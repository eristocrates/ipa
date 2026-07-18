namespace http.eulersharp.sourceforge.net._2003._03swap.document.hash

open DoxAletheia.Rdf_Vocabulary

module swap_document =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/document#"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Author"></see>
    /// </summary>
    let Author = Namespaced_IRI.parse _namespace_name "Author" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Authoring"></see>
    /// </summary>
    let Authoring = Namespaced_IRI.parse _namespace_name "Authoring" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Content"></see>
    /// </summary>
    let Content = Namespaced_IRI.parse _namespace_name "Content" |> NamespacedName

    /// <summary>
    /// E.g. data base table column header as property, data base table as domain class, data base field as range class, data base field value as instance, row as instance graph.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/document#DataDefinitionOntology"></see></summary>
    let DataDefinitionOntology =
        Namespaced_IRI.parse _namespace_name "DataDefinitionOntology" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Deprecated"></see>
    /// </summary>
    let Deprecated = Namespaced_IRI.parse _namespace_name "Deprecated" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Deprecating"></see>
    /// </summary>
    let Deprecating =
        Namespaced_IRI.parse _namespace_name "Deprecating" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Deprecation"></see>
    /// </summary>
    let Deprecation =
        Namespaced_IRI.parse _namespace_name "Deprecation" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#DigitalContent"></see>
    /// </summary>
    let DigitalContent =
        Namespaced_IRI.parse _namespace_name "DigitalContent" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Document"></see>
    /// </summary>
    let Document = Namespaced_IRI.parse _namespace_name "Document" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Image"></see>
    /// </summary>
    let Image = Namespaced_IRI.parse _namespace_name "Image" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Letter"></see>
    /// </summary>
    let Letter = Namespaced_IRI.parse _namespace_name "Letter" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Report"></see>
    /// </summary>
    let Report = Namespaced_IRI.parse _namespace_name "Report" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Parent"></see>
    /// </summary>
    let Parent = Namespaced_IRI.parse _namespace_name "Parent" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Record"></see>
    /// </summary>
    let Record = Namespaced_IRI.parse _namespace_name "Record" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Summary"></see>
    /// </summary>
    let Summary = Namespaced_IRI.parse _namespace_name "Summary" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#about"></see>
    /// </summary>
    let about = Namespaced_IRI.parse _namespace_name "about" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#addedTo"></see>
    /// </summary>
    let addedTo = Namespaced_IRI.parse _namespace_name "addedTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#authenticatedBy"></see>
    /// </summary>
    let authenticatedBy =
        Namespaced_IRI.parse _namespace_name "authenticatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#authoredBy"></see>
    /// </summary>
    let authoredBy = Namespaced_IRI.parse _namespace_name "authoredBy" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#contains"></see>
    /// </summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecatedBy"></see>
    /// </summary>
    let deprecatedBy =
        Namespaced_IRI.parse _namespace_name "deprecatedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecates"></see>
    /// </summary>
    let deprecates = Namespaced_IRI.parse _namespace_name "deprecates" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecatedIn"></see>
    /// </summary>
    let deprecatedIn =
        Namespaced_IRI.parse _namespace_name "deprecatedIn" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#whereinDeprecated"></see>
    /// </summary>
    let whereinDeprecated =
        Namespaced_IRI.parse _namespace_name "whereinDeprecated" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecationOf"></see>
    /// </summary>
    let deprecationOf =
        Namespaced_IRI.parse _namespace_name "deprecationOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasDeprecationDateTime"></see>
    /// </summary>
    let hasDeprecationDateTime =
        Namespaced_IRI.parse _namespace_name "hasDeprecationDateTime" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasDeprecator"></see>
    /// </summary>
    let hasDeprecator =
        Namespaced_IRI.parse _namespace_name "hasDeprecator" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasDigitalSize"></see>
    /// </summary>
    let hasDigitalSize =
        Namespaced_IRI.parse _namespace_name "hasDigitalSize" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasHash"></see>
    /// </summary>
    let hasHash = Namespaced_IRI.parse _namespace_name "hasHash" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasLanguage"></see>
    /// </summary>
    let hasLanguage =
        Namespaced_IRI.parse _namespace_name "hasLanguage" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasMimeType"></see>
    /// </summary>
    let hasMimeType =
        Namespaced_IRI.parse _namespace_name "hasMimeType" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasParent"></see>
    /// </summary>
    let hasParent = Namespaced_IRI.parse _namespace_name "hasParent" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasReport"></see>
    /// </summary>
    let hasReport = Namespaced_IRI.parse _namespace_name "hasReport" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#reportOf"></see>
    /// </summary>
    let reportOf = Namespaced_IRI.parse _namespace_name "reportOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasSha1Hash"></see>
    /// </summary>
    let hasSha1Hash =
        Namespaced_IRI.parse _namespace_name "hasSha1Hash" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasSummary"></see>
    /// </summary>
    let hasSummary = Namespaced_IRI.parse _namespace_name "hasSummary" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#summaryOf"></see>
    /// </summary>
    let summaryOf = Namespaced_IRI.parse _namespace_name "summaryOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasTitle"></see>
    /// </summary>
    let hasTitle = Namespaced_IRI.parse _namespace_name "hasTitle" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#imageOf"></see>
    /// </summary>
    let imageOf = Namespaced_IRI.parse _namespace_name "imageOf" |> NamespacedName
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#replaces"></see>
    /// </summary>
    let replaces = Namespaced_IRI.parse _namespace_name "replaces" |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#transformedTo"></see>
    /// </summary>
    let transformedTo =
        Namespaced_IRI.parse _namespace_name "transformedTo" |> NamespacedName
