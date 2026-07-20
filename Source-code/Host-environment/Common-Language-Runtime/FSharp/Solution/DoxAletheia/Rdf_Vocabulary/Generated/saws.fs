namespace http.purl.org.saws.ontology.hash

open DoxAletheia

module saws =
    let _namespace_name = "http://purl.org/saws/ontology#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// A content item that is defining a concept or term used in the material
    /// <see href="http://purl.org/saws/ontology#Definition"></see></summary>
    let Definition = _prefix "Definition"
    /// <summary>
    /// Narrative text that is not a saying itself, that either stands alone or is the text surrounding or immediately preceding or following the Statement (saying), e.g. 'Aristotle says...', 'The frogs asked for a king.’, ‘Aristotle is a lover of knowledge’
    /// <see href="http://purl.org/saws/ontology#Narrative"></see></summary>
    let Narrative = _prefix "Narrative"
    /// <summary>
    /// A unit of the material within a content item, as identified by the modern editor, which isn’t a narrative, statement, or definition
    /// <see href="http://purl.org/saws/ontology#OtherContentItem"></see></summary>
    let OtherContentItem = _prefix "OtherContentItem"
    /// <summary>
    /// The actual saying, e.g. 'All men are mortal'
    /// <see href="http://purl.org/saws/ontology#Statement"></see></summary>
    let Statement = _prefix "Statement"
    /// <summary>
    /// A Person has physically added a DecorativeItem onto the manuscript
    ///
    /// NB to represent where scribes have written marginalia notes (text) physically onto the manuscript, use: Scribe hasAddedMarginalia Marginalia
    /// <see href="http://purl.org/saws/ontology#hasAddedDecoration"></see></summary>
    let hasAddedDecoration = _prefix "hasAddedDecoration"
    /// <summary>
    /// A Scribe has physically added Marginalia onto a manuscript.
    ///
    /// NB to represent where a modern-day scholar/editor makes a comment, not written onto the manuscript, use: Editor hasMadeComment Comment
    /// <see href="http://purl.org/saws/ontology#hasAddedMarginalia"></see></summary>
    let hasAddedMarginalia = _prefix "hasAddedMarginalia"
    /// <summary>
    /// A modern-day scholar/editor has made a comment.
    ///
    /// NB to represent scribes physically writing marginalia on the manuscript, use: Scribe hasAddedMarginalia."@en
    /// <see href="http://purl.org/saws/ontology#hasMadeComment"></see></summary>
    let hasMadeComment = _prefix "hasMadeComment"
    /// <summary>
    /// A comment has been made by a modern-day scholar/editor.
    ///
    /// NB to represent marginalia physically written in the margins of the manuscript, use: Marginalia marginaliaAddedBy Scribe.
    /// <see href="http://purl.org/saws/ontology#commentMadeBy"></see></summary>
    let commentMadeBy = _prefix "commentMadeBy"
    /// <summary>
    /// A DecorativeItem has been physically added onto the manuscript by a Person
    ///
    /// NB to represent marginalia notes (text) physically written in the margins of the manuscript, use: Marginalia marginaliaAddedBy Scribe @en
    /// <see href="http://purl.org/saws/ontology#decorationAddedBy"></see></summary>
    let decorationAddedBy = _prefix "decorationAddedBy"
    /// <summary>
    /// Marginalia have been physically added onto the manuscript by a Scribe
    ///
    /// NB to represent where a comment has been made by a modern-day scholar/editor, not written onto the manuscript, use: Comment commentMadeBy Editor
    /// <see href="http://purl.org/saws/ontology#marginaliaAddedBy"></see></summary>
    let marginaliaAddedBy = _prefix "marginaliaAddedBy"
    /// <summary>
    /// Two things are related in some way. This relation may be used
    /// where the details of the link are to be refined at a later date, or where some relation is seen but the annotater cannot be more specific than to indicate that this relationship exists.
    /// <see href="http://purl.org/saws/ontology#isRelatedTo"></see></summary>
    let isRelatedTo = _prefix "isRelatedTo"
    /// <summary>
    /// We use hasMember to indicate:
    /// - A Family contains the specified original material (i.e. one
    /// produced by Scribe transcription rather than being edited in modern times)
    /// - An Institution has as a member this Person
    /// <see href="http://purl.org/saws/ontology#hasMember"></see></summary>
    let hasMember = _prefix "hasMember"
    /// <summary>
    /// To specify that a piece of text is missing from a LinguisticObject, for example if this text appears in a corresponding part of a manuscript from the same Family
    /// <see href="http://purl.org/saws/ontology#isNotPresentIn"></see></summary>
    let isNotPresentIn = _prefix "isNotPresentIn"
    /// <summary>
    /// A LinguisticObject is text in the specified Language
    /// <see href="http://purl.org/saws/ontology#isInLanguage"></see></summary>
    let isInLanguage = _prefix "isInLanguage"
    /// <summary>
    /// The text that is written in an manuscript
    /// <see href="http://purl.org/saws/ontology#AbstractManuscriptText"></see></summary>
    let AbstractManuscriptText = _prefix "AbstractManuscriptText"
    /// <summary>
    /// A material produced by scribe transcription rather than being edited in modern times
    /// <see href="http://purl.org/saws/ontology#OriginalMaterial"></see></summary>
    let OriginalMaterial = _prefix "OriginalMaterial"
    /// <summary>
    /// Person to whom original authorship of a linguistic object is attributed, as the source of that linguistic object
    /// <see href="http://purl.org/saws/ontology#AttributedAuthor"></see></summary>
    let AttributedAuthor = _prefix "AttributedAuthor"
    /// <summary>
    /// A modern scholar editing material to produce an edition, in the age of printing and beyond
    /// <see href="http://purl.org/saws/ontology#Editor"></see></summary>
    let Editor = _prefix "Editor"
    /// <summary>
    /// The gnomologium or other compilation/collection on which we are working
    /// <see href="http://purl.org/saws/ontology#CollectionInstance"></see></summary>
    let CollectionInstance = _prefix "CollectionInstance"
    /// <summary>
    /// Comment on a part of the material, usually from the modern editor.
    ///
    /// N.B. The Comment class is for comments on a material that do not physically exist on that material. If a comment has been physically written on a material (usually in the margin), then this should be represented as an instance of Marginalia.
    /// <see href="http://purl.org/saws/ontology#Comment"></see></summary>
    let Comment = _prefix "Comment"
    /// <summary>
    /// Remark(s) physically written in the margin of the material by a scribe, not necessarily the original scribe.
    ///
    /// N.B. If a comment has been physically written on a material (usually in the margin), then this should be represented as an instance of Marginalia. The Comment class is for comments on a material that don’t physically exist on that material
    /// <see href="http://purl.org/saws/ontology#Marginalia"></see></summary>
    let Marginalia = _prefix "Marginalia"
    /// <summary>
    /// A basic unit of interest within the Material: a division of a collection instance/section, for more exact reference than when using a section – this identifies basic units of interest in the material for SAWS (marked in TEI as &lt;seg&gt;)
    /// <see href="http://purl.org/saws/ontology#ContentItem"></see></summary>
    let ContentItem = _prefix "ContentItem"
    /// <summary>
    /// Decorative element (picture, ornamentation, etc) within the material, either meaning-bearing or non meaning-bearing
    /// <see href="http://purl.org/saws/ontology#DecorativeItem"></see></summary>
    let DecorativeItem = _prefix "DecorativeItem"
    /// <summary>
    /// Any edited material, known or unknown, including texts such as the Bible and Kekaumenos
    /// <see href="http://purl.org/saws/ontology#Edition"></see></summary>
    let Edition = _prefix "Edition"
    /// <summary>
    /// Any of the texts we are working on in SAWS or that we are referring to
    /// <see href="http://purl.org/saws/ontology#Material"></see></summary>
    let Material = _prefix "Material"
    /// <summary>
    /// Person who is described in the text content as having transmitted a content item or other linguistic objects, for example ‘[Transmitter] said that [AttributedAuthor] said … (ContentItem)
    /// <see href="http://purl.org/saws/ontology#Transmitter"></see></summary>
    let Transmitter = _prefix "Transmitter"
    /// <summary>
    /// The producer / author / copier of a linguistic object (excluding editions), in the medieval age. The scribe can be named or unnamed
    /// <see href="http://purl.org/saws/ontology#Scribe"></see></summary>
    let Scribe = _prefix "Scribe"
    /// <summary>
    /// Any division within a linguistic object created by an editor, e.g. to make the navigation of the text clearer or to mark a region of interest
    /// <see href="http://purl.org/saws/ontology#EditorSection"></see></summary>
    let EditorSection = _prefix "EditorSection"
    /// <summary>
    /// A division of a linguistic object e.g. chapter, verse, for larger-scale reference than when using a content item. These can be nested/numbered
    /// <see href="http://purl.org/saws/ontology#Section"></see></summary>
    let Section = _prefix "Section"
    /// <summary>
    /// Any division within a linguistic object indicated by a scribe
    /// <see href="http://purl.org/saws/ontology#ScribeSection"></see></summary>
    let ScribeSection = _prefix "ScribeSection"
    /// <summary>
    /// Indicates a title that was assigned outside the manuscript by an editor
    /// <see href="http://purl.org/saws/ontology#EditorTitle"></see></summary>
    let EditorTitle = _prefix "EditorTitle"
    /// <summary>
    /// Indicates a title that was assigned within the manuscript by a scribe
    /// <see href="http://purl.org/saws/ontology#ScribeTitle"></see></summary>
    let ScribeTitle = _prefix "ScribeTitle"
    /// <summary>
    ///   <see href="http://purl.org/saws/ontology#Epilogue"></see>
    /// </summary>
    let Epilogue = _prefix "Epilogue"
    /// <summary>
    ///   <see href="http://purl.org/saws/ontology#Prologue"></see>
    /// </summary>
    let Prologue = _prefix "Prologue"
    /// <summary>
    /// A grouping of related Materials - this is a concept, an interpretation, rather than a physical thing
    /// <see href="http://purl.org/saws/ontology#Family"></see></summary>
    let Family = _prefix "Family"
    /// <summary>
    /// The physical instance of an abstract manuscript text or collection instance which we hypothesise may have existed, but which we do not have - it is presumed lost or destroyed
    /// <see href="http://purl.org/saws/ontology#HypothesisedInstance"></see></summary>
    let HypothesisedInstance = _prefix "HypothesisedInstance"
    /// <summary>
    /// An Institution can own materials, be located at places, and include persons as members
    /// <see href="http://purl.org/saws/ontology#Institution"></see></summary>
    let Institution = _prefix "Institution"
    /// <summary>
    /// A physical gap in the physical manuscript
    /// <see href="http://purl.org/saws/ontology#Lacuna"></see></summary>
    let Lacuna = _prefix "Lacuna"
    /// <summary>
    /// A physical location within a physical manuscript
    /// <see href="http://purl.org/saws/ontology#Locus"></see></summary>
    let Locus = _prefix "Locus"
    /// <summary>
    /// A physical section of a physical manuscript
    /// <see href="http://purl.org/saws/ontology#ManuscriptPart"></see></summary>
    let ManuscriptPart = _prefix "ManuscriptPart"
    /// <summary>
    /// The physical object on which the material we are working on exists
    /// <see href="http://purl.org/saws/ontology#PhysicalManuscript"></see></summary>
    let PhysicalManuscript = _prefix "PhysicalManuscript"
    /// <summary>
    /// Manuscript whose parts are now distributed as separate manuscript parts, so no longer exists as a whole, but can still be identified
    /// <see href="http://purl.org/saws/ontology#ReconstructedManuscript"></see></summary>
    let ReconstructedManuscript = _prefix "ReconstructedManuscript"
    /// <summary>
    /// To indicate that Marginalia have been written on the manuscript,e .g. in the margins
    /// <see href="http://purl.org/saws/ontology#areMarginaliaOn"></see></summary>
    let areMarginaliaOn = _prefix "areMarginaliaOn"
    /// <summary>
    /// This property allows you to say that the text of a LinguisticObject makes a reference to (or mentions) some other text or object, either within the text (e.g. as allusion) or external to the text (for external things, please give a URI for that object)
    /// <see href="http://purl.org/saws/ontology#refersTo"></see></summary>
    let refersTo = _prefix "refersTo"
    /// <summary>
    ///   <see href="http://purl.org/saws/ontology#containsTextInLanguage"></see>
    /// </summary>
    let containsTextInLanguage = _prefix "containsTextInLanguage"
    /// <summary>
    /// A Section/ContentItem/CollectionInstance comes after another Section/ContentItem/CollectionInstance in the document
    /// <see href="http://purl.org/saws/ontology#follows"></see></summary>
    let follows = _prefix "follows"
    /// <summary>
    /// Physical Manuscripts can be composed of many Manuscript Parts – this relationship would be stated once for each part. This relationship can be used both for existing Manuscript Parts or for Manuscript Parts which used to be parts of a manuscript
    /// <see href="http://purl.org/saws/ontology#formsPartOf"></see></summary>
    let formsPartOf = _prefix "formsPartOf"
    /// <summary>
    /// Physical Manuscripts can be composed of many Manuscript Parts – this relationship would be stated once for each part. This relationship can be used both for existing Manuscript Parts or for Manuscript Parts which used to be parts of a manuscript
    /// <see href="http://purl.org/saws/ontology#hasPart"></see></summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial
    /// <see href="http://purl.org/saws/ontology#hasAncestor"></see></summary>
    let hasAncestor = _prefix "hasAncestor"
    /// <summary>
    /// Two OriginalMaterials are related by being part of the same Family of Original Materials
    /// <see href="http://purl.org/saws/ontology#isInSameFamilyAs"></see></summary>
    let isInSameFamilyAs = _prefix "isInSameFamilyAs"
    /// <summary>
    /// The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial
    /// <see href="http://purl.org/saws/ontology#hasParent"></see></summary>
    let hasParent = _prefix "hasParent"
    /// <summary>
    /// An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial
    /// <see href="http://purl.org/saws/ontology#hasDescendant"></see></summary>
    let hasDescendant = _prefix "hasDescendant"
    /// <summary>
    /// The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial
    /// <see href="http://purl.org/saws/ontology#hasChild"></see></summary>
    let hasChild = _prefix "hasChild"
    /// <summary>
    /// The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial
    /// <see href="http://purl.org/saws/ontology#isChildOf"></see></summary>
    let isChildOf = _prefix "isChildOf"
    /// <summary>
    /// To indicate that something has been commented about in an editorial Comment
    /// <see href="http://purl.org/saws/ontology#hasComment"></see></summary>
    let hasComment = _prefix "hasComment"
    /// <summary>
    /// This property allows you to say that an object or some text (internal to that document or from an external source) is referred to in the text of a LinguisticObject, e.g. by being described or being alluded to
    /// <see href="http://purl.org/saws/ontology#isReferencedBy"></see></summary>
    let isReferencedBy = _prefix "isReferencedBy"
    /// <summary>
    ///   <see href="http://purl.org/saws/ontology#hasComponent"></see>
    /// </summary>
    let hasComponent = _prefix "hasComponent"
    /// <summary>
    /// An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial
    /// <see href="http://purl.org/saws/ontology#isDescendantOf"></see></summary>
    let isDescendantOf = _prefix "isDescendantOf"
    /// <summary>
    /// To indicate that a manuscript has had Marginalia written on it, e.g. in the margins
    /// <see href="http://purl.org/saws/ontology#hasMarginalia"></see></summary>
    let hasMarginalia = _prefix "hasMarginalia"
    /// <summary>
    /// We use isMemberOf to indicate:
    /// - An OriginalMaterial is member of a Family of related
    /// OriginalMaterials
    /// - A Person is member of an Institution
    /// <see href="http://purl.org/saws/ontology#isMemberOf"></see></summary>
    let isMemberOf = _prefix "isMemberOf"
    /// <summary>
    /// A Person has owned (either currently or in the past) the Material of Interest. This would normally be based on a specific statement/mark of ownership.
    ///
    /// [nb this will always need a date?]
    /// <see href="http://purl.org/saws/ontology#hasOwned"></see></summary>
    let hasOwned = _prefix "hasOwned"
    /// <summary>
    /// The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial
    /// <see href="http://purl.org/saws/ontology#isParentOf"></see></summary>
    let isParentOf = _prefix "isParentOf"
    /// <summary>
    /// A Person has used (either currently or in the past) the OriginalMaterial in their work.
    ///
    /// [nb this will always need a date?]
    /// <see href="http://purl.org/saws/ontology#hasUsed"></see></summary>
    let hasUsed = _prefix "hasUsed"
    /// <summary>
    /// The Original Material of interest has been used by this particular Person in their work.
    ///
    /// [nb this will always need a date?]
    /// <see href="http://purl.org/saws/ontology#usedBy"></see></summary>
    let usedBy = _prefix "usedBy"
    /// <summary>
    /// A Person has written (or has transcribed) a LinguisticObject.
    /// NB This also includes:
    /// Editor hasWritten Comment
    /// Scribe hasWritten Marginalia
    /// <see href="http://purl.org/saws/ontology#hasWritten"></see></summary>
    let hasWritten = _prefix "hasWritten"
    /// <summary>
    /// An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial
    /// <see href="http://purl.org/saws/ontology#isAncestorOf"></see></summary>
    let isAncestorOf = _prefix "isAncestorOf"
    /// <summary>
    /// An author has been attributed as the author of this LinguisticObject (any Linguistic Object except Edition)
    /// <see href="http://purl.org/saws/ontology#isAttributedAuthorOf"></see></summary>
    let isAttributedAuthorOf = _prefix "isAttributedAuthorOf"
    /// <summary>
    /// A LinguisticObject (except Edition) is attributed to this AttributedAuthor
    /// <see href="http://purl.org/saws/ontology#isAttributedToAuthor"></see></summary>
    let isAttributedToAuthor = _prefix "isAttributedToAuthor"
    /// <summary>
    /// A LinguisticObject is written (or transcribed) by a specified Person
    /// <see href="http://purl.org/saws/ontology#isWrittenBy"></see></summary>
    let isWrittenBy = _prefix "isWrittenBy"
    /// <summary>
    /// An edition is based upon one or more textual materials (manuscripts, collections etc). One &lt;relation&gt; per each textual material)
    /// <see href="http://purl.org/saws/ontology#isBasedOn"></see></summary>
    let isBasedOn = _prefix "isBasedOn"
    /// <summary>
    /// A textual material (manuscripts, collections etc) is one of the source documents on which an edition is based. One &lt;relation&gt; per each textual material)
    /// <see href="http://purl.org/saws/ontology#isSourceFor"></see></summary>
    let isSourceFor = _prefix "isSourceFor"
    /// <summary>
    /// The two manuscripts (or parts of the manuscripts) have been copied/produced by the same Person
    /// <see href="http://purl.org/saws/ontology#isBySameScribeAs"></see></summary>
    let isBySameScribeAs = _prefix "isBySameScribeAs"
    /// <summary>
    /// From one dialect or genre into another. This property specifies the source and target LinguisticObject involved (respectively) when rendering one LinguisticObject instance to express it in a related but different way (not necessarily in a different Language), resulting in a new LinguisticObject e.g. poetry into prose, or from one dialect to another, or a paraphrase being made.  This property indicates that the new LinguisticObject is a close rendering of the original LinguisticObject.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect
    /// <see href="http://purl.org/saws/ontology#isCloseRenderingOf"></see></summary>
    let isCloseRenderingOf = _prefix "isCloseRenderingOf"
    /// <summary>
    /// A LinguisticObject is a variant of another LinguisticObject. NB This property is specialised by its subproperties - this is the default option, but more specialised properties should be used where possible. isVariantOf can be used as a placeholder or temporary annotation in a preliminary stage of annotation
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect
    /// <see href="http://purl.org/saws/ontology#isVariantOf"></see></summary>
    let isVariantOf = _prefix "isVariantOf"
    /// <summary>
    /// A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas, but is expressed in a different language (FRBRoo: an Expression of the same Work in a different Language). This property indicates that the translated text is a close interpretation of the original text
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)
    /// <see href="http://purl.org/saws/ontology#isCloseTranslationOf"></see></summary>
    let isCloseTranslationOf = _prefix "isCloseTranslationOf"
    /// <summary>
    /// To indicate that the translator worked directly from an MS or text which we have identified, to produce the target linguistic object. A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a different language (FRBRoo: a different and longer Expression).
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)
    /// <see href="http://purl.org/saws/ontology#isDirectTranslationOf"></see></summary>
    let isDirectTranslationOf = _prefix "isDirectTranslationOf"
    /// <summary>
    /// To indicate that an editorial Comment is being made about something
    /// <see href="http://purl.org/saws/ontology#isCommentOn"></see></summary>
    let isCommentOn = _prefix "isCommentOn"
    /// <summary>
    ///   <see href="http://purl.org/saws/ontology#isComponentOf"></see>
    /// </summary>
    let isComponentOf = _prefix "isComponentOf"
    /// <summary>
    /// A LinguisticObject (except Edition) is copied by this Scribe
    /// <see href="http://purl.org/saws/ontology#isCopiedBy"></see></summary>
    let isCopiedBy = _prefix "isCopiedBy"
    /// <summary>
    /// A Scribe has written or copied this LinguisticObject (any Linguistic Object except Edition)
    /// <see href="http://purl.org/saws/ontology#isCopierOf"></see></summary>
    let isCopierOf = _prefix "isCopierOf"
    /// <summary>
    /// To explicitly say that two things are different from each other
    /// <see href="http://purl.org/saws/ontology#isDifferentTo"></see></summary>
    let isDifferentTo = _prefix "isDifferentTo"
    /// <summary>
    /// To indicate where the Scribe worked from a lost translation/version or series of translations/versions to produce the target LinguisticObject. This relation should be used when we know that one LinguisticObject is a source of another (in a different language) and we want to assert that one text is not a direct translation from a previous document but where other unknown documents were involved in the process of going from one to another.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect
    /// <see href="http://purl.org/saws/ontology#isIndirectTranslationOf"></see></summary>
    let isIndirectTranslationOf = _prefix "isIndirectTranslationOf"
    /// <summary>
    /// An Edition is edited by an Editor (someone from the SAWS team or another modern-day scholar)
    /// <see href="http://purl.org/saws/ontology#isEditedBy"></see></summary>
    let isEditedBy = _prefix "isEditedBy"
    /// <summary>
    /// An Editor (a modern-day scholar, e.g. someone from the SAWS team) has edited an Edition
    /// <see href="http://purl.org/saws/ontology#isEditorOf"></see></summary>
    let isEditorOf = _prefix "isEditorOf"
    /// <summary>
    /// The two manuscripts (or parts of the manuscripts) have been copied/produced in the same Place/Institution
    /// <see href="http://purl.org/saws/ontology#isFromSamePlaceAs"></see></summary>
    let isFromSamePlaceAs = _prefix "isFromSamePlaceAs"
    /// <summary>
    /// A LinguisticObject is written (or transcribed) at a specified Place
    /// <see href="http://purl.org/saws/ontology#isWrittenAt"></see></summary>
    let isWrittenAt = _prefix "isWrittenAt"
    /// <summary>
    /// A Place is the location witnessing the writing (or transcription) of a LinguisticObject
    /// <see href="http://purl.org/saws/ontology#isLocationForWritingOf"></see></summary>
    let isLocationForWritingOf = _prefix "isLocationForWritingOf"
    /// <summary>
    ///   <see href="http://purl.org/saws/ontology#isIdentifiedBy"></see>
    /// </summary>
    let isIdentifiedBy = _prefix "isIdentifiedBy"
    /// <summary>
    /// A physical thing is (or was) located at a particular location (Place or Locus)
    ///
    /// NB Use this relation if you are talking about a physically-existing object being located at a physical place. Use physicallyLocatedAt if you are talking about an abstract linguistic object being found at a particular locus.
    /// <see href="http://purl.org/saws/ontology#isLocatedAt"></see></summary>
    let isLocatedAt = _prefix "isLocatedAt"
    /// <summary>
    /// A particular Place or Locus is (or was) the location of a physical thing.
    ///
    /// NB Use this relation if you are talking about the physical location of a physically-existing object. Use physicalLocationOf if you are talking about the physical location for an abstract linguistic object.
    /// <see href="http://purl.org/saws/ontology#isLocationOf"></see></summary>
    let isLocationOf = _prefix "isLocationOf"
    /// <summary>
    /// A LinguisticObject is an enhanced or expanded copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)
    /// <see href="http://purl.org/saws/ontology#isLongerTranslationOf"></see></summary>
    let isLongerTranslationOf = _prefix "isLongerTranslationOf"
    /// <summary>
    /// A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a longer version (FRBRoo: a different and longer Expression) which is an extension of the original text in some way.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect
    /// <see href="http://purl.org/saws/ontology#isLongerVersionOf"></see></summary>
    let isLongerVersionOf = _prefix "isLongerVersionOf"
    /// <summary>
    /// A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a more concise version (FRBRoo: a different and shorter Expression)
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect
    /// <see href="http://purl.org/saws/ontology#isShorterVersionOf"></see></summary>
    let isShorterVersionOf = _prefix "isShorterVersionOf"
    /// <summary>
    /// From one dialect or genre into another. This property specifies the source and target LinguisticObject involved (respectively) when rendering one LinguisticObject instance to express it in a related but different way (not necessarily in a different Language), resulting in a new LinguisticObject e.g. poetry into prose, or from one dialect to another, or a paraphrase being made. This property indicates that the new LinguisticObject is a loose rendering of the original LinguisticObject
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect
    /// <see href="http://purl.org/saws/ontology#isLooseRenderingOf"></see></summary>
    let isLooseRenderingOf = _prefix "isLooseRenderingOf"
    /// <summary>
    /// A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a different language (FRBRoo: a different and longer Expression). This property indicates that the translated text is a loose interpretation of the original text
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)
    /// <see href="http://purl.org/saws/ontology#isLooseTranslationOf"></see></summary>
    let isLooseTranslationOf = _prefix "isLooseTranslationOf"
    /// <summary>
    /// A Physical man-made thing (physical manuscript) is older than (i.e. was produced earlier in time than) another specified Physical man-made thing
    /// <see href="http://purl.org/saws/ontology#isOlderThan"></see></summary>
    let isOlderThan = _prefix "isOlderThan"
    /// <summary>
    /// A Physical man-made thing (physical manuscript) is younger than (i.e. was produced later in time than) another specified Physical man-made thing
    /// <see href="http://purl.org/saws/ontology#isYoungerThan"></see></summary>
    let isYoungerThan = _prefix "isYoungerThan"
    /// <summary>
    /// A CollectionInstance or Section has the same sequential structure as another CollectionInstance or Section. N.B. CollectionInstances contain sequences of ordered Sections. Sections contain sequences of ordered ContentItems
    /// <see href="http://purl.org/saws/ontology#isSequentiallySameAs"></see></summary>
    let isSequentiallySameAs = _prefix "isSequentiallySameAs"
    /// <summary>
    /// A CollectionInstance or Section has a slightly different but related sequential structure to another CollectionInstance or Section. N.B. CollectionInstances contain sequences of ordered Sections. Sections contain sequences of ordered ContentItems
    /// <see href="http://purl.org/saws/ontology#isSequentiallySimilarTo"></see></summary>
    let isSequentiallySimilarTo = _prefix "isSequentiallySimilarTo"
    /// <summary>
    /// A LinguisticObject is a condensed copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)
    /// <see href="http://purl.org/saws/ontology#isShorterTranslationOf"></see></summary>
    let isShorterTranslationOf = _prefix "isShorterTranslationOf"
    /// <summary>
    /// The two OriginalMaterials are produced using the same source(s) OriginalMaterial(s) (as indirect or direct source)
    /// <see href="http://purl.org/saws/ontology#isSiblingOf"></see></summary>
    let isSiblingOf = _prefix "isSiblingOf"
    /// <summary>
    /// A Section is formed of a sequence of ContentItems that is a subsequence of the sequence of ContentItems in another Section
    /// <see href="http://purl.org/saws/ontology#isSubSequenceOf"></see></summary>
    let isSubSequenceOf = _prefix "isSubSequenceOf"
    /// <summary>
    /// A LinguisticObject is a transliteration of another LinguisticObject, i.e. same words but using a different set of characters, e.g. kai isTransliterationOf και
    /// <see href="http://purl.org/saws/ontology#isTransliterationOf"></see></summary>
    let isTransliterationOf = _prefix "isTransliterationOf"
    /// <summary>
    /// A LinguisticObject (except Edition) is transmitted by this Transmitter (Person)
    /// <see href="http://purl.org/saws/ontology#isTransmittedBy"></see></summary>
    let isTransmittedBy = _prefix "isTransmittedBy"
    /// <summary>
    /// A Transmitter (Person) has transmitted this LinguisticObject (any Linguistic Object except Edition)
    /// <see href="http://purl.org/saws/ontology#isTransmitterOf"></see></summary>
    let isTransmitterOf = _prefix "isTransmitterOf"
    /// <summary>
    /// The two OriginalMaterials are produced using the same direct source(s) OriginalMaterial
    /// <see href="http://purl.org/saws/ontology#isTwinOf"></see></summary>
    let isTwinOf = _prefix "isTwinOf"
    /// <summary>
    /// To explicitly say two things are not at all related but are
    /// completely independent of each other
    /// <see href="http://purl.org/saws/ontology#isUnrelatedTo"></see></summary>
    let isUnrelatedTo = _prefix "isUnrelatedTo"
    /// <summary>
    /// A LinguisticObject is a slightly modified copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)
    /// <see href="http://purl.org/saws/ontology#isVariantTranslationOf"></see></summary>
    let isVariantTranslationOf = _prefix "isVariantTranslationOf"
    /// <summary>
    /// A LinguisticObject is a verbatim, word-for-word copy of another LinguisticObject.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect
    /// <see href="http://purl.org/saws/ontology#isVerbatimOf"></see></summary>
    let isVerbatimOf = _prefix "isVerbatimOf"
    /// <summary>
    /// A LinguisticObject is a verbatim, word-for-word copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)
    /// <see href="http://purl.org/saws/ontology#isVerbatimTranslationOf"></see></summary>
    let isVerbatimTranslationOf = _prefix "isVerbatimTranslationOf"
    /// <summary>
    /// The Material of interest has been owned (in the past or currently) by this particular Person. This would normally be based on a specific statement/mark of ownership.
    ///
    /// [nb this will always need a date?]
    /// <see href="http://purl.org/saws/ontology#ownedBy"></see></summary>
    let ownedBy = _prefix "ownedBy"
    /// <summary>
    /// This lets you describe the physical location of the LinguisticObject, e.g. a particular piece of text, or Marginalia, by recording the Locus that the notes are physically written on in a Material. You can describe the Locus (e.g. folio number, or position on the page) in free text, in as much detail as required, if there is no formal way to describe the location of the text/marginalia]
    ///
    /// NB Use this relation if you are talking about the physical location for an abstract linguistic object. Use isLocationOf if you are talking about the physical location of a physically-existing object.
    /// <see href="http://purl.org/saws/ontology#physicalLocationOf"></see></summary>
    let physicalLocationOf = _prefix "physicalLocationOf"
    /// <summary>
    /// This lets you describe the physical location of the LinguisticObject, e.g. a particular piece of text, or Marginalia, by recording the Locus that the notes are physically written on in a Material. You can describe the Locus (e.g. folio number, or position on the page) in free text, in as much detail as required, if there is no formal way to describe the location of the text/marginalia
    ///
    /// NB Use this relation if you are talking about an abstract linguistic object which is to be found at a particular locus. Use isLocatedAt if you are talking about a physically-existing object being located at a physical place.
    /// physically located at
    /// <see href="http://purl.org/saws/ontology#physicallyLocatedAt"></see></summary>
    let physicallyLocatedAt = _prefix "physicallyLocatedAt"
    /// <summary>
    /// A Section/ContentItem/CollectionInstance comes before another Section/ContentItem/CollectionInstance in the document
    /// <see href="http://purl.org/saws/ontology#precedes"></see></summary>
    let precedes = _prefix "precedes"
