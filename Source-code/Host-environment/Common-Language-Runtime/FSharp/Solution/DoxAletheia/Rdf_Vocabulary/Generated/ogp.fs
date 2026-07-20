namespace http.ogp.me.ns.hash

open DoxAletheia

module ogp =
    let _namespace_name = "http://ogp.me/ns#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A relevant audio URL for your object.
    /// <see href="http://ogp.me/ns#audio"></see></summary>
    let audio = _prefix "audio"
    /// <summary>
    /// [DEPRECATED] An album to which some audio belongs.
    /// <see href="http://ogp.me/ns#audio:album"></see></summary>
    let ``audio:album`` = _prefix "audio:album"
    /// <summary>
    /// [DEPRECATED] An artist of some audio.
    /// <see href="http://ogp.me/ns#audio:artist"></see></summary>
    let ``audio:artist`` = _prefix "audio:artist"
    /// <summary>
    /// A relevant, secure audio URL for your object.
    /// <see href="http://ogp.me/ns#audio:secure_url"></see></summary>
    let ``audio:secure_url`` = _prefix "audio:secure_url"
    /// <summary>
    /// [DEPRECATED] A title for some audio.
    /// <see href="http://ogp.me/ns#audio:title"></see></summary>
    let ``audio:title`` = _prefix "audio:title"
    /// <summary>
    /// The mime type of an audio file e.g., "application/mp3"
    /// <see href="http://ogp.me/ns#audio:type"></see></summary>
    let ``audio:type`` = _prefix "audio:type"
    /// <summary>
    /// [DEPRECATED] The country name of the resource e.g., "USA"
    /// <see href="http://ogp.me/ns#country-name"></see></summary>
    let ``country-name`` = _prefix "country-name"
    /// <summary>
    /// A one to two sentence description of your object.
    /// <see href="http://ogp.me/ns#description"></see></summary>
    let description = _prefix "description"
    /// <summary>
    /// The word to precede the object's title in a sentence (e.g., "the" in "the statue of liberty").  Valid values are "a", "an", "the", "", and "auto".
    /// <see href="http://ogp.me/ns#determiner"></see></summary>
    let determiner = _prefix "determiner"
    /// <summary>
    /// [DEPRECATED] Email of the contact for your object.
    /// <see href="http://ogp.me/ns#email"></see></summary>
    let email = _prefix "email"
    /// <summary>
    /// [DEPRECATED] Fax number of the contact for your object.
    /// <see href="http://ogp.me/ns#fax_number"></see></summary>
    let fax_number = _prefix "fax_number"
    /// <summary>
    /// An image URL which should represent your object within the graph.
    /// <see href="http://ogp.me/ns#image"></see></summary>
    let image = _prefix "image"
    /// <summary>
    /// The height of an image.
    /// <see href="http://ogp.me/ns#image:height"></see></summary>
    let ``image:height`` = _prefix "image:height"
    /// <summary>
    /// A secure image URL which should represent your object within the graph.
    /// <see href="http://ogp.me/ns#image:secure_url"></see></summary>
    let ``image:secure_url`` = _prefix "image:secure_url"
    /// <summary>
    /// The mime type of an image.
    /// <see href="http://ogp.me/ns#image:type"></see></summary>
    let ``image:type`` = _prefix "image:type"
    /// <summary>
    /// The width of an image.
    /// <see href="http://ogp.me/ns#image:width"></see></summary>
    let ``image:width`` = _prefix "image:width"
    /// <summary>
    /// [DEPRECATED] International Standard Book Number for you object.
    /// <see href="http://ogp.me/ns#isbn"></see></summary>
    let isbn = _prefix "isbn"
    /// <summary>
    /// [DEPRECATED] The latitude of the resource e.g., the latitude of a company.
    /// <see href="http://ogp.me/ns#latitude"></see></summary>
    let latitude = _prefix "latitude"
    /// <summary>
    /// A Unix locale in which this markup is rendered.
    /// <see href="http://ogp.me/ns#locale"></see></summary>
    let locale = _prefix "locale"
    /// <summary>
    /// [DEPRECATED] The locality of the resource e.g, "Palo Alto"
    /// <see href="http://ogp.me/ns#locality"></see></summary>
    let locality = _prefix "locality"
    /// <summary>
    /// [DEPRECATED] The longitude of the resource e.g., the longitude of a company.
    /// <see href="http://ogp.me/ns#longitude"></see></summary>
    let longitude = _prefix "longitude"
    /// <summary>
    /// [DEPRECATED] Phone number of the contact for your object.
    /// <see href="http://ogp.me/ns#phone_number"></see></summary>
    let phone_number = _prefix "phone_number"
    /// <summary>
    /// [DEPRECATED] The postal code of the resource e.g., "94304"
    /// <see href="http://ogp.me/ns#postal-code"></see></summary>
    let ``postal-code`` = _prefix "postal-code"
    /// <summary>
    /// [DEPRECATED] The region of the resource e.g., "CA"
    /// <see href="http://ogp.me/ns#region"></see></summary>
    let region = _prefix "region"
    /// <summary>
    /// If your object is part of a larger web site, the name which should be displayed for the overall site. e.g., "IMDb".
    /// <see href="http://ogp.me/ns#site_name"></see></summary>
    let site_name = _prefix "site_name"
    /// <summary>
    /// [DEPRECATED] The street address of the resource e.g., "1601 S California Ave".
    /// <see href="http://ogp.me/ns#street-address"></see></summary>
    let ``street-address`` = _prefix "street-address"
    /// <summary>
    /// The title of the object as it should appear within the graph, e.g.,  "The Rock".
    /// <see href="http://ogp.me/ns#title"></see></summary>
    let title = _prefix "title"
    /// <summary>
    /// The type of your object, e.g., "movie".  Depending on the type you specify, other properties may also be required.
    /// <see href="http://ogp.me/ns#type"></see></summary>
    let type_ = _prefix "type"
    /// <summary>
    /// [DEPRECATED] Universal Product Code for your object.
    /// <see href="http://ogp.me/ns#upc"></see></summary>
    let upc = _prefix "upc"
    /// <summary>
    /// The canonical URL of your object that will be used as its permanent ID in the graph, e.g., "http://www.imdb.com/title/tt0117500/".
    /// <see href="http://ogp.me/ns#url"></see></summary>
    let url = _prefix "url"
    /// <summary>
    /// A relevant video URL for your object.
    /// <see href="http://ogp.me/ns#video"></see></summary>
    let video = _prefix "video"
    /// <summary>
    /// The height of a video.
    /// <see href="http://ogp.me/ns#video:height"></see></summary>
    let ``video:height`` = _prefix "video:height"
    /// <summary>
    /// A relevant, secure video URL for your object.
    /// <see href="http://ogp.me/ns#video:secure_url"></see></summary>
    let ``video:secure_url`` = _prefix "video:secure_url"
    /// <summary>
    /// The mime type of a video e.g., "application/x-shockwave-flash"
    /// <see href="http://ogp.me/ns#video:type"></see></summary>
    let ``video:type`` = _prefix "video:type"
    /// <summary>
    /// The width of a video.
    /// <see href="http://ogp.me/ns#video:width"></see></summary>
    let ``video:width`` = _prefix "video:width"
