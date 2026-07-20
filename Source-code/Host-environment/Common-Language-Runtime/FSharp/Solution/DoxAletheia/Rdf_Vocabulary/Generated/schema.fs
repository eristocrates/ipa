namespace http.schema.org.slash

open DoxAletheia

module schema =
    let _namespace_name = "http://schema.org/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A radio channel that uses AM.
    /// <see href="http://schema.org/AMRadioChannel"></see></summary>
    let AMRadioChannel = _prefix "AMRadioChannel"
    /// <summary>
    /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
    /// <see href="http://schema.org/category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.
    /// <see href="http://schema.org/RadioChannel"></see></summary>
    let RadioChannel = _prefix "RadioChannel"
    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// <see href="http://schema.org/APIReference"></see></summary>
    let APIReference = _prefix "APIReference"
    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// <see href="http://schema.org/TechArticle"></see></summary>
    let TechArticle = _prefix "TechArticle"
    /// <summary>
    /// Web page type: About page.
    /// <see href="http://schema.org/AboutPage"></see></summary>
    let AboutPage = _prefix "AboutPage"
    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// <see href="http://schema.org/WebPage"></see></summary>
    let WebPage = _prefix "WebPage"
    /// <summary>
    /// The act of committing to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RejectAction"&gt;RejectAction&lt;/a&gt;: The antonym of AcceptAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/AcceptAction"></see></summary>
    let AcceptAction = _prefix "AcceptAction"
    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// <see href="http://schema.org/AllocateAction"></see></summary>
    let AllocateAction = _prefix "AllocateAction"
    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Accommodation"></see></summary>
    let Accommodation = _prefix "Accommodation"
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// <see href="http://schema.org/Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// Accountancy business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// <see href="http://schema.org/AccountingService"></see></summary>
    let AccountingService = _prefix "AccountingService"
    /// <summary>
    /// Financial services business.
    /// <see href="http://schema.org/FinancialService"></see></summary>
    let FinancialService = _prefix "FinancialService"
    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// <see href="http://schema.org/AchieveAction"></see></summary>
    let AchieveAction = _prefix "AchieveAction"
    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/04/announcing-schemaorg-actions.html"&gt;blog post&lt;/a&gt; and &lt;a href="http://schema.org/docs/actions.html"&gt;Actions overview document&lt;/a&gt;.
    /// <see href="http://schema.org/Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// The most generic type of item.
    /// <see href="http://schema.org/Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    /// A set of requirements that a must be fulfilled in order to perform an Action.
    /// <see href="http://schema.org/ActionAccessSpecification"></see></summary>
    let ActionAccessSpecification = _prefix "ActionAccessSpecification"
    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
    /// <see href="http://schema.org/Intangible"></see></summary>
    let Intangible = _prefix "Intangible"
    /// <summary>
    /// The status of an Action.
    /// <see href="http://schema.org/ActionStatusType"></see></summary>
    let ActionStatusType = _prefix "ActionStatusType"
    /// <summary>
    /// Lists or enumerations—for example, a list of cuisines or music genres, etc.
    /// <see href="http://schema.org/Enumeration"></see></summary>
    let Enumeration = _prefix "Enumeration"
    /// <summary>
    /// The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).
    /// <see href="http://schema.org/ActivateAction"></see></summary>
    let ActivateAction = _prefix "ActivateAction"
    /// <summary>
    /// An agent controls a device or application.
    /// <see href="http://schema.org/ControlAction"></see></summary>
    let ControlAction = _prefix "ControlAction"
    /// <summary>
    /// An in-progress action (e.g, while watching the movie, or driving to a location).
    /// <see href="http://schema.org/ActiveActionStatus"></see></summary>
    let ActiveActionStatus = _prefix "ActiveActionStatus"
    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// <see href="http://schema.org/AddAction"></see></summary>
    let AddAction = _prefix "AddAction"
    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// <see href="http://schema.org/UpdateAction"></see></summary>
    let UpdateAction = _prefix "UpdateAction"
    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// <see href="http://schema.org/AdministrativeArea"></see></summary>
    let AdministrativeArea = _prefix "AdministrativeArea"
    /// <summary>
    /// An adult entertainment establishment.
    /// <see href="http://schema.org/AdultEntertainment"></see></summary>
    let AdultEntertainment = _prefix "AdultEntertainment"
    /// <summary>
    /// A business providing entertainment.
    /// <see href="http://schema.org/EntertainmentBusiness"></see></summary>
    let EntertainmentBusiness = _prefix "EntertainmentBusiness"
    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: AggregateOffers are normally expected to associate multiple offers that all share the same defined &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; value, or default to http://purl.org/goodrelations/v1#Sell if businessFunction is not explicitly defined.
    /// <see href="http://schema.org/AggregateOffer"></see></summary>
    let AggregateOffer = _prefix "AggregateOffer"
    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: As the &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; property, which identifies the form of offer (e.g. sell, lease, repair, dispose), defaults to http://purl.org/goodrelations/v1#Sell; an Offer without a defined businessFunction value can be assumed to be an offer to sell.&lt;br/&gt;&lt;br/&gt;
    ///
    /// For &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GTIN&lt;/a&gt;-related fields, see &lt;a href="http://www.gs1.org/barcodes/support/check_digit_calculator"&gt;Check Digit calculator&lt;/a&gt; and &lt;a href="http://www.gs1us.org/resources/standards/gtin-validation-guide"&gt;validation guide&lt;/a&gt; from &lt;a href="http://www.gs1.org/"&gt;GS1&lt;/a&gt;.
    /// <see href="http://schema.org/Offer"></see></summary>
    let Offer = _prefix "Offer"
    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// <see href="http://schema.org/AggregateRating"></see></summary>
    let AggregateRating = _prefix "AggregateRating"
    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// <see href="http://schema.org/Rating"></see></summary>
    let Rating = _prefix "Rating"
    /// <summary>
    /// The act of expressing a consistency of opinion with the object. An agent agrees to/about an object (a proposition, topic or theme) with participants.
    /// <see href="http://schema.org/AgreeAction"></see></summary>
    let AgreeAction = _prefix "AgreeAction"
    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// <see href="http://schema.org/ReactAction"></see></summary>
    let ReactAction = _prefix "ReactAction"
    /// <summary>
    /// An organization that provides flights for passengers.
    /// <see href="http://schema.org/Airline"></see></summary>
    let Airline = _prefix "Airline"
    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// <see href="http://schema.org/Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// An airport.
    /// <see href="http://schema.org/Airport"></see></summary>
    let Airport = _prefix "Airport"
    /// <summary>
    /// A public structure, such as a town hall or concert hall.
    /// <see href="http://schema.org/CivicStructure"></see></summary>
    let CivicStructure = _prefix "CivicStructure"
    /// <summary>
    /// AlbumRelease.
    /// <see href="http://schema.org/AlbumRelease"></see></summary>
    let AlbumRelease = _prefix "AlbumRelease"
    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// <see href="http://schema.org/MusicAlbumReleaseType"></see></summary>
    let MusicAlbumReleaseType = _prefix "MusicAlbumReleaseType"
    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// <see href="http://schema.org/AlignmentObject"></see></summary>
    let AlignmentObject = _prefix "AlignmentObject"
    /// <summary>
    /// All-wheel Drive is a transmission layout where the engine drives all four wheels.
    /// <see href="http://schema.org/AllWheelDriveConfiguration"></see></summary>
    let AllWheelDriveConfiguration = _prefix "AllWheelDriveConfiguration"
    /// <summary>
    /// A value indicating which roadwheels will receive torque.
    /// <see href="http://schema.org/DriveWheelConfigurationValue"></see></summary>
    let DriveWheelConfigurationValue = _prefix "DriveWheelConfigurationValue"
    /// <summary>
    /// The act of manipulating/administering/supervising/controlling one or more objects.
    /// <see href="http://schema.org/OrganizeAction"></see></summary>
    let OrganizeAction = _prefix "OrganizeAction"
    /// <summary>
    /// An amusement park.
    /// <see href="http://schema.org/AmusementPark"></see></summary>
    let AmusementPark = _prefix "AmusementPark"
    /// <summary>
    /// Animal shelter.
    /// <see href="http://schema.org/AnimalShelter"></see></summary>
    let AnimalShelter = _prefix "AnimalShelter"
    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// <see href="http://schema.org/LocalBusiness"></see></summary>
    let LocalBusiness = _prefix "LocalBusiness"
    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// <see href="http://schema.org/Answer"></see></summary>
    let Answer = _prefix "Answer"
    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the &lt;a class="localLink" href="http://schema.org/text"&gt;text&lt;/a&gt; property, and its topic via &lt;a class="localLink" href="http://schema.org/about"&gt;about&lt;/a&gt;, properties shared with all CreativeWorks.
    /// <see href="http://schema.org/Comment"></see></summary>
    let Comment = _prefix "Comment"
    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).
    /// <see href="http://schema.org/Apartment"></see></summary>
    let Apartment = _prefix "Apartment"
    /// <summary>
    /// Residence type: Apartment complex.
    /// <see href="http://schema.org/ApartmentComplex"></see></summary>
    let ApartmentComplex = _prefix "ApartmentComplex"
    /// <summary>
    /// The place where a person lives.
    /// <see href="http://schema.org/Residence"></see></summary>
    let Residence = _prefix "Residence"
    /// <summary>
    /// The act of inserting at the end if an ordered collection.
    /// <see href="http://schema.org/AppendAction"></see></summary>
    let AppendAction = _prefix "AppendAction"
    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// <see href="http://schema.org/InsertAction"></see></summary>
    let InsertAction = _prefix "InsertAction"
    /// <summary>
    /// The act of registering to an organization/service without the guarantee to receive it.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/ApplyAction"></see></summary>
    let ApplyAction = _prefix "ApplyAction"
    /// <summary>
    /// Aquarium.
    /// <see href="http://schema.org/Aquarium"></see></summary>
    let Aquarium = _prefix "Aquarium"
    /// <summary>
    /// The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.
    /// <see href="http://schema.org/ArriveAction"></see></summary>
    let ArriveAction = _prefix "ArriveAction"
    /// <summary>
    /// The act of an agent relocating to a place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TransferAction"&gt;TransferAction&lt;/a&gt;: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/MoveAction"></see></summary>
    let MoveAction = _prefix "MoveAction"
    /// <summary>
    /// An art gallery.
    /// <see href="http://schema.org/ArtGallery"></see></summary>
    let ArtGallery = _prefix "ArtGallery"
    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// <see href="http://schema.org/CreativeWork"></see></summary>
    let CreativeWork = _prefix "CreativeWork"
    /// <summary>
    /// The act of posing a question / favor to someone.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/AskAction"></see></summary>
    let AskAction = _prefix "AskAction"
    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// <see href="http://schema.org/CommunicateAction"></see></summary>
    let CommunicateAction = _prefix "CommunicateAction"
    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// <see href="http://schema.org/AssessAction"></see></summary>
    let AssessAction = _prefix "AssessAction"
    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// <see href="http://schema.org/AssignAction"></see></summary>
    let AssignAction = _prefix "AssignAction"
    /// <summary>
    /// Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    ///
    /// This type is deprecated - &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.
    /// <see href="http://schema.org/Attorney"></see></summary>
    let Attorney = _prefix "Attorney"
    /// <summary>
    /// A LegalService is a business that provides legally-oriented services, advice and representation, e.g. law firms.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// <see href="http://schema.org/LegalService"></see></summary>
    let LegalService = _prefix "LegalService"
    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// <see href="http://schema.org/Audience"></see></summary>
    let Audience = _prefix "Audience"
    /// <summary>
    /// An audio file.
    /// <see href="http://schema.org/AudioObject"></see></summary>
    let AudioObject = _prefix "AudioObject"
    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// <see href="http://schema.org/MediaObject"></see></summary>
    let MediaObject = _prefix "MediaObject"
    /// <summary>
    /// Book format: Audiobook. This is an enumerated value for use with the bookFormat property. There is also a type 'Audiobook' in the bib extension which includes Audiobook specific properties.
    /// <see href="http://schema.org/AudiobookFormat"></see></summary>
    let AudiobookFormat = _prefix "AudiobookFormat"
    /// <summary>
    /// The publication format of the book.
    /// <see href="http://schema.org/BookFormatType"></see></summary>
    let BookFormatType = _prefix "BookFormatType"
    /// <summary>
    /// The act of granting permission to an object.
    /// <see href="http://schema.org/AuthorizeAction"></see></summary>
    let AuthorizeAction = _prefix "AuthorizeAction"
    /// <summary>
    /// Auto body shop.
    /// <see href="http://schema.org/AutoBodyShop"></see></summary>
    let AutoBodyShop = _prefix "AutoBodyShop"
    /// <summary>
    /// Car repair, sales, or parts.
    /// <see href="http://schema.org/AutomotiveBusiness"></see></summary>
    let AutomotiveBusiness = _prefix "AutomotiveBusiness"
    /// <summary>
    /// An car dealership.
    /// <see href="http://schema.org/AutoDealer"></see></summary>
    let AutoDealer = _prefix "AutoDealer"
    /// <summary>
    /// An auto parts store.
    /// <see href="http://schema.org/AutoPartsStore"></see></summary>
    let AutoPartsStore = _prefix "AutoPartsStore"
    /// <summary>
    /// A retail good store.
    /// <see href="http://schema.org/Store"></see></summary>
    let Store = _prefix "Store"
    /// <summary>
    /// A car rental business.
    /// <see href="http://schema.org/AutoRental"></see></summary>
    let AutoRental = _prefix "AutoRental"
    /// <summary>
    /// Car repair business.
    /// <see href="http://schema.org/AutoRepair"></see></summary>
    let AutoRepair = _prefix "AutoRepair"
    /// <summary>
    /// A car wash business.
    /// <see href="http://schema.org/AutoWash"></see></summary>
    let AutoWash = _prefix "AutoWash"
    /// <summary>
    /// ATM/cash machine.
    /// <see href="http://schema.org/AutomatedTeller"></see></summary>
    let AutomatedTeller = _prefix "AutomatedTeller"
    /// <summary>
    /// A bakery.
    /// <see href="http://schema.org/Bakery"></see></summary>
    let Bakery = _prefix "Bakery"
    /// <summary>
    /// A food-related business.
    /// <see href="http://schema.org/FoodEstablishment"></see></summary>
    let FoodEstablishment = _prefix "FoodEstablishment"
    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// <see href="http://schema.org/BankAccount"></see></summary>
    let BankAccount = _prefix "BankAccount"
    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// <see href="http://schema.org/FinancialProduct"></see></summary>
    let FinancialProduct = _prefix "FinancialProduct"
    /// <summary>
    /// Bank or credit union.
    /// <see href="http://schema.org/BankOrCreditUnion"></see></summary>
    let BankOrCreditUnion = _prefix "BankOrCreditUnion"
    /// <summary>
    /// A bar or pub.
    /// <see href="http://schema.org/BarOrPub"></see></summary>
    let BarOrPub = _prefix "BarOrPub"
    /// <summary>
    /// An image of a visual machine-readable code such as a barcode or QR code.
    /// <see href="http://schema.org/Barcode"></see></summary>
    let Barcode = _prefix "Barcode"
    /// <summary>
    /// An image file.
    /// <see href="http://schema.org/ImageObject"></see></summary>
    let ImageObject = _prefix "ImageObject"
    /// <summary>
    /// Beach.
    /// <see href="http://schema.org/Beach"></see></summary>
    let Beach = _prefix "Beach"
    /// <summary>
    /// Beauty salon.
    /// <see href="http://schema.org/BeautySalon"></see></summary>
    let BeautySalon = _prefix "BeautySalon"
    /// <summary>
    /// Health and beauty.
    /// <see href="http://schema.org/HealthAndBeautyBusiness"></see></summary>
    let HealthAndBeautyBusiness = _prefix "HealthAndBeautyBusiness"
    /// <summary>
    /// Bed and breakfast.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/BedAndBreakfast"></see></summary>
    let BedAndBreakfast = _prefix "BedAndBreakfast"
    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// <see href="http://schema.org/LodgingBusiness"></see></summary>
    let LodgingBusiness = _prefix "LodgingBusiness"
    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also &lt;a class="localLink" href="http://schema.org/BedType"&gt;BedType&lt;/a&gt; (under development).
    /// <see href="http://schema.org/BedDetails"></see></summary>
    let BedDetails = _prefix "BedDetails"
    /// <summary>
    /// A type of bed. This is used for indicating the bed or beds available in an accommodation.
    /// <see href="http://schema.org/BedType"></see></summary>
    let BedType = _prefix "BedType"
    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// <see href="http://schema.org/QualitativeValue"></see></summary>
    let QualitativeValue = _prefix "QualitativeValue"
    /// <summary>
    /// The act of forming a personal connection with someone (object) mutually/bidirectionally/symmetrically.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, BefriendAction implies that the connection is reciprocal.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/BefriendAction"></see></summary>
    let BefriendAction = _prefix "BefriendAction"
    /// <summary>
    /// The act of interacting with another person or organization.
    /// <see href="http://schema.org/InteractAction"></see></summary>
    let InteractAction = _prefix "InteractAction"
    /// <summary>
    /// A bike store.
    /// <see href="http://schema.org/BikeStore"></see></summary>
    let BikeStore = _prefix "BikeStore"
    /// <summary>
    /// A blog.
    /// <see href="http://schema.org/Blog"></see></summary>
    let Blog = _prefix "Blog"
    /// <summary>
    /// A blog post.
    /// <see href="http://schema.org/BlogPosting"></see></summary>
    let BlogPosting = _prefix "BlogPosting"
    /// <summary>
    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    /// <see href="http://schema.org/SocialMediaPosting"></see></summary>
    let SocialMediaPosting = _prefix "SocialMediaPosting"
    /// <summary>
    /// A type of boarding policy used by an airline.
    /// <see href="http://schema.org/BoardingPolicyType"></see></summary>
    let BoardingPolicyType = _prefix "BoardingPolicyType"
    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// <see href="http://schema.org/BodyOfWater"></see></summary>
    let BodyOfWater = _prefix "BodyOfWater"
    /// <summary>
    /// A landform or physical feature.  Landform elements include mountains, plains, lakes, rivers, seascape and oceanic waterbody interface features such as bays, peninsulas, seas and so forth, including sub-aqueous terrain features such as submersed mountain ranges, volcanoes, and the great ocean basins.
    /// <see href="http://schema.org/Landform"></see></summary>
    let Landform = _prefix "Landform"
    /// <summary>
    /// A book.
    /// <see href="http://schema.org/Book"></see></summary>
    let Book = _prefix "Book"
    /// <summary>
    /// A series of books. Included books can be indicated with the hasPart property.
    /// <see href="http://schema.org/BookSeries"></see></summary>
    let BookSeries = _prefix "BookSeries"
    /// <summary>
    /// A CreativeWorkSeries in schema.org is a group of related items, typically but not necessarily of the same kind. CreativeWorkSeries are usually organized into some order, often chronological. Unlike &lt;a class="localLink" href="http://schema.org/ItemList"&gt;ItemList&lt;/a&gt; which is a general purpose data structure for lists of things, the emphasis with CreativeWorkSeries is on published materials (written e.g. books and periodicals, or media such as tv, radio and games).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Specific subtypes are available for describing &lt;a class="localLink" href="http://schema.org/TVSeries"&gt;TVSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RadioSeries"&gt;RadioSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/MovieSeries"&gt;MovieSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/BookSeries"&gt;BookSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Periodical"&gt;Periodical&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/VideoGameSeries"&gt;VideoGameSeries&lt;/a&gt;. In each case, the &lt;a class="localLink" href="http://schema.org/hasPart"&gt;hasPart&lt;/a&gt; / &lt;a class="localLink" href="http://schema.org/isPartOf"&gt;isPartOf&lt;/a&gt; properties can be used to relate the CreativeWorkSeries to its parts. The general CreativeWorkSeries type serves largely just to organize these more specific and practical subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// It is common for properties applicable to an item from the series to be usefully applied to the containing group. Schema.org attempts to anticipate some of these cases, but publishers should be free to apply properties of the series parts to the series as a whole wherever they seem appropriate.
    /// <see href="http://schema.org/CreativeWorkSeries"></see></summary>
    let CreativeWorkSeries = _prefix "CreativeWorkSeries"
    /// <summary>
    /// A bookstore.
    /// <see href="http://schema.org/BookStore"></see></summary>
    let BookStore = _prefix "BookStore"
    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// <see href="http://schema.org/BookmarkAction"></see></summary>
    let BookmarkAction = _prefix "BookmarkAction"
    /// <summary>
    /// Boolean: True or False.
    /// <see href="http://schema.org/Boolean"></see></summary>
    let Boolean = _prefix "Boolean"
    /// <summary>
    /// The basic data types such as Integers, Strings, etc.
    /// <see href="http://schema.org/DataType"></see></summary>
    let DataType = _prefix "DataType"
    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/BorrowAction"></see></summary>
    let BorrowAction = _prefix "BorrowAction"
    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// <see href="http://schema.org/TransferAction"></see></summary>
    let TransferAction = _prefix "TransferAction"
    /// <summary>
    /// A bowling alley.
    /// <see href="http://schema.org/BowlingAlley"></see></summary>
    let BowlingAlley = _prefix "BowlingAlley"
    /// <summary>
    /// A sports location, such as a playing field.
    /// <see href="http://schema.org/SportsActivityLocation"></see></summary>
    let SportsActivityLocation = _prefix "SportsActivityLocation"
    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// <see href="http://schema.org/Brand"></see></summary>
    let Brand = _prefix "Brand"
    /// <summary>
    /// A BreadcrumbList is an ItemList consisting of a chain of linked Web pages, typically described using at least their URL and their name, and typically ending with the current page.&lt;br/&gt;&lt;br/&gt;
    ///
    /// The &lt;a class="localLink" href="http://schema.org/position"&gt;position&lt;/a&gt; property is used to reconstruct the order of the items in a BreadcrumbList The convention is that a breadcrumb list has an &lt;a class="localLink" href="http://schema.org/itemListOrder"&gt;itemListOrder&lt;/a&gt; of &lt;a class="localLink" href="http://schema.org/ItemListOrderAscending"&gt;ItemListOrderAscending&lt;/a&gt; (lower values listed first), and that the first items in this list correspond to the "top" or beginning of the breadcrumb trail, e.g. with a site or section homepage. The specific values of 'position' are not assigned meaning for a BreadcrumbList, but they should be integers, e.g. beginning with '1' for the first item in the list.
    /// <see href="http://schema.org/BreadcrumbList"></see></summary>
    let BreadcrumbList = _prefix "BreadcrumbList"
    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// <see href="http://schema.org/ItemList"></see></summary>
    let ItemList = _prefix "ItemList"
    /// <summary>
    /// Brewery.
    /// <see href="http://schema.org/Brewery"></see></summary>
    let Brewery = _prefix "Brewery"
    /// <summary>
    /// A bridge.
    /// <see href="http://schema.org/Bridge"></see></summary>
    let Bridge = _prefix "Bridge"
    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// <see href="http://schema.org/BroadcastChannel"></see></summary>
    let BroadcastChannel = _prefix "BroadcastChannel"
    /// <summary>
    /// An over the air or online broadcast event.
    /// <see href="http://schema.org/BroadcastEvent"></see></summary>
    let BroadcastEvent = _prefix "BroadcastEvent"
    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// <see href="http://schema.org/PublicationEvent"></see></summary>
    let PublicationEvent = _prefix "PublicationEvent"
    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// <see href="http://schema.org/BroadcastFrequencySpecification"></see></summary>
    let BroadcastFrequencySpecification = _prefix "BroadcastFrequencySpecification"
    /// <summary>
    /// BroadcastRelease.
    /// <see href="http://schema.org/BroadcastRelease"></see></summary>
    let BroadcastRelease = _prefix "BroadcastRelease"
    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// <see href="http://schema.org/BroadcastService"></see></summary>
    let BroadcastService = _prefix "BroadcastService"
    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// <see href="http://schema.org/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// A Buddhist temple.
    /// <see href="http://schema.org/BuddhistTemple"></see></summary>
    let BuddhistTemple = _prefix "BuddhistTemple"
    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// <see href="http://schema.org/PlaceOfWorship"></see></summary>
    let PlaceOfWorship = _prefix "PlaceOfWorship"
    /// <summary>
    /// A reservation for bus travel. &lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/BusReservation"></see></summary>
    let BusReservation = _prefix "BusReservation"
    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. &lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/Reservation"></see></summary>
    let Reservation = _prefix "Reservation"
    /// <summary>
    /// A bus station.
    /// <see href="http://schema.org/BusStation"></see></summary>
    let BusStation = _prefix "BusStation"
    /// <summary>
    /// A bus stop.
    /// <see href="http://schema.org/BusStop"></see></summary>
    let BusStop = _prefix "BusStop"
    /// <summary>
    /// A trip on a commercial bus line.
    /// <see href="http://schema.org/BusTrip"></see></summary>
    let BusTrip = _prefix "BusTrip"
    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// <see href="http://schema.org/Trip"></see></summary>
    let Trip = _prefix "Trip"
    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// <see href="http://schema.org/BusinessAudience"></see></summary>
    let BusinessAudience = _prefix "BusinessAudience"
    /// <summary>
    /// A business entity type is a conceptual entity representing the legal form, the size, the main line of business, the position in the value chain, or any combination thereof, of an organization or business person.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Business&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Enduser&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PublicInstitution&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Reseller&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/BusinessEntityType"></see></summary>
    let BusinessEntityType = _prefix "BusinessEntityType"
    /// <summary>
    /// Event type: Business event.
    /// <see href="http://schema.org/BusinessEvent"></see></summary>
    let BusinessEvent = _prefix "BusinessEvent"
    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the &lt;a class="localLink" href="http://schema.org/offers"&gt;offers&lt;/a&gt; property. Repeated events may be structured as separate Event objects.
    /// <see href="http://schema.org/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// The business function specifies the type of activity or access (i.e., the bundle of rights) offered by the organization or business person through the offer. Typical are sell, rental or lease, maintenance or repair, manufacture / produce, recycle / dispose, engineering / construction, or installation. Proprietary specifications of access rights are also instances of this class.&lt;br/&gt;&lt;br/&gt;
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
    ///
    /// <see href="http://schema.org/BusinessFunction"></see></summary>
    let BusinessFunction = _prefix "BusinessFunction"
    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    /// <see href="http://schema.org/BuyAction"></see></summary>
    let BuyAction = _prefix "BuyAction"
    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// <see href="http://schema.org/TradeAction"></see></summary>
    let TradeAction = _prefix "TradeAction"
    /// <summary>
    /// CDFormat.
    /// <see href="http://schema.org/CDFormat"></see></summary>
    let CDFormat = _prefix "CDFormat"
    /// <summary>
    /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
    /// <see href="http://schema.org/MusicReleaseFormatType"></see></summary>
    let MusicReleaseFormatType = _prefix "MusicReleaseFormatType"
    /// <summary>
    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    /// <see href="http://schema.org/CableOrSatelliteService"></see></summary>
    let CableOrSatelliteService = _prefix "CableOrSatelliteService"
    /// <summary>
    /// A cafe or coffee shop.
    /// <see href="http://schema.org/CafeOrCoffeeShop"></see></summary>
    let CafeOrCoffeeShop = _prefix "CafeOrCoffeeShop"
    /// <summary>
    /// A camping site, campsite, or &lt;a class="localLink" href="http://schema.org/Campground"&gt;Campground&lt;/a&gt; is a place used for overnight stay in the outdoors, typically containing individual &lt;a class="localLink" href="http://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; locations. &lt;br/&gt;&lt;br/&gt;
    ///
    /// In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Campground"></see></summary>
    let Campground = _prefix "Campground"
    /// <summary>
    /// A &lt;a class="localLink" href="http://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; is an individual place for overnight stay in the outdoors, typically being part of a larger camping site, or &lt;a class="localLink" href="http://schema.org/Campground"&gt;Campground&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// In British English a campsite, or campground, is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites.
    /// (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/CampingPitch"></see></summary>
    let CampingPitch = _prefix "CampingPitch"
    /// <summary>
    /// A canal, like the Panama Canal.
    /// <see href="http://schema.org/Canal"></see></summary>
    let Canal = _prefix "Canal"
    /// <summary>
    /// The act of asserting that a future event/action is no longer going to happen.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: The antonym of CancelAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/CancelAction"></see></summary>
    let CancelAction = _prefix "CancelAction"
    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// <see href="http://schema.org/PlanAction"></see></summary>
    let PlanAction = _prefix "PlanAction"
    /// <summary>
    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    /// <see href="http://schema.org/Car"></see></summary>
    let Car = _prefix "Car"
    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// <see href="http://schema.org/Vehicle"></see></summary>
    let Vehicle = _prefix "Vehicle"
    /// <summary>
    /// A casino.
    /// <see href="http://schema.org/Casino"></see></summary>
    let Casino = _prefix "Casino"
    /// <summary>
    /// CassetteFormat.
    /// <see href="http://schema.org/CassetteFormat"></see></summary>
    let CassetteFormat = _prefix "CassetteFormat"
    /// <summary>
    /// A Catholic church.
    /// <see href="http://schema.org/CatholicChurch"></see></summary>
    let CatholicChurch = _prefix "CatholicChurch"
    /// <summary>
    /// A church.
    /// <see href="http://schema.org/Church"></see></summary>
    let Church = _prefix "Church"
    /// <summary>
    /// A graveyard.
    /// <see href="http://schema.org/Cemetery"></see></summary>
    let Cemetery = _prefix "Cemetery"
    /// <summary>
    /// An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.
    /// <see href="http://schema.org/CheckAction"></see></summary>
    let CheckAction = _prefix "CheckAction"
    /// <summary>
    /// The act of finding an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SearchAction"&gt;SearchAction&lt;/a&gt;: FindAction is generally lead by a SearchAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/FindAction"></see></summary>
    let FindAction = _prefix "FindAction"
    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their arrival by registering/confirming for a previously reserved service (e.g. flight check in) or at a place (e.g. hotel), possibly resulting in a result (boarding pass, etc).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CheckOutAction"&gt;CheckOutAction&lt;/a&gt;: The antonym of CheckInAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ArriveAction"&gt;ArriveAction&lt;/a&gt;: Unlike ArriveAction, CheckInAction implies that the agent is informing/confirming the start of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: Unlike ConfirmAction, CheckInAction implies that the agent is informing/confirming the &lt;em&gt;start&lt;/em&gt; of a previously reserved service rather than its validity/existence.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/CheckInAction"></see></summary>
    let CheckInAction = _prefix "CheckInAction"
    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their departure of a previously reserved service (e.g. flight check in) or place (e.g. hotel).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CheckInAction"&gt;CheckInAction&lt;/a&gt;: The antonym of CheckOutAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/DepartAction"&gt;DepartAction&lt;/a&gt;: Unlike DepartAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: Unlike CancelAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/CheckOutAction"></see></summary>
    let CheckOutAction = _prefix "CheckOutAction"
    /// <summary>
    /// Web page type: Checkout page.
    /// <see href="http://schema.org/CheckoutPage"></see></summary>
    let CheckoutPage = _prefix "CheckoutPage"
    /// <summary>
    /// A Childcare center.
    /// <see href="http://schema.org/ChildCare"></see></summary>
    let ChildCare = _prefix "ChildCare"
    /// <summary>
    /// Event type: Children's event.
    /// <see href="http://schema.org/ChildrensEvent"></see></summary>
    let ChildrensEvent = _prefix "ChildrensEvent"
    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// <see href="http://schema.org/ChooseAction"></see></summary>
    let ChooseAction = _prefix "ChooseAction"
    /// <summary>
    /// A city or town.
    /// <see href="http://schema.org/City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// A city hall.
    /// <see href="http://schema.org/CityHall"></see></summary>
    let CityHall = _prefix "CityHall"
    /// <summary>
    /// A government building.
    /// <see href="http://schema.org/GovernmentBuilding"></see></summary>
    let GovernmentBuilding = _prefix "GovernmentBuilding"
    /// <summary>
    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    /// <see href="http://schema.org/ClaimReview"></see></summary>
    let ClaimReview = _prefix "ClaimReview"
    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// <see href="http://schema.org/Review"></see></summary>
    let Review = _prefix "Review"
    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// <see href="http://schema.org/Clip"></see></summary>
    let Clip = _prefix "Clip"
    /// <summary>
    /// A clothing store.
    /// <see href="http://schema.org/ClothingStore"></see></summary>
    let ClothingStore = _prefix "ClothingStore"
    /// <summary>
    /// Play mode: CoOp. Co-operative games, where you play on the same team with friends.
    /// <see href="http://schema.org/CoOp"></see></summary>
    let CoOp = _prefix "CoOp"
    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.
    /// <see href="http://schema.org/GamePlayMode"></see></summary>
    let GamePlayMode = _prefix "GamePlayMode"
    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// <see href="http://schema.org/Code"></see></summary>
    let Code = _prefix "Code"
    /// <summary>
    ///   <see href="http://schema.org/supersededBy"></see>
    /// </summary>
    let supersededBy = _prefix "supersededBy"
    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// <see href="http://schema.org/SoftwareSourceCode"></see></summary>
    let SoftwareSourceCode = _prefix "SoftwareSourceCode"
    /// <summary>
    /// Web page type: Collection page.
    /// <see href="http://schema.org/CollectionPage"></see></summary>
    let CollectionPage = _prefix "CollectionPage"
    /// <summary>
    /// A college, university, or other third-level educational institution.
    /// <see href="http://schema.org/CollegeOrUniversity"></see></summary>
    let CollegeOrUniversity = _prefix "CollegeOrUniversity"
    /// <summary>
    /// An educational organization.
    /// <see href="http://schema.org/EducationalOrganization"></see></summary>
    let EducationalOrganization = _prefix "EducationalOrganization"
    /// <summary>
    /// A comedy club.
    /// <see href="http://schema.org/ComedyClub"></see></summary>
    let ComedyClub = _prefix "ComedyClub"
    /// <summary>
    /// Event type: Comedy event.
    /// <see href="http://schema.org/ComedyEvent"></see></summary>
    let ComedyEvent = _prefix "ComedyEvent"
    /// <summary>
    /// The act of generating a comment about a subject.
    /// <see href="http://schema.org/CommentAction"></see></summary>
    let CommentAction = _prefix "CommentAction"
    /// <summary>
    /// Permission to add comments to the document.
    /// <see href="http://schema.org/CommentPermission"></see></summary>
    let CommentPermission = _prefix "CommentPermission"
    /// <summary>
    /// A type of permission which can be granted for accessing a digital document.
    /// <see href="http://schema.org/DigitalDocumentPermissionType"></see></summary>
    let DigitalDocumentPermissionType = _prefix "DigitalDocumentPermissionType"
    /// <summary>
    /// CompilationAlbum.
    /// <see href="http://schema.org/CompilationAlbum"></see></summary>
    let CompilationAlbum = _prefix "CompilationAlbum"
    /// <summary>
    /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
    /// <see href="http://schema.org/MusicAlbumProductionType"></see></summary>
    let MusicAlbumProductionType = _prefix "MusicAlbumProductionType"
    /// <summary>
    /// An action that has already taken place.
    /// <see href="http://schema.org/CompletedActionStatus"></see></summary>
    let CompletedActionStatus = _prefix "CompletedActionStatus"
    /// <summary>
    /// A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use the name property of the attached unit price specification for indicating the dimension of a price component (e.g. "electricity" or "final cleaning").
    /// <see href="http://schema.org/CompoundPriceSpecification"></see></summary>
    let CompoundPriceSpecification = _prefix "CompoundPriceSpecification"
    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; to describe independent amounts of money such as a salary, credit card limits, etc.
    /// <see href="http://schema.org/PriceSpecification"></see></summary>
    let PriceSpecification = _prefix "PriceSpecification"
    /// <summary>
    /// This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the &lt;a class="localLink" href="http://schema.org/Language"&gt;Language&lt;/a&gt; type.
    /// <see href="http://schema.org/ComputerLanguage"></see></summary>
    let ComputerLanguage = _prefix "ComputerLanguage"
    /// <summary>
    /// A computer store.
    /// <see href="http://schema.org/ComputerStore"></see></summary>
    let ComputerStore = _prefix "ComputerStore"
    /// <summary>
    /// The act of notifying someone that a future event/action is going to happen as expected.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: The antonym of ConfirmAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/ConfirmAction"></see></summary>
    let ConfirmAction = _prefix "ConfirmAction"
    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// <see href="http://schema.org/InformAction"></see></summary>
    let InformAction = _prefix "InformAction"
    /// <summary>
    /// The act of ingesting information/resources/food.
    /// <see href="http://schema.org/ConsumeAction"></see></summary>
    let ConsumeAction = _prefix "ConsumeAction"
    /// <summary>
    /// Web page type: Contact page.
    /// <see href="http://schema.org/ContactPage"></see></summary>
    let ContactPage = _prefix "ContactPage"
    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// <see href="http://schema.org/ContactPoint"></see></summary>
    let ContactPoint = _prefix "ContactPoint"
    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// <see href="http://schema.org/StructuredValue"></see></summary>
    let StructuredValue = _prefix "StructuredValue"
    /// <summary>
    /// Enumerated options related to a ContactPoint.
    /// <see href="http://schema.org/ContactPointOption"></see></summary>
    let ContactPointOption = _prefix "ContactPointOption"
    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// <see href="http://schema.org/Continent"></see></summary>
    let Continent = _prefix "Continent"
    /// <summary>
    /// A convenience store.
    /// <see href="http://schema.org/ConvenienceStore"></see></summary>
    let ConvenienceStore = _prefix "ConvenienceStore"
    /// <summary>
    /// One or more messages between organizations or people on a particular topic. Individual messages can be linked to the conversation with isPartOf or hasPart properties.
    /// <see href="http://schema.org/Conversation"></see></summary>
    let Conversation = _prefix "Conversation"
    /// <summary>
    /// The act of producing/preparing food.
    /// <see href="http://schema.org/CookAction"></see></summary>
    let CookAction = _prefix "CookAction"
    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// <see href="http://schema.org/CreateAction"></see></summary>
    let CreateAction = _prefix "CreateAction"
    /// <summary>
    /// Organization: A business corporation.
    /// <see href="http://schema.org/Corporation"></see></summary>
    let Corporation = _prefix "Corporation"
    /// <summary>
    /// A country.
    /// <see href="http://schema.org/Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// <see href="http://schema.org/Course"></see></summary>
    let Course = _prefix "Course"
    /// <summary>
    /// An instance of a &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// <see href="http://schema.org/CourseInstance"></see></summary>
    let CourseInstance = _prefix "CourseInstance"
    /// <summary>
    /// A courthouse.
    /// <see href="http://schema.org/Courthouse"></see></summary>
    let Courthouse = _prefix "Courthouse"
    /// <summary>
    /// A media season e.g. tv, radio, video game etc.
    /// <see href="http://schema.org/CreativeWorkSeason"></see></summary>
    let CreativeWorkSeason = _prefix "CreativeWorkSeason"
    /// <summary>
    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also &lt;a class="localLink" href="http://schema.org/CreativeWorkSeries"&gt;CreativeWorkSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/EventSeries"&gt;EventSeries&lt;/a&gt;.
    /// <see href="http://schema.org/Series"></see></summary>
    let Series = _prefix "Series"
    /// <summary>
    /// A card payment method of a particular brand or name.  Used to mark up a particular payment method and/or the financial product/service that supplies the card account.&lt;br/&gt;&lt;br/&gt;
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
    ///
    /// <see href="http://schema.org/CreditCard"></see></summary>
    let CreditCard = _prefix "CreditCard"
    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// <see href="http://schema.org/LoanOrCredit"></see></summary>
    let LoanOrCredit = _prefix "LoanOrCredit"
    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// <see href="http://schema.org/PaymentCard"></see></summary>
    let PaymentCard = _prefix "PaymentCard"
    /// <summary>
    /// A crematorium.
    /// <see href="http://schema.org/Crematorium"></see></summary>
    let Crematorium = _prefix "Crematorium"
    /// <summary>
    /// A service to convert funds from one currency to another currency.
    /// <see href="http://schema.org/CurrencyConversionService"></see></summary>
    let CurrencyConversionService = _prefix "CurrencyConversionService"
    /// <summary>
    /// DJMixAlbum.
    /// <see href="http://schema.org/DJMixAlbum"></see></summary>
    let DJMixAlbum = _prefix "DJMixAlbum"
    /// <summary>
    /// DVDFormat.
    /// <see href="http://schema.org/DVDFormat"></see></summary>
    let DVDFormat = _prefix "DVDFormat"
    /// <summary>
    /// Indicates that the item is damaged.
    /// <see href="http://schema.org/DamagedCondition"></see></summary>
    let DamagedCondition = _prefix "DamagedCondition"
    /// <summary>
    /// A list of possible conditions for the item.
    /// <see href="http://schema.org/OfferItemCondition"></see></summary>
    let OfferItemCondition = _prefix "OfferItemCondition"
    /// <summary>
    /// Event type: A social dance.
    /// <see href="http://schema.org/DanceEvent"></see></summary>
    let DanceEvent = _prefix "DanceEvent"
    /// <summary>
    /// A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    /// <see href="http://schema.org/DanceGroup"></see></summary>
    let DanceGroup = _prefix "DanceGroup"
    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// <see href="http://schema.org/PerformingGroup"></see></summary>
    let PerformingGroup = _prefix "PerformingGroup"
    /// <summary>
    /// A collection of datasets.
    /// <see href="http://schema.org/DataCatalog"></see></summary>
    let DataCatalog = _prefix "DataCatalog"
    /// <summary>
    /// A dataset in downloadable form.
    /// <see href="http://schema.org/DataDownload"></see></summary>
    let DataDownload = _prefix "DataDownload"
    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// <see href="http://schema.org/DataFeed"></see></summary>
    let DataFeed = _prefix "DataFeed"
    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// <see href="http://schema.org/Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// A single item within a larger data feed.
    /// <see href="http://schema.org/DataFeedItem"></see></summary>
    let DataFeedItem = _prefix "DataFeedItem"
    /// <summary>
    /// A date value in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
    /// <see href="http://schema.org/Date"></see></summary>
    let Date = _prefix "Date"
    /// <summary>
    /// A combination of date and time of day in the form [-]CCYY-MM-DDThh:mm:ss[Z|(+|-)hh:mm] (see Chapter 5.4 of ISO 8601).
    /// <see href="http://schema.org/DateTime"></see></summary>
    let DateTime = _prefix "DateTime"
    /// <summary>
    /// A DatedMoneySpecification represents monetary values with optional start and end dates. For example, this could represent an employee's salary over a specific period of time. &lt;strong&gt;Note:&lt;/strong&gt; This type has been superseded by &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; use of that type is recommended
    /// <see href="http://schema.org/DatedMoneySpecification"></see></summary>
    let DatedMoneySpecification = _prefix "DatedMoneySpecification"
    /// <summary>
    /// A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc. It is recommended to use &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; Types to describe the price of an Offer, Invoice, etc.
    /// <see href="http://schema.org/MonetaryAmount"></see></summary>
    let MonetaryAmount = _prefix "MonetaryAmount"
    /// <summary>
    /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Originally, URLs from &lt;a href="http://purl.org/goodrelations/v1"&gt;GoodRelations&lt;/a&gt; were used (for &lt;a class="localLink" href="http://schema.org/Monday"&gt;Monday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Tuesday"&gt;Tuesday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Wednesday"&gt;Wednesday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Thursday"&gt;Thursday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Friday"&gt;Friday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Saturday"&gt;Saturday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Sunday"&gt;Sunday&lt;/a&gt; plus a special entry for &lt;a class="localLink" href="http://schema.org/PublicHolidays"&gt;PublicHolidays&lt;/a&gt;); these have now been integrated directly into schema.org.
    /// <see href="http://schema.org/DayOfWeek"></see></summary>
    let DayOfWeek = _prefix "DayOfWeek"
    /// <summary>
    /// A day spa.
    /// <see href="http://schema.org/DaySpa"></see></summary>
    let DaySpa = _prefix "DaySpa"
    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// <see href="http://schema.org/DeactivateAction"></see></summary>
    let DeactivateAction = _prefix "DeactivateAction"
    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// <see href="http://schema.org/DefenceEstablishment"></see></summary>
    let DefenceEstablishment = _prefix "DefenceEstablishment"
    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// <see href="http://schema.org/DeleteAction"></see></summary>
    let DeleteAction = _prefix "DeleteAction"
    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// <see href="http://schema.org/DeliveryChargeSpecification"></see></summary>
    let DeliveryChargeSpecification = _prefix "DeliveryChargeSpecification"
    /// <summary>
    /// An event involving the delivery of an item.
    /// <see href="http://schema.org/DeliveryEvent"></see></summary>
    let DeliveryEvent = _prefix "DeliveryEvent"
    /// <summary>
    /// A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment chosen by the customer. Delivery methods are characterized by the means of transportation used, and by the organization or group that is the contracting party for the sending organization or person.&lt;br/&gt;&lt;br/&gt;
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
    ///
    /// <see href="http://schema.org/DeliveryMethod"></see></summary>
    let DeliveryMethod = _prefix "DeliveryMethod"
    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// <see href="http://schema.org/Demand"></see></summary>
    let Demand = _prefix "Demand"
    /// <summary>
    /// DemoAlbum.
    /// <see href="http://schema.org/DemoAlbum"></see></summary>
    let DemoAlbum = _prefix "DemoAlbum"
    /// <summary>
    /// A dentist.
    /// <see href="http://schema.org/Dentist"></see></summary>
    let Dentist = _prefix "Dentist"
    /// <summary>
    ///   <see href="http://schema.org/MedicalBusiness"></see>
    /// </summary>
    let MedicalBusiness = _prefix "MedicalBusiness"
    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// <see href="http://schema.org/MedicalOrganization"></see></summary>
    let MedicalOrganization = _prefix "MedicalOrganization"
    /// <summary>
    /// The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.
    /// <see href="http://schema.org/DepartAction"></see></summary>
    let DepartAction = _prefix "DepartAction"
    /// <summary>
    /// A department store.
    /// <see href="http://schema.org/DepartmentStore"></see></summary>
    let DepartmentStore = _prefix "DepartmentStore"
    /// <summary>
    /// A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.
    /// <see href="http://schema.org/DepositAccount"></see></summary>
    let DepositAccount = _prefix "DepositAccount"
    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// <see href="http://schema.org/InvestmentOrDeposit"></see></summary>
    let InvestmentOrDeposit = _prefix "InvestmentOrDeposit"
    /// <summary>
    /// A diet appropriate for people with diabetes.
    /// <see href="http://schema.org/DiabeticDiet"></see></summary>
    let DiabeticDiet = _prefix "DiabeticDiet"
    /// <summary>
    /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.
    /// <see href="http://schema.org/RestrictedDiet"></see></summary>
    let RestrictedDiet = _prefix "RestrictedDiet"
    /// <summary>
    /// DigitalAudioTapeFormat.
    /// <see href="http://schema.org/DigitalAudioTapeFormat"></see></summary>
    let DigitalAudioTapeFormat = _prefix "DigitalAudioTapeFormat"
    /// <summary>
    /// An electronic file or document.
    /// <see href="http://schema.org/DigitalDocument"></see></summary>
    let DigitalDocument = _prefix "DigitalDocument"
    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// <see href="http://schema.org/DigitalDocumentPermission"></see></summary>
    let DigitalDocumentPermission = _prefix "DigitalDocumentPermission"
    /// <summary>
    /// DigitalFormat.
    /// <see href="http://schema.org/DigitalFormat"></see></summary>
    let DigitalFormat = _prefix "DigitalFormat"
    /// <summary>
    /// The act of expressing a difference of opinion with the object. An agent disagrees to/about an object (a proposition, topic or theme) with participants.
    /// <see href="http://schema.org/DisagreeAction"></see></summary>
    let DisagreeAction = _prefix "DisagreeAction"
    /// <summary>
    /// Indicates that the item has been discontinued.
    /// <see href="http://schema.org/Discontinued"></see></summary>
    let Discontinued = _prefix "Discontinued"
    /// <summary>
    /// A list of possible product availability options.
    /// <see href="http://schema.org/ItemAvailability"></see></summary>
    let ItemAvailability = _prefix "ItemAvailability"
    /// <summary>
    /// The act of discovering/finding an object.
    /// <see href="http://schema.org/DiscoverAction"></see></summary>
    let DiscoverAction = _prefix "DiscoverAction"
    /// <summary>
    /// A posting to a discussion forum.
    /// <see href="http://schema.org/DiscussionForumPosting"></see></summary>
    let DiscussionForumPosting = _prefix "DiscussionForumPosting"
    /// <summary>
    /// The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.
    /// <see href="http://schema.org/DislikeAction"></see></summary>
    let DislikeAction = _prefix "DislikeAction"
    /// <summary>
    /// Properties that take Distances as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Length unit of measure&amp;gt;'. E.g., '7 ft'.
    /// <see href="http://schema.org/Distance"></see></summary>
    let Distance = _prefix "Distance"
    /// <summary>
    /// Quantities such as distance, time, mass, weight, etc. Particular instances of say Mass are entities like '3 Kg' or '4 milligrams'.
    /// <see href="http://schema.org/Quantity"></see></summary>
    let Quantity = _prefix "Quantity"
    /// <summary>
    /// A distillery.
    /// <see href="http://schema.org/Distillery"></see></summary>
    let Distillery = _prefix "Distillery"
    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// <see href="http://schema.org/DonateAction"></see></summary>
    let DonateAction = _prefix "DonateAction"
    /// <summary>
    /// The act of downloading an object.
    /// <see href="http://schema.org/DownloadAction"></see></summary>
    let DownloadAction = _prefix "DownloadAction"
    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// <see href="http://schema.org/DrawAction"></see></summary>
    let DrawAction = _prefix "DrawAction"
    /// <summary>
    /// The act of swallowing liquids.
    /// <see href="http://schema.org/DrinkAction"></see></summary>
    let DrinkAction = _prefix "DrinkAction"
    /// <summary>
    /// A dry-cleaning business.
    /// <see href="http://schema.org/DryCleaningOrLaundry"></see></summary>
    let DryCleaningOrLaundry = _prefix "DryCleaningOrLaundry"
    /// <summary>
    /// Quantity: Duration (use &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;).
    /// <see href="http://schema.org/Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    /// Book format: Ebook.
    /// <see href="http://schema.org/EBook"></see></summary>
    let EBook = _prefix "EBook"
    /// <summary>
    /// EPRelease.
    /// <see href="http://schema.org/EPRelease"></see></summary>
    let EPRelease = _prefix "EPRelease"
    /// <summary>
    /// The act of swallowing solid objects.
    /// <see href="http://schema.org/EatAction"></see></summary>
    let EatAction = _prefix "EatAction"
    /// <summary>
    /// Event type: Education event.
    /// <see href="http://schema.org/EducationEvent"></see></summary>
    let EducationEvent = _prefix "EducationEvent"
    /// <summary>
    /// An EducationalAudience.
    /// <see href="http://schema.org/EducationalAudience"></see></summary>
    let EducationalAudience = _prefix "EducationalAudience"
    /// <summary>
    /// An electrician.
    /// <see href="http://schema.org/Electrician"></see></summary>
    let Electrician = _prefix "Electrician"
    /// <summary>
    /// A construction business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// A HomeAndConstructionBusiness is a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; that provides services around homes and buildings.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// <see href="http://schema.org/HomeAndConstructionBusiness"></see></summary>
    let HomeAndConstructionBusiness = _prefix "HomeAndConstructionBusiness"
    /// <summary>
    /// An electronics store.
    /// <see href="http://schema.org/ElectronicsStore"></see></summary>
    let ElectronicsStore = _prefix "ElectronicsStore"
    /// <summary>
    /// An elementary school.
    /// <see href="http://schema.org/ElementarySchool"></see></summary>
    let ElementarySchool = _prefix "ElementarySchool"
    /// <summary>
    /// An email message.
    /// <see href="http://schema.org/EmailMessage"></see></summary>
    let EmailMessage = _prefix "EmailMessage"
    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// <see href="http://schema.org/Message"></see></summary>
    let Message = _prefix "Message"
    /// <summary>
    /// An embassy.
    /// <see href="http://schema.org/Embassy"></see></summary>
    let Embassy = _prefix "Embassy"
    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// <see href="http://schema.org/EmergencyService"></see></summary>
    let EmergencyService = _prefix "EmergencyService"
    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// <see href="http://schema.org/EmployeeRole"></see></summary>
    let EmployeeRole = _prefix "EmployeeRole"
    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// <see href="http://schema.org/OrganizationRole"></see></summary>
    let OrganizationRole = _prefix "OrganizationRole"
    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// <see href="http://schema.org/EmployerAggregateRating"></see></summary>
    let EmployerAggregateRating = _prefix "EmployerAggregateRating"
    /// <summary>
    /// An employment agency.
    /// <see href="http://schema.org/EmploymentAgency"></see></summary>
    let EmploymentAgency = _prefix "EmploymentAgency"
    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// <see href="http://schema.org/EndorseAction"></see></summary>
    let EndorseAction = _prefix "EndorseAction"
    /// <summary>
    /// An EndorsementRating is a rating that expresses some level of endorsement, for example inclusion in a "critic's pick" blog, a
    /// "Like" or "+1" on a social network. It can be considered the &lt;a class="localLink" href="http://schema.org/result"&gt;result&lt;/a&gt; of an &lt;a class="localLink" href="http://schema.org/EndorseAction"&gt;EndorseAction&lt;/a&gt; in which the &lt;a class="localLink" href="http://schema.org/object"&gt;object&lt;/a&gt; of the action is rated positively by
    /// some &lt;a class="localLink" href="http://schema.org/agent"&gt;agent&lt;/a&gt;. As is common elsewhere in schema.org, it is sometimes more useful to describe the results of such an action without explicitly describing the &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// An &lt;a class="localLink" href="http://schema.org/EndorsementRating"&gt;EndorsementRating&lt;/a&gt; may be part of a numeric scale or organized system, but this is not required: having an explicit type for indicating a positive,
    /// endorsement rating is particularly useful in the absence of numeric scales as it helps consumers understand that the rating is broadly positive.
    /// <see href="http://schema.org/EndorsementRating"></see></summary>
    let EndorsementRating = _prefix "EndorsementRating"
    /// <summary>
    /// Properties that take Energy as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Energy unit of measure&amp;gt;'.
    /// <see href="http://schema.org/Energy"></see></summary>
    let Energy = _prefix "Energy"
    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// <see href="http://schema.org/EngineSpecification"></see></summary>
    let EngineSpecification = _prefix "EngineSpecification"
    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// <see href="http://schema.org/EntryPoint"></see></summary>
    let EntryPoint = _prefix "EntryPoint"
    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// <see href="http://schema.org/Episode"></see></summary>
    let Episode = _prefix "Episode"
    /// <summary>
    /// The event has been cancelled. If the event has multiple startDate values, all are assumed to be cancelled. Either startDate or previousStartDate may be used to specify the event's cancelled date(s).
    /// <see href="http://schema.org/EventCancelled"></see></summary>
    let EventCancelled = _prefix "EventCancelled"
    /// <summary>
    /// EventStatusType is an enumeration type whose instances represent several states that an Event may be in.
    /// <see href="http://schema.org/EventStatusType"></see></summary>
    let EventStatusType = _prefix "EventStatusType"
    /// <summary>
    /// Indicates that the event was changed to allow online participation. See &lt;a class="localLink" href="http://schema.org/eventAttendanceMode"&gt;eventAttendanceMode&lt;/a&gt; for specifics of whether it is now fully or partially online.
    /// <see href="http://schema.org/EventMovedOnline"></see></summary>
    let EventMovedOnline = _prefix "EventMovedOnline"
    /// <summary>
    /// The event has been postponed and no new date has been set. The event's previousStartDate should be set.
    /// <see href="http://schema.org/EventPostponed"></see></summary>
    let EventPostponed = _prefix "EventPostponed"
    /// <summary>
    /// The event has been rescheduled. The event's previousStartDate should be set to the old date and the startDate should be set to the event's new date. (If the event has been rescheduled multiple times, the previousStartDate property may be repeated).
    /// <see href="http://schema.org/EventRescheduled"></see></summary>
    let EventRescheduled = _prefix "EventRescheduled"
    /// <summary>
    /// A reservation for an event like a concert, sporting event, or lecture.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/EventReservation"></see></summary>
    let EventReservation = _prefix "EventReservation"
    /// <summary>
    /// The event is taking place or has taken place on the startDate as scheduled. Use of this value is optional, as it is assumed by default.
    /// <see href="http://schema.org/EventScheduled"></see></summary>
    let EventScheduled = _prefix "EventScheduled"
    /// <summary>
    /// An event venue.
    /// <see href="http://schema.org/EventVenue"></see></summary>
    let EventVenue = _prefix "EventVenue"
    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// <see href="http://schema.org/ExerciseAction"></see></summary>
    let ExerciseAction = _prefix "ExerciseAction"
    /// <summary>
    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ListenAction"&gt;ListenAction&lt;/a&gt;: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/WatchAction"&gt;WatchAction&lt;/a&gt;: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/PlayAction"></see></summary>
    let PlayAction = _prefix "PlayAction"
    /// <summary>
    /// A gym.
    /// <see href="http://schema.org/ExerciseGym"></see></summary>
    let ExerciseGym = _prefix "ExerciseGym"
    /// <summary>
    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    /// <see href="http://schema.org/ExhibitionEvent"></see></summary>
    let ExhibitionEvent = _prefix "ExhibitionEvent"
    /// <summary>
    /// A &lt;a class="localLink" href="http://schema.org/FAQPage"&gt;FAQPage&lt;/a&gt; is a &lt;a class="localLink" href="http://schema.org/WebPage"&gt;WebPage&lt;/a&gt; presenting one or more "&lt;a href="https://en.wikipedia.org/wiki/FAQ"&gt;Frequently asked questions&lt;/a&gt;" (see also &lt;a class="localLink" href="http://schema.org/QAPage"&gt;QAPage&lt;/a&gt;).
    /// <see href="http://schema.org/FAQPage"></see></summary>
    let FAQPage = _prefix "FAQPage"
    /// <summary>
    /// A radio channel that uses FM.
    /// <see href="http://schema.org/FMRadioChannel"></see></summary>
    let FMRadioChannel = _prefix "FMRadioChannel"
    /// <summary>
    /// An action that failed to complete. The action's error property and the HTTP return code contain more information about the failure.
    /// <see href="http://schema.org/FailedActionStatus"></see></summary>
    let FailedActionStatus = _prefix "FailedActionStatus"
    /// <summary>
    /// The boolean value false.
    /// <see href="http://schema.org/False"></see></summary>
    let False = _prefix "False"
    /// <summary>
    /// A fast-food restaurant.
    /// <see href="http://schema.org/FastFoodRestaurant"></see></summary>
    let FastFoodRestaurant = _prefix "FastFoodRestaurant"
    /// <summary>
    /// The female gender.
    /// <see href="http://schema.org/Female"></see></summary>
    let Female = _prefix "Female"
    /// <summary>
    /// An enumeration of genders.
    /// <see href="http://schema.org/GenderType"></see></summary>
    let GenderType = _prefix "GenderType"
    /// <summary>
    /// Event type: Festival.
    /// <see href="http://schema.org/Festival"></see></summary>
    let Festival = _prefix "Festival"
    /// <summary>
    /// The act of capturing sound and moving images on film, video, or digitally.
    /// <see href="http://schema.org/FilmAction"></see></summary>
    let FilmAction = _prefix "FilmAction"
    /// <summary>
    /// A fire station. With firemen.
    /// <see href="http://schema.org/FireStation"></see></summary>
    let FireStation = _prefix "FireStation"
    /// <summary>
    /// An airline flight.
    /// <see href="http://schema.org/Flight"></see></summary>
    let Flight = _prefix "Flight"
    /// <summary>
    /// A reservation for air travel.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/FlightReservation"></see></summary>
    let FlightReservation = _prefix "FlightReservation"
    /// <summary>
    /// Data type: Floating number.
    /// <see href="http://schema.org/Float"></see></summary>
    let Float = _prefix "Float"
    /// <summary>
    /// Data type: Number.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/Number"></see></summary>
    let Number = _prefix "Number"
    /// <summary>
    /// A florist.
    /// <see href="http://schema.org/Florist"></see></summary>
    let Florist = _prefix "Florist"
    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from.&lt;br/&gt;&lt;br/&gt;
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
    ///
    /// <see href="http://schema.org/FollowAction"></see></summary>
    let FollowAction = _prefix "FollowAction"
    /// <summary>
    /// A reservation to dine at a food-related business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// <see href="http://schema.org/FoodEstablishmentReservation"></see></summary>
    let FoodEstablishmentReservation = _prefix "FoodEstablishmentReservation"
    /// <summary>
    /// Event type: Food event.
    /// <see href="http://schema.org/FoodEvent"></see></summary>
    let FoodEvent = _prefix "FoodEvent"
    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// <see href="http://schema.org/FoodService"></see></summary>
    let FoodService = _prefix "FoodService"
    /// <summary>
    /// Four-wheel drive is a transmission layout where the engine primarily drives two wheels with a part-time four-wheel drive capability.
    /// <see href="http://schema.org/FourWheelDriveConfiguration"></see></summary>
    let FourWheelDriveConfiguration = _prefix "FourWheelDriveConfiguration"
    /// <summary>
    /// The day of the week between Thursday and Saturday.
    /// <see href="http://schema.org/Friday"></see></summary>
    let Friday = _prefix "Friday"
    /// <summary>
    /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.
    /// <see href="http://schema.org/sameAs"></see></summary>
    let sameAs = _prefix "sameAs"
    /// <summary>
    /// Front-wheel drive is a transmission layout where the engine drives the front wheels.
    /// <see href="http://schema.org/FrontWheelDriveConfiguration"></see></summary>
    let FrontWheelDriveConfiguration = _prefix "FrontWheelDriveConfiguration"
    /// <summary>
    /// A furniture store.
    /// <see href="http://schema.org/FurnitureStore"></see></summary>
    let FurnitureStore = _prefix "FurnitureStore"
    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// <see href="http://schema.org/Game"></see></summary>
    let Game = _prefix "Game"
    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// <see href="http://schema.org/GameServer"></see></summary>
    let GameServer = _prefix "GameServer"
    /// <summary>
    /// Status of a game server.
    /// <see href="http://schema.org/GameServerStatus"></see></summary>
    let GameServerStatus = _prefix "GameServerStatus"
    /// <summary>
    /// A garden store.
    /// <see href="http://schema.org/GardenStore"></see></summary>
    let GardenStore = _prefix "GardenStore"
    /// <summary>
    /// A gas station.
    /// <see href="http://schema.org/GasStation"></see></summary>
    let GasStation = _prefix "GasStation"
    /// <summary>
    /// Residence type: Gated community.
    /// <see href="http://schema.org/GatedResidenceCommunity"></see></summary>
    let GatedResidenceCommunity = _prefix "GatedResidenceCommunity"
    /// <summary>
    /// A general contractor.
    /// <see href="http://schema.org/GeneralContractor"></see></summary>
    let GeneralContractor = _prefix "GeneralContractor"
    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    /// <see href="http://schema.org/GeoCircle"></see></summary>
    let GeoCircle = _prefix "GeoCircle"
    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// <see href="http://schema.org/GeoShape"></see></summary>
    let GeoShape = _prefix "GeoShape"
    /// <summary>
    /// The geographic coordinates of a place or event.
    /// <see href="http://schema.org/GeoCoordinates"></see></summary>
    let GeoCoordinates = _prefix "GeoCoordinates"
    /// <summary>
    /// The act of transferring ownership of an object to a destination. Reciprocal of TakeAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Reciprocal of GiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: Unlike SendAction, GiveAction implies that ownership is being transferred (e.g. I may send my laptop to you, but that doesn't mean I'm giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/GiveAction"></see></summary>
    let GiveAction = _prefix "GiveAction"
    /// <summary>
    /// A diet exclusive of gluten.
    /// <see href="http://schema.org/GlutenFreeDiet"></see></summary>
    let GlutenFreeDiet = _prefix "GlutenFreeDiet"
    /// <summary>
    /// A golf course.
    /// <see href="http://schema.org/GolfCourse"></see></summary>
    let GolfCourse = _prefix "GolfCourse"
    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// <see href="http://schema.org/GovernmentOffice"></see></summary>
    let GovernmentOffice = _prefix "GovernmentOffice"
    /// <summary>
    /// A governmental organization or agency.
    /// <see href="http://schema.org/GovernmentOrganization"></see></summary>
    let GovernmentOrganization = _prefix "GovernmentOrganization"
    /// <summary>
    /// A permit issued by a government agency.
    /// <see href="http://schema.org/GovernmentPermit"></see></summary>
    let GovernmentPermit = _prefix "GovernmentPermit"
    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// <see href="http://schema.org/Permit"></see></summary>
    let Permit = _prefix "Permit"
    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// <see href="http://schema.org/GovernmentService"></see></summary>
    let GovernmentService = _prefix "GovernmentService"
    /// <summary>
    /// A grocery store.
    /// <see href="http://schema.org/GroceryStore"></see></summary>
    let GroceryStore = _prefix "GroceryStore"
    /// <summary>
    /// The airline boards by groups based on check-in time, priority, etc.
    /// <see href="http://schema.org/GroupBoardingPolicy"></see></summary>
    let GroupBoardingPolicy = _prefix "GroupBoardingPolicy"
    /// <summary>
    /// A business that provide Heating, Ventilation and Air Conditioning services.
    /// <see href="http://schema.org/HVACBusiness"></see></summary>
    let HVACBusiness = _prefix "HVACBusiness"
    /// <summary>
    /// A hair salon.
    /// <see href="http://schema.org/HairSalon"></see></summary>
    let HairSalon = _prefix "HairSalon"
    /// <summary>
    /// A diet conforming to Islamic dietary practices.
    /// <see href="http://schema.org/HalalDiet"></see></summary>
    let HalalDiet = _prefix "HalalDiet"
    /// <summary>
    /// Book format: Hardcover.
    /// <see href="http://schema.org/Hardcover"></see></summary>
    let Hardcover = _prefix "Hardcover"
    /// <summary>
    /// A hardware store.
    /// <see href="http://schema.org/HardwareStore"></see></summary>
    let HardwareStore = _prefix "HardwareStore"
    /// <summary>
    /// A health club.
    /// <see href="http://schema.org/HealthClub"></see></summary>
    let HealthClub = _prefix "HealthClub"
    /// <summary>
    /// Uses devices to support users with hearing impairments.
    /// <see href="http://schema.org/HearingImpairedSupported"></see></summary>
    let HearingImpairedSupported = _prefix "HearingImpairedSupported"
    /// <summary>
    /// A high school.
    /// <see href="http://schema.org/HighSchool"></see></summary>
    let HighSchool = _prefix "HighSchool"
    /// <summary>
    /// A diet conforming to Hindu dietary practices, in particular, beef-free.
    /// <see href="http://schema.org/HinduDiet"></see></summary>
    let HinduDiet = _prefix "HinduDiet"
    /// <summary>
    /// A Hindu temple.
    /// <see href="http://schema.org/HinduTemple"></see></summary>
    let HinduTemple = _prefix "HinduTemple"
    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// <see href="http://schema.org/HobbyShop"></see></summary>
    let HobbyShop = _prefix "HobbyShop"
    /// <summary>
    /// A home goods store.
    /// <see href="http://schema.org/HomeGoodsStore"></see></summary>
    let HomeGoodsStore = _prefix "HomeGoodsStore"
    /// <summary>
    /// A hospital.
    /// <see href="http://schema.org/Hospital"></see></summary>
    let Hospital = _prefix "Hospital"
    /// <summary>
    /// A hostel - cheap accommodation, often in shared dormitories.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Hostel"></see></summary>
    let Hostel = _prefix "Hostel"
    /// <summary>
    /// A hotel is an establishment that provides lodging paid on a short-term basis (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Hotel"></see></summary>
    let Hotel = _prefix "Hotel"
    /// <summary>
    /// A hotel room is a single room in a hotel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/HotelRoom"></see></summary>
    let HotelRoom = _prefix "HotelRoom"
    /// <summary>
    /// A room is a distinguishable space within a structure, usually separated from other spaces by interior walls. (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Room"&gt;http://en.wikipedia.org/wiki/Room&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Room"></see></summary>
    let Room = _prefix "Room"
    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// <see href="http://schema.org/House"></see></summary>
    let House = _prefix "House"
    /// <summary>
    /// A house painting service.
    /// <see href="http://schema.org/HousePainter"></see></summary>
    let HousePainter = _prefix "HousePainter"
    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// <see href="http://schema.org/HowTo"></see></summary>
    let HowTo = _prefix "HowTo"
    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// <see href="http://schema.org/HowToDirection"></see></summary>
    let HowToDirection = _prefix "HowToDirection"
    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// <see href="http://schema.org/ListItem"></see></summary>
    let ListItem = _prefix "ListItem"
    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// <see href="http://schema.org/HowToItem"></see></summary>
    let HowToItem = _prefix "HowToItem"
    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// <see href="http://schema.org/HowToSection"></see></summary>
    let HowToSection = _prefix "HowToSection"
    /// <summary>
    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    /// <see href="http://schema.org/HowToStep"></see></summary>
    let HowToStep = _prefix "HowToStep"
    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// <see href="http://schema.org/HowToSupply"></see></summary>
    let HowToSupply = _prefix "HowToSupply"
    /// <summary>
    /// An explanation in the instructions for how to achieve a result. It provides supplementary information about a technique, supply, author's preference, etc. It can explain what could be done, or what should not be done, but doesn't specify what should be done (see HowToDirection).
    /// <see href="http://schema.org/HowToTip"></see></summary>
    let HowToTip = _prefix "HowToTip"
    /// <summary>
    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    /// <see href="http://schema.org/HowToTool"></see></summary>
    let HowToTool = _prefix "HowToTool"
    /// <summary>
    /// An ice cream shop.
    /// <see href="http://schema.org/IceCreamShop"></see></summary>
    let IceCreamShop = _prefix "IceCreamShop"
    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// <see href="http://schema.org/IgnoreAction"></see></summary>
    let IgnoreAction = _prefix "IgnoreAction"
    /// <summary>
    /// Web page type: Image gallery page.
    /// <see href="http://schema.org/ImageGallery"></see></summary>
    let ImageGallery = _prefix "ImageGallery"
    /// <summary>
    /// Web page type: Media gallery page. A mixed-media page that can contains media such as images, videos, and other multimedia.
    /// <see href="http://schema.org/MediaGallery"></see></summary>
    let MediaGallery = _prefix "MediaGallery"
    /// <summary>
    /// Indicates that the item is in stock.
    /// <see href="http://schema.org/InStock"></see></summary>
    let InStock = _prefix "InStock"
    /// <summary>
    /// Indicates that the item is available only at physical locations.
    /// <see href="http://schema.org/InStoreOnly"></see></summary>
    let InStoreOnly = _prefix "InStoreOnly"
    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// <see href="http://schema.org/IndividualProduct"></see></summary>
    let IndividualProduct = _prefix "IndividualProduct"
    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// <see href="http://schema.org/Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    /// The act of installing an application.
    /// <see href="http://schema.org/InstallAction"></see></summary>
    let InstallAction = _prefix "InstallAction"
    /// <summary>
    /// An Insurance agency.
    /// <see href="http://schema.org/InsuranceAgency"></see></summary>
    let InsuranceAgency = _prefix "InsuranceAgency"
    /// <summary>
    /// Data type: Integer.
    /// <see href="http://schema.org/Integer"></see></summary>
    let Integer = _prefix "Integer"
    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// <see href="http://schema.org/InteractionCounter"></see></summary>
    let InteractionCounter = _prefix "InteractionCounter"
    /// <summary>
    /// An internet cafe.
    /// <see href="http://schema.org/InternetCafe"></see></summary>
    let InternetCafe = _prefix "InternetCafe"
    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// <see href="http://schema.org/InviteAction"></see></summary>
    let InviteAction = _prefix "InviteAction"
    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// <see href="http://schema.org/Invoice"></see></summary>
    let Invoice = _prefix "Invoice"
    /// <summary>
    /// An ItemList ordered with lower values listed first.
    /// <see href="http://schema.org/ItemListOrderAscending"></see></summary>
    let ItemListOrderAscending = _prefix "ItemListOrderAscending"
    /// <summary>
    /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    /// <see href="http://schema.org/ItemListOrderType"></see></summary>
    let ItemListOrderType = _prefix "ItemListOrderType"
    /// <summary>
    /// An ItemList ordered with higher values listed first.
    /// <see href="http://schema.org/ItemListOrderDescending"></see></summary>
    let ItemListOrderDescending = _prefix "ItemListOrderDescending"
    /// <summary>
    /// An ItemList ordered with no explicit order.
    /// <see href="http://schema.org/ItemListUnordered"></see></summary>
    let ItemListUnordered = _prefix "ItemListUnordered"
    /// <summary>
    /// A page devoted to a single item, such as a particular product or hotel.
    /// <see href="http://schema.org/ItemPage"></see></summary>
    let ItemPage = _prefix "ItemPage"
    /// <summary>
    /// A jewelry store.
    /// <see href="http://schema.org/JewelryStore"></see></summary>
    let JewelryStore = _prefix "JewelryStore"
    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// <see href="http://schema.org/JobPosting"></see></summary>
    let JobPosting = _prefix "JobPosting"
    /// <summary>
    /// An agent joins an event/group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, JoinAction refers to joining a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, JoinAction does not imply that you'll be receiving updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, JoinAction does not imply that you'll be polling for updates.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/JoinAction"></see></summary>
    let JoinAction = _prefix "JoinAction"
    /// <summary>
    /// A diet conforming to Jewish dietary practices.
    /// <see href="http://schema.org/KosherDiet"></see></summary>
    let KosherDiet = _prefix "KosherDiet"
    /// <summary>
    /// A lake (for example, Lake Pontrachain).
    /// <see href="http://schema.org/LakeBodyOfWater"></see></summary>
    let LakeBodyOfWater = _prefix "LakeBodyOfWater"
    /// <summary>
    /// An historical landmark or building.
    /// <see href="http://schema.org/LandmarksOrHistoricalBuildings"></see></summary>
    let LandmarksOrHistoricalBuildings = _prefix "LandmarksOrHistoricalBuildings"
    /// <summary>
    /// Natural languages such as Spanish, Tamil, Hindi, English, etc. Formal language code tags expressed in &lt;a href="https://en.wikipedia.org/wiki/IETF_language_tag"&gt;BCP 47&lt;/a&gt; can be used via the &lt;a class="localLink" href="http://schema.org/alternateName"&gt;alternateName&lt;/a&gt; property. The Language type previously also covered programming languages such as Scheme and Lisp, which are now best represented using &lt;a class="localLink" href="http://schema.org/ComputerLanguage"&gt;ComputerLanguage&lt;/a&gt;.
    /// <see href="http://schema.org/Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// LaserDiscFormat.
    /// <see href="http://schema.org/LaserDiscFormat"></see></summary>
    let LaserDiscFormat = _prefix "LaserDiscFormat"
    /// <summary>
    /// An agent leaves an event / group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: The antonym of LeaveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/UnRegisterAction"&gt;UnRegisterAction&lt;/a&gt;: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/LeaveAction"></see></summary>
    let LeaveAction = _prefix "LeaveAction"
    /// <summary>
    /// The steering position is on the left side of the vehicle (viewed from the main direction of driving).
    /// <see href="http://schema.org/LeftHandDriving"></see></summary>
    let LeftHandDriving = _prefix "LeftHandDriving"
    /// <summary>
    /// A value indicating a steering position.
    /// <see href="http://schema.org/SteeringPositionValue"></see></summary>
    let SteeringPositionValue = _prefix "SteeringPositionValue"
    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// <see href="http://schema.org/LegislativeBuilding"></see></summary>
    let LegislativeBuilding = _prefix "LegislativeBuilding"
    /// <summary>
    /// The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/BorrowAction"&gt;BorrowAction&lt;/a&gt;: Reciprocal of LendAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/LendAction"></see></summary>
    let LendAction = _prefix "LendAction"
    /// <summary>
    /// A library.
    /// <see href="http://schema.org/Library"></see></summary>
    let Library = _prefix "Library"
    /// <summary>
    /// The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.
    /// <see href="http://schema.org/LikeAction"></see></summary>
    let LikeAction = _prefix "LikeAction"
    /// <summary>
    /// Indicates that the item has limited availability.
    /// <see href="http://schema.org/LimitedAvailability"></see></summary>
    let LimitedAvailability = _prefix "LimitedAvailability"
    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// <see href="http://schema.org/LiquorStore"></see></summary>
    let LiquorStore = _prefix "LiquorStore"
    /// <summary>
    /// The act of consuming audio content.
    /// <see href="http://schema.org/ListenAction"></see></summary>
    let ListenAction = _prefix "ListenAction"
    /// <summary>
    /// Event type: Literary event.
    /// <see href="http://schema.org/LiteraryEvent"></see></summary>
    let LiteraryEvent = _prefix "LiteraryEvent"
    /// <summary>
    /// LiveAlbum.
    /// <see href="http://schema.org/LiveAlbum"></see></summary>
    let LiveAlbum = _prefix "LiveAlbum"
    /// <summary>
    /// A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// <see href="http://schema.org/LiveBlogPosting"></see></summary>
    let LiveBlogPosting = _prefix "LiveBlogPosting"
    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// <see href="http://schema.org/LocationFeatureSpecification"></see></summary>
    let LocationFeatureSpecification = _prefix "LocationFeatureSpecification"
    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    /// <see href="http://schema.org/PropertyValue"></see></summary>
    let PropertyValue = _prefix "PropertyValue"
    /// <summary>
    /// A DeliveryMethod in which an item is made available via locker.
    /// <see href="http://schema.org/LockerDelivery"></see></summary>
    let LockerDelivery = _prefix "LockerDelivery"
    /// <summary>
    /// A locksmith.
    /// <see href="http://schema.org/Locksmith"></see></summary>
    let Locksmith = _prefix "Locksmith"
    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// <see href="http://schema.org/LodgingReservation"></see></summary>
    let LodgingReservation = _prefix "LodgingReservation"
    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// <see href="http://schema.org/LoseAction"></see></summary>
    let LoseAction = _prefix "LoseAction"
    /// <summary>
    /// A diet focused on reduced calorie intake.
    /// <see href="http://schema.org/LowCalorieDiet"></see></summary>
    let LowCalorieDiet = _prefix "LowCalorieDiet"
    /// <summary>
    /// A diet focused on reduced fat and cholesterol intake.
    /// <see href="http://schema.org/LowFatDiet"></see></summary>
    let LowFatDiet = _prefix "LowFatDiet"
    /// <summary>
    /// A diet appropriate for people with lactose intolerance.
    /// <see href="http://schema.org/LowLactoseDiet"></see></summary>
    let LowLactoseDiet = _prefix "LowLactoseDiet"
    /// <summary>
    /// A diet focused on reduced sodium intake.
    /// <see href="http://schema.org/LowSaltDiet"></see></summary>
    let LowSaltDiet = _prefix "LowSaltDiet"
    /// <summary>
    /// The male gender.
    /// <see href="http://schema.org/Male"></see></summary>
    let Male = _prefix "Male"
    /// <summary>
    /// A map.
    /// <see href="http://schema.org/Map"></see></summary>
    let Map = _prefix "Map"
    /// <summary>
    /// An enumeration of several kinds of Map.
    /// <see href="http://schema.org/MapCategoryType"></see></summary>
    let MapCategoryType = _prefix "MapCategoryType"
    /// <summary>
    /// The act of marrying a person.
    /// <see href="http://schema.org/MarryAction"></see></summary>
    let MarryAction = _prefix "MarryAction"
    /// <summary>
    /// Properties that take Mass as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Mass unit of measure&amp;gt;'. E.g., '7 kg'.
    /// <see href="http://schema.org/Mass"></see></summary>
    let Mass = _prefix "Mass"
    /// <summary>
    /// A subscription which allows a user to access media including audio, video, books, etc.
    /// <see href="http://schema.org/MediaSubscription"></see></summary>
    let MediaSubscription = _prefix "MediaSubscription"
    /// <summary>
    /// A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Conference_hall"&gt;http://en.wikipedia.org/wiki/Conference_hall&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/MeetingRoom"></see></summary>
    let MeetingRoom = _prefix "MeetingRoom"
    /// <summary>
    /// A men's clothing store.
    /// <see href="http://schema.org/MensClothingStore"></see></summary>
    let MensClothingStore = _prefix "MensClothingStore"
    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// <see href="http://schema.org/Menu"></see></summary>
    let Menu = _prefix "Menu"
    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// <see href="http://schema.org/MenuItem"></see></summary>
    let MenuItem = _prefix "MenuItem"
    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    /// <see href="http://schema.org/MenuSection"></see></summary>
    let MenuSection = _prefix "MenuSection"
    /// <summary>
    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    /// <see href="http://schema.org/MiddleSchool"></see></summary>
    let MiddleSchool = _prefix "MiddleSchool"
    /// <summary>
    /// MixtapeAlbum.
    /// <see href="http://schema.org/MixtapeAlbum"></see></summary>
    let MixtapeAlbum = _prefix "MixtapeAlbum"
    /// <summary>
    /// A software application designed specifically to work well on a mobile device such as a telephone.
    /// <see href="http://schema.org/MobileApplication"></see></summary>
    let MobileApplication = _prefix "MobileApplication"
    /// <summary>
    /// A software application.
    /// <see href="http://schema.org/SoftwareApplication"></see></summary>
    let SoftwareApplication = _prefix "SoftwareApplication"
    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// <see href="http://schema.org/MobilePhoneStore"></see></summary>
    let MobilePhoneStore = _prefix "MobilePhoneStore"
    /// <summary>
    /// The day of the week between Sunday and Tuesday.
    /// <see href="http://schema.org/Monday"></see></summary>
    let Monday = _prefix "Monday"
    /// <summary>
    /// A statistical distribution of monetary amounts.
    /// <see href="http://schema.org/MonetaryAmountDistribution"></see></summary>
    let MonetaryAmountDistribution = _prefix "MonetaryAmountDistribution"
    /// <summary>
    /// A statistical distribution of values.
    /// <see href="http://schema.org/QuantitativeValueDistribution"></see></summary>
    let QuantitativeValueDistribution = _prefix "QuantitativeValueDistribution"
    /// <summary>
    /// A mosque.
    /// <see href="http://schema.org/Mosque"></see></summary>
    let Mosque = _prefix "Mosque"
    /// <summary>
    /// A motel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Motel"></see></summary>
    let Motel = _prefix "Motel"
    /// <summary>
    /// A motorcycle dealer.
    /// <see href="http://schema.org/MotorcycleDealer"></see></summary>
    let MotorcycleDealer = _prefix "MotorcycleDealer"
    /// <summary>
    /// A motorcycle repair shop.
    /// <see href="http://schema.org/MotorcycleRepair"></see></summary>
    let MotorcycleRepair = _prefix "MotorcycleRepair"
    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// <see href="http://schema.org/Mountain"></see></summary>
    let Mountain = _prefix "Mountain"
    /// <summary>
    /// A movie.
    /// <see href="http://schema.org/Movie"></see></summary>
    let Movie = _prefix "Movie"
    /// <summary>
    /// A short segment/part of a movie.
    /// <see href="http://schema.org/MovieClip"></see></summary>
    let MovieClip = _prefix "MovieClip"
    /// <summary>
    /// A movie rental store.
    /// <see href="http://schema.org/MovieRentalStore"></see></summary>
    let MovieRentalStore = _prefix "MovieRentalStore"
    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// <see href="http://schema.org/MovieSeries"></see></summary>
    let MovieSeries = _prefix "MovieSeries"
    /// <summary>
    /// A movie theater.
    /// <see href="http://schema.org/MovieTheater"></see></summary>
    let MovieTheater = _prefix "MovieTheater"
    /// <summary>
    /// A moving company.
    /// <see href="http://schema.org/MovingCompany"></see></summary>
    let MovingCompany = _prefix "MovingCompany"
    /// <summary>
    /// Play mode: MultiPlayer. Requiring or allowing multiple human players to play simultaneously.
    /// <see href="http://schema.org/MultiPlayer"></see></summary>
    let MultiPlayer = _prefix "MultiPlayer"
    /// <summary>
    /// A museum.
    /// <see href="http://schema.org/Museum"></see></summary>
    let Museum = _prefix "Museum"
    /// <summary>
    /// A collection of music tracks.
    /// <see href="http://schema.org/MusicAlbum"></see></summary>
    let MusicAlbum = _prefix "MusicAlbum"
    /// <summary>
    /// A collection of music tracks in playlist form.
    /// <see href="http://schema.org/MusicPlaylist"></see></summary>
    let MusicPlaylist = _prefix "MusicPlaylist"
    /// <summary>
    /// A musical composition.
    /// <see href="http://schema.org/MusicComposition"></see></summary>
    let MusicComposition = _prefix "MusicComposition"
    /// <summary>
    /// Event type: Music event.
    /// <see href="http://schema.org/MusicEvent"></see></summary>
    let MusicEvent = _prefix "MusicEvent"
    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// <see href="http://schema.org/MusicGroup"></see></summary>
    let MusicGroup = _prefix "MusicGroup"
    /// <summary>
    /// A music recording (track), usually a single song.
    /// <see href="http://schema.org/MusicRecording"></see></summary>
    let MusicRecording = _prefix "MusicRecording"
    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// <see href="http://schema.org/MusicRelease"></see></summary>
    let MusicRelease = _prefix "MusicRelease"
    /// <summary>
    /// A music store.
    /// <see href="http://schema.org/MusicStore"></see></summary>
    let MusicStore = _prefix "MusicStore"
    /// <summary>
    /// A music venue.
    /// <see href="http://schema.org/MusicVenue"></see></summary>
    let MusicVenue = _prefix "MusicVenue"
    /// <summary>
    /// A music video file.
    /// <see href="http://schema.org/MusicVideoObject"></see></summary>
    let MusicVideoObject = _prefix "MusicVideoObject"
    /// <summary>
    /// Organization: Non-governmental Organization.
    /// <see href="http://schema.org/NGO"></see></summary>
    let NGO = _prefix "NGO"
    /// <summary>
    /// A nail salon.
    /// <see href="http://schema.org/NailSalon"></see></summary>
    let NailSalon = _prefix "NailSalon"
    /// <summary>
    /// Indicates that the item is new.
    /// <see href="http://schema.org/NewCondition"></see></summary>
    let NewCondition = _prefix "NewCondition"
    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.&lt;br/&gt;&lt;br/&gt;
    ///
    /// A more detailed overview of &lt;a href="/docs/news.html"&gt;schema.org News markup&lt;/a&gt; is also available.
    /// <see href="http://schema.org/NewsArticle"></see></summary>
    let NewsArticle = _prefix "NewsArticle"
    /// <summary>
    /// A nightclub or discotheque.
    /// <see href="http://schema.org/NightClub"></see></summary>
    let NightClub = _prefix "NightClub"
    /// <summary>
    /// A notary.
    /// <see href="http://schema.org/Notary"></see></summary>
    let Notary = _prefix "Notary"
    /// <summary>
    /// A file containing a note, primarily for the author.
    /// <see href="http://schema.org/NoteDigitalDocument"></see></summary>
    let NoteDigitalDocument = _prefix "NoteDigitalDocument"
    /// <summary>
    /// Nutritional information about the recipe.
    /// <see href="http://schema.org/NutritionInformation"></see></summary>
    let NutritionInformation = _prefix "NutritionInformation"
    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// <see href="http://schema.org/Occupation"></see></summary>
    let Occupation = _prefix "Occupation"
    /// <summary>
    /// An ocean (for example, the Pacific).
    /// <see href="http://schema.org/OceanBodyOfWater"></see></summary>
    let OceanBodyOfWater = _prefix "OceanBodyOfWater"
    /// <summary>
    /// An OfferCatalog is an ItemList that contains related Offers and/or further OfferCatalogs that are offeredBy the same provider.
    /// <see href="http://schema.org/OfferCatalog"></see></summary>
    let OfferCatalog = _prefix "OfferCatalog"
    /// <summary>
    /// An office equipment store.
    /// <see href="http://schema.org/OfficeEquipmentStore"></see></summary>
    let OfficeEquipmentStore = _prefix "OfficeEquipmentStore"
    /// <summary>
    /// Game server status: OfflinePermanently. Server is offline and not available.
    /// <see href="http://schema.org/OfflinePermanently"></see></summary>
    let OfflinePermanently = _prefix "OfflinePermanently"
    /// <summary>
    /// Game server status: OfflineTemporarily. Server is offline now but it can be online soon.
    /// <see href="http://schema.org/OfflineTemporarily"></see></summary>
    let OfflineTemporarily = _prefix "OfflineTemporarily"
    /// <summary>
    /// A publication event e.g. catch-up TV or radio podcast, during which a program is available on-demand.
    /// <see href="http://schema.org/OnDemandEvent"></see></summary>
    let OnDemandEvent = _prefix "OnDemandEvent"
    /// <summary>
    /// A DeliveryMethod in which an item is collected on site, e.g. in a store or at a box office.
    /// <see href="http://schema.org/OnSitePickup"></see></summary>
    let OnSitePickup = _prefix "OnSitePickup"
    /// <summary>
    /// Game server status: Online. Server is available.
    /// <see href="http://schema.org/Online"></see></summary>
    let Online = _prefix "Online"
    /// <summary>
    /// Game server status: OnlineFull. Server is online but unavailable. The maximum number of players has reached.
    /// <see href="http://schema.org/OnlineFull"></see></summary>
    let OnlineFull = _prefix "OnlineFull"
    /// <summary>
    /// Indicates that the item is available only online.
    /// <see href="http://schema.org/OnlineOnly"></see></summary>
    let OnlineOnly = _prefix "OnlineOnly"
    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;br/&gt;&lt;br/&gt;
    ///
    /// If the value for the &lt;a class="localLink" href="http://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.
    /// <see href="http://schema.org/OpeningHoursSpecification"></see></summary>
    let OpeningHoursSpecification = _prefix "OpeningHoursSpecification"
    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// <see href="http://schema.org/Order"></see></summary>
    let Order = _prefix "Order"
    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// <see href="http://schema.org/OrderAction"></see></summary>
    let OrderAction = _prefix "OrderAction"
    /// <summary>
    /// OrderStatus representing cancellation of an order.
    /// <see href="http://schema.org/OrderCancelled"></see></summary>
    let OrderCancelled = _prefix "OrderCancelled"
    /// <summary>
    /// Enumerated status values for Order.
    /// <see href="http://schema.org/OrderStatus"></see></summary>
    let OrderStatus = _prefix "OrderStatus"
    /// <summary>
    /// OrderStatus representing successful delivery of an order.
    /// <see href="http://schema.org/OrderDelivered"></see></summary>
    let OrderDelivered = _prefix "OrderDelivered"
    /// <summary>
    /// OrderStatus representing that an order is in transit.
    /// <see href="http://schema.org/OrderInTransit"></see></summary>
    let OrderInTransit = _prefix "OrderInTransit"
    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// <see href="http://schema.org/OrderItem"></see></summary>
    let OrderItem = _prefix "OrderItem"
    /// <summary>
    /// OrderStatus representing that payment is due on an order.
    /// <see href="http://schema.org/OrderPaymentDue"></see></summary>
    let OrderPaymentDue = _prefix "OrderPaymentDue"
    /// <summary>
    /// OrderStatus representing availability of an order for pickup.
    /// <see href="http://schema.org/OrderPickupAvailable"></see></summary>
    let OrderPickupAvailable = _prefix "OrderPickupAvailable"
    /// <summary>
    /// OrderStatus representing that there is a problem with the order.
    /// <see href="http://schema.org/OrderProblem"></see></summary>
    let OrderProblem = _prefix "OrderProblem"
    /// <summary>
    /// OrderStatus representing that an order is being processed.
    /// <see href="http://schema.org/OrderProcessing"></see></summary>
    let OrderProcessing = _prefix "OrderProcessing"
    /// <summary>
    /// OrderStatus representing that an order has been returned.
    /// <see href="http://schema.org/OrderReturned"></see></summary>
    let OrderReturned = _prefix "OrderReturned"
    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/06/introducing-role.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// Indicates that the item is out of stock.
    /// <see href="http://schema.org/OutOfStock"></see></summary>
    let OutOfStock = _prefix "OutOfStock"
    /// <summary>
    /// An outlet store.
    /// <see href="http://schema.org/OutletStore"></see></summary>
    let OutletStore = _prefix "OutletStore"
    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// <see href="http://schema.org/OwnershipInfo"></see></summary>
    let OwnershipInfo = _prefix "OwnershipInfo"
    /// <summary>
    /// The act of producing a painting, typically with paint and canvas as instruments.
    /// <see href="http://schema.org/PaintAction"></see></summary>
    let PaintAction = _prefix "PaintAction"
    /// <summary>
    /// A painting.
    /// <see href="http://schema.org/Painting"></see></summary>
    let Painting = _prefix "Painting"
    /// <summary>
    /// Book format: Paperback.
    /// <see href="http://schema.org/Paperback"></see></summary>
    let Paperback = _prefix "Paperback"
    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// <see href="http://schema.org/ParcelDelivery"></see></summary>
    let ParcelDelivery = _prefix "ParcelDelivery"
    /// <summary>
    /// A private parcel service as the delivery mode available for a certain offer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DHL&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#FederalExpress&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#UPS&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/ParcelService"></see></summary>
    let ParcelService = _prefix "ParcelService"
    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// <see href="http://schema.org/ParentAudience"></see></summary>
    let ParentAudience = _prefix "ParentAudience"
    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// <see href="http://schema.org/PeopleAudience"></see></summary>
    let PeopleAudience = _prefix "PeopleAudience"
    /// <summary>
    /// A park.
    /// <see href="http://schema.org/Park"></see></summary>
    let Park = _prefix "Park"
    /// <summary>
    /// A parking lot or other parking facility.
    /// <see href="http://schema.org/ParkingFacility"></see></summary>
    let ParkingFacility = _prefix "ParkingFacility"
    /// <summary>
    /// A parking map.
    /// <see href="http://schema.org/ParkingMap"></see></summary>
    let ParkingMap = _prefix "ParkingMap"
    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// <see href="http://schema.org/PawnShop"></see></summary>
    let PawnShop = _prefix "PawnShop"
    /// <summary>
    /// An agent pays a price to a participant.
    /// <see href="http://schema.org/PayAction"></see></summary>
    let PayAction = _prefix "PayAction"
    /// <summary>
    /// An automatic payment system is in place and will be used.
    /// <see href="http://schema.org/PaymentAutomaticallyApplied"></see></summary>
    let PaymentAutomaticallyApplied = _prefix "PaymentAutomaticallyApplied"
    /// <summary>
    /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    /// <see href="http://schema.org/PaymentStatusType"></see></summary>
    let PaymentStatusType = _prefix "PaymentStatusType"
    /// <summary>
    /// A payment method is a standardized procedure for transferring the monetary amount for a purchase. Payment methods are characterized by the legal and technical structures used, and by the organization or group carrying out the transaction.&lt;br/&gt;&lt;br/&gt;
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
    ///
    /// <see href="http://schema.org/PaymentMethod"></see></summary>
    let PaymentMethod = _prefix "PaymentMethod"
    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// <see href="http://schema.org/PaymentChargeSpecification"></see></summary>
    let PaymentChargeSpecification = _prefix "PaymentChargeSpecification"
    /// <summary>
    /// The payment has been received and processed.
    /// <see href="http://schema.org/PaymentComplete"></see></summary>
    let PaymentComplete = _prefix "PaymentComplete"
    /// <summary>
    /// The payee received the payment, but it was declined for some reason.
    /// <see href="http://schema.org/PaymentDeclined"></see></summary>
    let PaymentDeclined = _prefix "PaymentDeclined"
    /// <summary>
    /// The payment is due, but still within an acceptable time to be received.
    /// <see href="http://schema.org/PaymentDue"></see></summary>
    let PaymentDue = _prefix "PaymentDue"
    /// <summary>
    /// The payment is due and considered late.
    /// <see href="http://schema.org/PaymentPastDue"></see></summary>
    let PaymentPastDue = _prefix "PaymentPastDue"
    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// <see href="http://schema.org/PaymentService"></see></summary>
    let PaymentService = _prefix "PaymentService"
    /// <summary>
    /// The act of participating in performance arts.
    /// <see href="http://schema.org/PerformAction"></see></summary>
    let PerformAction = _prefix "PerformAction"
    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// <see href="http://schema.org/PerformanceRole"></see></summary>
    let PerformanceRole = _prefix "PerformanceRole"
    /// <summary>
    /// A theater or other performing art center.
    /// <see href="http://schema.org/PerformingArtsTheater"></see></summary>
    let PerformingArtsTheater = _prefix "PerformingArtsTheater"
    /// <summary>
    /// A publication in any medium issued in successive parts bearing numerical or chronological designations and intended, such as a magazine, scholarly journal, or newspaper to continue indefinitely.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/Periodical"></see></summary>
    let Periodical = _prefix "Periodical"
    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// <see href="http://schema.org/Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// A pet store.
    /// <see href="http://schema.org/PetStore"></see></summary>
    let PetStore = _prefix "PetStore"
    /// <summary>
    /// A pharmacy or drugstore.
    /// <see href="http://schema.org/Pharmacy"></see></summary>
    let Pharmacy = _prefix "Pharmacy"
    /// <summary>
    /// A photograph.
    /// <see href="http://schema.org/Photograph"></see></summary>
    let Photograph = _prefix "Photograph"
    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// <see href="http://schema.org/PhotographAction"></see></summary>
    let PhotographAction = _prefix "PhotographAction"
    /// <summary>
    /// A doctor's office.
    /// <see href="http://schema.org/Physician"></see></summary>
    let Physician = _prefix "Physician"
    /// <summary>
    /// A playground.
    /// <see href="http://schema.org/Playground"></see></summary>
    let Playground = _prefix "Playground"
    /// <summary>
    /// A plumbing service.
    /// <see href="http://schema.org/Plumber"></see></summary>
    let Plumber = _prefix "Plumber"
    /// <summary>
    /// A police station.
    /// <see href="http://schema.org/PoliceStation"></see></summary>
    let PoliceStation = _prefix "PoliceStation"
    /// <summary>
    /// A pond.
    /// <see href="http://schema.org/Pond"></see></summary>
    let Pond = _prefix "Pond"
    /// <summary>
    /// A post office.
    /// <see href="http://schema.org/PostOffice"></see></summary>
    let PostOffice = _prefix "PostOffice"
    /// <summary>
    /// The mailing address.
    /// <see href="http://schema.org/PostalAddress"></see></summary>
    let PostalAddress = _prefix "PostalAddress"
    /// <summary>
    /// A description of an action that is supported.
    /// <see href="http://schema.org/PotentialActionStatus"></see></summary>
    let PotentialActionStatus = _prefix "PotentialActionStatus"
    /// <summary>
    /// Indicates that the item is available for pre-order.
    /// <see href="http://schema.org/PreOrder"></see></summary>
    let PreOrder = _prefix "PreOrder"
    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// <see href="http://schema.org/PreOrderAction"></see></summary>
    let PreOrderAction = _prefix "PreOrderAction"
    /// <summary>
    /// Indicates that the item is available for ordering and delivery before general availability.
    /// <see href="http://schema.org/PreSale"></see></summary>
    let PreSale = _prefix "PreSale"
    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// <see href="http://schema.org/PrependAction"></see></summary>
    let PrependAction = _prefix "PrependAction"
    /// <summary>
    /// A preschool.
    /// <see href="http://schema.org/Preschool"></see></summary>
    let Preschool = _prefix "Preschool"
    /// <summary>
    /// A file containing slides or used for a presentation.
    /// <see href="http://schema.org/PresentationDigitalDocument"></see></summary>
    let PresentationDigitalDocument = _prefix "PresentationDigitalDocument"
    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// <see href="http://schema.org/ProductModel"></see></summary>
    let ProductModel = _prefix "ProductModel"
    /// <summary>
    /// Original definition: "provider of professional services."&lt;br/&gt;&lt;br/&gt;
    ///
    /// The general &lt;a class="localLink" href="http://schema.org/ProfessionalService"&gt;ProfessionalService&lt;/a&gt; type for local businesses was deprecated due to confusion with &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;. For reference, the types that it included were: &lt;a class="localLink" href="http://schema.org/Dentist"&gt;Dentist&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/AccountingService"&gt;AccountingService&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Notary"&gt;Notary&lt;/a&gt;, as well as types for several kinds of &lt;a class="localLink" href="http://schema.org/HomeAndConstructionBusiness"&gt;HomeAndConstructionBusiness&lt;/a&gt;: &lt;a class="localLink" href="http://schema.org/Electrician"&gt;Electrician&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/GeneralContractor"&gt;GeneralContractor&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/HousePainter"&gt;HousePainter&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Locksmith"&gt;Locksmith&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Plumber"&gt;Plumber&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RoofingContractor"&gt;RoofingContractor&lt;/a&gt;. &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; was introduced as a more inclusive supertype of &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;.
    /// <see href="http://schema.org/ProfessionalService"></see></summary>
    let ProfessionalService = _prefix "ProfessionalService"
    /// <summary>
    /// Web page type: Profile page.
    /// <see href="http://schema.org/ProfilePage"></see></summary>
    let ProfilePage = _prefix "ProfilePage"
    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// <see href="http://schema.org/ProgramMembership"></see></summary>
    let ProgramMembership = _prefix "ProgramMembership"
    /// <summary>
    /// A Property value specification.
    /// <see href="http://schema.org/PropertyValueSpecification"></see></summary>
    let PropertyValueSpecification = _prefix "PropertyValueSpecification"
    /// <summary>
    /// This stands for any day that is a public holiday; it is a placeholder for all official public holidays in some particular location. While not technically a "day of the week", it can be used with &lt;a class="localLink" href="http://schema.org/OpeningHoursSpecification"&gt;OpeningHoursSpecification&lt;/a&gt;. In the context of an opening hours specification it can be used to indicate opening hours on public holidays, overriding general opening hours for the day of the week on which a public holiday occurs.
    /// <see href="http://schema.org/PublicHolidays"></see></summary>
    let PublicHolidays = _prefix "PublicHolidays"
    /// <summary>
    /// A public swimming pool.
    /// <see href="http://schema.org/PublicSwimmingPool"></see></summary>
    let PublicSwimmingPool = _prefix "PublicSwimmingPool"
    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/PublicationIssue"></see></summary>
    let PublicationIssue = _prefix "PublicationIssue"
    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/PublicationVolume"></see></summary>
    let PublicationVolume = _prefix "PublicationVolume"
    /// <summary>
    /// A QAPage is a WebPage focussed on a specific Question and its Answer(s), e.g. in a question answering site or documenting Frequently Asked Questions (FAQs).
    /// <see href="http://schema.org/QAPage"></see></summary>
    let QAPage = _prefix "QAPage"
    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// <see href="http://schema.org/QuantitativeValue"></see></summary>
    let QuantitativeValue = _prefix "QuantitativeValue"
    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// <see href="http://schema.org/Question"></see></summary>
    let Question = _prefix "Question"
    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// <see href="http://schema.org/QuoteAction"></see></summary>
    let QuoteAction = _prefix "QuoteAction"
    /// <summary>
    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    /// <see href="http://schema.org/RVPark"></see></summary>
    let RVPark = _prefix "RVPark"
    /// <summary>
    /// A short radio program or a segment/part of a radio program.
    /// <see href="http://schema.org/RadioClip"></see></summary>
    let RadioClip = _prefix "RadioClip"
    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// <see href="http://schema.org/RadioEpisode"></see></summary>
    let RadioEpisode = _prefix "RadioEpisode"
    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// <see href="http://schema.org/RadioSeason"></see></summary>
    let RadioSeason = _prefix "RadioSeason"
    /// <summary>
    /// CreativeWorkSeries dedicated to radio broadcast and associated online delivery.
    /// <see href="http://schema.org/RadioSeries"></see></summary>
    let RadioSeries = _prefix "RadioSeries"
    /// <summary>
    /// A radio station.
    /// <see href="http://schema.org/RadioStation"></see></summary>
    let RadioStation = _prefix "RadioStation"
    /// <summary>
    /// The act of consuming written content.
    /// <see href="http://schema.org/ReadAction"></see></summary>
    let ReadAction = _prefix "ReadAction"
    /// <summary>
    /// Permission to read or view the document.
    /// <see href="http://schema.org/ReadPermission"></see></summary>
    let ReadPermission = _prefix "ReadPermission"
    /// <summary>
    /// A real-estate agent.
    /// <see href="http://schema.org/RealEstateAgent"></see></summary>
    let RealEstateAgent = _prefix "RealEstateAgent"
    /// <summary>
    /// Real-wheel drive is a transmission layout where the engine drives the rear wheels.
    /// <see href="http://schema.org/RearWheelDriveConfiguration"></see></summary>
    let RearWheelDriveConfiguration = _prefix "RearWheelDriveConfiguration"
    /// <summary>
    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: The reciprocal of ReceiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/ReceiveAction"></see></summary>
    let ReceiveAction = _prefix "ReceiveAction"
    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="http://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="http://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.
    /// <see href="http://schema.org/Recipe"></see></summary>
    let Recipe = _prefix "Recipe"
    /// <summary>
    /// A recycling center.
    /// <see href="http://schema.org/RecyclingCenter"></see></summary>
    let RecyclingCenter = _prefix "RecyclingCenter"
    /// <summary>
    /// Indicates that the item is refurbished.
    /// <see href="http://schema.org/RefurbishedCondition"></see></summary>
    let RefurbishedCondition = _prefix "RefurbishedCondition"
    /// <summary>
    /// The act of registering to be a user of a service, product or web page.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, RegisterAction implies you are registering to be a user of a service, &lt;em&gt;not&lt;/em&gt; a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;[FollowAction]]: Unlike FollowAction, RegisterAction doesn't imply that the agent is expecting to poll for updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, RegisterAction doesn't imply that the agent is expecting updates from the object.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/RegisterAction"></see></summary>
    let RegisterAction = _prefix "RegisterAction"
    /// <summary>
    /// The act of rejecting to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AcceptAction"&gt;AcceptAction&lt;/a&gt;: The antonym of RejectAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/RejectAction"></see></summary>
    let RejectAction = _prefix "RejectAction"
    /// <summary>
    /// RemixAlbum.
    /// <see href="http://schema.org/RemixAlbum"></see></summary>
    let RemixAlbum = _prefix "RemixAlbum"
    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// <see href="http://schema.org/RentAction"></see></summary>
    let RentAction = _prefix "RentAction"
    /// <summary>
    /// A reservation for a rental car.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// <see href="http://schema.org/RentalCarReservation"></see></summary>
    let RentalCarReservation = _prefix "RentalCarReservation"
    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// <see href="http://schema.org/ReplaceAction"></see></summary>
    let ReplaceAction = _prefix "ReplaceAction"
    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to &lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;: Appears generally as an origin of a ReplyAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/ReplyAction"></see></summary>
    let ReplyAction = _prefix "ReplyAction"
    /// <summary>
    /// A Report generated by governmental or non-governmental organization.
    /// <see href="http://schema.org/Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    /// Researchers.
    /// <see href="http://schema.org/Researcher"></see></summary>
    let Researcher = _prefix "Researcher"
    /// <summary>
    /// The status for a previously confirmed reservation that is now cancelled.
    /// <see href="http://schema.org/ReservationCancelled"></see></summary>
    let ReservationCancelled = _prefix "ReservationCancelled"
    /// <summary>
    /// Enumerated status values for Reservation.
    /// <see href="http://schema.org/ReservationStatusType"></see></summary>
    let ReservationStatusType = _prefix "ReservationStatusType"
    /// <summary>
    /// The status of a confirmed reservation.
    /// <see href="http://schema.org/ReservationConfirmed"></see></summary>
    let ReservationConfirmed = _prefix "ReservationConfirmed"
    /// <summary>
    /// The status of a reservation on hold pending an update like credit card number or flight changes.
    /// <see href="http://schema.org/ReservationHold"></see></summary>
    let ReservationHold = _prefix "ReservationHold"
    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// <see href="http://schema.org/ReservationPackage"></see></summary>
    let ReservationPackage = _prefix "ReservationPackage"
    /// <summary>
    /// The status of a reservation when a request has been sent, but not confirmed.
    /// <see href="http://schema.org/ReservationPending"></see></summary>
    let ReservationPending = _prefix "ReservationPending"
    /// <summary>
    /// Reserving a concrete object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ScheduleAction"&gt;ScheduleAction&lt;/a&gt;&lt;/a&gt;: Unlike ScheduleAction, ReserveAction reserves concrete objects (e.g. a table, a hotel) towards a time slot / spatial allocation.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/ReserveAction"></see></summary>
    let ReserveAction = _prefix "ReserveAction"
    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// <see href="http://schema.org/Reservoir"></see></summary>
    let Reservoir = _prefix "Reservoir"
    /// <summary>
    /// A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishment operated by a single company (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Resort"&gt;http://en.wikipedia.org/wiki/Resort&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Resort"></see></summary>
    let Resort = _prefix "Resort"
    /// <summary>
    /// A restaurant.
    /// <see href="http://schema.org/Restaurant"></see></summary>
    let Restaurant = _prefix "Restaurant"
    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    /// <see href="http://schema.org/ResumeAction"></see></summary>
    let ResumeAction = _prefix "ResumeAction"
    /// <summary>
    /// The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).
    /// <see href="http://schema.org/ReturnAction"></see></summary>
    let ReturnAction = _prefix "ReturnAction"
    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// <see href="http://schema.org/ReviewAction"></see></summary>
    let ReviewAction = _prefix "ReviewAction"
    /// <summary>
    /// The steering position is on the right side of the vehicle (viewed from the main direction of driving).
    /// <see href="http://schema.org/RightHandDriving"></see></summary>
    let RightHandDriving = _prefix "RightHandDriving"
    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// <see href="http://schema.org/RiverBodyOfWater"></see></summary>
    let RiverBodyOfWater = _prefix "RiverBodyOfWater"
    /// <summary>
    /// A roofing contractor.
    /// <see href="http://schema.org/RoofingContractor"></see></summary>
    let RoofingContractor = _prefix "RoofingContractor"
    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// <see href="http://schema.org/RsvpAction"></see></summary>
    let RsvpAction = _prefix "RsvpAction"
    /// <summary>
    /// The invitee may or may not attend.
    /// <see href="http://schema.org/RsvpResponseMaybe"></see></summary>
    let RsvpResponseMaybe = _prefix "RsvpResponseMaybe"
    /// <summary>
    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// <see href="http://schema.org/RsvpResponseType"></see></summary>
    let RsvpResponseType = _prefix "RsvpResponseType"
    /// <summary>
    /// The invitee will not attend.
    /// <see href="http://schema.org/RsvpResponseNo"></see></summary>
    let RsvpResponseNo = _prefix "RsvpResponseNo"
    /// <summary>
    /// The invitee will attend.
    /// <see href="http://schema.org/RsvpResponseYes"></see></summary>
    let RsvpResponseYes = _prefix "RsvpResponseYes"
    /// <summary>
    /// Event type: Sales event.
    /// <see href="http://schema.org/SaleEvent"></see></summary>
    let SaleEvent = _prefix "SaleEvent"
    /// <summary>
    /// The day of the week between Friday and Sunday.
    /// <see href="http://schema.org/Saturday"></see></summary>
    let Saturday = _prefix "Saturday"
    /// <summary>
    /// Scheduling future actions, events, or tasks.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReserveAction"&gt;ReserveAction&lt;/a&gt;: Unlike ReserveAction, ScheduleAction allocates future actions (e.g. an event, a task, etc) towards a time slot / spatial allocation.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/ScheduleAction"></see></summary>
    let ScheduleAction = _prefix "ScheduleAction"
    /// <summary>
    /// A scholarly article.
    /// <see href="http://schema.org/ScholarlyArticle"></see></summary>
    let ScholarlyArticle = _prefix "ScholarlyArticle"
    /// <summary>
    /// A school.
    /// <see href="http://schema.org/School"></see></summary>
    let School = _prefix "School"
    /// <summary>
    /// A screening of a movie or other video.
    /// <see href="http://schema.org/ScreeningEvent"></see></summary>
    let ScreeningEvent = _prefix "ScreeningEvent"
    /// <summary>
    /// A piece of sculpture.
    /// <see href="http://schema.org/Sculpture"></see></summary>
    let Sculpture = _prefix "Sculpture"
    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// <see href="http://schema.org/SeaBodyOfWater"></see></summary>
    let SeaBodyOfWater = _prefix "SeaBodyOfWater"
    /// <summary>
    /// The act of searching for an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FindAction"&gt;FindAction&lt;/a&gt;: SearchAction generally leads to a FindAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/SearchAction"></see></summary>
    let SearchAction = _prefix "SearchAction"
    /// <summary>
    /// Web page type: Search results page.
    /// <see href="http://schema.org/SearchResultsPage"></see></summary>
    let SearchResultsPage = _prefix "SearchResultsPage"
    /// <summary>
    /// A media season e.g. tv, radio, video game etc.
    /// <see href="http://schema.org/Season"></see></summary>
    let Season = _prefix "Season"
    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// <see href="http://schema.org/Seat"></see></summary>
    let Seat = _prefix "Seat"
    /// <summary>
    /// A seating map.
    /// <see href="http://schema.org/SeatingMap"></see></summary>
    let SeatingMap = _prefix "SeatingMap"
    /// <summary>
    /// A self-storage facility.
    /// <see href="http://schema.org/SelfStorage"></see></summary>
    let SelfStorage = _prefix "SelfStorage"
    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    /// <see href="http://schema.org/SellAction"></see></summary>
    let SellAction = _prefix "SellAction"
    /// <summary>
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: The reciprocal of SendAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/SendAction"></see></summary>
    let SendAction = _prefix "SendAction"
    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// <see href="http://schema.org/ServiceChannel"></see></summary>
    let ServiceChannel = _prefix "ServiceChannel"
    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// <see href="http://schema.org/ShareAction"></see></summary>
    let ShareAction = _prefix "ShareAction"
    /// <summary>
    /// A shoe store.
    /// <see href="http://schema.org/ShoeStore"></see></summary>
    let ShoeStore = _prefix "ShoeStore"
    /// <summary>
    /// A shopping center or mall.
    /// <see href="http://schema.org/ShoppingCenter"></see></summary>
    let ShoppingCenter = _prefix "ShoppingCenter"
    /// <summary>
    /// Residence type: Single-family home.
    /// <see href="http://schema.org/SingleFamilyResidence"></see></summary>
    let SingleFamilyResidence = _prefix "SingleFamilyResidence"
    /// <summary>
    /// Play mode: SinglePlayer. Which is played by a lone player.
    /// <see href="http://schema.org/SinglePlayer"></see></summary>
    let SinglePlayer = _prefix "SinglePlayer"
    /// <summary>
    /// SingleRelease.
    /// <see href="http://schema.org/SingleRelease"></see></summary>
    let SingleRelease = _prefix "SingleRelease"
    /// <summary>
    /// A navigation element of the page.
    /// <see href="http://schema.org/SiteNavigationElement"></see></summary>
    let SiteNavigationElement = _prefix "SiteNavigationElement"
    /// <summary>
    /// A web page element, like a table or an image.
    /// <see href="http://schema.org/WebPageElement"></see></summary>
    let WebPageElement = _prefix "WebPageElement"
    /// <summary>
    /// A ski resort.
    /// <see href="http://schema.org/SkiResort"></see></summary>
    let SkiResort = _prefix "SkiResort"
    /// <summary>
    /// Event type: Social event.
    /// <see href="http://schema.org/SocialEvent"></see></summary>
    let SocialEvent = _prefix "SocialEvent"
    /// <summary>
    /// Indicates that the item has sold out.
    /// <see href="http://schema.org/SoldOut"></see></summary>
    let SoldOut = _prefix "SoldOut"
    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// <see href="http://schema.org/SomeProducts"></see></summary>
    let SomeProducts = _prefix "SomeProducts"
    /// <summary>
    /// SoundtrackAlbum.
    /// <see href="http://schema.org/SoundtrackAlbum"></see></summary>
    let SoundtrackAlbum = _prefix "SoundtrackAlbum"
    /// <summary>
    /// A SpeakableSpecification indicates (typically via &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt;) sections of a document that are highlighted as particularly &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt;. Instances of this type are expected to be used primarily as values of the &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt; property.
    /// <see href="http://schema.org/SpeakableSpecification"></see></summary>
    let SpeakableSpecification = _prefix "SpeakableSpecification"
    /// <summary>
    /// Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.
    /// <see href="http://schema.org/Specialty"></see></summary>
    let Specialty = _prefix "Specialty"
    /// <summary>
    /// SpokenWordAlbum.
    /// <see href="http://schema.org/SpokenWordAlbum"></see></summary>
    let SpokenWordAlbum = _prefix "SpokenWordAlbum"
    /// <summary>
    /// A sporting goods store.
    /// <see href="http://schema.org/SportingGoodsStore"></see></summary>
    let SportingGoodsStore = _prefix "SportingGoodsStore"
    /// <summary>
    /// A sports club.
    /// <see href="http://schema.org/SportsClub"></see></summary>
    let SportsClub = _prefix "SportsClub"
    /// <summary>
    /// Event type: Sports event.
    /// <see href="http://schema.org/SportsEvent"></see></summary>
    let SportsEvent = _prefix "SportsEvent"
    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// <see href="http://schema.org/SportsOrganization"></see></summary>
    let SportsOrganization = _prefix "SportsOrganization"
    /// <summary>
    /// Organization: Sports team.
    /// <see href="http://schema.org/SportsTeam"></see></summary>
    let SportsTeam = _prefix "SportsTeam"
    /// <summary>
    /// A spreadsheet file.
    /// <see href="http://schema.org/SpreadsheetDigitalDocument"></see></summary>
    let SpreadsheetDigitalDocument = _prefix "SpreadsheetDigitalDocument"
    /// <summary>
    /// A stadium.
    /// <see href="http://schema.org/StadiumOrArena"></see></summary>
    let StadiumOrArena = _prefix "StadiumOrArena"
    /// <summary>
    /// A state or province of a country.
    /// <see href="http://schema.org/State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// StudioAlbum.
    /// <see href="http://schema.org/StudioAlbum"></see></summary>
    let StudioAlbum = _prefix "StudioAlbum"
    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates pushed to.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, SubscribeAction implies that the subscriber acts as a passive agent being constantly/actively pushed for updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/SubscribeAction"></see></summary>
    let SubscribeAction = _prefix "SubscribeAction"
    /// <summary>
    /// A subway station.
    /// <see href="http://schema.org/SubwayStation"></see></summary>
    let SubwayStation = _prefix "SubwayStation"
    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Suite"></see></summary>
    let Suite = _prefix "Suite"
    /// <summary>
    /// The day of the week between Saturday and Monday.
    /// <see href="http://schema.org/Sunday"></see></summary>
    let Sunday = _prefix "Sunday"
    /// <summary>
    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    /// <see href="http://schema.org/SuspendAction"></see></summary>
    let SuspendAction = _prefix "SuspendAction"
    /// <summary>
    /// A synagogue.
    /// <see href="http://schema.org/Synagogue"></see></summary>
    let Synagogue = _prefix "Synagogue"
    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// <see href="http://schema.org/TVClip"></see></summary>
    let TVClip = _prefix "TVClip"
    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// <see href="http://schema.org/TVEpisode"></see></summary>
    let TVEpisode = _prefix "TVEpisode"
    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// <see href="http://schema.org/TVSeason"></see></summary>
    let TVSeason = _prefix "TVSeason"
    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// <see href="http://schema.org/TVSeries"></see></summary>
    let TVSeries = _prefix "TVSeries"
    /// <summary>
    /// A table on a Web page.
    /// <see href="http://schema.org/Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    /// The act of gaining ownership of an object from an origin. Reciprocal of GiveAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: The reciprocal of TakeAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: Unlike ReceiveAction, TakeAction implies that ownership has been transfered.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/TakeAction"></see></summary>
    let TakeAction = _prefix "TakeAction"
    /// <summary>
    /// A tattoo parlor.
    /// <see href="http://schema.org/TattooParlor"></see></summary>
    let TattooParlor = _prefix "TattooParlor"
    /// <summary>
    /// A taxi.
    /// <see href="http://schema.org/Taxi"></see></summary>
    let Taxi = _prefix "Taxi"
    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// <see href="http://schema.org/TaxiService"></see></summary>
    let TaxiService = _prefix "TaxiService"
    /// <summary>
    /// A reservation for a taxi.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/TaxiReservation"></see></summary>
    let TaxiReservation = _prefix "TaxiReservation"
    /// <summary>
    /// A taxi stand.
    /// <see href="http://schema.org/TaxiStand"></see></summary>
    let TaxiStand = _prefix "TaxiStand"
    /// <summary>
    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    /// <see href="http://schema.org/TelevisionChannel"></see></summary>
    let TelevisionChannel = _prefix "TelevisionChannel"
    /// <summary>
    /// A television station.
    /// <see href="http://schema.org/TelevisionStation"></see></summary>
    let TelevisionStation = _prefix "TelevisionStation"
    /// <summary>
    /// A tennis complex.
    /// <see href="http://schema.org/TennisComplex"></see></summary>
    let TennisComplex = _prefix "TennisComplex"
    /// <summary>
    /// Data type: Text.
    /// <see href="http://schema.org/Text"></see></summary>
    let Text = _prefix "Text"
    /// <summary>
    /// A file composed primarily of text.
    /// <see href="http://schema.org/TextDigitalDocument"></see></summary>
    let TextDigitalDocument = _prefix "TextDigitalDocument"
    /// <summary>
    /// Event type: Theater performance.
    /// <see href="http://schema.org/TheaterEvent"></see></summary>
    let TheaterEvent = _prefix "TheaterEvent"
    /// <summary>
    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    /// <see href="http://schema.org/TheaterGroup"></see></summary>
    let TheaterGroup = _prefix "TheaterGroup"
    /// <summary>
    /// The day of the week between Wednesday and Friday.
    /// <see href="http://schema.org/Thursday"></see></summary>
    let Thursday = _prefix "Thursday"
    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// <see href="http://schema.org/Ticket"></see></summary>
    let Ticket = _prefix "Ticket"
    /// <summary>
    /// The act of reaching a draw in a competitive activity.
    /// <see href="http://schema.org/TieAction"></see></summary>
    let TieAction = _prefix "TieAction"
    /// <summary>
    /// A point in time recurring on multiple days in the form hh:mm:ss[Z|(+|-)hh:mm] (see &lt;a href="http://www.w3.org/TR/xmlschema-2/#time"&gt;XML schema for details&lt;/a&gt;).
    /// <see href="http://schema.org/Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    /// <see href="http://schema.org/TipAction"></see></summary>
    let TipAction = _prefix "TipAction"
    /// <summary>
    /// A tire shop.
    /// <see href="http://schema.org/TireShop"></see></summary>
    let TireShop = _prefix "TireShop"
    /// <summary>
    /// The associated telephone number is toll free.
    /// <see href="http://schema.org/TollFree"></see></summary>
    let TollFree = _prefix "TollFree"
    /// <summary>
    /// A tourist attraction.  In principle any Thing can be a &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, from a &lt;a class="localLink" href="http://schema.org/Mountain"&gt;Mountain&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/LandmarksOrHistoricalBuildings"&gt;LandmarksOrHistoricalBuildings&lt;/a&gt; to a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt;.  This Type can be used on its own to describe a general &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, or be used as an &lt;a class="localLink" href="http://schema.org/additionalType"&gt;additionalType&lt;/a&gt; to add tourist attraction properties to any other type.  (See examples below)
    /// <see href="http://schema.org/TouristAttraction"></see></summary>
    let TouristAttraction = _prefix "TouristAttraction"
    /// <summary>
    /// A tourist information center.
    /// <see href="http://schema.org/TouristInformationCenter"></see></summary>
    let TouristInformationCenter = _prefix "TouristInformationCenter"
    /// <summary>
    /// A toy store.
    /// <see href="http://schema.org/ToyStore"></see></summary>
    let ToyStore = _prefix "ToyStore"
    /// <summary>
    /// An agent tracks an object for updates.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/TrackAction"></see></summary>
    let TrackAction = _prefix "TrackAction"
    /// <summary>
    /// A reservation for train travel.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/TrainReservation"></see></summary>
    let TrainReservation = _prefix "TrainReservation"
    /// <summary>
    /// A train station.
    /// <see href="http://schema.org/TrainStation"></see></summary>
    let TrainStation = _prefix "TrainStation"
    /// <summary>
    /// A trip on a commercial train line.
    /// <see href="http://schema.org/TrainTrip"></see></summary>
    let TrainTrip = _prefix "TrainTrip"
    /// <summary>
    /// A transit map.
    /// <see href="http://schema.org/TransitMap"></see></summary>
    let TransitMap = _prefix "TransitMap"
    /// <summary>
    /// The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// <see href="http://schema.org/TravelAction"></see></summary>
    let TravelAction = _prefix "TravelAction"
    /// <summary>
    /// A travel agency.
    /// <see href="http://schema.org/TravelAgency"></see></summary>
    let TravelAgency = _prefix "TravelAgency"
    /// <summary>
    /// The boolean value true.
    /// <see href="http://schema.org/True"></see></summary>
    let True = _prefix "True"
    /// <summary>
    /// The day of the week between Monday and Wednesday.
    /// <see href="http://schema.org/Tuesday"></see></summary>
    let Tuesday = _prefix "Tuesday"
    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// <see href="http://schema.org/TypeAndQuantityNode"></see></summary>
    let TypeAndQuantityNode = _prefix "TypeAndQuantityNode"
    /// <summary>
    /// Data type: URL.
    /// <see href="http://schema.org/URL"></see></summary>
    let URL = _prefix "URL"
    /// <summary>
    /// The act of un-registering from a service.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: antonym of UnRegisterAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LeaveAction"&gt;LeaveAction&lt;/a&gt;: Unlike LeaveAction, UnRegisterAction implies that you are unregistering from a service you werer previously registered, rather than leaving a team/group of people.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/UnRegisterAction"></see></summary>
    let UnRegisterAction = _prefix "UnRegisterAction"
    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// <see href="http://schema.org/UnitPriceSpecification"></see></summary>
    let UnitPriceSpecification = _prefix "UnitPriceSpecification"
    /// <summary>
    /// The act of applying an object to its intended purpose.
    /// <see href="http://schema.org/UseAction"></see></summary>
    let UseAction = _prefix "UseAction"
    /// <summary>
    /// Indicates that the item is used.
    /// <see href="http://schema.org/UsedCondition"></see></summary>
    let UsedCondition = _prefix "UsedCondition"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserBlocks"></see></summary>
    let UserBlocks = _prefix "UserBlocks"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserInteraction"></see></summary>
    let UserInteraction = _prefix "UserInteraction"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserCheckins"></see></summary>
    let UserCheckins = _prefix "UserCheckins"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserComments"></see></summary>
    let UserComments = _prefix "UserComments"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserDownloads"></see></summary>
    let UserDownloads = _prefix "UserDownloads"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserLikes"></see></summary>
    let UserLikes = _prefix "UserLikes"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserPageVisits"></see></summary>
    let UserPageVisits = _prefix "UserPageVisits"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserPlays"></see></summary>
    let UserPlays = _prefix "UserPlays"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserPlusOnes"></see></summary>
    let UserPlusOnes = _prefix "UserPlusOnes"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserTweets"></see></summary>
    let UserTweets = _prefix "UserTweets"
    /// <summary>
    /// A diet exclusive of all animal products.
    /// <see href="http://schema.org/VeganDiet"></see></summary>
    let VeganDiet = _prefix "VeganDiet"
    /// <summary>
    /// A diet exclusive of animal meat.
    /// <see href="http://schema.org/VegetarianDiet"></see></summary>
    let VegetarianDiet = _prefix "VegetarianDiet"
    /// <summary>
    /// A venue map (e.g. for malls, auditoriums, museums, etc.).
    /// <see href="http://schema.org/VenueMap"></see></summary>
    let VenueMap = _prefix "VenueMap"
    /// <summary>
    /// Web page type: Video gallery page.
    /// <see href="http://schema.org/VideoGallery"></see></summary>
    let VideoGallery = _prefix "VideoGallery"
    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// <see href="http://schema.org/VideoGame"></see></summary>
    let VideoGame = _prefix "VideoGame"
    /// <summary>
    /// A short segment/part of a video game.
    /// <see href="http://schema.org/VideoGameClip"></see></summary>
    let VideoGameClip = _prefix "VideoGameClip"
    /// <summary>
    /// A video game series.
    /// <see href="http://schema.org/VideoGameSeries"></see></summary>
    let VideoGameSeries = _prefix "VideoGameSeries"
    /// <summary>
    /// A video file.
    /// <see href="http://schema.org/VideoObject"></see></summary>
    let VideoObject = _prefix "VideoObject"
    /// <summary>
    /// The act of consuming static visual content.
    /// <see href="http://schema.org/ViewAction"></see></summary>
    let ViewAction = _prefix "ViewAction"
    /// <summary>
    /// VinylFormat.
    /// <see href="http://schema.org/VinylFormat"></see></summary>
    let VinylFormat = _prefix "VinylFormat"
    /// <summary>
    /// Event type: Visual arts event.
    /// <see href="http://schema.org/VisualArtsEvent"></see></summary>
    let VisualArtsEvent = _prefix "VisualArtsEvent"
    /// <summary>
    /// A work of art that is primarily visual in character.
    /// <see href="http://schema.org/VisualArtwork"></see></summary>
    let VisualArtwork = _prefix "VisualArtwork"
    /// <summary>
    /// A volcano, like Fuji san.
    /// <see href="http://schema.org/Volcano"></see></summary>
    let Volcano = _prefix "Volcano"
    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// <see href="http://schema.org/VoteAction"></see></summary>
    let VoteAction = _prefix "VoteAction"
    /// <summary>
    /// An advertising section of the page.
    /// <see href="http://schema.org/WPAdBlock"></see></summary>
    let WPAdBlock = _prefix "WPAdBlock"
    /// <summary>
    /// The footer section of the page.
    /// <see href="http://schema.org/WPFooter"></see></summary>
    let WPFooter = _prefix "WPFooter"
    /// <summary>
    /// The header section of the page.
    /// <see href="http://schema.org/WPHeader"></see></summary>
    let WPHeader = _prefix "WPHeader"
    /// <summary>
    /// A sidebar section of the page.
    /// <see href="http://schema.org/WPSideBar"></see></summary>
    let WPSideBar = _prefix "WPSideBar"
    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// <see href="http://schema.org/WantAction"></see></summary>
    let WantAction = _prefix "WantAction"
    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// <see href="http://schema.org/WarrantyPromise"></see></summary>
    let WarrantyPromise = _prefix "WarrantyPromise"
    /// <summary>
    /// A range of of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Labor-BringIn&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PartsAndLabor-BringIn&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PartsAndLabor-PickUp&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/WarrantyScope"></see></summary>
    let WarrantyScope = _prefix "WarrantyScope"
    /// <summary>
    /// The act of consuming dynamic/moving visual content.
    /// <see href="http://schema.org/WatchAction"></see></summary>
    let WatchAction = _prefix "WatchAction"
    /// <summary>
    /// A waterfall, like Niagara.
    /// <see href="http://schema.org/Waterfall"></see></summary>
    let Waterfall = _prefix "Waterfall"
    /// <summary>
    /// The act of dressing oneself in clothing.
    /// <see href="http://schema.org/WearAction"></see></summary>
    let WearAction = _prefix "WearAction"
    /// <summary>
    /// Web applications.
    /// <see href="http://schema.org/WebApplication"></see></summary>
    let WebApplication = _prefix "WebApplication"
    /// <summary>
    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    /// <see href="http://schema.org/WebSite"></see></summary>
    let WebSite = _prefix "WebSite"
    /// <summary>
    /// The day of the week between Tuesday and Thursday.
    /// <see href="http://schema.org/Wednesday"></see></summary>
    let Wednesday = _prefix "Wednesday"
    /// <summary>
    /// A wholesale store.
    /// <see href="http://schema.org/WholesaleStore"></see></summary>
    let WholesaleStore = _prefix "WholesaleStore"
    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// <see href="http://schema.org/WinAction"></see></summary>
    let WinAction = _prefix "WinAction"
    /// <summary>
    /// A winery.
    /// <see href="http://schema.org/Winery"></see></summary>
    let Winery = _prefix "Winery"
    /// <summary>
    /// A Workers Union (also known as a Labor Union, Labour Union, or Trade Union) is an organization that promotes the interests of its worker members by collectively bargaining with management, organizing, and political lobbying.
    /// <see href="http://schema.org/WorkersUnion"></see></summary>
    let WorkersUnion = _prefix "WorkersUnion"
    /// <summary>
    /// The act of authoring written creative content.
    /// <see href="http://schema.org/WriteAction"></see></summary>
    let WriteAction = _prefix "WriteAction"
    /// <summary>
    /// Permission to write or edit the document.
    /// <see href="http://schema.org/WritePermission"></see></summary>
    let WritePermission = _prefix "WritePermission"
    /// <summary>
    /// The airline boards by zones of the plane.
    /// <see href="http://schema.org/ZoneBoardingPolicy"></see></summary>
    let ZoneBoardingPolicy = _prefix "ZoneBoardingPolicy"
    /// <summary>
    /// A zoo.
    /// <see href="http://schema.org/Zoo"></see></summary>
    let Zoo = _prefix "Zoo"
    /// <summary>
    /// The subject matter of the content.
    /// <see href="http://schema.org/about"></see></summary>
    let about = _prefix "about"
    /// <summary>
    ///   <see href="http://schema.org/domainIncludes"></see>
    /// </summary>
    let domainIncludes = _prefix "domainIncludes"
    /// <summary>
    ///   <see href="http://schema.org/inverseOf"></see>
    /// </summary>
    let inverseOf = _prefix "inverseOf"
    /// <summary>
    /// A CreativeWork or Event about this Thing.
    /// <see href="http://schema.org/subjectOf"></see></summary>
    let subjectOf = _prefix "subjectOf"
    /// <summary>
    ///   <see href="http://schema.org/rangeIncludes"></see>
    /// </summary>
    let rangeIncludes = _prefix "rangeIncludes"
    /// <summary>
    /// The answer(s) that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
    /// <see href="http://schema.org/acceptedAnswer"></see></summary>
    let acceptedAnswer = _prefix "acceptedAnswer"
    /// <summary>
    /// An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
    /// <see href="http://schema.org/suggestedAnswer"></see></summary>
    let suggestedAnswer = _prefix "suggestedAnswer"
    /// <summary>
    /// The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
    /// <see href="http://schema.org/acceptedOffer"></see></summary>
    let acceptedOffer = _prefix "acceptedOffer"
    /// <summary>
    /// The payment method(s) accepted by seller for this offer.
    /// <see href="http://schema.org/acceptedPaymentMethod"></see></summary>
    let acceptedPaymentMethod = _prefix "acceptedPaymentMethod"
    /// <summary>
    /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
    /// <see href="http://schema.org/acceptsReservations"></see></summary>
    let acceptsReservations = _prefix "acceptsReservations"
    /// <summary>
    /// Password, PIN, or access code needed for delivery (e.g. from a locker).
    /// <see href="http://schema.org/accessCode"></see></summary>
    let accessCode = _prefix "accessCode"
    /// <summary>
    /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
    /// <see href="http://schema.org/accessMode"></see></summary>
    let accessMode = _prefix "accessMode"
    /// <summary>
    /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
    /// <see href="http://schema.org/accessModeSufficient"></see></summary>
    let accessModeSufficient = _prefix "accessModeSufficient"
    /// <summary>
    /// Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
    /// <see href="http://schema.org/accessibilityAPI"></see></summary>
    let accessibilityAPI = _prefix "accessibilityAPI"
    /// <summary>
    /// Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
    /// <see href="http://schema.org/accessibilityControl"></see></summary>
    let accessibilityControl = _prefix "accessibilityControl"
    /// <summary>
    /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
    /// <see href="http://schema.org/accessibilityFeature"></see></summary>
    let accessibilityFeature = _prefix "accessibilityFeature"
    /// <summary>
    /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
    /// <see href="http://schema.org/accessibilityHazard"></see></summary>
    let accessibilityHazard = _prefix "accessibilityHazard"
    /// <summary>
    /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
    /// <see href="http://schema.org/accessibilitySummary"></see></summary>
    let accessibilitySummary = _prefix "accessibilitySummary"
    /// <summary>
    /// The identifier for the account the payment will be applied to.
    /// <see href="http://schema.org/accountId"></see></summary>
    let accountId = _prefix "accountId"
    /// <summary>
    /// The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.
    /// <see href="http://schema.org/identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// Specifies the Person that is legally accountable for the CreativeWork.
    /// <see href="http://schema.org/accountablePerson"></see></summary>
    let accountablePerson = _prefix "accountablePerson"
    /// <summary>
    /// The organization or person from which the product was acquired.
    /// <see href="http://schema.org/acquiredFrom"></see></summary>
    let acquiredFrom = _prefix "acquiredFrom"
    /// <summary>
    /// A set of requirements that a must be fulfilled in order to perform an Action. If more than one value is specied, fulfilling one set of requirements will allow the Action to be performed.
    /// <see href="http://schema.org/actionAccessibilityRequirement"></see></summary>
    let actionAccessibilityRequirement = _prefix "actionAccessibilityRequirement"
    /// <summary>
    /// An application that can complete the request.
    /// <see href="http://schema.org/actionApplication"></see></summary>
    let actionApplication = _prefix "actionApplication"
    /// <summary>
    /// A sub property of object. The options subject to this action.
    /// <see href="http://schema.org/actionOption"></see></summary>
    let actionOption = _prefix "actionOption"
    /// <summary>
    /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read &lt;em&gt;a book&lt;/em&gt;.
    /// <see href="http://schema.org/object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
    /// <see href="http://schema.org/actionPlatform"></see></summary>
    let actionPlatform = _prefix "actionPlatform"
    /// <summary>
    /// Indicates the current disposition of the Action.
    /// <see href="http://schema.org/actionStatus"></see></summary>
    let actionStatus = _prefix "actionStatus"
    /// <summary>
    /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
    /// <see href="http://schema.org/actor"></see></summary>
    let actor = _prefix "actor"
    /// <summary>
    /// An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip.
    /// <see href="http://schema.org/actors"></see></summary>
    let actors = _prefix "actors"
    /// <summary>
    /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
    /// <see href="http://schema.org/addOn"></see></summary>
    let addOn = _prefix "addOn"
    /// <summary>
    /// An additional name for a Person, can be used for a middle name.
    /// <see href="http://schema.org/additionalName"></see></summary>
    let additionalName = _prefix "additionalName"
    /// <summary>
    /// If responding yes, the number of guests who will attend in addition to the invitee.
    /// <see href="http://schema.org/additionalNumberOfGuests"></see></summary>
    let additionalNumberOfGuests = _prefix "additionalNumberOfGuests"
    /// <summary>
    /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
    /// <see href="http://schema.org/additionalProperty"></see></summary>
    let additionalProperty = _prefix "additionalProperty"
    /// <summary>
    /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
    /// <see href="http://schema.org/additionalType"></see></summary>
    let additionalType = _prefix "additionalType"
    /// <summary>
    /// Physical address of the item.
    /// <see href="http://schema.org/address"></see></summary>
    let address = _prefix "address"
    /// <summary>
    /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
    /// <see href="http://schema.org/addressCountry"></see></summary>
    let addressCountry = _prefix "addressCountry"
    /// <summary>
    /// The locality in which the street address is, and which is in the region. For example, Mountain View.
    /// <see href="http://schema.org/addressLocality"></see></summary>
    let addressLocality = _prefix "addressLocality"
    /// <summary>
    /// The region in which the locality is, and which is in the country. For example, California or another appropriate first-level &lt;a href="https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country"&gt;Administrative division&lt;/a&gt;
    /// <see href="http://schema.org/addressRegion"></see></summary>
    let addressRegion = _prefix "addressRegion"
    /// <summary>
    /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
    /// <see href="http://schema.org/advanceBookingRequirement"></see></summary>
    let advanceBookingRequirement = _prefix "advanceBookingRequirement"
    /// <summary>
    /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
    /// <see href="http://schema.org/affiliation"></see></summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
    /// <see href="http://schema.org/memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// A media object representing the circumstances after performing this direction.
    /// <see href="http://schema.org/afterMedia"></see></summary>
    let afterMedia = _prefix "afterMedia"
    /// <summary>
    /// The direct performer or driver of the action (animate or inanimate). e.g. &lt;em&gt;John&lt;/em&gt; wrote a book.
    /// <see href="http://schema.org/agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    /// The overall rating, based on a collection of reviews or ratings, of the item.
    /// <see href="http://schema.org/aggregateRating"></see></summary>
    let aggregateRating = _prefix "aggregateRating"
    /// <summary>
    /// The kind of aircraft (e.g., "Boeing 747").
    /// <see href="http://schema.org/aircraft"></see></summary>
    let aircraft = _prefix "aircraft"
    /// <summary>
    /// A music album.
    /// <see href="http://schema.org/album"></see></summary>
    let album = _prefix "album"
    /// <summary>
    /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
    /// <see href="http://schema.org/albumProductionType"></see></summary>
    let albumProductionType = _prefix "albumProductionType"
    /// <summary>
    /// A release of this album.
    /// <see href="http://schema.org/albumRelease"></see></summary>
    let albumRelease = _prefix "albumRelease"
    /// <summary>
    /// The album this is a release of.
    /// <see href="http://schema.org/releaseOf"></see></summary>
    let releaseOf = _prefix "releaseOf"
    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// <see href="http://schema.org/albumReleaseType"></see></summary>
    let albumReleaseType = _prefix "albumReleaseType"
    /// <summary>
    /// A collection of music albums.
    /// <see href="http://schema.org/albums"></see></summary>
    let albums = _prefix "albums"
    /// <summary>
    /// A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 'educationalSubject', and 'educationalLevel'.
    /// <see href="http://schema.org/alignmentType"></see></summary>
    let alignmentType = _prefix "alignmentType"
    /// <summary>
    /// An alias for the item.
    /// <see href="http://schema.org/alternateName"></see></summary>
    let alternateName = _prefix "alternateName"
    /// <summary>
    /// A secondary title of the CreativeWork.
    /// <see href="http://schema.org/alternativeHeadline"></see></summary>
    let alternativeHeadline = _prefix "alternativeHeadline"
    /// <summary>
    /// Alumni of an organization.
    /// <see href="http://schema.org/alumni"></see></summary>
    let alumni = _prefix "alumni"
    /// <summary>
    /// An organization that the person is an alumni of.
    /// <see href="http://schema.org/alumniOf"></see></summary>
    let alumniOf = _prefix "alumniOf"
    /// <summary>
    /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
    /// <see href="http://schema.org/amenityFeature"></see></summary>
    let amenityFeature = _prefix "amenityFeature"
    /// <summary>
    ///   <see href="http://schema.org/FloorPlan"></see>
    /// </summary>
    let FloorPlan = _prefix "FloorPlan"
    /// <summary>
    /// The amount of money.
    /// <see href="http://schema.org/amount"></see></summary>
    let amount = _prefix "amount"
    /// <summary>
    ///   <see href="http://schema.org/MoneyTransfer"></see>
    /// </summary>
    let MoneyTransfer = _prefix "MoneyTransfer"
    /// <summary>
    ///   <see href="http://schema.org/MonetaryGrant"></see>
    /// </summary>
    let MonetaryGrant = _prefix "MonetaryGrant"
    /// <summary>
    /// The quantity of the goods included in the offer.
    /// <see href="http://schema.org/amountOfThisGood"></see></summary>
    let amountOfThisGood = _prefix "amountOfThisGood"
    /// <summary>
    /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
    /// <see href="http://schema.org/annualPercentageRate"></see></summary>
    let annualPercentageRate = _prefix "annualPercentageRate"
    /// <summary>
    /// The number of answers this question has received.
    /// <see href="http://schema.org/answerCount"></see></summary>
    let answerCount = _prefix "answerCount"
    /// <summary>
    /// An application that can complete the request.
    /// <see href="http://schema.org/application"></see></summary>
    let application = _prefix "application"
    /// <summary>
    /// Type of software application, e.g. 'Game, Multimedia'.
    /// <see href="http://schema.org/applicationCategory"></see></summary>
    let applicationCategory = _prefix "applicationCategory"
    /// <summary>
    /// Subcategory of the application, e.g. 'Arcade Game'.
    /// <see href="http://schema.org/applicationSubCategory"></see></summary>
    let applicationSubCategory = _prefix "applicationSubCategory"
    /// <summary>
    /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
    /// <see href="http://schema.org/applicationSuite"></see></summary>
    let applicationSuite = _prefix "applicationSuite"
    /// <summary>
    /// The delivery method(s) to which the delivery charge or payment charge specification applies.
    /// <see href="http://schema.org/appliesToDeliveryMethod"></see></summary>
    let appliesToDeliveryMethod = _prefix "appliesToDeliveryMethod"
    /// <summary>
    /// The payment method(s) to which the payment charge specification applies.
    /// <see href="http://schema.org/appliesToPaymentMethod"></see></summary>
    let appliesToPaymentMethod = _prefix "appliesToPaymentMethod"
    /// <summary>
    /// The area within which users can expect to reach the broadcast service.
    /// <see href="http://schema.org/area"></see></summary>
    let area = _prefix "area"
    /// <summary>
    /// The geographic area where the service is provided.
    /// <see href="http://schema.org/serviceArea"></see></summary>
    let serviceArea = _prefix "serviceArea"
    /// <summary>
    /// The geographic area where a service or offered item is provided.
    /// <see href="http://schema.org/areaServed"></see></summary>
    let areaServed = _prefix "areaServed"
    /// <summary>
    /// The airport where the flight terminates.
    /// <see href="http://schema.org/arrivalAirport"></see></summary>
    let arrivalAirport = _prefix "arrivalAirport"
    /// <summary>
    /// The stop or station from which the bus arrives.
    /// <see href="http://schema.org/arrivalBusStop"></see></summary>
    let arrivalBusStop = _prefix "arrivalBusStop"
    /// <summary>
    /// Identifier of the flight's arrival gate.
    /// <see href="http://schema.org/arrivalGate"></see></summary>
    let arrivalGate = _prefix "arrivalGate"
    /// <summary>
    /// The platform where the train arrives.
    /// <see href="http://schema.org/arrivalPlatform"></see></summary>
    let arrivalPlatform = _prefix "arrivalPlatform"
    /// <summary>
    /// The station where the train trip ends.
    /// <see href="http://schema.org/arrivalStation"></see></summary>
    let arrivalStation = _prefix "arrivalStation"
    /// <summary>
    /// Identifier of the flight's arrival terminal.
    /// <see href="http://schema.org/arrivalTerminal"></see></summary>
    let arrivalTerminal = _prefix "arrivalTerminal"
    /// <summary>
    /// The expected arrival time.
    /// <see href="http://schema.org/arrivalTime"></see></summary>
    let arrivalTime = _prefix "arrivalTime"
    /// <summary>
    /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
    /// <see href="http://schema.org/artEdition"></see></summary>
    let artEdition = _prefix "artEdition"
    /// <summary>
    /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
    /// <see href="http://schema.org/artMedium"></see></summary>
    let artMedium = _prefix "artMedium"
    /// <summary>
    /// A material that something is made from, e.g. leather, wool, cotton, paper.
    /// <see href="http://schema.org/material"></see></summary>
    let material = _prefix "material"
    /// <summary>
    /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
    /// <see href="http://schema.org/artform"></see></summary>
    let artform = _prefix "artform"
    /// <summary>
    /// The actual body of the article.
    /// <see href="http://schema.org/articleBody"></see></summary>
    let articleBody = _prefix "articleBody"
    /// <summary>
    /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
    /// <see href="http://schema.org/articleSection"></see></summary>
    let articleSection = _prefix "articleSection"
    /// <summary>
    /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
    /// <see href="http://schema.org/artworkSurface"></see></summary>
    let artworkSurface = _prefix "artworkSurface"
    /// <summary>
    /// Library file name e.g., mscorlib.dll, system.web.dll.
    /// <see href="http://schema.org/assembly"></see></summary>
    let assembly = _prefix "assembly"
    /// <summary>
    /// Library file name e.g., mscorlib.dll, system.web.dll.
    /// <see href="http://schema.org/executableLibraryName"></see></summary>
    let executableLibraryName = _prefix "executableLibraryName"
    /// <summary>
    /// Associated product/technology version. e.g., .NET Framework 4.5.
    /// <see href="http://schema.org/assemblyVersion"></see></summary>
    let assemblyVersion = _prefix "assemblyVersion"
    /// <summary>
    /// A NewsArticle associated with the Media Object.
    /// <see href="http://schema.org/associatedArticle"></see></summary>
    let associatedArticle = _prefix "associatedArticle"
    /// <summary>
    /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
    /// <see href="http://schema.org/associatedMedia"></see></summary>
    let associatedMedia = _prefix "associatedMedia"
    /// <summary>
    /// A person that acts as performing member of a sports team; a player as opposed to a coach.
    /// <see href="http://schema.org/athlete"></see></summary>
    let athlete = _prefix "athlete"
    /// <summary>
    /// A person or organization attending the event.
    /// <see href="http://schema.org/attendee"></see></summary>
    let attendee = _prefix "attendee"
    /// <summary>
    /// A person attending the event.
    /// <see href="http://schema.org/attendees"></see></summary>
    let attendees = _prefix "attendees"
    /// <summary>
    /// An intended audience, i.e. a group for whom something was created.
    /// <see href="http://schema.org/audience"></see></summary>
    let audience = _prefix "audience"
    /// <summary>
    /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
    /// <see href="http://schema.org/audienceType"></see></summary>
    let audienceType = _prefix "audienceType"
    /// <summary>
    /// An embedded audio object.
    /// <see href="http://schema.org/audio"></see></summary>
    let audio = _prefix "audio"
    /// <summary>
    /// The Organization responsible for authenticating the user's subscription. For example, many media apps require a cable/satellite provider to authenticate your subscription before playing media.
    /// <see href="http://schema.org/authenticator"></see></summary>
    let authenticator = _prefix "authenticator"
    /// <summary>
    /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
    /// <see href="http://schema.org/author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.
    /// <see href="http://schema.org/availability"></see></summary>
    let availability = _prefix "availability"
    /// <summary>
    /// The end of the availability of the product or service included in the offer.
    /// <see href="http://schema.org/availabilityEnds"></see></summary>
    let availabilityEnds = _prefix "availabilityEnds"
    /// <summary>
    /// The beginning of the availability of the product or service included in the offer.
    /// <see href="http://schema.org/availabilityStarts"></see></summary>
    let availabilityStarts = _prefix "availabilityStarts"
    /// <summary>
    /// The place(s) from which the offer can be obtained (e.g. store locations).
    /// <see href="http://schema.org/availableAtOrFrom"></see></summary>
    let availableAtOrFrom = _prefix "availableAtOrFrom"
    /// <summary>
    /// A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
    /// <see href="http://schema.org/availableChannel"></see></summary>
    let availableChannel = _prefix "availableChannel"
    /// <summary>
    /// The delivery method(s) available for this offer.
    /// <see href="http://schema.org/availableDeliveryMethod"></see></summary>
    let availableDeliveryMethod = _prefix "availableDeliveryMethod"
    /// <summary>
    /// When the item is available for pickup from the store, locker, etc.
    /// <see href="http://schema.org/availableFrom"></see></summary>
    let availableFrom = _prefix "availableFrom"
    /// <summary>
    /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
    /// <see href="http://schema.org/availableLanguage"></see></summary>
    let availableLanguage = _prefix "availableLanguage"
    /// <summary>
    /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
    /// <see href="http://schema.org/availableOnDevice"></see></summary>
    let availableOnDevice = _prefix "availableOnDevice"
    /// <summary>
    /// After this date, the item will no longer be available for pickup.
    /// <see href="http://schema.org/availableThrough"></see></summary>
    let availableThrough = _prefix "availableThrough"
    /// <summary>
    /// An award won by or for this item.
    /// <see href="http://schema.org/award"></see></summary>
    let award = _prefix "award"
    /// <summary>
    /// Awards won by or for this item.
    /// <see href="http://schema.org/awards"></see></summary>
    let awards = _prefix "awards"
    /// <summary>
    /// The away team in a sports event.
    /// <see href="http://schema.org/awayTeam"></see></summary>
    let awayTeam = _prefix "awayTeam"
    /// <summary>
    /// A competitor in a sports event.
    /// <see href="http://schema.org/competitor"></see></summary>
    let competitor = _prefix "competitor"
    /// <summary>
    /// The base salary of the job or of an employee in an EmployeeRole.
    /// <see href="http://schema.org/baseSalary"></see></summary>
    let baseSalary = _prefix "baseSalary"
    /// <summary>
    /// A sub property of recipient. The recipient blind copied on a message.
    /// <see href="http://schema.org/bccRecipient"></see></summary>
    let bccRecipient = _prefix "bccRecipient"
    /// <summary>
    /// A sub property of participant. The participant who is at the receiving end of the action.
    /// <see href="http://schema.org/recipient"></see></summary>
    let recipient = _prefix "recipient"
    /// <summary>
    /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
    ///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.
    /// <see href="http://schema.org/bed"></see></summary>
    let bed = _prefix "bed"
    /// <summary>
    /// A media object representing the circumstances before performing this direction.
    /// <see href="http://schema.org/beforeMedia"></see></summary>
    let beforeMedia = _prefix "beforeMedia"
    /// <summary>
    /// Description of benefits associated with the job.
    /// <see href="http://schema.org/benefits"></see></summary>
    let benefits = _prefix "benefits"
    /// <summary>
    /// Description of benefits associated with the job.
    /// <see href="http://schema.org/jobBenefits"></see></summary>
    let jobBenefits = _prefix "jobBenefits"
    /// <summary>
    /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
    /// <see href="http://schema.org/bestRating"></see></summary>
    let bestRating = _prefix "bestRating"
    /// <summary>
    /// The billing address for the order.
    /// <see href="http://schema.org/billingAddress"></see></summary>
    let billingAddress = _prefix "billingAddress"
    /// <summary>
    /// This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.
    /// <see href="http://schema.org/billingIncrement"></see></summary>
    let billingIncrement = _prefix "billingIncrement"
    /// <summary>
    /// The time interval used to compute the invoice.
    /// <see href="http://schema.org/billingPeriod"></see></summary>
    let billingPeriod = _prefix "billingPeriod"
    /// <summary>
    /// Date of birth.
    /// <see href="http://schema.org/birthDate"></see></summary>
    let birthDate = _prefix "birthDate"
    /// <summary>
    /// The place where the person was born.
    /// <see href="http://schema.org/birthPlace"></see></summary>
    let birthPlace = _prefix "birthPlace"
    /// <summary>
    /// The bitrate of the media object.
    /// <see href="http://schema.org/bitrate"></see></summary>
    let bitrate = _prefix "bitrate"
    /// <summary>
    /// A posting that is part of this blog.
    /// <see href="http://schema.org/blogPost"></see></summary>
    let blogPost = _prefix "blogPost"
    /// <summary>
    /// The postings that are part of this blog.
    /// <see href="http://schema.org/blogPosts"></see></summary>
    let blogPosts = _prefix "blogPosts"
    /// <summary>
    /// The airline-specific indicator of boarding order / preference.
    /// <see href="http://schema.org/boardingGroup"></see></summary>
    let boardingGroup = _prefix "boardingGroup"
    /// <summary>
    /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
    /// <see href="http://schema.org/boardingPolicy"></see></summary>
    let boardingPolicy = _prefix "boardingPolicy"
    /// <summary>
    /// The edition of the book.
    /// <see href="http://schema.org/bookEdition"></see></summary>
    let bookEdition = _prefix "bookEdition"
    /// <summary>
    /// The format of the book.
    /// <see href="http://schema.org/bookFormat"></see></summary>
    let bookFormat = _prefix "bookFormat"
    /// <summary>
    /// 'bookingAgent' is an out-dated term indicating a 'broker' that serves as a booking agent.
    /// <see href="http://schema.org/bookingAgent"></see></summary>
    let bookingAgent = _prefix "bookingAgent"
    /// <summary>
    /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
    /// <see href="http://schema.org/broker"></see></summary>
    let broker = _prefix "broker"
    /// <summary>
    /// The date and time the reservation was booked.
    /// <see href="http://schema.org/bookingTime"></see></summary>
    let bookingTime = _prefix "bookingTime"
    /// <summary>
    /// A sub property of participant. The person that borrows the object being lent.
    /// <see href="http://schema.org/borrower"></see></summary>
    let borrower = _prefix "borrower"
    /// <summary>
    /// Other co-agents that participated in the action indirectly. e.g. John wrote a book with &lt;em&gt;Steve&lt;/em&gt;.
    /// <see href="http://schema.org/participant"></see></summary>
    let participant = _prefix "participant"
    /// <summary>
    /// A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.
    /// <see href="http://schema.org/box"></see></summary>
    let box = _prefix "box"
    /// <summary>
    /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
    ///
    /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
    /// <see href="http://schema.org/branchCode"></see></summary>
    let branchCode = _prefix "branchCode"
    /// <summary>
    /// The larger organization that this local business is a branch of, if any. Not to be confused with (anatomical)&lt;a class="localLink" href="http://schema.org/branch"&gt;branch&lt;/a&gt;.
    /// <see href="http://schema.org/branchOf"></see></summary>
    let branchOf = _prefix "branchOf"
    /// <summary>
    /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
    /// <see href="http://schema.org/parentOrganization"></see></summary>
    let parentOrganization = _prefix "parentOrganization"
    /// <summary>
    /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
    /// <see href="http://schema.org/brand"></see></summary>
    let brand = _prefix "brand"
    /// <summary>
    /// A set of links that can help a user understand and navigate a website hierarchy.
    /// <see href="http://schema.org/breadcrumb"></see></summary>
    let breadcrumb = _prefix "breadcrumb"
    /// <summary>
    /// The media network(s) whose content is broadcast on this station.
    /// <see href="http://schema.org/broadcastAffiliateOf"></see></summary>
    let broadcastAffiliateOf = _prefix "broadcastAffiliateOf"
    /// <summary>
    /// The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.
    /// <see href="http://schema.org/broadcastChannelId"></see></summary>
    let broadcastChannelId = _prefix "broadcastChannelId"
    /// <summary>
    /// The name displayed in the channel guide. For many US affiliates, it is the network name.
    /// <see href="http://schema.org/broadcastDisplayName"></see></summary>
    let broadcastDisplayName = _prefix "broadcastDisplayName"
    /// <summary>
    /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
    /// <see href="http://schema.org/broadcastFrequency"></see></summary>
    let broadcastFrequency = _prefix "broadcastFrequency"
    /// <summary>
    /// The frequency in MHz for a particular broadcast.
    /// <see href="http://schema.org/broadcastFrequencyValue"></see></summary>
    let broadcastFrequencyValue = _prefix "broadcastFrequencyValue"
    /// <summary>
    /// The event being broadcast such as a sporting event or awards ceremony.
    /// <see href="http://schema.org/broadcastOfEvent"></see></summary>
    let broadcastOfEvent = _prefix "broadcastOfEvent"
    /// <summary>
    /// The type of service required to have access to the channel (e.g. Standard or Premium).
    /// <see href="http://schema.org/broadcastServiceTier"></see></summary>
    let broadcastServiceTier = _prefix "broadcastServiceTier"
    /// <summary>
    /// The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts
    /// <see href="http://schema.org/broadcastTimezone"></see></summary>
    let broadcastTimezone = _prefix "broadcastTimezone"
    /// <summary>
    /// The organization owning or operating the broadcast service.
    /// <see href="http://schema.org/broadcaster"></see></summary>
    let broadcaster = _prefix "broadcaster"
    /// <summary>
    /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
    /// <see href="http://schema.org/browserRequirements"></see></summary>
    let browserRequirements = _prefix "browserRequirements"
    /// <summary>
    /// The name of the bus (e.g. Bolt Express).
    /// <see href="http://schema.org/busName"></see></summary>
    let busName = _prefix "busName"
    /// <summary>
    /// The unique identifier for the bus.
    /// <see href="http://schema.org/busNumber"></see></summary>
    let busNumber = _prefix "busNumber"
    /// <summary>
    /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
    /// <see href="http://schema.org/businessFunction"></see></summary>
    let businessFunction = _prefix "businessFunction"
    /// <summary>
    /// A sub property of participant. The participant/person/organization that bought the object.
    /// <see href="http://schema.org/buyer"></see></summary>
    let buyer = _prefix "buyer"
    /// <summary>
    /// The artist that performed this album or recording.
    /// <see href="http://schema.org/byArtist"></see></summary>
    let byArtist = _prefix "byArtist"
    /// <summary>
    /// The number of calories.
    /// <see href="http://schema.org/calories"></see></summary>
    let calories = _prefix "calories"
    /// <summary>
    /// A sub property of object. The candidate subject of this action.
    /// <see href="http://schema.org/candidate"></see></summary>
    let candidate = _prefix "candidate"
    /// <summary>
    /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
    /// <see href="http://schema.org/caption"></see></summary>
    let caption = _prefix "caption"
    /// <summary>
    /// The number of grams of carbohydrates.
    /// <see href="http://schema.org/carbohydrateContent"></see></summary>
    let carbohydrateContent = _prefix "carbohydrateContent"
    /// <summary>
    /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
    /// <see href="http://schema.org/cargoVolume"></see></summary>
    let cargoVolume = _prefix "cargoVolume"
    /// <summary>
    /// 'carrier' is an out-dated term indicating the 'provider' for parcel delivery and flights.
    /// <see href="http://schema.org/carrier"></see></summary>
    let carrier = _prefix "carrier"
    /// <summary>
    /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
    /// <see href="http://schema.org/provider"></see></summary>
    let provider = _prefix "provider"
    /// <summary>
    /// Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).
    /// <see href="http://schema.org/carrierRequirements"></see></summary>
    let carrierRequirements = _prefix "carrierRequirements"
    /// <summary>
    /// A data catalog which contains this dataset.
    /// <see href="http://schema.org/catalog"></see></summary>
    let catalog = _prefix "catalog"
    /// <summary>
    /// A data catalog which contains this dataset.
    /// <see href="http://schema.org/includedInDataCatalog"></see></summary>
    let includedInDataCatalog = _prefix "includedInDataCatalog"
    /// <summary>
    /// The catalog number for the release.
    /// <see href="http://schema.org/catalogNumber"></see></summary>
    let catalogNumber = _prefix "catalogNumber"
    /// <summary>
    ///   <see href="http://schema.org/SpecialAnnouncement"></see>
    /// </summary>
    let SpecialAnnouncement = _prefix "SpecialAnnouncement"
    /// <summary>
    ///   <see href="http://schema.org/PhysicalActivity"></see>
    /// </summary>
    let PhysicalActivity = _prefix "PhysicalActivity"
    /// <summary>
    ///   <see href="http://schema.org/Recommendation"></see>
    /// </summary>
    let Recommendation = _prefix "Recommendation"
    /// <summary>
    ///   <see href="http://schema.org/PhysicalActivityCategory"></see>
    /// </summary>
    let PhysicalActivityCategory = _prefix "PhysicalActivityCategory"
    /// <summary>
    /// A sub property of recipient. The recipient copied on a message.
    /// <see href="http://schema.org/ccRecipient"></see></summary>
    let ccRecipient = _prefix "ccRecipient"
    /// <summary>
    /// Fictional person connected with a creative work.
    /// <see href="http://schema.org/character"></see></summary>
    let character = _prefix "character"
    /// <summary>
    /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
    /// <see href="http://schema.org/characterAttribute"></see></summary>
    let characterAttribute = _prefix "characterAttribute"
    /// <summary>
    /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
    /// <see href="http://schema.org/characterName"></see></summary>
    let characterName = _prefix "characterName"
    /// <summary>
    /// Cheat codes to the game.
    /// <see href="http://schema.org/cheatCode"></see></summary>
    let cheatCode = _prefix "cheatCode"
    /// <summary>
    /// The earliest someone may check into a lodging establishment.
    /// <see href="http://schema.org/checkinTime"></see></summary>
    let checkinTime = _prefix "checkinTime"
    /// <summary>
    /// The latest someone may check out of a lodging establishment.
    /// <see href="http://schema.org/checkoutTime"></see></summary>
    let checkoutTime = _prefix "checkoutTime"
    /// <summary>
    /// Maximal age of the child.
    /// <see href="http://schema.org/childMaxAge"></see></summary>
    let childMaxAge = _prefix "childMaxAge"
    /// <summary>
    /// Minimal age of the child.
    /// <see href="http://schema.org/childMinAge"></see></summary>
    let childMinAge = _prefix "childMinAge"
    /// <summary>
    /// A child of the person.
    /// <see href="http://schema.org/children"></see></summary>
    let children = _prefix "children"
    /// <summary>
    /// The number of milligrams of cholesterol.
    /// <see href="http://schema.org/cholesterolContent"></see></summary>
    let cholesterolContent = _prefix "cholesterolContent"
    /// <summary>
    /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
    /// <see href="http://schema.org/circle"></see></summary>
    let circle = _prefix "circle"
    /// <summary>
    /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
    /// <see href="http://schema.org/citation"></see></summary>
    let citation = _prefix "citation"
    /// <summary>
    /// A short summary of the specific claims reviewed in a ClaimReview.
    /// <see href="http://schema.org/claimReviewed"></see></summary>
    let claimReviewed = _prefix "claimReviewed"
    /// <summary>
    /// Position of the clip within an ordered group of clips.
    /// <see href="http://schema.org/clipNumber"></see></summary>
    let clipNumber = _prefix "clipNumber"
    /// <summary>
    /// The position of an item in a series or sequence of items.
    /// <see href="http://schema.org/position"></see></summary>
    let position = _prefix "position"
    /// <summary>
    /// The closing hour of the place or service on the given day(s) of the week.
    /// <see href="http://schema.org/closes"></see></summary>
    let closes = _prefix "closes"
    /// <summary>
    /// A person that acts in a coaching role for a sports team.
    /// <see href="http://schema.org/coach"></see></summary>
    let coach = _prefix "coach"
    /// <summary>
    /// Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex).
    /// <see href="http://schema.org/codeRepository"></see></summary>
    let codeRepository = _prefix "codeRepository"
    /// <summary>
    /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
    /// <see href="http://schema.org/codeSampleType"></see></summary>
    let codeSampleType = _prefix "codeSampleType"
    /// <summary>
    /// A colleague of the person.
    /// <see href="http://schema.org/colleague"></see></summary>
    let colleague = _prefix "colleague"
    /// <summary>
    /// A colleague of the person.
    /// <see href="http://schema.org/colleagues"></see></summary>
    let colleagues = _prefix "colleagues"
    /// <summary>
    /// A sub property of object. The collection target of the action.
    /// <see href="http://schema.org/collection"></see></summary>
    let collection = _prefix "collection"
    /// <summary>
    /// A sub property of object. The collection target of the action.
    /// <see href="http://schema.org/targetCollection"></see></summary>
    let targetCollection = _prefix "targetCollection"
    /// <summary>
    /// The color of the product.
    /// <see href="http://schema.org/color"></see></summary>
    let color = _prefix "color"
    /// <summary>
    /// Comments, typically from users.
    /// <see href="http://schema.org/comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
    /// <see href="http://schema.org/commentCount"></see></summary>
    let commentCount = _prefix "commentCount"
    /// <summary>
    /// The text of the UserComment.
    /// <see href="http://schema.org/commentText"></see></summary>
    let commentText = _prefix "commentText"
    /// <summary>
    /// The time at which the UserComment was made.
    /// <see href="http://schema.org/commentTime"></see></summary>
    let commentTime = _prefix "commentTime"
    /// <summary>
    /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
    /// <see href="http://schema.org/composer"></see></summary>
    let composer = _prefix "composer"
    /// <summary>
    /// A number that confirms the given order or payment has been received.
    /// <see href="http://schema.org/confirmationNumber"></see></summary>
    let confirmationNumber = _prefix "confirmationNumber"
    /// <summary>
    /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
    /// <see href="http://schema.org/contactOption"></see></summary>
    let contactOption = _prefix "contactOption"
    /// <summary>
    /// A contact point for a person or organization.
    /// <see href="http://schema.org/contactPoint"></see></summary>
    let contactPoint = _prefix "contactPoint"
    /// <summary>
    ///   <see href="http://schema.org/HealthInsurancePlan"></see>
    /// </summary>
    let HealthInsurancePlan = _prefix "HealthInsurancePlan"
    /// <summary>
    /// A contact point for a person or organization.
    /// <see href="http://schema.org/contactPoints"></see></summary>
    let contactPoints = _prefix "contactPoints"
    /// <summary>
    /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
    /// <see href="http://schema.org/contactType"></see></summary>
    let contactType = _prefix "contactType"
    /// <summary>
    /// The basic containment relation between a place and one that contains it.
    /// <see href="http://schema.org/containedIn"></see></summary>
    let containedIn = _prefix "containedIn"
    /// <summary>
    /// The basic containment relation between a place and one that contains it.
    /// <see href="http://schema.org/containedInPlace"></see></summary>
    let containedInPlace = _prefix "containedInPlace"
    /// <summary>
    /// The basic containment relation between a place and another that it contains.
    /// <see href="http://schema.org/containsPlace"></see></summary>
    let containsPlace = _prefix "containsPlace"
    /// <summary>
    /// A season that is part of the media series.
    /// <see href="http://schema.org/containsSeason"></see></summary>
    let containsSeason = _prefix "containsSeason"
    /// <summary>
    /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).
    /// <see href="http://schema.org/hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// The location depicted or described in the content. For example, the location in a photograph or painting.
    /// <see href="http://schema.org/contentLocation"></see></summary>
    let contentLocation = _prefix "contentLocation"
    /// <summary>
    /// Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.
    /// <see href="http://schema.org/contentRating"></see></summary>
    let contentRating = _prefix "contentRating"
    /// <summary>
    /// File size in (mega/kilo) bytes.
    /// <see href="http://schema.org/contentSize"></see></summary>
    let contentSize = _prefix "contentSize"
    /// <summary>
    /// The supported content type(s) for an EntryPoint response.
    /// <see href="http://schema.org/contentType"></see></summary>
    let contentType = _prefix "contentType"
    /// <summary>
    /// Actual bytes of the media object, for example the image file or video file.
    /// <see href="http://schema.org/contentUrl"></see></summary>
    let contentUrl = _prefix "contentUrl"
    /// <summary>
    /// A secondary contributor to the CreativeWork or Event.
    /// <see href="http://schema.org/contributor"></see></summary>
    let contributor = _prefix "contributor"
    /// <summary>
    /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
    /// <see href="http://schema.org/cookTime"></see></summary>
    let cookTime = _prefix "cookTime"
    /// <summary>
    /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
    /// <see href="http://schema.org/performTime"></see></summary>
    let performTime = _prefix "performTime"
    /// <summary>
    /// The method of cooking, such as Frying, Steaming, ...
    /// <see href="http://schema.org/cookingMethod"></see></summary>
    let cookingMethod = _prefix "cookingMethod"
    /// <summary>
    /// The party holding the legal copyright to the CreativeWork.
    /// <see href="http://schema.org/copyrightHolder"></see></summary>
    let copyrightHolder = _prefix "copyrightHolder"
    /// <summary>
    /// The year during which the claimed copyright for the CreativeWork was first asserted.
    /// <see href="http://schema.org/copyrightYear"></see></summary>
    let copyrightYear = _prefix "copyrightYear"
    /// <summary>
    /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    /// <see href="http://schema.org/countriesNotSupported"></see></summary>
    let countriesNotSupported = _prefix "countriesNotSupported"
    /// <summary>
    /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    /// <see href="http://schema.org/countriesSupported"></see></summary>
    let countriesSupported = _prefix "countriesSupported"
    /// <summary>
    /// The country of the principal offices of the production company or individual responsible for the movie or program.
    /// <see href="http://schema.org/countryOfOrigin"></see></summary>
    let countryOfOrigin = _prefix "countryOfOrigin"
    /// <summary>
    /// A sub property of location. The course where this action was taken.
    /// <see href="http://schema.org/course"></see></summary>
    let course = _prefix "course"
    /// <summary>
    /// A sub property of location. The course where this action was taken.
    /// <see href="http://schema.org/exerciseCourse"></see></summary>
    let exerciseCourse = _prefix "exerciseCourse"
    /// <summary>
    /// The location of for example where the event is happening, an organization is located, or where an action takes place.
    /// <see href="http://schema.org/location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// The identifier for the &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; used by the course &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; (e.g. CS101 or 6.001).
    /// <see href="http://schema.org/courseCode"></see></summary>
    let courseCode = _prefix "courseCode"
    /// <summary>
    /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
    /// <see href="http://schema.org/courseMode"></see></summary>
    let courseMode = _prefix "courseMode"
    /// <summary>
    /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
    /// <see href="http://schema.org/coursePrerequisites"></see></summary>
    let coursePrerequisites = _prefix "coursePrerequisites"
    /// <summary>
    /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
    /// <see href="http://schema.org/coverageEndTime"></see></summary>
    let coverageEndTime = _prefix "coverageEndTime"
    /// <summary>
    /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
    /// <see href="http://schema.org/coverageStartTime"></see></summary>
    let coverageStartTime = _prefix "coverageStartTime"
    /// <summary>
    /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
    /// <see href="http://schema.org/creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
    /// <see href="http://schema.org/creditedTo"></see></summary>
    let creditedTo = _prefix "creditedTo"
    /// <summary>
    /// A CSS selector, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
    /// <see href="http://schema.org/cssSelector"></see></summary>
    let cssSelector = _prefix "cssSelector"
    /// <summary>
    ///   <see href="http://schema.org/CssSelectorType"></see>
    /// </summary>
    let CssSelectorType = _prefix "CssSelectorType"
    /// <summary>
    /// The currency accepted.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
    /// <see href="http://schema.org/currenciesAccepted"></see></summary>
    let currenciesAccepted = _prefix "currenciesAccepted"
    /// <summary>
    /// The currency in which the monetary amount is expressed.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
    /// <see href="http://schema.org/currency"></see></summary>
    let currency = _prefix "currency"
    /// <summary>
    ///   <see href="http://schema.org/ExchangeRateSpecification"></see>
    /// </summary>
    let ExchangeRateSpecification = _prefix "ExchangeRateSpecification"
    /// <summary>
    /// Party placing the order or paying the invoice.
    /// <see href="http://schema.org/customer"></see></summary>
    let customer = _prefix "customer"
    /// <summary>
    /// An item within in a data feed. Data feeds may have many elements.
    /// <see href="http://schema.org/dataFeedElement"></see></summary>
    let dataFeedElement = _prefix "dataFeedElement"
    /// <summary>
    /// A dataset contained in this catalog.
    /// <see href="http://schema.org/dataset"></see></summary>
    let dataset = _prefix "dataset"
    /// <summary>
    /// The range of temporal applicability of a dataset, e.g. for a 2011 census dataset, the year 2011 (in ISO 8601 time interval format).
    /// <see href="http://schema.org/datasetTimeInterval"></see></summary>
    let datasetTimeInterval = _prefix "datasetTimeInterval"
    /// <summary>
    /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
    ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
    ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".&lt;br/&gt;&lt;br/&gt;
    ///
    /// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated.
    /// <see href="http://schema.org/temporalCoverage"></see></summary>
    let temporalCoverage = _prefix "temporalCoverage"
    /// <summary>
    /// The date on which the CreativeWork was created or the item was added to a DataFeed.
    /// <see href="http://schema.org/dateCreated"></see></summary>
    let dateCreated = _prefix "dateCreated"
    /// <summary>
    /// The datetime the item was removed from the DataFeed.
    /// <see href="http://schema.org/dateDeleted"></see></summary>
    let dateDeleted = _prefix "dateDeleted"
    /// <summary>
    /// The date the ticket was issued.
    /// <see href="http://schema.org/dateIssued"></see></summary>
    let dateIssued = _prefix "dateIssued"
    /// <summary>
    /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
    /// <see href="http://schema.org/dateModified"></see></summary>
    let dateModified = _prefix "dateModified"
    /// <summary>
    /// Publication date of an online listing.
    /// <see href="http://schema.org/datePosted"></see></summary>
    let datePosted = _prefix "datePosted"
    /// <summary>
    ///   <see href="http://schema.org/RealEstateListing"></see>
    /// </summary>
    let RealEstateListing = _prefix "RealEstateListing"
    /// <summary>
    /// Date of first broadcast/publication.
    /// <see href="http://schema.org/datePublished"></see></summary>
    let datePublished = _prefix "datePublished"
    /// <summary>
    /// The date/time at which the message has been read by the recipient if a single recipient exists.
    /// <see href="http://schema.org/dateRead"></see></summary>
    let dateRead = _prefix "dateRead"
    /// <summary>
    /// The date/time the message was received if a single recipient exists.
    /// <see href="http://schema.org/dateReceived"></see></summary>
    let dateReceived = _prefix "dateReceived"
    /// <summary>
    /// The date/time at which the message was sent.
    /// <see href="http://schema.org/dateSent"></see></summary>
    let dateSent = _prefix "dateSent"
    /// <summary>
    /// The date of the first registration of the vehicle with the respective public authorities.
    /// <see href="http://schema.org/dateVehicleFirstRegistered"></see></summary>
    let dateVehicleFirstRegistered = _prefix "dateVehicleFirstRegistered"
    /// <summary>
    /// A &lt;a href="https://en.wikipedia.org/wiki/Dateline"&gt;dateline&lt;/a&gt; is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Structured representations of dateline-related information can also be expressed more explicitly using &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt; (which represents where a work was created e.g. where a news report was written).  For location depicted or described in the content, use &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Dateline summaries are oriented more towards human readers than towards automated processing, and can vary substantially. Some examples: "BEIRUT, Lebanon, June 2.", "Paris, France", "December 19, 2017 11:43AM Reporting from Washington", "Beijing/Moscow", "QUEZON CITY, Philippines".
    /// <see href="http://schema.org/dateline"></see></summary>
    let dateline = _prefix "dateline"
    /// <summary>
    /// The day of the week for which these opening hours are valid.
    /// <see href="http://schema.org/dayOfWeek"></see></summary>
    let dayOfWeek = _prefix "dayOfWeek"
    /// <summary>
    ///   <see href="http://schema.org/EducationalOccupationalProgram"></see>
    /// </summary>
    let EducationalOccupationalProgram = _prefix "EducationalOccupationalProgram"
    /// <summary>
    /// Date of death.
    /// <see href="http://schema.org/deathDate"></see></summary>
    let deathDate = _prefix "deathDate"
    /// <summary>
    /// The place where the person died.
    /// <see href="http://schema.org/deathPlace"></see></summary>
    let deathPlace = _prefix "deathPlace"
    /// <summary>
    /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
    /// <see href="http://schema.org/defaultValue"></see></summary>
    let defaultValue = _prefix "defaultValue"
    /// <summary>
    /// Destination address.
    /// <see href="http://schema.org/deliveryAddress"></see></summary>
    let deliveryAddress = _prefix "deliveryAddress"
    /// <summary>
    /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
    /// <see href="http://schema.org/deliveryLeadTime"></see></summary>
    let deliveryLeadTime = _prefix "deliveryLeadTime"
    /// <summary>
    /// A sub property of instrument. The method of delivery.
    /// <see href="http://schema.org/deliveryMethod"></see></summary>
    let deliveryMethod = _prefix "deliveryMethod"
    /// <summary>
    /// The object that helped the agent perform the action. e.g. John wrote a book with &lt;em&gt;a pen&lt;/em&gt;.
    /// <see href="http://schema.org/instrument"></see></summary>
    let instrument = _prefix "instrument"
    /// <summary>
    /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
    /// <see href="http://schema.org/deliveryStatus"></see></summary>
    let deliveryStatus = _prefix "deliveryStatus"
    /// <summary>
    /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
    /// <see href="http://schema.org/department"></see></summary>
    let department = _prefix "department"
    /// <summary>
    /// The airport where the flight originates.
    /// <see href="http://schema.org/departureAirport"></see></summary>
    let departureAirport = _prefix "departureAirport"
    /// <summary>
    /// The stop or station from which the bus departs.
    /// <see href="http://schema.org/departureBusStop"></see></summary>
    let departureBusStop = _prefix "departureBusStop"
    /// <summary>
    /// Identifier of the flight's departure gate.
    /// <see href="http://schema.org/departureGate"></see></summary>
    let departureGate = _prefix "departureGate"
    /// <summary>
    /// The platform from which the train departs.
    /// <see href="http://schema.org/departurePlatform"></see></summary>
    let departurePlatform = _prefix "departurePlatform"
    /// <summary>
    /// The station from which the train departs.
    /// <see href="http://schema.org/departureStation"></see></summary>
    let departureStation = _prefix "departureStation"
    /// <summary>
    /// Identifier of the flight's departure terminal.
    /// <see href="http://schema.org/departureTerminal"></see></summary>
    let departureTerminal = _prefix "departureTerminal"
    /// <summary>
    /// The expected departure time.
    /// <see href="http://schema.org/departureTime"></see></summary>
    let departureTime = _prefix "departureTime"
    /// <summary>
    /// Prerequisites needed to fulfill steps in article.
    /// <see href="http://schema.org/dependencies"></see></summary>
    let dependencies = _prefix "dependencies"
    /// <summary>
    /// The depth of the item.
    /// <see href="http://schema.org/depth"></see></summary>
    let depth = _prefix "depth"
    /// <summary>
    /// A description of the item.
    /// <see href="http://schema.org/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
    /// <see href="http://schema.org/device"></see></summary>
    let device = _prefix "device"
    /// <summary>
    /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
    /// <see href="http://schema.org/director"></see></summary>
    let director = _prefix "director"
    /// <summary>
    /// A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip.
    /// <see href="http://schema.org/directors"></see></summary>
    let directors = _prefix "directors"
    /// <summary>
    /// A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
    /// <see href="http://schema.org/disambiguatingDescription"></see></summary>
    let disambiguatingDescription = _prefix "disambiguatingDescription"
    /// <summary>
    /// Any discount applied (to an Order).
    /// <see href="http://schema.org/discount"></see></summary>
    let discount = _prefix "discount"
    /// <summary>
    /// Code used to redeem a discount.
    /// <see href="http://schema.org/discountCode"></see></summary>
    let discountCode = _prefix "discountCode"
    /// <summary>
    /// The currency of the discount.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
    /// <see href="http://schema.org/discountCurrency"></see></summary>
    let discountCurrency = _prefix "discountCurrency"
    /// <summary>
    /// Specifies the CreativeWork associated with the UserComment.
    /// <see href="http://schema.org/discusses"></see></summary>
    let discusses = _prefix "discusses"
    /// <summary>
    /// A link to the page containing the comments of the CreativeWork.
    /// <see href="http://schema.org/discussionUrl"></see></summary>
    let discussionUrl = _prefix "discussionUrl"
    /// <summary>
    /// The date that this organization was dissolved.
    /// <see href="http://schema.org/dissolutionDate"></see></summary>
    let dissolutionDate = _prefix "dissolutionDate"
    /// <summary>
    /// The distance travelled, e.g. exercising or travelling.
    /// <see href="http://schema.org/distance"></see></summary>
    let distance = _prefix "distance"
    /// <summary>
    /// A downloadable form of this dataset, at a specific location, in a specific format.
    /// <see href="http://schema.org/distribution"></see></summary>
    let distribution = _prefix "distribution"
    /// <summary>
    /// The time admission will commence.
    /// <see href="http://schema.org/doorTime"></see></summary>
    let doorTime = _prefix "doorTime"
    /// <summary>
    /// If the file can be downloaded, URL to download the binary.
    /// <see href="http://schema.org/downloadUrl"></see></summary>
    let downloadUrl = _prefix "downloadUrl"
    /// <summary>
    /// The number of downvotes this question, answer or comment has received from the community.
    /// <see href="http://schema.org/downvoteCount"></see></summary>
    let downvoteCount = _prefix "downvoteCount"
    /// <summary>
    /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
    /// <see href="http://schema.org/driveWheelConfiguration"></see></summary>
    let driveWheelConfiguration = _prefix "driveWheelConfiguration"
    /// <summary>
    /// Where a rental car can be dropped off.
    /// <see href="http://schema.org/dropoffLocation"></see></summary>
    let dropoffLocation = _prefix "dropoffLocation"
    /// <summary>
    /// When a rental car can be dropped off.
    /// <see href="http://schema.org/dropoffTime"></see></summary>
    let dropoffTime = _prefix "dropoffTime"
    /// <summary>
    /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
    /// <see href="http://schema.org/duns"></see></summary>
    let duns = _prefix "duns"
    /// <summary>
    /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
    /// <see href="http://schema.org/duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    ///   <see href="http://schema.org/Audiobook"></see>
    /// </summary>
    let Audiobook = _prefix "Audiobook"
    /// <summary>
    ///   <see href="http://schema.org/Schedule"></see>
    /// </summary>
    let Schedule = _prefix "Schedule"
    /// <summary>
    /// The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.
    /// <see href="http://schema.org/durationOfWarranty"></see></summary>
    let durationOfWarranty = _prefix "durationOfWarranty"
    /// <summary>
    /// A media object representing the circumstances while performing this direction.
    /// <see href="http://schema.org/duringMedia"></see></summary>
    let duringMedia = _prefix "duringMedia"
    /// <summary>
    /// Specifies the Person who edited the CreativeWork.
    /// <see href="http://schema.org/editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    /// An alignment to an established educational framework.
    /// <see href="http://schema.org/educationalAlignment"></see></summary>
    let educationalAlignment = _prefix "educationalAlignment"
    /// <summary>
    /// A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course or program.
    /// <see href="http://schema.org/educationalCredentialAwarded"></see></summary>
    let educationalCredentialAwarded = _prefix "educationalCredentialAwarded"
    /// <summary>
    ///   <see href="http://schema.org/EducationalOccupationalCredential"></see>
    /// </summary>
    let EducationalOccupationalCredential = _prefix "EducationalOccupationalCredential"
    /// <summary>
    /// The framework to which the resource being described is aligned.
    /// <see href="http://schema.org/educationalFramework"></see></summary>
    let educationalFramework = _prefix "educationalFramework"
    /// <summary>
    /// An educationalRole of an EducationalAudience.
    /// <see href="http://schema.org/educationalRole"></see></summary>
    let educationalRole = _prefix "educationalRole"
    /// <summary>
    /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
    /// <see href="http://schema.org/educationalUse"></see></summary>
    let educationalUse = _prefix "educationalUse"
    /// <summary>
    /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
    /// <see href="http://schema.org/elevation"></see></summary>
    let elevation = _prefix "elevation"
    /// <summary>
    /// The type(s) of customers for which the given offer is valid.
    /// <see href="http://schema.org/eligibleCustomerType"></see></summary>
    let eligibleCustomerType = _prefix "eligibleCustomerType"
    /// <summary>
    /// The duration for which the given offer is valid.
    /// <see href="http://schema.org/eligibleDuration"></see></summary>
    let eligibleDuration = _prefix "eligibleDuration"
    /// <summary>
    /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
    /// <see href="http://schema.org/eligibleQuantity"></see></summary>
    let eligibleQuantity = _prefix "eligibleQuantity"
    /// <summary>
    /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
    /// <see href="http://schema.org/eligibleRegion"></see></summary>
    let eligibleRegion = _prefix "eligibleRegion"
    /// <summary>
    /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
    /// <see href="http://schema.org/eligibleTransactionVolume"></see></summary>
    let eligibleTransactionVolume = _prefix "eligibleTransactionVolume"
    /// <summary>
    /// Email address.
    /// <see href="http://schema.org/email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.
    /// <see href="http://schema.org/embedUrl"></see></summary>
    let embedUrl = _prefix "embedUrl"
    /// <summary>
    /// Someone working for this organization.
    /// <see href="http://schema.org/employee"></see></summary>
    let employee = _prefix "employee"
    /// <summary>
    /// People working for this organization.
    /// <see href="http://schema.org/employees"></see></summary>
    let employees = _prefix "employees"
    /// <summary>
    /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
    /// <see href="http://schema.org/employmentType"></see></summary>
    let employmentType = _prefix "employmentType"
    /// <summary>
    /// The CreativeWork encoded by this media object.
    /// <see href="http://schema.org/encodesCreativeWork"></see></summary>
    let encodesCreativeWork = _prefix "encodesCreativeWork"
    /// <summary>
    /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
    /// <see href="http://schema.org/encoding"></see></summary>
    let encoding = _prefix "encoding"
    /// <summary>
    /// Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
    ///
    /// In cases where a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="http://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="http://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
    /// <see href="http://schema.org/encodingFormat"></see></summary>
    let encodingFormat = _prefix "encodingFormat"
    /// <summary>
    /// The supported encoding type(s) for an EntryPoint request.
    /// <see href="http://schema.org/encodingType"></see></summary>
    let encodingType = _prefix "encodingType"
    /// <summary>
    /// A media object that encodes this CreativeWork.
    /// <see href="http://schema.org/encodings"></see></summary>
    let encodings = _prefix "encodings"
    /// <summary>
    /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
    /// <see href="http://schema.org/endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
    /// <see href="http://schema.org/endTime"></see></summary>
    let endTime = _prefix "endTime"
    /// <summary>
    /// A sub property of participant. The person/organization being supported.
    /// <see href="http://schema.org/endorsee"></see></summary>
    let endorsee = _prefix "endorsee"
    /// <summary>
    /// A sub property of location. The entertainment business where the action occurred.
    /// <see href="http://schema.org/entertainmentBusiness"></see></summary>
    let entertainmentBusiness = _prefix "entertainmentBusiness"
    /// <summary>
    /// An episode of a tv, radio or game media within a series or season.
    /// <see href="http://schema.org/episode"></see></summary>
    let episode = _prefix "episode"
    /// <summary>
    /// Position of the episode within an ordered group of episodes.
    /// <see href="http://schema.org/episodeNumber"></see></summary>
    let episodeNumber = _prefix "episodeNumber"
    /// <summary>
    /// An episode of a TV/radio series or season.
    /// <see href="http://schema.org/episodes"></see></summary>
    let episodes = _prefix "episodes"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is equal to the object.
    /// <see href="http://schema.org/equal"></see></summary>
    let equal = _prefix "equal"
    /// <summary>
    /// For failed actions, more information on the cause of the failure.
    /// <see href="http://schema.org/error"></see></summary>
    let error = _prefix "error"
    /// <summary>
    /// The estimated cost of the supply or supplies consumed when performing instructions.
    /// <see href="http://schema.org/estimatedCost"></see></summary>
    let estimatedCost = _prefix "estimatedCost"
    /// <summary>
    /// The estimated time the flight will take.
    /// <see href="http://schema.org/estimatedFlightDuration"></see></summary>
    let estimatedFlightDuration = _prefix "estimatedFlightDuration"
    /// <summary>
    /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
    /// <see href="http://schema.org/estimatedSalary"></see></summary>
    let estimatedSalary = _prefix "estimatedSalary"
    /// <summary>
    /// Upcoming or past event associated with this place, organization, or action.
    /// <see href="http://schema.org/event"></see></summary>
    let event_ = _prefix "event"
    /// <summary>
    /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
    /// <see href="http://schema.org/eventStatus"></see></summary>
    let eventStatus = _prefix "eventStatus"
    /// <summary>
    /// Upcoming or past events associated with this place or organization.
    /// <see href="http://schema.org/events"></see></summary>
    let events = _prefix "events"
    /// <summary>
    /// A creative work that this work is an example/instance/realization/derivation of.
    /// <see href="http://schema.org/exampleOfWork"></see></summary>
    let exampleOfWork = _prefix "exampleOfWork"
    /// <summary>
    /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
    /// <see href="http://schema.org/workExample"></see></summary>
    let workExample = _prefix "workExample"
    /// <summary>
    /// exif data for this object.
    /// <see href="http://schema.org/exifData"></see></summary>
    let exifData = _prefix "exifData"
    /// <summary>
    /// The earliest date the package may arrive.
    /// <see href="http://schema.org/expectedArrivalFrom"></see></summary>
    let expectedArrivalFrom = _prefix "expectedArrivalFrom"
    /// <summary>
    /// The latest date the package may arrive.
    /// <see href="http://schema.org/expectedArrivalUntil"></see></summary>
    let expectedArrivalUntil = _prefix "expectedArrivalUntil"
    /// <summary>
    /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
    /// <see href="http://schema.org/expectsAcceptanceOf"></see></summary>
    let expectsAcceptanceOf = _prefix "expectsAcceptanceOf"
    /// <summary>
    /// Description of skills and experience needed for the position or Occupation.
    /// <see href="http://schema.org/experienceRequirements"></see></summary>
    let experienceRequirements = _prefix "experienceRequirements"
    /// <summary>
    /// Date the content expires and is no longer useful or available. For example a &lt;a class="localLink" href="http://schema.org/VideoObject"&gt;VideoObject&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt; whose availability or relevance is time-limited, or a &lt;a class="localLink" href="http://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt; fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
    /// <see href="http://schema.org/expires"></see></summary>
    let expires = _prefix "expires"
    /// <summary>
    /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
    /// <see href="http://schema.org/familyName"></see></summary>
    let familyName = _prefix "familyName"
    /// <summary>
    /// The number of grams of fat.
    /// <see href="http://schema.org/fatContent"></see></summary>
    let fatContent = _prefix "fatContent"
    /// <summary>
    /// The fax number.
    /// <see href="http://schema.org/faxNumber"></see></summary>
    let faxNumber = _prefix "faxNumber"
    /// <summary>
    /// Features or modules provided by this application (and possibly required by other applications).
    /// <see href="http://schema.org/featureList"></see></summary>
    let featureList = _prefix "featureList"
    /// <summary>
    /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
    /// <see href="http://schema.org/feesAndCommissionsSpecification"></see></summary>
    let feesAndCommissionsSpecification = _prefix "feesAndCommissionsSpecification"
    /// <summary>
    /// The number of grams of fiber.
    /// <see href="http://schema.org/fiberContent"></see></summary>
    let fiberContent = _prefix "fiberContent"
    /// <summary>
    /// Media type, typically MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt;) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.
    /// <see href="http://schema.org/fileFormat"></see></summary>
    let fileFormat = _prefix "fileFormat"
    /// <summary>
    /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
    /// <see href="http://schema.org/fileSize"></see></summary>
    let fileSize = _prefix "fileSize"
    /// <summary>
    /// The date and place the work was first performed.
    /// <see href="http://schema.org/firstPerformance"></see></summary>
    let firstPerformance = _prefix "firstPerformance"
    /// <summary>
    /// The distance of the flight.
    /// <see href="http://schema.org/flightDistance"></see></summary>
    let flightDistance = _prefix "flightDistance"
    /// <summary>
    /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
    /// <see href="http://schema.org/flightNumber"></see></summary>
    let flightNumber = _prefix "flightNumber"
    /// <summary>
    /// The size of the accommodation, e.g. in square meter or squarefoot.
    /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
    /// <see href="http://schema.org/floorSize"></see></summary>
    let floorSize = _prefix "floorSize"
    /// <summary>
    /// A sub property of object. The person or organization being followed.
    /// <see href="http://schema.org/followee"></see></summary>
    let followee = _prefix "followee"
    /// <summary>
    /// The most generic uni-directional social relation.
    /// <see href="http://schema.org/follows"></see></summary>
    let follows = _prefix "follows"
    /// <summary>
    /// A sub property of location. The specific food establishment where the action occurred.
    /// <see href="http://schema.org/foodEstablishment"></see></summary>
    let foodEstablishment = _prefix "foodEstablishment"
    /// <summary>
    /// A sub property of location. The specific food event where the action occurred.
    /// <see href="http://schema.org/foodEvent"></see></summary>
    let foodEvent = _prefix "foodEvent"
    /// <summary>
    /// A person who founded this organization.
    /// <see href="http://schema.org/founder"></see></summary>
    let founder = _prefix "founder"
    /// <summary>
    /// A person who founded this organization.
    /// <see href="http://schema.org/founders"></see></summary>
    let founders = _prefix "founders"
    /// <summary>
    /// The date that this organization was founded.
    /// <see href="http://schema.org/foundingDate"></see></summary>
    let foundingDate = _prefix "foundingDate"
    /// <summary>
    /// The place where the Organization was founded.
    /// <see href="http://schema.org/foundingLocation"></see></summary>
    let foundingLocation = _prefix "foundingLocation"
    /// <summary>
    /// A flag to signal that the item, event, or place is accessible for free.
    /// <see href="http://schema.org/free"></see></summary>
    let free = _prefix "free"
    /// <summary>
    /// A flag to signal that the item, event, or place is accessible for free.
    /// <see href="http://schema.org/isAccessibleForFree"></see></summary>
    let isAccessibleForFree = _prefix "isAccessibleForFree"
    /// <summary>
    /// A sub property of location. The original location of the object or the agent before the action.
    /// <see href="http://schema.org/fromLocation"></see></summary>
    let fromLocation = _prefix "fromLocation"
    /// <summary>
    /// The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. L/100 km.&lt;/li&gt;
    /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
    /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel consumption to another value.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/fuelConsumption"></see></summary>
    let fuelConsumption = _prefix "fuelConsumption"
    /// <summary>
    /// The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. mpg or km/L.&lt;/li&gt;
    /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
    /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel economy to another value.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/fuelEfficiency"></see></summary>
    let fuelEfficiency = _prefix "fuelEfficiency"
    /// <summary>
    /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
    /// <see href="http://schema.org/fuelType"></see></summary>
    let fuelType = _prefix "fuelType"
    /// <summary>
    /// A person or organization that supports (sponsors) something through some kind of financial contribution.
    /// <see href="http://schema.org/funder"></see></summary>
    let funder = _prefix "funder"
    /// <summary>
    /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
    /// <see href="http://schema.org/sponsor"></see></summary>
    let sponsor = _prefix "sponsor"
    /// <summary>
    /// Video game which is played on this server.
    /// <see href="http://schema.org/game"></see></summary>
    let game = _prefix "game"
    /// <summary>
    /// The server on which  it is possible to play the game.
    /// <see href="http://schema.org/gameServer"></see></summary>
    let gameServer = _prefix "gameServer"
    /// <summary>
    /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
    /// <see href="http://schema.org/gameItem"></see></summary>
    let gameItem = _prefix "gameItem"
    /// <summary>
    /// Real or fictional location of the game (or part of game).
    /// <see href="http://schema.org/gameLocation"></see></summary>
    let gameLocation = _prefix "gameLocation"
    /// <summary>
    /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
    /// <see href="http://schema.org/gamePlatform"></see></summary>
    let gamePlatform = _prefix "gamePlatform"
    /// <summary>
    /// Links to tips, tactics, etc.
    /// <see href="http://schema.org/gameTip"></see></summary>
    let gameTip = _prefix "gameTip"
    /// <summary>
    /// Genre of the creative work, broadcast channel or group.
    /// <see href="http://schema.org/genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    /// The geo coordinates of the place.
    /// <see href="http://schema.org/geo"></see></summary>
    let geo = _prefix "geo"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoContains"></see></summary>
    let geoContains = _prefix "geoContains"
    /// <summary>
    ///   <see href="http://schema.org/GeospatialGeometry"></see>
    /// </summary>
    let GeospatialGeometry = _prefix "GeospatialGeometry"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoCoveredBy"></see></summary>
    let geoCoveredBy = _prefix "geoCoveredBy"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoCovers"></see></summary>
    let geoCovers = _prefix "geoCovers"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoCrosses"></see></summary>
    let geoCrosses = _prefix "geoCrosses"
    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
    /// <see href="http://schema.org/geoDisjoint"></see></summary>
    let geoDisjoint = _prefix "geoDisjoint"
    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
    /// <see href="http://schema.org/geoEquals"></see></summary>
    let geoEquals = _prefix "geoEquals"
    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoIntersects"></see></summary>
    let geoIntersects = _prefix "geoIntersects"
    /// <summary>
    /// Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.
    /// <see href="http://schema.org/geoMidpoint"></see></summary>
    let geoMidpoint = _prefix "geoMidpoint"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoOverlaps"></see></summary>
    let geoOverlaps = _prefix "geoOverlaps"
    /// <summary>
    /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
    /// <see href="http://schema.org/geoRadius"></see></summary>
    let geoRadius = _prefix "geoRadius"
    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
    /// <see href="http://schema.org/geoTouches"></see></summary>
    let geoTouches = _prefix "geoTouches"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoWithin"></see></summary>
    let geoWithin = _prefix "geoWithin"
    /// <summary>
    /// The geographic area associated with the audience.
    /// <see href="http://schema.org/geographicArea"></see></summary>
    let geographicArea = _prefix "geographicArea"
    /// <summary>
    /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
    /// <see href="http://schema.org/givenName"></see></summary>
    let givenName = _prefix "givenName"
    /// <summary>
    /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
    /// <see href="http://schema.org/globalLocationNumber"></see></summary>
    let globalLocationNumber = _prefix "globalLocationNumber"
    /// <summary>
    /// The person, organization, contact point, or audience that has been granted this permission.
    /// <see href="http://schema.org/grantee"></see></summary>
    let grantee = _prefix "grantee"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is greater than the object.
    /// <see href="http://schema.org/greater"></see></summary>
    let greater = _prefix "greater"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.
    /// <see href="http://schema.org/greaterOrEqual"></see></summary>
    let greaterOrEqual = _prefix "greaterOrEqual"
    /// <summary>
    /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
    /// <see href="http://schema.org/gtin12"></see></summary>
    let gtin12 = _prefix "gtin12"
    /// <summary>
    ///   <see href="http://schema.org/gtin"></see>
    /// </summary>
    let gtin = _prefix "gtin"
    /// <summary>
    /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
    /// <see href="http://schema.org/gtin13"></see></summary>
    let gtin13 = _prefix "gtin13"
    /// <summary>
    /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
    /// <see href="http://schema.org/gtin14"></see></summary>
    let gtin14 = _prefix "gtin14"
    /// <summary>
    /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
    /// <see href="http://schema.org/gtin8"></see></summary>
    let gtin8 = _prefix "gtin8"
    /// <summary>
    /// A broadcast channel of a broadcast service.
    /// <see href="http://schema.org/hasBroadcastChannel"></see></summary>
    let hasBroadcastChannel = _prefix "hasBroadcastChannel"
    /// <summary>
    /// The BroadcastService offered on this channel.
    /// <see href="http://schema.org/providesBroadcastService"></see></summary>
    let providesBroadcastService = _prefix "providesBroadcastService"
    /// <summary>
    /// An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
    /// <see href="http://schema.org/hasCourseInstance"></see></summary>
    let hasCourseInstance = _prefix "hasCourseInstance"
    /// <summary>
    /// Method used for delivery or shipping.
    /// <see href="http://schema.org/hasDeliveryMethod"></see></summary>
    let hasDeliveryMethod = _prefix "hasDeliveryMethod"
    /// <summary>
    /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
    /// <see href="http://schema.org/hasDigitalDocumentPermission"></see></summary>
    let hasDigitalDocumentPermission = _prefix "hasDigitalDocumentPermission"
    /// <summary>
    /// A URL to a map of the place.
    /// <see href="http://schema.org/hasMap"></see></summary>
    let hasMap = _prefix "hasMap"
    /// <summary>
    /// Either the actual menu as a structured representation, as text, or a URL of the menu.
    /// <see href="http://schema.org/hasMenu"></see></summary>
    let hasMenu = _prefix "hasMenu"
    /// <summary>
    /// A food or drink item contained in a menu or menu section.
    /// <see href="http://schema.org/hasMenuItem"></see></summary>
    let hasMenuItem = _prefix "hasMenuItem"
    /// <summary>
    /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
    /// <see href="http://schema.org/hasMenuSection"></see></summary>
    let hasMenuSection = _prefix "hasMenuSection"
    /// <summary>
    /// The Person's occupation. For past professions, use Role for expressing dates.
    /// <see href="http://schema.org/hasOccupation"></see></summary>
    let hasOccupation = _prefix "hasOccupation"
    /// <summary>
    /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
    /// <see href="http://schema.org/hasOfferCatalog"></see></summary>
    let hasOfferCatalog = _prefix "hasOfferCatalog"
    /// <summary>
    /// Points-of-Sales operated by the organization or person.
    /// <see href="http://schema.org/hasPOS"></see></summary>
    let hasPOS = _prefix "hasPOS"
    /// <summary>
    /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.
    /// <see href="http://schema.org/isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    /// Headline of the article.
    /// <see href="http://schema.org/headline"></see></summary>
    let headline = _prefix "headline"
    /// <summary>
    /// The height of the item.
    /// <see href="http://schema.org/height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// The highest price of all offers available.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/highPrice"></see></summary>
    let highPrice = _prefix "highPrice"
    /// <summary>
    /// Organization offering the job position.
    /// <see href="http://schema.org/hiringOrganization"></see></summary>
    let hiringOrganization = _prefix "hiringOrganization"
    /// <summary>
    /// A contact location for a person's residence.
    /// <see href="http://schema.org/homeLocation"></see></summary>
    let homeLocation = _prefix "homeLocation"
    /// <summary>
    /// The home team in a sports event.
    /// <see href="http://schema.org/homeTeam"></see></summary>
    let homeTeam = _prefix "homeTeam"
    /// <summary>
    /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
    /// <see href="http://schema.org/honorificPrefix"></see></summary>
    let honorificPrefix = _prefix "honorificPrefix"
    /// <summary>
    /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
    /// <see href="http://schema.org/honorificSuffix"></see></summary>
    let honorificSuffix = _prefix "honorificSuffix"
    /// <summary>
    /// The organization (airline, travelers' club, etc.) the membership is made with.
    /// <see href="http://schema.org/hostingOrganization"></see></summary>
    let hostingOrganization = _prefix "hostingOrganization"
    /// <summary>
    /// The hours during which this service or contact is available.
    /// <see href="http://schema.org/hoursAvailable"></see></summary>
    let hoursAvailable = _prefix "hoursAvailable"
    /// <summary>
    /// An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.
    /// <see href="http://schema.org/httpMethod"></see></summary>
    let httpMethod = _prefix "httpMethod"
    /// <summary>
    /// IATA identifier for an airline or airport.
    /// <see href="http://schema.org/iataCode"></see></summary>
    let iataCode = _prefix "iataCode"
    /// <summary>
    /// ICAO identifier for an airport.
    /// <see href="http://schema.org/icaoCode"></see></summary>
    let icaoCode = _prefix "icaoCode"
    /// <summary>
    /// The illustrator of the book.
    /// <see href="http://schema.org/illustrator"></see></summary>
    let illustrator = _prefix "illustrator"
    /// <summary>
    /// An image of the item. This can be a &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt; or a fully described &lt;a class="localLink" href="http://schema.org/ImageObject"&gt;ImageObject&lt;/a&gt;.
    /// <see href="http://schema.org/image"></see></summary>
    let image = _prefix "image"
    /// <summary>
    /// The album to which this recording belongs.
    /// <see href="http://schema.org/inAlbum"></see></summary>
    let inAlbum = _prefix "inAlbum"
    /// <summary>
    /// The CableOrSatelliteService offering the channel.
    /// <see href="http://schema.org/inBroadcastLineup"></see></summary>
    let inBroadcastLineup = _prefix "inBroadcastLineup"
    /// <summary>
    /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
    /// <see href="http://schema.org/inLanguage"></see></summary>
    let inLanguage = _prefix "inLanguage"
    /// <summary>
    ///   <see href="http://schema.org/LinkRole"></see>
    /// </summary>
    let LinkRole = _prefix "LinkRole"
    /// <summary>
    ///   <see href="http://schema.org/PronounceableText"></see>
    /// </summary>
    let PronounceableText = _prefix "PronounceableText"
    /// <summary>
    /// The playlist to which this recording belongs.
    /// <see href="http://schema.org/inPlaylist"></see></summary>
    let inPlaylist = _prefix "inPlaylist"
    /// <summary>
    /// Description of bonus and commission compensation aspects of the job.
    /// <see href="http://schema.org/incentiveCompensation"></see></summary>
    let incentiveCompensation = _prefix "incentiveCompensation"
    /// <summary>
    /// Description of bonus and commission compensation aspects of the job.
    /// <see href="http://schema.org/incentives"></see></summary>
    let incentives = _prefix "incentives"
    /// <summary>
    /// Smaller compositions included in this work (e.g. a movement in a symphony).
    /// <see href="http://schema.org/includedComposition"></see></summary>
    let includedComposition = _prefix "includedComposition"
    /// <summary>
    /// A data catalog which contains this dataset (this property was previously 'catalog', preferred name is now 'includedInDataCatalog').
    /// <see href="http://schema.org/includedDataCatalog"></see></summary>
    let includedDataCatalog = _prefix "includedDataCatalog"
    /// <summary>
    /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
    /// <see href="http://schema.org/includesObject"></see></summary>
    let includesObject = _prefix "includesObject"
    /// <summary>
    /// The industry associated with the job position.
    /// <see href="http://schema.org/industry"></see></summary>
    let industry = _prefix "industry"
    /// <summary>
    ///   <see href="http://schema.org/DefinedTerm"></see>
    /// </summary>
    let DefinedTerm = _prefix "DefinedTerm"
    /// <summary>
    /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
    /// <see href="http://schema.org/ingredients"></see></summary>
    let ingredients = _prefix "ingredients"
    /// <summary>
    /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
    /// <see href="http://schema.org/recipeIngredient"></see></summary>
    let recipeIngredient = _prefix "recipeIngredient"
    /// <summary>
    /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
    /// <see href="http://schema.org/supply"></see></summary>
    let supply = _prefix "supply"
    /// <summary>
    /// URL at which the app may be installed, if different from the URL of the item.
    /// <see href="http://schema.org/installUrl"></see></summary>
    let installUrl = _prefix "installUrl"
    /// <summary>
    /// A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="http://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.
    /// <see href="http://schema.org/instructor"></see></summary>
    let instructor = _prefix "instructor"
    /// <summary>
    /// This property is deprecated, alongside the UserInteraction types on which it depended.
    /// <see href="http://schema.org/interactionCount"></see></summary>
    let interactionCount = _prefix "interactionCount"
    /// <summary>
    /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
    /// <see href="http://schema.org/interactionStatistic"></see></summary>
    let interactionStatistic = _prefix "interactionStatistic"
    /// <summary>
    /// The WebSite or SoftwareApplication where the interactions took place.
    /// <see href="http://schema.org/interactionService"></see></summary>
    let interactionService = _prefix "interactionService"
    /// <summary>
    /// The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="http://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="http://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.
    /// <see href="http://schema.org/interactionType"></see></summary>
    let interactionType = _prefix "interactionType"
    /// <summary>
    /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
    /// <see href="http://schema.org/interactivityType"></see></summary>
    let interactivityType = _prefix "interactivityType"
    /// <summary>
    /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
    /// <see href="http://schema.org/interestRate"></see></summary>
    let interestRate = _prefix "interestRate"
    /// <summary>
    /// The current approximate inventory level for the item or items.
    /// <see href="http://schema.org/inventoryLevel"></see></summary>
    let inventoryLevel = _prefix "inventoryLevel"
    /// <summary>
    /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
    /// <see href="http://schema.org/isAccessoryOrSparePartFor"></see></summary>
    let isAccessoryOrSparePartFor = _prefix "isAccessoryOrSparePartFor"
    /// <summary>
    /// A resource from which this work is derived or from which it is a modification or adaption.
    /// <see href="http://schema.org/isBasedOn"></see></summary>
    let isBasedOn = _prefix "isBasedOn"
    /// <summary>
    /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
    /// <see href="http://schema.org/isBasedOnUrl"></see></summary>
    let isBasedOnUrl = _prefix "isBasedOnUrl"
    /// <summary>
    /// A pointer to another product (or multiple products) for which this product is a consumable.
    /// <see href="http://schema.org/isConsumableFor"></see></summary>
    let isConsumableFor = _prefix "isConsumableFor"
    /// <summary>
    /// Indicates whether this content is family friendly.
    /// <see href="http://schema.org/isFamilyFriendly"></see></summary>
    let isFamilyFriendly = _prefix "isFamilyFriendly"
    /// <summary>
    /// Was the offer accepted as a gift for someone other than the buyer.
    /// <see href="http://schema.org/isGift"></see></summary>
    let isGift = _prefix "isGift"
    /// <summary>
    /// True is the broadcast is of a live event.
    /// <see href="http://schema.org/isLiveBroadcast"></see></summary>
    let isLiveBroadcast = _prefix "isLiveBroadcast"
    /// <summary>
    /// A pointer to another, somehow related product (or multiple products).
    /// <see href="http://schema.org/isRelatedTo"></see></summary>
    let isRelatedTo = _prefix "isRelatedTo"
    /// <summary>
    /// A pointer to another, functionally similar product (or multiple products).
    /// <see href="http://schema.org/isSimilarTo"></see></summary>
    let isSimilarTo = _prefix "isSimilarTo"
    /// <summary>
    /// A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.
    /// <see href="http://schema.org/isVariantOf"></see></summary>
    let isVariantOf = _prefix "isVariantOf"
    /// <summary>
    /// The ISBN of the book.
    /// <see href="http://schema.org/isbn"></see></summary>
    let isbn = _prefix "isbn"
    /// <summary>
    /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
    /// <see href="http://schema.org/isicV4"></see></summary>
    let isicV4 = _prefix "isicV4"
    /// <summary>
    /// The International Standard Recording Code for the recording.
    /// <see href="http://schema.org/isrcCode"></see></summary>
    let isrcCode = _prefix "isrcCode"
    /// <summary>
    /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
    /// <see href="http://schema.org/issn"></see></summary>
    let issn = _prefix "issn"
    /// <summary>
    /// Identifies the issue of publication; for example, "iii" or "2".
    /// <see href="http://schema.org/issueNumber"></see></summary>
    let issueNumber = _prefix "issueNumber"
    /// <summary>
    /// The organization issuing the ticket or permit.
    /// <see href="http://schema.org/issuedBy"></see></summary>
    let issuedBy = _prefix "issuedBy"
    /// <summary>
    /// The service through with the permit was granted.
    /// <see href="http://schema.org/issuedThrough"></see></summary>
    let issuedThrough = _prefix "issuedThrough"
    /// <summary>
    /// The International Standard Musical Work Code for the composition.
    /// <see href="http://schema.org/iswcCode"></see></summary>
    let iswcCode = _prefix "iswcCode"
    /// <summary>
    /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
    /// <see href="http://schema.org/item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
    /// <see href="http://schema.org/itemCondition"></see></summary>
    let itemCondition = _prefix "itemCondition"
    /// <summary>
    /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
    /// <see href="http://schema.org/itemListElement"></see></summary>
    let itemListElement = _prefix "itemListElement"
    /// <summary>
    /// Type of ordering (e.g. Ascending, Descending, Unordered).
    /// <see href="http://schema.org/itemListOrder"></see></summary>
    let itemListOrder = _prefix "itemListOrder"
    /// <summary>
    /// An item being offered (or demanded). The transactional nature of the offer or demand is documented using &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt;, e.g. sell, lease etc. While several common expected types are listed explicitly in this definition, others can be used. Using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
    /// <see href="http://schema.org/itemOffered"></see></summary>
    let itemOffered = _prefix "itemOffered"
    /// <summary>
    /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="http://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
    /// <see href="http://schema.org/offers"></see></summary>
    let offers = _prefix "offers"
    /// <summary>
    /// The item that is being reviewed/rated.
    /// <see href="http://schema.org/itemReviewed"></see></summary>
    let itemReviewed = _prefix "itemReviewed"
    /// <summary>
    /// Item(s) being shipped.
    /// <see href="http://schema.org/itemShipped"></see></summary>
    let itemShipped = _prefix "itemShipped"
    /// <summary>
    /// A (typically single) geographic location associated with the job position.
    /// <see href="http://schema.org/jobLocation"></see></summary>
    let jobLocation = _prefix "jobLocation"
    /// <summary>
    /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
    /// <see href="http://schema.org/keywords"></see></summary>
    let keywords = _prefix "keywords"
    /// <summary>
    /// A textual description of known damages, both repaired and unrepaired.
    /// <see href="http://schema.org/knownVehicleDamages"></see></summary>
    let knownVehicleDamages = _prefix "knownVehicleDamages"
    /// <summary>
    /// The most generic bi-directional social/work relation.
    /// <see href="http://schema.org/knows"></see></summary>
    let knows = _prefix "knows"
    /// <summary>
    /// A sub property of participant. The owner of the real estate property.
    /// <see href="http://schema.org/landlord"></see></summary>
    let landlord = _prefix "landlord"
    /// <summary>
    /// A sub property of instrument. The language used on this action.
    /// <see href="http://schema.org/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
    /// <see href="http://schema.org/lastReviewed"></see></summary>
    let lastReviewed = _prefix "lastReviewed"
    /// <summary>
    /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
    /// <see href="http://schema.org/latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
    /// <see href="http://schema.org/learningResourceType"></see></summary>
    let learningResourceType = _prefix "learningResourceType"
    /// <summary>
    /// The official name of the organization, e.g. the registered company name.
    /// <see href="http://schema.org/legalName"></see></summary>
    let legalName = _prefix "legalName"
    /// <summary>
    /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
    /// <see href="http://schema.org/leiCode"></see></summary>
    let leiCode = _prefix "leiCode"
    /// <summary>
    /// A sub property of participant. The person that lends the object being borrowed.
    /// <see href="http://schema.org/lender"></see></summary>
    let lender = _prefix "lender"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is lesser than the object.
    /// <see href="http://schema.org/lesser"></see></summary>
    let lesser = _prefix "lesser"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.
    /// <see href="http://schema.org/lesserOrEqual"></see></summary>
    let lesserOrEqual = _prefix "lesserOrEqual"
    /// <summary>
    /// A license document that applies to this content, typically indicated by URL.
    /// <see href="http://schema.org/license"></see></summary>
    let license = _prefix "license"
    /// <summary>
    /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
    /// <see href="http://schema.org/line"></see></summary>
    let line = _prefix "line"
    /// <summary>
    /// An update to the LiveBlog.
    /// <see href="http://schema.org/liveBlogUpdate"></see></summary>
    let liveBlogUpdate = _prefix "liveBlogUpdate"
    /// <summary>
    /// The duration of the loan or credit agreement.
    /// <see href="http://schema.org/loanTerm"></see></summary>
    let loanTerm = _prefix "loanTerm"
    /// <summary>
    ///   <see href="http://schema.org/VirtualLocation"></see>
    /// </summary>
    let VirtualLocation = _prefix "VirtualLocation"
    /// <summary>
    /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
    /// <see href="http://schema.org/locationCreated"></see></summary>
    let locationCreated = _prefix "locationCreated"
    /// <summary>
    /// A full description of the lodging unit.
    /// <see href="http://schema.org/lodgingUnitDescription"></see></summary>
    let lodgingUnitDescription = _prefix "lodgingUnitDescription"
    /// <summary>
    /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
    /// <see href="http://schema.org/lodgingUnitType"></see></summary>
    let lodgingUnitType = _prefix "lodgingUnitType"
    /// <summary>
    /// An associated logo.
    /// <see href="http://schema.org/logo"></see></summary>
    let logo = _prefix "logo"
    /// <summary>
    /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
    /// <see href="http://schema.org/longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// A sub property of participant. The loser of the action.
    /// <see href="http://schema.org/loser"></see></summary>
    let loser = _prefix "loser"
    /// <summary>
    /// The lowest price of all offers available.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/lowPrice"></see></summary>
    let lowPrice = _prefix "lowPrice"
    /// <summary>
    /// The person who wrote the words.
    /// <see href="http://schema.org/lyricist"></see></summary>
    let lyricist = _prefix "lyricist"
    /// <summary>
    /// The words in the song.
    /// <see href="http://schema.org/lyrics"></see></summary>
    let lyrics = _prefix "lyrics"
    /// <summary>
    /// Indicates if this web page element is the main subject of the page.
    /// <see href="http://schema.org/mainContentOfPage"></see></summary>
    let mainContentOfPage = _prefix "mainContentOfPage"
    /// <summary>
    /// Indicates the primary entity described in some page or other CreativeWork.
    /// <see href="http://schema.org/mainEntity"></see></summary>
    let mainEntity = _prefix "mainEntity"
    /// <summary>
    /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See &lt;a href="/docs/datamodel.html#mainEntityBackground"&gt;background notes&lt;/a&gt; for details.
    /// <see href="http://schema.org/mainEntityOfPage"></see></summary>
    let mainEntityOfPage = _prefix "mainEntityOfPage"
    /// <summary>
    /// A pointer to products or services offered by the organization or person.
    /// <see href="http://schema.org/makesOffer"></see></summary>
    let makesOffer = _prefix "makesOffer"
    /// <summary>
    /// A pointer to the organization or person making the offer.
    /// <see href="http://schema.org/offeredBy"></see></summary>
    let offeredBy = _prefix "offeredBy"
    /// <summary>
    /// The manufacturer of the product.
    /// <see href="http://schema.org/manufacturer"></see></summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    ///   <see href="http://schema.org/DietarySupplement"></see>
    /// </summary>
    let DietarySupplement = _prefix "DietarySupplement"
    /// <summary>
    ///   <see href="http://schema.org/Drug"></see>
    /// </summary>
    let Drug = _prefix "Drug"
    /// <summary>
    /// A URL to a map of the place.
    /// <see href="http://schema.org/map"></see></summary>
    let map = _prefix "map"
    /// <summary>
    /// Indicates the kind of Map, from the MapCategoryType Enumeration.
    /// <see href="http://schema.org/mapType"></see></summary>
    let mapType = _prefix "mapType"
    /// <summary>
    /// A URL to a map of the place.
    /// <see href="http://schema.org/maps"></see></summary>
    let maps = _prefix "maps"
    /// <summary>
    /// The highest price if the price is a range.
    /// <see href="http://schema.org/maxPrice"></see></summary>
    let maxPrice = _prefix "maxPrice"
    /// <summary>
    /// The upper value of some characteristic or property.
    /// <see href="http://schema.org/maxValue"></see></summary>
    let maxValue = _prefix "maxValue"
    /// <summary>
    /// The total number of individuals that may attend an event or venue.
    /// <see href="http://schema.org/maximumAttendeeCapacity"></see></summary>
    let maximumAttendeeCapacity = _prefix "maximumAttendeeCapacity"
    /// <summary>
    /// Description of the meals that will be provided or available for purchase.
    /// <see href="http://schema.org/mealService"></see></summary>
    let mealService = _prefix "mealService"
    /// <summary>
    /// The median value.
    /// <see href="http://schema.org/median"></see></summary>
    let median = _prefix "median"
    /// <summary>
    /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
    /// <see href="http://schema.org/member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// A member of this organization.
    /// <see href="http://schema.org/members"></see></summary>
    let members = _prefix "members"
    /// <summary>
    /// A unique identifier for the membership.
    /// <see href="http://schema.org/membershipNumber"></see></summary>
    let membershipNumber = _prefix "membershipNumber"
    /// <summary>
    /// Minimum memory requirements.
    /// <see href="http://schema.org/memoryRequirements"></see></summary>
    let memoryRequirements = _prefix "memoryRequirements"
    /// <summary>
    /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
    /// <see href="http://schema.org/mentions"></see></summary>
    let mentions = _prefix "mentions"
    /// <summary>
    /// Either the actual menu as a structured representation, as text, or a URL of the menu.
    /// <see href="http://schema.org/menu"></see></summary>
    let menu = _prefix "menu"
    /// <summary>
    /// Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.
    /// <see href="http://schema.org/menuAddOn"></see></summary>
    let menuAddOn = _prefix "menuAddOn"
    /// <summary>
    /// 'merchant' is an out-dated term for 'seller'.
    /// <see href="http://schema.org/merchant"></see></summary>
    let merchant = _prefix "merchant"
    /// <summary>
    /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
    /// <see href="http://schema.org/seller"></see></summary>
    let seller = _prefix "seller"
    /// <summary>
    /// A CreativeWork attached to the message.
    /// <see href="http://schema.org/messageAttachment"></see></summary>
    let messageAttachment = _prefix "messageAttachment"
    /// <summary>
    /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    /// <see href="http://schema.org/mileageFromOdometer"></see></summary>
    let mileageFromOdometer = _prefix "mileageFromOdometer"
    /// <summary>
    /// The lowest price if the price is a range.
    /// <see href="http://schema.org/minPrice"></see></summary>
    let minPrice = _prefix "minPrice"
    /// <summary>
    /// The lower value of some characteristic or property.
    /// <see href="http://schema.org/minValue"></see></summary>
    let minValue = _prefix "minValue"
    /// <summary>
    /// The minimum payment required at this time.
    /// <see href="http://schema.org/minimumPaymentDue"></see></summary>
    let minimumPaymentDue = _prefix "minimumPaymentDue"
    /// <summary>
    /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
    /// <see href="http://schema.org/model"></see></summary>
    let model = _prefix "model"
    /// <summary>
    /// The date and time the reservation was modified.
    /// <see href="http://schema.org/modifiedTime"></see></summary>
    let modifiedTime = _prefix "modifiedTime"
    /// <summary>
    /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
    /// <see href="http://schema.org/mpn"></see></summary>
    let mpn = _prefix "mpn"
    /// <summary>
    /// Whether multiple values are allowed for the property.  Default is false.
    /// <see href="http://schema.org/multipleValues"></see></summary>
    let multipleValues = _prefix "multipleValues"
    /// <summary>
    /// An arrangement derived from the composition.
    /// <see href="http://schema.org/musicArrangement"></see></summary>
    let musicArrangement = _prefix "musicArrangement"
    /// <summary>
    /// The composer of the soundtrack.
    /// <see href="http://schema.org/musicBy"></see></summary>
    let musicBy = _prefix "musicBy"
    /// <summary>
    /// The type of composition (e.g. overture, sonata, symphony, etc.).
    /// <see href="http://schema.org/musicCompositionForm"></see></summary>
    let musicCompositionForm = _prefix "musicCompositionForm"
    /// <summary>
    /// A member of a music group&amp;#x2014;for example, John, Paul, George, or Ringo.
    /// <see href="http://schema.org/musicGroupMember"></see></summary>
    let musicGroupMember = _prefix "musicGroupMember"
    /// <summary>
    /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
    /// <see href="http://schema.org/musicReleaseFormat"></see></summary>
    let musicReleaseFormat = _prefix "musicReleaseFormat"
    /// <summary>
    /// The key, mode, or scale this composition uses.
    /// <see href="http://schema.org/musicalKey"></see></summary>
    let musicalKey = _prefix "musicalKey"
    /// <summary>
    /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
    /// <see href="http://schema.org/naics"></see></summary>
    let naics = _prefix "naics"
    /// <summary>
    /// The name of the item.
    /// <see href="http://schema.org/name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// A position played, performed or filled by a person or organization, as part of an organization. For example, an athlete in a SportsTeam might play in the position named 'Quarterback'.
    /// <see href="http://schema.org/namedPosition"></see></summary>
    let namedPosition = _prefix "namedPosition"
    /// <summary>
    /// A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.
    /// <see href="http://schema.org/roleName"></see></summary>
    let roleName = _prefix "roleName"
    /// <summary>
    /// Nationality of the person.
    /// <see href="http://schema.org/nationality"></see></summary>
    let nationality = _prefix "nationality"
    /// <summary>
    /// The total financial value of the person as calculated by subtracting assets from liabilities.
    /// <see href="http://schema.org/netWorth"></see></summary>
    let netWorth = _prefix "netWorth"
    /// <summary>
    /// A link to the ListItem that follows the current one.
    /// <see href="http://schema.org/nextItem"></see></summary>
    let nextItem = _prefix "nextItem"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is not equal to the object.
    /// <see href="http://schema.org/nonEqual"></see></summary>
    let nonEqual = _prefix "nonEqual"
    /// <summary>
    /// The number of adults staying in the unit.
    /// <see href="http://schema.org/numAdults"></see></summary>
    let numAdults = _prefix "numAdults"
    /// <summary>
    /// The number of children staying in the unit.
    /// <see href="http://schema.org/numChildren"></see></summary>
    let numChildren = _prefix "numChildren"
    /// <summary>
    /// The number of tracks in this album or playlist.
    /// <see href="http://schema.org/numTracks"></see></summary>
    let numTracks = _prefix "numTracks"
    /// <summary>
    /// The number or type of airbags in the vehicle.
    /// <see href="http://schema.org/numberOfAirbags"></see></summary>
    let numberOfAirbags = _prefix "numberOfAirbags"
    /// <summary>
    /// The number of axles.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62
    /// <see href="http://schema.org/numberOfAxles"></see></summary>
    let numberOfAxles = _prefix "numberOfAxles"
    /// <summary>
    /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
    /// <see href="http://schema.org/numberOfBeds"></see></summary>
    let numberOfBeds = _prefix "numberOfBeds"
    /// <summary>
    /// The number of doors.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62
    /// <see href="http://schema.org/numberOfDoors"></see></summary>
    let numberOfDoors = _prefix "numberOfDoors"
    /// <summary>
    /// The number of employees in an organization e.g. business.
    /// <see href="http://schema.org/numberOfEmployees"></see></summary>
    let numberOfEmployees = _prefix "numberOfEmployees"
    /// <summary>
    /// The number of episodes in this season or series.
    /// <see href="http://schema.org/numberOfEpisodes"></see></summary>
    let numberOfEpisodes = _prefix "numberOfEpisodes"
    /// <summary>
    /// The total number of forward gears available for the transmission system of the vehicle.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62
    /// <see href="http://schema.org/numberOfForwardGears"></see></summary>
    let numberOfForwardGears = _prefix "numberOfForwardGears"
    /// <summary>
    /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
    /// <see href="http://schema.org/numberOfItems"></see></summary>
    let numberOfItems = _prefix "numberOfItems"
    /// <summary>
    /// The number of pages in the book.
    /// <see href="http://schema.org/numberOfPages"></see></summary>
    let numberOfPages = _prefix "numberOfPages"
    /// <summary>
    /// Indicate how many people can play this game (minimum, maximum, or range).
    /// <see href="http://schema.org/numberOfPlayers"></see></summary>
    let numberOfPlayers = _prefix "numberOfPlayers"
    /// <summary>
    /// The number of owners of the vehicle, including the current one.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62
    /// <see href="http://schema.org/numberOfPreviousOwners"></see></summary>
    let numberOfPreviousOwners = _prefix "numberOfPreviousOwners"
    /// <summary>
    /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
    /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
    /// <see href="http://schema.org/numberOfRooms"></see></summary>
    let numberOfRooms = _prefix "numberOfRooms"
    /// <summary>
    /// The number of seasons in this series.
    /// <see href="http://schema.org/numberOfSeasons"></see></summary>
    let numberOfSeasons = _prefix "numberOfSeasons"
    /// <summary>
    /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
    /// <see href="http://schema.org/numberedPosition"></see></summary>
    let numberedPosition = _prefix "numberedPosition"
    /// <summary>
    /// Nutrition information about the recipe or menu item.
    /// <see href="http://schema.org/nutrition"></see></summary>
    let nutrition = _prefix "nutrition"
    /// <summary>
    /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
    /// Typical unit code(s): C62 for person
    /// <see href="http://schema.org/occupancy"></see></summary>
    let occupancy = _prefix "occupancy"
    /// <summary>
    /// The region/country for which this occupational description is appropriate. Note that educational requirements and qualifications can vary between jurisdictions.
    /// <see href="http://schema.org/occupationLocation"></see></summary>
    let occupationLocation = _prefix "occupationLocation"
    /// <summary>
    /// The number of offers for the product.
    /// <see href="http://schema.org/offerCount"></see></summary>
    let offerCount = _prefix "offerCount"
    /// <summary>
    /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
    /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
    /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
    /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/openingHours"></see></summary>
    let openingHours = _prefix "openingHours"
    /// <summary>
    /// The opening hours of a certain place.
    /// <see href="http://schema.org/openingHoursSpecification"></see></summary>
    let openingHoursSpecification = _prefix "openingHoursSpecification"
    /// <summary>
    /// The opening hour of the place or service on the given day(s) of the week.
    /// <see href="http://schema.org/opens"></see></summary>
    let opens = _prefix "opens"
    /// <summary>
    /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
    /// <see href="http://schema.org/operatingSystem"></see></summary>
    let operatingSystem = _prefix "operatingSystem"
    /// <summary>
    /// A sub property of participant. The opponent on this action.
    /// <see href="http://schema.org/opponent"></see></summary>
    let opponent = _prefix "opponent"
    /// <summary>
    /// A sub property of object. The options subject to this action.
    /// <see href="http://schema.org/option"></see></summary>
    let option = _prefix "option"
    /// <summary>
    /// Date order was placed.
    /// <see href="http://schema.org/orderDate"></see></summary>
    let orderDate = _prefix "orderDate"
    /// <summary>
    /// The delivery of the parcel related to this order or order item.
    /// <see href="http://schema.org/orderDelivery"></see></summary>
    let orderDelivery = _prefix "orderDelivery"
    /// <summary>
    /// The identifier of the order item.
    /// <see href="http://schema.org/orderItemNumber"></see></summary>
    let orderItemNumber = _prefix "orderItemNumber"
    /// <summary>
    /// The current status of the order item.
    /// <see href="http://schema.org/orderItemStatus"></see></summary>
    let orderItemStatus = _prefix "orderItemStatus"
    /// <summary>
    /// The identifier of the transaction.
    /// <see href="http://schema.org/orderNumber"></see></summary>
    let orderNumber = _prefix "orderNumber"
    /// <summary>
    /// The number of the item ordered. If the property is not set, assume the quantity is one.
    /// <see href="http://schema.org/orderQuantity"></see></summary>
    let orderQuantity = _prefix "orderQuantity"
    /// <summary>
    /// The current status of the order.
    /// <see href="http://schema.org/orderStatus"></see></summary>
    let orderStatus = _prefix "orderStatus"
    /// <summary>
    /// The item ordered.
    /// <see href="http://schema.org/orderedItem"></see></summary>
    let orderedItem = _prefix "orderedItem"
    /// <summary>
    /// An organizer of an Event.
    /// <see href="http://schema.org/organizer"></see></summary>
    let organizer = _prefix "organizer"
    /// <summary>
    /// Shipper's address.
    /// <see href="http://schema.org/originAddress"></see></summary>
    let originAddress = _prefix "originAddress"
    /// <summary>
    /// The date and time of obtaining the product.
    /// <see href="http://schema.org/ownedFrom"></see></summary>
    let ownedFrom = _prefix "ownedFrom"
    /// <summary>
    /// The date and time of giving up ownership on the product.
    /// <see href="http://schema.org/ownedThrough"></see></summary>
    let ownedThrough = _prefix "ownedThrough"
    /// <summary>
    /// Products owned by the organization or person.
    /// <see href="http://schema.org/owns"></see></summary>
    let owns = _prefix "owns"
    /// <summary>
    /// The page on which the work ends; for example "138" or "xvi".
    /// <see href="http://schema.org/pageEnd"></see></summary>
    let pageEnd = _prefix "pageEnd"
    /// <summary>
    ///   <see href="http://schema.org/Chapter"></see>
    /// </summary>
    let Chapter = _prefix "Chapter"
    /// <summary>
    /// The page on which the work starts; for example "135" or "xiii".
    /// <see href="http://schema.org/pageStart"></see></summary>
    let pageStart = _prefix "pageStart"
    /// <summary>
    /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
    /// <see href="http://schema.org/pagination"></see></summary>
    let pagination = _prefix "pagination"
    /// <summary>
    /// A parent of this person.
    /// <see href="http://schema.org/parent"></see></summary>
    let parent = _prefix "parent"
    /// <summary>
    /// The parent of a question, answer or item in general.
    /// <see href="http://schema.org/parentItem"></see></summary>
    let parentItem = _prefix "parentItem"
    /// <summary>
    /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
    /// <see href="http://schema.org/subOrganization"></see></summary>
    let subOrganization = _prefix "subOrganization"
    /// <summary>
    /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
    /// <see href="http://schema.org/parentService"></see></summary>
    let parentService = _prefix "parentService"
    /// <summary>
    /// A parents of the person.
    /// <see href="http://schema.org/parents"></see></summary>
    let parents = _prefix "parents"
    /// <summary>
    /// The episode to which this clip belongs.
    /// <see href="http://schema.org/partOfEpisode"></see></summary>
    let partOfEpisode = _prefix "partOfEpisode"
    /// <summary>
    /// The order is being paid as part of the referenced Invoice.
    /// <see href="http://schema.org/partOfInvoice"></see></summary>
    let partOfInvoice = _prefix "partOfInvoice"
    /// <summary>
    /// The overall order the items in this delivery were included in.
    /// <see href="http://schema.org/partOfOrder"></see></summary>
    let partOfOrder = _prefix "partOfOrder"
    /// <summary>
    /// The season to which this episode belongs.
    /// <see href="http://schema.org/partOfSeason"></see></summary>
    let partOfSeason = _prefix "partOfSeason"
    /// <summary>
    /// The series to which this episode or season belongs.
    /// <see href="http://schema.org/partOfSeries"></see></summary>
    let partOfSeries = _prefix "partOfSeries"
    /// <summary>
    /// The TV series to which this episode or season belongs.
    /// <see href="http://schema.org/partOfTVSeries"></see></summary>
    let partOfTVSeries = _prefix "partOfTVSeries"
    /// <summary>
    /// Number of people the reservation should accommodate.
    /// <see href="http://schema.org/partySize"></see></summary>
    let partySize = _prefix "partySize"
    /// <summary>
    /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
    /// <see href="http://schema.org/passengerPriorityStatus"></see></summary>
    let passengerPriorityStatus = _prefix "passengerPriorityStatus"
    /// <summary>
    /// The passenger's sequence number as assigned by the airline.
    /// <see href="http://schema.org/passengerSequenceNumber"></see></summary>
    let passengerSequenceNumber = _prefix "passengerSequenceNumber"
    /// <summary>
    /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
    /// <see href="http://schema.org/paymentAccepted"></see></summary>
    let paymentAccepted = _prefix "paymentAccepted"
    /// <summary>
    /// The date that payment is due.
    /// <see href="http://schema.org/paymentDue"></see></summary>
    let paymentDue = _prefix "paymentDue"
    /// <summary>
    /// The date that payment is due.
    /// <see href="http://schema.org/paymentDueDate"></see></summary>
    let paymentDueDate = _prefix "paymentDueDate"
    /// <summary>
    /// The name of the credit card or other method of payment for the order.
    /// <see href="http://schema.org/paymentMethod"></see></summary>
    let paymentMethod = _prefix "paymentMethod"
    /// <summary>
    /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
    /// <see href="http://schema.org/paymentMethodId"></see></summary>
    let paymentMethodId = _prefix "paymentMethodId"
    /// <summary>
    /// The status of payment; whether the invoice has been paid or not.
    /// <see href="http://schema.org/paymentStatus"></see></summary>
    let paymentStatus = _prefix "paymentStatus"
    /// <summary>
    /// The URL for sending a payment.
    /// <see href="http://schema.org/paymentUrl"></see></summary>
    let paymentUrl = _prefix "paymentUrl"
    /// <summary>
    /// The 10th percentile value.
    /// <see href="http://schema.org/percentile10"></see></summary>
    let percentile10 = _prefix "percentile10"
    /// <summary>
    /// The 25th percentile value.
    /// <see href="http://schema.org/percentile25"></see></summary>
    let percentile25 = _prefix "percentile25"
    /// <summary>
    /// The 75th percentile value.
    /// <see href="http://schema.org/percentile75"></see></summary>
    let percentile75 = _prefix "percentile75"
    /// <summary>
    /// The 90th percentile value.
    /// <see href="http://schema.org/percentile90"></see></summary>
    let percentile90 = _prefix "percentile90"
    /// <summary>
    /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
    /// <see href="http://schema.org/performer"></see></summary>
    let performer = _prefix "performer"
    /// <summary>
    /// Event that this person is a performer or participant in.
    /// <see href="http://schema.org/performerIn"></see></summary>
    let performerIn = _prefix "performerIn"
    /// <summary>
    /// The main performer or performers of the event&amp;#x2014;for example, a presenter, musician, or actor.
    /// <see href="http://schema.org/performers"></see></summary>
    let performers = _prefix "performers"
    /// <summary>
    /// The type of permission granted the person, organization, or audience.
    /// <see href="http://schema.org/permissionType"></see></summary>
    let permissionType = _prefix "permissionType"
    /// <summary>
    /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
    /// <see href="http://schema.org/permissions"></see></summary>
    let permissions = _prefix "permissions"
    /// <summary>
    /// The target audience for this permit.
    /// <see href="http://schema.org/permitAudience"></see></summary>
    let permitAudience = _prefix "permitAudience"
    /// <summary>
    /// Indications regarding the permitted usage of the accommodation.
    /// <see href="http://schema.org/permittedUsage"></see></summary>
    let permittedUsage = _prefix "permittedUsage"
    /// <summary>
    /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
    /// <see href="http://schema.org/petsAllowed"></see></summary>
    let petsAllowed = _prefix "petsAllowed"
    /// <summary>
    /// A photograph of this place.
    /// <see href="http://schema.org/photo"></see></summary>
    let photo = _prefix "photo"
    /// <summary>
    /// Photographs of this place.
    /// <see href="http://schema.org/photos"></see></summary>
    let photos = _prefix "photos"
    /// <summary>
    /// Where a taxi will pick up a passenger or a rental car can be picked up.
    /// <see href="http://schema.org/pickupLocation"></see></summary>
    let pickupLocation = _prefix "pickupLocation"
    /// <summary>
    /// When a taxi will pickup a passenger or a rental car can be picked up.
    /// <see href="http://schema.org/pickupTime"></see></summary>
    let pickupTime = _prefix "pickupTime"
    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
    /// <see href="http://schema.org/playMode"></see></summary>
    let playMode = _prefix "playMode"
    /// <summary>
    /// Player type required&amp;#x2014;for example, Flash or Silverlight.
    /// <see href="http://schema.org/playerType"></see></summary>
    let playerType = _prefix "playerType"
    /// <summary>
    /// Number of players on the server.
    /// <see href="http://schema.org/playersOnline"></see></summary>
    let playersOnline = _prefix "playersOnline"
    /// <summary>
    /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
    /// <see href="http://schema.org/polygon"></see></summary>
    let polygon = _prefix "polygon"
    /// <summary>
    /// The post office box number for PO box addresses.
    /// <see href="http://schema.org/postOfficeBoxNumber"></see></summary>
    let postOfficeBoxNumber = _prefix "postOfficeBoxNumber"
    /// <summary>
    /// The postal code. For example, 94043.
    /// <see href="http://schema.org/postalCode"></see></summary>
    let postalCode = _prefix "postalCode"
    /// <summary>
    /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
    /// <see href="http://schema.org/potentialAction"></see></summary>
    let potentialAction = _prefix "potentialAction"
    /// <summary>
    /// A pointer from a previous, often discontinued variant of the product to its newer variant.
    /// <see href="http://schema.org/predecessorOf"></see></summary>
    let predecessorOf = _prefix "predecessorOf"
    /// <summary>
    /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
    /// <see href="http://schema.org/prepTime"></see></summary>
    let prepTime = _prefix "prepTime"
    /// <summary>
    /// A link to the ListItem that preceeds the current one.
    /// <see href="http://schema.org/previousItem"></see></summary>
    let previousItem = _prefix "previousItem"
    /// <summary>
    /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
    /// <see href="http://schema.org/previousStartDate"></see></summary>
    let previousStartDate = _prefix "previousStartDate"
    /// <summary>
    /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use the &lt;a class="localLink" href="http://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR") instead of including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/price"></see></summary>
    let price = _prefix "price"
    /// <summary>
    /// This property links to all &lt;a class="localLink" href="http://schema.org/UnitPriceSpecification"&gt;UnitPriceSpecification&lt;/a&gt; nodes that apply in parallel for the &lt;a class="localLink" href="http://schema.org/CompoundPriceSpecification"&gt;CompoundPriceSpecification&lt;/a&gt; node.
    /// <see href="http://schema.org/priceComponent"></see></summary>
    let priceComponent = _prefix "priceComponent"
    /// <summary>
    /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
    /// <see href="http://schema.org/priceCurrency"></see></summary>
    let priceCurrency = _prefix "priceCurrency"
    /// <summary>
    /// The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.
    /// <see href="http://schema.org/priceRange"></see></summary>
    let priceRange = _prefix "priceRange"
    /// <summary>
    /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
    /// <see href="http://schema.org/priceSpecification"></see></summary>
    let priceSpecification = _prefix "priceSpecification"
    /// <summary>
    /// A short text or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.
    /// <see href="http://schema.org/priceType"></see></summary>
    let priceType = _prefix "priceType"
    /// <summary>
    /// The date after which the price is no longer available.
    /// <see href="http://schema.org/priceValidUntil"></see></summary>
    let priceValidUntil = _prefix "priceValidUntil"
    /// <summary>
    /// Indicates the main image on the page.
    /// <see href="http://schema.org/primaryImageOfPage"></see></summary>
    let primaryImageOfPage = _prefix "primaryImageOfPage"
    /// <summary>
    /// The number of the column in which the NewsArticle appears in the print edition.
    /// <see href="http://schema.org/printColumn"></see></summary>
    let printColumn = _prefix "printColumn"
    /// <summary>
    /// The edition of the print product in which the NewsArticle appears.
    /// <see href="http://schema.org/printEdition"></see></summary>
    let printEdition = _prefix "printEdition"
    /// <summary>
    /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
    /// <see href="http://schema.org/printPage"></see></summary>
    let printPage = _prefix "printPage"
    /// <summary>
    /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
    /// <see href="http://schema.org/printSection"></see></summary>
    let printSection = _prefix "printSection"
    /// <summary>
    /// Estimated processing time for the service using this channel.
    /// <see href="http://schema.org/processingTime"></see></summary>
    let processingTime = _prefix "processingTime"
    /// <summary>
    /// Processor architecture required to run the application (e.g. IA64).
    /// <see href="http://schema.org/processorRequirements"></see></summary>
    let processorRequirements = _prefix "processorRequirements"
    /// <summary>
    /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
    /// <see href="http://schema.org/producer"></see></summary>
    let producer = _prefix "producer"
    /// <summary>
    /// The tangible thing generated by the service, e.g. a passport, permit, etc.
    /// <see href="http://schema.org/produces"></see></summary>
    let produces = _prefix "produces"
    /// <summary>
    /// The tangible thing generated by the service, e.g. a passport, permit, etc.
    /// <see href="http://schema.org/serviceOutput"></see></summary>
    let serviceOutput = _prefix "serviceOutput"
    /// <summary>
    /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
    /// <see href="http://schema.org/productID"></see></summary>
    let productID = _prefix "productID"
    /// <summary>
    /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
    /// <see href="http://schema.org/productSupported"></see></summary>
    let productSupported = _prefix "productSupported"
    /// <summary>
    /// The production company or studio responsible for the item e.g. series, video game, episode etc.
    /// <see href="http://schema.org/productionCompany"></see></summary>
    let productionCompany = _prefix "productionCompany"
    /// <summary>
    /// The date of production of the item, e.g. vehicle.
    /// <see href="http://schema.org/productionDate"></see></summary>
    let productionDate = _prefix "productionDate"
    /// <summary>
    /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
    /// <see href="http://schema.org/proficiencyLevel"></see></summary>
    let proficiencyLevel = _prefix "proficiencyLevel"
    /// <summary>
    /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
    /// <see href="http://schema.org/programMembershipUsed"></see></summary>
    let programMembershipUsed = _prefix "programMembershipUsed"
    /// <summary>
    /// The program providing the membership.
    /// <see href="http://schema.org/programName"></see></summary>
    let programName = _prefix "programName"
    /// <summary>
    /// The computer programming language.
    /// <see href="http://schema.org/programmingLanguage"></see></summary>
    let programmingLanguage = _prefix "programmingLanguage"
    /// <summary>
    /// Indicates whether API is managed or unmanaged.
    /// <see href="http://schema.org/programmingModel"></see></summary>
    let programmingModel = _prefix "programmingModel"
    /// <summary>
    /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
    /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
    /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
    /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
    /// <see href="http://schema.org/propertyID"></see></summary>
    let propertyID = _prefix "propertyID"
    /// <summary>
    /// The number of grams of protein.
    /// <see href="http://schema.org/proteinContent"></see></summary>
    let proteinContent = _prefix "proteinContent"
    /// <summary>
    /// Indicates the mobility of a provided service (e.g. 'static', 'dynamic').
    /// <see href="http://schema.org/providerMobility"></see></summary>
    let providerMobility = _prefix "providerMobility"
    /// <summary>
    /// The service provided by this channel.
    /// <see href="http://schema.org/providesService"></see></summary>
    let providesService = _prefix "providesService"
    /// <summary>
    /// A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
    /// <see href="http://schema.org/publicAccess"></see></summary>
    let publicAccess = _prefix "publicAccess"
    /// <summary>
    /// A publication event associated with the item.
    /// <see href="http://schema.org/publication"></see></summary>
    let publication = _prefix "publication"
    /// <summary>
    /// A broadcast service associated with the publication event.
    /// <see href="http://schema.org/publishedOn"></see></summary>
    let publishedOn = _prefix "publishedOn"
    /// <summary>
    /// The publisher of the creative work.
    /// <see href="http://schema.org/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
    /// <see href="http://schema.org/publishingPrinciples"></see></summary>
    let publishingPrinciples = _prefix "publishingPrinciples"
    /// <summary>
    /// The date the item e.g. vehicle was purchased by the current owner.
    /// <see href="http://schema.org/purchaseDate"></see></summary>
    let purchaseDate = _prefix "purchaseDate"
    /// <summary>
    /// A sub property of instrument. The query used on this action.
    /// <see href="http://schema.org/query"></see></summary>
    let query = _prefix "query"
    /// <summary>
    /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
    /// <see href="http://schema.org/quest"></see></summary>
    let quest = _prefix "quest"
    /// <summary>
    /// A sub property of object. A question.
    /// <see href="http://schema.org/question"></see></summary>
    let question = _prefix "question"
    /// <summary>
    /// The count of total number of ratings.
    /// <see href="http://schema.org/ratingCount"></see></summary>
    let ratingCount = _prefix "ratingCount"
    /// <summary>
    /// The rating for the content.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/ratingValue"></see></summary>
    let ratingValue = _prefix "ratingValue"
    /// <summary>
    /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
    /// <see href="http://schema.org/readonlyValue"></see></summary>
    let readonlyValue = _prefix "readonlyValue"
    /// <summary>
    /// A sub property of participant. The real estate agent involved in the action.
    /// <see href="http://schema.org/realEstateAgent"></see></summary>
    let realEstateAgent = _prefix "realEstateAgent"
    /// <summary>
    /// A sub property of instrument. The recipe/instructions used to perform the action.
    /// <see href="http://schema.org/recipe"></see></summary>
    let recipe = _prefix "recipe"
    /// <summary>
    /// The category of the recipe—for example, appetizer, entree, etc.
    /// <see href="http://schema.org/recipeCategory"></see></summary>
    let recipeCategory = _prefix "recipeCategory"
    /// <summary>
    /// The cuisine of the recipe (for example, French or Ethiopian).
    /// <see href="http://schema.org/recipeCuisine"></see></summary>
    let recipeCuisine = _prefix "recipeCuisine"
    /// <summary>
    /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
    /// <see href="http://schema.org/recipeInstructions"></see></summary>
    let recipeInstructions = _prefix "recipeInstructions"
    /// <summary>
    /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection.
    /// <see href="http://schema.org/step"></see></summary>
    let step = _prefix "step"
    /// <summary>
    /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
    /// <see href="http://schema.org/recipeYield"></see></summary>
    let recipeYield = _prefix "recipeYield"
    /// <summary>
    /// The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
    /// <see href="http://schema.org/yield"></see></summary>
    let yield_ = _prefix "yield"
    /// <summary>
    /// The label that issued the release.
    /// <see href="http://schema.org/recordLabel"></see></summary>
    let recordLabel = _prefix "recordLabel"
    /// <summary>
    /// An audio recording of the work.
    /// <see href="http://schema.org/recordedAs"></see></summary>
    let recordedAs = _prefix "recordedAs"
    /// <summary>
    /// The composition this track is a recording of.
    /// <see href="http://schema.org/recordingOf"></see></summary>
    let recordingOf = _prefix "recordingOf"
    /// <summary>
    /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
    /// <see href="http://schema.org/recordedAt"></see></summary>
    let recordedAt = _prefix "recordedAt"
    /// <summary>
    /// The CreativeWork that captured all or part of this Event.
    /// <see href="http://schema.org/recordedIn"></see></summary>
    let recordedIn = _prefix "recordedIn"
    /// <summary>
    /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
    /// <see href="http://schema.org/referenceQuantity"></see></summary>
    let referenceQuantity = _prefix "referenceQuantity"
    /// <summary>
    /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
    /// <see href="http://schema.org/referencesOrder"></see></summary>
    let referencesOrder = _prefix "referencesOrder"
    /// <summary>
    /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.
    /// <see href="http://schema.org/regionsAllowed"></see></summary>
    let regionsAllowed = _prefix "regionsAllowed"
    /// <summary>
    /// A link related to this web page, for example to other related web pages.
    /// <see href="http://schema.org/relatedLink"></see></summary>
    let relatedLink = _prefix "relatedLink"
    /// <summary>
    /// The most generic familial relation.
    /// <see href="http://schema.org/relatedTo"></see></summary>
    let relatedTo = _prefix "relatedTo"
    /// <summary>
    /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
    /// <see href="http://schema.org/releaseDate"></see></summary>
    let releaseDate = _prefix "releaseDate"
    /// <summary>
    /// Description of what changed in this version.
    /// <see href="http://schema.org/releaseNotes"></see></summary>
    let releaseNotes = _prefix "releaseNotes"
    /// <summary>
    /// The place and time the release was issued, expressed as a PublicationEvent.
    /// <see href="http://schema.org/releasedEvent"></see></summary>
    let releasedEvent = _prefix "releasedEvent"
    /// <summary>
    /// The Occupation for the JobPosting.
    /// <see href="http://schema.org/relevantOccupation"></see></summary>
    let relevantOccupation = _prefix "relevantOccupation"
    /// <summary>
    /// The number of attendee places for an event that remain unallocated.
    /// <see href="http://schema.org/remainingAttendeeCapacity"></see></summary>
    let remainingAttendeeCapacity = _prefix "remainingAttendeeCapacity"
    /// <summary>
    /// A sub property of object. The object that is being replaced.
    /// <see href="http://schema.org/replacee"></see></summary>
    let replacee = _prefix "replacee"
    /// <summary>
    /// A sub property of object. The object that replaces.
    /// <see href="http://schema.org/replacer"></see></summary>
    let replacer = _prefix "replacer"
    /// <summary>
    /// The URL at which a reply may be posted to the specified UserComment.
    /// <see href="http://schema.org/replyToUrl"></see></summary>
    let replyToUrl = _prefix "replyToUrl"
    /// <summary>
    /// The number or other unique designator assigned to a Report by the publishing organization.
    /// <see href="http://schema.org/reportNumber"></see></summary>
    let reportNumber = _prefix "reportNumber"
    /// <summary>
    /// Indicates whether this image is representative of the content of the page.
    /// <see href="http://schema.org/representativeOfPage"></see></summary>
    let representativeOfPage = _prefix "representativeOfPage"
    /// <summary>
    /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
    /// <see href="http://schema.org/requiredCollateral"></see></summary>
    let requiredCollateral = _prefix "requiredCollateral"
    /// <summary>
    /// Audiences defined by a person's gender.
    /// <see href="http://schema.org/requiredGender"></see></summary>
    let requiredGender = _prefix "requiredGender"
    /// <summary>
    /// Audiences defined by a person's maximum age.
    /// <see href="http://schema.org/requiredMaxAge"></see></summary>
    let requiredMaxAge = _prefix "requiredMaxAge"
    /// <summary>
    /// Audiences defined by a person's minimum age.
    /// <see href="http://schema.org/requiredMinAge"></see></summary>
    let requiredMinAge = _prefix "requiredMinAge"
    /// <summary>
    /// The required quantity of the item(s).
    /// <see href="http://schema.org/requiredQuantity"></see></summary>
    let requiredQuantity = _prefix "requiredQuantity"
    /// <summary>
    /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
    /// <see href="http://schema.org/requirements"></see></summary>
    let requirements = _prefix "requirements"
    /// <summary>
    /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
    /// <see href="http://schema.org/softwareRequirements"></see></summary>
    let softwareRequirements = _prefix "softwareRequirements"
    /// <summary>
    /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
    /// <see href="http://schema.org/requiresSubscription"></see></summary>
    let requiresSubscription = _prefix "requiresSubscription"
    /// <summary>
    /// The thing -- flight, event, restaurant,etc. being reserved.
    /// <see href="http://schema.org/reservationFor"></see></summary>
    let reservationFor = _prefix "reservationFor"
    /// <summary>
    /// A unique identifier for the reservation.
    /// <see href="http://schema.org/reservationId"></see></summary>
    let reservationId = _prefix "reservationId"
    /// <summary>
    /// The current status of the reservation.
    /// <see href="http://schema.org/reservationStatus"></see></summary>
    let reservationStatus = _prefix "reservationStatus"
    /// <summary>
    /// A ticket associated with the reservation.
    /// <see href="http://schema.org/reservedTicket"></see></summary>
    let reservedTicket = _prefix "reservedTicket"
    /// <summary>
    /// Responsibilities associated with this role or Occupation.
    /// <see href="http://schema.org/responsibilities"></see></summary>
    let responsibilities = _prefix "responsibilities"
    /// <summary>
    /// The result produced in the action. e.g. John wrote &lt;em&gt;a book&lt;/em&gt;.
    /// <see href="http://schema.org/result"></see></summary>
    let result = _prefix "result"
    /// <summary>
    /// A sub property of result. The Comment created or sent as a result of this action.
    /// <see href="http://schema.org/resultComment"></see></summary>
    let resultComment = _prefix "resultComment"
    /// <summary>
    /// A sub property of result. The review that resulted in the performing of the action.
    /// <see href="http://schema.org/resultReview"></see></summary>
    let resultReview = _prefix "resultReview"
    /// <summary>
    /// A review of the item.
    /// <see href="http://schema.org/review"></see></summary>
    let review = _prefix "review"
    /// <summary>
    /// This Review or Rating is relevant to this part or facet of the itemReviewed.
    /// <see href="http://schema.org/reviewAspect"></see></summary>
    let reviewAspect = _prefix "reviewAspect"
    /// <summary>
    ///   <see href="http://schema.org/Guide"></see>
    /// </summary>
    let Guide = _prefix "Guide"
    /// <summary>
    /// The actual body of the review.
    /// <see href="http://schema.org/reviewBody"></see></summary>
    let reviewBody = _prefix "reviewBody"
    /// <summary>
    /// The count of total number of reviews.
    /// <see href="http://schema.org/reviewCount"></see></summary>
    let reviewCount = _prefix "reviewCount"
    /// <summary>
    /// The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="http://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.
    /// <see href="http://schema.org/reviewRating"></see></summary>
    let reviewRating = _prefix "reviewRating"
    /// <summary>
    /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
    /// <see href="http://schema.org/reviewedBy"></see></summary>
    let reviewedBy = _prefix "reviewedBy"
    /// <summary>
    /// Review of the item.
    /// <see href="http://schema.org/reviews"></see></summary>
    let reviews = _prefix "reviews"
    /// <summary>
    /// The response (yes, no, maybe) to the RSVP.
    /// <see href="http://schema.org/rsvpResponse"></see></summary>
    let rsvpResponse = _prefix "rsvpResponse"
    /// <summary>
    /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
    /// <see href="http://schema.org/runtime"></see></summary>
    let runtime = _prefix "runtime"
    /// <summary>
    /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
    /// <see href="http://schema.org/runtimePlatform"></see></summary>
    let runtimePlatform = _prefix "runtimePlatform"
    /// <summary>
    /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
    /// <see href="http://schema.org/salaryCurrency"></see></summary>
    let salaryCurrency = _prefix "salaryCurrency"
    /// <summary>
    /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
    /// <see href="http://schema.org/sampleType"></see></summary>
    let sampleType = _prefix "sampleType"
    /// <summary>
    /// The number of grams of saturated fat.
    /// <see href="http://schema.org/saturatedFatContent"></see></summary>
    let saturatedFatContent = _prefix "saturatedFatContent"
    /// <summary>
    /// The date the invoice is scheduled to be paid.
    /// <see href="http://schema.org/scheduledPaymentDate"></see></summary>
    let scheduledPaymentDate = _prefix "scheduledPaymentDate"
    /// <summary>
    /// The time the object is scheduled to.
    /// <see href="http://schema.org/scheduledTime"></see></summary>
    let scheduledTime = _prefix "scheduledTime"
    /// <summary>
    /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
    /// <see href="http://schema.org/schemaVersion"></see></summary>
    let schemaVersion = _prefix "schemaVersion"
    /// <summary>
    /// The number of screens in the movie theater.
    /// <see href="http://schema.org/screenCount"></see></summary>
    let screenCount = _prefix "screenCount"
    /// <summary>
    /// A link to a screenshot image of the app.
    /// <see href="http://schema.org/screenshot"></see></summary>
    let screenshot = _prefix "screenshot"
    /// <summary>
    /// A season in a media series.
    /// <see href="http://schema.org/season"></see></summary>
    let season = _prefix "season"
    /// <summary>
    /// Position of the season within an ordered group of seasons.
    /// <see href="http://schema.org/seasonNumber"></see></summary>
    let seasonNumber = _prefix "seasonNumber"
    /// <summary>
    /// A season in a media series.
    /// <see href="http://schema.org/seasons"></see></summary>
    let seasons = _prefix "seasons"
    /// <summary>
    /// The location of the reserved seat (e.g., 27).
    /// <see href="http://schema.org/seatNumber"></see></summary>
    let seatNumber = _prefix "seatNumber"
    /// <summary>
    /// The row location of the reserved seat (e.g., B).
    /// <see href="http://schema.org/seatRow"></see></summary>
    let seatRow = _prefix "seatRow"
    /// <summary>
    /// The section location of the reserved seat (e.g. Orchestra).
    /// <see href="http://schema.org/seatSection"></see></summary>
    let seatSection = _prefix "seatSection"
    /// <summary>
    /// The type/class of the seat.
    /// <see href="http://schema.org/seatingType"></see></summary>
    let seatingType = _prefix "seatingType"
    /// <summary>
    /// The type of security screening the passenger is subject to.
    /// <see href="http://schema.org/securityScreening"></see></summary>
    let securityScreening = _prefix "securityScreening"
    /// <summary>
    /// A pointer to products or services sought by the organization or person (demand).
    /// <see href="http://schema.org/seeks"></see></summary>
    let seeks = _prefix "seeks"
    /// <summary>
    /// A sub property of participant. The participant who is at the sending end of the action.
    /// <see href="http://schema.org/sender"></see></summary>
    let sender = _prefix "sender"
    /// <summary>
    /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
    /// <see href="http://schema.org/serialNumber"></see></summary>
    let serialNumber = _prefix "serialNumber"
    /// <summary>
    /// Status of a game server.
    /// <see href="http://schema.org/serverStatus"></see></summary>
    let serverStatus = _prefix "serverStatus"
    /// <summary>
    /// The cuisine of the restaurant.
    /// <see href="http://schema.org/servesCuisine"></see></summary>
    let servesCuisine = _prefix "servesCuisine"
    /// <summary>
    /// The audience eligible for this service.
    /// <see href="http://schema.org/serviceAudience"></see></summary>
    let serviceAudience = _prefix "serviceAudience"
    /// <summary>
    /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
    /// <see href="http://schema.org/serviceLocation"></see></summary>
    let serviceLocation = _prefix "serviceLocation"
    /// <summary>
    /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
    /// <see href="http://schema.org/serviceOperator"></see></summary>
    let serviceOperator = _prefix "serviceOperator"
    /// <summary>
    /// The phone number to use to access the service.
    /// <see href="http://schema.org/servicePhone"></see></summary>
    let servicePhone = _prefix "servicePhone"
    /// <summary>
    /// The address for accessing the service by mail.
    /// <see href="http://schema.org/servicePostalAddress"></see></summary>
    let servicePostalAddress = _prefix "servicePostalAddress"
    /// <summary>
    /// The number to access the service by text message.
    /// <see href="http://schema.org/serviceSmsNumber"></see></summary>
    let serviceSmsNumber = _prefix "serviceSmsNumber"
    /// <summary>
    /// The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
    /// <see href="http://schema.org/serviceType"></see></summary>
    let serviceType = _prefix "serviceType"
    /// <summary>
    /// The website to access the service.
    /// <see href="http://schema.org/serviceUrl"></see></summary>
    let serviceUrl = _prefix "serviceUrl"
    /// <summary>
    /// The serving size, in terms of the number of volume or mass.
    /// <see href="http://schema.org/servingSize"></see></summary>
    let servingSize = _prefix "servingSize"
    /// <summary>
    /// A CreativeWork such as an image, video, or audio clip shared as part of this posting.
    /// <see href="http://schema.org/sharedContent"></see></summary>
    let sharedContent = _prefix "sharedContent"
    /// <summary>
    /// A sibling of the person.
    /// <see href="http://schema.org/sibling"></see></summary>
    let sibling = _prefix "sibling"
    /// <summary>
    /// A sibling of the person.
    /// <see href="http://schema.org/siblings"></see></summary>
    let siblings = _prefix "siblings"
    /// <summary>
    /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
    /// <see href="http://schema.org/significantLink"></see></summary>
    let significantLink = _prefix "significantLink"
    /// <summary>
    /// The most significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
    /// <see href="http://schema.org/significantLinks"></see></summary>
    let significantLinks = _prefix "significantLinks"
    /// <summary>
    /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.
    /// <see href="http://schema.org/skills"></see></summary>
    let skills = _prefix "skills"
    /// <summary>
    /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
    /// <see href="http://schema.org/sku"></see></summary>
    let sku = _prefix "sku"
    /// <summary>
    /// A slogan or motto associated with the item.
    /// <see href="http://schema.org/slogan"></see></summary>
    let slogan = _prefix "slogan"
    /// <summary>
    /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
    /// <see href="http://schema.org/smokingAllowed"></see></summary>
    let smokingAllowed = _prefix "smokingAllowed"
    /// <summary>
    /// The number of milligrams of sodium.
    /// <see href="http://schema.org/sodiumContent"></see></summary>
    let sodiumContent = _prefix "sodiumContent"
    /// <summary>
    /// Additional content for a software application.
    /// <see href="http://schema.org/softwareAddOn"></see></summary>
    let softwareAddOn = _prefix "softwareAddOn"
    /// <summary>
    /// Software application help.
    /// <see href="http://schema.org/softwareHelp"></see></summary>
    let softwareHelp = _prefix "softwareHelp"
    /// <summary>
    /// Version of the software instance.
    /// <see href="http://schema.org/softwareVersion"></see></summary>
    let softwareVersion = _prefix "softwareVersion"
    /// <summary>
    /// The Organization on whose behalf the creator was working.
    /// <see href="http://schema.org/sourceOrganization"></see></summary>
    let sourceOrganization = _prefix "sourceOrganization"
    /// <summary>
    /// The "spatial" property can be used in cases when more specific properties
    /// (e.g. &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/spatialCoverage"&gt;spatialCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;) are not known to be appropriate.
    /// <see href="http://schema.org/spatial"></see></summary>
    let spatial = _prefix "spatial"
    /// <summary>
    /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
    ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
    ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
    /// <see href="http://schema.org/spatialCoverage"></see></summary>
    let spatialCoverage = _prefix "spatialCoverage"
    /// <summary>
    /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;br/&gt;&lt;br/&gt;
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
    /// we define a supporting type, &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.
    /// <see href="http://schema.org/speakable"></see></summary>
    let speakable = _prefix "speakable"
    /// <summary>
    /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
    /// <see href="http://schema.org/specialCommitments"></see></summary>
    let specialCommitments = _prefix "specialCommitments"
    /// <summary>
    /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
    /// <see href="http://schema.org/specialOpeningHoursSpecification"></see></summary>
    let specialOpeningHoursSpecification = _prefix "specialOpeningHoursSpecification"
    /// <summary>
    /// One of the domain specialities to which this web page's content applies.
    /// <see href="http://schema.org/specialty"></see></summary>
    let specialty = _prefix "specialty"
    /// <summary>
    ///   <see href="http://schema.org/MedicalStudy"></see>
    /// </summary>
    let MedicalStudy = _prefix "MedicalStudy"
    /// <summary>
    ///   <see href="http://schema.org/Grant"></see>
    /// </summary>
    let Grant = _prefix "Grant"
    /// <summary>
    /// A sub property of location. The sports activity location where this action occurred.
    /// <see href="http://schema.org/sportsActivityLocation"></see></summary>
    let sportsActivityLocation = _prefix "sportsActivityLocation"
    /// <summary>
    /// A sub property of location. The sports event where this action occurred.
    /// <see href="http://schema.org/sportsEvent"></see></summary>
    let sportsEvent = _prefix "sportsEvent"
    /// <summary>
    /// A sub property of participant. The sports team that participated on this action.
    /// <see href="http://schema.org/sportsTeam"></see></summary>
    let sportsTeam = _prefix "sportsTeam"
    /// <summary>
    /// The person's spouse.
    /// <see href="http://schema.org/spouse"></see></summary>
    let spouse = _prefix "spouse"
    /// <summary>
    /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
    /// <see href="http://schema.org/starRating"></see></summary>
    let starRating = _prefix "starRating"
    /// <summary>
    /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
    /// <see href="http://schema.org/startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
    /// <see href="http://schema.org/startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// The position of the steering wheel or similar device (mostly for cars).
    /// <see href="http://schema.org/steeringPosition"></see></summary>
    let steeringPosition = _prefix "steeringPosition"
    /// <summary>
    /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
    /// <see href="http://schema.org/stepValue"></see></summary>
    let stepValue = _prefix "stepValue"
    /// <summary>
    /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection (originally misnamed 'steps'; 'step' is preferred).
    /// <see href="http://schema.org/steps"></see></summary>
    let steps = _prefix "steps"
    /// <summary>
    /// Storage requirements (free space required).
    /// <see href="http://schema.org/storageRequirements"></see></summary>
    let storageRequirements = _prefix "storageRequirements"
    /// <summary>
    /// The street address. For example, 1600 Amphitheatre Pkwy.
    /// <see href="http://schema.org/streetAddress"></see></summary>
    let streetAddress = _prefix "streetAddress"
    /// <summary>
    /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
    /// <see href="http://schema.org/subEvent"></see></summary>
    let subEvent = _prefix "subEvent"
    /// <summary>
    /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
    /// <see href="http://schema.org/superEvent"></see></summary>
    let superEvent = _prefix "superEvent"
    /// <summary>
    /// Events that are a part of this event. For example, a conference event includes many presentations, each subEvents of the conference.
    /// <see href="http://schema.org/subEvents"></see></summary>
    let subEvents = _prefix "subEvents"
    /// <summary>
    /// The individual reservations included in the package. Typically a repeated property.
    /// <see href="http://schema.org/subReservation"></see></summary>
    let subReservation = _prefix "subReservation"
    /// <summary>
    /// A pointer from a newer variant of a product  to its previous, often discontinued predecessor.
    /// <see href="http://schema.org/successorOf"></see></summary>
    let successorOf = _prefix "successorOf"
    /// <summary>
    /// The number of grams of sugar.
    /// <see href="http://schema.org/sugarContent"></see></summary>
    let sugarContent = _prefix "sugarContent"
    /// <summary>
    /// The gender of the person or audience.
    /// <see href="http://schema.org/suggestedGender"></see></summary>
    let suggestedGender = _prefix "suggestedGender"
    /// <summary>
    /// Maximal age recommended for viewing content.
    /// <see href="http://schema.org/suggestedMaxAge"></see></summary>
    let suggestedMaxAge = _prefix "suggestedMaxAge"
    /// <summary>
    /// Minimal age recommended for viewing content.
    /// <see href="http://schema.org/suggestedMinAge"></see></summary>
    let suggestedMinAge = _prefix "suggestedMinAge"
    /// <summary>
    /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
    /// <see href="http://schema.org/suitableForDiet"></see></summary>
    let suitableForDiet = _prefix "suitableForDiet"
    /// <summary>
    /// Supporting data for a SoftwareApplication.
    /// <see href="http://schema.org/supportingData"></see></summary>
    let supportingData = _prefix "supportingData"
    /// <summary>
    /// A material used as a surface in some artwork, e.g. Canvas, Paper, Wood, Board, etc.
    /// <see href="http://schema.org/surface"></see></summary>
    let surface = _prefix "surface"
    /// <summary>
    /// Indicates a target EntryPoint for an Action.
    /// <see href="http://schema.org/target"></see></summary>
    let target = _prefix "target"
    /// <summary>
    /// The description of a node in an established educational framework.
    /// <see href="http://schema.org/targetDescription"></see></summary>
    let targetDescription = _prefix "targetDescription"
    /// <summary>
    /// The name of a node in an established educational framework.
    /// <see href="http://schema.org/targetName"></see></summary>
    let targetName = _prefix "targetName"
    /// <summary>
    /// Type of app development: phone, Metro style, desktop, XBox, etc.
    /// <see href="http://schema.org/targetPlatform"></see></summary>
    let targetPlatform = _prefix "targetPlatform"
    /// <summary>
    /// Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.
    /// <see href="http://schema.org/targetProduct"></see></summary>
    let targetProduct = _prefix "targetProduct"
    /// <summary>
    /// The URL of a node in an established educational framework.
    /// <see href="http://schema.org/targetUrl"></see></summary>
    let targetUrl = _prefix "targetUrl"
    /// <summary>
    /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
    /// <see href="http://schema.org/taxID"></see></summary>
    let taxID = _prefix "taxID"
    /// <summary>
    /// The telephone number.
    /// <see href="http://schema.org/telephone"></see></summary>
    let telephone = _prefix "telephone"
    /// <summary>
    /// The "temporal" property can be used in cases where more specific properties
    /// (e.g. &lt;a class="localLink" href="http://schema.org/temporalCoverage"&gt;temporalCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateCreated"&gt;dateCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateModified"&gt;dateModified&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/datePublished"&gt;datePublished&lt;/a&gt;) are not known to be appropriate.
    /// <see href="http://schema.org/temporal"></see></summary>
    let temporal = _prefix "temporal"
    /// <summary>
    /// The textual content of this CreativeWork.
    /// <see href="http://schema.org/text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// Thumbnail image for an image or video.
    /// <see href="http://schema.org/thumbnail"></see></summary>
    let thumbnail = _prefix "thumbnail"
    /// <summary>
    /// A thumbnail image relevant to the Thing.
    /// <see href="http://schema.org/thumbnailUrl"></see></summary>
    let thumbnailUrl = _prefix "thumbnailUrl"
    /// <summary>
    /// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we recommend using the controlled vocabulary of Market Identifier Codes (MIC) specified in ISO15022.
    /// <see href="http://schema.org/tickerSymbol"></see></summary>
    let tickerSymbol = _prefix "tickerSymbol"
    /// <summary>
    /// The unique identifier for the ticket.
    /// <see href="http://schema.org/ticketNumber"></see></summary>
    let ticketNumber = _prefix "ticketNumber"
    /// <summary>
    /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
    /// <see href="http://schema.org/ticketToken"></see></summary>
    let ticketToken = _prefix "ticketToken"
    /// <summary>
    /// The seat associated with the ticket.
    /// <see href="http://schema.org/ticketedSeat"></see></summary>
    let ticketedSeat = _prefix "ticketedSeat"
    /// <summary>
    /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'PT30M', 'PT1H25M'.
    /// <see href="http://schema.org/timeRequired"></see></summary>
    let timeRequired = _prefix "timeRequired"
    /// <summary>
    /// The title of the job.
    /// <see href="http://schema.org/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// A sub property of location. The final location of the object or the agent after the action.
    /// <see href="http://schema.org/toLocation"></see></summary>
    let toLocation = _prefix "toLocation"
    /// <summary>
    /// A sub property of recipient. The recipient who was directly sent the message.
    /// <see href="http://schema.org/toRecipient"></see></summary>
    let toRecipient = _prefix "toRecipient"
    /// <summary>
    /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
    /// <see href="http://schema.org/tool"></see></summary>
    let tool = _prefix "tool"
    /// <summary>
    /// The total amount due.
    /// <see href="http://schema.org/totalPaymentDue"></see></summary>
    let totalPaymentDue = _prefix "totalPaymentDue"
    /// <summary>
    /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/totalPrice"></see></summary>
    let totalPrice = _prefix "totalPrice"
    /// <summary>
    /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
    /// <see href="http://schema.org/totalTime"></see></summary>
    let totalTime = _prefix "totalTime"
    /// <summary>
    /// Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.
    /// <see href="http://schema.org/touristType"></see></summary>
    let touristType = _prefix "touristType"
    /// <summary>
    ///   <see href="http://schema.org/TouristDestination"></see>
    /// </summary>
    let TouristDestination = _prefix "TouristDestination"
    /// <summary>
    ///   <see href="http://schema.org/TouristTrip"></see>
    /// </summary>
    let TouristTrip = _prefix "TouristTrip"
    /// <summary>
    /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
    /// <see href="http://schema.org/track"></see></summary>
    let track = _prefix "track"
    /// <summary>
    /// Shipper tracking number.
    /// <see href="http://schema.org/trackingNumber"></see></summary>
    let trackingNumber = _prefix "trackingNumber"
    /// <summary>
    /// Tracking url for the parcel delivery.
    /// <see href="http://schema.org/trackingUrl"></see></summary>
    let trackingUrl = _prefix "trackingUrl"
    /// <summary>
    /// A music recording (track)&amp;#x2014;usually a single song.
    /// <see href="http://schema.org/tracks"></see></summary>
    let tracks = _prefix "tracks"
    /// <summary>
    /// The trailer of a movie or tv/radio series, season, episode, etc.
    /// <see href="http://schema.org/trailer"></see></summary>
    let trailer = _prefix "trailer"
    /// <summary>
    /// The name of the train (e.g. The Orient Express).
    /// <see href="http://schema.org/trainName"></see></summary>
    let trainName = _prefix "trainName"
    /// <summary>
    /// The unique identifier for the train.
    /// <see href="http://schema.org/trainNumber"></see></summary>
    let trainNumber = _prefix "trainNumber"
    /// <summary>
    /// The number of grams of trans fat.
    /// <see href="http://schema.org/transFatContent"></see></summary>
    let transFatContent = _prefix "transFatContent"
    /// <summary>
    /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
    /// <see href="http://schema.org/transcript"></see></summary>
    let transcript = _prefix "transcript"
    /// <summary>
    /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
    /// <see href="http://schema.org/translator"></see></summary>
    let translator = _prefix "translator"
    /// <summary>
    /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
    /// <see href="http://schema.org/typeOfBed"></see></summary>
    let typeOfBed = _prefix "typeOfBed"
    /// <summary>
    /// The product that this structured value is referring to.
    /// <see href="http://schema.org/typeOfGood"></see></summary>
    let typeOfGood = _prefix "typeOfGood"
    /// <summary>
    /// The typical expected age range, e.g. '7-9', '11-'.
    /// <see href="http://schema.org/typicalAgeRange"></see></summary>
    let typicalAgeRange = _prefix "typicalAgeRange"
    /// <summary>
    /// The person or organization the reservation or ticket is for.
    /// <see href="http://schema.org/underName"></see></summary>
    let underName = _prefix "underName"
    /// <summary>
    /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
    /// <see href="http://schema.org/unitCode"></see></summary>
    let unitCode = _prefix "unitCode"
    /// <summary>
    /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
    /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
    /// <see href="http://schema.org/unitText"></see></summary>
    let unitText = _prefix "unitText"
    /// <summary>
    /// The number of grams of unsaturated fat.
    /// <see href="http://schema.org/unsaturatedFatContent"></see></summary>
    let unsaturatedFatContent = _prefix "unsaturatedFatContent"
    /// <summary>
    /// Date when this media object was uploaded to this site.
    /// <see href="http://schema.org/uploadDate"></see></summary>
    let uploadDate = _prefix "uploadDate"
    /// <summary>
    /// The number of upvotes this question, answer or comment has received from the community.
    /// <see href="http://schema.org/upvoteCount"></see></summary>
    let upvoteCount = _prefix "upvoteCount"
    /// <summary>
    /// URL of the item.
    /// <see href="http://schema.org/url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// An url template (RFC6570) that will be used to construct the target of the execution of the action.
    /// <see href="http://schema.org/urlTemplate"></see></summary>
    let urlTemplate = _prefix "urlTemplate"
    /// <summary>
    /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
    /// <see href="http://schema.org/userInteractionCount"></see></summary>
    let userInteractionCount = _prefix "userInteractionCount"
    /// <summary>
    /// The duration of validity of a permit or similar thing.
    /// <see href="http://schema.org/validFor"></see></summary>
    let validFor = _prefix "validFor"
    /// <summary>
    /// The date when the item becomes valid.
    /// <see href="http://schema.org/validFrom"></see></summary>
    let validFrom = _prefix "validFrom"
    /// <summary>
    /// The geographic area where a permit or similar thing is valid.
    /// <see href="http://schema.org/validIn"></see></summary>
    let validIn = _prefix "validIn"
    /// <summary>
    /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
    /// <see href="http://schema.org/validThrough"></see></summary>
    let validThrough = _prefix "validThrough"
    /// <summary>
    /// The date when the item is no longer valid.
    /// <see href="http://schema.org/validUntil"></see></summary>
    let validUntil = _prefix "validUntil"
    /// <summary>
    /// The value of the quantitative value or property value node.&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
    /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
    /// <see href="http://schema.org/valueAddedTaxIncluded"></see></summary>
    let valueAddedTaxIncluded = _prefix "valueAddedTaxIncluded"
    /// <summary>
    /// Specifies the allowed range for number of characters in a literal value.
    /// <see href="http://schema.org/valueMaxLength"></see></summary>
    let valueMaxLength = _prefix "valueMaxLength"
    /// <summary>
    /// Specifies the minimum allowed range for number of characters in a literal value.
    /// <see href="http://schema.org/valueMinLength"></see></summary>
    let valueMinLength = _prefix "valueMinLength"
    /// <summary>
    /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
    /// <see href="http://schema.org/valueName"></see></summary>
    let valueName = _prefix "valueName"
    /// <summary>
    /// Specifies a regular expression for testing literal values according to the HTML spec.
    /// <see href="http://schema.org/valuePattern"></see></summary>
    let valuePattern = _prefix "valuePattern"
    /// <summary>
    /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
    /// <see href="http://schema.org/valueReference"></see></summary>
    let valueReference = _prefix "valueReference"
    /// <summary>
    /// Whether the property must be filled in to complete the action.  Default is false.
    /// <see href="http://schema.org/valueRequired"></see></summary>
    let valueRequired = _prefix "valueRequired"
    /// <summary>
    /// The Value-added Tax ID of the organization or person.
    /// <see href="http://schema.org/vatID"></see></summary>
    let vatID = _prefix "vatID"
    /// <summary>
    /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
    /// <see href="http://schema.org/vehicleConfiguration"></see></summary>
    let vehicleConfiguration = _prefix "vehicleConfiguration"
    /// <summary>
    /// Information about the engine or engines of the vehicle.
    /// <see href="http://schema.org/vehicleEngine"></see></summary>
    let vehicleEngine = _prefix "vehicleEngine"
    /// <summary>
    /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
    /// <see href="http://schema.org/vehicleIdentificationNumber"></see></summary>
    let vehicleIdentificationNumber = _prefix "vehicleIdentificationNumber"
    /// <summary>
    /// The color or color combination of the interior of the vehicle.
    /// <see href="http://schema.org/vehicleInteriorColor"></see></summary>
    let vehicleInteriorColor = _prefix "vehicleInteriorColor"
    /// <summary>
    /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
    /// <see href="http://schema.org/vehicleInteriorType"></see></summary>
    let vehicleInteriorType = _prefix "vehicleInteriorType"
    /// <summary>
    /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
    /// <see href="http://schema.org/vehicleModelDate"></see></summary>
    let vehicleModelDate = _prefix "vehicleModelDate"
    /// <summary>
    /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62 for persons.
    /// <see href="http://schema.org/vehicleSeatingCapacity"></see></summary>
    let vehicleSeatingCapacity = _prefix "vehicleSeatingCapacity"
    /// <summary>
    /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
    /// <see href="http://schema.org/vehicleTransmission"></see></summary>
    let vehicleTransmission = _prefix "vehicleTransmission"
    /// <summary>
    /// 'vendor' is an earlier term for 'seller'.
    /// <see href="http://schema.org/vendor"></see></summary>
    let vendor = _prefix "vendor"
    /// <summary>
    /// The version of the CreativeWork embodied by a specified resource.
    /// <see href="http://schema.org/version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// An embedded video object.
    /// <see href="http://schema.org/video"></see></summary>
    let video = _prefix "video"
    /// <summary>
    /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
    /// <see href="http://schema.org/videoFormat"></see></summary>
    let videoFormat = _prefix "videoFormat"
    /// <summary>
    /// The frame size of the video.
    /// <see href="http://schema.org/videoFrameSize"></see></summary>
    let videoFrameSize = _prefix "videoFrameSize"
    /// <summary>
    /// The quality of the video.
    /// <see href="http://schema.org/videoQuality"></see></summary>
    let videoQuality = _prefix "videoQuality"
    /// <summary>
    /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
    /// <see href="http://schema.org/volumeNumber"></see></summary>
    let volumeNumber = _prefix "volumeNumber"
    /// <summary>
    /// The warranty promise(s) included in the offer.
    /// <see href="http://schema.org/warranty"></see></summary>
    let warranty = _prefix "warranty"
    /// <summary>
    /// The warranty promise(s) included in the offer.
    /// <see href="http://schema.org/warrantyPromise"></see></summary>
    let warrantyPromise = _prefix "warrantyPromise"
    /// <summary>
    /// The scope of the warranty promise.
    /// <see href="http://schema.org/warrantyScope"></see></summary>
    let warrantyScope = _prefix "warrantyScope"
    /// <summary>
    /// The time when a passenger can check into the flight online.
    /// <see href="http://schema.org/webCheckinTime"></see></summary>
    let webCheckinTime = _prefix "webCheckinTime"
    /// <summary>
    /// The weight of the product or person.
    /// <see href="http://schema.org/weight"></see></summary>
    let weight = _prefix "weight"
    /// <summary>
    /// The width of the item.
    /// <see href="http://schema.org/width"></see></summary>
    let width = _prefix "width"
    /// <summary>
    /// A sub property of participant. The winner of the action.
    /// <see href="http://schema.org/winner"></see></summary>
    let winner = _prefix "winner"
    /// <summary>
    /// The number of words in the text of the Article.
    /// <see href="http://schema.org/wordCount"></see></summary>
    let wordCount = _prefix "wordCount"
    /// <summary>
    /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
    ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
    /// <see href="http://schema.org/workFeatured"></see></summary>
    let workFeatured = _prefix "workFeatured"
    /// <summary>
    /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
    /// <see href="http://schema.org/workHours"></see></summary>
    let workHours = _prefix "workHours"
    /// <summary>
    /// A contact location for a person's place of work.
    /// <see href="http://schema.org/workLocation"></see></summary>
    let workLocation = _prefix "workLocation"
    /// <summary>
    /// A work performed in some event, for example a play performed in a TheaterEvent.
    /// <see href="http://schema.org/workPerformed"></see></summary>
    let workPerformed = _prefix "workPerformed"
    /// <summary>
    /// The movie presented during this event.
    /// <see href="http://schema.org/workPresented"></see></summary>
    let workPresented = _prefix "workPresented"
    /// <summary>
    /// Organizations that the person works for.
    /// <see href="http://schema.org/worksFor"></see></summary>
    let worksFor = _prefix "worksFor"
    /// <summary>
    /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
    /// <see href="http://schema.org/worstRating"></see></summary>
    let worstRating = _prefix "worstRating"
    /// <summary>
    /// An XPath, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
    /// <see href="http://schema.org/xpath"></see></summary>
    let xpath = _prefix "xpath"
    /// <summary>
    ///   <see href="http://schema.org/XPathType"></see>
    /// </summary>
    let XPathType = _prefix "XPathType"
    /// <summary>
    /// The size of the business in annual revenue.
    /// <see href="http://schema.org/yearlyRevenue"></see></summary>
    let yearlyRevenue = _prefix "yearlyRevenue"
    /// <summary>
    /// The age of the business.
    /// <see href="http://schema.org/yearsInOperation"></see></summary>
    let yearsInOperation = _prefix "yearsInOperation"
