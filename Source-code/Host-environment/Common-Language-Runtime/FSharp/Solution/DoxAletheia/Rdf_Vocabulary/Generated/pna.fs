namespace http.data.press.net.ontology.asset.slash

open DoxAletheia

module pna =
    let _namespace_name = "http://data.press.net/ontology/asset/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// Generic News Asset Class
    /// <see href="http://data.press.net/ontology/asset/Asset"></see></summary>
    let Asset = _prefix "Asset"
    /// <summary>
    /// Image Asset Class
    /// <see href="http://data.press.net/ontology/asset/Image"></see></summary>
    let Image = _prefix "Image"
    /// <summary>
    /// Text Asset Class
    /// <see href="http://data.press.net/ontology/asset/Text"></see></summary>
    let Text = _prefix "Text"
    /// <summary>
    /// Video Asset Class
    /// <see href="http://data.press.net/ontology/asset/Video"></see></summary>
    let Video = _prefix "Video"
    /// <summary>
    /// Property that associates one asset with another asset
    /// <see href="http://data.press.net/ontology/asset/associatedAsset"></see></summary>
    let associatedAsset = _prefix "associatedAsset"
    /// <summary>
    /// The byline of a news Asset
    /// <see href="http://data.press.net/ontology/asset/byline"></see></summary>
    let byline = _prefix "byline"
    /// <summary>
    /// The date and time a news Asset was created
    /// <see href="http://data.press.net/ontology/asset/created"></see></summary>
    let created = _prefix "created"
    /// <summary>
    /// Relates an asset to an asset that it is derived from
    /// <see href="http://data.press.net/ontology/asset/derivedFrom"></see></summary>
    let derivedFrom = _prefix "derivedFrom"
    /// <summary>
    /// The date and time a news Asset is embargoedUntil
    /// <see href="http://data.press.net/ontology/asset/embargoedUntil"></see></summary>
    let embargoedUntil = _prefix "embargoedUntil"
    /// <summary>
    /// Property that associates a thumbnail image with an asset
    /// <see href="http://data.press.net/ontology/asset/hasThumbnail"></see></summary>
    let hasThumbnail = _prefix "hasThumbnail"
    /// <summary>
    /// Property that associates a Text transcript with a Video
    /// <see href="http://data.press.net/ontology/asset/hasTranscript"></see></summary>
    let hasTranscript = _prefix "hasTranscript"
    /// <summary>
    /// The date and time a news Asset was modified
    /// <see href="http://data.press.net/ontology/asset/modified"></see></summary>
    let modified = _prefix "modified"
    /// <summary>
    /// The date and time a news Asset was published
    /// <see href="http://data.press.net/ontology/asset/published"></see></summary>
    let published = _prefix "published"
    /// <summary>
    /// The summary text of a news Asset
    /// <see href="http://data.press.net/ontology/asset/summary"></see></summary>
    let summary = _prefix "summary"
    /// <summary>
    /// The title of a news Asset
    /// <see href="http://data.press.net/ontology/asset/title"></see></summary>
    let title = _prefix "title"
