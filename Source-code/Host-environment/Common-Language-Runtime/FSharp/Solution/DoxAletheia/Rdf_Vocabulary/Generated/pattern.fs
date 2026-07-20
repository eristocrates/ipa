namespace http.www.essepuntato.it._2008._12.pattern.hash

open DoxAletheia

module pattern =
    let _namespace_name = "http://www.essepuntato.it/2008/12/pattern#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// This class describes container elements that must contain only homogeneous elements (but they can be repeated).
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Table"></see></summary>
    let Table = _prefix "Table"
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#x"></see>
    /// </summary>
    let x = _prefix "x"
    /// <summary>
    /// The name of a particular element.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#hasName"></see></summary>
    let hasName = _prefix "hasName"
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#s"></see>
    /// </summary>
    let s = _prefix "s"
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#y"></see>
    /// </summary>
    let y = _prefix "y"
    /// <summary>
    /// This class describes elements that contain neither other elements nor textual content. Contrarily to the pattern Milestone, which was meant to describe markup elements that impact the document because of their location, the main feature of its disjoint sibling is the mere existence, independently from the position it has within the document. Meta elements convey metadata information about the document or part of it, independently of where they are. Thus, meta elements can be contained only within container elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Meta"></see></summary>
    let Meta = _prefix "Meta"
    /// <summary>
    /// This class describe elements that contain neither other elements nor textual content. Moreover, similarly to Inline, elements following the Milestone pattern can only be contained within block or inline elements (and consequently they also cannot be used as root elements of documents).
    ///
    /// The distinctive characteristic of the pattern Milestone is the location it assumes within the document.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Milestone"></see></summary>
    let Milestone = _prefix "Milestone"
    /// <summary>
    /// This class describes container elements whose content model need to begin with one or more block elements (the heading), specified through the property containsAsHeader.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#HeadedContainer"></see></summary>
    let HeadedContainer = _prefix "HeadedContainer"
    /// <summary>
    /// This class describes container elements that can only contain heterogeneous and non repeatable elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Record"></see></summary>
    let Record = _prefix "Record"
    /// <summary>
    /// This class organise the document content as a sequence of nestable elements and text nodes. In particular, elements following this pattern can contain text and other elements compliant with the patterns Inline, Atom, Milestones and Popup, which will be introduced in the following. Furthermore, it is a requirement that block elements are contained only by container and popup elements
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Block"></see></summary>
    let Block = _prefix "Block"
    /// <summary>
    /// A hierarchical-based entity contains al least two entities having different names.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#canContainHeteronymousElements"></see></summary>
    let canContainHeteronymousElements = _prefix "canContainHeteronymousElements"
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#p"></see>
    /// </summary>
    let p = _prefix "p"
    /// <summary>
    /// The class of elements that can have textual content in their content models.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Textual"></see></summary>
    let Textual = _prefix "Textual"
    /// <summary>
    /// A structured element contains another generic element.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#contains"></see></summary>
    let contains = _prefix "contains"
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#z"></see>
    /// </summary>
    let z = _prefix "z"
    /// <summary>
    /// This class has the same use and content model of the pattern Block, but differing primarily because a) inline elements can contain other elements compliant with the same pattern while block elements cannot, and b) inline elements must always be contained by other block or inline elements and by no other type of element.
    ///
    /// These constraints also imply that inline elements cannot be used as root elements of documents and that the class Block is disjoint with the class Inline (i.e., a markup element cannot be a block and an inline at the same time).
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Inline"></see></summary>
    let Inline = _prefix "Inline"
    /// <summary>
    /// A hierarchical-based entity contains al least two entities that share the same name.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#canContainHomonymousElements"></see></summary>
    let canContainHomonymousElements = _prefix "canContainHomonymousElements"
    /// <summary>
    /// This class is defined to describe literal metadata or text that is not really part of the document body, contrarily to its disjointed sibling Atom. Its main difference with Meta is that Field can contain textual content.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Field"></see></summary>
    let Field = _prefix "Field"
    /// <summary>
    /// A structural pattern is an atomic component of a document, that is able to capture a recurrent and well knwon structure of a document.
    ///
    /// Any entity belonging to this class is compliant with exactly one structural pattern.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Pattern"></see></summary>
    let Pattern = _prefix "Pattern"
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#g"></see>
    /// </summary>
    let g = _prefix "g"
    /// <summary>
    /// This class concerns the structural organization of a document. Elements following this pattern contain no textual content and contain only elements compliant with the patterns: Meta, Field, Block and any subtype of Container. It is disjointed with the pattern Popup, although they share the same content model.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Container"></see></summary>
    let Container = _prefix "Container"
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#t"></see>
    /// </summary>
    let t = _prefix "t"
    /// <summary>
    /// This class is defined to describe literal text that is part of the document body. Moreover, similarly to Inline, elements following the Atom pattern can only be contained within block or inline elements (and consequently they also cannot be used as root elements of documents). It can contain textual content and no other elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Atom"></see></summary>
    let Atom = _prefix "Atom"
    /// <summary>
    /// An element that is contained by another structured element.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#isContainedBy"></see></summary>
    let isContainedBy = _prefix "isContainedBy"
    /// <summary>
    /// The class of elements that can contain text nodes but no elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Flat"></see></summary>
    let Flat = _prefix "Flat"
    /// <summary>
    /// This class defines bucket elements that are only present within block and inline elements. Popup elements are used whenever complex structures need to be placed within content elements such as paragraphs.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Popup"></see></summary>
    let Popup = _prefix "Popup"
    /// <summary>
    /// The class of elements that can contain other elements and text nodes.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Mixed"></see></summary>
    let Mixed = _prefix "Mixed"
    /// <summary>
    /// The class of elements that can contain other elements but no text nodes.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Bucket"></see></summary>
    let Bucket = _prefix "Bucket"
    /// <summary>
    /// The class of elements that cannot have textual content in their content models.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#NonTextual"></see></summary>
    let NonTextual = _prefix "NonTextual"
    /// <summary>
    /// The class of elements that can contain other elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Structured"></see></summary>
    let Structured = _prefix "Structured"
    /// <summary>
    /// The class of elements that can contain neither text nodes nor elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Marker"></see></summary>
    let Marker = _prefix "Marker"
    /// <summary>
    /// The class of elements that cannot contain other elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#NonStructured"></see></summary>
    let NonStructured = _prefix "NonStructured"
    /// <summary>
    /// A structured element contains another generic element as part of its header.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#containsAsHeader"></see></summary>
    let containsAsHeader = _prefix "containsAsHeader"
    /// <summary>
    /// An element is contained by another structured element as part of its header.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#isContainedByAsHeader"></see></summary>
    let isContainedByAsHeader = _prefix "isContainedByAsHeader"
