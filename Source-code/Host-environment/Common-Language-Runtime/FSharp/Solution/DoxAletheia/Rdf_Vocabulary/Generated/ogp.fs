namespace http.ogp.me.ns.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ogp =
    let _namespace_iri = Namespace_Iri ogp |> NamespaceIRI
    /// <summary>
    ///   <para>ogp:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ogp.me/ns#">http://ogp.me/ns#</seealso>
    let _prefix_iri = Prefixed_Name(ogp, "") |> PrefixedName
    /// <summary>
    ///   <para>ogp:audio:artist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] An artist of some audio.</para>
    /// labels<para>audio artist</para></remarks>
    /// <seealso href="http://ogp.me/ns#audio:artist">http://ogp.me/ns#audio:artist</seealso>
    let ``audio:artist`` = Prefixed_Name(ogp, "audio:artist") |> PrefixedName
    /// <summary>
    ///   <para>ogp:audio:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] A title for some audio.</para>
    /// labels<para>audio title</para></remarks>
    /// <seealso href="http://ogp.me/ns#audio:title">http://ogp.me/ns#audio:title</seealso>
    let ``audio:title`` = Prefixed_Name(ogp, "audio:title") |> PrefixedName
    /// <summary>
    ///   <para>ogp:audio:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The mime type of an audio file e.g., "application/mp3"</para>
    /// labels<para>audio type</para></remarks>
    /// <seealso href="http://ogp.me/ns#audio:type">http://ogp.me/ns#audio:type</seealso>
    let ``audio:type`` = Prefixed_Name(ogp, "audio:type") |> PrefixedName
    /// <summary>
    ///   <para>ogp:country-name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] The country name of the resource e.g., "USA"</para>
    /// labels<para>country name</para></remarks>
    /// <seealso href="http://ogp.me/ns#country-name">http://ogp.me/ns#country-name</seealso>
    let country_name = Prefixed_Name(ogp, "country-name") |> PrefixedName
    /// <summary>
    ///   <para>ogp:audio:album</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] An album to which some audio belongs.</para>
    /// labels<para>audio album</para></remarks>
    /// <seealso href="http://ogp.me/ns#audio:album">http://ogp.me/ns#audio:album</seealso>
    let ``audio:album`` = Prefixed_Name(ogp, "audio:album") |> PrefixedName
    /// <summary>
    ///   <para>ogp:email</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] Email of the contact for your object.</para>
    /// labels<para>email</para></remarks>
    /// <seealso href="http://ogp.me/ns#email">http://ogp.me/ns#email</seealso>
    let email = Prefixed_Name(ogp, "email") |> PrefixedName
    /// <summary>
    ///   <para>ogp:image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An image URL which should represent your object within the graph.</para>
    /// labels<para>image</para></remarks>
    /// <seealso href="http://ogp.me/ns#image">http://ogp.me/ns#image</seealso>
    let image = Prefixed_Name(ogp, "image") |> PrefixedName
    /// <summary>
    ///   <para>ogp:image:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The height of an image.</para>
    /// labels<para>image height</para></remarks>
    /// <seealso href="http://ogp.me/ns#image:height">http://ogp.me/ns#image:height</seealso>
    let ``image:height`` = Prefixed_Name(ogp, "image:height") |> PrefixedName
    /// <summary>
    ///   <para>ogp:image:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The width of an image.</para>
    /// labels<para>image width</para></remarks>
    /// <seealso href="http://ogp.me/ns#image:width">http://ogp.me/ns#image:width</seealso>
    let ``image:width`` = Prefixed_Name(ogp, "image:width") |> PrefixedName
    /// <summary>
    ///   <para>ogp:latitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] The latitude of the resource e.g., the latitude of a company.</para>
    /// labels<para>latitude</para></remarks>
    /// <seealso href="http://ogp.me/ns#latitude">http://ogp.me/ns#latitude</seealso>
    let latitude = Prefixed_Name(ogp, "latitude") |> PrefixedName
    /// <summary>
    ///   <para>ogp:locale</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A Unix locale in which this markup is rendered.</para>
    /// labels<para>locale</para></remarks>
    /// <seealso href="http://ogp.me/ns#locale">http://ogp.me/ns#locale</seealso>
    let locale = Prefixed_Name(ogp, "locale") |> PrefixedName
    /// <summary>
    ///   <para>ogp:longitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] The longitude of the resource e.g., the longitude of a company.</para>
    /// labels<para>longitude</para></remarks>
    /// <seealso href="http://ogp.me/ns#longitude">http://ogp.me/ns#longitude</seealso>
    let longitude = Prefixed_Name(ogp, "longitude") |> PrefixedName
    /// <summary>
    ///   <para>ogp:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] The region of the resource e.g., "CA"</para>
    /// labels<para>region</para></remarks>
    /// <seealso href="http://ogp.me/ns#region">http://ogp.me/ns#region</seealso>
    let region = Prefixed_Name(ogp, "region") |> PrefixedName
    /// <summary>
    ///   <para>ogp:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The title of the object as it should appear within the graph, e.g.,  "The Rock".</para>
    /// labels<para>title</para></remarks>
    /// <seealso href="http://ogp.me/ns#title">http://ogp.me/ns#title</seealso>
    let title = Prefixed_Name(ogp, "title") |> PrefixedName
    /// <summary>
    ///   <para>ogp:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The type of your object, e.g., "movie".  Depending on the type you specify, other properties may also be required.</para>
    /// labels<para>type</para></remarks>
    /// <seealso href="http://ogp.me/ns#type">http://ogp.me/ns#type</seealso>
    let type_ = Prefixed_Name(ogp, "type") |> PrefixedName
    /// <summary>
    ///   <para>ogp:url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The canonical URL of your object that will be used as its permanent ID in the graph, e.g., "http://www.imdb.com/title/tt0117500/".</para>
    /// labels<para>url</para></remarks>
    /// <seealso href="http://ogp.me/ns#url">http://ogp.me/ns#url</seealso>
    let url = Prefixed_Name(ogp, "url") |> PrefixedName
    /// <summary>
    ///   <para>ogp:video:secure_url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A relevant, secure video URL for your object.</para>
    /// labels<para>video secure URL</para></remarks>
    /// <seealso href="http://ogp.me/ns#video:secure_url">http://ogp.me/ns#video:secure_url</seealso>
    let ``video:secure_url`` = Prefixed_Name(ogp, "video:secure_url") |> PrefixedName
    /// <summary>
    ///   <para>ogp:video:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The mime type of a video e.g., "application/x-shockwave-flash"</para>
    /// labels<para>video type</para></remarks>
    /// <seealso href="http://ogp.me/ns#video:type">http://ogp.me/ns#video:type</seealso>
    let ``video:type`` = Prefixed_Name(ogp, "video:type") |> PrefixedName
    /// <summary>
    ///   <para>ogp:image:type</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The mime type of an image.</para>
    /// labels<para>image type</para></remarks>
    /// <seealso href="http://ogp.me/ns#image:type">http://ogp.me/ns#image:type</seealso>
    let ``image:type`` = Prefixed_Name(ogp, "image:type") |> PrefixedName
    /// <summary>
    ///   <para>ogp:locality</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] The locality of the resource e.g, "Palo Alto"</para>
    /// labels<para>locality</para></remarks>
    /// <seealso href="http://ogp.me/ns#locality">http://ogp.me/ns#locality</seealso>
    let locality = Prefixed_Name(ogp, "locality") |> PrefixedName
    /// <summary>
    ///   <para>ogp:phone_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] Phone number of the contact for your object.</para>
    /// labels<para>phone number</para></remarks>
    /// <seealso href="http://ogp.me/ns#phone_number">http://ogp.me/ns#phone_number</seealso>
    let phone_number = Prefixed_Name(ogp, "phone_number") |> PrefixedName
    /// <summary>
    ///   <para>ogp:site_name</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>If your object is part of a larger web site, the name which should be displayed for the overall site. e.g., "IMDb".</para>
    /// labels<para>site name</para></remarks>
    /// <seealso href="http://ogp.me/ns#site_name">http://ogp.me/ns#site_name</seealso>
    let site_name = Prefixed_Name(ogp, "site_name") |> PrefixedName
    /// <summary>
    ///   <para>ogp:upc</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] Universal Product Code for your object.</para>
    /// labels<para>universal product code</para><para>upc</para></remarks>
    /// <seealso href="http://ogp.me/ns#upc">http://ogp.me/ns#upc</seealso>
    let upc = Prefixed_Name(ogp, "upc") |> PrefixedName
    /// <summary>
    ///   <para>ogp:video</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A relevant video URL for your object.</para>
    /// labels<para>video</para></remarks>
    /// <seealso href="http://ogp.me/ns#video">http://ogp.me/ns#video</seealso>
    let video = Prefixed_Name(ogp, "video") |> PrefixedName
    /// <summary>
    ///   <para>ogp:video:height</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The height of a video.</para>
    /// labels<para>video height</para></remarks>
    /// <seealso href="http://ogp.me/ns#video:height">http://ogp.me/ns#video:height</seealso>
    let ``video:height`` = Prefixed_Name(ogp, "video:height") |> PrefixedName
    /// <summary>
    ///   <para>ogp:video:width</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The width of a video.</para>
    /// labels<para>video width</para></remarks>
    /// <seealso href="http://ogp.me/ns#video:width">http://ogp.me/ns#video:width</seealso>
    let ``video:width`` = Prefixed_Name(ogp, "video:width") |> PrefixedName
    /// <summary>
    ///   <para>ogp:image:secure_url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A secure image URL which should represent your object within the graph.</para>
    /// labels<para>image secure url</para></remarks>
    /// <seealso href="http://ogp.me/ns#image:secure_url">http://ogp.me/ns#image:secure_url</seealso>
    let ``image:secure_url`` = Prefixed_Name(ogp, "image:secure_url") |> PrefixedName
    /// <summary>
    ///   <para>ogp:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] International Standard Book Number for you object.</para>
    /// labels<para>International Standard Book Number</para><para>isbn</para></remarks>
    /// <seealso href="http://ogp.me/ns#isbn">http://ogp.me/ns#isbn</seealso>
    let isbn = Prefixed_Name(ogp, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>ogp:postal-code</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] The postal code of the resource e.g., "94304"</para>
    /// labels<para>postal code</para></remarks>
    /// <seealso href="http://ogp.me/ns#postal-code">http://ogp.me/ns#postal-code</seealso>
    let postal_code = Prefixed_Name(ogp, "postal-code") |> PrefixedName
    /// <summary>
    ///   <para>ogp:street-address</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] The street address of the resource e.g., "1601 S California Ave".</para>
    /// labels<para>street address</para></remarks>
    /// <seealso href="http://ogp.me/ns#street-address">http://ogp.me/ns#street-address</seealso>
    let street_address = Prefixed_Name(ogp, "street-address") |> PrefixedName
    /// <summary>
    ///   <para>ogp:audio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A relevant audio URL for your object.</para>
    /// labels<para>audio</para></remarks>
    /// <seealso href="http://ogp.me/ns#audio">http://ogp.me/ns#audio</seealso>
    let audio = Prefixed_Name(ogp, "audio") |> PrefixedName
    /// <summary>
    ///   <para>ogp:audio:secure_url</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A relevant, secure audio URL for your object.</para>
    /// labels<para>audio secure URL</para></remarks>
    /// <seealso href="http://ogp.me/ns#audio:secure_url">http://ogp.me/ns#audio:secure_url</seealso>
    let ``audio:secure_url`` = Prefixed_Name(ogp, "audio:secure_url") |> PrefixedName
    /// <summary>
    ///   <para>ogp:description</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A one to two sentence description of your object.</para>
    /// labels<para>description</para></remarks>
    /// <seealso href="http://ogp.me/ns#description">http://ogp.me/ns#description</seealso>
    let description = Prefixed_Name(ogp, "description") |> PrefixedName
    /// <summary>
    ///   <para>ogp:determiner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The word to precede the object's title in a sentence (e.g., "the" in "the statue of liberty").  Valid values are "a", "an", "the", "", and "auto".</para>
    /// labels<para>determiner</para></remarks>
    /// <seealso href="http://ogp.me/ns#determiner">http://ogp.me/ns#determiner</seealso>
    let determiner = Prefixed_Name(ogp, "determiner") |> PrefixedName
    /// <summary>
    ///   <para>ogp:fax_number</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>[DEPRECATED] Fax number of the contact for your object.</para>
    /// labels<para>fax number</para></remarks>
    /// <seealso href="http://ogp.me/ns#fax_number">http://ogp.me/ns#fax_number</seealso>
    let fax_number = Prefixed_Name(ogp, "fax_number") |> PrefixedName
