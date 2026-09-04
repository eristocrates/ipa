#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module oa =
    let _prefixId = PrefixId.fromNamespaceLabel "http://www.w3.org/ns/oa#" "oa"
    let _namespaceIri = _prefixId.prefix ""
    /// <summary>
    ///   <para>rdfs:comment : The class for Web Annotations.^^xsd:string</para>
    ///   <para>rdfs:label : Annotation^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#Annotation">oa:Annotation</a>
    /// </summary>
    let Annotation = _prefixId.prefix "Annotation"
    /// <summary>
    ///   <para>rdfs:comment : A subClass of  as:OrderedCollection  that conveys to a consuming application that it should select one of the resources in the  as:items  list to use, rather than all of them.  This is typically used to provide a choice of resources to render to the user, based on further supplied properties.  If the consuming application cannot determine the user's preference, then it should use the first in the list.^^xsd:string</para>
    ///   <para>rdfs:label : Choice^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#Choice">oa:Choice</a>
    /// </summary>
    let Choice = _prefixId.prefix "Choice"
    /// <summary>
    ///   <para>rdfs:comment : A CssSelector describes a Segment of interest in a representation that conforms to the Document Object Model through the use of the CSS selector specification.^^xsd:string</para>
    ///   <para>rdfs:label : CssSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#CssSelector">oa:CssSelector</a>
    /// </summary>
    let CssSelector = _prefixId.prefix "CssSelector"
    /// <summary>
    ///   <para>rdfs:comment : A resource which describes styles for resources participating in the Annotation using CSS.^^xsd:string</para>
    ///   <para>rdfs:label : CssStyle^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#CssStyle">oa:CssStyle</a>
    /// </summary>
    let CssStyle = _prefixId.prefix "CssStyle"
    /// <summary>
    ///   <para>rdfs:comment : DataPositionSelector describes a range of data by recording the start and end positions of the selection in the stream. Position 0 would be immediately before the first byte, position 1 would be immediately before the second byte, and so on. The start byte is thus included in the list, but the end byte is not.^^xsd:string</para>
    ///   <para>rdfs:label : DataPositionSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#DataPositionSelector">oa:DataPositionSelector</a>
    /// </summary>
    let DataPositionSelector = _prefixId.prefix "DataPositionSelector"
    /// <summary>
    ///   <para>rdfs:comment : A class to encapsulate the different text directions that a textual resource might take.  It is not used directly in the Annotation Model, only its three instances.^^xsd:string</para>
    ///   <para>rdfs:label : Direction^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#Direction">oa:Direction</a>
    /// </summary>
    let Direction = _prefixId.prefix "Direction"
    /// <summary>
    ///   <para>rdfs:comment : The FragmentSelector class is used to record the segment of a representation using the IRI fragment specification defined by the representation's media type.^^xsd:string</para>
    ///   <para>rdfs:label : FragmentSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#FragmentSelector">oa:FragmentSelector</a>
    /// </summary>
    let FragmentSelector = _prefixId.prefix "FragmentSelector"
    /// <summary>
    ///   <para>rdfs:comment : The HttpRequestState class is used to record the HTTP request headers that a client SHOULD use to request the correct representation from the resource. ^^xsd:string</para>
    ///   <para>rdfs:label : HttpRequestState^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#HttpRequestState">oa:HttpRequestState</a>
    /// </summary>
    let HttpRequestState = _prefixId.prefix "HttpRequestState"
    /// <summary>
    ///   <para>rdfs:comment : The Motivation class is used to record the user's intent or motivation for the creation of the Annotation, or the inclusion of the body or target, that it is associated with.^^xsd:string</para>
    ///   <para>rdfs:label : Motivation^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#Motivation">oa:Motivation</a>
    /// </summary>
    let Motivation = _prefixId.prefix "Motivation"
    let PreferContainedDescriptions = _prefixId.prefix "PreferContainedDescriptions"
    let PreferContainedIRIs = _prefixId.prefix "PreferContainedIRIs"
    /// <summary>
    ///   <para>rdfs:comment : A Range Selector can be used to identify the beginning and the end of the selection by using other Selectors. The selection consists of everything from the beginning of the starting selector through to the beginning of the ending selector, but not including it.^^xsd:string</para>
    ///   <para>rdfs:label : RangeSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#RangeSelector">oa:RangeSelector</a>
    /// </summary>
    let RangeSelector = _prefixId.prefix "RangeSelector"
    /// <summary>
    ///   <para>rdfs:comment : Instances of the ResourceSelection class identify part (described by an oa:Selector) of another resource (referenced with oa:hasSource), possibly from a particular representation of a resource (described by an oa:State). Please note that ResourceSelection is not used directly in the Web Annotation model, but is provided as a separate class for further application profiles to use, separate from oa:SpecificResource which has many Annotation specific features.^^xsd:string</para>
    ///   <para>rdfs:label : ResourceSelection^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#ResourceSelection">oa:ResourceSelection</a>
    /// </summary>
    let ResourceSelection = _prefixId.prefix "ResourceSelection"
    /// <summary>
    ///   <para>rdfs:comment : A resource which describes the segment of interest in a representation of a Source resource, indicated with oa:hasSelector from the Specific Resource. This class is not used directly in the Annotation model, only its subclasses.^^xsd:string</para>
    ///   <para>rdfs:label : Selector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#Selector">oa:Selector</a>
    /// </summary>
    let Selector = _prefixId.prefix "Selector"
    /// <summary>
    ///   <para>rdfs:comment : Instances of the SpecificResource class identify part of another resource (referenced with oa:hasSource), a particular representation of a resource, a resource with styling hints for renders, or any combination of these, as used within an Annotation.^^xsd:string</para>
    ///   <para>rdfs:label : SpecificResource^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#SpecificResource">oa:SpecificResource</a>
    /// </summary>
    let SpecificResource = _prefixId.prefix "SpecificResource"
    /// <summary>
    ///   <para>rdfs:comment : A State describes the intended state of a resource as applied to the particular Annotation, and thus provides the information needed to retrieve the correct representation of that resource.^^xsd:string</para>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#State">oa:State</a>
    /// </summary>
    let State = _prefixId.prefix "State"
    /// <summary>
    ///   <para>rdfs:comment : A Style describes the intended styling of a resource as applied to the particular Annotation, and thus provides the information to ensure that rendering is consistent across implementations.^^xsd:string</para>
    ///   <para>rdfs:label : Style^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#Style">oa:Style</a>
    /// </summary>
    let Style = _prefixId.prefix "Style"
    /// <summary>
    ///   <para>rdfs:comment : An SvgSelector defines an area through the use of the Scalable Vector Graphics [SVG] standard. This allows the user to select a non-rectangular area of the content, such as a circle or polygon by describing the region using SVG. The SVG may be either embedded within the Annotation or referenced as an External Resource.^^xsd:string</para>
    ///   <para>rdfs:label : SvgSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#SvgSelector">oa:SvgSelector</a>
    /// </summary>
    let SvgSelector = _prefixId.prefix "SvgSelector"
    /// <summary>
    ///   <para>rdfs:comment : The TextPositionSelector describes a range of text by recording the start and end positions of the selection in the stream. Position 0 would be immediately before the first character, position 1 would be immediately before the second character, and so on.^^xsd:string</para>
    ///   <para>rdfs:label : TextPositionSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#TextPositionSelector">oa:TextPositionSelector</a>
    /// </summary>
    let TextPositionSelector = _prefixId.prefix "TextPositionSelector"
    /// <summary>
    ///   <para>rdfs:comment : The TextQuoteSelector describes a range of text by copying it, and including some of the text immediately before (a prefix) and after (a suffix) it to distinguish between multiple copies of the same sequence of characters.^^xsd:string</para>
    ///   <para>rdfs:label : TextQuoteSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#TextQuoteSelector">oa:TextQuoteSelector</a>
    /// </summary>
    let TextQuoteSelector = _prefixId.prefix "TextQuoteSelector"
    /// <summary>
    ///   <para>rdfs:comment : ^^xsd:string</para>
    ///   <para>rdfs:label : TextualBody^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#TextualBody">oa:TextualBody</a>
    /// </summary>
    let TextualBody = _prefixId.prefix "TextualBody"
    /// <summary>
    ///   <para>rdfs:comment : A TimeState records the time at which the resource's state is appropriate for the Annotation, typically the time that the Annotation was created and/or a link to a persistent copy of the current version.^^xsd:string</para>
    ///   <para>rdfs:label : TimeState^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#TimeState">oa:TimeState</a>
    /// </summary>
    let TimeState = _prefixId.prefix "TimeState"
    /// <summary>
    ///   <para>rdfs:comment :  An XPathSelector is used to select elements and content within a resource that supports the Document Object Model via a specified XPath value.^^xsd:string</para>
    ///   <para>rdfs:label : XPathSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#XPathSelector">oa:XPathSelector</a>
    /// </summary>
    let XPathSelector = _prefixId.prefix "XPathSelector"
    /// <summary>
    ///   <para>rdfs:comment : The object of the relationship is the end point of a service that conforms to the annotation-protocol, and it may be associated with any resource.  The expectation of asserting the relationship is that the object is the preferred service for maintaining annotations about the subject resource, according to the publisher of the relationship.
    ///
    ///   This relationship is intended to be used both within Linked Data descriptions and as the  rel  type of a Link, via HTTP Link Headers rfc5988 for binary resources and in HTML &lt;link&gt; elements.  For more information about these, please see the Annotation Protocol specification annotation-protocol.
    ///   ^^xsd:string</para>
    ///   <para>rdfs:label : annotationService^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#annotationService">oa:annotationService</a>
    /// </summary>
    let annotationService = _prefixId.prefix "annotationService"
    let assessing = _prefixId.prefix "assessing"
    /// <summary>
    ///   <para>rdfs:comment : The object of the predicate is a plain text string to be used as the content of the body of the Annotation.  The value MUST be an  xsd:string  and that data type MUST NOT be expressed in the serialization. Note that language MUST NOT be associated with the value either as a language tag, as that is only available for  rdf:langString .
    ///   ^^xsd:string</para>
    ///   <para>rdfs:label : bodyValue^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#bodyValue">oa:bodyValue</a>
    /// </summary>
    let bodyValue = _prefixId.prefix "bodyValue"
    let bookmarking = _prefixId.prefix "bookmarking"
    /// <summary>
    ///   <para>rdfs:comment : A object of the relationship is a copy of the Source resource's representation, appropriate for the Annotation.^^xsd:string</para>
    ///   <para>rdfs:label : cachedSource^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#cachedSource">oa:cachedSource</a>
    /// </summary>
    let cachedSource = _prefixId.prefix "cachedSource"
    /// <summary>
    ///   <para>rdfs:comment : A object of the relationship is the canonical IRI that can always be used to deduplicate the Annotation, regardless of the current IRI used to access the representation.^^xsd:string</para>
    ///   <para>rdfs:label : canonical^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#canonical">oa:canonical</a>
    /// </summary>
    let canonical = _prefixId.prefix "canonical"
    let classifying = _prefixId.prefix "classifying"
    let commenting = _prefixId.prefix "commenting"
    let describing = _prefixId.prefix "describing"
    let editing = _prefixId.prefix "editing"
    /// <summary>
    ///   <para>rdfs:comment : The end property is used to convey the 0-based index of the end position of a range of content.^^xsd:string</para>
    ///   <para>rdfs:label : end^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#end">oa:end</a>
    /// </summary>
    let end_ = _prefixId.prefix "end"
    /// <summary>
    ///   <para>rdfs:comment : The object of the predicate is a copy of the text which is being selected, after normalization.^^xsd:string</para>
    ///   <para>rdfs:label : exact^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#exact">oa:exact</a>
    /// </summary>
    let exact = _prefixId.prefix "exact"
    /// <summary>
    ///   <para>rdfs:comment : The object of the relationship is a resource that is a body of the Annotation.^^xsd:string</para>
    ///   <para>rdfs:label : hasBody^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#hasBody">oa:hasBody</a>
    /// </summary>
    let hasBody = _prefixId.prefix "hasBody"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between a RangeSelector and the Selector that describes the end position of the range. ^^xsd:string</para>
    ///   <para>rdfs:label : hasEndSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#hasEndSelector">oa:hasEndSelector</a>
    /// </summary>
    let hasEndSelector = _prefixId.prefix "hasEndSelector"
    /// <summary>
    ///   <para>rdfs:comment : The purpose served by the resource in the Annotation.^^xsd:string</para>
    ///   <para>rdfs:label : hasPurpose^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#hasPurpose">oa:hasPurpose</a>
    /// </summary>
    let hasPurpose = _prefixId.prefix "hasPurpose"
    /// <summary>
    ///   <para>rdfs:comment : The scope or context in which the resource is used within the Annotation.^^xsd:string</para>
    ///   <para>rdfs:label : hasScope^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#hasScope">oa:hasScope</a>
    /// </summary>
    let hasScope = _prefixId.prefix "hasScope"
    /// <summary>
    ///   <para>rdfs:comment : The object of the relationship is a Selector that describes the segment or region of interest within the source resource.  Please note that the domain ( oa:ResourceSelection ) is not used directly in the Web Annotation model.^^xsd:string</para>
    ///   <para>rdfs:label : hasSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#hasSelector">oa:hasSelector</a>
    /// </summary>
    let hasSelector = _prefixId.prefix "hasSelector"
    /// <summary>
    ///   <para>rdfs:comment : The resource that the ResourceSelection, or its subclass SpecificResource, is refined from, or more specific than. Please note that the domain ( oa:ResourceSelection ) is not used directly in the Web Annotation model.^^xsd:string</para>
    ///   <para>rdfs:label : hasSource^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#hasSource">oa:hasSource</a>
    /// </summary>
    let hasSource = _prefixId.prefix "hasSource"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between a RangeSelector and the Selector that describes the start position of the range. ^^xsd:string</para>
    ///   <para>rdfs:label : hasStartSelector^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#hasStartSelector">oa:hasStartSelector</a>
    /// </summary>
    let hasStartSelector = _prefixId.prefix "hasStartSelector"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between the ResourceSelection, or its subclass SpecificResource, and a State resource. Please note that the domain ( oa:ResourceSelection ) is not used directly in the Web Annotation model.^^xsd:string</para>
    ///   <para>rdfs:label : hasState^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#hasState">oa:hasState</a>
    /// </summary>
    let hasState = _prefixId.prefix "hasState"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between an Annotation and its Target.^^xsd:string</para>
    ///   <para>rdfs:label : hasTarget^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#hasTarget">oa:hasTarget</a>
    /// </summary>
    let hasTarget = _prefixId.prefix "hasTarget"
    let highlighting = _prefixId.prefix "highlighting"
    let identifying = _prefixId.prefix "identifying"
    let linking = _prefixId.prefix "linking"
    let ltrDirection = _prefixId.prefix "ltrDirection"
    let moderating = _prefixId.prefix "moderating"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between an Annotation and a Motivation that describes the reason for the Annotation's creation.^^xsd:string</para>
    ///   <para>rdfs:label : motivatedBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#motivatedBy">oa:motivatedBy</a>
    /// </summary>
    let motivatedBy = _prefixId.prefix "motivatedBy"
    /// <summary>
    ///   <para>rdfs:comment : The object of the property is a snippet of content that occurs immediately before the content which is being selected by the Selector.^^xsd:string</para>
    ///   <para>rdfs:label : prefix^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#prefix">oa:prefix</a>
    /// </summary>
    let prefix = _prefixId.prefix "prefix"
    /// <summary>
    ///   <para>rdfs:comment : The object of the property is the language that should be used for textual processing algorithms when dealing with the content of the resource, including hyphenation, line breaking, which font to use for rendering and so forth.  The value must follow the recommendations of BCP47.^^xsd:string</para>
    ///   <para>rdfs:label : processingLanguage^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#processingLanguage">oa:processingLanguage</a>
    /// </summary>
    let processingLanguage = _prefixId.prefix "processingLanguage"
    let questioning = _prefixId.prefix "questioning"
    /// <summary>
    ///   <para>rdfs:comment : The relationship between a Selector and another Selector or a State and a Selector or State that should be applied to the results of the first to refine the processing of the source resource. ^^xsd:string</para>
    ///   <para>rdfs:label : refinedBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#refinedBy">oa:refinedBy</a>
    /// </summary>
    let refinedBy = _prefixId.prefix "refinedBy"
    /// <summary>
    ///   <para>rdfs:comment : A system that was used by the application that created the Annotation to render the resource.^^xsd:string</para>
    ///   <para>rdfs:label : renderedVia^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#renderedVia">oa:renderedVia</a>
    /// </summary>
    let renderedVia = _prefixId.prefix "renderedVia"
    let replying = _prefixId.prefix "replying"
    let rtlDirection = _prefixId.prefix "rtlDirection"
    /// <summary>
    ///   <para>rdfs:comment : The timestamp at which the Source resource should be interpreted as being applicable to the Annotation.^^xsd:string</para>
    ///   <para>rdfs:label : sourceDate^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#sourceDate">oa:sourceDate</a>
    /// </summary>
    let sourceDate = _prefixId.prefix "sourceDate"
    /// <summary>
    ///   <para>rdfs:comment : The end timestamp of the interval over which the Source resource should be interpreted as being applicable to the Annotation.^^xsd:string</para>
    ///   <para>rdfs:label : sourceDateEnd^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#sourceDateEnd">oa:sourceDateEnd</a>
    /// </summary>
    let sourceDateEnd = _prefixId.prefix "sourceDateEnd"
    /// <summary>
    ///   <para>rdfs:comment : The start timestamp of the interval over which the Source resource should be interpreted as being applicable to the Annotation.^^xsd:string</para>
    ///   <para>rdfs:label : sourceDateStart^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#sourceDateStart">oa:sourceDateStart</a>
    /// </summary>
    let sourceDateStart = _prefixId.prefix "sourceDateStart"
    /// <summary>
    ///   <para>rdfs:comment : The start position in a 0-based index at which a range of content is selected from the data in the source resource.^^xsd:string</para>
    ///   <para>rdfs:label : start^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#start">oa:start</a>
    /// </summary>
    let start = _prefixId.prefix "start"
    /// <summary>
    ///   <para>rdfs:comment : The name of the class used in the CSS description referenced from the Annotation that should be applied to the Specific Resource.^^xsd:string</para>
    ///   <para>rdfs:label : styleClass^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#styleClass">oa:styleClass</a>
    /// </summary>
    let styleClass = _prefixId.prefix "styleClass"
    /// <summary>
    ///   <para>rdfs:comment : A reference to a Stylesheet that should be used to apply styles to the Annotation rendering.^^xsd:string</para>
    ///   <para>rdfs:label : styledBy^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#styledBy">oa:styledBy</a>
    /// </summary>
    let styledBy = _prefixId.prefix "styledBy"
    /// <summary>
    ///   <para>rdfs:comment : The snippet of text that occurs immediately after the text which is being selected.^^xsd:string</para>
    ///   <para>rdfs:label : suffix^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#suffix">oa:suffix</a>
    /// </summary>
    let suffix = _prefixId.prefix "suffix"
    let tagging = _prefixId.prefix "tagging"
    /// <summary>
    ///   <para>rdfs:comment : The direction of the text of the subject resource. There MUST only be one text direction associated with any given resource.^^xsd:string</para>
    ///   <para>rdfs:label : textDirection^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#textDirection">oa:textDirection</a>
    /// </summary>
    let textDirection = _prefixId.prefix "textDirection"
    /// <summary>
    ///   <para>rdfs:comment : A object of the relationship is a resource from which the source resource was retrieved by the providing system.^^xsd:string</para>
    ///   <para>rdfs:label : via^^xsd:string</para>
    ///   <a href="http://www.w3.org/ns/oa#via">oa:via</a>
    /// </summary>
    let via = _prefixId.prefix "via"
