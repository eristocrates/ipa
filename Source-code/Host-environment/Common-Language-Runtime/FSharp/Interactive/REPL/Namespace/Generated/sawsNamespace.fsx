#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module saws =
    let _prefixId = PrefixId.fromNamespaceLabel "http://purl.org/saws/ontology#" "saws"
    /// <summary>
    ///   <para>rdfs:comment : The text that is written in an manuscript</para>
    ///   <para>rdfs:label : abstract manuscript text</para>
    ///   <a href="http://purl.org/saws/ontology#AbstractManuscriptText">saws:AbstractManuscriptText</a>
    /// </summary>
    let AbstractManuscriptText = _prefixId.prefix "AbstractManuscriptText"
    /// <summary>
    ///   <para>rdfs:comment : Person to whom original authorship of a linguistic object is attributed, as the source of that linguistic object</para>
    ///   <para>rdfs:label : attributed author</para>
    ///   <a href="http://purl.org/saws/ontology#AttributedAuthor">saws:AttributedAuthor</a>
    /// </summary>
    let AttributedAuthor = _prefixId.prefix "AttributedAuthor"
    /// <summary>
    ///   <para>rdfs:comment : The gnomologium or other compilation/collection on which we are working</para>
    ///   <para>rdfs:label : collection instance</para>
    ///   <a href="http://purl.org/saws/ontology#CollectionInstance">saws:CollectionInstance</a>
    /// </summary>
    let CollectionInstance = _prefixId.prefix "CollectionInstance"
    /// <summary>
    ///   <para>rdfs:comment : Comment on a part of the material, usually from the modern editor.
    ///
    /// N.B. The Comment class is for comments on a material that do not physically exist on that material. If a comment has been physically written on a material (usually in the margin), then this should be represented as an instance of Marginalia. </para>
    ///   <para>rdfs:label : comment</para>
    ///   <a href="http://purl.org/saws/ontology#Comment">saws:Comment</a>
    /// </summary>
    let Comment = _prefixId.prefix "Comment"
    /// <summary>
    ///   <para>rdfs:comment : A basic unit of interest within the Material: a division of a collection instance/section, for more exact reference than when using a section – this identifies basic units of interest in the material for SAWS (marked in TEI as &lt;seg&gt;)</para>
    ///   <para>rdfs:label : content item</para>
    ///   <a href="http://purl.org/saws/ontology#ContentItem">saws:ContentItem</a>
    /// </summary>
    let ContentItem = _prefixId.prefix "ContentItem"
    /// <summary>
    ///   <para>rdfs:comment : Decorative element (picture, ornamentation, etc) within the material, either meaning-bearing or non meaning-bearing</para>
    ///   <para>rdfs:label : decorative item</para>
    ///   <a href="http://purl.org/saws/ontology#DecorativeItem">saws:DecorativeItem</a>
    /// </summary>
    let DecorativeItem = _prefixId.prefix "DecorativeItem"
    /// <summary>
    ///   <para>rdfs:comment : A content item that is defining a concept or term used in the material</para>
    ///   <para>rdfs:label : definition</para>
    ///   <a href="http://purl.org/saws/ontology#Definition">saws:Definition</a>
    /// </summary>
    let Definition = _prefixId.prefix "Definition"
    /// <summary>
    ///   <para>rdfs:comment : Any edited material, known or unknown, including texts such as the Bible and Kekaumenos</para>
    ///   <para>rdfs:label : edition</para>
    ///   <a href="http://purl.org/saws/ontology#Edition">saws:Edition</a>
    /// </summary>
    let Edition = _prefixId.prefix "Edition"
    /// <summary>
    ///   <para>rdfs:comment : A modern scholar editing material to produce an edition, in the age of printing and beyond</para>
    ///   <para>rdfs:label : editor</para>
    ///   <a href="http://purl.org/saws/ontology#Editor">saws:Editor</a>
    /// </summary>
    let Editor = _prefixId.prefix "Editor"
    /// <summary>
    ///   <para>rdfs:comment : Any division within a linguistic object created by an editor, e.g. to make the navigation of the text clearer or to mark a region of interest</para>
    ///   <para>rdfs:label : editor section</para>
    ///   <a href="http://purl.org/saws/ontology#EditorSection">saws:EditorSection</a>
    /// </summary>
    let EditorSection = _prefixId.prefix "EditorSection"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a title that was assigned outside the manuscript by an editor</para>
    ///   <para>rdfs:label : editor title</para>
    ///   <a href="http://purl.org/saws/ontology#EditorTitle">saws:EditorTitle</a>
    /// </summary>
    let EditorTitle = _prefixId.prefix "EditorTitle"
    /// <summary>
    ///   <para>rdfs:label : epilogue</para>
    ///   <a href="http://purl.org/saws/ontology#Epilogue">saws:Epilogue</a>
    /// </summary>
    let Epilogue = _prefixId.prefix "Epilogue"
    /// <summary>
    ///   <para>rdfs:comment : A grouping of related Materials - this is a concept, an interpretation, rather than a physical thing</para>
    ///   <para>rdfs:label : family</para>
    ///   <a href="http://purl.org/saws/ontology#Family">saws:Family</a>
    /// </summary>
    let Family = _prefixId.prefix "Family"
    /// <summary>
    ///   <para>rdfs:comment : The physical instance of an abstract manuscript text or collection instance which we hypothesise may have existed, but which we do not have - it is presumed lost or destroyed</para>
    ///   <para>rdfs:label : hypothesised instance</para>
    ///   <a href="http://purl.org/saws/ontology#HypothesisedInstance">saws:HypothesisedInstance</a>
    /// </summary>
    let HypothesisedInstance = _prefixId.prefix "HypothesisedInstance"
    /// <summary>
    ///   <para>rdfs:comment : An Institution can own materials, be located at places, and include persons as members</para>
    ///   <para>rdfs:label : institution</para>
    ///   <a href="http://purl.org/saws/ontology#Institution">saws:Institution</a>
    /// </summary>
    let Institution = _prefixId.prefix "Institution"
    /// <summary>
    ///   <para>rdfs:comment : A physical gap in the physical manuscript</para>
    ///   <para>rdfs:label : lacuna</para>
    ///   <a href="http://purl.org/saws/ontology#Lacuna">saws:Lacuna</a>
    /// </summary>
    let Lacuna = _prefixId.prefix "Lacuna"
    /// <summary>
    ///   <para>rdfs:comment : A physical location within a physical manuscript</para>
    ///   <para>rdfs:label : locus</para>
    ///   <a href="http://purl.org/saws/ontology#Locus">saws:Locus</a>
    /// </summary>
    let Locus = _prefixId.prefix "Locus"
    /// <summary>
    ///   <para>rdfs:comment : A physical section of a physical manuscript</para>
    ///   <para>rdfs:label : manuscript part</para>
    ///   <a href="http://purl.org/saws/ontology#ManuscriptPart">saws:ManuscriptPart</a>
    /// </summary>
    let ManuscriptPart = _prefixId.prefix "ManuscriptPart"
    /// <summary>
    ///   <para>rdfs:comment : Remark(s) physically written in the margin of the material by a scribe, not necessarily the original scribe.
    ///
    /// N.B. If a comment has been physically written on a material (usually in the margin), then this should be represented as an instance of Marginalia. The Comment class is for comments on a material that don’t physically exist on that material</para>
    ///   <para>rdfs:label : marginalia</para>
    ///   <a href="http://purl.org/saws/ontology#Marginalia">saws:Marginalia</a>
    /// </summary>
    let Marginalia = _prefixId.prefix "Marginalia"
    /// <summary>
    ///   <para>rdfs:comment : Any of the texts we are working on in SAWS or that we are referring to</para>
    ///   <para>rdfs:label : material</para>
    ///   <a href="http://purl.org/saws/ontology#Material">saws:Material</a>
    /// </summary>
    let Material = _prefixId.prefix "Material"
    /// <summary>
    ///   <para>rdfs:comment : Narrative text that is not a saying itself, that either stands alone or is the text surrounding or immediately preceding or following the Statement (saying), e.g. 'Aristotle says...', 'The frogs asked for a king.’, ‘Aristotle is a lover of knowledge’</para>
    ///   <para>rdfs:label : narrative</para>
    ///   <a href="http://purl.org/saws/ontology#Narrative">saws:Narrative</a>
    /// </summary>
    let Narrative = _prefixId.prefix "Narrative"
    /// <summary>
    ///   <para>rdfs:comment : A material produced by scribe transcription rather than being edited in modern times</para>
    ///   <para>rdfs:label : original material</para>
    ///   <a href="http://purl.org/saws/ontology#OriginalMaterial">saws:OriginalMaterial</a>
    /// </summary>
    let OriginalMaterial = _prefixId.prefix "OriginalMaterial"
    /// <summary>
    ///   <para>rdfs:comment : A unit of the material within a content item, as identified by the modern editor, which isn’t a narrative, statement, or definition</para>
    ///   <para>rdfs:label : other content item</para>
    ///   <a href="http://purl.org/saws/ontology#OtherContentItem">saws:OtherContentItem</a>
    /// </summary>
    let OtherContentItem = _prefixId.prefix "OtherContentItem"
    /// <summary>
    ///   <para>rdfs:comment : The physical object on which the material we are working on exists</para>
    ///   <para>rdfs:label : physical manuscript</para>
    ///   <a href="http://purl.org/saws/ontology#PhysicalManuscript">saws:PhysicalManuscript</a>
    /// </summary>
    let PhysicalManuscript = _prefixId.prefix "PhysicalManuscript"
    /// <summary>
    ///   <para>rdfs:label : prologue</para>
    ///   <a href="http://purl.org/saws/ontology#Prologue">saws:Prologue</a>
    /// </summary>
    let Prologue = _prefixId.prefix "Prologue"
    /// <summary>
    ///   <para>rdfs:comment : Manuscript whose parts are now distributed as separate manuscript parts, so no longer exists as a whole, but can still be identified</para>
    ///   <para>rdfs:label : reconstructed manuscript</para>
    ///   <a href="http://purl.org/saws/ontology#ReconstructedManuscript">saws:ReconstructedManuscript</a>
    /// </summary>
    let ReconstructedManuscript = _prefixId.prefix "ReconstructedManuscript"
    /// <summary>
    ///   <para>rdfs:comment : The producer / author / copier of a linguistic object (excluding editions), in the medieval age. The scribe can be named or unnamed</para>
    ///   <para>rdfs:label : scribe</para>
    ///   <a href="http://purl.org/saws/ontology#Scribe">saws:Scribe</a>
    /// </summary>
    let Scribe = _prefixId.prefix "Scribe"
    /// <summary>
    ///   <para>rdfs:comment : Any division within a linguistic object indicated by a scribe</para>
    ///   <para>rdfs:label : scribe section</para>
    ///   <a href="http://purl.org/saws/ontology#ScribeSection">saws:ScribeSection</a>
    /// </summary>
    let ScribeSection = _prefixId.prefix "ScribeSection"
    /// <summary>
    ///   <para>rdfs:comment : Indicates a title that was assigned within the manuscript by a scribe</para>
    ///   <para>rdfs:label : scribe title</para>
    ///   <a href="http://purl.org/saws/ontology#ScribeTitle">saws:ScribeTitle</a>
    /// </summary>
    let ScribeTitle = _prefixId.prefix "ScribeTitle"
    /// <summary>
    ///   <para>rdfs:comment : A division of a linguistic object e.g. chapter, verse, for larger-scale reference than when using a content item. These can be nested/numbered</para>
    ///   <para>rdfs:label : section</para>
    ///   <a href="http://purl.org/saws/ontology#Section">saws:Section</a>
    /// </summary>
    let Section = _prefixId.prefix "Section"
    /// <summary>
    ///   <para>rdfs:comment : The actual saying, e.g. 'All men are mortal'</para>
    ///   <para>rdfs:label : statement</para>
    ///   <a href="http://purl.org/saws/ontology#Statement">saws:Statement</a>
    /// </summary>
    let Statement = _prefixId.prefix "Statement"
    /// <summary>
    ///   <para>rdfs:comment : Person who is described in the text content as having transmitted a content item or other linguistic objects, for example ‘[Transmitter] said that [AttributedAuthor] said … (ContentItem)</para>
    ///   <para>rdfs:label : transmitter</para>
    ///   <a href="http://purl.org/saws/ontology#Transmitter">saws:Transmitter</a>
    /// </summary>
    let Transmitter = _prefixId.prefix "Transmitter"
    /// <summary>
    ///   <para>rdfs:comment : To indicate that Marginalia have been written on the manuscript,e .g. in the margins</para>
    ///   <para>rdfs:label : are marginalia on</para>
    ///   <a href="http://purl.org/saws/ontology#areMarginaliaOn">saws:areMarginaliaOn</a>
    /// </summary>
    let areMarginaliaOn = _prefixId.prefix "areMarginaliaOn"
    /// <summary>
    ///   <para>rdfs:seeAlso : LinguisticObject isWrittenBy Person
    /// Marginalia marginaliaAddedBy Scribe</para>
    ///   <para>rdfs:comment : A comment has been made by a modern-day scholar/editor.
    ///
    /// NB to represent marginalia physically written in the margins of the manuscript, use: Marginalia marginaliaAddedBy Scribe.</para>
    ///   <para>rdfs:label : comment made by</para>
    ///   <a href="http://purl.org/saws/ontology#commentMadeBy">saws:commentMadeBy</a>
    /// </summary>
    let commentMadeBy = _prefixId.prefix "commentMadeBy"
    let containsTextInLanguage = _prefixId.prefix "containsTextInLanguage"
    /// <summary>
    ///   <para>rdfs:seeAlso : Marginalia marginaliaAddedBy Scribe</para>
    ///   <para>rdfs:comment : A DecorativeItem has been physically added onto the manuscript by a Person
    ///
    /// NB to represent marginalia notes (text) physically written in the margins of the manuscript, use: Marginalia marginaliaAddedBy Scribe @en</para>
    ///   <para>rdfs:label : decoration added by</para>
    ///   <a href="http://purl.org/saws/ontology#decorationAddedBy">saws:decorationAddedBy</a>
    /// </summary>
    let decorationAddedBy = _prefixId.prefix "decorationAddedBy"
    /// <summary>
    ///   <para>rdfs:comment : A Section/ContentItem/CollectionInstance comes after another Section/ContentItem/CollectionInstance in the document</para>
    ///   <para>rdfs:label : follows</para>
    ///   <a href="http://purl.org/saws/ontology#follows">saws:follows</a>
    /// </summary>
    let follows = _prefixId.prefix "follows"
    /// <summary>
    ///   <para>rdfs:comment : Physical Manuscripts can be composed of many Manuscript Parts – this relationship would be stated once for each part. This relationship can be used both for existing Manuscript Parts or for Manuscript Parts which used to be parts of a manuscript</para>
    ///   <para>rdfs:label : forms part of</para>
    ///   <a href="http://purl.org/saws/ontology#formsPartOf">saws:formsPartOf</a>
    /// </summary>
    let formsPartOf = _prefixId.prefix "formsPartOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : Scribe hasAddedMarginalia Marginalia</para>
    ///   <para>rdfs:label : has added decoration</para>
    ///   <para>rdfs:comment : A Person has physically added a DecorativeItem onto the manuscript
    ///
    /// NB to represent where scribes have written marginalia notes (text) physically onto the manuscript, use: Scribe hasAddedMarginalia Marginalia</para>
    ///   <a href="http://purl.org/saws/ontology#hasAddedDecoration">saws:hasAddedDecoration</a>
    /// </summary>
    let hasAddedDecoration = _prefixId.prefix "hasAddedDecoration"
    /// <summary>
    ///   <para>rdfs:comment : A Scribe has physically added Marginalia onto a manuscript.
    ///
    /// NB to represent where a modern-day scholar/editor makes a comment, not written onto the manuscript, use: Editor hasMadeComment Comment </para>
    ///   <para>rdfs:label : has added marginalia</para>
    ///   <para>rdfs:seeAlso : Person hasWritten LinguisticObject
    /// Editor hasMadeComment Comment</para>
    ///   <a href="http://purl.org/saws/ontology#hasAddedMarginalia">saws:hasAddedMarginalia</a>
    /// </summary>
    let hasAddedMarginalia = _prefixId.prefix "hasAddedMarginalia"
    /// <summary>
    ///   <para>rdfs:comment : An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial</para>
    ///   <para>rdfs:label : has ancestor</para>
    ///   <a href="http://purl.org/saws/ontology#hasAncestor">saws:hasAncestor</a>
    /// </summary>
    let hasAncestor = _prefixId.prefix "hasAncestor"
    /// <summary>
    ///   <para>rdfs:comment : The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial</para>
    ///   <para>rdfs:label : hasChild</para>
    ///   <a href="http://purl.org/saws/ontology#hasChild">saws:hasChild</a>
    /// </summary>
    let hasChild = _prefixId.prefix "hasChild"
    /// <summary>
    ///   <para>rdfs:comment : To indicate that something has been commented about in an editorial Comment </para>
    ///   <para>rdfs:label : has comment</para>
    ///   <a href="http://purl.org/saws/ontology#hasComment">saws:hasComment</a>
    /// </summary>
    let hasComment = _prefixId.prefix "hasComment"
    let hasComponent = _prefixId.prefix "hasComponent"
    /// <summary>
    ///   <para>rdfs:comment : An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial</para>
    ///   <para>rdfs:label : has descendant</para>
    ///   <a href="http://purl.org/saws/ontology#hasDescendant">saws:hasDescendant</a>
    /// </summary>
    let hasDescendant = _prefixId.prefix "hasDescendant"
    /// <summary>
    ///   <para>rdfs:seeAlso : Person hasWritten LinguisticObject
    /// Scribe hasAddedMarginalia Marginalia </para>
    ///   <para>rdfs:comment : A modern-day scholar/editor has made a comment.
    ///
    /// NB to represent scribes physically writing marginalia on the manuscript, use: Scribe hasAddedMarginalia."@en</para>
    ///   <para>rdfs:label : has made comment</para>
    ///   <a href="http://purl.org/saws/ontology#hasMadeComment">saws:hasMadeComment</a>
    /// </summary>
    let hasMadeComment = _prefixId.prefix "hasMadeComment"
    /// <summary>
    ///   <para>rdfs:comment : To indicate that a manuscript has had Marginalia written on it, e.g. in the margins</para>
    ///   <para>rdfs:label : has marginalia</para>
    ///   <a href="http://purl.org/saws/ontology#hasMarginalia">saws:hasMarginalia</a>
    /// </summary>
    let hasMarginalia = _prefixId.prefix "hasMarginalia"
    /// <summary>
    ///   <para>rdfs:seeAlso : dct:hasPart
    /// efrbroo:R10_has_member
    /// ecrm:P107_has_current_or_former_member</para>
    ///   <para>rdfs:comment : We use hasMember to indicate:
    /// - A Family contains the specified original material (i.e. one
    /// produced by Scribe transcription rather than being edited in modern times)
    /// - An Institution has as a member this Person</para>
    ///   <para>rdfs:label : has member</para>
    ///   <a href="http://purl.org/saws/ontology#hasMember">saws:hasMember</a>
    /// </summary>
    let hasMember = _prefixId.prefix "hasMember"
    /// <summary>
    ///   <para>rdfs:comment : A Person has owned (either currently or in the past) the Material of Interest. This would normally be based on a specific statement/mark of ownership.
    ///
    /// [nb this will always need a date?]</para>
    ///   <para>rdfs:label : has owned</para>
    ///   <a href="http://purl.org/saws/ontology#hasOwned">saws:hasOwned</a>
    /// </summary>
    let hasOwned = _prefixId.prefix "hasOwned"
    /// <summary>
    ///   <para>rdfs:comment : The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial</para>
    ///   <para>rdfs:label : has parent</para>
    ///   <a href="http://purl.org/saws/ontology#hasParent">saws:hasParent</a>
    /// </summary>
    let hasParent = _prefixId.prefix "hasParent"
    /// <summary>
    ///   <para>rdfs:comment : Physical Manuscripts can be composed of many Manuscript Parts – this relationship would be stated once for each part. This relationship can be used both for existing Manuscript Parts or for Manuscript Parts which used to be parts of a manuscript</para>
    ///   <para>rdfs:label : has part</para>
    ///   <a href="http://purl.org/saws/ontology#hasPart">saws:hasPart</a>
    /// </summary>
    let hasPart = _prefixId.prefix "hasPart"
    /// <summary>
    ///   <para>rdfs:comment : A Person has used (either currently or in the past) the OriginalMaterial in their work.
    ///
    /// [nb this will always need a date?]</para>
    ///   <para>rdfs:label : has used</para>
    ///   <a href="http://purl.org/saws/ontology#hasUsed">saws:hasUsed</a>
    /// </summary>
    let hasUsed = _prefixId.prefix "hasUsed"
    /// <summary>
    ///   <para>rdfs:seeAlso : Editor hasMadeComment Comment
    /// Scribe hasAddedMarginalia Marginalia</para>
    ///   <para>rdfs:comment : A Person has written (or has transcribed) a LinguisticObject.
    /// NB This also includes:
    /// Editor hasWritten Comment
    /// Scribe hasWritten Marginalia</para>
    ///   <para>rdfs:label : has written</para>
    ///   <a href="http://purl.org/saws/ontology#hasWritten">saws:hasWritten</a>
    /// </summary>
    let hasWritten = _prefixId.prefix "hasWritten"
    /// <summary>
    ///   <para>rdfs:comment : An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial</para>
    ///   <para>rdfs:label : is ancestor of</para>
    ///   <a href="http://purl.org/saws/ontology#isAncestorOf">saws:isAncestorOf</a>
    /// </summary>
    let isAncestorOf = _prefixId.prefix "isAncestorOf"
    /// <summary>
    ///   <para>rdfs:comment : An author has been attributed as the author of this LinguisticObject (any Linguistic Object except Edition)</para>
    ///   <para>rdfs:label : is attributed author of</para>
    ///   <a href="http://purl.org/saws/ontology#isAttributedAuthorOf">saws:isAttributedAuthorOf</a>
    /// </summary>
    let isAttributedAuthorOf = _prefixId.prefix "isAttributedAuthorOf"
    /// <summary>
    ///   <para>rdfs:comment : A LinguisticObject (except Edition) is attributed to this AttributedAuthor</para>
    ///   <para>rdfs:label : is attributed to author</para>
    ///   <a href="http://purl.org/saws/ontology#isAttributedToAuthor">saws:isAttributedToAuthor</a>
    /// </summary>
    let isAttributedToAuthor = _prefixId.prefix "isAttributedToAuthor"
    /// <summary>
    ///   <para>rdfs:comment : An edition is based upon one or more textual materials (manuscripts, collections etc). One &lt;relation&gt; per each textual material)</para>
    ///   <para>rdfs:label : is based on</para>
    ///   <a href="http://purl.org/saws/ontology#isBasedOn">saws:isBasedOn</a>
    /// </summary>
    let isBasedOn = _prefixId.prefix "isBasedOn"
    /// <summary>
    ///   <para>rdfs:seeAlso : Person hasWritten LinguisticObject
    /// LinguisticObject isWrittenBy Person
    ///
    /// PhysicalManuscript/ReconstructedManuscript/ManuscriptPart isFromSamePlaceAs PhysicalManuscript/ReconstructedManuscript/ManuscriptPart</para>
    ///   <para>rdfs:comment : The two manuscripts (or parts of the manuscripts) have been copied/produced by the same Person</para>
    ///   <para>rdfs:label : is by same scribe as</para>
    ///   <a href="http://purl.org/saws/ontology#isBySameScribeAs">saws:isBySameScribeAs</a>
    /// </summary>
    let isBySameScribeAs = _prefixId.prefix "isBySameScribeAs"
    /// <summary>
    ///   <para>rdfs:comment : The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial</para>
    ///   <para>rdfs:label : is child of</para>
    ///   <a href="http://purl.org/saws/ontology#isChildOf">saws:isChildOf</a>
    /// </summary>
    let isChildOf = _prefixId.prefix "isChildOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isLooseRenderingOf</para>
    ///   <para>rdfs:comment : From one dialect or genre into another. This property specifies the source and target LinguisticObject involved (respectively) when rendering one LinguisticObject instance to express it in a related but different way (not necessarily in a different Language), resulting in a new LinguisticObject e.g. poetry into prose, or from one dialect to another, or a paraphrase being made.  This property indicates that the new LinguisticObject is a close rendering of the original LinguisticObject.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    ///   <para>rdfs:label : is close rendering of</para>
    ///   <a href="http://purl.org/saws/ontology#isCloseRenderingOf">saws:isCloseRenderingOf</a>
    /// </summary>
    let isCloseRenderingOf = _prefixId.prefix "isCloseRenderingOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isLooseTranslationOf
    /// isCloseRenderingOf</para>
    ///   <para>rdfs:comment : A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas, but is expressed in a different language (FRBRoo: an Expression of the same Work in a different Language). This property indicates that the translated text is a close interpretation of the original text
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    ///   <para>rdfs:label : is close translation of</para>
    ///   <a href="http://purl.org/saws/ontology#isCloseTranslationOf">saws:isCloseTranslationOf</a>
    /// </summary>
    let isCloseTranslationOf = _prefixId.prefix "isCloseTranslationOf"
    /// <summary>
    ///   <para>rdfs:comment : To indicate that an editorial Comment is being made about something</para>
    ///   <para>rdfs:label : is comment on</para>
    ///   <a href="http://purl.org/saws/ontology#isCommentOn">saws:isCommentOn</a>
    /// </summary>
    let isCommentOn = _prefixId.prefix "isCommentOn"
    let isComponentOf = _prefixId.prefix "isComponentOf"
    /// <summary>
    ///   <para>rdfs:comment : A LinguisticObject (except Edition) is copied by this Scribe</para>
    ///   <para>rdfs:label : is copied by</para>
    ///   <a href="http://purl.org/saws/ontology#isCopiedBy">saws:isCopiedBy</a>
    /// </summary>
    let isCopiedBy = _prefixId.prefix "isCopiedBy"
    /// <summary>
    ///   <para>rdfs:comment : A Scribe has written or copied this LinguisticObject (any Linguistic Object except Edition)</para>
    ///   <para>rdfs:label : is copier of</para>
    ///   <a href="http://purl.org/saws/ontology#isCopierOf">saws:isCopierOf</a>
    /// </summary>
    let isCopierOf = _prefixId.prefix "isCopierOf"
    /// <summary>
    ///   <para>rdfs:comment : An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial</para>
    ///   <para>rdfs:label : is descendant of</para>
    ///   <a href="http://purl.org/saws/ontology#isDescendantOf">saws:isDescendantOf</a>
    /// </summary>
    let isDescendantOf = _prefixId.prefix "isDescendantOf"
    /// <summary>
    ///   <para>rdfs:comment : To explicitly say that two things are different from each other</para>
    ///   <para>rdfs:label : is different to</para>
    ///   <a href="http://purl.org/saws/ontology#isDifferentTo">saws:isDifferentTo</a>
    /// </summary>
    let isDifferentTo = _prefixId.prefix "isDifferentTo"
    /// <summary>
    ///   <para>rdfs:seeAlso : isIndirectTranslationOf
    /// isTransliterationOf</para>
    ///   <para>rdfs:comment : To indicate that the translator worked directly from an MS or text which we have identified, to produce the target linguistic object. A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a different language (FRBRoo: a different and longer Expression).
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    ///   <para>rdfs:label : is direct translation of</para>
    ///   <a href="http://purl.org/saws/ontology#isDirectTranslationOf">saws:isDirectTranslationOf</a>
    /// </summary>
    let isDirectTranslationOf = _prefixId.prefix "isDirectTranslationOf"
    /// <summary>
    ///   <para>rdfs:comment : An Edition is edited by an Editor (someone from the SAWS team or another modern-day scholar)</para>
    ///   <para>rdfs:label : is edited by</para>
    ///   <a href="http://purl.org/saws/ontology#isEditedBy">saws:isEditedBy</a>
    /// </summary>
    let isEditedBy = _prefixId.prefix "isEditedBy"
    /// <summary>
    ///   <para>rdfs:comment : An Editor (a modern-day scholar, e.g. someone from the SAWS team) has edited an Edition</para>
    ///   <para>rdfs:label : is editor of</para>
    ///   <a href="http://purl.org/saws/ontology#isEditorOf">saws:isEditorOf</a>
    /// </summary>
    let isEditorOf = _prefixId.prefix "isEditorOf"
    /// <summary>
    ///   <para>rdfs:label : is from same place as</para>
    ///   <para>rdfs:comment : The two manuscripts (or parts of the manuscripts) have been copied/produced in the same Place/Institution</para>
    ///   <para>rdfs:seeAlso : (Place or Institution) isLocationForWritingOf Material
    /// Material isWrittenAt (Place or Institution)
    ///
    /// PhysicalManuscript/ReconstructedManuscript/ManuscriptPart isBySameScribeAs  PhysicalManuscript/ReconstructedManuscriptPart</para>
    ///   <a href="http://purl.org/saws/ontology#isFromSamePlaceAs">saws:isFromSamePlaceAs</a>
    /// </summary>
    let isFromSamePlaceAs = _prefixId.prefix "isFromSamePlaceAs"
    let isIdentifiedBy = _prefixId.prefix "isIdentifiedBy"
    /// <summary>
    ///   <para>rdfs:comment : A LinguisticObject is text in the specified Language</para>
    ///   <para>rdfs:label : is in language</para>
    ///   <a href="http://purl.org/saws/ontology#isInLanguage">saws:isInLanguage</a>
    /// </summary>
    let isInLanguage = _prefixId.prefix "isInLanguage"
    /// <summary>
    ///   <para>rdfs:label : is in same family as</para>
    ///   <para>rdfs:comment : Two OriginalMaterials are related by being part of the same Family of Original Materials</para>
    ///   <a href="http://purl.org/saws/ontology#isInSameFamilyAs">saws:isInSameFamilyAs</a>
    /// </summary>
    let isInSameFamilyAs = _prefixId.prefix "isInSameFamilyAs"
    /// <summary>
    ///   <para>rdfs:seeAlso : isDirectTranslationOf</para>
    ///   <para>rdfs:comment : To indicate where the Scribe worked from a lost translation/version or series of translations/versions to produce the target LinguisticObject. This relation should be used when we know that one LinguisticObject is a source of another (in a different language) and we want to assert that one text is not a direct translation from a previous document but where other unknown documents were involved in the process of going from one to another.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    ///   <para>rdfs:label : is indirect translation of</para>
    ///   <a href="http://purl.org/saws/ontology#isIndirectTranslationOf">saws:isIndirectTranslationOf</a>
    /// </summary>
    let isIndirectTranslationOf = _prefixId.prefix "isIndirectTranslationOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : physicallyLocatedAt</para>
    ///   <para>rdfs:comment : A physical thing is (or was) located at a particular location (Place or Locus)
    ///
    /// NB Use this relation if you are talking about a physically-existing object being located at a physical place. Use physicallyLocatedAt if you are talking about an abstract linguistic object being found at a particular locus.</para>
    ///   <para>rdfs:label : is located at</para>
    ///   <a href="http://purl.org/saws/ontology#isLocatedAt">saws:isLocatedAt</a>
    /// </summary>
    let isLocatedAt = _prefixId.prefix "isLocatedAt"
    /// <summary>
    ///   <para>rdfs:seeAlso : isLocationOf</para>
    ///   <para>rdfs:comment : A Place is the location witnessing the writing (or transcription) of a LinguisticObject</para>
    ///   <para>rdfs:label : is location for writing of</para>
    ///   <a href="http://purl.org/saws/ontology#isLocationForWritingOf">saws:isLocationForWritingOf</a>
    /// </summary>
    let isLocationForWritingOf = _prefixId.prefix "isLocationForWritingOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : physicalLocationOf</para>
    ///   <para>rdfs:label : is location of</para>
    ///   <para>rdfs:comment : A particular Place or Locus is (or was) the location of a physical thing.
    ///
    /// NB Use this relation if you are talking about the physical location of a physically-existing object. Use physicalLocationOf if you are talking about the physical location for an abstract linguistic object.</para>
    ///   <a href="http://purl.org/saws/ontology#isLocationOf">saws:isLocationOf</a>
    /// </summary>
    let isLocationOf = _prefixId.prefix "isLocationOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isLongerVersionOf</para>
    ///   <para>rdfs:comment : A LinguisticObject is an enhanced or expanded copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    ///   <para>rdfs:label : is longer translation of</para>
    ///   <a href="http://purl.org/saws/ontology#isLongerTranslationOf">saws:isLongerTranslationOf</a>
    /// </summary>
    let isLongerTranslationOf = _prefixId.prefix "isLongerTranslationOf"
    /// <summary>
    ///   <para>rdfs:comment : A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a longer version (FRBRoo: a different and longer Expression) which is an extension of the original text in some way.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    ///   <para>rdfs:label : is longer version of</para>
    ///   <a href="http://purl.org/saws/ontology#isLongerVersionOf">saws:isLongerVersionOf</a>
    /// </summary>
    let isLongerVersionOf = _prefixId.prefix "isLongerVersionOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isCloseRenderingOf</para>
    ///   <para>rdfs:comment : From one dialect or genre into another. This property specifies the source and target LinguisticObject involved (respectively) when rendering one LinguisticObject instance to express it in a related but different way (not necessarily in a different Language), resulting in a new LinguisticObject e.g. poetry into prose, or from one dialect to another, or a paraphrase being made. This property indicates that the new LinguisticObject is a loose rendering of the original LinguisticObject
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    ///   <para>rdfs:label : is loose rendering of</para>
    ///   <a href="http://purl.org/saws/ontology#isLooseRenderingOf">saws:isLooseRenderingOf</a>
    /// </summary>
    let isLooseRenderingOf = _prefixId.prefix "isLooseRenderingOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isCloseTranslationOf
    /// isLooseRenderingOf</para>
    ///   <para>rdfs:comment : A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a different language (FRBRoo: a different and longer Expression). This property indicates that the translated text is a loose interpretation of the original text
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    ///   <para>rdfs:label : is loose translation of</para>
    ///   <a href="http://purl.org/saws/ontology#isLooseTranslationOf">saws:isLooseTranslationOf</a>
    /// </summary>
    let isLooseTranslationOf = _prefixId.prefix "isLooseTranslationOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : dct:isPartOf
    /// efrbroo:R10i_is_member_of
    /// ecrm:P107i_is_current_or_former_member_of</para>
    ///   <para>rdfs:comment : We use isMemberOf to indicate:
    /// - An OriginalMaterial is member of a Family of related
    /// OriginalMaterials
    /// - A Person is member of an Institution</para>
    ///   <para>rdfs:label : is member of</para>
    ///   <a href="http://purl.org/saws/ontology#isMemberOf">saws:isMemberOf</a>
    /// </summary>
    let isMemberOf = _prefixId.prefix "isMemberOf"
    /// <summary>
    ///   <para>rdfs:comment : To specify that a piece of text is missing from a LinguisticObject, for example if this text appears in a corresponding part of a manuscript from the same Family</para>
    ///   <para>rdfs:label : is not present in</para>
    ///   <a href="http://purl.org/saws/ontology#isNotPresentIn">saws:isNotPresentIn</a>
    /// </summary>
    let isNotPresentIn = _prefixId.prefix "isNotPresentIn"
    /// <summary>
    ///   <para>rdfs:comment : A Physical man-made thing (physical manuscript) is older than (i.e. was produced earlier in time than) another specified Physical man-made thing</para>
    ///   <para>rdfs:label : is older than</para>
    ///   <a href="http://purl.org/saws/ontology#isOlderThan">saws:isOlderThan</a>
    /// </summary>
    let isOlderThan = _prefixId.prefix "isOlderThan"
    /// <summary>
    ///   <para>rdfs:comment : The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial</para>
    ///   <para>rdfs:label : is parent of</para>
    ///   <a href="http://purl.org/saws/ontology#isParentOf">saws:isParentOf</a>
    /// </summary>
    let isParentOf = _prefixId.prefix "isParentOf"
    /// <summary>
    ///   <para>rdfs:comment : This property allows you to say that an object or some text (internal to that document or from an external source) is referred to in the text of a LinguisticObject, e.g. by being described or being alluded to</para>
    ///   <para>rdfs:label : is referenced by</para>
    ///   <a href="http://purl.org/saws/ontology#isReferencedBy">saws:isReferencedBy</a>
    /// </summary>
    let isReferencedBy = _prefixId.prefix "isReferencedBy"
    /// <summary>
    ///   <para>rdfs:comment : Two things are related in some way. This relation may be used
    /// where the details of the link are to be refined at a later date, or where some relation is seen but the annotater cannot be more specific than to indicate that this relationship exists.</para>
    ///   <para>rdfs:label : is related to</para>
    ///   <a href="http://purl.org/saws/ontology#isRelatedTo">saws:isRelatedTo</a>
    /// </summary>
    let isRelatedTo = _prefixId.prefix "isRelatedTo"
    /// <summary>
    ///   <para>rdfs:comment : A CollectionInstance or Section has the same sequential structure as another CollectionInstance or Section. N.B. CollectionInstances contain sequences of ordered Sections. Sections contain sequences of ordered ContentItems</para>
    ///   <para>rdfs:seeAlso : isSequentiallySimilarTo
    /// isSubSequenceOf</para>
    ///   <para>rdfs:label : is sequentially same as</para>
    ///   <a href="http://purl.org/saws/ontology#isSequentiallySameAs">saws:isSequentiallySameAs</a>
    /// </summary>
    let isSequentiallySameAs = _prefixId.prefix "isSequentiallySameAs"
    /// <summary>
    ///   <para>rdfs:seeAlso : isSequentiallySameAs
    /// isSubSequenceOf</para>
    ///   <para>rdfs:comment : A CollectionInstance or Section has a slightly different but related sequential structure to another CollectionInstance or Section. N.B. CollectionInstances contain sequences of ordered Sections. Sections contain sequences of ordered ContentItems</para>
    ///   <para>rdfs:label : is sequentially similar to</para>
    ///   <a href="http://purl.org/saws/ontology#isSequentiallySimilarTo">saws:isSequentiallySimilarTo</a>
    /// </summary>
    let isSequentiallySimilarTo = _prefixId.prefix "isSequentiallySimilarTo"
    /// <summary>
    ///   <para>rdfs:label : is shorter translation of</para>
    ///   <para>rdfs:comment : A LinguisticObject is a condensed copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    ///   <para>rdfs:seeAlso : isShorterVersionOf</para>
    ///   <a href="http://purl.org/saws/ontology#isShorterTranslationOf">saws:isShorterTranslationOf</a>
    /// </summary>
    let isShorterTranslationOf = _prefixId.prefix "isShorterTranslationOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isShorterTranslationOf</para>
    ///   <para>rdfs:comment : A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a more concise version (FRBRoo: a different and shorter Expression)
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    ///   <para>rdfs:label : is shorter version of</para>
    ///   <a href="http://purl.org/saws/ontology#isShorterVersionOf">saws:isShorterVersionOf</a>
    /// </summary>
    let isShorterVersionOf = _prefixId.prefix "isShorterVersionOf"
    /// <summary>
    ///   <para>rdfs:comment : The two OriginalMaterials are produced using the same source(s) OriginalMaterial(s) (as indirect or direct source)</para>
    ///   <a href="http://purl.org/saws/ontology#isSiblingOf">saws:isSiblingOf</a>
    /// </summary>
    let isSiblingOf = _prefixId.prefix "isSiblingOf"
    /// <summary>
    ///   <para>rdfs:comment : A textual material (manuscripts, collections etc) is one of the source documents on which an edition is based. One &lt;relation&gt; per each textual material)</para>
    ///   <para>rdfs:label : is source for</para>
    ///   <a href="http://purl.org/saws/ontology#isSourceFor">saws:isSourceFor</a>
    /// </summary>
    let isSourceFor = _prefixId.prefix "isSourceFor"
    /// <summary>
    ///   <para>rdfs:seeAlso : isSequentiallySameAs
    /// isSequentiallySimilarTo</para>
    ///   <para>rdfs:comment : A Section is formed of a sequence of ContentItems that is a subsequence of the sequence of ContentItems in another Section</para>
    ///   <para>rdfs:label : is sub sequence of</para>
    ///   <a href="http://purl.org/saws/ontology#isSubSequenceOf">saws:isSubSequenceOf</a>
    /// </summary>
    let isSubSequenceOf = _prefixId.prefix "isSubSequenceOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isDirectTranslationOf</para>
    ///   <para>rdfs:comment : A LinguisticObject is a transliteration of another LinguisticObject, i.e. same words but using a different set of characters, e.g. kai isTransliterationOf και </para>
    ///   <para>rdfs:label : is transliteration of</para>
    ///   <a href="http://purl.org/saws/ontology#isTransliterationOf">saws:isTransliterationOf</a>
    /// </summary>
    let isTransliterationOf = _prefixId.prefix "isTransliterationOf"
    /// <summary>
    ///   <para>rdfs:comment : A LinguisticObject (except Edition) is transmitted by this Transmitter (Person)</para>
    ///   <para>rdfs:label : is transmitted by</para>
    ///   <a href="http://purl.org/saws/ontology#isTransmittedBy">saws:isTransmittedBy</a>
    /// </summary>
    let isTransmittedBy = _prefixId.prefix "isTransmittedBy"
    /// <summary>
    ///   <para>rdfs:comment : A Transmitter (Person) has transmitted this LinguisticObject (any Linguistic Object except Edition)</para>
    ///   <para>rdfs:label : is transmitter of</para>
    ///   <a href="http://purl.org/saws/ontology#isTransmitterOf">saws:isTransmitterOf</a>
    /// </summary>
    let isTransmitterOf = _prefixId.prefix "isTransmitterOf"
    /// <summary>
    ///   <para>rdfs:comment : The two OriginalMaterials are produced using the same direct source(s) OriginalMaterial</para>
    ///   <para>rdfs:label : is twin of</para>
    ///   <a href="http://purl.org/saws/ontology#isTwinOf">saws:isTwinOf</a>
    /// </summary>
    let isTwinOf = _prefixId.prefix "isTwinOf"
    /// <summary>
    ///   <para>rdfs:comment : To explicitly say two things are not at all related but are
    /// completely independent of each other</para>
    ///   <para>rdfs:label : is unrelated to</para>
    ///   <a href="http://purl.org/saws/ontology#isUnrelatedTo">saws:isUnrelatedTo</a>
    /// </summary>
    let isUnrelatedTo = _prefixId.prefix "isUnrelatedTo"
    /// <summary>
    ///   <para>rdfs:seeAlso : isVariantTranslationOf</para>
    ///   <para>rdfs:comment : A LinguisticObject is a variant of another LinguisticObject. NB This property is specialised by its subproperties - this is the default option, but more specialised properties should be used where possible. isVariantOf can be used as a placeholder or temporary annotation in a preliminary stage of annotation
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    ///   <para>rdfs:label : is variant of</para>
    ///   <a href="http://purl.org/saws/ontology#isVariantOf">saws:isVariantOf</a>
    /// </summary>
    let isVariantOf = _prefixId.prefix "isVariantOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isVariant</para>
    ///   <para>rdfs:comment : A LinguisticObject is a slightly modified copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    ///   <para>rdfs:label : is variant translation of</para>
    ///   <a href="http://purl.org/saws/ontology#isVariantTranslationOf">saws:isVariantTranslationOf</a>
    /// </summary>
    let isVariantTranslationOf = _prefixId.prefix "isVariantTranslationOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isVerbatimTranslationOf</para>
    ///   <para>rdfs:comment : A LinguisticObject is a verbatim, word-for-word copy of another LinguisticObject.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    ///   <para>rdfs:label : is verbatim of</para>
    ///   <a href="http://purl.org/saws/ontology#isVerbatimOf">saws:isVerbatimOf</a>
    /// </summary>
    let isVerbatimOf = _prefixId.prefix "isVerbatimOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isVerbatimOf</para>
    ///   <para>rdfs:comment : A LinguisticObject is a verbatim, word-for-word copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    ///   <para>rdfs:label : is verbatim translation of</para>
    ///   <a href="http://purl.org/saws/ontology#isVerbatimTranslationOf">saws:isVerbatimTranslationOf</a>
    /// </summary>
    let isVerbatimTranslationOf = _prefixId.prefix "isVerbatimTranslationOf"
    /// <summary>
    ///   <para>rdfs:seeAlso : isLocatedAt</para>
    ///   <para>rdfs:comment : A LinguisticObject is written (or transcribed) at a specified Place</para>
    ///   <para>rdfs:label : is written at</para>
    ///   <a href="http://purl.org/saws/ontology#isWrittenAt">saws:isWrittenAt</a>
    /// </summary>
    let isWrittenAt = _prefixId.prefix "isWrittenAt"
    /// <summary>
    ///   <para>rdfs:label : is written by</para>
    ///   <para>rdfs:seeAlso : Comment commentMadeBy Editor
    /// Marginalia marginaliaAddedBy Scribe</para>
    ///   <para>rdfs:comment : A LinguisticObject is written (or transcribed) by a specified Person</para>
    ///   <a href="http://purl.org/saws/ontology#isWrittenBy">saws:isWrittenBy</a>
    /// </summary>
    let isWrittenBy = _prefixId.prefix "isWrittenBy"
    /// <summary>
    ///   <para>rdfs:comment : A Physical man-made thing (physical manuscript) is younger than (i.e. was produced later in time than) another specified Physical man-made thing</para>
    ///   <para>rdfs:label : is younger than</para>
    ///   <a href="http://purl.org/saws/ontology#isYoungerThan">saws:isYoungerThan</a>
    /// </summary>
    let isYoungerThan = _prefixId.prefix "isYoungerThan"
    /// <summary>
    ///   <para>rdfs:comment : Marginalia have been physically added onto the manuscript by a Scribe
    ///
    /// NB to represent where a comment has been made by a modern-day scholar/editor, not written onto the manuscript, use: Comment commentMadeBy Editor</para>
    ///   <para>rdfs:seeAlso : LinguisticObject isWrittenBy Person
    /// Comment commentMadeBy Editor</para>
    ///   <para>rdfs:label : marginalia added by</para>
    ///   <a href="http://purl.org/saws/ontology#marginaliaAddedBy">saws:marginaliaAddedBy</a>
    /// </summary>
    let marginaliaAddedBy = _prefixId.prefix "marginaliaAddedBy"
    /// <summary>
    ///   <para>rdfs:comment : The Material of interest has been owned (in the past or currently) by this particular Person. This would normally be based on a specific statement/mark of ownership.
    ///
    /// [nb this will always need a date?]</para>
    ///   <para>rdfs:label : owned by</para>
    ///   <a href="http://purl.org/saws/ontology#ownedBy">saws:ownedBy</a>
    /// </summary>
    let ownedBy = _prefixId.prefix "ownedBy"
    /// <summary>
    ///   <para>rdfs:seeAlso : isLocationOf</para>
    ///   <para>rdfs:comment : This lets you describe the physical location of the LinguisticObject, e.g. a particular piece of text, or Marginalia, by recording the Locus that the notes are physically written on in a Material. You can describe the Locus (e.g. folio number, or position on the page) in free text, in as much detail as required, if there is no formal way to describe the location of the text/marginalia]
    ///
    /// NB Use this relation if you are talking about the physical location for an abstract linguistic object. Use isLocationOf if you are talking about the physical location of a physically-existing object.</para>
    ///   <para>rdfs:label : physical location of</para>
    ///   <a href="http://purl.org/saws/ontology#physicalLocationOf">saws:physicalLocationOf</a>
    /// </summary>
    let physicalLocationOf = _prefixId.prefix "physicalLocationOf"
    /// <summary>
    ///   <para>rdfs:comment : This lets you describe the physical location of the LinguisticObject, e.g. a particular piece of text, or Marginalia, by recording the Locus that the notes are physically written on in a Material. You can describe the Locus (e.g. folio number, or position on the page) in free text, in as much detail as required, if there is no formal way to describe the location of the text/marginalia
    ///
    /// NB Use this relation if you are talking about an abstract linguistic object which is to be found at a particular locus. Use isLocatedAt if you are talking about a physically-existing object being located at a physical place.rdfs:comment : physically located at</para>
    ///   <para>rdfs:seeAlso : isLocatedAt</para>
    ///   <a href="http://purl.org/saws/ontology#physicallyLocatedAt">saws:physicallyLocatedAt</a>
    /// </summary>
    let physicallyLocatedAt = _prefixId.prefix "physicallyLocatedAt"
    /// <summary>
    ///   <para>rdfs:comment : A Section/ContentItem/CollectionInstance comes before another Section/ContentItem/CollectionInstance in the document</para>
    ///   <para>rdfs:label : precedes</para>
    ///   <a href="http://purl.org/saws/ontology#precedes">saws:precedes</a>
    /// </summary>
    let precedes = _prefixId.prefix "precedes"
    /// <summary>
    ///   <para>rdfs:comment : This property allows you to say that the text of a LinguisticObject makes a reference to (or mentions) some other text or object, either within the text (e.g. as allusion) or external to the text (for external things, please give a URI for that object)</para>
    ///   <para>rdfs:label : refers to</para>
    ///   <a href="http://purl.org/saws/ontology#refersTo">saws:refersTo</a>
    /// </summary>
    let refersTo = _prefixId.prefix "refersTo"
    /// <summary>
    ///   <para>rdfs:comment : The Original Material of interest has been used by this particular Person in their work.
    ///
    /// [nb this will always need a date?]</para>
    ///   <para>rdfs:label : used by</para>
    ///   <a href="http://purl.org/saws/ontology#usedBy">saws:usedBy</a>
    /// </summary>
    let usedBy = _prefixId.prefix "usedBy"
