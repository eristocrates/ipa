namespace http.www.essepuntato.it._2008._12.pattern.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module pattern =
    let _namespace_iri = Namespace_Iri pattern |> NamespaceIRI
    /// <summary>
    ///   <para>pattern:Atom</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is defined to describe literal text that is part of the document body. Moreover, similarly to Inline, elements following the Atom pattern can only be contained within block or inline elements (and consequently they also cannot be used as root elements of documents). It can contain textual content and no other elements."</para>
    /// labels<para>"atom element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Atom">http://www.essepuntato.it/2008/12/pattern#Atom</seealso>
    let Atom = Prefixed_Name(pattern, "Atom") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Block</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class organise the document content as a sequence of nestable elements and text nodes. In particular, elements following this pattern can contain text and other elements compliant with the patterns Inline, Atom, Milestones and Popup, which will be introduced in the following. Furthermore, it is a requirement that block elements are contained only by container and popup elements"</para>
    /// labels<para>"block element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Block">http://www.essepuntato.it/2008/12/pattern#Block</seealso>
    let Block = Prefixed_Name(pattern, "Block") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Bucket</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of elements that can contain other elements but no text nodes."</para>
    /// labels<para>"bucket element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Bucket">http://www.essepuntato.it/2008/12/pattern#Bucket</seealso>
    let Bucket = Prefixed_Name(pattern, "Bucket") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Container</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class concerns the structural organization of a document. Elements following this pattern contain no textual content and contain only elements compliant with the patterns: Meta, Field, Block and any subtype of Container. It is disjointed with the pattern Popup, although they share the same content model."</para>
    /// labels<para>"container element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Container">http://www.essepuntato.it/2008/12/pattern#Container</seealso>
    let Container = Prefixed_Name(pattern, "Container") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Field</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class is defined to describe literal metadata or text that is not really part of the document body, contrarily to its disjointed sibling Atom. Its main difference with Meta is that Field can contain textual content."</para>
    /// labels<para>"field element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Field">http://www.essepuntato.it/2008/12/pattern#Field</seealso>
    let Field = Prefixed_Name(pattern, "Field") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Flat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of elements that can contain text nodes but no elements."</para>
    /// labels<para>"flat element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Flat">http://www.essepuntato.it/2008/12/pattern#Flat</seealso>
    let Flat = Prefixed_Name(pattern, "Flat") |> PrefixedName
    /// <summary>
    ///   <para>pattern:HeadedContainer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes container elements whose content model need to begin with one or more block elements (the heading), specified through the property containsAsHeader."</para>
    /// labels<para>"headed-container element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#HeadedContainer">http://www.essepuntato.it/2008/12/pattern#HeadedContainer</seealso>
    let HeadedContainer = Prefixed_Name(pattern, "HeadedContainer") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Inline</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class has the same use and content model of the pattern Block, but differing primarily because a) inline elements can contain other elements compliant with the same pattern while block elements cannot, and b) inline elements must always be contained by other block or inline elements and by no other type of element.
    ///
    /// These constraints also imply that inline elements cannot be used as root elements of documents and that the class Block is disjoint with the class Inline (i.e., a markup element cannot be a block and an inline at the same time)."</para>
    /// labels<para>"inline element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Inline">http://www.essepuntato.it/2008/12/pattern#Inline</seealso>
    let Inline = Prefixed_Name(pattern, "Inline") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Marker</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of elements that can contain neither text nodes nor elements."</para>
    /// labels<para>"marker element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Marker">http://www.essepuntato.it/2008/12/pattern#Marker</seealso>
    let Marker = Prefixed_Name(pattern, "Marker") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Meta</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes elements that contain neither other elements nor textual content. Contrarily to the pattern Milestone, which was meant to describe markup elements that impact the document because of their location, the main feature of its disjoint sibling is the mere existence, independently from the position it has within the document. Meta elements convey metadata information about the document or part of it, independently of where they are. Thus, meta elements can be contained only within container elements."</para>
    /// labels<para>"meta element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Meta">http://www.essepuntato.it/2008/12/pattern#Meta</seealso>
    let Meta = Prefixed_Name(pattern, "Meta") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Milestone</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describe elements that contain neither other elements nor textual content. Moreover, similarly to Inline, elements following the Milestone pattern can only be contained within block or inline elements (and consequently they also cannot be used as root elements of documents).
    ///
    /// The distinctive characteristic of the pattern Milestone is the location it assumes within the document."</para>
    /// labels<para>"milestone element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Milestone">http://www.essepuntato.it/2008/12/pattern#Milestone</seealso>
    let Milestone = Prefixed_Name(pattern, "Milestone") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Mixed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of elements that can contain other elements and text nodes."</para>
    /// labels<para>"mixed element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Mixed">http://www.essepuntato.it/2008/12/pattern#Mixed</seealso>
    let Mixed = Prefixed_Name(pattern, "Mixed") |> PrefixedName
    /// <summary>
    ///   <para>pattern:NonStructured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of elements that cannot contain other elements."</para>
    /// labels<para>"non-structured element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#NonStructured">http://www.essepuntato.it/2008/12/pattern#NonStructured</seealso>
    let NonStructured = Prefixed_Name(pattern, "NonStructured") |> PrefixedName
    /// <summary>
    ///   <para>pattern:NonTextual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of elements that cannot have textual content in their content models."</para>
    /// labels<para>"non-textual element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#NonTextual">http://www.essepuntato.it/2008/12/pattern#NonTextual</seealso>
    let NonTextual = Prefixed_Name(pattern, "NonTextual") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Pattern</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A structural pattern is an atomic component of a document, that is able to capture a recurrent and well knwon structure of a document.
    ///
    /// Any entity belonging to this class is compliant with exactly one structural pattern."</para>
    /// labels<para>"pattern-based element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Pattern">http://www.essepuntato.it/2008/12/pattern#Pattern</seealso>
    let Pattern = Prefixed_Name(pattern, "Pattern") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Popup</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class defines bucket elements that are only present within block and inline elements. Popup elements are used whenever complex structures need to be placed within content elements such as paragraphs. "</para>
    /// labels<para>"popup element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Popup">http://www.essepuntato.it/2008/12/pattern#Popup</seealso>
    let Popup = Prefixed_Name(pattern, "Popup") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Record</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes container elements that can only contain heterogeneous and non repeatable elements."</para>
    /// labels<para>"record element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Record">http://www.essepuntato.it/2008/12/pattern#Record</seealso>
    let Record = Prefixed_Name(pattern, "Record") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Structured</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of elements that can contain other elements."</para>
    /// labels<para>"structured element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Structured">http://www.essepuntato.it/2008/12/pattern#Structured</seealso>
    let Structured = Prefixed_Name(pattern, "Structured") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Table</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"This class describes container elements that must contain only homogeneous elements (but they can be repeated)."</para>
    /// labels<para>"table element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Table">http://www.essepuntato.it/2008/12/pattern#Table</seealso>
    let Table = Prefixed_Name(pattern, "Table") |> PrefixedName
    /// <summary>
    ///   <para>pattern:Textual</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"The class of elements that can have textual content in their content models."</para>
    /// labels<para>"textual element"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#Textual">http://www.essepuntato.it/2008/12/pattern#Textual</seealso>
    let Textual = Prefixed_Name(pattern, "Textual") |> PrefixedName

    /// <summary>
    ///   <para>pattern:canContainHeteronymousElements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>"A hierarchical-based entity contains al least two entities having different names."</para>
    /// labels<para>"can contain heteronymous elements"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#canContainHeteronymousElements">http://www.essepuntato.it/2008/12/pattern#canContainHeteronymousElements</seealso>
    let canContainHeteronymousElements =
        Prefixed_Name(pattern, "canContainHeteronymousElements") |> PrefixedName

    /// <summary>
    ///   <para>pattern:canContainHomonymousElements</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"A hierarchical-based entity contains al least two entities that share the same name."</para>
    /// labels<para>"can contain homonymous elements"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#canContainHomonymousElements">http://www.essepuntato.it/2008/12/pattern#canContainHomonymousElements</seealso>
    let canContainHomonymousElements =
        Prefixed_Name(pattern, "canContainHomonymousElements") |> PrefixedName

    /// <summary>
    ///   <para>pattern:contains</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"A structured element contains another generic element."</para>
    /// labels<para>"contains"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#contains">http://www.essepuntato.it/2008/12/pattern#contains</seealso>
    let contains = Prefixed_Name(pattern, "contains") |> PrefixedName
    /// <summary>
    ///   <para>pattern:containsAsHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"A structured element contains another generic element as part of its header."</para>
    /// labels<para>"contains as header"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#containsAsHeader">http://www.essepuntato.it/2008/12/pattern#containsAsHeader</seealso>
    let containsAsHeader = Prefixed_Name(pattern, "containsAsHeader") |> PrefixedName
    /// <summary>
    ///   <para>pattern:g</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#g">http://www.essepuntato.it/2008/12/pattern#g</seealso>
    let g = Prefixed_Name(pattern, "g") |> PrefixedName
    /// <summary>
    ///   <para>pattern:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"The name of a particular element."</para>
    /// labels<para>"has name"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#hasName">http://www.essepuntato.it/2008/12/pattern#hasName</seealso>
    let hasName = Prefixed_Name(pattern, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>pattern:isContainedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"An element that is contained by another structured element."</para>
    /// labels<para>"is contained by"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#isContainedBy">http://www.essepuntato.it/2008/12/pattern#isContainedBy</seealso>
    let isContainedBy = Prefixed_Name(pattern, "isContainedBy") |> PrefixedName

    /// <summary>
    ///   <para>pattern:isContainedByAsHeader</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>"An element is contained by another structured element as part of its header."</para>
    /// labels<para>"is contained by as header"</para></remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#isContainedByAsHeader">http://www.essepuntato.it/2008/12/pattern#isContainedByAsHeader</seealso>
    let isContainedByAsHeader =
        Prefixed_Name(pattern, "isContainedByAsHeader") |> PrefixedName

    /// <summary>
    ///   <para>pattern:p</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#p">http://www.essepuntato.it/2008/12/pattern#p</seealso>
    let p = Prefixed_Name(pattern, "p") |> PrefixedName
    /// <summary>
    ///   <para>pattern:s</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#s">http://www.essepuntato.it/2008/12/pattern#s</seealso>
    let s = Prefixed_Name(pattern, "s") |> PrefixedName
    /// <summary>
    ///   <para>pattern:t</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#t">http://www.essepuntato.it/2008/12/pattern#t</seealso>
    let t = Prefixed_Name(pattern, "t") |> PrefixedName
    /// <summary>
    ///   <para>pattern:x</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#x">http://www.essepuntato.it/2008/12/pattern#x</seealso>
    let x = Prefixed_Name(pattern, "x") |> PrefixedName
    /// <summary>
    ///   <para>pattern:y</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#y">http://www.essepuntato.it/2008/12/pattern#y</seealso>
    let y = Prefixed_Name(pattern, "y") |> PrefixedName
    /// <summary>
    ///   <para>pattern:z</para>
    /// </summary>
    /// <remarks>
    ///   <para>swrl:Variable</para>
    /// </remarks>
    /// <seealso href="http://www.essepuntato.it/2008/12/pattern#z">http://www.essepuntato.it/2008/12/pattern#z</seealso>
    let z = Prefixed_Name(pattern, "z") |> PrefixedName
