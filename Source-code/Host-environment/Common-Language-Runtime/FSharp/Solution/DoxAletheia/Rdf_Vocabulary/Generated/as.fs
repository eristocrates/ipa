namespace https.www.w3.org.ns.activitystreams.hash

open DoxAletheia.Rdf_Vocabulary

module as_ =
    let _namespace_name = "https://www.w3.org/ns/activitystreams#"

    /// <summary>
    /// A rdf:List variant for Objects and Links
    /// <see href="https://www.w3.org/ns/activitystreams#OrderedItems"></see></summary>
    let OrderedItems =
        Namespaced_IRI.parse _namespace_name "OrderedItems" |> NamespacedName

    /// <summary>
    /// Actor accepts the Object
    /// <see href="https://www.w3.org/ns/activitystreams#Accept"></see></summary>
    let Accept = Namespaced_IRI.parse _namespace_name "Accept" |> NamespacedName
    /// <summary>
    /// An Object representing some form of Action that has been taken
    /// <see href="https://www.w3.org/ns/activitystreams#Activity"></see></summary>
    let Activity = Namespaced_IRI.parse _namespace_name "Activity" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#Object"></see>
    /// </summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName
    /// <summary>
    /// To Add an Object or Link to Something
    /// <see href="https://www.w3.org/ns/activitystreams#Add"></see></summary>
    let Add = Namespaced_IRI.parse _namespace_name "Add" |> NamespacedName
    /// <summary>
    /// Actor announces the object to the target
    /// <see href="https://www.w3.org/ns/activitystreams#Announce"></see></summary>
    let Announce = Namespaced_IRI.parse _namespace_name "Announce" |> NamespacedName

    /// <summary>
    /// Represents a software application of any sort
    /// <see href="https://www.w3.org/ns/activitystreams#Application"></see></summary>
    let Application =
        Namespaced_IRI.parse _namespace_name "Application" |> NamespacedName

    /// <summary>
    /// To Arrive Somewhere (can be used, for instance, to indicate that a particular entity is currently located somewhere, e.g. a "check-in")
    /// <see href="https://www.w3.org/ns/activitystreams#Arrive"></see></summary>
    let Arrive = Namespaced_IRI.parse _namespace_name "Arrive" |> NamespacedName

    /// <summary>
    /// An Activity that has no direct object
    /// <see href="https://www.w3.org/ns/activitystreams#IntransitiveActivity"></see></summary>
    let IntransitiveActivity =
        Namespaced_IRI.parse _namespace_name "IntransitiveActivity" |> NamespacedName

    /// <summary>
    /// A written work. Typically several paragraphs long. For example, a blog post or a news article.
    /// <see href="https://www.w3.org/ns/activitystreams#Article"></see></summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName
    /// <summary>
    /// An audio file
    /// <see href="https://www.w3.org/ns/activitystreams#Audio"></see></summary>
    let Audio = Namespaced_IRI.parse _namespace_name "Audio" |> NamespacedName
    /// <summary>
    /// Represents a digital document/file of any sort
    /// <see href="https://www.w3.org/ns/activitystreams#Document"></see></summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#Block"></see>
    /// </summary>
    let Block = Namespaced_IRI.parse _namespace_name "Block" |> NamespacedName
    /// <summary>
    /// Actor is ignoring the Object
    /// <see href="https://www.w3.org/ns/activitystreams#Ignore"></see></summary>
    let Ignore = Namespaced_IRI.parse _namespace_name "Ignore" |> NamespacedName
    /// <summary>
    /// An ordered or unordered collection of Objects or Links
    /// <see href="https://www.w3.org/ns/activitystreams#Collection"></see></summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    /// A subset of items from a Collection
    /// <see href="https://www.w3.org/ns/activitystreams#CollectionPage"></see></summary>
    let CollectionPage =
        Namespaced_IRI.parse _namespace_name "CollectionPage" |> NamespacedName

    /// <summary>
    /// To Create Something
    /// <see href="https://www.w3.org/ns/activitystreams#Create"></see></summary>
    let Create = Namespaced_IRI.parse _namespace_name "Create" |> NamespacedName
    /// <summary>
    /// To Delete Something
    /// <see href="https://www.w3.org/ns/activitystreams#Delete"></see></summary>
    let Delete = Namespaced_IRI.parse _namespace_name "Delete" |> NamespacedName
    /// <summary>
    /// The actor dislikes the object
    /// <see href="https://www.w3.org/ns/activitystreams#Dislike"></see></summary>
    let Dislike = Namespaced_IRI.parse _namespace_name "Dislike" |> NamespacedName
    /// <summary>
    /// An Event of any kind
    /// <see href="https://www.w3.org/ns/activitystreams#Event"></see></summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    /// To flag something (e.g. flag as inappropriate, flag as spam, etc)
    /// <see href="https://www.w3.org/ns/activitystreams#Flag"></see></summary>
    let Flag = Namespaced_IRI.parse _namespace_name "Flag" |> NamespacedName
    /// <summary>
    /// To Express Interest in Something
    /// <see href="https://www.w3.org/ns/activitystreams#Follow"></see></summary>
    let Follow = Namespaced_IRI.parse _namespace_name "Follow" |> NamespacedName
    /// <summary>
    /// A Group of any kind.
    /// <see href="https://www.w3.org/ns/activitystreams#Group"></see></summary>
    let Group = Namespaced_IRI.parse _namespace_name "Group" |> NamespacedName
    /// <summary>
    /// An Image file
    /// <see href="https://www.w3.org/ns/activitystreams#Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#object"></see>
    /// </summary>
    let object = Namespaced_IRI.parse _namespace_name "object" |> NamespacedName
    /// <summary>
    /// To invite someone or something to something
    /// <see href="https://www.w3.org/ns/activitystreams#Invite"></see></summary>
    let Invite = Namespaced_IRI.parse _namespace_name "Invite" |> NamespacedName
    /// <summary>
    /// To Offer something to someone or something
    /// <see href="https://www.w3.org/ns/activitystreams#Offer"></see></summary>
    let Offer = Namespaced_IRI.parse _namespace_name "Offer" |> NamespacedName
    /// <summary>
    /// To Join Something
    /// <see href="https://www.w3.org/ns/activitystreams#Join"></see></summary>
    let Join = Namespaced_IRI.parse _namespace_name "Join" |> NamespacedName
    /// <summary>
    /// To Leave Something
    /// <see href="https://www.w3.org/ns/activitystreams#Leave"></see></summary>
    let Leave = Namespaced_IRI.parse _namespace_name "Leave" |> NamespacedName
    /// <summary>
    /// To Like Something
    /// <see href="https://www.w3.org/ns/activitystreams#Like"></see></summary>
    let Like = Namespaced_IRI.parse _namespace_name "Like" |> NamespacedName
    /// <summary>
    /// Represents a qualified reference to another resource. Patterned after the RFC5988 Web Linking Model
    /// <see href="https://www.w3.org/ns/activitystreams#Link"></see></summary>
    let Link = Namespaced_IRI.parse _namespace_name "Link" |> NamespacedName
    /// <summary>
    /// The actor listened to the object
    /// <see href="https://www.w3.org/ns/activitystreams#Listen"></see></summary>
    let Listen = Namespaced_IRI.parse _namespace_name "Listen" |> NamespacedName
    /// <summary>
    /// A specialized Link that represents an @mention
    /// <see href="https://www.w3.org/ns/activitystreams#Mention"></see></summary>
    let Mention = Namespaced_IRI.parse _namespace_name "Mention" |> NamespacedName
    /// <summary>
    /// The actor is moving the object. The target specifies where the object is moving to. The origin specifies where the object is moving from.
    /// <see href="https://www.w3.org/ns/activitystreams#Move"></see></summary>
    let Move = Namespaced_IRI.parse _namespace_name "Move" |> NamespacedName
    /// <summary>
    /// A Short note, typically less than a single paragraph. A "tweet" is an example, or a "status update"
    /// <see href="https://www.w3.org/ns/activitystreams#Note"></see></summary>
    let Note = Namespaced_IRI.parse _namespace_name "Note" |> NamespacedName

    /// <summary>
    /// A variation of Collection in which items are strictly ordered
    /// <see href="https://www.w3.org/ns/activitystreams#OrderedCollection"></see></summary>
    let OrderedCollection =
        Namespaced_IRI.parse _namespace_name "OrderedCollection" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#items"></see>
    /// </summary>
    let items = Namespaced_IRI.parse _namespace_name "items" |> NamespacedName

    /// <summary>
    /// An ordered subset of items from an OrderedCollection
    /// <see href="https://www.w3.org/ns/activitystreams#OrderedCollectionPage"></see></summary>
    let OrderedCollectionPage =
        Namespaced_IRI.parse _namespace_name "OrderedCollectionPage" |> NamespacedName

    /// <summary>
    /// An Organization
    /// <see href="https://www.w3.org/ns/activitystreams#Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    /// A Web Page
    /// <see href="https://www.w3.org/ns/activitystreams#Page"></see></summary>
    let Page = Namespaced_IRI.parse _namespace_name "Page" |> NamespacedName
    /// <summary>
    /// A Person
    /// <see href="https://www.w3.org/ns/activitystreams#Person"></see></summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName
    /// <summary>
    /// A physical or logical location
    /// <see href="https://www.w3.org/ns/activitystreams#Place"></see></summary>
    let Place = Namespaced_IRI.parse _namespace_name "Place" |> NamespacedName
    /// <summary>
    /// A Profile Document
    /// <see href="https://www.w3.org/ns/activitystreams#Profile"></see></summary>
    let Profile = Namespaced_IRI.parse _namespace_name "Profile" |> NamespacedName
    /// <summary>
    /// A question of any sort.
    /// <see href="https://www.w3.org/ns/activitystreams#Question"></see></summary>
    let Question = Namespaced_IRI.parse _namespace_name "Question" |> NamespacedName
    /// <summary>
    /// The actor read the object
    /// <see href="https://www.w3.org/ns/activitystreams#Read"></see></summary>
    let Read = Namespaced_IRI.parse _namespace_name "Read" |> NamespacedName
    /// <summary>
    /// Actor rejects the Object
    /// <see href="https://www.w3.org/ns/activitystreams#Reject"></see></summary>
    let Reject = Namespaced_IRI.parse _namespace_name "Reject" |> NamespacedName

    /// <summary>
    /// Represents a Social Graph relationship between two Individuals (indicated by the 'a' and 'b' properties)
    /// <see href="https://www.w3.org/ns/activitystreams#Relationship"></see></summary>
    let Relationship =
        Namespaced_IRI.parse _namespace_name "Relationship" |> NamespacedName

    /// <summary>
    /// To Remove Something
    /// <see href="https://www.w3.org/ns/activitystreams#Remove"></see></summary>
    let Remove = Namespaced_IRI.parse _namespace_name "Remove" |> NamespacedName
    /// <summary>
    /// A service provided by some entity
    /// <see href="https://www.w3.org/ns/activitystreams#Service"></see></summary>
    let Service = Namespaced_IRI.parse _namespace_name "Service" |> NamespacedName

    /// <summary>
    /// Actor tentatively accepts the Object
    /// <see href="https://www.w3.org/ns/activitystreams#TentativeAccept"></see></summary>
    let TentativeAccept =
        Namespaced_IRI.parse _namespace_name "TentativeAccept" |> NamespacedName

    /// <summary>
    /// Actor tentatively rejects the object
    /// <see href="https://www.w3.org/ns/activitystreams#TentativeReject"></see></summary>
    let TentativeReject =
        Namespaced_IRI.parse _namespace_name "TentativeReject" |> NamespacedName

    /// <summary>
    /// A placeholder for a deleted object
    /// <see href="https://www.w3.org/ns/activitystreams#Tombstone"></see></summary>
    let Tombstone = Namespaced_IRI.parse _namespace_name "Tombstone" |> NamespacedName
    /// <summary>
    /// The actor is traveling to the target. The origin specifies where the actor is traveling from.
    /// <see href="https://www.w3.org/ns/activitystreams#Travel"></see></summary>
    let Travel = Namespaced_IRI.parse _namespace_name "Travel" |> NamespacedName
    /// <summary>
    /// To Undo Something. This would typically be used to indicate that a previous Activity has been undone.
    /// <see href="https://www.w3.org/ns/activitystreams#Undo"></see></summary>
    let Undo = Namespaced_IRI.parse _namespace_name "Undo" |> NamespacedName
    /// <summary>
    /// To Update/Modify Something
    /// <see href="https://www.w3.org/ns/activitystreams#Update"></see></summary>
    let Update = Namespaced_IRI.parse _namespace_name "Update" |> NamespacedName
    /// <summary>
    /// A Video document of any kind.
    /// <see href="https://www.w3.org/ns/activitystreams#Video"></see></summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName
    /// <summary>
    /// The actor viewed the object
    /// <see href="https://www.w3.org/ns/activitystreams#View"></see></summary>
    let View = Namespaced_IRI.parse _namespace_name "View" |> NamespacedName
    /// <summary>
    /// Specifies the accuracy around the point established by the longitude and latitude
    /// <see href="https://www.w3.org/ns/activitystreams#accuracy"></see></summary>
    let accuracy = Namespaced_IRI.parse _namespace_name "accuracy" |> NamespacedName
    /// <summary>
    /// Subproperty of as:attributedTo that identifies the primary actor
    /// <see href="https://www.w3.org/ns/activitystreams#actor"></see></summary>
    let actor = Namespaced_IRI.parse _namespace_name "actor" |> NamespacedName

    /// <summary>
    /// Identifies an entity to which an object is attributed
    /// <see href="https://www.w3.org/ns/activitystreams#attributedTo"></see></summary>
    let attributedTo =
        Namespaced_IRI.parse _namespace_name "attributedTo" |> NamespacedName

    /// <summary>
    /// The altitude of a place
    /// <see href="https://www.w3.org/ns/activitystreams#altitude"></see></summary>
    let altitude = Namespaced_IRI.parse _namespace_name "altitude" |> NamespacedName
    /// <summary>
    /// Describes a possible inclusive answer or option for a question.
    /// <see href="https://www.w3.org/ns/activitystreams#anyOf"></see></summary>
    let anyOf = Namespaced_IRI.parse _namespace_name "anyOf" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#attachment"></see>
    /// </summary>
    let attachment = Namespaced_IRI.parse _namespace_name "attachment" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#attachments"></see>
    /// </summary>
    let attachments =
        Namespaced_IRI.parse _namespace_name "attachments" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#audience"></see>
    /// </summary>
    let audience = Namespaced_IRI.parse _namespace_name "audience" |> NamespacedName
    /// <summary>
    /// Identifies the author of an object. Deprecated. Use as:attributedTo instead
    /// <see href="https://www.w3.org/ns/activitystreams#author"></see></summary>
    let author = Namespaced_IRI.parse _namespace_name "author" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#bcc"></see>
    /// </summary>
    let bcc = Namespaced_IRI.parse _namespace_name "bcc" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#bto"></see>
    /// </summary>
    let bto = Namespaced_IRI.parse _namespace_name "bto" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#cc"></see>
    /// </summary>
    let cc = Namespaced_IRI.parse _namespace_name "cc" |> NamespacedName
    /// <summary>
    /// The content of the object.
    /// <see href="https://www.w3.org/ns/activitystreams#content"></see></summary>
    let content = Namespaced_IRI.parse _namespace_name "content" |> NamespacedName
    /// <summary>
    /// Specifies the context within which an object exists or an activity was performed
    /// <see href="https://www.w3.org/ns/activitystreams#context"></see></summary>
    let context = Namespaced_IRI.parse _namespace_name "context" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#current"></see>
    /// </summary>
    let current = Namespaced_IRI.parse _namespace_name "current" |> NamespacedName
    /// <summary>
    /// Specifies the date and time the object was deleted
    /// <see href="https://www.w3.org/ns/activitystreams#deleted"></see></summary>
    let deleted = Namespaced_IRI.parse _namespace_name "deleted" |> NamespacedName
    /// <summary>
    /// On a Profile object, describes the object described by the profile
    /// <see href="https://www.w3.org/ns/activitystreams#describes"></see></summary>
    let describes = Namespaced_IRI.parse _namespace_name "describes" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#downstreamDuplicates"></see>
    /// </summary>
    let downstreamDuplicates =
        Namespaced_IRI.parse _namespace_name "downstreamDuplicates" |> NamespacedName

    /// <summary>
    /// The duration of the object
    /// <see href="https://www.w3.org/ns/activitystreams#duration"></see></summary>
    let duration = Namespaced_IRI.parse _namespace_name "duration" |> NamespacedName
    /// <summary>
    /// The ending time of the object
    /// <see href="https://www.w3.org/ns/activitystreams#endTime"></see></summary>
    let endTime = Namespaced_IRI.parse _namespace_name "endTime" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#first"></see>
    /// </summary>
    let first = Namespaced_IRI.parse _namespace_name "first" |> NamespacedName
    /// <summary>
    /// On a Tombstone object, describes the former type of the deleted object
    /// <see href="https://www.w3.org/ns/activitystreams#formerType"></see></summary>
    let formerType = Namespaced_IRI.parse _namespace_name "formerType" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#generator"></see>
    /// </summary>
    let generator = Namespaced_IRI.parse _namespace_name "generator" |> NamespacedName
    /// <summary>
    /// The display height expressed as device independent pixels
    /// <see href="https://www.w3.org/ns/activitystreams#height"></see></summary>
    let height = Namespaced_IRI.parse _namespace_name "height" |> NamespacedName
    /// <summary>
    /// The target URI of the Link
    /// <see href="https://www.w3.org/ns/activitystreams#href"></see></summary>
    let href = Namespaced_IRI.parse _namespace_name "href" |> NamespacedName
    /// <summary>
    /// A hint about the language of the referenced resource
    /// <see href="https://www.w3.org/ns/activitystreams#hreflang"></see></summary>
    let hreflang = Namespaced_IRI.parse _namespace_name "hreflang" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#icon"></see>
    /// </summary>
    let icon = Namespaced_IRI.parse _namespace_name "icon" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#image"></see>
    /// </summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#inReplyTo"></see>
    /// </summary>
    let inReplyTo = Namespaced_IRI.parse _namespace_name "inReplyTo" |> NamespacedName
    /// <summary>
    /// Indentifies an object used (or to be used) to complete an activity
    /// <see href="https://www.w3.org/ns/activitystreams#instrument"></see></summary>
    let instrument = Namespaced_IRI.parse _namespace_name "instrument" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#last"></see>
    /// </summary>
    let last = Namespaced_IRI.parse _namespace_name "last" |> NamespacedName
    /// <summary>
    /// The latitude
    /// <see href="https://www.w3.org/ns/activitystreams#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#location"></see>
    /// </summary>
    let location = Namespaced_IRI.parse _namespace_name "location" |> NamespacedName
    /// <summary>
    /// The longitude
    /// <see href="https://www.w3.org/ns/activitystreams#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName
    /// <summary>
    /// The MIME Media Type
    /// <see href="https://www.w3.org/ns/activitystreams#mediaType"></see></summary>
    let mediaType = Namespaced_IRI.parse _namespace_name "mediaType" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#next"></see>
    /// </summary>
    let next = Namespaced_IRI.parse _namespace_name "next" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#objectType"></see>
    /// </summary>
    let objectType = Namespaced_IRI.parse _namespace_name "objectType" |> NamespacedName
    /// <summary>
    /// Describes a possible exclusive answer or option for a question.
    /// <see href="https://www.w3.org/ns/activitystreams#oneOf"></see></summary>
    let oneOf = Namespaced_IRI.parse _namespace_name "oneOf" |> NamespacedName
    /// <summary>
    /// For certain activities, specifies the entity from which the action is directed.
    /// <see href="https://www.w3.org/ns/activitystreams#origin"></see></summary>
    let origin = Namespaced_IRI.parse _namespace_name "origin" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#partOf"></see>
    /// </summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#prev"></see>
    /// </summary>
    let prev = Namespaced_IRI.parse _namespace_name "prev" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#preview"></see>
    /// </summary>
    let preview = Namespaced_IRI.parse _namespace_name "preview" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#provider"></see>
    /// </summary>
    let provider = Namespaced_IRI.parse _namespace_name "provider" |> NamespacedName
    /// <summary>
    /// Specifies the date and time the object was published
    /// <see href="https://www.w3.org/ns/activitystreams#published"></see></summary>
    let published = Namespaced_IRI.parse _namespace_name "published" |> NamespacedName
    /// <summary>
    /// Specifies a radius around the point established by the longitude and latitude
    /// <see href="https://www.w3.org/ns/activitystreams#radius"></see></summary>
    let radius = Namespaced_IRI.parse _namespace_name "radius" |> NamespacedName
    /// <summary>
    /// A numeric rating (&gt;= 0.0, &lt;= 5.0) for the object
    /// <see href="https://www.w3.org/ns/activitystreams#rating"></see></summary>
    let rating = Namespaced_IRI.parse _namespace_name "rating" |> NamespacedName
    /// <summary>
    /// The RFC 5988 or HTML5 Link Relation associated with the Link
    /// <see href="https://www.w3.org/ns/activitystreams#rel"></see></summary>
    let rel = Namespaced_IRI.parse _namespace_name "rel" |> NamespacedName

    /// <summary>
    /// On a Relationship object, describes the type of relationship
    /// <see href="https://www.w3.org/ns/activitystreams#relationship"></see></summary>
    let relationship =
        Namespaced_IRI.parse _namespace_name "relationship" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#replies"></see>
    /// </summary>
    let replies = Namespaced_IRI.parse _namespace_name "replies" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#result"></see>
    /// </summary>
    let result = Namespaced_IRI.parse _namespace_name "result" |> NamespacedName
    /// <summary>
    /// In a strictly ordered logical collection, specifies the index position of the first item in the items list
    /// <see href="https://www.w3.org/ns/activitystreams#startIndex"></see></summary>
    let startIndex = Namespaced_IRI.parse _namespace_name "startIndex" |> NamespacedName
    /// <summary>
    /// The starting time of the object
    /// <see href="https://www.w3.org/ns/activitystreams#startTime"></see></summary>
    let startTime = Namespaced_IRI.parse _namespace_name "startTime" |> NamespacedName
    /// <summary>
    /// On a Relationship object, identifies the subject. e.g. when saying "John is connected to Sally", 'subject' refers to 'John'
    /// <see href="https://www.w3.org/ns/activitystreams#subject"></see></summary>
    let subject = Namespaced_IRI.parse _namespace_name "subject" |> NamespacedName
    /// <summary>
    /// A short summary of the object
    /// <see href="https://www.w3.org/ns/activitystreams#summary"></see></summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#tag"></see>
    /// </summary>
    let tag = Namespaced_IRI.parse _namespace_name "tag" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#tags"></see>
    /// </summary>
    let tags = Namespaced_IRI.parse _namespace_name "tags" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#target"></see>
    /// </summary>
    let target = Namespaced_IRI.parse _namespace_name "target" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#to"></see>
    /// </summary>
    let to_ = Namespaced_IRI.parse _namespace_name "to" |> NamespacedName
    /// <summary>
    /// The total number of items in a logical collection
    /// <see href="https://www.w3.org/ns/activitystreams#totalItems"></see></summary>
    let totalItems = Namespaced_IRI.parse _namespace_name "totalItems" |> NamespacedName
    /// <summary>
    /// Identifies the unit of measurement used by the radius, altitude and accuracy properties. The value can be expressed either as one of a set of predefined units or as a well-known common URI that identifies units.
    /// <see href="https://www.w3.org/ns/activitystreams#units"></see></summary>
    let units = Namespaced_IRI.parse _namespace_name "units" |> NamespacedName
    /// <summary>
    /// Specifies when the object was last updated
    /// <see href="https://www.w3.org/ns/activitystreams#updated"></see></summary>
    let updated = Namespaced_IRI.parse _namespace_name "updated" |> NamespacedName

    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#upstreamDuplicates"></see>
    /// </summary>
    let upstreamDuplicates =
        Namespaced_IRI.parse _namespace_name "upstreamDuplicates" |> NamespacedName

    /// <summary>
    /// Specifies a link to a specific representation of the Object
    /// <see href="https://www.w3.org/ns/activitystreams#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    ///   <see href="https://www.w3.org/ns/activitystreams#verb"></see>
    /// </summary>
    let verb = Namespaced_IRI.parse _namespace_name "verb" |> NamespacedName
    /// <summary>
    /// Specifies the preferred display width of the content, expressed in terms of device independent pixels.
    /// <see href="https://www.w3.org/ns/activitystreams#width"></see></summary>
    let width = Namespaced_IRI.parse _namespace_name "width" |> NamespacedName
