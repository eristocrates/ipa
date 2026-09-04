#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module c4o =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/c4o/" "c4o"

    /// <summary>
    ///   <para>rdfs:comment : A source of information about bibliographic citations, such as Google Scholar, Web of Science or Scopus.</para>
    ///   <para>rdfs:label : bibliographic information source</para>
    ///   <a href="http://purl.org/spar/c4o/BibliographicInformationSource">c4o:BibliographicInformationSource</a>
    /// </summary>
    let BibliographicInformationSource =
        _prefixId.prefix "BibliographicInformationSource"

    /// <summary>
    ///   <para>rdfs:comment : The number of times a work has been cited globally, as determined from a particular bibliographic information source on a particular date.</para>
    ///   <para>rdfs:label : global citation count</para>
    ///   <a href="http://purl.org/spar/c4o/GlobalCitationCount">c4o:GlobalCitationCount</a>
    /// </summary>
    let GlobalCitationCount = _prefixId.prefix "GlobalCitationCount"
    /// <summary>
    ///   <para>dce:description : An in-text reference pointer is a textual device denoting a single bibliographic reference that is embedded in the text of a document within the context of a particular sentence.</para>
    ///   <para>rdfs:label : in-text reference pointer</para>
    ///   <para>rdfs:comment : The in-text reference pointer is a textual element, usually embedded at the end of a phrase or sentence within the text of a document, that denotes a specific bibliographic reference present in the reference list of that document. For example, if the item in the reference list is:
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
    /// Or, less commonly, by the use of a code, e.g. by specifying the first surname letter of the first three author of the cited work followed by the last two digits of the year of publication, this string of characters being enclosed within square brackets, thus: [KRR99].</para>
    ///   <a href="http://purl.org/spar/c4o/InTextReferencePointer">c4o:InTextReferencePointer</a>
    /// </summary>
    let InTextReferencePointer = _prefixId.prefix "InTextReferencePointer"
    /// <summary>
    ///   <para>dce:description : An in-text reference pointer list can contains only in-text reference pointer list items and it always pertains to one or more bibliographic references.</para>
    ///   <para>rdfs:comment : A list containing only in-text reference pointers denoting the specific bibliographic references to which the list pertains.</para>
    ///   <para>rdfs:label : in-text reference pointer list</para>
    ///   <a href="http://purl.org/spar/c4o/InTextReferencePointerList">c4o:InTextReferencePointerList</a>
    /// </summary>
    let InTextReferencePointerList = _prefixId.prefix "InTextReferencePointerList"

    /// <summary>
    ///   <para>rdfs:comment : This class describes all the list items that must be used in the context of an in-text reference pointer list.</para>
    ///   <para>dce:description : An in-text reference pointer list item can contain only a single in-text reference pointer.
    ///
    /// Note that, as specified through the hasKey assertion, such a list cannot contain more than one item containing the same in-text reference pointer entity.</para>
    ///   <para>rdfs:label : in-text reference pointer list item</para>
    ///   <a href="http://purl.org/spar/c4o/InTextReferencePointerListItem">c4o:InTextReferencePointerListItem</a>
    /// </summary>
    let InTextReferencePointerListItem =
        _prefixId.prefix "InTextReferencePointerListItem"

    /// <summary>
    ///   <para>rdfs:comment : An in-text reference pointer list that pertains to exactly one bibliographic reference.</para>
    ///   <para>dce:description : A single reference pointer list pertains only to one bibliographic reference.
    ///
    /// Note that this semantic constraint is handled by the combined use of a particular restriction of this class, i.e. that the list pertains to exactly one owl:Thing, and that the following SWRL rule applies:
    ///
    /// c4o:InTextReferencePointerList(?l), c4o:denotes(?p, ?r), swan:item(?l, ?i), swan:itemContent(?i, ?p) -&gt; c4o:pertainsTo(?l, ?r)</para>
    ///   <para>rdfs:label : single reference pointer list</para>
    ///   <a href="http://purl.org/spar/c4o/SingleReferencePointerList">c4o:SingleReferencePointerList</a>
    /// </summary>
    let SingleReferencePointerList = _prefixId.prefix "SingleReferencePointerList"
    /// <summary>
    ///   <para>rdfs:comment : A property used to assert the connection between an in-text reference pointer and the bibliographic reference it points to.</para>
    ///   <para>rdfs:label : denotes</para>
    ///   <a href="http://purl.org/spar/c4o/denotes">c4o:denotes</a>
    /// </summary>
    let denotes = _prefixId.prefix "denotes"
    /// <summary>
    ///   <para>rdfs:comment : It is used to specify the textual content of a particular FRBR expression.</para>
    ///   <para>rdfs:label : has content</para>
    ///   <a href="http://purl.org/spar/c4o/hasContent">c4o:hasContent</a>
    /// </summary>
    let hasContent = _prefixId.prefix "hasContent"
    /// <summary>
    ///   <para>rdfs:comment : This property is used to indicate the textual context (e.g. a sentence or a paragraph) of a particular in-text reference pointer, this context providing the rhetorical motivation for the existence of that citation.</para>
    ///   <para>dce:description : Any FRBR expression that constitutes the range of this property can have at most one particular literal textual content specified through the property c4o:hasContent.</para>
    ///   <para>rdfs:label : has context</para>
    ///   <a href="http://purl.org/spar/c4o/hasContext">c4o:hasContext</a>
    /// </summary>
    let hasContext = _prefixId.prefix "hasContext"
    /// <summary>
    ///   <para>rdfs:comment : A property linking a publication entity to the property c40:GlobalCitationCount that specify how many times a work has been cited by others, according to a particular information source on a particular date.</para>
    ///   <para>rdfs:label : has global citation frequency</para>
    ///   <a href="http://purl.org/spar/c4o/hasGlobalCitationFrequency">c4o:hasGlobalCitationFrequency</a>
    /// </summary>
    let hasGlobalCitationFrequency = _prefixId.prefix "hasGlobalCitationFrequency"
    /// <summary>
    ///   <para>rdfs:comment : The date on which the global citation count of the cited entity was recorded from a named bibliographic information source.</para>
    ///   <para>rdfs:label : has global count date</para>
    ///   <a href="http://purl.org/spar/c4o/hasGlobalCountDate">c4o:hasGlobalCountDate</a>
    /// </summary>
    let hasGlobalCountDate = _prefixId.prefix "hasGlobalCountDate"
    /// <summary>
    ///   <para>rdfs:comment : A property linking the property c40:GlobalCitationCount to the bibliographic information source providing the global citation count information for a particular publication on a particular date.</para>
    ///   <para>rdfs:label : has global count source</para>
    ///   <a href="http://purl.org/spar/c4o/hasGlobalCountSource">c4o:hasGlobalCountSource</a>
    /// </summary>
    let hasGlobalCountSource = _prefixId.prefix "hasGlobalCountSource"
    /// <summary>
    ///   <para>rdfs:comment : An integer defining the value of the global citation count of a cited entity recorded from a named bibliographic information source on a particular date.</para>
    ///   <para>rdfs:label : has global count value</para>
    ///   <a href="http://purl.org/spar/c4o/hasGlobalCountValue">c4o:hasGlobalCountValue</a>
    /// </summary>
    let hasGlobalCountValue = _prefixId.prefix "hasGlobalCountValue"
    /// <summary>
    ///   <para>rdfs:comment : This property allows one to specify how many separate in-text reference pointers exist within the text of a citing document that all denote the same single bibliographic reference to a cited document (i.e how many distinct textual contexts exist within the citing document from which a citation is made to a particular document).</para>
    ///   <para>rdfs:label : has in text citation frequency</para>
    ///   <a href="http://purl.org/spar/c4o/hasInTextCitationFrequency">c4o:hasInTextCitationFrequency</a>
    /// </summary>
    let hasInTextCitationFrequency = _prefixId.prefix "hasInTextCitationFrequency"
    /// <summary>
    ///   <para>rdfs:comment : A property used to assert the connection between a bibliographic reference and the in-text reference pointer that points to it.</para>
    ///   <para>rdfs:label : is denoted by</para>
    ///   <a href="http://purl.org/spar/c4o/isDenotedBy">c4o:isDenotedBy</a>
    /// </summary>
    let isDenotedBy = _prefixId.prefix "isDenotedBy"
    /// <summary>
    ///   <para>rdfs:comment : A property allowing one FRBR expression to be declared to be of rhetorical relevance to another, for instance that the textual context of a particular in-text reference pointer in one document is relevant to a section of text within the published document that is referenced by the bibliographic reference denoted by the in-text reference pointer, and vice versa that the converse relevance also exists.</para>
    ///   <para>rdfs:label : is relevant to</para>
    ///   <a href="http://purl.org/spar/c4o/isRelevantTo">c4o:isRelevantTo</a>
    /// </summary>
    let isRelevantTo = _prefixId.prefix "isRelevantTo"
    /// <summary>
    ///   <para>rdfs:comment : The property linking an in-text reference pointer list to the bibliographic reference or references denoted by the in-text reference pointers within that list.</para>
    ///   <para>rdfs:label : pertains to</para>
    ///   <a href="http://purl.org/spar/c4o/pertainsTo">c4o:pertainsTo</a>
    /// </summary>
    let pertainsTo = _prefixId.prefix "pertainsTo"
