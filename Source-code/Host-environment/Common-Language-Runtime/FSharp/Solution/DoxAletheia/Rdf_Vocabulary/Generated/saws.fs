namespace http.purl.org.saws.ontology.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module saws =
    let _namespace_iri = Namespace_Iri saws |> NamespaceIRI
    /// <summary>
    ///   <para>saws:Narrative</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Narrative text that is not a saying itself, that either stands alone or is the text surrounding or immediately preceding or following the Statement (saying), e.g. 'Aristotle says...', 'The frogs asked for a king.’, ‘Aristotle is a lover of knowledge’</para>
    /// labels<para>narrative</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Narrative">http://purl.org/saws/ontology#Narrative</seealso>
    let Narrative = Prefixed_Name(saws, "Narrative") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasAddedDecoration</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Person has physically added a DecorativeItem onto the manuscript
    ///
    /// NB to represent where scribes have written marginalia notes (text) physically onto the manuscript, use: Scribe hasAddedMarginalia Marginalia</para>
    /// labels<para>has added decoration</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasAddedDecoration">http://purl.org/saws/ontology#hasAddedDecoration</seealso>
    let hasAddedDecoration = Prefixed_Name(saws, "hasAddedDecoration") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasMadeComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A modern-day scholar/editor has made a comment.
    ///
    /// NB to represent scribes physically writing marginalia on the manuscript, use: Scribe hasAddedMarginalia."@en</para>
    /// labels<para>has made comment</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasMadeComment">http://purl.org/saws/ontology#hasMadeComment</seealso>
    let hasMadeComment = Prefixed_Name(saws, "hasMadeComment") |> PrefixedName
    /// <summary>
    ///   <para>saws:commentMadeBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A comment has been made by a modern-day scholar/editor.
    ///
    /// NB to represent marginalia physically written in the margins of the manuscript, use: Marginalia marginaliaAddedBy Scribe.</para>
    /// labels<para>comment made by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#commentMadeBy">http://purl.org/saws/ontology#commentMadeBy</seealso>
    let commentMadeBy = Prefixed_Name(saws, "commentMadeBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:OtherContentItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A unit of the material within a content item, as identified by the modern editor, which isn’t a narrative, statement, or definition</para>
    /// labels<para>other content item</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#OtherContentItem">http://purl.org/saws/ontology#OtherContentItem</seealso>
    let OtherContentItem = Prefixed_Name(saws, "OtherContentItem") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasAddedMarginalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Scribe has physically added Marginalia onto a manuscript.
    ///
    /// NB to represent where a modern-day scholar/editor makes a comment, not written onto the manuscript, use: Editor hasMadeComment Comment </para>
    /// labels<para>has added marginalia</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasAddedMarginalia">http://purl.org/saws/ontology#hasAddedMarginalia</seealso>
    let hasAddedMarginalia = Prefixed_Name(saws, "hasAddedMarginalia") |> PrefixedName
    /// <summary>
    ///   <para>saws:marginaliaAddedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Marginalia have been physically added onto the manuscript by a Scribe
    ///
    /// NB to represent where a comment has been made by a modern-day scholar/editor, not written onto the manuscript, use: Comment commentMadeBy Editor</para>
    /// labels<para>marginalia added by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#marginaliaAddedBy">http://purl.org/saws/ontology#marginaliaAddedBy</seealso>
    let marginaliaAddedBy = Prefixed_Name(saws, "marginaliaAddedBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasMember</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>We use hasMember to indicate:
    /// - A Family contains the specified original material (i.e. one
    /// produced by Scribe transcription rather than being edited in modern times)
    /// - An Institution has as a member this Person</para>
    /// labels<para>has member</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasMember">http://purl.org/saws/ontology#hasMember</seealso>
    let hasMember = Prefixed_Name(saws, "hasMember") |> PrefixedName
    /// <summary>
    ///   <para>saws:isInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is text in the specified Language</para>
    /// labels<para>is in language</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isInLanguage">http://purl.org/saws/ontology#isInLanguage</seealso>
    let isInLanguage = Prefixed_Name(saws, "isInLanguage") |> PrefixedName
    /// <summary>
    ///   <para>saws:AttributedAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Person to whom original authorship of a linguistic object is attributed, as the source of that linguistic object</para>
    /// labels<para>attributed author</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#AttributedAuthor">http://purl.org/saws/ontology#AttributedAuthor</seealso>
    let AttributedAuthor = Prefixed_Name(saws, "AttributedAuthor") |> PrefixedName
    /// <summary>
    ///   <para>saws:Comment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Comment on a part of the material, usually from the modern editor.
    ///
    /// N.B. The Comment class is for comments on a material that do not physically exist on that material. If a comment has been physically written on a material (usually in the margin), then this should be represented as an instance of Marginalia. </para>
    /// labels<para>comment</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Comment">http://purl.org/saws/ontology#Comment</seealso>
    let Comment = Prefixed_Name(saws, "Comment") |> PrefixedName
    /// <summary>
    ///   <para>saws:Marginalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Remark(s) physically written in the margin of the material by a scribe, not necessarily the original scribe.
    ///
    /// N.B. If a comment has been physically written on a material (usually in the margin), then this should be represented as an instance of Marginalia. The Comment class is for comments on a material that don’t physically exist on that material</para>
    /// labels<para>marginalia</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Marginalia">http://purl.org/saws/ontology#Marginalia</seealso>
    let Marginalia = Prefixed_Name(saws, "Marginalia") |> PrefixedName
    /// <summary>
    ///   <para>saws:DecorativeItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Decorative element (picture, ornamentation, etc) within the material, either meaning-bearing or non meaning-bearing</para>
    /// labels<para>decorative item</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#DecorativeItem">http://purl.org/saws/ontology#DecorativeItem</seealso>
    let DecorativeItem = Prefixed_Name(saws, "DecorativeItem") |> PrefixedName
    /// <summary>
    ///   <para>saws:Edition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any edited material, known or unknown, including texts such as the Bible and Kekaumenos</para>
    /// labels<para>edition</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Edition">http://purl.org/saws/ontology#Edition</seealso>
    let Edition = Prefixed_Name(saws, "Edition") |> PrefixedName

    /// <summary>
    ///   <para>saws:AbstractManuscriptText</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The text that is written in an manuscript</para>
    /// labels<para>abstract manuscript text</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#AbstractManuscriptText">http://purl.org/saws/ontology#AbstractManuscriptText</seealso>
    let AbstractManuscriptText =
        Prefixed_Name(saws, "AbstractManuscriptText") |> PrefixedName

    /// <summary>
    ///   <para>saws:isCopierOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Scribe has written or copied this LinguisticObject (any Linguistic Object except Edition)</para>
    /// labels<para>is copier of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isCopierOf">http://purl.org/saws/ontology#isCopierOf</seealso>
    let isCopierOf = Prefixed_Name(saws, "isCopierOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Physical Manuscripts can be composed of many Manuscript Parts – this relationship would be stated once for each part. This relationship can be used both for existing Manuscript Parts or for Manuscript Parts which used to be parts of a manuscript</para>
    /// labels<para>has part</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasPart">http://purl.org/saws/ontology#hasPart</seealso>
    let hasPart = Prefixed_Name(saws, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasAncestor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial</para>
    /// labels<para>has ancestor</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasAncestor">http://purl.org/saws/ontology#hasAncestor</seealso>
    let hasAncestor = Prefixed_Name(saws, "hasAncestor") |> PrefixedName
    /// <summary>
    ///   <para>saws:isInSameFamilyAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>Two OriginalMaterials are related by being part of the same Family of Original Materials</para>
    /// labels<para>is in same family as</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isInSameFamilyAs">http://purl.org/saws/ontology#isInSameFamilyAs</seealso>
    let isInSameFamilyAs = Prefixed_Name(saws, "isInSameFamilyAs") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasDescendant</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial</para>
    /// labels<para>has descendant</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasDescendant">http://purl.org/saws/ontology#hasDescendant</seealso>
    let hasDescendant = Prefixed_Name(saws, "hasDescendant") |> PrefixedName
    /// <summary>
    ///   <para>saws:isChildOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial</para>
    /// labels<para>is child of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isChildOf">http://purl.org/saws/ontology#isChildOf</seealso>
    let isChildOf = Prefixed_Name(saws, "isChildOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasComment</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>To indicate that something has been commented about in an editorial Comment </para>
    /// labels<para>has comment</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasComment">http://purl.org/saws/ontology#hasComment</seealso>
    let hasComment = Prefixed_Name(saws, "hasComment") |> PrefixedName
    /// <summary>
    ///   <para>saws:isReferencedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property allows you to say that an object or some text (internal to that document or from an external source) is referred to in the text of a LinguisticObject, e.g. by being described or being alluded to</para>
    /// labels<para>is referenced by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isReferencedBy">http://purl.org/saws/ontology#isReferencedBy</seealso>
    let isReferencedBy = Prefixed_Name(saws, "isReferencedBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasComponent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasComponent">http://purl.org/saws/ontology#hasComponent</seealso>
    let hasComponent = Prefixed_Name(saws, "hasComponent") |> PrefixedName
    /// <summary>
    ///   <para>saws:isDescendantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial</para>
    /// labels<para>is descendant of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isDescendantOf">http://purl.org/saws/ontology#isDescendantOf</seealso>
    let isDescendantOf = Prefixed_Name(saws, "isDescendantOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasMarginalia</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>To indicate that a manuscript has had Marginalia written on it, e.g. in the margins</para>
    /// labels<para>has marginalia</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasMarginalia">http://purl.org/saws/ontology#hasMarginalia</seealso>
    let hasMarginalia = Prefixed_Name(saws, "hasMarginalia") |> PrefixedName
    /// <summary>
    ///   <para>saws:isMemberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:ReflexiveProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>We use isMemberOf to indicate:
    /// - An OriginalMaterial is member of a Family of related
    /// OriginalMaterials
    /// - A Person is member of an Institution</para>
    /// labels<para>is member of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isMemberOf">http://purl.org/saws/ontology#isMemberOf</seealso>
    let isMemberOf = Prefixed_Name(saws, "isMemberOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasOwned</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Person has owned (either currently or in the past) the Material of Interest. This would normally be based on a specific statement/mark of ownership.
    ///
    /// [nb this will always need a date?]</para>
    /// labels<para>has owned</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasOwned">http://purl.org/saws/ontology#hasOwned</seealso>
    let hasOwned = Prefixed_Name(saws, "hasOwned") |> PrefixedName
    /// <summary>
    ///   <para>saws:isParentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial</para>
    /// labels<para>is parent of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isParentOf">http://purl.org/saws/ontology#isParentOf</seealso>
    let isParentOf = Prefixed_Name(saws, "isParentOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasUsed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Person has used (either currently or in the past) the OriginalMaterial in their work.
    ///
    /// [nb this will always need a date?]</para>
    /// labels<para>has used</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasUsed">http://purl.org/saws/ontology#hasUsed</seealso>
    let hasUsed = Prefixed_Name(saws, "hasUsed") |> PrefixedName
    /// <summary>
    ///   <para>saws:usedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Original Material of interest has been used by this particular Person in their work.
    ///
    /// [nb this will always need a date?]</para>
    /// labels<para>used by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#usedBy">http://purl.org/saws/ontology#usedBy</seealso>
    let usedBy = Prefixed_Name(saws, "usedBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasWritten</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Person has written (or has transcribed) a LinguisticObject.
    /// NB This also includes:
    /// Editor hasWritten Comment
    /// Scribe hasWritten Marginalia</para>
    /// labels<para>has written</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasWritten">http://purl.org/saws/ontology#hasWritten</seealso>
    let hasWritten = Prefixed_Name(saws, "hasWritten") |> PrefixedName

    /// <summary>
    ///   <para>saws:isAttributedAuthorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An author has been attributed as the author of this LinguisticObject (any Linguistic Object except Edition)</para>
    /// labels<para>is attributed author of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isAttributedAuthorOf">http://purl.org/saws/ontology#isAttributedAuthorOf</seealso>
    let isAttributedAuthorOf =
        Prefixed_Name(saws, "isAttributedAuthorOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isWrittenBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is written (or transcribed) by a specified Person</para>
    /// labels<para>is written by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isWrittenBy">http://purl.org/saws/ontology#isWrittenBy</seealso>
    let isWrittenBy = Prefixed_Name(saws, "isWrittenBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:isBasedOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An edition is based upon one or more textual materials (manuscripts, collections etc). One &lt;relation&gt; per each textual material)</para>
    /// labels<para>is based on</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isBasedOn">http://purl.org/saws/ontology#isBasedOn</seealso>
    let isBasedOn = Prefixed_Name(saws, "isBasedOn") |> PrefixedName
    /// <summary>
    ///   <para>saws:isSourceFor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A textual material (manuscripts, collections etc) is one of the source documents on which an edition is based. One &lt;relation&gt; per each textual material)</para>
    /// labels<para>is source for</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isSourceFor">http://purl.org/saws/ontology#isSourceFor</seealso>
    let isSourceFor = Prefixed_Name(saws, "isSourceFor") |> PrefixedName
    /// <summary>
    ///   <para>saws:isBySameScribeAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The two manuscripts (or parts of the manuscripts) have been copied/produced by the same Person</para>
    /// labels<para>is by same scribe as</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isBySameScribeAs">http://purl.org/saws/ontology#isBySameScribeAs</seealso>
    let isBySameScribeAs = Prefixed_Name(saws, "isBySameScribeAs") |> PrefixedName
    /// <summary>
    ///   <para>saws:isCloseRenderingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>From one dialect or genre into another. This property specifies the source and target LinguisticObject involved (respectively) when rendering one LinguisticObject instance to express it in a related but different way (not necessarily in a different Language), resulting in a new LinguisticObject e.g. poetry into prose, or from one dialect to another, or a paraphrase being made.  This property indicates that the new LinguisticObject is a close rendering of the original LinguisticObject.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    /// labels<para>is close rendering of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isCloseRenderingOf">http://purl.org/saws/ontology#isCloseRenderingOf</seealso>
    let isCloseRenderingOf = Prefixed_Name(saws, "isCloseRenderingOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:isVariantOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is a variant of another LinguisticObject. NB This property is specialised by its subproperties - this is the default option, but more specialised properties should be used where possible. isVariantOf can be used as a placeholder or temporary annotation in a preliminary stage of annotation
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    /// labels<para>is variant of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isVariantOf">http://purl.org/saws/ontology#isVariantOf</seealso>
    let isVariantOf = Prefixed_Name(saws, "isVariantOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isCloseTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas, but is expressed in a different language (FRBRoo: an Expression of the same Work in a different Language). This property indicates that the translated text is a close interpretation of the original text
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    /// labels<para>is close translation of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isCloseTranslationOf">http://purl.org/saws/ontology#isCloseTranslationOf</seealso>
    let isCloseTranslationOf =
        Prefixed_Name(saws, "isCloseTranslationOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isCommentOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>To indicate that an editorial Comment is being made about something</para>
    /// labels<para>is comment on</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isCommentOn">http://purl.org/saws/ontology#isCommentOn</seealso>
    let isCommentOn = Prefixed_Name(saws, "isCommentOn") |> PrefixedName
    /// <summary>
    ///   <para>saws:isComponentOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/saws/ontology#isComponentOf">http://purl.org/saws/ontology#isComponentOf</seealso>
    let isComponentOf = Prefixed_Name(saws, "isComponentOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:isCopiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject (except Edition) is copied by this Scribe</para>
    /// labels<para>is copied by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isCopiedBy">http://purl.org/saws/ontology#isCopiedBy</seealso>
    let isCopiedBy = Prefixed_Name(saws, "isCopiedBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:isDifferentTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>To explicitly say that two things are different from each other</para>
    /// labels<para>is different to</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isDifferentTo">http://purl.org/saws/ontology#isDifferentTo</seealso>
    let isDifferentTo = Prefixed_Name(saws, "isDifferentTo") |> PrefixedName

    /// <summary>
    ///   <para>saws:isIndirectTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>To indicate where the Scribe worked from a lost translation/version or series of translations/versions to produce the target LinguisticObject. This relation should be used when we know that one LinguisticObject is a source of another (in a different language) and we want to assert that one text is not a direct translation from a previous document but where other unknown documents were involved in the process of going from one to another.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    /// labels<para>is indirect translation of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isIndirectTranslationOf">http://purl.org/saws/ontology#isIndirectTranslationOf</seealso>
    let isIndirectTranslationOf =
        Prefixed_Name(saws, "isIndirectTranslationOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isEditedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An Edition is edited by an Editor (someone from the SAWS team or another modern-day scholar)</para>
    /// labels<para>is edited by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isEditedBy">http://purl.org/saws/ontology#isEditedBy</seealso>
    let isEditedBy = Prefixed_Name(saws, "isEditedBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:isEditorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>An Editor (a modern-day scholar, e.g. someone from the SAWS team) has edited an Edition</para>
    /// labels<para>is editor of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isEditorOf">http://purl.org/saws/ontology#isEditorOf</seealso>
    let isEditorOf = Prefixed_Name(saws, "isEditorOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:isFromSamePlaceAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>The two manuscripts (or parts of the manuscripts) have been copied/produced in the same Place/Institution</para>
    /// labels<para>is from same place as</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isFromSamePlaceAs">http://purl.org/saws/ontology#isFromSamePlaceAs</seealso>
    let isFromSamePlaceAs = Prefixed_Name(saws, "isFromSamePlaceAs") |> PrefixedName
    /// <summary>
    ///   <para>saws:isWrittenAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is written (or transcribed) at a specified Place</para>
    /// labels<para>is written at</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isWrittenAt">http://purl.org/saws/ontology#isWrittenAt</seealso>
    let isWrittenAt = Prefixed_Name(saws, "isWrittenAt") |> PrefixedName

    /// <summary>
    ///   <para>saws:isLocationForWritingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Place is the location witnessing the writing (or transcription) of a LinguisticObject</para>
    /// labels<para>is location for writing of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isLocationForWritingOf">http://purl.org/saws/ontology#isLocationForWritingOf</seealso>
    let isLocationForWritingOf =
        Prefixed_Name(saws, "isLocationForWritingOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isIdentifiedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/saws/ontology#isIdentifiedBy">http://purl.org/saws/ontology#isIdentifiedBy</seealso>
    let isIdentifiedBy = Prefixed_Name(saws, "isIdentifiedBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasParent</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial</para>
    /// labels<para>has parent</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasParent">http://purl.org/saws/ontology#hasParent</seealso>
    let hasParent = Prefixed_Name(saws, "hasParent") |> PrefixedName
    /// <summary>
    ///   <para>saws:isNotPresentIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>To specify that a piece of text is missing from a LinguisticObject, for example if this text appears in a corresponding part of a manuscript from the same Family</para>
    /// labels<para>is not present in</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isNotPresentIn">http://purl.org/saws/ontology#isNotPresentIn</seealso>
    let isNotPresentIn = Prefixed_Name(saws, "isNotPresentIn") |> PrefixedName
    /// <summary>
    ///   <para>saws:isRelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>Two things are related in some way. This relation may be used
    /// where the details of the link are to be refined at a later date, or where some relation is seen but the annotater cannot be more specific than to indicate that this relationship exists.</para>
    /// labels<para>is related to</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isRelatedTo">http://purl.org/saws/ontology#isRelatedTo</seealso>
    let isRelatedTo = Prefixed_Name(saws, "isRelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>saws:hasChild</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The parent OriginalMaterial is a direct source for the production of part or all of the child OriginalMaterial</para>
    /// labels<para>hasChild</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#hasChild">http://purl.org/saws/ontology#hasChild</seealso>
    let hasChild = Prefixed_Name(saws, "hasChild") |> PrefixedName
    /// <summary>
    ///   <para>saws:OriginalMaterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A material produced by scribe transcription rather than being edited in modern times</para>
    /// labels<para>original material</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#OriginalMaterial">http://purl.org/saws/ontology#OriginalMaterial</seealso>
    let OriginalMaterial = Prefixed_Name(saws, "OriginalMaterial") |> PrefixedName
    /// <summary>
    ///   <para>saws:CollectionInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The gnomologium or other compilation/collection on which we are working</para>
    /// labels<para>collection instance</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#CollectionInstance">http://purl.org/saws/ontology#CollectionInstance</seealso>
    let CollectionInstance = Prefixed_Name(saws, "CollectionInstance") |> PrefixedName
    /// <summary>
    ///   <para>saws:isAncestorOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>An ancestor OriginalMaterial is a source material (direct or indirect) for the production of part or all of the descendant OriginalMaterial</para>
    /// labels<para>is ancestor of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isAncestorOf">http://purl.org/saws/ontology#isAncestorOf</seealso>
    let isAncestorOf = Prefixed_Name(saws, "isAncestorOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isAttributedToAuthor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject (except Edition) is attributed to this AttributedAuthor</para>
    /// labels<para>is attributed to author</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isAttributedToAuthor">http://purl.org/saws/ontology#isAttributedToAuthor</seealso>
    let isAttributedToAuthor =
        Prefixed_Name(saws, "isAttributedToAuthor") |> PrefixedName

    /// <summary>
    ///   <para>saws:Editor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A modern scholar editing material to produce an edition, in the age of printing and beyond</para>
    /// labels<para>editor</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Editor">http://purl.org/saws/ontology#Editor</seealso>
    let Editor = Prefixed_Name(saws, "Editor") |> PrefixedName
    /// <summary>
    ///   <para>saws:ContentItem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A basic unit of interest within the Material: a division of a collection instance/section, for more exact reference than when using a section – this identifies basic units of interest in the material for SAWS (marked in TEI as &lt;seg&gt;)</para>
    /// labels<para>content item</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#ContentItem">http://purl.org/saws/ontology#ContentItem</seealso>
    let ContentItem = Prefixed_Name(saws, "ContentItem") |> PrefixedName
    /// <summary>
    ///   <para>saws:Material</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any of the texts we are working on in SAWS or that we are referring to</para>
    /// labels<para>material</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Material">http://purl.org/saws/ontology#Material</seealso>
    let Material = Prefixed_Name(saws, "Material") |> PrefixedName
    /// <summary>
    ///   <para>saws:Scribe</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The producer / author / copier of a linguistic object (excluding editions), in the medieval age. The scribe can be named or unnamed</para>
    /// labels<para>scribe</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Scribe">http://purl.org/saws/ontology#Scribe</seealso>
    let Scribe = Prefixed_Name(saws, "Scribe") |> PrefixedName
    /// <summary>
    ///   <para>saws:Section</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A division of a linguistic object e.g. chapter, verse, for larger-scale reference than when using a content item. These can be nested/numbered</para>
    /// labels<para>section</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Section">http://purl.org/saws/ontology#Section</seealso>
    let Section = Prefixed_Name(saws, "Section") |> PrefixedName
    /// <summary>
    ///   <para>saws:EditorTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates a title that was assigned outside the manuscript by an editor</para>
    /// labels<para>editor title</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#EditorTitle">http://purl.org/saws/ontology#EditorTitle</seealso>
    let EditorTitle = Prefixed_Name(saws, "EditorTitle") |> PrefixedName
    /// <summary>
    ///   <para>saws:Prologue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>prologue</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Prologue">http://purl.org/saws/ontology#Prologue</seealso>
    let Prologue = Prefixed_Name(saws, "Prologue") |> PrefixedName

    /// <summary>
    ///   <para>saws:isDirectTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>To indicate that the translator worked directly from an MS or text which we have identified, to produce the target linguistic object. A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a different language (FRBRoo: a different and longer Expression).
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    /// labels<para>is direct translation of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isDirectTranslationOf">http://purl.org/saws/ontology#isDirectTranslationOf</seealso>
    let isDirectTranslationOf =
        Prefixed_Name(saws, "isDirectTranslationOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:EditorSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any division within a linguistic object created by an editor, e.g. to make the navigation of the text clearer or to mark a region of interest</para>
    /// labels<para>editor section</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#EditorSection">http://purl.org/saws/ontology#EditorSection</seealso>
    let EditorSection = Prefixed_Name(saws, "EditorSection") |> PrefixedName
    /// <summary>
    ///   <para>saws:Epilogue</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>epilogue</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Epilogue">http://purl.org/saws/ontology#Epilogue</seealso>
    let Epilogue = Prefixed_Name(saws, "Epilogue") |> PrefixedName
    /// <summary>
    ///   <para>saws:Transmitter</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Person who is described in the text content as having transmitted a content item or other linguistic objects, for example ‘[Transmitter] said that [AttributedAuthor] said … (ContentItem)</para>
    /// labels<para>transmitter</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Transmitter">http://purl.org/saws/ontology#Transmitter</seealso>
    let Transmitter = Prefixed_Name(saws, "Transmitter") |> PrefixedName
    /// <summary>
    ///   <para>saws:ScribeTitle</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Indicates a title that was assigned within the manuscript by a scribe</para>
    /// labels<para>scribe title</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#ScribeTitle">http://purl.org/saws/ontology#ScribeTitle</seealso>
    let ScribeTitle = Prefixed_Name(saws, "ScribeTitle") |> PrefixedName
    /// <summary>
    ///   <para>saws:Family</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A grouping of related Materials - this is a concept, an interpretation, rather than a physical thing</para>
    /// labels<para>family</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Family">http://purl.org/saws/ontology#Family</seealso>
    let Family = Prefixed_Name(saws, "Family") |> PrefixedName
    /// <summary>
    ///   <para>saws:isLocatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A physical thing is (or was) located at a particular location (Place or Locus)
    ///
    /// NB Use this relation if you are talking about a physically-existing object being located at a physical place. Use physicallyLocatedAt if you are talking about an abstract linguistic object being found at a particular locus.</para>
    /// labels<para>is located at</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isLocatedAt">http://purl.org/saws/ontology#isLocatedAt</seealso>
    let isLocatedAt = Prefixed_Name(saws, "isLocatedAt") |> PrefixedName
    /// <summary>
    ///   <para>saws:isLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>A particular Place or Locus is (or was) the location of a physical thing.
    ///
    /// NB Use this relation if you are talking about the physical location of a physically-existing object. Use physicalLocationOf if you are talking about the physical location for an abstract linguistic object.</para>
    /// labels<para>is location of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isLocationOf">http://purl.org/saws/ontology#isLocationOf</seealso>
    let isLocationOf = Prefixed_Name(saws, "isLocationOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isLongerTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>A LinguisticObject is an enhanced or expanded copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    /// labels<para>is longer translation of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isLongerTranslationOf">http://purl.org/saws/ontology#isLongerTranslationOf</seealso>
    let isLongerTranslationOf =
        Prefixed_Name(saws, "isLongerTranslationOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isLongerVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a longer version (FRBRoo: a different and longer Expression) which is an extension of the original text in some way.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    /// labels<para>is longer version of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isLongerVersionOf">http://purl.org/saws/ontology#isLongerVersionOf</seealso>
    let isLongerVersionOf = Prefixed_Name(saws, "isLongerVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:isShorterVersionOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a more concise version (FRBRoo: a different and shorter Expression)
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    /// labels<para>is shorter version of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isShorterVersionOf">http://purl.org/saws/ontology#isShorterVersionOf</seealso>
    let isShorterVersionOf = Prefixed_Name(saws, "isShorterVersionOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:ScribeSection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Any division within a linguistic object indicated by a scribe</para>
    /// labels<para>scribe section</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#ScribeSection">http://purl.org/saws/ontology#ScribeSection</seealso>
    let ScribeSection = Prefixed_Name(saws, "ScribeSection") |> PrefixedName
    /// <summary>
    ///   <para>saws:isLooseRenderingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>From one dialect or genre into another. This property specifies the source and target LinguisticObject involved (respectively) when rendering one LinguisticObject instance to express it in a related but different way (not necessarily in a different Language), resulting in a new LinguisticObject e.g. poetry into prose, or from one dialect to another, or a paraphrase being made. This property indicates that the new LinguisticObject is a loose rendering of the original LinguisticObject
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    /// labels<para>is loose rendering of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isLooseRenderingOf">http://purl.org/saws/ontology#isLooseRenderingOf</seealso>
    let isLooseRenderingOf = Prefixed_Name(saws, "isLooseRenderingOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isLooseTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is related to another LinguisticObject in that it conveys the same ideas (FRBRoo: Work), but is expressed in a different language (FRBRoo: a different and longer Expression). This property indicates that the translated text is a loose interpretation of the original text
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    /// labels<para>is loose translation of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isLooseTranslationOf">http://purl.org/saws/ontology#isLooseTranslationOf</seealso>
    let isLooseTranslationOf =
        Prefixed_Name(saws, "isLooseTranslationOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:Lacuna</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical gap in the physical manuscript</para>
    /// labels<para>lacuna</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Lacuna">http://purl.org/saws/ontology#Lacuna</seealso>
    let Lacuna = Prefixed_Name(saws, "Lacuna") |> PrefixedName
    /// <summary>
    ///   <para>saws:ManuscriptPart</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical section of a physical manuscript</para>
    /// labels<para>manuscript part</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#ManuscriptPart">http://purl.org/saws/ontology#ManuscriptPart</seealso>
    let ManuscriptPart = Prefixed_Name(saws, "ManuscriptPart") |> PrefixedName
    /// <summary>
    ///   <para>saws:PhysicalManuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The physical object on which the material we are working on exists</para>
    /// labels<para>physical manuscript</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#PhysicalManuscript">http://purl.org/saws/ontology#PhysicalManuscript</seealso>
    let PhysicalManuscript = Prefixed_Name(saws, "PhysicalManuscript") |> PrefixedName

    /// <summary>
    ///   <para>saws:isVariantTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>A LinguisticObject is a slightly modified copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    /// labels<para>is variant translation of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isVariantTranslationOf">http://purl.org/saws/ontology#isVariantTranslationOf</seealso>
    let isVariantTranslationOf =
        Prefixed_Name(saws, "isVariantTranslationOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isVerbatimTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is a verbatim, word-for-word copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    /// labels<para>is verbatim translation of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isVerbatimTranslationOf">http://purl.org/saws/ontology#isVerbatimTranslationOf</seealso>
    let isVerbatimTranslationOf =
        Prefixed_Name(saws, "isVerbatimTranslationOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:areMarginaliaOn</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>To indicate that Marginalia have been written on the manuscript,e .g. in the margins</para>
    /// labels<para>are marginalia on</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#areMarginaliaOn">http://purl.org/saws/ontology#areMarginaliaOn</seealso>
    let areMarginaliaOn = Prefixed_Name(saws, "areMarginaliaOn") |> PrefixedName
    /// <summary>
    ///   <para>saws:refersTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This property allows you to say that the text of a LinguisticObject makes a reference to (or mentions) some other text or object, either within the text (e.g. as allusion) or external to the text (for external things, please give a URI for that object)</para>
    /// labels<para>refers to</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#refersTo">http://purl.org/saws/ontology#refersTo</seealso>
    let refersTo = Prefixed_Name(saws, "refersTo") |> PrefixedName

    /// <summary>
    ///   <para>saws:containsTextInLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    /// </remarks>
    /// <seealso href="http://purl.org/saws/ontology#containsTextInLanguage">http://purl.org/saws/ontology#containsTextInLanguage</seealso>
    let containsTextInLanguage =
        Prefixed_Name(saws, "containsTextInLanguage") |> PrefixedName

    /// <summary>
    ///   <para>saws:Locus</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A physical location within a physical manuscript</para>
    /// labels<para>locus</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Locus">http://purl.org/saws/ontology#Locus</seealso>
    let Locus = Prefixed_Name(saws, "Locus") |> PrefixedName
    /// <summary>
    ///   <para>saws:isTransmittedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject (except Edition) is transmitted by this Transmitter (Person)</para>
    /// labels<para>is transmitted by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isTransmittedBy">http://purl.org/saws/ontology#isTransmittedBy</seealso>
    let isTransmittedBy = Prefixed_Name(saws, "isTransmittedBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:isTransmitterOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Transmitter (Person) has transmitted this LinguisticObject (any Linguistic Object except Edition)</para>
    /// labels<para>is transmitter of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isTransmitterOf">http://purl.org/saws/ontology#isTransmitterOf</seealso>
    let isTransmitterOf = Prefixed_Name(saws, "isTransmitterOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:isTwinOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The two OriginalMaterials are produced using the same direct source(s) OriginalMaterial</para>
    /// labels<para>is twin of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isTwinOf">http://purl.org/saws/ontology#isTwinOf</seealso>
    let isTwinOf = Prefixed_Name(saws, "isTwinOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:isUnrelatedTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>To explicitly say two things are not at all related but are
    /// completely independent of each other</para>
    /// labels<para>is unrelated to</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isUnrelatedTo">http://purl.org/saws/ontology#isUnrelatedTo</seealso>
    let isUnrelatedTo = Prefixed_Name(saws, "isUnrelatedTo") |> PrefixedName
    /// <summary>
    ///   <para>saws:isVerbatimOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is a verbatim, word-for-word copy of another LinguisticObject.
    ///
    /// For comparing between text of the same language, or comparing between different languages where the direction of translation is unknown or indirect</para>
    /// labels<para>is verbatim of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isVerbatimOf">http://purl.org/saws/ontology#isVerbatimOf</seealso>
    let isVerbatimOf = Prefixed_Name(saws, "isVerbatimOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:ReconstructedManuscript</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>Manuscript whose parts are now distributed as separate manuscript parts, so no longer exists as a whole, but can still be identified</para>
    /// labels<para>reconstructed manuscript</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#ReconstructedManuscript">http://purl.org/saws/ontology#ReconstructedManuscript</seealso>
    let ReconstructedManuscript =
        Prefixed_Name(saws, "ReconstructedManuscript") |> PrefixedName

    /// <summary>
    ///   <para>saws:physicalLocationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>This lets you describe the physical location of the LinguisticObject, e.g. a particular piece of text, or Marginalia, by recording the Locus that the notes are physically written on in a Material. You can describe the Locus (e.g. folio number, or position on the page) in free text, in as much detail as required, if there is no formal way to describe the location of the text/marginalia]
    ///
    /// NB Use this relation if you are talking about the physical location for an abstract linguistic object. Use isLocationOf if you are talking about the physical location of a physically-existing object.</para>
    /// labels<para>physical location of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#physicalLocationOf">http://purl.org/saws/ontology#physicalLocationOf</seealso>
    let physicalLocationOf = Prefixed_Name(saws, "physicalLocationOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:physicallyLocatedAt</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>physically located at</para>
    ///   <para>This lets you describe the physical location of the LinguisticObject, e.g. a particular piece of text, or Marginalia, by recording the Locus that the notes are physically written on in a Material. You can describe the Locus (e.g. folio number, or position on the page) in free text, in as much detail as required, if there is no formal way to describe the location of the text/marginalia
    ///
    /// NB Use this relation if you are talking about an abstract linguistic object which is to be found at a particular locus. Use isLocatedAt if you are talking about a physically-existing object being located at a physical place.</para>
    /// </remarks>
    /// <seealso href="http://purl.org/saws/ontology#physicallyLocatedAt">http://purl.org/saws/ontology#physicallyLocatedAt</seealso>
    let physicallyLocatedAt = Prefixed_Name(saws, "physicallyLocatedAt") |> PrefixedName
    /// <summary>
    ///   <para>saws:precedes</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Section/ContentItem/CollectionInstance comes before another Section/ContentItem/CollectionInstance in the document</para>
    /// labels<para>precedes</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#precedes">http://purl.org/saws/ontology#precedes</seealso>
    let precedes = Prefixed_Name(saws, "precedes") |> PrefixedName
    /// <summary>
    ///   <para>saws:ownedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The Material of interest has been owned (in the past or currently) by this particular Person. This would normally be based on a specific statement/mark of ownership.
    ///
    /// [nb this will always need a date?]</para>
    /// labels<para>owned by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#ownedBy">http://purl.org/saws/ontology#ownedBy</seealso>
    let ownedBy = Prefixed_Name(saws, "ownedBy") |> PrefixedName
    /// <summary>
    ///   <para>saws:follows</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>A Section/ContentItem/CollectionInstance comes after another Section/ContentItem/CollectionInstance in the document</para>
    /// labels<para>follows</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#follows">http://purl.org/saws/ontology#follows</seealso>
    let follows = Prefixed_Name(saws, "follows") |> PrefixedName
    /// <summary>
    ///   <para>saws:formsPartOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>Physical Manuscripts can be composed of many Manuscript Parts – this relationship would be stated once for each part. This relationship can be used both for existing Manuscript Parts or for Manuscript Parts which used to be parts of a manuscript</para>
    /// labels<para>forms part of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#formsPartOf">http://purl.org/saws/ontology#formsPartOf</seealso>
    let formsPartOf = Prefixed_Name(saws, "formsPartOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:Definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>A content item that is defining a concept or term used in the material</para>
    /// labels<para>definition</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Definition">http://purl.org/saws/ontology#Definition</seealso>
    let Definition = Prefixed_Name(saws, "Definition") |> PrefixedName
    /// <summary>
    ///   <para>saws:Statement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The actual saying, e.g. 'All men are mortal'</para>
    /// labels<para>statement</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Statement">http://purl.org/saws/ontology#Statement</seealso>
    let Statement = Prefixed_Name(saws, "Statement") |> PrefixedName
    /// <summary>
    ///   <para>saws:decorationAddedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A DecorativeItem has been physically added onto the manuscript by a Person
    ///
    /// NB to represent marginalia notes (text) physically written in the margins of the manuscript, use: Marginalia marginaliaAddedBy Scribe @en</para>
    /// labels<para>decoration added by</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#decorationAddedBy">http://purl.org/saws/ontology#decorationAddedBy</seealso>
    let decorationAddedBy = Prefixed_Name(saws, "decorationAddedBy") |> PrefixedName

    /// <summary>
    ///   <para>saws:HypothesisedInstance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>The physical instance of an abstract manuscript text or collection instance which we hypothesise may have existed, but which we do not have - it is presumed lost or destroyed</para>
    /// labels<para>hypothesised instance</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#HypothesisedInstance">http://purl.org/saws/ontology#HypothesisedInstance</seealso>
    let HypothesisedInstance =
        Prefixed_Name(saws, "HypothesisedInstance") |> PrefixedName

    /// <summary>
    ///   <para>saws:Institution</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>An Institution can own materials, be located at places, and include persons as members</para>
    /// labels<para>institution</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#Institution">http://purl.org/saws/ontology#Institution</seealso>
    let Institution = Prefixed_Name(saws, "Institution") |> PrefixedName
    /// <summary>
    ///   <para>saws:isOlderThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Physical man-made thing (physical manuscript) is older than (i.e. was produced earlier in time than) another specified Physical man-made thing</para>
    /// labels<para>is older than</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isOlderThan">http://purl.org/saws/ontology#isOlderThan</seealso>
    let isOlderThan = Prefixed_Name(saws, "isOlderThan") |> PrefixedName
    /// <summary>
    ///   <para>saws:isYoungerThan</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Physical man-made thing (physical manuscript) is younger than (i.e. was produced later in time than) another specified Physical man-made thing</para>
    /// labels<para>is younger than</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isYoungerThan">http://purl.org/saws/ontology#isYoungerThan</seealso>
    let isYoungerThan = Prefixed_Name(saws, "isYoungerThan") |> PrefixedName

    /// <summary>
    ///   <para>saws:isSequentiallySameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:TransitiveProperty</para>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A CollectionInstance or Section has the same sequential structure as another CollectionInstance or Section. N.B. CollectionInstances contain sequences of ordered Sections. Sections contain sequences of ordered ContentItems</para>
    /// labels<para>is sequentially same as</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isSequentiallySameAs">http://purl.org/saws/ontology#isSequentiallySameAs</seealso>
    let isSequentiallySameAs =
        Prefixed_Name(saws, "isSequentiallySameAs") |> PrefixedName

    /// <summary>
    ///   <para>saws:isSequentiallySimilarTo</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A CollectionInstance or Section has a slightly different but related sequential structure to another CollectionInstance or Section. N.B. CollectionInstances contain sequences of ordered Sections. Sections contain sequences of ordered ContentItems</para>
    /// labels<para>is sequentially similar to</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isSequentiallySimilarTo">http://purl.org/saws/ontology#isSequentiallySimilarTo</seealso>
    let isSequentiallySimilarTo =
        Prefixed_Name(saws, "isSequentiallySimilarTo") |> PrefixedName

    /// <summary>
    ///   <para>saws:isShorterTranslationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>A LinguisticObject is a condensed copy of another LinguisticObject.
    ///
    /// For comparing between different languages (where a translation act is known to have taken place directly between those documents, in a particular direction)</para>
    /// labels<para>is shorter translation of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isShorterTranslationOf">http://purl.org/saws/ontology#isShorterTranslationOf</seealso>
    let isShorterTranslationOf =
        Prefixed_Name(saws, "isShorterTranslationOf") |> PrefixedName

    /// <summary>
    ///   <para>saws:isSiblingOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:SymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>The two OriginalMaterials are produced using the same source(s) OriginalMaterial(s) (as indirect or direct source)</para>
    /// </remarks>
    /// <seealso href="http://purl.org/saws/ontology#isSiblingOf">http://purl.org/saws/ontology#isSiblingOf</seealso>
    let isSiblingOf = Prefixed_Name(saws, "isSiblingOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:isSubSequenceOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A Section is formed of a sequence of ContentItems that is a subsequence of the sequence of ContentItems in another Section</para>
    /// labels<para>is sub sequence of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isSubSequenceOf">http://purl.org/saws/ontology#isSubSequenceOf</seealso>
    let isSubSequenceOf = Prefixed_Name(saws, "isSubSequenceOf") |> PrefixedName
    /// <summary>
    ///   <para>saws:isTransliterationOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AsymmetricProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>A LinguisticObject is a transliteration of another LinguisticObject, i.e. same words but using a different set of characters, e.g. kai isTransliterationOf και </para>
    /// labels<para>is transliteration of</para></remarks>
    /// <seealso href="http://purl.org/saws/ontology#isTransliterationOf">http://purl.org/saws/ontology#isTransliterationOf</seealso>
    let isTransliterationOf = Prefixed_Name(saws, "isTransliterationOf") |> PrefixedName
