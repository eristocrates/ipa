namespace http.ns.nature.com.terms.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module npg =
    let _namespace_iri = Namespace_Iri npg |> NamespaceIRI
    /// <summary>
    ///   <para>npg:webpage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/webpage">http://ns.nature.com/terms/webpage</seealso>
    let webpage = Prefixed_Name(npg, "webpage") |> PrefixedName
    /// <summary>
    ///   <para>npg:repository</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/repository">http://ns.nature.com/terms/repository</seealso>
    let repository = Prefixed_Name(npg, "repository") |> PrefixedName
    /// <summary>
    ///   <para>npg:repositoryId</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/repositoryId">http://ns.nature.com/terms/repositoryId</seealso>
    let repositoryId = Prefixed_Name(npg, "repositoryId") |> PrefixedName
    /// <summary>
    ///   <para>npg:shortTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/shortTitle">http://ns.nature.com/terms/shortTitle</seealso>
    let shortTitle = Prefixed_Name(npg, "shortTitle") |> PrefixedName
    /// <summary>
    ///   <para>npg:Thing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Thing">http://ns.nature.com/terms/Thing</seealso>
    let Thing = Prefixed_Name(npg, "Thing") |> PrefixedName
    /// <summary>
    ///   <para>npg:XmlAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/XmlAsset">http://ns.nature.com/terms/XmlAsset</seealso>
    let XmlAsset = Prefixed_Name(npg, "XmlAsset") |> PrefixedName
    /// <summary>
    ///   <para>npg:assetVersion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/assetVersion">http://ns.nature.com/terms/assetVersion</seealso>
    let assetVersion = Prefixed_Name(npg, "assetVersion") |> PrefixedName
    /// <summary>
    ///   <para>npg:body</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/body">http://ns.nature.com/terms/body</seealso>
    let body = Prefixed_Name(npg, "body") |> PrefixedName
    /// <summary>
    ///   <para>npg:captionXml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/captionXml">http://ns.nature.com/terms/captionXml</seealso>
    let captionXml = Prefixed_Name(npg, "captionXml") |> PrefixedName
    /// <summary>
    ///   <para>npg:coverDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/coverDate">http://ns.nature.com/terms/coverDate</seealso>
    let coverDate = Prefixed_Name(npg, "coverDate") |> PrefixedName
    /// <summary>
    ///   <para>npg:coverYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/coverYear">http://ns.nature.com/terms/coverYear</seealso>
    let coverYear = Prefixed_Name(npg, "coverYear") |> PrefixedName
    /// <summary>
    ///   <para>npg:coverYearMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/coverYearMonth">http://ns.nature.com/terms/coverYearMonth</seealso>
    let coverYearMonth = Prefixed_Name(npg, "coverYearMonth") |> PrefixedName
    /// <summary>
    ///   <para>npg:credit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/credit">http://ns.nature.com/terms/credit</seealso>
    let credit = Prefixed_Name(npg, "credit") |> PrefixedName
    /// <summary>
    ///   <para>npg:date</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/date">http://ns.nature.com/terms/date</seealso>
    let date = Prefixed_Name(npg, "date") |> PrefixedName
    /// <summary>
    ///   <para>npg:doi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/doi">http://ns.nature.com/terms/doi</seealso>
    let doi = Prefixed_Name(npg, "doi") |> PrefixedName
    /// <summary>
    ///   <para>npg:familyName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/familyName">http://ns.nature.com/terms/familyName</seealso>
    let familyName = Prefixed_Name(npg, "familyName") |> PrefixedName
    /// <summary>
    ///   <para>npg:filename</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/filename">http://ns.nature.com/terms/filename</seealso>
    let filename = Prefixed_Name(npg, "filename") |> PrefixedName
    /// <summary>
    ///   <para>npg:filesize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/filesize">http://ns.nature.com/terms/filesize</seealso>
    let filesize = Prefixed_Name(npg, "filesize") |> PrefixedName
    /// <summary>
    ///   <para>npg:givenName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/givenName">http://ns.nature.com/terms/givenName</seealso>
    let givenName = Prefixed_Name(npg, "givenName") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasAbstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasAbstract">http://ns.nature.com/terms/hasAbstract</seealso>
    let hasAbstract = Prefixed_Name(npg, "hasAbstract") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasArticle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasArticle">http://ns.nature.com/terms/hasArticle</seealso>
    let hasArticle = Prefixed_Name(npg, "hasArticle") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasArticleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasArticleType">http://ns.nature.com/terms/hasArticleType</seealso>
    let hasArticleType = Prefixed_Name(npg, "hasArticleType") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasBroaderSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasBroaderSubject">http://ns.nature.com/terms/hasBroaderSubject</seealso>
    let hasBroaderSubject = Prefixed_Name(npg, "hasBroaderSubject") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasCollection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasCollection">http://ns.nature.com/terms/hasCollection</seealso>
    let hasCollection = Prefixed_Name(npg, "hasCollection") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasContributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasContributor">http://ns.nature.com/terms/hasContributor</seealso>
    let hasContributor = Prefixed_Name(npg, "hasContributor") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasFigure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasFigure">http://ns.nature.com/terms/hasFigure</seealso>
    let hasFigure = Prefixed_Name(npg, "hasFigure") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasIllustration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasIllustration">http://ns.nature.com/terms/hasIllustration</seealso>
    let hasIllustration = Prefixed_Name(npg, "hasIllustration") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasImage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasImage">http://ns.nature.com/terms/hasImage</seealso>
    let hasImage = Prefixed_Name(npg, "hasImage") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasImageAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasImageAsset">http://ns.nature.com/terms/hasImageAsset</seealso>
    let hasImageAsset = Prefixed_Name(npg, "hasImageAsset") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasIssue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasIssue">http://ns.nature.com/terms/hasIssue</seealso>
    let hasIssue = Prefixed_Name(npg, "hasIssue") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasItem">http://ns.nature.com/terms/hasItem</seealso>
    let hasItem = Prefixed_Name(npg, "hasItem") |> PrefixedName

    /// <summary>
    ///   <para>npg:hasPrimaryArticleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasPrimaryArticleType">http://ns.nature.com/terms/hasPrimaryArticleType</seealso>
    let hasPrimaryArticleType =
        Prefixed_Name(npg, "hasPrimaryArticleType") |> PrefixedName

    /// <summary>
    ///   <para>npg:hasPublication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasPublication">http://ns.nature.com/terms/hasPublication</seealso>
    let hasPublication = Prefixed_Name(npg, "hasPublication") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasPublishState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasPublishState">http://ns.nature.com/terms/hasPublishState</seealso>
    let hasPublishState = Prefixed_Name(npg, "hasPublishState") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasPublisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasPublisher">http://ns.nature.com/terms/hasPublisher</seealso>
    let hasPublisher = Prefixed_Name(npg, "hasPublisher") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasSection">http://ns.nature.com/terms/hasSection</seealso>
    let hasSection = Prefixed_Name(npg, "hasSection") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasSummary">http://ns.nature.com/terms/hasSummary</seealso>
    let hasSummary = Prefixed_Name(npg, "hasSummary") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasSummaryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasSummaryType">http://ns.nature.com/terms/hasSummaryType</seealso>
    let hasSummaryType = Prefixed_Name(npg, "hasSummaryType") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasTechnique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasTechnique">http://ns.nature.com/terms/hasTechnique</seealso>
    let hasTechnique = Prefixed_Name(npg, "hasTechnique") |> PrefixedName
    /// <summary>
    ///   <para>npg:id</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/id">http://ns.nature.com/terms/id</seealso>
    let id = Prefixed_Name(npg, "id") |> PrefixedName
    /// <summary>
    ///   <para>npg:isAssetOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/isAssetOf">http://ns.nature.com/terms/isAssetOf</seealso>
    let isAssetOf = Prefixed_Name(npg, "isAssetOf") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasAsset</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://ns.nature.com/terms/hasAsset">http://ns.nature.com/terms/hasAsset</seealso>
    let hasAsset = Prefixed_Name(npg, "hasAsset") |> PrefixedName
    /// <summary>
    ///   <para>npg:isCorresponding</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/isCorresponding">http://ns.nature.com/terms/isCorresponding</seealso>
    let isCorresponding = Prefixed_Name(npg, "isCorresponding") |> PrefixedName
    /// <summary>
    ///   <para>npg:isCurated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/isCurated">http://ns.nature.com/terms/isCurated</seealso>
    let isCurated = Prefixed_Name(npg, "isCurated") |> PrefixedName

    /// <summary>
    ///   <para>npg:isPrimaryArticleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/isPrimaryArticleType">http://ns.nature.com/terms/isPrimaryArticleType</seealso>
    let isPrimaryArticleType =
        Prefixed_Name(npg, "isPrimaryArticleType") |> PrefixedName

    /// <summary>
    ///   <para>npg:isRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/isRoot">http://ns.nature.com/terms/isRoot</seealso>
    let isRoot = Prefixed_Name(npg, "isRoot") |> PrefixedName
    /// <summary>
    ///   <para>npg:issn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/issn">http://ns.nature.com/terms/issn</seealso>
    let issn = Prefixed_Name(npg, "issn") |> PrefixedName
    /// <summary>
    ///   <para>npg:issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/issue">http://ns.nature.com/terms/issue</seealso>
    let issue = Prefixed_Name(npg, "issue") |> PrefixedName
    /// <summary>
    ///   <para>npg:name</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/name">http://ns.nature.com/terms/name</seealso>
    let name = Prefixed_Name(npg, "name") |> PrefixedName
    /// <summary>
    ///   <para>npg:namespace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/namespace">http://ns.nature.com/terms/namespace</seealso>
    let namespace_ = Prefixed_Name(npg, "namespace") |> PrefixedName
    /// <summary>
    ///   <para>npg:number</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/number">http://ns.nature.com/terms/number</seealso>
    let number = Prefixed_Name(npg, "number") |> PrefixedName
    /// <summary>
    ///   <para>npg:pageEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/pageEnd">http://ns.nature.com/terms/pageEnd</seealso>
    let pageEnd = Prefixed_Name(npg, "pageEnd") |> PrefixedName
    /// <summary>
    ///   <para>npg:pageStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/pageStart">http://ns.nature.com/terms/pageStart</seealso>
    let pageStart = Prefixed_Name(npg, "pageStart") |> PrefixedName
    /// <summary>
    ///   <para>npg:publicationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/publicationDate">http://ns.nature.com/terms/publicationDate</seealso>
    let publicationDate = Prefixed_Name(npg, "publicationDate") |> PrefixedName
    /// <summary>
    ///   <para>npg:publicationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/publicationDateTime">http://ns.nature.com/terms/publicationDateTime</seealso>
    let publicationDateTime = Prefixed_Name(npg, "publicationDateTime") |> PrefixedName
    /// <summary>
    ///   <para>npg:publicationYear</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/publicationYear">http://ns.nature.com/terms/publicationYear</seealso>
    let publicationYear = Prefixed_Name(npg, "publicationYear") |> PrefixedName

    /// <summary>
    ///   <para>npg:publicationYearMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/publicationYearMonth">http://ns.nature.com/terms/publicationYearMonth</seealso>
    let publicationYearMonth =
        Prefixed_Name(npg, "publicationYearMonth") |> PrefixedName

    /// <summary>
    ///   <para>npg:replacedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/replacedBy">http://ns.nature.com/terms/replacedBy</seealso>
    let replacedBy = Prefixed_Name(npg, "replacedBy") |> PrefixedName
    /// <summary>
    ///   <para>npg:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/replaces">http://ns.nature.com/terms/replaces</seealso>
    let replaces = Prefixed_Name(npg, "replaces") |> PrefixedName
    /// <summary>
    ///   <para>npg:eissn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/eissn">http://ns.nature.com/terms/eissn</seealso>
    let eissn = Prefixed_Name(npg, "eissn") |> PrefixedName
    /// <summary>
    ///   <para>npg:fileExtension</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/fileExtension">http://ns.nature.com/terms/fileExtension</seealso>
    let fileExtension = Prefixed_Name(npg, "fileExtension") |> PrefixedName
    /// <summary>
    ///   <para>npg:Journal</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Journal">http://ns.nature.com/terms/Journal</seealso>
    let Journal = Prefixed_Name(npg, "Journal") |> PrefixedName
    /// <summary>
    ///   <para>npg:Publication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Publication">http://ns.nature.com/terms/Publication</seealso>
    let Publication = Prefixed_Name(npg, "Publication") |> PrefixedName
    /// <summary>
    ///   <para>npg:Concept</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Concept">http://ns.nature.com/terms/Concept</seealso>
    let Concept = Prefixed_Name(npg, "Concept") |> PrefixedName
    /// <summary>
    ///   <para>npg:isLeaf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/isLeaf">http://ns.nature.com/terms/isLeaf</seealso>
    let isLeaf = Prefixed_Name(npg, "isLeaf") |> PrefixedName
    /// <summary>
    ///   <para>npg:Abstract</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Abstract">http://ns.nature.com/terms/Abstract</seealso>
    let Abstract = Prefixed_Name(npg, "Abstract") |> PrefixedName
    /// <summary>
    ///   <para>npg:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Section">http://ns.nature.com/terms/Section</seealso>
    let Section = Prefixed_Name(npg, "Section") |> PrefixedName
    /// <summary>
    ///   <para>npg:SeverityLevel</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/SeverityLevel">http://ns.nature.com/terms/SeverityLevel</seealso>
    let SeverityLevel = Prefixed_Name(npg, "SeverityLevel") |> PrefixedName
    /// <summary>
    ///   <para>npg:Summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Summary">http://ns.nature.com/terms/Summary</seealso>
    let Summary = Prefixed_Name(npg, "Summary") |> PrefixedName
    /// <summary>
    ///   <para>npg:SummaryType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/SummaryType">http://ns.nature.com/terms/SummaryType</seealso>
    let SummaryType = Prefixed_Name(npg, "SummaryType") |> PrefixedName
    /// <summary>
    ///   <para>npg:Technique</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Technique">http://ns.nature.com/terms/Technique</seealso>
    let Technique = Prefixed_Name(npg, "Technique") |> PrefixedName
    /// <summary>
    ///   <para>npg:Agent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Agent">http://ns.nature.com/terms/Agent</seealso>
    let Agent = Prefixed_Name(npg, "Agent") |> PrefixedName
    /// <summary>
    ///   <para>npg:Event</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Event">http://ns.nature.com/terms/Event</seealso>
    let Event = Prefixed_Name(npg, "Event") |> PrefixedName
    /// <summary>
    ///   <para>npg:dateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/dateTime">http://ns.nature.com/terms/dateTime</seealso>
    let dateTime = Prefixed_Name(npg, "dateTime") |> PrefixedName
    /// <summary>
    ///   <para>npg:AggregationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/AggregationEvent">http://ns.nature.com/terms/AggregationEvent</seealso>
    let AggregationEvent = Prefixed_Name(npg, "AggregationEvent") |> PrefixedName
    /// <summary>
    ///   <para>npg:Article</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Article">http://ns.nature.com/terms/Article</seealso>
    let Article = Prefixed_Name(npg, "Article") |> PrefixedName
    /// <summary>
    ///   <para>npg:Type</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Type">http://ns.nature.com/terms/Type</seealso>
    let Type = Prefixed_Name(npg, "Type") |> PrefixedName
    /// <summary>
    ///   <para>npg:Asset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Asset">http://ns.nature.com/terms/Asset</seealso>
    let Asset = Prefixed_Name(npg, "Asset") |> PrefixedName
    /// <summary>
    ///   <para>npg:BlobAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/BlobAsset">http://ns.nature.com/terms/BlobAsset</seealso>
    let BlobAsset = Prefixed_Name(npg, "BlobAsset") |> PrefixedName
    /// <summary>
    ///   <para>npg:Serial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Serial">http://ns.nature.com/terms/Serial</seealso>
    let Serial = Prefixed_Name(npg, "Serial") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasXmlAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasXmlAsset">http://ns.nature.com/terms/hasXmlAsset</seealso>
    let hasXmlAsset = Prefixed_Name(npg, "hasXmlAsset") |> PrefixedName
    /// <summary>
    ///   <para>npg:bodyXml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/bodyXml">http://ns.nature.com/terms/bodyXml</seealso>
    let bodyXml = Prefixed_Name(npg, "bodyXml") |> PrefixedName
    /// <summary>
    ///   <para>npg:caption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/caption">http://ns.nature.com/terms/caption</seealso>
    let caption = Prefixed_Name(npg, "caption") |> PrefixedName
    /// <summary>
    ///   <para>npg:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Document">http://ns.nature.com/terms/Document</seealso>
    let Document = Prefixed_Name(npg, "Document") |> PrefixedName
    /// <summary>
    ///   <para>npg:BinaryAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/BinaryAsset">http://ns.nature.com/terms/BinaryAsset</seealso>
    let BinaryAsset = Prefixed_Name(npg, "BinaryAsset") |> PrefixedName
    /// <summary>
    ///   <para>npg:Blog</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Blog">http://ns.nature.com/terms/Blog</seealso>
    let Blog = Prefixed_Name(npg, "Blog") |> PrefixedName
    /// <summary>
    ///   <para>npg:Collection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Collection">http://ns.nature.com/terms/Collection</seealso>
    let Collection = Prefixed_Name(npg, "Collection") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasSubject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasSubject">http://ns.nature.com/terms/hasSubject</seealso>
    let hasSubject = Prefixed_Name(npg, "hasSubject") |> PrefixedName
    /// <summary>
    ///   <para>npg:ArticleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/ArticleType">http://ns.nature.com/terms/ArticleType</seealso>
    let ArticleType = Prefixed_Name(npg, "ArticleType") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasPdfAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasPdfAsset">http://ns.nature.com/terms/hasPdfAsset</seealso>
    let hasPdfAsset = Prefixed_Name(npg, "hasPdfAsset") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasPublishEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasPublishEvent">http://ns.nature.com/terms/hasPublishEvent</seealso>
    let hasPublishEvent = Prefixed_Name(npg, "hasPublishEvent") |> PrefixedName
    /// <summary>
    ///   <para>npg:hasRoot</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/hasRoot">http://ns.nature.com/terms/hasRoot</seealso>
    let hasRoot = Prefixed_Name(npg, "hasRoot") |> PrefixedName
    /// <summary>
    ///   <para>npg:Dataset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Dataset">http://ns.nature.com/terms/Dataset</seealso>
    let Dataset = Prefixed_Name(npg, "Dataset") |> PrefixedName
    /// <summary>
    ///   <para>npg:Contributor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Contributor">http://ns.nature.com/terms/Contributor</seealso>
    let Contributor = Prefixed_Name(npg, "Contributor") |> PrefixedName
    /// <summary>
    ///   <para>npg:pages</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/pages">http://ns.nature.com/terms/pages</seealso>
    let pages = Prefixed_Name(npg, "pages") |> PrefixedName
    /// <summary>
    ///   <para>npg:Figure</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Figure">http://ns.nature.com/terms/Figure</seealso>
    let Figure = Prefixed_Name(npg, "Figure") |> PrefixedName
    /// <summary>
    ///   <para>npg:Illustration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Illustration">http://ns.nature.com/terms/Illustration</seealso>
    let Illustration = Prefixed_Name(npg, "Illustration") |> PrefixedName
    /// <summary>
    ///   <para>npg:Graph</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Graph">http://ns.nature.com/terms/Graph</seealso>
    let Graph = Prefixed_Name(npg, "Graph") |> PrefixedName
    /// <summary>
    ///   <para>npg:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Image">http://ns.nature.com/terms/Image</seealso>
    let Image = Prefixed_Name(npg, "Image") |> PrefixedName
    /// <summary>
    ///   <para>npg:KnowledgeBase</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/KnowledgeBase">http://ns.nature.com/terms/KnowledgeBase</seealso>
    let KnowledgeBase = Prefixed_Name(npg, "KnowledgeBase") |> PrefixedName
    /// <summary>
    ///   <para>npg:title</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/title">http://ns.nature.com/terms/title</seealso>
    let title = Prefixed_Name(npg, "title") |> PrefixedName
    /// <summary>
    ///   <para>npg:treeDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/treeDepth">http://ns.nature.com/terms/treeDepth</seealso>
    let treeDepth = Prefixed_Name(npg, "treeDepth") |> PrefixedName
    /// <summary>
    ///   <para>npg:yearMonth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/yearMonth">http://ns.nature.com/terms/yearMonth</seealso>
    let yearMonth = Prefixed_Name(npg, "yearMonth") |> PrefixedName
    /// <summary>
    ///   <para>npg:titleXml</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/titleXml">http://ns.nature.com/terms/titleXml</seealso>
    let titleXml = Prefixed_Name(npg, "titleXml") |> PrefixedName
    /// <summary>
    ///   <para>npg:ImageAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/ImageAsset">http://ns.nature.com/terms/ImageAsset</seealso>
    let ImageAsset = Prefixed_Name(npg, "ImageAsset") |> PrefixedName
    /// <summary>
    ///   <para>npg:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/volume">http://ns.nature.com/terms/volume</seealso>
    let volume = Prefixed_Name(npg, "volume") |> PrefixedName
    /// <summary>
    ///   <para>npg:year</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/year">http://ns.nature.com/terms/year</seealso>
    let year = Prefixed_Name(npg, "year") |> PrefixedName
    /// <summary>
    ///   <para>npg:Issue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Issue">http://ns.nature.com/terms/Issue</seealso>
    let Issue = Prefixed_Name(npg, "Issue") |> PrefixedName
    /// <summary>
    ///   <para>npg:Item</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Item">http://ns.nature.com/terms/Item</seealso>
    let Item = Prefixed_Name(npg, "Item") |> PrefixedName
    /// <summary>
    ///   <para>npg:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Organization">http://ns.nature.com/terms/Organization</seealso>
    let Organization = Prefixed_Name(npg, "Organization") |> PrefixedName
    /// <summary>
    ///   <para>npg:Person</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Person">http://ns.nature.com/terms/Person</seealso>
    let Person = Prefixed_Name(npg, "Person") |> PrefixedName
    /// <summary>
    ///   <para>npg:PdfAsset</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/PdfAsset">http://ns.nature.com/terms/PdfAsset</seealso>
    let PdfAsset = Prefixed_Name(npg, "PdfAsset") |> PrefixedName
    /// <summary>
    ///   <para>npg:Publisher</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Publisher">http://ns.nature.com/terms/Publisher</seealso>
    let Publisher = Prefixed_Name(npg, "Publisher") |> PrefixedName
    /// <summary>
    ///   <para>npg:ReviewState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/ReviewState">http://ns.nature.com/terms/ReviewState</seealso>
    let ReviewState = Prefixed_Name(npg, "ReviewState") |> PrefixedName
    /// <summary>
    ///   <para>npg:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/">http://ns.nature.com/terms/</seealso>
    let _prefix_iri = Prefixed_Name(npg, "") |> PrefixedName
    /// <summary>
    ///   <para>npg:Component</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Component">http://ns.nature.com/terms/Component</seealso>
    let Component = Prefixed_Name(npg, "Component") |> PrefixedName
    /// <summary>
    ///   <para>npg:PublicationEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/PublicationEvent">http://ns.nature.com/terms/PublicationEvent</seealso>
    let PublicationEvent = Prefixed_Name(npg, "PublicationEvent") |> PrefixedName
    /// <summary>
    ///   <para>npg:PublishEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/PublishEvent">http://ns.nature.com/terms/PublishEvent</seealso>
    let PublishEvent = Prefixed_Name(npg, "PublishEvent") |> PrefixedName
    /// <summary>
    ///   <para>npg:PublishState</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/PublishState">http://ns.nature.com/terms/PublishState</seealso>
    let PublishState = Prefixed_Name(npg, "PublishState") |> PrefixedName
    /// <summary>
    ///   <para>npg:ReviewEvent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/ReviewEvent">http://ns.nature.com/terms/ReviewEvent</seealso>
    let ReviewEvent = Prefixed_Name(npg, "ReviewEvent") |> PrefixedName
    /// <summary>
    ///   <para>npg:Subject</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    /// </remarks>
    /// <seealso href="http://ns.nature.com/terms/Subject">http://ns.nature.com/terms/Subject</seealso>
    let Subject = Prefixed_Name(npg, "Subject") |> PrefixedName
