namespace http.purl.org.spar.deo.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module deo =
    let _namespace_iri = Namespace_Iri deo |> NamespaceIRI
    /// <summary>
    ///   <para>deo:ProblemStatement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>problem statement</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/ProblemStatement">http://purl.org/spar/deo/ProblemStatement</seealso>
    let ProblemStatement = Prefixed_Name(deo, "ProblemStatement") |> PrefixedName
    /// <summary>
    ///   <para>deo:Results</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The report of the specific findings of an investigation, given without discussion or conclusion being drawn.</para>
    /// labels<para>results</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Results">http://purl.org/spar/deo/Results</seealso>
    let Results = Prefixed_Name(deo, "Results") |> PrefixedName
    /// <summary>
    ///   <para>deo:DatasetDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information describing a dataset held in an external database or repository and including a reference to it, such as a database ID or an accession number.</para>
    /// labels<para>dataset description</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/DatasetDescription">http://purl.org/spar/deo/DatasetDescription</seealso>
    let DatasetDescription = Prefixed_Name(deo, "DatasetDescription") |> PrefixedName
    /// <summary>
    ///   <para>deo:Acknowledgements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Usually part of the preface, or a separate section in its own right, often as part of the back matter, it acknowledges those, including funding agencies, who contributed to the undertaking of a research project described in a publication, or to the creation of the work in some way. In scientific articles, the acknowledgements are usually placed as a separated section immediately following the Discussion or Conclusions.</para>
    /// labels<para>acknowledgements</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Acknowledgements">http://purl.org/spar/deo/Acknowledgements</seealso>
    let Acknowledgements = Prefixed_Name(deo, "Acknowledgements") |> PrefixedName
    /// <summary>
    ///   <para>deo:Reference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A reference to a specific part of the document, or to another publication.</para>
    /// labels<para>reference</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Reference">http://purl.org/spar/deo/Reference</seealso>
    let Reference = Prefixed_Name(deo, "Reference") |> PrefixedName
    /// <summary>
    ///   <para>deo:Biography</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information describing a person and his or her life history and contributions.</para>
    /// labels<para>biography</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Biography">http://purl.org/spar/deo/Biography</seealso>
    let Biography = Prefixed_Name(deo, "Biography") |> PrefixedName
    /// <summary>
    ///   <para>deo:Caption</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Text accompanying another item, such as a picture.</para>
    /// labels<para>caption</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Caption">http://purl.org/spar/deo/Caption</seealso>
    let Caption = Prefixed_Name(deo, "Caption") |> PrefixedName
    /// <summary>
    ///   <para>deo:DiscourseElement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An element of a document that carries out a rhetorical function.</para>
    /// labels<para>discourse element</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/DiscourseElement">http://purl.org/spar/deo/DiscourseElement</seealso>
    let DiscourseElement = Prefixed_Name(deo, "DiscourseElement") |> PrefixedName
    /// <summary>
    ///   <para>deo:AuthorContribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description of the roles played by an author in the publication.</para>
    /// labels<para>author contribution</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/AuthorContribution">http://purl.org/spar/deo/AuthorContribution</seealso>
    let AuthorContribution = Prefixed_Name(deo, "AuthorContribution") |> PrefixedName
    /// <summary>
    ///   <para>deo:Background</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Presentation of information that is essential for understanding the situation or problem that is the subject of the publication. In a journal article, the background is usually part of the Introduction, but may be present as separated section.</para>
    /// labels<para>background</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Background">http://purl.org/spar/deo/Background</seealso>
    let Background = Prefixed_Name(deo, "Background") |> PrefixedName
    /// <summary>
    ///   <para>deo:Conclusion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A reflection on the preceding text, summarizing the evidence, arguments or premises presented in the document and their logical outcomes. Conclusions are a fundamental feature in academic research publications, and may be included in the Discussion section.</para>
    /// labels<para>conclusion</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Conclusion">http://purl.org/spar/deo/Conclusion</seealso>
    let Conclusion = Prefixed_Name(deo, "Conclusion") |> PrefixedName
    /// <summary>
    ///   <para>deo:Contribution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description of the part that this publication plays in the overall field.</para>
    /// labels<para>contribution</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Contribution">http://purl.org/spar/deo/Contribution</seealso>
    let Contribution = Prefixed_Name(deo, "Contribution") |> PrefixedName
    /// <summary>
    ///   <para>deo:Data</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A textual description of data used or produced in the work which the document describes, or the data themselves.</para>
    /// labels<para>data</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Data">http://purl.org/spar/deo/Data</seealso>
    let Data = Prefixed_Name(deo, "Data") |> PrefixedName
    /// <summary>
    ///   <para>deo:Dedication</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Text in which the author names the person or people for whom he/she has written the document, or to whose memory it is dedicated.</para>
    /// labels<para>dedication</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Dedication">http://purl.org/spar/deo/Dedication</seealso>
    let Dedication = Prefixed_Name(deo, "Dedication") |> PrefixedName
    /// <summary>
    ///   <para>deo:Discussion</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An interpretation and discussion of the results obtained and an analysis of their significance, in support of conclusions. These conclusions may be part of this discussion or may be included in a separate section of the document.</para>
    /// labels<para>discussion</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Discussion">http://purl.org/spar/deo/Discussion</seealso>
    let Discussion = Prefixed_Name(deo, "Discussion") |> PrefixedName

    /// <summary>
    ///   <para>deo:ExternalResourceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information describing an external resource and including a reference to that resource.</para>
    /// labels<para>external resource description</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/ExternalResourceDescription">http://purl.org/spar/deo/ExternalResourceDescription</seealso>
    let ExternalResourceDescription =
        Prefixed_Name(deo, "ExternalResourceDescription") |> PrefixedName

    /// <summary>
    ///   <para>deo:Epilogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A piece of writing at the end of a work of literature or drama, usually used to bring closure to the work.</para>
    /// labels<para>epilogue</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Epilogue">http://purl.org/spar/deo/Epilogue</seealso>
    let Epilogue = Prefixed_Name(deo, "Epilogue") |> PrefixedName
    /// <summary>
    ///   <para>deo:FutureWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A proposal for new investigation to be undertaken in order to continue and advance the work described in the publication.</para>
    /// labels<para>future work</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/FutureWork">http://purl.org/spar/deo/FutureWork</seealso>
    let FutureWork = Prefixed_Name(deo, "FutureWork") |> PrefixedName
    /// <summary>
    ///   <para>deo:Legend</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Informative text that explicitly explains another item, such as a figure or a table.</para>
    /// labels<para>legend</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Legend">http://purl.org/spar/deo/Legend</seealso>
    let Legend = Prefixed_Name(deo, "Legend") |> PrefixedName
    /// <summary>
    ///   <para>deo:Methods</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description in a research paper documenting the specialized methods used in the work described. This description is often combined with a description of the materials used, in a section entitled 'Methods and Materials', 'Experimental' or a related term.</para>
    /// labels<para>methods</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Methods">http://purl.org/spar/deo/Methods</seealso>
    let Methods = Prefixed_Name(deo, "Methods") |> PrefixedName
    /// <summary>
    ///   <para>deo:Evaluation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A consideration of the value, meaning and significance of the results obtained.</para>
    /// labels<para>evaluation</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Evaluation">http://purl.org/spar/deo/Evaluation</seealso>
    let Evaluation = Prefixed_Name(deo, "Evaluation") |> PrefixedName
    /// <summary>
    ///   <para>deo:Introduction</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An initial description which states the purpose and goals of the following writing, and, in the case of journal articles, typically includes background information on the research topic and a review of related work in the area.</para>
    /// labels<para>introduction</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Introduction">http://purl.org/spar/deo/Introduction</seealso>
    let Introduction = Prefixed_Name(deo, "Introduction") |> PrefixedName
    /// <summary>
    ///   <para>deo:Materials</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description in a research paper documenting the specialized materials used in the work described. This description is often combined with a description of the methods used, in a section entitled 'Methods and Materials', 'Experimental' or a related term.</para>
    /// labels<para>materials</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Materials">http://purl.org/spar/deo/Materials</seealso>
    let Materials = Prefixed_Name(deo, "Materials") |> PrefixedName
    /// <summary>
    ///   <para>deo:Motivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description of the justification for undertaking the work described in the publication.</para>
    /// labels<para>motivation</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Motivation">http://purl.org/spar/deo/Motivation</seealso>
    let Motivation = Prefixed_Name(deo, "Motivation") |> PrefixedName
    /// <summary>
    ///   <para>deo:Postscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Text added after the signature of a letter, or sometimes after the main body of an essay or book.</para>
    /// labels<para>postscript</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Postscript">http://purl.org/spar/deo/Postscript</seealso>
    let Postscript = Prefixed_Name(deo, "Postscript") |> PrefixedName
    /// <summary>
    ///   <para>deo:Prologue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A piece of writing at the beginning of a work of literature or drama, usually used to set the scene or to introduce the work.</para>
    /// labels<para>prologue</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Prologue">http://purl.org/spar/deo/Prologue</seealso>
    let Prologue = Prefixed_Name(deo, "Prologue") |> PrefixedName
    /// <summary>
    ///   <para>deo:RelatedWork</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The authors' critical review of current knowledge by specific reference to others' work, both in terms of substantive findings and theoretical and methodological contributions to a particular topic. This description is often included within the introduction section.</para>
    /// labels<para>related work</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/RelatedWork">http://purl.org/spar/deo/RelatedWork</seealso>
    let RelatedWork = Prefixed_Name(deo, "RelatedWork") |> PrefixedName
    /// <summary>
    ///   <para>deo:Scenario</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A presentation of a use case or test, based on a real or hypothetical situation, used to help someone think through a complex problem or system.</para>
    /// labels<para>scenario</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Scenario">http://purl.org/spar/deo/Scenario</seealso>
    let Scenario = Prefixed_Name(deo, "Scenario") |> PrefixedName

    /// <summary>
    ///   <para>deo:SupplementaryInformationDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Information describing supplementary information relating to the document, including references or links to the relevant supplementary information.</para>
    /// labels<para>supplementary information description</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/SupplementaryInformationDescription">http://purl.org/spar/deo/SupplementaryInformationDescription</seealso>
    let SupplementaryInformationDescription =
        Prefixed_Name(deo, "SupplementaryInformationDescription") |> PrefixedName

    /// <summary>
    ///   <para>deo:Model</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A description of a model used or produced by the work described in the publication.</para>
    /// labels<para>model</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/Model">http://purl.org/spar/deo/Model</seealso>
    let Model = Prefixed_Name(deo, "Model") |> PrefixedName

    /// <summary>
    ///   <para>deo:BibliographicReference</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A reference, usually contained in a footnote or a bibliographic reference list, that refer to another publication, such as a journal article, a book, a book chapter or a Web site. The inclusion of the bibliographic reference in a publication constitutes the performative act of bibliographic citation.</para>
    /// labels<para>bibliographic reference</para></remarks>
    /// <seealso href="http://purl.org/spar/deo/BibliographicReference">http://purl.org/spar/deo/BibliographicReference</seealso>
    let BibliographicReference =
        Prefixed_Name(deo, "BibliographicReference") |> PrefixedName
