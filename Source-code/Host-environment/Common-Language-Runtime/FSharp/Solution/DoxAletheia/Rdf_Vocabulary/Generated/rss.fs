namespace http.purl.org.rss._1._0.slash

open DoxAletheia.Rdf_Vocabulary

module rss =
    let _namespace_name = "http://purl.org/rss/1.0/"
    /// <summary>
    /// An RSS information channel.
    /// <see href="http://purl.org/rss/1.0/channel"></see></summary>
    let channel = Namespaced_IRI.parse _namespace_name "channel" |> NamespacedName

    /// <summary>
    /// A short text description of the subject.
    /// <see href="http://purl.org/rss/1.0/description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// An RSS image.
    /// <see href="http://purl.org/rss/1.0/image"></see></summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName
    /// <summary>
    /// An RSS item.
    /// <see href="http://purl.org/rss/1.0/item"></see></summary>
    let item = Namespaced_IRI.parse _namespace_name "item" |> NamespacedName
    /// <summary>
    /// Points to a list of rss:item elements that are members of the subject channel.
    /// <see href="http://purl.org/rss/1.0/items"></see></summary>
    let items = Namespaced_IRI.parse _namespace_name "items" |> NamespacedName
    /// <summary>
    /// The URL to which an HTML rendering of the subject will link.
    /// <see href="http://purl.org/rss/1.0/link"></see></summary>
    let link = Namespaced_IRI.parse _namespace_name "link" |> NamespacedName
    /// <summary>
    /// The text input field's (variable) name.
    /// <see href="http://purl.org/rss/1.0/name"></see></summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    /// An RSS text input.
    /// <see href="http://purl.org/rss/1.0/textinput"></see></summary>
    let textinput = Namespaced_IRI.parse _namespace_name "textinput" |> NamespacedName
    /// <summary>
    /// A descriptive title for the channel.
    /// <see href="http://purl.org/rss/1.0/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// The URL of the image to used in the 'src' attribute of the channel's image tag when rendered as HTML.
    /// <see href="http://purl.org/rss/1.0/url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
