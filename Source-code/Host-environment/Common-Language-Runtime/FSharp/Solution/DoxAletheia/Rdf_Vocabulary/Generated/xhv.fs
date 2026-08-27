namespace http.www.w3.org._1999.xhtml.vocab.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module xhv =
    let _namespace_iri = Namespace_Iri xhv |> NamespaceIRI
    /// <summary>
    ///   <para>html:vocab#</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#">http://www.w3.org/1999/xhtml/vocab#</seealso>
    let _prefix_iri = Prefixed_Name(xhv, "") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#alert</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A message
    ///       with important, and usually time-sensitive, information. Also see alertdialog
    ///       and status."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#alert">http://www.w3.org/1999/xhtml/vocab#alert</seealso>
    let alert = Prefixed_Name(xhv, "alert") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#alertdialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A
    ///       type of dialog that contains an alert message, where initial focus goes
    ///       an element within the dialog. Also see alert and dialog."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#alertdialog">http://www.w3.org/1999/xhtml/vocab#alertdialog</seealso>
    let alertdialog = Prefixed_Name(xhv, "alertdialog") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#alternate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>rdf:Property</para>
    ///   <para>"alternate
    ///     designates alternate versions for a resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#alternate">http://www.w3.org/1999/xhtml/vocab#alternate</seealso>
    let alternate = Prefixed_Name(xhv, "alternate") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#appendix</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"appendix refers to a resource serving
    ///       as an appendix in a collection. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#appendix">http://www.w3.org/1999/xhtml/vocab#appendix</seealso>
    let appendix = Prefixed_Name(xhv, "appendix") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#application</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A
    ///       region declared as a web application, as opposed to a web document."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#application">http://www.w3.org/1999/xhtml/vocab#application</seealso>
    let application = Prefixed_Name(xhv, "application") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#article</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A section
    ///       of a page that consists of a composition that forms an independent part
    ///       of a document, page, or site."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#article">http://www.w3.org/1999/xhtml/vocab#article</seealso>
    let article = Prefixed_Name(xhv, "article") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#banner</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"contains
    ///       the prime heading or internal title of a page. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#banner">http://www.w3.org/1999/xhtml/vocab#banner</seealso>
    let banner = Prefixed_Name(xhv, "banner") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#bookmark</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"bookmark refers to a bookmark - a link
    ///       to a key entry point within an extended document. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#bookmark">http://www.w3.org/1999/xhtml/vocab#bookmark</seealso>
    let bookmark = Prefixed_Name(xhv, "bookmark") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#button</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An input
    ///       that allows for user-triggered actions when clicked or pressed. Also see
    ///       link."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#button">http://www.w3.org/1999/xhtml/vocab#button</seealso>
    let button = Prefixed_Name(xhv, "button") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#chapter</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"chapter refers to a resource serving
    ///       as a chapter in a collection. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#chapter">http://www.w3.org/1999/xhtml/vocab#chapter</seealso>
    let chapter = Prefixed_Name(xhv, "chapter") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#checkbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A checkable
    ///       input that has three possible values: true, false, or mixed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#checkbox">http://www.w3.org/1999/xhtml/vocab#checkbox</seealso>
    let checkbox = Prefixed_Name(xhv, "checkbox") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#cite</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"cite refers to a resource that defines
    ///       a citation. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#cite">http://www.w3.org/1999/xhtml/vocab#cite</seealso>
    let cite = Prefixed_Name(xhv, "cite") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#columnheader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A
    ///       cell containing header information for a column."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#columnheader">http://www.w3.org/1999/xhtml/vocab#columnheader</seealso>
    let columnheader = Prefixed_Name(xhv, "columnheader") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#combobox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A presentation
    ///       of a select; usually similar to a textbox where users can type ahead to
    ///       select an option, or type to enter arbitrary text as a new item in the
    ///       list. Also see listbox."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#combobox">http://www.w3.org/1999/xhtml/vocab#combobox</seealso>
    let combobox = Prefixed_Name(xhv, "combobox") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#complementary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"indicates that the section supports but is
    ///       separable from the main content of resource."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#complementary">http://www.w3.org/1999/xhtml/vocab#complementary</seealso>
    let complementary = Prefixed_Name(xhv, "complementary") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#contentinfo</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"contains meta information about the
    ///       content on the page or the page as a whole."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#contentinfo">http://www.w3.org/1999/xhtml/vocab#contentinfo</seealso>
    let contentinfo = Prefixed_Name(xhv, "contentinfo") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#contents</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"contents refers to a resource serving
    ///       as a table of contents. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#contents">http://www.w3.org/1999/xhtml/vocab#contents</seealso>
    let contents = Prefixed_Name(xhv, "contents") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#copyright</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"copyright refers to a copyright
    ///       statement for the resource. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#copyright">http://www.w3.org/1999/xhtml/vocab#copyright</seealso>
    let copyright = Prefixed_Name(xhv, "copyright") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#definition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"indicates the definition of a term or concept."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#definition">http://www.w3.org/1999/xhtml/vocab#definition</seealso>
    let definition = Prefixed_Name(xhv, "definition") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#dialog</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A dialog
    ///       is an application window that is designed to interrupt the current processing
    ///       of an application in order to prompt the user to enter information or require
    ///       a response. Also see alertdialog."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#dialog">http://www.w3.org/1999/xhtml/vocab#dialog</seealso>
    let dialog = Prefixed_Name(xhv, "dialog") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#directory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A list
    ///       of references to members of a group, such as a static table of contents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#directory">http://www.w3.org/1999/xhtml/vocab#directory</seealso>
    let directory = Prefixed_Name(xhv, "directory") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#document</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A region
    ///       containing related information that is declared as document content, as
    ///       opposed to a web application."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#document">http://www.w3.org/1999/xhtml/vocab#document</seealso>
    let document = Prefixed_Name(xhv, "document") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#first</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"first refers the first item in a
    ///       collection (see also start and top)."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#first">http://www.w3.org/1999/xhtml/vocab#first</seealso>
    let first = Prefixed_Name(xhv, "first") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#form</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A landmark
    ///       region that contains a collection of items and objects that, as a whole,
    ///       combine to create a form. Also see search."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#form">http://www.w3.org/1999/xhtml/vocab#form</seealso>
    let form = Prefixed_Name(xhv, "form") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#glossary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"glossary refers to a resource
    ///       providing a glossary of terms. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#glossary">http://www.w3.org/1999/xhtml/vocab#glossary</seealso>
    let glossary = Prefixed_Name(xhv, "glossary") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#grid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A grid is
    ///       an interactive control which contains cells of tabular data arranged in
    ///       rows and columns, like a table."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#grid">http://www.w3.org/1999/xhtml/vocab#grid</seealso>
    let grid = Prefixed_Name(xhv, "grid") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#gridcell</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A cell
    ///       in a grid or treegrid."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#gridcell">http://www.w3.org/1999/xhtml/vocab#gridcell</seealso>
    let gridcell = Prefixed_Name(xhv, "gridcell") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#group</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A set of
    ///       user interface objects which are not intended to be included in a page
    ///       summary or table of contents by assistive technologies."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#group">http://www.w3.org/1999/xhtml/vocab#group</seealso>
    let group = Prefixed_Name(xhv, "group") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#heading</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A heading
    ///       for a section of the page."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#heading">http://www.w3.org/1999/xhtml/vocab#heading</seealso>
    let heading = Prefixed_Name(xhv, "heading") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#help</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"help refers to a resource offering
    ///       help. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#help">http://www.w3.org/1999/xhtml/vocab#help</seealso>
    let help = Prefixed_Name(xhv, "help") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#icon</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"icon refers to a resource that
    ///       represents an icon. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#icon">http://www.w3.org/1999/xhtml/vocab#icon</seealso>
    let icon = Prefixed_Name(xhv, "icon") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#img</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A container
    ///       for a collection of elements that form an image."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#img">http://www.w3.org/1999/xhtml/vocab#img</seealso>
    let img = Prefixed_Name(xhv, "img") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#index</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"index refers to a resource providing
    ///       an index. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#index">http://www.w3.org/1999/xhtml/vocab#index</seealso>
    let index = Prefixed_Name(xhv, "index") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#itsRules</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"itsRules indicates that the designated
    ///       resource is an [ITS] rule set."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#itsRules">http://www.w3.org/1999/xhtml/vocab#itsRules</seealso>
    let itsRules = Prefixed_Name(xhv, "itsRules") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#last</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"last refers to the last resource in a
    ///       collection of resources. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The xhv:last property fully represents the RADion relationship of Current version"</para>
    /// labels<para>"current version"</para></remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#last">http://www.w3.org/1999/xhtml/vocab#last</seealso>
    let last = Prefixed_Name(xhv, "last") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#license</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"license refers to a resource that
    ///       defines the associated license. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    ///   <para>"The license under
    ///             which the media recording is distributed."</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#license">http://www.w3.org/1999/xhtml/vocab#license</seealso>
    let license = Prefixed_Name(xhv, "license") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#link</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An interactive
    ///       reference to an internal or external resource that, when activated, causes
    ///       the user agent to navigate to that resource. Also see button."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#link">http://www.w3.org/1999/xhtml/vocab#link</seealso>
    let link = Prefixed_Name(xhv, "link") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#list</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A group of
    ///       non-interactive list items. Also see listbox."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#list">http://www.w3.org/1999/xhtml/vocab#list</seealso>
    let list = Prefixed_Name(xhv, "list") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#listbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A widget
    ///       that allows the user to select one or more items from a list of choices.
    ///       Also see combobox and list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#listbox">http://www.w3.org/1999/xhtml/vocab#listbox</seealso>
    let listbox = Prefixed_Name(xhv, "listbox") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#listitem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A single
    ///       item in a list or directory."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#listitem">http://www.w3.org/1999/xhtml/vocab#listitem</seealso>
    let listitem = Prefixed_Name(xhv, "listitem") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#log</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A type of
    ///       live region where new information is added in meaningful order and old
    ///       information may disappear. Also see marquee."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#log">http://www.w3.org/1999/xhtml/vocab#log</seealso>
    let log = Prefixed_Name(xhv, "log") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#main</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"acts as the
    ///       main content of the document. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#main">http://www.w3.org/1999/xhtml/vocab#main</seealso>
    let main = Prefixed_Name(xhv, "main") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#marquee</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A type
    ///       of live region where non-essential information changes frequently. Also
    ///       see log."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#marquee">http://www.w3.org/1999/xhtml/vocab#marquee</seealso>
    let marquee = Prefixed_Name(xhv, "marquee") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#math</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Content that
    ///       represents a mathematical expression. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#math">http://www.w3.org/1999/xhtml/vocab#math</seealso>
    let math = Prefixed_Name(xhv, "math") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#menu</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A type of
    ///       widget that offers a list of choices to the user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menu">http://www.w3.org/1999/xhtml/vocab#menu</seealso>
    let menu = Prefixed_Name(xhv, "menu") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#menubar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A presentation
    ///       of menu that usually remains visible and is usually presented horizontally."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menubar">http://www.w3.org/1999/xhtml/vocab#menubar</seealso>
    let menubar = Prefixed_Name(xhv, "menubar") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#menuitem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An option
    ///       in a group of choices contained by a menu or menubar."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menuitem">http://www.w3.org/1999/xhtml/vocab#menuitem</seealso>
    let menuitem = Prefixed_Name(xhv, "menuitem") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#menuitemcheckbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A
    ///       checkable menuitem that has three possible values: true, false, or mixed."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menuitemcheckbox">http://www.w3.org/1999/xhtml/vocab#menuitemcheckbox</seealso>
    let menuitemcheckbox = Prefixed_Name(xhv, "menuitemcheckbox") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#menuitemradio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A
    ///       checkable menuitem in a group of menuitemradio roles, only one of which
    ///       can be checked at a time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#menuitemradio">http://www.w3.org/1999/xhtml/vocab#menuitemradio</seealso>
    let menuitemradio = Prefixed_Name(xhv, "menuitemradio") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#meta</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"meta refers to a resource that
    ///       provides metadata. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#meta">http://www.w3.org/1999/xhtml/vocab#meta</seealso>
    let meta = Prefixed_Name(xhv, "meta") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#navigation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"indicates a collection of items suitable for
    ///       navigating the document or related documents."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#navigation">http://www.w3.org/1999/xhtml/vocab#navigation</seealso>
    let navigation = Prefixed_Name(xhv, "navigation") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#next</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The xhv:next property fully represents the RADion relationship of Next version"</para>
    ///   <para>"next refers to the next resource
    ///       (after the current one) in an ordered collection of resources. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"next version"</para></remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#next">http://www.w3.org/1999/xhtml/vocab#next</seealso>
    let next = Prefixed_Name(xhv, "next") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#note</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"indicates
    ///       the content is parenthetic or ancillary to the main content of the
    ///       resource. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#note">http://www.w3.org/1999/xhtml/vocab#note</seealso>
    let note = Prefixed_Name(xhv, "note") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#option</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A selectable
    ///       item in a select list."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#option">http://www.w3.org/1999/xhtml/vocab#option</seealso>
    let option = Prefixed_Name(xhv, "option") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#p3pv1</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"p3pv1 refers to a P3P Policy Reference
    ///       File [P3P]. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#p3pv1">http://www.w3.org/1999/xhtml/vocab#p3pv1</seealso>
    let p3pv1 = Prefixed_Name(xhv, "p3pv1") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#presentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An
    ///       element whose implicit native role semantics will not be mapped to the
    ///       accessibility API."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#presentation">http://www.w3.org/1999/xhtml/vocab#presentation</seealso>
    let presentation = Prefixed_Name(xhv, "presentation") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#prev</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"The xhv:prev property fully represents the RADion relationship of Previous version"</para>
    ///   <para>"prev refers to a previous resource
    ///       (before the current one) in an ordered collection of resources. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// labels<para>"previous version"</para></remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#prev">http://www.w3.org/1999/xhtml/vocab#prev</seealso>
    let prev = Prefixed_Name(xhv, "prev") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#progressbar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An
    ///       element that displays the progress status for tasks that take a long time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#progressbar">http://www.w3.org/1999/xhtml/vocab#progressbar</seealso>
    let progressbar = Prefixed_Name(xhv, "progressbar") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#radio</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A checkable
    ///       input in a group of radio roles, only one of which can be checked at a
    ///       time."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#radio">http://www.w3.org/1999/xhtml/vocab#radio</seealso>
    let radio = Prefixed_Name(xhv, "radio") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#radiogroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A group
    ///       of radio buttons."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#radiogroup">http://www.w3.org/1999/xhtml/vocab#radiogroup</seealso>
    let radiogroup = Prefixed_Name(xhv, "radiogroup") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#region</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A large
    ///       perceivable section of a web page or document, that the author feels is
    ///       important enough to be included in a page summary or table of contents,
    ///       for example, an area of the page containing live sporting event statistics."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#region">http://www.w3.org/1999/xhtml/vocab#region</seealso>
    let region = Prefixed_Name(xhv, "region") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#relrev-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Bag</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#relrev-properties">http://www.w3.org/1999/xhtml/vocab#relrev-properties</seealso>
    let relrev_properties = Prefixed_Name(xhv, "relrev-properties") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#role</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>rdf:Bag</para>
    ///   <para>"role indicates the purpose of the
    ///       resource. See the XHTML Role
    ///       Vocabulary for roles in this vocabulary space, and XHTMLROLE for information on extending the
    ///       collection of roles. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#role">http://www.w3.org/1999/xhtml/vocab#role</seealso>
    let role = Prefixed_Name(xhv, "role") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#role-properties</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:member</para>
    ///   <para>rdf:Bag</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#role-properties">http://www.w3.org/1999/xhtml/vocab#role-properties</seealso>
    let role_properties = Prefixed_Name(xhv, "role-properties") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#row</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A row of cells
    ///       in a grid."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#row">http://www.w3.org/1999/xhtml/vocab#row</seealso>
    let row = Prefixed_Name(xhv, "row") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#rowgroup</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A group
    ///       containing one or more row elements in a grid."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#rowgroup">http://www.w3.org/1999/xhtml/vocab#rowgroup</seealso>
    let rowgroup = Prefixed_Name(xhv, "rowgroup") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#rowheader</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A cell
    ///       containing header information for a row in a grid."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#rowheader">http://www.w3.org/1999/xhtml/vocab#rowheader</seealso>
    let rowheader = Prefixed_Name(xhv, "rowheader") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#scrollbar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A graphical
    ///       object that controls the scrolling of content within a viewing area, regardless
    ///       of whether the content is fully displayed within the viewing area."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#scrollbar">http://www.w3.org/1999/xhtml/vocab#scrollbar</seealso>
    let scrollbar = Prefixed_Name(xhv, "scrollbar") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#search</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"indicates
    ///       that the section provides a search facility. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#search">http://www.w3.org/1999/xhtml/vocab#search</seealso>
    let search = Prefixed_Name(xhv, "search") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#section</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"section refers to a resource serving
    ///       as a section in a collection. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#section">http://www.w3.org/1999/xhtml/vocab#section</seealso>
    let section = Prefixed_Name(xhv, "section") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#separator</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A divider
    ///       that separates and distinguishes sections of content or groups of menuitems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#separator">http://www.w3.org/1999/xhtml/vocab#separator</seealso>
    let separator = Prefixed_Name(xhv, "separator") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#slider</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A user
    ///       input where the user selects a value from within a given range."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#slider">http://www.w3.org/1999/xhtml/vocab#slider</seealso>
    let slider = Prefixed_Name(xhv, "slider") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#spinbutton</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A form
    ///       of range that expects a user to select from amongst discrete choices."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#spinbutton">http://www.w3.org/1999/xhtml/vocab#spinbutton</seealso>
    let spinbutton = Prefixed_Name(xhv, "spinbutton") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#start</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"start refers to the first resource in
    ///       a collection of resources. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#start">http://www.w3.org/1999/xhtml/vocab#start</seealso>
    let start = Prefixed_Name(xhv, "start") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#status</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A container
    ///       whose content is advisory information for the user but is not important
    ///       enough to justify an alert. Also see alert."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#status">http://www.w3.org/1999/xhtml/vocab#status</seealso>
    let status = Prefixed_Name(xhv, "status") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#stylesheet</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"stylesheet refers to a resource
    ///       serving as a stylesheet for a resource. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#stylesheet">http://www.w3.org/1999/xhtml/vocab#stylesheet</seealso>
    let stylesheet = Prefixed_Name(xhv, "stylesheet") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#subsection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"subsection refers to a resource
    ///       serving as a subsection in a collection. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#subsection">http://www.w3.org/1999/xhtml/vocab#subsection</seealso>
    let subsection = Prefixed_Name(xhv, "subsection") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#tab</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A grouping
    ///       label providing a mechanism for selecting the tab content that is to be
    ///       rendered to the user."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tab">http://www.w3.org/1999/xhtml/vocab#tab</seealso>
    let tab = Prefixed_Name(xhv, "tab") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#tablist</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A list
    ///       of tab elements, which are references to tabpanel elements."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tablist">http://www.w3.org/1999/xhtml/vocab#tablist</seealso>
    let tablist = Prefixed_Name(xhv, "tablist") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#tabpanel</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A container
    ///       for the resources associated with a tab, where each tab is contained in
    ///       a tablist."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tabpanel">http://www.w3.org/1999/xhtml/vocab#tabpanel</seealso>
    let tabpanel = Prefixed_Name(xhv, "tabpanel") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#textbox</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"Input
    ///       that allows free-form text as its value."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#textbox">http://www.w3.org/1999/xhtml/vocab#textbox</seealso>
    let textbox = Prefixed_Name(xhv, "textbox") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#timer</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A type of
    ///       live region containing a numerical counter which indicates an amount of
    ///       elapsed time from a start point, or the time remaining until an end point."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#timer">http://www.w3.org/1999/xhtml/vocab#timer</seealso>
    let timer = Prefixed_Name(xhv, "timer") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#toolbar</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A collection
    ///       of commonly used function buttons represented in compact visual form."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#toolbar">http://www.w3.org/1999/xhtml/vocab#toolbar</seealso>
    let toolbar = Prefixed_Name(xhv, "toolbar") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#tooltip</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A contextual
    ///       popup that displays a description for an element."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tooltip">http://www.w3.org/1999/xhtml/vocab#tooltip</seealso>
    let tooltip = Prefixed_Name(xhv, "tooltip") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#top</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"top is a synonym for start. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#top">http://www.w3.org/1999/xhtml/vocab#top</seealso>
    let top = Prefixed_Name(xhv, "top") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#tree</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A type of
    ///       list that may contain sub-level nested groups that can be collapsed and
    ///       expanded."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#tree">http://www.w3.org/1999/xhtml/vocab#tree</seealso>
    let tree = Prefixed_Name(xhv, "tree") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#treegrid</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"A grid
    ///       whose rows can be expanded and collapsed in the same manner as for a tree."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#treegrid">http://www.w3.org/1999/xhtml/vocab#treegrid</seealso>
    let treegrid = Prefixed_Name(xhv, "treegrid") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#treeitem</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"An option
    ///       item of a tree. This is an element within a tree that may be expanded or
    ///       collapsed if it contains a sub-level group of treeitems."^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#treeitem">http://www.w3.org/1999/xhtml/vocab#treeitem</seealso>
    let treeitem = Prefixed_Name(xhv, "treeitem") |> PrefixedName
    /// <summary>
    ///   <para>html:vocab#up</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>"up refers to a resource "above" in a
    ///       hierarchically structured set. "^^&lt;http://www.w3.org/2001/XMLSchema#string&gt;</para>
    /// </remarks>
    /// <seealso href="http://www.w3.org/1999/xhtml/vocab#up">http://www.w3.org/1999/xhtml/vocab#up</seealso>
    let up = Prefixed_Name(xhv, "up") |> PrefixedName
