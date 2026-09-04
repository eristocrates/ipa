#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module schema =
    let _prefixId = PrefixId.fromNamespaceLabel "http://schema.org/" "schema"
    /// <summary>
    ///   <para>schema:category : issue-1004^^xsd:string</para>
    ///   <para>rdfs:label : AMRadioChannel^^xsd:string</para>
    ///   <para>rdfs:comment : A radio channel that uses AM.^^xsd:string</para>
    ///   <a href="http://schema.org/AMRadioChannel">schema:AMRadioChannel</a>
    /// </summary>
    let AMRadioChannel = _prefixId.prefix "AMRadioChannel"
    /// <summary>
    ///   <para>rdfs:comment : Reference documentation for application programming interfaces (APIs).^^xsd:string</para>
    ///   <para>rdfs:label : APIReference^^xsd:string</para>
    ///   <a href="http://schema.org/APIReference">schema:APIReference</a>
    /// </summary>
    let APIReference = _prefixId.prefix "APIReference"
    /// <summary>
    ///   <para>rdfs:label : AboutPage^^xsd:string</para>
    ///   <para>rdfs:comment : Web page type: About page.^^xsd:string</para>
    ///   <a href="http://schema.org/AboutPage">schema:AboutPage</a>
    /// </summary>
    let AboutPage = _prefixId.prefix "AboutPage"
    /// <summary>
    ///   <para>rdfs:comment : The act of committing to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RejectAction"&gt;RejectAction&lt;/a&gt;: The antonym of AcceptAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : AcceptAction^^xsd:string</para>
    ///   <a href="http://schema.org/AcceptAction">schema:AcceptAction</a>
    /// </summary>
    let AcceptAction = _prefixId.prefix "AcceptAction"
    /// <summary>
    ///   <para>rdfs:label : Accommodation^^xsd:string</para>
    ///   <para>rdfs:comment : An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use additionalType with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/Accommodation">schema:Accommodation</a>
    /// </summary>
    let Accommodation = _prefixId.prefix "Accommodation"
    /// <summary>
    ///   <para>rdfs:comment : Accountancy business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).^^xsd:string</para>
    ///   <para>rdfs:label : AccountingService^^xsd:string</para>
    ///   <a href="http://schema.org/AccountingService">schema:AccountingService</a>
    /// </summary>
    let AccountingService = _prefixId.prefix "AccountingService"
    /// <summary>
    ///   <para>rdfs:label : AchieveAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.^^xsd:string</para>
    ///   <a href="http://schema.org/AchieveAction">schema:AchieveAction</a>
    /// </summary>
    let AchieveAction = _prefixId.prefix "AchieveAction"
    /// <summary>
    ///   <para>rdfs:comment : An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/04/announcing-schemaorg-actions.html"&gt;blog post&lt;/a&gt; and &lt;a href="http://schema.org/docs/actions.html"&gt;Actions overview document&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Action^^xsd:string</para>
    ///   <a href="http://schema.org/Action">schema:Action</a>
    /// </summary>
    let Action = _prefixId.prefix "Action"
    /// <summary>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <para>rdfs:label : ActionAccessSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : A set of requirements that a must be fulfilled in order to perform an Action.^^xsd:string</para>
    ///   <a href="http://schema.org/ActionAccessSpecification">schema:ActionAccessSpecification</a>
    /// </summary>
    let ActionAccessSpecification = _prefixId.prefix "ActionAccessSpecification"
    /// <summary>
    ///   <para>rdfs:label : ActionStatusType^^xsd:string</para>
    ///   <para>rdfs:comment : The status of an Action.^^xsd:string</para>
    ///   <a href="http://schema.org/ActionStatusType">schema:ActionStatusType</a>
    /// </summary>
    let ActionStatusType = _prefixId.prefix "ActionStatusType"
    /// <summary>
    ///   <para>rdfs:label : ActivateAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).^^xsd:string</para>
    ///   <a href="http://schema.org/ActivateAction">schema:ActivateAction</a>
    /// </summary>
    let ActivateAction = _prefixId.prefix "ActivateAction"
    let ActiveActionStatus = _prefixId.prefix "ActiveActionStatus"
    /// <summary>
    ///   <para>rdfs:comment : The act of editing by adding an object to a collection.^^xsd:string</para>
    ///   <para>rdfs:label : AddAction^^xsd:string</para>
    ///   <a href="http://schema.org/AddAction">schema:AddAction</a>
    /// </summary>
    let AddAction = _prefixId.prefix "AddAction"
    /// <summary>
    ///   <para>rdfs:comment : A geographical region, typically under the jurisdiction of a particular government.^^xsd:string</para>
    ///   <para>rdfs:label : AdministrativeArea^^xsd:string</para>
    ///   <a href="http://schema.org/AdministrativeArea">schema:AdministrativeArea</a>
    /// </summary>
    let AdministrativeArea = _prefixId.prefix "AdministrativeArea"
    /// <summary>
    ///   <para>rdfs:label : AdultEntertainment^^xsd:string</para>
    ///   <para>rdfs:comment : An adult entertainment establishment.^^xsd:string</para>
    ///   <a href="http://schema.org/AdultEntertainment">schema:AdultEntertainment</a>
    /// </summary>
    let AdultEntertainment = _prefixId.prefix "AdultEntertainment"
    /// <summary>
    ///   <para>rdfs:comment : When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: AggregateOffers are normally expected to associate multiple offers that all share the same defined &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; value, or default to http://purl.org/goodrelations/v1#Sell if businessFunction is not explicitly defined.^^xsd:string</para>
    ///   <para>rdfs:label : AggregateOffer^^xsd:string</para>
    ///   <a href="http://schema.org/AggregateOffer">schema:AggregateOffer</a>
    /// </summary>
    let AggregateOffer = _prefixId.prefix "AggregateOffer"
    /// <summary>
    ///   <para>rdfs:comment : The average rating based on multiple ratings or reviews.^^xsd:string</para>
    ///   <para>rdfs:label : AggregateRating^^xsd:string</para>
    ///   <a href="http://schema.org/AggregateRating">schema:AggregateRating</a>
    /// </summary>
    let AggregateRating = _prefixId.prefix "AggregateRating"
    /// <summary>
    ///   <para>rdfs:label : AgreeAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of expressing a consistency of opinion with the object. An agent agrees to/about an object (a proposition, topic or theme) with participants.^^xsd:string</para>
    ///   <a href="http://schema.org/AgreeAction">schema:AgreeAction</a>
    /// </summary>
    let AgreeAction = _prefixId.prefix "AgreeAction"
    /// <summary>
    ///   <para>rdfs:comment : An organization that provides flights for passengers.^^xsd:string</para>
    ///   <para>rdfs:label : Airline^^xsd:string</para>
    ///   <a href="http://schema.org/Airline">schema:Airline</a>
    /// </summary>
    let Airline = _prefixId.prefix "Airline"
    /// <summary>
    ///   <para>rdfs:label : Airport^^xsd:string</para>
    ///   <para>rdfs:comment : An airport.^^xsd:string</para>
    ///   <a href="http://schema.org/Airport">schema:Airport</a>
    /// </summary>
    let Airport = _prefixId.prefix "Airport"
    let AlbumRelease = _prefixId.prefix "AlbumRelease"
    /// <summary>
    ///   <para>rdfs:label : AlignmentObject^^xsd:string</para>
    ///   <para>rdfs:comment : An intangible item that describes an alignment between a learning resource and a node in an educational framework.^^xsd:string</para>
    ///   <a href="http://schema.org/AlignmentObject">schema:AlignmentObject</a>
    /// </summary>
    let AlignmentObject = _prefixId.prefix "AlignmentObject"
    let AllWheelDriveConfiguration = _prefixId.prefix "AllWheelDriveConfiguration"
    /// <summary>
    ///   <para>rdfs:comment : The act of organizing tasks/objects/events by associating resources to it.^^xsd:string</para>
    ///   <para>rdfs:label : AllocateAction^^xsd:string</para>
    ///   <a href="http://schema.org/AllocateAction">schema:AllocateAction</a>
    /// </summary>
    let AllocateAction = _prefixId.prefix "AllocateAction"
    /// <summary>
    ///   <para>rdfs:comment : An amusement park.^^xsd:string</para>
    ///   <para>rdfs:label : AmusementPark^^xsd:string</para>
    ///   <a href="http://schema.org/AmusementPark">schema:AmusementPark</a>
    /// </summary>
    let AmusementPark = _prefixId.prefix "AmusementPark"
    /// <summary>
    ///   <para>rdfs:label : AnimalShelter^^xsd:string</para>
    ///   <para>rdfs:comment : Animal shelter.^^xsd:string</para>
    ///   <a href="http://schema.org/AnimalShelter">schema:AnimalShelter</a>
    /// </summary>
    let AnimalShelter = _prefixId.prefix "AnimalShelter"
    /// <summary>
    ///   <para>rdfs:label : Answer^^xsd:string</para>
    ///   <para>rdfs:comment : An answer offered to a question; perhaps correct, perhaps opinionated or wrong.^^xsd:string</para>
    ///   <a href="http://schema.org/Answer">schema:Answer</a>
    /// </summary>
    let Answer = _prefixId.prefix "Answer"
    /// <summary>
    ///   <para>rdfs:label : Apartment^^xsd:string</para>
    ///   <para>rdfs:comment : An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).^^xsd:string</para>
    ///   <a href="http://schema.org/Apartment">schema:Apartment</a>
    /// </summary>
    let Apartment = _prefixId.prefix "Apartment"
    /// <summary>
    ///   <para>rdfs:label : ApartmentComplex^^xsd:string</para>
    ///   <para>rdfs:comment : Residence type: Apartment complex.^^xsd:string</para>
    ///   <a href="http://schema.org/ApartmentComplex">schema:ApartmentComplex</a>
    /// </summary>
    let ApartmentComplex = _prefixId.prefix "ApartmentComplex"
    /// <summary>
    ///   <para>rdfs:comment : The act of inserting at the end if an ordered collection.^^xsd:string</para>
    ///   <para>rdfs:label : AppendAction^^xsd:string</para>
    ///   <a href="http://schema.org/AppendAction">schema:AppendAction</a>
    /// </summary>
    let AppendAction = _prefixId.prefix "AppendAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of registering to an organization/service without the guarantee to receive it.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : ApplyAction^^xsd:string</para>
    ///   <a href="http://schema.org/ApplyAction">schema:ApplyAction</a>
    /// </summary>
    let ApplyAction = _prefixId.prefix "ApplyAction"
    /// <summary>
    ///   <para>rdfs:label : Aquarium^^xsd:string</para>
    ///   <para>rdfs:comment : Aquarium.^^xsd:string</para>
    ///   <a href="http://schema.org/Aquarium">schema:Aquarium</a>
    /// </summary>
    let Aquarium = _prefixId.prefix "Aquarium"
    /// <summary>
    ///   <para>rdfs:comment : The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.^^xsd:string</para>
    ///   <para>rdfs:label : ArriveAction^^xsd:string</para>
    ///   <a href="http://schema.org/ArriveAction">schema:ArriveAction</a>
    /// </summary>
    let ArriveAction = _prefixId.prefix "ArriveAction"
    /// <summary>
    ///   <para>rdfs:label : ArtGallery^^xsd:string</para>
    ///   <para>rdfs:comment : An art gallery.^^xsd:string</para>
    ///   <a href="http://schema.org/ArtGallery">schema:ArtGallery</a>
    /// </summary>
    let ArtGallery = _prefixId.prefix "ArtGallery"
    /// <summary>
    ///   <para>rdfs:comment : An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Article^^xsd:string</para>
    ///   <a href="http://schema.org/Article">schema:Article</a>
    /// </summary>
    let Article = _prefixId.prefix "Article"
    /// <summary>
    ///   <para>rdfs:comment : The act of posing a question / favor to someone.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : AskAction^^xsd:string</para>
    ///   <a href="http://schema.org/AskAction">schema:AskAction</a>
    /// </summary>
    let AskAction = _prefixId.prefix "AskAction"
    /// <summary>
    ///   <para>rdfs:label : AssessAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of forming one's opinion, reaction or sentiment.^^xsd:string</para>
    ///   <a href="http://schema.org/AssessAction">schema:AssessAction</a>
    /// </summary>
    let AssessAction = _prefixId.prefix "AssessAction"
    /// <summary>
    ///   <para>rdfs:label : AssignAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of allocating an action/event/task to some destination (someone or something).^^xsd:string</para>
    ///   <a href="http://schema.org/AssignAction">schema:AssignAction</a>
    /// </summary>
    let AssignAction = _prefixId.prefix "AssignAction"
    /// <summary>
    ///   <para>rdfs:label : Attorney^^xsd:string</para>
    ///   <para>rdfs:comment : Professional service: Attorney. &lt;br/&gt;&lt;br/&gt;
    ///
    /// This type is deprecated - &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; is more inclusive and less ambiguous.^^xsd:string</para>
    ///   <a href="http://schema.org/Attorney">schema:Attorney</a>
    /// </summary>
    let Attorney = _prefixId.prefix "Attorney"
    /// <summary>
    ///   <para>rdfs:label : Audience^^xsd:string</para>
    ///   <para>rdfs:comment : Intended audience for an item, i.e. the group for whom the item was created.^^xsd:string</para>
    ///   <a href="http://schema.org/Audience">schema:Audience</a>
    /// </summary>
    let Audience = _prefixId.prefix "Audience"
    /// <summary>
    ///   <para>rdfs:comment : An audio file.^^xsd:string</para>
    ///   <para>rdfs:label : AudioObject^^xsd:string</para>
    ///   <a href="http://schema.org/AudioObject">schema:AudioObject</a>
    /// </summary>
    let AudioObject = _prefixId.prefix "AudioObject"
    let Audiobook = _prefixId.prefix "Audiobook"
    let AudiobookFormat = _prefixId.prefix "AudiobookFormat"
    /// <summary>
    ///   <para>rdfs:comment : The act of granting permission to an object.^^xsd:string</para>
    ///   <para>rdfs:label : AuthorizeAction^^xsd:string</para>
    ///   <a href="http://schema.org/AuthorizeAction">schema:AuthorizeAction</a>
    /// </summary>
    let AuthorizeAction = _prefixId.prefix "AuthorizeAction"
    /// <summary>
    ///   <para>rdfs:label : AutoBodyShop^^xsd:string</para>
    ///   <para>rdfs:comment : Auto body shop.^^xsd:string</para>
    ///   <a href="http://schema.org/AutoBodyShop">schema:AutoBodyShop</a>
    /// </summary>
    let AutoBodyShop = _prefixId.prefix "AutoBodyShop"
    /// <summary>
    ///   <para>rdfs:comment : An car dealership.^^xsd:string</para>
    ///   <para>rdfs:label : AutoDealer^^xsd:string</para>
    ///   <a href="http://schema.org/AutoDealer">schema:AutoDealer</a>
    /// </summary>
    let AutoDealer = _prefixId.prefix "AutoDealer"
    /// <summary>
    ///   <para>rdfs:label : AutoPartsStore^^xsd:string</para>
    ///   <para>rdfs:comment : An auto parts store.^^xsd:string</para>
    ///   <a href="http://schema.org/AutoPartsStore">schema:AutoPartsStore</a>
    /// </summary>
    let AutoPartsStore = _prefixId.prefix "AutoPartsStore"
    /// <summary>
    ///   <para>rdfs:label : AutoRental^^xsd:string</para>
    ///   <para>rdfs:comment : A car rental business.^^xsd:string</para>
    ///   <a href="http://schema.org/AutoRental">schema:AutoRental</a>
    /// </summary>
    let AutoRental = _prefixId.prefix "AutoRental"
    /// <summary>
    ///   <para>rdfs:comment : Car repair business.^^xsd:string</para>
    ///   <para>rdfs:label : AutoRepair^^xsd:string</para>
    ///   <a href="http://schema.org/AutoRepair">schema:AutoRepair</a>
    /// </summary>
    let AutoRepair = _prefixId.prefix "AutoRepair"
    /// <summary>
    ///   <para>rdfs:label : AutoWash^^xsd:string</para>
    ///   <para>rdfs:comment : A car wash business.^^xsd:string</para>
    ///   <a href="http://schema.org/AutoWash">schema:AutoWash</a>
    /// </summary>
    let AutoWash = _prefixId.prefix "AutoWash"
    /// <summary>
    ///   <para>rdfs:label : AutomatedTeller^^xsd:string</para>
    ///   <para>rdfs:comment : ATM/cash machine.^^xsd:string</para>
    ///   <a href="http://schema.org/AutomatedTeller">schema:AutomatedTeller</a>
    /// </summary>
    let AutomatedTeller = _prefixId.prefix "AutomatedTeller"
    /// <summary>
    ///   <para>rdfs:label : AutomotiveBusiness^^xsd:string</para>
    ///   <para>rdfs:comment : Car repair, sales, or parts.^^xsd:string</para>
    ///   <a href="http://schema.org/AutomotiveBusiness">schema:AutomotiveBusiness</a>
    /// </summary>
    let AutomotiveBusiness = _prefixId.prefix "AutomotiveBusiness"
    /// <summary>
    ///   <para>rdfs:label : Bakery^^xsd:string</para>
    ///   <para>rdfs:comment : A bakery.^^xsd:string</para>
    ///   <a href="http://schema.org/Bakery">schema:Bakery</a>
    /// </summary>
    let Bakery = _prefixId.prefix "Bakery"
    /// <summary>
    ///   <para>rdfs:label : BankAccount^^xsd:string</para>
    ///   <para>rdfs:comment : A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.^^xsd:string</para>
    ///   <a href="http://schema.org/BankAccount">schema:BankAccount</a>
    /// </summary>
    let BankAccount = _prefixId.prefix "BankAccount"
    /// <summary>
    ///   <para>rdfs:label : BankOrCreditUnion^^xsd:string</para>
    ///   <para>rdfs:comment : Bank or credit union.^^xsd:string</para>
    ///   <a href="http://schema.org/BankOrCreditUnion">schema:BankOrCreditUnion</a>
    /// </summary>
    let BankOrCreditUnion = _prefixId.prefix "BankOrCreditUnion"
    /// <summary>
    ///   <para>rdfs:label : BarOrPub^^xsd:string</para>
    ///   <para>rdfs:comment : A bar or pub.^^xsd:string</para>
    ///   <a href="http://schema.org/BarOrPub">schema:BarOrPub</a>
    /// </summary>
    let BarOrPub = _prefixId.prefix "BarOrPub"
    /// <summary>
    ///   <para>rdfs:label : Barcode^^xsd:string</para>
    ///   <para>rdfs:comment : An image of a visual machine-readable code such as a barcode or QR code.^^xsd:string</para>
    ///   <a href="http://schema.org/Barcode">schema:Barcode</a>
    /// </summary>
    let Barcode = _prefixId.prefix "Barcode"
    /// <summary>
    ///   <para>rdfs:comment : Beach.^^xsd:string</para>
    ///   <para>rdfs:label : Beach^^xsd:string</para>
    ///   <a href="http://schema.org/Beach">schema:Beach</a>
    /// </summary>
    let Beach = _prefixId.prefix "Beach"
    /// <summary>
    ///   <para>rdfs:label : BeautySalon^^xsd:string</para>
    ///   <para>rdfs:comment : Beauty salon.^^xsd:string</para>
    ///   <a href="http://schema.org/BeautySalon">schema:BeautySalon</a>
    /// </summary>
    let BeautySalon = _prefixId.prefix "BeautySalon"
    /// <summary>
    ///   <para>rdfs:label : BedAndBreakfast^^xsd:string</para>
    ///   <para>rdfs:comment : Bed and breakfast.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/BedAndBreakfast">schema:BedAndBreakfast</a>
    /// </summary>
    let BedAndBreakfast = _prefixId.prefix "BedAndBreakfast"
    /// <summary>
    ///   <para>rdfs:comment : An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also &lt;a class="localLink" href="http://schema.org/BedType"&gt;BedType&lt;/a&gt; (under development).^^xsd:string</para>
    ///   <para>rdfs:label : BedDetails^^xsd:string</para>
    ///   <a href="http://schema.org/BedDetails">schema:BedDetails</a>
    /// </summary>
    let BedDetails = _prefixId.prefix "BedDetails"
    /// <summary>
    ///   <para>schema:category : issue-1262^^xsd:string</para>
    ///   <para>rdfs:comment : A type of bed. This is used for indicating the bed or beds available in an accommodation.^^xsd:string</para>
    ///   <para>rdfs:label : BedType^^xsd:string</para>
    ///   <a href="http://schema.org/BedType">schema:BedType</a>
    /// </summary>
    let BedType = _prefixId.prefix "BedType"
    /// <summary>
    ///   <para>rdfs:label : BefriendAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of forming a personal connection with someone (object) mutually/bidirectionally/symmetrically.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, BefriendAction implies that the connection is reciprocal.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/BefriendAction">schema:BefriendAction</a>
    /// </summary>
    let BefriendAction = _prefixId.prefix "BefriendAction"
    /// <summary>
    ///   <para>rdfs:comment : A bike store.^^xsd:string</para>
    ///   <para>rdfs:label : BikeStore^^xsd:string</para>
    ///   <a href="http://schema.org/BikeStore">schema:BikeStore</a>
    /// </summary>
    let BikeStore = _prefixId.prefix "BikeStore"
    /// <summary>
    ///   <para>rdfs:comment : A blog.^^xsd:string</para>
    ///   <para>rdfs:label : Blog^^xsd:string</para>
    ///   <a href="http://schema.org/Blog">schema:Blog</a>
    /// </summary>
    let Blog = _prefixId.prefix "Blog"
    /// <summary>
    ///   <para>rdfs:label : BlogPosting^^xsd:string</para>
    ///   <para>rdfs:comment : A blog post.^^xsd:string</para>
    ///   <a href="http://schema.org/BlogPosting">schema:BlogPosting</a>
    /// </summary>
    let BlogPosting = _prefixId.prefix "BlogPosting"
    /// <summary>
    ///   <para>rdfs:label : BoardingPolicyType^^xsd:string</para>
    ///   <para>rdfs:comment : A type of boarding policy used by an airline.^^xsd:string</para>
    ///   <a href="http://schema.org/BoardingPolicyType">schema:BoardingPolicyType</a>
    /// </summary>
    let BoardingPolicyType = _prefixId.prefix "BoardingPolicyType"
    /// <summary>
    ///   <para>rdfs:comment : A body of water, such as a sea, ocean, or lake.^^xsd:string</para>
    ///   <para>rdfs:label : BodyOfWater^^xsd:string</para>
    ///   <a href="http://schema.org/BodyOfWater">schema:BodyOfWater</a>
    /// </summary>
    let BodyOfWater = _prefixId.prefix "BodyOfWater"
    /// <summary>
    ///   <para>rdfs:label : Book^^xsd:string</para>
    ///   <para>rdfs:comment : A book.^^xsd:string</para>
    ///   <a href="http://schema.org/Book">schema:Book</a>
    /// </summary>
    let Book = _prefixId.prefix "Book"
    /// <summary>
    ///   <para>rdfs:label : BookFormatType^^xsd:string</para>
    ///   <para>rdfs:comment : The publication format of the book.^^xsd:string</para>
    ///   <a href="http://schema.org/BookFormatType">schema:BookFormatType</a>
    /// </summary>
    let BookFormatType = _prefixId.prefix "BookFormatType"
    /// <summary>
    ///   <para>rdfs:label : BookSeries^^xsd:string</para>
    ///   <para>rdfs:comment : A series of books. Included books can be indicated with the hasPart property.^^xsd:string</para>
    ///   <a href="http://schema.org/BookSeries">schema:BookSeries</a>
    /// </summary>
    let BookSeries = _prefixId.prefix "BookSeries"
    /// <summary>
    ///   <para>rdfs:label : BookStore^^xsd:string</para>
    ///   <para>rdfs:comment : A bookstore.^^xsd:string</para>
    ///   <a href="http://schema.org/BookStore">schema:BookStore</a>
    /// </summary>
    let BookStore = _prefixId.prefix "BookStore"
    /// <summary>
    ///   <para>rdfs:label : BookmarkAction^^xsd:string</para>
    ///   <para>rdfs:comment : An agent bookmarks/flags/labels/tags/marks an object.^^xsd:string</para>
    ///   <a href="http://schema.org/BookmarkAction">schema:BookmarkAction</a>
    /// </summary>
    let BookmarkAction = _prefixId.prefix "BookmarkAction"
    /// <summary>
    ///   <para>rdfs:label : Boolean^^xsd:string</para>
    ///   <para>rdfs:comment : Boolean: True or False.^^xsd:string</para>
    ///   <a href="http://schema.org/Boolean">schema:Boolean</a>
    /// </summary>
    let Boolean = _prefixId.prefix "Boolean"
    /// <summary>
    ///   <para>rdfs:comment : The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LendAction"&gt;LendAction&lt;/a&gt;: Reciprocal of BorrowAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : BorrowAction^^xsd:string</para>
    ///   <a href="http://schema.org/BorrowAction">schema:BorrowAction</a>
    /// </summary>
    let BorrowAction = _prefixId.prefix "BorrowAction"
    /// <summary>
    ///   <para>rdfs:label : BowlingAlley^^xsd:string</para>
    ///   <para>rdfs:comment : A bowling alley.^^xsd:string</para>
    ///   <a href="http://schema.org/BowlingAlley">schema:BowlingAlley</a>
    /// </summary>
    let BowlingAlley = _prefixId.prefix "BowlingAlley"
    /// <summary>
    ///   <para>rdfs:comment : A brand is a name used by an organization or business person for labeling a product, product group, or similar.^^xsd:string</para>
    ///   <para>rdfs:label : Brand^^xsd:string</para>
    ///   <a href="http://schema.org/Brand">schema:Brand</a>
    /// </summary>
    let Brand = _prefixId.prefix "Brand"
    /// <summary>
    ///   <para>rdfs:comment : A BreadcrumbList is an ItemList consisting of a chain of linked Web pages, typically described using at least their URL and their name, and typically ending with the current page.&lt;br/&gt;&lt;br/&gt;
    ///
    /// The &lt;a class="localLink" href="http://schema.org/position"&gt;position&lt;/a&gt; property is used to reconstruct the order of the items in a BreadcrumbList The convention is that a breadcrumb list has an &lt;a class="localLink" href="http://schema.org/itemListOrder"&gt;itemListOrder&lt;/a&gt; of &lt;a class="localLink" href="http://schema.org/ItemListOrderAscending"&gt;ItemListOrderAscending&lt;/a&gt; (lower values listed first), and that the first items in this list correspond to the "top" or beginning of the breadcrumb trail, e.g. with a site or section homepage. The specific values of 'position' are not assigned meaning for a BreadcrumbList, but they should be integers, e.g. beginning with '1' for the first item in the list.^^xsd:string</para>
    ///   <para>rdfs:label : BreadcrumbList^^xsd:string</para>
    ///   <a href="http://schema.org/BreadcrumbList">schema:BreadcrumbList</a>
    /// </summary>
    let BreadcrumbList = _prefixId.prefix "BreadcrumbList"
    /// <summary>
    ///   <para>rdfs:label : Brewery^^xsd:string</para>
    ///   <para>rdfs:comment : Brewery.^^xsd:string</para>
    ///   <a href="http://schema.org/Brewery">schema:Brewery</a>
    /// </summary>
    let Brewery = _prefixId.prefix "Brewery"
    /// <summary>
    ///   <para>rdfs:comment : A bridge.^^xsd:string</para>
    ///   <para>rdfs:label : Bridge^^xsd:string</para>
    ///   <a href="http://schema.org/Bridge">schema:Bridge</a>
    /// </summary>
    let Bridge = _prefixId.prefix "Bridge"
    /// <summary>
    ///   <para>rdfs:comment : A unique instance of a BroadcastService on a CableOrSatelliteService lineup.^^xsd:string</para>
    ///   <para>rdfs:label : BroadcastChannel^^xsd:string</para>
    ///   <a href="http://schema.org/BroadcastChannel">schema:BroadcastChannel</a>
    /// </summary>
    let BroadcastChannel = _prefixId.prefix "BroadcastChannel"
    /// <summary>
    ///   <para>rdfs:comment : An over the air or online broadcast event.^^xsd:string</para>
    ///   <para>rdfs:label : BroadcastEvent^^xsd:string</para>
    ///   <a href="http://schema.org/BroadcastEvent">schema:BroadcastEvent</a>
    /// </summary>
    let BroadcastEvent = _prefixId.prefix "BroadcastEvent"

    /// <summary>
    ///   <para>rdfs:comment : The frequency in MHz and the modulation used for a particular BroadcastService.^^xsd:string</para>
    ///   <para>rdfs:label : BroadcastFrequencySpecification^^xsd:string</para>
    ///   <para>schema:category : issue-1004^^xsd:string</para>
    ///   <a href="http://schema.org/BroadcastFrequencySpecification">schema:BroadcastFrequencySpecification</a>
    /// </summary>
    let BroadcastFrequencySpecification =
        _prefixId.prefix "BroadcastFrequencySpecification"

    let BroadcastRelease = _prefixId.prefix "BroadcastRelease"
    /// <summary>
    ///   <para>rdfs:label : BroadcastService^^xsd:string</para>
    ///   <para>rdfs:comment : A delivery service through which content is provided via broadcast over the air or online.^^xsd:string</para>
    ///   <a href="http://schema.org/BroadcastService">schema:BroadcastService</a>
    /// </summary>
    let BroadcastService = _prefixId.prefix "BroadcastService"
    /// <summary>
    ///   <para>rdfs:comment : A Buddhist temple.^^xsd:string</para>
    ///   <para>rdfs:label : BuddhistTemple^^xsd:string</para>
    ///   <a href="http://schema.org/BuddhistTemple">schema:BuddhistTemple</a>
    /// </summary>
    let BuddhistTemple = _prefixId.prefix "BuddhistTemple"
    /// <summary>
    ///   <para>rdfs:comment : A reservation for bus travel. &lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : BusReservation^^xsd:string</para>
    ///   <a href="http://schema.org/BusReservation">schema:BusReservation</a>
    /// </summary>
    let BusReservation = _prefixId.prefix "BusReservation"
    /// <summary>
    ///   <para>rdfs:label : BusStation^^xsd:string</para>
    ///   <para>rdfs:comment : A bus station.^^xsd:string</para>
    ///   <a href="http://schema.org/BusStation">schema:BusStation</a>
    /// </summary>
    let BusStation = _prefixId.prefix "BusStation"
    /// <summary>
    ///   <para>rdfs:comment : A bus stop.^^xsd:string</para>
    ///   <para>rdfs:label : BusStop^^xsd:string</para>
    ///   <a href="http://schema.org/BusStop">schema:BusStop</a>
    /// </summary>
    let BusStop = _prefixId.prefix "BusStop"
    /// <summary>
    ///   <para>rdfs:comment : A trip on a commercial bus line.^^xsd:string</para>
    ///   <para>rdfs:label : BusTrip^^xsd:string</para>
    ///   <a href="http://schema.org/BusTrip">schema:BusTrip</a>
    /// </summary>
    let BusTrip = _prefixId.prefix "BusTrip"
    /// <summary>
    ///   <para>rdfs:label : BusinessAudience^^xsd:string</para>
    ///   <para>rdfs:comment : A set of characteristics belonging to businesses, e.g. who compose an item's target audience.^^xsd:string</para>
    ///   <a href="http://schema.org/BusinessAudience">schema:BusinessAudience</a>
    /// </summary>
    let BusinessAudience = _prefixId.prefix "BusinessAudience"
    /// <summary>
    ///   <para>rdfs:comment : A business entity type is a conceptual entity representing the legal form, the size, the main line of business, the position in the value chain, or any combination thereof, of an organization or business person.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Business&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Enduser&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PublicInstitution&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Reseller&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : BusinessEntityType^^xsd:string</para>
    ///   <a href="http://schema.org/BusinessEntityType">schema:BusinessEntityType</a>
    /// </summary>
    let BusinessEntityType = _prefixId.prefix "BusinessEntityType"
    /// <summary>
    ///   <para>rdfs:comment : Event type: Business event.^^xsd:string</para>
    ///   <para>rdfs:label : BusinessEvent^^xsd:string</para>
    ///   <a href="http://schema.org/BusinessEvent">schema:BusinessEvent</a>
    /// </summary>
    let BusinessEvent = _prefixId.prefix "BusinessEvent"
    /// <summary>
    ///   <para>rdfs:comment : The business function specifies the type of activity or access (i.e., the bundle of rights) offered by the organization or business person through the offer. Typical are sell, rental or lease, maintenance or repair, manufacture / produce, recycle / dispose, engineering / construction, or installation. Proprietary specifications of access rights are also instances of this class.&lt;br/&gt;&lt;br/&gt;
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
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : BusinessFunction^^xsd:string</para>
    ///   <a href="http://schema.org/BusinessFunction">schema:BusinessFunction</a>
    /// </summary>
    let BusinessFunction = _prefixId.prefix "BusinessFunction"
    /// <summary>
    ///   <para>rdfs:comment : The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.^^xsd:string</para>
    ///   <para>rdfs:label : BuyAction^^xsd:string</para>
    ///   <a href="http://schema.org/BuyAction">schema:BuyAction</a>
    /// </summary>
    let BuyAction = _prefixId.prefix "BuyAction"
    let CDFormat = _prefixId.prefix "CDFormat"
    /// <summary>
    ///   <para>rdfs:comment : A service which provides access to media programming like TV or radio. Access may be via cable or satellite.^^xsd:string</para>
    ///   <para>rdfs:label : CableOrSatelliteService^^xsd:string</para>
    ///   <a href="http://schema.org/CableOrSatelliteService">schema:CableOrSatelliteService</a>
    /// </summary>
    let CableOrSatelliteService = _prefixId.prefix "CableOrSatelliteService"
    /// <summary>
    ///   <para>rdfs:comment : A cafe or coffee shop.^^xsd:string</para>
    ///   <para>rdfs:label : CafeOrCoffeeShop^^xsd:string</para>
    ///   <a href="http://schema.org/CafeOrCoffeeShop">schema:CafeOrCoffeeShop</a>
    /// </summary>
    let CafeOrCoffeeShop = _prefixId.prefix "CafeOrCoffeeShop"
    /// <summary>
    ///   <para>rdfs:label : Campground^^xsd:string</para>
    ///   <para>rdfs:comment : A camping site, campsite, or &lt;a class="localLink" href="http://schema.org/Campground"&gt;Campground&lt;/a&gt; is a place used for overnight stay in the outdoors, typically containing individual &lt;a class="localLink" href="http://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; locations. &lt;br/&gt;&lt;br/&gt;
    ///
    /// In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/Campground">schema:Campground</a>
    /// </summary>
    let Campground = _prefixId.prefix "Campground"
    /// <summary>
    ///   <para>rdfs:label : CampingPitch^^xsd:string</para>
    ///   <para>rdfs:comment : A &lt;a class="localLink" href="http://schema.org/CampingPitch"&gt;CampingPitch&lt;/a&gt; is an individual place for overnight stay in the outdoors, typically being part of a larger camping site, or &lt;a class="localLink" href="http://schema.org/Campground"&gt;Campground&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// In British English a campsite, or campground, is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites.
    /// (Source: Wikipedia see &lt;a href="https://en.wikipedia.org/wiki/Campsite"&gt;https://en.wikipedia.org/wiki/Campsite&lt;/a&gt;).&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also the dedicated &lt;a href="/docs/hotels.html"&gt;document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/CampingPitch">schema:CampingPitch</a>
    /// </summary>
    let CampingPitch = _prefixId.prefix "CampingPitch"
    /// <summary>
    ///   <para>rdfs:comment : A canal, like the Panama Canal.^^xsd:string</para>
    ///   <para>rdfs:label : Canal^^xsd:string</para>
    ///   <a href="http://schema.org/Canal">schema:Canal</a>
    /// </summary>
    let Canal = _prefixId.prefix "Canal"
    /// <summary>
    ///   <para>rdfs:comment : The act of asserting that a future event/action is no longer going to happen.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: The antonym of CancelAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : CancelAction^^xsd:string</para>
    ///   <a href="http://schema.org/CancelAction">schema:CancelAction</a>
    /// </summary>
    let CancelAction = _prefixId.prefix "CancelAction"
    /// <summary>
    ///   <para>rdfs:label : Car^^xsd:string</para>
    ///   <para>rdfs:comment : A car is a wheeled, self-powered motor vehicle used for transportation.^^xsd:string</para>
    ///   <a href="http://schema.org/Car">schema:Car</a>
    /// </summary>
    let Car = _prefixId.prefix "Car"
    /// <summary>
    ///   <para>rdfs:comment : A casino.^^xsd:string</para>
    ///   <para>rdfs:label : Casino^^xsd:string</para>
    ///   <a href="http://schema.org/Casino">schema:Casino</a>
    /// </summary>
    let Casino = _prefixId.prefix "Casino"
    let CassetteFormat = _prefixId.prefix "CassetteFormat"
    /// <summary>
    ///   <para>rdfs:label : CatholicChurch^^xsd:string</para>
    ///   <para>rdfs:comment : A Catholic church.^^xsd:string</para>
    ///   <a href="http://schema.org/CatholicChurch">schema:CatholicChurch</a>
    /// </summary>
    let CatholicChurch = _prefixId.prefix "CatholicChurch"
    /// <summary>
    ///   <para>rdfs:label : Cemetery^^xsd:string</para>
    ///   <para>rdfs:comment : A graveyard.^^xsd:string</para>
    ///   <a href="http://schema.org/Cemetery">schema:Cemetery</a>
    /// </summary>
    let Cemetery = _prefixId.prefix "Cemetery"
    let Chapter = _prefixId.prefix "Chapter"
    /// <summary>
    ///   <para>rdfs:comment : An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.^^xsd:string</para>
    ///   <para>rdfs:label : CheckAction^^xsd:string</para>
    ///   <a href="http://schema.org/CheckAction">schema:CheckAction</a>
    /// </summary>
    let CheckAction = _prefixId.prefix "CheckAction"
    /// <summary>
    ///   <para>rdfs:label : CheckInAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of an agent communicating (service provider, social media, etc) their arrival by registering/confirming for a previously reserved service (e.g. flight check in) or at a place (e.g. hotel), possibly resulting in a result (boarding pass, etc).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CheckOutAction"&gt;CheckOutAction&lt;/a&gt;: The antonym of CheckInAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ArriveAction"&gt;ArriveAction&lt;/a&gt;: Unlike ArriveAction, CheckInAction implies that the agent is informing/confirming the start of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ConfirmAction"&gt;ConfirmAction&lt;/a&gt;: Unlike ConfirmAction, CheckInAction implies that the agent is informing/confirming the &lt;em&gt;start&lt;/em&gt; of a previously reserved service rather than its validity/existence.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/CheckInAction">schema:CheckInAction</a>
    /// </summary>
    let CheckInAction = _prefixId.prefix "CheckInAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of an agent communicating (service provider, social media, etc) their departure of a previously reserved service (e.g. flight check in) or place (e.g. hotel).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CheckInAction"&gt;CheckInAction&lt;/a&gt;: The antonym of CheckOutAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/DepartAction"&gt;DepartAction&lt;/a&gt;: Unlike DepartAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: Unlike CancelAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : CheckOutAction^^xsd:string</para>
    ///   <a href="http://schema.org/CheckOutAction">schema:CheckOutAction</a>
    /// </summary>
    let CheckOutAction = _prefixId.prefix "CheckOutAction"
    /// <summary>
    ///   <para>rdfs:comment : Web page type: Checkout page.^^xsd:string</para>
    ///   <para>rdfs:label : CheckoutPage^^xsd:string</para>
    ///   <a href="http://schema.org/CheckoutPage">schema:CheckoutPage</a>
    /// </summary>
    let CheckoutPage = _prefixId.prefix "CheckoutPage"
    /// <summary>
    ///   <para>rdfs:comment : A Childcare center.^^xsd:string</para>
    ///   <para>rdfs:label : ChildCare^^xsd:string</para>
    ///   <a href="http://schema.org/ChildCare">schema:ChildCare</a>
    /// </summary>
    let ChildCare = _prefixId.prefix "ChildCare"
    /// <summary>
    ///   <para>rdfs:label : ChildrensEvent^^xsd:string</para>
    ///   <para>rdfs:comment : Event type: Children's event.^^xsd:string</para>
    ///   <a href="http://schema.org/ChildrensEvent">schema:ChildrensEvent</a>
    /// </summary>
    let ChildrensEvent = _prefixId.prefix "ChildrensEvent"
    /// <summary>
    ///   <para>rdfs:label : ChooseAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of expressing a preference from a set of options or a large or unbounded set of choices/options.^^xsd:string</para>
    ///   <a href="http://schema.org/ChooseAction">schema:ChooseAction</a>
    /// </summary>
    let ChooseAction = _prefixId.prefix "ChooseAction"
    /// <summary>
    ///   <para>rdfs:comment : A church.^^xsd:string</para>
    ///   <para>rdfs:label : Church^^xsd:string</para>
    ///   <a href="http://schema.org/Church">schema:Church</a>
    /// </summary>
    let Church = _prefixId.prefix "Church"
    /// <summary>
    ///   <para>rdfs:label : City^^xsd:string</para>
    ///   <para>rdfs:comment : A city or town.^^xsd:string</para>
    ///   <a href="http://schema.org/City">schema:City</a>
    /// </summary>
    let City = _prefixId.prefix "City"
    /// <summary>
    ///   <para>rdfs:label : CityHall^^xsd:string</para>
    ///   <para>rdfs:comment : A city hall.^^xsd:string</para>
    ///   <a href="http://schema.org/CityHall">schema:CityHall</a>
    /// </summary>
    let CityHall = _prefixId.prefix "CityHall"
    /// <summary>
    ///   <para>rdfs:comment : A public structure, such as a town hall or concert hall.^^xsd:string</para>
    ///   <para>rdfs:label : CivicStructure^^xsd:string</para>
    ///   <a href="http://schema.org/CivicStructure">schema:CivicStructure</a>
    /// </summary>
    let CivicStructure = _prefixId.prefix "CivicStructure"
    /// <summary>
    ///   <para>rdfs:label : ClaimReview^^xsd:string</para>
    ///   <para>rdfs:comment : A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).^^xsd:string</para>
    ///   <para>schema:category : issue-1061^^xsd:string</para>
    ///   <a href="http://schema.org/ClaimReview">schema:ClaimReview</a>
    /// </summary>
    let ClaimReview = _prefixId.prefix "ClaimReview"
    /// <summary>
    ///   <para>rdfs:comment : A short TV or radio program or a segment/part of a program.^^xsd:string</para>
    ///   <para>rdfs:label : Clip^^xsd:string</para>
    ///   <a href="http://schema.org/Clip">schema:Clip</a>
    /// </summary>
    let Clip = _prefixId.prefix "Clip"
    /// <summary>
    ///   <para>rdfs:comment : A clothing store.^^xsd:string</para>
    ///   <para>rdfs:label : ClothingStore^^xsd:string</para>
    ///   <a href="http://schema.org/ClothingStore">schema:ClothingStore</a>
    /// </summary>
    let ClothingStore = _prefixId.prefix "ClothingStore"
    let CoOp = _prefixId.prefix "CoOp"
    /// <summary>
    ///   <para>rdfs:label : Code^^xsd:string</para>
    ///   <para>rdfs:comment : Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.^^xsd:string</para>
    ///   <a href="http://schema.org/Code">schema:Code</a>
    /// </summary>
    let Code = _prefixId.prefix "Code"
    /// <summary>
    ///   <para>rdfs:comment : Web page type: Collection page.^^xsd:string</para>
    ///   <para>rdfs:label : CollectionPage^^xsd:string</para>
    ///   <a href="http://schema.org/CollectionPage">schema:CollectionPage</a>
    /// </summary>
    let CollectionPage = _prefixId.prefix "CollectionPage"
    /// <summary>
    ///   <para>rdfs:label : CollegeOrUniversity^^xsd:string</para>
    ///   <para>rdfs:comment : A college, university, or other third-level educational institution.^^xsd:string</para>
    ///   <a href="http://schema.org/CollegeOrUniversity">schema:CollegeOrUniversity</a>
    /// </summary>
    let CollegeOrUniversity = _prefixId.prefix "CollegeOrUniversity"
    /// <summary>
    ///   <para>rdfs:label : ComedyClub^^xsd:string</para>
    ///   <para>rdfs:comment : A comedy club.^^xsd:string</para>
    ///   <a href="http://schema.org/ComedyClub">schema:ComedyClub</a>
    /// </summary>
    let ComedyClub = _prefixId.prefix "ComedyClub"
    /// <summary>
    ///   <para>rdfs:comment : Event type: Comedy event.^^xsd:string</para>
    ///   <para>rdfs:label : ComedyEvent^^xsd:string</para>
    ///   <a href="http://schema.org/ComedyEvent">schema:ComedyEvent</a>
    /// </summary>
    let ComedyEvent = _prefixId.prefix "ComedyEvent"
    /// <summary>
    ///   <para>rdfs:comment : A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the &lt;a class="localLink" href="http://schema.org/text"&gt;text&lt;/a&gt; property, and its topic via &lt;a class="localLink" href="http://schema.org/about"&gt;about&lt;/a&gt;, properties shared with all CreativeWorks.^^xsd:string</para>
    ///   <para>rdfs:label : Comment^^xsd:string</para>
    ///   <a href="http://schema.org/Comment">schema:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    /// <summary>
    ///   <para>rdfs:label : CommentAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of generating a comment about a subject.^^xsd:string</para>
    ///   <a href="http://schema.org/CommentAction">schema:CommentAction</a>
    /// </summary>
    let CommentAction = _prefixId.prefix "CommentAction"
    let CommentPermission = _prefixId.prefix "CommentPermission"
    /// <summary>
    ///   <para>rdfs:comment : The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.^^xsd:string</para>
    ///   <para>rdfs:label : CommunicateAction^^xsd:string</para>
    ///   <a href="http://schema.org/CommunicateAction">schema:CommunicateAction</a>
    /// </summary>
    let CommunicateAction = _prefixId.prefix "CommunicateAction"
    let CompilationAlbum = _prefixId.prefix "CompilationAlbum"
    let CompletedActionStatus = _prefixId.prefix "CompletedActionStatus"
    /// <summary>
    ///   <para>rdfs:label : CompoundPriceSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use the name property of the attached unit price specification for indicating the dimension of a price component (e.g. "electricity" or "final cleaning").^^xsd:string</para>
    ///   <a href="http://schema.org/CompoundPriceSpecification">schema:CompoundPriceSpecification</a>
    /// </summary>
    let CompoundPriceSpecification = _prefixId.prefix "CompoundPriceSpecification"
    /// <summary>
    ///   <para>rdfs:comment : This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the &lt;a class="localLink" href="http://schema.org/Language"&gt;Language&lt;/a&gt; type.^^xsd:string</para>
    ///   <para>rdfs:label : ComputerLanguage^^xsd:string</para>
    ///   <a href="http://schema.org/ComputerLanguage">schema:ComputerLanguage</a>
    /// </summary>
    let ComputerLanguage = _prefixId.prefix "ComputerLanguage"
    /// <summary>
    ///   <para>rdfs:label : ComputerStore^^xsd:string</para>
    ///   <para>rdfs:comment : A computer store.^^xsd:string</para>
    ///   <a href="http://schema.org/ComputerStore">schema:ComputerStore</a>
    /// </summary>
    let ComputerStore = _prefixId.prefix "ComputerStore"
    /// <summary>
    ///   <para>rdfs:comment : The act of notifying someone that a future event/action is going to happen as expected.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/CancelAction"&gt;CancelAction&lt;/a&gt;: The antonym of ConfirmAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : ConfirmAction^^xsd:string</para>
    ///   <a href="http://schema.org/ConfirmAction">schema:ConfirmAction</a>
    /// </summary>
    let ConfirmAction = _prefixId.prefix "ConfirmAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of ingesting information/resources/food.^^xsd:string</para>
    ///   <para>rdfs:label : ConsumeAction^^xsd:string</para>
    ///   <a href="http://schema.org/ConsumeAction">schema:ConsumeAction</a>
    /// </summary>
    let ConsumeAction = _prefixId.prefix "ConsumeAction"
    /// <summary>
    ///   <para>rdfs:label : ContactPage^^xsd:string</para>
    ///   <para>rdfs:comment : Web page type: Contact page.^^xsd:string</para>
    ///   <a href="http://schema.org/ContactPage">schema:ContactPage</a>
    /// </summary>
    let ContactPage = _prefixId.prefix "ContactPage"
    /// <summary>
    ///   <para>rdfs:label : ContactPoint^^xsd:string</para>
    ///   <para>rdfs:comment : A contact point&amp;#x2014;for example, a Customer Complaints department.^^xsd:string</para>
    ///   <a href="http://schema.org/ContactPoint">schema:ContactPoint</a>
    /// </summary>
    let ContactPoint = _prefixId.prefix "ContactPoint"
    /// <summary>
    ///   <para>rdfs:comment : Enumerated options related to a ContactPoint.^^xsd:string</para>
    ///   <para>rdfs:label : ContactPointOption^^xsd:string</para>
    ///   <a href="http://schema.org/ContactPointOption">schema:ContactPointOption</a>
    /// </summary>
    let ContactPointOption = _prefixId.prefix "ContactPointOption"
    /// <summary>
    ///   <para>rdfs:label : Continent^^xsd:string</para>
    ///   <para>rdfs:comment : One of the continents (for example, Europe or Africa).^^xsd:string</para>
    ///   <a href="http://schema.org/Continent">schema:Continent</a>
    /// </summary>
    let Continent = _prefixId.prefix "Continent"
    /// <summary>
    ///   <para>rdfs:label : ControlAction^^xsd:string</para>
    ///   <para>rdfs:comment : An agent controls a device or application.^^xsd:string</para>
    ///   <a href="http://schema.org/ControlAction">schema:ControlAction</a>
    /// </summary>
    let ControlAction = _prefixId.prefix "ControlAction"
    /// <summary>
    ///   <para>rdfs:comment : A convenience store.^^xsd:string</para>
    ///   <para>rdfs:label : ConvenienceStore^^xsd:string</para>
    ///   <a href="http://schema.org/ConvenienceStore">schema:ConvenienceStore</a>
    /// </summary>
    let ConvenienceStore = _prefixId.prefix "ConvenienceStore"
    /// <summary>
    ///   <para>rdfs:label : Conversation^^xsd:string</para>
    ///   <para>rdfs:comment : One or more messages between organizations or people on a particular topic. Individual messages can be linked to the conversation with isPartOf or hasPart properties.^^xsd:string</para>
    ///   <a href="http://schema.org/Conversation">schema:Conversation</a>
    /// </summary>
    let Conversation = _prefixId.prefix "Conversation"
    /// <summary>
    ///   <para>rdfs:label : CookAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of producing/preparing food.^^xsd:string</para>
    ///   <a href="http://schema.org/CookAction">schema:CookAction</a>
    /// </summary>
    let CookAction = _prefixId.prefix "CookAction"
    /// <summary>
    ///   <para>rdfs:comment : Organization: A business corporation.^^xsd:string</para>
    ///   <para>rdfs:label : Corporation^^xsd:string</para>
    ///   <a href="http://schema.org/Corporation">schema:Corporation</a>
    /// </summary>
    let Corporation = _prefixId.prefix "Corporation"
    /// <summary>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <para>rdfs:comment : A country.^^xsd:string</para>
    ///   <a href="http://schema.org/Country">schema:Country</a>
    /// </summary>
    let Country = _prefixId.prefix "Country"
    /// <summary>
    ///   <para>rdfs:comment : A description of an educational course which may be offered as distinct instances at which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.^^xsd:string</para>
    ///   <para>rdfs:label : Course^^xsd:string</para>
    ///   <a href="http://schema.org/Course">schema:Course</a>
    /// </summary>
    let Course = _prefixId.prefix "Course"
    /// <summary>
    ///   <para>rdfs:comment : An instance of a &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.^^xsd:string</para>
    ///   <para>rdfs:label : CourseInstance^^xsd:string</para>
    ///   <a href="http://schema.org/CourseInstance">schema:CourseInstance</a>
    /// </summary>
    let CourseInstance = _prefixId.prefix "CourseInstance"
    /// <summary>
    ///   <para>rdfs:label : Courthouse^^xsd:string</para>
    ///   <para>rdfs:comment : A courthouse.^^xsd:string</para>
    ///   <a href="http://schema.org/Courthouse">schema:Courthouse</a>
    /// </summary>
    let Courthouse = _prefixId.prefix "Courthouse"
    /// <summary>
    ///   <para>rdfs:label : CreateAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of deliberately creating/producing/generating/building a result out of the agent.^^xsd:string</para>
    ///   <a href="http://schema.org/CreateAction">schema:CreateAction</a>
    /// </summary>
    let CreateAction = _prefixId.prefix "CreateAction"
    /// <summary>
    ///   <para>rdfs:comment : The most generic kind of creative work, including books, movies, photographs, software programs, etc.^^xsd:string</para>
    ///   <para>rdfs:label : CreativeWork^^xsd:string</para>
    ///   <a href="http://schema.org/CreativeWork">schema:CreativeWork</a>
    /// </summary>
    let CreativeWork = _prefixId.prefix "CreativeWork"
    /// <summary>
    ///   <para>rdfs:comment : A media season e.g. tv, radio, video game etc.^^xsd:string</para>
    ///   <para>rdfs:label : CreativeWorkSeason^^xsd:string</para>
    ///   <a href="http://schema.org/CreativeWorkSeason">schema:CreativeWorkSeason</a>
    /// </summary>
    let CreativeWorkSeason = _prefixId.prefix "CreativeWorkSeason"
    /// <summary>
    ///   <para>rdfs:comment : A CreativeWorkSeries in schema.org is a group of related items, typically but not necessarily of the same kind. CreativeWorkSeries are usually organized into some order, often chronological. Unlike &lt;a class="localLink" href="http://schema.org/ItemList"&gt;ItemList&lt;/a&gt; which is a general purpose data structure for lists of things, the emphasis with CreativeWorkSeries is on published materials (written e.g. books and periodicals, or media such as tv, radio and games).&lt;br/&gt;&lt;br/&gt;
    ///
    /// Specific subtypes are available for describing &lt;a class="localLink" href="http://schema.org/TVSeries"&gt;TVSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RadioSeries"&gt;RadioSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/MovieSeries"&gt;MovieSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/BookSeries"&gt;BookSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Periodical"&gt;Periodical&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/VideoGameSeries"&gt;VideoGameSeries&lt;/a&gt;. In each case, the &lt;a class="localLink" href="http://schema.org/hasPart"&gt;hasPart&lt;/a&gt; / &lt;a class="localLink" href="http://schema.org/isPartOf"&gt;isPartOf&lt;/a&gt; properties can be used to relate the CreativeWorkSeries to its parts. The general CreativeWorkSeries type serves largely just to organize these more specific and practical subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// It is common for properties applicable to an item from the series to be usefully applied to the containing group. Schema.org attempts to anticipate some of these cases, but publishers should be free to apply properties of the series parts to the series as a whole wherever they seem appropriate.^^xsd:string</para>
    ///   <para>rdfs:label : CreativeWorkSeries^^xsd:string</para>
    ///   <a href="http://schema.org/CreativeWorkSeries">schema:CreativeWorkSeries</a>
    /// </summary>
    let CreativeWorkSeries = _prefixId.prefix "CreativeWorkSeries"
    /// <summary>
    ///   <para>rdfs:label : CreditCard^^xsd:string</para>
    ///   <para>rdfs:comment : A card payment method of a particular brand or name.  Used to mark up a particular payment method and/or the financial product/service that supplies the card account.&lt;br/&gt;&lt;br/&gt;
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
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/CreditCard">schema:CreditCard</a>
    /// </summary>
    let CreditCard = _prefixId.prefix "CreditCard"
    /// <summary>
    ///   <para>rdfs:comment : A crematorium.^^xsd:string</para>
    ///   <para>rdfs:label : Crematorium^^xsd:string</para>
    ///   <a href="http://schema.org/Crematorium">schema:Crematorium</a>
    /// </summary>
    let Crematorium = _prefixId.prefix "Crematorium"
    let CssSelectorType = _prefixId.prefix "CssSelectorType"
    /// <summary>
    ///   <para>rdfs:comment : A service to convert funds from one currency to another currency.^^xsd:string</para>
    ///   <para>rdfs:label : CurrencyConversionService^^xsd:string</para>
    ///   <a href="http://schema.org/CurrencyConversionService">schema:CurrencyConversionService</a>
    /// </summary>
    let CurrencyConversionService = _prefixId.prefix "CurrencyConversionService"
    let DJMixAlbum = _prefixId.prefix "DJMixAlbum"
    let DVDFormat = _prefixId.prefix "DVDFormat"
    let DamagedCondition = _prefixId.prefix "DamagedCondition"
    /// <summary>
    ///   <para>rdfs:comment : Event type: A social dance.^^xsd:string</para>
    ///   <para>rdfs:label : DanceEvent^^xsd:string</para>
    ///   <a href="http://schema.org/DanceEvent">schema:DanceEvent</a>
    /// </summary>
    let DanceEvent = _prefixId.prefix "DanceEvent"
    /// <summary>
    ///   <para>rdfs:label : DanceGroup^^xsd:string</para>
    ///   <para>rdfs:comment : A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.^^xsd:string</para>
    ///   <a href="http://schema.org/DanceGroup">schema:DanceGroup</a>
    /// </summary>
    let DanceGroup = _prefixId.prefix "DanceGroup"
    /// <summary>
    ///   <para>rdfs:label : DataCatalog^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of datasets.^^xsd:string</para>
    ///   <a href="http://schema.org/DataCatalog">schema:DataCatalog</a>
    /// </summary>
    let DataCatalog = _prefixId.prefix "DataCatalog"
    /// <summary>
    ///   <para>rdfs:comment : A dataset in downloadable form.^^xsd:string</para>
    ///   <para>rdfs:label : DataDownload^^xsd:string</para>
    ///   <a href="http://schema.org/DataDownload">schema:DataDownload</a>
    /// </summary>
    let DataDownload = _prefixId.prefix "DataDownload"
    /// <summary>
    ///   <para>rdfs:label : DataFeed^^xsd:string</para>
    ///   <para>rdfs:comment : A single feed providing structured information about one or more entities or topics.^^xsd:string</para>
    ///   <a href="http://schema.org/DataFeed">schema:DataFeed</a>
    /// </summary>
    let DataFeed = _prefixId.prefix "DataFeed"
    /// <summary>
    ///   <para>rdfs:comment : A single item within a larger data feed.^^xsd:string</para>
    ///   <para>rdfs:label : DataFeedItem^^xsd:string</para>
    ///   <a href="http://schema.org/DataFeedItem">schema:DataFeedItem</a>
    /// </summary>
    let DataFeedItem = _prefixId.prefix "DataFeedItem"
    /// <summary>
    ///   <para>rdfs:label : DataType^^xsd:string</para>
    ///   <para>rdfs:comment : The basic data types such as Integers, Strings, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/DataType">schema:DataType</a>
    /// </summary>
    let DataType = _prefixId.prefix "DataType"
    /// <summary>
    ///   <para>rdfs:comment : A body of structured information describing some topic(s) of interest.^^xsd:string</para>
    ///   <para>rdfs:label : Dataset^^xsd:string</para>
    ///   <a href="http://schema.org/Dataset">schema:Dataset</a>
    /// </summary>
    let Dataset = _prefixId.prefix "Dataset"
    /// <summary>
    ///   <para>rdfs:comment : A date value in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Date^^xsd:string</para>
    ///   <a href="http://schema.org/Date">schema:Date</a>
    /// </summary>
    let Date = _prefixId.prefix "Date"
    /// <summary>
    ///   <para>rdfs:comment : A combination of date and time of day in the form [-]CCYY-MM-DDThh:mm:ss[Z|(+|-)hh:mm] (see Chapter 5.4 of ISO 8601).^^xsd:string</para>
    ///   <para>rdfs:label : DateTime^^xsd:string</para>
    ///   <a href="http://schema.org/DateTime">schema:DateTime</a>
    /// </summary>
    let DateTime = _prefixId.prefix "DateTime"
    /// <summary>
    ///   <para>rdfs:label : DatedMoneySpecification^^xsd:string</para>
    ///   <para>rdfs:comment : A DatedMoneySpecification represents monetary values with optional start and end dates. For example, this could represent an employee's salary over a specific period of time. &lt;strong&gt;Note:&lt;/strong&gt; This type has been superseded by &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; use of that type is recommended^^xsd:string</para>
    ///   <a href="http://schema.org/DatedMoneySpecification">schema:DatedMoneySpecification</a>
    /// </summary>
    let DatedMoneySpecification = _prefixId.prefix "DatedMoneySpecification"
    /// <summary>
    ///   <para>rdfs:label : DayOfWeek^^xsd:string</para>
    ///   <para>rdfs:comment : The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Originally, URLs from &lt;a href="http://purl.org/goodrelations/v1"&gt;GoodRelations&lt;/a&gt; were used (for &lt;a class="localLink" href="http://schema.org/Monday"&gt;Monday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Tuesday"&gt;Tuesday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Wednesday"&gt;Wednesday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Thursday"&gt;Thursday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Friday"&gt;Friday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Saturday"&gt;Saturday&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Sunday"&gt;Sunday&lt;/a&gt; plus a special entry for &lt;a class="localLink" href="http://schema.org/PublicHolidays"&gt;PublicHolidays&lt;/a&gt;); these have now been integrated directly into schema.org.^^xsd:string</para>
    ///   <a href="http://schema.org/DayOfWeek">schema:DayOfWeek</a>
    /// </summary>
    let DayOfWeek = _prefixId.prefix "DayOfWeek"
    /// <summary>
    ///   <para>rdfs:label : DaySpa^^xsd:string</para>
    ///   <para>rdfs:comment : A day spa.^^xsd:string</para>
    ///   <a href="http://schema.org/DaySpa">schema:DaySpa</a>
    /// </summary>
    let DaySpa = _prefixId.prefix "DaySpa"
    /// <summary>
    ///   <para>rdfs:label : DeactivateAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).^^xsd:string</para>
    ///   <a href="http://schema.org/DeactivateAction">schema:DeactivateAction</a>
    /// </summary>
    let DeactivateAction = _prefixId.prefix "DeactivateAction"
    /// <summary>
    ///   <para>rdfs:comment : A defence establishment, such as an army or navy base.^^xsd:string</para>
    ///   <para>rdfs:label : DefenceEstablishment^^xsd:string</para>
    ///   <a href="http://schema.org/DefenceEstablishment">schema:DefenceEstablishment</a>
    /// </summary>
    let DefenceEstablishment = _prefixId.prefix "DefenceEstablishment"
    let DefinedTerm = _prefixId.prefix "DefinedTerm"
    /// <summary>
    ///   <para>rdfs:comment : The act of editing a recipient by removing one of its objects.^^xsd:string</para>
    ///   <para>rdfs:label : DeleteAction^^xsd:string</para>
    ///   <a href="http://schema.org/DeleteAction">schema:DeleteAction</a>
    /// </summary>
    let DeleteAction = _prefixId.prefix "DeleteAction"
    /// <summary>
    ///   <para>rdfs:comment : The price for the delivery of an offer using a particular delivery method.^^xsd:string</para>
    ///   <para>rdfs:label : DeliveryChargeSpecification^^xsd:string</para>
    ///   <a href="http://schema.org/DeliveryChargeSpecification">schema:DeliveryChargeSpecification</a>
    /// </summary>
    let DeliveryChargeSpecification = _prefixId.prefix "DeliveryChargeSpecification"
    /// <summary>
    ///   <para>rdfs:label : DeliveryEvent^^xsd:string</para>
    ///   <para>rdfs:comment : An event involving the delivery of an item.^^xsd:string</para>
    ///   <a href="http://schema.org/DeliveryEvent">schema:DeliveryEvent</a>
    /// </summary>
    let DeliveryEvent = _prefixId.prefix "DeliveryEvent"
    /// <summary>
    ///   <para>rdfs:label : DeliveryMethod^^xsd:string</para>
    ///   <para>rdfs:comment : A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment chosen by the customer. Delivery methods are characterized by the means of transportation used, and by the organization or group that is the contracting party for the sending organization or person.&lt;br/&gt;&lt;br/&gt;
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
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/DeliveryMethod">schema:DeliveryMethod</a>
    /// </summary>
    let DeliveryMethod = _prefixId.prefix "DeliveryMethod"
    /// <summary>
    ///   <para>rdfs:comment : A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.^^xsd:string</para>
    ///   <para>rdfs:label : Demand^^xsd:string</para>
    ///   <a href="http://schema.org/Demand">schema:Demand</a>
    /// </summary>
    let Demand = _prefixId.prefix "Demand"
    let DemoAlbum = _prefixId.prefix "DemoAlbum"
    /// <summary>
    ///   <para>rdfs:comment : A dentist.^^xsd:string</para>
    ///   <para>rdfs:label : Dentist^^xsd:string</para>
    ///   <a href="http://schema.org/Dentist">schema:Dentist</a>
    /// </summary>
    let Dentist = _prefixId.prefix "Dentist"
    /// <summary>
    ///   <para>rdfs:comment : The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.^^xsd:string</para>
    ///   <para>rdfs:label : DepartAction^^xsd:string</para>
    ///   <a href="http://schema.org/DepartAction">schema:DepartAction</a>
    /// </summary>
    let DepartAction = _prefixId.prefix "DepartAction"
    /// <summary>
    ///   <para>rdfs:comment : A department store.^^xsd:string</para>
    ///   <para>rdfs:label : DepartmentStore^^xsd:string</para>
    ///   <a href="http://schema.org/DepartmentStore">schema:DepartmentStore</a>
    /// </summary>
    let DepartmentStore = _prefixId.prefix "DepartmentStore"
    /// <summary>
    ///   <para>rdfs:label : DepositAccount^^xsd:string</para>
    ///   <para>rdfs:comment : A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.^^xsd:string</para>
    ///   <a href="http://schema.org/DepositAccount">schema:DepositAccount</a>
    /// </summary>
    let DepositAccount = _prefixId.prefix "DepositAccount"
    let DiabeticDiet = _prefixId.prefix "DiabeticDiet"
    let DietarySupplement = _prefixId.prefix "DietarySupplement"
    let DigitalAudioTapeFormat = _prefixId.prefix "DigitalAudioTapeFormat"
    /// <summary>
    ///   <para>rdfs:label : DigitalDocument^^xsd:string</para>
    ///   <para>rdfs:comment : An electronic file or document.^^xsd:string</para>
    ///   <a href="http://schema.org/DigitalDocument">schema:DigitalDocument</a>
    /// </summary>
    let DigitalDocument = _prefixId.prefix "DigitalDocument"
    /// <summary>
    ///   <para>rdfs:comment : A permission for a particular person or group to access a particular file.^^xsd:string</para>
    ///   <para>rdfs:label : DigitalDocumentPermission^^xsd:string</para>
    ///   <a href="http://schema.org/DigitalDocumentPermission">schema:DigitalDocumentPermission</a>
    /// </summary>
    let DigitalDocumentPermission = _prefixId.prefix "DigitalDocumentPermission"
    /// <summary>
    ///   <para>rdfs:comment : A type of permission which can be granted for accessing a digital document.^^xsd:string</para>
    ///   <para>rdfs:label : DigitalDocumentPermissionType^^xsd:string</para>
    ///   <a href="http://schema.org/DigitalDocumentPermissionType">schema:DigitalDocumentPermissionType</a>
    /// </summary>
    let DigitalDocumentPermissionType = _prefixId.prefix "DigitalDocumentPermissionType"
    let DigitalFormat = _prefixId.prefix "DigitalFormat"
    /// <summary>
    ///   <para>rdfs:comment : The act of expressing a difference of opinion with the object. An agent disagrees to/about an object (a proposition, topic or theme) with participants.^^xsd:string</para>
    ///   <para>rdfs:label : DisagreeAction^^xsd:string</para>
    ///   <a href="http://schema.org/DisagreeAction">schema:DisagreeAction</a>
    /// </summary>
    let DisagreeAction = _prefixId.prefix "DisagreeAction"
    let Discontinued = _prefixId.prefix "Discontinued"
    /// <summary>
    ///   <para>rdfs:label : DiscoverAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of discovering/finding an object.^^xsd:string</para>
    ///   <a href="http://schema.org/DiscoverAction">schema:DiscoverAction</a>
    /// </summary>
    let DiscoverAction = _prefixId.prefix "DiscoverAction"
    /// <summary>
    ///   <para>rdfs:label : DiscussionForumPosting^^xsd:string</para>
    ///   <para>rdfs:comment : A posting to a discussion forum.^^xsd:string</para>
    ///   <a href="http://schema.org/DiscussionForumPosting">schema:DiscussionForumPosting</a>
    /// </summary>
    let DiscussionForumPosting = _prefixId.prefix "DiscussionForumPosting"
    /// <summary>
    ///   <para>rdfs:comment : The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.^^xsd:string</para>
    ///   <para>rdfs:label : DislikeAction^^xsd:string</para>
    ///   <a href="http://schema.org/DislikeAction">schema:DislikeAction</a>
    /// </summary>
    let DislikeAction = _prefixId.prefix "DislikeAction"
    /// <summary>
    ///   <para>rdfs:comment : Properties that take Distances as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Length unit of measure&amp;gt;'. E.g., '7 ft'.^^xsd:string</para>
    ///   <para>rdfs:label : Distance^^xsd:string</para>
    ///   <a href="http://schema.org/Distance">schema:Distance</a>
    /// </summary>
    let Distance = _prefixId.prefix "Distance"
    /// <summary>
    ///   <para>schema:category : issue-743^^xsd:string</para>
    ///   <para>rdfs:comment : A distillery.^^xsd:string</para>
    ///   <para>rdfs:label : Distillery^^xsd:string</para>
    ///   <a href="http://schema.org/Distillery">schema:Distillery</a>
    /// </summary>
    let Distillery = _prefixId.prefix "Distillery"
    /// <summary>
    ///   <para>rdfs:comment : The act of providing goods, services, or money without compensation, often for philanthropic reasons.^^xsd:string</para>
    ///   <para>rdfs:label : DonateAction^^xsd:string</para>
    ///   <a href="http://schema.org/DonateAction">schema:DonateAction</a>
    /// </summary>
    let DonateAction = _prefixId.prefix "DonateAction"
    /// <summary>
    ///   <para>rdfs:label : DownloadAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of downloading an object.^^xsd:string</para>
    ///   <a href="http://schema.org/DownloadAction">schema:DownloadAction</a>
    /// </summary>
    let DownloadAction = _prefixId.prefix "DownloadAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.^^xsd:string</para>
    ///   <para>rdfs:label : DrawAction^^xsd:string</para>
    ///   <a href="http://schema.org/DrawAction">schema:DrawAction</a>
    /// </summary>
    let DrawAction = _prefixId.prefix "DrawAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of swallowing liquids.^^xsd:string</para>
    ///   <para>rdfs:label : DrinkAction^^xsd:string</para>
    ///   <a href="http://schema.org/DrinkAction">schema:DrinkAction</a>
    /// </summary>
    let DrinkAction = _prefixId.prefix "DrinkAction"
    /// <summary>
    ///   <para>rdfs:label : DriveWheelConfigurationValue^^xsd:string</para>
    ///   <para>rdfs:comment : A value indicating which roadwheels will receive torque.^^xsd:string</para>
    ///   <a href="http://schema.org/DriveWheelConfigurationValue">schema:DriveWheelConfigurationValue</a>
    /// </summary>
    let DriveWheelConfigurationValue = _prefixId.prefix "DriveWheelConfigurationValue"
    let Drug = _prefixId.prefix "Drug"
    /// <summary>
    ///   <para>rdfs:label : DryCleaningOrLaundry^^xsd:string</para>
    ///   <para>rdfs:comment : A dry-cleaning business.^^xsd:string</para>
    ///   <a href="http://schema.org/DryCleaningOrLaundry">schema:DryCleaningOrLaundry</a>
    /// </summary>
    let DryCleaningOrLaundry = _prefixId.prefix "DryCleaningOrLaundry"
    /// <summary>
    ///   <para>rdfs:label : Duration^^xsd:string</para>
    ///   <para>rdfs:comment : Quantity: Duration (use &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;).^^xsd:string</para>
    ///   <a href="http://schema.org/Duration">schema:Duration</a>
    /// </summary>
    let Duration = _prefixId.prefix "Duration"
    let EBook = _prefixId.prefix "EBook"
    let EPRelease = _prefixId.prefix "EPRelease"
    /// <summary>
    ///   <para>rdfs:label : EatAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of swallowing solid objects.^^xsd:string</para>
    ///   <a href="http://schema.org/EatAction">schema:EatAction</a>
    /// </summary>
    let EatAction = _prefixId.prefix "EatAction"
    /// <summary>
    ///   <para>rdfs:comment : Event type: Education event.^^xsd:string</para>
    ///   <para>rdfs:label : EducationEvent^^xsd:string</para>
    ///   <a href="http://schema.org/EducationEvent">schema:EducationEvent</a>
    /// </summary>
    let EducationEvent = _prefixId.prefix "EducationEvent"
    /// <summary>
    ///   <para>rdfs:comment : An EducationalAudience.^^xsd:string</para>
    ///   <para>rdfs:label : EducationalAudience^^xsd:string</para>
    ///   <a href="http://schema.org/EducationalAudience">schema:EducationalAudience</a>
    /// </summary>
    let EducationalAudience = _prefixId.prefix "EducationalAudience"

    let EducationalOccupationalCredential =
        _prefixId.prefix "EducationalOccupationalCredential"

    let EducationalOccupationalProgram =
        _prefixId.prefix "EducationalOccupationalProgram"

    /// <summary>
    ///   <para>rdfs:label : EducationalOrganization^^xsd:string</para>
    ///   <para>rdfs:comment : An educational organization.^^xsd:string</para>
    ///   <a href="http://schema.org/EducationalOrganization">schema:EducationalOrganization</a>
    /// </summary>
    let EducationalOrganization = _prefixId.prefix "EducationalOrganization"
    /// <summary>
    ///   <para>rdfs:label : Electrician^^xsd:string</para>
    ///   <para>rdfs:comment : An electrician.^^xsd:string</para>
    ///   <a href="http://schema.org/Electrician">schema:Electrician</a>
    /// </summary>
    let Electrician = _prefixId.prefix "Electrician"
    /// <summary>
    ///   <para>rdfs:comment : An electronics store.^^xsd:string</para>
    ///   <para>rdfs:label : ElectronicsStore^^xsd:string</para>
    ///   <a href="http://schema.org/ElectronicsStore">schema:ElectronicsStore</a>
    /// </summary>
    let ElectronicsStore = _prefixId.prefix "ElectronicsStore"
    /// <summary>
    ///   <para>rdfs:label : ElementarySchool^^xsd:string</para>
    ///   <para>rdfs:comment : An elementary school.^^xsd:string</para>
    ///   <a href="http://schema.org/ElementarySchool">schema:ElementarySchool</a>
    /// </summary>
    let ElementarySchool = _prefixId.prefix "ElementarySchool"
    /// <summary>
    ///   <para>rdfs:comment : An email message.^^xsd:string</para>
    ///   <para>rdfs:label : EmailMessage^^xsd:string</para>
    ///   <a href="http://schema.org/EmailMessage">schema:EmailMessage</a>
    /// </summary>
    let EmailMessage = _prefixId.prefix "EmailMessage"
    /// <summary>
    ///   <para>rdfs:comment : An embassy.^^xsd:string</para>
    ///   <para>rdfs:label : Embassy^^xsd:string</para>
    ///   <a href="http://schema.org/Embassy">schema:Embassy</a>
    /// </summary>
    let Embassy = _prefixId.prefix "Embassy"
    /// <summary>
    ///   <para>rdfs:comment : An emergency service, such as a fire station or ER.^^xsd:string</para>
    ///   <para>rdfs:label : EmergencyService^^xsd:string</para>
    ///   <a href="http://schema.org/EmergencyService">schema:EmergencyService</a>
    /// </summary>
    let EmergencyService = _prefixId.prefix "EmergencyService"
    /// <summary>
    ///   <para>rdfs:comment : A subclass of OrganizationRole used to describe employee relationships.^^xsd:string</para>
    ///   <para>rdfs:label : EmployeeRole^^xsd:string</para>
    ///   <a href="http://schema.org/EmployeeRole">schema:EmployeeRole</a>
    /// </summary>
    let EmployeeRole = _prefixId.prefix "EmployeeRole"
    /// <summary>
    ///   <para>schema:category : issue-1689^^xsd:string</para>
    ///   <para>rdfs:label : EmployerAggregateRating^^xsd:string</para>
    ///   <para>rdfs:comment : An aggregate rating of an Organization related to its role as an employer.^^xsd:string</para>
    ///   <a href="http://schema.org/EmployerAggregateRating">schema:EmployerAggregateRating</a>
    /// </summary>
    let EmployerAggregateRating = _prefixId.prefix "EmployerAggregateRating"
    /// <summary>
    ///   <para>rdfs:label : EmploymentAgency^^xsd:string</para>
    ///   <para>rdfs:comment : An employment agency.^^xsd:string</para>
    ///   <a href="http://schema.org/EmploymentAgency">schema:EmploymentAgency</a>
    /// </summary>
    let EmploymentAgency = _prefixId.prefix "EmploymentAgency"
    /// <summary>
    ///   <para>rdfs:label : EndorseAction^^xsd:string</para>
    ///   <para>rdfs:comment : An agent approves/certifies/likes/supports/sanction an object.^^xsd:string</para>
    ///   <a href="http://schema.org/EndorseAction">schema:EndorseAction</a>
    /// </summary>
    let EndorseAction = _prefixId.prefix "EndorseAction"
    /// <summary>
    ///   <para>rdfs:comment : An EndorsementRating is a rating that expresses some level of endorsement, for example inclusion in a "critic's pick" blog, a
    /// "Like" or "+1" on a social network. It can be considered the &lt;a class="localLink" href="http://schema.org/result"&gt;result&lt;/a&gt; of an &lt;a class="localLink" href="http://schema.org/EndorseAction"&gt;EndorseAction&lt;/a&gt; in which the &lt;a class="localLink" href="http://schema.org/object"&gt;object&lt;/a&gt; of the action is rated positively by
    /// some &lt;a class="localLink" href="http://schema.org/agent"&gt;agent&lt;/a&gt;. As is common elsewhere in schema.org, it is sometimes more useful to describe the results of such an action without explicitly describing the &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// An &lt;a class="localLink" href="http://schema.org/EndorsementRating"&gt;EndorsementRating&lt;/a&gt; may be part of a numeric scale or organized system, but this is not required: having an explicit type for indicating a positive,
    /// endorsement rating is particularly useful in the absence of numeric scales as it helps consumers understand that the rating is broadly positive.^^xsd:string</para>
    ///   <para>schema:category : issue-1293^^xsd:string</para>
    ///   <para>rdfs:label : EndorsementRating^^xsd:string</para>
    ///   <a href="http://schema.org/EndorsementRating">schema:EndorsementRating</a>
    /// </summary>
    let EndorsementRating = _prefixId.prefix "EndorsementRating"
    /// <summary>
    ///   <para>rdfs:comment : Properties that take Energy as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Energy unit of measure&amp;gt;'.^^xsd:string</para>
    ///   <para>rdfs:label : Energy^^xsd:string</para>
    ///   <a href="http://schema.org/Energy">schema:Energy</a>
    /// </summary>
    let Energy = _prefixId.prefix "Energy"
    /// <summary>
    ///   <para>rdfs:label : EngineSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.^^xsd:string</para>
    ///   <a href="http://schema.org/EngineSpecification">schema:EngineSpecification</a>
    /// </summary>
    let EngineSpecification = _prefixId.prefix "EngineSpecification"
    /// <summary>
    ///   <para>rdfs:comment : A business providing entertainment.^^xsd:string</para>
    ///   <para>rdfs:label : EntertainmentBusiness^^xsd:string</para>
    ///   <a href="http://schema.org/EntertainmentBusiness">schema:EntertainmentBusiness</a>
    /// </summary>
    let EntertainmentBusiness = _prefixId.prefix "EntertainmentBusiness"
    /// <summary>
    ///   <para>rdfs:comment : An entry point, within some Web-based protocol.^^xsd:string</para>
    ///   <para>rdfs:label : EntryPoint^^xsd:string</para>
    ///   <a href="http://schema.org/EntryPoint">schema:EntryPoint</a>
    /// </summary>
    let EntryPoint = _prefixId.prefix "EntryPoint"
    /// <summary>
    ///   <para>rdfs:comment : Lists or enumerations—for example, a list of cuisines or music genres, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Enumeration^^xsd:string</para>
    ///   <a href="http://schema.org/Enumeration">schema:Enumeration</a>
    /// </summary>
    let Enumeration = _prefixId.prefix "Enumeration"
    /// <summary>
    ///   <para>rdfs:comment : A media episode (e.g. TV, radio, video game) which can be part of a series or season.^^xsd:string</para>
    ///   <para>rdfs:label : Episode^^xsd:string</para>
    ///   <a href="http://schema.org/Episode">schema:Episode</a>
    /// </summary>
    let Episode = _prefixId.prefix "Episode"
    /// <summary>
    ///   <para>rdfs:label : Event^^xsd:string</para>
    ///   <para>rdfs:comment : An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the &lt;a class="localLink" href="http://schema.org/offers"&gt;offers&lt;/a&gt; property. Repeated events may be structured as separate Event objects.^^xsd:string</para>
    ///   <a href="http://schema.org/Event">schema:Event</a>
    /// </summary>
    let Event = _prefixId.prefix "Event"
    let EventCancelled = _prefixId.prefix "EventCancelled"
    let EventMovedOnline = _prefixId.prefix "EventMovedOnline"
    let EventPostponed = _prefixId.prefix "EventPostponed"
    let EventRescheduled = _prefixId.prefix "EventRescheduled"
    /// <summary>
    ///   <para>rdfs:label : EventReservation^^xsd:string</para>
    ///   <para>rdfs:comment : A reservation for an event like a concert, sporting event, or lecture.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/EventReservation">schema:EventReservation</a>
    /// </summary>
    let EventReservation = _prefixId.prefix "EventReservation"
    let EventScheduled = _prefixId.prefix "EventScheduled"
    /// <summary>
    ///   <para>rdfs:comment : EventStatusType is an enumeration type whose instances represent several states that an Event may be in.^^xsd:string</para>
    ///   <para>rdfs:label : EventStatusType^^xsd:string</para>
    ///   <a href="http://schema.org/EventStatusType">schema:EventStatusType</a>
    /// </summary>
    let EventStatusType = _prefixId.prefix "EventStatusType"
    /// <summary>
    ///   <para>rdfs:label : EventVenue^^xsd:string</para>
    ///   <para>rdfs:comment : An event venue.^^xsd:string</para>
    ///   <a href="http://schema.org/EventVenue">schema:EventVenue</a>
    /// </summary>
    let EventVenue = _prefixId.prefix "EventVenue"
    let ExchangeRateSpecification = _prefixId.prefix "ExchangeRateSpecification"
    /// <summary>
    ///   <para>rdfs:comment : The act of participating in exertive activity for the purposes of improving health and fitness.^^xsd:string</para>
    ///   <para>rdfs:label : ExerciseAction^^xsd:string</para>
    ///   <a href="http://schema.org/ExerciseAction">schema:ExerciseAction</a>
    /// </summary>
    let ExerciseAction = _prefixId.prefix "ExerciseAction"
    /// <summary>
    ///   <para>rdfs:label : ExerciseGym^^xsd:string</para>
    ///   <para>rdfs:comment : A gym.^^xsd:string</para>
    ///   <a href="http://schema.org/ExerciseGym">schema:ExerciseGym</a>
    /// </summary>
    let ExerciseGym = _prefixId.prefix "ExerciseGym"
    /// <summary>
    ///   <para>rdfs:label : ExhibitionEvent^^xsd:string</para>
    ///   <para>rdfs:comment : Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...^^xsd:string</para>
    ///   <a href="http://schema.org/ExhibitionEvent">schema:ExhibitionEvent</a>
    /// </summary>
    let ExhibitionEvent = _prefixId.prefix "ExhibitionEvent"
    /// <summary>
    ///   <para>rdfs:comment : A &lt;a class="localLink" href="http://schema.org/FAQPage"&gt;FAQPage&lt;/a&gt; is a &lt;a class="localLink" href="http://schema.org/WebPage"&gt;WebPage&lt;/a&gt; presenting one or more "&lt;a href="https://en.wikipedia.org/wiki/FAQ"&gt;Frequently asked questions&lt;/a&gt;" (see also &lt;a class="localLink" href="http://schema.org/QAPage"&gt;QAPage&lt;/a&gt;).^^xsd:string</para>
    ///   <para>rdfs:label : FAQPage^^xsd:string</para>
    ///   <para>schema:category : issue-1723^^xsd:string</para>
    ///   <a href="http://schema.org/FAQPage">schema:FAQPage</a>
    /// </summary>
    let FAQPage = _prefixId.prefix "FAQPage"
    /// <summary>
    ///   <para>schema:category : issue-1004^^xsd:string</para>
    ///   <para>rdfs:label : FMRadioChannel^^xsd:string</para>
    ///   <para>rdfs:comment : A radio channel that uses FM.^^xsd:string</para>
    ///   <a href="http://schema.org/FMRadioChannel">schema:FMRadioChannel</a>
    /// </summary>
    let FMRadioChannel = _prefixId.prefix "FMRadioChannel"
    let FailedActionStatus = _prefixId.prefix "FailedActionStatus"
    let False = _prefixId.prefix "False"
    /// <summary>
    ///   <para>rdfs:label : FastFoodRestaurant^^xsd:string</para>
    ///   <para>rdfs:comment : A fast-food restaurant.^^xsd:string</para>
    ///   <a href="http://schema.org/FastFoodRestaurant">schema:FastFoodRestaurant</a>
    /// </summary>
    let FastFoodRestaurant = _prefixId.prefix "FastFoodRestaurant"
    let Female = _prefixId.prefix "Female"
    /// <summary>
    ///   <para>rdfs:label : Festival^^xsd:string</para>
    ///   <para>rdfs:comment : Event type: Festival.^^xsd:string</para>
    ///   <a href="http://schema.org/Festival">schema:Festival</a>
    /// </summary>
    let Festival = _prefixId.prefix "Festival"
    /// <summary>
    ///   <para>rdfs:comment : The act of capturing sound and moving images on film, video, or digitally.^^xsd:string</para>
    ///   <para>rdfs:label : FilmAction^^xsd:string</para>
    ///   <a href="http://schema.org/FilmAction">schema:FilmAction</a>
    /// </summary>
    let FilmAction = _prefixId.prefix "FilmAction"
    /// <summary>
    ///   <para>rdfs:comment : A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.^^xsd:string</para>
    ///   <para>rdfs:label : FinancialProduct^^xsd:string</para>
    ///   <a href="http://schema.org/FinancialProduct">schema:FinancialProduct</a>
    /// </summary>
    let FinancialProduct = _prefixId.prefix "FinancialProduct"
    /// <summary>
    ///   <para>rdfs:label : FinancialService^^xsd:string</para>
    ///   <para>rdfs:comment : Financial services business.^^xsd:string</para>
    ///   <a href="http://schema.org/FinancialService">schema:FinancialService</a>
    /// </summary>
    let FinancialService = _prefixId.prefix "FinancialService"
    /// <summary>
    ///   <para>rdfs:comment : The act of finding an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SearchAction"&gt;SearchAction&lt;/a&gt;: FindAction is generally lead by a SearchAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : FindAction^^xsd:string</para>
    ///   <a href="http://schema.org/FindAction">schema:FindAction</a>
    /// </summary>
    let FindAction = _prefixId.prefix "FindAction"
    /// <summary>
    ///   <para>rdfs:comment : A fire station. With firemen.^^xsd:string</para>
    ///   <para>rdfs:label : FireStation^^xsd:string</para>
    ///   <a href="http://schema.org/FireStation">schema:FireStation</a>
    /// </summary>
    let FireStation = _prefixId.prefix "FireStation"
    /// <summary>
    ///   <para>rdfs:comment : An airline flight.^^xsd:string</para>
    ///   <para>rdfs:label : Flight^^xsd:string</para>
    ///   <a href="http://schema.org/Flight">schema:Flight</a>
    /// </summary>
    let Flight = _prefixId.prefix "Flight"
    /// <summary>
    ///   <para>rdfs:label : FlightReservation^^xsd:string</para>
    ///   <para>rdfs:comment : A reservation for air travel.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/FlightReservation">schema:FlightReservation</a>
    /// </summary>
    let FlightReservation = _prefixId.prefix "FlightReservation"
    /// <summary>
    ///   <para>rdfs:label : Float^^xsd:string</para>
    ///   <para>rdfs:comment : Data type: Floating number.^^xsd:string</para>
    ///   <a href="http://schema.org/Float">schema:Float</a>
    /// </summary>
    let Float = _prefixId.prefix "Float"
    let FloorPlan = _prefixId.prefix "FloorPlan"
    /// <summary>
    ///   <para>rdfs:label : Florist^^xsd:string</para>
    ///   <para>rdfs:comment : A florist.^^xsd:string</para>
    ///   <a href="http://schema.org/Florist">schema:Florist</a>
    /// </summary>
    let Florist = _prefixId.prefix "Florist"
    /// <summary>
    ///   <para>rdfs:label : FollowAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from.&lt;br/&gt;&lt;br/&gt;
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
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/FollowAction">schema:FollowAction</a>
    /// </summary>
    let FollowAction = _prefixId.prefix "FollowAction"
    /// <summary>
    ///   <para>rdfs:comment : A food-related business.^^xsd:string</para>
    ///   <para>rdfs:label : FoodEstablishment^^xsd:string</para>
    ///   <a href="http://schema.org/FoodEstablishment">schema:FoodEstablishment</a>
    /// </summary>
    let FoodEstablishment = _prefixId.prefix "FoodEstablishment"
    /// <summary>
    ///   <para>rdfs:comment : A reservation to dine at a food-related business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.^^xsd:string</para>
    ///   <para>rdfs:label : FoodEstablishmentReservation^^xsd:string</para>
    ///   <a href="http://schema.org/FoodEstablishmentReservation">schema:FoodEstablishmentReservation</a>
    /// </summary>
    let FoodEstablishmentReservation = _prefixId.prefix "FoodEstablishmentReservation"
    /// <summary>
    ///   <para>rdfs:comment : Event type: Food event.^^xsd:string</para>
    ///   <para>rdfs:label : FoodEvent^^xsd:string</para>
    ///   <a href="http://schema.org/FoodEvent">schema:FoodEvent</a>
    /// </summary>
    let FoodEvent = _prefixId.prefix "FoodEvent"
    /// <summary>
    ///   <para>rdfs:label : FoodService^^xsd:string</para>
    ///   <para>rdfs:comment : A food service, like breakfast, lunch, or dinner.^^xsd:string</para>
    ///   <a href="http://schema.org/FoodService">schema:FoodService</a>
    /// </summary>
    let FoodService = _prefixId.prefix "FoodService"
    let FourWheelDriveConfiguration = _prefixId.prefix "FourWheelDriveConfiguration"
    let Friday = _prefixId.prefix "Friday"
    let FrontWheelDriveConfiguration = _prefixId.prefix "FrontWheelDriveConfiguration"
    /// <summary>
    ///   <para>rdfs:comment : A furniture store.^^xsd:string</para>
    ///   <para>rdfs:label : FurnitureStore^^xsd:string</para>
    ///   <a href="http://schema.org/FurnitureStore">schema:FurnitureStore</a>
    /// </summary>
    let FurnitureStore = _prefixId.prefix "FurnitureStore"
    /// <summary>
    ///   <para>rdfs:comment : The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.^^xsd:string</para>
    ///   <para>rdfs:label : Game^^xsd:string</para>
    ///   <a href="http://schema.org/Game">schema:Game</a>
    /// </summary>
    let Game = _prefixId.prefix "Game"
    /// <summary>
    ///   <para>rdfs:label : GamePlayMode^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether this game is multi-player, co-op or single-player.^^xsd:string</para>
    ///   <a href="http://schema.org/GamePlayMode">schema:GamePlayMode</a>
    /// </summary>
    let GamePlayMode = _prefixId.prefix "GamePlayMode"
    /// <summary>
    ///   <para>rdfs:label : GameServer^^xsd:string</para>
    ///   <para>rdfs:comment : Server that provides game interaction in a multiplayer game.^^xsd:string</para>
    ///   <a href="http://schema.org/GameServer">schema:GameServer</a>
    /// </summary>
    let GameServer = _prefixId.prefix "GameServer"
    /// <summary>
    ///   <para>rdfs:comment : Status of a game server.^^xsd:string</para>
    ///   <para>rdfs:label : GameServerStatus^^xsd:string</para>
    ///   <a href="http://schema.org/GameServerStatus">schema:GameServerStatus</a>
    /// </summary>
    let GameServerStatus = _prefixId.prefix "GameServerStatus"
    /// <summary>
    ///   <para>rdfs:comment : A garden store.^^xsd:string</para>
    ///   <para>rdfs:label : GardenStore^^xsd:string</para>
    ///   <a href="http://schema.org/GardenStore">schema:GardenStore</a>
    /// </summary>
    let GardenStore = _prefixId.prefix "GardenStore"
    /// <summary>
    ///   <para>rdfs:label : GasStation^^xsd:string</para>
    ///   <para>rdfs:comment : A gas station.^^xsd:string</para>
    ///   <a href="http://schema.org/GasStation">schema:GasStation</a>
    /// </summary>
    let GasStation = _prefixId.prefix "GasStation"
    /// <summary>
    ///   <para>rdfs:comment : Residence type: Gated community.^^xsd:string</para>
    ///   <para>rdfs:label : GatedResidenceCommunity^^xsd:string</para>
    ///   <a href="http://schema.org/GatedResidenceCommunity">schema:GatedResidenceCommunity</a>
    /// </summary>
    let GatedResidenceCommunity = _prefixId.prefix "GatedResidenceCommunity"
    /// <summary>
    ///   <para>rdfs:comment : An enumeration of genders.^^xsd:string</para>
    ///   <para>rdfs:label : GenderType^^xsd:string</para>
    ///   <a href="http://schema.org/GenderType">schema:GenderType</a>
    /// </summary>
    let GenderType = _prefixId.prefix "GenderType"
    /// <summary>
    ///   <para>rdfs:label : GeneralContractor^^xsd:string</para>
    ///   <para>rdfs:comment : A general contractor.^^xsd:string</para>
    ///   <a href="http://schema.org/GeneralContractor">schema:GeneralContractor</a>
    /// </summary>
    let GeneralContractor = _prefixId.prefix "GeneralContractor"
    /// <summary>
    ///   <para>rdfs:comment : A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.^^xsd:string</para>
    ///   <para>rdfs:label : GeoCircle^^xsd:string</para>
    ///   <a href="http://schema.org/GeoCircle">schema:GeoCircle</a>
    /// </summary>
    let GeoCircle = _prefixId.prefix "GeoCircle"
    /// <summary>
    ///   <para>rdfs:comment : The geographic coordinates of a place or event.^^xsd:string</para>
    ///   <para>rdfs:label : GeoCoordinates^^xsd:string</para>
    ///   <a href="http://schema.org/GeoCoordinates">schema:GeoCoordinates</a>
    /// </summary>
    let GeoCoordinates = _prefixId.prefix "GeoCoordinates"
    /// <summary>
    ///   <para>rdfs:label : GeoShape^^xsd:string</para>
    ///   <para>rdfs:comment : The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.^^xsd:string</para>
    ///   <a href="http://schema.org/GeoShape">schema:GeoShape</a>
    /// </summary>
    let GeoShape = _prefixId.prefix "GeoShape"
    let GeospatialGeometry = _prefixId.prefix "GeospatialGeometry"
    /// <summary>
    ///   <para>rdfs:comment : The act of transferring ownership of an object to a destination. Reciprocal of TakeAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Reciprocal of GiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: Unlike SendAction, GiveAction implies that ownership is being transferred (e.g. I may send my laptop to you, but that doesn't mean I'm giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : GiveAction^^xsd:string</para>
    ///   <a href="http://schema.org/GiveAction">schema:GiveAction</a>
    /// </summary>
    let GiveAction = _prefixId.prefix "GiveAction"
    let GlutenFreeDiet = _prefixId.prefix "GlutenFreeDiet"
    /// <summary>
    ///   <para>rdfs:comment : A golf course.^^xsd:string</para>
    ///   <para>rdfs:label : GolfCourse^^xsd:string</para>
    ///   <a href="http://schema.org/GolfCourse">schema:GolfCourse</a>
    /// </summary>
    let GolfCourse = _prefixId.prefix "GolfCourse"
    /// <summary>
    ///   <para>rdfs:label : GovernmentBuilding^^xsd:string</para>
    ///   <para>rdfs:comment : A government building.^^xsd:string</para>
    ///   <a href="http://schema.org/GovernmentBuilding">schema:GovernmentBuilding</a>
    /// </summary>
    let GovernmentBuilding = _prefixId.prefix "GovernmentBuilding"
    /// <summary>
    ///   <para>rdfs:comment : A government office&amp;#x2014;for example, an IRS or DMV office.^^xsd:string</para>
    ///   <para>rdfs:label : GovernmentOffice^^xsd:string</para>
    ///   <a href="http://schema.org/GovernmentOffice">schema:GovernmentOffice</a>
    /// </summary>
    let GovernmentOffice = _prefixId.prefix "GovernmentOffice"
    /// <summary>
    ///   <para>rdfs:label : GovernmentOrganization^^xsd:string</para>
    ///   <para>rdfs:comment : A governmental organization or agency.^^xsd:string</para>
    ///   <a href="http://schema.org/GovernmentOrganization">schema:GovernmentOrganization</a>
    /// </summary>
    let GovernmentOrganization = _prefixId.prefix "GovernmentOrganization"
    /// <summary>
    ///   <para>rdfs:label : GovernmentPermit^^xsd:string</para>
    ///   <para>rdfs:comment : A permit issued by a government agency.^^xsd:string</para>
    ///   <a href="http://schema.org/GovernmentPermit">schema:GovernmentPermit</a>
    /// </summary>
    let GovernmentPermit = _prefixId.prefix "GovernmentPermit"
    /// <summary>
    ///   <para>rdfs:comment : A service provided by a government organization, e.g. food stamps, veterans benefits, etc.^^xsd:string</para>
    ///   <para>rdfs:label : GovernmentService^^xsd:string</para>
    ///   <a href="http://schema.org/GovernmentService">schema:GovernmentService</a>
    /// </summary>
    let GovernmentService = _prefixId.prefix "GovernmentService"
    let Grant = _prefixId.prefix "Grant"
    /// <summary>
    ///   <para>rdfs:label : GroceryStore^^xsd:string</para>
    ///   <para>rdfs:comment : A grocery store.^^xsd:string</para>
    ///   <a href="http://schema.org/GroceryStore">schema:GroceryStore</a>
    /// </summary>
    let GroceryStore = _prefixId.prefix "GroceryStore"
    let GroupBoardingPolicy = _prefixId.prefix "GroupBoardingPolicy"
    let Guide = _prefixId.prefix "Guide"
    /// <summary>
    ///   <para>rdfs:comment : A business that provide Heating, Ventilation and Air Conditioning services.^^xsd:string</para>
    ///   <para>rdfs:label : HVACBusiness^^xsd:string</para>
    ///   <a href="http://schema.org/HVACBusiness">schema:HVACBusiness</a>
    /// </summary>
    let HVACBusiness = _prefixId.prefix "HVACBusiness"
    /// <summary>
    ///   <para>rdfs:label : HairSalon^^xsd:string</para>
    ///   <para>rdfs:comment : A hair salon.^^xsd:string</para>
    ///   <a href="http://schema.org/HairSalon">schema:HairSalon</a>
    /// </summary>
    let HairSalon = _prefixId.prefix "HairSalon"
    let HalalDiet = _prefixId.prefix "HalalDiet"
    let Hardcover = _prefixId.prefix "Hardcover"
    /// <summary>
    ///   <para>rdfs:comment : A hardware store.^^xsd:string</para>
    ///   <para>rdfs:label : HardwareStore^^xsd:string</para>
    ///   <a href="http://schema.org/HardwareStore">schema:HardwareStore</a>
    /// </summary>
    let HardwareStore = _prefixId.prefix "HardwareStore"
    /// <summary>
    ///   <para>rdfs:comment : Health and beauty.^^xsd:string</para>
    ///   <para>rdfs:label : HealthAndBeautyBusiness^^xsd:string</para>
    ///   <a href="http://schema.org/HealthAndBeautyBusiness">schema:HealthAndBeautyBusiness</a>
    /// </summary>
    let HealthAndBeautyBusiness = _prefixId.prefix "HealthAndBeautyBusiness"
    /// <summary>
    ///   <para>rdfs:label : HealthClub^^xsd:string</para>
    ///   <para>rdfs:comment : A health club.^^xsd:string</para>
    ///   <a href="http://schema.org/HealthClub">schema:HealthClub</a>
    /// </summary>
    let HealthClub = _prefixId.prefix "HealthClub"
    let HealthInsurancePlan = _prefixId.prefix "HealthInsurancePlan"
    let HearingImpairedSupported = _prefixId.prefix "HearingImpairedSupported"
    /// <summary>
    ///   <para>rdfs:comment : A high school.^^xsd:string</para>
    ///   <para>rdfs:label : HighSchool^^xsd:string</para>
    ///   <a href="http://schema.org/HighSchool">schema:HighSchool</a>
    /// </summary>
    let HighSchool = _prefixId.prefix "HighSchool"
    let HinduDiet = _prefixId.prefix "HinduDiet"
    /// <summary>
    ///   <para>rdfs:label : HinduTemple^^xsd:string</para>
    ///   <para>rdfs:comment : A Hindu temple.^^xsd:string</para>
    ///   <a href="http://schema.org/HinduTemple">schema:HinduTemple</a>
    /// </summary>
    let HinduTemple = _prefixId.prefix "HinduTemple"
    /// <summary>
    ///   <para>rdfs:comment : A store that sells materials useful or necessary for various hobbies.^^xsd:string</para>
    ///   <para>rdfs:label : HobbyShop^^xsd:string</para>
    ///   <a href="http://schema.org/HobbyShop">schema:HobbyShop</a>
    /// </summary>
    let HobbyShop = _prefixId.prefix "HobbyShop"
    /// <summary>
    ///   <para>rdfs:label : HomeAndConstructionBusiness^^xsd:string</para>
    ///   <para>rdfs:comment : A construction business.&lt;br/&gt;&lt;br/&gt;
    ///
    /// A HomeAndConstructionBusiness is a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; that provides services around homes and buildings.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).^^xsd:string</para>
    ///   <a href="http://schema.org/HomeAndConstructionBusiness">schema:HomeAndConstructionBusiness</a>
    /// </summary>
    let HomeAndConstructionBusiness = _prefixId.prefix "HomeAndConstructionBusiness"
    /// <summary>
    ///   <para>rdfs:label : HomeGoodsStore^^xsd:string</para>
    ///   <para>rdfs:comment : A home goods store.^^xsd:string</para>
    ///   <a href="http://schema.org/HomeGoodsStore">schema:HomeGoodsStore</a>
    /// </summary>
    let HomeGoodsStore = _prefixId.prefix "HomeGoodsStore"
    /// <summary>
    ///   <para>rdfs:comment : A hospital.^^xsd:string</para>
    ///   <para>rdfs:label : Hospital^^xsd:string</para>
    ///   <a href="http://schema.org/Hospital">schema:Hospital</a>
    /// </summary>
    let Hospital = _prefixId.prefix "Hospital"
    /// <summary>
    ///   <para>rdfs:label : Hostel^^xsd:string</para>
    ///   <para>rdfs:comment : A hostel - cheap accommodation, often in shared dormitories.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/Hostel">schema:Hostel</a>
    /// </summary>
    let Hostel = _prefixId.prefix "Hostel"
    /// <summary>
    ///   <para>rdfs:label : Hotel^^xsd:string</para>
    ///   <para>rdfs:comment : A hotel is an establishment that provides lodging paid on a short-term basis (Source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/Hotel">schema:Hotel</a>
    /// </summary>
    let Hotel = _prefixId.prefix "Hotel"
    /// <summary>
    ///   <para>rdfs:comment : A hotel room is a single room in a hotel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : HotelRoom^^xsd:string</para>
    ///   <a href="http://schema.org/HotelRoom">schema:HotelRoom</a>
    /// </summary>
    let HotelRoom = _prefixId.prefix "HotelRoom"
    /// <summary>
    ///   <para>rdfs:comment : A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).^^xsd:string</para>
    ///   <para>rdfs:label : House^^xsd:string</para>
    ///   <a href="http://schema.org/House">schema:House</a>
    /// </summary>
    let House = _prefixId.prefix "House"
    /// <summary>
    ///   <para>rdfs:label : HousePainter^^xsd:string</para>
    ///   <para>rdfs:comment : A house painting service.^^xsd:string</para>
    ///   <a href="http://schema.org/HousePainter">schema:HousePainter</a>
    /// </summary>
    let HousePainter = _prefixId.prefix "HousePainter"
    /// <summary>
    ///   <para>rdfs:label : HowTo^^xsd:string</para>
    ///   <para>rdfs:comment : Instructions that explain how to achieve a result by performing a sequence of steps.^^xsd:string</para>
    ///   <a href="http://schema.org/HowTo">schema:HowTo</a>
    /// </summary>
    let HowTo = _prefixId.prefix "HowTo"
    /// <summary>
    ///   <para>rdfs:comment : A direction indicating a single action to do in the instructions for how to achieve a result.^^xsd:string</para>
    ///   <para>rdfs:label : HowToDirection^^xsd:string</para>
    ///   <a href="http://schema.org/HowToDirection">schema:HowToDirection</a>
    /// </summary>
    let HowToDirection = _prefixId.prefix "HowToDirection"
    /// <summary>
    ///   <para>rdfs:comment : An item used as either a tool or supply when performing the instructions for how to to achieve a result.^^xsd:string</para>
    ///   <para>rdfs:label : HowToItem^^xsd:string</para>
    ///   <a href="http://schema.org/HowToItem">schema:HowToItem</a>
    /// </summary>
    let HowToItem = _prefixId.prefix "HowToItem"
    /// <summary>
    ///   <para>rdfs:label : HowToSection^^xsd:string</para>
    ///   <para>rdfs:comment : A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).^^xsd:string</para>
    ///   <a href="http://schema.org/HowToSection">schema:HowToSection</a>
    /// </summary>
    let HowToSection = _prefixId.prefix "HowToSection"
    /// <summary>
    ///   <para>rdfs:comment : A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.^^xsd:string</para>
    ///   <para>rdfs:label : HowToStep^^xsd:string</para>
    ///   <a href="http://schema.org/HowToStep">schema:HowToStep</a>
    /// </summary>
    let HowToStep = _prefixId.prefix "HowToStep"
    /// <summary>
    ///   <para>rdfs:label : HowToSupply^^xsd:string</para>
    ///   <para>rdfs:comment : A supply consumed when performing the instructions for how to achieve a result.^^xsd:string</para>
    ///   <a href="http://schema.org/HowToSupply">schema:HowToSupply</a>
    /// </summary>
    let HowToSupply = _prefixId.prefix "HowToSupply"
    /// <summary>
    ///   <para>rdfs:label : HowToTip^^xsd:string</para>
    ///   <para>rdfs:comment : An explanation in the instructions for how to achieve a result. It provides supplementary information about a technique, supply, author's preference, etc. It can explain what could be done, or what should not be done, but doesn't specify what should be done (see HowToDirection).^^xsd:string</para>
    ///   <a href="http://schema.org/HowToTip">schema:HowToTip</a>
    /// </summary>
    let HowToTip = _prefixId.prefix "HowToTip"
    /// <summary>
    ///   <para>rdfs:comment : A tool used (but not consumed) when performing instructions for how to achieve a result.^^xsd:string</para>
    ///   <para>rdfs:label : HowToTool^^xsd:string</para>
    ///   <a href="http://schema.org/HowToTool">schema:HowToTool</a>
    /// </summary>
    let HowToTool = _prefixId.prefix "HowToTool"
    /// <summary>
    ///   <para>rdfs:comment : An ice cream shop.^^xsd:string</para>
    ///   <para>rdfs:label : IceCreamShop^^xsd:string</para>
    ///   <a href="http://schema.org/IceCreamShop">schema:IceCreamShop</a>
    /// </summary>
    let IceCreamShop = _prefixId.prefix "IceCreamShop"
    /// <summary>
    ///   <para>rdfs:comment : The act of intentionally disregarding the object. An agent ignores an object.^^xsd:string</para>
    ///   <para>rdfs:label : IgnoreAction^^xsd:string</para>
    ///   <a href="http://schema.org/IgnoreAction">schema:IgnoreAction</a>
    /// </summary>
    let IgnoreAction = _prefixId.prefix "IgnoreAction"
    /// <summary>
    ///   <para>rdfs:comment : Web page type: Image gallery page.^^xsd:string</para>
    ///   <para>rdfs:label : ImageGallery^^xsd:string</para>
    ///   <a href="http://schema.org/ImageGallery">schema:ImageGallery</a>
    /// </summary>
    let ImageGallery = _prefixId.prefix "ImageGallery"
    /// <summary>
    ///   <para>rdfs:label : ImageObject^^xsd:string</para>
    ///   <para>rdfs:comment : An image file.^^xsd:string</para>
    ///   <a href="http://schema.org/ImageObject">schema:ImageObject</a>
    /// </summary>
    let ImageObject = _prefixId.prefix "ImageObject"
    let InStock = _prefixId.prefix "InStock"
    let InStoreOnly = _prefixId.prefix "InStoreOnly"
    /// <summary>
    ///   <para>rdfs:comment : A single, identifiable product instance (e.g. a laptop with a particular serial number).^^xsd:string</para>
    ///   <para>rdfs:label : IndividualProduct^^xsd:string</para>
    ///   <a href="http://schema.org/IndividualProduct">schema:IndividualProduct</a>
    /// </summary>
    let IndividualProduct = _prefixId.prefix "IndividualProduct"
    /// <summary>
    ///   <para>rdfs:label : InformAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of notifying someone of information pertinent to them, with no expectation of a response.^^xsd:string</para>
    ///   <a href="http://schema.org/InformAction">schema:InformAction</a>
    /// </summary>
    let InformAction = _prefixId.prefix "InformAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of adding at a specific location in an ordered collection.^^xsd:string</para>
    ///   <para>rdfs:label : InsertAction^^xsd:string</para>
    ///   <a href="http://schema.org/InsertAction">schema:InsertAction</a>
    /// </summary>
    let InsertAction = _prefixId.prefix "InsertAction"
    /// <summary>
    ///   <para>rdfs:label : InstallAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of installing an application.^^xsd:string</para>
    ///   <a href="http://schema.org/InstallAction">schema:InstallAction</a>
    /// </summary>
    let InstallAction = _prefixId.prefix "InstallAction"
    /// <summary>
    ///   <para>rdfs:label : InsuranceAgency^^xsd:string</para>
    ///   <para>rdfs:comment : An Insurance agency.^^xsd:string</para>
    ///   <a href="http://schema.org/InsuranceAgency">schema:InsuranceAgency</a>
    /// </summary>
    let InsuranceAgency = _prefixId.prefix "InsuranceAgency"
    /// <summary>
    ///   <para>rdfs:comment : A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Intangible^^xsd:string</para>
    ///   <a href="http://schema.org/Intangible">schema:Intangible</a>
    /// </summary>
    let Intangible = _prefixId.prefix "Intangible"
    /// <summary>
    ///   <para>rdfs:label : Integer^^xsd:string</para>
    ///   <para>rdfs:comment : Data type: Integer.^^xsd:string</para>
    ///   <a href="http://schema.org/Integer">schema:Integer</a>
    /// </summary>
    let Integer = _prefixId.prefix "Integer"
    /// <summary>
    ///   <para>rdfs:comment : The act of interacting with another person or organization.^^xsd:string</para>
    ///   <para>rdfs:label : InteractAction^^xsd:string</para>
    ///   <a href="http://schema.org/InteractAction">schema:InteractAction</a>
    /// </summary>
    let InteractAction = _prefixId.prefix "InteractAction"
    /// <summary>
    ///   <para>rdfs:comment : A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.^^xsd:string</para>
    ///   <para>rdfs:label : InteractionCounter^^xsd:string</para>
    ///   <a href="http://schema.org/InteractionCounter">schema:InteractionCounter</a>
    /// </summary>
    let InteractionCounter = _prefixId.prefix "InteractionCounter"
    /// <summary>
    ///   <para>rdfs:label : InternetCafe^^xsd:string</para>
    ///   <para>rdfs:comment : An internet cafe.^^xsd:string</para>
    ///   <a href="http://schema.org/InternetCafe">schema:InternetCafe</a>
    /// </summary>
    let InternetCafe = _prefixId.prefix "InternetCafe"
    /// <summary>
    ///   <para>rdfs:comment : A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.^^xsd:string</para>
    ///   <para>rdfs:label : InvestmentOrDeposit^^xsd:string</para>
    ///   <a href="http://schema.org/InvestmentOrDeposit">schema:InvestmentOrDeposit</a>
    /// </summary>
    let InvestmentOrDeposit = _prefixId.prefix "InvestmentOrDeposit"
    /// <summary>
    ///   <para>rdfs:label : InviteAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of asking someone to attend an event. Reciprocal of RsvpAction.^^xsd:string</para>
    ///   <a href="http://schema.org/InviteAction">schema:InviteAction</a>
    /// </summary>
    let InviteAction = _prefixId.prefix "InviteAction"
    /// <summary>
    ///   <para>rdfs:label : Invoice^^xsd:string</para>
    ///   <para>rdfs:comment : A statement of the money due for goods or services; a bill.^^xsd:string</para>
    ///   <a href="http://schema.org/Invoice">schema:Invoice</a>
    /// </summary>
    let Invoice = _prefixId.prefix "Invoice"
    /// <summary>
    ///   <para>rdfs:label : ItemAvailability^^xsd:string</para>
    ///   <para>rdfs:comment : A list of possible product availability options.^^xsd:string</para>
    ///   <a href="http://schema.org/ItemAvailability">schema:ItemAvailability</a>
    /// </summary>
    let ItemAvailability = _prefixId.prefix "ItemAvailability"
    /// <summary>
    ///   <para>rdfs:comment : A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.^^xsd:string</para>
    ///   <para>rdfs:label : ItemList^^xsd:string</para>
    ///   <a href="http://schema.org/ItemList">schema:ItemList</a>
    /// </summary>
    let ItemList = _prefixId.prefix "ItemList"
    let ItemListOrderAscending = _prefixId.prefix "ItemListOrderAscending"
    let ItemListOrderDescending = _prefixId.prefix "ItemListOrderDescending"
    /// <summary>
    ///   <para>rdfs:comment : Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.^^xsd:string</para>
    ///   <para>rdfs:label : ItemListOrderType^^xsd:string</para>
    ///   <a href="http://schema.org/ItemListOrderType">schema:ItemListOrderType</a>
    /// </summary>
    let ItemListOrderType = _prefixId.prefix "ItemListOrderType"
    let ItemListUnordered = _prefixId.prefix "ItemListUnordered"
    /// <summary>
    ///   <para>rdfs:label : ItemPage^^xsd:string</para>
    ///   <para>rdfs:comment : A page devoted to a single item, such as a particular product or hotel.^^xsd:string</para>
    ///   <a href="http://schema.org/ItemPage">schema:ItemPage</a>
    /// </summary>
    let ItemPage = _prefixId.prefix "ItemPage"
    /// <summary>
    ///   <para>rdfs:comment : A jewelry store.^^xsd:string</para>
    ///   <para>rdfs:label : JewelryStore^^xsd:string</para>
    ///   <a href="http://schema.org/JewelryStore">schema:JewelryStore</a>
    /// </summary>
    let JewelryStore = _prefixId.prefix "JewelryStore"
    /// <summary>
    ///   <para>rdfs:label : JobPosting^^xsd:string</para>
    ///   <para>rdfs:comment : A listing that describes a job opening in a certain organization.^^xsd:string</para>
    ///   <a href="http://schema.org/JobPosting">schema:JobPosting</a>
    /// </summary>
    let JobPosting = _prefixId.prefix "JobPosting"
    /// <summary>
    ///   <para>rdfs:comment : An agent joins an event/group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, JoinAction refers to joining a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, JoinAction does not imply that you'll be receiving updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, JoinAction does not imply that you'll be polling for updates.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : JoinAction^^xsd:string</para>
    ///   <a href="http://schema.org/JoinAction">schema:JoinAction</a>
    /// </summary>
    let JoinAction = _prefixId.prefix "JoinAction"
    let KosherDiet = _prefixId.prefix "KosherDiet"
    /// <summary>
    ///   <para>rdfs:label : LakeBodyOfWater^^xsd:string</para>
    ///   <para>rdfs:comment : A lake (for example, Lake Pontrachain).^^xsd:string</para>
    ///   <a href="http://schema.org/LakeBodyOfWater">schema:LakeBodyOfWater</a>
    /// </summary>
    let LakeBodyOfWater = _prefixId.prefix "LakeBodyOfWater"
    /// <summary>
    ///   <para>rdfs:comment : A landform or physical feature.  Landform elements include mountains, plains, lakes, rivers, seascape and oceanic waterbody interface features such as bays, peninsulas, seas and so forth, including sub-aqueous terrain features such as submersed mountain ranges, volcanoes, and the great ocean basins.^^xsd:string</para>
    ///   <para>rdfs:label : Landform^^xsd:string</para>
    ///   <a href="http://schema.org/Landform">schema:Landform</a>
    /// </summary>
    let Landform = _prefixId.prefix "Landform"

    /// <summary>
    ///   <para>rdfs:comment : An historical landmark or building.^^xsd:string</para>
    ///   <para>rdfs:label : LandmarksOrHistoricalBuildings^^xsd:string</para>
    ///   <a href="http://schema.org/LandmarksOrHistoricalBuildings">schema:LandmarksOrHistoricalBuildings</a>
    /// </summary>
    let LandmarksOrHistoricalBuildings =
        _prefixId.prefix "LandmarksOrHistoricalBuildings"

    /// <summary>
    ///   <para>rdfs:comment : Natural languages such as Spanish, Tamil, Hindi, English, etc. Formal language code tags expressed in &lt;a href="https://en.wikipedia.org/wiki/IETF_language_tag"&gt;BCP 47&lt;/a&gt; can be used via the &lt;a class="localLink" href="http://schema.org/alternateName"&gt;alternateName&lt;/a&gt; property. The Language type previously also covered programming languages such as Scheme and Lisp, which are now best represented using &lt;a class="localLink" href="http://schema.org/ComputerLanguage"&gt;ComputerLanguage&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Language^^xsd:string</para>
    ///   <a href="http://schema.org/Language">schema:Language</a>
    /// </summary>
    let Language = _prefixId.prefix "Language"
    let LaserDiscFormat = _prefixId.prefix "LaserDiscFormat"
    /// <summary>
    ///   <para>rdfs:comment : An agent leaves an event / group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: The antonym of LeaveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/UnRegisterAction"&gt;UnRegisterAction&lt;/a&gt;: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : LeaveAction^^xsd:string</para>
    ///   <a href="http://schema.org/LeaveAction">schema:LeaveAction</a>
    /// </summary>
    let LeaveAction = _prefixId.prefix "LeaveAction"
    let LeftHandDriving = _prefixId.prefix "LeftHandDriving"
    /// <summary>
    ///   <para>rdfs:label : LegalService^^xsd:string</para>
    ///   <para>rdfs:comment : A LegalService is a business that provides legally-oriented services, advice and representation, e.g. law firms.&lt;br/&gt;&lt;br/&gt;
    ///
    /// As a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt; it can be described as a &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; of one or more &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;(s).^^xsd:string</para>
    ///   <a href="http://schema.org/LegalService">schema:LegalService</a>
    /// </summary>
    let LegalService = _prefixId.prefix "LegalService"
    /// <summary>
    ///   <para>rdfs:comment : A legislative building&amp;#x2014;for example, the state capitol.^^xsd:string</para>
    ///   <para>rdfs:label : LegislativeBuilding^^xsd:string</para>
    ///   <a href="http://schema.org/LegislativeBuilding">schema:LegislativeBuilding</a>
    /// </summary>
    let LegislativeBuilding = _prefixId.prefix "LegislativeBuilding"
    /// <summary>
    ///   <para>rdfs:label : LendAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/BorrowAction"&gt;BorrowAction&lt;/a&gt;: Reciprocal of LendAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/LendAction">schema:LendAction</a>
    /// </summary>
    let LendAction = _prefixId.prefix "LendAction"
    /// <summary>
    ///   <para>rdfs:label : Library^^xsd:string</para>
    ///   <para>rdfs:comment : A library.^^xsd:string</para>
    ///   <a href="http://schema.org/Library">schema:Library</a>
    /// </summary>
    let Library = _prefixId.prefix "Library"
    /// <summary>
    ///   <para>rdfs:comment : The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.^^xsd:string</para>
    ///   <para>rdfs:label : LikeAction^^xsd:string</para>
    ///   <a href="http://schema.org/LikeAction">schema:LikeAction</a>
    /// </summary>
    let LikeAction = _prefixId.prefix "LikeAction"
    let LimitedAvailability = _prefixId.prefix "LimitedAvailability"
    let LinkRole = _prefixId.prefix "LinkRole"
    /// <summary>
    ///   <para>rdfs:comment : A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.^^xsd:string</para>
    ///   <para>rdfs:label : LiquorStore^^xsd:string</para>
    ///   <a href="http://schema.org/LiquorStore">schema:LiquorStore</a>
    /// </summary>
    let LiquorStore = _prefixId.prefix "LiquorStore"
    /// <summary>
    ///   <para>rdfs:comment : An list item, e.g. a step in a checklist or how-to description.^^xsd:string</para>
    ///   <para>rdfs:label : ListItem^^xsd:string</para>
    ///   <a href="http://schema.org/ListItem">schema:ListItem</a>
    /// </summary>
    let ListItem = _prefixId.prefix "ListItem"
    /// <summary>
    ///   <para>rdfs:label : ListenAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of consuming audio content.^^xsd:string</para>
    ///   <a href="http://schema.org/ListenAction">schema:ListenAction</a>
    /// </summary>
    let ListenAction = _prefixId.prefix "ListenAction"
    /// <summary>
    ///   <para>rdfs:label : LiteraryEvent^^xsd:string</para>
    ///   <para>rdfs:comment : Event type: Literary event.^^xsd:string</para>
    ///   <a href="http://schema.org/LiteraryEvent">schema:LiteraryEvent</a>
    /// </summary>
    let LiteraryEvent = _prefixId.prefix "LiteraryEvent"
    let LiveAlbum = _prefixId.prefix "LiveAlbum"
    /// <summary>
    ///   <para>rdfs:label : LiveBlogPosting^^xsd:string</para>
    ///   <para>rdfs:comment : A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.^^xsd:string</para>
    ///   <a href="http://schema.org/LiveBlogPosting">schema:LiveBlogPosting</a>
    /// </summary>
    let LiveBlogPosting = _prefixId.prefix "LiveBlogPosting"
    /// <summary>
    ///   <para>rdfs:comment : A financial product for the loaning of an amount of money under agreed terms and charges.^^xsd:string</para>
    ///   <para>rdfs:label : LoanOrCredit^^xsd:string</para>
    ///   <a href="http://schema.org/LoanOrCredit">schema:LoanOrCredit</a>
    /// </summary>
    let LoanOrCredit = _prefixId.prefix "LoanOrCredit"
    /// <summary>
    ///   <para>rdfs:label : LocalBusiness^^xsd:string</para>
    ///   <para>rdfs:comment : A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/LocalBusiness">schema:LocalBusiness</a>
    /// </summary>
    let LocalBusiness = _prefixId.prefix "LocalBusiness"
    /// <summary>
    ///   <para>rdfs:comment : Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.^^xsd:string</para>
    ///   <para>rdfs:label : LocationFeatureSpecification^^xsd:string</para>
    ///   <a href="http://schema.org/LocationFeatureSpecification">schema:LocationFeatureSpecification</a>
    /// </summary>
    let LocationFeatureSpecification = _prefixId.prefix "LocationFeatureSpecification"
    /// <summary>
    ///   <para>rdfs:label : LockerDelivery^^xsd:string</para>
    ///   <para>rdfs:comment : A DeliveryMethod in which an item is made available via locker.^^xsd:string</para>
    ///   <a href="http://schema.org/LockerDelivery">schema:LockerDelivery</a>
    /// </summary>
    let LockerDelivery = _prefixId.prefix "LockerDelivery"
    /// <summary>
    ///   <para>rdfs:comment : A locksmith.^^xsd:string</para>
    ///   <para>rdfs:label : Locksmith^^xsd:string</para>
    ///   <a href="http://schema.org/Locksmith">schema:Locksmith</a>
    /// </summary>
    let Locksmith = _prefixId.prefix "Locksmith"
    /// <summary>
    ///   <para>rdfs:comment : A lodging business, such as a motel, hotel, or inn.^^xsd:string</para>
    ///   <para>rdfs:label : LodgingBusiness^^xsd:string</para>
    ///   <a href="http://schema.org/LodgingBusiness">schema:LodgingBusiness</a>
    /// </summary>
    let LodgingBusiness = _prefixId.prefix "LodgingBusiness"
    /// <summary>
    ///   <para>rdfs:label : LodgingReservation^^xsd:string</para>
    ///   <para>rdfs:comment : A reservation for lodging at a hotel, motel, inn, etc.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.^^xsd:string</para>
    ///   <a href="http://schema.org/LodgingReservation">schema:LodgingReservation</a>
    /// </summary>
    let LodgingReservation = _prefixId.prefix "LodgingReservation"
    /// <summary>
    ///   <para>rdfs:label : LoseAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of being defeated in a competitive activity.^^xsd:string</para>
    ///   <a href="http://schema.org/LoseAction">schema:LoseAction</a>
    /// </summary>
    let LoseAction = _prefixId.prefix "LoseAction"
    let LowCalorieDiet = _prefixId.prefix "LowCalorieDiet"
    let LowFatDiet = _prefixId.prefix "LowFatDiet"
    let LowLactoseDiet = _prefixId.prefix "LowLactoseDiet"
    let LowSaltDiet = _prefixId.prefix "LowSaltDiet"
    let Male = _prefixId.prefix "Male"
    /// <summary>
    ///   <para>rdfs:label : Map^^xsd:string</para>
    ///   <para>rdfs:comment : A map.^^xsd:string</para>
    ///   <a href="http://schema.org/Map">schema:Map</a>
    /// </summary>
    let Map = _prefixId.prefix "Map"
    /// <summary>
    ///   <para>rdfs:comment : An enumeration of several kinds of Map.^^xsd:string</para>
    ///   <para>rdfs:label : MapCategoryType^^xsd:string</para>
    ///   <a href="http://schema.org/MapCategoryType">schema:MapCategoryType</a>
    /// </summary>
    let MapCategoryType = _prefixId.prefix "MapCategoryType"
    /// <summary>
    ///   <para>rdfs:label : MarryAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of marrying a person.^^xsd:string</para>
    ///   <a href="http://schema.org/MarryAction">schema:MarryAction</a>
    /// </summary>
    let MarryAction = _prefixId.prefix "MarryAction"
    /// <summary>
    ///   <para>rdfs:comment : Properties that take Mass as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Mass unit of measure&amp;gt;'. E.g., '7 kg'.^^xsd:string</para>
    ///   <para>rdfs:label : Mass^^xsd:string</para>
    ///   <a href="http://schema.org/Mass">schema:Mass</a>
    /// </summary>
    let Mass = _prefixId.prefix "Mass"
    /// <summary>
    ///   <para>rdfs:label : MediaGallery^^xsd:string</para>
    ///   <para>rdfs:comment : Web page type: Media gallery page. A mixed-media page that can contains media such as images, videos, and other multimedia.^^xsd:string</para>
    ///   <a href="http://schema.org/MediaGallery">schema:MediaGallery</a>
    /// </summary>
    let MediaGallery = _prefixId.prefix "MediaGallery"
    /// <summary>
    ///   <para>rdfs:label : MediaObject^^xsd:string</para>
    ///   <para>rdfs:comment : A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).^^xsd:string</para>
    ///   <a href="http://schema.org/MediaObject">schema:MediaObject</a>
    /// </summary>
    let MediaObject = _prefixId.prefix "MediaObject"
    /// <summary>
    ///   <para>rdfs:comment : A subscription which allows a user to access media including audio, video, books, etc.^^xsd:string</para>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <para>rdfs:label : MediaSubscription^^xsd:string</para>
    ///   <a href="http://schema.org/MediaSubscription">schema:MediaSubscription</a>
    /// </summary>
    let MediaSubscription = _prefixId.prefix "MediaSubscription"
    let MedicalBusiness = _prefixId.prefix "MedicalBusiness"
    /// <summary>
    ///   <para>rdfs:comment : A medical organization (physical or not), such as hospital, institution or clinic.^^xsd:string</para>
    ///   <para>rdfs:label : MedicalOrganization^^xsd:string</para>
    ///   <a href="http://schema.org/MedicalOrganization">schema:MedicalOrganization</a>
    /// </summary>
    let MedicalOrganization = _prefixId.prefix "MedicalOrganization"
    let MedicalStudy = _prefixId.prefix "MedicalStudy"
    /// <summary>
    ///   <para>rdfs:label : MeetingRoom^^xsd:string</para>
    ///   <para>rdfs:comment : A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Conference_hall"&gt;http://en.wikipedia.org/wiki/Conference_hall&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/MeetingRoom">schema:MeetingRoom</a>
    /// </summary>
    let MeetingRoom = _prefixId.prefix "MeetingRoom"
    /// <summary>
    ///   <para>rdfs:comment : A men's clothing store.^^xsd:string</para>
    ///   <para>rdfs:label : MensClothingStore^^xsd:string</para>
    ///   <a href="http://schema.org/MensClothingStore">schema:MensClothingStore</a>
    /// </summary>
    let MensClothingStore = _prefixId.prefix "MensClothingStore"
    /// <summary>
    ///   <para>rdfs:comment : A structured representation of food or drink items available from a FoodEstablishment.^^xsd:string</para>
    ///   <para>rdfs:label : Menu^^xsd:string</para>
    ///   <a href="http://schema.org/Menu">schema:Menu</a>
    /// </summary>
    let Menu = _prefixId.prefix "Menu"
    /// <summary>
    ///   <para>rdfs:comment : A food or drink item listed in a menu or menu section.^^xsd:string</para>
    ///   <para>rdfs:label : MenuItem^^xsd:string</para>
    ///   <a href="http://schema.org/MenuItem">schema:MenuItem</a>
    /// </summary>
    let MenuItem = _prefixId.prefix "MenuItem"
    /// <summary>
    ///   <para>rdfs:comment : A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.^^xsd:string</para>
    ///   <para>rdfs:label : MenuSection^^xsd:string</para>
    ///   <a href="http://schema.org/MenuSection">schema:MenuSection</a>
    /// </summary>
    let MenuSection = _prefixId.prefix "MenuSection"
    /// <summary>
    ///   <para>rdfs:label : Message^^xsd:string</para>
    ///   <para>rdfs:comment : A single message from a sender to one or more organizations or people.^^xsd:string</para>
    ///   <a href="http://schema.org/Message">schema:Message</a>
    /// </summary>
    let Message = _prefixId.prefix "Message"
    /// <summary>
    ///   <para>rdfs:comment : A middle school (typically for children aged around 11-14, although this varies somewhat).^^xsd:string</para>
    ///   <para>rdfs:label : MiddleSchool^^xsd:string</para>
    ///   <a href="http://schema.org/MiddleSchool">schema:MiddleSchool</a>
    /// </summary>
    let MiddleSchool = _prefixId.prefix "MiddleSchool"
    let MixtapeAlbum = _prefixId.prefix "MixtapeAlbum"
    /// <summary>
    ///   <para>rdfs:comment : A software application designed specifically to work well on a mobile device such as a telephone.^^xsd:string</para>
    ///   <para>rdfs:label : MobileApplication^^xsd:string</para>
    ///   <a href="http://schema.org/MobileApplication">schema:MobileApplication</a>
    /// </summary>
    let MobileApplication = _prefixId.prefix "MobileApplication"
    /// <summary>
    ///   <para>rdfs:comment : A store that sells mobile phones and related accessories.^^xsd:string</para>
    ///   <para>rdfs:label : MobilePhoneStore^^xsd:string</para>
    ///   <a href="http://schema.org/MobilePhoneStore">schema:MobilePhoneStore</a>
    /// </summary>
    let MobilePhoneStore = _prefixId.prefix "MobilePhoneStore"
    let Monday = _prefixId.prefix "Monday"
    /// <summary>
    ///   <para>rdfs:label : MonetaryAmount^^xsd:string</para>
    ///   <para>rdfs:comment : A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc. It is recommended to use &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; Types to describe the price of an Offer, Invoice, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/MonetaryAmount">schema:MonetaryAmount</a>
    /// </summary>
    let MonetaryAmount = _prefixId.prefix "MonetaryAmount"
    /// <summary>
    ///   <para>rdfs:comment : A statistical distribution of monetary amounts.^^xsd:string</para>
    ///   <para>rdfs:label : MonetaryAmountDistribution^^xsd:string</para>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <a href="http://schema.org/MonetaryAmountDistribution">schema:MonetaryAmountDistribution</a>
    /// </summary>
    let MonetaryAmountDistribution = _prefixId.prefix "MonetaryAmountDistribution"
    let MonetaryGrant = _prefixId.prefix "MonetaryGrant"
    let MoneyTransfer = _prefixId.prefix "MoneyTransfer"
    /// <summary>
    ///   <para>rdfs:comment : A mosque.^^xsd:string</para>
    ///   <para>rdfs:label : Mosque^^xsd:string</para>
    ///   <a href="http://schema.org/Mosque">schema:Mosque</a>
    /// </summary>
    let Mosque = _prefixId.prefix "Mosque"
    /// <summary>
    ///   <para>rdfs:comment : A motel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Motel^^xsd:string</para>
    ///   <a href="http://schema.org/Motel">schema:Motel</a>
    /// </summary>
    let Motel = _prefixId.prefix "Motel"
    /// <summary>
    ///   <para>rdfs:comment : A motorcycle dealer.^^xsd:string</para>
    ///   <para>rdfs:label : MotorcycleDealer^^xsd:string</para>
    ///   <a href="http://schema.org/MotorcycleDealer">schema:MotorcycleDealer</a>
    /// </summary>
    let MotorcycleDealer = _prefixId.prefix "MotorcycleDealer"
    /// <summary>
    ///   <para>rdfs:label : MotorcycleRepair^^xsd:string</para>
    ///   <para>rdfs:comment : A motorcycle repair shop.^^xsd:string</para>
    ///   <a href="http://schema.org/MotorcycleRepair">schema:MotorcycleRepair</a>
    /// </summary>
    let MotorcycleRepair = _prefixId.prefix "MotorcycleRepair"
    /// <summary>
    ///   <para>rdfs:comment : A mountain, like Mount Whitney or Mount Everest.^^xsd:string</para>
    ///   <para>rdfs:label : Mountain^^xsd:string</para>
    ///   <a href="http://schema.org/Mountain">schema:Mountain</a>
    /// </summary>
    let Mountain = _prefixId.prefix "Mountain"
    /// <summary>
    ///   <para>rdfs:label : MoveAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of an agent relocating to a place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TransferAction"&gt;TransferAction&lt;/a&gt;: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/MoveAction">schema:MoveAction</a>
    /// </summary>
    let MoveAction = _prefixId.prefix "MoveAction"
    /// <summary>
    ///   <para>rdfs:comment : A movie.^^xsd:string</para>
    ///   <para>rdfs:label : Movie^^xsd:string</para>
    ///   <a href="http://schema.org/Movie">schema:Movie</a>
    /// </summary>
    let Movie = _prefixId.prefix "Movie"
    /// <summary>
    ///   <para>rdfs:label : MovieClip^^xsd:string</para>
    ///   <para>rdfs:comment : A short segment/part of a movie.^^xsd:string</para>
    ///   <a href="http://schema.org/MovieClip">schema:MovieClip</a>
    /// </summary>
    let MovieClip = _prefixId.prefix "MovieClip"
    /// <summary>
    ///   <para>rdfs:comment : A movie rental store.^^xsd:string</para>
    ///   <para>rdfs:label : MovieRentalStore^^xsd:string</para>
    ///   <a href="http://schema.org/MovieRentalStore">schema:MovieRentalStore</a>
    /// </summary>
    let MovieRentalStore = _prefixId.prefix "MovieRentalStore"
    /// <summary>
    ///   <para>rdfs:label : MovieSeries^^xsd:string</para>
    ///   <para>rdfs:comment : A series of movies. Included movies can be indicated with the hasPart property.^^xsd:string</para>
    ///   <a href="http://schema.org/MovieSeries">schema:MovieSeries</a>
    /// </summary>
    let MovieSeries = _prefixId.prefix "MovieSeries"
    /// <summary>
    ///   <para>rdfs:comment : A movie theater.^^xsd:string</para>
    ///   <para>rdfs:label : MovieTheater^^xsd:string</para>
    ///   <a href="http://schema.org/MovieTheater">schema:MovieTheater</a>
    /// </summary>
    let MovieTheater = _prefixId.prefix "MovieTheater"
    /// <summary>
    ///   <para>rdfs:comment : A moving company.^^xsd:string</para>
    ///   <para>rdfs:label : MovingCompany^^xsd:string</para>
    ///   <a href="http://schema.org/MovingCompany">schema:MovingCompany</a>
    /// </summary>
    let MovingCompany = _prefixId.prefix "MovingCompany"
    let MultiPlayer = _prefixId.prefix "MultiPlayer"
    /// <summary>
    ///   <para>rdfs:comment : A museum.^^xsd:string</para>
    ///   <para>rdfs:label : Museum^^xsd:string</para>
    ///   <a href="http://schema.org/Museum">schema:Museum</a>
    /// </summary>
    let Museum = _prefixId.prefix "Museum"
    /// <summary>
    ///   <para>rdfs:label : MusicAlbum^^xsd:string</para>
    ///   <para>rdfs:comment : A collection of music tracks.^^xsd:string</para>
    ///   <a href="http://schema.org/MusicAlbum">schema:MusicAlbum</a>
    /// </summary>
    let MusicAlbum = _prefixId.prefix "MusicAlbum"
    /// <summary>
    ///   <para>rdfs:label : MusicAlbumProductionType^^xsd:string</para>
    ///   <para>rdfs:comment : Classification of the album by it's type of content: soundtrack, live album, studio album, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/MusicAlbumProductionType">schema:MusicAlbumProductionType</a>
    /// </summary>
    let MusicAlbumProductionType = _prefixId.prefix "MusicAlbumProductionType"
    /// <summary>
    ///   <para>rdfs:comment : The kind of release which this album is: single, EP or album.^^xsd:string</para>
    ///   <para>rdfs:label : MusicAlbumReleaseType^^xsd:string</para>
    ///   <a href="http://schema.org/MusicAlbumReleaseType">schema:MusicAlbumReleaseType</a>
    /// </summary>
    let MusicAlbumReleaseType = _prefixId.prefix "MusicAlbumReleaseType"
    /// <summary>
    ///   <para>rdfs:comment : A musical composition.^^xsd:string</para>
    ///   <para>rdfs:label : MusicComposition^^xsd:string</para>
    ///   <a href="http://schema.org/MusicComposition">schema:MusicComposition</a>
    /// </summary>
    let MusicComposition = _prefixId.prefix "MusicComposition"
    /// <summary>
    ///   <para>rdfs:comment : Event type: Music event.^^xsd:string</para>
    ///   <para>rdfs:label : MusicEvent^^xsd:string</para>
    ///   <a href="http://schema.org/MusicEvent">schema:MusicEvent</a>
    /// </summary>
    let MusicEvent = _prefixId.prefix "MusicEvent"
    /// <summary>
    ///   <para>rdfs:label : MusicGroup^^xsd:string</para>
    ///   <para>rdfs:comment : A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.^^xsd:string</para>
    ///   <a href="http://schema.org/MusicGroup">schema:MusicGroup</a>
    /// </summary>
    let MusicGroup = _prefixId.prefix "MusicGroup"
    /// <summary>
    ///   <para>rdfs:comment : A collection of music tracks in playlist form.^^xsd:string</para>
    ///   <para>rdfs:label : MusicPlaylist^^xsd:string</para>
    ///   <a href="http://schema.org/MusicPlaylist">schema:MusicPlaylist</a>
    /// </summary>
    let MusicPlaylist = _prefixId.prefix "MusicPlaylist"
    /// <summary>
    ///   <para>rdfs:comment : A music recording (track), usually a single song.^^xsd:string</para>
    ///   <para>rdfs:label : MusicRecording^^xsd:string</para>
    ///   <a href="http://schema.org/MusicRecording">schema:MusicRecording</a>
    /// </summary>
    let MusicRecording = _prefixId.prefix "MusicRecording"
    /// <summary>
    ///   <para>rdfs:comment : A MusicRelease is a specific release of a music album.^^xsd:string</para>
    ///   <para>rdfs:label : MusicRelease^^xsd:string</para>
    ///   <a href="http://schema.org/MusicRelease">schema:MusicRelease</a>
    /// </summary>
    let MusicRelease = _prefixId.prefix "MusicRelease"
    /// <summary>
    ///   <para>rdfs:label : MusicReleaseFormatType^^xsd:string</para>
    ///   <para>rdfs:comment : Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).^^xsd:string</para>
    ///   <a href="http://schema.org/MusicReleaseFormatType">schema:MusicReleaseFormatType</a>
    /// </summary>
    let MusicReleaseFormatType = _prefixId.prefix "MusicReleaseFormatType"
    /// <summary>
    ///   <para>rdfs:label : MusicStore^^xsd:string</para>
    ///   <para>rdfs:comment : A music store.^^xsd:string</para>
    ///   <a href="http://schema.org/MusicStore">schema:MusicStore</a>
    /// </summary>
    let MusicStore = _prefixId.prefix "MusicStore"
    /// <summary>
    ///   <para>rdfs:label : MusicVenue^^xsd:string</para>
    ///   <para>rdfs:comment : A music venue.^^xsd:string</para>
    ///   <a href="http://schema.org/MusicVenue">schema:MusicVenue</a>
    /// </summary>
    let MusicVenue = _prefixId.prefix "MusicVenue"
    /// <summary>
    ///   <para>rdfs:label : MusicVideoObject^^xsd:string</para>
    ///   <para>rdfs:comment : A music video file.^^xsd:string</para>
    ///   <a href="http://schema.org/MusicVideoObject">schema:MusicVideoObject</a>
    /// </summary>
    let MusicVideoObject = _prefixId.prefix "MusicVideoObject"
    /// <summary>
    ///   <para>rdfs:comment : Organization: Non-governmental Organization.^^xsd:string</para>
    ///   <para>rdfs:label : NGO^^xsd:string</para>
    ///   <a href="http://schema.org/NGO">schema:NGO</a>
    /// </summary>
    let NGO = _prefixId.prefix "NGO"
    /// <summary>
    ///   <para>rdfs:comment : A nail salon.^^xsd:string</para>
    ///   <para>rdfs:label : NailSalon^^xsd:string</para>
    ///   <a href="http://schema.org/NailSalon">schema:NailSalon</a>
    /// </summary>
    let NailSalon = _prefixId.prefix "NailSalon"
    let NewCondition = _prefixId.prefix "NewCondition"
    /// <summary>
    ///   <para>rdfs:comment : A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.&lt;br/&gt;&lt;br/&gt;
    ///
    /// A more detailed overview of &lt;a href="/docs/news.html"&gt;schema.org News markup&lt;/a&gt; is also available.^^xsd:string</para>
    ///   <para>rdfs:label : NewsArticle^^xsd:string</para>
    ///   <a href="http://schema.org/NewsArticle">schema:NewsArticle</a>
    /// </summary>
    let NewsArticle = _prefixId.prefix "NewsArticle"
    /// <summary>
    ///   <para>rdfs:comment : A nightclub or discotheque.^^xsd:string</para>
    ///   <para>rdfs:label : NightClub^^xsd:string</para>
    ///   <a href="http://schema.org/NightClub">schema:NightClub</a>
    /// </summary>
    let NightClub = _prefixId.prefix "NightClub"
    /// <summary>
    ///   <para>rdfs:label : Notary^^xsd:string</para>
    ///   <para>rdfs:comment : A notary.^^xsd:string</para>
    ///   <a href="http://schema.org/Notary">schema:Notary</a>
    /// </summary>
    let Notary = _prefixId.prefix "Notary"
    /// <summary>
    ///   <para>rdfs:comment : A file containing a note, primarily for the author.^^xsd:string</para>
    ///   <para>rdfs:label : NoteDigitalDocument^^xsd:string</para>
    ///   <a href="http://schema.org/NoteDigitalDocument">schema:NoteDigitalDocument</a>
    /// </summary>
    let NoteDigitalDocument = _prefixId.prefix "NoteDigitalDocument"
    /// <summary>
    ///   <para>rdfs:comment : Data type: Number.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : Number^^xsd:string</para>
    ///   <a href="http://schema.org/Number">schema:Number</a>
    /// </summary>
    let Number = _prefixId.prefix "Number"
    /// <summary>
    ///   <para>rdfs:label : NutritionInformation^^xsd:string</para>
    ///   <para>rdfs:comment : Nutritional information about the recipe.^^xsd:string</para>
    ///   <a href="http://schema.org/NutritionInformation">schema:NutritionInformation</a>
    /// </summary>
    let NutritionInformation = _prefixId.prefix "NutritionInformation"
    /// <summary>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:label : Occupation^^xsd:string</para>
    ///   <para>rdfs:comment : A profession, may involve prolonged training and/or a formal qualification.^^xsd:string</para>
    ///   <a href="http://schema.org/Occupation">schema:Occupation</a>
    /// </summary>
    let Occupation = _prefixId.prefix "Occupation"
    /// <summary>
    ///   <para>rdfs:comment : An ocean (for example, the Pacific).^^xsd:string</para>
    ///   <para>rdfs:label : OceanBodyOfWater^^xsd:string</para>
    ///   <a href="http://schema.org/OceanBodyOfWater">schema:OceanBodyOfWater</a>
    /// </summary>
    let OceanBodyOfWater = _prefixId.prefix "OceanBodyOfWater"
    /// <summary>
    ///   <para>rdfs:comment : An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: As the &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; property, which identifies the form of offer (e.g. sell, lease, repair, dispose), defaults to http://purl.org/goodrelations/v1#Sell; an Offer without a defined businessFunction value can be assumed to be an offer to sell.&lt;br/&gt;&lt;br/&gt;
    ///
    /// For &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GTIN&lt;/a&gt;-related fields, see &lt;a href="http://www.gs1.org/barcodes/support/check_digit_calculator"&gt;Check Digit calculator&lt;/a&gt; and &lt;a href="http://www.gs1us.org/resources/standards/gtin-validation-guide"&gt;validation guide&lt;/a&gt; from &lt;a href="http://www.gs1.org/"&gt;GS1&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Offer^^xsd:string</para>
    ///   <a href="http://schema.org/Offer">schema:Offer</a>
    /// </summary>
    let Offer = _prefixId.prefix "Offer"
    /// <summary>
    ///   <para>rdfs:label : OfferCatalog^^xsd:string</para>
    ///   <para>rdfs:comment : An OfferCatalog is an ItemList that contains related Offers and/or further OfferCatalogs that are offeredBy the same provider.^^xsd:string</para>
    ///   <a href="http://schema.org/OfferCatalog">schema:OfferCatalog</a>
    /// </summary>
    let OfferCatalog = _prefixId.prefix "OfferCatalog"
    /// <summary>
    ///   <para>rdfs:label : OfferItemCondition^^xsd:string</para>
    ///   <para>rdfs:comment : A list of possible conditions for the item.^^xsd:string</para>
    ///   <a href="http://schema.org/OfferItemCondition">schema:OfferItemCondition</a>
    /// </summary>
    let OfferItemCondition = _prefixId.prefix "OfferItemCondition"
    /// <summary>
    ///   <para>rdfs:comment : An office equipment store.^^xsd:string</para>
    ///   <para>rdfs:label : OfficeEquipmentStore^^xsd:string</para>
    ///   <a href="http://schema.org/OfficeEquipmentStore">schema:OfficeEquipmentStore</a>
    /// </summary>
    let OfficeEquipmentStore = _prefixId.prefix "OfficeEquipmentStore"
    let OfflinePermanently = _prefixId.prefix "OfflinePermanently"
    let OfflineTemporarily = _prefixId.prefix "OfflineTemporarily"
    /// <summary>
    ///   <para>rdfs:label : OnDemandEvent^^xsd:string</para>
    ///   <para>rdfs:comment : A publication event e.g. catch-up TV or radio podcast, during which a program is available on-demand.^^xsd:string</para>
    ///   <a href="http://schema.org/OnDemandEvent">schema:OnDemandEvent</a>
    /// </summary>
    let OnDemandEvent = _prefixId.prefix "OnDemandEvent"
    let OnSitePickup = _prefixId.prefix "OnSitePickup"
    let Online = _prefixId.prefix "Online"
    let OnlineFull = _prefixId.prefix "OnlineFull"
    let OnlineOnly = _prefixId.prefix "OnlineOnly"
    /// <summary>
    ///   <para>rdfs:label : OpeningHoursSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;br/&gt;&lt;br/&gt;
    ///
    /// If the value for the &lt;a class="localLink" href="http://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.^^xsd:string</para>
    ///   <a href="http://schema.org/OpeningHoursSpecification">schema:OpeningHoursSpecification</a>
    /// </summary>
    let OpeningHoursSpecification = _prefixId.prefix "OpeningHoursSpecification"
    /// <summary>
    ///   <para>rdfs:comment : An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.^^xsd:string</para>
    ///   <para>rdfs:label : Order^^xsd:string</para>
    ///   <a href="http://schema.org/Order">schema:Order</a>
    /// </summary>
    let Order = _prefixId.prefix "Order"
    /// <summary>
    ///   <para>rdfs:comment : An agent orders an object/product/service to be delivered/sent.^^xsd:string</para>
    ///   <para>rdfs:label : OrderAction^^xsd:string</para>
    ///   <a href="http://schema.org/OrderAction">schema:OrderAction</a>
    /// </summary>
    let OrderAction = _prefixId.prefix "OrderAction"
    let OrderCancelled = _prefixId.prefix "OrderCancelled"
    let OrderDelivered = _prefixId.prefix "OrderDelivered"
    let OrderInTransit = _prefixId.prefix "OrderInTransit"
    /// <summary>
    ///   <para>rdfs:comment : An order item is a line of an order. It includes the quantity and shipping details of a bought offer.^^xsd:string</para>
    ///   <para>rdfs:label : OrderItem^^xsd:string</para>
    ///   <a href="http://schema.org/OrderItem">schema:OrderItem</a>
    /// </summary>
    let OrderItem = _prefixId.prefix "OrderItem"
    let OrderPaymentDue = _prefixId.prefix "OrderPaymentDue"
    let OrderPickupAvailable = _prefixId.prefix "OrderPickupAvailable"
    let OrderProblem = _prefixId.prefix "OrderProblem"
    let OrderProcessing = _prefixId.prefix "OrderProcessing"
    let OrderReturned = _prefixId.prefix "OrderReturned"
    /// <summary>
    ///   <para>rdfs:label : OrderStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Enumerated status values for Order.^^xsd:string</para>
    ///   <a href="http://schema.org/OrderStatus">schema:OrderStatus</a>
    /// </summary>
    let OrderStatus = _prefixId.prefix "OrderStatus"
    /// <summary>
    ///   <para>rdfs:label : Organization^^xsd:string</para>
    ///   <para>rdfs:comment : An organization such as a school, NGO, corporation, club, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/Organization">schema:Organization</a>
    /// </summary>
    let Organization = _prefixId.prefix "Organization"
    /// <summary>
    ///   <para>rdfs:comment : A subclass of Role used to describe roles within organizations.^^xsd:string</para>
    ///   <para>rdfs:label : OrganizationRole^^xsd:string</para>
    ///   <a href="http://schema.org/OrganizationRole">schema:OrganizationRole</a>
    /// </summary>
    let OrganizationRole = _prefixId.prefix "OrganizationRole"
    /// <summary>
    ///   <para>rdfs:comment : The act of manipulating/administering/supervising/controlling one or more objects.^^xsd:string</para>
    ///   <para>rdfs:label : OrganizeAction^^xsd:string</para>
    ///   <a href="http://schema.org/OrganizeAction">schema:OrganizeAction</a>
    /// </summary>
    let OrganizeAction = _prefixId.prefix "OrganizeAction"
    let OutOfStock = _prefixId.prefix "OutOfStock"
    /// <summary>
    ///   <para>rdfs:comment : An outlet store.^^xsd:string</para>
    ///   <para>rdfs:label : OutletStore^^xsd:string</para>
    ///   <a href="http://schema.org/OutletStore">schema:OutletStore</a>
    /// </summary>
    let OutletStore = _prefixId.prefix "OutletStore"
    /// <summary>
    ///   <para>rdfs:comment : A structured value providing information about when a certain organization or person owned a certain product.^^xsd:string</para>
    ///   <para>rdfs:label : OwnershipInfo^^xsd:string</para>
    ///   <a href="http://schema.org/OwnershipInfo">schema:OwnershipInfo</a>
    /// </summary>
    let OwnershipInfo = _prefixId.prefix "OwnershipInfo"
    /// <summary>
    ///   <para>rdfs:label : PaintAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of producing a painting, typically with paint and canvas as instruments.^^xsd:string</para>
    ///   <a href="http://schema.org/PaintAction">schema:PaintAction</a>
    /// </summary>
    let PaintAction = _prefixId.prefix "PaintAction"
    /// <summary>
    ///   <para>rdfs:comment : A painting.^^xsd:string</para>
    ///   <para>rdfs:label : Painting^^xsd:string</para>
    ///   <a href="http://schema.org/Painting">schema:Painting</a>
    /// </summary>
    let Painting = _prefixId.prefix "Painting"
    let Paperback = _prefixId.prefix "Paperback"
    /// <summary>
    ///   <para>rdfs:label : ParcelDelivery^^xsd:string</para>
    ///   <para>rdfs:comment : The delivery of a parcel either via the postal service or a commercial service.^^xsd:string</para>
    ///   <a href="http://schema.org/ParcelDelivery">schema:ParcelDelivery</a>
    /// </summary>
    let ParcelDelivery = _prefixId.prefix "ParcelDelivery"
    /// <summary>
    ///   <para>rdfs:comment : A private parcel service as the delivery mode available for a certain offer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DHL&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#FederalExpress&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#UPS&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : ParcelService^^xsd:string</para>
    ///   <a href="http://schema.org/ParcelService">schema:ParcelService</a>
    /// </summary>
    let ParcelService = _prefixId.prefix "ParcelService"
    /// <summary>
    ///   <para>rdfs:comment : A set of characteristics describing parents, who can be interested in viewing some content.^^xsd:string</para>
    ///   <para>rdfs:label : ParentAudience^^xsd:string</para>
    ///   <a href="http://schema.org/ParentAudience">schema:ParentAudience</a>
    /// </summary>
    let ParentAudience = _prefixId.prefix "ParentAudience"
    /// <summary>
    ///   <para>rdfs:comment : A park.^^xsd:string</para>
    ///   <para>rdfs:label : Park^^xsd:string</para>
    ///   <a href="http://schema.org/Park">schema:Park</a>
    /// </summary>
    let Park = _prefixId.prefix "Park"
    /// <summary>
    ///   <para>rdfs:label : ParkingFacility^^xsd:string</para>
    ///   <para>rdfs:comment : A parking lot or other parking facility.^^xsd:string</para>
    ///   <a href="http://schema.org/ParkingFacility">schema:ParkingFacility</a>
    /// </summary>
    let ParkingFacility = _prefixId.prefix "ParkingFacility"
    let ParkingMap = _prefixId.prefix "ParkingMap"
    /// <summary>
    ///   <para>rdfs:label : PawnShop^^xsd:string</para>
    ///   <para>rdfs:comment : A shop that will buy, or lend money against the security of, personal possessions.^^xsd:string</para>
    ///   <a href="http://schema.org/PawnShop">schema:PawnShop</a>
    /// </summary>
    let PawnShop = _prefixId.prefix "PawnShop"
    /// <summary>
    ///   <para>rdfs:comment : An agent pays a price to a participant.^^xsd:string</para>
    ///   <para>rdfs:label : PayAction^^xsd:string</para>
    ///   <a href="http://schema.org/PayAction">schema:PayAction</a>
    /// </summary>
    let PayAction = _prefixId.prefix "PayAction"
    let PaymentAutomaticallyApplied = _prefixId.prefix "PaymentAutomaticallyApplied"
    /// <summary>
    ///   <para>rdfs:label : PaymentCard^^xsd:string</para>
    ///   <para>rdfs:comment : A payment method using a credit, debit, store or other card to associate the payment with an account.^^xsd:string</para>
    ///   <a href="http://schema.org/PaymentCard">schema:PaymentCard</a>
    /// </summary>
    let PaymentCard = _prefixId.prefix "PaymentCard"
    /// <summary>
    ///   <para>rdfs:comment : The costs of settling the payment using a particular payment method.^^xsd:string</para>
    ///   <para>rdfs:label : PaymentChargeSpecification^^xsd:string</para>
    ///   <a href="http://schema.org/PaymentChargeSpecification">schema:PaymentChargeSpecification</a>
    /// </summary>
    let PaymentChargeSpecification = _prefixId.prefix "PaymentChargeSpecification"
    let PaymentComplete = _prefixId.prefix "PaymentComplete"
    let PaymentDeclined = _prefixId.prefix "PaymentDeclined"
    let PaymentDue = _prefixId.prefix "PaymentDue"
    /// <summary>
    ///   <para>rdfs:label : PaymentMethod^^xsd:string</para>
    ///   <para>rdfs:comment : A payment method is a standardized procedure for transferring the monetary amount for a purchase. Payment methods are characterized by the legal and technical structures used, and by the organization or group carrying out the transaction.&lt;br/&gt;&lt;br/&gt;
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
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/PaymentMethod">schema:PaymentMethod</a>
    /// </summary>
    let PaymentMethod = _prefixId.prefix "PaymentMethod"
    let PaymentPastDue = _prefixId.prefix "PaymentPastDue"
    /// <summary>
    ///   <para>rdfs:comment : A Service to transfer funds from a person or organization to a beneficiary person or organization.^^xsd:string</para>
    ///   <para>rdfs:label : PaymentService^^xsd:string</para>
    ///   <a href="http://schema.org/PaymentService">schema:PaymentService</a>
    /// </summary>
    let PaymentService = _prefixId.prefix "PaymentService"
    /// <summary>
    ///   <para>rdfs:label : PaymentStatusType^^xsd:string</para>
    ///   <para>rdfs:comment : A specific payment status. For example, PaymentDue, PaymentComplete, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/PaymentStatusType">schema:PaymentStatusType</a>
    /// </summary>
    let PaymentStatusType = _prefixId.prefix "PaymentStatusType"
    /// <summary>
    ///   <para>rdfs:comment : A set of characteristics belonging to people, e.g. who compose an item's target audience.^^xsd:string</para>
    ///   <para>rdfs:label : PeopleAudience^^xsd:string</para>
    ///   <a href="http://schema.org/PeopleAudience">schema:PeopleAudience</a>
    /// </summary>
    let PeopleAudience = _prefixId.prefix "PeopleAudience"
    /// <summary>
    ///   <para>rdfs:comment : The act of participating in performance arts.^^xsd:string</para>
    ///   <para>rdfs:label : PerformAction^^xsd:string</para>
    ///   <a href="http://schema.org/PerformAction">schema:PerformAction</a>
    /// </summary>
    let PerformAction = _prefixId.prefix "PerformAction"
    /// <summary>
    ///   <para>rdfs:comment : A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.^^xsd:string</para>
    ///   <para>rdfs:label : PerformanceRole^^xsd:string</para>
    ///   <a href="http://schema.org/PerformanceRole">schema:PerformanceRole</a>
    /// </summary>
    let PerformanceRole = _prefixId.prefix "PerformanceRole"
    /// <summary>
    ///   <para>rdfs:label : PerformingArtsTheater^^xsd:string</para>
    ///   <para>rdfs:comment : A theater or other performing art center.^^xsd:string</para>
    ///   <a href="http://schema.org/PerformingArtsTheater">schema:PerformingArtsTheater</a>
    /// </summary>
    let PerformingArtsTheater = _prefixId.prefix "PerformingArtsTheater"
    /// <summary>
    ///   <para>rdfs:comment : A performance group, such as a band, an orchestra, or a circus.^^xsd:string</para>
    ///   <para>rdfs:label : PerformingGroup^^xsd:string</para>
    ///   <a href="http://schema.org/PerformingGroup">schema:PerformingGroup</a>
    /// </summary>
    let PerformingGroup = _prefixId.prefix "PerformingGroup"
    /// <summary>
    ///   <para>rdfs:label : Periodical^^xsd:string</para>
    ///   <para>rdfs:comment : A publication in any medium issued in successive parts bearing numerical or chronological designations and intended, such as a magazine, scholarly journal, or newspaper to continue indefinitely.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/Periodical">schema:Periodical</a>
    /// </summary>
    let Periodical = _prefixId.prefix "Periodical"
    /// <summary>
    ///   <para>rdfs:comment : A permit issued by an organization, e.g. a parking pass.^^xsd:string</para>
    ///   <para>rdfs:label : Permit^^xsd:string</para>
    ///   <a href="http://schema.org/Permit">schema:Permit</a>
    /// </summary>
    let Permit = _prefixId.prefix "Permit"
    /// <summary>
    ///   <para>rdfs:label : Person^^xsd:string</para>
    ///   <para>rdfs:comment : A person (alive, dead, undead, or fictional).^^xsd:string</para>
    ///   <a href="http://schema.org/Person">schema:Person</a>
    /// </summary>
    let Person = _prefixId.prefix "Person"
    /// <summary>
    ///   <para>rdfs:label : PetStore^^xsd:string</para>
    ///   <para>rdfs:comment : A pet store.^^xsd:string</para>
    ///   <a href="http://schema.org/PetStore">schema:PetStore</a>
    /// </summary>
    let PetStore = _prefixId.prefix "PetStore"
    /// <summary>
    ///   <para>rdfs:comment : A pharmacy or drugstore.^^xsd:string</para>
    ///   <para>rdfs:label : Pharmacy^^xsd:string</para>
    ///   <a href="http://schema.org/Pharmacy">schema:Pharmacy</a>
    /// </summary>
    let Pharmacy = _prefixId.prefix "Pharmacy"
    /// <summary>
    ///   <para>rdfs:comment : A photograph.^^xsd:string</para>
    ///   <para>rdfs:label : Photograph^^xsd:string</para>
    ///   <a href="http://schema.org/Photograph">schema:Photograph</a>
    /// </summary>
    let Photograph = _prefixId.prefix "Photograph"
    /// <summary>
    ///   <para>rdfs:label : PhotographAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of capturing still images of objects using a camera.^^xsd:string</para>
    ///   <a href="http://schema.org/PhotographAction">schema:PhotographAction</a>
    /// </summary>
    let PhotographAction = _prefixId.prefix "PhotographAction"
    let PhysicalActivity = _prefixId.prefix "PhysicalActivity"
    let PhysicalActivityCategory = _prefixId.prefix "PhysicalActivityCategory"
    /// <summary>
    ///   <para>rdfs:comment : A doctor's office.^^xsd:string</para>
    ///   <para>rdfs:label : Physician^^xsd:string</para>
    ///   <a href="http://schema.org/Physician">schema:Physician</a>
    /// </summary>
    let Physician = _prefixId.prefix "Physician"
    /// <summary>
    ///   <para>rdfs:comment : Entities that have a somewhat fixed, physical extension.^^xsd:string</para>
    ///   <para>rdfs:label : Place^^xsd:string</para>
    ///   <a href="http://schema.org/Place">schema:Place</a>
    /// </summary>
    let Place = _prefixId.prefix "Place"
    /// <summary>
    ///   <para>rdfs:label : PlaceOfWorship^^xsd:string</para>
    ///   <para>rdfs:comment : Place of worship, such as a church, synagogue, or mosque.^^xsd:string</para>
    ///   <a href="http://schema.org/PlaceOfWorship">schema:PlaceOfWorship</a>
    /// </summary>
    let PlaceOfWorship = _prefixId.prefix "PlaceOfWorship"
    /// <summary>
    ///   <para>rdfs:comment : The act of planning the execution of an event/task/action/reservation/plan to a future date.^^xsd:string</para>
    ///   <para>rdfs:label : PlanAction^^xsd:string</para>
    ///   <a href="http://schema.org/PlanAction">schema:PlanAction</a>
    /// </summary>
    let PlanAction = _prefixId.prefix "PlanAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ListenAction"&gt;ListenAction&lt;/a&gt;: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/WatchAction"&gt;WatchAction&lt;/a&gt;: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : PlayAction^^xsd:string</para>
    ///   <a href="http://schema.org/PlayAction">schema:PlayAction</a>
    /// </summary>
    let PlayAction = _prefixId.prefix "PlayAction"
    /// <summary>
    ///   <para>rdfs:comment : A playground.^^xsd:string</para>
    ///   <para>rdfs:label : Playground^^xsd:string</para>
    ///   <a href="http://schema.org/Playground">schema:Playground</a>
    /// </summary>
    let Playground = _prefixId.prefix "Playground"
    /// <summary>
    ///   <para>rdfs:label : Plumber^^xsd:string</para>
    ///   <para>rdfs:comment : A plumbing service.^^xsd:string</para>
    ///   <a href="http://schema.org/Plumber">schema:Plumber</a>
    /// </summary>
    let Plumber = _prefixId.prefix "Plumber"
    /// <summary>
    ///   <para>rdfs:label : PoliceStation^^xsd:string</para>
    ///   <para>rdfs:comment : A police station.^^xsd:string</para>
    ///   <a href="http://schema.org/PoliceStation">schema:PoliceStation</a>
    /// </summary>
    let PoliceStation = _prefixId.prefix "PoliceStation"
    /// <summary>
    ///   <para>rdfs:comment : A pond.^^xsd:string</para>
    ///   <para>rdfs:label : Pond^^xsd:string</para>
    ///   <a href="http://schema.org/Pond">schema:Pond</a>
    /// </summary>
    let Pond = _prefixId.prefix "Pond"
    /// <summary>
    ///   <para>rdfs:comment : A post office.^^xsd:string</para>
    ///   <para>rdfs:label : PostOffice^^xsd:string</para>
    ///   <a href="http://schema.org/PostOffice">schema:PostOffice</a>
    /// </summary>
    let PostOffice = _prefixId.prefix "PostOffice"
    /// <summary>
    ///   <para>rdfs:label : PostalAddress^^xsd:string</para>
    ///   <para>rdfs:comment : The mailing address.^^xsd:string</para>
    ///   <a href="http://schema.org/PostalAddress">schema:PostalAddress</a>
    /// </summary>
    let PostalAddress = _prefixId.prefix "PostalAddress"
    let PotentialActionStatus = _prefixId.prefix "PotentialActionStatus"
    let PreOrder = _prefixId.prefix "PreOrder"
    /// <summary>
    ///   <para>schema:category : issue-1125^^xsd:string</para>
    ///   <para>rdfs:label : PreOrderAction^^xsd:string</para>
    ///   <para>rdfs:comment : An agent orders a (not yet released) object/product/service to be delivered/sent.^^xsd:string</para>
    ///   <a href="http://schema.org/PreOrderAction">schema:PreOrderAction</a>
    /// </summary>
    let PreOrderAction = _prefixId.prefix "PreOrderAction"
    let PreSale = _prefixId.prefix "PreSale"
    /// <summary>
    ///   <para>rdfs:comment : The act of inserting at the beginning if an ordered collection.^^xsd:string</para>
    ///   <para>rdfs:label : PrependAction^^xsd:string</para>
    ///   <a href="http://schema.org/PrependAction">schema:PrependAction</a>
    /// </summary>
    let PrependAction = _prefixId.prefix "PrependAction"
    /// <summary>
    ///   <para>rdfs:comment : A preschool.^^xsd:string</para>
    ///   <para>rdfs:label : Preschool^^xsd:string</para>
    ///   <a href="http://schema.org/Preschool">schema:Preschool</a>
    /// </summary>
    let Preschool = _prefixId.prefix "Preschool"
    /// <summary>
    ///   <para>rdfs:label : PresentationDigitalDocument^^xsd:string</para>
    ///   <para>rdfs:comment : A file containing slides or used for a presentation.^^xsd:string</para>
    ///   <a href="http://schema.org/PresentationDigitalDocument">schema:PresentationDigitalDocument</a>
    /// </summary>
    let PresentationDigitalDocument = _prefixId.prefix "PresentationDigitalDocument"
    /// <summary>
    ///   <para>rdfs:label : PriceSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt; to describe independent amounts of money such as a salary, credit card limits, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/PriceSpecification">schema:PriceSpecification</a>
    /// </summary>
    let PriceSpecification = _prefixId.prefix "PriceSpecification"
    /// <summary>
    ///   <para>rdfs:label : Product^^xsd:string</para>
    ///   <para>rdfs:comment : Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.^^xsd:string</para>
    ///   <a href="http://schema.org/Product">schema:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    /// <summary>
    ///   <para>rdfs:label : ProductModel^^xsd:string</para>
    ///   <para>rdfs:comment : A datasheet or vendor specification of a product (in the sense of a prototypical description).^^xsd:string</para>
    ///   <a href="http://schema.org/ProductModel">schema:ProductModel</a>
    /// </summary>
    let ProductModel = _prefixId.prefix "ProductModel"
    /// <summary>
    ///   <para>rdfs:comment : Original definition: "provider of professional services."&lt;br/&gt;&lt;br/&gt;
    ///
    /// The general &lt;a class="localLink" href="http://schema.org/ProfessionalService"&gt;ProfessionalService&lt;/a&gt; type for local businesses was deprecated due to confusion with &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;. For reference, the types that it included were: &lt;a class="localLink" href="http://schema.org/Dentist"&gt;Dentist&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/AccountingService"&gt;AccountingService&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Notary"&gt;Notary&lt;/a&gt;, as well as types for several kinds of &lt;a class="localLink" href="http://schema.org/HomeAndConstructionBusiness"&gt;HomeAndConstructionBusiness&lt;/a&gt;: &lt;a class="localLink" href="http://schema.org/Electrician"&gt;Electrician&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/GeneralContractor"&gt;GeneralContractor&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/HousePainter"&gt;HousePainter&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Locksmith"&gt;Locksmith&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Plumber"&gt;Plumber&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RoofingContractor"&gt;RoofingContractor&lt;/a&gt;. &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; was introduced as a more inclusive supertype of &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : ProfessionalService^^xsd:string</para>
    ///   <a href="http://schema.org/ProfessionalService">schema:ProfessionalService</a>
    /// </summary>
    let ProfessionalService = _prefixId.prefix "ProfessionalService"
    /// <summary>
    ///   <para>rdfs:comment : Web page type: Profile page.^^xsd:string</para>
    ///   <para>rdfs:label : ProfilePage^^xsd:string</para>
    ///   <a href="http://schema.org/ProfilePage">schema:ProfilePage</a>
    /// </summary>
    let ProfilePage = _prefixId.prefix "ProfilePage"
    /// <summary>
    ///   <para>rdfs:label : ProgramMembership^^xsd:string</para>
    ///   <para>rdfs:comment : Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.^^xsd:string</para>
    ///   <a href="http://schema.org/ProgramMembership">schema:ProgramMembership</a>
    /// </summary>
    let ProgramMembership = _prefixId.prefix "ProgramMembership"
    let PronounceableText = _prefixId.prefix "PronounceableText"
    /// <summary>
    ///   <para>rdfs:label : PropertyValue^^xsd:string</para>
    ///   <para>rdfs:comment : A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.^^xsd:string</para>
    ///   <a href="http://schema.org/PropertyValue">schema:PropertyValue</a>
    /// </summary>
    let PropertyValue = _prefixId.prefix "PropertyValue"
    /// <summary>
    ///   <para>rdfs:comment : A Property value specification.^^xsd:string</para>
    ///   <para>rdfs:label : PropertyValueSpecification^^xsd:string</para>
    ///   <a href="http://schema.org/PropertyValueSpecification">schema:PropertyValueSpecification</a>
    /// </summary>
    let PropertyValueSpecification = _prefixId.prefix "PropertyValueSpecification"
    let PublicHolidays = _prefixId.prefix "PublicHolidays"
    /// <summary>
    ///   <para>rdfs:label : PublicSwimmingPool^^xsd:string</para>
    ///   <para>rdfs:comment : A public swimming pool.^^xsd:string</para>
    ///   <a href="http://schema.org/PublicSwimmingPool">schema:PublicSwimmingPool</a>
    /// </summary>
    let PublicSwimmingPool = _prefixId.prefix "PublicSwimmingPool"
    /// <summary>
    ///   <para>rdfs:comment : A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.^^xsd:string</para>
    ///   <para>rdfs:label : PublicationEvent^^xsd:string</para>
    ///   <a href="http://schema.org/PublicationEvent">schema:PublicationEvent</a>
    /// </summary>
    let PublicationEvent = _prefixId.prefix "PublicationEvent"
    /// <summary>
    ///   <para>rdfs:comment : A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : PublicationIssue^^xsd:string</para>
    ///   <a href="http://schema.org/PublicationIssue">schema:PublicationIssue</a>
    /// </summary>
    let PublicationIssue = _prefixId.prefix "PublicationIssue"
    /// <summary>
    ///   <para>rdfs:comment : A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : PublicationVolume^^xsd:string</para>
    ///   <a href="http://schema.org/PublicationVolume">schema:PublicationVolume</a>
    /// </summary>
    let PublicationVolume = _prefixId.prefix "PublicationVolume"
    /// <summary>
    ///   <para>rdfs:label : QAPage^^xsd:string</para>
    ///   <para>rdfs:comment : A QAPage is a WebPage focussed on a specific Question and its Answer(s), e.g. in a question answering site or documenting Frequently Asked Questions (FAQs).^^xsd:string</para>
    ///   <a href="http://schema.org/QAPage">schema:QAPage</a>
    /// </summary>
    let QAPage = _prefixId.prefix "QAPage"
    /// <summary>
    ///   <para>rdfs:label : QualitativeValue^^xsd:string</para>
    ///   <para>rdfs:comment : A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.^^xsd:string</para>
    ///   <a href="http://schema.org/QualitativeValue">schema:QualitativeValue</a>
    /// </summary>
    let QualitativeValue = _prefixId.prefix "QualitativeValue"
    /// <summary>
    ///   <para>rdfs:comment : A point value or interval for product characteristics and other purposes.^^xsd:string</para>
    ///   <para>rdfs:label : QuantitativeValue^^xsd:string</para>
    ///   <a href="http://schema.org/QuantitativeValue">schema:QuantitativeValue</a>
    /// </summary>
    let QuantitativeValue = _prefixId.prefix "QuantitativeValue"
    /// <summary>
    ///   <para>rdfs:comment : A statistical distribution of values.^^xsd:string</para>
    ///   <para>rdfs:label : QuantitativeValueDistribution^^xsd:string</para>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <a href="http://schema.org/QuantitativeValueDistribution">schema:QuantitativeValueDistribution</a>
    /// </summary>
    let QuantitativeValueDistribution = _prefixId.prefix "QuantitativeValueDistribution"
    /// <summary>
    ///   <para>rdfs:comment : Quantities such as distance, time, mass, weight, etc. Particular instances of say Mass are entities like '3 Kg' or '4 milligrams'.^^xsd:string</para>
    ///   <para>rdfs:label : Quantity^^xsd:string</para>
    ///   <a href="http://schema.org/Quantity">schema:Quantity</a>
    /// </summary>
    let Quantity = _prefixId.prefix "Quantity"
    /// <summary>
    ///   <para>rdfs:comment : A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.^^xsd:string</para>
    ///   <para>rdfs:label : Question^^xsd:string</para>
    ///   <a href="http://schema.org/Question">schema:Question</a>
    /// </summary>
    let Question = _prefixId.prefix "Question"
    /// <summary>
    ///   <para>rdfs:label : QuoteAction^^xsd:string</para>
    ///   <para>rdfs:comment : An agent quotes/estimates/appraises an object/product/service with a price at a location/store.^^xsd:string</para>
    ///   <a href="http://schema.org/QuoteAction">schema:QuoteAction</a>
    /// </summary>
    let QuoteAction = _prefixId.prefix "QuoteAction"
    /// <summary>
    ///   <para>rdfs:comment : A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.^^xsd:string</para>
    ///   <para>rdfs:label : RVPark^^xsd:string</para>
    ///   <a href="http://schema.org/RVPark">schema:RVPark</a>
    /// </summary>
    let RVPark = _prefixId.prefix "RVPark"
    /// <summary>
    ///   <para>rdfs:label : RadioChannel^^xsd:string</para>
    ///   <para>rdfs:comment : A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.^^xsd:string</para>
    ///   <a href="http://schema.org/RadioChannel">schema:RadioChannel</a>
    /// </summary>
    let RadioChannel = _prefixId.prefix "RadioChannel"
    /// <summary>
    ///   <para>rdfs:comment : A short radio program or a segment/part of a radio program.^^xsd:string</para>
    ///   <para>rdfs:label : RadioClip^^xsd:string</para>
    ///   <a href="http://schema.org/RadioClip">schema:RadioClip</a>
    /// </summary>
    let RadioClip = _prefixId.prefix "RadioClip"
    /// <summary>
    ///   <para>rdfs:comment : A radio episode which can be part of a series or season.^^xsd:string</para>
    ///   <para>rdfs:label : RadioEpisode^^xsd:string</para>
    ///   <a href="http://schema.org/RadioEpisode">schema:RadioEpisode</a>
    /// </summary>
    let RadioEpisode = _prefixId.prefix "RadioEpisode"
    /// <summary>
    ///   <para>rdfs:label : RadioSeason^^xsd:string</para>
    ///   <para>rdfs:comment : Season dedicated to radio broadcast and associated online delivery.^^xsd:string</para>
    ///   <a href="http://schema.org/RadioSeason">schema:RadioSeason</a>
    /// </summary>
    let RadioSeason = _prefixId.prefix "RadioSeason"
    /// <summary>
    ///   <para>rdfs:label : RadioSeries^^xsd:string</para>
    ///   <para>rdfs:comment : CreativeWorkSeries dedicated to radio broadcast and associated online delivery.^^xsd:string</para>
    ///   <a href="http://schema.org/RadioSeries">schema:RadioSeries</a>
    /// </summary>
    let RadioSeries = _prefixId.prefix "RadioSeries"
    /// <summary>
    ///   <para>rdfs:comment : A radio station.^^xsd:string</para>
    ///   <para>rdfs:label : RadioStation^^xsd:string</para>
    ///   <a href="http://schema.org/RadioStation">schema:RadioStation</a>
    /// </summary>
    let RadioStation = _prefixId.prefix "RadioStation"
    /// <summary>
    ///   <para>rdfs:comment : A rating is an evaluation on a numeric scale, such as 1 to 5 stars.^^xsd:string</para>
    ///   <para>rdfs:label : Rating^^xsd:string</para>
    ///   <a href="http://schema.org/Rating">schema:Rating</a>
    /// </summary>
    let Rating = _prefixId.prefix "Rating"
    /// <summary>
    ///   <para>rdfs:comment : The act of responding instinctively and emotionally to an object, expressing a sentiment.^^xsd:string</para>
    ///   <para>rdfs:label : ReactAction^^xsd:string</para>
    ///   <a href="http://schema.org/ReactAction">schema:ReactAction</a>
    /// </summary>
    let ReactAction = _prefixId.prefix "ReactAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of consuming written content.^^xsd:string</para>
    ///   <para>rdfs:label : ReadAction^^xsd:string</para>
    ///   <a href="http://schema.org/ReadAction">schema:ReadAction</a>
    /// </summary>
    let ReadAction = _prefixId.prefix "ReadAction"
    let ReadPermission = _prefixId.prefix "ReadPermission"
    /// <summary>
    ///   <para>rdfs:label : RealEstateAgent^^xsd:string</para>
    ///   <para>rdfs:comment : A real-estate agent.^^xsd:string</para>
    ///   <a href="http://schema.org/RealEstateAgent">schema:RealEstateAgent</a>
    /// </summary>
    let RealEstateAgent = _prefixId.prefix "RealEstateAgent"
    let RealEstateListing = _prefixId.prefix "RealEstateListing"
    let RearWheelDriveConfiguration = _prefixId.prefix "RearWheelDriveConfiguration"
    /// <summary>
    ///   <para>rdfs:label : ReceiveAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of physically/electronically taking delivery of an object thathas been transferred from an origin to a destination. Reciprocal of SendAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SendAction"&gt;SendAction&lt;/a&gt;: The reciprocal of ReceiveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TakeAction"&gt;TakeAction&lt;/a&gt;: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transfered (e.g. I can receive a package, but it does not mean the package is now mine).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/ReceiveAction">schema:ReceiveAction</a>
    /// </summary>
    let ReceiveAction = _prefixId.prefix "ReceiveAction"
    /// <summary>
    ///   <para>rdfs:label : Recipe^^xsd:string</para>
    ///   <para>rdfs:comment : A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via &lt;a class="localLink" href="http://schema.org/suitableForDiet"&gt;suitableForDiet&lt;/a&gt;. The &lt;a class="localLink" href="http://schema.org/keywords"&gt;keywords&lt;/a&gt; property can also be used to add more detail.^^xsd:string</para>
    ///   <a href="http://schema.org/Recipe">schema:Recipe</a>
    /// </summary>
    let Recipe = _prefixId.prefix "Recipe"
    let Recommendation = _prefixId.prefix "Recommendation"
    /// <summary>
    ///   <para>rdfs:comment : A recycling center.^^xsd:string</para>
    ///   <para>rdfs:label : RecyclingCenter^^xsd:string</para>
    ///   <a href="http://schema.org/RecyclingCenter">schema:RecyclingCenter</a>
    /// </summary>
    let RecyclingCenter = _prefixId.prefix "RecyclingCenter"
    let RefurbishedCondition = _prefixId.prefix "RefurbishedCondition"
    /// <summary>
    ///   <para>rdfs:comment : The act of registering to be a user of a service, product or web page.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, RegisterAction implies you are registering to be a user of a service, &lt;em&gt;not&lt;/em&gt; a group/team of people.&lt;/li&gt;
    /// &lt;li&gt;[FollowAction]]: Unlike FollowAction, RegisterAction doesn't imply that the agent is expecting to poll for updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, RegisterAction doesn't imply that the agent is expecting updates from the object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : RegisterAction^^xsd:string</para>
    ///   <a href="http://schema.org/RegisterAction">schema:RegisterAction</a>
    /// </summary>
    let RegisterAction = _prefixId.prefix "RegisterAction"
    /// <summary>
    ///   <para>rdfs:label : RejectAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of rejecting to/adopting an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AcceptAction"&gt;AcceptAction&lt;/a&gt;: The antonym of RejectAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/RejectAction">schema:RejectAction</a>
    /// </summary>
    let RejectAction = _prefixId.prefix "RejectAction"
    let RemixAlbum = _prefixId.prefix "RemixAlbum"
    /// <summary>
    ///   <para>rdfs:label : RentAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.^^xsd:string</para>
    ///   <a href="http://schema.org/RentAction">schema:RentAction</a>
    /// </summary>
    let RentAction = _prefixId.prefix "RentAction"
    /// <summary>
    ///   <para>rdfs:comment : A reservation for a rental car.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.^^xsd:string</para>
    ///   <para>rdfs:label : RentalCarReservation^^xsd:string</para>
    ///   <a href="http://schema.org/RentalCarReservation">schema:RentalCarReservation</a>
    /// </summary>
    let RentalCarReservation = _prefixId.prefix "RentalCarReservation"
    /// <summary>
    ///   <para>rdfs:comment : The act of editing a recipient by replacing an old object with a new object.^^xsd:string</para>
    ///   <para>rdfs:label : ReplaceAction^^xsd:string</para>
    ///   <a href="http://schema.org/ReplaceAction">schema:ReplaceAction</a>
    /// </summary>
    let ReplaceAction = _prefixId.prefix "ReplaceAction"
    /// <summary>
    ///   <para>rdfs:label : ReplyAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of responding to a question/message asked/sent by the object. Related to &lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;: Appears generally as an origin of a ReplyAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/ReplyAction">schema:ReplyAction</a>
    /// </summary>
    let ReplyAction = _prefixId.prefix "ReplyAction"
    /// <summary>
    ///   <para>rdfs:label : Report^^xsd:string</para>
    ///   <para>rdfs:comment : A Report generated by governmental or non-governmental organization.^^xsd:string</para>
    ///   <a href="http://schema.org/Report">schema:Report</a>
    /// </summary>
    let Report = _prefixId.prefix "Report"
    let Researcher = _prefixId.prefix "Researcher"
    /// <summary>
    ///   <para>rdfs:label : Reservation^^xsd:string</para>
    ///   <para>rdfs:comment : Describes a reservation for travel, dining or an event. Some reservations require tickets. &lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/Reservation">schema:Reservation</a>
    /// </summary>
    let Reservation = _prefixId.prefix "Reservation"
    let ReservationCancelled = _prefixId.prefix "ReservationCancelled"
    let ReservationConfirmed = _prefixId.prefix "ReservationConfirmed"
    let ReservationHold = _prefixId.prefix "ReservationHold"
    /// <summary>
    ///   <para>rdfs:label : ReservationPackage^^xsd:string</para>
    ///   <para>rdfs:comment : A group of multiple reservations with common values for all sub-reservations.^^xsd:string</para>
    ///   <a href="http://schema.org/ReservationPackage">schema:ReservationPackage</a>
    /// </summary>
    let ReservationPackage = _prefixId.prefix "ReservationPackage"
    let ReservationPending = _prefixId.prefix "ReservationPending"
    /// <summary>
    ///   <para>rdfs:comment : Enumerated status values for Reservation.^^xsd:string</para>
    ///   <para>rdfs:label : ReservationStatusType^^xsd:string</para>
    ///   <a href="http://schema.org/ReservationStatusType">schema:ReservationStatusType</a>
    /// </summary>
    let ReservationStatusType = _prefixId.prefix "ReservationStatusType"
    /// <summary>
    ///   <para>rdfs:comment : Reserving a concrete object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ScheduleAction"&gt;ScheduleAction&lt;/a&gt;&lt;/a&gt;: Unlike ScheduleAction, ReserveAction reserves concrete objects (e.g. a table, a hotel) towards a time slot / spatial allocation.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : ReserveAction^^xsd:string</para>
    ///   <a href="http://schema.org/ReserveAction">schema:ReserveAction</a>
    /// </summary>
    let ReserveAction = _prefixId.prefix "ReserveAction"
    /// <summary>
    ///   <para>rdfs:comment : A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.^^xsd:string</para>
    ///   <para>rdfs:label : Reservoir^^xsd:string</para>
    ///   <a href="http://schema.org/Reservoir">schema:Reservoir</a>
    /// </summary>
    let Reservoir = _prefixId.prefix "Reservoir"
    /// <summary>
    ///   <para>rdfs:comment : The place where a person lives.^^xsd:string</para>
    ///   <para>rdfs:label : Residence^^xsd:string</para>
    ///   <a href="http://schema.org/Residence">schema:Residence</a>
    /// </summary>
    let Residence = _prefixId.prefix "Residence"
    /// <summary>
    ///   <para>rdfs:label : Resort^^xsd:string</para>
    ///   <para>rdfs:comment : A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishment operated by a single company (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Resort"&gt;http://en.wikipedia.org/wiki/Resort&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/Resort">schema:Resort</a>
    /// </summary>
    let Resort = _prefixId.prefix "Resort"
    /// <summary>
    ///   <para>rdfs:label : Restaurant^^xsd:string</para>
    ///   <para>rdfs:comment : A restaurant.^^xsd:string</para>
    ///   <a href="http://schema.org/Restaurant">schema:Restaurant</a>
    /// </summary>
    let Restaurant = _prefixId.prefix "Restaurant"
    /// <summary>
    ///   <para>rdfs:comment : A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.^^xsd:string</para>
    ///   <para>rdfs:label : RestrictedDiet^^xsd:string</para>
    ///   <a href="http://schema.org/RestrictedDiet">schema:RestrictedDiet</a>
    /// </summary>
    let RestrictedDiet = _prefixId.prefix "RestrictedDiet"
    /// <summary>
    ///   <para>rdfs:comment : The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).^^xsd:string</para>
    ///   <para>rdfs:label : ResumeAction^^xsd:string</para>
    ///   <a href="http://schema.org/ResumeAction">schema:ResumeAction</a>
    /// </summary>
    let ResumeAction = _prefixId.prefix "ResumeAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).^^xsd:string</para>
    ///   <para>rdfs:label : ReturnAction^^xsd:string</para>
    ///   <a href="http://schema.org/ReturnAction">schema:ReturnAction</a>
    /// </summary>
    let ReturnAction = _prefixId.prefix "ReturnAction"
    /// <summary>
    ///   <para>rdfs:label : Review^^xsd:string</para>
    ///   <para>rdfs:comment : A review of an item - for example, of a restaurant, movie, or store.^^xsd:string</para>
    ///   <a href="http://schema.org/Review">schema:Review</a>
    /// </summary>
    let Review = _prefixId.prefix "Review"
    /// <summary>
    ///   <para>rdfs:label : ReviewAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.^^xsd:string</para>
    ///   <a href="http://schema.org/ReviewAction">schema:ReviewAction</a>
    /// </summary>
    let ReviewAction = _prefixId.prefix "ReviewAction"
    let RightHandDriving = _prefixId.prefix "RightHandDriving"
    /// <summary>
    ///   <para>rdfs:label : RiverBodyOfWater^^xsd:string</para>
    ///   <para>rdfs:comment : A river (for example, the broad majestic Shannon).^^xsd:string</para>
    ///   <a href="http://schema.org/RiverBodyOfWater">schema:RiverBodyOfWater</a>
    /// </summary>
    let RiverBodyOfWater = _prefixId.prefix "RiverBodyOfWater"
    /// <summary>
    ///   <para>rdfs:comment : Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a href="http://blog.schema.org/2014/06/introducing-role.html"&gt;blog post&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <a href="http://schema.org/Role">schema:Role</a>
    /// </summary>
    let Role = _prefixId.prefix "Role"
    /// <summary>
    ///   <para>rdfs:comment : A roofing contractor.^^xsd:string</para>
    ///   <para>rdfs:label : RoofingContractor^^xsd:string</para>
    ///   <a href="http://schema.org/RoofingContractor">schema:RoofingContractor</a>
    /// </summary>
    let RoofingContractor = _prefixId.prefix "RoofingContractor"
    /// <summary>
    ///   <para>rdfs:label : Room^^xsd:string</para>
    ///   <para>rdfs:comment : A room is a distinguishable space within a structure, usually separated from other spaces by interior walls. (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Room"&gt;http://en.wikipedia.org/wiki/Room&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/Room">schema:Room</a>
    /// </summary>
    let Room = _prefixId.prefix "Room"
    /// <summary>
    ///   <para>rdfs:comment : The act of notifying an event organizer as to whether you expect to attend the event.^^xsd:string</para>
    ///   <para>rdfs:label : RsvpAction^^xsd:string</para>
    ///   <a href="http://schema.org/RsvpAction">schema:RsvpAction</a>
    /// </summary>
    let RsvpAction = _prefixId.prefix "RsvpAction"
    let RsvpResponseMaybe = _prefixId.prefix "RsvpResponseMaybe"
    let RsvpResponseNo = _prefixId.prefix "RsvpResponseNo"
    /// <summary>
    ///   <para>rdfs:label : RsvpResponseType^^xsd:string</para>
    ///   <para>rdfs:comment : RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.^^xsd:string</para>
    ///   <a href="http://schema.org/RsvpResponseType">schema:RsvpResponseType</a>
    /// </summary>
    let RsvpResponseType = _prefixId.prefix "RsvpResponseType"
    let RsvpResponseYes = _prefixId.prefix "RsvpResponseYes"
    /// <summary>
    ///   <para>rdfs:comment : Event type: Sales event.^^xsd:string</para>
    ///   <para>rdfs:label : SaleEvent^^xsd:string</para>
    ///   <a href="http://schema.org/SaleEvent">schema:SaleEvent</a>
    /// </summary>
    let SaleEvent = _prefixId.prefix "SaleEvent"
    let Saturday = _prefixId.prefix "Saturday"
    let Schedule = _prefixId.prefix "Schedule"
    /// <summary>
    ///   <para>rdfs:label : ScheduleAction^^xsd:string</para>
    ///   <para>rdfs:comment : Scheduling future actions, events, or tasks.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReserveAction"&gt;ReserveAction&lt;/a&gt;: Unlike ReserveAction, ScheduleAction allocates future actions (e.g. an event, a task, etc) towards a time slot / spatial allocation.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/ScheduleAction">schema:ScheduleAction</a>
    /// </summary>
    let ScheduleAction = _prefixId.prefix "ScheduleAction"
    /// <summary>
    ///   <para>rdfs:label : ScholarlyArticle^^xsd:string</para>
    ///   <para>rdfs:comment : A scholarly article.^^xsd:string</para>
    ///   <a href="http://schema.org/ScholarlyArticle">schema:ScholarlyArticle</a>
    /// </summary>
    let ScholarlyArticle = _prefixId.prefix "ScholarlyArticle"
    /// <summary>
    ///   <para>rdfs:label : School^^xsd:string</para>
    ///   <para>rdfs:comment : A school.^^xsd:string</para>
    ///   <a href="http://schema.org/School">schema:School</a>
    /// </summary>
    let School = _prefixId.prefix "School"
    /// <summary>
    ///   <para>rdfs:label : ScreeningEvent^^xsd:string</para>
    ///   <para>rdfs:comment : A screening of a movie or other video.^^xsd:string</para>
    ///   <a href="http://schema.org/ScreeningEvent">schema:ScreeningEvent</a>
    /// </summary>
    let ScreeningEvent = _prefixId.prefix "ScreeningEvent"
    /// <summary>
    ///   <para>rdfs:label : Sculpture^^xsd:string</para>
    ///   <para>rdfs:comment : A piece of sculpture.^^xsd:string</para>
    ///   <a href="http://schema.org/Sculpture">schema:Sculpture</a>
    /// </summary>
    let Sculpture = _prefixId.prefix "Sculpture"
    /// <summary>
    ///   <para>rdfs:comment : A sea (for example, the Caspian sea).^^xsd:string</para>
    ///   <para>rdfs:label : SeaBodyOfWater^^xsd:string</para>
    ///   <a href="http://schema.org/SeaBodyOfWater">schema:SeaBodyOfWater</a>
    /// </summary>
    let SeaBodyOfWater = _prefixId.prefix "SeaBodyOfWater"
    /// <summary>
    ///   <para>rdfs:label : SearchAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of searching for an object.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FindAction"&gt;FindAction&lt;/a&gt;: SearchAction generally leads to a FindAction, but not necessarily.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/SearchAction">schema:SearchAction</a>
    /// </summary>
    let SearchAction = _prefixId.prefix "SearchAction"
    /// <summary>
    ///   <para>rdfs:label : SearchResultsPage^^xsd:string</para>
    ///   <para>rdfs:comment : Web page type: Search results page.^^xsd:string</para>
    ///   <a href="http://schema.org/SearchResultsPage">schema:SearchResultsPage</a>
    /// </summary>
    let SearchResultsPage = _prefixId.prefix "SearchResultsPage"
    /// <summary>
    ///   <para>rdfs:label : Season^^xsd:string</para>
    ///   <para>rdfs:comment : A media season e.g. tv, radio, video game etc.^^xsd:string</para>
    ///   <a href="http://schema.org/Season">schema:Season</a>
    /// </summary>
    let Season = _prefixId.prefix "Season"
    /// <summary>
    ///   <para>rdfs:label : Seat^^xsd:string</para>
    ///   <para>rdfs:comment : Used to describe a seat, such as a reserved seat in an event reservation.^^xsd:string</para>
    ///   <a href="http://schema.org/Seat">schema:Seat</a>
    /// </summary>
    let Seat = _prefixId.prefix "Seat"
    let SeatingMap = _prefixId.prefix "SeatingMap"
    /// <summary>
    ///   <para>rdfs:comment : A self-storage facility.^^xsd:string</para>
    ///   <para>rdfs:label : SelfStorage^^xsd:string</para>
    ///   <a href="http://schema.org/SelfStorage">schema:SelfStorage</a>
    /// </summary>
    let SelfStorage = _prefixId.prefix "SelfStorage"
    /// <summary>
    ///   <para>rdfs:comment : The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.^^xsd:string</para>
    ///   <para>rdfs:label : SellAction^^xsd:string</para>
    ///   <a href="http://schema.org/SellAction">schema:SellAction</a>
    /// </summary>
    let SellAction = _prefixId.prefix "SellAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of physically/electronically dispatching an object for transfer from an origin to a destination.Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: The reciprocal of SendAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : SendAction^^xsd:string</para>
    ///   <a href="http://schema.org/SendAction">schema:SendAction</a>
    /// </summary>
    let SendAction = _prefixId.prefix "SendAction"
    /// <summary>
    ///   <para>rdfs:label : Series^^xsd:string</para>
    ///   <para>rdfs:comment : A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also &lt;a class="localLink" href="http://schema.org/CreativeWorkSeries"&gt;CreativeWorkSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/EventSeries"&gt;EventSeries&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/Series">schema:Series</a>
    /// </summary>
    let Series = _prefixId.prefix "Series"
    /// <summary>
    ///   <para>rdfs:comment : A service provided by an organization, e.g. delivery service, print services, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Service^^xsd:string</para>
    ///   <a href="http://schema.org/Service">schema:Service</a>
    /// </summary>
    let Service = _prefixId.prefix "Service"
    /// <summary>
    ///   <para>rdfs:label : ServiceChannel^^xsd:string</para>
    ///   <para>rdfs:comment : A means for accessing a service, e.g. a government office location, web site, or phone number.^^xsd:string</para>
    ///   <a href="http://schema.org/ServiceChannel">schema:ServiceChannel</a>
    /// </summary>
    let ServiceChannel = _prefixId.prefix "ServiceChannel"
    /// <summary>
    ///   <para>rdfs:comment : The act of distributing content to people for their amusement or edification.^^xsd:string</para>
    ///   <para>rdfs:label : ShareAction^^xsd:string</para>
    ///   <a href="http://schema.org/ShareAction">schema:ShareAction</a>
    /// </summary>
    let ShareAction = _prefixId.prefix "ShareAction"
    /// <summary>
    ///   <para>rdfs:comment : A shoe store.^^xsd:string</para>
    ///   <para>rdfs:label : ShoeStore^^xsd:string</para>
    ///   <a href="http://schema.org/ShoeStore">schema:ShoeStore</a>
    /// </summary>
    let ShoeStore = _prefixId.prefix "ShoeStore"
    /// <summary>
    ///   <para>rdfs:label : ShoppingCenter^^xsd:string</para>
    ///   <para>rdfs:comment : A shopping center or mall.^^xsd:string</para>
    ///   <a href="http://schema.org/ShoppingCenter">schema:ShoppingCenter</a>
    /// </summary>
    let ShoppingCenter = _prefixId.prefix "ShoppingCenter"
    /// <summary>
    ///   <para>rdfs:comment : Residence type: Single-family home.^^xsd:string</para>
    ///   <para>rdfs:label : SingleFamilyResidence^^xsd:string</para>
    ///   <a href="http://schema.org/SingleFamilyResidence">schema:SingleFamilyResidence</a>
    /// </summary>
    let SingleFamilyResidence = _prefixId.prefix "SingleFamilyResidence"
    let SinglePlayer = _prefixId.prefix "SinglePlayer"
    let SingleRelease = _prefixId.prefix "SingleRelease"
    /// <summary>
    ///   <para>rdfs:comment : A navigation element of the page.^^xsd:string</para>
    ///   <para>rdfs:label : SiteNavigationElement^^xsd:string</para>
    ///   <a href="http://schema.org/SiteNavigationElement">schema:SiteNavigationElement</a>
    /// </summary>
    let SiteNavigationElement = _prefixId.prefix "SiteNavigationElement"
    /// <summary>
    ///   <para>rdfs:comment : A ski resort.^^xsd:string</para>
    ///   <para>rdfs:label : SkiResort^^xsd:string</para>
    ///   <a href="http://schema.org/SkiResort">schema:SkiResort</a>
    /// </summary>
    let SkiResort = _prefixId.prefix "SkiResort"
    /// <summary>
    ///   <para>rdfs:label : SocialEvent^^xsd:string</para>
    ///   <para>rdfs:comment : Event type: Social event.^^xsd:string</para>
    ///   <a href="http://schema.org/SocialEvent">schema:SocialEvent</a>
    /// </summary>
    let SocialEvent = _prefixId.prefix "SocialEvent"
    /// <summary>
    ///   <para>rdfs:label : SocialMediaPosting^^xsd:string</para>
    ///   <para>rdfs:comment : A post to a social media platform, including blog posts, tweets, Facebook posts, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/SocialMediaPosting">schema:SocialMediaPosting</a>
    /// </summary>
    let SocialMediaPosting = _prefixId.prefix "SocialMediaPosting"
    /// <summary>
    ///   <para>rdfs:comment : A software application.^^xsd:string</para>
    ///   <para>rdfs:label : SoftwareApplication^^xsd:string</para>
    ///   <a href="http://schema.org/SoftwareApplication">schema:SoftwareApplication</a>
    /// </summary>
    let SoftwareApplication = _prefixId.prefix "SoftwareApplication"
    /// <summary>
    ///   <para>rdfs:label : SoftwareSourceCode^^xsd:string</para>
    ///   <para>rdfs:comment : Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.^^xsd:string</para>
    ///   <a href="http://schema.org/SoftwareSourceCode">schema:SoftwareSourceCode</a>
    /// </summary>
    let SoftwareSourceCode = _prefixId.prefix "SoftwareSourceCode"
    let SoldOut = _prefixId.prefix "SoldOut"
    /// <summary>
    ///   <para>rdfs:comment : A placeholder for multiple similar products of the same kind.^^xsd:string</para>
    ///   <para>rdfs:label : SomeProducts^^xsd:string</para>
    ///   <a href="http://schema.org/SomeProducts">schema:SomeProducts</a>
    /// </summary>
    let SomeProducts = _prefixId.prefix "SomeProducts"
    let SoundtrackAlbum = _prefixId.prefix "SoundtrackAlbum"
    /// <summary>
    ///   <para>rdfs:comment : A SpeakableSpecification indicates (typically via &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt;) sections of a document that are highlighted as particularly &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt;. Instances of this type are expected to be used primarily as values of the &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt; property.^^xsd:string</para>
    ///   <para>schema:category : issue-1389^^xsd:string</para>
    ///   <para>rdfs:label : SpeakableSpecification^^xsd:string</para>
    ///   <a href="http://schema.org/SpeakableSpecification">schema:SpeakableSpecification</a>
    /// </summary>
    let SpeakableSpecification = _prefixId.prefix "SpeakableSpecification"
    let SpecialAnnouncement = _prefixId.prefix "SpecialAnnouncement"
    /// <summary>
    ///   <para>rdfs:comment : Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.^^xsd:string</para>
    ///   <para>rdfs:label : Specialty^^xsd:string</para>
    ///   <a href="http://schema.org/Specialty">schema:Specialty</a>
    /// </summary>
    let Specialty = _prefixId.prefix "Specialty"
    let SpokenWordAlbum = _prefixId.prefix "SpokenWordAlbum"
    /// <summary>
    ///   <para>rdfs:comment : A sporting goods store.^^xsd:string</para>
    ///   <para>rdfs:label : SportingGoodsStore^^xsd:string</para>
    ///   <a href="http://schema.org/SportingGoodsStore">schema:SportingGoodsStore</a>
    /// </summary>
    let SportingGoodsStore = _prefixId.prefix "SportingGoodsStore"
    /// <summary>
    ///   <para>rdfs:comment : A sports location, such as a playing field.^^xsd:string</para>
    ///   <para>rdfs:label : SportsActivityLocation^^xsd:string</para>
    ///   <a href="http://schema.org/SportsActivityLocation">schema:SportsActivityLocation</a>
    /// </summary>
    let SportsActivityLocation = _prefixId.prefix "SportsActivityLocation"
    /// <summary>
    ///   <para>rdfs:label : SportsClub^^xsd:string</para>
    ///   <para>rdfs:comment : A sports club.^^xsd:string</para>
    ///   <a href="http://schema.org/SportsClub">schema:SportsClub</a>
    /// </summary>
    let SportsClub = _prefixId.prefix "SportsClub"
    /// <summary>
    ///   <para>rdfs:label : SportsEvent^^xsd:string</para>
    ///   <para>rdfs:comment : Event type: Sports event.^^xsd:string</para>
    ///   <a href="http://schema.org/SportsEvent">schema:SportsEvent</a>
    /// </summary>
    let SportsEvent = _prefixId.prefix "SportsEvent"
    /// <summary>
    ///   <para>rdfs:label : SportsOrganization^^xsd:string</para>
    ///   <para>rdfs:comment : Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.^^xsd:string</para>
    ///   <a href="http://schema.org/SportsOrganization">schema:SportsOrganization</a>
    /// </summary>
    let SportsOrganization = _prefixId.prefix "SportsOrganization"
    /// <summary>
    ///   <para>rdfs:label : SportsTeam^^xsd:string</para>
    ///   <para>rdfs:comment : Organization: Sports team.^^xsd:string</para>
    ///   <a href="http://schema.org/SportsTeam">schema:SportsTeam</a>
    /// </summary>
    let SportsTeam = _prefixId.prefix "SportsTeam"
    /// <summary>
    ///   <para>rdfs:label : SpreadsheetDigitalDocument^^xsd:string</para>
    ///   <para>rdfs:comment : A spreadsheet file.^^xsd:string</para>
    ///   <a href="http://schema.org/SpreadsheetDigitalDocument">schema:SpreadsheetDigitalDocument</a>
    /// </summary>
    let SpreadsheetDigitalDocument = _prefixId.prefix "SpreadsheetDigitalDocument"
    /// <summary>
    ///   <para>rdfs:comment : A stadium.^^xsd:string</para>
    ///   <para>rdfs:label : StadiumOrArena^^xsd:string</para>
    ///   <a href="http://schema.org/StadiumOrArena">schema:StadiumOrArena</a>
    /// </summary>
    let StadiumOrArena = _prefixId.prefix "StadiumOrArena"
    /// <summary>
    ///   <para>rdfs:comment : A state or province of a country.^^xsd:string</para>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <a href="http://schema.org/State">schema:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:label : SteeringPositionValue^^xsd:string</para>
    ///   <para>rdfs:comment : A value indicating a steering position.^^xsd:string</para>
    ///   <a href="http://schema.org/SteeringPositionValue">schema:SteeringPositionValue</a>
    /// </summary>
    let SteeringPositionValue = _prefixId.prefix "SteeringPositionValue"
    /// <summary>
    ///   <para>rdfs:comment : A retail good store.^^xsd:string</para>
    ///   <para>rdfs:label : Store^^xsd:string</para>
    ///   <a href="http://schema.org/Store">schema:Store</a>
    /// </summary>
    let Store = _prefixId.prefix "Store"
    /// <summary>
    ///   <para>rdfs:label : StructuredValue^^xsd:string</para>
    ///   <para>rdfs:comment : Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.^^xsd:string</para>
    ///   <a href="http://schema.org/StructuredValue">schema:StructuredValue</a>
    /// </summary>
    let StructuredValue = _prefixId.prefix "StructuredValue"
    let StudioAlbum = _prefixId.prefix "StudioAlbum"
    /// <summary>
    ///   <para>rdfs:label : SubscribeAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates pushed to.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, SubscribeAction implies that the subscriber acts as a passive agent being constantly/actively pushed for updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/SubscribeAction">schema:SubscribeAction</a>
    /// </summary>
    let SubscribeAction = _prefixId.prefix "SubscribeAction"
    /// <summary>
    ///   <para>rdfs:comment : A subway station.^^xsd:string</para>
    ///   <para>rdfs:label : SubwayStation^^xsd:string</para>
    ///   <a href="http://schema.org/SubwayStation">schema:SubwayStation</a>
    /// </summary>
    let SubwayStation = _prefixId.prefix "SubwayStation"
    /// <summary>
    ///   <para>rdfs:comment : A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : Suite^^xsd:string</para>
    ///   <a href="http://schema.org/Suite">schema:Suite</a>
    /// </summary>
    let Suite = _prefixId.prefix "Suite"
    let Sunday = _prefixId.prefix "Sunday"
    /// <summary>
    ///   <para>rdfs:label : SuspendAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).^^xsd:string</para>
    ///   <a href="http://schema.org/SuspendAction">schema:SuspendAction</a>
    /// </summary>
    let SuspendAction = _prefixId.prefix "SuspendAction"
    /// <summary>
    ///   <para>rdfs:comment : A synagogue.^^xsd:string</para>
    ///   <para>rdfs:label : Synagogue^^xsd:string</para>
    ///   <a href="http://schema.org/Synagogue">schema:Synagogue</a>
    /// </summary>
    let Synagogue = _prefixId.prefix "Synagogue"
    /// <summary>
    ///   <para>rdfs:label : TVClip^^xsd:string</para>
    ///   <para>rdfs:comment : A short TV program or a segment/part of a TV program.^^xsd:string</para>
    ///   <a href="http://schema.org/TVClip">schema:TVClip</a>
    /// </summary>
    let TVClip = _prefixId.prefix "TVClip"
    /// <summary>
    ///   <para>rdfs:label : TVEpisode^^xsd:string</para>
    ///   <para>rdfs:comment : A TV episode which can be part of a series or season.^^xsd:string</para>
    ///   <a href="http://schema.org/TVEpisode">schema:TVEpisode</a>
    /// </summary>
    let TVEpisode = _prefixId.prefix "TVEpisode"
    /// <summary>
    ///   <para>rdfs:comment : Season dedicated to TV broadcast and associated online delivery.^^xsd:string</para>
    ///   <para>rdfs:label : TVSeason^^xsd:string</para>
    ///   <a href="http://schema.org/TVSeason">schema:TVSeason</a>
    /// </summary>
    let TVSeason = _prefixId.prefix "TVSeason"
    /// <summary>
    ///   <para>rdfs:comment : CreativeWorkSeries dedicated to TV broadcast and associated online delivery.^^xsd:string</para>
    ///   <para>rdfs:label : TVSeries^^xsd:string</para>
    ///   <a href="http://schema.org/TVSeries">schema:TVSeries</a>
    /// </summary>
    let TVSeries = _prefixId.prefix "TVSeries"
    /// <summary>
    ///   <para>rdfs:comment : A table on a Web page.^^xsd:string</para>
    ///   <para>rdfs:label : Table^^xsd:string</para>
    ///   <a href="http://schema.org/Table">schema:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:comment : The act of gaining ownership of an object from an origin. Reciprocal of GiveAction.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/GiveAction"&gt;GiveAction&lt;/a&gt;: The reciprocal of TakeAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReceiveAction"&gt;ReceiveAction&lt;/a&gt;: Unlike ReceiveAction, TakeAction implies that ownership has been transfered.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : TakeAction^^xsd:string</para>
    ///   <a href="http://schema.org/TakeAction">schema:TakeAction</a>
    /// </summary>
    let TakeAction = _prefixId.prefix "TakeAction"
    /// <summary>
    ///   <para>rdfs:comment : A tattoo parlor.^^xsd:string</para>
    ///   <para>rdfs:label : TattooParlor^^xsd:string</para>
    ///   <a href="http://schema.org/TattooParlor">schema:TattooParlor</a>
    /// </summary>
    let TattooParlor = _prefixId.prefix "TattooParlor"
    /// <summary>
    ///   <para>rdfs:comment : A taxi.^^xsd:string</para>
    ///   <para>rdfs:label : Taxi^^xsd:string</para>
    ///   <a href="http://schema.org/Taxi">schema:Taxi</a>
    /// </summary>
    let Taxi = _prefixId.prefix "Taxi"
    /// <summary>
    ///   <para>rdfs:comment : A reservation for a taxi.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : TaxiReservation^^xsd:string</para>
    ///   <a href="http://schema.org/TaxiReservation">schema:TaxiReservation</a>
    /// </summary>
    let TaxiReservation = _prefixId.prefix "TaxiReservation"
    /// <summary>
    ///   <para>rdfs:comment : A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.^^xsd:string</para>
    ///   <para>rdfs:label : TaxiService^^xsd:string</para>
    ///   <a href="http://schema.org/TaxiService">schema:TaxiService</a>
    /// </summary>
    let TaxiService = _prefixId.prefix "TaxiService"
    /// <summary>
    ///   <para>rdfs:comment : A taxi stand.^^xsd:string</para>
    ///   <para>rdfs:label : TaxiStand^^xsd:string</para>
    ///   <a href="http://schema.org/TaxiStand">schema:TaxiStand</a>
    /// </summary>
    let TaxiStand = _prefixId.prefix "TaxiStand"
    /// <summary>
    ///   <para>rdfs:comment : A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.^^xsd:string</para>
    ///   <para>rdfs:label : TechArticle^^xsd:string</para>
    ///   <a href="http://schema.org/TechArticle">schema:TechArticle</a>
    /// </summary>
    let TechArticle = _prefixId.prefix "TechArticle"
    /// <summary>
    ///   <para>rdfs:comment : A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.^^xsd:string</para>
    ///   <para>rdfs:label : TelevisionChannel^^xsd:string</para>
    ///   <a href="http://schema.org/TelevisionChannel">schema:TelevisionChannel</a>
    /// </summary>
    let TelevisionChannel = _prefixId.prefix "TelevisionChannel"
    /// <summary>
    ///   <para>rdfs:comment : A television station.^^xsd:string</para>
    ///   <para>rdfs:label : TelevisionStation^^xsd:string</para>
    ///   <a href="http://schema.org/TelevisionStation">schema:TelevisionStation</a>
    /// </summary>
    let TelevisionStation = _prefixId.prefix "TelevisionStation"
    /// <summary>
    ///   <para>rdfs:label : TennisComplex^^xsd:string</para>
    ///   <para>rdfs:comment : A tennis complex.^^xsd:string</para>
    ///   <a href="http://schema.org/TennisComplex">schema:TennisComplex</a>
    /// </summary>
    let TennisComplex = _prefixId.prefix "TennisComplex"
    /// <summary>
    ///   <para>rdfs:label : Text^^xsd:string</para>
    ///   <para>rdfs:comment : Data type: Text.^^xsd:string</para>
    ///   <a href="http://schema.org/Text">schema:Text</a>
    /// </summary>
    let Text = _prefixId.prefix "Text"
    /// <summary>
    ///   <para>rdfs:comment : A file composed primarily of text.^^xsd:string</para>
    ///   <para>rdfs:label : TextDigitalDocument^^xsd:string</para>
    ///   <a href="http://schema.org/TextDigitalDocument">schema:TextDigitalDocument</a>
    /// </summary>
    let TextDigitalDocument = _prefixId.prefix "TextDigitalDocument"
    /// <summary>
    ///   <para>rdfs:label : TheaterEvent^^xsd:string</para>
    ///   <para>rdfs:comment : Event type: Theater performance.^^xsd:string</para>
    ///   <a href="http://schema.org/TheaterEvent">schema:TheaterEvent</a>
    /// </summary>
    let TheaterEvent = _prefixId.prefix "TheaterEvent"
    /// <summary>
    ///   <para>rdfs:comment : A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.^^xsd:string</para>
    ///   <para>rdfs:label : TheaterGroup^^xsd:string</para>
    ///   <a href="http://schema.org/TheaterGroup">schema:TheaterGroup</a>
    /// </summary>
    let TheaterGroup = _prefixId.prefix "TheaterGroup"
    /// <summary>
    ///   <para>rdfs:comment : The most generic type of item.^^xsd:string</para>
    ///   <para>rdfs:label : Thing^^xsd:string</para>
    ///   <a href="http://schema.org/Thing">schema:Thing</a>
    /// </summary>
    let Thing = _prefixId.prefix "Thing"
    let Thursday = _prefixId.prefix "Thursday"
    /// <summary>
    ///   <para>rdfs:comment : Used to describe a ticket to an event, a flight, a bus ride, etc.^^xsd:string</para>
    ///   <para>rdfs:label : Ticket^^xsd:string</para>
    ///   <a href="http://schema.org/Ticket">schema:Ticket</a>
    /// </summary>
    let Ticket = _prefixId.prefix "Ticket"
    /// <summary>
    ///   <para>rdfs:label : TieAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of reaching a draw in a competitive activity.^^xsd:string</para>
    ///   <a href="http://schema.org/TieAction">schema:TieAction</a>
    /// </summary>
    let TieAction = _prefixId.prefix "TieAction"
    /// <summary>
    ///   <para>rdfs:comment : A point in time recurring on multiple days in the form hh:mm:ss[Z|(+|-)hh:mm] (see &lt;a href="http://www.w3.org/TR/xmlschema-2/#time"&gt;XML schema for details&lt;/a&gt;).^^xsd:string</para>
    ///   <para>rdfs:label : Time^^xsd:string</para>
    ///   <a href="http://schema.org/Time">schema:Time</a>
    /// </summary>
    let Time = _prefixId.prefix "Time"
    /// <summary>
    ///   <para>rdfs:comment : The act of giving money voluntarily to a beneficiary in recognition of services rendered.^^xsd:string</para>
    ///   <para>rdfs:label : TipAction^^xsd:string</para>
    ///   <a href="http://schema.org/TipAction">schema:TipAction</a>
    /// </summary>
    let TipAction = _prefixId.prefix "TipAction"
    /// <summary>
    ///   <para>rdfs:comment : A tire shop.^^xsd:string</para>
    ///   <para>rdfs:label : TireShop^^xsd:string</para>
    ///   <a href="http://schema.org/TireShop">schema:TireShop</a>
    /// </summary>
    let TireShop = _prefixId.prefix "TireShop"
    let TollFree = _prefixId.prefix "TollFree"
    /// <summary>
    ///   <para>rdfs:label : TouristAttraction^^xsd:string</para>
    ///   <para>rdfs:comment : A tourist attraction.  In principle any Thing can be a &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, from a &lt;a class="localLink" href="http://schema.org/Mountain"&gt;Mountain&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/LandmarksOrHistoricalBuildings"&gt;LandmarksOrHistoricalBuildings&lt;/a&gt; to a &lt;a class="localLink" href="http://schema.org/LocalBusiness"&gt;LocalBusiness&lt;/a&gt;.  This Type can be used on its own to describe a general &lt;a class="localLink" href="http://schema.org/TouristAttraction"&gt;TouristAttraction&lt;/a&gt;, or be used as an &lt;a class="localLink" href="http://schema.org/additionalType"&gt;additionalType&lt;/a&gt; to add tourist attraction properties to any other type.  (See examples below)^^xsd:string</para>
    ///   <a href="http://schema.org/TouristAttraction">schema:TouristAttraction</a>
    /// </summary>
    let TouristAttraction = _prefixId.prefix "TouristAttraction"
    let TouristDestination = _prefixId.prefix "TouristDestination"
    /// <summary>
    ///   <para>rdfs:label : TouristInformationCenter^^xsd:string</para>
    ///   <para>rdfs:comment : A tourist information center.^^xsd:string</para>
    ///   <a href="http://schema.org/TouristInformationCenter">schema:TouristInformationCenter</a>
    /// </summary>
    let TouristInformationCenter = _prefixId.prefix "TouristInformationCenter"
    let TouristTrip = _prefixId.prefix "TouristTrip"
    /// <summary>
    ///   <para>rdfs:comment : A toy store.^^xsd:string</para>
    ///   <para>rdfs:label : ToyStore^^xsd:string</para>
    ///   <a href="http://schema.org/ToyStore">schema:ToyStore</a>
    /// </summary>
    let ToyStore = _prefixId.prefix "ToyStore"
    /// <summary>
    ///   <para>rdfs:comment : An agent tracks an object for updates.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : TrackAction^^xsd:string</para>
    ///   <a href="http://schema.org/TrackAction">schema:TrackAction</a>
    /// </summary>
    let TrackAction = _prefixId.prefix "TrackAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.^^xsd:string</para>
    ///   <para>rdfs:label : TradeAction^^xsd:string</para>
    ///   <a href="http://schema.org/TradeAction">schema:TradeAction</a>
    /// </summary>
    let TradeAction = _prefixId.prefix "TradeAction"
    /// <summary>
    ///   <para>rdfs:label : TrainReservation^^xsd:string</para>
    ///   <para>rdfs:comment : A reservation for train travel.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/TrainReservation">schema:TrainReservation</a>
    /// </summary>
    let TrainReservation = _prefixId.prefix "TrainReservation"
    /// <summary>
    ///   <para>rdfs:label : TrainStation^^xsd:string</para>
    ///   <para>rdfs:comment : A train station.^^xsd:string</para>
    ///   <a href="http://schema.org/TrainStation">schema:TrainStation</a>
    /// </summary>
    let TrainStation = _prefixId.prefix "TrainStation"
    /// <summary>
    ///   <para>rdfs:comment : A trip on a commercial train line.^^xsd:string</para>
    ///   <para>rdfs:label : TrainTrip^^xsd:string</para>
    ///   <a href="http://schema.org/TrainTrip">schema:TrainTrip</a>
    /// </summary>
    let TrainTrip = _prefixId.prefix "TrainTrip"
    /// <summary>
    ///   <para>rdfs:label : TransferAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.^^xsd:string</para>
    ///   <a href="http://schema.org/TransferAction">schema:TransferAction</a>
    /// </summary>
    let TransferAction = _prefixId.prefix "TransferAction"
    let TransitMap = _prefixId.prefix "TransitMap"
    /// <summary>
    ///   <para>rdfs:label : TravelAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of traveling from an fromLocation to a destination by a specified mode of transport, optionally with participants.^^xsd:string</para>
    ///   <a href="http://schema.org/TravelAction">schema:TravelAction</a>
    /// </summary>
    let TravelAction = _prefixId.prefix "TravelAction"
    /// <summary>
    ///   <para>rdfs:label : TravelAgency^^xsd:string</para>
    ///   <para>rdfs:comment : A travel agency.^^xsd:string</para>
    ///   <a href="http://schema.org/TravelAgency">schema:TravelAgency</a>
    /// </summary>
    let TravelAgency = _prefixId.prefix "TravelAgency"
    /// <summary>
    ///   <para>rdfs:comment : A trip or journey. An itinerary of visits to one or more places.^^xsd:string</para>
    ///   <para>rdfs:label : Trip^^xsd:string</para>
    ///   <a href="http://schema.org/Trip">schema:Trip</a>
    /// </summary>
    let Trip = _prefixId.prefix "Trip"
    let True = _prefixId.prefix "True"
    let Tuesday = _prefixId.prefix "Tuesday"
    /// <summary>
    ///   <para>rdfs:label : TypeAndQuantityNode^^xsd:string</para>
    ///   <para>rdfs:comment : A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.^^xsd:string</para>
    ///   <a href="http://schema.org/TypeAndQuantityNode">schema:TypeAndQuantityNode</a>
    /// </summary>
    let TypeAndQuantityNode = _prefixId.prefix "TypeAndQuantityNode"
    /// <summary>
    ///   <para>rdfs:comment : Data type: URL.^^xsd:string</para>
    ///   <para>rdfs:label : URL^^xsd:string</para>
    ///   <a href="http://schema.org/URL">schema:URL</a>
    /// </summary>
    let URL = _prefixId.prefix "URL"
    /// <summary>
    ///   <para>rdfs:comment : The act of un-registering from a service.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: antonym of UnRegisterAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/LeaveAction"&gt;LeaveAction&lt;/a&gt;: Unlike LeaveAction, UnRegisterAction implies that you are unregistering from a service you werer previously registered, rather than leaving a team/group of people.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : UnRegisterAction^^xsd:string</para>
    ///   <a href="http://schema.org/UnRegisterAction">schema:UnRegisterAction</a>
    /// </summary>
    let UnRegisterAction = _prefixId.prefix "UnRegisterAction"
    /// <summary>
    ///   <para>rdfs:comment : The price asked for a given offer by the respective organization or person.^^xsd:string</para>
    ///   <para>rdfs:label : UnitPriceSpecification^^xsd:string</para>
    ///   <a href="http://schema.org/UnitPriceSpecification">schema:UnitPriceSpecification</a>
    /// </summary>
    let UnitPriceSpecification = _prefixId.prefix "UnitPriceSpecification"
    /// <summary>
    ///   <para>rdfs:label : UpdateAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of managing by changing/editing the state of the object.^^xsd:string</para>
    ///   <a href="http://schema.org/UpdateAction">schema:UpdateAction</a>
    /// </summary>
    let UpdateAction = _prefixId.prefix "UpdateAction"
    /// <summary>
    ///   <para>rdfs:comment : The act of applying an object to its intended purpose.^^xsd:string</para>
    ///   <para>rdfs:label : UseAction^^xsd:string</para>
    ///   <a href="http://schema.org/UseAction">schema:UseAction</a>
    /// </summary>
    let UseAction = _prefixId.prefix "UseAction"
    let UsedCondition = _prefixId.prefix "UsedCondition"
    /// <summary>
    ///   <para>rdfs:label : UserBlocks^^xsd:string</para>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/UserBlocks">schema:UserBlocks</a>
    /// </summary>
    let UserBlocks = _prefixId.prefix "UserBlocks"
    /// <summary>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : UserCheckins^^xsd:string</para>
    ///   <a href="http://schema.org/UserCheckins">schema:UserCheckins</a>
    /// </summary>
    let UserCheckins = _prefixId.prefix "UserCheckins"
    /// <summary>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : UserComments^^xsd:string</para>
    ///   <a href="http://schema.org/UserComments">schema:UserComments</a>
    /// </summary>
    let UserComments = _prefixId.prefix "UserComments"
    /// <summary>
    ///   <para>rdfs:label : UserDownloads^^xsd:string</para>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/UserDownloads">schema:UserDownloads</a>
    /// </summary>
    let UserDownloads = _prefixId.prefix "UserDownloads"
    /// <summary>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : UserInteraction^^xsd:string</para>
    ///   <a href="http://schema.org/UserInteraction">schema:UserInteraction</a>
    /// </summary>
    let UserInteraction = _prefixId.prefix "UserInteraction"
    /// <summary>
    ///   <para>rdfs:label : UserLikes^^xsd:string</para>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/UserLikes">schema:UserLikes</a>
    /// </summary>
    let UserLikes = _prefixId.prefix "UserLikes"
    /// <summary>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : UserPageVisits^^xsd:string</para>
    ///   <a href="http://schema.org/UserPageVisits">schema:UserPageVisits</a>
    /// </summary>
    let UserPageVisits = _prefixId.prefix "UserPageVisits"
    /// <summary>
    ///   <para>rdfs:label : UserPlays^^xsd:string</para>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/UserPlays">schema:UserPlays</a>
    /// </summary>
    let UserPlays = _prefixId.prefix "UserPlays"
    /// <summary>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : UserPlusOnes^^xsd:string</para>
    ///   <a href="http://schema.org/UserPlusOnes">schema:UserPlusOnes</a>
    /// </summary>
    let UserPlusOnes = _prefixId.prefix "UserPlusOnes"
    /// <summary>
    ///   <para>rdfs:comment : UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use &lt;a class="localLink" href="http://schema.org/Action"&gt;Action&lt;/a&gt;-based vocabulary, alongside types such as &lt;a class="localLink" href="http://schema.org/Comment"&gt;Comment&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : UserTweets^^xsd:string</para>
    ///   <a href="http://schema.org/UserTweets">schema:UserTweets</a>
    /// </summary>
    let UserTweets = _prefixId.prefix "UserTweets"
    let VeganDiet = _prefixId.prefix "VeganDiet"
    let VegetarianDiet = _prefixId.prefix "VegetarianDiet"
    /// <summary>
    ///   <para>rdfs:comment : A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.^^xsd:string</para>
    ///   <para>rdfs:label : Vehicle^^xsd:string</para>
    ///   <a href="http://schema.org/Vehicle">schema:Vehicle</a>
    /// </summary>
    let Vehicle = _prefixId.prefix "Vehicle"
    let VenueMap = _prefixId.prefix "VenueMap"
    /// <summary>
    ///   <para>rdfs:label : VideoGallery^^xsd:string</para>
    ///   <para>rdfs:comment : Web page type: Video gallery page.^^xsd:string</para>
    ///   <a href="http://schema.org/VideoGallery">schema:VideoGallery</a>
    /// </summary>
    let VideoGallery = _prefixId.prefix "VideoGallery"
    /// <summary>
    ///   <para>rdfs:label : VideoGame^^xsd:string</para>
    ///   <para>rdfs:comment : A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.^^xsd:string</para>
    ///   <a href="http://schema.org/VideoGame">schema:VideoGame</a>
    /// </summary>
    let VideoGame = _prefixId.prefix "VideoGame"
    /// <summary>
    ///   <para>rdfs:label : VideoGameClip^^xsd:string</para>
    ///   <para>rdfs:comment : A short segment/part of a video game.^^xsd:string</para>
    ///   <a href="http://schema.org/VideoGameClip">schema:VideoGameClip</a>
    /// </summary>
    let VideoGameClip = _prefixId.prefix "VideoGameClip"
    /// <summary>
    ///   <para>rdfs:label : VideoGameSeries^^xsd:string</para>
    ///   <para>rdfs:comment : A video game series.^^xsd:string</para>
    ///   <a href="http://schema.org/VideoGameSeries">schema:VideoGameSeries</a>
    /// </summary>
    let VideoGameSeries = _prefixId.prefix "VideoGameSeries"
    /// <summary>
    ///   <para>rdfs:label : VideoObject^^xsd:string</para>
    ///   <para>rdfs:comment : A video file.^^xsd:string</para>
    ///   <a href="http://schema.org/VideoObject">schema:VideoObject</a>
    /// </summary>
    let VideoObject = _prefixId.prefix "VideoObject"
    /// <summary>
    ///   <para>rdfs:label : ViewAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of consuming static visual content.^^xsd:string</para>
    ///   <a href="http://schema.org/ViewAction">schema:ViewAction</a>
    /// </summary>
    let ViewAction = _prefixId.prefix "ViewAction"
    let VinylFormat = _prefixId.prefix "VinylFormat"
    let VirtualLocation = _prefixId.prefix "VirtualLocation"
    /// <summary>
    ///   <para>rdfs:label : VisualArtsEvent^^xsd:string</para>
    ///   <para>rdfs:comment : Event type: Visual arts event.^^xsd:string</para>
    ///   <a href="http://schema.org/VisualArtsEvent">schema:VisualArtsEvent</a>
    /// </summary>
    let VisualArtsEvent = _prefixId.prefix "VisualArtsEvent"
    /// <summary>
    ///   <para>rdfs:comment : A work of art that is primarily visual in character.^^xsd:string</para>
    ///   <para>rdfs:label : VisualArtwork^^xsd:string</para>
    ///   <a href="http://schema.org/VisualArtwork">schema:VisualArtwork</a>
    /// </summary>
    let VisualArtwork = _prefixId.prefix "VisualArtwork"
    /// <summary>
    ///   <para>rdfs:label : Volcano^^xsd:string</para>
    ///   <para>rdfs:comment : A volcano, like Fuji san.^^xsd:string</para>
    ///   <a href="http://schema.org/Volcano">schema:Volcano</a>
    /// </summary>
    let Volcano = _prefixId.prefix "Volcano"
    /// <summary>
    ///   <para>rdfs:label : VoteAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of expressing a preference from a fixed/finite/structured set of choices/options.^^xsd:string</para>
    ///   <a href="http://schema.org/VoteAction">schema:VoteAction</a>
    /// </summary>
    let VoteAction = _prefixId.prefix "VoteAction"
    /// <summary>
    ///   <para>rdfs:label : WPAdBlock^^xsd:string</para>
    ///   <para>rdfs:comment : An advertising section of the page.^^xsd:string</para>
    ///   <a href="http://schema.org/WPAdBlock">schema:WPAdBlock</a>
    /// </summary>
    let WPAdBlock = _prefixId.prefix "WPAdBlock"
    /// <summary>
    ///   <para>rdfs:label : WPFooter^^xsd:string</para>
    ///   <para>rdfs:comment : The footer section of the page.^^xsd:string</para>
    ///   <a href="http://schema.org/WPFooter">schema:WPFooter</a>
    /// </summary>
    let WPFooter = _prefixId.prefix "WPFooter"
    /// <summary>
    ///   <para>rdfs:label : WPHeader^^xsd:string</para>
    ///   <para>rdfs:comment : The header section of the page.^^xsd:string</para>
    ///   <a href="http://schema.org/WPHeader">schema:WPHeader</a>
    /// </summary>
    let WPHeader = _prefixId.prefix "WPHeader"
    /// <summary>
    ///   <para>rdfs:comment : A sidebar section of the page.^^xsd:string</para>
    ///   <para>rdfs:label : WPSideBar^^xsd:string</para>
    ///   <a href="http://schema.org/WPSideBar">schema:WPSideBar</a>
    /// </summary>
    let WPSideBar = _prefixId.prefix "WPSideBar"
    /// <summary>
    ///   <para>rdfs:label : WantAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of expressing a desire about the object. An agent wants an object.^^xsd:string</para>
    ///   <a href="http://schema.org/WantAction">schema:WantAction</a>
    /// </summary>
    let WantAction = _prefixId.prefix "WantAction"
    /// <summary>
    ///   <para>rdfs:label : WarrantyPromise^^xsd:string</para>
    ///   <para>rdfs:comment : A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.^^xsd:string</para>
    ///   <a href="http://schema.org/WarrantyPromise">schema:WarrantyPromise</a>
    /// </summary>
    let WarrantyPromise = _prefixId.prefix "WarrantyPromise"
    /// <summary>
    ///   <para>rdfs:label : WarrantyScope^^xsd:string</para>
    ///   <para>rdfs:comment : A range of of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Labor-BringIn&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PartsAndLabor-BringIn&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PartsAndLabor-PickUp&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/WarrantyScope">schema:WarrantyScope</a>
    /// </summary>
    let WarrantyScope = _prefixId.prefix "WarrantyScope"
    /// <summary>
    ///   <para>rdfs:comment : The act of consuming dynamic/moving visual content.^^xsd:string</para>
    ///   <para>rdfs:label : WatchAction^^xsd:string</para>
    ///   <a href="http://schema.org/WatchAction">schema:WatchAction</a>
    /// </summary>
    let WatchAction = _prefixId.prefix "WatchAction"
    /// <summary>
    ///   <para>rdfs:comment : A waterfall, like Niagara.^^xsd:string</para>
    ///   <para>rdfs:label : Waterfall^^xsd:string</para>
    ///   <a href="http://schema.org/Waterfall">schema:Waterfall</a>
    /// </summary>
    let Waterfall = _prefixId.prefix "Waterfall"
    /// <summary>
    ///   <para>rdfs:comment : The act of dressing oneself in clothing.^^xsd:string</para>
    ///   <para>rdfs:label : WearAction^^xsd:string</para>
    ///   <a href="http://schema.org/WearAction">schema:WearAction</a>
    /// </summary>
    let WearAction = _prefixId.prefix "WearAction"
    /// <summary>
    ///   <para>rdfs:comment : Web applications.^^xsd:string</para>
    ///   <para>rdfs:label : WebApplication^^xsd:string</para>
    ///   <a href="http://schema.org/WebApplication">schema:WebApplication</a>
    /// </summary>
    let WebApplication = _prefixId.prefix "WebApplication"
    /// <summary>
    ///   <para>rdfs:label : WebPage^^xsd:string</para>
    ///   <para>rdfs:comment : A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.^^xsd:string</para>
    ///   <a href="http://schema.org/WebPage">schema:WebPage</a>
    /// </summary>
    let WebPage = _prefixId.prefix "WebPage"
    /// <summary>
    ///   <para>rdfs:comment : A web page element, like a table or an image.^^xsd:string</para>
    ///   <para>rdfs:label : WebPageElement^^xsd:string</para>
    ///   <a href="http://schema.org/WebPageElement">schema:WebPageElement</a>
    /// </summary>
    let WebPageElement = _prefixId.prefix "WebPageElement"
    /// <summary>
    ///   <para>rdfs:comment : A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.^^xsd:string</para>
    ///   <para>rdfs:label : WebSite^^xsd:string</para>
    ///   <a href="http://schema.org/WebSite">schema:WebSite</a>
    /// </summary>
    let WebSite = _prefixId.prefix "WebSite"
    let Wednesday = _prefixId.prefix "Wednesday"
    /// <summary>
    ///   <para>rdfs:comment : A wholesale store.^^xsd:string</para>
    ///   <para>rdfs:label : WholesaleStore^^xsd:string</para>
    ///   <a href="http://schema.org/WholesaleStore">schema:WholesaleStore</a>
    /// </summary>
    let WholesaleStore = _prefixId.prefix "WholesaleStore"
    /// <summary>
    ///   <para>rdfs:label : WinAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of achieving victory in a competitive activity.^^xsd:string</para>
    ///   <a href="http://schema.org/WinAction">schema:WinAction</a>
    /// </summary>
    let WinAction = _prefixId.prefix "WinAction"
    /// <summary>
    ///   <para>rdfs:comment : A winery.^^xsd:string</para>
    ///   <para>rdfs:label : Winery^^xsd:string</para>
    ///   <a href="http://schema.org/Winery">schema:Winery</a>
    /// </summary>
    let Winery = _prefixId.prefix "Winery"
    /// <summary>
    ///   <para>rdfs:label : WorkersUnion^^xsd:string</para>
    ///   <para>schema:category : issue-243^^xsd:string</para>
    ///   <para>rdfs:comment : A Workers Union (also known as a Labor Union, Labour Union, or Trade Union) is an organization that promotes the interests of its worker members by collectively bargaining with management, organizing, and political lobbying.^^xsd:string</para>
    ///   <a href="http://schema.org/WorkersUnion">schema:WorkersUnion</a>
    /// </summary>
    let WorkersUnion = _prefixId.prefix "WorkersUnion"
    /// <summary>
    ///   <para>rdfs:label : WriteAction^^xsd:string</para>
    ///   <para>rdfs:comment : The act of authoring written creative content.^^xsd:string</para>
    ///   <a href="http://schema.org/WriteAction">schema:WriteAction</a>
    /// </summary>
    let WriteAction = _prefixId.prefix "WriteAction"
    let WritePermission = _prefixId.prefix "WritePermission"
    let XPathType = _prefixId.prefix "XPathType"
    let ZoneBoardingPolicy = _prefixId.prefix "ZoneBoardingPolicy"
    /// <summary>
    ///   <para>rdfs:comment : A zoo.^^xsd:string</para>
    ///   <para>rdfs:label : Zoo^^xsd:string</para>
    ///   <a href="http://schema.org/Zoo">schema:Zoo</a>
    /// </summary>
    let Zoo = _prefixId.prefix "Zoo"
    /// <summary>
    ///   <para>rdfs:label : about^^xsd:string</para>
    ///   <para>rdfs:comment : The subject matter of the content.^^xsd:string</para>
    ///   <para>schema:category : issue-1670^^xsd:string</para>
    ///   <a href="http://schema.org/about">schema:about</a>
    /// </summary>
    let about = _prefixId.prefix "about"
    /// <summary>
    ///   <para>rdfs:comment : The answer(s) that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.^^xsd:string</para>
    ///   <para>rdfs:label : acceptedAnswer^^xsd:string</para>
    ///   <a href="http://schema.org/acceptedAnswer">schema:acceptedAnswer</a>
    /// </summary>
    let acceptedAnswer = _prefixId.prefix "acceptedAnswer"
    /// <summary>
    ///   <para>rdfs:comment : The offer(s) -- e.g., product, quantity and price combinations -- included in the order.^^xsd:string</para>
    ///   <para>rdfs:label : acceptedOffer^^xsd:string</para>
    ///   <a href="http://schema.org/acceptedOffer">schema:acceptedOffer</a>
    /// </summary>
    let acceptedOffer = _prefixId.prefix "acceptedOffer"
    /// <summary>
    ///   <para>rdfs:comment : The payment method(s) accepted by seller for this offer.^^xsd:string</para>
    ///   <para>rdfs:label : acceptedPaymentMethod^^xsd:string</para>
    ///   <a href="http://schema.org/acceptedPaymentMethod">schema:acceptedPaymentMethod</a>
    /// </summary>
    let acceptedPaymentMethod = _prefixId.prefix "acceptedPaymentMethod"
    /// <summary>
    ///   <para>rdfs:label : acceptsReservations^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/acceptsReservations">schema:acceptsReservations</a>
    /// </summary>
    let acceptsReservations = _prefixId.prefix "acceptsReservations"
    /// <summary>
    ///   <para>rdfs:comment : Password, PIN, or access code needed for delivery (e.g. from a locker).^^xsd:string</para>
    ///   <para>rdfs:label : accessCode^^xsd:string</para>
    ///   <a href="http://schema.org/accessCode">schema:accessCode</a>
    /// </summary>
    let accessCode = _prefixId.prefix "accessCode"
    /// <summary>
    ///   <para>schema:category : issue-1110^^xsd:string</para>
    ///   <para>rdfs:comment : The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.^^xsd:string</para>
    ///   <para>rdfs:label : accessMode^^xsd:string</para>
    ///   <a href="http://schema.org/accessMode">schema:accessMode</a>
    /// </summary>
    let accessMode = _prefixId.prefix "accessMode"
    /// <summary>
    ///   <para>rdfs:label : accessModeSufficient^^xsd:string</para>
    ///   <para>rdfs:comment : A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.^^xsd:string</para>
    ///   <para>schema:category : issue-1110^^xsd:string</para>
    ///   <a href="http://schema.org/accessModeSufficient">schema:accessModeSufficient</a>
    /// </summary>
    let accessModeSufficient = _prefixId.prefix "accessModeSufficient"
    /// <summary>
    ///   <para>rdfs:label : accessibilityAPI^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).^^xsd:string</para>
    ///   <a href="http://schema.org/accessibilityAPI">schema:accessibilityAPI</a>
    /// </summary>
    let accessibilityAPI = _prefixId.prefix "accessibilityAPI"
    /// <summary>
    ///   <para>rdfs:comment : Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).^^xsd:string</para>
    ///   <para>rdfs:label : accessibilityControl^^xsd:string</para>
    ///   <a href="http://schema.org/accessibilityControl">schema:accessibilityControl</a>
    /// </summary>
    let accessibilityControl = _prefixId.prefix "accessibilityControl"
    /// <summary>
    ///   <para>rdfs:label : accessibilityFeature^^xsd:string</para>
    ///   <para>rdfs:comment : Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).^^xsd:string</para>
    ///   <a href="http://schema.org/accessibilityFeature">schema:accessibilityFeature</a>
    /// </summary>
    let accessibilityFeature = _prefixId.prefix "accessibilityFeature"
    /// <summary>
    ///   <para>rdfs:label : accessibilityHazard^^xsd:string</para>
    ///   <para>rdfs:comment : A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).^^xsd:string</para>
    ///   <a href="http://schema.org/accessibilityHazard">schema:accessibilityHazard</a>
    /// </summary>
    let accessibilityHazard = _prefixId.prefix "accessibilityHazard"
    /// <summary>
    ///   <para>rdfs:label : accessibilitySummary^^xsd:string</para>
    ///   <para>rdfs:comment : A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."^^xsd:string</para>
    ///   <para>schema:category : issue-1110^^xsd:string</para>
    ///   <a href="http://schema.org/accessibilitySummary">schema:accessibilitySummary</a>
    /// </summary>
    let accessibilitySummary = _prefixId.prefix "accessibilitySummary"
    /// <summary>
    ///   <para>rdfs:comment : The identifier for the account the payment will be applied to.^^xsd:string</para>
    ///   <para>rdfs:label : accountId^^xsd:string</para>
    ///   <a href="http://schema.org/accountId">schema:accountId</a>
    /// </summary>
    let accountId = _prefixId.prefix "accountId"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the Person that is legally accountable for the CreativeWork.^^xsd:string</para>
    ///   <para>rdfs:label : accountablePerson^^xsd:string</para>
    ///   <a href="http://schema.org/accountablePerson">schema:accountablePerson</a>
    /// </summary>
    let accountablePerson = _prefixId.prefix "accountablePerson"
    /// <summary>
    ///   <para>rdfs:label : acquiredFrom^^xsd:string</para>
    ///   <para>rdfs:comment : The organization or person from which the product was acquired.^^xsd:string</para>
    ///   <a href="http://schema.org/acquiredFrom">schema:acquiredFrom</a>
    /// </summary>
    let acquiredFrom = _prefixId.prefix "acquiredFrom"

    /// <summary>
    ///   <para>rdfs:comment : A set of requirements that a must be fulfilled in order to perform an Action. If more than one value is specied, fulfilling one set of requirements will allow the Action to be performed.^^xsd:string</para>
    ///   <para>rdfs:label : actionAccessibilityRequirement^^xsd:string</para>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <a href="http://schema.org/actionAccessibilityRequirement">schema:actionAccessibilityRequirement</a>
    /// </summary>
    let actionAccessibilityRequirement =
        _prefixId.prefix "actionAccessibilityRequirement"

    /// <summary>
    ///   <para>rdfs:label : actionApplication^^xsd:string</para>
    ///   <para>rdfs:comment : An application that can complete the request.^^xsd:string</para>
    ///   <a href="http://schema.org/actionApplication">schema:actionApplication</a>
    /// </summary>
    let actionApplication = _prefixId.prefix "actionApplication"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of object. The options subject to this action.^^xsd:string</para>
    ///   <para>rdfs:label : actionOption^^xsd:string</para>
    ///   <a href="http://schema.org/actionOption">schema:actionOption</a>
    /// </summary>
    let actionOption = _prefixId.prefix "actionOption"
    /// <summary>
    ///   <para>rdfs:comment : The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.^^xsd:string</para>
    ///   <para>rdfs:label : actionPlatform^^xsd:string</para>
    ///   <a href="http://schema.org/actionPlatform">schema:actionPlatform</a>
    /// </summary>
    let actionPlatform = _prefixId.prefix "actionPlatform"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the current disposition of the Action.^^xsd:string</para>
    ///   <para>rdfs:label : actionStatus^^xsd:string</para>
    ///   <a href="http://schema.org/actionStatus">schema:actionStatus</a>
    /// </summary>
    let actionStatus = _prefixId.prefix "actionStatus"
    /// <summary>
    ///   <para>rdfs:label : actor^^xsd:string</para>
    ///   <para>rdfs:comment : An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.^^xsd:string</para>
    ///   <a href="http://schema.org/actor">schema:actor</a>
    /// </summary>
    let actor = _prefixId.prefix "actor"
    /// <summary>
    ///   <para>rdfs:comment : An actor, e.g. in tv, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip.^^xsd:string</para>
    ///   <para>rdfs:label : actors^^xsd:string</para>
    ///   <a href="http://schema.org/actors">schema:actors</a>
    /// </summary>
    let actors = _prefixId.prefix "actors"
    /// <summary>
    ///   <para>rdfs:label : addOn^^xsd:string</para>
    ///   <para>rdfs:comment : An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).^^xsd:string</para>
    ///   <a href="http://schema.org/addOn">schema:addOn</a>
    /// </summary>
    let addOn = _prefixId.prefix "addOn"
    /// <summary>
    ///   <para>rdfs:comment : An additional name for a Person, can be used for a middle name.^^xsd:string</para>
    ///   <para>rdfs:label : additionalName^^xsd:string</para>
    ///   <a href="http://schema.org/additionalName">schema:additionalName</a>
    /// </summary>
    let additionalName = _prefixId.prefix "additionalName"
    /// <summary>
    ///   <para>rdfs:label : additionalNumberOfGuests^^xsd:string</para>
    ///   <para>rdfs:comment : If responding yes, the number of guests who will attend in addition to the invitee.^^xsd:string</para>
    ///   <a href="http://schema.org/additionalNumberOfGuests">schema:additionalNumberOfGuests</a>
    /// </summary>
    let additionalNumberOfGuests = _prefixId.prefix "additionalNumberOfGuests"
    /// <summary>
    ///   <para>rdfs:label : additionalProperty^^xsd:string</para>
    ///   <para>rdfs:comment : A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.^^xsd:string</para>
    ///   <a href="http://schema.org/additionalProperty">schema:additionalProperty</a>
    /// </summary>
    let additionalProperty = _prefixId.prefix "additionalProperty"
    /// <summary>
    ///   <para>rdfs:label : additionalType^^xsd:string</para>
    ///   <para>rdfs:comment : An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. In RDFa syntax, it is better to use the native RDFa syntax - the 'typeof' attribute - for multiple types. Schema.org tools may have only weaker understanding of extra types, in particular those defined externally.^^xsd:string</para>
    ///   <a href="http://schema.org/additionalType">schema:additionalType</a>
    /// </summary>
    let additionalType = _prefixId.prefix "additionalType"
    /// <summary>
    ///   <para>rdfs:label : address^^xsd:string</para>
    ///   <para>rdfs:comment : Physical address of the item.^^xsd:string</para>
    ///   <a href="http://schema.org/address">schema:address</a>
    /// </summary>
    let address = _prefixId.prefix "address"
    /// <summary>
    ///   <para>rdfs:comment : The country. For example, USA. You can also provide the two-letter &lt;a href="http://en.wikipedia.org/wiki/ISO_3166-1"&gt;ISO 3166-1 alpha-2 country code&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : addressCountry^^xsd:string</para>
    ///   <a href="http://schema.org/addressCountry">schema:addressCountry</a>
    /// </summary>
    let addressCountry = _prefixId.prefix "addressCountry"
    /// <summary>
    ///   <para>rdfs:label : addressLocality^^xsd:string</para>
    ///   <para>rdfs:comment : The locality in which the street address is, and which is in the region. For example, Mountain View.^^xsd:string</para>
    ///   <a href="http://schema.org/addressLocality">schema:addressLocality</a>
    /// </summary>
    let addressLocality = _prefixId.prefix "addressLocality"
    /// <summary>
    ///   <para>rdfs:comment : The region in which the locality is, and which is in the country. For example, California or another appropriate first-level &lt;a href="https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country"&gt;Administrative division&lt;/a&gt;^^xsd:string</para>
    ///   <para>rdfs:label : addressRegion^^xsd:string</para>
    ///   <a href="http://schema.org/addressRegion">schema:addressRegion</a>
    /// </summary>
    let addressRegion = _prefixId.prefix "addressRegion"
    /// <summary>
    ///   <para>rdfs:label : advanceBookingRequirement^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of time that is required between accepting the offer and the actual usage of the resource or service.^^xsd:string</para>
    ///   <a href="http://schema.org/advanceBookingRequirement">schema:advanceBookingRequirement</a>
    /// </summary>
    let advanceBookingRequirement = _prefixId.prefix "advanceBookingRequirement"
    /// <summary>
    ///   <para>rdfs:comment : An organization that this person is affiliated with. For example, a school/university, a club, or a team.^^xsd:string</para>
    ///   <para>rdfs:label : affiliation^^xsd:string</para>
    ///   <a href="http://schema.org/affiliation">schema:affiliation</a>
    /// </summary>
    let affiliation = _prefixId.prefix "affiliation"
    /// <summary>
    ///   <para>rdfs:label : afterMedia^^xsd:string</para>
    ///   <para>rdfs:comment : A media object representing the circumstances after performing this direction.^^xsd:string</para>
    ///   <a href="http://schema.org/afterMedia">schema:afterMedia</a>
    /// </summary>
    let afterMedia = _prefixId.prefix "afterMedia"
    /// <summary>
    ///   <para>rdfs:comment : The direct performer or driver of the action (animate or inanimate). e.g. &lt;em&gt;John&lt;/em&gt; wrote a book.^^xsd:string</para>
    ///   <para>rdfs:label : agent^^xsd:string</para>
    ///   <a href="http://schema.org/agent">schema:agent</a>
    /// </summary>
    let agent = _prefixId.prefix "agent"
    /// <summary>
    ///   <para>rdfs:comment : The overall rating, based on a collection of reviews or ratings, of the item.^^xsd:string</para>
    ///   <para>rdfs:label : aggregateRating^^xsd:string</para>
    ///   <a href="http://schema.org/aggregateRating">schema:aggregateRating</a>
    /// </summary>
    let aggregateRating = _prefixId.prefix "aggregateRating"
    /// <summary>
    ///   <para>rdfs:label : aircraft^^xsd:string</para>
    ///   <para>rdfs:comment : The kind of aircraft (e.g., "Boeing 747").^^xsd:string</para>
    ///   <a href="http://schema.org/aircraft">schema:aircraft</a>
    /// </summary>
    let aircraft = _prefixId.prefix "aircraft"
    /// <summary>
    ///   <para>rdfs:label : album^^xsd:string</para>
    ///   <para>rdfs:comment : A music album.^^xsd:string</para>
    ///   <a href="http://schema.org/album">schema:album</a>
    /// </summary>
    let album = _prefixId.prefix "album"
    /// <summary>
    ///   <para>rdfs:label : albumProductionType^^xsd:string</para>
    ///   <para>rdfs:comment : Classification of the album by it's type of content: soundtrack, live album, studio album, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/albumProductionType">schema:albumProductionType</a>
    /// </summary>
    let albumProductionType = _prefixId.prefix "albumProductionType"
    /// <summary>
    ///   <para>rdfs:label : albumRelease^^xsd:string</para>
    ///   <para>rdfs:comment : A release of this album.^^xsd:string</para>
    ///   <a href="http://schema.org/albumRelease">schema:albumRelease</a>
    /// </summary>
    let albumRelease = _prefixId.prefix "albumRelease"
    /// <summary>
    ///   <para>rdfs:comment : The kind of release which this album is: single, EP or album.^^xsd:string</para>
    ///   <para>rdfs:label : albumReleaseType^^xsd:string</para>
    ///   <a href="http://schema.org/albumReleaseType">schema:albumReleaseType</a>
    /// </summary>
    let albumReleaseType = _prefixId.prefix "albumReleaseType"
    /// <summary>
    ///   <para>rdfs:comment : A collection of music albums.^^xsd:string</para>
    ///   <para>rdfs:label : albums^^xsd:string</para>
    ///   <a href="http://schema.org/albums">schema:albums</a>
    /// </summary>
    let albums = _prefixId.prefix "albums"
    /// <summary>
    ///   <para>rdfs:label : alignmentType^^xsd:string</para>
    ///   <para>rdfs:comment : A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 'educationalSubject', and 'educationalLevel'.^^xsd:string</para>
    ///   <a href="http://schema.org/alignmentType">schema:alignmentType</a>
    /// </summary>
    let alignmentType = _prefixId.prefix "alignmentType"
    /// <summary>
    ///   <para>rdfs:label : alternateName^^xsd:string</para>
    ///   <para>rdfs:comment : An alias for the item.^^xsd:string</para>
    ///   <a href="http://schema.org/alternateName">schema:alternateName</a>
    /// </summary>
    let alternateName = _prefixId.prefix "alternateName"
    /// <summary>
    ///   <para>rdfs:comment : A secondary title of the CreativeWork.^^xsd:string</para>
    ///   <para>rdfs:label : alternativeHeadline^^xsd:string</para>
    ///   <a href="http://schema.org/alternativeHeadline">schema:alternativeHeadline</a>
    /// </summary>
    let alternativeHeadline = _prefixId.prefix "alternativeHeadline"
    /// <summary>
    ///   <para>rdfs:label : alumni^^xsd:string</para>
    ///   <para>rdfs:comment : Alumni of an organization.^^xsd:string</para>
    ///   <a href="http://schema.org/alumni">schema:alumni</a>
    /// </summary>
    let alumni = _prefixId.prefix "alumni"
    /// <summary>
    ///   <para>rdfs:comment : An organization that the person is an alumni of.^^xsd:string</para>
    ///   <para>rdfs:label : alumniOf^^xsd:string</para>
    ///   <a href="http://schema.org/alumniOf">schema:alumniOf</a>
    /// </summary>
    let alumniOf = _prefixId.prefix "alumniOf"
    /// <summary>
    ///   <para>rdfs:comment : An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.^^xsd:string</para>
    ///   <para>rdfs:label : amenityFeature^^xsd:string</para>
    ///   <a href="http://schema.org/amenityFeature">schema:amenityFeature</a>
    /// </summary>
    let amenityFeature = _prefixId.prefix "amenityFeature"
    /// <summary>
    ///   <para>rdfs:label : amount^^xsd:string</para>
    ///   <para>schema:category : issue-1253^^xsd:stringschema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of money.^^xsd:string</para>
    ///   <a href="http://schema.org/amount">schema:amount</a>
    /// </summary>
    let amount = _prefixId.prefix "amount"
    /// <summary>
    ///   <para>rdfs:label : amountOfThisGood^^xsd:string</para>
    ///   <para>rdfs:comment : The quantity of the goods included in the offer.^^xsd:string</para>
    ///   <a href="http://schema.org/amountOfThisGood">schema:amountOfThisGood</a>
    /// </summary>
    let amountOfThisGood = _prefixId.prefix "amountOfThisGood"
    /// <summary>
    ///   <para>rdfs:label : annualPercentageRate^^xsd:string</para>
    ///   <para>rdfs:comment : The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.^^xsd:string</para>
    ///   <a href="http://schema.org/annualPercentageRate">schema:annualPercentageRate</a>
    /// </summary>
    let annualPercentageRate = _prefixId.prefix "annualPercentageRate"
    /// <summary>
    ///   <para>rdfs:label : answerCount^^xsd:string</para>
    ///   <para>rdfs:comment : The number of answers this question has received.^^xsd:string</para>
    ///   <a href="http://schema.org/answerCount">schema:answerCount</a>
    /// </summary>
    let answerCount = _prefixId.prefix "answerCount"
    /// <summary>
    ///   <para>rdfs:comment : An application that can complete the request.^^xsd:string</para>
    ///   <para>rdfs:label : application^^xsd:string</para>
    ///   <a href="http://schema.org/application">schema:application</a>
    /// </summary>
    let application = _prefixId.prefix "application"
    /// <summary>
    ///   <para>rdfs:comment : Type of software application, e.g. 'Game, Multimedia'.^^xsd:string</para>
    ///   <para>rdfs:label : applicationCategory^^xsd:string</para>
    ///   <a href="http://schema.org/applicationCategory">schema:applicationCategory</a>
    /// </summary>
    let applicationCategory = _prefixId.prefix "applicationCategory"
    /// <summary>
    ///   <para>rdfs:label : applicationSubCategory^^xsd:string</para>
    ///   <para>rdfs:comment : Subcategory of the application, e.g. 'Arcade Game'.^^xsd:string</para>
    ///   <a href="http://schema.org/applicationSubCategory">schema:applicationSubCategory</a>
    /// </summary>
    let applicationSubCategory = _prefixId.prefix "applicationSubCategory"
    /// <summary>
    ///   <para>rdfs:label : applicationSuite^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the application suite to which the application belongs (e.g. Excel belongs to Office).^^xsd:string</para>
    ///   <a href="http://schema.org/applicationSuite">schema:applicationSuite</a>
    /// </summary>
    let applicationSuite = _prefixId.prefix "applicationSuite"
    /// <summary>
    ///   <para>rdfs:label : appliesToDeliveryMethod^^xsd:string</para>
    ///   <para>rdfs:comment : The delivery method(s) to which the delivery charge or payment charge specification applies.^^xsd:string</para>
    ///   <a href="http://schema.org/appliesToDeliveryMethod">schema:appliesToDeliveryMethod</a>
    /// </summary>
    let appliesToDeliveryMethod = _prefixId.prefix "appliesToDeliveryMethod"
    /// <summary>
    ///   <para>rdfs:label : appliesToPaymentMethod^^xsd:string</para>
    ///   <para>rdfs:comment : The payment method(s) to which the payment charge specification applies.^^xsd:string</para>
    ///   <a href="http://schema.org/appliesToPaymentMethod">schema:appliesToPaymentMethod</a>
    /// </summary>
    let appliesToPaymentMethod = _prefixId.prefix "appliesToPaymentMethod"
    /// <summary>
    ///   <para>rdfs:comment : The area within which users can expect to reach the broadcast service.^^xsd:string</para>
    ///   <para>rdfs:label : area^^xsd:string</para>
    ///   <a href="http://schema.org/area">schema:area</a>
    /// </summary>
    let area = _prefixId.prefix "area"
    /// <summary>
    ///   <para>rdfs:label : areaServed^^xsd:string</para>
    ///   <para>rdfs:comment : The geographic area where a service or offered item is provided.^^xsd:string</para>
    ///   <a href="http://schema.org/areaServed">schema:areaServed</a>
    /// </summary>
    let areaServed = _prefixId.prefix "areaServed"
    /// <summary>
    ///   <para>rdfs:label : arrivalAirport^^xsd:string</para>
    ///   <para>rdfs:comment : The airport where the flight terminates.^^xsd:string</para>
    ///   <a href="http://schema.org/arrivalAirport">schema:arrivalAirport</a>
    /// </summary>
    let arrivalAirport = _prefixId.prefix "arrivalAirport"
    /// <summary>
    ///   <para>rdfs:comment : The stop or station from which the bus arrives.^^xsd:string</para>
    ///   <para>rdfs:label : arrivalBusStop^^xsd:string</para>
    ///   <a href="http://schema.org/arrivalBusStop">schema:arrivalBusStop</a>
    /// </summary>
    let arrivalBusStop = _prefixId.prefix "arrivalBusStop"
    /// <summary>
    ///   <para>rdfs:label : arrivalGate^^xsd:string</para>
    ///   <para>rdfs:comment : Identifier of the flight's arrival gate.^^xsd:string</para>
    ///   <a href="http://schema.org/arrivalGate">schema:arrivalGate</a>
    /// </summary>
    let arrivalGate = _prefixId.prefix "arrivalGate"
    /// <summary>
    ///   <para>rdfs:comment : The platform where the train arrives.^^xsd:string</para>
    ///   <para>rdfs:label : arrivalPlatform^^xsd:string</para>
    ///   <a href="http://schema.org/arrivalPlatform">schema:arrivalPlatform</a>
    /// </summary>
    let arrivalPlatform = _prefixId.prefix "arrivalPlatform"
    /// <summary>
    ///   <para>rdfs:comment : The station where the train trip ends.^^xsd:string</para>
    ///   <para>rdfs:label : arrivalStation^^xsd:string</para>
    ///   <a href="http://schema.org/arrivalStation">schema:arrivalStation</a>
    /// </summary>
    let arrivalStation = _prefixId.prefix "arrivalStation"
    /// <summary>
    ///   <para>rdfs:comment : Identifier of the flight's arrival terminal.^^xsd:string</para>
    ///   <para>rdfs:label : arrivalTerminal^^xsd:string</para>
    ///   <a href="http://schema.org/arrivalTerminal">schema:arrivalTerminal</a>
    /// </summary>
    let arrivalTerminal = _prefixId.prefix "arrivalTerminal"
    /// <summary>
    ///   <para>rdfs:label : arrivalTime^^xsd:string</para>
    ///   <para>rdfs:comment : The expected arrival time.^^xsd:string</para>
    ///   <a href="http://schema.org/arrivalTime">schema:arrivalTime</a>
    /// </summary>
    let arrivalTime = _prefixId.prefix "arrivalTime"
    /// <summary>
    ///   <para>rdfs:label : artEdition^^xsd:string</para>
    ///   <para>rdfs:comment : The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").^^xsd:string</para>
    ///   <a href="http://schema.org/artEdition">schema:artEdition</a>
    /// </summary>
    let artEdition = _prefixId.prefix "artEdition"
    /// <summary>
    ///   <para>rdfs:label : artMedium^^xsd:string</para>
    ///   <para>rdfs:comment : The material used. (e.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)^^xsd:string</para>
    ///   <a href="http://schema.org/artMedium">schema:artMedium</a>
    /// </summary>
    let artMedium = _prefixId.prefix "artMedium"
    /// <summary>
    ///   <para>rdfs:label : artform^^xsd:string</para>
    ///   <para>rdfs:comment : e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/artform">schema:artform</a>
    /// </summary>
    let artform = _prefixId.prefix "artform"
    /// <summary>
    ///   <para>rdfs:label : articleBody^^xsd:string</para>
    ///   <para>rdfs:comment : The actual body of the article.^^xsd:string</para>
    ///   <a href="http://schema.org/articleBody">schema:articleBody</a>
    /// </summary>
    let articleBody = _prefixId.prefix "articleBody"
    /// <summary>
    ///   <para>rdfs:label : articleSection^^xsd:string</para>
    ///   <para>rdfs:comment : Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/articleSection">schema:articleSection</a>
    /// </summary>
    let articleSection = _prefixId.prefix "articleSection"
    /// <summary>
    ///   <para>rdfs:label : artworkSurface^^xsd:string</para>
    ///   <para>rdfs:comment : The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/artworkSurface">schema:artworkSurface</a>
    /// </summary>
    let artworkSurface = _prefixId.prefix "artworkSurface"
    /// <summary>
    ///   <para>rdfs:comment : Library file name e.g., mscorlib.dll, system.web.dll.^^xsd:string</para>
    ///   <para>rdfs:label : assembly^^xsd:string</para>
    ///   <a href="http://schema.org/assembly">schema:assembly</a>
    /// </summary>
    let assembly = _prefixId.prefix "assembly"
    /// <summary>
    ///   <para>rdfs:comment : Associated product/technology version. e.g., .NET Framework 4.5.^^xsd:string</para>
    ///   <para>rdfs:label : assemblyVersion^^xsd:string</para>
    ///   <a href="http://schema.org/assemblyVersion">schema:assemblyVersion</a>
    /// </summary>
    let assemblyVersion = _prefixId.prefix "assemblyVersion"
    /// <summary>
    ///   <para>rdfs:comment : A NewsArticle associated with the Media Object.^^xsd:string</para>
    ///   <para>rdfs:label : associatedArticle^^xsd:string</para>
    ///   <a href="http://schema.org/associatedArticle">schema:associatedArticle</a>
    /// </summary>
    let associatedArticle = _prefixId.prefix "associatedArticle"
    /// <summary>
    ///   <para>rdfs:comment : A media object that encodes this CreativeWork. This property is a synonym for encoding.^^xsd:string</para>
    ///   <para>rdfs:label : associatedMedia^^xsd:string</para>
    ///   <a href="http://schema.org/associatedMedia">schema:associatedMedia</a>
    /// </summary>
    let associatedMedia = _prefixId.prefix "associatedMedia"
    /// <summary>
    ///   <para>rdfs:comment : A person that acts as performing member of a sports team; a player as opposed to a coach.^^xsd:string</para>
    ///   <para>rdfs:label : athlete^^xsd:string</para>
    ///   <a href="http://schema.org/athlete">schema:athlete</a>
    /// </summary>
    let athlete = _prefixId.prefix "athlete"
    /// <summary>
    ///   <para>rdfs:comment : A person or organization attending the event.^^xsd:string</para>
    ///   <para>rdfs:label : attendee^^xsd:string</para>
    ///   <a href="http://schema.org/attendee">schema:attendee</a>
    /// </summary>
    let attendee = _prefixId.prefix "attendee"
    /// <summary>
    ///   <para>rdfs:comment : A person attending the event.^^xsd:string</para>
    ///   <para>rdfs:label : attendees^^xsd:string</para>
    ///   <a href="http://schema.org/attendees">schema:attendees</a>
    /// </summary>
    let attendees = _prefixId.prefix "attendees"
    /// <summary>
    ///   <para>rdfs:comment : An intended audience, i.e. a group for whom something was created.^^xsd:string</para>
    ///   <para>rdfs:label : audience^^xsd:string</para>
    ///   <a href="http://schema.org/audience">schema:audience</a>
    /// </summary>
    let audience = _prefixId.prefix "audience"
    /// <summary>
    ///   <para>rdfs:label : audienceType^^xsd:string</para>
    ///   <para>rdfs:comment : The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).^^xsd:string</para>
    ///   <a href="http://schema.org/audienceType">schema:audienceType</a>
    /// </summary>
    let audienceType = _prefixId.prefix "audienceType"
    /// <summary>
    ///   <para>rdfs:comment : An embedded audio object.^^xsd:string</para>
    ///   <para>rdfs:label : audio^^xsd:string</para>
    ///   <para>schema:category : issue-2420^^xsd:string</para>
    ///   <a href="http://schema.org/audio">schema:audio</a>
    /// </summary>
    let audio = _prefixId.prefix "audio"
    /// <summary>
    ///   <para>rdfs:comment : The Organization responsible for authenticating the user's subscription. For example, many media apps require a cable/satellite provider to authenticate your subscription before playing media.^^xsd:string</para>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <para>rdfs:label : authenticator^^xsd:string</para>
    ///   <a href="http://schema.org/authenticator">schema:authenticator</a>
    /// </summary>
    let authenticator = _prefixId.prefix "authenticator"
    /// <summary>
    ///   <para>rdfs:comment : The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.^^xsd:string</para>
    ///   <para>rdfs:label : author^^xsd:string</para>
    ///   <a href="http://schema.org/author">schema:author</a>
    /// </summary>
    let author = _prefixId.prefix "author"
    /// <summary>
    ///   <para>rdfs:label : availability^^xsd:string</para>
    ///   <para>rdfs:comment : The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/availability">schema:availability</a>
    /// </summary>
    let availability = _prefixId.prefix "availability"
    /// <summary>
    ///   <para>rdfs:comment : The end of the availability of the product or service included in the offer.^^xsd:string</para>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <para>rdfs:label : availabilityEnds^^xsd:string</para>
    ///   <a href="http://schema.org/availabilityEnds">schema:availabilityEnds</a>
    /// </summary>
    let availabilityEnds = _prefixId.prefix "availabilityEnds"
    /// <summary>
    ///   <para>rdfs:label : availabilityStarts^^xsd:string</para>
    ///   <para>rdfs:comment : The beginning of the availability of the product or service included in the offer.^^xsd:string</para>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <a href="http://schema.org/availabilityStarts">schema:availabilityStarts</a>
    /// </summary>
    let availabilityStarts = _prefixId.prefix "availabilityStarts"
    /// <summary>
    ///   <para>rdfs:comment : The place(s) from which the offer can be obtained (e.g. store locations).^^xsd:string</para>
    ///   <para>rdfs:label : availableAtOrFrom^^xsd:string</para>
    ///   <a href="http://schema.org/availableAtOrFrom">schema:availableAtOrFrom</a>
    /// </summary>
    let availableAtOrFrom = _prefixId.prefix "availableAtOrFrom"
    /// <summary>
    ///   <para>rdfs:label : availableChannel^^xsd:string</para>
    ///   <para>rdfs:comment : A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).^^xsd:string</para>
    ///   <a href="http://schema.org/availableChannel">schema:availableChannel</a>
    /// </summary>
    let availableChannel = _prefixId.prefix "availableChannel"
    /// <summary>
    ///   <para>rdfs:label : availableDeliveryMethod^^xsd:string</para>
    ///   <para>rdfs:comment : The delivery method(s) available for this offer.^^xsd:string</para>
    ///   <a href="http://schema.org/availableDeliveryMethod">schema:availableDeliveryMethod</a>
    /// </summary>
    let availableDeliveryMethod = _prefixId.prefix "availableDeliveryMethod"
    /// <summary>
    ///   <para>rdfs:label : availableFrom^^xsd:string</para>
    ///   <para>rdfs:comment : When the item is available for pickup from the store, locker, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/availableFrom">schema:availableFrom</a>
    /// </summary>
    let availableFrom = _prefixId.prefix "availableFrom"
    /// <summary>
    ///   <para>rdfs:label : availableLanguage^^xsd:string</para>
    ///   <para>rdfs:comment : A language someone may use with or at the item, service or place. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/inLanguage"&gt;inLanguage&lt;/a&gt;^^xsd:string</para>
    ///   <a href="http://schema.org/availableLanguage">schema:availableLanguage</a>
    /// </summary>
    let availableLanguage = _prefixId.prefix "availableLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Device required to run the application. Used in cases where a specific make/model is required to run the application.^^xsd:string</para>
    ///   <para>rdfs:label : availableOnDevice^^xsd:string</para>
    ///   <a href="http://schema.org/availableOnDevice">schema:availableOnDevice</a>
    /// </summary>
    let availableOnDevice = _prefixId.prefix "availableOnDevice"
    /// <summary>
    ///   <para>rdfs:comment : After this date, the item will no longer be available for pickup.^^xsd:string</para>
    ///   <para>rdfs:label : availableThrough^^xsd:string</para>
    ///   <a href="http://schema.org/availableThrough">schema:availableThrough</a>
    /// </summary>
    let availableThrough = _prefixId.prefix "availableThrough"
    /// <summary>
    ///   <para>rdfs:comment : An award won by or for this item.^^xsd:string</para>
    ///   <para>rdfs:label : award^^xsd:string</para>
    ///   <a href="http://schema.org/award">schema:award</a>
    /// </summary>
    let award = _prefixId.prefix "award"
    /// <summary>
    ///   <para>rdfs:comment : Awards won by or for this item.^^xsd:string</para>
    ///   <para>rdfs:label : awards^^xsd:string</para>
    ///   <a href="http://schema.org/awards">schema:awards</a>
    /// </summary>
    let awards = _prefixId.prefix "awards"
    /// <summary>
    ///   <para>rdfs:label : awayTeam^^xsd:string</para>
    ///   <para>rdfs:comment : The away team in a sports event.^^xsd:string</para>
    ///   <a href="http://schema.org/awayTeam">schema:awayTeam</a>
    /// </summary>
    let awayTeam = _prefixId.prefix "awayTeam"
    /// <summary>
    ///   <para>rdfs:comment : The base salary of the job or of an employee in an EmployeeRole.^^xsd:string</para>
    ///   <para>rdfs:label : baseSalary^^xsd:string</para>
    ///   <a href="http://schema.org/baseSalary">schema:baseSalary</a>
    /// </summary>
    let baseSalary = _prefixId.prefix "baseSalary"
    /// <summary>
    ///   <para>rdfs:label : bccRecipient^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of recipient. The recipient blind copied on a message.^^xsd:string</para>
    ///   <a href="http://schema.org/bccRecipient">schema:bccRecipient</a>
    /// </summary>
    let bccRecipient = _prefixId.prefix "bccRecipient"
    /// <summary>
    ///   <para>rdfs:comment : The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
    ///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.^^xsd:string</para>
    ///   <para>rdfs:label : bed^^xsd:string</para>
    ///   <a href="http://schema.org/bed">schema:bed</a>
    /// </summary>
    let bed = _prefixId.prefix "bed"
    /// <summary>
    ///   <para>rdfs:comment : A media object representing the circumstances before performing this direction.^^xsd:string</para>
    ///   <para>rdfs:label : beforeMedia^^xsd:string</para>
    ///   <a href="http://schema.org/beforeMedia">schema:beforeMedia</a>
    /// </summary>
    let beforeMedia = _prefixId.prefix "beforeMedia"
    /// <summary>
    ///   <para>rdfs:label : benefits^^xsd:string</para>
    ///   <para>rdfs:comment : Description of benefits associated with the job.^^xsd:string</para>
    ///   <a href="http://schema.org/benefits">schema:benefits</a>
    /// </summary>
    let benefits = _prefixId.prefix "benefits"
    /// <summary>
    ///   <para>rdfs:comment : The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.^^xsd:string</para>
    ///   <para>rdfs:label : bestRating^^xsd:string</para>
    ///   <a href="http://schema.org/bestRating">schema:bestRating</a>
    /// </summary>
    let bestRating = _prefixId.prefix "bestRating"
    /// <summary>
    ///   <para>rdfs:comment : The billing address for the order.^^xsd:string</para>
    ///   <para>rdfs:label : billingAddress^^xsd:string</para>
    ///   <a href="http://schema.org/billingAddress">schema:billingAddress</a>
    /// </summary>
    let billingAddress = _prefixId.prefix "billingAddress"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.^^xsd:string</para>
    ///   <para>rdfs:label : billingIncrement^^xsd:string</para>
    ///   <a href="http://schema.org/billingIncrement">schema:billingIncrement</a>
    /// </summary>
    let billingIncrement = _prefixId.prefix "billingIncrement"
    /// <summary>
    ///   <para>rdfs:comment : The time interval used to compute the invoice.^^xsd:string</para>
    ///   <para>rdfs:label : billingPeriod^^xsd:string</para>
    ///   <a href="http://schema.org/billingPeriod">schema:billingPeriod</a>
    /// </summary>
    let billingPeriod = _prefixId.prefix "billingPeriod"
    /// <summary>
    ///   <para>rdfs:label : birthDate^^xsd:string</para>
    ///   <para>rdfs:comment : Date of birth.^^xsd:string</para>
    ///   <a href="http://schema.org/birthDate">schema:birthDate</a>
    /// </summary>
    let birthDate = _prefixId.prefix "birthDate"
    /// <summary>
    ///   <para>rdfs:label : birthPlace^^xsd:string</para>
    ///   <para>rdfs:comment : The place where the person was born.^^xsd:string</para>
    ///   <a href="http://schema.org/birthPlace">schema:birthPlace</a>
    /// </summary>
    let birthPlace = _prefixId.prefix "birthPlace"
    /// <summary>
    ///   <para>rdfs:label : bitrate^^xsd:string</para>
    ///   <para>rdfs:comment : The bitrate of the media object.^^xsd:string</para>
    ///   <a href="http://schema.org/bitrate">schema:bitrate</a>
    /// </summary>
    let bitrate = _prefixId.prefix "bitrate"
    /// <summary>
    ///   <para>rdfs:label : blogPost^^xsd:string</para>
    ///   <para>rdfs:comment : A posting that is part of this blog.^^xsd:string</para>
    ///   <a href="http://schema.org/blogPost">schema:blogPost</a>
    /// </summary>
    let blogPost = _prefixId.prefix "blogPost"
    /// <summary>
    ///   <para>rdfs:comment : The postings that are part of this blog.^^xsd:string</para>
    ///   <para>rdfs:label : blogPosts^^xsd:string</para>
    ///   <a href="http://schema.org/blogPosts">schema:blogPosts</a>
    /// </summary>
    let blogPosts = _prefixId.prefix "blogPosts"
    /// <summary>
    ///   <para>rdfs:comment : The airline-specific indicator of boarding order / preference.^^xsd:string</para>
    ///   <para>rdfs:label : boardingGroup^^xsd:string</para>
    ///   <a href="http://schema.org/boardingGroup">schema:boardingGroup</a>
    /// </summary>
    let boardingGroup = _prefixId.prefix "boardingGroup"
    /// <summary>
    ///   <para>rdfs:comment : The type of boarding policy used by the airline (e.g. zone-based or group-based).^^xsd:string</para>
    ///   <para>rdfs:label : boardingPolicy^^xsd:string</para>
    ///   <a href="http://schema.org/boardingPolicy">schema:boardingPolicy</a>
    /// </summary>
    let boardingPolicy = _prefixId.prefix "boardingPolicy"
    /// <summary>
    ///   <para>rdfs:comment : The edition of the book.^^xsd:string</para>
    ///   <para>rdfs:label : bookEdition^^xsd:string</para>
    ///   <a href="http://schema.org/bookEdition">schema:bookEdition</a>
    /// </summary>
    let bookEdition = _prefixId.prefix "bookEdition"
    /// <summary>
    ///   <para>rdfs:comment : The format of the book.^^xsd:string</para>
    ///   <para>rdfs:label : bookFormat^^xsd:string</para>
    ///   <a href="http://schema.org/bookFormat">schema:bookFormat</a>
    /// </summary>
    let bookFormat = _prefixId.prefix "bookFormat"
    /// <summary>
    ///   <para>rdfs:label : bookingAgent^^xsd:string</para>
    ///   <para>rdfs:comment : 'bookingAgent' is an out-dated term indicating a 'broker' that serves as a booking agent.^^xsd:string</para>
    ///   <a href="http://schema.org/bookingAgent">schema:bookingAgent</a>
    /// </summary>
    let bookingAgent = _prefixId.prefix "bookingAgent"
    /// <summary>
    ///   <para>rdfs:label : bookingTime^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time the reservation was booked.^^xsd:string</para>
    ///   <a href="http://schema.org/bookingTime">schema:bookingTime</a>
    /// </summary>
    let bookingTime = _prefixId.prefix "bookingTime"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of participant. The person that borrows the object being lent.^^xsd:string</para>
    ///   <para>rdfs:label : borrower^^xsd:string</para>
    ///   <a href="http://schema.org/borrower">schema:borrower</a>
    /// </summary>
    let borrower = _prefixId.prefix "borrower"
    /// <summary>
    ///   <para>rdfs:label : box^^xsd:string</para>
    ///   <para>rdfs:comment : A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.^^xsd:string</para>
    ///   <a href="http://schema.org/box">schema:box</a>
    /// </summary>
    let box = _prefixId.prefix "box"
    /// <summary>
    ///   <para>rdfs:comment : A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
    ///
    /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.^^xsd:string</para>
    ///   <para>rdfs:label : branchCode^^xsd:string</para>
    ///   <a href="http://schema.org/branchCode">schema:branchCode</a>
    /// </summary>
    let branchCode = _prefixId.prefix "branchCode"
    /// <summary>
    ///   <para>rdfs:label : branchOf^^xsd:string</para>
    ///   <para>rdfs:comment : The larger organization that this local business is a branch of, if any. Not to be confused with (anatomical)&lt;a class="localLink" href="http://schema.org/branch"&gt;branch&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/branchOf">schema:branchOf</a>
    /// </summary>
    let branchOf = _prefixId.prefix "branchOf"
    /// <summary>
    ///   <para>rdfs:label : brand^^xsd:string</para>
    ///   <para>rdfs:comment : The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.^^xsd:string</para>
    ///   <a href="http://schema.org/brand">schema:brand</a>
    /// </summary>
    let brand = _prefixId.prefix "brand"
    /// <summary>
    ///   <para>rdfs:label : breadcrumb^^xsd:string</para>
    ///   <para>rdfs:comment : A set of links that can help a user understand and navigate a website hierarchy.^^xsd:string</para>
    ///   <a href="http://schema.org/breadcrumb">schema:breadcrumb</a>
    /// </summary>
    let breadcrumb = _prefixId.prefix "breadcrumb"
    /// <summary>
    ///   <para>rdfs:label : broadcastAffiliateOf^^xsd:string</para>
    ///   <para>rdfs:comment : The media network(s) whose content is broadcast on this station.^^xsd:string</para>
    ///   <a href="http://schema.org/broadcastAffiliateOf">schema:broadcastAffiliateOf</a>
    /// </summary>
    let broadcastAffiliateOf = _prefixId.prefix "broadcastAffiliateOf"
    /// <summary>
    ///   <para>rdfs:label : broadcastChannelId^^xsd:string</para>
    ///   <para>rdfs:comment : The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.^^xsd:string</para>
    ///   <a href="http://schema.org/broadcastChannelId">schema:broadcastChannelId</a>
    /// </summary>
    let broadcastChannelId = _prefixId.prefix "broadcastChannelId"
    /// <summary>
    ///   <para>rdfs:label : broadcastDisplayName^^xsd:string</para>
    ///   <para>rdfs:comment : The name displayed in the channel guide. For many US affiliates, it is the network name.^^xsd:string</para>
    ///   <a href="http://schema.org/broadcastDisplayName">schema:broadcastDisplayName</a>
    /// </summary>
    let broadcastDisplayName = _prefixId.prefix "broadcastDisplayName"
    /// <summary>
    ///   <para>rdfs:label : broadcastFrequency^^xsd:string</para>
    ///   <para>rdfs:comment : The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".^^xsd:string</para>
    ///   <para>schema:category : issue-1004^^xsd:string</para>
    ///   <a href="http://schema.org/broadcastFrequency">schema:broadcastFrequency</a>
    /// </summary>
    let broadcastFrequency = _prefixId.prefix "broadcastFrequency"
    /// <summary>
    ///   <para>rdfs:comment : The frequency in MHz for a particular broadcast.^^xsd:string</para>
    ///   <para>rdfs:label : broadcastFrequencyValue^^xsd:string</para>
    ///   <para>schema:category : issue-1004^^xsd:string</para>
    ///   <a href="http://schema.org/broadcastFrequencyValue">schema:broadcastFrequencyValue</a>
    /// </summary>
    let broadcastFrequencyValue = _prefixId.prefix "broadcastFrequencyValue"
    /// <summary>
    ///   <para>rdfs:comment : The event being broadcast such as a sporting event or awards ceremony.^^xsd:string</para>
    ///   <para>rdfs:label : broadcastOfEvent^^xsd:string</para>
    ///   <a href="http://schema.org/broadcastOfEvent">schema:broadcastOfEvent</a>
    /// </summary>
    let broadcastOfEvent = _prefixId.prefix "broadcastOfEvent"
    /// <summary>
    ///   <para>rdfs:comment : The type of service required to have access to the channel (e.g. Standard or Premium).^^xsd:string</para>
    ///   <para>rdfs:label : broadcastServiceTier^^xsd:string</para>
    ///   <a href="http://schema.org/broadcastServiceTier">schema:broadcastServiceTier</a>
    /// </summary>
    let broadcastServiceTier = _prefixId.prefix "broadcastServiceTier"
    /// <summary>
    ///   <para>rdfs:comment : The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts^^xsd:string</para>
    ///   <para>rdfs:label : broadcastTimezone^^xsd:string</para>
    ///   <a href="http://schema.org/broadcastTimezone">schema:broadcastTimezone</a>
    /// </summary>
    let broadcastTimezone = _prefixId.prefix "broadcastTimezone"
    /// <summary>
    ///   <para>rdfs:label : broadcaster^^xsd:string</para>
    ///   <para>rdfs:comment : The organization owning or operating the broadcast service.^^xsd:string</para>
    ///   <a href="http://schema.org/broadcaster">schema:broadcaster</a>
    /// </summary>
    let broadcaster = _prefixId.prefix "broadcaster"
    /// <summary>
    ///   <para>rdfs:label : broker^^xsd:string</para>
    ///   <para>rdfs:comment : An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.^^xsd:string</para>
    ///   <a href="http://schema.org/broker">schema:broker</a>
    /// </summary>
    let broker = _prefixId.prefix "broker"
    /// <summary>
    ///   <para>rdfs:label : browserRequirements^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.^^xsd:string</para>
    ///   <a href="http://schema.org/browserRequirements">schema:browserRequirements</a>
    /// </summary>
    let browserRequirements = _prefixId.prefix "browserRequirements"
    /// <summary>
    ///   <para>rdfs:label : busName^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the bus (e.g. Bolt Express).^^xsd:string</para>
    ///   <a href="http://schema.org/busName">schema:busName</a>
    /// </summary>
    let busName = _prefixId.prefix "busName"
    /// <summary>
    ///   <para>rdfs:comment : The unique identifier for the bus.^^xsd:string</para>
    ///   <para>rdfs:label : busNumber^^xsd:string</para>
    ///   <a href="http://schema.org/busNumber">schema:busNumber</a>
    /// </summary>
    let busNumber = _prefixId.prefix "busNumber"
    /// <summary>
    ///   <para>rdfs:label : businessFunction^^xsd:string</para>
    ///   <para>rdfs:comment : The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.^^xsd:string</para>
    ///   <a href="http://schema.org/businessFunction">schema:businessFunction</a>
    /// </summary>
    let businessFunction = _prefixId.prefix "businessFunction"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of participant. The participant/person/organization that bought the object.^^xsd:string</para>
    ///   <para>rdfs:label : buyer^^xsd:string</para>
    ///   <a href="http://schema.org/buyer">schema:buyer</a>
    /// </summary>
    let buyer = _prefixId.prefix "buyer"
    /// <summary>
    ///   <para>rdfs:label : byArtist^^xsd:string</para>
    ///   <para>rdfs:comment : The artist that performed this album or recording.^^xsd:string</para>
    ///   <a href="http://schema.org/byArtist">schema:byArtist</a>
    /// </summary>
    let byArtist = _prefixId.prefix "byArtist"
    /// <summary>
    ///   <para>rdfs:label : calories^^xsd:string</para>
    ///   <para>rdfs:comment : The number of calories.^^xsd:string</para>
    ///   <a href="http://schema.org/calories">schema:calories</a>
    /// </summary>
    let calories = _prefixId.prefix "calories"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of object. The candidate subject of this action.^^xsd:string</para>
    ///   <para>rdfs:label : candidate^^xsd:string</para>
    ///   <a href="http://schema.org/candidate">schema:candidate</a>
    /// </summary>
    let candidate = _prefixId.prefix "candidate"
    /// <summary>
    ///   <para>rdfs:comment : The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : caption^^xsd:string</para>
    ///   <a href="http://schema.org/caption">schema:caption</a>
    /// </summary>
    let caption = _prefixId.prefix "caption"
    /// <summary>
    ///   <para>rdfs:comment : The number of grams of carbohydrates.^^xsd:string</para>
    ///   <para>rdfs:label : carbohydrateContent^^xsd:string</para>
    ///   <a href="http://schema.org/carbohydrateContent">schema:carbohydrateContent</a>
    /// </summary>
    let carbohydrateContent = _prefixId.prefix "carbohydrateContent"
    /// <summary>
    ///   <para>rdfs:label : cargoVolume^^xsd:string</para>
    ///   <para>rdfs:comment : The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): LTR for liters, FTQ for cubic foot/feet&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.^^xsd:string</para>
    ///   <a href="http://schema.org/cargoVolume">schema:cargoVolume</a>
    /// </summary>
    let cargoVolume = _prefixId.prefix "cargoVolume"
    /// <summary>
    ///   <para>rdfs:comment : 'carrier' is an out-dated term indicating the 'provider' for parcel delivery and flights.^^xsd:string</para>
    ///   <para>rdfs:label : carrier^^xsd:string</para>
    ///   <a href="http://schema.org/carrier">schema:carrier</a>
    /// </summary>
    let carrier = _prefixId.prefix "carrier"
    /// <summary>
    ///   <para>rdfs:label : carrierRequirements^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).^^xsd:string</para>
    ///   <a href="http://schema.org/carrierRequirements">schema:carrierRequirements</a>
    /// </summary>
    let carrierRequirements = _prefixId.prefix "carrierRequirements"
    /// <summary>
    ///   <para>rdfs:label : catalog^^xsd:string</para>
    ///   <para>rdfs:comment : A data catalog which contains this dataset.^^xsd:string</para>
    ///   <a href="http://schema.org/catalog">schema:catalog</a>
    /// </summary>
    let catalog = _prefixId.prefix "catalog"
    /// <summary>
    ///   <para>rdfs:comment : The catalog number for the release.^^xsd:string</para>
    ///   <para>rdfs:label : catalogNumber^^xsd:string</para>
    ///   <a href="http://schema.org/catalogNumber">schema:catalogNumber</a>
    /// </summary>
    let catalogNumber = _prefixId.prefix "catalogNumber"
    /// <summary>
    ///   <para>rdfs:comment : A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.^^xsd:string</para>
    ///   <para>rdfs:label : category^^xsd:string</para>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <a href="http://schema.org/category">schema:category</a>
    /// </summary>
    let category = _prefixId.prefix "category"
    /// <summary>
    ///   <para>rdfs:label : ccRecipient^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of recipient. The recipient copied on a message.^^xsd:string</para>
    ///   <a href="http://schema.org/ccRecipient">schema:ccRecipient</a>
    /// </summary>
    let ccRecipient = _prefixId.prefix "ccRecipient"
    /// <summary>
    ///   <para>rdfs:comment : Fictional person connected with a creative work.^^xsd:string</para>
    ///   <para>rdfs:label : character^^xsd:string</para>
    ///   <a href="http://schema.org/character">schema:character</a>
    /// </summary>
    let character = _prefixId.prefix "character"
    /// <summary>
    ///   <para>rdfs:comment : A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).^^xsd:string</para>
    ///   <para>rdfs:label : characterAttribute^^xsd:string</para>
    ///   <a href="http://schema.org/characterAttribute">schema:characterAttribute</a>
    /// </summary>
    let characterAttribute = _prefixId.prefix "characterAttribute"
    /// <summary>
    ///   <para>rdfs:comment : The name of a character played in some acting or performing role, i.e. in a PerformanceRole.^^xsd:string</para>
    ///   <para>rdfs:label : characterName^^xsd:string</para>
    ///   <a href="http://schema.org/characterName">schema:characterName</a>
    /// </summary>
    let characterName = _prefixId.prefix "characterName"
    /// <summary>
    ///   <para>rdfs:label : cheatCode^^xsd:string</para>
    ///   <para>rdfs:comment : Cheat codes to the game.^^xsd:string</para>
    ///   <a href="http://schema.org/cheatCode">schema:cheatCode</a>
    /// </summary>
    let cheatCode = _prefixId.prefix "cheatCode"
    /// <summary>
    ///   <para>rdfs:label : checkinTime^^xsd:string</para>
    ///   <para>rdfs:comment : The earliest someone may check into a lodging establishment.^^xsd:string</para>
    ///   <a href="http://schema.org/checkinTime">schema:checkinTime</a>
    /// </summary>
    let checkinTime = _prefixId.prefix "checkinTime"
    /// <summary>
    ///   <para>rdfs:comment : The latest someone may check out of a lodging establishment.^^xsd:string</para>
    ///   <para>rdfs:label : checkoutTime^^xsd:string</para>
    ///   <a href="http://schema.org/checkoutTime">schema:checkoutTime</a>
    /// </summary>
    let checkoutTime = _prefixId.prefix "checkoutTime"
    /// <summary>
    ///   <para>rdfs:label : childMaxAge^^xsd:string</para>
    ///   <para>rdfs:comment : Maximal age of the child.^^xsd:string</para>
    ///   <a href="http://schema.org/childMaxAge">schema:childMaxAge</a>
    /// </summary>
    let childMaxAge = _prefixId.prefix "childMaxAge"
    /// <summary>
    ///   <para>rdfs:label : childMinAge^^xsd:string</para>
    ///   <para>rdfs:comment : Minimal age of the child.^^xsd:string</para>
    ///   <a href="http://schema.org/childMinAge">schema:childMinAge</a>
    /// </summary>
    let childMinAge = _prefixId.prefix "childMinAge"
    /// <summary>
    ///   <para>rdfs:label : children^^xsd:string</para>
    ///   <para>rdfs:comment : A child of the person.^^xsd:string</para>
    ///   <a href="http://schema.org/children">schema:children</a>
    /// </summary>
    let children = _prefixId.prefix "children"
    /// <summary>
    ///   <para>rdfs:comment : The number of milligrams of cholesterol.^^xsd:string</para>
    ///   <para>rdfs:label : cholesterolContent^^xsd:string</para>
    ///   <a href="http://schema.org/cholesterolContent">schema:cholesterolContent</a>
    /// </summary>
    let cholesterolContent = _prefixId.prefix "cholesterolContent"
    /// <summary>
    ///   <para>rdfs:label : circle^^xsd:string</para>
    ///   <para>rdfs:comment : A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.^^xsd:string</para>
    ///   <a href="http://schema.org/circle">schema:circle</a>
    /// </summary>
    let circle = _prefixId.prefix "circle"
    /// <summary>
    ///   <para>rdfs:comment : A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.^^xsd:string</para>
    ///   <para>rdfs:label : citation^^xsd:string</para>
    ///   <a href="http://schema.org/citation">schema:citation</a>
    /// </summary>
    let citation = _prefixId.prefix "citation"
    /// <summary>
    ///   <para>schema:category : issue-1061^^xsd:string</para>
    ///   <para>rdfs:comment : A short summary of the specific claims reviewed in a ClaimReview.^^xsd:string</para>
    ///   <para>rdfs:label : claimReviewed^^xsd:string</para>
    ///   <a href="http://schema.org/claimReviewed">schema:claimReviewed</a>
    /// </summary>
    let claimReviewed = _prefixId.prefix "claimReviewed"
    /// <summary>
    ///   <para>rdfs:label : clipNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Position of the clip within an ordered group of clips.^^xsd:string</para>
    ///   <a href="http://schema.org/clipNumber">schema:clipNumber</a>
    /// </summary>
    let clipNumber = _prefixId.prefix "clipNumber"
    /// <summary>
    ///   <para>rdfs:label : closes^^xsd:string</para>
    ///   <para>rdfs:comment : The closing hour of the place or service on the given day(s) of the week.^^xsd:string</para>
    ///   <a href="http://schema.org/closes">schema:closes</a>
    /// </summary>
    let closes = _prefixId.prefix "closes"
    /// <summary>
    ///   <para>rdfs:label : coach^^xsd:string</para>
    ///   <para>rdfs:comment : A person that acts in a coaching role for a sports team.^^xsd:string</para>
    ///   <a href="http://schema.org/coach">schema:coach</a>
    /// </summary>
    let coach = _prefixId.prefix "coach"
    /// <summary>
    ///   <para>rdfs:comment : Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex).^^xsd:string</para>
    ///   <para>rdfs:label : codeRepository^^xsd:string</para>
    ///   <a href="http://schema.org/codeRepository">schema:codeRepository</a>
    /// </summary>
    let codeRepository = _prefixId.prefix "codeRepository"
    /// <summary>
    ///   <para>rdfs:label : codeSampleType^^xsd:string</para>
    ///   <para>rdfs:comment : What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.^^xsd:string</para>
    ///   <a href="http://schema.org/codeSampleType">schema:codeSampleType</a>
    /// </summary>
    let codeSampleType = _prefixId.prefix "codeSampleType"
    /// <summary>
    ///   <para>rdfs:comment : A colleague of the person.^^xsd:string</para>
    ///   <para>rdfs:label : colleague^^xsd:string</para>
    ///   <a href="http://schema.org/colleague">schema:colleague</a>
    /// </summary>
    let colleague = _prefixId.prefix "colleague"
    /// <summary>
    ///   <para>rdfs:comment : A colleague of the person.^^xsd:string</para>
    ///   <para>rdfs:label : colleagues^^xsd:string</para>
    ///   <a href="http://schema.org/colleagues">schema:colleagues</a>
    /// </summary>
    let colleagues = _prefixId.prefix "colleagues"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of object. The collection target of the action.^^xsd:string</para>
    ///   <para>rdfs:label : collection^^xsd:string</para>
    ///   <a href="http://schema.org/collection">schema:collection</a>
    /// </summary>
    let collection = _prefixId.prefix "collection"
    /// <summary>
    ///   <para>rdfs:label : color^^xsd:string</para>
    ///   <para>rdfs:comment : The color of the product.^^xsd:string</para>
    ///   <a href="http://schema.org/color">schema:color</a>
    /// </summary>
    let color = _prefixId.prefix "color"
    /// <summary>
    ///   <para>rdfs:comment : Comments, typically from users.^^xsd:string</para>
    ///   <para>rdfs:label : comment^^xsd:string</para>
    ///   <a href="http://schema.org/comment">schema:comment</a>
    /// </summary>
    let comment = _prefixId.prefix "comment"
    /// <summary>
    ///   <para>rdfs:label : commentCount^^xsd:string</para>
    ///   <para>rdfs:comment : The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.^^xsd:string</para>
    ///   <a href="http://schema.org/commentCount">schema:commentCount</a>
    /// </summary>
    let commentCount = _prefixId.prefix "commentCount"
    /// <summary>
    ///   <para>rdfs:comment : The text of the UserComment.^^xsd:string</para>
    ///   <para>rdfs:label : commentText^^xsd:string</para>
    ///   <a href="http://schema.org/commentText">schema:commentText</a>
    /// </summary>
    let commentText = _prefixId.prefix "commentText"
    /// <summary>
    ///   <para>rdfs:comment : The time at which the UserComment was made.^^xsd:string</para>
    ///   <para>rdfs:label : commentTime^^xsd:string</para>
    ///   <a href="http://schema.org/commentTime">schema:commentTime</a>
    /// </summary>
    let commentTime = _prefixId.prefix "commentTime"
    /// <summary>
    ///   <para>rdfs:label : competitor^^xsd:string</para>
    ///   <para>rdfs:comment : A competitor in a sports event.^^xsd:string</para>
    ///   <a href="http://schema.org/competitor">schema:competitor</a>
    /// </summary>
    let competitor = _prefixId.prefix "competitor"
    /// <summary>
    ///   <para>rdfs:comment : The person or organization who wrote a composition, or who is the composer of a work performed at some event.^^xsd:string</para>
    ///   <para>rdfs:label : composer^^xsd:string</para>
    ///   <a href="http://schema.org/composer">schema:composer</a>
    /// </summary>
    let composer = _prefixId.prefix "composer"
    /// <summary>
    ///   <para>rdfs:comment : A number that confirms the given order or payment has been received.^^xsd:string</para>
    ///   <para>rdfs:label : confirmationNumber^^xsd:string</para>
    ///   <a href="http://schema.org/confirmationNumber">schema:confirmationNumber</a>
    /// </summary>
    let confirmationNumber = _prefixId.prefix "confirmationNumber"
    /// <summary>
    ///   <para>rdfs:comment : An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).^^xsd:string</para>
    ///   <para>rdfs:label : contactOption^^xsd:string</para>
    ///   <a href="http://schema.org/contactOption">schema:contactOption</a>
    /// </summary>
    let contactOption = _prefixId.prefix "contactOption"
    /// <summary>
    ///   <para>rdfs:comment : A contact point for a person or organization.^^xsd:string</para>
    ///   <para>rdfs:label : contactPoint^^xsd:string</para>
    ///   <a href="http://schema.org/contactPoint">schema:contactPoint</a>
    /// </summary>
    let contactPoint = _prefixId.prefix "contactPoint"
    /// <summary>
    ///   <para>rdfs:label : contactPoints^^xsd:string</para>
    ///   <para>rdfs:comment : A contact point for a person or organization.^^xsd:string</para>
    ///   <a href="http://schema.org/contactPoints">schema:contactPoints</a>
    /// </summary>
    let contactPoints = _prefixId.prefix "contactPoints"
    /// <summary>
    ///   <para>rdfs:comment : A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.^^xsd:string</para>
    ///   <para>rdfs:label : contactType^^xsd:string</para>
    ///   <a href="http://schema.org/contactType">schema:contactType</a>
    /// </summary>
    let contactType = _prefixId.prefix "contactType"
    /// <summary>
    ///   <para>rdfs:comment : The basic containment relation between a place and one that contains it.^^xsd:string</para>
    ///   <para>rdfs:label : containedIn^^xsd:string</para>
    ///   <a href="http://schema.org/containedIn">schema:containedIn</a>
    /// </summary>
    let containedIn = _prefixId.prefix "containedIn"
    /// <summary>
    ///   <para>rdfs:comment : The basic containment relation between a place and one that contains it.^^xsd:string</para>
    ///   <para>rdfs:label : containedInPlace^^xsd:string</para>
    ///   <a href="http://schema.org/containedInPlace">schema:containedInPlace</a>
    /// </summary>
    let containedInPlace = _prefixId.prefix "containedInPlace"
    /// <summary>
    ///   <para>rdfs:comment : The basic containment relation between a place and another that it contains.^^xsd:string</para>
    ///   <para>rdfs:label : containsPlace^^xsd:string</para>
    ///   <a href="http://schema.org/containsPlace">schema:containsPlace</a>
    /// </summary>
    let containsPlace = _prefixId.prefix "containsPlace"
    /// <summary>
    ///   <para>rdfs:comment : A season that is part of the media series.^^xsd:string</para>
    ///   <para>rdfs:label : containsSeason^^xsd:string</para>
    ///   <a href="http://schema.org/containsSeason">schema:containsSeason</a>
    /// </summary>
    let containsSeason = _prefixId.prefix "containsSeason"
    /// <summary>
    ///   <para>rdfs:label : contentLocation^^xsd:string</para>
    ///   <para>rdfs:comment : The location depicted or described in the content. For example, the location in a photograph or painting.^^xsd:string</para>
    ///   <a href="http://schema.org/contentLocation">schema:contentLocation</a>
    /// </summary>
    let contentLocation = _prefixId.prefix "contentLocation"
    /// <summary>
    ///   <para>rdfs:label : contentRating^^xsd:string</para>
    ///   <para>rdfs:comment : Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.^^xsd:string</para>
    ///   <a href="http://schema.org/contentRating">schema:contentRating</a>
    /// </summary>
    let contentRating = _prefixId.prefix "contentRating"
    /// <summary>
    ///   <para>rdfs:comment : File size in (mega/kilo) bytes.^^xsd:string</para>
    ///   <para>rdfs:label : contentSize^^xsd:string</para>
    ///   <a href="http://schema.org/contentSize">schema:contentSize</a>
    /// </summary>
    let contentSize = _prefixId.prefix "contentSize"
    /// <summary>
    ///   <para>rdfs:comment : The supported content type(s) for an EntryPoint response.^^xsd:string</para>
    ///   <para>rdfs:label : contentType^^xsd:string</para>
    ///   <a href="http://schema.org/contentType">schema:contentType</a>
    /// </summary>
    let contentType = _prefixId.prefix "contentType"
    /// <summary>
    ///   <para>rdfs:label : contentUrl^^xsd:string</para>
    ///   <para>rdfs:comment : Actual bytes of the media object, for example the image file or video file.^^xsd:string</para>
    ///   <a href="http://schema.org/contentUrl">schema:contentUrl</a>
    /// </summary>
    let contentUrl = _prefixId.prefix "contentUrl"
    /// <summary>
    ///   <para>rdfs:label : contributor^^xsd:string</para>
    ///   <para>rdfs:comment : A secondary contributor to the CreativeWork or Event.^^xsd:string</para>
    ///   <a href="http://schema.org/contributor">schema:contributor</a>
    /// </summary>
    let contributor = _prefixId.prefix "contributor"
    /// <summary>
    ///   <para>rdfs:comment : The time it takes to actually cook the dish, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : cookTime^^xsd:string</para>
    ///   <a href="http://schema.org/cookTime">schema:cookTime</a>
    /// </summary>
    let cookTime = _prefixId.prefix "cookTime"
    /// <summary>
    ///   <para>rdfs:comment : The method of cooking, such as Frying, Steaming, ...^^xsd:string</para>
    ///   <para>rdfs:label : cookingMethod^^xsd:string</para>
    ///   <a href="http://schema.org/cookingMethod">schema:cookingMethod</a>
    /// </summary>
    let cookingMethod = _prefixId.prefix "cookingMethod"
    /// <summary>
    ///   <para>rdfs:label : copyrightHolder^^xsd:string</para>
    ///   <para>rdfs:comment : The party holding the legal copyright to the CreativeWork.^^xsd:string</para>
    ///   <a href="http://schema.org/copyrightHolder">schema:copyrightHolder</a>
    /// </summary>
    let copyrightHolder = _prefixId.prefix "copyrightHolder"
    /// <summary>
    ///   <para>rdfs:label : copyrightYear^^xsd:string</para>
    ///   <para>rdfs:comment : The year during which the claimed copyright for the CreativeWork was first asserted.^^xsd:string</para>
    ///   <a href="http://schema.org/copyrightYear">schema:copyrightYear</a>
    /// </summary>
    let copyrightYear = _prefixId.prefix "copyrightYear"
    /// <summary>
    ///   <para>rdfs:label : countriesNotSupported^^xsd:string</para>
    ///   <para>rdfs:comment : Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.^^xsd:string</para>
    ///   <a href="http://schema.org/countriesNotSupported">schema:countriesNotSupported</a>
    /// </summary>
    let countriesNotSupported = _prefixId.prefix "countriesNotSupported"
    /// <summary>
    ///   <para>rdfs:comment : Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.^^xsd:string</para>
    ///   <para>rdfs:label : countriesSupported^^xsd:string</para>
    ///   <a href="http://schema.org/countriesSupported">schema:countriesSupported</a>
    /// </summary>
    let countriesSupported = _prefixId.prefix "countriesSupported"
    /// <summary>
    ///   <para>rdfs:label : countryOfOrigin^^xsd:string</para>
    ///   <para>rdfs:comment : The country of the principal offices of the production company or individual responsible for the movie or program.^^xsd:string</para>
    ///   <a href="http://schema.org/countryOfOrigin">schema:countryOfOrigin</a>
    /// </summary>
    let countryOfOrigin = _prefixId.prefix "countryOfOrigin"
    /// <summary>
    ///   <para>rdfs:label : course^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of location. The course where this action was taken.^^xsd:string</para>
    ///   <a href="http://schema.org/course">schema:course</a>
    /// </summary>
    let course = _prefixId.prefix "course"
    /// <summary>
    ///   <para>rdfs:label : courseCode^^xsd:string</para>
    ///   <para>rdfs:comment : The identifier for the &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; used by the course &lt;a class="localLink" href="http://schema.org/provider"&gt;provider&lt;/a&gt; (e.g. CS101 or 6.001).^^xsd:string</para>
    ///   <a href="http://schema.org/courseCode">schema:courseCode</a>
    /// </summary>
    let courseCode = _prefixId.prefix "courseCode"
    /// <summary>
    ///   <para>rdfs:comment : The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).^^xsd:string</para>
    ///   <para>rdfs:label : courseMode^^xsd:string</para>
    ///   <a href="http://schema.org/courseMode">schema:courseMode</a>
    /// </summary>
    let courseMode = _prefixId.prefix "courseMode"
    /// <summary>
    ///   <para>rdfs:label : coursePrerequisites^^xsd:string</para>
    ///   <para>rdfs:comment : Requirements for taking the Course. May be completion of another &lt;a class="localLink" href="http://schema.org/Course"&gt;Course&lt;/a&gt; or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using &lt;a class="localLink" href="http://schema.org/AlignmentObject"&gt;AlignmentObject&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/coursePrerequisites">schema:coursePrerequisites</a>
    /// </summary>
    let coursePrerequisites = _prefixId.prefix "coursePrerequisites"
    /// <summary>
    ///   <para>rdfs:comment : The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.^^xsd:string</para>
    ///   <para>rdfs:label : coverageEndTime^^xsd:string</para>
    ///   <a href="http://schema.org/coverageEndTime">schema:coverageEndTime</a>
    /// </summary>
    let coverageEndTime = _prefixId.prefix "coverageEndTime"
    /// <summary>
    ///   <para>rdfs:comment : The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.^^xsd:string</para>
    ///   <para>rdfs:label : coverageStartTime^^xsd:string</para>
    ///   <a href="http://schema.org/coverageStartTime">schema:coverageStartTime</a>
    /// </summary>
    let coverageStartTime = _prefixId.prefix "coverageStartTime"
    /// <summary>
    ///   <para>rdfs:comment : The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.^^xsd:string</para>
    ///   <para>rdfs:label : creator^^xsd:string</para>
    ///   <a href="http://schema.org/creator">schema:creator</a>
    /// </summary>
    let creator = _prefixId.prefix "creator"
    /// <summary>
    ///   <para>rdfs:label : creditedTo^^xsd:string</para>
    ///   <para>rdfs:comment : The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.^^xsd:string</para>
    ///   <a href="http://schema.org/creditedTo">schema:creditedTo</a>
    /// </summary>
    let creditedTo = _prefixId.prefix "creditedTo"
    /// <summary>
    ///   <para>rdfs:label : cssSelector^^xsd:string</para>
    ///   <para>rdfs:comment : A CSS selector, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".^^xsd:string</para>
    ///   <para>schema:category : issue-1389^^xsd:string</para>
    ///   <a href="http://schema.org/cssSelector">schema:cssSelector</a>
    /// </summary>
    let cssSelector = _prefixId.prefix "cssSelector"
    /// <summary>
    ///   <para>rdfs:comment : The currency accepted.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".^^xsd:string</para>
    ///   <para>rdfs:label : currenciesAccepted^^xsd:string</para>
    ///   <a href="http://schema.org/currenciesAccepted">schema:currenciesAccepted</a>
    /// </summary>
    let currenciesAccepted = _prefixId.prefix "currenciesAccepted"
    /// <summary>
    ///   <para>rdfs:comment : The currency in which the monetary amount is expressed.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".^^xsd:string</para>
    ///   <para>schema:category : issue-1253^^xsd:string</para>
    ///   <para>rdfs:label : currency^^xsd:string</para>
    ///   <a href="http://schema.org/currency">schema:currency</a>
    /// </summary>
    let currency = _prefixId.prefix "currency"
    /// <summary>
    ///   <para>rdfs:label : customer^^xsd:string</para>
    ///   <para>rdfs:comment : Party placing the order or paying the invoice.^^xsd:string</para>
    ///   <a href="http://schema.org/customer">schema:customer</a>
    /// </summary>
    let customer = _prefixId.prefix "customer"
    /// <summary>
    ///   <para>rdfs:comment : An item within in a data feed. Data feeds may have many elements.^^xsd:string</para>
    ///   <para>rdfs:label : dataFeedElement^^xsd:string</para>
    ///   <a href="http://schema.org/dataFeedElement">schema:dataFeedElement</a>
    /// </summary>
    let dataFeedElement = _prefixId.prefix "dataFeedElement"
    /// <summary>
    ///   <para>rdfs:label : dataset^^xsd:string</para>
    ///   <para>rdfs:comment : A dataset contained in this catalog.^^xsd:string</para>
    ///   <a href="http://schema.org/dataset">schema:dataset</a>
    /// </summary>
    let dataset = _prefixId.prefix "dataset"
    /// <summary>
    ///   <para>rdfs:label : datasetTimeInterval^^xsd:string</para>
    ///   <para>rdfs:comment : The range of temporal applicability of a dataset, e.g. for a 2011 census dataset, the year 2011 (in ISO 8601 time interval format).^^xsd:string</para>
    ///   <a href="http://schema.org/datasetTimeInterval">schema:datasetTimeInterval</a>
    /// </summary>
    let datasetTimeInterval = _prefixId.prefix "datasetTimeInterval"
    /// <summary>
    ///   <para>rdfs:label : dateCreated^^xsd:string</para>
    ///   <para>rdfs:comment : The date on which the CreativeWork was created or the item was added to a DataFeed.^^xsd:string</para>
    ///   <a href="http://schema.org/dateCreated">schema:dateCreated</a>
    /// </summary>
    let dateCreated = _prefixId.prefix "dateCreated"
    /// <summary>
    ///   <para>rdfs:comment : The datetime the item was removed from the DataFeed.^^xsd:string</para>
    ///   <para>rdfs:label : dateDeleted^^xsd:string</para>
    ///   <a href="http://schema.org/dateDeleted">schema:dateDeleted</a>
    /// </summary>
    let dateDeleted = _prefixId.prefix "dateDeleted"
    /// <summary>
    ///   <para>rdfs:comment : The date the ticket was issued.^^xsd:string</para>
    ///   <para>rdfs:label : dateIssued^^xsd:string</para>
    ///   <a href="http://schema.org/dateIssued">schema:dateIssued</a>
    /// </summary>
    let dateIssued = _prefixId.prefix "dateIssued"
    /// <summary>
    ///   <para>rdfs:comment : The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.^^xsd:string</para>
    ///   <para>rdfs:label : dateModified^^xsd:string</para>
    ///   <a href="http://schema.org/dateModified">schema:dateModified</a>
    /// </summary>
    let dateModified = _prefixId.prefix "dateModified"
    /// <summary>
    ///   <para>rdfs:comment : Publication date of an online listing.^^xsd:string</para>
    ///   <para>rdfs:label : datePosted^^xsd:string</para>
    ///   <a href="http://schema.org/datePosted">schema:datePosted</a>
    /// </summary>
    let datePosted = _prefixId.prefix "datePosted"
    /// <summary>
    ///   <para>rdfs:comment : Date of first broadcast/publication.^^xsd:string</para>
    ///   <para>rdfs:label : datePublished^^xsd:string</para>
    ///   <a href="http://schema.org/datePublished">schema:datePublished</a>
    /// </summary>
    let datePublished = _prefixId.prefix "datePublished"
    /// <summary>
    ///   <para>rdfs:label : dateRead^^xsd:string</para>
    ///   <para>rdfs:comment : The date/time at which the message has been read by the recipient if a single recipient exists.^^xsd:string</para>
    ///   <a href="http://schema.org/dateRead">schema:dateRead</a>
    /// </summary>
    let dateRead = _prefixId.prefix "dateRead"
    /// <summary>
    ///   <para>rdfs:label : dateReceived^^xsd:string</para>
    ///   <para>rdfs:comment : The date/time the message was received if a single recipient exists.^^xsd:string</para>
    ///   <a href="http://schema.org/dateReceived">schema:dateReceived</a>
    /// </summary>
    let dateReceived = _prefixId.prefix "dateReceived"
    /// <summary>
    ///   <para>rdfs:label : dateSent^^xsd:string</para>
    ///   <para>rdfs:comment : The date/time at which the message was sent.^^xsd:string</para>
    ///   <a href="http://schema.org/dateSent">schema:dateSent</a>
    /// </summary>
    let dateSent = _prefixId.prefix "dateSent"
    /// <summary>
    ///   <para>rdfs:label : dateVehicleFirstRegistered^^xsd:string</para>
    ///   <para>rdfs:comment : The date of the first registration of the vehicle with the respective public authorities.^^xsd:string</para>
    ///   <a href="http://schema.org/dateVehicleFirstRegistered">schema:dateVehicleFirstRegistered</a>
    /// </summary>
    let dateVehicleFirstRegistered = _prefixId.prefix "dateVehicleFirstRegistered"
    /// <summary>
    ///   <para>rdfs:comment : A &lt;a href="https://en.wikipedia.org/wiki/Dateline"&gt;dateline&lt;/a&gt; is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Structured representations of dateline-related information can also be expressed more explicitly using &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt; (which represents where a work was created e.g. where a news report was written).  For location depicted or described in the content, use &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Dateline summaries are oriented more towards human readers than towards automated processing, and can vary substantially. Some examples: "BEIRUT, Lebanon, June 2.", "Paris, France", "December 19, 2017 11:43AM Reporting from Washington", "Beijing/Moscow", "QUEZON CITY, Philippines".^^xsd:string</para>
    ///   <para>rdfs:label : dateline^^xsd:string</para>
    ///   <a href="http://schema.org/dateline">schema:dateline</a>
    /// </summary>
    let dateline = _prefixId.prefix "dateline"
    /// <summary>
    ///   <para>rdfs:comment : The day of the week for which these opening hours are valid.^^xsd:string</para>
    ///   <para>rdfs:label : dayOfWeek^^xsd:string</para>
    ///   <a href="http://schema.org/dayOfWeek">schema:dayOfWeek</a>
    /// </summary>
    let dayOfWeek = _prefixId.prefix "dayOfWeek"
    /// <summary>
    ///   <para>rdfs:comment : Date of death.^^xsd:string</para>
    ///   <para>rdfs:label : deathDate^^xsd:string</para>
    ///   <a href="http://schema.org/deathDate">schema:deathDate</a>
    /// </summary>
    let deathDate = _prefixId.prefix "deathDate"
    /// <summary>
    ///   <para>rdfs:label : deathPlace^^xsd:string</para>
    ///   <para>rdfs:comment : The place where the person died.^^xsd:string</para>
    ///   <a href="http://schema.org/deathPlace">schema:deathPlace</a>
    /// </summary>
    let deathPlace = _prefixId.prefix "deathPlace"
    /// <summary>
    ///   <para>rdfs:label : defaultValue^^xsd:string</para>
    ///   <para>rdfs:comment : The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.^^xsd:string</para>
    ///   <a href="http://schema.org/defaultValue">schema:defaultValue</a>
    /// </summary>
    let defaultValue = _prefixId.prefix "defaultValue"
    /// <summary>
    ///   <para>rdfs:label : deliveryAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Destination address.^^xsd:string</para>
    ///   <a href="http://schema.org/deliveryAddress">schema:deliveryAddress</a>
    /// </summary>
    let deliveryAddress = _prefixId.prefix "deliveryAddress"
    /// <summary>
    ///   <para>rdfs:comment : The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.^^xsd:string</para>
    ///   <para>rdfs:label : deliveryLeadTime^^xsd:string</para>
    ///   <a href="http://schema.org/deliveryLeadTime">schema:deliveryLeadTime</a>
    /// </summary>
    let deliveryLeadTime = _prefixId.prefix "deliveryLeadTime"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of instrument. The method of delivery.^^xsd:string</para>
    ///   <para>rdfs:label : deliveryMethod^^xsd:string</para>
    ///   <a href="http://schema.org/deliveryMethod">schema:deliveryMethod</a>
    /// </summary>
    let deliveryMethod = _prefixId.prefix "deliveryMethod"
    /// <summary>
    ///   <para>rdfs:label : deliveryStatus^^xsd:string</para>
    ///   <para>rdfs:comment : New entry added as the package passes through each leg of its journey (from shipment to final delivery).^^xsd:string</para>
    ///   <a href="http://schema.org/deliveryStatus">schema:deliveryStatus</a>
    /// </summary>
    let deliveryStatus = _prefixId.prefix "deliveryStatus"
    /// <summary>
    ///   <para>rdfs:label : department^^xsd:string</para>
    ///   <para>rdfs:comment : A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.^^xsd:string</para>
    ///   <a href="http://schema.org/department">schema:department</a>
    /// </summary>
    let department = _prefixId.prefix "department"
    /// <summary>
    ///   <para>rdfs:comment : The airport where the flight originates.^^xsd:string</para>
    ///   <para>rdfs:label : departureAirport^^xsd:string</para>
    ///   <a href="http://schema.org/departureAirport">schema:departureAirport</a>
    /// </summary>
    let departureAirport = _prefixId.prefix "departureAirport"
    /// <summary>
    ///   <para>rdfs:label : departureBusStop^^xsd:string</para>
    ///   <para>rdfs:comment : The stop or station from which the bus departs.^^xsd:string</para>
    ///   <a href="http://schema.org/departureBusStop">schema:departureBusStop</a>
    /// </summary>
    let departureBusStop = _prefixId.prefix "departureBusStop"
    /// <summary>
    ///   <para>rdfs:label : departureGate^^xsd:string</para>
    ///   <para>rdfs:comment : Identifier of the flight's departure gate.^^xsd:string</para>
    ///   <a href="http://schema.org/departureGate">schema:departureGate</a>
    /// </summary>
    let departureGate = _prefixId.prefix "departureGate"
    /// <summary>
    ///   <para>rdfs:comment : The platform from which the train departs.^^xsd:string</para>
    ///   <para>rdfs:label : departurePlatform^^xsd:string</para>
    ///   <a href="http://schema.org/departurePlatform">schema:departurePlatform</a>
    /// </summary>
    let departurePlatform = _prefixId.prefix "departurePlatform"
    /// <summary>
    ///   <para>rdfs:label : departureStation^^xsd:string</para>
    ///   <para>rdfs:comment : The station from which the train departs.^^xsd:string</para>
    ///   <a href="http://schema.org/departureStation">schema:departureStation</a>
    /// </summary>
    let departureStation = _prefixId.prefix "departureStation"
    /// <summary>
    ///   <para>rdfs:comment : Identifier of the flight's departure terminal.^^xsd:string</para>
    ///   <para>rdfs:label : departureTerminal^^xsd:string</para>
    ///   <a href="http://schema.org/departureTerminal">schema:departureTerminal</a>
    /// </summary>
    let departureTerminal = _prefixId.prefix "departureTerminal"
    /// <summary>
    ///   <para>rdfs:label : departureTime^^xsd:string</para>
    ///   <para>rdfs:comment : The expected departure time.^^xsd:string</para>
    ///   <a href="http://schema.org/departureTime">schema:departureTime</a>
    /// </summary>
    let departureTime = _prefixId.prefix "departureTime"
    /// <summary>
    ///   <para>rdfs:label : dependencies^^xsd:string</para>
    ///   <para>rdfs:comment : Prerequisites needed to fulfill steps in article.^^xsd:string</para>
    ///   <a href="http://schema.org/dependencies">schema:dependencies</a>
    /// </summary>
    let dependencies = _prefixId.prefix "dependencies"
    /// <summary>
    ///   <para>rdfs:label : depth^^xsd:string</para>
    ///   <para>rdfs:comment : The depth of the item.^^xsd:string</para>
    ///   <a href="http://schema.org/depth">schema:depth</a>
    /// </summary>
    let depth = _prefixId.prefix "depth"
    /// <summary>
    ///   <para>rdfs:comment : A description of the item.^^xsd:string</para>
    ///   <para>rdfs:label : description^^xsd:string</para>
    ///   <a href="http://schema.org/description">schema:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:label : device^^xsd:string</para>
    ///   <para>rdfs:comment : Device required to run the application. Used in cases where a specific make/model is required to run the application.^^xsd:string</para>
    ///   <a href="http://schema.org/device">schema:device</a>
    /// </summary>
    let device = _prefixId.prefix "device"
    /// <summary>
    ///   <para>rdfs:comment : A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.^^xsd:string</para>
    ///   <para>rdfs:label : director^^xsd:string</para>
    ///   <a href="http://schema.org/director">schema:director</a>
    /// </summary>
    let director = _prefixId.prefix "director"
    /// <summary>
    ///   <para>rdfs:comment : A director of e.g. tv, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip.^^xsd:string</para>
    ///   <para>rdfs:label : directors^^xsd:string</para>
    ///   <a href="http://schema.org/directors">schema:directors</a>
    /// </summary>
    let directors = _prefixId.prefix "directors"
    /// <summary>
    ///   <para>rdfs:label : disambiguatingDescription^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.^^xsd:string</para>
    ///   <a href="http://schema.org/disambiguatingDescription">schema:disambiguatingDescription</a>
    /// </summary>
    let disambiguatingDescription = _prefixId.prefix "disambiguatingDescription"
    /// <summary>
    ///   <para>rdfs:comment : Any discount applied (to an Order).^^xsd:string</para>
    ///   <para>rdfs:label : discount^^xsd:string</para>
    ///   <a href="http://schema.org/discount">schema:discount</a>
    /// </summary>
    let discount = _prefixId.prefix "discount"
    /// <summary>
    ///   <para>rdfs:label : discountCode^^xsd:string</para>
    ///   <para>rdfs:comment : Code used to redeem a discount.^^xsd:string</para>
    ///   <a href="http://schema.org/discountCode">schema:discountCode</a>
    /// </summary>
    let discountCode = _prefixId.prefix "discountCode"
    /// <summary>
    ///   <para>rdfs:comment : The currency of the discount.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".^^xsd:string</para>
    ///   <para>rdfs:label : discountCurrency^^xsd:string</para>
    ///   <a href="http://schema.org/discountCurrency">schema:discountCurrency</a>
    /// </summary>
    let discountCurrency = _prefixId.prefix "discountCurrency"
    /// <summary>
    ///   <para>rdfs:label : discusses^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the CreativeWork associated with the UserComment.^^xsd:string</para>
    ///   <a href="http://schema.org/discusses">schema:discusses</a>
    /// </summary>
    let discusses = _prefixId.prefix "discusses"
    /// <summary>
    ///   <para>rdfs:comment : A link to the page containing the comments of the CreativeWork.^^xsd:string</para>
    ///   <para>rdfs:label : discussionUrl^^xsd:string</para>
    ///   <a href="http://schema.org/discussionUrl">schema:discussionUrl</a>
    /// </summary>
    let discussionUrl = _prefixId.prefix "discussionUrl"
    /// <summary>
    ///   <para>rdfs:comment : The date that this organization was dissolved.^^xsd:string</para>
    ///   <para>rdfs:label : dissolutionDate^^xsd:string</para>
    ///   <a href="http://schema.org/dissolutionDate">schema:dissolutionDate</a>
    /// </summary>
    let dissolutionDate = _prefixId.prefix "dissolutionDate"
    /// <summary>
    ///   <para>rdfs:label : distance^^xsd:string</para>
    ///   <para>rdfs:comment : The distance travelled, e.g. exercising or travelling.^^xsd:string</para>
    ///   <a href="http://schema.org/distance">schema:distance</a>
    /// </summary>
    let distance = _prefixId.prefix "distance"
    /// <summary>
    ///   <para>rdfs:label : distribution^^xsd:string</para>
    ///   <para>rdfs:comment : A downloadable form of this dataset, at a specific location, in a specific format.^^xsd:string</para>
    ///   <a href="http://schema.org/distribution">schema:distribution</a>
    /// </summary>
    let distribution = _prefixId.prefix "distribution"
    let domainIncludes = _prefixId.prefix "domainIncludes"
    /// <summary>
    ///   <para>rdfs:comment : The time admission will commence.^^xsd:string</para>
    ///   <para>rdfs:label : doorTime^^xsd:string</para>
    ///   <a href="http://schema.org/doorTime">schema:doorTime</a>
    /// </summary>
    let doorTime = _prefixId.prefix "doorTime"
    /// <summary>
    ///   <para>rdfs:comment : If the file can be downloaded, URL to download the binary.^^xsd:string</para>
    ///   <para>rdfs:label : downloadUrl^^xsd:string</para>
    ///   <a href="http://schema.org/downloadUrl">schema:downloadUrl</a>
    /// </summary>
    let downloadUrl = _prefixId.prefix "downloadUrl"
    /// <summary>
    ///   <para>rdfs:label : downvoteCount^^xsd:string</para>
    ///   <para>rdfs:comment : The number of downvotes this question, answer or comment has received from the community.^^xsd:string</para>
    ///   <a href="http://schema.org/downvoteCount">schema:downvoteCount</a>
    /// </summary>
    let downvoteCount = _prefixId.prefix "downvoteCount"
    /// <summary>
    ///   <para>rdfs:label : driveWheelConfiguration^^xsd:string</para>
    ///   <para>rdfs:comment : The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.^^xsd:string</para>
    ///   <a href="http://schema.org/driveWheelConfiguration">schema:driveWheelConfiguration</a>
    /// </summary>
    let driveWheelConfiguration = _prefixId.prefix "driveWheelConfiguration"
    /// <summary>
    ///   <para>rdfs:comment : Where a rental car can be dropped off.^^xsd:string</para>
    ///   <para>rdfs:label : dropoffLocation^^xsd:string</para>
    ///   <a href="http://schema.org/dropoffLocation">schema:dropoffLocation</a>
    /// </summary>
    let dropoffLocation = _prefixId.prefix "dropoffLocation"
    /// <summary>
    ///   <para>rdfs:label : dropoffTime^^xsd:string</para>
    ///   <para>rdfs:comment : When a rental car can be dropped off.^^xsd:string</para>
    ///   <a href="http://schema.org/dropoffTime">schema:dropoffTime</a>
    /// </summary>
    let dropoffTime = _prefixId.prefix "dropoffTime"
    /// <summary>
    ///   <para>rdfs:label : duns^^xsd:string</para>
    ///   <para>rdfs:comment : The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.^^xsd:string</para>
    ///   <a href="http://schema.org/duns">schema:duns</a>
    /// </summary>
    let duns = _prefixId.prefix "duns"
    /// <summary>
    ///   <para>schema:category : issue-1698^^xsd:stringschema:category : issue-1457^^xsd:string</para>
    ///   <para>rdfs:label : duration^^xsd:string</para>
    ///   <para>rdfs:comment : The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/duration">schema:duration</a>
    /// </summary>
    let duration = _prefixId.prefix "duration"
    /// <summary>
    ///   <para>rdfs:label : durationOfWarranty^^xsd:string</para>
    ///   <para>rdfs:comment : The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.^^xsd:string</para>
    ///   <a href="http://schema.org/durationOfWarranty">schema:durationOfWarranty</a>
    /// </summary>
    let durationOfWarranty = _prefixId.prefix "durationOfWarranty"
    /// <summary>
    ///   <para>rdfs:label : duringMedia^^xsd:string</para>
    ///   <para>rdfs:comment : A media object representing the circumstances while performing this direction.^^xsd:string</para>
    ///   <a href="http://schema.org/duringMedia">schema:duringMedia</a>
    /// </summary>
    let duringMedia = _prefixId.prefix "duringMedia"
    /// <summary>
    ///   <para>rdfs:label : editor^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the Person who edited the CreativeWork.^^xsd:string</para>
    ///   <a href="http://schema.org/editor">schema:editor</a>
    /// </summary>
    let editor = _prefixId.prefix "editor"
    /// <summary>
    ///   <para>rdfs:comment : An alignment to an established educational framework.^^xsd:string</para>
    ///   <para>rdfs:label : educationalAlignment^^xsd:string</para>
    ///   <a href="http://schema.org/educationalAlignment">schema:educationalAlignment</a>
    /// </summary>
    let educationalAlignment = _prefixId.prefix "educationalAlignment"
    /// <summary>
    ///   <para>rdfs:label : educationalCredentialAwarded^^xsd:string</para>
    ///   <para>rdfs:comment : A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course or program.^^xsd:string</para>
    ///   <para>schema:category : issue-2289^^xsd:string</para>
    ///   <a href="http://schema.org/educationalCredentialAwarded">schema:educationalCredentialAwarded</a>
    /// </summary>
    let educationalCredentialAwarded = _prefixId.prefix "educationalCredentialAwarded"
    /// <summary>
    ///   <para>rdfs:label : educationalFramework^^xsd:string</para>
    ///   <para>rdfs:comment : The framework to which the resource being described is aligned.^^xsd:string</para>
    ///   <a href="http://schema.org/educationalFramework">schema:educationalFramework</a>
    /// </summary>
    let educationalFramework = _prefixId.prefix "educationalFramework"
    /// <summary>
    ///   <para>rdfs:label : educationalRole^^xsd:string</para>
    ///   <para>rdfs:comment : An educationalRole of an EducationalAudience.^^xsd:string</para>
    ///   <a href="http://schema.org/educationalRole">schema:educationalRole</a>
    /// </summary>
    let educationalRole = _prefixId.prefix "educationalRole"
    /// <summary>
    ///   <para>rdfs:label : educationalUse^^xsd:string</para>
    ///   <para>rdfs:comment : The purpose of a work in the context of education; for example, 'assignment', 'group work'.^^xsd:string</para>
    ///   <a href="http://schema.org/educationalUse">schema:educationalUse</a>
    /// </summary>
    let educationalUse = _prefixId.prefix "educationalUse"
    /// <summary>
    ///   <para>rdfs:label : elevation^^xsd:string</para>
    ///   <para>rdfs:comment : The elevation of a location (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;). Values may be of the form 'NUMBER UNIT&lt;em&gt;OF&lt;/em&gt;MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.^^xsd:string</para>
    ///   <a href="http://schema.org/elevation">schema:elevation</a>
    /// </summary>
    let elevation = _prefixId.prefix "elevation"
    /// <summary>
    ///   <para>rdfs:label : eligibleCustomerType^^xsd:string</para>
    ///   <para>rdfs:comment : The type(s) of customers for which the given offer is valid.^^xsd:string</para>
    ///   <a href="http://schema.org/eligibleCustomerType">schema:eligibleCustomerType</a>
    /// </summary>
    let eligibleCustomerType = _prefixId.prefix "eligibleCustomerType"
    /// <summary>
    ///   <para>rdfs:label : eligibleDuration^^xsd:string</para>
    ///   <para>rdfs:comment : The duration for which the given offer is valid.^^xsd:string</para>
    ///   <a href="http://schema.org/eligibleDuration">schema:eligibleDuration</a>
    /// </summary>
    let eligibleDuration = _prefixId.prefix "eligibleDuration"
    /// <summary>
    ///   <para>rdfs:label : eligibleQuantity^^xsd:string</para>
    ///   <para>rdfs:comment : The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.^^xsd:string</para>
    ///   <a href="http://schema.org/eligibleQuantity">schema:eligibleQuantity</a>
    /// </summary>
    let eligibleQuantity = _prefixId.prefix "eligibleQuantity"
    /// <summary>
    ///   <para>rdfs:label : eligibleRegion^^xsd:string</para>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <para>rdfs:comment : The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.&lt;br/&gt;&lt;br/&gt;
    ///
    /// See also &lt;a class="localLink" href="http://schema.org/ineligibleRegion"&gt;ineligibleRegion&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/eligibleRegion">schema:eligibleRegion</a>
    /// </summary>
    let eligibleRegion = _prefixId.prefix "eligibleRegion"
    /// <summary>
    ///   <para>rdfs:label : eligibleTransactionVolume^^xsd:string</para>
    ///   <para>rdfs:comment : The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.^^xsd:string</para>
    ///   <a href="http://schema.org/eligibleTransactionVolume">schema:eligibleTransactionVolume</a>
    /// </summary>
    let eligibleTransactionVolume = _prefixId.prefix "eligibleTransactionVolume"
    /// <summary>
    ///   <para>rdfs:label : email^^xsd:string</para>
    ///   <para>rdfs:comment : Email address.^^xsd:string</para>
    ///   <a href="http://schema.org/email">schema:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:label : embedUrl^^xsd:string</para>
    ///   <para>rdfs:comment : A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.^^xsd:string</para>
    ///   <a href="http://schema.org/embedUrl">schema:embedUrl</a>
    /// </summary>
    let embedUrl = _prefixId.prefix "embedUrl"
    /// <summary>
    ///   <para>rdfs:comment : Someone working for this organization.^^xsd:string</para>
    ///   <para>rdfs:label : employee^^xsd:string</para>
    ///   <a href="http://schema.org/employee">schema:employee</a>
    /// </summary>
    let employee = _prefixId.prefix "employee"
    /// <summary>
    ///   <para>rdfs:label : employees^^xsd:string</para>
    ///   <para>rdfs:comment : People working for this organization.^^xsd:string</para>
    ///   <a href="http://schema.org/employees">schema:employees</a>
    /// </summary>
    let employees = _prefixId.prefix "employees"
    /// <summary>
    ///   <para>rdfs:label : employmentType^^xsd:string</para>
    ///   <para>rdfs:comment : Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).^^xsd:string</para>
    ///   <a href="http://schema.org/employmentType">schema:employmentType</a>
    /// </summary>
    let employmentType = _prefixId.prefix "employmentType"
    /// <summary>
    ///   <para>rdfs:label : encodesCreativeWork^^xsd:string</para>
    ///   <para>rdfs:comment : The CreativeWork encoded by this media object.^^xsd:string</para>
    ///   <a href="http://schema.org/encodesCreativeWork">schema:encodesCreativeWork</a>
    /// </summary>
    let encodesCreativeWork = _prefixId.prefix "encodesCreativeWork"
    /// <summary>
    ///   <para>rdfs:comment : A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.^^xsd:string</para>
    ///   <para>rdfs:label : encoding^^xsd:string</para>
    ///   <a href="http://schema.org/encoding">schema:encoding</a>
    /// </summary>
    let encoding = _prefixId.prefix "encoding"
    /// <summary>
    ///   <para>rdfs:label : encodingFormat^^xsd:string</para>
    ///   <para>rdfs:comment : Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
    ///
    /// In cases where a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="http://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="http://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="http://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.^^xsd:string</para>
    ///   <a href="http://schema.org/encodingFormat">schema:encodingFormat</a>
    /// </summary>
    let encodingFormat = _prefixId.prefix "encodingFormat"
    /// <summary>
    ///   <para>rdfs:label : encodingType^^xsd:string</para>
    ///   <para>rdfs:comment : The supported encoding type(s) for an EntryPoint request.^^xsd:string</para>
    ///   <a href="http://schema.org/encodingType">schema:encodingType</a>
    /// </summary>
    let encodingType = _prefixId.prefix "encodingType"
    /// <summary>
    ///   <para>rdfs:comment : A media object that encodes this CreativeWork.^^xsd:string</para>
    ///   <para>rdfs:label : encodings^^xsd:string</para>
    ///   <a href="http://schema.org/encodings">schema:encodings</a>
    /// </summary>
    let encodings = _prefixId.prefix "encodings"
    /// <summary>
    ///   <para>rdfs:label : endDate^^xsd:string</para>
    ///   <para>schema:category : issue-2486^^xsd:string</para>
    ///   <para>rdfs:comment : The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).^^xsd:string</para>
    ///   <a href="http://schema.org/endDate">schema:endDate</a>
    /// </summary>
    let endDate = _prefixId.prefix "endDate"
    /// <summary>
    ///   <para>rdfs:label : endTime^^xsd:string</para>
    ///   <para>rdfs:comment : The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;. For media, including audio and video, it's the time offset of the end of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.^^xsd:string</para>
    ///   <a href="http://schema.org/endTime">schema:endTime</a>
    /// </summary>
    let endTime = _prefixId.prefix "endTime"
    /// <summary>
    ///   <para>rdfs:label : endorsee^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of participant. The person/organization being supported.^^xsd:string</para>
    ///   <a href="http://schema.org/endorsee">schema:endorsee</a>
    /// </summary>
    let endorsee = _prefixId.prefix "endorsee"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of location. The entertainment business where the action occurred.^^xsd:string</para>
    ///   <para>rdfs:label : entertainmentBusiness^^xsd:string</para>
    ///   <a href="http://schema.org/entertainmentBusiness">schema:entertainmentBusiness</a>
    /// </summary>
    let entertainmentBusiness = _prefixId.prefix "entertainmentBusiness"
    /// <summary>
    ///   <para>rdfs:label : episode^^xsd:string</para>
    ///   <para>rdfs:comment : An episode of a tv, radio or game media within a series or season.^^xsd:string</para>
    ///   <a href="http://schema.org/episode">schema:episode</a>
    /// </summary>
    let episode = _prefixId.prefix "episode"
    /// <summary>
    ///   <para>rdfs:label : episodeNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Position of the episode within an ordered group of episodes.^^xsd:string</para>
    ///   <a href="http://schema.org/episodeNumber">schema:episodeNumber</a>
    /// </summary>
    let episodeNumber = _prefixId.prefix "episodeNumber"
    /// <summary>
    ///   <para>rdfs:label : episodes^^xsd:string</para>
    ///   <para>rdfs:comment : An episode of a TV/radio series or season.^^xsd:string</para>
    ///   <a href="http://schema.org/episodes">schema:episodes</a>
    /// </summary>
    let episodes = _prefixId.prefix "episodes"
    /// <summary>
    ///   <para>rdfs:comment : This ordering relation for qualitative values indicates that the subject is equal to the object.^^xsd:string</para>
    ///   <para>rdfs:label : equal^^xsd:string</para>
    ///   <a href="http://schema.org/equal">schema:equal</a>
    /// </summary>
    let equal = _prefixId.prefix "equal"
    /// <summary>
    ///   <para>rdfs:comment : For failed actions, more information on the cause of the failure.^^xsd:string</para>
    ///   <para>rdfs:label : error^^xsd:string</para>
    ///   <a href="http://schema.org/error">schema:error</a>
    /// </summary>
    let error = _prefixId.prefix "error"
    /// <summary>
    ///   <para>rdfs:comment : The estimated cost of the supply or supplies consumed when performing instructions.^^xsd:string</para>
    ///   <para>rdfs:label : estimatedCost^^xsd:string</para>
    ///   <a href="http://schema.org/estimatedCost">schema:estimatedCost</a>
    /// </summary>
    let estimatedCost = _prefixId.prefix "estimatedCost"
    /// <summary>
    ///   <para>rdfs:comment : The estimated time the flight will take.^^xsd:string</para>
    ///   <para>rdfs:label : estimatedFlightDuration^^xsd:string</para>
    ///   <a href="http://schema.org/estimatedFlightDuration">schema:estimatedFlightDuration</a>
    /// </summary>
    let estimatedFlightDuration = _prefixId.prefix "estimatedFlightDuration"
    /// <summary>
    ///   <para>rdfs:label : estimatedSalary^^xsd:string</para>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:comment : An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.^^xsd:string</para>
    ///   <a href="http://schema.org/estimatedSalary">schema:estimatedSalary</a>
    /// </summary>
    let estimatedSalary = _prefixId.prefix "estimatedSalary"
    /// <summary>
    ///   <para>rdfs:comment : Upcoming or past event associated with this place, organization, or action.^^xsd:string</para>
    ///   <para>rdfs:label : event^^xsd:string</para>
    ///   <a href="http://schema.org/event">schema:event</a>
    /// </summary>
    let event_ = _prefixId.prefix "event"
    /// <summary>
    ///   <para>rdfs:comment : An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.^^xsd:string</para>
    ///   <para>rdfs:label : eventStatus^^xsd:string</para>
    ///   <a href="http://schema.org/eventStatus">schema:eventStatus</a>
    /// </summary>
    let eventStatus = _prefixId.prefix "eventStatus"
    /// <summary>
    ///   <para>rdfs:label : events^^xsd:string</para>
    ///   <para>rdfs:comment : Upcoming or past events associated with this place or organization.^^xsd:string</para>
    ///   <a href="http://schema.org/events">schema:events</a>
    /// </summary>
    let events = _prefixId.prefix "events"
    /// <summary>
    ///   <para>rdfs:comment : A creative work that this work is an example/instance/realization/derivation of.^^xsd:string</para>
    ///   <para>rdfs:label : exampleOfWork^^xsd:string</para>
    ///   <a href="http://schema.org/exampleOfWork">schema:exampleOfWork</a>
    /// </summary>
    let exampleOfWork = _prefixId.prefix "exampleOfWork"
    /// <summary>
    ///   <para>rdfs:comment : Library file name e.g., mscorlib.dll, system.web.dll.^^xsd:string</para>
    ///   <para>rdfs:label : executableLibraryName^^xsd:string</para>
    ///   <a href="http://schema.org/executableLibraryName">schema:executableLibraryName</a>
    /// </summary>
    let executableLibraryName = _prefixId.prefix "executableLibraryName"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of location. The course where this action was taken.^^xsd:string</para>
    ///   <para>rdfs:label : exerciseCourse^^xsd:string</para>
    ///   <a href="http://schema.org/exerciseCourse">schema:exerciseCourse</a>
    /// </summary>
    let exerciseCourse = _prefixId.prefix "exerciseCourse"
    /// <summary>
    ///   <para>rdfs:comment : exif data for this object.^^xsd:string</para>
    ///   <para>rdfs:label : exifData^^xsd:string</para>
    ///   <a href="http://schema.org/exifData">schema:exifData</a>
    /// </summary>
    let exifData = _prefixId.prefix "exifData"
    /// <summary>
    ///   <para>rdfs:comment : The earliest date the package may arrive.^^xsd:string</para>
    ///   <para>rdfs:label : expectedArrivalFrom^^xsd:string</para>
    ///   <a href="http://schema.org/expectedArrivalFrom">schema:expectedArrivalFrom</a>
    /// </summary>
    let expectedArrivalFrom = _prefixId.prefix "expectedArrivalFrom"
    /// <summary>
    ///   <para>rdfs:label : expectedArrivalUntil^^xsd:string</para>
    ///   <para>rdfs:comment : The latest date the package may arrive.^^xsd:string</para>
    ///   <a href="http://schema.org/expectedArrivalUntil">schema:expectedArrivalUntil</a>
    /// </summary>
    let expectedArrivalUntil = _prefixId.prefix "expectedArrivalUntil"
    /// <summary>
    ///   <para>rdfs:label : expectsAcceptanceOf^^xsd:string</para>
    ///   <para>rdfs:comment : An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.^^xsd:string</para>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <a href="http://schema.org/expectsAcceptanceOf">schema:expectsAcceptanceOf</a>
    /// </summary>
    let expectsAcceptanceOf = _prefixId.prefix "expectsAcceptanceOf"
    /// <summary>
    ///   <para>rdfs:label : experienceRequirements^^xsd:string</para>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:comment : Description of skills and experience needed for the position or Occupation.^^xsd:string</para>
    ///   <a href="http://schema.org/experienceRequirements">schema:experienceRequirements</a>
    /// </summary>
    let experienceRequirements = _prefixId.prefix "experienceRequirements"
    /// <summary>
    ///   <para>rdfs:comment : Date the content expires and is no longer useful or available. For example a &lt;a class="localLink" href="http://schema.org/VideoObject"&gt;VideoObject&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt; whose availability or relevance is time-limited, or a &lt;a class="localLink" href="http://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt; fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.^^xsd:string</para>
    ///   <para>rdfs:label : expires^^xsd:string</para>
    ///   <a href="http://schema.org/expires">schema:expires</a>
    /// </summary>
    let expires = _prefixId.prefix "expires"
    /// <summary>
    ///   <para>rdfs:comment : Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.^^xsd:string</para>
    ///   <para>rdfs:label : familyName^^xsd:string</para>
    ///   <a href="http://schema.org/familyName">schema:familyName</a>
    /// </summary>
    let familyName = _prefixId.prefix "familyName"
    /// <summary>
    ///   <para>rdfs:comment : The number of grams of fat.^^xsd:string</para>
    ///   <para>rdfs:label : fatContent^^xsd:string</para>
    ///   <a href="http://schema.org/fatContent">schema:fatContent</a>
    /// </summary>
    let fatContent = _prefixId.prefix "fatContent"
    /// <summary>
    ///   <para>rdfs:label : faxNumber^^xsd:string</para>
    ///   <para>rdfs:comment : The fax number.^^xsd:string</para>
    ///   <a href="http://schema.org/faxNumber">schema:faxNumber</a>
    /// </summary>
    let faxNumber = _prefixId.prefix "faxNumber"
    /// <summary>
    ///   <para>rdfs:comment : Features or modules provided by this application (and possibly required by other applications).^^xsd:string</para>
    ///   <para>rdfs:label : featureList^^xsd:string</para>
    ///   <a href="http://schema.org/featureList">schema:featureList</a>
    /// </summary>
    let featureList = _prefixId.prefix "featureList"

    /// <summary>
    ///   <para>rdfs:comment : Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.^^xsd:string</para>
    ///   <para>rdfs:label : feesAndCommissionsSpecification^^xsd:string</para>
    ///   <a href="http://schema.org/feesAndCommissionsSpecification">schema:feesAndCommissionsSpecification</a>
    /// </summary>
    let feesAndCommissionsSpecification =
        _prefixId.prefix "feesAndCommissionsSpecification"

    /// <summary>
    ///   <para>rdfs:comment : The number of grams of fiber.^^xsd:string</para>
    ///   <para>rdfs:label : fiberContent^^xsd:string</para>
    ///   <a href="http://schema.org/fiberContent">schema:fiberContent</a>
    /// </summary>
    let fiberContent = _prefixId.prefix "fiberContent"
    /// <summary>
    ///   <para>rdfs:label : fileFormat^^xsd:string</para>
    ///   <para>rdfs:comment : Media type, typically MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt;) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.^^xsd:string</para>
    ///   <a href="http://schema.org/fileFormat">schema:fileFormat</a>
    /// </summary>
    let fileFormat = _prefixId.prefix "fileFormat"
    /// <summary>
    ///   <para>rdfs:label : fileSize^^xsd:string</para>
    ///   <para>rdfs:comment : Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.^^xsd:string</para>
    ///   <a href="http://schema.org/fileSize">schema:fileSize</a>
    /// </summary>
    let fileSize = _prefixId.prefix "fileSize"
    /// <summary>
    ///   <para>rdfs:comment : The date and place the work was first performed.^^xsd:string</para>
    ///   <para>rdfs:label : firstPerformance^^xsd:string</para>
    ///   <a href="http://schema.org/firstPerformance">schema:firstPerformance</a>
    /// </summary>
    let firstPerformance = _prefixId.prefix "firstPerformance"
    /// <summary>
    ///   <para>rdfs:comment : The distance of the flight.^^xsd:string</para>
    ///   <para>rdfs:label : flightDistance^^xsd:string</para>
    ///   <a href="http://schema.org/flightDistance">schema:flightDistance</a>
    /// </summary>
    let flightDistance = _prefixId.prefix "flightDistance"
    /// <summary>
    ///   <para>rdfs:comment : The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.^^xsd:string</para>
    ///   <para>rdfs:label : flightNumber^^xsd:string</para>
    ///   <a href="http://schema.org/flightNumber">schema:flightNumber</a>
    /// </summary>
    let flightNumber = _prefixId.prefix "flightNumber"
    /// <summary>
    ///   <para>rdfs:comment : The size of the accommodation, e.g. in square meter or squarefoot.
    /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard^^xsd:string</para>
    ///   <para>rdfs:label : floorSize^^xsd:string</para>
    ///   <a href="http://schema.org/floorSize">schema:floorSize</a>
    /// </summary>
    let floorSize = _prefixId.prefix "floorSize"
    /// <summary>
    ///   <para>rdfs:label : followee^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of object. The person or organization being followed.^^xsd:string</para>
    ///   <a href="http://schema.org/followee">schema:followee</a>
    /// </summary>
    let followee = _prefixId.prefix "followee"
    /// <summary>
    ///   <para>rdfs:comment : The most generic uni-directional social relation.^^xsd:string</para>
    ///   <para>rdfs:label : follows^^xsd:string</para>
    ///   <a href="http://schema.org/follows">schema:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:label : foodEstablishment^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of location. The specific food establishment where the action occurred.^^xsd:string</para>
    ///   <a href="http://schema.org/foodEstablishment">schema:foodEstablishment</a>
    /// </summary>
    let foodEstablishment = _prefixId.prefix "foodEstablishment"
    /// <summary>
    ///   <para>rdfs:label : foodEvent^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of location. The specific food event where the action occurred.^^xsd:string</para>
    ///   <a href="http://schema.org/foodEvent">schema:foodEvent</a>
    /// </summary>
    let foodEvent = _prefixId.prefix "foodEvent"
    /// <summary>
    ///   <para>rdfs:comment : A person who founded this organization.^^xsd:string</para>
    ///   <para>rdfs:label : founder^^xsd:string</para>
    ///   <a href="http://schema.org/founder">schema:founder</a>
    /// </summary>
    let founder = _prefixId.prefix "founder"
    /// <summary>
    ///   <para>rdfs:label : founders^^xsd:string</para>
    ///   <para>rdfs:comment : A person who founded this organization.^^xsd:string</para>
    ///   <a href="http://schema.org/founders">schema:founders</a>
    /// </summary>
    let founders = _prefixId.prefix "founders"
    /// <summary>
    ///   <para>rdfs:comment : The date that this organization was founded.^^xsd:string</para>
    ///   <para>rdfs:label : foundingDate^^xsd:string</para>
    ///   <a href="http://schema.org/foundingDate">schema:foundingDate</a>
    /// </summary>
    let foundingDate = _prefixId.prefix "foundingDate"
    /// <summary>
    ///   <para>rdfs:comment : The place where the Organization was founded.^^xsd:string</para>
    ///   <para>rdfs:label : foundingLocation^^xsd:string</para>
    ///   <a href="http://schema.org/foundingLocation">schema:foundingLocation</a>
    /// </summary>
    let foundingLocation = _prefixId.prefix "foundingLocation"
    /// <summary>
    ///   <para>rdfs:label : free^^xsd:string</para>
    ///   <para>rdfs:comment : A flag to signal that the item, event, or place is accessible for free.^^xsd:string</para>
    ///   <a href="http://schema.org/free">schema:free</a>
    /// </summary>
    let free = _prefixId.prefix "free"
    /// <summary>
    ///   <para>rdfs:label : fromLocation^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of location. The original location of the object or the agent before the action.^^xsd:string</para>
    ///   <a href="http://schema.org/fromLocation">schema:fromLocation</a>
    /// </summary>
    let fromLocation = _prefixId.prefix "fromLocation"
    /// <summary>
    ///   <para>rdfs:label : fuelConsumption^^xsd:string</para>
    ///   <para>rdfs:comment : The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. L/100 km.&lt;/li&gt;
    /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
    /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel consumption to another value.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/fuelConsumption">schema:fuelConsumption</a>
    /// </summary>
    let fuelConsumption = _prefixId.prefix "fuelConsumption"
    /// <summary>
    ///   <para>rdfs:comment : The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use &lt;a class="localLink" href="http://schema.org/unitText"&gt;unitText&lt;/a&gt; to indicate the unit of measurement, e.g. mpg or km/L.&lt;/li&gt;
    /// &lt;li&gt;Note 2: There are two ways of indicating the fuel consumption, &lt;a class="localLink" href="http://schema.org/fuelConsumption"&gt;fuelConsumption&lt;/a&gt; (e.g. 8 liters per 100 km) and &lt;a class="localLink" href="http://schema.org/fuelEfficiency"&gt;fuelEfficiency&lt;/a&gt; (e.g. 30 miles per gallon). They are reciprocal.&lt;/li&gt;
    /// &lt;li&gt;Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; to link the value for the fuel economy to another value.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : fuelEfficiency^^xsd:string</para>
    ///   <a href="http://schema.org/fuelEfficiency">schema:fuelEfficiency</a>
    /// </summary>
    let fuelEfficiency = _prefixId.prefix "fuelEfficiency"
    /// <summary>
    ///   <para>rdfs:comment : The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.^^xsd:string</para>
    ///   <para>rdfs:label : fuelType^^xsd:string</para>
    ///   <a href="http://schema.org/fuelType">schema:fuelType</a>
    /// </summary>
    let fuelType = _prefixId.prefix "fuelType"
    /// <summary>
    ///   <para>rdfs:label : funder^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization that supports (sponsors) something through some kind of financial contribution.^^xsd:string</para>
    ///   <a href="http://schema.org/funder">schema:funder</a>
    /// </summary>
    let funder = _prefixId.prefix "funder"
    /// <summary>
    ///   <para>rdfs:label : game^^xsd:string</para>
    ///   <para>rdfs:comment : Video game which is played on this server.^^xsd:string</para>
    ///   <a href="http://schema.org/game">schema:game</a>
    /// </summary>
    let game = _prefixId.prefix "game"
    /// <summary>
    ///   <para>rdfs:label : gameItem^^xsd:string</para>
    ///   <para>rdfs:comment : An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.^^xsd:string</para>
    ///   <a href="http://schema.org/gameItem">schema:gameItem</a>
    /// </summary>
    let gameItem = _prefixId.prefix "gameItem"
    /// <summary>
    ///   <para>rdfs:label : gameLocation^^xsd:string</para>
    ///   <para>rdfs:comment : Real or fictional location of the game (or part of game).^^xsd:string</para>
    ///   <a href="http://schema.org/gameLocation">schema:gameLocation</a>
    /// </summary>
    let gameLocation = _prefixId.prefix "gameLocation"
    /// <summary>
    ///   <para>rdfs:comment : The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : gamePlatform^^xsd:string</para>
    ///   <a href="http://schema.org/gamePlatform">schema:gamePlatform</a>
    /// </summary>
    let gamePlatform = _prefixId.prefix "gamePlatform"
    /// <summary>
    ///   <para>rdfs:label : gameServer^^xsd:string</para>
    ///   <para>rdfs:comment : The server on which  it is possible to play the game.^^xsd:string</para>
    ///   <a href="http://schema.org/gameServer">schema:gameServer</a>
    /// </summary>
    let gameServer = _prefixId.prefix "gameServer"
    /// <summary>
    ///   <para>rdfs:label : gameTip^^xsd:string</para>
    ///   <para>rdfs:comment : Links to tips, tactics, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/gameTip">schema:gameTip</a>
    /// </summary>
    let gameTip = _prefixId.prefix "gameTip"
    /// <summary>
    ///   <para>rdfs:label : genre^^xsd:string</para>
    ///   <para>rdfs:comment : Genre of the creative work, broadcast channel or group.^^xsd:string</para>
    ///   <a href="http://schema.org/genre">schema:genre</a>
    /// </summary>
    let genre = _prefixId.prefix "genre"
    /// <summary>
    ///   <para>rdfs:label : geo^^xsd:string</para>
    ///   <para>rdfs:comment : The geo coordinates of the place.^^xsd:string</para>
    ///   <a href="http://schema.org/geo">schema:geo</a>
    /// </summary>
    let geo = _prefixId.prefix "geo"
    /// <summary>
    ///   <para>rdfs:comment : Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : geoContains^^xsd:string</para>
    ///   <a href="http://schema.org/geoContains">schema:geoContains</a>
    /// </summary>
    let geoContains = _prefixId.prefix "geoContains"
    /// <summary>
    ///   <para>rdfs:comment : Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : geoCoveredBy^^xsd:string</para>
    ///   <a href="http://schema.org/geoCoveredBy">schema:geoCoveredBy</a>
    /// </summary>
    let geoCoveredBy = _prefixId.prefix "geoCoveredBy"
    /// <summary>
    ///   <para>rdfs:label : geoCovers^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/geoCovers">schema:geoCovers</a>
    /// </summary>
    let geoCovers = _prefixId.prefix "geoCovers"
    /// <summary>
    ///   <para>rdfs:label : geoCrosses^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/geoCrosses">schema:geoCrosses</a>
    /// </summary>
    let geoCrosses = _prefixId.prefix "geoCrosses"
    /// <summary>
    ///   <para>rdfs:comment : Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)^^xsd:string</para>
    ///   <para>rdfs:label : geoDisjoint^^xsd:string</para>
    ///   <a href="http://schema.org/geoDisjoint">schema:geoDisjoint</a>
    /// </summary>
    let geoDisjoint = _prefixId.prefix "geoDisjoint"
    /// <summary>
    ///   <para>rdfs:comment : Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)^^xsd:string</para>
    ///   <para>rdfs:label : geoEquals^^xsd:string</para>
    ///   <a href="http://schema.org/geoEquals">schema:geoEquals</a>
    /// </summary>
    let geoEquals = _prefixId.prefix "geoEquals"
    /// <summary>
    ///   <para>rdfs:comment : Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : geoIntersects^^xsd:string</para>
    ///   <a href="http://schema.org/geoIntersects">schema:geoIntersects</a>
    /// </summary>
    let geoIntersects = _prefixId.prefix "geoIntersects"
    /// <summary>
    ///   <para>rdfs:label : geoMidpoint^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the GeoCoordinates at the centre of a GeoShape e.g. GeoCircle.^^xsd:string</para>
    ///   <a href="http://schema.org/geoMidpoint">schema:geoMidpoint</a>
    /// </summary>
    let geoMidpoint = _prefixId.prefix "geoMidpoint"
    /// <summary>
    ///   <para>rdfs:label : geoOverlaps^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/geoOverlaps">schema:geoOverlaps</a>
    /// </summary>
    let geoOverlaps = _prefixId.prefix "geoOverlaps"
    /// <summary>
    ///   <para>rdfs:label : geoRadius^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).^^xsd:string</para>
    ///   <a href="http://schema.org/geoRadius">schema:geoRadius</a>
    /// </summary>
    let geoRadius = _prefixId.prefix "geoRadius"
    /// <summary>
    ///   <para>rdfs:comment : Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )^^xsd:string</para>
    ///   <para>rdfs:label : geoTouches^^xsd:string</para>
    ///   <a href="http://schema.org/geoTouches">schema:geoTouches</a>
    /// </summary>
    let geoTouches = _prefixId.prefix "geoTouches"
    /// <summary>
    ///   <para>rdfs:label : geoWithin^^xsd:string</para>
    ///   <para>rdfs:comment : Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/geoWithin">schema:geoWithin</a>
    /// </summary>
    let geoWithin = _prefixId.prefix "geoWithin"
    /// <summary>
    ///   <para>rdfs:comment : The geographic area associated with the audience.^^xsd:string</para>
    ///   <para>rdfs:label : geographicArea^^xsd:string</para>
    ///   <a href="http://schema.org/geographicArea">schema:geographicArea</a>
    /// </summary>
    let geographicArea = _prefixId.prefix "geographicArea"
    /// <summary>
    ///   <para>rdfs:label : givenName^^xsd:string</para>
    ///   <para>rdfs:comment : Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.^^xsd:string</para>
    ///   <a href="http://schema.org/givenName">schema:givenName</a>
    /// </summary>
    let givenName = _prefixId.prefix "givenName"
    /// <summary>
    ///   <para>rdfs:label : globalLocationNumber^^xsd:string</para>
    ///   <para>rdfs:comment : The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.^^xsd:string</para>
    ///   <a href="http://schema.org/globalLocationNumber">schema:globalLocationNumber</a>
    /// </summary>
    let globalLocationNumber = _prefixId.prefix "globalLocationNumber"
    /// <summary>
    ///   <para>rdfs:comment : The person, organization, contact point, or audience that has been granted this permission.^^xsd:string</para>
    ///   <para>rdfs:label : grantee^^xsd:string</para>
    ///   <a href="http://schema.org/grantee">schema:grantee</a>
    /// </summary>
    let grantee = _prefixId.prefix "grantee"
    /// <summary>
    ///   <para>rdfs:label : greater^^xsd:string</para>
    ///   <para>rdfs:comment : This ordering relation for qualitative values indicates that the subject is greater than the object.^^xsd:string</para>
    ///   <a href="http://schema.org/greater">schema:greater</a>
    /// </summary>
    let greater = _prefixId.prefix "greater"
    /// <summary>
    ///   <para>rdfs:label : greaterOrEqual^^xsd:string</para>
    ///   <para>rdfs:comment : This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.^^xsd:string</para>
    ///   <a href="http://schema.org/greaterOrEqual">schema:greaterOrEqual</a>
    /// </summary>
    let greaterOrEqual = _prefixId.prefix "greaterOrEqual"
    let gtin = _prefixId.prefix "gtin"
    /// <summary>
    ///   <para>rdfs:label : gtin12^^xsd:string</para>
    ///   <para>rdfs:comment : The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.^^xsd:string</para>
    ///   <a href="http://schema.org/gtin12">schema:gtin12</a>
    /// </summary>
    let gtin12 = _prefixId.prefix "gtin12"
    /// <summary>
    ///   <para>rdfs:comment : The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceeding zero. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.^^xsd:string</para>
    ///   <para>rdfs:label : gtin13^^xsd:string</para>
    ///   <a href="http://schema.org/gtin13">schema:gtin13</a>
    /// </summary>
    let gtin13 = _prefixId.prefix "gtin13"
    /// <summary>
    ///   <para>rdfs:comment : The GTIN-14 code of the product, or the product to which the offer refers. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.^^xsd:string</para>
    ///   <para>rdfs:label : gtin14^^xsd:string</para>
    ///   <a href="http://schema.org/gtin14">schema:gtin14</a>
    /// </summary>
    let gtin14 = _prefixId.prefix "gtin14"
    /// <summary>
    ///   <para>rdfs:label : gtin8^^xsd:string</para>
    ///   <para>rdfs:comment : The &lt;a href="http://apps.gs1.org/GDD/glossary/Pages/GTIN-8.aspx"&gt;GTIN-8&lt;/a&gt; code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See &lt;a href="http://www.gs1.org/barcodes/technical/idkeys/gtin"&gt;GS1 GTIN Summary&lt;/a&gt; for more details.^^xsd:string</para>
    ///   <a href="http://schema.org/gtin8">schema:gtin8</a>
    /// </summary>
    let gtin8 = _prefixId.prefix "gtin8"
    /// <summary>
    ///   <para>rdfs:comment : A broadcast channel of a broadcast service.^^xsd:string</para>
    ///   <para>rdfs:label : hasBroadcastChannel^^xsd:string</para>
    ///   <para>schema:category : issue-1004^^xsd:string</para>
    ///   <a href="http://schema.org/hasBroadcastChannel">schema:hasBroadcastChannel</a>
    /// </summary>
    let hasBroadcastChannel = _prefixId.prefix "hasBroadcastChannel"
    /// <summary>
    ///   <para>rdfs:label : hasCourseInstance^^xsd:string</para>
    ///   <para>rdfs:comment : An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.^^xsd:string</para>
    ///   <a href="http://schema.org/hasCourseInstance">schema:hasCourseInstance</a>
    /// </summary>
    let hasCourseInstance = _prefixId.prefix "hasCourseInstance"
    /// <summary>
    ///   <para>rdfs:comment : Method used for delivery or shipping.^^xsd:string</para>
    ///   <para>rdfs:label : hasDeliveryMethod^^xsd:string</para>
    ///   <a href="http://schema.org/hasDeliveryMethod">schema:hasDeliveryMethod</a>
    /// </summary>
    let hasDeliveryMethod = _prefixId.prefix "hasDeliveryMethod"
    /// <summary>
    ///   <para>rdfs:label : hasDigitalDocumentPermission^^xsd:string</para>
    ///   <para>rdfs:comment : A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".^^xsd:string</para>
    ///   <a href="http://schema.org/hasDigitalDocumentPermission">schema:hasDigitalDocumentPermission</a>
    /// </summary>
    let hasDigitalDocumentPermission = _prefixId.prefix "hasDigitalDocumentPermission"
    /// <summary>
    ///   <para>rdfs:label : hasMap^^xsd:string</para>
    ///   <para>rdfs:comment : A URL to a map of the place.^^xsd:string</para>
    ///   <a href="http://schema.org/hasMap">schema:hasMap</a>
    /// </summary>
    let hasMap = _prefixId.prefix "hasMap"
    /// <summary>
    ///   <para>rdfs:comment : Either the actual menu as a structured representation, as text, or a URL of the menu.^^xsd:string</para>
    ///   <para>rdfs:label : hasMenu^^xsd:string</para>
    ///   <a href="http://schema.org/hasMenu">schema:hasMenu</a>
    /// </summary>
    let hasMenu = _prefixId.prefix "hasMenu"
    /// <summary>
    ///   <para>rdfs:label : hasMenuItem^^xsd:string</para>
    ///   <para>rdfs:comment : A food or drink item contained in a menu or menu section.^^xsd:string</para>
    ///   <a href="http://schema.org/hasMenuItem">schema:hasMenuItem</a>
    /// </summary>
    let hasMenuItem = _prefixId.prefix "hasMenuItem"
    /// <summary>
    ///   <para>rdfs:comment : A subgrouping of the menu (by dishes, course, serving time period, etc.).^^xsd:string</para>
    ///   <para>rdfs:label : hasMenuSection^^xsd:string</para>
    ///   <a href="http://schema.org/hasMenuSection">schema:hasMenuSection</a>
    /// </summary>
    let hasMenuSection = _prefixId.prefix "hasMenuSection"
    /// <summary>
    ///   <para>rdfs:label : hasOccupation^^xsd:string</para>
    ///   <para>rdfs:comment : The Person's occupation. For past professions, use Role for expressing dates.^^xsd:string</para>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <a href="http://schema.org/hasOccupation">schema:hasOccupation</a>
    /// </summary>
    let hasOccupation = _prefixId.prefix "hasOccupation"
    /// <summary>
    ///   <para>rdfs:label : hasOfferCatalog^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates an OfferCatalog listing for this Organization, Person, or Service.^^xsd:string</para>
    ///   <a href="http://schema.org/hasOfferCatalog">schema:hasOfferCatalog</a>
    /// </summary>
    let hasOfferCatalog = _prefixId.prefix "hasOfferCatalog"
    /// <summary>
    ///   <para>rdfs:label : hasPOS^^xsd:string</para>
    ///   <para>rdfs:comment : Points-of-Sales operated by the organization or person.^^xsd:string</para>
    ///   <a href="http://schema.org/hasPOS">schema:hasPOS</a>
    /// </summary>
    let hasPOS = _prefixId.prefix "hasPOS"
    /// <summary>
    ///   <para>rdfs:label : hasPart^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).^^xsd:string</para>
    ///   <a href="http://schema.org/hasPart">schema:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:label : headline^^xsd:string</para>
    ///   <para>rdfs:comment : Headline of the article.^^xsd:string</para>
    ///   <a href="http://schema.org/headline">schema:headline</a>
    /// </summary>
    let headline = _prefixId.prefix "headline"
    /// <summary>
    ///   <para>rdfs:label : height^^xsd:string</para>
    ///   <para>rdfs:comment : The height of the item.^^xsd:string</para>
    ///   <a href="http://schema.org/height">schema:height</a>
    /// </summary>
    let height = _prefixId.prefix "height"
    /// <summary>
    ///   <para>rdfs:comment : The highest price of all offers available.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : highPrice^^xsd:string</para>
    ///   <a href="http://schema.org/highPrice">schema:highPrice</a>
    /// </summary>
    let highPrice = _prefixId.prefix "highPrice"
    /// <summary>
    ///   <para>rdfs:label : hiringOrganization^^xsd:string</para>
    ///   <para>rdfs:comment : Organization offering the job position.^^xsd:string</para>
    ///   <a href="http://schema.org/hiringOrganization">schema:hiringOrganization</a>
    /// </summary>
    let hiringOrganization = _prefixId.prefix "hiringOrganization"
    /// <summary>
    ///   <para>rdfs:comment : A contact location for a person's residence.^^xsd:string</para>
    ///   <para>rdfs:label : homeLocation^^xsd:string</para>
    ///   <a href="http://schema.org/homeLocation">schema:homeLocation</a>
    /// </summary>
    let homeLocation = _prefixId.prefix "homeLocation"
    /// <summary>
    ///   <para>rdfs:label : homeTeam^^xsd:string</para>
    ///   <para>rdfs:comment : The home team in a sports event.^^xsd:string</para>
    ///   <a href="http://schema.org/homeTeam">schema:homeTeam</a>
    /// </summary>
    let homeTeam = _prefixId.prefix "homeTeam"
    /// <summary>
    ///   <para>rdfs:label : honorificPrefix^^xsd:string</para>
    ///   <para>rdfs:comment : An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.^^xsd:string</para>
    ///   <a href="http://schema.org/honorificPrefix">schema:honorificPrefix</a>
    /// </summary>
    let honorificPrefix = _prefixId.prefix "honorificPrefix"
    /// <summary>
    ///   <para>rdfs:comment : An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.^^xsd:string</para>
    ///   <para>rdfs:label : honorificSuffix^^xsd:string</para>
    ///   <a href="http://schema.org/honorificSuffix">schema:honorificSuffix</a>
    /// </summary>
    let honorificSuffix = _prefixId.prefix "honorificSuffix"
    /// <summary>
    ///   <para>rdfs:label : hostingOrganization^^xsd:string</para>
    ///   <para>rdfs:comment : The organization (airline, travelers' club, etc.) the membership is made with.^^xsd:string</para>
    ///   <a href="http://schema.org/hostingOrganization">schema:hostingOrganization</a>
    /// </summary>
    let hostingOrganization = _prefixId.prefix "hostingOrganization"
    /// <summary>
    ///   <para>rdfs:comment : The hours during which this service or contact is available.^^xsd:string</para>
    ///   <para>rdfs:label : hoursAvailable^^xsd:string</para>
    ///   <a href="http://schema.org/hoursAvailable">schema:hoursAvailable</a>
    /// </summary>
    let hoursAvailable = _prefixId.prefix "hoursAvailable"
    /// <summary>
    ///   <para>rdfs:label : httpMethod^^xsd:string</para>
    ///   <para>rdfs:comment : An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.^^xsd:string</para>
    ///   <a href="http://schema.org/httpMethod">schema:httpMethod</a>
    /// </summary>
    let httpMethod = _prefixId.prefix "httpMethod"
    /// <summary>
    ///   <para>rdfs:label : iataCode^^xsd:string</para>
    ///   <para>rdfs:comment : IATA identifier for an airline or airport.^^xsd:string</para>
    ///   <a href="http://schema.org/iataCode">schema:iataCode</a>
    /// </summary>
    let iataCode = _prefixId.prefix "iataCode"
    /// <summary>
    ///   <para>rdfs:label : icaoCode^^xsd:string</para>
    ///   <para>rdfs:comment : ICAO identifier for an airport.^^xsd:string</para>
    ///   <a href="http://schema.org/icaoCode">schema:icaoCode</a>
    /// </summary>
    let icaoCode = _prefixId.prefix "icaoCode"
    /// <summary>
    ///   <para>rdfs:comment : The identifier property represents any kind of identifier for any kind of &lt;a class="localLink" href="http://schema.org/Thing"&gt;Thing&lt;/a&gt;, such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See &lt;a href="/docs/datamodel.html#identifierBg"&gt;background notes&lt;/a&gt; for more details.^^xsd:string</para>
    ///   <para>rdfs:label : identifier^^xsd:string</para>
    ///   <a href="http://schema.org/identifier">schema:identifier</a>
    /// </summary>
    let identifier = _prefixId.prefix "identifier"
    /// <summary>
    ///   <para>rdfs:label : illustrator^^xsd:string</para>
    ///   <para>rdfs:comment : The illustrator of the book.^^xsd:string</para>
    ///   <a href="http://schema.org/illustrator">schema:illustrator</a>
    /// </summary>
    let illustrator = _prefixId.prefix "illustrator"
    /// <summary>
    ///   <para>rdfs:label : image^^xsd:string</para>
    ///   <para>rdfs:comment : An image of the item. This can be a &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt; or a fully described &lt;a class="localLink" href="http://schema.org/ImageObject"&gt;ImageObject&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/image">schema:image</a>
    /// </summary>
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:comment : The album to which this recording belongs.^^xsd:string</para>
    ///   <para>rdfs:label : inAlbum^^xsd:string</para>
    ///   <a href="http://schema.org/inAlbum">schema:inAlbum</a>
    /// </summary>
    let inAlbum = _prefixId.prefix "inAlbum"
    /// <summary>
    ///   <para>rdfs:label : inBroadcastLineup^^xsd:string</para>
    ///   <para>rdfs:comment : The CableOrSatelliteService offering the channel.^^xsd:string</para>
    ///   <a href="http://schema.org/inBroadcastLineup">schema:inBroadcastLineup</a>
    /// </summary>
    let inBroadcastLineup = _prefixId.prefix "inBroadcastLineup"
    /// <summary>
    ///   <para>rdfs:comment : The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : inLanguage^^xsd:string</para>
    ///   <para>schema:category : issue-2382^^xsd:string</para>
    ///   <a href="http://schema.org/inLanguage">schema:inLanguage</a>
    /// </summary>
    let inLanguage = _prefixId.prefix "inLanguage"
    /// <summary>
    ///   <para>rdfs:comment : The playlist to which this recording belongs.^^xsd:string</para>
    ///   <para>rdfs:label : inPlaylist^^xsd:string</para>
    ///   <a href="http://schema.org/inPlaylist">schema:inPlaylist</a>
    /// </summary>
    let inPlaylist = _prefixId.prefix "inPlaylist"
    /// <summary>
    ///   <para>rdfs:label : incentiveCompensation^^xsd:string</para>
    ///   <para>rdfs:comment : Description of bonus and commission compensation aspects of the job.^^xsd:string</para>
    ///   <a href="http://schema.org/incentiveCompensation">schema:incentiveCompensation</a>
    /// </summary>
    let incentiveCompensation = _prefixId.prefix "incentiveCompensation"
    /// <summary>
    ///   <para>rdfs:label : incentives^^xsd:string</para>
    ///   <para>rdfs:comment : Description of bonus and commission compensation aspects of the job.^^xsd:string</para>
    ///   <a href="http://schema.org/incentives">schema:incentives</a>
    /// </summary>
    let incentives = _prefixId.prefix "incentives"
    /// <summary>
    ///   <para>rdfs:comment : Smaller compositions included in this work (e.g. a movement in a symphony).^^xsd:string</para>
    ///   <para>rdfs:label : includedComposition^^xsd:string</para>
    ///   <a href="http://schema.org/includedComposition">schema:includedComposition</a>
    /// </summary>
    let includedComposition = _prefixId.prefix "includedComposition"
    /// <summary>
    ///   <para>rdfs:comment : A data catalog which contains this dataset (this property was previously 'catalog', preferred name is now 'includedInDataCatalog').^^xsd:string</para>
    ///   <para>rdfs:label : includedDataCatalog^^xsd:string</para>
    ///   <a href="http://schema.org/includedDataCatalog">schema:includedDataCatalog</a>
    /// </summary>
    let includedDataCatalog = _prefixId.prefix "includedDataCatalog"
    /// <summary>
    ///   <para>rdfs:comment : A data catalog which contains this dataset.^^xsd:string</para>
    ///   <para>rdfs:label : includedInDataCatalog^^xsd:string</para>
    ///   <a href="http://schema.org/includedInDataCatalog">schema:includedInDataCatalog</a>
    /// </summary>
    let includedInDataCatalog = _prefixId.prefix "includedInDataCatalog"
    /// <summary>
    ///   <para>rdfs:label : includesObject^^xsd:string</para>
    ///   <para>rdfs:comment : This links to a node or nodes indicating the exact quantity of the products included in the offer.^^xsd:string</para>
    ///   <a href="http://schema.org/includesObject">schema:includesObject</a>
    /// </summary>
    let includesObject = _prefixId.prefix "includesObject"
    /// <summary>
    ///   <para>rdfs:label : industry^^xsd:string</para>
    ///   <para>rdfs:comment : The industry associated with the job position.^^xsd:string</para>
    ///   <a href="http://schema.org/industry">schema:industry</a>
    /// </summary>
    let industry = _prefixId.prefix "industry"
    /// <summary>
    ///   <para>rdfs:comment : A single ingredient used in the recipe, e.g. sugar, flour or garlic.^^xsd:string</para>
    ///   <para>rdfs:label : ingredients^^xsd:string</para>
    ///   <a href="http://schema.org/ingredients">schema:ingredients</a>
    /// </summary>
    let ingredients = _prefixId.prefix "ingredients"
    /// <summary>
    ///   <para>rdfs:comment : URL at which the app may be installed, if different from the URL of the item.^^xsd:string</para>
    ///   <para>rdfs:label : installUrl^^xsd:string</para>
    ///   <a href="http://schema.org/installUrl">schema:installUrl</a>
    /// </summary>
    let installUrl = _prefixId.prefix "installUrl"
    /// <summary>
    ///   <para>rdfs:label : instructor^^xsd:string</para>
    ///   <para>rdfs:comment : A person assigned to instruct or provide instructional assistance for the &lt;a class="localLink" href="http://schema.org/CourseInstance"&gt;CourseInstance&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/instructor">schema:instructor</a>
    /// </summary>
    let instructor = _prefixId.prefix "instructor"
    /// <summary>
    ///   <para>rdfs:label : instrument^^xsd:string</para>
    ///   <para>rdfs:comment : The object that helped the agent perform the action. e.g. John wrote a book with &lt;em&gt;a pen&lt;/em&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/instrument">schema:instrument</a>
    /// </summary>
    let instrument = _prefixId.prefix "instrument"
    /// <summary>
    ///   <para>rdfs:comment : This property is deprecated, alongside the UserInteraction types on which it depended.^^xsd:string</para>
    ///   <para>rdfs:label : interactionCount^^xsd:string</para>
    ///   <a href="http://schema.org/interactionCount">schema:interactionCount</a>
    /// </summary>
    let interactionCount = _prefixId.prefix "interactionCount"
    /// <summary>
    ///   <para>rdfs:comment : The WebSite or SoftwareApplication where the interactions took place.^^xsd:string</para>
    ///   <para>rdfs:label : interactionService^^xsd:string</para>
    ///   <a href="http://schema.org/interactionService">schema:interactionService</a>
    /// </summary>
    let interactionService = _prefixId.prefix "interactionService"
    /// <summary>
    ///   <para>rdfs:label : interactionStatistic^^xsd:string</para>
    ///   <para>rdfs:comment : The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.^^xsd:string</para>
    ///   <para>schema:category : issue-2421^^xsd:string</para>
    ///   <a href="http://schema.org/interactionStatistic">schema:interactionStatistic</a>
    /// </summary>
    let interactionStatistic = _prefixId.prefix "interactionStatistic"
    /// <summary>
    ///   <para>rdfs:comment : The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="http://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="http://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.^^xsd:string</para>
    ///   <para>rdfs:label : interactionType^^xsd:string</para>
    ///   <a href="http://schema.org/interactionType">schema:interactionType</a>
    /// </summary>
    let interactionType = _prefixId.prefix "interactionType"
    /// <summary>
    ///   <para>rdfs:label : interactivityType^^xsd:string</para>
    ///   <para>rdfs:comment : The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.^^xsd:string</para>
    ///   <a href="http://schema.org/interactivityType">schema:interactivityType</a>
    /// </summary>
    let interactivityType = _prefixId.prefix "interactivityType"
    /// <summary>
    ///   <para>rdfs:comment : The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.^^xsd:string</para>
    ///   <para>rdfs:label : interestRate^^xsd:string</para>
    ///   <a href="http://schema.org/interestRate">schema:interestRate</a>
    /// </summary>
    let interestRate = _prefixId.prefix "interestRate"
    /// <summary>
    ///   <para>rdfs:comment : The current approximate inventory level for the item or items.^^xsd:string</para>
    ///   <para>rdfs:label : inventoryLevel^^xsd:string</para>
    ///   <a href="http://schema.org/inventoryLevel">schema:inventoryLevel</a>
    /// </summary>
    let inventoryLevel = _prefixId.prefix "inventoryLevel"
    let inverseOf = _prefixId.prefix "inverseOf"
    /// <summary>
    ///   <para>rdfs:label : isAccessibleForFree^^xsd:string</para>
    ///   <para>rdfs:comment : A flag to signal that the item, event, or place is accessible for free.^^xsd:string</para>
    ///   <a href="http://schema.org/isAccessibleForFree">schema:isAccessibleForFree</a>
    /// </summary>
    let isAccessibleForFree = _prefixId.prefix "isAccessibleForFree"
    /// <summary>
    ///   <para>rdfs:label : isAccessoryOrSparePartFor^^xsd:string</para>
    ///   <para>rdfs:comment : A pointer to another product (or multiple products) for which this product is an accessory or spare part.^^xsd:string</para>
    ///   <a href="http://schema.org/isAccessoryOrSparePartFor">schema:isAccessoryOrSparePartFor</a>
    /// </summary>
    let isAccessoryOrSparePartFor = _prefixId.prefix "isAccessoryOrSparePartFor"
    /// <summary>
    ///   <para>rdfs:comment : A resource from which this work is derived or from which it is a modification or adaption.^^xsd:string</para>
    ///   <para>rdfs:label : isBasedOn^^xsd:string</para>
    ///   <a href="http://schema.org/isBasedOn">schema:isBasedOn</a>
    /// </summary>
    let isBasedOn = _prefixId.prefix "isBasedOn"
    /// <summary>
    ///   <para>rdfs:label : isBasedOnUrl^^xsd:string</para>
    ///   <para>rdfs:comment : A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.^^xsd:string</para>
    ///   <a href="http://schema.org/isBasedOnUrl">schema:isBasedOnUrl</a>
    /// </summary>
    let isBasedOnUrl = _prefixId.prefix "isBasedOnUrl"
    /// <summary>
    ///   <para>rdfs:label : isConsumableFor^^xsd:string</para>
    ///   <para>rdfs:comment : A pointer to another product (or multiple products) for which this product is a consumable.^^xsd:string</para>
    ///   <a href="http://schema.org/isConsumableFor">schema:isConsumableFor</a>
    /// </summary>
    let isConsumableFor = _prefixId.prefix "isConsumableFor"
    /// <summary>
    ///   <para>rdfs:label : isFamilyFriendly^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether this content is family friendly.^^xsd:string</para>
    ///   <a href="http://schema.org/isFamilyFriendly">schema:isFamilyFriendly</a>
    /// </summary>
    let isFamilyFriendly = _prefixId.prefix "isFamilyFriendly"
    /// <summary>
    ///   <para>rdfs:comment : Was the offer accepted as a gift for someone other than the buyer.^^xsd:string</para>
    ///   <para>rdfs:label : isGift^^xsd:string</para>
    ///   <a href="http://schema.org/isGift">schema:isGift</a>
    /// </summary>
    let isGift = _prefixId.prefix "isGift"
    /// <summary>
    ///   <para>rdfs:label : isLiveBroadcast^^xsd:string</para>
    ///   <para>rdfs:comment : True is the broadcast is of a live event.^^xsd:string</para>
    ///   <a href="http://schema.org/isLiveBroadcast">schema:isLiveBroadcast</a>
    /// </summary>
    let isLiveBroadcast = _prefixId.prefix "isLiveBroadcast"
    /// <summary>
    ///   <para>rdfs:label : isPartOf^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.^^xsd:string</para>
    ///   <a href="http://schema.org/isPartOf">schema:isPartOf</a>
    /// </summary>
    let isPartOf = _prefixId.prefix "isPartOf"
    /// <summary>
    ///   <para>rdfs:label : isRelatedTo^^xsd:string</para>
    ///   <para>rdfs:comment : A pointer to another, somehow related product (or multiple products).^^xsd:string</para>
    ///   <a href="http://schema.org/isRelatedTo">schema:isRelatedTo</a>
    /// </summary>
    let isRelatedTo = _prefixId.prefix "isRelatedTo"
    /// <summary>
    ///   <para>rdfs:comment : A pointer to another, functionally similar product (or multiple products).^^xsd:string</para>
    ///   <para>rdfs:label : isSimilarTo^^xsd:string</para>
    ///   <a href="http://schema.org/isSimilarTo">schema:isSimilarTo</a>
    /// </summary>
    let isSimilarTo = _prefixId.prefix "isSimilarTo"
    /// <summary>
    ///   <para>rdfs:comment : A pointer to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive.^^xsd:string</para>
    ///   <para>rdfs:label : isVariantOf^^xsd:string</para>
    ///   <a href="http://schema.org/isVariantOf">schema:isVariantOf</a>
    /// </summary>
    let isVariantOf = _prefixId.prefix "isVariantOf"
    /// <summary>
    ///   <para>rdfs:label : isbn^^xsd:string</para>
    ///   <para>rdfs:comment : The ISBN of the book.^^xsd:string</para>
    ///   <a href="http://schema.org/isbn">schema:isbn</a>
    /// </summary>
    let isbn = _prefixId.prefix "isbn"
    /// <summary>
    ///   <para>rdfs:comment : The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.^^xsd:string</para>
    ///   <para>rdfs:label : isicV4^^xsd:string</para>
    ///   <a href="http://schema.org/isicV4">schema:isicV4</a>
    /// </summary>
    let isicV4 = _prefixId.prefix "isicV4"
    /// <summary>
    ///   <para>rdfs:label : isrcCode^^xsd:string</para>
    ///   <para>rdfs:comment : The International Standard Recording Code for the recording.^^xsd:string</para>
    ///   <a href="http://schema.org/isrcCode">schema:isrcCode</a>
    /// </summary>
    let isrcCode = _prefixId.prefix "isrcCode"
    /// <summary>
    ///   <para>rdfs:comment : The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.^^xsd:string</para>
    ///   <para>rdfs:label : issn^^xsd:string</para>
    ///   <a href="http://schema.org/issn">schema:issn</a>
    /// </summary>
    let issn = _prefixId.prefix "issn"
    /// <summary>
    ///   <para>rdfs:label : issueNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies the issue of publication; for example, "iii" or "2".^^xsd:string</para>
    ///   <a href="http://schema.org/issueNumber">schema:issueNumber</a>
    /// </summary>
    let issueNumber = _prefixId.prefix "issueNumber"
    /// <summary>
    ///   <para>rdfs:comment : The organization issuing the ticket or permit.^^xsd:string</para>
    ///   <para>rdfs:label : issuedBy^^xsd:string</para>
    ///   <a href="http://schema.org/issuedBy">schema:issuedBy</a>
    /// </summary>
    let issuedBy = _prefixId.prefix "issuedBy"
    /// <summary>
    ///   <para>rdfs:comment : The service through with the permit was granted.^^xsd:string</para>
    ///   <para>rdfs:label : issuedThrough^^xsd:string</para>
    ///   <a href="http://schema.org/issuedThrough">schema:issuedThrough</a>
    /// </summary>
    let issuedThrough = _prefixId.prefix "issuedThrough"
    /// <summary>
    ///   <para>rdfs:label : iswcCode^^xsd:string</para>
    ///   <para>rdfs:comment : The International Standard Musical Work Code for the composition.^^xsd:string</para>
    ///   <a href="http://schema.org/iswcCode">schema:iswcCode</a>
    /// </summary>
    let iswcCode = _prefixId.prefix "iswcCode"
    /// <summary>
    ///   <para>rdfs:label : item^^xsd:string</para>
    ///   <para>rdfs:comment : An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.^^xsd:string</para>
    ///   <a href="http://schema.org/item">schema:item</a>
    /// </summary>
    let item = _prefixId.prefix "item"
    /// <summary>
    ///   <para>rdfs:label : itemCondition^^xsd:string</para>
    ///   <para>rdfs:comment : A predefined value from OfferItemCondition or a textual description of the condition of the product or service, or the products or services included in the offer.^^xsd:string</para>
    ///   <a href="http://schema.org/itemCondition">schema:itemCondition</a>
    /// </summary>
    let itemCondition = _prefixId.prefix "itemCondition"
    /// <summary>
    ///   <para>rdfs:label : itemListElement^^xsd:string</para>
    ///   <para>rdfs:comment : For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Text values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.^^xsd:string</para>
    ///   <a href="http://schema.org/itemListElement">schema:itemListElement</a>
    /// </summary>
    let itemListElement = _prefixId.prefix "itemListElement"
    /// <summary>
    ///   <para>rdfs:comment : Type of ordering (e.g. Ascending, Descending, Unordered).^^xsd:string</para>
    ///   <para>rdfs:label : itemListOrder^^xsd:string</para>
    ///   <a href="http://schema.org/itemListOrder">schema:itemListOrder</a>
    /// </summary>
    let itemListOrder = _prefixId.prefix "itemListOrder"
    /// <summary>
    ///   <para>rdfs:comment : An item being offered (or demanded). The transactional nature of the offer or demand is documented using &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt;, e.g. sell, lease etc. While several common expected types are listed explicitly in this definition, others can be used. Using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.^^xsd:string</para>
    ///   <para>rdfs:label : itemOffered^^xsd:string</para>
    ///   <a href="http://schema.org/itemOffered">schema:itemOffered</a>
    /// </summary>
    let itemOffered = _prefixId.prefix "itemOffered"
    /// <summary>
    ///   <para>rdfs:label : itemReviewed^^xsd:string</para>
    ///   <para>rdfs:comment : The item that is being reviewed/rated.^^xsd:string</para>
    ///   <a href="http://schema.org/itemReviewed">schema:itemReviewed</a>
    /// </summary>
    let itemReviewed = _prefixId.prefix "itemReviewed"
    /// <summary>
    ///   <para>rdfs:comment : Item(s) being shipped.^^xsd:string</para>
    ///   <para>rdfs:label : itemShipped^^xsd:string</para>
    ///   <a href="http://schema.org/itemShipped">schema:itemShipped</a>
    /// </summary>
    let itemShipped = _prefixId.prefix "itemShipped"
    /// <summary>
    ///   <para>rdfs:label : jobBenefits^^xsd:string</para>
    ///   <para>rdfs:comment : Description of benefits associated with the job.^^xsd:string</para>
    ///   <a href="http://schema.org/jobBenefits">schema:jobBenefits</a>
    /// </summary>
    let jobBenefits = _prefixId.prefix "jobBenefits"
    /// <summary>
    ///   <para>rdfs:comment : A (typically single) geographic location associated with the job position.^^xsd:string</para>
    ///   <para>rdfs:label : jobLocation^^xsd:string</para>
    ///   <a href="http://schema.org/jobLocation">schema:jobLocation</a>
    /// </summary>
    let jobLocation = _prefixId.prefix "jobLocation"
    /// <summary>
    ///   <para>rdfs:label : keywords^^xsd:string</para>
    ///   <para>rdfs:comment : Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.^^xsd:string</para>
    ///   <a href="http://schema.org/keywords">schema:keywords</a>
    /// </summary>
    let keywords = _prefixId.prefix "keywords"
    /// <summary>
    ///   <para>rdfs:comment : A textual description of known damages, both repaired and unrepaired.^^xsd:string</para>
    ///   <para>rdfs:label : knownVehicleDamages^^xsd:string</para>
    ///   <a href="http://schema.org/knownVehicleDamages">schema:knownVehicleDamages</a>
    /// </summary>
    let knownVehicleDamages = _prefixId.prefix "knownVehicleDamages"
    /// <summary>
    ///   <para>rdfs:comment : The most generic bi-directional social/work relation.^^xsd:string</para>
    ///   <para>rdfs:label : knows^^xsd:string</para>
    ///   <a href="http://schema.org/knows">schema:knows</a>
    /// </summary>
    let knows = _prefixId.prefix "knows"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of participant. The owner of the real estate property.^^xsd:string</para>
    ///   <para>rdfs:label : landlord^^xsd:string</para>
    ///   <a href="http://schema.org/landlord">schema:landlord</a>
    /// </summary>
    let landlord = _prefixId.prefix "landlord"
    /// <summary>
    ///   <para>rdfs:label : language^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of instrument. The language used on this action.^^xsd:string</para>
    ///   <a href="http://schema.org/language">schema:language</a>
    /// </summary>
    let language = _prefixId.prefix "language"
    /// <summary>
    ///   <para>rdfs:comment : Date on which the content on this web page was last reviewed for accuracy and/or completeness.^^xsd:string</para>
    ///   <para>rdfs:label : lastReviewed^^xsd:string</para>
    ///   <a href="http://schema.org/lastReviewed">schema:lastReviewed</a>
    /// </summary>
    let lastReviewed = _prefixId.prefix "lastReviewed"
    /// <summary>
    ///   <para>rdfs:comment : The latitude of a location. For example &lt;code&gt;37.42242&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).^^xsd:string</para>
    ///   <para>rdfs:label : latitude^^xsd:string</para>
    ///   <a href="http://schema.org/latitude">schema:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:label : learningResourceType^^xsd:string</para>
    ///   <para>rdfs:comment : The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.^^xsd:string</para>
    ///   <a href="http://schema.org/learningResourceType">schema:learningResourceType</a>
    /// </summary>
    let learningResourceType = _prefixId.prefix "learningResourceType"
    /// <summary>
    ///   <para>rdfs:label : legalName^^xsd:string</para>
    ///   <para>rdfs:comment : The official name of the organization, e.g. the registered company name.^^xsd:string</para>
    ///   <a href="http://schema.org/legalName">schema:legalName</a>
    /// </summary>
    let legalName = _prefixId.prefix "legalName"
    /// <summary>
    ///   <para>rdfs:label : leiCode^^xsd:string</para>
    ///   <para>rdfs:comment : An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.^^xsd:string</para>
    ///   <a href="http://schema.org/leiCode">schema:leiCode</a>
    /// </summary>
    let leiCode = _prefixId.prefix "leiCode"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of participant. The person that lends the object being borrowed.^^xsd:string</para>
    ///   <para>rdfs:label : lender^^xsd:string</para>
    ///   <a href="http://schema.org/lender">schema:lender</a>
    /// </summary>
    let lender = _prefixId.prefix "lender"
    /// <summary>
    ///   <para>rdfs:label : lesser^^xsd:string</para>
    ///   <para>rdfs:comment : This ordering relation for qualitative values indicates that the subject is lesser than the object.^^xsd:string</para>
    ///   <a href="http://schema.org/lesser">schema:lesser</a>
    /// </summary>
    let lesser = _prefixId.prefix "lesser"
    /// <summary>
    ///   <para>rdfs:label : lesserOrEqual^^xsd:string</para>
    ///   <para>rdfs:comment : This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.^^xsd:string</para>
    ///   <a href="http://schema.org/lesserOrEqual">schema:lesserOrEqual</a>
    /// </summary>
    let lesserOrEqual = _prefixId.prefix "lesserOrEqual"
    /// <summary>
    ///   <para>rdfs:comment : A license document that applies to this content, typically indicated by URL.^^xsd:string</para>
    ///   <para>rdfs:label : license^^xsd:string</para>
    ///   <a href="http://schema.org/license">schema:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>rdfs:comment : A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.^^xsd:string</para>
    ///   <para>rdfs:label : line^^xsd:string</para>
    ///   <a href="http://schema.org/line">schema:line</a>
    /// </summary>
    let line = _prefixId.prefix "line"
    /// <summary>
    ///   <para>rdfs:comment : An update to the LiveBlog.^^xsd:string</para>
    ///   <para>rdfs:label : liveBlogUpdate^^xsd:string</para>
    ///   <a href="http://schema.org/liveBlogUpdate">schema:liveBlogUpdate</a>
    /// </summary>
    let liveBlogUpdate = _prefixId.prefix "liveBlogUpdate"
    /// <summary>
    ///   <para>rdfs:comment : The duration of the loan or credit agreement.^^xsd:string</para>
    ///   <para>rdfs:label : loanTerm^^xsd:string</para>
    ///   <a href="http://schema.org/loanTerm">schema:loanTerm</a>
    /// </summary>
    let loanTerm = _prefixId.prefix "loanTerm"
    /// <summary>
    ///   <para>rdfs:comment : The location of for example where the event is happening, an organization is located, or where an action takes place.^^xsd:string</para>
    ///   <para>rdfs:label : location^^xsd:string</para>
    ///   <a href="http://schema.org/location">schema:location</a>
    /// </summary>
    let location = _prefixId.prefix "location"
    /// <summary>
    ///   <para>rdfs:comment : The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.^^xsd:string</para>
    ///   <para>rdfs:label : locationCreated^^xsd:string</para>
    ///   <a href="http://schema.org/locationCreated">schema:locationCreated</a>
    /// </summary>
    let locationCreated = _prefixId.prefix "locationCreated"
    /// <summary>
    ///   <para>rdfs:label : lodgingUnitDescription^^xsd:string</para>
    ///   <para>rdfs:comment : A full description of the lodging unit.^^xsd:string</para>
    ///   <a href="http://schema.org/lodgingUnitDescription">schema:lodgingUnitDescription</a>
    /// </summary>
    let lodgingUnitDescription = _prefixId.prefix "lodgingUnitDescription"
    /// <summary>
    ///   <para>rdfs:comment : Textual description of the unit type (including suite vs. room, size of bed, etc.).^^xsd:string</para>
    ///   <para>rdfs:label : lodgingUnitType^^xsd:string</para>
    ///   <a href="http://schema.org/lodgingUnitType">schema:lodgingUnitType</a>
    /// </summary>
    let lodgingUnitType = _prefixId.prefix "lodgingUnitType"
    /// <summary>
    ///   <para>rdfs:comment : An associated logo.^^xsd:string</para>
    ///   <para>rdfs:label : logo^^xsd:string</para>
    ///   <a href="http://schema.org/logo">schema:logo</a>
    /// </summary>
    let logo = _prefixId.prefix "logo"
    /// <summary>
    ///   <para>rdfs:label : longitude^^xsd:string</para>
    ///   <para>rdfs:comment : The longitude of a location. For example &lt;code&gt;-122.08585&lt;/code&gt; (&lt;a href="https://en.wikipedia.org/wiki/World_Geodetic_System"&gt;WGS 84&lt;/a&gt;).^^xsd:string</para>
    ///   <a href="http://schema.org/longitude">schema:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of participant. The loser of the action.^^xsd:string</para>
    ///   <para>rdfs:label : loser^^xsd:string</para>
    ///   <a href="http://schema.org/loser">schema:loser</a>
    /// </summary>
    let loser = _prefixId.prefix "loser"
    /// <summary>
    ///   <para>rdfs:label : lowPrice^^xsd:string</para>
    ///   <para>rdfs:comment : The lowest price of all offers available.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/lowPrice">schema:lowPrice</a>
    /// </summary>
    let lowPrice = _prefixId.prefix "lowPrice"
    /// <summary>
    ///   <para>rdfs:comment : The person who wrote the words.^^xsd:string</para>
    ///   <para>rdfs:label : lyricist^^xsd:string</para>
    ///   <a href="http://schema.org/lyricist">schema:lyricist</a>
    /// </summary>
    let lyricist = _prefixId.prefix "lyricist"
    /// <summary>
    ///   <para>rdfs:comment : The words in the song.^^xsd:string</para>
    ///   <para>rdfs:label : lyrics^^xsd:string</para>
    ///   <a href="http://schema.org/lyrics">schema:lyrics</a>
    /// </summary>
    let lyrics = _prefixId.prefix "lyrics"
    /// <summary>
    ///   <para>rdfs:label : mainContentOfPage^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates if this web page element is the main subject of the page.^^xsd:string</para>
    ///   <a href="http://schema.org/mainContentOfPage">schema:mainContentOfPage</a>
    /// </summary>
    let mainContentOfPage = _prefixId.prefix "mainContentOfPage"
    /// <summary>
    ///   <para>rdfs:label : mainEntity^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the primary entity described in some page or other CreativeWork.^^xsd:string</para>
    ///   <a href="http://schema.org/mainEntity">schema:mainEntity</a>
    /// </summary>
    let mainEntity = _prefixId.prefix "mainEntity"
    /// <summary>
    ///   <para>rdfs:label : mainEntityOfPage^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See &lt;a href="/docs/datamodel.html#mainEntityBackground"&gt;background notes&lt;/a&gt; for details.^^xsd:string</para>
    ///   <a href="http://schema.org/mainEntityOfPage">schema:mainEntityOfPage</a>
    /// </summary>
    let mainEntityOfPage = _prefixId.prefix "mainEntityOfPage"
    /// <summary>
    ///   <para>rdfs:label : makesOffer^^xsd:string</para>
    ///   <para>rdfs:comment : A pointer to products or services offered by the organization or person.^^xsd:string</para>
    ///   <a href="http://schema.org/makesOffer">schema:makesOffer</a>
    /// </summary>
    let makesOffer = _prefixId.prefix "makesOffer"
    /// <summary>
    ///   <para>rdfs:label : manufacturer^^xsd:string</para>
    ///   <para>rdfs:comment : The manufacturer of the product.^^xsd:string</para>
    ///   <a href="http://schema.org/manufacturer">schema:manufacturer</a>
    /// </summary>
    let manufacturer = _prefixId.prefix "manufacturer"
    /// <summary>
    ///   <para>rdfs:label : map^^xsd:string</para>
    ///   <para>rdfs:comment : A URL to a map of the place.^^xsd:string</para>
    ///   <a href="http://schema.org/map">schema:map</a>
    /// </summary>
    let map = _prefixId.prefix "map"
    /// <summary>
    ///   <para>rdfs:label : mapType^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the kind of Map, from the MapCategoryType Enumeration.^^xsd:string</para>
    ///   <a href="http://schema.org/mapType">schema:mapType</a>
    /// </summary>
    let mapType = _prefixId.prefix "mapType"
    /// <summary>
    ///   <para>rdfs:label : maps^^xsd:string</para>
    ///   <para>rdfs:comment : A URL to a map of the place.^^xsd:string</para>
    ///   <a href="http://schema.org/maps">schema:maps</a>
    /// </summary>
    let maps = _prefixId.prefix "maps"
    /// <summary>
    ///   <para>rdfs:label : material^^xsd:string</para>
    ///   <para>rdfs:comment : A material that something is made from, e.g. leather, wool, cotton, paper.^^xsd:string</para>
    ///   <a href="http://schema.org/material">schema:material</a>
    /// </summary>
    let material = _prefixId.prefix "material"
    /// <summary>
    ///   <para>rdfs:comment : The highest price if the price is a range.^^xsd:string</para>
    ///   <para>rdfs:label : maxPrice^^xsd:string</para>
    ///   <a href="http://schema.org/maxPrice">schema:maxPrice</a>
    /// </summary>
    let maxPrice = _prefixId.prefix "maxPrice"
    /// <summary>
    ///   <para>rdfs:comment : The upper value of some characteristic or property.^^xsd:string</para>
    ///   <para>rdfs:label : maxValue^^xsd:string</para>
    ///   <a href="http://schema.org/maxValue">schema:maxValue</a>
    /// </summary>
    let maxValue = _prefixId.prefix "maxValue"
    /// <summary>
    ///   <para>rdfs:label : maximumAttendeeCapacity^^xsd:string</para>
    ///   <para>rdfs:comment : The total number of individuals that may attend an event or venue.^^xsd:string</para>
    ///   <a href="http://schema.org/maximumAttendeeCapacity">schema:maximumAttendeeCapacity</a>
    /// </summary>
    let maximumAttendeeCapacity = _prefixId.prefix "maximumAttendeeCapacity"
    /// <summary>
    ///   <para>rdfs:label : mealService^^xsd:string</para>
    ///   <para>rdfs:comment : Description of the meals that will be provided or available for purchase.^^xsd:string</para>
    ///   <a href="http://schema.org/mealService">schema:mealService</a>
    /// </summary>
    let mealService = _prefixId.prefix "mealService"
    /// <summary>
    ///   <para>rdfs:comment : The median value.^^xsd:string</para>
    ///   <para>rdfs:label : median^^xsd:string</para>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <a href="http://schema.org/median">schema:median</a>
    /// </summary>
    let median = _prefixId.prefix "median"
    /// <summary>
    ///   <para>rdfs:comment : A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.^^xsd:string</para>
    ///   <para>rdfs:label : member^^xsd:string</para>
    ///   <a href="http://schema.org/member">schema:member</a>
    /// </summary>
    let member_ = _prefixId.prefix "member"
    /// <summary>
    ///   <para>rdfs:label : memberOf^^xsd:string</para>
    ///   <para>rdfs:comment : An Organization (or ProgramMembership) to which this Person or Organization belongs.^^xsd:string</para>
    ///   <a href="http://schema.org/memberOf">schema:memberOf</a>
    /// </summary>
    let memberOf = _prefixId.prefix "memberOf"
    /// <summary>
    ///   <para>rdfs:label : members^^xsd:string</para>
    ///   <para>rdfs:comment : A member of this organization.^^xsd:string</para>
    ///   <a href="http://schema.org/members">schema:members</a>
    /// </summary>
    let members = _prefixId.prefix "members"
    /// <summary>
    ///   <para>rdfs:label : membershipNumber^^xsd:string</para>
    ///   <para>rdfs:comment : A unique identifier for the membership.^^xsd:string</para>
    ///   <a href="http://schema.org/membershipNumber">schema:membershipNumber</a>
    /// </summary>
    let membershipNumber = _prefixId.prefix "membershipNumber"
    /// <summary>
    ///   <para>rdfs:comment : Minimum memory requirements.^^xsd:string</para>
    ///   <para>rdfs:label : memoryRequirements^^xsd:string</para>
    ///   <a href="http://schema.org/memoryRequirements">schema:memoryRequirements</a>
    /// </summary>
    let memoryRequirements = _prefixId.prefix "memoryRequirements"
    /// <summary>
    ///   <para>rdfs:label : mentions^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.^^xsd:string</para>
    ///   <a href="http://schema.org/mentions">schema:mentions</a>
    /// </summary>
    let mentions = _prefixId.prefix "mentions"
    /// <summary>
    ///   <para>rdfs:label : menu^^xsd:string</para>
    ///   <para>rdfs:comment : Either the actual menu as a structured representation, as text, or a URL of the menu.^^xsd:string</para>
    ///   <a href="http://schema.org/menu">schema:menu</a>
    /// </summary>
    let menu = _prefixId.prefix "menu"
    /// <summary>
    ///   <para>schema:category : issue-1541^^xsd:string</para>
    ///   <para>rdfs:label : menuAddOn^^xsd:string</para>
    ///   <para>rdfs:comment : Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.^^xsd:string</para>
    ///   <a href="http://schema.org/menuAddOn">schema:menuAddOn</a>
    /// </summary>
    let menuAddOn = _prefixId.prefix "menuAddOn"
    /// <summary>
    ///   <para>rdfs:comment : 'merchant' is an out-dated term for 'seller'.^^xsd:string</para>
    ///   <para>rdfs:label : merchant^^xsd:string</para>
    ///   <a href="http://schema.org/merchant">schema:merchant</a>
    /// </summary>
    let merchant = _prefixId.prefix "merchant"
    /// <summary>
    ///   <para>rdfs:label : messageAttachment^^xsd:string</para>
    ///   <para>rdfs:comment : A CreativeWork attached to the message.^^xsd:string</para>
    ///   <a href="http://schema.org/messageAttachment">schema:messageAttachment</a>
    /// </summary>
    let messageAttachment = _prefixId.prefix "messageAttachment"
    /// <summary>
    ///   <para>rdfs:comment : The total distance travelled by the particular vehicle since its initial production, as read from its odometer.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): KMT for kilometers, SMI for statute miles^^xsd:string</para>
    ///   <para>rdfs:label : mileageFromOdometer^^xsd:string</para>
    ///   <a href="http://schema.org/mileageFromOdometer">schema:mileageFromOdometer</a>
    /// </summary>
    let mileageFromOdometer = _prefixId.prefix "mileageFromOdometer"
    /// <summary>
    ///   <para>rdfs:label : minPrice^^xsd:string</para>
    ///   <para>rdfs:comment : The lowest price if the price is a range.^^xsd:string</para>
    ///   <a href="http://schema.org/minPrice">schema:minPrice</a>
    /// </summary>
    let minPrice = _prefixId.prefix "minPrice"
    /// <summary>
    ///   <para>rdfs:label : minValue^^xsd:string</para>
    ///   <para>rdfs:comment : The lower value of some characteristic or property.^^xsd:string</para>
    ///   <a href="http://schema.org/minValue">schema:minValue</a>
    /// </summary>
    let minValue = _prefixId.prefix "minValue"
    /// <summary>
    ///   <para>rdfs:label : minimumPaymentDue^^xsd:string</para>
    ///   <para>rdfs:comment : The minimum payment required at this time.^^xsd:string</para>
    ///   <a href="http://schema.org/minimumPaymentDue">schema:minimumPaymentDue</a>
    /// </summary>
    let minimumPaymentDue = _prefixId.prefix "minimumPaymentDue"
    /// <summary>
    ///   <para>rdfs:comment : The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.^^xsd:string</para>
    ///   <para>rdfs:label : model^^xsd:string</para>
    ///   <a href="http://schema.org/model">schema:model</a>
    /// </summary>
    let model = _prefixId.prefix "model"
    /// <summary>
    ///   <para>rdfs:comment : The date and time the reservation was modified.^^xsd:string</para>
    ///   <para>rdfs:label : modifiedTime^^xsd:string</para>
    ///   <a href="http://schema.org/modifiedTime">schema:modifiedTime</a>
    /// </summary>
    let modifiedTime = _prefixId.prefix "modifiedTime"
    /// <summary>
    ///   <para>rdfs:comment : The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.^^xsd:string</para>
    ///   <para>rdfs:label : mpn^^xsd:string</para>
    ///   <a href="http://schema.org/mpn">schema:mpn</a>
    /// </summary>
    let mpn = _prefixId.prefix "mpn"
    /// <summary>
    ///   <para>rdfs:label : multipleValues^^xsd:string</para>
    ///   <para>rdfs:comment : Whether multiple values are allowed for the property.  Default is false.^^xsd:string</para>
    ///   <a href="http://schema.org/multipleValues">schema:multipleValues</a>
    /// </summary>
    let multipleValues = _prefixId.prefix "multipleValues"
    /// <summary>
    ///   <para>rdfs:label : musicArrangement^^xsd:string</para>
    ///   <para>rdfs:comment : An arrangement derived from the composition.^^xsd:string</para>
    ///   <a href="http://schema.org/musicArrangement">schema:musicArrangement</a>
    /// </summary>
    let musicArrangement = _prefixId.prefix "musicArrangement"
    /// <summary>
    ///   <para>rdfs:comment : The composer of the soundtrack.^^xsd:string</para>
    ///   <para>rdfs:label : musicBy^^xsd:string</para>
    ///   <a href="http://schema.org/musicBy">schema:musicBy</a>
    /// </summary>
    let musicBy = _prefixId.prefix "musicBy"
    /// <summary>
    ///   <para>rdfs:label : musicCompositionForm^^xsd:string</para>
    ///   <para>rdfs:comment : The type of composition (e.g. overture, sonata, symphony, etc.).^^xsd:string</para>
    ///   <a href="http://schema.org/musicCompositionForm">schema:musicCompositionForm</a>
    /// </summary>
    let musicCompositionForm = _prefixId.prefix "musicCompositionForm"
    /// <summary>
    ///   <para>rdfs:label : musicGroupMember^^xsd:string</para>
    ///   <para>rdfs:comment : A member of a music group&amp;#x2014;for example, John, Paul, George, or Ringo.^^xsd:string</para>
    ///   <a href="http://schema.org/musicGroupMember">schema:musicGroupMember</a>
    /// </summary>
    let musicGroupMember = _prefixId.prefix "musicGroupMember"
    /// <summary>
    ///   <para>rdfs:label : musicReleaseFormat^^xsd:string</para>
    ///   <para>rdfs:comment : Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).^^xsd:string</para>
    ///   <a href="http://schema.org/musicReleaseFormat">schema:musicReleaseFormat</a>
    /// </summary>
    let musicReleaseFormat = _prefixId.prefix "musicReleaseFormat"
    /// <summary>
    ///   <para>rdfs:comment : The key, mode, or scale this composition uses.^^xsd:string</para>
    ///   <para>rdfs:label : musicalKey^^xsd:string</para>
    ///   <a href="http://schema.org/musicalKey">schema:musicalKey</a>
    /// </summary>
    let musicalKey = _prefixId.prefix "musicalKey"
    /// <summary>
    ///   <para>rdfs:comment : The North American Industry Classification System (NAICS) code for a particular organization or business person.^^xsd:string</para>
    ///   <para>rdfs:label : naics^^xsd:string</para>
    ///   <a href="http://schema.org/naics">schema:naics</a>
    /// </summary>
    let naics = _prefixId.prefix "naics"
    /// <summary>
    ///   <para>rdfs:label : name^^xsd:string</para>
    ///   <para>rdfs:comment : The name of the item.^^xsd:string</para>
    ///   <a href="http://schema.org/name">schema:name</a>
    /// </summary>
    let name = _prefixId.prefix "name"
    /// <summary>
    ///   <para>rdfs:label : namedPosition^^xsd:string</para>
    ///   <para>rdfs:comment : A position played, performed or filled by a person or organization, as part of an organization. For example, an athlete in a SportsTeam might play in the position named 'Quarterback'.^^xsd:string</para>
    ///   <a href="http://schema.org/namedPosition">schema:namedPosition</a>
    /// </summary>
    let namedPosition = _prefixId.prefix "namedPosition"
    /// <summary>
    ///   <para>rdfs:comment : Nationality of the person.^^xsd:string</para>
    ///   <para>rdfs:label : nationality^^xsd:string</para>
    ///   <a href="http://schema.org/nationality">schema:nationality</a>
    /// </summary>
    let nationality = _prefixId.prefix "nationality"
    /// <summary>
    ///   <para>rdfs:label : netWorth^^xsd:string</para>
    ///   <para>rdfs:comment : The total financial value of the person as calculated by subtracting assets from liabilities.^^xsd:string</para>
    ///   <a href="http://schema.org/netWorth">schema:netWorth</a>
    /// </summary>
    let netWorth = _prefixId.prefix "netWorth"
    /// <summary>
    ///   <para>rdfs:comment : A link to the ListItem that follows the current one.^^xsd:string</para>
    ///   <para>rdfs:label : nextItem^^xsd:string</para>
    ///   <a href="http://schema.org/nextItem">schema:nextItem</a>
    /// </summary>
    let nextItem = _prefixId.prefix "nextItem"
    /// <summary>
    ///   <para>rdfs:label : nonEqual^^xsd:string</para>
    ///   <para>rdfs:comment : This ordering relation for qualitative values indicates that the subject is not equal to the object.^^xsd:string</para>
    ///   <a href="http://schema.org/nonEqual">schema:nonEqual</a>
    /// </summary>
    let nonEqual = _prefixId.prefix "nonEqual"
    /// <summary>
    ///   <para>rdfs:comment : The number of adults staying in the unit.^^xsd:string</para>
    ///   <para>rdfs:label : numAdults^^xsd:string</para>
    ///   <a href="http://schema.org/numAdults">schema:numAdults</a>
    /// </summary>
    let numAdults = _prefixId.prefix "numAdults"
    /// <summary>
    ///   <para>rdfs:label : numChildren^^xsd:string</para>
    ///   <para>rdfs:comment : The number of children staying in the unit.^^xsd:string</para>
    ///   <a href="http://schema.org/numChildren">schema:numChildren</a>
    /// </summary>
    let numChildren = _prefixId.prefix "numChildren"
    /// <summary>
    ///   <para>rdfs:label : numTracks^^xsd:string</para>
    ///   <para>rdfs:comment : The number of tracks in this album or playlist.^^xsd:string</para>
    ///   <a href="http://schema.org/numTracks">schema:numTracks</a>
    /// </summary>
    let numTracks = _prefixId.prefix "numTracks"
    /// <summary>
    ///   <para>rdfs:label : numberOfAirbags^^xsd:string</para>
    ///   <para>rdfs:comment : The number or type of airbags in the vehicle.^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfAirbags">schema:numberOfAirbags</a>
    /// </summary>
    let numberOfAirbags = _prefixId.prefix "numberOfAirbags"
    /// <summary>
    ///   <para>rdfs:comment : The number of axles.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62^^xsd:string</para>
    ///   <para>rdfs:label : numberOfAxles^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfAxles">schema:numberOfAxles</a>
    /// </summary>
    let numberOfAxles = _prefixId.prefix "numberOfAxles"
    /// <summary>
    ///   <para>rdfs:comment : The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.^^xsd:string</para>
    ///   <para>rdfs:label : numberOfBeds^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfBeds">schema:numberOfBeds</a>
    /// </summary>
    let numberOfBeds = _prefixId.prefix "numberOfBeds"
    /// <summary>
    ///   <para>rdfs:comment : The number of doors.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62^^xsd:string</para>
    ///   <para>rdfs:label : numberOfDoors^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfDoors">schema:numberOfDoors</a>
    /// </summary>
    let numberOfDoors = _prefixId.prefix "numberOfDoors"
    /// <summary>
    ///   <para>rdfs:label : numberOfEmployees^^xsd:string</para>
    ///   <para>rdfs:comment : The number of employees in an organization e.g. business.^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfEmployees">schema:numberOfEmployees</a>
    /// </summary>
    let numberOfEmployees = _prefixId.prefix "numberOfEmployees"
    /// <summary>
    ///   <para>rdfs:comment : The number of episodes in this season or series.^^xsd:string</para>
    ///   <para>rdfs:label : numberOfEpisodes^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfEpisodes">schema:numberOfEpisodes</a>
    /// </summary>
    let numberOfEpisodes = _prefixId.prefix "numberOfEpisodes"
    /// <summary>
    ///   <para>rdfs:comment : The total number of forward gears available for the transmission system of the vehicle.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62^^xsd:string</para>
    ///   <para>rdfs:label : numberOfForwardGears^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfForwardGears">schema:numberOfForwardGears</a>
    /// </summary>
    let numberOfForwardGears = _prefixId.prefix "numberOfForwardGears"
    /// <summary>
    ///   <para>rdfs:label : numberOfItems^^xsd:string</para>
    ///   <para>rdfs:comment : The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfItems">schema:numberOfItems</a>
    /// </summary>
    let numberOfItems = _prefixId.prefix "numberOfItems"
    /// <summary>
    ///   <para>rdfs:label : numberOfPages^^xsd:string</para>
    ///   <para>rdfs:comment : The number of pages in the book.^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfPages">schema:numberOfPages</a>
    /// </summary>
    let numberOfPages = _prefixId.prefix "numberOfPages"
    /// <summary>
    ///   <para>rdfs:label : numberOfPlayers^^xsd:string</para>
    ///   <para>rdfs:comment : Indicate how many people can play this game (minimum, maximum, or range).^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfPlayers">schema:numberOfPlayers</a>
    /// </summary>
    let numberOfPlayers = _prefixId.prefix "numberOfPlayers"
    /// <summary>
    ///   <para>rdfs:comment : The number of owners of the vehicle, including the current one.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62^^xsd:string</para>
    ///   <para>rdfs:label : numberOfPreviousOwners^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfPreviousOwners">schema:numberOfPreviousOwners</a>
    /// </summary>
    let numberOfPreviousOwners = _prefixId.prefix "numberOfPreviousOwners"
    /// <summary>
    ///   <para>rdfs:label : numberOfRooms^^xsd:string</para>
    ///   <para>rdfs:comment : The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
    /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfRooms">schema:numberOfRooms</a>
    /// </summary>
    let numberOfRooms = _prefixId.prefix "numberOfRooms"
    /// <summary>
    ///   <para>rdfs:comment : The number of seasons in this series.^^xsd:string</para>
    ///   <para>rdfs:label : numberOfSeasons^^xsd:string</para>
    ///   <a href="http://schema.org/numberOfSeasons">schema:numberOfSeasons</a>
    /// </summary>
    let numberOfSeasons = _prefixId.prefix "numberOfSeasons"
    /// <summary>
    ///   <para>rdfs:label : numberedPosition^^xsd:string</para>
    ///   <para>rdfs:comment : A number associated with a role in an organization, for example, the number on an athlete's jersey.^^xsd:string</para>
    ///   <a href="http://schema.org/numberedPosition">schema:numberedPosition</a>
    /// </summary>
    let numberedPosition = _prefixId.prefix "numberedPosition"
    /// <summary>
    ///   <para>rdfs:comment : Nutrition information about the recipe or menu item.^^xsd:string</para>
    ///   <para>rdfs:label : nutrition^^xsd:string</para>
    ///   <a href="http://schema.org/nutrition">schema:nutrition</a>
    /// </summary>
    let nutrition = _prefixId.prefix "nutrition"
    /// <summary>
    ///   <para>rdfs:comment : The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read &lt;em&gt;a book&lt;/em&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : object^^xsd:string</para>
    ///   <a href="http://schema.org/object">schema:object</a>
    /// </summary>
    let object = _prefixId.prefix "object"
    /// <summary>
    ///   <para>rdfs:label : occupancy^^xsd:string</para>
    ///   <para>rdfs:comment : The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
    /// Typical unit code(s): C62 for person^^xsd:string</para>
    ///   <a href="http://schema.org/occupancy">schema:occupancy</a>
    /// </summary>
    let occupancy = _prefixId.prefix "occupancy"
    /// <summary>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:label : occupationLocation^^xsd:string</para>
    ///   <para>rdfs:comment : The region/country for which this occupational description is appropriate. Note that educational requirements and qualifications can vary between jurisdictions.^^xsd:string</para>
    ///   <a href="http://schema.org/occupationLocation">schema:occupationLocation</a>
    /// </summary>
    let occupationLocation = _prefixId.prefix "occupationLocation"
    /// <summary>
    ///   <para>rdfs:label : offerCount^^xsd:string</para>
    ///   <para>rdfs:comment : The number of offers for the product.^^xsd:string</para>
    ///   <a href="http://schema.org/offerCount">schema:offerCount</a>
    /// </summary>
    let offerCount = _prefixId.prefix "offerCount"
    /// <summary>
    ///   <para>rdfs:comment : A pointer to the organization or person making the offer.^^xsd:string</para>
    ///   <para>rdfs:label : offeredBy^^xsd:string</para>
    ///   <a href="http://schema.org/offeredBy">schema:offeredBy</a>
    /// </summary>
    let offeredBy = _prefixId.prefix "offeredBy"
    /// <summary>
    ///   <para>rdfs:comment : An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="http://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="http://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.^^xsd:string</para>
    ///   <para>schema:category : issue-2289^^xsd:string</para>
    ///   <para>rdfs:label : offers^^xsd:string</para>
    ///   <a href="http://schema.org/offers">schema:offers</a>
    /// </summary>
    let offers = _prefixId.prefix "offers"
    /// <summary>
    ///   <para>rdfs:comment : The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
    /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
    /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
    /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : openingHours^^xsd:string</para>
    ///   <a href="http://schema.org/openingHours">schema:openingHours</a>
    /// </summary>
    let openingHours = _prefixId.prefix "openingHours"
    /// <summary>
    ///   <para>rdfs:label : openingHoursSpecification^^xsd:string</para>
    ///   <para>rdfs:comment : The opening hours of a certain place.^^xsd:string</para>
    ///   <a href="http://schema.org/openingHoursSpecification">schema:openingHoursSpecification</a>
    /// </summary>
    let openingHoursSpecification = _prefixId.prefix "openingHoursSpecification"
    /// <summary>
    ///   <para>rdfs:label : opens^^xsd:string</para>
    ///   <para>rdfs:comment : The opening hour of the place or service on the given day(s) of the week.^^xsd:string</para>
    ///   <a href="http://schema.org/opens">schema:opens</a>
    /// </summary>
    let opens = _prefixId.prefix "opens"
    /// <summary>
    ///   <para>rdfs:label : operatingSystem^^xsd:string</para>
    ///   <para>rdfs:comment : Operating systems supported (Windows 7, OSX 10.6, Android 1.6).^^xsd:string</para>
    ///   <a href="http://schema.org/operatingSystem">schema:operatingSystem</a>
    /// </summary>
    let operatingSystem = _prefixId.prefix "operatingSystem"
    /// <summary>
    ///   <para>rdfs:label : opponent^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of participant. The opponent on this action.^^xsd:string</para>
    ///   <a href="http://schema.org/opponent">schema:opponent</a>
    /// </summary>
    let opponent = _prefixId.prefix "opponent"
    /// <summary>
    ///   <para>rdfs:label : option^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of object. The options subject to this action.^^xsd:string</para>
    ///   <a href="http://schema.org/option">schema:option</a>
    /// </summary>
    let option = _prefixId.prefix "option"
    /// <summary>
    ///   <para>rdfs:comment : Date order was placed.^^xsd:string</para>
    ///   <para>rdfs:label : orderDate^^xsd:string</para>
    ///   <a href="http://schema.org/orderDate">schema:orderDate</a>
    /// </summary>
    let orderDate = _prefixId.prefix "orderDate"
    /// <summary>
    ///   <para>rdfs:label : orderDelivery^^xsd:string</para>
    ///   <para>rdfs:comment : The delivery of the parcel related to this order or order item.^^xsd:string</para>
    ///   <a href="http://schema.org/orderDelivery">schema:orderDelivery</a>
    /// </summary>
    let orderDelivery = _prefixId.prefix "orderDelivery"
    /// <summary>
    ///   <para>rdfs:label : orderItemNumber^^xsd:string</para>
    ///   <para>rdfs:comment : The identifier of the order item.^^xsd:string</para>
    ///   <a href="http://schema.org/orderItemNumber">schema:orderItemNumber</a>
    /// </summary>
    let orderItemNumber = _prefixId.prefix "orderItemNumber"
    /// <summary>
    ///   <para>rdfs:label : orderItemStatus^^xsd:string</para>
    ///   <para>rdfs:comment : The current status of the order item.^^xsd:string</para>
    ///   <a href="http://schema.org/orderItemStatus">schema:orderItemStatus</a>
    /// </summary>
    let orderItemStatus = _prefixId.prefix "orderItemStatus"
    /// <summary>
    ///   <para>rdfs:comment : The identifier of the transaction.^^xsd:string</para>
    ///   <para>rdfs:label : orderNumber^^xsd:string</para>
    ///   <a href="http://schema.org/orderNumber">schema:orderNumber</a>
    /// </summary>
    let orderNumber = _prefixId.prefix "orderNumber"
    /// <summary>
    ///   <para>rdfs:label : orderQuantity^^xsd:string</para>
    ///   <para>rdfs:comment : The number of the item ordered. If the property is not set, assume the quantity is one.^^xsd:string</para>
    ///   <a href="http://schema.org/orderQuantity">schema:orderQuantity</a>
    /// </summary>
    let orderQuantity = _prefixId.prefix "orderQuantity"
    /// <summary>
    ///   <para>rdfs:comment : The current status of the order.^^xsd:string</para>
    ///   <para>rdfs:label : orderStatus^^xsd:string</para>
    ///   <a href="http://schema.org/orderStatus">schema:orderStatus</a>
    /// </summary>
    let orderStatus = _prefixId.prefix "orderStatus"
    /// <summary>
    ///   <para>rdfs:comment : The item ordered.^^xsd:string</para>
    ///   <para>rdfs:label : orderedItem^^xsd:string</para>
    ///   <a href="http://schema.org/orderedItem">schema:orderedItem</a>
    /// </summary>
    let orderedItem = _prefixId.prefix "orderedItem"
    /// <summary>
    ///   <para>rdfs:comment : An organizer of an Event.^^xsd:string</para>
    ///   <para>rdfs:label : organizer^^xsd:string</para>
    ///   <a href="http://schema.org/organizer">schema:organizer</a>
    /// </summary>
    let organizer = _prefixId.prefix "organizer"
    /// <summary>
    ///   <para>rdfs:label : originAddress^^xsd:string</para>
    ///   <para>rdfs:comment : Shipper's address.^^xsd:string</para>
    ///   <a href="http://schema.org/originAddress">schema:originAddress</a>
    /// </summary>
    let originAddress = _prefixId.prefix "originAddress"
    /// <summary>
    ///   <para>rdfs:label : ownedFrom^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time of obtaining the product.^^xsd:string</para>
    ///   <a href="http://schema.org/ownedFrom">schema:ownedFrom</a>
    /// </summary>
    let ownedFrom = _prefixId.prefix "ownedFrom"
    /// <summary>
    ///   <para>rdfs:label : ownedThrough^^xsd:string</para>
    ///   <para>rdfs:comment : The date and time of giving up ownership on the product.^^xsd:string</para>
    ///   <a href="http://schema.org/ownedThrough">schema:ownedThrough</a>
    /// </summary>
    let ownedThrough = _prefixId.prefix "ownedThrough"
    /// <summary>
    ///   <para>rdfs:comment : Products owned by the organization or person.^^xsd:string</para>
    ///   <para>rdfs:label : owns^^xsd:string</para>
    ///   <a href="http://schema.org/owns">schema:owns</a>
    /// </summary>
    let owns = _prefixId.prefix "owns"
    /// <summary>
    ///   <para>rdfs:label : pageEnd^^xsd:string</para>
    ///   <para>rdfs:comment : The page on which the work ends; for example "138" or "xvi".^^xsd:string</para>
    ///   <a href="http://schema.org/pageEnd">schema:pageEnd</a>
    /// </summary>
    let pageEnd = _prefixId.prefix "pageEnd"
    /// <summary>
    ///   <para>rdfs:comment : The page on which the work starts; for example "135" or "xiii".^^xsd:string</para>
    ///   <para>rdfs:label : pageStart^^xsd:string</para>
    ///   <a href="http://schema.org/pageStart">schema:pageStart</a>
    /// </summary>
    let pageStart = _prefixId.prefix "pageStart"
    /// <summary>
    ///   <para>rdfs:comment : Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".^^xsd:string</para>
    ///   <para>rdfs:label : pagination^^xsd:string</para>
    ///   <a href="http://schema.org/pagination">schema:pagination</a>
    /// </summary>
    let pagination = _prefixId.prefix "pagination"
    /// <summary>
    ///   <para>rdfs:comment : A parent of this person.^^xsd:string</para>
    ///   <para>rdfs:label : parent^^xsd:string</para>
    ///   <a href="http://schema.org/parent">schema:parent</a>
    /// </summary>
    let parent = _prefixId.prefix "parent"
    /// <summary>
    ///   <para>rdfs:label : parentItem^^xsd:string</para>
    ///   <para>rdfs:comment : The parent of a question, answer or item in general.^^xsd:string</para>
    ///   <a href="http://schema.org/parentItem">schema:parentItem</a>
    /// </summary>
    let parentItem = _prefixId.prefix "parentItem"
    /// <summary>
    ///   <para>rdfs:label : parentOrganization^^xsd:string</para>
    ///   <para>rdfs:comment : The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.^^xsd:string</para>
    ///   <a href="http://schema.org/parentOrganization">schema:parentOrganization</a>
    /// </summary>
    let parentOrganization = _prefixId.prefix "parentOrganization"
    /// <summary>
    ///   <para>rdfs:label : parentService^^xsd:string</para>
    ///   <para>rdfs:comment : A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.^^xsd:string</para>
    ///   <a href="http://schema.org/parentService">schema:parentService</a>
    /// </summary>
    let parentService = _prefixId.prefix "parentService"
    /// <summary>
    ///   <para>rdfs:label : parents^^xsd:string</para>
    ///   <para>rdfs:comment : A parents of the person.^^xsd:string</para>
    ///   <a href="http://schema.org/parents">schema:parents</a>
    /// </summary>
    let parents = _prefixId.prefix "parents"
    /// <summary>
    ///   <para>rdfs:comment : The episode to which this clip belongs.^^xsd:string</para>
    ///   <para>rdfs:label : partOfEpisode^^xsd:string</para>
    ///   <a href="http://schema.org/partOfEpisode">schema:partOfEpisode</a>
    /// </summary>
    let partOfEpisode = _prefixId.prefix "partOfEpisode"
    /// <summary>
    ///   <para>rdfs:comment : The order is being paid as part of the referenced Invoice.^^xsd:string</para>
    ///   <para>rdfs:label : partOfInvoice^^xsd:string</para>
    ///   <a href="http://schema.org/partOfInvoice">schema:partOfInvoice</a>
    /// </summary>
    let partOfInvoice = _prefixId.prefix "partOfInvoice"
    /// <summary>
    ///   <para>rdfs:label : partOfOrder^^xsd:string</para>
    ///   <para>rdfs:comment : The overall order the items in this delivery were included in.^^xsd:string</para>
    ///   <a href="http://schema.org/partOfOrder">schema:partOfOrder</a>
    /// </summary>
    let partOfOrder = _prefixId.prefix "partOfOrder"
    /// <summary>
    ///   <para>rdfs:comment : The season to which this episode belongs.^^xsd:string</para>
    ///   <para>rdfs:label : partOfSeason^^xsd:string</para>
    ///   <a href="http://schema.org/partOfSeason">schema:partOfSeason</a>
    /// </summary>
    let partOfSeason = _prefixId.prefix "partOfSeason"
    /// <summary>
    ///   <para>rdfs:label : partOfSeries^^xsd:string</para>
    ///   <para>rdfs:comment : The series to which this episode or season belongs.^^xsd:string</para>
    ///   <a href="http://schema.org/partOfSeries">schema:partOfSeries</a>
    /// </summary>
    let partOfSeries = _prefixId.prefix "partOfSeries"
    /// <summary>
    ///   <para>rdfs:label : partOfTVSeries^^xsd:string</para>
    ///   <para>rdfs:comment : The TV series to which this episode or season belongs.^^xsd:string</para>
    ///   <a href="http://schema.org/partOfTVSeries">schema:partOfTVSeries</a>
    /// </summary>
    let partOfTVSeries = _prefixId.prefix "partOfTVSeries"
    /// <summary>
    ///   <para>rdfs:label : participant^^xsd:string</para>
    ///   <para>rdfs:comment : Other co-agents that participated in the action indirectly. e.g. John wrote a book with &lt;em&gt;Steve&lt;/em&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/participant">schema:participant</a>
    /// </summary>
    let participant = _prefixId.prefix "participant"
    /// <summary>
    ///   <para>rdfs:comment : Number of people the reservation should accommodate.^^xsd:string</para>
    ///   <para>rdfs:label : partySize^^xsd:string</para>
    ///   <a href="http://schema.org/partySize">schema:partySize</a>
    /// </summary>
    let partySize = _prefixId.prefix "partySize"
    /// <summary>
    ///   <para>rdfs:label : passengerPriorityStatus^^xsd:string</para>
    ///   <para>rdfs:comment : The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).^^xsd:string</para>
    ///   <a href="http://schema.org/passengerPriorityStatus">schema:passengerPriorityStatus</a>
    /// </summary>
    let passengerPriorityStatus = _prefixId.prefix "passengerPriorityStatus"
    /// <summary>
    ///   <para>rdfs:comment : The passenger's sequence number as assigned by the airline.^^xsd:string</para>
    ///   <para>rdfs:label : passengerSequenceNumber^^xsd:string</para>
    ///   <a href="http://schema.org/passengerSequenceNumber">schema:passengerSequenceNumber</a>
    /// </summary>
    let passengerSequenceNumber = _prefixId.prefix "passengerSequenceNumber"
    /// <summary>
    ///   <para>rdfs:label : paymentAccepted^^xsd:string</para>
    ///   <para>rdfs:comment : Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/paymentAccepted">schema:paymentAccepted</a>
    /// </summary>
    let paymentAccepted = _prefixId.prefix "paymentAccepted"
    /// <summary>
    ///   <para>rdfs:comment : The date that payment is due.^^xsd:string</para>
    ///   <para>rdfs:label : paymentDue^^xsd:string</para>
    ///   <a href="http://schema.org/paymentDue">schema:paymentDue</a>
    /// </summary>
    let paymentDue = _prefixId.prefix "paymentDue"
    /// <summary>
    ///   <para>rdfs:label : paymentDueDate^^xsd:string</para>
    ///   <para>rdfs:comment : The date that payment is due.^^xsd:string</para>
    ///   <a href="http://schema.org/paymentDueDate">schema:paymentDueDate</a>
    /// </summary>
    let paymentDueDate = _prefixId.prefix "paymentDueDate"
    /// <summary>
    ///   <para>rdfs:comment : The name of the credit card or other method of payment for the order.^^xsd:string</para>
    ///   <para>rdfs:label : paymentMethod^^xsd:string</para>
    ///   <a href="http://schema.org/paymentMethod">schema:paymentMethod</a>
    /// </summary>
    let paymentMethod = _prefixId.prefix "paymentMethod"
    /// <summary>
    ///   <para>rdfs:label : paymentMethodId^^xsd:string</para>
    ///   <para>rdfs:comment : An identifier for the method of payment used (e.g. the last 4 digits of the credit card).^^xsd:string</para>
    ///   <a href="http://schema.org/paymentMethodId">schema:paymentMethodId</a>
    /// </summary>
    let paymentMethodId = _prefixId.prefix "paymentMethodId"
    /// <summary>
    ///   <para>rdfs:comment : The status of payment; whether the invoice has been paid or not.^^xsd:string</para>
    ///   <para>rdfs:label : paymentStatus^^xsd:string</para>
    ///   <a href="http://schema.org/paymentStatus">schema:paymentStatus</a>
    /// </summary>
    let paymentStatus = _prefixId.prefix "paymentStatus"
    /// <summary>
    ///   <para>rdfs:label : paymentUrl^^xsd:string</para>
    ///   <para>rdfs:comment : The URL for sending a payment.^^xsd:string</para>
    ///   <a href="http://schema.org/paymentUrl">schema:paymentUrl</a>
    /// </summary>
    let paymentUrl = _prefixId.prefix "paymentUrl"
    /// <summary>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:comment : The 10th percentile value.^^xsd:string</para>
    ///   <para>rdfs:label : percentile10^^xsd:string</para>
    ///   <a href="http://schema.org/percentile10">schema:percentile10</a>
    /// </summary>
    let percentile10 = _prefixId.prefix "percentile10"
    /// <summary>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:comment : The 25th percentile value.^^xsd:string</para>
    ///   <para>rdfs:label : percentile25^^xsd:string</para>
    ///   <a href="http://schema.org/percentile25">schema:percentile25</a>
    /// </summary>
    let percentile25 = _prefixId.prefix "percentile25"
    /// <summary>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:label : percentile75^^xsd:string</para>
    ///   <para>rdfs:comment : The 75th percentile value.^^xsd:string</para>
    ///   <a href="http://schema.org/percentile75">schema:percentile75</a>
    /// </summary>
    let percentile75 = _prefixId.prefix "percentile75"
    /// <summary>
    ///   <para>rdfs:label : percentile90^^xsd:string</para>
    ///   <para>rdfs:comment : The 90th percentile value.^^xsd:string</para>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <a href="http://schema.org/percentile90">schema:percentile90</a>
    /// </summary>
    let percentile90 = _prefixId.prefix "percentile90"
    /// <summary>
    ///   <para>rdfs:label : performTime^^xsd:string</para>
    ///   <para>rdfs:comment : The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/performTime">schema:performTime</a>
    /// </summary>
    let performTime = _prefixId.prefix "performTime"
    /// <summary>
    ///   <para>rdfs:comment : A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.^^xsd:string</para>
    ///   <para>rdfs:label : performer^^xsd:string</para>
    ///   <a href="http://schema.org/performer">schema:performer</a>
    /// </summary>
    let performer = _prefixId.prefix "performer"
    /// <summary>
    ///   <para>rdfs:comment : Event that this person is a performer or participant in.^^xsd:string</para>
    ///   <para>rdfs:label : performerIn^^xsd:string</para>
    ///   <a href="http://schema.org/performerIn">schema:performerIn</a>
    /// </summary>
    let performerIn = _prefixId.prefix "performerIn"
    /// <summary>
    ///   <para>rdfs:comment : The main performer or performers of the event&amp;#x2014;for example, a presenter, musician, or actor.^^xsd:string</para>
    ///   <para>rdfs:label : performers^^xsd:string</para>
    ///   <a href="http://schema.org/performers">schema:performers</a>
    /// </summary>
    let performers = _prefixId.prefix "performers"
    /// <summary>
    ///   <para>rdfs:label : permissionType^^xsd:string</para>
    ///   <para>rdfs:comment : The type of permission granted the person, organization, or audience.^^xsd:string</para>
    ///   <a href="http://schema.org/permissionType">schema:permissionType</a>
    /// </summary>
    let permissionType = _prefixId.prefix "permissionType"
    /// <summary>
    ///   <para>rdfs:comment : Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).^^xsd:string</para>
    ///   <para>rdfs:label : permissions^^xsd:string</para>
    ///   <a href="http://schema.org/permissions">schema:permissions</a>
    /// </summary>
    let permissions = _prefixId.prefix "permissions"
    /// <summary>
    ///   <para>rdfs:label : permitAudience^^xsd:string</para>
    ///   <para>rdfs:comment : The target audience for this permit.^^xsd:string</para>
    ///   <a href="http://schema.org/permitAudience">schema:permitAudience</a>
    /// </summary>
    let permitAudience = _prefixId.prefix "permitAudience"
    /// <summary>
    ///   <para>rdfs:comment : Indications regarding the permitted usage of the accommodation.^^xsd:string</para>
    ///   <para>rdfs:label : permittedUsage^^xsd:string</para>
    ///   <a href="http://schema.org/permittedUsage">schema:permittedUsage</a>
    /// </summary>
    let permittedUsage = _prefixId.prefix "permittedUsage"
    /// <summary>
    ///   <para>rdfs:label : petsAllowed^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.^^xsd:string</para>
    ///   <a href="http://schema.org/petsAllowed">schema:petsAllowed</a>
    /// </summary>
    let petsAllowed = _prefixId.prefix "petsAllowed"
    /// <summary>
    ///   <para>rdfs:label : photo^^xsd:string</para>
    ///   <para>rdfs:comment : A photograph of this place.^^xsd:string</para>
    ///   <a href="http://schema.org/photo">schema:photo</a>
    /// </summary>
    let photo = _prefixId.prefix "photo"
    /// <summary>
    ///   <para>rdfs:comment : Photographs of this place.^^xsd:string</para>
    ///   <para>rdfs:label : photos^^xsd:string</para>
    ///   <a href="http://schema.org/photos">schema:photos</a>
    /// </summary>
    let photos = _prefixId.prefix "photos"
    /// <summary>
    ///   <para>rdfs:comment : Where a taxi will pick up a passenger or a rental car can be picked up.^^xsd:string</para>
    ///   <para>rdfs:label : pickupLocation^^xsd:string</para>
    ///   <a href="http://schema.org/pickupLocation">schema:pickupLocation</a>
    /// </summary>
    let pickupLocation = _prefixId.prefix "pickupLocation"
    /// <summary>
    ///   <para>rdfs:comment : When a taxi will pickup a passenger or a rental car can be picked up.^^xsd:string</para>
    ///   <para>rdfs:label : pickupTime^^xsd:string</para>
    ///   <a href="http://schema.org/pickupTime">schema:pickupTime</a>
    /// </summary>
    let pickupTime = _prefixId.prefix "pickupTime"
    /// <summary>
    ///   <para>rdfs:label : playMode^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.^^xsd:string</para>
    ///   <a href="http://schema.org/playMode">schema:playMode</a>
    /// </summary>
    let playMode = _prefixId.prefix "playMode"
    /// <summary>
    ///   <para>rdfs:label : playerType^^xsd:string</para>
    ///   <para>rdfs:comment : Player type required&amp;#x2014;for example, Flash or Silverlight.^^xsd:string</para>
    ///   <a href="http://schema.org/playerType">schema:playerType</a>
    /// </summary>
    let playerType = _prefixId.prefix "playerType"
    /// <summary>
    ///   <para>rdfs:label : playersOnline^^xsd:string</para>
    ///   <para>rdfs:comment : Number of players on the server.^^xsd:string</para>
    ///   <a href="http://schema.org/playersOnline">schema:playersOnline</a>
    /// </summary>
    let playersOnline = _prefixId.prefix "playersOnline"
    /// <summary>
    ///   <para>rdfs:label : polygon^^xsd:string</para>
    ///   <para>rdfs:comment : A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.^^xsd:string</para>
    ///   <a href="http://schema.org/polygon">schema:polygon</a>
    /// </summary>
    let polygon = _prefixId.prefix "polygon"
    /// <summary>
    ///   <para>rdfs:comment : The position of an item in a series or sequence of items.^^xsd:string</para>
    ///   <para>rdfs:label : position^^xsd:string</para>
    ///   <a href="http://schema.org/position">schema:position</a>
    /// </summary>
    let position = _prefixId.prefix "position"
    /// <summary>
    ///   <para>rdfs:label : postOfficeBoxNumber^^xsd:string</para>
    ///   <para>rdfs:comment : The post office box number for PO box addresses.^^xsd:string</para>
    ///   <a href="http://schema.org/postOfficeBoxNumber">schema:postOfficeBoxNumber</a>
    /// </summary>
    let postOfficeBoxNumber = _prefixId.prefix "postOfficeBoxNumber"
    /// <summary>
    ///   <para>rdfs:comment : The postal code. For example, 94043.^^xsd:string</para>
    ///   <para>rdfs:label : postalCode^^xsd:string</para>
    ///   <a href="http://schema.org/postalCode">schema:postalCode</a>
    /// </summary>
    let postalCode = _prefixId.prefix "postalCode"
    /// <summary>
    ///   <para>rdfs:label : potentialAction^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.^^xsd:string</para>
    ///   <a href="http://schema.org/potentialAction">schema:potentialAction</a>
    /// </summary>
    let potentialAction = _prefixId.prefix "potentialAction"
    /// <summary>
    ///   <para>rdfs:label : predecessorOf^^xsd:string</para>
    ///   <para>rdfs:comment : A pointer from a previous, often discontinued variant of the product to its newer variant.^^xsd:string</para>
    ///   <a href="http://schema.org/predecessorOf">schema:predecessorOf</a>
    /// </summary>
    let predecessorOf = _prefixId.prefix "predecessorOf"
    /// <summary>
    ///   <para>rdfs:label : prepTime^^xsd:string</para>
    ///   <para>rdfs:comment : The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/prepTime">schema:prepTime</a>
    /// </summary>
    let prepTime = _prefixId.prefix "prepTime"
    /// <summary>
    ///   <para>rdfs:label : previousItem^^xsd:string</para>
    ///   <para>rdfs:comment : A link to the ListItem that preceeds the current one.^^xsd:string</para>
    ///   <a href="http://schema.org/previousItem">schema:previousItem</a>
    /// </summary>
    let previousItem = _prefixId.prefix "previousItem"
    /// <summary>
    ///   <para>rdfs:comment : Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.^^xsd:string</para>
    ///   <para>rdfs:label : previousStartDate^^xsd:string</para>
    ///   <a href="http://schema.org/previousStartDate">schema:previousStartDate</a>
    /// </summary>
    let previousStartDate = _prefixId.prefix "previousStartDate"
    /// <summary>
    ///   <para>rdfs:comment : The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use the &lt;a class="localLink" href="http://schema.org/priceCurrency"&gt;priceCurrency&lt;/a&gt; property (with standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR") instead of including &lt;a href="http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign"&gt;ambiguous symbols&lt;/a&gt; such as '$' in the value.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;li&gt;Note that both &lt;a href="http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute"&gt;RDFa&lt;/a&gt; and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.&lt;/li&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : price^^xsd:string</para>
    ///   <a href="http://schema.org/price">schema:price</a>
    /// </summary>
    let price = _prefixId.prefix "price"
    /// <summary>
    ///   <para>rdfs:label : priceComponent^^xsd:string</para>
    ///   <para>rdfs:comment : This property links to all &lt;a class="localLink" href="http://schema.org/UnitPriceSpecification"&gt;UnitPriceSpecification&lt;/a&gt; nodes that apply in parallel for the &lt;a class="localLink" href="http://schema.org/CompoundPriceSpecification"&gt;CompoundPriceSpecification&lt;/a&gt; node.^^xsd:string</para>
    ///   <a href="http://schema.org/priceComponent">schema:priceComponent</a>
    /// </summary>
    let priceComponent = _prefixId.prefix "priceComponent"
    /// <summary>
    ///   <para>rdfs:label : priceCurrency^^xsd:string</para>
    ///   <para>rdfs:comment : The currency of the price, or a price component when attached to &lt;a class="localLink" href="http://schema.org/PriceSpecification"&gt;PriceSpecification&lt;/a&gt; and its subtypes.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".^^xsd:string</para>
    ///   <a href="http://schema.org/priceCurrency">schema:priceCurrency</a>
    /// </summary>
    let priceCurrency = _prefixId.prefix "priceCurrency"
    /// <summary>
    ///   <para>rdfs:label : priceRange^^xsd:string</para>
    ///   <para>rdfs:comment : The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/priceRange">schema:priceRange</a>
    /// </summary>
    let priceRange = _prefixId.prefix "priceRange"
    /// <summary>
    ///   <para>rdfs:comment : One or more detailed price specifications, indicating the unit price and delivery or payment charges.^^xsd:string</para>
    ///   <para>rdfs:label : priceSpecification^^xsd:string</para>
    ///   <a href="http://schema.org/priceSpecification">schema:priceSpecification</a>
    /// </summary>
    let priceSpecification = _prefixId.prefix "priceSpecification"
    /// <summary>
    ///   <para>rdfs:label : priceType^^xsd:string</para>
    ///   <para>rdfs:comment : A short text or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.^^xsd:string</para>
    ///   <a href="http://schema.org/priceType">schema:priceType</a>
    /// </summary>
    let priceType = _prefixId.prefix "priceType"
    /// <summary>
    ///   <para>rdfs:comment : The date after which the price is no longer available.^^xsd:string</para>
    ///   <para>rdfs:label : priceValidUntil^^xsd:string</para>
    ///   <a href="http://schema.org/priceValidUntil">schema:priceValidUntil</a>
    /// </summary>
    let priceValidUntil = _prefixId.prefix "priceValidUntil"
    /// <summary>
    ///   <para>rdfs:label : primaryImageOfPage^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates the main image on the page.^^xsd:string</para>
    ///   <a href="http://schema.org/primaryImageOfPage">schema:primaryImageOfPage</a>
    /// </summary>
    let primaryImageOfPage = _prefixId.prefix "primaryImageOfPage"
    /// <summary>
    ///   <para>rdfs:label : printColumn^^xsd:string</para>
    ///   <para>rdfs:comment : The number of the column in which the NewsArticle appears in the print edition.^^xsd:string</para>
    ///   <a href="http://schema.org/printColumn">schema:printColumn</a>
    /// </summary>
    let printColumn = _prefixId.prefix "printColumn"
    /// <summary>
    ///   <para>rdfs:label : printEdition^^xsd:string</para>
    ///   <para>rdfs:comment : The edition of the print product in which the NewsArticle appears.^^xsd:string</para>
    ///   <a href="http://schema.org/printEdition">schema:printEdition</a>
    /// </summary>
    let printEdition = _prefixId.prefix "printEdition"
    /// <summary>
    ///   <para>rdfs:label : printPage^^xsd:string</para>
    ///   <para>rdfs:comment : If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).^^xsd:string</para>
    ///   <a href="http://schema.org/printPage">schema:printPage</a>
    /// </summary>
    let printPage = _prefixId.prefix "printPage"
    /// <summary>
    ///   <para>rdfs:label : printSection^^xsd:string</para>
    ///   <para>rdfs:comment : If this NewsArticle appears in print, this field indicates the print section in which the article appeared.^^xsd:string</para>
    ///   <a href="http://schema.org/printSection">schema:printSection</a>
    /// </summary>
    let printSection = _prefixId.prefix "printSection"
    /// <summary>
    ///   <para>rdfs:label : processingTime^^xsd:string</para>
    ///   <para>rdfs:comment : Estimated processing time for the service using this channel.^^xsd:string</para>
    ///   <a href="http://schema.org/processingTime">schema:processingTime</a>
    /// </summary>
    let processingTime = _prefixId.prefix "processingTime"
    /// <summary>
    ///   <para>rdfs:label : processorRequirements^^xsd:string</para>
    ///   <para>rdfs:comment : Processor architecture required to run the application (e.g. IA64).^^xsd:string</para>
    ///   <a href="http://schema.org/processorRequirements">schema:processorRequirements</a>
    /// </summary>
    let processorRequirements = _prefixId.prefix "processorRequirements"
    /// <summary>
    ///   <para>rdfs:label : producer^^xsd:string</para>
    ///   <para>rdfs:comment : The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).^^xsd:string</para>
    ///   <a href="http://schema.org/producer">schema:producer</a>
    /// </summary>
    let producer = _prefixId.prefix "producer"
    /// <summary>
    ///   <para>rdfs:comment : The tangible thing generated by the service, e.g. a passport, permit, etc.^^xsd:string</para>
    ///   <para>rdfs:label : produces^^xsd:string</para>
    ///   <a href="http://schema.org/produces">schema:produces</a>
    /// </summary>
    let produces = _prefixId.prefix "produces"
    /// <summary>
    ///   <para>rdfs:label : productID^^xsd:string</para>
    ///   <para>rdfs:comment : The product identifier, such as ISBN. For example: &lt;code&gt;meta itemprop="productID" content="isbn:123-456-789"&lt;/code&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/productID">schema:productID</a>
    /// </summary>
    let productID = _prefixId.prefix "productID"
    /// <summary>
    ///   <para>rdfs:comment : The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").^^xsd:string</para>
    ///   <para>rdfs:label : productSupported^^xsd:string</para>
    ///   <a href="http://schema.org/productSupported">schema:productSupported</a>
    /// </summary>
    let productSupported = _prefixId.prefix "productSupported"
    /// <summary>
    ///   <para>rdfs:label : productionCompany^^xsd:string</para>
    ///   <para>rdfs:comment : The production company or studio responsible for the item e.g. series, video game, episode etc.^^xsd:string</para>
    ///   <a href="http://schema.org/productionCompany">schema:productionCompany</a>
    /// </summary>
    let productionCompany = _prefixId.prefix "productionCompany"
    /// <summary>
    ///   <para>rdfs:comment : The date of production of the item, e.g. vehicle.^^xsd:string</para>
    ///   <para>rdfs:label : productionDate^^xsd:string</para>
    ///   <a href="http://schema.org/productionDate">schema:productionDate</a>
    /// </summary>
    let productionDate = _prefixId.prefix "productionDate"
    /// <summary>
    ///   <para>rdfs:comment : Proficiency needed for this content; expected values: 'Beginner', 'Expert'.^^xsd:string</para>
    ///   <para>rdfs:label : proficiencyLevel^^xsd:string</para>
    ///   <a href="http://schema.org/proficiencyLevel">schema:proficiencyLevel</a>
    /// </summary>
    let proficiencyLevel = _prefixId.prefix "proficiencyLevel"
    /// <summary>
    ///   <para>rdfs:comment : Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.^^xsd:string</para>
    ///   <para>rdfs:label : programMembershipUsed^^xsd:string</para>
    ///   <a href="http://schema.org/programMembershipUsed">schema:programMembershipUsed</a>
    /// </summary>
    let programMembershipUsed = _prefixId.prefix "programMembershipUsed"
    /// <summary>
    ///   <para>rdfs:label : programName^^xsd:string</para>
    ///   <para>rdfs:comment : The program providing the membership.^^xsd:string</para>
    ///   <a href="http://schema.org/programName">schema:programName</a>
    /// </summary>
    let programName = _prefixId.prefix "programName"
    /// <summary>
    ///   <para>rdfs:label : programmingLanguage^^xsd:string</para>
    ///   <para>rdfs:comment : The computer programming language.^^xsd:string</para>
    ///   <a href="http://schema.org/programmingLanguage">schema:programmingLanguage</a>
    /// </summary>
    let programmingLanguage = _prefixId.prefix "programmingLanguage"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether API is managed or unmanaged.^^xsd:string</para>
    ///   <para>rdfs:label : programmingModel^^xsd:string</para>
    ///   <a href="http://schema.org/programmingModel">schema:programmingModel</a>
    /// </summary>
    let programmingModel = _prefixId.prefix "programmingModel"
    /// <summary>
    ///   <para>rdfs:comment : A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
    /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific id of the property), or (3)
    /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
    /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.^^xsd:string</para>
    ///   <para>rdfs:label : propertyID^^xsd:string</para>
    ///   <a href="http://schema.org/propertyID">schema:propertyID</a>
    /// </summary>
    let propertyID = _prefixId.prefix "propertyID"
    /// <summary>
    ///   <para>rdfs:label : proteinContent^^xsd:string</para>
    ///   <para>rdfs:comment : The number of grams of protein.^^xsd:string</para>
    ///   <a href="http://schema.org/proteinContent">schema:proteinContent</a>
    /// </summary>
    let proteinContent = _prefixId.prefix "proteinContent"
    /// <summary>
    ///   <para>rdfs:comment : The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.^^xsd:string</para>
    ///   <para>rdfs:label : provider^^xsd:string</para>
    ///   <para>schema:category : issue-2289^^xsd:string</para>
    ///   <a href="http://schema.org/provider">schema:provider</a>
    /// </summary>
    let provider = _prefixId.prefix "provider"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the mobility of a provided service (e.g. 'static', 'dynamic').^^xsd:string</para>
    ///   <para>rdfs:label : providerMobility^^xsd:string</para>
    ///   <a href="http://schema.org/providerMobility">schema:providerMobility</a>
    /// </summary>
    let providerMobility = _prefixId.prefix "providerMobility"
    /// <summary>
    ///   <para>rdfs:label : providesBroadcastService^^xsd:string</para>
    ///   <para>rdfs:comment : The BroadcastService offered on this channel.^^xsd:string</para>
    ///   <a href="http://schema.org/providesBroadcastService">schema:providesBroadcastService</a>
    /// </summary>
    let providesBroadcastService = _prefixId.prefix "providesBroadcastService"
    /// <summary>
    ///   <para>rdfs:comment : The service provided by this channel.^^xsd:string</para>
    ///   <para>rdfs:label : providesService^^xsd:string</para>
    ///   <a href="http://schema.org/providesService">schema:providesService</a>
    /// </summary>
    let providesService = _prefixId.prefix "providesService"
    /// <summary>
    ///   <para>rdfs:comment : A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value^^xsd:string</para>
    ///   <para>rdfs:label : publicAccess^^xsd:string</para>
    ///   <a href="http://schema.org/publicAccess">schema:publicAccess</a>
    /// </summary>
    let publicAccess = _prefixId.prefix "publicAccess"
    /// <summary>
    ///   <para>rdfs:label : publication^^xsd:string</para>
    ///   <para>rdfs:comment : A publication event associated with the item.^^xsd:string</para>
    ///   <a href="http://schema.org/publication">schema:publication</a>
    /// </summary>
    let publication = _prefixId.prefix "publication"
    /// <summary>
    ///   <para>rdfs:comment : A broadcast service associated with the publication event.^^xsd:string</para>
    ///   <para>rdfs:label : publishedOn^^xsd:string</para>
    ///   <a href="http://schema.org/publishedOn">schema:publishedOn</a>
    /// </summary>
    let publishedOn = _prefixId.prefix "publishedOn"
    /// <summary>
    ///   <para>rdfs:comment : The publisher of the creative work.^^xsd:string</para>
    ///   <para>rdfs:label : publisher^^xsd:string</para>
    ///   <a href="http://schema.org/publisher">schema:publisher</a>
    /// </summary>
    let publisher = _prefixId.prefix "publisher"
    /// <summary>
    ///   <para>rdfs:comment : The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
    ///
    /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.^^xsd:string</para>
    ///   <para>rdfs:label : publishingPrinciples^^xsd:string</para>
    ///   <a href="http://schema.org/publishingPrinciples">schema:publishingPrinciples</a>
    /// </summary>
    let publishingPrinciples = _prefixId.prefix "publishingPrinciples"
    /// <summary>
    ///   <para>rdfs:comment : The date the item e.g. vehicle was purchased by the current owner.^^xsd:string</para>
    ///   <para>rdfs:label : purchaseDate^^xsd:string</para>
    ///   <a href="http://schema.org/purchaseDate">schema:purchaseDate</a>
    /// </summary>
    let purchaseDate = _prefixId.prefix "purchaseDate"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of instrument. The query used on this action.^^xsd:string</para>
    ///   <para>rdfs:label : query^^xsd:string</para>
    ///   <a href="http://schema.org/query">schema:query</a>
    /// </summary>
    let query = _prefixId.prefix "query"
    /// <summary>
    ///   <para>rdfs:label : quest^^xsd:string</para>
    ///   <para>rdfs:comment : The task that a player-controlled character, or group of characters may complete in order to gain a reward.^^xsd:string</para>
    ///   <a href="http://schema.org/quest">schema:quest</a>
    /// </summary>
    let quest = _prefixId.prefix "quest"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of object. A question.^^xsd:string</para>
    ///   <para>rdfs:label : question^^xsd:string</para>
    ///   <a href="http://schema.org/question">schema:question</a>
    /// </summary>
    let question = _prefixId.prefix "question"
    let rangeIncludes = _prefixId.prefix "rangeIncludes"
    /// <summary>
    ///   <para>rdfs:comment : The count of total number of ratings.^^xsd:string</para>
    ///   <para>rdfs:label : ratingCount^^xsd:string</para>
    ///   <a href="http://schema.org/ratingCount">schema:ratingCount</a>
    /// </summary>
    let ratingCount = _prefixId.prefix "ratingCount"
    /// <summary>
    ///   <para>rdfs:label : ratingValue^^xsd:string</para>
    ///   <para>rdfs:comment : The rating for the content.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/ratingValue">schema:ratingValue</a>
    /// </summary>
    let ratingValue = _prefixId.prefix "ratingValue"
    /// <summary>
    ///   <para>rdfs:label : readonlyValue^^xsd:string</para>
    ///   <para>rdfs:comment : Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.^^xsd:string</para>
    ///   <a href="http://schema.org/readonlyValue">schema:readonlyValue</a>
    /// </summary>
    let readonlyValue = _prefixId.prefix "readonlyValue"
    /// <summary>
    ///   <para>rdfs:label : realEstateAgent^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of participant. The real estate agent involved in the action.^^xsd:string</para>
    ///   <a href="http://schema.org/realEstateAgent">schema:realEstateAgent</a>
    /// </summary>
    let realEstateAgent = _prefixId.prefix "realEstateAgent"
    /// <summary>
    ///   <para>rdfs:label : recipe^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of instrument. The recipe/instructions used to perform the action.^^xsd:string</para>
    ///   <a href="http://schema.org/recipe">schema:recipe</a>
    /// </summary>
    let recipe = _prefixId.prefix "recipe"
    /// <summary>
    ///   <para>rdfs:label : recipeCategory^^xsd:string</para>
    ///   <para>rdfs:comment : The category of the recipe—for example, appetizer, entree, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/recipeCategory">schema:recipeCategory</a>
    /// </summary>
    let recipeCategory = _prefixId.prefix "recipeCategory"
    /// <summary>
    ///   <para>rdfs:comment : The cuisine of the recipe (for example, French or Ethiopian).^^xsd:string</para>
    ///   <para>rdfs:label : recipeCuisine^^xsd:string</para>
    ///   <a href="http://schema.org/recipeCuisine">schema:recipeCuisine</a>
    /// </summary>
    let recipeCuisine = _prefixId.prefix "recipeCuisine"
    /// <summary>
    ///   <para>rdfs:label : recipeIngredient^^xsd:string</para>
    ///   <para>rdfs:comment : A single ingredient used in the recipe, e.g. sugar, flour or garlic.^^xsd:string</para>
    ///   <a href="http://schema.org/recipeIngredient">schema:recipeIngredient</a>
    /// </summary>
    let recipeIngredient = _prefixId.prefix "recipeIngredient"
    /// <summary>
    ///   <para>rdfs:comment : A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.^^xsd:string</para>
    ///   <para>rdfs:label : recipeInstructions^^xsd:string</para>
    ///   <a href="http://schema.org/recipeInstructions">schema:recipeInstructions</a>
    /// </summary>
    let recipeInstructions = _prefixId.prefix "recipeInstructions"
    /// <summary>
    ///   <para>rdfs:comment : The quantity produced by the recipe (for example, number of people served, number of servings, etc).^^xsd:string</para>
    ///   <para>rdfs:label : recipeYield^^xsd:string</para>
    ///   <a href="http://schema.org/recipeYield">schema:recipeYield</a>
    /// </summary>
    let recipeYield = _prefixId.prefix "recipeYield"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of participant. The participant who is at the receiving end of the action.^^xsd:string</para>
    ///   <para>rdfs:label : recipient^^xsd:string</para>
    ///   <a href="http://schema.org/recipient">schema:recipient</a>
    /// </summary>
    let recipient = _prefixId.prefix "recipient"
    /// <summary>
    ///   <para>rdfs:comment : The label that issued the release.^^xsd:string</para>
    ///   <para>rdfs:label : recordLabel^^xsd:string</para>
    ///   <a href="http://schema.org/recordLabel">schema:recordLabel</a>
    /// </summary>
    let recordLabel = _prefixId.prefix "recordLabel"
    /// <summary>
    ///   <para>rdfs:comment : An audio recording of the work.^^xsd:string</para>
    ///   <para>rdfs:label : recordedAs^^xsd:string</para>
    ///   <a href="http://schema.org/recordedAs">schema:recordedAs</a>
    /// </summary>
    let recordedAs = _prefixId.prefix "recordedAs"
    /// <summary>
    ///   <para>rdfs:comment : The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.^^xsd:string</para>
    ///   <para>rdfs:label : recordedAt^^xsd:string</para>
    ///   <a href="http://schema.org/recordedAt">schema:recordedAt</a>
    /// </summary>
    let recordedAt = _prefixId.prefix "recordedAt"
    /// <summary>
    ///   <para>rdfs:comment : The CreativeWork that captured all or part of this Event.^^xsd:string</para>
    ///   <para>rdfs:label : recordedIn^^xsd:string</para>
    ///   <a href="http://schema.org/recordedIn">schema:recordedIn</a>
    /// </summary>
    let recordedIn = _prefixId.prefix "recordedIn"
    /// <summary>
    ///   <para>rdfs:label : recordingOf^^xsd:string</para>
    ///   <para>rdfs:comment : The composition this track is a recording of.^^xsd:string</para>
    ///   <a href="http://schema.org/recordingOf">schema:recordingOf</a>
    /// </summary>
    let recordingOf = _prefixId.prefix "recordingOf"
    /// <summary>
    ///   <para>rdfs:comment : The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.^^xsd:string</para>
    ///   <para>rdfs:label : referenceQuantity^^xsd:string</para>
    ///   <a href="http://schema.org/referenceQuantity">schema:referenceQuantity</a>
    /// </summary>
    let referenceQuantity = _prefixId.prefix "referenceQuantity"
    /// <summary>
    ///   <para>rdfs:label : referencesOrder^^xsd:string</para>
    ///   <para>rdfs:comment : The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.^^xsd:string</para>
    ///   <a href="http://schema.org/referencesOrder">schema:referencesOrder</a>
    /// </summary>
    let referencesOrder = _prefixId.prefix "referencesOrder"
    /// <summary>
    ///   <para>rdfs:comment : The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : regionsAllowed^^xsd:string</para>
    ///   <a href="http://schema.org/regionsAllowed">schema:regionsAllowed</a>
    /// </summary>
    let regionsAllowed = _prefixId.prefix "regionsAllowed"
    /// <summary>
    ///   <para>rdfs:label : relatedLink^^xsd:string</para>
    ///   <para>rdfs:comment : A link related to this web page, for example to other related web pages.^^xsd:string</para>
    ///   <a href="http://schema.org/relatedLink">schema:relatedLink</a>
    /// </summary>
    let relatedLink = _prefixId.prefix "relatedLink"
    /// <summary>
    ///   <para>rdfs:comment : The most generic familial relation.^^xsd:string</para>
    ///   <para>rdfs:label : relatedTo^^xsd:string</para>
    ///   <a href="http://schema.org/relatedTo">schema:relatedTo</a>
    /// </summary>
    let relatedTo = _prefixId.prefix "relatedTo"
    /// <summary>
    ///   <para>rdfs:label : releaseDate^^xsd:string</para>
    ///   <para>rdfs:comment : The release date of a product or product model. This can be used to distinguish the exact variant of a product.^^xsd:string</para>
    ///   <a href="http://schema.org/releaseDate">schema:releaseDate</a>
    /// </summary>
    let releaseDate = _prefixId.prefix "releaseDate"
    /// <summary>
    ///   <para>rdfs:label : releaseNotes^^xsd:string</para>
    ///   <para>rdfs:comment : Description of what changed in this version.^^xsd:string</para>
    ///   <a href="http://schema.org/releaseNotes">schema:releaseNotes</a>
    /// </summary>
    let releaseNotes = _prefixId.prefix "releaseNotes"
    /// <summary>
    ///   <para>rdfs:comment : The album this is a release of.^^xsd:string</para>
    ///   <para>rdfs:label : releaseOf^^xsd:string</para>
    ///   <a href="http://schema.org/releaseOf">schema:releaseOf</a>
    /// </summary>
    let releaseOf = _prefixId.prefix "releaseOf"
    /// <summary>
    ///   <para>rdfs:label : releasedEvent^^xsd:string</para>
    ///   <para>rdfs:comment : The place and time the release was issued, expressed as a PublicationEvent.^^xsd:string</para>
    ///   <a href="http://schema.org/releasedEvent">schema:releasedEvent</a>
    /// </summary>
    let releasedEvent = _prefixId.prefix "releasedEvent"
    /// <summary>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:comment : The Occupation for the JobPosting.^^xsd:string</para>
    ///   <para>rdfs:label : relevantOccupation^^xsd:string</para>
    ///   <a href="http://schema.org/relevantOccupation">schema:relevantOccupation</a>
    /// </summary>
    let relevantOccupation = _prefixId.prefix "relevantOccupation"
    /// <summary>
    ///   <para>rdfs:label : remainingAttendeeCapacity^^xsd:string</para>
    ///   <para>rdfs:comment : The number of attendee places for an event that remain unallocated.^^xsd:string</para>
    ///   <a href="http://schema.org/remainingAttendeeCapacity">schema:remainingAttendeeCapacity</a>
    /// </summary>
    let remainingAttendeeCapacity = _prefixId.prefix "remainingAttendeeCapacity"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of object. The object that is being replaced.^^xsd:string</para>
    ///   <para>rdfs:label : replacee^^xsd:string</para>
    ///   <a href="http://schema.org/replacee">schema:replacee</a>
    /// </summary>
    let replacee = _prefixId.prefix "replacee"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of object. The object that replaces.^^xsd:string</para>
    ///   <para>rdfs:label : replacer^^xsd:string</para>
    ///   <a href="http://schema.org/replacer">schema:replacer</a>
    /// </summary>
    let replacer = _prefixId.prefix "replacer"
    /// <summary>
    ///   <para>rdfs:comment : The URL at which a reply may be posted to the specified UserComment.^^xsd:string</para>
    ///   <para>rdfs:label : replyToUrl^^xsd:string</para>
    ///   <a href="http://schema.org/replyToUrl">schema:replyToUrl</a>
    /// </summary>
    let replyToUrl = _prefixId.prefix "replyToUrl"
    /// <summary>
    ///   <para>rdfs:comment : The number or other unique designator assigned to a Report by the publishing organization.^^xsd:string</para>
    ///   <para>rdfs:label : reportNumber^^xsd:string</para>
    ///   <a href="http://schema.org/reportNumber">schema:reportNumber</a>
    /// </summary>
    let reportNumber = _prefixId.prefix "reportNumber"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether this image is representative of the content of the page.^^xsd:string</para>
    ///   <para>rdfs:label : representativeOfPage^^xsd:string</para>
    ///   <a href="http://schema.org/representativeOfPage">schema:representativeOfPage</a>
    /// </summary>
    let representativeOfPage = _prefixId.prefix "representativeOfPage"
    /// <summary>
    ///   <para>rdfs:label : requiredCollateral^^xsd:string</para>
    ///   <para>rdfs:comment : Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)^^xsd:string</para>
    ///   <a href="http://schema.org/requiredCollateral">schema:requiredCollateral</a>
    /// </summary>
    let requiredCollateral = _prefixId.prefix "requiredCollateral"
    /// <summary>
    ///   <para>rdfs:comment : Audiences defined by a person's gender.^^xsd:string</para>
    ///   <para>rdfs:label : requiredGender^^xsd:string</para>
    ///   <a href="http://schema.org/requiredGender">schema:requiredGender</a>
    /// </summary>
    let requiredGender = _prefixId.prefix "requiredGender"
    /// <summary>
    ///   <para>rdfs:label : requiredMaxAge^^xsd:string</para>
    ///   <para>rdfs:comment : Audiences defined by a person's maximum age.^^xsd:string</para>
    ///   <a href="http://schema.org/requiredMaxAge">schema:requiredMaxAge</a>
    /// </summary>
    let requiredMaxAge = _prefixId.prefix "requiredMaxAge"
    /// <summary>
    ///   <para>rdfs:comment : Audiences defined by a person's minimum age.^^xsd:string</para>
    ///   <para>rdfs:label : requiredMinAge^^xsd:string</para>
    ///   <a href="http://schema.org/requiredMinAge">schema:requiredMinAge</a>
    /// </summary>
    let requiredMinAge = _prefixId.prefix "requiredMinAge"
    /// <summary>
    ///   <para>rdfs:label : requiredQuantity^^xsd:string</para>
    ///   <para>rdfs:comment : The required quantity of the item(s).^^xsd:string</para>
    ///   <a href="http://schema.org/requiredQuantity">schema:requiredQuantity</a>
    /// </summary>
    let requiredQuantity = _prefixId.prefix "requiredQuantity"
    /// <summary>
    ///   <para>rdfs:label : requirements^^xsd:string</para>
    ///   <para>rdfs:comment : Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).^^xsd:string</para>
    ///   <a href="http://schema.org/requirements">schema:requirements</a>
    /// </summary>
    let requirements = _prefixId.prefix "requirements"
    /// <summary>
    ///   <para>rdfs:comment : Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').^^xsd:string</para>
    ///   <para>schema:category : issue-1741^^xsd:string</para>
    ///   <para>rdfs:label : requiresSubscription^^xsd:string</para>
    ///   <a href="http://schema.org/requiresSubscription">schema:requiresSubscription</a>
    /// </summary>
    let requiresSubscription = _prefixId.prefix "requiresSubscription"
    /// <summary>
    ///   <para>rdfs:label : reservationFor^^xsd:string</para>
    ///   <para>rdfs:comment : The thing -- flight, event, restaurant,etc. being reserved.^^xsd:string</para>
    ///   <a href="http://schema.org/reservationFor">schema:reservationFor</a>
    /// </summary>
    let reservationFor = _prefixId.prefix "reservationFor"
    /// <summary>
    ///   <para>rdfs:label : reservationId^^xsd:string</para>
    ///   <para>rdfs:comment : A unique identifier for the reservation.^^xsd:string</para>
    ///   <a href="http://schema.org/reservationId">schema:reservationId</a>
    /// </summary>
    let reservationId = _prefixId.prefix "reservationId"
    /// <summary>
    ///   <para>rdfs:comment : The current status of the reservation.^^xsd:string</para>
    ///   <para>rdfs:label : reservationStatus^^xsd:string</para>
    ///   <a href="http://schema.org/reservationStatus">schema:reservationStatus</a>
    /// </summary>
    let reservationStatus = _prefixId.prefix "reservationStatus"
    /// <summary>
    ///   <para>rdfs:comment : A ticket associated with the reservation.^^xsd:string</para>
    ///   <para>rdfs:label : reservedTicket^^xsd:string</para>
    ///   <a href="http://schema.org/reservedTicket">schema:reservedTicket</a>
    /// </summary>
    let reservedTicket = _prefixId.prefix "reservedTicket"
    /// <summary>
    ///   <para>schema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:label : responsibilities^^xsd:string</para>
    ///   <para>rdfs:comment : Responsibilities associated with this role or Occupation.^^xsd:string</para>
    ///   <a href="http://schema.org/responsibilities">schema:responsibilities</a>
    /// </summary>
    let responsibilities = _prefixId.prefix "responsibilities"
    /// <summary>
    ///   <para>rdfs:label : result^^xsd:string</para>
    ///   <para>rdfs:comment : The result produced in the action. e.g. John wrote &lt;em&gt;a book&lt;/em&gt;.^^xsd:string</para>
    ///   <a href="http://schema.org/result">schema:result</a>
    /// </summary>
    let result = _prefixId.prefix "result"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of result. The Comment created or sent as a result of this action.^^xsd:string</para>
    ///   <para>rdfs:label : resultComment^^xsd:string</para>
    ///   <a href="http://schema.org/resultComment">schema:resultComment</a>
    /// </summary>
    let resultComment = _prefixId.prefix "resultComment"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of result. The review that resulted in the performing of the action.^^xsd:string</para>
    ///   <para>rdfs:label : resultReview^^xsd:string</para>
    ///   <a href="http://schema.org/resultReview">schema:resultReview</a>
    /// </summary>
    let resultReview = _prefixId.prefix "resultReview"
    /// <summary>
    ///   <para>rdfs:label : review^^xsd:string</para>
    ///   <para>rdfs:comment : A review of the item.^^xsd:string</para>
    ///   <a href="http://schema.org/review">schema:review</a>
    /// </summary>
    let review = _prefixId.prefix "review"
    /// <summary>
    ///   <para>rdfs:label : reviewAspect^^xsd:string</para>
    ///   <para>rdfs:comment : This Review or Rating is relevant to this part or facet of the itemReviewed.^^xsd:string</para>
    ///   <para>schema:category : issue-1689^^xsd:string</para>
    ///   <a href="http://schema.org/reviewAspect">schema:reviewAspect</a>
    /// </summary>
    let reviewAspect = _prefixId.prefix "reviewAspect"
    /// <summary>
    ///   <para>rdfs:comment : The actual body of the review.^^xsd:string</para>
    ///   <para>rdfs:label : reviewBody^^xsd:string</para>
    ///   <a href="http://schema.org/reviewBody">schema:reviewBody</a>
    /// </summary>
    let reviewBody = _prefixId.prefix "reviewBody"
    /// <summary>
    ///   <para>rdfs:label : reviewCount^^xsd:string</para>
    ///   <para>rdfs:comment : The count of total number of reviews.^^xsd:string</para>
    ///   <a href="http://schema.org/reviewCount">schema:reviewCount</a>
    /// </summary>
    let reviewCount = _prefixId.prefix "reviewCount"
    /// <summary>
    ///   <para>rdfs:label : reviewRating^^xsd:string</para>
    ///   <para>rdfs:comment : The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="http://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.^^xsd:string</para>
    ///   <a href="http://schema.org/reviewRating">schema:reviewRating</a>
    /// </summary>
    let reviewRating = _prefixId.prefix "reviewRating"
    /// <summary>
    ///   <para>rdfs:label : reviewedBy^^xsd:string</para>
    ///   <para>rdfs:comment : People or organizations that have reviewed the content on this web page for accuracy and/or completeness.^^xsd:string</para>
    ///   <a href="http://schema.org/reviewedBy">schema:reviewedBy</a>
    /// </summary>
    let reviewedBy = _prefixId.prefix "reviewedBy"
    /// <summary>
    ///   <para>rdfs:comment : Review of the item.^^xsd:string</para>
    ///   <para>rdfs:label : reviews^^xsd:string</para>
    ///   <a href="http://schema.org/reviews">schema:reviews</a>
    /// </summary>
    let reviews = _prefixId.prefix "reviews"
    /// <summary>
    ///   <para>rdfs:label : roleName^^xsd:string</para>
    ///   <para>rdfs:comment : A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.^^xsd:string</para>
    ///   <a href="http://schema.org/roleName">schema:roleName</a>
    /// </summary>
    let roleName = _prefixId.prefix "roleName"
    /// <summary>
    ///   <para>rdfs:comment : The response (yes, no, maybe) to the RSVP.^^xsd:string</para>
    ///   <para>rdfs:label : rsvpResponse^^xsd:string</para>
    ///   <a href="http://schema.org/rsvpResponse">schema:rsvpResponse</a>
    /// </summary>
    let rsvpResponse = _prefixId.prefix "rsvpResponse"
    /// <summary>
    ///   <para>rdfs:label : runtime^^xsd:string</para>
    ///   <para>rdfs:comment : Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).^^xsd:string</para>
    ///   <a href="http://schema.org/runtime">schema:runtime</a>
    /// </summary>
    let runtime = _prefixId.prefix "runtime"
    /// <summary>
    ///   <para>rdfs:label : runtimePlatform^^xsd:string</para>
    ///   <para>rdfs:comment : Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).^^xsd:string</para>
    ///   <a href="http://schema.org/runtimePlatform">schema:runtimePlatform</a>
    /// </summary>
    let runtimePlatform = _prefixId.prefix "runtimePlatform"
    /// <summary>
    ///   <para>rdfs:label : salaryCurrency^^xsd:string</para>
    ///   <para>rdfs:comment : The currency (coded using &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217&lt;/a&gt; ) used for the main salary information in this job posting or for this employee.^^xsd:string</para>
    ///   <a href="http://schema.org/salaryCurrency">schema:salaryCurrency</a>
    /// </summary>
    let salaryCurrency = _prefixId.prefix "salaryCurrency"
    /// <summary>
    ///   <para>rdfs:label : sameAs^^xsd:string</para>
    ///   <para>rdfs:comment : URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.^^xsd:string</para>
    ///   <a href="http://schema.org/sameAs">schema:sameAs</a>
    /// </summary>
    let sameAs = _prefixId.prefix "sameAs"
    /// <summary>
    ///   <para>rdfs:label : sampleType^^xsd:string</para>
    ///   <para>rdfs:comment : What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.^^xsd:string</para>
    ///   <a href="http://schema.org/sampleType">schema:sampleType</a>
    /// </summary>
    let sampleType = _prefixId.prefix "sampleType"
    /// <summary>
    ///   <para>rdfs:comment : The number of grams of saturated fat.^^xsd:string</para>
    ///   <para>rdfs:label : saturatedFatContent^^xsd:string</para>
    ///   <a href="http://schema.org/saturatedFatContent">schema:saturatedFatContent</a>
    /// </summary>
    let saturatedFatContent = _prefixId.prefix "saturatedFatContent"
    /// <summary>
    ///   <para>rdfs:comment : The date the invoice is scheduled to be paid.^^xsd:string</para>
    ///   <para>rdfs:label : scheduledPaymentDate^^xsd:string</para>
    ///   <a href="http://schema.org/scheduledPaymentDate">schema:scheduledPaymentDate</a>
    /// </summary>
    let scheduledPaymentDate = _prefixId.prefix "scheduledPaymentDate"
    /// <summary>
    ///   <para>rdfs:label : scheduledTime^^xsd:string</para>
    ///   <para>rdfs:comment : The time the object is scheduled to.^^xsd:string</para>
    ///   <a href="http://schema.org/scheduledTime">schema:scheduledTime</a>
    /// </summary>
    let scheduledTime = _prefixId.prefix "scheduledTime"
    /// <summary>
    ///   <para>rdfs:label : schemaVersion^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.^^xsd:string</para>
    ///   <a href="http://schema.org/schemaVersion">schema:schemaVersion</a>
    /// </summary>
    let schemaVersion = _prefixId.prefix "schemaVersion"
    /// <summary>
    ///   <para>rdfs:comment : The number of screens in the movie theater.^^xsd:string</para>
    ///   <para>rdfs:label : screenCount^^xsd:string</para>
    ///   <a href="http://schema.org/screenCount">schema:screenCount</a>
    /// </summary>
    let screenCount = _prefixId.prefix "screenCount"
    /// <summary>
    ///   <para>rdfs:comment : A link to a screenshot image of the app.^^xsd:string</para>
    ///   <para>rdfs:label : screenshot^^xsd:string</para>
    ///   <a href="http://schema.org/screenshot">schema:screenshot</a>
    /// </summary>
    let screenshot = _prefixId.prefix "screenshot"
    /// <summary>
    ///   <para>rdfs:label : season^^xsd:string</para>
    ///   <para>rdfs:comment : A season in a media series.^^xsd:string</para>
    ///   <a href="http://schema.org/season">schema:season</a>
    /// </summary>
    let season = _prefixId.prefix "season"
    /// <summary>
    ///   <para>rdfs:label : seasonNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Position of the season within an ordered group of seasons.^^xsd:string</para>
    ///   <a href="http://schema.org/seasonNumber">schema:seasonNumber</a>
    /// </summary>
    let seasonNumber = _prefixId.prefix "seasonNumber"
    /// <summary>
    ///   <para>rdfs:comment : A season in a media series.^^xsd:string</para>
    ///   <para>rdfs:label : seasons^^xsd:string</para>
    ///   <a href="http://schema.org/seasons">schema:seasons</a>
    /// </summary>
    let seasons = _prefixId.prefix "seasons"
    /// <summary>
    ///   <para>rdfs:comment : The location of the reserved seat (e.g., 27).^^xsd:string</para>
    ///   <para>rdfs:label : seatNumber^^xsd:string</para>
    ///   <a href="http://schema.org/seatNumber">schema:seatNumber</a>
    /// </summary>
    let seatNumber = _prefixId.prefix "seatNumber"
    /// <summary>
    ///   <para>rdfs:label : seatRow^^xsd:string</para>
    ///   <para>rdfs:comment : The row location of the reserved seat (e.g., B).^^xsd:string</para>
    ///   <a href="http://schema.org/seatRow">schema:seatRow</a>
    /// </summary>
    let seatRow = _prefixId.prefix "seatRow"
    /// <summary>
    ///   <para>rdfs:label : seatSection^^xsd:string</para>
    ///   <para>rdfs:comment : The section location of the reserved seat (e.g. Orchestra).^^xsd:string</para>
    ///   <a href="http://schema.org/seatSection">schema:seatSection</a>
    /// </summary>
    let seatSection = _prefixId.prefix "seatSection"
    /// <summary>
    ///   <para>rdfs:label : seatingType^^xsd:string</para>
    ///   <para>rdfs:comment : The type/class of the seat.^^xsd:string</para>
    ///   <a href="http://schema.org/seatingType">schema:seatingType</a>
    /// </summary>
    let seatingType = _prefixId.prefix "seatingType"
    /// <summary>
    ///   <para>rdfs:comment : The type of security screening the passenger is subject to.^^xsd:string</para>
    ///   <para>rdfs:label : securityScreening^^xsd:string</para>
    ///   <a href="http://schema.org/securityScreening">schema:securityScreening</a>
    /// </summary>
    let securityScreening = _prefixId.prefix "securityScreening"
    /// <summary>
    ///   <para>rdfs:label : seeks^^xsd:string</para>
    ///   <para>rdfs:comment : A pointer to products or services sought by the organization or person (demand).^^xsd:string</para>
    ///   <a href="http://schema.org/seeks">schema:seeks</a>
    /// </summary>
    let seeks = _prefixId.prefix "seeks"
    /// <summary>
    ///   <para>rdfs:comment : An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.^^xsd:string</para>
    ///   <para>rdfs:label : seller^^xsd:string</para>
    ///   <a href="http://schema.org/seller">schema:seller</a>
    /// </summary>
    let seller = _prefixId.prefix "seller"
    /// <summary>
    ///   <para>rdfs:label : sender^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of participant. The participant who is at the sending end of the action.^^xsd:string</para>
    ///   <a href="http://schema.org/sender">schema:sender</a>
    /// </summary>
    let sender = _prefixId.prefix "sender"
    /// <summary>
    ///   <para>rdfs:comment : The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.^^xsd:string</para>
    ///   <para>rdfs:label : serialNumber^^xsd:string</para>
    ///   <a href="http://schema.org/serialNumber">schema:serialNumber</a>
    /// </summary>
    let serialNumber = _prefixId.prefix "serialNumber"
    /// <summary>
    ///   <para>rdfs:label : serverStatus^^xsd:string</para>
    ///   <para>rdfs:comment : Status of a game server.^^xsd:string</para>
    ///   <a href="http://schema.org/serverStatus">schema:serverStatus</a>
    /// </summary>
    let serverStatus = _prefixId.prefix "serverStatus"
    /// <summary>
    ///   <para>rdfs:comment : The cuisine of the restaurant.^^xsd:string</para>
    ///   <para>rdfs:label : servesCuisine^^xsd:string</para>
    ///   <a href="http://schema.org/servesCuisine">schema:servesCuisine</a>
    /// </summary>
    let servesCuisine = _prefixId.prefix "servesCuisine"
    /// <summary>
    ///   <para>rdfs:label : serviceArea^^xsd:string</para>
    ///   <para>rdfs:comment : The geographic area where the service is provided.^^xsd:string</para>
    ///   <a href="http://schema.org/serviceArea">schema:serviceArea</a>
    /// </summary>
    let serviceArea = _prefixId.prefix "serviceArea"
    /// <summary>
    ///   <para>rdfs:comment : The audience eligible for this service.^^xsd:string</para>
    ///   <para>rdfs:label : serviceAudience^^xsd:string</para>
    ///   <a href="http://schema.org/serviceAudience">schema:serviceAudience</a>
    /// </summary>
    let serviceAudience = _prefixId.prefix "serviceAudience"
    /// <summary>
    ///   <para>rdfs:comment : The location (e.g. civic structure, local business, etc.) where a person can go to access the service.^^xsd:string</para>
    ///   <para>rdfs:label : serviceLocation^^xsd:string</para>
    ///   <a href="http://schema.org/serviceLocation">schema:serviceLocation</a>
    /// </summary>
    let serviceLocation = _prefixId.prefix "serviceLocation"
    /// <summary>
    ///   <para>rdfs:label : serviceOperator^^xsd:string</para>
    ///   <para>rdfs:comment : The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.^^xsd:string</para>
    ///   <a href="http://schema.org/serviceOperator">schema:serviceOperator</a>
    /// </summary>
    let serviceOperator = _prefixId.prefix "serviceOperator"
    /// <summary>
    ///   <para>rdfs:label : serviceOutput^^xsd:string</para>
    ///   <para>rdfs:comment : The tangible thing generated by the service, e.g. a passport, permit, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/serviceOutput">schema:serviceOutput</a>
    /// </summary>
    let serviceOutput = _prefixId.prefix "serviceOutput"
    /// <summary>
    ///   <para>rdfs:comment : The phone number to use to access the service.^^xsd:string</para>
    ///   <para>rdfs:label : servicePhone^^xsd:string</para>
    ///   <a href="http://schema.org/servicePhone">schema:servicePhone</a>
    /// </summary>
    let servicePhone = _prefixId.prefix "servicePhone"
    /// <summary>
    ///   <para>rdfs:comment : The address for accessing the service by mail.^^xsd:string</para>
    ///   <para>rdfs:label : servicePostalAddress^^xsd:string</para>
    ///   <a href="http://schema.org/servicePostalAddress">schema:servicePostalAddress</a>
    /// </summary>
    let servicePostalAddress = _prefixId.prefix "servicePostalAddress"
    /// <summary>
    ///   <para>rdfs:comment : The number to access the service by text message.^^xsd:string</para>
    ///   <para>rdfs:label : serviceSmsNumber^^xsd:string</para>
    ///   <a href="http://schema.org/serviceSmsNumber">schema:serviceSmsNumber</a>
    /// </summary>
    let serviceSmsNumber = _prefixId.prefix "serviceSmsNumber"
    /// <summary>
    ///   <para>rdfs:comment : The type of service being offered, e.g. veterans' benefits, emergency relief, etc.^^xsd:string</para>
    ///   <para>rdfs:label : serviceType^^xsd:string</para>
    ///   <a href="http://schema.org/serviceType">schema:serviceType</a>
    /// </summary>
    let serviceType = _prefixId.prefix "serviceType"
    /// <summary>
    ///   <para>rdfs:label : serviceUrl^^xsd:string</para>
    ///   <para>rdfs:comment : The website to access the service.^^xsd:string</para>
    ///   <a href="http://schema.org/serviceUrl">schema:serviceUrl</a>
    /// </summary>
    let serviceUrl = _prefixId.prefix "serviceUrl"
    /// <summary>
    ///   <para>rdfs:label : servingSize^^xsd:string</para>
    ///   <para>rdfs:comment : The serving size, in terms of the number of volume or mass.^^xsd:string</para>
    ///   <a href="http://schema.org/servingSize">schema:servingSize</a>
    /// </summary>
    let servingSize = _prefixId.prefix "servingSize"
    /// <summary>
    ///   <para>rdfs:label : sharedContent^^xsd:string</para>
    ///   <para>rdfs:comment : A CreativeWork such as an image, video, or audio clip shared as part of this posting.^^xsd:string</para>
    ///   <a href="http://schema.org/sharedContent">schema:sharedContent</a>
    /// </summary>
    let sharedContent = _prefixId.prefix "sharedContent"
    /// <summary>
    ///   <para>rdfs:comment : A sibling of the person.^^xsd:string</para>
    ///   <para>rdfs:label : sibling^^xsd:string</para>
    ///   <a href="http://schema.org/sibling">schema:sibling</a>
    /// </summary>
    let sibling = _prefixId.prefix "sibling"
    /// <summary>
    ///   <para>rdfs:label : siblings^^xsd:string</para>
    ///   <para>rdfs:comment : A sibling of the person.^^xsd:string</para>
    ///   <a href="http://schema.org/siblings">schema:siblings</a>
    /// </summary>
    let siblings = _prefixId.prefix "siblings"
    /// <summary>
    ///   <para>rdfs:label : significantLink^^xsd:string</para>
    ///   <para>rdfs:comment : One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.^^xsd:string</para>
    ///   <a href="http://schema.org/significantLink">schema:significantLink</a>
    /// </summary>
    let significantLink = _prefixId.prefix "significantLink"
    /// <summary>
    ///   <para>rdfs:label : significantLinks^^xsd:string</para>
    ///   <para>rdfs:comment : The most significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.^^xsd:string</para>
    ///   <a href="http://schema.org/significantLinks">schema:significantLinks</a>
    /// </summary>
    let significantLinks = _prefixId.prefix "significantLinks"
    /// <summary>
    ///   <para>rdfs:comment : A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is desired or required to fulfill this role or to work in this occupation.^^xsd:string</para>
    ///   <para>schema:category : issue-2322^^xsd:stringschema:category : issue-1698^^xsd:string</para>
    ///   <para>rdfs:label : skills^^xsd:string</para>
    ///   <a href="http://schema.org/skills">schema:skills</a>
    /// </summary>
    let skills = _prefixId.prefix "skills"
    /// <summary>
    ///   <para>rdfs:label : sku^^xsd:string</para>
    ///   <para>rdfs:comment : The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.^^xsd:string</para>
    ///   <a href="http://schema.org/sku">schema:sku</a>
    /// </summary>
    let sku = _prefixId.prefix "sku"
    /// <summary>
    ///   <para>rdfs:label : slogan^^xsd:string</para>
    ///   <para>rdfs:comment : A slogan or motto associated with the item.^^xsd:string</para>
    ///   <a href="http://schema.org/slogan">schema:slogan</a>
    /// </summary>
    let slogan = _prefixId.prefix "slogan"
    /// <summary>
    ///   <para>rdfs:comment : Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.^^xsd:string</para>
    ///   <para>rdfs:label : smokingAllowed^^xsd:string</para>
    ///   <a href="http://schema.org/smokingAllowed">schema:smokingAllowed</a>
    /// </summary>
    let smokingAllowed = _prefixId.prefix "smokingAllowed"
    /// <summary>
    ///   <para>rdfs:comment : The number of milligrams of sodium.^^xsd:string</para>
    ///   <para>rdfs:label : sodiumContent^^xsd:string</para>
    ///   <a href="http://schema.org/sodiumContent">schema:sodiumContent</a>
    /// </summary>
    let sodiumContent = _prefixId.prefix "sodiumContent"
    /// <summary>
    ///   <para>rdfs:label : softwareAddOn^^xsd:string</para>
    ///   <para>rdfs:comment : Additional content for a software application.^^xsd:string</para>
    ///   <a href="http://schema.org/softwareAddOn">schema:softwareAddOn</a>
    /// </summary>
    let softwareAddOn = _prefixId.prefix "softwareAddOn"
    /// <summary>
    ///   <para>rdfs:comment : Software application help.^^xsd:string</para>
    ///   <para>rdfs:label : softwareHelp^^xsd:string</para>
    ///   <a href="http://schema.org/softwareHelp">schema:softwareHelp</a>
    /// </summary>
    let softwareHelp = _prefixId.prefix "softwareHelp"
    /// <summary>
    ///   <para>rdfs:comment : Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).^^xsd:string</para>
    ///   <para>rdfs:label : softwareRequirements^^xsd:string</para>
    ///   <a href="http://schema.org/softwareRequirements">schema:softwareRequirements</a>
    /// </summary>
    let softwareRequirements = _prefixId.prefix "softwareRequirements"
    /// <summary>
    ///   <para>rdfs:label : softwareVersion^^xsd:string</para>
    ///   <para>rdfs:comment : Version of the software instance.^^xsd:string</para>
    ///   <a href="http://schema.org/softwareVersion">schema:softwareVersion</a>
    /// </summary>
    let softwareVersion = _prefixId.prefix "softwareVersion"
    /// <summary>
    ///   <para>rdfs:label : sourceOrganization^^xsd:string</para>
    ///   <para>rdfs:comment : The Organization on whose behalf the creator was working.^^xsd:string</para>
    ///   <a href="http://schema.org/sourceOrganization">schema:sourceOrganization</a>
    /// </summary>
    let sourceOrganization = _prefixId.prefix "sourceOrganization"
    /// <summary>
    ///   <para>rdfs:label : spatial^^xsd:string</para>
    ///   <para>rdfs:comment : The "spatial" property can be used in cases when more specific properties
    /// (e.g. &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/spatialCoverage"&gt;spatialCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;) are not known to be appropriate.^^xsd:string</para>
    ///   <a href="http://schema.org/spatial">schema:spatial</a>
    /// </summary>
    let spatial = _prefixId.prefix "spatial"
    /// <summary>
    ///   <para>rdfs:comment : The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
    ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
    ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.^^xsd:string</para>
    ///   <para>rdfs:label : spatialCoverage^^xsd:string</para>
    ///   <a href="http://schema.org/spatialCoverage">schema:spatialCoverage</a>
    /// </summary>
    let spatialCoverage = _prefixId.prefix "spatialCoverage"
    /// <summary>
    ///   <para>schema:category : issue-1389^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;br/&gt;&lt;br/&gt;
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
    /// we define a supporting type, &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.^^xsd:string</para>
    ///   <para>rdfs:label : speakable^^xsd:string</para>
    ///   <a href="http://schema.org/speakable">schema:speakable</a>
    /// </summary>
    let speakable = _prefixId.prefix "speakable"
    /// <summary>
    ///   <para>rdfs:comment : Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.^^xsd:string</para>
    ///   <para>rdfs:label : specialCommitments^^xsd:string</para>
    ///   <a href="http://schema.org/specialCommitments">schema:specialCommitments</a>
    /// </summary>
    let specialCommitments = _prefixId.prefix "specialCommitments"

    /// <summary>
    ///   <para>rdfs:comment : The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : specialOpeningHoursSpecification^^xsd:string</para>
    ///   <a href="http://schema.org/specialOpeningHoursSpecification">schema:specialOpeningHoursSpecification</a>
    /// </summary>
    let specialOpeningHoursSpecification =
        _prefixId.prefix "specialOpeningHoursSpecification"

    /// <summary>
    ///   <para>rdfs:label : specialty^^xsd:string</para>
    ///   <para>rdfs:comment : One of the domain specialities to which this web page's content applies.^^xsd:string</para>
    ///   <a href="http://schema.org/specialty">schema:specialty</a>
    /// </summary>
    let specialty = _prefixId.prefix "specialty"
    /// <summary>
    ///   <para>rdfs:label : sponsor^^xsd:string</para>
    ///   <para>rdfs:comment : A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.^^xsd:string</para>
    ///   <a href="http://schema.org/sponsor">schema:sponsor</a>
    /// </summary>
    let sponsor = _prefixId.prefix "sponsor"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of location. The sports activity location where this action occurred.^^xsd:string</para>
    ///   <para>rdfs:label : sportsActivityLocation^^xsd:string</para>
    ///   <a href="http://schema.org/sportsActivityLocation">schema:sportsActivityLocation</a>
    /// </summary>
    let sportsActivityLocation = _prefixId.prefix "sportsActivityLocation"
    /// <summary>
    ///   <para>rdfs:label : sportsEvent^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of location. The sports event where this action occurred.^^xsd:string</para>
    ///   <a href="http://schema.org/sportsEvent">schema:sportsEvent</a>
    /// </summary>
    let sportsEvent = _prefixId.prefix "sportsEvent"
    /// <summary>
    ///   <para>rdfs:label : sportsTeam^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of participant. The sports team that participated on this action.^^xsd:string</para>
    ///   <a href="http://schema.org/sportsTeam">schema:sportsTeam</a>
    /// </summary>
    let sportsTeam = _prefixId.prefix "sportsTeam"
    /// <summary>
    ///   <para>rdfs:comment : The person's spouse.^^xsd:string</para>
    ///   <para>rdfs:label : spouse^^xsd:string</para>
    ///   <a href="http://schema.org/spouse">schema:spouse</a>
    /// </summary>
    let spouse = _prefixId.prefix "spouse"
    /// <summary>
    ///   <para>rdfs:comment : An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).^^xsd:string</para>
    ///   <para>rdfs:label : starRating^^xsd:string</para>
    ///   <a href="http://schema.org/starRating">schema:starRating</a>
    /// </summary>
    let starRating = _prefixId.prefix "starRating"
    /// <summary>
    ///   <para>rdfs:comment : The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).^^xsd:string</para>
    ///   <para>rdfs:label : startDate^^xsd:string</para>
    ///   <para>schema:category : issue-2486^^xsd:string</para>
    ///   <a href="http://schema.org/startDate">schema:startDate</a>
    /// </summary>
    let startDate = _prefixId.prefix "startDate"
    /// <summary>
    ///   <para>rdfs:comment : The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.^^xsd:string</para>
    ///   <para>rdfs:label : startTime^^xsd:string</para>
    ///   <a href="http://schema.org/startTime">schema:startTime</a>
    /// </summary>
    let startTime = _prefixId.prefix "startTime"
    /// <summary>
    ///   <para>rdfs:comment : The position of the steering wheel or similar device (mostly for cars).^^xsd:string</para>
    ///   <para>rdfs:label : steeringPosition^^xsd:string</para>
    ///   <a href="http://schema.org/steeringPosition">schema:steeringPosition</a>
    /// </summary>
    let steeringPosition = _prefixId.prefix "steeringPosition"
    /// <summary>
    ///   <para>rdfs:label : step^^xsd:string</para>
    ///   <para>rdfs:comment : A single step item (as HowToStep, text, document, video, etc.) or a HowToSection.^^xsd:string</para>
    ///   <a href="http://schema.org/step">schema:step</a>
    /// </summary>
    let step = _prefixId.prefix "step"
    /// <summary>
    ///   <para>rdfs:comment : The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.^^xsd:string</para>
    ///   <para>rdfs:label : stepValue^^xsd:string</para>
    ///   <a href="http://schema.org/stepValue">schema:stepValue</a>
    /// </summary>
    let stepValue = _prefixId.prefix "stepValue"
    /// <summary>
    ///   <para>rdfs:comment : A single step item (as HowToStep, text, document, video, etc.) or a HowToSection (originally misnamed 'steps'; 'step' is preferred).^^xsd:string</para>
    ///   <para>rdfs:label : steps^^xsd:string</para>
    ///   <a href="http://schema.org/steps">schema:steps</a>
    /// </summary>
    let steps = _prefixId.prefix "steps"
    /// <summary>
    ///   <para>rdfs:label : storageRequirements^^xsd:string</para>
    ///   <para>rdfs:comment : Storage requirements (free space required).^^xsd:string</para>
    ///   <a href="http://schema.org/storageRequirements">schema:storageRequirements</a>
    /// </summary>
    let storageRequirements = _prefixId.prefix "storageRequirements"
    /// <summary>
    ///   <para>rdfs:label : streetAddress^^xsd:string</para>
    ///   <para>rdfs:comment : The street address. For example, 1600 Amphitheatre Pkwy.^^xsd:string</para>
    ///   <a href="http://schema.org/streetAddress">schema:streetAddress</a>
    /// </summary>
    let streetAddress = _prefixId.prefix "streetAddress"
    /// <summary>
    ///   <para>rdfs:comment : An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.^^xsd:string</para>
    ///   <para>rdfs:label : subEvent^^xsd:string</para>
    ///   <a href="http://schema.org/subEvent">schema:subEvent</a>
    /// </summary>
    let subEvent = _prefixId.prefix "subEvent"
    /// <summary>
    ///   <para>rdfs:label : subEvents^^xsd:string</para>
    ///   <para>rdfs:comment : Events that are a part of this event. For example, a conference event includes many presentations, each subEvents of the conference.^^xsd:string</para>
    ///   <a href="http://schema.org/subEvents">schema:subEvents</a>
    /// </summary>
    let subEvents = _prefixId.prefix "subEvents"
    /// <summary>
    ///   <para>rdfs:comment : A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.^^xsd:string</para>
    ///   <para>rdfs:label : subOrganization^^xsd:string</para>
    ///   <a href="http://schema.org/subOrganization">schema:subOrganization</a>
    /// </summary>
    let subOrganization = _prefixId.prefix "subOrganization"
    /// <summary>
    ///   <para>rdfs:label : subReservation^^xsd:string</para>
    ///   <para>rdfs:comment : The individual reservations included in the package. Typically a repeated property.^^xsd:string</para>
    ///   <a href="http://schema.org/subReservation">schema:subReservation</a>
    /// </summary>
    let subReservation = _prefixId.prefix "subReservation"
    /// <summary>
    ///   <para>rdfs:label : subjectOf^^xsd:string</para>
    ///   <para>schema:category : issue-1670^^xsd:string</para>
    ///   <para>rdfs:comment : A CreativeWork or Event about this Thing.^^xsd:string</para>
    ///   <a href="http://schema.org/subjectOf">schema:subjectOf</a>
    /// </summary>
    let subjectOf = _prefixId.prefix "subjectOf"
    /// <summary>
    ///   <para>rdfs:comment : A pointer from a newer variant of a product  to its previous, often discontinued predecessor.^^xsd:string</para>
    ///   <para>rdfs:label : successorOf^^xsd:string</para>
    ///   <a href="http://schema.org/successorOf">schema:successorOf</a>
    /// </summary>
    let successorOf = _prefixId.prefix "successorOf"
    /// <summary>
    ///   <para>rdfs:comment : The number of grams of sugar.^^xsd:string</para>
    ///   <para>rdfs:label : sugarContent^^xsd:string</para>
    ///   <a href="http://schema.org/sugarContent">schema:sugarContent</a>
    /// </summary>
    let sugarContent = _prefixId.prefix "sugarContent"
    /// <summary>
    ///   <para>rdfs:label : suggestedAnswer^^xsd:string</para>
    ///   <para>rdfs:comment : An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.^^xsd:string</para>
    ///   <a href="http://schema.org/suggestedAnswer">schema:suggestedAnswer</a>
    /// </summary>
    let suggestedAnswer = _prefixId.prefix "suggestedAnswer"
    /// <summary>
    ///   <para>rdfs:label : suggestedGender^^xsd:string</para>
    ///   <para>rdfs:comment : The gender of the person or audience.^^xsd:string</para>
    ///   <a href="http://schema.org/suggestedGender">schema:suggestedGender</a>
    /// </summary>
    let suggestedGender = _prefixId.prefix "suggestedGender"
    /// <summary>
    ///   <para>rdfs:label : suggestedMaxAge^^xsd:string</para>
    ///   <para>rdfs:comment : Maximal age recommended for viewing content.^^xsd:string</para>
    ///   <a href="http://schema.org/suggestedMaxAge">schema:suggestedMaxAge</a>
    /// </summary>
    let suggestedMaxAge = _prefixId.prefix "suggestedMaxAge"
    /// <summary>
    ///   <para>rdfs:comment : Minimal age recommended for viewing content.^^xsd:string</para>
    ///   <para>rdfs:label : suggestedMinAge^^xsd:string</para>
    ///   <a href="http://schema.org/suggestedMinAge">schema:suggestedMinAge</a>
    /// </summary>
    let suggestedMinAge = _prefixId.prefix "suggestedMinAge"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.^^xsd:string</para>
    ///   <para>rdfs:label : suitableForDiet^^xsd:string</para>
    ///   <a href="http://schema.org/suitableForDiet">schema:suitableForDiet</a>
    /// </summary>
    let suitableForDiet = _prefixId.prefix "suitableForDiet"
    /// <summary>
    ///   <para>rdfs:comment : An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.^^xsd:string</para>
    ///   <para>rdfs:label : superEvent^^xsd:string</para>
    ///   <a href="http://schema.org/superEvent">schema:superEvent</a>
    /// </summary>
    let superEvent = _prefixId.prefix "superEvent"
    let supersededBy = _prefixId.prefix "supersededBy"
    /// <summary>
    ///   <para>rdfs:label : supply^^xsd:string</para>
    ///   <para>rdfs:comment : A sub-property of instrument. A supply consumed when performing instructions or a direction.^^xsd:string</para>
    ///   <a href="http://schema.org/supply">schema:supply</a>
    /// </summary>
    let supply = _prefixId.prefix "supply"
    /// <summary>
    ///   <para>rdfs:comment : Supporting data for a SoftwareApplication.^^xsd:string</para>
    ///   <para>rdfs:label : supportingData^^xsd:string</para>
    ///   <a href="http://schema.org/supportingData">schema:supportingData</a>
    /// </summary>
    let supportingData = _prefixId.prefix "supportingData"
    /// <summary>
    ///   <para>rdfs:label : surface^^xsd:string</para>
    ///   <para>rdfs:comment : A material used as a surface in some artwork, e.g. Canvas, Paper, Wood, Board, etc.^^xsd:string</para>
    ///   <a href="http://schema.org/surface">schema:surface</a>
    /// </summary>
    let surface = _prefixId.prefix "surface"
    /// <summary>
    ///   <para>rdfs:label : target^^xsd:string</para>
    ///   <para>rdfs:comment : Indicates a target EntryPoint for an Action.^^xsd:string</para>
    ///   <a href="http://schema.org/target">schema:target</a>
    /// </summary>
    let target = _prefixId.prefix "target"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of object. The collection target of the action.^^xsd:string</para>
    ///   <para>rdfs:label : targetCollection^^xsd:string</para>
    ///   <a href="http://schema.org/targetCollection">schema:targetCollection</a>
    /// </summary>
    let targetCollection = _prefixId.prefix "targetCollection"
    /// <summary>
    ///   <para>rdfs:label : targetDescription^^xsd:string</para>
    ///   <para>rdfs:comment : The description of a node in an established educational framework.^^xsd:string</para>
    ///   <a href="http://schema.org/targetDescription">schema:targetDescription</a>
    /// </summary>
    let targetDescription = _prefixId.prefix "targetDescription"
    /// <summary>
    ///   <para>rdfs:comment : The name of a node in an established educational framework.^^xsd:string</para>
    ///   <para>rdfs:label : targetName^^xsd:string</para>
    ///   <a href="http://schema.org/targetName">schema:targetName</a>
    /// </summary>
    let targetName = _prefixId.prefix "targetName"
    /// <summary>
    ///   <para>rdfs:comment : Type of app development: phone, Metro style, desktop, XBox, etc.^^xsd:string</para>
    ///   <para>rdfs:label : targetPlatform^^xsd:string</para>
    ///   <a href="http://schema.org/targetPlatform">schema:targetPlatform</a>
    /// </summary>
    let targetPlatform = _prefixId.prefix "targetPlatform"
    /// <summary>
    ///   <para>rdfs:comment : Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.^^xsd:string</para>
    ///   <para>rdfs:label : targetProduct^^xsd:string</para>
    ///   <a href="http://schema.org/targetProduct">schema:targetProduct</a>
    /// </summary>
    let targetProduct = _prefixId.prefix "targetProduct"
    /// <summary>
    ///   <para>rdfs:comment : The URL of a node in an established educational framework.^^xsd:string</para>
    ///   <para>rdfs:label : targetUrl^^xsd:string</para>
    ///   <a href="http://schema.org/targetUrl">schema:targetUrl</a>
    /// </summary>
    let targetUrl = _prefixId.prefix "targetUrl"
    /// <summary>
    ///   <para>rdfs:comment : The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.^^xsd:string</para>
    ///   <para>rdfs:label : taxID^^xsd:string</para>
    ///   <a href="http://schema.org/taxID">schema:taxID</a>
    /// </summary>
    let taxID = _prefixId.prefix "taxID"
    /// <summary>
    ///   <para>rdfs:comment : The telephone number.^^xsd:string</para>
    ///   <para>rdfs:label : telephone^^xsd:string</para>
    ///   <a href="http://schema.org/telephone">schema:telephone</a>
    /// </summary>
    let telephone = _prefixId.prefix "telephone"
    /// <summary>
    ///   <para>rdfs:label : temporal^^xsd:string</para>
    ///   <para>rdfs:comment : The "temporal" property can be used in cases where more specific properties
    /// (e.g. &lt;a class="localLink" href="http://schema.org/temporalCoverage"&gt;temporalCoverage&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateCreated"&gt;dateCreated&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/dateModified"&gt;dateModified&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/datePublished"&gt;datePublished&lt;/a&gt;) are not known to be appropriate.^^xsd:string</para>
    ///   <a href="http://schema.org/temporal">schema:temporal</a>
    /// </summary>
    let temporal = _prefixId.prefix "temporal"
    /// <summary>
    ///   <para>rdfs:comment : The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
    ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
    ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".&lt;br/&gt;&lt;br/&gt;
    ///
    /// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated.^^xsd:string</para>
    ///   <para>rdfs:label : temporalCoverage^^xsd:string</para>
    ///   <a href="http://schema.org/temporalCoverage">schema:temporalCoverage</a>
    /// </summary>
    let temporalCoverage = _prefixId.prefix "temporalCoverage"
    /// <summary>
    ///   <para>rdfs:label : text^^xsd:string</para>
    ///   <para>rdfs:comment : The textual content of this CreativeWork.^^xsd:string</para>
    ///   <a href="http://schema.org/text">schema:text</a>
    /// </summary>
    let text = _prefixId.prefix "text"
    /// <summary>
    ///   <para>rdfs:label : thumbnail^^xsd:string</para>
    ///   <para>rdfs:comment : Thumbnail image for an image or video.^^xsd:string</para>
    ///   <a href="http://schema.org/thumbnail">schema:thumbnail</a>
    /// </summary>
    let thumbnail = _prefixId.prefix "thumbnail"
    /// <summary>
    ///   <para>rdfs:label : thumbnailUrl^^xsd:string</para>
    ///   <para>rdfs:comment : A thumbnail image relevant to the Thing.^^xsd:string</para>
    ///   <a href="http://schema.org/thumbnailUrl">schema:thumbnailUrl</a>
    /// </summary>
    let thumbnailUrl = _prefixId.prefix "thumbnailUrl"
    /// <summary>
    ///   <para>rdfs:comment : The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we recommend using the controlled vocabulary of Market Identifier Codes (MIC) specified in ISO15022.^^xsd:string</para>
    ///   <para>rdfs:label : tickerSymbol^^xsd:string</para>
    ///   <a href="http://schema.org/tickerSymbol">schema:tickerSymbol</a>
    /// </summary>
    let tickerSymbol = _prefixId.prefix "tickerSymbol"
    /// <summary>
    ///   <para>rdfs:comment : The unique identifier for the ticket.^^xsd:string</para>
    ///   <para>rdfs:label : ticketNumber^^xsd:string</para>
    ///   <a href="http://schema.org/ticketNumber">schema:ticketNumber</a>
    /// </summary>
    let ticketNumber = _prefixId.prefix "ticketNumber"
    /// <summary>
    ///   <para>rdfs:label : ticketToken^^xsd:string</para>
    ///   <para>rdfs:comment : Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.^^xsd:string</para>
    ///   <a href="http://schema.org/ticketToken">schema:ticketToken</a>
    /// </summary>
    let ticketToken = _prefixId.prefix "ticketToken"
    /// <summary>
    ///   <para>rdfs:comment : The seat associated with the ticket.^^xsd:string</para>
    ///   <para>rdfs:label : ticketedSeat^^xsd:string</para>
    ///   <a href="http://schema.org/ticketedSeat">schema:ticketedSeat</a>
    /// </summary>
    let ticketedSeat = _prefixId.prefix "ticketedSeat"
    /// <summary>
    ///   <para>rdfs:label : timeRequired^^xsd:string</para>
    ///   <para>rdfs:comment : Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'PT30M', 'PT1H25M'.^^xsd:string</para>
    ///   <a href="http://schema.org/timeRequired">schema:timeRequired</a>
    /// </summary>
    let timeRequired = _prefixId.prefix "timeRequired"
    /// <summary>
    ///   <para>rdfs:comment : The title of the job.^^xsd:string</para>
    ///   <para>rdfs:label : title^^xsd:string</para>
    ///   <a href="http://schema.org/title">schema:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of location. The final location of the object or the agent after the action.^^xsd:string</para>
    ///   <para>rdfs:label : toLocation^^xsd:string</para>
    ///   <a href="http://schema.org/toLocation">schema:toLocation</a>
    /// </summary>
    let toLocation = _prefixId.prefix "toLocation"
    /// <summary>
    ///   <para>rdfs:comment : A sub property of recipient. The recipient who was directly sent the message.^^xsd:string</para>
    ///   <para>rdfs:label : toRecipient^^xsd:string</para>
    ///   <a href="http://schema.org/toRecipient">schema:toRecipient</a>
    /// </summary>
    let toRecipient = _prefixId.prefix "toRecipient"
    /// <summary>
    ///   <para>rdfs:label : tool^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.^^xsd:string</para>
    ///   <a href="http://schema.org/tool">schema:tool</a>
    /// </summary>
    let tool = _prefixId.prefix "tool"
    /// <summary>
    ///   <para>rdfs:comment : The total amount due.^^xsd:string</para>
    ///   <para>rdfs:label : totalPaymentDue^^xsd:string</para>
    ///   <a href="http://schema.org/totalPaymentDue">schema:totalPaymentDue</a>
    /// </summary>
    let totalPaymentDue = _prefixId.prefix "totalPaymentDue"
    /// <summary>
    ///   <para>rdfs:comment : The total price for the reservation or ticket, including applicable taxes, shipping, etc.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Usage guidelines:&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <para>rdfs:label : totalPrice^^xsd:string</para>
    ///   <a href="http://schema.org/totalPrice">schema:totalPrice</a>
    /// </summary>
    let totalPrice = _prefixId.prefix "totalPrice"
    /// <summary>
    ///   <para>rdfs:comment : The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : totalTime^^xsd:string</para>
    ///   <a href="http://schema.org/totalTime">schema:totalTime</a>
    /// </summary>
    let totalTime = _prefixId.prefix "totalTime"
    /// <summary>
    ///   <para>rdfs:comment : Attraction suitable for type(s) of tourist. eg. Children, visitors from a particular country, etc.^^xsd:string</para>
    ///   <para>rdfs:label : touristType^^xsd:string</para>
    ///   <para>schema:category : issue-1810^^xsd:string</para>
    ///   <a href="http://schema.org/touristType">schema:touristType</a>
    /// </summary>
    let touristType = _prefixId.prefix "touristType"
    /// <summary>
    ///   <para>rdfs:comment : A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.^^xsd:string</para>
    ///   <para>rdfs:label : track^^xsd:string</para>
    ///   <a href="http://schema.org/track">schema:track</a>
    /// </summary>
    let track = _prefixId.prefix "track"
    /// <summary>
    ///   <para>rdfs:comment : Shipper tracking number.^^xsd:string</para>
    ///   <para>rdfs:label : trackingNumber^^xsd:string</para>
    ///   <a href="http://schema.org/trackingNumber">schema:trackingNumber</a>
    /// </summary>
    let trackingNumber = _prefixId.prefix "trackingNumber"
    /// <summary>
    ///   <para>rdfs:label : trackingUrl^^xsd:string</para>
    ///   <para>rdfs:comment : Tracking url for the parcel delivery.^^xsd:string</para>
    ///   <a href="http://schema.org/trackingUrl">schema:trackingUrl</a>
    /// </summary>
    let trackingUrl = _prefixId.prefix "trackingUrl"
    /// <summary>
    ///   <para>rdfs:label : tracks^^xsd:string</para>
    ///   <para>rdfs:comment : A music recording (track)&amp;#x2014;usually a single song.^^xsd:string</para>
    ///   <a href="http://schema.org/tracks">schema:tracks</a>
    /// </summary>
    let tracks = _prefixId.prefix "tracks"
    /// <summary>
    ///   <para>rdfs:comment : The trailer of a movie or tv/radio series, season, episode, etc.^^xsd:string</para>
    ///   <para>rdfs:label : trailer^^xsd:string</para>
    ///   <a href="http://schema.org/trailer">schema:trailer</a>
    /// </summary>
    let trailer = _prefixId.prefix "trailer"
    /// <summary>
    ///   <para>rdfs:comment : The name of the train (e.g. The Orient Express).^^xsd:string</para>
    ///   <para>rdfs:label : trainName^^xsd:string</para>
    ///   <a href="http://schema.org/trainName">schema:trainName</a>
    /// </summary>
    let trainName = _prefixId.prefix "trainName"
    /// <summary>
    ///   <para>rdfs:label : trainNumber^^xsd:string</para>
    ///   <para>rdfs:comment : The unique identifier for the train.^^xsd:string</para>
    ///   <a href="http://schema.org/trainNumber">schema:trainNumber</a>
    /// </summary>
    let trainNumber = _prefixId.prefix "trainNumber"
    /// <summary>
    ///   <para>rdfs:comment : The number of grams of trans fat.^^xsd:string</para>
    ///   <para>rdfs:label : transFatContent^^xsd:string</para>
    ///   <a href="http://schema.org/transFatContent">schema:transFatContent</a>
    /// </summary>
    let transFatContent = _prefixId.prefix "transFatContent"
    /// <summary>
    ///   <para>rdfs:label : transcript^^xsd:string</para>
    ///   <para>rdfs:comment : If this MediaObject is an AudioObject or VideoObject, the transcript of that object.^^xsd:string</para>
    ///   <a href="http://schema.org/transcript">schema:transcript</a>
    /// </summary>
    let transcript = _prefixId.prefix "transcript"
    /// <summary>
    ///   <para>rdfs:label : translator^^xsd:string</para>
    ///   <para>rdfs:comment : Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.^^xsd:string</para>
    ///   <a href="http://schema.org/translator">schema:translator</a>
    /// </summary>
    let translator = _prefixId.prefix "translator"
    /// <summary>
    ///   <para>rdfs:label : typeOfBed^^xsd:string</para>
    ///   <para>rdfs:comment : The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.^^xsd:string</para>
    ///   <a href="http://schema.org/typeOfBed">schema:typeOfBed</a>
    /// </summary>
    let typeOfBed = _prefixId.prefix "typeOfBed"
    /// <summary>
    ///   <para>rdfs:label : typeOfGood^^xsd:string</para>
    ///   <para>rdfs:comment : The product that this structured value is referring to.^^xsd:string</para>
    ///   <a href="http://schema.org/typeOfGood">schema:typeOfGood</a>
    /// </summary>
    let typeOfGood = _prefixId.prefix "typeOfGood"
    /// <summary>
    ///   <para>rdfs:comment : The typical expected age range, e.g. '7-9', '11-'.^^xsd:string</para>
    ///   <para>rdfs:label : typicalAgeRange^^xsd:string</para>
    ///   <a href="http://schema.org/typicalAgeRange">schema:typicalAgeRange</a>
    /// </summary>
    let typicalAgeRange = _prefixId.prefix "typicalAgeRange"
    /// <summary>
    ///   <para>rdfs:label : underName^^xsd:string</para>
    ///   <para>rdfs:comment : The person or organization the reservation or ticket is for.^^xsd:string</para>
    ///   <a href="http://schema.org/underName">schema:underName</a>
    /// </summary>
    let underName = _prefixId.prefix "underName"
    /// <summary>
    ///   <para>rdfs:label : unitCode^^xsd:string</para>
    ///   <para>rdfs:comment : The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.^^xsd:string</para>
    ///   <a href="http://schema.org/unitCode">schema:unitCode</a>
    /// </summary>
    let unitCode = _prefixId.prefix "unitCode"
    /// <summary>
    ///   <para>rdfs:comment : A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
    /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.^^xsd:string</para>
    ///   <para>rdfs:label : unitText^^xsd:string</para>
    ///   <a href="http://schema.org/unitText">schema:unitText</a>
    /// </summary>
    let unitText = _prefixId.prefix "unitText"
    /// <summary>
    ///   <para>rdfs:comment : The number of grams of unsaturated fat.^^xsd:string</para>
    ///   <para>rdfs:label : unsaturatedFatContent^^xsd:string</para>
    ///   <a href="http://schema.org/unsaturatedFatContent">schema:unsaturatedFatContent</a>
    /// </summary>
    let unsaturatedFatContent = _prefixId.prefix "unsaturatedFatContent"
    /// <summary>
    ///   <para>rdfs:label : uploadDate^^xsd:string</para>
    ///   <para>rdfs:comment : Date when this media object was uploaded to this site.^^xsd:string</para>
    ///   <a href="http://schema.org/uploadDate">schema:uploadDate</a>
    /// </summary>
    let uploadDate = _prefixId.prefix "uploadDate"
    /// <summary>
    ///   <para>rdfs:label : upvoteCount^^xsd:string</para>
    ///   <para>rdfs:comment : The number of upvotes this question, answer or comment has received from the community.^^xsd:string</para>
    ///   <a href="http://schema.org/upvoteCount">schema:upvoteCount</a>
    /// </summary>
    let upvoteCount = _prefixId.prefix "upvoteCount"
    /// <summary>
    ///   <para>rdfs:label : url^^xsd:string</para>
    ///   <para>rdfs:comment : URL of the item.^^xsd:string</para>
    ///   <a href="http://schema.org/url">schema:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:comment : An url template (RFC6570) that will be used to construct the target of the execution of the action.^^xsd:string</para>
    ///   <para>rdfs:label : urlTemplate^^xsd:string</para>
    ///   <a href="http://schema.org/urlTemplate">schema:urlTemplate</a>
    /// </summary>
    let urlTemplate = _prefixId.prefix "urlTemplate"
    /// <summary>
    ///   <para>rdfs:label : userInteractionCount^^xsd:string</para>
    ///   <para>rdfs:comment : The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.^^xsd:string</para>
    ///   <a href="http://schema.org/userInteractionCount">schema:userInteractionCount</a>
    /// </summary>
    let userInteractionCount = _prefixId.prefix "userInteractionCount"
    /// <summary>
    ///   <para>rdfs:comment : The duration of validity of a permit or similar thing.^^xsd:string</para>
    ///   <para>rdfs:label : validFor^^xsd:string</para>
    ///   <para>schema:category : issue-1779^^xsd:string</para>
    ///   <a href="http://schema.org/validFor">schema:validFor</a>
    /// </summary>
    let validFor = _prefixId.prefix "validFor"
    /// <summary>
    ///   <para>rdfs:comment : The date when the item becomes valid.^^xsd:string</para>
    ///   <para>rdfs:label : validFrom^^xsd:string</para>
    ///   <a href="http://schema.org/validFrom">schema:validFrom</a>
    /// </summary>
    let validFrom = _prefixId.prefix "validFrom"
    /// <summary>
    ///   <para>schema:category : issue-1779^^xsd:string</para>
    ///   <para>rdfs:comment : The geographic area where a permit or similar thing is valid.^^xsd:string</para>
    ///   <para>rdfs:label : validIn^^xsd:string</para>
    ///   <a href="http://schema.org/validIn">schema:validIn</a>
    /// </summary>
    let validIn = _prefixId.prefix "validIn"
    /// <summary>
    ///   <para>rdfs:comment : The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.^^xsd:string</para>
    ///   <para>rdfs:label : validThrough^^xsd:string</para>
    ///   <a href="http://schema.org/validThrough">schema:validThrough</a>
    /// </summary>
    let validThrough = _prefixId.prefix "validThrough"
    /// <summary>
    ///   <para>rdfs:label : validUntil^^xsd:string</para>
    ///   <para>rdfs:comment : The date when the item is no longer valid.^^xsd:string</para>
    ///   <a href="http://schema.org/validUntil">schema:validUntil</a>
    /// </summary>
    let validUntil = _prefixId.prefix "validUntil"
    /// <summary>
    ///   <para>rdfs:label : value^^xsd:string</para>
    ///   <para>rdfs:comment : The value of the quantitative value or property value node.&lt;br/&gt;&lt;br/&gt;
    ///
    /// &lt;ul&gt;
    /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/MonetaryAmount"&gt;MonetaryAmount&lt;/a&gt;, the recommended type for values is 'Number'.&lt;/li&gt;
    /// &lt;li&gt;For &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt;, it can be 'Text;', 'Number', 'Boolean', or 'StructuredValue'.&lt;/li&gt;
    /// &lt;li&gt;Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similiar Unicode symbols.&lt;/li&gt;
    /// &lt;li&gt;Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// ^^xsd:string</para>
    ///   <a href="http://schema.org/value">schema:value</a>
    /// </summary>
    let value = _prefixId.prefix "value"
    /// <summary>
    ///   <para>rdfs:label : valueAddedTaxIncluded^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.^^xsd:string</para>
    ///   <a href="http://schema.org/valueAddedTaxIncluded">schema:valueAddedTaxIncluded</a>
    /// </summary>
    let valueAddedTaxIncluded = _prefixId.prefix "valueAddedTaxIncluded"
    /// <summary>
    ///   <para>rdfs:label : valueMaxLength^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies the allowed range for number of characters in a literal value.^^xsd:string</para>
    ///   <a href="http://schema.org/valueMaxLength">schema:valueMaxLength</a>
    /// </summary>
    let valueMaxLength = _prefixId.prefix "valueMaxLength"
    /// <summary>
    ///   <para>rdfs:comment : Specifies the minimum allowed range for number of characters in a literal value.^^xsd:string</para>
    ///   <para>rdfs:label : valueMinLength^^xsd:string</para>
    ///   <a href="http://schema.org/valueMinLength">schema:valueMinLength</a>
    /// </summary>
    let valueMinLength = _prefixId.prefix "valueMinLength"
    /// <summary>
    ///   <para>rdfs:comment : Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.^^xsd:string</para>
    ///   <para>rdfs:label : valueName^^xsd:string</para>
    ///   <a href="http://schema.org/valueName">schema:valueName</a>
    /// </summary>
    let valueName = _prefixId.prefix "valueName"
    /// <summary>
    ///   <para>rdfs:label : valuePattern^^xsd:string</para>
    ///   <para>rdfs:comment : Specifies a regular expression for testing literal values according to the HTML spec.^^xsd:string</para>
    ///   <a href="http://schema.org/valuePattern">schema:valuePattern</a>
    /// </summary>
    let valuePattern = _prefixId.prefix "valuePattern"
    /// <summary>
    ///   <para>rdfs:label : valueReference^^xsd:string</para>
    ///   <para>rdfs:comment : A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.^^xsd:string</para>
    ///   <a href="http://schema.org/valueReference">schema:valueReference</a>
    /// </summary>
    let valueReference = _prefixId.prefix "valueReference"
    /// <summary>
    ///   <para>rdfs:comment : Whether the property must be filled in to complete the action.  Default is false.^^xsd:string</para>
    ///   <para>rdfs:label : valueRequired^^xsd:string</para>
    ///   <a href="http://schema.org/valueRequired">schema:valueRequired</a>
    /// </summary>
    let valueRequired = _prefixId.prefix "valueRequired"
    /// <summary>
    ///   <para>rdfs:comment : The Value-added Tax ID of the organization or person.^^xsd:string</para>
    ///   <para>rdfs:label : vatID^^xsd:string</para>
    ///   <a href="http://schema.org/vatID">schema:vatID</a>
    /// </summary>
    let vatID = _prefixId.prefix "vatID"
    /// <summary>
    ///   <para>rdfs:label : vehicleConfiguration^^xsd:string</para>
    ///   <para>rdfs:comment : A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.^^xsd:string</para>
    ///   <a href="http://schema.org/vehicleConfiguration">schema:vehicleConfiguration</a>
    /// </summary>
    let vehicleConfiguration = _prefixId.prefix "vehicleConfiguration"
    /// <summary>
    ///   <para>rdfs:comment : Information about the engine or engines of the vehicle.^^xsd:string</para>
    ///   <para>rdfs:label : vehicleEngine^^xsd:string</para>
    ///   <a href="http://schema.org/vehicleEngine">schema:vehicleEngine</a>
    /// </summary>
    let vehicleEngine = _prefixId.prefix "vehicleEngine"
    /// <summary>
    ///   <para>rdfs:label : vehicleIdentificationNumber^^xsd:string</para>
    ///   <para>rdfs:comment : The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.^^xsd:string</para>
    ///   <a href="http://schema.org/vehicleIdentificationNumber">schema:vehicleIdentificationNumber</a>
    /// </summary>
    let vehicleIdentificationNumber = _prefixId.prefix "vehicleIdentificationNumber"
    /// <summary>
    ///   <para>rdfs:comment : The color or color combination of the interior of the vehicle.^^xsd:string</para>
    ///   <para>rdfs:label : vehicleInteriorColor^^xsd:string</para>
    ///   <a href="http://schema.org/vehicleInteriorColor">schema:vehicleInteriorColor</a>
    /// </summary>
    let vehicleInteriorColor = _prefixId.prefix "vehicleInteriorColor"
    /// <summary>
    ///   <para>rdfs:comment : The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.^^xsd:string</para>
    ///   <para>rdfs:label : vehicleInteriorType^^xsd:string</para>
    ///   <a href="http://schema.org/vehicleInteriorType">schema:vehicleInteriorType</a>
    /// </summary>
    let vehicleInteriorType = _prefixId.prefix "vehicleInteriorType"
    /// <summary>
    ///   <para>rdfs:label : vehicleModelDate^^xsd:string</para>
    ///   <para>rdfs:comment : The release date of a vehicle model (often used to differentiate versions of the same make and model).^^xsd:string</para>
    ///   <a href="http://schema.org/vehicleModelDate">schema:vehicleModelDate</a>
    /// </summary>
    let vehicleModelDate = _prefixId.prefix "vehicleModelDate"
    /// <summary>
    ///   <para>rdfs:label : vehicleSeatingCapacity^^xsd:string</para>
    ///   <para>rdfs:comment : The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.&lt;br/&gt;&lt;br/&gt;
    ///
    /// Typical unit code(s): C62 for persons.^^xsd:string</para>
    ///   <a href="http://schema.org/vehicleSeatingCapacity">schema:vehicleSeatingCapacity</a>
    /// </summary>
    let vehicleSeatingCapacity = _prefixId.prefix "vehicleSeatingCapacity"
    /// <summary>
    ///   <para>rdfs:comment : The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).^^xsd:string</para>
    ///   <para>rdfs:label : vehicleTransmission^^xsd:string</para>
    ///   <a href="http://schema.org/vehicleTransmission">schema:vehicleTransmission</a>
    /// </summary>
    let vehicleTransmission = _prefixId.prefix "vehicleTransmission"
    /// <summary>
    ///   <para>rdfs:comment : 'vendor' is an earlier term for 'seller'.^^xsd:string</para>
    ///   <para>rdfs:label : vendor^^xsd:string</para>
    ///   <a href="http://schema.org/vendor">schema:vendor</a>
    /// </summary>
    let vendor = _prefixId.prefix "vendor"
    /// <summary>
    ///   <para>rdfs:label : version^^xsd:string</para>
    ///   <para>rdfs:comment : The version of the CreativeWork embodied by a specified resource.^^xsd:string</para>
    ///   <a href="http://schema.org/version">schema:version</a>
    /// </summary>
    let version = _prefixId.prefix "version"
    /// <summary>
    ///   <para>rdfs:comment : An embedded video object.^^xsd:string</para>
    ///   <para>rdfs:label : video^^xsd:string</para>
    ///   <a href="http://schema.org/video">schema:video</a>
    /// </summary>
    let video = _prefixId.prefix "video"
    /// <summary>
    ///   <para>rdfs:label : videoFormat^^xsd:string</para>
    ///   <para>rdfs:comment : The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).^^xsd:string</para>
    ///   <a href="http://schema.org/videoFormat">schema:videoFormat</a>
    /// </summary>
    let videoFormat = _prefixId.prefix "videoFormat"
    /// <summary>
    ///   <para>rdfs:label : videoFrameSize^^xsd:string</para>
    ///   <para>rdfs:comment : The frame size of the video.^^xsd:string</para>
    ///   <a href="http://schema.org/videoFrameSize">schema:videoFrameSize</a>
    /// </summary>
    let videoFrameSize = _prefixId.prefix "videoFrameSize"
    /// <summary>
    ///   <para>rdfs:comment : The quality of the video.^^xsd:string</para>
    ///   <para>rdfs:label : videoQuality^^xsd:string</para>
    ///   <a href="http://schema.org/videoQuality">schema:videoQuality</a>
    /// </summary>
    let videoQuality = _prefixId.prefix "videoQuality"
    /// <summary>
    ///   <para>rdfs:label : volumeNumber^^xsd:string</para>
    ///   <para>rdfs:comment : Identifies the volume of publication or multi-part work; for example, "iii" or "2".^^xsd:string</para>
    ///   <a href="http://schema.org/volumeNumber">schema:volumeNumber</a>
    /// </summary>
    let volumeNumber = _prefixId.prefix "volumeNumber"
    /// <summary>
    ///   <para>rdfs:comment : The warranty promise(s) included in the offer.^^xsd:string</para>
    ///   <para>rdfs:label : warranty^^xsd:string</para>
    ///   <a href="http://schema.org/warranty">schema:warranty</a>
    /// </summary>
    let warranty = _prefixId.prefix "warranty"
    /// <summary>
    ///   <para>rdfs:label : warrantyPromise^^xsd:string</para>
    ///   <para>rdfs:comment : The warranty promise(s) included in the offer.^^xsd:string</para>
    ///   <a href="http://schema.org/warrantyPromise">schema:warrantyPromise</a>
    /// </summary>
    let warrantyPromise = _prefixId.prefix "warrantyPromise"
    /// <summary>
    ///   <para>rdfs:label : warrantyScope^^xsd:string</para>
    ///   <para>rdfs:comment : The scope of the warranty promise.^^xsd:string</para>
    ///   <a href="http://schema.org/warrantyScope">schema:warrantyScope</a>
    /// </summary>
    let warrantyScope = _prefixId.prefix "warrantyScope"
    /// <summary>
    ///   <para>rdfs:label : webCheckinTime^^xsd:string</para>
    ///   <para>rdfs:comment : The time when a passenger can check into the flight online.^^xsd:string</para>
    ///   <a href="http://schema.org/webCheckinTime">schema:webCheckinTime</a>
    /// </summary>
    let webCheckinTime = _prefixId.prefix "webCheckinTime"
    /// <summary>
    ///   <para>rdfs:label : weight^^xsd:string</para>
    ///   <para>rdfs:comment : The weight of the product or person.^^xsd:string</para>
    ///   <a href="http://schema.org/weight">schema:weight</a>
    /// </summary>
    let weight = _prefixId.prefix "weight"
    /// <summary>
    ///   <para>rdfs:comment : The width of the item.^^xsd:string</para>
    ///   <para>rdfs:label : width^^xsd:string</para>
    ///   <a href="http://schema.org/width">schema:width</a>
    /// </summary>
    let width = _prefixId.prefix "width"
    /// <summary>
    ///   <para>rdfs:label : winner^^xsd:string</para>
    ///   <para>rdfs:comment : A sub property of participant. The winner of the action.^^xsd:string</para>
    ///   <a href="http://schema.org/winner">schema:winner</a>
    /// </summary>
    let winner = _prefixId.prefix "winner"
    /// <summary>
    ///   <para>rdfs:label : wordCount^^xsd:string</para>
    ///   <para>rdfs:comment : The number of words in the text of the Article.^^xsd:string</para>
    ///   <a href="http://schema.org/wordCount">schema:wordCount</a>
    /// </summary>
    let wordCount = _prefixId.prefix "wordCount"
    /// <summary>
    ///   <para>rdfs:comment : Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.^^xsd:string</para>
    ///   <para>rdfs:label : workExample^^xsd:string</para>
    ///   <a href="http://schema.org/workExample">schema:workExample</a>
    /// </summary>
    let workExample = _prefixId.prefix "workExample"
    /// <summary>
    ///   <para>rdfs:label : workFeatured^^xsd:string</para>
    ///   <para>rdfs:comment : A work featured in some event, e.g. exhibited in an ExhibitionEvent.
    ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).^^xsd:string</para>
    ///   <a href="http://schema.org/workFeatured">schema:workFeatured</a>
    /// </summary>
    let workFeatured = _prefixId.prefix "workFeatured"
    /// <summary>
    ///   <para>rdfs:comment : The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).^^xsd:string</para>
    ///   <para>rdfs:label : workHours^^xsd:string</para>
    ///   <a href="http://schema.org/workHours">schema:workHours</a>
    /// </summary>
    let workHours = _prefixId.prefix "workHours"
    /// <summary>
    ///   <para>rdfs:comment : A contact location for a person's place of work.^^xsd:string</para>
    ///   <para>rdfs:label : workLocation^^xsd:string</para>
    ///   <a href="http://schema.org/workLocation">schema:workLocation</a>
    /// </summary>
    let workLocation = _prefixId.prefix "workLocation"
    /// <summary>
    ///   <para>rdfs:label : workPerformed^^xsd:string</para>
    ///   <para>rdfs:comment : A work performed in some event, for example a play performed in a TheaterEvent.^^xsd:string</para>
    ///   <a href="http://schema.org/workPerformed">schema:workPerformed</a>
    /// </summary>
    let workPerformed = _prefixId.prefix "workPerformed"
    /// <summary>
    ///   <para>rdfs:label : workPresented^^xsd:string</para>
    ///   <para>rdfs:comment : The movie presented during this event.^^xsd:string</para>
    ///   <a href="http://schema.org/workPresented">schema:workPresented</a>
    /// </summary>
    let workPresented = _prefixId.prefix "workPresented"
    /// <summary>
    ///   <para>rdfs:label : worksFor^^xsd:string</para>
    ///   <para>rdfs:comment : Organizations that the person works for.^^xsd:string</para>
    ///   <a href="http://schema.org/worksFor">schema:worksFor</a>
    /// </summary>
    let worksFor = _prefixId.prefix "worksFor"
    /// <summary>
    ///   <para>rdfs:comment : The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.^^xsd:string</para>
    ///   <para>rdfs:label : worstRating^^xsd:string</para>
    ///   <a href="http://schema.org/worstRating">schema:worstRating</a>
    /// </summary>
    let worstRating = _prefixId.prefix "worstRating"
    /// <summary>
    ///   <para>rdfs:label : xpath^^xsd:string</para>
    ///   <para>rdfs:comment : An XPath, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".^^xsd:string</para>
    ///   <para>schema:category : issue-1389^^xsd:string</para>
    ///   <a href="http://schema.org/xpath">schema:xpath</a>
    /// </summary>
    let xpath = _prefixId.prefix "xpath"
    /// <summary>
    ///   <para>rdfs:comment : The size of the business in annual revenue.^^xsd:string</para>
    ///   <para>rdfs:label : yearlyRevenue^^xsd:string</para>
    ///   <a href="http://schema.org/yearlyRevenue">schema:yearlyRevenue</a>
    /// </summary>
    let yearlyRevenue = _prefixId.prefix "yearlyRevenue"
    /// <summary>
    ///   <para>rdfs:label : yearsInOperation^^xsd:string</para>
    ///   <para>rdfs:comment : The age of the business.^^xsd:string</para>
    ///   <a href="http://schema.org/yearsInOperation">schema:yearsInOperation</a>
    /// </summary>
    let yearsInOperation = _prefixId.prefix "yearsInOperation"
    /// <summary>
    ///   <para>rdfs:comment : The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.^^xsd:string</para>
    ///   <para>rdfs:label : yield^^xsd:string</para>
    ///   <a href="http://schema.org/yield">schema:yield</a>
    /// </summary>
    let yield_ = _prefixId.prefix "yield"
