#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module deo =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/spar/deo/" "deo"
    /// <summary>
    ///   <para>rdfs:comment : Usually part of the preface, or a separate section in its own right, often as part of the back matter, it acknowledges those, including funding agencies, who contributed to the undertaking of a research project described in a publication, or to the creation of the work in some way. In scientific articles, the acknowledgements are usually placed as a separated section immediately following the Discussion or Conclusions.</para>
    ///   <para>rdfs:label : acknowledgements</para>
    ///   <a href="http://purl.org/spar/deo/Acknowledgements">deo:Acknowledgements</a>
    /// </summary>
    let Acknowledgements = _prefixId.prefix "Acknowledgements"
    /// <summary>
    ///   <para>rdfs:comment : A description of the roles played by an author in the publication.</para>
    ///   <para>rdfs:label : author contribution</para>
    ///   <a href="http://purl.org/spar/deo/AuthorContribution">deo:AuthorContribution</a>
    /// </summary>
    let AuthorContribution = _prefixId.prefix "AuthorContribution"
    /// <summary>
    ///   <para>rdfs:comment : Presentation of information that is essential for understanding the situation or problem that is the subject of the publication. In a journal article, the background is usually part of the Introduction, but may be present as separated section.^^xsd:string</para>
    ///   <para>rdfs:label : background^^xsd:string</para>
    ///   <a href="http://purl.org/spar/deo/Background">deo:Background</a>
    /// </summary>
    let Background = _prefixId.prefix "Background"
    /// <summary>
    ///   <para>rdfs:comment : A reference, usually contained in a footnote or a bibliographic reference list, that refer to another publication, such as a journal article, a book, a book chapter or a Web site. The inclusion of the bibliographic reference in a publication constitutes the performative act of bibliographic citation.</para>
    ///   <para>rdfs:label : bibliographic reference</para>
    ///   <a href="http://purl.org/spar/deo/BibliographicReference">deo:BibliographicReference</a>
    /// </summary>
    let BibliographicReference = _prefixId.prefix "BibliographicReference"
    /// <summary>
    ///   <para>rdfs:comment : Information describing a person and his or her life history and contributions.</para>
    ///   <para>rdfs:label : biography</para>
    ///   <a href="http://purl.org/spar/deo/Biography">deo:Biography</a>
    /// </summary>
    let Biography = _prefixId.prefix "Biography"
    /// <summary>
    ///   <para>rdfs:comment : Text accompanying another item, such as a picture.</para>
    ///   <para>rdfs:label : caption</para>
    ///   <a href="http://purl.org/spar/deo/Caption">deo:Caption</a>
    /// </summary>
    let Caption = _prefixId.prefix "Caption"
    /// <summary>
    ///   <para>rdfs:comment : A reflection on the preceding text, summarizing the evidence, arguments or premises presented in the document and their logical outcomes. Conclusions are a fundamental feature in academic research publications, and may be included in the Discussion section.^^xsd:string</para>
    ///   <para>rdfs:label : conclusion^^xsd:string</para>
    ///   <a href="http://purl.org/spar/deo/Conclusion">deo:Conclusion</a>
    /// </summary>
    let Conclusion = _prefixId.prefix "Conclusion"
    /// <summary>
    ///   <para>rdfs:comment : A description of the part that this publication plays in the overall field.^^xsd:string</para>
    ///   <para>rdfs:label : contribution^^xsd:string</para>
    ///   <a href="http://purl.org/spar/deo/Contribution">deo:Contribution</a>
    /// </summary>
    let Contribution = _prefixId.prefix "Contribution"
    /// <summary>
    ///   <para>rdfs:comment : A textual description of data used or produced in the work which the document describes, or the data themselves.</para>
    ///   <para>rdfs:label : data</para>
    ///   <a href="http://purl.org/spar/deo/Data">deo:Data</a>
    /// </summary>
    let Data = _prefixId.prefix "Data"
    /// <summary>
    ///   <para>rdfs:comment : Information describing a dataset held in an external database or repository and including a reference to it, such as a database ID or an accession number.</para>
    ///   <para>rdfs:label : dataset description</para>
    ///   <a href="http://purl.org/spar/deo/DatasetDescription">deo:DatasetDescription</a>
    /// </summary>
    let DatasetDescription = _prefixId.prefix "DatasetDescription"
    /// <summary>
    ///   <para>rdfs:comment : Text in which the author names the person or people for whom he/she has written the document, or to whose memory it is dedicated.</para>
    ///   <para>rdfs:label : dedication</para>
    ///   <a href="http://purl.org/spar/deo/Dedication">deo:Dedication</a>
    /// </summary>
    let Dedication = _prefixId.prefix "Dedication"
    /// <summary>
    ///   <para>rdfs:comment : An element of a document that carries out a rhetorical function.</para>
    ///   <para>rdfs:label : discourse element</para>
    ///   <a href="http://purl.org/spar/deo/DiscourseElement">deo:DiscourseElement</a>
    /// </summary>
    let DiscourseElement = _prefixId.prefix "DiscourseElement"
    /// <summary>
    ///   <para>rdfs:comment : An interpretation and discussion of the results obtained and an analysis of their significance, in support of conclusions. These conclusions may be part of this discussion or may be included in a separate section of the document.^^xsd:string</para>
    ///   <para>rdfs:label : discussion^^xsd:string</para>
    ///   <a href="http://purl.org/spar/deo/Discussion">deo:Discussion</a>
    /// </summary>
    let Discussion = _prefixId.prefix "Discussion"
    /// <summary>
    ///   <para>rdfs:comment : A piece of writing at the end of a work of literature or drama, usually used to bring closure to the work.</para>
    ///   <para>rdfs:label : epilogue</para>
    ///   <a href="http://purl.org/spar/deo/Epilogue">deo:Epilogue</a>
    /// </summary>
    let Epilogue = _prefixId.prefix "Epilogue"
    /// <summary>
    ///   <para>rdfs:comment : A consideration of the value, meaning and significance of the results obtained.^^xsd:string</para>
    ///   <para>rdfs:label : evaluation^^xsd:string</para>
    ///   <a href="http://purl.org/spar/deo/Evaluation">deo:Evaluation</a>
    /// </summary>
    let Evaluation = _prefixId.prefix "Evaluation"
    /// <summary>
    ///   <para>rdfs:comment : Information describing an external resource and including a reference to that resource.</para>
    ///   <para>rdfs:label : external resource description</para>
    ///   <a href="http://purl.org/spar/deo/ExternalResourceDescription">deo:ExternalResourceDescription</a>
    /// </summary>
    let ExternalResourceDescription = _prefixId.prefix "ExternalResourceDescription"
    /// <summary>
    ///   <para>rdfs:comment : A proposal for new investigation to be undertaken in order to continue and advance the work described in the publication.</para>
    ///   <para>rdfs:label : future work</para>
    ///   <a href="http://purl.org/spar/deo/FutureWork">deo:FutureWork</a>
    /// </summary>
    let FutureWork = _prefixId.prefix "FutureWork"
    /// <summary>
    ///   <para>rdfs:comment : An initial description which states the purpose and goals of the following writing, and, in the case of journal articles, typically includes background information on the research topic and a review of related work in the area.</para>
    ///   <para>rdfs:label : introduction</para>
    ///   <a href="http://purl.org/spar/deo/Introduction">deo:Introduction</a>
    /// </summary>
    let Introduction = _prefixId.prefix "Introduction"
    /// <summary>
    ///   <para>rdfs:comment : Informative text that explicitly explains another item, such as a figure or a table.</para>
    ///   <para>rdfs:label : legend</para>
    ///   <a href="http://purl.org/spar/deo/Legend">deo:Legend</a>
    /// </summary>
    let Legend = _prefixId.prefix "Legend"
    /// <summary>
    ///   <para>rdfs:comment : A description in a research paper documenting the specialized materials used in the work described. This description is often combined with a description of the methods used, in a section entitled 'Methods and Materials', 'Experimental' or a related term.</para>
    ///   <para>rdfs:label : materials</para>
    ///   <a href="http://purl.org/spar/deo/Materials">deo:Materials</a>
    /// </summary>
    let Materials = _prefixId.prefix "Materials"
    /// <summary>
    ///   <para>rdfs:comment : A description in a research paper documenting the specialized methods used in the work described. This description is often combined with a description of the materials used, in a section entitled 'Methods and Materials', 'Experimental' or a related term.</para>
    ///   <para>rdfs:label : methods</para>
    ///   <a href="http://purl.org/spar/deo/Methods">deo:Methods</a>
    /// </summary>
    let Methods = _prefixId.prefix "Methods"
    /// <summary>
    ///   <para>rdfs:comment : A description of a model used or produced by the work described in the publication.</para>
    ///   <para>rdfs:label : model</para>
    ///   <a href="http://purl.org/spar/deo/Model">deo:Model</a>
    /// </summary>
    let Model = _prefixId.prefix "Model"
    /// <summary>
    ///   <para>rdfs:comment : A description of the justification for undertaking the work described in the publication.^^xsd:string</para>
    ///   <para>rdfs:label : motivation^^xsd:string</para>
    ///   <a href="http://purl.org/spar/deo/Motivation">deo:Motivation</a>
    /// </summary>
    let Motivation = _prefixId.prefix "Motivation"
    /// <summary>
    ///   <para>rdfs:comment : Text added after the signature of a letter, or sometimes after the main body of an essay or book.</para>
    ///   <para>rdfs:label : postscript</para>
    ///   <a href="http://purl.org/spar/deo/Postscript">deo:Postscript</a>
    /// </summary>
    let Postscript = _prefixId.prefix "Postscript"
    /// <summary>
    ///   <para>dce:description : A concise description of the issues that needed to be addressed by a work described in the document.</para>
    ///   <para>rdfs:label : problem statement</para>
    ///   <a href="http://purl.org/spar/deo/ProblemStatement">deo:ProblemStatement</a>
    /// </summary>
    let ProblemStatement = _prefixId.prefix "ProblemStatement"
    /// <summary>
    ///   <para>rdfs:comment : A piece of writing at the beginning of a work of literature or drama, usually used to set the scene or to introduce the work.</para>
    ///   <para>rdfs:label : prologue</para>
    ///   <a href="http://purl.org/spar/deo/Prologue">deo:Prologue</a>
    /// </summary>
    let Prologue = _prefixId.prefix "Prologue"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a specific part of the document, or to another publication.</para>
    ///   <para>rdfs:label : reference</para>
    ///   <a href="http://purl.org/spar/deo/Reference">deo:Reference</a>
    /// </summary>
    let Reference = _prefixId.prefix "Reference"
    /// <summary>
    ///   <para>rdfs:comment : The authors' critical review of current knowledge by specific reference to others' work, both in terms of substantive findings and theoretical and methodological contributions to a particular topic. This description is often included within the introduction section.</para>
    ///   <para>rdfs:label : related work</para>
    ///   <a href="http://purl.org/spar/deo/RelatedWork">deo:RelatedWork</a>
    /// </summary>
    let RelatedWork = _prefixId.prefix "RelatedWork"
    /// <summary>
    ///   <para>rdfs:comment : The report of the specific findings of an investigation, given without discussion or conclusion being drawn.</para>
    ///   <para>rdfs:label : results</para>
    ///   <a href="http://purl.org/spar/deo/Results">deo:Results</a>
    /// </summary>
    let Results = _prefixId.prefix "Results"
    /// <summary>
    ///   <para>rdfs:comment : A presentation of a use case or test, based on a real or hypothetical situation, used to help someone think through a complex problem or system.^^xsd:string</para>
    ///   <para>rdfs:label : scenario^^xsd:string</para>
    ///   <a href="http://purl.org/spar/deo/Scenario">deo:Scenario</a>
    /// </summary>
    let Scenario = _prefixId.prefix "Scenario"

    /// <summary>
    ///   <para>rdfs:comment : Information describing supplementary information relating to the document, including references or links to the relevant supplementary information.</para>
    ///   <para>rdfs:label : supplementary information description</para>
    ///   <a href="http://purl.org/spar/deo/SupplementaryInformationDescription">deo:SupplementaryInformationDescription</a>
    /// </summary>
    let SupplementaryInformationDescription =
        _prefixId.prefix "SupplementaryInformationDescription"
