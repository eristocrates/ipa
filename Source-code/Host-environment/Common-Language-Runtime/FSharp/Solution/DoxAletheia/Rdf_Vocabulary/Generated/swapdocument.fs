namespace http.eulersharp.sourceforge.net._2003._03swap.document.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module swapdocument =
    let _namespace_iri = Namespace_Iri swapdocument |> NamespaceIRI
    /// <summary>
    ///   <para>swapdocument:</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#">http://eulersharp.sourceforge.net/2003/03swap/document#</seealso>
    let _prefix_iri = Prefixed_Name(swapdocument, "") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Authoring</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>authoring</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Authoring">http://eulersharp.sourceforge.net/2003/03swap/document#Authoring</seealso>
    let Authoring = Prefixed_Name(swapdocument, "Authoring") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:imageOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#imageOf">http://eulersharp.sourceforge.net/2003/03swap/document#imageOf</seealso>
    let imageOf = Prefixed_Name(swapdocument, "imageOf") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Content</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>content</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Content">http://eulersharp.sourceforge.net/2003/03swap/document#Content</seealso>
    let Content = Prefixed_Name(swapdocument, "Content") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:authenticatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#authenticatedBy">http://eulersharp.sourceforge.net/2003/03swap/document#authenticatedBy</seealso>
    let authenticatedBy = Prefixed_Name(swapdocument, "authenticatedBy") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:deprecatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecatedBy">http://eulersharp.sourceforge.net/2003/03swap/document#deprecatedBy</seealso>
    let deprecatedBy = Prefixed_Name(swapdocument, "deprecatedBy") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:deprecates</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecates">http://eulersharp.sourceforge.net/2003/03swap/document#deprecates</seealso>
    let deprecates = Prefixed_Name(swapdocument, "deprecates") |> PrefixedName

    /// <summary>
    ///   <para>swapdocument:DataDefinitionOntology</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>E.g. data base table column header as property, data base table as domain class, data base field as range class, data base field value as instance, row as instance graph.</para>
    /// labels<para>data definition ontology</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#DataDefinitionOntology">http://eulersharp.sourceforge.net/2003/03swap/document#DataDefinitionOntology</seealso>
    let DataDefinitionOntology =
        Prefixed_Name(swapdocument, "DataDefinitionOntology") |> PrefixedName

    /// <summary>
    ///   <para>swapdocument:Deprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>events:State</para>
    ///
    /// labels<para>deprecated</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Deprecated">http://eulersharp.sourceforge.net/2003/03swap/document#Deprecated</seealso>
    let Deprecated = Prefixed_Name(swapdocument, "Deprecated") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:DigitalContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>digital content</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#DigitalContent">http://eulersharp.sourceforge.net/2003/03swap/document#DigitalContent</seealso>
    let DigitalContent = Prefixed_Name(swapdocument, "DigitalContent") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Deprecating</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>deprecating</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Deprecating">http://eulersharp.sourceforge.net/2003/03swap/document#Deprecating</seealso>
    let Deprecating = Prefixed_Name(swapdocument, "Deprecating") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Deprecation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>deprecation</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Deprecation">http://eulersharp.sourceforge.net/2003/03swap/document#Deprecation</seealso>
    let Deprecation = Prefixed_Name(swapdocument, "Deprecation") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>document</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Document">http://eulersharp.sourceforge.net/2003/03swap/document#Document</seealso>
    let Document = Prefixed_Name(swapdocument, "Document") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Image</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>image</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Image">http://eulersharp.sourceforge.net/2003/03swap/document#Image</seealso>
    let Image = Prefixed_Name(swapdocument, "Image") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Report</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>report</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Report">http://eulersharp.sourceforge.net/2003/03swap/document#Report</seealso>
    let Report = Prefixed_Name(swapdocument, "Report") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Summary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>summary report</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Summary">http://eulersharp.sourceforge.net/2003/03swap/document#Summary</seealso>
    let Summary = Prefixed_Name(swapdocument, "Summary") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:about</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#about">http://eulersharp.sourceforge.net/2003/03swap/document#about</seealso>
    let about = Prefixed_Name(swapdocument, "about") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Letter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>letter</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Letter">http://eulersharp.sourceforge.net/2003/03swap/document#Letter</seealso>
    let Letter = Prefixed_Name(swapdocument, "Letter") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Record">http://eulersharp.sourceforge.net/2003/03swap/document#Record</seealso>
    let Record = Prefixed_Name(swapdocument, "Record") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Parent</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>parent document</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Parent">http://eulersharp.sourceforge.net/2003/03swap/document#Parent</seealso>
    let Parent = Prefixed_Name(swapdocument, "Parent") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:addedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#addedTo">http://eulersharp.sourceforge.net/2003/03swap/document#addedTo</seealso>
    let addedTo = Prefixed_Name(swapdocument, "addedTo") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#contains">http://eulersharp.sourceforge.net/2003/03swap/document#contains</seealso>
    let contains = Prefixed_Name(swapdocument, "contains") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:authoredBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#authoredBy">http://eulersharp.sourceforge.net/2003/03swap/document#authoredBy</seealso>
    let authoredBy = Prefixed_Name(swapdocument, "authoredBy") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:deprecatedIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecatedIn">http://eulersharp.sourceforge.net/2003/03swap/document#deprecatedIn</seealso>
    let deprecatedIn = Prefixed_Name(swapdocument, "deprecatedIn") |> PrefixedName

    /// <summary>
    ///   <para>swapdocument:hasDeprecationDateTime</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasDeprecationDateTime">http://eulersharp.sourceforge.net/2003/03swap/document#hasDeprecationDateTime</seealso>
    let hasDeprecationDateTime =
        Prefixed_Name(swapdocument, "hasDeprecationDateTime") |> PrefixedName

    /// <summary>
    ///   <para>swapdocument:whereinDeprecated</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#whereinDeprecated">http://eulersharp.sourceforge.net/2003/03swap/document#whereinDeprecated</seealso>
    let whereinDeprecated =
        Prefixed_Name(swapdocument, "whereinDeprecated") |> PrefixedName

    /// <summary>
    ///   <para>swapdocument:deprecationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#deprecationOf">http://eulersharp.sourceforge.net/2003/03swap/document#deprecationOf</seealso>
    let deprecationOf = Prefixed_Name(swapdocument, "deprecationOf") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasLanguage">http://eulersharp.sourceforge.net/2003/03swap/document#hasLanguage</seealso>
    let hasLanguage = Prefixed_Name(swapdocument, "hasLanguage") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasParent">http://eulersharp.sourceforge.net/2003/03swap/document#hasParent</seealso>
    let hasParent = Prefixed_Name(swapdocument, "hasParent") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasReport</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasReport">http://eulersharp.sourceforge.net/2003/03swap/document#hasReport</seealso>
    let hasReport = Prefixed_Name(swapdocument, "hasReport") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:reportOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#reportOf">http://eulersharp.sourceforge.net/2003/03swap/document#reportOf</seealso>
    let reportOf = Prefixed_Name(swapdocument, "reportOf") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasDeprecator</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasDeprecator">http://eulersharp.sourceforge.net/2003/03swap/document#hasDeprecator</seealso>
    let hasDeprecator = Prefixed_Name(swapdocument, "hasDeprecator") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasDigitalSize</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasDigitalSize">http://eulersharp.sourceforge.net/2003/03swap/document#hasDigitalSize</seealso>
    let hasDigitalSize = Prefixed_Name(swapdocument, "hasDigitalSize") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasMimeType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasMimeType">http://eulersharp.sourceforge.net/2003/03swap/document#hasMimeType</seealso>
    let hasMimeType = Prefixed_Name(swapdocument, "hasMimeType") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasSha1Hash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasSha1Hash">http://eulersharp.sourceforge.net/2003/03swap/document#hasSha1Hash</seealso>
    let hasSha1Hash = Prefixed_Name(swapdocument, "hasSha1Hash") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:summaryOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#summaryOf">http://eulersharp.sourceforge.net/2003/03swap/document#summaryOf</seealso>
    let summaryOf = Prefixed_Name(swapdocument, "summaryOf") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasTitle">http://eulersharp.sourceforge.net/2003/03swap/document#hasTitle</seealso>
    let hasTitle = Prefixed_Name(swapdocument, "hasTitle") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasHash</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasHash">http://eulersharp.sourceforge.net/2003/03swap/document#hasHash</seealso>
    let hasHash = Prefixed_Name(swapdocument, "hasHash") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:hasSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#hasSummary">http://eulersharp.sourceforge.net/2003/03swap/document#hasSummary</seealso>
    let hasSummary = Prefixed_Name(swapdocument, "hasSummary") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:transformedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#transformedTo">http://eulersharp.sourceforge.net/2003/03swap/document#transformedTo</seealso>
    let transformedTo = Prefixed_Name(swapdocument, "transformedTo") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:replaces</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#replaces">http://eulersharp.sourceforge.net/2003/03swap/document#replaces</seealso>
    let replaces = Prefixed_Name(swapdocument, "replaces") |> PrefixedName
    /// <summary>
    ///   <para>swapdocument:Author</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>author</para></remarks>
    /// <seealso href="http://eulersharp.sourceforge.net/2003/03swap/document#Author">http://eulersharp.sourceforge.net/2003/03swap/document#Author</seealso>
    let Author = Prefixed_Name(swapdocument, "Author") |> PrefixedName
