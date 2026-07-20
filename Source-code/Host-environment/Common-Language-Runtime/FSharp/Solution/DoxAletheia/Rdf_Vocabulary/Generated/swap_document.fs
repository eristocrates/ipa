namespace http.eulersharp.sourceforge.net._2003._03swap.document.hash

open DoxAletheia

module swap_document =
    let _namespace_name = "http://eulersharp.sourceforge.net/2003/03swap/document#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Author"></see>
    /// </summary>
    let Author = _prefix "Author"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Authoring"></see>
    /// </summary>
    let Authoring = _prefix "Authoring"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Content"></see>
    /// </summary>
    let Content = _prefix "Content"
    /// <summary>
    /// E.g. data base table column header as property, data base table as domain class, data base field as range class, data base field value as instance, row as instance graph.
    /// <see href="http://eulersharp.sourceforge.net/2003/03swap/document#DataDefinitionOntology"></see></summary>
    let DataDefinitionOntology = _prefix "DataDefinitionOntology"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Deprecated"></see>
    /// </summary>
    let Deprecated = _prefix "Deprecated"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Deprecating"></see>
    /// </summary>
    let Deprecating = _prefix "Deprecating"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Deprecation"></see>
    /// </summary>
    let Deprecation = _prefix "Deprecation"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#DigitalContent"></see>
    /// </summary>
    let DigitalContent = _prefix "DigitalContent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Document"></see>
    /// </summary>
    let Document = _prefix "Document"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Image"></see>
    /// </summary>
    let Image = _prefix "Image"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Letter"></see>
    /// </summary>
    let Letter = _prefix "Letter"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Report"></see>
    /// </summary>
    let Report = _prefix "Report"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Parent"></see>
    /// </summary>
    let Parent = _prefix "Parent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Record"></see>
    /// </summary>
    let Record = _prefix "Record"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#Summary"></see>
    /// </summary>
    let Summary = _prefix "Summary"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#about"></see>
    /// </summary>
    let about = _prefix "about"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#addedTo"></see>
    /// </summary>
    let addedTo = _prefix "addedTo"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#authenticatedBy"></see>
    /// </summary>
    let authenticatedBy = _prefix "authenticatedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#authoredBy"></see>
    /// </summary>
    let authoredBy = _prefix "authoredBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#contains"></see>
    /// </summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecatedBy"></see>
    /// </summary>
    let deprecatedBy = _prefix "deprecatedBy"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecates"></see>
    /// </summary>
    let deprecates = _prefix "deprecates"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecatedIn"></see>
    /// </summary>
    let deprecatedIn = _prefix "deprecatedIn"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#whereinDeprecated"></see>
    /// </summary>
    let whereinDeprecated = _prefix "whereinDeprecated"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecationOf"></see>
    /// </summary>
    let deprecationOf = _prefix "deprecationOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasDeprecationDateTime"></see>
    /// </summary>
    let hasDeprecationDateTime = _prefix "hasDeprecationDateTime"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasDeprecator"></see>
    /// </summary>
    let hasDeprecator = _prefix "hasDeprecator"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasDigitalSize"></see>
    /// </summary>
    let hasDigitalSize = _prefix "hasDigitalSize"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasHash"></see>
    /// </summary>
    let hasHash = _prefix "hasHash"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasLanguage"></see>
    /// </summary>
    let hasLanguage = _prefix "hasLanguage"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasMimeType"></see>
    /// </summary>
    let hasMimeType = _prefix "hasMimeType"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasParent"></see>
    /// </summary>
    let hasParent = _prefix "hasParent"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasReport"></see>
    /// </summary>
    let hasReport = _prefix "hasReport"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#reportOf"></see>
    /// </summary>
    let reportOf = _prefix "reportOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasSha1Hash"></see>
    /// </summary>
    let hasSha1Hash = _prefix "hasSha1Hash"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasSummary"></see>
    /// </summary>
    let hasSummary = _prefix "hasSummary"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#summaryOf"></see>
    /// </summary>
    let summaryOf = _prefix "summaryOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#hasTitle"></see>
    /// </summary>
    let hasTitle = _prefix "hasTitle"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#imageOf"></see>
    /// </summary>
    let imageOf = _prefix "imageOf"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#replaces"></see>
    /// </summary>
    let replaces = _prefix "replaces"
    /// <summary>
    ///   <see href="http://eulersharp.sourceforge.net/2003/03swap/document#transformedTo"></see>
    /// </summary>
    let transformedTo = _prefix "transformedTo"
