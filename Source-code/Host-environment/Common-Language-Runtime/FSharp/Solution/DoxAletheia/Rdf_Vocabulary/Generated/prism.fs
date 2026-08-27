namespace http.prismstandard.org.namespaces.basic._2._0.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module prism =
    let _namespace_iri = Namespace_Iri prism |> NamespaceIRI
    /// <summary>
    ///   <para>prism:alternateTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An alternative title for a resource."</para>
    /// labels<para>"alternate title"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/alternateTitle">http://prismstandard.org/namespaces/basic/2.0/alternateTitle</seealso>
    let alternateTitle = Prefixed_Name(prism, "alternateTitle") |> PrefixedName
    /// <summary>
    ///   <para>prism:doi</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A Digital Object Identifier for a serial publication item, a dataset or some other entity."</para>
    /// labels<para>"has DOI"</para><para>"has Digital Object Identifier"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/doi">http://prismstandard.org/namespaces/basic/2.0/doi</seealso>
    let doi = Prefixed_Name(prism, "doi") |> PrefixedName
    /// <summary>
    ///   <para>prism:eIssn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An International Standard Serial Number, ISSN, for electronic versions of serial publications."</para>
    /// labels<para>"has eISSN"</para><para>"has electronic International Standard Serial Number"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/eIssn">http://prismstandard.org/namespaces/basic/2.0/eIssn</seealso>
    let eIssn = Prefixed_Name(prism, "eIssn") |> PrefixedName
    /// <summary>
    ///   <para>prism:edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"An identifier for one of several alternative issues of a magazine, a book or other resource."</para>
    /// labels<para>"has edition"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/edition">http://prismstandard.org/namespaces/basic/2.0/edition</seealso>
    let edition = Prefixed_Name(prism, "edition") |> PrefixedName
    /// <summary>
    ///   <para>prism:endingPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Identifies the last page of an entity such as a journal article."</para>
    /// labels<para>"has ending page"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/endingPage">http://prismstandard.org/namespaces/basic/2.0/endingPage</seealso>
    let endingPage = Prefixed_Name(prism, "endingPage") |> PrefixedName
    /// <summary>
    ///   <para>prism:isbn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The International Standard Book Number, ISBN, used to identify published books or, more rarely, journal issues."</para>
    /// labels<para>"has International Standard Book Number"</para><para>"has ISBN"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/isbn">http://prismstandard.org/namespaces/basic/2.0/isbn</seealso>
    let isbn = Prefixed_Name(prism, "isbn") |> PrefixedName
    /// <summary>
    ///   <para>prism:issn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The International Standard Serial Number, ISSN, an identifer for serial publications."</para>
    /// labels<para>"has ISSN"</para><para>"has International Standard Serial Number"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/issn">http://prismstandard.org/namespaces/basic/2.0/issn</seealso>
    let issn = Prefixed_Name(prism, "issn") |> PrefixedName
    /// <summary>
    ///   <para>prism:issueIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An identifier used to identify a specific issue of a magazine, a journal or other resource."</para>
    /// labels<para>"has issue identifier"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/issueIdentifier">http://prismstandard.org/namespaces/basic/2.0/issueIdentifier</seealso>
    let issueIdentifier = Prefixed_Name(prism, "issueIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>prism:keyword</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A property used to tag a resource with a keyword that is likely to be used in search queries."</para>
    /// labels<para>"has keyword"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/keyword">http://prismstandard.org/namespaces/basic/2.0/keyword</seealso>
    let keyword = Prefixed_Name(prism, "keyword") |> PrefixedName
    /// <summary>
    ///   <para>prism:pageRange</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"Identifies the page range of an entity such as a journal article."</para>
    /// labels<para>"has page range"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/pageRange">http://prismstandard.org/namespaces/basic/2.0/pageRange</seealso>
    let pageRange = Prefixed_Name(prism, "pageRange") |> PrefixedName
    /// <summary>
    ///   <para>prism:publicationDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>rdfs:Datatype</para>
    ///   <para>"The date on which a resource is published or disclosed."</para>
    /// labels<para>"has publication date"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/publicationDate">http://prismstandard.org/namespaces/basic/2.0/publicationDate</seealso>
    let publicationDate = Prefixed_Name(prism, "publicationDate") |> PrefixedName
    /// <summary>
    ///   <para>prism:section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name or identifier of the section or part of a resource, for example Part 2 of Issue 6 of Volume 127 of the Journal of Cell Biology, or the Travel Section of a newspaper issue."</para>
    /// labels<para>"section"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/section">http://prismstandard.org/namespaces/basic/2.0/section</seealso>
    let section = Prefixed_Name(prism, "section") |> PrefixedName
    /// <summary>
    ///   <para>prism:startingPage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"Identifies the first page of an entity such as a journal article."</para>
    /// labels<para>"has starting page"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/startingPage">http://prismstandard.org/namespaces/basic/2.0/startingPage</seealso>
    let startingPage = Prefixed_Name(prism, "startingPage") |> PrefixedName
    /// <summary>
    ///   <para>prism:versionIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An identifier for a version of a resource, for example a text book, a draft of an article, or a data file."</para>
    /// labels<para>"has version identifier"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/versionIdentifier">http://prismstandard.org/namespaces/basic/2.0/versionIdentifier</seealso>
    let versionIdentifier = Prefixed_Name(prism, "versionIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>prism:volume</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"An identifier for a particular volume of a resource, such as a journal or a multi-volume book."</para>
    /// labels<para>"has volume identifier"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/volume">http://prismstandard.org/namespaces/basic/2.0/volume</seealso>
    let volume = Prefixed_Name(prism, "volume") |> PrefixedName
    /// <summary>
    ///   <para>prism:wordCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"The count of the number of words in a textual resource."</para>
    /// labels<para>"has word count"</para></remarks>
    /// <seealso href="http://prismstandard.org/namespaces/basic/2.0/wordCount">http://prismstandard.org/namespaces/basic/2.0/wordCount</seealso>
    let wordCount = Prefixed_Name(prism, "wordCount") |> PrefixedName
