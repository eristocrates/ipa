namespace http.www.w3.org.ns.oa.hash

open DoxAletheia

module oa =
    let _namespace_name = "http://www.w3.org/ns/oa#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// The class for Web Annotations.
    /// <see href="http://www.w3.org/ns/oa#Annotation"></see></summary>
    let Annotation = _prefix "Annotation"
    /// <summary>
    /// A subClass of  as:OrderedCollection  that conveys to a consuming application that it should select one of the resources in the  as:items  list to use, rather than all of them.  This is typically used to provide a choice of resources to render to the user, based on further supplied properties.  If the consuming application cannot determine the user's preference, then it should use the first in the list.
    /// <see href="http://www.w3.org/ns/oa#Choice"></see></summary>
    let Choice = _prefix "Choice"
    /// <summary>
    /// A CssSelector describes a Segment of interest in a representation that conforms to the Document Object Model through the use of the CSS selector specification.
    /// <see href="http://www.w3.org/ns/oa#CssSelector"></see></summary>
    let CssSelector = _prefix "CssSelector"
    /// <summary>
    /// A resource which describes the segment of interest in a representation of a Source resource, indicated with oa:hasSelector from the Specific Resource. This class is not used directly in the Annotation model, only its subclasses.
    /// <see href="http://www.w3.org/ns/oa#Selector"></see></summary>
    let Selector = _prefix "Selector"
    /// <summary>
    /// A resource which describes styles for resources participating in the Annotation using CSS.
    /// <see href="http://www.w3.org/ns/oa#CssStyle"></see></summary>
    let CssStyle = _prefix "CssStyle"
    /// <summary>
    /// A Style describes the intended styling of a resource as applied to the particular Annotation, and thus provides the information to ensure that rendering is consistent across implementations.
    /// <see href="http://www.w3.org/ns/oa#Style"></see></summary>
    let Style = _prefix "Style"
    /// <summary>
    /// DataPositionSelector describes a range of data by recording the start and end positions of the selection in the stream. Position 0 would be immediately before the first byte, position 1 would be immediately before the second byte, and so on. The start byte is thus included in the list, but the end byte is not.
    /// <see href="http://www.w3.org/ns/oa#DataPositionSelector"></see></summary>
    let DataPositionSelector = _prefix "DataPositionSelector"
    /// <summary>
    /// A class to encapsulate the different text directions that a textual resource might take.  It is not used directly in the Annotation Model, only its three instances.
    /// <see href="http://www.w3.org/ns/oa#Direction"></see></summary>
    let Direction = _prefix "Direction"
    /// <summary>
    /// The FragmentSelector class is used to record the segment of a representation using the IRI fragment specification defined by the representation's media type.
    /// <see href="http://www.w3.org/ns/oa#FragmentSelector"></see></summary>
    let FragmentSelector = _prefix "FragmentSelector"
    /// <summary>
    /// The HttpRequestState class is used to record the HTTP request headers that a client SHOULD use to request the correct representation from the resource.
    /// <see href="http://www.w3.org/ns/oa#HttpRequestState"></see></summary>
    let HttpRequestState = _prefix "HttpRequestState"
    /// <summary>
    /// A State describes the intended state of a resource as applied to the particular Annotation, and thus provides the information needed to retrieve the correct representation of that resource.
    /// <see href="http://www.w3.org/ns/oa#State"></see></summary>
    let State = _prefix "State"
    /// <summary>
    /// The Motivation class is used to record the user's intent or motivation for the creation of the Annotation, or the inclusion of the body or target, that it is associated with.
    /// <see href="http://www.w3.org/ns/oa#Motivation"></see></summary>
    let Motivation = _prefix "Motivation"
    /// <summary>
    /// An IRI to signal the client prefers to receive full descriptions of the Annotations from a container, not just their IRIs.
    /// <see href="http://www.w3.org/ns/oa#PreferContainedDescriptions"></see></summary>
    let PreferContainedDescriptions = _prefix "PreferContainedDescriptions"
    /// <summary>
    /// An IRI to signal that the client prefers to receive only the IRIs of the Annotations from a container, not their full descriptions.
    /// <see href="http://www.w3.org/ns/oa#PreferContainedIRIs"></see></summary>
    let PreferContainedIRIs = _prefix "PreferContainedIRIs"
    /// <summary>
    /// A Range Selector can be used to identify the beginning and the end of the selection by using other Selectors. The selection consists of everything from the beginning of the starting selector through to the beginning of the ending selector, but not including it.
    /// <see href="http://www.w3.org/ns/oa#RangeSelector"></see></summary>
    let RangeSelector = _prefix "RangeSelector"
    /// <summary>
    /// Instances of the ResourceSelection class identify part (described by an oa:Selector) of another resource (referenced with oa:hasSource), possibly from a particular representation of a resource (described by an oa:State). Please note that ResourceSelection is not used directly in the Web Annotation model, but is provided as a separate class for further application profiles to use, separate from oa:SpecificResource which has many Annotation specific features.
    /// <see href="http://www.w3.org/ns/oa#ResourceSelection"></see></summary>
    let ResourceSelection = _prefix "ResourceSelection"
    /// <summary>
    /// Instances of the SpecificResource class identify part of another resource (referenced with oa:hasSource), a particular representation of a resource, a resource with styling hints for renders, or any combination of these, as used within an Annotation.
    /// <see href="http://www.w3.org/ns/oa#SpecificResource"></see></summary>
    let SpecificResource = _prefix "SpecificResource"
    /// <summary>
    /// An SvgSelector defines an area through the use of the Scalable Vector Graphics [SVG] standard. This allows the user to select a non-rectangular area of the content, such as a circle or polygon by describing the region using SVG. The SVG may be either embedded within the Annotation or referenced as an External Resource.
    /// <see href="http://www.w3.org/ns/oa#SvgSelector"></see></summary>
    let SvgSelector = _prefix "SvgSelector"
    /// <summary>
    /// The TextPositionSelector describes a range of text by recording the start and end positions of the selection in the stream. Position 0 would be immediately before the first character, position 1 would be immediately before the second character, and so on.
    /// <see href="http://www.w3.org/ns/oa#TextPositionSelector"></see></summary>
    let TextPositionSelector = _prefix "TextPositionSelector"
    /// <summary>
    /// The TextQuoteSelector describes a range of text by copying it, and including some of the text immediately before (a prefix) and after (a suffix) it to distinguish between multiple copies of the same sequence of characters.
    /// <see href="http://www.w3.org/ns/oa#TextQuoteSelector"></see></summary>
    let TextQuoteSelector = _prefix "TextQuoteSelector"
    /// <summary>
    ///   <see href="http://www.w3.org/ns/oa#TextualBody"></see>
    /// </summary>
    let TextualBody = _prefix "TextualBody"
    /// <summary>
    /// A TimeState records the time at which the resource's state is appropriate for the Annotation, typically the time that the Annotation was created and/or a link to a persistent copy of the current version.
    /// <see href="http://www.w3.org/ns/oa#TimeState"></see></summary>
    let TimeState = _prefix "TimeState"
    /// <summary>
    ///  An XPathSelector is used to select elements and content within a resource that supports the Document Object Model via a specified XPath value.
    /// <see href="http://www.w3.org/ns/oa#XPathSelector"></see></summary>
    let XPathSelector = _prefix "XPathSelector"
    /// <summary>
    /// The object of the relationship is the end point of a service that conforms to the annotation-protocol, and it may be associated with any resource.  The expectation of asserting the relationship is that the object is the preferred service for maintaining annotations about the subject resource, according to the publisher of the relationship.
    ///
    ///   This relationship is intended to be used both within Linked Data descriptions and as the  rel  type of a Link, via HTTP Link Headers rfc5988 for binary resources and in HTML &lt;link&gt; elements.  For more information about these, please see the Annotation Protocol specification annotation-protocol.
    ///
    /// <see href="http://www.w3.org/ns/oa#annotationService"></see></summary>
    let annotationService = _prefix "annotationService"
    /// <summary>
    /// The motivation for when the user intends to provide an assessment about the Target resource.
    /// <see href="http://www.w3.org/ns/oa#assessing"></see></summary>
    let assessing = _prefix "assessing"
    /// <summary>
    /// The object of the predicate is a plain text string to be used as the content of the body of the Annotation.  The value MUST be an  xsd:string  and that data type MUST NOT be expressed in the serialization. Note that language MUST NOT be associated with the value either as a language tag, as that is only available for  rdf:langString .
    ///
    /// <see href="http://www.w3.org/ns/oa#bodyValue"></see></summary>
    let bodyValue = _prefix "bodyValue"
    /// <summary>
    /// The motivation for when the user intends to create a bookmark to the Target or part thereof.
    /// <see href="http://www.w3.org/ns/oa#bookmarking"></see></summary>
    let bookmarking = _prefix "bookmarking"
    /// <summary>
    /// A object of the relationship is a copy of the Source resource's representation, appropriate for the Annotation.
    /// <see href="http://www.w3.org/ns/oa#cachedSource"></see></summary>
    let cachedSource = _prefix "cachedSource"
    /// <summary>
    /// A object of the relationship is the canonical IRI that can always be used to deduplicate the Annotation, regardless of the current IRI used to access the representation.
    /// <see href="http://www.w3.org/ns/oa#canonical"></see></summary>
    let canonical = _prefix "canonical"
    /// <summary>
    /// The motivation for when the user intends to that classify the Target as something.
    /// <see href="http://www.w3.org/ns/oa#classifying"></see></summary>
    let classifying = _prefix "classifying"
    /// <summary>
    /// The motivation for when the user intends to comment about the Target.
    /// <see href="http://www.w3.org/ns/oa#commenting"></see></summary>
    let commenting = _prefix "commenting"
    /// <summary>
    /// The motivation for when the user intends to describe the Target, as opposed to a comment about them.
    /// <see href="http://www.w3.org/ns/oa#describing"></see></summary>
    let describing = _prefix "describing"
    /// <summary>
    /// The motivation for when the user intends to request a change or edit to the Target resource.
    /// <see href="http://www.w3.org/ns/oa#editing"></see></summary>
    let editing = _prefix "editing"
    /// <summary>
    /// The end property is used to convey the 0-based index of the end position of a range of content.
    /// <see href="http://www.w3.org/ns/oa#end"></see></summary>
    let end_ = _prefix "end"
    /// <summary>
    /// The object of the predicate is a copy of the text which is being selected, after normalization.
    /// <see href="http://www.w3.org/ns/oa#exact"></see></summary>
    let exact = _prefix "exact"
    /// <summary>
    /// The object of the relationship is a resource that is a body of the Annotation.
    /// <see href="http://www.w3.org/ns/oa#hasBody"></see></summary>
    let hasBody = _prefix "hasBody"
    /// <summary>
    /// The relationship between a RangeSelector and the Selector that describes the end position of the range.
    /// <see href="http://www.w3.org/ns/oa#hasEndSelector"></see></summary>
    let hasEndSelector = _prefix "hasEndSelector"
    /// <summary>
    /// The purpose served by the resource in the Annotation.
    /// <see href="http://www.w3.org/ns/oa#hasPurpose"></see></summary>
    let hasPurpose = _prefix "hasPurpose"
    /// <summary>
    /// The scope or context in which the resource is used within the Annotation.
    /// <see href="http://www.w3.org/ns/oa#hasScope"></see></summary>
    let hasScope = _prefix "hasScope"
    /// <summary>
    /// The object of the relationship is a Selector that describes the segment or region of interest within the source resource.  Please note that the domain ( oa:ResourceSelection ) is not used directly in the Web Annotation model.
    /// <see href="http://www.w3.org/ns/oa#hasSelector"></see></summary>
    let hasSelector = _prefix "hasSelector"
    /// <summary>
    /// The resource that the ResourceSelection, or its subclass SpecificResource, is refined from, or more specific than. Please note that the domain ( oa:ResourceSelection ) is not used directly in the Web Annotation model.
    /// <see href="http://www.w3.org/ns/oa#hasSource"></see></summary>
    let hasSource = _prefix "hasSource"
    /// <summary>
    /// The relationship between a RangeSelector and the Selector that describes the start position of the range.
    /// <see href="http://www.w3.org/ns/oa#hasStartSelector"></see></summary>
    let hasStartSelector = _prefix "hasStartSelector"
    /// <summary>
    /// The relationship between the ResourceSelection, or its subclass SpecificResource, and a State resource. Please note that the domain ( oa:ResourceSelection ) is not used directly in the Web Annotation model.
    /// <see href="http://www.w3.org/ns/oa#hasState"></see></summary>
    let hasState = _prefix "hasState"
    /// <summary>
    /// The relationship between an Annotation and its Target.
    /// <see href="http://www.w3.org/ns/oa#hasTarget"></see></summary>
    let hasTarget = _prefix "hasTarget"
    /// <summary>
    /// The motivation for when the user intends to highlight the Target resource or segment of it.
    /// <see href="http://www.w3.org/ns/oa#highlighting"></see></summary>
    let highlighting = _prefix "highlighting"
    /// <summary>
    /// The motivation for when the user intends to assign an identity to the Target or identify what is being depicted or described in the Target.
    /// <see href="http://www.w3.org/ns/oa#identifying"></see></summary>
    let identifying = _prefix "identifying"
    /// <summary>
    /// The motivation for when the user intends to link to a resource related to the Target.
    /// <see href="http://www.w3.org/ns/oa#linking"></see></summary>
    let linking = _prefix "linking"
    /// <summary>
    /// The direction of text that is read from left to right.
    /// <see href="http://www.w3.org/ns/oa#ltrDirection"></see></summary>
    let ltrDirection = _prefix "ltrDirection"
    /// <summary>
    /// The motivation for when the user intends to assign some value or quality to the Target.
    /// <see href="http://www.w3.org/ns/oa#moderating"></see></summary>
    let moderating = _prefix "moderating"
    /// <summary>
    /// The relationship between an Annotation and a Motivation that describes the reason for the Annotation's creation.
    /// <see href="http://www.w3.org/ns/oa#motivatedBy"></see></summary>
    let motivatedBy = _prefix "motivatedBy"
    /// <summary>
    /// The object of the property is a snippet of content that occurs immediately before the content which is being selected by the Selector.
    /// <see href="http://www.w3.org/ns/oa#prefix"></see></summary>
    let prefix = _prefix "prefix"
    /// <summary>
    /// The object of the property is the language that should be used for textual processing algorithms when dealing with the content of the resource, including hyphenation, line breaking, which font to use for rendering and so forth.  The value must follow the recommendations of BCP47.
    /// <see href="http://www.w3.org/ns/oa#processingLanguage"></see></summary>
    let processingLanguage = _prefix "processingLanguage"
    /// <summary>
    /// The motivation for when the user intends to ask a question about the Target.
    /// <see href="http://www.w3.org/ns/oa#questioning"></see></summary>
    let questioning = _prefix "questioning"
    /// <summary>
    /// The relationship between a Selector and another Selector or a State and a Selector or State that should be applied to the results of the first to refine the processing of the source resource.
    /// <see href="http://www.w3.org/ns/oa#refinedBy"></see></summary>
    let refinedBy = _prefix "refinedBy"
    /// <summary>
    /// A system that was used by the application that created the Annotation to render the resource.
    /// <see href="http://www.w3.org/ns/oa#renderedVia"></see></summary>
    let renderedVia = _prefix "renderedVia"
    /// <summary>
    /// The motivation for when the user intends to reply to a previous statement, either an Annotation or another resource.
    /// <see href="http://www.w3.org/ns/oa#replying"></see></summary>
    let replying = _prefix "replying"
    /// <summary>
    /// The direction of text that is read from right to left.
    /// <see href="http://www.w3.org/ns/oa#rtlDirection"></see></summary>
    let rtlDirection = _prefix "rtlDirection"
    /// <summary>
    /// The timestamp at which the Source resource should be interpreted as being applicable to the Annotation.
    /// <see href="http://www.w3.org/ns/oa#sourceDate"></see></summary>
    let sourceDate = _prefix "sourceDate"
    /// <summary>
    /// The end timestamp of the interval over which the Source resource should be interpreted as being applicable to the Annotation.
    /// <see href="http://www.w3.org/ns/oa#sourceDateEnd"></see></summary>
    let sourceDateEnd = _prefix "sourceDateEnd"
    /// <summary>
    /// The start timestamp of the interval over which the Source resource should be interpreted as being applicable to the Annotation.
    /// <see href="http://www.w3.org/ns/oa#sourceDateStart"></see></summary>
    let sourceDateStart = _prefix "sourceDateStart"
    /// <summary>
    /// The start position in a 0-based index at which a range of content is selected from the data in the source resource.
    /// <see href="http://www.w3.org/ns/oa#start"></see></summary>
    let start = _prefix "start"
    /// <summary>
    /// The name of the class used in the CSS description referenced from the Annotation that should be applied to the Specific Resource.
    /// <see href="http://www.w3.org/ns/oa#styleClass"></see></summary>
    let styleClass = _prefix "styleClass"
    /// <summary>
    /// A reference to a Stylesheet that should be used to apply styles to the Annotation rendering.
    /// <see href="http://www.w3.org/ns/oa#styledBy"></see></summary>
    let styledBy = _prefix "styledBy"
    /// <summary>
    /// The snippet of text that occurs immediately after the text which is being selected.
    /// <see href="http://www.w3.org/ns/oa#suffix"></see></summary>
    let suffix = _prefix "suffix"
    /// <summary>
    /// The motivation for when the user intends to associate a tag with the Target.
    /// <see href="http://www.w3.org/ns/oa#tagging"></see></summary>
    let tagging = _prefix "tagging"
    /// <summary>
    /// The direction of the text of the subject resource. There MUST only be one text direction associated with any given resource.
    /// <see href="http://www.w3.org/ns/oa#textDirection"></see></summary>
    let textDirection = _prefix "textDirection"
    /// <summary>
    /// A object of the relationship is a resource from which the source resource was retrieved by the providing system.
    /// <see href="http://www.w3.org/ns/oa#via"></see></summary>
    let via = _prefix "via"
