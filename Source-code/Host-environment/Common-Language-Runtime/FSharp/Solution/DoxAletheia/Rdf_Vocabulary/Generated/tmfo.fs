namespace http.tracker.api.gnome.org.ontology.v3.mfo.hash

open DoxAletheia

module tmfo =
    let _namespace_name = "http://tracker.api.gnome.org/ontology/v3/mfo#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// class with a restricted set of actions
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#Action"></see></summary>
    let Action = _prefix "Action"
    /// <summary>
    /// Represents an enclosure of a feed message
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#Enclosure"></see></summary>
    let Enclosure = _prefix "Enclosure"
    /// <summary>
    /// Superclass for all elements related with feeds, to provide common configuration options
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedElement"></see></summary>
    let FeedElement = _prefix "FeedElement"
    /// <summary>
    /// Represents feed channel transfer, typically a download of RSS or ATOM.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedChannel"></see></summary>
    let FeedChannel = _prefix "FeedChannel"
    /// <summary>
    /// Represents feed entry. May have enclosures attached and certain settings that allow deviation from feed channel's setup
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedMessage"></see></summary>
    let FeedMessage = _prefix "FeedMessage"
    /// <summary>
    /// Represents settings applied to a feed channel or a feed entry. How often it is updated, through which connection type it is delivered, when data expires and so on
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedSettings"></see></summary>
    let FeedSettings = _prefix "FeedSettings"
    /// <summary>
    /// class with a restricted set of feed types
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#FeedType"></see></summary>
    let FeedType = _prefix "FeedType"
    /// <summary>
    /// Captures the current action for the channel: Refresh Now
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#action"></see></summary>
    let action = _prefix "action"
    /// <summary>
    /// To indicate whether enclosures will be downloaded or not
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#downloadFlag"></see></summary>
    let downloadFlag = _prefix "downloadFlag"
    /// <summary>
    /// Download path for enclosures in a message
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#downloadPath"></see></summary>
    let downloadPath = _prefix "downloadPath"
    /// <summary>
    /// Captures the time stamp when message was downloaded
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#downloadedTime"></see></summary>
    let downloadedTime = _prefix "downloadedTime"
    /// <summary>
    /// A list of enclosures
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#enclosureList"></see></summary>
    let enclosureList = _prefix "enclosureList"
    /// <summary>
    /// Expiry interval for feed channel, it tells time that a message in a channel can live. Interpreted as minutes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#expiryInterval"></see></summary>
    let expiryInterval = _prefix "expiryInterval"
    /// <summary>
    /// Settings
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#feedSettings"></see></summary>
    let feedSettings = _prefix "feedSettings"
    /// <summary>
    /// Different enclosures can represent the same resource in different formats/resolutions. This representations are grouped using the nie:identifier property and this property identify the default between them.
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#groupDefault"></see></summary>
    let groupDefault = _prefix "groupDefault"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/mfo#image"></see>
    /// </summary>
    let image = _prefix "image"
    /// <summary>
    /// Downloaded copy of the enclosure
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#localLink"></see></summary>
    let localLink = _prefix "localLink"
    /// <summary>
    /// Maximum size of enclosure that can be downloaded. Interpreted as KBs
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#maxSize"></see></summary>
    let maxSize = _prefix "maxSize"
    /// <summary>
    /// Feed format name like rss-atom,flickr,facebook
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// The enclosure is mandatory to download or only optional
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#optional"></see></summary>
    let optional = _prefix "optional"
    /// <summary>
    ///   <see href="http://tracker.api.gnome.org/ontology/v3/mfo#refresh-now"></see>
    /// </summary>
    let ``refresh-now`` = _prefix "refresh-now"
    /// <summary>
    /// Used to store remote URL of enclosure
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#remoteLink"></see></summary>
    let remoteLink = _prefix "remoteLink"
    /// <summary>
    /// Total messages count within a channel
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#totalCount"></see></summary>
    let totalCount = _prefix "totalCount"
    /// <summary>
    ///  Feeds format type which is mapped to plugin used in engine: flickr,rss-atom
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// Unread messages count within a channel
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#unreadCount"></see></summary>
    let unreadCount = _prefix "unreadCount"
    /// <summary>
    /// Update interval for a feed channel to get updated or refreshed. Interpreted as minutes
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#updateInterval"></see></summary>
    let updateInterval = _prefix "updateInterval"
    /// <summary>
    /// Captures the updated date and time when the channel is updated
    /// <see href="http://tracker.api.gnome.org/ontology/v3/mfo#updatedTime"></see></summary>
    let updatedTime = _prefix "updatedTime"
