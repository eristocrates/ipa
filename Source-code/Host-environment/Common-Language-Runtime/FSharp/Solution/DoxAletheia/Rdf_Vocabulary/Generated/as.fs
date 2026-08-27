namespace https.www.w3.org.ns.activitystreams.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module as_ =
    let _namespace_iri = Namespace_Iri as_ |> NamespaceIRI
    /// <summary>
    ///   <para>as:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Extended Activity Streams 2.0 Vocabulary"</para>
    /// labels<para>"Activity Streams 2.0"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#">https://www.w3.org/ns/activitystreams#</seealso>
    let _prefix_iri = Prefixed_Name(as_, "") |> PrefixedName
    /// <summary>
    ///   <para>as:Accept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actor accepts the Object"</para>
    /// labels<para>"Accept"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Accept">https://www.w3.org/ns/activitystreams#Accept</seealso>
    let Accept = Prefixed_Name(as_, "Accept") |> PrefixedName
    /// <summary>
    ///   <para>as:Activity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Object representing some form of Action that has been taken"</para>
    /// labels<para>"Activity"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Activity">https://www.w3.org/ns/activitystreams#Activity</seealso>
    let Activity = Prefixed_Name(as_, "Activity") |> PrefixedName
    /// <summary>
    ///   <para>as:Add</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Add an Object or Link to Something"</para>
    /// labels<para>"Add"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Add">https://www.w3.org/ns/activitystreams#Add</seealso>
    let Add = Prefixed_Name(as_, "Add") |> PrefixedName
    /// <summary>
    ///   <para>as:Announce</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actor announces the object to the target"</para>
    /// labels<para>"Announce"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Announce">https://www.w3.org/ns/activitystreams#Announce</seealso>
    let Announce = Prefixed_Name(as_, "Announce") |> PrefixedName
    /// <summary>
    ///   <para>as:Application</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a software application of any sort"</para>
    /// labels<para>"Application"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Application">https://www.w3.org/ns/activitystreams#Application</seealso>
    let Application = Prefixed_Name(as_, "Application") |> PrefixedName
    /// <summary>
    ///   <para>as:Arrive</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Arrive Somewhere (can be used, for instance, to indicate that a particular entity is currently located somewhere, e.g. a "check-in")"</para>
    /// labels<para>"Arrive"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Arrive">https://www.w3.org/ns/activitystreams#Arrive</seealso>
    let Arrive = Prefixed_Name(as_, "Arrive") |> PrefixedName
    /// <summary>
    ///   <para>as:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A written work. Typically several paragraphs long. For example, a blog post or a news article."</para>
    /// labels<para>"Article"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Article">https://www.w3.org/ns/activitystreams#Article</seealso>
    let Article = Prefixed_Name(as_, "Article") |> PrefixedName
    /// <summary>
    ///   <para>as:Audio</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An audio file"</para>
    /// labels<para>"Audio"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Audio">https://www.w3.org/ns/activitystreams#Audio</seealso>
    let Audio = Prefixed_Name(as_, "Audio") |> PrefixedName
    /// <summary>
    ///   <para>as:Block</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Block"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Block">https://www.w3.org/ns/activitystreams#Block</seealso>
    let Block = Prefixed_Name(as_, "Block") |> PrefixedName
    /// <summary>
    ///   <para>as:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ordered or unordered collection of Objects or Links"</para>
    /// labels<para>"Collection"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Collection">https://www.w3.org/ns/activitystreams#Collection</seealso>
    let Collection = Prefixed_Name(as_, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>as:CollectionPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A subset of items from a Collection"</para>
    /// labels<para>"CollectionPage"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#CollectionPage">https://www.w3.org/ns/activitystreams#CollectionPage</seealso>
    let CollectionPage = Prefixed_Name(as_, "CollectionPage") |> PrefixedName
    /// <summary>
    ///   <para>as:Create</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Create Something"</para>
    /// labels<para>"Create"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Create">https://www.w3.org/ns/activitystreams#Create</seealso>
    let Create = Prefixed_Name(as_, "Create") |> PrefixedName
    /// <summary>
    ///   <para>as:Delete</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Delete Something"</para>
    /// labels<para>"Delete"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Delete">https://www.w3.org/ns/activitystreams#Delete</seealso>
    let Delete = Prefixed_Name(as_, "Delete") |> PrefixedName
    /// <summary>
    ///   <para>as:Dislike</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The actor dislikes the object"</para>
    /// labels<para>"Dislike"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Dislike">https://www.w3.org/ns/activitystreams#Dislike</seealso>
    let Dislike = Prefixed_Name(as_, "Dislike") |> PrefixedName
    /// <summary>
    ///   <para>as:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a digital document/file of any sort"</para>
    /// labels<para>"Document"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Document">https://www.w3.org/ns/activitystreams#Document</seealso>
    let Document = Prefixed_Name(as_, "Document") |> PrefixedName
    /// <summary>
    ///   <para>as:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Event of any kind"</para>
    /// labels<para>"Event"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Event">https://www.w3.org/ns/activitystreams#Event</seealso>
    let Event = Prefixed_Name(as_, "Event") |> PrefixedName
    /// <summary>
    ///   <para>as:Flag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To flag something (e.g. flag as inappropriate, flag as spam, etc)"</para>
    /// labels<para>"Flag"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Flag">https://www.w3.org/ns/activitystreams#Flag</seealso>
    let Flag = Prefixed_Name(as_, "Flag") |> PrefixedName
    /// <summary>
    ///   <para>as:Follow</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Express Interest in Something"</para>
    /// labels<para>"Follow"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Follow">https://www.w3.org/ns/activitystreams#Follow</seealso>
    let Follow = Prefixed_Name(as_, "Follow") |> PrefixedName
    /// <summary>
    ///   <para>as:Group</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Group of any kind."</para>
    /// labels<para>"Group"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Group">https://www.w3.org/ns/activitystreams#Group</seealso>
    let Group = Prefixed_Name(as_, "Group") |> PrefixedName
    /// <summary>
    ///   <para>as:Ignore</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actor is ignoring the Object"</para>
    /// labels<para>"Ignore"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Ignore">https://www.w3.org/ns/activitystreams#Ignore</seealso>
    let Ignore = Prefixed_Name(as_, "Ignore") |> PrefixedName
    /// <summary>
    ///   <para>as:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Image file"</para>
    /// labels<para>"Image"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Image">https://www.w3.org/ns/activitystreams#Image</seealso>
    let Image = Prefixed_Name(as_, "Image") |> PrefixedName

    /// <summary>
    ///   <para>as:IntransitiveActivity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Activity that has no direct object"</para>
    /// labels<para>"IntransitiveActivity"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#IntransitiveActivity">https://www.w3.org/ns/activitystreams#IntransitiveActivity</seealso>
    let IntransitiveActivity =
        Prefixed_Name(as_, "IntransitiveActivity") |> PrefixedName

    /// <summary>
    ///   <para>as:Invite</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To invite someone or something to something"</para>
    /// labels<para>"Invite"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Invite">https://www.w3.org/ns/activitystreams#Invite</seealso>
    let Invite = Prefixed_Name(as_, "Invite") |> PrefixedName
    /// <summary>
    ///   <para>as:Join</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Join Something"</para>
    /// labels<para>"Join"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Join">https://www.w3.org/ns/activitystreams#Join</seealso>
    let Join = Prefixed_Name(as_, "Join") |> PrefixedName
    /// <summary>
    ///   <para>as:Leave</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Leave Something"</para>
    /// labels<para>"Leave"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Leave">https://www.w3.org/ns/activitystreams#Leave</seealso>
    let Leave = Prefixed_Name(as_, "Leave") |> PrefixedName
    /// <summary>
    ///   <para>as:Like</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Like Something"</para>
    /// labels<para>"Like"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Like">https://www.w3.org/ns/activitystreams#Like</seealso>
    let Like = Prefixed_Name(as_, "Like") |> PrefixedName
    /// <summary>
    ///   <para>as:Link</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Represents a qualified reference to another resource. Patterned after the RFC5988 Web Linking Model"</para>
    /// labels<para>"Link"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Link">https://www.w3.org/ns/activitystreams#Link</seealso>
    let Link = Prefixed_Name(as_, "Link") |> PrefixedName
    /// <summary>
    ///   <para>as:Listen</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The actor listened to the object"</para>
    /// labels<para>"Listen"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Listen">https://www.w3.org/ns/activitystreams#Listen</seealso>
    let Listen = Prefixed_Name(as_, "Listen") |> PrefixedName
    /// <summary>
    ///   <para>as:Mention</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A specialized Link that represents an @mention"</para>
    /// labels<para>"Mention"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Mention">https://www.w3.org/ns/activitystreams#Mention</seealso>
    let Mention = Prefixed_Name(as_, "Mention") |> PrefixedName
    /// <summary>
    ///   <para>as:Move</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The actor is moving the object. The target specifies where the object is moving to. The origin specifies where the object is moving from."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Move"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Move">https://www.w3.org/ns/activitystreams#Move</seealso>
    let Move = Prefixed_Name(as_, "Move") |> PrefixedName
    /// <summary>
    ///   <para>as:Note</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Short note, typically less than a single paragraph. A "tweet" is an example, or a "status update""</para>
    /// labels<para>"Note"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Note">https://www.w3.org/ns/activitystreams#Note</seealso>
    let Note = Prefixed_Name(as_, "Note") |> PrefixedName
    /// <summary>
    ///   <para>as:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"Object"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Object">https://www.w3.org/ns/activitystreams#Object</seealso>
    let Object = Prefixed_Name(as_, "Object") |> PrefixedName
    /// <summary>
    ///   <para>as:Offer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Offer something to someone or something"</para>
    /// labels<para>"Offer"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Offer">https://www.w3.org/ns/activitystreams#Offer</seealso>
    let Offer = Prefixed_Name(as_, "Offer") |> PrefixedName
    /// <summary>
    ///   <para>as:OrderedCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A variation of Collection in which items are strictly ordered"</para>
    /// labels<para>"OrderedCollection"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#OrderedCollection">https://www.w3.org/ns/activitystreams#OrderedCollection</seealso>
    let OrderedCollection = Prefixed_Name(as_, "OrderedCollection") |> PrefixedName

    /// <summary>
    ///   <para>as:OrderedCollectionPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An ordered subset of items from an OrderedCollection"</para>
    /// labels<para>"OrderedCollectionPage"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#OrderedCollectionPage">https://www.w3.org/ns/activitystreams#OrderedCollectionPage</seealso>
    let OrderedCollectionPage =
        Prefixed_Name(as_, "OrderedCollectionPage") |> PrefixedName

    /// <summary>
    ///   <para>as:OrderedItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A rdf:List variant for Objects and Links"</para>
    /// labels<para>"OrderedItems"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#OrderedItems">https://www.w3.org/ns/activitystreams#OrderedItems</seealso>
    let OrderedItems = Prefixed_Name(as_, "OrderedItems") |> PrefixedName
    /// <summary>
    ///   <para>as:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An Organization"</para>
    /// labels<para>"Organization"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Organization">https://www.w3.org/ns/activitystreams#Organization</seealso>
    let Organization = Prefixed_Name(as_, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>as:Page</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Web Page"</para>
    /// labels<para>"Page"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Page">https://www.w3.org/ns/activitystreams#Page</seealso>
    let Page = Prefixed_Name(as_, "Page") |> PrefixedName
    /// <summary>
    ///   <para>as:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Person"</para>
    /// labels<para>"Person"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Person">https://www.w3.org/ns/activitystreams#Person</seealso>
    let Person = Prefixed_Name(as_, "Person") |> PrefixedName
    /// <summary>
    ///   <para>as:Place</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A physical or logical location"</para>
    /// labels<para>"Place"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Place">https://www.w3.org/ns/activitystreams#Place</seealso>
    let Place = Prefixed_Name(as_, "Place") |> PrefixedName
    /// <summary>
    ///   <para>as:Profile</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Profile Document"</para>
    /// labels<para>"Profile"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Profile">https://www.w3.org/ns/activitystreams#Profile</seealso>
    let Profile = Prefixed_Name(as_, "Profile") |> PrefixedName
    /// <summary>
    ///   <para>as:Question</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A question of any sort."</para>
    /// labels<para>"Question"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Question">https://www.w3.org/ns/activitystreams#Question</seealso>
    let Question = Prefixed_Name(as_, "Question") |> PrefixedName
    /// <summary>
    ///   <para>as:Read</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The actor read the object"</para>
    /// labels<para>"Read"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Read">https://www.w3.org/ns/activitystreams#Read</seealso>
    let Read = Prefixed_Name(as_, "Read") |> PrefixedName
    /// <summary>
    ///   <para>as:Reject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actor rejects the Object"</para>
    /// labels<para>"Reject"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Reject">https://www.w3.org/ns/activitystreams#Reject</seealso>
    let Reject = Prefixed_Name(as_, "Reject") |> PrefixedName
    /// <summary>
    ///   <para>as:Relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>rdf:Statement</para>
    ///   <para>"Represents a Social Graph relationship between two Individuals (indicated by the 'a' and 'b' properties)"</para>
    /// labels<para>"Relationship"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Relationship">https://www.w3.org/ns/activitystreams#Relationship</seealso>
    let Relationship = Prefixed_Name(as_, "Relationship") |> PrefixedName
    /// <summary>
    ///   <para>as:Remove</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Remove Something"</para>
    /// labels<para>"Remove"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Remove">https://www.w3.org/ns/activitystreams#Remove</seealso>
    let Remove = Prefixed_Name(as_, "Remove") |> PrefixedName
    /// <summary>
    ///   <para>as:Service</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A service provided by some entity"</para>
    /// labels<para>"Service"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Service">https://www.w3.org/ns/activitystreams#Service</seealso>
    let Service = Prefixed_Name(as_, "Service") |> PrefixedName
    /// <summary>
    ///   <para>as:TentativeAccept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actor tentatively accepts the Object"</para>
    /// labels<para>"TentativeAccept"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#TentativeAccept">https://www.w3.org/ns/activitystreams#TentativeAccept</seealso>
    let TentativeAccept = Prefixed_Name(as_, "TentativeAccept") |> PrefixedName
    /// <summary>
    ///   <para>as:TentativeReject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Actor tentatively rejects the object"</para>
    /// labels<para>"TentativeReject"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#TentativeReject">https://www.w3.org/ns/activitystreams#TentativeReject</seealso>
    let TentativeReject = Prefixed_Name(as_, "TentativeReject") |> PrefixedName
    /// <summary>
    ///   <para>as:Tombstone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A placeholder for a deleted object"</para>
    /// labels<para>"Tombstone"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Tombstone">https://www.w3.org/ns/activitystreams#Tombstone</seealso>
    let Tombstone = Prefixed_Name(as_, "Tombstone") |> PrefixedName
    /// <summary>
    ///   <para>as:Travel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The actor is traveling to the target. The origin specifies where the actor is traveling from."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"Travel"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Travel">https://www.w3.org/ns/activitystreams#Travel</seealso>
    let Travel = Prefixed_Name(as_, "Travel") |> PrefixedName
    /// <summary>
    ///   <para>as:Undo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Undo Something. This would typically be used to indicate that a previous Activity has been undone."</para>
    /// labels<para>"Undo"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Undo">https://www.w3.org/ns/activitystreams#Undo</seealso>
    let Undo = Prefixed_Name(as_, "Undo") |> PrefixedName
    /// <summary>
    ///   <para>as:Update</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"To Update/Modify Something"</para>
    /// labels<para>"Update"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Update">https://www.w3.org/ns/activitystreams#Update</seealso>
    let Update = Prefixed_Name(as_, "Update") |> PrefixedName
    /// <summary>
    ///   <para>as:Video</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A Video document of any kind."</para>
    /// labels<para>"Video"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#Video">https://www.w3.org/ns/activitystreams#Video</seealso>
    let Video = Prefixed_Name(as_, "Video") |> PrefixedName
    /// <summary>
    ///   <para>as:View</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The actor viewed the object"</para>
    /// labels<para>"View"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#View">https://www.w3.org/ns/activitystreams#View</seealso>
    let View = Prefixed_Name(as_, "View") |> PrefixedName
    /// <summary>
    ///   <para>as:accuracy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the accuracy around the point established by the longitude and latitude"</para>
    /// labels<para>"accuracy"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#accuracy">https://www.w3.org/ns/activitystreams#accuracy</seealso>
    let accuracy = Prefixed_Name(as_, "accuracy") |> PrefixedName
    /// <summary>
    ///   <para>as:actor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Subproperty of as:attributedTo that identifies the primary actor"</para>
    /// labels<para>"actor"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#actor">https://www.w3.org/ns/activitystreams#actor</seealso>
    let actor = Prefixed_Name(as_, "actor") |> PrefixedName
    /// <summary>
    ///   <para>as:altitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The altitude of a place"</para>
    /// labels<para>"altitude"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#altitude">https://www.w3.org/ns/activitystreams#altitude</seealso>
    let altitude = Prefixed_Name(as_, "altitude") |> PrefixedName
    /// <summary>
    ///   <para>as:anyOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Describes a possible inclusive answer or option for a question."</para>
    /// labels<para>"oneOf"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#anyOf">https://www.w3.org/ns/activitystreams#anyOf</seealso>
    let anyOf = Prefixed_Name(as_, "anyOf") |> PrefixedName
    /// <summary>
    ///   <para>as:attachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"attachment"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#attachment">https://www.w3.org/ns/activitystreams#attachment</seealso>
    let attachment = Prefixed_Name(as_, "attachment") |> PrefixedName
    /// <summary>
    ///   <para>as:attachments</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"attachments"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#attachments">https://www.w3.org/ns/activitystreams#attachments</seealso>
    let attachments = Prefixed_Name(as_, "attachments") |> PrefixedName
    /// <summary>
    ///   <para>as:attributedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Identifies an entity to which an object is attributed"</para>
    /// labels<para>"attributedTo"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#attributedTo">https://www.w3.org/ns/activitystreams#attributedTo</seealso>
    let attributedTo = Prefixed_Name(as_, "attributedTo") |> PrefixedName
    /// <summary>
    ///   <para>as:audience</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"audience"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#audience">https://www.w3.org/ns/activitystreams#audience</seealso>
    let audience = Prefixed_Name(as_, "audience") |> PrefixedName
    /// <summary>
    ///   <para>as:author</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Identifies the author of an object. Deprecated. Use as:attributedTo instead"</para>
    /// labels<para>"author"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#author">https://www.w3.org/ns/activitystreams#author</seealso>
    let author = Prefixed_Name(as_, "author") |> PrefixedName
    /// <summary>
    ///   <para>as:bcc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"bcc"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#bcc">https://www.w3.org/ns/activitystreams#bcc</seealso>
    let bcc = Prefixed_Name(as_, "bcc") |> PrefixedName
    /// <summary>
    ///   <para>as:bto</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"bto"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#bto">https://www.w3.org/ns/activitystreams#bto</seealso>
    let bto = Prefixed_Name(as_, "bto") |> PrefixedName
    /// <summary>
    ///   <para>as:cc</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"cc"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#cc">https://www.w3.org/ns/activitystreams#cc</seealso>
    let cc = Prefixed_Name(as_, "cc") |> PrefixedName
    /// <summary>
    ///   <para>as:content</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"The content of the object."</para>
    /// labels<para>"content"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#content">https://www.w3.org/ns/activitystreams#content</seealso>
    let content = Prefixed_Name(as_, "content") |> PrefixedName
    /// <summary>
    ///   <para>as:context</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies the context within which an object exists or an activity was performed"</para>
    /// labels<para>"context"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#context">https://www.w3.org/ns/activitystreams#context</seealso>
    let context = Prefixed_Name(as_, "context") |> PrefixedName
    /// <summary>
    ///   <para>as:current</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"current"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#current">https://www.w3.org/ns/activitystreams#current</seealso>
    let current = Prefixed_Name(as_, "current") |> PrefixedName
    /// <summary>
    ///   <para>as:deleted</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Specifies the date and time the object was deleted"</para>
    /// labels<para>"deleted"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#deleted">https://www.w3.org/ns/activitystreams#deleted</seealso>
    let deleted = Prefixed_Name(as_, "deleted") |> PrefixedName
    /// <summary>
    ///   <para>as:describes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"On a Profile object, describes the object described by the profile"</para>
    /// labels<para>"describes"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#describes">https://www.w3.org/ns/activitystreams#describes</seealso>
    let describes = Prefixed_Name(as_, "describes") |> PrefixedName

    /// <summary>
    ///   <para>as:downstreamDuplicates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///
    /// labels<para>"downstreamDuplicates"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#downstreamDuplicates">https://www.w3.org/ns/activitystreams#downstreamDuplicates</seealso>
    let downstreamDuplicates =
        Prefixed_Name(as_, "downstreamDuplicates") |> PrefixedName

    /// <summary>
    ///   <para>as:duration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The duration of the object"</para>
    /// labels<para>"duration"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#duration">https://www.w3.org/ns/activitystreams#duration</seealso>
    let duration = Prefixed_Name(as_, "duration") |> PrefixedName
    /// <summary>
    ///   <para>as:endTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The ending time of the object"</para>
    /// labels<para>"endTime"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#endTime">https://www.w3.org/ns/activitystreams#endTime</seealso>
    let endTime = Prefixed_Name(as_, "endTime") |> PrefixedName
    /// <summary>
    ///   <para>as:first</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"first"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#first">https://www.w3.org/ns/activitystreams#first</seealso>
    let first = Prefixed_Name(as_, "first") |> PrefixedName
    /// <summary>
    ///   <para>as:formerType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"On a Tombstone object, describes the former type of the deleted object"</para>
    /// labels<para>"formerType"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#formerType">https://www.w3.org/ns/activitystreams#formerType</seealso>
    let formerType = Prefixed_Name(as_, "formerType") |> PrefixedName
    /// <summary>
    ///   <para>as:generator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"generator"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#generator">https://www.w3.org/ns/activitystreams#generator</seealso>
    let generator = Prefixed_Name(as_, "generator") |> PrefixedName
    /// <summary>
    ///   <para>as:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The display height expressed as device independent pixels"</para>
    /// labels<para>"height"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#height">https://www.w3.org/ns/activitystreams#height</seealso>
    let height = Prefixed_Name(as_, "height") |> PrefixedName
    /// <summary>
    ///   <para>as:href</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The target URI of the Link"</para>
    /// labels<para>"href"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#href">https://www.w3.org/ns/activitystreams#href</seealso>
    let href = Prefixed_Name(as_, "href") |> PrefixedName
    /// <summary>
    ///   <para>as:hreflang</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A hint about the language of the referenced resource"</para>
    /// labels<para>"hreflang"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#hreflang">https://www.w3.org/ns/activitystreams#hreflang</seealso>
    let hreflang = Prefixed_Name(as_, "hreflang") |> PrefixedName
    /// <summary>
    ///   <para>as:icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"icon"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#icon">https://www.w3.org/ns/activitystreams#icon</seealso>
    let icon = Prefixed_Name(as_, "icon") |> PrefixedName
    /// <summary>
    ///   <para>as:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"id"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#id">https://www.w3.org/ns/activitystreams#id</seealso>
    let id = Prefixed_Name(as_, "id") |> PrefixedName
    /// <summary>
    ///   <para>as:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"image"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#image">https://www.w3.org/ns/activitystreams#image</seealso>
    let image = Prefixed_Name(as_, "image") |> PrefixedName
    /// <summary>
    ///   <para>as:inReplyTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"inReplyTo"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#inReplyTo">https://www.w3.org/ns/activitystreams#inReplyTo</seealso>
    let inReplyTo = Prefixed_Name(as_, "inReplyTo") |> PrefixedName
    /// <summary>
    ///   <para>as:instrument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Indentifies an object used (or to be used) to complete an activity"</para>
    /// labels<para>"instrument"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#instrument">https://www.w3.org/ns/activitystreams#instrument</seealso>
    let instrument = Prefixed_Name(as_, "instrument") |> PrefixedName
    /// <summary>
    ///   <para>as:items</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"items"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#items">https://www.w3.org/ns/activitystreams#items</seealso>
    let items = Prefixed_Name(as_, "items") |> PrefixedName
    /// <summary>
    ///   <para>as:last</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"last"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#last">https://www.w3.org/ns/activitystreams#last</seealso>
    let last = Prefixed_Name(as_, "last") |> PrefixedName
    /// <summary>
    ///   <para>as:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The latitude"</para>
    /// labels<para>"latitude"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#latitude">https://www.w3.org/ns/activitystreams#latitude</seealso>
    let latitude = Prefixed_Name(as_, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>as:location</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"location"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#location">https://www.w3.org/ns/activitystreams#location</seealso>
    let location = Prefixed_Name(as_, "location") |> PrefixedName
    /// <summary>
    ///   <para>as:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The longitude"</para>
    /// labels<para>"longitude"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#longitude">https://www.w3.org/ns/activitystreams#longitude</seealso>
    let longitude = Prefixed_Name(as_, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>as:mediaType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The MIME Media Type"</para>
    /// labels<para>"mediaType"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#mediaType">https://www.w3.org/ns/activitystreams#mediaType</seealso>
    let mediaType = Prefixed_Name(as_, "mediaType") |> PrefixedName
    /// <summary>
    ///   <para>as:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"name"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#name">https://www.w3.org/ns/activitystreams#name</seealso>
    let name = Prefixed_Name(as_, "name") |> PrefixedName
    /// <summary>
    ///   <para>as:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"next"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#next">https://www.w3.org/ns/activitystreams#next</seealso>
    let next = Prefixed_Name(as_, "next") |> PrefixedName
    /// <summary>
    ///   <para>as:object</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"object"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#object">https://www.w3.org/ns/activitystreams#object</seealso>
    let object = Prefixed_Name(as_, "object") |> PrefixedName
    /// <summary>
    ///   <para>as:objectType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"objectType"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#objectType">https://www.w3.org/ns/activitystreams#objectType</seealso>
    let objectType = Prefixed_Name(as_, "objectType") |> PrefixedName
    /// <summary>
    ///   <para>as:oneOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"Describes a possible exclusive answer or option for a question."</para>
    /// labels<para>"oneOf"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#oneOf">https://www.w3.org/ns/activitystreams#oneOf</seealso>
    let oneOf = Prefixed_Name(as_, "oneOf") |> PrefixedName
    /// <summary>
    ///   <para>as:origin</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"For certain activities, specifies the entity from which the action is directed."</para>
    /// labels<para>"origin"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#origin">https://www.w3.org/ns/activitystreams#origin</seealso>
    let origin = Prefixed_Name(as_, "origin") |> PrefixedName
    /// <summary>
    ///   <para>as:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"partOf"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#partOf">https://www.w3.org/ns/activitystreams#partOf</seealso>
    let partOf = Prefixed_Name(as_, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>as:prev</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"prev"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#prev">https://www.w3.org/ns/activitystreams#prev</seealso>
    let prev = Prefixed_Name(as_, "prev") |> PrefixedName
    /// <summary>
    ///   <para>as:preview</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"preview"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#preview">https://www.w3.org/ns/activitystreams#preview</seealso>
    let preview = Prefixed_Name(as_, "preview") |> PrefixedName
    /// <summary>
    ///   <para>as:provider</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"provider"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#provider">https://www.w3.org/ns/activitystreams#provider</seealso>
    let provider = Prefixed_Name(as_, "provider") |> PrefixedName
    /// <summary>
    ///   <para>as:published</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Specifies the date and time the object was published"</para>
    /// labels<para>"published"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#published">https://www.w3.org/ns/activitystreams#published</seealso>
    let published = Prefixed_Name(as_, "published") |> PrefixedName
    /// <summary>
    ///   <para>as:radius</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies a radius around the point established by the longitude and latitude"</para>
    /// labels<para>"radius"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#radius">https://www.w3.org/ns/activitystreams#radius</seealso>
    let radius = Prefixed_Name(as_, "radius") |> PrefixedName
    /// <summary>
    ///   <para>as:rating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A numeric rating (&gt;= 0.0, &lt;= 5.0) for the object"</para>
    /// labels<para>"rating"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#rating">https://www.w3.org/ns/activitystreams#rating</seealso>
    let rating = Prefixed_Name(as_, "rating") |> PrefixedName
    /// <summary>
    ///   <para>as:rel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The RFC 5988 or HTML5 Link Relation associated with the Link"</para>
    /// labels<para>"rel"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#rel">https://www.w3.org/ns/activitystreams#rel</seealso>
    let rel = Prefixed_Name(as_, "rel") |> PrefixedName
    /// <summary>
    ///   <para>as:relationship</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"On a Relationship object, describes the type of relationship"</para>
    /// labels<para>"relationship"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#relationship">https://www.w3.org/ns/activitystreams#relationship</seealso>
    let relationship = Prefixed_Name(as_, "relationship") |> PrefixedName
    /// <summary>
    ///   <para>as:replies</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"replies"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#replies">https://www.w3.org/ns/activitystreams#replies</seealso>
    let replies = Prefixed_Name(as_, "replies") |> PrefixedName
    /// <summary>
    ///   <para>as:result</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"result"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#result">https://www.w3.org/ns/activitystreams#result</seealso>
    let result = Prefixed_Name(as_, "result") |> PrefixedName
    /// <summary>
    ///   <para>as:startIndex</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"In a strictly ordered logical collection, specifies the index position of the first item in the items list"</para>
    /// labels<para>"startIndex"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#startIndex">https://www.w3.org/ns/activitystreams#startIndex</seealso>
    let startIndex = Prefixed_Name(as_, "startIndex") |> PrefixedName
    /// <summary>
    ///   <para>as:startTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The starting time of the object"</para>
    /// labels<para>"startTime"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#startTime">https://www.w3.org/ns/activitystreams#startTime</seealso>
    let startTime = Prefixed_Name(as_, "startTime") |> PrefixedName
    /// <summary>
    ///   <para>as:subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"On a Relationship object, identifies the subject. e.g. when saying "John is connected to Sally", 'subject' refers to 'John'"</para>
    /// labels<para>"a"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#subject">https://www.w3.org/ns/activitystreams#subject</seealso>
    let subject = Prefixed_Name(as_, "subject") |> PrefixedName
    /// <summary>
    ///   <para>as:summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A short summary of the object"</para>
    /// labels<para>"summary"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#summary">https://www.w3.org/ns/activitystreams#summary</seealso>
    let summary = Prefixed_Name(as_, "summary") |> PrefixedName
    /// <summary>
    ///   <para>as:tag</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"tag"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#tag">https://www.w3.org/ns/activitystreams#tag</seealso>
    let tag = Prefixed_Name(as_, "tag") |> PrefixedName
    /// <summary>
    ///   <para>as:tags</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///
    /// labels<para>"tags"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#tags">https://www.w3.org/ns/activitystreams#tags</seealso>
    let tags = Prefixed_Name(as_, "tags") |> PrefixedName
    /// <summary>
    ///   <para>as:target</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:ObjectProperty</para>
    ///
    /// labels<para>"target"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#target">https://www.w3.org/ns/activitystreams#target</seealso>
    let target = Prefixed_Name(as_, "target") |> PrefixedName
    /// <summary>
    ///   <para>as:to</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>"to"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#to">https://www.w3.org/ns/activitystreams#to</seealso>
    let to_ = Prefixed_Name(as_, "to") |> PrefixedName
    /// <summary>
    ///   <para>as:totalItems</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The total number of items in a logical collection"</para>
    /// labels<para>"totalItems"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#totalItems">https://www.w3.org/ns/activitystreams#totalItems</seealso>
    let totalItems = Prefixed_Name(as_, "totalItems") |> PrefixedName
    /// <summary>
    ///   <para>as:units</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Identifies the unit of measurement used by the radius, altitude and accuracy properties. The value can be expressed either as one of a set of predefined units or as a well-known common URI that identifies units."</para>
    /// labels<para>"units"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#units">https://www.w3.org/ns/activitystreams#units</seealso>
    let units = Prefixed_Name(as_, "units") |> PrefixedName
    /// <summary>
    ///   <para>as:updated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Specifies when the object was last updated"</para>
    /// labels<para>"updated"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#updated">https://www.w3.org/ns/activitystreams#updated</seealso>
    let updated = Prefixed_Name(as_, "updated") |> PrefixedName
    /// <summary>
    ///   <para>as:upstreamDuplicates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DeprecatedProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///
    /// labels<para>"upstreamDuplicates"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#upstreamDuplicates">https://www.w3.org/ns/activitystreams#upstreamDuplicates</seealso>
    let upstreamDuplicates = Prefixed_Name(as_, "upstreamDuplicates") |> PrefixedName
    /// <summary>
    ///   <para>as:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Specifies a link to a specific representation of the Object"</para>
    /// labels<para>"url"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#url">https://www.w3.org/ns/activitystreams#url</seealso>
    let url = Prefixed_Name(as_, "url") |> PrefixedName
    /// <summary>
    ///   <para>as:verb</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DeprecatedProperty</para>
    ///
    /// labels<para>"verb"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#verb">https://www.w3.org/ns/activitystreams#verb</seealso>
    let verb = Prefixed_Name(as_, "verb") |> PrefixedName
    /// <summary>
    ///   <para>as:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"Specifies the preferred display width of the content, expressed in terms of device independent pixels."</para>
    /// labels<para>"width"</para></remarks>
    /// <seealso href="https://www.w3.org/ns/activitystreams#width">https://www.w3.org/ns/activitystreams#width</seealso>
    let width = Prefixed_Name(as_, "width") |> PrefixedName
