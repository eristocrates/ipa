namespace http.www.bbc.co.uk.ontologies.bbc.slash

open DoxAletheia.Rdf_Vocabulary

module bbc =
    let _namespace_name = "http://www.bbc.co.uk/ontologies/bbc/"
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/bbc/1.9"></see>
    /// </summary>
    let ``_1.9`` = Namespaced_IRI.parse _namespace_name "1.9" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.bbc.co.uk/ontologies/bbc/1.10"></see>
    /// </summary>
    let ``_1.10`` = Namespaced_IRI.parse _namespace_name "1.10" |> NamespacedName
    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from the BBC blogs.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Blogs"></see></summary>
    let Blogs = Namespaced_IRI.parse _namespace_name "Blogs" |> NamespacedName
    /// <summary>
    /// Class representing products which create content about things. Within the BBC's scope, this would be one of the ten Future Media Products. Outside the BBC, this could refer to an organisation or company whose web pages we link to. Typically the official web pages of things (e.g., http://www.tomdaley.tv/) or their Wikipedia, Twitter and Facebook pages.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Product"></see></summary>
    let Product = Namespaced_IRI.parse _namespace_name "Product" |> NamespacedName
    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from BBC Education.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Education"></see></summary>
    let Education = Namespaced_IRI.parse _namespace_name "Education" |> NamespacedName
    /// <summary>
    /// Represents the official Facebook pages of the things the BBC creates content about e.g., the Manchester council Facebook account http://www.facebook.com/mancitycouncil.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Facebook"></see></summary>
    let Facebook = Namespaced_IRI.parse _namespace_name "Facebook" |> NamespacedName
    /// <summary>
    /// Represents the  web documents designed for a large screen.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/HighWeb"></see></summary>
    let HighWeb = Namespaced_IRI.parse _namespace_name "HighWeb" |> NamespacedName
    /// <summary>
    /// Represents the different types of platforms through which a web document can be accessed. This is needed to derive the correct web document for consumption from the appropriate platform. If there's no specification on platform suitability then the document is considered to be suitable for both.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Platform"></see></summary>
    let Platform = Namespaced_IRI.parse _namespace_name "Platform" |> NamespacedName
    /// <summary>
    /// Represents the web documents designed for a smaller, mobile screen.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Mobile"></see></summary>
    let Mobile = Namespaced_IRI.parse _namespace_name "Mobile" |> NamespacedName
    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from BBC Music.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Music"></see></summary>
    let Music = Namespaced_IRI.parse _namespace_name "Music" |> NamespacedName
    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from BBC News.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/News"></see></summary>
    let News = Namespaced_IRI.parse _namespace_name "News" |> NamespacedName

    /// <summary>
    /// Class representing a BBC News service, e.g., BBC Guernsey.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/NewsService"></see></summary>
    let NewsService =
        Namespaced_IRI.parse _namespace_name "NewsService" |> NamespacedName

    /// <summary>
    /// Represents the official home pages of the things the BBC creates content about e.g., the Manchester council homepage http://www.manchester.gov.uk.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/OfficialHomepage"></see></summary>
    let OfficialHomepage =
        Namespaced_IRI.parse _namespace_name "OfficialHomepage" |> NamespacedName

    /// <summary>
    /// This instance of bbc:Product is needed to associate WebDocuments from BBC Sport.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Sport"></see></summary>
    let Sport = Namespaced_IRI.parse _namespace_name "Sport" |> NamespacedName
    /// <summary>
    /// Represents the official twitter pages of the things the BBC creates content about e.g., the Manchester council twitter account http://twitter.com/ManCityCouncil.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/Twitter"></see></summary>
    let Twitter = Namespaced_IRI.parse _namespace_name "Twitter" |> NamespacedName

    /// <summary>
    /// A web document is a page available from a content-negotiable URL on the BBC website or any web document to which the BBC points at.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/WebDocument"></see></summary>
    let WebDocument =
        Namespaced_IRI.parse _namespace_name "WebDocument" |> NamespacedName

    /// <summary>
    /// This class is needed to support the different categories of web documents. This is meant to be extended by the clients with categories of web documents that make sense to their own product. For example, dynamically generated aggregations of content or editorially curated profiles of things.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/WebDocumentCategory"></see></summary>
    let WebDocumentCategory =
        Namespaced_IRI.parse _namespace_name "WebDocumentCategory" |> NamespacedName

    /// <summary>
    /// Associates a Thing with a regional BBC service which reports on it.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/coveredBy"></see></summary>
    let coveredBy = Namespaced_IRI.parse _namespace_name "coveredBy" |> NamespacedName
    /// <summary>
    /// Associates a regional BBC service with a Thing that it regularly reports on.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/covers"></see></summary>
    let covers = Namespaced_IRI.parse _namespace_name "covers" |> NamespacedName
    /// <summary>
    /// Associates a regional BBC service with an audience facing output such as a News website.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/hasOutput"></see></summary>
    let hasOutput = Namespaced_IRI.parse _namespace_name "hasOutput" |> NamespacedName
    /// <summary>
    /// Associates a web document with one of the platforms for which the WebDocument is appropriate. If the WebDocument is responsive then this property is not used because the WebDocument is appropriate for both platforms. Only one of the two allowed values (bbc:HighWeb, bbc:Mobile) can be used for every WebDocument. Therefore the property is used with at most one value per WebDocument.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/platform"></see></summary>
    let platform = Namespaced_IRI.parse _namespace_name "platform" |> NamespacedName

    /// <summary>
    /// Represents the fact that a web document has as primary content the creative work (e.g., a news story about Tom Daley is the primary content of a webpage).
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/primaryContent"></see></summary>
    let primaryContent =
        Namespaced_IRI.parse _namespace_name "primaryContent" |> NamespacedName

    /// <summary>
    /// Inverse of bbc:primaryContent.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/primaryContentOf"></see></summary>
    let primaryContentOf =
        Namespaced_IRI.parse _namespace_name "primaryContentOf" |> NamespacedName

    /// <summary>
    /// Associates the WebDocument with the particular BBC Product it belongs to. This reflects the editorial branding of the product.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/product"></see></summary>
    let product = Namespaced_IRI.parse _namespace_name "product" |> NamespacedName
    /// <summary>
    /// Associates a populated place with a regional BBC service that it is served by.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/servedBy"></see></summary>
    let servedBy = Namespaced_IRI.parse _namespace_name "servedBy" |> NamespacedName
    /// <summary>
    /// Associates a regional BBC service with a populated place that it serves.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/serves"></see></summary>
    let serves = Namespaced_IRI.parse _namespace_name "serves" |> NamespacedName

    /// <summary>
    /// Associates a web document with a category as defined by clients.
    /// <see href="http://www.bbc.co.uk/ontologies/bbc/webDocumentCategory"></see></summary>
    let webDocumentCategory =
        Namespaced_IRI.parse _namespace_name "webDocumentCategory" |> NamespacedName
