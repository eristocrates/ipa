namespace http.purl.org.spar.c4o.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module c4o =
    let _namespace_iri = Namespace_Iri c4o |> NamespaceIRI
    /// <summary>
    ///   <para>c4o:</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>"Citation Counting and Context Characterization Ontology"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/">http://purl.org/spar/c4o/</seealso>
    let _prefix_iri = Prefixed_Name(c4o, "") |> PrefixedName

    /// <summary>
    ///   <para>c4o:BibliographicInformationSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A source of information about bibliographic citations, such as Google Scholar, Web of Science or Scopus."</para>
    /// labels<para>"bibliographic information source"</para><para>"Bibliographic Information Source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/BibliographicInformationSource">http://purl.org/spar/c4o/BibliographicInformationSource</seealso>
    let BibliographicInformationSource =
        Prefixed_Name(c4o, "BibliographicInformationSource") |> PrefixedName

    /// <summary>
    ///   <para>c4o:GlobalCitationCount</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The number of times a work has been cited globally, as determined from a particular bibliographic information source on a particular date."</para>
    /// labels<para>"Global Citation Count"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"global citation count"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/GlobalCitationCount">http://purl.org/spar/c4o/GlobalCitationCount</seealso>
    let GlobalCitationCount = Prefixed_Name(c4o, "GlobalCitationCount") |> PrefixedName

    /// <summary>
    ///   <para>c4o:InTextReferencePointer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The in-text reference pointer is a textual element, usually embedded at the end of a phrase or sentence within the text of a document, that denotes a specific bibliographic reference present in the reference list of that document. For example, if the item in the reference list is:
    ///
    /// 4.  Ko AI, Reis MG, Ribeiro Dourado CM, Johnson WD Jr, Riley LW (1999). Urban epidemic of severe leptospirosis in Brazil. Salvador Leptospirosis Study Group. Lancet 354: 820-825.
    ///
    /// the in-text reference pointer to this paper in a journal article may be manifested in a number of ways:
    ///
    /// Numerically, for example by using the numeral 4 in superscript or between square brackets, thus: [4].  Such numerical in-text
    /// reference pointers are frequently aggregated, e.g. [4, 5, 6-9].  In such cases, the missing pointers to references 7 and 8 are inferred (and should be added explicitly to the XML mark-up at this point in the text!).
    ///
    /// Or by use of the author names (or the first author's name plus et al.) and the publication year in parentheses, thus: (Ko et al., 1999).
    ///
    /// Or, less commonly, by the use of a code, e.g. by specifying the first surname letter of the first three author of the cited work followed by the last two digits of the year of publication, this string of characters being enclosed within square brackets, thus: [KRR99]."</para>
    /// labels<para>"in-text reference pointer"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/InTextReferencePointer">http://purl.org/spar/c4o/InTextReferencePointer</seealso>
    let InTextReferencePointer =
        Prefixed_Name(c4o, "InTextReferencePointer") |> PrefixedName

    /// <summary>
    ///   <para>c4o:InTextReferencePointerList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A list containing only in-text reference pointers denoting the specific bibliographic references to which the list pertains."</para>
    /// labels<para>"in-text reference pointer list"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/InTextReferencePointerList">http://purl.org/spar/c4o/InTextReferencePointerList</seealso>
    let InTextReferencePointerList =
        Prefixed_Name(c4o, "InTextReferencePointerList") |> PrefixedName

    /// <summary>
    ///   <para>c4o:InTextReferencePointerListItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes all the list items that must be used in the context of an in-text reference pointer list."</para>
    /// labels<para>"in-text reference pointer list item"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/InTextReferencePointerListItem">http://purl.org/spar/c4o/InTextReferencePointerListItem</seealso>
    let InTextReferencePointerListItem =
        Prefixed_Name(c4o, "InTextReferencePointerListItem") |> PrefixedName

    /// <summary>
    ///   <para>c4o:SingleReferencePointerList</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"An in-text reference pointer list that pertains to exactly one bibliographic reference."</para>
    /// labels<para>"single reference pointer list"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/SingleReferencePointerList">http://purl.org/spar/c4o/SingleReferencePointerList</seealso>
    let SingleReferencePointerList =
        Prefixed_Name(c4o, "SingleReferencePointerList") |> PrefixedName

    /// <summary>
    ///   <para>c4o:denotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property used to assert the connection between an in-text reference pointer and the bibliographic reference it points to."</para>
    /// labels<para>"denotes"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/denotes">http://purl.org/spar/c4o/denotes</seealso>
    let denotes = Prefixed_Name(c4o, "denotes") |> PrefixedName
    /// <summary>
    ///   <para>c4o:hasContent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"It is used to specify the textual content of a particular FRBR expression."</para>
    /// labels<para>"has content"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/hasContent">http://purl.org/spar/c4o/hasContent</seealso>
    let hasContent = Prefixed_Name(c4o, "hasContent") |> PrefixedName
    /// <summary>
    ///   <para>c4o:hasContext</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:Class</para>
    ///   <para>"This property is used to indicate the textual context (e.g. a sentence or a paragraph) of a particular in-text reference pointer, this context providing the rhetorical motivation for the existence of that citation."</para>
    /// labels<para>"has context"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/hasContext">http://purl.org/spar/c4o/hasContext</seealso>
    let hasContext = Prefixed_Name(c4o, "hasContext") |> PrefixedName

    /// <summary>
    ///   <para>c4o:hasGlobalCitationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking a publication entity to the property c40:GlobalCitationCount that specify how many times a work has been cited by others, according to a particular information source on a particular date."</para>
    /// labels<para>"has global citation frequency"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has global citation frequency"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/hasGlobalCitationFrequency">http://purl.org/spar/c4o/hasGlobalCitationFrequency</seealso>
    let hasGlobalCitationFrequency =
        Prefixed_Name(c4o, "hasGlobalCitationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>c4o:hasGlobalCountDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The date on which the global citation count of the cited entity was recorded from a named bibliographic information source."</para>
    /// labels<para>"has global count date"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has global count date"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/hasGlobalCountDate">http://purl.org/spar/c4o/hasGlobalCountDate</seealso>
    let hasGlobalCountDate = Prefixed_Name(c4o, "hasGlobalCountDate") |> PrefixedName

    /// <summary>
    ///   <para>c4o:hasGlobalCountSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property linking the property c40:GlobalCitationCount to the bibliographic information source providing the global citation count information for a particular publication on a particular date."</para>
    /// labels<para>"has global count source"</para><para>"has global count source"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/hasGlobalCountSource">http://purl.org/spar/c4o/hasGlobalCountSource</seealso>
    let hasGlobalCountSource =
        Prefixed_Name(c4o, "hasGlobalCountSource") |> PrefixedName

    /// <summary>
    ///   <para>c4o:hasGlobalCountValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"An integer defining the value of the global citation count of a cited entity recorded from a named bibliographic information source on a particular date."</para>
    /// labels<para>"has global count value"^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para><para>"has global count value"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/hasGlobalCountValue">http://purl.org/spar/c4o/hasGlobalCountValue</seealso>
    let hasGlobalCountValue = Prefixed_Name(c4o, "hasGlobalCountValue") |> PrefixedName

    /// <summary>
    ///   <para>c4o:hasInTextCitationFrequency</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property allows one to specify how many separate in-text reference pointers exist within the text of a citing document that all denote the same single bibliographic reference to a cited document (i.e how many distinct textual contexts exist within the citing document from which a citation is made to a particular document)."</para>
    /// labels<para>"has in text citation frequency"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/hasInTextCitationFrequency">http://purl.org/spar/c4o/hasInTextCitationFrequency</seealso>
    let hasInTextCitationFrequency =
        Prefixed_Name(c4o, "hasInTextCitationFrequency") |> PrefixedName

    /// <summary>
    ///   <para>c4o:isDenotedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property used to assert the connection between a bibliographic reference and the in-text reference pointer that points to it."</para>
    /// labels<para>"is denoted by"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/isDenotedBy">http://purl.org/spar/c4o/isDenotedBy</seealso>
    let isDenotedBy = Prefixed_Name(c4o, "isDenotedBy") |> PrefixedName
    /// <summary>
    ///   <para>c4o:isRelevantTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A property allowing one FRBR expression to be declared to be of rhetorical relevance to another, for instance that the textual context of a particular in-text reference pointer in one document is relevant to a section of text within the published document that is referenced by the bibliographic reference denoted by the in-text reference pointer, and vice versa that the converse relevance also exists."</para>
    /// labels<para>"is relevant to"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/isRelevantTo">http://purl.org/spar/c4o/isRelevantTo</seealso>
    let isRelevantTo = Prefixed_Name(c4o, "isRelevantTo") |> PrefixedName
    /// <summary>
    ///   <para>c4o:pertainsTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The property linking an in-text reference pointer list to the bibliographic reference or references denoted by the in-text reference pointers within that list."</para>
    /// labels<para>"pertains to"</para></remarks>
    /// <seealso href="http://purl.org/spar/c4o/pertainsTo">http://purl.org/spar/c4o/pertainsTo</seealso>
    let pertainsTo = Prefixed_Name(c4o, "pertainsTo") |> PrefixedName
