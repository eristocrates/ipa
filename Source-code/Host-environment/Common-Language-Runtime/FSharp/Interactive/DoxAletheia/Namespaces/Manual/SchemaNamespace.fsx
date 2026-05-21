#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module schema =

    let _prefix = prefix_label "schema"

    
    let Audiobook = _prefix "Audiobook"
          

    
    let Chapter = _prefix "Chapter"
          

    
    let CssSelectorType = _prefix "CssSelectorType"
          

    
    let DefinedTerm = _prefix "DefinedTerm"
          

    
    let DietarySupplement = _prefix "DietarySupplement"
          

    
    let Drug = _prefix "Drug"
          

    
    let EducationalOccupationalCredential = _prefix "EducationalOccupationalCredential"
          

    
    let EducationalOccupationalProgram = _prefix "EducationalOccupationalProgram"
          

    
    let ExchangeRateSpecification = _prefix "ExchangeRateSpecification"
          

    
    let FloorPlan = _prefix "FloorPlan"
          

    
    let GeospatialGeometry = _prefix "GeospatialGeometry"
          

    
    let Grant = _prefix "Grant"
          

    
    let Guide = _prefix "Guide"
          

    
    let HealthInsurancePlan = _prefix "HealthInsurancePlan"
          

    
    let LinkRole = _prefix "LinkRole"
          

    
    let MedicalBusiness = _prefix "MedicalBusiness"
          

    
    let MedicalStudy = _prefix "MedicalStudy"
          

    
    let MonetaryGrant = _prefix "MonetaryGrant"
          

    
    let MoneyTransfer = _prefix "MoneyTransfer"
          

    
    let PhysicalActivity = _prefix "PhysicalActivity"
          

    
    let PhysicalActivityCategory = _prefix "PhysicalActivityCategory"
          

    
    let PronounceableText = _prefix "PronounceableText"
          

    
    let RealEstateListing = _prefix "RealEstateListing"
          

    
    let Recommendation = _prefix "Recommendation"
          

    
    let Schedule = _prefix "Schedule"
          

    
    let SpecialAnnouncement = _prefix "SpecialAnnouncement"
          

    
    let TouristDestination = _prefix "TouristDestination"
          

    
    let TouristTrip = _prefix "TouristTrip"
          

    
    let VirtualLocation = _prefix "VirtualLocation"
          

    
    let XPathType = _prefix "XPathType"
          

    
    let domainIncludes = _prefix "domainIncludes"
          

    
    let gtin = _prefix "gtin"
          

    
    let inverseOf = _prefix "inverseOf"
          

    
    let rangeIncludes = _prefix "rangeIncludes"
          

    
    let supersededBy = _prefix "supersededBy"
          

    /// 'bookingAgent' is an out-dated term indicating a 'broker' that serves as a booking agent.
    let bookingAgent = _prefix "bookingAgent"
          

    /// 'carrier' is an out-dated term indicating the 'provider' for parcel delivery and flights.
    let carrier = _prefix "carrier"
          

    /// 'merchant' is an out-dated term for 'seller'.
    let merchant = _prefix "merchant"
          

    /// 'vendor' is an earlier term for 'seller'.
    let vendor = _prefix "vendor"
          

    /// A (typically single) geographic location associated with the job position.
    let jobLocation = _prefix "jobLocation"
          

    /// A <a class="localLink" href="http://schema.org/CampingPitch">CampingPitch</a> is an individual place for overnight stay in the outdoors, typically being part of a larger camping site, or <a class="localLink" href="http://schema.org/Campground">Campground</a>.<br/><br/>
/// 
/// In British English a campsite, or campground, is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites.
/// (Source: Wikipedia see <a href="https://en.wikipedia.org/wiki/Campsite">https://en.wikipedia.org/wiki/Campsite</a>).<br/><br/>
/// 
/// See also the dedicated <a href="/docs/hotels.html">document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let CampingPitch = _prefix "CampingPitch"
          

    /// A <a class="localLink" href="http://schema.org/FAQPage">FAQPage</a> is a <a class="localLink" href="http://schema.org/WebPage">WebPage</a> presenting one or more "<a href="https://en.wikipedia.org/wiki/FAQ">Frequently asked questions</a>" (see also <a class="localLink" href="http://schema.org/QAPage">QAPage</a>).
    let FAQPage = _prefix "FAQPage"
          

    /// A <a href="https://en.wikipedia.org/wiki/Dateline">dateline</a> is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.<br/><br/>
/// 
/// Structured representations of dateline-related information can also be expressed more explicitly using <a class="localLink" href="http://schema.org/locationCreated">locationCreated</a> (which represents where a work was created e.g. where a news report was written).  For location depicted or described in the content, use <a class="localLink" href="http://schema.org/contentLocation">contentLocation</a>.<br/><br/>
/// 
/// Dateline summaries are oriented more towards human readers than towards automated processing, and can vary substantially. Some examples: "BEIRUT, Lebanon, June 2.", "Paris, France", "December 19, 2017 11:43AM Reporting from Washington", "Beijing/Moscow", "QUEZON CITY, Philippines".
    let dateline = _prefix "dateline"
          

    /// A BreadcrumbList is an ItemList consisting of a chain of linked Web pages, typically described using at least their URL and their name, and typically ending with the current page.<br/><br/>
/// 
/// The <a class="localLink" href="http://schema.org/position">position</a> property is used to reconstruct the order of the items in a BreadcrumbList The convention is that a breadcrumb list has an <a class="localLink" href="http://schema.org/itemListOrder">itemListOrder</a> of <a class="localLink" href="http://schema.org/ItemListOrderAscending">ItemListOrderAscending</a> (lower values listed first), and that the first items in this list correspond to the "top" or beginning of the breadcrumb trail, e.g. with a site or section homepage. The specific values of 'position' are not assigned meaning for a BreadcrumbList, but they should be integers, e.g. beginning with '1' for the first item in the list.
    let BreadcrumbList = _prefix "BreadcrumbList"
          

    /// A Buddhist temple.
    let BuddhistTemple = _prefix "BuddhistTemple"
          

    /// A CSS selector, e.g. of a <a class="localLink" href="http://schema.org/SpeakableSpecification">SpeakableSpecification</a> or <a class="localLink" href="http://schema.org/WebPageElement">WebPageElement</a>. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
    let cssSelector = _prefix "cssSelector"
          

    /// A Catholic church.
    let CatholicChurch = _prefix "CatholicChurch"
          

    /// A Childcare center.
    let ChildCare = _prefix "ChildCare"
          

    /// A CreativeWork attached to the message.
    let messageAttachment = _prefix "messageAttachment"
          

    /// A CreativeWork or Event about this Thing.
    let subjectOf = _prefix "subjectOf"
          

    /// A CreativeWork such as an image, video, or audio clip shared as part of this posting.
    let sharedContent = _prefix "sharedContent"
          

    /// A CreativeWorkSeries in schema.org is a group of related items, typically but not necessarily of the same kind. CreativeWorkSeries are usually organized into some order, often chronological. Unlike <a class="localLink" href="http://schema.org/ItemList">ItemList</a> which is a general purpose data structure for lists of things, the emphasis with CreativeWorkSeries is on published materials (written e.g. books and periodicals, or media such as tv, radio and games).<br/><br/>
/// 
/// Specific subtypes are available for describing <a class="localLink" href="http://schema.org/TVSeries">TVSeries</a>, <a class="localLink" href="http://schema.org/RadioSeries">RadioSeries</a>, <a class="localLink" href="http://schema.org/MovieSeries">MovieSeries</a>, <a class="localLink" href="http://schema.org/BookSeries">BookSeries</a>, <a class="localLink" href="http://schema.org/Periodical">Periodical</a> and <a class="localLink" href="http://schema.org/VideoGameSeries">VideoGameSeries</a>. In each case, the <a class="localLink" href="http://schema.org/hasPart">hasPart</a> / <a class="localLink" href="http://schema.org/isPartOf">isPartOf</a> properties can be used to relate the CreativeWorkSeries to its parts. The general CreativeWorkSeries type serves largely just to organize these more specific and practical subtypes.<br/><br/>
/// 
/// It is common for properties applicable to an item from the series to be usefully applied to the containing group. Schema.org attempts to anticipate some of these cases, but publishers should be free to apply properties of the series parts to the series as a whole wherever they seem appropriate.
    let CreativeWorkSeries = _prefix "CreativeWorkSeries"
          

    /// A DatedMoneySpecification represents monetary values with optional start and end dates. For example, this could represent an employee's salary over a specific period of time. <strong>Note:</strong> This type has been superseded by <a class="localLink" href="http://schema.org/MonetaryAmount">MonetaryAmount</a> use of that type is recommended
    let DatedMoneySpecification = _prefix "DatedMoneySpecification"
          

    /// A DeliveryMethod in which an item is collected on site, e.g. in a store or at a box office.
    let OnSitePickup = _prefix "OnSitePickup"
          

    /// A DeliveryMethod in which an item is made available via locker.
    let LockerDelivery = _prefix "LockerDelivery"
          

    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    let GeoCircle = _prefix "GeoCircle"
          

    /// A Hindu temple.
    let HinduTemple = _prefix "HinduTemple"
          

    /// A LegalService is a business that provides legally-oriented services, advice and representation, e.g. law firms.<br/><br/>
/// 
/// As a <a class="localLink" href="http://schema.org/LocalBusiness">LocalBusiness</a> it can be described as a <a class="localLink" href="http://schema.org/provider">provider</a> of one or more <a class="localLink" href="http://schema.org/Service">Service</a>(s).
    let LegalService = _prefix "LegalService"
          

    /// A MusicRelease is a specific release of a music album.
    let MusicRelease = _prefix "MusicRelease"
          

    /// A NewsArticle associated with the Media Object.
    let associatedArticle = _prefix "associatedArticle"
          

    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.<br/><br/>
/// 
/// A more detailed overview of <a href="/docs/news.html">schema.org News markup</a> is also available.
    let NewsArticle = _prefix "NewsArticle"
          

    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    let PerformanceRole = _prefix "PerformanceRole"
          

    /// A Property value specification.
    let PropertyValueSpecification = _prefix "PropertyValueSpecification"
          

    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    let PublicationEvent = _prefix "PublicationEvent"
          

    /// A QAPage is a WebPage focussed on a specific Question and its Answer(s), e.g. in a question answering site or documenting Frequently Asked Questions (FAQs).
    let QAPage = _prefix "QAPage"
          

    /// A Report generated by governmental or non-governmental organization.
    let Report = _prefix "Report"
          

    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also <a class="localLink" href="http://schema.org/CreativeWorkSeries">CreativeWorkSeries</a>, <a class="localLink" href="http://schema.org/EventSeries">EventSeries</a>.
    let Series = _prefix "Series"
          

    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    let PaymentService = _prefix "PaymentService"
          

    /// A SpeakableSpecification indicates (typically via <a class="localLink" href="http://schema.org/xpath">xpath</a> or <a class="localLink" href="http://schema.org/cssSelector">cssSelector</a>) sections of a document that are highlighted as particularly <a class="localLink" href="http://schema.org/speakable">speakable</a>. Instances of this type are expected to be used primarily as values of the <a class="localLink" href="http://schema.org/speakable">speakable</a> property.
    let SpeakableSpecification = _prefix "SpeakableSpecification"
          

    /// A TV episode which can be part of a series or season.
    let TVEpisode = _prefix "TVEpisode"
          

    /// A URL pointing to a player for a specific video. In general, this is the information in the <code>src</code> element of an <code>embed</code> tag and should not be the same as the content of the <code>loc</code> tag.
    let embedUrl = _prefix "embedUrl"
          

    /// A URL to a map of the place.
    let hasMap = _prefix "hasMap"
          

    /// A URL to a map of the place.
    let map = _prefix "map"
          

    /// A URL to a map of the place.
    let maps = _prefix "maps"
          

    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    let WebSite = _prefix "WebSite"
          

    /// A Workers Union (also known as a Labor Union, Labour Union, or Trade Union) is an organization that promotes the interests of its worker members by collectively bargaining with management, organizing, and political lobbying.
    let WorkersUnion = _prefix "WorkersUnion"
          

    /// A bakery.
    let Bakery = _prefix "Bakery"
          

    /// A bar or pub.
    let BarOrPub = _prefix "BarOrPub"
          

    /// A bike store.
    let BikeStore = _prefix "BikeStore"
          

    /// A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    let LiveBlogPosting = _prefix "LiveBlogPosting"
          

    /// A blog post.
    let BlogPosting = _prefix "BlogPosting"
          

    /// A blog.
    let Blog = _prefix "Blog"
          

    /// A body of structured information describing some topic(s) of interest.
    let Dataset = _prefix "Dataset"
          

    /// A body of water, such as a sea, ocean, or lake.
    let BodyOfWater = _prefix "BodyOfWater"
          

    /// A book.
    let Book = _prefix "Book"
          

    /// A bookstore.
    let BookStore = _prefix "BookStore"
          

    /// A bowling alley.
    let BowlingAlley = _prefix "BowlingAlley"
          

    /// A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.
    let box = _prefix "box"
          

    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    let Brand = _prefix "Brand"
          

    /// A bridge.
    let Bridge = _prefix "Bridge"
          

    /// A broadcast channel of a broadcast service.
    let hasBroadcastChannel = _prefix "hasBroadcastChannel"
          

    /// A broadcast service associated with the publication event.
    let publishedOn = _prefix "publishedOn"
          

    /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
    let parentService = _prefix "parentService"
          

    /// A bus station.
    let BusStation = _prefix "BusStation"
          

    /// A bus stop.
    let BusStop = _prefix "BusStop"
          

    /// A business entity type is a conceptual entity representing the legal form, the size, the main line of business, the position in the value chain, or any combination thereof, of an organization or business person.<br/><br/>
/// 
/// Commonly used values:<br/><br/>
/// 
/// <ul>
/// <li>http://purl.org/goodrelations/v1#Business</li>
/// <li>http://purl.org/goodrelations/v1#Enduser</li>
/// <li>http://purl.org/goodrelations/v1#PublicInstitution</li>
/// <li>http://purl.org/goodrelations/v1#Reseller</li>
/// </ul>
/// 
    let BusinessEntityType = _prefix "BusinessEntityType"
          

    /// A business providing entertainment.
    let EntertainmentBusiness = _prefix "EntertainmentBusiness"
          

    /// A business that provide Heating, Ventilation and Air Conditioning services.
    let HVACBusiness = _prefix "HVACBusiness"
          

    /// A cafe or coffee shop.
    let CafeOrCoffeeShop = _prefix "CafeOrCoffeeShop"
          

    /// A camping site, campsite, or <a class="localLink" href="http://schema.org/Campground">Campground</a> is a place used for overnight stay in the outdoors, typically containing individual <a class="localLink" href="http://schema.org/CampingPitch">CampingPitch</a> locations. <br/><br/>
/// 
/// In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites (Source: Wikipedia see <a href="https://en.wikipedia.org/wiki/Campsite">https://en.wikipedia.org/wiki/Campsite</a>).<br/><br/>
/// 
/// See also the dedicated <a href="/docs/hotels.html">document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let Campground = _prefix "Campground"
          

    /// A canal, like the Panama Canal.
    let Canal = _prefix "Canal"
          

    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    let Car = _prefix "Car"
          

    /// A car rental business.
    let AutoRental = _prefix "AutoRental"
          

    /// A car wash business.
    let AutoWash = _prefix "AutoWash"
          

    /// A card payment method of a particular brand or name.  Used to mark up a particular payment method and/or the financial product/service that supplies the card account.<br/><br/>
/// 
/// Commonly used values:<br/><br/>
/// 
/// <ul>
/// <li>http://purl.org/goodrelations/v1#AmericanExpress</li>
/// <li>http://purl.org/goodrelations/v1#DinersClub</li>
/// <li>http://purl.org/goodrelations/v1#Discover</li>
/// <li>http://purl.org/goodrelations/v1#JCB</li>
/// <li>http://purl.org/goodrelations/v1#MasterCard</li>
/// <li>http://purl.org/goodrelations/v1#VISA</li>
/// </ul>
/// 
    let CreditCard = _prefix "CreditCard"
          

    /// A casino.
    let Casino = _prefix "Casino"
          

    /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
    let category = _prefix "category"
          

    /// A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 'educationalSubject', and 'educationalLevel'.
    let alignmentType = _prefix "alignmentType"
          

    /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (<a href="http://www.w3.org/wiki/WebSchemas/Accessibility">WebSchemas wiki lists possible values</a>).
    let accessibilityHazard = _prefix "accessibilityHazard"
          

    /// A child of the person.
    let children = _prefix "children"
          

    /// A church.
    let Church = _prefix "Church"
          

    /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
    let circle = _prefix "circle"
          

    /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
    let citation = _prefix "citation"
          

    /// A city hall.
    let CityHall = _prefix "CityHall"
          

    /// A city or town.
    let City = _prefix "City"
          

    /// A clothing store.
    let ClothingStore = _prefix "ClothingStore"
          

    /// A colleague of the person.
    let colleague = _prefix "colleague"
          

    /// A colleague of the person.
    let colleagues = _prefix "colleagues"
          

    /// A collection of datasets.
    let DataCatalog = _prefix "DataCatalog"
          

    /// A collection of music albums.
    let albums = _prefix "albums"
          

    /// A collection of music tracks in playlist form.
    let MusicPlaylist = _prefix "MusicPlaylist"
          

    /// A collection of music tracks.
    let MusicAlbum = _prefix "MusicAlbum"
          

    /// A college, university, or other third-level educational institution.
    let CollegeOrUniversity = _prefix "CollegeOrUniversity"
          

    /// A combination of date and time of day in the form [-]CCYY-MM-DDThh:mm:ss[Z|(+|-)hh:mm] (see Chapter 5.4 of ISO 8601).
    let DateTime = _prefix "DateTime"
          

    /// A comedy club.
    let ComedyClub = _prefix "ComedyClub"
          

    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the <a class="localLink" href="http://schema.org/text">text</a> property, and its topic via <a class="localLink" href="http://schema.org/about">about</a>, properties shared with all CreativeWorks.
    let Comment = _prefix "Comment"
          

    /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
/// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
/// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
/// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
    let propertyID = _prefix "propertyID"
          

    /// A competitor in a sports event.
    let competitor = _prefix "competitor"
          

    /// A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use the name property of the attached unit price specification for indicating the dimension of a price component (e.g. "electricity" or "final cleaning").
    let CompoundPriceSpecification = _prefix "CompoundPriceSpecification"
          

    /// A computer store.
    let ComputerStore = _prefix "ComputerStore"
          

    /// A construction business.<br/><br/>
/// 
/// A HomeAndConstructionBusiness is a <a class="localLink" href="http://schema.org/LocalBusiness">LocalBusiness</a> that provides services around homes and buildings.<br/><br/>
/// 
/// As a <a class="localLink" href="http://schema.org/LocalBusiness">LocalBusiness</a> it can be described as a <a class="localLink" href="http://schema.org/provider">provider</a> of one or more <a class="localLink" href="http://schema.org/Service">Service</a>(s).
    let HomeAndConstructionBusiness = _prefix "HomeAndConstructionBusiness"
          

    /// A contact location for a person's place of work.
    let workLocation = _prefix "workLocation"
          

    /// A contact location for a person's residence.
    let homeLocation = _prefix "homeLocation"
          

    /// A contact point for a person or organization.
    let contactPoint = _prefix "contactPoint"
          

    /// A contact point for a person or organization.
    let contactPoints = _prefix "contactPoints"
          

    /// A contact point&#x2014;for example, a Customer Complaints department.
    let ContactPoint = _prefix "ContactPoint"
          

    /// A convenience store.
    let ConvenienceStore = _prefix "ConvenienceStore"
          

    /// A country.
    let Country = _prefix "Country"
          

    /// A courthouse.
    let Courthouse = _prefix "Courthouse"
          

    /// A creative work that this work is an example/instance/realization/derivation of.
    let exampleOfWork = _prefix "exampleOfWork"
          

    /// A crematorium.
    let Crematorium = _prefix "Crematorium"
          

    /// A dance group&#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    let DanceGroup = _prefix "DanceGroup"
          

    /// A data catalog which contains this dataset (this property was previously 'catalog', preferred name is now 'includedInDataCatalog').
    let includedDataCatalog = _prefix "includedDataCatalog"
          

    /// A data catalog which contains this dataset.
    let catalog = _prefix "catalog"
          

    /// A data catalog which contains this dataset.
    let includedInDataCatalog = _prefix "includedInDataCatalog"
          

    /// A dataset contained in this catalog.
    let dataset = _prefix "dataset"
          

    /// A dataset in downloadable form.
    let DataDownload = _prefix "DataDownload"
          

    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    let ProductModel = _prefix "ProductModel"
          

    /// A date value in <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 date format</a>.
    let Date = _prefix "Date"
          

    /// A day spa.
    let DaySpa = _prefix "DaySpa"
          

    /// A defence establishment, such as an army or navy base.
    let DefenceEstablishment = _prefix "DefenceEstablishment"
          

    /// A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment chosen by the customer. Delivery methods are characterized by the means of transportation used, and by the organization or group that is the contracting party for the sending organization or person.<br/><br/>
/// 
/// Commonly used values:<br/><br/>
/// 
/// <ul>
/// <li>http://purl.org/goodrelations/v1#DeliveryModeDirectDownload</li>
/// <li>http://purl.org/goodrelations/v1#DeliveryModeFreight</li>
/// <li>http://purl.org/goodrelations/v1#DeliveryModeMail</li>
/// <li>http://purl.org/goodrelations/v1#DeliveryModeOwnFleet</li>
/// <li>http://purl.org/goodrelations/v1#DeliveryModePickUp</li>
/// <li>http://purl.org/goodrelations/v1#DHL</li>
/// <li>http://purl.org/goodrelations/v1#FederalExpress</li>
/// <li>http://purl.org/goodrelations/v1#UPS</li>
/// </ul>
/// 
    let DeliveryMethod = _prefix "DeliveryMethod"
          

    /// A delivery service through which content is provided via broadcast over the air or online.
    let BroadcastService = _prefix "BroadcastService"
          

    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    let Demand = _prefix "Demand"
          

    /// A dentist.
    let Dentist = _prefix "Dentist"
          

    /// A department store.
    let DepartmentStore = _prefix "DepartmentStore"
          

    /// A description of an action that is supported.
    let PotentialActionStatus = _prefix "PotentialActionStatus"
          

    /// A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    let Course = _prefix "Course"
          

    /// A description of the item.
    let description = _prefix "description"
          

    /// A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course or program.
    let educationalCredentialAwarded = _prefix "educationalCredentialAwarded"
          

    /// A diet appropriate for people with diabetes.
    let DiabeticDiet = _prefix "DiabeticDiet"
          

    /// A diet appropriate for people with lactose intolerance.
    let LowLactoseDiet = _prefix "LowLactoseDiet"
          

    /// A diet conforming to Hindu dietary practices, in particular, beef-free.
    let HinduDiet = _prefix "HinduDiet"
          

    /// A diet conforming to Islamic dietary practices.
    let HalalDiet = _prefix "HalalDiet"
          

    /// A diet conforming to Jewish dietary practices.
    let KosherDiet = _prefix "KosherDiet"
          

    /// A diet exclusive of all animal products.
    let VeganDiet = _prefix "VeganDiet"
          

    /// A diet exclusive of animal meat.
    let VegetarianDiet = _prefix "VegetarianDiet"
          

    /// A diet exclusive of gluten.
    let GlutenFreeDiet = _prefix "GlutenFreeDiet"
          

    /// A diet focused on reduced calorie intake.
    let LowCalorieDiet = _prefix "LowCalorieDiet"
          

    /// A diet focused on reduced fat and cholesterol intake.
    let LowFatDiet = _prefix "LowFatDiet"
          

    /// A diet focused on reduced sodium intake.
    let LowSaltDiet = _prefix "LowSaltDiet"
          

    /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.
    let RestrictedDiet = _prefix "RestrictedDiet"
          

    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    let HowToDirection = _prefix "HowToDirection"
          

    /// A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip.
    let directors = _prefix "directors"
          

    /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
    let director = _prefix "director"
          

    /// A distillery.
    let Distillery = _prefix "Distillery"
          

    /// A doctor's office.
    let Physician = _prefix "Physician"
          

    /// A downloadable form of this dataset, at a specific location, in a specific format.
    let distribution = _prefix "distribution"
          

    /// A dry-cleaning business.
    let DryCleaningOrLaundry = _prefix "DryCleaningOrLaundry"
          

    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    let ClaimReview = _prefix "ClaimReview"
          

    /// A fast-food restaurant.
    let FastFoodRestaurant = _prefix "FastFoodRestaurant"
          

    /// A file composed primarily of text.
    let TextDigitalDocument = _prefix "TextDigitalDocument"
          

    /// A file containing a note, primarily for the author.
    let NoteDigitalDocument = _prefix "NoteDigitalDocument"
          

    /// A file containing slides or used for a presentation.
    let PresentationDigitalDocument = _prefix "PresentationDigitalDocument"
          

    /// A financial product for the loaning of an amount of money under agreed terms and charges.
    let LoanOrCredit = _prefix "LoanOrCredit"
          

    /// A fire station. With firemen.
    let FireStation = _prefix "FireStation"
          

    /// A flag to signal that the <a class="localLink" href="http://schema.org/Place">Place</a> is open to public visitors.  If this property is omitted there is no assumed default boolean value
    let publicAccess = _prefix "publicAccess"
          

    /// A flag to signal that the item, event, or place is accessible for free.
    let free = _prefix "free"
          

    /// A flag to signal that the item, event, or place is accessible for free.
    let isAccessibleForFree = _prefix "isAccessibleForFree"
          

    /// A florist.
    let Florist = _prefix "Florist"
          

    /// A food or drink item contained in a menu or menu section.
    let hasMenuItem = _prefix "hasMenuItem"
          

    /// A food or drink item listed in a menu or menu section.
    let MenuItem = _prefix "MenuItem"
          

    /// A food service, like breakfast, lunch, or dinner.
    let FoodService = _prefix "FoodService"
          

    /// A food-related business.
    let FoodEstablishment = _prefix "FoodEstablishment"
          

    /// A full description of the lodging unit.
    let lodgingUnitDescription = _prefix "lodgingUnitDescription"
          

    /// A furniture store.
    let FurnitureStore = _prefix "FurnitureStore"
          

    /// A garden store.
    let GardenStore = _prefix "GardenStore"
          

    /// A gas station.
    let GasStation = _prefix "GasStation"
          

    /// A general contractor.
    let GeneralContractor = _prefix "GeneralContractor"
          

    /// A geographical region, typically under the jurisdiction of a particular government.
    let AdministrativeArea = _prefix "AdministrativeArea"
          

    /// A golf course.
    let GolfCourse = _prefix "GolfCourse"
          

    /// A government building.
    let GovernmentBuilding = _prefix "GovernmentBuilding"
          

    /// A government office&#x2014;for example, an IRS or DMV office.
    let GovernmentOffice = _prefix "GovernmentOffice"
          

    /// A governmental organization or agency.
    let GovernmentOrganization = _prefix "GovernmentOrganization"
          

    /// A graveyard.
    let Cemetery = _prefix "Cemetery"
          

    /// A grocery store.
    let GroceryStore = _prefix "GroceryStore"
          

    /// A group of multiple reservations with common values for all sub-reservations.
    let ReservationPackage = _prefix "ReservationPackage"
          

    /// A gym.
    let ExerciseGym = _prefix "ExerciseGym"
          

    /// A hair salon.
    let HairSalon = _prefix "HairSalon"
          

    /// A hardware store.
    let HardwareStore = _prefix "HardwareStore"
          

    /// A health club.
    let HealthClub = _prefix "HealthClub"
          

    /// A high school.
    let HighSchool = _prefix "HighSchool"
          

    /// A home goods store.
    let HomeGoodsStore = _prefix "HomeGoodsStore"
          

    /// A hospital.
    let Hospital = _prefix "Hospital"
          

    /// A hostel - cheap accommodation, often in shared dormitories.
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let Hostel = _prefix "Hostel"
          

    /// A hotel is an establishment that provides lodging paid on a short-term basis (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel).
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let Hotel = _prefix "Hotel"
          

    /// A hotel room is a single room in a hotel.
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let HotelRoom = _prefix "HotelRoom"
          

    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see <a href="http://en.wikipedia.org/wiki/House">http://en.wikipedia.org/wiki/House</a>).
    let House = _prefix "House"
          

    /// A house painting service.
    let HousePainter = _prefix "HousePainter"
          

    /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
    let accessibilitySummary = _prefix "accessibilitySummary"
          

    /// A jewelry store.
    let JewelryStore = _prefix "JewelryStore"
          

    /// A lake (for example, Lake Pontrachain).
    let LakeBodyOfWater = _prefix "LakeBodyOfWater"
          

    /// A landform or physical feature.  Landform elements include mountains, plains, lakes, rivers, seascape and oceanic waterbody interface features such as bays, peninsulas, seas and so forth, including sub-aqueous terrain features such as submersed mountain ranges, volcanoes, and the great ocean basins.
    let Landform = _prefix "Landform"
          

    /// A language someone may use with or at the item, service or place. Please use one of the language codes from the <a href="http://tools.ietf.org/html/bcp47">IETF BCP 47 standard</a>. See also <a class="localLink" href="http://schema.org/inLanguage">inLanguage</a>
    let availableLanguage = _prefix "availableLanguage"
          

    /// A legislative building&#x2014;for example, the state capitol.
    let LegislativeBuilding = _prefix "LegislativeBuilding"
          

    /// A library.
    let Library = _prefix "Library"
          

    /// A license document that applies to this content, typically indicated by URL.
    let license = _prefix "license"
          

    /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
    let line = _prefix "line"
          

    /// A link related to this web page, for example to other related web pages.
    let relatedLink = _prefix "relatedLink"
          

    /// A link to a screenshot image of the app.
    let screenshot = _prefix "screenshot"
          

    /// A link to the ListItem that follows the current one.
    let nextItem = _prefix "nextItem"
          

    /// A link to the ListItem that preceeds the current one.
    let previousItem = _prefix "previousItem"
          

    /// A link to the page containing the comments of the CreativeWork.
    let discussionUrl = _prefix "discussionUrl"
          

    /// A list of items of any sort&#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    let ItemList = _prefix "ItemList"
          

    /// A list of possible conditions for the item.
    let OfferItemCondition = _prefix "OfferItemCondition"
          

    /// A list of possible product availability options.
    let ItemAvailability = _prefix "ItemAvailability"
          

    /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
    let accessModeSufficient = _prefix "accessModeSufficient"
          

    /// A listing that describes a job opening in a certain organization.
    let JobPosting = _prefix "JobPosting"
          

    /// A locksmith.
    let Locksmith = _prefix "Locksmith"
          

    /// A lodging business, such as a motel, hotel, or inn.
    let LodgingBusiness = _prefix "LodgingBusiness"
          

    /// A map.
    let Map = _prefix "Map"
          

    /// A material that something is made from, e.g. leather, wool, cotton, paper.
    let material = _prefix "material"
          

    /// A material used as a surface in some artwork, e.g. Canvas, Paper, Wood, Board, etc.
    let surface = _prefix "surface"
          

    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    let ServiceChannel = _prefix "ServiceChannel"
          

    /// A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
    let availableChannel = _prefix "availableChannel"
          

    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    let Episode = _prefix "Episode"
          

    /// A media object representing the circumstances after performing this direction.
    let afterMedia = _prefix "afterMedia"
          

    /// A media object representing the circumstances before performing this direction.
    let beforeMedia = _prefix "beforeMedia"
          

    /// A media object representing the circumstances while performing this direction.
    let duringMedia = _prefix "duringMedia"
          

    /// A media object that encodes this CreativeWork.
    let encodings = _prefix "encodings"
          

    /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
    let encoding = _prefix "encoding"
          

    /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
    let associatedMedia = _prefix "associatedMedia"
          

    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    let MediaObject = _prefix "MediaObject"
          

    /// A media season e.g. tv, radio, video game etc.
    let CreativeWorkSeason = _prefix "CreativeWorkSeason"
          

    /// A media season e.g. tv, radio, video game etc.
    let Season = _prefix "Season"
          

    /// A medical organization (physical or not), such as hospital, institution or clinic.
    let MedicalOrganization = _prefix "MedicalOrganization"
          

    /// A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings (Source: Wikipedia, the free encyclopedia, see <a href="http://en.wikipedia.org/wiki/Conference_hall">http://en.wikipedia.org/wiki/Conference_hall</a>).
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let MeetingRoom = _prefix "MeetingRoom"
          

    /// A member of a music group&#x2014;for example, John, Paul, George, or Ringo.
    let musicGroupMember = _prefix "musicGroupMember"
          

    /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
    let member = _prefix "member"
          

    /// A member of this organization.
    let members = _prefix "members"
          

    /// A men's clothing store.
    let MensClothingStore = _prefix "MensClothingStore"
          

    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    let MiddleSchool = _prefix "MiddleSchool"
          

    /// A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between �1,000 and �1,000,000 GBP, or the value of a salary, etc. It is recommended to use <a class="localLink" href="http://schema.org/PriceSpecification">PriceSpecification</a> Types to describe the price of an Offer, Invoice, etc.
    let MonetaryAmount = _prefix "MonetaryAmount"
          

    /// A mosque.
    let Mosque = _prefix "Mosque"
          

    /// A motel.
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let Motel = _prefix "Motel"
          

    /// A motorcycle dealer.
    let MotorcycleDealer = _prefix "MotorcycleDealer"
          

    /// A motorcycle repair shop.
    let MotorcycleRepair = _prefix "MotorcycleRepair"
          

    /// A mountain, like Mount Whitney or Mount Everest.
    let Mountain = _prefix "Mountain"
          

    /// A movie rental store.
    let MovieRentalStore = _prefix "MovieRentalStore"
          

    /// A movie theater.
    let MovieTheater = _prefix "MovieTheater"
          

    /// A movie.
    let Movie = _prefix "Movie"
          

    /// A moving company.
    let MovingCompany = _prefix "MovingCompany"
          

    /// A museum.
    let Museum = _prefix "Museum"
          

    /// A music album.
    let album = _prefix "album"
          

    /// A music recording (track)&#x2014;usually a single song.
    let tracks = _prefix "tracks"
          

    /// A music recording (track)&#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
    let track = _prefix "track"
          

    /// A music recording (track), usually a single song.
    let MusicRecording = _prefix "MusicRecording"
          

    /// A music store.
    let MusicStore = _prefix "MusicStore"
          

    /// A music venue.
    let MusicVenue = _prefix "MusicVenue"
          

    /// A music video file.
    let MusicVideoObject = _prefix "MusicVideoObject"
          

    /// A musical composition.
    let MusicComposition = _prefix "MusicComposition"
          

    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    let MusicGroup = _prefix "MusicGroup"
          

    /// A nail salon.
    let NailSalon = _prefix "NailSalon"
          

    /// A navigation element of the page.
    let SiteNavigationElement = _prefix "SiteNavigationElement"
          

    /// A nightclub or discotheque.
    let NightClub = _prefix "NightClub"
          

    /// A notary.
    let Notary = _prefix "Notary"
          

    /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
    let numberedPosition = _prefix "numberedPosition"
          

    /// A number that confirms the given order or payment has been received.
    let confirmationNumber = _prefix "confirmationNumber"
          

    /// A page devoted to a single item, such as a particular product or hotel.
    let ItemPage = _prefix "ItemPage"
          

    /// A painting.
    let Painting = _prefix "Painting"
          

    /// A parent of this person.
    let parent = _prefix "parent"
          

    /// A parents of the person.
    let parents = _prefix "parents"
          

    /// A park.
    let Park = _prefix "Park"
          

    /// A parking lot or other parking facility.
    let ParkingFacility = _prefix "ParkingFacility"
          

    /// A parking map.
    let ParkingMap = _prefix "ParkingMap"
          

    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.<br/><br/>
/// 
/// See also <a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html">blog post</a>.
    let PublicationVolume = _prefix "PublicationVolume"
          

    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.<br/><br/>
/// 
/// See also <a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html">blog post</a>.
    let PublicationIssue = _prefix "PublicationIssue"
          

    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    let LocalBusiness = _prefix "LocalBusiness"
          

    /// A payment method is a standardized procedure for transferring the monetary amount for a purchase. Payment methods are characterized by the legal and technical structures used, and by the organization or group carrying out the transaction.<br/><br/>
/// 
/// Commonly used values:<br/><br/>
/// 
/// <ul>
/// <li>http://purl.org/goodrelations/v1#ByBankTransferInAdvance</li>
/// <li>http://purl.org/goodrelations/v1#ByInvoice</li>
/// <li>http://purl.org/goodrelations/v1#Cash</li>
/// <li>http://purl.org/goodrelations/v1#CheckInAdvance</li>
/// <li>http://purl.org/goodrelations/v1#COD</li>
/// <li>http://purl.org/goodrelations/v1#DirectDebit</li>
/// <li>http://purl.org/goodrelations/v1#GoogleCheckout</li>
/// <li>http://purl.org/goodrelations/v1#PayPal</li>
/// <li>http://purl.org/goodrelations/v1#PaySwarm</li>
/// </ul>
/// 
    let PaymentMethod = _prefix "PaymentMethod"
          

    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    let PaymentCard = _prefix "PaymentCard"
          

    /// A performance group, such as a band, an orchestra, or a circus.
    let PerformingGroup = _prefix "PerformingGroup"
          

    /// A performer at the event&#x2014;for example, a presenter, musician, musical group or actor.
    let performer = _prefix "performer"
          

    /// A permission for a particular person or group to access a particular file.
    let DigitalDocumentPermission = _prefix "DigitalDocumentPermission"
          

    /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
    let hasDigitalDocumentPermission = _prefix "hasDigitalDocumentPermission"
          

    /// A permit issued by a government agency.
    let GovernmentPermit = _prefix "GovernmentPermit"
          

    /// A permit issued by an organization, e.g. a parking pass.
    let Permit = _prefix "Permit"
          

    /// A person (alive, dead, undead, or fictional).
    let Person = _prefix "Person"
          

    /// A person assigned to instruct or provide instructional assistance for the <a class="localLink" href="http://schema.org/CourseInstance">CourseInstance</a>.
    let instructor = _prefix "instructor"
          

    /// A person attending the event.
    let attendees = _prefix "attendees"
          

    /// A person or organization attending the event.
    let attendee = _prefix "attendee"
          

    /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
    let contactType = _prefix "contactType"
          

    /// A person or organization that supports (sponsors) something through some kind of financial contribution.
    let funder = _prefix "funder"
          

    /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
    let sponsor = _prefix "sponsor"
          

    /// A person that acts as performing member of a sports team; a player as opposed to a coach.
    let athlete = _prefix "athlete"
          

    /// A person that acts in a coaching role for a sports team.
    let coach = _prefix "coach"
          

    /// A person who founded this organization.
    let founder = _prefix "founder"
          

    /// A person who founded this organization.
    let founders = _prefix "founders"
          

    /// A pet store.
    let PetStore = _prefix "PetStore"
          

    /// A pharmacy or drugstore.
    let Pharmacy = _prefix "Pharmacy"
          

    /// A photograph of this place.
    let photo = _prefix "photo"
          

    /// A photograph.
    let Photograph = _prefix "Photograph"
          

    /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
    let characterAttribute = _prefix "characterAttribute"
          

    /// A piece of sculpture.
    let Sculpture = _prefix "Sculpture"
          

    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    let RVPark = _prefix "RVPark"
          

    /// A placeholder for multiple similar products of the same kind.
    let SomeProducts = _prefix "SomeProducts"
          

    /// A playground.
    let Playground = _prefix "Playground"
          

    /// A plumbing service.
    let Plumber = _prefix "Plumber"
          

    /// A point in time recurring on multiple days in the form hh:mm:ss[Z|(+|-)hh:mm] (see <a href="http://www.w3.org/TR/xmlschema-2/#time">XML schema for details</a>).
    let Time = _prefix "Time"
          

    /// A point value or interval for product characteristics and other purposes.
    let QuantitativeValue = _prefix "QuantitativeValue"
          

    /// A pointer from a newer variant of a product  to its previous, often discontinued predecessor.
    let successorOf = _prefix "successorOf"
          

    /// A pointer from a previous, often discontinued variant of the product to its newer variant.
    let predecessorOf = _prefix "predecessorOf"
          

    /// A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.
    let isVariantOf = _prefix "isVariantOf"
          

    /// A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
    let valueReference = _prefix "valueReference"
          

    /// A pointer to another product (or multiple products) for which this product is a consumable.
    let isConsumableFor = _prefix "isConsumableFor"
          

    /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
    let isAccessoryOrSparePartFor = _prefix "isAccessoryOrSparePartFor"
          

    /// A pointer to another, functionally similar product (or multiple products).
    let isSimilarTo = _prefix "isSimilarTo"
          

    /// A pointer to another, somehow related product (or multiple products).
    let isRelatedTo = _prefix "isRelatedTo"
          

    /// A pointer to products or services offered by the organization or person.
    let makesOffer = _prefix "makesOffer"
          

    /// A pointer to products or services sought by the organization or person (demand).
    let seeks = _prefix "seeks"
          

    /// A pointer to the organization or person making the offer.
    let offeredBy = _prefix "offeredBy"
          

    /// A police station.
    let PoliceStation = _prefix "PoliceStation"
          

    /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
    let polygon = _prefix "polygon"
          

    /// A pond.
    let Pond = _prefix "Pond"
          

    /// A position played, performed or filled by a person or organization, as part of an organization. For example, an athlete in a SportsTeam might play in the position named 'Quarterback'.
    let namedPosition = _prefix "namedPosition"
          

    /// A post office.
    let PostOffice = _prefix "PostOffice"
          

    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    let SocialMediaPosting = _prefix "SocialMediaPosting"
          

    /// A posting that is part of this blog.
    let blogPost = _prefix "blogPost"
          

    /// A posting to a discussion forum.
    let DiscussionForumPosting = _prefix "DiscussionForumPosting"
          

    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    let QualitativeValue = _prefix "QualitativeValue"
          

    /// A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.
    let itemCondition = _prefix "itemCondition"
          

    /// A preschool.
    let Preschool = _prefix "Preschool"
          

    /// A private parcel service as the delivery mode available for a certain offer.<br/><br/>
/// 
/// Commonly used values:<br/><br/>
/// 
/// <ul>
/// <li>http://purl.org/goodrelations/v1#DHL</li>
/// <li>http://purl.org/goodrelations/v1#FederalExpress</li>
/// <li>http://purl.org/goodrelations/v1#UPS</li>
/// </ul>
/// 
    let ParcelService = _prefix "ParcelService"
          

    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    let BankAccount = _prefix "BankAccount"
          

    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    let FinancialProduct = _prefix "FinancialProduct"
          

    /// A profession, may involve prolonged training and/or a formal qualification.
    let Occupation = _prefix "Occupation"
          

    /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.<br/><br/>
/// 
/// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
    let additionalProperty = _prefix "additionalProperty"
          

    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.<br/><br/>
/// 
/// Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    let PropertyValue = _prefix "PropertyValue"
          

    /// A public structure, such as a town hall or concert hall.
    let CivicStructure = _prefix "CivicStructure"
          

    /// A public swimming pool.
    let PublicSwimmingPool = _prefix "PublicSwimmingPool"
          

    /// A publication event associated with the item.
    let publication = _prefix "publication"
          

    /// A publication event e.g. catch-up TV or radio podcast, during which a program is available on-demand.
    let OnDemandEvent = _prefix "OnDemandEvent"
          

    /// A publication in any medium issued in successive parts bearing numerical or chronological designations and intended, such as a magazine, scholarly journal, or newspaper to continue indefinitely.<br/><br/>
/// 
/// See also <a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html">blog post</a>.
    let Periodical = _prefix "Periodical"
          

    /// A radio channel that uses AM.
    let AMRadioChannel = _prefix "AMRadioChannel"
          

    /// A radio channel that uses FM.
    let FMRadioChannel = _prefix "FMRadioChannel"
          

    /// A radio episode which can be part of a series or season.
    let RadioEpisode = _prefix "RadioEpisode"
          

    /// A radio station.
    let RadioStation = _prefix "RadioStation"
          

    /// A range of of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.<br/><br/>
/// 
/// Commonly used values:<br/><br/>
/// 
/// <ul>
/// <li>http://purl.org/goodrelations/v1#Labor-BringIn</li>
/// <li>http://purl.org/goodrelations/v1#PartsAndLabor-BringIn</li>
/// <li>http://purl.org/goodrelations/v1#PartsAndLabor-PickUp</li>
/// </ul>
/// 
    let WarrantyScope = _prefix "WarrantyScope"
          

    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    let Rating = _prefix "Rating"
          

    /// A real-estate agent.
    let RealEstateAgent = _prefix "RealEstateAgent"
          

    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via <a class="localLink" href="http://schema.org/suitableForDiet">suitableForDiet</a>. The <a class="localLink" href="http://schema.org/keywords">keywords</a> property can also be used to add more detail.
    let Recipe = _prefix "Recipe"
          

    /// A recycling center.
    let RecyclingCenter = _prefix "RecyclingCenter"
          

    /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
    let department = _prefix "department"
          

    /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
    let subOrganization = _prefix "subOrganization"
          

    /// A release of this album.
    let albumRelease = _prefix "albumRelease"
          

    /// A reservation for a rental car.<br/><br/>
/// 
/// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    let RentalCarReservation = _prefix "RentalCarReservation"
          

    /// A reservation for a taxi.<br/><br/>
/// 
/// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use <a class="localLink" href="http://schema.org/Offer">Offer</a>.
    let TaxiReservation = _prefix "TaxiReservation"
          

    /// A reservation for air travel.<br/><br/>
/// 
/// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use <a class="localLink" href="http://schema.org/Offer">Offer</a>.
    let FlightReservation = _prefix "FlightReservation"
          

    /// A reservation for an event like a concert, sporting event, or lecture.<br/><br/>
/// 
/// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use <a class="localLink" href="http://schema.org/Offer">Offer</a>.
    let EventReservation = _prefix "EventReservation"
          

    /// A reservation for bus travel. <br/><br/>
/// 
/// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use <a class="localLink" href="http://schema.org/Offer">Offer</a>.
    let BusReservation = _prefix "BusReservation"
          

    /// A reservation for lodging at a hotel, motel, inn, etc.<br/><br/>
/// 
/// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    let LodgingReservation = _prefix "LodgingReservation"
          

    /// A reservation for train travel.<br/><br/>
/// 
/// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use <a class="localLink" href="http://schema.org/Offer">Offer</a>.
    let TrainReservation = _prefix "TrainReservation"
          

    /// A reservation to dine at a food-related business.<br/><br/>
/// 
/// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    let FoodEstablishmentReservation = _prefix "FoodEstablishmentReservation"
          

    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    let Reservoir = _prefix "Reservoir"
          

    /// A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishment operated by a single company (Source: Wikipedia, the free encyclopedia, see <a href="http://en.wikipedia.org/wiki/Resort">http://en.wikipedia.org/wiki/Resort</a>).
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let Resort = _prefix "Resort"
          

    /// A resource from which this work is derived or from which it is a modification or adaption.
    let isBasedOn = _prefix "isBasedOn"
          

    /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
    let isBasedOnUrl = _prefix "isBasedOnUrl"
          

    /// A restaurant.
    let Restaurant = _prefix "Restaurant"
          

    /// A retail good store.
    let Store = _prefix "Store"
          

    /// A review of an item - for example, of a restaurant, movie, or store.
    let Review = _prefix "Review"
          

    /// A review of the item.
    let review = _prefix "review"
          

    /// A river (for example, the broad majestic Shannon).
    let RiverBodyOfWater = _prefix "RiverBodyOfWater"
          

    /// A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.
    let roleName = _prefix "roleName"
          

    /// A roofing contractor.
    let RoofingContractor = _prefix "RoofingContractor"
          

    /// A room is a distinguishable space within a structure, usually separated from other spaces by interior walls. (Source: Wikipedia, the free encyclopedia, see <a href="http://en.wikipedia.org/wiki/Room">http://en.wikipedia.org/wiki/Room</a>).
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let Room = _prefix "Room"
          

    /// A scholarly article.
    let ScholarlyArticle = _prefix "ScholarlyArticle"
          

    /// A school.
    let School = _prefix "School"
          

    /// A screening of a movie or other video.
    let ScreeningEvent = _prefix "ScreeningEvent"
          

    /// A sea (for example, the Caspian sea).
    let SeaBodyOfWater = _prefix "SeaBodyOfWater"
          

    /// A season in a media series.
    let season = _prefix "season"
          

    /// A season in a media series.
    let seasons = _prefix "seasons"
          

    /// A season that is part of the media series.
    let containsSeason = _prefix "containsSeason"
          

    /// A seating map.
    let SeatingMap = _prefix "SeatingMap"
          

    /// A secondary contributor to the CreativeWork or Event.
    let contributor = _prefix "contributor"
          

    /// A secondary title of the CreativeWork.
    let alternativeHeadline = _prefix "alternativeHeadline"
          

    /// A self-storage facility.
    let SelfStorage = _prefix "SelfStorage"
          

    /// A series of books. Included books can be indicated with the hasPart property.
    let BookSeries = _prefix "BookSeries"
          

    /// A series of movies. Included movies can be indicated with the hasPart property.
    let MovieSeries = _prefix "MovieSeries"
          

    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    let TaxiService = _prefix "TaxiService"
          

    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    let GovernmentService = _prefix "GovernmentService"
          

    /// A service provided by an organization, e.g. delivery service, print services, etc.
    let Service = _prefix "Service"
          

    /// A service to convert funds from one currency to another currency.
    let CurrencyConversionService = _prefix "CurrencyConversionService"
          

    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    let CableOrSatelliteService = _prefix "CableOrSatelliteService"
          

    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    let BusinessAudience = _prefix "BusinessAudience"
          

    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    let PeopleAudience = _prefix "PeopleAudience"
          

    /// A set of characteristics describing parents, who can be interested in viewing some content.
    let ParentAudience = _prefix "ParentAudience"
          

    /// A set of links that can help a user understand and navigate a website hierarchy.
    let breadcrumb = _prefix "breadcrumb"
          

    /// A set of requirements that a must be fulfilled in order to perform an Action.
    let ActionAccessSpecification = _prefix "ActionAccessSpecification"
          

    /// A set of requirements that a must be fulfilled in order to perform an Action. If more than one value is specied, fulfilling one set of requirements will allow the Action to be performed.
    let actionAccessibilityRequirement = _prefix "actionAccessibilityRequirement"
          

    /// A shoe store.
    let ShoeStore = _prefix "ShoeStore"
          

    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    let LiquorStore = _prefix "LiquorStore"
          

    /// A shop that will buy, or lend money against the security of, personal possessions.
    let PawnShop = _prefix "PawnShop"
          

    /// A shopping center or mall.
    let ShoppingCenter = _prefix "ShoppingCenter"
          

    /// A short TV or radio program or a segment/part of a program.
    let Clip = _prefix "Clip"
          

    /// A short TV program or a segment/part of a TV program.
    let TVClip = _prefix "TVClip"
          

    /// A short radio program or a segment/part of a radio program.
    let RadioClip = _prefix "RadioClip"
          

    /// A short segment/part of a movie.
    let MovieClip = _prefix "MovieClip"
          

    /// A short segment/part of a video game.
    let VideoGameClip = _prefix "VideoGameClip"
          

    /// A short summary of the specific claims reviewed in a ClaimReview.
    let claimReviewed = _prefix "claimReviewed"
          

    /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
    let vehicleConfiguration = _prefix "vehicleConfiguration"
          

    /// A short text or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.
    let priceType = _prefix "priceType"
          

    /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.<br/><br/>
/// 
/// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
    let branchCode = _prefix "branchCode"
          

    /// A sibling of the person.
    let sibling = _prefix "sibling"
          

    /// A sibling of the person.
    let siblings = _prefix "siblings"
          

    /// A sidebar section of the page.
    let WPSideBar = _prefix "WPSideBar"
          

    /// A single feed providing structured information about one or more entities or topics.
    let DataFeed = _prefix "DataFeed"
          

    /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
    let ingredients = _prefix "ingredients"
          

    /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
    let recipeIngredient = _prefix "recipeIngredient"
          

    /// A single item within a larger data feed.
    let DataFeedItem = _prefix "DataFeedItem"
          

    /// A single message from a sender to one or more organizations or people.
    let Message = _prefix "Message"
          

    /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection (originally misnamed 'steps'; 'step' is preferred).
    let steps = _prefix "steps"
          

    /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection.
    let step = _prefix "step"
          

    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    let IndividualProduct = _prefix "IndividualProduct"
          

    /// A ski resort.
    let SkiResort = _prefix "SkiResort"
          

    /// A slogan or motto associated with the item.
    let slogan = _prefix "slogan"
          

    /// A software application designed specifically to work well on a mobile device such as a telephone.
    let MobileApplication = _prefix "MobileApplication"
          

    /// A software application.
    let SoftwareApplication = _prefix "SoftwareApplication"
          

    /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    let PaymentStatusType = _prefix "PaymentStatusType"
          

    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    let Question = _prefix "Question"
          

    /// A sporting goods store.
    let SportingGoodsStore = _prefix "SportingGoodsStore"
          

    /// A sports club.
    let SportsClub = _prefix "SportsClub"
          

    /// A sports location, such as a playing field.
    let SportsActivityLocation = _prefix "SportsActivityLocation"
          

    /// A spreadsheet file.
    let SpreadsheetDigitalDocument = _prefix "SpreadsheetDigitalDocument"
          

    /// A stadium.
    let StadiumOrArena = _prefix "StadiumOrArena"
          

    /// A state or province of a country.
    let State = _prefix "State"
          

    /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.
    let skills = _prefix "skills"
          

    /// A statement of the money due for goods or services; a bill.
    let Invoice = _prefix "Invoice"
          

    /// A statistical distribution of monetary amounts.
    let MonetaryAmountDistribution = _prefix "MonetaryAmountDistribution"
          

    /// A statistical distribution of values.
    let QuantitativeValueDistribution = _prefix "QuantitativeValueDistribution"
          

    /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
    let recipeInstructions = _prefix "recipeInstructions"
          

    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    let HowToStep = _prefix "HowToStep"
          

    /// A store that sells materials useful or necessary for various hobbies.
    let HobbyShop = _prefix "HobbyShop"
          

    /// A store that sells mobile phones and related accessories.
    let MobilePhoneStore = _prefix "MobilePhoneStore"
          

    /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
/// <a href='unitCode'>unitCode</a>.
    let unitText = _prefix "unitText"
          

    /// A structured representation of food or drink items available from a FoodEstablishment.
    let Menu = _prefix "Menu"
          

    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    let TypeAndQuantityNode = _prefix "TypeAndQuantityNode"
          

    /// A structured value providing information about the opening hours of a place or a certain service inside a place.<br/><br/>
/// 
/// The place is <strong>open</strong> if the <a class="localLink" href="http://schema.org/opens">opens</a> property is specified, and <strong>closed</strong> otherwise.<br/><br/>
/// 
/// If the value for the <a class="localLink" href="http://schema.org/closes">closes</a> property is less than the value for the <a class="localLink" href="http://schema.org/opens">opens</a> property then the hour range is assumed to span over the next day.
    let OpeningHoursSpecification = _prefix "OpeningHoursSpecification"
          

    /// A structured value providing information about when a certain organization or person owned a certain product.
    let OwnershipInfo = _prefix "OwnershipInfo"
          

    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use <a class="localLink" href="http://schema.org/MonetaryAmount">MonetaryAmount</a> to describe independent amounts of money such as a salary, credit card limits, etc.
    let PriceSpecification = _prefix "PriceSpecification"
          

    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    let WarrantyPromise = _prefix "WarrantyPromise"
          

    /// A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
    let disambiguatingDescription = _prefix "disambiguatingDescription"
          

    /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
    let tool = _prefix "tool"
          

    /// A sub property of instrument. The language used on this action.
    let language = _prefix "language"
          

    /// A sub property of instrument. The method of delivery.
    let deliveryMethod = _prefix "deliveryMethod"
          

    /// A sub property of instrument. The query used on this action.
    let query = _prefix "query"
          

    /// A sub property of instrument. The recipe/instructions used to perform the action.
    let recipe = _prefix "recipe"
          

    /// A sub property of location. The course where this action was taken.
    let course = _prefix "course"
          

    /// A sub property of location. The course where this action was taken.
    let exerciseCourse = _prefix "exerciseCourse"
          

    /// A sub property of location. The entertainment business where the action occurred.
    let entertainmentBusiness = _prefix "entertainmentBusiness"
          

    /// A sub property of location. The final location of the object or the agent after the action.
    let toLocation = _prefix "toLocation"
          

    /// A sub property of location. The original location of the object or the agent before the action.
    let fromLocation = _prefix "fromLocation"
          

    /// A sub property of location. The specific food establishment where the action occurred.
    let foodEstablishment = _prefix "foodEstablishment"
          

    /// A sub property of location. The specific food event where the action occurred.
    let foodEvent = _prefix "foodEvent"
          

    /// A sub property of location. The sports activity location where this action occurred.
    let sportsActivityLocation = _prefix "sportsActivityLocation"
          

    /// A sub property of location. The sports event where this action occurred.
    let sportsEvent = _prefix "sportsEvent"
          

    /// A sub property of object. A question.
    let question = _prefix "question"
          

    /// A sub property of object. The candidate subject of this action.
    let candidate = _prefix "candidate"
          

    /// A sub property of object. The collection target of the action.
    let collection = _prefix "collection"
          

    /// A sub property of object. The collection target of the action.
    let targetCollection = _prefix "targetCollection"
          

    /// A sub property of object. The object that is being replaced.
    let replacee = _prefix "replacee"
          

    /// A sub property of object. The object that replaces.
    let replacer = _prefix "replacer"
          

    /// A sub property of object. The options subject to this action.
    let actionOption = _prefix "actionOption"
          

    /// A sub property of object. The options subject to this action.
    let option = _prefix "option"
          

    /// A sub property of object. The person or organization being followed.
    let followee = _prefix "followee"
          

    /// A sub property of participant. The loser of the action.
    let loser = _prefix "loser"
          

    /// A sub property of participant. The opponent on this action.
    let opponent = _prefix "opponent"
          

    /// A sub property of participant. The owner of the real estate property.
    let landlord = _prefix "landlord"
          

    /// A sub property of participant. The participant who is at the receiving end of the action.
    let recipient = _prefix "recipient"
          

    /// A sub property of participant. The participant who is at the sending end of the action.
    let sender = _prefix "sender"
          

    /// A sub property of participant. The participant/person/organization that bought the object.
    let buyer = _prefix "buyer"
          

    /// A sub property of participant. The person that borrows the object being lent.
    let borrower = _prefix "borrower"
          

    /// A sub property of participant. The person that lends the object being borrowed.
    let lender = _prefix "lender"
          

    /// A sub property of participant. The person/organization being supported.
    let endorsee = _prefix "endorsee"
          

    /// A sub property of participant. The real estate agent involved in the action.
    let realEstateAgent = _prefix "realEstateAgent"
          

    /// A sub property of participant. The sports team that participated on this action.
    let sportsTeam = _prefix "sportsTeam"
          

    /// A sub property of participant. The winner of the action.
    let winner = _prefix "winner"
          

    /// A sub property of recipient. The recipient blind copied on a message.
    let bccRecipient = _prefix "bccRecipient"
          

    /// A sub property of recipient. The recipient copied on a message.
    let ccRecipient = _prefix "ccRecipient"
          

    /// A sub property of recipient. The recipient who was directly sent the message.
    let toRecipient = _prefix "toRecipient"
          

    /// A sub property of result. The Comment created or sent as a result of this action.
    let resultComment = _prefix "resultComment"
          

    /// A sub property of result. The review that resulted in the performing of the action.
    let resultReview = _prefix "resultReview"
          

    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    let MenuSection = _prefix "MenuSection"
          

    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    let HowToSection = _prefix "HowToSection"
          

    /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
    let supply = _prefix "supply"
          

    /// A subclass of OrganizationRole used to describe employee relationships.
    let EmployeeRole = _prefix "EmployeeRole"
          

    /// A subclass of Role used to describe roles within organizations.
    let OrganizationRole = _prefix "OrganizationRole"
          

    /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
    let hasMenuSection = _prefix "hasMenuSection"
          

    /// A subscription which allows a user to access media including audio, video, books, etc.
    let MediaSubscription = _prefix "MediaSubscription"
          

    /// A subway station.
    let SubwayStation = _prefix "SubwayStation"
          

    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (Source: Wikipedia, the free encyclopedia, see <a href="http://en.wikipedia.org/wiki/Suite_(hotel)">http://en.wikipedia.org/wiki/Suite_(hotel)</a>).
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let Suite = _prefix "Suite"
          

    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    let InteractionCounter = _prefix "InteractionCounter"
          

    /// A supply consumed when performing the instructions for how to achieve a result.
    let HowToSupply = _prefix "HowToSupply"
          

    /// A synagogue.
    let Synagogue = _prefix "Synagogue"
          

    /// A table on a Web page.
    let Table = _prefix "Table"
          

    /// A tattoo parlor.
    let TattooParlor = _prefix "TattooParlor"
          

    /// A taxi stand.
    let TaxiStand = _prefix "TaxiStand"
          

    /// A taxi.
    let Taxi = _prefix "Taxi"
          

    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    let TechArticle = _prefix "TechArticle"
          

    /// A television station.
    let TelevisionStation = _prefix "TelevisionStation"
          

    /// A tennis complex.
    let TennisComplex = _prefix "TennisComplex"
          

    /// A textual description of known damages, both repaired and unrepaired.
    let knownVehicleDamages = _prefix "knownVehicleDamages"
          

    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    let TheaterGroup = _prefix "TheaterGroup"
          

    /// A theater or other performing art center.
    let PerformingArtsTheater = _prefix "PerformingArtsTheater"
          

    /// A thumbnail image relevant to the Thing.
    let thumbnailUrl = _prefix "thumbnailUrl"
          

    /// A ticket associated with the reservation.
    let reservedTicket = _prefix "reservedTicket"
          

    /// A tire shop.
    let TireShop = _prefix "TireShop"
          

    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    let HowToTool = _prefix "HowToTool"
          

    /// A tourist attraction.  In principle any Thing can be a <a class="localLink" href="http://schema.org/TouristAttraction">TouristAttraction</a>, from a <a class="localLink" href="http://schema.org/Mountain">Mountain</a> and <a class="localLink" href="http://schema.org/LandmarksOrHistoricalBuildings">LandmarksOrHistoricalBuildings</a> to a <a class="localLink" href="http://schema.org/LocalBusiness">LocalBusiness</a>.  This Type can be used on its own to describe a general <a class="localLink" href="http://schema.org/TouristAttraction">TouristAttraction</a>, or be used as an <a class="localLink" href="http://schema.org/additionalType">additionalType</a> to add tourist attraction properties to any other type.  (See examples below)
    let TouristAttraction = _prefix "TouristAttraction"
          

    /// A tourist information center.
    let TouristInformationCenter = _prefix "TouristInformationCenter"
          

    /// A toy store.
    let ToyStore = _prefix "ToyStore"
          

    /// A train station.
    let TrainStation = _prefix "TrainStation"
          

    /// A transit map.
    let TransitMap = _prefix "TransitMap"
          

    /// A travel agency.
    let TravelAgency = _prefix "TravelAgency"
          

    /// A trip on a commercial bus line.
    let BusTrip = _prefix "BusTrip"
          

    /// A trip on a commercial train line.
    let TrainTrip = _prefix "TrainTrip"
          

    /// A trip or journey. An itinerary of visits to one or more places.
    let Trip = _prefix "Trip"
          

    /// A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.
    let DepositAccount = _prefix "DepositAccount"
          

    /// A type of bed. This is used for indicating the bed or beds available in an accommodation.
    let BedType = _prefix "BedType"
          

    /// A type of boarding policy used by an airline.
    let BoardingPolicyType = _prefix "BoardingPolicyType"
          

    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    let InvestmentOrDeposit = _prefix "InvestmentOrDeposit"
          

    /// A type of permission which can be granted for accessing a digital document.
    let DigitalDocumentPermissionType = _prefix "DigitalDocumentPermissionType"
          

    /// A unique identifier for the membership.
    let membershipNumber = _prefix "membershipNumber"
          

    /// A unique identifier for the reservation.
    let reservationId = _prefix "reservationId"
          

    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    let BroadcastChannel = _prefix "BroadcastChannel"
          

    /// A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.
    let RadioChannel = _prefix "RadioChannel"
          

    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    let TelevisionChannel = _prefix "TelevisionChannel"
          

    /// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
    let Intangible = _prefix "Intangible"
          

    /// A value indicating a steering position.
    let SteeringPositionValue = _prefix "SteeringPositionValue"
          

    /// A value indicating which roadwheels will receive torque.
    let DriveWheelConfigurationValue = _prefix "DriveWheelConfigurationValue"
          

    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    let Vehicle = _prefix "Vehicle"
          

    /// A venue map (e.g. for malls, auditoriums, museums, etc.).
    let VenueMap = _prefix "VenueMap"
          

    /// A video file.
    let VideoObject = _prefix "VideoObject"
          

    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    let VideoGame = _prefix "VideoGame"
          

    /// A video game series.
    let VideoGameSeries = _prefix "VideoGameSeries"
          

    /// A volcano, like Fuji san.
    let Volcano = _prefix "Volcano"
          

    /// A waterfall, like Niagara.
    let Waterfall = _prefix "Waterfall"
          

    /// A web page element, like a table or an image.
    let WebPageElement = _prefix "WebPageElement"
          

    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as <code>breadcrumb</code> may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    let WebPage = _prefix "WebPage"
          

    /// A wholesale store.
    let WholesaleStore = _prefix "WholesaleStore"
          

    /// A winery.
    let Winery = _prefix "Winery"
          

    /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
    let workFeatured = _prefix "workFeatured"
          

    /// A work of art that is primarily visual in character.
    let VisualArtwork = _prefix "VisualArtwork"
          

    /// A work performed in some event, for example a play performed in a TheaterEvent.
    let workPerformed = _prefix "workPerformed"
          

    /// A zoo.
    let Zoo = _prefix "Zoo"
          

    /// ATM/cash machine.
    let AutomatedTeller = _prefix "AutomatedTeller"
          

    /// Accountancy business.<br/><br/>
/// 
/// As a <a class="localLink" href="http://schema.org/LocalBusiness">LocalBusiness</a> it can be described as a <a class="localLink" href="http://schema.org/provider">provider</a> of one or more <a class="localLink" href="http://schema.org/Service">Service</a>(s).
    let AccountingService = _prefix "AccountingService"
          

    /// Actual bytes of the media object, for example the image file or video file.
    let contentUrl = _prefix "contentUrl"
          

    /// Additional content for a software application.
    let softwareAddOn = _prefix "softwareAddOn"
          

    /// Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.
    let menuAddOn = _prefix "menuAddOn"
          

    /// After this date, the item will no longer be available for pickup.
    let availableThrough = _prefix "availableThrough"
          

    /// AlbumRelease.
    let AlbumRelease = _prefix "AlbumRelease"
          

    /// All-wheel Drive is a transmission layout where the engine drives all four wheels.
    let AllWheelDriveConfiguration = _prefix "AllWheelDriveConfiguration"
          

    /// Alumni of an organization.
    let alumni = _prefix "alumni"
          

    /// An EducationalAudience.
    let EducationalAudience = _prefix "EducationalAudience"
          

    /// An EndorsementRating is a rating that expresses some level of endorsement, for example inclusion in a "critic's pick" blog, a
/// "Like" or "+1" on a social network. It can be considered the <a class="localLink" href="http://schema.org/result">result</a> of an <a class="localLink" href="http://schema.org/EndorseAction">EndorseAction</a> in which the <a class="localLink" href="http://schema.org/object">object</a> of the action is rated positively by
/// some <a class="localLink" href="http://schema.org/agent">agent</a>. As is common elsewhere in schema.org, it is sometimes more useful to describe the results of such an action without explicitly describing the <a class="localLink" href="http://schema.org/Action">Action</a>.<br/><br/>
/// 
/// An <a class="localLink" href="http://schema.org/EndorsementRating">EndorsementRating</a> may be part of a numeric scale or organized system, but this is not required: having an explicit type for indicating a positive,
/// endorsement rating is particularly useful in the absence of numeric scales as it helps consumers understand that the rating is broadly positive.
    let EndorsementRating = _prefix "EndorsementRating"
          

    /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
    let subEvent = _prefix "subEvent"
          

    /// An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.
    let httpMethod = _prefix "httpMethod"
          

    /// An Insurance agency.
    let InsuranceAgency = _prefix "InsuranceAgency"
          

    /// An ItemList ordered with higher values listed first.
    let ItemListOrderDescending = _prefix "ItemListOrderDescending"
          

    /// An ItemList ordered with lower values listed first.
    let ItemListOrderAscending = _prefix "ItemListOrderAscending"
          

    /// An ItemList ordered with no explicit order.
    let ItemListUnordered = _prefix "ItemListUnordered"
          

    /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
    let expectsAcceptanceOf = _prefix "expectsAcceptanceOf"
          

    /// An OfferCatalog is an ItemList that contains related Offers and/or further OfferCatalogs that are offeredBy the same provider.
    let OfferCatalog = _prefix "OfferCatalog"
          

    /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
    let memberOf = _prefix "memberOf"
          

    /// An XPath, e.g. of a <a class="localLink" href="http://schema.org/SpeakableSpecification">SpeakableSpecification</a> or <a class="localLink" href="http://schema.org/WebPageElement">WebPageElement</a>. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
    let xpath = _prefix "xpath"
          

    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
/// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let Accommodation = _prefix "Accommodation"
          

    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.<br/><br/>
/// 
/// See also <a href="http://blog.schema.org/2014/04/announcing-schemaorg-actions.html">blog post</a> and <a href="http://schema.org/docs/actions.html">Actions overview document</a>.
    let Action = _prefix "Action"
          

    /// An action that failed to complete. The action's error property and the HTTP return code contain more information about the failure.
    let FailedActionStatus = _prefix "FailedActionStatus"
          

    /// An action that has already taken place.
    let CompletedActionStatus = _prefix "CompletedActionStatus"
          

    /// An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip.
    let actors = _prefix "actors"
          

    /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
    let actor = _prefix "actor"
          

    /// An additional name for a Person, can be used for a middle name.
    let additionalName = _prefix "additionalName"
          

    /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
    let addOn = _prefix "addOn"
          

    /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.
    let additionalType = _prefix "additionalType"
          

    /// An adult entertainment establishment.
    let AdultEntertainment = _prefix "AdultEntertainment"
          

    /// An advertising section of the page.
    let WPAdBlock = _prefix "WPAdBlock"
          

    /// An agent approves/certifies/likes/supports/sanction an object.
    let EndorseAction = _prefix "EndorseAction"
          

    /// An agent bookmarks/flags/labels/tags/marks an object.
    let BookmarkAction = _prefix "BookmarkAction"
          

    /// An agent controls a device or application.
    let ControlAction = _prefix "ControlAction"
          

    /// An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.
    let CheckAction = _prefix "CheckAction"
          

    /// An agent joins an event/group with participants/friends at a location.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/RegisterAction">RegisterAction</a>: Unlike RegisterAction, JoinAction refers to joining a group/team of people.</li>
/// <li><a class="localLink" href="http://schema.org/SubscribeAction">SubscribeAction</a>: Unlike SubscribeAction, JoinAction does not imply that you'll be receiving updates.</li>
/// <li><a class="localLink" href="http://schema.org/FollowAction">FollowAction</a>: Unlike FollowAction, JoinAction does not imply that you'll be polling for updates.</li>
/// </ul>
/// 
    let JoinAction = _prefix "JoinAction"
          

    /// An agent leaves an event / group with participants/friends at a location.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/JoinAction">JoinAction</a>: The antonym of LeaveAction.</li>
/// <li><a class="localLink" href="http://schema.org/UnRegisterAction">UnRegisterAction</a>: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.</li>
/// </ul>
/// 
    let LeaveAction = _prefix "LeaveAction"
          

    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    let PreOrderAction = _prefix "PreOrderAction"
          

    /// An agent orders an object/product/service to be delivered/sent.
    let OrderAction = _prefix "OrderAction"
          

    /// An agent pays a price to a participant.
    let PayAction = _prefix "PayAction"
          

    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    let QuoteAction = _prefix "QuoteAction"
          

    /// An agent tracks an object for updates.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/FollowAction">FollowAction</a>: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.</li>
/// <li><a class="localLink" href="http://schema.org/SubscribeAction">SubscribeAction</a>: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.</li>
/// </ul>
/// 
    let TrackAction = _prefix "TrackAction"
          

    /// An aggregate rating of an Organization related to its role as an employer.
    let EmployerAggregateRating = _prefix "EmployerAggregateRating"
          

    /// An airline flight.
    let Flight = _prefix "Flight"
          

    /// An airport.
    let Airport = _prefix "Airport"
          

    /// An alias for the item.
    let alternateName = _prefix "alternateName"
          

    /// An alignment to an established educational framework.
    let educationalAlignment = _prefix "educationalAlignment"
          

    /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
    let amenityFeature = _prefix "amenityFeature"
          

    /// An amusement park.
    let AmusementPark = _prefix "AmusementPark"
          

    /// An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
    let suggestedAnswer = _prefix "suggestedAnswer"
          

    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    let Answer = _prefix "Answer"
          

    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (Source: Wikipedia, the free encyclopedia, see <a href="http://en.wikipedia.org/wiki/Apartment">http://en.wikipedia.org/wiki/Apartment</a>).
    let Apartment = _prefix "Apartment"
          

    /// An application that can complete the request.
    let actionApplication = _prefix "actionApplication"
          

    /// An application that can complete the request.
    let application = _prefix "application"
          

    /// An arrangement derived from the composition.
    let musicArrangement = _prefix "musicArrangement"
          

    /// An art gallery.
    let ArtGallery = _prefix "ArtGallery"
          

    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.<br/><br/>
/// 
/// See also <a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html">blog post</a>.
    let Article = _prefix "Article"
          

    /// An associated logo.
    let logo = _prefix "logo"
          

    /// An audio file.
    let AudioObject = _prefix "AudioObject"
          

    /// An audio recording of the work.
    let recordedAs = _prefix "recordedAs"
          

    /// An auto parts store.
    let AutoPartsStore = _prefix "AutoPartsStore"
          

    /// An automatic payment system is in place and will be used.
    let PaymentAutomaticallyApplied = _prefix "PaymentAutomaticallyApplied"
          

    /// An award won by or for this item.
    let award = _prefix "award"
          

    /// An car dealership.
    let AutoDealer = _prefix "AutoDealer"
          

    /// An educational organization.
    let EducationalOrganization = _prefix "EducationalOrganization"
          

    /// An educationalRole of an EducationalAudience.
    let educationalRole = _prefix "educationalRole"
          

    /// An electrician.
    let Electrician = _prefix "Electrician"
          

    /// An electronic file or document.
    let DigitalDocument = _prefix "DigitalDocument"
          

    /// An electronics store.
    let ElectronicsStore = _prefix "ElectronicsStore"
          

    /// An elementary school.
    let ElementarySchool = _prefix "ElementarySchool"
          

    /// An email message.
    let EmailMessage = _prefix "EmailMessage"
          

    /// An embassy.
    let Embassy = _prefix "Embassy"
          

    /// An embedded audio object.
    let audio = _prefix "audio"
          

    /// An embedded video object.
    let video = _prefix "video"
          

    /// An emergency service, such as a fire station or ER.
    let EmergencyService = _prefix "EmergencyService"
          

    /// An employment agency.
    let EmploymentAgency = _prefix "EmploymentAgency"
          

    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also <a class="localLink" href="http://schema.org/BedType">BedType</a> (under development).
    let BedDetails = _prefix "BedDetails"
          

    /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')'.
    let item = _prefix "item"
          

    /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
    let broker = _prefix "broker"
          

    /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
    let seller = _prefix "seller"
          

    /// An entry point, within some Web-based protocol.
    let EntryPoint = _prefix "EntryPoint"
          

    /// An enumeration of genders.
    let GenderType = _prefix "GenderType"
          

    /// An enumeration of several kinds of Map.
    let MapCategoryType = _prefix "MapCategoryType"
          

    /// An episode of a TV/radio series or season.
    let episodes = _prefix "episodes"
          

    /// An episode of a tv, radio or game media within a series or season.
    let episode = _prefix "episode"
          

    /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
    let estimatedSalary = _prefix "estimatedSalary"
          

    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the <a class="localLink" href="http://schema.org/offers">offers</a> property. Repeated events may be structured as separate Event objects.
    let Event = _prefix "Event"
          

    /// An event involving the delivery of an item.
    let DeliveryEvent = _prefix "DeliveryEvent"
          

    /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
    let superEvent = _prefix "superEvent"
          

    /// An event venue.
    let EventVenue = _prefix "EventVenue"
          

    /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
    let eventStatus = _prefix "eventStatus"
          

    /// An explanation in the instructions for how to achieve a result. It provides supplementary information about a technique, supply, author's preference, etc. It can explain what could be done, or what should not be done, but doesn't specify what should be done (see HowToDirection).
    let HowToTip = _prefix "HowToTip"
          

    /// An historical landmark or building.
    let LandmarksOrHistoricalBuildings = _prefix "LandmarksOrHistoricalBuildings"
          

    /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
    let honorificPrefix = _prefix "honorificPrefix"
          

    /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
    let honorificSuffix = _prefix "honorificSuffix"
          

    /// An ice cream shop.
    let IceCreamShop = _prefix "IceCreamShop"
          

    /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
    let paymentMethodId = _prefix "paymentMethodId"
          

    /// An image file.
    let ImageObject = _prefix "ImageObject"
          

    /// An image of a visual machine-readable code such as a barcode or QR code.
    let Barcode = _prefix "Barcode"
          

    /// An image of the item. This can be a <a class="localLink" href="http://schema.org/URL">URL</a> or a fully described <a class="localLink" href="http://schema.org/ImageObject">ImageObject</a>.
    let image = _prefix "image"
          

    /// An in-progress action (e.g, while watching the movie, or driving to a location).
    let ActiveActionStatus = _prefix "ActiveActionStatus"
          

    /// An instance of a <a class="localLink" href="http://schema.org/Course">Course</a> which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    let CourseInstance = _prefix "CourseInstance"
          

    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    let AlignmentObject = _prefix "AlignmentObject"
          

    /// An intended audience, i.e. a group for whom something was created.
    let audience = _prefix "audience"
          

    /// An internet cafe.
    let InternetCafe = _prefix "InternetCafe"
          

    /// An item being offered (or demanded). The transactional nature of the offer or demand is documented using <a class="localLink" href="http://schema.org/businessFunction">businessFunction</a>, e.g. sell, lease etc. While several common expected types are listed explicitly in this definition, others can be used. Using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
    let itemOffered = _prefix "itemOffered"
          

    /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
    let gameItem = _prefix "gameItem"
          

    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    let HowToItem = _prefix "HowToItem"
          

    /// An item within in a data feed. Data feeds may have many elements.
    let dataFeedElement = _prefix "dataFeedElement"
          

    /// An list item, e.g. a step in a checklist or how-to description.
    let ListItem = _prefix "ListItem"
          

    /// An ocean (for example, the Pacific).
    let OceanBodyOfWater = _prefix "OceanBodyOfWater"
          

    /// An offer to provide this item&#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use <a class="localLink" href="http://schema.org/businessFunction">businessFunction</a> to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a <a class="localLink" href="http://schema.org/Demand">Demand</a>. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
    let offers = _prefix "offers"
          

    /// An offer to transfer some rights to an item or to provide a service - for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.<br/><br/>
/// 
/// Note: As the <a class="localLink" href="http://schema.org/businessFunction">businessFunction</a> property, which identifies the form of offer (e.g. sell, lease, repair, dispose), defaults to http://purl.org/goodrelations/v1#Sell; an Offer without a defined businessFunction value can be assumed to be an offer to sell.<br/><br/>
/// 
/// For <a href="http://www.gs1.org/barcodes/technical/idkeys/gtin">GTIN</a>-related fields, see <a href="http://www.gs1.org/barcodes/support/check_digit_calculator">Check Digit calculator</a> and <a href="http://www.gs1us.org/resources/standards/gtin-validation-guide">validation guide</a> from <a href="http://www.gs1.org/">GS1</a>.
    let Offer = _prefix "Offer"
          

    /// An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
    let hasCourseInstance = _prefix "hasCourseInstance"
          

    /// An office equipment store.
    let OfficeEquipmentStore = _prefix "OfficeEquipmentStore"
          

    /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
    let starRating = _prefix "starRating"
          

    /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
    let contactOption = _prefix "contactOption"
          

    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    let Order = _prefix "Order"
          

    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    let OrderItem = _prefix "OrderItem"
          

    /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
    let leiCode = _prefix "leiCode"
          

    /// An organization such as a school, NGO, corporation, club, etc.
    let Organization = _prefix "Organization"
          

    /// An organization that provides flights for passengers.
    let Airline = _prefix "Airline"
          

    /// An organization that the person is an alumni of.
    let alumniOf = _prefix "alumniOf"
          

    /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
    let affiliation = _prefix "affiliation"
          

    /// An organizer of an Event.
    let organizer = _prefix "organizer"
          

    /// An outlet store.
    let OutletStore = _prefix "OutletStore"
          

    /// An over the air or online broadcast event.
    let BroadcastEvent = _prefix "BroadcastEvent"
          

    /// An update to the LiveBlog.
    let liveBlogUpdate = _prefix "liveBlogUpdate"
          

    /// An url template (RFC6570) that will be used to construct the target of the execution of the action.
    let urlTemplate = _prefix "urlTemplate"
          

    /// Animal shelter.
    let AnimalShelter = _prefix "AnimalShelter"
          

    /// Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.
    let Specialty = _prefix "Specialty"
          

    /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
    let pagination = _prefix "pagination"
          

    /// Any discount applied (to an Order).
    let discount = _prefix "discount"
          

    /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
    let programMembershipUsed = _prefix "programMembershipUsed"
          

    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    let Product = _prefix "Product"
          

    /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
    let specialCommitments = _prefix "specialCommitments"
          

    /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'PT30M', 'PT1H25M'.
    let timeRequired = _prefix "timeRequired"
          

    /// Aquarium.
    let Aquarium = _prefix "Aquarium"
          

    /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
    let articleSection = _prefix "articleSection"
          

    /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
    let requiredCollateral = _prefix "requiredCollateral"
          

    /// Associated product/technology version. e.g., .NET Framework 4.5.
    let assemblyVersion = _prefix "assemblyVersion"
          

    /// Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.
    let touristType = _prefix "touristType"
          

    /// Audiences defined by a person's gender.
    let requiredGender = _prefix "requiredGender"
          

    /// Audiences defined by a person's maximum age.
    let requiredMaxAge = _prefix "requiredMaxAge"
          

    /// Audiences defined by a person's minimum age.
    let requiredMinAge = _prefix "requiredMinAge"
          

    /// Auto body shop.
    let AutoBodyShop = _prefix "AutoBodyShop"
          

    /// Awards won by or for this item.
    let awards = _prefix "awards"
          

    /// Bank or credit union.
    let BankOrCreditUnion = _prefix "BankOrCreditUnion"
          

    /// Beach.
    let Beach = _prefix "Beach"
          

    /// Beauty salon.
    let BeautySalon = _prefix "BeautySalon"
          

    /// Bed and breakfast.
/// <br /><br />
/// See also the <a href="/docs/hotels.html">dedicated document on the use of schema.org for marking up hotels and other forms of accommodations</a>.
    let BedAndBreakfast = _prefix "BedAndBreakfast"
          

    /// Book format: Audiobook. This is an enumerated value for use with the bookFormat property. There is also a type 'Audiobook' in the bib extension which includes Audiobook specific properties.
    let AudiobookFormat = _prefix "AudiobookFormat"
          

    /// Book format: Ebook.
    let EBook = _prefix "EBook"
          

    /// Book format: Hardcover.
    let Hardcover = _prefix "Hardcover"
          

    /// Book format: Paperback.
    let Paperback = _prefix "Paperback"
          

    /// Boolean: True or False.
    let Boolean = _prefix "Boolean"
          

    /// Brewery.
    let Brewery = _prefix "Brewery"
          

    /// BroadcastRelease.
    let BroadcastRelease = _prefix "BroadcastRelease"
          

    /// CDFormat.
    let CDFormat = _prefix "CDFormat"
          

    /// Car repair business.
    let AutoRepair = _prefix "AutoRepair"
          

    /// Car repair, sales, or parts.
    let AutomotiveBusiness = _prefix "AutomotiveBusiness"
          

    /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
    let paymentAccepted = _prefix "paymentAccepted"
          

    /// CassetteFormat.
    let CassetteFormat = _prefix "CassetteFormat"
          

    /// Cheat codes to the game.
    let cheatCode = _prefix "cheatCode"
          

    /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
    let MusicAlbumProductionType = _prefix "MusicAlbumProductionType"
          

    /// Classification of the album by it's type of content: soundtrack, live album, studio album, etc.
    let albumProductionType = _prefix "albumProductionType"
          

    /// Code used to redeem a discount.
    let discountCode = _prefix "discountCode"
          

    /// Comments, typically from users.
    let comment = _prefix "comment"
          

    /// CompilationAlbum.
    let CompilationAlbum = _prefix "CompilationAlbum"
          

    /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
    let requirements = _prefix "requirements"
          

    /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
    let softwareRequirements = _prefix "softwareRequirements"
          

    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    let Code = _prefix "Code"
          

    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    let SoftwareSourceCode = _prefix "SoftwareSourceCode"
          

    /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (<a href="http://www.w3.org/wiki/WebSchemas/Accessibility">WebSchemas wiki lists possible values</a>).
    let accessibilityFeature = _prefix "accessibilityFeature"
          

    /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    let countriesNotSupported = _prefix "countriesNotSupported"
          

    /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    let countriesSupported = _prefix "countriesSupported"
          

    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    let TVSeries = _prefix "TVSeries"
          

    /// CreativeWorkSeries dedicated to radio broadcast and associated online delivery.
    let RadioSeries = _prefix "RadioSeries"
          

    /// DJMixAlbum.
    let DJMixAlbum = _prefix "DJMixAlbum"
          

    /// DVDFormat.
    let DVDFormat = _prefix "DVDFormat"
          

    /// Data type: Floating number.
    let Float = _prefix "Float"
          

    /// Data type: Integer.
    let Integer = _prefix "Integer"
          

    /// Data type: Number.<br/><br/>
/// 
/// Usage guidelines:<br/><br/>
/// 
/// <ul>
/// <li>Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.</li>
/// <li>Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.</li>
/// </ul>
/// 
    let Number = _prefix "Number"
          

    /// Data type: Text.
    let Text = _prefix "Text"
          

    /// Data type: URL.
    let URL = _prefix "URL"
          

    /// Date of birth.
    let birthDate = _prefix "birthDate"
          

    /// Date of death.
    let deathDate = _prefix "deathDate"
          

    /// Date of first broadcast/publication.
    let datePublished = _prefix "datePublished"
          

    /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
    let lastReviewed = _prefix "lastReviewed"
          

    /// Date order was placed.
    let orderDate = _prefix "orderDate"
          

    /// Date the content expires and is no longer useful or available. For example a <a class="localLink" href="http://schema.org/VideoObject">VideoObject</a> or <a class="localLink" href="http://schema.org/NewsArticle">NewsArticle</a> whose availability or relevance is time-limited, or a <a class="localLink" href="http://schema.org/ClaimReview">ClaimReview</a> fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
    let expires = _prefix "expires"
          

    /// Date when this media object was uploaded to this site.
    let uploadDate = _prefix "uploadDate"
          

    /// DemoAlbum.
    let DemoAlbum = _prefix "DemoAlbum"
          

    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. <br/><br/>
/// 
/// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use <a class="localLink" href="http://schema.org/Offer">Offer</a>.
    let Reservation = _prefix "Reservation"
          

    /// Description of benefits associated with the job.
    let benefits = _prefix "benefits"
          

    /// Description of benefits associated with the job.
    let jobBenefits = _prefix "jobBenefits"
          

    /// Description of bonus and commission compensation aspects of the job.
    let incentiveCompensation = _prefix "incentiveCompensation"
          

    /// Description of bonus and commission compensation aspects of the job.
    let incentives = _prefix "incentives"
          

    /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
    let feesAndCommissionsSpecification = _prefix "feesAndCommissionsSpecification"
          

    /// Description of skills and experience needed for the position or Occupation.
    let experienceRequirements = _prefix "experienceRequirements"
          

    /// Description of the meals that will be provided or available for purchase.
    let mealService = _prefix "mealService"
          

    /// Description of what changed in this version.
    let releaseNotes = _prefix "releaseNotes"
          

    /// Destination address.
    let deliveryAddress = _prefix "deliveryAddress"
          

    /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
    let availableOnDevice = _prefix "availableOnDevice"
          

    /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
    let device = _prefix "device"
          

    /// DigitalAudioTapeFormat.
    let DigitalAudioTapeFormat = _prefix "DigitalAudioTapeFormat"
          

    /// DigitalFormat.
    let DigitalFormat = _prefix "DigitalFormat"
          

    /// EPRelease.
    let EPRelease = _prefix "EPRelease"
          

    /// Either the actual menu as a structured representation, as text, or a URL of the menu.
    let hasMenu = _prefix "hasMenu"
          

    /// Either the actual menu as a structured representation, as text, or a URL of the menu.
    let menu = _prefix "menu"
          

    /// Email address.
    let email = _prefix "email"
          

    /// Entities that have a somewhat fixed, physical extension.
    let Place = _prefix "Place"
          

    /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    let ItemListOrderType = _prefix "ItemListOrderType"
          

    /// Enumerated options related to a ContactPoint.
    let ContactPointOption = _prefix "ContactPointOption"
          

    /// Enumerated status values for Order.
    let OrderStatus = _prefix "OrderStatus"
          

    /// Enumerated status values for Reservation.
    let ReservationStatusType = _prefix "ReservationStatusType"
          

    /// Estimated processing time for the service using this channel.
    let processingTime = _prefix "processingTime"
          

    /// Event that this person is a performer or participant in.
    let performerIn = _prefix "performerIn"
          

    /// Event type: A social dance.
    let DanceEvent = _prefix "DanceEvent"
          

    /// Event type: Business event.
    let BusinessEvent = _prefix "BusinessEvent"
          

    /// Event type: Children's event.
    let ChildrensEvent = _prefix "ChildrensEvent"
          

    /// Event type: Comedy event.
    let ComedyEvent = _prefix "ComedyEvent"
          

    /// Event type: Education event.
    let EducationEvent = _prefix "EducationEvent"
          

    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    let ExhibitionEvent = _prefix "ExhibitionEvent"
          

    /// Event type: Festival.
    let Festival = _prefix "Festival"
          

    /// Event type: Food event.
    let FoodEvent = _prefix "FoodEvent"
          

    /// Event type: Literary event.
    let LiteraryEvent = _prefix "LiteraryEvent"
          

    /// Event type: Music event.
    let MusicEvent = _prefix "MusicEvent"
          

    /// Event type: Sales event.
    let SaleEvent = _prefix "SaleEvent"
          

    /// Event type: Social event.
    let SocialEvent = _prefix "SocialEvent"
          

    /// Event type: Sports event.
    let SportsEvent = _prefix "SportsEvent"
          

    /// Event type: Theater performance.
    let TheaterEvent = _prefix "TheaterEvent"
          

    /// Event type: Visual arts event.
    let VisualArtsEvent = _prefix "VisualArtsEvent"
          

    /// EventStatusType is an enumeration type whose instances represent several states that an Event may be in.
    let EventStatusType = _prefix "EventStatusType"
          

    /// Events that are a part of this event. For example, a conference event includes many presentations, each subEvents of the conference.
    let subEvents = _prefix "subEvents"
          

    /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
    let workExample = _prefix "workExample"
          

    /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
    let familyName = _prefix "familyName"
          

    /// Features or modules provided by this application (and possibly required by other applications).
    let featureList = _prefix "featureList"
          

    /// Fictional person connected with a creative work.
    let character = _prefix "character"
          

    /// File size in (mega/kilo) bytes.
    let contentSize = _prefix "contentSize"
          

    /// Financial services business.
    let FinancialService = _prefix "FinancialService"
          

    /// For failed actions, more information on the cause of the failure.
    let error = _prefix "error"
          

    /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.<br/><br/>
/// 
/// Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.<br/><br/>
/// 
/// Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
    let itemListElement = _prefix "itemListElement"
          

    /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
    let MusicReleaseFormatType = _prefix "MusicReleaseFormatType"
          

    /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
    let musicReleaseFormat = _prefix "musicReleaseFormat"
          

    /// Four-wheel drive is a transmission layout where the engine primarily drives two wheels with a part-time four-wheel drive capability.
    let FourWheelDriveConfiguration = _prefix "FourWheelDriveConfiguration"
          

    /// Front-wheel drive is a transmission layout where the engine drives the front wheels.
    let FrontWheelDriveConfiguration = _prefix "FrontWheelDriveConfiguration"
          

    /// Game server status: OfflinePermanently. Server is offline and not available.
    let OfflinePermanently = _prefix "OfflinePermanently"
          

    /// Game server status: OfflineTemporarily. Server is offline now but it can be online soon.
    let OfflineTemporarily = _prefix "OfflineTemporarily"
          

    /// Game server status: Online. Server is available.
    let Online = _prefix "Online"
          

    /// Game server status: OnlineFull. Server is online but unavailable. The maximum number of players has reached.
    let OnlineFull = _prefix "OnlineFull"
          

    /// Genre of the creative work, broadcast channel or group.
    let genre = _prefix "genre"
          

    /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
    let givenName = _prefix "givenName"
          

    /// Headline of the article.
    let headline = _prefix "headline"
          

    /// Health and beauty.
    let HealthAndBeautyBusiness = _prefix "HealthAndBeautyBusiness"
          

    /// IATA identifier for an airline or airport.
    let iataCode = _prefix "iataCode"
          

    /// ICAO identifier for an airport.
    let icaoCode = _prefix "icaoCode"
          

    /// Identifier of the flight's arrival gate.
    let arrivalGate = _prefix "arrivalGate"
          

    /// Identifier of the flight's arrival terminal.
    let arrivalTerminal = _prefix "arrivalTerminal"
          

    /// Identifier of the flight's departure gate.
    let departureGate = _prefix "departureGate"
          

    /// Identifier of the flight's departure terminal.
    let departureTerminal = _prefix "departureTerminal"
          

    /// Identifies input methods that are sufficient to fully control the described resource (<a href="http://www.w3.org/wiki/WebSchemas/Accessibility">WebSchemas wiki lists possible values</a>).
    let accessibilityControl = _prefix "accessibilityControl"
          

    /// Identifies the issue of publication; for example, "iii" or "2".
    let issueNumber = _prefix "issueNumber"
          

    /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
    let volumeNumber = _prefix "volumeNumber"
          

    /// If responding yes, the number of guests who will attend in addition to the invitee.
    let additionalNumberOfGuests = _prefix "additionalNumberOfGuests"
          

    /// If the file can be downloaded, URL to download the binary.
    let downloadUrl = _prefix "downloadUrl"
          

    /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
    let transcript = _prefix "transcript"
          

    /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
    let printPage = _prefix "printPage"
          

    /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
    let printSection = _prefix "printSection"
          

    /// Indicate how many people can play this game (minimum, maximum, or range).
    let numberOfPlayers = _prefix "numberOfPlayers"
          

    /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
    let schemaVersion = _prefix "schemaVersion"
          

    /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
    let suitableForDiet = _prefix "suitableForDiet"
          

    /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See <a href="/docs/datamodel.html#mainEntityBackground">background notes</a> for details.
    let mainEntityOfPage = _prefix "mainEntityOfPage"
          

    /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
    let potentialAction = _prefix "potentialAction"
          

    /// Indicates a target EntryPoint for an Action.
    let target = _prefix "target"
          

    /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
    let hasOfferCatalog = _prefix "hasOfferCatalog"
          

    /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).
    let hasPart = _prefix "hasPart"
          

    /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.
    let isPartOf = _prefix "isPartOf"
          

    /// Indicates if this web page element is the main subject of the page.
    let mainContentOfPage = _prefix "mainContentOfPage"
          

    /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are <code>true</code> or <code>false</code> (note that an earlier version had 'yes', 'no').
    let requiresSubscription = _prefix "requiresSubscription"
          

    /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.<br/><br/>
/// 
/// The <em>speakable</em> property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:<br/><br/>
/// 
/// 1.) <em>id-value</em> URL references - uses <em>id-value</em> of an element in the page being annotated. The simplest use of <em>speakable</em> has (potentially relative) URL values, referencing identified sections of the document concerned.<br/><br/>
/// 
/// 2.) CSS Selectors - addresses content in the annotated page, eg. via class attribute. Use the <a class="localLink" href="http://schema.org/cssSelector">cssSelector</a> property.<br/><br/>
/// 
/// 3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the <a class="localLink" href="http://schema.org/xpath">xpath</a> property.<br/><br/>
/// 
/// For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
/// we define a supporting type, <a class="localLink" href="http://schema.org/SpeakableSpecification">SpeakableSpecification</a>  which is defined to be a possible value of the <em>speakable</em> property.
    let speakable = _prefix "speakable"
          

    /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
    let mentions = _prefix "mentions"
          

    /// Indicates that the event was changed to allow online participation. See <a class="localLink" href="http://schema.org/eventAttendanceMode">eventAttendanceMode</a> for specifics of whether it is now fully or partially online.
    let EventMovedOnline = _prefix "EventMovedOnline"
          

    /// Indicates that the item has been discontinued.
    let Discontinued = _prefix "Discontinued"
          

    /// Indicates that the item has limited availability.
    let LimitedAvailability = _prefix "LimitedAvailability"
          

    /// Indicates that the item has sold out.
    let SoldOut = _prefix "SoldOut"
          

    /// Indicates that the item is available for ordering and delivery before general availability.
    let PreSale = _prefix "PreSale"
          

    /// Indicates that the item is available for pre-order.
    let PreOrder = _prefix "PreOrder"
          

    /// Indicates that the item is available only at physical locations.
    let InStoreOnly = _prefix "InStoreOnly"
          

    /// Indicates that the item is available only online.
    let OnlineOnly = _prefix "OnlineOnly"
          

    /// Indicates that the item is damaged.
    let DamagedCondition = _prefix "DamagedCondition"
          

    /// Indicates that the item is in stock.
    let InStock = _prefix "InStock"
          

    /// Indicates that the item is new.
    let NewCondition = _prefix "NewCondition"
          

    /// Indicates that the item is out of stock.
    let OutOfStock = _prefix "OutOfStock"
          

    /// Indicates that the item is refurbished.
    let RefurbishedCondition = _prefix "RefurbishedCondition"
          

    /// Indicates that the item is used.
    let UsedCondition = _prefix "UsedCondition"
          

    /// Indicates that the resource is compatible with the referenced accessibility API (<a href="http://www.w3.org/wiki/WebSchemas/Accessibility">WebSchemas wiki lists possible values</a>).
    let accessibilityAPI = _prefix "accessibilityAPI"
          

    /// Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.
    let geoMidpoint = _prefix "geoMidpoint"
          

    /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
    let geoRadius = _prefix "geoRadius"
          

    /// Indicates the current disposition of the Action.
    let actionStatus = _prefix "actionStatus"
          

    /// Indicates the kind of Map, from the MapCategoryType Enumeration.
    let mapType = _prefix "mapType"
          

    /// Indicates the main image on the page.
    let primaryImageOfPage = _prefix "primaryImageOfPage"
          

    /// Indicates the mobility of a provided service (e.g. 'static', 'dynamic').
    let providerMobility = _prefix "providerMobility"
          

    /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
    let valueName = _prefix "valueName"
          

    /// Indicates the primary entity described in some page or other CreativeWork.
    let mainEntity = _prefix "mainEntity"
          

    /// Indicates whether API is managed or unmanaged.
    let programmingModel = _prefix "programmingModel"
          

    /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings <code>Yes</code> or <code>No</code>.
    let acceptsReservations = _prefix "acceptsReservations"
          

    /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
    let smokingAllowed = _prefix "smokingAllowed"
          

    /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
    let petsAllowed = _prefix "petsAllowed"
          

    /// Indicates whether this content is family friendly.
    let isFamilyFriendly = _prefix "isFamilyFriendly"
          

    /// Indicates whether this game is multi-player, co-op or single-player.
    let GamePlayMode = _prefix "GamePlayMode"
          

    /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
    let playMode = _prefix "playMode"
          

    /// Indicates whether this image is representative of the content of the page.
    let representativeOfPage = _prefix "representativeOfPage"
          

    /// Indications regarding the permitted usage of the accommodation.
    let permittedUsage = _prefix "permittedUsage"
          

    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    let EngineSpecification = _prefix "EngineSpecification"
          

    /// Information about the engine or engines of the vehicle.
    let vehicleEngine = _prefix "vehicleEngine"
          

    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    let HowTo = _prefix "HowTo"
          

    /// Intended audience for an item, i.e. the group for whom the item was created.
    let Audience = _prefix "Audience"
          

    /// Item(s) being shipped.
    let itemShipped = _prefix "itemShipped"
          

    /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
    let keywords = _prefix "keywords"
          

    /// LaserDiscFormat.
    let LaserDiscFormat = _prefix "LaserDiscFormat"
          

    /// Library file name e.g., mscorlib.dll, system.web.dll.
    let assembly = _prefix "assembly"
          

    /// Library file name e.g., mscorlib.dll, system.web.dll.
    let executableLibraryName = _prefix "executableLibraryName"
          

    /// Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex).
    let codeRepository = _prefix "codeRepository"
          

    /// Links to tips, tactics, etc.
    let gameTip = _prefix "gameTip"
          

    /// Lists or enumerations-for example, a list of cuisines or music genres, etc.
    let Enumeration = _prefix "Enumeration"
          

    /// LiveAlbum.
    let LiveAlbum = _prefix "LiveAlbum"
          

    /// Maximal age of the child.
    let childMaxAge = _prefix "childMaxAge"
          

    /// Maximal age recommended for viewing content.
    let suggestedMaxAge = _prefix "suggestedMaxAge"
          

    /// Media type typically expressed using a MIME format (see <a href="http://www.iana.org/assignments/media-types/media-types.xhtml">IANA site</a> and <a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types">MDN reference</a>) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).<br/><br/>
/// 
/// In cases where a <a class="localLink" href="http://schema.org/CreativeWork">CreativeWork</a> has several media type representations, <a class="localLink" href="http://schema.org/encoding">encoding</a> can be used to indicate each <a class="localLink" href="http://schema.org/MediaObject">MediaObject</a> alongside particular <a class="localLink" href="http://schema.org/encodingFormat">encodingFormat</a> information.<br/><br/>
/// 
/// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
    let encodingFormat = _prefix "encodingFormat"
          

    /// Media type, typically MIME format (see <a href="http://www.iana.org/assignments/media-types/media-types.xhtml">IANA site</a>) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.
    let fileFormat = _prefix "fileFormat"
          

    /// Method used for delivery or shipping.
    let hasDeliveryMethod = _prefix "hasDeliveryMethod"
          

    /// Minimal age of the child.
    let childMinAge = _prefix "childMinAge"
          

    /// Minimal age recommended for viewing content.
    let suggestedMinAge = _prefix "suggestedMinAge"
          

    /// Minimum memory requirements.
    let memoryRequirements = _prefix "memoryRequirements"
          

    /// MixtapeAlbum.
    let MixtapeAlbum = _prefix "MixtapeAlbum"
          

    /// Nationality of the person.
    let nationality = _prefix "nationality"
          

    /// Natural languages such as Spanish, Tamil, Hindi, English, etc. Formal language code tags expressed in <a href="https://en.wikipedia.org/wiki/IETF_language_tag">BCP 47</a> can be used via the <a class="localLink" href="http://schema.org/alternateName">alternateName</a> property. The Language type previously also covered programming languages such as Scheme and Lisp, which are now best represented using <a class="localLink" href="http://schema.org/ComputerLanguage">ComputerLanguage</a>.
    let Language = _prefix "Language"
          

    /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
    let deliveryStatus = _prefix "deliveryStatus"
          

    /// Number of people the reservation should accommodate.
    let partySize = _prefix "partySize"
          

    /// Number of players on the server.
    let playersOnline = _prefix "playersOnline"
          

    /// Nutrition information about the recipe or menu item.
    let nutrition = _prefix "nutrition"
          

    /// Nutritional information about the recipe.
    let NutritionInformation = _prefix "NutritionInformation"
          

    /// Official rating of a piece of content&#x2014;for example,'MPAA PG-13'.
    let contentRating = _prefix "contentRating"
          

    /// One of the continents (for example, Europe or Africa).
    let Continent = _prefix "Continent"
          

    /// One of the domain specialities to which this web page's content applies.
    let specialty = _prefix "specialty"
          

    /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
    let significantLink = _prefix "significantLink"
          

    /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
    let priceSpecification = _prefix "priceSpecification"
          

    /// One or more messages between organizations or people on a particular topic. Individual messages can be linked to the conversation with isPartOf or hasPart properties.
    let Conversation = _prefix "Conversation"
          

    /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
    let operatingSystem = _prefix "operatingSystem"
          

    /// OrderStatus representing availability of an order for pickup.
    let OrderPickupAvailable = _prefix "OrderPickupAvailable"
          

    /// OrderStatus representing cancellation of an order.
    let OrderCancelled = _prefix "OrderCancelled"
          

    /// OrderStatus representing successful delivery of an order.
    let OrderDelivered = _prefix "OrderDelivered"
          

    /// OrderStatus representing that an order has been returned.
    let OrderReturned = _prefix "OrderReturned"
          

    /// OrderStatus representing that an order is being processed.
    let OrderProcessing = _prefix "OrderProcessing"
          

    /// OrderStatus representing that an order is in transit.
    let OrderInTransit = _prefix "OrderInTransit"
          

    /// OrderStatus representing that payment is due on an order.
    let OrderPaymentDue = _prefix "OrderPaymentDue"
          

    /// OrderStatus representing that there is a problem with the order.
    let OrderProblem = _prefix "OrderProblem"
          

    /// Organization offering the job position.
    let hiringOrganization = _prefix "hiringOrganization"
          

    /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
    let translator = _prefix "translator"
          

    /// Organization: A business corporation.
    let Corporation = _prefix "Corporation"
          

    /// Organization: Non-governmental Organization.
    let NGO = _prefix "NGO"
          

    /// Organization: Sports team.
    let SportsTeam = _prefix "SportsTeam"
          

    /// Organizations that the person works for.
    let worksFor = _prefix "worksFor"
          

    /// Original definition: "provider of professional services."<br/><br/>
/// 
/// The general <a class="localLink" href="http://schema.org/ProfessionalService">ProfessionalService</a> type for local businesses was deprecated due to confusion with <a class="localLink" href="http://schema.org/Service">Service</a>. For reference, the types that it included were: <a class="localLink" href="http://schema.org/Dentist">Dentist</a>,
///         <a class="localLink" href="http://schema.org/AccountingService">AccountingService</a>, <a class="localLink" href="http://schema.org/Attorney">Attorney</a>, <a class="localLink" href="http://schema.org/Notary">Notary</a>, as well as types for several kinds of <a class="localLink" href="http://schema.org/HomeAndConstructionBusiness">HomeAndConstructionBusiness</a>: <a class="localLink" href="http://schema.org/Electrician">Electrician</a>, <a class="localLink" href="http://schema.org/GeneralContractor">GeneralContractor</a>,
///         <a class="localLink" href="http://schema.org/HousePainter">HousePainter</a>, <a class="localLink" href="http://schema.org/Locksmith">Locksmith</a>, <a class="localLink" href="http://schema.org/Plumber">Plumber</a>, <a class="localLink" href="http://schema.org/RoofingContractor">RoofingContractor</a>. <a class="localLink" href="http://schema.org/LegalService">LegalService</a> was introduced as a more inclusive supertype of <a class="localLink" href="http://schema.org/Attorney">Attorney</a>.
    let ProfessionalService = _prefix "ProfessionalService"
          

    /// Other co-agents that participated in the action indirectly. e.g. John wrote a book with <em>Steve</em>.
    let participant = _prefix "participant"
          

    /// Party placing the order or paying the invoice.
    let customer = _prefix "customer"
          

    /// Password, PIN, or access code needed for delivery (e.g. from a locker).
    let accessCode = _prefix "accessCode"
          

    /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
    let reviewedBy = _prefix "reviewedBy"
          

    /// People working for this organization.
    let employees = _prefix "employees"
          

    /// Permission to add comments to the document.
    let CommentPermission = _prefix "CommentPermission"
          

    /// Permission to read or view the document.
    let ReadPermission = _prefix "ReadPermission"
          

    /// Permission to write or edit the document.
    let WritePermission = _prefix "WritePermission"
          

    /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
    let permissions = _prefix "permissions"
          

    /// Photographs of this place.
    let photos = _prefix "photos"
          

    /// Physical address of the item.
    let address = _prefix "address"
          

    /// Place of worship, such as a church, synagogue, or mosque.
    let PlaceOfWorship = _prefix "PlaceOfWorship"
          

    /// Play mode: CoOp. Co-operative games, where you play on the same team with friends.
    let CoOp = _prefix "CoOp"
          

    /// Play mode: MultiPlayer. Requiring or allowing multiple human players to play simultaneously.
    let MultiPlayer = _prefix "MultiPlayer"
          

    /// Play mode: SinglePlayer. Which is played by a lone player.
    let SinglePlayer = _prefix "SinglePlayer"
          

    /// Player type required&#x2014;for example, Flash or Silverlight.
    let playerType = _prefix "playerType"
          

    /// Points-of-Sales operated by the organization or person.
    let hasPOS = _prefix "hasPOS"
          

    /// Position of the clip within an ordered group of clips.
    let clipNumber = _prefix "clipNumber"
          

    /// Position of the episode within an ordered group of episodes.
    let episodeNumber = _prefix "episodeNumber"
          

    /// Position of the season within an ordered group of seasons.
    let seasonNumber = _prefix "seasonNumber"
          

    /// Prerequisites needed to fulfill steps in article.
    let dependencies = _prefix "dependencies"
          

    /// Processor architecture required to run the application (e.g. IA64).
    let processorRequirements = _prefix "processorRequirements"
          

    /// Products owned by the organization or person.
    let owns = _prefix "owns"
          

    /// Professional service: Attorney. <br/><br/>
/// 
/// This type is deprecated - <a class="localLink" href="http://schema.org/LegalService">LegalService</a> is more inclusive and less ambiguous.
    let Attorney = _prefix "Attorney"
          

    /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
    let proficiencyLevel = _prefix "proficiencyLevel"
          

    /// Properties that take Distances as values are of the form '&lt;Number&gt; &lt;Length unit of measure&gt;'. E.g., '7 ft'.
    let Distance = _prefix "Distance"
          

    /// Properties that take Energy as values are of the form '&lt;Number&gt; &lt;Energy unit of measure&gt;'.
    let Energy = _prefix "Energy"
          

    /// Properties that take Mass as values are of the form '&lt;Number&gt; &lt;Mass unit of measure&gt;'. E.g., '7 kg'.
    let Mass = _prefix "Mass"
          

    /// Publication date of an online listing.
    let datePosted = _prefix "datePosted"
          

    /// Quantities such as distance, time, mass, weight, etc. Particular instances of say Mass are entities like '3 Kg' or '4 milligrams'.
    let Quantity = _prefix "Quantity"
          

    /// Quantity: Duration (use <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 duration format</a>).
    let Duration = _prefix "Duration"
          

    /// Real or fictional location of the game (or part of game).
    let gameLocation = _prefix "gameLocation"
          

    /// Real-wheel drive is a transmission layout where the engine drives the rear wheels.
    let RearWheelDriveConfiguration = _prefix "RearWheelDriveConfiguration"
          

    /// Reference documentation for application programming interfaces (APIs).
    let APIReference = _prefix "APIReference"
          

    /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
    let ticketToken = _prefix "ticketToken"
          

    /// RemixAlbum.
    let RemixAlbum = _prefix "RemixAlbum"
          

    /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a>.
    let geoContains = _prefix "geoContains"
          

    /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a>.
    let geoCovers = _prefix "geoCovers"
          

    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a>.
    let geoCoveredBy = _prefix "geoCoveredBy"
          

    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a>.
    let geoCrosses = _prefix "geoCrosses"
          

    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a>.
    let geoOverlaps = _prefix "geoOverlaps"
          

    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a>.
    let geoWithin = _prefix "geoWithin"
          

    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.<br/><br/>
/// 
/// See also <a href="http://blog.schema.org/2014/06/introducing-role.html">blog post</a>.
    let Role = _prefix "Role"
          

    /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a>)
    let geoDisjoint = _prefix "geoDisjoint"
          

    /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a>. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
    let geoEquals = _prefix "geoEquals"
          

    /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a>.
    let geoIntersects = _prefix "geoIntersects"
          

    /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in <a href="https://en.wikipedia.org/wiki/DE-9IM">DE-9IM</a> )
    let geoTouches = _prefix "geoTouches"
          

    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    let SportsOrganization = _prefix "SportsOrganization"
          

    /// Requirements for taking the Course. May be completion of another <a class="localLink" href="http://schema.org/Course">Course</a> or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using <a class="localLink" href="http://schema.org/AlignmentObject">AlignmentObject</a>.
    let coursePrerequisites = _prefix "coursePrerequisites"
          

    /// Researchers.
    let Researcher = _prefix "Researcher"
          

    /// Reserving a concrete object.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/ScheduleAction">ScheduleAction</a></a>: Unlike ScheduleAction, ReserveAction reserves concrete objects (e.g. a table, a hotel) towards a time slot / spatial allocation.</li>
/// </ul>
/// 
    let ReserveAction = _prefix "ReserveAction"
          

    /// Residence type: Apartment complex.
    let ApartmentComplex = _prefix "ApartmentComplex"
          

    /// Residence type: Gated community.
    let GatedResidenceCommunity = _prefix "GatedResidenceCommunity"
          

    /// Residence type: Single-family home.
    let SingleFamilyResidence = _prefix "SingleFamilyResidence"
          

    /// Responsibilities associated with this role or Occupation.
    let responsibilities = _prefix "responsibilities"
          

    /// Review of the item.
    let reviews = _prefix "reviews"
          

    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    let RsvpResponseType = _prefix "RsvpResponseType"
          

    /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
    let runtime = _prefix "runtime"
          

    /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
    let runtimePlatform = _prefix "runtimePlatform"
          

    /// Scheduling future actions, events, or tasks.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/ReserveAction">ReserveAction</a>: Unlike ReserveAction, ScheduleAction allocates future actions (e.g. an event, a task, etc) towards a time slot / spatial allocation.</li>
/// </ul>
/// 
    let ScheduleAction = _prefix "ScheduleAction"
          

    /// Season dedicated to TV broadcast and associated online delivery.
    let TVSeason = _prefix "TVSeason"
          

    /// Season dedicated to radio broadcast and associated online delivery.
    let RadioSeason = _prefix "RadioSeason"
          

    /// Server that provides game interaction in a multiplayer game.
    let GameServer = _prefix "GameServer"
          

    /// Shipper tracking number.
    let trackingNumber = _prefix "trackingNumber"
          

    /// Shipper's address.
    let originAddress = _prefix "originAddress"
          

    /// SingleRelease.
    let SingleRelease = _prefix "SingleRelease"
          

    /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
    let fileSize = _prefix "fileSize"
          

    /// Smaller compositions included in this work (e.g. a movement in a symphony).
    let includedComposition = _prefix "includedComposition"
          

    /// Software application help.
    let softwareHelp = _prefix "softwareHelp"
          

    /// Someone working for this organization.
    let employee = _prefix "employee"
          

    /// SoundtrackAlbum.
    let SoundtrackAlbum = _prefix "SoundtrackAlbum"
          

    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    let LocationFeatureSpecification = _prefix "LocationFeatureSpecification"
          

    /// Specifies a regular expression for testing literal values according to the HTML spec.
    let valuePattern = _prefix "valuePattern"
          

    /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
    let browserRequirements = _prefix "browserRequirements"
          

    /// Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).
    let carrierRequirements = _prefix "carrierRequirements"
          

    /// Specifies the CreativeWork associated with the UserComment.
    let discusses = _prefix "discusses"
          

    /// Specifies the Person that is legally accountable for the CreativeWork.
    let accountablePerson = _prefix "accountablePerson"
          

    /// Specifies the Person who edited the CreativeWork.
    let editor = _prefix "editor"
          

    /// Specifies the allowed range for number of characters in a literal value.
    let valueMaxLength = _prefix "valueMaxLength"
          

    /// Specifies the minimum allowed range for number of characters in a literal value.
    let valueMinLength = _prefix "valueMinLength"
          

    /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
    let valueAddedTaxIncluded = _prefix "valueAddedTaxIncluded"
          

    /// SpokenWordAlbum.
    let SpokenWordAlbum = _prefix "SpokenWordAlbum"
          

    /// Status of a game server.
    let GameServerStatus = _prefix "GameServerStatus"
          

    /// Status of a game server.
    let serverStatus = _prefix "serverStatus"
          

    /// Storage requirements (free space required).
    let storageRequirements = _prefix "storageRequirements"
          

    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    let StructuredValue = _prefix "StructuredValue"
          

    /// StudioAlbum.
    let StudioAlbum = _prefix "StudioAlbum"
          

    /// Subcategory of the application, e.g. 'Arcade Game'.
    let applicationSubCategory = _prefix "applicationSubCategory"
          

    /// Supporting data for a SoftwareApplication.
    let supportingData = _prefix "supportingData"
          

    /// Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.
    let targetProduct = _prefix "targetProduct"
          

    /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
    let lodgingUnitType = _prefix "lodgingUnitType"
          

    /// The "spatial" property can be used in cases when more specific properties
/// (e.g. <a class="localLink" href="http://schema.org/locationCreated">locationCreated</a>, <a class="localLink" href="http://schema.org/spatialCoverage">spatialCoverage</a>, <a class="localLink" href="http://schema.org/contentLocation">contentLocation</a>) are not known to be appropriate.
    let spatial = _prefix "spatial"
          

    /// The "temporal" property can be used in cases where more specific properties
/// (e.g. <a class="localLink" href="http://schema.org/temporalCoverage">temporalCoverage</a>, <a class="localLink" href="http://schema.org/dateCreated">dateCreated</a>, <a class="localLink" href="http://schema.org/dateModified">dateModified</a>, <a class="localLink" href="http://schema.org/datePublished">datePublished</a>) are not known to be appropriate.
    let temporal = _prefix "temporal"
          

    /// The 10th percentile value.
    let percentile10 = _prefix "percentile10"
          

    /// The 25th percentile value.
    let percentile25 = _prefix "percentile25"
          

    /// The 75th percentile value.
    let percentile75 = _prefix "percentile75"
          

    /// The 90th percentile value.
    let percentile90 = _prefix "percentile90"
          

    /// The <a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx">GTIN-8</a> code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See <a href="http://www.gs1.org/barcodes/technical/idkeys/gtin">GS1 GTIN Summary</a> for more details.
    let gtin8 = _prefix "gtin8"
          

    /// The <a href="http://www.gs1.org/gln">Global Location Number</a> (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
    let globalLocationNumber = _prefix "globalLocationNumber"
          

    /// The Action representing the type of interaction. For up votes, +1s, etc. use <a class="localLink" href="http://schema.org/LikeAction">LikeAction</a>. For down votes use <a class="localLink" href="http://schema.org/DislikeAction">DislikeAction</a>. Otherwise, use the most specific Action.
    let interactionType = _prefix "interactionType"
          

    /// The BroadcastService offered on this channel.
    let providesBroadcastService = _prefix "providesBroadcastService"
          

    /// The CableOrSatelliteService offering the channel.
    let inBroadcastLineup = _prefix "inBroadcastLineup"
          

    /// The CreativeWork encoded by this media object.
    let encodesCreativeWork = _prefix "encodesCreativeWork"
          

    /// The CreativeWork that captured all or part of this Event.
    let recordedIn = _prefix "recordedIn"
          

    /// The Dun &amp; Bradstreet DUNS number for identifying an organization or business person.
    let duns = _prefix "duns"
          

    /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
    let recordedAt = _prefix "recordedAt"
          

    /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See <a href="http://www.gs1.org/barcodes/technical/idkeys/gtin">GS1 GTIN Summary</a> for more details.
    let gtin12 = _prefix "gtin12"
          

    /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See <a href="http://www.gs1.org/barcodes/technical/idkeys/gtin">GS1 GTIN Summary</a> for more details.
    let gtin13 = _prefix "gtin13"
          

    /// The GTIN-14 code of the product, or the product to which the offer refers. See <a href="http://www.gs1.org/barcodes/technical/idkeys/gtin">GS1 GTIN Summary</a> for more details.
    let gtin14 = _prefix "gtin14"
          

    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    let Game = _prefix "Game"
          

    /// The ISBN of the book.
    let isbn = _prefix "isbn"
          

    /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.<br/><br/>
/// 
/// See also <a class="localLink" href="http://schema.org/ineligibleRegion">ineligibleRegion</a>.
    let eligibleRegion = _prefix "eligibleRegion"
          

    /// The International Standard Musical Work Code for the composition.
    let iswcCode = _prefix "iswcCode"
          

    /// The International Standard Recording Code for the recording.
    let isrcCode = _prefix "isrcCode"
          

    /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
    let issn = _prefix "issn"
          

    /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
    let isicV4 = _prefix "isicV4"
          

    /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
    let mpn = _prefix "mpn"
          

    /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
    let naics = _prefix "naics"
          

    /// The Occupation for the JobPosting.
    let relevantOccupation = _prefix "relevantOccupation"
          

    /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
    let referencesOrder = _prefix "referencesOrder"
          

    /// The Organization on whose behalf the creator was working.
    let sourceOrganization = _prefix "sourceOrganization"
          

    /// The Organization responsible for authenticating the user's subscription. For example, many media apps require a cable/satellite provider to authenticate your subscription before playing media.
    let authenticator = _prefix "authenticator"
          

    /// The Person's occupation. For past professions, use Role for expressing dates.
    let hasOccupation = _prefix "hasOccupation"
          

    /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
    let sku = _prefix "sku"
          

    /// The TV series to which this episode or season belongs.
    let partOfTVSeries = _prefix "partOfTVSeries"
          

    /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
    let taxID = _prefix "taxID"
          

    /// The URL at which a reply may be posted to the specified UserComment.
    let replyToUrl = _prefix "replyToUrl"
          

    /// The URL for sending a payment.
    let paymentUrl = _prefix "paymentUrl"
          

    /// The URL of a node in an established educational framework.
    let targetUrl = _prefix "targetUrl"
          

    /// The Value-added Tax ID of the organization or person.
    let vatID = _prefix "vatID"
          

    /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
    let vehicleIdentificationNumber = _prefix "vehicleIdentificationNumber"
          

    /// The WebSite or SoftwareApplication where the interactions took place.
    let interactionService = _prefix "interactionService"
          

    /// The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.
    let DepartAction = _prefix "DepartAction"
          

    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    let AchieveAction = _prefix "AchieveAction"
          

    /// The act of achieving victory in a competitive activity.
    let WinAction = _prefix "WinAction"
          

    /// The act of adding at a specific location in an ordered collection.
    let InsertAction = _prefix "InsertAction"
          

    /// The act of allocating an action/event/task to some destination (someone or something).
    let AssignAction = _prefix "AssignAction"
          

    /// The act of an agent communicating (service provider, social media, etc) their arrival by registering/confirming for a previously reserved service (e.g. flight check in) or at a place (e.g. hotel), possibly resulting in a result (boarding pass, etc).<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/CheckOutAction">CheckOutAction</a>: The antonym of CheckInAction.</li>
/// <li><a class="localLink" href="http://schema.org/ArriveAction">ArriveAction</a>: Unlike ArriveAction, CheckInAction implies that the agent is informing/confirming the start of a previously reserved service.</li>
/// <li><a class="localLink" href="http://schema.org/ConfirmAction">ConfirmAction</a>: Unlike ConfirmAction, CheckInAction implies that the agent is informing/confirming the <em>start</em> of a previously reserved service rather than its validity/existence.</li>
/// </ul>
/// 
    let CheckInAction = _prefix "CheckInAction"
          

    /// The act of an agent communicating (service provider, social media, etc) their departure of a previously reserved service (e.g. flight check in) or place (e.g. hotel).<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/CheckInAction">CheckInAction</a>: The antonym of CheckOutAction.</li>
/// <li><a class="localLink" href="http://schema.org/DepartAction">DepartAction</a>: Unlike DepartAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.</li>
/// <li><a class="localLink" href="http://schema.org/CancelAction">CancelAction</a>: Unlike CancelAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.</li>
/// </ul>
/// 
    let CheckOutAction = _prefix "CheckOutAction"
          

    /// The act of an agent relocating to a place.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/TransferAction">TransferAction</a>: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.</li>
/// </ul>
/// 
    let MoveAction = _prefix "MoveAction"
          

    /// The act of applying an object to its intended purpose.
    let UseAction = _prefix "UseAction"
          

    /// The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.
    let ArriveAction = _prefix "ArriveAction"
          

    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    let InviteAction = _prefix "InviteAction"
          

    /// The act of asserting that a future event/action is no longer going to happen.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/ConfirmAction">ConfirmAction</a>: The antonym of CancelAction.</li>
/// </ul>
/// 
    let CancelAction = _prefix "CancelAction"
          

    /// The act of authoring written creative content.
    let WriteAction = _prefix "WriteAction"
          

    /// The act of being defeated in a competitive activity.
    let LoseAction = _prefix "LoseAction"
          

    /// The act of capturing sound and moving images on film, video, or digitally.
    let FilmAction = _prefix "FilmAction"
          

    /// The act of capturing still images of objects using a camera.
    let PhotographAction = _prefix "PhotographAction"
          

    /// The act of committing to/adopting an object.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/RejectAction">RejectAction</a>: The antonym of AcceptAction.</li>
/// </ul>
/// 
    let AcceptAction = _prefix "AcceptAction"
          

    /// The act of consuming audio content.
    let ListenAction = _prefix "ListenAction"
          

    /// The act of consuming dynamic/moving visual content.
    let WatchAction = _prefix "WatchAction"
          

    /// The act of consuming static visual content.
    let ViewAction = _prefix "ViewAction"
          

    /// The act of consuming written content.
    let ReadAction = _prefix "ReadAction"
          

    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    let CommunicateAction = _prefix "CommunicateAction"
          

    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    let CreateAction = _prefix "CreateAction"
          

    /// The act of discovering/finding an object.
    let DiscoverAction = _prefix "DiscoverAction"
          

    /// The act of distributing content to people for their amusement or edification.
    let ShareAction = _prefix "ShareAction"
          

    /// The act of downloading an object.
    let DownloadAction = _prefix "DownloadAction"
          

    /// The act of dressing oneself in clothing.
    let WearAction = _prefix "WearAction"
          

    /// The act of editing a recipient by removing one of its objects.
    let DeleteAction = _prefix "DeleteAction"
          

    /// The act of editing a recipient by replacing an old object with a new object.
    let ReplaceAction = _prefix "ReplaceAction"
          

    /// The act of editing by adding an object to a collection.
    let AddAction = _prefix "AddAction"
          

    /// The act of expressing a consistency of opinion with the object. An agent agrees to/about an object (a proposition, topic or theme) with participants.
    let AgreeAction = _prefix "AgreeAction"
          

    /// The act of expressing a desire about the object. An agent wants an object.
    let WantAction = _prefix "WantAction"
          

    /// The act of expressing a difference of opinion with the object. An agent disagrees to/about an object (a proposition, topic or theme) with participants.
    let DisagreeAction = _prefix "DisagreeAction"
          

    /// The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.
    let DislikeAction = _prefix "DislikeAction"
          

    /// The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.
    let LikeAction = _prefix "LikeAction"
          

    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    let VoteAction = _prefix "VoteAction"
          

    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    let ChooseAction = _prefix "ChooseAction"
          

    /// The act of finding an object.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/SearchAction">SearchAction</a>: FindAction is generally lead by a SearchAction, but not necessarily.</li>
/// </ul>
/// 
    let FindAction = _prefix "FindAction"
          

    /// The act of forming a personal connection with someone (object) mutually/bidirectionally/symmetrically.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/FollowAction">FollowAction</a>: Unlike FollowAction, BefriendAction implies that the connection is reciprocal.</li>
/// </ul>
/// 
    let BefriendAction = _prefix "BefriendAction"
          

    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/BefriendAction">BefriendAction</a>: Unlike BefriendAction, FollowAction implies that the connection is <em>not</em> necessarily reciprocal.</li>
/// <li><a class="localLink" href="http://schema.org/SubscribeAction">SubscribeAction</a>: Unlike SubscribeAction, FollowAction implies that the follower acts as an active agent constantly/actively polling for updates.</li>
/// <li><a class="localLink" href="http://schema.org/RegisterAction">RegisterAction</a>: Unlike RegisterAction, FollowAction implies that the agent is interested in continuing receiving updates from the object.</li>
/// <li><a class="localLink" href="http://schema.org/JoinAction">JoinAction</a>: Unlike JoinAction, FollowAction implies that the agent is interested in getting updates from the object.</li>
/// <li><a class="localLink" href="http://schema.org/TrackAction">TrackAction</a>: Unlike TrackAction, FollowAction refers to the polling of updates of all aspects of animate objects rather than the location of inanimate objects (e.g. you track a package, but you don't follow it).</li>
/// </ul>
/// 
    let FollowAction = _prefix "FollowAction"
          

    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates pushed to.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/FollowAction">FollowAction</a>: Unlike FollowAction, SubscribeAction implies that the subscriber acts as a passive agent being constantly/actively pushed for updates.</li>
/// <li><a class="localLink" href="http://schema.org/RegisterAction">RegisterAction</a>: Unlike RegisterAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.</li>
/// <li><a class="localLink" href="http://schema.org/JoinAction">JoinAction</a>: Unlike JoinAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.</li>
/// </ul>
/// 
    let SubscribeAction = _prefix "SubscribeAction"
          

    /// The act of forming one's opinion, reaction or sentiment.
    let AssessAction = _prefix "AssessAction"
          

    /// The act of gaining ownership of an object from an origin. Reciprocal of GiveAction.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/GiveAction">GiveAction</a>: The reciprocal of TakeAction.</li>
/// <li><a class="localLink" href="http://schema.org/ReceiveAction">ReceiveAction</a>: Unlike ReceiveAction, TakeAction implies that ownership has been transfered.</li>
/// </ul>
/// 
    let TakeAction = _prefix "TakeAction"
          

    /// The act of generating a comment about a subject.
    let CommentAction = _prefix "CommentAction"
          

    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    let RentAction = _prefix "RentAction"
          

    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    let BuyAction = _prefix "BuyAction"
          

    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    let TipAction = _prefix "TipAction"
          

    /// The act of granting permission to an object.
    let AuthorizeAction = _prefix "AuthorizeAction"
          

    /// The act of ingesting information/resources/food.
    let ConsumeAction = _prefix "ConsumeAction"
          

    /// The act of inserting at the beginning if an ordered collection.
    let PrependAction = _prefix "PrependAction"
          

    /// The act of inserting at the end if an ordered collection.
    let AppendAction = _prefix "AppendAction"
          

    /// The act of installing an application.
    let InstallAction = _prefix "InstallAction"
          

    /// The act of intentionally disregarding the object. An agent ignores an object.
    let IgnoreAction = _prefix "IgnoreAction"
          

    /// The act of interacting with another person or organization.
    let InteractAction = _prefix "InteractAction"
          

    /// The act of managing by changing/editing the state of the object.
    let UpdateAction = _prefix "UpdateAction"
          

    /// The act of manipulating/administering/supervising/controlling one or more objects.
    let OrganizeAction = _prefix "OrganizeAction"
          

    /// The act of marrying a person.
    let MarryAction = _prefix "MarryAction"
          

    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    let SuspendAction = _prefix "SuspendAction"
          

    /// The act of notifying an event organizer as to whether you expect to attend the event.
    let RsvpAction = _prefix "RsvpAction"
          

    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    let InformAction = _prefix "InformAction"
          

    /// The act of notifying someone that a future event/action is going to happen as expected.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/CancelAction">CancelAction</a>: The antonym of ConfirmAction.</li>
/// </ul>
/// 
    let ConfirmAction = _prefix "ConfirmAction"
          

    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/LendAction">LendAction</a>: Reciprocal of BorrowAction.</li>
/// </ul>
/// 
    let BorrowAction = _prefix "BorrowAction"
          

    /// The act of organizing tasks/objects/events by associating resources to it.
    let AllocateAction = _prefix "AllocateAction"
          

    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    let TradeAction = _prefix "TradeAction"
          

    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    let ExerciseAction = _prefix "ExerciseAction"
          

    /// The act of participating in performance arts.
    let PerformAction = _prefix "PerformAction"
          

    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/ReceiveAction">ReceiveAction</a>: The reciprocal of SendAction.</li>
/// <li><a class="localLink" href="http://schema.org/GiveAction">GiveAction</a>: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).</li>
/// </ul>
/// 
    let SendAction = _prefix "SendAction"
          

    /// The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/SendAction">SendAction</a>: The reciprocal of ReceiveAction.</li>
/// <li><a class="localLink" href="http://schema.org/TakeAction">TakeAction</a>: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).</li>
/// </ul>
/// 
    let ReceiveAction = _prefix "ReceiveAction"
          

    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    let PlanAction = _prefix "PlanAction"
          

    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/ListenAction">ListenAction</a>: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.</li>
/// <li><a class="localLink" href="http://schema.org/WatchAction">WatchAction</a>: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.</li>
/// </ul>
/// 
    let PlayAction = _prefix "PlayAction"
          

    /// The act of posing a question / favor to someone.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/ReplyAction">ReplyAction</a>: Appears generally as a response to AskAction.</li>
/// </ul>
/// 
    let AskAction = _prefix "AskAction"
          

    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    let ReviewAction = _prefix "ReviewAction"
          

    /// The act of producing a painting, typically with paint and canvas as instruments.
    let PaintAction = _prefix "PaintAction"
          

    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    let DrawAction = _prefix "DrawAction"
          

    /// The act of producing/preparing food.
    let CookAction = _prefix "CookAction"
          

    /// The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/BorrowAction">BorrowAction</a>: Reciprocal of LendAction.</li>
/// </ul>
/// 
    let LendAction = _prefix "LendAction"
          

    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    let DonateAction = _prefix "DonateAction"
          

    /// The act of reaching a draw in a competitive activity.
    let TieAction = _prefix "TieAction"
          

    /// The act of registering to an organization/service without the guarantee to receive it.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/RegisterAction">RegisterAction</a>: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.</li>
/// </ul>
/// 
    let ApplyAction = _prefix "ApplyAction"
          

    /// The act of registering to be a user of a service, product or web page.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/JoinAction">JoinAction</a>: Unlike JoinAction, RegisterAction implies you are registering to be a user of a service, <em>not</em> a group/team of people.</li>
/// <li>[FollowAction]]: Unlike FollowAction, RegisterAction doesn't imply that the agent is expecting to poll for updates from the object.</li>
/// <li><a class="localLink" href="http://schema.org/SubscribeAction">SubscribeAction</a>: Unlike SubscribeAction, RegisterAction doesn't imply that the agent is expecting updates from the object.</li>
/// </ul>
/// 
    let RegisterAction = _prefix "RegisterAction"
          

    /// The act of rejecting to/adopting an object.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/AcceptAction">AcceptAction</a>: The antonym of RejectAction.</li>
/// </ul>
/// 
    let RejectAction = _prefix "RejectAction"
          

    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    let ReactAction = _prefix "ReactAction"
          

    /// The act of responding to a question/message asked/sent by the object. Related to <a class="localLink" href="http://schema.org/AskAction">AskAction</a><br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/AskAction">AskAction</a>: Appears generally as an origin of a ReplyAction.</li>
/// </ul>
/// 
    let ReplyAction = _prefix "ReplyAction"
          

    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    let ResumeAction = _prefix "ResumeAction"
          

    /// The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).
    let ReturnAction = _prefix "ReturnAction"
          

    /// The act of searching for an object.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/FindAction">FindAction</a>: SearchAction generally leads to a FindAction, but not necessarily.</li>
/// </ul>
/// 
    let SearchAction = _prefix "SearchAction"
          

    /// The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).
    let ActivateAction = _prefix "ActivateAction"
          

    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    let DeactivateAction = _prefix "DeactivateAction"
          

    /// The act of swallowing liquids.
    let DrinkAction = _prefix "DrinkAction"
          

    /// The act of swallowing solid objects.
    let EatAction = _prefix "EatAction"
          

    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    let SellAction = _prefix "SellAction"
          

    /// The act of transferring ownership of an object to a destination. Reciprocal of TakeAction.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/TakeAction">TakeAction</a>: Reciprocal of GiveAction.</li>
/// <li><a class="localLink" href="http://schema.org/SendAction">SendAction</a>: Unlike SendAction, GiveAction implies that ownership is being transferred (e.g. I may send my laptop to you, but that doesn't mean I'm giving it to you).</li>
/// </ul>
/// 
    let GiveAction = _prefix "GiveAction"
          

    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    let TransferAction = _prefix "TransferAction"
          

    /// The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.
    let TravelAction = _prefix "TravelAction"
          

    /// The act of un-registering from a service.<br/><br/>
/// 
/// Related actions:<br/><br/>
/// 
/// <ul>
/// <li><a class="localLink" href="http://schema.org/RegisterAction">RegisterAction</a>: antonym of UnRegisterAction.</li>
/// <li><a class="localLink" href="http://schema.org/LeaveAction">LeaveAction</a>: Unlike LeaveAction, UnRegisterAction implies that you are unregistering from a service you werer previously registered, rather than leaving a team/group of people.</li>
/// </ul>
/// 
    let UnRegisterAction = _prefix "UnRegisterAction"
          

    /// The actual body of the article.
    let articleBody = _prefix "articleBody"
          

    /// The actual body of the review.
    let reviewBody = _prefix "reviewBody"
          

    /// The address for accessing the service by mail.
    let servicePostalAddress = _prefix "servicePostalAddress"
          

    /// The age of the business.
    let yearsInOperation = _prefix "yearsInOperation"
          

    /// The airline boards by groups based on check-in time, priority, etc.
    let GroupBoardingPolicy = _prefix "GroupBoardingPolicy"
          

    /// The airline boards by zones of the plane.
    let ZoneBoardingPolicy = _prefix "ZoneBoardingPolicy"
          

    /// The airline-specific indicator of boarding order / preference.
    let boardingGroup = _prefix "boardingGroup"
          

    /// The airport where the flight originates.
    let departureAirport = _prefix "departureAirport"
          

    /// The airport where the flight terminates.
    let arrivalAirport = _prefix "arrivalAirport"
          

    /// The album this is a release of.
    let releaseOf = _prefix "releaseOf"
          

    /// The album to which this recording belongs.
    let inAlbum = _prefix "inAlbum"
          

    /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
/// Typical unit code(s): C62 for person
    let occupancy = _prefix "occupancy"
          

    /// The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).<br/><br/>
/// 
/// <ul>
/// <li>Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use <a class="localLink" href="http://schema.org/unitText">unitText</a> to indicate the unit of measurement, e.g. L/100 km.</li>
/// <li>Note 2: There are two ways of indicating the fuel consumption, <a class="localLink" href="http://schema.org/fuelConsumption">fuelConsumption</a> (e.g. 8 liters per 100 km) and <a class="localLink" href="http://schema.org/fuelEfficiency">fuelEfficiency</a> (e.g. 30 miles per gallon). They are reciprocal.</li>
/// <li>Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use <a class="localLink" href="http://schema.org/valueReference">valueReference</a> to link the value for the fuel consumption to another value.</li>
/// </ul>
/// 
    let fuelConsumption = _prefix "fuelConsumption"
          

    /// The amount of money.
    let amount = _prefix "amount"
          

    /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
    let advanceBookingRequirement = _prefix "advanceBookingRequirement"
          

    /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
    let annualPercentageRate = _prefix "annualPercentageRate"
          

    /// The answer(s) that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
    let acceptedAnswer = _prefix "acceptedAnswer"
          

    /// The area within which users can expect to reach the broadcast service.
    let area = _prefix "area"
          

    /// The artist that performed this album or recording.
    let byArtist = _prefix "byArtist"
          

    /// The associated telephone number is toll free.
    let TollFree = _prefix "TollFree"
          

    /// The audience eligible for this service.
    let serviceAudience = _prefix "serviceAudience"
          

    /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
    let author = _prefix "author"
          

    /// The availability of this item&#x2014;for example In stock, Out of stock, Pre-order, etc.
    let availability = _prefix "availability"
          

    /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.<br/><br/>
/// 
/// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet<br/><br/>
/// 
/// Note: You can use <a class="localLink" href="http://schema.org/minValue">minValue</a> and <a class="localLink" href="http://schema.org/maxValue">maxValue</a> to indicate ranges.
    let cargoVolume = _prefix "cargoVolume"
          

    /// The average rating based on multiple ratings or reviews.
    let AggregateRating = _prefix "AggregateRating"
          

    /// The away team in a sports event.
    let awayTeam = _prefix "awayTeam"
          

    /// The base salary of the job or of an employee in an EmployeeRole.
    let baseSalary = _prefix "baseSalary"
          

    /// The basic containment relation between a place and another that it contains.
    let containsPlace = _prefix "containsPlace"
          

    /// The basic containment relation between a place and one that contains it.
    let containedIn = _prefix "containedIn"
          

    /// The basic containment relation between a place and one that contains it.
    let containedInPlace = _prefix "containedInPlace"
          

    /// The basic data types such as Integers, Strings, etc.
    let DataType = _prefix "DataType"
          

    /// The beginning of the availability of the product or service included in the offer.
    let availabilityStarts = _prefix "availabilityStarts"
          

    /// The billing address for the order.
    let billingAddress = _prefix "billingAddress"
          

    /// The bitrate of the media object.
    let bitrate = _prefix "bitrate"
          

    /// The boolean value false.
    let False = _prefix "False"
          

    /// The boolean value true.
    let True = _prefix "True"
          

    /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
    let brand = _prefix "brand"
          

    /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
    let businessFunction = _prefix "businessFunction"
          

    /// The business function specifies the type of activity or access (i.e., the bundle of rights) offered by the organization or business person through the offer. Typical are sell, rental or lease, maintenance or repair, manufacture / produce, recycle / dispose, engineering / construction, or installation. Proprietary specifications of access rights are also instances of this class.<br/><br/>
/// 
/// Commonly used values:<br/><br/>
/// 
/// <ul>
/// <li>http://purl.org/goodrelations/v1#ConstructionInstallation</li>
/// <li>http://purl.org/goodrelations/v1#Dispose</li>
/// <li>http://purl.org/goodrelations/v1#LeaseOut</li>
/// <li>http://purl.org/goodrelations/v1#Maintain</li>
/// <li>http://purl.org/goodrelations/v1#ProvideService</li>
/// <li>http://purl.org/goodrelations/v1#Repair</li>
/// <li>http://purl.org/goodrelations/v1#Sell</li>
/// <li>http://purl.org/goodrelations/v1#Buy</li>
/// </ul>
/// 
    let BusinessFunction = _prefix "BusinessFunction"
          

    /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the <a class="localLink" href="http://schema.org/encodingFormat">encodingFormat</a>.
    let caption = _prefix "caption"
          

    /// The catalog number for the release.
    let catalogNumber = _prefix "catalogNumber"
          

    /// The category of the recipe-for example, appetizer, entree, etc.
    let recipeCategory = _prefix "recipeCategory"
          

    /// The closing hour of the place or service on the given day(s) of the week.
    let closes = _prefix "closes"
          

    /// The color of the product.
    let color = _prefix "color"
          

    /// The color or color combination of the interior of the vehicle.
    let vehicleInteriorColor = _prefix "vehicleInteriorColor"
          

    /// The composer of the soundtrack.
    let musicBy = _prefix "musicBy"
          

    /// The composition this track is a recording of.
    let recordingOf = _prefix "recordingOf"
          

    /// The computer programming language.
    let programmingLanguage = _prefix "programmingLanguage"
          

    /// The costs of settling the payment using a particular payment method.
    let PaymentChargeSpecification = _prefix "PaymentChargeSpecification"
          

    /// The count of total number of ratings.
    let ratingCount = _prefix "ratingCount"
          

    /// The count of total number of reviews.
    let reviewCount = _prefix "reviewCount"
          

    /// The country of the principal offices of the production company or individual responsible for the movie or program.
    let countryOfOrigin = _prefix "countryOfOrigin"
          

    /// The country. For example, USA. You can also provide the two-letter <a href="http://en.wikipedia.org/wiki/ISO_3166-1">ISO 3166-1 alpha-2 country code</a>.
    let addressCountry = _prefix "addressCountry"
          

    /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
    let creator = _prefix "creator"
          

    /// The cuisine of the recipe (for example, French or Ethiopian).
    let recipeCuisine = _prefix "recipeCuisine"
          

    /// The cuisine of the restaurant.
    let servesCuisine = _prefix "servesCuisine"
          

    /// The currency (coded using <a href="http://en.wikipedia.org/wiki/ISO_4217">ISO 4217</a> ) used for the main salary information in this job posting or for this employee.
    let salaryCurrency = _prefix "salaryCurrency"
          

    /// The currency accepted.<br/><br/>
/// 
/// Use standard formats: <a href="http://en.wikipedia.org/wiki/ISO_4217">ISO 4217 currency format</a> e.g. "USD"; <a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies">Ticker symbol</a> for cryptocurrencies e.g. "BTC"; well known names for <a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system">Local Exchange Tradings Systems</a> (LETS) and other currency types e.g. "Ithaca HOUR".
    let currenciesAccepted = _prefix "currenciesAccepted"
          

    /// The currency in which the monetary amount is expressed.<br/><br/>
/// 
/// Use standard formats: <a href="http://en.wikipedia.org/wiki/ISO_4217">ISO 4217 currency format</a> e.g. "USD"; <a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies">Ticker symbol</a> for cryptocurrencies e.g. "BTC"; well known names for <a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system">Local Exchange Tradings Systems</a> (LETS) and other currency types e.g. "Ithaca HOUR".
    let currency = _prefix "currency"
          

    /// The currency of the discount.<br/><br/>
/// 
/// Use standard formats: <a href="http://en.wikipedia.org/wiki/ISO_4217">ISO 4217 currency format</a> e.g. "USD"; <a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies">Ticker symbol</a> for cryptocurrencies e.g. "BTC"; well known names for <a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system">Local Exchange Tradings Systems</a> (LETS) and other currency types e.g. "Ithaca HOUR".
    let discountCurrency = _prefix "discountCurrency"
          

    /// The currency of the price, or a price component when attached to <a class="localLink" href="http://schema.org/PriceSpecification">PriceSpecification</a> and its subtypes.<br/><br/>
/// 
/// Use standard formats: <a href="http://en.wikipedia.org/wiki/ISO_4217">ISO 4217 currency format</a> e.g. "USD"; <a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies">Ticker symbol</a> for cryptocurrencies e.g. "BTC"; well known names for <a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system">Local Exchange Tradings Systems</a> (LETS) and other currency types e.g. "Ithaca HOUR".
    let priceCurrency = _prefix "priceCurrency"
          

    /// The current approximate inventory level for the item or items.
    let inventoryLevel = _prefix "inventoryLevel"
          

    /// The current status of the order item.
    let orderItemStatus = _prefix "orderItemStatus"
          

    /// The current status of the order.
    let orderStatus = _prefix "orderStatus"
          

    /// The current status of the reservation.
    let reservationStatus = _prefix "reservationStatus"
          

    /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
    let validThrough = _prefix "validThrough"
          

    /// The date after which the price is no longer available.
    let priceValidUntil = _prefix "priceValidUntil"
          

    /// The date and place the work was first performed.
    let firstPerformance = _prefix "firstPerformance"
          

    /// The date and time of giving up ownership on the product.
    let ownedThrough = _prefix "ownedThrough"
          

    /// The date and time of obtaining the product.
    let ownedFrom = _prefix "ownedFrom"
          

    /// The date and time the reservation was booked.
    let bookingTime = _prefix "bookingTime"
          

    /// The date and time the reservation was modified.
    let modifiedTime = _prefix "modifiedTime"
          

    /// The date of production of the item, e.g. vehicle.
    let productionDate = _prefix "productionDate"
          

    /// The date of the first registration of the vehicle with the respective public authorities.
    let dateVehicleFirstRegistered = _prefix "dateVehicleFirstRegistered"
          

    /// The date on which the CreativeWork was created or the item was added to a DataFeed.
    let dateCreated = _prefix "dateCreated"
          

    /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
    let dateModified = _prefix "dateModified"
          

    /// The date that payment is due.
    let paymentDue = _prefix "paymentDue"
          

    /// The date that payment is due.
    let paymentDueDate = _prefix "paymentDueDate"
          

    /// The date that this organization was dissolved.
    let dissolutionDate = _prefix "dissolutionDate"
          

    /// The date that this organization was founded.
    let foundingDate = _prefix "foundingDate"
          

    /// The date the invoice is scheduled to be paid.
    let scheduledPaymentDate = _prefix "scheduledPaymentDate"
          

    /// The date the item e.g. vehicle was purchased by the current owner.
    let purchaseDate = _prefix "purchaseDate"
          

    /// The date the ticket was issued.
    let dateIssued = _prefix "dateIssued"
          

    /// The date when the item becomes valid.
    let validFrom = _prefix "validFrom"
          

    /// The date when the item is no longer valid.
    let validUntil = _prefix "validUntil"
          

    /// The date/time at which the message has been read by the recipient if a single recipient exists.
    let dateRead = _prefix "dateRead"
          

    /// The date/time at which the message was sent.
    let dateSent = _prefix "dateSent"
          

    /// The date/time the message was received if a single recipient exists.
    let dateReceived = _prefix "dateReceived"
          

    /// The datetime the item was removed from the DataFeed.
    let dateDeleted = _prefix "dateDeleted"
          

    /// The day of the week between Friday and Sunday.
    let Saturday = _prefix "Saturday"
          

    /// The day of the week between Monday and Wednesday.
    let Tuesday = _prefix "Tuesday"
          

    /// The day of the week between Saturday and Monday.
    let Sunday = _prefix "Sunday"
          

    /// The day of the week between Sunday and Tuesday.
    let Monday = _prefix "Monday"
          

    /// The day of the week between Thursday and Saturday.
    let Friday = _prefix "Friday"
          

    /// The day of the week between Tuesday and Thursday.
    let Wednesday = _prefix "Wednesday"
          

    /// The day of the week between Wednesday and Friday.
    let Thursday = _prefix "Thursday"
          

    /// The day of the week for which these opening hours are valid.
    let dayOfWeek = _prefix "dayOfWeek"
          

    /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer.<br/><br/>
/// 
/// Originally, URLs from <a href="http://purl.org/goodrelations/v1">GoodRelations</a> were used (for <a class="localLink" href="http://schema.org/Monday">Monday</a>, <a class="localLink" href="http://schema.org/Tuesday">Tuesday</a>, <a class="localLink" href="http://schema.org/Wednesday">Wednesday</a>, <a class="localLink" href="http://schema.org/Thursday">Thursday</a>, <a class="localLink" href="http://schema.org/Friday">Friday</a>, <a class="localLink" href="http://schema.org/Saturday">Saturday</a>, <a class="localLink" href="http://schema.org/Sunday">Sunday</a> plus a special entry for <a class="localLink" href="http://schema.org/PublicHolidays">PublicHolidays</a>); these have now been integrated directly into schema.org.
    let DayOfWeek = _prefix "DayOfWeek"
          

    /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
    let defaultValue = _prefix "defaultValue"
          

    /// The delivery method(s) available for this offer.
    let availableDeliveryMethod = _prefix "availableDeliveryMethod"
          

    /// The delivery method(s) to which the delivery charge or payment charge specification applies.
    let appliesToDeliveryMethod = _prefix "appliesToDeliveryMethod"
          

    /// The delivery of a parcel either via the postal service or a commercial service.
    let ParcelDelivery = _prefix "ParcelDelivery"
          

    /// The delivery of the parcel related to this order or order item.
    let orderDelivery = _prefix "orderDelivery"
          

    /// The depth of the item.
    let depth = _prefix "depth"
          

    /// The description of a node in an established educational framework.
    let targetDescription = _prefix "targetDescription"
          

    /// The direct performer or driver of the action (animate or inanimate). e.g. <em>John</em> wrote a book.
    let agent = _prefix "agent"
          

    /// The distance of the flight.
    let flightDistance = _prefix "flightDistance"
          

    /// The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).<br/><br/>
/// 
/// <ul>
/// <li>Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use <a class="localLink" href="http://schema.org/unitText">unitText</a> to indicate the unit of measurement, e.g. mpg or km/L.</li>
/// <li>Note 2: There are two ways of indicating the fuel consumption, <a class="localLink" href="http://schema.org/fuelConsumption">fuelConsumption</a> (e.g. 8 liters per 100 km) and <a class="localLink" href="http://schema.org/fuelEfficiency">fuelEfficiency</a> (e.g. 30 miles per gallon). They are reciprocal.</li>
/// <li>Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use <a class="localLink" href="http://schema.org/valueReference">valueReference</a> to link the value for the fuel economy to another value.</li>
/// </ul>
/// 
    let fuelEfficiency = _prefix "fuelEfficiency"
          

    /// The distance travelled, e.g. exercising or travelling.
    let distance = _prefix "distance"
          

    /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
    let driveWheelConfiguration = _prefix "driveWheelConfiguration"
          

    /// The duration for which the given offer is valid.
    let eligibleDuration = _prefix "eligibleDuration"
          

    /// The duration of the item (movie, audio recording, event, etc.) in <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 date format</a>.
    let duration = _prefix "duration"
          

    /// The duration of the loan or credit agreement.
    let loanTerm = _prefix "loanTerm"
          

    /// The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.
    let durationOfWarranty = _prefix "durationOfWarranty"
          

    /// The duration of validity of a permit or similar thing.
    let validFor = _prefix "validFor"
          

    /// The earliest date the package may arrive.
    let expectedArrivalFrom = _prefix "expectedArrivalFrom"
          

    /// The earliest someone may check into a lodging establishment.
    let checkinTime = _prefix "checkinTime"
          

    /// The edition of the book.
    let bookEdition = _prefix "bookEdition"
          

    /// The edition of the print product in which the NewsArticle appears.
    let printEdition = _prefix "printEdition"
          

    /// The electronic systems used to play <a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms">video games</a>.
    let gamePlatform = _prefix "gamePlatform"
          

    /// The elevation of a location (<a href="https://en.wikipedia.org/wiki/World_Geodetic_System">WGS 84</a>). Values may be of the form 'NUMBER UNIT<em>OF</em>MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
    let elevation = _prefix "elevation"
          

    /// The end date and time of the item (in <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 date format</a>).
    let endDate = _prefix "endDate"
          

    /// The end of the availability of the product or service included in the offer.
    let availabilityEnds = _prefix "availabilityEnds"
          

    /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to <em>December</em>. For media, including audio and video, it's the time offset of the end of a clip within a larger file.<br/><br/>
/// 
/// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
    let endTime = _prefix "endTime"
          

    /// The episode to which this clip belongs.
    let partOfEpisode = _prefix "partOfEpisode"
          

    /// The estimated cost of the supply or supplies consumed when performing instructions.
    let estimatedCost = _prefix "estimatedCost"
          

    /// The estimated time the flight will take.
    let estimatedFlightDuration = _prefix "estimatedFlightDuration"
          

    /// The event being broadcast such as a sporting event or awards ceremony.
    let broadcastOfEvent = _prefix "broadcastOfEvent"
          

    /// The event has been cancelled. If the event has multiple startDate values, all are assumed to be cancelled. Either startDate or previousStartDate may be used to specify the event's cancelled date(s).
    let EventCancelled = _prefix "EventCancelled"
          

    /// The event has been postponed and no new date has been set. The event's previousStartDate should be set.
    let EventPostponed = _prefix "EventPostponed"
          

    /// The event has been rescheduled. The event's previousStartDate should be set to the old date and the startDate should be set to the event's new date. (If the event has been rescheduled multiple times, the previousStartDate property may be repeated).
    let EventRescheduled = _prefix "EventRescheduled"
          

    /// The event is taking place or has taken place on the startDate as scheduled. Use of this value is optional, as it is assumed by default.
    let EventScheduled = _prefix "EventScheduled"
          

    /// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we recommend using the controlled vocabulary of Market Identifier Codes (MIC) specified in ISO15022.
    let tickerSymbol = _prefix "tickerSymbol"
          

    /// The expected arrival time.
    let arrivalTime = _prefix "arrivalTime"
          

    /// The expected departure time.
    let departureTime = _prefix "departureTime"
          

    /// The fax number.
    let faxNumber = _prefix "faxNumber"
          

    /// The female gender.
    let Female = _prefix "Female"
          

    /// The footer section of the page.
    let WPFooter = _prefix "WPFooter"
          

    /// The format of the book.
    let bookFormat = _prefix "bookFormat"
          

    /// The frame size of the video.
    let videoFrameSize = _prefix "videoFrameSize"
          

    /// The framework to which the resource being described is aligned.
    let educationalFramework = _prefix "educationalFramework"
          

    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    let BroadcastFrequencySpecification = _prefix "BroadcastFrequencySpecification"
          

    /// The frequency in MHz for a particular broadcast.
    let broadcastFrequencyValue = _prefix "broadcastFrequencyValue"
          

    /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
    let broadcastFrequency = _prefix "broadcastFrequency"
          

    /// The gender of the person or audience.
    let suggestedGender = _prefix "suggestedGender"
          

    /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.<br/><br/>
/// 
/// <ul>
/// <li>Days are specified using the following two-letter combinations: <code>Mo</code>, <code>Tu</code>, <code>We</code>, <code>Th</code>, <code>Fr</code>, <code>Sa</code>, <code>Su</code>.</li>
/// <li>Times are specified using 24:00 time. For example, 3pm is specified as <code>15:00</code>. </li>
/// <li>Here is an example: <code>&lt;time itemprop="openingHours" datetime=&quot;Tu,Th 16:00-20:00&quot;&gt;Tuesdays and Thursdays 4-8pm&lt;/time&gt;</code>.</li>
/// <li>If a business is open 7 days a week, then it can be specified as <code>&lt;time itemprop=&quot;openingHours&quot; datetime=&quot;Mo-Su&quot;&gt;Monday through Sunday, all day&lt;/time&gt;</code>.</li>
/// </ul>
/// 
    let openingHours = _prefix "openingHours"
          

    /// The geo coordinates of the place.
    let geo = _prefix "geo"
          

    /// The geographic area associated with the audience.
    let geographicArea = _prefix "geographicArea"
          

    /// The geographic area where a permit or similar thing is valid.
    let validIn = _prefix "validIn"
          

    /// The geographic area where a service or offered item is provided.
    let areaServed = _prefix "areaServed"
          

    /// The geographic area where the service is provided.
    let serviceArea = _prefix "serviceArea"
          

    /// The geographic coordinates of a place or event.
    let GeoCoordinates = _prefix "GeoCoordinates"
          

    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    let GeoShape = _prefix "GeoShape"
          

    /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
    let creditedTo = _prefix "creditedTo"
          

    /// The header section of the page.
    let WPHeader = _prefix "WPHeader"
          

    /// The height of the item.
    let height = _prefix "height"
          

    /// The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
    let actionPlatform = _prefix "actionPlatform"
          

    /// The highest price if the price is a range.
    let maxPrice = _prefix "maxPrice"
          

    /// The highest price of all offers available.<br/><br/>
/// 
/// Usage guidelines:<br/><br/>
/// 
/// <ul>
/// <li>Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.</li>
/// <li>Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.</li>
/// </ul>
/// 
    let highPrice = _prefix "highPrice"
          

    /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
    let bestRating = _prefix "bestRating"
          

    /// The home team in a sports event.
    let homeTeam = _prefix "homeTeam"
          

    /// The hours during which this service or contact is available.
    let hoursAvailable = _prefix "hoursAvailable"
          

    /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
    let accessMode = _prefix "accessMode"
          

    /// The identifier for the <a class="localLink" href="http://schema.org/Course">Course</a> used by the course <a class="localLink" href="http://schema.org/provider">provider</a> (e.g. CS101 or 6.001).
    let courseCode = _prefix "courseCode"
          

    /// The identifier for the account the payment will be applied to.
    let accountId = _prefix "accountId"
          

    /// The identifier of the order item.
    let orderItemNumber = _prefix "orderItemNumber"
          

    /// The identifier of the transaction.
    let orderNumber = _prefix "orderNumber"
          

    /// The identifier property represents any kind of identifier for any kind of <a class="localLink" href="http://schema.org/Thing">Thing</a>, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See <a href="/docs/datamodel.html#identifierBg">background notes</a> for more details.
    let identifier = _prefix "identifier"
          

    /// The illustrator of the book.
    let illustrator = _prefix "illustrator"
          

    /// The individual reservations included in the package. Typically a repeated property.
    let subReservation = _prefix "subReservation"
          

    /// The industry associated with the job position.
    let industry = _prefix "industry"
          

    /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
    let interestRate = _prefix "interestRate"
          

    /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
    let eligibleQuantity = _prefix "eligibleQuantity"
          

    /// The invitee may or may not attend.
    let RsvpResponseMaybe = _prefix "RsvpResponseMaybe"
          

    /// The invitee will attend.
    let RsvpResponseYes = _prefix "RsvpResponseYes"
          

    /// The invitee will not attend.
    let RsvpResponseNo = _prefix "RsvpResponseNo"
          

    /// The item ordered.
    let orderedItem = _prefix "orderedItem"
          

    /// The item that is being reviewed/rated.
    let itemReviewed = _prefix "itemReviewed"
          

    /// The key, mode, or scale this composition uses.
    let musicalKey = _prefix "musicalKey"
          

    /// The kind of aircraft (e.g., "Boeing 747").
    let aircraft = _prefix "aircraft"
          

    /// The kind of release which this album is: single, EP or album.
    let MusicAlbumReleaseType = _prefix "MusicAlbumReleaseType"
          

    /// The kind of release which this album is: single, EP or album.
    let albumReleaseType = _prefix "albumReleaseType"
          

    /// The label that issued the release.
    let recordLabel = _prefix "recordLabel"
          

    /// The language of the content or performance or used in an action. Please use one of the language codes from the <a href="http://tools.ietf.org/html/bcp47">IETF BCP 47 standard</a>. See also <a class="localLink" href="http://schema.org/availableLanguage">availableLanguage</a>.
    let inLanguage = _prefix "inLanguage"
          

    /// The larger organization that this local business is a branch of, if any. Not to be confused with (anatomical)<a class="localLink" href="http://schema.org/branch">branch</a>.
    let branchOf = _prefix "branchOf"
          

    /// The larger organization that this organization is a <a class="localLink" href="http://schema.org/subOrganization">subOrganization</a> of, if any.
    let parentOrganization = _prefix "parentOrganization"
          

    /// The latest date the package may arrive.
    let expectedArrivalUntil = _prefix "expectedArrivalUntil"
          

    /// The latest someone may check out of a lodging establishment.
    let checkoutTime = _prefix "checkoutTime"
          

    /// The latitude of a location. For example <code>37.42242</code> (<a href="https://en.wikipedia.org/wiki/World_Geodetic_System">WGS 84</a>).
    let latitude = _prefix "latitude"
          

    /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 duration format</a>.
    let performTime = _prefix "performTime"
          

    /// The length of time it takes to prepare the items to be used in instructions or a direction, in <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 duration format</a>.
    let prepTime = _prefix "prepTime"
          

    /// The locality in which the street address is, and which is in the region. For example, Mountain View.
    let addressLocality = _prefix "addressLocality"
          

    /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
    let serviceLocation = _prefix "serviceLocation"
          

    /// The location depicted or described in the content. For example, the location in a photograph or painting.
    let contentLocation = _prefix "contentLocation"
          

    /// The location of for example where the event is happening, an organization is located, or where an action takes place.
    let location = _prefix "location"
          

    /// The location of the reserved seat (e.g., 27).
    let seatNumber = _prefix "seatNumber"
          

    /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
    let locationCreated = _prefix "locationCreated"
          

    /// The longitude of a location. For example <code>-122.08585</code> (<a href="https://en.wikipedia.org/wiki/World_Geodetic_System">WGS 84</a>).
    let longitude = _prefix "longitude"
          

    /// The lower value of some characteristic or property.
    let minValue = _prefix "minValue"
          

    /// The lowest price if the price is a range.
    let minPrice = _prefix "minPrice"
          

    /// The lowest price of all offers available.<br/><br/>
/// 
/// Usage guidelines:<br/><br/>
/// 
/// <ul>
/// <li>Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.</li>
/// <li>Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.</li>
/// </ul>
/// 
    let lowPrice = _prefix "lowPrice"
          

    /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
    let worstRating = _prefix "worstRating"
          

    /// The mailing address.
    let PostalAddress = _prefix "PostalAddress"
          

    /// The main performer or performers of the event&#x2014;for example, a presenter, musician, or actor.
    let performers = _prefix "performers"
          

    /// The male gender.
    let Male = _prefix "Male"
          

    /// The manufacturer of the product.
    let manufacturer = _prefix "manufacturer"
          

    /// The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
    let artMedium = _prefix "artMedium"
          

    /// The media network(s) whose content is broadcast on this station.
    let broadcastAffiliateOf = _prefix "broadcastAffiliateOf"
          

    /// The median value.
    let median = _prefix "median"
          

    /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
    let courseMode = _prefix "courseMode"
          

    /// The method of cooking, such as Frying, Steaming, ...
    let cookingMethod = _prefix "cookingMethod"
          

    /// The minimum payment required at this time.
    let minimumPaymentDue = _prefix "minimumPaymentDue"
          

    /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
    let model = _prefix "model"
          

    /// The most generic bi-directional social/work relation.
    let knows = _prefix "knows"
          

    /// The most generic familial relation.
    let relatedTo = _prefix "relatedTo"
          

    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    let CreativeWork = _prefix "CreativeWork"
          

    /// The most generic type of item.
    let Thing = _prefix "Thing"
          

    /// The most generic uni-directional social relation.
    let follows = _prefix "follows"
          

    /// The most significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
    let significantLinks = _prefix "significantLinks"
          

    /// The movie presented during this event.
    let workPresented = _prefix "workPresented"
          

    /// The name displayed in the channel guide. For many US affiliates, it is the network name.
    let broadcastDisplayName = _prefix "broadcastDisplayName"
          

    /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
    let characterName = _prefix "characterName"
          

    /// The name of a node in an established educational framework.
    let targetName = _prefix "targetName"
          

    /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
    let applicationSuite = _prefix "applicationSuite"
          

    /// The name of the bus (e.g. Bolt Express).
    let busName = _prefix "busName"
          

    /// The name of the credit card or other method of payment for the order.
    let paymentMethod = _prefix "paymentMethod"
          

    /// The name of the item.
    let name = _prefix "name"
          

    /// The name of the train (e.g. The Orient Express).
    let trainName = _prefix "trainName"
          

    /// The number of adults staying in the unit.
    let numAdults = _prefix "numAdults"
          

    /// The number of answers this question has received.
    let answerCount = _prefix "answerCount"
          

    /// The number of attendee places for an event that remain unallocated.
    let remainingAttendeeCapacity = _prefix "remainingAttendeeCapacity"
          

    /// The number of axles.<br/><br/>
/// 
/// Typical unit code(s): C62
    let numberOfAxles = _prefix "numberOfAxles"
          

    /// The number of calories.
    let calories = _prefix "calories"
          

    /// The number of children staying in the unit.
    let numChildren = _prefix "numChildren"
          

    /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
    let commentCount = _prefix "commentCount"
          

    /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
    let artEdition = _prefix "artEdition"
          

    /// The number of doors.<br/><br/>
/// 
/// Typical unit code(s): C62
    let numberOfDoors = _prefix "numberOfDoors"
          

    /// The number of downvotes this question, answer or comment has received from the community.
    let downvoteCount = _prefix "downvoteCount"
          

    /// The number of employees in an organization e.g. business.
    let numberOfEmployees = _prefix "numberOfEmployees"
          

    /// The number of episodes in this season or series.
    let numberOfEpisodes = _prefix "numberOfEpisodes"
          

    /// The number of grams of carbohydrates.
    let carbohydrateContent = _prefix "carbohydrateContent"
          

    /// The number of grams of fat.
    let fatContent = _prefix "fatContent"
          

    /// The number of grams of fiber.
    let fiberContent = _prefix "fiberContent"
          

    /// The number of grams of protein.
    let proteinContent = _prefix "proteinContent"
          

    /// The number of grams of saturated fat.
    let saturatedFatContent = _prefix "saturatedFatContent"
          

    /// The number of grams of sugar.
    let sugarContent = _prefix "sugarContent"
          

    /// The number of grams of trans fat.
    let transFatContent = _prefix "transFatContent"
          

    /// The number of grams of unsaturated fat.
    let unsaturatedFatContent = _prefix "unsaturatedFatContent"
          

    /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
    let userInteractionCount = _prefix "userInteractionCount"
          

    /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
    let interactionStatistic = _prefix "interactionStatistic"
          

    /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
    let numberOfItems = _prefix "numberOfItems"
          

    /// The number of milligrams of cholesterol.
    let cholesterolContent = _prefix "cholesterolContent"
          

    /// The number of milligrams of sodium.
    let sodiumContent = _prefix "sodiumContent"
          

    /// The number of offers for the product.
    let offerCount = _prefix "offerCount"
          

    /// The number of owners of the vehicle, including the current one.<br/><br/>
/// 
/// Typical unit code(s): C62
    let numberOfPreviousOwners = _prefix "numberOfPreviousOwners"
          

    /// The number of pages in the book.
    let numberOfPages = _prefix "numberOfPages"
          

    /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.<br/><br/>
/// 
/// Typical unit code(s): C62 for persons.
    let vehicleSeatingCapacity = _prefix "vehicleSeatingCapacity"
          

    /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
/// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
    let numberOfRooms = _prefix "numberOfRooms"
          

    /// The number of screens in the movie theater.
    let screenCount = _prefix "screenCount"
          

    /// The number of seasons in this series.
    let numberOfSeasons = _prefix "numberOfSeasons"
          

    /// The number of the column in which the NewsArticle appears in the print edition.
    let printColumn = _prefix "printColumn"
          

    /// The number of the item ordered. If the property is not set, assume the quantity is one.
    let orderQuantity = _prefix "orderQuantity"
          

    /// The number of tracks in this album or playlist.
    let numTracks = _prefix "numTracks"
          

    /// The number of upvotes this question, answer or comment has received from the community.
    let upvoteCount = _prefix "upvoteCount"
          

    /// The number of words in the text of the Article.
    let wordCount = _prefix "wordCount"
          

    /// The number or other unique designator assigned to a Report by the publishing organization.
    let reportNumber = _prefix "reportNumber"
          

    /// The number or type of airbags in the vehicle.
    let numberOfAirbags = _prefix "numberOfAirbags"
          

    /// The number to access the service by text message.
    let serviceSmsNumber = _prefix "serviceSmsNumber"
          

    /// The object that helped the agent perform the action. e.g. John wrote a book with <em>a pen</em>.
    let instrument = _prefix "instrument"
          

    /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read <em>a book</em>.
    let object = _prefix "object"
          

    /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.<br/><br/>
/// 
/// Usage guidelines:<br/><br/>
/// 
/// <ul>
/// <li>Use the <a class="localLink" href="http://schema.org/priceCurrency">priceCurrency</a> property (with standard formats: <a href="http://en.wikipedia.org/wiki/ISO_4217">ISO 4217 currency format</a> e.g. "USD"; <a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies">Ticker symbol</a> for cryptocurrencies e.g. "BTC"; well known names for <a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system">Local Exchange Tradings Systems</a> (LETS) and other currency types e.g. "Ithaca HOUR") instead of including <a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign">ambiguous symbols</a> such as '$' in the value.</li>
/// <li>Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.</li>
/// <li>Note that both <a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute">RDFa</a> and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.</li>
/// <li>Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.</li>
/// </ul>
/// 
    let price = _prefix "price"
          

    /// The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
    let acceptedOffer = _prefix "acceptedOffer"
          

    /// The official name of the organization, e.g. the registered company name.
    let legalName = _prefix "legalName"
          

    /// The opening hour of the place or service on the given day(s) of the week.
    let opens = _prefix "opens"
          

    /// The opening hours of a certain place.
    let openingHoursSpecification = _prefix "openingHoursSpecification"
          

    /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
    let serviceOperator = _prefix "serviceOperator"
          

    /// The order is being paid as part of the referenced Invoice.
    let partOfInvoice = _prefix "partOfInvoice"
          

    /// The organization (airline, travelers' club, etc.) the membership is made with.
    let hostingOrganization = _prefix "hostingOrganization"
          

    /// The organization issuing the ticket or permit.
    let issuedBy = _prefix "issuedBy"
          

    /// The organization or person from which the product was acquired.
    let acquiredFrom = _prefix "acquiredFrom"
          

    /// The organization owning or operating the broadcast service.
    let broadcaster = _prefix "broadcaster"
          

    /// The overall order the items in this delivery were included in.
    let partOfOrder = _prefix "partOfOrder"
          

    /// The overall rating, based on a collection of reviews or ratings, of the item.
    let aggregateRating = _prefix "aggregateRating"
          

    /// The page on which the work ends; for example "138" or "xvi".
    let pageEnd = _prefix "pageEnd"
          

    /// The page on which the work starts; for example "135" or "xiii".
    let pageStart = _prefix "pageStart"
          

    /// The parent of a question, answer or item in general.
    let parentItem = _prefix "parentItem"
          

    /// The party holding the legal copyright to the CreativeWork.
    let copyrightHolder = _prefix "copyrightHolder"
          

    /// The passenger's sequence number as assigned by the airline.
    let passengerSequenceNumber = _prefix "passengerSequenceNumber"
          

    /// The payee received the payment, but it was declined for some reason.
    let PaymentDeclined = _prefix "PaymentDeclined"
          

    /// The payment has been received and processed.
    let PaymentComplete = _prefix "PaymentComplete"
          

    /// The payment is due and considered late.
    let PaymentPastDue = _prefix "PaymentPastDue"
          

    /// The payment is due, but still within an acceptable time to be received.
    let PaymentDue = _prefix "PaymentDue"
          

    /// The payment method(s) accepted by seller for this offer.
    let acceptedPaymentMethod = _prefix "acceptedPaymentMethod"
          

    /// The payment method(s) to which the payment charge specification applies.
    let appliesToPaymentMethod = _prefix "appliesToPaymentMethod"
          

    /// The person or organization the reservation or ticket is for.
    let underName = _prefix "underName"
          

    /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
    let producer = _prefix "producer"
          

    /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
    let composer = _prefix "composer"
          

    /// The person who wrote the words.
    let lyricist = _prefix "lyricist"
          

    /// The person's spouse.
    let spouse = _prefix "spouse"
          

    /// The person, organization, contact point, or audience that has been granted this permission.
    let grantee = _prefix "grantee"
          

    /// The phone number to use to access the service.
    let servicePhone = _prefix "servicePhone"
          

    /// The place and time the release was issued, expressed as a PublicationEvent.
    let releasedEvent = _prefix "releasedEvent"
          

    /// The place where a person lives.
    let Residence = _prefix "Residence"
          

    /// The place where the Organization was founded.
    let foundingLocation = _prefix "foundingLocation"
          

    /// The place where the person died.
    let deathPlace = _prefix "deathPlace"
          

    /// The place where the person was born.
    let birthPlace = _prefix "birthPlace"
          

    /// The place(s) from which the offer can be obtained (e.g. store locations).
    let availableAtOrFrom = _prefix "availableAtOrFrom"
          

    /// The platform from which the train departs.
    let departurePlatform = _prefix "departurePlatform"
          

    /// The platform where the train arrives.
    let arrivalPlatform = _prefix "arrivalPlatform"
          

    /// The playlist to which this recording belongs.
    let inPlaylist = _prefix "inPlaylist"
          

    /// The position of an item in a series or sequence of items.
    let position = _prefix "position"
          

    /// The position of the steering wheel or similar device (mostly for cars).
    let steeringPosition = _prefix "steeringPosition"
          

    /// The post office box number for PO box addresses.
    let postOfficeBoxNumber = _prefix "postOfficeBoxNumber"
          

    /// The postal code. For example, 94043.
    let postalCode = _prefix "postalCode"
          

    /// The postings that are part of this blog.
    let blogPosts = _prefix "blogPosts"
          

    /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
    let interactivityType = _prefix "interactivityType"
          

    /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
    let learningResourceType = _prefix "learningResourceType"
          

    /// The price asked for a given offer by the respective organization or person.
    let UnitPriceSpecification = _prefix "UnitPriceSpecification"
          

    /// The price for the delivery of an offer using a particular delivery method.
    let DeliveryChargeSpecification = _prefix "DeliveryChargeSpecification"
          

    /// The price range of the business, for example <code>$$$</code>.
    let priceRange = _prefix "priceRange"
          

    /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
    let passengerPriorityStatus = _prefix "passengerPriorityStatus"
          

    /// The product identifier, such as ISBN. For example: <code>meta itemprop="productID" content="isbn:123-456-789"</code>.
    let productID = _prefix "productID"
          

    /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
    let productSupported = _prefix "productSupported"
          

    /// The product that this structured value is referring to.
    let typeOfGood = _prefix "typeOfGood"
          

    /// The production company or studio responsible for the item e.g. series, video game, episode etc.
    let productionCompany = _prefix "productionCompany"
          

    /// The program providing the membership.
    let programName = _prefix "programName"
          

    /// The publication format of the book.
    let BookFormatType = _prefix "BookFormatType"
          

    /// The publisher of the creative work.
    let publisher = _prefix "publisher"
          

    /// The publishingPrinciples property indicates (typically via <a class="localLink" href="http://schema.org/URL">URL</a>) a document describing the editorial principles of an <a class="localLink" href="http://schema.org/Organization">Organization</a> (or individual e.g. a <a class="localLink" href="http://schema.org/Person">Person</a> writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a <a class="localLink" href="http://schema.org/CreativeWork">CreativeWork</a> (e.g. <a class="localLink" href="http://schema.org/NewsArticle">NewsArticle</a>) the principles are those of the party primarily responsible for the creation of the <a class="localLink" href="http://schema.org/CreativeWork">CreativeWork</a>.<br/><br/>
/// 
/// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a <a class="localLink" href="http://schema.org/funder">funder</a>) can be expressed using schema.org terminology.
    let publishingPrinciples = _prefix "publishingPrinciples"
          

    /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
    let educationalUse = _prefix "educationalUse"
          

    /// The quality of the video.
    let videoQuality = _prefix "videoQuality"
          

    /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
    let numberOfBeds = _prefix "numberOfBeds"
          

    /// The quantity of the goods included in the offer.
    let amountOfThisGood = _prefix "amountOfThisGood"
          

    /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
    let recipeYield = _prefix "recipeYield"
          

    /// The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
    let yield = _prefix "yield"
          

    /// The range of temporal applicability of a dataset, e.g. for a 2011 census dataset, the year 2011 (in ISO 8601 time interval format).
    let datasetTimeInterval = _prefix "datasetTimeInterval"
          

    /// The rating for the content.<br/><br/>
/// 
/// Usage guidelines:<br/><br/>
/// 
/// <ul>
/// <li>Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.</li>
/// <li>Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.</li>
/// </ul>
/// 
    let ratingValue = _prefix "ratingValue"
          

    /// The rating given in this review. Note that reviews can themselves be rated. The <code>reviewRating</code> applies to rating given by the review. The <a class="localLink" href="http://schema.org/aggregateRating">aggregateRating</a> property applies to the review itself, as a creative work.
    let reviewRating = _prefix "reviewRating"
          

    /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
    let referenceQuantity = _prefix "referenceQuantity"
          

    /// The region in which the locality is, and which is in the country. For example, California or another appropriate first-level <a href="https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country">Administrative division</a>
    let addressRegion = _prefix "addressRegion"
          

    /// The region/country for which this occupational description is appropriate. Note that educational requirements and qualifications can vary between jurisdictions.
    let occupationLocation = _prefix "occupationLocation"
          

    /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in <a href="http://en.wikipedia.org/wiki/ISO_3166">ISO 3166 format</a>.
    let regionsAllowed = _prefix "regionsAllowed"
          

    /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
    let releaseDate = _prefix "releaseDate"
          

    /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
    let vehicleModelDate = _prefix "vehicleModelDate"
          

    /// The required quantity of the item(s).
    let requiredQuantity = _prefix "requiredQuantity"
          

    /// The response (yes, no, maybe) to the RSVP.
    let rsvpResponse = _prefix "rsvpResponse"
          

    /// The result produced in the action. e.g. John wrote <em>a book</em>.
    let result = _prefix "result"
          

    /// The row location of the reserved seat (e.g., B).
    let seatRow = _prefix "seatRow"
          

    /// The scope of the warranty promise.
    let warrantyScope = _prefix "warrantyScope"
          

    /// The season to which this episode belongs.
    let partOfSeason = _prefix "partOfSeason"
          

    /// The seat associated with the ticket.
    let ticketedSeat = _prefix "ticketedSeat"
          

    /// The section location of the reserved seat (e.g. Orchestra).
    let seatSection = _prefix "seatSection"
          

    /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
    let serialNumber = _prefix "serialNumber"
          

    /// The series to which this episode or season belongs.
    let partOfSeries = _prefix "partOfSeries"
          

    /// The server on which  it is possible to play the game.
    let gameServer = _prefix "gameServer"
          

    /// The service provided by this channel.
    let providesService = _prefix "providesService"
          

    /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
    let provider = _prefix "provider"
          

    /// The service through with the permit was granted.
    let issuedThrough = _prefix "issuedThrough"
          

    /// The serving size, in terms of the number of volume or mass.
    let servingSize = _prefix "servingSize"
          

    /// The size of the accommodation, e.g. in square meter or squarefoot.
/// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard
    let floorSize = _prefix "floorSize"
          

    /// The size of the business in annual revenue.
    let yearlyRevenue = _prefix "yearlyRevenue"
          

    /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
    let spatialCoverage = _prefix "spatialCoverage"
          

    /// The special opening hours of a certain place.<br/><br/>
/// 
/// Use this to explicitly override general opening hours brought in scope by <a class="localLink" href="http://schema.org/openingHoursSpecification">openingHoursSpecification</a> or <a class="localLink" href="http://schema.org/openingHours">openingHours</a>.
    let specialOpeningHoursSpecification = _prefix "specialOpeningHoursSpecification"
          

    /// The start date and time of the item (in <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 date format</a>).
    let startDate = _prefix "startDate"
          

    /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from <em>January</em> to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.<br/><br/>
/// 
/// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
    let startTime = _prefix "startTime"
          

    /// The station from which the train departs.
    let departureStation = _prefix "departureStation"
          

    /// The station where the train trip ends.
    let arrivalStation = _prefix "arrivalStation"
          

    /// The status for a previously confirmed reservation that is now cancelled.
    let ReservationCancelled = _prefix "ReservationCancelled"
          

    /// The status of a confirmed reservation.
    let ReservationConfirmed = _prefix "ReservationConfirmed"
          

    /// The status of a reservation on hold pending an update like credit card number or flight changes.
    let ReservationHold = _prefix "ReservationHold"
          

    /// The status of a reservation when a request has been sent, but not confirmed.
    let ReservationPending = _prefix "ReservationPending"
          

    /// The status of an Action.
    let ActionStatusType = _prefix "ActionStatusType"
          

    /// The status of payment; whether the invoice has been paid or not.
    let paymentStatus = _prefix "paymentStatus"
          

    /// The steering position is on the left side of the vehicle (viewed from the main direction of driving).
    let LeftHandDriving = _prefix "LeftHandDriving"
          

    /// The steering position is on the right side of the vehicle (viewed from the main direction of driving).
    let RightHandDriving = _prefix "RightHandDriving"
          

    /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
    let stepValue = _prefix "stepValue"
          

    /// The stop or station from which the bus arrives.
    let arrivalBusStop = _prefix "arrivalBusStop"
          

    /// The stop or station from which the bus departs.
    let departureBusStop = _prefix "departureBusStop"
          

    /// The street address. For example, 1600 Amphitheatre Pkwy.
    let streetAddress = _prefix "streetAddress"
          

    /// The subject matter of the content.
    let about = _prefix "about"
          

    /// The supported content type(s) for an EntryPoint response.
    let contentType = _prefix "contentType"
          

    /// The supported encoding type(s) for an EntryPoint request.
    let encodingType = _prefix "encodingType"
          

    /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
    let artworkSurface = _prefix "artworkSurface"
          

    /// The tangible thing generated by the service, e.g. a passport, permit, etc.
    let produces = _prefix "produces"
          

    /// The tangible thing generated by the service, e.g. a passport, permit, etc.
    let serviceOutput = _prefix "serviceOutput"
          

    /// The target audience for this permit.
    let permitAudience = _prefix "permitAudience"
          

    /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
    let audienceType = _prefix "audienceType"
          

    /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
    let quest = _prefix "quest"
          

    /// The telephone number.
    let telephone = _prefix "telephone"
          

    /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in <a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals">ISO 8601 time interval format</a>. In
///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".<br/><br/>
/// 
/// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated.
    let temporalCoverage = _prefix "temporalCoverage"
          

    /// The text of the UserComment.
    let commentText = _prefix "commentText"
          

    /// The textual content of this CreativeWork.
    let text = _prefix "text"
          

    /// The thing -- flight, event, restaurant,etc. being reserved.
    let reservationFor = _prefix "reservationFor"
          

    /// The time admission will commence.
    let doorTime = _prefix "doorTime"
          

    /// The time at which the UserComment was made.
    let commentTime = _prefix "commentTime"
          

    /// The time interval used to compute the invoice.
    let billingPeriod = _prefix "billingPeriod"
          

    /// The time it takes to actually cook the dish, in <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 duration format</a>.
    let cookTime = _prefix "cookTime"
          

    /// The time the object is scheduled to.
    let scheduledTime = _prefix "scheduledTime"
          

    /// The time when a passenger can check into the flight online.
    let webCheckinTime = _prefix "webCheckinTime"
          

    /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
    let coverageStartTime = _prefix "coverageStartTime"
          

    /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
    let coverageEndTime = _prefix "coverageEndTime"
          

    /// The timezone in <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 format</a> for which the service bases its broadcasts
    let broadcastTimezone = _prefix "broadcastTimezone"
          

    /// The title of the job.
    let title = _prefix "title"
          

    /// The total amount due.
    let totalPaymentDue = _prefix "totalPaymentDue"
          

    /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.<br/><br/>
/// 
/// Typical unit code(s): KMT for kilometers, SMI for statute miles
    let mileageFromOdometer = _prefix "mileageFromOdometer"
          

    /// The total financial value of the person as calculated by subtracting assets from liabilities.
    let netWorth = _prefix "netWorth"
          

    /// The total number of forward gears available for the transmission system of the vehicle.<br/><br/>
/// 
/// Typical unit code(s): C62
    let numberOfForwardGears = _prefix "numberOfForwardGears"
          

    /// The total number of individuals that may attend an event or venue.
    let maximumAttendeeCapacity = _prefix "maximumAttendeeCapacity"
          

    /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.<br/><br/>
/// 
/// Usage guidelines:<br/><br/>
/// 
/// <ul>
/// <li>Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.</li>
/// <li>Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.</li>
/// </ul>
/// 
    let totalPrice = _prefix "totalPrice"
          

    /// The total time required to perform instructions or a direction (including time to prepare the supplies), in <a href="http://en.wikipedia.org/wiki/ISO_8601">ISO 8601 duration format</a>.
    let totalTime = _prefix "totalTime"
          

    /// The trailer of a movie or tv/radio series, season, episode, etc.
    let trailer = _prefix "trailer"
          

    /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
    let eligibleTransactionVolume = _prefix "eligibleTransactionVolume"
          

    /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.
    let bed = _prefix "bed"
          

    /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
    let typeOfBed = _prefix "typeOfBed"
          

    /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
    let boardingPolicy = _prefix "boardingPolicy"
          

    /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
    let vehicleTransmission = _prefix "vehicleTransmission"
          

    /// The type of composition (e.g. overture, sonata, symphony, etc.).
    let musicCompositionForm = _prefix "musicCompositionForm"
          

    /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
    let fuelType = _prefix "fuelType"
          

    /// The type of permission granted the person, organization, or audience.
    let permissionType = _prefix "permissionType"
          

    /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
    let videoFormat = _prefix "videoFormat"
          

    /// The type of security screening the passenger is subject to.
    let securityScreening = _prefix "securityScreening"
          

    /// The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
    let serviceType = _prefix "serviceType"
          

    /// The type of service required to have access to the channel (e.g. Standard or Premium).
    let broadcastServiceTier = _prefix "broadcastServiceTier"
          

    /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
    let vehicleInteriorType = _prefix "vehicleInteriorType"
          

    /// The type(s) of customers for which the given offer is valid.
    let eligibleCustomerType = _prefix "eligibleCustomerType"
          

    /// The type/class of the seat.
    let seatingType = _prefix "seatingType"
          

    /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
    let deliveryLeadTime = _prefix "deliveryLeadTime"
          

    /// The typical expected age range, e.g. '7-9', '11-'.
    let typicalAgeRange = _prefix "typicalAgeRange"
          

    /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
    let workHours = _prefix "workHours"
          

    /// The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.
    let broadcastChannelId = _prefix "broadcastChannelId"
          

    /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
    let flightNumber = _prefix "flightNumber"
          

    /// The unique identifier for the bus.
    let busNumber = _prefix "busNumber"
          

    /// The unique identifier for the ticket.
    let ticketNumber = _prefix "ticketNumber"
          

    /// The unique identifier for the train.
    let trainNumber = _prefix "trainNumber"
          

    /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
    let unitCode = _prefix "unitCode"
          

    /// The upper value of some characteristic or property.
    let maxValue = _prefix "maxValue"
          

    /// The value of the quantitative value or property value node.<br/><br/>
/// 
/// <ul>
/// <li>For <a class="localLink" href="http://schema.org/QuantitativeValue">QuantitativeValue</a> and <a class="localLink" href="http://schema.org/MonetaryAmount">MonetaryAmount</a>, the recommended type for values is 'Number'.</li>
/// <li>For <a class="localLink" href="http://schema.org/PropertyValue">PropertyValue</a>, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.</li>
/// <li>Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.</li>
/// <li>Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.</li>
/// </ul>
/// 
    let value = _prefix "value"
          

    /// The version of the CreativeWork embodied by a specified resource.
    let version = _prefix "version"
          

    /// The warranty promise(s) included in the offer.
    let warranty = _prefix "warranty"
          

    /// The warranty promise(s) included in the offer.
    let warrantyPromise = _prefix "warrantyPromise"
          

    /// The website to access the service.
    let serviceUrl = _prefix "serviceUrl"
          

    /// The weight of the product or person.
    let weight = _prefix "weight"
          

    /// The width of the item.
    let width = _prefix "width"
          

    /// The words in the song.
    let lyrics = _prefix "lyrics"
          

    /// The year during which the claimed copyright for the CreativeWork was first asserted.
    let copyrightYear = _prefix "copyrightYear"
          

    /// This Review or Rating is relevant to this part or facet of the itemReviewed.
    let reviewAspect = _prefix "reviewAspect"
          

    /// This links to a node or nodes indicating the exact quantity of the products included in the offer.
    let includesObject = _prefix "includesObject"
          

    /// This ordering relation for qualitative values indicates that the subject is equal to the object.
    let equal = _prefix "equal"
          

    /// This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.
    let greaterOrEqual = _prefix "greaterOrEqual"
          

    /// This ordering relation for qualitative values indicates that the subject is greater than the object.
    let greater = _prefix "greater"
          

    /// This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.
    let lesserOrEqual = _prefix "lesserOrEqual"
          

    /// This ordering relation for qualitative values indicates that the subject is lesser than the object.
    let lesser = _prefix "lesser"
          

    /// This ordering relation for qualitative values indicates that the subject is not equal to the object.
    let nonEqual = _prefix "nonEqual"
          

    /// This property is deprecated, alongside the UserInteraction types on which it depended.
    let interactionCount = _prefix "interactionCount"
          

    /// This property links to all <a class="localLink" href="http://schema.org/UnitPriceSpecification">UnitPriceSpecification</a> nodes that apply in parallel for the <a class="localLink" href="http://schema.org/CompoundPriceSpecification">CompoundPriceSpecification</a> node.
    let priceComponent = _prefix "priceComponent"
          

    /// This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.
    let billingIncrement = _prefix "billingIncrement"
          

    /// This stands for any day that is a public holiday; it is a placeholder for all official public holidays in some particular location. While not technically a "day of the week", it can be used with <a class="localLink" href="http://schema.org/OpeningHoursSpecification">OpeningHoursSpecification</a>. In the context of an opening hours specification it can be used to indicate opening hours on public holidays, overriding general opening hours for the day of the week on which a public holiday occurs.
    let PublicHolidays = _prefix "PublicHolidays"
          

    /// This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the <a class="localLink" href="http://schema.org/Language">Language</a> type.
    let ComputerLanguage = _prefix "ComputerLanguage"
          

    /// Thumbnail image for an image or video.
    let thumbnail = _prefix "thumbnail"
          

    /// Tracking url for the parcel delivery.
    let trackingUrl = _prefix "trackingUrl"
          

    /// True is the broadcast is of a live event.
    let isLiveBroadcast = _prefix "isLiveBroadcast"
          

    /// Type of app development: phone, Metro style, desktop, XBox, etc.
    let targetPlatform = _prefix "targetPlatform"
          

    /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
    let employmentType = _prefix "employmentType"
          

    /// Type of ordering (e.g. Ascending, Descending, Unordered).
    let itemListOrder = _prefix "itemListOrder"
          

    /// Type of software application, e.g. 'Game, Multimedia'.
    let applicationCategory = _prefix "applicationCategory"
          

    /// URL at which the app may be installed, if different from the URL of the item.
    let installUrl = _prefix "installUrl"
          

    /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.
    let sameAs = _prefix "sameAs"
          

    /// URL of the item.
    let url = _prefix "url"
          

    /// Upcoming or past event associated with this place, organization, or action.
    let event = _prefix "event"
          

    /// Upcoming or past events associated with this place or organization.
    let events = _prefix "events"
          

    /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
    let previousStartDate = _prefix "previousStartDate"
          

    /// Used to describe a seat, such as a reserved seat in an event reservation.
    let Seat = _prefix "Seat"
          

    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    let Ticket = _prefix "Ticket"
          

    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    let ProgramMembership = _prefix "ProgramMembership"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserBlocks = _prefix "UserBlocks"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserCheckins = _prefix "UserCheckins"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserComments = _prefix "UserComments"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserDownloads = _prefix "UserDownloads"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserInteraction = _prefix "UserInteraction"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserLikes = _prefix "UserLikes"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserPageVisits = _prefix "UserPageVisits"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserPlays = _prefix "UserPlays"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserPlusOnes = _prefix "UserPlusOnes"
          

    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use <a class="localLink" href="http://schema.org/Action">Action</a>-based vocabulary, alongside types such as <a class="localLink" href="http://schema.org/Comment">Comment</a>.
    let UserTweets = _prefix "UserTweets"
          

    /// Uses devices to support users with hearing impairments.
    let HearingImpairedSupported = _prefix "HearingImpairedSupported"
          

    /// Version of the software instance.
    let softwareVersion = _prefix "softwareVersion"
          

    /// Video game which is played on this server.
    let game = _prefix "game"
          

    /// VinylFormat.
    let VinylFormat = _prefix "VinylFormat"
          

    /// Was the offer accepted as a gift for someone other than the buyer.
    let isGift = _prefix "isGift"
          

    /// Web applications.
    let WebApplication = _prefix "WebApplication"
          

    /// Web page type: About page.
    let AboutPage = _prefix "AboutPage"
          

    /// Web page type: Checkout page.
    let CheckoutPage = _prefix "CheckoutPage"
          

    /// Web page type: Collection page.
    let CollectionPage = _prefix "CollectionPage"
          

    /// Web page type: Contact page.
    let ContactPage = _prefix "ContactPage"
          

    /// Web page type: Image gallery page.
    let ImageGallery = _prefix "ImageGallery"
          

    /// Web page type: Media gallery page. A mixed-media page that can contains media such as images, videos, and other multimedia.
    let MediaGallery = _prefix "MediaGallery"
          

    /// Web page type: Profile page.
    let ProfilePage = _prefix "ProfilePage"
          

    /// Web page type: Search results page.
    let SearchResultsPage = _prefix "SearchResultsPage"
          

    /// Web page type: Video gallery page.
    let VideoGallery = _prefix "VideoGallery"
          

    /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
    let codeSampleType = _prefix "codeSampleType"
          

    /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
    let sampleType = _prefix "sampleType"
          

    /// When a rental car can be dropped off.
    let dropoffTime = _prefix "dropoffTime"
          

    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.<br/><br/>
/// 
/// Note: AggregateOffers are normally expected to associate multiple offers that all share the same defined <a class="localLink" href="http://schema.org/businessFunction">businessFunction</a> value, or default to http://purl.org/goodrelations/v1#Sell if businessFunction is not explicitly defined.
    let AggregateOffer = _prefix "AggregateOffer"
          

    /// When a taxi will pickup a passenger or a rental car can be picked up.
    let pickupTime = _prefix "pickupTime"
          

    /// When the item is available for pickup from the store, locker, etc.
    let availableFrom = _prefix "availableFrom"
          

    /// Where a rental car can be dropped off.
    let dropoffLocation = _prefix "dropoffLocation"
          

    /// Where a taxi will pick up a passenger or a rental car can be picked up.
    let pickupLocation = _prefix "pickupLocation"
          

    /// Whether multiple values are allowed for the property.  Default is false.
    let multipleValues = _prefix "multipleValues"
          

    /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
    let readonlyValue = _prefix "readonlyValue"
          

    /// Whether the property must be filled in to complete the action.  Default is false.
    let valueRequired = _prefix "valueRequired"
          

    /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
    let artform = _prefix "artform"
          

    /// exif data for this object.
    let exifData = _prefix "exifData"
          