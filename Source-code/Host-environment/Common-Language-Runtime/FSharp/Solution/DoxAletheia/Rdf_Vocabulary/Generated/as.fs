namespace https.www.w3.org.ns.activitystreams.hash

open DoxAletheia

module as_ =
    let _namespace_name = "https://www.w3.org/ns/activitystreams#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A rdf:List variant for Objects and Links
    /// <see href="https://www.w3.org/ns/activitystreams#OrderedItems"></see></summary>
    let OrderedItems = _prefix "OrderedItems"
    /// <summary>
    /// Actor accepts the Object
    /// <see href="https://www.w3.org/ns/activitystreams#Accept"></see></summary>
    let Accept = _prefix "Accept"
    /// <summary>
    /// An Object representing some form of Action that has been taken
    /// <see href="https://www.w3.org/ns/activitystreams#Activity"></see></summary>
    let Activity = _prefix "Activity"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#Object"></see>
    /// </summary>
    let Object = _prefix "Object"
    /// <summary>
    /// To Add an Object or Link to Something
    /// <see href="https://www.w3.org/ns/activitystreams#Add"></see></summary>
    let Add = _prefix "Add"
    /// <summary>
    /// Actor announces the object to the target
    /// <see href="https://www.w3.org/ns/activitystreams#Announce"></see></summary>
    let Announce = _prefix "Announce"
    /// <summary>
    /// Represents a software application of any sort
    /// <see href="https://www.w3.org/ns/activitystreams#Application"></see></summary>
    let Application = _prefix "Application"
    /// <summary>
    /// To Arrive Somewhere (can be used, for instance, to indicate that a particular entity is currently located somewhere, e.g. a "check-in")
    /// <see href="https://www.w3.org/ns/activitystreams#Arrive"></see></summary>
    let Arrive = _prefix "Arrive"
    /// <summary>
    /// An Activity that has no direct object
    /// <see href="https://www.w3.org/ns/activitystreams#IntransitiveActivity"></see></summary>
    let IntransitiveActivity = _prefix "IntransitiveActivity"
    /// <summary>
    /// A written work. Typically several paragraphs long. For example, a blog post or a news article.
    /// <see href="https://www.w3.org/ns/activitystreams#Article"></see></summary>
    let Article = _prefix "Article"
    /// <summary>
    /// An audio file
    /// <see href="https://www.w3.org/ns/activitystreams#Audio"></see></summary>
    let Audio = _prefix "Audio"
    /// <summary>
    /// Represents a digital document/file of any sort
    /// <see href="https://www.w3.org/ns/activitystreams#Document"></see></summary>
    let Document = _prefix "Document"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#Block"></see>
    /// </summary>
    let Block = _prefix "Block"
    /// <summary>
    /// Actor is ignoring the Object
    /// <see href="https://www.w3.org/ns/activitystreams#Ignore"></see></summary>
    let Ignore = _prefix "Ignore"
    /// <summary>
    /// An ordered or unordered collection of Objects or Links
    /// <see href="https://www.w3.org/ns/activitystreams#Collection"></see></summary>
    let Collection = _prefix "Collection"
    /// <summary>
    /// A subset of items from a Collection
    /// <see href="https://www.w3.org/ns/activitystreams#CollectionPage"></see></summary>
    let CollectionPage = _prefix "CollectionPage"
    /// <summary>
    /// To Create Something
    /// <see href="https://www.w3.org/ns/activitystreams#Create"></see></summary>
    let Create = _prefix "Create"
    /// <summary>
    /// To Delete Something
    /// <see href="https://www.w3.org/ns/activitystreams#Delete"></see></summary>
    let Delete = _prefix "Delete"
    /// <summary>
    /// The actor dislikes the object
    /// <see href="https://www.w3.org/ns/activitystreams#Dislike"></see></summary>
    let Dislike = _prefix "Dislike"
    /// <summary>
    /// An Event of any kind
    /// <see href="https://www.w3.org/ns/activitystreams#Event"></see></summary>
    let Event = _prefix "Event"
    /// <summary>
    /// To flag something (e.g. flag as inappropriate, flag as spam, etc)
    /// <see href="https://www.w3.org/ns/activitystreams#Flag"></see></summary>
    let Flag = _prefix "Flag"
    /// <summary>
    /// To Express Interest in Something
    /// <see href="https://www.w3.org/ns/activitystreams#Follow"></see></summary>
    let Follow = _prefix "Follow"
    /// <summary>
    /// A Group of any kind.
    /// <see href="https://www.w3.org/ns/activitystreams#Group"></see></summary>
    let Group = _prefix "Group"
    /// <summary>
    /// An Image file
    /// <see href="https://www.w3.org/ns/activitystreams#Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#object"></see>
    /// </summary>
    let object = _prefix "object"
    /// <summary>
    /// To invite someone or something to something
    /// <see href="https://www.w3.org/ns/activitystreams#Invite"></see></summary>
    let Invite = _prefix "Invite"
    /// <summary>
    /// To Offer something to someone or something
    /// <see href="https://www.w3.org/ns/activitystreams#Offer"></see></summary>
    let Offer = _prefix "Offer"
    /// <summary>
    /// To Join Something
    /// <see href="https://www.w3.org/ns/activitystreams#Join"></see></summary>
    let Join = _prefix "Join"
    /// <summary>
    /// To Leave Something
    /// <see href="https://www.w3.org/ns/activitystreams#Leave"></see></summary>
    let Leave = _prefix "Leave"
    /// <summary>
    /// To Like Something
    /// <see href="https://www.w3.org/ns/activitystreams#Like"></see></summary>
    let Like = _prefix "Like"
    /// <summary>
    /// Represents a qualified reference to another resource. Patterned after the RFC5988 Web Linking Model
    /// <see href="https://www.w3.org/ns/activitystreams#Link"></see></summary>
    let Link = _prefix "Link"
    /// <summary>
    /// The actor listened to the object
    /// <see href="https://www.w3.org/ns/activitystreams#Listen"></see></summary>
    let Listen = _prefix "Listen"
    /// <summary>
    /// A specialized Link that represents an @mention
    /// <see href="https://www.w3.org/ns/activitystreams#Mention"></see></summary>
    let Mention = _prefix "Mention"
    /// <summary>
    /// The actor is moving the object. The target specifies where the object is moving to. The origin specifies where the object is moving from.
    /// <see href="https://www.w3.org/ns/activitystreams#Move"></see></summary>
    let Move = _prefix "Move"
    /// <summary>
    /// A Short note, typically less than a single paragraph. A "tweet" is an example, or a "status update"
    /// <see href="https://www.w3.org/ns/activitystreams#Note"></see></summary>
    let Note = _prefix "Note"
    /// <summary>
    /// A variation of Collection in which items are strictly ordered
    /// <see href="https://www.w3.org/ns/activitystreams#OrderedCollection"></see></summary>
    let OrderedCollection = _prefix "OrderedCollection"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#items"></see>
    /// </summary>
    let items = _prefix "items"
    /// <summary>
    /// An ordered subset of items from an OrderedCollection
    /// <see href="https://www.w3.org/ns/activitystreams#OrderedCollectionPage"></see></summary>
    let OrderedCollectionPage = _prefix "OrderedCollectionPage"
    /// <summary>
    /// An Organization
    /// <see href="https://www.w3.org/ns/activitystreams#Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    /// A Web Page
    /// <see href="https://www.w3.org/ns/activitystreams#Page"></see></summary>
    let Page = _prefix "Page"
    /// <summary>
    /// A Person
    /// <see href="https://www.w3.org/ns/activitystreams#Person"></see></summary>
    let Person = _prefix "Person"
    /// <summary>
    /// A physical or logical location
    /// <see href="https://www.w3.org/ns/activitystreams#Place"></see></summary>
    let Place = _prefix "Place"
    /// <summary>
    /// A Profile Document
    /// <see href="https://www.w3.org/ns/activitystreams#Profile"></see></summary>
    let Profile = _prefix "Profile"
    /// <summary>
    /// A question of any sort.
    /// <see href="https://www.w3.org/ns/activitystreams#Question"></see></summary>
    let Question = _prefix "Question"
    /// <summary>
    /// The actor read the object
    /// <see href="https://www.w3.org/ns/activitystreams#Read"></see></summary>
    let Read = _prefix "Read"
    /// <summary>
    /// Actor rejects the Object
    /// <see href="https://www.w3.org/ns/activitystreams#Reject"></see></summary>
    let Reject = _prefix "Reject"
    /// <summary>
    /// Represents a Social Graph relationship between two Individuals (indicated by the 'a' and 'b' properties)
    /// <see href="https://www.w3.org/ns/activitystreams#Relationship"></see></summary>
    let Relationship = _prefix "Relationship"
    /// <summary>
    /// To Remove Something
    /// <see href="https://www.w3.org/ns/activitystreams#Remove"></see></summary>
    let Remove = _prefix "Remove"
    /// <summary>
    /// A service provided by some entity
    /// <see href="https://www.w3.org/ns/activitystreams#Service"></see></summary>
    let Service = _prefix "Service"
    /// <summary>
    /// Actor tentatively accepts the Object
    /// <see href="https://www.w3.org/ns/activitystreams#TentativeAccept"></see></summary>
    let TentativeAccept = _prefix "TentativeAccept"
    /// <summary>
    /// Actor tentatively rejects the object
    /// <see href="https://www.w3.org/ns/activitystreams#TentativeReject"></see></summary>
    let TentativeReject = _prefix "TentativeReject"
    /// <summary>
    /// A placeholder for a deleted object
    /// <see href="https://www.w3.org/ns/activitystreams#Tombstone"></see></summary>
    let Tombstone = _prefix "Tombstone"
    /// <summary>
    /// The actor is traveling to the target. The origin specifies where the actor is traveling from.
    /// <see href="https://www.w3.org/ns/activitystreams#Travel"></see></summary>
    let Travel = _prefix "Travel"
    /// <summary>
    /// To Undo Something. This would typically be used to indicate that a previous Activity has been undone.
    /// <see href="https://www.w3.org/ns/activitystreams#Undo"></see></summary>
    let Undo = _prefix "Undo"
    /// <summary>
    /// To Update/Modify Something
    /// <see href="https://www.w3.org/ns/activitystreams#Update"></see></summary>
    let Update = _prefix "Update"
    /// <summary>
    /// A Video document of any kind.
    /// <see href="https://www.w3.org/ns/activitystreams#Video"></see></summary>
    let Video = _prefix "Video"
    /// <summary>
    /// The actor viewed the object
    /// <see href="https://www.w3.org/ns/activitystreams#View"></see></summary>
    let View = _prefix "View"
    /// <summary>
    /// Specifies the accuracy around the point established by the longitude and latitude
    /// <see href="https://www.w3.org/ns/activitystreams#accuracy"></see></summary>
    let accuracy = _prefix "accuracy"
    /// <summary>
    /// Subproperty of as:attributedTo that identifies the primary actor
    /// <see href="https://www.w3.org/ns/activitystreams#actor"></see></summary>
    let actor = _prefix "actor"
    /// <summary>
    /// Identifies an entity to which an object is attributed
    /// <see href="https://www.w3.org/ns/activitystreams#attributedTo"></see></summary>
    let attributedTo = _prefix "attributedTo"
    /// <summary>
    /// The altitude of a place
    /// <see href="https://www.w3.org/ns/activitystreams#altitude"></see></summary>
    let altitude = _prefix "altitude"
    /// <summary>
    /// Describes a possible inclusive answer or option for a question.
    /// <see href="https://www.w3.org/ns/activitystreams#anyOf"></see></summary>
    let anyOf = _prefix "anyOf"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#attachment"></see>
    /// </summary>
    let attachment = _prefix "attachment"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#attachments"></see>
    /// </summary>
    let attachments = _prefix "attachments"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#audience"></see>
    /// </summary>
    let audience = _prefix "audience"
    /// <summary>
    /// Identifies the author of an object. Deprecated. Use as:attributedTo instead
    /// <see href="https://www.w3.org/ns/activitystreams#author"></see></summary>
    let author = _prefix "author"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#bcc"></see>
    /// </summary>
    let bcc = _prefix "bcc"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#bto"></see>
    /// </summary>
    let bto = _prefix "bto"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#cc"></see>
    /// </summary>
    let cc = _prefix "cc"
    /// <summary>
    /// The content of the object.
    /// <see href="https://www.w3.org/ns/activitystreams#content"></see></summary>
    let content = _prefix "content"
    /// <summary>
    /// Specifies the context within which an object exists or an activity was performed
    /// <see href="https://www.w3.org/ns/activitystreams#context"></see></summary>
    let context = _prefix "context"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#current"></see>
    /// </summary>
    let current = _prefix "current"
    /// <summary>
    /// Specifies the date and time the object was deleted
    /// <see href="https://www.w3.org/ns/activitystreams#deleted"></see></summary>
    let deleted = _prefix "deleted"
    /// <summary>
    /// On a Profile object, describes the object described by the profile
    /// <see href="https://www.w3.org/ns/activitystreams#describes"></see></summary>
    let describes = _prefix "describes"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#downstreamDuplicates"></see>
    /// </summary>
    let downstreamDuplicates = _prefix "downstreamDuplicates"
    /// <summary>
    /// The duration of the object
    /// <see href="https://www.w3.org/ns/activitystreams#duration"></see></summary>
    let duration = _prefix "duration"
    /// <summary>
    /// The ending time of the object
    /// <see href="https://www.w3.org/ns/activitystreams#endTime"></see></summary>
    let endTime = _prefix "endTime"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#first"></see>
    /// </summary>
    let first = _prefix "first"
    /// <summary>
    /// On a Tombstone object, describes the former type of the deleted object
    /// <see href="https://www.w3.org/ns/activitystreams#formerType"></see></summary>
    let formerType = _prefix "formerType"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#generator"></see>
    /// </summary>
    let generator = _prefix "generator"
    /// <summary>
    /// The display height expressed as device independent pixels
    /// <see href="https://www.w3.org/ns/activitystreams#height"></see></summary>
    let height = _prefix "height"
    /// <summary>
    /// The target URI of the Link
    /// <see href="https://www.w3.org/ns/activitystreams#href"></see></summary>
    let href = _prefix "href"
    /// <summary>
    /// A hint about the language of the referenced resource
    /// <see href="https://www.w3.org/ns/activitystreams#hreflang"></see></summary>
    let hreflang = _prefix "hreflang"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#icon"></see>
    /// </summary>
    let icon = _prefix "icon"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#image"></see>
    /// </summary>
    let image = _prefix "image"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#inReplyTo"></see>
    /// </summary>
    let inReplyTo = _prefix "inReplyTo"
    /// <summary>
    /// Indentifies an object used (or to be used) to complete an activity
    /// <see href="https://www.w3.org/ns/activitystreams#instrument"></see></summary>
    let instrument = _prefix "instrument"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#last"></see>
    /// </summary>
    let last = _prefix "last"
    /// <summary>
    /// The latitude
    /// <see href="https://www.w3.org/ns/activitystreams#latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#location"></see>
    /// </summary>
    let location = _prefix "location"
    /// <summary>
    /// The longitude
    /// <see href="https://www.w3.org/ns/activitystreams#longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// The MIME Media Type
    /// <see href="https://www.w3.org/ns/activitystreams#mediaType"></see></summary>
    let mediaType = _prefix "mediaType"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#next"></see>
    /// </summary>
    let next = _prefix "next"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#objectType"></see>
    /// </summary>
    let objectType = _prefix "objectType"
    /// <summary>
    /// Describes a possible exclusive answer or option for a question.
    /// <see href="https://www.w3.org/ns/activitystreams#oneOf"></see></summary>
    let oneOf = _prefix "oneOf"
    /// <summary>
    /// For certain activities, specifies the entity from which the action is directed.
    /// <see href="https://www.w3.org/ns/activitystreams#origin"></see></summary>
    let origin = _prefix "origin"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#partOf"></see>
    /// </summary>
    let partOf = _prefix "partOf"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#prev"></see>
    /// </summary>
    let prev = _prefix "prev"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#preview"></see>
    /// </summary>
    let preview = _prefix "preview"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#provider"></see>
    /// </summary>
    let provider = _prefix "provider"
    /// <summary>
    /// Specifies the date and time the object was published
    /// <see href="https://www.w3.org/ns/activitystreams#published"></see></summary>
    let published = _prefix "published"
    /// <summary>
    /// Specifies a radius around the point established by the longitude and latitude
    /// <see href="https://www.w3.org/ns/activitystreams#radius"></see></summary>
    let radius = _prefix "radius"
    /// <summary>
    /// A numeric rating (&gt;= 0.0, &lt;= 5.0) for the object
    /// <see href="https://www.w3.org/ns/activitystreams#rating"></see></summary>
    let rating = _prefix "rating"
    /// <summary>
    /// The RFC 5988 or HTML5 Link Relation associated with the Link
    /// <see href="https://www.w3.org/ns/activitystreams#rel"></see></summary>
    let rel = _prefix "rel"
    /// <summary>
    /// On a Relationship object, describes the type of relationship
    /// <see href="https://www.w3.org/ns/activitystreams#relationship"></see></summary>
    let relationship = _prefix "relationship"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#replies"></see>
    /// </summary>
    let replies = _prefix "replies"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#result"></see>
    /// </summary>
    let result = _prefix "result"
    /// <summary>
    /// In a strictly ordered logical collection, specifies the index position of the first item in the items list
    /// <see href="https://www.w3.org/ns/activitystreams#startIndex"></see></summary>
    let startIndex = _prefix "startIndex"
    /// <summary>
    /// The starting time of the object
    /// <see href="https://www.w3.org/ns/activitystreams#startTime"></see></summary>
    let startTime = _prefix "startTime"
    /// <summary>
    /// On a Relationship object, identifies the subject. e.g. when saying "John is connected to Sally", 'subject' refers to 'John'
    /// <see href="https://www.w3.org/ns/activitystreams#subject"></see></summary>
    let subject = _prefix "subject"
    /// <summary>
    /// A short summary of the object
    /// <see href="https://www.w3.org/ns/activitystreams#summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#tag"></see>
    /// </summary>
    let tag = _prefix "tag"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#tags"></see>
    /// </summary>
    let tags = _prefix "tags"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#target"></see>
    /// </summary>
    let target = _prefix "target"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#to"></see>
    /// </summary>
    let to_ = _prefix "to"
    /// <summary>
    /// The total number of items in a logical collection
    /// <see href="https://www.w3.org/ns/activitystreams#totalItems"></see></summary>
    let totalItems = _prefix "totalItems"
    /// <summary>
    /// Identifies the unit of measurement used by the radius, altitude and accuracy properties. The value can be expressed either as one of a set of predefined units or as a well-known common URI that identifies units.
    /// <see href="https://www.w3.org/ns/activitystreams#units"></see></summary>
    let units = _prefix "units"
    /// <summary>
    /// Specifies when the object was last updated
    /// <see href="https://www.w3.org/ns/activitystreams#updated"></see></summary>
    let updated = _prefix "updated"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#upstreamDuplicates"></see>
    /// </summary>
    let upstreamDuplicates = _prefix "upstreamDuplicates"
    /// <summary>
    /// Specifies a link to a specific representation of the Object
    /// <see href="https://www.w3.org/ns/activitystreams#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#verb"></see>
    /// </summary>
    let verb = _prefix "verb"
    /// <summary>
    /// Specifies the preferred display width of the content, expressed in terms of device independent pixels.
    /// <see href="https://www.w3.org/ns/activitystreams#width"></see></summary>
    let width = _prefix "width"
