namespace http.data.press.net.ontology.asset.slash

open DoxAletheia.Rdf_Vocabulary

module pna =
    let _namespace_name = "http://data.press.net/ontology/asset/"
    /// <summary>
    /// Generic News Asset Class
    /// <see href="http://data.press.net/ontology/asset/Asset"></see></summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName
    /// <summary>
    /// Image Asset Class
    /// <see href="http://data.press.net/ontology/asset/Image"></see></summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    /// Text Asset Class
    /// <see href="http://data.press.net/ontology/asset/Text"></see></summary>
    let Text = Namespaced_IRI.parse _namespace_name "Text" |> NamespacedName
    /// <summary>
    /// Video Asset Class
    /// <see href="http://data.press.net/ontology/asset/Video"></see></summary>
    let Video = Namespaced_IRI.parse _namespace_name "Video" |> NamespacedName

    /// <summary>
    /// Property that associates one asset with another asset
    /// <see href="http://data.press.net/ontology/asset/associatedAsset"></see></summary>
    let associatedAsset =
        Namespaced_IRI.parse _namespace_name "associatedAsset" |> NamespacedName

    /// <summary>
    /// The byline of a news Asset
    /// <see href="http://data.press.net/ontology/asset/byline"></see></summary>
    let byline = Namespaced_IRI.parse _namespace_name "byline" |> NamespacedName
    /// <summary>
    /// The date and time a news Asset was created
    /// <see href="http://data.press.net/ontology/asset/created"></see></summary>
    let created = Namespaced_IRI.parse _namespace_name "created" |> NamespacedName

    /// <summary>
    /// Relates an asset to an asset that it is derived from
    /// <see href="http://data.press.net/ontology/asset/derivedFrom"></see></summary>
    let derivedFrom =
        Namespaced_IRI.parse _namespace_name "derivedFrom" |> NamespacedName

    /// <summary>
    /// The date and time a news Asset is embargoedUntil
    /// <see href="http://data.press.net/ontology/asset/embargoedUntil"></see></summary>
    let embargoedUntil =
        Namespaced_IRI.parse _namespace_name "embargoedUntil" |> NamespacedName

    /// <summary>
    /// Property that associates a thumbnail image with an asset
    /// <see href="http://data.press.net/ontology/asset/hasThumbnail"></see></summary>
    let hasThumbnail =
        Namespaced_IRI.parse _namespace_name "hasThumbnail" |> NamespacedName

    /// <summary>
    /// Property that associates a Text transcript with a Video
    /// <see href="http://data.press.net/ontology/asset/hasTranscript"></see></summary>
    let hasTranscript =
        Namespaced_IRI.parse _namespace_name "hasTranscript" |> NamespacedName

    /// <summary>
    /// The date and time a news Asset was modified
    /// <see href="http://data.press.net/ontology/asset/modified"></see></summary>
    let modified = Namespaced_IRI.parse _namespace_name "modified" |> NamespacedName
    /// <summary>
    /// The date and time a news Asset was published
    /// <see href="http://data.press.net/ontology/asset/published"></see></summary>
    let published = Namespaced_IRI.parse _namespace_name "published" |> NamespacedName
    /// <summary>
    /// The summary text of a news Asset
    /// <see href="http://data.press.net/ontology/asset/summary"></see></summary>
    let summary = Namespaced_IRI.parse _namespace_name "summary" |> NamespacedName
    /// <summary>
    /// The title of a news Asset
    /// <see href="http://data.press.net/ontology/asset/title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
