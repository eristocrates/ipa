namespace https.schema.org.slash

open DoxAletheia

module schemas =
    let _namespace_name = "https://schema.org/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A 3D model represents some kind of 3D content, which may have [[encoding]]s in one or more [[MediaObject]]s. Many 3D formats are available (e.g. see [Wikipedia](https://en.wikipedia.org/wiki/Category:3D_graphics_file_formats)); specific encoding formats can be represented using the [[encodingFormat]] property applied to the relevant [[MediaObject]]. For the
    /// case of a single file published after Zip compression, the convention of appending '+zip' to the [[encodingFormat]] can be used. Geospatial, AR/VR, artistic/animation, gaming, engineering and scientific content can all be represented using [[3DModel]].
    /// <see href="https://schema.org/3DModel"></see></summary>
    let _3DModel = _prefix "3DModel"
    /// <summary>
    /// A media object, such as an image, video, audio, or text object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// <see href="https://schema.org/MediaObject"></see></summary>
    let MediaObject = _prefix "MediaObject"
    /// <summary>
    /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.
    /// <see href="https://schema.org/isPartOf"></see></summary>
    let isPartOf = _prefix "isPartOf"
    /// <summary>
    /// The source or cause of the event.
    /// <see href="https://schema.org/source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    /// A radio channel that uses AM.
    /// <see href="https://schema.org/AMRadioChannel"></see></summary>
    let AMRadioChannel = _prefix "AMRadioChannel"
    /// <summary>
    /// A unique instance of a radio BroadcastService on a CableOrSatelliteService lineup.
    /// <see href="https://schema.org/RadioChannel"></see></summary>
    let RadioChannel = _prefix "RadioChannel"
    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// <see href="https://schema.org/APIReference"></see></summary>
    let APIReference = _prefix "APIReference"
    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// <see href="https://schema.org/TechArticle"></see></summary>
    let TechArticle = _prefix "TechArticle"
    /// <summary>
    /// Abdomen clinical examination.
    /// <see href="https://schema.org/Abdomen"></see></summary>
    let Abdomen = _prefix "Abdomen"
    /// <summary>
    /// A type of physical examination of a patient performed by a physician.
    /// <see href="https://schema.org/PhysicalExam"></see></summary>
    let PhysicalExam = _prefix "PhysicalExam"
    /// <summary>
    /// Web page type: About page.
    /// <see href="https://schema.org/AboutPage"></see></summary>
    let AboutPage = _prefix "AboutPage"
    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// <see href="https://schema.org/WebPage"></see></summary>
    let WebPage = _prefix "WebPage"
    /// <summary>
    /// The act of committing to/adopting an object.\n\nRelated actions:\n\n* [[RejectAction]]: The antonym of AcceptAction.
    /// <see href="https://schema.org/AcceptAction"></see></summary>
    let AcceptAction = _prefix "AcceptAction"
    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// <see href="https://schema.org/AllocateAction"></see></summary>
    let AllocateAction = _prefix "AllocateAction"
    /// <summary>
    /// An accommodation is a place that can accommodate human beings, e.g. a hotel room, a camping pitch, or a meeting room. Many accommodations are for overnight stays, but this is not a mandatory requirement.
    /// For more specific types of accommodations not defined in schema.org, one can use [[additionalType]] with external vocabularies.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/Accommodation"></see></summary>
    let Accommodation = _prefix "Accommodation"
    /// <summary>
    /// Entities that have a somewhat fixed, physical extension.
    /// <see href="https://schema.org/Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// A secondary contributor to the CreativeWork or Event.
    /// <see href="https://schema.org/contributor"></see></summary>
    let contributor = _prefix "contributor"

    /// <summary>
    ///   <see href="https://schema.org/docs/collab/STI_Accommodation_Ontology"></see>
    /// </summary>
    let ``docs/collab/STI_Accommodation_Ontology`` =
        _prefix "docs/collab/STI_Accommodation_Ontology"

    /// <summary>
    /// Accountancy business.\n\nAs a [[LocalBusiness]] it can be described as a [[provider]] of one or more [[Service]]\(s).
    ///
    /// <see href="https://schema.org/AccountingService"></see></summary>
    let AccountingService = _prefix "AccountingService"
    /// <summary>
    /// Financial services business.
    /// <see href="https://schema.org/FinancialService"></see></summary>
    let FinancialService = _prefix "FinancialService"
    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// <see href="https://schema.org/AchieveAction"></see></summary>
    let AchieveAction = _prefix "AchieveAction"
    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. Optionally happens at a location with the help of an inanimate instrument. The execution of the action may produce a result. Specific action sub-type documentation specifies the exact expectation of each argument/role.\n\nSee also [blog post](https://blog.schema.org/2014/04/16/announcing-schema-org-actions/) and [Actions overview document](https://schema.org/docs/actions.html).
    /// <see href="https://schema.org/Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// The most generic type of item.
    /// <see href="https://schema.org/Thing"></see></summary>
    let Thing = _prefix "Thing"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/ActionCollabClass"></see>
    /// </summary>
    let ``docs/collab/ActionCollabClass`` = _prefix "docs/collab/ActionCollabClass"
    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action.
    /// <see href="https://schema.org/ActionAccessSpecification"></see></summary>
    let ActionAccessSpecification = _prefix "ActionAccessSpecification"
    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things such as quantities, structured values, etc.
    /// <see href="https://schema.org/Intangible"></see></summary>
    let Intangible = _prefix "Intangible"
    /// <summary>
    /// The status of an Action.
    /// <see href="https://schema.org/ActionStatusType"></see></summary>
    let ActionStatusType = _prefix "ActionStatusType"
    /// <summary>
    /// Lists or enumerations dealing with status types.
    /// <see href="https://schema.org/StatusEnumeration"></see></summary>
    let StatusEnumeration = _prefix "StatusEnumeration"
    /// <summary>
    /// The act of starting or activating a device or application (e.g. starting a timer or turning on a flashlight).
    /// <see href="https://schema.org/ActivateAction"></see></summary>
    let ActivateAction = _prefix "ActivateAction"
    /// <summary>
    /// An agent controls a device or application.
    /// <see href="https://schema.org/ControlAction"></see></summary>
    let ControlAction = _prefix "ControlAction"
    /// <summary>
    /// Represents the activation fee part of the total price for an offered product, for example a cellphone contract.
    /// <see href="https://schema.org/ActivationFee"></see></summary>
    let ActivationFee = _prefix "ActivationFee"
    /// <summary>
    /// Enumerates different price components that together make up the total price for an offered product.
    /// <see href="https://schema.org/PriceComponentTypeEnumeration"></see></summary>
    let PriceComponentTypeEnumeration = _prefix "PriceComponentTypeEnumeration"
    /// <summary>
    /// An in-progress action (e.g., while watching the movie, or driving to a location).
    /// <see href="https://schema.org/ActiveActionStatus"></see></summary>
    let ActiveActionStatus = _prefix "ActiveActionStatus"
    /// <summary>
    /// Active, but not recruiting new participants.
    /// <see href="https://schema.org/ActiveNotRecruiting"></see></summary>
    let ActiveNotRecruiting = _prefix "ActiveNotRecruiting"
    /// <summary>
    /// The status of a medical study. Enumerated type.
    /// <see href="https://schema.org/MedicalStudyStatus"></see></summary>
    let MedicalStudyStatus = _prefix "MedicalStudyStatus"
    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// <see href="https://schema.org/AddAction"></see></summary>
    let AddAction = _prefix "AddAction"
    /// <summary>
    /// The act of managing by changing/editing the state of the object.
    /// <see href="https://schema.org/UpdateAction"></see></summary>
    let UpdateAction = _prefix "UpdateAction"
    /// <summary>
    /// A geographical region, typically under the jurisdiction of a particular government.
    /// <see href="https://schema.org/AdministrativeArea"></see></summary>
    let AdministrativeArea = _prefix "AdministrativeArea"
    /// <summary>
    /// An adult entertainment establishment.
    /// <see href="https://schema.org/AdultEntertainment"></see></summary>
    let AdultEntertainment = _prefix "AdultEntertainment"
    /// <summary>
    /// A business providing entertainment.
    /// <see href="https://schema.org/EntertainmentBusiness"></see></summary>
    let EntertainmentBusiness = _prefix "EntertainmentBusiness"
    /// <summary>
    /// Enumeration of considerations that make a product relevant or potentially restricted for adults only.
    /// <see href="https://schema.org/AdultOrientedEnumeration"></see></summary>
    let AdultOrientedEnumeration = _prefix "AdultOrientedEnumeration"
    /// <summary>
    /// Lists or enumerations—for example, a list of cuisines or music genres, etc.
    /// <see href="https://schema.org/Enumeration"></see></summary>
    let Enumeration = _prefix "Enumeration"
    /// <summary>
    /// An [[Article]] that an external entity has paid to place or to produce to its specifications. Includes [advertorials](https://en.wikipedia.org/wiki/Advertorial), sponsored content, native advertising and other paid content.
    /// <see href="https://schema.org/AdvertiserContentArticle"></see></summary>
    let AdvertiserContentArticle = _prefix "AdvertiserContentArticle"
    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// <see href="https://schema.org/Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/TP"></see>
    /// </summary>
    let ``docs/collab/TP`` = _prefix "docs/collab/TP"
    /// <summary>
    /// Physical activity of relatively low intensity that depends primarily on the aerobic energy-generating process; during activity, the aerobic metabolism uses oxygen to adequately meet energy demands during exercise.
    /// <see href="https://schema.org/AerobicActivity"></see></summary>
    let AerobicActivity = _prefix "AerobicActivity"
    /// <summary>
    /// Categories of physical activity, organized by physiologic classification.
    /// <see href="https://schema.org/PhysicalActivityCategory"></see></summary>
    let PhysicalActivityCategory = _prefix "PhysicalActivityCategory"
    /// <summary>
    /// When a single product is associated with multiple offers (for example, the same pair of shoes is offered by different merchants), then AggregateOffer can be used.\n\nNote: AggregateOffers are normally expected to associate multiple offers that all share the same defined [[businessFunction]] value, or default to http://purl.org/goodrelations/v1#Sell if businessFunction is not explicitly defined.
    /// <see href="https://schema.org/AggregateOffer"></see></summary>
    let AggregateOffer = _prefix "AggregateOffer"
    /// <summary>
    /// An offer to transfer some rights to an item or to provide a service — for example, an offer to sell tickets to an event, to rent the DVD of a movie, to stream a TV show over the internet, to repair a motorcycle, or to loan a book.\n\nNote: As the [[businessFunction]] property, which identifies the form of offer (e.g. sell, lease, repair, dispose), defaults to http://purl.org/goodrelations/v1#Sell; an Offer without a defined businessFunction value can be assumed to be an offer to sell.\n\nFor [GTIN](http://www.gs1.org/barcodes/technical/idkeys/gtin)-related fields, see [Check Digit calculator](http://www.gs1.org/barcodes/support/check_digit_calculator) and [validation guide](http://www.gs1us.org/resources/standards/gtin-validation-guide) from [GS1](http://www.gs1.org/).
    /// <see href="https://schema.org/Offer"></see></summary>
    let Offer = _prefix "Offer"
    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// <see href="https://schema.org/AggregateRating"></see></summary>
    let AggregateRating = _prefix "AggregateRating"
    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// <see href="https://schema.org/Rating"></see></summary>
    let Rating = _prefix "Rating"
    /// <summary>
    /// The act of expressing a consistency of opinion with the object. An agent agrees to/about an object (a proposition, topic or theme) with participants.
    /// <see href="https://schema.org/AgreeAction"></see></summary>
    let AgreeAction = _prefix "AgreeAction"
    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// <see href="https://schema.org/ReactAction"></see></summary>
    let ReactAction = _prefix "ReactAction"
    /// <summary>
    /// An organization that provides flights for passengers.
    /// <see href="https://schema.org/Airline"></see></summary>
    let Airline = _prefix "Airline"
    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// <see href="https://schema.org/Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// An airport.
    /// <see href="https://schema.org/Airport"></see></summary>
    let Airport = _prefix "Airport"
    /// <summary>
    /// A public structure, such as a town hall or concert hall.
    /// <see href="https://schema.org/CivicStructure"></see></summary>
    let CivicStructure = _prefix "CivicStructure"
    /// <summary>
    /// AlbumRelease.
    /// <see href="https://schema.org/AlbumRelease"></see></summary>
    let AlbumRelease = _prefix "AlbumRelease"
    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// <see href="https://schema.org/MusicAlbumReleaseType"></see></summary>
    let MusicAlbumReleaseType = _prefix "MusicAlbumReleaseType"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/MBZ"></see>
    /// </summary>
    let ``docs/collab/MBZ`` = _prefix "docs/collab/MBZ"
    /// <summary>
    /// Item contains alcohol or promotes alcohol consumption.
    /// <see href="https://schema.org/AlcoholConsideration"></see></summary>
    let AlcoholConsideration = _prefix "AlcoholConsideration"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/algorithmicMedia"&gt;algorithmic media&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/AlgorithmicMediaDigitalSource"></see></summary>
    let AlgorithmicMediaDigitalSource = _prefix "AlgorithmicMediaDigitalSource"
    /// <summary>
    /// &lt;a href="https://www.iptc.org/"&gt;IPTC&lt;/a&gt; "Digital Source" codes for use with the [[digitalSourceType]] property, providing information about the source for a digital media object.
    /// In general these codes are not declared here to be mutually exclusive, although some combinations would be contradictory if applied simultaneously, or might be considered mutually incompatible by upstream maintainers of the definitions. See the IPTC &lt;a href="https://www.iptc.org/std/photometadata/documentation/userguide/"&gt;documentation&lt;/a&gt;
    ///  for &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;detailed definitions&lt;/a&gt; of all terms.
    /// <see href="https://schema.org/IPTCDigitalSourceEnumeration"></see></summary>
    let IPTCDigitalSourceEnumeration = _prefix "IPTCDigitalSourceEnumeration"

    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/algorithmicallyEnhanced"&gt;algorithmically enhanced&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/AlgorithmicallyEnhancedDigitalSource"></see></summary>
    let AlgorithmicallyEnhancedDigitalSource =
        _prefix "AlgorithmicallyEnhancedDigitalSource"

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// Should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource [[teaches]] or [[assesses]] a competency.
    /// <see href="https://schema.org/AlignmentObject"></see></summary>
    let AlignmentObject = _prefix "AlignmentObject"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/LRMIClass"></see>
    /// </summary>
    let ``docs/collab/LRMIClass`` = _prefix "docs/collab/LRMIClass"
    /// <summary>
    /// All-wheel Drive is a transmission layout where the engine drives all four wheels.
    /// <see href="https://schema.org/AllWheelDriveConfiguration"></see></summary>
    let AllWheelDriveConfiguration = _prefix "AllWheelDriveConfiguration"
    /// <summary>
    /// A value indicating which roadwheels will receive torque.
    /// <see href="https://schema.org/DriveWheelConfigurationValue"></see></summary>
    let DriveWheelConfigurationValue = _prefix "DriveWheelConfigurationValue"

    /// <summary>
    ///   <see href="https://schema.org/docs/collab/Automotive_Ontology_Working_Group"></see>
    /// </summary>
    let ``docs/collab/Automotive_Ontology_Working_Group`` =
        _prefix "docs/collab/Automotive_Ontology_Working_Group"

    /// <summary>
    /// Content about the allergy-related aspects of a health topic.
    /// <see href="https://schema.org/AllergiesHealthAspect"></see></summary>
    let AllergiesHealthAspect = _prefix "AllergiesHealthAspect"
    /// <summary>
    /// HealthAspectEnumeration enumerates several aspects of health content online, each of which might be described using [[hasHealthAspect]] and [[HealthTopicContent]].
    /// <see href="https://schema.org/HealthAspectEnumeration"></see></summary>
    let HealthAspectEnumeration = _prefix "HealthAspectEnumeration"
    /// <summary>
    /// The act of manipulating/administering/supervising/controlling one or more objects.
    /// <see href="https://schema.org/OrganizeAction"></see></summary>
    let OrganizeAction = _prefix "OrganizeAction"
    /// <summary>
    /// A creative work with a visual storytelling format intended to be viewed online, particularly on mobile devices.
    /// <see href="https://schema.org/AmpStory"></see></summary>
    let AmpStory = _prefix "AmpStory"
    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// <see href="https://schema.org/CreativeWork"></see></summary>
    let CreativeWork = _prefix "CreativeWork"
    /// <summary>
    /// An amusement park.
    /// <see href="https://schema.org/AmusementPark"></see></summary>
    let AmusementPark = _prefix "AmusementPark"
    /// <summary>
    /// Physical activity that is of high-intensity which utilizes the anaerobic metabolism of the body.
    /// <see href="https://schema.org/AnaerobicActivity"></see></summary>
    let AnaerobicActivity = _prefix "AnaerobicActivity"
    /// <summary>
    /// An AnalysisNewsArticle is a [[NewsArticle]] that, while based on factual reporting, incorporates the expertise of the author/producer, offering interpretations and conclusions.
    /// <see href="https://schema.org/AnalysisNewsArticle"></see></summary>
    let AnalysisNewsArticle = _prefix "AnalysisNewsArticle"
    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.
    ///
    /// A more detailed overview of [schema.org News markup](/docs/news.html) is also available.
    ///
    /// <see href="https://schema.org/NewsArticle"></see></summary>
    let NewsArticle = _prefix "NewsArticle"
    /// <summary>
    /// Any part of the human body, typically a component of an anatomical system. Organs, tissues, and cells are all anatomical structures.
    /// <see href="https://schema.org/AnatomicalStructure"></see></summary>
    let AnatomicalStructure = _prefix "AnatomicalStructure"
    /// <summary>
    /// The most generic type of entity related to health and the practice of medicine.
    /// <see href="https://schema.org/MedicalEntity"></see></summary>
    let MedicalEntity = _prefix "MedicalEntity"
    /// <summary>
    /// An anatomical system is a group of anatomical structures that work together to perform a certain task. Anatomical systems, such as organ systems, are one organizing principle of anatomy, and can include circulatory, digestive, endocrine, integumentary, immune, lymphatic, muscular, nervous, reproductive, respiratory, skeletal, urinary, vestibular, and other systems.
    /// <see href="https://schema.org/AnatomicalSystem"></see></summary>
    let AnatomicalSystem = _prefix "AnatomicalSystem"
    /// <summary>
    /// Represents the broad notion of Android-based operating systems.
    /// <see href="https://schema.org/AndroidPlatform"></see></summary>
    let AndroidPlatform = _prefix "AndroidPlatform"
    /// <summary>
    /// Enumerates some common technology platforms, for use with properties such as [[actionPlatform]]. It is not supposed to be comprehensive - when a suitable code is not enumerated here, textual or URL values can be used instead. These codes are at a fairly high level and do not deal with versioning and other nuance. Additional codes can be suggested [in github](https://github.com/schemaorg/schemaorg/issues/3057).
    /// <see href="https://schema.org/DigitalPlatformEnumeration"></see></summary>
    let DigitalPlatformEnumeration = _prefix "DigitalPlatformEnumeration"
    /// <summary>
    /// A specific branch of medical science that pertains to study of anesthetics and their application.
    /// <see href="https://schema.org/Anesthesia"></see></summary>
    let Anesthesia = _prefix "Anesthesia"
    /// <summary>
    /// Any specific branch of medical science or practice. Medical specialities include clinical specialties that pertain to particular organ systems and their respective disease states, as well as allied health specialties. Enumerated type.
    /// <see href="https://schema.org/MedicalSpecialty"></see></summary>
    let MedicalSpecialty = _prefix "MedicalSpecialty"
    /// <summary>
    /// Animal shelter.
    /// <see href="https://schema.org/AnimalShelter"></see></summary>
    let AnimalShelter = _prefix "AnimalShelter"
    /// <summary>
    /// A particular physical business or branch of an organization. Examples of LocalBusiness include a restaurant, a particular branch of a restaurant chain, a branch of a bank, a medical practice, a club, a bowling alley, etc.
    /// <see href="https://schema.org/LocalBusiness"></see></summary>
    let LocalBusiness = _prefix "LocalBusiness"
    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// <see href="https://schema.org/Answer"></see></summary>
    let Answer = _prefix "Answer"
    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the [[text]] property, and its topic via [[about]], properties shared with all CreativeWorks.
    /// <see href="https://schema.org/Comment"></see></summary>
    let Comment = _prefix "Comment"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/QAStackExchange"></see>
    /// </summary>
    let ``docs/collab/QAStackExchange`` = _prefix "docs/collab/QAStackExchange"
    /// <summary>
    /// An apartment (in American English) or flat (in British English) is a self-contained housing unit (a type of residential real estate) that occupies only part of a building (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Apartment"&gt;http://en.wikipedia.org/wiki/Apartment&lt;/a&gt;).
    /// <see href="https://schema.org/Apartment"></see></summary>
    let Apartment = _prefix "Apartment"
    /// <summary>
    /// Residence type: Apartment complex.
    /// <see href="https://schema.org/ApartmentComplex"></see></summary>
    let ApartmentComplex = _prefix "ApartmentComplex"
    /// <summary>
    /// The place where a person lives.
    /// <see href="https://schema.org/Residence"></see></summary>
    let Residence = _prefix "Residence"
    /// <summary>
    /// Appearance assessment with clinical examination.
    /// <see href="https://schema.org/Appearance"></see></summary>
    let Appearance = _prefix "Appearance"
    /// <summary>
    /// The act of inserting at the end if an ordered collection.
    /// <see href="https://schema.org/AppendAction"></see></summary>
    let AppendAction = _prefix "AppendAction"
    /// <summary>
    /// The act of adding at a specific location in an ordered collection.
    /// <see href="https://schema.org/InsertAction"></see></summary>
    let InsertAction = _prefix "InsertAction"
    /// <summary>
    /// The act of registering to an organization/service without the guarantee to receive it.\n\nRelated actions:\n\n* [[RegisterAction]]: Unlike RegisterAction, ApplyAction has no guarantees that the application will be accepted.
    /// <see href="https://schema.org/ApplyAction"></see></summary>
    let ApplyAction = _prefix "ApplyAction"
    /// <summary>
    /// An indication for a medical therapy that has been formally specified or approved by a regulatory body that regulates use of the therapy; for example, the US FDA approves indications for most drugs in the US.
    /// <see href="https://schema.org/ApprovedIndication"></see></summary>
    let ApprovedIndication = _prefix "ApprovedIndication"
    /// <summary>
    /// A condition or factor that indicates use of a medical therapy, including signs, symptoms, risk factors, anatomical states, etc.
    /// <see href="https://schema.org/MedicalIndication"></see></summary>
    let MedicalIndication = _prefix "MedicalIndication"
    /// <summary>
    /// Aquarium.
    /// <see href="https://schema.org/Aquarium"></see></summary>
    let Aquarium = _prefix "Aquarium"
    /// <summary>
    /// An intangible type to be applied to any archive content, carrying with it a set of properties required to describe archival items and collections.
    /// <see href="https://schema.org/ArchiveComponent"></see></summary>
    let ArchiveComponent = _prefix "ArchiveComponent"
    /// <summary>
    /// An organization with archival holdings. An organization which keeps and preserves archival material and typically makes it accessible to the public.
    /// <see href="https://schema.org/ArchiveOrganization"></see></summary>
    let ArchiveOrganization = _prefix "ArchiveOrganization"
    /// <summary>
    /// The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.
    /// <see href="https://schema.org/ArriveAction"></see></summary>
    let ArriveAction = _prefix "ArriveAction"
    /// <summary>
    /// The act of an agent relocating to a place.\n\nRelated actions:\n\n* [[TransferAction]]: Unlike TransferAction, the subject of the move is a living Person or Organization rather than an inanimate object.
    /// <see href="https://schema.org/MoveAction"></see></summary>
    let MoveAction = _prefix "MoveAction"
    /// <summary>
    /// An art gallery.
    /// <see href="https://schema.org/ArtGallery"></see></summary>
    let ArtGallery = _prefix "ArtGallery"
    /// <summary>
    /// A type of blood vessel that specifically carries blood away from the heart.
    /// <see href="https://schema.org/Artery"></see></summary>
    let Artery = _prefix "Artery"
    /// <summary>
    /// A component of the human body circulatory system comprised of an intricate network of hollow tubes that transport blood throughout the entire body.
    /// <see href="https://schema.org/Vessel"></see></summary>
    let Vessel = _prefix "Vessel"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/rNews"></see>
    /// </summary>
    let ``docs/collab/rNews`` = _prefix "docs/collab/rNews"
    /// <summary>
    /// The act of posing a question / favor to someone.\n\nRelated actions:\n\n* [[ReplyAction]]: Appears generally as a response to AskAction.
    /// <see href="https://schema.org/AskAction"></see></summary>
    let AskAction = _prefix "AskAction"
    /// <summary>
    /// The act of conveying information to another person via a communication medium (instrument) such as speech, email, or telephone conversation.
    /// <see href="https://schema.org/CommunicateAction"></see></summary>
    let CommunicateAction = _prefix "CommunicateAction"
    /// <summary>
    /// A [[NewsArticle]] expressing an open call by a [[NewsMediaOrganization]] asking the public for input, insights, clarifications, anecdotes, documentation, etc., on an issue, for reporting purposes.
    /// <see href="https://schema.org/AskPublicNewsArticle"></see></summary>
    let AskPublicNewsArticle = _prefix "AskPublicNewsArticle"
    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// <see href="https://schema.org/AssessAction"></see></summary>
    let AssessAction = _prefix "AssessAction"
    /// <summary>
    /// The act of allocating an action/event/task to some destination (someone or something).
    /// <see href="https://schema.org/AssignAction"></see></summary>
    let AssignAction = _prefix "AssignAction"
    /// <summary>
    /// A collection or bound volume of maps, charts, plates or tables, physical or in media form illustrating any subject.
    /// <see href="https://schema.org/Atlas"></see></summary>
    let Atlas = _prefix "Atlas"
    /// <summary>
    /// Professional service: Attorney. \n\nThis type is deprecated - [[LegalService]] is more inclusive and less ambiguous.
    /// <see href="https://schema.org/Attorney"></see></summary>
    let Attorney = _prefix "Attorney"
    /// <summary>
    /// A LegalService is a business that provides legally-oriented services, advice and representation, e.g. law firms.\n\nAs a [[LocalBusiness]] it can be described as a [[provider]] of one or more [[Service]]\(s).
    /// <see href="https://schema.org/LegalService"></see></summary>
    let LegalService = _prefix "LegalService"
    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// <see href="https://schema.org/Audience"></see></summary>
    let Audience = _prefix "Audience"
    /// <summary>
    /// An audio file.
    /// <see href="https://schema.org/AudioObject"></see></summary>
    let AudioObject = _prefix "AudioObject"
    /// <summary>
    /// A specific and exact (byte-for-byte) version of an [[AudioObject]]. Two byte-for-byte identical files, for the purposes of this type, considered identical. If they have different embedded metadata the files will differ. Different external facts about the files, e.g. creator or dateCreated that aren't represented in their actual content, do not affect this notion of identity.
    /// <see href="https://schema.org/AudioObjectSnapshot"></see></summary>
    let AudioObjectSnapshot = _prefix "AudioObjectSnapshot"
    /// <summary>
    /// An audiobook.
    /// <see href="https://schema.org/Audiobook"></see></summary>
    let Audiobook = _prefix "Audiobook"
    /// <summary>
    /// A book.
    /// <see href="https://schema.org/Book"></see></summary>
    let Book = _prefix "Book"
    /// <summary>
    /// Book format: Audiobook. This is an enumerated value for use with the bookFormat property. There is also a type 'Audiobook' in the bib extension which includes Audiobook specific properties.
    /// <see href="https://schema.org/AudiobookFormat"></see></summary>
    let AudiobookFormat = _prefix "AudiobookFormat"
    /// <summary>
    /// The publication format of the book.
    /// <see href="https://schema.org/BookFormatType"></see></summary>
    let BookFormatType = _prefix "BookFormatType"
    /// <summary>
    /// The action of authenticating into a device or application.
    /// <see href="https://schema.org/AuthenticateAction"></see></summary>
    let AuthenticateAction = _prefix "AuthenticateAction"
    /// <summary>
    /// Indicates that the publisher gives some special status to the publication of the document. ("The Queens Printer" version of a UK Act of Parliament, or the PDF version of a Directive published by the EU Office of Publications). Something "Authoritative" is considered to be also [[OfficialLegalValue]]".
    /// <see href="https://schema.org/AuthoritativeLegalValue"></see></summary>
    let AuthoritativeLegalValue = _prefix "AuthoritativeLegalValue"
    /// <summary>
    /// A list of possible levels for the legal validity of a legislation.
    /// <see href="https://schema.org/LegalValueLevel"></see></summary>
    let LegalValueLevel = _prefix "LegalValueLevel"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/ELI"></see>
    /// </summary>
    let ``docs/collab/ELI`` = _prefix "docs/collab/ELI"
    /// <summary>
    /// The act of granting permission to an object.
    /// <see href="https://schema.org/AuthorizeAction"></see></summary>
    let AuthorizeAction = _prefix "AuthorizeAction"
    /// <summary>
    /// Auto body shop.
    /// <see href="https://schema.org/AutoBodyShop"></see></summary>
    let AutoBodyShop = _prefix "AutoBodyShop"
    /// <summary>
    /// Car repair, sales, or parts.
    /// <see href="https://schema.org/AutomotiveBusiness"></see></summary>
    let AutomotiveBusiness = _prefix "AutomotiveBusiness"
    /// <summary>
    /// An car dealership.
    /// <see href="https://schema.org/AutoDealer"></see></summary>
    let AutoDealer = _prefix "AutoDealer"
    /// <summary>
    /// An auto parts store.
    /// <see href="https://schema.org/AutoPartsStore"></see></summary>
    let AutoPartsStore = _prefix "AutoPartsStore"
    /// <summary>
    /// A retail good store.
    /// <see href="https://schema.org/Store"></see></summary>
    let Store = _prefix "Store"
    /// <summary>
    /// A car rental business.
    /// <see href="https://schema.org/AutoRental"></see></summary>
    let AutoRental = _prefix "AutoRental"
    /// <summary>
    /// Car repair business.
    /// <see href="https://schema.org/AutoRepair"></see></summary>
    let AutoRepair = _prefix "AutoRepair"
    /// <summary>
    /// A car wash business.
    /// <see href="https://schema.org/AutoWash"></see></summary>
    let AutoWash = _prefix "AutoWash"
    /// <summary>
    /// ATM/cash machine.
    /// <see href="https://schema.org/AutomatedTeller"></see></summary>
    let AutomatedTeller = _prefix "AutomatedTeller"
    /// <summary>
    /// A system of medicine that originated in India over thousands of years and that focuses on integrating and balancing the body, mind, and spirit.
    /// <see href="https://schema.org/Ayurvedic"></see></summary>
    let Ayurvedic = _prefix "Ayurvedic"
    /// <summary>
    /// Systems of medical practice.
    /// <see href="https://schema.org/MedicineSystem"></see></summary>
    let MedicineSystem = _prefix "MedicineSystem"
    /// <summary>
    /// Indicates that the item is available on back order.
    /// <see href="https://schema.org/BackOrder"></see></summary>
    let BackOrder = _prefix "BackOrder"
    /// <summary>
    /// A list of possible product availability options.
    /// <see href="https://schema.org/ItemAvailability"></see></summary>
    let ItemAvailability = _prefix "ItemAvailability"
    /// <summary>
    /// A [[NewsArticle]] providing historical context, definition and detail on a specific topic (aka "explainer" or "backgrounder"). For example, an in-depth article or frequently-asked-questions ([FAQ](https://en.wikipedia.org/wiki/FAQ)) document on topics such as Climate Change or the European Union. Other kinds of background material from a non-news setting are often described using [[Book]] or [[Article]], in particular [[ScholarlyArticle]]. See also [[NewsArticle]] for related vocabulary from a learning/education perspective.
    /// <see href="https://schema.org/BackgroundNewsArticle"></see></summary>
    let BackgroundNewsArticle = _prefix "BackgroundNewsArticle"
    /// <summary>
    /// Pathogenic bacteria that cause bacterial infection.
    /// <see href="https://schema.org/Bacteria"></see></summary>
    let Bacteria = _prefix "Bacteria"
    /// <summary>
    /// Classes of agents or pathogens that transmit infectious diseases. Enumerated type.
    /// <see href="https://schema.org/InfectiousAgentClass"></see></summary>
    let InfectiousAgentClass = _prefix "InfectiousAgentClass"
    /// <summary>
    /// A bakery.
    /// <see href="https://schema.org/Bakery"></see></summary>
    let Bakery = _prefix "Bakery"
    /// <summary>
    /// A food-related business.
    /// <see href="https://schema.org/FoodEstablishment"></see></summary>
    let FoodEstablishment = _prefix "FoodEstablishment"
    /// <summary>
    /// Physical activity that is engaged to help maintain posture and balance.
    /// <see href="https://schema.org/Balance"></see></summary>
    let Balance = _prefix "Balance"
    /// <summary>
    /// A product or service offered by a bank whereby one may deposit, withdraw or transfer money and in some cases be paid interest.
    /// <see href="https://schema.org/BankAccount"></see></summary>
    let BankAccount = _prefix "BankAccount"
    /// <summary>
    /// A product provided to consumers and businesses by financial institutions such as banks, insurance companies, brokerage firms, consumer finance companies, and investment companies which comprise the financial services industry.
    /// <see href="https://schema.org/FinancialProduct"></see></summary>
    let FinancialProduct = _prefix "FinancialProduct"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/FIBO"></see>
    /// </summary>
    let ``docs/collab/FIBO`` = _prefix "docs/collab/FIBO"
    /// <summary>
    /// Bank or credit union.
    /// <see href="https://schema.org/BankOrCreditUnion"></see></summary>
    let BankOrCreditUnion = _prefix "BankOrCreditUnion"
    /// <summary>
    /// A bar or pub.
    /// <see href="https://schema.org/BarOrPub"></see></summary>
    let BarOrPub = _prefix "BarOrPub"
    /// <summary>
    /// An image of a visual machine-readable code such as a barcode or QR code.
    /// <see href="https://schema.org/Barcode"></see></summary>
    let Barcode = _prefix "Barcode"
    /// <summary>
    /// An image file.
    /// <see href="https://schema.org/ImageObject"></see></summary>
    let ImageObject = _prefix "ImageObject"
    /// <summary>
    /// BasicIncome: this is a benefit for basic income.
    /// <see href="https://schema.org/BasicIncome"></see></summary>
    let BasicIncome = _prefix "BasicIncome"
    /// <summary>
    /// GovernmentBenefitsType enumerates several kinds of government benefits to support the COVID-19 situation. Note that this structure may not capture all benefits offered.
    /// <see href="https://schema.org/GovernmentBenefitsType"></see></summary>
    let GovernmentBenefitsType = _prefix "GovernmentBenefitsType"
    /// <summary>
    /// Beach.
    /// <see href="https://schema.org/Beach"></see></summary>
    let Beach = _prefix "Beach"
    /// <summary>
    /// Beauty salon.
    /// <see href="https://schema.org/BeautySalon"></see></summary>
    let BeautySalon = _prefix "BeautySalon"
    /// <summary>
    /// Health and beauty.
    /// <see href="https://schema.org/HealthAndBeautyBusiness"></see></summary>
    let HealthAndBeautyBusiness = _prefix "HealthAndBeautyBusiness"
    /// <summary>
    /// Bed and breakfast.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/BedAndBreakfast"></see></summary>
    let BedAndBreakfast = _prefix "BedAndBreakfast"
    /// <summary>
    /// A lodging business, such as a motel, hotel, or inn.
    /// <see href="https://schema.org/LodgingBusiness"></see></summary>
    let LodgingBusiness = _prefix "LodgingBusiness"
    /// <summary>
    /// An entity holding detailed information about the available bed types, e.g. the quantity of twin beds for a hotel room. For the single case of just one bed of a certain type, you can use bed directly with a text. See also [[BedType]] (under development).
    /// <see href="https://schema.org/BedDetails"></see></summary>
    let BedDetails = _prefix "BedDetails"
    /// <summary>
    /// A type of bed. This is used for indicating the bed or beds available in an accommodation.
    /// <see href="https://schema.org/BedType"></see></summary>
    let BedType = _prefix "BedType"
    /// <summary>
    /// A predefined value for a product characteristic, e.g. the power cord plug type 'US' or the garment sizes 'S', 'M', 'L', and 'XL'.
    /// <see href="https://schema.org/QualitativeValue"></see></summary>
    let QualitativeValue = _prefix "QualitativeValue"
    /// <summary>
    /// The act of forming a personal connection with someone (object) mutually/bidirectionally/symmetrically.\n\nRelated actions:\n\n* [[FollowAction]]: Unlike FollowAction, BefriendAction implies that the connection is reciprocal.
    /// <see href="https://schema.org/BefriendAction"></see></summary>
    let BefriendAction = _prefix "BefriendAction"
    /// <summary>
    /// The act of interacting with another person or organization.
    /// <see href="https://schema.org/InteractAction"></see></summary>
    let InteractAction = _prefix "InteractAction"
    /// <summary>
    /// Content about the benefits and advantages of usage or utilization of topic.
    /// <see href="https://schema.org/BenefitsHealthAspect"></see></summary>
    let BenefitsHealthAspect = _prefix "BenefitsHealthAspect"
    /// <summary>
    /// A bike store.
    /// <see href="https://schema.org/BikeStore"></see></summary>
    let BikeStore = _prefix "BikeStore"
    /// <summary>
    /// Any biological, chemical, or biochemical thing. For example: a protein; a gene; a chemical; a synthetic chemical.
    /// <see href="https://schema.org/BioChemEntity"></see></summary>
    let BioChemEntity = _prefix "BioChemEntity"
    /// <summary>
    /// A [blog](https://en.wikipedia.org/wiki/Blog), sometimes known as a "weblog". Note that the individual posts ([[BlogPosting]]s) in a [[Blog]] are often colloquially referred to by the same term.
    /// <see href="https://schema.org/Blog"></see></summary>
    let Blog = _prefix "Blog"
    /// <summary>
    /// A blog post.
    /// <see href="https://schema.org/BlogPosting"></see></summary>
    let BlogPosting = _prefix "BlogPosting"
    /// <summary>
    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    /// <see href="https://schema.org/SocialMediaPosting"></see></summary>
    let SocialMediaPosting = _prefix "SocialMediaPosting"
    /// <summary>
    /// A medical test performed on a sample of a patient's blood.
    /// <see href="https://schema.org/BloodTest"></see></summary>
    let BloodTest = _prefix "BloodTest"
    /// <summary>
    /// Any medical test, typically performed for diagnostic purposes.
    /// <see href="https://schema.org/MedicalTest"></see></summary>
    let MedicalTest = _prefix "MedicalTest"
    /// <summary>
    /// A type of boarding policy used by an airline.
    /// <see href="https://schema.org/BoardingPolicyType"></see></summary>
    let BoardingPolicyType = _prefix "BoardingPolicyType"
    /// <summary>
    /// A reservation for boat travel.
    ///
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// <see href="https://schema.org/BoatReservation"></see></summary>
    let BoatReservation = _prefix "BoatReservation"
    /// <summary>
    /// Describes a reservation for travel, dining or an event. Some reservations require tickets. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, restaurant reservations, flights, or rental cars, use [[Offer]].
    /// <see href="https://schema.org/Reservation"></see></summary>
    let Reservation = _prefix "Reservation"
    /// <summary>
    /// A terminal for boats, ships, and other water vessels.
    /// <see href="https://schema.org/BoatTerminal"></see></summary>
    let BoatTerminal = _prefix "BoatTerminal"
    /// <summary>
    /// A trip on a commercial ferry line.
    /// <see href="https://schema.org/BoatTrip"></see></summary>
    let BoatTrip = _prefix "BoatTrip"
    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// <see href="https://schema.org/Trip"></see></summary>
    let Trip = _prefix "Trip"
    /// <summary>
    /// Arm length (measured between arms/shoulder line intersection and the prominent wrist bone). Used, for example, to fit shirts.
    /// <see href="https://schema.org/BodyMeasurementArm"></see></summary>
    let BodyMeasurementArm = _prefix "BodyMeasurementArm"
    /// <summary>
    /// Enumerates types (or dimensions) of a person's body measurements, for example for fitting of clothes.
    /// <see href="https://schema.org/BodyMeasurementTypeEnumeration"></see></summary>
    let BodyMeasurementTypeEnumeration = _prefix "BodyMeasurementTypeEnumeration"
    /// <summary>
    /// Maximum girth of bust. Used, for example, to fit women's suits.
    /// <see href="https://schema.org/BodyMeasurementBust"></see></summary>
    let BodyMeasurementBust = _prefix "BodyMeasurementBust"
    /// <summary>
    /// Maximum girth of chest. Used, for example, to fit men's suits.
    /// <see href="https://schema.org/BodyMeasurementChest"></see></summary>
    let BodyMeasurementChest = _prefix "BodyMeasurementChest"
    /// <summary>
    /// Foot length (measured between end of the most prominent toe and the most prominent part of the heel). Used, for example, to measure socks.
    /// <see href="https://schema.org/BodyMeasurementFoot"></see></summary>
    let BodyMeasurementFoot = _prefix "BodyMeasurementFoot"
    /// <summary>
    /// Maximum hand girth (measured over the knuckles of the open right hand excluding thumb, fingers together). Used, for example, to fit gloves.
    /// <see href="https://schema.org/BodyMeasurementHand"></see></summary>
    let BodyMeasurementHand = _prefix "BodyMeasurementHand"
    /// <summary>
    /// Maximum girth of head above the ears. Used, for example, to fit hats.
    /// <see href="https://schema.org/BodyMeasurementHead"></see></summary>
    let BodyMeasurementHead = _prefix "BodyMeasurementHead"
    /// <summary>
    /// Body height (measured between crown of head and soles of feet). Used, for example, to fit jackets.
    /// <see href="https://schema.org/BodyMeasurementHeight"></see></summary>
    let BodyMeasurementHeight = _prefix "BodyMeasurementHeight"
    /// <summary>
    /// Girth of hips (measured around the buttocks). Used, for example, to fit skirts.
    /// <see href="https://schema.org/BodyMeasurementHips"></see></summary>
    let BodyMeasurementHips = _prefix "BodyMeasurementHips"
    /// <summary>
    /// Inside leg (measured between crotch and soles of feet). Used, for example, to fit pants.
    /// <see href="https://schema.org/BodyMeasurementInsideLeg"></see></summary>
    let BodyMeasurementInsideLeg = _prefix "BodyMeasurementInsideLeg"
    /// <summary>
    /// Girth of neck. Used, for example, to fit shirts.
    /// <see href="https://schema.org/BodyMeasurementNeck"></see></summary>
    let BodyMeasurementNeck = _prefix "BodyMeasurementNeck"
    /// <summary>
    /// Enumeration of common measurement types (or dimensions), for example "chest" for a person, "inseam" for pants, "gauge" for screws, or "wheel" for bicycles.
    /// <see href="https://schema.org/MeasurementTypeEnumeration"></see></summary>
    let MeasurementTypeEnumeration = _prefix "MeasurementTypeEnumeration"
    /// <summary>
    /// Girth of body just below the bust. Used, for example, to fit women's swimwear.
    /// <see href="https://schema.org/BodyMeasurementUnderbust"></see></summary>
    let BodyMeasurementUnderbust = _prefix "BodyMeasurementUnderbust"
    /// <summary>
    /// Girth of natural waistline (between hip bones and lower ribs). Used, for example, to fit pants.
    /// <see href="https://schema.org/BodyMeasurementWaist"></see></summary>
    let BodyMeasurementWaist = _prefix "BodyMeasurementWaist"
    /// <summary>
    /// Body weight. Used, for example, to measure pantyhose.
    /// <see href="https://schema.org/BodyMeasurementWeight"></see></summary>
    let BodyMeasurementWeight = _prefix "BodyMeasurementWeight"
    /// <summary>
    /// A body of water, such as a sea, ocean, or lake.
    /// <see href="https://schema.org/BodyOfWater"></see></summary>
    let BodyOfWater = _prefix "BodyOfWater"
    /// <summary>
    /// A landform or physical feature.  Landform elements include mountains, plains, lakes, rivers, seascape and oceanic waterbody interface features such as bays, peninsulas, seas and so forth, including sub-aqueous terrain features such as submersed mountain ranges, volcanoes, and the great ocean basins.
    /// <see href="https://schema.org/Landform"></see></summary>
    let Landform = _prefix "Landform"
    /// <summary>
    /// Rigid connective tissue that comprises up the skeletal structure of the human body.
    /// <see href="https://schema.org/Bone"></see></summary>
    let Bone = _prefix "Bone"
    /// <summary>
    /// A series of books. Included books can be indicated with the hasPart property.
    /// <see href="https://schema.org/BookSeries"></see></summary>
    let BookSeries = _prefix "BookSeries"
    /// <summary>
    /// A CreativeWorkSeries in schema.org is a group of related items, typically but not necessarily of the same kind. CreativeWorkSeries are usually organized into some order, often chronological. Unlike [[ItemList]] which is a general purpose data structure for lists of things, the emphasis with CreativeWorkSeries is on published materials (written e.g. books and periodicals, or media such as TV, radio and games).\n\nSpecific subtypes are available for describing [[TVSeries]], [[RadioSeries]], [[MovieSeries]], [[BookSeries]], [[Periodical]] and [[VideoGameSeries]]. In each case, the [[hasPart]] / [[isPartOf]] properties can be used to relate the CreativeWorkSeries to its parts. The general CreativeWorkSeries type serves largely just to organize these more specific and practical subtypes.\n\nIt is common for properties applicable to an item from the series to be usefully applied to the containing group. Schema.org attempts to anticipate some of these cases, but publishers should be free to apply properties of the series parts to the series as a whole wherever they seem appropriate.
    ///
    /// <see href="https://schema.org/CreativeWorkSeries"></see></summary>
    let CreativeWorkSeries = _prefix "CreativeWorkSeries"
    /// <summary>
    /// A bookstore.
    /// <see href="https://schema.org/BookStore"></see></summary>
    let BookStore = _prefix "BookStore"
    /// <summary>
    /// An agent bookmarks/flags/labels/tags/marks an object.
    /// <see href="https://schema.org/BookmarkAction"></see></summary>
    let BookmarkAction = _prefix "BookmarkAction"
    /// <summary>
    /// Boolean: True or False.
    /// <see href="https://schema.org/Boolean"></see></summary>
    let Boolean = _prefix "Boolean"
    /// <summary>
    /// The basic data types such as Integers, Strings, etc.
    /// <see href="https://schema.org/DataType"></see></summary>
    let DataType = _prefix "DataType"
    /// <summary>
    /// The act of obtaining an object under an agreement to return it at a later date. Reciprocal of LendAction.\n\nRelated actions:\n\n* [[LendAction]]: Reciprocal of BorrowAction.
    /// <see href="https://schema.org/BorrowAction"></see></summary>
    let BorrowAction = _prefix "BorrowAction"
    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// <see href="https://schema.org/TransferAction"></see></summary>
    let TransferAction = _prefix "TransferAction"
    /// <summary>
    /// A bowling alley.
    /// <see href="https://schema.org/BowlingAlley"></see></summary>
    let BowlingAlley = _prefix "BowlingAlley"
    /// <summary>
    /// A sports location, such as a playing field.
    /// <see href="https://schema.org/SportsActivityLocation"></see></summary>
    let SportsActivityLocation = _prefix "SportsActivityLocation"
    /// <summary>
    /// Any anatomical structure which pertains to the soft nervous tissue functioning as the coordinating center of sensation and intellectual and nervous activity.
    /// <see href="https://schema.org/BrainStructure"></see></summary>
    let BrainStructure = _prefix "BrainStructure"
    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// <see href="https://schema.org/Brand"></see></summary>
    let Brand = _prefix "Brand"
    /// <summary>
    /// A BreadcrumbList is an ItemList consisting of a chain of linked Web pages, typically described using at least their URL and their name, and typically ending with the current page.\n\nThe [[position]] property is used to reconstruct the order of the items in a BreadcrumbList. The convention is that a breadcrumb list has an [[itemListOrder]] of [[ItemListOrderAscending]] (lower values listed first), and that the first items in this list correspond to the "top" or beginning of the breadcrumb trail, e.g. with a site or section homepage. The specific values of 'position' are not assigned meaning for a BreadcrumbList, but they should be integers, e.g. beginning with '1' for the first item in the list.
    ///
    /// <see href="https://schema.org/BreadcrumbList"></see></summary>
    let BreadcrumbList = _prefix "BreadcrumbList"
    /// <summary>
    /// A list of items of any sort&amp;#x2014;for example, Top 10 Movies About Weathermen, or Top 100 Party Songs. Not to be confused with HTML lists, which are often used only for formatting.
    /// <see href="https://schema.org/ItemList"></see></summary>
    let ItemList = _prefix "ItemList"
    /// <summary>
    /// Brewery.
    /// <see href="https://schema.org/Brewery"></see></summary>
    let Brewery = _prefix "Brewery"
    /// <summary>
    /// A bridge.
    /// <see href="https://schema.org/Bridge"></see></summary>
    let Bridge = _prefix "Bridge"
    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// <see href="https://schema.org/BroadcastChannel"></see></summary>
    let BroadcastChannel = _prefix "BroadcastChannel"
    /// <summary>
    /// An over the air or online broadcast event.
    /// <see href="https://schema.org/BroadcastEvent"></see></summary>
    let BroadcastEvent = _prefix "BroadcastEvent"
    /// <summary>
    /// A PublicationEvent corresponds indifferently to the event of publication for a CreativeWork of any type, e.g. a broadcast event, an on-demand event, a book/journal publication via a variety of delivery media.
    /// <see href="https://schema.org/PublicationEvent"></see></summary>
    let PublicationEvent = _prefix "PublicationEvent"
    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// <see href="https://schema.org/BroadcastFrequencySpecification"></see></summary>
    let BroadcastFrequencySpecification = _prefix "BroadcastFrequencySpecification"
    /// <summary>
    /// BroadcastRelease.
    /// <see href="https://schema.org/BroadcastRelease"></see></summary>
    let BroadcastRelease = _prefix "BroadcastRelease"
    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// <see href="https://schema.org/BroadcastService"></see></summary>
    let BroadcastService = _prefix "BroadcastService"
    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// <see href="https://schema.org/Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// An account that allows an investor to deposit funds and place investment orders with a licensed broker or brokerage firm.
    /// <see href="https://schema.org/BrokerageAccount"></see></summary>
    let BrokerageAccount = _prefix "BrokerageAccount"
    /// <summary>
    /// A type of financial product that typically requires the client to transfer funds to a financial service in return for potential beneficial financial return.
    /// <see href="https://schema.org/InvestmentOrDeposit"></see></summary>
    let InvestmentOrDeposit = _prefix "InvestmentOrDeposit"
    /// <summary>
    /// A Buddhist temple.
    /// <see href="https://schema.org/BuddhistTemple"></see></summary>
    let BuddhistTemple = _prefix "BuddhistTemple"
    /// <summary>
    /// Place of worship, such as a church, synagogue, or mosque.
    /// <see href="https://schema.org/PlaceOfWorship"></see></summary>
    let PlaceOfWorship = _prefix "PlaceOfWorship"
    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Coaches are luxury buses, usually in service for long distance travel.
    /// <see href="https://schema.org/BusOrCoach"></see></summary>
    let BusOrCoach = _prefix "BusOrCoach"
    /// <summary>
    /// A vehicle is a device that is designed or used to transport people or cargo over land, water, air, or through space.
    /// <see href="https://schema.org/Vehicle"></see></summary>
    let Vehicle = _prefix "Vehicle"
    /// <summary>
    /// A reservation for bus travel. \n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// <see href="https://schema.org/BusReservation"></see></summary>
    let BusReservation = _prefix "BusReservation"
    /// <summary>
    /// A bus station.
    /// <see href="https://schema.org/BusStation"></see></summary>
    let BusStation = _prefix "BusStation"
    /// <summary>
    /// A bus stop.
    /// <see href="https://schema.org/BusStop"></see></summary>
    let BusStop = _prefix "BusStop"
    /// <summary>
    /// A trip on a commercial bus line.
    /// <see href="https://schema.org/BusTrip"></see></summary>
    let BusTrip = _prefix "BusTrip"
    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// <see href="https://schema.org/BusinessAudience"></see></summary>
    let BusinessAudience = _prefix "BusinessAudience"
    /// <summary>
    /// A business entity type is a conceptual entity representing the legal form, the size, the main line of business, the position in the value chain, or any combination thereof, of an organization or business person.\n\nCommonly used values:\n\n* http://purl.org/goodrelations/v1#Business\n* http://purl.org/goodrelations/v1#Enduser\n* http://purl.org/goodrelations/v1#PublicInstitution\n* http://purl.org/goodrelations/v1#Reseller
    ///
    /// <see href="https://schema.org/BusinessEntityType"></see></summary>
    let BusinessEntityType = _prefix "BusinessEntityType"
    /// <summary>
    /// Event type: Business event.
    /// <see href="https://schema.org/BusinessEvent"></see></summary>
    let BusinessEvent = _prefix "BusinessEvent"
    /// <summary>
    /// An event happening at a certain time and location, such as a concert, lecture, or festival. Ticketing information may be added via the [[offers]] property. Repeated events may be structured as separate Event objects.
    /// <see href="https://schema.org/Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// The business function specifies the type of activity or access (i.e., the bundle of rights) offered by the organization or business person through the offer. Typical are sell, rental or lease, maintenance or repair, manufacture / produce, recycle / dispose, engineering / construction, or installation. Proprietary specifications of access rights are also instances of this class.\n\nCommonly used values:\n\n* http://purl.org/goodrelations/v1#ConstructionInstallation\n* http://purl.org/goodrelations/v1#Dispose\n* http://purl.org/goodrelations/v1#LeaseOut\n* http://purl.org/goodrelations/v1#Maintain\n* http://purl.org/goodrelations/v1#ProvideService\n* http://purl.org/goodrelations/v1#Repair\n* http://purl.org/goodrelations/v1#Sell\n* http://purl.org/goodrelations/v1#Buy
    ///
    /// <see href="https://schema.org/BusinessFunction"></see></summary>
    let BusinessFunction = _prefix "BusinessFunction"
    /// <summary>
    /// BusinessSupport: this is a benefit for supporting businesses.
    /// <see href="https://schema.org/BusinessSupport"></see></summary>
    let BusinessSupport = _prefix "BusinessSupport"
    /// <summary>
    /// The act of giving money to a seller in exchange for goods or services rendered. An agent buys an object, product, or service from a seller for a price. Reciprocal of SellAction.
    /// <see href="https://schema.org/BuyAction"></see></summary>
    let BuyAction = _prefix "BuyAction"
    /// <summary>
    /// The act of participating in an exchange of goods and services for monetary compensation. An agent trades an object, product or service with a participant in exchange for a one time or periodic payment.
    /// <see href="https://schema.org/TradeAction"></see></summary>
    let TradeAction = _prefix "TradeAction"
    /// <summary>
    /// Payment in advance by bank transfer, equivalent to &lt;code&gt;http://purl.org/goodrelations/v1#ByBankTransferInAdvance&lt;/code&gt;.
    /// <see href="https://schema.org/ByBankTransferInAdvance"></see></summary>
    let ByBankTransferInAdvance = _prefix "ByBankTransferInAdvance"
    /// <summary>
    /// The type of payment method, only for generic payment types, specific forms of payments, like card payment should be expressed using subclasses of PaymentMethod.
    /// <see href="https://schema.org/PaymentMethodType"></see></summary>
    let PaymentMethodType = _prefix "PaymentMethodType"
    /// <summary>
    /// Payment by invoice, typically after the goods were delivered, equivalent to &lt;code&gt;http://purl.org/goodrelations/v1#ByInvoice&lt;/code&gt;.
    /// <see href="https://schema.org/ByInvoice"></see></summary>
    let ByInvoice = _prefix "ByInvoice"
    /// <summary>
    /// A CDCPMDRecord is a data structure representing a record in a CDC tabular data format
    ///       used for hospital data reporting. See [documentation](/docs/cdc-covid.html) for details, and the linked CDC materials for authoritative
    ///       definitions used as the source here.
    ///
    /// <see href="https://schema.org/CDCPMDRecord"></see></summary>
    let CDCPMDRecord = _prefix "CDCPMDRecord"
    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// <see href="https://schema.org/StructuredValue"></see></summary>
    let StructuredValue = _prefix "StructuredValue"
    /// <summary>
    /// CDFormat.
    /// <see href="https://schema.org/CDFormat"></see></summary>
    let CDFormat = _prefix "CDFormat"
    /// <summary>
    /// Format of this release (the type of recording media used, i.e. compact disc, digital media, LP, etc.).
    /// <see href="https://schema.org/MusicReleaseFormatType"></see></summary>
    let MusicReleaseFormatType = _prefix "MusicReleaseFormatType"
    /// <summary>
    /// Cash on Delivery (COD) payment, equivalent to &lt;code&gt;http://purl.org/goodrelations/v1#COD&lt;/code&gt;.
    /// <see href="https://schema.org/COD"></see></summary>
    let COD = _prefix "COD"
    /// <summary>
    /// X-ray computed tomography imaging.
    /// <see href="https://schema.org/CT"></see></summary>
    let CT = _prefix "CT"
    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes. Enumerated type.
    /// <see href="https://schema.org/MedicalImagingTechnique"></see></summary>
    let MedicalImagingTechnique = _prefix "MedicalImagingTechnique"
    /// <summary>
    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    /// <see href="https://schema.org/CableOrSatelliteService"></see></summary>
    let CableOrSatelliteService = _prefix "CableOrSatelliteService"
    /// <summary>
    /// A cafe or coffee shop.
    /// <see href="https://schema.org/CafeOrCoffeeShop"></see></summary>
    let CafeOrCoffeeShop = _prefix "CafeOrCoffeeShop"
    /// <summary>
    /// A camping site, campsite, or [[Campground]] is a place used for overnight stay in the outdoors, typically containing individual [[CampingPitch]] locations. \n\n
    /// In British English a campsite is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites (source: Wikipedia, see [https://en.wikipedia.org/wiki/Campsite](https://en.wikipedia.org/wiki/Campsite)).\n\n
    ///
    /// See also the dedicated [document on the use of schema.org for marking up hotels and other forms of accommodations](/docs/hotels.html).
    ///
    /// <see href="https://schema.org/Campground"></see></summary>
    let Campground = _prefix "Campground"
    /// <summary>
    /// A [[CampingPitch]] is an individual place for overnight stay in the outdoors, typically being part of a larger camping site, or [[Campground]].\n\n
    /// In British English a campsite, or campground, is an area, usually divided into a number of pitches, where people can camp overnight using tents or camper vans or caravans; this British English use of the word is synonymous with the American English expression campground. In American English the term campsite generally means an area where an individual, family, group, or military unit can pitch a tent or park a camper; a campground may contain many campsites.
    /// (Source: Wikipedia, see [https://en.wikipedia.org/wiki/Campsite](https://en.wikipedia.org/wiki/Campsite).)\n\n
    /// See also the dedicated [document on the use of schema.org for marking up hotels and other forms of accommodations](/docs/hotels.html).
    ///
    /// <see href="https://schema.org/CampingPitch"></see></summary>
    let CampingPitch = _prefix "CampingPitch"
    /// <summary>
    /// A canal, like the Panama Canal.
    /// <see href="https://schema.org/Canal"></see></summary>
    let Canal = _prefix "Canal"
    /// <summary>
    /// The act of asserting that a future event/action is no longer going to happen.\n\nRelated actions:\n\n* [[ConfirmAction]]: The antonym of CancelAction.
    /// <see href="https://schema.org/CancelAction"></see></summary>
    let CancelAction = _prefix "CancelAction"
    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// <see href="https://schema.org/PlanAction"></see></summary>
    let PlanAction = _prefix "PlanAction"
    /// <summary>
    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    /// <see href="https://schema.org/Car"></see></summary>
    let Car = _prefix "Car"
    /// <summary>
    /// A value indicating a special usage of a car, e.g. commercial rental, driving school, or as a taxi.
    /// <see href="https://schema.org/CarUsageType"></see></summary>
    let CarUsageType = _prefix "CarUsageType"
    /// <summary>
    /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of heart and vasculature.
    /// <see href="https://schema.org/Cardiovascular"></see></summary>
    let Cardiovascular = _prefix "Cardiovascular"
    /// <summary>
    /// Cardiovascular system assessment with clinical examination.
    /// <see href="https://schema.org/CardiovascularExam"></see></summary>
    let CardiovascularExam = _prefix "CardiovascularExam"
    /// <summary>
    /// A case series (also known as a clinical series) is a medical research study that tracks patients with a known exposure given similar treatment or examines their medical records for exposure and outcome. A case series can be retrospective or prospective and usually involves a smaller number of patients than the more powerful case-control studies or randomized controlled trials. Case series may be consecutive or non-consecutive, depending on whether all cases presenting to the reporting authors over a period of time were included, or only a selection.
    /// <see href="https://schema.org/CaseSeries"></see></summary>
    let CaseSeries = _prefix "CaseSeries"
    /// <summary>
    /// Design models for observational medical studies. Enumerated type.
    /// <see href="https://schema.org/MedicalObservationalStudyDesign"></see></summary>
    let MedicalObservationalStudyDesign = _prefix "MedicalObservationalStudyDesign"
    /// <summary>
    /// Payment using cash, on premises, equivalent to &lt;code&gt;http://purl.org/goodrelations/v1#Cash&lt;/code&gt;.
    /// <see href="https://schema.org/Cash"></see></summary>
    let Cash = _prefix "Cash"
    /// <summary>
    /// A casino.
    /// <see href="https://schema.org/Casino"></see></summary>
    let Casino = _prefix "Casino"
    /// <summary>
    /// CassetteFormat.
    /// <see href="https://schema.org/CassetteFormat"></see></summary>
    let CassetteFormat = _prefix "CassetteFormat"
    /// <summary>
    /// A Category Code.
    /// <see href="https://schema.org/CategoryCode"></see></summary>
    let CategoryCode = _prefix "CategoryCode"
    /// <summary>
    /// A word, name, acronym, phrase, etc. with a formal definition. Often used in the context of category or subject classification, glossaries or dictionaries, product or creative work types, etc. Use the name property for the term being defined, use termCode if the term has an alpha-numeric code allocated, use description to provide the definition of the term. Use the about property to specify what the term is about.
    /// <see href="https://schema.org/DefinedTerm"></see></summary>
    let DefinedTerm = _prefix "DefinedTerm"
    /// <summary>
    /// A set of Category Code values.
    /// <see href="https://schema.org/CategoryCodeSet"></see></summary>
    let CategoryCodeSet = _prefix "CategoryCodeSet"
    /// <summary>
    /// A set of defined terms, for example a set of categories or a classification scheme, a glossary, dictionary or enumeration. Use the about property to specify what the term set is about.
    /// <see href="https://schema.org/DefinedTermSet"></see></summary>
    let DefinedTermSet = _prefix "DefinedTermSet"
    /// <summary>
    /// A Catholic church.
    /// <see href="https://schema.org/CatholicChurch"></see></summary>
    let CatholicChurch = _prefix "CatholicChurch"
    /// <summary>
    /// A church.
    /// <see href="https://schema.org/Church"></see></summary>
    let Church = _prefix "Church"
    /// <summary>
    /// Information about the causes and main actions that gave rise to the topic.
    /// <see href="https://schema.org/CausesHealthAspect"></see></summary>
    let CausesHealthAspect = _prefix "CausesHealthAspect"
    /// <summary>
    /// A graveyard.
    /// <see href="https://schema.org/Cemetery"></see></summary>
    let Cemetery = _prefix "Cemetery"
    /// <summary>
    /// A Certification is an official and authoritative statement about a subject, for example a product, service, person, or organization. A certification is typically issued by an indendent certification body, for example a professional organization or government. It formally attests certain characteristics about the subject, for example Organizations can be ISO certified, Food products can be certified Organic or Vegan, a Person can be a certified professional, a Place can be certified for food processing. There are certifications for many domains: regulatory, organizational, recycling, food, efficiency, educational, ecological, etc. A certification is a form of credential, as are accreditations and licenses. Mapped from the [gs1:CertificationDetails](https://www.gs1.org/voc/CertificationDetails) class in the GS1 Web Vocabulary.
    /// <see href="https://schema.org/Certification"></see></summary>
    let Certification = _prefix "Certification"
    /// <summary>
    /// Specifies that a certification is active.
    /// <see href="https://schema.org/CertificationActive"></see></summary>
    let CertificationActive = _prefix "CertificationActive"
    /// <summary>
    /// Enumerates the different statuses of a Certification (Active and Inactive).
    /// <see href="https://schema.org/CertificationStatusEnumeration"></see></summary>
    let CertificationStatusEnumeration = _prefix "CertificationStatusEnumeration"
    /// <summary>
    /// Specifies that a certification is inactive (no longer in effect).
    /// <see href="https://schema.org/CertificationInactive"></see></summary>
    let CertificationInactive = _prefix "CertificationInactive"
    /// <summary>
    /// One of the sections into which a book is divided. A chapter usually has a section number or a name.
    /// <see href="https://schema.org/Chapter"></see></summary>
    let Chapter = _prefix "Chapter"

    /// <summary>
    /// CharitableIncorporatedOrganization: Non-profit type referring to a Charitable Incorporated Organization (UK).
    /// <see href="https://schema.org/CharitableIncorporatedOrganization"></see></summary>
    let CharitableIncorporatedOrganization =
        _prefix "CharitableIncorporatedOrganization"

    /// <summary>
    /// UKNonprofitType: Non-profit organization type originating from the United Kingdom.
    /// <see href="https://schema.org/UKNonprofitType"></see></summary>
    let UKNonprofitType = _prefix "UKNonprofitType"
    /// <summary>
    /// An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.
    /// <see href="https://schema.org/CheckAction"></see></summary>
    let CheckAction = _prefix "CheckAction"
    /// <summary>
    /// The act of finding an object.\n\nRelated actions:\n\n* [[SearchAction]]: FindAction is generally lead by a SearchAction, but not necessarily.
    /// <see href="https://schema.org/FindAction"></see></summary>
    let FindAction = _prefix "FindAction"
    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their arrival by registering/confirming for a previously reserved service (e.g. flight check-in) or at a place (e.g. hotel), possibly resulting in a result (boarding pass, etc).\n\nRelated actions:\n\n* [[CheckOutAction]]: The antonym of CheckInAction.\n* [[ArriveAction]]: Unlike ArriveAction, CheckInAction implies that the agent is informing/confirming the start of a previously reserved service.\n* [[ConfirmAction]]: Unlike ConfirmAction, CheckInAction implies that the agent is informing/confirming the *start* of a previously reserved service rather than its validity/existence.
    /// <see href="https://schema.org/CheckInAction"></see></summary>
    let CheckInAction = _prefix "CheckInAction"
    /// <summary>
    /// Payment in advance by sending a check, equivalent to &lt;code&gt;http://purl.org/goodrelations/v1#CheckInAdvance&lt;/code&gt;.
    /// <see href="https://schema.org/CheckInAdvance"></see></summary>
    let CheckInAdvance = _prefix "CheckInAdvance"
    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their departure of a previously reserved service (e.g. flight check-in) or place (e.g. hotel).\n\nRelated actions:\n\n* [[CheckInAction]]: The antonym of CheckOutAction.\n* [[DepartAction]]: Unlike DepartAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.\n* [[CancelAction]]: Unlike CancelAction, CheckOutAction implies that the agent is informing/confirming the end of a previously reserved service.
    /// <see href="https://schema.org/CheckOutAction"></see></summary>
    let CheckOutAction = _prefix "CheckOutAction"
    /// <summary>
    /// Web page type: Checkout page.
    /// <see href="https://schema.org/CheckoutPage"></see></summary>
    let CheckoutPage = _prefix "CheckoutPage"
    /// <summary>
    /// A chemical substance is 'a portion of matter of constant composition, composed of molecular entities of the same type or of different types' (source: [ChEBI:59999](https://www.ebi.ac.uk/chebi/searchId.do?chebiId=59999)).
    /// <see href="https://schema.org/ChemicalSubstance"></see></summary>
    let ChemicalSubstance = _prefix "ChemicalSubstance"
    /// <summary>
    /// A Childcare center.
    /// <see href="https://schema.org/ChildCare"></see></summary>
    let ChildCare = _prefix "ChildCare"
    /// <summary>
    /// Event type: Children's event.
    /// <see href="https://schema.org/ChildrensEvent"></see></summary>
    let ChildrensEvent = _prefix "ChildrensEvent"
    /// <summary>
    /// A system of medicine focused on the relationship between the body's structure, mainly the spine, and its functioning.
    /// <see href="https://schema.org/Chiropractic"></see></summary>
    let Chiropractic = _prefix "Chiropractic"
    /// <summary>
    /// The act of expressing a preference from a set of options or a large or unbounded set of choices/options.
    /// <see href="https://schema.org/ChooseAction"></see></summary>
    let ChooseAction = _prefix "ChooseAction"
    /// <summary>
    /// A city or town.
    /// <see href="https://schema.org/City"></see></summary>
    let City = _prefix "City"
    /// <summary>
    /// A city hall.
    /// <see href="https://schema.org/CityHall"></see></summary>
    let CityHall = _prefix "CityHall"
    /// <summary>
    /// A government building.
    /// <see href="https://schema.org/GovernmentBuilding"></see></summary>
    let GovernmentBuilding = _prefix "GovernmentBuilding"
    /// <summary>
    /// A [[Claim]] in Schema.org represents a specific, factually-oriented claim that could be the [[itemReviewed]] in a [[ClaimReview]]. The content of a claim can be summarized with the [[text]] property. Variations on well known claims can have their common identity indicated via [[sameAs]] links, and summarized with a [[name]]. Ideally, a [[Claim]] description includes enough contextual information to minimize the risk of ambiguity or inclarity. In practice, many claims are better understood in the context in which they appear or the interpretations provided by claim reviews.
    ///
    ///   Beyond [[ClaimReview]], the Claim type can be associated with related creative works - for example a [[ScholarlyArticle]] or [[Question]] might be [[about]] some [[Claim]].
    ///
    ///   At this time, Schema.org does not define any types of relationship between claims. This is a natural area for future exploration.
    ///
    /// <see href="https://schema.org/Claim"></see></summary>
    let Claim = _prefix "Claim"
    /// <summary>
    /// A fact-checking review of claims made (or reported) in some creative work (referenced via itemReviewed).
    /// <see href="https://schema.org/ClaimReview"></see></summary>
    let ClaimReview = _prefix "ClaimReview"
    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// <see href="https://schema.org/Review"></see></summary>
    let Review = _prefix "Review"
    /// <summary>
    /// A class, also often called a 'Type'; equivalent to rdfs:Class.
    /// <see href="https://schema.org/Class"></see></summary>
    let Class = _prefix "Class"
    /// <summary>
    /// Represents the cleaning fee part of the total price for an offered product, for example a vacation rental.
    /// <see href="https://schema.org/CleaningFee"></see></summary>
    let CleaningFee = _prefix "CleaningFee"
    /// <summary>
    /// Medical clinicians, including practicing physicians and other medical professionals involved in clinical practice.
    /// <see href="https://schema.org/Clinician"></see></summary>
    let Clinician = _prefix "Clinician"
    /// <summary>
    /// Target audiences types for medical web pages. Enumerated type.
    /// <see href="https://schema.org/MedicalAudienceType"></see></summary>
    let MedicalAudienceType = _prefix "MedicalAudienceType"
    /// <summary>
    /// A short TV or radio program or a segment/part of a program.
    /// <see href="https://schema.org/Clip"></see></summary>
    let Clip = _prefix "Clip"
    /// <summary>
    /// A clothing store.
    /// <see href="https://schema.org/ClothingStore"></see></summary>
    let ClothingStore = _prefix "ClothingStore"
    /// <summary>
    /// Play mode: CoOp. Co-operative games, where you play on the same team with friends.
    /// <see href="https://schema.org/CoOp"></see></summary>
    let CoOp = _prefix "CoOp"
    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.
    /// <see href="https://schema.org/GamePlayMode"></see></summary>
    let GamePlayMode = _prefix "GamePlayMode"
    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// <see href="https://schema.org/Code"></see></summary>
    let Code = _prefix "Code"
    /// <summary>
    /// Relates a term (i.e. a property, class or enumeration) to one that supersedes it.
    /// <see href="https://schema.org/supersededBy"></see></summary>
    let supersededBy = _prefix "supersededBy"
    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// <see href="https://schema.org/SoftwareSourceCode"></see></summary>
    let SoftwareSourceCode = _prefix "SoftwareSourceCode"
    /// <summary>
    /// Also known as a panel study. A cohort study is a form of longitudinal study used in medicine and social science. It is one type of study design and should be compared with a cross-sectional study.  A cohort is a group of people who share a common characteristic or experience within a defined period (e.g., are born, leave school, lose their job, are exposed to a drug or a vaccine, etc.). The comparison group may be the general population from which the cohort is drawn, or it may be another cohort of persons thought to have had little or no exposure to the substance under investigation, but otherwise similar. Alternatively, subgroups within the cohort may be compared with each other.
    /// <see href="https://schema.org/CohortStudy"></see></summary>
    let CohortStudy = _prefix "CohortStudy"
    /// <summary>
    /// A collection of items, e.g. creative works or products.
    /// <see href="https://schema.org/Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// Web page type: Collection page.
    /// <see href="https://schema.org/CollectionPage"></see></summary>
    let CollectionPage = _prefix "CollectionPage"
    /// <summary>
    /// A college, university, or other third-level educational institution.
    /// <see href="https://schema.org/CollegeOrUniversity"></see></summary>
    let CollegeOrUniversity = _prefix "CollegeOrUniversity"
    /// <summary>
    /// An educational organization.
    /// <see href="https://schema.org/EducationalOrganization"></see></summary>
    let EducationalOrganization = _prefix "EducationalOrganization"
    /// <summary>
    /// A comedy club.
    /// <see href="https://schema.org/ComedyClub"></see></summary>
    let ComedyClub = _prefix "ComedyClub"
    /// <summary>
    /// Event type: Comedy event.
    /// <see href="https://schema.org/ComedyEvent"></see></summary>
    let ComedyEvent = _prefix "ComedyEvent"
    /// <summary>
    /// The artwork on the cover of a comic.
    /// <see href="https://schema.org/ComicCoverArt"></see></summary>
    let ComicCoverArt = _prefix "ComicCoverArt"
    /// <summary>
    /// The term "story" is any indivisible, re-printable
    ///     	unit of a comic, including the interior stories, covers, and backmatter. Most
    ///     	comics have at least two stories: a cover (ComicCoverArt) and an interior story.
    /// <see href="https://schema.org/ComicStory"></see></summary>
    let ComicStory = _prefix "ComicStory"
    /// <summary>
    /// The artwork on the outer surface of a CreativeWork.
    /// <see href="https://schema.org/CoverArt"></see></summary>
    let CoverArt = _prefix "CoverArt"
    /// <summary>
    /// Individual comic issues are serially published as
    ///     	part of a larger series. For the sake of consistency, even one-shot issues
    ///     	belong to a series comprised of a single issue. All comic issues can be
    ///     	uniquely identified by: the combination of the name and volume number of the
    ///     	series to which the issue belongs; the issue number; and the variant
    ///     	description of the issue (if any).
    /// <see href="https://schema.org/ComicIssue"></see></summary>
    let ComicIssue = _prefix "ComicIssue"
    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// <see href="https://schema.org/PublicationIssue"></see></summary>
    let PublicationIssue = _prefix "PublicationIssue"
    /// <summary>
    /// A sequential publication of comic stories under a
    ///     	unifying title, for example "The Amazing Spider-Man" or "Groo the
    ///     	Wanderer".
    /// <see href="https://schema.org/ComicSeries"></see></summary>
    let ComicSeries = _prefix "ComicSeries"
    /// <summary>
    /// A publication in any medium issued in successive parts bearing numerical or chronological designations and intended to continue indefinitely, such as a magazine, scholarly journal, or newspaper.\n\nSee also [blog post](https://blog.schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// <see href="https://schema.org/Periodical"></see></summary>
    let Periodical = _prefix "Periodical"
    /// <summary>
    /// The act of generating a comment about a subject.
    /// <see href="https://schema.org/CommentAction"></see></summary>
    let CommentAction = _prefix "CommentAction"
    /// <summary>
    /// Permission to add comments to the document.
    /// <see href="https://schema.org/CommentPermission"></see></summary>
    let CommentPermission = _prefix "CommentPermission"
    /// <summary>
    /// A type of permission which can be granted for accessing a digital document.
    /// <see href="https://schema.org/DigitalDocumentPermissionType"></see></summary>
    let DigitalDocumentPermissionType = _prefix "DigitalDocumentPermissionType"
    /// <summary>
    /// A field of public health focusing on improving health characteristics of a defined population in relation with their geographical or environment areas.
    /// <see href="https://schema.org/CommunityHealth"></see></summary>
    let CommunityHealth = _prefix "CommunityHealth"
    /// <summary>
    /// A particular physical or virtual business of an organization for medical purposes. Examples of MedicalBusiness include different businesses run by health professionals.
    /// <see href="https://schema.org/MedicalBusiness"></see></summary>
    let MedicalBusiness = _prefix "MedicalBusiness"
    /// <summary>
    /// CompilationAlbum.
    /// <see href="https://schema.org/CompilationAlbum"></see></summary>
    let CompilationAlbum = _prefix "CompilationAlbum"
    /// <summary>
    /// Classification of the album by its type of content: soundtrack, live album, studio album, etc.
    /// <see href="https://schema.org/MusicAlbumProductionType"></see></summary>
    let MusicAlbumProductionType = _prefix "MusicAlbumProductionType"
    /// <summary>
    /// A [[CompleteDataFeed]] is a [[DataFeed]] whose standard representation includes content for every item currently in the feed.
    ///
    /// This is the equivalent of Atom's element as defined in Feed Paging and Archiving [RFC 5005](https://tools.ietf.org/html/rfc5005), for example (and as defined for Atom), when using data from a feed that represents a collection of items that varies over time (e.g. "Top Twenty Records") there is no need to have newer entries mixed in alongside older, obsolete entries. By marking this feed as a CompleteDataFeed, old entries can be safely discarded when the feed is refreshed, since we can assume the feed has provided descriptions for all current items.
    /// <see href="https://schema.org/CompleteDataFeed"></see></summary>
    let CompleteDataFeed = _prefix "CompleteDataFeed"
    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// <see href="https://schema.org/DataFeed"></see></summary>
    let DataFeed = _prefix "DataFeed"
    /// <summary>
    /// Completed.
    /// <see href="https://schema.org/Completed"></see></summary>
    let Completed = _prefix "Completed"
    /// <summary>
    /// An action that has already taken place.
    /// <see href="https://schema.org/CompletedActionStatus"></see></summary>
    let CompletedActionStatus = _prefix "CompletedActionStatus"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/compositeCapture"&gt;composite capture&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/CompositeCaptureDigitalSource"></see></summary>
    let CompositeCaptureDigitalSource = _prefix "CompositeCaptureDigitalSource"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/algorithmicMedia"&gt;algorithmic media&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/CompositeDigitalSource"></see></summary>
    let CompositeDigitalSource = _prefix "CompositeDigitalSource"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/compositeSynthetic"&gt;composite synthetic&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/CompositeSyntheticDigitalSource"></see></summary>
    let CompositeSyntheticDigitalSource = _prefix "CompositeSyntheticDigitalSource"

    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/compositeWithTrainedAlgorithmicMedia"&gt;composite with trained algorithmic media&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/CompositeWithTrainedAlgorithmicMediaDigitalSource"></see></summary>
    let CompositeWithTrainedAlgorithmicMediaDigitalSource =
        _prefix "CompositeWithTrainedAlgorithmicMediaDigitalSource"

    /// <summary>
    /// A compound price specification is one that bundles multiple prices that all apply in combination for different dimensions of consumption. Use the name property of the attached unit price specification for indicating the dimension of a price component (e.g. "electricity" or "final cleaning").
    /// <see href="https://schema.org/CompoundPriceSpecification"></see></summary>
    let CompoundPriceSpecification = _prefix "CompoundPriceSpecification"
    /// <summary>
    /// A structured value representing a price or price range. Typically, only the subclasses of this type are used for markup. It is recommended to use [[MonetaryAmount]] to describe independent amounts of money such as a salary, credit card limits, etc.
    /// <see href="https://schema.org/PriceSpecification"></see></summary>
    let PriceSpecification = _prefix "PriceSpecification"
    /// <summary>
    /// This type covers computer programming languages such as Scheme and Lisp, as well as other language-like computer representations. Natural languages are best represented with the [[Language]] type.
    /// <see href="https://schema.org/ComputerLanguage"></see></summary>
    let ComputerLanguage = _prefix "ComputerLanguage"
    /// <summary>
    /// A computer store.
    /// <see href="https://schema.org/ComputerStore"></see></summary>
    let ComputerStore = _prefix "ComputerStore"
    /// <summary>
    /// Event type: Conference event.
    /// <see href="https://schema.org/ConferenceEvent"></see></summary>
    let ConferenceEvent = _prefix "ConferenceEvent"
    /// <summary>
    /// The act of notifying someone that a future event/action is going to happen as expected.\n\nRelated actions:\n\n* [[CancelAction]]: The antonym of ConfirmAction.
    /// <see href="https://schema.org/ConfirmAction"></see></summary>
    let ConfirmAction = _prefix "ConfirmAction"
    /// <summary>
    /// The act of notifying someone of information pertinent to them, with no expectation of a response.
    /// <see href="https://schema.org/InformAction"></see></summary>
    let InformAction = _prefix "InformAction"
    /// <summary>
    /// A Consortium is a membership [[Organization]] whose members are typically Organizations.
    /// <see href="https://schema.org/Consortium"></see></summary>
    let Consortium = _prefix "Consortium"
    /// <summary>
    /// The ConstraintNode type is provided to support usecases in which a node in a structured data graph is described with properties which appear to describe a single entity, but are being used in a situation where they serve a more abstract purpose. A [[ConstraintNode]] can be described using [[constraintProperty]] and [[numConstraints]]. These constraint properties can serve a
    ///     variety of purposes, and their values may sometimes be understood to indicate sets of possible values rather than single, exact and specific values.
    /// <see href="https://schema.org/ConstraintNode"></see></summary>
    let ConstraintNode = _prefix "ConstraintNode"
    /// <summary>
    /// The act of ingesting information/resources/food.
    /// <see href="https://schema.org/ConsumeAction"></see></summary>
    let ConsumeAction = _prefix "ConsumeAction"
    /// <summary>
    /// Web page type: Contact page.
    /// <see href="https://schema.org/ContactPage"></see></summary>
    let ContactPage = _prefix "ContactPage"
    /// <summary>
    /// A contact point&amp;#x2014;for example, a Customer Complaints department.
    /// <see href="https://schema.org/ContactPoint"></see></summary>
    let ContactPoint = _prefix "ContactPoint"
    /// <summary>
    /// Enumerated options related to a ContactPoint.
    /// <see href="https://schema.org/ContactPointOption"></see></summary>
    let ContactPointOption = _prefix "ContactPointOption"
    /// <summary>
    /// Content about contagion mechanisms and contagiousness information over the topic.
    /// <see href="https://schema.org/ContagiousnessHealthAspect"></see></summary>
    let ContagiousnessHealthAspect = _prefix "ContagiousnessHealthAspect"
    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// <see href="https://schema.org/Continent"></see></summary>
    let Continent = _prefix "Continent"
    /// <summary>
    /// A convenience store.
    /// <see href="https://schema.org/ConvenienceStore"></see></summary>
    let ConvenienceStore = _prefix "ConvenienceStore"
    /// <summary>
    /// One or more messages between organizations or people on a particular topic. Individual messages can be linked to the conversation with isPartOf or hasPart properties.
    /// <see href="https://schema.org/Conversation"></see></summary>
    let Conversation = _prefix "Conversation"
    /// <summary>
    /// The act of producing/preparing food.
    /// <see href="https://schema.org/CookAction"></see></summary>
    let CookAction = _prefix "CookAction"
    /// <summary>
    /// The act of deliberately creating/producing/generating/building a result out of the agent.
    /// <see href="https://schema.org/CreateAction"></see></summary>
    let CreateAction = _prefix "CreateAction"
    /// <summary>
    /// An organization that is a joint project of multiple organizations or persons.
    /// <see href="https://schema.org/Cooperative"></see></summary>
    let Cooperative = _prefix "Cooperative"
    /// <summary>
    /// Organization: A business corporation.
    /// <see href="https://schema.org/Corporation"></see></summary>
    let Corporation = _prefix "Corporation"
    /// <summary>
    /// A [[comment]] that corrects [[CreativeWork]].
    /// <see href="https://schema.org/CorrectionComment"></see></summary>
    let CorrectionComment = _prefix "CorrectionComment"
    /// <summary>
    /// A country.
    /// <see href="https://schema.org/Country"></see></summary>
    let Country = _prefix "Country"
    /// <summary>
    /// A description of an educational course which may be offered as distinct instances which take place at different times or take place at different locations, or be offered through different media or modes of study. An educational course is a sequence of one or more educational events and/or creative works which aims to build knowledge, competence or ability of learners.
    /// <see href="https://schema.org/Course"></see></summary>
    let Course = _prefix "Course"
    /// <summary>
    /// The LearningResource type can be used to indicate [[CreativeWork]]s (whether physical or digital) that have a particular and explicit orientation towards learning, education, skill acquisition, and other educational purposes.
    ///
    /// [[LearningResource]] is expected to be used as an addition to a primary type such as [[Book]], [[VideoObject]], [[Product]] etc.
    ///
    /// [[EducationEvent]] serves a similar purpose for event-like things (e.g. a [[Trip]]). A [[LearningResource]] may be created as a result of an [[EducationEvent]], for example by recording one.
    /// <see href="https://schema.org/LearningResource"></see></summary>
    let LearningResource = _prefix "LearningResource"
    /// <summary>
    /// An instance of a [[Course]] which is distinct from other instances because it is offered at a different time or location or through different media or modes of study or to a specific section of students.
    /// <see href="https://schema.org/CourseInstance"></see></summary>
    let CourseInstance = _prefix "CourseInstance"
    /// <summary>
    /// A courthouse.
    /// <see href="https://schema.org/Courthouse"></see></summary>
    let Courthouse = _prefix "Courthouse"
    /// <summary>
    /// A work of art that is primarily visual in character.
    /// <see href="https://schema.org/VisualArtwork"></see></summary>
    let VisualArtwork = _prefix "VisualArtwork"
    /// <summary>
    /// A CovidTestingFacility is a [[MedicalClinic]] where testing for the COVID-19 Coronavirus
    ///       disease is available. If the facility is being made available from an established [[Pharmacy]], [[Hotel]], or other
    ///       non-medical organization, multiple types can be listed. This makes it easier to re-use existing schema.org information
    ///       about that place, e.g. contact info, address, opening hours. Note that in an emergency, such information may not always be reliable.
    ///
    /// <see href="https://schema.org/CovidTestingFacility"></see></summary>
    let CovidTestingFacility = _prefix "CovidTestingFacility"
    /// <summary>
    /// A facility, often associated with a hospital or medical school, that is devoted to the specific diagnosis and/or healthcare. Previously limited to outpatients but with evolution it may be open to inpatients as well.
    /// <see href="https://schema.org/MedicalClinic"></see></summary>
    let MedicalClinic = _prefix "MedicalClinic"
    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// <see href="https://schema.org/CreativeWorkSeason"></see></summary>
    let CreativeWorkSeason = _prefix "CreativeWorkSeason"
    /// <summary>
    /// A Series in schema.org is a group of related items, typically but not necessarily of the same kind. See also [[CreativeWorkSeries]], [[EventSeries]].
    /// <see href="https://schema.org/Series"></see></summary>
    let Series = _prefix "Series"
    /// <summary>
    /// A credential is a certificate that is used to verify the identity of a person or entity.
    /// <see href="https://schema.org/Credential"></see></summary>
    let Credential = _prefix "Credential"
    /// <summary>
    /// A card payment method of a particular brand or name.  Used to mark up a particular payment method and/or the financial product/service that supplies the card account.\n\nCommonly used values:\n\n* http://purl.org/goodrelations/v1#AmericanExpress\n* http://purl.org/goodrelations/v1#DinersClub\n* http://purl.org/goodrelations/v1#Discover\n* http://purl.org/goodrelations/v1#JCB\n* http://purl.org/goodrelations/v1#MasterCard\n* http://purl.org/goodrelations/v1#VISA
    ///
    /// <see href="https://schema.org/CreditCard"></see></summary>
    let CreditCard = _prefix "CreditCard"
    /// <summary>
    /// A financial product for the loaning of an amount of money, or line of credit, under agreed terms and charges.
    /// <see href="https://schema.org/LoanOrCredit"></see></summary>
    let LoanOrCredit = _prefix "LoanOrCredit"
    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// <see href="https://schema.org/PaymentCard"></see></summary>
    let PaymentCard = _prefix "PaymentCard"
    /// <summary>
    /// A crematorium.
    /// <see href="https://schema.org/Crematorium"></see></summary>
    let Crematorium = _prefix "Crematorium"
    /// <summary>
    /// A [[CriticReview]] is a more specialized form of Review written or published by a source that is recognized for its reviewing activities. These can include online columns, travel and food guides, TV and radio shows, blogs and other independent Web sites. [[CriticReview]]s are typically more in-depth and professionally written. For simpler, casually written user/visitor/viewer/customer reviews, it is more appropriate to use the [[UserReview]] type. Review aggregator sites such as Metacritic already separate out the site's user reviews from selected critic reviews that originate from third-party sources.
    /// <see href="https://schema.org/CriticReview"></see></summary>
    let CriticReview = _prefix "CriticReview"
    /// <summary>
    /// Studies carried out on pre-existing data (usually from 'snapshot' surveys), such as that collected by the Census Bureau. Sometimes called Prevalence Studies.
    /// <see href="https://schema.org/CrossSectional"></see></summary>
    let CrossSectional = _prefix "CrossSectional"
    /// <summary>
    /// Text representing a CSS selector.
    /// <see href="https://schema.org/CssSelectorType"></see></summary>
    let CssSelectorType = _prefix "CssSelectorType"
    /// <summary>
    /// Data type: Text.
    /// <see href="https://schema.org/Text"></see></summary>
    let Text = _prefix "Text"
    /// <summary>
    /// A service to convert funds from one currency to another currency.
    /// <see href="https://schema.org/CurrencyConversionService"></see></summary>
    let CurrencyConversionService = _prefix "CurrencyConversionService"
    /// <summary>
    /// An alternative, closely-related condition typically considered later in the differential diagnosis process along with the signs that are used to distinguish it.
    /// <see href="https://schema.org/DDxElement"></see></summary>
    let DDxElement = _prefix "DDxElement"
    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things in the medical space.
    /// <see href="https://schema.org/MedicalIntangible"></see></summary>
    let MedicalIntangible = _prefix "MedicalIntangible"
    /// <summary>
    /// DECooperativeCharity: Non-profit type referring to a charitable Cooperative (German Genossenschaft) that has been recognized by the tax authorities as a charitable non-profit.
    /// <see href="https://schema.org/DECooperativeCharity"></see></summary>
    let DECooperativeCharity = _prefix "DECooperativeCharity"
    /// <summary>
    /// DENonprofitType: Non-profit organization type originating from Germany in accordance with article 52 of the German fiscal code (Abgabenverordnung or AO).
    /// <see href="https://schema.org/DENonprofitType"></see></summary>
    let DENonprofitType = _prefix "DENonprofitType"
    /// <summary>
    /// DEFoundationCharity: Non-profit type referring to a charitable Foundation (German Stiftung) that has been recognized by the tax authorities as a charitable non-profit.
    /// <see href="https://schema.org/DEFoundationCharity"></see></summary>
    let DEFoundationCharity = _prefix "DEFoundationCharity"
    /// <summary>
    /// DEJointStockCompanyCharity: Non-profit type referring to a charitable Joint Stock Company (German gAG gemeinnützige Aktiengesellschaft) that has been recognized by the tax authorities as a charitable non-profit.
    /// <see href="https://schema.org/DEJointStockCompanyCharity"></see></summary>
    let DEJointStockCompanyCharity = _prefix "DEJointStockCompanyCharity"
    /// <summary>
    /// DELimitedLiabilityCharity: Non-profit type referring to a charitable Common Stock Company (German gGmbH or gemeinnützige Gesellschaft mit beschränkter Haftung) that has been recognized by the tax authorities as a charitable non-profit.
    /// <see href="https://schema.org/DELimitedLiabilityCharity"></see></summary>
    let DELimitedLiabilityCharity = _prefix "DELimitedLiabilityCharity"
    /// <summary>
    /// NonprofitType enumerates several kinds of official non-profit types of which a non-profit organization can be.
    /// <see href="https://schema.org/NonprofitType"></see></summary>
    let NonprofitType = _prefix "NonprofitType"
    /// <summary>
    /// DENotRegisteredAssociationCharity: Non-profit type referring to a charitable association that is not registered with the German association register (gemeinnütziger Verein) and has been recognized by the tax authorities as a charitable non-profit.
    /// <see href="https://schema.org/DENotRegisteredAssociationCharity"></see></summary>
    let DENotRegisteredAssociationCharity = _prefix "DENotRegisteredAssociationCharity"
    /// <summary>
    /// DEPublicCharity: Non-profit type referring to a charitable government owned juridical person (German Körperschaft öffentlichen Rechts) that has been recognized by the tax authorities as a charitable non-profit.
    /// <see href="https://schema.org/DEPublicCharity"></see></summary>
    let DEPublicCharity = _prefix "DEPublicCharity"
    /// <summary>
    /// DERegisteredAssociationCharity: Non-profit type referring to a charitable association that is registered with the German association register (german gemeinnütziger e.v. or gemeinnütziger eingetragener Verein) and has been recognized by the tax authorities as a charitable non-profit.
    /// <see href="https://schema.org/DERegisteredAssociationCharity"></see></summary>
    let DERegisteredAssociationCharity = _prefix "DERegisteredAssociationCharity"
    /// <summary>
    /// DJMixAlbum.
    /// <see href="https://schema.org/DJMixAlbum"></see></summary>
    let DJMixAlbum = _prefix "DJMixAlbum"
    /// <summary>
    /// DVDFormat.
    /// <see href="https://schema.org/DVDFormat"></see></summary>
    let DVDFormat = _prefix "DVDFormat"
    /// <summary>
    /// Indicates that the item is damaged.
    /// <see href="https://schema.org/DamagedCondition"></see></summary>
    let DamagedCondition = _prefix "DamagedCondition"
    /// <summary>
    /// A list of possible conditions for the item.
    /// <see href="https://schema.org/OfferItemCondition"></see></summary>
    let OfferItemCondition = _prefix "OfferItemCondition"
    /// <summary>
    /// Event type: A social dance.
    /// <see href="https://schema.org/DanceEvent"></see></summary>
    let DanceEvent = _prefix "DanceEvent"
    /// <summary>
    /// A dance group&amp;#x2014;for example, the Alvin Ailey Dance Theater or Riverdance.
    /// <see href="https://schema.org/DanceGroup"></see></summary>
    let DanceGroup = _prefix "DanceGroup"
    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// <see href="https://schema.org/PerformingGroup"></see></summary>
    let PerformingGroup = _prefix "PerformingGroup"
    /// <summary>
    /// The item is dangerous and requires careful handling and/or special training of the user. See also the [UN Model Classification](https://unece.org/DAM/trans/danger/publi/unrec/rev17/English/02EREv17_Part2.pdf) defining the 9 classes of dangerous goods such as explosives, gases, flammables, and more.
    /// <see href="https://schema.org/DangerousGoodConsideration"></see></summary>
    let DangerousGoodConsideration = _prefix "DangerousGoodConsideration"
    /// <summary>
    /// A collection of datasets.
    /// <see href="https://schema.org/DataCatalog"></see></summary>
    let DataCatalog = _prefix "DataCatalog"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/DatasetClass"></see>
    /// </summary>
    let ``docs/collab/DatasetClass`` = _prefix "docs/collab/DatasetClass"
    /// <summary>
    /// All or part of a [[Dataset]] in downloadable form.
    /// <see href="https://schema.org/DataDownload"></see></summary>
    let DataDownload = _prefix "DataDownload"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/dataDrivenMedia"&gt;data driven media&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/DataDrivenMediaDigitalSource"></see></summary>
    let DataDrivenMediaDigitalSource = _prefix "DataDrivenMediaDigitalSource"
    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// <see href="https://schema.org/Dataset"></see></summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    /// A single item within a larger data feed.
    /// <see href="https://schema.org/DataFeedItem"></see></summary>
    let DataFeedItem = _prefix "DataFeedItem"
    /// <summary>
    /// A date value in [ISO 8601 date format](http://en.wikipedia.org/wiki/ISO_8601).
    /// <see href="https://schema.org/Date"></see></summary>
    let Date = _prefix "Date"
    /// <summary>
    /// A combination of date and time of day in the form [-]CCYY-MM-DDThh:mm:ss[Z|(+|-)hh:mm] (see Chapter 5.4 of ISO 8601).
    /// <see href="https://schema.org/DateTime"></see></summary>
    let DateTime = _prefix "DateTime"
    /// <summary>
    /// A DatedMoneySpecification represents monetary values with optional start and end dates. For example, this could represent an employee's salary over a specific period of time. __Note:__ This type has been superseded by [[MonetaryAmount]], use of that type is recommended.
    /// <see href="https://schema.org/DatedMoneySpecification"></see></summary>
    let DatedMoneySpecification = _prefix "DatedMoneySpecification"
    /// <summary>
    /// A monetary value or range. This type can be used to describe an amount of money such as $50 USD, or a range as in describing a bank account being suitable for a balance between £1,000 and £1,000,000 GBP, or the value of a salary, etc. It is recommended to use [[PriceSpecification]] Types to describe the price of an Offer, Invoice, etc.
    /// <see href="https://schema.org/MonetaryAmount"></see></summary>
    let MonetaryAmount = _prefix "MonetaryAmount"
    /// <summary>
    /// The day of the week, e.g. used to specify to which day the opening hours of an OpeningHoursSpecification refer.
    ///
    /// Originally, URLs from [GoodRelations](http://purl.org/goodrelations/v1) were used (for [[Monday]], [[Tuesday]], [[Wednesday]], [[Thursday]], [[Friday]], [[Saturday]], [[Sunday]] plus a special entry for [[PublicHolidays]]); these have now been integrated directly into schema.org.
    ///
    /// <see href="https://schema.org/DayOfWeek"></see></summary>
    let DayOfWeek = _prefix "DayOfWeek"
    /// <summary>
    /// A day spa.
    /// <see href="https://schema.org/DaySpa"></see></summary>
    let DaySpa = _prefix "DaySpa"
    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// <see href="https://schema.org/DeactivateAction"></see></summary>
    let DeactivateAction = _prefix "DeactivateAction"
    /// <summary>
    /// Content coded 'missing context' in a [[MediaReview]], considered in the context of how it was published or shared.
    ///
    /// For a [[VideoObject]] to be 'missing context': Presenting unaltered video in an inaccurate manner that misrepresents the footage. For example, using incorrect dates or locations, altering the transcript or sharing brief clips from a longer video to mislead viewers. (A video rated 'original' can also be missing context.)
    ///
    /// For an [[ImageObject]] to be 'missing context': Presenting unaltered images in an inaccurate manner to misrepresent the image and mislead the viewer. For example, a common tactic is using an unaltered image but saying it came from a different time or place. (An image rated 'original' can also be missing context.)
    ///
    /// For an [[ImageObject]] with embedded text to be 'missing context': An unaltered image presented in an inaccurate manner to misrepresent the image and mislead the viewer. For example, a common tactic is using an unaltered image but saying it came from a different time or place. (An 'original' image with inaccurate text would generally fall in this category.)
    ///
    /// For an [[AudioObject]] to be 'missing context': Unaltered audio presented in an inaccurate manner that misrepresents it. For example, using incorrect dates or locations, or sharing brief clips from a longer recording to mislead viewers. (Audio rated “original” can also be missing context.)
    ///
    /// <see href="https://schema.org/DecontextualizedContent"></see></summary>
    let DecontextualizedContent = _prefix "DecontextualizedContent"

    /// <summary>
    ///  Codes for use with the [[mediaAuthenticityCategory]] property, indicating the authenticity of a media object (in the context of how it was published or shared). In general these codes are not mutually exclusive, although some combinations (such as 'original' versus 'transformed', 'edited' and 'staged') would be contradictory if applied in the same [[MediaReview]]. Note that the application of these codes is with regard to a piece of media shared or published in a particular context.
    /// <see href="https://schema.org/MediaManipulationRatingEnumeration"></see></summary>
    let MediaManipulationRatingEnumeration =
        _prefix "MediaManipulationRatingEnumeration"

    /// <summary>
    /// A defence establishment, such as an army or navy base.
    /// <see href="https://schema.org/DefenceEstablishment"></see></summary>
    let DefenceEstablishment = _prefix "DefenceEstablishment"
    /// <summary>
    /// A DefinedRegion is a geographic area defined by potentially arbitrary (rather than political, administrative or natural geographical) criteria. Properties are provided for defining a region by reference to sets of postal codes.
    ///
    /// Examples: a delivery destination when shopping. Region where regional pricing is configured.
    ///
    /// Requirement 1:
    /// Country: US
    /// States: "NY", "CA"
    ///
    /// Requirement 2:
    /// Country: US
    /// PostalCode Set: { [94000-94585], [97000, 97999], [13000, 13599]}
    /// { [12345, 12345], [78945, 78945], }
    /// Region = state, canton, prefecture, autonomous community...
    ///
    /// <see href="https://schema.org/DefinedRegion"></see></summary>
    let DefinedRegion = _prefix "DefinedRegion"
    /// <summary>
    /// Indicates a document for which the text is conclusively what the law says and is legally binding. (e.g. The digitally signed version of an Official Journal.)
    ///   Something "Definitive" is considered to be also [[AuthoritativeLegalValue]].
    /// <see href="https://schema.org/DefinitiveLegalValue"></see></summary>
    let DefinitiveLegalValue = _prefix "DefinitiveLegalValue"
    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// <see href="https://schema.org/DeleteAction"></see></summary>
    let DeleteAction = _prefix "DeleteAction"
    /// <summary>
    /// The price for the delivery of an offer using a particular delivery method.
    /// <see href="https://schema.org/DeliveryChargeSpecification"></see></summary>
    let DeliveryChargeSpecification = _prefix "DeliveryChargeSpecification"
    /// <summary>
    /// An event involving the delivery of an item.
    /// <see href="https://schema.org/DeliveryEvent"></see></summary>
    let DeliveryEvent = _prefix "DeliveryEvent"
    /// <summary>
    /// A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment chosen by the customer. Delivery methods are characterized by the means of transportation used, and by the organization or group that is the contracting party for the sending organization or person.\n\nCommonly used values:\n\n* http://purl.org/goodrelations/v1#DeliveryModeDirectDownload\n* http://purl.org/goodrelations/v1#DeliveryModeFreight\n* http://purl.org/goodrelations/v1#DeliveryModeMail\n* http://purl.org/goodrelations/v1#DeliveryModeOwnFleet\n* http://purl.org/goodrelations/v1#DeliveryModePickUp\n* http://purl.org/goodrelations/v1#DHL\n* http://purl.org/goodrelations/v1#FederalExpress\n* http://purl.org/goodrelations/v1#UPS
    ///
    /// <see href="https://schema.org/DeliveryMethod"></see></summary>
    let DeliveryMethod = _prefix "DeliveryMethod"
    /// <summary>
    /// A demand entity represents the public, not necessarily binding, not necessarily exclusive, announcement by an organization or person to seek a certain type of goods or services. For describing demand using this type, the very same properties used for Offer apply.
    /// <see href="https://schema.org/Demand"></see></summary>
    let Demand = _prefix "Demand"
    /// <summary>
    /// DemoAlbum.
    /// <see href="https://schema.org/DemoAlbum"></see></summary>
    let DemoAlbum = _prefix "DemoAlbum"
    /// <summary>
    /// Indicates demo game availability, i.e. a somehow limited demonstration of the full game.
    /// <see href="https://schema.org/DemoGameAvailability"></see></summary>
    let DemoGameAvailability = _prefix "DemoGameAvailability"
    /// <summary>
    /// For a [[VideoGame]], such as used with a [[PlayGameAction]], an enumeration of the kind of game availability offered.
    /// <see href="https://schema.org/GameAvailabilityEnumeration"></see></summary>
    let GameAvailabilityEnumeration = _prefix "GameAvailabilityEnumeration"
    /// <summary>
    /// A dentist.
    /// <see href="https://schema.org/Dentist"></see></summary>
    let Dentist = _prefix "Dentist"
    /// <summary>
    /// A medical organization (physical or not), such as hospital, institution or clinic.
    /// <see href="https://schema.org/MedicalOrganization"></see></summary>
    let MedicalOrganization = _prefix "MedicalOrganization"
    /// <summary>
    /// A branch of medicine that is involved in the dental care.
    /// <see href="https://schema.org/Dentistry"></see></summary>
    let Dentistry = _prefix "Dentistry"
    /// <summary>
    /// The act of  departing from a place. An agent departs from a fromLocation for a destination, optionally with participants.
    /// <see href="https://schema.org/DepartAction"></see></summary>
    let DepartAction = _prefix "DepartAction"
    /// <summary>
    /// A department store.
    /// <see href="https://schema.org/DepartmentStore"></see></summary>
    let DepartmentStore = _prefix "DepartmentStore"
    /// <summary>
    /// A type of Bank Account with a main purpose of depositing funds to gain interest or other benefits.
    /// <see href="https://schema.org/DepositAccount"></see></summary>
    let DepositAccount = _prefix "DepositAccount"
    /// <summary>
    /// Something relating to or practicing dermatology.
    /// <see href="https://schema.org/Dermatologic"></see></summary>
    let Dermatologic = _prefix "Dermatologic"
    /// <summary>
    /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of skin.
    /// <see href="https://schema.org/Dermatology"></see></summary>
    let Dermatology = _prefix "Dermatology"
    /// <summary>
    /// Represents the broad notion of 'desktop' browsers as a Web Platform.
    /// <see href="https://schema.org/DesktopWebPlatform"></see></summary>
    let DesktopWebPlatform = _prefix "DesktopWebPlatform"
    /// <summary>
    /// A diet appropriate for people with diabetes.
    /// <see href="https://schema.org/DiabeticDiet"></see></summary>
    let DiabeticDiet = _prefix "DiabeticDiet"
    /// <summary>
    /// A diet restricted to certain foods or preparations for cultural, religious, health or lifestyle reasons.
    /// <see href="https://schema.org/RestrictedDiet"></see></summary>
    let RestrictedDiet = _prefix "RestrictedDiet"
    /// <summary>
    /// A medical device used for diagnostic purposes.
    /// <see href="https://schema.org/Diagnostic"></see></summary>
    let Diagnostic = _prefix "Diagnostic"
    /// <summary>
    /// Categories of medical devices, organized by the purpose or intended use of the device.
    /// <see href="https://schema.org/MedicalDevicePurpose"></see></summary>
    let MedicalDevicePurpose = _prefix "MedicalDevicePurpose"
    /// <summary>
    /// A medical laboratory that offers on-site or off-site diagnostic services.
    /// <see href="https://schema.org/DiagnosticLab"></see></summary>
    let DiagnosticLab = _prefix "DiagnosticLab"
    /// <summary>
    /// A medical procedure intended primarily for diagnostic, as opposed to therapeutic, purposes.
    /// <see href="https://schema.org/DiagnosticProcedure"></see></summary>
    let DiagnosticProcedure = _prefix "DiagnosticProcedure"
    /// <summary>
    /// A process of care used in either a diagnostic, therapeutic, preventive or palliative capacity that relies on invasive (surgical), non-invasive, or other techniques.
    /// <see href="https://schema.org/MedicalProcedure"></see></summary>
    let MedicalProcedure = _prefix "MedicalProcedure"
    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// <see href="https://schema.org/Diet"></see></summary>
    let Diet = _prefix "Diet"
    /// <summary>
    /// A process of care involving exercise, changes to diet, fitness routines, and other lifestyle changes aimed at improving a health condition.
    /// <see href="https://schema.org/LifestyleModification"></see></summary>
    let LifestyleModification = _prefix "LifestyleModification"
    /// <summary>
    /// Dietetics and nutrition as a medical specialty.
    /// <see href="https://schema.org/DietNutrition"></see></summary>
    let DietNutrition = _prefix "DietNutrition"
    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// <see href="https://schema.org/DietarySupplement"></see></summary>
    let DietarySupplement = _prefix "DietarySupplement"
    /// <summary>
    /// Any offered product or service. For example: a pair of shoes; a concert ticket; the rental of a car; a haircut; or an episode of a TV show streamed online.
    /// <see href="https://schema.org/Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    /// Any matter of defined composition that has discrete existence, whose origin may be biological, mineral or chemical.
    /// <see href="https://schema.org/Substance"></see></summary>
    let Substance = _prefix "Substance"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/digitalArt"&gt;digital art&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/DigitalArtDigitalSource"></see></summary>
    let DigitalArtDigitalSource = _prefix "DigitalArtDigitalSource"
    /// <summary>
    /// DigitalAudioTapeFormat.
    /// <see href="https://schema.org/DigitalAudioTapeFormat"></see></summary>
    let DigitalAudioTapeFormat = _prefix "DigitalAudioTapeFormat"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/digitalCapture"&gt;digital capture&lt;/a&gt;&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/DigitalCaptureDigitalSource"></see></summary>
    let DigitalCaptureDigitalSource = _prefix "DigitalCaptureDigitalSource"
    /// <summary>
    /// An electronic file or document.
    /// <see href="https://schema.org/DigitalDocument"></see></summary>
    let DigitalDocument = _prefix "DigitalDocument"
    /// <summary>
    /// A permission for a particular person or group to access a particular file.
    /// <see href="https://schema.org/DigitalDocumentPermission"></see></summary>
    let DigitalDocumentPermission = _prefix "DigitalDocumentPermission"
    /// <summary>
    /// DigitalFormat.
    /// <see href="https://schema.org/DigitalFormat"></see></summary>
    let DigitalFormat = _prefix "DigitalFormat"
    /// <summary>
    /// Payment in advance by direct debit from the bank, equivalent to &lt;code&gt;http://purl.org/goodrelations/v1#DirectDebit&lt;/code&gt;.
    /// <see href="https://schema.org/DirectDebit"></see></summary>
    let DirectDebit = _prefix "DirectDebit"
    /// <summary>
    /// DisabilitySupport: this is a benefit for disability support.
    /// <see href="https://schema.org/DisabilitySupport"></see></summary>
    let DisabilitySupport = _prefix "DisabilitySupport"
    /// <summary>
    /// The act of expressing a difference of opinion with the object. An agent disagrees to/about an object (a proposition, topic or theme) with participants.
    /// <see href="https://schema.org/DisagreeAction"></see></summary>
    let DisagreeAction = _prefix "DisagreeAction"
    /// <summary>
    /// Indicates that the item has been discontinued.
    /// <see href="https://schema.org/Discontinued"></see></summary>
    let Discontinued = _prefix "Discontinued"
    /// <summary>
    /// The act of discovering/finding an object.
    /// <see href="https://schema.org/DiscoverAction"></see></summary>
    let DiscoverAction = _prefix "DiscoverAction"
    /// <summary>
    /// A posting to a discussion forum.
    /// <see href="https://schema.org/DiscussionForumPosting"></see></summary>
    let DiscussionForumPosting = _prefix "DiscussionForumPosting"
    /// <summary>
    /// The act of expressing a negative sentiment about the object. An agent dislikes an object (a proposition, topic or theme) with participants.
    /// <see href="https://schema.org/DislikeAction"></see></summary>
    let DislikeAction = _prefix "DislikeAction"
    /// <summary>
    /// Properties that take Distances as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Length unit of measure&amp;gt;'. E.g., '7 ft'.
    /// <see href="https://schema.org/Distance"></see></summary>
    let Distance = _prefix "Distance"
    /// <summary>
    /// Quantities such as distance, time, mass, weight, etc. Particular instances of say Mass are strings like '3 kg' or '4 milligrams'.
    /// <see href="https://schema.org/Quantity"></see></summary>
    let Quantity = _prefix "Quantity"
    /// <summary>
    /// Represents the distance fee (e.g., price per km or mile) part of the total price for an offered product, for example a car rental.
    /// <see href="https://schema.org/DistanceFee"></see></summary>
    let DistanceFee = _prefix "DistanceFee"
    /// <summary>
    /// A distillery.
    /// <see href="https://schema.org/Distillery"></see></summary>
    let Distillery = _prefix "Distillery"
    /// <summary>
    /// The act of providing goods, services, or money without compensation, often for philanthropic reasons.
    /// <see href="https://schema.org/DonateAction"></see></summary>
    let DonateAction = _prefix "DonateAction"
    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// <see href="https://schema.org/DoseSchedule"></see></summary>
    let DoseSchedule = _prefix "DoseSchedule"
    /// <summary>
    /// A trial design in which neither the researcher nor the patient knows the details of the treatment the patient was randomly assigned to.
    /// <see href="https://schema.org/DoubleBlindedTrial"></see></summary>
    let DoubleBlindedTrial = _prefix "DoubleBlindedTrial"
    /// <summary>
    /// Design models for medical trials. Enumerated type.
    /// <see href="https://schema.org/MedicalTrialDesign"></see></summary>
    let MedicalTrialDesign = _prefix "MedicalTrialDesign"
    /// <summary>
    /// The act of downloading an object.
    /// <see href="https://schema.org/DownloadAction"></see></summary>
    let DownloadAction = _prefix "DownloadAction"
    /// <summary>
    /// Represents the downpayment (up-front payment) price component of the total price for an offered product that has additional installment payments.
    /// <see href="https://schema.org/Downpayment"></see></summary>
    let Downpayment = _prefix "Downpayment"
    /// <summary>
    /// The act of producing a visual/graphical representation of an object, typically with a pen/pencil and paper as instruments.
    /// <see href="https://schema.org/DrawAction"></see></summary>
    let DrawAction = _prefix "DrawAction"
    /// <summary>
    /// A picture or diagram made with a pencil, pen, or crayon rather than paint.
    /// <see href="https://schema.org/Drawing"></see></summary>
    let Drawing = _prefix "Drawing"
    /// <summary>
    /// The act of swallowing liquids.
    /// <see href="https://schema.org/DrinkAction"></see></summary>
    let DrinkAction = _prefix "DrinkAction"
    /// <summary>
    /// Indicates the usage of the vehicle for driving school.
    /// <see href="https://schema.org/DrivingSchoolVehicleUsage"></see></summary>
    let DrivingSchoolVehicleUsage = _prefix "DrivingSchoolVehicleUsage"
    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// <see href="https://schema.org/Drug"></see></summary>
    let Drug = _prefix "Drug"
    /// <summary>
    /// A class of medical drugs, e.g., statins. Classes can represent general pharmacological class, common mechanisms of action, common physiological effects, etc.
    /// <see href="https://schema.org/DrugClass"></see></summary>
    let DrugClass = _prefix "DrugClass"
    /// <summary>
    /// The cost per unit of a medical drug. Note that this type is not meant to represent the price in an offer of a drug for sale; see the Offer type for that. This type will typically be used to tag wholesale or average retail cost of a drug, or maximum reimbursable cost. Costs of medical drugs vary widely depending on how and where they are paid for, so while this type captures some of the variables, costs should be used with caution by consumers of this schema's markup.
    /// <see href="https://schema.org/DrugCost"></see></summary>
    let DrugCost = _prefix "DrugCost"
    /// <summary>
    /// Enumerated categories of medical drug costs.
    /// <see href="https://schema.org/DrugCostCategory"></see></summary>
    let DrugCostCategory = _prefix "DrugCostCategory"
    /// <summary>
    /// Enumerations related to health and the practice of medicine: A concept that is used to attribute a quality to another concept, as a qualifier, a collection of items or a listing of all of the elements of a set in medicine practice.
    /// <see href="https://schema.org/MedicalEnumeration"></see></summary>
    let MedicalEnumeration = _prefix "MedicalEnumeration"
    /// <summary>
    /// The legal availability status of a medical drug.
    /// <see href="https://schema.org/DrugLegalStatus"></see></summary>
    let DrugLegalStatus = _prefix "DrugLegalStatus"
    /// <summary>
    /// Categories that represent an assessment of the risk of fetal injury due to a drug or pharmaceutical used as directed by the mother during pregnancy.
    /// <see href="https://schema.org/DrugPregnancyCategory"></see></summary>
    let DrugPregnancyCategory = _prefix "DrugPregnancyCategory"
    /// <summary>
    /// Indicates whether this drug is available by prescription or over-the-counter.
    /// <see href="https://schema.org/DrugPrescriptionStatus"></see></summary>
    let DrugPrescriptionStatus = _prefix "DrugPrescriptionStatus"
    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// <see href="https://schema.org/DrugStrength"></see></summary>
    let DrugStrength = _prefix "DrugStrength"
    /// <summary>
    /// A dry-cleaning business.
    /// <see href="https://schema.org/DryCleaningOrLaundry"></see></summary>
    let DryCleaningOrLaundry = _prefix "DryCleaningOrLaundry"
    /// <summary>
    /// Quantity: Duration (use [ISO 8601 duration format](http://en.wikipedia.org/wiki/ISO_8601)).
    /// <see href="https://schema.org/Duration"></see></summary>
    let Duration = _prefix "Duration"
    /// <summary>
    /// Book format: Ebook.
    /// <see href="https://schema.org/EBook"></see></summary>
    let EBook = _prefix "EBook"
    /// <summary>
    /// EPRelease.
    /// <see href="https://schema.org/EPRelease"></see></summary>
    let EPRelease = _prefix "EPRelease"
    /// <summary>
    /// Represents EU Energy Efficiency Class A as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryA"></see></summary>
    let EUEnergyEfficiencyCategoryA = _prefix "EUEnergyEfficiencyCategoryA"
    /// <summary>
    /// Enumerates the EU energy efficiency classes A-G as well as A+, A++, and A+++ as defined in EU directive 2017/1369.
    /// <see href="https://schema.org/EUEnergyEfficiencyEnumeration"></see></summary>
    let EUEnergyEfficiencyEnumeration = _prefix "EUEnergyEfficiencyEnumeration"
    /// <summary>
    /// Represents EU Energy Efficiency Class A+ as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryA1Plus"></see></summary>
    let EUEnergyEfficiencyCategoryA1Plus = _prefix "EUEnergyEfficiencyCategoryA1Plus"
    /// <summary>
    /// Represents EU Energy Efficiency Class A++ as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryA2Plus"></see></summary>
    let EUEnergyEfficiencyCategoryA2Plus = _prefix "EUEnergyEfficiencyCategoryA2Plus"
    /// <summary>
    /// Represents EU Energy Efficiency Class A+++ as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryA3Plus"></see></summary>
    let EUEnergyEfficiencyCategoryA3Plus = _prefix "EUEnergyEfficiencyCategoryA3Plus"
    /// <summary>
    /// Represents EU Energy Efficiency Class B as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryB"></see></summary>
    let EUEnergyEfficiencyCategoryB = _prefix "EUEnergyEfficiencyCategoryB"
    /// <summary>
    /// Represents EU Energy Efficiency Class C as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryC"></see></summary>
    let EUEnergyEfficiencyCategoryC = _prefix "EUEnergyEfficiencyCategoryC"
    /// <summary>
    /// Represents EU Energy Efficiency Class D as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryD"></see></summary>
    let EUEnergyEfficiencyCategoryD = _prefix "EUEnergyEfficiencyCategoryD"
    /// <summary>
    /// Represents EU Energy Efficiency Class E as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryE"></see></summary>
    let EUEnergyEfficiencyCategoryE = _prefix "EUEnergyEfficiencyCategoryE"
    /// <summary>
    /// Represents EU Energy Efficiency Class F as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryF"></see></summary>
    let EUEnergyEfficiencyCategoryF = _prefix "EUEnergyEfficiencyCategoryF"
    /// <summary>
    /// Represents EU Energy Efficiency Class G as defined in EU energy labeling regulations.
    /// <see href="https://schema.org/EUEnergyEfficiencyCategoryG"></see></summary>
    let EUEnergyEfficiencyCategoryG = _prefix "EUEnergyEfficiencyCategoryG"
    /// <summary>
    /// Enumerates energy efficiency levels (also known as "classes" or "ratings") and certifications that are part of several international energy efficiency standards.
    /// <see href="https://schema.org/EnergyEfficiencyEnumeration"></see></summary>
    let EnergyEfficiencyEnumeration = _prefix "EnergyEfficiencyEnumeration"
    /// <summary>
    /// Ear function assessment with clinical examination.
    /// <see href="https://schema.org/Ear"></see></summary>
    let Ear = _prefix "Ear"
    /// <summary>
    /// The act of swallowing solid objects.
    /// <see href="https://schema.org/EatAction"></see></summary>
    let EatAction = _prefix "EatAction"
    /// <summary>
    /// Content coded 'edited or cropped content' in a [[MediaReview]], considered in the context of how it was published or shared.
    ///
    /// For a [[VideoObject]] to be 'edited or cropped content': The video has been edited or rearranged. This category applies to time edits, including editing multiple videos together to alter the story being told or editing out large portions from a video.
    ///
    /// For an [[ImageObject]] to be 'edited or cropped content': Presenting a part of an image from a larger whole to mislead the viewer.
    ///
    /// For an [[ImageObject]] with embedded text to be 'edited or cropped content': Presenting a part of an image from a larger whole to mislead the viewer.
    ///
    /// For an [[AudioObject]] to be 'edited or cropped content': The audio has been edited or rearranged. This category applies to time edits, including editing multiple audio clips together to alter the story being told or editing out large portions from the recording.
    ///
    /// <see href="https://schema.org/EditedOrCroppedContent"></see></summary>
    let EditedOrCroppedContent = _prefix "EditedOrCroppedContent"
    /// <summary>
    /// Event type: Education event.
    /// <see href="https://schema.org/EducationEvent"></see></summary>
    let EducationEvent = _prefix "EducationEvent"
    /// <summary>
    /// An EducationalAudience.
    /// <see href="https://schema.org/EducationalAudience"></see></summary>
    let EducationalAudience = _prefix "EducationalAudience"
    /// <summary>
    /// An educational or occupational credential. A diploma, academic degree, certification, qualification, badge, etc., that may be awarded to a person or other entity that meets the requirements defined by the credentialer.
    /// <see href="https://schema.org/EducationalOccupationalCredential"></see></summary>
    let EducationalOccupationalCredential = _prefix "EducationalOccupationalCredential"
    /// <summary>
    /// A program offered by an institution which determines the learning progress to achieve an outcome, usually a credential like a degree or certificate. This would define a discrete set of opportunities (e.g., job, courses) that together constitute a program with a clear start, end, set of requirements, and transition to a new occupational opportunity (e.g., a job), or sometimes a higher educational opportunity (e.g., an advanced degree).
    /// <see href="https://schema.org/EducationalOccupationalProgram"></see></summary>
    let EducationalOccupationalProgram = _prefix "EducationalOccupationalProgram"
    /// <summary>
    /// Content about the effectiveness-related aspects of a health topic.
    /// <see href="https://schema.org/EffectivenessHealthAspect"></see></summary>
    let EffectivenessHealthAspect = _prefix "EffectivenessHealthAspect"
    /// <summary>
    /// An electrician.
    /// <see href="https://schema.org/Electrician"></see></summary>
    let Electrician = _prefix "Electrician"
    /// <summary>
    /// A construction business.\n\nA HomeAndConstructionBusiness is a [[LocalBusiness]] that provides services around homes and buildings.\n\nAs a [[LocalBusiness]] it can be described as a [[provider]] of one or more [[Service]]\(s).
    /// <see href="https://schema.org/HomeAndConstructionBusiness"></see></summary>
    let HomeAndConstructionBusiness = _prefix "HomeAndConstructionBusiness"
    /// <summary>
    /// An electronics store.
    /// <see href="https://schema.org/ElectronicsStore"></see></summary>
    let ElectronicsStore = _prefix "ElectronicsStore"
    /// <summary>
    /// An elementary school.
    /// <see href="https://schema.org/ElementarySchool"></see></summary>
    let ElementarySchool = _prefix "ElementarySchool"
    /// <summary>
    /// An email message.
    /// <see href="https://schema.org/EmailMessage"></see></summary>
    let EmailMessage = _prefix "EmailMessage"
    /// <summary>
    /// A single message from a sender to one or more organizations or people.
    /// <see href="https://schema.org/Message"></see></summary>
    let Message = _prefix "Message"
    /// <summary>
    /// An embassy.
    /// <see href="https://schema.org/Embassy"></see></summary>
    let Embassy = _prefix "Embassy"
    /// <summary>
    /// A specific branch of medical science that deals with the evaluation and initial treatment of medical conditions caused by trauma or sudden illness.
    /// <see href="https://schema.org/Emergency"></see></summary>
    let Emergency = _prefix "Emergency"
    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// <see href="https://schema.org/EmergencyService"></see></summary>
    let EmergencyService = _prefix "EmergencyService"
    /// <summary>
    /// A subclass of OrganizationRole used to describe employee relationships.
    /// <see href="https://schema.org/EmployeeRole"></see></summary>
    let EmployeeRole = _prefix "EmployeeRole"
    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// <see href="https://schema.org/OrganizationRole"></see></summary>
    let OrganizationRole = _prefix "OrganizationRole"
    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// <see href="https://schema.org/EmployerAggregateRating"></see></summary>
    let EmployerAggregateRating = _prefix "EmployerAggregateRating"
    /// <summary>
    /// An [[EmployerReview]] is a review of an [[Organization]] regarding its role as an employer, written by a current or former employee of that organization.
    /// <see href="https://schema.org/EmployerReview"></see></summary>
    let EmployerReview = _prefix "EmployerReview"
    /// <summary>
    /// An employment agency.
    /// <see href="https://schema.org/EmploymentAgency"></see></summary>
    let EmploymentAgency = _prefix "EmploymentAgency"
    /// <summary>
    /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of endocrine glands and their secretions.
    /// <see href="https://schema.org/Endocrine"></see></summary>
    let Endocrine = _prefix "Endocrine"
    /// <summary>
    /// An agent approves/certifies/likes/supports/sanctions an object.
    /// <see href="https://schema.org/EndorseAction"></see></summary>
    let EndorseAction = _prefix "EndorseAction"
    /// <summary>
    /// An EndorsementRating is a rating that expresses some level of endorsement, for example inclusion in a "critic's pick" blog, a
    /// "Like" or "+1" on a social network. It can be considered the [[result]] of an [[EndorseAction]] in which the [[object]] of the action is rated positively by
    /// some [[agent]]. As is common elsewhere in schema.org, it is sometimes more useful to describe the results of such an action without explicitly describing the [[Action]].
    ///
    /// An [[EndorsementRating]] may be part of a numeric scale or organized system, but this is not required: having an explicit type for indicating a positive,
    /// endorsement rating is particularly useful in the absence of numeric scales as it helps consumers understand that the rating is broadly positive.
    ///
    /// <see href="https://schema.org/EndorsementRating"></see></summary>
    let EndorsementRating = _prefix "EndorsementRating"
    /// <summary>
    /// Properties that take Energy as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Energy unit of measure&amp;gt;'.
    /// <see href="https://schema.org/Energy"></see></summary>
    let Energy = _prefix "Energy"
    /// <summary>
    /// EnergyConsumptionDetails represents information related to the energy efficiency of a product that consumes energy. The information that can be provided is based on international regulations such as for example [EU directive 2017/1369](https://eur-lex.europa.eu/eli/reg/2017/1369/oj) for energy labeling and the [Energy labeling rule](https://www.ftc.gov/enforcement/rules/rulemaking-regulatory-reform-proceedings/energy-water-use-labeling-consumer) under the Energy Policy and Conservation Act (EPCA) in the US.
    /// <see href="https://schema.org/EnergyConsumptionDetails"></see></summary>
    let EnergyConsumptionDetails = _prefix "EnergyConsumptionDetails"
    /// <summary>
    /// Represents EnergyStar certification.
    /// <see href="https://schema.org/EnergyStarCertified"></see></summary>
    let EnergyStarCertified = _prefix "EnergyStarCertified"

    /// <summary>
    /// Used to indicate whether a product is EnergyStar certified.
    /// <see href="https://schema.org/EnergyStarEnergyEfficiencyEnumeration"></see></summary>
    let EnergyStarEnergyEfficiencyEnumeration =
        _prefix "EnergyStarEnergyEfficiencyEnumeration"

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// <see href="https://schema.org/EngineSpecification"></see></summary>
    let EngineSpecification = _prefix "EngineSpecification"
    /// <summary>
    /// Enrolling participants by invitation only.
    /// <see href="https://schema.org/EnrollingByInvitation"></see></summary>
    let EnrollingByInvitation = _prefix "EnrollingByInvitation"
    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// <see href="https://schema.org/EntryPoint"></see></summary>
    let EntryPoint = _prefix "EntryPoint"
    /// <summary>
    /// A media episode (e.g. TV, radio, video game) which can be part of a series or season.
    /// <see href="https://schema.org/Episode"></see></summary>
    let Episode = _prefix "Episode"
    /// <summary>
    /// Representation of an Error.
    /// <see href="https://schema.org/Error"></see></summary>
    let Error = _prefix "Error"
    /// <summary>
    /// An event with no duration, like for instance a computer log entry.
    /// <see href="https://schema.org/InstantaneousEvent"></see></summary>
    let InstantaneousEvent = _prefix "InstantaneousEvent"
    /// <summary>
    /// An EventAttendanceModeEnumeration value is one of potentially several modes of organising an event, relating to whether it is online or offline.
    /// <see href="https://schema.org/EventAttendanceModeEnumeration"></see></summary>
    let EventAttendanceModeEnumeration = _prefix "EventAttendanceModeEnumeration"
    /// <summary>
    /// The event has been cancelled. If the event has multiple startDate values, all are assumed to be cancelled. Either startDate or previousStartDate may be used to specify the event's cancelled date(s).
    /// <see href="https://schema.org/EventCancelled"></see></summary>
    let EventCancelled = _prefix "EventCancelled"
    /// <summary>
    /// EventStatusType is an enumeration type whose instances represent several states that an Event may be in.
    /// <see href="https://schema.org/EventStatusType"></see></summary>
    let EventStatusType = _prefix "EventStatusType"
    /// <summary>
    /// Indicates that the event was changed to allow online participation. See [[eventAttendanceMode]] for specifics of whether it is now fully or partially online.
    /// <see href="https://schema.org/EventMovedOnline"></see></summary>
    let EventMovedOnline = _prefix "EventMovedOnline"
    /// <summary>
    /// The event has been postponed and no new date has been set. The event's previousStartDate should be set.
    /// <see href="https://schema.org/EventPostponed"></see></summary>
    let EventPostponed = _prefix "EventPostponed"
    /// <summary>
    /// The event has been rescheduled. The event's previousStartDate should be set to the old date and the startDate should be set to the event's new date. (If the event has been rescheduled multiple times, the previousStartDate property may be repeated.)
    /// <see href="https://schema.org/EventRescheduled"></see></summary>
    let EventRescheduled = _prefix "EventRescheduled"
    /// <summary>
    /// A reservation for an event like a concert, sporting event, or lecture.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// <see href="https://schema.org/EventReservation"></see></summary>
    let EventReservation = _prefix "EventReservation"
    /// <summary>
    /// The event is taking place or has taken place on the startDate as scheduled. Use of this value is optional, as it is assumed by default.
    /// <see href="https://schema.org/EventScheduled"></see></summary>
    let EventScheduled = _prefix "EventScheduled"
    /// <summary>
    /// A series of [[Event]]s. Included events can relate with the series using the [[superEvent]] property.
    ///
    /// An EventSeries is a collection of events that share some unifying characteristic. For example, "The Olympic Games" is a series, which
    /// is repeated regularly. The "2012 London Olympics" can be presented both as an [[Event]] in the series "Olympic Games", and as an
    /// [[EventSeries]] that included a number of sporting competitions as Events.
    ///
    /// The nature of the association between the events in an [[EventSeries]] can vary, but typical examples could
    /// include a thematic event series (e.g. topical meetups or classes), or a series of regular events that share a location, attendee group and/or organizers.
    ///
    /// EventSeries has been defined as a kind of Event to make it easy for publishers to use it in an Event context without
    /// worrying about which kinds of series are really event-like enough to call an Event. In general an EventSeries
    /// may seem more Event-like when the period of time is compact and when aspects such as location are fixed, but
    /// it may also sometimes prove useful to describe a longer-term series as an Event.
    ///
    /// <see href="https://schema.org/EventSeries"></see></summary>
    let EventSeries = _prefix "EventSeries"
    /// <summary>
    /// An event venue.
    /// <see href="https://schema.org/EventVenue"></see></summary>
    let EventVenue = _prefix "EventVenue"
    /// <summary>
    /// Data derived from multiple randomized clinical trials or meta-analyses.
    /// <see href="https://schema.org/EvidenceLevelA"></see></summary>
    let EvidenceLevelA = _prefix "EvidenceLevelA"
    /// <summary>
    /// Level of evidence for a medical guideline. Enumerated type.
    /// <see href="https://schema.org/MedicalEvidenceLevel"></see></summary>
    let MedicalEvidenceLevel = _prefix "MedicalEvidenceLevel"
    /// <summary>
    /// Data derived from a single randomized trial, or nonrandomized studies.
    /// <see href="https://schema.org/EvidenceLevelB"></see></summary>
    let EvidenceLevelB = _prefix "EvidenceLevelB"
    /// <summary>
    /// Only consensus opinion of experts, case studies, or standard-of-care.
    /// <see href="https://schema.org/EvidenceLevelC"></see></summary>
    let EvidenceLevelC = _prefix "EvidenceLevelC"
    /// <summary>
    /// An example [[MeasurementMethodEnum]] (to remove when real enums are added).
    /// <see href="https://schema.org/ExampleMeasurementMethodEnum"></see></summary>
    let ExampleMeasurementMethodEnum = _prefix "ExampleMeasurementMethodEnum"
    /// <summary>
    /// Enumeration(s) for use with [[measurementMethod]].
    /// <see href="https://schema.org/MeasurementMethodEnum"></see></summary>
    let MeasurementMethodEnum = _prefix "MeasurementMethodEnum"
    /// <summary>
    /// A structured value representing exchange rate.
    /// <see href="https://schema.org/ExchangeRateSpecification"></see></summary>
    let ExchangeRateSpecification = _prefix "ExchangeRateSpecification"
    /// <summary>
    /// Specifies that a refund can be done as an exchange for the same product.
    /// <see href="https://schema.org/ExchangeRefund"></see></summary>
    let ExchangeRefund = _prefix "ExchangeRefund"
    /// <summary>
    /// Enumerates several kinds of product return refund types.
    /// <see href="https://schema.org/RefundTypeEnumeration"></see></summary>
    let RefundTypeEnumeration = _prefix "RefundTypeEnumeration"
    /// <summary>
    /// The act of participating in exertive activity for the purposes of improving health and fitness.
    /// <see href="https://schema.org/ExerciseAction"></see></summary>
    let ExerciseAction = _prefix "ExerciseAction"
    /// <summary>
    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, competition or exercise.\n\nRelated actions:\n\n* [[ListenAction]]: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.\n* [[WatchAction]]: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.
    /// <see href="https://schema.org/PlayAction"></see></summary>
    let PlayAction = _prefix "PlayAction"
    /// <summary>
    /// A gym.
    /// <see href="https://schema.org/ExerciseGym"></see></summary>
    let ExerciseGym = _prefix "ExerciseGym"
    /// <summary>
    /// Fitness-related activity designed for a specific health-related purpose, including defined exercise routines as well as activity prescribed by a clinician.
    /// <see href="https://schema.org/ExercisePlan"></see></summary>
    let ExercisePlan = _prefix "ExercisePlan"
    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// <see href="https://schema.org/PhysicalActivity"></see></summary>
    let PhysicalActivity = _prefix "PhysicalActivity"
    /// <summary>
    /// Event type: Exhibition event, e.g. at a museum, library, archive, tradeshow, ...
    /// <see href="https://schema.org/ExhibitionEvent"></see></summary>
    let ExhibitionEvent = _prefix "ExhibitionEvent"
    /// <summary>
    /// Eye or ophthalmological function assessment with clinical examination.
    /// <see href="https://schema.org/Eye"></see></summary>
    let Eye = _prefix "Eye"
    /// <summary>
    /// A [[FAQPage]] is a [[WebPage]] presenting one or more "[Frequently asked questions](https://en.wikipedia.org/wiki/FAQ)" (see also [[QAPage]]).
    /// <see href="https://schema.org/FAQPage"></see></summary>
    let FAQPage = _prefix "FAQPage"
    /// <summary>
    /// A designation by the US FDA signifying that adequate and well-controlled studies have failed to demonstrate a risk to the fetus in the first trimester of pregnancy (and there is no evidence of risk in later trimesters).
    /// <see href="https://schema.org/FDAcategoryA"></see></summary>
    let FDAcategoryA = _prefix "FDAcategoryA"
    /// <summary>
    /// A designation by the US FDA signifying that animal reproduction studies have failed to demonstrate a risk to the fetus and there are no adequate and well-controlled studies in pregnant women.
    /// <see href="https://schema.org/FDAcategoryB"></see></summary>
    let FDAcategoryB = _prefix "FDAcategoryB"
    /// <summary>
    /// A designation by the US FDA signifying that animal reproduction studies have shown an adverse effect on the fetus and there are no adequate and well-controlled studies in humans, but potential benefits may warrant use of the drug in pregnant women despite potential risks.
    /// <see href="https://schema.org/FDAcategoryC"></see></summary>
    let FDAcategoryC = _prefix "FDAcategoryC"
    /// <summary>
    /// A designation by the US FDA signifying that there is positive evidence of human fetal risk based on adverse reaction data from investigational or marketing experience or studies in humans, but potential benefits may warrant use of the drug in pregnant women despite potential risks.
    /// <see href="https://schema.org/FDAcategoryD"></see></summary>
    let FDAcategoryD = _prefix "FDAcategoryD"
    /// <summary>
    /// A designation by the US FDA signifying that studies in animals or humans have demonstrated fetal abnormalities and/or there is positive evidence of human fetal risk based on adverse reaction data from investigational or marketing experience, and the risks involved in use of the drug in pregnant women clearly outweigh potential benefits.
    /// <see href="https://schema.org/FDAcategoryX"></see></summary>
    let FDAcategoryX = _prefix "FDAcategoryX"
    /// <summary>
    /// A designation that the drug in question has not been assigned a pregnancy category designation by the US FDA.
    /// <see href="https://schema.org/FDAnotEvaluated"></see></summary>
    let FDAnotEvaluated = _prefix "FDAnotEvaluated"
    /// <summary>
    /// A radio channel that uses FM.
    /// <see href="https://schema.org/FMRadioChannel"></see></summary>
    let FMRadioChannel = _prefix "FMRadioChannel"
    /// <summary>
    /// An action that failed to complete. The action's error property and the HTTP return code contain more information about the failure.
    /// <see href="https://schema.org/FailedActionStatus"></see></summary>
    let FailedActionStatus = _prefix "FailedActionStatus"
    /// <summary>
    /// The boolean value false.
    /// <see href="https://schema.org/False"></see></summary>
    let False = _prefix "False"
    /// <summary>
    /// A fast-food restaurant.
    /// <see href="https://schema.org/FastFoodRestaurant"></see></summary>
    let FastFoodRestaurant = _prefix "FastFoodRestaurant"
    /// <summary>
    /// The female gender.
    /// <see href="https://schema.org/Female"></see></summary>
    let Female = _prefix "Female"
    /// <summary>
    /// An enumeration of genders.
    /// <see href="https://schema.org/GenderType"></see></summary>
    let GenderType = _prefix "GenderType"
    /// <summary>
    /// Event type: Festival.
    /// <see href="https://schema.org/Festival"></see></summary>
    let Festival = _prefix "Festival"
    /// <summary>
    /// The act of capturing sound and moving images on film, video, or digitally.
    /// <see href="https://schema.org/FilmAction"></see></summary>
    let FilmAction = _prefix "FilmAction"
    /// <summary>
    /// &lt;p&gt;Represents financial incentives for goods/services offered by an organization (or individual).&lt;/p&gt;
    ///
    /// &lt;p&gt;Typically contains the [[name]] of the incentive, the [[incentivizedItem]], the [[incentiveAmount]], the [[incentiveStatus]], [[incentiveType]], the [[provider]] of the incentive, and [[eligibleWithSupplier]].&lt;/p&gt;
    ///
    /// &lt;p&gt;Optionally contains criteria on whether the incentive is limited based on [[purchaseType]], [[purchasePriceLimit]], [[incomeLimit]], and the [[qualifiedExpense]].
    ///
    /// <see href="https://schema.org/FinancialIncentive"></see></summary>
    let FinancialIncentive = _prefix "FinancialIncentive"
    /// <summary>
    /// A fire station. With firemen.
    /// <see href="https://schema.org/FireStation"></see></summary>
    let FireStation = _prefix "FireStation"
    /// <summary>
    /// Physical activity that is engaged in to improve joint and muscle flexibility.
    /// <see href="https://schema.org/Flexibility"></see></summary>
    let Flexibility = _prefix "Flexibility"
    /// <summary>
    /// An airline flight.
    /// <see href="https://schema.org/Flight"></see></summary>
    let Flight = _prefix "Flight"
    /// <summary>
    /// A reservation for air travel.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// <see href="https://schema.org/FlightReservation"></see></summary>
    let FlightReservation = _prefix "FlightReservation"
    /// <summary>
    /// Data type: Floating number.
    /// <see href="https://schema.org/Float"></see></summary>
    let Float = _prefix "Float"
    /// <summary>
    /// Data type: Number.\n\nUsage guidelines:\n\n* Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similar Unicode symbols.\n* Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
    /// <see href="https://schema.org/Number"></see></summary>
    let Number = _prefix "Number"
    /// <summary>
    /// A FloorPlan is an explicit representation of a collection of similar accommodations, allowing the provision of common information (room counts, sizes, layout diagrams) and offers for rental or sale. In typical use, some [[ApartmentComplex]] has an [[accommodationFloorPlan]] which is a [[FloorPlan]].  A FloorPlan is always in the context of a particular place, either a larger [[ApartmentComplex]] or a single [[Apartment]]. The visual/spatial aspects of a floor plan (i.e. room layout, [see wikipedia](https://en.wikipedia.org/wiki/Floor_plan)) can be indicated using [[image]].
    /// <see href="https://schema.org/FloorPlan"></see></summary>
    let FloorPlan = _prefix "FloorPlan"
    /// <summary>
    /// A florist.
    /// <see href="https://schema.org/Florist"></see></summary>
    let Florist = _prefix "Florist"
    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from.\n\nRelated actions:\n\n* [[BefriendAction]]: Unlike BefriendAction, FollowAction implies that the connection is *not* necessarily reciprocal.\n* [[SubscribeAction]]: Unlike SubscribeAction, FollowAction implies that the follower acts as an active agent constantly/actively polling for updates.\n* [[RegisterAction]]: Unlike RegisterAction, FollowAction implies that the agent is interested in continuing receiving updates from the object.\n* [[JoinAction]]: Unlike JoinAction, FollowAction implies that the agent is interested in getting updates from the object.\n* [[TrackAction]]: Unlike TrackAction, FollowAction refers to the polling of updates of all aspects of animate objects rather than the location of inanimate objects (e.g. you track a package, but you don't follow it).
    /// <see href="https://schema.org/FollowAction"></see></summary>
    let FollowAction = _prefix "FollowAction"
    /// <summary>
    /// A reservation to dine at a food-related business.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// <see href="https://schema.org/FoodEstablishmentReservation"></see></summary>
    let FoodEstablishmentReservation = _prefix "FoodEstablishmentReservation"
    /// <summary>
    /// Event type: Food event.
    /// <see href="https://schema.org/FoodEvent"></see></summary>
    let FoodEvent = _prefix "FoodEvent"
    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// <see href="https://schema.org/FoodService"></see></summary>
    let FoodService = _prefix "FoodService"
    /// <summary>
    /// Four-wheel drive is a transmission layout where the engine primarily drives two wheels with a part-time four-wheel drive capability.
    /// <see href="https://schema.org/FourWheelDriveConfiguration"></see></summary>
    let FourWheelDriveConfiguration = _prefix "FourWheelDriveConfiguration"
    /// <summary>
    /// Specifies that product returns are free of charge for the customer.
    /// <see href="https://schema.org/FreeReturn"></see></summary>
    let FreeReturn = _prefix "FreeReturn"
    /// <summary>
    /// Enumerates several kinds of policies for product return fees.
    /// <see href="https://schema.org/ReturnFeesEnumeration"></see></summary>
    let ReturnFeesEnumeration = _prefix "ReturnFeesEnumeration"
    /// <summary>
    /// The day of the week between Thursday and Saturday.
    /// <see href="https://schema.org/Friday"></see></summary>
    let Friday = _prefix "Friday"
    /// <summary>
    /// URL of a reference Web page that unambiguously indicates the item's identity. E.g. the URL of the item's Wikipedia page, Wikidata entry, or official website.
    /// <see href="https://schema.org/sameAs"></see></summary>
    let sameAs = _prefix "sameAs"
    /// <summary>
    /// Front-wheel drive is a transmission layout where the engine drives the front wheels.
    /// <see href="https://schema.org/FrontWheelDriveConfiguration"></see></summary>
    let FrontWheelDriveConfiguration = _prefix "FrontWheelDriveConfiguration"
    /// <summary>
    /// Fulfillment to a collection point location.
    /// <see href="https://schema.org/FulfillmentTypeCollectionPoint"></see></summary>
    let FulfillmentTypeCollectionPoint = _prefix "FulfillmentTypeCollectionPoint"
    /// <summary>
    /// A type of product fulfillment.
    /// <see href="https://schema.org/FulfillmentTypeEnumeration"></see></summary>
    let FulfillmentTypeEnumeration = _prefix "FulfillmentTypeEnumeration"
    /// <summary>
    /// Fulfillment to a customer selected address.
    /// <see href="https://schema.org/FulfillmentTypeDelivery"></see></summary>
    let FulfillmentTypeDelivery = _prefix "FulfillmentTypeDelivery"
    /// <summary>
    /// Fulfillment through pick-up drop-off locations.
    /// <see href="https://schema.org/FulfillmentTypePickupDropoff"></see></summary>
    let FulfillmentTypePickupDropoff = _prefix "FulfillmentTypePickupDropoff"
    /// <summary>
    /// Fulfillment through pick-up in a store.
    /// <see href="https://schema.org/FulfillmentTypePickupInStore"></see></summary>
    let FulfillmentTypePickupInStore = _prefix "FulfillmentTypePickupInStore"
    /// <summary>
    /// Fulfillment to a customer selected address after scheduling with the customer.
    /// <see href="https://schema.org/FulfillmentTypeScheduledDelivery"></see></summary>
    let FulfillmentTypeScheduledDelivery = _prefix "FulfillmentTypeScheduledDelivery"
    /// <summary>
    /// Indicates full game availability.
    /// <see href="https://schema.org/FullGameAvailability"></see></summary>
    let FullGameAvailability = _prefix "FullGameAvailability"
    /// <summary>
    /// Specifies that a refund can be done in the full amount the customer paid for the product.
    /// <see href="https://schema.org/FullRefund"></see></summary>
    let FullRefund = _prefix "FullRefund"
    /// <summary>
    /// A FundingAgency is an organization that implements one or more [[FundingScheme]]s and manages
    ///     the granting process (via [[Grant]]s, typically [[MonetaryGrant]]s).
    ///     A funding agency is not always required for grant funding, e.g. philanthropic giving, corporate sponsorship etc.
    ///
    /// Examples of funding agencies include ERC, REA, NIH, Bill and Melinda Gates Foundation, ...
    ///
    /// <see href="https://schema.org/FundingAgency"></see></summary>
    let FundingAgency = _prefix "FundingAgency"
    /// <summary>
    /// An enterprise (potentially individual but typically collaborative), planned to achieve a particular aim.
    /// Use properties from [[Organization]], [[subOrganization]]/[[parentOrganization]] to indicate project sub-structures.
    ///
    /// <see href="https://schema.org/Project"></see></summary>
    let Project = _prefix "Project"
    /// <summary>
    /// A FundingScheme combines organizational, project and policy aspects of grant-based funding
    ///     that sets guidelines, principles and mechanisms to support other kinds of projects and activities.
    ///     Funding is typically organized via [[Grant]] funding. Examples of funding schemes: Swiss Priority Programmes (SPPs); EU Framework 7 (FP7); Horizon 2020; the NIH-R01 Grant Program; Wellcome institutional strategic support fund. For large scale public sector funding, the management and administration of grant awards is often handled by other, dedicated, organizations - [[FundingAgency]]s such as ERC, REA, ...
    /// <see href="https://schema.org/FundingScheme"></see></summary>
    let FundingScheme = _prefix "FundingScheme"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/FundInfoCollab"></see>
    /// </summary>
    let ``docs/collab/FundInfoCollab`` = _prefix "docs/collab/FundInfoCollab"
    /// <summary>
    /// Pathogenic fungus.
    /// <see href="https://schema.org/Fungus"></see></summary>
    let Fungus = _prefix "Fungus"
    /// <summary>
    /// A furniture store.
    /// <see href="https://schema.org/FurnitureStore"></see></summary>
    let FurnitureStore = _prefix "FurnitureStore"
    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// <see href="https://schema.org/Game"></see></summary>
    let Game = _prefix "Game"
    /// <summary>
    /// Server that provides game interaction in a multiplayer game.
    /// <see href="https://schema.org/GameServer"></see></summary>
    let GameServer = _prefix "GameServer"
    /// <summary>
    /// Status of a game server.
    /// <see href="https://schema.org/GameServerStatus"></see></summary>
    let GameServerStatus = _prefix "GameServerStatus"
    /// <summary>
    /// A garden store.
    /// <see href="https://schema.org/GardenStore"></see></summary>
    let GardenStore = _prefix "GardenStore"
    /// <summary>
    /// A gas station.
    /// <see href="https://schema.org/GasStation"></see></summary>
    let GasStation = _prefix "GasStation"
    /// <summary>
    /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of digestive system.
    /// <see href="https://schema.org/Gastroenterologic"></see></summary>
    let Gastroenterologic = _prefix "Gastroenterologic"
    /// <summary>
    /// Residence type: Gated community.
    /// <see href="https://schema.org/GatedResidenceCommunity"></see></summary>
    let GatedResidenceCommunity = _prefix "GatedResidenceCommunity"
    /// <summary>
    /// A discrete unit of inheritance which affects one or more biological traits (Source: [https://en.wikipedia.org/wiki/Gene](https://en.wikipedia.org/wiki/Gene)). Examples include FOXP2 (Forkhead box protein P2), SCARNA21 (small Cajal body-specific RNA 21), A- (agouti genotype).
    /// <see href="https://schema.org/Gene"></see></summary>
    let Gene = _prefix "Gene"
    /// <summary>
    /// A general contractor.
    /// <see href="https://schema.org/GeneralContractor"></see></summary>
    let GeneralContractor = _prefix "GeneralContractor"
    /// <summary>
    /// Represents the generic notion of the Web Platform. More specific codes include [[MobileWebPlatform]] and [[DesktopWebPlatform]], as an incomplete list.
    /// <see href="https://schema.org/GenericWebPlatform"></see></summary>
    let GenericWebPlatform = _prefix "GenericWebPlatform"
    /// <summary>
    /// A specific branch of medical science that pertains to hereditary transmission and the variation of inherited characteristics and disorders.
    /// <see href="https://schema.org/Genetic"></see></summary>
    let Genetic = _prefix "Genetic"
    /// <summary>
    /// Genitourinary system function assessment with clinical examination.
    /// <see href="https://schema.org/Genitourinary"></see></summary>
    let Genitourinary = _prefix "Genitourinary"
    /// <summary>
    /// A GeoCircle is a GeoShape representing a circular geographic area. As it is a GeoShape
    ///           it provides the simple textual property 'circle', but also allows the combination of postalCode alongside geoRadius.
    ///           The center of the circle can be indicated via the 'geoMidpoint' property, or more approximately using 'address', 'postalCode'.
    ///
    /// <see href="https://schema.org/GeoCircle"></see></summary>
    let GeoCircle = _prefix "GeoCircle"
    /// <summary>
    /// The geographic shape of a place. A GeoShape can be described using several properties whose values are based on latitude/longitude pairs. Either whitespace or commas can be used to separate latitude and longitude; whitespace should be used when writing a list of several such points.
    /// <see href="https://schema.org/GeoShape"></see></summary>
    let GeoShape = _prefix "GeoShape"
    /// <summary>
    /// The geographic coordinates of a place or event.
    /// <see href="https://schema.org/GeoCoordinates"></see></summary>
    let GeoCoordinates = _prefix "GeoCoordinates"
    /// <summary>
    /// (Eventually to be defined as) a supertype of GeoShape designed to accommodate definitions from Geo-Spatial best practices.
    /// <see href="https://schema.org/GeospatialGeometry"></see></summary>
    let GeospatialGeometry = _prefix "GeospatialGeometry"
    /// <summary>
    /// A specific branch of medical science that is concerned with the diagnosis and treatment of diseases, debilities and provision of care to the aged.
    /// <see href="https://schema.org/Geriatric"></see></summary>
    let Geriatric = _prefix "Geriatric"
    /// <summary>
    /// Content that discusses practical and policy aspects for getting access to specific kinds of healthcare (e.g. distribution mechanisms for vaccines).
    /// <see href="https://schema.org/GettingAccessHealthAspect"></see></summary>
    let GettingAccessHealthAspect = _prefix "GettingAccessHealthAspect"
    /// <summary>
    /// The act of transferring ownership of an object to a destination. Reciprocal of TakeAction.\n\nRelated actions:\n\n* [[TakeAction]]: Reciprocal of GiveAction.\n* [[SendAction]]: Unlike SendAction, GiveAction implies that ownership is being transferred (e.g. I may send my laptop to you, but that doesn't mean I'm giving it to you).
    /// <see href="https://schema.org/GiveAction"></see></summary>
    let GiveAction = _prefix "GiveAction"
    /// <summary>
    /// A diet exclusive of gluten.
    /// <see href="https://schema.org/GlutenFreeDiet"></see></summary>
    let GlutenFreeDiet = _prefix "GlutenFreeDiet"
    /// <summary>
    /// A golf course.
    /// <see href="https://schema.org/GolfCourse"></see></summary>
    let GolfCourse = _prefix "GolfCourse"
    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// <see href="https://schema.org/GovernmentOffice"></see></summary>
    let GovernmentOffice = _prefix "GovernmentOffice"
    /// <summary>
    /// A governmental organization or agency.
    /// <see href="https://schema.org/GovernmentOrganization"></see></summary>
    let GovernmentOrganization = _prefix "GovernmentOrganization"
    /// <summary>
    /// A permit issued by a government agency.
    /// <see href="https://schema.org/GovernmentPermit"></see></summary>
    let GovernmentPermit = _prefix "GovernmentPermit"
    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// <see href="https://schema.org/Permit"></see></summary>
    let Permit = _prefix "Permit"
    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// <see href="https://schema.org/GovernmentService"></see></summary>
    let GovernmentService = _prefix "GovernmentService"
    /// <summary>
    /// A grant, typically financial or otherwise quantifiable, of resources. Typically a [[funder]] sponsors some [[MonetaryAmount]] to an [[Organization]] or [[Person]],
    ///     sometimes not necessarily via a dedicated or long-lived [[Project]], resulting in one or more outputs, or [[fundedItem]]s. For financial sponsorship, indicate the [[funder]] of a [[MonetaryGrant]]. For non-financial support, indicate [[sponsor]] of [[Grant]]s of resources (e.g. office space).
    ///
    /// Grants support  activities directed towards some agreed collective goals, often but not always organized as [[Project]]s. Long-lived projects are sometimes sponsored by a variety of grants over time, but it is also common for a project to be associated with a single grant.
    ///
    /// The amount of a [[Grant]] is represented using [[amount]] as a [[MonetaryAmount]].
    ///
    /// <see href="https://schema.org/Grant"></see></summary>
    let Grant = _prefix "Grant"
    /// <summary>
    /// This type is deprecated: GraphicNovel does not fit the BookFormatType enumeration, as it can appear in multiple formats (e.g., Hardcover, eBook). It is not mutually exclusive and therefore deprecated. Use standard BookFormatType values instead in combination with the SequentialArt.
    ///
    /// Book format: GraphicNovel. May represent a bound collection of ComicIssue instances.
    /// <see href="https://schema.org/GraphicNovel"></see></summary>
    let GraphicNovel = _prefix "GraphicNovel"
    /// <summary>
    /// A grocery store.
    /// <see href="https://schema.org/GroceryStore"></see></summary>
    let GroceryStore = _prefix "GroceryStore"
    /// <summary>
    /// The airline boards by groups based on check-in time, priority, etc.
    /// <see href="https://schema.org/GroupBoardingPolicy"></see></summary>
    let GroupBoardingPolicy = _prefix "GroupBoardingPolicy"
    /// <summary>
    /// [[Guide]] is a page or article that recommends specific products or services, or aspects of a thing for a user to consider. A [[Guide]] may represent a Buying Guide and detail aspects of products or services for a user to consider. A [[Guide]] may represent a Product Guide and recommend specific products or services. A [[Guide]] may represent a Ranked List and recommend specific products or services with ranking.
    /// <see href="https://schema.org/Guide"></see></summary>
    let Guide = _prefix "Guide"
    /// <summary>
    /// A specific branch of medical science that pertains to the health care of women, particularly in the diagnosis and treatment of disorders affecting the female reproductive system.
    /// <see href="https://schema.org/Gynecologic"></see></summary>
    let Gynecologic = _prefix "Gynecologic"
    /// <summary>
    /// A business that provides Heating, Ventilation and Air Conditioning services.
    /// <see href="https://schema.org/HVACBusiness"></see></summary>
    let HVACBusiness = _prefix "HVACBusiness"
    /// <summary>
    /// A [hackathon](https://en.wikipedia.org/wiki/Hackathon) event.
    /// <see href="https://schema.org/Hackathon"></see></summary>
    let Hackathon = _prefix "Hackathon"
    /// <summary>
    /// A hair salon.
    /// <see href="https://schema.org/HairSalon"></see></summary>
    let HairSalon = _prefix "HairSalon"
    /// <summary>
    /// A diet conforming to Islamic dietary practices.
    /// <see href="https://schema.org/HalalDiet"></see></summary>
    let HalalDiet = _prefix "HalalDiet"
    /// <summary>
    /// A durable, archival-quality book featuring a rigid protective shell made of heavy board wrapped in cloth or paper, designed to withstand heavy use and preservation on a shelf.
    /// <see href="https://schema.org/Hardcover"></see></summary>
    let Hardcover = _prefix "Hardcover"
    /// <summary>
    /// A hardware store.
    /// <see href="https://schema.org/HardwareStore"></see></summary>
    let HardwareStore = _prefix "HardwareStore"
    /// <summary>
    /// Head assessment with clinical examination.
    /// <see href="https://schema.org/Head"></see></summary>
    let Head = _prefix "Head"
    /// <summary>
    /// HealthCare: this is a benefit for health care.
    /// <see href="https://schema.org/HealthCare"></see></summary>
    let HealthCare = _prefix "HealthCare"
    /// <summary>
    /// A health club.
    /// <see href="https://schema.org/HealthClub"></see></summary>
    let HealthClub = _prefix "HealthClub"
    /// <summary>
    /// A US-style health insurance plan, including PPOs, EPOs, and HMOs.
    /// <see href="https://schema.org/HealthInsurancePlan"></see></summary>
    let HealthInsurancePlan = _prefix "HealthInsurancePlan"

    /// <summary>
    /// A description of costs to the patient under a given network or formulary.
    /// <see href="https://schema.org/HealthPlanCostSharingSpecification"></see></summary>
    let HealthPlanCostSharingSpecification =
        _prefix "HealthPlanCostSharingSpecification"

    /// <summary>
    /// For a given health insurance plan, the specification for costs and coverage of prescription drugs.
    /// <see href="https://schema.org/HealthPlanFormulary"></see></summary>
    let HealthPlanFormulary = _prefix "HealthPlanFormulary"
    /// <summary>
    /// A US-style health insurance plan network.
    /// <see href="https://schema.org/HealthPlanNetwork"></see></summary>
    let HealthPlanNetwork = _prefix "HealthPlanNetwork"
    /// <summary>
    /// [[HealthTopicContent]] is [[WebContent]] that is about some aspect of a health topic, e.g. a condition, its symptoms or treatments. Such content may be comprised of several parts or sections and use different types of media. Multiple instances of [[WebContent]] (and hence [[HealthTopicContent]]) can be related using [[hasPart]] / [[isPartOf]] where there is some kind of content hierarchy, and their content described with [[about]] and [[mentions]] e.g. building upon the existing [[MedicalCondition]] vocabulary.
    ///
    /// <see href="https://schema.org/HealthTopicContent"></see></summary>
    let HealthTopicContent = _prefix "HealthTopicContent"
    /// <summary>
    /// WebContent is a type representing all [[WebPage]], [[WebSite]] and [[WebPageElement]] content. It is sometimes the case that detailed distinctions between Web pages, sites and their parts are not always important or obvious. The  [[WebContent]] type makes it easier to describe Web-addressable content without requiring such distinctions to always be stated. (The intent is that the existing types [[WebPage]], [[WebSite]] and [[WebPageElement]] will eventually be declared as subtypes of [[WebContent]].)
    /// <see href="https://schema.org/WebContent"></see></summary>
    let WebContent = _prefix "WebContent"
    /// <summary>
    /// Item is a pharmaceutical (e.g., a prescription or OTC drug) or a restricted medical device.
    /// <see href="https://schema.org/HealthcareConsideration"></see></summary>
    let HealthcareConsideration = _prefix "HealthcareConsideration"
    /// <summary>
    /// Uses devices to support users with hearing impairments.
    /// <see href="https://schema.org/HearingImpairedSupported"></see></summary>
    let HearingImpairedSupported = _prefix "HearingImpairedSupported"
    /// <summary>
    /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of blood and blood producing organs.
    /// <see href="https://schema.org/Hematologic"></see></summary>
    let Hematologic = _prefix "Hematologic"
    /// <summary>
    /// A high school.
    /// <see href="https://schema.org/HighSchool"></see></summary>
    let HighSchool = _prefix "HighSchool"
    /// <summary>
    /// A diet conforming to Hindu dietary practices, in particular, beef-free.
    /// <see href="https://schema.org/HinduDiet"></see></summary>
    let HinduDiet = _prefix "HinduDiet"
    /// <summary>
    /// A Hindu temple.
    /// <see href="https://schema.org/HinduTemple"></see></summary>
    let HinduTemple = _prefix "HinduTemple"
    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// <see href="https://schema.org/HobbyShop"></see></summary>
    let HobbyShop = _prefix "HobbyShop"
    /// <summary>
    /// A home goods store.
    /// <see href="https://schema.org/HomeGoodsStore"></see></summary>
    let HomeGoodsStore = _prefix "HomeGoodsStore"
    /// <summary>
    /// A system of medicine based on the principle that a disease can be cured by a substance that produces similar symptoms in healthy people.
    /// <see href="https://schema.org/Homeopathic"></see></summary>
    let Homeopathic = _prefix "Homeopathic"
    /// <summary>
    /// A hospital.
    /// <see href="https://schema.org/Hospital"></see></summary>
    let Hospital = _prefix "Hospital"
    /// <summary>
    /// A hostel - cheap accommodation, often in shared dormitories.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/Hostel"></see></summary>
    let Hostel = _prefix "Hostel"
    /// <summary>
    /// A hotel is an establishment that provides lodging paid on a short-term basis (source: Wikipedia, the free encyclopedia, see http://en.wikipedia.org/wiki/Hotel).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/Hotel"></see></summary>
    let Hotel = _prefix "Hotel"
    /// <summary>
    /// A hotel room is a single room in a hotel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/HotelRoom"></see></summary>
    let HotelRoom = _prefix "HotelRoom"
    /// <summary>
    /// A room is a distinguishable space within a structure, usually separated from other spaces by interior walls (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Room"&gt;http://en.wikipedia.org/wiki/Room&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/Room"></see></summary>
    let Room = _prefix "Room"
    /// <summary>
    /// A house is a building or structure that has the ability to be occupied for habitation by humans or other creatures (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/House"&gt;http://en.wikipedia.org/wiki/House&lt;/a&gt;).
    /// <see href="https://schema.org/House"></see></summary>
    let House = _prefix "House"
    /// <summary>
    /// A house painting service.
    /// <see href="https://schema.org/HousePainter"></see></summary>
    let HousePainter = _prefix "HousePainter"
    /// <summary>
    /// Content that discusses and explains how a particular health-related topic works, e.g. in terms of mechanisms and underlying science.
    /// <see href="https://schema.org/HowItWorksHealthAspect"></see></summary>
    let HowItWorksHealthAspect = _prefix "HowItWorksHealthAspect"
    /// <summary>
    /// Information about how or where to find a topic. Also may contain location data that can be used for where to look for help if the topic is observed.
    /// <see href="https://schema.org/HowOrWhereHealthAspect"></see></summary>
    let HowOrWhereHealthAspect = _prefix "HowOrWhereHealthAspect"
    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// <see href="https://schema.org/HowTo"></see></summary>
    let HowTo = _prefix "HowTo"
    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// <see href="https://schema.org/HowToDirection"></see></summary>
    let HowToDirection = _prefix "HowToDirection"
    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// <see href="https://schema.org/ListItem"></see></summary>
    let ListItem = _prefix "ListItem"
    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to achieve a result.
    /// <see href="https://schema.org/HowToItem"></see></summary>
    let HowToItem = _prefix "HowToItem"
    /// <summary>
    /// A sub-grouping of steps in the instructions for how to achieve a result (e.g. steps for making a pie crust within a pie recipe).
    /// <see href="https://schema.org/HowToSection"></see></summary>
    let HowToSection = _prefix "HowToSection"
    /// <summary>
    /// A step in the instructions for how to achieve a result. It is an ordered list with HowToDirection and/or HowToTip items.
    /// <see href="https://schema.org/HowToStep"></see></summary>
    let HowToStep = _prefix "HowToStep"
    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// <see href="https://schema.org/HowToSupply"></see></summary>
    let HowToSupply = _prefix "HowToSupply"
    /// <summary>
    /// An explanation in the instructions for how to achieve a result. It provides supplementary information about a technique, supply, author's preference, etc. It can explain what could be done, or what should not be done, but doesn't specify what should be done (see HowToDirection).
    /// <see href="https://schema.org/HowToTip"></see></summary>
    let HowToTip = _prefix "HowToTip"
    /// <summary>
    /// A tool used (but not consumed) when performing instructions for how to achieve a result.
    /// <see href="https://schema.org/HowToTool"></see></summary>
    let HowToTool = _prefix "HowToTool"
    /// <summary>
    /// A HyperToc represents a hypertext table of contents for complex media objects, such as [[VideoObject]], [[AudioObject]]. Items in the table of contents are indicated using the [[tocEntry]] property, and typed [[HyperTocEntry]]. For cases where the same larger work is split into multiple files, [[associatedMedia]] can be used on individual [[HyperTocEntry]] items.
    /// <see href="https://schema.org/HyperToc"></see></summary>
    let HyperToc = _prefix "HyperToc"
    /// <summary>
    /// A HyperToEntry is an item within a [[HyperToc]], which represents a hypertext table of contents for complex media objects, such as [[VideoObject]], [[AudioObject]]. The media object itself is indicated using [[associatedMedia]]. Each section of interest within that content can be described with a [[HyperTocEntry]], with associated [[startOffset]] and [[endOffset]]. When several entries are all from the same file, [[associatedMedia]] is used on the overarching [[HyperTocEntry]]; if the content has been split into multiple files, they can be referenced using [[associatedMedia]] on each [[HyperTocEntry]].
    /// <see href="https://schema.org/HyperTocEntry"></see></summary>
    let HyperTocEntry = _prefix "HyperTocEntry"
    /// <summary>
    /// Represents the broad notion of iOS-based operating systems.
    /// <see href="https://schema.org/IOSPlatform"></see></summary>
    let IOSPlatform = _prefix "IOSPlatform"
    /// <summary>
    /// MediaEnumeration enumerations are lists of codes, labels etc. useful for describing media objects. They may be reflections of externally developed lists, or created at schema.org, or a combination.
    /// <see href="https://schema.org/MediaEnumeration"></see></summary>
    let MediaEnumeration = _prefix "MediaEnumeration"
    /// <summary>
    /// ITCooperativeCharity: Non-profit type referring to Cooperatives with charitable missions (Ital. Cooperativa Sociale) according to Italian Law 112 of 2017.
    /// <see href="https://schema.org/ITCooperativeCharity"></see></summary>
    let ITCooperativeCharity = _prefix "ITCooperativeCharity"
    /// <summary>
    /// ITNonprofitType: Non-profit organization type originating from Italy.
    /// <see href="https://schema.org/ITNonprofitType"></see></summary>
    let ITNonprofitType = _prefix "ITNonprofitType"
    /// <summary>
    /// ITMutualAidCharity: Non-profit type referring to associations providing financial aid to people need (Ital. Società di mutuo soccorso or SOMS) according to Italian Law 3818 of 1886.
    /// <see href="https://schema.org/ITMutualAidCharity"></see></summary>
    let ITMutualAidCharity = _prefix "ITMutualAidCharity"
    /// <summary>
    /// ITSocialCompanyCharity: Non-profit type referring to companies with charitable missions (Ital. Imprese Sociali or IS) according to Italian Law 112 of 2017.
    /// <see href="https://schema.org/ITSocialCompanyCharity"></see></summary>
    let ITSocialCompanyCharity = _prefix "ITSocialCompanyCharity"
    /// <summary>
    /// ITSocialPromotionCharity: Non-profit type referring to associations promoting charitable causes (Ital. Associazioni di promozione sociale or APS) according to Italian Law 383 of 2000.
    /// <see href="https://schema.org/ITSocialPromotionCharity"></see></summary>
    let ITSocialPromotionCharity = _prefix "ITSocialPromotionCharity"
    /// <summary>
    /// ITSportCompanyCharity: Non-profit type referring to Companies that organize sports activities for the public or inscribed members (Ital. Società Sportiva Dilettantistica or SSD) according to Italian Law 289 of 2002.
    /// <see href="https://schema.org/ITSportCompanyCharity"></see></summary>
    let ITSportCompanyCharity = _prefix "ITSportCompanyCharity"
    /// <summary>
    /// ITVolunteerAssociationCharity: Non-profit type referring to associations organising charitable volunteer activities (Ital. Organizzazioni di volontariato or ODV) according to Italian Law 266 of 1991.
    /// <see href="https://schema.org/ITVolunteerAssociationCharity"></see></summary>
    let ITVolunteerAssociationCharity = _prefix "ITVolunteerAssociationCharity"
    /// <summary>
    /// An ice cream shop.
    /// <see href="https://schema.org/IceCreamShop"></see></summary>
    let IceCreamShop = _prefix "IceCreamShop"
    /// <summary>
    /// The act of intentionally disregarding the object. An agent ignores an object.
    /// <see href="https://schema.org/IgnoreAction"></see></summary>
    let IgnoreAction = _prefix "IgnoreAction"
    /// <summary>
    /// Web page type: Image gallery page.
    /// <see href="https://schema.org/ImageGallery"></see></summary>
    let ImageGallery = _prefix "ImageGallery"
    /// <summary>
    /// Web page type: Media gallery page. A mixed-media page that can contain media such as images, videos, and other multimedia.
    /// <see href="https://schema.org/MediaGallery"></see></summary>
    let MediaGallery = _prefix "MediaGallery"
    /// <summary>
    /// A specific and exact (byte-for-byte) version of an [[ImageObject]]. Two byte-for-byte identical files, for the purposes of this type, considered identical. If they have different embedded metadata (e.g. XMP, EXIF) the files will differ. Different external facts about the files, e.g. creator or dateCreated that aren't represented in their actual content, do not affect this notion of identity.
    /// <see href="https://schema.org/ImageObjectSnapshot"></see></summary>
    let ImageObjectSnapshot = _prefix "ImageObjectSnapshot"
    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes.
    /// <see href="https://schema.org/ImagingTest"></see></summary>
    let ImagingTest = _prefix "ImagingTest"
    /// <summary>
    /// Indicates that a legislation is in force.
    /// <see href="https://schema.org/InForce"></see></summary>
    let InForce = _prefix "InForce"
    /// <summary>
    /// A list of possible statuses for the legal force of a legislation.
    /// <see href="https://schema.org/LegalForceStatus"></see></summary>
    let LegalForceStatus = _prefix "LegalForceStatus"
    /// <summary>
    /// Indicates that the item is in stock.
    /// <see href="https://schema.org/InStock"></see></summary>
    let InStock = _prefix "InStock"
    /// <summary>
    /// Indicates that the item is available only at physical locations.
    /// <see href="https://schema.org/InStoreOnly"></see></summary>
    let InStoreOnly = _prefix "InStoreOnly"
    /// <summary>
    /// Payment in advance in some form of shop or kiosk for goods purchased online.
    /// <see href="https://schema.org/InStorePrepay"></see></summary>
    let InStorePrepay = _prefix "InStorePrepay"
    /// <summary>
    /// The types of expenses that are covered by the incentive. For example some incentives are only for the goods (tangible items) but the services (labor) are excluded.
    /// <see href="https://schema.org/IncentiveQualifiedExpenseType"></see></summary>
    let IncentiveQualifiedExpenseType = _prefix "IncentiveQualifiedExpenseType"

    /// <summary>
    /// This incentive applies to goods only.
    /// <see href="https://schema.org/IncentiveQualifiedExpenseTypeGoodsOnly"></see></summary>
    let IncentiveQualifiedExpenseTypeGoodsOnly =
        _prefix "IncentiveQualifiedExpenseTypeGoodsOnly"

    /// <summary>
    /// This incentive can apply to either goods or services (or both).
    /// <see href="https://schema.org/IncentiveQualifiedExpenseTypeGoodsOrServices"></see></summary>
    let IncentiveQualifiedExpenseTypeGoodsOrServices =
        _prefix "IncentiveQualifiedExpenseTypeGoodsOrServices"

    /// <summary>
    /// This incentive applies to services only.
    /// <see href="https://schema.org/IncentiveQualifiedExpenseTypeServicesOnly"></see></summary>
    let IncentiveQualifiedExpenseTypeServicesOnly =
        _prefix "IncentiveQualifiedExpenseTypeServicesOnly"

    /// <summary>
    /// This incentive applies to utility bills.
    /// <see href="https://schema.org/IncentiveQualifiedExpenseTypeUtilityBill"></see></summary>
    let IncentiveQualifiedExpenseTypeUtilityBill =
        _prefix "IncentiveQualifiedExpenseTypeUtilityBill"

    /// <summary>
    /// Enumerates a status for an incentive, such as whether it is active.
    /// <see href="https://schema.org/IncentiveStatus"></see></summary>
    let IncentiveStatus = _prefix "IncentiveStatus"
    /// <summary>
    /// This incentive is currently active.
    /// <see href="https://schema.org/IncentiveStatusActive"></see></summary>
    let IncentiveStatusActive = _prefix "IncentiveStatusActive"
    /// <summary>
    /// This incentive is currently being developed, and may become active/retired in the future.
    /// <see href="https://schema.org/IncentiveStatusInDevelopment"></see></summary>
    let IncentiveStatusInDevelopment = _prefix "IncentiveStatusInDevelopment"
    /// <summary>
    /// This incentive is currently active, but may not be accepting new applicants (e.g. max number of redemptions reached for a year)
    /// <see href="https://schema.org/IncentiveStatusOnHold"></see></summary>
    let IncentiveStatusOnHold = _prefix "IncentiveStatusOnHold"
    /// <summary>
    /// This incentive is not longer available.
    /// <see href="https://schema.org/IncentiveStatusRetired"></see></summary>
    let IncentiveStatusRetired = _prefix "IncentiveStatusRetired"
    /// <summary>
    /// Enumerates common financial incentives for products, including tax credits, tax deductions, rebates and subsidies, etc.
    /// <see href="https://schema.org/IncentiveType"></see></summary>
    let IncentiveType = _prefix "IncentiveType"
    /// <summary>
    /// An incentive where the recipient can receive additional funding for the purchase/lease of the good/service, which must be paid back.
    /// <see href="https://schema.org/IncentiveTypeLoan"></see></summary>
    let IncentiveTypeLoan = _prefix "IncentiveTypeLoan"
    /// <summary>
    /// An incentive that reduces the purchase/lease cost of the good/service in question.
    /// <see href="https://schema.org/IncentiveTypeRebateOrSubsidy"></see></summary>
    let IncentiveTypeRebateOrSubsidy = _prefix "IncentiveTypeRebateOrSubsidy"
    /// <summary>
    /// An incentive that directly reduces the amount of tax owed by the recipient.
    /// <see href="https://schema.org/IncentiveTypeTaxCredit"></see></summary>
    let IncentiveTypeTaxCredit = _prefix "IncentiveTypeTaxCredit"
    /// <summary>
    /// An incentive that reduces the recipient's amount of taxable income.
    /// <see href="https://schema.org/IncentiveTypeTaxDeduction"></see></summary>
    let IncentiveTypeTaxDeduction = _prefix "IncentiveTypeTaxDeduction"
    /// <summary>
    /// An incentive that reduces/exempts the recipient from taxation applicable to the incentivized good/service (e.g. luxury taxes, registration taxes, circulation tax).
    /// <see href="https://schema.org/IncentiveTypeTaxWaiver"></see></summary>
    let IncentiveTypeTaxWaiver = _prefix "IncentiveTypeTaxWaiver"
    /// <summary>
    /// An individual medical practitioner. For their official address use [[address]], for affiliations to hospitals use [[hospitalAffiliation]].
    /// The [[practicesAt]] property can be used to indicate [[MedicalOrganization]] hospitals, clinics, pharmacies etc. where this physician practices.
    /// <see href="https://schema.org/IndividualPhysician"></see></summary>
    let IndividualPhysician = _prefix "IndividualPhysician"
    /// <summary>
    /// An individual physician or a physician's office considered as a [[MedicalOrganization]].
    /// <see href="https://schema.org/Physician"></see></summary>
    let Physician = _prefix "Physician"
    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// <see href="https://schema.org/IndividualProduct"></see></summary>
    let IndividualProduct = _prefix "IndividualProduct"
    /// <summary>
    /// A datasheet or vendor specification of a product (in the sense of a prototypical description).
    /// <see href="https://schema.org/ProductModel"></see></summary>
    let ProductModel = _prefix "ProductModel"
    /// <summary>
    /// Something in medical science that pertains to infectious diseases, i.e. caused by bacterial, viral, fungal or parasitic infections.
    /// <see href="https://schema.org/Infectious"></see></summary>
    let Infectious = _prefix "Infectious"
    /// <summary>
    /// An infectious disease is a clinically evident human disease resulting from the presence of pathogenic microbial agents, like pathogenic viruses, pathogenic bacteria, fungi, protozoa, multicellular parasites, and prions. To be considered an infectious disease, such pathogens are known to be able to cause this disease.
    /// <see href="https://schema.org/InfectiousDisease"></see></summary>
    let InfectiousDisease = _prefix "InfectiousDisease"
    /// <summary>
    /// Any condition of the human body that affects the normal functioning of a person, whether physically or mentally. Includes diseases, injuries, disabilities, disorders, syndromes, etc.
    /// <see href="https://schema.org/MedicalCondition"></see></summary>
    let MedicalCondition = _prefix "MedicalCondition"
    /// <summary>
    /// Content discussing ingredients-related aspects of a health topic.
    /// <see href="https://schema.org/IngredientsHealthAspect"></see></summary>
    let IngredientsHealthAspect = _prefix "IngredientsHealthAspect"
    /// <summary>
    /// The act of installing an application.
    /// <see href="https://schema.org/InstallAction"></see></summary>
    let InstallAction = _prefix "InstallAction"
    /// <summary>
    /// Represents the installment pricing component of the total price for an offered product.
    /// <see href="https://schema.org/Installment"></see></summary>
    let Installment = _prefix "Installment"
    /// <summary>
    /// An Insurance agency.
    /// <see href="https://schema.org/InsuranceAgency"></see></summary>
    let InsuranceAgency = _prefix "InsuranceAgency"
    /// <summary>
    /// Data type: Integer.
    /// <see href="https://schema.org/Integer"></see></summary>
    let Integer = _prefix "Integer"
    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// <see href="https://schema.org/InteractionCounter"></see></summary>
    let InteractionCounter = _prefix "InteractionCounter"
    /// <summary>
    /// An international trial.
    /// <see href="https://schema.org/InternationalTrial"></see></summary>
    let InternationalTrial = _prefix "InternationalTrial"
    /// <summary>
    /// An internet cafe.
    /// <see href="https://schema.org/InternetCafe"></see></summary>
    let InternetCafe = _prefix "InternetCafe"
    /// <summary>
    /// A company or fund that gathers capital from a number of investors to create a pool of money that is then re-invested into stocks, bonds and other assets.
    /// <see href="https://schema.org/InvestmentFund"></see></summary>
    let InvestmentFund = _prefix "InvestmentFund"
    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// <see href="https://schema.org/InviteAction"></see></summary>
    let InviteAction = _prefix "InviteAction"
    /// <summary>
    /// A statement of the money due for goods or services; a bill.
    /// <see href="https://schema.org/Invoice"></see></summary>
    let Invoice = _prefix "Invoice"
    /// <summary>
    /// Represents the invoice price of an offered product.
    /// <see href="https://schema.org/InvoicePrice"></see></summary>
    let InvoicePrice = _prefix "InvoicePrice"
    /// <summary>
    /// Enumerates different price types, for example list price, invoice price, and sale price.
    /// <see href="https://schema.org/PriceTypeEnumeration"></see></summary>
    let PriceTypeEnumeration = _prefix "PriceTypeEnumeration"
    /// <summary>
    /// An ItemList ordered with lower values listed first.
    /// <see href="https://schema.org/ItemListOrderAscending"></see></summary>
    let ItemListOrderAscending = _prefix "ItemListOrderAscending"
    /// <summary>
    /// Enumerated for values for itemListOrder for indicating how an ordered ItemList is organized.
    /// <see href="https://schema.org/ItemListOrderType"></see></summary>
    let ItemListOrderType = _prefix "ItemListOrderType"
    /// <summary>
    /// An ItemList ordered with higher values listed first.
    /// <see href="https://schema.org/ItemListOrderDescending"></see></summary>
    let ItemListOrderDescending = _prefix "ItemListOrderDescending"
    /// <summary>
    /// An ItemList ordered with no explicit order.
    /// <see href="https://schema.org/ItemListUnordered"></see></summary>
    let ItemListUnordered = _prefix "ItemListUnordered"
    /// <summary>
    /// A page devoted to a single item, such as a particular product or hotel.
    /// <see href="https://schema.org/ItemPage"></see></summary>
    let ItemPage = _prefix "ItemPage"
    /// <summary>
    /// A jewelry store.
    /// <see href="https://schema.org/JewelryStore"></see></summary>
    let JewelryStore = _prefix "JewelryStore"
    /// <summary>
    /// A listing that describes a job opening in a certain organization.
    /// <see href="https://schema.org/JobPosting"></see></summary>
    let JobPosting = _prefix "JobPosting"
    /// <summary>
    /// An agent joins an event/group with participants/friends at a location.\n\nRelated actions:\n\n* [[RegisterAction]]: Unlike RegisterAction, JoinAction refers to joining a group/team of people.\n* [[SubscribeAction]]: Unlike SubscribeAction, JoinAction does not imply that you'll be receiving updates.\n* [[FollowAction]]: Unlike FollowAction, JoinAction does not imply that you'll be polling for updates.
    /// <see href="https://schema.org/JoinAction"></see></summary>
    let JoinAction = _prefix "JoinAction"
    /// <summary>
    /// The anatomical location at which two or more bones make contact.
    /// <see href="https://schema.org/Joint"></see></summary>
    let Joint = _prefix "Joint"
    /// <summary>
    /// Specifies that the consumer can keep the product, even when receiving a refund or store credit.
    /// <see href="https://schema.org/KeepProduct"></see></summary>
    let KeepProduct = _prefix "KeepProduct"
    /// <summary>
    /// Enumerates several types of product return methods.
    /// <see href="https://schema.org/ReturnMethodEnumeration"></see></summary>
    let ReturnMethodEnumeration = _prefix "ReturnMethodEnumeration"
    /// <summary>
    /// A diet conforming to Jewish dietary practices.
    /// <see href="https://schema.org/KosherDiet"></see></summary>
    let KosherDiet = _prefix "KosherDiet"
    /// <summary>
    /// A medical science pertaining to chemical, hematological, immunologic, microscopic, or bacteriological diagnostic analyses or research.
    /// <see href="https://schema.org/LaboratoryScience"></see></summary>
    let LaboratoryScience = _prefix "LaboratoryScience"
    /// <summary>
    /// A lake (for example, Lake Pontrachain).
    /// <see href="https://schema.org/LakeBodyOfWater"></see></summary>
    let LakeBodyOfWater = _prefix "LakeBodyOfWater"
    /// <summary>
    /// An historical landmark or building.
    /// <see href="https://schema.org/LandmarksOrHistoricalBuildings"></see></summary>
    let LandmarksOrHistoricalBuildings = _prefix "LandmarksOrHistoricalBuildings"
    /// <summary>
    /// Natural languages such as Spanish, Tamil, Hindi, English, etc. Formal language code tags expressed in [BCP 47](https://en.wikipedia.org/wiki/IETF_language_tag) can be used via the [[alternateName]] property. The Language type previously also covered programming languages such as Scheme and Lisp, which are now best represented using [[ComputerLanguage]].
    /// <see href="https://schema.org/Language"></see></summary>
    let Language = _prefix "Language"
    /// <summary>
    /// LaserDiscFormat.
    /// <see href="https://schema.org/LaserDiscFormat"></see></summary>
    let LaserDiscFormat = _prefix "LaserDiscFormat"
    /// <summary>
    /// An agent leaves an event / group with participants/friends at a location.\n\nRelated actions:\n\n* [[JoinAction]]: The antonym of LeaveAction.\n* [[UnRegisterAction]]: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.
    /// <see href="https://schema.org/LeaveAction"></see></summary>
    let LeaveAction = _prefix "LeaveAction"
    /// <summary>
    /// The steering position is on the left side of the vehicle (viewed from the main direction of driving).
    /// <see href="https://schema.org/LeftHandDriving"></see></summary>
    let LeftHandDriving = _prefix "LeftHandDriving"
    /// <summary>
    /// A value indicating a steering position.
    /// <see href="https://schema.org/SteeringPositionValue"></see></summary>
    let SteeringPositionValue = _prefix "SteeringPositionValue"
    /// <summary>
    /// A legal document such as an act, decree, bill, etc. (enforceable or not) or a component of a legal act (like an article).
    /// <see href="https://schema.org/Legislation"></see></summary>
    let Legislation = _prefix "Legislation"
    /// <summary>
    /// A specific object or file containing a Legislation. Note that the same Legislation can be published in multiple files. For example, a digitally signed PDF, a plain PDF and an HTML version.
    /// <see href="https://schema.org/LegislationObject"></see></summary>
    let LegislationObject = _prefix "LegislationObject"
    /// <summary>
    /// A legislative building&amp;#x2014;for example, the state capitol.
    /// <see href="https://schema.org/LegislativeBuilding"></see></summary>
    let LegislativeBuilding = _prefix "LegislativeBuilding"
    /// <summary>
    /// Any physical activity engaged in for recreational purposes. Examples may include ballroom dancing, roller skating, canoeing, fishing, etc.
    /// <see href="https://schema.org/LeisureTimeActivity"></see></summary>
    let LeisureTimeActivity = _prefix "LeisureTimeActivity"
    /// <summary>
    /// The act of providing an object under an agreement that it will be returned at a later date. Reciprocal of BorrowAction.\n\nRelated actions:\n\n* [[BorrowAction]]: Reciprocal of LendAction.
    /// <see href="https://schema.org/LendAction"></see></summary>
    let LendAction = _prefix "LendAction"
    /// <summary>
    /// A library.
    /// <see href="https://schema.org/Library"></see></summary>
    let Library = _prefix "Library"
    /// <summary>
    /// A [[LibrarySystem]] is a collaborative system amongst several libraries.
    /// <see href="https://schema.org/LibrarySystem"></see></summary>
    let LibrarySystem = _prefix "LibrarySystem"
    /// <summary>
    /// A short band of tough, flexible, fibrous connective tissue that functions to connect multiple bones, cartilages, and structurally support joints.
    /// <see href="https://schema.org/Ligament"></see></summary>
    let Ligament = _prefix "Ligament"
    /// <summary>
    /// The act of expressing a positive sentiment about the object. An agent likes an object (a proposition, topic or theme) with participants.
    /// <see href="https://schema.org/LikeAction"></see></summary>
    let LikeAction = _prefix "LikeAction"
    /// <summary>
    /// Indicates that the item has limited availability.
    /// <see href="https://schema.org/LimitedAvailability"></see></summary>
    let LimitedAvailability = _prefix "LimitedAvailability"
    /// <summary>
    /// LimitedByGuaranteeCharity: Non-profit type referring to a charitable company that is limited by guarantee (UK).
    /// <see href="https://schema.org/LimitedByGuaranteeCharity"></see></summary>
    let LimitedByGuaranteeCharity = _prefix "LimitedByGuaranteeCharity"
    /// <summary>
    /// A Role that represents a Web link, e.g. as expressed via the 'url' property. Its linkRelationship property can indicate URL-based and plain textual link types, e.g. those in IANA link registry or others such as 'amphtml'. This structure provides a placeholder where details from HTML's link element can be represented outside of HTML, e.g. in JSON-LD feeds.
    /// <see href="https://schema.org/LinkRole"></see></summary>
    let LinkRole = _prefix "LinkRole"
    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.\n\nSee also [blog post](https://blog.schema.org/2014/06/16/introducing-role/).
    /// <see href="https://schema.org/Role"></see></summary>
    let Role = _prefix "Role"
    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// <see href="https://schema.org/LiquorStore"></see></summary>
    let LiquorStore = _prefix "LiquorStore"
    /// <summary>
    /// Represents the list price of an offered product. Typically the same as the [MSRP](https://schema.org/MSRP).
    /// <see href="https://schema.org/ListPrice"></see></summary>
    let ListPrice = _prefix "ListPrice"
    /// <summary>
    /// The act of consuming audio content.
    /// <see href="https://schema.org/ListenAction"></see></summary>
    let ListenAction = _prefix "ListenAction"
    /// <summary>
    /// Event type: Literary event.
    /// <see href="https://schema.org/LiteraryEvent"></see></summary>
    let LiteraryEvent = _prefix "LiteraryEvent"
    /// <summary>
    /// LiveAlbum.
    /// <see href="https://schema.org/LiveAlbum"></see></summary>
    let LiveAlbum = _prefix "LiveAlbum"
    /// <summary>
    /// A [[LiveBlogPosting]] is a [[BlogPosting]] intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// <see href="https://schema.org/LiveBlogPosting"></see></summary>
    let LiveBlogPosting = _prefix "LiveBlogPosting"
    /// <summary>
    /// Information about coping or life related to the topic.
    /// <see href="https://schema.org/LivingWithHealthAspect"></see></summary>
    let LivingWithHealthAspect = _prefix "LivingWithHealthAspect"
    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// <see href="https://schema.org/LocationFeatureSpecification"></see></summary>
    let LocationFeatureSpecification = _prefix "LocationFeatureSpecification"
    /// <summary>
    /// A property-value pair, e.g. representing a feature of a product or place. Use the 'name' property for the name of the property. If there is an additional human-readable version of the value, put that into the 'description' property.\n\n Always use specific schema.org properties when a) they exist and b) you can populate them. Using PropertyValue as a substitute will typically not trigger the same effect as using the original, specific property.
    ///
    /// <see href="https://schema.org/PropertyValue"></see></summary>
    let PropertyValue = _prefix "PropertyValue"
    /// <summary>
    /// A DeliveryMethod in which an item is made available via locker.
    /// <see href="https://schema.org/LockerDelivery"></see></summary>
    let LockerDelivery = _prefix "LockerDelivery"
    /// <summary>
    /// A locksmith.
    /// <see href="https://schema.org/Locksmith"></see></summary>
    let Locksmith = _prefix "Locksmith"
    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// <see href="https://schema.org/LodgingReservation"></see></summary>
    let LodgingReservation = _prefix "LodgingReservation"
    /// <summary>
    /// The action of logging into a device or application.
    /// <see href="https://schema.org/LoginAction"></see></summary>
    let LoginAction = _prefix "LoginAction"
    /// <summary>
    /// Unlike cross-sectional studies, longitudinal studies track the same people, and therefore the differences observed in those people are less likely to be the result of cultural differences across generations. Longitudinal studies are also used in medicine to uncover predictors of certain diseases.
    /// <see href="https://schema.org/Longitudinal"></see></summary>
    let Longitudinal = _prefix "Longitudinal"
    /// <summary>
    /// The act of being defeated in a competitive activity.
    /// <see href="https://schema.org/LoseAction"></see></summary>
    let LoseAction = _prefix "LoseAction"
    /// <summary>
    /// A diet focused on reduced calorie intake.
    /// <see href="https://schema.org/LowCalorieDiet"></see></summary>
    let LowCalorieDiet = _prefix "LowCalorieDiet"
    /// <summary>
    /// A diet focused on reduced fat and cholesterol intake.
    /// <see href="https://schema.org/LowFatDiet"></see></summary>
    let LowFatDiet = _prefix "LowFatDiet"
    /// <summary>
    /// A diet appropriate for people with lactose intolerance.
    /// <see href="https://schema.org/LowLactoseDiet"></see></summary>
    let LowLactoseDiet = _prefix "LowLactoseDiet"
    /// <summary>
    /// A diet focused on reduced sodium intake.
    /// <see href="https://schema.org/LowSaltDiet"></see></summary>
    let LowSaltDiet = _prefix "LowSaltDiet"
    /// <summary>
    /// Lung and respiratory system clinical examination.
    /// <see href="https://schema.org/Lung"></see></summary>
    let Lung = _prefix "Lung"
    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// <see href="https://schema.org/LymphaticVessel"></see></summary>
    let LymphaticVessel = _prefix "LymphaticVessel"
    /// <summary>
    /// Magnetic resonance imaging.
    /// <see href="https://schema.org/MRI"></see></summary>
    let MRI = _prefix "MRI"
    /// <summary>
    /// Represents the manufacturer suggested retail price ("MSRP") of an offered product.
    /// <see href="https://schema.org/MSRP"></see></summary>
    let MSRP = _prefix "MSRP"
    /// <summary>
    /// Indicates that the item is made to order (custom made).
    /// <see href="https://schema.org/MadeToOrder"></see></summary>
    let MadeToOrder = _prefix "MadeToOrder"
    /// <summary>
    /// The male gender.
    /// <see href="https://schema.org/Male"></see></summary>
    let Male = _prefix "Male"
    /// <summary>
    /// A book, document, or piece of music written by hand rather than typed or printed.
    /// <see href="https://schema.org/Manuscript"></see></summary>
    let Manuscript = _prefix "Manuscript"
    /// <summary>
    /// A map.
    /// <see href="https://schema.org/Map"></see></summary>
    let Map = _prefix "Map"
    /// <summary>
    /// An enumeration of several kinds of Map.
    /// <see href="https://schema.org/MapCategoryType"></see></summary>
    let MapCategoryType = _prefix "MapCategoryType"
    /// <summary>
    /// The act of marrying a person.
    /// <see href="https://schema.org/MarryAction"></see></summary>
    let MarryAction = _prefix "MarryAction"
    /// <summary>
    /// Properties that take Mass as values are of the form '&amp;lt;Number&amp;gt; &amp;lt;Mass unit of measure&amp;gt;'. E.g., '7 kg'.
    /// <see href="https://schema.org/Mass"></see></summary>
    let Mass = _prefix "Mass"
    /// <summary>
    /// A math solver which is capable of solving a subset of mathematical problems.
    /// <see href="https://schema.org/MathSolver"></see></summary>
    let MathSolver = _prefix "MathSolver"
    /// <summary>
    /// The maximum dosing schedule considered safe for a drug or supplement as recommended by an authority or by the drug/supplement's manufacturer. Capture the recommending authority in the recognizingAuthority property of MedicalEntity.
    /// <see href="https://schema.org/MaximumDoseSchedule"></see></summary>
    let MaximumDoseSchedule = _prefix "MaximumDoseSchedule"
    /// <summary>
    /// Related topics may be treated by a Topic.
    /// <see href="https://schema.org/MayTreatHealthAspect"></see></summary>
    let MayTreatHealthAspect = _prefix "MayTreatHealthAspect"
    /// <summary>
    /// A [[MediaReview]] is a more specialized form of Review dedicated to the evaluation of media content online, typically in the context of fact-checking and misinformation.
    ///     For more general reviews of media in the broader sense, use [[UserReview]], [[CriticReview]] or other [[Review]] types. This definition is
    ///     a work in progress. While the [[MediaManipulationRatingEnumeration]] list reflects significant community review amongst fact-checkers and others working
    ///     to combat misinformation, the specific structures for representing media objects, their versions and publication context, are still evolving. Similarly, best practices for the relationship between [[MediaReview]] and [[ClaimReview]] markup have not yet been finalized.
    /// <see href="https://schema.org/MediaReview"></see></summary>
    let MediaReview = _prefix "MediaReview"
    /// <summary>
    /// Represents an item or group of closely related items treated as a unit for the sake of evaluation in a [[MediaReview]]. Authorship etc. apply to the items rather than to the curation/grouping or reviewing party.
    /// <see href="https://schema.org/MediaReviewItem"></see></summary>
    let MediaReviewItem = _prefix "MediaReviewItem"
    /// <summary>
    /// A subscription which allows a user to access media including audio, video, books, etc.
    /// <see href="https://schema.org/MediaSubscription"></see></summary>
    let MediaSubscription = _prefix "MediaSubscription"
    /// <summary>
    /// Target audiences for medical web pages.
    /// <see href="https://schema.org/MedicalAudience"></see></summary>
    let MedicalAudience = _prefix "MedicalAudience"
    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// <see href="https://schema.org/PeopleAudience"></see></summary>
    let PeopleAudience = _prefix "PeopleAudience"
    /// <summary>
    /// The causative agent(s) that are responsible for the pathophysiologic process that eventually results in a medical condition, symptom or sign. In this schema, unless otherwise specified this is meant to be the proximate cause of the medical condition, symptom or sign. The proximate cause is defined as the causative agent that most directly results in the medical condition, symptom or sign. For example, the HIV virus could be considered a cause of AIDS. Or in a diagnostic context, if a patient fell and sustained a hip fracture and two days later sustained a pulmonary embolism which eventuated in a cardiac arrest, the cause of the cardiac arrest (the proximate cause) would be the pulmonary embolism and not the fall. Medical causes can include cardiovascular, chemical, dermatologic, endocrine, environmental, gastroenterologic, genetic, hematologic, gynecologic, iatrogenic, infectious, musculoskeletal, neurologic, nutritional, obstetric, oncologic, otolaryngologic, pharmacologic, psychiatric, pulmonary, renal, rheumatologic, toxic, traumatic, or urologic causes; medical conditions can be causes as well.
    /// <see href="https://schema.org/MedicalCause"></see></summary>
    let MedicalCause = _prefix "MedicalCause"
    /// <summary>
    /// A code for a medical entity.
    /// <see href="https://schema.org/MedicalCode"></see></summary>
    let MedicalCode = _prefix "MedicalCode"
    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// <see href="https://schema.org/MedicalConditionStage"></see></summary>
    let MedicalConditionStage = _prefix "MedicalConditionStage"
    /// <summary>
    /// A condition or factor that serves as a reason to withhold a certain medical therapy. Contraindications can be absolute (there are no reasonable circumstances for undertaking a course of action) or relative (the patient is at higher risk of complications, but these risks may be outweighed by other considerations or mitigated by other measures).
    /// <see href="https://schema.org/MedicalContraindication"></see></summary>
    let MedicalContraindication = _prefix "MedicalContraindication"
    /// <summary>
    /// Any object used in a medical capacity, such as to diagnose or treat a patient.
    /// <see href="https://schema.org/MedicalDevice"></see></summary>
    let MedicalDevice = _prefix "MedicalDevice"
    /// <summary>
    /// Any recommendation made by a standard society (e.g. ACC/AHA) or consensus statement that denotes how to diagnose and treat a particular condition. Note: this type should be used to tag the actual guideline recommendation; if the guideline recommendation occurs in a larger scholarly article, use MedicalScholarlyArticle to tag the overall article, not this type. Note also: the organization making the recommendation should be captured in the recognizingAuthority base property of MedicalEntity.
    /// <see href="https://schema.org/MedicalGuideline"></see></summary>
    let MedicalGuideline = _prefix "MedicalGuideline"
    /// <summary>
    /// A guideline contraindication that designates a process as harmful and where quality of the data supporting the contraindication is sound.
    /// <see href="https://schema.org/MedicalGuidelineContraindication"></see></summary>
    let MedicalGuidelineContraindication = _prefix "MedicalGuidelineContraindication"
    /// <summary>
    /// A guideline recommendation that is regarded as efficacious and where quality of the data supporting the recommendation is sound.
    /// <see href="https://schema.org/MedicalGuidelineRecommendation"></see></summary>
    let MedicalGuidelineRecommendation = _prefix "MedicalGuidelineRecommendation"
    /// <summary>
    /// An observational study is a type of medical study that attempts to infer the possible effect of a treatment through observation of a cohort of subjects over a period of time. In an observational study, the assignment of subjects into treatment groups versus control groups is outside the control of the investigator. This is in contrast with controlled studies, such as the randomized controlled trials represented by MedicalTrial, where each subject is randomly assigned to a treatment group or a control group before the start of the treatment.
    /// <see href="https://schema.org/MedicalObservationalStudy"></see></summary>
    let MedicalObservationalStudy = _prefix "MedicalObservationalStudy"
    /// <summary>
    /// A medical study is an umbrella type covering all kinds of research studies relating to human medicine or health, including observational studies and interventional trials and registries, randomized, controlled or not. When the specific type of study is known, use one of the extensions of this type, such as MedicalTrial or MedicalObservationalStudy. Also, note that this type should be used to mark up data that describes the study itself; to tag an article that publishes the results of a study, use MedicalScholarlyArticle. Note: use the code property of MedicalEntity to store study IDs, e.g. clinicaltrials.gov ID.
    /// <see href="https://schema.org/MedicalStudy"></see></summary>
    let MedicalStudy = _prefix "MedicalStudy"
    /// <summary>
    /// An enumeration that describes different types of medical procedures.
    /// <see href="https://schema.org/MedicalProcedureType"></see></summary>
    let MedicalProcedureType = _prefix "MedicalProcedureType"
    /// <summary>
    /// Medical researchers.
    /// <see href="https://schema.org/MedicalResearcher"></see></summary>
    let MedicalResearcher = _prefix "MedicalResearcher"
    /// <summary>
    /// A complex mathematical calculation requiring an online calculator, used to assess prognosis. Note: use the url property of Thing to record any URLs for online calculators.
    /// <see href="https://schema.org/MedicalRiskCalculator"></see></summary>
    let MedicalRiskCalculator = _prefix "MedicalRiskCalculator"
    /// <summary>
    /// Any rule set or interactive tool for estimating the risk of developing a complication or condition.
    /// <see href="https://schema.org/MedicalRiskEstimator"></see></summary>
    let MedicalRiskEstimator = _prefix "MedicalRiskEstimator"
    /// <summary>
    /// A risk factor is anything that increases a person's likelihood of developing or contracting a disease, medical condition, or complication.
    /// <see href="https://schema.org/MedicalRiskFactor"></see></summary>
    let MedicalRiskFactor = _prefix "MedicalRiskFactor"
    /// <summary>
    /// A simple system that adds up the number of risk factors to yield a score that is associated with prognosis, e.g. CHAD score, TIMI risk score.
    /// <see href="https://schema.org/MedicalRiskScore"></see></summary>
    let MedicalRiskScore = _prefix "MedicalRiskScore"
    /// <summary>
    /// A scholarly article in the medical domain.
    /// <see href="https://schema.org/MedicalScholarlyArticle"></see></summary>
    let MedicalScholarlyArticle = _prefix "MedicalScholarlyArticle"
    /// <summary>
    /// A scholarly article.
    /// <see href="https://schema.org/ScholarlyArticle"></see></summary>
    let ScholarlyArticle = _prefix "ScholarlyArticle"
    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// <see href="https://schema.org/MedicalSign"></see></summary>
    let MedicalSign = _prefix "MedicalSign"
    /// <summary>
    /// Any feature associated or not with a medical condition. In medicine a symptom is generally subjective while a sign is objective.
    /// <see href="https://schema.org/MedicalSignOrSymptom"></see></summary>
    let MedicalSignOrSymptom = _prefix "MedicalSignOrSymptom"
    /// <summary>
    /// Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.
    /// <see href="https://schema.org/Specialty"></see></summary>
    let Specialty = _prefix "Specialty"
    /// <summary>
    /// Any complaint sensed and expressed by the patient (therefore defined as subjective)  like stomachache, lower-back pain, or fatigue.
    /// <see href="https://schema.org/MedicalSymptom"></see></summary>
    let MedicalSymptom = _prefix "MedicalSymptom"
    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// <see href="https://schema.org/MedicalTestPanel"></see></summary>
    let MedicalTestPanel = _prefix "MedicalTestPanel"
    /// <summary>
    /// Any medical intervention designed to prevent, treat, and cure human diseases and medical conditions, including both curative and palliative therapies. Medical therapies are typically processes of care relying upon pharmacotherapy, behavioral therapy, supportive therapy (with fluid or nutrition for example), or detoxification (e.g. hemodialysis) aimed at improving or preventing a health condition.
    /// <see href="https://schema.org/MedicalTherapy"></see></summary>
    let MedicalTherapy = _prefix "MedicalTherapy"
    /// <summary>
    /// A medical procedure intended primarily for therapeutic purposes, aimed at improving a health condition.
    /// <see href="https://schema.org/TherapeuticProcedure"></see></summary>
    let TherapeuticProcedure = _prefix "TherapeuticProcedure"
    /// <summary>
    /// A medical trial is a type of medical study that uses a scientific process to compare the safety and efficacy of medical therapies or medical procedures. In general, medical trials are controlled and subjects are allocated at random to the different treatment and/or control groups.
    /// <see href="https://schema.org/MedicalTrial"></see></summary>
    let MedicalTrial = _prefix "MedicalTrial"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/WikiDoc"></see>
    /// </summary>
    let ``docs/collab/WikiDoc`` = _prefix "docs/collab/WikiDoc"
    /// <summary>
    /// A web page that provides medical information.
    /// <see href="https://schema.org/MedicalWebPage"></see></summary>
    let MedicalWebPage = _prefix "MedicalWebPage"
    /// <summary>
    /// A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Conference_hall"&gt;http://en.wikipedia.org/wiki/Conference_hall&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/MeetingRoom"></see></summary>
    let MeetingRoom = _prefix "MeetingRoom"
    /// <summary>
    /// A MemberProgram defines a loyalty (or membership) program that provides its members with certain benefits, for example better pricing, free shipping or returns, or the ability to earn loyalty points. Member programs may have multiple tiers, for example silver and gold members, each with different benefits.
    /// <see href="https://schema.org/MemberProgram"></see></summary>
    let MemberProgram = _prefix "MemberProgram"
    /// <summary>
    /// A MemberProgramTier specifies a tier under a loyalty (member) program, for example "gold".
    /// <see href="https://schema.org/MemberProgramTier"></see></summary>
    let MemberProgramTier = _prefix "MemberProgramTier"
    /// <summary>
    /// A men's clothing store.
    /// <see href="https://schema.org/MensClothingStore"></see></summary>
    let MensClothingStore = _prefix "MensClothingStore"
    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// <see href="https://schema.org/Menu"></see></summary>
    let Menu = _prefix "Menu"
    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// <see href="https://schema.org/MenuItem"></see></summary>
    let MenuItem = _prefix "MenuItem"
    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    /// <see href="https://schema.org/MenuSection"></see></summary>
    let MenuSection = _prefix "MenuSection"
    /// <summary>
    /// Enumerates several kinds of product return policies.
    /// <see href="https://schema.org/MerchantReturnEnumeration"></see></summary>
    let MerchantReturnEnumeration = _prefix "MerchantReturnEnumeration"
    /// <summary>
    /// Specifies that there is a finite window for product returns.
    /// <see href="https://schema.org/MerchantReturnFiniteReturnWindow"></see></summary>
    let MerchantReturnFiniteReturnWindow = _prefix "MerchantReturnFiniteReturnWindow"
    /// <summary>
    /// Specifies that product returns are not permitted.
    /// <see href="https://schema.org/MerchantReturnNotPermitted"></see></summary>
    let MerchantReturnNotPermitted = _prefix "MerchantReturnNotPermitted"
    /// <summary>
    /// A MerchantReturnPolicy provides information about product return policies associated with an [[Organization]], [[Product]], or [[Offer]].
    /// <see href="https://schema.org/MerchantReturnPolicy"></see></summary>
    let MerchantReturnPolicy = _prefix "MerchantReturnPolicy"

    /// <summary>
    /// A seasonal override of a return policy, for example used for holidays.
    /// <see href="https://schema.org/MerchantReturnPolicySeasonalOverride"></see></summary>
    let MerchantReturnPolicySeasonalOverride =
        _prefix "MerchantReturnPolicySeasonalOverride"

    /// <summary>
    /// Specifies that there is an unlimited window for product returns.
    /// <see href="https://schema.org/MerchantReturnUnlimitedWindow"></see></summary>
    let MerchantReturnUnlimitedWindow = _prefix "MerchantReturnUnlimitedWindow"
    /// <summary>
    /// Specifies that a product return policy is not provided.
    /// <see href="https://schema.org/MerchantReturnUnspecified"></see></summary>
    let MerchantReturnUnspecified = _prefix "MerchantReturnUnspecified"
    /// <summary>
    /// A middle school (typically for children aged around 11-14, although this varies somewhat).
    /// <see href="https://schema.org/MiddleSchool"></see></summary>
    let MiddleSchool = _prefix "MiddleSchool"
    /// <summary>
    /// A nurse-like health profession that deals with pregnancy, childbirth, and the postpartum period (including care of the newborn), besides sexual and reproductive health of women throughout their lives.
    /// <see href="https://schema.org/Midwifery"></see></summary>
    let Midwifery = _prefix "Midwifery"
    /// <summary>
    /// Represents the minimum advertised price ("MAP") (as dictated by the manufacturer) of an offered product.
    /// <see href="https://schema.org/MinimumAdvertisedPrice"></see></summary>
    let MinimumAdvertisedPrice = _prefix "MinimumAdvertisedPrice"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/minorHumanEdits"&gt;minor human edits&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/MinorHumanEditsDigitalSource"></see></summary>
    let MinorHumanEditsDigitalSource = _prefix "MinorHumanEditsDigitalSource"
    /// <summary>
    /// Content about common misconceptions and myths that are related to a topic.
    /// <see href="https://schema.org/MisconceptionsHealthAspect"></see></summary>
    let MisconceptionsHealthAspect = _prefix "MisconceptionsHealthAspect"
    /// <summary>
    /// MixedEventAttendanceMode - an event that is conducted as a combination of both offline and online modes.
    /// <see href="https://schema.org/MixedEventAttendanceMode"></see></summary>
    let MixedEventAttendanceMode = _prefix "MixedEventAttendanceMode"
    /// <summary>
    /// MixtapeAlbum.
    /// <see href="https://schema.org/MixtapeAlbum"></see></summary>
    let MixtapeAlbum = _prefix "MixtapeAlbum"
    /// <summary>
    /// A software application designed specifically to work well on a mobile device such as a telephone.
    /// <see href="https://schema.org/MobileApplication"></see></summary>
    let MobileApplication = _prefix "MobileApplication"
    /// <summary>
    /// A software application.
    /// <see href="https://schema.org/SoftwareApplication"></see></summary>
    let SoftwareApplication = _prefix "SoftwareApplication"
    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// <see href="https://schema.org/MobilePhoneStore"></see></summary>
    let MobilePhoneStore = _prefix "MobilePhoneStore"
    /// <summary>
    /// Represents the broad notion of 'mobile' browsers as a Web Platform.
    /// <see href="https://schema.org/MobileWebPlatform"></see></summary>
    let MobileWebPlatform = _prefix "MobileWebPlatform"
    /// <summary>
    /// Any constitutionally or isotopically distinct atom, molecule, ion, ion pair, radical, radical ion, complex, conformer etc., identifiable as a separately distinguishable entity.
    /// <see href="https://schema.org/MolecularEntity"></see></summary>
    let MolecularEntity = _prefix "MolecularEntity"
    /// <summary>
    /// The day of the week between Sunday and Tuesday.
    /// <see href="https://schema.org/Monday"></see></summary>
    let Monday = _prefix "Monday"
    /// <summary>
    /// A statistical distribution of monetary amounts.
    /// <see href="https://schema.org/MonetaryAmountDistribution"></see></summary>
    let MonetaryAmountDistribution = _prefix "MonetaryAmountDistribution"
    /// <summary>
    /// A statistical distribution of values.
    /// <see href="https://schema.org/QuantitativeValueDistribution"></see></summary>
    let QuantitativeValueDistribution = _prefix "QuantitativeValueDistribution"
    /// <summary>
    /// A monetary grant.
    /// <see href="https://schema.org/MonetaryGrant"></see></summary>
    let MonetaryGrant = _prefix "MonetaryGrant"
    /// <summary>
    /// The act of transferring money from one place to another place. This may occur electronically or physically.
    /// <see href="https://schema.org/MoneyTransfer"></see></summary>
    let MoneyTransfer = _prefix "MoneyTransfer"
    /// <summary>
    /// A loan in which property or real estate is used as collateral. (A loan securitized against some real estate.)
    /// <see href="https://schema.org/MortgageLoan"></see></summary>
    let MortgageLoan = _prefix "MortgageLoan"
    /// <summary>
    /// A mosque.
    /// <see href="https://schema.org/Mosque"></see></summary>
    let Mosque = _prefix "Mosque"
    /// <summary>
    /// A motel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/Motel"></see></summary>
    let Motel = _prefix "Motel"
    /// <summary>
    /// A motorcycle or motorbike is a single-track, two-wheeled motor vehicle.
    /// <see href="https://schema.org/Motorcycle"></see></summary>
    let Motorcycle = _prefix "Motorcycle"
    /// <summary>
    /// A motorcycle dealer.
    /// <see href="https://schema.org/MotorcycleDealer"></see></summary>
    let MotorcycleDealer = _prefix "MotorcycleDealer"
    /// <summary>
    /// A motorcycle repair shop.
    /// <see href="https://schema.org/MotorcycleRepair"></see></summary>
    let MotorcycleRepair = _prefix "MotorcycleRepair"
    /// <summary>
    /// A motorized bicycle is a bicycle with an attached motor used to power the vehicle, or to assist with pedaling.
    /// <see href="https://schema.org/MotorizedBicycle"></see></summary>
    let MotorizedBicycle = _prefix "MotorizedBicycle"
    /// <summary>
    /// A mountain, like Mount Whitney or Mount Everest.
    /// <see href="https://schema.org/Mountain"></see></summary>
    let Mountain = _prefix "Mountain"
    /// <summary>
    /// A movie.
    /// <see href="https://schema.org/Movie"></see></summary>
    let Movie = _prefix "Movie"
    /// <summary>
    /// A short segment/part of a movie.
    /// <see href="https://schema.org/MovieClip"></see></summary>
    let MovieClip = _prefix "MovieClip"
    /// <summary>
    /// A movie rental store.
    /// <see href="https://schema.org/MovieRentalStore"></see></summary>
    let MovieRentalStore = _prefix "MovieRentalStore"
    /// <summary>
    /// A series of movies. Included movies can be indicated with the hasPart property.
    /// <see href="https://schema.org/MovieSeries"></see></summary>
    let MovieSeries = _prefix "MovieSeries"
    /// <summary>
    /// A movie theater.
    /// <see href="https://schema.org/MovieTheater"></see></summary>
    let MovieTheater = _prefix "MovieTheater"
    /// <summary>
    /// A moving company.
    /// <see href="https://schema.org/MovingCompany"></see></summary>
    let MovingCompany = _prefix "MovingCompany"
    /// <summary>
    /// A trial that takes place at multiple centers.
    /// <see href="https://schema.org/MultiCenterTrial"></see></summary>
    let MultiCenterTrial = _prefix "MultiCenterTrial"

    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/algorithmicMedia"&gt;algorithmic media&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/MultiFrameComputationalCaptureDigitalSource"></see></summary>
    let MultiFrameComputationalCaptureDigitalSource =
        _prefix "MultiFrameComputationalCaptureDigitalSource"

    /// <summary>
    /// Play mode: MultiPlayer. Requiring or allowing multiple human players to play simultaneously.
    /// <see href="https://schema.org/MultiPlayer"></see></summary>
    let MultiPlayer = _prefix "MultiPlayer"
    /// <summary>
    /// Multicellular parasite that causes an infection.
    /// <see href="https://schema.org/MulticellularParasite"></see></summary>
    let MulticellularParasite = _prefix "MulticellularParasite"
    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// <see href="https://schema.org/Muscle"></see></summary>
    let Muscle = _prefix "Muscle"
    /// <summary>
    /// A specific branch of medical science that pertains to diagnosis and treatment of disorders of muscles, ligaments and skeletal system.
    /// <see href="https://schema.org/Musculoskeletal"></see></summary>
    let Musculoskeletal = _prefix "Musculoskeletal"
    /// <summary>
    /// Musculoskeletal system clinical examination.
    /// <see href="https://schema.org/MusculoskeletalExam"></see></summary>
    let MusculoskeletalExam = _prefix "MusculoskeletalExam"
    /// <summary>
    /// A museum.
    /// <see href="https://schema.org/Museum"></see></summary>
    let Museum = _prefix "Museum"
    /// <summary>
    /// A collection of music tracks.
    /// <see href="https://schema.org/MusicAlbum"></see></summary>
    let MusicAlbum = _prefix "MusicAlbum"
    /// <summary>
    /// A collection of music tracks in playlist form.
    /// <see href="https://schema.org/MusicPlaylist"></see></summary>
    let MusicPlaylist = _prefix "MusicPlaylist"
    /// <summary>
    /// A musical composition.
    /// <see href="https://schema.org/MusicComposition"></see></summary>
    let MusicComposition = _prefix "MusicComposition"
    /// <summary>
    /// Event type: Music event.
    /// <see href="https://schema.org/MusicEvent"></see></summary>
    let MusicEvent = _prefix "MusicEvent"
    /// <summary>
    /// A musical group, such as a band, an orchestra, or a choir. Can also be a solo musician.
    /// <see href="https://schema.org/MusicGroup"></see></summary>
    let MusicGroup = _prefix "MusicGroup"
    /// <summary>
    /// A music recording (track), usually a single song.
    /// <see href="https://schema.org/MusicRecording"></see></summary>
    let MusicRecording = _prefix "MusicRecording"
    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// <see href="https://schema.org/MusicRelease"></see></summary>
    let MusicRelease = _prefix "MusicRelease"
    /// <summary>
    /// A music store.
    /// <see href="https://schema.org/MusicStore"></see></summary>
    let MusicStore = _prefix "MusicStore"
    /// <summary>
    /// A music venue.
    /// <see href="https://schema.org/MusicVenue"></see></summary>
    let MusicVenue = _prefix "MusicVenue"
    /// <summary>
    /// A music video file.
    /// <see href="https://schema.org/MusicVideoObject"></see></summary>
    let MusicVideoObject = _prefix "MusicVideoObject"
    /// <summary>
    /// Organization: Non-governmental Organization.
    /// <see href="https://schema.org/NGO"></see></summary>
    let NGO = _prefix "NGO"
    /// <summary>
    /// NLNonprofitType: Non-profit organization type originating from the Netherlands.
    /// <see href="https://schema.org/NLNonprofitType"></see></summary>
    let NLNonprofitType = _prefix "NLNonprofitType"
    /// <summary>
    /// A nail salon.
    /// <see href="https://schema.org/NailSalon"></see></summary>
    let NailSalon = _prefix "NailSalon"
    /// <summary>
    /// Item is a narcotic as defined by the [1961 UN convention](https://www.incb.org/incb/en/narcotic-drugs/Yellowlist/yellow-list.html), for example marijuana or heroin.
    /// <see href="https://schema.org/NarcoticConsideration"></see></summary>
    let NarcoticConsideration = _prefix "NarcoticConsideration"
    /// <summary>
    /// Neck assessment with clinical examination.
    /// <see href="https://schema.org/Neck"></see></summary>
    let Neck = _prefix "Neck"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/negativeFilm"&gt;negative film&lt;/a&gt;&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/NegativeFilmDigitalSource"></see></summary>
    let NegativeFilmDigitalSource = _prefix "NegativeFilmDigitalSource"
    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// <see href="https://schema.org/Nerve"></see></summary>
    let Nerve = _prefix "Nerve"
    /// <summary>
    /// Neurological system clinical examination.
    /// <see href="https://schema.org/Neuro"></see></summary>
    let Neuro = _prefix "Neuro"
    /// <summary>
    /// A specific branch of medical science that studies the nerves and nervous system and its respective disease states.
    /// <see href="https://schema.org/Neurologic"></see></summary>
    let Neurologic = _prefix "Neurologic"
    /// <summary>
    /// Indicates that the item is new.
    /// <see href="https://schema.org/NewCondition"></see></summary>
    let NewCondition = _prefix "NewCondition"
    /// <summary>
    /// A News/Media organization such as a newspaper or TV station.
    /// <see href="https://schema.org/NewsMediaOrganization"></see></summary>
    let NewsMediaOrganization = _prefix "NewsMediaOrganization"
    /// <summary>
    /// A publication containing information about varied topics that are pertinent to general information, a geographic area, or a specific subject matter (i.e. business, culture, education). Often published daily.
    /// <see href="https://schema.org/Newspaper"></see></summary>
    let Newspaper = _prefix "Newspaper"
    /// <summary>
    /// A nightclub or discotheque.
    /// <see href="https://schema.org/NightClub"></see></summary>
    let NightClub = _prefix "NightClub"
    /// <summary>
    /// A type of medical procedure that involves noninvasive techniques.
    /// <see href="https://schema.org/NoninvasiveProcedure"></see></summary>
    let NoninvasiveProcedure = _prefix "NoninvasiveProcedure"
    /// <summary>
    /// Nonprofit501a: Non-profit type referring to Farmers’ Cooperative Associations.
    /// <see href="https://schema.org/Nonprofit501a"></see></summary>
    let Nonprofit501a = _prefix "Nonprofit501a"
    /// <summary>
    /// USNonprofitType: Non-profit organization type originating from the United States.
    /// <see href="https://schema.org/USNonprofitType"></see></summary>
    let USNonprofitType = _prefix "USNonprofitType"
    /// <summary>
    /// Nonprofit501c1: Non-profit type referring to Corporations Organized Under Act of Congress, including Federal Credit Unions and National Farm Loan Associations.
    /// <see href="https://schema.org/Nonprofit501c1"></see></summary>
    let Nonprofit501c1 = _prefix "Nonprofit501c1"
    /// <summary>
    /// Nonprofit501c10: Non-profit type referring to Domestic Fraternal Societies and Associations.
    /// <see href="https://schema.org/Nonprofit501c10"></see></summary>
    let Nonprofit501c10 = _prefix "Nonprofit501c10"
    /// <summary>
    /// Nonprofit501c11: Non-profit type referring to Teachers' Retirement Fund Associations.
    /// <see href="https://schema.org/Nonprofit501c11"></see></summary>
    let Nonprofit501c11 = _prefix "Nonprofit501c11"
    /// <summary>
    /// Nonprofit501c12: Non-profit type referring to Benevolent Life Insurance Associations, Mutual Ditch or Irrigation Companies, Mutual or Cooperative Telephone Companies.
    /// <see href="https://schema.org/Nonprofit501c12"></see></summary>
    let Nonprofit501c12 = _prefix "Nonprofit501c12"
    /// <summary>
    /// Nonprofit501c13: Non-profit type referring to Cemetery Companies.
    /// <see href="https://schema.org/Nonprofit501c13"></see></summary>
    let Nonprofit501c13 = _prefix "Nonprofit501c13"
    /// <summary>
    /// Nonprofit501c14: Non-profit type referring to State-Chartered Credit Unions, Mutual Reserve Funds.
    /// <see href="https://schema.org/Nonprofit501c14"></see></summary>
    let Nonprofit501c14 = _prefix "Nonprofit501c14"
    /// <summary>
    /// Nonprofit501c15: Non-profit type referring to Mutual Insurance Companies or Associations.
    /// <see href="https://schema.org/Nonprofit501c15"></see></summary>
    let Nonprofit501c15 = _prefix "Nonprofit501c15"
    /// <summary>
    /// Nonprofit501c16: Non-profit type referring to Cooperative Organizations to Finance Crop Operations.
    /// <see href="https://schema.org/Nonprofit501c16"></see></summary>
    let Nonprofit501c16 = _prefix "Nonprofit501c16"
    /// <summary>
    /// Nonprofit501c17: Non-profit type referring to Supplemental Unemployment Benefit Trusts.
    /// <see href="https://schema.org/Nonprofit501c17"></see></summary>
    let Nonprofit501c17 = _prefix "Nonprofit501c17"
    /// <summary>
    /// Nonprofit501c18: Non-profit type referring to Employee Funded Pension Trust (created before 25 June 1959).
    /// <see href="https://schema.org/Nonprofit501c18"></see></summary>
    let Nonprofit501c18 = _prefix "Nonprofit501c18"
    /// <summary>
    /// Nonprofit501c19: Non-profit type referring to Post or Organization of Past or Present Members of the Armed Forces.
    /// <see href="https://schema.org/Nonprofit501c19"></see></summary>
    let Nonprofit501c19 = _prefix "Nonprofit501c19"
    /// <summary>
    /// Nonprofit501c2: Non-profit type referring to Title-holding Corporations for Exempt Organizations.
    /// <see href="https://schema.org/Nonprofit501c2"></see></summary>
    let Nonprofit501c2 = _prefix "Nonprofit501c2"
    /// <summary>
    /// Nonprofit501c20: Non-profit type referring to Group Legal Services Plan Organizations.
    /// <see href="https://schema.org/Nonprofit501c20"></see></summary>
    let Nonprofit501c20 = _prefix "Nonprofit501c20"
    /// <summary>
    /// Nonprofit501c21: Non-profit type referring to Black Lung Benefit Trusts.
    /// <see href="https://schema.org/Nonprofit501c21"></see></summary>
    let Nonprofit501c21 = _prefix "Nonprofit501c21"
    /// <summary>
    /// Nonprofit501c22: Non-profit type referring to Withdrawal Liability Payment Funds.
    /// <see href="https://schema.org/Nonprofit501c22"></see></summary>
    let Nonprofit501c22 = _prefix "Nonprofit501c22"
    /// <summary>
    /// Nonprofit501c23: Non-profit type referring to Veterans Organizations.
    /// <see href="https://schema.org/Nonprofit501c23"></see></summary>
    let Nonprofit501c23 = _prefix "Nonprofit501c23"
    /// <summary>
    /// Nonprofit501c24: Non-profit type referring to Section 4049 ERISA Trusts.
    /// <see href="https://schema.org/Nonprofit501c24"></see></summary>
    let Nonprofit501c24 = _prefix "Nonprofit501c24"
    /// <summary>
    /// Nonprofit501c25: Non-profit type referring to Real Property Title-Holding Corporations or Trusts with Multiple Parents.
    /// <see href="https://schema.org/Nonprofit501c25"></see></summary>
    let Nonprofit501c25 = _prefix "Nonprofit501c25"
    /// <summary>
    /// Nonprofit501c26: Non-profit type referring to State-Sponsored Organizations Providing Health Coverage for High-Risk Individuals.
    /// <see href="https://schema.org/Nonprofit501c26"></see></summary>
    let Nonprofit501c26 = _prefix "Nonprofit501c26"
    /// <summary>
    /// Nonprofit501c27: Non-profit type referring to State-Sponsored Workers' Compensation Reinsurance Organizations.
    /// <see href="https://schema.org/Nonprofit501c27"></see></summary>
    let Nonprofit501c27 = _prefix "Nonprofit501c27"
    /// <summary>
    /// Nonprofit501c28: Non-profit type referring to National Railroad Retirement Investment Trusts.
    /// <see href="https://schema.org/Nonprofit501c28"></see></summary>
    let Nonprofit501c28 = _prefix "Nonprofit501c28"
    /// <summary>
    /// Nonprofit501c3: Non-profit type referring to Religious, Educational, Charitable, Scientific, Literary, Testing for Public Safety, Fostering National or International Amateur Sports Competition, or Prevention of Cruelty to Children or Animals Organizations.
    /// <see href="https://schema.org/Nonprofit501c3"></see></summary>
    let Nonprofit501c3 = _prefix "Nonprofit501c3"
    /// <summary>
    /// Nonprofit501c4: Non-profit type referring to Civic Leagues, Social Welfare Organizations, and Local Associations of Employees.
    /// <see href="https://schema.org/Nonprofit501c4"></see></summary>
    let Nonprofit501c4 = _prefix "Nonprofit501c4"
    /// <summary>
    /// Nonprofit501c5: Non-profit type referring to Labor, Agricultural and Horticultural Organizations.
    /// <see href="https://schema.org/Nonprofit501c5"></see></summary>
    let Nonprofit501c5 = _prefix "Nonprofit501c5"
    /// <summary>
    /// Nonprofit501c6: Non-profit type referring to Business Leagues, Chambers of Commerce, Real Estate Boards.
    /// <see href="https://schema.org/Nonprofit501c6"></see></summary>
    let Nonprofit501c6 = _prefix "Nonprofit501c6"
    /// <summary>
    /// Nonprofit501c7: Non-profit type referring to Social and Recreational Clubs.
    /// <see href="https://schema.org/Nonprofit501c7"></see></summary>
    let Nonprofit501c7 = _prefix "Nonprofit501c7"
    /// <summary>
    /// Nonprofit501c8: Non-profit type referring to Fraternal Beneficiary Societies and Associations.
    /// <see href="https://schema.org/Nonprofit501c8"></see></summary>
    let Nonprofit501c8 = _prefix "Nonprofit501c8"
    /// <summary>
    /// Nonprofit501c9: Non-profit type referring to Voluntary Employee Beneficiary Associations.
    /// <see href="https://schema.org/Nonprofit501c9"></see></summary>
    let Nonprofit501c9 = _prefix "Nonprofit501c9"
    /// <summary>
    /// Nonprofit501d: Non-profit type referring to Religious and Apostolic Associations.
    /// <see href="https://schema.org/Nonprofit501d"></see></summary>
    let Nonprofit501d = _prefix "Nonprofit501d"
    /// <summary>
    /// Nonprofit501e: Non-profit type referring to Cooperative Hospital Service Organizations.
    /// <see href="https://schema.org/Nonprofit501e"></see></summary>
    let Nonprofit501e = _prefix "Nonprofit501e"
    /// <summary>
    /// Nonprofit501f: Non-profit type referring to Cooperative Service Organizations.
    /// <see href="https://schema.org/Nonprofit501f"></see></summary>
    let Nonprofit501f = _prefix "Nonprofit501f"
    /// <summary>
    /// Nonprofit501k: Non-profit type referring to Child Care Organizations.
    /// <see href="https://schema.org/Nonprofit501k"></see></summary>
    let Nonprofit501k = _prefix "Nonprofit501k"
    /// <summary>
    /// Nonprofit501n: Non-profit type referring to Charitable Risk Pools.
    /// <see href="https://schema.org/Nonprofit501n"></see></summary>
    let Nonprofit501n = _prefix "Nonprofit501n"
    /// <summary>
    /// Nonprofit501q: Non-profit type referring to Credit Counseling Organizations.
    /// <see href="https://schema.org/Nonprofit501q"></see></summary>
    let Nonprofit501q = _prefix "Nonprofit501q"
    /// <summary>
    /// Nonprofit527: Non-profit type referring to political organizations.
    /// <see href="https://schema.org/Nonprofit527"></see></summary>
    let Nonprofit527 = _prefix "Nonprofit527"
    /// <summary>
    /// NonprofitANBI: Non-profit type referring to a Public Benefit Organization (NL).
    /// <see href="https://schema.org/NonprofitANBI"></see></summary>
    let NonprofitANBI = _prefix "NonprofitANBI"
    /// <summary>
    /// NonprofitSBBI: Non-profit type referring to a Social Interest Promoting Institution (NL).
    /// <see href="https://schema.org/NonprofitSBBI"></see></summary>
    let NonprofitSBBI = _prefix "NonprofitSBBI"
    /// <summary>
    /// Nose function assessment with clinical examination.
    /// <see href="https://schema.org/Nose"></see></summary>
    let Nose = _prefix "Nose"
    /// <summary>
    /// Indicates that a legislation is currently not in force.
    /// <see href="https://schema.org/NotInForce"></see></summary>
    let NotInForce = _prefix "NotInForce"
    /// <summary>
    /// Not yet recruiting.
    /// <see href="https://schema.org/NotYetRecruiting"></see></summary>
    let NotYetRecruiting = _prefix "NotYetRecruiting"
    /// <summary>
    /// A notary.
    /// <see href="https://schema.org/Notary"></see></summary>
    let Notary = _prefix "Notary"
    /// <summary>
    /// A file containing a note, primarily for the author.
    /// <see href="https://schema.org/NoteDigitalDocument"></see></summary>
    let NoteDigitalDocument = _prefix "NoteDigitalDocument"
    /// <summary>
    /// A health profession of a person formally educated and trained in the care of the sick or infirm person.
    /// <see href="https://schema.org/Nursing"></see></summary>
    let Nursing = _prefix "Nursing"
    /// <summary>
    /// Nutritional information about the recipe.
    /// <see href="https://schema.org/NutritionInformation"></see></summary>
    let NutritionInformation = _prefix "NutritionInformation"
    /// <summary>
    /// The character of a medical substance, typically a medicine, of being available over the counter or not.
    /// <see href="https://schema.org/OTC"></see></summary>
    let OTC = _prefix "OTC"
    /// <summary>
    /// Instances of the class [[Observation]] are used to specify observations about an entity at a particular time. The principal properties of an [[Observation]] are [[observationAbout]], [[measuredProperty]], [[statType]], [[value] and [[observationDate]]  and [[measuredProperty]]. Some but not all Observations represent a [[QuantitativeValue]]. Quantitative observations can be about a [[StatisticalVariable]], which is an abstract specification about which we can make observations that are grounded at a particular location and time.
    ///
    /// Observations can also encode a subset of simple RDF-like statements (its observationAbout, a StatisticalVariable, defining the measuredPoperty; its observationAbout property indicating the entity the statement is about, and [[value]] )
    ///
    /// In the context of a quantitative knowledge graph, typical properties could include [[measuredProperty]], [[observationAbout]], [[observationDate]], [[value]], [[unitCode]], [[unitText]], [[measurementMethod]].
    ///
    /// <see href="https://schema.org/Observation"></see></summary>
    let Observation = _prefix "Observation"
    /// <summary>
    ///  A point value or interval for product characteristics and other purposes.
    /// <see href="https://schema.org/QuantitativeValue"></see></summary>
    let QuantitativeValue = _prefix "QuantitativeValue"
    /// <summary>
    /// An observational study design.
    /// <see href="https://schema.org/Observational"></see></summary>
    let Observational = _prefix "Observational"
    /// <summary>
    /// A specific branch of medical science that specializes in the care of women during the prenatal and postnatal care and with the delivery of the child.
    /// <see href="https://schema.org/Obstetric"></see></summary>
    let Obstetric = _prefix "Obstetric"
    /// <summary>
    /// A profession, may involve prolonged training and/or a formal qualification.
    /// <see href="https://schema.org/Occupation"></see></summary>
    let Occupation = _prefix "Occupation"
    /// <summary>
    /// Any physical activity engaged in for job-related purposes. Examples may include waiting tables, maid service, carrying a mailbag, picking fruits or vegetables, construction work, etc.
    /// <see href="https://schema.org/OccupationalActivity"></see></summary>
    let OccupationalActivity = _prefix "OccupationalActivity"

    /// <summary>
    /// Indicates employment-related experience requirements, e.g. [[monthsOfExperience]].
    /// <see href="https://schema.org/OccupationalExperienceRequirements"></see></summary>
    let OccupationalExperienceRequirements =
        _prefix "OccupationalExperienceRequirements"

    /// <summary>
    /// A treatment of people with physical, emotional, or social problems, using purposeful activity to help them overcome or learn to deal with their problems.
    /// <see href="https://schema.org/OccupationalTherapy"></see></summary>
    let OccupationalTherapy = _prefix "OccupationalTherapy"
    /// <summary>
    /// An ocean (for example, the Pacific).
    /// <see href="https://schema.org/OceanBodyOfWater"></see></summary>
    let OceanBodyOfWater = _prefix "OceanBodyOfWater"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/GoodRelationsTerms"></see>
    /// </summary>
    let ``docs/collab/GoodRelationsTerms`` = _prefix "docs/collab/GoodRelationsTerms"
    /// <summary>
    /// An OfferCatalog is an ItemList that contains related Offers and/or further OfferCatalogs that are offeredBy the same provider.
    /// <see href="https://schema.org/OfferCatalog"></see></summary>
    let OfferCatalog = _prefix "OfferCatalog"
    /// <summary>
    /// An [[OfferForLease]] in Schema.org represents an [[Offer]] to lease out something, i.e. an [[Offer]] whose
    ///   [[businessFunction]] is [lease out](http://purl.org/goodrelations/v1#LeaseOut.). See [Good Relations](https://en.wikipedia.org/wiki/GoodRelations) for
    ///   background on the underlying concepts.
    ///
    /// <see href="https://schema.org/OfferForLease"></see></summary>
    let OfferForLease = _prefix "OfferForLease"
    /// <summary>
    /// An [[OfferForPurchase]] in Schema.org represents an [[Offer]] to sell something, i.e. an [[Offer]] whose
    ///   [[businessFunction]] is [sell](http://purl.org/goodrelations/v1#Sell.). See [Good Relations](https://en.wikipedia.org/wiki/GoodRelations) for
    ///   background on the underlying concepts.
    ///
    /// <see href="https://schema.org/OfferForPurchase"></see></summary>
    let OfferForPurchase = _prefix "OfferForPurchase"
    /// <summary>
    /// OfferShippingDetails represents information about shipping destinations.
    ///
    /// Multiple of these entities can be used to represent different shipping rates for different destinations:
    ///
    /// One entity for Alaska/Hawaii. A different one for continental US. A different one for all France.
    ///
    /// Multiple of these entities can be used to represent different shipping costs and delivery times.
    ///
    /// Two entities that are identical but differ in rate and time:
    ///
    /// E.g. Cheaper and slower: $5 in 5-7 days
    /// or Fast and expensive: $15 in 1-2 days.
    /// <see href="https://schema.org/OfferShippingDetails"></see></summary>
    let OfferShippingDetails = _prefix "OfferShippingDetails"
    /// <summary>
    /// An office equipment store.
    /// <see href="https://schema.org/OfficeEquipmentStore"></see></summary>
    let OfficeEquipmentStore = _prefix "OfficeEquipmentStore"
    /// <summary>
    /// All the documents published by an official publisher should have at least the legal value level "OfficialLegalValue". This indicates that the document was published by an organisation with the public task of making it available (e.g. a consolidated version of a EU directive published by the EU Office of Publications).
    /// <see href="https://schema.org/OfficialLegalValue"></see></summary>
    let OfficialLegalValue = _prefix "OfficialLegalValue"
    /// <summary>
    /// OfflineEventAttendanceMode - an event that is primarily conducted offline.
    /// <see href="https://schema.org/OfflineEventAttendanceMode"></see></summary>
    let OfflineEventAttendanceMode = _prefix "OfflineEventAttendanceMode"
    /// <summary>
    /// Game server status: OfflinePermanently. Server is offline and not available.
    /// <see href="https://schema.org/OfflinePermanently"></see></summary>
    let OfflinePermanently = _prefix "OfflinePermanently"
    /// <summary>
    /// Game server status: OfflineTemporarily. Server is offline now but it can be online soon.
    /// <see href="https://schema.org/OfflineTemporarily"></see></summary>
    let OfflineTemporarily = _prefix "OfflineTemporarily"
    /// <summary>
    /// A publication event, e.g. catch-up TV or radio podcast, during which a program is available on-demand.
    /// <see href="https://schema.org/OnDemandEvent"></see></summary>
    let OnDemandEvent = _prefix "OnDemandEvent"
    /// <summary>
    /// A DeliveryMethod in which an item is collected on site, e.g. in a store or at a box office.
    /// <see href="https://schema.org/OnSitePickup"></see></summary>
    let OnSitePickup = _prefix "OnSitePickup"
    /// <summary>
    /// A specific branch of medical science that deals with benign and malignant tumors, including the study of their development, diagnosis, treatment and prevention.
    /// <see href="https://schema.org/Oncologic"></see></summary>
    let Oncologic = _prefix "Oncologic"
    /// <summary>
    /// OneTimePayments: this is a benefit for one-time payments for individuals.
    /// <see href="https://schema.org/OneTimePayments"></see></summary>
    let OneTimePayments = _prefix "OneTimePayments"
    /// <summary>
    /// Game server status: Online. Server is available.
    /// <see href="https://schema.org/Online"></see></summary>
    let Online = _prefix "Online"
    /// <summary>
    /// A particular online business, either standalone or the online part of a broader organization. Examples include an eCommerce site, an online travel booking site, an online learning site, an online logistics and shipping provider, an online (virtual) doctor, etc.
    /// <see href="https://schema.org/OnlineBusiness"></see></summary>
    let OnlineBusiness = _prefix "OnlineBusiness"
    /// <summary>
    /// OnlineEventAttendanceMode - an event that is primarily conducted online.
    /// <see href="https://schema.org/OnlineEventAttendanceMode"></see></summary>
    let OnlineEventAttendanceMode = _prefix "OnlineEventAttendanceMode"
    /// <summary>
    /// Game server status: OnlineFull. Server is online but unavailable. The maximum number of players has reached.
    /// <see href="https://schema.org/OnlineFull"></see></summary>
    let OnlineFull = _prefix "OnlineFull"
    /// <summary>
    /// An eCommerce marketplace.
    /// <see href="https://schema.org/OnlineMarketplace"></see></summary>
    let OnlineMarketplace = _prefix "OnlineMarketplace"
    /// <summary>
    /// An eCommerce site.
    /// <see href="https://schema.org/OnlineStore"></see></summary>
    let OnlineStore = _prefix "OnlineStore"
    /// <summary>
    /// Indicates that the item is available only online.
    /// <see href="https://schema.org/OnlineOnly"></see></summary>
    let OnlineOnly = _prefix "OnlineOnly"
    /// <summary>
    /// A trial design in which the researcher knows the full details of the treatment, and so does the patient.
    /// <see href="https://schema.org/OpenTrial"></see></summary>
    let OpenTrial = _prefix "OpenTrial"
    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.\n\n
    /// The place is __open__ if the [[opens]] property is specified, and __closed__ otherwise.\n\nIf the value for the [[closes]] property is less than the value for the [[opens]] property then the hour range is assumed to span over the next day.
    ///
    /// <see href="https://schema.org/OpeningHoursSpecification"></see></summary>
    let OpeningHoursSpecification = _prefix "OpeningHoursSpecification"
    /// <summary>
    /// System software that manages computer hardware and software resources, and provides common services for computer programs.
    /// <see href="https://schema.org/OperatingSystem"></see></summary>
    let OperatingSystem = _prefix "OperatingSystem"
    /// <summary>
    /// An [[OpinionNewsArticle]] is a [[NewsArticle]] that primarily expresses opinions rather than journalistic reporting of news and events. For example, a [[NewsArticle]] consisting of a column or [[Blog]]/[[BlogPosting]] entry in the Opinions section of a news publication.
    /// <see href="https://schema.org/OpinionNewsArticle"></see></summary>
    let OpinionNewsArticle = _prefix "OpinionNewsArticle"
    /// <summary>
    /// A store that sells reading glasses and similar devices for improving vision.
    /// <see href="https://schema.org/Optician"></see></summary>
    let Optician = _prefix "Optician"
    /// <summary>
    /// The science or practice of testing visual acuity and prescribing corrective lenses.
    /// <see href="https://schema.org/Optometric"></see></summary>
    let Optometric = _prefix "Optometric"
    /// <summary>
    /// An order is a confirmation of a transaction (a receipt), which can contain multiple line items, each represented by an Offer that has been accepted by the customer.
    /// <see href="https://schema.org/Order"></see></summary>
    let Order = _prefix "Order"
    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// <see href="https://schema.org/OrderAction"></see></summary>
    let OrderAction = _prefix "OrderAction"
    /// <summary>
    /// OrderStatus representing cancellation of an order.
    /// <see href="https://schema.org/OrderCancelled"></see></summary>
    let OrderCancelled = _prefix "OrderCancelled"
    /// <summary>
    /// Enumerated status values for Order.
    /// <see href="https://schema.org/OrderStatus"></see></summary>
    let OrderStatus = _prefix "OrderStatus"
    /// <summary>
    /// OrderStatus representing successful delivery of an order.
    /// <see href="https://schema.org/OrderDelivered"></see></summary>
    let OrderDelivered = _prefix "OrderDelivered"
    /// <summary>
    /// OrderStatus representing that an order is in transit.
    /// <see href="https://schema.org/OrderInTransit"></see></summary>
    let OrderInTransit = _prefix "OrderInTransit"
    /// <summary>
    /// An order item is a line of an order. It includes the quantity and shipping details of a bought offer.
    /// <see href="https://schema.org/OrderItem"></see></summary>
    let OrderItem = _prefix "OrderItem"
    /// <summary>
    /// OrderStatus representing that payment is due on an order.
    /// <see href="https://schema.org/OrderPaymentDue"></see></summary>
    let OrderPaymentDue = _prefix "OrderPaymentDue"
    /// <summary>
    /// OrderStatus representing availability of an order for pickup.
    /// <see href="https://schema.org/OrderPickupAvailable"></see></summary>
    let OrderPickupAvailable = _prefix "OrderPickupAvailable"
    /// <summary>
    /// OrderStatus representing that there is a problem with the order.
    /// <see href="https://schema.org/OrderProblem"></see></summary>
    let OrderProblem = _prefix "OrderProblem"
    /// <summary>
    /// OrderStatus representing that an order is being processed.
    /// <see href="https://schema.org/OrderProcessing"></see></summary>
    let OrderProcessing = _prefix "OrderProcessing"
    /// <summary>
    /// OrderStatus representing that an order has been returned.
    /// <see href="https://schema.org/OrderReturned"></see></summary>
    let OrderReturned = _prefix "OrderReturned"
    /// <summary>
    /// Content coded 'as original media content' in a [[MediaReview]], considered in the context of how it was published or shared.
    ///
    /// For a [[VideoObject]] to be 'original': No evidence the footage has been misleadingly altered or manipulated, though it may contain false or misleading claims.
    ///
    /// For an [[ImageObject]] to be 'original': No evidence the image has been misleadingly altered or manipulated, though it may still contain false or misleading claims.
    ///
    /// For an [[ImageObject]] with embedded text to be 'original': No evidence the image has been misleadingly altered or manipulated, though it may still contain false or misleading claims.
    ///
    /// For an [[AudioObject]] to be 'original': No evidence the audio has been misleadingly altered or manipulated, though it may contain false or misleading claims.
    ///
    /// <see href="https://schema.org/OriginalMediaContent"></see></summary>
    let OriginalMediaContent = _prefix "OriginalMediaContent"
    /// <summary>
    /// Specifies that the customer must pay the original shipping costs when returning a product.
    /// <see href="https://schema.org/OriginalShippingFees"></see></summary>
    let OriginalShippingFees = _prefix "OriginalShippingFees"
    /// <summary>
    /// A system of medicine focused on promoting the body's innate ability to heal itself.
    /// <see href="https://schema.org/Osteopathic"></see></summary>
    let Osteopathic = _prefix "Osteopathic"
    /// <summary>
    /// A specific branch of medical science that is concerned with the ear, nose and throat and their respective disease states.
    /// <see href="https://schema.org/Otolaryngologic"></see></summary>
    let Otolaryngologic = _prefix "Otolaryngologic"
    /// <summary>
    /// Indicates that the item is out of stock.
    /// <see href="https://schema.org/OutOfStock"></see></summary>
    let OutOfStock = _prefix "OutOfStock"
    /// <summary>
    /// An outlet store.
    /// <see href="https://schema.org/OutletStore"></see></summary>
    let OutletStore = _prefix "OutletStore"
    /// <summary>
    /// Overview of the content. Contains a summarized view of the topic with the most relevant information for an introduction.
    /// <see href="https://schema.org/OverviewHealthAspect"></see></summary>
    let OverviewHealthAspect = _prefix "OverviewHealthAspect"
    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// <see href="https://schema.org/OwnershipInfo"></see></summary>
    let OwnershipInfo = _prefix "OwnershipInfo"
    /// <summary>
    /// Positron emission tomography imaging.
    /// <see href="https://schema.org/PET"></see></summary>
    let PET = _prefix "PET"
    /// <summary>
    /// PaidLeave: this is a benefit for paid leave.
    /// <see href="https://schema.org/PaidLeave"></see></summary>
    let PaidLeave = _prefix "PaidLeave"
    /// <summary>
    /// The act of producing a painting, typically with paint and canvas as instruments.
    /// <see href="https://schema.org/PaintAction"></see></summary>
    let PaintAction = _prefix "PaintAction"
    /// <summary>
    /// A painting.
    /// <see href="https://schema.org/Painting"></see></summary>
    let Painting = _prefix "Painting"
    /// <summary>
    /// A medical procedure intended primarily for palliative purposes, aimed at relieving the symptoms of an underlying health condition.
    /// <see href="https://schema.org/PalliativeProcedure"></see></summary>
    let PalliativeProcedure = _prefix "PalliativeProcedure"
    /// <summary>
    /// A small, unbound or stapled booklet consisting of few pages with a flexible paper cover, designed for the economical distribution of focused information on a single subject.
    /// <see href="https://schema.org/Pamphlet"></see></summary>
    let Pamphlet = _prefix "Pamphlet"
    /// <summary>
    /// A flexible, lightweight book bound with a thick paper or cardstock cover and glued spine, prioritizing portability and affordability over long-term durability.
    /// <see href="https://schema.org/Paperback"></see></summary>
    let Paperback = _prefix "Paperback"
    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// <see href="https://schema.org/ParcelDelivery"></see></summary>
    let ParcelDelivery = _prefix "ParcelDelivery"
    /// <summary>
    /// A private parcel service as the delivery mode available for a certain offer.\n\nCommonly used values:\n\n* http://purl.org/goodrelations/v1#DHL\n* http://purl.org/goodrelations/v1#FederalExpress\n* http://purl.org/goodrelations/v1#UPS
    ///
    /// <see href="https://schema.org/ParcelService"></see></summary>
    let ParcelService = _prefix "ParcelService"
    /// <summary>
    /// A set of characteristics describing parents, who can be interested in viewing some content.
    /// <see href="https://schema.org/ParentAudience"></see></summary>
    let ParentAudience = _prefix "ParentAudience"
    /// <summary>
    /// ParentalSupport: this is a benefit for parental support.
    /// <see href="https://schema.org/ParentalSupport"></see></summary>
    let ParentalSupport = _prefix "ParentalSupport"
    /// <summary>
    /// A park.
    /// <see href="https://schema.org/Park"></see></summary>
    let Park = _prefix "Park"
    /// <summary>
    /// A parking lot or other parking facility.
    /// <see href="https://schema.org/ParkingFacility"></see></summary>
    let ParkingFacility = _prefix "ParkingFacility"
    /// <summary>
    /// A parking map.
    /// <see href="https://schema.org/ParkingMap"></see></summary>
    let ParkingMap = _prefix "ParkingMap"
    /// <summary>
    /// Indicates that parts of the legislation are in force, and parts are not.
    /// <see href="https://schema.org/PartiallyInForce"></see></summary>
    let PartiallyInForce = _prefix "PartiallyInForce"
    /// <summary>
    /// A specific branch of medical science that is concerned with the study of the cause, origin and nature of a disease state, including its consequences as a result of manifestation of the disease. In clinical care, the term is used to designate a branch of medicine using laboratory tests to diagnose and determine the prognostic significance of illness.
    /// <see href="https://schema.org/Pathology"></see></summary>
    let Pathology = _prefix "Pathology"
    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// <see href="https://schema.org/PathologyTest"></see></summary>
    let PathologyTest = _prefix "PathologyTest"
    /// <summary>
    /// A patient is any person recipient of health care services.
    /// <see href="https://schema.org/Patient"></see></summary>
    let Patient = _prefix "Patient"
    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// <see href="https://schema.org/Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// Content about the real life experience of patients or people that have lived a similar experience about the topic. May be forums, topics, Q-and-A and related material.
    /// <see href="https://schema.org/PatientExperienceHealthAspect"></see></summary>
    let PatientExperienceHealthAspect = _prefix "PatientExperienceHealthAspect"
    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// <see href="https://schema.org/PawnShop"></see></summary>
    let PawnShop = _prefix "PawnShop"
    /// <summary>
    /// An agent pays a price to a participant.
    /// <see href="https://schema.org/PayAction"></see></summary>
    let PayAction = _prefix "PayAction"
    /// <summary>
    /// An automatic payment system is in place and will be used.
    /// <see href="https://schema.org/PaymentAutomaticallyApplied"></see></summary>
    let PaymentAutomaticallyApplied = _prefix "PaymentAutomaticallyApplied"
    /// <summary>
    /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    /// <see href="https://schema.org/PaymentStatusType"></see></summary>
    let PaymentStatusType = _prefix "PaymentStatusType"
    /// <summary>
    /// A payment method is a standardized procedure for transferring the monetary amount for a purchase. Payment methods are characterized by the legal and technical structures used, and by the organization or group carrying out the transaction. The following legacy values should be accepted: \n\n* http://purl.org/goodrelations/v1#ByBankTransferInAdvance\n* http://purl.org/goodrelations/v1#ByInvoice\n* http://purl.org/goodrelations/v1#Cash\n* http://purl.org/goodrelations/v1#CheckInAdvance\n* http://purl.org/goodrelations/v1#COD\n* http://purl.org/goodrelations/v1#DirectDebit\n* http://purl.org/goodrelations/v1#GoogleCheckout\n* http://purl.org/goodrelations/v1#PayPal\n* http://purl.org/goodrelations/v1#PaySwarm\n\nStructured values, or [UNCE payment means](https://vocabulary.uncefact.org/PaymentMeans) are recommended or for newer annotations.
    /// <see href="https://schema.org/PaymentMethod"></see></summary>
    let PaymentMethod = _prefix "PaymentMethod"
    /// <summary>
    /// The costs of settling the payment using a particular payment method.
    /// <see href="https://schema.org/PaymentChargeSpecification"></see></summary>
    let PaymentChargeSpecification = _prefix "PaymentChargeSpecification"
    /// <summary>
    /// The payment has been received and processed.
    /// <see href="https://schema.org/PaymentComplete"></see></summary>
    let PaymentComplete = _prefix "PaymentComplete"
    /// <summary>
    /// The payee received the payment, but it was declined for some reason.
    /// <see href="https://schema.org/PaymentDeclined"></see></summary>
    let PaymentDeclined = _prefix "PaymentDeclined"
    /// <summary>
    /// The payment is due, but still within an acceptable time to be received.
    /// <see href="https://schema.org/PaymentDue"></see></summary>
    let PaymentDue = _prefix "PaymentDue"
    /// <summary>
    /// The payment is due and considered late.
    /// <see href="https://schema.org/PaymentPastDue"></see></summary>
    let PaymentPastDue = _prefix "PaymentPastDue"
    /// <summary>
    /// A Service to transfer funds from a person or organization to a beneficiary person or organization.
    /// <see href="https://schema.org/PaymentService"></see></summary>
    let PaymentService = _prefix "PaymentService"
    /// <summary>
    /// A specific branch of medical science that specializes in the care of infants, children and adolescents.
    /// <see href="https://schema.org/Pediatric"></see></summary>
    let Pediatric = _prefix "Pediatric"
    /// <summary>
    /// A type of medical procedure that involves percutaneous techniques, where access to organs or tissue is achieved via needle-puncture of the skin. For example, catheter-based procedures like stent delivery.
    /// <see href="https://schema.org/PercutaneousProcedure"></see></summary>
    let PercutaneousProcedure = _prefix "PercutaneousProcedure"
    /// <summary>
    /// The act of participating in performance arts.
    /// <see href="https://schema.org/PerformAction"></see></summary>
    let PerformAction = _prefix "PerformAction"
    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// <see href="https://schema.org/PerformanceRole"></see></summary>
    let PerformanceRole = _prefix "PerformanceRole"
    /// <summary>
    /// Live performance &lt;a class="localLink" href="http://schema.org/Event"&gt;Event of the performing arts (music, theatre, dance, acrobatics, spoken word), including performance art and performative sports (e.g. choreographed forms of martial arts, figure skating, competitive ballroom dancing).&lt;br/&gt;&lt;br/&gt;Note: Use &lt;a class="localLink" href="http://schema.org/additionalType"&gt;additionalType&lt;/a&gt; to differentiate between productions / shows (PerformanceWork, EventSeries), tours (EventSeries), and individual performances.
    /// <see href="https://schema.org/PerformingArtsEvent"></see></summary>
    let PerformingArtsEvent = _prefix "PerformingArtsEvent"
    /// <summary>
    /// A theater or other performing art center.
    /// <see href="https://schema.org/PerformingArtsTheater"></see></summary>
    let PerformingArtsTheater = _prefix "PerformingArtsTheater"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/bibex"></see>
    /// </summary>
    let ``docs/collab/bibex`` = _prefix "docs/collab/bibex"
    /// <summary>
    /// A pet store.
    /// <see href="https://schema.org/PetStore"></see></summary>
    let PetStore = _prefix "PetStore"
    /// <summary>
    /// A pharmacy or drugstore.
    /// <see href="https://schema.org/Pharmacy"></see></summary>
    let Pharmacy = _prefix "Pharmacy"
    /// <summary>
    /// The practice or art and science of preparing and dispensing drugs and medicines.
    /// <see href="https://schema.org/PharmacySpecialty"></see></summary>
    let PharmacySpecialty = _prefix "PharmacySpecialty"
    /// <summary>
    /// Payment by billing via the phone carrier.
    /// <see href="https://schema.org/PhoneCarrierPayment"></see></summary>
    let PhoneCarrierPayment = _prefix "PhoneCarrierPayment"
    /// <summary>
    /// A photograph.
    /// <see href="https://schema.org/Photograph"></see></summary>
    let Photograph = _prefix "Photograph"
    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// <see href="https://schema.org/PhotographAction"></see></summary>
    let PhotographAction = _prefix "PhotographAction"
    /// <summary>
    /// A process of progressive physical care and rehabilitation aimed at improving a health condition.
    /// <see href="https://schema.org/PhysicalTherapy"></see></summary>
    let PhysicalTherapy = _prefix "PhysicalTherapy"
    /// <summary>
    /// A doctor's office or clinic.
    /// <see href="https://schema.org/PhysiciansOffice"></see></summary>
    let PhysiciansOffice = _prefix "PhysiciansOffice"
    /// <summary>
    /// The practice of treatment of disease, injury, or deformity by physical methods such as massage, heat treatment, and exercise rather than by drugs or surgery.
    /// <see href="https://schema.org/Physiotherapy"></see></summary>
    let Physiotherapy = _prefix "Physiotherapy"
    /// <summary>
    /// A placebo-controlled trial design.
    /// <see href="https://schema.org/PlaceboControlledTrial"></see></summary>
    let PlaceboControlledTrial = _prefix "PlaceboControlledTrial"
    /// <summary>
    /// A specific branch of medical science that pertains to therapeutic or cosmetic repair or re-formation of missing, injured or malformed tissues or body parts by manual and instrumental means.
    /// <see href="https://schema.org/PlasticSurgery"></see></summary>
    let PlasticSurgery = _prefix "PlasticSurgery"
    /// <summary>
    /// A play is a form of literature, usually consisting of dialogue between characters, intended for theatrical performance rather than just reading. Note: A performance of a Play would be a [[TheaterEvent]] or [[BroadcastEvent]] - the *Play* being the [[workPerformed]].
    /// <see href="https://schema.org/Play"></see></summary>
    let Play = _prefix "Play"
    /// <summary>
    /// The act of playing a video game.
    /// <see href="https://schema.org/PlayGameAction"></see></summary>
    let PlayGameAction = _prefix "PlayGameAction"
    /// <summary>
    /// A playground.
    /// <see href="https://schema.org/Playground"></see></summary>
    let Playground = _prefix "Playground"
    /// <summary>
    /// A plumbing service.
    /// <see href="https://schema.org/Plumber"></see></summary>
    let Plumber = _prefix "Plumber"
    /// <summary>
    /// A single episode of a podcast series.
    /// <see href="https://schema.org/PodcastEpisode"></see></summary>
    let PodcastEpisode = _prefix "PodcastEpisode"
    /// <summary>
    /// A single season of a podcast. Many podcasts do not break down into separate seasons. In that case, PodcastSeries should be used.
    /// <see href="https://schema.org/PodcastSeason"></see></summary>
    let PodcastSeason = _prefix "PodcastSeason"
    /// <summary>
    /// A podcast is an episodic series of digital audio or video files which a user can download and listen to.
    /// <see href="https://schema.org/PodcastSeries"></see></summary>
    let PodcastSeries = _prefix "PodcastSeries"
    /// <summary>
    /// Podiatry is the care of the human foot, especially the diagnosis and treatment of foot disorders.
    /// <see href="https://schema.org/Podiatric"></see></summary>
    let Podiatric = _prefix "Podiatric"
    /// <summary>
    /// A police station.
    /// <see href="https://schema.org/PoliceStation"></see></summary>
    let PoliceStation = _prefix "PoliceStation"
    /// <summary>
    /// Organization: Political Party.
    /// <see href="https://schema.org/PoliticalParty"></see></summary>
    let PoliticalParty = _prefix "PoliticalParty"
    /// <summary>
    /// A pond.
    /// <see href="https://schema.org/Pond"></see></summary>
    let Pond = _prefix "Pond"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/positiveFilm"&gt;positive film&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/PositiveFilmDigitalSource"></see></summary>
    let PositiveFilmDigitalSource = _prefix "PositiveFilmDigitalSource"
    /// <summary>
    /// A post office.
    /// <see href="https://schema.org/PostOffice"></see></summary>
    let PostOffice = _prefix "PostOffice"
    /// <summary>
    /// The mailing address.
    /// <see href="https://schema.org/PostalAddress"></see></summary>
    let PostalAddress = _prefix "PostalAddress"
    /// <summary>
    /// Indicates a range of postal codes, usually defined as the set of valid codes between [[postalCodeBegin]] and [[postalCodeEnd]], inclusively.
    /// <see href="https://schema.org/PostalCodeRangeSpecification"></see></summary>
    let PostalCodeRangeSpecification = _prefix "PostalCodeRangeSpecification"
    /// <summary>
    /// A large, usually printed placard, bill, or announcement, often illustrated, that is posted to advertise or publicize something.
    /// <see href="https://schema.org/Poster"></see></summary>
    let Poster = _prefix "Poster"
    /// <summary>
    /// A description of an action that is supported.
    /// <see href="https://schema.org/PotentialActionStatus"></see></summary>
    let PotentialActionStatus = _prefix "PotentialActionStatus"
    /// <summary>
    /// Indicates that the item is available for pre-order.
    /// <see href="https://schema.org/PreOrder"></see></summary>
    let PreOrder = _prefix "PreOrder"
    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// <see href="https://schema.org/PreOrderAction"></see></summary>
    let PreOrderAction = _prefix "PreOrderAction"
    /// <summary>
    /// Indicates that the item is available for ordering and delivery before general availability.
    /// <see href="https://schema.org/PreSale"></see></summary>
    let PreSale = _prefix "PreSale"
    /// <summary>
    /// Content discussing pregnancy-related aspects of a health topic.
    /// <see href="https://schema.org/PregnancyHealthAspect"></see></summary>
    let PregnancyHealthAspect = _prefix "PregnancyHealthAspect"
    /// <summary>
    /// The act of inserting at the beginning if an ordered collection.
    /// <see href="https://schema.org/PrependAction"></see></summary>
    let PrependAction = _prefix "PrependAction"
    /// <summary>
    /// A preschool.
    /// <see href="https://schema.org/Preschool"></see></summary>
    let Preschool = _prefix "Preschool"
    /// <summary>
    /// Available by prescription only.
    /// <see href="https://schema.org/PrescriptionOnly"></see></summary>
    let PrescriptionOnly = _prefix "PrescriptionOnly"
    /// <summary>
    /// A file containing slides or used for a presentation.
    /// <see href="https://schema.org/PresentationDigitalDocument"></see></summary>
    let PresentationDigitalDocument = _prefix "PresentationDigitalDocument"
    /// <summary>
    /// Information about actions or measures that can be taken to avoid getting the topic or reaching a critical situation related to the topic.
    /// <see href="https://schema.org/PreventionHealthAspect"></see></summary>
    let PreventionHealthAspect = _prefix "PreventionHealthAspect"
    /// <summary>
    /// An indication for preventing an underlying condition, symptom, etc.
    /// <see href="https://schema.org/PreventionIndication"></see></summary>
    let PreventionIndication = _prefix "PreventionIndication"
    /// <summary>
    /// The medical care by a physician, or other health-care professional, who is the patient's first contact with the health-care system and who may recommend a specialist if necessary.
    /// <see href="https://schema.org/PrimaryCare"></see></summary>
    let PrimaryCare = _prefix "PrimaryCare"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/print"&gt;print&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/PrintDigitalSource"></see></summary>
    let PrintDigitalSource = _prefix "PrintDigitalSource"
    /// <summary>
    /// A prion is an infectious agent composed of protein in a misfolded form.
    /// <see href="https://schema.org/Prion"></see></summary>
    let Prion = _prefix "Prion"
    /// <summary>
    /// A set of products (either [[ProductGroup]]s or specific variants) that are listed together e.g. in an [[Offer]].
    /// <see href="https://schema.org/ProductCollection"></see></summary>
    let ProductCollection = _prefix "ProductCollection"
    /// <summary>
    /// A ProductGroup represents a group of [[Product]]s that vary only in certain well-described ways, such as by [[size]], [[color]], [[material]] etc.
    ///
    /// While a ProductGroup itself is not directly offered for sale, the various varying products that it represents can be. The ProductGroup serves as a prototype or template, standing in for all of the products who have an [[isVariantOf]] relationship to it. As such, properties (including additional types) can be applied to the ProductGroup to represent characteristics shared by each of the (possibly very many) variants. Properties that reference a ProductGroup are not included in this mechanism; neither are the following specific properties [[variesBy]], [[hasVariant]], [[url]].
    /// <see href="https://schema.org/ProductGroup"></see></summary>
    let ProductGroup = _prefix "ProductGroup"
    /// <summary>
    /// Original definition: "provider of professional services."\n\nThe general [[ProfessionalService]] type for local businesses was deprecated due to confusion with [[Service]]. For reference, the types that it included were: [[Dentist]],
    ///         [[AccountingService]], [[Attorney]], [[Notary]], as well as types for several kinds of [[HomeAndConstructionBusiness]]: [[Electrician]], [[GeneralContractor]],
    ///         [[HousePainter]], [[Locksmith]], [[Plumber]], [[RoofingContractor]]. [[LegalService]] was introduced as a more inclusive supertype of [[Attorney]].
    /// <see href="https://schema.org/ProfessionalService"></see></summary>
    let ProfessionalService = _prefix "ProfessionalService"
    /// <summary>
    /// Web page type: Profile page.
    /// <see href="https://schema.org/ProfilePage"></see></summary>
    let ProfilePage = _prefix "ProfilePage"
    /// <summary>
    /// Typical progression and happenings of life course of the topic.
    /// <see href="https://schema.org/PrognosisHealthAspect"></see></summary>
    let PrognosisHealthAspect = _prefix "PrognosisHealthAspect"
    /// <summary>
    /// Used to describe membership in a loyalty programs (e.g. "StarAliance"), traveler clubs (e.g. "AAA"), purchase clubs ("Safeway Club"), etc.
    /// <see href="https://schema.org/ProgramMembership"></see></summary>
    let ProgramMembership = _prefix "ProgramMembership"
    /// <summary>
    /// Data type: PronounceableText.
    /// <see href="https://schema.org/PronounceableText"></see></summary>
    let PronounceableText = _prefix "PronounceableText"
    /// <summary>
    /// A property, used to indicate attributes and relationships of some Thing; equivalent to rdf:Property.
    /// <see href="https://schema.org/Property"></see></summary>
    let Property = _prefix "Property"
    /// <summary>
    /// A Property value specification.
    /// <see href="https://schema.org/PropertyValueSpecification"></see></summary>
    let PropertyValueSpecification = _prefix "PropertyValueSpecification"
    /// <summary>
    /// Protein is here used in its widest possible definition, as classes of amino acid based molecules. Amyloid-beta Protein in human (UniProt P05067), eukaryota (e.g. an OrthoDB group) or even a single molecule that one can point to are all of type :Protein. A protein can thus be a subclass of another protein, e.g. :Protein as a UniProt record can have multiple isoforms inside it which would also be :Protein. They can be imagined, synthetic, hypothetical or naturally occurring.
    /// <see href="https://schema.org/Protein"></see></summary>
    let Protein = _prefix "Protein"
    /// <summary>
    /// Single-celled organism that causes an infection.
    /// <see href="https://schema.org/Protozoa"></see></summary>
    let Protozoa = _prefix "Protozoa"
    /// <summary>
    /// A specific branch of medical science that is concerned with the study, treatment, and prevention of mental illness, using both medical and psychological therapies.
    /// <see href="https://schema.org/Psychiatric"></see></summary>
    let Psychiatric = _prefix "Psychiatric"
    /// <summary>
    /// A process of care relying upon counseling, dialogue and communication  aimed at improving a mental health condition without use of drugs.
    /// <see href="https://schema.org/PsychologicalTreatment"></see></summary>
    let PsychologicalTreatment = _prefix "PsychologicalTreatment"
    /// <summary>
    /// Branch of medicine that pertains to the health services to improve and protect community health, especially epidemiology, sanitation, immunization, and preventive medicine.
    /// <see href="https://schema.org/PublicHealth"></see></summary>
    let PublicHealth = _prefix "PublicHealth"
    /// <summary>
    /// This stands for any day that is a public holiday; it is a placeholder for all official public holidays in some particular location. While not technically a "day of the week", it can be used with [[OpeningHoursSpecification]]. In the context of an opening hours specification it can be used to indicate opening hours on public holidays, overriding general opening hours for the day of the week on which a public holiday occurs.
    /// <see href="https://schema.org/PublicHolidays"></see></summary>
    let PublicHolidays = _prefix "PublicHolidays"
    /// <summary>
    /// A public swimming pool.
    /// <see href="https://schema.org/PublicSwimmingPool"></see></summary>
    let PublicSwimmingPool = _prefix "PublicSwimmingPool"
    /// <summary>
    /// A public toilet is a room or small building containing one or more toilets (and possibly also urinals) which is available for use by the general public, or by customers or employees of certain businesses.
    /// <see href="https://schema.org/PublicToilet"></see></summary>
    let PublicToilet = _prefix "PublicToilet"
    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.\n\nSee also [blog post](https://blog-schema.org/2014/09/02/schema-org-support-for-bibliographic-relationships-and-periodicals/).
    /// <see href="https://schema.org/PublicationVolume"></see></summary>
    let PublicationVolume = _prefix "PublicationVolume"
    /// <summary>
    /// A specific branch of medical science that pertains to the study of the respiratory system and its respective disease states.
    /// <see href="https://schema.org/Pulmonary"></see></summary>
    let Pulmonary = _prefix "Pulmonary"
    /// <summary>
    /// Enumerates a purchase type for an item.
    /// <see href="https://schema.org/PurchaseType"></see></summary>
    let PurchaseType = _prefix "PurchaseType"
    /// <summary>
    /// This is a lease of an item.
    /// <see href="https://schema.org/PurchaseTypeLease"></see></summary>
    let PurchaseTypeLease = _prefix "PurchaseTypeLease"
    /// <summary>
    /// This is a purchase of a new item.
    /// <see href="https://schema.org/PurchaseTypeNewPurchase"></see></summary>
    let PurchaseTypeNewPurchase = _prefix "PurchaseTypeNewPurchase"
    /// <summary>
    /// This is a trade-in for an item.
    /// <see href="https://schema.org/PurchaseTypeTradeIn"></see></summary>
    let PurchaseTypeTradeIn = _prefix "PurchaseTypeTradeIn"
    /// <summary>
    /// This is a purchase of a used item.
    /// <see href="https://schema.org/PurchaseTypeUsedPurchase"></see></summary>
    let PurchaseTypeUsedPurchase = _prefix "PurchaseTypeUsedPurchase"
    /// <summary>
    /// A QAPage is a WebPage focussed on a specific Question and its Answer(s), e.g. in a question answering site or documenting Frequently Asked Questions (FAQs).
    /// <see href="https://schema.org/QAPage"></see></summary>
    let QAPage = _prefix "QAPage"
    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// <see href="https://schema.org/Question"></see></summary>
    let Question = _prefix "Question"
    /// <summary>
    /// Quiz: A test of knowledge, skills and abilities.
    /// <see href="https://schema.org/Quiz"></see></summary>
    let Quiz = _prefix "Quiz"
    /// <summary>
    /// A quotation. Often but not necessarily from some written work, attributable to a real world author and - if associated with a fictional character - to any fictional Person. Use [[isBasedOn]] to link to source/origin. The [[recordedIn]] property can be used to reference a Quotation from an [[Event]].
    /// <see href="https://schema.org/Quotation"></see></summary>
    let Quotation = _prefix "Quotation"
    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// <see href="https://schema.org/QuoteAction"></see></summary>
    let QuoteAction = _prefix "QuoteAction"
    /// <summary>
    /// A place offering space for "Recreational Vehicles", Caravans, mobile homes and the like.
    /// <see href="https://schema.org/RVPark"></see></summary>
    let RVPark = _prefix "RVPark"
    /// <summary>
    /// A process of care using radiation aimed at improving a health condition.
    /// <see href="https://schema.org/RadiationTherapy"></see></summary>
    let RadiationTherapy = _prefix "RadiationTherapy"
    /// <summary>
    /// A delivery service through which radio content is provided via broadcast over the air or online.
    /// <see href="https://schema.org/RadioBroadcastService"></see></summary>
    let RadioBroadcastService = _prefix "RadioBroadcastService"
    /// <summary>
    /// A short radio program or a segment/part of a radio program.
    /// <see href="https://schema.org/RadioClip"></see></summary>
    let RadioClip = _prefix "RadioClip"
    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// <see href="https://schema.org/RadioEpisode"></see></summary>
    let RadioEpisode = _prefix "RadioEpisode"
    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// <see href="https://schema.org/RadioSeason"></see></summary>
    let RadioSeason = _prefix "RadioSeason"
    /// <summary>
    /// CreativeWorkSeries dedicated to radio broadcast and associated online delivery.
    /// <see href="https://schema.org/RadioSeries"></see></summary>
    let RadioSeries = _prefix "RadioSeries"
    /// <summary>
    /// A radio station.
    /// <see href="https://schema.org/RadioStation"></see></summary>
    let RadioStation = _prefix "RadioStation"
    /// <summary>
    /// Radiography is an imaging technique that uses electromagnetic radiation other than visible light, especially X-rays, to view the internal structure of a non-uniformly composed and opaque object such as the human body.
    /// <see href="https://schema.org/Radiography"></see></summary>
    let Radiography = _prefix "Radiography"
    /// <summary>
    /// A randomized trial design.
    /// <see href="https://schema.org/RandomizedTrial"></see></summary>
    let RandomizedTrial = _prefix "RandomizedTrial"
    /// <summary>
    /// The act of consuming written content.
    /// <see href="https://schema.org/ReadAction"></see></summary>
    let ReadAction = _prefix "ReadAction"
    /// <summary>
    /// Permission to read or view the document.
    /// <see href="https://schema.org/ReadPermission"></see></summary>
    let ReadPermission = _prefix "ReadPermission"
    /// <summary>
    /// A real-estate agent.
    /// <see href="https://schema.org/RealEstateAgent"></see></summary>
    let RealEstateAgent = _prefix "RealEstateAgent"
    /// <summary>
    /// A [[RealEstateListing]] is a listing that describes one or more real-estate [[Offer]]s (whose [[businessFunction]] is typically to lease out, or to sell).
    ///   The [[RealEstateListing]] type itself represents the overall listing, as manifested in some [[WebPage]].
    ///
    /// <see href="https://schema.org/RealEstateListing"></see></summary>
    let RealEstateListing = _prefix "RealEstateListing"
    /// <summary>
    /// Real-wheel drive is a transmission layout where the engine drives the rear wheels.
    /// <see href="https://schema.org/RearWheelDriveConfiguration"></see></summary>
    let RearWheelDriveConfiguration = _prefix "RearWheelDriveConfiguration"
    /// <summary>
    /// The act of physically/electronically taking delivery of an object that has been transferred from an origin to a destination. Reciprocal of SendAction.\n\nRelated actions:\n\n* [[SendAction]]: The reciprocal of ReceiveAction.\n* [[TakeAction]]: Unlike TakeAction, ReceiveAction does not imply that the ownership has been transferred (e.g. I can receive a package, but it does not mean the package is now mine).
    /// <see href="https://schema.org/ReceiveAction"></see></summary>
    let ReceiveAction = _prefix "ReceiveAction"
    /// <summary>
    /// A recipe. For dietary restrictions covered by the recipe, a few common restrictions are enumerated via [[suitableForDiet]]. The [[keywords]] property can also be used to add more detail.
    /// <see href="https://schema.org/Recipe"></see></summary>
    let Recipe = _prefix "Recipe"
    /// <summary>
    /// [[Recommendation]] is a type of [[Review]] that suggests or proposes something as the best option or best course of action. Recommendations may be for products or services, or other concrete things, as in the case of a ranked list or product guide. A [[Guide]] may list multiple recommendations for different categories. For example, in a [[Guide]] about which TVs to buy, the author may have several [[Recommendation]]s.
    /// <see href="https://schema.org/Recommendation"></see></summary>
    let Recommendation = _prefix "Recommendation"
    /// <summary>
    /// A recommended dosing schedule for a drug or supplement as prescribed or recommended by an authority or by the drug/supplement's manufacturer. Capture the recommending authority in the recognizingAuthority property of MedicalEntity.
    /// <see href="https://schema.org/RecommendedDoseSchedule"></see></summary>
    let RecommendedDoseSchedule = _prefix "RecommendedDoseSchedule"
    /// <summary>
    /// Recruiting participants.
    /// <see href="https://schema.org/Recruiting"></see></summary>
    let Recruiting = _prefix "Recruiting"
    /// <summary>
    /// A recycling center.
    /// <see href="https://schema.org/RecyclingCenter"></see></summary>
    let RecyclingCenter = _prefix "RecyclingCenter"

    /// <summary>
    /// A general code for cases where relevance to children is reduced, e.g. adult education, mortgages, retirement-related products, etc.
    /// <see href="https://schema.org/ReducedRelevanceForChildrenConsideration"></see></summary>
    let ReducedRelevanceForChildrenConsideration =
        _prefix "ReducedRelevanceForChildrenConsideration"

    /// <summary>
    /// Indicates that the item is refurbished.
    /// <see href="https://schema.org/RefurbishedCondition"></see></summary>
    let RefurbishedCondition = _prefix "RefurbishedCondition"
    /// <summary>
    /// The act of registering to be a user of a service, product or web page.\n\nRelated actions:\n\n* [[JoinAction]]: Unlike JoinAction, RegisterAction implies you are registering to be a user of a service, *not* a group/team of people.\n* [[FollowAction]]: Unlike FollowAction, RegisterAction doesn't imply that the agent is expecting to poll for updates from the object.\n* [[SubscribeAction]]: Unlike SubscribeAction, RegisterAction doesn't imply that the agent is expecting updates from the object.
    /// <see href="https://schema.org/RegisterAction"></see></summary>
    let RegisterAction = _prefix "RegisterAction"
    /// <summary>
    /// A registry-based study design.
    /// <see href="https://schema.org/Registry"></see></summary>
    let Registry = _prefix "Registry"
    /// <summary>
    /// Represents the regular price of an offered product. This is usually the advertised price before a temporary sale. Once the sale period ends the advertised price will go back to the regular price.
    /// <see href="https://schema.org/RegularPrice"></see></summary>
    let RegularPrice = _prefix "RegularPrice"
    /// <summary>
    /// The drug's cost represents the maximum reimbursement paid by an insurer for the drug.
    /// <see href="https://schema.org/ReimbursementCap"></see></summary>
    let ReimbursementCap = _prefix "ReimbursementCap"
    /// <summary>
    /// The act of rejecting to/adopting an object.\n\nRelated actions:\n\n* [[AcceptAction]]: The antonym of RejectAction.
    /// <see href="https://schema.org/RejectAction"></see></summary>
    let RejectAction = _prefix "RejectAction"
    /// <summary>
    /// Other prominent or relevant topics tied to the main topic.
    /// <see href="https://schema.org/RelatedTopicsHealthAspect"></see></summary>
    let RelatedTopicsHealthAspect = _prefix "RelatedTopicsHealthAspect"
    /// <summary>
    /// RemixAlbum.
    /// <see href="https://schema.org/RemixAlbum"></see></summary>
    let RemixAlbum = _prefix "RemixAlbum"
    /// <summary>
    /// A specific branch of medical science that pertains to the study of the kidneys and its respective disease states.
    /// <see href="https://schema.org/Renal"></see></summary>
    let Renal = _prefix "Renal"
    /// <summary>
    /// The act of giving money in return for temporary use, but not ownership, of an object such as a vehicle or property. For example, an agent rents a property from a landlord in exchange for a periodic payment.
    /// <see href="https://schema.org/RentAction"></see></summary>
    let RentAction = _prefix "RentAction"
    /// <summary>
    /// A reservation for a rental car.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// <see href="https://schema.org/RentalCarReservation"></see></summary>
    let RentalCarReservation = _prefix "RentalCarReservation"
    /// <summary>
    /// Indicates the usage of the vehicle as a rental car.
    /// <see href="https://schema.org/RentalVehicleUsage"></see></summary>
    let RentalVehicleUsage = _prefix "RentalVehicleUsage"
    /// <summary>
    /// A structured value representing repayment.
    /// <see href="https://schema.org/RepaymentSpecification"></see></summary>
    let RepaymentSpecification = _prefix "RepaymentSpecification"
    /// <summary>
    /// The act of editing a recipient by replacing an old object with a new object.
    /// <see href="https://schema.org/ReplaceAction"></see></summary>
    let ReplaceAction = _prefix "ReplaceAction"
    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to [[AskAction]].\n\nRelated actions:\n\n* [[AskAction]]: Appears generally as an origin of a ReplyAction.
    /// <see href="https://schema.org/ReplyAction"></see></summary>
    let ReplyAction = _prefix "ReplyAction"
    /// <summary>
    /// A Report generated by governmental or non-governmental organization.
    /// <see href="https://schema.org/Report"></see></summary>
    let Report = _prefix "Report"
    /// <summary>
    /// The [[ReportageNewsArticle]] type is a subtype of [[NewsArticle]] representing
    ///  news articles which are the result of journalistic news reporting conventions.
    ///
    /// In practice many news publishers produce a wide variety of article types, many of which might be considered a [[NewsArticle]] but not a [[ReportageNewsArticle]]. For example, opinion pieces, reviews, analysis, sponsored or satirical articles, or articles that combine several of these elements.
    ///
    /// The [[ReportageNewsArticle]] type is based on a stricter ideal for "news" as a work of journalism, with articles based on factual information either observed or verified by the author, or reported and verified from knowledgeable sources.  This often includes perspectives from multiple viewpoints on a particular issue (distinguishing news reports from public relations or propaganda).  News reports in the [[ReportageNewsArticle]] sense de-emphasize the opinion of the author, with commentary and value judgements typically expressed elsewhere.
    ///
    /// A [[ReportageNewsArticle]] which goes deeper into analysis can also be marked with an additional type of [[AnalysisNewsArticle]].
    ///
    /// <see href="https://schema.org/ReportageNewsArticle"></see></summary>
    let ReportageNewsArticle = _prefix "ReportageNewsArticle"
    /// <summary>
    /// A patient-reported or observed dosing schedule for a drug or supplement.
    /// <see href="https://schema.org/ReportedDoseSchedule"></see></summary>
    let ReportedDoseSchedule = _prefix "ReportedDoseSchedule"
    /// <summary>
    /// A Research Organization (e.g. scientific institute, research company).
    /// <see href="https://schema.org/ResearchOrganization"></see></summary>
    let ResearchOrganization = _prefix "ResearchOrganization"
    /// <summary>
    /// A Research project.
    /// <see href="https://schema.org/ResearchProject"></see></summary>
    let ResearchProject = _prefix "ResearchProject"
    /// <summary>
    /// Researchers.
    /// <see href="https://schema.org/Researcher"></see></summary>
    let Researcher = _prefix "Researcher"
    /// <summary>
    /// The status for a previously confirmed reservation that is now cancelled.
    /// <see href="https://schema.org/ReservationCancelled"></see></summary>
    let ReservationCancelled = _prefix "ReservationCancelled"
    /// <summary>
    /// Enumerated status values for Reservation.
    /// <see href="https://schema.org/ReservationStatusType"></see></summary>
    let ReservationStatusType = _prefix "ReservationStatusType"
    /// <summary>
    /// The status of a confirmed reservation.
    /// <see href="https://schema.org/ReservationConfirmed"></see></summary>
    let ReservationConfirmed = _prefix "ReservationConfirmed"
    /// <summary>
    /// The status of a reservation on hold pending an update like credit card number or flight changes.
    /// <see href="https://schema.org/ReservationHold"></see></summary>
    let ReservationHold = _prefix "ReservationHold"
    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// <see href="https://schema.org/ReservationPackage"></see></summary>
    let ReservationPackage = _prefix "ReservationPackage"
    /// <summary>
    /// The status of a reservation when a request has been sent, but not confirmed.
    /// <see href="https://schema.org/ReservationPending"></see></summary>
    let ReservationPending = _prefix "ReservationPending"
    /// <summary>
    /// Reserving a concrete object.\n\nRelated actions:\n\n* [[ScheduleAction]]: Unlike ScheduleAction, ReserveAction reserves concrete objects (e.g. a table, a hotel) towards a time slot / spatial allocation.
    /// <see href="https://schema.org/ReserveAction"></see></summary>
    let ReserveAction = _prefix "ReserveAction"
    /// <summary>
    /// Indicates that the item is reserved and therefore not available.
    /// <see href="https://schema.org/Reserved"></see></summary>
    let Reserved = _prefix "Reserved"
    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// <see href="https://schema.org/Reservoir"></see></summary>
    let Reservoir = _prefix "Reservoir"
    /// <summary>
    /// The action of resetting the password of a device or application.
    /// <see href="https://schema.org/ResetPasswordAction"></see></summary>
    let ResetPasswordAction = _prefix "ResetPasswordAction"
    /// <summary>
    /// A resort is a place used for relaxation or recreation, attracting visitors for holidays or vacations. Resorts are places, towns or sometimes commercial establishments operated by a single company (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Resort"&gt;http://en.wikipedia.org/wiki/Resort&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/Resort"></see></summary>
    let Resort = _prefix "Resort"
    /// <summary>
    /// The therapy that is concerned with the maintenance or improvement of respiratory function (as in patients with pulmonary disease).
    /// <see href="https://schema.org/RespiratoryTherapy"></see></summary>
    let RespiratoryTherapy = _prefix "RespiratoryTherapy"
    /// <summary>
    /// A restaurant.
    /// <see href="https://schema.org/Restaurant"></see></summary>
    let Restaurant = _prefix "Restaurant"
    /// <summary>
    /// Specifies that the customer must pay a restocking fee when returning a product.
    /// <see href="https://schema.org/RestockingFees"></see></summary>
    let RestockingFees = _prefix "RestockingFees"
    /// <summary>
    /// Results are available.
    /// <see href="https://schema.org/ResultsAvailable"></see></summary>
    let ResultsAvailable = _prefix "ResultsAvailable"
    /// <summary>
    /// Results are not available.
    /// <see href="https://schema.org/ResultsNotAvailable"></see></summary>
    let ResultsNotAvailable = _prefix "ResultsNotAvailable"
    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    /// <see href="https://schema.org/ResumeAction"></see></summary>
    let ResumeAction = _prefix "ResumeAction"
    /// <summary>
    /// The drug's cost represents the retail cost of the drug.
    /// <see href="https://schema.org/Retail"></see></summary>
    let Retail = _prefix "Retail"
    /// <summary>
    /// The act of returning to the origin that which was previously received (concrete objects) or taken (ownership).
    /// <see href="https://schema.org/ReturnAction"></see></summary>
    let ReturnAction = _prefix "ReturnAction"
    /// <summary>
    /// Specifies that product returns must be made at a kiosk.
    /// <see href="https://schema.org/ReturnAtKiosk"></see></summary>
    let ReturnAtKiosk = _prefix "ReturnAtKiosk"
    /// <summary>
    /// Specifies that product returns must be done by mail.
    /// <see href="https://schema.org/ReturnByMail"></see></summary>
    let ReturnByMail = _prefix "ReturnByMail"
    /// <summary>
    /// Specifies that product returns must be paid for, and are the responsibility of, the customer.
    /// <see href="https://schema.org/ReturnFeesCustomerResponsibility"></see></summary>
    let ReturnFeesCustomerResponsibility = _prefix "ReturnFeesCustomerResponsibility"
    /// <summary>
    /// Specifies that product returns must be made in a store.
    /// <see href="https://schema.org/ReturnInStore"></see></summary>
    let ReturnInStore = _prefix "ReturnInStore"
    /// <summary>
    /// Indicated that creating a return label is the responsibility of the customer.
    /// <see href="https://schema.org/ReturnLabelCustomerResponsibility"></see></summary>
    let ReturnLabelCustomerResponsibility = _prefix "ReturnLabelCustomerResponsibility"
    /// <summary>
    /// Enumerates several types of return labels for product returns.
    /// <see href="https://schema.org/ReturnLabelSourceEnumeration"></see></summary>
    let ReturnLabelSourceEnumeration = _prefix "ReturnLabelSourceEnumeration"
    /// <summary>
    /// Indicated that a return label must be downloaded and printed by the customer.
    /// <see href="https://schema.org/ReturnLabelDownloadAndPrint"></see></summary>
    let ReturnLabelDownloadAndPrint = _prefix "ReturnLabelDownloadAndPrint"
    /// <summary>
    /// Specifies that a return label will be provided by the seller in the shipping box.
    /// <see href="https://schema.org/ReturnLabelInBox"></see></summary>
    let ReturnLabelInBox = _prefix "ReturnLabelInBox"
    /// <summary>
    /// Specifies that the customer must pay the return shipping costs when returning a product.
    /// <see href="https://schema.org/ReturnShippingFees"></see></summary>
    let ReturnShippingFees = _prefix "ReturnShippingFees"
    /// <summary>
    /// The act of producing a balanced opinion about the object for an audience. An agent reviews an object with participants resulting in a review.
    /// <see href="https://schema.org/ReviewAction"></see></summary>
    let ReviewAction = _prefix "ReviewAction"
    /// <summary>
    /// A [[NewsArticle]] and [[CriticReview]] providing a professional critic's assessment of a service, product, performance, or artistic or literary work.
    /// <see href="https://schema.org/ReviewNewsArticle"></see></summary>
    let ReviewNewsArticle = _prefix "ReviewNewsArticle"
    /// <summary>
    /// A specific branch of medical science that deals with the study and treatment of rheumatic, autoimmune or joint diseases.
    /// <see href="https://schema.org/Rheumatologic"></see></summary>
    let Rheumatologic = _prefix "Rheumatologic"
    /// <summary>
    /// The steering position is on the right side of the vehicle (viewed from the main direction of driving).
    /// <see href="https://schema.org/RightHandDriving"></see></summary>
    let RightHandDriving = _prefix "RightHandDriving"
    /// <summary>
    /// Information about the risk factors and possible complications that may follow a topic.
    /// <see href="https://schema.org/RisksOrComplicationsHealthAspect"></see></summary>
    let RisksOrComplicationsHealthAspect = _prefix "RisksOrComplicationsHealthAspect"
    /// <summary>
    /// A river (for example, the broad majestic Shannon).
    /// <see href="https://schema.org/RiverBodyOfWater"></see></summary>
    let RiverBodyOfWater = _prefix "RiverBodyOfWater"
    /// <summary>
    /// A roofing contractor.
    /// <see href="https://schema.org/RoofingContractor"></see></summary>
    let RoofingContractor = _prefix "RoofingContractor"
    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// <see href="https://schema.org/RsvpAction"></see></summary>
    let RsvpAction = _prefix "RsvpAction"
    /// <summary>
    /// The invitee may or may not attend.
    /// <see href="https://schema.org/RsvpResponseMaybe"></see></summary>
    let RsvpResponseMaybe = _prefix "RsvpResponseMaybe"
    /// <summary>
    /// RsvpResponseType is an enumeration type whose instances represent responding to an RSVP request.
    /// <see href="https://schema.org/RsvpResponseType"></see></summary>
    let RsvpResponseType = _prefix "RsvpResponseType"
    /// <summary>
    /// The invitee will not attend.
    /// <see href="https://schema.org/RsvpResponseNo"></see></summary>
    let RsvpResponseNo = _prefix "RsvpResponseNo"
    /// <summary>
    /// The invitee will attend.
    /// <see href="https://schema.org/RsvpResponseYes"></see></summary>
    let RsvpResponseYes = _prefix "RsvpResponseYes"
    /// <summary>
    /// Specialized software environment that provides the essential infrastructure, libraries, and services required to execute a program.
    /// <see href="https://schema.org/RuntimePlatform"></see></summary>
    let RuntimePlatform = _prefix "RuntimePlatform"
    /// <summary>
    /// Represents the suggested retail price ("SRP") of an offered product.
    /// <see href="https://schema.org/SRP"></see></summary>
    let SRP = _prefix "SRP"
    /// <summary>
    /// Content about the safety-related aspects of a health topic.
    /// <see href="https://schema.org/SafetyHealthAspect"></see></summary>
    let SafetyHealthAspect = _prefix "SafetyHealthAspect"
    /// <summary>
    /// Event type: Sales event.
    /// <see href="https://schema.org/SaleEvent"></see></summary>
    let SaleEvent = _prefix "SaleEvent"
    /// <summary>
    /// Represents a sale price (usually active for a limited period) of an offered product.
    /// <see href="https://schema.org/SalePrice"></see></summary>
    let SalePrice = _prefix "SalePrice"
    /// <summary>
    /// Content coded 'satire or parody content' in a [[MediaReview]], considered in the context of how it was published or shared.
    ///
    /// For a [[VideoObject]] to be 'satire or parody content': A video that was created as political or humorous commentary and is presented in that context. (Reshares of satire/parody content that do not include relevant context are more likely to fall under the “missing context” rating.)
    ///
    /// For an [[ImageObject]] to be 'satire or parody content': An image that was created as political or humorous commentary and is presented in that context. (Reshares of satire/parody content that do not include relevant context are more likely to fall under the “missing context” rating.)
    ///
    /// For an [[ImageObject]] with embedded text to be 'satire or parody content': An image that was created as political or humorous commentary and is presented in that context. (Reshares of satire/parody content that do not include relevant context are more likely to fall under the “missing context” rating.)
    ///
    /// For an [[AudioObject]] to be 'satire or parody content': Audio that was created as political or humorous commentary and is presented in that context. (Reshares of satire/parody content that do not include relevant context are more likely to fall under the “missing context” rating.)
    ///
    /// <see href="https://schema.org/SatireOrParodyContent"></see></summary>
    let SatireOrParodyContent = _prefix "SatireOrParodyContent"
    /// <summary>
    /// An [[Article]] whose content is primarily [[satirical]](https://en.wikipedia.org/wiki/Satire) in nature, i.e. unlikely to be literally true. A satirical article is sometimes but not necessarily also a [[NewsArticle]]. [[ScholarlyArticle]]s are also sometimes satirized.
    /// <see href="https://schema.org/SatiricalArticle"></see></summary>
    let SatiricalArticle = _prefix "SatiricalArticle"
    /// <summary>
    /// The day of the week between Friday and Sunday.
    /// <see href="https://schema.org/Saturday"></see></summary>
    let Saturday = _prefix "Saturday"
    /// <summary>
    /// A schedule defines a repeating time period used to describe a regularly occurring [[Event]]. At a minimum a schedule will specify [[repeatFrequency]] which describes the interval between occurrences of the event. Additional information can be provided to specify the schedule more precisely.
    ///       This includes identifying the day(s) of the week or month when the recurring event will take place, in addition to its start and end time. Schedules may also
    ///       have start and end dates to indicate when they are active, e.g. to define a limited calendar of events.
    /// <see href="https://schema.org/Schedule"></see></summary>
    let Schedule = _prefix "Schedule"
    /// <summary>
    /// Scheduling future actions, events, or tasks.\n\nRelated actions:\n\n* [[ReserveAction]]: Unlike ReserveAction, ScheduleAction allocates future actions (e.g. an event, a task, etc) towards a time slot / spatial allocation.
    /// <see href="https://schema.org/ScheduleAction"></see></summary>
    let ScheduleAction = _prefix "ScheduleAction"
    /// <summary>
    /// A school.
    /// <see href="https://schema.org/School"></see></summary>
    let School = _prefix "School"
    /// <summary>
    /// A School District is an administrative area for the administration of schools.
    /// <see href="https://schema.org/SchoolDistrict"></see></summary>
    let SchoolDistrict = _prefix "SchoolDistrict"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/algorithmicMedia"&gt;algorithmic media&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/ScreenCaptureDigitalSource"></see></summary>
    let ScreenCaptureDigitalSource = _prefix "ScreenCaptureDigitalSource"
    /// <summary>
    /// A screening of a movie or other video.
    /// <see href="https://schema.org/ScreeningEvent"></see></summary>
    let ScreeningEvent = _prefix "ScreeningEvent"
    /// <summary>
    /// Content about how to screen or further filter a topic.
    /// <see href="https://schema.org/ScreeningHealthAspect"></see></summary>
    let ScreeningHealthAspect = _prefix "ScreeningHealthAspect"
    /// <summary>
    /// A piece of sculpture.
    /// <see href="https://schema.org/Sculpture"></see></summary>
    let Sculpture = _prefix "Sculpture"
    /// <summary>
    /// A sea (for example, the Caspian sea).
    /// <see href="https://schema.org/SeaBodyOfWater"></see></summary>
    let SeaBodyOfWater = _prefix "SeaBodyOfWater"
    /// <summary>
    /// The act of searching for an object.\n\nRelated actions:\n\n* [[FindAction]]: SearchAction generally leads to a FindAction, but not necessarily.
    /// <see href="https://schema.org/SearchAction"></see></summary>
    let SearchAction = _prefix "SearchAction"
    /// <summary>
    /// A Search and Rescue organization of some kind.
    /// <see href="https://schema.org/SearchRescueOrganization"></see></summary>
    let SearchRescueOrganization = _prefix "SearchRescueOrganization"
    /// <summary>
    /// Web page type: Search results page.
    /// <see href="https://schema.org/SearchResultsPage"></see></summary>
    let SearchResultsPage = _prefix "SearchResultsPage"
    /// <summary>
    /// A media season, e.g. TV, radio, video game etc.
    /// <see href="https://schema.org/Season"></see></summary>
    let Season = _prefix "Season"
    /// <summary>
    /// Used to describe a seat, such as a reserved seat in an event reservation.
    /// <see href="https://schema.org/Seat"></see></summary>
    let Seat = _prefix "Seat"
    /// <summary>
    /// A seating map.
    /// <see href="https://schema.org/SeatingMap"></see></summary>
    let SeatingMap = _prefix "SeatingMap"
    /// <summary>
    /// Information about questions that may be asked, when to see a professional, measures before seeing a doctor or content about the first consultation.
    /// <see href="https://schema.org/SeeDoctorHealthAspect"></see></summary>
    let SeeDoctorHealthAspect = _prefix "SeeDoctorHealthAspect"
    /// <summary>
    /// This is the [[Action]] of navigating to a specific [[startOffset]] timestamp within a [[VideoObject]], typically represented with a URL template structure.
    /// <see href="https://schema.org/SeekToAction"></see></summary>
    let SeekToAction = _prefix "SeekToAction"
    /// <summary>
    /// Self care actions or measures that can be taken to sooth, health or avoid a topic. This may be carried at home and can be carried/managed by the person itself.
    /// <see href="https://schema.org/SelfCareHealthAspect"></see></summary>
    let SelfCareHealthAspect = _prefix "SelfCareHealthAspect"
    /// <summary>
    /// A self-storage facility.
    /// <see href="https://schema.org/SelfStorage"></see></summary>
    let SelfStorage = _prefix "SelfStorage"
    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. Reciprocal of BuyAction.
    /// <see href="https://schema.org/SellAction"></see></summary>
    let SellAction = _prefix "SellAction"
    /// <summary>
    /// The act of physically/electronically dispatching an object for transfer from an origin to a destination. Related actions:\n\n* [[ReceiveAction]]: The reciprocal of SendAction.\n* [[GiveAction]]: Unlike GiveAction, SendAction does not imply the transfer of ownership (e.g. I can send you my laptop, but I'm not necessarily giving it to you).
    /// <see href="https://schema.org/SendAction"></see></summary>
    let SendAction = _prefix "SendAction"
    /// <summary>
    /// An art forms that use images deployed in a specific order for the purpose of graphic storytelling (i.e., narration of graphic stories) or conveying information. Examples of SequentialArt are Franco-Belgian Bande Dessinée, Comics in the USA and 漫画 (Manga) in Japan.
    /// <see href="https://schema.org/SequentialArt"></see></summary>
    let SequentialArt = _prefix "SequentialArt"
    /// <summary>
    /// A means for accessing a service, e.g. a government office location, web site, or phone number.
    /// <see href="https://schema.org/ServiceChannel"></see></summary>
    let ServiceChannel = _prefix "ServiceChannel"
    /// <summary>
    /// ServicePeriod represents a duration with some constraints about cutoff time and business days. This is used e.g. in shipping for handling times or transit time.
    /// <see href="https://schema.org/ServicePeriod"></see></summary>
    let ServicePeriod = _prefix "ServicePeriod"
    /// <summary>
    /// The item contains sexually oriented content such as nudity, suggestive or explicit material, or related online services, or is intended to enhance sexual activity. Examples: Erotic videos or magazine, sexual enhancement devices, sex toys.
    /// <see href="https://schema.org/SexualContentConsideration"></see></summary>
    let SexualContentConsideration = _prefix "SexualContentConsideration"
    /// <summary>
    /// The act of distributing content to people for their amusement or edification.
    /// <see href="https://schema.org/ShareAction"></see></summary>
    let ShareAction = _prefix "ShareAction"
    /// <summary>
    /// Printed music, as opposed to performed or recorded music.
    /// <see href="https://schema.org/SheetMusic"></see></summary>
    let SheetMusic = _prefix "SheetMusic"
    /// <summary>
    /// ShippingConditions represent a set of constraints and information about the conditions of shipping a product. Such conditions may apply to only a subset of the products being shipped, depending on aspects of the product like weight, size, price, destination, and others. All the specified conditions must be met for this ShippingConditions to apply.
    /// <see href="https://schema.org/ShippingConditions"></see></summary>
    let ShippingConditions = _prefix "ShippingConditions"
    /// <summary>
    /// ShippingDeliveryTime provides various pieces of information about delivery times for shipping.
    /// <see href="https://schema.org/ShippingDeliveryTime"></see></summary>
    let ShippingDeliveryTime = _prefix "ShippingDeliveryTime"
    /// <summary>
    /// A ShippingRateSettings represents re-usable pieces of shipping information. It is designed for publication on an URL that may be referenced via the [[shippingSettingsLink]] property of an [[OfferShippingDetails]]. Several occurrences can be published, distinguished and matched (i.e. identified/referenced) by their different values for [[shippingLabel]].
    /// <see href="https://schema.org/ShippingRateSettings"></see></summary>
    let ShippingRateSettings = _prefix "ShippingRateSettings"
    /// <summary>
    /// ShippingService represents the criteria used to determine if and how an offer could be shipped to a customer.
    /// <see href="https://schema.org/ShippingService"></see></summary>
    let ShippingService = _prefix "ShippingService"
    /// <summary>
    /// A shoe store.
    /// <see href="https://schema.org/ShoeStore"></see></summary>
    let ShoeStore = _prefix "ShoeStore"
    /// <summary>
    /// A shopping center or mall.
    /// <see href="https://schema.org/ShoppingCenter"></see></summary>
    let ShoppingCenter = _prefix "ShoppingCenter"
    /// <summary>
    /// Short story or tale. A brief work of literature, usually written in narrative prose.
    /// <see href="https://schema.org/ShortStory"></see></summary>
    let ShortStory = _prefix "ShortStory"
    /// <summary>
    /// Side effects that can be observed from the usage of the topic.
    /// <see href="https://schema.org/SideEffectsHealthAspect"></see></summary>
    let SideEffectsHealthAspect = _prefix "SideEffectsHealthAspect"
    /// <summary>
    /// A trial design in which the researcher knows which treatment the patient was randomly assigned to but the patient does not.
    /// <see href="https://schema.org/SingleBlindedTrial"></see></summary>
    let SingleBlindedTrial = _prefix "SingleBlindedTrial"
    /// <summary>
    /// A trial that takes place at a single center.
    /// <see href="https://schema.org/SingleCenterTrial"></see></summary>
    let SingleCenterTrial = _prefix "SingleCenterTrial"
    /// <summary>
    /// Residence type: Single-family home.
    /// <see href="https://schema.org/SingleFamilyResidence"></see></summary>
    let SingleFamilyResidence = _prefix "SingleFamilyResidence"
    /// <summary>
    /// Play mode: SinglePlayer. Which is played by a lone player.
    /// <see href="https://schema.org/SinglePlayer"></see></summary>
    let SinglePlayer = _prefix "SinglePlayer"
    /// <summary>
    /// SingleRelease.
    /// <see href="https://schema.org/SingleRelease"></see></summary>
    let SingleRelease = _prefix "SingleRelease"
    /// <summary>
    /// A navigation element of the page.
    /// <see href="https://schema.org/SiteNavigationElement"></see></summary>
    let SiteNavigationElement = _prefix "SiteNavigationElement"
    /// <summary>
    /// A web page element, like a table or an image.
    /// <see href="https://schema.org/WebPageElement"></see></summary>
    let WebPageElement = _prefix "WebPageElement"
    /// <summary>
    /// Enumerates common size groups for various product categories.
    /// <see href="https://schema.org/SizeGroupEnumeration"></see></summary>
    let SizeGroupEnumeration = _prefix "SizeGroupEnumeration"
    /// <summary>
    /// Size related properties of a product, typically a size code ([[name]]) and optionally a [[sizeSystem]], [[sizeGroup]], and product measurements ([[hasMeasurement]]). In addition, the intended audience can be defined through [[suggestedAge]], [[suggestedGender]], and suggested body measurements ([[suggestedMeasurement]]).
    /// <see href="https://schema.org/SizeSpecification"></see></summary>
    let SizeSpecification = _prefix "SizeSpecification"
    /// <summary>
    /// Enumerates common size systems for different categories of products, for example "EN-13402" or "UK" for wearables or "Imperial" for screws.
    /// <see href="https://schema.org/SizeSystemEnumeration"></see></summary>
    let SizeSystemEnumeration = _prefix "SizeSystemEnumeration"
    /// <summary>
    /// Imperial size system.
    /// <see href="https://schema.org/SizeSystemImperial"></see></summary>
    let SizeSystemImperial = _prefix "SizeSystemImperial"
    /// <summary>
    /// Metric size system.
    /// <see href="https://schema.org/SizeSystemMetric"></see></summary>
    let SizeSystemMetric = _prefix "SizeSystemMetric"
    /// <summary>
    /// A ski resort.
    /// <see href="https://schema.org/SkiResort"></see></summary>
    let SkiResort = _prefix "SkiResort"
    /// <summary>
    /// Skin assessment with clinical examination.
    /// <see href="https://schema.org/Skin"></see></summary>
    let Skin = _prefix "Skin"
    /// <summary>
    /// Event type: Social event.
    /// <see href="https://schema.org/SocialEvent"></see></summary>
    let SocialEvent = _prefix "SocialEvent"
    /// <summary>
    /// Indicates that the item has sold out.
    /// <see href="https://schema.org/SoldOut"></see></summary>
    let SoldOut = _prefix "SoldOut"
    /// <summary>
    /// The action that takes in a math expression and directs users to a page potentially capable of solving/simplifying that expression.
    /// <see href="https://schema.org/SolveMathAction"></see></summary>
    let SolveMathAction = _prefix "SolveMathAction"
    /// <summary>
    /// A placeholder for multiple similar products of the same kind.
    /// <see href="https://schema.org/SomeProducts"></see></summary>
    let SomeProducts = _prefix "SomeProducts"
    /// <summary>
    /// SoundtrackAlbum.
    /// <see href="https://schema.org/SoundtrackAlbum"></see></summary>
    let SoundtrackAlbum = _prefix "SoundtrackAlbum"
    /// <summary>
    /// A SpeakableSpecification indicates (typically via [[xpath]] or [[cssSelector]]) sections of a document that are highlighted as particularly [[speakable]]. Instances of this type are expected to be used primarily as values of the [[speakable]] property.
    /// <see href="https://schema.org/SpeakableSpecification"></see></summary>
    let SpeakableSpecification = _prefix "SpeakableSpecification"
    /// <summary>
    /// A SpecialAnnouncement combines a simple date-stamped textual information update
    ///       with contextualized Web links and other structured data.  It represents an information update made by a
    ///       locally-oriented organization, for example schools, pharmacies, healthcare providers,  community groups, police,
    ///       local government.
    ///
    /// For work in progress guidelines on Coronavirus-related markup see [this doc](https://docs.google.com/document/d/14ikaGCKxo50rRM7nvKSlbUpjyIk2WMQd3IkB1lItlrM/edit#).
    ///
    /// The motivating scenario for SpecialAnnouncement is the [Coronavirus pandemic](https://en.wikipedia.org/wiki/2019%E2%80%9320_coronavirus_pandemic), and the initial vocabulary is oriented to this urgent situation. Schema.org
    /// expect to improve the markup iteratively as it is deployed and as feedback emerges from use. In addition to our
    /// usual [Github entry](https://github.com/schemaorg/schemaorg/issues/2490), feedback comments can also be provided in [this document](https://docs.google.com/document/d/1fpdFFxk8s87CWwACs53SGkYv3aafSxz_DTtOQxMrBJQ/edit#).
    ///
    ///
    /// While this schema is designed to communicate urgent crisis-related information, it is not the same as an emergency warning technology like [CAP](https://en.wikipedia.org/wiki/Common_Alerting_Protocol), although there may be overlaps. The intent is to cover
    /// the kinds of everyday practical information being posted to existing websites during an emergency situation.
    ///
    /// Several kinds of information can be provided:
    ///
    /// We encourage the provision of "name", "text", "datePosted", "expires" (if appropriate), "category" and
    /// "url" as a simple baseline. It is important to provide a value for "category" where possible, most ideally as a well known
    /// URL from Wikipedia or Wikidata. In the case of the 2019-2020 Coronavirus pandemic, this should be "https://en.wikipedia.org/w/index.php?title=2019-20\_coronavirus\_pandemic" or "https://www.wikidata.org/wiki/Q81068910".
    ///
    /// For many of the possible properties, values can either be simple links or an inline description, depending on whether a summary is available. For a link, provide just the URL of the appropriate page as the property's value. For an inline description, use a [[WebContent]] type, and provide the url as a property of that, alongside at least a simple "[[text]]" summary of the page. It is
    /// unlikely that a single SpecialAnnouncement will need all of the possible properties simultaneously.
    ///
    /// We expect that in many cases the page referenced might contain more specialized structured data, e.g. contact info, [[openingHours]], [[Event]], [[FAQPage]] etc. By linking to those pages from a [[SpecialAnnouncement]] you can help make it clearer that the events are related to the situation (e.g. Coronavirus) indicated by the [[category]] property of the [[SpecialAnnouncement]].
    ///
    /// Many [[SpecialAnnouncement]]s will relate to particular regions and to identifiable local organizations. Use [[spatialCoverage]] for the region, and [[announcementLocation]] to indicate specific [[LocalBusiness]]es and [[CivicStructure]]s. If the announcement affects both a particular region and a specific location (for example, a library closure that serves an entire region), use both [[spatialCoverage]] and [[announcementLocation]].
    ///
    /// The [[about]] property can be used to indicate entities that are the focus of the announcement. We now recommend using [[about]] only
    /// for representing non-location entities (e.g. a [[Course]] or a [[RadioStation]]). For places, use [[announcementLocation]] and [[spatialCoverage]]. Consumers of this markup should be aware that the initial design encouraged the use of [[about]] for locations too.
    ///
    /// The basic content of [[SpecialAnnouncement]] is similar to that of an [RSS](https://en.wikipedia.org/wiki/RSS) or [Atom](https://en.wikipedia.org/wiki/Atom_(Web_standard)) feed. For publishers without such feeds, basic feed-like information can be shared by posting
    /// [[SpecialAnnouncement]] updates in a page, e.g. using JSON-LD. For sites with Atom/RSS functionality, you can point to a feed
    /// with the [[webFeed]] property. This can be a simple URL, or an inline [[DataFeed]] object, with [[encodingFormat]] providing
    /// media type information, e.g. "application/rss+xml" or "application/atom+xml".
    ///
    /// <see href="https://schema.org/SpecialAnnouncement"></see></summary>
    let SpecialAnnouncement = _prefix "SpecialAnnouncement"
    /// <summary>
    /// The scientific study and treatment of defects, disorders, and malfunctions of speech and voice, as stuttering, lisping, or lalling, and of language disturbances, as aphasia or delayed language acquisition.
    /// <see href="https://schema.org/SpeechPathology"></see></summary>
    let SpeechPathology = _prefix "SpeechPathology"
    /// <summary>
    /// SpokenWordAlbum.
    /// <see href="https://schema.org/SpokenWordAlbum"></see></summary>
    let SpokenWordAlbum = _prefix "SpokenWordAlbum"
    /// <summary>
    /// A sporting goods store.
    /// <see href="https://schema.org/SportingGoodsStore"></see></summary>
    let SportingGoodsStore = _prefix "SportingGoodsStore"
    /// <summary>
    /// A sports club.
    /// <see href="https://schema.org/SportsClub"></see></summary>
    let SportsClub = _prefix "SportsClub"
    /// <summary>
    /// Event type: Sports event.
    /// <see href="https://schema.org/SportsEvent"></see></summary>
    let SportsEvent = _prefix "SportsEvent"
    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// <see href="https://schema.org/SportsOrganization"></see></summary>
    let SportsOrganization = _prefix "SportsOrganization"
    /// <summary>
    /// Organization: Sports team.
    /// <see href="https://schema.org/SportsTeam"></see></summary>
    let SportsTeam = _prefix "SportsTeam"
    /// <summary>
    /// A spreadsheet file.
    /// <see href="https://schema.org/SpreadsheetDigitalDocument"></see></summary>
    let SpreadsheetDigitalDocument = _prefix "SpreadsheetDigitalDocument"
    /// <summary>
    /// A stadium.
    /// <see href="https://schema.org/StadiumOrArena"></see></summary>
    let StadiumOrArena = _prefix "StadiumOrArena"
    /// <summary>
    /// Content coded 'staged content' in a [[MediaReview]], considered in the context of how it was published or shared.
    ///
    /// For a [[VideoObject]] to be 'staged content': A video that has been created using actors or similarly contrived.
    ///
    /// For an [[ImageObject]] to be 'staged content': An image that was created using actors or similarly contrived, such as a screenshot of a fake tweet.
    ///
    /// For an [[ImageObject]] with embedded text to be 'staged content': An image that was created using actors or similarly contrived, such as a screenshot of a fake tweet.
    ///
    /// For an [[AudioObject]] to be 'staged content': Audio that has been created using actors or similarly contrived.
    ///
    /// <see href="https://schema.org/StagedContent"></see></summary>
    let StagedContent = _prefix "StagedContent"
    /// <summary>
    /// Stages that can be observed from a topic.
    /// <see href="https://schema.org/StagesHealthAspect"></see></summary>
    let StagesHealthAspect = _prefix "StagesHealthAspect"
    /// <summary>
    /// A state or province of a country.
    /// <see href="https://schema.org/State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// A statement about something, for example a fun or interesting fact. If known, the main entity this statement is about can be indicated using mainEntity. For more formal claims (e.g. in Fact Checking), consider using [[Claim]] instead. Use the [[text]] property to capture the text of the statement.
    /// <see href="https://schema.org/Statement"></see></summary>
    let Statement = _prefix "Statement"
    /// <summary>
    /// A StatisticalPopulation is a set of instances of a certain given type that satisfy some set of constraints. The property [[populationType]] is used to specify the type. Any property that can be used on instances of that type can appear on the statistical population. For example, a [[StatisticalPopulation]] representing all [[Person]]s with a [[homeLocation]] of East Podunk California would be described by applying the appropriate [[homeLocation]] and [[populationType]] properties to a [[StatisticalPopulation]] item that stands for that set of people.
    /// The properties [[numConstraints]] and [[constraintProperty]] are used to specify which of the populations properties are used to specify the population. Note that the sense of "population" used here is the general sense of a statistical
    /// population, and does not imply that the population consists of people. For example, a [[populationType]] of [[Event]] or [[NewsArticle]] could be used. See also [[Observation]], where a [[populationType]] such as [[Person]] or [[Event]] can be indicated directly. In most cases it may be better to use [[StatisticalVariable]] instead of [[StatisticalPopulation]].
    /// <see href="https://schema.org/StatisticalPopulation"></see></summary>
    let StatisticalPopulation = _prefix "StatisticalPopulation"
    /// <summary>
    /// [[StatisticalVariable]] represents any type of statistical metric that can be measured at a place and time. The usage pattern for [[StatisticalVariable]] is typically expressed using [[Observation]] with an explicit [[populationType]], which is a type, typically drawn from Schema.org. Each [[StatisticalVariable]] is marked as a [[ConstraintNode]], meaning that some properties (those listed using [[constraintProperty]]) serve in this setting solely to define the statistical variable rather than literally describe a specific person, place or thing. For example, a [[StatisticalVariable]] Median_Height_Person_Female representing the median height of women, could be written as follows: the population type is [[Person]]; the measuredProperty [[height]]; the [[statType]] [[median]]; the [[gender]] [[Female]]. It is important to note that there are many kinds of scientific quantitative observation which are not fully, perfectly or unambiguously described following this pattern, or with solely Schema.org terminology. The approach taken here is designed to allow partial, incremental or minimal description of [[StatisticalVariable]]s, and the use of detailed sets of entity and property IDs from external repositories. The [[measurementMethod]], [[unitCode]] and [[unitText]] properties can also be used to clarify the specific nature and notation of an observed measurement.
    /// <see href="https://schema.org/StatisticalVariable"></see></summary>
    let StatisticalVariable = _prefix "StatisticalVariable"
    /// <summary>
    /// Specifies that the customer receives a store credit as refund when returning a product.
    /// <see href="https://schema.org/StoreCreditRefund"></see></summary>
    let StoreCreditRefund = _prefix "StoreCreditRefund"
    /// <summary>
    /// Physical activity that is engaged in to improve muscle and bone strength. Also referred to as resistance training.
    /// <see href="https://schema.org/StrengthTraining"></see></summary>
    let StrengthTraining = _prefix "StrengthTraining"
    /// <summary>
    /// Represents the strikethrough price (the previous advertised price) of an offered product.
    /// <see href="https://schema.org/StrikethroughPrice"></see></summary>
    let StrikethroughPrice = _prefix "StrikethroughPrice"
    /// <summary>
    /// StudioAlbum.
    /// <see href="https://schema.org/StudioAlbum"></see></summary>
    let StudioAlbum = _prefix "StudioAlbum"
    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates pushed to.\n\nRelated actions:\n\n* [[FollowAction]]: Unlike FollowAction, SubscribeAction implies that the subscriber acts as a passive agent being constantly/actively pushed for updates.\n* [[RegisterAction]]: Unlike RegisterAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.\n* [[JoinAction]]: Unlike JoinAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.
    /// <see href="https://schema.org/SubscribeAction"></see></summary>
    let SubscribeAction = _prefix "SubscribeAction"
    /// <summary>
    /// Represents the subscription pricing component of the total price for an offered product.
    /// <see href="https://schema.org/Subscription"></see></summary>
    let Subscription = _prefix "Subscription"
    /// <summary>
    /// A subway station.
    /// <see href="https://schema.org/SubwayStation"></see></summary>
    let SubwayStation = _prefix "SubwayStation"
    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    ///
    /// <see href="https://schema.org/Suite"></see></summary>
    let Suite = _prefix "Suite"
    /// <summary>
    /// The day of the week between Saturday and Monday.
    /// <see href="https://schema.org/Sunday"></see></summary>
    let Sunday = _prefix "Sunday"
    /// <summary>
    /// Anatomical features that can be observed by sight (without dissection), including the form and proportions of the human body as well as surface landmarks that correspond to deeper subcutaneous structures. Superficial anatomy plays an important role in sports medicine, phlebotomy, and other medical specialties as underlying anatomical structures can be identified through surface palpation. For example, during back surgery, superficial anatomy can be used to palpate and count vertebrae to find the site of incision. Or in phlebotomy, superficial anatomy can be used to locate an underlying vein; for example, the median cubital vein can be located by palpating the borders of the cubital fossa (such as the epicondyles of the humerus) and then looking for the superficial signs of the vein, such as size, prominence, ability to refill after depression, and feel of surrounding tissue support. As another example, in a subluxation (dislocation) of the glenohumeral joint, the bony structure becomes pronounced with the deltoid muscle failing to cover the glenohumeral joint allowing the edges of the scapula to be superficially visible. Here, the superficial anatomy is the visible edges of the scapula, implying the underlying dislocation of the joint (the related anatomical structure).
    /// <see href="https://schema.org/SuperficialAnatomy"></see></summary>
    let SuperficialAnatomy = _prefix "SuperficialAnatomy"
    /// <summary>
    /// A specific branch of medical science that pertains to treating diseases, injuries and deformities by manual and instrumental means.
    /// <see href="https://schema.org/Surgical"></see></summary>
    let Surgical = _prefix "Surgical"
    /// <summary>
    /// A medical procedure involving an incision with instruments; performed for diagnose, or therapeutic purposes.
    /// <see href="https://schema.org/SurgicalProcedure"></see></summary>
    let SurgicalProcedure = _prefix "SurgicalProcedure"
    /// <summary>
    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    /// <see href="https://schema.org/SuspendAction"></see></summary>
    let SuspendAction = _prefix "SuspendAction"
    /// <summary>
    /// Suspended.
    /// <see href="https://schema.org/Suspended"></see></summary>
    let Suspended = _prefix "Suspended"
    /// <summary>
    /// A syllabus that describes the material covered in a course, often with several such sections per [[Course]] so that a distinct [[timeRequired]] can be provided for that section of the [[Course]].
    /// <see href="https://schema.org/Syllabus"></see></summary>
    let Syllabus = _prefix "Syllabus"
    /// <summary>
    /// Symptoms or related symptoms of a Topic.
    /// <see href="https://schema.org/SymptomsHealthAspect"></see></summary>
    let SymptomsHealthAspect = _prefix "SymptomsHealthAspect"
    /// <summary>
    /// A synagogue.
    /// <see href="https://schema.org/Synagogue"></see></summary>
    let Synagogue = _prefix "Synagogue"
    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// <see href="https://schema.org/TVClip"></see></summary>
    let TVClip = _prefix "TVClip"
    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// <see href="https://schema.org/TVEpisode"></see></summary>
    let TVEpisode = _prefix "TVEpisode"
    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// <see href="https://schema.org/TVSeason"></see></summary>
    let TVSeason = _prefix "TVSeason"
    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// <see href="https://schema.org/TVSeries"></see></summary>
    let TVSeries = _prefix "TVSeries"
    /// <summary>
    /// A table on a Web page.
    /// <see href="https://schema.org/Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    /// The act of gaining ownership of an object from an origin. Reciprocal of GiveAction.\n\nRelated actions:\n\n* [[GiveAction]]: The reciprocal of TakeAction.\n* [[ReceiveAction]]: Unlike ReceiveAction, TakeAction implies that ownership has been transferred.
    /// <see href="https://schema.org/TakeAction"></see></summary>
    let TakeAction = _prefix "TakeAction"
    /// <summary>
    /// A tattoo parlor.
    /// <see href="https://schema.org/TattooParlor"></see></summary>
    let TattooParlor = _prefix "TattooParlor"
    /// <summary>
    /// A taxi.
    /// <see href="https://schema.org/Taxi"></see></summary>
    let Taxi = _prefix "Taxi"
    /// <summary>
    /// A service for a vehicle for hire with a driver for local travel. Fares are usually calculated based on distance traveled.
    /// <see href="https://schema.org/TaxiService"></see></summary>
    let TaxiService = _prefix "TaxiService"
    /// <summary>
    /// A reservation for a taxi.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// <see href="https://schema.org/TaxiReservation"></see></summary>
    let TaxiReservation = _prefix "TaxiReservation"
    /// <summary>
    /// A taxi stand.
    /// <see href="https://schema.org/TaxiStand"></see></summary>
    let TaxiStand = _prefix "TaxiStand"
    /// <summary>
    /// Indicates the usage of the car as a taxi.
    /// <see href="https://schema.org/TaxiVehicleUsage"></see></summary>
    let TaxiVehicleUsage = _prefix "TaxiVehicleUsage"
    /// <summary>
    /// A set of organisms asserted to represent a natural cohesive biological unit.
    /// <see href="https://schema.org/Taxon"></see></summary>
    let Taxon = _prefix "Taxon"
    /// <summary>
    /// A unique instance of a television BroadcastService on a CableOrSatelliteService lineup.
    /// <see href="https://schema.org/TelevisionChannel"></see></summary>
    let TelevisionChannel = _prefix "TelevisionChannel"
    /// <summary>
    /// A television station.
    /// <see href="https://schema.org/TelevisionStation"></see></summary>
    let TelevisionStation = _prefix "TelevisionStation"
    /// <summary>
    /// A tennis complex.
    /// <see href="https://schema.org/TennisComplex"></see></summary>
    let TennisComplex = _prefix "TennisComplex"
    /// <summary>
    /// Terminated.
    /// <see href="https://schema.org/Terminated"></see></summary>
    let Terminated = _prefix "Terminated"
    /// <summary>
    /// A file composed primarily of text.
    /// <see href="https://schema.org/TextDigitalDocument"></see></summary>
    let TextDigitalDocument = _prefix "TextDigitalDocument"
    /// <summary>
    /// A text file. The text can be unformatted or contain markup, html, etc.
    /// <see href="https://schema.org/TextObject"></see></summary>
    let TextObject = _prefix "TextObject"
    /// <summary>
    /// Event type: Theater performance.
    /// <see href="https://schema.org/TheaterEvent"></see></summary>
    let TheaterEvent = _prefix "TheaterEvent"
    /// <summary>
    /// A theater group or company, for example, the Royal Shakespeare Company or Druid Theatre.
    /// <see href="https://schema.org/TheaterGroup"></see></summary>
    let TheaterGroup = _prefix "TheaterGroup"
    /// <summary>
    /// A medical device used for therapeutic purposes.
    /// <see href="https://schema.org/Therapeutic"></see></summary>
    let Therapeutic = _prefix "Therapeutic"
    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// <see href="https://schema.org/Thesis"></see></summary>
    let Thesis = _prefix "Thesis"
    /// <summary>
    /// Throat assessment with  clinical examination.
    /// <see href="https://schema.org/Throat"></see></summary>
    let Throat = _prefix "Throat"
    /// <summary>
    /// The day of the week between Wednesday and Friday.
    /// <see href="https://schema.org/Thursday"></see></summary>
    let Thursday = _prefix "Thursday"
    /// <summary>
    /// Used to describe a ticket to an event, a flight, a bus ride, etc.
    /// <see href="https://schema.org/Ticket"></see></summary>
    let Ticket = _prefix "Ticket"
    /// <summary>
    /// The act of reaching a draw in a competitive activity.
    /// <see href="https://schema.org/TieAction"></see></summary>
    let TieAction = _prefix "TieAction"
    /// <summary>
    /// An enumeration of possible benefits as part of a loyalty (members) program.
    /// <see href="https://schema.org/TierBenefitEnumeration"></see></summary>
    let TierBenefitEnumeration = _prefix "TierBenefitEnumeration"
    /// <summary>
    /// Benefit of the tier is earning of loyalty points.
    /// <see href="https://schema.org/TierBenefitLoyaltyPoints"></see></summary>
    let TierBenefitLoyaltyPoints = _prefix "TierBenefitLoyaltyPoints"
    /// <summary>
    /// Benefit of the tier is a members-only price.
    /// <see href="https://schema.org/TierBenefitLoyaltyPrice"></see></summary>
    let TierBenefitLoyaltyPrice = _prefix "TierBenefitLoyaltyPrice"
    /// <summary>
    /// Benefit of the tier is members-only returns, for example free unlimited returns.
    /// <see href="https://schema.org/TierBenefitLoyaltyReturns"></see></summary>
    let TierBenefitLoyaltyReturns = _prefix "TierBenefitLoyaltyReturns"
    /// <summary>
    /// Benefit of the tier is a members-only shipping price or speed (for example free shipping or 1-day shipping).
    /// <see href="https://schema.org/TierBenefitLoyaltyShipping"></see></summary>
    let TierBenefitLoyaltyShipping = _prefix "TierBenefitLoyaltyShipping"
    /// <summary>
    /// A point in time recurring on multiple days in the form hh:mm:ss[Z|(+|-)hh:mm] (see [XML schema for details](http://www.w3.org/TR/xmlschema-2/#time)).
    /// <see href="https://schema.org/Time"></see></summary>
    let Time = _prefix "Time"
    /// <summary>
    /// The act of giving money voluntarily to a beneficiary in recognition of services rendered.
    /// <see href="https://schema.org/TipAction"></see></summary>
    let TipAction = _prefix "TipAction"
    /// <summary>
    /// A tire shop.
    /// <see href="https://schema.org/TireShop"></see></summary>
    let TireShop = _prefix "TireShop"
    /// <summary>
    /// Item contains tobacco and/or nicotine, for example cigars, cigarettes, chewing tobacco, e-cigarettes, or hookahs.
    /// <see href="https://schema.org/TobaccoNicotineConsideration"></see></summary>
    let TobaccoNicotineConsideration = _prefix "TobaccoNicotineConsideration"
    /// <summary>
    /// The associated telephone number is toll free.
    /// <see href="https://schema.org/TollFree"></see></summary>
    let TollFree = _prefix "TollFree"
    /// <summary>
    /// A tourist attraction.  In principle any Thing can be a [[TouristAttraction]], from a [[Mountain]] and [[LandmarksOrHistoricalBuildings]] to a [[LocalBusiness]].  This Type can be used on its own to describe a general [[TouristAttraction]], or be used as an [[additionalType]] to add tourist attraction properties to any other type.  (See examples below)
    /// <see href="https://schema.org/TouristAttraction"></see></summary>
    let TouristAttraction = _prefix "TouristAttraction"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/IIT-CNR.it"></see>
    /// </summary>
    let ``docs/collab/IIT-CNR.it`` = _prefix "docs/collab/IIT-CNR.it"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/Tourism"></see>
    /// </summary>
    let ``docs/collab/Tourism`` = _prefix "docs/collab/Tourism"
    /// <summary>
    /// A tourist destination. In principle any [[Place]] can be a [[TouristDestination]] from a [[City]], Region or [[Country]] to an [[AmusementPark]] or [[Hotel]]. This Type can be used on its own to describe a general [[TouristDestination]], or be used as an [[additionalType]] to add tourist relevant properties to any other [[Place]].  A [[TouristDestination]] is defined as a [[Place]] that contains, or is colocated with, one or more [[TouristAttraction]]s, often linked by a similar theme or interest to a particular [[touristType]]. The [UNWTO](http://www2.unwto.org/) defines Destination (main destination of a tourism trip) as the place visited that is central to the decision to take the trip.
    ///   (See examples below.)
    /// <see href="https://schema.org/TouristDestination"></see></summary>
    let TouristDestination = _prefix "TouristDestination"
    /// <summary>
    /// A tourist information center.
    /// <see href="https://schema.org/TouristInformationCenter"></see></summary>
    let TouristInformationCenter = _prefix "TouristInformationCenter"
    /// <summary>
    /// A tourist trip. A created itinerary of visits to one or more places of interest ([[TouristAttraction]]/[[TouristDestination]]) often linked by a similar theme, geographic area, or interest to a particular [[touristType]]. The [UNWTO](http://www2.unwto.org/) defines tourism trip as the Trip taken by visitors.
    ///   (See examples below.)
    /// <see href="https://schema.org/TouristTrip"></see></summary>
    let TouristTrip = _prefix "TouristTrip"
    /// <summary>
    /// A specific branch of medical science that is concerned with poisons, their nature, effects and detection and involved in the treatment of poisoning.
    /// <see href="https://schema.org/Toxicologic"></see></summary>
    let Toxicologic = _prefix "Toxicologic"
    /// <summary>
    /// A toy store.
    /// <see href="https://schema.org/ToyStore"></see></summary>
    let ToyStore = _prefix "ToyStore"
    /// <summary>
    /// An agent tracks an object for updates.\n\nRelated actions:\n\n* [[FollowAction]]: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.\n* [[SubscribeAction]]: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.
    /// <see href="https://schema.org/TrackAction"></see></summary>
    let TrackAction = _prefix "TrackAction"
    /// <summary>
    /// A system of medicine based on common theoretical concepts that originated in China and evolved over thousands of years, that uses herbs, acupuncture, exercise, massage, dietary therapy, and other methods to treat a wide range of conditions.
    /// <see href="https://schema.org/TraditionalChinese"></see></summary>
    let TraditionalChinese = _prefix "TraditionalChinese"
    /// <summary>
    /// A reservation for train travel.\n\nNote: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use [[Offer]].
    /// <see href="https://schema.org/TrainReservation"></see></summary>
    let TrainReservation = _prefix "TrainReservation"
    /// <summary>
    /// A train station.
    /// <see href="https://schema.org/TrainStation"></see></summary>
    let TrainStation = _prefix "TrainStation"
    /// <summary>
    /// A trip on a commercial train line.
    /// <see href="https://schema.org/TrainTrip"></see></summary>
    let TrainTrip = _prefix "TrainTrip"

    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/trainedAlgorithmicMedia"&gt;trained algorithmic media&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/TrainedAlgorithmicMediaDigitalSource"></see></summary>
    let TrainedAlgorithmicMediaDigitalSource =
        _prefix "TrainedAlgorithmicMediaDigitalSource"

    /// <summary>
    /// Content coded 'transformed content' in a [[MediaReview]], considered in the context of how it was published or shared.
    ///
    /// For a [[VideoObject]] to be 'transformed content':  or all of the video has been manipulated to transform the footage itself. This category includes using tools like the Adobe Suite to change the speed of the video, add or remove visual elements or dub audio. Deepfakes are also a subset of transformation.
    ///
    /// For an [[ImageObject]] to be 'transformed content': Adding or deleting visual elements to give the image a different meaning with the intention to mislead.
    ///
    /// For an [[ImageObject]] with embedded text to be 'transformed content': Adding or deleting visual elements to give the image a different meaning with the intention to mislead.
    ///
    /// For an [[AudioObject]] to be 'transformed content': Part or all of the audio has been manipulated to alter the words or sounds, or the audio has been synthetically generated, such as to create a sound-alike voice.
    ///
    /// <see href="https://schema.org/TransformedContent"></see></summary>
    let TransformedContent = _prefix "TransformedContent"
    /// <summary>
    /// A transit map.
    /// <see href="https://schema.org/TransitMap"></see></summary>
    let TransitMap = _prefix "TransitMap"
    /// <summary>
    /// The act of traveling from a fromLocation to a destination by a specified mode of transport, optionally with participants.
    /// <see href="https://schema.org/TravelAction"></see></summary>
    let TravelAction = _prefix "TravelAction"
    /// <summary>
    /// A travel agency.
    /// <see href="https://schema.org/TravelAgency"></see></summary>
    let TravelAgency = _prefix "TravelAgency"
    /// <summary>
    /// An indication for treating an underlying condition, symptom, etc.
    /// <see href="https://schema.org/TreatmentIndication"></see></summary>
    let TreatmentIndication = _prefix "TreatmentIndication"
    /// <summary>
    /// Treatments or related therapies for a Topic.
    /// <see href="https://schema.org/TreatmentsHealthAspect"></see></summary>
    let TreatmentsHealthAspect = _prefix "TreatmentsHealthAspect"
    /// <summary>
    /// A trial design in which neither the researcher, the person administering the therapy nor the patient knows the details of the treatment the patient was randomly assigned to.
    /// <see href="https://schema.org/TripleBlindedTrial"></see></summary>
    let TripleBlindedTrial = _prefix "TripleBlindedTrial"
    /// <summary>
    /// The boolean value true.
    /// <see href="https://schema.org/True"></see></summary>
    let True = _prefix "True"
    /// <summary>
    /// The day of the week between Monday and Wednesday.
    /// <see href="https://schema.org/Tuesday"></see></summary>
    let Tuesday = _prefix "Tuesday"
    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// <see href="https://schema.org/TypeAndQuantityNode"></see></summary>
    let TypeAndQuantityNode = _prefix "TypeAndQuantityNode"
    /// <summary>
    /// Categorization and other types related to a topic.
    /// <see href="https://schema.org/TypesHealthAspect"></see></summary>
    let TypesHealthAspect = _prefix "TypesHealthAspect"
    /// <summary>
    /// UKTrust: Non-profit type referring to a UK trust.
    /// <see href="https://schema.org/UKTrust"></see></summary>
    let UKTrust = _prefix "UKTrust"
    /// <summary>
    /// Data type: URL.
    /// <see href="https://schema.org/URL"></see></summary>
    let URL = _prefix "URL"
    /// <summary>
    /// Ultrasound imaging.
    /// <see href="https://schema.org/Ultrasound"></see></summary>
    let Ultrasound = _prefix "Ultrasound"
    /// <summary>
    /// The act of un-registering from a service.\n\nRelated actions:\n\n* [[RegisterAction]]: antonym of UnRegisterAction.\n* [[LeaveAction]]: Unlike LeaveAction, UnRegisterAction implies that you are unregistering from a service you were previously registered, rather than leaving a team/group of people.
    /// <see href="https://schema.org/UnRegisterAction"></see></summary>
    let UnRegisterAction = _prefix "UnRegisterAction"
    /// <summary>
    /// The item is suitable only for adults, without indicating why. Due to widespread use of "adult" as a euphemism for "sexual", many such items are likely suited also for the SexualContentConsideration code.
    /// <see href="https://schema.org/UnclassifiedAdultConsideration"></see></summary>
    let UnclassifiedAdultConsideration = _prefix "UnclassifiedAdultConsideration"
    /// <summary>
    /// UnemploymentSupport: this is a benefit for unemployment support.
    /// <see href="https://schema.org/UnemploymentSupport"></see></summary>
    let UnemploymentSupport = _prefix "UnemploymentSupport"
    /// <summary>
    /// UnincorporatedAssociationCharity: Non-profit type referring to a charitable company that is not incorporated (UK).
    /// <see href="https://schema.org/UnincorporatedAssociationCharity"></see></summary>
    let UnincorporatedAssociationCharity = _prefix "UnincorporatedAssociationCharity"
    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// <see href="https://schema.org/UnitPriceSpecification"></see></summary>
    let UnitPriceSpecification = _prefix "UnitPriceSpecification"
    /// <summary>
    /// Indicates that a document has no particular or special standing (e.g. a republication of a law by a private publisher).
    /// <see href="https://schema.org/UnofficialLegalValue"></see></summary>
    let UnofficialLegalValue = _prefix "UnofficialLegalValue"
    /// <summary>
    /// A specific branch of medical science that is concerned with the diagnosis and treatment of diseases pertaining to the urinary tract and the urogenital system.
    /// <see href="https://schema.org/Urologic"></see></summary>
    let Urologic = _prefix "Urologic"
    /// <summary>
    /// Content about how, when, frequency and dosage of a topic.
    /// <see href="https://schema.org/UsageOrScheduleHealthAspect"></see></summary>
    let UsageOrScheduleHealthAspect = _prefix "UsageOrScheduleHealthAspect"
    /// <summary>
    /// The act of applying an object to its intended purpose.
    /// <see href="https://schema.org/UseAction"></see></summary>
    let UseAction = _prefix "UseAction"
    /// <summary>
    /// Indicates that the item is used.
    /// <see href="https://schema.org/UsedCondition"></see></summary>
    let UsedCondition = _prefix "UsedCondition"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserBlocks"></see></summary>
    let UserBlocks = _prefix "UserBlocks"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserInteraction"></see></summary>
    let UserInteraction = _prefix "UserInteraction"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserCheckins"></see></summary>
    let UserCheckins = _prefix "UserCheckins"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserComments"></see></summary>
    let UserComments = _prefix "UserComments"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserDownloads"></see></summary>
    let UserDownloads = _prefix "UserDownloads"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserLikes"></see></summary>
    let UserLikes = _prefix "UserLikes"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserPageVisits"></see></summary>
    let UserPageVisits = _prefix "UserPageVisits"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserPlays"></see></summary>
    let UserPlays = _prefix "UserPlays"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserPlusOnes"></see></summary>
    let UserPlusOnes = _prefix "UserPlusOnes"
    /// <summary>
    /// A review created by an end-user (e.g. consumer, purchaser, attendee etc.), in contrast with [[CriticReview]].
    /// <see href="https://schema.org/UserReview"></see></summary>
    let UserReview = _prefix "UserReview"
    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages. It is generally better to use [[Action]]-based vocabulary, alongside types such as [[Comment]].
    /// <see href="https://schema.org/UserTweets"></see></summary>
    let UserTweets = _prefix "UserTweets"
    /// <summary>
    /// A kind of lodging business that focuses on renting single properties for limited time.
    /// <see href="https://schema.org/VacationRental"></see></summary>
    let VacationRental = _prefix "VacationRental"
    /// <summary>
    /// A diet exclusive of all animal products.
    /// <see href="https://schema.org/VeganDiet"></see></summary>
    let VeganDiet = _prefix "VeganDiet"
    /// <summary>
    /// A diet exclusive of animal meat.
    /// <see href="https://schema.org/VegetarianDiet"></see></summary>
    let VegetarianDiet = _prefix "VegetarianDiet"
    /// <summary>
    /// A type of blood vessel that specifically carries blood to the heart.
    /// <see href="https://schema.org/Vein"></see></summary>
    let Vein = _prefix "Vein"
    /// <summary>
    /// A venue map (e.g. for malls, auditoriums, museums, etc.).
    /// <see href="https://schema.org/VenueMap"></see></summary>
    let VenueMap = _prefix "VenueMap"
    /// <summary>
    /// A vet's office.
    /// <see href="https://schema.org/VeterinaryCare"></see></summary>
    let VeterinaryCare = _prefix "VeterinaryCare"
    /// <summary>
    /// Web page type: Video gallery page.
    /// <see href="https://schema.org/VideoGallery"></see></summary>
    let VideoGallery = _prefix "VideoGallery"
    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// <see href="https://schema.org/VideoGame"></see></summary>
    let VideoGame = _prefix "VideoGame"
    /// <summary>
    /// A short segment/part of a video game.
    /// <see href="https://schema.org/VideoGameClip"></see></summary>
    let VideoGameClip = _prefix "VideoGameClip"
    /// <summary>
    /// A video game series.
    /// <see href="https://schema.org/VideoGameSeries"></see></summary>
    let VideoGameSeries = _prefix "VideoGameSeries"
    /// <summary>
    /// A video file.
    /// <see href="https://schema.org/VideoObject"></see></summary>
    let VideoObject = _prefix "VideoObject"
    /// <summary>
    /// A specific and exact (byte-for-byte) version of a [[VideoObject]]. Two byte-for-byte identical files, for the purposes of this type, considered identical. If they have different embedded metadata the files will differ. Different external facts about the files, e.g. creator or dateCreated that aren't represented in their actual content, do not affect this notion of identity.
    /// <see href="https://schema.org/VideoObjectSnapshot"></see></summary>
    let VideoObjectSnapshot = _prefix "VideoObjectSnapshot"
    /// <summary>
    /// The act of consuming static visual content.
    /// <see href="https://schema.org/ViewAction"></see></summary>
    let ViewAction = _prefix "ViewAction"
    /// <summary>
    /// VinylFormat.
    /// <see href="https://schema.org/VinylFormat"></see></summary>
    let VinylFormat = _prefix "VinylFormat"
    /// <summary>
    /// Item shows or promotes violence.
    /// <see href="https://schema.org/ViolenceConsideration"></see></summary>
    let ViolenceConsideration = _prefix "ViolenceConsideration"
    /// <summary>
    /// An online or virtual location for attending events. For example, one may attend an online seminar or educational event. While a virtual location may be used as the location of an event, virtual locations should not be confused with physical locations in the real world.
    /// <see href="https://schema.org/VirtualLocation"></see></summary>
    let VirtualLocation = _prefix "VirtualLocation"
    /// <summary>
    /// Content coded as '&lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/virtualRecording"&gt;virtual recording&lt;/a&gt;' using the IPTC &lt;a href="https://cv.iptc.org/newscodes/digitalsourcetype/"&gt;digital source type&lt;/a&gt; vocabulary.
    /// <see href="https://schema.org/VirtualRecordingDigitalSource"></see></summary>
    let VirtualRecordingDigitalSource = _prefix "VirtualRecordingDigitalSource"
    /// <summary>
    /// Pathogenic virus that causes viral infection.
    /// <see href="https://schema.org/Virus"></see></summary>
    let Virus = _prefix "Virus"
    /// <summary>
    /// Event type: Visual arts event.
    /// <see href="https://schema.org/VisualArtsEvent"></see></summary>
    let VisualArtsEvent = _prefix "VisualArtsEvent"
    /// <summary>
    /// Vital signs are measures of various physiological functions in order to assess the most basic body functions.
    /// <see href="https://schema.org/VitalSign"></see></summary>
    let VitalSign = _prefix "VitalSign"
    /// <summary>
    /// A volcano, like Fujisan.
    /// <see href="https://schema.org/Volcano"></see></summary>
    let Volcano = _prefix "Volcano"
    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// <see href="https://schema.org/VoteAction"></see></summary>
    let VoteAction = _prefix "VoteAction"
    /// <summary>
    /// An advertising section of the page.
    /// <see href="https://schema.org/WPAdBlock"></see></summary>
    let WPAdBlock = _prefix "WPAdBlock"
    /// <summary>
    /// The footer section of the page.
    /// <see href="https://schema.org/WPFooter"></see></summary>
    let WPFooter = _prefix "WPFooter"
    /// <summary>
    /// The header section of the page.
    /// <see href="https://schema.org/WPHeader"></see></summary>
    let WPHeader = _prefix "WPHeader"
    /// <summary>
    /// A sidebar section of the page.
    /// <see href="https://schema.org/WPSideBar"></see></summary>
    let WPSideBar = _prefix "WPSideBar"
    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// <see href="https://schema.org/WantAction"></see></summary>
    let WantAction = _prefix "WantAction"
    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// <see href="https://schema.org/WarrantyPromise"></see></summary>
    let WarrantyPromise = _prefix "WarrantyPromise"
    /// <summary>
    /// A range of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.\n\nCommonly used values:\n\n* http://purl.org/goodrelations/v1#Labor-BringIn\n* http://purl.org/goodrelations/v1#PartsAndLabor-BringIn\n* http://purl.org/goodrelations/v1#PartsAndLabor-PickUp
    ///
    /// <see href="https://schema.org/WarrantyScope"></see></summary>
    let WarrantyScope = _prefix "WarrantyScope"
    /// <summary>
    /// The act of consuming dynamic/moving visual content.
    /// <see href="https://schema.org/WatchAction"></see></summary>
    let WatchAction = _prefix "WatchAction"
    /// <summary>
    /// A waterfall, like Niagara.
    /// <see href="https://schema.org/Waterfall"></see></summary>
    let Waterfall = _prefix "Waterfall"
    /// <summary>
    /// The item is intended to induce bodily harm, for example guns, mace, combat knives, brass knuckles, nail or other bombs, and spears.
    /// <see href="https://schema.org/WeaponConsideration"></see></summary>
    let WeaponConsideration = _prefix "WeaponConsideration"
    /// <summary>
    /// The act of dressing oneself in clothing.
    /// <see href="https://schema.org/WearAction"></see></summary>
    let WearAction = _prefix "WearAction"
    /// <summary>
    /// Measurement of the back section, for example of a jacket.
    /// <see href="https://schema.org/WearableMeasurementBack"></see></summary>
    let WearableMeasurementBack = _prefix "WearableMeasurementBack"

    /// <summary>
    /// Enumerates common types of measurement for wearables products.
    /// <see href="https://schema.org/WearableMeasurementTypeEnumeration"></see></summary>
    let WearableMeasurementTypeEnumeration =
        _prefix "WearableMeasurementTypeEnumeration"

    /// <summary>
    /// Measurement of the chest/bust section, for example of a suit.
    /// <see href="https://schema.org/WearableMeasurementChestOrBust"></see></summary>
    let WearableMeasurementChestOrBust = _prefix "WearableMeasurementChestOrBust"
    /// <summary>
    /// Measurement of the collar, for example of a shirt.
    /// <see href="https://schema.org/WearableMeasurementCollar"></see></summary>
    let WearableMeasurementCollar = _prefix "WearableMeasurementCollar"
    /// <summary>
    /// Measurement of the cup, for example of a bra.
    /// <see href="https://schema.org/WearableMeasurementCup"></see></summary>
    let WearableMeasurementCup = _prefix "WearableMeasurementCup"
    /// <summary>
    /// Measurement of the height, for example the heel height of a shoe.
    /// <see href="https://schema.org/WearableMeasurementHeight"></see></summary>
    let WearableMeasurementHeight = _prefix "WearableMeasurementHeight"
    /// <summary>
    /// Measurement of the hip section, for example of a skirt.
    /// <see href="https://schema.org/WearableMeasurementHips"></see></summary>
    let WearableMeasurementHips = _prefix "WearableMeasurementHips"
    /// <summary>
    /// Measurement of the inseam, for example of pants.
    /// <see href="https://schema.org/WearableMeasurementInseam"></see></summary>
    let WearableMeasurementInseam = _prefix "WearableMeasurementInseam"
    /// <summary>
    /// Represents the length, for example of a dress.
    /// <see href="https://schema.org/WearableMeasurementLength"></see></summary>
    let WearableMeasurementLength = _prefix "WearableMeasurementLength"
    /// <summary>
    /// Measurement of the outside leg, for example of pants.
    /// <see href="https://schema.org/WearableMeasurementOutsideLeg"></see></summary>
    let WearableMeasurementOutsideLeg = _prefix "WearableMeasurementOutsideLeg"
    /// <summary>
    /// Measurement of the sleeve length, for example of a shirt.
    /// <see href="https://schema.org/WearableMeasurementSleeve"></see></summary>
    let WearableMeasurementSleeve = _prefix "WearableMeasurementSleeve"
    /// <summary>
    /// Measurement of the waist section, for example of pants.
    /// <see href="https://schema.org/WearableMeasurementWaist"></see></summary>
    let WearableMeasurementWaist = _prefix "WearableMeasurementWaist"
    /// <summary>
    /// Measurement of the width, for example of shoes.
    /// <see href="https://schema.org/WearableMeasurementWidth"></see></summary>
    let WearableMeasurementWidth = _prefix "WearableMeasurementWidth"
    /// <summary>
    /// Size group "Big" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupBig"></see></summary>
    let WearableSizeGroupBig = _prefix "WearableSizeGroupBig"
    /// <summary>
    /// Enumerates common size groups (also known as "size types") for wearable products.
    /// <see href="https://schema.org/WearableSizeGroupEnumeration"></see></summary>
    let WearableSizeGroupEnumeration = _prefix "WearableSizeGroupEnumeration"
    /// <summary>
    /// Size group "Boys" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupBoys"></see></summary>
    let WearableSizeGroupBoys = _prefix "WearableSizeGroupBoys"
    /// <summary>
    /// Size group "Extra Short" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupExtraShort"></see></summary>
    let WearableSizeGroupExtraShort = _prefix "WearableSizeGroupExtraShort"
    /// <summary>
    /// Size group "Extra Tall" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupExtraTall"></see></summary>
    let WearableSizeGroupExtraTall = _prefix "WearableSizeGroupExtraTall"
    /// <summary>
    /// Size group "Girls" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupGirls"></see></summary>
    let WearableSizeGroupGirls = _prefix "WearableSizeGroupGirls"
    /// <summary>
    /// Size group "Husky" (or "Stocky") for wearables.
    /// <see href="https://schema.org/WearableSizeGroupHusky"></see></summary>
    let WearableSizeGroupHusky = _prefix "WearableSizeGroupHusky"
    /// <summary>
    /// Size group "Infants" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupInfants"></see></summary>
    let WearableSizeGroupInfants = _prefix "WearableSizeGroupInfants"
    /// <summary>
    /// Size group "Juniors" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupJuniors"></see></summary>
    let WearableSizeGroupJuniors = _prefix "WearableSizeGroupJuniors"
    /// <summary>
    /// Size group "Maternity" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupMaternity"></see></summary>
    let WearableSizeGroupMaternity = _prefix "WearableSizeGroupMaternity"
    /// <summary>
    /// Size group "Mens" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupMens"></see></summary>
    let WearableSizeGroupMens = _prefix "WearableSizeGroupMens"
    /// <summary>
    /// Size group "Misses" (also known as "Missy") for wearables.
    /// <see href="https://schema.org/WearableSizeGroupMisses"></see></summary>
    let WearableSizeGroupMisses = _prefix "WearableSizeGroupMisses"
    /// <summary>
    /// Size group "Petite" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupPetite"></see></summary>
    let WearableSizeGroupPetite = _prefix "WearableSizeGroupPetite"
    /// <summary>
    /// Size group "Plus" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupPlus"></see></summary>
    let WearableSizeGroupPlus = _prefix "WearableSizeGroupPlus"
    /// <summary>
    /// Size group "Regular" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupRegular"></see></summary>
    let WearableSizeGroupRegular = _prefix "WearableSizeGroupRegular"
    /// <summary>
    /// Size group "Short" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupShort"></see></summary>
    let WearableSizeGroupShort = _prefix "WearableSizeGroupShort"
    /// <summary>
    /// Size group "Tall" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupTall"></see></summary>
    let WearableSizeGroupTall = _prefix "WearableSizeGroupTall"
    /// <summary>
    /// Size group "Womens" for wearables.
    /// <see href="https://schema.org/WearableSizeGroupWomens"></see></summary>
    let WearableSizeGroupWomens = _prefix "WearableSizeGroupWomens"
    /// <summary>
    /// Australian size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemAU"></see></summary>
    let WearableSizeSystemAU = _prefix "WearableSizeSystemAU"
    /// <summary>
    /// Enumerates common size systems specific for wearable products.
    /// <see href="https://schema.org/WearableSizeSystemEnumeration"></see></summary>
    let WearableSizeSystemEnumeration = _prefix "WearableSizeSystemEnumeration"
    /// <summary>
    /// Brazilian size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemBR"></see></summary>
    let WearableSizeSystemBR = _prefix "WearableSizeSystemBR"
    /// <summary>
    /// Chinese size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemCN"></see></summary>
    let WearableSizeSystemCN = _prefix "WearableSizeSystemCN"
    /// <summary>
    /// Continental size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemContinental"></see></summary>
    let WearableSizeSystemContinental = _prefix "WearableSizeSystemContinental"
    /// <summary>
    /// German size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemDE"></see></summary>
    let WearableSizeSystemDE = _prefix "WearableSizeSystemDE"
    /// <summary>
    /// EN 13402 (joint European standard for size labelling of clothes).
    /// <see href="https://schema.org/WearableSizeSystemEN13402"></see></summary>
    let WearableSizeSystemEN13402 = _prefix "WearableSizeSystemEN13402"
    /// <summary>
    /// European size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemEurope"></see></summary>
    let WearableSizeSystemEurope = _prefix "WearableSizeSystemEurope"
    /// <summary>
    /// French size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemFR"></see></summary>
    let WearableSizeSystemFR = _prefix "WearableSizeSystemFR"
    /// <summary>
    /// GS1 (formerly NRF) size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemGS1"></see></summary>
    let WearableSizeSystemGS1 = _prefix "WearableSizeSystemGS1"
    /// <summary>
    /// Italian size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemIT"></see></summary>
    let WearableSizeSystemIT = _prefix "WearableSizeSystemIT"
    /// <summary>
    /// Japanese size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemJP"></see></summary>
    let WearableSizeSystemJP = _prefix "WearableSizeSystemJP"
    /// <summary>
    /// Mexican size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemMX"></see></summary>
    let WearableSizeSystemMX = _prefix "WearableSizeSystemMX"
    /// <summary>
    /// United Kingdom size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemUK"></see></summary>
    let WearableSizeSystemUK = _prefix "WearableSizeSystemUK"
    /// <summary>
    /// United States size system for wearables.
    /// <see href="https://schema.org/WearableSizeSystemUS"></see></summary>
    let WearableSizeSystemUS = _prefix "WearableSizeSystemUS"
    /// <summary>
    /// An application programming interface accessible over Web/Internet technologies.
    /// <see href="https://schema.org/WebAPI"></see></summary>
    let WebAPI = _prefix "WebAPI"
    /// <summary>
    /// Web applications.
    /// <see href="https://schema.org/WebApplication"></see></summary>
    let WebApplication = _prefix "WebApplication"
    /// <summary>
    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    /// <see href="https://schema.org/WebSite"></see></summary>
    let WebSite = _prefix "WebSite"
    /// <summary>
    /// The day of the week between Tuesday and Thursday.
    /// <see href="https://schema.org/Wednesday"></see></summary>
    let Wednesday = _prefix "Wednesday"
    /// <summary>
    /// The conventional Western system of medicine, that aims to apply the best available evidence gained from the scientific method to clinical decision making. Also known as conventional or Western medicine.
    /// <see href="https://schema.org/WesternConventional"></see></summary>
    let WesternConventional = _prefix "WesternConventional"
    /// <summary>
    /// The drug's cost represents the wholesale acquisition cost of the drug.
    /// <see href="https://schema.org/Wholesale"></see></summary>
    let Wholesale = _prefix "Wholesale"
    /// <summary>
    /// A wholesale store.
    /// <see href="https://schema.org/WholesaleStore"></see></summary>
    let WholesaleStore = _prefix "WholesaleStore"
    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// <see href="https://schema.org/WinAction"></see></summary>
    let WinAction = _prefix "WinAction"
    /// <summary>
    /// A winery.
    /// <see href="https://schema.org/Winery"></see></summary>
    let Winery = _prefix "Winery"
    /// <summary>
    /// Withdrawn.
    /// <see href="https://schema.org/Withdrawn"></see></summary>
    let Withdrawn = _prefix "Withdrawn"
    /// <summary>
    /// A program with both an educational and employment component. Typically based at a workplace and structured around work-based learning, with the aim of instilling competencies related to an occupation. WorkBasedProgram is used to distinguish programs such as apprenticeships from school, college or other classroom based educational programs.
    /// <see href="https://schema.org/WorkBasedProgram"></see></summary>
    let WorkBasedProgram = _prefix "WorkBasedProgram"
    /// <summary>
    /// A Workers Union (also known as a Labor Union, Labour Union, or Trade Union) is an organization that promotes the interests of its worker members by collectively bargaining with management, organizing, and political lobbying.
    /// <see href="https://schema.org/WorkersUnion"></see></summary>
    let WorkersUnion = _prefix "WorkersUnion"
    /// <summary>
    /// The act of authoring written creative content.
    /// <see href="https://schema.org/WriteAction"></see></summary>
    let WriteAction = _prefix "WriteAction"
    /// <summary>
    /// Permission to write or edit the document.
    /// <see href="https://schema.org/WritePermission"></see></summary>
    let WritePermission = _prefix "WritePermission"
    /// <summary>
    /// Text representing an XPath (typically but not necessarily version 1.0).
    /// <see href="https://schema.org/XPathType"></see></summary>
    let XPathType = _prefix "XPathType"
    /// <summary>
    /// X-ray imaging.
    /// <see href="https://schema.org/XRay"></see></summary>
    let XRay = _prefix "XRay"
    /// <summary>
    /// The airline boards by zones of the plane.
    /// <see href="https://schema.org/ZoneBoardingPolicy"></see></summary>
    let ZoneBoardingPolicy = _prefix "ZoneBoardingPolicy"
    /// <summary>
    /// A zoo.
    /// <see href="https://schema.org/Zoo"></see></summary>
    let Zoo = _prefix "Zoo"
    /// <summary>
    /// The subject matter of an object.
    /// <see href="https://schema.org/about"></see></summary>
    let about = _prefix "about"
    /// <summary>
    /// Relates a property to a class that is (one of) the type(s) the property is expected to be used on.
    /// <see href="https://schema.org/domainIncludes"></see></summary>
    let domainIncludes = _prefix "domainIncludes"
    /// <summary>
    /// Relates a property to a property that is its inverse. Inverse properties relate the same pairs of items to each other, but in reversed direction. For example, the 'alumni' and 'alumniOf' properties are inverseOf each other. Some properties don't have explicit inverses; in these situations RDFa and JSON-LD syntax for reverse properties can be used.
    /// <see href="https://schema.org/inverseOf"></see></summary>
    let inverseOf = _prefix "inverseOf"
    /// <summary>
    /// A CreativeWork or Event about this Thing.
    /// <see href="https://schema.org/subjectOf"></see></summary>
    let subjectOf = _prefix "subjectOf"
    /// <summary>
    /// Relates a property to a class that constitutes (one of) the expected type(s) for values of the property.
    /// <see href="https://schema.org/rangeIncludes"></see></summary>
    let rangeIncludes = _prefix "rangeIncludes"
    /// <summary>
    /// Indicates whether the book is an abridged edition.
    /// <see href="https://schema.org/abridged"></see></summary>
    let abridged = _prefix "abridged"
    /// <summary>
    /// An abstract is a short description that summarizes a [[CreativeWork]].
    /// <see href="https://schema.org/abstract"></see></summary>
    let abstract_ = _prefix "abstract"
    /// <summary>
    /// The time needed to accelerate the vehicle from a given start velocity to a given target velocity.\n\nTypical unit code(s): SEC for seconds\n\n* Note: There are unfortunately no standard unit codes for seconds/0..100 km/h or seconds/0..60 mph. Simply use "SEC" for seconds and indicate the velocities in the [[name]] of the [[QuantitativeValue]], or use [[valueReference]] with a [[QuantitativeValue]] of 0..60 mph or 0..100 km/h to specify the reference speeds.
    /// <see href="https://schema.org/accelerationTime"></see></summary>
    let accelerationTime = _prefix "accelerationTime"
    /// <summary>
    /// The answer(s) that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
    /// <see href="https://schema.org/acceptedAnswer"></see></summary>
    let acceptedAnswer = _prefix "acceptedAnswer"
    /// <summary>
    /// An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
    /// <see href="https://schema.org/suggestedAnswer"></see></summary>
    let suggestedAnswer = _prefix "suggestedAnswer"
    /// <summary>
    /// The offer(s) -- e.g., product, quantity and price combinations -- included in the order.
    /// <see href="https://schema.org/acceptedOffer"></see></summary>
    let acceptedOffer = _prefix "acceptedOffer"
    /// <summary>
    /// The payment method(s) that are accepted in general by an organization, or for some specific demand or offer.
    /// <see href="https://schema.org/acceptedPaymentMethod"></see></summary>
    let acceptedPaymentMethod = _prefix "acceptedPaymentMethod"
    /// <summary>
    /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings ```Yes``` or ```No```.
    /// <see href="https://schema.org/acceptsReservations"></see></summary>
    let acceptsReservations = _prefix "acceptsReservations"
    /// <summary>
    /// Password, PIN, or access code needed for delivery (e.g. from a locker).
    /// <see href="https://schema.org/accessCode"></see></summary>
    let accessCode = _prefix "accessCode"
    /// <summary>
    /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive the intellectual content of a resource, not including any adaptations of the content (e.g., text alternatives for images). Values should be drawn from the [approved vocabulary](https://www.w3.org/2021/a11y-discov-vocab/latest/#accessMode-vocabulary).
    /// <see href="https://schema.org/accessMode"></see></summary>
    let accessMode = _prefix "accessMode"
    /// <summary>
    /// A list of single or combined access modes that are sufficient to understand all the intellectual content of a resource, including any adaptations. Values should be drawn from the [approved vocabulary](https://www.w3.org/2021/a11y-discov-vocab/latest/#accessModeSufficient-vocabulary).
    /// <see href="https://schema.org/accessModeSufficient"></see></summary>
    let accessModeSufficient = _prefix "accessModeSufficient"
    /// <summary>
    /// Indicates that the resource is compatible with the referenced accessibility API. Values should be drawn from the [approved vocabulary](https://www.w3.org/2021/a11y-discov-vocab/latest/#accessibilityAPI-vocabulary).
    /// <see href="https://schema.org/accessibilityAPI"></see></summary>
    let accessibilityAPI = _prefix "accessibilityAPI"
    /// <summary>
    /// Identifies input methods that are sufficient to fully control the described resource. Values should be drawn from the [approved vocabulary](https://www.w3.org/2021/a11y-discov-vocab/latest/#accessibilityControl-vocabulary).
    /// <see href="https://schema.org/accessibilityControl"></see></summary>
    let accessibilityControl = _prefix "accessibilityControl"
    /// <summary>
    /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility. Values should be drawn from the [approved vocabulary](https://www.w3.org/2021/a11y-discov-vocab/latest/#accessibilityFeature-vocabulary).
    /// <see href="https://schema.org/accessibilityFeature"></see></summary>
    let accessibilityFeature = _prefix "accessibilityFeature"
    /// <summary>
    /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3. Values should be drawn from the [approved vocabulary](https://www.w3.org/2021/a11y-discov-vocab/latest/#accessibilityHazard-vocabulary).
    /// <see href="https://schema.org/accessibilityHazard"></see></summary>
    let accessibilityHazard = _prefix "accessibilityHazard"
    /// <summary>
    /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed".
    /// <see href="https://schema.org/accessibilitySummary"></see></summary>
    let accessibilitySummary = _prefix "accessibilitySummary"
    /// <summary>
    /// Category of an [[Accommodation]], following real estate conventions, e.g. RESO (see [PropertySubType](https://ddwiki.reso.org/display/DDW17/PropertySubType+Field), and [PropertyType](https://ddwiki.reso.org/display/DDW17/PropertyType+Field) fields  for suggested values).
    /// <see href="https://schema.org/accommodationCategory"></see></summary>
    let accommodationCategory = _prefix "accommodationCategory"
    /// <summary>
    /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
    /// <see href="https://schema.org/category"></see></summary>
    let category = _prefix "category"
    /// <summary>
    /// A floorplan of some [[Accommodation]].
    /// <see href="https://schema.org/accommodationFloorPlan"></see></summary>
    let accommodationFloorPlan = _prefix "accommodationFloorPlan"
    /// <summary>
    /// The identifier for the account the payment will be applied to.
    /// <see href="https://schema.org/accountId"></see></summary>
    let accountId = _prefix "accountId"
    /// <summary>
    /// The identifier property represents any kind of identifier for any kind of [[Thing]], such as ISBNs, GTIN codes, UUIDs etc. Schema.org provides dedicated properties for representing many of these, either as textual strings or as URL (URI) links. See [background notes](/docs/datamodel.html#identifierBg) for more details.
    ///
    /// <see href="https://schema.org/identifier"></see></summary>
    let identifier = _prefix "identifier"
    /// <summary>
    /// A minimum amount that has to be paid in every month.
    /// <see href="https://schema.org/accountMinimumInflow"></see></summary>
    let accountMinimumInflow = _prefix "accountMinimumInflow"
    /// <summary>
    /// An overdraft is an extension of credit from a lending institution when an account reaches zero. An overdraft allows the individual to continue withdrawing money even if the account has no funds in it. Basically the bank allows people to borrow a set amount of money.
    /// <see href="https://schema.org/accountOverdraftLimit"></see></summary>
    let accountOverdraftLimit = _prefix "accountOverdraftLimit"
    /// <summary>
    /// Specifies the Person that is legally accountable for the CreativeWork.
    /// <see href="https://schema.org/accountablePerson"></see></summary>
    let accountablePerson = _prefix "accountablePerson"
    /// <summary>
    /// Indicates a page documenting how licenses can be purchased or otherwise acquired, for the current item.
    /// <see href="https://schema.org/acquireLicensePage"></see></summary>
    let acquireLicensePage = _prefix "acquireLicensePage"
    /// <summary>
    /// The schema.org [[usageInfo]] property indicates further information about a [[CreativeWork]]. This property is applicable both to works that are freely available and to those that require payment or other transactions. It can reference additional information, e.g. community expectations on preferred linking and citation conventions, as well as purchasing details. For something that can be commercially licensed, usageInfo can provide detailed, resource-specific information about licensing options.
    ///
    /// This property can be used alongside the license property which indicates license(s) applicable to some piece of content. The usageInfo property can provide information about other licensing options, e.g. acquiring commercial usage rights for an image that is also available under non-commercial creative commons licenses.
    /// <see href="https://schema.org/usageInfo"></see></summary>
    let usageInfo = _prefix "usageInfo"
    /// <summary>
    /// The organization or person from which the product was acquired.
    /// <see href="https://schema.org/acquiredFrom"></see></summary>
    let acquiredFrom = _prefix "acquiredFrom"
    /// <summary>
    /// The ACRISS Car Classification Code is a code used by many car rental companies, for classifying vehicles. ACRISS stands for Association of Car Rental Industry Systems and Standards.
    /// <see href="https://schema.org/acrissCode"></see></summary>
    let acrissCode = _prefix "acrissCode"
    /// <summary>
    /// A set of requirements that must be fulfilled in order to perform an Action. If more than one value is specified, fulfilling one set of requirements will allow the Action to be performed.
    /// <see href="https://schema.org/actionAccessibilityRequirement"></see></summary>
    let actionAccessibilityRequirement = _prefix "actionAccessibilityRequirement"
    /// <summary>
    /// An application that can complete the request.
    /// <see href="https://schema.org/actionApplication"></see></summary>
    let actionApplication = _prefix "actionApplication"
    /// <summary>
    /// A sub property of object. The options subject to this action.
    /// <see href="https://schema.org/actionOption"></see></summary>
    let actionOption = _prefix "actionOption"
    /// <summary>
    /// The object upon which the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). E.g. John read *a book*.
    /// <see href="https://schema.org/object"></see></summary>
    let object = _prefix "object"
    /// <summary>
    /// The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
    /// <see href="https://schema.org/actionPlatform"></see></summary>
    let actionPlatform = _prefix "actionPlatform"
    /// <summary>
    /// Description of the process by which the action was performed.
    /// <see href="https://schema.org/actionProcess"></see></summary>
    let actionProcess = _prefix "actionProcess"
    /// <summary>
    /// Indicates the current disposition of the Action.
    /// <see href="https://schema.org/actionStatus"></see></summary>
    let actionStatus = _prefix "actionStatus"
    /// <summary>
    /// For a [[NewsMediaOrganization]] or other news-related [[Organization]], a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
    /// <see href="https://schema.org/actionableFeedbackPolicy"></see></summary>
    let actionableFeedbackPolicy = _prefix "actionableFeedbackPolicy"
    /// <summary>
    /// The publishingPrinciples property indicates (typically via [[URL]]) a document describing the editorial principles of an [[Organization]] (or individual, e.g. a [[Person]] writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a [[CreativeWork]] (e.g. [[NewsArticle]]) the principles are those of the party primarily responsible for the creation of the [[CreativeWork]].
    ///
    /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a [[funder]]) can be expressed using schema.org terminology.
    ///
    /// <see href="https://schema.org/publishingPrinciples"></see></summary>
    let publishingPrinciples = _prefix "publishingPrinciples"
    /// <summary>
    /// An active ingredient, typically chemical compounds and/or biologic substances.
    /// <see href="https://schema.org/activeIngredient"></see></summary>
    let activeIngredient = _prefix "activeIngredient"
    /// <summary>
    /// Length of time to engage in the activity.
    /// <see href="https://schema.org/activityDuration"></see></summary>
    let activityDuration = _prefix "activityDuration"
    /// <summary>
    /// How often one should engage in the activity.
    /// <see href="https://schema.org/activityFrequency"></see></summary>
    let activityFrequency = _prefix "activityFrequency"
    /// <summary>
    /// An actor (individual or a group), e.g. in TV, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
    /// <see href="https://schema.org/actor"></see></summary>
    let actor = _prefix "actor"
    /// <summary>
    /// An actor, e.g. in TV, radio, movie, video games etc. Actors can be associated with individual items or with a series, episode, clip.
    /// <see href="https://schema.org/actors"></see></summary>
    let actors = _prefix "actors"
    /// <summary>
    /// An additional offer that can only be obtained in combination with the first base offer (e.g. supplements and extensions that are available for a surcharge).
    /// <see href="https://schema.org/addOn"></see></summary>
    let addOn = _prefix "addOn"
    /// <summary>
    /// An additional name for a Person, can be used for a middle name.
    /// <see href="https://schema.org/additionalName"></see></summary>
    let additionalName = _prefix "additionalName"
    /// <summary>
    /// An alias for the item.
    /// <see href="https://schema.org/alternateName"></see></summary>
    let alternateName = _prefix "alternateName"
    /// <summary>
    /// If responding yes, the number of guests who will attend in addition to the invitee.
    /// <see href="https://schema.org/additionalNumberOfGuests"></see></summary>
    let additionalNumberOfGuests = _prefix "additionalNumberOfGuests"
    /// <summary>
    /// A property-value pair representing an additional characteristic of the entity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.\n\nNote: Publishers should be aware that applications designed to use specific schema.org properties (e.g. https://schema.org/width, https://schema.org/color, https://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
    ///
    /// <see href="https://schema.org/additionalProperty"></see></summary>
    let additionalProperty = _prefix "additionalProperty"
    /// <summary>
    /// An additional type for the item, typically used for adding more specific types from external vocabularies in microdata syntax. This is a relationship between something and a class that the thing is in. Typically the value is a URI-identified RDF class, and in this case corresponds to the
    ///     use of rdf:type in RDF. Text values can be used sparingly, for cases where useful information can be added without their being an appropriate schema to reference. In the case of text values, the class label should follow the schema.org &lt;a href="https://schema.org/docs/styleguide.html"&gt;style guide&lt;/a&gt;.
    /// <see href="https://schema.org/additionalType"></see></summary>
    let additionalType = _prefix "additionalType"
    /// <summary>
    /// Any additional component of the exercise prescription that may need to be articulated to the patient. This may include the order of exercises, the number of repetitions of movement, quantitative distance, progressions over time, etc.
    /// <see href="https://schema.org/additionalVariable"></see></summary>
    let additionalVariable = _prefix "additionalVariable"
    /// <summary>
    /// Physical address of the item.
    /// <see href="https://schema.org/address"></see></summary>
    let address = _prefix "address"
    /// <summary>
    /// The country. Recommended to be in 2-letter [ISO 3166-1 alpha-2](http://en.wikipedia.org/wiki/ISO_3166-1) format, for example "US". For backward compatibility, a 3-letter [ISO 3166-1 alpha-3](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) country code such as "SGP" or a full country name such as "Singapore" can also be used.
    /// <see href="https://schema.org/addressCountry"></see></summary>
    let addressCountry = _prefix "addressCountry"
    /// <summary>
    /// The locality in which the street address is, and which is in the region. For example, Mountain View.
    /// <see href="https://schema.org/addressLocality"></see></summary>
    let addressLocality = _prefix "addressLocality"
    /// <summary>
    /// The region in which the locality is, and which is in the country. For example, California or another appropriate first-level [Administrative division](https://en.wikipedia.org/wiki/List_of_administrative_divisions_by_country) such as the Province in Italy or Region in Germany.
    /// <see href="https://schema.org/addressRegion"></see></summary>
    let addressRegion = _prefix "addressRegion"
    /// <summary>
    /// A route by which this drug may be administered, e.g. 'oral'.
    /// <see href="https://schema.org/administrationRoute"></see></summary>
    let administrationRoute = _prefix "administrationRoute"
    /// <summary>
    /// The amount of time that is required between accepting the offer and the actual usage of the resource or service.
    /// <see href="https://schema.org/advanceBookingRequirement"></see></summary>
    let advanceBookingRequirement = _prefix "advanceBookingRequirement"
    /// <summary>
    /// A possible complication and/or side effect of this therapy. If it is known that an adverse outcome is serious (resulting in death, disability, or permanent damage; requiring hospitalization; or otherwise life-threatening or requiring immediate medical attention), tag it as a seriousAdverseOutcome instead.
    /// <see href="https://schema.org/adverseOutcome"></see></summary>
    let adverseOutcome = _prefix "adverseOutcome"
    /// <summary>
    /// Drugs that affect the test's results.
    /// <see href="https://schema.org/affectedBy"></see></summary>
    let affectedBy = _prefix "affectedBy"
    /// <summary>
    /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
    /// <see href="https://schema.org/affiliation"></see></summary>
    let affiliation = _prefix "affiliation"
    /// <summary>
    /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
    /// <see href="https://schema.org/memberOf"></see></summary>
    let memberOf = _prefix "memberOf"
    /// <summary>
    /// A media object representing the circumstances after performing this direction.
    /// <see href="https://schema.org/afterMedia"></see></summary>
    let afterMedia = _prefix "afterMedia"
    /// <summary>
    /// The direct performer or driver of the action (animate or inanimate). E.g. *John* wrote a book.
    /// <see href="https://schema.org/agent"></see></summary>
    let agent = _prefix "agent"
    /// <summary>
    /// The number of completed interactions for this entity, in a particular role (the 'agent'), in a particular action (indicated in the statistic), and in a particular context (i.e. interactionService).
    /// <see href="https://schema.org/agentInteractionStatistic"></see></summary>
    let agentInteractionStatistic = _prefix "agentInteractionStatistic"
    /// <summary>
    /// Indicates a prototype of the elements in the list that is used to hold aggregate information (ratings, offers, etc.).
    /// <see href="https://schema.org/aggregateElement"></see></summary>
    let aggregateElement = _prefix "aggregateElement"
    /// <summary>
    /// The overall rating, based on a collection of reviews or ratings, of the item.
    /// <see href="https://schema.org/aggregateRating"></see></summary>
    let aggregateRating = _prefix "aggregateRating"
    /// <summary>
    /// The kind of aircraft (e.g., "Boeing 747").
    /// <see href="https://schema.org/aircraft"></see></summary>
    let aircraft = _prefix "aircraft"
    /// <summary>
    /// A music album.
    /// <see href="https://schema.org/album"></see></summary>
    let album = _prefix "album"
    /// <summary>
    /// Classification of the album by its type of content: soundtrack, live album, studio album, etc.
    /// <see href="https://schema.org/albumProductionType"></see></summary>
    let albumProductionType = _prefix "albumProductionType"
    /// <summary>
    /// A release of this album.
    /// <see href="https://schema.org/albumRelease"></see></summary>
    let albumRelease = _prefix "albumRelease"
    /// <summary>
    /// The album this is a release of.
    /// <see href="https://schema.org/releaseOf"></see></summary>
    let releaseOf = _prefix "releaseOf"
    /// <summary>
    /// The kind of release which this album is: single, EP or album.
    /// <see href="https://schema.org/albumReleaseType"></see></summary>
    let albumReleaseType = _prefix "albumReleaseType"
    /// <summary>
    /// A collection of music albums.
    /// <see href="https://schema.org/albums"></see></summary>
    let albums = _prefix "albums"
    /// <summary>
    /// Any precaution, guidance, contraindication, etc. related to consumption of alcohol while taking this drug.
    /// <see href="https://schema.org/alcoholWarning"></see></summary>
    let alcoholWarning = _prefix "alcoholWarning"
    /// <summary>
    /// The algorithm or rules to follow to compute the score.
    /// <see href="https://schema.org/algorithm"></see></summary>
    let algorithm = _prefix "algorithm"
    /// <summary>
    /// A category of alignment between the learning resource and the framework node. Recommended values include: 'requires', 'textComplexity', 'readingLevel', and 'educationalSubject'.
    /// <see href="https://schema.org/alignmentType"></see></summary>
    let alignmentType = _prefix "alignmentType"
    /// <summary>
    /// A secondary title of the CreativeWork.
    /// <see href="https://schema.org/alternativeHeadline"></see></summary>
    let alternativeHeadline = _prefix "alternativeHeadline"
    /// <summary>
    /// Another gene which is a variation of this one.
    /// <see href="https://schema.org/alternativeOf"></see></summary>
    let alternativeOf = _prefix "alternativeOf"
    /// <summary>
    /// Alumni of an organization.
    /// <see href="https://schema.org/alumni"></see></summary>
    let alumni = _prefix "alumni"
    /// <summary>
    /// An organization that the person is an alumni of.
    /// <see href="https://schema.org/alumniOf"></see></summary>
    let alumniOf = _prefix "alumniOf"
    /// <summary>
    /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
    /// <see href="https://schema.org/amenityFeature"></see></summary>
    let amenityFeature = _prefix "amenityFeature"
    /// <summary>
    /// The amount of money.
    /// <see href="https://schema.org/amount"></see></summary>
    let amount = _prefix "amount"
    /// <summary>
    /// The quantity of the goods included in the offer.
    /// <see href="https://schema.org/amountOfThisGood"></see></summary>
    let amountOfThisGood = _prefix "amountOfThisGood"
    /// <summary>
    /// Indicates a specific [[CivicStructure]] or [[LocalBusiness]] associated with the SpecialAnnouncement. For example, a specific testing facility or business with special opening hours. For a larger geographic region like a quarantine of an entire region, use [[spatialCoverage]].
    /// <see href="https://schema.org/announcementLocation"></see></summary>
    let announcementLocation = _prefix "announcementLocation"
    /// <summary>
    /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
    ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
    ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
    /// <see href="https://schema.org/spatialCoverage"></see></summary>
    let spatialCoverage = _prefix "spatialCoverage"
    /// <summary>
    /// The annual rate that is charged for borrowing (or made by investing), expressed as a single percentage number that represents the actual yearly cost of funds over the term of a loan. This includes any fees or additional costs associated with the transaction.
    /// <see href="https://schema.org/annualPercentageRate"></see></summary>
    let annualPercentageRate = _prefix "annualPercentageRate"
    /// <summary>
    /// The number of answers this question has received.
    /// <see href="https://schema.org/answerCount"></see></summary>
    let answerCount = _prefix "answerCount"
    /// <summary>
    /// A step-by-step or full explanation about Answer. Can outline how this Answer was achieved or contain more broad clarification or statement about it.
    /// <see href="https://schema.org/answerExplanation"></see></summary>
    let answerExplanation = _prefix "answerExplanation"
    /// <summary>
    /// The muscle whose action counteracts the specified muscle.
    /// <see href="https://schema.org/antagonist"></see></summary>
    let antagonist = _prefix "antagonist"
    /// <summary>
    /// Indicates an occurrence of a [[Claim]] in some [[CreativeWork]].
    /// <see href="https://schema.org/appearance"></see></summary>
    let appearance = _prefix "appearance"
    /// <summary>
    /// Example/instance/realization/derivation of the concept of this creative work. E.g. the paperback edition, first edition, or e-book.
    /// <see href="https://schema.org/workExample"></see></summary>
    let workExample = _prefix "workExample"
    /// <summary>
    /// A country where a particular merchant return policy applies to, for example the two-letter ISO 3166-1 alpha-2 country code.
    /// <see href="https://schema.org/applicableCountry"></see></summary>
    let applicableCountry = _prefix "applicableCountry"
    /// <summary>
    /// The location in which the status applies.
    /// <see href="https://schema.org/applicableLocation"></see></summary>
    let applicableLocation = _prefix "applicableLocation"
    /// <summary>
    /// The location(s) applicants can apply from. This is usually used for telecommuting jobs where the applicant does not need to be in a physical office. Note: This should not be used for citizenship or work visa requirements.
    /// <see href="https://schema.org/applicantLocationRequirements"></see></summary>
    let applicantLocationRequirements = _prefix "applicantLocationRequirements"
    /// <summary>
    /// An application that can complete the request.
    /// <see href="https://schema.org/application"></see></summary>
    let application = _prefix "application"
    /// <summary>
    /// Type of software application, e.g. 'Game, Multimedia'.
    /// <see href="https://schema.org/applicationCategory"></see></summary>
    let applicationCategory = _prefix "applicationCategory"
    /// <summary>
    /// Contact details for further information relevant to this job posting.
    /// <see href="https://schema.org/applicationContact"></see></summary>
    let applicationContact = _prefix "applicationContact"
    /// <summary>
    /// The date on which the program stops collecting applications for the next enrollment cycle. Flexible application deadlines (for example, a program with rolling admissions) can be described in a textual string, rather than as a DateTime.
    /// <see href="https://schema.org/applicationDeadline"></see></summary>
    let applicationDeadline = _prefix "applicationDeadline"
    /// <summary>
    /// The date at which the program begins collecting applications for the next enrollment cycle.
    /// <see href="https://schema.org/applicationStartDate"></see></summary>
    let applicationStartDate = _prefix "applicationStartDate"
    /// <summary>
    /// Subcategory of the application, e.g. 'Arcade Game'.
    /// <see href="https://schema.org/applicationSubCategory"></see></summary>
    let applicationSubCategory = _prefix "applicationSubCategory"
    /// <summary>
    /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
    /// <see href="https://schema.org/applicationSuite"></see></summary>
    let applicationSuite = _prefix "applicationSuite"
    /// <summary>
    /// The delivery method(s) to which the delivery charge or payment charge specification applies.
    /// <see href="https://schema.org/appliesToDeliveryMethod"></see></summary>
    let appliesToDeliveryMethod = _prefix "appliesToDeliveryMethod"
    /// <summary>
    /// The payment method(s) to which the payment charge specification applies.
    /// <see href="https://schema.org/appliesToPaymentMethod"></see></summary>
    let appliesToPaymentMethod = _prefix "appliesToPaymentMethod"
    /// <summary>
    /// Collection, [fonds](https://en.wikipedia.org/wiki/Fonds), or item held, kept or maintained by an [[ArchiveOrganization]].
    /// <see href="https://schema.org/archiveHeld"></see></summary>
    let archiveHeld = _prefix "archiveHeld"
    /// <summary>
    /// [[ArchiveOrganization]] that holds, keeps or maintains the [[ArchiveComponent]].
    /// <see href="https://schema.org/holdingArchive"></see></summary>
    let holdingArchive = _prefix "holdingArchive"
    /// <summary>
    /// Indicates a page or other link involved in archival of a [[CreativeWork]]. In the case of [[MediaReview]], the items in a [[MediaReviewItem]] may often become inaccessible, but be archived by archival, journalistic, activist, or law enforcement organizations. In such cases, the referenced page may not directly publish the content.
    /// <see href="https://schema.org/archivedAt"></see></summary>
    let archivedAt = _prefix "archivedAt"
    /// <summary>
    /// The area within which users can expect to reach the broadcast service.
    /// <see href="https://schema.org/area"></see></summary>
    let area = _prefix "area"
    /// <summary>
    /// The geographic area where the service is provided.
    /// <see href="https://schema.org/serviceArea"></see></summary>
    let serviceArea = _prefix "serviceArea"
    /// <summary>
    /// The geographic area where a service or offered item is provided.
    /// <see href="https://schema.org/areaServed"></see></summary>
    let areaServed = _prefix "areaServed"
    /// <summary>
    /// The airport where the flight terminates.
    /// <see href="https://schema.org/arrivalAirport"></see></summary>
    let arrivalAirport = _prefix "arrivalAirport"
    /// <summary>
    /// The terminal or port from which the boat arrives.
    /// <see href="https://schema.org/arrivalBoatTerminal"></see></summary>
    let arrivalBoatTerminal = _prefix "arrivalBoatTerminal"
    /// <summary>
    /// The stop or station from which the bus arrives.
    /// <see href="https://schema.org/arrivalBusStop"></see></summary>
    let arrivalBusStop = _prefix "arrivalBusStop"
    /// <summary>
    /// Identifier of the flight's arrival gate.
    /// <see href="https://schema.org/arrivalGate"></see></summary>
    let arrivalGate = _prefix "arrivalGate"
    /// <summary>
    /// The platform where the train arrives.
    /// <see href="https://schema.org/arrivalPlatform"></see></summary>
    let arrivalPlatform = _prefix "arrivalPlatform"
    /// <summary>
    /// The station where the train trip ends.
    /// <see href="https://schema.org/arrivalStation"></see></summary>
    let arrivalStation = _prefix "arrivalStation"
    /// <summary>
    /// Identifier of the flight's arrival terminal.
    /// <see href="https://schema.org/arrivalTerminal"></see></summary>
    let arrivalTerminal = _prefix "arrivalTerminal"
    /// <summary>
    /// The expected arrival time.
    /// <see href="https://schema.org/arrivalTime"></see></summary>
    let arrivalTime = _prefix "arrivalTime"
    /// <summary>
    /// The number of copies when multiple copies of a piece of artwork are produced - e.g. for a limited edition of 20 prints, 'artEdition' refers to the total number of copies (in this example "20").
    /// <see href="https://schema.org/artEdition"></see></summary>
    let artEdition = _prefix "artEdition"
    /// <summary>
    /// The material used. (E.g. Oil, Watercolour, Acrylic, Linoprint, Marble, Cyanotype, Digital, Lithograph, DryPoint, Intaglio, Pastel, Woodcut, Pencil, Mixed Media, etc.)
    /// <see href="https://schema.org/artMedium"></see></summary>
    let artMedium = _prefix "artMedium"
    /// <summary>
    /// A material that something is made from, e.g. leather, wool, cotton, paper.
    /// <see href="https://schema.org/material"></see></summary>
    let material = _prefix "material"
    /// <summary>
    /// The branches that comprise the arterial structure.
    /// <see href="https://schema.org/arterialBranch"></see></summary>
    let arterialBranch = _prefix "arterialBranch"
    /// <summary>
    /// e.g. Painting, Drawing, Sculpture, Print, Photograph, Assemblage, Collage, etc.
    /// <see href="https://schema.org/artform"></see></summary>
    let artform = _prefix "artform"
    /// <summary>
    /// The actual body of the article.
    /// <see href="https://schema.org/articleBody"></see></summary>
    let articleBody = _prefix "articleBody"
    /// <summary>
    /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
    /// <see href="https://schema.org/articleSection"></see></summary>
    let articleSection = _prefix "articleSection"
    /// <summary>
    /// The primary artist for a work
    ///     	in a medium other than pencils or digital line art--for example, if the
    ///     	primary artwork is done in watercolors or digital paints.
    /// <see href="https://schema.org/artist"></see></summary>
    let artist = _prefix "artist"
    /// <summary>
    /// The supporting materials for the artwork, e.g. Canvas, Paper, Wood, Board, etc.
    /// <see href="https://schema.org/artworkSurface"></see></summary>
    let artworkSurface = _prefix "artworkSurface"
    /// <summary>
    /// An Amazon Standard Identification Number (ASIN) is a 10-character alphanumeric unique identifier assigned by Amazon.com and its partners for product identification within the Amazon organization (summary from [Wikipedia](https://en.wikipedia.org/wiki/Amazon_Standard_Identification_Number)'s article).
    ///
    /// Note also that this is a definition for how to include ASINs in Schema.org data, and not a definition of ASINs in general - see documentation from Amazon for authoritative details.
    /// ASINs are most commonly encoded as text strings, but the [asin] property supports URL/URI as potential values too.
    /// <see href="https://schema.org/asin"></see></summary>
    let asin = _prefix "asin"
    /// <summary>
    /// An aspect of medical practice that is considered on the page, such as 'diagnosis', 'treatment', 'causes', 'prognosis', 'etiology', 'epidemiology', etc.
    /// <see href="https://schema.org/aspect"></see></summary>
    let aspect = _prefix "aspect"
    /// <summary>
    /// Indicates if this web page element is the main subject of the page.
    /// <see href="https://schema.org/mainContentOfPage"></see></summary>
    let mainContentOfPage = _prefix "mainContentOfPage"
    /// <summary>
    /// Library file name, e.g., mscorlib.dll, system.web.dll.
    /// <see href="https://schema.org/assembly"></see></summary>
    let assembly = _prefix "assembly"
    /// <summary>
    /// Library file name, e.g., mscorlib.dll, system.web.dll.
    /// <see href="https://schema.org/executableLibraryName"></see></summary>
    let executableLibraryName = _prefix "executableLibraryName"
    /// <summary>
    /// Associated product/technology version. E.g., .NET Framework 4.5.
    /// <see href="https://schema.org/assemblyVersion"></see></summary>
    let assemblyVersion = _prefix "assemblyVersion"
    /// <summary>
    /// The item being described is intended to assess the competency or learning outcome defined by the referenced term.
    /// <see href="https://schema.org/assesses"></see></summary>
    let assesses = _prefix "assesses"
    /// <summary>
    /// The anatomy of the underlying organ system or structures associated with this entity.
    /// <see href="https://schema.org/associatedAnatomy"></see></summary>
    let associatedAnatomy = _prefix "associatedAnatomy"
    /// <summary>
    /// A NewsArticle associated with the Media Object.
    /// <see href="https://schema.org/associatedArticle"></see></summary>
    let associatedArticle = _prefix "associatedArticle"
    /// <summary>
    /// An associated [[ClaimReview]], related by specific common content, topic or claim. The expectation is that this property would be most typically used in cases where a single activity is conducting both claim reviews and media reviews, in which case [[relatedMediaReview]] would commonly be used on a [[ClaimReview]], while [[associatedClaimReview]] would be used on [[MediaReview]].
    /// <see href="https://schema.org/associatedClaimReview"></see></summary>
    let associatedClaimReview = _prefix "associatedClaimReview"
    /// <summary>
    /// An associated [[Review]].
    /// <see href="https://schema.org/associatedReview"></see></summary>
    let associatedReview = _prefix "associatedReview"
    /// <summary>
    /// Disease associated to this BioChemEntity. Such disease can be a MedicalCondition or a URL. If you want to add an evidence supporting the association, please use PropertyValue.
    /// <see href="https://schema.org/associatedDisease"></see></summary>
    let associatedDisease = _prefix "associatedDisease"
    /// <summary>
    /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
    /// <see href="https://schema.org/associatedMedia"></see></summary>
    let associatedMedia = _prefix "associatedMedia"
    /// <summary>
    /// An associated [[MediaReview]], related by specific common content, topic or claim. The expectation is that this property would be most typically used in cases where a single activity is conducting both claim reviews and media reviews, in which case [[relatedMediaReview]] would commonly be used on a [[ClaimReview]], while [[associatedClaimReview]] would be used on [[MediaReview]].
    /// <see href="https://schema.org/associatedMediaReview"></see></summary>
    let associatedMediaReview = _prefix "associatedMediaReview"
    /// <summary>
    /// If applicable, a description of the pathophysiology associated with the anatomical system, including potential abnormal changes in the mechanical, physical, and biochemical functions of the system.
    /// <see href="https://schema.org/associatedPathophysiology"></see></summary>
    let associatedPathophysiology = _prefix "associatedPathophysiology"
    /// <summary>
    /// A person that acts as performing member of a sports team; a player as opposed to a coach.
    /// <see href="https://schema.org/athlete"></see></summary>
    let athlete = _prefix "athlete"
    /// <summary>
    /// A person or organization attending the event.
    /// <see href="https://schema.org/attendee"></see></summary>
    let attendee = _prefix "attendee"
    /// <summary>
    /// A person attending the event.
    /// <see href="https://schema.org/attendees"></see></summary>
    let attendees = _prefix "attendees"
    /// <summary>
    /// An intended audience, i.e. a group for whom something was created.
    /// <see href="https://schema.org/audience"></see></summary>
    let audience = _prefix "audience"
    /// <summary>
    /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
    /// <see href="https://schema.org/audienceType"></see></summary>
    let audienceType = _prefix "audienceType"
    /// <summary>
    /// An embedded audio object.
    /// <see href="https://schema.org/audio"></see></summary>
    let audio = _prefix "audio"
    /// <summary>
    /// Date when a certification was last audited. See also  [gs1:certificationAuditDate](https://www.gs1.org/voc/certificationAuditDate).
    /// <see href="https://schema.org/auditDate"></see></summary>
    let auditDate = _prefix "auditDate"
    /// <summary>
    /// The Organization responsible for authenticating the user's subscription. For example, many media apps require a cable/satellite provider to authenticate your subscription before playing media.
    /// <see href="https://schema.org/authenticator"></see></summary>
    let authenticator = _prefix "authenticator"
    /// <summary>
    /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
    /// <see href="https://schema.org/author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    /// The availability of this item&amp;#x2014;for example In stock, Out of stock, Pre-order, etc.
    /// <see href="https://schema.org/availability"></see></summary>
    let availability = _prefix "availability"
    /// <summary>
    /// The end of the availability of the product or service included in the offer.
    /// <see href="https://schema.org/availabilityEnds"></see></summary>
    let availabilityEnds = _prefix "availabilityEnds"
    /// <summary>
    /// The beginning of the availability of the product or service included in the offer.
    /// <see href="https://schema.org/availabilityStarts"></see></summary>
    let availabilityStarts = _prefix "availabilityStarts"
    /// <summary>
    /// The place(s) from which the offer can be obtained (e.g. store locations).
    /// <see href="https://schema.org/availableAtOrFrom"></see></summary>
    let availableAtOrFrom = _prefix "availableAtOrFrom"
    /// <summary>
    /// A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
    /// <see href="https://schema.org/availableChannel"></see></summary>
    let availableChannel = _prefix "availableChannel"
    /// <summary>
    /// The delivery method(s) available for this offer.
    /// <see href="https://schema.org/availableDeliveryMethod"></see></summary>
    let availableDeliveryMethod = _prefix "availableDeliveryMethod"
    /// <summary>
    /// When the item is available for pickup from the store, locker, etc.
    /// <see href="https://schema.org/availableFrom"></see></summary>
    let availableFrom = _prefix "availableFrom"
    /// <summary>
    /// The location in which the strength is available.
    /// <see href="https://schema.org/availableIn"></see></summary>
    let availableIn = _prefix "availableIn"
    /// <summary>
    /// A language someone may use with or at the item, service or place. Please use one of the language codes from the [IETF BCP 47 standard](http://tools.ietf.org/html/bcp47). See also [[inLanguage]].
    /// <see href="https://schema.org/availableLanguage"></see></summary>
    let availableLanguage = _prefix "availableLanguage"
    /// <summary>
    /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
    /// <see href="https://schema.org/availableOnDevice"></see></summary>
    let availableOnDevice = _prefix "availableOnDevice"
    /// <summary>
    /// A medical service available from this provider.
    /// <see href="https://schema.org/availableService"></see></summary>
    let availableService = _prefix "availableService"
    /// <summary>
    /// An available dosage strength for the drug.
    /// <see href="https://schema.org/availableStrength"></see></summary>
    let availableStrength = _prefix "availableStrength"
    /// <summary>
    /// A diagnostic test or procedure offered by this lab.
    /// <see href="https://schema.org/availableTest"></see></summary>
    let availableTest = _prefix "availableTest"
    /// <summary>
    /// After this date, the item will no longer be available for pickup.
    /// <see href="https://schema.org/availableThrough"></see></summary>
    let availableThrough = _prefix "availableThrough"
    /// <summary>
    /// An award won by or for this item.
    /// <see href="https://schema.org/award"></see></summary>
    let award = _prefix "award"
    /// <summary>
    /// Awards won by or for this item.
    /// <see href="https://schema.org/awards"></see></summary>
    let awards = _prefix "awards"
    /// <summary>
    /// The away team in a sports event.
    /// <see href="https://schema.org/awayTeam"></see></summary>
    let awayTeam = _prefix "awayTeam"
    /// <summary>
    /// A competitor in a sports event.
    /// <see href="https://schema.org/competitor"></see></summary>
    let competitor = _prefix "competitor"
    /// <summary>
    /// For an [[Article]], typically a [[NewsArticle]], the backstory property provides a textual summary giving a brief explanation of why and how an article was created. In a journalistic setting this could include information about reporting process, methods, interviews, data sources, etc.
    /// <see href="https://schema.org/backstory"></see></summary>
    let backstory = _prefix "backstory"
    /// <summary>
    /// The type of a bank account.
    /// <see href="https://schema.org/bankAccountType"></see></summary>
    let bankAccountType = _prefix "bankAccountType"
    /// <summary>
    /// The base salary of the job or of an employee in an EmployeeRole.
    /// <see href="https://schema.org/baseSalary"></see></summary>
    let baseSalary = _prefix "baseSalary"
    /// <summary>
    /// A sub property of recipient. The recipient blind copied on a message.
    /// <see href="https://schema.org/bccRecipient"></see></summary>
    let bccRecipient = _prefix "bccRecipient"
    /// <summary>
    /// A sub property of participant. The participant who is at the receiving end of the action.
    /// <see href="https://schema.org/recipient"></see></summary>
    let recipient = _prefix "recipient"
    /// <summary>
    /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
    ///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.
    /// <see href="https://schema.org/bed"></see></summary>
    let bed = _prefix "bed"
    /// <summary>
    /// A media object representing the circumstances before performing this direction.
    /// <see href="https://schema.org/beforeMedia"></see></summary>
    let beforeMedia = _prefix "beforeMedia"
    /// <summary>
    /// A bank or bank’s branch, financial institution or international financial institution operating the beneficiary’s bank account or releasing funds for the beneficiary.
    /// <see href="https://schema.org/beneficiaryBank"></see></summary>
    let beneficiaryBank = _prefix "beneficiaryBank"
    /// <summary>
    /// Description of benefits associated with the job.
    /// <see href="https://schema.org/benefits"></see></summary>
    let benefits = _prefix "benefits"
    /// <summary>
    /// Description of benefits associated with the job.
    /// <see href="https://schema.org/jobBenefits"></see></summary>
    let jobBenefits = _prefix "jobBenefits"
    /// <summary>
    /// The URL that goes directly to the summary of benefits and coverage for the specific standard plan or plan variation.
    /// <see href="https://schema.org/benefitsSummaryUrl"></see></summary>
    let benefitsSummaryUrl = _prefix "benefitsSummaryUrl"
    /// <summary>
    /// The highest value allowed in this rating system.
    /// <see href="https://schema.org/bestRating"></see></summary>
    let bestRating = _prefix "bestRating"
    /// <summary>
    /// The billing address for the order.
    /// <see href="https://schema.org/billingAddress"></see></summary>
    let billingAddress = _prefix "billingAddress"
    /// <summary>
    /// Specifies for how long this price (or price component) will be billed. Can be used, for example, to model the contractual duration of a subscription or payment plan. Type can be either a Duration or a Number (in which case the unit of measurement, for example month, is specified by the unitCode property).
    /// <see href="https://schema.org/billingDuration"></see></summary>
    let billingDuration = _prefix "billingDuration"
    /// <summary>
    /// This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.
    /// <see href="https://schema.org/billingIncrement"></see></summary>
    let billingIncrement = _prefix "billingIncrement"
    /// <summary>
    /// The time interval used to compute the invoice.
    /// <see href="https://schema.org/billingPeriod"></see></summary>
    let billingPeriod = _prefix "billingPeriod"
    /// <summary>
    /// Specifies after how much time this price (or price component) becomes valid and billing starts. Can be used, for example, to model a price increase after the first year of a subscription. The unit of measurement is specified by the unitCode property.
    /// <see href="https://schema.org/billingStart"></see></summary>
    let billingStart = _prefix "billingStart"
    /// <summary>
    /// A BioChemEntity that is known to interact with this item.
    /// <see href="https://schema.org/bioChemInteraction"></see></summary>
    let bioChemInteraction = _prefix "bioChemInteraction"
    /// <summary>
    /// A similar BioChemEntity, e.g., obtained by fingerprint similarity algorithms.
    /// <see href="https://schema.org/bioChemSimilarity"></see></summary>
    let bioChemSimilarity = _prefix "bioChemSimilarity"
    /// <summary>
    /// A role played by the BioChemEntity within a biological context.
    /// <see href="https://schema.org/biologicalRole"></see></summary>
    let biologicalRole = _prefix "biologicalRole"
    /// <summary>
    /// The biomechanical properties of the bone.
    /// <see href="https://schema.org/biomechnicalClass"></see></summary>
    let biomechnicalClass = _prefix "biomechnicalClass"
    /// <summary>
    /// Date of birth.
    /// <see href="https://schema.org/birthDate"></see></summary>
    let birthDate = _prefix "birthDate"
    /// <summary>
    /// The place where the person was born.
    /// <see href="https://schema.org/birthPlace"></see></summary>
    let birthPlace = _prefix "birthPlace"
    /// <summary>
    /// The bitrate of the media object.
    /// <see href="https://schema.org/bitrate"></see></summary>
    let bitrate = _prefix "bitrate"
    /// <summary>
    /// A posting that is part of this blog.
    /// <see href="https://schema.org/blogPost"></see></summary>
    let blogPost = _prefix "blogPost"
    /// <summary>
    /// Indicates a post that is part of a [[Blog]]. Note that historically, what we term a "Blog" was once known as a "weblog", and that what we term a "BlogPosting" is now often colloquially referred to as a "blog".
    /// <see href="https://schema.org/blogPosts"></see></summary>
    let blogPosts = _prefix "blogPosts"
    /// <summary>
    /// The blood vessel that carries blood from the heart to the muscle.
    /// <see href="https://schema.org/bloodSupply"></see></summary>
    let bloodSupply = _prefix "bloodSupply"
    /// <summary>
    /// The airline-specific indicator of boarding order / preference.
    /// <see href="https://schema.org/boardingGroup"></see></summary>
    let boardingGroup = _prefix "boardingGroup"
    /// <summary>
    /// The type of boarding policy used by the airline (e.g. zone-based or group-based).
    /// <see href="https://schema.org/boardingPolicy"></see></summary>
    let boardingPolicy = _prefix "boardingPolicy"
    /// <summary>
    /// Location in the body of the anatomical structure.
    /// <see href="https://schema.org/bodyLocation"></see></summary>
    let bodyLocation = _prefix "bodyLocation"
    /// <summary>
    /// Indicates the design and body style of the vehicle (e.g. station wagon, hatchback, etc.).
    /// <see href="https://schema.org/bodyType"></see></summary>
    let bodyType = _prefix "bodyType"
    /// <summary>
    /// The edition of the book.
    /// <see href="https://schema.org/bookEdition"></see></summary>
    let bookEdition = _prefix "bookEdition"
    /// <summary>
    /// The format of the book.
    /// <see href="https://schema.org/bookFormat"></see></summary>
    let bookFormat = _prefix "bookFormat"
    /// <summary>
    /// 'bookingAgent' is an out-dated term indicating a 'broker' that serves as a booking agent.
    /// <see href="https://schema.org/bookingAgent"></see></summary>
    let bookingAgent = _prefix "bookingAgent"
    /// <summary>
    /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
    /// <see href="https://schema.org/broker"></see></summary>
    let broker = _prefix "broker"
    /// <summary>
    /// The date and time the reservation was booked.
    /// <see href="https://schema.org/bookingTime"></see></summary>
    let bookingTime = _prefix "bookingTime"
    /// <summary>
    /// A sub property of participant. The person that borrows the object being lent.
    /// <see href="https://schema.org/borrower"></see></summary>
    let borrower = _prefix "borrower"
    /// <summary>
    /// Other co-agents that participated in the action indirectly. E.g. John wrote a book with *Steve*.
    /// <see href="https://schema.org/participant"></see></summary>
    let participant = _prefix "participant"
    /// <summary>
    /// A box is the area enclosed by the rectangle formed by two points. The first point is the lower corner, the second point is the upper corner. A box is expressed as two points separated by a space character.
    /// <see href="https://schema.org/box"></see></summary>
    let box = _prefix "box"
    /// <summary>
    /// The branches that delineate from the nerve bundle. Not to be confused with [[branchOf]].
    /// <see href="https://schema.org/branch"></see></summary>
    let branch = _prefix "branch"
    /// <summary>
    /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.\n\nFor example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
    ///
    /// <see href="https://schema.org/branchCode"></see></summary>
    let branchCode = _prefix "branchCode"
    /// <summary>
    /// The larger organization that this local business is a branch of, if any. Not to be confused with (anatomical) [[branch]].
    /// <see href="https://schema.org/branchOf"></see></summary>
    let branchOf = _prefix "branchOf"
    /// <summary>
    /// The larger organization that this organization is a [[subOrganization]] of, if any.
    /// <see href="https://schema.org/parentOrganization"></see></summary>
    let parentOrganization = _prefix "parentOrganization"
    /// <summary>
    /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
    /// <see href="https://schema.org/brand"></see></summary>
    let brand = _prefix "brand"
    /// <summary>
    /// A set of links that can help a user understand and navigate a website hierarchy.
    /// <see href="https://schema.org/breadcrumb"></see></summary>
    let breadcrumb = _prefix "breadcrumb"
    /// <summary>
    /// Any precaution, guidance, contraindication, etc. related to this drug's use by breastfeeding mothers.
    /// <see href="https://schema.org/breastfeedingWarning"></see></summary>
    let breastfeedingWarning = _prefix "breastfeedingWarning"
    /// <summary>
    /// The media network(s) whose content is broadcast on this station.
    /// <see href="https://schema.org/broadcastAffiliateOf"></see></summary>
    let broadcastAffiliateOf = _prefix "broadcastAffiliateOf"
    /// <summary>
    /// The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.
    /// <see href="https://schema.org/broadcastChannelId"></see></summary>
    let broadcastChannelId = _prefix "broadcastChannelId"
    /// <summary>
    /// The name displayed in the channel guide. For many US affiliates, it is the network name.
    /// <see href="https://schema.org/broadcastDisplayName"></see></summary>
    let broadcastDisplayName = _prefix "broadcastDisplayName"
    /// <summary>
    /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges, e.g. 87-99. In addition a shortcut idiom is supported for frequencies of AM and FM radio channels, e.g. "87 FM".
    /// <see href="https://schema.org/broadcastFrequency"></see></summary>
    let broadcastFrequency = _prefix "broadcastFrequency"
    /// <summary>
    /// The frequency in MHz for a particular broadcast.
    /// <see href="https://schema.org/broadcastFrequencyValue"></see></summary>
    let broadcastFrequencyValue = _prefix "broadcastFrequencyValue"
    /// <summary>
    /// The event being broadcast such as a sporting event or awards ceremony.
    /// <see href="https://schema.org/broadcastOfEvent"></see></summary>
    let broadcastOfEvent = _prefix "broadcastOfEvent"
    /// <summary>
    /// The type of service required to have access to the channel (e.g. Standard or Premium).
    /// <see href="https://schema.org/broadcastServiceTier"></see></summary>
    let broadcastServiceTier = _prefix "broadcastServiceTier"
    /// <summary>
    /// The modulation (e.g. FM, AM, etc) used by a particular broadcast service.
    /// <see href="https://schema.org/broadcastSignalModulation"></see></summary>
    let broadcastSignalModulation = _prefix "broadcastSignalModulation"
    /// <summary>
    /// The subchannel used for the broadcast.
    /// <see href="https://schema.org/broadcastSubChannel"></see></summary>
    let broadcastSubChannel = _prefix "broadcastSubChannel"
    /// <summary>
    /// The timezone in [ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601) for which the service bases its broadcasts.
    /// <see href="https://schema.org/broadcastTimezone"></see></summary>
    let broadcastTimezone = _prefix "broadcastTimezone"
    /// <summary>
    /// The organization owning or operating the broadcast service.
    /// <see href="https://schema.org/broadcaster"></see></summary>
    let broadcaster = _prefix "broadcaster"
    /// <summary>
    /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
    /// <see href="https://schema.org/browserRequirements"></see></summary>
    let browserRequirements = _prefix "browserRequirements"
    /// <summary>
    /// The name of the bus (e.g. Bolt Express).
    /// <see href="https://schema.org/busName"></see></summary>
    let busName = _prefix "busName"
    /// <summary>
    /// The unique identifier for the bus.
    /// <see href="https://schema.org/busNumber"></see></summary>
    let busNumber = _prefix "busNumber"
    /// <summary>
    /// Days of the week when the merchant typically operates, indicated via opening hours markup.
    /// <see href="https://schema.org/businessDays"></see></summary>
    let businessDays = _prefix "businessDays"
    /// <summary>
    /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
    /// <see href="https://schema.org/businessFunction"></see></summary>
    let businessFunction = _prefix "businessFunction"
    /// <summary>
    /// A sub property of participant. The participant/person/organization that bought the object.
    /// <see href="https://schema.org/buyer"></see></summary>
    let buyer = _prefix "buyer"
    /// <summary>
    /// The artist that performed this album or recording.
    /// <see href="https://schema.org/byArtist"></see></summary>
    let byArtist = _prefix "byArtist"
    /// <summary>
    /// Defines the day(s) of the week on which a recurring [[Event]] takes place. May be specified using either [[DayOfWeek]], or alternatively [[Text]] conforming to iCal's syntax for byDay recurrence rules.
    /// <see href="https://schema.org/byDay"></see></summary>
    let byDay = _prefix "byDay"
    /// <summary>
    /// Defines the month(s) of the year on which a recurring [[Event]] takes place. Specified as an [[Integer]] between 1-12. January is 1.
    /// <see href="https://schema.org/byMonth"></see></summary>
    let byMonth = _prefix "byMonth"
    /// <summary>
    /// Defines the day(s) of the month on which a recurring [[Event]] takes place. Specified as an [[Integer]] between 1-31.
    /// <see href="https://schema.org/byMonthDay"></see></summary>
    let byMonthDay = _prefix "byMonthDay"
    /// <summary>
    /// Defines the week(s) of the month on which a recurring Event takes place. Specified as an Integer between 1-5. For clarity, byMonthWeek is best used in conjunction with byDay to indicate concepts like the first and third Mondays of a month.
    /// <see href="https://schema.org/byMonthWeek"></see></summary>
    let byMonthWeek = _prefix "byMonthWeek"
    /// <summary>
    /// A [callsign](https://en.wikipedia.org/wiki/Call_sign), as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
    /// <see href="https://schema.org/callSign"></see></summary>
    let callSign = _prefix "callSign"
    /// <summary>
    /// The number of calories.
    /// <see href="https://schema.org/calories"></see></summary>
    let calories = _prefix "calories"
    /// <summary>
    /// A sub property of object. The candidate subject of this action.
    /// <see href="https://schema.org/candidate"></see></summary>
    let candidate = _prefix "candidate"
    /// <summary>
    /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the [[encodingFormat]].
    /// <see href="https://schema.org/caption"></see></summary>
    let caption = _prefix "caption"
    /// <summary>
    /// The number of grams of carbohydrates.
    /// <see href="https://schema.org/carbohydrateContent"></see></summary>
    let carbohydrateContent = _prefix "carbohydrateContent"
    /// <summary>
    /// The available volume for cargo or luggage. For automobiles, this is usually the trunk volume.\n\nTypical unit code(s): LTR for liters, FTQ for cubic foot/feet\n\nNote: You can use [[minValue]] and [[maxValue]] to indicate ranges.
    /// <see href="https://schema.org/cargoVolume"></see></summary>
    let cargoVolume = _prefix "cargoVolume"
    /// <summary>
    /// 'carrier' is an out-dated term indicating the 'provider' for parcel delivery and flights.
    /// <see href="https://schema.org/carrier"></see></summary>
    let carrier = _prefix "carrier"
    /// <summary>
    /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
    /// <see href="https://schema.org/provider"></see></summary>
    let provider = _prefix "provider"
    /// <summary>
    /// Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).
    /// <see href="https://schema.org/carrierRequirements"></see></summary>
    let carrierRequirements = _prefix "carrierRequirements"
    /// <summary>
    /// A cardholder benefit that pays the cardholder a small percentage of their net expenditures.
    /// <see href="https://schema.org/cashBack"></see></summary>
    let cashBack = _prefix "cashBack"
    /// <summary>
    /// A data catalog which contains this dataset.
    /// <see href="https://schema.org/catalog"></see></summary>
    let catalog = _prefix "catalog"
    /// <summary>
    /// A data catalog which contains this dataset.
    /// <see href="https://schema.org/includedInDataCatalog"></see></summary>
    let includedInDataCatalog = _prefix "includedInDataCatalog"
    /// <summary>
    /// The catalog number for the release.
    /// <see href="https://schema.org/catalogNumber"></see></summary>
    let catalogNumber = _prefix "catalogNumber"
    /// <summary>
    /// The cause of a medical condition.
    /// <see href="https://schema.org/cause"></see></summary>
    let cause = _prefix "cause"
    /// <summary>
    /// The condition, complication, symptom, sign, etc. caused.
    /// <see href="https://schema.org/causeOf"></see></summary>
    let causeOf = _prefix "causeOf"
    /// <summary>
    /// A sub property of recipient. The recipient copied on a message.
    /// <see href="https://schema.org/ccRecipient"></see></summary>
    let ccRecipient = _prefix "ccRecipient"
    /// <summary>
    /// Identifier of a certification instance (as registered with an independent certification body). Typically this identifier can be used to consult and verify the certification instance. See also [gs1:certificationIdentification](https://www.gs1.org/voc/certificationIdentification).
    /// <see href="https://schema.org/certificationIdentification"></see></summary>
    let certificationIdentification = _prefix "certificationIdentification"
    /// <summary>
    /// Rating of a certification instance (as defined by an independent certification body). Typically this rating can be used to rate the level to which the requirements of the certification instance are fulfilled. See also [gs1:certificationValue](https://www.gs1.org/voc/certificationValue).
    /// <see href="https://schema.org/certificationRating"></see></summary>
    let certificationRating = _prefix "certificationRating"
    /// <summary>
    /// Indicates the current status of a certification: active or inactive. See also  [gs1:certificationStatus](https://www.gs1.org/voc/certificationStatus).
    /// <see href="https://schema.org/certificationStatus"></see></summary>
    let certificationStatus = _prefix "certificationStatus"
    /// <summary>
    /// Fictional person connected with a creative work.
    /// <see href="https://schema.org/character"></see></summary>
    let character = _prefix "character"
    /// <summary>
    /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
    /// <see href="https://schema.org/characterAttribute"></see></summary>
    let characterAttribute = _prefix "characterAttribute"
    /// <summary>
    /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
    /// <see href="https://schema.org/characterName"></see></summary>
    let characterName = _prefix "characterName"
    /// <summary>
    /// Cheat codes to the game.
    /// <see href="https://schema.org/cheatCode"></see></summary>
    let cheatCode = _prefix "cheatCode"
    /// <summary>
    /// The earliest someone may check into a lodging establishment.
    /// <see href="https://schema.org/checkinTime"></see></summary>
    let checkinTime = _prefix "checkinTime"
    /// <summary>
    /// A URL template (RFC 6570) for a checkout page for an offer. This approach allows merchants to specify a URL for online checkout of the offered product, by interpolating parameters such as the logged in user ID, product ID, quantity, discount code etc. Parameter naming and standardization are not specified here.
    /// <see href="https://schema.org/checkoutPageURLTemplate"></see></summary>
    let checkoutPageURLTemplate = _prefix "checkoutPageURLTemplate"
    /// <summary>
    /// The latest someone may check out of a lodging establishment.
    /// <see href="https://schema.org/checkoutTime"></see></summary>
    let checkoutTime = _prefix "checkoutTime"
    /// <summary>
    /// The chemical composition describes the identity and relative ratio of the chemical elements that make up the substance.
    /// <see href="https://schema.org/chemicalComposition"></see></summary>
    let chemicalComposition = _prefix "chemicalComposition"
    /// <summary>
    /// A role played by the BioChemEntity within a chemical context.
    /// <see href="https://schema.org/chemicalRole"></see></summary>
    let chemicalRole = _prefix "chemicalRole"
    /// <summary>
    /// Maximal age of the child.
    /// <see href="https://schema.org/childMaxAge"></see></summary>
    let childMaxAge = _prefix "childMaxAge"
    /// <summary>
    /// Minimal age of the child.
    /// <see href="https://schema.org/childMinAge"></see></summary>
    let childMinAge = _prefix "childMinAge"
    /// <summary>
    /// Closest child taxa of the taxon in question.
    /// <see href="https://schema.org/childTaxon"></see></summary>
    let childTaxon = _prefix "childTaxon"
    /// <summary>
    /// Closest parent taxon of the taxon in question.
    /// <see href="https://schema.org/parentTaxon"></see></summary>
    let parentTaxon = _prefix "parentTaxon"
    /// <summary>
    /// A child of the person.
    /// <see href="https://schema.org/children"></see></summary>
    let children = _prefix "children"
    /// <summary>
    /// The number of milligrams of cholesterol.
    /// <see href="https://schema.org/cholesterolContent"></see></summary>
    let cholesterolContent = _prefix "cholesterolContent"
    /// <summary>
    /// A circle is the circular region of a specified radius centered at a specified latitude and longitude. A circle is expressed as a pair followed by a radius in meters.
    /// <see href="https://schema.org/circle"></see></summary>
    let circle = _prefix "circle"
    /// <summary>
    /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
    /// <see href="https://schema.org/citation"></see></summary>
    let citation = _prefix "citation"
    /// <summary>
    /// For a [[Claim]] interpreted from [[MediaObject]] content, the [[interpretedAsClaim]] property can be used to indicate a claim contained, implied or refined from the content of a [[MediaObject]].
    /// <see href="https://schema.org/claimInterpreter"></see></summary>
    let claimInterpreter = _prefix "claimInterpreter"
    /// <summary>
    /// A short summary of the specific claims reviewed in a ClaimReview.
    /// <see href="https://schema.org/claimReviewed"></see></summary>
    let claimReviewed = _prefix "claimReviewed"
    /// <summary>
    /// Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD).
    /// <see href="https://schema.org/clincalPharmacology"></see></summary>
    let clincalPharmacology = _prefix "clincalPharmacology"
    /// <summary>
    /// Description of the absorption and elimination of drugs, including their concentration (pharmacokinetics, pK) and biological effects (pharmacodynamics, pD).
    /// <see href="https://schema.org/clinicalPharmacology"></see></summary>
    let clinicalPharmacology = _prefix "clinicalPharmacology"
    /// <summary>
    /// Position of the clip within an ordered group of clips.
    /// <see href="https://schema.org/clipNumber"></see></summary>
    let clipNumber = _prefix "clipNumber"
    /// <summary>
    /// The position of an item in a series or sequence of items.
    /// <see href="https://schema.org/position"></see></summary>
    let position = _prefix "position"
    /// <summary>
    /// The closing hour of the place or service on the given day(s) of the week.
    /// <see href="https://schema.org/closes"></see></summary>
    let closes = _prefix "closes"
    /// <summary>
    /// A person that acts in a coaching role for a sports team.
    /// <see href="https://schema.org/coach"></see></summary>
    let coach = _prefix "coach"
    /// <summary>
    /// A medical code for the entity, taken from a controlled vocabulary or ontology such as ICD-9, DiseasesDB, MeSH, SNOMED-CT, RxNorm, etc.
    /// <see href="https://schema.org/code"></see></summary>
    let code = _prefix "code"
    /// <summary>
    /// Link to the repository where the un-compiled, human readable code and related code is located (SVN, GitHub, CodePlex).
    /// <see href="https://schema.org/codeRepository"></see></summary>
    let codeRepository = _prefix "codeRepository"
    /// <summary>
    /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
    /// <see href="https://schema.org/codeSampleType"></see></summary>
    let codeSampleType = _prefix "codeSampleType"
    /// <summary>
    /// A short textual code that uniquely identifies the value.
    /// <see href="https://schema.org/codeValue"></see></summary>
    let codeValue = _prefix "codeValue"
    /// <summary>
    /// A code that identifies this [[DefinedTerm]] within a [[DefinedTermSet]].
    /// <see href="https://schema.org/termCode"></see></summary>
    let termCode = _prefix "termCode"
    /// <summary>
    /// The coding system, e.g. 'ICD-10'.
    /// <see href="https://schema.org/codingSystem"></see></summary>
    let codingSystem = _prefix "codingSystem"
    /// <summary>
    /// A colleague of the person.
    /// <see href="https://schema.org/colleague"></see></summary>
    let colleague = _prefix "colleague"
    /// <summary>
    /// A colleague of the person.
    /// <see href="https://schema.org/colleagues"></see></summary>
    let colleagues = _prefix "colleagues"
    /// <summary>
    /// A sub property of object. The collection target of the action.
    /// <see href="https://schema.org/collection"></see></summary>
    let collection = _prefix "collection"
    /// <summary>
    /// A sub property of object. The collection target of the action.
    /// <see href="https://schema.org/targetCollection"></see></summary>
    let targetCollection = _prefix "targetCollection"
    /// <summary>
    /// The number of items in the [[Collection]].
    /// <see href="https://schema.org/collectionSize"></see></summary>
    let collectionSize = _prefix "collectionSize"
    /// <summary>
    /// The color of the product.
    /// <see href="https://schema.org/color"></see></summary>
    let color = _prefix "color"
    /// <summary>
    /// A color swatch image, visualizing the color of a [[Product]]. Should match the textual description specified in the [[color]] property. This can be a URL or a fully described ImageObject.
    /// <see href="https://schema.org/colorSwatch"></see></summary>
    let colorSwatch = _prefix "colorSwatch"
    /// <summary>
    /// An image of the item. This can be a [[URL]] or a fully described [[ImageObject]].
    /// <see href="https://schema.org/image"></see></summary>
    let image = _prefix "image"
    /// <summary>
    /// The individual who adds color to inked drawings.
    /// <see href="https://schema.org/colorist"></see></summary>
    let colorist = _prefix "colorist"
    /// <summary>
    /// Comments, typically from users.
    /// <see href="https://schema.org/comment"></see></summary>
    let comment = _prefix "comment"
    /// <summary>
    /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
    /// <see href="https://schema.org/commentCount"></see></summary>
    let commentCount = _prefix "commentCount"
    /// <summary>
    /// The text of the UserComment.
    /// <see href="https://schema.org/commentText"></see></summary>
    let commentText = _prefix "commentText"
    /// <summary>
    /// The time at which the UserComment was made.
    /// <see href="https://schema.org/commentTime"></see></summary>
    let commentTime = _prefix "commentTime"
    /// <summary>
    /// The official registration information of a business including the organization that issued it such as Company House or Chamber of Commerce in form of a Certification.
    /// <see href="https://schema.org/companyRegistration"></see></summary>
    let companyRegistration = _prefix "companyRegistration"
    /// <summary>
    /// Knowledge, skill, ability or personal attribute that must be demonstrated by a person or other entity in order to do something such as earn an Educational Occupational Credential or understand a LearningResource.
    /// <see href="https://schema.org/competencyRequired"></see></summary>
    let competencyRequired = _prefix "competencyRequired"
    /// <summary>
    /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
    /// <see href="https://schema.org/composer"></see></summary>
    let composer = _prefix "composer"
    /// <summary>
    /// Specifying something physically contained by something else. Typically used here for the underlying anatomical structures, such as organs, that comprise the anatomical system.
    /// <see href="https://schema.org/comprisedOf"></see></summary>
    let comprisedOf = _prefix "comprisedOf"
    /// <summary>
    /// Conditions that affect the availability of, or method(s) of access to, an item. Typically used for real world items such as an [[ArchiveComponent]] held by an [[ArchiveOrganization]]. This property is not suitable for use as a general Web access control mechanism. It is expressed only in natural language.\n\nFor example "Available by appointment from the Reading Room" or "Accessible only from logged-in accounts ".
    /// <see href="https://schema.org/conditionsOfAccess"></see></summary>
    let conditionsOfAccess = _prefix "conditionsOfAccess"
    /// <summary>
    /// A number that confirms the given order or payment has been received.
    /// <see href="https://schema.org/confirmationNumber"></see></summary>
    let confirmationNumber = _prefix "confirmationNumber"
    /// <summary>
    /// Other anatomical structures to which this structure is connected.
    /// <see href="https://schema.org/connectedTo"></see></summary>
    let connectedTo = _prefix "connectedTo"
    /// <summary>
    /// Indicates a property used as a constraint. For example, in the definition of a [[StatisticalVariable]]. The value is a property, either from within Schema.org or from other compatible (e.g. RDF) systems such as DataCommons.org or Wikidata.org.
    /// <see href="https://schema.org/constraintProperty"></see></summary>
    let constraintProperty = _prefix "constraintProperty"
    /// <summary>
    /// An option available on this contact point (e.g. a toll-free number or support for hearing-impaired callers).
    /// <see href="https://schema.org/contactOption"></see></summary>
    let contactOption = _prefix "contactOption"
    /// <summary>
    /// A contact point for a person or organization.
    /// <see href="https://schema.org/contactPoint"></see></summary>
    let contactPoint = _prefix "contactPoint"
    /// <summary>
    /// A contact point for a person or organization.
    /// <see href="https://schema.org/contactPoints"></see></summary>
    let contactPoints = _prefix "contactPoints"
    /// <summary>
    /// A person or organization can have different contact points, for different purposes. For example, a sales contact point, a PR contact point and so on. This property is used to specify the kind of contact point.
    /// <see href="https://schema.org/contactType"></see></summary>
    let contactType = _prefix "contactType"
    /// <summary>
    /// A secure method for consumers to purchase products or services via debit, credit or smartcards by using RFID or NFC technology.
    /// <see href="https://schema.org/contactlessPayment"></see></summary>
    let contactlessPayment = _prefix "contactlessPayment"
    /// <summary>
    /// The basic containment relation between a place and one that contains it.
    /// <see href="https://schema.org/containedIn"></see></summary>
    let containedIn = _prefix "containedIn"
    /// <summary>
    /// The basic containment relation between a place and one that contains it.
    /// <see href="https://schema.org/containedInPlace"></see></summary>
    let containedInPlace = _prefix "containedInPlace"
    /// <summary>
    /// The basic containment relation between a place and another that it contains.
    /// <see href="https://schema.org/containsPlace"></see></summary>
    let containsPlace = _prefix "containsPlace"
    /// <summary>
    /// A season that is part of the media series.
    /// <see href="https://schema.org/containsSeason"></see></summary>
    let containsSeason = _prefix "containsSeason"
    /// <summary>
    /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).
    /// <see href="https://schema.org/hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// The location depicted or described in the content. For example, the location in a photograph or painting.
    /// <see href="https://schema.org/contentLocation"></see></summary>
    let contentLocation = _prefix "contentLocation"
    /// <summary>
    /// Official rating of a piece of content&amp;#x2014;for example, 'MPAA PG-13'.
    /// <see href="https://schema.org/contentRating"></see></summary>
    let contentRating = _prefix "contentRating"
    /// <summary>
    /// The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasise a particular moment within an Event.
    /// <see href="https://schema.org/contentReferenceTime"></see></summary>
    let contentReferenceTime = _prefix "contentReferenceTime"
    /// <summary>
    /// File size in (mega/kilo)bytes.
    /// <see href="https://schema.org/contentSize"></see></summary>
    let contentSize = _prefix "contentSize"
    /// <summary>
    /// The supported content type(s) for an EntryPoint response.
    /// <see href="https://schema.org/contentType"></see></summary>
    let contentType = _prefix "contentType"
    /// <summary>
    /// Actual bytes of the media object, for example the image file or video file.
    /// <see href="https://schema.org/contentUrl"></see></summary>
    let contentUrl = _prefix "contentUrl"
    /// <summary>
    /// A contraindication for this therapy.
    /// <see href="https://schema.org/contraindication"></see></summary>
    let contraindication = _prefix "contraindication"
    /// <summary>
    /// The time it takes to actually cook the dish, in [ISO 8601 duration format](http://en.wikipedia.org/wiki/ISO_8601).
    /// <see href="https://schema.org/cookTime"></see></summary>
    let cookTime = _prefix "cookTime"
    /// <summary>
    /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in [ISO 8601 duration format](http://en.wikipedia.org/wiki/ISO_8601).
    /// <see href="https://schema.org/performTime"></see></summary>
    let performTime = _prefix "performTime"
    /// <summary>
    /// The method of cooking, such as Frying, Steaming, ...
    /// <see href="https://schema.org/cookingMethod"></see></summary>
    let cookingMethod = _prefix "cookingMethod"
    /// <summary>
    /// The party holding the legal copyright to the CreativeWork.
    /// <see href="https://schema.org/copyrightHolder"></see></summary>
    let copyrightHolder = _prefix "copyrightHolder"
    /// <summary>
    /// Text of a notice appropriate for describing the copyright aspects of this Creative Work, ideally indicating the owner of the copyright for the Work.
    /// <see href="https://schema.org/copyrightNotice"></see></summary>
    let copyrightNotice = _prefix "copyrightNotice"
    /// <summary>
    /// The year during which the claimed copyright for the CreativeWork was first asserted.
    /// <see href="https://schema.org/copyrightYear"></see></summary>
    let copyrightYear = _prefix "copyrightYear"
    /// <summary>
    /// Indicates a correction to a [[CreativeWork]], either via a [[CorrectionComment]], textually or in another document.
    /// <see href="https://schema.org/correction"></see></summary>
    let correction = _prefix "correction"
    /// <summary>
    /// For an [[Organization]] (e.g. [[NewsMediaOrganization]]), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
    /// <see href="https://schema.org/correctionsPolicy"></see></summary>
    let correctionsPolicy = _prefix "correctionsPolicy"
    /// <summary>
    /// The category of cost, such as wholesale, retail, reimbursement cap, etc.
    /// <see href="https://schema.org/costCategory"></see></summary>
    let costCategory = _prefix "costCategory"
    /// <summary>
    /// The currency (in 3-letter) of the drug cost. See: http://en.wikipedia.org/wiki/ISO_4217.
    /// <see href="https://schema.org/costCurrency"></see></summary>
    let costCurrency = _prefix "costCurrency"
    /// <summary>
    /// Additional details to capture the origin of the cost data. For example, 'Medicare Part B'.
    /// <see href="https://schema.org/costOrigin"></see></summary>
    let costOrigin = _prefix "costOrigin"
    /// <summary>
    /// The cost per unit of the drug.
    /// <see href="https://schema.org/costPerUnit"></see></summary>
    let costPerUnit = _prefix "costPerUnit"
    /// <summary>
    /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    /// <see href="https://schema.org/countriesNotSupported"></see></summary>
    let countriesNotSupported = _prefix "countriesNotSupported"
    /// <summary>
    /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
    /// <see href="https://schema.org/countriesSupported"></see></summary>
    let countriesSupported = _prefix "countriesSupported"
    /// <summary>
    /// The place where the product was assembled.
    /// <see href="https://schema.org/countryOfAssembly"></see></summary>
    let countryOfAssembly = _prefix "countryOfAssembly"
    /// <summary>
    /// The place where the item (typically [[Product]]) was last processed and tested before importation.
    /// <see href="https://schema.org/countryOfLastProcessing"></see></summary>
    let countryOfLastProcessing = _prefix "countryOfLastProcessing"
    /// <summary>
    /// The country of origin of something, including products as well as creative  works such as movie and TV content.
    ///
    /// In the case of TV and movie, this would be the country of the principle offices of the production company or individual responsible for the movie. For other kinds of [[CreativeWork]] it is difficult to provide fully general guidance, and properties such as [[contentLocation]] and [[locationCreated]] may be more applicable.
    ///
    /// In the case of products, the country of origin of the product. The exact interpretation of this may vary by context and product type, and cannot be fully enumerated here.
    /// <see href="https://schema.org/countryOfOrigin"></see></summary>
    let countryOfOrigin = _prefix "countryOfOrigin"
    /// <summary>
    /// A sub property of location. The course where this action was taken.
    /// <see href="https://schema.org/course"></see></summary>
    let course = _prefix "course"
    /// <summary>
    /// The location of, for example, where an event is happening, where an organization is located, or where an action takes place.
    /// <see href="https://schema.org/location"></see></summary>
    let location = _prefix "location"
    /// <summary>
    /// A sub property of location. The course where this action was taken.
    /// <see href="https://schema.org/exerciseCourse"></see></summary>
    let exerciseCourse = _prefix "exerciseCourse"
    /// <summary>
    /// The identifier for the [[Course]] used by the course [[provider]] (e.g. CS101 or 6.001).
    /// <see href="https://schema.org/courseCode"></see></summary>
    let courseCode = _prefix "courseCode"
    /// <summary>
    /// The medium or means of delivery of the course instance or the mode of study, either as a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or as a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous).
    /// <see href="https://schema.org/courseMode"></see></summary>
    let courseMode = _prefix "courseMode"
    /// <summary>
    /// Requirements for taking the Course. May be completion of another [[Course]] or a textual description like "permission of instructor". Requirements may be a pre-requisite competency, referenced using [[AlignmentObject]].
    /// <see href="https://schema.org/coursePrerequisites"></see></summary>
    let coursePrerequisites = _prefix "coursePrerequisites"
    /// <summary>
    /// Represents the length and pace of a course, expressed as a [[Schedule]].
    /// <see href="https://schema.org/courseSchedule"></see></summary>
    let courseSchedule = _prefix "courseSchedule"
    /// <summary>
    /// The amount of work expected of students taking the course, often provided as a figure per week or per month, and may be broken down by type. For example, "2 hours of lectures, 1 hour of lab work and 3 hours of independent study per week".
    /// <see href="https://schema.org/courseWorkload"></see></summary>
    let courseWorkload = _prefix "courseWorkload"
    /// <summary>
    /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
    /// <see href="https://schema.org/coverageEndTime"></see></summary>
    let coverageEndTime = _prefix "coverageEndTime"
    /// <summary>
    /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
    /// <see href="https://schema.org/coverageStartTime"></see></summary>
    let coverageStartTime = _prefix "coverageStartTime"
    /// <summary>
    /// The status of a creative work in terms of its stage in a lifecycle. Example terms include Incomplete, Draft, Published, Obsolete. Some organizations define a set of terms for the stages of their publication lifecycle.
    /// <see href="https://schema.org/creativeWorkStatus"></see></summary>
    let creativeWorkStatus = _prefix "creativeWorkStatus"
    /// <summary>
    /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
    /// <see href="https://schema.org/creator"></see></summary>
    let creator = _prefix "creator"
    /// <summary>
    /// The category or type of credential being described, for example "degree”, “certificate”, “badge”, or more specific term.
    /// <see href="https://schema.org/credentialCategory"></see></summary>
    let credentialCategory = _prefix "credentialCategory"
    /// <summary>
    /// Text that can be used to credit person(s) and/or organization(s) associated with a published Creative Work.
    /// <see href="https://schema.org/creditText"></see></summary>
    let creditText = _prefix "creditText"
    /// <summary>
    /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
    /// <see href="https://schema.org/creditedTo"></see></summary>
    let creditedTo = _prefix "creditedTo"
    /// <summary>
    /// A CSS selector, e.g. of a [[SpeakableSpecification]] or [[WebPageElement]]. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
    /// <see href="https://schema.org/cssSelector"></see></summary>
    let cssSelector = _prefix "cssSelector"
    /// <summary>
    /// The currency accepted.\n\nUse standard formats: [ISO 4217 currency format](http://en.wikipedia.org/wiki/ISO_4217), e.g. "USD"; [Ticker symbol](https://en.wikipedia.org/wiki/List_of_cryptocurrencies) for cryptocurrencies, e.g. "BTC"; well known names for [Local Exchange Trading Systems](https://en.wikipedia.org/wiki/Local_exchange_trading_system) (LETS) and other currency types, e.g. "Ithaca HOUR".
    /// <see href="https://schema.org/currenciesAccepted"></see></summary>
    let currenciesAccepted = _prefix "currenciesAccepted"
    /// <summary>
    /// The currency in which the monetary amount is expressed.\n\nUse standard formats: [ISO 4217 currency format](http://en.wikipedia.org/wiki/ISO_4217), e.g. "USD"; [Ticker symbol](https://en.wikipedia.org/wiki/List_of_cryptocurrencies) for cryptocurrencies, e.g. "BTC"; well known names for [Local Exchange Trading Systems](https://en.wikipedia.org/wiki/Local_exchange_trading_system) (LETS) and other currency types, e.g. "Ithaca HOUR".
    /// <see href="https://schema.org/currency"></see></summary>
    let currency = _prefix "currency"
    /// <summary>
    /// The current price of a currency.
    /// <see href="https://schema.org/currentExchangeRate"></see></summary>
    let currentExchangeRate = _prefix "currentExchangeRate"
    /// <summary>
    /// Party placing the order or paying the invoice.
    /// <see href="https://schema.org/customer"></see></summary>
    let customer = _prefix "customer"
    /// <summary>
    /// The type of return fees if the product is returned due to customer remorse.
    /// <see href="https://schema.org/customerRemorseReturnFees"></see></summary>
    let customerRemorseReturnFees = _prefix "customerRemorseReturnFees"
    /// <summary>
    /// The method (from an enumeration) by which the customer obtains a return shipping label for a product returned due to customer remorse.
    /// <see href="https://schema.org/customerRemorseReturnLabelSource"></see></summary>
    let customerRemorseReturnLabelSource = _prefix "customerRemorseReturnLabelSource"

    /// <summary>
    /// The amount of shipping costs if a product is returned due to customer remorse. Applicable when property [[customerRemorseReturnFees]] equals [[ReturnShippingFees]].
    /// <see href="https://schema.org/customerRemorseReturnShippingFeesAmount"></see></summary>
    let customerRemorseReturnShippingFeesAmount =
        _prefix "customerRemorseReturnShippingFeesAmount"

    /// <summary>
    /// Order cutoff time allows merchants to describe the time after which they will no longer process orders received on that day. For orders processed after cutoff time, one day gets added to the delivery time estimate. This property is expected to be most typically used via the [[ShippingRateSettings]] publication pattern. The time is indicated using the ISO-8601 Time format, e.g. "23:30:00-05:00" would represent 6:30 pm Eastern Standard Time (EST) which is 5 hours behind Coordinated Universal Time (UTC).
    /// <see href="https://schema.org/cutoffTime"></see></summary>
    let cutoffTime = _prefix "cutoffTime"
    /// <summary>
    /// collectiondate - Date for which patient counts are reported.
    /// <see href="https://schema.org/cvdCollectionDate"></see></summary>
    let cvdCollectionDate = _prefix "cvdCollectionDate"
    /// <summary>
    /// Name of the County of the NHSN facility that this data record applies to. Use [[cvdFacilityId]] to identify the facility. To provide other details, [[healthcareReportingData]] can be used on a [[Hospital]] entry.
    /// <see href="https://schema.org/cvdFacilityCounty"></see></summary>
    let cvdFacilityCounty = _prefix "cvdFacilityCounty"
    /// <summary>
    /// Identifier of the NHSN facility that this data record applies to. Use [[cvdFacilityCounty]] to indicate the county. To provide other details, [[healthcareReportingData]] can be used on a [[Hospital]] entry.
    /// <see href="https://schema.org/cvdFacilityId"></see></summary>
    let cvdFacilityId = _prefix "cvdFacilityId"
    /// <summary>
    /// numbeds - HOSPITAL INPATIENT BEDS: Inpatient beds, including all staffed, licensed, and overflow (surge) beds used for inpatients.
    /// <see href="https://schema.org/cvdNumBeds"></see></summary>
    let cvdNumBeds = _prefix "cvdNumBeds"
    /// <summary>
    /// numbedsocc - HOSPITAL INPATIENT BED OCCUPANCY: Total number of staffed inpatient beds that are occupied.
    /// <see href="https://schema.org/cvdNumBedsOcc"></see></summary>
    let cvdNumBedsOcc = _prefix "cvdNumBedsOcc"
    /// <summary>
    /// numc19died - DEATHS: Patients with suspected or confirmed COVID-19 who died in the hospital, ED, or any overflow location.
    /// <see href="https://schema.org/cvdNumC19Died"></see></summary>
    let cvdNumC19Died = _prefix "cvdNumC19Died"
    /// <summary>
    /// numc19hopats - HOSPITAL ONSET: Patients hospitalized in an NHSN inpatient care location with onset of suspected or confirmed COVID-19 14 or more days after hospitalization.
    /// <see href="https://schema.org/cvdNumC19HOPats"></see></summary>
    let cvdNumC19HOPats = _prefix "cvdNumC19HOPats"
    /// <summary>
    /// numc19hosppats - HOSPITALIZED: Patients currently hospitalized in an inpatient care location who have suspected or confirmed COVID-19.
    /// <see href="https://schema.org/cvdNumC19HospPats"></see></summary>
    let cvdNumC19HospPats = _prefix "cvdNumC19HospPats"
    /// <summary>
    /// numc19mechventpats - HOSPITALIZED and VENTILATED: Patients hospitalized in an NHSN inpatient care location who have suspected or confirmed COVID-19 and are on a mechanical ventilator.
    /// <see href="https://schema.org/cvdNumC19MechVentPats"></see></summary>
    let cvdNumC19MechVentPats = _prefix "cvdNumC19MechVentPats"
    /// <summary>
    /// numc19ofmechventpats - ED/OVERFLOW and VENTILATED: Patients with suspected or confirmed COVID-19 who are in the ED or any overflow location awaiting an inpatient bed and on a mechanical ventilator.
    /// <see href="https://schema.org/cvdNumC19OFMechVentPats"></see></summary>
    let cvdNumC19OFMechVentPats = _prefix "cvdNumC19OFMechVentPats"
    /// <summary>
    /// numc19overflowpats - ED/OVERFLOW: Patients with suspected or confirmed COVID-19 who are in the ED or any overflow location awaiting an inpatient bed.
    /// <see href="https://schema.org/cvdNumC19OverflowPats"></see></summary>
    let cvdNumC19OverflowPats = _prefix "cvdNumC19OverflowPats"
    /// <summary>
    /// numicubeds - ICU BEDS: Total number of staffed inpatient intensive care unit (ICU) beds.
    /// <see href="https://schema.org/cvdNumICUBeds"></see></summary>
    let cvdNumICUBeds = _prefix "cvdNumICUBeds"
    /// <summary>
    /// numicubedsocc - ICU BED OCCUPANCY: Total number of staffed inpatient ICU beds that are occupied.
    /// <see href="https://schema.org/cvdNumICUBedsOcc"></see></summary>
    let cvdNumICUBedsOcc = _prefix "cvdNumICUBedsOcc"
    /// <summary>
    /// numtotbeds - ALL HOSPITAL BEDS: Total number of all inpatient and outpatient beds, including all staffed, ICU, licensed, and overflow (surge) beds used for inpatients or outpatients.
    /// <see href="https://schema.org/cvdNumTotBeds"></see></summary>
    let cvdNumTotBeds = _prefix "cvdNumTotBeds"
    /// <summary>
    /// numvent - MECHANICAL VENTILATORS: Total number of ventilators available.
    /// <see href="https://schema.org/cvdNumVent"></see></summary>
    let cvdNumVent = _prefix "cvdNumVent"
    /// <summary>
    /// numventuse - MECHANICAL VENTILATORS IN USE: Total number of ventilators in use.
    /// <see href="https://schema.org/cvdNumVentUse"></see></summary>
    let cvdNumVentUse = _prefix "cvdNumVentUse"
    /// <summary>
    /// Data associated with the event, like for instance a log message.
    /// <see href="https://schema.org/data"></see></summary>
    let data = _prefix "data"
    /// <summary>
    /// An item within a data feed. Data feeds may have many elements.
    /// <see href="https://schema.org/dataFeedElement"></see></summary>
    let dataFeedElement = _prefix "dataFeedElement"
    /// <summary>
    /// A dataset contained in this catalog.
    /// <see href="https://schema.org/dataset"></see></summary>
    let dataset = _prefix "dataset"
    /// <summary>
    /// The range of temporal applicability of a dataset, e.g. for a 2011 census dataset, the year 2011 (in ISO 8601 time interval format).
    /// <see href="https://schema.org/datasetTimeInterval"></see></summary>
    let datasetTimeInterval = _prefix "datasetTimeInterval"
    /// <summary>
    /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in [ISO 8601 time interval format](https://en.wikipedia.org/wiki/ISO_8601#Time_intervals). In
    ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content, e.g. ScholarlyArticle, Book, TVSeries or TVEpisode, may indicate their temporalCoverage in broader terms - textually or via well-known URL.
    ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".
    ///
    /// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated.
    /// <see href="https://schema.org/temporalCoverage"></see></summary>
    let temporalCoverage = _prefix "temporalCoverage"
    /// <summary>
    /// The date on which the CreativeWork was created or the item was added to a DataFeed.
    /// <see href="https://schema.org/dateCreated"></see></summary>
    let dateCreated = _prefix "dateCreated"
    /// <summary>
    /// The datetime the item was removed from the DataFeed.
    /// <see href="https://schema.org/dateDeleted"></see></summary>
    let dateDeleted = _prefix "dateDeleted"
    /// <summary>
    /// The date the ticket was issued.
    /// <see href="https://schema.org/dateIssued"></see></summary>
    let dateIssued = _prefix "dateIssued"
    /// <summary>
    /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
    /// <see href="https://schema.org/dateModified"></see></summary>
    let dateModified = _prefix "dateModified"
    /// <summary>
    /// Publication date of an online listing.
    /// <see href="https://schema.org/datePosted"></see></summary>
    let datePosted = _prefix "datePosted"
    /// <summary>
    /// Date of first publication or broadcast. For example the date a [[CreativeWork]] was broadcast or a [[Certification]] was issued.
    /// <see href="https://schema.org/datePublished"></see></summary>
    let datePublished = _prefix "datePublished"
    /// <summary>
    /// The date/time at which the message has been read by the recipient if a single recipient exists.
    /// <see href="https://schema.org/dateRead"></see></summary>
    let dateRead = _prefix "dateRead"
    /// <summary>
    /// The date/time the message was received if a single recipient exists.
    /// <see href="https://schema.org/dateReceived"></see></summary>
    let dateReceived = _prefix "dateReceived"
    /// <summary>
    /// The date/time at which the message was sent.
    /// <see href="https://schema.org/dateSent"></see></summary>
    let dateSent = _prefix "dateSent"
    /// <summary>
    /// The date of the first registration of the vehicle with the respective public authorities.
    /// <see href="https://schema.org/dateVehicleFirstRegistered"></see></summary>
    let dateVehicleFirstRegistered = _prefix "dateVehicleFirstRegistered"
    /// <summary>
    /// A [dateline](https://en.wikipedia.org/wiki/Dateline) is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.
    ///
    /// Structured representations of dateline-related information can also be expressed more explicitly using [[locationCreated]] (which represents where a work was created, e.g. where a news report was written).  For location depicted or described in the content, use [[contentLocation]].
    ///
    /// Dateline summaries are oriented more towards human readers than towards automated processing, and can vary substantially. Some examples: "BEIRUT, Lebanon, June 2.", "Paris, France", "December 19, 2017 11:43AM Reporting from Washington", "Beijing/Moscow", "QUEZON CITY, Philippines".
    ///
    /// <see href="https://schema.org/dateline"></see></summary>
    let dateline = _prefix "dateline"
    /// <summary>
    /// The day of the week for which these opening hours are valid.
    /// <see href="https://schema.org/dayOfWeek"></see></summary>
    let dayOfWeek = _prefix "dayOfWeek"
    /// <summary>
    /// Date of death.
    /// <see href="https://schema.org/deathDate"></see></summary>
    let deathDate = _prefix "deathDate"
    /// <summary>
    /// The place where the person died.
    /// <see href="https://schema.org/deathPlace"></see></summary>
    let deathPlace = _prefix "deathPlace"
    /// <summary>
    /// The default value of the input.  For properties that expect a literal, the default is a literal value, for properties that expect an object, it's an ID reference to one of the current values.
    /// <see href="https://schema.org/defaultValue"></see></summary>
    let defaultValue = _prefix "defaultValue"
    /// <summary>
    /// Destination address.
    /// <see href="https://schema.org/deliveryAddress"></see></summary>
    let deliveryAddress = _prefix "deliveryAddress"
    /// <summary>
    /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
    /// <see href="https://schema.org/deliveryLeadTime"></see></summary>
    let deliveryLeadTime = _prefix "deliveryLeadTime"
    /// <summary>
    /// A sub property of instrument. The method of delivery.
    /// <see href="https://schema.org/deliveryMethod"></see></summary>
    let deliveryMethod = _prefix "deliveryMethod"
    /// <summary>
    /// The object that helped the agent perform the action. E.g. John wrote a book with *a pen*.
    /// <see href="https://schema.org/instrument"></see></summary>
    let instrument = _prefix "instrument"
    /// <summary>
    /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
    /// <see href="https://schema.org/deliveryStatus"></see></summary>
    let deliveryStatus = _prefix "deliveryStatus"
    /// <summary>
    /// The total delay between the receipt of the order and the goods reaching the final customer.
    /// <see href="https://schema.org/deliveryTime"></see></summary>
    let deliveryTime = _prefix "deliveryTime"
    /// <summary>
    ///   <see href="https://schema.org/DeliveryTimeSettings"></see>
    /// </summary>
    let DeliveryTimeSettings = _prefix "DeliveryTimeSettings"
    /// <summary>
    /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
    /// <see href="https://schema.org/department"></see></summary>
    let department = _prefix "department"
    /// <summary>
    /// The airport where the flight originates.
    /// <see href="https://schema.org/departureAirport"></see></summary>
    let departureAirport = _prefix "departureAirport"
    /// <summary>
    /// The terminal or port from which the boat departs.
    /// <see href="https://schema.org/departureBoatTerminal"></see></summary>
    let departureBoatTerminal = _prefix "departureBoatTerminal"
    /// <summary>
    /// The stop or station from which the bus departs.
    /// <see href="https://schema.org/departureBusStop"></see></summary>
    let departureBusStop = _prefix "departureBusStop"
    /// <summary>
    /// Identifier of the flight's departure gate.
    /// <see href="https://schema.org/departureGate"></see></summary>
    let departureGate = _prefix "departureGate"
    /// <summary>
    /// The platform from which the train departs.
    /// <see href="https://schema.org/departurePlatform"></see></summary>
    let departurePlatform = _prefix "departurePlatform"
    /// <summary>
    /// The station from which the train departs.
    /// <see href="https://schema.org/departureStation"></see></summary>
    let departureStation = _prefix "departureStation"
    /// <summary>
    /// Identifier of the flight's departure terminal.
    /// <see href="https://schema.org/departureTerminal"></see></summary>
    let departureTerminal = _prefix "departureTerminal"
    /// <summary>
    /// The expected departure time.
    /// <see href="https://schema.org/departureTime"></see></summary>
    let departureTime = _prefix "departureTime"
    /// <summary>
    /// Prerequisites needed to fulfill steps in article.
    /// <see href="https://schema.org/dependencies"></see></summary>
    let dependencies = _prefix "dependencies"
    /// <summary>
    /// The depth of the item.
    /// <see href="https://schema.org/depth"></see></summary>
    let depth = _prefix "depth"
    /// <summary>
    /// A description of the item.
    /// <see href="https://schema.org/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
    /// <see href="https://schema.org/device"></see></summary>
    let device = _prefix "device"
    /// <summary>
    /// One or more alternative conditions considered in the differential diagnosis process as output of a diagnosis process.
    /// <see href="https://schema.org/diagnosis"></see></summary>
    let diagnosis = _prefix "diagnosis"
    /// <summary>
    /// An image containing a diagram that illustrates the structure and/or its component substructures and/or connections with other structures.
    /// <see href="https://schema.org/diagram"></see></summary>
    let diagram = _prefix "diagram"
    /// <summary>
    /// A sub property of instrument. The diet used in this action.
    /// <see href="https://schema.org/diet"></see></summary>
    let diet = _prefix "diet"
    /// <summary>
    /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
    /// <see href="https://schema.org/dietFeatures"></see></summary>
    let dietFeatures = _prefix "dietFeatures"
    /// <summary>
    /// One of a set of differential diagnoses for the condition. Specifically, a closely-related or competing diagnosis typically considered later in the cognitive process whereby this medical condition is distinguished from others most likely responsible for a similar collection of signs and symptoms to reach the most parsimonious diagnosis or diagnoses in a patient.
    /// <see href="https://schema.org/differentialDiagnosis"></see></summary>
    let differentialDiagnosis = _prefix "differentialDiagnosis"
    /// <summary>
    /// Indicates an IPTCDigitalSourceEnumeration code indicating the nature of the digital source(s) for some [[CreativeWork]].
    /// <see href="https://schema.org/digitalSourceType"></see></summary>
    let digitalSourceType = _prefix "digitalSourceType"
    /// <summary>
    /// Indicates whether an [[url]] that is associated with a [[JobPosting]] enables direct application for the job, via the posting website. A job posting is considered to have directApply of [[True]] if an application process for the specified job can be directly initiated via the url(s) given (noting that e.g. multiple internet domains might nevertheless be involved at an implementation level). A value of [[False]] is appropriate if there is no clear path to applying directly online for the specified job, navigating directly from the JobPosting url(s) supplied.
    /// <see href="https://schema.org/directApply"></see></summary>
    let directApply = _prefix "directApply"
    /// <summary>
    /// A director of e.g. TV, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
    /// <see href="https://schema.org/director"></see></summary>
    let director = _prefix "director"
    /// <summary>
    /// A director of e.g. TV, radio, movie, video games etc. content. Directors can be associated with individual items or with a series, episode, clip.
    /// <see href="https://schema.org/directors"></see></summary>
    let directors = _prefix "directors"
    /// <summary>
    /// A sub property of description. A short description of the item used to disambiguate from other, similar items. Information from other properties (in particular, name) may be necessary for the description to be useful for disambiguation.
    /// <see href="https://schema.org/disambiguatingDescription"></see></summary>
    let disambiguatingDescription = _prefix "disambiguatingDescription"
    /// <summary>
    /// Any discount applied (to an Order).
    /// <see href="https://schema.org/discount"></see></summary>
    let discount = _prefix "discount"
    /// <summary>
    /// Code used to redeem a discount.
    /// <see href="https://schema.org/discountCode"></see></summary>
    let discountCode = _prefix "discountCode"
    /// <summary>
    /// The currency of the discount.\n\nUse standard formats: [ISO 4217 currency format](http://en.wikipedia.org/wiki/ISO_4217), e.g. "USD"; [Ticker symbol](https://en.wikipedia.org/wiki/List_of_cryptocurrencies) for cryptocurrencies, e.g. "BTC"; well known names for [Local Exchange Trading Systems](https://en.wikipedia.org/wiki/Local_exchange_trading_system) (LETS) and other currency types, e.g. "Ithaca HOUR".
    /// <see href="https://schema.org/discountCurrency"></see></summary>
    let discountCurrency = _prefix "discountCurrency"
    /// <summary>
    /// Specifies the CreativeWork associated with the UserComment.
    /// <see href="https://schema.org/discusses"></see></summary>
    let discusses = _prefix "discusses"
    /// <summary>
    /// A link to the page containing the comments of the CreativeWork.
    /// <see href="https://schema.org/discussionUrl"></see></summary>
    let discussionUrl = _prefix "discussionUrl"
    /// <summary>
    /// Information about disease prevention.
    /// <see href="https://schema.org/diseasePreventionInfo"></see></summary>
    let diseasePreventionInfo = _prefix "diseasePreventionInfo"
    /// <summary>
    /// Statistical information about the spread of a disease, either as [[WebContent]], or
    ///   described directly as a [[Dataset]], or the specific [[Observation]]s in the dataset. When a [[WebContent]] URL is
    ///   provided, the page indicated might also contain more such markup.
    /// <see href="https://schema.org/diseaseSpreadStatistics"></see></summary>
    let diseaseSpreadStatistics = _prefix "diseaseSpreadStatistics"
    /// <summary>
    /// The location at which an item can be viewed or experienced in-person.
    /// <see href="https://schema.org/displayLocation"></see></summary>
    let displayLocation = _prefix "displayLocation"
    /// <summary>
    /// The date that this organization was dissolved.
    /// <see href="https://schema.org/dissolutionDate"></see></summary>
    let dissolutionDate = _prefix "dissolutionDate"
    /// <summary>
    /// The distance travelled, e.g. exercising or travelling.
    /// <see href="https://schema.org/distance"></see></summary>
    let distance = _prefix "distance"
    /// <summary>
    /// One of a set of signs and symptoms that can be used to distinguish this diagnosis from others in the differential diagnosis.
    /// <see href="https://schema.org/distinguishingSign"></see></summary>
    let distinguishingSign = _prefix "distinguishingSign"
    /// <summary>
    /// A downloadable form of this dataset, at a specific location, in a specific format. This property can be repeated if different variations are available. There is no expectation that different downloadable distributions must contain exactly equivalent information (see also [DCAT](https://www.w3.org/TR/vocab-dcat-3/#Class:Distribution) on this point). Different distributions might include or exclude different subsets of the entire dataset, for example.
    /// <see href="https://schema.org/distribution"></see></summary>
    let distribution = _prefix "distribution"
    /// <summary>
    /// Statement on diversity policy by an [[Organization]] e.g. a [[NewsMediaOrganization]]. For a [[NewsMediaOrganization]], a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
    /// <see href="https://schema.org/diversityPolicy"></see></summary>
    let diversityPolicy = _prefix "diversityPolicy"
    /// <summary>
    /// For an [[Organization]] (often but not necessarily a [[NewsMediaOrganization]]), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
    /// <see href="https://schema.org/diversityStaffingReport"></see></summary>
    let diversityStaffingReport = _prefix "diversityStaffingReport"
    /// <summary>
    /// Further documentation describing the Web API in more detail.
    /// <see href="https://schema.org/documentation"></see></summary>
    let documentation = _prefix "documentation"
    /// <summary>
    /// Indicates when shipping to a particular [[shippingDestination]] is not available.
    /// <see href="https://schema.org/doesNotShip"></see></summary>
    let doesNotShip = _prefix "doesNotShip"
    /// <summary>
    /// Whether borrower is a resident of the jurisdiction where the property is located.
    /// <see href="https://schema.org/domiciledMortgage"></see></summary>
    let domiciledMortgage = _prefix "domiciledMortgage"
    /// <summary>
    /// The time admission will commence.
    /// <see href="https://schema.org/doorTime"></see></summary>
    let doorTime = _prefix "doorTime"
    /// <summary>
    /// A dosage form in which this drug/supplement is available, e.g. 'tablet', 'suspension', 'injection'.
    /// <see href="https://schema.org/dosageForm"></see></summary>
    let dosageForm = _prefix "dosageForm"
    /// <summary>
    /// A dosing schedule for the drug for a given population, either observed, recommended, or maximum dose based on the type used.
    /// <see href="https://schema.org/doseSchedule"></see></summary>
    let doseSchedule = _prefix "doseSchedule"
    /// <summary>
    /// The unit of the dose, e.g. 'mg'.
    /// <see href="https://schema.org/doseUnit"></see></summary>
    let doseUnit = _prefix "doseUnit"
    /// <summary>
    /// The value of the dose, e.g. 500.
    /// <see href="https://schema.org/doseValue"></see></summary>
    let doseValue = _prefix "doseValue"
    /// <summary>
    /// a type of payment made in cash during the onset of the purchase of an expensive good/service. The payment typically represents only a percentage of the full purchase price.
    /// <see href="https://schema.org/downPayment"></see></summary>
    let downPayment = _prefix "downPayment"
    /// <summary>
    /// If the file can be downloaded, URL to download the binary.
    /// <see href="https://schema.org/downloadUrl"></see></summary>
    let downloadUrl = _prefix "downloadUrl"
    /// <summary>
    /// The number of downvotes this question, answer or comment has received from the community.
    /// <see href="https://schema.org/downvoteCount"></see></summary>
    let downvoteCount = _prefix "downvoteCount"
    /// <summary>
    /// The vasculature that the vein drains into.
    /// <see href="https://schema.org/drainsTo"></see></summary>
    let drainsTo = _prefix "drainsTo"
    /// <summary>
    /// The drive wheel configuration, i.e. which roadwheels will receive torque from the vehicle's engine via the drivetrain.
    /// <see href="https://schema.org/driveWheelConfiguration"></see></summary>
    let driveWheelConfiguration = _prefix "driveWheelConfiguration"
    /// <summary>
    /// Where a rental car can be dropped off.
    /// <see href="https://schema.org/dropoffLocation"></see></summary>
    let dropoffLocation = _prefix "dropoffLocation"
    /// <summary>
    /// When a rental car can be dropped off.
    /// <see href="https://schema.org/dropoffTime"></see></summary>
    let dropoffTime = _prefix "dropoffTime"
    /// <summary>
    /// Specifying a drug or medicine used in a medication procedure.
    /// <see href="https://schema.org/drug"></see></summary>
    let drug = _prefix "drug"
    /// <summary>
    /// The class of drug this belongs to (e.g., statins).
    /// <see href="https://schema.org/drugClass"></see></summary>
    let drugClass = _prefix "drugClass"
    /// <summary>
    /// The unit in which the drug is measured, e.g. '5 mg tablet'.
    /// <see href="https://schema.org/drugUnit"></see></summary>
    let drugUnit = _prefix "drugUnit"
    /// <summary>
    /// The Dun &amp; Bradstreet DUNS number for identifying an organization or business person.
    /// <see href="https://schema.org/duns"></see></summary>
    let duns = _prefix "duns"
    /// <summary>
    /// A therapy that duplicates or overlaps this one.
    /// <see href="https://schema.org/duplicateTherapy"></see></summary>
    let duplicateTherapy = _prefix "duplicateTherapy"
    /// <summary>
    /// The duration of the item (movie, audio recording, event, etc.) in [ISO 8601 duration format](http://en.wikipedia.org/wiki/ISO_8601).
    /// <see href="https://schema.org/duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.
    /// <see href="https://schema.org/durationOfWarranty"></see></summary>
    let durationOfWarranty = _prefix "durationOfWarranty"
    /// <summary>
    /// A media object representing the circumstances while performing this direction.
    /// <see href="https://schema.org/duringMedia"></see></summary>
    let duringMedia = _prefix "duringMedia"
    /// <summary>
    /// The amount to be paid as a penalty in the event of early payment of the loan.
    /// <see href="https://schema.org/earlyPrepaymentPenalty"></see></summary>
    let earlyPrepaymentPenalty = _prefix "earlyPrepaymentPenalty"
    /// <summary>
    /// An [EIDR](https://eidr.org/) (Entertainment Identifier Registry) [[identifier]] representing a specific edit / edition for a work of film or television.
    ///
    /// For example, the motion picture known as "Ghostbusters" whose [[titleEIDR]] is "10.5240/7EC7-228A-510A-053E-CBB8-J" has several edits, e.g. "10.5240/1F2A-E1C5-680A-14C6-E76B-I" and "10.5240/8A35-3BEE-6497-5D12-9E4F-3".
    ///
    /// Since schema.org types like [[Movie]] and [[TVEpisode]] can be used for both works and their multiple expressions, it is possible to use [[titleEIDR]] alone (for a general description), or alongside [[editEIDR]] for a more edit-specific description.
    ///
    /// <see href="https://schema.org/editEIDR"></see></summary>
    let editEIDR = _prefix "editEIDR"
    /// <summary>
    /// Specifies the Person who edited the CreativeWork.
    /// <see href="https://schema.org/editor"></see></summary>
    let editor = _prefix "editor"
    /// <summary>
    /// For questions that are part of learning resources (e.g. Quiz), eduQuestionType indicates the format of question being given. Example: "Multiple choice", "Open ended", "Flashcard".
    /// <see href="https://schema.org/eduQuestionType"></see></summary>
    let eduQuestionType = _prefix "eduQuestionType"
    /// <summary>
    /// Educational background needed for the position or Occupation.
    /// <see href="https://schema.org/educationRequirements"></see></summary>
    let educationRequirements = _prefix "educationRequirements"
    /// <summary>
    /// An alignment to an established educational framework.
    ///
    /// This property should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource [[teaches]] or [[assesses]] a competency.
    /// <see href="https://schema.org/educationalAlignment"></see></summary>
    let educationalAlignment = _prefix "educationalAlignment"
    /// <summary>
    /// A description of the qualification, award, certificate, diploma or other educational credential awarded as a consequence of successful completion of this course or program.
    /// <see href="https://schema.org/educationalCredentialAwarded"></see></summary>
    let educationalCredentialAwarded = _prefix "educationalCredentialAwarded"
    /// <summary>
    /// The framework to which the resource being described is aligned.
    /// <see href="https://schema.org/educationalFramework"></see></summary>
    let educationalFramework = _prefix "educationalFramework"
    /// <summary>
    /// The level in terms of progression through an educational or training context. Examples of educational levels include 'beginner', 'intermediate' or 'advanced', and formal sets of level indicators.
    /// <see href="https://schema.org/educationalLevel"></see></summary>
    let educationalLevel = _prefix "educationalLevel"
    /// <summary>
    /// Similar to courseMode, the medium or means of delivery of the program as a whole. The value may either be a text label (e.g. "online", "onsite" or "blended"; "synchronous" or "asynchronous"; "full-time" or "part-time") or a URL reference to a term from a controlled vocabulary (e.g. https://ceds.ed.gov/element/001311#Asynchronous ).
    /// <see href="https://schema.org/educationalProgramMode"></see></summary>
    let educationalProgramMode = _prefix "educationalProgramMode"
    /// <summary>
    /// An educationalRole of an EducationalAudience.
    /// <see href="https://schema.org/educationalRole"></see></summary>
    let educationalRole = _prefix "educationalRole"
    /// <summary>
    /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
    /// <see href="https://schema.org/educationalUse"></see></summary>
    let educationalUse = _prefix "educationalUse"
    /// <summary>
    /// The elevation of a location ([WGS 84](https://en.wikipedia.org/wiki/World_Geodetic_System)). Values may be of the form 'NUMBER UNIT\_OF\_MEASUREMENT' (e.g., '1,000 m', '3,200 ft') while numbers alone should be assumed to be a value in meters.
    /// <see href="https://schema.org/elevation"></see></summary>
    let elevation = _prefix "elevation"
    /// <summary>
    /// The legal requirements such as citizenship, visa and other documentation required for an applicant to this job.
    /// <see href="https://schema.org/eligibilityToWorkRequirement"></see></summary>
    let eligibilityToWorkRequirement = _prefix "eligibilityToWorkRequirement"
    /// <summary>
    /// The type(s) of customers for which the given offer is valid.
    /// <see href="https://schema.org/eligibleCustomerType"></see></summary>
    let eligibleCustomerType = _prefix "eligibleCustomerType"
    /// <summary>
    /// The duration for which the given offer is valid.
    /// <see href="https://schema.org/eligibleDuration"></see></summary>
    let eligibleDuration = _prefix "eligibleDuration"
    /// <summary>
    /// The interval and unit of measurement of ordering quantities for which the offer or price specification is valid. This allows e.g. specifying that a certain freight charge is valid only for a certain quantity.
    /// <see href="https://schema.org/eligibleQuantity"></see></summary>
    let eligibleQuantity = _prefix "eligibleQuantity"
    /// <summary>
    /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is valid.\n\nSee also [[ineligibleRegion]].
    ///
    /// <see href="https://schema.org/eligibleRegion"></see></summary>
    let eligibleRegion = _prefix "eligibleRegion"
    /// <summary>
    /// The transaction volume, in a monetary unit, for which the offer or price specification is valid, e.g. for indicating a minimal purchasing volume, to express free shipping above a certain order volume, or to limit the acceptance of credit cards to purchases to a certain minimal amount.
    /// <see href="https://schema.org/eligibleTransactionVolume"></see></summary>
    let eligibleTransactionVolume = _prefix "eligibleTransactionVolume"
    /// <summary>
    /// The supplier of the incentivized item/service for which the incentive is valid for such as a utility company, merchant, or contractor.
    /// <see href="https://schema.org/eligibleWithSupplier"></see></summary>
    let eligibleWithSupplier = _prefix "eligibleWithSupplier"
    /// <summary>
    /// Email address.
    /// <see href="https://schema.org/email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// A URL pointing to a player for a specific video. In general, this is the information in the ```src``` element of an ```embed``` tag and should not be the same as the content of the ```loc``` tag.
    /// <see href="https://schema.org/embedUrl"></see></summary>
    let embedUrl = _prefix "embedUrl"
    /// <summary>
    /// Represents textual captioning from a [[MediaObject]], e.g. text of a 'meme'.
    /// <see href="https://schema.org/embeddedTextCaption"></see></summary>
    let embeddedTextCaption = _prefix "embeddedTextCaption"
    /// <summary>
    /// The CO2 emissions in g/km. When used in combination with a QuantitativeValue, put "g/km" into the unitText property of that value, since there is no UN/CEFACT Common Code for "g/km".
    /// <see href="https://schema.org/emissionsCO2"></see></summary>
    let emissionsCO2 = _prefix "emissionsCO2"
    /// <summary>
    /// Someone working for this organization.
    /// <see href="https://schema.org/employee"></see></summary>
    let employee = _prefix "employee"
    /// <summary>
    /// People working for this organization.
    /// <see href="https://schema.org/employees"></see></summary>
    let employees = _prefix "employees"
    /// <summary>
    /// A description of the employer, career opportunities and work environment for this position.
    /// <see href="https://schema.org/employerOverview"></see></summary>
    let employerOverview = _prefix "employerOverview"
    /// <summary>
    /// Type of employment (e.g. full-time, part-time, contract, temporary, seasonal, internship).
    /// <see href="https://schema.org/employmentType"></see></summary>
    let employmentType = _prefix "employmentType"
    /// <summary>
    /// Indicates the department, unit and/or facility where the employee reports and/or in which the job is to be performed.
    /// <see href="https://schema.org/employmentUnit"></see></summary>
    let employmentUnit = _prefix "employmentUnit"
    /// <summary>
    /// Another BioChemEntity encoded by this one.
    /// <see href="https://schema.org/encodesBioChemEntity"></see></summary>
    let encodesBioChemEntity = _prefix "encodesBioChemEntity"
    /// <summary>
    /// Another BioChemEntity encoding by this one.
    /// <see href="https://schema.org/isEncodedByBioChemEntity"></see></summary>
    let isEncodedByBioChemEntity = _prefix "isEncodedByBioChemEntity"
    /// <summary>
    /// The CreativeWork encoded by this media object.
    /// <see href="https://schema.org/encodesCreativeWork"></see></summary>
    let encodesCreativeWork = _prefix "encodesCreativeWork"
    /// <summary>
    /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
    /// <see href="https://schema.org/encoding"></see></summary>
    let encoding = _prefix "encoding"
    /// <summary>
    /// Media type typically expressed using a MIME format (see [IANA site](http://www.iana.org/assignments/media-types/media-types.xhtml) and [MDN reference](https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types)), e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.
    ///
    /// In cases where a [[CreativeWork]] has several media type representations, [[encoding]] can be used to indicate each [[MediaObject]] alongside particular [[encodingFormat]] information.
    ///
    /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
    /// <see href="https://schema.org/encodingFormat"></see></summary>
    let encodingFormat = _prefix "encodingFormat"
    /// <summary>
    /// The supported encoding type(s) for an EntryPoint request.
    /// <see href="https://schema.org/encodingType"></see></summary>
    let encodingType = _prefix "encodingType"
    /// <summary>
    /// A media object that encodes this CreativeWork.
    /// <see href="https://schema.org/encodings"></see></summary>
    let encodings = _prefix "encodings"
    /// <summary>
    /// The end date and time of the item (in [ISO 8601 date format](http://en.wikipedia.org/wiki/ISO_8601)).
    /// <see href="https://schema.org/endDate"></see></summary>
    let endDate = _prefix "endDate"
    /// <summary>
    /// The end time of the clip expressed as the number of seconds from the beginning of the work.
    /// <see href="https://schema.org/endOffset"></see></summary>
    let endOffset = _prefix "endOffset"
    /// <summary>
    /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. E.g. John wrote a book from January to *December*. For media, including audio and video, it's the time offset of the end of a clip within a larger file.\n\nNote that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
    /// <see href="https://schema.org/endTime"></see></summary>
    let endTime = _prefix "endTime"
    /// <summary>
    /// A sub property of participant. The person/organization being supported.
    /// <see href="https://schema.org/endorsee"></see></summary>
    let endorsee = _prefix "endorsee"
    /// <summary>
    /// People or organizations that endorse the plan.
    /// <see href="https://schema.org/endorsers"></see></summary>
    let endorsers = _prefix "endorsers"
    /// <summary>
    /// Specifies the most energy efficient class on the regulated EU energy consumption scale for the product category a product belongs to. For example, energy consumption for televisions placed on the market after January 1, 2020 is scaled from D to A+++.
    /// <see href="https://schema.org/energyEfficiencyScaleMax"></see></summary>
    let energyEfficiencyScaleMax = _prefix "energyEfficiencyScaleMax"
    /// <summary>
    /// Specifies the least energy efficient class on the regulated EU energy consumption scale for the product category a product belongs to. For example, energy consumption for televisions placed on the market after January 1, 2020 is scaled from D to A+++.
    /// <see href="https://schema.org/energyEfficiencyScaleMin"></see></summary>
    let energyEfficiencyScaleMin = _prefix "energyEfficiencyScaleMin"
    /// <summary>
    /// The volume swept by all of the pistons inside the cylinders of an internal combustion engine in a single movement. \n\nTypical unit code(s): CMQ for cubic centimeter, LTR for liters, INQ for cubic inches\n* Note 1: You can link to information about how the given value has been determined using the [[valueReference]] property.\n* Note 2: You can use [[minValue]] and [[maxValue]] to indicate ranges.
    /// <see href="https://schema.org/engineDisplacement"></see></summary>
    let engineDisplacement = _prefix "engineDisplacement"
    /// <summary>
    /// The power of the vehicle's engine.
    ///     Typical unit code(s): KWT for kilowatt, BHP for brake horsepower, N12 for metric horsepower (PS, with 1 PS = 735,49875 W)\n\n* Note 1: There are many different ways of measuring an engine's power. For an overview, see  [http://en.wikipedia.org/wiki/Horsepower#Engine\_power\_test\_codes](http://en.wikipedia.org/wiki/Horsepower#Engine_power_test_codes).\n* Note 2: You can link to information about how the given value has been determined using the [[valueReference]] property.\n* Note 3: You can use [[minValue]] and [[maxValue]] to indicate ranges.
    /// <see href="https://schema.org/enginePower"></see></summary>
    let enginePower = _prefix "enginePower"
    /// <summary>
    /// The type of engine or engines powering the vehicle.
    /// <see href="https://schema.org/engineType"></see></summary>
    let engineType = _prefix "engineType"
    /// <summary>
    /// A sub property of location. The entertainment business where the action occurred.
    /// <see href="https://schema.org/entertainmentBusiness"></see></summary>
    let entertainmentBusiness = _prefix "entertainmentBusiness"
    /// <summary>
    /// The characteristics of associated patients, such as age, gender, race etc.
    /// <see href="https://schema.org/epidemiology"></see></summary>
    let epidemiology = _prefix "epidemiology"
    /// <summary>
    /// An episode of a TV, radio or game media within a series or season.
    /// <see href="https://schema.org/episode"></see></summary>
    let episode = _prefix "episode"
    /// <summary>
    /// Position of the episode within an ordered group of episodes.
    /// <see href="https://schema.org/episodeNumber"></see></summary>
    let episodeNumber = _prefix "episodeNumber"
    /// <summary>
    /// An episode of a TV/radio series or season.
    /// <see href="https://schema.org/episodes"></see></summary>
    let episodes = _prefix "episodes"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is equal to the object.
    /// <see href="https://schema.org/equal"></see></summary>
    let equal = _prefix "equal"
    /// <summary>
    /// For failed actions, more information on the cause of the failure. Consider using the Error type.
    /// <see href="https://schema.org/error"></see></summary>
    let error = _prefix "error"
    /// <summary>
    /// Application or platform dependant error code.
    /// <see href="https://schema.org/errorCode"></see></summary>
    let errorCode = _prefix "errorCode"
    /// <summary>
    /// The estimated cost of the supply or supplies consumed when performing instructions.
    /// <see href="https://schema.org/estimatedCost"></see></summary>
    let estimatedCost = _prefix "estimatedCost"
    /// <summary>
    /// The estimated time the flight will take.
    /// <see href="https://schema.org/estimatedFlightDuration"></see></summary>
    let estimatedFlightDuration = _prefix "estimatedFlightDuration"
    /// <summary>
    /// An estimated salary for a job posting or occupation, based on a variety of variables including, but not limited to industry, job title, and location. Estimated salaries  are often computed by outside organizations rather than the hiring organization, who may not have committed to the estimated value.
    /// <see href="https://schema.org/estimatedSalary"></see></summary>
    let estimatedSalary = _prefix "estimatedSalary"
    /// <summary>
    /// The condition, complication, or symptom whose risk is being estimated.
    /// <see href="https://schema.org/estimatesRiskOf"></see></summary>
    let estimatesRiskOf = _prefix "estimatesRiskOf"
    /// <summary>
    /// Statement about ethics policy, e.g. of a [[NewsMediaOrganization]] regarding journalistic and publishing practices, or of a [[Restaurant]], a page describing food source policies. In the case of a [[NewsMediaOrganization]], an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
    /// <see href="https://schema.org/ethicsPolicy"></see></summary>
    let ethicsPolicy = _prefix "ethicsPolicy"
    /// <summary>
    /// Upcoming or past event associated with this place, organization, or action.
    /// <see href="https://schema.org/event"></see></summary>
    let event_ = _prefix "event"
    /// <summary>
    /// The eventAttendanceMode of an event indicates whether it occurs online, offline, or a mix.
    /// <see href="https://schema.org/eventAttendanceMode"></see></summary>
    let eventAttendanceMode = _prefix "eventAttendanceMode"
    /// <summary>
    /// Associates an [[Event]] with a [[Schedule]]. There are circumstances where it is preferable to share a schedule for a series of
    ///       repeating events rather than data on the individual events themselves. For example, a website or application might prefer to publish a schedule for a weekly
    ///       gym class rather than provide data on every event. A schedule could be processed by applications to add forthcoming events to a calendar. An [[Event]] that
    ///       is associated with a [[Schedule]] using this property should not have [[startDate]] or [[endDate]] properties. These are instead defined within the associated
    ///       [[Schedule]], this avoids any ambiguity for clients using the data. The property might have repeated values to specify different schedules, e.g. for different months
    ///       or seasons.
    /// <see href="https://schema.org/eventSchedule"></see></summary>
    let eventSchedule = _prefix "eventSchedule"
    /// <summary>
    /// An eventStatus of an event represents its status; particularly useful when an event is cancelled or rescheduled.
    /// <see href="https://schema.org/eventStatus"></see></summary>
    let eventStatus = _prefix "eventStatus"
    /// <summary>
    /// Upcoming or past events associated with this place or organization.
    /// <see href="https://schema.org/events"></see></summary>
    let events = _prefix "events"
    /// <summary>
    /// Strength of evidence of the data used to formulate the guideline (enumerated).
    /// <see href="https://schema.org/evidenceLevel"></see></summary>
    let evidenceLevel = _prefix "evidenceLevel"
    /// <summary>
    /// Source of the data used to formulate the guidance, e.g. RCT, consensus opinion, etc.
    /// <see href="https://schema.org/evidenceOrigin"></see></summary>
    let evidenceOrigin = _prefix "evidenceOrigin"
    /// <summary>
    /// A creative work that this work is an example/instance/realization/derivation of.
    /// <see href="https://schema.org/exampleOfWork"></see></summary>
    let exampleOfWork = _prefix "exampleOfWork"
    /// <summary>
    /// Defines a [[Date]] or [[DateTime]] during which a scheduled [[Event]] will not take place. The property allows exceptions to
    ///       a [[Schedule]] to be specified. If an exception is specified as a [[DateTime]] then only the event that would have started at that specific date and time
    ///       should be excluded from the schedule. If an exception is specified as a [[Date]] then any event that is scheduled for that 24 hour period should be
    ///       excluded from the schedule. This allows a whole day to be excluded from the schedule without having to itemise every scheduled event.
    /// <see href="https://schema.org/exceptDate"></see></summary>
    let exceptDate = _prefix "exceptDate"
    /// <summary>
    /// The difference between the price at which a broker or other intermediary buys and sells foreign currency.
    /// <see href="https://schema.org/exchangeRateSpread"></see></summary>
    let exchangeRateSpread = _prefix "exchangeRateSpread"
    /// <summary>
    /// A sub property of instrument. The exercise plan used on this action.
    /// <see href="https://schema.org/exercisePlan"></see></summary>
    let exercisePlan = _prefix "exercisePlan"
    /// <summary>
    /// A sub property of instrument. The diet used in this action.
    /// <see href="https://schema.org/exerciseRelatedDiet"></see></summary>
    let exerciseRelatedDiet = _prefix "exerciseRelatedDiet"
    /// <summary>
    /// Type(s) of exercise or activity, such as strength training, flexibility training, aerobics, cardiac rehabilitation, etc.
    /// <see href="https://schema.org/exerciseType"></see></summary>
    let exerciseType = _prefix "exerciseType"
    /// <summary>
    /// exif data for this object.
    /// <see href="https://schema.org/exifData"></see></summary>
    let exifData = _prefix "exifData"
    /// <summary>
    /// The earliest date the package may arrive.
    /// <see href="https://schema.org/expectedArrivalFrom"></see></summary>
    let expectedArrivalFrom = _prefix "expectedArrivalFrom"
    /// <summary>
    /// The latest date the package may arrive.
    /// <see href="https://schema.org/expectedArrivalUntil"></see></summary>
    let expectedArrivalUntil = _prefix "expectedArrivalUntil"
    /// <summary>
    /// The likely outcome in either the short term or long term of the medical condition.
    /// <see href="https://schema.org/expectedPrognosis"></see></summary>
    let expectedPrognosis = _prefix "expectedPrognosis"
    /// <summary>
    /// An Offer which must be accepted before the user can perform the Action. For example, the user may need to buy a movie before being able to watch it.
    /// <see href="https://schema.org/expectsAcceptanceOf"></see></summary>
    let expectsAcceptanceOf = _prefix "expectsAcceptanceOf"
    /// <summary>
    /// Indicates whether a [[JobPosting]] will accept experience (as indicated by [[OccupationalExperienceRequirements]]) in place of its formal educational qualifications (as indicated by [[educationRequirements]]). If true, indicates that satisfying one of these requirements is sufficient.
    /// <see href="https://schema.org/experienceInPlaceOfEducation"></see></summary>
    let experienceInPlaceOfEducation = _prefix "experienceInPlaceOfEducation"
    /// <summary>
    /// Description of skills and experience needed for the position or Occupation.
    /// <see href="https://schema.org/experienceRequirements"></see></summary>
    let experienceRequirements = _prefix "experienceRequirements"
    /// <summary>
    /// Medical expert advice related to the plan.
    /// <see href="https://schema.org/expertConsiderations"></see></summary>
    let expertConsiderations = _prefix "expertConsiderations"
    /// <summary>
    /// Date the content expires and is no longer useful or available. For example a [[VideoObject]] or [[NewsArticle]] whose availability or relevance is time-limited, a [[ClaimReview]] fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date, or a [[Certification]] the validity has expired.
    /// <see href="https://schema.org/expires"></see></summary>
    let expires = _prefix "expires"
    /// <summary>
    /// Tissue, organ, biological sample, etc in which activity of this gene has been observed experimentally. For example brain, digestive system.
    /// <see href="https://schema.org/expressedIn"></see></summary>
    let expressedIn = _prefix "expressedIn"
    /// <summary>
    /// An address extension such as an apartment number, C/O or alternative name.
    /// <see href="https://schema.org/extendedAddress"></see></summary>
    let extendedAddress = _prefix "extendedAddress"
    /// <summary>
    /// Family name. In the U.S., the last name of a Person.
    /// <see href="https://schema.org/familyName"></see></summary>
    let familyName = _prefix "familyName"
    /// <summary>
    /// The number of grams of fat.
    /// <see href="https://schema.org/fatContent"></see></summary>
    let fatContent = _prefix "fatContent"
    /// <summary>
    /// The fax number.
    /// <see href="https://schema.org/faxNumber"></see></summary>
    let faxNumber = _prefix "faxNumber"
    /// <summary>
    /// Features or modules provided by this application (and possibly required by other applications).
    /// <see href="https://schema.org/featureList"></see></summary>
    let featureList = _prefix "featureList"
    /// <summary>
    /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
    /// <see href="https://schema.org/feesAndCommissionsSpecification"></see></summary>
    let feesAndCommissionsSpecification = _prefix "feesAndCommissionsSpecification"
    /// <summary>
    /// The number of grams of fiber.
    /// <see href="https://schema.org/fiberContent"></see></summary>
    let fiberContent = _prefix "fiberContent"
    /// <summary>
    /// Media type, typically MIME format (see [IANA site](http://www.iana.org/assignments/media-types/media-types.xhtml)) of the content, e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.
    /// <see href="https://schema.org/fileFormat"></see></summary>
    let fileFormat = _prefix "fileFormat"
    /// <summary>
    /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
    /// <see href="https://schema.org/fileSize"></see></summary>
    let fileSize = _prefix "fileSize"
    /// <summary>
    /// A financial aid type or program which students may use to pay for tuition or fees associated with the program.
    /// <see href="https://schema.org/financialAidEligible"></see></summary>
    let financialAidEligible = _prefix "financialAidEligible"
    /// <summary>
    /// Indicates the first known occurrence of a [[Claim]] in some [[CreativeWork]].
    /// <see href="https://schema.org/firstAppearance"></see></summary>
    let firstAppearance = _prefix "firstAppearance"
    /// <summary>
    /// The date and place the work was first performed.
    /// <see href="https://schema.org/firstPerformance"></see></summary>
    let firstPerformance = _prefix "firstPerformance"
    /// <summary>
    /// The distance of the flight.
    /// <see href="https://schema.org/flightDistance"></see></summary>
    let flightDistance = _prefix "flightDistance"
    /// <summary>
    /// The unique identifier for a flight including the airline IATA code. For example, if describing United flight 110, where the IATA code for United is 'UA', the flightNumber is 'UA110'.
    /// <see href="https://schema.org/flightNumber"></see></summary>
    let flightNumber = _prefix "flightNumber"
    /// <summary>
    /// The floor level for an [[Accommodation]] in a multi-storey building. Since counting
    ///   systems [vary internationally](https://en.wikipedia.org/wiki/Storey#Consecutive_number_floor_designations), the local system should be used where possible.
    /// <see href="https://schema.org/floorLevel"></see></summary>
    let floorLevel = _prefix "floorLevel"
    /// <summary>
    /// A floor limit is the amount of money above which credit card transactions must be authorized.
    /// <see href="https://schema.org/floorLimit"></see></summary>
    let floorLimit = _prefix "floorLimit"
    /// <summary>
    /// The size of the accommodation, e.g. in square meter or squarefoot.
    /// Typical unit code(s): MTK for square meter, FTK for square foot, or YDK for square yard.
    /// <see href="https://schema.org/floorSize"></see></summary>
    let floorSize = _prefix "floorSize"
    /// <summary>
    /// A sub property of object. The person or organization being followed.
    /// <see href="https://schema.org/followee"></see></summary>
    let followee = _prefix "followee"
    /// <summary>
    /// The most generic uni-directional social relation.
    /// <see href="https://schema.org/follows"></see></summary>
    let follows = _prefix "follows"
    /// <summary>
    /// Typical or recommended followup care after the procedure is performed.
    /// <see href="https://schema.org/followup"></see></summary>
    let followup = _prefix "followup"
    /// <summary>
    /// A sub property of location. The specific food establishment where the action occurred.
    /// <see href="https://schema.org/foodEstablishment"></see></summary>
    let foodEstablishment = _prefix "foodEstablishment"
    /// <summary>
    /// A sub property of location. The specific food event where the action occurred.
    /// <see href="https://schema.org/foodEvent"></see></summary>
    let foodEvent = _prefix "foodEvent"
    /// <summary>
    /// Any precaution, guidance, contraindication, etc. related to consumption of specific foods while taking this drug.
    /// <see href="https://schema.org/foodWarning"></see></summary>
    let foodWarning = _prefix "foodWarning"
    /// <summary>
    /// A person or organization who founded this organization.
    /// <see href="https://schema.org/founder"></see></summary>
    let founder = _prefix "founder"
    /// <summary>
    /// A person who founded this organization.
    /// <see href="https://schema.org/founders"></see></summary>
    let founders = _prefix "founders"
    /// <summary>
    /// The date that this organization was founded.
    /// <see href="https://schema.org/foundingDate"></see></summary>
    let foundingDate = _prefix "foundingDate"
    /// <summary>
    /// The place where the Organization was founded.
    /// <see href="https://schema.org/foundingLocation"></see></summary>
    let foundingLocation = _prefix "foundingLocation"
    /// <summary>
    /// A flag to signal that the item, event, or place is accessible for free.
    /// <see href="https://schema.org/free"></see></summary>
    let free = _prefix "free"
    /// <summary>
    /// A flag to signal that the item, event, or place is accessible for free.
    /// <see href="https://schema.org/isAccessibleForFree"></see></summary>
    let isAccessibleForFree = _prefix "isAccessibleForFree"
    /// <summary>
    /// A monetary value above (or at) which the shipping rate becomes free. Intended to be used via an [[OfferShippingDetails]] with [[shippingSettingsLink]] matching this [[ShippingRateSettings]].
    /// <see href="https://schema.org/freeShippingThreshold"></see></summary>
    let freeShippingThreshold = _prefix "freeShippingThreshold"
    /// <summary>
    /// How often the dose is taken, e.g. 'daily'.
    /// <see href="https://schema.org/frequency"></see></summary>
    let frequency = _prefix "frequency"
    /// <summary>
    /// A sub property of location. The original location of the object or the agent before the action.
    /// <see href="https://schema.org/fromLocation"></see></summary>
    let fromLocation = _prefix "fromLocation"
    /// <summary>
    /// The capacity of the fuel tank or in the case of electric cars, the battery. If there are multiple components for storage, this should indicate the total of all storage of the same type.\n\nTypical unit code(s): LTR for liters, GLL of US gallons, GLI for UK / imperial gallons, AMH for ampere-hours (for electrical vehicles).
    /// <see href="https://schema.org/fuelCapacity"></see></summary>
    let fuelCapacity = _prefix "fuelCapacity"
    /// <summary>
    /// The amount of fuel consumed for traveling a particular distance or temporal duration with the given vehicle (e.g. liters per 100 km).\n\n* Note 1: There are unfortunately no standard unit codes for liters per 100 km.  Use [[unitText]] to indicate the unit of measurement, e.g. L/100 km.\n* Note 2: There are two ways of indicating the fuel consumption, [[fuelConsumption]] (e.g. 8 liters per 100 km) and [[fuelEfficiency]] (e.g. 30 miles per gallon). They are reciprocal.\n* Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use [[valueReference]] to link the value for the fuel consumption to another value.
    /// <see href="https://schema.org/fuelConsumption"></see></summary>
    let fuelConsumption = _prefix "fuelConsumption"
    /// <summary>
    /// The distance traveled per unit of fuel used; most commonly miles per gallon (mpg) or kilometers per liter (km/L).\n\n* Note 1: There are unfortunately no standard unit codes for miles per gallon or kilometers per liter. Use [[unitText]] to indicate the unit of measurement, e.g. mpg or km/L.\n* Note 2: There are two ways of indicating the fuel consumption, [[fuelConsumption]] (e.g. 8 liters per 100 km) and [[fuelEfficiency]] (e.g. 30 miles per gallon). They are reciprocal.\n* Note 3: Often, the absolute value is useful only when related to driving speed ("at 80 km/h") or usage pattern ("city traffic"). You can use [[valueReference]] to link the value for the fuel economy to another value.
    /// <see href="https://schema.org/fuelEfficiency"></see></summary>
    let fuelEfficiency = _prefix "fuelEfficiency"
    /// <summary>
    /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
    /// <see href="https://schema.org/fuelType"></see></summary>
    let fuelType = _prefix "fuelType"
    /// <summary>
    /// Type of fulfillment applicable to the [[ShippingService]].
    /// <see href="https://schema.org/fulfillmentType"></see></summary>
    let fulfillmentType = _prefix "fulfillmentType"
    /// <summary>
    /// The degree of mobility the joint allows.
    /// <see href="https://schema.org/functionalClass"></see></summary>
    let functionalClass = _prefix "functionalClass"
    /// <summary>
    /// Indicates something directly or indirectly funded or sponsored through a [[Grant]]. See also [[ownershipFundingInfo]].
    /// <see href="https://schema.org/fundedItem"></see></summary>
    let fundedItem = _prefix "fundedItem"
    /// <summary>
    /// A [[Grant]] that directly or indirectly provide funding or sponsorship for this item. See also [[ownershipFundingInfo]].
    /// <see href="https://schema.org/funding"></see></summary>
    let funding = _prefix "funding"
    /// <summary>
    /// A person or organization that supports (sponsors) something through some kind of financial contribution.
    /// <see href="https://schema.org/funder"></see></summary>
    let funder = _prefix "funder"
    /// <summary>
    /// A person or organization that supports a thing through a pledge, promise, or financial contribution. E.g. a sponsor of a Medical Study or a corporate sponsor of an event.
    /// <see href="https://schema.org/sponsor"></see></summary>
    let sponsor = _prefix "sponsor"
    /// <summary>
    /// Video game which is played on this server.
    /// <see href="https://schema.org/game"></see></summary>
    let game = _prefix "game"
    /// <summary>
    /// The server on which  it is possible to play the game.
    /// <see href="https://schema.org/gameServer"></see></summary>
    let gameServer = _prefix "gameServer"
    /// <summary>
    /// Indicates the availability type of the game content associated with this action, such as whether it is a full version or a demo.
    /// <see href="https://schema.org/gameAvailabilityType"></see></summary>
    let gameAvailabilityType = _prefix "gameAvailabilityType"
    /// <summary>
    /// The edition of a video game.
    /// <see href="https://schema.org/gameEdition"></see></summary>
    let gameEdition = _prefix "gameEdition"
    /// <summary>
    /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
    /// <see href="https://schema.org/gameItem"></see></summary>
    let gameItem = _prefix "gameItem"
    /// <summary>
    /// Real or fictional location of the game (or part of game).
    /// <see href="https://schema.org/gameLocation"></see></summary>
    let gameLocation = _prefix "gameLocation"
    /// <summary>
    /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
    /// <see href="https://schema.org/gamePlatform"></see></summary>
    let gamePlatform = _prefix "gamePlatform"
    /// <summary>
    /// Links to tips, tactics, etc.
    /// <see href="https://schema.org/gameTip"></see></summary>
    let gameTip = _prefix "gameTip"
    /// <summary>
    /// Gender of something, typically a [[Person]], but possibly also fictional characters, animals, etc. While https://schema.org/Male and https://schema.org/Female may be used, text strings are also acceptable for people who are not a binary gender. The [[gender]] property can also be used in an extended sense to cover e.g. the gender of sports teams. As with the gender of individuals, we do not try to enumerate all possibilities. A mixed-gender [[SportsTeam]] can be indicated with a text value of "Mixed".
    /// <see href="https://schema.org/gender"></see></summary>
    let gender = _prefix "gender"
    /// <summary>
    /// Genre of the creative work, broadcast channel or group.
    /// <see href="https://schema.org/genre"></see></summary>
    let genre = _prefix "genre"
    /// <summary>
    /// The geo coordinates of the place.
    /// <see href="https://schema.org/geo"></see></summary>
    let geo = _prefix "geo"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM).
    /// <see href="https://schema.org/geoContains"></see></summary>
    let geoContains = _prefix "geoContains"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM).
    /// <see href="https://schema.org/geoCoveredBy"></see></summary>
    let geoCoveredBy = _prefix "geoCoveredBy"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM).
    /// <see href="https://schema.org/geoCovers"></see></summary>
    let geoCovers = _prefix "geoCovers"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM).
    /// <see href="https://schema.org/geoCrosses"></see></summary>
    let geoCrosses = _prefix "geoCrosses"
    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: "they have no point in common. They form a set of disconnected geometries." (A symmetric relationship, as defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM).)
    /// <see href="https://schema.org/geoDisjoint"></see></summary>
    let geoDisjoint = _prefix "geoDisjoint"
    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM). "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship).
    /// <see href="https://schema.org/geoEquals"></see></summary>
    let geoEquals = _prefix "geoEquals"
    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM).
    /// <see href="https://schema.org/geoIntersects"></see></summary>
    let geoIntersects = _prefix "geoIntersects"
    /// <summary>
    /// Indicates the GeoCoordinates at the centre of a GeoShape, e.g. GeoCircle.
    /// <see href="https://schema.org/geoMidpoint"></see></summary>
    let geoMidpoint = _prefix "geoMidpoint"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM).
    /// <see href="https://schema.org/geoOverlaps"></see></summary>
    let geoOverlaps = _prefix "geoOverlaps"
    /// <summary>
    /// Indicates the approximate radius of a GeoCircle (metres unless indicated otherwise via Distance notation).
    /// <see href="https://schema.org/geoRadius"></see></summary>
    let geoRadius = _prefix "geoRadius"
    /// <summary>
    /// Represents spatial relations in which two geometries (or the places they represent) touch: "they have at least one boundary point in common, but no interior points." (A symmetric relationship, as defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM).)
    /// <see href="https://schema.org/geoTouches"></see></summary>
    let geoTouches = _prefix "geoTouches"
    /// <summary>
    /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in [DE-9IM](https://en.wikipedia.org/wiki/DE-9IM).
    /// <see href="https://schema.org/geoWithin"></see></summary>
    let geoWithin = _prefix "geoWithin"
    /// <summary>
    /// The geographic area associated with the audience.
    /// <see href="https://schema.org/geographicArea"></see></summary>
    let geographicArea = _prefix "geographicArea"
    /// <summary>
    /// Information about getting tested (for a [[MedicalCondition]]), e.g. in the context of a pandemic.
    /// <see href="https://schema.org/gettingTestedInfo"></see></summary>
    let gettingTestedInfo = _prefix "gettingTestedInfo"
    /// <summary>
    /// Given name. In the U.S., the first name of a Person.
    /// <see href="https://schema.org/givenName"></see></summary>
    let givenName = _prefix "givenName"
    /// <summary>
    /// The [Global Location Number](http://www.gs1.org/gln) (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
    /// <see href="https://schema.org/globalLocationNumber"></see></summary>
    let globalLocationNumber = _prefix "globalLocationNumber"
    /// <summary>
    /// governmentBenefitsInfo provides information about government benefits associated with a SpecialAnnouncement.
    /// <see href="https://schema.org/governmentBenefitsInfo"></see></summary>
    let governmentBenefitsInfo = _prefix "governmentBenefitsInfo"
    /// <summary>
    /// The period of time after any due date that the borrower has to fulfil its obligations before a default (failure to pay) is deemed to have occurred.
    /// <see href="https://schema.org/gracePeriod"></see></summary>
    let gracePeriod = _prefix "gracePeriod"
    /// <summary>
    /// The person, organization, contact point, or audience that has been granted this permission.
    /// <see href="https://schema.org/grantee"></see></summary>
    let grantee = _prefix "grantee"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is greater than the object.
    /// <see href="https://schema.org/greater"></see></summary>
    let greater = _prefix "greater"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is greater than or equal to the object.
    /// <see href="https://schema.org/greaterOrEqual"></see></summary>
    let greaterOrEqual = _prefix "greaterOrEqual"
    /// <summary>
    /// A Global Trade Item Number ([GTIN](https://www.gs1.org/standards/id-keys/gtin)). GTINs identify trade items, including products and services, using numeric identification codes.
    ///
    /// A correct [[gtin]] value should be a valid GTIN, which means that it should be an all-numeric string of either 8, 12, 13 or 14 digits, or a "GS1 Digital Link" URL based on such a string. The numeric component should also have a [valid GS1 check digit](https://www.gs1.org/services/check-digit-calculator) and meet the other rules for valid GTINs. See also [GS1's GTIN Summary](http://www.gs1.org/barcodes/technical/idkeys/gtin) and [Wikipedia](https://en.wikipedia.org/wiki/Global_Trade_Item_Number) for more details. Left-padding of the gtin values is not required or encouraged. The [[gtin]] property generalizes the earlier [[gtin8]], [[gtin12]], [[gtin13]], and [[gtin14]] properties.
    ///
    /// The GS1 [digital link specifications](https://www.gs1.org/standards/Digital-Link/) expresses GTINs as URLs (URIs, IRIs, etc.).
    /// Digital Links should be populated into the [[hasGS1DigitalLink]] attribute.
    ///
    /// Note also that this is a definition for how to include GTINs in Schema.org data, and not a definition of GTINs in general - see the GS1 documentation for authoritative details.
    /// <see href="https://schema.org/gtin"></see></summary>
    let gtin = _prefix "gtin"
    /// <summary>
    /// The GTIN-12 code of the product, or the product to which the offer refers. The GTIN-12 is the 12-digit GS1 Identification Key composed of a U.P.C. Company Prefix, Item Reference, and Check Digit used to identify trade items. See [GS1 GTIN Summary](http://www.gs1.org/barcodes/technical/idkeys/gtin) for more details.
    /// <see href="https://schema.org/gtin12"></see></summary>
    let gtin12 = _prefix "gtin12"
    /// <summary>
    /// The GTIN-13 code of the product, or the product to which the offer refers. This is equivalent to 13-digit ISBN codes and EAN UCC-13. Former 12-digit UPC codes can be converted into a GTIN-13 code by simply adding a preceding zero. See [GS1 GTIN Summary](http://www.gs1.org/barcodes/technical/idkeys/gtin) for more details.
    /// <see href="https://schema.org/gtin13"></see></summary>
    let gtin13 = _prefix "gtin13"
    /// <summary>
    /// The GTIN-14 code of the product, or the product to which the offer refers. See [GS1 GTIN Summary](http://www.gs1.org/barcodes/technical/idkeys/gtin) for more details.
    /// <see href="https://schema.org/gtin14"></see></summary>
    let gtin14 = _prefix "gtin14"
    /// <summary>
    /// The GTIN-8 code of the product, or the product to which the offer refers. This code is also known as EAN/UCC-8 or 8-digit EAN. See [GS1 GTIN Summary](http://www.gs1.org/barcodes/technical/idkeys/gtin) for more details.
    /// <see href="https://schema.org/gtin8"></see></summary>
    let gtin8 = _prefix "gtin8"
    /// <summary>
    /// A medical guideline related to this entity.
    /// <see href="https://schema.org/guideline"></see></summary>
    let guideline = _prefix "guideline"
    /// <summary>
    /// Date on which this guideline's recommendation was made.
    /// <see href="https://schema.org/guidelineDate"></see></summary>
    let guidelineDate = _prefix "guidelineDate"
    /// <summary>
    /// The medical conditions, treatments, etc. that are the subject of the guideline.
    /// <see href="https://schema.org/guidelineSubject"></see></summary>
    let guidelineSubject = _prefix "guidelineSubject"
    /// <summary>
    /// The typical delay between the receipt of the order and the goods either leaving the warehouse or being prepared for pickup, in case the delivery method is on site pickup.
    ///
    /// In the context of [[ShippingDeliveryTime]], Typical properties: minValue, maxValue, unitCode (d for DAY).  This is by common convention assumed to mean business days (if a unitCode is used, coded as "d"), i.e. only counting days when the business normally operates.
    ///
    /// In the context of [[ShippingService]], use the [[ServicePeriod]] format, that contains the same information in a structured form, with cut-off time, business days and duration.
    /// <see href="https://schema.org/handlingTime"></see></summary>
    let handlingTime = _prefix "handlingTime"
    /// <summary>
    /// Used to tag an item to be intended or suitable for consumption or use by adults only.
    /// <see href="https://schema.org/hasAdultConsideration"></see></summary>
    let hasAdultConsideration = _prefix "hasAdultConsideration"
    /// <summary>
    /// Indicates a BioChemEntity that (in some sense) has this BioChemEntity as a part.
    /// <see href="https://schema.org/hasBioChemEntityPart"></see></summary>
    let hasBioChemEntityPart = _prefix "hasBioChemEntityPart"
    /// <summary>
    /// Indicates a BioChemEntity that is (in some sense) a part of this BioChemEntity.
    /// <see href="https://schema.org/isPartOfBioChemEntity"></see></summary>
    let isPartOfBioChemEntity = _prefix "isPartOfBioChemEntity"
    /// <summary>
    /// A symbolic representation of a BioChemEntity. For example, a nucleotide sequence of a Gene or an amino acid sequence of a Protein.
    /// <see href="https://schema.org/hasBioPolymerSequence"></see></summary>
    let hasBioPolymerSequence = _prefix "hasBioPolymerSequence"
    /// <summary>
    /// A common representation such as a protein sequence or chemical structure for this entity. For images use schema.org/image.
    /// <see href="https://schema.org/hasRepresentation"></see></summary>
    let hasRepresentation = _prefix "hasRepresentation"
    /// <summary>
    /// A broadcast channel of a broadcast service.
    /// <see href="https://schema.org/hasBroadcastChannel"></see></summary>
    let hasBroadcastChannel = _prefix "hasBroadcastChannel"
    /// <summary>
    /// The BroadcastService offered on this channel.
    /// <see href="https://schema.org/providesBroadcastService"></see></summary>
    let providesBroadcastService = _prefix "providesBroadcastService"
    /// <summary>
    /// A Category code contained in this code set.
    /// <see href="https://schema.org/hasCategoryCode"></see></summary>
    let hasCategoryCode = _prefix "hasCategoryCode"
    /// <summary>
    /// A Defined Term contained in this term set.
    /// <see href="https://schema.org/hasDefinedTerm"></see></summary>
    let hasDefinedTerm = _prefix "hasDefinedTerm"
    /// <summary>
    /// Certification information about a product, organization, service, place, or person.
    /// <see href="https://schema.org/hasCertification"></see></summary>
    let hasCertification = _prefix "hasCertification"
    /// <summary>
    /// A course or class that is one of the learning opportunities that constitute an educational / occupational program. No information is implied about whether the course is mandatory or optional; no guarantee is implied about whether the course will be available to everyone on the program.
    /// <see href="https://schema.org/hasCourse"></see></summary>
    let hasCourse = _prefix "hasCourse"
    /// <summary>
    /// An offering of the course at a specific time and place or through specific media or mode of study or to a specific section of students.
    /// <see href="https://schema.org/hasCourseInstance"></see></summary>
    let hasCourseInstance = _prefix "hasCourseInstance"
    /// <summary>
    /// A credential awarded to the Person or Organization.
    /// <see href="https://schema.org/hasCredential"></see></summary>
    let hasCredential = _prefix "hasCredential"
    /// <summary>
    /// Method used for delivery or shipping.
    /// <see href="https://schema.org/hasDeliveryMethod"></see></summary>
    let hasDeliveryMethod = _prefix "hasDeliveryMethod"
    /// <summary>
    /// A permission related to the access to this document (e.g. permission to read or write an electronic document). For a public document, specify a grantee with an Audience with audienceType equal to "public".
    /// <see href="https://schema.org/hasDigitalDocumentPermission"></see></summary>
    let hasDigitalDocumentPermission = _prefix "hasDigitalDocumentPermission"
    /// <summary>
    /// Indicates whether some facility (e.g. [[FoodEstablishment]], [[CovidTestingFacility]]) offers a service that can be used by driving through in a car. In the case of [[CovidTestingFacility]] such facilities could potentially help with social distancing from other potentially-infected users.
    /// <see href="https://schema.org/hasDriveThroughService"></see></summary>
    let hasDriveThroughService = _prefix "hasDriveThroughService"
    /// <summary>
    /// Defines the energy efficiency Category (also known as "class" or "rating") for a product according to an international energy efficiency standard.
    /// <see href="https://schema.org/hasEnergyConsumptionDetails"></see></summary>
    let hasEnergyConsumptionDetails = _prefix "hasEnergyConsumptionDetails"
    /// <summary>
    /// Defines the energy efficiency Category (which could be either a rating out of range of values or a yes/no certification) for a product according to an international energy efficiency standard.
    /// <see href="https://schema.org/hasEnergyEfficiencyCategory"></see></summary>
    let hasEnergyEfficiencyCategory = _prefix "hasEnergyEfficiencyCategory"
    /// <summary>
    /// The &lt;a href="https://www.gs1.org/standards/gs1-digital-link"&gt;GS1 digital link&lt;/a&gt; associated with the object. This URL should conform to the particular requirements of digital links. The link should only contain the Application Identifiers (AIs) that are relevant for the entity being annotated, for instance a [[Product]] or an [[Organization]], and for the correct granularity. In particular, for products:&lt;ul&gt;&lt;li&gt;A Digital Link that contains a serial number (AI &lt;code&gt;21&lt;/code&gt;) should only be present on instances of [[IndividualProduct]]&lt;/li&gt;&lt;li&gt;A Digital Link that contains a lot number (AI &lt;code&gt;10&lt;/code&gt;) should be annotated as [[SomeProducts]] if only products from that lot are sold, or [[IndividualProduct]] if there is only a specific product.&lt;/li&gt;&lt;li&gt;A Digital Link that contains a global model number (AI &lt;code&gt;8013&lt;/code&gt;) should be attached to a [[Product]] or a [[ProductModel]].&lt;/li&gt;&lt;/ul&gt; Other item types should be adapted similarly.
    /// <see href="https://schema.org/hasGS1DigitalLink"></see></summary>
    let hasGS1DigitalLink = _prefix "hasGS1DigitalLink"
    /// <summary>
    /// Indicates the aspect or aspects specifically addressed in some [[HealthTopicContent]]. For example, that the content is an overview, or that it talks about treatment, self-care, treatments or their side-effects.
    /// <see href="https://schema.org/hasHealthAspect"></see></summary>
    let hasHealthAspect = _prefix "hasHealthAspect"
    /// <summary>
    /// A URL to a map of the place.
    /// <see href="https://schema.org/hasMap"></see></summary>
    let hasMap = _prefix "hasMap"
    /// <summary>
    /// A measurement of an item, For example, the inseam of pants, the wheel size of a bicycle, the gauge of a screw, or the carbon footprint measured for certification by an authority. Usually an exact measurement, but can also be a range of measurements for adjustable products, for example belts and ski bindings.
    /// <see href="https://schema.org/hasMeasurement"></see></summary>
    let hasMeasurement = _prefix "hasMeasurement"
    /// <summary>
    /// MemberProgram offered by an Organization, for example an eCommerce merchant or an airline.
    /// <see href="https://schema.org/hasMemberProgram"></see></summary>
    let hasMemberProgram = _prefix "hasMemberProgram"
    /// <summary>
    /// Either the actual menu as a structured representation, as text, or a URL of the menu.
    /// <see href="https://schema.org/hasMenu"></see></summary>
    let hasMenu = _prefix "hasMenu"
    /// <summary>
    /// A food or drink item contained in a menu or menu section.
    /// <see href="https://schema.org/hasMenuItem"></see></summary>
    let hasMenuItem = _prefix "hasMenuItem"
    /// <summary>
    /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
    /// <see href="https://schema.org/hasMenuSection"></see></summary>
    let hasMenuSection = _prefix "hasMenuSection"
    /// <summary>
    /// Specifies a MerchantReturnPolicy that may be applicable.
    /// <see href="https://schema.org/hasMerchantReturnPolicy"></see></summary>
    let hasMerchantReturnPolicy = _prefix "hasMerchantReturnPolicy"
    /// <summary>
    /// Molecular function performed by this BioChemEntity; please use PropertyValue if you want to include any evidence.
    /// <see href="https://schema.org/hasMolecularFunction"></see></summary>
    let hasMolecularFunction = _prefix "hasMolecularFunction"
    /// <summary>
    /// The Person's occupation. For past professions, use Role for expressing dates.
    /// <see href="https://schema.org/hasOccupation"></see></summary>
    let hasOccupation = _prefix "hasOccupation"
    /// <summary>
    /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
    /// <see href="https://schema.org/hasOfferCatalog"></see></summary>
    let hasOfferCatalog = _prefix "hasOfferCatalog"
    /// <summary>
    /// Points-of-Sales operated by the organization or person.
    /// <see href="https://schema.org/hasPOS"></see></summary>
    let hasPOS = _prefix "hasPOS"
    /// <summary>
    /// An offer to participate in the event, for example, Call for Proposals, Call for Speakers, or Call for Performers.
    /// <see href="https://schema.org/hasParticipationOffer"></see></summary>
    let hasParticipationOffer = _prefix "hasParticipationOffer"
    /// <summary>
    /// Specification of a shipping service offered by the organization.
    /// <see href="https://schema.org/hasShippingService"></see></summary>
    let hasShippingService = _prefix "hasShippingService"
    /// <summary>
    /// An offer to sponsor the event, for example, Sponsorship Prospectus, Sponsorship Opportunities, or Sponsor Packages.
    /// <see href="https://schema.org/hasSponsorshipOffer"></see></summary>
    let hasSponsorshipOffer = _prefix "hasSponsorshipOffer"
    /// <summary>
    /// An eCommerce store part of an online marketplace.
    /// <see href="https://schema.org/hasStore"></see></summary>
    let hasStore = _prefix "hasStore"
    /// <summary>
    /// A member benefit for a particular tier of a loyalty program.
    /// <see href="https://schema.org/hasTierBenefit"></see></summary>
    let hasTierBenefit = _prefix "hasTierBenefit"
    /// <summary>
    /// A requirement for a user to join a membership tier, for example: a CreditCard if the tier requires sign up for a credit card, A UnitPriceSpecification if the user is required to pay a (periodic) fee, or a MonetaryAmount if the user needs to spend a minimum amount to join the tier. If a tier is free to join then this property does not need to be specified.
    /// <see href="https://schema.org/hasTierRequirement"></see></summary>
    let hasTierRequirement = _prefix "hasTierRequirement"
    /// <summary>
    /// The tiers of a member program.
    /// <see href="https://schema.org/hasTiers"></see></summary>
    let hasTiers = _prefix "hasTiers"
    /// <summary>
    /// The member program this tier is a part of.
    /// <see href="https://schema.org/isTierOf"></see></summary>
    let isTierOf = _prefix "isTierOf"
    /// <summary>
    /// Indicates a [[Product]] that is a member of this [[ProductGroup]] (or [[ProductModel]]).
    /// <see href="https://schema.org/hasVariant"></see></summary>
    let hasVariant = _prefix "hasVariant"
    /// <summary>
    /// Indicates the kind of product that this is a variant of. In the case of [[ProductModel]], this is a pointer (from a ProductModel) to a base product from which this product is a variant. It is safe to infer that the variant inherits all product features from the base model, unless defined locally. This is not transitive. In the case of a [[ProductGroup]], the group description also serves as a template, representing a set of Products that vary on explicitly defined, specific dimensions only (so it defines both a set of variants, as well as which values distinguish amongst those variants). When used with [[ProductGroup]], this property can apply to any [[Product]] included in the group.
    /// <see href="https://schema.org/isVariantOf"></see></summary>
    let isVariantOf = _prefix "isVariantOf"
    /// <summary>
    /// Headline of the article.
    /// <see href="https://schema.org/headline"></see></summary>
    let headline = _prefix "headline"
    /// <summary>
    /// Specifying the health condition(s) of a patient, medical study, or other target audience.
    /// <see href="https://schema.org/healthCondition"></see></summary>
    let healthCondition = _prefix "healthCondition"
    /// <summary>
    /// Whether the coinsurance applies before or after deductible, etc. TODO: Is this a closed set?
    /// <see href="https://schema.org/healthPlanCoinsuranceOption"></see></summary>
    let healthPlanCoinsuranceOption = _prefix "healthPlanCoinsuranceOption"
    /// <summary>
    /// The rate of coinsurance expressed as a number between 0.0 and 1.0.
    /// <see href="https://schema.org/healthPlanCoinsuranceRate"></see></summary>
    let healthPlanCoinsuranceRate = _prefix "healthPlanCoinsuranceRate"
    /// <summary>
    /// The copay amount.
    /// <see href="https://schema.org/healthPlanCopay"></see></summary>
    let healthPlanCopay = _prefix "healthPlanCopay"
    /// <summary>
    /// Whether the copay is before or after deductible, etc. TODO: Is this a closed set?
    /// <see href="https://schema.org/healthPlanCopayOption"></see></summary>
    let healthPlanCopayOption = _prefix "healthPlanCopayOption"
    /// <summary>
    /// The costs to the patient for services under this network or formulary.
    /// <see href="https://schema.org/healthPlanCostSharing"></see></summary>
    let healthPlanCostSharing = _prefix "healthPlanCostSharing"
    /// <summary>
    /// TODO.
    /// <see href="https://schema.org/healthPlanDrugOption"></see></summary>
    let healthPlanDrugOption = _prefix "healthPlanDrugOption"
    /// <summary>
    /// The tier(s) of drugs offered by this formulary or insurance plan.
    /// <see href="https://schema.org/healthPlanDrugTier"></see></summary>
    let healthPlanDrugTier = _prefix "healthPlanDrugTier"
    /// <summary>
    /// The 14-character, HIOS-generated Plan ID number. (Plan IDs must be unique, even across different markets.)
    /// <see href="https://schema.org/healthPlanId"></see></summary>
    let healthPlanId = _prefix "healthPlanId"
    /// <summary>
    /// The URL that goes directly to the plan brochure for the specific standard plan or plan variation.
    /// <see href="https://schema.org/healthPlanMarketingUrl"></see></summary>
    let healthPlanMarketingUrl = _prefix "healthPlanMarketingUrl"
    /// <summary>
    /// Name or unique ID of network. (Networks are often reused across different insurance plans.)
    /// <see href="https://schema.org/healthPlanNetworkId"></see></summary>
    let healthPlanNetworkId = _prefix "healthPlanNetworkId"
    /// <summary>
    /// The tier(s) for this network.
    /// <see href="https://schema.org/healthPlanNetworkTier"></see></summary>
    let healthPlanNetworkTier = _prefix "healthPlanNetworkTier"
    /// <summary>
    /// The category or type of pharmacy associated with this cost sharing.
    /// <see href="https://schema.org/healthPlanPharmacyCategory"></see></summary>
    let healthPlanPharmacyCategory = _prefix "healthPlanPharmacyCategory"
    /// <summary>
    /// Indicates data describing a hospital, e.g. a CDC [[CDCPMDRecord]] or as some kind of [[Dataset]].
    /// <see href="https://schema.org/healthcareReportingData"></see></summary>
    let healthcareReportingData = _prefix "healthcareReportingData"
    /// <summary>
    /// The height of the item.
    /// <see href="https://schema.org/height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// The highest price of all offers available.\n\nUsage guidelines:\n\n* Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similar Unicode symbols.\n* Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
    /// <see href="https://schema.org/highPrice"></see></summary>
    let highPrice = _prefix "highPrice"
    /// <summary>
    /// Organization or Person offering the job position.
    /// <see href="https://schema.org/hiringOrganization"></see></summary>
    let hiringOrganization = _prefix "hiringOrganization"
    /// <summary>
    /// A contact location for a person's residence.
    /// <see href="https://schema.org/homeLocation"></see></summary>
    let homeLocation = _prefix "homeLocation"
    /// <summary>
    /// The home team in a sports event.
    /// <see href="https://schema.org/homeTeam"></see></summary>
    let homeTeam = _prefix "homeTeam"
    /// <summary>
    /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
    /// <see href="https://schema.org/honorificPrefix"></see></summary>
    let honorificPrefix = _prefix "honorificPrefix"
    /// <summary>
    /// An honorific suffix following a Person's name such as M.D./PhD/MSCSW.
    /// <see href="https://schema.org/honorificSuffix"></see></summary>
    let honorificSuffix = _prefix "honorificSuffix"
    /// <summary>
    /// A hospital with which the physician or office is affiliated.
    /// <see href="https://schema.org/hospitalAffiliation"></see></summary>
    let hospitalAffiliation = _prefix "hospitalAffiliation"
    /// <summary>
    /// The Organization (airline, travelers' club, retailer, etc.) the membership is made with or which offers the  MemberProgram.
    /// <see href="https://schema.org/hostingOrganization"></see></summary>
    let hostingOrganization = _prefix "hostingOrganization"
    /// <summary>
    /// The hours during which this service or contact is available.
    /// <see href="https://schema.org/hoursAvailable"></see></summary>
    let hoursAvailable = _prefix "hoursAvailable"
    /// <summary>
    /// How the procedure is performed.
    /// <see href="https://schema.org/howPerformed"></see></summary>
    let howPerformed = _prefix "howPerformed"
    /// <summary>
    /// An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.
    /// <see href="https://schema.org/httpMethod"></see></summary>
    let httpMethod = _prefix "httpMethod"
    /// <summary>
    /// IATA identifier for an airline or airport.
    /// <see href="https://schema.org/iataCode"></see></summary>
    let iataCode = _prefix "iataCode"
    /// <summary>
    /// ICAO identifier for an airport.
    /// <see href="https://schema.org/icaoCode"></see></summary>
    let icaoCode = _prefix "icaoCode"
    /// <summary>
    /// A physical examination that can identify this sign.
    /// <see href="https://schema.org/identifyingExam"></see></summary>
    let identifyingExam = _prefix "identifyingExam"
    /// <summary>
    /// A diagnostic test that can identify this sign.
    /// <see href="https://schema.org/identifyingTest"></see></summary>
    let identifyingTest = _prefix "identifyingTest"
    /// <summary>
    /// The illustrator of the book.
    /// <see href="https://schema.org/illustrator"></see></summary>
    let illustrator = _prefix "illustrator"
    /// <summary>
    /// Imaging technique used.
    /// <see href="https://schema.org/imagingTechnique"></see></summary>
    let imagingTechnique = _prefix "imagingTechnique"
    /// <summary>
    /// The album to which this recording belongs.
    /// <see href="https://schema.org/inAlbum"></see></summary>
    let inAlbum = _prefix "inAlbum"
    /// <summary>
    /// The CableOrSatelliteService offering the channel.
    /// <see href="https://schema.org/inBroadcastLineup"></see></summary>
    let inBroadcastLineup = _prefix "inBroadcastLineup"
    /// <summary>
    /// Non-proprietary identifier for molecular entity that can be used in printed and electronic data sources thus enabling easier linking of diverse data compilations.
    /// <see href="https://schema.org/inChI"></see></summary>
    let inChI = _prefix "inChI"
    /// <summary>
    /// InChIKey is a hashed version of the full InChI (using the SHA-256 algorithm).
    /// <see href="https://schema.org/inChIKey"></see></summary>
    let inChIKey = _prefix "inChIKey"
    /// <summary>
    /// A [[CategoryCodeSet]] that contains this category code.
    /// <see href="https://schema.org/inCodeSet"></see></summary>
    let inCodeSet = _prefix "inCodeSet"
    /// <summary>
    /// A [[DefinedTermSet]] that contains this term.
    /// <see href="https://schema.org/inDefinedTermSet"></see></summary>
    let inDefinedTermSet = _prefix "inDefinedTermSet"
    /// <summary>
    /// The language of the content or performance or used in an action. Please use one of the language codes from the [IETF BCP 47 standard](http://tools.ietf.org/html/bcp47). See also [[availableLanguage]].
    /// <see href="https://schema.org/inLanguage"></see></summary>
    let inLanguage = _prefix "inLanguage"
    /// <summary>
    /// The playlist to which this recording belongs.
    /// <see href="https://schema.org/inPlaylist"></see></summary>
    let inPlaylist = _prefix "inPlaylist"
    /// <summary>
    /// Indicates the [[productGroupID]] for a [[ProductGroup]] that this product [[isVariantOf]].
    /// <see href="https://schema.org/inProductGroupWithID"></see></summary>
    let inProductGroupWithID = _prefix "inProductGroupWithID"
    /// <summary>
    /// Are in-store returns offered? (For more advanced return methods use the [[returnMethod]] property.)
    /// <see href="https://schema.org/inStoreReturnsOffered"></see></summary>
    let inStoreReturnsOffered = _prefix "inStoreReturnsOffered"
    /// <summary>
    /// Qualification, candidature, degree, application that Thesis supports.
    /// <see href="https://schema.org/inSupportOf"></see></summary>
    let inSupportOf = _prefix "inSupportOf"
    /// <summary>
    /// Describes the amount that can be redeemed from this incentive.
    ///
    /// &lt;p&gt;[[QuantitativeValue]]: Use this for incentives based on price (either raw amount or percentage-based). For a raw amount example, "You can claim $2,500 - $7,500 from the total cost of installation" would be represented as the following:&lt;/p&gt;
    ///     {
    ///         "@type": "QuantitativeValue",
    ///         “minValue”: 2500,
    ///         “maxValue”: 7500,
    ///         "unitCode": "USD"
    ///     }
    /// &lt;p&gt;[[QuantitativeValue]] can also be used for percentage amounts. In such cases, value is used to represent the incentive’s percentage, while maxValue represents a limit (if one exists) to that incentive. The unitCode should be 'P1' and the unitText should be '%', while valueReference should be used for holding the currency type. For example, "You can claim up to 30% of the total cost of installation, up to a maximum of $7,500" would be:&lt;/p&gt;
    ///     {
    ///         "@type": "QuantitativeValue",
    ///         "value": 30,
    ///         "unitCode": "P1",
    ///         "unitText": "%",
    ///         “maxValue”: 7500,
    ///         “valueReference”: “USD”
    ///     }
    /// &lt;p&gt;[[UnitPriceSpecification]]: Use this for incentives that are based on amounts rather than price. For example, a net metering rebate that pays $10/kWh, up to $1,000:&lt;/p&gt;
    ///     {
    ///         "@type": "UnitPriceSpecification",
    ///         "price": 10,
    ///         "priceCurrency": "USD",
    ///         "referenceQuantity": 1,
    ///         "unitCode": "DO3",
    ///         "unitText": "kw/h",
    ///         "maxPrice": 1000,
    ///         "description": "$10 / kwh up to $1000"
    ///     }
    /// &lt;p&gt;[[LoanOrCredit]]: Use for incentives that are loan based. For example, a loan of $4,000 - $50,000 with a repayment term of 10 years, interest free would look like:&lt;/p&gt;
    ///     {
    ///         "@type": "LoanOrCredit",
    ///         "loanTerm": {
    ///                 "@type":"QuantitativeValue",
    ///                 "value":"10",
    ///                 "unitCode": "ANN"
    ///             },
    ///         "amount":[
    ///             {
    ///                 "@type": "QuantitativeValue",
    ///                 "Name":"fixed interest rate",
    ///                 "value":"0",
    ///             },
    ///         ],
    ///         "amount":[
    ///             {
    ///                 "@type": "MonetaryAmount",
    ///                 "Name":"min loan amount",
    ///                 "value":"4000",
    ///                 "currency":"CAD"
    ///             },
    ///             {
    ///                 "@type": "MonetaryAmount",
    ///                 "Name":"max loan amount",
    ///                 "value":"50000",
    ///                 "currency":"CAD"
    ///             }
    ///         ],
    ///     }
    ///
    /// In summary: &lt;ul&gt;&lt;li&gt;Use [[QuantitativeValue]] for absolute/percentage-based incentives applied on the price of a good/service.&lt;/li&gt;
    /// &lt;li&gt;Use [[UnitPriceSpecification]] for incentives based on a per-unit basis (e.g. net metering).&lt;/li&gt;
    /// &lt;li&gt;Use [[LoanOrCredit]] for loans/credits.&lt;/li&gt;
    /// &lt;/ul&gt;.
    /// <see href="https://schema.org/incentiveAmount"></see></summary>
    let incentiveAmount = _prefix "incentiveAmount"
    /// <summary>
    /// Description of bonus and commission compensation aspects of the job.
    /// <see href="https://schema.org/incentiveCompensation"></see></summary>
    let incentiveCompensation = _prefix "incentiveCompensation"
    /// <summary>
    /// The status of the incentive (active, on hold, retired, etc.).
    /// <see href="https://schema.org/incentiveStatus"></see></summary>
    let incentiveStatus = _prefix "incentiveStatus"
    /// <summary>
    /// The type of incentive offered (tax credit/rebate, tax deduction, tax waiver, subsidies, etc.).
    /// <see href="https://schema.org/incentiveType"></see></summary>
    let incentiveType = _prefix "incentiveType"
    /// <summary>
    /// Description of bonus and commission compensation aspects of the job.
    /// <see href="https://schema.org/incentives"></see></summary>
    let incentives = _prefix "incentives"
    /// <summary>
    /// The type or specific product(s) and/or service(s) being incentivized.
    /// &lt;p&gt;DefinedTermSets are used for product and service categories such as the United Nations Standard Products and Services Code:&lt;/p&gt;
    ///     {
    ///         "@type": "DefinedTerm",
    ///         "inDefinedTermSet": "https://www.unspsc.org/",
    ///         "termCode": "261315XX",
    ///         "name": "Photovoltaic module"
    ///     }
    ///
    /// &lt;p&gt;For a specific product or service, use the Product type:&lt;/p&gt;
    ///     {
    ///         "@type": "Product",
    ///         "name": "Kenmore White 17" Microwave",
    ///     }
    /// For multiple different incentivized items, use multiple [[DefinedTerm]] or [[Product]].
    /// <see href="https://schema.org/incentivizedItem"></see></summary>
    let incentivizedItem = _prefix "incentivizedItem"
    /// <summary>
    /// Smaller compositions included in this work (e.g. a movement in a symphony).
    /// <see href="https://schema.org/includedComposition"></see></summary>
    let includedComposition = _prefix "includedComposition"
    /// <summary>
    /// A data catalog which contains this dataset (this property was previously 'catalog', preferred name is now 'includedInDataCatalog').
    /// <see href="https://schema.org/includedDataCatalog"></see></summary>
    let includedDataCatalog = _prefix "includedDataCatalog"
    /// <summary>
    /// The insurance plans that cover this drug.
    /// <see href="https://schema.org/includedInHealthInsurancePlan"></see></summary>
    let includedInHealthInsurancePlan = _prefix "includedInHealthInsurancePlan"
    /// <summary>
    /// A modifiable or non-modifiable risk factor included in the calculation, e.g. age, coexisting condition.
    /// <see href="https://schema.org/includedRiskFactor"></see></summary>
    let includedRiskFactor = _prefix "includedRiskFactor"
    /// <summary>
    /// Attraction located at destination.
    /// <see href="https://schema.org/includesAttraction"></see></summary>
    let includesAttraction = _prefix "includesAttraction"
    /// <summary>
    /// Formularies covered by this plan.
    /// <see href="https://schema.org/includesHealthPlanFormulary"></see></summary>
    let includesHealthPlanFormulary = _prefix "includesHealthPlanFormulary"
    /// <summary>
    /// Networks covered by this plan.
    /// <see href="https://schema.org/includesHealthPlanNetwork"></see></summary>
    let includesHealthPlanNetwork = _prefix "includesHealthPlanNetwork"
    /// <summary>
    /// This links to a node or nodes indicating the exact quantity of the products included in  an [[Offer]] or [[ProductCollection]].
    /// <see href="https://schema.org/includesObject"></see></summary>
    let includesObject = _prefix "includesObject"
    /// <summary>
    /// Optional. Income limit for which the incentive is applicable for.
    ///
    /// &lt;p&gt;If MonetaryAmount is specified, this should be based on annualized income (e.g. if an incentive is limited to those making &lt;$114,000 annually):&lt;/p&gt;
    ///     {
    ///         "@type": "MonetaryAmount",
    ///         "maxValue": 114000,
    ///         "currency": "USD",
    ///     }
    ///
    /// Use Text for incentives that are limited based on other criteria, for example if an incentive is only available to recipients making 120% of the median poverty income in their area.
    /// <see href="https://schema.org/incomeLimit"></see></summary>
    let incomeLimit = _prefix "incomeLimit"
    /// <summary>
    /// The condition, complication, etc. influenced by this factor.
    /// <see href="https://schema.org/increasesRiskOf"></see></summary>
    let increasesRiskOf = _prefix "increasesRiskOf"
    /// <summary>
    /// The industry associated with the job position.
    /// <see href="https://schema.org/industry"></see></summary>
    let industry = _prefix "industry"
    /// <summary>
    /// The ISO 3166-1 (ISO 3166-1 alpha-2) or ISO 3166-2 code, the place, or the GeoShape for the geo-political region(s) for which the offer or delivery charge specification is not valid, e.g. a region where the transaction is not allowed.\n\nSee also [[eligibleRegion]].
    ///
    /// <see href="https://schema.org/ineligibleRegion"></see></summary>
    let ineligibleRegion = _prefix "ineligibleRegion"
    /// <summary>
    /// The actual infectious agent, such as a specific bacterium.
    /// <see href="https://schema.org/infectiousAgent"></see></summary>
    let infectiousAgent = _prefix "infectiousAgent"
    /// <summary>
    /// The class of infectious agent (bacteria, prion, etc.) that causes the disease.
    /// <see href="https://schema.org/infectiousAgentClass"></see></summary>
    let infectiousAgentClass = _prefix "infectiousAgentClass"
    /// <summary>
    /// A single ingredient used in the recipe, e.g. sugar, flour or garlic.
    /// <see href="https://schema.org/ingredients"></see></summary>
    let ingredients = _prefix "ingredients"
    /// <summary>
    /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
    /// <see href="https://schema.org/supply"></see></summary>
    let supply = _prefix "supply"
    /// <summary>
    /// An ingredient or ordered list of ingredients and potentially quantities used in the recipe, e.g. 1 cup of sugar, flour or garlic.  The ingredients can be represented as free text or more structured values.
    /// <see href="https://schema.org/recipeIngredient"></see></summary>
    let recipeIngredient = _prefix "recipeIngredient"
    /// <summary>
    /// The individual who traces over the pencil drawings in ink after pencils are complete.
    /// <see href="https://schema.org/inker"></see></summary>
    let inker = _prefix "inker"
    /// <summary>
    /// The place of attachment of a muscle, or what the muscle moves.
    /// <see href="https://schema.org/insertion"></see></summary>
    let insertion = _prefix "insertion"
    /// <summary>
    /// URL at which the app may be installed, if different from the URL of the item.
    /// <see href="https://schema.org/installUrl"></see></summary>
    let installUrl = _prefix "installUrl"
    /// <summary>
    /// A person assigned to instruct or provide instructional assistance for the [[CourseInstance]].
    /// <see href="https://schema.org/instructor"></see></summary>
    let instructor = _prefix "instructor"
    /// <summary>
    /// Quantitative measure gauging the degree of force involved in the exercise, for example, heartbeats per minute. May include the velocity of the movement.
    /// <see href="https://schema.org/intensity"></see></summary>
    let intensity = _prefix "intensity"
    /// <summary>
    /// Another drug that is known to interact with this drug in a way that impacts the effect of this drug or causes a risk to the patient. Note: disease interactions are typically captured as contraindications.
    /// <see href="https://schema.org/interactingDrug"></see></summary>
    let interactingDrug = _prefix "interactingDrug"
    /// <summary>
    /// This property is deprecated, alongside the UserInteraction types on which it depended.
    /// <see href="https://schema.org/interactionCount"></see></summary>
    let interactionCount = _prefix "interactionCount"
    /// <summary>
    /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
    /// <see href="https://schema.org/interactionStatistic"></see></summary>
    let interactionStatistic = _prefix "interactionStatistic"
    /// <summary>
    /// The WebSite or SoftwareApplication where the interactions took place.
    /// <see href="https://schema.org/interactionService"></see></summary>
    let interactionService = _prefix "interactionService"
    /// <summary>
    /// The Action representing the type of interaction. For up votes, +1s, etc. use [[LikeAction]]. For down votes use [[DislikeAction]]. Otherwise, use the most specific Action.
    /// <see href="https://schema.org/interactionType"></see></summary>
    let interactionType = _prefix "interactionType"
    /// <summary>
    /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
    /// <see href="https://schema.org/interactivityType"></see></summary>
    let interactivityType = _prefix "interactivityType"
    /// <summary>
    /// The interest rate, charged or paid, applicable to the financial product. Note: This is different from the calculated annualPercentageRate.
    /// <see href="https://schema.org/interestRate"></see></summary>
    let interestRate = _prefix "interestRate"
    /// <summary>
    /// Used to indicate a specific claim contained, implied, translated or refined from the content of a [[MediaObject]] or other [[CreativeWork]]. The interpreting party can be indicated using [[claimInterpreter]].
    /// <see href="https://schema.org/interpretedAsClaim"></see></summary>
    let interpretedAsClaim = _prefix "interpretedAsClaim"
    /// <summary>
    /// The current approximate inventory level for the item or items.
    /// <see href="https://schema.org/inventoryLevel"></see></summary>
    let inventoryLevel = _prefix "inventoryLevel"
    /// <summary>
    /// Whether the provider is accepting new patients.
    /// <see href="https://schema.org/isAcceptingNewPatients"></see></summary>
    let isAcceptingNewPatients = _prefix "isAcceptingNewPatients"
    /// <summary>
    /// A pointer to another product (or multiple products) for which this product is an accessory or spare part.
    /// <see href="https://schema.org/isAccessoryOrSparePartFor"></see></summary>
    let isAccessoryOrSparePartFor = _prefix "isAccessoryOrSparePartFor"
    /// <summary>
    /// True if the drug is available in a generic form (regardless of name).
    /// <see href="https://schema.org/isAvailableGenerically"></see></summary>
    let isAvailableGenerically = _prefix "isAvailableGenerically"
    /// <summary>
    /// A resource from which this work is derived or from which it is a modification or adaptation.
    /// <see href="https://schema.org/isBasedOn"></see></summary>
    let isBasedOn = _prefix "isBasedOn"
    /// <summary>
    /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
    /// <see href="https://schema.org/isBasedOnUrl"></see></summary>
    let isBasedOnUrl = _prefix "isBasedOnUrl"
    /// <summary>
    /// A pointer to another product (or multiple products) for which this product is a consumable.
    /// <see href="https://schema.org/isConsumableFor"></see></summary>
    let isConsumableFor = _prefix "isConsumableFor"
    /// <summary>
    /// Indicates whether this content is family friendly.
    /// <see href="https://schema.org/isFamilyFriendly"></see></summary>
    let isFamilyFriendly = _prefix "isFamilyFriendly"
    /// <summary>
    /// Indicates whether the offer was accepted as a gift for someone other than the buyer.
    /// <see href="https://schema.org/isGift"></see></summary>
    let isGift = _prefix "isGift"
    /// <summary>
    /// Biological process this BioChemEntity is involved in; please use PropertyValue if you want to include any evidence.
    /// <see href="https://schema.org/isInvolvedInBiologicalProcess"></see></summary>
    let isInvolvedInBiologicalProcess = _prefix "isInvolvedInBiologicalProcess"
    /// <summary>
    /// True if the broadcast is of a live event.
    /// <see href="https://schema.org/isLiveBroadcast"></see></summary>
    let isLiveBroadcast = _prefix "isLiveBroadcast"
    /// <summary>
    /// Subcellular location where this BioChemEntity is located; please use PropertyValue if you want to include any evidence.
    /// <see href="https://schema.org/isLocatedInSubcellularLocation"></see></summary>
    let isLocatedInSubcellularLocation = _prefix "isLocatedInSubcellularLocation"
    /// <summary>
    /// Indicates some accommodation that this floor plan describes.
    /// <see href="https://schema.org/isPlanForApartment"></see></summary>
    let isPlanForApartment = _prefix "isPlanForApartment"
    /// <summary>
    /// True if this item's name is a proprietary/brand name (vs. generic name).
    /// <see href="https://schema.org/isProprietary"></see></summary>
    let isProprietary = _prefix "isProprietary"
    /// <summary>
    /// A pointer to another, somehow related product (or multiple products).
    /// <see href="https://schema.org/isRelatedTo"></see></summary>
    let isRelatedTo = _prefix "isRelatedTo"
    /// <summary>
    /// Whether the 3DModel allows resizing. For example, room layout applications often do not allow 3DModel elements to be resized to reflect reality.
    /// <see href="https://schema.org/isResizable"></see></summary>
    let isResizable = _prefix "isResizable"
    /// <summary>
    /// A pointer to another, functionally similar product (or multiple products).
    /// <see href="https://schema.org/isSimilarTo"></see></summary>
    let isSimilarTo = _prefix "isSimilarTo"
    /// <summary>
    /// The eCommerce marketplace this online store is on.
    /// <see href="https://schema.org/isStoreOn"></see></summary>
    let isStoreOn = _prefix "isStoreOn"
    /// <summary>
    /// This can be marked 'true' to indicate that some published [[DeliveryTimeSettings]] or [[ShippingRateSettings]] are intended to apply to all [[OfferShippingDetails]] published by the same merchant, when referenced by a [[shippingSettingsLink]] in those settings. It is not meaningful to use a 'true' value for this property alongside a transitTimeLabel (for [[DeliveryTimeSettings]]) or shippingLabel (for [[ShippingRateSettings]]), since this property is for use with unlabelled settings.
    /// <see href="https://schema.org/isUnlabelledFallback"></see></summary>
    let isUnlabelledFallback = _prefix "isUnlabelledFallback"
    /// <summary>
    /// The ISBN of the book.
    /// <see href="https://schema.org/isbn"></see></summary>
    let isbn = _prefix "isbn"
    /// <summary>
    /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
    /// <see href="https://schema.org/isicV4"></see></summary>
    let isicV4 = _prefix "isicV4"
    /// <summary>
    /// An organization identifier as defined in [ISO 6523(-1)](https://en.wikipedia.org/wiki/ISO/IEC_6523). The identifier should be in the `XXXX:YYYYYY:ZZZ` or `XXXX:YYYYYY`format. Where `XXXX` is a 4 digit _ICD_ (International Code Designator), `YYYYYY` is an _OID_ (Organization Identifier) with all formatting characters (dots, dashes, spaces) removed with a maximal length of 35 characters, and `ZZZ` is an optional OPI (Organization Part Identifier) with a maximum length of 35 characters. The various components (ICD, OID, OPI) are joined with a colon character (ASCII `0x3a`). Note that many existing organization identifiers defined as attributes like [leiCode](https://schema.org/leiCode) (`0199`), [duns](https://schema.org/duns) (`0060`) or [GLN](https://schema.org/globalLocationNumber) (`0088`) can be expressed using ISO-6523. If possible, ISO-6523 codes should be preferred to populating [vatID](https://schema.org/vatID) or [taxID](https://schema.org/taxID), as ISO identifiers are less ambiguous.
    /// <see href="https://schema.org/iso6523Code"></see></summary>
    let iso6523Code = _prefix "iso6523Code"
    /// <summary>
    /// The International Standard Recording Code for the recording.
    /// <see href="https://schema.org/isrcCode"></see></summary>
    let isrcCode = _prefix "isrcCode"
    /// <summary>
    /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
    /// <see href="https://schema.org/issn"></see></summary>
    let issn = _prefix "issn"
    /// <summary>
    /// Identifies the issue of publication; for example, "iii" or "2".
    /// <see href="https://schema.org/issueNumber"></see></summary>
    let issueNumber = _prefix "issueNumber"
    /// <summary>
    /// The organization issuing the item, for example a [[Permit]], [[Ticket]], or [[Certification]].
    /// <see href="https://schema.org/issuedBy"></see></summary>
    let issuedBy = _prefix "issuedBy"
    /// <summary>
    /// The service through which the permit was granted.
    /// <see href="https://schema.org/issuedThrough"></see></summary>
    let issuedThrough = _prefix "issuedThrough"
    /// <summary>
    /// The International Standard Musical Work Code for the composition.
    /// <see href="https://schema.org/iswcCode"></see></summary>
    let iswcCode = _prefix "iswcCode"
    /// <summary>
    /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists').
    /// <see href="https://schema.org/item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    /// A predefined value from OfferItemCondition specifying the condition of the product or service, or the products or services included in the offer. Also used for product return policies to specify the condition of products accepted for returns.
    /// <see href="https://schema.org/itemCondition"></see></summary>
    let itemCondition = _prefix "itemCondition"
    /// <summary>
    /// The type of return fees for returns of defect products.
    /// <see href="https://schema.org/itemDefectReturnFees"></see></summary>
    let itemDefectReturnFees = _prefix "itemDefectReturnFees"
    /// <summary>
    /// The method (from an enumeration) by which the customer obtains a return shipping label for a defect product.
    /// <see href="https://schema.org/itemDefectReturnLabelSource"></see></summary>
    let itemDefectReturnLabelSource = _prefix "itemDefectReturnLabelSource"

    /// <summary>
    /// Amount of shipping costs for defect product returns. Applicable when property [[itemDefectReturnFees]] equals [[ReturnShippingFees]].
    /// <see href="https://schema.org/itemDefectReturnShippingFeesAmount"></see></summary>
    let itemDefectReturnShippingFeesAmount =
        _prefix "itemDefectReturnShippingFeesAmount"

    /// <summary>
    /// For itemListElement values, you can use simple strings (e.g. "Peter", "Paul", "Mary"), existing entities, or use ListItem.\n\nText values are best if the elements in the list are plain strings. Existing entities are best for a simple, unordered list of existing things in your data. ListItem is used with ordered lists when you want to provide additional context about the element in that list or when the same item might be in different places in different lists.\n\nNote: The order of elements in your mark-up is not sufficient for indicating the order or elements.  Use ListItem with a 'position' property in such cases.
    /// <see href="https://schema.org/itemListElement"></see></summary>
    let itemListElement = _prefix "itemListElement"
    /// <summary>
    /// Type of ordering (e.g. Ascending, Descending, Unordered).
    /// <see href="https://schema.org/itemListOrder"></see></summary>
    let itemListOrder = _prefix "itemListOrder"
    /// <summary>
    /// Current location of the item.
    /// <see href="https://schema.org/itemLocation"></see></summary>
    let itemLocation = _prefix "itemLocation"
    /// <summary>
    /// An item being offered (or demanded). The transactional nature of the offer or demand is documented using [[businessFunction]], e.g. sell, lease etc. While several common expected types are listed explicitly in this definition, others can be used. Using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
    /// <see href="https://schema.org/itemOffered"></see></summary>
    let itemOffered = _prefix "itemOffered"
    /// <summary>
    /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use [[businessFunction]] to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a [[Demand]]. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
    ///
    /// <see href="https://schema.org/offers"></see></summary>
    let offers = _prefix "offers"
    /// <summary>
    /// The item that is being reviewed/rated.
    /// <see href="https://schema.org/itemReviewed"></see></summary>
    let itemReviewed = _prefix "itemReviewed"
    /// <summary>
    /// Item(s) being shipped.
    /// <see href="https://schema.org/itemShipped"></see></summary>
    let itemShipped = _prefix "itemShipped"
    /// <summary>
    /// Destination(s) ( [[Place]] ) that make up a trip. For a trip where destination order is important use [[ItemList]] to specify that order (see examples).
    /// <see href="https://schema.org/itinerary"></see></summary>
    let itinerary = _prefix "itinerary"
    /// <summary>
    /// Systematic method of naming chemical compounds as recommended by the International Union of Pure and Applied Chemistry (IUPAC).
    /// <see href="https://schema.org/iupacName"></see></summary>
    let iupacName = _prefix "iupacName"
    /// <summary>
    /// The expected duration of an employment offer as advertised by the employer. Relevant for job postings that have a clearly defined period in mind such as seasonal work, substitutes for maternal leave or any other temporary employment.
    /// <see href="https://schema.org/jobDuration"></see></summary>
    let jobDuration = _prefix "jobDuration"
    /// <summary>
    /// An indicator as to whether a position is available for an immediate start.
    /// <see href="https://schema.org/jobImmediateStart"></see></summary>
    let jobImmediateStart = _prefix "jobImmediateStart"
    /// <summary>
    /// A (typically single) geographic location associated with the job position.
    /// <see href="https://schema.org/jobLocation"></see></summary>
    let jobLocation = _prefix "jobLocation"
    /// <summary>
    /// A description of the job location (e.g. TELECOMMUTE for telecommute jobs).
    /// <see href="https://schema.org/jobLocationType"></see></summary>
    let jobLocationType = _prefix "jobLocationType"
    /// <summary>
    /// The date on which a successful applicant for this job would be expected to start work. Choose a specific date in the future or use the jobImmediateStart property to indicate the position is to be filled as soon as possible.
    /// <see href="https://schema.org/jobStartDate"></see></summary>
    let jobStartDate = _prefix "jobStartDate"
    /// <summary>
    /// The job title of the person (for example, Financial Manager).
    /// <see href="https://schema.org/jobTitle"></see></summary>
    let jobTitle = _prefix "jobTitle"
    /// <summary>
    /// Indicates a legal jurisdiction, e.g. of some legislation, or where some government service is based.
    /// <see href="https://schema.org/jurisdiction"></see></summary>
    let jurisdiction = _prefix "jurisdiction"
    /// <summary>
    /// Keywords or tags used to describe some item. Multiple textual entries in a keywords list are typically delimited by commas, or by repeating the property.
    /// <see href="https://schema.org/keywords"></see></summary>
    let keywords = _prefix "keywords"
    /// <summary>
    /// A textual description of known damages, both repaired and unrepaired.
    /// <see href="https://schema.org/knownVehicleDamages"></see></summary>
    let knownVehicleDamages = _prefix "knownVehicleDamages"
    /// <summary>
    /// The most generic bi-directional social/work relation.
    /// <see href="https://schema.org/knows"></see></summary>
    let knows = _prefix "knows"
    /// <summary>
    /// Of a [[Person]], and less typically of an [[Organization]], to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or relate this to educational content, events, objectives or [[JobPosting]] descriptions.
    /// <see href="https://schema.org/knowsAbout"></see></summary>
    let knowsAbout = _prefix "knowsAbout"
    /// <summary>
    /// Of a [[Person]], and less typically of an [[Organization]], to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the [IETF BCP 47 standard](http://tools.ietf.org/html/bcp47).
    /// <see href="https://schema.org/knowsLanguage"></see></summary>
    let knowsLanguage = _prefix "knowsLanguage"
    /// <summary>
    /// Link to the drug's label details.
    /// <see href="https://schema.org/labelDetails"></see></summary>
    let labelDetails = _prefix "labelDetails"
    /// <summary>
    /// A sub property of participant. The owner of the real estate property.
    /// <see href="https://schema.org/landlord"></see></summary>
    let landlord = _prefix "landlord"
    /// <summary>
    /// A sub property of instrument. The language used on this action.
    /// <see href="https://schema.org/language"></see></summary>
    let language = _prefix "language"
    /// <summary>
    /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
    /// <see href="https://schema.org/lastReviewed"></see></summary>
    let lastReviewed = _prefix "lastReviewed"
    /// <summary>
    /// The latitude of a location. For example ```37.42242``` ([WGS 84](https://en.wikipedia.org/wiki/World_Geodetic_System)).
    /// <see href="https://schema.org/latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// A schematic image showing the floorplan layout.
    /// <see href="https://schema.org/layoutImage"></see></summary>
    let layoutImage = _prefix "layoutImage"
    /// <summary>
    /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
    /// <see href="https://schema.org/learningResourceType"></see></summary>
    let learningResourceType = _prefix "learningResourceType"
    /// <summary>
    /// Length of the lease for some [[Accommodation]], either particular to some [[Offer]] or in some cases intrinsic to the property.
    /// <see href="https://schema.org/leaseLength"></see></summary>
    let leaseLength = _prefix "leaseLength"
    /// <summary>
    /// The legal address of an organization which acts as the officially registered address used for legal and tax purposes. The legal address can be different from the place of operations of a business and other addresses can be part of an organization.
    /// <see href="https://schema.org/legalAddress"></see></summary>
    let legalAddress = _prefix "legalAddress"
    /// <summary>
    /// The official name of the organization, e.g. the registered company name.
    /// <see href="https://schema.org/legalName"></see></summary>
    let legalName = _prefix "legalName"
    /// <summary>
    /// One or multiple persons who represent this organization legally such as CEO or sole administrator.
    /// <see href="https://schema.org/legalRepresentative"></see></summary>
    let legalRepresentative = _prefix "legalRepresentative"
    /// <summary>
    /// The drug or supplement's legal status, including any controlled substance schedules that apply.
    /// <see href="https://schema.org/legalStatus"></see></summary>
    let legalStatus = _prefix "legalStatus"
    /// <summary>
    /// Another legislation that this legislation amends, introducing legal changes.
    /// <see href="https://schema.org/legislationAmends"></see></summary>
    let legislationAmends = _prefix "legislationAmends"
    /// <summary>
    /// Another legislation that this legislation changes. This encompasses the notions of amendment, replacement, correction, repeal, or other types of change. This may be a direct change (textual or non-textual amendment) or a consequential or indirect change. The property is to be used to express the existence of a change relationship between two acts rather than the existence of a consolidated version of the text that shows the result of the change. For consolidation relationships, use the &lt;a href="/legislationConsolidates"&gt;legislationConsolidates&lt;/a&gt; property.
    /// <see href="https://schema.org/legislationChanges"></see></summary>
    let legislationChanges = _prefix "legislationChanges"
    /// <summary>
    /// Indicates that this legislation (or part of a legislation) somehow transfers another legislation in a different legislative context. This is an informative link, and it has no legal value. For legally-binding links of transposition, use the &lt;a href="/legislationTransposes"&gt;legislationTransposes&lt;/a&gt; property. For example an informative consolidated law of a European Union's member state "applies" the consolidated version of the European Directive implemented in it.
    /// <see href="https://schema.org/legislationApplies"></see></summary>
    let legislationApplies = _prefix "legislationApplies"
    /// <summary>
    /// Another legislation that this one sets into force.
    /// <see href="https://schema.org/legislationCommences"></see></summary>
    let legislationCommences = _prefix "legislationCommences"
    /// <summary>
    /// Indicates another legislation taken into account in this consolidated legislation (which is usually the product of an editorial process that revises the legislation). This property should be used multiple times to refer to both the original version or the previous consolidated version, and to the legislations making the change.
    /// <see href="https://schema.org/legislationConsolidates"></see></summary>
    let legislationConsolidates = _prefix "legislationConsolidates"
    /// <summary>
    /// Another legislation in which this one introduces textual changes, like correction of spelling mistakes, with no legal impact (for modifications that have legal impact, use &lt;a href="/legislationAmends"&gt;legislationAmends&lt;/a&gt;).
    /// <see href="https://schema.org/legislationCorrects"></see></summary>
    let legislationCorrects = _prefix "legislationCorrects"
    /// <summary>
    /// The person or organization that countersigned the legislation. Depending on the legal context, a countersignature can indicate that the signed authority undertakes to assume responsibility for texts emanating from a person who is inviolable and irresponsible, (for example a King, Grand Duc or President), or that the authority is in charge of the implementation of the text.
    /// <see href="https://schema.org/legislationCountersignedBy"></see></summary>
    let legislationCountersignedBy = _prefix "legislationCountersignedBy"
    /// <summary>
    /// The date of adoption or signature of the legislation. This is the date at which the text is officially aknowledged to be a legislation, even though it might not even be published or in force.
    /// <see href="https://schema.org/legislationDate"></see></summary>
    let legislationDate = _prefix "legislationDate"
    /// <summary>
    /// The date at which the Legislation becomes applicable. This can sometimes be distinct from the date of entry into force : a text may come in force today, and state it will become applicable in 3 months.
    /// <see href="https://schema.org/legislationDateOfApplicability"></see></summary>
    let legislationDateOfApplicability = _prefix "legislationDateOfApplicability"
    /// <summary>
    /// The point-in-time at which the provided description of the legislation is valid (e.g.: when looking at the law on the 2016-04-07 (= dateVersion), I get the consolidation of 2015-04-12 of the "National Insurance Contributions Act 2015")
    /// <see href="https://schema.org/legislationDateVersion"></see></summary>
    let legislationDateVersion = _prefix "legislationDateVersion"

    /// <summary>
    /// Indicates that this Legislation ensures the implementation of another Legislation, for example by modifying national legislations so that they do not contradict to an EU regulation or decision. This implies a legal meaning. Transpositions of EU Directive should be captured with &lt;a href="/legislationTransposes"&gt;legislationTransposes&lt;/a&gt;.
    /// <see href="https://schema.org/legislationEnsuresImplementationOf"></see></summary>
    let legislationEnsuresImplementationOf =
        _prefix "legislationEnsuresImplementationOf"

    /// <summary>
    /// An identifier for the legislation. This can be either a string-based identifier, like the CELEX at EU level or the NOR in France, or a web-based, URL/URI identifier, like an ELI (European Legislation Identifier) or an URN-Lex.
    /// <see href="https://schema.org/legislationIdentifier"></see></summary>
    let legislationIdentifier = _prefix "legislationIdentifier"
    /// <summary>
    /// The jurisdiction from which the legislation originates.
    /// <see href="https://schema.org/legislationJurisdiction"></see></summary>
    let legislationJurisdiction = _prefix "legislationJurisdiction"
    /// <summary>
    /// Whether the legislation is currently in force, not in force, or partially in force.
    /// <see href="https://schema.org/legislationLegalForce"></see></summary>
    let legislationLegalForce = _prefix "legislationLegalForce"
    /// <summary>
    /// The legal value of this legislation file. The same legislation can be written in multiple files with different legal values. Typically a digitally signed PDF have a "stronger" legal value than the HTML file of the same act.
    /// <see href="https://schema.org/legislationLegalValue"></see></summary>
    let legislationLegalValue = _prefix "legislationLegalValue"
    /// <summary>
    /// The person or organization that originally passed or made the law: typically parliament (for primary legislation) or government (for secondary legislation). This indicates the "legal author" of the law, as opposed to its physical author.
    /// <see href="https://schema.org/legislationPassedBy"></see></summary>
    let legislationPassedBy = _prefix "legislationPassedBy"
    /// <summary>
    /// Another legislation that this legislation repeals (cancels, abrogates).
    /// <see href="https://schema.org/legislationRepeals"></see></summary>
    let legislationRepeals = _prefix "legislationRepeals"
    /// <summary>
    /// An individual or organization that has some kind of responsibility for the legislation. Typically the ministry who is/was in charge of elaborating the legislation, or the adressee for potential questions about the legislation once it is published.
    /// <see href="https://schema.org/legislationResponsible"></see></summary>
    let legislationResponsible = _prefix "legislationResponsible"
    /// <summary>
    /// Indicates that this legislation (or part of legislation) fulfills the objectives set by another legislation, by passing appropriate implementation measures. Typically, some legislations of European Union's member states or regions transpose European Directives. This indicates a legally binding link between the 2 legislations.
    /// <see href="https://schema.org/legislationTransposes"></see></summary>
    let legislationTransposes = _prefix "legislationTransposes"
    /// <summary>
    /// The type of the legislation. Examples of values are "law", "act", "directive", "decree", "regulation", "statutory instrument", "loi organique", "règlement grand-ducal", etc., depending on the country.
    /// <see href="https://schema.org/legislationType"></see></summary>
    let legislationType = _prefix "legislationType"
    /// <summary>
    /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
    /// <see href="https://schema.org/leiCode"></see></summary>
    let leiCode = _prefix "leiCode"
    /// <summary>
    ///   <see href="https://schema.org/docs/collab/GLEIF"></see>
    /// </summary>
    let ``docs/collab/GLEIF`` = _prefix "docs/collab/GLEIF"
    /// <summary>
    /// A sub property of participant. The person that lends the object being borrowed.
    /// <see href="https://schema.org/lender"></see></summary>
    let lender = _prefix "lender"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is lesser than the object.
    /// <see href="https://schema.org/lesser"></see></summary>
    let lesser = _prefix "lesser"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is lesser than or equal to the object.
    /// <see href="https://schema.org/lesserOrEqual"></see></summary>
    let lesserOrEqual = _prefix "lesserOrEqual"
    /// <summary>
    /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
    /// <see href="https://schema.org/letterer"></see></summary>
    let letterer = _prefix "letterer"
    /// <summary>
    /// A license document that applies to this content, typically indicated by URL.
    /// <see href="https://schema.org/license"></see></summary>
    let license = _prefix "license"
    /// <summary>
    /// A life event like baptism, communions, Bar Mitzvahs, Aqiqah, Namakarana, Miyamairi, burial, ....
    /// <see href="https://schema.org/lifeEvent"></see></summary>
    let lifeEvent = _prefix "lifeEvent"
    /// <summary>
    /// A line is a point-to-point path consisting of two or more points. A line is expressed as a series of two or more point objects separated by space.
    /// <see href="https://schema.org/line"></see></summary>
    let line = _prefix "line"
    /// <summary>
    /// Indicates the relationship type of a Web link.
    /// <see href="https://schema.org/linkRelationship"></see></summary>
    let linkRelationship = _prefix "linkRelationship"
    /// <summary>
    /// An update to the LiveBlog.
    /// <see href="https://schema.org/liveBlogUpdate"></see></summary>
    let liveBlogUpdate = _prefix "liveBlogUpdate"
    /// <summary>
    /// Amount of mortgage mandate that can be converted into a proper mortgage at a later stage.
    /// <see href="https://schema.org/loanMortgageMandateAmount"></see></summary>
    let loanMortgageMandateAmount = _prefix "loanMortgageMandateAmount"
    /// <summary>
    /// The amount of money to pay in a single payment.
    /// <see href="https://schema.org/loanPaymentAmount"></see></summary>
    let loanPaymentAmount = _prefix "loanPaymentAmount"
    /// <summary>
    /// Frequency of payments due, i.e. number of months between payments. This is defined as a frequency, i.e. the reciprocal of a period of time.
    /// <see href="https://schema.org/loanPaymentFrequency"></see></summary>
    let loanPaymentFrequency = _prefix "loanPaymentFrequency"
    /// <summary>
    /// A form of paying back money previously borrowed from a lender. Repayment usually takes the form of periodic payments that normally include part principal plus interest in each payment.
    /// <see href="https://schema.org/loanRepaymentForm"></see></summary>
    let loanRepaymentForm = _prefix "loanRepaymentForm"
    /// <summary>
    /// The duration of the loan or credit agreement.
    /// <see href="https://schema.org/loanTerm"></see></summary>
    let loanTerm = _prefix "loanTerm"
    /// <summary>
    /// The type of a loan or credit.
    /// <see href="https://schema.org/loanType"></see></summary>
    let loanType = _prefix "loanType"
    /// <summary>
    /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
    /// <see href="https://schema.org/locationCreated"></see></summary>
    let locationCreated = _prefix "locationCreated"
    /// <summary>
    /// A full description of the lodging unit.
    /// <see href="https://schema.org/lodgingUnitDescription"></see></summary>
    let lodgingUnitDescription = _prefix "lodgingUnitDescription"
    /// <summary>
    /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
    /// <see href="https://schema.org/lodgingUnitType"></see></summary>
    let lodgingUnitType = _prefix "lodgingUnitType"
    /// <summary>
    /// An associated logo.
    /// <see href="https://schema.org/logo"></see></summary>
    let logo = _prefix "logo"
    /// <summary>
    /// The longitude of a location. For example ```-122.08585``` ([WGS 84](https://en.wikipedia.org/wiki/World_Geodetic_System)).
    /// <see href="https://schema.org/longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// A sub property of participant. The loser of the action.
    /// <see href="https://schema.org/loser"></see></summary>
    let loser = _prefix "loser"
    /// <summary>
    /// The lowest price of all offers available.\n\nUsage guidelines:\n\n* Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similar Unicode symbols.\n* Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
    /// <see href="https://schema.org/lowPrice"></see></summary>
    let lowPrice = _prefix "lowPrice"
    /// <summary>
    /// The person who wrote the words.
    /// <see href="https://schema.org/lyricist"></see></summary>
    let lyricist = _prefix "lyricist"
    /// <summary>
    /// The words in the song.
    /// <see href="https://schema.org/lyrics"></see></summary>
    let lyrics = _prefix "lyrics"
    /// <summary>
    /// Indicates the primary entity described in some page or other CreativeWork.
    /// <see href="https://schema.org/mainEntity"></see></summary>
    let mainEntity = _prefix "mainEntity"
    /// <summary>
    /// Indicates a page (or other CreativeWork) for which this thing is the main entity being described. See [background notes](/docs/datamodel.html#mainEntityBackground) for details.
    /// <see href="https://schema.org/mainEntityOfPage"></see></summary>
    let mainEntityOfPage = _prefix "mainEntityOfPage"
    /// <summary>
    /// A maintainer of a [[Dataset]], software package ([[SoftwareApplication]]), or other [[Project]]. A maintainer is a [[Person]] or [[Organization]] that manages contributions to, and/or publication of, some (typically complex) artifact. It is common for distributions of software and data to be based on "upstream" sources. When [[maintainer]] is applied to a specific version of something e.g. a particular version or packaging of a [[Dataset]], it is always  possible that the upstream source has a different maintainer. The [[isBasedOn]] property can be used to indicate such relationships between datasets to make the different maintenance roles clear. Similarly in the case of software, a package may have dedicated maintainers working on integration into software distributions such as Ubuntu, as well as upstream maintainers of the underlying work.
    ///
    /// <see href="https://schema.org/maintainer"></see></summary>
    let maintainer = _prefix "maintainer"
    /// <summary>
    /// A pointer to products or services offered by the organization or person.
    /// <see href="https://schema.org/makesOffer"></see></summary>
    let makesOffer = _prefix "makesOffer"
    /// <summary>
    /// A pointer to the organization or person making the offer.
    /// <see href="https://schema.org/offeredBy"></see></summary>
    let offeredBy = _prefix "offeredBy"
    /// <summary>
    /// The manufacturer of the product.
    /// <see href="https://schema.org/manufacturer"></see></summary>
    let manufacturer = _prefix "manufacturer"
    /// <summary>
    /// A URL to a map of the place.
    /// <see href="https://schema.org/map"></see></summary>
    let map = _prefix "map"
    /// <summary>
    /// Indicates the kind of Map, from the MapCategoryType Enumeration.
    /// <see href="https://schema.org/mapType"></see></summary>
    let mapType = _prefix "mapType"
    /// <summary>
    /// A URL to a map of the place.
    /// <see href="https://schema.org/maps"></see></summary>
    let maps = _prefix "maps"
    /// <summary>
    /// A [[marginOfError]] for an [[Observation]].
    /// <see href="https://schema.org/marginOfError"></see></summary>
    let marginOfError = _prefix "marginOfError"
    /// <summary>
    /// For a [[NewsMediaOrganization]], a link to the masthead page or a page listing top editorial management.
    /// <see href="https://schema.org/masthead"></see></summary>
    let masthead = _prefix "masthead"
    /// <summary>
    /// The quantity of the materials being described or an expression of the physical space they occupy.
    /// <see href="https://schema.org/materialExtent"></see></summary>
    let materialExtent = _prefix "materialExtent"
    /// <summary>
    /// A mathematical expression (e.g. 'x^2-3x=0') that may be solved for a specific variable, simplified, or transformed. This can take many formats, e.g. LaTeX, Ascii-Math, or math as you would write with a keyboard.
    /// <see href="https://schema.org/mathExpression"></see></summary>
    let mathExpression = _prefix "mathExpression"
    /// <summary>
    /// The highest price if the price is a range.
    /// <see href="https://schema.org/maxPrice"></see></summary>
    let maxPrice = _prefix "maxPrice"
    /// <summary>
    /// The upper value of some characteristic or property.
    /// <see href="https://schema.org/maxValue"></see></summary>
    let maxValue = _prefix "maxValue"
    /// <summary>
    /// The total number of individuals that may attend an event or venue.
    /// <see href="https://schema.org/maximumAttendeeCapacity"></see></summary>
    let maximumAttendeeCapacity = _prefix "maximumAttendeeCapacity"
    /// <summary>
    /// The maximum number of students who may be enrolled in the program.
    /// <see href="https://schema.org/maximumEnrollment"></see></summary>
    let maximumEnrollment = _prefix "maximumEnrollment"
    /// <summary>
    /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
    /// <see href="https://schema.org/maximumIntake"></see></summary>
    let maximumIntake = _prefix "maximumIntake"
    /// <summary>
    /// The maximum physical attendee capacity of an [[Event]] whose [[eventAttendanceMode]] is [[OfflineEventAttendanceMode]] (or the offline aspects, in the case of a [[MixedEventAttendanceMode]]).
    /// <see href="https://schema.org/maximumPhysicalAttendeeCapacity"></see></summary>
    let maximumPhysicalAttendeeCapacity = _prefix "maximumPhysicalAttendeeCapacity"
    /// <summary>
    /// The maximum virtual attendee capacity of an [[Event]] whose [[eventAttendanceMode]] is [[OnlineEventAttendanceMode]] (or the online aspects, in the case of a [[MixedEventAttendanceMode]]).
    /// <see href="https://schema.org/maximumVirtualAttendeeCapacity"></see></summary>
    let maximumVirtualAttendeeCapacity = _prefix "maximumVirtualAttendeeCapacity"
    /// <summary>
    /// Description of the meals that will be provided or available for purchase.
    /// <see href="https://schema.org/mealService"></see></summary>
    let mealService = _prefix "mealService"
    /// <summary>
    /// The measuredProperty of an [[Observation]], typically via its [[StatisticalVariable]]. There are various kinds of applicable [[Property]]: a schema.org property, a property from other RDF-compatible systems, e.g. W3C RDF Data Cube, Data Commons, Wikidata, or schema.org extensions such as [GS1's](https://www.gs1.org/voc/?show=properties).
    /// <see href="https://schema.org/measuredProperty"></see></summary>
    let measuredProperty = _prefix "measuredProperty"
    /// <summary>
    /// Identifies the denominator variable when an observation represents a ratio or percentage.
    /// <see href="https://schema.org/measurementDenominator"></see></summary>
    let measurementDenominator = _prefix "measurementDenominator"
    /// <summary>
    /// A subproperty of [[measurementTechnique]] that can be used for specifying specific methods, in particular via [[MeasurementMethodEnum]].
    /// <see href="https://schema.org/measurementMethod"></see></summary>
    let measurementMethod = _prefix "measurementMethod"
    /// <summary>
    /// A technique, method or technology used in an [[Observation]], [[StatisticalVariable]] or [[Dataset]] (or [[DataDownload]], [[DataCatalog]]), corresponding to the method used for measuring the corresponding variable(s) (for datasets, described using [[variableMeasured]]; for [[Observation]], a [[StatisticalVariable]]). Often but not necessarily each [[variableMeasured]] will have an explicit representation as (or mapping to) an property such as those defined in Schema.org, or other RDF vocabularies and "knowledge graphs". In that case the subproperty of [[variableMeasured]] called [[measuredProperty]] is applicable.
    ///
    /// The [[measurementTechnique]] property helps when extra clarification is needed about how a [[measuredProperty]] was measured. This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but can often serve as a high level summary for dataset discovery.
    ///
    /// For example, if [[variableMeasured]] is: molecule concentration, [[measurementTechnique]] could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence". If the [[variableMeasured]] is "depression rating", the [[measurementTechnique]] could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".
    ///
    /// If there are several [[variableMeasured]] properties recorded for some given data object, use a [[PropertyValue]] for each [[variableMeasured]] and attach the corresponding [[measurementTechnique]]. The value can also be from an enumeration, organized as a [[MeasurementMethodEnum]].
    /// <see href="https://schema.org/measurementTechnique"></see></summary>
    let measurementTechnique = _prefix "measurementTechnique"
    /// <summary>
    /// Provides additional qualification to an observation. For example, a GDP observation measures the Nominal value.
    /// <see href="https://schema.org/measurementQualifier"></see></summary>
    let measurementQualifier = _prefix "measurementQualifier"
    /// <summary>
    /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
    /// <see href="https://schema.org/mechanismOfAction"></see></summary>
    let mechanismOfAction = _prefix "mechanismOfAction"
    /// <summary>
    /// Indicates a MediaManipulationRatingEnumeration classification of a media object (in the context of how it was published or shared).
    /// <see href="https://schema.org/mediaAuthenticityCategory"></see></summary>
    let mediaAuthenticityCategory = _prefix "mediaAuthenticityCategory"
    /// <summary>
    /// In the context of a [[MediaReview]], indicates specific media item(s) that are grouped using a [[MediaReviewItem]].
    /// <see href="https://schema.org/mediaItemAppearance"></see></summary>
    let mediaItemAppearance = _prefix "mediaItemAppearance"
    /// <summary>
    /// The median value.
    /// <see href="https://schema.org/median"></see></summary>
    let median = _prefix "median"
    /// <summary>
    /// Medical audience for page.
    /// <see href="https://schema.org/medicalAudience"></see></summary>
    let medicalAudience = _prefix "medicalAudience"
    /// <summary>
    /// A medical specialty of the provider.
    /// <see href="https://schema.org/medicalSpecialty"></see></summary>
    let medicalSpecialty = _prefix "medicalSpecialty"
    /// <summary>
    /// The system of medicine that includes this MedicalEntity, for example 'evidence-based', 'homeopathic', 'chiropractic', etc.
    /// <see href="https://schema.org/medicineSystem"></see></summary>
    let medicineSystem = _prefix "medicineSystem"
    /// <summary>
    /// Indicates that the vehicle meets the respective emission standard.
    /// <see href="https://schema.org/meetsEmissionStandard"></see></summary>
    let meetsEmissionStandard = _prefix "meetsEmissionStandard"
    /// <summary>
    /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
    /// <see href="https://schema.org/member"></see></summary>
    let member_ = _prefix "member"
    /// <summary>
    /// A member of this organization.
    /// <see href="https://schema.org/members"></see></summary>
    let members = _prefix "members"
    /// <summary>
    /// A unique identifier for the membership.
    /// <see href="https://schema.org/membershipNumber"></see></summary>
    let membershipNumber = _prefix "membershipNumber"
    /// <summary>
    /// The number of membership points earned by the member. If necessary, the unitText can be used to express the units the points are issued in. (E.g. stars, miles, etc.)
    /// <see href="https://schema.org/membershipPointsEarned"></see></summary>
    let membershipPointsEarned = _prefix "membershipPointsEarned"
    /// <summary>
    /// Minimum memory requirements.
    /// <see href="https://schema.org/memoryRequirements"></see></summary>
    let memoryRequirements = _prefix "memoryRequirements"
    /// <summary>
    /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
    /// <see href="https://schema.org/mentions"></see></summary>
    let mentions = _prefix "mentions"
    /// <summary>
    /// Either the actual menu as a structured representation, as text, or a URL of the menu.
    /// <see href="https://schema.org/menu"></see></summary>
    let menu = _prefix "menu"
    /// <summary>
    /// Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.
    /// <see href="https://schema.org/menuAddOn"></see></summary>
    let menuAddOn = _prefix "menuAddOn"
    /// <summary>
    /// 'merchant' is an out-dated term for 'seller'.
    /// <see href="https://schema.org/merchant"></see></summary>
    let merchant = _prefix "merchant"
    /// <summary>
    /// An entity which offers (sells / leases / lends / loans) the services / goods.  A seller may also be a provider.
    /// <see href="https://schema.org/seller"></see></summary>
    let seller = _prefix "seller"
    /// <summary>
    /// Specifies either a fixed return date or the number of days (from the delivery date) that a product can be returned. Used when the [[returnPolicyCategory]] property is specified as [[MerchantReturnFiniteReturnWindow]].
    /// <see href="https://schema.org/merchantReturnDays"></see></summary>
    let merchantReturnDays = _prefix "merchantReturnDays"
    /// <summary>
    /// Specifies a Web page or service by URL, for product returns.
    /// <see href="https://schema.org/merchantReturnLink"></see></summary>
    let merchantReturnLink = _prefix "merchantReturnLink"
    /// <summary>
    /// A CreativeWork attached to the message.
    /// <see href="https://schema.org/messageAttachment"></see></summary>
    let messageAttachment = _prefix "messageAttachment"
    /// <summary>
    /// The total distance travelled by the particular vehicle since its initial production, as read from its odometer.\n\nTypical unit code(s): KMT for kilometers, SMI for statute miles.
    /// <see href="https://schema.org/mileageFromOdometer"></see></summary>
    let mileageFromOdometer = _prefix "mileageFromOdometer"
    /// <summary>
    /// The lowest price if the price is a range.
    /// <see href="https://schema.org/minPrice"></see></summary>
    let minPrice = _prefix "minPrice"
    /// <summary>
    /// The lower value of some characteristic or property.
    /// <see href="https://schema.org/minValue"></see></summary>
    let minValue = _prefix "minValue"
    /// <summary>
    /// The minimum payment required at this time.
    /// <see href="https://schema.org/minimumPaymentDue"></see></summary>
    let minimumPaymentDue = _prefix "minimumPaymentDue"
    /// <summary>
    /// For a [[NewsMediaOrganization]], a statement on coverage priorities, including any public agenda or stance on issues.
    /// <see href="https://schema.org/missionCoveragePrioritiesPolicy"></see></summary>
    let missionCoveragePrioritiesPolicy = _prefix "missionCoveragePrioritiesPolicy"
    /// <summary>
    /// The [[mobileUrl]] property is provided for specific situations in which data consumers need to determine whether one of several provided URLs is a dedicated 'mobile site'.
    ///
    /// To discourage over-use, and reflecting intial usecases, the property is expected only on [[Product]] and [[Offer]], rather than [[Thing]]. The general trend in web technology is towards [responsive design](https://en.wikipedia.org/wiki/Responsive_web_design) in which content can be flexibly adapted to a wide range of browsing environments. Pages and sites referenced with the long-established [[url]] property should ideally also be usable on a wide variety of devices, including mobile phones. In most cases, it would be pointless and counter productive to attempt to update all [[url]] markup to use [[mobileUrl]] for more mobile-oriented pages. The property is intended for the case when items (primarily [[Product]] and [[Offer]]) have extra URLs hosted on an additional "mobile site" alongside the main one. It should not be taken as an endorsement of this publication style.
    ///
    /// <see href="https://schema.org/mobileUrl"></see></summary>
    let mobileUrl = _prefix "mobileUrl"
    /// <summary>
    /// The model of the product. Use with the URL of a ProductModel or a textual representation of the model identifier. The URL of the ProductModel can be from an external source. It is recommended to additionally provide strong product identifiers via the gtin8/gtin13/gtin14 and mpn properties.
    /// <see href="https://schema.org/model"></see></summary>
    let model = _prefix "model"
    /// <summary>
    /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
    /// <see href="https://schema.org/modelDate"></see></summary>
    let modelDate = _prefix "modelDate"
    /// <summary>
    /// The date and time the reservation was modified.
    /// <see href="https://schema.org/modifiedTime"></see></summary>
    let modifiedTime = _prefix "modifiedTime"
    /// <summary>
    /// The empirical formula is the simplest whole number ratio of all the atoms in a molecule.
    /// <see href="https://schema.org/molecularFormula"></see></summary>
    let molecularFormula = _prefix "molecularFormula"
    /// <summary>
    /// This is the molecular weight of the entity being described, not of the parent. Units should be included in the form '&amp;lt;Number&amp;gt; &amp;lt;unit&amp;gt;', for example '12 amu' or as '&amp;lt;QuantitativeValue&amp;gt;.
    /// <see href="https://schema.org/molecularWeight"></see></summary>
    let molecularWeight = _prefix "molecularWeight"
    /// <summary>
    /// The monoisotopic mass is the sum of the masses of the atoms in a molecule using the unbound, ground-state, rest mass of the principal (most abundant) isotope for each element instead of the isotopic average mass. Please include the units in the form '&amp;lt;Number&amp;gt; &amp;lt;unit&amp;gt;', for example '770.230488 g/mol' or as '&amp;lt;QuantitativeValue&amp;gt;.
    /// <see href="https://schema.org/monoisotopicMolecularWeight"></see></summary>
    let monoisotopicMolecularWeight = _prefix "monoisotopicMolecularWeight"
    /// <summary>
    /// The minimum payment is the lowest amount of money that one is required to pay on a credit card statement each month.
    /// <see href="https://schema.org/monthlyMinimumRepaymentAmount"></see></summary>
    let monthlyMinimumRepaymentAmount = _prefix "monthlyMinimumRepaymentAmount"
    /// <summary>
    /// Indicates the minimal number of months of experience required for a position.
    /// <see href="https://schema.org/monthsOfExperience"></see></summary>
    let monthsOfExperience = _prefix "monthsOfExperience"
    /// <summary>
    /// The Manufacturer Part Number (MPN) of the product, or the product to which the offer refers.
    /// <see href="https://schema.org/mpn"></see></summary>
    let mpn = _prefix "mpn"
    /// <summary>
    /// Whether multiple values are allowed for the property.  Default is false.
    /// <see href="https://schema.org/multipleValues"></see></summary>
    let multipleValues = _prefix "multipleValues"
    /// <summary>
    /// The movement the muscle generates.
    /// <see href="https://schema.org/muscleAction"></see></summary>
    let muscleAction = _prefix "muscleAction"
    /// <summary>
    /// An arrangement derived from the composition.
    /// <see href="https://schema.org/musicArrangement"></see></summary>
    let musicArrangement = _prefix "musicArrangement"
    /// <summary>
    /// The composer of the soundtrack.
    /// <see href="https://schema.org/musicBy"></see></summary>
    let musicBy = _prefix "musicBy"
    /// <summary>
    /// The type of composition (e.g. overture, sonata, symphony, etc.).
    /// <see href="https://schema.org/musicCompositionForm"></see></summary>
    let musicCompositionForm = _prefix "musicCompositionForm"
    /// <summary>
    /// A member of a music group&amp;#x2014;for example, John, Paul, George, or Ringo.
    /// <see href="https://schema.org/musicGroupMember"></see></summary>
    let musicGroupMember = _prefix "musicGroupMember"
    /// <summary>
    /// Format of this release (the type of recording media used, i.e. compact disc, digital media, LP, etc.).
    /// <see href="https://schema.org/musicReleaseFormat"></see></summary>
    let musicReleaseFormat = _prefix "musicReleaseFormat"
    /// <summary>
    /// The key, mode, or scale this composition uses.
    /// <see href="https://schema.org/musicalKey"></see></summary>
    let musicalKey = _prefix "musicalKey"
    /// <summary>
    /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
    /// <see href="https://schema.org/naics"></see></summary>
    let naics = _prefix "naics"
    /// <summary>
    /// The name of the item.
    /// <see href="https://schema.org/name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// A position played, performed or filled by a person or organization, as part of an organization. For example, an athlete in a SportsTeam might play in the position named 'Quarterback'.
    /// <see href="https://schema.org/namedPosition"></see></summary>
    let namedPosition = _prefix "namedPosition"
    /// <summary>
    /// A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.
    /// <see href="https://schema.org/roleName"></see></summary>
    let roleName = _prefix "roleName"
    /// <summary>
    /// Nationality of the person.
    /// <see href="https://schema.org/nationality"></see></summary>
    let nationality = _prefix "nationality"
    /// <summary>
    /// The expected progression of the condition if it is not treated and allowed to progress naturally.
    /// <see href="https://schema.org/naturalProgression"></see></summary>
    let naturalProgression = _prefix "naturalProgression"
    /// <summary>
    /// Provides negative considerations regarding something, most typically in pro/con lists for reviews (alongside [[positiveNotes]]). For symmetry
    ///
    /// In the case of a [[Review]], the property describes the [[itemReviewed]] from the perspective of the review; in the case of a [[Product]], the product itself is being described. Since product descriptions
    /// tend to emphasise positive claims, it may be relatively unusual to find [[negativeNotes]] used in this way. Nevertheless for the sake of symmetry, [[negativeNotes]] can be used on [[Product]].
    ///
    /// The property values can be expressed either as unstructured text (repeated as necessary), or if ordered, as a list (in which case the most negative is at the beginning of the list).
    /// <see href="https://schema.org/negativeNotes"></see></summary>
    let negativeNotes = _prefix "negativeNotes"
    /// <summary>
    /// The underlying innervation associated with the muscle.
    /// <see href="https://schema.org/nerve"></see></summary>
    let nerve = _prefix "nerve"
    /// <summary>
    /// The neurological pathway extension that involves muscle control.
    /// <see href="https://schema.org/nerveMotor"></see></summary>
    let nerveMotor = _prefix "nerveMotor"
    /// <summary>
    /// The total financial value of the person as calculated by subtracting the total value of liabilities from the total value of assets.
    /// <see href="https://schema.org/netWorth"></see></summary>
    let netWorth = _prefix "netWorth"
    /// <summary>
    /// Indicates a page with news updates and guidelines. This could often be (but is not required to be) the main page containing [[SpecialAnnouncement]] markup on a site.
    /// <see href="https://schema.org/newsUpdatesAndGuidelines"></see></summary>
    let newsUpdatesAndGuidelines = _prefix "newsUpdatesAndGuidelines"
    /// <summary>
    /// A link to the ListItem that follows the current one.
    /// <see href="https://schema.org/nextItem"></see></summary>
    let nextItem = _prefix "nextItem"
    /// <summary>
    /// For a [[NewsMediaOrganization]] or other news-related [[Organization]], a statement explaining when authors of articles are not named in bylines.
    /// <see href="https://schema.org/noBylinesPolicy"></see></summary>
    let noBylinesPolicy = _prefix "noBylinesPolicy"
    /// <summary>
    /// This ordering relation for qualitative values indicates that the subject is not equal to the object.
    /// <see href="https://schema.org/nonEqual"></see></summary>
    let nonEqual = _prefix "nonEqual"
    /// <summary>
    /// The generic name of this drug or supplement.
    /// <see href="https://schema.org/nonProprietaryName"></see></summary>
    let nonProprietaryName = _prefix "nonProprietaryName"
    /// <summary>
    /// nonprofitStatus indicates the legal status of a non-profit organization in its primary place of business.
    /// <see href="https://schema.org/nonprofitStatus"></see></summary>
    let nonprofitStatus = _prefix "nonprofitStatus"
    /// <summary>
    /// Range of acceptable values for a typical patient, when applicable.
    /// <see href="https://schema.org/normalRange"></see></summary>
    let normalRange = _prefix "normalRange"
    /// <summary>
    /// Indicates the [NATO stock number](https://en.wikipedia.org/wiki/NATO_Stock_Number) (nsn) of a [[Product]].
    /// <see href="https://schema.org/nsn"></see></summary>
    let nsn = _prefix "nsn"
    /// <summary>
    /// The number of adults staying in the unit.
    /// <see href="https://schema.org/numAdults"></see></summary>
    let numAdults = _prefix "numAdults"
    /// <summary>
    /// The number of children staying in the unit.
    /// <see href="https://schema.org/numChildren"></see></summary>
    let numChildren = _prefix "numChildren"
    /// <summary>
    /// Indicates the number of constraints property values defined for a particular [[ConstraintNode]] such as [[StatisticalVariable]]. This helps applications understand if they have access to a sufficiently complete description of a [[StatisticalVariable]] or other construct that is defined using properties on template-style nodes.
    /// <see href="https://schema.org/numConstraints"></see></summary>
    let numConstraints = _prefix "numConstraints"
    /// <summary>
    /// Limits the number of items being shipped for which these conditions apply.
    /// <see href="https://schema.org/numItems"></see></summary>
    let numItems = _prefix "numItems"
    /// <summary>
    /// The number of tracks in this album or playlist.
    /// <see href="https://schema.org/numTracks"></see></summary>
    let numTracks = _prefix "numTracks"
    /// <summary>
    /// Indicates the total (available plus unavailable) number of accommodation units in an [[ApartmentComplex]], or the number of accommodation units for a specific [[FloorPlan]] (within its specific [[ApartmentComplex]]). See also [[numberOfAvailableAccommodationUnits]].
    /// <see href="https://schema.org/numberOfAccommodationUnits"></see></summary>
    let numberOfAccommodationUnits = _prefix "numberOfAccommodationUnits"
    /// <summary>
    /// The number or type of airbags in the vehicle.
    /// <see href="https://schema.org/numberOfAirbags"></see></summary>
    let numberOfAirbags = _prefix "numberOfAirbags"

    /// <summary>
    /// Indicates the number of available accommodation units in an [[ApartmentComplex]], or the number of accommodation units for a specific [[FloorPlan]] (within its specific [[ApartmentComplex]]). See also [[numberOfAccommodationUnits]].
    /// <see href="https://schema.org/numberOfAvailableAccommodationUnits"></see></summary>
    let numberOfAvailableAccommodationUnits =
        _prefix "numberOfAvailableAccommodationUnits"

    /// <summary>
    /// The number of axles.\n\nTypical unit code(s): C62.
    /// <see href="https://schema.org/numberOfAxles"></see></summary>
    let numberOfAxles = _prefix "numberOfAxles"
    /// <summary>
    /// The total integer number of bathrooms in some [[Accommodation]], following real estate conventions as [documented in RESO](https://ddwiki.reso.org/display/DDW17/BathroomsTotalInteger+Field): "The simple sum of the number of bathrooms. For example for a property with two Full Bathrooms and one Half Bathroom, the Bathrooms Total Integer will be 3.". See also [[numberOfRooms]].
    /// <see href="https://schema.org/numberOfBathroomsTotal"></see></summary>
    let numberOfBathroomsTotal = _prefix "numberOfBathroomsTotal"
    /// <summary>
    /// The total integer number of bedrooms in a some [[Accommodation]], [[ApartmentComplex]] or [[FloorPlan]].
    /// <see href="https://schema.org/numberOfBedrooms"></see></summary>
    let numberOfBedrooms = _prefix "numberOfBedrooms"
    /// <summary>
    /// The quantity of the given bed type available in the HotelRoom, Suite, House, or Apartment.
    /// <see href="https://schema.org/numberOfBeds"></see></summary>
    let numberOfBeds = _prefix "numberOfBeds"
    /// <summary>
    /// The number of credits or units awarded by a Course or required to complete an EducationalOccupationalProgram.
    /// <see href="https://schema.org/numberOfCredits"></see></summary>
    let numberOfCredits = _prefix "numberOfCredits"
    /// <summary>
    /// The number of doors.\n\nTypical unit code(s): C62.
    /// <see href="https://schema.org/numberOfDoors"></see></summary>
    let numberOfDoors = _prefix "numberOfDoors"
    /// <summary>
    /// The number of employees in an organization, e.g. business.
    /// <see href="https://schema.org/numberOfEmployees"></see></summary>
    let numberOfEmployees = _prefix "numberOfEmployees"
    /// <summary>
    /// The number of episodes in this season or series.
    /// <see href="https://schema.org/numberOfEpisodes"></see></summary>
    let numberOfEpisodes = _prefix "numberOfEpisodes"
    /// <summary>
    /// The total number of forward gears available for the transmission system of the vehicle.\n\nTypical unit code(s): C62.
    /// <see href="https://schema.org/numberOfForwardGears"></see></summary>
    let numberOfForwardGears = _prefix "numberOfForwardGears"
    /// <summary>
    /// Number of full bathrooms - The total number of full and ¾ bathrooms in an [[Accommodation]]. This corresponds to the [BathroomsFull field in RESO](https://ddwiki.reso.org/display/DDW17/BathroomsFull+Field).
    /// <see href="https://schema.org/numberOfFullBathrooms"></see></summary>
    let numberOfFullBathrooms = _prefix "numberOfFullBathrooms"
    /// <summary>
    /// The number of items in an ItemList. Note that some descriptions might not fully describe all items in a list (e.g., multi-page pagination); in such cases, the numberOfItems would be for the entire list.
    /// <see href="https://schema.org/numberOfItems"></see></summary>
    let numberOfItems = _prefix "numberOfItems"
    /// <summary>
    /// The number of payments contractually required at origination to repay the loan. For monthly paying loans this is the number of months from the contractual first payment date to the maturity date.
    /// <see href="https://schema.org/numberOfLoanPayments"></see></summary>
    let numberOfLoanPayments = _prefix "numberOfLoanPayments"
    /// <summary>
    /// The number of pages in the book.
    /// <see href="https://schema.org/numberOfPages"></see></summary>
    let numberOfPages = _prefix "numberOfPages"
    /// <summary>
    /// Number of partial bathrooms - The total number of half and ¼ bathrooms in an [[Accommodation]]. This corresponds to the [BathroomsPartial field in RESO](https://ddwiki.reso.org/display/DDW17/BathroomsPartial+Field).
    /// <see href="https://schema.org/numberOfPartialBathrooms"></see></summary>
    let numberOfPartialBathrooms = _prefix "numberOfPartialBathrooms"
    /// <summary>
    /// Indicate how many people can play this game (minimum, maximum, or range).
    /// <see href="https://schema.org/numberOfPlayers"></see></summary>
    let numberOfPlayers = _prefix "numberOfPlayers"
    /// <summary>
    /// The number of owners of the vehicle, including the current one.\n\nTypical unit code(s): C62.
    /// <see href="https://schema.org/numberOfPreviousOwners"></see></summary>
    let numberOfPreviousOwners = _prefix "numberOfPreviousOwners"
    /// <summary>
    /// The number of rooms (excluding bathrooms and closets) of the accommodation or lodging business.
    /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
    /// <see href="https://schema.org/numberOfRooms"></see></summary>
    let numberOfRooms = _prefix "numberOfRooms"
    /// <summary>
    /// The number of seasons in this series.
    /// <see href="https://schema.org/numberOfSeasons"></see></summary>
    let numberOfSeasons = _prefix "numberOfSeasons"
    /// <summary>
    /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
    /// <see href="https://schema.org/numberedPosition"></see></summary>
    let numberedPosition = _prefix "numberedPosition"
    /// <summary>
    /// Nutrition information about the recipe or menu item.
    /// <see href="https://schema.org/nutrition"></see></summary>
    let nutrition = _prefix "nutrition"
    /// <summary>
    /// The [[observationAbout]] property identifies an entity, often a [[Place]], associated with an [[Observation]].
    /// <see href="https://schema.org/observationAbout"></see></summary>
    let observationAbout = _prefix "observationAbout"
    /// <summary>
    /// The observationDate of an [[Observation]].
    /// <see href="https://schema.org/observationDate"></see></summary>
    let observationDate = _prefix "observationDate"
    /// <summary>
    /// The length of time an Observation took place over. The format follows `P[0-9]*[Y|M|D|h|m|s]`. For example, P1Y is Period 1 Year, P3M is Period 3 Months, P3h is Period 3 hours.
    /// <see href="https://schema.org/observationPeriod"></see></summary>
    let observationPeriod = _prefix "observationPeriod"
    /// <summary>
    /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
    /// Typical unit code(s): C62 for person.
    /// <see href="https://schema.org/occupancy"></see></summary>
    let occupancy = _prefix "occupancy"
    /// <summary>
    ///  The region/country for which this occupational description is appropriate. Note that educational requirements and qualifications can vary between jurisdictions.
    /// <see href="https://schema.org/occupationLocation"></see></summary>
    let occupationLocation = _prefix "occupationLocation"
    /// <summary>
    /// A category describing the job, preferably using a term from a taxonomy such as [BLS O*NET-SOC](http://www.onetcenter.org/taxonomy.html), [ISCO-08](https://www.ilo.org/public/english/bureau/stat/isco/isco08/) or similar, with the property repeated for each applicable value. Ideally the taxonomy should be identified, and both the textual label and formal code for the category should be provided.\n
    /// Note: for historical reasons, any textual label and formal code provided as a literal may be assumed to be from O*NET-SOC.
    /// <see href="https://schema.org/occupationalCategory"></see></summary>
    let occupationalCategory = _prefix "occupationalCategory"
    /// <summary>
    /// A description of the qualification, award, certificate, diploma or other occupational credential awarded as a consequence of successful completion of this course or program.
    /// <see href="https://schema.org/occupationalCredentialAwarded"></see></summary>
    let occupationalCredentialAwarded = _prefix "occupationalCredentialAwarded"
    /// <summary>
    /// The number of offers for the product.
    /// <see href="https://schema.org/offerCount"></see></summary>
    let offerCount = _prefix "offerCount"
    /// <summary>
    /// Whether prescriptions can be delivered by mail.
    /// <see href="https://schema.org/offersPrescriptionByMail"></see></summary>
    let offersPrescriptionByMail = _prefix "offersPrescriptionByMail"
    /// <summary>
    /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.\n\n* Days are specified using the following two-letter combinations: ```Mo```, ```Tu```, ```We```, ```Th```, ```Fr```, ```Sa```, ```Su```.\n* Times are specified using 24:00 format. For example, 3pm is specified as ```15:00```, 10am as ```10:00```. \n* Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.\n* If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.
    /// <see href="https://schema.org/openingHours"></see></summary>
    let openingHours = _prefix "openingHours"
    /// <summary>
    /// The opening hours of a certain place.
    /// <see href="https://schema.org/openingHoursSpecification"></see></summary>
    let openingHoursSpecification = _prefix "openingHoursSpecification"
    /// <summary>
    /// The opening hour of the place or service on the given day(s) of the week.
    /// <see href="https://schema.org/opens"></see></summary>
    let opens = _prefix "opens"
    /// <summary>
    /// Operating systems supported (Windows 7, OS X 10.6, Android 1.6).
    /// <see href="https://schema.org/operatingSystem"></see></summary>
    let operatingSystem = _prefix "operatingSystem"
    /// <summary>
    /// A sub property of participant. The opponent on this action.
    /// <see href="https://schema.org/opponent"></see></summary>
    let opponent = _prefix "opponent"
    /// <summary>
    /// A sub property of object. The options subject to this action.
    /// <see href="https://schema.org/option"></see></summary>
    let option = _prefix "option"
    /// <summary>
    /// Date order was placed.
    /// <see href="https://schema.org/orderDate"></see></summary>
    let orderDate = _prefix "orderDate"
    /// <summary>
    /// The delivery of the parcel related to this order or order item.
    /// <see href="https://schema.org/orderDelivery"></see></summary>
    let orderDelivery = _prefix "orderDelivery"
    /// <summary>
    /// The identifier of the order item.
    /// <see href="https://schema.org/orderItemNumber"></see></summary>
    let orderItemNumber = _prefix "orderItemNumber"
    /// <summary>
    /// The current status of the order item.
    /// <see href="https://schema.org/orderItemStatus"></see></summary>
    let orderItemStatus = _prefix "orderItemStatus"
    /// <summary>
    /// The identifier of the transaction.
    /// <see href="https://schema.org/orderNumber"></see></summary>
    let orderNumber = _prefix "orderNumber"
    /// <summary>
    /// Value representing the fraction of the value of the order that is charged as shipping cost. Example: 0.10 would mean shipping rate is 10% of the total order value.
    /// <see href="https://schema.org/orderPercentage"></see></summary>
    let orderPercentage = _prefix "orderPercentage"
    /// <summary>
    /// The number of the item ordered. If the property is not set, assume the quantity is one.
    /// <see href="https://schema.org/orderQuantity"></see></summary>
    let orderQuantity = _prefix "orderQuantity"
    /// <summary>
    /// The current status of the order.
    /// <see href="https://schema.org/orderStatus"></see></summary>
    let orderStatus = _prefix "orderStatus"
    /// <summary>
    /// Minimum and maximum order value for which these shipping conditions are valid.
    /// <see href="https://schema.org/orderValue"></see></summary>
    let orderValue = _prefix "orderValue"
    /// <summary>
    /// The item ordered.
    /// <see href="https://schema.org/orderedItem"></see></summary>
    let orderedItem = _prefix "orderedItem"
    /// <summary>
    /// An organizer of an Event.
    /// <see href="https://schema.org/organizer"></see></summary>
    let organizer = _prefix "organizer"
    /// <summary>
    /// Shipper's address.
    /// <see href="https://schema.org/originAddress"></see></summary>
    let originAddress = _prefix "originAddress"
    /// <summary>
    /// Describes, in a [[MediaReview]] when dealing with [[DecontextualizedContent]], background information that can contribute to better interpretation of the [[MediaObject]].
    /// <see href="https://schema.org/originalMediaContextDescription"></see></summary>
    let originalMediaContextDescription = _prefix "originalMediaContextDescription"
    /// <summary>
    /// Link to the page containing an original version of the content, or directly to an online copy of the original [[MediaObject]] content, e.g. video file.
    /// <see href="https://schema.org/originalMediaLink"></see></summary>
    let originalMediaLink = _prefix "originalMediaLink"
    /// <summary>
    /// The vasculature the lymphatic structure originates, or afferents, from.
    /// <see href="https://schema.org/originatesFrom"></see></summary>
    let originatesFrom = _prefix "originatesFrom"
    /// <summary>
    /// Any information related to overdose on a drug, including signs or symptoms, treatments, contact information for emergency response.
    /// <see href="https://schema.org/overdosage"></see></summary>
    let overdosage = _prefix "overdosage"
    /// <summary>
    /// The date and time of obtaining the product.
    /// <see href="https://schema.org/ownedFrom"></see></summary>
    let ownedFrom = _prefix "ownedFrom"
    /// <summary>
    /// The date and time of giving up ownership on the product.
    /// <see href="https://schema.org/ownedThrough"></see></summary>
    let ownedThrough = _prefix "ownedThrough"
    /// <summary>
    /// A person or organization who owns this Thing.
    /// <see href="https://schema.org/owner"></see></summary>
    let owner = _prefix "owner"
    /// <summary>
    /// Things owned by the organization or person.
    /// <see href="https://schema.org/owns"></see></summary>
    let owns = _prefix "owns"
    /// <summary>
    /// For an [[Organization]] (often but not necessarily a [[NewsMediaOrganization]]), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the [[funder]] is also available and can be used to make basic funder information machine-readable.
    /// <see href="https://schema.org/ownershipFundingInfo"></see></summary>
    let ownershipFundingInfo = _prefix "ownershipFundingInfo"
    /// <summary>
    /// The page on which the work ends; for example "138" or "xvi".
    /// <see href="https://schema.org/pageEnd"></see></summary>
    let pageEnd = _prefix "pageEnd"
    /// <summary>
    /// The page on which the work starts; for example "135" or "xiii".
    /// <see href="https://schema.org/pageStart"></see></summary>
    let pageStart = _prefix "pageStart"
    /// <summary>
    /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
    /// <see href="https://schema.org/pagination"></see></summary>
    let pagination = _prefix "pagination"
    /// <summary>
    /// A parent of this person.
    /// <see href="https://schema.org/parent"></see></summary>
    let parent = _prefix "parent"
    /// <summary>
    /// The parent of a question, answer or item in general. Typically used for Q/A discussion threads e.g. a chain of comments with the first comment being an [[Article]] or other [[CreativeWork]]. See also [[comment]] which points from something to a comment about it.
    /// <see href="https://schema.org/parentItem"></see></summary>
    let parentItem = _prefix "parentItem"
    /// <summary>
    /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
    /// <see href="https://schema.org/subOrganization"></see></summary>
    let subOrganization = _prefix "subOrganization"
    /// <summary>
    /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
    /// <see href="https://schema.org/parentService"></see></summary>
    let parentService = _prefix "parentService"
    /// <summary>
    /// A parents of the person.
    /// <see href="https://schema.org/parents"></see></summary>
    let parents = _prefix "parents"
    /// <summary>
    /// The episode to which this clip belongs.
    /// <see href="https://schema.org/partOfEpisode"></see></summary>
    let partOfEpisode = _prefix "partOfEpisode"
    /// <summary>
    /// The order is being paid as part of the referenced Invoice.
    /// <see href="https://schema.org/partOfInvoice"></see></summary>
    let partOfInvoice = _prefix "partOfInvoice"
    /// <summary>
    /// The overall order the items in this delivery were included in.
    /// <see href="https://schema.org/partOfOrder"></see></summary>
    let partOfOrder = _prefix "partOfOrder"
    /// <summary>
    /// The season to which this episode belongs.
    /// <see href="https://schema.org/partOfSeason"></see></summary>
    let partOfSeason = _prefix "partOfSeason"
    /// <summary>
    /// The series to which this episode or season belongs.
    /// <see href="https://schema.org/partOfSeries"></see></summary>
    let partOfSeries = _prefix "partOfSeries"
    /// <summary>
    /// The anatomical or organ system that this structure is part of.
    /// <see href="https://schema.org/partOfSystem"></see></summary>
    let partOfSystem = _prefix "partOfSystem"
    /// <summary>
    /// The TV series to which this episode or season belongs.
    /// <see href="https://schema.org/partOfTVSeries"></see></summary>
    let partOfTVSeries = _prefix "partOfTVSeries"
    /// <summary>
    /// Identifies that this [[Trip]] is a subTrip of another Trip.  For example Day 1, Day 2, etc. of a multi-day trip.
    /// <see href="https://schema.org/partOfTrip"></see></summary>
    let partOfTrip = _prefix "partOfTrip"
    /// <summary>
    /// Identifies a [[Trip]] that is a subTrip of this Trip.  For example Day 1, Day 2, etc. of a multi-day trip.
    /// <see href="https://schema.org/subTrip"></see></summary>
    let subTrip = _prefix "subTrip"
    /// <summary>
    /// Number of people the reservation should accommodate.
    /// <see href="https://schema.org/partySize"></see></summary>
    let partySize = _prefix "partySize"
    /// <summary>
    /// The priority status assigned to a passenger for security or boarding (e.g. FastTrack or Priority).
    /// <see href="https://schema.org/passengerPriorityStatus"></see></summary>
    let passengerPriorityStatus = _prefix "passengerPriorityStatus"
    /// <summary>
    /// The passenger's sequence number as assigned by the airline.
    /// <see href="https://schema.org/passengerSequenceNumber"></see></summary>
    let passengerSequenceNumber = _prefix "passengerSequenceNumber"
    /// <summary>
    /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
    /// <see href="https://schema.org/pathophysiology"></see></summary>
    let pathophysiology = _prefix "pathophysiology"
    /// <summary>
    /// A pattern that something has, for example 'polka dot', 'striped', 'Canadian flag'. Values are typically expressed as text, although links to controlled value schemes are also supported.
    /// <see href="https://schema.org/pattern"></see></summary>
    let pattern = _prefix "pattern"
    /// <summary>
    /// The permitted weight of passengers and cargo, EXCLUDING the weight of the empty vehicle.\n\nTypical unit code(s): KGM for kilogram, LBR for pound\n\n* Note 1: Many databases specify the permitted TOTAL weight instead, which is the sum of [[weight]] and [[payload]]\n* Note 2: You can indicate additional information in the [[name]] of the [[QuantitativeValue]] node.\n* Note 3: You may also link to a [[QualitativeValue]] node that provides additional information using [[valueReference]].\n* Note 4: Note that you can use [[minValue]] and [[maxValue]] to indicate ranges.
    /// <see href="https://schema.org/payload"></see></summary>
    let payload = _prefix "payload"
    /// <summary>
    /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
    /// <see href="https://schema.org/paymentAccepted"></see></summary>
    let paymentAccepted = _prefix "paymentAccepted"
    /// <summary>
    /// The date that payment is due.
    /// <see href="https://schema.org/paymentDue"></see></summary>
    let paymentDue = _prefix "paymentDue"
    /// <summary>
    /// The date that payment is due.
    /// <see href="https://schema.org/paymentDueDate"></see></summary>
    let paymentDueDate = _prefix "paymentDueDate"
    /// <summary>
    /// The name of the credit card or other method of payment for the order.
    /// <see href="https://schema.org/paymentMethod"></see></summary>
    let paymentMethod = _prefix "paymentMethod"
    /// <summary>
    /// An identifier for the method of payment used (e.g. the last 4 digits of the credit card).
    /// <see href="https://schema.org/paymentMethodId"></see></summary>
    let paymentMethodId = _prefix "paymentMethodId"
    /// <summary>
    /// The type of a payment method.
    /// <see href="https://schema.org/paymentMethodType"></see></summary>
    let paymentMethodType = _prefix "paymentMethodType"
    /// <summary>
    /// The status of payment; whether the invoice has been paid or not.
    /// <see href="https://schema.org/paymentStatus"></see></summary>
    let paymentStatus = _prefix "paymentStatus"
    /// <summary>
    /// The URL for sending a payment.
    /// <see href="https://schema.org/paymentUrl"></see></summary>
    let paymentUrl = _prefix "paymentUrl"
    /// <summary>
    /// The individual who draws the primary narrative artwork.
    /// <see href="https://schema.org/penciler"></see></summary>
    let penciler = _prefix "penciler"
    /// <summary>
    /// The 10th percentile value.
    /// <see href="https://schema.org/percentile10"></see></summary>
    let percentile10 = _prefix "percentile10"
    /// <summary>
    /// The 25th percentile value.
    /// <see href="https://schema.org/percentile25"></see></summary>
    let percentile25 = _prefix "percentile25"
    /// <summary>
    /// The 75th percentile value.
    /// <see href="https://schema.org/percentile75"></see></summary>
    let percentile75 = _prefix "percentile75"
    /// <summary>
    /// The 90th percentile value.
    /// <see href="https://schema.org/percentile90"></see></summary>
    let percentile90 = _prefix "percentile90"
    /// <summary>
    /// A performer at the event&amp;#x2014;for example, a presenter, musician, musical group or actor.
    /// <see href="https://schema.org/performer"></see></summary>
    let performer = _prefix "performer"
    /// <summary>
    /// Event that this person is a performer or participant in.
    /// <see href="https://schema.org/performerIn"></see></summary>
    let performerIn = _prefix "performerIn"
    /// <summary>
    /// The main performer or performers of the event&amp;#x2014;for example, a presenter, musician, or actor.
    /// <see href="https://schema.org/performers"></see></summary>
    let performers = _prefix "performers"
    /// <summary>
    /// The type of permission granted the person, organization, or audience.
    /// <see href="https://schema.org/permissionType"></see></summary>
    let permissionType = _prefix "permissionType"
    /// <summary>
    /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
    /// <see href="https://schema.org/permissions"></see></summary>
    let permissions = _prefix "permissions"
    /// <summary>
    /// The target audience for this permit.
    /// <see href="https://schema.org/permitAudience"></see></summary>
    let permitAudience = _prefix "permitAudience"
    /// <summary>
    /// Indications regarding the permitted usage of the accommodation.
    /// <see href="https://schema.org/permittedUsage"></see></summary>
    let permittedUsage = _prefix "permittedUsage"
    /// <summary>
    /// Indicates whether pets are allowed to enter the accommodation or lodging business. More detailed information can be put in a text value.
    /// <see href="https://schema.org/petsAllowed"></see></summary>
    let petsAllowed = _prefix "petsAllowed"
    /// <summary>
    /// Representation of a text [[textValue]] using the specified [[speechToTextMarkup]]. For example the city name of Houston in IPA: /ˈhjuːstən/.
    /// <see href="https://schema.org/phoneticText"></see></summary>
    let phoneticText = _prefix "phoneticText"
    /// <summary>
    /// A photograph of this place.
    /// <see href="https://schema.org/photo"></see></summary>
    let photo = _prefix "photo"
    /// <summary>
    /// Photographs of this place.
    /// <see href="https://schema.org/photos"></see></summary>
    let photos = _prefix "photos"
    /// <summary>
    /// A description of the types of physical activity associated with the job. Defined terms such as those in O*net may be used, but note that there is no way to specify the level of ability as well as its nature when using a defined term.
    /// <see href="https://schema.org/physicalRequirement"></see></summary>
    let physicalRequirement = _prefix "physicalRequirement"
    /// <summary>
    /// Specific physiologic benefits associated to the plan.
    /// <see href="https://schema.org/physiologicalBenefits"></see></summary>
    let physiologicalBenefits = _prefix "physiologicalBenefits"
    /// <summary>
    /// Where a taxi will pick up a passenger or a rental car can be picked up.
    /// <see href="https://schema.org/pickupLocation"></see></summary>
    let pickupLocation = _prefix "pickupLocation"
    /// <summary>
    /// When a taxi will pick up a passenger or a rental car can be picked up.
    /// <see href="https://schema.org/pickupTime"></see></summary>
    let pickupTime = _prefix "pickupTime"
    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
    /// <see href="https://schema.org/playMode"></see></summary>
    let playMode = _prefix "playMode"
    /// <summary>
    /// Player type required&amp;#x2014;for example, Flash or Silverlight.
    /// <see href="https://schema.org/playerType"></see></summary>
    let playerType = _prefix "playerType"
    /// <summary>
    /// Number of players on the server.
    /// <see href="https://schema.org/playersOnline"></see></summary>
    let playersOnline = _prefix "playersOnline"
    /// <summary>
    /// A polygon is the area enclosed by a point-to-point path for which the starting and ending points are the same. A polygon is expressed as a series of four or more space delimited points where the first and final points are identical.
    /// <see href="https://schema.org/polygon"></see></summary>
    let polygon = _prefix "polygon"
    /// <summary>
    /// Indicates the populationType common to all members of a [[StatisticalPopulation]] or all cases within the scope of a [[StatisticalVariable]].
    /// <see href="https://schema.org/populationType"></see></summary>
    let populationType = _prefix "populationType"
    /// <summary>
    /// Provides positive considerations regarding something, for example product highlights or (alongside [[negativeNotes]]) pro/con lists for reviews.
    ///
    /// In the case of a [[Review]], the property describes the [[itemReviewed]] from the perspective of the review; in the case of a [[Product]], the product itself is being described.
    ///
    /// The property values can be expressed either as unstructured text (repeated as necessary), or if ordered, as a list (in which case the most positive is at the beginning of the list).
    /// <see href="https://schema.org/positiveNotes"></see></summary>
    let positiveNotes = _prefix "positiveNotes"
    /// <summary>
    /// A possible unexpected and unfavorable evolution of a medical condition. Complications may include worsening of the signs or symptoms of the disease, extension of the condition to other organ systems, etc.
    /// <see href="https://schema.org/possibleComplication"></see></summary>
    let possibleComplication = _prefix "possibleComplication"
    /// <summary>
    /// A possible treatment to address this condition, sign or symptom.
    /// <see href="https://schema.org/possibleTreatment"></see></summary>
    let possibleTreatment = _prefix "possibleTreatment"
    /// <summary>
    /// The post office box number for PO box addresses.
    /// <see href="https://schema.org/postOfficeBoxNumber"></see></summary>
    let postOfficeBoxNumber = _prefix "postOfficeBoxNumber"
    /// <summary>
    /// A description of the postoperative procedures, care, and/or followups for this device.
    /// <see href="https://schema.org/postOp"></see></summary>
    let postOp = _prefix "postOp"
    /// <summary>
    /// The postal code. For example, 94043.
    /// <see href="https://schema.org/postalCode"></see></summary>
    let postalCode = _prefix "postalCode"
    /// <summary>
    /// First postal code in a range (included).
    /// <see href="https://schema.org/postalCodeBegin"></see></summary>
    let postalCodeBegin = _prefix "postalCodeBegin"
    /// <summary>
    /// Last postal code in the range (included). Needs to be after [[postalCodeBegin]].
    /// <see href="https://schema.org/postalCodeEnd"></see></summary>
    let postalCodeEnd = _prefix "postalCodeEnd"
    /// <summary>
    /// A defined range of postal codes indicated by a common textual prefix. Used for non-numeric systems such as UK.
    /// <see href="https://schema.org/postalCodePrefix"></see></summary>
    let postalCodePrefix = _prefix "postalCodePrefix"
    /// <summary>
    /// A defined range of postal codes.
    /// <see href="https://schema.org/postalCodeRange"></see></summary>
    let postalCodeRange = _prefix "postalCodeRange"
    /// <summary>
    /// Indicates a potential Action, which describes an idealized action in which this thing would play an 'object' role.
    /// <see href="https://schema.org/potentialAction"></see></summary>
    let potentialAction = _prefix "potentialAction"
    /// <summary>
    /// Intended use of the BioChemEntity by humans.
    /// <see href="https://schema.org/potentialUse"></see></summary>
    let potentialUse = _prefix "potentialUse"
    /// <summary>
    /// A [[MedicalOrganization]] where the [[IndividualPhysician]] practices.
    /// <see href="https://schema.org/practicesAt"></see></summary>
    let practicesAt = _prefix "practicesAt"
    /// <summary>
    /// A description of the workup, testing, and other preparations required before implanting this device.
    /// <see href="https://schema.org/preOp"></see></summary>
    let preOp = _prefix "preOp"
    /// <summary>
    /// A pointer from a previous, often discontinued variant of the product to its newer variant.
    /// <see href="https://schema.org/predecessorOf"></see></summary>
    let predecessorOf = _prefix "predecessorOf"
    /// <summary>
    /// Pregnancy category of this drug.
    /// <see href="https://schema.org/pregnancyCategory"></see></summary>
    let pregnancyCategory = _prefix "pregnancyCategory"
    /// <summary>
    /// Any precaution, guidance, contraindication, etc. related to this drug's use during pregnancy.
    /// <see href="https://schema.org/pregnancyWarning"></see></summary>
    let pregnancyWarning = _prefix "pregnancyWarning"
    /// <summary>
    /// The length of time it takes to prepare the items to be used in instructions or a direction, in [ISO 8601 duration format](http://en.wikipedia.org/wiki/ISO_8601).
    /// <see href="https://schema.org/prepTime"></see></summary>
    let prepTime = _prefix "prepTime"
    /// <summary>
    /// Typical preparation that a patient must undergo before having the procedure performed.
    /// <see href="https://schema.org/preparation"></see></summary>
    let preparation = _prefix "preparation"
    /// <summary>
    /// Link to prescribing information for the drug.
    /// <see href="https://schema.org/prescribingInfo"></see></summary>
    let prescribingInfo = _prefix "prescribingInfo"
    /// <summary>
    /// Indicates the status of drug prescription, e.g. local catalogs classifications or whether the drug is available by prescription or over-the-counter, etc.
    /// <see href="https://schema.org/prescriptionStatus"></see></summary>
    let prescriptionStatus = _prefix "prescriptionStatus"
    /// <summary>
    /// A link to the ListItem that precedes the current one.
    /// <see href="https://schema.org/previousItem"></see></summary>
    let previousItem = _prefix "previousItem"
    /// <summary>
    /// Used in conjunction with eventStatus for rescheduled or cancelled events. This property contains the previously scheduled start date. For rescheduled events, the startDate property should be used for the newly scheduled start date. In the (rare) case of an event that has been postponed and rescheduled multiple times, this field may be repeated.
    /// <see href="https://schema.org/previousStartDate"></see></summary>
    let previousStartDate = _prefix "previousStartDate"
    /// <summary>
    /// The offer price of a product, or of a price component when attached to PriceSpecification and its subtypes.\n\nUsage guidelines:\n\n* Use the [[priceCurrency]] property (with standard formats: [ISO 4217 currency format](http://en.wikipedia.org/wiki/ISO_4217), e.g. "USD"; [Ticker symbol](https://en.wikipedia.org/wiki/List_of_cryptocurrencies) for cryptocurrencies, e.g. "BTC"; well known names for [Local Exchange Trading Systems](https://en.wikipedia.org/wiki/Local_exchange_trading_system) (LETS) and other currency types, e.g. "Ithaca HOUR") instead of including [ambiguous symbols](http://en.wikipedia.org/wiki/Dollar_sign#Currencies_that_use_the_dollar_or_peso_sign) such as '$' in the value.\n* Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.\n* Note that both [RDFa](http://www.w3.org/TR/xhtml-rdfa-primer/#using-the-content-attribute) and Microdata syntax allow the use of a "content=" attribute for publishing simple machine-readable values alongside more human-friendly formatting.\n* Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similar Unicode symbols.
    ///
    /// <see href="https://schema.org/price"></see></summary>
    let price = _prefix "price"
    /// <summary>
    /// This property links to all [[UnitPriceSpecification]] nodes that apply in parallel for the [[CompoundPriceSpecification]] node.
    /// <see href="https://schema.org/priceComponent"></see></summary>
    let priceComponent = _prefix "priceComponent"
    /// <summary>
    /// Identifies a price component (for example, a line item on an invoice), part of the total price for an offer.
    /// <see href="https://schema.org/priceComponentType"></see></summary>
    let priceComponentType = _prefix "priceComponentType"
    /// <summary>
    /// The currency of the price, or a price component when attached to [[PriceSpecification]] and its subtypes.\n\nUse standard formats: [ISO 4217 currency format](http://en.wikipedia.org/wiki/ISO_4217), e.g. "USD"; [Ticker symbol](https://en.wikipedia.org/wiki/List_of_cryptocurrencies) for cryptocurrencies, e.g. "BTC"; well known names for [Local Exchange Trading Systems](https://en.wikipedia.org/wiki/Local_exchange_trading_system) (LETS) and other currency types, e.g. "Ithaca HOUR".
    /// <see href="https://schema.org/priceCurrency"></see></summary>
    let priceCurrency = _prefix "priceCurrency"
    /// <summary>
    /// The price range of the business, for example ```$$$```.
    /// <see href="https://schema.org/priceRange"></see></summary>
    let priceRange = _prefix "priceRange"
    /// <summary>
    /// One or more detailed price specifications, indicating the unit price and delivery or payment charges.
    /// <see href="https://schema.org/priceSpecification"></see></summary>
    let priceSpecification = _prefix "priceSpecification"
    /// <summary>
    /// Defines the type of a price specified for an offered product, for example a list price, a (temporary) sale price or a manufacturer suggested retail price. If multiple prices are specified for an offer the [[priceType]] property can be used to identify the type of each such specified price. The value of priceType can be specified as a value from enumeration PriceTypeEnumeration or, a UN/EDIFACT 5387 code, or as a free form text string for price types that are not already predefined in PriceTypeEnumeration.
    /// <see href="https://schema.org/priceType"></see></summary>
    let priceType = _prefix "priceType"
    /// <summary>
    /// The date after which the price is no longer available.
    /// <see href="https://schema.org/priceValidUntil"></see></summary>
    let priceValidUntil = _prefix "priceValidUntil"
    /// <summary>
    /// Indicates the main image on the page.
    /// <see href="https://schema.org/primaryImageOfPage"></see></summary>
    let primaryImageOfPage = _prefix "primaryImageOfPage"
    /// <summary>
    /// A preventative therapy used to prevent an initial occurrence of the medical condition, such as vaccination.
    /// <see href="https://schema.org/primaryPrevention"></see></summary>
    let primaryPrevention = _prefix "primaryPrevention"
    /// <summary>
    /// The number of the column in which the NewsArticle appears in the print edition.
    /// <see href="https://schema.org/printColumn"></see></summary>
    let printColumn = _prefix "printColumn"
    /// <summary>
    /// The edition of the print product in which the NewsArticle appears.
    /// <see href="https://schema.org/printEdition"></see></summary>
    let printEdition = _prefix "printEdition"
    /// <summary>
    /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
    /// <see href="https://schema.org/printPage"></see></summary>
    let printPage = _prefix "printPage"
    /// <summary>
    /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
    /// <see href="https://schema.org/printSection"></see></summary>
    let printSection = _prefix "printSection"
    /// <summary>
    /// A description of the procedure involved in setting up, using, and/or installing the device.
    /// <see href="https://schema.org/procedure"></see></summary>
    let procedure = _prefix "procedure"
    /// <summary>
    /// The type of procedure, for example Surgical, Noninvasive, or Percutaneous.
    /// <see href="https://schema.org/procedureType"></see></summary>
    let procedureType = _prefix "procedureType"
    /// <summary>
    /// Estimated processing time for the service using this channel.
    /// <see href="https://schema.org/processingTime"></see></summary>
    let processingTime = _prefix "processingTime"
    /// <summary>
    /// Processor architecture required to run the application (e.g. IA64).
    /// <see href="https://schema.org/processorRequirements"></see></summary>
    let processorRequirements = _prefix "processorRequirements"
    /// <summary>
    /// The person or organization who produced the work (e.g. music album, movie, TV/radio series etc.).
    /// <see href="https://schema.org/producer"></see></summary>
    let producer = _prefix "producer"
    /// <summary>
    /// The tangible thing generated by the service, e.g. a passport, permit, etc.
    /// <see href="https://schema.org/produces"></see></summary>
    let produces = _prefix "produces"
    /// <summary>
    /// The tangible thing generated by the service, e.g. a passport, permit, etc.
    /// <see href="https://schema.org/serviceOutput"></see></summary>
    let serviceOutput = _prefix "serviceOutput"
    /// <summary>
    /// Indicates a textual identifier for a ProductGroup.
    /// <see href="https://schema.org/productGroupID"></see></summary>
    let productGroupID = _prefix "productGroupID"
    /// <summary>
    /// The product identifier, such as ISBN. For example: ``` meta itemprop="productID" content="isbn:123-456-789" ```.
    /// <see href="https://schema.org/productID"></see></summary>
    let productID = _prefix "productID"
    /// <summary>
    /// The product or service this support contact point is related to (such as product support for a particular product line). This can be a specific product or product line (e.g. "iPhone") or a general category of products or services (e.g. "smartphones").
    /// <see href="https://schema.org/productSupported"></see></summary>
    let productSupported = _prefix "productSupported"
    /// <summary>
    /// The production company or studio responsible for the item, e.g. series, video game, episode etc.
    /// <see href="https://schema.org/productionCompany"></see></summary>
    let productionCompany = _prefix "productionCompany"
    /// <summary>
    /// The date of production of the item, e.g. vehicle.
    /// <see href="https://schema.org/productionDate"></see></summary>
    let productionDate = _prefix "productionDate"
    /// <summary>
    /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
    /// <see href="https://schema.org/proficiencyLevel"></see></summary>
    let proficiencyLevel = _prefix "proficiencyLevel"
    /// <summary>
    /// The [MemberProgram](https://schema.org/MemberProgram) associated with a [ProgramMembership](https://schema.org/ProgramMembership).
    /// <see href="https://schema.org/program"></see></summary>
    let program = _prefix "program"
    /// <summary>
    /// Any membership in a frequent flyer, hotel loyalty program, etc. being applied to the reservation.
    /// <see href="https://schema.org/programMembershipUsed"></see></summary>
    let programMembershipUsed = _prefix "programMembershipUsed"
    /// <summary>
    /// The program providing the membership. It is preferable to use [:program](https://schema.org/program) instead.
    /// <see href="https://schema.org/programName"></see></summary>
    let programName = _prefix "programName"
    /// <summary>
    /// Prerequisites for enrolling in the program.
    /// <see href="https://schema.org/programPrerequisites"></see></summary>
    let programPrerequisites = _prefix "programPrerequisites"
    /// <summary>
    /// The type of educational or occupational program. For example, classroom, internship, alternance, etc.
    /// <see href="https://schema.org/programType"></see></summary>
    let programType = _prefix "programType"
    /// <summary>
    /// The computer programming language.
    /// <see href="https://schema.org/programmingLanguage"></see></summary>
    let programmingLanguage = _prefix "programmingLanguage"
    /// <summary>
    /// Indicates whether API is managed or unmanaged.
    /// <see href="https://schema.org/programmingModel"></see></summary>
    let programmingModel = _prefix "programmingModel"
    /// <summary>
    /// A short string listing or describing pronouns for a person. Typically the person concerned is the best authority as pronouns are a critical part of personal identity and expression. Publishers and consumers of this information are reminded to treat this data responsibly, take country-specific laws related to gender expression into account, and be wary of out-of-date data and drawing unwarranted inferences about the person being described.
    ///
    /// In English, formulations such as "they/them", "she/her", and "he/him" are commonly used online and can also be used here. We do not intend to enumerate all possible micro-syntaxes in all languages. More structured and well-defined external values for pronouns can be referenced using the [[StructuredValue]] or [[DefinedTerm]] values.
    ///
    /// <see href="https://schema.org/pronouns"></see></summary>
    let pronouns = _prefix "pronouns"
    /// <summary>
    /// A commonly used identifier for the characteristic represented by the property, e.g. a manufacturer or a standard code for a property. propertyID can be
    /// (1) a prefixed string, mainly meant to be used with standards for product properties; (2) a site-specific, non-prefixed string (e.g. the primary key of the property or the vendor-specific ID of the property), or (3)
    /// a URL indicating the type of the property, either pointing to an external vocabulary, or a Web resource that describes the property (e.g. a glossary entry).
    /// Standards bodies should promote a standard prefix for the identifiers of properties from their standards.
    /// <see href="https://schema.org/propertyID"></see></summary>
    let propertyID = _prefix "propertyID"
    /// <summary>
    /// Proprietary name given to the diet plan, typically by its originator or creator.
    /// <see href="https://schema.org/proprietaryName"></see></summary>
    let proprietaryName = _prefix "proprietaryName"
    /// <summary>
    /// The number of grams of protein.
    /// <see href="https://schema.org/proteinContent"></see></summary>
    let proteinContent = _prefix "proteinContent"
    /// <summary>
    /// Indicates the mobility of a provided service (e.g. 'static', 'dynamic').
    /// <see href="https://schema.org/providerMobility"></see></summary>
    let providerMobility = _prefix "providerMobility"
    /// <summary>
    /// The service provided by this channel.
    /// <see href="https://schema.org/providesService"></see></summary>
    let providesService = _prefix "providesService"
    /// <summary>
    /// A flag to signal that the [[Place]] is open to public visitors.  If this property is omitted there is no assumed default boolean value.
    /// <see href="https://schema.org/publicAccess"></see></summary>
    let publicAccess = _prefix "publicAccess"
    /// <summary>
    /// Information about public transport closures.
    /// <see href="https://schema.org/publicTransportClosuresInfo"></see></summary>
    let publicTransportClosuresInfo = _prefix "publicTransportClosuresInfo"
    /// <summary>
    /// A publication event associated with the item.
    /// <see href="https://schema.org/publication"></see></summary>
    let publication = _prefix "publication"
    /// <summary>
    /// The type of the medical article, taken from the US NLM MeSH publication type catalog. See also [MeSH documentation](http://www.nlm.nih.gov/mesh/pubtypes.html).
    /// <see href="https://schema.org/publicationType"></see></summary>
    let publicationType = _prefix "publicationType"
    /// <summary>
    /// An agent associated with the publication event.
    /// <see href="https://schema.org/publishedBy"></see></summary>
    let publishedBy = _prefix "publishedBy"
    /// <summary>
    /// A broadcast service associated with the publication event.
    /// <see href="https://schema.org/publishedOn"></see></summary>
    let publishedOn = _prefix "publishedOn"
    /// <summary>
    /// The publisher of the article in question.
    /// <see href="https://schema.org/publisher"></see></summary>
    let publisher = _prefix "publisher"
    /// <summary>
    /// The publishing division which published the comic.
    /// <see href="https://schema.org/publisherImprint"></see></summary>
    let publisherImprint = _prefix "publisherImprint"
    /// <summary>
    /// The date the item, e.g. vehicle, was purchased by the current owner.
    /// <see href="https://schema.org/purchaseDate"></see></summary>
    let purchaseDate = _prefix "purchaseDate"
    /// <summary>
    /// Optional. The maximum price the item can have and still qualify for this offer.
    /// <see href="https://schema.org/purchasePriceLimit"></see></summary>
    let purchasePriceLimit = _prefix "purchasePriceLimit"
    /// <summary>
    /// Optional. The type of purchase the consumer must make in order to qualify for this incentive.
    /// <see href="https://schema.org/purchaseType"></see></summary>
    let purchaseType = _prefix "purchaseType"
    /// <summary>
    /// Specific qualifications required for this role or Occupation.
    /// <see href="https://schema.org/qualifications"></see></summary>
    let qualifications = _prefix "qualifications"
    /// <summary>
    /// Optional. The types of expenses that are covered by the incentive. For example some incentives are only for the goods (tangible items) but the services (labor) are excluded.
    /// <see href="https://schema.org/qualifiedExpense"></see></summary>
    let qualifiedExpense = _prefix "qualifiedExpense"
    /// <summary>
    /// Guidelines about quarantine rules, e.g. in the context of a pandemic.
    /// <see href="https://schema.org/quarantineGuidelines"></see></summary>
    let quarantineGuidelines = _prefix "quarantineGuidelines"
    /// <summary>
    /// A sub property of instrument. The query used on this action.
    /// <see href="https://schema.org/query"></see></summary>
    let query = _prefix "query"
    /// <summary>
    /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
    /// <see href="https://schema.org/quest"></see></summary>
    let quest = _prefix "quest"
    /// <summary>
    /// A sub property of object. A question.
    /// <see href="https://schema.org/question"></see></summary>
    let question = _prefix "question"
    /// <summary>
    /// The count of total number of ratings.
    /// <see href="https://schema.org/ratingCount"></see></summary>
    let ratingCount = _prefix "ratingCount"
    /// <summary>
    /// A short explanation (e.g. one to two sentences) providing background context and other information that led to the conclusion expressed in the rating. This is particularly applicable to ratings associated with "fact check" markup using [[ClaimReview]].
    /// <see href="https://schema.org/ratingExplanation"></see></summary>
    let ratingExplanation = _prefix "ratingExplanation"
    /// <summary>
    /// The rating for the content.\n\nUsage guidelines:\n\n* Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similar Unicode symbols.\n* Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
    /// <see href="https://schema.org/ratingValue"></see></summary>
    let ratingValue = _prefix "ratingValue"
    /// <summary>
    /// A person who reads (performs) the audiobook.
    /// <see href="https://schema.org/readBy"></see></summary>
    let readBy = _prefix "readBy"
    /// <summary>
    /// Whether or not a property is mutable.  Default is false. Specifying this for a property that also has a value makes it act similar to a "hidden" input in an HTML form.
    /// <see href="https://schema.org/readonlyValue"></see></summary>
    let readonlyValue = _prefix "readonlyValue"
    /// <summary>
    /// A sub property of participant. The real estate agent involved in the action.
    /// <see href="https://schema.org/realEstateAgent"></see></summary>
    let realEstateAgent = _prefix "realEstateAgent"
    /// <summary>
    /// A sub property of instrument. The recipe/instructions used to perform the action.
    /// <see href="https://schema.org/recipe"></see></summary>
    let recipe = _prefix "recipe"
    /// <summary>
    /// The category of the recipe—for example, appetizer, entree, etc.
    /// <see href="https://schema.org/recipeCategory"></see></summary>
    let recipeCategory = _prefix "recipeCategory"
    /// <summary>
    /// The cuisine of the recipe (for example, French or Ethiopian).
    /// <see href="https://schema.org/recipeCuisine"></see></summary>
    let recipeCuisine = _prefix "recipeCuisine"
    /// <summary>
    /// A step in making the recipe, in the form of a single item (document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
    /// <see href="https://schema.org/recipeInstructions"></see></summary>
    let recipeInstructions = _prefix "recipeInstructions"
    /// <summary>
    /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection.
    /// <see href="https://schema.org/step"></see></summary>
    let step = _prefix "step"
    /// <summary>
    /// The quantity produced by the recipe (for example, number of people served, number of servings, etc).
    /// <see href="https://schema.org/recipeYield"></see></summary>
    let recipeYield = _prefix "recipeYield"
    /// <summary>
    /// The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
    /// <see href="https://schema.org/yield"></see></summary>
    let yield_ = _prefix "yield"
    /// <summary>
    /// An organization that acknowledges the validity, value or utility of a credential. Note: recognition may include a process of quality assurance or accreditation.
    /// <see href="https://schema.org/recognizedBy"></see></summary>
    let recognizedBy = _prefix "recognizedBy"
    /// <summary>
    /// If applicable, the organization that officially recognizes this entity as part of its endorsed system of medicine.
    /// <see href="https://schema.org/recognizingAuthority"></see></summary>
    let recognizingAuthority = _prefix "recognizingAuthority"
    /// <summary>
    /// Strength of the guideline's recommendation (e.g. 'class I').
    /// <see href="https://schema.org/recommendationStrength"></see></summary>
    let recommendationStrength = _prefix "recommendationStrength"
    /// <summary>
    /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
    /// <see href="https://schema.org/recommendedIntake"></see></summary>
    let recommendedIntake = _prefix "recommendedIntake"
    /// <summary>
    /// The label that issued the release.
    /// <see href="https://schema.org/recordLabel"></see></summary>
    let recordLabel = _prefix "recordLabel"
    /// <summary>
    /// An audio recording of the work.
    /// <see href="https://schema.org/recordedAs"></see></summary>
    let recordedAs = _prefix "recordedAs"
    /// <summary>
    /// The composition this track is a recording of.
    /// <see href="https://schema.org/recordingOf"></see></summary>
    let recordingOf = _prefix "recordingOf"
    /// <summary>
    /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
    /// <see href="https://schema.org/recordedAt"></see></summary>
    let recordedAt = _prefix "recordedAt"
    /// <summary>
    /// The CreativeWork that captured all or part of this Event.
    /// <see href="https://schema.org/recordedIn"></see></summary>
    let recordedIn = _prefix "recordedIn"
    /// <summary>
    /// The only way you get the money back in the event of default is the security. Recourse is where you still have the opportunity to go back to the borrower for the rest of the money.
    /// <see href="https://schema.org/recourseLoan"></see></summary>
    let recourseLoan = _prefix "recourseLoan"
    /// <summary>
    /// An official who watches a game or match closely to enforce the rules and arbitrate on matters arising from the play such as referees, umpires or judges. The name of the effective function can vary according to the sport.
    /// <see href="https://schema.org/referee"></see></summary>
    let referee = _prefix "referee"
    /// <summary>
    /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
    /// <see href="https://schema.org/referenceQuantity"></see></summary>
    let referenceQuantity = _prefix "referenceQuantity"
    /// <summary>
    /// The Order(s) related to this Invoice. One or more Orders may be combined into a single Invoice.
    /// <see href="https://schema.org/referencesOrder"></see></summary>
    let referencesOrder = _prefix "referencesOrder"
    /// <summary>
    /// A refund type, from an enumerated list.
    /// <see href="https://schema.org/refundType"></see></summary>
    let refundType = _prefix "refundType"
    /// <summary>
    /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
    /// <see href="https://schema.org/regionDrained"></see></summary>
    let regionDrained = _prefix "regionDrained"
    /// <summary>
    /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in [ISO 3166 format](http://en.wikipedia.org/wiki/ISO_3166).
    /// <see href="https://schema.org/regionsAllowed"></see></summary>
    let regionsAllowed = _prefix "regionsAllowed"
    /// <summary>
    /// Anatomical systems or structures that relate to the superficial anatomy.
    /// <see href="https://schema.org/relatedAnatomy"></see></summary>
    let relatedAnatomy = _prefix "relatedAnatomy"
    /// <summary>
    /// A medical condition associated with this anatomy.
    /// <see href="https://schema.org/relatedCondition"></see></summary>
    let relatedCondition = _prefix "relatedCondition"
    /// <summary>
    /// Any other drug related to this one, for example commonly-prescribed alternatives.
    /// <see href="https://schema.org/relatedDrug"></see></summary>
    let relatedDrug = _prefix "relatedDrug"
    /// <summary>
    /// A link related to this web page, for example to other related web pages.
    /// <see href="https://schema.org/relatedLink"></see></summary>
    let relatedLink = _prefix "relatedLink"
    /// <summary>
    /// Related anatomical structure(s) that are not part of the system but relate or connect to it, such as vascular bundles associated with an organ system.
    /// <see href="https://schema.org/relatedStructure"></see></summary>
    let relatedStructure = _prefix "relatedStructure"
    /// <summary>
    /// A medical therapy related to this anatomy.
    /// <see href="https://schema.org/relatedTherapy"></see></summary>
    let relatedTherapy = _prefix "relatedTherapy"
    /// <summary>
    /// The most generic familial relation.
    /// <see href="https://schema.org/relatedTo"></see></summary>
    let relatedTo = _prefix "relatedTo"
    /// <summary>
    /// The release date of a product or product model. This can be used to distinguish the exact variant of a product.
    /// <see href="https://schema.org/releaseDate"></see></summary>
    let releaseDate = _prefix "releaseDate"
    /// <summary>
    /// Description of what changed in this version.
    /// <see href="https://schema.org/releaseNotes"></see></summary>
    let releaseNotes = _prefix "releaseNotes"
    /// <summary>
    /// The place and time the release was issued, expressed as a PublicationEvent.
    /// <see href="https://schema.org/releasedEvent"></see></summary>
    let releasedEvent = _prefix "releasedEvent"
    /// <summary>
    /// The Occupation for the JobPosting.
    /// <see href="https://schema.org/relevantOccupation"></see></summary>
    let relevantOccupation = _prefix "relevantOccupation"
    /// <summary>
    /// If applicable, a medical specialty in which this entity is relevant.
    /// <see href="https://schema.org/relevantSpecialty"></see></summary>
    let relevantSpecialty = _prefix "relevantSpecialty"
    /// <summary>
    /// The number of attendee places for an event that remain unallocated.
    /// <see href="https://schema.org/remainingAttendeeCapacity"></see></summary>
    let remainingAttendeeCapacity = _prefix "remainingAttendeeCapacity"
    /// <summary>
    /// Whether the terms for payment of interest can be renegotiated during the life of the loan.
    /// <see href="https://schema.org/renegotiableLoan"></see></summary>
    let renegotiableLoan = _prefix "renegotiableLoan"
    /// <summary>
    /// Defines the number of times a recurring [[Event]] will take place.
    /// <see href="https://schema.org/repeatCount"></see></summary>
    let repeatCount = _prefix "repeatCount"
    /// <summary>
    /// Defines the frequency at which [[Event]]s will occur according to a schedule [[Schedule]]. The intervals between
    ///       events should be defined as a [[Duration]] of time.
    /// <see href="https://schema.org/repeatFrequency"></see></summary>
    let repeatFrequency = _prefix "repeatFrequency"
    /// <summary>
    /// Number of times one should repeat the activity.
    /// <see href="https://schema.org/repetitions"></see></summary>
    let repetitions = _prefix "repetitions"
    /// <summary>
    /// A sub property of object. The object that is being replaced.
    /// <see href="https://schema.org/replacee"></see></summary>
    let replacee = _prefix "replacee"
    /// <summary>
    /// A sub property of object. The object that replaces.
    /// <see href="https://schema.org/replacer"></see></summary>
    let replacer = _prefix "replacer"
    /// <summary>
    /// The URL at which a reply may be posted to the specified UserComment.
    /// <see href="https://schema.org/replyToUrl"></see></summary>
    let replyToUrl = _prefix "replyToUrl"
    /// <summary>
    /// The number or other unique designator assigned to a Report by the publishing organization.
    /// <see href="https://schema.org/reportNumber"></see></summary>
    let reportNumber = _prefix "reportNumber"
    /// <summary>
    /// Indicates whether this image is representative of the content of the page.
    /// <see href="https://schema.org/representativeOfPage"></see></summary>
    let representativeOfPage = _prefix "representativeOfPage"
    /// <summary>
    /// Assets required to secure loan or credit repayments. It may take form of third party pledge, goods, financial instruments (cash, securities, etc.)
    /// <see href="https://schema.org/requiredCollateral"></see></summary>
    let requiredCollateral = _prefix "requiredCollateral"
    /// <summary>
    /// Audiences defined by a person's gender.
    /// <see href="https://schema.org/requiredGender"></see></summary>
    let requiredGender = _prefix "requiredGender"
    /// <summary>
    /// Audiences defined by a person's maximum age.
    /// <see href="https://schema.org/requiredMaxAge"></see></summary>
    let requiredMaxAge = _prefix "requiredMaxAge"
    /// <summary>
    /// Audiences defined by a person's minimum age.
    /// <see href="https://schema.org/requiredMinAge"></see></summary>
    let requiredMinAge = _prefix "requiredMinAge"
    /// <summary>
    /// The required quantity of the item(s).
    /// <see href="https://schema.org/requiredQuantity"></see></summary>
    let requiredQuantity = _prefix "requiredQuantity"
    /// <summary>
    /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (examples: DirectX, Java or .NET runtime).
    /// <see href="https://schema.org/requirements"></see></summary>
    let requirements = _prefix "requirements"
    /// <summary>
    /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (examples: DirectX, Java or .NET runtime).
    /// <see href="https://schema.org/softwareRequirements"></see></summary>
    let softwareRequirements = _prefix "softwareRequirements"
    /// <summary>
    /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are ```true``` or ```false``` (note that an earlier version had 'yes', 'no').
    /// <see href="https://schema.org/requiresSubscription"></see></summary>
    let requiresSubscription = _prefix "requiresSubscription"
    /// <summary>
    /// The thing -- flight, event, restaurant, etc. being reserved.
    /// <see href="https://schema.org/reservationFor"></see></summary>
    let reservationFor = _prefix "reservationFor"
    /// <summary>
    /// A unique identifier for the reservation.
    /// <see href="https://schema.org/reservationId"></see></summary>
    let reservationId = _prefix "reservationId"
    /// <summary>
    /// The current status of the reservation.
    /// <see href="https://schema.org/reservationStatus"></see></summary>
    let reservationStatus = _prefix "reservationStatus"
    /// <summary>
    /// A ticket associated with the reservation.
    /// <see href="https://schema.org/reservedTicket"></see></summary>
    let reservedTicket = _prefix "reservedTicket"
    /// <summary>
    /// Responsibilities associated with this role or Occupation.
    /// <see href="https://schema.org/responsibilities"></see></summary>
    let responsibilities = _prefix "responsibilities"
    /// <summary>
    /// How often one should break from the activity.
    /// <see href="https://schema.org/restPeriods"></see></summary>
    let restPeriods = _prefix "restPeriods"
    /// <summary>
    /// Use [[MonetaryAmount]] to specify a fixed restocking fee for product returns, or use [[Number]] to specify a percentage of the product price paid by the customer.
    /// <see href="https://schema.org/restockingFee"></see></summary>
    let restockingFee = _prefix "restockingFee"
    /// <summary>
    /// The result produced in the action. E.g. John wrote *a book*.
    /// <see href="https://schema.org/result"></see></summary>
    let result = _prefix "result"
    /// <summary>
    /// A sub property of result. The Comment created or sent as a result of this action.
    /// <see href="https://schema.org/resultComment"></see></summary>
    let resultComment = _prefix "resultComment"
    /// <summary>
    /// A sub property of result. The review that resulted in the performing of the action.
    /// <see href="https://schema.org/resultReview"></see></summary>
    let resultReview = _prefix "resultReview"
    /// <summary>
    /// The type of return fees for purchased products (for any return reason).
    /// <see href="https://schema.org/returnFees"></see></summary>
    let returnFees = _prefix "returnFees"
    /// <summary>
    /// The method (from an enumeration) by which the customer obtains a return shipping label for a product returned for any reason.
    /// <see href="https://schema.org/returnLabelSource"></see></summary>
    let returnLabelSource = _prefix "returnLabelSource"
    /// <summary>
    /// The type of return method offered, specified from an enumeration.
    /// <see href="https://schema.org/returnMethod"></see></summary>
    let returnMethod = _prefix "returnMethod"
    /// <summary>
    /// Specifies an applicable return policy (from an enumeration).
    /// <see href="https://schema.org/returnPolicyCategory"></see></summary>
    let returnPolicyCategory = _prefix "returnPolicyCategory"
    /// <summary>
    /// The country where the product has to be sent to for returns, for example "Ireland" using the [[name]] property of [[Country]]. You can also provide the two-letter [ISO 3166-1 alpha-2 country code](http://en.wikipedia.org/wiki/ISO_3166-1). Note that this can be different from the country where the product was originally shipped from or sent to.
    /// <see href="https://schema.org/returnPolicyCountry"></see></summary>
    let returnPolicyCountry = _prefix "returnPolicyCountry"
    /// <summary>
    /// Seasonal override of a return policy.
    /// <see href="https://schema.org/returnPolicySeasonalOverride"></see></summary>
    let returnPolicySeasonalOverride = _prefix "returnPolicySeasonalOverride"
    /// <summary>
    /// Amount of shipping costs for product returns (for any reason). Applicable when property [[returnFees]] equals [[ReturnShippingFees]].
    /// <see href="https://schema.org/returnShippingFeesAmount"></see></summary>
    let returnShippingFeesAmount = _prefix "returnShippingFeesAmount"
    /// <summary>
    /// A review of the item.
    /// <see href="https://schema.org/review"></see></summary>
    let review = _prefix "review"
    /// <summary>
    /// This Review or Rating is relevant to this part or facet of the itemReviewed.
    /// <see href="https://schema.org/reviewAspect"></see></summary>
    let reviewAspect = _prefix "reviewAspect"
    /// <summary>
    /// The actual body of the review.
    /// <see href="https://schema.org/reviewBody"></see></summary>
    let reviewBody = _prefix "reviewBody"
    /// <summary>
    /// The count of total number of reviews.
    /// <see href="https://schema.org/reviewCount"></see></summary>
    let reviewCount = _prefix "reviewCount"
    /// <summary>
    /// The rating given in this review. Note that reviews can themselves be rated. The ```reviewRating``` applies to rating given by the review. The [[aggregateRating]] property applies to the review itself, as a creative work.
    /// <see href="https://schema.org/reviewRating"></see></summary>
    let reviewRating = _prefix "reviewRating"
    /// <summary>
    /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
    /// <see href="https://schema.org/reviewedBy"></see></summary>
    let reviewedBy = _prefix "reviewedBy"
    /// <summary>
    /// Review of the item.
    /// <see href="https://schema.org/reviews"></see></summary>
    let reviews = _prefix "reviews"
    /// <summary>
    /// A modifiable or non-modifiable factor that increases the risk of a patient contracting this condition, e.g. age,  coexisting condition.
    /// <see href="https://schema.org/riskFactor"></see></summary>
    let riskFactor = _prefix "riskFactor"
    /// <summary>
    /// Specific physiologic risks associated to the diet plan.
    /// <see href="https://schema.org/risks"></see></summary>
    let risks = _prefix "risks"
    /// <summary>
    /// The permitted total weight of cargo and installations (e.g. a roof rack) on top of the vehicle.\n\nTypical unit code(s): KGM for kilogram, LBR for pound\n\n* Note 1: You can indicate additional information in the [[name]] of the [[QuantitativeValue]] node.\n* Note 2: You may also link to a [[QualitativeValue]] node that provides additional information using [[valueReference]]\n* Note 3: Note that you can use [[minValue]] and [[maxValue]] to indicate ranges.
    /// <see href="https://schema.org/roofLoad"></see></summary>
    let roofLoad = _prefix "roofLoad"
    /// <summary>
    /// The response (yes, no, maybe) to the RSVP.
    /// <see href="https://schema.org/rsvpResponse"></see></summary>
    let rsvpResponse = _prefix "rsvpResponse"
    /// <summary>
    /// The vasculature the lymphatic structure runs, or efferents, to.
    /// <see href="https://schema.org/runsTo"></see></summary>
    let runsTo = _prefix "runsTo"
    /// <summary>
    /// Runtime platform or script interpreter dependencies (example: Java v1, Python 2.3, .NET Framework 3.0).
    /// <see href="https://schema.org/runtime"></see></summary>
    let runtime = _prefix "runtime"
    /// <summary>
    /// Runtime platform or script interpreter dependencies (example: Java v1, Python 2.3, .NET Framework 3.0).
    /// <see href="https://schema.org/runtimePlatform"></see></summary>
    let runtimePlatform = _prefix "runtimePlatform"
    /// <summary>
    /// The RxCUI drug identifier from RXNORM.
    /// <see href="https://schema.org/rxcui"></see></summary>
    let rxcui = _prefix "rxcui"
    /// <summary>
    /// Any potential safety concern associated with the supplement. May include interactions with other drugs and foods, pregnancy, breastfeeding, known adverse reactions, and documented efficacy of the supplement.
    /// <see href="https://schema.org/safetyConsideration"></see></summary>
    let safetyConsideration = _prefix "safetyConsideration"
    /// <summary>
    /// The currency (coded using [ISO 4217](http://en.wikipedia.org/wiki/ISO_4217)) used for the main salary information in this job posting or for this employee.
    /// <see href="https://schema.org/salaryCurrency"></see></summary>
    let salaryCurrency = _prefix "salaryCurrency"
    /// <summary>
    /// The expected salary upon completing the training.
    /// <see href="https://schema.org/salaryUponCompletion"></see></summary>
    let salaryUponCompletion = _prefix "salaryUponCompletion"
    /// <summary>
    /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
    /// <see href="https://schema.org/sampleType"></see></summary>
    let sampleType = _prefix "sampleType"
    /// <summary>
    /// The number of grams of saturated fat.
    /// <see href="https://schema.org/saturatedFatContent"></see></summary>
    let saturatedFatContent = _prefix "saturatedFatContent"
    /// <summary>
    /// Indicates the timezone for which the time(s) indicated in the [[Schedule]] are given. The value provided should be among those listed in the IANA Time Zone Database.
    /// <see href="https://schema.org/scheduleTimezone"></see></summary>
    let scheduleTimezone = _prefix "scheduleTimezone"
    /// <summary>
    /// The date the invoice is scheduled to be paid.
    /// <see href="https://schema.org/scheduledPaymentDate"></see></summary>
    let scheduledPaymentDate = _prefix "scheduledPaymentDate"
    /// <summary>
    /// The time the object is scheduled to.
    /// <see href="https://schema.org/scheduledTime"></see></summary>
    let scheduledTime = _prefix "scheduledTime"
    /// <summary>
    /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. This property was created primarily to
    ///     indicate the use of a specific schema.org release, e.g. ```10.0``` as a simple string, or more explicitly via URL, ```https://schema.org/docs/releases.html#v10.0```. There may be situations in which other schemas might usefully be referenced this way, e.g. ```http://dublincore.org/specifications/dublin-core/dces/1999-07-02/``` but this has not been carefully explored in the community.
    /// <see href="https://schema.org/schemaVersion"></see></summary>
    let schemaVersion = _prefix "schemaVersion"
    /// <summary>
    /// Information about school closures.
    /// <see href="https://schema.org/schoolClosuresInfo"></see></summary>
    let schoolClosuresInfo = _prefix "schoolClosuresInfo"
    /// <summary>
    /// The number of screens in the movie theater.
    /// <see href="https://schema.org/screenCount"></see></summary>
    let screenCount = _prefix "screenCount"
    /// <summary>
    /// A link to a screenshot image of the app.
    /// <see href="https://schema.org/screenshot"></see></summary>
    let screenshot = _prefix "screenshot"
    /// <summary>
    /// Indicates the date on which the current structured data was generated / published. Typically used alongside [[sdPublisher]].
    /// <see href="https://schema.org/sdDatePublished"></see></summary>
    let sdDatePublished = _prefix "sdDatePublished"
    /// <summary>
    /// A license document that applies to this structured data, typically indicated by URL.
    /// <see href="https://schema.org/sdLicense"></see></summary>
    let sdLicense = _prefix "sdLicense"
    /// <summary>
    /// Indicates the party responsible for generating and publishing the current structured data markup, typically in cases where the structured data is derived automatically from existing published content but published on a different site. For example, student projects and open data initiatives often re-publish existing content with more explicitly structured metadata. The
    /// [[sdPublisher]] property helps make such practices more explicit.
    /// <see href="https://schema.org/sdPublisher"></see></summary>
    let sdPublisher = _prefix "sdPublisher"
    /// <summary>
    /// A season in a media series.
    /// <see href="https://schema.org/season"></see></summary>
    let season = _prefix "season"
    /// <summary>
    /// Position of the season within an ordered group of seasons.
    /// <see href="https://schema.org/seasonNumber"></see></summary>
    let seasonNumber = _prefix "seasonNumber"
    /// <summary>
    /// Limited period during which these shipping conditions apply.
    /// <see href="https://schema.org/seasonalOverride"></see></summary>
    let seasonalOverride = _prefix "seasonalOverride"
    /// <summary>
    /// A season in a media series.
    /// <see href="https://schema.org/seasons"></see></summary>
    let seasons = _prefix "seasons"
    /// <summary>
    /// The location of the reserved seat (e.g., 27).
    /// <see href="https://schema.org/seatNumber"></see></summary>
    let seatNumber = _prefix "seatNumber"
    /// <summary>
    /// The row location of the reserved seat (e.g., B).
    /// <see href="https://schema.org/seatRow"></see></summary>
    let seatRow = _prefix "seatRow"
    /// <summary>
    /// The section location of the reserved seat (e.g. Orchestra).
    /// <see href="https://schema.org/seatSection"></see></summary>
    let seatSection = _prefix "seatSection"
    /// <summary>
    /// The number of persons that can be seated (e.g. in a vehicle), both in terms of the physical space available, and in terms of limitations set by law.\n\nTypical unit code(s): C62 for persons.
    /// <see href="https://schema.org/seatingCapacity"></see></summary>
    let seatingCapacity = _prefix "seatingCapacity"
    /// <summary>
    /// The type/class of the seat.
    /// <see href="https://schema.org/seatingType"></see></summary>
    let seatingType = _prefix "seatingType"
    /// <summary>
    /// A preventative therapy used to prevent reoccurrence of the medical condition after an initial episode of the condition.
    /// <see href="https://schema.org/secondaryPrevention"></see></summary>
    let secondaryPrevention = _prefix "secondaryPrevention"
    /// <summary>
    /// A description of any security clearance requirements of the job.
    /// <see href="https://schema.org/securityClearanceRequirement"></see></summary>
    let securityClearanceRequirement = _prefix "securityClearanceRequirement"
    /// <summary>
    /// The type of security screening the passenger is subject to.
    /// <see href="https://schema.org/securityScreening"></see></summary>
    let securityScreening = _prefix "securityScreening"
    /// <summary>
    /// A pointer to products or services sought by the organization or person (demand).
    /// <see href="https://schema.org/seeks"></see></summary>
    let seeks = _prefix "seeks"
    /// <summary>
    /// A sub property of participant. The participant who is at the sending end of the action.
    /// <see href="https://schema.org/sender"></see></summary>
    let sender = _prefix "sender"
    /// <summary>
    /// A description of any sensory requirements and levels necessary to function on the job, including hearing and vision. Defined terms such as those in O*net may be used, but note that there is no way to specify the level of ability as well as its nature when using a defined term.
    /// <see href="https://schema.org/sensoryRequirement"></see></summary>
    let sensoryRequirement = _prefix "sensoryRequirement"
    /// <summary>
    /// The neurological pathway extension that inputs and sends information to the brain or spinal cord.
    /// <see href="https://schema.org/sensoryUnit"></see></summary>
    let sensoryUnit = _prefix "sensoryUnit"
    /// <summary>
    /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
    /// <see href="https://schema.org/serialNumber"></see></summary>
    let serialNumber = _prefix "serialNumber"
    /// <summary>
    /// A possible serious complication and/or serious side effect of this therapy. Serious adverse outcomes include those that are life-threatening; result in death, disability, or permanent damage; require hospitalization or prolong existing hospitalization; cause congenital anomalies or birth defects; or jeopardize the patient and may require medical or surgical intervention to prevent one of the outcomes in this definition.
    /// <see href="https://schema.org/seriousAdverseOutcome"></see></summary>
    let seriousAdverseOutcome = _prefix "seriousAdverseOutcome"
    /// <summary>
    /// Status of a game server.
    /// <see href="https://schema.org/serverStatus"></see></summary>
    let serverStatus = _prefix "serverStatus"
    /// <summary>
    /// The cuisine of the restaurant.
    /// <see href="https://schema.org/servesCuisine"></see></summary>
    let servesCuisine = _prefix "servesCuisine"
    /// <summary>
    /// The audience eligible for this service.
    /// <see href="https://schema.org/serviceAudience"></see></summary>
    let serviceAudience = _prefix "serviceAudience"
    /// <summary>
    /// The location (e.g. civic structure, local business, etc.) where a person can go to access the service.
    /// <see href="https://schema.org/serviceLocation"></see></summary>
    let serviceLocation = _prefix "serviceLocation"
    /// <summary>
    /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
    /// <see href="https://schema.org/serviceOperator"></see></summary>
    let serviceOperator = _prefix "serviceOperator"
    /// <summary>
    /// The phone number to use to access the service.
    /// <see href="https://schema.org/servicePhone"></see></summary>
    let servicePhone = _prefix "servicePhone"
    /// <summary>
    /// The address for accessing the service by mail.
    /// <see href="https://schema.org/servicePostalAddress"></see></summary>
    let servicePostalAddress = _prefix "servicePostalAddress"
    /// <summary>
    /// The number to access the service by text message.
    /// <see href="https://schema.org/serviceSmsNumber"></see></summary>
    let serviceSmsNumber = _prefix "serviceSmsNumber"
    /// <summary>
    /// The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
    /// <see href="https://schema.org/serviceType"></see></summary>
    let serviceType = _prefix "serviceType"
    /// <summary>
    /// The website to access the service.
    /// <see href="https://schema.org/serviceUrl"></see></summary>
    let serviceUrl = _prefix "serviceUrl"
    /// <summary>
    /// The serving size, in terms of the number of volume or mass.
    /// <see href="https://schema.org/servingSize"></see></summary>
    let servingSize = _prefix "servingSize"
    /// <summary>
    /// The [SHA-2](https://en.wikipedia.org/wiki/SHA-2) SHA256 hash of the content of the item. For example, a zero-length input has value 'e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855'.
    /// <see href="https://schema.org/sha256"></see></summary>
    let sha256 = _prefix "sha256"
    /// <summary>
    /// A CreativeWork such as an image, video, or audio clip shared as part of this posting.
    /// <see href="https://schema.org/sharedContent"></see></summary>
    let sharedContent = _prefix "sharedContent"
    /// <summary>
    /// The conditions (constraints, price) applicable to the [[ShippingService]].
    /// <see href="https://schema.org/shippingConditions"></see></summary>
    let shippingConditions = _prefix "shippingConditions"
    /// <summary>
    /// indicates (possibly multiple) shipping destinations. These can be defined in several ways, e.g. postalCode ranges.
    /// <see href="https://schema.org/shippingDestination"></see></summary>
    let shippingDestination = _prefix "shippingDestination"
    /// <summary>
    /// Indicates information about the shipping policies and options associated with an [[Offer]].
    /// <see href="https://schema.org/shippingDetails"></see></summary>
    let shippingDetails = _prefix "shippingDetails"
    /// <summary>
    /// Indicates the origin of a shipment, i.e. where it should be coming from.
    /// <see href="https://schema.org/shippingOrigin"></see></summary>
    let shippingOrigin = _prefix "shippingOrigin"
    /// <summary>
    /// The shipping rate is the cost of shipping to the specified destination. Typically, the maxValue and currency values (of the [[MonetaryAmount]]) are most appropriate.
    /// <see href="https://schema.org/shippingRate"></see></summary>
    let shippingRate = _prefix "shippingRate"
    /// <summary>
    /// A sibling of the person.
    /// <see href="https://schema.org/sibling"></see></summary>
    let sibling = _prefix "sibling"
    /// <summary>
    /// A sibling of the person.
    /// <see href="https://schema.org/siblings"></see></summary>
    let siblings = _prefix "siblings"
    /// <summary>
    /// A sign detected by the test.
    /// <see href="https://schema.org/signDetected"></see></summary>
    let signDetected = _prefix "signDetected"
    /// <summary>
    /// A sign or symptom of this condition. Signs are objective or physically observable manifestations of the medical condition while symptoms are the subjective experience of the medical condition.
    /// <see href="https://schema.org/signOrSymptom"></see></summary>
    let signOrSymptom = _prefix "signOrSymptom"
    /// <summary>
    /// The significance associated with the superficial anatomy; as an example, how characteristics of the superficial anatomy can suggest underlying medical conditions or courses of treatment.
    /// <see href="https://schema.org/significance"></see></summary>
    let significance = _prefix "significance"
    /// <summary>
    /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
    /// <see href="https://schema.org/significantLink"></see></summary>
    let significantLink = _prefix "significantLink"
    /// <summary>
    /// The most significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
    /// <see href="https://schema.org/significantLinks"></see></summary>
    let significantLinks = _prefix "significantLinks"
    /// <summary>
    /// A standardized size of a product or creative work, specified either through a simple textual string (for example 'XL', '32Wx34L'), a  QuantitativeValue with a unitCode, or a comprehensive and structured [[SizeSpecification]]; in other cases, the [[width]], [[height]], [[depth]] and [[weight]] properties may be more applicable.
    /// <see href="https://schema.org/size"></see></summary>
    let size = _prefix "size"
    /// <summary>
    /// The size group (also known as "size type") for a product's size. Size groups are common in the fashion industry to define size segments and suggested audiences for wearable products. Multiple values can be combined, for example "men's big and tall", "petite maternity" or "regular".
    /// <see href="https://schema.org/sizeGroup"></see></summary>
    let sizeGroup = _prefix "sizeGroup"
    /// <summary>
    /// The size system used to identify a product's size. Typically either a standard (for example, "GS1" or "ISO-EN13402"), country code (for example "US" or "JP"), or a measuring system (for example "Metric" or "Imperial").
    /// <see href="https://schema.org/sizeSystem"></see></summary>
    let sizeSystem = _prefix "sizeSystem"
    /// <summary>
    /// A statement of knowledge, skill, ability, task or any other assertion expressing a competency that is either claimed by a person, an organization or desired or required to fulfill a role or to work in an occupation.
    /// <see href="https://schema.org/skills"></see></summary>
    let skills = _prefix "skills"
    /// <summary>
    /// The Stock Keeping Unit (SKU), i.e. a merchant-specific identifier for a product or service, or the product to which the offer refers.
    /// <see href="https://schema.org/sku"></see></summary>
    let sku = _prefix "sku"
    /// <summary>
    /// A slogan or motto associated with the item.
    /// <see href="https://schema.org/slogan"></see></summary>
    let slogan = _prefix "slogan"
    /// <summary>
    /// A specification in form of a line notation for describing the structure of chemical species using short ASCII strings.  Double bond stereochemistry \ indicators may need to be escaped in the string in formats where the backslash is an escape character.
    /// <see href="https://schema.org/smiles"></see></summary>
    let smiles = _prefix "smiles"
    /// <summary>
    /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
    /// <see href="https://schema.org/smokingAllowed"></see></summary>
    let smokingAllowed = _prefix "smokingAllowed"
    /// <summary>
    /// The number of milligrams of sodium.
    /// <see href="https://schema.org/sodiumContent"></see></summary>
    let sodiumContent = _prefix "sodiumContent"
    /// <summary>
    /// Additional content for a software application.
    /// <see href="https://schema.org/softwareAddOn"></see></summary>
    let softwareAddOn = _prefix "softwareAddOn"
    /// <summary>
    /// Software application help.
    /// <see href="https://schema.org/softwareHelp"></see></summary>
    let softwareHelp = _prefix "softwareHelp"
    /// <summary>
    /// Version of the software instance.
    /// <see href="https://schema.org/softwareVersion"></see></summary>
    let softwareVersion = _prefix "softwareVersion"
    /// <summary>
    /// The Organization on whose behalf the creator was working.
    /// <see href="https://schema.org/sourceOrganization"></see></summary>
    let sourceOrganization = _prefix "sourceOrganization"
    /// <summary>
    /// The neurological pathway that originates the neurons.
    /// <see href="https://schema.org/sourcedFrom"></see></summary>
    let sourcedFrom = _prefix "sourcedFrom"
    /// <summary>
    /// The "spatial" property can be used in cases when more specific properties
    /// (e.g. [[locationCreated]], [[spatialCoverage]], [[contentLocation]]) are not known to be appropriate.
    /// <see href="https://schema.org/spatial"></see></summary>
    let spatial = _prefix "spatial"
    /// <summary>
    /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.
    ///
    /// The *speakable* property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:
    ///
    /// 1.) *id-value* URL references - uses *id-value* of an element in the page being annotated. The simplest use of *speakable* has (potentially relative) URL values, referencing identified sections of the document concerned.
    ///
    /// 2.) CSS Selectors - addresses content in the annotated page, e.g. via class attribute. Use the [[cssSelector]] property.
    ///
    /// 3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the [[xpath]] property.
    ///
    ///
    /// For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
    /// we define a supporting type, [[SpeakableSpecification]]  which is defined to be a possible value of the *speakable* property.
    ///
    /// <see href="https://schema.org/speakable"></see></summary>
    let speakable = _prefix "speakable"
    /// <summary>
    /// Any special commitments associated with this job posting. Valid entries include VeteranCommit, MilitarySpouseCommit, etc.
    /// <see href="https://schema.org/specialCommitments"></see></summary>
    let specialCommitments = _prefix "specialCommitments"
    /// <summary>
    /// The special opening hours of a certain place.\n\nUse this to explicitly override general opening hours brought in scope by [[openingHoursSpecification]] or [[openingHours]].
    ///
    /// <see href="https://schema.org/specialOpeningHoursSpecification"></see></summary>
    let specialOpeningHoursSpecification = _prefix "specialOpeningHoursSpecification"
    /// <summary>
    /// One of the domain specialities to which this web page's content applies.
    /// <see href="https://schema.org/specialty"></see></summary>
    let specialty = _prefix "specialty"
    /// <summary>
    /// Form of markup used. eg. [SSML](https://www.w3.org/TR/speech-synthesis11) or [IPA](https://www.wikidata.org/wiki/Property:P898).
    /// <see href="https://schema.org/speechToTextMarkup"></see></summary>
    let speechToTextMarkup = _prefix "speechToTextMarkup"
    /// <summary>
    /// The speed range of the vehicle. If the vehicle is powered by an engine, the upper limit of the speed range (indicated by [[maxValue]]) should be the maximum speed achievable under regular conditions.\n\nTypical unit code(s): KMH for km/h, HM for mile per hour (0.447 04 m/s), KNT for knot\n\n*Note 1: Use [[minValue]] and [[maxValue]] to indicate the range. Typically, the minimal value is zero.\n* Note 2: There are many different ways of measuring the speed range. You can link to information about how the given value has been determined using the [[valueReference]] property.
    /// <see href="https://schema.org/speed"></see></summary>
    let speed = _prefix "speed"
    /// <summary>
    /// The (e.g. fictional) character, Person or Organization to whom the quotation is attributed within the containing CreativeWork.
    /// <see href="https://schema.org/spokenByCharacter"></see></summary>
    let spokenByCharacter = _prefix "spokenByCharacter"
    /// <summary>
    /// A type of sport (e.g. Baseball).
    /// <see href="https://schema.org/sport"></see></summary>
    let sport = _prefix "sport"
    /// <summary>
    /// A sub property of location. The sports activity location where this action occurred.
    /// <see href="https://schema.org/sportsActivityLocation"></see></summary>
    let sportsActivityLocation = _prefix "sportsActivityLocation"
    /// <summary>
    /// A sub property of location. The sports event where this action occurred.
    /// <see href="https://schema.org/sportsEvent"></see></summary>
    let sportsEvent = _prefix "sportsEvent"
    /// <summary>
    /// A sub property of participant. The sports team that participated on this action.
    /// <see href="https://schema.org/sportsTeam"></see></summary>
    let sportsTeam = _prefix "sportsTeam"
    /// <summary>
    /// The person's spouse.
    /// <see href="https://schema.org/spouse"></see></summary>
    let spouse = _prefix "spouse"
    /// <summary>
    /// The stage of the condition, if applicable.
    /// <see href="https://schema.org/stage"></see></summary>
    let stage = _prefix "stage"
    /// <summary>
    /// The stage represented as a number, e.g. 3.
    /// <see href="https://schema.org/stageAsNumber"></see></summary>
    let stageAsNumber = _prefix "stageAsNumber"
    /// <summary>
    /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
    /// <see href="https://schema.org/starRating"></see></summary>
    let starRating = _prefix "starRating"
    /// <summary>
    /// The start date and time of the item (in [ISO 8601 date format](http://en.wikipedia.org/wiki/ISO_8601)).
    /// <see href="https://schema.org/startDate"></see></summary>
    let startDate = _prefix "startDate"
    /// <summary>
    /// The start time of the clip expressed as the number of seconds from the beginning of the work.
    /// <see href="https://schema.org/startOffset"></see></summary>
    let startOffset = _prefix "startOffset"
    /// <summary>
    /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. E.g. John wrote a book from *January* to December. For media, including audio and video, it's the time offset of the start of a clip within a larger file.\n\nNote that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
    /// <see href="https://schema.org/startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// Indicates the kind of statistic represented by a [[StatisticalVariable]], e.g. mean, count etc. The value of statType is a property, either from within Schema.org (e.g. [[median]], [[marginOfError]], [[maxValue]], [[minValue]]) or from other compatible (e.g. RDF) systems such as DataCommons.org or Wikidata.org.
    /// <see href="https://schema.org/statType"></see></summary>
    let statType = _prefix "statType"
    /// <summary>
    /// The status of the study (enumerated).
    /// <see href="https://schema.org/status"></see></summary>
    let status = _prefix "status"
    /// <summary>
    /// The position of the steering wheel or similar device (mostly for cars).
    /// <see href="https://schema.org/steeringPosition"></see></summary>
    let steeringPosition = _prefix "steeringPosition"
    /// <summary>
    /// The stepValue attribute indicates the granularity that is expected (and required) of the value in a PropertyValueSpecification.
    /// <see href="https://schema.org/stepValue"></see></summary>
    let stepValue = _prefix "stepValue"
    /// <summary>
    /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection (originally misnamed 'steps'; 'step' is preferred).
    /// <see href="https://schema.org/steps"></see></summary>
    let steps = _prefix "steps"
    /// <summary>
    /// Storage requirements (free space required).
    /// <see href="https://schema.org/storageRequirements"></see></summary>
    let storageRequirements = _prefix "storageRequirements"
    /// <summary>
    /// The street address. For example, 1600 Amphitheatre Pkwy.
    /// <see href="https://schema.org/streetAddress"></see></summary>
    let streetAddress = _prefix "streetAddress"
    /// <summary>
    /// The units of an active ingredient's strength, e.g. mg.
    /// <see href="https://schema.org/strengthUnit"></see></summary>
    let strengthUnit = _prefix "strengthUnit"
    /// <summary>
    /// The value of an active ingredient's strength, e.g. 325.
    /// <see href="https://schema.org/strengthValue"></see></summary>
    let strengthValue = _prefix "strengthValue"
    /// <summary>
    /// The name given to how bone physically connects to each other.
    /// <see href="https://schema.org/structuralClass"></see></summary>
    let structuralClass = _prefix "structuralClass"
    /// <summary>
    /// A medical study or trial related to this entity.
    /// <see href="https://schema.org/study"></see></summary>
    let study = _prefix "study"
    /// <summary>
    /// Specifics about the observational study design (enumerated).
    /// <see href="https://schema.org/studyDesign"></see></summary>
    let studyDesign = _prefix "studyDesign"
    /// <summary>
    /// The location in which the study is taking/took place.
    /// <see href="https://schema.org/studyLocation"></see></summary>
    let studyLocation = _prefix "studyLocation"
    /// <summary>
    /// A subject of the study, i.e. one of the medical conditions, therapies, devices, drugs, etc. investigated by the study.
    /// <see href="https://schema.org/studySubject"></see></summary>
    let studySubject = _prefix "studySubject"
    /// <summary>
    /// An Event that is part of this event. For example, a conference event includes many presentations, each of which is a subEvent of the conference.
    /// <see href="https://schema.org/subEvent"></see></summary>
    let subEvent = _prefix "subEvent"
    /// <summary>
    /// An event that this event is a part of. For example, a collection of individual music performances might each have a music festival as their superEvent.
    /// <see href="https://schema.org/superEvent"></see></summary>
    let superEvent = _prefix "superEvent"
    /// <summary>
    /// Events that are a part of this event. For example, a conference event includes many presentations, each subEvents of the conference.
    /// <see href="https://schema.org/subEvents"></see></summary>
    let subEvents = _prefix "subEvents"
    /// <summary>
    /// The individual reservations included in the package. Typically a repeated property.
    /// <see href="https://schema.org/subReservation"></see></summary>
    let subReservation = _prefix "subReservation"
    /// <summary>
    /// The substage, e.g. 'a' for Stage IIIa.
    /// <see href="https://schema.org/subStageSuffix"></see></summary>
    let subStageSuffix = _prefix "subStageSuffix"
    /// <summary>
    /// Component (sub-)structure(s) that comprise this anatomical structure.
    /// <see href="https://schema.org/subStructure"></see></summary>
    let subStructure = _prefix "subStructure"
    /// <summary>
    /// A component test of the panel.
    /// <see href="https://schema.org/subTest"></see></summary>
    let subTest = _prefix "subTest"
    /// <summary>
    /// Languages in which subtitles/captions are available, in [IETF BCP 47 standard format](http://tools.ietf.org/html/bcp47).
    /// <see href="https://schema.org/subtitleLanguage"></see></summary>
    let subtitleLanguage = _prefix "subtitleLanguage"
    /// <summary>
    /// A pointer from a newer variant of a product  to its previous, often discontinued predecessor.
    /// <see href="https://schema.org/successorOf"></see></summary>
    let successorOf = _prefix "successorOf"
    /// <summary>
    /// The number of grams of sugar.
    /// <see href="https://schema.org/sugarContent"></see></summary>
    let sugarContent = _prefix "sugarContent"
    /// <summary>
    /// The age or age range for the intended audience or person, for example 3-12 months for infants, 1-5 years for toddlers.
    /// <see href="https://schema.org/suggestedAge"></see></summary>
    let suggestedAge = _prefix "suggestedAge"
    /// <summary>
    /// The suggested gender of the intended person or audience, for example "male", "female", or "unisex".
    /// <see href="https://schema.org/suggestedGender"></see></summary>
    let suggestedGender = _prefix "suggestedGender"
    /// <summary>
    /// Maximum recommended age in years for the audience or user.
    /// <see href="https://schema.org/suggestedMaxAge"></see></summary>
    let suggestedMaxAge = _prefix "suggestedMaxAge"
    /// <summary>
    /// A suggested range of body measurements for the intended audience or person, for example inseam between 32 and 34 inches or height between 170 and 190 cm. Typically found on a size chart for wearable products.
    /// <see href="https://schema.org/suggestedMeasurement"></see></summary>
    let suggestedMeasurement = _prefix "suggestedMeasurement"
    /// <summary>
    /// Minimum recommended age in years for the audience or user.
    /// <see href="https://schema.org/suggestedMinAge"></see></summary>
    let suggestedMinAge = _prefix "suggestedMinAge"
    /// <summary>
    /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
    /// <see href="https://schema.org/suitableForDiet"></see></summary>
    let suitableForDiet = _prefix "suitableForDiet"
    /// <summary>
    /// The area to which the artery supplies blood.
    /// <see href="https://schema.org/supplyTo"></see></summary>
    let supplyTo = _prefix "supplyTo"
    /// <summary>
    /// Supporting data for a SoftwareApplication.
    /// <see href="https://schema.org/supportingData"></see></summary>
    let supportingData = _prefix "supportingData"
    /// <summary>
    /// A material used as a surface in some artwork, e.g. Canvas, Paper, Wood, Board, etc.
    /// <see href="https://schema.org/surface"></see></summary>
    let surface = _prefix "surface"
    /// <summary>
    /// Indicates (typically several) Syllabus entities that lay out what each section of the overall course will cover.
    /// <see href="https://schema.org/syllabusSections"></see></summary>
    let syllabusSections = _prefix "syllabusSections"
    /// <summary>
    /// Indicates a target EntryPoint, or url, for an Action.
    /// <see href="https://schema.org/target"></see></summary>
    let target = _prefix "target"
    /// <summary>
    /// The description of a node in an established educational framework.
    /// <see href="https://schema.org/targetDescription"></see></summary>
    let targetDescription = _prefix "targetDescription"
    /// <summary>
    /// The name of a node in an established educational framework.
    /// <see href="https://schema.org/targetName"></see></summary>
    let targetName = _prefix "targetName"
    /// <summary>
    /// Type of app development: phone, Metro style, desktop, XBox, etc.
    /// <see href="https://schema.org/targetPlatform"></see></summary>
    let targetPlatform = _prefix "targetPlatform"
    /// <summary>
    /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
    /// <see href="https://schema.org/targetPopulation"></see></summary>
    let targetPopulation = _prefix "targetPopulation"
    /// <summary>
    /// Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.
    /// <see href="https://schema.org/targetProduct"></see></summary>
    let targetProduct = _prefix "targetProduct"
    /// <summary>
    /// The URL of a node in an established educational framework.
    /// <see href="https://schema.org/targetUrl"></see></summary>
    let targetUrl = _prefix "targetUrl"
    /// <summary>
    /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
    /// <see href="https://schema.org/taxID"></see></summary>
    let taxID = _prefix "taxID"
    /// <summary>
    /// The taxonomic rank of this taxon given preferably as a URI from a controlled vocabulary – typically the ranks from TDWG TaxonRank ontology or equivalent Wikidata URIs.
    /// <see href="https://schema.org/taxonRank"></see></summary>
    let taxonRank = _prefix "taxonRank"
    /// <summary>
    /// The taxonomic grouping of the organism that expresses, encodes, or in some way related to the BioChemEntity.
    /// <see href="https://schema.org/taxonomicRange"></see></summary>
    let taxonomicRange = _prefix "taxonomicRange"
    /// <summary>
    /// The item being described is intended to help a person learn the competency or learning outcome defined by the referenced term.
    /// <see href="https://schema.org/teaches"></see></summary>
    let teaches = _prefix "teaches"
    /// <summary>
    /// The telephone number.
    /// <see href="https://schema.org/telephone"></see></summary>
    let telephone = _prefix "telephone"
    /// <summary>
    /// The "temporal" property can be used in cases where more specific properties
    /// (e.g. [[temporalCoverage]], [[dateCreated]], [[dateModified]], [[datePublished]]) are not known to be appropriate.
    /// <see href="https://schema.org/temporal"></see></summary>
    let temporal = _prefix "temporal"
    /// <summary>
    /// The amount of time in a term as defined by the institution. A term is a length of time where students take one or more classes. Semesters and quarters are common units for term.
    /// <see href="https://schema.org/termDuration"></see></summary>
    let termDuration = _prefix "termDuration"
    /// <summary>
    /// Human-readable terms of service documentation.
    /// <see href="https://schema.org/termsOfService"></see></summary>
    let termsOfService = _prefix "termsOfService"
    /// <summary>
    /// The number of times terms of study are offered per year. Semesters and quarters are common units for term. For example, if the student can only take 2 semesters for the program in one year, then termsPerYear should be 2.
    /// <see href="https://schema.org/termsPerYear"></see></summary>
    let termsPerYear = _prefix "termsPerYear"
    /// <summary>
    /// The textual content of this CreativeWork.
    /// <see href="https://schema.org/text"></see></summary>
    let text = _prefix "text"
    /// <summary>
    /// Text value being annotated.
    /// <see href="https://schema.org/textValue"></see></summary>
    let textValue = _prefix "textValue"
    /// <summary>
    /// Thumbnail image for an image or video.
    /// <see href="https://schema.org/thumbnail"></see></summary>
    let thumbnail = _prefix "thumbnail"
    /// <summary>
    /// A thumbnail image relevant to the Thing.
    /// <see href="https://schema.org/thumbnailUrl"></see></summary>
    let thumbnailUrl = _prefix "thumbnailUrl"
    /// <summary>
    /// The exchange traded instrument associated with a Corporation object. The tickerSymbol is expressed as an exchange and an instrument name separated by a space character. For the exchange component of the tickerSymbol attribute, we recommend using the controlled vocabulary of Market Identifier Codes (MIC) specified in ISO 15022.
    /// <see href="https://schema.org/tickerSymbol"></see></summary>
    let tickerSymbol = _prefix "tickerSymbol"
    /// <summary>
    /// The unique identifier for the ticket.
    /// <see href="https://schema.org/ticketNumber"></see></summary>
    let ticketNumber = _prefix "ticketNumber"
    /// <summary>
    /// Reference to an asset (e.g., Barcode, QR code image or PDF) usable for entrance.
    /// <see href="https://schema.org/ticketToken"></see></summary>
    let ticketToken = _prefix "ticketToken"
    /// <summary>
    /// The seat associated with the ticket.
    /// <see href="https://schema.org/ticketedSeat"></see></summary>
    let ticketedSeat = _prefix "ticketedSeat"
    /// <summary>
    /// The time of day the program normally runs. For example, "evenings".
    /// <see href="https://schema.org/timeOfDay"></see></summary>
    let timeOfDay = _prefix "timeOfDay"
    /// <summary>
    /// Approximate or typical time it usually takes to work with or through the content of this work for the typical or target audience.
    /// <see href="https://schema.org/timeRequired"></see></summary>
    let timeRequired = _prefix "timeRequired"
    /// <summary>
    /// The expected length of time to complete the program if attending full-time.
    /// <see href="https://schema.org/timeToComplete"></see></summary>
    let timeToComplete = _prefix "timeToComplete"
    /// <summary>
    /// The instant the event occured.
    /// <see href="https://schema.org/timestamp"></see></summary>
    let timestamp = _prefix "timestamp"
    /// <summary>
    /// The type of tissue sample required for the test.
    /// <see href="https://schema.org/tissueSample"></see></summary>
    let tissueSample = _prefix "tissueSample"
    /// <summary>
    /// The title of the job.
    /// <see href="https://schema.org/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// An [EIDR](https://eidr.org/) (Entertainment Identifier Registry) [[identifier]] representing at the most general/abstract level, a work of film or television.
    ///
    /// For example, the motion picture known as "Ghostbusters" has a titleEIDR of  "10.5240/7EC7-228A-510A-053E-CBB8-J". This title (or work) may have several variants, which EIDR calls "edits". See [[editEIDR]].
    ///
    /// Since schema.org types like [[Movie]], [[TVEpisode]], [[TVSeason]], and [[TVSeries]] can be used for both works and their multiple expressions, it is possible to use [[titleEIDR]] alone (for a general description), or alongside [[editEIDR]] for a more edit-specific description.
    ///
    /// <see href="https://schema.org/titleEIDR"></see></summary>
    let titleEIDR = _prefix "titleEIDR"
    /// <summary>
    /// A sub property of location. The final location of the object or the agent after the action.
    /// <see href="https://schema.org/toLocation"></see></summary>
    let toLocation = _prefix "toLocation"
    /// <summary>
    /// A sub property of recipient. The recipient who was directly sent the message.
    /// <see href="https://schema.org/toRecipient"></see></summary>
    let toRecipient = _prefix "toRecipient"
    /// <summary>
    /// A [[HyperTocEntry]] can have a [[tocContinuation]] indicated, which is another [[HyperTocEntry]] that would be the default next item to play or render.
    /// <see href="https://schema.org/tocContinuation"></see></summary>
    let tocContinuation = _prefix "tocContinuation"
    /// <summary>
    /// Indicates a [[HyperTocEntry]] in a [[HyperToc]].
    /// <see href="https://schema.org/tocEntry"></see></summary>
    let tocEntry = _prefix "tocEntry"
    /// <summary>
    /// The permitted vertical load (TWR) of a trailer attached to the vehicle. Also referred to as Tongue Load Rating (TLR) or Vertical Load Rating (VLR).\n\nTypical unit code(s): KGM for kilogram, LBR for pound\n\n* Note 1: You can indicate additional information in the [[name]] of the [[QuantitativeValue]] node.\n* Note 2: You may also link to a [[QualitativeValue]] node that provides additional information using [[valueReference]].\n* Note 3: Note that you can use [[minValue]] and [[maxValue]] to indicate ranges.
    /// <see href="https://schema.org/tongueWeight"></see></summary>
    let tongueWeight = _prefix "tongueWeight"
    /// <summary>
    /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
    /// <see href="https://schema.org/tool"></see></summary>
    let tool = _prefix "tool"
    /// <summary>
    /// The torque (turning force) of the vehicle's engine.\n\nTypical unit code(s): NU for newton metre (N m), F17 for pound-force per foot, or F48 for pound-force per inch\n\n* Note 1: You can link to information about how the given value has been determined (e.g. reference RPM) using the [[valueReference]] property.\n* Note 2: You can use [[minValue]] and [[maxValue]] to indicate ranges.
    /// <see href="https://schema.org/torque"></see></summary>
    let torque = _prefix "torque"
    /// <summary>
    /// The total number of students that have enrolled in the history of the course.
    /// <see href="https://schema.org/totalHistoricalEnrollment"></see></summary>
    let totalHistoricalEnrollment = _prefix "totalHistoricalEnrollment"
    /// <summary>
    /// The number of positions open for this job posting. Use a positive integer. Do not use if the number of positions is unclear or not known.
    /// <see href="https://schema.org/totalJobOpenings"></see></summary>
    let totalJobOpenings = _prefix "totalJobOpenings"
    /// <summary>
    /// The total amount due.
    /// <see href="https://schema.org/totalPaymentDue"></see></summary>
    let totalPaymentDue = _prefix "totalPaymentDue"
    /// <summary>
    /// The total price for the reservation or ticket, including applicable taxes, shipping, etc.\n\nUsage guidelines:\n\n* Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similar Unicode symbols.\n* Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
    /// <see href="https://schema.org/totalPrice"></see></summary>
    let totalPrice = _prefix "totalPrice"
    /// <summary>
    /// The total time required to perform instructions or a direction (including time to prepare the supplies), in [ISO 8601 duration format](http://en.wikipedia.org/wiki/ISO_8601).
    /// <see href="https://schema.org/totalTime"></see></summary>
    let totalTime = _prefix "totalTime"
    /// <summary>
    /// A page providing information on how to book a tour of some [[Place]], such as an [[Accommodation]] or [[ApartmentComplex]] in a real estate setting, as well as other kinds of tours as appropriate.
    /// <see href="https://schema.org/tourBookingPage"></see></summary>
    let tourBookingPage = _prefix "tourBookingPage"
    /// <summary>
    /// Attraction suitable for type(s) of tourist. E.g. children, visitors from a particular country, etc.
    /// <see href="https://schema.org/touristType"></see></summary>
    let touristType = _prefix "touristType"
    /// <summary>
    /// A music recording (track)&amp;#x2014;usually a single song. If an ItemList is given, the list should contain items of type MusicRecording.
    /// <see href="https://schema.org/track"></see></summary>
    let track = _prefix "track"
    /// <summary>
    /// Shipper tracking number.
    /// <see href="https://schema.org/trackingNumber"></see></summary>
    let trackingNumber = _prefix "trackingNumber"
    /// <summary>
    /// Tracking url for the parcel delivery.
    /// <see href="https://schema.org/trackingUrl"></see></summary>
    let trackingUrl = _prefix "trackingUrl"
    /// <summary>
    /// A music recording (track)&amp;#x2014;usually a single song.
    /// <see href="https://schema.org/tracks"></see></summary>
    let tracks = _prefix "tracks"
    /// <summary>
    /// The trailer of a movie or TV/radio series, season, episode, etc.
    /// <see href="https://schema.org/trailer"></see></summary>
    let trailer = _prefix "trailer"
    /// <summary>
    /// The permitted weight of a trailer attached to the vehicle.\n\nTypical unit code(s): KGM for kilogram, LBR for pound\n* Note 1: You can indicate additional information in the [[name]] of the [[QuantitativeValue]] node.\n* Note 2: You may also link to a [[QualitativeValue]] node that provides additional information using [[valueReference]].\n* Note 3: Note that you can use [[minValue]] and [[maxValue]] to indicate ranges.
    /// <see href="https://schema.org/trailerWeight"></see></summary>
    let trailerWeight = _prefix "trailerWeight"
    /// <summary>
    /// The name of the train (e.g. The Orient Express).
    /// <see href="https://schema.org/trainName"></see></summary>
    let trainName = _prefix "trainName"
    /// <summary>
    /// The unique identifier for the train.
    /// <see href="https://schema.org/trainNumber"></see></summary>
    let trainNumber = _prefix "trainNumber"
    /// <summary>
    /// The estimated salary earned while in the program.
    /// <see href="https://schema.org/trainingSalary"></see></summary>
    let trainingSalary = _prefix "trainingSalary"
    /// <summary>
    /// The number of grams of trans fat.
    /// <see href="https://schema.org/transFatContent"></see></summary>
    let transFatContent = _prefix "transFatContent"
    /// <summary>
    /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
    /// <see href="https://schema.org/transcript"></see></summary>
    let transcript = _prefix "transcript"
    /// <summary>
    /// The typical delay the order has been sent for delivery and the goods reach the final customer.
    ///
    ///   In the context of [[ShippingDeliveryTime]], use the [[QuantitativeValue]]. Typical properties: minValue, maxValue, unitCode (d for DAY).
    ///
    ///   In the context of [[ShippingConditions]], use the [[ServicePeriod]]. It has a duration (as a [[QuantitativeValue]]) and also business days and a cut-off time.
    ///
    /// <see href="https://schema.org/transitTime"></see></summary>
    let transitTime = _prefix "transitTime"
    /// <summary>
    /// The work that this work has been translated from. E.g. 物种起源 is a translationOf “On the Origin of Species”.
    /// <see href="https://schema.org/translationOfWork"></see></summary>
    let translationOfWork = _prefix "translationOfWork"
    /// <summary>
    /// A work that is a translation of the content of this work. E.g. 西遊記 has an English workTranslation “Journey to the West”, a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese  translation Tây du ký bình khảo.
    /// <see href="https://schema.org/workTranslation"></see></summary>
    let workTranslation = _prefix "workTranslation"
    /// <summary>
    /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
    /// <see href="https://schema.org/translator"></see></summary>
    let translator = _prefix "translator"
    /// <summary>
    /// How the disease spreads, either as a route or vector, for example 'direct contact', 'Aedes aegypti', etc.
    /// <see href="https://schema.org/transmissionMethod"></see></summary>
    let transmissionMethod = _prefix "transmissionMethod"
    /// <summary>
    /// Information about travel bans, e.g. in the context of a pandemic.
    /// <see href="https://schema.org/travelBans"></see></summary>
    let travelBans = _prefix "travelBans"
    /// <summary>
    /// Specifics about the trial design (enumerated).
    /// <see href="https://schema.org/trialDesign"></see></summary>
    let trialDesign = _prefix "trialDesign"
    /// <summary>
    /// The anatomical or organ system that the vein flows into; a larger structure that the vein connects to.
    /// <see href="https://schema.org/tributary"></see></summary>
    let tributary = _prefix "tributary"
    /// <summary>
    /// The location of origin of the trip, prior to any destination(s).
    /// <see href="https://schema.org/tripOrigin"></see></summary>
    let tripOrigin = _prefix "tripOrigin"
    /// <summary>
    /// The type of bed to which the BedDetail refers, i.e. the type of bed available in the quantity indicated by quantity.
    /// <see href="https://schema.org/typeOfBed"></see></summary>
    let typeOfBed = _prefix "typeOfBed"
    /// <summary>
    /// The product that this structured value is referring to.
    /// <see href="https://schema.org/typeOfGood"></see></summary>
    let typeOfGood = _prefix "typeOfGood"
    /// <summary>
    /// The typical expected age range, e.g. '7-9', '11-'.
    /// <see href="https://schema.org/typicalAgeRange"></see></summary>
    let typicalAgeRange = _prefix "typicalAgeRange"
    /// <summary>
    /// The number of credits or units a full-time student would be expected to take in 1 term however 'term' is defined by the institution.
    /// <see href="https://schema.org/typicalCreditsPerTerm"></see></summary>
    let typicalCreditsPerTerm = _prefix "typicalCreditsPerTerm"
    /// <summary>
    /// A medical test typically performed given this condition.
    /// <see href="https://schema.org/typicalTest"></see></summary>
    let typicalTest = _prefix "typicalTest"
    /// <summary>
    /// The person or organization the reservation or ticket is for.
    /// <see href="https://schema.org/underName"></see></summary>
    let underName = _prefix "underName"
    /// <summary>
    /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
    /// <see href="https://schema.org/unitCode"></see></summary>
    let unitCode = _prefix "unitCode"
    /// <summary>
    /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
    /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
    /// <see href="https://schema.org/unitText"></see></summary>
    let unitText = _prefix "unitText"
    /// <summary>
    /// For an [[Organization]] (typically a [[NewsMediaOrganization]]), a statement about policy on use of unnamed sources and the decision process required.
    /// <see href="https://schema.org/unnamedSourcesPolicy"></see></summary>
    let unnamedSourcesPolicy = _prefix "unnamedSourcesPolicy"
    /// <summary>
    /// The number of grams of unsaturated fat.
    /// <see href="https://schema.org/unsaturatedFatContent"></see></summary>
    let unsaturatedFatContent = _prefix "unsaturatedFatContent"
    /// <summary>
    /// Date (including time if available) when this media object was uploaded to this site.
    /// <see href="https://schema.org/uploadDate"></see></summary>
    let uploadDate = _prefix "uploadDate"
    /// <summary>
    /// The number of upvotes this question, answer or comment has received from the community.
    /// <see href="https://schema.org/upvoteCount"></see></summary>
    let upvoteCount = _prefix "upvoteCount"
    /// <summary>
    /// URL of the item.
    /// <see href="https://schema.org/url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// An url template (RFC6570) that will be used to construct the target of the execution of the action.
    /// <see href="https://schema.org/urlTemplate"></see></summary>
    let urlTemplate = _prefix "urlTemplate"
    /// <summary>
    /// A &lt;a href="https://en.wikipedia.org/wiki/National_Provider_Identifier"&gt;National Provider Identifier&lt;/a&gt; (NPI)
    ///     is a unique 10-digit identification number issued to health care providers in the United States by the Centers for Medicare and Medicaid Services.
    /// <see href="https://schema.org/usNPI"></see></summary>
    let usNPI = _prefix "usNPI"
    /// <summary>
    /// A condition the test is used to diagnose.
    /// <see href="https://schema.org/usedToDiagnose"></see></summary>
    let usedToDiagnose = _prefix "usedToDiagnose"
    /// <summary>
    /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
    /// <see href="https://schema.org/userInteractionCount"></see></summary>
    let userInteractionCount = _prefix "userInteractionCount"
    /// <summary>
    /// Device used to perform the test.
    /// <see href="https://schema.org/usesDevice"></see></summary>
    let usesDevice = _prefix "usesDevice"
    /// <summary>
    /// The standard for interpreting the Plan ID. The preferred is "HIOS". See the Centers for Medicare &amp; Medicaid Services for more details.
    /// <see href="https://schema.org/usesHealthPlanIdStandard"></see></summary>
    let usesHealthPlanIdStandard = _prefix "usesHealthPlanIdStandard"
    /// <summary>
    /// Text of an utterances (spoken words, lyrics etc.) that occurs at a certain section of a media object, represented as a [[HyperTocEntry]].
    /// <see href="https://schema.org/utterances"></see></summary>
    let utterances = _prefix "utterances"
    /// <summary>
    /// The duration of validity of a permit or similar thing.
    /// <see href="https://schema.org/validFor"></see></summary>
    let validFor = _prefix "validFor"
    /// <summary>
    /// The membership program tier(s) an Offer (or a PriceSpecification, OfferShippingDetails, or MerchantReturnPolicy under an Offer) is valid for.
    /// <see href="https://schema.org/validForMemberTier"></see></summary>
    let validForMemberTier = _prefix "validForMemberTier"
    /// <summary>
    /// The date when the item becomes valid.
    /// <see href="https://schema.org/validFrom"></see></summary>
    let validFrom = _prefix "validFrom"
    /// <summary>
    /// The geographic area where the item is valid. Applies for example to a [[Permit]], a [[Certification]], or an [[EducationalOccupationalCredential]].
    /// <see href="https://schema.org/validIn"></see></summary>
    let validIn = _prefix "validIn"
    /// <summary>
    /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
    /// <see href="https://schema.org/validThrough"></see></summary>
    let validThrough = _prefix "validThrough"
    /// <summary>
    /// The date when the item is no longer valid.
    /// <see href="https://schema.org/validUntil"></see></summary>
    let validUntil = _prefix "validUntil"
    /// <summary>
    /// The value of a [[QuantitativeValue]] (including [[Observation]]) or property value node.\n\n* For [[QuantitativeValue]] and [[MonetaryAmount]], the recommended type for values is 'Number'.\n* For [[PropertyValue]], it can be 'Text', 'Number', 'Boolean', or 'StructuredValue'.\n* Use values from 0123456789 (Unicode 'DIGIT ZERO' (U+0030) to 'DIGIT NINE' (U+0039)) rather than superficially similar Unicode symbols.\n* Use '.' (Unicode 'FULL STOP' (U+002E)) rather than ',' to indicate a decimal point. Avoid using these symbols as a readability separator.
    /// <see href="https://schema.org/value"></see></summary>
    let value = _prefix "value"
    /// <summary>
    /// Specifies whether the applicable value-added tax (VAT) is included in the price specification or not.
    /// <see href="https://schema.org/valueAddedTaxIncluded"></see></summary>
    let valueAddedTaxIncluded = _prefix "valueAddedTaxIncluded"
    /// <summary>
    /// Specifies the allowed range for number of characters in a literal value.
    /// <see href="https://schema.org/valueMaxLength"></see></summary>
    let valueMaxLength = _prefix "valueMaxLength"
    /// <summary>
    /// Specifies the minimum allowed range for number of characters in a literal value.
    /// <see href="https://schema.org/valueMinLength"></see></summary>
    let valueMinLength = _prefix "valueMinLength"
    /// <summary>
    /// Indicates the name of the PropertyValueSpecification to be used in URL templates and form encoding in a manner analogous to HTML's input@name.
    /// <see href="https://schema.org/valueName"></see></summary>
    let valueName = _prefix "valueName"
    /// <summary>
    /// Specifies a regular expression for testing literal values according to the HTML spec.
    /// <see href="https://schema.org/valuePattern"></see></summary>
    let valuePattern = _prefix "valuePattern"
    /// <summary>
    /// A secondary value that provides additional information on the original value, e.g. a reference temperature or a type of measurement.
    /// <see href="https://schema.org/valueReference"></see></summary>
    let valueReference = _prefix "valueReference"
    /// <summary>
    /// Whether the property must be filled in to complete the action.  Default is false.
    /// <see href="https://schema.org/valueRequired"></see></summary>
    let valueRequired = _prefix "valueRequired"
    /// <summary>
    /// The variableMeasured property can indicate (repeated as necessary) the  variables that are measured in some dataset, either described as text or as pairs of identifier and description using PropertyValue, or more explicitly as a [[StatisticalVariable]].
    /// <see href="https://schema.org/variableMeasured"></see></summary>
    let variableMeasured = _prefix "variableMeasured"
    /// <summary>
    /// A description of the variant cover
    ///     	for the issue, if the issue is a variant printing. For example, "Bryan Hitch
    ///     	Variant Cover" or "2nd Printing Variant".
    /// <see href="https://schema.org/variantCover"></see></summary>
    let variantCover = _prefix "variantCover"
    /// <summary>
    /// Indicates the property or properties by which the variants in a [[ProductGroup]] vary, e.g. their size, color etc. Schema.org properties can be referenced by their short name e.g. "color"; terms defined elsewhere can be referenced with their URIs.
    /// <see href="https://schema.org/variesBy"></see></summary>
    let variesBy = _prefix "variesBy"
    /// <summary>
    /// The value-added Tax ID of the organization or person with national prefix (for example IT123456789). Can also be described as [[iso6523Code]] with proper prefix.
    /// <see href="https://schema.org/vatID"></see></summary>
    let vatID = _prefix "vatID"
    /// <summary>
    /// A short text indicating the configuration of the vehicle, e.g. '5dr hatchback ST 2.5 MT 225 hp' or 'limited edition'.
    /// <see href="https://schema.org/vehicleConfiguration"></see></summary>
    let vehicleConfiguration = _prefix "vehicleConfiguration"
    /// <summary>
    /// Information about the engine or engines of the vehicle.
    /// <see href="https://schema.org/vehicleEngine"></see></summary>
    let vehicleEngine = _prefix "vehicleEngine"
    /// <summary>
    /// The Vehicle Identification Number (VIN) is a unique serial number used by the automotive industry to identify individual motor vehicles.
    /// <see href="https://schema.org/vehicleIdentificationNumber"></see></summary>
    let vehicleIdentificationNumber = _prefix "vehicleIdentificationNumber"
    /// <summary>
    /// The color or color combination of the interior of the vehicle.
    /// <see href="https://schema.org/vehicleInteriorColor"></see></summary>
    let vehicleInteriorColor = _prefix "vehicleInteriorColor"
    /// <summary>
    /// The type or material of the interior of the vehicle (e.g. synthetic fabric, leather, wood, etc.). While most interior types are characterized by the material used, an interior type can also be based on vehicle usage or target audience.
    /// <see href="https://schema.org/vehicleInteriorType"></see></summary>
    let vehicleInteriorType = _prefix "vehicleInteriorType"
    /// <summary>
    /// The release date of a vehicle model (often used to differentiate versions of the same make and model).
    /// <see href="https://schema.org/vehicleModelDate"></see></summary>
    let vehicleModelDate = _prefix "vehicleModelDate"
    /// <summary>
    /// The number of passengers that can be seated in the vehicle, both in terms of the physical space available, and in terms of limitations set by law.\n\nTypical unit code(s): C62 for persons.
    /// <see href="https://schema.org/vehicleSeatingCapacity"></see></summary>
    let vehicleSeatingCapacity = _prefix "vehicleSeatingCapacity"
    /// <summary>
    /// Indicates whether the vehicle has been used for special purposes, like commercial rental, driving school, or as a taxi. The legislation in many countries requires this information to be revealed when offering a car for sale.
    /// <see href="https://schema.org/vehicleSpecialUsage"></see></summary>
    let vehicleSpecialUsage = _prefix "vehicleSpecialUsage"
    /// <summary>
    /// The type of component used for transmitting the power from a rotating power source to the wheels or other relevant component(s) ("gearbox" for cars).
    /// <see href="https://schema.org/vehicleTransmission"></see></summary>
    let vehicleTransmission = _prefix "vehicleTransmission"
    /// <summary>
    /// 'vendor' is an earlier term for 'seller'.
    /// <see href="https://schema.org/vendor"></see></summary>
    let vendor = _prefix "vendor"
    /// <summary>
    /// Disclosure about verification and fact-checking processes for a [[NewsMediaOrganization]] or other fact-checking [[Organization]].
    /// <see href="https://schema.org/verificationFactCheckingPolicy"></see></summary>
    let verificationFactCheckingPolicy = _prefix "verificationFactCheckingPolicy"
    /// <summary>
    /// The version of the CreativeWork embodied by a specified resource.
    /// <see href="https://schema.org/version"></see></summary>
    let version = _prefix "version"
    /// <summary>
    /// An embedded video object.
    /// <see href="https://schema.org/video"></see></summary>
    let video = _prefix "video"
    /// <summary>
    /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
    /// <see href="https://schema.org/videoFormat"></see></summary>
    let videoFormat = _prefix "videoFormat"
    /// <summary>
    /// The frame size of the video.
    /// <see href="https://schema.org/videoFrameSize"></see></summary>
    let videoFrameSize = _prefix "videoFrameSize"
    /// <summary>
    /// The quality of the video.
    /// <see href="https://schema.org/videoQuality"></see></summary>
    let videoQuality = _prefix "videoQuality"
    /// <summary>
    /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
    /// <see href="https://schema.org/volumeNumber"></see></summary>
    let volumeNumber = _prefix "volumeNumber"
    /// <summary>
    /// Any FDA or other warnings about the drug (text or URL).
    /// <see href="https://schema.org/warning"></see></summary>
    let warning = _prefix "warning"
    /// <summary>
    /// The warranty promise(s) included in the offer.
    /// <see href="https://schema.org/warranty"></see></summary>
    let warranty = _prefix "warranty"
    /// <summary>
    /// The warranty promise(s) included in the offer.
    /// <see href="https://schema.org/warrantyPromise"></see></summary>
    let warrantyPromise = _prefix "warrantyPromise"
    /// <summary>
    /// The scope of the warranty promise.
    /// <see href="https://schema.org/warrantyScope"></see></summary>
    let warrantyScope = _prefix "warrantyScope"
    /// <summary>
    /// The time when a passenger can check into the flight online.
    /// <see href="https://schema.org/webCheckinTime"></see></summary>
    let webCheckinTime = _prefix "webCheckinTime"
    /// <summary>
    /// The URL for a feed, e.g. associated with a podcast series, blog, or series of date-stamped updates. This is usually RSS or Atom.
    /// <see href="https://schema.org/webFeed"></see></summary>
    let webFeed = _prefix "webFeed"
    /// <summary>
    /// The weight of the product or person.
    /// <see href="https://schema.org/weight"></see></summary>
    let weight = _prefix "weight"
    /// <summary>
    /// Value representing the fraction of the weight that is used to compute the shipping price. Example: 0.10 and a shipping weight of 15kg would add $1.5 to the order price, where the $ is the currency of the order.
    /// <see href="https://schema.org/weightPercentage"></see></summary>
    let weightPercentage = _prefix "weightPercentage"
    /// <summary>
    /// The permitted total weight of the loaded vehicle, including passengers and cargo and the weight of the empty vehicle.\n\nTypical unit code(s): KGM for kilogram, LBR for pound\n\n* Note 1: You can indicate additional information in the [[name]] of the [[QuantitativeValue]] node.\n* Note 2: You may also link to a [[QualitativeValue]] node that provides additional information using [[valueReference]].\n* Note 3: Note that you can use [[minValue]] and [[maxValue]] to indicate ranges.
    /// <see href="https://schema.org/weightTotal"></see></summary>
    let weightTotal = _prefix "weightTotal"
    /// <summary>
    /// The distance between the centers of the front and rear wheels.\n\nTypical unit code(s): CMT for centimeters, MTR for meters, INH for inches, FOT for foot/feet.
    /// <see href="https://schema.org/wheelbase"></see></summary>
    let wheelbase = _prefix "wheelbase"
    /// <summary>
    /// The width of the item.
    /// <see href="https://schema.org/width"></see></summary>
    let width = _prefix "width"
    /// <summary>
    /// A sub property of participant. The winner of the action.
    /// <see href="https://schema.org/winner"></see></summary>
    let winner = _prefix "winner"
    /// <summary>
    /// The number of words in the text of the CreativeWork such as an Article, Book, etc.
    /// <see href="https://schema.org/wordCount"></see></summary>
    let wordCount = _prefix "wordCount"
    /// <summary>
    /// A work featured in some event, e.g. exhibited in an ExhibitionEvent.
    ///        Specific subproperties are available for workPerformed (e.g. a play), or a workPresented (a Movie at a ScreeningEvent).
    /// <see href="https://schema.org/workFeatured"></see></summary>
    let workFeatured = _prefix "workFeatured"
    /// <summary>
    /// The typical working hours for this job (e.g. 1st shift, night shift, 8am-5pm).
    /// <see href="https://schema.org/workHours"></see></summary>
    let workHours = _prefix "workHours"
    /// <summary>
    /// A contact location for a person's place of work.
    /// <see href="https://schema.org/workLocation"></see></summary>
    let workLocation = _prefix "workLocation"
    /// <summary>
    /// A work performed in some event, for example a play performed in a TheaterEvent.
    /// <see href="https://schema.org/workPerformed"></see></summary>
    let workPerformed = _prefix "workPerformed"
    /// <summary>
    /// The movie presented during this event.
    /// <see href="https://schema.org/workPresented"></see></summary>
    let workPresented = _prefix "workPresented"
    /// <summary>
    /// Quantitative measure of the physiologic output of the exercise; also referred to as energy expenditure.
    /// <see href="https://schema.org/workload"></see></summary>
    let workload = _prefix "workload"
    /// <summary>
    /// Organizations that the person works for.
    /// <see href="https://schema.org/worksFor"></see></summary>
    let worksFor = _prefix "worksFor"
    /// <summary>
    /// The lowest value allowed in this rating system.
    /// <see href="https://schema.org/worstRating"></see></summary>
    let worstRating = _prefix "worstRating"
    /// <summary>
    /// An XPath, e.g. of a [[SpeakableSpecification]] or [[WebPageElement]]. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
    /// <see href="https://schema.org/xpath"></see></summary>
    let xpath = _prefix "xpath"
    /// <summary>
    /// The year an [[Accommodation]] was constructed. This corresponds to the [YearBuilt field in RESO](https://ddwiki.reso.org/display/DDW17/YearBuilt+Field).
    /// <see href="https://schema.org/yearBuilt"></see></summary>
    let yearBuilt = _prefix "yearBuilt"
    /// <summary>
    /// The size of the business in annual revenue.
    /// <see href="https://schema.org/yearlyRevenue"></see></summary>
    let yearlyRevenue = _prefix "yearlyRevenue"
    /// <summary>
    /// The age of the business.
    /// <see href="https://schema.org/yearsInOperation"></see></summary>
    let yearsInOperation = _prefix "yearsInOperation"
