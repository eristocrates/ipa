namespace http.ns.nature.com.terms.slash

open DoxAletheia

module npg =
    let _namespace_name = "http://ns.nature.com/terms/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/webpage"></see>
    /// </summary>
    let webpage = _prefix "webpage"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Abstract"></see>
    /// </summary>
    let Abstract = _prefix "Abstract"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Component"></see>
    /// </summary>
    let Component = _prefix "Component"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Agent"></see>
    /// </summary>
    let Agent = _prefix "Agent"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Thing"></see>
    /// </summary>
    let Thing = _prefix "Thing"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/AggregationEvent"></see>
    /// </summary>
    let AggregationEvent = _prefix "AggregationEvent"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Event"></see>
    /// </summary>
    let Event = _prefix "Event"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Article"></see>
    /// </summary>
    let Article = _prefix "Article"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Document"></see>
    /// </summary>
    let Document = _prefix "Document"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/ArticleType"></see>
    /// </summary>
    let ArticleType = _prefix "ArticleType"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Type"></see>
    /// </summary>
    let Type = _prefix "Type"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Asset"></see>
    /// </summary>
    let Asset = _prefix "Asset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/BinaryAsset"></see>
    /// </summary>
    let BinaryAsset = _prefix "BinaryAsset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/BlobAsset"></see>
    /// </summary>
    let BlobAsset = _prefix "BlobAsset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Blog"></see>
    /// </summary>
    let Blog = _prefix "Blog"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Serial"></see>
    /// </summary>
    let Serial = _prefix "Serial"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Journal"></see>
    /// </summary>
    let Journal = _prefix "Journal"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Collection"></see>
    /// </summary>
    let Collection = _prefix "Collection"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Publication"></see>
    /// </summary>
    let Publication = _prefix "Publication"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Dataset"></see>
    /// </summary>
    let Dataset = _prefix "Dataset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Concept"></see>
    /// </summary>
    let Concept = _prefix "Concept"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Contributor"></see>
    /// </summary>
    let Contributor = _prefix "Contributor"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Figure"></see>
    /// </summary>
    let Figure = _prefix "Figure"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Illustration"></see>
    /// </summary>
    let Illustration = _prefix "Illustration"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Graph"></see>
    /// </summary>
    let Graph = _prefix "Graph"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/KnowledgeBase"></see>
    /// </summary>
    let KnowledgeBase = _prefix "KnowledgeBase"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/ImageAsset"></see>
    /// </summary>
    let ImageAsset = _prefix "ImageAsset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Issue"></see>
    /// </summary>
    let Issue = _prefix "Issue"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Item"></see>
    /// </summary>
    let Item = _prefix "Item"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Organization"></see>
    /// </summary>
    let Organization = _prefix "Organization"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/PdfAsset"></see>
    /// </summary>
    let PdfAsset = _prefix "PdfAsset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Person"></see>
    /// </summary>
    let Person = _prefix "Person"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/PublicationEvent"></see>
    /// </summary>
    let PublicationEvent = _prefix "PublicationEvent"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/PublishEvent"></see>
    /// </summary>
    let PublishEvent = _prefix "PublishEvent"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/PublishState"></see>
    /// </summary>
    let PublishState = _prefix "PublishState"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Publisher"></see>
    /// </summary>
    let Publisher = _prefix "Publisher"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/ReviewEvent"></see>
    /// </summary>
    let ReviewEvent = _prefix "ReviewEvent"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/ReviewState"></see>
    /// </summary>
    let ReviewState = _prefix "ReviewState"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Section"></see>
    /// </summary>
    let Section = _prefix "Section"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/SeverityLevel"></see>
    /// </summary>
    let SeverityLevel = _prefix "SeverityLevel"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Subject"></see>
    /// </summary>
    let Subject = _prefix "Subject"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Summary"></see>
    /// </summary>
    let Summary = _prefix "Summary"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/SummaryType"></see>
    /// </summary>
    let SummaryType = _prefix "SummaryType"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Technique"></see>
    /// </summary>
    let Technique = _prefix "Technique"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/XmlAsset"></see>
    /// </summary>
    let XmlAsset = _prefix "XmlAsset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/assetVersion"></see>
    /// </summary>
    let assetVersion = _prefix "assetVersion"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/body"></see>
    /// </summary>
    let body = _prefix "body"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/bodyXml"></see>
    /// </summary>
    let bodyXml = _prefix "bodyXml"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/caption"></see>
    /// </summary>
    let caption = _prefix "caption"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/captionXml"></see>
    /// </summary>
    let captionXml = _prefix "captionXml"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/coverDate"></see>
    /// </summary>
    let coverDate = _prefix "coverDate"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/coverYear"></see>
    /// </summary>
    let coverYear = _prefix "coverYear"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/coverYearMonth"></see>
    /// </summary>
    let coverYearMonth = _prefix "coverYearMonth"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/credit"></see>
    /// </summary>
    let credit = _prefix "credit"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/date"></see>
    /// </summary>
    let date = _prefix "date"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/dateTime"></see>
    /// </summary>
    let dateTime = _prefix "dateTime"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/doi"></see>
    /// </summary>
    let doi = _prefix "doi"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/eissn"></see>
    /// </summary>
    let eissn = _prefix "eissn"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/familyName"></see>
    /// </summary>
    let familyName = _prefix "familyName"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/fileExtension"></see>
    /// </summary>
    let fileExtension = _prefix "fileExtension"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/filename"></see>
    /// </summary>
    let filename = _prefix "filename"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/filesize"></see>
    /// </summary>
    let filesize = _prefix "filesize"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/givenName"></see>
    /// </summary>
    let givenName = _prefix "givenName"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasAbstract"></see>
    /// </summary>
    let hasAbstract = _prefix "hasAbstract"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasArticle"></see>
    /// </summary>
    let hasArticle = _prefix "hasArticle"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasArticleType"></see>
    /// </summary>
    let hasArticleType = _prefix "hasArticleType"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasBroaderSubject"></see>
    /// </summary>
    let hasBroaderSubject = _prefix "hasBroaderSubject"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasSubject"></see>
    /// </summary>
    let hasSubject = _prefix "hasSubject"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasCollection"></see>
    /// </summary>
    let hasCollection = _prefix "hasCollection"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasContributor"></see>
    /// </summary>
    let hasContributor = _prefix "hasContributor"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasFigure"></see>
    /// </summary>
    let hasFigure = _prefix "hasFigure"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasIllustration"></see>
    /// </summary>
    let hasIllustration = _prefix "hasIllustration"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasImage"></see>
    /// </summary>
    let hasImage = _prefix "hasImage"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasImageAsset"></see>
    /// </summary>
    let hasImageAsset = _prefix "hasImageAsset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasIssue"></see>
    /// </summary>
    let hasIssue = _prefix "hasIssue"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasItem"></see>
    /// </summary>
    let hasItem = _prefix "hasItem"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPdfAsset"></see>
    /// </summary>
    let hasPdfAsset = _prefix "hasPdfAsset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPrimaryArticleType"></see>
    /// </summary>
    let hasPrimaryArticleType = _prefix "hasPrimaryArticleType"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPublication"></see>
    /// </summary>
    let hasPublication = _prefix "hasPublication"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPublishEvent"></see>
    /// </summary>
    let hasPublishEvent = _prefix "hasPublishEvent"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPublishState"></see>
    /// </summary>
    let hasPublishState = _prefix "hasPublishState"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPublisher"></see>
    /// </summary>
    let hasPublisher = _prefix "hasPublisher"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasRoot"></see>
    /// </summary>
    let hasRoot = _prefix "hasRoot"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasSection"></see>
    /// </summary>
    let hasSection = _prefix "hasSection"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasSummary"></see>
    /// </summary>
    let hasSummary = _prefix "hasSummary"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasSummaryType"></see>
    /// </summary>
    let hasSummaryType = _prefix "hasSummaryType"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasTechnique"></see>
    /// </summary>
    let hasTechnique = _prefix "hasTechnique"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasXmlAsset"></see>
    /// </summary>
    let hasXmlAsset = _prefix "hasXmlAsset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/id"></see>
    /// </summary>
    let id = _prefix "id"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isAssetOf"></see>
    /// </summary>
    let isAssetOf = _prefix "isAssetOf"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasAsset"></see>
    /// </summary>
    let hasAsset = _prefix "hasAsset"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isCorresponding"></see>
    /// </summary>
    let isCorresponding = _prefix "isCorresponding"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isCurated"></see>
    /// </summary>
    let isCurated = _prefix "isCurated"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isLeaf"></see>
    /// </summary>
    let isLeaf = _prefix "isLeaf"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isPrimaryArticleType"></see>
    /// </summary>
    let isPrimaryArticleType = _prefix "isPrimaryArticleType"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isRoot"></see>
    /// </summary>
    let isRoot = _prefix "isRoot"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/issn"></see>
    /// </summary>
    let issn = _prefix "issn"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/issue"></see>
    /// </summary>
    let issue = _prefix "issue"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/name"></see>
    /// </summary>
    let name = _prefix "name"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/namespace"></see>
    /// </summary>
    let namespace_ = _prefix "namespace"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/number"></see>
    /// </summary>
    let number = _prefix "number"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/pageEnd"></see>
    /// </summary>
    let pageEnd = _prefix "pageEnd"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/pageStart"></see>
    /// </summary>
    let pageStart = _prefix "pageStart"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/pages"></see>
    /// </summary>
    let pages = _prefix "pages"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/publicationDate"></see>
    /// </summary>
    let publicationDate = _prefix "publicationDate"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/publicationDateTime"></see>
    /// </summary>
    let publicationDateTime = _prefix "publicationDateTime"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/publicationYear"></see>
    /// </summary>
    let publicationYear = _prefix "publicationYear"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/publicationYearMonth"></see>
    /// </summary>
    let publicationYearMonth = _prefix "publicationYearMonth"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/replacedBy"></see>
    /// </summary>
    let replacedBy = _prefix "replacedBy"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/replaces"></see>
    /// </summary>
    let replaces = _prefix "replaces"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/repository"></see>
    /// </summary>
    let repository = _prefix "repository"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/repositoryId"></see>
    /// </summary>
    let repositoryId = _prefix "repositoryId"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/shortTitle"></see>
    /// </summary>
    let shortTitle = _prefix "shortTitle"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/title"></see>
    /// </summary>
    let title = _prefix "title"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/titleXml"></see>
    /// </summary>
    let titleXml = _prefix "titleXml"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/treeDepth"></see>
    /// </summary>
    let treeDepth = _prefix "treeDepth"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/volume"></see>
    /// </summary>
    let volume = _prefix "volume"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/year"></see>
    /// </summary>
    let year = _prefix "year"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/yearMonth"></see>
    /// </summary>
    let yearMonth = _prefix "yearMonth"
