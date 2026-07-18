namespace http.purl.org.spar.c4o.slash

open DoxAletheia.Rdf_Vocabulary

module c4o =
    let _namespace_name = "http://purl.org/spar/c4o/"
    /// <summary>
    /// The property linking an in-text reference pointer list to the bibliographic reference or references denoted by the in-text reference pointers within that list.
    /// <see href="http://purl.org/spar/c4o/pertainsTo"></see></summary>
    let pertainsTo = Namespaced_IRI.parse _namespace_name "pertainsTo" |> NamespacedName

    /// <summary>
    /// A list containing only in-text reference pointers denoting the specific bibliographic references to which the list pertains.
    /// <see href="http://purl.org/spar/c4o/InTextReferencePointerList"></see></summary>
    let InTextReferencePointerList =
        Namespaced_IRI.parse _namespace_name "InTextReferencePointerList" |> NamespacedName

    /// <summary>
    /// A property used to assert the connection between an in-text reference pointer and the bibliographic reference it points to.
    /// <see href="http://purl.org/spar/c4o/denotes"></see></summary>
    let denotes = Namespaced_IRI.parse _namespace_name "denotes" |> NamespacedName

    /// <summary>
    /// A source of information about bibliographic citations, such as Google Scholar, Web of Science or Scopus.
    /// <see href="http://purl.org/spar/c4o/BibliographicInformationSource"></see></summary>
    let BibliographicInformationSource =
        Namespaced_IRI.parse _namespace_name "BibliographicInformationSource" |> NamespacedName

    /// <summary>
    /// The in-text reference pointer is a textual element, usually embedded at the end of a phrase or sentence within the text of a document, that denotes a specific bibliographic reference present in the reference list of that document. For example, if the item in the reference list is:
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
    /// Or, less commonly, by the use of a code, e.g. by specifying the first surname letter of the first three author of the cited work followed by the last two digits of the year of publication, this string of characters being enclosed within square brackets, thus: [KRR99].
    /// <see href="http://purl.org/spar/c4o/InTextReferencePointer"></see></summary>
    let InTextReferencePointer =
        Namespaced_IRI.parse _namespace_name "InTextReferencePointer" |> NamespacedName

    /// <summary>
    /// The number of times a work has been cited globally, as determined from a particular bibliographic information source on a particular date.
    /// <see href="http://purl.org/spar/c4o/GlobalCitationCount"></see></summary>
    let GlobalCitationCount =
        Namespaced_IRI.parse _namespace_name "GlobalCitationCount" |> NamespacedName

    /// <summary>
    /// This property is used to indicate the textual context (e.g. a sentence or a paragraph) of a particular in-text reference pointer, this context providing the rhetorical motivation for the existence of that citation.
    /// <see href="http://purl.org/spar/c4o/hasContext"></see></summary>
    let hasContext = Namespaced_IRI.parse _namespace_name "hasContext" |> NamespacedName

    /// <summary>
    /// This class describes all the list items that must be used in the context of an in-text reference pointer list.
    /// <see href="http://purl.org/spar/c4o/InTextReferencePointerListItem"></see></summary>
    let InTextReferencePointerListItem =
        Namespaced_IRI.parse _namespace_name "InTextReferencePointerListItem" |> NamespacedName

    /// <summary>
    /// An in-text reference pointer list that pertains to exactly one bibliographic reference.
    /// <see href="http://purl.org/spar/c4o/SingleReferencePointerList"></see></summary>
    let SingleReferencePointerList =
        Namespaced_IRI.parse _namespace_name "SingleReferencePointerList" |> NamespacedName

    /// <summary>
    /// It is used to specify the textual content of a particular FRBR expression.
    /// <see href="http://purl.org/spar/c4o/hasContent"></see></summary>
    let hasContent = Namespaced_IRI.parse _namespace_name "hasContent" |> NamespacedName

    /// <summary>
    /// A property linking a publication entity to the property c40:GlobalCitationCount that specify how many times a work has been cited by others, according to a particular information source on a particular date.
    /// <see href="http://purl.org/spar/c4o/hasGlobalCitationFrequency"></see></summary>
    let hasGlobalCitationFrequency =
        Namespaced_IRI.parse _namespace_name "hasGlobalCitationFrequency" |> NamespacedName

    /// <summary>
    /// The date on which the global citation count of the cited entity was recorded from a named bibliographic information source.
    /// <see href="http://purl.org/spar/c4o/hasGlobalCountDate"></see></summary>
    let hasGlobalCountDate =
        Namespaced_IRI.parse _namespace_name "hasGlobalCountDate" |> NamespacedName

    /// <summary>
    /// A property linking the property c40:GlobalCitationCount to the bibliographic information source providing the global citation count information for a particular publication on a particular date.
    /// <see href="http://purl.org/spar/c4o/hasGlobalCountSource"></see></summary>
    let hasGlobalCountSource =
        Namespaced_IRI.parse _namespace_name "hasGlobalCountSource" |> NamespacedName

    /// <summary>
    /// An integer defining the value of the global citation count of a cited entity recorded from a named bibliographic information source on a particular date.
    /// <see href="http://purl.org/spar/c4o/hasGlobalCountValue"></see></summary>
    let hasGlobalCountValue =
        Namespaced_IRI.parse _namespace_name "hasGlobalCountValue" |> NamespacedName

    /// <summary>
    /// This property allows one to specify how many separate in-text reference pointers exist within the text of a citing document that all denote the same single bibliographic reference to a cited document (i.e how many distinct textual contexts exist within the citing document from which a citation is made to a particular document).
    /// <see href="http://purl.org/spar/c4o/hasInTextCitationFrequency"></see></summary>
    let hasInTextCitationFrequency =
        Namespaced_IRI.parse _namespace_name "hasInTextCitationFrequency" |> NamespacedName

    /// <summary>
    /// A property used to assert the connection between a bibliographic reference and the in-text reference pointer that points to it.
    /// <see href="http://purl.org/spar/c4o/isDenotedBy"></see></summary>
    let isDenotedBy =
        Namespaced_IRI.parse _namespace_name "isDenotedBy" |> NamespacedName

    /// <summary>
    /// A property allowing one FRBR expression to be declared to be of rhetorical relevance to another, for instance that the textual context of a particular in-text reference pointer in one document is relevant to a section of text within the published document that is referenced by the bibliographic reference denoted by the in-text reference pointer, and vice versa that the converse relevance also exists.
    /// <see href="http://purl.org/spar/c4o/isRelevantTo"></see></summary>
    let isRelevantTo =
        Namespaced_IRI.parse _namespace_name "isRelevantTo" |> NamespacedName
