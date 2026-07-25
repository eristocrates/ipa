namespace http.www.w3.org.ns.oa.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module oa =
    let _namespace_iri = Namespace_Iri oa |> NamespaceIRI
    /// <summary>
    ///   <para>oa:CssSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A CssSelector describes a Segment of interest in a representation that conforms to the Document Object Model through the use of the CSS selector specification.</para>
    /// labels<para>CssSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#CssSelector">http://www.w3.org/ns/oa#CssSelector</seealso>
    let CssSelector = Prefixed_Name(oa, "CssSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:DataPositionSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>DataPositionSelector describes a range of data by recording the start and end positions of the selection in the stream. Position 0 would be immediately before the first byte, position 1 would be immediately before the second byte, and so on. The start byte is thus included in the list, but the end byte is not.</para>
    /// labels<para>DataPositionSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#DataPositionSelector">http://www.w3.org/ns/oa#DataPositionSelector</seealso>
    let DataPositionSelector = Prefixed_Name(oa, "DataPositionSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:FragmentSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The FragmentSelector class is used to record the segment of a representation using the IRI fragment specification defined by the representation's media type.</para>
    /// labels<para>FragmentSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#FragmentSelector">http://www.w3.org/ns/oa#FragmentSelector</seealso>
    let FragmentSelector = Prefixed_Name(oa, "FragmentSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:Choice</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A subClass of  as:OrderedCollection  that conveys to a consuming application that it should select one of the resources in the  as:items  list to use, rather than all of them.  This is typically used to provide a choice of resources to render to the user, based on further supplied properties.  If the consuming application cannot determine the user's preference, then it should use the first in the list.</para>
    /// labels<para>Choice</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#Choice">http://www.w3.org/ns/oa#Choice</seealso>
    let Choice = Prefixed_Name(oa, "Choice") |> PrefixedName
    /// <summary>
    ///   <para>oa:CssStyle</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource which describes styles for resources participating in the Annotation using CSS.</para>
    /// labels<para>CssStyle</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#CssStyle">http://www.w3.org/ns/oa#CssStyle</seealso>
    let CssStyle = Prefixed_Name(oa, "CssStyle") |> PrefixedName
    /// <summary>
    ///   <para>oa:Direction</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A class to encapsulate the different text directions that a textual resource might take.  It is not used directly in the Annotation Model, only its three instances.</para>
    /// labels<para>Direction</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#Direction">http://www.w3.org/ns/oa#Direction</seealso>
    let Direction = Prefixed_Name(oa, "Direction") |> PrefixedName
    /// <summary>
    ///   <para>oa:Annotation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The class for Web Annotations.</para>
    /// labels<para>Annotation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#Annotation">http://www.w3.org/ns/oa#Annotation</seealso>
    let Annotation = Prefixed_Name(oa, "Annotation") |> PrefixedName
    /// <summary>
    ///   <para>oa:Selector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A resource which describes the segment of interest in a representation of a Source resource, indicated with oa:hasSelector from the Specific Resource. This class is not used directly in the Annotation model, only its subclasses.</para>
    /// labels<para>Selector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#Selector">http://www.w3.org/ns/oa#Selector</seealso>
    let Selector = Prefixed_Name(oa, "Selector") |> PrefixedName
    /// <summary>
    ///   <para>oa:TextPositionSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The TextPositionSelector describes a range of text by recording the start and end positions of the selection in the stream. Position 0 would be immediately before the first character, position 1 would be immediately before the second character, and so on.</para>
    /// labels<para>TextPositionSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#TextPositionSelector">http://www.w3.org/ns/oa#TextPositionSelector</seealso>
    let TextPositionSelector = Prefixed_Name(oa, "TextPositionSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:XPathSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para> An XPathSelector is used to select elements and content within a resource that supports the Document Object Model via a specified XPath value.</para>
    /// labels<para>XPathSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#XPathSelector">http://www.w3.org/ns/oa#XPathSelector</seealso>
    let XPathSelector = Prefixed_Name(oa, "XPathSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:assessing</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to provide an assessment about the Target resource.</para>
    /// labels<para>assessing</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#assessing">http://www.w3.org/ns/oa#assessing</seealso>
    let assessing = Prefixed_Name(oa, "assessing") |> PrefixedName
    /// <summary>
    ///   <para>oa:ResourceSelection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Instances of the ResourceSelection class identify part (described by an oa:Selector) of another resource (referenced with oa:hasSource), possibly from a particular representation of a resource (described by an oa:State). Please note that ResourceSelection is not used directly in the Web Annotation model, but is provided as a separate class for further application profiles to use, separate from oa:SpecificResource which has many Annotation specific features.</para>
    /// labels<para>ResourceSelection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#ResourceSelection">http://www.w3.org/ns/oa#ResourceSelection</seealso>
    let ResourceSelection = Prefixed_Name(oa, "ResourceSelection") |> PrefixedName
    /// <summary>
    ///   <para>oa:SvgSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>An SvgSelector defines an area through the use of the Scalable Vector Graphics [SVG] standard. This allows the user to select a non-rectangular area of the content, such as a circle or polygon by describing the region using SVG. The SVG may be either embedded within the Annotation or referenced as an External Resource.</para>
    /// labels<para>SvgSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#SvgSelector">http://www.w3.org/ns/oa#SvgSelector</seealso>
    let SvgSelector = Prefixed_Name(oa, "SvgSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:TextualBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para></para>
    /// labels<para>TextualBody</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#TextualBody">http://www.w3.org/ns/oa#TextualBody</seealso>
    let TextualBody = Prefixed_Name(oa, "TextualBody") |> PrefixedName
    /// <summary>
    ///   <para>oa:annotationService</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object of the relationship is the end point of a service that conforms to the annotation-protocol, and it may be associated with any resource.  The expectation of asserting the relationship is that the object is the preferred service for maintaining annotations about the subject resource, according to the publisher of the relationship.
    ///
    ///   This relationship is intended to be used both within Linked Data descriptions and as the  rel  type of a Link, via HTTP Link Headers rfc5988 for binary resources and in HTML &lt;link&gt; elements.  For more information about these, please see the Annotation Protocol specification annotation-protocol.
    ///   </para>
    /// labels<para>annotationService</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#annotationService">http://www.w3.org/ns/oa#annotationService</seealso>
    let annotationService = Prefixed_Name(oa, "annotationService") |> PrefixedName
    /// <summary>
    ///   <para>oa:moderating</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to assign some value or quality to the Target.</para>
    /// labels<para>moderating</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#moderating">http://www.w3.org/ns/oa#moderating</seealso>
    let moderating = Prefixed_Name(oa, "moderating") |> PrefixedName
    /// <summary>
    ///   <para>oa:processingLanguage</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object of the property is the language that should be used for textual processing algorithms when dealing with the content of the resource, including hyphenation, line breaking, which font to use for rendering and so forth.  The value must follow the recommendations of BCP47.</para>
    /// labels<para>processingLanguage</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#processingLanguage">http://www.w3.org/ns/oa#processingLanguage</seealso>
    let processingLanguage = Prefixed_Name(oa, "processingLanguage") |> PrefixedName
    /// <summary>
    ///   <para>oa:replying</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to reply to a previous statement, either an Annotation or another resource.</para>
    /// labels<para>replying</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#replying">http://www.w3.org/ns/oa#replying</seealso>
    let replying = Prefixed_Name(oa, "replying") |> PrefixedName
    /// <summary>
    ///   <para>oa:Motivation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The Motivation class is used to record the user's intent or motivation for the creation of the Annotation, or the inclusion of the body or target, that it is associated with.</para>
    /// labels<para>Motivation</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#Motivation">http://www.w3.org/ns/oa#Motivation</seealso>
    let Motivation = Prefixed_Name(oa, "Motivation") |> PrefixedName
    /// <summary>
    ///   <para>oa:RangeSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Range Selector can be used to identify the beginning and the end of the selection by using other Selectors. The selection consists of everything from the beginning of the starting selector through to the beginning of the ending selector, but not including it.</para>
    /// labels<para>RangeSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#RangeSelector">http://www.w3.org/ns/oa#RangeSelector</seealso>
    let RangeSelector = Prefixed_Name(oa, "RangeSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:State</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A State describes the intended state of a resource as applied to the particular Annotation, and thus provides the information needed to retrieve the correct representation of that resource.</para>
    /// labels<para>State</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#State">http://www.w3.org/ns/oa#State</seealso>
    let State = Prefixed_Name(oa, "State") |> PrefixedName

    /// <summary>
    ///   <para>oa:PreferContainedDescriptions</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>An IRI to signal the client prefers to receive full descriptions of the Annotations from a container, not just their IRIs.</para>
    /// labels<para>PreferContainedDescriptions</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#PreferContainedDescriptions">http://www.w3.org/ns/oa#PreferContainedDescriptions</seealso>
    let PreferContainedDescriptions =
        Prefixed_Name(oa, "PreferContainedDescriptions") |> PrefixedName

    /// <summary>
    ///   <para>oa:PreferContainedIRIs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Resource</para>
    ///   <para>An IRI to signal that the client prefers to receive only the IRIs of the Annotations from a container, not their full descriptions.</para>
    /// labels<para>PreferContainedIRIs</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#PreferContainedIRIs">http://www.w3.org/ns/oa#PreferContainedIRIs</seealso>
    let PreferContainedIRIs = Prefixed_Name(oa, "PreferContainedIRIs") |> PrefixedName
    /// <summary>
    ///   <para>oa:SpecificResource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Instances of the SpecificResource class identify part of another resource (referenced with oa:hasSource), a particular representation of a resource, a resource with styling hints for renders, or any combination of these, as used within an Annotation.</para>
    /// labels<para>SpecificResource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#SpecificResource">http://www.w3.org/ns/oa#SpecificResource</seealso>
    let SpecificResource = Prefixed_Name(oa, "SpecificResource") |> PrefixedName
    /// <summary>
    ///   <para>oa:TextQuoteSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The TextQuoteSelector describes a range of text by copying it, and including some of the text immediately before (a prefix) and after (a suffix) it to distinguish between multiple copies of the same sequence of characters.</para>
    /// labels<para>TextQuoteSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#TextQuoteSelector">http://www.w3.org/ns/oa#TextQuoteSelector</seealso>
    let TextQuoteSelector = Prefixed_Name(oa, "TextQuoteSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:TimeState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A TimeState records the time at which the resource's state is appropriate for the Annotation, typically the time that the Annotation was created and/or a link to a persistent copy of the current version.</para>
    /// labels<para>TimeState</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#TimeState">http://www.w3.org/ns/oa#TimeState</seealso>
    let TimeState = Prefixed_Name(oa, "TimeState") |> PrefixedName
    /// <summary>
    ///   <para>oa:bodyValue</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object of the predicate is a plain text string to be used as the content of the body of the Annotation.  The value MUST be an  xsd:string  and that data type MUST NOT be expressed in the serialization. Note that language MUST NOT be associated with the value either as a language tag, as that is only available for  rdf:langString .
    ///   </para>
    /// labels<para>bodyValue</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#bodyValue">http://www.w3.org/ns/oa#bodyValue</seealso>
    let bodyValue = Prefixed_Name(oa, "bodyValue") |> PrefixedName
    /// <summary>
    ///   <para>oa:bookmarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to create a bookmark to the Target or part thereof.</para>
    /// labels<para>bookmarking</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#bookmarking">http://www.w3.org/ns/oa#bookmarking</seealso>
    let bookmarking = Prefixed_Name(oa, "bookmarking") |> PrefixedName
    /// <summary>
    ///   <para>oa:classifying</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to that classify the Target as something.</para>
    /// labels<para>classifying</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#classifying">http://www.w3.org/ns/oa#classifying</seealso>
    let classifying = Prefixed_Name(oa, "classifying") |> PrefixedName
    /// <summary>
    ///   <para>oa:cachedSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A object of the relationship is a copy of the Source resource's representation, appropriate for the Annotation.</para>
    /// labels<para>cachedSource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#cachedSource">http://www.w3.org/ns/oa#cachedSource</seealso>
    let cachedSource = Prefixed_Name(oa, "cachedSource") |> PrefixedName
    /// <summary>
    ///   <para>oa:commenting</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to comment about the Target.</para>
    /// labels<para>commenting</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#commenting">http://www.w3.org/ns/oa#commenting</seealso>
    let commenting = Prefixed_Name(oa, "commenting") |> PrefixedName
    /// <summary>
    ///   <para>oa:editing</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to request a change or edit to the Target resource.</para>
    /// labels<para>editing</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#editing">http://www.w3.org/ns/oa#editing</seealso>
    let editing = Prefixed_Name(oa, "editing") |> PrefixedName
    /// <summary>
    ///   <para>oa:exact</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object of the predicate is a copy of the text which is being selected, after normalization.</para>
    /// labels<para>exact</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#exact">http://www.w3.org/ns/oa#exact</seealso>
    let exact = Prefixed_Name(oa, "exact") |> PrefixedName
    /// <summary>
    ///   <para>oa:hasPurpose</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The purpose served by the resource in the Annotation.</para>
    /// labels<para>hasPurpose</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#hasPurpose">http://www.w3.org/ns/oa#hasPurpose</seealso>
    let hasPurpose = Prefixed_Name(oa, "hasPurpose") |> PrefixedName
    /// <summary>
    ///   <para>oa:canonical</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A object of the relationship is the canonical IRI that can always be used to deduplicate the Annotation, regardless of the current IRI used to access the representation.</para>
    /// labels<para>canonical</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#canonical">http://www.w3.org/ns/oa#canonical</seealso>
    let canonical = Prefixed_Name(oa, "canonical") |> PrefixedName
    /// <summary>
    ///   <para>oa:describing</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to describe the Target, as opposed to a comment about them.</para>
    /// labels<para>describing</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#describing">http://www.w3.org/ns/oa#describing</seealso>
    let describing = Prefixed_Name(oa, "describing") |> PrefixedName
    /// <summary>
    ///   <para>oa:end</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The end property is used to convey the 0-based index of the end position of a range of content.</para>
    /// labels<para>end</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#end">http://www.w3.org/ns/oa#end</seealso>
    let end_ = Prefixed_Name(oa, "end") |> PrefixedName
    /// <summary>
    ///   <para>oa:hasBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object of the relationship is a resource that is a body of the Annotation.</para>
    /// labels<para>hasBody</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#hasBody">http://www.w3.org/ns/oa#hasBody</seealso>
    let hasBody = Prefixed_Name(oa, "hasBody") |> PrefixedName
    /// <summary>
    ///   <para>oa:hasScope</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The scope or context in which the resource is used within the Annotation.</para>
    /// labels<para>hasScope</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#hasScope">http://www.w3.org/ns/oa#hasScope</seealso>
    let hasScope = Prefixed_Name(oa, "hasScope") |> PrefixedName
    /// <summary>
    ///   <para>oa:hasEndSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relationship between a RangeSelector and the Selector that describes the end position of the range. </para>
    /// labels<para>hasEndSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#hasEndSelector">http://www.w3.org/ns/oa#hasEndSelector</seealso>
    let hasEndSelector = Prefixed_Name(oa, "hasEndSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:hasSource</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The resource that the ResourceSelection, or its subclass SpecificResource, is refined from, or more specific than. Please note that the domain ( oa:ResourceSelection ) is not used directly in the Web Annotation model.</para>
    /// labels<para>hasSource</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#hasSource">http://www.w3.org/ns/oa#hasSource</seealso>
    let hasSource = Prefixed_Name(oa, "hasSource") |> PrefixedName
    /// <summary>
    ///   <para>oa:hasTarget</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relationship between an Annotation and its Target.</para>
    /// labels<para>hasTarget</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#hasTarget">http://www.w3.org/ns/oa#hasTarget</seealso>
    let hasTarget = Prefixed_Name(oa, "hasTarget") |> PrefixedName
    /// <summary>
    ///   <para>oa:identifying</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to assign an identity to the Target or identify what is being depicted or described in the Target.</para>
    /// labels<para>identifying</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#identifying">http://www.w3.org/ns/oa#identifying</seealso>
    let identifying = Prefixed_Name(oa, "identifying") |> PrefixedName
    /// <summary>
    ///   <para>oa:ltrDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Direction</para>
    ///   <para>The direction of text that is read from left to right.</para>
    /// labels<para>ltrDirection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#ltrDirection">http://www.w3.org/ns/oa#ltrDirection</seealso>
    let ltrDirection = Prefixed_Name(oa, "ltrDirection") |> PrefixedName
    /// <summary>
    ///   <para>oa:prefix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object of the property is a snippet of content that occurs immediately before the content which is being selected by the Selector.</para>
    /// labels<para>prefix</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#prefix">http://www.w3.org/ns/oa#prefix</seealso>
    let prefix = Prefixed_Name(oa, "prefix") |> PrefixedName
    /// <summary>
    ///   <para>oa:refinedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relationship between a Selector and another Selector or a State and a Selector or State that should be applied to the results of the first to refine the processing of the source resource. </para>
    /// labels<para>refinedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#refinedBy">http://www.w3.org/ns/oa#refinedBy</seealso>
    let refinedBy = Prefixed_Name(oa, "refinedBy") |> PrefixedName
    /// <summary>
    ///   <para>oa:sourceDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The timestamp at which the Source resource should be interpreted as being applicable to the Annotation.</para>
    /// labels<para>sourceDate</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#sourceDate">http://www.w3.org/ns/oa#sourceDate</seealso>
    let sourceDate = Prefixed_Name(oa, "sourceDate") |> PrefixedName
    /// <summary>
    ///   <para>oa:hasSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The object of the relationship is a Selector that describes the segment or region of interest within the source resource.  Please note that the domain ( oa:ResourceSelection ) is not used directly in the Web Annotation model.</para>
    /// labels<para>hasSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#hasSelector">http://www.w3.org/ns/oa#hasSelector</seealso>
    let hasSelector = Prefixed_Name(oa, "hasSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:hasStartSelector</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relationship between a RangeSelector and the Selector that describes the start position of the range. </para>
    /// labels<para>hasStartSelector</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#hasStartSelector">http://www.w3.org/ns/oa#hasStartSelector</seealso>
    let hasStartSelector = Prefixed_Name(oa, "hasStartSelector") |> PrefixedName
    /// <summary>
    ///   <para>oa:hasState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relationship between the ResourceSelection, or its subclass SpecificResource, and a State resource. Please note that the domain ( oa:ResourceSelection ) is not used directly in the Web Annotation model.</para>
    /// labels<para>hasState</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#hasState">http://www.w3.org/ns/oa#hasState</seealso>
    let hasState = Prefixed_Name(oa, "hasState") |> PrefixedName
    /// <summary>
    ///   <para>oa:highlighting</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to highlight the Target resource or segment of it.</para>
    /// labels<para>highlighting</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#highlighting">http://www.w3.org/ns/oa#highlighting</seealso>
    let highlighting = Prefixed_Name(oa, "highlighting") |> PrefixedName
    /// <summary>
    ///   <para>oa:linking</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to link to a resource related to the Target.</para>
    /// labels<para>linking</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#linking">http://www.w3.org/ns/oa#linking</seealso>
    let linking = Prefixed_Name(oa, "linking") |> PrefixedName
    /// <summary>
    ///   <para>oa:motivatedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The relationship between an Annotation and a Motivation that describes the reason for the Annotation's creation.</para>
    /// labels<para>motivatedBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#motivatedBy">http://www.w3.org/ns/oa#motivatedBy</seealso>
    let motivatedBy = Prefixed_Name(oa, "motivatedBy") |> PrefixedName
    /// <summary>
    ///   <para>oa:questioning</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to ask a question about the Target.</para>
    /// labels<para>questioning</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#questioning">http://www.w3.org/ns/oa#questioning</seealso>
    let questioning = Prefixed_Name(oa, "questioning") |> PrefixedName
    /// <summary>
    ///   <para>oa:renderedVia</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A system that was used by the application that created the Annotation to render the resource.</para>
    /// labels<para>renderedVia</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#renderedVia">http://www.w3.org/ns/oa#renderedVia</seealso>
    let renderedVia = Prefixed_Name(oa, "renderedVia") |> PrefixedName
    /// <summary>
    ///   <para>oa:rtlDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Direction</para>
    ///   <para>The direction of text that is read from right to left.</para>
    /// labels<para>rtlDirection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#rtlDirection">http://www.w3.org/ns/oa#rtlDirection</seealso>
    let rtlDirection = Prefixed_Name(oa, "rtlDirection") |> PrefixedName
    /// <summary>
    ///   <para>oa:sourceDateStart</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The start timestamp of the interval over which the Source resource should be interpreted as being applicable to the Annotation.</para>
    /// labels<para>sourceDateStart</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#sourceDateStart">http://www.w3.org/ns/oa#sourceDateStart</seealso>
    let sourceDateStart = Prefixed_Name(oa, "sourceDateStart") |> PrefixedName
    /// <summary>
    ///   <para>oa:start</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The start position in a 0-based index at which a range of content is selected from the data in the source resource.</para>
    /// labels<para>start</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#start">http://www.w3.org/ns/oa#start</seealso>
    let start = Prefixed_Name(oa, "start") |> PrefixedName
    /// <summary>
    ///   <para>oa:styleClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The name of the class used in the CSS description referenced from the Annotation that should be applied to the Specific Resource.</para>
    /// labels<para>styleClass</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#styleClass">http://www.w3.org/ns/oa#styleClass</seealso>
    let styleClass = Prefixed_Name(oa, "styleClass") |> PrefixedName
    /// <summary>
    ///   <para>oa:suffix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The snippet of text that occurs immediately after the text which is being selected.</para>
    /// labels<para>suffix</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#suffix">http://www.w3.org/ns/oa#suffix</seealso>
    let suffix = Prefixed_Name(oa, "suffix") |> PrefixedName
    /// <summary>
    ///   <para>oa:tagging</para>
    /// </summary>
    /// <remarks>
    ///   <para>oa:Motivation</para>
    ///   <para>The motivation for when the user intends to associate a tag with the Target.</para>
    /// labels<para>tagging</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#tagging">http://www.w3.org/ns/oa#tagging</seealso>
    let tagging = Prefixed_Name(oa, "tagging") |> PrefixedName
    /// <summary>
    ///   <para>oa:textDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The direction of the text of the subject resource. There MUST only be one text direction associated with any given resource.</para>
    /// labels<para>textDirection</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#textDirection">http://www.w3.org/ns/oa#textDirection</seealso>
    let textDirection = Prefixed_Name(oa, "textDirection") |> PrefixedName
    /// <summary>
    ///   <para>oa:sourceDateEnd</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>The end timestamp of the interval over which the Source resource should be interpreted as being applicable to the Annotation.</para>
    /// labels<para>sourceDateEnd</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#sourceDateEnd">http://www.w3.org/ns/oa#sourceDateEnd</seealso>
    let sourceDateEnd = Prefixed_Name(oa, "sourceDateEnd") |> PrefixedName
    /// <summary>
    ///   <para>oa:styledBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A reference to a Stylesheet that should be used to apply styles to the Annotation rendering.</para>
    /// labels<para>styledBy</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#styledBy">http://www.w3.org/ns/oa#styledBy</seealso>
    let styledBy = Prefixed_Name(oa, "styledBy") |> PrefixedName
    /// <summary>
    ///   <para>oa:via</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A object of the relationship is a resource from which the source resource was retrieved by the providing system.</para>
    /// labels<para>via</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#via">http://www.w3.org/ns/oa#via</seealso>
    let via = Prefixed_Name(oa, "via") |> PrefixedName
    /// <summary>
    ///   <para>oa:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>The Web Annotation ontology defines the terms of the Web Annotation vocabulary. Any changes to this document MUST be from a Working Group in the W3C that has established expertise in the area.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/ns/oa#">http://www.w3.org/ns/oa#</seealso>
    let _prefix_iri = Prefixed_Name(oa, "") |> PrefixedName
    /// <summary>
    ///   <para>oa:Style</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>A Style describes the intended styling of a resource as applied to the particular Annotation, and thus provides the information to ensure that rendering is consistent across implementations.</para>
    /// labels<para>Style</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#Style">http://www.w3.org/ns/oa#Style</seealso>
    let Style = Prefixed_Name(oa, "Style") |> PrefixedName
    /// <summary>
    ///   <para>oa:HttpRequestState</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The HttpRequestState class is used to record the HTTP request headers that a client SHOULD use to request the correct representation from the resource. </para>
    /// labels<para>HttpRequestState</para></remarks>
    /// <seealso href="http://www.w3.org/ns/oa#HttpRequestState">http://www.w3.org/ns/oa#HttpRequestState</seealso>
    let HttpRequestState = Prefixed_Name(oa, "HttpRequestState") |> PrefixedName
