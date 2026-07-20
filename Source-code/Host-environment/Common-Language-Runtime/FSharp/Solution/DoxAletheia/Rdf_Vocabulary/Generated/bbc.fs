namespace http.www.bbc.co.uk.ontologies.bbc.slash

open DoxAletheia

module bbc =
    let _namespace_name = "http://www.bbc.co.uk/ontologies/bbc/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/bbc/1.9"></see>
    /// </summary>
    let ``_1.9`` = _prefix "1.9"
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/bbc/1.10"></see>
    /// </summary>
    let ``_1.10`` = _prefix "1.10"
    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from the BBC blogs.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Blogs"></see></summary>
    let Blogs = _prefix "Blogs"
    /// <summary>
    /// Class representing products which create content about things. Within the BBC's scope, this would be one of the ten Future Media Products. Outside the BBC, this could refer to an organisation or company whose web pages we link to. Typically the official web pages of things (e.g., http://www.tomdaley.tv/) or their Wikipedia, Twitter and Facebook pages.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Product"></see></summary>
    let Product = _prefix "Product"
    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from BBC Education.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Education"></see></summary>
    let Education = _prefix "Education"
    /// <summary>
    /// Represents the official Facebook pages of the things the BBC creates content about e.g., the Manchester council Facebook account http://www.facebook.com/mancitycouncil.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Facebook"></see></summary>
    let Facebook = _prefix "Facebook"
    /// <summary>
    /// Represents the  web documents designed for a large screen.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/HighWeb"></see></summary>
    let HighWeb = _prefix "HighWeb"
    /// <summary>
    /// Represents the different types of platforms through which a web document can be accessed. This is needed to derive the correct web document for consumption from the appropriate platform. If there's no specification on platform suitability then the document is considered to be suitable for both.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Platform"></see></summary>
    let Platform = _prefix "Platform"
    /// <summary>
    /// Represents the web documents designed for a smaller, mobile screen.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Mobile"></see></summary>
    let Mobile = _prefix "Mobile"
    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from BBC Music.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Music"></see></summary>
    let Music = _prefix "Music"
    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from BBC News.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/News"></see></summary>
    let News = _prefix "News"
    /// <summary>
    /// Class representing a BBC News service, e.g., BBC Guernsey.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/NewsService"></see></summary>
    let NewsService = _prefix "NewsService"
    /// <summary>
    /// Represents the official home pages of the things the BBC creates content about e.g., the Manchester council homepage http://www.manchester.gov.uk.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/OfficialHomepage"></see></summary>
    let OfficialHomepage = _prefix "OfficialHomepage"
    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from BBC Sport.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Sport"></see></summary>
    let Sport = _prefix "Sport"
    /// <summary>
    /// Represents the official twitter pages of the things the BBC creates content about e.g., the Manchester council twitter account http://twitter.com/ManCityCouncil.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Twitter"></see></summary>
    let Twitter = _prefix "Twitter"
    /// <summary>
    /// A web document is a page available from a content-negotiable URL on the BBC website or any web document to which the BBC points at.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/WebDocument"></see></summary>
    let WebDocument = _prefix "WebDocument"
    /// <summary>
    /// This class is needed to support the different categories of web documents. This is meant to be extended by the clients with categories of web documents that make sense to their own product. For example, dynamically generated aggregations of content or editorially curated profiles of things.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/WebDocumentCategory"></see></summary>
    let WebDocumentCategory = _prefix "WebDocumentCategory"
    /// <summary>
    /// Associates a Thing with a regional BBC service which reports on it.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/coveredBy"></see></summary>
    let coveredBy = _prefix "coveredBy"
    /// <summary>
    /// Associates a regional BBC service with a Thing that it regularly reports on.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/covers"></see></summary>
    let covers = _prefix "covers"
    /// <summary>
    /// Associates a regional BBC service with an audience facing output such as a News website.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/hasOutput"></see></summary>
    let hasOutput = _prefix "hasOutput"
    /// <summary>
    /// Associates a web document with one of the platforms for which the WebDocument is appropriate. If the WebDocument is responsive then this property is not used because the WebDocument is appropriate for both platforms. Only one of the two allowed values (bbc:HighWeb, bbc:Mobile) can be used for every WebDocument. Therefore the property is used with at most one value per WebDocument.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/platform"></see></summary>
    let platform = _prefix "platform"
    /// <summary>
    /// Represents the fact that a web document has as primary content the creative work (e.g., a news story about Tom Daley is the primary content of a webpage).
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/primaryContent"></see></summary>
    let primaryContent = _prefix "primaryContent"
    /// <summary>
    /// Inverse of bbc:primaryContent.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/primaryContentOf"></see></summary>
    let primaryContentOf = _prefix "primaryContentOf"
    /// <summary>
    /// Associates the WebDocument with the particular BBC Product it belongs to. This reflects the editorial branding of the product.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/product"></see></summary>
    let product = _prefix "product"
    /// <summary>
    /// Associates a populated place with a regional BBC service that it is served by.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/servedBy"></see></summary>
    let servedBy = _prefix "servedBy"
    /// <summary>
    /// Associates a regional BBC service with a populated place that it serves.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/serves"></see></summary>
    let serves = _prefix "serves"
    /// <summary>
    /// Associates a web document with a category as defined by clients.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/webDocumentCategory"></see></summary>
    let webDocumentCategory = _prefix "webDocumentCategory"
