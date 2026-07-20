namespace http.purl.org.rss._1._0.slash

open DoxAletheia

module rss =
    let _namespace_name = "http://purl.org/rss/1.0/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// An RSS information channel.
    /// <see href="http://purl.org/rss/1.0/channel"></see></summary>
    let channel = _prefix "channel"
    /// <summary>
    /// A short text description of the subject.
    /// <see href="http://purl.org/rss/1.0/description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// An RSS image.
    /// <see href="http://purl.org/rss/1.0/image"></see></summary>
    let image = _prefix "image"
    /// <summary>
    /// An RSS item.
    /// <see href="http://purl.org/rss/1.0/item"></see></summary>
    let item = _prefix "item"
    /// <summary>
    /// Points to a list of rss:item elements that are members of the subject channel.
    /// <see href="http://purl.org/rss/1.0/items"></see></summary>
    let items = _prefix "items"
    /// <summary>
    /// The URL to which an HTML rendering of the subject will link.
    /// <see href="http://purl.org/rss/1.0/link"></see></summary>
    let link = _prefix "link"
    /// <summary>
    /// The text input field's (variable) name.
    /// <see href="http://purl.org/rss/1.0/name"></see></summary>
    let name = _prefix "name"
    /// <summary>
    /// An RSS text input.
    /// <see href="http://purl.org/rss/1.0/textinput"></see></summary>
    let textinput = _prefix "textinput"
    /// <summary>
    /// A descriptive title for the channel.
    /// <see href="http://purl.org/rss/1.0/title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// The URL of the image to used in the 'src' attribute of the channel's image tag when rendered as HTML.
    /// <see href="http://purl.org/rss/1.0/url"></see></summary>
    let url = _prefix "url"
