namespace http.www.w3.org._1999.xhtml.vocab.hash

open DoxAletheia.Rdf_Vocabulary

module xhv =
    let _namespace_name = "http://www.w3.org/1999/xhtml/vocab#"
    /// <summary>
    /// stylesheet refers to a resource
    ///       serving as a stylesheet for a resource.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#stylesheet"></see></summary>
    let stylesheet = Namespaced_IRI.parse _namespace_name "stylesheet" |> NamespacedName
    /// <summary>
    /// A message
    ///       with important, and usually time-sensitive, information. Also see alertdialog
    ///       and status.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#alert"></see></summary>
    let alert = Namespaced_IRI.parse _namespace_name "alert" |> NamespacedName

    /// <summary>
    /// A
    ///       type of dialog that contains an alert message, where initial focus goes
    ///       an element within the dialog. Also see alert and dialog.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#alertdialog"></see></summary>
    let alertdialog =
        Namespaced_IRI.parse _namespace_name "alertdialog" |> NamespacedName

    /// <summary>
    /// alternate
    ///     designates alternate versions for a resource.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#alternate"></see></summary>
    let alternate = Namespaced_IRI.parse _namespace_name "alternate" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/1999/xhtml/vocab#relrev-properties"></see>
    /// </summary>
    let ``relrev-properties`` =
        Namespaced_IRI.parse _namespace_name "relrev-properties" |> NamespacedName

    /// <summary>
    /// appendix refers to a resource serving
    ///       as an appendix in a collection.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#appendix"></see></summary>
    let appendix = Namespaced_IRI.parse _namespace_name "appendix" |> NamespacedName

    /// <summary>
    /// A
    ///       region declared as a web application, as opposed to a web document.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#application"></see></summary>
    let application =
        Namespaced_IRI.parse _namespace_name "application" |> NamespacedName

    /// <summary>
    /// A section
    ///       of a page that consists of a composition that forms an independent part
    ///       of a document, page, or site.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#article"></see></summary>
    let article = Namespaced_IRI.parse _namespace_name "article" |> NamespacedName
    /// <summary>
    /// contains
    ///       the prime heading or internal title of a page.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#banner"></see></summary>
    let banner = Namespaced_IRI.parse _namespace_name "banner" |> NamespacedName

    /// <summary>
    ///   <see href="http://www.w3.org/1999/xhtml/vocab#role-properties"></see>
    /// </summary>
    let ``role-properties`` =
        Namespaced_IRI.parse _namespace_name "role-properties" |> NamespacedName

    /// <summary>
    /// bookmark refers to a bookmark - a link
    ///       to a key entry point within an extended document.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#bookmark"></see></summary>
    let bookmark = Namespaced_IRI.parse _namespace_name "bookmark" |> NamespacedName
    /// <summary>
    /// An input
    ///       that allows for user-triggered actions when clicked or pressed. Also see
    ///       link.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#button"></see></summary>
    let button = Namespaced_IRI.parse _namespace_name "button" |> NamespacedName
    /// <summary>
    /// chapter refers to a resource serving
    ///       as a chapter in a collection.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#chapter"></see></summary>
    let chapter = Namespaced_IRI.parse _namespace_name "chapter" |> NamespacedName
    /// <summary>
    /// A checkable
    ///       input that has three possible values: true, false, or mixed.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#checkbox"></see></summary>
    let checkbox = Namespaced_IRI.parse _namespace_name "checkbox" |> NamespacedName
    /// <summary>
    /// cite refers to a resource that defines
    ///       a citation.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#cite"></see></summary>
    let cite = Namespaced_IRI.parse _namespace_name "cite" |> NamespacedName

    /// <summary>
    /// A
    ///       cell containing header information for a column.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#columnheader"></see></summary>
    let columnheader =
        Namespaced_IRI.parse _namespace_name "columnheader" |> NamespacedName

    /// <summary>
    /// A presentation
    ///       of a select; usually similar to a textbox where users can type ahead to
    ///       select an option, or type to enter arbitrary text as a new item in the
    ///       list. Also see listbox.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#combobox"></see></summary>
    let combobox = Namespaced_IRI.parse _namespace_name "combobox" |> NamespacedName

    /// <summary>
    /// indicates that the section supports but is
    ///       separable from the main content of resource.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#complementary"></see></summary>
    let complementary =
        Namespaced_IRI.parse _namespace_name "complementary" |> NamespacedName

    /// <summary>
    /// contains meta information about the
    ///       content on the page or the page as a whole.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#contentinfo"></see></summary>
    let contentinfo =
        Namespaced_IRI.parse _namespace_name "contentinfo" |> NamespacedName

    /// <summary>
    /// contents refers to a resource serving
    ///       as a table of contents.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#contents"></see></summary>
    let contents = Namespaced_IRI.parse _namespace_name "contents" |> NamespacedName
    /// <summary>
    /// copyright refers to a copyright
    ///       statement for the resource.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#copyright"></see></summary>
    let copyright = Namespaced_IRI.parse _namespace_name "copyright" |> NamespacedName
    /// <summary>
    /// indicates the definition of a term or concept.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#definition"></see></summary>
    let definition = Namespaced_IRI.parse _namespace_name "definition" |> NamespacedName
    /// <summary>
    /// A dialog
    ///       is an application window that is designed to interrupt the current processing
    ///       of an application in order to prompt the user to enter information or require
    ///       a response. Also see alertdialog.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#dialog"></see></summary>
    let dialog = Namespaced_IRI.parse _namespace_name "dialog" |> NamespacedName
    /// <summary>
    /// A list
    ///       of references to members of a group, such as a static table of contents.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#directory"></see></summary>
    let directory = Namespaced_IRI.parse _namespace_name "directory" |> NamespacedName
    /// <summary>
    /// A region
    ///       containing related information that is declared as document content, as
    ///       opposed to a web application.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#document"></see></summary>
    let document = Namespaced_IRI.parse _namespace_name "document" |> NamespacedName
    /// <summary>
    /// first refers the first item in a
    ///       collection (see also start and top).
    /// <see href="http://www.w3.org/1999/xhtml/vocab#first"></see></summary>
    let first = Namespaced_IRI.parse _namespace_name "first" |> NamespacedName
    /// <summary>
    /// A landmark
    ///       region that contains a collection of items and objects that, as a whole,
    ///       combine to create a form. Also see search.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#form"></see></summary>
    let form = Namespaced_IRI.parse _namespace_name "form" |> NamespacedName
    /// <summary>
    /// glossary refers to a resource
    ///       providing a glossary of terms.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#glossary"></see></summary>
    let glossary = Namespaced_IRI.parse _namespace_name "glossary" |> NamespacedName
    /// <summary>
    /// A grid is
    ///       an interactive control which contains cells of tabular data arranged in
    ///       rows and columns, like a table.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#grid"></see></summary>
    let grid = Namespaced_IRI.parse _namespace_name "grid" |> NamespacedName
    /// <summary>
    /// A cell
    ///       in a grid or treegrid.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#gridcell"></see></summary>
    let gridcell = Namespaced_IRI.parse _namespace_name "gridcell" |> NamespacedName
    /// <summary>
    /// A set of
    ///       user interface objects which are not intended to be included in a page
    ///       summary or table of contents by assistive technologies.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#group"></see></summary>
    let group = Namespaced_IRI.parse _namespace_name "group" |> NamespacedName
    /// <summary>
    /// A heading
    ///       for a section of the page.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#heading"></see></summary>
    let heading = Namespaced_IRI.parse _namespace_name "heading" |> NamespacedName
    /// <summary>
    /// help refers to a resource offering
    ///       help.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#help"></see></summary>
    let help = Namespaced_IRI.parse _namespace_name "help" |> NamespacedName
    /// <summary>
    /// icon refers to a resource that
    ///       represents an icon.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#icon"></see></summary>
    let icon = Namespaced_IRI.parse _namespace_name "icon" |> NamespacedName
    /// <summary>
    /// A container
    ///       for a collection of elements that form an image.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#img"></see></summary>
    let img = Namespaced_IRI.parse _namespace_name "img" |> NamespacedName
    /// <summary>
    /// index refers to a resource providing
    ///       an index.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#index"></see></summary>
    let index = Namespaced_IRI.parse _namespace_name "index" |> NamespacedName
    /// <summary>
    /// itsRules indicates that the designated
    ///       resource is an [ITS] rule set.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#itsRules"></see></summary>
    let itsRules = Namespaced_IRI.parse _namespace_name "itsRules" |> NamespacedName
    /// <summary>
    /// last refers to the last resource in a
    ///       collection of resources.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#last"></see></summary>
    let last = Namespaced_IRI.parse _namespace_name "last" |> NamespacedName
    /// <summary>
    /// license refers to a resource that
    ///       defines the associated license.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#license"></see></summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName
    /// <summary>
    /// An interactive
    ///       reference to an internal or external resource that, when activated, causes
    ///       the user agent to navigate to that resource. Also see button.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#link"></see></summary>
    let link = Namespaced_IRI.parse _namespace_name "link" |> NamespacedName
    /// <summary>
    /// A group of
    ///       non-interactive list items. Also see listbox.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#list"></see></summary>
    let list = Namespaced_IRI.parse _namespace_name "list" |> NamespacedName
    /// <summary>
    /// A widget
    ///       that allows the user to select one or more items from a list of choices.
    ///       Also see combobox and list.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#listbox"></see></summary>
    let listbox = Namespaced_IRI.parse _namespace_name "listbox" |> NamespacedName
    /// <summary>
    /// A single
    ///       item in a list or directory.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#listitem"></see></summary>
    let listitem = Namespaced_IRI.parse _namespace_name "listitem" |> NamespacedName
    /// <summary>
    /// A type of
    ///       live region where new information is added in meaningful order and old
    ///       information may disappear. Also see marquee.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#log"></see></summary>
    let log = Namespaced_IRI.parse _namespace_name "log" |> NamespacedName
    /// <summary>
    /// acts as the
    ///       main content of the document.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#main"></see></summary>
    let main = Namespaced_IRI.parse _namespace_name "main" |> NamespacedName
    /// <summary>
    /// A type
    ///       of live region where non-essential information changes frequently. Also
    ///       see log.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#marquee"></see></summary>
    let marquee = Namespaced_IRI.parse _namespace_name "marquee" |> NamespacedName
    /// <summary>
    /// Content that
    ///       represents a mathematical expression.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#math"></see></summary>
    let math = Namespaced_IRI.parse _namespace_name "math" |> NamespacedName
    /// <summary>
    /// A type of
    ///       widget that offers a list of choices to the user.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#menu"></see></summary>
    let menu = Namespaced_IRI.parse _namespace_name "menu" |> NamespacedName
    /// <summary>
    /// A presentation
    ///       of menu that usually remains visible and is usually presented horizontally.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#menubar"></see></summary>
    let menubar = Namespaced_IRI.parse _namespace_name "menubar" |> NamespacedName
    /// <summary>
    /// An option
    ///       in a group of choices contained by a menu or menubar.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#menuitem"></see></summary>
    let menuitem = Namespaced_IRI.parse _namespace_name "menuitem" |> NamespacedName

    /// <summary>
    /// A
    ///       checkable menuitem that has three possible values: true, false, or mixed.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#menuitemcheckbox"></see></summary>
    let menuitemcheckbox =
        Namespaced_IRI.parse _namespace_name "menuitemcheckbox" |> NamespacedName

    /// <summary>
    /// A
    ///       checkable menuitem in a group of menuitemradio roles, only one of which
    ///       can be checked at a time.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#menuitemradio"></see></summary>
    let menuitemradio =
        Namespaced_IRI.parse _namespace_name "menuitemradio" |> NamespacedName

    /// <summary>
    /// meta refers to a resource that
    ///       provides metadata.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#meta"></see></summary>
    let meta = Namespaced_IRI.parse _namespace_name "meta" |> NamespacedName
    /// <summary>
    /// indicates a collection of items suitable for
    ///       navigating the document or related documents.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#navigation"></see></summary>
    let navigation = Namespaced_IRI.parse _namespace_name "navigation" |> NamespacedName
    /// <summary>
    /// next refers to the next resource
    ///       (after the current one) in an ordered collection of resources.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#next"></see></summary>
    let next = Namespaced_IRI.parse _namespace_name "next" |> NamespacedName
    /// <summary>
    /// indicates
    ///       the content is parenthetic or ancillary to the main content of the
    ///       resource.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#note"></see></summary>
    let note = Namespaced_IRI.parse _namespace_name "note" |> NamespacedName
    /// <summary>
    /// A selectable
    ///       item in a select list.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#option"></see></summary>
    let option = Namespaced_IRI.parse _namespace_name "option" |> NamespacedName
    /// <summary>
    /// p3pv1 refers to a P3P Policy Reference
    ///       File [P3P].
    /// <see href="http://www.w3.org/1999/xhtml/vocab#p3pv1"></see></summary>
    let p3pv1 = Namespaced_IRI.parse _namespace_name "p3pv1" |> NamespacedName

    /// <summary>
    /// An
    ///       element whose implicit native role semantics will not be mapped to the
    ///       accessibility API.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#presentation"></see></summary>
    let presentation =
        Namespaced_IRI.parse _namespace_name "presentation" |> NamespacedName

    /// <summary>
    /// prev refers to a previous resource
    ///       (before the current one) in an ordered collection of resources.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#prev"></see></summary>
    let prev = Namespaced_IRI.parse _namespace_name "prev" |> NamespacedName

    /// <summary>
    /// An
    ///       element that displays the progress status for tasks that take a long time.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#progressbar"></see></summary>
    let progressbar =
        Namespaced_IRI.parse _namespace_name "progressbar" |> NamespacedName

    /// <summary>
    /// A checkable
    ///       input in a group of radio roles, only one of which can be checked at a
    ///       time.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#radio"></see></summary>
    let radio = Namespaced_IRI.parse _namespace_name "radio" |> NamespacedName
    /// <summary>
    /// A group
    ///       of radio buttons.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#radiogroup"></see></summary>
    let radiogroup = Namespaced_IRI.parse _namespace_name "radiogroup" |> NamespacedName
    /// <summary>
    /// A large
    ///       perceivable section of a web page or document, that the author feels is
    ///       important enough to be included in a page summary or table of contents,
    ///       for example, an area of the page containing live sporting event statistics.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#region"></see></summary>
    let region = Namespaced_IRI.parse _namespace_name "region" |> NamespacedName
    /// <summary>
    /// role indicates the purpose of the
    ///       resource. See the XHTML Role
    ///       Vocabulary for roles in this vocabulary space, and XHTMLROLE for information on extending the
    ///       collection of roles.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#role"></see></summary>
    let role = Namespaced_IRI.parse _namespace_name "role" |> NamespacedName
    /// <summary>
    /// A row of cells
    ///       in a grid.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#row"></see></summary>
    let row = Namespaced_IRI.parse _namespace_name "row" |> NamespacedName
    /// <summary>
    /// A group
    ///       containing one or more row elements in a grid.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#rowgroup"></see></summary>
    let rowgroup = Namespaced_IRI.parse _namespace_name "rowgroup" |> NamespacedName
    /// <summary>
    /// A cell
    ///       containing header information for a row in a grid.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#rowheader"></see></summary>
    let rowheader = Namespaced_IRI.parse _namespace_name "rowheader" |> NamespacedName
    /// <summary>
    /// A graphical
    ///       object that controls the scrolling of content within a viewing area, regardless
    ///       of whether the content is fully displayed within the viewing area.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#scrollbar"></see></summary>
    let scrollbar = Namespaced_IRI.parse _namespace_name "scrollbar" |> NamespacedName
    /// <summary>
    /// indicates
    ///       that the section provides a search facility.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#search"></see></summary>
    let search = Namespaced_IRI.parse _namespace_name "search" |> NamespacedName
    /// <summary>
    /// section refers to a resource serving
    ///       as a section in a collection.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#section"></see></summary>
    let section = Namespaced_IRI.parse _namespace_name "section" |> NamespacedName
    /// <summary>
    /// A divider
    ///       that separates and distinguishes sections of content or groups of menuitems.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#separator"></see></summary>
    let separator = Namespaced_IRI.parse _namespace_name "separator" |> NamespacedName
    /// <summary>
    /// A user
    ///       input where the user selects a value from within a given range.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#slider"></see></summary>
    let slider = Namespaced_IRI.parse _namespace_name "slider" |> NamespacedName
    /// <summary>
    /// A form
    ///       of range that expects a user to select from amongst discrete choices.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#spinbutton"></see></summary>
    let spinbutton = Namespaced_IRI.parse _namespace_name "spinbutton" |> NamespacedName
    /// <summary>
    /// start refers to the first resource in
    ///       a collection of resources.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#start"></see></summary>
    let start = Namespaced_IRI.parse _namespace_name "start" |> NamespacedName
    /// <summary>
    /// A container
    ///       whose content is advisory information for the user but is not important
    ///       enough to justify an alert. Also see alert.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#status"></see></summary>
    let status = Namespaced_IRI.parse _namespace_name "status" |> NamespacedName
    /// <summary>
    /// subsection refers to a resource
    ///       serving as a subsection in a collection.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#subsection"></see></summary>
    let subsection = Namespaced_IRI.parse _namespace_name "subsection" |> NamespacedName
    /// <summary>
    /// A grouping
    ///       label providing a mechanism for selecting the tab content that is to be
    ///       rendered to the user.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#tab"></see></summary>
    let tab = Namespaced_IRI.parse _namespace_name "tab" |> NamespacedName
    /// <summary>
    /// A list
    ///       of tab elements, which are references to tabpanel elements.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#tablist"></see></summary>
    let tablist = Namespaced_IRI.parse _namespace_name "tablist" |> NamespacedName
    /// <summary>
    /// A container
    ///       for the resources associated with a tab, where each tab is contained in
    ///       a tablist.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#tabpanel"></see></summary>
    let tabpanel = Namespaced_IRI.parse _namespace_name "tabpanel" |> NamespacedName
    /// <summary>
    /// Input
    ///       that allows free-form text as its value.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#textbox"></see></summary>
    let textbox = Namespaced_IRI.parse _namespace_name "textbox" |> NamespacedName
    /// <summary>
    /// A type of
    ///       live region containing a numerical counter which indicates an amount of
    ///       elapsed time from a start point, or the time remaining until an end point.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#timer"></see></summary>
    let timer = Namespaced_IRI.parse _namespace_name "timer" |> NamespacedName
    /// <summary>
    /// A collection
    ///       of commonly used function buttons represented in compact visual form.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#toolbar"></see></summary>
    let toolbar = Namespaced_IRI.parse _namespace_name "toolbar" |> NamespacedName
    /// <summary>
    /// A contextual
    ///       popup that displays a description for an element.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#tooltip"></see></summary>
    let tooltip = Namespaced_IRI.parse _namespace_name "tooltip" |> NamespacedName
    /// <summary>
    /// top is a synonym for start.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#top"></see></summary>
    let top = Namespaced_IRI.parse _namespace_name "top" |> NamespacedName
    /// <summary>
    /// A type of
    ///       list that may contain sub-level nested groups that can be collapsed and
    ///       expanded.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#tree"></see></summary>
    let tree = Namespaced_IRI.parse _namespace_name "tree" |> NamespacedName
    /// <summary>
    /// A grid
    ///       whose rows can be expanded and collapsed in the same manner as for a tree.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#treegrid"></see></summary>
    let treegrid = Namespaced_IRI.parse _namespace_name "treegrid" |> NamespacedName
    /// <summary>
    /// An option
    ///       item of a tree. This is an element within a tree that may be expanded or
    ///       collapsed if it contains a sub-level group of treeitems.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#treeitem"></see></summary>
    let treeitem = Namespaced_IRI.parse _namespace_name "treeitem" |> NamespacedName
    /// <summary>
    /// up refers to a resource "above" in a
    ///       hierarchically structured set.
    /// <see href="http://www.w3.org/1999/xhtml/vocab#up"></see></summary>
    let up = Namespaced_IRI.parse _namespace_name "up" |> NamespacedName
