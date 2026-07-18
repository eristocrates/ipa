namespace http.www.essepuntato.it._2008._12.pattern.hash

open DoxAletheia.Rdf_Vocabulary

module pattern =
    let _namespace_name = "http://www.essepuntato.it/2008/12/pattern#"
    /// <summary>
    /// This class describes container elements that must contain only homogeneous elements (but they can be repeated).
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Table"></see></summary>
    let Table = Namespaced_IRI.parse _namespace_name "Table" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#x"></see>
    /// </summary>
    let x = Namespaced_IRI.parse _namespace_name "x" |> NamespacedName
    /// <summary>
    /// The name of a particular element.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#hasName"></see></summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#s"></see>
    /// </summary>
    let s = Namespaced_IRI.parse _namespace_name "s" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#y"></see>
    /// </summary>
    let y = Namespaced_IRI.parse _namespace_name "y" |> NamespacedName
    /// <summary>
    /// This class describes elements that contain neither other elements nor textual content. Contrarily to the pattern Milestone, which was meant to describe markup elements that impact the document because of their location, the main feature of its disjoint sibling is the mere existence, independently from the position it has within the document. Meta elements convey metadata information about the document or part of it, independently of where they are. Thus, meta elements can be contained only within container elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Meta"></see></summary>
    let Meta = Namespaced_IRI.parse _namespace_name "Meta" |> NamespacedName
    /// <summary>
    /// This class describe elements that contain neither other elements nor textual content. Moreover, similarly to Inline, elements following the Milestone pattern can only be contained within block or inline elements (and consequently they also cannot be used as root elements of documents).
    ///
    /// The distinctive characteristic of the pattern Milestone is the location it assumes within the document.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Milestone"></see></summary>
    let Milestone = Namespaced_IRI.parse _namespace_name "Milestone" |> NamespacedName

    /// <summary>
    /// This class describes container elements whose content model need to begin with one or more block elements (the heading), specified through the property containsAsHeader.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#HeadedContainer"></see></summary>
    let HeadedContainer =
        Namespaced_IRI.parse _namespace_name "HeadedContainer" |> NamespacedName

    /// <summary>
    /// This class describes container elements that can only contain heterogeneous and non repeatable elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Record"></see></summary>
    let Record = Namespaced_IRI.parse _namespace_name "Record" |> NamespacedName
    /// <summary>
    /// This class organise the document content as a sequence of nestable elements and text nodes. In particular, elements following this pattern can contain text and other elements compliant with the patterns Inline, Atom, Milestones and Popup, which will be introduced in the following. Furthermore, it is a requirement that block elements are contained only by container and popup elements
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Block"></see></summary>
    let Block = Namespaced_IRI.parse _namespace_name "Block" |> NamespacedName

    /// <summary>
    /// A hierarchical-based entity contains al least two entities having different names.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#canContainHeteronymousElements"></see></summary>
    let canContainHeteronymousElements =
        Namespaced_IRI.parse _namespace_name "canContainHeteronymousElements" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#p"></see>
    /// </summary>
    let p = Namespaced_IRI.parse _namespace_name "p" |> NamespacedName
    /// <summary>
    /// The class of elements that can have textual content in their content models.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Textual"></see></summary>
    let Textual = Namespaced_IRI.parse _namespace_name "Textual" |> NamespacedName
    /// <summary>
    /// A structured element contains another generic element.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#contains"></see></summary>
    let contains = Namespaced_IRI.parse _namespace_name "contains" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#z"></see>
    /// </summary>
    let z = Namespaced_IRI.parse _namespace_name "z" |> NamespacedName
    /// <summary>
    /// This class has the same use and content model of the pattern Block, but differing primarily because a) inline elements can contain other elements compliant with the same pattern while block elements cannot, and b) inline elements must always be contained by other block or inline elements and by no other type of element.
    ///
    /// These constraints also imply that inline elements cannot be used as root elements of documents and that the class Block is disjoint with the class Inline (i.e., a markup element cannot be a block and an inline at the same time).
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Inline"></see></summary>
    let Inline = Namespaced_IRI.parse _namespace_name "Inline" |> NamespacedName

    /// <summary>
    /// A hierarchical-based entity contains al least two entities that share the same name.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#canContainHomonymousElements"></see></summary>
    let canContainHomonymousElements =
        Namespaced_IRI.parse _namespace_name "canContainHomonymousElements" |> NamespacedName

    /// <summary>
    /// This class is defined to describe literal metadata or text that is not really part of the document body, contrarily to its disjointed sibling Atom. Its main difference with Meta is that Field can contain textual content.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Field"></see></summary>
    let Field = Namespaced_IRI.parse _namespace_name "Field" |> NamespacedName
    /// <summary>
    /// A structural pattern is an atomic component of a document, that is able to capture a recurrent and well knwon structure of a document.
    ///
    /// Any entity belonging to this class is compliant with exactly one structural pattern.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Pattern"></see></summary>
    let Pattern = Namespaced_IRI.parse _namespace_name "Pattern" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#g"></see>
    /// </summary>
    let g = Namespaced_IRI.parse _namespace_name "g" |> NamespacedName
    /// <summary>
    /// This class concerns the structural organization of a document. Elements following this pattern contain no textual content and contain only elements compliant with the patterns: Meta, Field, Block and any subtype of Container. It is disjointed with the pattern Popup, although they share the same content model.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Container"></see></summary>
    let Container = Namespaced_IRI.parse _namespace_name "Container" |> NamespacedName
    /// <summary>
    ///   <see href="http://www.essepuntato.it/2008/12/pattern#t"></see>
    /// </summary>
    let t = Namespaced_IRI.parse _namespace_name "t" |> NamespacedName
    /// <summary>
    /// This class is defined to describe literal text that is part of the document body. Moreover, similarly to Inline, elements following the Atom pattern can only be contained within block or inline elements (and consequently they also cannot be used as root elements of documents). It can contain textual content and no other elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Atom"></see></summary>
    let Atom = Namespaced_IRI.parse _namespace_name "Atom" |> NamespacedName

    /// <summary>
    /// An element that is contained by another structured element.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#isContainedBy"></see></summary>
    let isContainedBy =
        Namespaced_IRI.parse _namespace_name "isContainedBy" |> NamespacedName

    /// <summary>
    /// The class of elements that can contain text nodes but no elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Flat"></see></summary>
    let Flat = Namespaced_IRI.parse _namespace_name "Flat" |> NamespacedName
    /// <summary>
    /// This class defines bucket elements that are only present within block and inline elements. Popup elements are used whenever complex structures need to be placed within content elements such as paragraphs.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Popup"></see></summary>
    let Popup = Namespaced_IRI.parse _namespace_name "Popup" |> NamespacedName
    /// <summary>
    /// The class of elements that can contain other elements and text nodes.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Mixed"></see></summary>
    let Mixed = Namespaced_IRI.parse _namespace_name "Mixed" |> NamespacedName
    /// <summary>
    /// The class of elements that can contain other elements but no text nodes.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Bucket"></see></summary>
    let Bucket = Namespaced_IRI.parse _namespace_name "Bucket" |> NamespacedName
    /// <summary>
    /// The class of elements that cannot have textual content in their content models.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#NonTextual"></see></summary>
    let NonTextual = Namespaced_IRI.parse _namespace_name "NonTextual" |> NamespacedName
    /// <summary>
    /// The class of elements that can contain other elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Structured"></see></summary>
    let Structured = Namespaced_IRI.parse _namespace_name "Structured" |> NamespacedName
    /// <summary>
    /// The class of elements that can contain neither text nodes nor elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#Marker"></see></summary>
    let Marker = Namespaced_IRI.parse _namespace_name "Marker" |> NamespacedName

    /// <summary>
    /// The class of elements that cannot contain other elements.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#NonStructured"></see></summary>
    let NonStructured =
        Namespaced_IRI.parse _namespace_name "NonStructured" |> NamespacedName

    /// <summary>
    /// A structured element contains another generic element as part of its header.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#containsAsHeader"></see></summary>
    let containsAsHeader =
        Namespaced_IRI.parse _namespace_name "containsAsHeader" |> NamespacedName

    /// <summary>
    /// An element is contained by another structured element as part of its header.
    /// <see href="http://www.essepuntato.it/2008/12/pattern#isContainedByAsHeader"></see></summary>
    let isContainedByAsHeader =
        Namespaced_IRI.parse _namespace_name "isContainedByAsHeader" |> NamespacedName
