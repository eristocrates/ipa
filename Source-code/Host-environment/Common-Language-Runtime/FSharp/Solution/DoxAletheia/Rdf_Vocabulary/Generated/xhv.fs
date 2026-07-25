namespace http.www.w3.org._1999.xhtml.vocab.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module xhv =
    let _namespace_iri = Namespace_Iri xhv |> NamespaceIRI
    /// <summary>
    ///   <para>xhv:stylesheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>stylesheet refers to a resource
    ///       serving as a stylesheet for a resource. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#stylesheet">http://www.w3.org/1999/xhtml/vocab#stylesheet</seealso>
    let stylesheet = Prefixed_Name(xhv, "stylesheet") |> PrefixedName
    /// <summary>
    ///   <para>xhv:appendix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>appendix refers to a resource serving
    ///       as an appendix in a collection. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#appendix">http://www.w3.org/1999/xhtml/vocab#appendix</seealso>
    let appendix = Prefixed_Name(xhv, "appendix") |> PrefixedName
    /// <summary>
    ///   <para>xhv:checkbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A checkable
    ///       input that has three possible values: true, false, or mixed.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#checkbox">http://www.w3.org/1999/xhtml/vocab#checkbox</seealso>
    let checkbox = Prefixed_Name(xhv, "checkbox") |> PrefixedName
    /// <summary>
    ///   <para>xhv:combobox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A presentation
    ///       of a select; usually similar to a textbox where users can type ahead to
    ///       select an option, or type to enter arbitrary text as a new item in the
    ///       list. Also see listbox.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#combobox">http://www.w3.org/1999/xhtml/vocab#combobox</seealso>
    let combobox = Prefixed_Name(xhv, "combobox") |> PrefixedName
    /// <summary>
    ///   <para>xhv:grid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A grid is
    ///       an interactive control which contains cells of tabular data arranged in
    ///       rows and columns, like a table.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#grid">http://www.w3.org/1999/xhtml/vocab#grid</seealso>
    let grid = Prefixed_Name(xhv, "grid") |> PrefixedName
    /// <summary>
    ///   <para>xhv:help</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>help refers to a resource offering
    ///       help. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#help">http://www.w3.org/1999/xhtml/vocab#help</seealso>
    let help = Prefixed_Name(xhv, "help") |> PrefixedName
    /// <summary>
    ///   <para>xhv:img</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A container
    ///       for a collection of elements that form an image.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#img">http://www.w3.org/1999/xhtml/vocab#img</seealso>
    let img = Prefixed_Name(xhv, "img") |> PrefixedName
    /// <summary>
    ///   <para>xhv:last</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>last refers to the last resource in a
    ///       collection of resources. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#last">http://www.w3.org/1999/xhtml/vocab#last</seealso>
    let last = Prefixed_Name(xhv, "last") |> PrefixedName
    /// <summary>
    ///   <para>xhv:link</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An interactive
    ///       reference to an internal or external resource that, when activated, causes
    ///       the user agent to navigate to that resource. Also see button.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#link">http://www.w3.org/1999/xhtml/vocab#link</seealso>
    let link = Prefixed_Name(xhv, "link") |> PrefixedName
    /// <summary>
    ///   <para>xhv:log</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A type of
    ///       live region where new information is added in meaningful order and old
    ///       information may disappear. Also see marquee.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#log">http://www.w3.org/1999/xhtml/vocab#log</seealso>
    let log = Prefixed_Name(xhv, "log") |> PrefixedName
    /// <summary>
    ///   <para>xhv:main</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>acts as the
    ///       main content of the document. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#main">http://www.w3.org/1999/xhtml/vocab#main</seealso>
    let main = Prefixed_Name(xhv, "main") |> PrefixedName
    /// <summary>
    ///   <para>xhv:menuitem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An option
    ///       in a group of choices contained by a menu or menubar.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menuitem">http://www.w3.org/1999/xhtml/vocab#menuitem</seealso>
    let menuitem = Prefixed_Name(xhv, "menuitem") |> PrefixedName
    /// <summary>
    ///   <para>xhv:menuitemcheckbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A
    ///       checkable menuitem that has three possible values: true, false, or mixed.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menuitemcheckbox">http://www.w3.org/1999/xhtml/vocab#menuitemcheckbox</seealso>
    let menuitemcheckbox = Prefixed_Name(xhv, "menuitemcheckbox") |> PrefixedName
    /// <summary>
    ///   <para>xhv:next</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>next refers to the next resource
    ///       (after the current one) in an ordered collection of resources. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#next">http://www.w3.org/1999/xhtml/vocab#next</seealso>
    let next = Prefixed_Name(xhv, "next") |> PrefixedName
    /// <summary>
    ///   <para>xhv:prev</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>prev refers to a previous resource
    ///       (before the current one) in an ordered collection of resources. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#prev">http://www.w3.org/1999/xhtml/vocab#prev</seealso>
    let prev = Prefixed_Name(xhv, "prev") |> PrefixedName
    /// <summary>
    ///   <para>xhv:region</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A large
    ///       perceivable section of a web page or document, that the author feels is
    ///       important enough to be included in a page summary or table of contents,
    ///       for example, an area of the page containing live sporting event statistics.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#region">http://www.w3.org/1999/xhtml/vocab#region</seealso>
    let region = Prefixed_Name(xhv, "region") |> PrefixedName
    /// <summary>
    ///   <para>xhv:section</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>section refers to a resource serving
    ///       as a section in a collection. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#section">http://www.w3.org/1999/xhtml/vocab#section</seealso>
    let section = Prefixed_Name(xhv, "section") |> PrefixedName
    /// <summary>
    ///   <para>xhv:spinbutton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A form
    ///       of range that expects a user to select from amongst discrete choices.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#spinbutton">http://www.w3.org/1999/xhtml/vocab#spinbutton</seealso>
    let spinbutton = Prefixed_Name(xhv, "spinbutton") |> PrefixedName
    /// <summary>
    ///   <para>xhv:start</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>start refers to the first resource in
    ///       a collection of resources. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#start">http://www.w3.org/1999/xhtml/vocab#start</seealso>
    let start = Prefixed_Name(xhv, "start") |> PrefixedName
    /// <summary>
    ///   <para>xhv:status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A container
    ///       whose content is advisory information for the user but is not important
    ///       enough to justify an alert. Also see alert.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#status">http://www.w3.org/1999/xhtml/vocab#status</seealso>
    let status = Prefixed_Name(xhv, "status") |> PrefixedName
    /// <summary>
    ///   <para>xhv:tree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A type of
    ///       list that may contain sub-level nested groups that can be collapsed and
    ///       expanded.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tree">http://www.w3.org/1999/xhtml/vocab#tree</seealso>
    let tree = Prefixed_Name(xhv, "tree") |> PrefixedName
    /// <summary>
    ///   <para>xhv:treegrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A grid
    ///       whose rows can be expanded and collapsed in the same manner as for a tree.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#treegrid">http://www.w3.org/1999/xhtml/vocab#treegrid</seealso>
    let treegrid = Prefixed_Name(xhv, "treegrid") |> PrefixedName
    /// <summary>
    ///   <para>xhv:treeitem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An option
    ///       item of a tree. This is an element within a tree that may be expanded or
    ///       collapsed if it contains a sub-level group of treeitems.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#treeitem">http://www.w3.org/1999/xhtml/vocab#treeitem</seealso>
    let treeitem = Prefixed_Name(xhv, "treeitem") |> PrefixedName
    /// <summary>
    ///   <para>xhv:alternate</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>alternate
    ///     designates alternate versions for a resource.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#alternate">http://www.w3.org/1999/xhtml/vocab#alternate</seealso>
    let alternate = Prefixed_Name(xhv, "alternate") |> PrefixedName
    /// <summary>
    ///   <para>xhv:role-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:member</para>
    ///   <para>rdf:Bag</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#role-properties">http://www.w3.org/1999/xhtml/vocab#role-properties</seealso>
    let role_properties = Prefixed_Name(xhv, "role-properties") |> PrefixedName
    /// <summary>
    ///   <para>xhv:columnheader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A
    ///       cell containing header information for a column.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#columnheader">http://www.w3.org/1999/xhtml/vocab#columnheader</seealso>
    let columnheader = Prefixed_Name(xhv, "columnheader") |> PrefixedName
    /// <summary>
    ///   <para>xhv:copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>copyright refers to a copyright
    ///       statement for the resource. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#copyright">http://www.w3.org/1999/xhtml/vocab#copyright</seealso>
    let copyright = Prefixed_Name(xhv, "copyright") |> PrefixedName
    /// <summary>
    ///   <para>xhv:dialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A dialog
    ///       is an application window that is designed to interrupt the current processing
    ///       of an application in order to prompt the user to enter information or require
    ///       a response. Also see alertdialog.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#dialog">http://www.w3.org/1999/xhtml/vocab#dialog</seealso>
    let dialog = Prefixed_Name(xhv, "dialog") |> PrefixedName
    /// <summary>
    ///   <para>xhv:first</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>first refers the first item in a
    ///       collection (see also start and top).</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#first">http://www.w3.org/1999/xhtml/vocab#first</seealso>
    let first = Prefixed_Name(xhv, "first") |> PrefixedName
    /// <summary>
    ///   <para>xhv:glossary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>glossary refers to a resource
    ///       providing a glossary of terms. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#glossary">http://www.w3.org/1999/xhtml/vocab#glossary</seealso>
    let glossary = Prefixed_Name(xhv, "glossary") |> PrefixedName
    /// <summary>
    ///   <para>xhv:gridcell</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A cell
    ///       in a grid or treegrid.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#gridcell">http://www.w3.org/1999/xhtml/vocab#gridcell</seealso>
    let gridcell = Prefixed_Name(xhv, "gridcell") |> PrefixedName
    /// <summary>
    ///   <para>xhv:heading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A heading
    ///       for a section of the page.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#heading">http://www.w3.org/1999/xhtml/vocab#heading</seealso>
    let heading = Prefixed_Name(xhv, "heading") |> PrefixedName
    /// <summary>
    ///   <para>xhv:icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>icon refers to a resource that
    ///       represents an icon. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#icon">http://www.w3.org/1999/xhtml/vocab#icon</seealso>
    let icon = Prefixed_Name(xhv, "icon") |> PrefixedName
    /// <summary>
    ///   <para>xhv:index</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>index refers to a resource providing
    ///       an index. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#index">http://www.w3.org/1999/xhtml/vocab#index</seealso>
    let index = Prefixed_Name(xhv, "index") |> PrefixedName
    /// <summary>
    ///   <para>xhv:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>license refers to a resource that
    ///       defines the associated license. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#license">http://www.w3.org/1999/xhtml/vocab#license</seealso>
    let license = Prefixed_Name(xhv, "license") |> PrefixedName
    /// <summary>
    ///   <para>xhv:list</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A group of
    ///       non-interactive list items. Also see listbox.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#list">http://www.w3.org/1999/xhtml/vocab#list</seealso>
    let list = Prefixed_Name(xhv, "list") |> PrefixedName
    /// <summary>
    ///   <para>xhv:listbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A widget
    ///       that allows the user to select one or more items from a list of choices.
    ///       Also see combobox and list.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#listbox">http://www.w3.org/1999/xhtml/vocab#listbox</seealso>
    let listbox = Prefixed_Name(xhv, "listbox") |> PrefixedName
    /// <summary>
    ///   <para>xhv:math</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Content that
    ///       represents a mathematical expression. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#math">http://www.w3.org/1999/xhtml/vocab#math</seealso>
    let math = Prefixed_Name(xhv, "math") |> PrefixedName
    /// <summary>
    ///   <para>xhv:menu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A type of
    ///       widget that offers a list of choices to the user.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menu">http://www.w3.org/1999/xhtml/vocab#menu</seealso>
    let menu = Prefixed_Name(xhv, "menu") |> PrefixedName
    /// <summary>
    ///   <para>xhv:menuitemradio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A
    ///       checkable menuitem in a group of menuitemradio roles, only one of which
    ///       can be checked at a time.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menuitemradio">http://www.w3.org/1999/xhtml/vocab#menuitemradio</seealso>
    let menuitemradio = Prefixed_Name(xhv, "menuitemradio") |> PrefixedName
    /// <summary>
    ///   <para>xhv:meta</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>meta refers to a resource that
    ///       provides metadata. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#meta">http://www.w3.org/1999/xhtml/vocab#meta</seealso>
    let meta = Prefixed_Name(xhv, "meta") |> PrefixedName
    /// <summary>
    ///   <para>xhv:p3pv1</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>p3pv1 refers to a P3P Policy Reference
    ///       File [P3P]. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#p3pv1">http://www.w3.org/1999/xhtml/vocab#p3pv1</seealso>
    let p3pv1 = Prefixed_Name(xhv, "p3pv1") |> PrefixedName
    /// <summary>
    ///   <para>xhv:progressbar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An
    ///       element that displays the progress status for tasks that take a long time.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#progressbar">http://www.w3.org/1999/xhtml/vocab#progressbar</seealso>
    let progressbar = Prefixed_Name(xhv, "progressbar") |> PrefixedName
    /// <summary>
    ///   <para>xhv:radio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A checkable
    ///       input in a group of radio roles, only one of which can be checked at a
    ///       time.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#radio">http://www.w3.org/1999/xhtml/vocab#radio</seealso>
    let radio = Prefixed_Name(xhv, "radio") |> PrefixedName
    /// <summary>
    ///   <para>xhv:rowgroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A group
    ///       containing one or more row elements in a grid.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#rowgroup">http://www.w3.org/1999/xhtml/vocab#rowgroup</seealso>
    let rowgroup = Prefixed_Name(xhv, "rowgroup") |> PrefixedName
    /// <summary>
    ///   <para>xhv:rowheader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A cell
    ///       containing header information for a row in a grid.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#rowheader">http://www.w3.org/1999/xhtml/vocab#rowheader</seealso>
    let rowheader = Prefixed_Name(xhv, "rowheader") |> PrefixedName
    /// <summary>
    ///   <para>xhv:scrollbar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A graphical
    ///       object that controls the scrolling of content within a viewing area, regardless
    ///       of whether the content is fully displayed within the viewing area.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#scrollbar">http://www.w3.org/1999/xhtml/vocab#scrollbar</seealso>
    let scrollbar = Prefixed_Name(xhv, "scrollbar") |> PrefixedName
    /// <summary>
    ///   <para>xhv:search</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>indicates
    ///       that the section provides a search facility. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#search">http://www.w3.org/1999/xhtml/vocab#search</seealso>
    let search = Prefixed_Name(xhv, "search") |> PrefixedName
    /// <summary>
    ///   <para>xhv:subsection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>subsection refers to a resource
    ///       serving as a subsection in a collection. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#subsection">http://www.w3.org/1999/xhtml/vocab#subsection</seealso>
    let subsection = Prefixed_Name(xhv, "subsection") |> PrefixedName
    /// <summary>
    ///   <para>xhv:tab</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A grouping
    ///       label providing a mechanism for selecting the tab content that is to be
    ///       rendered to the user.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tab">http://www.w3.org/1999/xhtml/vocab#tab</seealso>
    let tab = Prefixed_Name(xhv, "tab") |> PrefixedName
    /// <summary>
    ///   <para>xhv:timer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A type of
    ///       live region containing a numerical counter which indicates an amount of
    ///       elapsed time from a start point, or the time remaining until an end point.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#timer">http://www.w3.org/1999/xhtml/vocab#timer</seealso>
    let timer = Prefixed_Name(xhv, "timer") |> PrefixedName
    /// <summary>
    ///   <para>xhv:toolbar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A collection
    ///       of commonly used function buttons represented in compact visual form.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#toolbar">http://www.w3.org/1999/xhtml/vocab#toolbar</seealso>
    let toolbar = Prefixed_Name(xhv, "toolbar") |> PrefixedName
    /// <summary>
    ///   <para>xhv:tooltip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A contextual
    ///       popup that displays a description for an element.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tooltip">http://www.w3.org/1999/xhtml/vocab#tooltip</seealso>
    let tooltip = Prefixed_Name(xhv, "tooltip") |> PrefixedName
    /// <summary>
    ///   <para>xhv:top</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>top is a synonym for start. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#top">http://www.w3.org/1999/xhtml/vocab#top</seealso>
    let top = Prefixed_Name(xhv, "top") |> PrefixedName
    /// <summary>
    ///   <para>xhv:application</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A
    ///       region declared as a web application, as opposed to a web document.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#application">http://www.w3.org/1999/xhtml/vocab#application</seealso>
    let application = Prefixed_Name(xhv, "application") |> PrefixedName
    /// <summary>
    ///   <para>xhv:bookmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>bookmark refers to a bookmark - a link
    ///       to a key entry point within an extended document. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#bookmark">http://www.w3.org/1999/xhtml/vocab#bookmark</seealso>
    let bookmark = Prefixed_Name(xhv, "bookmark") |> PrefixedName
    /// <summary>
    ///   <para>xhv:chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>chapter refers to a resource serving
    ///       as a chapter in a collection. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#chapter">http://www.w3.org/1999/xhtml/vocab#chapter</seealso>
    let chapter = Prefixed_Name(xhv, "chapter") |> PrefixedName
    /// <summary>
    ///   <para>xhv:complementary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>indicates that the section supports but is
    ///       separable from the main content of resource.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#complementary">http://www.w3.org/1999/xhtml/vocab#complementary</seealso>
    let complementary = Prefixed_Name(xhv, "complementary") |> PrefixedName
    /// <summary>
    ///   <para>xhv:contents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>contents refers to a resource serving
    ///       as a table of contents. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#contents">http://www.w3.org/1999/xhtml/vocab#contents</seealso>
    let contents = Prefixed_Name(xhv, "contents") |> PrefixedName
    /// <summary>
    ///   <para>xhv:definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>indicates the definition of a term or concept.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#definition">http://www.w3.org/1999/xhtml/vocab#definition</seealso>
    let definition = Prefixed_Name(xhv, "definition") |> PrefixedName
    /// <summary>
    ///   <para>xhv:directory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A list
    ///       of references to members of a group, such as a static table of contents.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#directory">http://www.w3.org/1999/xhtml/vocab#directory</seealso>
    let directory = Prefixed_Name(xhv, "directory") |> PrefixedName
    /// <summary>
    ///   <para>xhv:group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A set of
    ///       user interface objects which are not intended to be included in a page
    ///       summary or table of contents by assistive technologies.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#group">http://www.w3.org/1999/xhtml/vocab#group</seealso>
    let group = Prefixed_Name(xhv, "group") |> PrefixedName
    /// <summary>
    ///   <para>xhv:itsRules</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>itsRules indicates that the designated
    ///       resource is an [ITS] rule set.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#itsRules">http://www.w3.org/1999/xhtml/vocab#itsRules</seealso>
    let itsRules = Prefixed_Name(xhv, "itsRules") |> PrefixedName
    /// <summary>
    ///   <para>xhv:listitem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A single
    ///       item in a list or directory.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#listitem">http://www.w3.org/1999/xhtml/vocab#listitem</seealso>
    let listitem = Prefixed_Name(xhv, "listitem") |> PrefixedName
    /// <summary>
    ///   <para>xhv:marquee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A type
    ///       of live region where non-essential information changes frequently. Also
    ///       see log.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#marquee">http://www.w3.org/1999/xhtml/vocab#marquee</seealso>
    let marquee = Prefixed_Name(xhv, "marquee") |> PrefixedName
    /// <summary>
    ///   <para>xhv:tabpanel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A container
    ///       for the resources associated with a tab, where each tab is contained in
    ///       a tablist.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tabpanel">http://www.w3.org/1999/xhtml/vocab#tabpanel</seealso>
    let tabpanel = Prefixed_Name(xhv, "tabpanel") |> PrefixedName
    /// <summary>
    ///   <para>xhv:textbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Input
    ///       that allows free-form text as its value.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#textbox">http://www.w3.org/1999/xhtml/vocab#textbox</seealso>
    let textbox = Prefixed_Name(xhv, "textbox") |> PrefixedName
    /// <summary>
    ///   <para>xhv:up</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>up refers to a resource "above" in a
    ///       hierarchically structured set. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#up">http://www.w3.org/1999/xhtml/vocab#up</seealso>
    let up = Prefixed_Name(xhv, "up") |> PrefixedName
    /// <summary>
    ///   <para>xhv:document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A region
    ///       containing related information that is declared as document content, as
    ///       opposed to a web application.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#document">http://www.w3.org/1999/xhtml/vocab#document</seealso>
    let document = Prefixed_Name(xhv, "document") |> PrefixedName
    /// <summary>
    ///   <para>xhv:form</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A landmark
    ///       region that contains a collection of items and objects that, as a whole,
    ///       combine to create a form. Also see search.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#form">http://www.w3.org/1999/xhtml/vocab#form</seealso>
    let form = Prefixed_Name(xhv, "form") |> PrefixedName
    /// <summary>
    ///   <para>xhv:navigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>indicates a collection of items suitable for
    ///       navigating the document or related documents.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#navigation">http://www.w3.org/1999/xhtml/vocab#navigation</seealso>
    let navigation = Prefixed_Name(xhv, "navigation") |> PrefixedName
    /// <summary>
    ///   <para>xhv:note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>indicates
    ///       the content is parenthetic or ancillary to the main content of the
    ///       resource. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#note">http://www.w3.org/1999/xhtml/vocab#note</seealso>
    let note = Prefixed_Name(xhv, "note") |> PrefixedName
    /// <summary>
    ///   <para>xhv:presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An
    ///       element whose implicit native role semantics will not be mapped to the
    ///       accessibility API.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#presentation">http://www.w3.org/1999/xhtml/vocab#presentation</seealso>
    let presentation = Prefixed_Name(xhv, "presentation") |> PrefixedName
    /// <summary>
    ///   <para>xhv:radiogroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A group
    ///       of radio buttons.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#radiogroup">http://www.w3.org/1999/xhtml/vocab#radiogroup</seealso>
    let radiogroup = Prefixed_Name(xhv, "radiogroup") |> PrefixedName
    /// <summary>
    ///   <para>xhv:role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>rdf:Bag</para>
    ///   <para>role indicates the purpose of the
    ///       resource. See the XHTML Role
    ///       Vocabulary for roles in this vocabulary space, and XHTMLROLE for information on extending the
    ///       collection of roles. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#role">http://www.w3.org/1999/xhtml/vocab#role</seealso>
    let role = Prefixed_Name(xhv, "role") |> PrefixedName
    /// <summary>
    ///   <para>xhv:option</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A selectable
    ///       item in a select list.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#option">http://www.w3.org/1999/xhtml/vocab#option</seealso>
    let option = Prefixed_Name(xhv, "option") |> PrefixedName
    /// <summary>
    ///   <para>xhv:row</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A row of cells
    ///       in a grid.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#row">http://www.w3.org/1999/xhtml/vocab#row</seealso>
    let row = Prefixed_Name(xhv, "row") |> PrefixedName
    /// <summary>
    ///   <para>xhv:separator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A divider
    ///       that separates and distinguishes sections of content or groups of menuitems.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#separator">http://www.w3.org/1999/xhtml/vocab#separator</seealso>
    let separator = Prefixed_Name(xhv, "separator") |> PrefixedName
    /// <summary>
    ///   <para>xhv:tablist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A list
    ///       of tab elements, which are references to tabpanel elements.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tablist">http://www.w3.org/1999/xhtml/vocab#tablist</seealso>
    let tablist = Prefixed_Name(xhv, "tablist") |> PrefixedName
    /// <summary>
    ///   <para>xhv:menubar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A presentation
    ///       of menu that usually remains visible and is usually presented horizontally.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menubar">http://www.w3.org/1999/xhtml/vocab#menubar</seealso>
    let menubar = Prefixed_Name(xhv, "menubar") |> PrefixedName
    /// <summary>
    ///   <para>xhv:slider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A user
    ///       input where the user selects a value from within a given range.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#slider">http://www.w3.org/1999/xhtml/vocab#slider</seealso>
    let slider = Prefixed_Name(xhv, "slider") |> PrefixedName
    /// <summary>
    ///   <para>xhv:alert</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A message
    ///       with important, and usually time-sensitive, information. Also see alertdialog
    ///       and status.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#alert">http://www.w3.org/1999/xhtml/vocab#alert</seealso>
    let alert = Prefixed_Name(xhv, "alert") |> PrefixedName
    /// <summary>
    ///   <para>xhv:alertdialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A
    ///       type of dialog that contains an alert message, where initial focus goes
    ///       an element within the dialog. Also see alert and dialog.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#alertdialog">http://www.w3.org/1999/xhtml/vocab#alertdialog</seealso>
    let alertdialog = Prefixed_Name(xhv, "alertdialog") |> PrefixedName
    /// <summary>
    ///   <para>xhv:relrev-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#relrev-properties">http://www.w3.org/1999/xhtml/vocab#relrev-properties</seealso>
    let relrev_properties = Prefixed_Name(xhv, "relrev-properties") |> PrefixedName
    /// <summary>
    ///   <para>xhv:article</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>A section
    ///       of a page that consists of a composition that forms an independent part
    ///       of a document, page, or site.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#article">http://www.w3.org/1999/xhtml/vocab#article</seealso>
    let article = Prefixed_Name(xhv, "article") |> PrefixedName
    /// <summary>
    ///   <para>xhv:banner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>contains
    ///       the prime heading or internal title of a page. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#banner">http://www.w3.org/1999/xhtml/vocab#banner</seealso>
    let banner = Prefixed_Name(xhv, "banner") |> PrefixedName
    /// <summary>
    ///   <para>xhv:button</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>An input
    ///       that allows for user-triggered actions when clicked or pressed. Also see
    ///       link.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#button">http://www.w3.org/1999/xhtml/vocab#button</seealso>
    let button = Prefixed_Name(xhv, "button") |> PrefixedName
    /// <summary>
    ///   <para>xhv:cite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>cite refers to a resource that defines
    ///       a citation. </para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#cite">http://www.w3.org/1999/xhtml/vocab#cite</seealso>
    let cite = Prefixed_Name(xhv, "cite") |> PrefixedName
    /// <summary>
    ///   <para>xhv:contentinfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>contains meta information about the
    ///       content on the page or the page as a whole.</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#contentinfo">http://www.w3.org/1999/xhtml/vocab#contentinfo</seealso>
    let contentinfo = Prefixed_Name(xhv, "contentinfo") |> PrefixedName
