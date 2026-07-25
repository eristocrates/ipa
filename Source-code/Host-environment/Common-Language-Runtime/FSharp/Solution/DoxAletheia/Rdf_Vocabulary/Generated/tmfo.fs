namespace http.tracker.api.gnome.org.ontology.v3.mfo.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module tmfo =
    let _namespace_iri = Namespace_Iri tmfo |> NamespaceIRI
    /// <summary>
    ///   <para>tmfo:Action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>class with a restricted set of actions</para>
    /// labels<para>Action Requests</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#Action">http://tracker.api.gnome.org/ontology/v3/mfo#Action</seealso>
    let Action = Prefixed_Name(tmfo, "Action") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:FeedElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Superclass for all elements related with feeds, to provide common configuration options</para>
    /// labels<para>Feed element</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedElement">http://tracker.api.gnome.org/ontology/v3/mfo#FeedElement</seealso>
    let FeedElement = Prefixed_Name(tmfo, "FeedElement") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:FeedChannel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents feed channel transfer, typically a download of RSS or ATOM.</para>
    /// labels<para>Feed channel</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedChannel">http://tracker.api.gnome.org/ontology/v3/mfo#FeedChannel</seealso>
    let FeedChannel = Prefixed_Name(tmfo, "FeedChannel") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:FeedMessage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents feed entry. May have enclosures attached and certain settings that allow deviation from feed channel's setup</para>
    /// labels<para>Feed entry</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedMessage">http://tracker.api.gnome.org/ontology/v3/mfo#FeedMessage</seealso>
    let FeedMessage = Prefixed_Name(tmfo, "FeedMessage") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:FeedType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>class with a restricted set of feed types</para>
    /// labels<para>Feed fomat type </para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedType">http://tracker.api.gnome.org/ontology/v3/mfo#FeedType</seealso>
    let FeedType = Prefixed_Name(tmfo, "FeedType") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:action</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Captures the current action for the channel: Refresh Now</para>
    /// labels<para>Action</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#action">http://tracker.api.gnome.org/ontology/v3/mfo#action</seealso>
    let action = Prefixed_Name(tmfo, "action") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:downloadPath</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Download path for enclosures in a message</para>
    /// labels<para>Download path</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#downloadPath">http://tracker.api.gnome.org/ontology/v3/mfo#downloadPath</seealso>
    let downloadPath = Prefixed_Name(tmfo, "downloadPath") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:enclosureList</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A list of enclosures</para>
    /// labels<para>Enclosure List</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#enclosureList">http://tracker.api.gnome.org/ontology/v3/mfo#enclosureList</seealso>
    let enclosureList = Prefixed_Name(tmfo, "enclosureList") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:groupDefault</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Different enclosures can represent the same resource in different formats/resolutions. This representations are grouped using the nie:identifier property and this property identify the default between them.</para>
    /// labels<para>Default in group</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#groupDefault">http://tracker.api.gnome.org/ontology/v3/mfo#groupDefault</seealso>
    let groupDefault = Prefixed_Name(tmfo, "groupDefault") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:maxSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Maximum size of enclosure that can be downloaded. Interpreted as KBs </para>
    /// labels<para>Size</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#maxSize">http://tracker.api.gnome.org/ontology/v3/mfo#maxSize</seealso>
    let maxSize = Prefixed_Name(tmfo, "maxSize") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:refresh-now</para>
    /// </summary>
    /// <remarks>
    ///   <para>tmfo:Action</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#refresh-now">http://tracker.api.gnome.org/ontology/v3/mfo#refresh-now</seealso>
    let refresh_now = Prefixed_Name(tmfo, "refresh-now") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:remoteLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Used to store remote URL of enclosure</para>
    /// labels<para>Enclosure link</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#remoteLink">http://tracker.api.gnome.org/ontology/v3/mfo#remoteLink</seealso>
    let remoteLink = Prefixed_Name(tmfo, "remoteLink") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:unreadCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Unread messages count within a channel</para>
    /// labels<para> Unread count</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#unreadCount">http://tracker.api.gnome.org/ontology/v3/mfo#unreadCount</seealso>
    let unreadCount = Prefixed_Name(tmfo, "unreadCount") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:feedSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Settings </para>
    /// labels<para>Feed element settings</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#feedSettings">http://tracker.api.gnome.org/ontology/v3/mfo#feedSettings</seealso>
    let feedSettings = Prefixed_Name(tmfo, "feedSettings") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Feed format name like rss-atom,flickr,facebook</para>
    /// labels<para>Feed type name or plugin name</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#name">http://tracker.api.gnome.org/ontology/v3/mfo#name</seealso>
    let name = Prefixed_Name(tmfo, "name") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para> Feeds format type which is mapped to plugin used in engine: flickr,rss-atom </para>
    /// labels<para>Feed formats type</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#type">http://tracker.api.gnome.org/ontology/v3/mfo#type</seealso>
    let type_ = Prefixed_Name(tmfo, "type") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:updatedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Captures the updated date and time when the channel is updated</para>
    /// labels<para>Updated</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#updatedTime">http://tracker.api.gnome.org/ontology/v3/mfo#updatedTime</seealso>
    let updatedTime = Prefixed_Name(tmfo, "updatedTime") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:</para>
    /// </summary>
    /// <remarks>
    ///   <para>tnrl:Namespace</para>
    ///   <para>tnrl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#">http://tracker.api.gnome.org/ontology/v3/mfo#</seealso>
    let _prefix_iri = Prefixed_Name(tmfo, "") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:Enclosure</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents an enclosure of a feed message</para>
    /// labels<para>Message enclosure</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#Enclosure">http://tracker.api.gnome.org/ontology/v3/mfo#Enclosure</seealso>
    let Enclosure = Prefixed_Name(tmfo, "Enclosure") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:FeedSettings</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Represents settings applied to a feed channel or a feed entry. How often it is updated, through which connection type it is delivered, when data expires and so on</para>
    /// labels<para>Resource settings</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedSettings">http://tracker.api.gnome.org/ontology/v3/mfo#FeedSettings</seealso>
    let FeedSettings = Prefixed_Name(tmfo, "FeedSettings") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:downloadFlag</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To indicate whether enclosures will be downloaded or not</para>
    /// labels<para>Download</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#downloadFlag">http://tracker.api.gnome.org/ontology/v3/mfo#downloadFlag</seealso>
    let downloadFlag = Prefixed_Name(tmfo, "downloadFlag") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:downloadedTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Captures the time stamp when message was downloaded</para>
    /// labels<para>Downloaded</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#downloadedTime">http://tracker.api.gnome.org/ontology/v3/mfo#downloadedTime</seealso>
    let downloadedTime = Prefixed_Name(tmfo, "downloadedTime") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:expiryInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Expiry interval for feed channel, it tells time that a message in a channel can live. Interpreted as minutes</para>
    /// labels<para>Expiry Interval</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#expiryInterval">http://tracker.api.gnome.org/ontology/v3/mfo#expiryInterval</seealso>
    let expiryInterval = Prefixed_Name(tmfo, "expiryInterval") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#image">http://tracker.api.gnome.org/ontology/v3/mfo#image</seealso>
    let image = Prefixed_Name(tmfo, "image") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:localLink</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Downloaded copy of the enclosure</para>
    /// labels<para>Local link</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#localLink">http://tracker.api.gnome.org/ontology/v3/mfo#localLink</seealso>
    let localLink = Prefixed_Name(tmfo, "localLink") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:optional</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The enclosure is mandatory to download or only optional</para>
    /// labels<para>Optional</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#optional">http://tracker.api.gnome.org/ontology/v3/mfo#optional</seealso>
    let optional = Prefixed_Name(tmfo, "optional") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:totalCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Total messages count within a channel</para>
    /// labels<para> Total count</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#totalCount">http://tracker.api.gnome.org/ontology/v3/mfo#totalCount</seealso>
    let totalCount = Prefixed_Name(tmfo, "totalCount") |> PrefixedName
    /// <summary>
    ///   <para>tmfo:updateInterval</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Update interval for a feed channel to get updated or refreshed. Interpreted as minutes</para>
    /// labels<para>Update Interval</para></remarks>
    /// <seealso href="http://tracker.api.gnome.org/ontology/v3/mfo#updateInterval">http://tracker.api.gnome.org/ontology/v3/mfo#updateInterval</seealso>
    let updateInterval = Prefixed_Name(tmfo, "updateInterval") |> PrefixedName
