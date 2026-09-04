#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module bbc =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.bbc.co.uk/ontologies/bbc/" "bbc"

    let ``_1.10`` = _prefixId.prefix "1.10"
    let ``_1.9`` = _prefixId.prefix "1.9"
    let Blogs = _prefixId.prefix "Blogs"
    let Education = _prefixId.prefix "Education"
    let Facebook = _prefixId.prefix "Facebook"
    let HighWeb = _prefixId.prefix "HighWeb"
    let Mobile = _prefixId.prefix "Mobile"
    let Music = _prefixId.prefix "Music"
    let News = _prefixId.prefix "News"
    /// <summary>
    ///   <para>rdfs:label : NewsService</para>
    ///   <para>rdfs:comment : Class representing a BBC News service, e.g., BBC Guernsey.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/NewsService">bbc:NewsService</a>
    /// </summary>
    let NewsService = _prefixId.prefix "NewsService"
    let OfficialHomepage = _prefixId.prefix "OfficialHomepage"
    /// <summary>
    ///   <para>rdfs:label : Platform</para>
    ///   <para>rdfs:comment : Represents the different types of platforms through which a web document can be accessed. This is needed to derive the correct web document for consumption from the appropriate platform. If there's no specification on platform suitability then the document is considered to be suitable for both.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/Platform">bbc:Platform</a>
    /// </summary>
    let Platform = _prefixId.prefix "Platform"
    /// <summary>
    ///   <para>rdfs:label : Product</para>
    ///   <para>rdfs:comment : Class representing products which create content about things. Within the BBC's scope, this would be one of the ten Future Media Products. Outside the BBC, this could refer to an organisation or company whose web pages we link to. Typically the official web pages of things (e.g., http://www.tomdaley.tv/) or their Wikipedia, Twitter and Facebook pages.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/Product">bbc:Product</a>
    /// </summary>
    let Product = _prefixId.prefix "Product"
    let Sport = _prefixId.prefix "Sport"
    let Twitter = _prefixId.prefix "Twitter"
    /// <summary>
    ///   <para>rdfs:label : WebDocument</para>
    ///   <para>rdfs:comment : A web document is a page available from a content-negotiable URL on the BBC website or any web document to which the BBC points at.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/WebDocument">bbc:WebDocument</a>
    /// </summary>
    let WebDocument = _prefixId.prefix "WebDocument"
    /// <summary>
    ///   <para>rdfs:label : WebDocumentCategory</para>
    ///   <para>rdfs:comment : This class is needed to support the different categories of web documents. This is meant to be extended by the clients with categories of web documents that make sense to their own product. For example, dynamically generated aggregations of content or editorially curated profiles of things.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/WebDocumentCategory">bbc:WebDocumentCategory</a>
    /// </summary>
    let WebDocumentCategory = _prefixId.prefix "WebDocumentCategory"
    /// <summary>
    ///   <para>rdfs:label : coveredBy</para>
    ///   <para>rdfs:comment : Associates a Thing with a regional BBC service which reports on it.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/coveredBy">bbc:coveredBy</a>
    /// </summary>
    let coveredBy = _prefixId.prefix "coveredBy"
    /// <summary>
    ///   <para>rdfs:label : covers</para>
    ///   <para>rdfs:comment : Associates a regional BBC service with a Thing that it regularly reports on.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/covers">bbc:covers</a>
    /// </summary>
    let covers = _prefixId.prefix "covers"
    /// <summary>
    ///   <para>rdfs:label : hasOutput</para>
    ///   <para>rdfs:comment : Associates a regional BBC service with an audience facing output such as a News website.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/hasOutput">bbc:hasOutput</a>
    /// </summary>
    let hasOutput = _prefixId.prefix "hasOutput"
    /// <summary>
    ///   <para>rdfs:label : platform</para>
    ///   <para>rdfs:comment : Associates a web document with one of the platforms for which the WebDocument is appropriate. If the WebDocument is responsive then this property is not used because the WebDocument is appropriate for both platforms. Only one of the two allowed values (bbc:HighWeb, bbc:Mobile) can be used for every WebDocument. Therefore the property is used with at most one value per WebDocument.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/platform">bbc:platform</a>
    /// </summary>
    let platform = _prefixId.prefix "platform"
    /// <summary>
    ///   <para>rdfs:label : primaryContent</para>
    ///   <para>rdfs:comment : Represents the fact that a web document has as primary content the creative work (e.g., a news story about Tom Daley is the primary content of a webpage).</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/primaryContent">bbc:primaryContent</a>
    /// </summary>
    let primaryContent = _prefixId.prefix "primaryContent"
    /// <summary>
    ///   <para>rdfs:label : primaryContentOf</para>
    ///   <para>rdfs:comment : Inverse of bbc:primaryContent.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/primaryContentOf">bbc:primaryContentOf</a>
    /// </summary>
    let primaryContentOf = _prefixId.prefix "primaryContentOf"
    /// <summary>
    ///   <para>rdfs:label : product</para>
    ///   <para>rdfs:comment : Associates the WebDocument with the particular BBC Product it belongs to. This reflects the editorial branding of the product.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/product">bbc:product</a>
    /// </summary>
    let product = _prefixId.prefix "product"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : servedBy</para>
    ///   <para>rdfs:comment : Associates a populated place with a regional BBC service that it is served by.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/servedBy">bbc:servedBy</a>
    /// </summary>
    let servedBy = _prefixId.prefix "servedBy"
    /// <summary>
    ///   <para>rdfs:label : serves</para>
    ///   <para>rdfs:comment : Associates a regional BBC service with a populated place that it serves.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/serves">bbc:serves</a>
    /// </summary>
    let serves = _prefixId.prefix "serves"
    /// <summary>
    ///   <para>rdfs:label : webDocumentCategory</para>
    ///   <para>rdfs:comment : Associates a web document with a category as defined by clients.</para>
    ///   <a href="http://www.bbc.co.uk/ontologies/bbc/webDocumentCategory">bbc:webDocumentCategory</a>
    /// </summary>
    let webDocumentCategory = _prefixId.prefix "webDocumentCategory"
