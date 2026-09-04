#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module og =
    let _prefixId = PrefixId.fromNamespaceLabel "http://ogp.me/ns#" "og"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : A relevant audio URL for your object.</para>
    ///   <para>rdfs:label : audio</para>
    ///   <a href="http://ogp.me/ns#audio">og:audio</a>
    /// </summary>
    let audio = _prefixId.prefix "audio"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] An album to which some audio belongs.</para>
    ///   <para>rdfs:label : audio album</para>
    ///   <a href="http://ogp.me/ns#audio:album">og:audio:album</a>
    /// </summary>
    let audioalbum = _prefixId.prefix "audio:album"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] An artist of some audio.</para>
    ///   <para>rdfs:label : audio artist</para>
    ///   <a href="http://ogp.me/ns#audio:artist">og:audio:artist</a>
    /// </summary>
    let audioartist = _prefixId.prefix "audio:artist"
    /// <summary>
    ///   <para>rdfs:comment : A relevant, secure audio URL for your object.</para>
    ///   <para>rdfs:label : audio secure URL</para>
    ///   <a href="http://ogp.me/ns#audio:secure_url">og:audio:secure_url</a>
    /// </summary>
    let audiosecure_url = _prefixId.prefix "audio:secure_url"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] A title for some audio.</para>
    ///   <para>rdfs:label : audio title</para>
    ///   <a href="http://ogp.me/ns#audio:title">og:audio:title</a>
    /// </summary>
    let audiotitle = _prefixId.prefix "audio:title"
    /// <summary>
    ///   <para>rdfs:comment : The mime type of an audio file e.g., "application/mp3"</para>
    ///   <para>rdfs:label : audio type</para>
    ///   <a href="http://ogp.me/ns#audio:type">og:audio:type</a>
    /// </summary>
    let audiotype = _prefixId.prefix "audio:type"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] The country name of the resource e.g., "USA"</para>
    ///   <para>rdfs:label : country name</para>
    ///   <a href="http://ogp.me/ns#country-name">og:country-name</a>
    /// </summary>
    let country_name = _prefixId.prefix "country-name"
    /// <summary>
    ///   <para>rdfs:comment : A one to two sentence description of your object.</para>
    ///   <para>rdfs:label : description</para>
    ///   <a href="http://ogp.me/ns#description">og:description</a>
    /// </summary>
    let description = _prefixId.prefix "description"
    /// <summary>
    ///   <para>rdfs:comment : The word to precede the object's title in a sentence (e.g., "the" in "the statue of liberty").  Valid values are "a", "an", "the", "", and "auto".</para>
    ///   <para>rdfs:label : determiner</para>
    ///   <a href="http://ogp.me/ns#determiner">og:determiner</a>
    /// </summary>
    let determiner = _prefixId.prefix "determiner"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] Email of the contact for your object.</para>
    ///   <para>rdfs:label : email</para>
    ///   <a href="http://ogp.me/ns#email">og:email</a>
    /// </summary>
    let email = _prefixId.prefix "email"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] Fax number of the contact for your object.</para>
    ///   <para>rdfs:label : fax number</para>
    ///   <a href="http://ogp.me/ns#fax_number">og:fax_number</a>
    /// </summary>
    let fax_number = _prefixId.prefix "fax_number"
    /// <summary>
    ///   <para>rdfs:comment : An image URL which should represent your object within the graph.</para>
    ///   <para>rdfs:label : image</para>
    ///   <a href="http://ogp.me/ns#image">og:image</a>
    /// </summary>
    let image = _prefixId.prefix "image"
    /// <summary>
    ///   <para>rdfs:comment : The height of an image.</para>
    ///   <para>rdfs:label : image height</para>
    ///   <a href="http://ogp.me/ns#image:height">og:image:height</a>
    /// </summary>
    let imageheight = _prefixId.prefix "image:height"
    /// <summary>
    ///   <para>rdfs:comment : A secure image URL which should represent your object within the graph.</para>
    ///   <para>rdfs:label : image secure url</para>
    ///   <a href="http://ogp.me/ns#image:secure_url">og:image:secure_url</a>
    /// </summary>
    let imagesecure_url = _prefixId.prefix "image:secure_url"
    /// <summary>
    ///   <para>rdfs:comment : The mime type of an image.</para>
    ///   <para>rdfs:label : image type</para>
    ///   <a href="http://ogp.me/ns#image:type">og:image:type</a>
    /// </summary>
    let imagetype = _prefixId.prefix "image:type"
    /// <summary>
    ///   <para>rdfs:comment : The width of an image.</para>
    ///   <para>rdfs:label : image width</para>
    ///   <a href="http://ogp.me/ns#image:width">og:image:width</a>
    /// </summary>
    let imagewidth = _prefixId.prefix "image:width"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] International Standard Book Number for you object.</para>
    ///   <para>rdfs:label : International Standard Book Numberrdfs:label : isbn</para>
    ///   <a href="http://ogp.me/ns#isbn">og:isbn</a>
    /// </summary>
    let isbn = _prefixId.prefix "isbn"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] The latitude of the resource e.g., the latitude of a company.</para>
    ///   <para>rdfs:label : latitude</para>
    ///   <a href="http://ogp.me/ns#latitude">og:latitude</a>
    /// </summary>
    let latitude = _prefixId.prefix "latitude"
    /// <summary>
    ///   <para>rdfs:comment : A Unix locale in which this markup is rendered.</para>
    ///   <para>rdfs:label : locale</para>
    ///   <a href="http://ogp.me/ns#locale">og:locale</a>
    /// </summary>
    let locale = _prefixId.prefix "locale"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] The locality of the resource e.g, "Palo Alto"</para>
    ///   <para>rdfs:label : locality</para>
    ///   <a href="http://ogp.me/ns#locality">og:locality</a>
    /// </summary>
    let locality = _prefixId.prefix "locality"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] The longitude of the resource e.g., the longitude of a company.</para>
    ///   <para>rdfs:label : longitude</para>
    ///   <a href="http://ogp.me/ns#longitude">og:longitude</a>
    /// </summary>
    let longitude = _prefixId.prefix "longitude"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] Phone number of the contact for your object.</para>
    ///   <para>rdfs:label : phone number</para>
    ///   <a href="http://ogp.me/ns#phone_number">og:phone_number</a>
    /// </summary>
    let phone_number = _prefixId.prefix "phone_number"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] The postal code of the resource e.g., "94304"</para>
    ///   <para>rdfs:label : postal code</para>
    ///   <a href="http://ogp.me/ns#postal-code">og:postal-code</a>
    /// </summary>
    let postal_code = _prefixId.prefix "postal-code"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] The region of the resource e.g., "CA"</para>
    ///   <para>rdfs:label : region</para>
    ///   <a href="http://ogp.me/ns#region">og:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    /// <summary>
    ///   <para>rdfs:comment : If your object is part of a larger web site, the name which should be displayed for the overall site. e.g., "IMDb".</para>
    ///   <para>rdfs:label : site name</para>
    ///   <a href="http://ogp.me/ns#site_name">og:site_name</a>
    /// </summary>
    let site_name = _prefixId.prefix "site_name"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] The street address of the resource e.g., "1601 S California Ave".</para>
    ///   <para>rdfs:label : street address</para>
    ///   <a href="http://ogp.me/ns#street-address">og:street-address</a>
    /// </summary>
    let street_address = _prefixId.prefix "street-address"
    /// <summary>
    ///   <para>rdfs:comment : The title of the object as it should appear within the graph, e.g.,  "The Rock".</para>
    ///   <para>rdfs:label : title</para>
    ///   <a href="http://ogp.me/ns#title">og:title</a>
    /// </summary>
    let title = _prefixId.prefix "title"
    /// <summary>
    ///   <para>rdfs:comment : The type of your object, e.g., "movie".  Depending on the type you specify, other properties may also be required.</para>
    ///   <para>rdfs:label : type</para>
    ///   <a href="http://ogp.me/ns#type">og:type</a>
    /// </summary>
    let type_ = _prefixId.prefix "type"
    /// <summary>
    ///   <para>rdfs:comment : [DEPRECATED] Universal Product Code for your object.</para>
    ///   <para>rdfs:label : universal product coderdfs:label : upc</para>
    ///   <a href="http://ogp.me/ns#upc">og:upc</a>
    /// </summary>
    let upc = _prefixId.prefix "upc"
    /// <summary>
    ///   <para>rdfs:comment : The canonical URL of your object that will be used as its permanent ID in the graph, e.g., "http://www.imdb.com/title/tt0117500/".</para>
    ///   <para>rdfs:label : url</para>
    ///   <a href="http://ogp.me/ns#url">og:url</a>
    /// </summary>
    let url = _prefixId.prefix "url"
    /// <summary>
    ///   <para>rdfs:comment : A relevant video URL for your object.</para>
    ///   <para>rdfs:label : video</para>
    ///   <a href="http://ogp.me/ns#video">og:video</a>
    /// </summary>
    let video = _prefixId.prefix "video"
    /// <summary>
    ///   <para>rdfs:comment : The height of a video.</para>
    ///   <para>rdfs:label : video height</para>
    ///   <a href="http://ogp.me/ns#video:height">og:video:height</a>
    /// </summary>
    let videoheight = _prefixId.prefix "video:height"
    /// <summary>
    ///   <para>rdfs:comment : A relevant, secure video URL for your object.</para>
    ///   <para>rdfs:label : video secure URL</para>
    ///   <a href="http://ogp.me/ns#video:secure_url">og:video:secure_url</a>
    /// </summary>
    let videosecure_url = _prefixId.prefix "video:secure_url"
    /// <summary>
    ///   <para>rdfs:comment : The mime type of a video e.g., "application/x-shockwave-flash"</para>
    ///   <para>rdfs:label : video type</para>
    ///   <a href="http://ogp.me/ns#video:type">og:video:type</a>
    /// </summary>
    let videotype = _prefixId.prefix "video:type"
    /// <summary>
    ///   <para>rdfs:comment : The width of a video.</para>
    ///   <para>rdfs:label : video width</para>
    ///   <a href="http://ogp.me/ns#video:width">og:video:width</a>
    /// </summary>
    let videowidth = _prefixId.prefix "video:width"
