namespace http.ogp.me.ns.hash

open DoxAletheia.Rdf_Vocabulary

module ogp =
    let _namespace_name = "http://ogp.me/ns#"
    /// <summary>
    /// A relevant audio URL for your object.
    /// <see href="http://ogp.me/ns#audio"></see></summary>
    let audio = Namespaced_IRI.parse _namespace_name "audio" |> NamespacedName

    /// <summary>
    /// [DEPRECATED] An album to which some audio belongs.
    /// <see href="http://ogp.me/ns#audio:album"></see></summary>
    let ``audio:album`` =
        Namespaced_IRI.parse _namespace_name "audio:album" |> NamespacedName

    /// <summary>
    /// [DEPRECATED] An artist of some audio.
    /// <see href="http://ogp.me/ns#audio:artist"></see></summary>
    let ``audio:artist`` =
        Namespaced_IRI.parse _namespace_name "audio:artist" |> NamespacedName

    /// <summary>
    /// A relevant, secure audio URL for your object.
    /// <see href="http://ogp.me/ns#audio:secure_url"></see></summary>
    let ``audio:secure_url`` =
        Namespaced_IRI.parse _namespace_name "audio:secure_url" |> NamespacedName

    /// <summary>
    /// [DEPRECATED] A title for some audio.
    /// <see href="http://ogp.me/ns#audio:title"></see></summary>
    let ``audio:title`` =
        Namespaced_IRI.parse _namespace_name "audio:title" |> NamespacedName

    /// <summary>
    /// The mime type of an audio file e.g., "application/mp3"
    /// <see href="http://ogp.me/ns#audio:type"></see></summary>
    let ``audio:type`` =
        Namespaced_IRI.parse _namespace_name "audio:type" |> NamespacedName

    /// <summary>
    /// [DEPRECATED] The country name of the resource e.g., "USA"
    /// <see href="http://ogp.me/ns#country-name"></see></summary>
    let ``country-name`` =
        Namespaced_IRI.parse _namespace_name "country-name" |> NamespacedName

    /// <summary>
    /// A one to two sentence description of your object.
    /// <see href="http://ogp.me/ns#description"></see></summary>
    let description =
        Namespaced_IRI.parse _namespace_name "description" |> NamespacedName

    /// <summary>
    /// The word to precede the object's title in a sentence (e.g., "the" in "the statue of liberty").  Valid values are "a", "an", "the", "", and "auto".
    /// <see href="http://ogp.me/ns#determiner"></see></summary>
    let determiner = Namespaced_IRI.parse _namespace_name "determiner" |> NamespacedName
    /// <summary>
    /// [DEPRECATED] Email of the contact for your object.
    /// <see href="http://ogp.me/ns#email"></see></summary>
    let email = Namespaced_IRI.parse _namespace_name "email" |> NamespacedName
    /// <summary>
    /// [DEPRECATED] Fax number of the contact for your object.
    /// <see href="http://ogp.me/ns#fax_number"></see></summary>
    let fax_number = Namespaced_IRI.parse _namespace_name "fax_number" |> NamespacedName
    /// <summary>
    /// An image URL which should represent your object within the graph.
    /// <see href="http://ogp.me/ns#image"></see></summary>
    let image = Namespaced_IRI.parse _namespace_name "image" |> NamespacedName

    /// <summary>
    /// The height of an image.
    /// <see href="http://ogp.me/ns#image:height"></see></summary>
    let ``image:height`` =
        Namespaced_IRI.parse _namespace_name "image:height" |> NamespacedName

    /// <summary>
    /// A secure image URL which should represent your object within the graph.
    /// <see href="http://ogp.me/ns#image:secure_url"></see></summary>
    let ``image:secure_url`` =
        Namespaced_IRI.parse _namespace_name "image:secure_url" |> NamespacedName

    /// <summary>
    /// The mime type of an image.
    /// <see href="http://ogp.me/ns#image:type"></see></summary>
    let ``image:type`` =
        Namespaced_IRI.parse _namespace_name "image:type" |> NamespacedName

    /// <summary>
    /// The width of an image.
    /// <see href="http://ogp.me/ns#image:width"></see></summary>
    let ``image:width`` =
        Namespaced_IRI.parse _namespace_name "image:width" |> NamespacedName

    /// <summary>
    /// [DEPRECATED] International Standard Book Number for you object.
    /// <see href="http://ogp.me/ns#isbn"></see></summary>
    let isbn = Namespaced_IRI.parse _namespace_name "isbn" |> NamespacedName
    /// <summary>
    /// [DEPRECATED] The latitude of the resource e.g., the latitude of a company.
    /// <see href="http://ogp.me/ns#latitude"></see></summary>
    let latitude = Namespaced_IRI.parse _namespace_name "latitude" |> NamespacedName
    /// <summary>
    /// A Unix locale in which this markup is rendered.
    /// <see href="http://ogp.me/ns#locale"></see></summary>
    let locale = Namespaced_IRI.parse _namespace_name "locale" |> NamespacedName
    /// <summary>
    /// [DEPRECATED] The locality of the resource e.g, "Palo Alto"
    /// <see href="http://ogp.me/ns#locality"></see></summary>
    let locality = Namespaced_IRI.parse _namespace_name "locality" |> NamespacedName
    /// <summary>
    /// [DEPRECATED] The longitude of the resource e.g., the longitude of a company.
    /// <see href="http://ogp.me/ns#longitude"></see></summary>
    let longitude = Namespaced_IRI.parse _namespace_name "longitude" |> NamespacedName

    /// <summary>
    /// [DEPRECATED] Phone number of the contact for your object.
    /// <see href="http://ogp.me/ns#phone_number"></see></summary>
    let phone_number =
        Namespaced_IRI.parse _namespace_name "phone_number" |> NamespacedName

    /// <summary>
    /// [DEPRECATED] The postal code of the resource e.g., "94304"
    /// <see href="http://ogp.me/ns#postal-code"></see></summary>
    let ``postal-code`` =
        Namespaced_IRI.parse _namespace_name "postal-code" |> NamespacedName

    /// <summary>
    /// [DEPRECATED] The region of the resource e.g., "CA"
    /// <see href="http://ogp.me/ns#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName
    /// <summary>
    /// If your object is part of a larger web site, the name which should be displayed for the overall site. e.g., "IMDb".
    /// <see href="http://ogp.me/ns#site_name"></see></summary>
    let site_name = Namespaced_IRI.parse _namespace_name "site_name" |> NamespacedName

    /// <summary>
    /// [DEPRECATED] The street address of the resource e.g., "1601 S California Ave".
    /// <see href="http://ogp.me/ns#street-address"></see></summary>
    let ``street-address`` =
        Namespaced_IRI.parse _namespace_name "street-address" |> NamespacedName

    /// <summary>
    /// The title of the object as it should appear within the graph, e.g.,  "The Rock".
    /// <see href="http://ogp.me/ns#title"></see></summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    /// The type of your object, e.g., "movie".  Depending on the type you specify, other properties may also be required.
    /// <see href="http://ogp.me/ns#type"></see></summary>
    let type_ = Namespaced_IRI.parse _namespace_name "type" |> NamespacedName
    /// <summary>
    /// [DEPRECATED] Universal Product Code for your object.
    /// <see href="http://ogp.me/ns#upc"></see></summary>
    let upc = Namespaced_IRI.parse _namespace_name "upc" |> NamespacedName
    /// <summary>
    /// The canonical URL of your object that will be used as its permanent ID in the graph, e.g., "http://www.imdb.com/title/tt0117500/".
    /// <see href="http://ogp.me/ns#url"></see></summary>
    let url = Namespaced_IRI.parse _namespace_name "url" |> NamespacedName
    /// <summary>
    /// A relevant video URL for your object.
    /// <see href="http://ogp.me/ns#video"></see></summary>
    let video = Namespaced_IRI.parse _namespace_name "video" |> NamespacedName

    /// <summary>
    /// The height of a video.
    /// <see href="http://ogp.me/ns#video:height"></see></summary>
    let ``video:height`` =
        Namespaced_IRI.parse _namespace_name "video:height" |> NamespacedName

    /// <summary>
    /// A relevant, secure video URL for your object.
    /// <see href="http://ogp.me/ns#video:secure_url"></see></summary>
    let ``video:secure_url`` =
        Namespaced_IRI.parse _namespace_name "video:secure_url" |> NamespacedName

    /// <summary>
    /// The mime type of a video e.g., "application/x-shockwave-flash"
    /// <see href="http://ogp.me/ns#video:type"></see></summary>
    let ``video:type`` =
        Namespaced_IRI.parse _namespace_name "video:type" |> NamespacedName

    /// <summary>
    /// The width of a video.
    /// <see href="http://ogp.me/ns#video:width"></see></summary>
    let ``video:width`` =
        Namespaced_IRI.parse _namespace_name "video:width" |> NamespacedName
