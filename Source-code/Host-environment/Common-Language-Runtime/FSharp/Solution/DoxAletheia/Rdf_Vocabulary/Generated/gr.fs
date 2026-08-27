namespace http.purl.org.goodrelations.v1.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module gr =
    let _namespace_iri = Namespace_Iri gr |> NamespaceIRI
    /// <summary>
    ///   <para>gr:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#">http://purl.org/goodrelations/v1#</seealso>
    let _prefix_iri = Prefixed_Name(gr, "") |> PrefixedName

    /// <summary>
    ///   <para>gr:ActualProductOrServiceInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Class</para>
    ///   <para>"DEPRECATED - This class is superseded by gr:Individual. Replace all occurrences of gr:ActualProductOrServiceInstance by gr:Individual, if possible."</para>
    /// labels<para>"Actual product or service instance (DEPRECATED)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#ActualProductOrServiceInstance">http://purl.org/goodrelations/v1#ActualProductOrServiceInstance</seealso>
    let ActualProductOrServiceInstance =
        Prefixed_Name(gr, "ActualProductOrServiceInstance") |> PrefixedName

    /// <summary>
    ///   <para>gr:AmericanExpress</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethodCreditCard</para>
    ///   <para>"Payment by credit or debit cards issued by the American Express network."</para>
    /// labels<para>"American Express (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#AmericanExpress">http://purl.org/goodrelations/v1#AmericanExpress</seealso>
    let AmericanExpress = Prefixed_Name(gr, "AmericanExpress") |> PrefixedName
    /// <summary>
    ///   <para>gr:Brand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A brand is the identity of a specific product, service, or business. Use foaf:logo for attaching a brand logo and gr:name or rdfs:label for attaching the brand name.
    ///
    /// (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Brand)"</para>
    /// labels<para>"Brand"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Brand">http://purl.org/goodrelations/v1#Brand</seealso>
    let Brand = Prefixed_Name(gr, "Brand") |> PrefixedName
    /// <summary>
    ///   <para>gr:Business</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessEntityType</para>
    ///   <para>"The gr:BusinessEntityType representing such agents that are themselves offering commercial services or products on the market. Usually, businesses are characterized by the fact that they are officially registered with the public administration and strive for profits by their activities."</para>
    /// labels<para>"Business (business entity type)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Business">http://purl.org/goodrelations/v1#Business</seealso>
    let Business = Prefixed_Name(gr, "Business") |> PrefixedName
    /// <summary>
    ///   <para>gr:BusinessEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:class</para>
    ///   <para>"An instance of this class represents the legal agent making (or seeking) a particular offering. This can be a legal body or a person. A business entity has at least a primary mailing address and contact details. For this, typical address standards (vCard) and location data (geo, WGS84) can be attached. Note that the location of the business entity is not necessarily the location from which the product or service is being available (e.g. the branch or store). Use gr:Location for stores and branches.
    ///
    /// Example: Siemens Austria AG, Volkswagen Ltd., Peter Miller's Cell phone Shop LLC
    ///
    /// Compatibility with schema.org: This class is equivalent to the union of http://schema.org/Person and http://schema.org/Organization.
    /// "</para>
    ///   <para>"An instance of this class represents the legal agent making (or seeking) a particular offering. This can be a legal body or a person. A business entity has at least a primary mailing address and contact details. For this, typical address standards (vCard) and location data (geo, WGS84) can be attached. Note that the location of the business entity is not necessarily the location from which the product or service is being available."</para>
    ///   <para>"GoodRelation: This class represents the legal agent making (or seeking) a particular offering. This can be a legal body or a person. A business entity has at least a primary mailing address and contact"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Business Entity"</para><para>"Juristische Person"</para><para>"Business entity"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#BusinessEntity">http://purl.org/goodrelations/v1#BusinessEntity</seealso>
    let BusinessEntity = Prefixed_Name(gr, "BusinessEntity") |> PrefixedName
    /// <summary>
    ///   <para>gr:BusinessEntityType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A business entity type is a conceptual entity representing the legal form, the size, the main line of business, the position in the value chain, or any combination thereof, of a gr:BusinessEntity. From the ontological point of view, business entity types are mostly roles that a business entity has in the market. Business entity types are important for specifying eligible customers, since a gr:Offering is often valid only for business entities of a certain size, legal structure, or role in the value chain.
    ///
    /// Examples: Consumers, Retailers, Wholesalers, or Public Institutions"</para>
    /// labels<para>"Business entity type"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#BusinessEntityType">http://purl.org/goodrelations/v1#BusinessEntityType</seealso>
    let BusinessEntityType = Prefixed_Name(gr, "BusinessEntityType") |> PrefixedName
    /// <summary>
    ///   <para>gr:BusinessFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The business function specifies the type of activity or access (i.e., the bundle of rights) offered by the gr:BusinessEntity on the gr:ProductOrService through the gr:Offering. Typical are sell, rental or lease, maintenance or repair, manufacture / produce, recycle / dispose, engineering / construction, or installation.
    ///
    /// Licenses and other proprietary specifications of access rights are also instances of this class.
    ///
    /// Examples: A particular offering made by Miller Rentals Ltd. says that they (1) sell Volkswagen Golf convertibles, (2) lease out a particular Ford pick-up truck, and (3) dispose car wrecks of any make and model."</para>
    /// labels<para>"Business function"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#BusinessFunction">http://purl.org/goodrelations/v1#BusinessFunction</seealso>
    let BusinessFunction = Prefixed_Name(gr, "BusinessFunction") |> PrefixedName
    /// <summary>
    ///   <para>gr:Buy</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessFunction</para>
    ///   <para>"This gr:BusinessFunction indicates that the gr:BusinessEntity is in general interested in purchasing the specified gr:ProductOrService.
    /// DEPRECATED. Use gr:seeks instead."</para>
    /// labels<para>"Buy (business function, DEPRECATED)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Buy">http://purl.org/goodrelations/v1#Buy</seealso>
    let Buy = Prefixed_Name(gr, "Buy") |> PrefixedName

    /// <summary>
    ///   <para>gr:ByBankTransferInAdvance</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethod</para>
    ///   <para>"Payment by bank transfer in advance, i.e., the offering gr:BusinessEntity will inform the buying party about their bank account details and will deliver the goods upon receipt of the due amount.
    /// This is equivalent to payment by wire transfer."</para>
    /// labels<para>"By bank transfer in advance (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#ByBankTransferInAdvance">http://purl.org/goodrelations/v1#ByBankTransferInAdvance</seealso>
    let ByBankTransferInAdvance =
        Prefixed_Name(gr, "ByBankTransferInAdvance") |> PrefixedName

    /// <summary>
    ///   <para>gr:ByInvoice</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethod</para>
    ///   <para>"Payment by bank transfer after delivery, i.e., the offering gr:BusinessEntity will deliver first, inform the buying party about the due amount and their bank account details, and expect payment shortly after delivery."</para>
    /// labels<para>"By invoice (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#ByInvoice">http://purl.org/goodrelations/v1#ByInvoice</seealso>
    let ByInvoice = Prefixed_Name(gr, "ByInvoice") |> PrefixedName
    /// <summary>
    ///   <para>gr:COD</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethod</para>
    ///   <para>"Collect on delivery / Cash on delivery - A payment method where the recipient of goods pays at the time of delivery. Usually, the amount of money is collected by the transportation company handling the goods."</para>
    /// labels<para>"COD (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#COD">http://purl.org/goodrelations/v1#COD</seealso>
    let COD = Prefixed_Name(gr, "COD") |> PrefixedName
    /// <summary>
    ///   <para>gr:Cash</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethod</para>
    ///   <para>"Payment by cash upon delivery or pickup."</para>
    /// labels<para>"Cash (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Cash">http://purl.org/goodrelations/v1#Cash</seealso>
    let Cash = Prefixed_Name(gr, "Cash") |> PrefixedName
    /// <summary>
    ///   <para>gr:CheckInAdvance</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethod</para>
    ///   <para>"Payment by sending a check in advance, i.e., the offering gr:BusinessEntity will deliver the goods upon receipt of a check over the due amount. There are variations in handling payment by check - sometimes, shipment will be upon receipt of the check as a document, sometimes the shipment will take place only upon successful crediting of the check."</para>
    /// labels<para>"Check in advance (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#CheckInAdvance">http://purl.org/goodrelations/v1#CheckInAdvance</seealso>
    let CheckInAdvance = Prefixed_Name(gr, "CheckInAdvance") |> PrefixedName

    /// <summary>
    ///   <para>gr:ConstructionInstallation</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessFunction</para>
    ///   <para>"This gr:BusinessFunction indicates that the gr:BusinessEntity offers (or seeks) the construction and/or installation of the specified gr:ProductOrService at the customer's location."</para>
    /// labels<para>"Construction / installation (business function)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#ConstructionInstallation">http://purl.org/goodrelations/v1#ConstructionInstallation</seealso>
    let ConstructionInstallation =
        Prefixed_Name(gr, "ConstructionInstallation") |> PrefixedName

    /// <summary>
    ///   <para>gr:DHL</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DeliveryModeParcelService</para>
    ///   <para>"Delivery via the parcel service DHL."</para>
    /// labels<para>"DHL (delivery method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DHL">http://purl.org/goodrelations/v1#DHL</seealso>
    let DHL = Prefixed_Name(gr, "DHL") |> PrefixedName
    /// <summary>
    ///   <para>gr:DayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The day of the week, used to specify  to which day the opening hours of a gr:OpeningHoursSpecification refer.
    ///
    /// Examples: Monday, Tuesday, Wednesday,..."</para>
    /// labels<para>"Day of week"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DayOfWeek">http://purl.org/goodrelations/v1#DayOfWeek</seealso>
    let DayOfWeek = Prefixed_Name(gr, "DayOfWeek") |> PrefixedName

    /// <summary>
    ///   <para>gr:DeliveryChargeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A delivery charge specification is a conceptual entity that specifies the additional costs asked for the delivery of a given gr:Offering using a particular gr:DeliveryMethod by the respective gr:BusinessEntity. A delivery charge specification is characterized by (1) a monetary amount per order, specified as a literal value of type float in combination with a currency, (2) the delivery method, (3) the target country or region, and (4)  whether this charge includes local sales taxes, namely VAT.
    /// A gr:Offering may be linked to multiple gr:DeliveryChargeSpecification nodes that specify alternative charges for disjoint combinations of target countries or regions, and delivery methods.
    ///
    /// Examples: Delivery by direct download is free of charge worldwide, delivery by UPS to Germany is 10 Euros per order, delivery by mail within the US is 5 Euros per order.
    ///
    /// The total amount of this charge is specified as a float value of the gr:hasCurrencyValue property. The currency is specified via the gr:hasCurrency datatype property. Whether the price includes VAT or not is indicated by the gr:valueAddedTaxIncluded property. The gr:DeliveryMethod to which this charge applies is specified using the gr:appliesToDeliveryMethod object property. The region or regions to which this charge applies is specified using the gr:eligibleRegions property, which uses ISO 3166-1 and ISO 3166-2 codes.
    ///
    /// If the price can only be given as a range, use gr:hasMaxCurrencyValue and gr:hasMinCurrencyValue for the upper and lower bounds.
    ///
    /// Important: When querying for the price, always use gr:hasMaxCurrencyValue and gr:hasMinCurrencyValue."</para>
    /// labels<para>"Delivery charge specification"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DeliveryChargeSpecification">http://purl.org/goodrelations/v1#DeliveryChargeSpecification</seealso>
    let DeliveryChargeSpecification =
        Prefixed_Name(gr, "DeliveryChargeSpecification") |> PrefixedName

    /// <summary>
    ///   <para>gr:DeliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A delivery method is a standardized procedure for transferring the product or service to the destination of fulfilment chosen by the customer. Delivery methods are characterized by the means of transportation used, and by the organization or group that is the contracting party for the sending gr:BusinessEntity (this is important, since the contracted party may subcontract the fulfilment to smaller, regional businesses).
    ///
    /// Examples: Delivery by mail, delivery by direct download, delivery by UPS"</para>
    /// labels<para>"Delivery method"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DeliveryMethod">http://purl.org/goodrelations/v1#DeliveryMethod</seealso>
    let DeliveryMethod = Prefixed_Name(gr, "DeliveryMethod") |> PrefixedName

    /// <summary>
    ///   <para>gr:DeliveryModeDirectDownload</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DeliveryMethod</para>
    ///   <para>"Delivery of the goods via direct download from the Internet, i.e., the offering gr:BusinessEntity provides the buying party with details on how to retrieve the goods online. Connection fees and other costs of using the infrastructure are to be carried by the buying party."</para>
    /// labels<para>"Delivery mode direct download (delivery method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DeliveryModeDirectDownload">http://purl.org/goodrelations/v1#DeliveryModeDirectDownload</seealso>
    let DeliveryModeDirectDownload =
        Prefixed_Name(gr, "DeliveryModeDirectDownload") |> PrefixedName

    /// <summary>
    ///   <para>gr:DeliveryModeFreight</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DeliveryMethod</para>
    ///   <para>"Delivery by an unspecified air, sea, or ground freight carrier or cargo company."</para>
    /// labels<para>"Delivery mode freight (delivery method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DeliveryModeFreight">http://purl.org/goodrelations/v1#DeliveryModeFreight</seealso>
    let DeliveryModeFreight = Prefixed_Name(gr, "DeliveryModeFreight") |> PrefixedName
    /// <summary>
    ///   <para>gr:DeliveryModeMail</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DeliveryMethod</para>
    ///   <para>"Delivery via regular mail service (private or public postal services)."</para>
    /// labels<para>"Delivery mode mail (delivery method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DeliveryModeMail">http://purl.org/goodrelations/v1#DeliveryModeMail</seealso>
    let DeliveryModeMail = Prefixed_Name(gr, "DeliveryModeMail") |> PrefixedName
    /// <summary>
    ///   <para>gr:DeliveryModeOwnFleet</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DeliveryMethod</para>
    ///   <para>"Delivery of the goods by using a fleet of vehicles either owned and operated or subcontracted by the gr:BusinessEntity."</para>
    /// labels<para>"Delivery mode own fleet (delivery method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DeliveryModeOwnFleet">http://purl.org/goodrelations/v1#DeliveryModeOwnFleet</seealso>
    let DeliveryModeOwnFleet = Prefixed_Name(gr, "DeliveryModeOwnFleet") |> PrefixedName

    /// <summary>
    ///   <para>gr:DeliveryModeParcelService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A private parcel service as the delivery mode available for a certain offering.
    ///
    /// Examples: UPS, DHL"</para>
    /// labels<para>"Delivery mode parcel service"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DeliveryModeParcelService">http://purl.org/goodrelations/v1#DeliveryModeParcelService</seealso>
    let DeliveryModeParcelService =
        Prefixed_Name(gr, "DeliveryModeParcelService") |> PrefixedName

    /// <summary>
    ///   <para>gr:DeliveryModePickUp</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DeliveryMethod</para>
    ///   <para>"Delivery of the goods by picking them up at one of the stores etc. (gr:Location) during the opening hours as specified by respective instances of gr:OpeningHoursSpecification."</para>
    /// labels<para>"Delivery mode pick up (delivery method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DeliveryModePickUp">http://purl.org/goodrelations/v1#DeliveryModePickUp</seealso>
    let DeliveryModePickUp = Prefixed_Name(gr, "DeliveryModePickUp") |> PrefixedName
    /// <summary>
    ///   <para>gr:DinersClub</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethodCreditCard</para>
    ///   <para>"Payment by credit or debit cards issued by the Diner's Club network."</para>
    /// labels<para>"Diners Club (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DinersClub">http://purl.org/goodrelations/v1#DinersClub</seealso>
    let DinersClub = Prefixed_Name(gr, "DinersClub") |> PrefixedName
    /// <summary>
    ///   <para>gr:DirectDebit</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethod</para>
    ///   <para>"Payment by direct debit, i.e., the buying party will inform the offering gr:BusinessEntity about its bank account details and authorizes the gr:BusinessEntity to collect the agreed amount directly from that account."</para>
    /// labels<para>"Direct debit (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#DirectDebit">http://purl.org/goodrelations/v1#DirectDebit</seealso>
    let DirectDebit = Prefixed_Name(gr, "DirectDebit") |> PrefixedName
    /// <summary>
    ///   <para>gr:Discover</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethodCreditCard</para>
    ///   <para>"Payment by credit or debit cards issued by the Discover network."</para>
    /// labels<para>"Discover (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Discover">http://purl.org/goodrelations/v1#Discover</seealso>
    let Discover = Prefixed_Name(gr, "Discover") |> PrefixedName
    /// <summary>
    ///   <para>gr:Dispose</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessFunction</para>
    ///   <para>"This gr:BusinessFunction indicates that the gr:BusinessEntity offers (or seeks) the acceptance of the specified gr:ProductOrService for proper disposal, recycling, or any other kind of allowed usages, freeing the current owner from all rights and obligations of ownership."</para>
    /// labels<para>"Dispose (business function)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Dispose">http://purl.org/goodrelations/v1#Dispose</seealso>
    let Dispose = Prefixed_Name(gr, "Dispose") |> PrefixedName
    /// <summary>
    ///   <para>gr:Enduser</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessEntityType</para>
    ///   <para>"The gr:BusinessEntityType representing such agents that are purchasing the good or service for private consumption, in particular not for resale or for usage within an industrial enterprise. By default, a Business Entity is an Enduser."</para>
    /// labels<para>"Enduser (business entity type)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Enduser">http://purl.org/goodrelations/v1#Enduser</seealso>
    let Enduser = Prefixed_Name(gr, "Enduser") |> PrefixedName
    /// <summary>
    ///   <para>gr:FederalExpress</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DeliveryModeParcelService</para>
    ///   <para>"Delivery via the parcel service Federal Express."</para>
    /// labels<para>"Federal Express (delivery method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#FederalExpress">http://purl.org/goodrelations/v1#FederalExpress</seealso>
    let FederalExpress = Prefixed_Name(gr, "FederalExpress") |> PrefixedName
    /// <summary>
    ///   <para>gr:Friday</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DayOfWeek</para>
    ///   <para>"Friday as a day of the week."</para>
    /// labels<para>"Friday (day of week)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Friday">http://purl.org/goodrelations/v1#Friday</seealso>
    let Friday = Prefixed_Name(gr, "Friday") |> PrefixedName
    /// <summary>
    ///   <para>gr:GoogleCheckout</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethod</para>
    ///   <para>"Payment via the Google Checkout payment service."</para>
    /// labels<para>"Google Checkout (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#GoogleCheckout">http://purl.org/goodrelations/v1#GoogleCheckout</seealso>
    let GoogleCheckout = Prefixed_Name(gr, "GoogleCheckout") |> PrefixedName
    /// <summary>
    ///   <para>gr:Individual</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A gr:Individual is an actual product or service instance, i.e., a single identifiable object or action that creates some increase in utility (in the economic sense) for the individual possessing or using this very object (product) or for the individual in whose favor this very action is being taken (service). Products or services are types of goods in the economic sense. For an overview of goods and commodities in economics, see Milgate (1987).
    ///
    /// Examples: MyThinkpad T60, the pint of beer standing in front of me, my Volkswagen Golf, the haircut that I received or will be receiving at a given date and time.
    ///
    /// Note 1: In many cases, product or service instances are not explicitly exposed on the Web but only claimed to exist (i.e. existentially quantified). In this case, use gr:SomeItems.
    /// Note 2: This class is the new, shorter form of the former gr:ActualProductOrServiceInstance.
    ///
    /// Compatibility with schema.org: This class is a subclass of http://schema.org/Product."</para>
    /// labels<para>"Individual"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Individual">http://purl.org/goodrelations/v1#Individual</seealso>
    let Individual = Prefixed_Name(gr, "Individual") |> PrefixedName
    /// <summary>
    ///   <para>gr:JCB</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethodCreditCard</para>
    ///   <para>"Payment by credit or debit cards issued by the JCB network."</para>
    /// labels<para>"JCB (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#JCB">http://purl.org/goodrelations/v1#JCB</seealso>
    let JCB = Prefixed_Name(gr, "JCB") |> PrefixedName
    /// <summary>
    ///   <para>gr:Labor-BringIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:WarrantyScope</para>
    ///   <para>"In case of a defect or malfunction, the buying party has the right to transport the good to a service location determined by the the selling gr:BusinessEntity and will be charged only for parts and materials needed to fix the problem. Labor will be covered by the selling business entity or one of its partnering business entities.
    ///
    /// Note: This is just a rough classification for filtering offers. It is up to the buying party to check the exact scope and terms and conditions of the gr:WarrantyPromise."</para>
    /// labels<para>"Labor / bring-in (warranty scope)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Labor-BringIn">http://purl.org/goodrelations/v1#Labor-BringIn</seealso>
    let Labor_BringIn = Prefixed_Name(gr, "Labor-BringIn") |> PrefixedName
    /// <summary>
    ///   <para>gr:LeaseOut</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessFunction</para>
    ///   <para>"This gr:BusinessFunction indicates that the gr:BusinessEntity offers (or seeks) the temporary right to use the specified gr:ProductOrService."</para>
    /// labels<para>"Lease Out (business function)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#LeaseOut">http://purl.org/goodrelations/v1#LeaseOut</seealso>
    let LeaseOut = Prefixed_Name(gr, "LeaseOut") |> PrefixedName
    /// <summary>
    ///   <para>gr:License</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A license is the specification of a bundle of rights that determines the type of activity or access offered by the gr:BusinessEntity on the gr:ProductOrService through the gr:Offering.
    ///
    /// Licenses can be standardized (e.g. LPGL, Creative Commons, ...), vendor-specific, or individually defined for a single offer or product. Whether there is a fee for obtaining the license is specified using the gr:UnitPriceSpecification attached to the gr:Offering. Use foaf:page for linking to a document containing the license, e.g. in PDF or HTML."</para>
    /// labels<para>"License"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#License">http://purl.org/goodrelations/v1#License</seealso>
    let License = Prefixed_Name(gr, "License") |> PrefixedName
    /// <summary>
    ///   <para>gr:Location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A location is a point or area of interest from which a particular product or service is available, e.g. a store, a bus stop, a gas station, or a ticket booth. The difference to gr:BusinessEntity is that the gr:BusinessEntity is the legal entity (e.g. a person or corporation) making the offer, while gr:Location is the store, office, or place. A chain restaurant will e.g. have one legal entity but multiple restaurant locations. Locations are characterized by an address or geographical position and a set of opening hour specifications for various days of the week.
    ///
    /// Example: A rental car company may offer the Business Function Lease Out of cars from two locations, one in Fort Myers, Florida, and one in Boston, Massachussetts. Both stations are open 7:00 - 23:00 Mondays through Saturdays.
    ///
    /// Note: Typical address standards (vcard) and location data (geo, WGC84) should be attached to a gr:Location node. Since there already exist established vocabularies for this, the GoodRelations ontology does not provide respective attributes. Instead, the use of respective vocabularies is recommended. However, the gr:hasGlobalLocationNumber property is  provided for linking to public identifiers for business locations.
    ///
    /// Compatibility with schema.org: This class is equivalent to http://schema.org/Place."</para>
    /// labels<para>"Location"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Location">http://purl.org/goodrelations/v1#Location</seealso>
    let Location = Prefixed_Name(gr, "Location") |> PrefixedName

    /// <summary>
    ///   <para>gr:LocationOfSalesOrServiceProvisioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DEPRECATED - This class is superseded by gr:Location. Replace all occurrences of gr:LocationOfSalesOrServiceProvisioning by gr:Location, if possible."</para>
    /// labels<para>"Location of sales or service provisioning (DEPRECATED)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#LocationOfSalesOrServiceProvisioning">http://purl.org/goodrelations/v1#LocationOfSalesOrServiceProvisioning</seealso>
    let LocationOfSalesOrServiceProvisioning =
        Prefixed_Name(gr, "LocationOfSalesOrServiceProvisioning") |> PrefixedName

    /// <summary>
    ///   <para>gr:Maintain</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessFunction</para>
    ///   <para>"This gr:BusinessFunction indicates that the gr:BusinessEntity offers (or seeks) typical maintenance tasks for the specified gr:ProductOrService. Maintenance tasks are actions that undo or compensate for wear or other deterioriation caused by regular usage, in order to restore the originally intended function of the product, or to prevent outage or malfunction."</para>
    /// labels<para>"Maintain (business function)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Maintain">http://purl.org/goodrelations/v1#Maintain</seealso>
    let Maintain = Prefixed_Name(gr, "Maintain") |> PrefixedName
    /// <summary>
    ///   <para>gr:MasterCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethodCreditCard</para>
    ///   <para>"Payment by credit or debit cards issued by the MasterCard network."</para>
    /// labels<para>"MasterCard (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#MasterCard">http://purl.org/goodrelations/v1#MasterCard</seealso>
    let MasterCard = Prefixed_Name(gr, "MasterCard") |> PrefixedName
    /// <summary>
    ///   <para>gr:Monday</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DayOfWeek</para>
    ///   <para>"Monday as a day of the week."</para>
    /// labels<para>"Monday (day of week)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Monday">http://purl.org/goodrelations/v1#Monday</seealso>
    let Monday = Prefixed_Name(gr, "Monday") |> PrefixedName
    /// <summary>
    ///   <para>gr:N-Ary-Relations</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is the superclass for all classes that are placeholders for n-ary relations, which OWL cannot represent.
    /// DEPRECATED. Do not use this class in data or queries."</para>
    /// labels<para>"N-ary relations (DEPRECATED)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#N-Ary-Relations">http://purl.org/goodrelations/v1#N-Ary-Relations</seealso>
    let N_Ary_Relations = Prefixed_Name(gr, "N-Ary-Relations") |> PrefixedName
    /// <summary>
    ///   <para>gr:Offering</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An offering represents the public, not necessarily binding, not necessarily exclusive, announcement by a gr:BusinessEntity to provide (or seek) a certain gr:BusinessFunction for a certain gr:ProductOrService to a specified target audience. An offering is specified by the type of product or service or bundle it refers to, what business function is being offered (sales, rental, ...), and a set of commercial properties. It can either refer to
    /// (1) a clearly specified instance (gr:Individual),
    /// (2) to a set of anonymous instances of a given type (gr:SomeItems),
    /// (3) a product model specification (gr:ProductOrServiceModel), see also section 3.3.3 of the GoodRelations Technical Report.
    ///
    /// An offering may be constrained in terms of the eligible type of business partner, countries, quantities, and other commercial properties. The definition of the commercial properties, the type of product offered, and the business function are explained in other parts of this vocabulary in more detail.
    ///
    /// Example: Peter Miller offers to repair TV sets made by Siemens, Volkswagen Innsbruck sells a particular instance of a Volkswagen Golf at $10,000.
    ///
    /// Compatibility with schema.org: This class is a superclass to http://schema.org/Offer, since gr:Offering can also represent demand."</para>
    /// labels<para>"Oferta"</para><para>"Offering"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Offering">http://purl.org/goodrelations/v1#Offering</seealso>
    let Offering = Prefixed_Name(gr, "Offering") |> PrefixedName

    /// <summary>
    ///   <para>gr:OpeningHoursSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a conceptual entity that holds together all information about the opening hours on a given day (gr:DayOfWeek)."</para>
    /// labels<para>"Opening hours specification"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#OpeningHoursSpecification">http://purl.org/goodrelations/v1#OpeningHoursSpecification</seealso>
    let OpeningHoursSpecification =
        Prefixed_Name(gr, "OpeningHoursSpecification") |> PrefixedName

    /// <summary>
    ///   <para>gr:PartsAndLabor-BringIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:WarrantyScope</para>
    ///   <para>"In case of a defect or malfunction, the buying party has the right to transport the good to a service location determined by the the selling gr:BusinessEntity and will not be be charged for labor, parts, and materials needed to fix the problem. All those costs will be covered by the selling business entity or one of its partnering business entities.
    ///
    /// Note: This is just a rough classification for filtering offers. It is up to the buying party to check the exact scope and terms and conditions of the gr:WarrantyPromise."</para>
    /// labels<para>"Parts and labor / bring-in (warranty scope)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PartsAndLabor-BringIn">http://purl.org/goodrelations/v1#PartsAndLabor-BringIn</seealso>
    let PartsAndLabor_BringIn =
        Prefixed_Name(gr, "PartsAndLabor-BringIn") |> PrefixedName

    /// <summary>
    ///   <para>gr:PartsAndLabor-PickUp</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:WarrantyScope</para>
    ///   <para>"In case of a defect or malfunction, the buying party has the right to request from the selling gr:Business Entity to pick-up the good from its current location to a suitable service location, where the functionality of the good will be restored. All transportation, labor, parts, and materials needed to fix the problem will be covered by the selling business entity or one of its partnering business entities.
    ///
    /// Note: This is just a rough classification for filtering offers. It is up to the buying party to check the exact scope and terms and conditions of the gr:WarrantyPromise."</para>
    /// labels<para>"Parts and labor / pick up (warranty scope)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PartsAndLabor-PickUp">http://purl.org/goodrelations/v1#PartsAndLabor-PickUp</seealso>
    let PartsAndLabor_PickUp = Prefixed_Name(gr, "PartsAndLabor-PickUp") |> PrefixedName
    /// <summary>
    ///   <para>gr:PayPal</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethod</para>
    ///   <para>"Payment via the PayPal payment service."</para>
    /// labels<para>"PayPal (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PayPal">http://purl.org/goodrelations/v1#PayPal</seealso>
    let PayPal = Prefixed_Name(gr, "PayPal") |> PrefixedName
    /// <summary>
    ///   <para>gr:PaySwarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethod</para>
    ///   <para>"Payment via the PaySwarm distributed micropayment service."</para>
    /// labels<para>"PaySwarm (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PaySwarm">http://purl.org/goodrelations/v1#PaySwarm</seealso>
    let PaySwarm = Prefixed_Name(gr, "PaySwarm") |> PrefixedName

    /// <summary>
    ///   <para>gr:PaymentChargeSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A payment charge specification is a conceptual entity that specifies the additional costs asked for settling the payment after accepting a given gr:Offering using a particular gr:PaymentMethod. A payment charge specification is characterized by (1) a monetary amount per order specified as a literal value of type float in combination with a Currency, (2) the payment method, and (3) a whether this charge includes local sales taxes, namely VAT.
    /// A gr:Offering may be linked to multiple payment charge specifications that specify alternative charges for various payment methods.
    ///
    /// Examples: Payment by VISA or Mastercard costs a fee of 3 Euros including VAT, payment by bank transfer in advance is free of charge.
    ///
    /// The total amount of this surcharge is specified as a float value of the gr:hasCurrencyValue property. The currency is specified via the gr:hasCurrency datatype property. Whether the price includes VAT or not is indicated by the gr:valueAddedTaxIncluded datatype property. The gr:PaymentMethod to which this charge applies is specified using the gr:appliesToPaymentMethod object property.
    ///
    /// If the price can only be given as a range, use gr:hasMaxCurrencyValue and gr:hasMinCurrencyValue for the upper and lower bounds.
    ///
    /// Important: When querying for the price, always use gr:hasMaxCurrencyValue and gr:hasMinCurrencyValue."</para>
    /// labels<para>"Payment charge specification"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PaymentChargeSpecification">http://purl.org/goodrelations/v1#PaymentChargeSpecification</seealso>
    let PaymentChargeSpecification =
        Prefixed_Name(gr, "PaymentChargeSpecification") |> PrefixedName

    /// <summary>
    ///   <para>gr:PaymentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A payment method is a standardized procedure for transferring the monetary amount for a purchase. Payment methods are characterized by the legal and technical structures used, and by the organization or group carrying out the transaction. This element is mostly used for specifying the types of payment accepted by a gr:BusinessEntity.
    ///
    /// Examples: VISA, MasterCard, Diners, cash, or bank transfer in advance."</para>
    /// labels<para>"Payment method"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PaymentMethod">http://purl.org/goodrelations/v1#PaymentMethod</seealso>
    let PaymentMethod = Prefixed_Name(gr, "PaymentMethod") |> PrefixedName

    /// <summary>
    ///   <para>gr:PaymentMethodCreditCard</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The subclass of gr:PaymentMethod represents all variants and brands of credit or debit cards as a standardized procedure for transferring the monetary amount for a purchase. It is mostly used for specifying the types of payment accepted by a gr:Business Entity.
    ///
    /// Examples: VISA, MasterCard, or American Express."</para>
    /// labels<para>"Payment method credit card"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PaymentMethodCreditCard">http://purl.org/goodrelations/v1#PaymentMethodCreditCard</seealso>
    let PaymentMethodCreditCard =
        Prefixed_Name(gr, "PaymentMethodCreditCard") |> PrefixedName

    /// <summary>
    ///   <para>gr:PriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The superclass of all price specifications"</para>
    ///   <para>"The superclass of all price specifications."</para>
    /// labels<para>"Price specification"</para><para>"Especificación del precio"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PriceSpecification">http://purl.org/goodrelations/v1#PriceSpecification</seealso>
    let PriceSpecification = Prefixed_Name(gr, "PriceSpecification") |> PrefixedName
    /// <summary>
    ///   <para>gr:ProductOrService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The superclass of all classes describing products or services types, either by nature or purpose. Examples for such subclasses are "TV set", "vacuum cleaner", etc. An instance of this class can be either an actual product or service (gr:Individual), a placeholder instance for unknown instances of a mass-produced commodity (gr:SomeItems), or a model / prototype specification (gr:ProductOrServiceModel). When in doubt, use gr:SomeItems.
    ///
    /// Examples:
    /// a) MyCellphone123, i.e. my personal, tangible cell phone (gr:Individual)
    /// b) Siemens1234, i.e. the Siemens cell phone make and model 1234 (gr:ProductOrServiceModel)
    /// c) dummyCellPhone123 as a placeholder for actual instances of a certain kind of cell phones (gr:SomeItems)
    ///
    /// Note: Your first choice for specializations of gr:ProductOrService should be http://www.productontology.org.
    ///
    /// Compatibility with schema.org: This class is (approximately) equivalent to http://schema.org/Product."</para>
    /// labels<para>"Product or service"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#ProductOrService">http://purl.org/goodrelations/v1#ProductOrService</seealso>
    let ProductOrService = Prefixed_Name(gr, "ProductOrService") |> PrefixedName

    /// <summary>
    ///   <para>gr:ProductOrServiceModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A product or service model is a intangible entity that specifies some characteristics of a group of similar, usually mass-produced products, in the sense of a prototype. In case of mass-produced products, there exists a relation gr:hasMakeAndModel between the actual product or service (gr:Individual or gr:SomeItems) and the prototype (gr:ProductOrServiceModel). GoodRelations treats product or service models as "prototypes" instead of a completely separate kind of entities, because this allows using the same domain-specific properties (e.g. gr:weight) for describing makes and models and for describing actual products.
    ///
    /// Examples: Ford T, Volkswagen Golf, Sony Ericsson W123 cell phone
    ///
    /// Note: An actual product or service (gr:Individual) by default shares the features of its model (e.g. the weight). However, this requires non-standard reasoning. See http://wiki.goodrelations-vocabulary.org/Axioms for respective rule sets.
    ///
    /// Compatibility with schema.org: This class is (approximately) a subclass of http://schema.org/Product."</para>
    /// labels<para>"Product or service model"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#ProductOrServiceModel">http://purl.org/goodrelations/v1#ProductOrServiceModel</seealso>
    let ProductOrServiceModel =
        Prefixed_Name(gr, "ProductOrServiceModel") |> PrefixedName

    /// <summary>
    ///   <para>gr:ProductOrServicesSomeInstancesPlaceholder</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"DEPRECATED - This class is superseded by gr:SomeItems. Replace all occurrences of gr:ProductOrServicesSomeInstancesPlaceholder by gr:SomeItems, if possible."</para>
    /// labels<para>"Product or services some instances placeholder (DEPRECATED)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#ProductOrServicesSomeInstancesPlaceholder">http://purl.org/goodrelations/v1#ProductOrServicesSomeInstancesPlaceholder</seealso>
    let ProductOrServicesSomeInstancesPlaceholder =
        Prefixed_Name(gr, "ProductOrServicesSomeInstancesPlaceholder") |> PrefixedName

    /// <summary>
    ///   <para>gr:ProvideService</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessFunction</para>
    ///   <para>"This gr:BusinessFunction indicates that the gr:BusinessEntity offers (or seeks) the respective type of service.
    ///
    /// Note: Maintain and Repair are also types of Services. However, products and services ontologies often provide classes for tangible products as well as for types of services. The business function gr:ProvideService is to be used with such goods that are services, while gr:Maintain and gr:Repair can be used with goods for which only the class of product exists in the ontology, but not the respective type of service.
    ///
    /// Example: Car maintenance could be expressed both as "provide the service car maintenance" or "maintain cars"."</para>
    /// labels<para>"Provide service (business function)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#ProvideService">http://purl.org/goodrelations/v1#ProvideService</seealso>
    let ProvideService = Prefixed_Name(gr, "ProvideService") |> PrefixedName
    /// <summary>
    ///   <para>gr:PublicHolidays</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DayOfWeek</para>
    ///   <para>"A placeholder for all official public holidays at the gr:Location. This allows specifying the opening hours on public holidays. If a given day is a public holiday, this specification supersedes the opening hours for the respective day of the week."</para>
    /// labels<para>"Public holidays (day of week)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PublicHolidays">http://purl.org/goodrelations/v1#PublicHolidays</seealso>
    let PublicHolidays = Prefixed_Name(gr, "PublicHolidays") |> PrefixedName
    /// <summary>
    ///   <para>gr:PublicInstitution</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessEntityType</para>
    ///   <para>"The gr:BusinessEntityType representing such agents that are part of the adminstration or owned by the public."</para>
    /// labels<para>"Public institution (business entity type)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#PublicInstitution">http://purl.org/goodrelations/v1#PublicInstitution</seealso>
    let PublicInstitution = Prefixed_Name(gr, "PublicInstitution") |> PrefixedName
    /// <summary>
    ///   <para>gr:QualitativeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A qualitative value is a predefined value for a product characteristic.
    ///
    /// Examples: the color "green" or the power cord plug type "US"; the garment sizes "S", "M", "L", and "XL".
    ///
    /// Note: Value sets are supported by creating subclasses of this class. Ordinal relations between values (gr:greater, gr:lesser, ...) are provided directly by GoodRelations.
    ///
    /// Compatibility with schema.org: This class is equivalent to http://schema.org/Enumeration."</para>
    /// labels<para>"Qualitative value"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#QualitativeValue">http://purl.org/goodrelations/v1#QualitativeValue</seealso>
    let QualitativeValue = Prefixed_Name(gr, "QualitativeValue") |> PrefixedName
    /// <summary>
    ///   <para>gr:QuantitativeValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A quantitative value is a numerical interval that represents the range of a certain gr:quantitativeProductOrServiceProperty in terms of the lower and upper bounds for a particular gr:ProductOrService. It is to be interpreted in combination with the respective unit of measurement. Most quantitative values are intervals even if they are in practice often treated as a single point value.
    ///
    /// Example: a weight between 10 and 25 kilogramms, a length between 10 and 15 milimeters.
    ///
    /// Compatibility with schema.org: This class is equivalent to http://schema.org/Quantity."</para>
    /// labels<para>"Quantitative value"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#QuantitativeValue">http://purl.org/goodrelations/v1#QuantitativeValue</seealso>
    let QuantitativeValue = Prefixed_Name(gr, "QuantitativeValue") |> PrefixedName

    /// <summary>
    ///   <para>gr:QuantitativeValueFloat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of this class is an actual float value for a quantitative property of a product. This instance is usually characterized by a minimal value, a maximal value, and a unit of measurement.
    ///
    /// Examples: The intervals "between 10.0  and 25.4 kilogramms" or "10.2 and 15.5 milimeters".
    ///
    /// Compatibility with schema.org: This class is a subclass of http://schema.org/Quantity."</para>
    /// labels<para>"Quantitative value float"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#QuantitativeValueFloat">http://purl.org/goodrelations/v1#QuantitativeValueFloat</seealso>
    let QuantitativeValueFloat =
        Prefixed_Name(gr, "QuantitativeValueFloat") |> PrefixedName

    /// <summary>
    ///   <para>gr:QuantitativeValueInteger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An instance of this class is an actual integer value for a quantitative property of a product. This instance is usually characterized by a minimal value, a maximal value, and a unit of measurement.
    ///
    /// Example: A seating capacity between 1 and 8 persons.
    ///
    /// Note: Users must keep in mind that ranges in here mean that ALL possible values in this interval are covered. (Sometimes, the actual commitment may be less than that: "We sell cars from 2 - 12 seats" does often not really mean that they have cars with 2,3,4,...12 seats.). Someone renting out two types of rowing boats, one that fits for 1 or 2 people, and another that must be operated by 4 people cannot claim to rent boats with a seating capacity between 1 and 4 people. He or she is offering two boat types for 1-2 and 4 persons.
    ///
    /// Compatibility with schema.org: This class is a subclass of http://schema.org/Quantity."</para>
    /// labels<para>"Quantitative value integer"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#QuantitativeValueInteger">http://purl.org/goodrelations/v1#QuantitativeValueInteger</seealso>
    let QuantitativeValueInteger =
        Prefixed_Name(gr, "QuantitativeValueInteger") |> PrefixedName

    /// <summary>
    ///   <para>gr:Repair</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessFunction</para>
    ///   <para>"This gr:BusinessFunction indicates that the gr:BusinessEntity offers (or seeks) the evaluation of the chances for repairing, and, if positive, repair of the specified gr:ProductOrService. Repairing means actions that restore the originally intended function of a product that suffers from outage or malfunction."</para>
    /// labels<para>"Repair (business function)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Repair">http://purl.org/goodrelations/v1#Repair</seealso>
    let Repair = Prefixed_Name(gr, "Repair") |> PrefixedName
    /// <summary>
    ///   <para>gr:Reseller</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessEntityType</para>
    ///   <para>"The gr:BusinessEntityType representing such agents that are purchasing the scope of products included in the gr:Offering for resale on the market. Resellers are also businesses, i.e., they are officially registered with the public administration and strive for profits by their activities."</para>
    /// labels<para>"Reseller (business entity type)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Reseller">http://purl.org/goodrelations/v1#Reseller</seealso>
    let Reseller = Prefixed_Name(gr, "Reseller") |> PrefixedName
    /// <summary>
    ///   <para>gr:Saturday</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DayOfWeek</para>
    ///   <para>"Saturday as a day of the week."</para>
    /// labels<para>"Saturday (day of week)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Saturday">http://purl.org/goodrelations/v1#Saturday</seealso>
    let Saturday = Prefixed_Name(gr, "Saturday") |> PrefixedName
    /// <summary>
    ///   <para>gr:Sell</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:BusinessFunction</para>
    ///   <para>"This gr:BusinessFunction indicates that the gr:BusinessEntity offers to permanently transfer all property rights on the specified gr:ProductOrService."</para>
    /// labels<para>"Sell (business function)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Sell">http://purl.org/goodrelations/v1#Sell</seealso>
    let Sell = Prefixed_Name(gr, "Sell") |> PrefixedName
    /// <summary>
    ///   <para>gr:SomeItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A placeholder instance for unknown instances of a mass-produced commodity. This is used as a computationally cheap work-around for such instances that are not individually exposed on the Web but just stated to exist (i.e., which are existentially quantified).
    ///
    /// Example: An instance of this class can represent an anonymous set of green Siemens1234 phones. It is different from the gr:ProductOrServiceModel Siemens1234, since this refers to the make and model, and it is different from a particular instance of this make and model (e.g. my individual phone) since the latter can be sold only once.
    ///
    /// Note: This class is the new, shorter form of the former gr:ProductOrServicesSomeInstancesPlaceholder.
    ///
    /// Compatibility with schema.org: This class is (approximately) a subclass of http://schema.org/Product."</para>
    /// labels<para>"Some items"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#SomeItems">http://purl.org/goodrelations/v1#SomeItems</seealso>
    let SomeItems = Prefixed_Name(gr, "SomeItems") |> PrefixedName
    /// <summary>
    ///   <para>gr:Sunday</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DayOfWeek</para>
    ///   <para>"Sunday as a day of the week."</para>
    /// labels<para>"Sunday (day of week)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Sunday">http://purl.org/goodrelations/v1#Sunday</seealso>
    let Sunday = Prefixed_Name(gr, "Sunday") |> PrefixedName
    /// <summary>
    ///   <para>gr:Thursday</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DayOfWeek</para>
    ///   <para>"Thursday as a day of the week."</para>
    /// labels<para>"Thursday (day of week)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Thursday">http://purl.org/goodrelations/v1#Thursday</seealso>
    let Thursday = Prefixed_Name(gr, "Thursday") |> PrefixedName
    /// <summary>
    ///   <para>gr:Tuesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DayOfWeek</para>
    ///   <para>"Tuesday as a day of the week."</para>
    /// labels<para>"Tuesday (day of week)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Tuesday">http://purl.org/goodrelations/v1#Tuesday</seealso>
    let Tuesday = Prefixed_Name(gr, "Tuesday") |> PrefixedName
    /// <summary>
    ///   <para>gr:TypeAndQuantityNode</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class collates all the information about a gr:ProductOrService included in a bundle. If a gr:Offering contains just one item, you can directly link from the gr:Offering to the gr:ProductOrService using gr:includes. If the offering contains multiple items, use an instance of this class for each component to indicate the quantity, unit of measurement, and type of product, and link from the gr:Offering via gr:includesObject.
    ///
    /// Example: An offering may include of 100g of Butter and 1 kg of potatoes, or 1 cell phone and 2 headsets."</para>
    /// labels<para>"Type and quantity node"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#TypeAndQuantityNode">http://purl.org/goodrelations/v1#TypeAndQuantityNode</seealso>
    let TypeAndQuantityNode = Prefixed_Name(gr, "TypeAndQuantityNode") |> PrefixedName
    /// <summary>
    ///   <para>gr:UPS</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DeliveryModeParcelService</para>
    ///   <para>"Delivery via the parcel service UPS."</para>
    /// labels<para>"UPS (delivery method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#UPS">http://purl.org/goodrelations/v1#UPS</seealso>
    let UPS = Prefixed_Name(gr, "UPS") |> PrefixedName

    /// <summary>
    ///   <para>gr:UnitPriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"A unit price specification is a conceptual entity that specifies the price asked for a given gr:Offering by the respective gr:Business Entity. An offering may be linked to multiple unit price specifications that specify alternative prices for non-overlapping sets of conditions (e.g. quantities or sales regions) or with differing validity periods.
    ///
    /// A unit price specification is characterized by (1) the lower and upper limits and the unit of measurement of the eligible quantity, (2) by a monetary amount per unit of the product or service, and (3)  whether this prices includes local sales taxes, namely VAT.
    ///
    /// Example: The price, including VAT, for 1 kg of a given material is 5 Euros per kg for 0 - 5 kg and 4 Euros for quantities above 5 kg.
    ///
    /// The eligible quantity interval for a given price is specified using the object property gr:hasEligibleQuantity, which points to an instance of gr:QuantitativeValue. The currency is specified using the gr:hasCurrency property, which points to an ISO 4217 currency code. The unit of measurement for the eligible quantity is specified using the gr:hasUnitOfMeasurement datatype property, which points to an UN/CEFACT Common Code (3 characters).
    ///
    /// In most cases, the appropriate unit of measurement is the UN/CEFACT Common Code "C62" for "Unit or piece", since a gr:Offering is defined by the quantity and unit of measurement of all items included (e.g. "1 kg of bananas plus a 2 kg of apples"). As long at the offering consists of only one item, it is also possible to use an unit of measurement of choice for specifying the price per unit. For bundles, however, only  "C62" for "Unit or piece" is a valid unit of measurement.
    ///
    /// You can assume that the price is given per unit or piece if there is no gr:hasUnitOfMeasurement property attached to the price.
    ///
    /// Whether VAT and sales taxes are included in this price is specified using the property gr:valueAddedTaxIncluded (xsd:boolean).
    ///
    /// The price per unit of measurement is specified as a float value of the gr:hasCurrencyValue property. The currency is specified via the gr:hasCurrency datatype property. Whether the price includes VAT or not is indicated by the gr:valueAddedTaxIncluded datatype property.
    ///
    /// The property priceType can be used to indicate that the price is a retail price recommendation only (i.e. a list price).
    ///
    /// If the price can only be given as a range, use gr:hasMaxCurrencyValue and gr:hasMinCurrencyValue for the upper and lower bounds.
    ///
    /// Important: When querying for the price, always use gr:hasMaxCurrencyValue and gr:hasMinCurrencyValue.
    ///
    /// Note 1: Due to the complexity of pricing scenarios in various industries, it may be necessary to create extensions of this fundamental model of price specifications. Such can be done easily by importing and refining the GoodRelations ontology.
    ///
    /// Note 2: For Google, attaching a gr:validThrough statement to a gr:UnitPriceSpecification is mandatory.
    /// "</para>
    /// labels<para>"Unit price specification"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#UnitPriceSpecification">http://purl.org/goodrelations/v1#UnitPriceSpecification</seealso>
    let UnitPriceSpecification =
        Prefixed_Name(gr, "UnitPriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>gr:VISA</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:PaymentMethodCreditCard</para>
    ///   <para>"Payment by credit or debit cards issued by the VISA network."</para>
    /// labels<para>"VISA (payment method)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#VISA">http://purl.org/goodrelations/v1#VISA</seealso>
    let VISA = Prefixed_Name(gr, "VISA") |> PrefixedName
    /// <summary>
    ///   <para>gr:WarrantyPromise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This is a conceptual entity that holds together all aspects of the n-ary relation gr:hasWarrantyPromise.
    ///
    /// A Warranty promise is an entity representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of the gr:ProductOrService. A warranty promise is characterized by its temporal duration (usually starting with the date of purchase) and its gr:WarrantyScope. The warranty scope represents the types of services provided (e.g. labor and parts, just parts) of the warranty included in an gr:Offering. The actual services may be provided by the gr:BusinessEntity making the offering, by the manufacturer of the product, or by a third party. There may be multiple warranty promises associated with a particular offering, which differ in duration and scope (e.g. pick-up service during the first 12 months, just parts and labor for 36 months).
    ///
    /// Examples: 12 months parts and labor, 36 months parts"</para>
    /// labels<para>"Warranty promise"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#WarrantyPromise">http://purl.org/goodrelations/v1#WarrantyPromise</seealso>
    let WarrantyPromise = Prefixed_Name(gr, "WarrantyPromise") |> PrefixedName
    /// <summary>
    ///   <para>gr:WarrantyScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The warranty scope represents types of services that will be provided free of charge by the vendor or manufacturer in the case of a defect (e.g. labor and parts, just parts), as part of the warranty included in an gr:Offering. The actual services may be provided by the gr:BusinessEntity making the offering, by the manufacturer of the product, or by a third party.
    ///
    /// Examples: Parts and Labor, Parts"</para>
    /// labels<para>"Warranty scope"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#WarrantyScope">http://purl.org/goodrelations/v1#WarrantyScope</seealso>
    let WarrantyScope = Prefixed_Name(gr, "WarrantyScope") |> PrefixedName
    /// <summary>
    ///   <para>gr:Wednesday</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:DayOfWeek</para>
    ///   <para>"Wednesday as a day of the week."</para>
    /// labels<para>"Wednesday (day of week)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#Wednesday">http://purl.org/goodrelations/v1#Wednesday</seealso>
    let Wednesday = Prefixed_Name(gr, "Wednesday") |> PrefixedName

    /// <summary>
    ///   <para>gr:acceptedPaymentMethods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The gr:PaymentMethod or methods accepted by the gr:BusinessEntity for the given gr:Offering."</para>
    /// labels<para>"accepted payment methods (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#acceptedPaymentMethods">http://purl.org/goodrelations/v1#acceptedPaymentMethods</seealso>
    let acceptedPaymentMethods =
        Prefixed_Name(gr, "acceptedPaymentMethods") |> PrefixedName

    /// <summary>
    ///   <para>gr:addOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property points from a gr:Offering to additional offerings that can only be obtained in combination with the first offering. This can be used to model supplements and extensions that are available for a surcharge. Any gr:PriceSpecification attached to the secondary offering is to be understood as an additional charge."</para>
    /// labels<para>"add-on (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#addOn">http://purl.org/goodrelations/v1#addOn</seealso>
    let addOn = Prefixed_Name(gr, "addOn") |> PrefixedName

    /// <summary>
    ///   <para>gr:advanceBookingRequirement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The minimal and maximal amount of time that is required between accepting the gr:Offering and the actual usage of the resource or service. This is mostly relevant for offers regarding hotel rooms, the rental of objects, or the provisioning of services. The duration is specified relatively to the beginning of the usage of the contracted object. It is represented by attaching an instance of the class gr:QuantitativeValueInteger. The lower and upper boundaries are specified using the properties gr:hasMinValueInteger and gr:hasMaxValueInteger to that instance. The unit of measurement is specified using the property gr:hasUnitOfMeasurement with a string holding a UN/CEFACT code suitable for durations, e.g. MON (months), DAY (days), HUR (hours), or MIN (minutes).
    ///
    /// The difference to the gr:validFrom and gr:validThrough properties is that those specify the interval during which the gr:Offering is valid, while gr:advanceBookingRequirement specifies the acceptable relative amount of time between accepting the offer and the fulfilment or usage."</para>
    /// labels<para>"advance booking requirement (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#advanceBookingRequirement">http://purl.org/goodrelations/v1#advanceBookingRequirement</seealso>
    let advanceBookingRequirement =
        Prefixed_Name(gr, "advanceBookingRequirement") |> PrefixedName

    /// <summary>
    ///   <para>gr:amountOfThisGood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the quantity of the goods included in the gr:Offering via this gr:TypeAndQuantityNode. The quantity is given in the unit of measurement attached to the gr:TypeAndQuantityNode."</para>
    /// labels<para>"amount of this good (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#amountOfThisGood">http://purl.org/goodrelations/v1#amountOfThisGood</seealso>
    let amountOfThisGood = Prefixed_Name(gr, "amountOfThisGood") |> PrefixedName

    /// <summary>
    ///   <para>gr:appliesToDeliveryMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the gr:DeliveryMethod to which the gr:DeliveryChargeSpecification applies."</para>
    /// labels<para>"applies to delivery method (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#appliesToDeliveryMethod">http://purl.org/goodrelations/v1#appliesToDeliveryMethod</seealso>
    let appliesToDeliveryMethod =
        Prefixed_Name(gr, "appliesToDeliveryMethod") |> PrefixedName

    /// <summary>
    ///   <para>gr:appliesToPaymentMethod</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the gr:PaymentMethod to which the gr:PaymentChargeSpecification applies."</para>
    /// labels<para>"applies to payment method (1..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#appliesToPaymentMethod">http://purl.org/goodrelations/v1#appliesToPaymentMethod</seealso>
    let appliesToPaymentMethod =
        Prefixed_Name(gr, "appliesToPaymentMethod") |> PrefixedName

    /// <summary>
    ///   <para>gr:availabilityEnds</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the end of the availability of the gr:ProductOrService included in the gr:Offering.
    /// The difference to the properties gr:validFrom and gr:validThrough is that those specify the period of time during which the offer is valid and can be accepted.
    ///
    /// Example: I offer to lease my boat for the period of August 1 - August 31, 2010, but you must accept by offer no later than July 15.
    ///
    /// A time-zone should be specified. For a time in GMT/UTC, simply add a "Z" following the time:
    ///
    /// 2008-05-30T09:30:10Z.
    ///
    /// Alternatively, you can specify an offset from the UTC time by adding a positive or negative time following the time:
    ///
    /// 2008-05-30T09:30:10-09:00
    ///
    /// or
    ///
    /// 2008-05-30T09:30:10+09:00.
    ///
    /// Note: There is another property gr:availableAtOrFrom, which is used to indicate the gr:Location (e.g. store or shop) from which the goods would be available."</para>
    /// labels<para>"availability ends (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#availabilityEnds">http://purl.org/goodrelations/v1#availabilityEnds</seealso>
    let availabilityEnds = Prefixed_Name(gr, "availabilityEnds") |> PrefixedName
    /// <summary>
    ///   <para>gr:availabilityStarts</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property specifies the beginning of the availability of the gr:ProductOrService included in the gr:Offering.
    /// The difference to the properties gr:validFrom and gr:validThrough is that those specify the period of time during which the offer is valid and can be accepted.
    ///
    /// Example: I offer to lease my boat for the period of August 1 - August 31, 2010, but you must accept by offer no later than July 15.
    ///
    /// A time-zone should be specified. For a time in GMT/UTC, simply add a "Z" following the time:
    ///
    /// 2008-05-30T09:30:10Z.
    ///
    /// Alternatively, you can specify an offset from the UTC time by adding a positive or negative time following the time:
    ///
    /// 2008-05-30T09:30:10-09:00
    ///
    /// or
    ///
    /// 2008-05-30T09:30:10+09:00.
    ///
    /// Note: There is another property gr:availableAtOrFrom, which is used to indicate the gr:Location (e.g. store or shop) from which the goods would be available."</para>
    /// labels<para>"availability starts (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#availabilityStarts">http://purl.org/goodrelations/v1#availabilityStarts</seealso>
    let availabilityStarts = Prefixed_Name(gr, "availabilityStarts") |> PrefixedName
    /// <summary>
    ///   <para>gr:availableAtOrFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This states that a particular gr:Offering is available at or from the given gr:Location (e.g. shop or branch)."</para>
    /// labels<para>"available at or from (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#availableAtOrFrom">http://purl.org/goodrelations/v1#availableAtOrFrom</seealso>
    let availableAtOrFrom = Prefixed_Name(gr, "availableAtOrFrom") |> PrefixedName

    /// <summary>
    ///   <para>gr:availableDeliveryMethods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This specifies the gr:DeliveryMethod or methods available for a given gr:Offering."</para>
    /// labels<para>"available delivery methods (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#availableDeliveryMethods">http://purl.org/goodrelations/v1#availableDeliveryMethods</seealso>
    let availableDeliveryMethods =
        Prefixed_Name(gr, "availableDeliveryMethods") |> PrefixedName

    /// <summary>
    ///   <para>gr:billingIncrement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the minimal quantity and rounding increment that will be the basis for the billing.
    /// The unit of measurement is specified by the UN/CEFACT code attached to the gr:UnitPriceSpecification via the gr:hasUnitOfMeasurement property.
    ///
    /// Examples:
    /// - The price for gasoline is 4 USD per gallon at the pump, but you will be charged in units of 0.1 gallons.
    /// - The price for legal consulting is 100 USD per hour, but you will be charged in units of 15 minutes.
    ///
    /// This property makes sense only for instances of gr:Offering that include not more than one type of good or service."</para>
    /// labels<para>"billing increment (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#billingIncrement">http://purl.org/goodrelations/v1#billingIncrement</seealso>
    let billingIncrement = Prefixed_Name(gr, "billingIncrement") |> PrefixedName
    /// <summary>
    ///   <para>gr:category</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of a category to which this gr:ProductOrService, gr:Offering, gr:BusinessEntity, or gr:Location belongs.
    ///
    /// Note 1: For products, it is better to add an rdf:type statement referring to a GoodRelations-compliant ontology for vertical industries instead, but if you just have a short text label, gr:category is simpler.
    /// Note 2: You can use greater signs or slashes to informally indicate a category hierarchy, e.g. "restaurants/asian_restaurants" or "cables &gt; usb_cables"
    /// "</para>
    /// labels<para>"category (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#category">http://purl.org/goodrelations/v1#category</seealso>
    let category = Prefixed_Name(gr, "category") |> PrefixedName
    /// <summary>
    ///   <para>gr:closes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The closing  hour of the gr:Location on the given gr:DayOfWeek.
    /// If no time-zone suffix is included, the time is given in the local time valid at the gr:Location.
    ///
    /// For a time in GMT/UTC, simply add a "Z" following the time:
    ///
    /// 09:30:10Z.
    ///
    /// Alternatively, you can specify an offset from the UTC time by adding a positive or negative time following the time:
    ///
    /// 09:30:10-09:00
    ///
    /// 09:30:10+09:00.
    ///
    /// Note 1: Use 00:00:00 for the first second of the respective day and 23:59:59 for the last second of that day.
    /// Note 2: If a store opens at 17:00 on Saturdays and closes at 03:00:00 a.m. next morning, use two instances of this class, one with 17:00:00 - 23:59:59 for Saturday and another one with 00:00:00 - 03:00:00 for Sunday.
    /// Note 3: If the shop re-opens on the same day of the week or set of days of the week, you must create a second instance of gr:OpeningHoursSpecification."</para>
    /// labels<para>"closes (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#closes">http://purl.org/goodrelations/v1#closes</seealso>
    let closes = Prefixed_Name(gr, "closes") |> PrefixedName
    /// <summary>
    ///   <para>gr:color</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The color of the product."</para>
    /// labels<para>"color (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#color">http://purl.org/goodrelations/v1#color</seealso>
    let color = Prefixed_Name(gr, "color") |> PrefixedName
    /// <summary>
    ///   <para>gr:condition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A textual description of the condition of the product or service, or the products or services included in the offer (when attached to a gr:Offering)"</para>
    /// labels<para>"condition (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#condition">http://purl.org/goodrelations/v1#condition</seealso>
    let condition = Prefixed_Name(gr, "condition") |> PrefixedName

    /// <summary>
    ///   <para>gr:datatypeProductOrServiceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property is the super property for all pure datatype properties that can be used to describe a gr:ProductOrService.
    ///
    /// In products and services ontologies, only such properties that are no quantitative properties and that have no predefined gr:QualitativeValue instances are subproperties of this property. In practice, this refers to a few integer properties for which the integer value represents qualitative aspects, for string datatypes (as long as no predefined values exist), for boolean datatype properties, and for dates and times."</para>
    /// labels<para>"datatype product or service property (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#datatypeProductOrServiceProperty">http://purl.org/goodrelations/v1#datatypeProductOrServiceProperty</seealso>
    let datatypeProductOrServiceProperty =
        Prefixed_Name(gr, "datatypeProductOrServiceProperty") |> PrefixedName

    /// <summary>
    ///   <para>gr:deliveryLeadTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property can be used to indicate the promised delay between the receipt of the order and the goods leaving the warehouse.
    ///
    /// The duration is specified by attaching an instance of gr:QuantitativeValueInteger. The lower and upper boundaries are specified using the properties gr:hasMinValueInteger and gr:hasMaxValueInteger to that instance. A point value can be modeled with the gr:hasValueInteger property. The unit of measurement is specified using the property gr:hasUnitOfMeasurement with a string holding a UN/CEFACT code suitable for durations, e.g. MON (months), DAY (days), HUR (hours), or MIN (minutes)."</para>
    /// labels<para>"delivery lead time (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#deliveryLeadTime">http://purl.org/goodrelations/v1#deliveryLeadTime</seealso>
    let deliveryLeadTime = Prefixed_Name(gr, "deliveryLeadTime") |> PrefixedName
    /// <summary>
    ///   <para>gr:depth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The depth of the product.
    /// Typical unit code(s): CMT for centimeters, INH for inches"</para>
    /// labels<para>"depth (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#depth">http://purl.org/goodrelations/v1#depth</seealso>
    let depth = Prefixed_Name(gr, "depth") |> PrefixedName
    /// <summary>
    ///   <para>gr:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A short textual description of the resource.
    ///
    /// This property is semantically equivalent to rdfs:comment and just meant as a handy shortcut for marking up data."</para>
    /// labels<para>"description (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#description">http://purl.org/goodrelations/v1#description</seealso>
    let description = Prefixed_Name(gr, "description") |> PrefixedName
    /// <summary>
    ///   <para>gr:displayPosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The position at which the option or element should be listed in a menu or user dialog, lower numbers come first.
    ///
    /// The main usage of this property are the days of the week (gr:DayOfWeek), but it is also possible to apply it e.g. to product features or any other conceptual element.
    /// Note: Rely on this property only for data originating from a single RDF graph; otherwise, unpredictable results are possible."</para>
    /// labels<para>"display position (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#displayPosition">http://purl.org/goodrelations/v1#displayPosition</seealso>
    let displayPosition = Prefixed_Name(gr, "displayPosition") |> PrefixedName

    /// <summary>
    ///   <para>gr:durationOfWarrantyInMonths</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the duration of the gr:WarrantyPromise in months."</para>
    /// labels<para>"duration of warranty in months (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#durationOfWarrantyInMonths">http://purl.org/goodrelations/v1#durationOfWarrantyInMonths</seealso>
    let durationOfWarrantyInMonths =
        Prefixed_Name(gr, "durationOfWarrantyInMonths") |> PrefixedName

    /// <summary>
    ///   <para>gr:eligibleCustomerTypes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The types of customers (gr:BusinessEntityType) for which the given gr:Offering is valid."</para>
    /// labels<para>"eligible customer types (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#eligibleCustomerTypes">http://purl.org/goodrelations/v1#eligibleCustomerTypes</seealso>
    let eligibleCustomerTypes =
        Prefixed_Name(gr, "eligibleCustomerTypes") |> PrefixedName

    /// <summary>
    ///   <para>gr:eligibleDuration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The minimal and maximal duration for which the given gr:Offering or gr:License is valid. This is mostly used for offers regarding accommodation, the rental of objects, or software licenses. The duration is specified by attaching an instance of gr:QuantitativeValue. The lower and upper boundaries are specified using the properties gr:hasMinValue and gr:hasMaxValue to that instance. If they are the same, use the gr:hasValue property. The unit of measurement is specified using the property gr:hasUnitOfMeasurement with a string holding a UN/CEFACT code suitable for durations, e.g. MON (months), DAY (days), HUR (hours), or MIN (minutes).
    ///
    /// The difference to the gr:validFrom and gr:validThrough properties is that those specify the absiolute interval during which the gr:Offering or gr:License is valid, while gr:eligibleDuration specifies the acceptable duration of the contract or usage."</para>
    /// labels<para>"eligible duration (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#eligibleDuration">http://purl.org/goodrelations/v1#eligibleDuration</seealso>
    let eligibleDuration = Prefixed_Name(gr, "eligibleDuration") |> PrefixedName
    /// <summary>
    ///   <para>gr:eligibleRegions</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property specifies the geo-political region or regions for which the gr:Offering, gr:License, or gr:DeliveryChargeSpecification is valid using the two-character version of ISO 3166-1 (ISO 3166-1 alpha-2)  for regions or ISO 3166-2 , which breaks down the countries from ISO 3166-1 into administrative subdivisions.
    ///
    /// Important: Do NOT use 3-letter ISO 3166-1 codes!"</para>
    /// labels<para>"eligible regions (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#eligibleRegions">http://purl.org/goodrelations/v1#eligibleRegions</seealso>
    let eligibleRegions = Prefixed_Name(gr, "eligibleRegions") |> PrefixedName

    /// <summary>
    ///   <para>gr:eligibleTransactionVolume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property can be used to indicate the transaction volume, in a monetary unit, for which the gr:Offering or gr:PriceSpecification is valid. This is mostly used to specify a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases above a certain amount.
    ///
    /// The object is a gr:PriceSpecification that uses the properties gr:hasMaxCurrencyValue and gr:hasMinCurrencyValue to indicate the lower and upper boundaries and gr:hasCurrency to indicate the currency using the ISO 4217 standard (3 characters)."</para>
    /// labels<para>"eligible transaction volume (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#eligibleTransactionVolume">http://purl.org/goodrelations/v1#eligibleTransactionVolume</seealso>
    let eligibleTransactionVolume =
        Prefixed_Name(gr, "eligibleTransactionVolume") |> PrefixedName

    /// <summary>
    ///   <para>gr:equal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This ordering relation for qualitative values indicates that the subject is equal to the object."</para>
    /// labels<para>"equal (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#equal">http://purl.org/goodrelations/v1#equal</seealso>
    let equal = Prefixed_Name(gr, "equal") |> PrefixedName
    /// <summary>
    ///   <para>gr:greater</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This ordering relation for qualitative values indicates that the subject is greater than the object."</para>
    /// labels<para>"greater (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#greater">http://purl.org/goodrelations/v1#greater</seealso>
    let greater = Prefixed_Name(gr, "greater") |> PrefixedName
    /// <summary>
    ///   <para>gr:greaterOrEqual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"This ordering relation for qualitative values indicates that the subject is greater than or equal to the object."</para>
    /// labels<para>"greater or equal (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#greaterOrEqual">http://purl.org/goodrelations/v1#greaterOrEqual</seealso>
    let greaterOrEqual = Prefixed_Name(gr, "greaterOrEqual") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasBrand</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the brand or brands (gr:Brand) associated with a gr:ProductOrService, or the brand or brands maintained by a gr:BusinessEntity."</para>
    /// labels<para>"has brand (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasBrand">http://purl.org/goodrelations/v1#hasBrand</seealso>
    let hasBrand = Prefixed_Name(gr, "hasBrand") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasBusinessFunction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This specifies the business function of the gr:Offering, i.e. whether the gr:BusinessEntity is offering to sell, to lease, or to repair the particular type of product. In the case of bundles, it is also possible to attach individual business functions to each gr:TypeAndQuantityNode. The business function of the main gr:Offering determines the business function for all included objects or services, unless a business function attached to a gr:TypeAndQuantityNode overrides it.
    ///
    /// Note: While it is possible that an entity is offering multiple types of business functions for the same set of objects (e.g. rental and sales), this should usually not be stated by attaching multiple business functions to the same gr:Offering, since the gr:UnitPriceSpecification for the varying business functions will typically be very different."</para>
    /// labels<para>"has business function (1..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasBusinessFunction">http://purl.org/goodrelations/v1#hasBusinessFunction</seealso>
    let hasBusinessFunction = Prefixed_Name(gr, "hasBusinessFunction") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasCurrency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The currency for all prices in the gr:PriceSpecification given using the ISO 4217 standard (3 characters)."</para>
    /// labels<para>"has currency (1..1)"</para><para>"Has currency"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasCurrency">http://purl.org/goodrelations/v1#hasCurrency</seealso>
    let hasCurrency = Prefixed_Name(gr, "hasCurrency") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasCurrencyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the amount of money for a price per unit, shipping charges, or payment charges. The currency and other relevant details are attached to the respective gr:PriceSpecification etc.
    ///
    /// For a gr:UnitPriceSpecification, this is the price for one unit or bundle (as specified in the unit of measurement of the unit price specification) of the respective gr:ProductOrService. For a gr:DeliveryChargeSpecification or a gr:PaymentChargeSpecification, it is the price per delivery or payment.
    ///
    /// GoodRelations also supports giving price information as intervals only. If this is needed, use gr:hasMaxCurrencyValue for the upper bound and gr:hasMinCurrencyValue for the lower bound.
    ///
    /// Using gr:hasCurrencyValue sets the upper and lower bounds to the same given value, i.e., x gr:hasCurrencyValue y implies x gr:hasMinCurrencyValue y, x gr:hasMaxCurrencyValue y."</para>
    /// labels<para>"has currency value (0..1)"</para><para>"Has currency value"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasCurrencyValue">http://purl.org/goodrelations/v1#hasCurrencyValue</seealso>
    let hasCurrencyValue = Prefixed_Name(gr, "hasCurrencyValue") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasDUNS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Dun &amp; Bradstreet DUNS number for identifying a gr:BusinessEntity. The Dun &amp; Bradstreet DUNS is a nine-digit number used to identify legal entities (but usually not branches or locations of logistical importance only)."</para>
    /// labels<para>"has DUNS (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasDUNS">http://purl.org/goodrelations/v1#hasDUNS</seealso>
    let hasDUNS = Prefixed_Name(gr, "hasDUNS") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasEAN_UCC-13</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The EAN·UCC-13 code of the given gr:ProductOrService or gr:Offering. This code is now officially called GTIN-13 (Global Trade Identifier Number) or EAN·UCC-13. Former 12-digit UPC codes can be converted into EAN·UCC-13 code by simply adding a preceeding zero.
    ///
    /// Note 1: When using this property for searching by 12-digit UPC codes, you must add a preceeding zero digit.
    /// Note 2: As of January 1, 2007, the former ISBN numbers for books etc. have been integrated into the EAN·UCC-13 code. For each old ISBN-10 code, there exists a proper translation into EAN·UCC-13 by adding "978" or "979" as prefix. Since the old ISBN-10 is now deprecated, GoodRelations does not provide a property for ISBNs."</para>
    /// labels<para>"has EAN/UCC-13 (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasEAN_UCC-13">http://purl.org/goodrelations/v1#hasEAN_UCC-13</seealso>
    let hasEAN_UCC_13 = Prefixed_Name(gr, "hasEAN_UCC-13") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasEligibleQuantity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This specifies the interval and unit of measurement of ordering quantities for which the gr:Offering or gr:PriceSpecification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
    /// Note that if an offering is a bundle, i.e. it consists of more than one unit of a single type of good, or if the unit of measurement for the good is different from unit (Common Code C62), then gr:hasEligibleQuantity refers to units of this bundle. In other words, "C62" for "Units or pieces" is usually the appropriate unit of measurement."</para>
    /// labels<para>"has eligible quantity (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasEligibleQuantity">http://purl.org/goodrelations/v1#hasEligibleQuantity</seealso>
    let hasEligibleQuantity = Prefixed_Name(gr, "hasEligibleQuantity") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasGTIN-14</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Global Trade Item Number (GTIN-14) of the given gr:ProductOrService or gr:Offering."</para>
    /// labels<para>"has GTIN-14 (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasGTIN-14">http://purl.org/goodrelations/v1#hasGTIN-14</seealso>
    let hasGTIN_14 = Prefixed_Name(gr, "hasGTIN-14") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasGTIN-8</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The 8-digit Global Trade Item Number (GTIN-8) of the given gr:ProductOrService or gr:Offering, also known as EAN/UCC-8 (8-digit EAN)."</para>
    /// labels<para>"has GTIN-8 (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasGTIN-8">http://purl.org/goodrelations/v1#hasGTIN-8</seealso>
    let hasGTIN_8 = Prefixed_Name(gr, "hasGTIN-8") |> PrefixedName

    /// <summary>
    ///   <para>gr:hasGlobalLocationNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Global Location Number (GLN, sometimes also referred to as International Location Number or ILN) of the respective gr:BusinessEntity or gr:Location.
    /// The Global Location Number is a thirteen-digit number used to identify parties and physical locations."</para>
    /// labels<para>"has Global Location Number (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasGlobalLocationNumber">http://purl.org/goodrelations/v1#hasGlobalLocationNumber</seealso>
    let hasGlobalLocationNumber =
        Prefixed_Name(gr, "hasGlobalLocationNumber") |> PrefixedName

    /// <summary>
    ///   <para>gr:hasISICv4</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular gr:BusinessEntity or gr:Location. See http://unstats.un.org/unsd/cr/registry/isic-4.asp for more information.
    ///
    /// Note: While ISIC codes are sometimes misused for classifying products or services, they are designed and suited only for classifying business establishments."</para>
    /// labels<para>"has ISIC v4 (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasISICv4">http://purl.org/goodrelations/v1#hasISICv4</seealso>
    let hasISICv4 = Prefixed_Name(gr, "hasISICv4") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasInventoryLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property specifies the current approximate inventory level for gr:SomeItems. The unit of measurement and the point value or interval are indicated using the attached gr:QuantitativeValueFloat instance.
    ///
    /// This property can also be attached to a gr:Offering in cases where the included products are not modeled in more detail."</para>
    /// labels<para>"has inventory level (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasInventoryLevel">http://purl.org/goodrelations/v1#hasInventoryLevel</seealso>
    let hasInventoryLevel = Prefixed_Name(gr, "hasInventoryLevel") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMPN</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Manufacturer Part Number or MPN is a unique identifier for a product, service, or bundle from the perspective of a particular manufacturer. MPNs can be assigned to products or product datasheets, or bundles. Accordingly, the domain of this property is the union of gr:ProductOrService (the common superclass of goods and datasheets), and gr:Offering.
    ///
    /// Important: Be careful when assuming two products or services instances or offering instances to be identical based on the MPN. Since MPNs are unique only for the same gr:BusinessEntity, this holds only when the two MPN values refer to the same gr:BusinessEntity. Such can be done by taking into account the provenance of the data.
    ///
    /// Usually, the properties gr:hasEAN_UCC-13 and gr:hasGTIN-14 are much more reliable identifiers, because they are globally unique.
    ///
    /// See also http://en.wikipedia.org/wiki/Part_number"</para>
    /// labels<para>"has MPN (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMPN">http://purl.org/goodrelations/v1#hasMPN</seealso>
    let hasMPN = Prefixed_Name(gr, "hasMPN") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMakeAndModel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This states that an actual product instance (gr:Individual) or a placeholder instance for multiple, unidentified such instances (gr:SomeItems) is one occurence of a particular gr:ProductOrServiceModel.
    ///
    /// Example: myFordT hasMakeAndModel FordT."</para>
    /// labels<para>"has make and model (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMakeAndModel">http://purl.org/goodrelations/v1#hasMakeAndModel</seealso>
    let hasMakeAndModel = Prefixed_Name(gr, "hasMakeAndModel") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasManufacturer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property links a gr:ProductOrService to the gr:BusinessEntity that produces it. Mostly used with gr:ProductOrServiceModel."</para>
    /// labels<para>"has manufacturer (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasManufacturer">http://purl.org/goodrelations/v1#hasManufacturer</seealso>
    let hasManufacturer = Prefixed_Name(gr, "hasManufacturer") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMaxCurrencyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the UPPER BOUND of the amount of money for a price RANGE per unit, shipping charges, or payment charges. The currency and other relevant details are attached to the respective gr:PriceSpecification etc.
    /// For a gr:UnitPriceSpecification, this is the UPPER BOUND for the price for one unit or bundle (as specified in the unit of measurement of the unit price specification) of the respective gr:ProductOrService. For a gr:DeliveryChargeSpecification or a gr:PaymentChargeSpecification, it is the UPPER BOUND of the price per delivery or payment.
    ///
    /// Using gr:hasCurrencyValue sets the upper and lower bounds to the same given value, i.e., x gr:hasCurrencyValue y implies x gr:hasMinCurrencyValue y, x gr:hasMaxCurrencyValue y."</para>
    /// labels<para>"has max currency value (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMaxCurrencyValue">http://purl.org/goodrelations/v1#hasMaxCurrencyValue</seealso>
    let hasMaxCurrencyValue = Prefixed_Name(gr, "hasMaxCurrencyValue") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMaxValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property captures the upper limit of a gr:QuantitativeValue instance."</para>
    /// labels<para>"has max value (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMaxValue">http://purl.org/goodrelations/v1#hasMaxValue</seealso>
    let hasMaxValue = Prefixed_Name(gr, "hasMaxValue") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMaxValueFloat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property captures the upper limit of a gr:QuantitativeValueFloat instance."</para>
    /// labels<para>"has max value float (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMaxValueFloat">http://purl.org/goodrelations/v1#hasMaxValueFloat</seealso>
    let hasMaxValueFloat = Prefixed_Name(gr, "hasMaxValueFloat") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMaxValueInteger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property captures the upper limit of a gr:QuantitativeValueInteger instance."</para>
    /// labels<para>"has max value integer (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMaxValueInteger">http://purl.org/goodrelations/v1#hasMaxValueInteger</seealso>
    let hasMaxValueInteger = Prefixed_Name(gr, "hasMaxValueInteger") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMinCurrencyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the LOWER BOUND of the amount of money for a price RANGE per unit, shipping charges, or payment charges. The currency and other relevant details are attached to the respective gr:PriceSpecification etc.
    /// For a gr:UnitPriceSpecification, this is the LOWER BOUND for the price for one unit or bundle (as specified in the unit of measurement of the unit price specification) of the respective gr:ProductOrService. For a gr:DeliveryChargeSpecification or a gr:PaymentChargeSpecification, it is the LOWER BOUND of the price per delivery or payment.
    ///
    /// Using gr:hasCurrencyValue sets the upper and lower bounds to the same given value, i.e., x gr:hasCurrencyValue y implies x gr:hasMinCurrencyValue y, x gr:hasMaxCurrencyValue y."</para>
    /// labels<para>"has min currency value (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMinCurrencyValue">http://purl.org/goodrelations/v1#hasMinCurrencyValue</seealso>
    let hasMinCurrencyValue = Prefixed_Name(gr, "hasMinCurrencyValue") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMinValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property captures the lower limit of a gr:QuantitativeValue instance."</para>
    /// labels<para>"has min value (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMinValue">http://purl.org/goodrelations/v1#hasMinValue</seealso>
    let hasMinValue = Prefixed_Name(gr, "hasMinValue") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMinValueFloat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property captures the lower limit of a gr:QuantitativeValueFloat instance."</para>
    /// labels<para>"has min value float (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMinValueFloat">http://purl.org/goodrelations/v1#hasMinValueFloat</seealso>
    let hasMinValueFloat = Prefixed_Name(gr, "hasMinValueFloat") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasMinValueInteger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property captures the lower limit of a gr:QuantitativeValueInteger instance."</para>
    /// labels<para>"has min value integer (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasMinValueInteger">http://purl.org/goodrelations/v1#hasMinValueInteger</seealso>
    let hasMinValueInteger = Prefixed_Name(gr, "hasMinValueInteger") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasNAICS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The North American Industry Classification System (NAICS) code for a particular gr:BusinessEntity.
    /// See http://www.census.gov/eos/www/naics/ for more details.
    ///
    /// Note: While NAICS codes are sometimes misused for classifying products or services, they are designed and suited only for classifying business establishments."</para>
    /// labels<para>"has NAICS (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasNAICS">http://purl.org/goodrelations/v1#hasNAICS</seealso>
    let hasNAICS = Prefixed_Name(gr, "hasNAICS") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasNext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This ordering relation for gr:DayOfWeek indicates that the subject is directly followed by the object.
    ///
    /// Example: Monday hasNext Tuesday
    ///
    /// Since days of the week are a cycle, this property is not transitive."</para>
    /// labels<para>"has next (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasNext">http://purl.org/goodrelations/v1#hasNext</seealso>
    let hasNext = Prefixed_Name(gr, "hasNext") |> PrefixedName

    /// <summary>
    ///   <para>gr:hasOpeningHoursDayOfWeek</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the gr:DayOfWeek to which the gr:OpeningHoursSpecification is related.
    ///
    /// Note: Use multiple instances of gr:OpeningHoursSpecification for specifying the opening hours for multiple days if the opening hours differ."</para>
    /// labels<para>"has opening hours day of week (1..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasOpeningHoursDayOfWeek">http://purl.org/goodrelations/v1#hasOpeningHoursDayOfWeek</seealso>
    let hasOpeningHoursDayOfWeek =
        Prefixed_Name(gr, "hasOpeningHoursDayOfWeek") |> PrefixedName

    /// <summary>
    ///   <para>gr:hasOpeningHoursSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property links a gr:Location to a gr:OpeningHoursSpecification."</para>
    /// labels<para>"has opening hours specification (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasOpeningHoursSpecification">http://purl.org/goodrelations/v1#hasOpeningHoursSpecification</seealso>
    let hasOpeningHoursSpecification =
        Prefixed_Name(gr, "hasOpeningHoursSpecification") |> PrefixedName

    /// <summary>
    ///   <para>gr:hasPOS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property states that the respective gr:Location is a point of sale for the respective gr:BusinessEntity. It allows linking those two types of entities without the need for a particular gr:Offering."</para>
    /// labels<para>"has POS (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasPOS">http://purl.org/goodrelations/v1#hasPOS</seealso>
    let hasPOS = Prefixed_Name(gr, "hasPOS") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasPrevious</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This ordering relation for gr:DayOfWeek indicates that the subject is directly preceeded by the object.
    ///
    /// Example: Tuesday hasPrevious Monday
    ///
    /// Since days of the week are a cycle, this property is not transitive."</para>
    /// labels<para>"has previous (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasPrevious">http://purl.org/goodrelations/v1#hasPrevious</seealso>
    let hasPrevious = Prefixed_Name(gr, "hasPrevious") |> PrefixedName

    /// <summary>
    ///   <para>gr:hasPriceSpecification</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This links a gr:Offering to a gr:PriceSpecification or specifications. There can be unit price specifications, payment charge specifications, and delivery charge specifications. For each type, multiple specifications for the same gr:Offering are possible, e.g. for different quantity ranges or for different currencies, or for different combinations of gr:DeliveryMethod and target destinations.
    ///
    /// Recommended retail prices etc. can be marked by the gr:priceType property of the gr:UnitPriceSpecification."</para>
    /// labels<para>"Has price specification"</para><para>"Especificación del precio"</para><para>"has price specification (0..*)"</para><para>"Price specification"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasPriceSpecification">http://purl.org/goodrelations/v1#hasPriceSpecification</seealso>
    let hasPriceSpecification =
        Prefixed_Name(gr, "hasPriceSpecification") |> PrefixedName

    /// <summary>
    ///   <para>gr:hasStockKeepingUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Stock Keeping Unit, or SKU is a unique identifier for a product, service, or bundle from the perspective of a particular supplier, i.e. SKUs are mostly assigned and serialized at the merchant level.
    /// Examples of SKUs are the ordering or parts numbers used by a particular Web shop or catalog.
    ///
    /// Consequently, the domain of gr:hasStockKeepingUnit is the union of the classes gr:Offering and gr:ProductOrService.
    /// If attached to a gr:Offering, the SKU will usually reflect a merchant-specific identifier, i.e. one valid only for that particular retailer or shop.
    /// If attached to a gr:ProductOrServiceModel, the SKU can reflect either the identifier used by the merchant or the part number used by the official manufacturer of that part. For the latter, gr:hasMPN is a better choice.
    ///
    /// Important: Be careful when assuming two products or services instances or offering instances to be identical based on the SKU. Since SKUs are unique only for the same gr:BusinessEntity, this can be assumed only when you are sure that the two SKU values refer to the same business entity. Such can be done by taking into account the provenance of the data. As long as instances of gr:Offering are concerned, you can also check that the offerings are being offered by the same gr:Business Entity.
    ///
    /// Usually, the properties gr:hasEAN_UCC-13 and gr:hasGTIN-14 are much more reliable identifiers, because they are globally unique.
    ///
    /// See also http://en.wikipedia.org/wiki/Stock_Keeping_Unit."</para>
    /// labels<para>"has Stock Keeping Unit (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasStockKeepingUnit">http://purl.org/goodrelations/v1#hasStockKeepingUnit</seealso>
    let hasStockKeepingUnit = Prefixed_Name(gr, "hasStockKeepingUnit") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasUnitOfMeasurement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The unit of measurement for a gr:QuantitativeValue, a gr:UnitPriceSpecification, or a gr:TypeAndQuantityNode given using the UN/CEFACT Common Code (3 characters)."</para>
    /// labels<para>"has unit of measurement (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasUnitOfMeasurement">http://purl.org/goodrelations/v1#hasUnitOfMeasurement</seealso>
    let hasUnitOfMeasurement = Prefixed_Name(gr, "hasUnitOfMeasurement") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This subproperty specifies that the upper and lower limit of the given gr:QuantitativeValue are identical and have the respective value. It is a shortcut for such cases where a quantitative property is (at least practically) a single point value and not an interval."</para>
    /// labels<para>"has value (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasValue">http://purl.org/goodrelations/v1#hasValue</seealso>
    let hasValue = Prefixed_Name(gr, "hasValue") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasValueFloat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This subproperty specifies that the upper and lower limit of the given gr:QuantitativeValueFloat are identical and have the respective float value. It is a shortcut for such cases where a quantitative property is (at least practically) a single point value and not an interval."</para>
    /// labels<para>"has value float (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasValueFloat">http://purl.org/goodrelations/v1#hasValueFloat</seealso>
    let hasValueFloat = Prefixed_Name(gr, "hasValueFloat") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasValueInteger</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This subproperty specifies that the upper and lower limit of the given gr:QuantitativeValueInteger are identical and have the respective integer value. It is a shortcut for such cases where a quantitative property is (at least practically) a single point value and not an interval."</para>
    /// labels<para>"has value integer (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasValueInteger">http://purl.org/goodrelations/v1#hasValueInteger</seealso>
    let hasValueInteger = Prefixed_Name(gr, "hasValueInteger") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasWarrantyPromise</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the gr:WarrantyPromise made by the gr:BusinessEntity for the given gr:Offering."</para>
    /// labels<para>"has warranty promise (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasWarrantyPromise">http://purl.org/goodrelations/v1#hasWarrantyPromise</seealso>
    let hasWarrantyPromise = Prefixed_Name(gr, "hasWarrantyPromise") |> PrefixedName
    /// <summary>
    ///   <para>gr:hasWarrantyScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This states the gr:WarrantyScope of a given gr:WarrantyPromise."</para>
    /// labels<para>"has warranty scope (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#hasWarrantyScope">http://purl.org/goodrelations/v1#hasWarrantyScope</seealso>
    let hasWarrantyScope = Prefixed_Name(gr, "hasWarrantyScope") |> PrefixedName
    /// <summary>
    ///   <para>gr:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The height of the product.
    /// Typical unit code(s): CMT for centimeters, INH for inches"</para>
    /// labels<para>"height (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#height">http://purl.org/goodrelations/v1#height</seealso>
    let height = Prefixed_Name(gr, "height") |> PrefixedName
    /// <summary>
    ///   <para>gr:includes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property is a shortcut for the original gr:includesObject property for the common case of having exactly one single gr:ProductOrService instance included in an Offering.
    ///
    /// When linking to an instance of gr:SomeItems or gr:Individual, it is equivalent to using a gr:TypeAndQuantityNode with gr:hasUnitOfMeasurement="C62"^^xsd:string and gr:amountOfThisGood="1.0"^^xsd:float for that good.
    ///
    /// When linking to a gr:ProductOrServiceModel, it is equivalent to
    /// 1. defining an blank node for a gr:SomeItems
    /// 2. linking that blank node via gr:hasMakeAndModel to the gr:ProductOrServiceModel, and
    /// 3. linking from the gr:Offering to that blank node using another blank node of type gr:TypeAndQuantityNode with gr:hasUnitOfMeasurement="C62"^^xsd:string and gr:amountOfThisGood="1.0"^^xsd:float for that good."</para>
    /// labels<para>"includes (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#includes">http://purl.org/goodrelations/v1#includes</seealso>
    let includes = Prefixed_Name(gr, "includes") |> PrefixedName
    /// <summary>
    ///   <para>gr:includesObject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This object property links a gr:Offering to one or multiple gr:TypeAndQuantityNode or nodes that specify the components that are included in the respective offer."</para>
    /// labels<para>"includes object (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#includesObject">http://purl.org/goodrelations/v1#includesObject</seealso>
    let includesObject = Prefixed_Name(gr, "includesObject") |> PrefixedName

    /// <summary>
    ///   <para>gr:isAccessoryOrSparePartFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This states that a particular gr:ProductOrService is an accessory or spare part for another product or service."</para>
    /// labels<para>"is accessory or spare part for (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#isAccessoryOrSparePartFor">http://purl.org/goodrelations/v1#isAccessoryOrSparePartFor</seealso>
    let isAccessoryOrSparePartFor =
        Prefixed_Name(gr, "isAccessoryOrSparePartFor") |> PrefixedName

    /// <summary>
    ///   <para>gr:isConsumableFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This states that a particular gr:ProductOrService is a consumable for another product or service."</para>
    /// labels<para>"is consumable for (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#isConsumableFor">http://purl.org/goodrelations/v1#isConsumableFor</seealso>
    let isConsumableFor = Prefixed_Name(gr, "isConsumableFor") |> PrefixedName
    /// <summary>
    ///   <para>gr:isListPrice</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This boolean attribute indicates whether a gr:UnitPriceSpecification is a list price (usually a vendor recommendation) or not. "true"  indicates it is a list price, "false" indicates it is not.
    /// DEPRECATED. Use the gr:priceType property instead."</para>
    /// labels<para>"is list price (DEPRECATED)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#isListPrice">http://purl.org/goodrelations/v1#isListPrice</seealso>
    let isListPrice = Prefixed_Name(gr, "isListPrice") |> PrefixedName
    /// <summary>
    ///   <para>gr:isSimilarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This states that a given gr:ProductOrService is similar to another product or service. Of course, this is a subjective statement; when interpreting it, the trust in the origin of the statement should be taken into account."</para>
    /// labels<para>"is similar to (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#isSimilarTo">http://purl.org/goodrelations/v1#isSimilarTo</seealso>
    let isSimilarTo = Prefixed_Name(gr, "isSimilarTo") |> PrefixedName
    /// <summary>
    ///   <para>gr:isVariantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This states that a particular gr:ProductOrServiceModel is a variant of another product or service model. It is pretty safe to infer that the variant inherits all gr:quantitativeProductOrServiceProperty, gr:qualitativeProductOrServiceProperty, and gr:datatypeProductOrServiceProperty values that are defined for the first gr:ProductOrServiceModel.
    ///
    /// Example:
    /// foo:Red_Ford_T_Model gr:isVariantOf foo:Ford_T_Model"</para>
    /// labels<para>"is variant of (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#isVariantOf">http://purl.org/goodrelations/v1#isVariantOf</seealso>
    let isVariantOf = Prefixed_Name(gr, "isVariantOf") |> PrefixedName
    /// <summary>
    ///   <para>gr:legalName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The legal name of the gr:BusinessEntity."</para>
    /// labels<para>"legal name (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#legalName">http://purl.org/goodrelations/v1#legalName</seealso>
    let legalName = Prefixed_Name(gr, "legalName") |> PrefixedName
    /// <summary>
    ///   <para>gr:lesser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This ordering relation for gr:QualitativeValue pairs indicates that the subject is lesser than the object."</para>
    /// labels<para>"lesser (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#lesser">http://purl.org/goodrelations/v1#lesser</seealso>
    let lesser = Prefixed_Name(gr, "lesser") |> PrefixedName
    /// <summary>
    ///   <para>gr:lesserOrEqual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"This ordering relation for gr:QualitativeValue pairs indicates that the subject is lesser than or equal to the object."</para>
    /// labels<para>"lesser or equal (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#lesserOrEqual">http://purl.org/goodrelations/v1#lesserOrEqual</seealso>
    let lesserOrEqual = Prefixed_Name(gr, "lesserOrEqual") |> PrefixedName
    /// <summary>
    ///   <para>gr:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"A short text describing the respective resource.
    ///
    /// This property is semantically equivalent to dcterms:title and rdfs:label and just meant as a handy shortcut for marking up data."</para>
    /// labels<para>"name (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#name">http://purl.org/goodrelations/v1#name</seealso>
    let name = Prefixed_Name(gr, "name") |> PrefixedName
    /// <summary>
    ///   <para>gr:nonEqual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>"This ordering relation for gr:QualitativeValue pairs indicates that the subject is not equal to the object."</para>
    /// labels<para>"non equal (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#nonEqual">http://purl.org/goodrelations/v1#nonEqual</seealso>
    let nonEqual = Prefixed_Name(gr, "nonEqual") |> PrefixedName
    /// <summary>
    ///   <para>gr:offers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This links a gr:BusinessEntity to the offers (gr:Offering) it makes. If you want to express interest in receiving offers, use gr:seeks instead."</para>
    /// labels<para>"offers (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#offers">http://purl.org/goodrelations/v1#offers</seealso>
    let offers = Prefixed_Name(gr, "offers") |> PrefixedName
    /// <summary>
    ///   <para>gr:opens</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The opening hour of the gr:Location on the given gr:DayOfWeek.
    /// If no time-zone suffix is included, the time is given in the local time valid at the gr:Location.
    ///
    /// For a time in GMT/UTC, simply add a "Z" following the time:
    ///
    /// 09:30:10Z.
    ///
    /// Alternatively, you can specify an offset from the UTC time by adding a positive or negative time following the time:
    ///
    /// 09:30:10-09:00
    ///
    /// or
    ///
    /// 09:30:10+09:00.
    ///
    /// Note 1: Use 00:00:00 for the first second of the respective day and 23:59:59 for the last second of that day.
    /// Note 2: If a store opens at 17:00 on Saturdays and closes at 03:00:00 a.m. next morning, use 17:00:00 - 23:59:59 for Saturday and 00:00:00 - 03:00:00 for Sunday.
    /// Note 3: If the shop re-opens on the same day of the week or set of days of the week, you must create a second instance of gr:OpeningHoursSpecification."</para>
    /// labels<para>"opens (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#opens">http://purl.org/goodrelations/v1#opens</seealso>
    let opens = Prefixed_Name(gr, "opens") |> PrefixedName
    /// <summary>
    ///   <para>gr:owns</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property indicates that a particular person or business owns a particular product. It can be used to expose the products in one's posession in order to empower recommender systems to suggest matching offers.
    ///
    /// Note that the product must be an instance of the class gr:Individual.
    ///
    /// This property can also be safely applied to foaf:Agent instances."</para>
    /// labels<para>"owns (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#owns">http://purl.org/goodrelations/v1#owns</seealso>
    let owns = Prefixed_Name(gr, "owns") |> PrefixedName
    /// <summary>
    ///   <para>gr:predecessorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This property indicates that the subject is a previous, often discontinued variant of the gr:ProductOrServiceModel used as the object.
    ///
    /// Example: Golf III predecessorOf Golf IV
    ///
    /// This relation is transitive."</para>
    /// labels<para>"predecessor of (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#predecessorOf">http://purl.org/goodrelations/v1#predecessorOf</seealso>
    let predecessorOf = Prefixed_Name(gr, "predecessorOf") |> PrefixedName
    /// <summary>
    ///   <para>gr:priceType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This attribute can be used to distinguish multiple different price specifications for the same gr:Offering. It supersedes the former gr:isListPrice property. The following values are recommended:
    ///
    /// The absence of this property marks the actual sales price.
    ///
    /// SRP: "suggested retail price" - applicable for all sorts of a non-binding retail price recommendations, e.g. such published by the manufacturer or the distributor. This value replaces the former gr:isListPrice property.
    ///
    /// INVOICE: The invoice price, mostly used in the car industry - this is the price a dealer pays to the manufacturer, excluding rebates and charges."</para>
    /// labels<para>"price type (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#priceType">http://purl.org/goodrelations/v1#priceType</seealso>
    let priceType = Prefixed_Name(gr, "priceType") |> PrefixedName

    /// <summary>
    ///   <para>gr:qualitativeProductOrServiceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the super property of all qualitative properties for products and services. All properties in product or service ontologies for which gr:QualitativeValue instances are specified are subproperties of this property."</para>
    /// labels<para>"qualitative product or service property (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#qualitativeProductOrServiceProperty">http://purl.org/goodrelations/v1#qualitativeProductOrServiceProperty</seealso>
    let qualitativeProductOrServiceProperty =
        Prefixed_Name(gr, "qualitativeProductOrServiceProperty") |> PrefixedName

    /// <summary>
    ///   <para>gr:quantitativeProductOrServiceProperty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This is the super property of all quantitative  properties for products and services. All properties in product or service ontologies that specify quantitative characteristics, for which an interval is at least theoretically an appropriate value, are subproperties of this property."</para>
    /// labels<para>"quantitative product or service property (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#quantitativeProductOrServiceProperty">http://purl.org/goodrelations/v1#quantitativeProductOrServiceProperty</seealso>
    let quantitativeProductOrServiceProperty =
        Prefixed_Name(gr, "quantitativeProductOrServiceProperty") |> PrefixedName

    /// <summary>
    ///   <para>gr:relatedWebService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"The URI of a SOAP or REST Web Service from which additional information about the gr:BusinessEntity, gr:Offering, gr:PriceSpecification, or gr:ProductOrService, or any other element,  can be obtained. The recommended range is xsd:anyURI i.e., the URI of a SOAP or REST Web Service.
    ///
    /// In principle, any existing or upcoming vocabulary for Web Services can be used in combination with GoodRelations, because the association between (a) the service description and (b) the GoodRelations description can be found via the Web Service URI value used with this gr:relatedWebService property."</para>
    /// labels<para>"related Web Service (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#relatedWebService">http://purl.org/goodrelations/v1#relatedWebService</seealso>
    let relatedWebService = Prefixed_Name(gr, "relatedWebService") |> PrefixedName
    /// <summary>
    ///   <para>gr:seeks</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This links a gr:BusinessEntity to gr:Offering nodes that describe what the business entity is interested in (i.e., the buy side). If you want to express interest in offering something, use gr:offers instead. Note that this substitutes the former gr:BusinessFunction gr:Buy, which is now deprecated."</para>
    /// labels<para>"seeks (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#seeks">http://purl.org/goodrelations/v1#seeks</seealso>
    let seeks = Prefixed_Name(gr, "seeks") |> PrefixedName
    /// <summary>
    ///   <para>gr:serialNumber</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The serial number or any alphanumeric identifier of a particular product. Note that serial number are unique only for the same brand or the same model, so you cannot infer from two occurrences of the same serial number that the objects to which they are attached are identical.
    ///
    /// This property can also be attached to a gr:Offering in cases where the included products are not modeled in more detail."</para>
    /// labels<para>"serial number (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#serialNumber">http://purl.org/goodrelations/v1#serialNumber</seealso>
    let serialNumber = Prefixed_Name(gr, "serialNumber") |> PrefixedName
    /// <summary>
    ///   <para>gr:successorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>"This property indicates that the subject is a newer, often updated or improved variant of the gr:ProductOrServiceModel used as the object.
    ///
    /// Example: Golf III successorOf Golf II
    ///
    /// This relation is transitive."</para>
    /// labels<para>"successor of (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#successorOf">http://purl.org/goodrelations/v1#successorOf</seealso>
    let successorOf = Prefixed_Name(gr, "successorOf") |> PrefixedName
    /// <summary>
    ///   <para>gr:taxID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The Tax / Fiscal ID of the gr:BusinessEntity, e.g. the TIN in the US or the CIF/NIF in Spain. It is usually assigned by the country of residence"</para>
    /// labels<para>"Tax ID (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#taxID">http://purl.org/goodrelations/v1#taxID</seealso>
    let taxID = Prefixed_Name(gr, "taxID") |> PrefixedName
    /// <summary>
    ///   <para>gr:typeOfGood</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"This specifies the gr:ProductOrService that the gr:TypeAndQuantityNode is referring to."</para>
    /// labels<para>"type of good (1..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#typeOfGood">http://purl.org/goodrelations/v1#typeOfGood</seealso>
    let typeOfGood = Prefixed_Name(gr, "typeOfGood") |> PrefixedName
    /// <summary>
    ///   <para>gr:validFrom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property specifies the beginning of the validity of the gr:Offering, gr:PriceSpecification, gr:License, or gr:OpeningHoursSpecification.
    /// A time-zone should be specified. For a time in GMT/UTC, simply add a "Z" following the time:
    ///
    /// 2008-05-30T09:30:10Z.
    ///
    /// Alternatively, you can specify an offset from the UTC time by adding a positive or negative time following the time:
    ///
    /// 2008-05-30T09:30:10-09:00
    ///
    /// or
    ///
    /// 2008-05-30T09:30:10+09:00.
    ///
    /// Note: If multiple contradicting instances of a gr:Offering, gr:PriceSpecification, or gr:OpeningHoursSpecification exist, it is a good heuristics to assume that
    /// 1. Information with validity information for the respective period of time ranks higher than information without validity information.
    /// 2. Among conflicting nodes both having validity information, the one with the shorter validity span ranks higher."</para>
    /// labels<para>"valid from (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#validFrom">http://purl.org/goodrelations/v1#validFrom</seealso>
    let validFrom = Prefixed_Name(gr, "validFrom") |> PrefixedName
    /// <summary>
    ///   <para>gr:validThrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property specifies the end of the validity of the gr:Offering, gr:PriceSpecification, gr:License, or gr:OpeningHoursSpecification.
    /// A time-zone should be specified. For a time in GMT/UTC, simply add a "Z" following the time:
    ///
    /// 2008-05-30T09:30:10Z.
    ///
    /// Alternatively, you can specify an offset from the UTC time by adding a positive or negative time following the time:
    ///
    /// 2008-05-30T09:30:10-09:00
    ///
    /// or
    /// 2008-05-30T09:30:10+09:00.
    ///
    /// Note 1: If multiple contradicting instances of a gr:Offering, gr:PriceSpecification, or gr:OpeningHoursSpecification exist, it is a good heuristics to assume that
    /// 1. Information with validity information for the respective period of time ranks higher than information without validity information.
    /// 2. Among conflicting nodes both having validity information, the one with the shorter validity span ranks higher.
    /// Note 2: For Google, attaching a gr:validThrough statement to a gr:UnitPriceSpecification is mandatory.
    /// "</para>
    /// labels<para>"valid through (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#validThrough">http://purl.org/goodrelations/v1#validThrough</seealso>
    let validThrough = Prefixed_Name(gr, "validThrough") |> PrefixedName

    /// <summary>
    ///   <para>gr:valueAddedTaxIncluded</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the applicable value-added tax (VAT)  is included in the price of the gr:PriceSpecification or not.
    ///
    /// Note: This is a simple representation which may not properly reflect all details of local taxation."</para>
    /// labels<para>"value added tax included (0..1)"</para><para>"Value added tax included"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#valueAddedTaxIncluded">http://purl.org/goodrelations/v1#valueAddedTaxIncluded</seealso>
    let valueAddedTaxIncluded =
        Prefixed_Name(gr, "valueAddedTaxIncluded") |> PrefixedName

    /// <summary>
    ///   <para>gr:valueReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The superclass of properties that link a gr:QuantitativeValue or a gr:QualitativeValue to a second gr:QuantitativeValue or a gr:QualitativeValue that provides additional information on the original value. A good modeling practice is to define specializations of this property (e.g. foo:referenceTemperature) for your particular domain."</para>
    /// labels<para>"value reference (0..*)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#valueReference">http://purl.org/goodrelations/v1#valueReference</seealso>
    let valueReference = Prefixed_Name(gr, "valueReference") |> PrefixedName
    /// <summary>
    ///   <para>gr:vatID</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The Value-added Tax ID of the gr:BusinessEntity. See http://en.wikipedia.org/wiki/Value_added_tax_identification_number for details."</para>
    /// labels<para>"VAT ID (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#vatID">http://purl.org/goodrelations/v1#vatID</seealso>
    let vatID = Prefixed_Name(gr, "vatID") |> PrefixedName
    /// <summary>
    ///   <para>gr:weight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The weight of the gr:ProductOrService.
    /// Typical unit code(s): GRM for gram, KGM for kilogram, LBR for pound"</para>
    /// labels<para>"weight (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#weight">http://purl.org/goodrelations/v1#weight</seealso>
    let weight = Prefixed_Name(gr, "weight") |> PrefixedName
    /// <summary>
    ///   <para>gr:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The width of the gr:ProductOrService.
    /// Typical unit code(s): CMT for centimeters, INH for inches"</para>
    /// labels<para>"width (0..1)"</para></remarks>
    /// <seealso href="http://purl.org/goodrelations/v1#width">http://purl.org/goodrelations/v1#width</seealso>
    let width = Prefixed_Name(gr, "width") |> PrefixedName
