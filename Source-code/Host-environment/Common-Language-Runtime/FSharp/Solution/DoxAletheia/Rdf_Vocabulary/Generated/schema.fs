namespace http.schema.org.slash

open DoxAletheia.Rdf_Vocabulary

module schema =
    let _namespace_name = "http://schema.org/"

    /// <summary>
    /// A radio channel that uses AM.
    /// <see href="http://schema.org/AMRadioChannel"></see></summary>
    let AMRadioChannel =
        Namespaced_IRI.parse _namespace_name "AMRadioChannel" |> NamespacedName

    /// <summary>
    /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
    /// <see href="http://schema.org/category"></see></summary>
    let category = Namespaced_IRI.parse _namespace_name "category" |> NamespacedName

    /// <summary>
    /// A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.
    /// <see href="http://schema.org/RadioChannel"></see></summary>
    let RadioChannel =
        Namespaced_IRI.parse _namespace_name "RadioChannel" |> NamespacedName

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// <see href="http://schema.org/APIReference"></see></summary>
    let APIReference =
        Namespaced_IRI.parse _namespace_name "APIReference" |> NamespacedName

    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// <see href="http://schema.org/TechArticle"></see></summary>
    let TechArticle =
        Namespaced_IRI.parse _namespace_name "TechArticle" |> NamespacedName

    /// <summary>
    /// Web page type: About page.
    /// <see href="http://schema.org/AboutPage"></see></summary>
    let AboutPage = Namespaced_IRI.parse _namespace_name "AboutPage" |> NamespacedName
    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// <see href="http://schema.org/WebPage"></see></summary>
    let WebPage = Namespaced_IRI.parse _namespace_name "WebPage" |> NamespacedName

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
    let AcceptAction =
        Namespaced_IRI.parse _namespace_name "AcceptAction" |> NamespacedName

    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// <see href="http://schema.org/AllocateAction"></see></summary>
    let AllocateAction =
        Namespaced_IRI.parse _namespace_name "AllocateAction" |> NamespacedName

    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Accommodation"></see></summary>
    let Accommodation =
        Namespaced_IRI.parse _namespace_name "Accommodation" |> NamespacedName

    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// <see href="http://schema.org/Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName

    /// <summary>
    /// Accountancy business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// <see href="http://schema.org/AccountingService"></see></summary>
    let AccountingService =
        Namespaced_IRI.parse _namespace_name "AccountingService" |> NamespacedName

    /// <summary>
    /// Financial services business.
    /// <see href="http://schema.org/FinancialService"></see></summary>
    let FinancialService =
        Namespaced_IRI.parse _namespace_name "FinancialService" |> NamespacedName

    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// <see href="http://schema.org/AchieveAction"></see></summary>
    let AchieveAction =
        Namespaced_IRI.parse _namespace_name "AchieveAction" |> NamespacedName

    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/04/announcing-schemaorg-actions.html"&gt;blog post&lt;/a&gt; and &lt;a href="http://schema.org/docs/actions.html"&gt;Actions overview document&lt;/a&gt;.
    /// <see href="http://schema.org/Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// The most generic type of item.
    /// <see href="http://schema.org/Thing"></see></summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName

    /// <summary>
    /// A set of requirements that a must be fulfilled in order to perform an Action.
    /// <see href="http://schema.org/ActionAccessSpecification"></see></summary>
    let ActionAccessSpecification =
        Namespaced_IRI.parse _namespace_name "ActionAccessSpecification" |> NamespacedName

    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
    /// <see href="http://schema.org/Intangible"></see></summary>
    let Intangible = Namespaced_IRI.parse _namespace_name "Intangible" |> NamespacedName

    /// <summary>
    /// The status of an Action.
    /// <see href="http://schema.org/ActionStatusType"></see></summary>
    let ActionStatusType =
        Namespaced_IRI.parse _namespace_name "ActionStatusType" |> NamespacedName

    /// <summary>
    /// Lists or enumerations—for example, a list of cuisines or music genres, etc.
    /// <see href="http://schema.org/Enumeration"></see></summary>
    let Enumeration =
        Namespaced_IRI.parse _namespace_name "Enumeration" |> NamespacedName

    /// <summary>
    /// The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).
    /// <see href="http://schema.org/ActivateAction"></see></summary>
    let ActivateAction =
        Namespaced_IRI.parse _namespace_name "ActivateAction" |> NamespacedName

    /// <summary>
    /// An agent controls a device or application.
    /// <see href="http://schema.org/ControlAction"></see></summary>
    let ControlAction =
        Namespaced_IRI.parse _namespace_name "ControlAction" |> NamespacedName

    /// <summary>
    /// An in-progress action (e.g, while watching the movie, or driving to a location).
    /// <see href="http://schema.org/ActiveActionStatus"></see></summary>
    let ActiveActionStatus =
        Namespaced_IRI.parse _namespace_name "ActiveActionStatus" |> NamespacedName

    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// <see href="http://schema.org/AddAction"></see></summary>
    let AddAction = Namespaced_IRI.parse _namespace_name "AddAction" |> NamespacedName

    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// <see href="http://schema.org/UpdateAction"></see></summary>
    let UpdateAction =
        Namespaced_IRI.parse _namespace_name "UpdateAction" |> NamespacedName

    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// <see href="http://schema.org/AdministrativeArea"></see></summary>
    let AdministrativeArea =
        Namespaced_IRI.parse _namespace_name "AdministrativeArea" |> NamespacedName

    /// <summary>
    /// An adult entertainment establishment.
    /// <see href="http://schema.org/AdultEntertainment"></see></summary>
    let AdultEntertainment =
        Namespaced_IRI.parse _namespace_name "AdultEntertainment" |> NamespacedName

    /// <summary>
    /// A business providing entertainment.
    /// <see href="http://schema.org/EntertainmentBusiness"></see></summary>
    let EntertainmentBusiness =
        Namespaced_IRI.parse _namespace_name "EntertainmentBusiness" |> NamespacedName

    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: AggregateOffers are normally expected to associate multiple offers that all share the same defined &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; value, or default to http://purl.org/goodrelations/v1#Sell if businessFunction is not explicitly defined.
    /// <see href="http://schema.org/AggregateOffer"></see></summary>
    let AggregateOffer =
        Namespaced_IRI.parse _namespace_name "AggregateOffer" |> NamespacedName

    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: As the &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; property, which identifies the form of offer (e.g. sell, lease, repair, dispose), defaults to http://purl.org/goodrelations/v1#Sell; an Offer without a defined businessFunction value can be assumed to be an offer to sell.&lt;br/&gt;&lt;br/&gt;
    ///
    /// For &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GTIN&lt;/a&gt;-related fields, see &lt;a href="http://www.gs1.org/barcodes/support/check_digit_calculator"&gt;Check Digit calculator&lt;/a&gt; and &lt;a href="http://www.gs1us.org/resources/standards/gtin-validation-guide"&gt;validation guide&lt;/a&gt; from &lt;a href="http://www.gs1.org/"&gt;GS1&lt;/a&gt;.
    /// <see href="http://schema.org/Offer"></see></summary>
    let Offer = Namespaced_IRI.parse _namespace_name "Offer" |> NamespacedName

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// <see href="http://schema.org/AggregateRating"></see></summary>
    let AggregateRating =
        Namespaced_IRI.parse _namespace_name "AggregateRating" |> NamespacedName

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// <see href="http://schema.org/Rating"></see></summary>
    let Rating = Namespaced_IRI.parse _namespace_name "Rating" |> NamespacedName

    /// <summary>
    /// The act of expressing a consistency of opinion with the object. An agent agrees to/about an object (a proposition, topic or theme) with participants.
    /// <see href="http://schema.org/AgreeAction"></see></summary>
    let AgreeAction =
        Namespaced_IRI.parse _namespace_name "AgreeAction" |> NamespacedName

    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// <see href="http://schema.org/ReactAction"></see></summary>
    let ReactAction =
        Namespaced_IRI.parse _namespace_name "ReactAction" |> NamespacedName

    /// <summary>
    /// An organization that provides flights for passengers.
    /// <see href="http://schema.org/Airline"></see></summary>
    let Airline = Namespaced_IRI.parse _namespace_name "Airline" |> NamespacedName

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// <see href="http://schema.org/Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// An airport.
    /// <see href="http://schema.org/Airport"></see></summary>
    let Airport = Namespaced_IRI.parse _namespace_name "Airport" |> NamespacedName

    /// <summary>
    /// A public structure, such as a town hall or concert hall.
    /// <see href="http://schema.org/CivicStructure"></see></summary>
    let CivicStructure =
        Namespaced_IRI.parse _namespace_name "CivicStructure" |> NamespacedName

    /// <summary>
    /// AlbumRelease.
    /// <see href="http://schema.org/AlbumRelease"></see></summary>
    let AlbumRelease =
        Namespaced_IRI.parse _namespace_name "AlbumRelease" |> NamespacedName

    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// <see href="http://schema.org/MusicAlbumReleaseType"></see></summary>
    let MusicAlbumReleaseType =
        Namespaced_IRI.parse _namespace_name "MusicAlbumReleaseType" |> NamespacedName

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// <see href="http://schema.org/AlignmentObject"></see></summary>
    let AlignmentObject =
        Namespaced_IRI.parse _namespace_name "AlignmentObject" |> NamespacedName

    /// <summary>
    /// All-wheel Drive is a transmission layout where the engine drives all four wheels.
    /// <see href="http://schema.org/AllWheelDriveConfiguration"></see></summary>
    let AllWheelDriveConfiguration =
        Namespaced_IRI.parse _namespace_name "AllWheelDriveConfiguration" |> NamespacedName

    /// <summary>
    /// A value indicating which roadwheels will receive torque.
    /// <see href="http://schema.org/DriveWheelConfigurationValue"></see></summary>
    let DriveWheelConfigurationValue =
        Namespaced_IRI.parse _namespace_name "DriveWheelConfigurationValue" |> NamespacedName

    /// <summary>
    /// The act of manipulating/administering/supervising/controlling one or more objects.
    /// <see href="http://schema.org/OrganizeAction"></see></summary>
    let OrganizeAction =
        Namespaced_IRI.parse _namespace_name "OrganizeAction" |> NamespacedName

    /// <summary>
    /// An amusement park.
    /// <see href="http://schema.org/AmusementPark"></see></summary>
    let AmusementPark =
        Namespaced_IRI.parse _namespace_name "AmusementPark" |> NamespacedName

    /// <summary>
    /// Animal shelter.
    /// <see href="http://schema.org/AnimalShelter"></see></summary>
    let AnimalShelter =
        Namespaced_IRI.parse _namespace_name "AnimalShelter" |> NamespacedName

    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// <see href="http://schema.org/LocalBusiness"></see></summary>
    let LocalBusiness =
        Namespaced_IRI.parse _namespace_name "LocalBusiness" |> NamespacedName

    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// <see href="http://schema.org/Answer"></see></summary>
    let Answer = Namespaced_IRI.parse _namespace_name "Answer" |> NamespacedName
    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the &lt;a class="localLink" href="http://schema.org/text"&gt;text&lt;/a&gt; property, and its topic via &lt;a class="localLink" href="http://schema.org/about"&gt;about&lt;/a&gt;, properties shared with all CreativeWorks.
    /// <see href="http://schema.org/Comment"></see></summary>
    let Comment = Namespaced_IRI.parse _namespace_name "Comment" |> NamespacedName
    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).
    /// <see href="http://schema.org/Apartment"></see></summary>
    let Apartment = Namespaced_IRI.parse _namespace_name "Apartment" |> NamespacedName

    /// <summary>
    /// Residence type: Apartment complex.
    /// <see href="http://schema.org/ApartmentComplex"></see></summary>
    let ApartmentComplex =
        Namespaced_IRI.parse _namespace_name "ApartmentComplex" |> NamespacedName

    /// <summary>
    /// The place where a person lives.
    /// <see href="http://schema.org/Residence"></see></summary>
    let Residence = Namespaced_IRI.parse _namespace_name "Residence" |> NamespacedName

    /// <summary>
    /// The act of inserting at the end if an ordered collection.
    /// <see href="http://schema.org/AppendAction"></see></summary>
    let AppendAction =
        Namespaced_IRI.parse _namespace_name "AppendAction" |> NamespacedName

    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// <see href="http://schema.org/InsertAction"></see></summary>
    let InsertAction =
        Namespaced_IRI.parse _namespace_name "InsertAction" |> NamespacedName

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
    let ApplyAction =
        Namespaced_IRI.parse _namespace_name "ApplyAction" |> NamespacedName

    /// <summary>
    /// Aquarium.
    /// <see href="http://schema.org/Aquarium"></see></summary>
    let Aquarium = Namespaced_IRI.parse _namespace_name "Aquarium" |> NamespacedName

    /// <summary>
    /// The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.
    /// <see href="http://schema.org/ArriveAction"></see></summary>
    let ArriveAction =
        Namespaced_IRI.parse _namespace_name "ArriveAction" |> NamespacedName

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
    let MoveAction = Namespaced_IRI.parse _namespace_name "MoveAction" |> NamespacedName
    /// <summary>
    /// An art gallery.
    /// <see href="http://schema.org/ArtGallery"></see></summary>
    let ArtGallery = Namespaced_IRI.parse _namespace_name "ArtGallery" |> NamespacedName
    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// <see href="http://schema.org/CreativeWork"></see></summary>
    let CreativeWork =
        Namespaced_IRI.parse _namespace_name "CreativeWork" |> NamespacedName

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
    let AskAction = Namespaced_IRI.parse _namespace_name "AskAction" |> NamespacedName

    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// <see href="http://schema.org/CommunicateAction"></see></summary>
    let CommunicateAction =
        Namespaced_IRI.parse _namespace_name "CommunicateAction" |> NamespacedName

    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// <see href="http://schema.org/AssessAction"></see></summary>
    let AssessAction =
        Namespaced_IRI.parse _namespace_name "AssessAction" |> NamespacedName

    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// <see href="http://schema.org/AssignAction"></see></summary>
    let AssignAction =
        Namespaced_IRI.parse _namespace_name "AssignAction" |> NamespacedName

    /// <summary>
    /// Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    ///
    /// This type is deprecated - &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.
    /// <see href="http://schema.org/Attorney"></see></summary>
    let Attorney = Namespaced_IRI.parse _namespace_name "Attorney" |> NamespacedName

    /// <summary>
    /// A LegalService is a business that provides legally-oriented services, advice and representation, e.g. law firms.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// <see href="http://schema.org/LegalService"></see></summary>
    let LegalService =
        Namespaced_IRI.parse _namespace_name "LegalService" |> NamespacedName

    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// <see href="http://schema.org/Audience"></see></summary>
    let Audience = Namespaced_IRI.parse _namespace_name "Audience" |> NamespacedName

    /// <summary>
    /// An audio file.
    /// <see href="http://schema.org/AudioObject"></see></summary>
    let AudioObject =
        Namespaced_IRI.parse _namespace_name "AudioObject" |> NamespacedName

    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// <see href="http://schema.org/MediaObject"></see></summary>
    let MediaObject =
        Namespaced_IRI.parse _namespace_name "MediaObject" |> NamespacedName

    /// <summary>
    /// Book format: Audiobook. This is an enumerated value for use with the bookFormat property. There is also a type 'Audiobook' in the bib extension which includes Audiobook specific properties.
    /// <see href="http://schema.org/AudiobookFormat"></see></summary>
    let AudiobookFormat =
        Namespaced_IRI.parse _namespace_name "AudiobookFormat" |> NamespacedName

    /// <summary>
    /// The publication format of the book.
    /// <see href="http://schema.org/BookFormatType"></see></summary>
    let BookFormatType =
        Namespaced_IRI.parse _namespace_name "BookFormatType" |> NamespacedName

    /// <summary>
    /// The act of granting permission to an object.
    /// <see href="http://schema.org/AuthorizeAction"></see></summary>
    let AuthorizeAction =
        Namespaced_IRI.parse _namespace_name "AuthorizeAction" |> NamespacedName

    /// <summary>
    /// Auto body shop.
    /// <see href="http://schema.org/AutoBodyShop"></see></summary>
    let AutoBodyShop =
        Namespaced_IRI.parse _namespace_name "AutoBodyShop" |> NamespacedName

    /// <summary>
    /// Car repair, sales, or parts.
    /// <see href="http://schema.org/AutomotiveBusiness"></see></summary>
    let AutomotiveBusiness =
        Namespaced_IRI.parse _namespace_name "AutomotiveBusiness" |> NamespacedName

    /// <summary>
    /// An car dealership.
    /// <see href="http://schema.org/AutoDealer"></see></summary>
    let AutoDealer = Namespaced_IRI.parse _namespace_name "AutoDealer" |> NamespacedName

    /// <summary>
    /// An auto parts store.
    /// <see href="http://schema.org/AutoPartsStore"></see></summary>
    let AutoPartsStore =
        Namespaced_IRI.parse _namespace_name "AutoPartsStore" |> NamespacedName

    /// <summary>
    /// A retail good store.
    /// <see href="http://schema.org/Store"></see></summary>
    let Store = Namespaced_IRI.parse _namespace_name "Store" |> NamespacedName
    /// <summary>
    /// A car rental business.
    /// <see href="http://schema.org/AutoRental"></see></summary>
    let AutoRental = Namespaced_IRI.parse _namespace_name "AutoRental" |> NamespacedName
    /// <summary>
    /// Car repair business.
    /// <see href="http://schema.org/AutoRepair"></see></summary>
    let AutoRepair = Namespaced_IRI.parse _namespace_name "AutoRepair" |> NamespacedName
    /// <summary>
    /// A car wash business.
    /// <see href="http://schema.org/AutoWash"></see></summary>
    let AutoWash = Namespaced_IRI.parse _namespace_name "AutoWash" |> NamespacedName

    /// <summary>
    /// ATM/cash machine.
    /// <see href="http://schema.org/AutomatedTeller"></see></summary>
    let AutomatedTeller =
        Namespaced_IRI.parse _namespace_name "AutomatedTeller" |> NamespacedName

    /// <summary>
    /// A bakery.
    /// <see href="http://schema.org/Bakery"></see></summary>
    let Bakery = Namespaced_IRI.parse _namespace_name "Bakery" |> NamespacedName

    /// <summary>
    /// A food-related business.
    /// <see href="http://schema.org/FoodEstablishment"></see></summary>
    let FoodEstablishment =
        Namespaced_IRI.parse _namespace_name "FoodEstablishment" |> NamespacedName

    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// <see href="http://schema.org/BankAccount"></see></summary>
    let BankAccount =
        Namespaced_IRI.parse _namespace_name "BankAccount" |> NamespacedName

    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// <see href="http://schema.org/FinancialProduct"></see></summary>
    let FinancialProduct =
        Namespaced_IRI.parse _namespace_name "FinancialProduct" |> NamespacedName

    /// <summary>
    /// Bank or credit union.
    /// <see href="http://schema.org/BankOrCreditUnion"></see></summary>
    let BankOrCreditUnion =
        Namespaced_IRI.parse _namespace_name "BankOrCreditUnion" |> NamespacedName

    /// <summary>
    /// A bar or pub.
    /// <see href="http://schema.org/BarOrPub"></see></summary>
    let BarOrPub = Namespaced_IRI.parse _namespace_name "BarOrPub" |> NamespacedName
    /// <summary>
    /// An image of a visual machine-readable code such as a barcode or QR code.
    /// <see href="http://schema.org/Barcode"></see></summary>
    let Barcode = Namespaced_IRI.parse _namespace_name "Barcode" |> NamespacedName

    /// <summary>
    /// An image file.
    /// <see href="http://schema.org/ImageObject"></see></summary>
    let ImageObject =
        Namespaced_IRI.parse _namespace_name "ImageObject" |> NamespacedName

    /// <summary>
    /// Beach.
    /// <see href="http://schema.org/Beach"></see></summary>
    let Beach = Namespaced_IRI.parse _namespace_name "Beach" |> NamespacedName

    /// <summary>
    /// Beauty salon.
    /// <see href="http://schema.org/BeautySalon"></see></summary>
    let BeautySalon =
        Namespaced_IRI.parse _namespace_name "BeautySalon" |> NamespacedName

    /// <summary>
    /// Health and beauty.
    /// <see href="http://schema.org/HealthAndBeautyBusiness"></see></summary>
    let HealthAndBeautyBusiness =
        Namespaced_IRI.parse _namespace_name "HealthAndBeautyBusiness" |> NamespacedName

    /// <summary>
    /// Bed and breakfast.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/BedAndBreakfast"></see></summary>
    let BedAndBreakfast =
        Namespaced_IRI.parse _namespace_name "BedAndBreakfast" |> NamespacedName

    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// <see href="http://schema.org/LodgingBusiness"></see></summary>
    let LodgingBusiness =
        Namespaced_IRI.parse _namespace_name "LodgingBusiness" |> NamespacedName

    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also &lt;a class="localLink" href="http://schema.org/BedType"&gt;BedType&lt;/a&gt; (under development).
    /// <see href="http://schema.org/BedDetails"></see></summary>
    let BedDetails = Namespaced_IRI.parse _namespace_name "BedDetails" |> NamespacedName
    /// <summary>
    /// A type of bed. This is used for indicating the bed or beds available in an accommodation.
    /// <see href="http://schema.org/BedType"></see></summary>
    let BedType = Namespaced_IRI.parse _namespace_name "BedType" |> NamespacedName

    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// <see href="http://schema.org/QualitativeValue"></see></summary>
    let QualitativeValue =
        Namespaced_IRI.parse _namespace_name "QualitativeValue" |> NamespacedName

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
    let BefriendAction =
        Namespaced_IRI.parse _namespace_name "BefriendAction" |> NamespacedName

    /// <summary>
    /// The act of interacting with another person or organization.
    /// <see href="http://schema.org/InteractAction"></see></summary>
    let InteractAction =
        Namespaced_IRI.parse _namespace_name "InteractAction" |> NamespacedName

    /// <summary>
    /// A bike store.
    /// <see href="http://schema.org/BikeStore"></see></summary>
    let BikeStore = Namespaced_IRI.parse _namespace_name "BikeStore" |> NamespacedName
    /// <summary>
    /// A blog.
    /// <see href="http://schema.org/Blog"></see></summary>
    let Blog = Namespaced_IRI.parse _namespace_name "Blog" |> NamespacedName

    /// <summary>
    /// A blog post.
    /// <see href="http://schema.org/BlogPosting"></see></summary>
    let BlogPosting =
        Namespaced_IRI.parse _namespace_name "BlogPosting" |> NamespacedName

    /// <summary>
    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    /// <see href="http://schema.org/SocialMediaPosting"></see></summary>
    let SocialMediaPosting =
        Namespaced_IRI.parse _namespace_name "SocialMediaPosting" |> NamespacedName

    /// <summary>
    /// A type of boarding policy used by an airline.
    /// <see href="http://schema.org/BoardingPolicyType"></see></summary>
    let BoardingPolicyType =
        Namespaced_IRI.parse _namespace_name "BoardingPolicyType" |> NamespacedName

    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// <see href="http://schema.org/BodyOfWater"></see></summary>
    let BodyOfWater =
        Namespaced_IRI.parse _namespace_name "BodyOfWater" |> NamespacedName

    /// <summary>
    /// A landform or physical feature.  Landform elements include mountains, plains, lakes, rivers, seascape and oceanic waterbody interface features such as bays, peninsulas, seas and so forth, including sub-aqueous terrain features such as submersed mountain ranges, volcanoes, and the great ocean basins.
    /// <see href="http://schema.org/Landform"></see></summary>
    let Landform = Namespaced_IRI.parse _namespace_name "Landform" |> NamespacedName
    /// <summary>
    /// A book.
    /// <see href="http://schema.org/Book"></see></summary>
    let Book = Namespaced_IRI.parse _namespace_name "Book" |> NamespacedName
    /// <summary>
    /// A series of books. Included books can be indicated with the hasPart property.
    /// <see href="http://schema.org/BookSeries"></see></summary>
    let BookSeries = Namespaced_IRI.parse _namespace_name "BookSeries" |> NamespacedName

    /// <summary>
    /// A CreativeWorkSeries in schema.org is a group of related items, typically but not necessarily of the same kind. CreativeWorkSeries are usually organized into some order, often chronological. Unlike &lt;a class="localLink" href="http://schema.org/ItemList"&gt;ItemList&lt;/a&gt; which is a general purpose data structure for lists of things, the emphasis with CreativeWorkSeries is on published materials (written e.g. books and periodicals, or media such as tv, radio and games).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Specific subtypes are available for describing &lt;a class="localLink" href="http://schema.org/TVSeries"&gt;TVSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RadioSeries"&gt;RadioSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/MovieSeries"&gt;MovieSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/BookSeries"&gt;BookSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Periodical"&gt;Periodical&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/VideoGameSeries"&gt;VideoGameSeries&lt;/a&gt;. In each case, the &lt;a class="localLink" href="http://schema.org/hasPart"&gt;hasPart&lt;/a&gt; / &lt;a class="localLink" href="http://schema.org/isPartOf"&gt;isPartOf&lt;/a&gt; properties can be used to relate the CreativeWorkSeries to its parts. The general CreativeWorkSeries type serves largely just to organize these more specific and practical subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// It is common for properties applicable to an item from the series to be usefully applied to the containing group. Schema.org attempts to anticipate some of these cases, but publishers should be free to apply properties of the series parts to the series as a whole wherever they seem appropriate.
    /// <see href="http://schema.org/CreativeWorkSeries"></see></summary>
    let CreativeWorkSeries =
        Namespaced_IRI.parse _namespace_name "CreativeWorkSeries" |> NamespacedName

    /// <summary>
    /// A bookstore.
    /// <see href="http://schema.org/BookStore"></see></summary>
    let BookStore = Namespaced_IRI.parse _namespace_name "BookStore" |> NamespacedName

    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// <see href="http://schema.org/BookmarkAction"></see></summary>
    let BookmarkAction =
        Namespaced_IRI.parse _namespace_name "BookmarkAction" |> NamespacedName

    /// <summary>
    /// Boolean: True or False.
    /// <see href="http://schema.org/Boolean"></see></summary>
    let Boolean = Namespaced_IRI.parse _namespace_name "Boolean" |> NamespacedName
    /// <summary>
    /// The basic data types such as Integers, Strings, etc.
    /// <see href="http://schema.org/DataType"></see></summary>
    let DataType = Namespaced_IRI.parse _namespace_name "DataType" |> NamespacedName

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
    let BorrowAction =
        Namespaced_IRI.parse _namespace_name "BorrowAction" |> NamespacedName

    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// <see href="http://schema.org/TransferAction"></see></summary>
    let TransferAction =
        Namespaced_IRI.parse _namespace_name "TransferAction" |> NamespacedName

    /// <summary>
    /// A bowling alley.
    /// <see href="http://schema.org/BowlingAlley"></see></summary>
    let BowlingAlley =
        Namespaced_IRI.parse _namespace_name "BowlingAlley" |> NamespacedName

    /// <summary>
    /// A sports location, such as a playing field.
    /// <see href="http://schema.org/SportsActivityLocation"></see></summary>
    let SportsActivityLocation =
        Namespaced_IRI.parse _namespace_name "SportsActivityLocation" |> NamespacedName

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// <see href="http://schema.org/Brand"></see></summary>
    let Brand = Namespaced_IRI.parse _namespace_name "Brand" |> NamespacedName

    /// <summary>
    /// A BreadcrumbList is an ItemList consisting of a chain of linked Web pages, typically described using at least their URL and their name, and typically ending with the current page.&lt;br/&gt;&lt;br/&gt;
    ///
    /// The &lt;a class="localLink" href="http://schema.org/position"&gt;position&lt;/a&gt; property is used to reconstruct the order of the items in a BreadcrumbList The convention is that a breadcrumb list has an &lt;a class="localLink" href="http://schema.org/itemListOrder"&gt;itemListOrder&lt;/a&gt; of &lt;a class="localLink" href="http://schema.org/ItemListOrderAscending"&gt;ItemListOrderAscending&lt;/a&gt; (lower values listed first), and that the first items in this list correspond to the "top" or beginning of the breadcrumb trail, e.g. with a site or section homepage. The specific values of 'position' are not assigned meaning for a BreadcrumbList, but they should be integers, e.g. beginning with '1' for the first item in the list.
    /// <see href="http://schema.org/BreadcrumbList"></see></summary>
    let BreadcrumbList =
        Namespaced_IRI.parse _namespace_name "BreadcrumbList" |> NamespacedName

    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// <see href="http://schema.org/ItemList"></see></summary>
    let ItemList = Namespaced_IRI.parse _namespace_name "ItemList" |> NamespacedName
    /// <summary>
    /// Brewery.
    /// <see href="http://schema.org/Brewery"></see></summary>
    let Brewery = Namespaced_IRI.parse _namespace_name "Brewery" |> NamespacedName
    /// <summary>
    /// A bridge.
    /// <see href="http://schema.org/Bridge"></see></summary>
    let Bridge = Namespaced_IRI.parse _namespace_name "Bridge" |> NamespacedName

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// <see href="http://schema.org/BroadcastChannel"></see></summary>
    let BroadcastChannel =
        Namespaced_IRI.parse _namespace_name "BroadcastChannel" |> NamespacedName

    /// <summary>
    /// An over the air or online broadcast event.
    /// <see href="http://schema.org/BroadcastEvent"></see></summary>
    let BroadcastEvent =
        Namespaced_IRI.parse _namespace_name "BroadcastEvent" |> NamespacedName

    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// <see href="http://schema.org/PublicationEvent"></see></summary>
    let PublicationEvent =
        Namespaced_IRI.parse _namespace_name "PublicationEvent" |> NamespacedName

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// <see href="http://schema.org/BroadcastFrequencySpecification"></see></summary>
    let BroadcastFrequencySpecification =
        Namespaced_IRI.parse _namespace_name "BroadcastFrequencySpecification" |> NamespacedName

    /// <summary>
    /// BroadcastRelease.
    /// <see href="http://schema.org/BroadcastRelease"></see></summary>
    let BroadcastRelease =
        Namespaced_IRI.parse _namespace_name "BroadcastRelease" |> NamespacedName

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// <see href="http://schema.org/BroadcastService"></see></summary>
    let BroadcastService =
        Namespaced_IRI.parse _namespace_name "BroadcastService" |> NamespacedName

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// <see href="http://schema.org/Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// A Buddhist temple.
    /// <see href="http://schema.org/BuddhistTemple"></see></summary>
    let BuddhistTemple =
        Namespaced_IRI.parse _namespace_name "BuddhistTemple" |> NamespacedName

    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// <see href="http://schema.org/PlaceOfWorship"></see></summary>
    let PlaceOfWorship =
        Namespaced_IRI.parse _namespace_name "PlaceOfWorship" |> NamespacedName

    /// <summary>
    /// A reservation for bus travel. &lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/BusReservation"></see></summary>
    let BusReservation =
        Namespaced_IRI.parse _namespace_name "BusReservation" |> NamespacedName

    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. &lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/Reservation"></see></summary>
    let Reservation =
        Namespaced_IRI.parse _namespace_name "Reservation" |> NamespacedName

    /// <summary>
    /// A bus station.
    /// <see href="http://schema.org/BusStation"></see></summary>
    let BusStation = Namespaced_IRI.parse _namespace_name "BusStation" |> NamespacedName
    /// <summary>
    /// A bus stop.
    /// <see href="http://schema.org/BusStop"></see></summary>
    let BusStop = Namespaced_IRI.parse _namespace_name "BusStop" |> NamespacedName
    /// <summary>
    /// A trip on a commercial bus line.
    /// <see href="http://schema.org/BusTrip"></see></summary>
    let BusTrip = Namespaced_IRI.parse _namespace_name "BusTrip" |> NamespacedName
    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// <see href="http://schema.org/Trip"></see></summary>
    let Trip = Namespaced_IRI.parse _namespace_name "Trip" |> NamespacedName

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// <see href="http://schema.org/BusinessAudience"></see></summary>
    let BusinessAudience =
        Namespaced_IRI.parse _namespace_name "BusinessAudience" |> NamespacedName

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
    let BusinessEntityType =
        Namespaced_IRI.parse _namespace_name "BusinessEntityType" |> NamespacedName

    /// <summary>
    /// Event type: Business event.
    /// <see href="http://schema.org/BusinessEvent"></see></summary>
    let BusinessEvent =
        Namespaced_IRI.parse _namespace_name "BusinessEvent" |> NamespacedName

    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the &lt;a class="localLink" href="http://schema.org/offers"&gt;offers&lt;/a&gt; property. Repeated events may be structured as separate Event objects.
    /// <see href="http://schema.org/Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName

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
    let BusinessFunction =
        Namespaced_IRI.parse _namespace_name "BusinessFunction" |> NamespacedName

    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    /// <see href="http://schema.org/BuyAction"></see></summary>
    let BuyAction = Namespaced_IRI.parse _namespace_name "BuyAction" |> NamespacedName

    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// <see href="http://schema.org/TradeAction"></see></summary>
    let TradeAction =
        Namespaced_IRI.parse _namespace_name "TradeAction" |> NamespacedName

    /// <summary>
    /// CDFormat.
    /// <see href="http://schema.org/CDFormat"></see></summary>
    let CDFormat = Namespaced_IRI.parse _namespace_name "CDFormat" |> NamespacedName

    /// <summary>
    /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
    /// <see href="http://schema.org/MusicReleaseFormatType"></see></summary>
    let MusicReleaseFormatType =
        Namespaced_IRI.parse _namespace_name "MusicReleaseFormatType" |> NamespacedName

    /// <summary>
    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    /// <see href="http://schema.org/CableOrSatelliteService"></see></summary>
    let CableOrSatelliteService =
        Namespaced_IRI.parse _namespace_name "CableOrSatelliteService" |> NamespacedName

    /// <summary>
    /// A cafe or coffee shop.
    /// <see href="http://schema.org/CafeOrCoffeeShop"></see></summary>
    let CafeOrCoffeeShop =
        Namespaced_IRI.parse _namespace_name "CafeOrCoffeeShop" |> NamespacedName

    /// <summary>
    /// A camping site, campsite, or &lt;a class="localLink" href="http://schema.org/Campground"&gt;Campground&lt;/a&gt; is a place used for overnight stay in the outdoors, typically containing individual &lt;a class="localLink" href="http://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; locations. &lt;br/&gt;&lt;br/&gt;
    ///
    /// In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Campground"></see></summary>
    let Campground = Namespaced_IRI.parse _namespace_name "Campground" |> NamespacedName

    /// <summary>
    /// A &lt;a class="localLink" href="http://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; is an individual place for overnight stay in the outdoors, typically being part of a larger camping site, or &lt;a class="localLink" href="http://schema.org/Campground"&gt;Campground&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// In British English a campsite, or campground, is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites.
    /// (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/CampingPitch"></see></summary>
    let CampingPitch =
        Namespaced_IRI.parse _namespace_name "CampingPitch" |> NamespacedName

    /// <summary>
    /// A canal, like the Panama Canal.
    /// <see href="http://schema.org/Canal"></see></summary>
    let Canal = Namespaced_IRI.parse _namespace_name "Canal" |> NamespacedName

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
    let CancelAction =
        Namespaced_IRI.parse _namespace_name "CancelAction" |> NamespacedName

    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// <see href="http://schema.org/PlanAction"></see></summary>
    let PlanAction = Namespaced_IRI.parse _namespace_name "PlanAction" |> NamespacedName
    /// <summary>
    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    /// <see href="http://schema.org/Car"></see></summary>
    let Car = Namespaced_IRI.parse _namespace_name "Car" |> NamespacedName
    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// <see href="http://schema.org/Vehicle"></see></summary>
    let Vehicle = Namespaced_IRI.parse _namespace_name "Vehicle" |> NamespacedName
    /// <summary>
    /// A casino.
    /// <see href="http://schema.org/Casino"></see></summary>
    let Casino = Namespaced_IRI.parse _namespace_name "Casino" |> NamespacedName

    /// <summary>
    /// CassetteFormat.
    /// <see href="http://schema.org/CassetteFormat"></see></summary>
    let CassetteFormat =
        Namespaced_IRI.parse _namespace_name "CassetteFormat" |> NamespacedName

    /// <summary>
    /// A Catholic church.
    /// <see href="http://schema.org/CatholicChurch"></see></summary>
    let CatholicChurch =
        Namespaced_IRI.parse _namespace_name "CatholicChurch" |> NamespacedName

    /// <summary>
    /// A church.
    /// <see href="http://schema.org/Church"></see></summary>
    let Church = Namespaced_IRI.parse _namespace_name "Church" |> NamespacedName
    /// <summary>
    /// A graveyard.
    /// <see href="http://schema.org/Cemetery"></see></summary>
    let Cemetery = Namespaced_IRI.parse _namespace_name "Cemetery" |> NamespacedName

    /// <summary>
    /// An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.
    /// <see href="http://schema.org/CheckAction"></see></summary>
    let CheckAction =
        Namespaced_IRI.parse _namespace_name "CheckAction" |> NamespacedName

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
    let FindAction = Namespaced_IRI.parse _namespace_name "FindAction" |> NamespacedName

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
    let CheckInAction =
        Namespaced_IRI.parse _namespace_name "CheckInAction" |> NamespacedName

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
    let CheckOutAction =
        Namespaced_IRI.parse _namespace_name "CheckOutAction" |> NamespacedName

    /// <summary>
    /// Web page type: Checkout page.
    /// <see href="http://schema.org/CheckoutPage"></see></summary>
    let CheckoutPage =
        Namespaced_IRI.parse _namespace_name "CheckoutPage" |> NamespacedName

    /// <summary>
    /// A Childcare center.
    /// <see href="http://schema.org/ChildCare"></see></summary>
    let ChildCare = Namespaced_IRI.parse _namespace_name "ChildCare" |> NamespacedName

    /// <summary>
    /// Event type: Children's event.
    /// <see href="http://schema.org/ChildrensEvent"></see></summary>
    let ChildrensEvent =
        Namespaced_IRI.parse _namespace_name "ChildrensEvent" |> NamespacedName

    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// <see href="http://schema.org/ChooseAction"></see></summary>
    let ChooseAction =
        Namespaced_IRI.parse _namespace_name "ChooseAction" |> NamespacedName

    /// <summary>
    /// A city or town.
    /// <see href="http://schema.org/City"></see></summary>
    let City = Namespaced_IRI.parse _namespace_name "City" |> NamespacedName
    /// <summary>
    /// A city hall.
    /// <see href="http://schema.org/CityHall"></see></summary>
    let CityHall = Namespaced_IRI.parse _namespace_name "CityHall" |> NamespacedName

    /// <summary>
    /// A government building.
    /// <see href="http://schema.org/GovernmentBuilding"></see></summary>
    let GovernmentBuilding =
        Namespaced_IRI.parse _namespace_name "GovernmentBuilding" |> NamespacedName

    /// <summary>
    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    /// <see href="http://schema.org/ClaimReview"></see></summary>
    let ClaimReview =
        Namespaced_IRI.parse _namespace_name "ClaimReview" |> NamespacedName

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// <see href="http://schema.org/Review"></see></summary>
    let Review = Namespaced_IRI.parse _namespace_name "Review" |> NamespacedName
    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// <see href="http://schema.org/Clip"></see></summary>
    let Clip = Namespaced_IRI.parse _namespace_name "Clip" |> NamespacedName

    /// <summary>
    /// A clothing store.
    /// <see href="http://schema.org/ClothingStore"></see></summary>
    let ClothingStore =
        Namespaced_IRI.parse _namespace_name "ClothingStore" |> NamespacedName

    /// <summary>
    /// Play mode: CoOp. Co-operative games, where you play on the same team with friends.
    /// <see href="http://schema.org/CoOp"></see></summary>
    let CoOp = Namespaced_IRI.parse _namespace_name "CoOp" |> NamespacedName

    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.
    /// <see href="http://schema.org/GamePlayMode"></see></summary>
    let GamePlayMode =
        Namespaced_IRI.parse _namespace_name "GamePlayMode" |> NamespacedName

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// <see href="http://schema.org/Code"></see></summary>
    let Code = Namespaced_IRI.parse _namespace_name "Code" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/supersededBy"></see>
    /// </summary>
    let supersededBy =
        Namespaced_IRI.parse _namespace_name "supersededBy" |> NamespacedName

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// <see href="http://schema.org/SoftwareSourceCode"></see></summary>
    let SoftwareSourceCode =
        Namespaced_IRI.parse _namespace_name "SoftwareSourceCode" |> NamespacedName

    /// <summary>
    /// Web page type: Collection page.
    /// <see href="http://schema.org/CollectionPage"></see></summary>
    let CollectionPage =
        Namespaced_IRI.parse _namespace_name "CollectionPage" |> NamespacedName

    /// <summary>
    /// A college, university, or other third-level educational institution.
    /// <see href="http://schema.org/CollegeOrUniversity"></see></summary>
    let CollegeOrUniversity =
        Namespaced_IRI.parse _namespace_name "CollegeOrUniversity" |> NamespacedName

    /// <summary>
    /// An educational organization.
    /// <see href="http://schema.org/EducationalOrganization"></see></summary>
    let EducationalOrganization =
        Namespaced_IRI.parse _namespace_name "EducationalOrganization" |> NamespacedName

    /// <summary>
    /// A comedy club.
    /// <see href="http://schema.org/ComedyClub"></see></summary>
    let ComedyClub = Namespaced_IRI.parse _namespace_name "ComedyClub" |> NamespacedName

    /// <summary>
    /// Event type: Comedy event.
    /// <see href="http://schema.org/ComedyEvent"></see></summary>
    let ComedyEvent =
        Namespaced_IRI.parse _namespace_name "ComedyEvent" |> NamespacedName

    /// <summary>
    /// The act of generating a comment about a subject.
    /// <see href="http://schema.org/CommentAction"></see></summary>
    let CommentAction =
        Namespaced_IRI.parse _namespace_name "CommentAction" |> NamespacedName

    /// <summary>
    /// Permission to add comments to the document.
    /// <see href="http://schema.org/CommentPermission"></see></summary>
    let CommentPermission =
        Namespaced_IRI.parse _namespace_name "CommentPermission" |> NamespacedName

    /// <summary>
    /// A type of permission which can be granted for accessing a digital document.
    /// <see href="http://schema.org/DigitalDocumentPermissionType"></see></summary>
    let DigitalDocumentPermissionType =
        Namespaced_IRI.parse _namespace_name "DigitalDocumentPermissionType" |> NamespacedName

    /// <summary>
    /// CompilationAlbum.
    /// <see href="http://schema.org/CompilationAlbum"></see></summary>
    let CompilationAlbum =
        Namespaced_IRI.parse _namespace_name "CompilationAlbum" |> NamespacedName

    /// <summary>
    /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
    /// <see href="http://schema.org/MusicAlbumProductionType"></see></summary>
    let MusicAlbumProductionType =
        Namespaced_IRI.parse _namespace_name "MusicAlbumProductionType" |> NamespacedName

    /// <summary>
    /// An action that has already taken place.
    /// <see href="http://schema.org/CompletedActionStatus"></see></summary>
    let CompletedActionStatus =
        Namespaced_IRI.parse _namespace_name "CompletedActionStatus" |> NamespacedName

    /// <summary>
    /// A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use the name property of the attached unit price specification for indicating the dimension of a price component (e.g. "electricity" or "final cleaning").
    /// <see href="http://schema.org/CompoundPriceSpecification"></see></summary>
    let CompoundPriceSpecification =
        Namespaced_IRI.parse _namespace_name "CompoundPriceSpecification" |> NamespacedName

    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; to describe independent amounts of money such as a salary, credit card limits, etc.
    /// <see href="http://schema.org/PriceSpecification"></see></summary>
    let PriceSpecification =
        Namespaced_IRI.parse _namespace_name "PriceSpecification" |> NamespacedName

    /// <summary>
    /// This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the &lt;a class="localLink" href="http://schema.org/Language"&gt;Language&lt;/a&gt; type.
    /// <see href="http://schema.org/ComputerLanguage"></see></summary>
    let ComputerLanguage =
        Namespaced_IRI.parse _namespace_name "ComputerLanguage" |> NamespacedName

    /// <summary>
    /// A computer store.
    /// <see href="http://schema.org/ComputerStore"></see></summary>
    let ComputerStore =
        Namespaced_IRI.parse _namespace_name "ComputerStore" |> NamespacedName

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
    let ConfirmAction =
        Namespaced_IRI.parse _namespace_name "ConfirmAction" |> NamespacedName

    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// <see href="http://schema.org/InformAction"></see></summary>
    let InformAction =
        Namespaced_IRI.parse _namespace_name "InformAction" |> NamespacedName

    /// <summary>
    /// The act of ingesting information/resources/food.
    /// <see href="http://schema.org/ConsumeAction"></see></summary>
    let ConsumeAction =
        Namespaced_IRI.parse _namespace_name "ConsumeAction" |> NamespacedName

    /// <summary>
    /// Web page type: Contact page.
    /// <see href="http://schema.org/ContactPage"></see></summary>
    let ContactPage =
        Namespaced_IRI.parse _namespace_name "ContactPage" |> NamespacedName

    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// <see href="http://schema.org/ContactPoint"></see></summary>
    let ContactPoint =
        Namespaced_IRI.parse _namespace_name "ContactPoint" |> NamespacedName

    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// <see href="http://schema.org/StructuredValue"></see></summary>
    let StructuredValue =
        Namespaced_IRI.parse _namespace_name "StructuredValue" |> NamespacedName

    /// <summary>
    /// Enumerated options related to a ContactPoint.
    /// <see href="http://schema.org/ContactPointOption"></see></summary>
    let ContactPointOption =
        Namespaced_IRI.parse _namespace_name "ContactPointOption" |> NamespacedName

    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// <see href="http://schema.org/Continent"></see></summary>
    let Continent = Namespaced_IRI.parse _namespace_name "Continent" |> NamespacedName

    /// <summary>
    /// A convenience store.
    /// <see href="http://schema.org/ConvenienceStore"></see></summary>
    let ConvenienceStore =
        Namespaced_IRI.parse _namespace_name "ConvenienceStore" |> NamespacedName

    /// <summary>
    /// One or more messages between organizations or people on a particular topic. Individual messages can be linked to the conversation with isPartOf or hasPart properties.
    /// <see href="http://schema.org/Conversation"></see></summary>
    let Conversation =
        Namespaced_IRI.parse _namespace_name "Conversation" |> NamespacedName

    /// <summary>
    /// The act of producing/preparing food.
    /// <see href="http://schema.org/CookAction"></see></summary>
    let CookAction = Namespaced_IRI.parse _namespace_name "CookAction" |> NamespacedName

    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// <see href="http://schema.org/CreateAction"></see></summary>
    let CreateAction =
        Namespaced_IRI.parse _namespace_name "CreateAction" |> NamespacedName

    /// <summary>
    /// Organization: A business corporation.
    /// <see href="http://schema.org/Corporation"></see></summary>
    let Corporation =
        Namespaced_IRI.parse _namespace_name "Corporation" |> NamespacedName

    /// <summary>
    /// A country.
    /// <see href="http://schema.org/Country"></see></summary>
    let Country = Namespaced_IRI.parse _namespace_name "Country" |> NamespacedName
    /// <summary>
    /// A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// <see href="http://schema.org/Course"></see></summary>
    let Course = Namespaced_IRI.parse _namespace_name "Course" |> NamespacedName

    /// <summary>
    /// An instance of a &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// <see href="http://schema.org/CourseInstance"></see></summary>
    let CourseInstance =
        Namespaced_IRI.parse _namespace_name "CourseInstance" |> NamespacedName

    /// <summary>
    /// A courthouse.
    /// <see href="http://schema.org/Courthouse"></see></summary>
    let Courthouse = Namespaced_IRI.parse _namespace_name "Courthouse" |> NamespacedName

    /// <summary>
    /// A media season e.g. tv, radio, video game etc.
    /// <see href="http://schema.org/CreativeWorkSeason"></see></summary>
    let CreativeWorkSeason =
        Namespaced_IRI.parse _namespace_name "CreativeWorkSeason" |> NamespacedName

    /// <summary>
    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also &lt;a class="localLink" href="http://schema.org/CreativeWorkSeries"&gt;CreativeWorkSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/EventSeries"&gt;EventSeries&lt;/a&gt;.
    /// <see href="http://schema.org/Series"></see></summary>
    let Series = Namespaced_IRI.parse _namespace_name "Series" |> NamespacedName
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
    let CreditCard = Namespaced_IRI.parse _namespace_name "CreditCard" |> NamespacedName

    /// <summary>
    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    /// <see href="http://schema.org/LoanOrCredit"></see></summary>
    let LoanOrCredit =
        Namespaced_IRI.parse _namespace_name "LoanOrCredit" |> NamespacedName

    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// <see href="http://schema.org/PaymentCard"></see></summary>
    let PaymentCard =
        Namespaced_IRI.parse _namespace_name "PaymentCard" |> NamespacedName

    /// <summary>
    /// A crematorium.
    /// <see href="http://schema.org/Crematorium"></see></summary>
    let Crematorium =
        Namespaced_IRI.parse _namespace_name "Crematorium" |> NamespacedName

    /// <summary>
    /// A service to convert funds from one currency to another currency.
    /// <see href="http://schema.org/CurrencyConversionService"></see></summary>
    let CurrencyConversionService =
        Namespaced_IRI.parse _namespace_name "CurrencyConversionService" |> NamespacedName

    /// <summary>
    /// DJMixAlbum.
    /// <see href="http://schema.org/DJMixAlbum"></see></summary>
    let DJMixAlbum = Namespaced_IRI.parse _namespace_name "DJMixAlbum" |> NamespacedName
    /// <summary>
    /// DVDFormat.
    /// <see href="http://schema.org/DVDFormat"></see></summary>
    let DVDFormat = Namespaced_IRI.parse _namespace_name "DVDFormat" |> NamespacedName

    /// <summary>
    /// Indicates that the item is damaged.
    /// <see href="http://schema.org/DamagedCondition"></see></summary>
    let DamagedCondition =
        Namespaced_IRI.parse _namespace_name "DamagedCondition" |> NamespacedName

    /// <summary>
    /// A list of possible conditions for the item.
    /// <see href="http://schema.org/OfferItemCondition"></see></summary>
    let OfferItemCondition =
        Namespaced_IRI.parse _namespace_name "OfferItemCondition" |> NamespacedName

    /// <summary>
    /// Event type: A social dance.
    /// <see href="http://schema.org/DanceEvent"></see></summary>
    let DanceEvent = Namespaced_IRI.parse _namespace_name "DanceEvent" |> NamespacedName
    /// <summary>
    /// A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    /// <see href="http://schema.org/DanceGroup"></see></summary>
    let DanceGroup = Namespaced_IRI.parse _namespace_name "DanceGroup" |> NamespacedName

    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// <see href="http://schema.org/PerformingGroup"></see></summary>
    let PerformingGroup =
        Namespaced_IRI.parse _namespace_name "PerformingGroup" |> NamespacedName

    /// <summary>
    /// A collection of datasets.
    /// <see href="http://schema.org/DataCatalog"></see></summary>
    let DataCatalog =
        Namespaced_IRI.parse _namespace_name "DataCatalog" |> NamespacedName

    /// <summary>
    /// A dataset in downloadable form.
    /// <see href="http://schema.org/DataDownload"></see></summary>
    let DataDownload =
        Namespaced_IRI.parse _namespace_name "DataDownload" |> NamespacedName

    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// <see href="http://schema.org/DataFeed"></see></summary>
    let DataFeed = Namespaced_IRI.parse _namespace_name "DataFeed" |> NamespacedName
    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// <see href="http://schema.org/Dataset"></see></summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName

    /// <summary>
    /// A single item within a larger data feed.
    /// <see href="http://schema.org/DataFeedItem"></see></summary>
    let DataFeedItem =
        Namespaced_IRI.parse _namespace_name "DataFeedItem" |> NamespacedName

    /// <summary>
    /// A date value in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
    /// <see href="http://schema.org/Date"></see></summary>
    let Date = Namespaced_IRI.parse _namespace_name "Date" |> NamespacedName
    /// <summary>
    /// A combination of date and time of day in the form [-]CCYY-MM-DDThh:mm:ss[Z|(+|-)hh:mm] (see Chapter 5.4 of ISO 8601).
    /// <see href="http://schema.org/DateTime"></see></summary>
    let DateTime = Namespaced_IRI.parse _namespace_name "DateTime" |> NamespacedName

    /// <summary>
    /// A DatedMoneySpecification represents monetary values with optional start and end dates. For example, this could represent an employee's salary over a specific period of time. &lt;strong&gt;Note:&lt;/strong&gt; This type has been superseded by &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; use of that type is recommended
    /// <see href="http://schema.org/DatedMoneySpecification"></see></summary>
    let DatedMoneySpecification =
        Namespaced_IRI.parse _namespace_name "DatedMoneySpecification" |> NamespacedName

    /// <summary>
    /// A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc. It is recommended to use &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; Types to describe the price of an Offer, Invoice, etc.
    /// <see href="http://schema.org/MonetaryAmount"></see></summary>
    let MonetaryAmount =
        Namespaced_IRI.parse _namespace_name "MonetaryAmount" |> NamespacedName

    /// <summary>
    /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Originally, URLs from &lt;a href="http://purl.org/goodrelations/v1"&gt;GoodRelations&lt;/a&gt; were used (for &lt;a class="localLink" href="http://schema.org/Monday"&gt;Monday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Tuesday"&gt;Tuesday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Wednesday"&gt;Wednesday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Thursday"&gt;Thursday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Friday"&gt;Friday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Saturday"&gt;Saturday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Sunday"&gt;Sunday&lt;/a&gt; plus a special entry for &lt;a class="localLink" href="http://schema.org/PublicHolidays"&gt;PublicHolidays&lt;/a&gt;); these have now been integrated directly into schema.org.
    /// <see href="http://schema.org/DayOfWeek"></see></summary>
    let DayOfWeek = Namespaced_IRI.parse _namespace_name "DayOfWeek" |> NamespacedName
    /// <summary>
    /// A day spa.
    /// <see href="http://schema.org/DaySpa"></see></summary>
    let DaySpa = Namespaced_IRI.parse _namespace_name "DaySpa" |> NamespacedName

    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// <see href="http://schema.org/DeactivateAction"></see></summary>
    let DeactivateAction =
        Namespaced_IRI.parse _namespace_name "DeactivateAction" |> NamespacedName

    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// <see href="http://schema.org/DefenceEstablishment"></see></summary>
    let DefenceEstablishment =
        Namespaced_IRI.parse _namespace_name "DefenceEstablishment" |> NamespacedName

    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// <see href="http://schema.org/DeleteAction"></see></summary>
    let DeleteAction =
        Namespaced_IRI.parse _namespace_name "DeleteAction" |> NamespacedName

    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// <see href="http://schema.org/DeliveryChargeSpecification"></see></summary>
    let DeliveryChargeSpecification =
        Namespaced_IRI.parse _namespace_name "DeliveryChargeSpecification" |> NamespacedName

    /// <summary>
    /// An event involving the delivery of an item.
    /// <see href="http://schema.org/DeliveryEvent"></see></summary>
    let DeliveryEvent =
        Namespaced_IRI.parse _namespace_name "DeliveryEvent" |> NamespacedName

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
    let DeliveryMethod =
        Namespaced_IRI.parse _namespace_name "DeliveryMethod" |> NamespacedName

    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// <see href="http://schema.org/Demand"></see></summary>
    let Demand = Namespaced_IRI.parse _namespace_name "Demand" |> NamespacedName
    /// <summary>
    /// DemoAlbum.
    /// <see href="http://schema.org/DemoAlbum"></see></summary>
    let DemoAlbum = Namespaced_IRI.parse _namespace_name "DemoAlbum" |> NamespacedName
    /// <summary>
    /// A dentist.
    /// <see href="http://schema.org/Dentist"></see></summary>
    let Dentist = Namespaced_IRI.parse _namespace_name "Dentist" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/MedicalBusiness"></see>
    /// </summary>
    let MedicalBusiness =
        Namespaced_IRI.parse _namespace_name "MedicalBusiness" |> NamespacedName

    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// <see href="http://schema.org/MedicalOrganization"></see></summary>
    let MedicalOrganization =
        Namespaced_IRI.parse _namespace_name "MedicalOrganization" |> NamespacedName

    /// <summary>
    /// The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.
    /// <see href="http://schema.org/DepartAction"></see></summary>
    let DepartAction =
        Namespaced_IRI.parse _namespace_name "DepartAction" |> NamespacedName

    /// <summary>
    /// A department store.
    /// <see href="http://schema.org/DepartmentStore"></see></summary>
    let DepartmentStore =
        Namespaced_IRI.parse _namespace_name "DepartmentStore" |> NamespacedName

    /// <summary>
    /// A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.
    /// <see href="http://schema.org/DepositAccount"></see></summary>
    let DepositAccount =
        Namespaced_IRI.parse _namespace_name "DepositAccount" |> NamespacedName

    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// <see href="http://schema.org/InvestmentOrDeposit"></see></summary>
    let InvestmentOrDeposit =
        Namespaced_IRI.parse _namespace_name "InvestmentOrDeposit" |> NamespacedName

    /// <summary>
    /// A diet appropriate for people with diabetes.
    /// <see href="http://schema.org/DiabeticDiet"></see></summary>
    let DiabeticDiet =
        Namespaced_IRI.parse _namespace_name "DiabeticDiet" |> NamespacedName

    /// <summary>
    /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.
    /// <see href="http://schema.org/RestrictedDiet"></see></summary>
    let RestrictedDiet =
        Namespaced_IRI.parse _namespace_name "RestrictedDiet" |> NamespacedName

    /// <summary>
    /// DigitalAudioTapeFormat.
    /// <see href="http://schema.org/DigitalAudioTapeFormat"></see></summary>
    let DigitalAudioTapeFormat =
        Namespaced_IRI.parse _namespace_name "DigitalAudioTapeFormat" |> NamespacedName

    /// <summary>
    /// An electronic file or document.
    /// <see href="http://schema.org/DigitalDocument"></see></summary>
    let DigitalDocument =
        Namespaced_IRI.parse _namespace_name "DigitalDocument" |> NamespacedName

    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// <see href="http://schema.org/DigitalDocumentPermission"></see></summary>
    let DigitalDocumentPermission =
        Namespaced_IRI.parse _namespace_name "DigitalDocumentPermission" |> NamespacedName

    /// <summary>
    /// DigitalFormat.
    /// <see href="http://schema.org/DigitalFormat"></see></summary>
    let DigitalFormat =
        Namespaced_IRI.parse _namespace_name "DigitalFormat" |> NamespacedName

    /// <summary>
    /// The act of expressing a difference of opinion with the object. An agent disagrees to/about an object (a proposition, topic or theme) with participants.
    /// <see href="http://schema.org/DisagreeAction"></see></summary>
    let DisagreeAction =
        Namespaced_IRI.parse _namespace_name "DisagreeAction" |> NamespacedName

    /// <summary>
    /// Indicates that the item has been discontinued.
    /// <see href="http://schema.org/Discontinued"></see></summary>
    let Discontinued =
        Namespaced_IRI.parse _namespace_name "Discontinued" |> NamespacedName

    /// <summary>
    /// A list of possible product availability options.
    /// <see href="http://schema.org/ItemAvailability"></see></summary>
    let ItemAvailability =
        Namespaced_IRI.parse _namespace_name "ItemAvailability" |> NamespacedName

    /// <summary>
    /// The act of discovering/finding an object.
    /// <see href="http://schema.org/DiscoverAction"></see></summary>
    let DiscoverAction =
        Namespaced_IRI.parse _namespace_name "DiscoverAction" |> NamespacedName

    /// <summary>
    /// A posting to a discussion forum.
    /// <see href="http://schema.org/DiscussionForumPosting"></see></summary>
    let DiscussionForumPosting =
        Namespaced_IRI.parse _namespace_name "DiscussionForumPosting" |> NamespacedName

    /// <summary>
    /// The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.
    /// <see href="http://schema.org/DislikeAction"></see></summary>
    let DislikeAction =
        Namespaced_IRI.parse _namespace_name "DislikeAction" |> NamespacedName

    /// <summary>
    /// Properties that take Distances as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Length unit of measure&amp;gt;'. E.g., '7 ft'.
    /// <see href="http://schema.org/Distance"></see></summary>
    let Distance = Namespaced_IRI.parse _namespace_name "Distance" |> NamespacedName
    /// <summary>
    /// Quantities such as distance, time, mass, weight, etc. Particular instances of say Mass are entities like '3 Kg' or '4 milligrams'.
    /// <see href="http://schema.org/Quantity"></see></summary>
    let Quantity = Namespaced_IRI.parse _namespace_name "Quantity" |> NamespacedName
    /// <summary>
    /// A distillery.
    /// <see href="http://schema.org/Distillery"></see></summary>
    let Distillery = Namespaced_IRI.parse _namespace_name "Distillery" |> NamespacedName

    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// <see href="http://schema.org/DonateAction"></see></summary>
    let DonateAction =
        Namespaced_IRI.parse _namespace_name "DonateAction" |> NamespacedName

    /// <summary>
    /// The act of downloading an object.
    /// <see href="http://schema.org/DownloadAction"></see></summary>
    let DownloadAction =
        Namespaced_IRI.parse _namespace_name "DownloadAction" |> NamespacedName

    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// <see href="http://schema.org/DrawAction"></see></summary>
    let DrawAction = Namespaced_IRI.parse _namespace_name "DrawAction" |> NamespacedName

    /// <summary>
    /// The act of swallowing liquids.
    /// <see href="http://schema.org/DrinkAction"></see></summary>
    let DrinkAction =
        Namespaced_IRI.parse _namespace_name "DrinkAction" |> NamespacedName

    /// <summary>
    /// A dry-cleaning business.
    /// <see href="http://schema.org/DryCleaningOrLaundry"></see></summary>
    let DryCleaningOrLaundry =
        Namespaced_IRI.parse _namespace_name "DryCleaningOrLaundry" |> NamespacedName

    /// <summary>
    /// Quantity: Duration (use &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;).
    /// <see href="http://schema.org/Duration"></see></summary>
    let Duration = Namespaced_IRI.parse _namespace_name "Duration" |> NamespacedName
    /// <summary>
    /// Book format: Ebook.
    /// <see href="http://schema.org/EBook"></see></summary>
    let EBook = Namespaced_IRI.parse _namespace_name "EBook" |> NamespacedName
    /// <summary>
    /// EPRelease.
    /// <see href="http://schema.org/EPRelease"></see></summary>
    let EPRelease = Namespaced_IRI.parse _namespace_name "EPRelease" |> NamespacedName
    /// <summary>
    /// The act of swallowing solid objects.
    /// <see href="http://schema.org/EatAction"></see></summary>
    let EatAction = Namespaced_IRI.parse _namespace_name "EatAction" |> NamespacedName

    /// <summary>
    /// Event type: Education event.
    /// <see href="http://schema.org/EducationEvent"></see></summary>
    let EducationEvent =
        Namespaced_IRI.parse _namespace_name "EducationEvent" |> NamespacedName

    /// <summary>
    /// An EducationalAudience.
    /// <see href="http://schema.org/EducationalAudience"></see></summary>
    let EducationalAudience =
        Namespaced_IRI.parse _namespace_name "EducationalAudience" |> NamespacedName

    /// <summary>
    /// An electrician.
    /// <see href="http://schema.org/Electrician"></see></summary>
    let Electrician =
        Namespaced_IRI.parse _namespace_name "Electrician" |> NamespacedName

    /// <summary>
    /// A construction business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// A HomeAndConstructionBusiness is a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; that provides services around homes and buildings.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).
    /// <see href="http://schema.org/HomeAndConstructionBusiness"></see></summary>
    let HomeAndConstructionBusiness =
        Namespaced_IRI.parse _namespace_name "HomeAndConstructionBusiness" |> NamespacedName

    /// <summary>
    /// An electronics store.
    /// <see href="http://schema.org/ElectronicsStore"></see></summary>
    let ElectronicsStore =
        Namespaced_IRI.parse _namespace_name "ElectronicsStore" |> NamespacedName

    /// <summary>
    /// An elementary school.
    /// <see href="http://schema.org/ElementarySchool"></see></summary>
    let ElementarySchool =
        Namespaced_IRI.parse _namespace_name "ElementarySchool" |> NamespacedName

    /// <summary>
    /// An email message.
    /// <see href="http://schema.org/EmailMessage"></see></summary>
    let EmailMessage =
        Namespaced_IRI.parse _namespace_name "EmailMessage" |> NamespacedName

    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// <see href="http://schema.org/Message"></see></summary>
    let Message = Namespaced_IRI.parse _namespace_name "Message" |> NamespacedName
    /// <summary>
    /// An embassy.
    /// <see href="http://schema.org/Embassy"></see></summary>
    let Embassy = Namespaced_IRI.parse _namespace_name "Embassy" |> NamespacedName

    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// <see href="http://schema.org/EmergencyService"></see></summary>
    let EmergencyService =
        Namespaced_IRI.parse _namespace_name "EmergencyService" |> NamespacedName

    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// <see href="http://schema.org/EmployeeRole"></see></summary>
    let EmployeeRole =
        Namespaced_IRI.parse _namespace_name "EmployeeRole" |> NamespacedName

    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// <see href="http://schema.org/OrganizationRole"></see></summary>
    let OrganizationRole =
        Namespaced_IRI.parse _namespace_name "OrganizationRole" |> NamespacedName

    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// <see href="http://schema.org/EmployerAggregateRating"></see></summary>
    let EmployerAggregateRating =
        Namespaced_IRI.parse _namespace_name "EmployerAggregateRating" |> NamespacedName

    /// <summary>
    /// An employment agency.
    /// <see href="http://schema.org/EmploymentAgency"></see></summary>
    let EmploymentAgency =
        Namespaced_IRI.parse _namespace_name "EmploymentAgency" |> NamespacedName

    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// <see href="http://schema.org/EndorseAction"></see></summary>
    let EndorseAction =
        Namespaced_IRI.parse _namespace_name "EndorseAction" |> NamespacedName

    /// <summary>
    /// An EndorsementRating is a rating that expresses some level of endorsement, for example inclusion in a "critic's pick" blog, a
    /// "Like" or "+1" on a social network. It can be considered the &lt;a class="localLink" href="http://schema.org/result"&gt;result&lt;/a&gt; of an &lt;a class="localLink" href="http://schema.org/EndorseAction"&gt;EndorseAction&lt;/a&gt; in which the &lt;a class="localLink" href="http://schema.org/object"&gt;object&lt;/a&gt; of the action is rated positively by
    /// some &lt;a class="localLink" href="http://schema.org/agent"&gt;agent&lt;/a&gt;. As is common elsewhere in schema.org, it is sometimes more useful to describe the results of such an action without explicitly describing the &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// An &lt;a class="localLink" href="http://schema.org/EndorsementRating"&gt;EndorsementRating&lt;/a&gt; may be part of a numeric scale or organized system, but this is not required: having an explicit type for indicating a positive,
    /// endorsement rating is particularly useful in the absence of numeric scales as it helps consumers understand that the rating is broadly positive.
    /// <see href="http://schema.org/EndorsementRating"></see></summary>
    let EndorsementRating =
        Namespaced_IRI.parse _namespace_name "EndorsementRating" |> NamespacedName

    /// <summary>
    /// Properties that take Energy as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Energy unit of measure&amp;gt;'.
    /// <see href="http://schema.org/Energy"></see></summary>
    let Energy = Namespaced_IRI.parse _namespace_name "Energy" |> NamespacedName

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// <see href="http://schema.org/EngineSpecification"></see></summary>
    let EngineSpecification =
        Namespaced_IRI.parse _namespace_name "EngineSpecification" |> NamespacedName

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// <see href="http://schema.org/EntryPoint"></see></summary>
    let EntryPoint = Namespaced_IRI.parse _namespace_name "EntryPoint" |> NamespacedName
    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// <see href="http://schema.org/Episode"></see></summary>
    let Episode = Namespaced_IRI.parse _namespace_name "Episode" |> NamespacedName

    /// <summary>
    /// The event has been cancelled. If the event has multiple startDate values, all are assumed to be cancelled. Either startDate or previousStartDate may be used to specify the event's cancelled date(s).
    /// <see href="http://schema.org/EventCancelled"></see></summary>
    let EventCancelled =
        Namespaced_IRI.parse _namespace_name "EventCancelled" |> NamespacedName

    /// <summary>
    /// EventStatusType is an enumeration type whose instances represent several states that an Event may be in.
    /// <see href="http://schema.org/EventStatusType"></see></summary>
    let EventStatusType =
        Namespaced_IRI.parse _namespace_name "EventStatusType" |> NamespacedName

    /// <summary>
    /// Indicates that the event was changed to allow online participation. See &lt;a class="localLink" href="http://schema.org/eventAttendanceMode"&gt;eventAttendanceMode&lt;/a&gt; for specifics of whether it is now fully or partially online.
    /// <see href="http://schema.org/EventMovedOnline"></see></summary>
    let EventMovedOnline =
        Namespaced_IRI.parse _namespace_name "EventMovedOnline" |> NamespacedName

    /// <summary>
    /// The event has been postponed and no new date has been set. The event's previousStartDate should be set.
    /// <see href="http://schema.org/EventPostponed"></see></summary>
    let EventPostponed =
        Namespaced_IRI.parse _namespace_name "EventPostponed" |> NamespacedName

    /// <summary>
    /// The event has been rescheduled. The event's previousStartDate should be set to the old date and the startDate should be set to the event's new date. (If the event has been rescheduled multiple times, the previousStartDate property may be repeated).
    /// <see href="http://schema.org/EventRescheduled"></see></summary>
    let EventRescheduled =
        Namespaced_IRI.parse _namespace_name "EventRescheduled" |> NamespacedName

    /// <summary>
    /// A reservation for an event like a concert, sporting event, or lecture.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/EventReservation"></see></summary>
    let EventReservation =
        Namespaced_IRI.parse _namespace_name "EventReservation" |> NamespacedName

    /// <summary>
    /// The event is taking place or has taken place on the startDate as scheduled. Use of this value is optional, as it is assumed by default.
    /// <see href="http://schema.org/EventScheduled"></see></summary>
    let EventScheduled =
        Namespaced_IRI.parse _namespace_name "EventScheduled" |> NamespacedName

    /// <summary>
    /// An event venue.
    /// <see href="http://schema.org/EventVenue"></see></summary>
    let EventVenue = Namespaced_IRI.parse _namespace_name "EventVenue" |> NamespacedName

    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// <see href="http://schema.org/ExerciseAction"></see></summary>
    let ExerciseAction =
        Namespaced_IRI.parse _namespace_name "ExerciseAction" |> NamespacedName

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
    let PlayAction = Namespaced_IRI.parse _namespace_name "PlayAction" |> NamespacedName

    /// <summary>
    /// A gym.
    /// <see href="http://schema.org/ExerciseGym"></see></summary>
    let ExerciseGym =
        Namespaced_IRI.parse _namespace_name "ExerciseGym" |> NamespacedName

    /// <summary>
    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    /// <see href="http://schema.org/ExhibitionEvent"></see></summary>
    let ExhibitionEvent =
        Namespaced_IRI.parse _namespace_name "ExhibitionEvent" |> NamespacedName

    /// <summary>
    /// A &lt;a class="localLink" href="http://schema.org/FAQPage"&gt;FAQPage&lt;/a&gt; is a &lt;a class="localLink" href="http://schema.org/WebPage"&gt;WebPage&lt;/a&gt; presenting one or more "&lt;a href="https://en.wikipedia.org/wiki/FAQ"&gt;Frequently asked questions&lt;/a&gt;" (see also &lt;a class="localLink" href="http://schema.org/QAPage"&gt;QAPage&lt;/a&gt;).
    /// <see href="http://schema.org/FAQPage"></see></summary>
    let FAQPage = Namespaced_IRI.parse _namespace_name "FAQPage" |> NamespacedName

    /// <summary>
    /// A radio channel that uses FM.
    /// <see href="http://schema.org/FMRadioChannel"></see></summary>
    let FMRadioChannel =
        Namespaced_IRI.parse _namespace_name "FMRadioChannel" |> NamespacedName

    /// <summary>
    /// An action that failed to complete. The action's error property and the HTTP return code contain more information about the failure.
    /// <see href="http://schema.org/FailedActionStatus"></see></summary>
    let FailedActionStatus =
        Namespaced_IRI.parse _namespace_name "FailedActionStatus" |> NamespacedName

    /// <summary>
    /// The boolean value false.
    /// <see href="http://schema.org/False"></see></summary>
    let False = Namespaced_IRI.parse _namespace_name "False" |> NamespacedName

    /// <summary>
    /// A fast-food restaurant.
    /// <see href="http://schema.org/FastFoodRestaurant"></see></summary>
    let FastFoodRestaurant =
        Namespaced_IRI.parse _namespace_name "FastFoodRestaurant" |> NamespacedName

    /// <summary>
    /// The female gender.
    /// <see href="http://schema.org/Female"></see></summary>
    let Female = Namespaced_IRI.parse _namespace_name "Female" |> NamespacedName
    /// <summary>
    /// An enumeration of genders.
    /// <see href="http://schema.org/GenderType"></see></summary>
    let GenderType = Namespaced_IRI.parse _namespace_name "GenderType" |> NamespacedName
    /// <summary>
    /// Event type: Festival.
    /// <see href="http://schema.org/Festival"></see></summary>
    let Festival = Namespaced_IRI.parse _namespace_name "Festival" |> NamespacedName
    /// <summary>
    /// The act of capturing sound and moving images on film, video, or digitally.
    /// <see href="http://schema.org/FilmAction"></see></summary>
    let FilmAction = Namespaced_IRI.parse _namespace_name "FilmAction" |> NamespacedName

    /// <summary>
    /// A fire station. With firemen.
    /// <see href="http://schema.org/FireStation"></see></summary>
    let FireStation =
        Namespaced_IRI.parse _namespace_name "FireStation" |> NamespacedName

    /// <summary>
    /// An airline flight.
    /// <see href="http://schema.org/Flight"></see></summary>
    let Flight = Namespaced_IRI.parse _namespace_name "Flight" |> NamespacedName

    /// <summary>
    /// A reservation for air travel.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/FlightReservation"></see></summary>
    let FlightReservation =
        Namespaced_IRI.parse _namespace_name "FlightReservation" |> NamespacedName

    /// <summary>
    /// Data type: Floating number.
    /// <see href="http://schema.org/Float"></see></summary>
    let Float = Namespaced_IRI.parse _namespace_name "Float" |> NamespacedName
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
    let Number = Namespaced_IRI.parse _namespace_name "Number" |> NamespacedName
    /// <summary>
    /// A florist.
    /// <see href="http://schema.org/Florist"></see></summary>
    let Florist = Namespaced_IRI.parse _namespace_name "Florist" |> NamespacedName

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
    let FollowAction =
        Namespaced_IRI.parse _namespace_name "FollowAction" |> NamespacedName

    /// <summary>
    /// A reservation to dine at a food-related business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// <see href="http://schema.org/FoodEstablishmentReservation"></see></summary>
    let FoodEstablishmentReservation =
        Namespaced_IRI.parse _namespace_name "FoodEstablishmentReservation" |> NamespacedName

    /// <summary>
    /// Event type: Food event.
    /// <see href="http://schema.org/FoodEvent"></see></summary>
    let FoodEvent = Namespaced_IRI.parse _namespace_name "FoodEvent" |> NamespacedName

    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// <see href="http://schema.org/FoodService"></see></summary>
    let FoodService =
        Namespaced_IRI.parse _namespace_name "FoodService" |> NamespacedName

    /// <summary>
    /// Four-wheel drive is a transmission layout where the engine primarily drives two wheels with a part-time four-wheel drive capability.
    /// <see href="http://schema.org/FourWheelDriveConfiguration"></see></summary>
    let FourWheelDriveConfiguration =
        Namespaced_IRI.parse _namespace_name "FourWheelDriveConfiguration" |> NamespacedName

    /// <summary>
    /// The day of the week between Thursday and Saturday.
    /// <see href="http://schema.org/Friday"></see></summary>
    let Friday = Namespaced_IRI.parse _namespace_name "Friday" |> NamespacedName
    /// <summary>
    /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.
    /// <see href="http://schema.org/sameAs"></see></summary>
    let sameAs = Namespaced_IRI.parse _namespace_name "sameAs" |> NamespacedName

    /// <summary>
    /// Front-wheel drive is a transmission layout where the engine drives the front wheels.
    /// <see href="http://schema.org/FrontWheelDriveConfiguration"></see></summary>
    let FrontWheelDriveConfiguration =
        Namespaced_IRI.parse _namespace_name "FrontWheelDriveConfiguration" |> NamespacedName

    /// <summary>
    /// A furniture store.
    /// <see href="http://schema.org/FurnitureStore"></see></summary>
    let FurnitureStore =
        Namespaced_IRI.parse _namespace_name "FurnitureStore" |> NamespacedName

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// <see href="http://schema.org/Game"></see></summary>
    let Game = Namespaced_IRI.parse _namespace_name "Game" |> NamespacedName
    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// <see href="http://schema.org/GameServer"></see></summary>
    let GameServer = Namespaced_IRI.parse _namespace_name "GameServer" |> NamespacedName

    /// <summary>
    /// Status of a game server.
    /// <see href="http://schema.org/GameServerStatus"></see></summary>
    let GameServerStatus =
        Namespaced_IRI.parse _namespace_name "GameServerStatus" |> NamespacedName

    /// <summary>
    /// A garden store.
    /// <see href="http://schema.org/GardenStore"></see></summary>
    let GardenStore =
        Namespaced_IRI.parse _namespace_name "GardenStore" |> NamespacedName

    /// <summary>
    /// A gas station.
    /// <see href="http://schema.org/GasStation"></see></summary>
    let GasStation = Namespaced_IRI.parse _namespace_name "GasStation" |> NamespacedName

    /// <summary>
    /// Residence type: Gated community.
    /// <see href="http://schema.org/GatedResidenceCommunity"></see></summary>
    let GatedResidenceCommunity =
        Namespaced_IRI.parse _namespace_name "GatedResidenceCommunity" |> NamespacedName

    /// <summary>
    /// A general contractor.
    /// <see href="http://schema.org/GeneralContractor"></see></summary>
    let GeneralContractor =
        Namespaced_IRI.parse _namespace_name "GeneralContractor" |> NamespacedName

    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    /// <see href="http://schema.org/GeoCircle"></see></summary>
    let GeoCircle = Namespaced_IRI.parse _namespace_name "GeoCircle" |> NamespacedName
    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// <see href="http://schema.org/GeoShape"></see></summary>
    let GeoShape = Namespaced_IRI.parse _namespace_name "GeoShape" |> NamespacedName

    /// <summary>
    /// The geographic coordinates of a place or event.
    /// <see href="http://schema.org/GeoCoordinates"></see></summary>
    let GeoCoordinates =
        Namespaced_IRI.parse _namespace_name "GeoCoordinates" |> NamespacedName

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
    let GiveAction = Namespaced_IRI.parse _namespace_name "GiveAction" |> NamespacedName

    /// <summary>
    /// A diet exclusive of gluten.
    /// <see href="http://schema.org/GlutenFreeDiet"></see></summary>
    let GlutenFreeDiet =
        Namespaced_IRI.parse _namespace_name "GlutenFreeDiet" |> NamespacedName

    /// <summary>
    /// A golf course.
    /// <see href="http://schema.org/GolfCourse"></see></summary>
    let GolfCourse = Namespaced_IRI.parse _namespace_name "GolfCourse" |> NamespacedName

    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// <see href="http://schema.org/GovernmentOffice"></see></summary>
    let GovernmentOffice =
        Namespaced_IRI.parse _namespace_name "GovernmentOffice" |> NamespacedName

    /// <summary>
    /// A governmental organization or agency.
    /// <see href="http://schema.org/GovernmentOrganization"></see></summary>
    let GovernmentOrganization =
        Namespaced_IRI.parse _namespace_name "GovernmentOrganization" |> NamespacedName

    /// <summary>
    /// A permit issued by a government agency.
    /// <see href="http://schema.org/GovernmentPermit"></see></summary>
    let GovernmentPermit =
        Namespaced_IRI.parse _namespace_name "GovernmentPermit" |> NamespacedName

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// <see href="http://schema.org/Permit"></see></summary>
    let Permit = Namespaced_IRI.parse _namespace_name "Permit" |> NamespacedName

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// <see href="http://schema.org/GovernmentService"></see></summary>
    let GovernmentService =
        Namespaced_IRI.parse _namespace_name "GovernmentService" |> NamespacedName

    /// <summary>
    /// A grocery store.
    /// <see href="http://schema.org/GroceryStore"></see></summary>
    let GroceryStore =
        Namespaced_IRI.parse _namespace_name "GroceryStore" |> NamespacedName

    /// <summary>
    /// The airline boards by groups based on check-in time, priority, etc.
    /// <see href="http://schema.org/GroupBoardingPolicy"></see></summary>
    let GroupBoardingPolicy =
        Namespaced_IRI.parse _namespace_name "GroupBoardingPolicy" |> NamespacedName

    /// <summary>
    /// A business that provide Heating, Ventilation and Air Conditioning services.
    /// <see href="http://schema.org/HVACBusiness"></see></summary>
    let HVACBusiness =
        Namespaced_IRI.parse _namespace_name "HVACBusiness" |> NamespacedName

    /// <summary>
    /// A hair salon.
    /// <see href="http://schema.org/HairSalon"></see></summary>
    let HairSalon = Namespaced_IRI.parse _namespace_name "HairSalon" |> NamespacedName
    /// <summary>
    /// A diet conforming to Islamic dietary practices.
    /// <see href="http://schema.org/HalalDiet"></see></summary>
    let HalalDiet = Namespaced_IRI.parse _namespace_name "HalalDiet" |> NamespacedName
    /// <summary>
    /// Book format: Hardcover.
    /// <see href="http://schema.org/Hardcover"></see></summary>
    let Hardcover = Namespaced_IRI.parse _namespace_name "Hardcover" |> NamespacedName

    /// <summary>
    /// A hardware store.
    /// <see href="http://schema.org/HardwareStore"></see></summary>
    let HardwareStore =
        Namespaced_IRI.parse _namespace_name "HardwareStore" |> NamespacedName

    /// <summary>
    /// A health club.
    /// <see href="http://schema.org/HealthClub"></see></summary>
    let HealthClub = Namespaced_IRI.parse _namespace_name "HealthClub" |> NamespacedName

    /// <summary>
    /// Uses devices to support users with hearing impairments.
    /// <see href="http://schema.org/HearingImpairedSupported"></see></summary>
    let HearingImpairedSupported =
        Namespaced_IRI.parse _namespace_name "HearingImpairedSupported" |> NamespacedName

    /// <summary>
    /// A high school.
    /// <see href="http://schema.org/HighSchool"></see></summary>
    let HighSchool = Namespaced_IRI.parse _namespace_name "HighSchool" |> NamespacedName
    /// <summary>
    /// A diet conforming to Hindu dietary practices, in particular, beef-free.
    /// <see href="http://schema.org/HinduDiet"></see></summary>
    let HinduDiet = Namespaced_IRI.parse _namespace_name "HinduDiet" |> NamespacedName

    /// <summary>
    /// A Hindu temple.
    /// <see href="http://schema.org/HinduTemple"></see></summary>
    let HinduTemple =
        Namespaced_IRI.parse _namespace_name "HinduTemple" |> NamespacedName

    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// <see href="http://schema.org/HobbyShop"></see></summary>
    let HobbyShop = Namespaced_IRI.parse _namespace_name "HobbyShop" |> NamespacedName

    /// <summary>
    /// A home goods store.
    /// <see href="http://schema.org/HomeGoodsStore"></see></summary>
    let HomeGoodsStore =
        Namespaced_IRI.parse _namespace_name "HomeGoodsStore" |> NamespacedName

    /// <summary>
    /// A hospital.
    /// <see href="http://schema.org/Hospital"></see></summary>
    let Hospital = Namespaced_IRI.parse _namespace_name "Hospital" |> NamespacedName
    /// <summary>
    /// A hostel - cheap accommodation, often in shared dormitories.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Hostel"></see></summary>
    let Hostel = Namespaced_IRI.parse _namespace_name "Hostel" |> NamespacedName
    /// <summary>
    /// A hotel is an establishment that provides lodging paid on a short-term basis (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Hotel"></see></summary>
    let Hotel = Namespaced_IRI.parse _namespace_name "Hotel" |> NamespacedName
    /// <summary>
    /// A hotel room is a single room in a hotel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/HotelRoom"></see></summary>
    let HotelRoom = Namespaced_IRI.parse _namespace_name "HotelRoom" |> NamespacedName
    /// <summary>
    /// A room is a distinguishable space within a structure, usually separated from other spaces by interior walls. (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Room"&gt;http://en.wikipedia.org/wiki/Room&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Room"></see></summary>
    let Room = Namespaced_IRI.parse _namespace_name "Room" |> NamespacedName
    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// <see href="http://schema.org/House"></see></summary>
    let House = Namespaced_IRI.parse _namespace_name "House" |> NamespacedName

    /// <summary>
    /// A house painting service.
    /// <see href="http://schema.org/HousePainter"></see></summary>
    let HousePainter =
        Namespaced_IRI.parse _namespace_name "HousePainter" |> NamespacedName

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// <see href="http://schema.org/HowTo"></see></summary>
    let HowTo = Namespaced_IRI.parse _namespace_name "HowTo" |> NamespacedName

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// <see href="http://schema.org/HowToDirection"></see></summary>
    let HowToDirection =
        Namespaced_IRI.parse _namespace_name "HowToDirection" |> NamespacedName

    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// <see href="http://schema.org/ListItem"></see></summary>
    let ListItem = Namespaced_IRI.parse _namespace_name "ListItem" |> NamespacedName
    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// <see href="http://schema.org/HowToItem"></see></summary>
    let HowToItem = Namespaced_IRI.parse _namespace_name "HowToItem" |> NamespacedName

    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// <see href="http://schema.org/HowToSection"></see></summary>
    let HowToSection =
        Namespaced_IRI.parse _namespace_name "HowToSection" |> NamespacedName

    /// <summary>
    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    /// <see href="http://schema.org/HowToStep"></see></summary>
    let HowToStep = Namespaced_IRI.parse _namespace_name "HowToStep" |> NamespacedName

    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// <see href="http://schema.org/HowToSupply"></see></summary>
    let HowToSupply =
        Namespaced_IRI.parse _namespace_name "HowToSupply" |> NamespacedName

    /// <summary>
    /// An explanation in the instructions for how to achieve a result. It provides supplementary information about a technique, supply, author's preference, etc. It can explain what could be done, or what should not be done, but doesn't specify what should be done (see HowToDirection).
    /// <see href="http://schema.org/HowToTip"></see></summary>
    let HowToTip = Namespaced_IRI.parse _namespace_name "HowToTip" |> NamespacedName
    /// <summary>
    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    /// <see href="http://schema.org/HowToTool"></see></summary>
    let HowToTool = Namespaced_IRI.parse _namespace_name "HowToTool" |> NamespacedName

    /// <summary>
    /// An ice cream shop.
    /// <see href="http://schema.org/IceCreamShop"></see></summary>
    let IceCreamShop =
        Namespaced_IRI.parse _namespace_name "IceCreamShop" |> NamespacedName

    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// <see href="http://schema.org/IgnoreAction"></see></summary>
    let IgnoreAction =
        Namespaced_IRI.parse _namespace_name "IgnoreAction" |> NamespacedName

    /// <summary>
    /// Web page type: Image gallery page.
    /// <see href="http://schema.org/ImageGallery"></see></summary>
    let ImageGallery =
        Namespaced_IRI.parse _namespace_name "ImageGallery" |> NamespacedName

    /// <summary>
    /// Web page type: Media gallery page. A mixed-media page that can contains media such as images, videos, and other multimedia.
    /// <see href="http://schema.org/MediaGallery"></see></summary>
    let MediaGallery =
        Namespaced_IRI.parse _namespace_name "MediaGallery" |> NamespacedName

    /// <summary>
    /// Indicates that the item is in stock.
    /// <see href="http://schema.org/InStock"></see></summary>
    let InStock = Namespaced_IRI.parse _namespace_name "InStock" |> NamespacedName

    /// <summary>
    /// Indicates that the item is available only at physical locations.
    /// <see href="http://schema.org/InStoreOnly"></see></summary>
    let InStoreOnly =
        Namespaced_IRI.parse _namespace_name "InStoreOnly" |> NamespacedName

    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// <see href="http://schema.org/IndividualProduct"></see></summary>
    let IndividualProduct =
        Namespaced_IRI.parse _namespace_name "IndividualProduct" |> NamespacedName

    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// <see href="http://schema.org/Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName

    /// <summary>
    /// The act of installing an application.
    /// <see href="http://schema.org/InstallAction"></see></summary>
    let InstallAction =
        Namespaced_IRI.parse _namespace_name "InstallAction" |> NamespacedName

    /// <summary>
    /// An Insurance agency.
    /// <see href="http://schema.org/InsuranceAgency"></see></summary>
    let InsuranceAgency =
        Namespaced_IRI.parse _namespace_name "InsuranceAgency" |> NamespacedName

    /// <summary>
    /// Data type: Integer.
    /// <see href="http://schema.org/Integer"></see></summary>
    let Integer = Namespaced_IRI.parse _namespace_name "Integer" |> NamespacedName

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// <see href="http://schema.org/InteractionCounter"></see></summary>
    let InteractionCounter =
        Namespaced_IRI.parse _namespace_name "InteractionCounter" |> NamespacedName

    /// <summary>
    /// An internet cafe.
    /// <see href="http://schema.org/InternetCafe"></see></summary>
    let InternetCafe =
        Namespaced_IRI.parse _namespace_name "InternetCafe" |> NamespacedName

    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// <see href="http://schema.org/InviteAction"></see></summary>
    let InviteAction =
        Namespaced_IRI.parse _namespace_name "InviteAction" |> NamespacedName

    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// <see href="http://schema.org/Invoice"></see></summary>
    let Invoice = Namespaced_IRI.parse _namespace_name "Invoice" |> NamespacedName

    /// <summary>
    /// An ItemList ordered with lower values listed first.
    /// <see href="http://schema.org/ItemListOrderAscending"></see></summary>
    let ItemListOrderAscending =
        Namespaced_IRI.parse _namespace_name "ItemListOrderAscending" |> NamespacedName

    /// <summary>
    /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    /// <see href="http://schema.org/ItemListOrderType"></see></summary>
    let ItemListOrderType =
        Namespaced_IRI.parse _namespace_name "ItemListOrderType" |> NamespacedName

    /// <summary>
    /// An ItemList ordered with higher values listed first.
    /// <see href="http://schema.org/ItemListOrderDescending"></see></summary>
    let ItemListOrderDescending =
        Namespaced_IRI.parse _namespace_name "ItemListOrderDescending" |> NamespacedName

    /// <summary>
    /// An ItemList ordered with no explicit order.
    /// <see href="http://schema.org/ItemListUnordered"></see></summary>
    let ItemListUnordered =
        Namespaced_IRI.parse _namespace_name "ItemListUnordered" |> NamespacedName

    /// <summary>
    /// A page devoted to a single item, such as a particular product or hotel.
    /// <see href="http://schema.org/ItemPage"></see></summary>
    let ItemPage = Namespaced_IRI.parse _namespace_name "ItemPage" |> NamespacedName

    /// <summary>
    /// A jewelry store.
    /// <see href="http://schema.org/JewelryStore"></see></summary>
    let JewelryStore =
        Namespaced_IRI.parse _namespace_name "JewelryStore" |> NamespacedName

    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// <see href="http://schema.org/JobPosting"></see></summary>
    let JobPosting = Namespaced_IRI.parse _namespace_name "JobPosting" |> NamespacedName
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
    let JoinAction = Namespaced_IRI.parse _namespace_name "JoinAction" |> NamespacedName
    /// <summary>
    /// A diet conforming to Jewish dietary practices.
    /// <see href="http://schema.org/KosherDiet"></see></summary>
    let KosherDiet = Namespaced_IRI.parse _namespace_name "KosherDiet" |> NamespacedName

    /// <summary>
    /// A lake (for example, Lake Pontrachain).
    /// <see href="http://schema.org/LakeBodyOfWater"></see></summary>
    let LakeBodyOfWater =
        Namespaced_IRI.parse _namespace_name "LakeBodyOfWater" |> NamespacedName

    /// <summary>
    /// An historical landmark or building.
    /// <see href="http://schema.org/LandmarksOrHistoricalBuildings"></see></summary>
    let LandmarksOrHistoricalBuildings =
        Namespaced_IRI.parse _namespace_name "LandmarksOrHistoricalBuildings" |> NamespacedName

    /// <summary>
    /// Natural languages such as Spanish, Tamil, Hindi, English, etc. Formal language code tags expressed in &lt;a href="https://en.wikipedia.org/wiki/IETF_language_tag"&gt;BCP 47&lt;/a&gt; can be used via the &lt;a class="localLink" href="http://schema.org/alternateName"&gt;alternateName&lt;/a&gt; property. The Language type previously also covered programming languages such as Scheme and Lisp, which are now best represented using &lt;a class="localLink" href="http://schema.org/ComputerLanguage"&gt;ComputerLanguage&lt;/a&gt;.
    /// <see href="http://schema.org/Language"></see></summary>
    let Language = Namespaced_IRI.parse _namespace_name "Language" |> NamespacedName

    /// <summary>
    /// LaserDiscFormat.
    /// <see href="http://schema.org/LaserDiscFormat"></see></summary>
    let LaserDiscFormat =
        Namespaced_IRI.parse _namespace_name "LaserDiscFormat" |> NamespacedName

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
    let LeaveAction =
        Namespaced_IRI.parse _namespace_name "LeaveAction" |> NamespacedName

    /// <summary>
    /// The steering position is on the left side of the vehicle (viewed from the main direction of driving).
    /// <see href="http://schema.org/LeftHandDriving"></see></summary>
    let LeftHandDriving =
        Namespaced_IRI.parse _namespace_name "LeftHandDriving" |> NamespacedName

    /// <summary>
    /// A value indicating a steering position.
    /// <see href="http://schema.org/SteeringPositionValue"></see></summary>
    let SteeringPositionValue =
        Namespaced_IRI.parse _namespace_name "SteeringPositionValue" |> NamespacedName

    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// <see href="http://schema.org/LegislativeBuilding"></see></summary>
    let LegislativeBuilding =
        Namespaced_IRI.parse _namespace_name "LegislativeBuilding" |> NamespacedName

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
    let LendAction = Namespaced_IRI.parse _namespace_name "LendAction" |> NamespacedName
    /// <summary>
    /// A library.
    /// <see href="http://schema.org/Library"></see></summary>
    let Library = Namespaced_IRI.parse _namespace_name "Library" |> NamespacedName
    /// <summary>
    /// The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.
    /// <see href="http://schema.org/LikeAction"></see></summary>
    let LikeAction = Namespaced_IRI.parse _namespace_name "LikeAction" |> NamespacedName

    /// <summary>
    /// Indicates that the item has limited availability.
    /// <see href="http://schema.org/LimitedAvailability"></see></summary>
    let LimitedAvailability =
        Namespaced_IRI.parse _namespace_name "LimitedAvailability" |> NamespacedName

    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// <see href="http://schema.org/LiquorStore"></see></summary>
    let LiquorStore =
        Namespaced_IRI.parse _namespace_name "LiquorStore" |> NamespacedName

    /// <summary>
    /// The act of consuming audio content.
    /// <see href="http://schema.org/ListenAction"></see></summary>
    let ListenAction =
        Namespaced_IRI.parse _namespace_name "ListenAction" |> NamespacedName

    /// <summary>
    /// Event type: Literary event.
    /// <see href="http://schema.org/LiteraryEvent"></see></summary>
    let LiteraryEvent =
        Namespaced_IRI.parse _namespace_name "LiteraryEvent" |> NamespacedName

    /// <summary>
    /// LiveAlbum.
    /// <see href="http://schema.org/LiveAlbum"></see></summary>
    let LiveAlbum = Namespaced_IRI.parse _namespace_name "LiveAlbum" |> NamespacedName

    /// <summary>
    /// A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// <see href="http://schema.org/LiveBlogPosting"></see></summary>
    let LiveBlogPosting =
        Namespaced_IRI.parse _namespace_name "LiveBlogPosting" |> NamespacedName

    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// <see href="http://schema.org/LocationFeatureSpecification"></see></summary>
    let LocationFeatureSpecification =
        Namespaced_IRI.parse _namespace_name "LocationFeatureSpecification" |> NamespacedName

    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    /// <see href="http://schema.org/PropertyValue"></see></summary>
    let PropertyValue =
        Namespaced_IRI.parse _namespace_name "PropertyValue" |> NamespacedName

    /// <summary>
    /// A DeliveryMethod in which an item is made available via locker.
    /// <see href="http://schema.org/LockerDelivery"></see></summary>
    let LockerDelivery =
        Namespaced_IRI.parse _namespace_name "LockerDelivery" |> NamespacedName

    /// <summary>
    /// A locksmith.
    /// <see href="http://schema.org/Locksmith"></see></summary>
    let Locksmith = Namespaced_IRI.parse _namespace_name "Locksmith" |> NamespacedName

    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// <see href="http://schema.org/LodgingReservation"></see></summary>
    let LodgingReservation =
        Namespaced_IRI.parse _namespace_name "LodgingReservation" |> NamespacedName

    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// <see href="http://schema.org/LoseAction"></see></summary>
    let LoseAction = Namespaced_IRI.parse _namespace_name "LoseAction" |> NamespacedName

    /// <summary>
    /// A diet focused on reduced calorie intake.
    /// <see href="http://schema.org/LowCalorieDiet"></see></summary>
    let LowCalorieDiet =
        Namespaced_IRI.parse _namespace_name "LowCalorieDiet" |> NamespacedName

    /// <summary>
    /// A diet focused on reduced fat and cholesterol intake.
    /// <see href="http://schema.org/LowFatDiet"></see></summary>
    let LowFatDiet = Namespaced_IRI.parse _namespace_name "LowFatDiet" |> NamespacedName

    /// <summary>
    /// A diet appropriate for people with lactose intolerance.
    /// <see href="http://schema.org/LowLactoseDiet"></see></summary>
    let LowLactoseDiet =
        Namespaced_IRI.parse _namespace_name "LowLactoseDiet" |> NamespacedName

    /// <summary>
    /// A diet focused on reduced sodium intake.
    /// <see href="http://schema.org/LowSaltDiet"></see></summary>
    let LowSaltDiet =
        Namespaced_IRI.parse _namespace_name "LowSaltDiet" |> NamespacedName

    /// <summary>
    /// The male gender.
    /// <see href="http://schema.org/Male"></see></summary>
    let Male = Namespaced_IRI.parse _namespace_name "Male" |> NamespacedName
    /// <summary>
    /// A map.
    /// <see href="http://schema.org/Map"></see></summary>
    let Map = Namespaced_IRI.parse _namespace_name "Map" |> NamespacedName

    /// <summary>
    /// An enumeration of several kinds of Map.
    /// <see href="http://schema.org/MapCategoryType"></see></summary>
    let MapCategoryType =
        Namespaced_IRI.parse _namespace_name "MapCategoryType" |> NamespacedName

    /// <summary>
    /// The act of marrying a person.
    /// <see href="http://schema.org/MarryAction"></see></summary>
    let MarryAction =
        Namespaced_IRI.parse _namespace_name "MarryAction" |> NamespacedName

    /// <summary>
    /// Properties that take Mass as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Mass unit of measure&amp;gt;'. E.g., '7 kg'.
    /// <see href="http://schema.org/Mass"></see></summary>
    let Mass = Namespaced_IRI.parse _namespace_name "Mass" |> NamespacedName

    /// <summary>
    /// A subscription which allows a user to access media including audio, video, books, etc.
    /// <see href="http://schema.org/MediaSubscription"></see></summary>
    let MediaSubscription =
        Namespaced_IRI.parse _namespace_name "MediaSubscription" |> NamespacedName

    /// <summary>
    /// A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Conference_hall"&gt;http://en.wikipedia.org/wiki/Conference_hall&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/MeetingRoom"></see></summary>
    let MeetingRoom =
        Namespaced_IRI.parse _namespace_name "MeetingRoom" |> NamespacedName

    /// <summary>
    /// A men's clothing store.
    /// <see href="http://schema.org/MensClothingStore"></see></summary>
    let MensClothingStore =
        Namespaced_IRI.parse _namespace_name "MensClothingStore" |> NamespacedName

    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// <see href="http://schema.org/Menu"></see></summary>
    let Menu = Namespaced_IRI.parse _namespace_name "Menu" |> NamespacedName
    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// <see href="http://schema.org/MenuItem"></see></summary>
    let MenuItem = Namespaced_IRI.parse _namespace_name "MenuItem" |> NamespacedName

    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    /// <see href="http://schema.org/MenuSection"></see></summary>
    let MenuSection =
        Namespaced_IRI.parse _namespace_name "MenuSection" |> NamespacedName

    /// <summary>
    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    /// <see href="http://schema.org/MiddleSchool"></see></summary>
    let MiddleSchool =
        Namespaced_IRI.parse _namespace_name "MiddleSchool" |> NamespacedName

    /// <summary>
    /// MixtapeAlbum.
    /// <see href="http://schema.org/MixtapeAlbum"></see></summary>
    let MixtapeAlbum =
        Namespaced_IRI.parse _namespace_name "MixtapeAlbum" |> NamespacedName

    /// <summary>
    /// A software application designed specifically to work well on a mobile device such as a telephone.
    /// <see href="http://schema.org/MobileApplication"></see></summary>
    let MobileApplication =
        Namespaced_IRI.parse _namespace_name "MobileApplication" |> NamespacedName

    /// <summary>
    /// A software application.
    /// <see href="http://schema.org/SoftwareApplication"></see></summary>
    let SoftwareApplication =
        Namespaced_IRI.parse _namespace_name "SoftwareApplication" |> NamespacedName

    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// <see href="http://schema.org/MobilePhoneStore"></see></summary>
    let MobilePhoneStore =
        Namespaced_IRI.parse _namespace_name "MobilePhoneStore" |> NamespacedName

    /// <summary>
    /// The day of the week between Sunday and Tuesday.
    /// <see href="http://schema.org/Monday"></see></summary>
    let Monday = Namespaced_IRI.parse _namespace_name "Monday" |> NamespacedName

    /// <summary>
    /// A statistical distribution of monetary amounts.
    /// <see href="http://schema.org/MonetaryAmountDistribution"></see></summary>
    let MonetaryAmountDistribution =
        Namespaced_IRI.parse _namespace_name "MonetaryAmountDistribution" |> NamespacedName

    /// <summary>
    /// A statistical distribution of values.
    /// <see href="http://schema.org/QuantitativeValueDistribution"></see></summary>
    let QuantitativeValueDistribution =
        Namespaced_IRI.parse _namespace_name "QuantitativeValueDistribution" |> NamespacedName

    /// <summary>
    /// A mosque.
    /// <see href="http://schema.org/Mosque"></see></summary>
    let Mosque = Namespaced_IRI.parse _namespace_name "Mosque" |> NamespacedName
    /// <summary>
    /// A motel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Motel"></see></summary>
    let Motel = Namespaced_IRI.parse _namespace_name "Motel" |> NamespacedName

    /// <summary>
    /// A motorcycle dealer.
    /// <see href="http://schema.org/MotorcycleDealer"></see></summary>
    let MotorcycleDealer =
        Namespaced_IRI.parse _namespace_name "MotorcycleDealer" |> NamespacedName

    /// <summary>
    /// A motorcycle repair shop.
    /// <see href="http://schema.org/MotorcycleRepair"></see></summary>
    let MotorcycleRepair =
        Namespaced_IRI.parse _namespace_name "MotorcycleRepair" |> NamespacedName

    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// <see href="http://schema.org/Mountain"></see></summary>
    let Mountain = Namespaced_IRI.parse _namespace_name "Mountain" |> NamespacedName
    /// <summary>
    /// A movie.
    /// <see href="http://schema.org/Movie"></see></summary>
    let Movie = Namespaced_IRI.parse _namespace_name "Movie" |> NamespacedName
    /// <summary>
    /// A short segment/part of a movie.
    /// <see href="http://schema.org/MovieClip"></see></summary>
    let MovieClip = Namespaced_IRI.parse _namespace_name "MovieClip" |> NamespacedName

    /// <summary>
    /// A movie rental store.
    /// <see href="http://schema.org/MovieRentalStore"></see></summary>
    let MovieRentalStore =
        Namespaced_IRI.parse _namespace_name "MovieRentalStore" |> NamespacedName

    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// <see href="http://schema.org/MovieSeries"></see></summary>
    let MovieSeries =
        Namespaced_IRI.parse _namespace_name "MovieSeries" |> NamespacedName

    /// <summary>
    /// A movie theater.
    /// <see href="http://schema.org/MovieTheater"></see></summary>
    let MovieTheater =
        Namespaced_IRI.parse _namespace_name "MovieTheater" |> NamespacedName

    /// <summary>
    /// A moving company.
    /// <see href="http://schema.org/MovingCompany"></see></summary>
    let MovingCompany =
        Namespaced_IRI.parse _namespace_name "MovingCompany" |> NamespacedName

    /// <summary>
    /// Play mode: MultiPlayer. Requiring or allowing multiple human players to play simultaneously.
    /// <see href="http://schema.org/MultiPlayer"></see></summary>
    let MultiPlayer =
        Namespaced_IRI.parse _namespace_name "MultiPlayer" |> NamespacedName

    /// <summary>
    /// A museum.
    /// <see href="http://schema.org/Museum"></see></summary>
    let Museum = Namespaced_IRI.parse _namespace_name "Museum" |> NamespacedName
    /// <summary>
    /// A collection of music tracks.
    /// <see href="http://schema.org/MusicAlbum"></see></summary>
    let MusicAlbum = Namespaced_IRI.parse _namespace_name "MusicAlbum" |> NamespacedName

    /// <summary>
    /// A collection of music tracks in playlist form.
    /// <see href="http://schema.org/MusicPlaylist"></see></summary>
    let MusicPlaylist =
        Namespaced_IRI.parse _namespace_name "MusicPlaylist" |> NamespacedName

    /// <summary>
    /// A musical composition.
    /// <see href="http://schema.org/MusicComposition"></see></summary>
    let MusicComposition =
        Namespaced_IRI.parse _namespace_name "MusicComposition" |> NamespacedName

    /// <summary>
    /// Event type: Music event.
    /// <see href="http://schema.org/MusicEvent"></see></summary>
    let MusicEvent = Namespaced_IRI.parse _namespace_name "MusicEvent" |> NamespacedName
    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// <see href="http://schema.org/MusicGroup"></see></summary>
    let MusicGroup = Namespaced_IRI.parse _namespace_name "MusicGroup" |> NamespacedName

    /// <summary>
    /// A music recording (track), usually a single song.
    /// <see href="http://schema.org/MusicRecording"></see></summary>
    let MusicRecording =
        Namespaced_IRI.parse _namespace_name "MusicRecording" |> NamespacedName

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// <see href="http://schema.org/MusicRelease"></see></summary>
    let MusicRelease =
        Namespaced_IRI.parse _namespace_name "MusicRelease" |> NamespacedName

    /// <summary>
    /// A music store.
    /// <see href="http://schema.org/MusicStore"></see></summary>
    let MusicStore = Namespaced_IRI.parse _namespace_name "MusicStore" |> NamespacedName
    /// <summary>
    /// A music venue.
    /// <see href="http://schema.org/MusicVenue"></see></summary>
    let MusicVenue = Namespaced_IRI.parse _namespace_name "MusicVenue" |> NamespacedName

    /// <summary>
    /// A music video file.
    /// <see href="http://schema.org/MusicVideoObject"></see></summary>
    let MusicVideoObject =
        Namespaced_IRI.parse _namespace_name "MusicVideoObject" |> NamespacedName

    /// <summary>
    /// Organization: Non-governmental Organization.
    /// <see href="http://schema.org/NGO"></see></summary>
    let NGO = Namespaced_IRI.parse _namespace_name "NGO" |> NamespacedName
    /// <summary>
    /// A nail salon.
    /// <see href="http://schema.org/NailSalon"></see></summary>
    let NailSalon = Namespaced_IRI.parse _namespace_name "NailSalon" |> NamespacedName

    /// <summary>
    /// Indicates that the item is new.
    /// <see href="http://schema.org/NewCondition"></see></summary>
    let NewCondition =
        Namespaced_IRI.parse _namespace_name "NewCondition" |> NamespacedName

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.&lt;br/&gt;&lt;br/&gt;
    ///
    /// A more detailed overview of &lt;a href="/docs/news.html"&gt;schema.org News markup&lt;/a&gt; is also available.
    /// <see href="http://schema.org/NewsArticle"></see></summary>
    let NewsArticle =
        Namespaced_IRI.parse _namespace_name "NewsArticle" |> NamespacedName

    /// <summary>
    /// A nightclub or discotheque.
    /// <see href="http://schema.org/NightClub"></see></summary>
    let NightClub = Namespaced_IRI.parse _namespace_name "NightClub" |> NamespacedName
    /// <summary>
    /// A notary.
    /// <see href="http://schema.org/Notary"></see></summary>
    let Notary = Namespaced_IRI.parse _namespace_name "Notary" |> NamespacedName

    /// <summary>
    /// A file containing a note, primarily for the author.
    /// <see href="http://schema.org/NoteDigitalDocument"></see></summary>
    let NoteDigitalDocument =
        Namespaced_IRI.parse _namespace_name "NoteDigitalDocument" |> NamespacedName

    /// <summary>
    /// Nutritional information about the recipe.
    /// <see href="http://schema.org/NutritionInformation"></see></summary>
    let NutritionInformation =
        Namespaced_IRI.parse _namespace_name "NutritionInformation" |> NamespacedName

    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// <see href="http://schema.org/Occupation"></see></summary>
    let Occupation = Namespaced_IRI.parse _namespace_name "Occupation" |> NamespacedName

    /// <summary>
    /// An ocean (for example, the Pacific).
    /// <see href="http://schema.org/OceanBodyOfWater"></see></summary>
    let OceanBodyOfWater =
        Namespaced_IRI.parse _namespace_name "OceanBodyOfWater" |> NamespacedName

    /// <summary>
    /// An OfferCatalog is an ItemList that contains related Offers and/or further OfferCatalogs that are offeredBy the same provider.
    /// <see href="http://schema.org/OfferCatalog"></see></summary>
    let OfferCatalog =
        Namespaced_IRI.parse _namespace_name "OfferCatalog" |> NamespacedName

    /// <summary>
    /// An office equipment store.
    /// <see href="http://schema.org/OfficeEquipmentStore"></see></summary>
    let OfficeEquipmentStore =
        Namespaced_IRI.parse _namespace_name "OfficeEquipmentStore" |> NamespacedName

    /// <summary>
    /// Game server status: OfflinePermanently. Server is offline and not available.
    /// <see href="http://schema.org/OfflinePermanently"></see></summary>
    let OfflinePermanently =
        Namespaced_IRI.parse _namespace_name "OfflinePermanently" |> NamespacedName

    /// <summary>
    /// Game server status: OfflineTemporarily. Server is offline now but it can be online soon.
    /// <see href="http://schema.org/OfflineTemporarily"></see></summary>
    let OfflineTemporarily =
        Namespaced_IRI.parse _namespace_name "OfflineTemporarily" |> NamespacedName

    /// <summary>
    /// A publication event e.g. catch-up TV or radio podcast, during which a program is available on-demand.
    /// <see href="http://schema.org/OnDemandEvent"></see></summary>
    let OnDemandEvent =
        Namespaced_IRI.parse _namespace_name "OnDemandEvent" |> NamespacedName

    /// <summary>
    /// A DeliveryMethod in which an item is collected on site, e.g. in a store or at a box office.
    /// <see href="http://schema.org/OnSitePickup"></see></summary>
    let OnSitePickup =
        Namespaced_IRI.parse _namespace_name "OnSitePickup" |> NamespacedName

    /// <summary>
    /// Game server status: Online. Server is available.
    /// <see href="http://schema.org/Online"></see></summary>
    let Online = Namespaced_IRI.parse _namespace_name "Online" |> NamespacedName
    /// <summary>
    /// Game server status: OnlineFull. Server is online but unavailable. The maximum number of players has reached.
    /// <see href="http://schema.org/OnlineFull"></see></summary>
    let OnlineFull = Namespaced_IRI.parse _namespace_name "OnlineFull" |> NamespacedName
    /// <summary>
    /// Indicates that the item is available only online.
    /// <see href="http://schema.org/OnlineOnly"></see></summary>
    let OnlineOnly = Namespaced_IRI.parse _namespace_name "OnlineOnly" |> NamespacedName

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;br/&gt;&lt;br/&gt;
    ///
    /// If the value for the &lt;a class="localLink" href="http://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.
    /// <see href="http://schema.org/OpeningHoursSpecification"></see></summary>
    let OpeningHoursSpecification =
        Namespaced_IRI.parse _namespace_name "OpeningHoursSpecification" |> NamespacedName

    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// <see href="http://schema.org/Order"></see></summary>
    let Order = Namespaced_IRI.parse _namespace_name "Order" |> NamespacedName

    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// <see href="http://schema.org/OrderAction"></see></summary>
    let OrderAction =
        Namespaced_IRI.parse _namespace_name "OrderAction" |> NamespacedName

    /// <summary>
    /// OrderStatus representing cancellation of an order.
    /// <see href="http://schema.org/OrderCancelled"></see></summary>
    let OrderCancelled =
        Namespaced_IRI.parse _namespace_name "OrderCancelled" |> NamespacedName

    /// <summary>
    /// Enumerated status values for Order.
    /// <see href="http://schema.org/OrderStatus"></see></summary>
    let OrderStatus =
        Namespaced_IRI.parse _namespace_name "OrderStatus" |> NamespacedName

    /// <summary>
    /// OrderStatus representing successful delivery of an order.
    /// <see href="http://schema.org/OrderDelivered"></see></summary>
    let OrderDelivered =
        Namespaced_IRI.parse _namespace_name "OrderDelivered" |> NamespacedName

    /// <summary>
    /// OrderStatus representing that an order is in transit.
    /// <see href="http://schema.org/OrderInTransit"></see></summary>
    let OrderInTransit =
        Namespaced_IRI.parse _namespace_name "OrderInTransit" |> NamespacedName

    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// <see href="http://schema.org/OrderItem"></see></summary>
    let OrderItem = Namespaced_IRI.parse _namespace_name "OrderItem" |> NamespacedName

    /// <summary>
    /// OrderStatus representing that payment is due on an order.
    /// <see href="http://schema.org/OrderPaymentDue"></see></summary>
    let OrderPaymentDue =
        Namespaced_IRI.parse _namespace_name "OrderPaymentDue" |> NamespacedName

    /// <summary>
    /// OrderStatus representing availability of an order for pickup.
    /// <see href="http://schema.org/OrderPickupAvailable"></see></summary>
    let OrderPickupAvailable =
        Namespaced_IRI.parse _namespace_name "OrderPickupAvailable" |> NamespacedName

    /// <summary>
    /// OrderStatus representing that there is a problem with the order.
    /// <see href="http://schema.org/OrderProblem"></see></summary>
    let OrderProblem =
        Namespaced_IRI.parse _namespace_name "OrderProblem" |> NamespacedName

    /// <summary>
    /// OrderStatus representing that an order is being processed.
    /// <see href="http://schema.org/OrderProcessing"></see></summary>
    let OrderProcessing =
        Namespaced_IRI.parse _namespace_name "OrderProcessing" |> NamespacedName

    /// <summary>
    /// OrderStatus representing that an order has been returned.
    /// <see href="http://schema.org/OrderReturned"></see></summary>
    let OrderReturned =
        Namespaced_IRI.parse _namespace_name "OrderReturned" |> NamespacedName

    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/06/introducing-role.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/Role"></see></summary>
    let Role = Namespaced_IRI.parse _namespace_name "Role" |> NamespacedName
    /// <summary>
    /// Indicates that the item is out of stock.
    /// <see href="http://schema.org/OutOfStock"></see></summary>
    let OutOfStock = Namespaced_IRI.parse _namespace_name "OutOfStock" |> NamespacedName

    /// <summary>
    /// An outlet store.
    /// <see href="http://schema.org/OutletStore"></see></summary>
    let OutletStore =
        Namespaced_IRI.parse _namespace_name "OutletStore" |> NamespacedName

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// <see href="http://schema.org/OwnershipInfo"></see></summary>
    let OwnershipInfo =
        Namespaced_IRI.parse _namespace_name "OwnershipInfo" |> NamespacedName

    /// <summary>
    /// The act of producing a painting, typically with paint and canvas as instruments.
    /// <see href="http://schema.org/PaintAction"></see></summary>
    let PaintAction =
        Namespaced_IRI.parse _namespace_name "PaintAction" |> NamespacedName

    /// <summary>
    /// A painting.
    /// <see href="http://schema.org/Painting"></see></summary>
    let Painting = Namespaced_IRI.parse _namespace_name "Painting" |> NamespacedName
    /// <summary>
    /// Book format: Paperback.
    /// <see href="http://schema.org/Paperback"></see></summary>
    let Paperback = Namespaced_IRI.parse _namespace_name "Paperback" |> NamespacedName

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// <see href="http://schema.org/ParcelDelivery"></see></summary>
    let ParcelDelivery =
        Namespaced_IRI.parse _namespace_name "ParcelDelivery" |> NamespacedName

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
    let ParcelService =
        Namespaced_IRI.parse _namespace_name "ParcelService" |> NamespacedName

    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// <see href="http://schema.org/ParentAudience"></see></summary>
    let ParentAudience =
        Namespaced_IRI.parse _namespace_name "ParentAudience" |> NamespacedName

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// <see href="http://schema.org/PeopleAudience"></see></summary>
    let PeopleAudience =
        Namespaced_IRI.parse _namespace_name "PeopleAudience" |> NamespacedName

    /// <summary>
    /// A park.
    /// <see href="http://schema.org/Park"></see></summary>
    let Park = Namespaced_IRI.parse _namespace_name "Park" |> NamespacedName

    /// <summary>
    /// A parking lot or other parking facility.
    /// <see href="http://schema.org/ParkingFacility"></see></summary>
    let ParkingFacility =
        Namespaced_IRI.parse _namespace_name "ParkingFacility" |> NamespacedName

    /// <summary>
    /// A parking map.
    /// <see href="http://schema.org/ParkingMap"></see></summary>
    let ParkingMap = Namespaced_IRI.parse _namespace_name "ParkingMap" |> NamespacedName
    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// <see href="http://schema.org/PawnShop"></see></summary>
    let PawnShop = Namespaced_IRI.parse _namespace_name "PawnShop" |> NamespacedName
    /// <summary>
    /// An agent pays a price to a participant.
    /// <see href="http://schema.org/PayAction"></see></summary>
    let PayAction = Namespaced_IRI.parse _namespace_name "PayAction" |> NamespacedName

    /// <summary>
    /// An automatic payment system is in place and will be used.
    /// <see href="http://schema.org/PaymentAutomaticallyApplied"></see></summary>
    let PaymentAutomaticallyApplied =
        Namespaced_IRI.parse _namespace_name "PaymentAutomaticallyApplied" |> NamespacedName

    /// <summary>
    /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    /// <see href="http://schema.org/PaymentStatusType"></see></summary>
    let PaymentStatusType =
        Namespaced_IRI.parse _namespace_name "PaymentStatusType" |> NamespacedName

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
    let PaymentMethod =
        Namespaced_IRI.parse _namespace_name "PaymentMethod" |> NamespacedName

    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// <see href="http://schema.org/PaymentChargeSpecification"></see></summary>
    let PaymentChargeSpecification =
        Namespaced_IRI.parse _namespace_name "PaymentChargeSpecification" |> NamespacedName

    /// <summary>
    /// The payment has been received and processed.
    /// <see href="http://schema.org/PaymentComplete"></see></summary>
    let PaymentComplete =
        Namespaced_IRI.parse _namespace_name "PaymentComplete" |> NamespacedName

    /// <summary>
    /// The payee received the payment, but it was declined for some reason.
    /// <see href="http://schema.org/PaymentDeclined"></see></summary>
    let PaymentDeclined =
        Namespaced_IRI.parse _namespace_name "PaymentDeclined" |> NamespacedName

    /// <summary>
    /// The payment is due, but still within an acceptable time to be received.
    /// <see href="http://schema.org/PaymentDue"></see></summary>
    let PaymentDue = Namespaced_IRI.parse _namespace_name "PaymentDue" |> NamespacedName

    /// <summary>
    /// The payment is due and considered late.
    /// <see href="http://schema.org/PaymentPastDue"></see></summary>
    let PaymentPastDue =
        Namespaced_IRI.parse _namespace_name "PaymentPastDue" |> NamespacedName

    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// <see href="http://schema.org/PaymentService"></see></summary>
    let PaymentService =
        Namespaced_IRI.parse _namespace_name "PaymentService" |> NamespacedName

    /// <summary>
    /// The act of participating in performance arts.
    /// <see href="http://schema.org/PerformAction"></see></summary>
    let PerformAction =
        Namespaced_IRI.parse _namespace_name "PerformAction" |> NamespacedName

    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// <see href="http://schema.org/PerformanceRole"></see></summary>
    let PerformanceRole =
        Namespaced_IRI.parse _namespace_name "PerformanceRole" |> NamespacedName

    /// <summary>
    /// A theater or other performing art center.
    /// <see href="http://schema.org/PerformingArtsTheater"></see></summary>
    let PerformingArtsTheater =
        Namespaced_IRI.parse _namespace_name "PerformingArtsTheater" |> NamespacedName

    /// <summary>
    /// A publication in any medium issued in successive parts bearing numerical or chronological designations and intended, such as a magazine, scholarly journal, or newspaper to continue indefinitely.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/Periodical"></see></summary>
    let Periodical = Namespaced_IRI.parse _namespace_name "Periodical" |> NamespacedName
    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// <see href="http://schema.org/Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// A pet store.
    /// <see href="http://schema.org/PetStore"></see></summary>
    let PetStore = Namespaced_IRI.parse _namespace_name "PetStore" |> NamespacedName
    /// <summary>
    /// A pharmacy or drugstore.
    /// <see href="http://schema.org/Pharmacy"></see></summary>
    let Pharmacy = Namespaced_IRI.parse _namespace_name "Pharmacy" |> NamespacedName
    /// <summary>
    /// A photograph.
    /// <see href="http://schema.org/Photograph"></see></summary>
    let Photograph = Namespaced_IRI.parse _namespace_name "Photograph" |> NamespacedName

    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// <see href="http://schema.org/PhotographAction"></see></summary>
    let PhotographAction =
        Namespaced_IRI.parse _namespace_name "PhotographAction" |> NamespacedName

    /// <summary>
    /// A doctor's office.
    /// <see href="http://schema.org/Physician"></see></summary>
    let Physician = Namespaced_IRI.parse _namespace_name "Physician" |> NamespacedName
    /// <summary>
    /// A playground.
    /// <see href="http://schema.org/Playground"></see></summary>
    let Playground = Namespaced_IRI.parse _namespace_name "Playground" |> NamespacedName
    /// <summary>
    /// A plumbing service.
    /// <see href="http://schema.org/Plumber"></see></summary>
    let Plumber = Namespaced_IRI.parse _namespace_name "Plumber" |> NamespacedName

    /// <summary>
    /// A police station.
    /// <see href="http://schema.org/PoliceStation"></see></summary>
    let PoliceStation =
        Namespaced_IRI.parse _namespace_name "PoliceStation" |> NamespacedName

    /// <summary>
    /// A pond.
    /// <see href="http://schema.org/Pond"></see></summary>
    let Pond = Namespaced_IRI.parse _namespace_name "Pond" |> NamespacedName
    /// <summary>
    /// A post office.
    /// <see href="http://schema.org/PostOffice"></see></summary>
    let PostOffice = Namespaced_IRI.parse _namespace_name "PostOffice" |> NamespacedName

    /// <summary>
    /// The mailing address.
    /// <see href="http://schema.org/PostalAddress"></see></summary>
    let PostalAddress =
        Namespaced_IRI.parse _namespace_name "PostalAddress" |> NamespacedName

    /// <summary>
    /// A description of an action that is supported.
    /// <see href="http://schema.org/PotentialActionStatus"></see></summary>
    let PotentialActionStatus =
        Namespaced_IRI.parse _namespace_name "PotentialActionStatus" |> NamespacedName

    /// <summary>
    /// Indicates that the item is available for pre-order.
    /// <see href="http://schema.org/PreOrder"></see></summary>
    let PreOrder = Namespaced_IRI.parse _namespace_name "PreOrder" |> NamespacedName

    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// <see href="http://schema.org/PreOrderAction"></see></summary>
    let PreOrderAction =
        Namespaced_IRI.parse _namespace_name "PreOrderAction" |> NamespacedName

    /// <summary>
    /// Indicates that the item is available for ordering and delivery before general availability.
    /// <see href="http://schema.org/PreSale"></see></summary>
    let PreSale = Namespaced_IRI.parse _namespace_name "PreSale" |> NamespacedName

    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// <see href="http://schema.org/PrependAction"></see></summary>
    let PrependAction =
        Namespaced_IRI.parse _namespace_name "PrependAction" |> NamespacedName

    /// <summary>
    /// A preschool.
    /// <see href="http://schema.org/Preschool"></see></summary>
    let Preschool = Namespaced_IRI.parse _namespace_name "Preschool" |> NamespacedName

    /// <summary>
    /// A file containing slides or used for a presentation.
    /// <see href="http://schema.org/PresentationDigitalDocument"></see></summary>
    let PresentationDigitalDocument =
        Namespaced_IRI.parse _namespace_name "PresentationDigitalDocument" |> NamespacedName

    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// <see href="http://schema.org/ProductModel"></see></summary>
    let ProductModel =
        Namespaced_IRI.parse _namespace_name "ProductModel" |> NamespacedName

    /// <summary>
    /// Original definition: "provider of professional services."&lt;br/&gt;&lt;br/&gt;
    ///
    /// The general &lt;a class="localLink" href="http://schema.org/ProfessionalService"&gt;ProfessionalService&lt;/a&gt; type for local businesses was deprecated due to confusion with &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;. For reference, the types that it included were: &lt;a class="localLink" href="http://schema.org/Dentist"&gt;Dentist&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/AccountingService"&gt;AccountingService&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Notary"&gt;Notary&lt;/a&gt;, as well as types for several kinds of &lt;a class="localLink" href="http://schema.org/HomeAndConstructionBusiness"&gt;HomeAndConstructionBusiness&lt;/a&gt;: &lt;a class="localLink" href="http://schema.org/Electrician"&gt;Electrician&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/GeneralContractor"&gt;GeneralContractor&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/HousePainter"&gt;HousePainter&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Locksmith"&gt;Locksmith&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Plumber"&gt;Plumber&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RoofingContractor"&gt;RoofingContractor&lt;/a&gt;. &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; was introduced as a more inclusive supertype of &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;.
    /// <see href="http://schema.org/ProfessionalService"></see></summary>
    let ProfessionalService =
        Namespaced_IRI.parse _namespace_name "ProfessionalService" |> NamespacedName

    /// <summary>
    /// Web page type: Profile page.
    /// <see href="http://schema.org/ProfilePage"></see></summary>
    let ProfilePage =
        Namespaced_IRI.parse _namespace_name "ProfilePage" |> NamespacedName

    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// <see href="http://schema.org/ProgramMembership"></see></summary>
    let ProgramMembership =
        Namespaced_IRI.parse _namespace_name "ProgramMembership" |> NamespacedName

    /// <summary>
    /// A Property value specification.
    /// <see href="http://schema.org/PropertyValueSpecification"></see></summary>
    let PropertyValueSpecification =
        Namespaced_IRI.parse _namespace_name "PropertyValueSpecification" |> NamespacedName

    /// <summary>
    /// This stands for any day that is a public holiday; it is a placeholder for all official public holidays in some particular location. While not technically a "day of the week", it can be used with &lt;a class="localLink" href="http://schema.org/OpeningHoursSpecification"&gt;OpeningHoursSpecification&lt;/a&gt;. In the context of an opening hours specification it can be used to indicate opening hours on public holidays, overriding general opening hours for the day of the week on which a public holiday occurs.
    /// <see href="http://schema.org/PublicHolidays"></see></summary>
    let PublicHolidays =
        Namespaced_IRI.parse _namespace_name "PublicHolidays" |> NamespacedName

    /// <summary>
    /// A public swimming pool.
    /// <see href="http://schema.org/PublicSwimmingPool"></see></summary>
    let PublicSwimmingPool =
        Namespaced_IRI.parse _namespace_name "PublicSwimmingPool" |> NamespacedName

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/PublicationIssue"></see></summary>
    let PublicationIssue =
        Namespaced_IRI.parse _namespace_name "PublicationIssue" |> NamespacedName

    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// <see href="http://schema.org/PublicationVolume"></see></summary>
    let PublicationVolume =
        Namespaced_IRI.parse _namespace_name "PublicationVolume" |> NamespacedName

    /// <summary>
    /// A QAPage is a WebPage focussed on a specific Question and its Answer(s), e.g. in a question answering site or documenting Frequently Asked Questions (FAQs).
    /// <see href="http://schema.org/QAPage"></see></summary>
    let QAPage = Namespaced_IRI.parse _namespace_name "QAPage" |> NamespacedName

    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// <see href="http://schema.org/QuantitativeValue"></see></summary>
    let QuantitativeValue =
        Namespaced_IRI.parse _namespace_name "QuantitativeValue" |> NamespacedName

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// <see href="http://schema.org/Question"></see></summary>
    let Question = Namespaced_IRI.parse _namespace_name "Question" |> NamespacedName

    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// <see href="http://schema.org/QuoteAction"></see></summary>
    let QuoteAction =
        Namespaced_IRI.parse _namespace_name "QuoteAction" |> NamespacedName

    /// <summary>
    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    /// <see href="http://schema.org/RVPark"></see></summary>
    let RVPark = Namespaced_IRI.parse _namespace_name "RVPark" |> NamespacedName
    /// <summary>
    /// A short radio program or a segment/part of a radio program.
    /// <see href="http://schema.org/RadioClip"></see></summary>
    let RadioClip = Namespaced_IRI.parse _namespace_name "RadioClip" |> NamespacedName

    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// <see href="http://schema.org/RadioEpisode"></see></summary>
    let RadioEpisode =
        Namespaced_IRI.parse _namespace_name "RadioEpisode" |> NamespacedName

    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// <see href="http://schema.org/RadioSeason"></see></summary>
    let RadioSeason =
        Namespaced_IRI.parse _namespace_name "RadioSeason" |> NamespacedName

    /// <summary>
    /// CreativeWorkSeries dedicated to radio broadcast and associated online delivery.
    /// <see href="http://schema.org/RadioSeries"></see></summary>
    let RadioSeries =
        Namespaced_IRI.parse _namespace_name "RadioSeries" |> NamespacedName

    /// <summary>
    /// A radio station.
    /// <see href="http://schema.org/RadioStation"></see></summary>
    let RadioStation =
        Namespaced_IRI.parse _namespace_name "RadioStation" |> NamespacedName

    /// <summary>
    /// The act of consuming written content.
    /// <see href="http://schema.org/ReadAction"></see></summary>
    let ReadAction = Namespaced_IRI.parse _namespace_name "ReadAction" |> NamespacedName

    /// <summary>
    /// Permission to read or view the document.
    /// <see href="http://schema.org/ReadPermission"></see></summary>
    let ReadPermission =
        Namespaced_IRI.parse _namespace_name "ReadPermission" |> NamespacedName

    /// <summary>
    /// A real-estate agent.
    /// <see href="http://schema.org/RealEstateAgent"></see></summary>
    let RealEstateAgent =
        Namespaced_IRI.parse _namespace_name "RealEstateAgent" |> NamespacedName

    /// <summary>
    /// Real-wheel drive is a transmission layout where the engine drives the rear wheels.
    /// <see href="http://schema.org/RearWheelDriveConfiguration"></see></summary>
    let RearWheelDriveConfiguration =
        Namespaced_IRI.parse _namespace_name "RearWheelDriveConfiguration" |> NamespacedName

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
    let ReceiveAction =
        Namespaced_IRI.parse _namespace_name "ReceiveAction" |> NamespacedName

    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="http://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="http://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.
    /// <see href="http://schema.org/Recipe"></see></summary>
    let Recipe = Namespaced_IRI.parse _namespace_name "Recipe" |> NamespacedName

    /// <summary>
    /// A recycling center.
    /// <see href="http://schema.org/RecyclingCenter"></see></summary>
    let RecyclingCenter =
        Namespaced_IRI.parse _namespace_name "RecyclingCenter" |> NamespacedName

    /// <summary>
    /// Indicates that the item is refurbished.
    /// <see href="http://schema.org/RefurbishedCondition"></see></summary>
    let RefurbishedCondition =
        Namespaced_IRI.parse _namespace_name "RefurbishedCondition" |> NamespacedName

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
    let RegisterAction =
        Namespaced_IRI.parse _namespace_name "RegisterAction" |> NamespacedName

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
    let RejectAction =
        Namespaced_IRI.parse _namespace_name "RejectAction" |> NamespacedName

    /// <summary>
    /// RemixAlbum.
    /// <see href="http://schema.org/RemixAlbum"></see></summary>
    let RemixAlbum = Namespaced_IRI.parse _namespace_name "RemixAlbum" |> NamespacedName
    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// <see href="http://schema.org/RentAction"></see></summary>
    let RentAction = Namespaced_IRI.parse _namespace_name "RentAction" |> NamespacedName

    /// <summary>
    /// A reservation for a rental car.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// <see href="http://schema.org/RentalCarReservation"></see></summary>
    let RentalCarReservation =
        Namespaced_IRI.parse _namespace_name "RentalCarReservation" |> NamespacedName

    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// <see href="http://schema.org/ReplaceAction"></see></summary>
    let ReplaceAction =
        Namespaced_IRI.parse _namespace_name "ReplaceAction" |> NamespacedName

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
    let ReplyAction =
        Namespaced_IRI.parse _namespace_name "ReplyAction" |> NamespacedName

    /// <summary>
    /// A Report generated by governmental or non-governmental organization.
    /// <see href="http://schema.org/Report"></see></summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName
    /// <summary>
    /// Researchers.
    /// <see href="http://schema.org/Researcher"></see></summary>
    let Researcher = Namespaced_IRI.parse _namespace_name "Researcher" |> NamespacedName

    /// <summary>
    /// The status for a previously confirmed reservation that is now cancelled.
    /// <see href="http://schema.org/ReservationCancelled"></see></summary>
    let ReservationCancelled =
        Namespaced_IRI.parse _namespace_name "ReservationCancelled" |> NamespacedName

    /// <summary>
    /// Enumerated status values for Reservation.
    /// <see href="http://schema.org/ReservationStatusType"></see></summary>
    let ReservationStatusType =
        Namespaced_IRI.parse _namespace_name "ReservationStatusType" |> NamespacedName

    /// <summary>
    /// The status of a confirmed reservation.
    /// <see href="http://schema.org/ReservationConfirmed"></see></summary>
    let ReservationConfirmed =
        Namespaced_IRI.parse _namespace_name "ReservationConfirmed" |> NamespacedName

    /// <summary>
    /// The status of a reservation on hold pending an update like credit card number or flight changes.
    /// <see href="http://schema.org/ReservationHold"></see></summary>
    let ReservationHold =
        Namespaced_IRI.parse _namespace_name "ReservationHold" |> NamespacedName

    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// <see href="http://schema.org/ReservationPackage"></see></summary>
    let ReservationPackage =
        Namespaced_IRI.parse _namespace_name "ReservationPackage" |> NamespacedName

    /// <summary>
    /// The status of a reservation when a request has been sent, but not confirmed.
    /// <see href="http://schema.org/ReservationPending"></see></summary>
    let ReservationPending =
        Namespaced_IRI.parse _namespace_name "ReservationPending" |> NamespacedName

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
    let ReserveAction =
        Namespaced_IRI.parse _namespace_name "ReserveAction" |> NamespacedName

    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// <see href="http://schema.org/Reservoir"></see></summary>
    let Reservoir = Namespaced_IRI.parse _namespace_name "Reservoir" |> NamespacedName
    /// <summary>
    /// A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishment operated by a single company (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Resort"&gt;http://en.wikipedia.org/wiki/Resort&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Resort"></see></summary>
    let Resort = Namespaced_IRI.parse _namespace_name "Resort" |> NamespacedName
    /// <summary>
    /// A restaurant.
    /// <see href="http://schema.org/Restaurant"></see></summary>
    let Restaurant = Namespaced_IRI.parse _namespace_name "Restaurant" |> NamespacedName

    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    /// <see href="http://schema.org/ResumeAction"></see></summary>
    let ResumeAction =
        Namespaced_IRI.parse _namespace_name "ResumeAction" |> NamespacedName

    /// <summary>
    /// The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).
    /// <see href="http://schema.org/ReturnAction"></see></summary>
    let ReturnAction =
        Namespaced_IRI.parse _namespace_name "ReturnAction" |> NamespacedName

    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// <see href="http://schema.org/ReviewAction"></see></summary>
    let ReviewAction =
        Namespaced_IRI.parse _namespace_name "ReviewAction" |> NamespacedName

    /// <summary>
    /// The steering position is on the right side of the vehicle (viewed from the main direction of driving).
    /// <see href="http://schema.org/RightHandDriving"></see></summary>
    let RightHandDriving =
        Namespaced_IRI.parse _namespace_name "RightHandDriving" |> NamespacedName

    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// <see href="http://schema.org/RiverBodyOfWater"></see></summary>
    let RiverBodyOfWater =
        Namespaced_IRI.parse _namespace_name "RiverBodyOfWater" |> NamespacedName

    /// <summary>
    /// A roofing contractor.
    /// <see href="http://schema.org/RoofingContractor"></see></summary>
    let RoofingContractor =
        Namespaced_IRI.parse _namespace_name "RoofingContractor" |> NamespacedName

    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// <see href="http://schema.org/RsvpAction"></see></summary>
    let RsvpAction = Namespaced_IRI.parse _namespace_name "RsvpAction" |> NamespacedName

    /// <summary>
    /// The invitee may or may not attend.
    /// <see href="http://schema.org/RsvpResponseMaybe"></see></summary>
    let RsvpResponseMaybe =
        Namespaced_IRI.parse _namespace_name "RsvpResponseMaybe" |> NamespacedName

    /// <summary>
    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// <see href="http://schema.org/RsvpResponseType"></see></summary>
    let RsvpResponseType =
        Namespaced_IRI.parse _namespace_name "RsvpResponseType" |> NamespacedName

    /// <summary>
    /// The invitee will not attend.
    /// <see href="http://schema.org/RsvpResponseNo"></see></summary>
    let RsvpResponseNo =
        Namespaced_IRI.parse _namespace_name "RsvpResponseNo" |> NamespacedName

    /// <summary>
    /// The invitee will attend.
    /// <see href="http://schema.org/RsvpResponseYes"></see></summary>
    let RsvpResponseYes =
        Namespaced_IRI.parse _namespace_name "RsvpResponseYes" |> NamespacedName

    /// <summary>
    /// Event type: Sales event.
    /// <see href="http://schema.org/SaleEvent"></see></summary>
    let SaleEvent = Namespaced_IRI.parse _namespace_name "SaleEvent" |> NamespacedName
    /// <summary>
    /// The day of the week between Friday and Sunday.
    /// <see href="http://schema.org/Saturday"></see></summary>
    let Saturday = Namespaced_IRI.parse _namespace_name "Saturday" |> NamespacedName

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
    let ScheduleAction =
        Namespaced_IRI.parse _namespace_name "ScheduleAction" |> NamespacedName

    /// <summary>
    /// A scholarly article.
    /// <see href="http://schema.org/ScholarlyArticle"></see></summary>
    let ScholarlyArticle =
        Namespaced_IRI.parse _namespace_name "ScholarlyArticle" |> NamespacedName

    /// <summary>
    /// A school.
    /// <see href="http://schema.org/School"></see></summary>
    let School = Namespaced_IRI.parse _namespace_name "School" |> NamespacedName

    /// <summary>
    /// A screening of a movie or other video.
    /// <see href="http://schema.org/ScreeningEvent"></see></summary>
    let ScreeningEvent =
        Namespaced_IRI.parse _namespace_name "ScreeningEvent" |> NamespacedName

    /// <summary>
    /// A piece of sculpture.
    /// <see href="http://schema.org/Sculpture"></see></summary>
    let Sculpture = Namespaced_IRI.parse _namespace_name "Sculpture" |> NamespacedName

    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// <see href="http://schema.org/SeaBodyOfWater"></see></summary>
    let SeaBodyOfWater =
        Namespaced_IRI.parse _namespace_name "SeaBodyOfWater" |> NamespacedName

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
    let SearchAction =
        Namespaced_IRI.parse _namespace_name "SearchAction" |> NamespacedName

    /// <summary>
    /// Web page type: Search results page.
    /// <see href="http://schema.org/SearchResultsPage"></see></summary>
    let SearchResultsPage =
        Namespaced_IRI.parse _namespace_name "SearchResultsPage" |> NamespacedName

    /// <summary>
    /// A media season e.g. tv, radio, video game etc.
    /// <see href="http://schema.org/Season"></see></summary>
    let Season = Namespaced_IRI.parse _namespace_name "Season" |> NamespacedName
    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// <see href="http://schema.org/Seat"></see></summary>
    let Seat = Namespaced_IRI.parse _namespace_name "Seat" |> NamespacedName
    /// <summary>
    /// A seating map.
    /// <see href="http://schema.org/SeatingMap"></see></summary>
    let SeatingMap = Namespaced_IRI.parse _namespace_name "SeatingMap" |> NamespacedName

    /// <summary>
    /// A self-storage facility.
    /// <see href="http://schema.org/SelfStorage"></see></summary>
    let SelfStorage =
        Namespaced_IRI.parse _namespace_name "SelfStorage" |> NamespacedName

    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    /// <see href="http://schema.org/SellAction"></see></summary>
    let SellAction = Namespaced_IRI.parse _namespace_name "SellAction" |> NamespacedName
    /// <summary>
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: The reciprocal of SendAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    ///
    /// <see href="http://schema.org/SendAction"></see></summary>
    let SendAction = Namespaced_IRI.parse _namespace_name "SendAction" |> NamespacedName

    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// <see href="http://schema.org/ServiceChannel"></see></summary>
    let ServiceChannel =
        Namespaced_IRI.parse _namespace_name "ServiceChannel" |> NamespacedName

    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// <see href="http://schema.org/ShareAction"></see></summary>
    let ShareAction =
        Namespaced_IRI.parse _namespace_name "ShareAction" |> NamespacedName

    /// <summary>
    /// A shoe store.
    /// <see href="http://schema.org/ShoeStore"></see></summary>
    let ShoeStore = Namespaced_IRI.parse _namespace_name "ShoeStore" |> NamespacedName

    /// <summary>
    /// A shopping center or mall.
    /// <see href="http://schema.org/ShoppingCenter"></see></summary>
    let ShoppingCenter =
        Namespaced_IRI.parse _namespace_name "ShoppingCenter" |> NamespacedName

    /// <summary>
    /// Residence type: Single-family home.
    /// <see href="http://schema.org/SingleFamilyResidence"></see></summary>
    let SingleFamilyResidence =
        Namespaced_IRI.parse _namespace_name "SingleFamilyResidence" |> NamespacedName

    /// <summary>
    /// Play mode: SinglePlayer. Which is played by a lone player.
    /// <see href="http://schema.org/SinglePlayer"></see></summary>
    let SinglePlayer =
        Namespaced_IRI.parse _namespace_name "SinglePlayer" |> NamespacedName

    /// <summary>
    /// SingleRelease.
    /// <see href="http://schema.org/SingleRelease"></see></summary>
    let SingleRelease =
        Namespaced_IRI.parse _namespace_name "SingleRelease" |> NamespacedName

    /// <summary>
    /// A navigation element of the page.
    /// <see href="http://schema.org/SiteNavigationElement"></see></summary>
    let SiteNavigationElement =
        Namespaced_IRI.parse _namespace_name "SiteNavigationElement" |> NamespacedName

    /// <summary>
    /// A web page element, like a table or an image.
    /// <see href="http://schema.org/WebPageElement"></see></summary>
    let WebPageElement =
        Namespaced_IRI.parse _namespace_name "WebPageElement" |> NamespacedName

    /// <summary>
    /// A ski resort.
    /// <see href="http://schema.org/SkiResort"></see></summary>
    let SkiResort = Namespaced_IRI.parse _namespace_name "SkiResort" |> NamespacedName

    /// <summary>
    /// Event type: Social event.
    /// <see href="http://schema.org/SocialEvent"></see></summary>
    let SocialEvent =
        Namespaced_IRI.parse _namespace_name "SocialEvent" |> NamespacedName

    /// <summary>
    /// Indicates that the item has sold out.
    /// <see href="http://schema.org/SoldOut"></see></summary>
    let SoldOut = Namespaced_IRI.parse _namespace_name "SoldOut" |> NamespacedName

    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// <see href="http://schema.org/SomeProducts"></see></summary>
    let SomeProducts =
        Namespaced_IRI.parse _namespace_name "SomeProducts" |> NamespacedName

    /// <summary>
    /// SoundtrackAlbum.
    /// <see href="http://schema.org/SoundtrackAlbum"></see></summary>
    let SoundtrackAlbum =
        Namespaced_IRI.parse _namespace_name "SoundtrackAlbum" |> NamespacedName

    /// <summary>
    /// A SpeakableSpecification indicates (typically via &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt;) sections of a document that are highlighted as particularly &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt;. Instances of this type are expected to be used primarily as values of the &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt; property.
    /// <see href="http://schema.org/SpeakableSpecification"></see></summary>
    let SpeakableSpecification =
        Namespaced_IRI.parse _namespace_name "SpeakableSpecification" |> NamespacedName

    /// <summary>
    /// Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.
    /// <see href="http://schema.org/Specialty"></see></summary>
    let Specialty = Namespaced_IRI.parse _namespace_name "Specialty" |> NamespacedName

    /// <summary>
    /// SpokenWordAlbum.
    /// <see href="http://schema.org/SpokenWordAlbum"></see></summary>
    let SpokenWordAlbum =
        Namespaced_IRI.parse _namespace_name "SpokenWordAlbum" |> NamespacedName

    /// <summary>
    /// A sporting goods store.
    /// <see href="http://schema.org/SportingGoodsStore"></see></summary>
    let SportingGoodsStore =
        Namespaced_IRI.parse _namespace_name "SportingGoodsStore" |> NamespacedName

    /// <summary>
    /// A sports club.
    /// <see href="http://schema.org/SportsClub"></see></summary>
    let SportsClub = Namespaced_IRI.parse _namespace_name "SportsClub" |> NamespacedName

    /// <summary>
    /// Event type: Sports event.
    /// <see href="http://schema.org/SportsEvent"></see></summary>
    let SportsEvent =
        Namespaced_IRI.parse _namespace_name "SportsEvent" |> NamespacedName

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// <see href="http://schema.org/SportsOrganization"></see></summary>
    let SportsOrganization =
        Namespaced_IRI.parse _namespace_name "SportsOrganization" |> NamespacedName

    /// <summary>
    /// Organization: Sports team.
    /// <see href="http://schema.org/SportsTeam"></see></summary>
    let SportsTeam = Namespaced_IRI.parse _namespace_name "SportsTeam" |> NamespacedName

    /// <summary>
    /// A spreadsheet file.
    /// <see href="http://schema.org/SpreadsheetDigitalDocument"></see></summary>
    let SpreadsheetDigitalDocument =
        Namespaced_IRI.parse _namespace_name "SpreadsheetDigitalDocument" |> NamespacedName

    /// <summary>
    /// A stadium.
    /// <see href="http://schema.org/StadiumOrArena"></see></summary>
    let StadiumOrArena =
        Namespaced_IRI.parse _namespace_name "StadiumOrArena" |> NamespacedName

    /// <summary>
    /// A state or province of a country.
    /// <see href="http://schema.org/State"></see></summary>
    let State = Namespaced_IRI.parse _namespace_name "State" |> NamespacedName

    /// <summary>
    /// StudioAlbum.
    /// <see href="http://schema.org/StudioAlbum"></see></summary>
    let StudioAlbum =
        Namespaced_IRI.parse _namespace_name "StudioAlbum" |> NamespacedName

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
    let SubscribeAction =
        Namespaced_IRI.parse _namespace_name "SubscribeAction" |> NamespacedName

    /// <summary>
    /// A subway station.
    /// <see href="http://schema.org/SubwayStation"></see></summary>
    let SubwayStation =
        Namespaced_IRI.parse _namespace_name "SubwayStation" |> NamespacedName

    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// <see href="http://schema.org/Suite"></see></summary>
    let Suite = Namespaced_IRI.parse _namespace_name "Suite" |> NamespacedName
    /// <summary>
    /// The day of the week between Saturday and Monday.
    /// <see href="http://schema.org/Sunday"></see></summary>
    let Sunday = Namespaced_IRI.parse _namespace_name "Sunday" |> NamespacedName

    /// <summary>
    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    /// <see href="http://schema.org/SuspendAction"></see></summary>
    let SuspendAction =
        Namespaced_IRI.parse _namespace_name "SuspendAction" |> NamespacedName

    /// <summary>
    /// A synagogue.
    /// <see href="http://schema.org/Synagogue"></see></summary>
    let Synagogue = Namespaced_IRI.parse _namespace_name "Synagogue" |> NamespacedName
    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// <see href="http://schema.org/TVClip"></see></summary>
    let TVClip = Namespaced_IRI.parse _namespace_name "TVClip" |> NamespacedName
    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// <see href="http://schema.org/TVEpisode"></see></summary>
    let TVEpisode = Namespaced_IRI.parse _namespace_name "TVEpisode" |> NamespacedName
    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// <see href="http://schema.org/TVSeason"></see></summary>
    let TVSeason = Namespaced_IRI.parse _namespace_name "TVSeason" |> NamespacedName
    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// <see href="http://schema.org/TVSeries"></see></summary>
    let TVSeries = Namespaced_IRI.parse _namespace_name "TVSeries" |> NamespacedName
    /// <summary>
    /// A table on a Web page.
    /// <see href="http://schema.org/Table"></see></summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName
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
    let TakeAction = Namespaced_IRI.parse _namespace_name "TakeAction" |> NamespacedName

    /// <summary>
    /// A tattoo parlor.
    /// <see href="http://schema.org/TattooParlor"></see></summary>
    let TattooParlor =
        Namespaced_IRI.parse _namespace_name "TattooParlor" |> NamespacedName

    /// <summary>
    /// A taxi.
    /// <see href="http://schema.org/Taxi"></see></summary>
    let Taxi = Namespaced_IRI.parse _namespace_name "Taxi" |> NamespacedName

    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// <see href="http://schema.org/TaxiService"></see></summary>
    let TaxiService =
        Namespaced_IRI.parse _namespace_name "TaxiService" |> NamespacedName

    /// <summary>
    /// A reservation for a taxi.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/TaxiReservation"></see></summary>
    let TaxiReservation =
        Namespaced_IRI.parse _namespace_name "TaxiReservation" |> NamespacedName

    /// <summary>
    /// A taxi stand.
    /// <see href="http://schema.org/TaxiStand"></see></summary>
    let TaxiStand = Namespaced_IRI.parse _namespace_name "TaxiStand" |> NamespacedName

    /// <summary>
    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    /// <see href="http://schema.org/TelevisionChannel"></see></summary>
    let TelevisionChannel =
        Namespaced_IRI.parse _namespace_name "TelevisionChannel" |> NamespacedName

    /// <summary>
    /// A television station.
    /// <see href="http://schema.org/TelevisionStation"></see></summary>
    let TelevisionStation =
        Namespaced_IRI.parse _namespace_name "TelevisionStation" |> NamespacedName

    /// <summary>
    /// A tennis complex.
    /// <see href="http://schema.org/TennisComplex"></see></summary>
    let TennisComplex =
        Namespaced_IRI.parse _namespace_name "TennisComplex" |> NamespacedName

    /// <summary>
    /// Data type: Text.
    /// <see href="http://schema.org/Text"></see></summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName

    /// <summary>
    /// A file composed primarily of text.
    /// <see href="http://schema.org/TextDigitalDocument"></see></summary>
    let TextDigitalDocument =
        Namespaced_IRI.parse _namespace_name "TextDigitalDocument" |> NamespacedName

    /// <summary>
    /// Event type: Theater performance.
    /// <see href="http://schema.org/TheaterEvent"></see></summary>
    let TheaterEvent =
        Namespaced_IRI.parse _namespace_name "TheaterEvent" |> NamespacedName

    /// <summary>
    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    /// <see href="http://schema.org/TheaterGroup"></see></summary>
    let TheaterGroup =
        Namespaced_IRI.parse _namespace_name "TheaterGroup" |> NamespacedName

    /// <summary>
    /// The day of the week between Wednesday and Friday.
    /// <see href="http://schema.org/Thursday"></see></summary>
    let Thursday = Namespaced_IRI.parse _namespace_name "Thursday" |> NamespacedName
    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// <see href="http://schema.org/Ticket"></see></summary>
    let Ticket = Namespaced_IRI.parse _namespace_name "Ticket" |> NamespacedName
    /// <summary>
    /// The act of reaching a draw in a competitive activity.
    /// <see href="http://schema.org/TieAction"></see></summary>
    let TieAction = Namespaced_IRI.parse _namespace_name "TieAction" |> NamespacedName
    /// <summary>
    /// A point in time recurring on multiple days in the form hh:mm:ss[Z|(+|-)hh:mm] (see &lt;a href="http://www.w3.org/TR/xmlschema-2/#time"&gt;XML schema for details&lt;/a&gt;).
    /// <see href="http://schema.org/Time"></see></summary>
    let Time = Namespaced_IRI.parse _namespace_name "Time" |> NamespacedName
    /// <summary>
    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    /// <see href="http://schema.org/TipAction"></see></summary>
    let TipAction = Namespaced_IRI.parse _namespace_name "TipAction" |> NamespacedName
    /// <summary>
    /// A tire shop.
    /// <see href="http://schema.org/TireShop"></see></summary>
    let TireShop = Namespaced_IRI.parse _namespace_name "TireShop" |> NamespacedName
    /// <summary>
    /// The associated telephone number is toll free.
    /// <see href="http://schema.org/TollFree"></see></summary>
    let TollFree = Namespaced_IRI.parse _namespace_name "TollFree" |> NamespacedName

    /// <summary>
    /// A tourist attraction.  In principle any Thing can be a &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, from a &lt;a class="localLink" href="http://schema.org/Mountain"&gt;Mountain&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/LandmarksOrHistoricalBuildings"&gt;LandmarksOrHistoricalBuildings&lt;/a&gt; to a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt;.  This Type can be used on its own to describe a general &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, or be used as an &lt;a class="localLink" href="http://schema.org/additionalType"&gt;additionalType&lt;/a&gt; to add tourist attraction properties to any other type.  (See examples below)
    /// <see href="http://schema.org/TouristAttraction"></see></summary>
    let TouristAttraction =
        Namespaced_IRI.parse _namespace_name "TouristAttraction" |> NamespacedName

    /// <summary>
    /// A tourist information center.
    /// <see href="http://schema.org/TouristInformationCenter"></see></summary>
    let TouristInformationCenter =
        Namespaced_IRI.parse _namespace_name "TouristInformationCenter" |> NamespacedName

    /// <summary>
    /// A toy store.
    /// <see href="http://schema.org/ToyStore"></see></summary>
    let ToyStore = Namespaced_IRI.parse _namespace_name "ToyStore" |> NamespacedName

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
    let TrackAction =
        Namespaced_IRI.parse _namespace_name "TrackAction" |> NamespacedName

    /// <summary>
    /// A reservation for train travel.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// <see href="http://schema.org/TrainReservation"></see></summary>
    let TrainReservation =
        Namespaced_IRI.parse _namespace_name "TrainReservation" |> NamespacedName

    /// <summary>
    /// A train station.
    /// <see href="http://schema.org/TrainStation"></see></summary>
    let TrainStation =
        Namespaced_IRI.parse _namespace_name "TrainStation" |> NamespacedName

    /// <summary>
    /// A trip on a commercial train line.
    /// <see href="http://schema.org/TrainTrip"></see></summary>
    let TrainTrip = Namespaced_IRI.parse _namespace_name "TrainTrip" |> NamespacedName
    /// <summary>
    /// A transit map.
    /// <see href="http://schema.org/TransitMap"></see></summary>
    let TransitMap = Namespaced_IRI.parse _namespace_name "TransitMap" |> NamespacedName

    /// <summary>
    /// The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// <see href="http://schema.org/TravelAction"></see></summary>
    let TravelAction =
        Namespaced_IRI.parse _namespace_name "TravelAction" |> NamespacedName

    /// <summary>
    /// A travel agency.
    /// <see href="http://schema.org/TravelAgency"></see></summary>
    let TravelAgency =
        Namespaced_IRI.parse _namespace_name "TravelAgency" |> NamespacedName

    /// <summary>
    /// The boolean value true.
    /// <see href="http://schema.org/True"></see></summary>
    let True = Namespaced_IRI.parse _namespace_name "True" |> NamespacedName
    /// <summary>
    /// The day of the week between Monday and Wednesday.
    /// <see href="http://schema.org/Tuesday"></see></summary>
    let Tuesday = Namespaced_IRI.parse _namespace_name "Tuesday" |> NamespacedName

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// <see href="http://schema.org/TypeAndQuantityNode"></see></summary>
    let TypeAndQuantityNode =
        Namespaced_IRI.parse _namespace_name "TypeAndQuantityNode" |> NamespacedName

    /// <summary>
    /// Data type: URL.
    /// <see href="http://schema.org/URL"></see></summary>
    let URL = Namespaced_IRI.parse _namespace_name "URL" |> NamespacedName

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
    let UnRegisterAction =
        Namespaced_IRI.parse _namespace_name "UnRegisterAction" |> NamespacedName

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// <see href="http://schema.org/UnitPriceSpecification"></see></summary>
    let UnitPriceSpecification =
        Namespaced_IRI.parse _namespace_name "UnitPriceSpecification" |> NamespacedName

    /// <summary>
    /// The act of applying an object to its intended purpose.
    /// <see href="http://schema.org/UseAction"></see></summary>
    let UseAction = Namespaced_IRI.parse _namespace_name "UseAction" |> NamespacedName

    /// <summary>
    /// Indicates that the item is used.
    /// <see href="http://schema.org/UsedCondition"></see></summary>
    let UsedCondition =
        Namespaced_IRI.parse _namespace_name "UsedCondition" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserBlocks"></see></summary>
    let UserBlocks = Namespaced_IRI.parse _namespace_name "UserBlocks" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserInteraction"></see></summary>
    let UserInteraction =
        Namespaced_IRI.parse _namespace_name "UserInteraction" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserCheckins"></see></summary>
    let UserCheckins =
        Namespaced_IRI.parse _namespace_name "UserCheckins" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserComments"></see></summary>
    let UserComments =
        Namespaced_IRI.parse _namespace_name "UserComments" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserDownloads"></see></summary>
    let UserDownloads =
        Namespaced_IRI.parse _namespace_name "UserDownloads" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserLikes"></see></summary>
    let UserLikes = Namespaced_IRI.parse _namespace_name "UserLikes" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserPageVisits"></see></summary>
    let UserPageVisits =
        Namespaced_IRI.parse _namespace_name "UserPageVisits" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserPlays"></see></summary>
    let UserPlays = Namespaced_IRI.parse _namespace_name "UserPlays" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserPlusOnes"></see></summary>
    let UserPlusOnes =
        Namespaced_IRI.parse _namespace_name "UserPlusOnes" |> NamespacedName

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.
    /// <see href="http://schema.org/UserTweets"></see></summary>
    let UserTweets = Namespaced_IRI.parse _namespace_name "UserTweets" |> NamespacedName
    /// <summary>
    /// A diet exclusive of all animal products.
    /// <see href="http://schema.org/VeganDiet"></see></summary>
    let VeganDiet = Namespaced_IRI.parse _namespace_name "VeganDiet" |> NamespacedName

    /// <summary>
    /// A diet exclusive of animal meat.
    /// <see href="http://schema.org/VegetarianDiet"></see></summary>
    let VegetarianDiet =
        Namespaced_IRI.parse _namespace_name "VegetarianDiet" |> NamespacedName

    /// <summary>
    /// A venue map (e.g. for malls, auditoriums, museums, etc.).
    /// <see href="http://schema.org/VenueMap"></see></summary>
    let VenueMap = Namespaced_IRI.parse _namespace_name "VenueMap" |> NamespacedName

    /// <summary>
    /// Web page type: Video gallery page.
    /// <see href="http://schema.org/VideoGallery"></see></summary>
    let VideoGallery =
        Namespaced_IRI.parse _namespace_name "VideoGallery" |> NamespacedName

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// <see href="http://schema.org/VideoGame"></see></summary>
    let VideoGame = Namespaced_IRI.parse _namespace_name "VideoGame" |> NamespacedName

    /// <summary>
    /// A short segment/part of a video game.
    /// <see href="http://schema.org/VideoGameClip"></see></summary>
    let VideoGameClip =
        Namespaced_IRI.parse _namespace_name "VideoGameClip" |> NamespacedName

    /// <summary>
    /// A video game series.
    /// <see href="http://schema.org/VideoGameSeries"></see></summary>
    let VideoGameSeries =
        Namespaced_IRI.parse _namespace_name "VideoGameSeries" |> NamespacedName

    /// <summary>
    /// A video file.
    /// <see href="http://schema.org/VideoObject"></see></summary>
    let VideoObject =
        Namespaced_IRI.parse _namespace_name "VideoObject" |> NamespacedName

    /// <summary>
    /// The act of consuming static visual content.
    /// <see href="http://schema.org/ViewAction"></see></summary>
    let ViewAction = Namespaced_IRI.parse _namespace_name "ViewAction" |> NamespacedName

    /// <summary>
    /// VinylFormat.
    /// <see href="http://schema.org/VinylFormat"></see></summary>
    let VinylFormat =
        Namespaced_IRI.parse _namespace_name "VinylFormat" |> NamespacedName

    /// <summary>
    /// Event type: Visual arts event.
    /// <see href="http://schema.org/VisualArtsEvent"></see></summary>
    let VisualArtsEvent =
        Namespaced_IRI.parse _namespace_name "VisualArtsEvent" |> NamespacedName

    /// <summary>
    /// A work of art that is primarily visual in character.
    /// <see href="http://schema.org/VisualArtwork"></see></summary>
    let VisualArtwork =
        Namespaced_IRI.parse _namespace_name "VisualArtwork" |> NamespacedName

    /// <summary>
    /// A volcano, like Fuji san.
    /// <see href="http://schema.org/Volcano"></see></summary>
    let Volcano = Namespaced_IRI.parse _namespace_name "Volcano" |> NamespacedName
    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// <see href="http://schema.org/VoteAction"></see></summary>
    let VoteAction = Namespaced_IRI.parse _namespace_name "VoteAction" |> NamespacedName
    /// <summary>
    /// An advertising section of the page.
    /// <see href="http://schema.org/WPAdBlock"></see></summary>
    let WPAdBlock = Namespaced_IRI.parse _namespace_name "WPAdBlock" |> NamespacedName
    /// <summary>
    /// The footer section of the page.
    /// <see href="http://schema.org/WPFooter"></see></summary>
    let WPFooter = Namespaced_IRI.parse _namespace_name "WPFooter" |> NamespacedName
    /// <summary>
    /// The header section of the page.
    /// <see href="http://schema.org/WPHeader"></see></summary>
    let WPHeader = Namespaced_IRI.parse _namespace_name "WPHeader" |> NamespacedName
    /// <summary>
    /// A sidebar section of the page.
    /// <see href="http://schema.org/WPSideBar"></see></summary>
    let WPSideBar = Namespaced_IRI.parse _namespace_name "WPSideBar" |> NamespacedName
    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// <see href="http://schema.org/WantAction"></see></summary>
    let WantAction = Namespaced_IRI.parse _namespace_name "WantAction" |> NamespacedName

    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// <see href="http://schema.org/WarrantyPromise"></see></summary>
    let WarrantyPromise =
        Namespaced_IRI.parse _namespace_name "WarrantyPromise" |> NamespacedName

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
    let WarrantyScope =
        Namespaced_IRI.parse _namespace_name "WarrantyScope" |> NamespacedName

    /// <summary>
    /// The act of consuming dynamic/moving visual content.
    /// <see href="http://schema.org/WatchAction"></see></summary>
    let WatchAction =
        Namespaced_IRI.parse _namespace_name "WatchAction" |> NamespacedName

    /// <summary>
    /// A waterfall, like Niagara.
    /// <see href="http://schema.org/Waterfall"></see></summary>
    let Waterfall = Namespaced_IRI.parse _namespace_name "Waterfall" |> NamespacedName
    /// <summary>
    /// The act of dressing oneself in clothing.
    /// <see href="http://schema.org/WearAction"></see></summary>
    let WearAction = Namespaced_IRI.parse _namespace_name "WearAction" |> NamespacedName

    /// <summary>
    /// Web applications.
    /// <see href="http://schema.org/WebApplication"></see></summary>
    let WebApplication =
        Namespaced_IRI.parse _namespace_name "WebApplication" |> NamespacedName

    /// <summary>
    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    /// <see href="http://schema.org/WebSite"></see></summary>
    let WebSite = Namespaced_IRI.parse _namespace_name "WebSite" |> NamespacedName
    /// <summary>
    /// The day of the week between Tuesday and Thursday.
    /// <see href="http://schema.org/Wednesday"></see></summary>
    let Wednesday = Namespaced_IRI.parse _namespace_name "Wednesday" |> NamespacedName

    /// <summary>
    /// A wholesale store.
    /// <see href="http://schema.org/WholesaleStore"></see></summary>
    let WholesaleStore =
        Namespaced_IRI.parse _namespace_name "WholesaleStore" |> NamespacedName

    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// <see href="http://schema.org/WinAction"></see></summary>
    let WinAction = Namespaced_IRI.parse _namespace_name "WinAction" |> NamespacedName
    /// <summary>
    /// A winery.
    /// <see href="http://schema.org/Winery"></see></summary>
    let Winery = Namespaced_IRI.parse _namespace_name "Winery" |> NamespacedName

    /// <summary>
    /// A Workers Union (also known as a Labor Union, Labour Union, or Trade Union) is an organization that promotes the interests of its worker members by collectively bargaining with management, organizing, and political lobbying.
    /// <see href="http://schema.org/WorkersUnion"></see></summary>
    let WorkersUnion =
        Namespaced_IRI.parse _namespace_name "WorkersUnion" |> NamespacedName

    /// <summary>
    /// The act of authoring written creative content.
    /// <see href="http://schema.org/WriteAction"></see></summary>
    let WriteAction =
        Namespaced_IRI.parse _namespace_name "WriteAction" |> NamespacedName

    /// <summary>
    /// Permission to write or edit the document.
    /// <see href="http://schema.org/WritePermission"></see></summary>
    let WritePermission =
        Namespaced_IRI.parse _namespace_name "WritePermission" |> NamespacedName

    /// <summary>
    /// The airline boards by zones of the plane.
    /// <see href="http://schema.org/ZoneBoardingPolicy"></see></summary>
    let ZoneBoardingPolicy =
        Namespaced_IRI.parse _namespace_name "ZoneBoardingPolicy" |> NamespacedName

    /// <summary>
    /// A zoo.
    /// <see href="http://schema.org/Zoo"></see></summary>
    let Zoo = Namespaced_IRI.parse _namespace_name "Zoo" |> NamespacedName
    /// <summary>
    /// The subject matter of the content.
    /// <see href="http://schema.org/about"></see></summary>
    let about = Namespaced_IRI.parse _namespace_name "about" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/domainIncludes"></see>
    /// </summary>
    let domainIncludes =
        Namespaced_IRI.parse _namespace_name "domainIncludes" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/inverseOf"></see>
    /// </summary>
    let inverseOf = Namespaced_IRI.parse _namespace_name "inverseOf" |> NamespacedName
    /// <summary>
    /// A CreativeWork or Event about this Thing.
    /// <see href="http://schema.org/subjectOf"></see></summary>
    let subjectOf = Namespaced_IRI.parse _namespace_name "subjectOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/rangeIncludes"></see>
    /// </summary>
    let rangeIncludes =
        Namespaced_IRI.parse _namespace_name "rangeIncludes" |> NamespacedName

    /// <summary>
    /// The answer(s) that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
    /// <see href="http://schema.org/acceptedAnswer"></see></summary>
    let acceptedAnswer =
        Namespaced_IRI.parse _namespace_name "acceptedAnswer" |> NamespacedName

    /// <summary>
    /// An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
    /// <see href="http://schema.org/suggestedAnswer"></see></summary>
    let suggestedAnswer =
        Namespaced_IRI.parse _namespace_name "suggestedAnswer" |> NamespacedName

    /// <summary>
    /// The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
    /// <see href="http://schema.org/acceptedOffer"></see></summary>
    let acceptedOffer =
        Namespaced_IRI.parse _namespace_name "acceptedOffer" |> NamespacedName

    /// <summary>
    /// The payment method(s) accepted by seller for this offer.
    /// <see href="http://schema.org/acceptedPaymentMethod"></see></summary>
    let acceptedPaymentMethod =
        Namespaced_IRI.parse _namespace_name "acceptedPaymentMethod" |> NamespacedName

    /// <summary>
    /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
    /// <see href="http://schema.org/acceptsReservations"></see></summary>
    let acceptsReservations =
        Namespaced_IRI.parse _namespace_name "acceptsReservations" |> NamespacedName

    /// <summary>
    /// Password, PIN, or access code needed for delivery (e.g. from a locker).
    /// <see href="http://schema.org/accessCode"></see></summary>
    let accessCode = Namespaced_IRI.parse _namespace_name "accessCode" |> NamespacedName
    /// <summary>
    /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
    /// <see href="http://schema.org/accessMode"></see></summary>
    let accessMode = Namespaced_IRI.parse _namespace_name "accessMode" |> NamespacedName

    /// <summary>
    /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
    /// <see href="http://schema.org/accessModeSufficient"></see></summary>
    let accessModeSufficient =
        Namespaced_IRI.parse _namespace_name "accessModeSufficient" |> NamespacedName

    /// <summary>
    /// Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
    /// <see href="http://schema.org/accessibilityAPI"></see></summary>
    let accessibilityAPI =
        Namespaced_IRI.parse _namespace_name "accessibilityAPI" |> NamespacedName

    /// <summary>
    /// Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
    /// <see href="http://schema.org/accessibilityControl"></see></summary>
    let accessibilityControl =
        Namespaced_IRI.parse _namespace_name "accessibilityControl" |> NamespacedName

    /// <summary>
    /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
    /// <see href="http://schema.org/accessibilityFeature"></see></summary>
    let accessibilityFeature =
        Namespaced_IRI.parse _namespace_name "accessibilityFeature" |> NamespacedName

    /// <summary>
    /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
    /// <see href="http://schema.org/accessibilityHazard"></see></summary>
    let accessibilityHazard =
        Namespaced_IRI.parse _namespace_name "accessibilityHazard" |> NamespacedName

    /// <summary>
    /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
    /// <see href="http://schema.org/accessibilitySummary"></see></summary>
    let accessibilitySummary =
        Namespaced_IRI.parse _namespace_name "accessibilitySummary" |> NamespacedName

    /// <summary>
    /// The identifier for the account the payment will be applied to.
    /// <see href="http://schema.org/accountId"></see></summary>
    let accountId = Namespaced_IRI.parse _namespace_name "accountId" |> NamespacedName
    /// <summary>
    /// The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.
    /// <see href="http://schema.org/identifier"></see></summary>
    let identifier = Namespaced_IRI.parse _namespace_name "identifier" |> NamespacedName

    /// <summary>
    /// Specifies the Person that is legally accountable for the CreativeWork.
    /// <see href="http://schema.org/accountablePerson"></see></summary>
    let accountablePerson =
        Namespaced_IRI.parse _namespace_name "accountablePerson" |> NamespacedName

    /// <summary>
    /// The organization or person from which the product was acquired.
    /// <see href="http://schema.org/acquiredFrom"></see></summary>
    let acquiredFrom =
        Namespaced_IRI.parse _namespace_name "acquiredFrom" |> NamespacedName

    /// <summary>
    /// A set of requirements that a must be fulfilled in order to perform an Action. If more than one value is specied, fulfilling one set of requirements will allow the Action to be performed.
    /// <see href="http://schema.org/actionAccessibilityRequirement"></see></summary>
    let actionAccessibilityRequirement =
        Namespaced_IRI.parse _namespace_name "actionAccessibilityRequirement" |> NamespacedName

    /// <summary>
    /// An application that can complete the request.
    /// <see href="http://schema.org/actionApplication"></see></summary>
    let actionApplication =
        Namespaced_IRI.parse _namespace_name "actionApplication" |> NamespacedName

    /// <summary>
    /// A sub property of object. The options subject to this action.
    /// <see href="http://schema.org/actionOption"></see></summary>
    let actionOption =
        Namespaced_IRI.parse _namespace_name "actionOption" |> NamespacedName

    /// <summary>
    /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read &lt;em&gt;a book&lt;/em&gt;.
    /// <see href="http://schema.org/object"></see></summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName

    /// <summary>
    /// The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
    /// <see href="http://schema.org/actionPlatform"></see></summary>
    let actionPlatform =
        Namespaced_IRI.parse _namespace_name "actionPlatform" |> NamespacedName

    /// <summary>
    /// Indicates the current disposition of the Action.
    /// <see href="http://schema.org/actionStatus"></see></summary>
    let actionStatus =
        Namespaced_IRI.parse _namespace_name "actionStatus" |> NamespacedName

    /// <summary>
    /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
    /// <see href="http://schema.org/actor"></see></summary>
    let actor = Namespaced_IRI.parse _namespace_name "actor" |> NamespacedName
    /// <summary>
    /// An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip.
    /// <see href="http://schema.org/actors"></see></summary>
    let actors = Namespaced_IRI.parse _namespace_name "actors" |> NamespacedName
    /// <summary>
    /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
    /// <see href="http://schema.org/addOn"></see></summary>
    let addOn = Namespaced_IRI.parse _namespace_name "addOn" |> NamespacedName

    /// <summary>
    /// An additional name for a Person, can be used for a middle name.
    /// <see href="http://schema.org/additionalName"></see></summary>
    let additionalName =
        Namespaced_IRI.parse _namespace_name "additionalName" |> NamespacedName

    /// <summary>
    /// If responding yes, the number of guests who will attend in addition to the invitee.
    /// <see href="http://schema.org/additionalNumberOfGuests"></see></summary>
    let additionalNumberOfGuests =
        Namespaced_IRI.parse _namespace_name "additionalNumberOfGuests" |> NamespacedName

    /// <summary>
    /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
    /// <see href="http://schema.org/additionalProperty"></see></summary>
    let additionalProperty =
        Namespaced_IRI.parse _namespace_name "additionalProperty" |> NamespacedName

    /// <summary>
    /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
    /// <see href="http://schema.org/additionalType"></see></summary>
    let additionalType =
        Namespaced_IRI.parse _namespace_name "additionalType" |> NamespacedName

    /// <summary>
    /// Physical address of the item.
    /// <see href="http://schema.org/address"></see></summary>
    let address = Namespaced_IRI.parse _namespace_name "address" |> NamespacedName

    /// <summary>
    /// The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.
    /// <see href="http://schema.org/addressCountry"></see></summary>
    let addressCountry =
        Namespaced_IRI.parse _namespace_name "addressCountry" |> NamespacedName

    /// <summary>
    /// The locality in which the street address is, and which is in the region. For example, Mountain View.
    /// <see href="http://schema.org/addressLocality"></see></summary>
    let addressLocality =
        Namespaced_IRI.parse _namespace_name "addressLocality" |> NamespacedName

    /// <summary>
    /// The region in which the locality is, and which is in the country. For example, California or another appropriate first-level &lt;a href="https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country"&gt;Administrative division&lt;/a&gt;
    /// <see href="http://schema.org/addressRegion"></see></summary>
    let addressRegion =
        Namespaced_IRI.parse _namespace_name "addressRegion" |> NamespacedName

    /// <summary>
    /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
    /// <see href="http://schema.org/advanceBookingRequirement"></see></summary>
    let advanceBookingRequirement =
        Namespaced_IRI.parse _namespace_name "advanceBookingRequirement" |> NamespacedName

    /// <summary>
    /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
    /// <see href="http://schema.org/affiliation"></see></summary>
    let affiliation =
        Namespaced_IRI.parse _namespace_name "affiliation" |> NamespacedName

    /// <summary>
    /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
    /// <see href="http://schema.org/memberOf"></see></summary>
    let memberOf = Namespaced_IRI.parse _namespace_name "memberOf" |> NamespacedName
    /// <summary>
    /// A media object representing the circumstances after performing this direction.
    /// <see href="http://schema.org/afterMedia"></see></summary>
    let afterMedia = Namespaced_IRI.parse _namespace_name "afterMedia" |> NamespacedName
    /// <summary>
    /// The direct performer or driver of the action (animate or inanimate). e.g. &lt;em&gt;John&lt;/em&gt; wrote a book.
    /// <see href="http://schema.org/agent"></see></summary>
    let agent = Namespaced_IRI.parse _namespace_name "agent" |> NamespacedName

    /// <summary>
    /// The overall rating, based on a collection of reviews or ratings, of the item.
    /// <see href="http://schema.org/aggregateRating"></see></summary>
    let aggregateRating =
        Namespaced_IRI.parse _namespace_name "aggregateRating" |> NamespacedName

    /// <summary>
    /// The kind of aircraft (e.g., "Boeing 747").
    /// <see href="http://schema.org/aircraft"></see></summary>
    let aircraft = Namespaced_IRI.parse _namespace_name "aircraft" |> NamespacedName
    /// <summary>
    /// A music album.
    /// <see href="http://schema.org/album"></see></summary>
    let album = Namespaced_IRI.parse _namespace_name "album" |> NamespacedName

    /// <summary>
    /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
    /// <see href="http://schema.org/albumProductionType"></see></summary>
    let albumProductionType =
        Namespaced_IRI.parse _namespace_name "albumProductionType" |> NamespacedName

    /// <summary>
    /// A release of this album.
    /// <see href="http://schema.org/albumRelease"></see></summary>
    let albumRelease =
        Namespaced_IRI.parse _namespace_name "albumRelease" |> NamespacedName

    /// <summary>
    /// The album this is a release of.
    /// <see href="http://schema.org/releaseOf"></see></summary>
    let releaseOf = Namespaced_IRI.parse _namespace_name "releaseOf" |> NamespacedName

    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// <see href="http://schema.org/albumReleaseType"></see></summary>
    let albumReleaseType =
        Namespaced_IRI.parse _namespace_name "albumReleaseType" |> NamespacedName

    /// <summary>
    /// A collection of music albums.
    /// <see href="http://schema.org/albums"></see></summary>
    let albums = Namespaced_IRI.parse _namespace_name "albums" |> NamespacedName

    /// <summary>
    /// A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 'educationalSubject', and 'educationalLevel'.
    /// <see href="http://schema.org/alignmentType"></see></summary>
    let alignmentType =
        Namespaced_IRI.parse _namespace_name "alignmentType" |> NamespacedName

    /// <summary>
    /// An alias for the item.
    /// <see href="http://schema.org/alternateName"></see></summary>
    let alternateName =
        Namespaced_IRI.parse _namespace_name "alternateName" |> NamespacedName

    /// <summary>
    /// A secondary title of the CreativeWork.
    /// <see href="http://schema.org/alternativeHeadline"></see></summary>
    let alternativeHeadline =
        Namespaced_IRI.parse _namespace_name "alternativeHeadline" |> NamespacedName

    /// <summary>
    /// Alumni of an organization.
    /// <see href="http://schema.org/alumni"></see></summary>
    let alumni = Namespaced_IRI.parse _namespace_name "alumni" |> NamespacedName
    /// <summary>
    /// An organization that the person is an alumni of.
    /// <see href="http://schema.org/alumniOf"></see></summary>
    let alumniOf = Namespaced_IRI.parse _namespace_name "alumniOf" |> NamespacedName

    /// <summary>
    /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
    /// <see href="http://schema.org/amenityFeature"></see></summary>
    let amenityFeature =
        Namespaced_IRI.parse _namespace_name "amenityFeature" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/FloorPlan"></see>
    /// </summary>
    let FloorPlan = Namespaced_IRI.parse _namespace_name "FloorPlan" |> NamespacedName
    /// <summary>
    /// The amount of money.
    /// <see href="http://schema.org/amount"></see></summary>
    let amount = Namespaced_IRI.parse _namespace_name "amount" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/MoneyTransfer"></see>
    /// </summary>
    let MoneyTransfer =
        Namespaced_IRI.parse _namespace_name "MoneyTransfer" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/MonetaryGrant"></see>
    /// </summary>
    let MonetaryGrant =
        Namespaced_IRI.parse _namespace_name "MonetaryGrant" |> NamespacedName

    /// <summary>
    /// The quantity of the goods included in the offer.
    /// <see href="http://schema.org/amountOfThisGood"></see></summary>
    let amountOfThisGood =
        Namespaced_IRI.parse _namespace_name "amountOfThisGood" |> NamespacedName

    /// <summary>
    /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
    /// <see href="http://schema.org/annualPercentageRate"></see></summary>
    let annualPercentageRate =
        Namespaced_IRI.parse _namespace_name "annualPercentageRate" |> NamespacedName

    /// <summary>
    /// The number of answers this question has received.
    /// <see href="http://schema.org/answerCount"></see></summary>
    let answerCount =
        Namespaced_IRI.parse _namespace_name "answerCount" |> NamespacedName

    /// <summary>
    /// An application that can complete the request.
    /// <see href="http://schema.org/application"></see></summary>
    let application =
        Namespaced_IRI.parse _namespace_name "application" |> NamespacedName

    /// <summary>
    /// Type of software application, e.g. 'Game, Multimedia'.
    /// <see href="http://schema.org/applicationCategory"></see></summary>
    let applicationCategory =
        Namespaced_IRI.parse _namespace_name "applicationCategory" |> NamespacedName

    /// <summary>
    /// Subcategory of the application, e.g. 'Arcade Game'.
    /// <see href="http://schema.org/applicationSubCategory"></see></summary>
    let applicationSubCategory =
        Namespaced_IRI.parse _namespace_name "applicationSubCategory" |> NamespacedName

    /// <summary>
    /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
    /// <see href="http://schema.org/applicationSuite"></see></summary>
    let applicationSuite =
        Namespaced_IRI.parse _namespace_name "applicationSuite" |> NamespacedName

    /// <summary>
    /// The delivery method(s) to which the delivery charge or payment charge specification applies.
    /// <see href="http://schema.org/appliesToDeliveryMethod"></see></summary>
    let appliesToDeliveryMethod =
        Namespaced_IRI.parse _namespace_name "appliesToDeliveryMethod" |> NamespacedName

    /// <summary>
    /// The payment method(s) to which the payment charge specification applies.
    /// <see href="http://schema.org/appliesToPaymentMethod"></see></summary>
    let appliesToPaymentMethod =
        Namespaced_IRI.parse _namespace_name "appliesToPaymentMethod" |> NamespacedName

    /// <summary>
    /// The area within which users can expect to reach the broadcast service.
    /// <see href="http://schema.org/area"></see></summary>
    let area = Namespaced_IRI.parse _namespace_name "area" |> NamespacedName

    /// <summary>
    /// The geographic area where the service is provided.
    /// <see href="http://schema.org/serviceArea"></see></summary>
    let serviceArea =
        Namespaced_IRI.parse _namespace_name "serviceArea" |> NamespacedName

    /// <summary>
    /// The geographic area where a service or offered item is provided.
    /// <see href="http://schema.org/areaServed"></see></summary>
    let areaServed = Namespaced_IRI.parse _namespace_name "areaServed" |> NamespacedName

    /// <summary>
    /// The airport where the flight terminates.
    /// <see href="http://schema.org/arrivalAirport"></see></summary>
    let arrivalAirport =
        Namespaced_IRI.parse _namespace_name "arrivalAirport" |> NamespacedName

    /// <summary>
    /// The stop or station from which the bus arrives.
    /// <see href="http://schema.org/arrivalBusStop"></see></summary>
    let arrivalBusStop =
        Namespaced_IRI.parse _namespace_name "arrivalBusStop" |> NamespacedName

    /// <summary>
    /// Identifier of the flight's arrival gate.
    /// <see href="http://schema.org/arrivalGate"></see></summary>
    let arrivalGate =
        Namespaced_IRI.parse _namespace_name "arrivalGate" |> NamespacedName

    /// <summary>
    /// The platform where the train arrives.
    /// <see href="http://schema.org/arrivalPlatform"></see></summary>
    let arrivalPlatform =
        Namespaced_IRI.parse _namespace_name "arrivalPlatform" |> NamespacedName

    /// <summary>
    /// The station where the train trip ends.
    /// <see href="http://schema.org/arrivalStation"></see></summary>
    let arrivalStation =
        Namespaced_IRI.parse _namespace_name "arrivalStation" |> NamespacedName

    /// <summary>
    /// Identifier of the flight's arrival terminal.
    /// <see href="http://schema.org/arrivalTerminal"></see></summary>
    let arrivalTerminal =
        Namespaced_IRI.parse _namespace_name "arrivalTerminal" |> NamespacedName

    /// <summary>
    /// The expected arrival time.
    /// <see href="http://schema.org/arrivalTime"></see></summary>
    let arrivalTime =
        Namespaced_IRI.parse _namespace_name "arrivalTime" |> NamespacedName

    /// <summary>
    /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
    /// <see href="http://schema.org/artEdition"></see></summary>
    let artEdition = Namespaced_IRI.parse _namespace_name "artEdition" |> NamespacedName
    /// <summary>
    /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
    /// <see href="http://schema.org/artMedium"></see></summary>
    let artMedium = Namespaced_IRI.parse _namespace_name "artMedium" |> NamespacedName
    /// <summary>
    /// A material that something is made from, e.g. leather, wool, cotton, paper.
    /// <see href="http://schema.org/material"></see></summary>
    let material = Namespaced_IRI.parse _namespace_name "material" |> NamespacedName
    /// <summary>
    /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
    /// <see href="http://schema.org/artform"></see></summary>
    let artform = Namespaced_IRI.parse _namespace_name "artform" |> NamespacedName

    /// <summary>
    /// The actual body of the article.
    /// <see href="http://schema.org/articleBody"></see></summary>
    let articleBody =
        Namespaced_IRI.parse _namespace_name "articleBody" |> NamespacedName

    /// <summary>
    /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
    /// <see href="http://schema.org/articleSection"></see></summary>
    let articleSection =
        Namespaced_IRI.parse _namespace_name "articleSection" |> NamespacedName

    /// <summary>
    /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
    /// <see href="http://schema.org/artworkSurface"></see></summary>
    let artworkSurface =
        Namespaced_IRI.parse _namespace_name "artworkSurface" |> NamespacedName

    /// <summary>
    /// Library file name e.g., mscorlib.dll, system.web.dll.
    /// <see href="http://schema.org/assembly"></see></summary>
    let assembly = Namespaced_IRI.parse _namespace_name "assembly" |> NamespacedName

    /// <summary>
    /// Library file name e.g., mscorlib.dll, system.web.dll.
    /// <see href="http://schema.org/executableLibraryName"></see></summary>
    let executableLibraryName =
        Namespaced_IRI.parse _namespace_name "executableLibraryName" |> NamespacedName

    /// <summary>
    /// Associated product/technology version. e.g., .NET Framework 4.5.
    /// <see href="http://schema.org/assemblyVersion"></see></summary>
    let assemblyVersion =
        Namespaced_IRI.parse _namespace_name "assemblyVersion" |> NamespacedName

    /// <summary>
    /// A NewsArticle associated with the Media Object.
    /// <see href="http://schema.org/associatedArticle"></see></summary>
    let associatedArticle =
        Namespaced_IRI.parse _namespace_name "associatedArticle" |> NamespacedName

    /// <summary>
    /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
    /// <see href="http://schema.org/associatedMedia"></see></summary>
    let associatedMedia =
        Namespaced_IRI.parse _namespace_name "associatedMedia" |> NamespacedName

    /// <summary>
    /// A person that acts as performing member of a sports team; a player as opposed to a coach.
    /// <see href="http://schema.org/athlete"></see></summary>
    let athlete = Namespaced_IRI.parse _namespace_name "athlete" |> NamespacedName
    /// <summary>
    /// A person or organization attending the event.
    /// <see href="http://schema.org/attendee"></see></summary>
    let attendee = Namespaced_IRI.parse _namespace_name "attendee" |> NamespacedName
    /// <summary>
    /// A person attending the event.
    /// <see href="http://schema.org/attendees"></see></summary>
    let attendees = Namespaced_IRI.parse _namespace_name "attendees" |> NamespacedName
    /// <summary>
    /// An intended audience, i.e. a group for whom something was created.
    /// <see href="http://schema.org/audience"></see></summary>
    let audience = Namespaced_IRI.parse _namespace_name "audience" |> NamespacedName

    /// <summary>
    /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
    /// <see href="http://schema.org/audienceType"></see></summary>
    let audienceType =
        Namespaced_IRI.parse _namespace_name "audienceType" |> NamespacedName

    /// <summary>
    /// An embedded audio object.
    /// <see href="http://schema.org/audio"></see></summary>
    let audio = Namespaced_IRI.parse _namespace_name "audio" |> NamespacedName

    /// <summary>
    /// The Organization responsible for authenticating the user's subscription. For example, many media apps require a cable/satellite provider to authenticate your subscription before playing media.
    /// <see href="http://schema.org/authenticator"></see></summary>
    let authenticator =
        Namespaced_IRI.parse _namespace_name "authenticator" |> NamespacedName

    /// <summary>
    /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
    /// <see href="http://schema.org/author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName

    /// <summary>
    /// The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.
    /// <see href="http://schema.org/availability"></see></summary>
    let availability =
        Namespaced_IRI.parse _namespace_name "availability" |> NamespacedName

    /// <summary>
    /// The end of the availability of the product or service included in the offer.
    /// <see href="http://schema.org/availabilityEnds"></see></summary>
    let availabilityEnds =
        Namespaced_IRI.parse _namespace_name "availabilityEnds" |> NamespacedName

    /// <summary>
    /// The beginning of the availability of the product or service included in the offer.
    /// <see href="http://schema.org/availabilityStarts"></see></summary>
    let availabilityStarts =
        Namespaced_IRI.parse _namespace_name "availabilityStarts" |> NamespacedName

    /// <summary>
    /// The place(s) from which the offer can be obtained (e.g. store locations).
    /// <see href="http://schema.org/availableAtOrFrom"></see></summary>
    let availableAtOrFrom =
        Namespaced_IRI.parse _namespace_name "availableAtOrFrom" |> NamespacedName

    /// <summary>
    /// A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
    /// <see href="http://schema.org/availableChannel"></see></summary>
    let availableChannel =
        Namespaced_IRI.parse _namespace_name "availableChannel" |> NamespacedName

    /// <summary>
    /// The delivery method(s) available for this offer.
    /// <see href="http://schema.org/availableDeliveryMethod"></see></summary>
    let availableDeliveryMethod =
        Namespaced_IRI.parse _namespace_name "availableDeliveryMethod" |> NamespacedName

    /// <summary>
    /// When the item is available for pickup from the store, locker, etc.
    /// <see href="http://schema.org/availableFrom"></see></summary>
    let availableFrom =
        Namespaced_IRI.parse _namespace_name "availableFrom" |> NamespacedName

    /// <summary>
    /// A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;
    /// <see href="http://schema.org/availableLanguage"></see></summary>
    let availableLanguage =
        Namespaced_IRI.parse _namespace_name "availableLanguage" |> NamespacedName

    /// <summary>
    /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
    /// <see href="http://schema.org/availableOnDevice"></see></summary>
    let availableOnDevice =
        Namespaced_IRI.parse _namespace_name "availableOnDevice" |> NamespacedName

    /// <summary>
    /// After this date, the item will no longer be available for pickup.
    /// <see href="http://schema.org/availableThrough"></see></summary>
    let availableThrough =
        Namespaced_IRI.parse _namespace_name "availableThrough" |> NamespacedName

    /// <summary>
    /// An award won by or for this item.
    /// <see href="http://schema.org/award"></see></summary>
    let award = Namespaced_IRI.parse _namespace_name "award" |> NamespacedName
    /// <summary>
    /// Awards won by or for this item.
    /// <see href="http://schema.org/awards"></see></summary>
    let awards = Namespaced_IRI.parse _namespace_name "awards" |> NamespacedName
    /// <summary>
    /// The away team in a sports event.
    /// <see href="http://schema.org/awayTeam"></see></summary>
    let awayTeam = Namespaced_IRI.parse _namespace_name "awayTeam" |> NamespacedName
    /// <summary>
    /// A competitor in a sports event.
    /// <see href="http://schema.org/competitor"></see></summary>
    let competitor = Namespaced_IRI.parse _namespace_name "competitor" |> NamespacedName
    /// <summary>
    /// The base salary of the job or of an employee in an EmployeeRole.
    /// <see href="http://schema.org/baseSalary"></see></summary>
    let baseSalary = Namespaced_IRI.parse _namespace_name "baseSalary" |> NamespacedName

    /// <summary>
    /// A sub property of recipient. The recipient blind copied on a message.
    /// <see href="http://schema.org/bccRecipient"></see></summary>
    let bccRecipient =
        Namespaced_IRI.parse _namespace_name "bccRecipient" |> NamespacedName

    /// <summary>
    /// A sub property of participant. The participant who is at the receiving end of the action.
    /// <see href="http://schema.org/recipient"></see></summary>
    let recipient = Namespaced_IRI.parse _namespace_name "recipient" |> NamespacedName
    /// <summary>
    /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
    ///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.
    /// <see href="http://schema.org/bed"></see></summary>
    let bed = Namespaced_IRI.parse _namespace_name "bed" |> NamespacedName

    /// <summary>
    /// A media object representing the circumstances before performing this direction.
    /// <see href="http://schema.org/beforeMedia"></see></summary>
    let beforeMedia =
        Namespaced_IRI.parse _namespace_name "beforeMedia" |> NamespacedName

    /// <summary>
    /// Description of benefits associated with the job.
    /// <see href="http://schema.org/benefits"></see></summary>
    let benefits = Namespaced_IRI.parse _namespace_name "benefits" |> NamespacedName

    /// <summary>
    /// Description of benefits associated with the job.
    /// <see href="http://schema.org/jobBenefits"></see></summary>
    let jobBenefits =
        Namespaced_IRI.parse _namespace_name "jobBenefits" |> NamespacedName

    /// <summary>
    /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
    /// <see href="http://schema.org/bestRating"></see></summary>
    let bestRating = Namespaced_IRI.parse _namespace_name "bestRating" |> NamespacedName

    /// <summary>
    /// The billing address for the order.
    /// <see href="http://schema.org/billingAddress"></see></summary>
    let billingAddress =
        Namespaced_IRI.parse _namespace_name "billingAddress" |> NamespacedName

    /// <summary>
    /// This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.
    /// <see href="http://schema.org/billingIncrement"></see></summary>
    let billingIncrement =
        Namespaced_IRI.parse _namespace_name "billingIncrement" |> NamespacedName

    /// <summary>
    /// The time interval used to compute the invoice.
    /// <see href="http://schema.org/billingPeriod"></see></summary>
    let billingPeriod =
        Namespaced_IRI.parse _namespace_name "billingPeriod" |> NamespacedName

    /// <summary>
    /// Date of birth.
    /// <see href="http://schema.org/birthDate"></see></summary>
    let birthDate = Namespaced_IRI.parse _namespace_name "birthDate" |> NamespacedName
    /// <summary>
    /// The place where the person was born.
    /// <see href="http://schema.org/birthPlace"></see></summary>
    let birthPlace = Namespaced_IRI.parse _namespace_name "birthPlace" |> NamespacedName
    /// <summary>
    /// The bitrate of the media object.
    /// <see href="http://schema.org/bitrate"></see></summary>
    let bitrate = Namespaced_IRI.parse _namespace_name "bitrate" |> NamespacedName
    /// <summary>
    /// A posting that is part of this blog.
    /// <see href="http://schema.org/blogPost"></see></summary>
    let blogPost = Namespaced_IRI.parse _namespace_name "blogPost" |> NamespacedName
    /// <summary>
    /// The postings that are part of this blog.
    /// <see href="http://schema.org/blogPosts"></see></summary>
    let blogPosts = Namespaced_IRI.parse _namespace_name "blogPosts" |> NamespacedName

    /// <summary>
    /// The airline-specific indicator of boarding order / preference.
    /// <see href="http://schema.org/boardingGroup"></see></summary>
    let boardingGroup =
        Namespaced_IRI.parse _namespace_name "boardingGroup" |> NamespacedName

    /// <summary>
    /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
    /// <see href="http://schema.org/boardingPolicy"></see></summary>
    let boardingPolicy =
        Namespaced_IRI.parse _namespace_name "boardingPolicy" |> NamespacedName

    /// <summary>
    /// The edition of the book.
    /// <see href="http://schema.org/bookEdition"></see></summary>
    let bookEdition =
        Namespaced_IRI.parse _namespace_name "bookEdition" |> NamespacedName

    /// <summary>
    /// The format of the book.
    /// <see href="http://schema.org/bookFormat"></see></summary>
    let bookFormat = Namespaced_IRI.parse _namespace_name "bookFormat" |> NamespacedName

    /// <summary>
    /// 'bookingAgent' is an out-dated term indicating a 'broker' that serves as a booking agent.
    /// <see href="http://schema.org/bookingAgent"></see></summary>
    let bookingAgent =
        Namespaced_IRI.parse _namespace_name "bookingAgent" |> NamespacedName

    /// <summary>
    /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
    /// <see href="http://schema.org/broker"></see></summary>
    let broker = Namespaced_IRI.parse _namespace_name "broker" |> NamespacedName

    /// <summary>
    /// The date and time the reservation was booked.
    /// <see href="http://schema.org/bookingTime"></see></summary>
    let bookingTime =
        Namespaced_IRI.parse _namespace_name "bookingTime" |> NamespacedName

    /// <summary>
    /// A sub property of participant. The person that borrows the object being lent.
    /// <see href="http://schema.org/borrower"></see></summary>
    let borrower = Namespaced_IRI.parse _namespace_name "borrower" |> NamespacedName

    /// <summary>
    /// Other co-agents that participated in the action indirectly. e.g. John wrote a book with &lt;em&gt;Steve&lt;/em&gt;.
    /// <see href="http://schema.org/participant"></see></summary>
    let participant =
        Namespaced_IRI.parse _namespace_name "participant" |> NamespacedName

    /// <summary>
    /// A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.
    /// <see href="http://schema.org/box"></see></summary>
    let box = Namespaced_IRI.parse _namespace_name "box" |> NamespacedName
    /// <summary>
    /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
    ///
    /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
    /// <see href="http://schema.org/branchCode"></see></summary>
    let branchCode = Namespaced_IRI.parse _namespace_name "branchCode" |> NamespacedName
    /// <summary>
    /// The larger organization that this local business is a branch of, if any. Not to be confused with (anatomical)&lt;a class="localLink" href="http://schema.org/branch"&gt;branch&lt;/a&gt;.
    /// <see href="http://schema.org/branchOf"></see></summary>
    let branchOf = Namespaced_IRI.parse _namespace_name "branchOf" |> NamespacedName

    /// <summary>
    /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
    /// <see href="http://schema.org/parentOrganization"></see></summary>
    let parentOrganization =
        Namespaced_IRI.parse _namespace_name "parentOrganization" |> NamespacedName

    /// <summary>
    /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
    /// <see href="http://schema.org/brand"></see></summary>
    let brand = Namespaced_IRI.parse _namespace_name "brand" |> NamespacedName
    /// <summary>
    /// A set of links that can help a user understand and navigate a website hierarchy.
    /// <see href="http://schema.org/breadcrumb"></see></summary>
    let breadcrumb = Namespaced_IRI.parse _namespace_name "breadcrumb" |> NamespacedName

    /// <summary>
    /// The media network(s) whose content is broadcast on this station.
    /// <see href="http://schema.org/broadcastAffiliateOf"></see></summary>
    let broadcastAffiliateOf =
        Namespaced_IRI.parse _namespace_name "broadcastAffiliateOf" |> NamespacedName

    /// <summary>
    /// The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.
    /// <see href="http://schema.org/broadcastChannelId"></see></summary>
    let broadcastChannelId =
        Namespaced_IRI.parse _namespace_name "broadcastChannelId" |> NamespacedName

    /// <summary>
    /// The name displayed in the channel guide. For many US affiliates, it is the network name.
    /// <see href="http://schema.org/broadcastDisplayName"></see></summary>
    let broadcastDisplayName =
        Namespaced_IRI.parse _namespace_name "broadcastDisplayName" |> NamespacedName

    /// <summary>
    /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
    /// <see href="http://schema.org/broadcastFrequency"></see></summary>
    let broadcastFrequency =
        Namespaced_IRI.parse _namespace_name "broadcastFrequency" |> NamespacedName

    /// <summary>
    /// The frequency in MHz for a particular broadcast.
    /// <see href="http://schema.org/broadcastFrequencyValue"></see></summary>
    let broadcastFrequencyValue =
        Namespaced_IRI.parse _namespace_name "broadcastFrequencyValue" |> NamespacedName

    /// <summary>
    /// The event being broadcast such as a sporting event or awards ceremony.
    /// <see href="http://schema.org/broadcastOfEvent"></see></summary>
    let broadcastOfEvent =
        Namespaced_IRI.parse _namespace_name "broadcastOfEvent" |> NamespacedName

    /// <summary>
    /// The type of service required to have access to the channel (e.g. Standard or Premium).
    /// <see href="http://schema.org/broadcastServiceTier"></see></summary>
    let broadcastServiceTier =
        Namespaced_IRI.parse _namespace_name "broadcastServiceTier" |> NamespacedName

    /// <summary>
    /// The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts
    /// <see href="http://schema.org/broadcastTimezone"></see></summary>
    let broadcastTimezone =
        Namespaced_IRI.parse _namespace_name "broadcastTimezone" |> NamespacedName

    /// <summary>
    /// The organization owning or operating the broadcast service.
    /// <see href="http://schema.org/broadcaster"></see></summary>
    let broadcaster =
        Namespaced_IRI.parse _namespace_name "broadcaster" |> NamespacedName

    /// <summary>
    /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
    /// <see href="http://schema.org/browserRequirements"></see></summary>
    let browserRequirements =
        Namespaced_IRI.parse _namespace_name "browserRequirements" |> NamespacedName

    /// <summary>
    /// The name of the bus (e.g. Bolt Express).
    /// <see href="http://schema.org/busName"></see></summary>
    let busName = Namespaced_IRI.parse _namespace_name "busName" |> NamespacedName
    /// <summary>
    /// The unique identifier for the bus.
    /// <see href="http://schema.org/busNumber"></see></summary>
    let busNumber = Namespaced_IRI.parse _namespace_name "busNumber" |> NamespacedName

    /// <summary>
    /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
    /// <see href="http://schema.org/businessFunction"></see></summary>
    let businessFunction =
        Namespaced_IRI.parse _namespace_name "businessFunction" |> NamespacedName

    /// <summary>
    /// A sub property of participant. The participant/person/organization that bought the object.
    /// <see href="http://schema.org/buyer"></see></summary>
    let buyer = Namespaced_IRI.parse _namespace_name "buyer" |> NamespacedName
    /// <summary>
    /// The artist that performed this album or recording.
    /// <see href="http://schema.org/byArtist"></see></summary>
    let byArtist = Namespaced_IRI.parse _namespace_name "byArtist" |> NamespacedName
    /// <summary>
    /// The number of calories.
    /// <see href="http://schema.org/calories"></see></summary>
    let calories = Namespaced_IRI.parse _namespace_name "calories" |> NamespacedName
    /// <summary>
    /// A sub property of object. The candidate subject of this action.
    /// <see href="http://schema.org/candidate"></see></summary>
    let candidate = Namespaced_IRI.parse _namespace_name "candidate" |> NamespacedName
    /// <summary>
    /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
    /// <see href="http://schema.org/caption"></see></summary>
    let caption = Namespaced_IRI.parse _namespace_name "caption" |> NamespacedName

    /// <summary>
    /// The number of grams of carbohydrates.
    /// <see href="http://schema.org/carbohydrateContent"></see></summary>
    let carbohydrateContent =
        Namespaced_IRI.parse _namespace_name "carbohydrateContent" |> NamespacedName

    /// <summary>
    /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
    /// <see href="http://schema.org/cargoVolume"></see></summary>
    let cargoVolume =
        Namespaced_IRI.parse _namespace_name "cargoVolume" |> NamespacedName

    /// <summary>
    /// 'carrier' is an out-dated term indicating the 'provider' for parcel delivery and flights.
    /// <see href="http://schema.org/carrier"></see></summary>
    let carrier = Namespaced_IRI.parse _namespace_name "carrier" |> NamespacedName
    /// <summary>
    /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
    /// <see href="http://schema.org/provider"></see></summary>
    let provider = Namespaced_IRI.parse _namespace_name "provider" |> NamespacedName

    /// <summary>
    /// Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).
    /// <see href="http://schema.org/carrierRequirements"></see></summary>
    let carrierRequirements =
        Namespaced_IRI.parse _namespace_name "carrierRequirements" |> NamespacedName

    /// <summary>
    /// A data catalog which contains this dataset.
    /// <see href="http://schema.org/catalog"></see></summary>
    let catalog = Namespaced_IRI.parse _namespace_name "catalog" |> NamespacedName

    /// <summary>
    /// A data catalog which contains this dataset.
    /// <see href="http://schema.org/includedInDataCatalog"></see></summary>
    let includedInDataCatalog =
        Namespaced_IRI.parse _namespace_name "includedInDataCatalog" |> NamespacedName

    /// <summary>
    /// The catalog number for the release.
    /// <see href="http://schema.org/catalogNumber"></see></summary>
    let catalogNumber =
        Namespaced_IRI.parse _namespace_name "catalogNumber" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/SpecialAnnouncement"></see>
    /// </summary>
    let SpecialAnnouncement =
        Namespaced_IRI.parse _namespace_name "SpecialAnnouncement" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/PhysicalActivity"></see>
    /// </summary>
    let PhysicalActivity =
        Namespaced_IRI.parse _namespace_name "PhysicalActivity" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/Recommendation"></see>
    /// </summary>
    let Recommendation =
        Namespaced_IRI.parse _namespace_name "Recommendation" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/PhysicalActivityCategory"></see>
    /// </summary>
    let PhysicalActivityCategory =
        Namespaced_IRI.parse _namespace_name "PhysicalActivityCategory" |> NamespacedName

    /// <summary>
    /// A sub property of recipient. The recipient copied on a message.
    /// <see href="http://schema.org/ccRecipient"></see></summary>
    let ccRecipient =
        Namespaced_IRI.parse _namespace_name "ccRecipient" |> NamespacedName

    /// <summary>
    /// Fictional person connected with a creative work.
    /// <see href="http://schema.org/character"></see></summary>
    let character = Namespaced_IRI.parse _namespace_name "character" |> NamespacedName

    /// <summary>
    /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
    /// <see href="http://schema.org/characterAttribute"></see></summary>
    let characterAttribute =
        Namespaced_IRI.parse _namespace_name "characterAttribute" |> NamespacedName

    /// <summary>
    /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
    /// <see href="http://schema.org/characterName"></see></summary>
    let characterName =
        Namespaced_IRI.parse _namespace_name "characterName" |> NamespacedName

    /// <summary>
    /// Cheat codes to the game.
    /// <see href="http://schema.org/cheatCode"></see></summary>
    let cheatCode = Namespaced_IRI.parse _namespace_name "cheatCode" |> NamespacedName

    /// <summary>
    /// The earliest someone may check into a lodging establishment.
    /// <see href="http://schema.org/checkinTime"></see></summary>
    let checkinTime =
        Namespaced_IRI.parse _namespace_name "checkinTime" |> NamespacedName

    /// <summary>
    /// The latest someone may check out of a lodging establishment.
    /// <see href="http://schema.org/checkoutTime"></see></summary>
    let checkoutTime =
        Namespaced_IRI.parse _namespace_name "checkoutTime" |> NamespacedName

    /// <summary>
    /// Maximal age of the child.
    /// <see href="http://schema.org/childMaxAge"></see></summary>
    let childMaxAge =
        Namespaced_IRI.parse _namespace_name "childMaxAge" |> NamespacedName

    /// <summary>
    /// Minimal age of the child.
    /// <see href="http://schema.org/childMinAge"></see></summary>
    let childMinAge =
        Namespaced_IRI.parse _namespace_name "childMinAge" |> NamespacedName

    /// <summary>
    /// A child of the person.
    /// <see href="http://schema.org/children"></see></summary>
    let children = Namespaced_IRI.parse _namespace_name "children" |> NamespacedName

    /// <summary>
    /// The number of milligrams of cholesterol.
    /// <see href="http://schema.org/cholesterolContent"></see></summary>
    let cholesterolContent =
        Namespaced_IRI.parse _namespace_name "cholesterolContent" |> NamespacedName

    /// <summary>
    /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
    /// <see href="http://schema.org/circle"></see></summary>
    let circle = Namespaced_IRI.parse _namespace_name "circle" |> NamespacedName
    /// <summary>
    /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
    /// <see href="http://schema.org/citation"></see></summary>
    let citation = Namespaced_IRI.parse _namespace_name "citation" |> NamespacedName

    /// <summary>
    /// A short summary of the specific claims reviewed in a ClaimReview.
    /// <see href="http://schema.org/claimReviewed"></see></summary>
    let claimReviewed =
        Namespaced_IRI.parse _namespace_name "claimReviewed" |> NamespacedName

    /// <summary>
    /// Position of the clip within an ordered group of clips.
    /// <see href="http://schema.org/clipNumber"></see></summary>
    let clipNumber = Namespaced_IRI.parse _namespace_name "clipNumber" |> NamespacedName
    /// <summary>
    /// The position of an item in a series or sequence of items.
    /// <see href="http://schema.org/position"></see></summary>
    let position = Namespaced_IRI.parse _namespace_name "position" |> NamespacedName
    /// <summary>
    /// The closing hour of the place or service on the given day(s) of the week.
    /// <see href="http://schema.org/closes"></see></summary>
    let closes = Namespaced_IRI.parse _namespace_name "closes" |> NamespacedName
    /// <summary>
    /// A person that acts in a coaching role for a sports team.
    /// <see href="http://schema.org/coach"></see></summary>
    let coach = Namespaced_IRI.parse _namespace_name "coach" |> NamespacedName

    /// <summary>
    /// Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex).
    /// <see href="http://schema.org/codeRepository"></see></summary>
    let codeRepository =
        Namespaced_IRI.parse _namespace_name "codeRepository" |> NamespacedName

    /// <summary>
    /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
    /// <see href="http://schema.org/codeSampleType"></see></summary>
    let codeSampleType =
        Namespaced_IRI.parse _namespace_name "codeSampleType" |> NamespacedName

    /// <summary>
    /// A colleague of the person.
    /// <see href="http://schema.org/colleague"></see></summary>
    let colleague = Namespaced_IRI.parse _namespace_name "colleague" |> NamespacedName
    /// <summary>
    /// A colleague of the person.
    /// <see href="http://schema.org/colleagues"></see></summary>
    let colleagues = Namespaced_IRI.parse _namespace_name "colleagues" |> NamespacedName
    /// <summary>
    /// A sub property of object. The collection target of the action.
    /// <see href="http://schema.org/collection"></see></summary>
    let collection = Namespaced_IRI.parse _namespace_name "collection" |> NamespacedName

    /// <summary>
    /// A sub property of object. The collection target of the action.
    /// <see href="http://schema.org/targetCollection"></see></summary>
    let targetCollection =
        Namespaced_IRI.parse _namespace_name "targetCollection" |> NamespacedName

    /// <summary>
    /// The color of the product.
    /// <see href="http://schema.org/color"></see></summary>
    let color = Namespaced_IRI.parse _namespace_name "color" |> NamespacedName
    /// <summary>
    /// Comments, typically from users.
    /// <see href="http://schema.org/comment"></see></summary>
    let comment = Namespaced_IRI.parse _namespace_name "comment" |> NamespacedName

    /// <summary>
    /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
    /// <see href="http://schema.org/commentCount"></see></summary>
    let commentCount =
        Namespaced_IRI.parse _namespace_name "commentCount" |> NamespacedName

    /// <summary>
    /// The text of the UserComment.
    /// <see href="http://schema.org/commentText"></see></summary>
    let commentText =
        Namespaced_IRI.parse _namespace_name "commentText" |> NamespacedName

    /// <summary>
    /// The time at which the UserComment was made.
    /// <see href="http://schema.org/commentTime"></see></summary>
    let commentTime =
        Namespaced_IRI.parse _namespace_name "commentTime" |> NamespacedName

    /// <summary>
    /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
    /// <see href="http://schema.org/composer"></see></summary>
    let composer = Namespaced_IRI.parse _namespace_name "composer" |> NamespacedName

    /// <summary>
    /// A number that confirms the given order or payment has been received.
    /// <see href="http://schema.org/confirmationNumber"></see></summary>
    let confirmationNumber =
        Namespaced_IRI.parse _namespace_name "confirmationNumber" |> NamespacedName

    /// <summary>
    /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
    /// <see href="http://schema.org/contactOption"></see></summary>
    let contactOption =
        Namespaced_IRI.parse _namespace_name "contactOption" |> NamespacedName

    /// <summary>
    /// A contact point for a person or organization.
    /// <see href="http://schema.org/contactPoint"></see></summary>
    let contactPoint =
        Namespaced_IRI.parse _namespace_name "contactPoint" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/HealthInsurancePlan"></see>
    /// </summary>
    let HealthInsurancePlan =
        Namespaced_IRI.parse _namespace_name "HealthInsurancePlan" |> NamespacedName

    /// <summary>
    /// A contact point for a person or organization.
    /// <see href="http://schema.org/contactPoints"></see></summary>
    let contactPoints =
        Namespaced_IRI.parse _namespace_name "contactPoints" |> NamespacedName

    /// <summary>
    /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
    /// <see href="http://schema.org/contactType"></see></summary>
    let contactType =
        Namespaced_IRI.parse _namespace_name "contactType" |> NamespacedName

    /// <summary>
    /// The basic containment relation between a place and one that contains it.
    /// <see href="http://schema.org/containedIn"></see></summary>
    let containedIn =
        Namespaced_IRI.parse _namespace_name "containedIn" |> NamespacedName

    /// <summary>
    /// The basic containment relation between a place and one that contains it.
    /// <see href="http://schema.org/containedInPlace"></see></summary>
    let containedInPlace =
        Namespaced_IRI.parse _namespace_name "containedInPlace" |> NamespacedName

    /// <summary>
    /// The basic containment relation between a place and another that it contains.
    /// <see href="http://schema.org/containsPlace"></see></summary>
    let containsPlace =
        Namespaced_IRI.parse _namespace_name "containsPlace" |> NamespacedName

    /// <summary>
    /// A season that is part of the media series.
    /// <see href="http://schema.org/containsSeason"></see></summary>
    let containsSeason =
        Namespaced_IRI.parse _namespace_name "containsSeason" |> NamespacedName

    /// <summary>
    /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).
    /// <see href="http://schema.org/hasPart"></see></summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName

    /// <summary>
    /// The location depicted or described in the content. For example, the location in a photograph or painting.
    /// <see href="http://schema.org/contentLocation"></see></summary>
    let contentLocation =
        Namespaced_IRI.parse _namespace_name "contentLocation" |> NamespacedName

    /// <summary>
    /// Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.
    /// <see href="http://schema.org/contentRating"></see></summary>
    let contentRating =
        Namespaced_IRI.parse _namespace_name "contentRating" |> NamespacedName

    /// <summary>
    /// File size in (mega/kilo) bytes.
    /// <see href="http://schema.org/contentSize"></see></summary>
    let contentSize =
        Namespaced_IRI.parse _namespace_name "contentSize" |> NamespacedName

    /// <summary>
    /// The supported content type(s) for an EntryPoint response.
    /// <see href="http://schema.org/contentType"></see></summary>
    let contentType =
        Namespaced_IRI.parse _namespace_name "contentType" |> NamespacedName

    /// <summary>
    /// Actual bytes of the media object, for example the image file or video file.
    /// <see href="http://schema.org/contentUrl"></see></summary>
    let contentUrl = Namespaced_IRI.parse _namespace_name "contentUrl" |> NamespacedName

    /// <summary>
    /// A secondary contributor to the CreativeWork or Event.
    /// <see href="http://schema.org/contributor"></see></summary>
    let contributor =
        Namespaced_IRI.parse _namespace_name "contributor" |> NamespacedName

    /// <summary>
    /// The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
    /// <see href="http://schema.org/cookTime"></see></summary>
    let cookTime = Namespaced_IRI.parse _namespace_name "cookTime" |> NamespacedName

    /// <summary>
    /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
    /// <see href="http://schema.org/performTime"></see></summary>
    let performTime =
        Namespaced_IRI.parse _namespace_name "performTime" |> NamespacedName

    /// <summary>
    /// The method of cooking, such as Frying, Steaming, ...
    /// <see href="http://schema.org/cookingMethod"></see></summary>
    let cookingMethod =
        Namespaced_IRI.parse _namespace_name "cookingMethod" |> NamespacedName

    /// <summary>
    /// The party holding the legal copyright to the CreativeWork.
    /// <see href="http://schema.org/copyrightHolder"></see></summary>
    let copyrightHolder =
        Namespaced_IRI.parse _namespace_name "copyrightHolder" |> NamespacedName

    /// <summary>
    /// The year during which the claimed copyright for the CreativeWork was first asserted.
    /// <see href="http://schema.org/copyrightYear"></see></summary>
    let copyrightYear =
        Namespaced_IRI.parse _namespace_name "copyrightYear" |> NamespacedName

    /// <summary>
    /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    /// <see href="http://schema.org/countriesNotSupported"></see></summary>
    let countriesNotSupported =
        Namespaced_IRI.parse _namespace_name "countriesNotSupported" |> NamespacedName

    /// <summary>
    /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    /// <see href="http://schema.org/countriesSupported"></see></summary>
    let countriesSupported =
        Namespaced_IRI.parse _namespace_name "countriesSupported" |> NamespacedName

    /// <summary>
    /// The country of the principal offices of the production company or individual responsible for the movie or program.
    /// <see href="http://schema.org/countryOfOrigin"></see></summary>
    let countryOfOrigin =
        Namespaced_IRI.parse _namespace_name "countryOfOrigin" |> NamespacedName

    /// <summary>
    /// A sub property of location. The course where this action was taken.
    /// <see href="http://schema.org/course"></see></summary>
    let course = Namespaced_IRI.parse _namespace_name "course" |> NamespacedName

    /// <summary>
    /// A sub property of location. The course where this action was taken.
    /// <see href="http://schema.org/exerciseCourse"></see></summary>
    let exerciseCourse =
        Namespaced_IRI.parse _namespace_name "exerciseCourse" |> NamespacedName

    /// <summary>
    /// The location of for example where the event is happening, an organization is located, or where an action takes place.
    /// <see href="http://schema.org/location"></see></summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    /// The identifier for the &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; used by the course &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; (e.g. CS101 or 6.001).
    /// <see href="http://schema.org/courseCode"></see></summary>
    let courseCode = Namespaced_IRI.parse _namespace_name "courseCode" |> NamespacedName
    /// <summary>
    /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
    /// <see href="http://schema.org/courseMode"></see></summary>
    let courseMode = Namespaced_IRI.parse _namespace_name "courseMode" |> NamespacedName

    /// <summary>
    /// Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.
    /// <see href="http://schema.org/coursePrerequisites"></see></summary>
    let coursePrerequisites =
        Namespaced_IRI.parse _namespace_name "coursePrerequisites" |> NamespacedName

    /// <summary>
    /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
    /// <see href="http://schema.org/coverageEndTime"></see></summary>
    let coverageEndTime =
        Namespaced_IRI.parse _namespace_name "coverageEndTime" |> NamespacedName

    /// <summary>
    /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
    /// <see href="http://schema.org/coverageStartTime"></see></summary>
    let coverageStartTime =
        Namespaced_IRI.parse _namespace_name "coverageStartTime" |> NamespacedName

    /// <summary>
    /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
    /// <see href="http://schema.org/creator"></see></summary>
    let creator = Namespaced_IRI.parse _namespace_name "creator" |> NamespacedName
    /// <summary>
    /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
    /// <see href="http://schema.org/creditedTo"></see></summary>
    let creditedTo = Namespaced_IRI.parse _namespace_name "creditedTo" |> NamespacedName

    /// <summary>
    /// A CSS selector, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
    /// <see href="http://schema.org/cssSelector"></see></summary>
    let cssSelector =
        Namespaced_IRI.parse _namespace_name "cssSelector" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/CssSelectorType"></see>
    /// </summary>
    let CssSelectorType =
        Namespaced_IRI.parse _namespace_name "CssSelectorType" |> NamespacedName

    /// <summary>
    /// The currency accepted.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
    /// <see href="http://schema.org/currenciesAccepted"></see></summary>
    let currenciesAccepted =
        Namespaced_IRI.parse _namespace_name "currenciesAccepted" |> NamespacedName

    /// <summary>
    /// The currency in which the monetary amount is expressed.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
    /// <see href="http://schema.org/currency"></see></summary>
    let currency = Namespaced_IRI.parse _namespace_name "currency" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/ExchangeRateSpecification"></see>
    /// </summary>
    let ExchangeRateSpecification =
        Namespaced_IRI.parse _namespace_name "ExchangeRateSpecification" |> NamespacedName

    /// <summary>
    /// Party placing the order or paying the invoice.
    /// <see href="http://schema.org/customer"></see></summary>
    let customer = Namespaced_IRI.parse _namespace_name "customer" |> NamespacedName

    /// <summary>
    /// An item within in a data feed. Data feeds may have many elements.
    /// <see href="http://schema.org/dataFeedElement"></see></summary>
    let dataFeedElement =
        Namespaced_IRI.parse _namespace_name "dataFeedElement" |> NamespacedName

    /// <summary>
    /// A dataset contained in this catalog.
    /// <see href="http://schema.org/dataset"></see></summary>
    let dataset = Namespaced_IRI.parse _namespace_name "dataset" |> NamespacedName

    /// <summary>
    /// The range of temporal applicability of a dataset, e.g. for a 2011 census dataset, the year 2011 (in ISO 8601 time interval format).
    /// <see href="http://schema.org/datasetTimeInterval"></see></summary>
    let datasetTimeInterval =
        Namespaced_IRI.parse _namespace_name "datasetTimeInterval" |> NamespacedName

    /// <summary>
    /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
    ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
    ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".&lt;br/&gt;&lt;br/&gt;
    ///
    /// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated.
    /// <see href="http://schema.org/temporalCoverage"></see></summary>
    let temporalCoverage =
        Namespaced_IRI.parse _namespace_name "temporalCoverage" |> NamespacedName

    /// <summary>
    /// The date on which the CreativeWork was created or the item was added to a DataFeed.
    /// <see href="http://schema.org/dateCreated"></see></summary>
    let dateCreated =
        Namespaced_IRI.parse _namespace_name "dateCreated" |> NamespacedName

    /// <summary>
    /// The datetime the item was removed from the DataFeed.
    /// <see href="http://schema.org/dateDeleted"></see></summary>
    let dateDeleted =
        Namespaced_IRI.parse _namespace_name "dateDeleted" |> NamespacedName

    /// <summary>
    /// The date the ticket was issued.
    /// <see href="http://schema.org/dateIssued"></see></summary>
    let dateIssued = Namespaced_IRI.parse _namespace_name "dateIssued" |> NamespacedName

    /// <summary>
    /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
    /// <see href="http://schema.org/dateModified"></see></summary>
    let dateModified =
        Namespaced_IRI.parse _namespace_name "dateModified" |> NamespacedName

    /// <summary>
    /// Publication date of an online listing.
    /// <see href="http://schema.org/datePosted"></see></summary>
    let datePosted = Namespaced_IRI.parse _namespace_name "datePosted" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/RealEstateListing"></see>
    /// </summary>
    let RealEstateListing =
        Namespaced_IRI.parse _namespace_name "RealEstateListing" |> NamespacedName

    /// <summary>
    /// Date of first broadcast/publication.
    /// <see href="http://schema.org/datePublished"></see></summary>
    let datePublished =
        Namespaced_IRI.parse _namespace_name "datePublished" |> NamespacedName

    /// <summary>
    /// The date/time at which the message has been read by the recipient if a single recipient exists.
    /// <see href="http://schema.org/dateRead"></see></summary>
    let dateRead = Namespaced_IRI.parse _namespace_name "dateRead" |> NamespacedName

    /// <summary>
    /// The date/time the message was received if a single recipient exists.
    /// <see href="http://schema.org/dateReceived"></see></summary>
    let dateReceived =
        Namespaced_IRI.parse _namespace_name "dateReceived" |> NamespacedName

    /// <summary>
    /// The date/time at which the message was sent.
    /// <see href="http://schema.org/dateSent"></see></summary>
    let dateSent = Namespaced_IRI.parse _namespace_name "dateSent" |> NamespacedName

    /// <summary>
    /// The date of the first registration of the vehicle with the respective public authorities.
    /// <see href="http://schema.org/dateVehicleFirstRegistered"></see></summary>
    let dateVehicleFirstRegistered =
        Namespaced_IRI.parse _namespace_name "dateVehicleFirstRegistered" |> NamespacedName

    /// <summary>
    /// A &lt;a href="https://en.wikipedia.org/wiki/Dateline"&gt;dateline&lt;/a&gt; is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Structured representations of dateline-related information can also be expressed more explicitly using &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt; (which represents where a work was created e.g. where a news report was written).  For location depicted or described in the content, use &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Dateline summaries are oriented more towards human readers than towards automated processing, and can vary substantially. Some examples: "BEIRUT, Lebanon, June 2.", "Paris, France", "December 19, 2017 11:43AM Reporting from Washington", "Beijing/Moscow", "QUEZON CITY, Philippines".
    /// <see href="http://schema.org/dateline"></see></summary>
    let dateline = Namespaced_IRI.parse _namespace_name "dateline" |> NamespacedName
    /// <summary>
    /// The day of the week for which these opening hours are valid.
    /// <see href="http://schema.org/dayOfWeek"></see></summary>
    let dayOfWeek = Namespaced_IRI.parse _namespace_name "dayOfWeek" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/EducationalOccupationalProgram"></see>
    /// </summary>
    let EducationalOccupationalProgram =
        Namespaced_IRI.parse _namespace_name "EducationalOccupationalProgram" |> NamespacedName

    /// <summary>
    /// Date of death.
    /// <see href="http://schema.org/deathDate"></see></summary>
    let deathDate = Namespaced_IRI.parse _namespace_name "deathDate" |> NamespacedName
    /// <summary>
    /// The place where the person died.
    /// <see href="http://schema.org/deathPlace"></see></summary>
    let deathPlace = Namespaced_IRI.parse _namespace_name "deathPlace" |> NamespacedName

    /// <summary>
    /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
    /// <see href="http://schema.org/defaultValue"></see></summary>
    let defaultValue =
        Namespaced_IRI.parse _namespace_name "defaultValue" |> NamespacedName

    /// <summary>
    /// Destination address.
    /// <see href="http://schema.org/deliveryAddress"></see></summary>
    let deliveryAddress =
        Namespaced_IRI.parse _namespace_name "deliveryAddress" |> NamespacedName

    /// <summary>
    /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
    /// <see href="http://schema.org/deliveryLeadTime"></see></summary>
    let deliveryLeadTime =
        Namespaced_IRI.parse _namespace_name "deliveryLeadTime" |> NamespacedName

    /// <summary>
    /// A sub property of instrument. The method of delivery.
    /// <see href="http://schema.org/deliveryMethod"></see></summary>
    let deliveryMethod =
        Namespaced_IRI.parse _namespace_name "deliveryMethod" |> NamespacedName

    /// <summary>
    /// The object that helped the agent perform the action. e.g. John wrote a book with &lt;em&gt;a pen&lt;/em&gt;.
    /// <see href="http://schema.org/instrument"></see></summary>
    let instrument = Namespaced_IRI.parse _namespace_name "instrument" |> NamespacedName

    /// <summary>
    /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
    /// <see href="http://schema.org/deliveryStatus"></see></summary>
    let deliveryStatus =
        Namespaced_IRI.parse _namespace_name "deliveryStatus" |> NamespacedName

    /// <summary>
    /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
    /// <see href="http://schema.org/department"></see></summary>
    let department = Namespaced_IRI.parse _namespace_name "department" |> NamespacedName

    /// <summary>
    /// The airport where the flight originates.
    /// <see href="http://schema.org/departureAirport"></see></summary>
    let departureAirport =
        Namespaced_IRI.parse _namespace_name "departureAirport" |> NamespacedName

    /// <summary>
    /// The stop or station from which the bus departs.
    /// <see href="http://schema.org/departureBusStop"></see></summary>
    let departureBusStop =
        Namespaced_IRI.parse _namespace_name "departureBusStop" |> NamespacedName

    /// <summary>
    /// Identifier of the flight's departure gate.
    /// <see href="http://schema.org/departureGate"></see></summary>
    let departureGate =
        Namespaced_IRI.parse _namespace_name "departureGate" |> NamespacedName

    /// <summary>
    /// The platform from which the train departs.
    /// <see href="http://schema.org/departurePlatform"></see></summary>
    let departurePlatform =
        Namespaced_IRI.parse _namespace_name "departurePlatform" |> NamespacedName

    /// <summary>
    /// The station from which the train departs.
    /// <see href="http://schema.org/departureStation"></see></summary>
    let departureStation =
        Namespaced_IRI.parse _namespace_name "departureStation" |> NamespacedName

    /// <summary>
    /// Identifier of the flight's departure terminal.
    /// <see href="http://schema.org/departureTerminal"></see></summary>
    let departureTerminal =
        Namespaced_IRI.parse _namespace_name "departureTerminal" |> NamespacedName

    /// <summary>
    /// The expected departure time.
    /// <see href="http://schema.org/departureTime"></see></summary>
    let departureTime =
        Namespaced_IRI.parse _namespace_name "departureTime" |> NamespacedName

    /// <summary>
    /// Prerequisites needed to fulfill steps in article.
    /// <see href="http://schema.org/dependencies"></see></summary>
    let dependencies =
        Namespaced_IRI.parse _namespace_name "dependencies" |> NamespacedName

    /// <summary>
    /// The depth of the item.
    /// <see href="http://schema.org/depth"></see></summary>
    let depth = Namespaced_IRI.parse _namespace_name "depth" |> NamespacedName

    /// <summary>
    /// A description of the item.
    /// <see href="http://schema.org/description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
    /// <see href="http://schema.org/device"></see></summary>
    let device = Namespaced_IRI.parse _namespace_name "device" |> NamespacedName
    /// <summary>
    /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
    /// <see href="http://schema.org/director"></see></summary>
    let director = Namespaced_IRI.parse _namespace_name "director" |> NamespacedName
    /// <summary>
    /// A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip.
    /// <see href="http://schema.org/directors"></see></summary>
    let directors = Namespaced_IRI.parse _namespace_name "directors" |> NamespacedName

    /// <summary>
    /// A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
    /// <see href="http://schema.org/disambiguatingDescription"></see></summary>
    let disambiguatingDescription =
        Namespaced_IRI.parse _namespace_name "disambiguatingDescription" |> NamespacedName

    /// <summary>
    /// Any discount applied (to an Order).
    /// <see href="http://schema.org/discount"></see></summary>
    let discount = Namespaced_IRI.parse _namespace_name "discount" |> NamespacedName

    /// <summary>
    /// Code used to redeem a discount.
    /// <see href="http://schema.org/discountCode"></see></summary>
    let discountCode =
        Namespaced_IRI.parse _namespace_name "discountCode" |> NamespacedName

    /// <summary>
    /// The currency of the discount.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
    /// <see href="http://schema.org/discountCurrency"></see></summary>
    let discountCurrency =
        Namespaced_IRI.parse _namespace_name "discountCurrency" |> NamespacedName

    /// <summary>
    /// Specifies the CreativeWork associated with the UserComment.
    /// <see href="http://schema.org/discusses"></see></summary>
    let discusses = Namespaced_IRI.parse _namespace_name "discusses" |> NamespacedName

    /// <summary>
    /// A link to the page containing the comments of the CreativeWork.
    /// <see href="http://schema.org/discussionUrl"></see></summary>
    let discussionUrl =
        Namespaced_IRI.parse _namespace_name "discussionUrl" |> NamespacedName

    /// <summary>
    /// The date that this organization was dissolved.
    /// <see href="http://schema.org/dissolutionDate"></see></summary>
    let dissolutionDate =
        Namespaced_IRI.parse _namespace_name "dissolutionDate" |> NamespacedName

    /// <summary>
    /// The distance travelled, e.g. exercising or travelling.
    /// <see href="http://schema.org/distance"></see></summary>
    let distance = Namespaced_IRI.parse _namespace_name "distance" |> NamespacedName

    /// <summary>
    /// A downloadable form of this dataset, at a specific location, in a specific format.
    /// <see href="http://schema.org/distribution"></see></summary>
    let distribution =
        Namespaced_IRI.parse _namespace_name "distribution" |> NamespacedName

    /// <summary>
    /// The time admission will commence.
    /// <see href="http://schema.org/doorTime"></see></summary>
    let doorTime = Namespaced_IRI.parse _namespace_name "doorTime" |> NamespacedName

    /// <summary>
    /// If the file can be downloaded, URL to download the binary.
    /// <see href="http://schema.org/downloadUrl"></see></summary>
    let downloadUrl =
        Namespaced_IRI.parse _namespace_name "downloadUrl" |> NamespacedName

    /// <summary>
    /// The number of downvotes this question, answer or comment has received from the community.
    /// <see href="http://schema.org/downvoteCount"></see></summary>
    let downvoteCount =
        Namespaced_IRI.parse _namespace_name "downvoteCount" |> NamespacedName

    /// <summary>
    /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
    /// <see href="http://schema.org/driveWheelConfiguration"></see></summary>
    let driveWheelConfiguration =
        Namespaced_IRI.parse _namespace_name "driveWheelConfiguration" |> NamespacedName

    /// <summary>
    /// Where a rental car can be dropped off.
    /// <see href="http://schema.org/dropoffLocation"></see></summary>
    let dropoffLocation =
        Namespaced_IRI.parse _namespace_name "dropoffLocation" |> NamespacedName

    /// <summary>
    /// When a rental car can be dropped off.
    /// <see href="http://schema.org/dropoffTime"></see></summary>
    let dropoffTime =
        Namespaced_IRI.parse _namespace_name "dropoffTime" |> NamespacedName

    /// <summary>
    /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
    /// <see href="http://schema.org/duns"></see></summary>
    let duns = Namespaced_IRI.parse _namespace_name "duns" |> NamespacedName
    /// <summary>
    /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
    /// <see href="http://schema.org/duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    ///   <see href="http://schema.org/Audiobook"></see>
    /// </summary>
    let Audiobook = Namespaced_IRI.parse _namespace_name "Audiobook" |> NamespacedName
    /// <summary>
    ///   <see href="http://schema.org/Schedule"></see>
    /// </summary>
    let Schedule = Namespaced_IRI.parse _namespace_name "Schedule" |> NamespacedName

    /// <summary>
    /// The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.
    /// <see href="http://schema.org/durationOfWarranty"></see></summary>
    let durationOfWarranty =
        Namespaced_IRI.parse _namespace_name "durationOfWarranty" |> NamespacedName

    /// <summary>
    /// A media object representing the circumstances while performing this direction.
    /// <see href="http://schema.org/duringMedia"></see></summary>
    let duringMedia =
        Namespaced_IRI.parse _namespace_name "duringMedia" |> NamespacedName

    /// <summary>
    /// Specifies the Person who edited the CreativeWork.
    /// <see href="http://schema.org/editor"></see></summary>
    let editor = Namespaced_IRI.parse _namespace_name "editor" |> NamespacedName

    /// <summary>
    /// An alignment to an established educational framework.
    /// <see href="http://schema.org/educationalAlignment"></see></summary>
    let educationalAlignment =
        Namespaced_IRI.parse _namespace_name "educationalAlignment" |> NamespacedName

    /// <summary>
    /// A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course or program.
    /// <see href="http://schema.org/educationalCredentialAwarded"></see></summary>
    let educationalCredentialAwarded =
        Namespaced_IRI.parse _namespace_name "educationalCredentialAwarded" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/EducationalOccupationalCredential"></see>
    /// </summary>
    let EducationalOccupationalCredential =
        Namespaced_IRI.parse _namespace_name "EducationalOccupationalCredential" |> NamespacedName

    /// <summary>
    /// The framework to which the resource being described is aligned.
    /// <see href="http://schema.org/educationalFramework"></see></summary>
    let educationalFramework =
        Namespaced_IRI.parse _namespace_name "educationalFramework" |> NamespacedName

    /// <summary>
    /// An educationalRole of an EducationalAudience.
    /// <see href="http://schema.org/educationalRole"></see></summary>
    let educationalRole =
        Namespaced_IRI.parse _namespace_name "educationalRole" |> NamespacedName

    /// <summary>
    /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
    /// <see href="http://schema.org/educationalUse"></see></summary>
    let educationalUse =
        Namespaced_IRI.parse _namespace_name "educationalUse" |> NamespacedName

    /// <summary>
    /// The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
    /// <see href="http://schema.org/elevation"></see></summary>
    let elevation = Namespaced_IRI.parse _namespace_name "elevation" |> NamespacedName

    /// <summary>
    /// The type(s) of customers for which the given offer is valid.
    /// <see href="http://schema.org/eligibleCustomerType"></see></summary>
    let eligibleCustomerType =
        Namespaced_IRI.parse _namespace_name "eligibleCustomerType" |> NamespacedName

    /// <summary>
    /// The duration for which the given offer is valid.
    /// <see href="http://schema.org/eligibleDuration"></see></summary>
    let eligibleDuration =
        Namespaced_IRI.parse _namespace_name "eligibleDuration" |> NamespacedName

    /// <summary>
    /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
    /// <see href="http://schema.org/eligibleQuantity"></see></summary>
    let eligibleQuantity =
        Namespaced_IRI.parse _namespace_name "eligibleQuantity" |> NamespacedName

    /// <summary>
    /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.
    /// <see href="http://schema.org/eligibleRegion"></see></summary>
    let eligibleRegion =
        Namespaced_IRI.parse _namespace_name "eligibleRegion" |> NamespacedName

    /// <summary>
    /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
    /// <see href="http://schema.org/eligibleTransactionVolume"></see></summary>
    let eligibleTransactionVolume =
        Namespaced_IRI.parse _namespace_name "eligibleTransactionVolume" |> NamespacedName

    /// <summary>
    /// Email address.
    /// <see href="http://schema.org/email"></see></summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName
    /// <summary>
    /// A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.
    /// <see href="http://schema.org/embedUrl"></see></summary>
    let embedUrl = Namespaced_IRI.parse _namespace_name "embedUrl" |> NamespacedName
    /// <summary>
    /// Someone working for this organization.
    /// <see href="http://schema.org/employee"></see></summary>
    let employee = Namespaced_IRI.parse _namespace_name "employee" |> NamespacedName
    /// <summary>
    /// People working for this organization.
    /// <see href="http://schema.org/employees"></see></summary>
    let employees = Namespaced_IRI.parse _namespace_name "employees" |> NamespacedName

    /// <summary>
    /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
    /// <see href="http://schema.org/employmentType"></see></summary>
    let employmentType =
        Namespaced_IRI.parse _namespace_name "employmentType" |> NamespacedName

    /// <summary>
    /// The CreativeWork encoded by this media object.
    /// <see href="http://schema.org/encodesCreativeWork"></see></summary>
    let encodesCreativeWork =
        Namespaced_IRI.parse _namespace_name "encodesCreativeWork" |> NamespacedName

    /// <summary>
    /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
    /// <see href="http://schema.org/encoding"></see></summary>
    let encoding = Namespaced_IRI.parse _namespace_name "encoding" |> NamespacedName

    /// <summary>
    /// Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
    ///
    /// In cases where a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="http://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="http://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
    /// <see href="http://schema.org/encodingFormat"></see></summary>
    let encodingFormat =
        Namespaced_IRI.parse _namespace_name "encodingFormat" |> NamespacedName

    /// <summary>
    /// The supported encoding type(s) for an EntryPoint request.
    /// <see href="http://schema.org/encodingType"></see></summary>
    let encodingType =
        Namespaced_IRI.parse _namespace_name "encodingType" |> NamespacedName

    /// <summary>
    /// A media object that encodes this CreativeWork.
    /// <see href="http://schema.org/encodings"></see></summary>
    let encodings = Namespaced_IRI.parse _namespace_name "encodings" |> NamespacedName
    /// <summary>
    /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
    /// <see href="http://schema.org/endDate"></see></summary>
    let endDate = Namespaced_IRI.parse _namespace_name "endDate" |> NamespacedName
    /// <summary>
    /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
    /// <see href="http://schema.org/endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName
    /// <summary>
    /// A sub property of participant. The person/organization being supported.
    /// <see href="http://schema.org/endorsee"></see></summary>
    let endorsee = Namespaced_IRI.parse _namespace_name "endorsee" |> NamespacedName

    /// <summary>
    /// A sub property of location. The entertainment business where the action occurred.
    /// <see href="http://schema.org/entertainmentBusiness"></see></summary>
    let entertainmentBusiness =
        Namespaced_IRI.parse _namespace_name "entertainmentBusiness" |> NamespacedName

    /// <summary>
    /// An episode of a tv, radio or game media within a series or season.
    /// <see href="http://schema.org/episode"></see></summary>
    let episode = Namespaced_IRI.parse _namespace_name "episode" |> NamespacedName

    /// <summary>
    /// Position of the episode within an ordered group of episodes.
    /// <see href="http://schema.org/episodeNumber"></see></summary>
    let episodeNumber =
        Namespaced_IRI.parse _namespace_name "episodeNumber" |> NamespacedName

    /// <summary>
    /// An episode of a TV/radio series or season.
    /// <see href="http://schema.org/episodes"></see></summary>
    let episodes = Namespaced_IRI.parse _namespace_name "episodes" |> NamespacedName
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is equal to the object.
    /// <see href="http://schema.org/equal"></see></summary>
    let equal = Namespaced_IRI.parse _namespace_name "equal" |> NamespacedName
    /// <summary>
    /// For failed actions, more information on the cause of the failure.
    /// <see href="http://schema.org/error"></see></summary>
    let error = Namespaced_IRI.parse _namespace_name "error" |> NamespacedName

    /// <summary>
    /// The estimated cost of the supply or supplies consumed when performing instructions.
    /// <see href="http://schema.org/estimatedCost"></see></summary>
    let estimatedCost =
        Namespaced_IRI.parse _namespace_name "estimatedCost" |> NamespacedName

    /// <summary>
    /// The estimated time the flight will take.
    /// <see href="http://schema.org/estimatedFlightDuration"></see></summary>
    let estimatedFlightDuration =
        Namespaced_IRI.parse _namespace_name "estimatedFlightDuration" |> NamespacedName

    /// <summary>
    /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
    /// <see href="http://schema.org/estimatedSalary"></see></summary>
    let estimatedSalary =
        Namespaced_IRI.parse _namespace_name "estimatedSalary" |> NamespacedName

    /// <summary>
    /// Upcoming or past event associated with this place, organization, or action.
    /// <see href="http://schema.org/event"></see></summary>
    let event_ = Namespaced_IRI.parse _namespace_name "event" |> NamespacedName

    /// <summary>
    /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
    /// <see href="http://schema.org/eventStatus"></see></summary>
    let eventStatus =
        Namespaced_IRI.parse _namespace_name "eventStatus" |> NamespacedName

    /// <summary>
    /// Upcoming or past events associated with this place or organization.
    /// <see href="http://schema.org/events"></see></summary>
    let events = Namespaced_IRI.parse _namespace_name "events" |> NamespacedName

    /// <summary>
    /// A creative work that this work is an example/instance/realization/derivation of.
    /// <see href="http://schema.org/exampleOfWork"></see></summary>
    let exampleOfWork =
        Namespaced_IRI.parse _namespace_name "exampleOfWork" |> NamespacedName

    /// <summary>
    /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
    /// <see href="http://schema.org/workExample"></see></summary>
    let workExample =
        Namespaced_IRI.parse _namespace_name "workExample" |> NamespacedName

    /// <summary>
    /// exif data for this object.
    /// <see href="http://schema.org/exifData"></see></summary>
    let exifData = Namespaced_IRI.parse _namespace_name "exifData" |> NamespacedName

    /// <summary>
    /// The earliest date the package may arrive.
    /// <see href="http://schema.org/expectedArrivalFrom"></see></summary>
    let expectedArrivalFrom =
        Namespaced_IRI.parse _namespace_name "expectedArrivalFrom" |> NamespacedName

    /// <summary>
    /// The latest date the package may arrive.
    /// <see href="http://schema.org/expectedArrivalUntil"></see></summary>
    let expectedArrivalUntil =
        Namespaced_IRI.parse _namespace_name "expectedArrivalUntil" |> NamespacedName

    /// <summary>
    /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
    /// <see href="http://schema.org/expectsAcceptanceOf"></see></summary>
    let expectsAcceptanceOf =
        Namespaced_IRI.parse _namespace_name "expectsAcceptanceOf" |> NamespacedName

    /// <summary>
    /// Description of skills and experience needed for the position or Occupation.
    /// <see href="http://schema.org/experienceRequirements"></see></summary>
    let experienceRequirements =
        Namespaced_IRI.parse _namespace_name "experienceRequirements" |> NamespacedName

    /// <summary>
    /// Date the content expires and is no longer useful or available. For example a &lt;a class="localLink" href="http://schema.org/VideoObject"&gt;VideoObject&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt; whose availability or relevance is time-limited, or a &lt;a class="localLink" href="http://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt; fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
    /// <see href="http://schema.org/expires"></see></summary>
    let expires = Namespaced_IRI.parse _namespace_name "expires" |> NamespacedName
    /// <summary>
    /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
    /// <see href="http://schema.org/familyName"></see></summary>
    let familyName = Namespaced_IRI.parse _namespace_name "familyName" |> NamespacedName
    /// <summary>
    /// The number of grams of fat.
    /// <see href="http://schema.org/fatContent"></see></summary>
    let fatContent = Namespaced_IRI.parse _namespace_name "fatContent" |> NamespacedName
    /// <summary>
    /// The fax number.
    /// <see href="http://schema.org/faxNumber"></see></summary>
    let faxNumber = Namespaced_IRI.parse _namespace_name "faxNumber" |> NamespacedName

    /// <summary>
    /// Features or modules provided by this application (and possibly required by other applications).
    /// <see href="http://schema.org/featureList"></see></summary>
    let featureList =
        Namespaced_IRI.parse _namespace_name "featureList" |> NamespacedName

    /// <summary>
    /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
    /// <see href="http://schema.org/feesAndCommissionsSpecification"></see></summary>
    let feesAndCommissionsSpecification =
        Namespaced_IRI.parse _namespace_name "feesAndCommissionsSpecification" |> NamespacedName

    /// <summary>
    /// The number of grams of fiber.
    /// <see href="http://schema.org/fiberContent"></see></summary>
    let fiberContent =
        Namespaced_IRI.parse _namespace_name "fiberContent" |> NamespacedName

    /// <summary>
    /// Media type, typically MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt;) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.
    /// <see href="http://schema.org/fileFormat"></see></summary>
    let fileFormat = Namespaced_IRI.parse _namespace_name "fileFormat" |> NamespacedName
    /// <summary>
    /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
    /// <see href="http://schema.org/fileSize"></see></summary>
    let fileSize = Namespaced_IRI.parse _namespace_name "fileSize" |> NamespacedName

    /// <summary>
    /// The date and place the work was first performed.
    /// <see href="http://schema.org/firstPerformance"></see></summary>
    let firstPerformance =
        Namespaced_IRI.parse _namespace_name "firstPerformance" |> NamespacedName

    /// <summary>
    /// The distance of the flight.
    /// <see href="http://schema.org/flightDistance"></see></summary>
    let flightDistance =
        Namespaced_IRI.parse _namespace_name "flightDistance" |> NamespacedName

    /// <summary>
    /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
    /// <see href="http://schema.org/flightNumber"></see></summary>
    let flightNumber =
        Namespaced_IRI.parse _namespace_name "flightNumber" |> NamespacedName

    /// <summary>
    /// The size of the accommodation, e.g. in square meter or squarefoot.
    /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
    /// <see href="http://schema.org/floorSize"></see></summary>
    let floorSize = Namespaced_IRI.parse _namespace_name "floorSize" |> NamespacedName
    /// <summary>
    /// A sub property of object. The person or organization being followed.
    /// <see href="http://schema.org/followee"></see></summary>
    let followee = Namespaced_IRI.parse _namespace_name "followee" |> NamespacedName
    /// <summary>
    /// The most generic uni-directional social relation.
    /// <see href="http://schema.org/follows"></see></summary>
    let follows = Namespaced_IRI.parse _namespace_name "follows" |> NamespacedName

    /// <summary>
    /// A sub property of location. The specific food establishment where the action occurred.
    /// <see href="http://schema.org/foodEstablishment"></see></summary>
    let foodEstablishment =
        Namespaced_IRI.parse _namespace_name "foodEstablishment" |> NamespacedName

    /// <summary>
    /// A sub property of location. The specific food event where the action occurred.
    /// <see href="http://schema.org/foodEvent"></see></summary>
    let foodEvent = Namespaced_IRI.parse _namespace_name "foodEvent" |> NamespacedName
    /// <summary>
    /// A person who founded this organization.
    /// <see href="http://schema.org/founder"></see></summary>
    let founder = Namespaced_IRI.parse _namespace_name "founder" |> NamespacedName
    /// <summary>
    /// A person who founded this organization.
    /// <see href="http://schema.org/founders"></see></summary>
    let founders = Namespaced_IRI.parse _namespace_name "founders" |> NamespacedName

    /// <summary>
    /// The date that this organization was founded.
    /// <see href="http://schema.org/foundingDate"></see></summary>
    let foundingDate =
        Namespaced_IRI.parse _namespace_name "foundingDate" |> NamespacedName

    /// <summary>
    /// The place where the Organization was founded.
    /// <see href="http://schema.org/foundingLocation"></see></summary>
    let foundingLocation =
        Namespaced_IRI.parse _namespace_name "foundingLocation" |> NamespacedName

    /// <summary>
    /// A flag to signal that the item, event, or place is accessible for free.
    /// <see href="http://schema.org/free"></see></summary>
    let free = Namespaced_IRI.parse _namespace_name "free" |> NamespacedName

    /// <summary>
    /// A flag to signal that the item, event, or place is accessible for free.
    /// <see href="http://schema.org/isAccessibleForFree"></see></summary>
    let isAccessibleForFree =
        Namespaced_IRI.parse _namespace_name "isAccessibleForFree" |> NamespacedName

    /// <summary>
    /// A sub property of location. The original location of the object or the agent before the action.
    /// <see href="http://schema.org/fromLocation"></see></summary>
    let fromLocation =
        Namespaced_IRI.parse _namespace_name "fromLocation" |> NamespacedName

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
    let fuelConsumption =
        Namespaced_IRI.parse _namespace_name "fuelConsumption" |> NamespacedName

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
    let fuelEfficiency =
        Namespaced_IRI.parse _namespace_name "fuelEfficiency" |> NamespacedName

    /// <summary>
    /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
    /// <see href="http://schema.org/fuelType"></see></summary>
    let fuelType = Namespaced_IRI.parse _namespace_name "fuelType" |> NamespacedName
    /// <summary>
    /// A person or organization that supports (sponsors) something through some kind of financial contribution.
    /// <see href="http://schema.org/funder"></see></summary>
    let funder = Namespaced_IRI.parse _namespace_name "funder" |> NamespacedName
    /// <summary>
    /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
    /// <see href="http://schema.org/sponsor"></see></summary>
    let sponsor = Namespaced_IRI.parse _namespace_name "sponsor" |> NamespacedName
    /// <summary>
    /// Video game which is played on this server.
    /// <see href="http://schema.org/game"></see></summary>
    let game = Namespaced_IRI.parse _namespace_name "game" |> NamespacedName
    /// <summary>
    /// The server on which  it is possible to play the game.
    /// <see href="http://schema.org/gameServer"></see></summary>
    let gameServer = Namespaced_IRI.parse _namespace_name "gameServer" |> NamespacedName
    /// <summary>
    /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
    /// <see href="http://schema.org/gameItem"></see></summary>
    let gameItem = Namespaced_IRI.parse _namespace_name "gameItem" |> NamespacedName

    /// <summary>
    /// Real or fictional location of the game (or part of game).
    /// <see href="http://schema.org/gameLocation"></see></summary>
    let gameLocation =
        Namespaced_IRI.parse _namespace_name "gameLocation" |> NamespacedName

    /// <summary>
    /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
    /// <see href="http://schema.org/gamePlatform"></see></summary>
    let gamePlatform =
        Namespaced_IRI.parse _namespace_name "gamePlatform" |> NamespacedName

    /// <summary>
    /// Links to tips, tactics, etc.
    /// <see href="http://schema.org/gameTip"></see></summary>
    let gameTip = Namespaced_IRI.parse _namespace_name "gameTip" |> NamespacedName
    /// <summary>
    /// Genre of the creative work, broadcast channel or group.
    /// <see href="http://schema.org/genre"></see></summary>
    let genre = Namespaced_IRI.parse _namespace_name "genre" |> NamespacedName
    /// <summary>
    /// The geo coordinates of the place.
    /// <see href="http://schema.org/geo"></see></summary>
    let geo = Namespaced_IRI.parse _namespace_name "geo" |> NamespacedName

    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoContains"></see></summary>
    let geoContains =
        Namespaced_IRI.parse _namespace_name "geoContains" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/GeospatialGeometry"></see>
    /// </summary>
    let GeospatialGeometry =
        Namespaced_IRI.parse _namespace_name "GeospatialGeometry" |> NamespacedName

    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoCoveredBy"></see></summary>
    let geoCoveredBy =
        Namespaced_IRI.parse _namespace_name "geoCoveredBy" |> NamespacedName

    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoCovers"></see></summary>
    let geoCovers = Namespaced_IRI.parse _namespace_name "geoCovers" |> NamespacedName
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoCrosses"></see></summary>
    let geoCrosses = Namespaced_IRI.parse _namespace_name "geoCrosses" |> NamespacedName

    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
    /// <see href="http://schema.org/geoDisjoint"></see></summary>
    let geoDisjoint =
        Namespaced_IRI.parse _namespace_name "geoDisjoint" |> NamespacedName

    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
    /// <see href="http://schema.org/geoEquals"></see></summary>
    let geoEquals = Namespaced_IRI.parse _namespace_name "geoEquals" |> NamespacedName

    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoIntersects"></see></summary>
    let geoIntersects =
        Namespaced_IRI.parse _namespace_name "geoIntersects" |> NamespacedName

    /// <summary>
    /// Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.
    /// <see href="http://schema.org/geoMidpoint"></see></summary>
    let geoMidpoint =
        Namespaced_IRI.parse _namespace_name "geoMidpoint" |> NamespacedName

    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoOverlaps"></see></summary>
    let geoOverlaps =
        Namespaced_IRI.parse _namespace_name "geoOverlaps" |> NamespacedName

    /// <summary>
    /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
    /// <see href="http://schema.org/geoRadius"></see></summary>
    let geoRadius = Namespaced_IRI.parse _namespace_name "geoRadius" |> NamespacedName
    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
    /// <see href="http://schema.org/geoTouches"></see></summary>
    let geoTouches = Namespaced_IRI.parse _namespace_name "geoTouches" |> NamespacedName
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
    /// <see href="http://schema.org/geoWithin"></see></summary>
    let geoWithin = Namespaced_IRI.parse _namespace_name "geoWithin" |> NamespacedName

    /// <summary>
    /// The geographic area associated with the audience.
    /// <see href="http://schema.org/geographicArea"></see></summary>
    let geographicArea =
        Namespaced_IRI.parse _namespace_name "geographicArea" |> NamespacedName

    /// <summary>
    /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
    /// <see href="http://schema.org/givenName"></see></summary>
    let givenName = Namespaced_IRI.parse _namespace_name "givenName" |> NamespacedName

    /// <summary>
    /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
    /// <see href="http://schema.org/globalLocationNumber"></see></summary>
    let globalLocationNumber =
        Namespaced_IRI.parse _namespace_name "globalLocationNumber" |> NamespacedName

    /// <summary>
    /// The person, organization, contact point, or audience that has been granted this permission.
    /// <see href="http://schema.org/grantee"></see></summary>
    let grantee = Namespaced_IRI.parse _namespace_name "grantee" |> NamespacedName
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is greater than the object.
    /// <see href="http://schema.org/greater"></see></summary>
    let greater = Namespaced_IRI.parse _namespace_name "greater" |> NamespacedName

    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.
    /// <see href="http://schema.org/greaterOrEqual"></see></summary>
    let greaterOrEqual =
        Namespaced_IRI.parse _namespace_name "greaterOrEqual" |> NamespacedName

    /// <summary>
    /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
    /// <see href="http://schema.org/gtin12"></see></summary>
    let gtin12 = Namespaced_IRI.parse _namespace_name "gtin12" |> NamespacedName
    /// <summary>
    ///   <see href="http://schema.org/gtin"></see>
    /// </summary>
    let gtin = Namespaced_IRI.parse _namespace_name "gtin" |> NamespacedName
    /// <summary>
    /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
    /// <see href="http://schema.org/gtin13"></see></summary>
    let gtin13 = Namespaced_IRI.parse _namespace_name "gtin13" |> NamespacedName
    /// <summary>
    /// The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
    /// <see href="http://schema.org/gtin14"></see></summary>
    let gtin14 = Namespaced_IRI.parse _namespace_name "gtin14" |> NamespacedName
    /// <summary>
    /// The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.
    /// <see href="http://schema.org/gtin8"></see></summary>
    let gtin8 = Namespaced_IRI.parse _namespace_name "gtin8" |> NamespacedName

    /// <summary>
    /// A broadcast channel of a broadcast service.
    /// <see href="http://schema.org/hasBroadcastChannel"></see></summary>
    let hasBroadcastChannel =
        Namespaced_IRI.parse _namespace_name "hasBroadcastChannel" |> NamespacedName

    /// <summary>
    /// The BroadcastService offered on this channel.
    /// <see href="http://schema.org/providesBroadcastService"></see></summary>
    let providesBroadcastService =
        Namespaced_IRI.parse _namespace_name "providesBroadcastService" |> NamespacedName

    /// <summary>
    /// An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
    /// <see href="http://schema.org/hasCourseInstance"></see></summary>
    let hasCourseInstance =
        Namespaced_IRI.parse _namespace_name "hasCourseInstance" |> NamespacedName

    /// <summary>
    /// Method used for delivery or shipping.
    /// <see href="http://schema.org/hasDeliveryMethod"></see></summary>
    let hasDeliveryMethod =
        Namespaced_IRI.parse _namespace_name "hasDeliveryMethod" |> NamespacedName

    /// <summary>
    /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
    /// <see href="http://schema.org/hasDigitalDocumentPermission"></see></summary>
    let hasDigitalDocumentPermission =
        Namespaced_IRI.parse _namespace_name "hasDigitalDocumentPermission" |> NamespacedName

    /// <summary>
    /// A URL to a map of the place.
    /// <see href="http://schema.org/hasMap"></see></summary>
    let hasMap = Namespaced_IRI.parse _namespace_name "hasMap" |> NamespacedName
    /// <summary>
    /// Either the actual menu as a structured representation, as text, or a URL of the menu.
    /// <see href="http://schema.org/hasMenu"></see></summary>
    let hasMenu = Namespaced_IRI.parse _namespace_name "hasMenu" |> NamespacedName

    /// <summary>
    /// A food or drink item contained in a menu or menu section.
    /// <see href="http://schema.org/hasMenuItem"></see></summary>
    let hasMenuItem =
        Namespaced_IRI.parse _namespace_name "hasMenuItem" |> NamespacedName

    /// <summary>
    /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
    /// <see href="http://schema.org/hasMenuSection"></see></summary>
    let hasMenuSection =
        Namespaced_IRI.parse _namespace_name "hasMenuSection" |> NamespacedName

    /// <summary>
    /// The Person's occupation. For past professions, use Role for expressing dates.
    /// <see href="http://schema.org/hasOccupation"></see></summary>
    let hasOccupation =
        Namespaced_IRI.parse _namespace_name "hasOccupation" |> NamespacedName

    /// <summary>
    /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
    /// <see href="http://schema.org/hasOfferCatalog"></see></summary>
    let hasOfferCatalog =
        Namespaced_IRI.parse _namespace_name "hasOfferCatalog" |> NamespacedName

    /// <summary>
    /// Points-of-Sales operated by the organization or person.
    /// <see href="http://schema.org/hasPOS"></see></summary>
    let hasPOS = Namespaced_IRI.parse _namespace_name "hasPOS" |> NamespacedName
    /// <summary>
    /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.
    /// <see href="http://schema.org/isPartOf"></see></summary>
    let isPartOf = Namespaced_IRI.parse _namespace_name "isPartOf" |> NamespacedName
    /// <summary>
    /// Headline of the article.
    /// <see href="http://schema.org/headline"></see></summary>
    let headline = Namespaced_IRI.parse _namespace_name "headline" |> NamespacedName
    /// <summary>
    /// The height of the item.
    /// <see href="http://schema.org/height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
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
    let highPrice = Namespaced_IRI.parse _namespace_name "highPrice" |> NamespacedName

    /// <summary>
    /// Organization offering the job position.
    /// <see href="http://schema.org/hiringOrganization"></see></summary>
    let hiringOrganization =
        Namespaced_IRI.parse _namespace_name "hiringOrganization" |> NamespacedName

    /// <summary>
    /// A contact location for a person's residence.
    /// <see href="http://schema.org/homeLocation"></see></summary>
    let homeLocation =
        Namespaced_IRI.parse _namespace_name "homeLocation" |> NamespacedName

    /// <summary>
    /// The home team in a sports event.
    /// <see href="http://schema.org/homeTeam"></see></summary>
    let homeTeam = Namespaced_IRI.parse _namespace_name "homeTeam" |> NamespacedName

    /// <summary>
    /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
    /// <see href="http://schema.org/honorificPrefix"></see></summary>
    let honorificPrefix =
        Namespaced_IRI.parse _namespace_name "honorificPrefix" |> NamespacedName

    /// <summary>
    /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
    /// <see href="http://schema.org/honorificSuffix"></see></summary>
    let honorificSuffix =
        Namespaced_IRI.parse _namespace_name "honorificSuffix" |> NamespacedName

    /// <summary>
    /// The organization (airline, travelers' club, etc.) the membership is made with.
    /// <see href="http://schema.org/hostingOrganization"></see></summary>
    let hostingOrganization =
        Namespaced_IRI.parse _namespace_name "hostingOrganization" |> NamespacedName

    /// <summary>
    /// The hours during which this service or contact is available.
    /// <see href="http://schema.org/hoursAvailable"></see></summary>
    let hoursAvailable =
        Namespaced_IRI.parse _namespace_name "hoursAvailable" |> NamespacedName

    /// <summary>
    /// An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.
    /// <see href="http://schema.org/httpMethod"></see></summary>
    let httpMethod = Namespaced_IRI.parse _namespace_name "httpMethod" |> NamespacedName
    /// <summary>
    /// IATA identifier for an airline or airport.
    /// <see href="http://schema.org/iataCode"></see></summary>
    let iataCode = Namespaced_IRI.parse _namespace_name "iataCode" |> NamespacedName
    /// <summary>
    /// ICAO identifier for an airport.
    /// <see href="http://schema.org/icaoCode"></see></summary>
    let icaoCode = Namespaced_IRI.parse _namespace_name "icaoCode" |> NamespacedName

    /// <summary>
    /// The illustrator of the book.
    /// <see href="http://schema.org/illustrator"></see></summary>
    let illustrator =
        Namespaced_IRI.parse _namespace_name "illustrator" |> NamespacedName

    /// <summary>
    /// An image of the item. This can be a &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt; or a fully described &lt;a class="localLink" href="http://schema.org/ImageObject"&gt;ImageObject&lt;/a&gt;.
    /// <see href="http://schema.org/image"></see></summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName
    /// <summary>
    /// The album to which this recording belongs.
    /// <see href="http://schema.org/inAlbum"></see></summary>
    let inAlbum = Namespaced_IRI.parse _namespace_name "inAlbum" |> NamespacedName

    /// <summary>
    /// The CableOrSatelliteService offering the channel.
    /// <see href="http://schema.org/inBroadcastLineup"></see></summary>
    let inBroadcastLineup =
        Namespaced_IRI.parse _namespace_name "inBroadcastLineup" |> NamespacedName

    /// <summary>
    /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
    /// <see href="http://schema.org/inLanguage"></see></summary>
    let inLanguage = Namespaced_IRI.parse _namespace_name "inLanguage" |> NamespacedName
    /// <summary>
    ///   <see href="http://schema.org/LinkRole"></see>
    /// </summary>
    let LinkRole = Namespaced_IRI.parse _namespace_name "LinkRole" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/PronounceableText"></see>
    /// </summary>
    let PronounceableText =
        Namespaced_IRI.parse _namespace_name "PronounceableText" |> NamespacedName

    /// <summary>
    /// The playlist to which this recording belongs.
    /// <see href="http://schema.org/inPlaylist"></see></summary>
    let inPlaylist = Namespaced_IRI.parse _namespace_name "inPlaylist" |> NamespacedName

    /// <summary>
    /// Description of bonus and commission compensation aspects of the job.
    /// <see href="http://schema.org/incentiveCompensation"></see></summary>
    let incentiveCompensation =
        Namespaced_IRI.parse _namespace_name "incentiveCompensation" |> NamespacedName

    /// <summary>
    /// Description of bonus and commission compensation aspects of the job.
    /// <see href="http://schema.org/incentives"></see></summary>
    let incentives = Namespaced_IRI.parse _namespace_name "incentives" |> NamespacedName

    /// <summary>
    /// Smaller compositions included in this work (e.g. a movement in a symphony).
    /// <see href="http://schema.org/includedComposition"></see></summary>
    let includedComposition =
        Namespaced_IRI.parse _namespace_name "includedComposition" |> NamespacedName

    /// <summary>
    /// A data catalog which contains this dataset (this property was previously 'catalog', preferred name is now 'includedInDataCatalog').
    /// <see href="http://schema.org/includedDataCatalog"></see></summary>
    let includedDataCatalog =
        Namespaced_IRI.parse _namespace_name "includedDataCatalog" |> NamespacedName

    /// <summary>
    /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
    /// <see href="http://schema.org/includesObject"></see></summary>
    let includesObject =
        Namespaced_IRI.parse _namespace_name "includesObject" |> NamespacedName

    /// <summary>
    /// The industry associated with the job position.
    /// <see href="http://schema.org/industry"></see></summary>
    let industry = Namespaced_IRI.parse _namespace_name "industry" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/DefinedTerm"></see>
    /// </summary>
    let DefinedTerm =
        Namespaced_IRI.parse _namespace_name "DefinedTerm" |> NamespacedName

    /// <summary>
    /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
    /// <see href="http://schema.org/ingredients"></see></summary>
    let ingredients =
        Namespaced_IRI.parse _namespace_name "ingredients" |> NamespacedName

    /// <summary>
    /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
    /// <see href="http://schema.org/recipeIngredient"></see></summary>
    let recipeIngredient =
        Namespaced_IRI.parse _namespace_name "recipeIngredient" |> NamespacedName

    /// <summary>
    /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
    /// <see href="http://schema.org/supply"></see></summary>
    let supply = Namespaced_IRI.parse _namespace_name "supply" |> NamespacedName
    /// <summary>
    /// URL at which the app may be installed, if different from the URL of the item.
    /// <see href="http://schema.org/installUrl"></see></summary>
    let installUrl = Namespaced_IRI.parse _namespace_name "installUrl" |> NamespacedName
    /// <summary>
    /// A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="http://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.
    /// <see href="http://schema.org/instructor"></see></summary>
    let instructor = Namespaced_IRI.parse _namespace_name "instructor" |> NamespacedName

    /// <summary>
    /// This property is deprecated, alongside the UserInteraction types on which it depended.
    /// <see href="http://schema.org/interactionCount"></see></summary>
    let interactionCount =
        Namespaced_IRI.parse _namespace_name "interactionCount" |> NamespacedName

    /// <summary>
    /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
    /// <see href="http://schema.org/interactionStatistic"></see></summary>
    let interactionStatistic =
        Namespaced_IRI.parse _namespace_name "interactionStatistic" |> NamespacedName

    /// <summary>
    /// The WebSite or SoftwareApplication where the interactions took place.
    /// <see href="http://schema.org/interactionService"></see></summary>
    let interactionService =
        Namespaced_IRI.parse _namespace_name "interactionService" |> NamespacedName

    /// <summary>
    /// The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="http://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="http://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.
    /// <see href="http://schema.org/interactionType"></see></summary>
    let interactionType =
        Namespaced_IRI.parse _namespace_name "interactionType" |> NamespacedName

    /// <summary>
    /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
    /// <see href="http://schema.org/interactivityType"></see></summary>
    let interactivityType =
        Namespaced_IRI.parse _namespace_name "interactivityType" |> NamespacedName

    /// <summary>
    /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
    /// <see href="http://schema.org/interestRate"></see></summary>
    let interestRate =
        Namespaced_IRI.parse _namespace_name "interestRate" |> NamespacedName

    /// <summary>
    /// The current approximate inventory level for the item or items.
    /// <see href="http://schema.org/inventoryLevel"></see></summary>
    let inventoryLevel =
        Namespaced_IRI.parse _namespace_name "inventoryLevel" |> NamespacedName

    /// <summary>
    /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
    /// <see href="http://schema.org/isAccessoryOrSparePartFor"></see></summary>
    let isAccessoryOrSparePartFor =
        Namespaced_IRI.parse _namespace_name "isAccessoryOrSparePartFor" |> NamespacedName

    /// <summary>
    /// A resource from which this work is derived or from which it is a modification or adaption.
    /// <see href="http://schema.org/isBasedOn"></see></summary>
    let isBasedOn = Namespaced_IRI.parse _namespace_name "isBasedOn" |> NamespacedName

    /// <summary>
    /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
    /// <see href="http://schema.org/isBasedOnUrl"></see></summary>
    let isBasedOnUrl =
        Namespaced_IRI.parse _namespace_name "isBasedOnUrl" |> NamespacedName

    /// <summary>
    /// A pointer to another product (or multiple products) for which this product is a consumable.
    /// <see href="http://schema.org/isConsumableFor"></see></summary>
    let isConsumableFor =
        Namespaced_IRI.parse _namespace_name "isConsumableFor" |> NamespacedName

    /// <summary>
    /// Indicates whether this content is family friendly.
    /// <see href="http://schema.org/isFamilyFriendly"></see></summary>
    let isFamilyFriendly =
        Namespaced_IRI.parse _namespace_name "isFamilyFriendly" |> NamespacedName

    /// <summary>
    /// Was the offer accepted as a gift for someone other than the buyer.
    /// <see href="http://schema.org/isGift"></see></summary>
    let isGift = Namespaced_IRI.parse _namespace_name "isGift" |> NamespacedName

    /// <summary>
    /// True is the broadcast is of a live event.
    /// <see href="http://schema.org/isLiveBroadcast"></see></summary>
    let isLiveBroadcast =
        Namespaced_IRI.parse _namespace_name "isLiveBroadcast" |> NamespacedName

    /// <summary>
    /// A pointer to another, somehow related product (or multiple products).
    /// <see href="http://schema.org/isRelatedTo"></see></summary>
    let isRelatedTo =
        Namespaced_IRI.parse _namespace_name "isRelatedTo" |> NamespacedName

    /// <summary>
    /// A pointer to another, functionally similar product (or multiple products).
    /// <see href="http://schema.org/isSimilarTo"></see></summary>
    let isSimilarTo =
        Namespaced_IRI.parse _namespace_name "isSimilarTo" |> NamespacedName

    /// <summary>
    /// A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.
    /// <see href="http://schema.org/isVariantOf"></see></summary>
    let isVariantOf =
        Namespaced_IRI.parse _namespace_name "isVariantOf" |> NamespacedName

    /// <summary>
    /// The ISBN of the book.
    /// <see href="http://schema.org/isbn"></see></summary>
    let isbn = Namespaced_IRI.parse _namespace_name "isbn" |> NamespacedName
    /// <summary>
    /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
    /// <see href="http://schema.org/isicV4"></see></summary>
    let isicV4 = Namespaced_IRI.parse _namespace_name "isicV4" |> NamespacedName
    /// <summary>
    /// The International Standard Recording Code for the recording.
    /// <see href="http://schema.org/isrcCode"></see></summary>
    let isrcCode = Namespaced_IRI.parse _namespace_name "isrcCode" |> NamespacedName
    /// <summary>
    /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
    /// <see href="http://schema.org/issn"></see></summary>
    let issn = Namespaced_IRI.parse _namespace_name "issn" |> NamespacedName

    /// <summary>
    /// Identifies the issue of publication; for example, "iii" or "2".
    /// <see href="http://schema.org/issueNumber"></see></summary>
    let issueNumber =
        Namespaced_IRI.parse _namespace_name "issueNumber" |> NamespacedName

    /// <summary>
    /// The organization issuing the ticket or permit.
    /// <see href="http://schema.org/issuedBy"></see></summary>
    let issuedBy = Namespaced_IRI.parse _namespace_name "issuedBy" |> NamespacedName

    /// <summary>
    /// The service through with the permit was granted.
    /// <see href="http://schema.org/issuedThrough"></see></summary>
    let issuedThrough =
        Namespaced_IRI.parse _namespace_name "issuedThrough" |> NamespacedName

    /// <summary>
    /// The International Standard Musical Work Code for the composition.
    /// <see href="http://schema.org/iswcCode"></see></summary>
    let iswcCode = Namespaced_IRI.parse _namespace_name "iswcCode" |> NamespacedName
    /// <summary>
    /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
    /// <see href="http://schema.org/item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName

    /// <summary>
    /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
    /// <see href="http://schema.org/itemCondition"></see></summary>
    let itemCondition =
        Namespaced_IRI.parse _namespace_name "itemCondition" |> NamespacedName

    /// <summary>
    /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
    /// <see href="http://schema.org/itemListElement"></see></summary>
    let itemListElement =
        Namespaced_IRI.parse _namespace_name "itemListElement" |> NamespacedName

    /// <summary>
    /// Type of ordering (e.g. Ascending, Descending, Unordered).
    /// <see href="http://schema.org/itemListOrder"></see></summary>
    let itemListOrder =
        Namespaced_IRI.parse _namespace_name "itemListOrder" |> NamespacedName

    /// <summary>
    /// An item being offered (or demanded). The transactional nature of the offer or demand is documented using &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt;, e.g. sell, lease etc. While several common expected types are listed explicitly in this definition, others can be used. Using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
    /// <see href="http://schema.org/itemOffered"></see></summary>
    let itemOffered =
        Namespaced_IRI.parse _namespace_name "itemOffered" |> NamespacedName

    /// <summary>
    /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="http://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
    /// <see href="http://schema.org/offers"></see></summary>
    let offers = Namespaced_IRI.parse _namespace_name "offers" |> NamespacedName

    /// <summary>
    /// The item that is being reviewed/rated.
    /// <see href="http://schema.org/itemReviewed"></see></summary>
    let itemReviewed =
        Namespaced_IRI.parse _namespace_name "itemReviewed" |> NamespacedName

    /// <summary>
    /// Item(s) being shipped.
    /// <see href="http://schema.org/itemShipped"></see></summary>
    let itemShipped =
        Namespaced_IRI.parse _namespace_name "itemShipped" |> NamespacedName

    /// <summary>
    /// A (typically single) geographic location associated with the job position.
    /// <see href="http://schema.org/jobLocation"></see></summary>
    let jobLocation =
        Namespaced_IRI.parse _namespace_name "jobLocation" |> NamespacedName

    /// <summary>
    /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
    /// <see href="http://schema.org/keywords"></see></summary>
    let keywords = Namespaced_IRI.parse _namespace_name "keywords" |> NamespacedName

    /// <summary>
    /// A textual description of known damages, both repaired and unrepaired.
    /// <see href="http://schema.org/knownVehicleDamages"></see></summary>
    let knownVehicleDamages =
        Namespaced_IRI.parse _namespace_name "knownVehicleDamages" |> NamespacedName

    /// <summary>
    /// The most generic bi-directional social/work relation.
    /// <see href="http://schema.org/knows"></see></summary>
    let knows = Namespaced_IRI.parse _namespace_name "knows" |> NamespacedName
    /// <summary>
    /// A sub property of participant. The owner of the real estate property.
    /// <see href="http://schema.org/landlord"></see></summary>
    let landlord = Namespaced_IRI.parse _namespace_name "landlord" |> NamespacedName
    /// <summary>
    /// A sub property of instrument. The language used on this action.
    /// <see href="http://schema.org/language"></see></summary>
    let language = Namespaced_IRI.parse _namespace_name "language" |> NamespacedName

    /// <summary>
    /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
    /// <see href="http://schema.org/lastReviewed"></see></summary>
    let lastReviewed =
        Namespaced_IRI.parse _namespace_name "lastReviewed" |> NamespacedName

    /// <summary>
    /// The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
    /// <see href="http://schema.org/latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName

    /// <summary>
    /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
    /// <see href="http://schema.org/learningResourceType"></see></summary>
    let learningResourceType =
        Namespaced_IRI.parse _namespace_name "learningResourceType" |> NamespacedName

    /// <summary>
    /// The official name of the organization, e.g. the registered company name.
    /// <see href="http://schema.org/legalName"></see></summary>
    let legalName = Namespaced_IRI.parse _namespace_name "legalName" |> NamespacedName
    /// <summary>
    /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
    /// <see href="http://schema.org/leiCode"></see></summary>
    let leiCode = Namespaced_IRI.parse _namespace_name "leiCode" |> NamespacedName
    /// <summary>
    /// A sub property of participant. The person that lends the object being borrowed.
    /// <see href="http://schema.org/lender"></see></summary>
    let lender = Namespaced_IRI.parse _namespace_name "lender" |> NamespacedName
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is lesser than the object.
    /// <see href="http://schema.org/lesser"></see></summary>
    let lesser = Namespaced_IRI.parse _namespace_name "lesser" |> NamespacedName

    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.
    /// <see href="http://schema.org/lesserOrEqual"></see></summary>
    let lesserOrEqual =
        Namespaced_IRI.parse _namespace_name "lesserOrEqual" |> NamespacedName

    /// <summary>
    /// A license document that applies to this content, typically indicated by URL.
    /// <see href="http://schema.org/license"></see></summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
    /// <see href="http://schema.org/line"></see></summary>
    let line = Namespaced_IRI.parse _namespace_name "line" |> NamespacedName

    /// <summary>
    /// An update to the LiveBlog.
    /// <see href="http://schema.org/liveBlogUpdate"></see></summary>
    let liveBlogUpdate =
        Namespaced_IRI.parse _namespace_name "liveBlogUpdate" |> NamespacedName

    /// <summary>
    /// The duration of the loan or credit agreement.
    /// <see href="http://schema.org/loanTerm"></see></summary>
    let loanTerm = Namespaced_IRI.parse _namespace_name "loanTerm" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/VirtualLocation"></see>
    /// </summary>
    let VirtualLocation =
        Namespaced_IRI.parse _namespace_name "VirtualLocation" |> NamespacedName

    /// <summary>
    /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
    /// <see href="http://schema.org/locationCreated"></see></summary>
    let locationCreated =
        Namespaced_IRI.parse _namespace_name "locationCreated" |> NamespacedName

    /// <summary>
    /// A full description of the lodging unit.
    /// <see href="http://schema.org/lodgingUnitDescription"></see></summary>
    let lodgingUnitDescription =
        Namespaced_IRI.parse _namespace_name "lodgingUnitDescription" |> NamespacedName

    /// <summary>
    /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
    /// <see href="http://schema.org/lodgingUnitType"></see></summary>
    let lodgingUnitType =
        Namespaced_IRI.parse _namespace_name "lodgingUnitType" |> NamespacedName

    /// <summary>
    /// An associated logo.
    /// <see href="http://schema.org/logo"></see></summary>
    let logo = Namespaced_IRI.parse _namespace_name "logo" |> NamespacedName
    /// <summary>
    /// The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).
    /// <see href="http://schema.org/longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName
    /// <summary>
    /// A sub property of participant. The loser of the action.
    /// <see href="http://schema.org/loser"></see></summary>
    let loser = Namespaced_IRI.parse _namespace_name "loser" |> NamespacedName
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
    let lowPrice = Namespaced_IRI.parse _namespace_name "lowPrice" |> NamespacedName
    /// <summary>
    /// The person who wrote the words.
    /// <see href="http://schema.org/lyricist"></see></summary>
    let lyricist = Namespaced_IRI.parse _namespace_name "lyricist" |> NamespacedName
    /// <summary>
    /// The words in the song.
    /// <see href="http://schema.org/lyrics"></see></summary>
    let lyrics = Namespaced_IRI.parse _namespace_name "lyrics" |> NamespacedName

    /// <summary>
    /// Indicates if this web page element is the main subject of the page.
    /// <see href="http://schema.org/mainContentOfPage"></see></summary>
    let mainContentOfPage =
        Namespaced_IRI.parse _namespace_name "mainContentOfPage" |> NamespacedName

    /// <summary>
    /// Indicates the primary entity described in some page or other CreativeWork.
    /// <see href="http://schema.org/mainEntity"></see></summary>
    let mainEntity = Namespaced_IRI.parse _namespace_name "mainEntity" |> NamespacedName

    /// <summary>
    /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See &lt;a href="/docs/datamodel.html#mainEntityBackground"&gt;background notes&lt;/a&gt; for details.
    /// <see href="http://schema.org/mainEntityOfPage"></see></summary>
    let mainEntityOfPage =
        Namespaced_IRI.parse _namespace_name "mainEntityOfPage" |> NamespacedName

    /// <summary>
    /// A pointer to products or services offered by the organization or person.
    /// <see href="http://schema.org/makesOffer"></see></summary>
    let makesOffer = Namespaced_IRI.parse _namespace_name "makesOffer" |> NamespacedName
    /// <summary>
    /// A pointer to the organization or person making the offer.
    /// <see href="http://schema.org/offeredBy"></see></summary>
    let offeredBy = Namespaced_IRI.parse _namespace_name "offeredBy" |> NamespacedName

    /// <summary>
    /// The manufacturer of the product.
    /// <see href="http://schema.org/manufacturer"></see></summary>
    let manufacturer =
        Namespaced_IRI.parse _namespace_name "manufacturer" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/DietarySupplement"></see>
    /// </summary>
    let DietarySupplement =
        Namespaced_IRI.parse _namespace_name "DietarySupplement" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/Drug"></see>
    /// </summary>
    let Drug = Namespaced_IRI.parse _namespace_name "Drug" |> NamespacedName
    /// <summary>
    /// A URL to a map of the place.
    /// <see href="http://schema.org/map"></see></summary>
    let map = Namespaced_IRI.parse _namespace_name "map" |> NamespacedName
    /// <summary>
    /// Indicates the kind of Map, from the MapCategoryType Enumeration.
    /// <see href="http://schema.org/mapType"></see></summary>
    let mapType = Namespaced_IRI.parse _namespace_name "mapType" |> NamespacedName
    /// <summary>
    /// A URL to a map of the place.
    /// <see href="http://schema.org/maps"></see></summary>
    let maps = Namespaced_IRI.parse _namespace_name "maps" |> NamespacedName
    /// <summary>
    /// The highest price if the price is a range.
    /// <see href="http://schema.org/maxPrice"></see></summary>
    let maxPrice = Namespaced_IRI.parse _namespace_name "maxPrice" |> NamespacedName
    /// <summary>
    /// The upper value of some characteristic or property.
    /// <see href="http://schema.org/maxValue"></see></summary>
    let maxValue = Namespaced_IRI.parse _namespace_name "maxValue" |> NamespacedName

    /// <summary>
    /// The total number of individuals that may attend an event or venue.
    /// <see href="http://schema.org/maximumAttendeeCapacity"></see></summary>
    let maximumAttendeeCapacity =
        Namespaced_IRI.parse _namespace_name "maximumAttendeeCapacity" |> NamespacedName

    /// <summary>
    /// Description of the meals that will be provided or available for purchase.
    /// <see href="http://schema.org/mealService"></see></summary>
    let mealService =
        Namespaced_IRI.parse _namespace_name "mealService" |> NamespacedName

    /// <summary>
    /// The median value.
    /// <see href="http://schema.org/median"></see></summary>
    let median = Namespaced_IRI.parse _namespace_name "median" |> NamespacedName
    /// <summary>
    /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
    /// <see href="http://schema.org/member"></see></summary>
    let member_ = Namespaced_IRI.parse _namespace_name "member" |> NamespacedName
    /// <summary>
    /// A member of this organization.
    /// <see href="http://schema.org/members"></see></summary>
    let members = Namespaced_IRI.parse _namespace_name "members" |> NamespacedName

    /// <summary>
    /// A unique identifier for the membership.
    /// <see href="http://schema.org/membershipNumber"></see></summary>
    let membershipNumber =
        Namespaced_IRI.parse _namespace_name "membershipNumber" |> NamespacedName

    /// <summary>
    /// Minimum memory requirements.
    /// <see href="http://schema.org/memoryRequirements"></see></summary>
    let memoryRequirements =
        Namespaced_IRI.parse _namespace_name "memoryRequirements" |> NamespacedName

    /// <summary>
    /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
    /// <see href="http://schema.org/mentions"></see></summary>
    let mentions = Namespaced_IRI.parse _namespace_name "mentions" |> NamespacedName
    /// <summary>
    /// Either the actual menu as a structured representation, as text, or a URL of the menu.
    /// <see href="http://schema.org/menu"></see></summary>
    let menu = Namespaced_IRI.parse _namespace_name "menu" |> NamespacedName
    /// <summary>
    /// Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.
    /// <see href="http://schema.org/menuAddOn"></see></summary>
    let menuAddOn = Namespaced_IRI.parse _namespace_name "menuAddOn" |> NamespacedName
    /// <summary>
    /// 'merchant' is an out-dated term for 'seller'.
    /// <see href="http://schema.org/merchant"></see></summary>
    let merchant = Namespaced_IRI.parse _namespace_name "merchant" |> NamespacedName
    /// <summary>
    /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
    /// <see href="http://schema.org/seller"></see></summary>
    let seller = Namespaced_IRI.parse _namespace_name "seller" |> NamespacedName

    /// <summary>
    /// A CreativeWork attached to the message.
    /// <see href="http://schema.org/messageAttachment"></see></summary>
    let messageAttachment =
        Namespaced_IRI.parse _namespace_name "messageAttachment" |> NamespacedName

    /// <summary>
    /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles
    /// <see href="http://schema.org/mileageFromOdometer"></see></summary>
    let mileageFromOdometer =
        Namespaced_IRI.parse _namespace_name "mileageFromOdometer" |> NamespacedName

    /// <summary>
    /// The lowest price if the price is a range.
    /// <see href="http://schema.org/minPrice"></see></summary>
    let minPrice = Namespaced_IRI.parse _namespace_name "minPrice" |> NamespacedName
    /// <summary>
    /// The lower value of some characteristic or property.
    /// <see href="http://schema.org/minValue"></see></summary>
    let minValue = Namespaced_IRI.parse _namespace_name "minValue" |> NamespacedName

    /// <summary>
    /// The minimum payment required at this time.
    /// <see href="http://schema.org/minimumPaymentDue"></see></summary>
    let minimumPaymentDue =
        Namespaced_IRI.parse _namespace_name "minimumPaymentDue" |> NamespacedName

    /// <summary>
    /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
    /// <see href="http://schema.org/model"></see></summary>
    let model = Namespaced_IRI.parse _namespace_name "model" |> NamespacedName

    /// <summary>
    /// The date and time the reservation was modified.
    /// <see href="http://schema.org/modifiedTime"></see></summary>
    let modifiedTime =
        Namespaced_IRI.parse _namespace_name "modifiedTime" |> NamespacedName

    /// <summary>
    /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
    /// <see href="http://schema.org/mpn"></see></summary>
    let mpn = Namespaced_IRI.parse _namespace_name "mpn" |> NamespacedName

    /// <summary>
    /// Whether multiple values are allowed for the property.  Default is false.
    /// <see href="http://schema.org/multipleValues"></see></summary>
    let multipleValues =
        Namespaced_IRI.parse _namespace_name "multipleValues" |> NamespacedName

    /// <summary>
    /// An arrangement derived from the composition.
    /// <see href="http://schema.org/musicArrangement"></see></summary>
    let musicArrangement =
        Namespaced_IRI.parse _namespace_name "musicArrangement" |> NamespacedName

    /// <summary>
    /// The composer of the soundtrack.
    /// <see href="http://schema.org/musicBy"></see></summary>
    let musicBy = Namespaced_IRI.parse _namespace_name "musicBy" |> NamespacedName

    /// <summary>
    /// The type of composition (e.g. overture, sonata, symphony, etc.).
    /// <see href="http://schema.org/musicCompositionForm"></see></summary>
    let musicCompositionForm =
        Namespaced_IRI.parse _namespace_name "musicCompositionForm" |> NamespacedName

    /// <summary>
    /// A member of a music group&amp;#x2014;for example, John, Paul, George, or Ringo.
    /// <see href="http://schema.org/musicGroupMember"></see></summary>
    let musicGroupMember =
        Namespaced_IRI.parse _namespace_name "musicGroupMember" |> NamespacedName

    /// <summary>
    /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
    /// <see href="http://schema.org/musicReleaseFormat"></see></summary>
    let musicReleaseFormat =
        Namespaced_IRI.parse _namespace_name "musicReleaseFormat" |> NamespacedName

    /// <summary>
    /// The key, mode, or scale this composition uses.
    /// <see href="http://schema.org/musicalKey"></see></summary>
    let musicalKey = Namespaced_IRI.parse _namespace_name "musicalKey" |> NamespacedName
    /// <summary>
    /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
    /// <see href="http://schema.org/naics"></see></summary>
    let naics = Namespaced_IRI.parse _namespace_name "naics" |> NamespacedName
    /// <summary>
    /// The name of the item.
    /// <see href="http://schema.org/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName

    /// <summary>
    /// A position played, performed or filled by a person or organization, as part of an organization. For example, an athlete in a SportsTeam might play in the position named 'Quarterback'.
    /// <see href="http://schema.org/namedPosition"></see></summary>
    let namedPosition =
        Namespaced_IRI.parse _namespace_name "namedPosition" |> NamespacedName

    /// <summary>
    /// A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.
    /// <see href="http://schema.org/roleName"></see></summary>
    let roleName = Namespaced_IRI.parse _namespace_name "roleName" |> NamespacedName

    /// <summary>
    /// Nationality of the person.
    /// <see href="http://schema.org/nationality"></see></summary>
    let nationality =
        Namespaced_IRI.parse _namespace_name "nationality" |> NamespacedName

    /// <summary>
    /// The total financial value of the person as calculated by subtracting assets from liabilities.
    /// <see href="http://schema.org/netWorth"></see></summary>
    let netWorth = Namespaced_IRI.parse _namespace_name "netWorth" |> NamespacedName
    /// <summary>
    /// A link to the ListItem that follows the current one.
    /// <see href="http://schema.org/nextItem"></see></summary>
    let nextItem = Namespaced_IRI.parse _namespace_name "nextItem" |> NamespacedName
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is not equal to the object.
    /// <see href="http://schema.org/nonEqual"></see></summary>
    let nonEqual = Namespaced_IRI.parse _namespace_name "nonEqual" |> NamespacedName
    /// <summary>
    /// The number of adults staying in the unit.
    /// <see href="http://schema.org/numAdults"></see></summary>
    let numAdults = Namespaced_IRI.parse _namespace_name "numAdults" |> NamespacedName

    /// <summary>
    /// The number of children staying in the unit.
    /// <see href="http://schema.org/numChildren"></see></summary>
    let numChildren =
        Namespaced_IRI.parse _namespace_name "numChildren" |> NamespacedName

    /// <summary>
    /// The number of tracks in this album or playlist.
    /// <see href="http://schema.org/numTracks"></see></summary>
    let numTracks = Namespaced_IRI.parse _namespace_name "numTracks" |> NamespacedName

    /// <summary>
    /// The number or type of airbags in the vehicle.
    /// <see href="http://schema.org/numberOfAirbags"></see></summary>
    let numberOfAirbags =
        Namespaced_IRI.parse _namespace_name "numberOfAirbags" |> NamespacedName

    /// <summary>
    /// The number of axles.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62
    /// <see href="http://schema.org/numberOfAxles"></see></summary>
    let numberOfAxles =
        Namespaced_IRI.parse _namespace_name "numberOfAxles" |> NamespacedName

    /// <summary>
    /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
    /// <see href="http://schema.org/numberOfBeds"></see></summary>
    let numberOfBeds =
        Namespaced_IRI.parse _namespace_name "numberOfBeds" |> NamespacedName

    /// <summary>
    /// The number of doors.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62
    /// <see href="http://schema.org/numberOfDoors"></see></summary>
    let numberOfDoors =
        Namespaced_IRI.parse _namespace_name "numberOfDoors" |> NamespacedName

    /// <summary>
    /// The number of employees in an organization e.g. business.
    /// <see href="http://schema.org/numberOfEmployees"></see></summary>
    let numberOfEmployees =
        Namespaced_IRI.parse _namespace_name "numberOfEmployees" |> NamespacedName

    /// <summary>
    /// The number of episodes in this season or series.
    /// <see href="http://schema.org/numberOfEpisodes"></see></summary>
    let numberOfEpisodes =
        Namespaced_IRI.parse _namespace_name "numberOfEpisodes" |> NamespacedName

    /// <summary>
    /// The total number of forward gears available for the transmission system of the vehicle.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62
    /// <see href="http://schema.org/numberOfForwardGears"></see></summary>
    let numberOfForwardGears =
        Namespaced_IRI.parse _namespace_name "numberOfForwardGears" |> NamespacedName

    /// <summary>
    /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
    /// <see href="http://schema.org/numberOfItems"></see></summary>
    let numberOfItems =
        Namespaced_IRI.parse _namespace_name "numberOfItems" |> NamespacedName

    /// <summary>
    /// The number of pages in the book.
    /// <see href="http://schema.org/numberOfPages"></see></summary>
    let numberOfPages =
        Namespaced_IRI.parse _namespace_name "numberOfPages" |> NamespacedName

    /// <summary>
    /// Indicate how many people can play this game (minimum, maximum, or range).
    /// <see href="http://schema.org/numberOfPlayers"></see></summary>
    let numberOfPlayers =
        Namespaced_IRI.parse _namespace_name "numberOfPlayers" |> NamespacedName

    /// <summary>
    /// The number of owners of the vehicle, including the current one.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62
    /// <see href="http://schema.org/numberOfPreviousOwners"></see></summary>
    let numberOfPreviousOwners =
        Namespaced_IRI.parse _namespace_name "numberOfPreviousOwners" |> NamespacedName

    /// <summary>
    /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
    /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
    /// <see href="http://schema.org/numberOfRooms"></see></summary>
    let numberOfRooms =
        Namespaced_IRI.parse _namespace_name "numberOfRooms" |> NamespacedName

    /// <summary>
    /// The number of seasons in this series.
    /// <see href="http://schema.org/numberOfSeasons"></see></summary>
    let numberOfSeasons =
        Namespaced_IRI.parse _namespace_name "numberOfSeasons" |> NamespacedName

    /// <summary>
    /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
    /// <see href="http://schema.org/numberedPosition"></see></summary>
    let numberedPosition =
        Namespaced_IRI.parse _namespace_name "numberedPosition" |> NamespacedName

    /// <summary>
    /// Nutrition information about the recipe or menu item.
    /// <see href="http://schema.org/nutrition"></see></summary>
    let nutrition = Namespaced_IRI.parse _namespace_name "nutrition" |> NamespacedName
    /// <summary>
    /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
    /// Typical unit code(s): C62 for person
    /// <see href="http://schema.org/occupancy"></see></summary>
    let occupancy = Namespaced_IRI.parse _namespace_name "occupancy" |> NamespacedName

    /// <summary>
    /// The region/country for which this occupational description is appropriate. Note that educational requirements and qualifications can vary between jurisdictions.
    /// <see href="http://schema.org/occupationLocation"></see></summary>
    let occupationLocation =
        Namespaced_IRI.parse _namespace_name "occupationLocation" |> NamespacedName

    /// <summary>
    /// The number of offers for the product.
    /// <see href="http://schema.org/offerCount"></see></summary>
    let offerCount = Namespaced_IRI.parse _namespace_name "offerCount" |> NamespacedName

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
    let openingHours =
        Namespaced_IRI.parse _namespace_name "openingHours" |> NamespacedName

    /// <summary>
    /// The opening hours of a certain place.
    /// <see href="http://schema.org/openingHoursSpecification"></see></summary>
    let openingHoursSpecification =
        Namespaced_IRI.parse _namespace_name "openingHoursSpecification" |> NamespacedName

    /// <summary>
    /// The opening hour of the place or service on the given day(s) of the week.
    /// <see href="http://schema.org/opens"></see></summary>
    let opens = Namespaced_IRI.parse _namespace_name "opens" |> NamespacedName

    /// <summary>
    /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
    /// <see href="http://schema.org/operatingSystem"></see></summary>
    let operatingSystem =
        Namespaced_IRI.parse _namespace_name "operatingSystem" |> NamespacedName

    /// <summary>
    /// A sub property of participant. The opponent on this action.
    /// <see href="http://schema.org/opponent"></see></summary>
    let opponent = Namespaced_IRI.parse _namespace_name "opponent" |> NamespacedName
    /// <summary>
    /// A sub property of object. The options subject to this action.
    /// <see href="http://schema.org/option"></see></summary>
    let option = Namespaced_IRI.parse _namespace_name "option" |> NamespacedName
    /// <summary>
    /// Date order was placed.
    /// <see href="http://schema.org/orderDate"></see></summary>
    let orderDate = Namespaced_IRI.parse _namespace_name "orderDate" |> NamespacedName

    /// <summary>
    /// The delivery of the parcel related to this order or order item.
    /// <see href="http://schema.org/orderDelivery"></see></summary>
    let orderDelivery =
        Namespaced_IRI.parse _namespace_name "orderDelivery" |> NamespacedName

    /// <summary>
    /// The identifier of the order item.
    /// <see href="http://schema.org/orderItemNumber"></see></summary>
    let orderItemNumber =
        Namespaced_IRI.parse _namespace_name "orderItemNumber" |> NamespacedName

    /// <summary>
    /// The current status of the order item.
    /// <see href="http://schema.org/orderItemStatus"></see></summary>
    let orderItemStatus =
        Namespaced_IRI.parse _namespace_name "orderItemStatus" |> NamespacedName

    /// <summary>
    /// The identifier of the transaction.
    /// <see href="http://schema.org/orderNumber"></see></summary>
    let orderNumber =
        Namespaced_IRI.parse _namespace_name "orderNumber" |> NamespacedName

    /// <summary>
    /// The number of the item ordered. If the property is not set, assume the quantity is one.
    /// <see href="http://schema.org/orderQuantity"></see></summary>
    let orderQuantity =
        Namespaced_IRI.parse _namespace_name "orderQuantity" |> NamespacedName

    /// <summary>
    /// The current status of the order.
    /// <see href="http://schema.org/orderStatus"></see></summary>
    let orderStatus =
        Namespaced_IRI.parse _namespace_name "orderStatus" |> NamespacedName

    /// <summary>
    /// The item ordered.
    /// <see href="http://schema.org/orderedItem"></see></summary>
    let orderedItem =
        Namespaced_IRI.parse _namespace_name "orderedItem" |> NamespacedName

    /// <summary>
    /// An organizer of an Event.
    /// <see href="http://schema.org/organizer"></see></summary>
    let organizer = Namespaced_IRI.parse _namespace_name "organizer" |> NamespacedName

    /// <summary>
    /// Shipper's address.
    /// <see href="http://schema.org/originAddress"></see></summary>
    let originAddress =
        Namespaced_IRI.parse _namespace_name "originAddress" |> NamespacedName

    /// <summary>
    /// The date and time of obtaining the product.
    /// <see href="http://schema.org/ownedFrom"></see></summary>
    let ownedFrom = Namespaced_IRI.parse _namespace_name "ownedFrom" |> NamespacedName

    /// <summary>
    /// The date and time of giving up ownership on the product.
    /// <see href="http://schema.org/ownedThrough"></see></summary>
    let ownedThrough =
        Namespaced_IRI.parse _namespace_name "ownedThrough" |> NamespacedName

    /// <summary>
    /// Products owned by the organization or person.
    /// <see href="http://schema.org/owns"></see></summary>
    let owns = Namespaced_IRI.parse _namespace_name "owns" |> NamespacedName
    /// <summary>
    /// The page on which the work ends; for example "138" or "xvi".
    /// <see href="http://schema.org/pageEnd"></see></summary>
    let pageEnd = Namespaced_IRI.parse _namespace_name "pageEnd" |> NamespacedName
    /// <summary>
    ///   <see href="http://schema.org/Chapter"></see>
    /// </summary>
    let Chapter = Namespaced_IRI.parse _namespace_name "Chapter" |> NamespacedName
    /// <summary>
    /// The page on which the work starts; for example "135" or "xiii".
    /// <see href="http://schema.org/pageStart"></see></summary>
    let pageStart = Namespaced_IRI.parse _namespace_name "pageStart" |> NamespacedName
    /// <summary>
    /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
    /// <see href="http://schema.org/pagination"></see></summary>
    let pagination = Namespaced_IRI.parse _namespace_name "pagination" |> NamespacedName
    /// <summary>
    /// A parent of this person.
    /// <see href="http://schema.org/parent"></see></summary>
    let parent = Namespaced_IRI.parse _namespace_name "parent" |> NamespacedName
    /// <summary>
    /// The parent of a question, answer or item in general.
    /// <see href="http://schema.org/parentItem"></see></summary>
    let parentItem = Namespaced_IRI.parse _namespace_name "parentItem" |> NamespacedName

    /// <summary>
    /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
    /// <see href="http://schema.org/subOrganization"></see></summary>
    let subOrganization =
        Namespaced_IRI.parse _namespace_name "subOrganization" |> NamespacedName

    /// <summary>
    /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
    /// <see href="http://schema.org/parentService"></see></summary>
    let parentService =
        Namespaced_IRI.parse _namespace_name "parentService" |> NamespacedName

    /// <summary>
    /// A parents of the person.
    /// <see href="http://schema.org/parents"></see></summary>
    let parents = Namespaced_IRI.parse _namespace_name "parents" |> NamespacedName

    /// <summary>
    /// The episode to which this clip belongs.
    /// <see href="http://schema.org/partOfEpisode"></see></summary>
    let partOfEpisode =
        Namespaced_IRI.parse _namespace_name "partOfEpisode" |> NamespacedName

    /// <summary>
    /// The order is being paid as part of the referenced Invoice.
    /// <see href="http://schema.org/partOfInvoice"></see></summary>
    let partOfInvoice =
        Namespaced_IRI.parse _namespace_name "partOfInvoice" |> NamespacedName

    /// <summary>
    /// The overall order the items in this delivery were included in.
    /// <see href="http://schema.org/partOfOrder"></see></summary>
    let partOfOrder =
        Namespaced_IRI.parse _namespace_name "partOfOrder" |> NamespacedName

    /// <summary>
    /// The season to which this episode belongs.
    /// <see href="http://schema.org/partOfSeason"></see></summary>
    let partOfSeason =
        Namespaced_IRI.parse _namespace_name "partOfSeason" |> NamespacedName

    /// <summary>
    /// The series to which this episode or season belongs.
    /// <see href="http://schema.org/partOfSeries"></see></summary>
    let partOfSeries =
        Namespaced_IRI.parse _namespace_name "partOfSeries" |> NamespacedName

    /// <summary>
    /// The TV series to which this episode or season belongs.
    /// <see href="http://schema.org/partOfTVSeries"></see></summary>
    let partOfTVSeries =
        Namespaced_IRI.parse _namespace_name "partOfTVSeries" |> NamespacedName

    /// <summary>
    /// Number of people the reservation should accommodate.
    /// <see href="http://schema.org/partySize"></see></summary>
    let partySize = Namespaced_IRI.parse _namespace_name "partySize" |> NamespacedName

    /// <summary>
    /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
    /// <see href="http://schema.org/passengerPriorityStatus"></see></summary>
    let passengerPriorityStatus =
        Namespaced_IRI.parse _namespace_name "passengerPriorityStatus" |> NamespacedName

    /// <summary>
    /// The passenger's sequence number as assigned by the airline.
    /// <see href="http://schema.org/passengerSequenceNumber"></see></summary>
    let passengerSequenceNumber =
        Namespaced_IRI.parse _namespace_name "passengerSequenceNumber" |> NamespacedName

    /// <summary>
    /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
    /// <see href="http://schema.org/paymentAccepted"></see></summary>
    let paymentAccepted =
        Namespaced_IRI.parse _namespace_name "paymentAccepted" |> NamespacedName

    /// <summary>
    /// The date that payment is due.
    /// <see href="http://schema.org/paymentDue"></see></summary>
    let paymentDue = Namespaced_IRI.parse _namespace_name "paymentDue" |> NamespacedName

    /// <summary>
    /// The date that payment is due.
    /// <see href="http://schema.org/paymentDueDate"></see></summary>
    let paymentDueDate =
        Namespaced_IRI.parse _namespace_name "paymentDueDate" |> NamespacedName

    /// <summary>
    /// The name of the credit card or other method of payment for the order.
    /// <see href="http://schema.org/paymentMethod"></see></summary>
    let paymentMethod =
        Namespaced_IRI.parse _namespace_name "paymentMethod" |> NamespacedName

    /// <summary>
    /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
    /// <see href="http://schema.org/paymentMethodId"></see></summary>
    let paymentMethodId =
        Namespaced_IRI.parse _namespace_name "paymentMethodId" |> NamespacedName

    /// <summary>
    /// The status of payment; whether the invoice has been paid or not.
    /// <see href="http://schema.org/paymentStatus"></see></summary>
    let paymentStatus =
        Namespaced_IRI.parse _namespace_name "paymentStatus" |> NamespacedName

    /// <summary>
    /// The URL for sending a payment.
    /// <see href="http://schema.org/paymentUrl"></see></summary>
    let paymentUrl = Namespaced_IRI.parse _namespace_name "paymentUrl" |> NamespacedName

    /// <summary>
    /// The 10th percentile value.
    /// <see href="http://schema.org/percentile10"></see></summary>
    let percentile10 =
        Namespaced_IRI.parse _namespace_name "percentile10" |> NamespacedName

    /// <summary>
    /// The 25th percentile value.
    /// <see href="http://schema.org/percentile25"></see></summary>
    let percentile25 =
        Namespaced_IRI.parse _namespace_name "percentile25" |> NamespacedName

    /// <summary>
    /// The 75th percentile value.
    /// <see href="http://schema.org/percentile75"></see></summary>
    let percentile75 =
        Namespaced_IRI.parse _namespace_name "percentile75" |> NamespacedName

    /// <summary>
    /// The 90th percentile value.
    /// <see href="http://schema.org/percentile90"></see></summary>
    let percentile90 =
        Namespaced_IRI.parse _namespace_name "percentile90" |> NamespacedName

    /// <summary>
    /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
    /// <see href="http://schema.org/performer"></see></summary>
    let performer = Namespaced_IRI.parse _namespace_name "performer" |> NamespacedName

    /// <summary>
    /// Event that this person is a performer or participant in.
    /// <see href="http://schema.org/performerIn"></see></summary>
    let performerIn =
        Namespaced_IRI.parse _namespace_name "performerIn" |> NamespacedName

    /// <summary>
    /// The main performer or performers of the event&amp;#x2014;for example, a presenter, musician, or actor.
    /// <see href="http://schema.org/performers"></see></summary>
    let performers = Namespaced_IRI.parse _namespace_name "performers" |> NamespacedName

    /// <summary>
    /// The type of permission granted the person, organization, or audience.
    /// <see href="http://schema.org/permissionType"></see></summary>
    let permissionType =
        Namespaced_IRI.parse _namespace_name "permissionType" |> NamespacedName

    /// <summary>
    /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
    /// <see href="http://schema.org/permissions"></see></summary>
    let permissions =
        Namespaced_IRI.parse _namespace_name "permissions" |> NamespacedName

    /// <summary>
    /// The target audience for this permit.
    /// <see href="http://schema.org/permitAudience"></see></summary>
    let permitAudience =
        Namespaced_IRI.parse _namespace_name "permitAudience" |> NamespacedName

    /// <summary>
    /// Indications regarding the permitted usage of the accommodation.
    /// <see href="http://schema.org/permittedUsage"></see></summary>
    let permittedUsage =
        Namespaced_IRI.parse _namespace_name "permittedUsage" |> NamespacedName

    /// <summary>
    /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
    /// <see href="http://schema.org/petsAllowed"></see></summary>
    let petsAllowed =
        Namespaced_IRI.parse _namespace_name "petsAllowed" |> NamespacedName

    /// <summary>
    /// A photograph of this place.
    /// <see href="http://schema.org/photo"></see></summary>
    let photo = Namespaced_IRI.parse _namespace_name "photo" |> NamespacedName
    /// <summary>
    /// Photographs of this place.
    /// <see href="http://schema.org/photos"></see></summary>
    let photos = Namespaced_IRI.parse _namespace_name "photos" |> NamespacedName

    /// <summary>
    /// Where a taxi will pick up a passenger or a rental car can be picked up.
    /// <see href="http://schema.org/pickupLocation"></see></summary>
    let pickupLocation =
        Namespaced_IRI.parse _namespace_name "pickupLocation" |> NamespacedName

    /// <summary>
    /// When a taxi will pickup a passenger or a rental car can be picked up.
    /// <see href="http://schema.org/pickupTime"></see></summary>
    let pickupTime = Namespaced_IRI.parse _namespace_name "pickupTime" |> NamespacedName
    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
    /// <see href="http://schema.org/playMode"></see></summary>
    let playMode = Namespaced_IRI.parse _namespace_name "playMode" |> NamespacedName
    /// <summary>
    /// Player type required&amp;#x2014;for example, Flash or Silverlight.
    /// <see href="http://schema.org/playerType"></see></summary>
    let playerType = Namespaced_IRI.parse _namespace_name "playerType" |> NamespacedName

    /// <summary>
    /// Number of players on the server.
    /// <see href="http://schema.org/playersOnline"></see></summary>
    let playersOnline =
        Namespaced_IRI.parse _namespace_name "playersOnline" |> NamespacedName

    /// <summary>
    /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
    /// <see href="http://schema.org/polygon"></see></summary>
    let polygon = Namespaced_IRI.parse _namespace_name "polygon" |> NamespacedName

    /// <summary>
    /// The post office box number for PO box addresses.
    /// <see href="http://schema.org/postOfficeBoxNumber"></see></summary>
    let postOfficeBoxNumber =
        Namespaced_IRI.parse _namespace_name "postOfficeBoxNumber" |> NamespacedName

    /// <summary>
    /// The postal code. For example, 94043.
    /// <see href="http://schema.org/postalCode"></see></summary>
    let postalCode = Namespaced_IRI.parse _namespace_name "postalCode" |> NamespacedName

    /// <summary>
    /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
    /// <see href="http://schema.org/potentialAction"></see></summary>
    let potentialAction =
        Namespaced_IRI.parse _namespace_name "potentialAction" |> NamespacedName

    /// <summary>
    /// A pointer from a previous, often discontinued variant of the product to its newer variant.
    /// <see href="http://schema.org/predecessorOf"></see></summary>
    let predecessorOf =
        Namespaced_IRI.parse _namespace_name "predecessorOf" |> NamespacedName

    /// <summary>
    /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
    /// <see href="http://schema.org/prepTime"></see></summary>
    let prepTime = Namespaced_IRI.parse _namespace_name "prepTime" |> NamespacedName

    /// <summary>
    /// A link to the ListItem that preceeds the current one.
    /// <see href="http://schema.org/previousItem"></see></summary>
    let previousItem =
        Namespaced_IRI.parse _namespace_name "previousItem" |> NamespacedName

    /// <summary>
    /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
    /// <see href="http://schema.org/previousStartDate"></see></summary>
    let previousStartDate =
        Namespaced_IRI.parse _namespace_name "previousStartDate" |> NamespacedName

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
    let price = Namespaced_IRI.parse _namespace_name "price" |> NamespacedName

    /// <summary>
    /// This property links to all &lt;a class="localLink" href="http://schema.org/UnitPriceSpecification"&gt;UnitPriceSpecification&lt;/a&gt; nodes that apply in parallel for the &lt;a class="localLink" href="http://schema.org/CompoundPriceSpecification"&gt;CompoundPriceSpecification&lt;/a&gt; node.
    /// <see href="http://schema.org/priceComponent"></see></summary>
    let priceComponent =
        Namespaced_IRI.parse _namespace_name "priceComponent" |> NamespacedName

    /// <summary>
    /// The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
    /// <see href="http://schema.org/priceCurrency"></see></summary>
    let priceCurrency =
        Namespaced_IRI.parse _namespace_name "priceCurrency" |> NamespacedName

    /// <summary>
    /// The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.
    /// <see href="http://schema.org/priceRange"></see></summary>
    let priceRange = Namespaced_IRI.parse _namespace_name "priceRange" |> NamespacedName

    /// <summary>
    /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
    /// <see href="http://schema.org/priceSpecification"></see></summary>
    let priceSpecification =
        Namespaced_IRI.parse _namespace_name "priceSpecification" |> NamespacedName

    /// <summary>
    /// A short text or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.
    /// <see href="http://schema.org/priceType"></see></summary>
    let priceType = Namespaced_IRI.parse _namespace_name "priceType" |> NamespacedName

    /// <summary>
    /// The date after which the price is no longer available.
    /// <see href="http://schema.org/priceValidUntil"></see></summary>
    let priceValidUntil =
        Namespaced_IRI.parse _namespace_name "priceValidUntil" |> NamespacedName

    /// <summary>
    /// Indicates the main image on the page.
    /// <see href="http://schema.org/primaryImageOfPage"></see></summary>
    let primaryImageOfPage =
        Namespaced_IRI.parse _namespace_name "primaryImageOfPage" |> NamespacedName

    /// <summary>
    /// The number of the column in which the NewsArticle appears in the print edition.
    /// <see href="http://schema.org/printColumn"></see></summary>
    let printColumn =
        Namespaced_IRI.parse _namespace_name "printColumn" |> NamespacedName

    /// <summary>
    /// The edition of the print product in which the NewsArticle appears.
    /// <see href="http://schema.org/printEdition"></see></summary>
    let printEdition =
        Namespaced_IRI.parse _namespace_name "printEdition" |> NamespacedName

    /// <summary>
    /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
    /// <see href="http://schema.org/printPage"></see></summary>
    let printPage = Namespaced_IRI.parse _namespace_name "printPage" |> NamespacedName

    /// <summary>
    /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
    /// <see href="http://schema.org/printSection"></see></summary>
    let printSection =
        Namespaced_IRI.parse _namespace_name "printSection" |> NamespacedName

    /// <summary>
    /// Estimated processing time for the service using this channel.
    /// <see href="http://schema.org/processingTime"></see></summary>
    let processingTime =
        Namespaced_IRI.parse _namespace_name "processingTime" |> NamespacedName

    /// <summary>
    /// Processor architecture required to run the application (e.g. IA64).
    /// <see href="http://schema.org/processorRequirements"></see></summary>
    let processorRequirements =
        Namespaced_IRI.parse _namespace_name "processorRequirements" |> NamespacedName

    /// <summary>
    /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
    /// <see href="http://schema.org/producer"></see></summary>
    let producer = Namespaced_IRI.parse _namespace_name "producer" |> NamespacedName
    /// <summary>
    /// The tangible thing generated by the service, e.g. a passport, permit, etc.
    /// <see href="http://schema.org/produces"></see></summary>
    let produces = Namespaced_IRI.parse _namespace_name "produces" |> NamespacedName

    /// <summary>
    /// The tangible thing generated by the service, e.g. a passport, permit, etc.
    /// <see href="http://schema.org/serviceOutput"></see></summary>
    let serviceOutput =
        Namespaced_IRI.parse _namespace_name "serviceOutput" |> NamespacedName

    /// <summary>
    /// The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.
    /// <see href="http://schema.org/productID"></see></summary>
    let productID = Namespaced_IRI.parse _namespace_name "productID" |> NamespacedName

    /// <summary>
    /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
    /// <see href="http://schema.org/productSupported"></see></summary>
    let productSupported =
        Namespaced_IRI.parse _namespace_name "productSupported" |> NamespacedName

    /// <summary>
    /// The production company or studio responsible for the item e.g. series, video game, episode etc.
    /// <see href="http://schema.org/productionCompany"></see></summary>
    let productionCompany =
        Namespaced_IRI.parse _namespace_name "productionCompany" |> NamespacedName

    /// <summary>
    /// The date of production of the item, e.g. vehicle.
    /// <see href="http://schema.org/productionDate"></see></summary>
    let productionDate =
        Namespaced_IRI.parse _namespace_name "productionDate" |> NamespacedName

    /// <summary>
    /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
    /// <see href="http://schema.org/proficiencyLevel"></see></summary>
    let proficiencyLevel =
        Namespaced_IRI.parse _namespace_name "proficiencyLevel" |> NamespacedName

    /// <summary>
    /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
    /// <see href="http://schema.org/programMembershipUsed"></see></summary>
    let programMembershipUsed =
        Namespaced_IRI.parse _namespace_name "programMembershipUsed" |> NamespacedName

    /// <summary>
    /// The program providing the membership.
    /// <see href="http://schema.org/programName"></see></summary>
    let programName =
        Namespaced_IRI.parse _namespace_name "programName" |> NamespacedName

    /// <summary>
    /// The computer programming language.
    /// <see href="http://schema.org/programmingLanguage"></see></summary>
    let programmingLanguage =
        Namespaced_IRI.parse _namespace_name "programmingLanguage" |> NamespacedName

    /// <summary>
    /// Indicates whether API is managed or unmanaged.
    /// <see href="http://schema.org/programmingModel"></see></summary>
    let programmingModel =
        Namespaced_IRI.parse _namespace_name "programmingModel" |> NamespacedName

    /// <summary>
    /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
    /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
    /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
    /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
    /// <see href="http://schema.org/propertyID"></see></summary>
    let propertyID = Namespaced_IRI.parse _namespace_name "propertyID" |> NamespacedName

    /// <summary>
    /// The number of grams of protein.
    /// <see href="http://schema.org/proteinContent"></see></summary>
    let proteinContent =
        Namespaced_IRI.parse _namespace_name "proteinContent" |> NamespacedName

    /// <summary>
    /// Indicates the mobility of a provided service (e.g. 'static', 'dynamic').
    /// <see href="http://schema.org/providerMobility"></see></summary>
    let providerMobility =
        Namespaced_IRI.parse _namespace_name "providerMobility" |> NamespacedName

    /// <summary>
    /// The service provided by this channel.
    /// <see href="http://schema.org/providesService"></see></summary>
    let providesService =
        Namespaced_IRI.parse _namespace_name "providesService" |> NamespacedName

    /// <summary>
    /// A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
    /// <see href="http://schema.org/publicAccess"></see></summary>
    let publicAccess =
        Namespaced_IRI.parse _namespace_name "publicAccess" |> NamespacedName

    /// <summary>
    /// A publication event associated with the item.
    /// <see href="http://schema.org/publication"></see></summary>
    let publication =
        Namespaced_IRI.parse _namespace_name "publication" |> NamespacedName

    /// <summary>
    /// A broadcast service associated with the publication event.
    /// <see href="http://schema.org/publishedOn"></see></summary>
    let publishedOn =
        Namespaced_IRI.parse _namespace_name "publishedOn" |> NamespacedName

    /// <summary>
    /// The publisher of the creative work.
    /// <see href="http://schema.org/publisher"></see></summary>
    let publisher = Namespaced_IRI.parse _namespace_name "publisher" |> NamespacedName

    /// <summary>
    /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
    /// <see href="http://schema.org/publishingPrinciples"></see></summary>
    let publishingPrinciples =
        Namespaced_IRI.parse _namespace_name "publishingPrinciples" |> NamespacedName

    /// <summary>
    /// The date the item e.g. vehicle was purchased by the current owner.
    /// <see href="http://schema.org/purchaseDate"></see></summary>
    let purchaseDate =
        Namespaced_IRI.parse _namespace_name "purchaseDate" |> NamespacedName

    /// <summary>
    /// A sub property of instrument. The query used on this action.
    /// <see href="http://schema.org/query"></see></summary>
    let query = Namespaced_IRI.parse _namespace_name "query" |> NamespacedName
    /// <summary>
    /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
    /// <see href="http://schema.org/quest"></see></summary>
    let quest = Namespaced_IRI.parse _namespace_name "quest" |> NamespacedName
    /// <summary>
    /// A sub property of object. A question.
    /// <see href="http://schema.org/question"></see></summary>
    let question = Namespaced_IRI.parse _namespace_name "question" |> NamespacedName

    /// <summary>
    /// The count of total number of ratings.
    /// <see href="http://schema.org/ratingCount"></see></summary>
    let ratingCount =
        Namespaced_IRI.parse _namespace_name "ratingCount" |> NamespacedName

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
    let ratingValue =
        Namespaced_IRI.parse _namespace_name "ratingValue" |> NamespacedName

    /// <summary>
    /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
    /// <see href="http://schema.org/readonlyValue"></see></summary>
    let readonlyValue =
        Namespaced_IRI.parse _namespace_name "readonlyValue" |> NamespacedName

    /// <summary>
    /// A sub property of participant. The real estate agent involved in the action.
    /// <see href="http://schema.org/realEstateAgent"></see></summary>
    let realEstateAgent =
        Namespaced_IRI.parse _namespace_name "realEstateAgent" |> NamespacedName

    /// <summary>
    /// A sub property of instrument. The recipe/instructions used to perform the action.
    /// <see href="http://schema.org/recipe"></see></summary>
    let recipe = Namespaced_IRI.parse _namespace_name "recipe" |> NamespacedName

    /// <summary>
    /// The category of the recipe—for example, appetizer, entree, etc.
    /// <see href="http://schema.org/recipeCategory"></see></summary>
    let recipeCategory =
        Namespaced_IRI.parse _namespace_name "recipeCategory" |> NamespacedName

    /// <summary>
    /// The cuisine of the recipe (for example, French or Ethiopian).
    /// <see href="http://schema.org/recipeCuisine"></see></summary>
    let recipeCuisine =
        Namespaced_IRI.parse _namespace_name "recipeCuisine" |> NamespacedName

    /// <summary>
    /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
    /// <see href="http://schema.org/recipeInstructions"></see></summary>
    let recipeInstructions =
        Namespaced_IRI.parse _namespace_name "recipeInstructions" |> NamespacedName

    /// <summary>
    /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection.
    /// <see href="http://schema.org/step"></see></summary>
    let step = Namespaced_IRI.parse _namespace_name "step" |> NamespacedName

    /// <summary>
    /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
    /// <see href="http://schema.org/recipeYield"></see></summary>
    let recipeYield =
        Namespaced_IRI.parse _namespace_name "recipeYield" |> NamespacedName

    /// <summary>
    /// The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
    /// <see href="http://schema.org/yield"></see></summary>
    let yield_ = Namespaced_IRI.parse _namespace_name "yield" |> NamespacedName

    /// <summary>
    /// The label that issued the release.
    /// <see href="http://schema.org/recordLabel"></see></summary>
    let recordLabel =
        Namespaced_IRI.parse _namespace_name "recordLabel" |> NamespacedName

    /// <summary>
    /// An audio recording of the work.
    /// <see href="http://schema.org/recordedAs"></see></summary>
    let recordedAs = Namespaced_IRI.parse _namespace_name "recordedAs" |> NamespacedName

    /// <summary>
    /// The composition this track is a recording of.
    /// <see href="http://schema.org/recordingOf"></see></summary>
    let recordingOf =
        Namespaced_IRI.parse _namespace_name "recordingOf" |> NamespacedName

    /// <summary>
    /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
    /// <see href="http://schema.org/recordedAt"></see></summary>
    let recordedAt = Namespaced_IRI.parse _namespace_name "recordedAt" |> NamespacedName
    /// <summary>
    /// The CreativeWork that captured all or part of this Event.
    /// <see href="http://schema.org/recordedIn"></see></summary>
    let recordedIn = Namespaced_IRI.parse _namespace_name "recordedIn" |> NamespacedName

    /// <summary>
    /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
    /// <see href="http://schema.org/referenceQuantity"></see></summary>
    let referenceQuantity =
        Namespaced_IRI.parse _namespace_name "referenceQuantity" |> NamespacedName

    /// <summary>
    /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
    /// <see href="http://schema.org/referencesOrder"></see></summary>
    let referencesOrder =
        Namespaced_IRI.parse _namespace_name "referencesOrder" |> NamespacedName

    /// <summary>
    /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.
    /// <see href="http://schema.org/regionsAllowed"></see></summary>
    let regionsAllowed =
        Namespaced_IRI.parse _namespace_name "regionsAllowed" |> NamespacedName

    /// <summary>
    /// A link related to this web page, for example to other related web pages.
    /// <see href="http://schema.org/relatedLink"></see></summary>
    let relatedLink =
        Namespaced_IRI.parse _namespace_name "relatedLink" |> NamespacedName

    /// <summary>
    /// The most generic familial relation.
    /// <see href="http://schema.org/relatedTo"></see></summary>
    let relatedTo = Namespaced_IRI.parse _namespace_name "relatedTo" |> NamespacedName

    /// <summary>
    /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
    /// <see href="http://schema.org/releaseDate"></see></summary>
    let releaseDate =
        Namespaced_IRI.parse _namespace_name "releaseDate" |> NamespacedName

    /// <summary>
    /// Description of what changed in this version.
    /// <see href="http://schema.org/releaseNotes"></see></summary>
    let releaseNotes =
        Namespaced_IRI.parse _namespace_name "releaseNotes" |> NamespacedName

    /// <summary>
    /// The place and time the release was issued, expressed as a PublicationEvent.
    /// <see href="http://schema.org/releasedEvent"></see></summary>
    let releasedEvent =
        Namespaced_IRI.parse _namespace_name "releasedEvent" |> NamespacedName

    /// <summary>
    /// The Occupation for the JobPosting.
    /// <see href="http://schema.org/relevantOccupation"></see></summary>
    let relevantOccupation =
        Namespaced_IRI.parse _namespace_name "relevantOccupation" |> NamespacedName

    /// <summary>
    /// The number of attendee places for an event that remain unallocated.
    /// <see href="http://schema.org/remainingAttendeeCapacity"></see></summary>
    let remainingAttendeeCapacity =
        Namespaced_IRI.parse _namespace_name "remainingAttendeeCapacity" |> NamespacedName

    /// <summary>
    /// A sub property of object. The object that is being replaced.
    /// <see href="http://schema.org/replacee"></see></summary>
    let replacee = Namespaced_IRI.parse _namespace_name "replacee" |> NamespacedName
    /// <summary>
    /// A sub property of object. The object that replaces.
    /// <see href="http://schema.org/replacer"></see></summary>
    let replacer = Namespaced_IRI.parse _namespace_name "replacer" |> NamespacedName
    /// <summary>
    /// The URL at which a reply may be posted to the specified UserComment.
    /// <see href="http://schema.org/replyToUrl"></see></summary>
    let replyToUrl = Namespaced_IRI.parse _namespace_name "replyToUrl" |> NamespacedName

    /// <summary>
    /// The number or other unique designator assigned to a Report by the publishing organization.
    /// <see href="http://schema.org/reportNumber"></see></summary>
    let reportNumber =
        Namespaced_IRI.parse _namespace_name "reportNumber" |> NamespacedName

    /// <summary>
    /// Indicates whether this image is representative of the content of the page.
    /// <see href="http://schema.org/representativeOfPage"></see></summary>
    let representativeOfPage =
        Namespaced_IRI.parse _namespace_name "representativeOfPage" |> NamespacedName

    /// <summary>
    /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
    /// <see href="http://schema.org/requiredCollateral"></see></summary>
    let requiredCollateral =
        Namespaced_IRI.parse _namespace_name "requiredCollateral" |> NamespacedName

    /// <summary>
    /// Audiences defined by a person's gender.
    /// <see href="http://schema.org/requiredGender"></see></summary>
    let requiredGender =
        Namespaced_IRI.parse _namespace_name "requiredGender" |> NamespacedName

    /// <summary>
    /// Audiences defined by a person's maximum age.
    /// <see href="http://schema.org/requiredMaxAge"></see></summary>
    let requiredMaxAge =
        Namespaced_IRI.parse _namespace_name "requiredMaxAge" |> NamespacedName

    /// <summary>
    /// Audiences defined by a person's minimum age.
    /// <see href="http://schema.org/requiredMinAge"></see></summary>
    let requiredMinAge =
        Namespaced_IRI.parse _namespace_name "requiredMinAge" |> NamespacedName

    /// <summary>
    /// The required quantity of the item(s).
    /// <see href="http://schema.org/requiredQuantity"></see></summary>
    let requiredQuantity =
        Namespaced_IRI.parse _namespace_name "requiredQuantity" |> NamespacedName

    /// <summary>
    /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
    /// <see href="http://schema.org/requirements"></see></summary>
    let requirements =
        Namespaced_IRI.parse _namespace_name "requirements" |> NamespacedName

    /// <summary>
    /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
    /// <see href="http://schema.org/softwareRequirements"></see></summary>
    let softwareRequirements =
        Namespaced_IRI.parse _namespace_name "softwareRequirements" |> NamespacedName

    /// <summary>
    /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
    /// <see href="http://schema.org/requiresSubscription"></see></summary>
    let requiresSubscription =
        Namespaced_IRI.parse _namespace_name "requiresSubscription" |> NamespacedName

    /// <summary>
    /// The thing -- flight, event, restaurant,etc. being reserved.
    /// <see href="http://schema.org/reservationFor"></see></summary>
    let reservationFor =
        Namespaced_IRI.parse _namespace_name "reservationFor" |> NamespacedName

    /// <summary>
    /// A unique identifier for the reservation.
    /// <see href="http://schema.org/reservationId"></see></summary>
    let reservationId =
        Namespaced_IRI.parse _namespace_name "reservationId" |> NamespacedName

    /// <summary>
    /// The current status of the reservation.
    /// <see href="http://schema.org/reservationStatus"></see></summary>
    let reservationStatus =
        Namespaced_IRI.parse _namespace_name "reservationStatus" |> NamespacedName

    /// <summary>
    /// A ticket associated with the reservation.
    /// <see href="http://schema.org/reservedTicket"></see></summary>
    let reservedTicket =
        Namespaced_IRI.parse _namespace_name "reservedTicket" |> NamespacedName

    /// <summary>
    /// Responsibilities associated with this role or Occupation.
    /// <see href="http://schema.org/responsibilities"></see></summary>
    let responsibilities =
        Namespaced_IRI.parse _namespace_name "responsibilities" |> NamespacedName

    /// <summary>
    /// The result produced in the action. e.g. John wrote &lt;em&gt;a book&lt;/em&gt;.
    /// <see href="http://schema.org/result"></see></summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName

    /// <summary>
    /// A sub property of result. The Comment created or sent as a result of this action.
    /// <see href="http://schema.org/resultComment"></see></summary>
    let resultComment =
        Namespaced_IRI.parse _namespace_name "resultComment" |> NamespacedName

    /// <summary>
    /// A sub property of result. The review that resulted in the performing of the action.
    /// <see href="http://schema.org/resultReview"></see></summary>
    let resultReview =
        Namespaced_IRI.parse _namespace_name "resultReview" |> NamespacedName

    /// <summary>
    /// A review of the item.
    /// <see href="http://schema.org/review"></see></summary>
    let review = Namespaced_IRI.parse _namespace_name "review" |> NamespacedName

    /// <summary>
    /// This Review or Rating is relevant to this part or facet of the itemReviewed.
    /// <see href="http://schema.org/reviewAspect"></see></summary>
    let reviewAspect =
        Namespaced_IRI.parse _namespace_name "reviewAspect" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/Guide"></see>
    /// </summary>
    let Guide = Namespaced_IRI.parse _namespace_name "Guide" |> NamespacedName
    /// <summary>
    /// The actual body of the review.
    /// <see href="http://schema.org/reviewBody"></see></summary>
    let reviewBody = Namespaced_IRI.parse _namespace_name "reviewBody" |> NamespacedName

    /// <summary>
    /// The count of total number of reviews.
    /// <see href="http://schema.org/reviewCount"></see></summary>
    let reviewCount =
        Namespaced_IRI.parse _namespace_name "reviewCount" |> NamespacedName

    /// <summary>
    /// The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="http://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.
    /// <see href="http://schema.org/reviewRating"></see></summary>
    let reviewRating =
        Namespaced_IRI.parse _namespace_name "reviewRating" |> NamespacedName

    /// <summary>
    /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
    /// <see href="http://schema.org/reviewedBy"></see></summary>
    let reviewedBy = Namespaced_IRI.parse _namespace_name "reviewedBy" |> NamespacedName
    /// <summary>
    /// Review of the item.
    /// <see href="http://schema.org/reviews"></see></summary>
    let reviews = Namespaced_IRI.parse _namespace_name "reviews" |> NamespacedName

    /// <summary>
    /// The response (yes, no, maybe) to the RSVP.
    /// <see href="http://schema.org/rsvpResponse"></see></summary>
    let rsvpResponse =
        Namespaced_IRI.parse _namespace_name "rsvpResponse" |> NamespacedName

    /// <summary>
    /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
    /// <see href="http://schema.org/runtime"></see></summary>
    let runtime = Namespaced_IRI.parse _namespace_name "runtime" |> NamespacedName

    /// <summary>
    /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
    /// <see href="http://schema.org/runtimePlatform"></see></summary>
    let runtimePlatform =
        Namespaced_IRI.parse _namespace_name "runtimePlatform" |> NamespacedName

    /// <summary>
    /// The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.
    /// <see href="http://schema.org/salaryCurrency"></see></summary>
    let salaryCurrency =
        Namespaced_IRI.parse _namespace_name "salaryCurrency" |> NamespacedName

    /// <summary>
    /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
    /// <see href="http://schema.org/sampleType"></see></summary>
    let sampleType = Namespaced_IRI.parse _namespace_name "sampleType" |> NamespacedName

    /// <summary>
    /// The number of grams of saturated fat.
    /// <see href="http://schema.org/saturatedFatContent"></see></summary>
    let saturatedFatContent =
        Namespaced_IRI.parse _namespace_name "saturatedFatContent" |> NamespacedName

    /// <summary>
    /// The date the invoice is scheduled to be paid.
    /// <see href="http://schema.org/scheduledPaymentDate"></see></summary>
    let scheduledPaymentDate =
        Namespaced_IRI.parse _namespace_name "scheduledPaymentDate" |> NamespacedName

    /// <summary>
    /// The time the object is scheduled to.
    /// <see href="http://schema.org/scheduledTime"></see></summary>
    let scheduledTime =
        Namespaced_IRI.parse _namespace_name "scheduledTime" |> NamespacedName

    /// <summary>
    /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
    /// <see href="http://schema.org/schemaVersion"></see></summary>
    let schemaVersion =
        Namespaced_IRI.parse _namespace_name "schemaVersion" |> NamespacedName

    /// <summary>
    /// The number of screens in the movie theater.
    /// <see href="http://schema.org/screenCount"></see></summary>
    let screenCount =
        Namespaced_IRI.parse _namespace_name "screenCount" |> NamespacedName

    /// <summary>
    /// A link to a screenshot image of the app.
    /// <see href="http://schema.org/screenshot"></see></summary>
    let screenshot = Namespaced_IRI.parse _namespace_name "screenshot" |> NamespacedName
    /// <summary>
    /// A season in a media series.
    /// <see href="http://schema.org/season"></see></summary>
    let season = Namespaced_IRI.parse _namespace_name "season" |> NamespacedName

    /// <summary>
    /// Position of the season within an ordered group of seasons.
    /// <see href="http://schema.org/seasonNumber"></see></summary>
    let seasonNumber =
        Namespaced_IRI.parse _namespace_name "seasonNumber" |> NamespacedName

    /// <summary>
    /// A season in a media series.
    /// <see href="http://schema.org/seasons"></see></summary>
    let seasons = Namespaced_IRI.parse _namespace_name "seasons" |> NamespacedName
    /// <summary>
    /// The location of the reserved seat (e.g., 27).
    /// <see href="http://schema.org/seatNumber"></see></summary>
    let seatNumber = Namespaced_IRI.parse _namespace_name "seatNumber" |> NamespacedName
    /// <summary>
    /// The row location of the reserved seat (e.g., B).
    /// <see href="http://schema.org/seatRow"></see></summary>
    let seatRow = Namespaced_IRI.parse _namespace_name "seatRow" |> NamespacedName

    /// <summary>
    /// The section location of the reserved seat (e.g. Orchestra).
    /// <see href="http://schema.org/seatSection"></see></summary>
    let seatSection =
        Namespaced_IRI.parse _namespace_name "seatSection" |> NamespacedName

    /// <summary>
    /// The type/class of the seat.
    /// <see href="http://schema.org/seatingType"></see></summary>
    let seatingType =
        Namespaced_IRI.parse _namespace_name "seatingType" |> NamespacedName

    /// <summary>
    /// The type of security screening the passenger is subject to.
    /// <see href="http://schema.org/securityScreening"></see></summary>
    let securityScreening =
        Namespaced_IRI.parse _namespace_name "securityScreening" |> NamespacedName

    /// <summary>
    /// A pointer to products or services sought by the organization or person (demand).
    /// <see href="http://schema.org/seeks"></see></summary>
    let seeks = Namespaced_IRI.parse _namespace_name "seeks" |> NamespacedName
    /// <summary>
    /// A sub property of participant. The participant who is at the sending end of the action.
    /// <see href="http://schema.org/sender"></see></summary>
    let sender = Namespaced_IRI.parse _namespace_name "sender" |> NamespacedName

    /// <summary>
    /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
    /// <see href="http://schema.org/serialNumber"></see></summary>
    let serialNumber =
        Namespaced_IRI.parse _namespace_name "serialNumber" |> NamespacedName

    /// <summary>
    /// Status of a game server.
    /// <see href="http://schema.org/serverStatus"></see></summary>
    let serverStatus =
        Namespaced_IRI.parse _namespace_name "serverStatus" |> NamespacedName

    /// <summary>
    /// The cuisine of the restaurant.
    /// <see href="http://schema.org/servesCuisine"></see></summary>
    let servesCuisine =
        Namespaced_IRI.parse _namespace_name "servesCuisine" |> NamespacedName

    /// <summary>
    /// The audience eligible for this service.
    /// <see href="http://schema.org/serviceAudience"></see></summary>
    let serviceAudience =
        Namespaced_IRI.parse _namespace_name "serviceAudience" |> NamespacedName

    /// <summary>
    /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
    /// <see href="http://schema.org/serviceLocation"></see></summary>
    let serviceLocation =
        Namespaced_IRI.parse _namespace_name "serviceLocation" |> NamespacedName

    /// <summary>
    /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
    /// <see href="http://schema.org/serviceOperator"></see></summary>
    let serviceOperator =
        Namespaced_IRI.parse _namespace_name "serviceOperator" |> NamespacedName

    /// <summary>
    /// The phone number to use to access the service.
    /// <see href="http://schema.org/servicePhone"></see></summary>
    let servicePhone =
        Namespaced_IRI.parse _namespace_name "servicePhone" |> NamespacedName

    /// <summary>
    /// The address for accessing the service by mail.
    /// <see href="http://schema.org/servicePostalAddress"></see></summary>
    let servicePostalAddress =
        Namespaced_IRI.parse _namespace_name "servicePostalAddress" |> NamespacedName

    /// <summary>
    /// The number to access the service by text message.
    /// <see href="http://schema.org/serviceSmsNumber"></see></summary>
    let serviceSmsNumber =
        Namespaced_IRI.parse _namespace_name "serviceSmsNumber" |> NamespacedName

    /// <summary>
    /// The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
    /// <see href="http://schema.org/serviceType"></see></summary>
    let serviceType =
        Namespaced_IRI.parse _namespace_name "serviceType" |> NamespacedName

    /// <summary>
    /// The website to access the service.
    /// <see href="http://schema.org/serviceUrl"></see></summary>
    let serviceUrl = Namespaced_IRI.parse _namespace_name "serviceUrl" |> NamespacedName

    /// <summary>
    /// The serving size, in terms of the number of volume or mass.
    /// <see href="http://schema.org/servingSize"></see></summary>
    let servingSize =
        Namespaced_IRI.parse _namespace_name "servingSize" |> NamespacedName

    /// <summary>
    /// A CreativeWork such as an image, video, or audio clip shared as part of this posting.
    /// <see href="http://schema.org/sharedContent"></see></summary>
    let sharedContent =
        Namespaced_IRI.parse _namespace_name "sharedContent" |> NamespacedName

    /// <summary>
    /// A sibling of the person.
    /// <see href="http://schema.org/sibling"></see></summary>
    let sibling = Namespaced_IRI.parse _namespace_name "sibling" |> NamespacedName
    /// <summary>
    /// A sibling of the person.
    /// <see href="http://schema.org/siblings"></see></summary>
    let siblings = Namespaced_IRI.parse _namespace_name "siblings" |> NamespacedName

    /// <summary>
    /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
    /// <see href="http://schema.org/significantLink"></see></summary>
    let significantLink =
        Namespaced_IRI.parse _namespace_name "significantLink" |> NamespacedName

    /// <summary>
    /// The most significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
    /// <see href="http://schema.org/significantLinks"></see></summary>
    let significantLinks =
        Namespaced_IRI.parse _namespace_name "significantLinks" |> NamespacedName

    /// <summary>
    /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.
    /// <see href="http://schema.org/skills"></see></summary>
    let skills = Namespaced_IRI.parse _namespace_name "skills" |> NamespacedName
    /// <summary>
    /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
    /// <see href="http://schema.org/sku"></see></summary>
    let sku = Namespaced_IRI.parse _namespace_name "sku" |> NamespacedName
    /// <summary>
    /// A slogan or motto associated with the item.
    /// <see href="http://schema.org/slogan"></see></summary>
    let slogan = Namespaced_IRI.parse _namespace_name "slogan" |> NamespacedName

    /// <summary>
    /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
    /// <see href="http://schema.org/smokingAllowed"></see></summary>
    let smokingAllowed =
        Namespaced_IRI.parse _namespace_name "smokingAllowed" |> NamespacedName

    /// <summary>
    /// The number of milligrams of sodium.
    /// <see href="http://schema.org/sodiumContent"></see></summary>
    let sodiumContent =
        Namespaced_IRI.parse _namespace_name "sodiumContent" |> NamespacedName

    /// <summary>
    /// Additional content for a software application.
    /// <see href="http://schema.org/softwareAddOn"></see></summary>
    let softwareAddOn =
        Namespaced_IRI.parse _namespace_name "softwareAddOn" |> NamespacedName

    /// <summary>
    /// Software application help.
    /// <see href="http://schema.org/softwareHelp"></see></summary>
    let softwareHelp =
        Namespaced_IRI.parse _namespace_name "softwareHelp" |> NamespacedName

    /// <summary>
    /// Version of the software instance.
    /// <see href="http://schema.org/softwareVersion"></see></summary>
    let softwareVersion =
        Namespaced_IRI.parse _namespace_name "softwareVersion" |> NamespacedName

    /// <summary>
    /// The Organization on whose behalf the creator was working.
    /// <see href="http://schema.org/sourceOrganization"></see></summary>
    let sourceOrganization =
        Namespaced_IRI.parse _namespace_name "sourceOrganization" |> NamespacedName

    /// <summary>
    /// The "spatial" property can be used in cases when more specific properties
    /// (e.g. &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/spatialCoverage"&gt;spatialCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;) are not known to be appropriate.
    /// <see href="http://schema.org/spatial"></see></summary>
    let spatial = Namespaced_IRI.parse _namespace_name "spatial" |> NamespacedName

    /// <summary>
    /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
    ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
    ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
    /// <see href="http://schema.org/spatialCoverage"></see></summary>
    let spatialCoverage =
        Namespaced_IRI.parse _namespace_name "spatialCoverage" |> NamespacedName

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
    let speakable = Namespaced_IRI.parse _namespace_name "speakable" |> NamespacedName

    /// <summary>
    /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
    /// <see href="http://schema.org/specialCommitments"></see></summary>
    let specialCommitments =
        Namespaced_IRI.parse _namespace_name "specialCommitments" |> NamespacedName

    /// <summary>
    /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
    /// <see href="http://schema.org/specialOpeningHoursSpecification"></see></summary>
    let specialOpeningHoursSpecification =
        Namespaced_IRI.parse _namespace_name "specialOpeningHoursSpecification" |> NamespacedName

    /// <summary>
    /// One of the domain specialities to which this web page's content applies.
    /// <see href="http://schema.org/specialty"></see></summary>
    let specialty = Namespaced_IRI.parse _namespace_name "specialty" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/MedicalStudy"></see>
    /// </summary>
    let MedicalStudy =
        Namespaced_IRI.parse _namespace_name "MedicalStudy" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/Grant"></see>
    /// </summary>
    let Grant = Namespaced_IRI.parse _namespace_name "Grant" |> NamespacedName

    /// <summary>
    /// A sub property of location. The sports activity location where this action occurred.
    /// <see href="http://schema.org/sportsActivityLocation"></see></summary>
    let sportsActivityLocation =
        Namespaced_IRI.parse _namespace_name "sportsActivityLocation" |> NamespacedName

    /// <summary>
    /// A sub property of location. The sports event where this action occurred.
    /// <see href="http://schema.org/sportsEvent"></see></summary>
    let sportsEvent =
        Namespaced_IRI.parse _namespace_name "sportsEvent" |> NamespacedName

    /// <summary>
    /// A sub property of participant. The sports team that participated on this action.
    /// <see href="http://schema.org/sportsTeam"></see></summary>
    let sportsTeam = Namespaced_IRI.parse _namespace_name "sportsTeam" |> NamespacedName
    /// <summary>
    /// The person's spouse.
    /// <see href="http://schema.org/spouse"></see></summary>
    let spouse = Namespaced_IRI.parse _namespace_name "spouse" |> NamespacedName
    /// <summary>
    /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
    /// <see href="http://schema.org/starRating"></see></summary>
    let starRating = Namespaced_IRI.parse _namespace_name "starRating" |> NamespacedName
    /// <summary>
    /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
    /// <see href="http://schema.org/startDate"></see></summary>
    let startDate = Namespaced_IRI.parse _namespace_name "startDate" |> NamespacedName
    /// <summary>
    /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
    /// <see href="http://schema.org/startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName

    /// <summary>
    /// The position of the steering wheel or similar device (mostly for cars).
    /// <see href="http://schema.org/steeringPosition"></see></summary>
    let steeringPosition =
        Namespaced_IRI.parse _namespace_name "steeringPosition" |> NamespacedName

    /// <summary>
    /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
    /// <see href="http://schema.org/stepValue"></see></summary>
    let stepValue = Namespaced_IRI.parse _namespace_name "stepValue" |> NamespacedName
    /// <summary>
    /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection (originally misnamed 'steps'; 'step' is preferred).
    /// <see href="http://schema.org/steps"></see></summary>
    let steps = Namespaced_IRI.parse _namespace_name "steps" |> NamespacedName

    /// <summary>
    /// Storage requirements (free space required).
    /// <see href="http://schema.org/storageRequirements"></see></summary>
    let storageRequirements =
        Namespaced_IRI.parse _namespace_name "storageRequirements" |> NamespacedName

    /// <summary>
    /// The street address. For example, 1600 Amphitheatre Pkwy.
    /// <see href="http://schema.org/streetAddress"></see></summary>
    let streetAddress =
        Namespaced_IRI.parse _namespace_name "streetAddress" |> NamespacedName

    /// <summary>
    /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
    /// <see href="http://schema.org/subEvent"></see></summary>
    let subEvent = Namespaced_IRI.parse _namespace_name "subEvent" |> NamespacedName
    /// <summary>
    /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
    /// <see href="http://schema.org/superEvent"></see></summary>
    let superEvent = Namespaced_IRI.parse _namespace_name "superEvent" |> NamespacedName
    /// <summary>
    /// Events that are a part of this event. For example, a conference event includes many presentations, each subEvents of the conference.
    /// <see href="http://schema.org/subEvents"></see></summary>
    let subEvents = Namespaced_IRI.parse _namespace_name "subEvents" |> NamespacedName

    /// <summary>
    /// The individual reservations included in the package. Typically a repeated property.
    /// <see href="http://schema.org/subReservation"></see></summary>
    let subReservation =
        Namespaced_IRI.parse _namespace_name "subReservation" |> NamespacedName

    /// <summary>
    /// A pointer from a newer variant of a product  to its previous, often discontinued predecessor.
    /// <see href="http://schema.org/successorOf"></see></summary>
    let successorOf =
        Namespaced_IRI.parse _namespace_name "successorOf" |> NamespacedName

    /// <summary>
    /// The number of grams of sugar.
    /// <see href="http://schema.org/sugarContent"></see></summary>
    let sugarContent =
        Namespaced_IRI.parse _namespace_name "sugarContent" |> NamespacedName

    /// <summary>
    /// The gender of the person or audience.
    /// <see href="http://schema.org/suggestedGender"></see></summary>
    let suggestedGender =
        Namespaced_IRI.parse _namespace_name "suggestedGender" |> NamespacedName

    /// <summary>
    /// Maximal age recommended for viewing content.
    /// <see href="http://schema.org/suggestedMaxAge"></see></summary>
    let suggestedMaxAge =
        Namespaced_IRI.parse _namespace_name "suggestedMaxAge" |> NamespacedName

    /// <summary>
    /// Minimal age recommended for viewing content.
    /// <see href="http://schema.org/suggestedMinAge"></see></summary>
    let suggestedMinAge =
        Namespaced_IRI.parse _namespace_name "suggestedMinAge" |> NamespacedName

    /// <summary>
    /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
    /// <see href="http://schema.org/suitableForDiet"></see></summary>
    let suitableForDiet =
        Namespaced_IRI.parse _namespace_name "suitableForDiet" |> NamespacedName

    /// <summary>
    /// Supporting data for a SoftwareApplication.
    /// <see href="http://schema.org/supportingData"></see></summary>
    let supportingData =
        Namespaced_IRI.parse _namespace_name "supportingData" |> NamespacedName

    /// <summary>
    /// A material used as a surface in some artwork, e.g. Canvas, Paper, Wood, Board, etc.
    /// <see href="http://schema.org/surface"></see></summary>
    let surface = Namespaced_IRI.parse _namespace_name "surface" |> NamespacedName
    /// <summary>
    /// Indicates a target EntryPoint for an Action.
    /// <see href="http://schema.org/target"></see></summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName

    /// <summary>
    /// The description of a node in an established educational framework.
    /// <see href="http://schema.org/targetDescription"></see></summary>
    let targetDescription =
        Namespaced_IRI.parse _namespace_name "targetDescription" |> NamespacedName

    /// <summary>
    /// The name of a node in an established educational framework.
    /// <see href="http://schema.org/targetName"></see></summary>
    let targetName = Namespaced_IRI.parse _namespace_name "targetName" |> NamespacedName

    /// <summary>
    /// Type of app development: phone, Metro style, desktop, XBox, etc.
    /// <see href="http://schema.org/targetPlatform"></see></summary>
    let targetPlatform =
        Namespaced_IRI.parse _namespace_name "targetPlatform" |> NamespacedName

    /// <summary>
    /// Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.
    /// <see href="http://schema.org/targetProduct"></see></summary>
    let targetProduct =
        Namespaced_IRI.parse _namespace_name "targetProduct" |> NamespacedName

    /// <summary>
    /// The URL of a node in an established educational framework.
    /// <see href="http://schema.org/targetUrl"></see></summary>
    let targetUrl = Namespaced_IRI.parse _namespace_name "targetUrl" |> NamespacedName
    /// <summary>
    /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
    /// <see href="http://schema.org/taxID"></see></summary>
    let taxID = Namespaced_IRI.parse _namespace_name "taxID" |> NamespacedName
    /// <summary>
    /// The telephone number.
    /// <see href="http://schema.org/telephone"></see></summary>
    let telephone = Namespaced_IRI.parse _namespace_name "telephone" |> NamespacedName
    /// <summary>
    /// The "temporal" property can be used in cases where more specific properties
    /// (e.g. &lt;a class="localLink" href="http://schema.org/temporalCoverage"&gt;temporalCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateCreated"&gt;dateCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateModified"&gt;dateModified&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/datePublished"&gt;datePublished&lt;/a&gt;) are not known to be appropriate.
    /// <see href="http://schema.org/temporal"></see></summary>
    let temporal = Namespaced_IRI.parse _namespace_name "temporal" |> NamespacedName
    /// <summary>
    /// The textual content of this CreativeWork.
    /// <see href="http://schema.org/text"></see></summary>
    let text = Namespaced_IRI.parse _namespace_name "text" |> NamespacedName
    /// <summary>
    /// Thumbnail image for an image or video.
    /// <see href="http://schema.org/thumbnail"></see></summary>
    let thumbnail = Namespaced_IRI.parse _namespace_name "thumbnail" |> NamespacedName

    /// <summary>
    /// A thumbnail image relevant to the Thing.
    /// <see href="http://schema.org/thumbnailUrl"></see></summary>
    let thumbnailUrl =
        Namespaced_IRI.parse _namespace_name "thumbnailUrl" |> NamespacedName

    /// <summary>
    /// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we recommend using the controlled vocabulary of Market Identifier Codes (MIC) specified in ISO15022.
    /// <see href="http://schema.org/tickerSymbol"></see></summary>
    let tickerSymbol =
        Namespaced_IRI.parse _namespace_name "tickerSymbol" |> NamespacedName

    /// <summary>
    /// The unique identifier for the ticket.
    /// <see href="http://schema.org/ticketNumber"></see></summary>
    let ticketNumber =
        Namespaced_IRI.parse _namespace_name "ticketNumber" |> NamespacedName

    /// <summary>
    /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
    /// <see href="http://schema.org/ticketToken"></see></summary>
    let ticketToken =
        Namespaced_IRI.parse _namespace_name "ticketToken" |> NamespacedName

    /// <summary>
    /// The seat associated with the ticket.
    /// <see href="http://schema.org/ticketedSeat"></see></summary>
    let ticketedSeat =
        Namespaced_IRI.parse _namespace_name "ticketedSeat" |> NamespacedName

    /// <summary>
    /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'PT30M', 'PT1H25M'.
    /// <see href="http://schema.org/timeRequired"></see></summary>
    let timeRequired =
        Namespaced_IRI.parse _namespace_name "timeRequired" |> NamespacedName

    /// <summary>
    /// The title of the job.
    /// <see href="http://schema.org/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// A sub property of location. The final location of the object or the agent after the action.
    /// <see href="http://schema.org/toLocation"></see></summary>
    let toLocation = Namespaced_IRI.parse _namespace_name "toLocation" |> NamespacedName

    /// <summary>
    /// A sub property of recipient. The recipient who was directly sent the message.
    /// <see href="http://schema.org/toRecipient"></see></summary>
    let toRecipient =
        Namespaced_IRI.parse _namespace_name "toRecipient" |> NamespacedName

    /// <summary>
    /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
    /// <see href="http://schema.org/tool"></see></summary>
    let tool = Namespaced_IRI.parse _namespace_name "tool" |> NamespacedName

    /// <summary>
    /// The total amount due.
    /// <see href="http://schema.org/totalPaymentDue"></see></summary>
    let totalPaymentDue =
        Namespaced_IRI.parse _namespace_name "totalPaymentDue" |> NamespacedName

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
    let totalPrice = Namespaced_IRI.parse _namespace_name "totalPrice" |> NamespacedName
    /// <summary>
    /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
    /// <see href="http://schema.org/totalTime"></see></summary>
    let totalTime = Namespaced_IRI.parse _namespace_name "totalTime" |> NamespacedName

    /// <summary>
    /// Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.
    /// <see href="http://schema.org/touristType"></see></summary>
    let touristType =
        Namespaced_IRI.parse _namespace_name "touristType" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/TouristDestination"></see>
    /// </summary>
    let TouristDestination =
        Namespaced_IRI.parse _namespace_name "TouristDestination" |> NamespacedName

    /// <summary>
    ///   <see href="http://schema.org/TouristTrip"></see>
    /// </summary>
    let TouristTrip =
        Namespaced_IRI.parse _namespace_name "TouristTrip" |> NamespacedName

    /// <summary>
    /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
    /// <see href="http://schema.org/track"></see></summary>
    let track = Namespaced_IRI.parse _namespace_name "track" |> NamespacedName

    /// <summary>
    /// Shipper tracking number.
    /// <see href="http://schema.org/trackingNumber"></see></summary>
    let trackingNumber =
        Namespaced_IRI.parse _namespace_name "trackingNumber" |> NamespacedName

    /// <summary>
    /// Tracking url for the parcel delivery.
    /// <see href="http://schema.org/trackingUrl"></see></summary>
    let trackingUrl =
        Namespaced_IRI.parse _namespace_name "trackingUrl" |> NamespacedName

    /// <summary>
    /// A music recording (track)&amp;#x2014;usually a single song.
    /// <see href="http://schema.org/tracks"></see></summary>
    let tracks = Namespaced_IRI.parse _namespace_name "tracks" |> NamespacedName
    /// <summary>
    /// The trailer of a movie or tv/radio series, season, episode, etc.
    /// <see href="http://schema.org/trailer"></see></summary>
    let trailer = Namespaced_IRI.parse _namespace_name "trailer" |> NamespacedName
    /// <summary>
    /// The name of the train (e.g. The Orient Express).
    /// <see href="http://schema.org/trainName"></see></summary>
    let trainName = Namespaced_IRI.parse _namespace_name "trainName" |> NamespacedName

    /// <summary>
    /// The unique identifier for the train.
    /// <see href="http://schema.org/trainNumber"></see></summary>
    let trainNumber =
        Namespaced_IRI.parse _namespace_name "trainNumber" |> NamespacedName

    /// <summary>
    /// The number of grams of trans fat.
    /// <see href="http://schema.org/transFatContent"></see></summary>
    let transFatContent =
        Namespaced_IRI.parse _namespace_name "transFatContent" |> NamespacedName

    /// <summary>
    /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
    /// <see href="http://schema.org/transcript"></see></summary>
    let transcript = Namespaced_IRI.parse _namespace_name "transcript" |> NamespacedName
    /// <summary>
    /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
    /// <see href="http://schema.org/translator"></see></summary>
    let translator = Namespaced_IRI.parse _namespace_name "translator" |> NamespacedName
    /// <summary>
    /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
    /// <see href="http://schema.org/typeOfBed"></see></summary>
    let typeOfBed = Namespaced_IRI.parse _namespace_name "typeOfBed" |> NamespacedName
    /// <summary>
    /// The product that this structured value is referring to.
    /// <see href="http://schema.org/typeOfGood"></see></summary>
    let typeOfGood = Namespaced_IRI.parse _namespace_name "typeOfGood" |> NamespacedName

    /// <summary>
    /// The typical expected age range, e.g. '7-9', '11-'.
    /// <see href="http://schema.org/typicalAgeRange"></see></summary>
    let typicalAgeRange =
        Namespaced_IRI.parse _namespace_name "typicalAgeRange" |> NamespacedName

    /// <summary>
    /// The person or organization the reservation or ticket is for.
    /// <see href="http://schema.org/underName"></see></summary>
    let underName = Namespaced_IRI.parse _namespace_name "underName" |> NamespacedName
    /// <summary>
    /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
    /// <see href="http://schema.org/unitCode"></see></summary>
    let unitCode = Namespaced_IRI.parse _namespace_name "unitCode" |> NamespacedName
    /// <summary>
    /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
    /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
    /// <see href="http://schema.org/unitText"></see></summary>
    let unitText = Namespaced_IRI.parse _namespace_name "unitText" |> NamespacedName

    /// <summary>
    /// The number of grams of unsaturated fat.
    /// <see href="http://schema.org/unsaturatedFatContent"></see></summary>
    let unsaturatedFatContent =
        Namespaced_IRI.parse _namespace_name "unsaturatedFatContent" |> NamespacedName

    /// <summary>
    /// Date when this media object was uploaded to this site.
    /// <see href="http://schema.org/uploadDate"></see></summary>
    let uploadDate = Namespaced_IRI.parse _namespace_name "uploadDate" |> NamespacedName

    /// <summary>
    /// The number of upvotes this question, answer or comment has received from the community.
    /// <see href="http://schema.org/upvoteCount"></see></summary>
    let upvoteCount =
        Namespaced_IRI.parse _namespace_name "upvoteCount" |> NamespacedName

    /// <summary>
    /// URL of the item.
    /// <see href="http://schema.org/url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName

    /// <summary>
    /// An url template (RFC6570) that will be used to construct the target of the execution of the action.
    /// <see href="http://schema.org/urlTemplate"></see></summary>
    let urlTemplate =
        Namespaced_IRI.parse _namespace_name "urlTemplate" |> NamespacedName

    /// <summary>
    /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
    /// <see href="http://schema.org/userInteractionCount"></see></summary>
    let userInteractionCount =
        Namespaced_IRI.parse _namespace_name "userInteractionCount" |> NamespacedName

    /// <summary>
    /// The duration of validity of a permit or similar thing.
    /// <see href="http://schema.org/validFor"></see></summary>
    let validFor = Namespaced_IRI.parse _namespace_name "validFor" |> NamespacedName
    /// <summary>
    /// The date when the item becomes valid.
    /// <see href="http://schema.org/validFrom"></see></summary>
    let validFrom = Namespaced_IRI.parse _namespace_name "validFrom" |> NamespacedName
    /// <summary>
    /// The geographic area where a permit or similar thing is valid.
    /// <see href="http://schema.org/validIn"></see></summary>
    let validIn = Namespaced_IRI.parse _namespace_name "validIn" |> NamespacedName

    /// <summary>
    /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
    /// <see href="http://schema.org/validThrough"></see></summary>
    let validThrough =
        Namespaced_IRI.parse _namespace_name "validThrough" |> NamespacedName

    /// <summary>
    /// The date when the item is no longer valid.
    /// <see href="http://schema.org/validUntil"></see></summary>
    let validUntil = Namespaced_IRI.parse _namespace_name "validUntil" |> NamespacedName
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
    let value = Namespaced_IRI.parse _namespace_name "value" |> NamespacedName

    /// <summary>
    /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
    /// <see href="http://schema.org/valueAddedTaxIncluded"></see></summary>
    let valueAddedTaxIncluded =
        Namespaced_IRI.parse _namespace_name "valueAddedTaxIncluded" |> NamespacedName

    /// <summary>
    /// Specifies the allowed range for number of characters in a literal value.
    /// <see href="http://schema.org/valueMaxLength"></see></summary>
    let valueMaxLength =
        Namespaced_IRI.parse _namespace_name "valueMaxLength" |> NamespacedName

    /// <summary>
    /// Specifies the minimum allowed range for number of characters in a literal value.
    /// <see href="http://schema.org/valueMinLength"></see></summary>
    let valueMinLength =
        Namespaced_IRI.parse _namespace_name "valueMinLength" |> NamespacedName

    /// <summary>
    /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
    /// <see href="http://schema.org/valueName"></see></summary>
    let valueName = Namespaced_IRI.parse _namespace_name "valueName" |> NamespacedName

    /// <summary>
    /// Specifies a regular expression for testing literal values according to the HTML spec.
    /// <see href="http://schema.org/valuePattern"></see></summary>
    let valuePattern =
        Namespaced_IRI.parse _namespace_name "valuePattern" |> NamespacedName

    /// <summary>
    /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
    /// <see href="http://schema.org/valueReference"></see></summary>
    let valueReference =
        Namespaced_IRI.parse _namespace_name "valueReference" |> NamespacedName

    /// <summary>
    /// Whether the property must be filled in to complete the action.  Default is false.
    /// <see href="http://schema.org/valueRequired"></see></summary>
    let valueRequired =
        Namespaced_IRI.parse _namespace_name "valueRequired" |> NamespacedName

    /// <summary>
    /// The Value-added Tax ID of the organization or person.
    /// <see href="http://schema.org/vatID"></see></summary>
    let vatID = Namespaced_IRI.parse _namespace_name "vatID" |> NamespacedName

    /// <summary>
    /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
    /// <see href="http://schema.org/vehicleConfiguration"></see></summary>
    let vehicleConfiguration =
        Namespaced_IRI.parse _namespace_name "vehicleConfiguration" |> NamespacedName

    /// <summary>
    /// Information about the engine or engines of the vehicle.
    /// <see href="http://schema.org/vehicleEngine"></see></summary>
    let vehicleEngine =
        Namespaced_IRI.parse _namespace_name "vehicleEngine" |> NamespacedName

    /// <summary>
    /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
    /// <see href="http://schema.org/vehicleIdentificationNumber"></see></summary>
    let vehicleIdentificationNumber =
        Namespaced_IRI.parse _namespace_name "vehicleIdentificationNumber" |> NamespacedName

    /// <summary>
    /// The color or color combination of the interior of the vehicle.
    /// <see href="http://schema.org/vehicleInteriorColor"></see></summary>
    let vehicleInteriorColor =
        Namespaced_IRI.parse _namespace_name "vehicleInteriorColor" |> NamespacedName

    /// <summary>
    /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
    /// <see href="http://schema.org/vehicleInteriorType"></see></summary>
    let vehicleInteriorType =
        Namespaced_IRI.parse _namespace_name "vehicleInteriorType" |> NamespacedName

    /// <summary>
    /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
    /// <see href="http://schema.org/vehicleModelDate"></see></summary>
    let vehicleModelDate =
        Namespaced_IRI.parse _namespace_name "vehicleModelDate" |> NamespacedName

    /// <summary>
    /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62 for persons.
    /// <see href="http://schema.org/vehicleSeatingCapacity"></see></summary>
    let vehicleSeatingCapacity =
        Namespaced_IRI.parse _namespace_name "vehicleSeatingCapacity" |> NamespacedName

    /// <summary>
    /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
    /// <see href="http://schema.org/vehicleTransmission"></see></summary>
    let vehicleTransmission =
        Namespaced_IRI.parse _namespace_name "vehicleTransmission" |> NamespacedName

    /// <summary>
    /// 'vendor' is an earlier term for 'seller'.
    /// <see href="http://schema.org/vendor"></see></summary>
    let vendor = Namespaced_IRI.parse _namespace_name "vendor" |> NamespacedName
    /// <summary>
    /// The version of the CreativeWork embodied by a specified resource.
    /// <see href="http://schema.org/version"></see></summary>
    let version = Namespaced_IRI.parse _namespace_name "version" |> NamespacedName
    /// <summary>
    /// An embedded video object.
    /// <see href="http://schema.org/video"></see></summary>
    let video = Namespaced_IRI.parse _namespace_name "video" |> NamespacedName

    /// <summary>
    /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
    /// <see href="http://schema.org/videoFormat"></see></summary>
    let videoFormat =
        Namespaced_IRI.parse _namespace_name "videoFormat" |> NamespacedName

    /// <summary>
    /// The frame size of the video.
    /// <see href="http://schema.org/videoFrameSize"></see></summary>
    let videoFrameSize =
        Namespaced_IRI.parse _namespace_name "videoFrameSize" |> NamespacedName

    /// <summary>
    /// The quality of the video.
    /// <see href="http://schema.org/videoQuality"></see></summary>
    let videoQuality =
        Namespaced_IRI.parse _namespace_name "videoQuality" |> NamespacedName

    /// <summary>
    /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
    /// <see href="http://schema.org/volumeNumber"></see></summary>
    let volumeNumber =
        Namespaced_IRI.parse _namespace_name "volumeNumber" |> NamespacedName

    /// <summary>
    /// The warranty promise(s) included in the offer.
    /// <see href="http://schema.org/warranty"></see></summary>
    let warranty = Namespaced_IRI.parse _namespace_name "warranty" |> NamespacedName

    /// <summary>
    /// The warranty promise(s) included in the offer.
    /// <see href="http://schema.org/warrantyPromise"></see></summary>
    let warrantyPromise =
        Namespaced_IRI.parse _namespace_name "warrantyPromise" |> NamespacedName

    /// <summary>
    /// The scope of the warranty promise.
    /// <see href="http://schema.org/warrantyScope"></see></summary>
    let warrantyScope =
        Namespaced_IRI.parse _namespace_name "warrantyScope" |> NamespacedName

    /// <summary>
    /// The time when a passenger can check into the flight online.
    /// <see href="http://schema.org/webCheckinTime"></see></summary>
    let webCheckinTime =
        Namespaced_IRI.parse _namespace_name "webCheckinTime" |> NamespacedName

    /// <summary>
    /// The weight of the product or person.
    /// <see href="http://schema.org/weight"></see></summary>
    let weight = Namespaced_IRI.parse _namespace_name "weight" |> NamespacedName
    /// <summary>
    /// The width of the item.
    /// <see href="http://schema.org/width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
    /// <summary>
    /// A sub property of participant. The winner of the action.
    /// <see href="http://schema.org/winner"></see></summary>
    let winner = Namespaced_IRI.parse _namespace_name "winner" |> NamespacedName
    /// <summary>
    /// The number of words in the text of the Article.
    /// <see href="http://schema.org/wordCount"></see></summary>
    let wordCount = Namespaced_IRI.parse _namespace_name "wordCount" |> NamespacedName

    /// <summary>
    /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
    ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
    /// <see href="http://schema.org/workFeatured"></see></summary>
    let workFeatured =
        Namespaced_IRI.parse _namespace_name "workFeatured" |> NamespacedName

    /// <summary>
    /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
    /// <see href="http://schema.org/workHours"></see></summary>
    let workHours = Namespaced_IRI.parse _namespace_name "workHours" |> NamespacedName

    /// <summary>
    /// A contact location for a person's place of work.
    /// <see href="http://schema.org/workLocation"></see></summary>
    let workLocation =
        Namespaced_IRI.parse _namespace_name "workLocation" |> NamespacedName

    /// <summary>
    /// A work performed in some event, for example a play performed in a TheaterEvent.
    /// <see href="http://schema.org/workPerformed"></see></summary>
    let workPerformed =
        Namespaced_IRI.parse _namespace_name "workPerformed" |> NamespacedName

    /// <summary>
    /// The movie presented during this event.
    /// <see href="http://schema.org/workPresented"></see></summary>
    let workPresented =
        Namespaced_IRI.parse _namespace_name "workPresented" |> NamespacedName

    /// <summary>
    /// Organizations that the person works for.
    /// <see href="http://schema.org/worksFor"></see></summary>
    let worksFor = Namespaced_IRI.parse _namespace_name "worksFor" |> NamespacedName

    /// <summary>
    /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
    /// <see href="http://schema.org/worstRating"></see></summary>
    let worstRating =
        Namespaced_IRI.parse _namespace_name "worstRating" |> NamespacedName

    /// <summary>
    /// An XPath, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
    /// <see href="http://schema.org/xpath"></see></summary>
    let xpath = Namespaced_IRI.parse _namespace_name "xpath" |> NamespacedName
    /// <summary>
    ///   <see href="http://schema.org/XPathType"></see>
    /// </summary>
    let XPathType = Namespaced_IRI.parse _namespace_name "XPathType" |> NamespacedName

    /// <summary>
    /// The size of the business in annual revenue.
    /// <see href="http://schema.org/yearlyRevenue"></see></summary>
    let yearlyRevenue =
        Namespaced_IRI.parse _namespace_name "yearlyRevenue" |> NamespacedName

    /// <summary>
    /// The age of the business.
    /// <see href="http://schema.org/yearsInOperation"></see></summary>
    let yearsInOperation =
        Namespaced_IRI.parse _namespace_name "yearsInOperation" |> NamespacedName
