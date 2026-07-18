namespace http.purl.org.spar.deo.slash

open DoxAletheia.Rdf_Vocabulary

module deo =
    let _namespace_name = "http://purl.org/spar/deo/"

    /// <summary>
    /// Usually part of the preface, or a separate section in its own right, often as part of the back matter, it acknowledges those, including funding agencies, who contributed to the undertaking of a research project described in a publication, or to the creation of the work in some way. In scientific articles, the acknowledgements are usually placed as a separated section immediately following the Discussion or Conclusions.
    /// <see href="http://purl.org/spar/deo/Acknowledgements"></see></summary>
    let Acknowledgements =
        Namespaced_IRI.parse _namespace_name "Acknowledgements" |> NamespacedName

    /// <summary>
    /// An element of a document that carries out a rhetorical function.
    /// <see href="http://purl.org/spar/deo/DiscourseElement"></see></summary>
    let DiscourseElement =
        Namespaced_IRI.parse _namespace_name "DiscourseElement" |> NamespacedName

    /// <summary>
    /// A description of the roles played by an author in the publication.
    /// <see href="http://purl.org/spar/deo/AuthorContribution"></see></summary>
    let AuthorContribution =
        Namespaced_IRI.parse _namespace_name "AuthorContribution" |> NamespacedName

    /// <summary>
    /// Presentation of information that is essential for understanding the situation or problem that is the subject of the publication. In a journal article, the background is usually part of the Introduction, but may be present as separated section.
    /// <see href="http://purl.org/spar/deo/Background"></see></summary>
    let Background = Namespaced_IRI.parse _namespace_name "Background" |> NamespacedName

    /// <summary>
    /// A reference, usually contained in a footnote or a bibliographic reference list, that refer to another publication, such as a journal article, a book, a book chapter or a Web site. The inclusion of the bibliographic reference in a publication constitutes the performative act of bibliographic citation.
    /// <see href="http://purl.org/spar/deo/BibliographicReference"></see></summary>
    let BibliographicReference =
        Namespaced_IRI.parse _namespace_name "BibliographicReference" |> NamespacedName

    /// <summary>
    /// A reference to a specific part of the document, or to another publication.
    /// <see href="http://purl.org/spar/deo/Reference"></see></summary>
    let Reference = Namespaced_IRI.parse _namespace_name "Reference" |> NamespacedName
    /// <summary>
    /// Information describing a person and his or her life history and contributions.
    /// <see href="http://purl.org/spar/deo/Biography"></see></summary>
    let Biography = Namespaced_IRI.parse _namespace_name "Biography" |> NamespacedName
    /// <summary>
    /// Text accompanying another item, such as a picture.
    /// <see href="http://purl.org/spar/deo/Caption"></see></summary>
    let Caption = Namespaced_IRI.parse _namespace_name "Caption" |> NamespacedName
    /// <summary>
    /// A reflection on the preceding text, summarizing the evidence, arguments or premises presented in the document and their logical outcomes. Conclusions are a fundamental feature in academic research publications, and may be included in the Discussion section.
    /// <see href="http://purl.org/spar/deo/Conclusion"></see></summary>
    let Conclusion = Namespaced_IRI.parse _namespace_name "Conclusion" |> NamespacedName

    /// <summary>
    /// A description of the part that this publication plays in the overall field.
    /// <see href="http://purl.org/spar/deo/Contribution"></see></summary>
    let Contribution =
        Namespaced_IRI.parse _namespace_name "Contribution" |> NamespacedName

    /// <summary>
    /// A textual description of data used or produced in the work which the document describes, or the data themselves.
    /// <see href="http://purl.org/spar/deo/Data"></see></summary>
    let Data = Namespaced_IRI.parse _namespace_name "Data" |> NamespacedName

    /// <summary>
    /// Information describing a dataset held in an external database or repository and including a reference to it, such as a database ID or an accession number.
    /// <see href="http://purl.org/spar/deo/DatasetDescription"></see></summary>
    let DatasetDescription =
        Namespaced_IRI.parse _namespace_name "DatasetDescription" |> NamespacedName

    /// <summary>
    /// Information describing an external resource and including a reference to that resource.
    /// <see href="http://purl.org/spar/deo/ExternalResourceDescription"></see></summary>
    let ExternalResourceDescription =
        Namespaced_IRI.parse _namespace_name "ExternalResourceDescription" |> NamespacedName

    /// <summary>
    /// Text in which the author names the person or people for whom he/she has written the document, or to whose memory it is dedicated.
    /// <see href="http://purl.org/spar/deo/Dedication"></see></summary>
    let Dedication = Namespaced_IRI.parse _namespace_name "Dedication" |> NamespacedName
    /// <summary>
    /// An interpretation and discussion of the results obtained and an analysis of their significance, in support of conclusions. These conclusions may be part of this discussion or may be included in a separate section of the document.
    /// <see href="http://purl.org/spar/deo/Discussion"></see></summary>
    let Discussion = Namespaced_IRI.parse _namespace_name "Discussion" |> NamespacedName
    /// <summary>
    /// A piece of writing at the end of a work of literature or drama, usually used to bring closure to the work.
    /// <see href="http://purl.org/spar/deo/Epilogue"></see></summary>
    let Epilogue = Namespaced_IRI.parse _namespace_name "Epilogue" |> NamespacedName
    /// <summary>
    /// A consideration of the value, meaning and significance of the results obtained.
    /// <see href="http://purl.org/spar/deo/Evaluation"></see></summary>
    let Evaluation = Namespaced_IRI.parse _namespace_name "Evaluation" |> NamespacedName
    /// <summary>
    /// A proposal for new investigation to be undertaken in order to continue and advance the work described in the publication.
    /// <see href="http://purl.org/spar/deo/FutureWork"></see></summary>
    let FutureWork = Namespaced_IRI.parse _namespace_name "FutureWork" |> NamespacedName

    /// <summary>
    /// An initial description which states the purpose and goals of the following writing, and, in the case of journal articles, typically includes background information on the research topic and a review of related work in the area.
    /// <see href="http://purl.org/spar/deo/Introduction"></see></summary>
    let Introduction =
        Namespaced_IRI.parse _namespace_name "Introduction" |> NamespacedName

    /// <summary>
    /// Informative text that explicitly explains another item, such as a figure or a table.
    /// <see href="http://purl.org/spar/deo/Legend"></see></summary>
    let Legend = Namespaced_IRI.parse _namespace_name "Legend" |> NamespacedName
    /// <summary>
    /// A description in a research paper documenting the specialized materials used in the work described. This description is often combined with a description of the methods used, in a section entitled 'Methods and Materials', 'Experimental' or a related term.
    /// <see href="http://purl.org/spar/deo/Materials"></see></summary>
    let Materials = Namespaced_IRI.parse _namespace_name "Materials" |> NamespacedName
    /// <summary>
    /// A description in a research paper documenting the specialized methods used in the work described. This description is often combined with a description of the materials used, in a section entitled 'Methods and Materials', 'Experimental' or a related term.
    /// <see href="http://purl.org/spar/deo/Methods"></see></summary>
    let Methods = Namespaced_IRI.parse _namespace_name "Methods" |> NamespacedName
    /// <summary>
    /// A description of a model used or produced by the work described in the publication.
    /// <see href="http://purl.org/spar/deo/Model"></see></summary>
    let Model = Namespaced_IRI.parse _namespace_name "Model" |> NamespacedName
    /// <summary>
    /// A description of the justification for undertaking the work described in the publication.
    /// <see href="http://purl.org/spar/deo/Motivation"></see></summary>
    let Motivation = Namespaced_IRI.parse _namespace_name "Motivation" |> NamespacedName
    /// <summary>
    /// Text added after the signature of a letter, or sometimes after the main body of an essay or book.
    /// <see href="http://purl.org/spar/deo/Postscript"></see></summary>
    let Postscript = Namespaced_IRI.parse _namespace_name "Postscript" |> NamespacedName

    /// <summary>
    ///   <see href="http://purl.org/spar/deo/ProblemStatement"></see>
    /// </summary>
    let ProblemStatement =
        Namespaced_IRI.parse _namespace_name "ProblemStatement" |> NamespacedName

    /// <summary>
    /// A piece of writing at the beginning of a work of literature or drama, usually used to set the scene or to introduce the work.
    /// <see href="http://purl.org/spar/deo/Prologue"></see></summary>
    let Prologue = Namespaced_IRI.parse _namespace_name "Prologue" |> NamespacedName

    /// <summary>
    /// The authors' critical review of current knowledge by specific reference to others' work, both in terms of substantive findings and theoretical and methodological contributions to a particular topic. This description is often included within the introduction section.
    /// <see href="http://purl.org/spar/deo/RelatedWork"></see></summary>
    let RelatedWork =
        Namespaced_IRI.parse _namespace_name "RelatedWork" |> NamespacedName

    /// <summary>
    /// The report of the specific findings of an investigation, given without discussion or conclusion being drawn.
    /// <see href="http://purl.org/spar/deo/Results"></see></summary>
    let Results = Namespaced_IRI.parse _namespace_name "Results" |> NamespacedName
    /// <summary>
    /// A presentation of a use case or test, based on a real or hypothetical situation, used to help someone think through a complex problem or system.
    /// <see href="http://purl.org/spar/deo/Scenario"></see></summary>
    let Scenario = Namespaced_IRI.parse _namespace_name "Scenario" |> NamespacedName

    /// <summary>
    /// Information describing supplementary information relating to the document, including references or links to the relevant supplementary information.
    /// <see href="http://purl.org/spar/deo/SupplementaryInformationDescription"></see></summary>
    let SupplementaryInformationDescription =
        Namespaced_IRI.parse _namespace_name "SupplementaryInformationDescription" |> NamespacedName
