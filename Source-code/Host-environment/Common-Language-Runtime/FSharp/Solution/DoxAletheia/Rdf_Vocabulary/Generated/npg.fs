namespace http.ns.nature.com.terms.slash

open DoxAletheia.Rdf_Vocabulary

module npg =
    let _namespace_name = "http://ns.nature.com/terms/"
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/webpage"></see>
    /// </summary>
    let webpage = Namespaced_IRI.parse _namespace_name "webpage" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Abstract"></see>
    /// </summary>
    let Abstract = Namespaced_IRI.parse _namespace_name "Abstract" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Component"></see>
    /// </summary>
    let Component = Namespaced_IRI.parse _namespace_name "Component" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Agent"></see>
    /// </summary>
    let Agent = Namespaced_IRI.parse _namespace_name "Agent" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Thing"></see>
    /// </summary>
    let Thing = Namespaced_IRI.parse _namespace_name "Thing" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/AggregationEvent"></see>
    /// </summary>
    let AggregationEvent =
        Namespaced_IRI.parse _namespace_name "AggregationEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Event"></see>
    /// </summary>
    let Event = Namespaced_IRI.parse _namespace_name "Event" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Article"></see>
    /// </summary>
    let Article = Namespaced_IRI.parse _namespace_name "Article" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Document"></see>
    /// </summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/ArticleType"></see>
    /// </summary>
    let ArticleType =
        Namespaced_IRI.parse _namespace_name "ArticleType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Type"></see>
    /// </summary>
    let Type = Namespaced_IRI.parse _namespace_name "Type" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Asset"></see>
    /// </summary>
    let Asset = Namespaced_IRI.parse _namespace_name "Asset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/BinaryAsset"></see>
    /// </summary>
    let BinaryAsset =
        Namespaced_IRI.parse _namespace_name "BinaryAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/BlobAsset"></see>
    /// </summary>
    let BlobAsset = Namespaced_IRI.parse _namespace_name "BlobAsset" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Blog"></see>
    /// </summary>
    let Blog = Namespaced_IRI.parse _namespace_name "Blog" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Serial"></see>
    /// </summary>
    let Serial = Namespaced_IRI.parse _namespace_name "Serial" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Journal"></see>
    /// </summary>
    let Journal = Namespaced_IRI.parse _namespace_name "Journal" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Collection"></see>
    /// </summary>
    let Collection = Namespaced_IRI.parse _namespace_name "Collection" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Publication"></see>
    /// </summary>
    let Publication =
        Namespaced_IRI.parse _namespace_name "Publication" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Dataset"></see>
    /// </summary>
    let Dataset = Namespaced_IRI.parse _namespace_name "Dataset" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Concept"></see>
    /// </summary>
    let Concept = Namespaced_IRI.parse _namespace_name "Concept" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Contributor"></see>
    /// </summary>
    let Contributor =
        Namespaced_IRI.parse _namespace_name "Contributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Figure"></see>
    /// </summary>
    let Figure = Namespaced_IRI.parse _namespace_name "Figure" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Illustration"></see>
    /// </summary>
    let Illustration =
        Namespaced_IRI.parse _namespace_name "Illustration" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Graph"></see>
    /// </summary>
    let Graph = Namespaced_IRI.parse _namespace_name "Graph" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/KnowledgeBase"></see>
    /// </summary>
    let KnowledgeBase =
        Namespaced_IRI.parse _namespace_name "KnowledgeBase" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/ImageAsset"></see>
    /// </summary>
    let ImageAsset = Namespaced_IRI.parse _namespace_name "ImageAsset" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Issue"></see>
    /// </summary>
    let Issue = Namespaced_IRI.parse _namespace_name "Issue" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Item"></see>
    /// </summary>
    let Item = Namespaced_IRI.parse _namespace_name "Item" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Organization"></see>
    /// </summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/PdfAsset"></see>
    /// </summary>
    let PdfAsset = Namespaced_IRI.parse _namespace_name "PdfAsset" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Person"></see>
    /// </summary>
    let Person = Namespaced_IRI.parse _namespace_name "Person" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/PublicationEvent"></see>
    /// </summary>
    let PublicationEvent =
        Namespaced_IRI.parse _namespace_name "PublicationEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/PublishEvent"></see>
    /// </summary>
    let PublishEvent =
        Namespaced_IRI.parse _namespace_name "PublishEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/PublishState"></see>
    /// </summary>
    let PublishState =
        Namespaced_IRI.parse _namespace_name "PublishState" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Publisher"></see>
    /// </summary>
    let Publisher = Namespaced_IRI.parse _namespace_name "Publisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/ReviewEvent"></see>
    /// </summary>
    let ReviewEvent =
        Namespaced_IRI.parse _namespace_name "ReviewEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/ReviewState"></see>
    /// </summary>
    let ReviewState =
        Namespaced_IRI.parse _namespace_name "ReviewState" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Section"></see>
    /// </summary>
    let Section = Namespaced_IRI.parse _namespace_name "Section" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/SeverityLevel"></see>
    /// </summary>
    let SeverityLevel =
        Namespaced_IRI.parse _namespace_name "SeverityLevel" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Subject"></see>
    /// </summary>
    let Subject = Namespaced_IRI.parse _namespace_name "Subject" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Summary"></see>
    /// </summary>
    let Summary = Namespaced_IRI.parse _namespace_name "Summary" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/SummaryType"></see>
    /// </summary>
    let SummaryType =
        Namespaced_IRI.parse _namespace_name "SummaryType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/Technique"></see>
    /// </summary>
    let Technique = Namespaced_IRI.parse _namespace_name "Technique" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/XmlAsset"></see>
    /// </summary>
    let XmlAsset = Namespaced_IRI.parse _namespace_name "XmlAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/assetVersion"></see>
    /// </summary>
    let assetVersion =
        Namespaced_IRI.parse _namespace_name "assetVersion" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/body"></see>
    /// </summary>
    let body = Namespaced_IRI.parse _namespace_name "body" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/bodyXml"></see>
    /// </summary>
    let bodyXml = Namespaced_IRI.parse _namespace_name "bodyXml" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/caption"></see>
    /// </summary>
    let caption = Namespaced_IRI.parse _namespace_name "caption" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/captionXml"></see>
    /// </summary>
    let captionXml = Namespaced_IRI.parse _namespace_name "captionXml" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/coverDate"></see>
    /// </summary>
    let coverDate = Namespaced_IRI.parse _namespace_name "coverDate" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/coverYear"></see>
    /// </summary>
    let coverYear = Namespaced_IRI.parse _namespace_name "coverYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/coverYearMonth"></see>
    /// </summary>
    let coverYearMonth =
        Namespaced_IRI.parse _namespace_name "coverYearMonth" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/credit"></see>
    /// </summary>
    let credit = Namespaced_IRI.parse _namespace_name "credit" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/date"></see>
    /// </summary>
    let date = Namespaced_IRI.parse _namespace_name "date" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/dateTime"></see>
    /// </summary>
    let dateTime = Namespaced_IRI.parse _namespace_name "dateTime" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/doi"></see>
    /// </summary>
    let doi = Namespaced_IRI.parse _namespace_name "doi" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/eissn"></see>
    /// </summary>
    let eissn = Namespaced_IRI.parse _namespace_name "eissn" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/familyName"></see>
    /// </summary>
    let familyName = Namespaced_IRI.parse _namespace_name "familyName" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/fileExtension"></see>
    /// </summary>
    let fileExtension =
        Namespaced_IRI.parse _namespace_name "fileExtension" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/filename"></see>
    /// </summary>
    let filename = Namespaced_IRI.parse _namespace_name "filename" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/filesize"></see>
    /// </summary>
    let filesize = Namespaced_IRI.parse _namespace_name "filesize" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/givenName"></see>
    /// </summary>
    let givenName = Namespaced_IRI.parse _namespace_name "givenName" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasAbstract"></see>
    /// </summary>
    let hasAbstract =
        Namespaced_IRI.parse _namespace_name "hasAbstract" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasArticle"></see>
    /// </summary>
    let hasArticle = Namespaced_IRI.parse _namespace_name "hasArticle" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasArticleType"></see>
    /// </summary>
    let hasArticleType =
        Namespaced_IRI.parse _namespace_name "hasArticleType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasBroaderSubject"></see>
    /// </summary>
    let hasBroaderSubject =
        Namespaced_IRI.parse _namespace_name "hasBroaderSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasSubject"></see>
    /// </summary>
    let hasSubject = Namespaced_IRI.parse _namespace_name "hasSubject" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasCollection"></see>
    /// </summary>
    let hasCollection =
        Namespaced_IRI.parse _namespace_name "hasCollection" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasContributor"></see>
    /// </summary>
    let hasContributor =
        Namespaced_IRI.parse _namespace_name "hasContributor" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasFigure"></see>
    /// </summary>
    let hasFigure = Namespaced_IRI.parse _namespace_name "hasFigure" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasIllustration"></see>
    /// </summary>
    let hasIllustration =
        Namespaced_IRI.parse _namespace_name "hasIllustration" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasImage"></see>
    /// </summary>
    let hasImage = Namespaced_IRI.parse _namespace_name "hasImage" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasImageAsset"></see>
    /// </summary>
    let hasImageAsset =
        Namespaced_IRI.parse _namespace_name "hasImageAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasIssue"></see>
    /// </summary>
    let hasIssue = Namespaced_IRI.parse _namespace_name "hasIssue" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasItem"></see>
    /// </summary>
    let hasItem = Namespaced_IRI.parse _namespace_name "hasItem" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPdfAsset"></see>
    /// </summary>
    let hasPdfAsset =
        Namespaced_IRI.parse _namespace_name "hasPdfAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPrimaryArticleType"></see>
    /// </summary>
    let hasPrimaryArticleType =
        Namespaced_IRI.parse _namespace_name "hasPrimaryArticleType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPublication"></see>
    /// </summary>
    let hasPublication =
        Namespaced_IRI.parse _namespace_name "hasPublication" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPublishEvent"></see>
    /// </summary>
    let hasPublishEvent =
        Namespaced_IRI.parse _namespace_name "hasPublishEvent" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPublishState"></see>
    /// </summary>
    let hasPublishState =
        Namespaced_IRI.parse _namespace_name "hasPublishState" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasPublisher"></see>
    /// </summary>
    let hasPublisher =
        Namespaced_IRI.parse _namespace_name "hasPublisher" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasRoot"></see>
    /// </summary>
    let hasRoot = Namespaced_IRI.parse _namespace_name "hasRoot" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasSection"></see>
    /// </summary>
    let hasSection = Namespaced_IRI.parse _namespace_name "hasSection" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasSummary"></see>
    /// </summary>
    let hasSummary = Namespaced_IRI.parse _namespace_name "hasSummary" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasSummaryType"></see>
    /// </summary>
    let hasSummaryType =
        Namespaced_IRI.parse _namespace_name "hasSummaryType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasTechnique"></see>
    /// </summary>
    let hasTechnique =
        Namespaced_IRI.parse _namespace_name "hasTechnique" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasXmlAsset"></see>
    /// </summary>
    let hasXmlAsset =
        Namespaced_IRI.parse _namespace_name "hasXmlAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/id"></see>
    /// </summary>
    let id = Namespaced_IRI.parse _namespace_name "id" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isAssetOf"></see>
    /// </summary>
    let isAssetOf = Namespaced_IRI.parse _namespace_name "isAssetOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/hasAsset"></see>
    /// </summary>
    let hasAsset = Namespaced_IRI.parse _namespace_name "hasAsset" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isCorresponding"></see>
    /// </summary>
    let isCorresponding =
        Namespaced_IRI.parse _namespace_name "isCorresponding" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isCurated"></see>
    /// </summary>
    let isCurated = Namespaced_IRI.parse _namespace_name "isCurated" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isLeaf"></see>
    /// </summary>
    let isLeaf = Namespaced_IRI.parse _namespace_name "isLeaf" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isPrimaryArticleType"></see>
    /// </summary>
    let isPrimaryArticleType =
        Namespaced_IRI.parse _namespace_name "isPrimaryArticleType" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/isRoot"></see>
    /// </summary>
    let isRoot = Namespaced_IRI.parse _namespace_name "isRoot" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/issn"></see>
    /// </summary>
    let issn = Namespaced_IRI.parse _namespace_name "issn" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/issue"></see>
    /// </summary>
    let issue = Namespaced_IRI.parse _namespace_name "issue" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/name"></see>
    /// </summary>
    let name = Namespaced_IRI.parse _namespace_name "name" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/namespace"></see>
    /// </summary>
    let namespace_ = Namespaced_IRI.parse _namespace_name "namespace" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/number"></see>
    /// </summary>
    let number = Namespaced_IRI.parse _namespace_name "number" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/pageEnd"></see>
    /// </summary>
    let pageEnd = Namespaced_IRI.parse _namespace_name "pageEnd" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/pageStart"></see>
    /// </summary>
    let pageStart = Namespaced_IRI.parse _namespace_name "pageStart" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/pages"></see>
    /// </summary>
    let pages = Namespaced_IRI.parse _namespace_name "pages" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/publicationDate"></see>
    /// </summary>
    let publicationDate =
        Namespaced_IRI.parse _namespace_name "publicationDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/publicationDateTime"></see>
    /// </summary>
    let publicationDateTime =
        Namespaced_IRI.parse _namespace_name "publicationDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/publicationYear"></see>
    /// </summary>
    let publicationYear =
        Namespaced_IRI.parse _namespace_name "publicationYear" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/publicationYearMonth"></see>
    /// </summary>
    let publicationYearMonth =
        Namespaced_IRI.parse _namespace_name "publicationYearMonth" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/replacedBy"></see>
    /// </summary>
    let replacedBy = Namespaced_IRI.parse _namespace_name "replacedBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/replaces"></see>
    /// </summary>
    let replaces = Namespaced_IRI.parse _namespace_name "replaces" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/repository"></see>
    /// </summary>
    let repository = Namespaced_IRI.parse _namespace_name "repository" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/repositoryId"></see>
    /// </summary>
    let repositoryId =
        Namespaced_IRI.parse _namespace_name "repositoryId" |> NamespacedName

    /// <summary>
    ///   <see href="http://ns.nature.com/terms/shortTitle"></see>
    /// </summary>
    let shortTitle = Namespaced_IRI.parse _namespace_name "shortTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/title"></see>
    /// </summary>
    let title = Namespaced_IRI.parse _namespace_name "title" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/titleXml"></see>
    /// </summary>
    let titleXml = Namespaced_IRI.parse _namespace_name "titleXml" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/treeDepth"></see>
    /// </summary>
    let treeDepth = Namespaced_IRI.parse _namespace_name "treeDepth" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/volume"></see>
    /// </summary>
    let volume = Namespaced_IRI.parse _namespace_name "volume" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/year"></see>
    /// </summary>
    let year = Namespaced_IRI.parse _namespace_name "year" |> NamespacedName
    /// <summary>
    ///   <see href="http://ns.nature.com/terms/yearMonth"></see>
    /// </summary>
    let yearMonth = Namespaced_IRI.parse _namespace_name "yearMonth" |> NamespacedName
