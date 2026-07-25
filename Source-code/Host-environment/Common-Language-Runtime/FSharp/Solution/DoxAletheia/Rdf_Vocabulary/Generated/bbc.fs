namespace http.www.bbc.co.uk.ontologies.bbc.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module bbc =
    let _namespace_iri = Namespace_Iri bbc |> NamespaceIRI
    /// <summary>
    ///   <para>bbc:1.10</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/1.10">http://www.bbc.co.uk/ontologies/bbc/1.10</seealso>
    let ``_1.10`` = Prefixed_Name(bbc, "1.10") |> PrefixedName
    /// <summary>
    ///   <para>bbc:HighWeb</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Platform</para>
    ///   <para>Represents the  web documents designed for a large screen.</para>
    /// labels<para>HighWeb</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/HighWeb">http://www.bbc.co.uk/ontologies/bbc/HighWeb</seealso>
    let HighWeb = Prefixed_Name(bbc, "HighWeb") |> PrefixedName
    /// <summary>
    ///   <para>bbc:Platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Represents the different types of platforms through which a web document can be accessed. This is needed to derive the correct web document for consumption from the appropriate platform. If there's no specification on platform suitability then the document is considered to be suitable for both.</para>
    /// labels<para>Platform</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/Platform">http://www.bbc.co.uk/ontologies/bbc/Platform</seealso>
    let Platform = Prefixed_Name(bbc, "Platform") |> PrefixedName
    /// <summary>
    ///   <para>bbc:OfficialHomepage</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Product</para>
    ///   <para>Represents the official home pages of the things the BBC creates content about e.g., the Manchester council homepage http://www.manchester.gov.uk.</para>
    /// labels<para>OfficialHomepage</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/OfficialHomepage">http://www.bbc.co.uk/ontologies/bbc/OfficialHomepage</seealso>
    let OfficialHomepage = Prefixed_Name(bbc, "OfficialHomepage") |> PrefixedName
    /// <summary>
    ///   <para>bbc:Sport</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Product</para>
    ///   <para>This instance of bbc:Product is needed to associate WebDocuments from BBC Sport.</para>
    /// labels<para>Sport</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/Sport">http://www.bbc.co.uk/ontologies/bbc/Sport</seealso>
    let Sport = Prefixed_Name(bbc, "Sport") |> PrefixedName
    /// <summary>
    ///   <para>bbc:Twitter</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Product</para>
    ///   <para>Represents the official twitter pages of the things the BBC creates content about e.g., the Manchester council twitter account http://twitter.com/ManCityCouncil.</para>
    /// labels<para>Twitter</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/Twitter">http://www.bbc.co.uk/ontologies/bbc/Twitter</seealso>
    let Twitter = Prefixed_Name(bbc, "Twitter") |> PrefixedName
    /// <summary>
    ///   <para>bbc:WebDocumentCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>This class is needed to support the different categories of web documents. This is meant to be extended by the clients with categories of web documents that make sense to their own product. For example, dynamically generated aggregations of content or editorially curated profiles of things.</para>
    /// labels<para>WebDocumentCategory</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/WebDocumentCategory">http://www.bbc.co.uk/ontologies/bbc/WebDocumentCategory</seealso>
    let WebDocumentCategory = Prefixed_Name(bbc, "WebDocumentCategory") |> PrefixedName
    /// <summary>
    ///   <para>bbc:hasOutput</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a regional BBC service with an audience facing output such as a News website.</para>
    /// labels<para>hasOutput</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/hasOutput">http://www.bbc.co.uk/ontologies/bbc/hasOutput</seealso>
    let hasOutput = Prefixed_Name(bbc, "hasOutput") |> PrefixedName
    /// <summary>
    ///   <para>bbc:primaryContentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Inverse of bbc:primaryContent.</para>
    /// labels<para>primaryContentOf</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/primaryContentOf">http://www.bbc.co.uk/ontologies/bbc/primaryContentOf</seealso>
    let primaryContentOf = Prefixed_Name(bbc, "primaryContentOf") |> PrefixedName
    /// <summary>
    ///   <para>bbc:Product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class representing products which create content about things. Within the BBC's scope, this would be one of the ten Future Media Products. Outside the BBC, this could refer to an organisation or company whose web pages we link to. Typically the official web pages of things (e.g., http://www.tomdaley.tv/) or their Wikipedia, Twitter and Facebook pages.</para>
    /// labels<para>Product</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/Product">http://www.bbc.co.uk/ontologies/bbc/Product</seealso>
    let Product = Prefixed_Name(bbc, "Product") |> PrefixedName
    /// <summary>
    ///   <para>bbc:Blogs</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Product</para>
    ///   <para>This instance of bbc:Product is needed to associate WebDocuments from the BBC blogs.</para>
    /// labels<para>Blogs</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/Blogs">http://www.bbc.co.uk/ontologies/bbc/Blogs</seealso>
    let Blogs = Prefixed_Name(bbc, "Blogs") |> PrefixedName
    /// <summary>
    ///   <para>bbc:Facebook</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Product</para>
    ///   <para>Represents the official Facebook pages of the things the BBC creates content about e.g., the Manchester council Facebook account http://www.facebook.com/mancitycouncil.</para>
    /// labels<para>Facebook</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/Facebook">http://www.bbc.co.uk/ontologies/bbc/Facebook</seealso>
    let Facebook = Prefixed_Name(bbc, "Facebook") |> PrefixedName
    /// <summary>
    ///   <para>bbc:Mobile</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Platform</para>
    ///   <para>Represents the web documents designed for a smaller, mobile screen.</para>
    /// labels<para>Mobile</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/Mobile">http://www.bbc.co.uk/ontologies/bbc/Mobile</seealso>
    let Mobile = Prefixed_Name(bbc, "Mobile") |> PrefixedName
    /// <summary>
    ///   <para>bbc:News</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Product</para>
    ///   <para>This instance of bbc:Product is needed to associate WebDocuments from BBC News.</para>
    /// labels<para>News</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/News">http://www.bbc.co.uk/ontologies/bbc/News</seealso>
    let News = Prefixed_Name(bbc, "News") |> PrefixedName
    /// <summary>
    ///   <para>bbc:NewsService</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Class representing a BBC News service, e.g., BBC Guernsey.</para>
    /// labels<para>NewsService</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/NewsService">http://www.bbc.co.uk/ontologies/bbc/NewsService</seealso>
    let NewsService = Prefixed_Name(bbc, "NewsService") |> PrefixedName
    /// <summary>
    ///   <para>bbc:Music</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Product</para>
    ///   <para>This instance of bbc:Product is needed to associate WebDocuments from BBC Music.</para>
    /// labels<para>Music</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/Music">http://www.bbc.co.uk/ontologies/bbc/Music</seealso>
    let Music = Prefixed_Name(bbc, "Music") |> PrefixedName
    /// <summary>
    ///   <para>bbc:WebDocument</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A web document is a page available from a content-negotiable URL on the BBC website or any web document to which the BBC points at.</para>
    /// labels<para>WebDocument</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/WebDocument">http://www.bbc.co.uk/ontologies/bbc/WebDocument</seealso>
    let WebDocument = Prefixed_Name(bbc, "WebDocument") |> PrefixedName
    /// <summary>
    ///   <para>bbc:coveredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a Thing with a regional BBC service which reports on it.</para>
    /// labels<para>coveredBy</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/coveredBy">http://www.bbc.co.uk/ontologies/bbc/coveredBy</seealso>
    let coveredBy = Prefixed_Name(bbc, "coveredBy") |> PrefixedName
    /// <summary>
    ///   <para>bbc:covers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a regional BBC service with a Thing that it regularly reports on.</para>
    /// labels<para>covers</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/covers">http://www.bbc.co.uk/ontologies/bbc/covers</seealso>
    let covers = Prefixed_Name(bbc, "covers") |> PrefixedName
    /// <summary>
    ///   <para>bbc:primaryContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Represents the fact that a web document has as primary content the creative work (e.g., a news story about Tom Daley is the primary content of a webpage).</para>
    /// labels<para>primaryContent</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/primaryContent">http://www.bbc.co.uk/ontologies/bbc/primaryContent</seealso>
    let primaryContent = Prefixed_Name(bbc, "primaryContent") |> PrefixedName
    /// <summary>
    ///   <para>bbc:product</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates the WebDocument with the particular BBC Product it belongs to. This reflects the editorial branding of the product.</para>
    /// labels<para>product</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/product">http://www.bbc.co.uk/ontologies/bbc/product</seealso>
    let product = Prefixed_Name(bbc, "product") |> PrefixedName
    /// <summary>
    ///   <para>bbc:platform</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a web document with one of the platforms for which the WebDocument is appropriate. If the WebDocument is responsive then this property is not used because the WebDocument is appropriate for both platforms. Only one of the two allowed values (bbc:HighWeb, bbc:Mobile) can be used for every WebDocument. Therefore the property is used with at most one value per WebDocument.</para>
    /// labels<para>platform</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/platform">http://www.bbc.co.uk/ontologies/bbc/platform</seealso>
    let platform = Prefixed_Name(bbc, "platform") |> PrefixedName
    /// <summary>
    ///   <para>bbc:serves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a regional BBC service with a populated place that it serves.</para>
    /// labels<para>serves</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/serves">http://www.bbc.co.uk/ontologies/bbc/serves</seealso>
    let serves = Prefixed_Name(bbc, "serves") |> PrefixedName
    /// <summary>
    ///   <para>bbc:servedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a populated place with a regional BBC service that it is served by.</para>
    /// labels<para>servedBy</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/servedBy">http://www.bbc.co.uk/ontologies/bbc/servedBy</seealso>
    let servedBy = Prefixed_Name(bbc, "servedBy") |> PrefixedName
    /// <summary>
    ///   <para>bbc:webDocumentCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Associates a web document with a category as defined by clients.</para>
    /// labels<para>webDocumentCategory</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/webDocumentCategory">http://www.bbc.co.uk/ontologies/bbc/webDocumentCategory</seealso>
    let webDocumentCategory = Prefixed_Name(bbc, "webDocumentCategory") |> PrefixedName
    /// <summary>
    ///   <para>bbc:1.9</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/1.9">http://www.bbc.co.uk/ontologies/bbc/1.9</seealso>
    let ``_1.9`` = Prefixed_Name(bbc, "1.9") |> PrefixedName
    /// <summary>
    ///   <para>bbc:Education</para>
    /// </summary>
    /// <remarks>
    ///   <para>bbc:Product</para>
    ///   <para>This instance of bbc:Product is needed to associate WebDocuments from BBC Education.</para>
    /// labels<para>Education</para></remarks>
    /// <seealso href="http://www.bbc.co.uk/ontologies/bbc/Education">http://www.bbc.co.uk/ontologies/bbc/Education</seealso>
    let Education = Prefixed_Name(bbc, "Education") |> PrefixedName
