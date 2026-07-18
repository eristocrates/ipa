namespace http.tracker.api.gnome.org.ontology.v3.mfo.hash

open DoxAletheia.Rdf_Vocabulary

module tmfo =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/mfo#"
    /// <summary>
    /// class with a restricted set of actions
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#Action"></see></summary>
    let Action = Namespaced_IRI.parse _namespace_name "Action" |> NamespacedName
    /// <summary>
    /// Represents an enclosure of a feed message
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#Enclosure"></see></summary>
    let Enclosure = Namespaced_IRI.parse _namespace_name "Enclosure" |> NamespacedName

    /// <summary>
    /// Superclass for all elements related with feeds, to provide common configuration options
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedElement"></see></summary>
    let FeedElement =
        Namespaced_IRI.parse _namespace_name "FeedElement" |> NamespacedName

    /// <summary>
    /// Represents feed channel transfer, typically a download of RSS or ATOM.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedChannel"></see></summary>
    let FeedChannel =
        Namespaced_IRI.parse _namespace_name "FeedChannel" |> NamespacedName

    /// <summary>
    /// Represents feed entry. May have enclosures attached and certain settings that allow deviation from feed channel's setup
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedMessage"></see></summary>
    let FeedMessage =
        Namespaced_IRI.parse _namespace_name "FeedMessage" |> NamespacedName

    /// <summary>
    /// Represents settings applied to a feed channel or a feed entry. How often it is updated, through which connection type it is delivered, when data expires and so on
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedSettings"></see></summary>
    let FeedSettings =
        Namespaced_IRI.parse _namespace_name "FeedSettings" |> NamespacedName

    /// <summary>
    /// class with a restricted set of feed types
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedType"></see></summary>
    let FeedType = Namespaced_IRI.parse _namespace_name "FeedType" |> NamespacedName
    /// <summary>
    /// Captures the current action for the channel: Refresh Now
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#action"></see></summary>
    let action = Namespaced_IRI.parse _namespace_name "action" |> NamespacedName

    /// <summary>
    /// To indicate whether enclosures will be downloaded or not
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#downloadFlag"></see></summary>
    let downloadFlag =
        Namespaced_IRI.parse _namespace_name "downloadFlag" |> NamespacedName

    /// <summary>
    /// Download path for enclosures in a message
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#downloadPath"></see></summary>
    let downloadPath =
        Namespaced_IRI.parse _namespace_name "downloadPath" |> NamespacedName

    /// <summary>
    /// Captures the time stamp when message was downloaded
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#downloadedTime"></see></summary>
    let downloadedTime =
        Namespaced_IRI.parse _namespace_name "downloadedTime" |> NamespacedName

    /// <summary>
    /// A list of enclosures
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#enclosureList"></see></summary>
    let enclosureList =
        Namespaced_IRI.parse _namespace_name "enclosureList" |> NamespacedName

    /// <summary>
    /// Expiry interval for feed channel, it tells time that a message in a channel can live. Interpreted as minutes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#expiryInterval"></see></summary>
    let expiryInterval =
        Namespaced_IRI.parse _namespace_name "expiryInterval" |> NamespacedName

    /// <summary>
    /// Settings
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#feedSettings"></see></summary>
    let feedSettings =
        Namespaced_IRI.parse _namespace_name "feedSettings" |> NamespacedName

    /// <summary>
    /// Different enclosures can represent the same resource in different formats/resolutions. This representations are grouped using the nie:identifier property and this property identify the default between them.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#groupDefault"></see></summary>
    let groupDefault =
        Namespaced_IRI.parse _namespace_name "groupDefault" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/mfo#image"></see>
    /// </summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName
    /// <summary>
    /// Downloaded copy of the enclosure
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#localLink"></see></summary>
    let localLink = Namespaced_IRI.parse _namespace_name "localLink" |> NamespacedName
    /// <summary>
    /// Maximum size of enclosure that can be downloaded. Interpreted as KBs
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#maxSize"></see></summary>
    let maxSize = Namespaced_IRI.parse _namespace_name "maxSize" |> NamespacedName
    /// <summary>
    /// Feed format name like rss-atom,flickr,facebook
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// The enclosure is mandatory to download or only optional
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#optional"></see></summary>
    let optional = Namespaced_IRI.parse _namespace_name "optional" |> NamespacedName

    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/mfo#refresh-now"></see>
    /// </summary>
    let ``refresh-now`` =
        Namespaced_IRI.parse _namespace_name "refresh-now" |> NamespacedName

    /// <summary>
    /// Used to store remote URL of enclosure
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#remoteLink"></see></summary>
    let remoteLink = Namespaced_IRI.parse _namespace_name "remoteLink" |> NamespacedName
    /// <summary>
    /// Total messages count within a channel
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#totalCount"></see></summary>
    let totalCount = Namespaced_IRI.parse _namespace_name "totalCount" |> NamespacedName
    /// <summary>
    ///  Feeds format type which is mapped to plugin used in engine: flickr,rss-atom
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName

    /// <summary>
    /// Unread messages count within a channel
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#unreadCount"></see></summary>
    let unreadCount =
        Namespaced_IRI.parse _namespace_name "unreadCount" |> NamespacedName

    /// <summary>
    /// Update interval for a feed channel to get updated or refreshed. Interpreted as minutes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#updateInterval"></see></summary>
    let updateInterval =
        Namespaced_IRI.parse _namespace_name "updateInterval" |> NamespacedName

    /// <summary>
    /// Captures the updated date and time when the channel is updated
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#updatedTime"></see></summary>
    let updatedTime =
        Namespaced_IRI.parse _namespace_name "updatedTime" |> NamespacedName
