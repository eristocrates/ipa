#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module pattern =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.essepuntato.it/2008/12/pattern#" "pattern"

    /// <summary>
    ///   <para>rdfs:label : atom element</para>
    ///   <para>rdfs:comment : This class is defined to describe literal text that is part of the document body. Moreover, similarly to Inline, elements following the Atom pattern can only be contained within block or inline elements (and consequently they also cannot be used as root elements of documents). It can contain textual content and no other elements.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Atom">pattern:Atom</a>
    /// </summary>
    let Atom = _prefixId.prefix "Atom"
    /// <summary>
    ///   <para>rdfs:label : block element</para>
    ///   <para>rdfs:comment : This class organise the document content as a sequence of nestable elements and text nodes. In particular, elements following this pattern can contain text and other elements compliant with the patterns Inline, Atom, Milestones and Popup, which will be introduced in the following. Furthermore, it is a requirement that block elements are contained only by container and popup elements</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Block">pattern:Block</a>
    /// </summary>
    let Block = _prefixId.prefix "Block"
    /// <summary>
    ///   <para>rdfs:label : bucket element</para>
    ///   <para>rdfs:comment : The class of elements that can contain other elements but no text nodes.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Bucket">pattern:Bucket</a>
    /// </summary>
    let Bucket = _prefixId.prefix "Bucket"
    /// <summary>
    ///   <para>rdfs:label : container element</para>
    ///   <para>rdfs:comment : This class concerns the structural organization of a document. Elements following this pattern contain no textual content and contain only elements compliant with the patterns: Meta, Field, Block and any subtype of Container. It is disjointed with the pattern Popup, although they share the same content model.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Container">pattern:Container</a>
    /// </summary>
    let Container = _prefixId.prefix "Container"
    /// <summary>
    ///   <para>rdfs:label : field element</para>
    ///   <para>rdfs:comment : This class is defined to describe literal metadata or text that is not really part of the document body, contrarily to its disjointed sibling Atom. Its main difference with Meta is that Field can contain textual content.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Field">pattern:Field</a>
    /// </summary>
    let Field = _prefixId.prefix "Field"
    /// <summary>
    ///   <para>rdfs:label : flat element</para>
    ///   <para>rdfs:comment : The class of elements that can contain text nodes but no elements.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Flat">pattern:Flat</a>
    /// </summary>
    let Flat = _prefixId.prefix "Flat"
    /// <summary>
    ///   <para>rdfs:label : headed-container element</para>
    ///   <para>rdfs:comment : This class describes container elements whose content model need to begin with one or more block elements (the heading), specified through the property containsAsHeader.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#HeadedContainer">pattern:HeadedContainer</a>
    /// </summary>
    let HeadedContainer = _prefixId.prefix "HeadedContainer"
    /// <summary>
    ///   <para>rdfs:label : inline element</para>
    ///   <para>rdfs:comment : This class has the same use and content model of the pattern Block, but differing primarily because a) inline elements can contain other elements compliant with the same pattern while block elements cannot, and b) inline elements must always be contained by other block or inline elements and by no other type of element.
    ///
    /// These constraints also imply that inline elements cannot be used as root elements of documents and that the class Block is disjoint with the class Inline (i.e., a markup element cannot be a block and an inline at the same time).</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Inline">pattern:Inline</a>
    /// </summary>
    let Inline = _prefixId.prefix "Inline"
    /// <summary>
    ///   <para>rdfs:label : marker element</para>
    ///   <para>rdfs:comment : The class of elements that can contain neither text nodes nor elements.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Marker">pattern:Marker</a>
    /// </summary>
    let Marker = _prefixId.prefix "Marker"
    /// <summary>
    ///   <para>rdfs:label : meta element</para>
    ///   <para>rdfs:comment : This class describes elements that contain neither other elements nor textual content. Contrarily to the pattern Milestone, which was meant to describe markup elements that impact the document because of their location, the main feature of its disjoint sibling is the mere existence, independently from the position it has within the document. Meta elements convey metadata information about the document or part of it, independently of where they are. Thus, meta elements can be contained only within container elements.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Meta">pattern:Meta</a>
    /// </summary>
    let Meta = _prefixId.prefix "Meta"
    /// <summary>
    ///   <para>rdfs:label : milestone element</para>
    ///   <para>rdfs:comment : This class describe elements that contain neither other elements nor textual content. Moreover, similarly to Inline, elements following the Milestone pattern can only be contained within block or inline elements (and consequently they also cannot be used as root elements of documents).
    ///
    /// The distinctive characteristic of the pattern Milestone is the location it assumes within the document.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Milestone">pattern:Milestone</a>
    /// </summary>
    let Milestone = _prefixId.prefix "Milestone"
    /// <summary>
    ///   <para>rdfs:label : mixed element</para>
    ///   <para>rdfs:comment : The class of elements that can contain other elements and text nodes.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Mixed">pattern:Mixed</a>
    /// </summary>
    let Mixed = _prefixId.prefix "Mixed"
    /// <summary>
    ///   <para>rdfs:label : non-structured element</para>
    ///   <para>rdfs:comment : The class of elements that cannot contain other elements.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#NonStructured">pattern:NonStructured</a>
    /// </summary>
    let NonStructured = _prefixId.prefix "NonStructured"
    /// <summary>
    ///   <para>rdfs:label : non-textual element</para>
    ///   <para>rdfs:comment : The class of elements that cannot have textual content in their content models.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#NonTextual">pattern:NonTextual</a>
    /// </summary>
    let NonTextual = _prefixId.prefix "NonTextual"
    /// <summary>
    ///   <para>rdfs:label : pattern-based element</para>
    ///   <para>rdfs:comment : A structural pattern is an atomic component of a document, that is able to capture a recurrent and well knwon structure of a document.
    ///
    /// Any entity belonging to this class is compliant with exactly one structural pattern.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Pattern">pattern:Pattern</a>
    /// </summary>
    let Pattern = _prefixId.prefix "Pattern"
    /// <summary>
    ///   <para>rdfs:label : popup element</para>
    ///   <para>rdfs:comment : This class defines bucket elements that are only present within block and inline elements. Popup elements are used whenever complex structures need to be placed within content elements such as paragraphs. </para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Popup">pattern:Popup</a>
    /// </summary>
    let Popup = _prefixId.prefix "Popup"
    /// <summary>
    ///   <para>rdfs:label : record element</para>
    ///   <para>rdfs:comment : This class describes container elements that can only contain heterogeneous and non repeatable elements.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Record">pattern:Record</a>
    /// </summary>
    let Record = _prefixId.prefix "Record"
    /// <summary>
    ///   <para>rdfs:label : structured element</para>
    ///   <para>rdfs:comment : The class of elements that can contain other elements.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Structured">pattern:Structured</a>
    /// </summary>
    let Structured = _prefixId.prefix "Structured"
    /// <summary>
    ///   <para>rdfs:label : table element</para>
    ///   <para>rdfs:comment : This class describes container elements that must contain only homogeneous elements (but they can be repeated).</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Table">pattern:Table</a>
    /// </summary>
    let Table = _prefixId.prefix "Table"
    /// <summary>
    ///   <para>rdfs:label : textual element</para>
    ///   <para>rdfs:comment : The class of elements that can have textual content in their content models.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#Textual">pattern:Textual</a>
    /// </summary>
    let Textual = _prefixId.prefix "Textual"

    /// <summary>
    ///   <para>rdfs:label : can contain heteronymous elements</para>
    ///   <para>rdfs:comment : A hierarchical-based entity contains al least two entities having different names.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#canContainHeteronymousElements">pattern:canContainHeteronymousElements</a>
    /// </summary>
    let canContainHeteronymousElements =
        _prefixId.prefix "canContainHeteronymousElements"

    /// <summary>
    ///   <para>rdfs:label : can contain homonymous elements</para>
    ///   <para>rdfs:comment : A hierarchical-based entity contains al least two entities that share the same name.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#canContainHomonymousElements">pattern:canContainHomonymousElements</a>
    /// </summary>
    let canContainHomonymousElements = _prefixId.prefix "canContainHomonymousElements"
    /// <summary>
    ///   <para>rdfs:label : contains</para>
    ///   <para>rdfs:comment : A structured element contains another generic element.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#contains">pattern:contains</a>
    /// </summary>
    let contains = _prefixId.prefix "contains"
    /// <summary>
    ///   <para>rdfs:label : contains as header</para>
    ///   <para>rdfs:comment : A structured element contains another generic element as part of its header.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#containsAsHeader">pattern:containsAsHeader</a>
    /// </summary>
    let containsAsHeader = _prefixId.prefix "containsAsHeader"
    let g = _prefixId.prefix "g"
    /// <summary>
    ///   <para>rdfs:label : has name</para>
    ///   <para>rdfs:comment : The name of a particular element.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#hasName">pattern:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:label : is contained by</para>
    ///   <para>rdfs:comment : An element that is contained by another structured element.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#isContainedBy">pattern:isContainedBy</a>
    /// </summary>
    let isContainedBy = _prefixId.prefix "isContainedBy"
    /// <summary>
    ///   <para>rdfs:label : is contained by as header</para>
    ///   <para>rdfs:comment : An element is contained by another structured element as part of its header.</para>
    ///   <a href="http://www.essepuntato.it/2008/12/pattern#isContainedByAsHeader">pattern:isContainedByAsHeader</a>
    /// </summary>
    let isContainedByAsHeader = _prefixId.prefix "isContainedByAsHeader"
    let p = _prefixId.prefix "p"
    let s = _prefixId.prefix "s"
    let t = _prefixId.prefix "t"
    let x = _prefixId.prefix "x"
    let y = _prefixId.prefix "y"
    let z = _prefixId.prefix "z"
