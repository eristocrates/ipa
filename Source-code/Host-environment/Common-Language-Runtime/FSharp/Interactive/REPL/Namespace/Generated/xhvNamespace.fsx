#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module xhv =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://www.w3.org/1999/xhtml/vocab#" "xhv"

    /// <summary>
    ///   <para>rdfs:comment : A message
    ///       with important, and usually time-sensitive, information. Also see alertdialog
    ///       and status.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#alert">xhv:alert</a>
    /// </summary>
    let alert = _prefixId.prefix "alert"
    /// <summary>
    ///   <para>rdfs:comment : A
    ///       type of dialog that contains an alert message, where initial focus goes
    ///       an element within the dialog. Also see alert and dialog.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#alertdialog">xhv:alertdialog</a>
    /// </summary>
    let alertdialog = _prefixId.prefix "alertdialog"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#alternate^^xsd:string</para>
    ///   <para>rdfa:term : alternate^^xsd:string</para>
    ///   <para>rdfs:comment : alternate
    ///     designates alternate versions for a resource.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#alternate">xhv:alternate</a>
    /// </summary>
    let alternate = _prefixId.prefix "alternate"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#appendix^^xsd:string</para>
    ///   <para>rdfa:term : appendix^^xsd:string</para>
    ///   <para>rdfs:comment : appendix refers to a resource serving
    ///       as an appendix in a collection. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#appendix">xhv:appendix</a>
    /// </summary>
    let appendix = _prefixId.prefix "appendix"
    /// <summary>
    ///   <para>rdfs:comment : A
    ///       region declared as a web application, as opposed to a web document.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#application">xhv:application</a>
    /// </summary>
    let application = _prefixId.prefix "application"
    /// <summary>
    ///   <para>rdfs:comment : A section
    ///       of a page that consists of a composition that forms an independent part
    ///       of a document, page, or site.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#article">xhv:article</a>
    /// </summary>
    let article = _prefixId.prefix "article"
    /// <summary>
    ///   <para>rdfs:comment : contains
    ///       the prime heading or internal title of a page. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#banner">xhv:banner</a>
    /// </summary>
    let banner = _prefixId.prefix "banner"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#bookmark^^xsd:string</para>
    ///   <para>rdfa:term : bookmark^^xsd:string</para>
    ///   <para>rdfs:comment : bookmark refers to a bookmark - a link
    ///       to a key entry point within an extended document. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#bookmark">xhv:bookmark</a>
    /// </summary>
    let bookmark = _prefixId.prefix "bookmark"
    /// <summary>
    ///   <para>rdfs:comment : An input
    ///       that allows for user-triggered actions when clicked or pressed. Also see
    ///       link.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#button">xhv:button</a>
    /// </summary>
    let button = _prefixId.prefix "button"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#chapter^^xsd:string</para>
    ///   <para>rdfa:term : chapter^^xsd:string</para>
    ///   <para>rdfs:comment : chapter refers to a resource serving
    ///       as a chapter in a collection. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#chapter">xhv:chapter</a>
    /// </summary>
    let chapter = _prefixId.prefix "chapter"
    /// <summary>
    ///   <para>rdfs:comment : A checkable
    ///       input that has three possible values: true, false, or mixed.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#checkbox">xhv:checkbox</a>
    /// </summary>
    let checkbox = _prefixId.prefix "checkbox"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#cite^^xsd:string</para>
    ///   <para>rdfa:term : cite^^xsd:string</para>
    ///   <para>rdfs:comment : cite refers to a resource that defines
    ///       a citation. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#cite">xhv:cite</a>
    /// </summary>
    let cite = _prefixId.prefix "cite"
    /// <summary>
    ///   <para>rdfs:comment : A
    ///       cell containing header information for a column.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#columnheader">xhv:columnheader</a>
    /// </summary>
    let columnheader = _prefixId.prefix "columnheader"
    /// <summary>
    ///   <para>rdfs:comment : A presentation
    ///       of a select; usually similar to a textbox where users can type ahead to
    ///       select an option, or type to enter arbitrary text as a new item in the
    ///       list. Also see listbox.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#combobox">xhv:combobox</a>
    /// </summary>
    let combobox = _prefixId.prefix "combobox"
    /// <summary>
    ///   <para>rdfs:comment : indicates that the section supports but is
    ///       separable from the main content of resource.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#complementary">xhv:complementary</a>
    /// </summary>
    let complementary = _prefixId.prefix "complementary"
    /// <summary>
    ///   <para>rdfs:comment : contains meta information about the
    ///       content on the page or the page as a whole.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#contentinfo">xhv:contentinfo</a>
    /// </summary>
    let contentinfo = _prefixId.prefix "contentinfo"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#contents^^xsd:string</para>
    ///   <para>rdfa:term : contents^^xsd:string</para>
    ///   <para>rdfs:comment : contents refers to a resource serving
    ///       as a table of contents. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#contents">xhv:contents</a>
    /// </summary>
    let contents = _prefixId.prefix "contents"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#copyright^^xsd:string</para>
    ///   <para>rdfa:term : copyright^^xsd:string</para>
    ///   <para>rdfs:comment : copyright refers to a copyright
    ///       statement for the resource. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#copyright">xhv:copyright</a>
    /// </summary>
    let copyright = _prefixId.prefix "copyright"
    /// <summary>
    ///   <para>rdfs:comment : indicates the definition of a term or concept.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#definition">xhv:definition</a>
    /// </summary>
    let definition = _prefixId.prefix "definition"
    /// <summary>
    ///   <para>rdfs:comment : A dialog
    ///       is an application window that is designed to interrupt the current processing
    ///       of an application in order to prompt the user to enter information or require
    ///       a response. Also see alertdialog.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#dialog">xhv:dialog</a>
    /// </summary>
    let dialog = _prefixId.prefix "dialog"
    /// <summary>
    ///   <para>rdfs:comment : A list
    ///       of references to members of a group, such as a static table of contents.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#directory">xhv:directory</a>
    /// </summary>
    let directory = _prefixId.prefix "directory"
    /// <summary>
    ///   <para>rdfs:comment : A region
    ///       containing related information that is declared as document content, as
    ///       opposed to a web application.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#document">xhv:document</a>
    /// </summary>
    let document = _prefixId.prefix "document"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#first^^xsd:string</para>
    ///   <para>rdfa:term : first^^xsd:string</para>
    ///   <para>rdfs:comment : first refers the first item in a
    ///       collection (see also start and top).^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#first">xhv:first</a>
    /// </summary>
    let first = _prefixId.prefix "first"
    /// <summary>
    ///   <para>rdfs:comment : A landmark
    ///       region that contains a collection of items and objects that, as a whole,
    ///       combine to create a form. Also see search.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#form">xhv:form</a>
    /// </summary>
    let form = _prefixId.prefix "form"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#glossary^^xsd:string</para>
    ///   <para>rdfa:term : glossary^^xsd:string</para>
    ///   <para>rdfs:comment : glossary refers to a resource
    ///       providing a glossary of terms. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#glossary">xhv:glossary</a>
    /// </summary>
    let glossary = _prefixId.prefix "glossary"
    /// <summary>
    ///   <para>rdfs:comment : A grid is
    ///       an interactive control which contains cells of tabular data arranged in
    ///       rows and columns, like a table.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#grid">xhv:grid</a>
    /// </summary>
    let grid = _prefixId.prefix "grid"
    /// <summary>
    ///   <para>rdfs:comment : A cell
    ///       in a grid or treegrid.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#gridcell">xhv:gridcell</a>
    /// </summary>
    let gridcell = _prefixId.prefix "gridcell"
    /// <summary>
    ///   <para>rdfs:comment : A set of
    ///       user interface objects which are not intended to be included in a page
    ///       summary or table of contents by assistive technologies.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#group">xhv:group</a>
    /// </summary>
    let group = _prefixId.prefix "group"
    /// <summary>
    ///   <para>rdfs:comment : A heading
    ///       for a section of the page.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#heading">xhv:heading</a>
    /// </summary>
    let heading = _prefixId.prefix "heading"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#help^^xsd:string</para>
    ///   <para>rdfa:term : help^^xsd:string</para>
    ///   <para>rdfs:comment : help refers to a resource offering
    ///       help. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#help">xhv:help</a>
    /// </summary>
    let help = _prefixId.prefix "help"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#icon^^xsd:string</para>
    ///   <para>rdfa:term : icon^^xsd:string</para>
    ///   <para>rdfs:comment : icon refers to a resource that
    ///       represents an icon. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#icon">xhv:icon</a>
    /// </summary>
    let icon = _prefixId.prefix "icon"
    /// <summary>
    ///   <para>rdfs:comment : A container
    ///       for a collection of elements that form an image.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#img">xhv:img</a>
    /// </summary>
    let img = _prefixId.prefix "img"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#index^^xsd:string</para>
    ///   <para>rdfa:term : index^^xsd:string</para>
    ///   <para>rdfs:comment : index refers to a resource providing
    ///       an index. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#index">xhv:index</a>
    /// </summary>
    let index = _prefixId.prefix "index"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#itsRules^^xsd:string</para>
    ///   <para>rdfa:term : itsRules^^xsd:string</para>
    ///   <para>rdfs:comment : itsRules indicates that the designated
    ///       resource is an [ITS] rule set.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#itsRules">xhv:itsRules</a>
    /// </summary>
    let itsRules = _prefixId.prefix "itsRules"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#last^^xsd:string</para>
    ///   <para>rdfa:term : last^^xsd:string</para>
    ///   <para>rdfs:comment : last refers to the last resource in a
    ///       collection of resources. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#last">xhv:last</a>
    /// </summary>
    let last = _prefixId.prefix "last"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#license^^xsd:string</para>
    ///   <para>rdfa:term : license^^xsd:string</para>
    ///   <para>rdfs:comment : license refers to a resource that
    ///       defines the associated license. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#license">xhv:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>rdfs:comment : An interactive
    ///       reference to an internal or external resource that, when activated, causes
    ///       the user agent to navigate to that resource. Also see button.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#link">xhv:link</a>
    /// </summary>
    let link = _prefixId.prefix "link"
    /// <summary>
    ///   <para>rdfs:comment : A group of
    ///       non-interactive list items. Also see listbox.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#list">xhv:list</a>
    /// </summary>
    let list = _prefixId.prefix "list"
    /// <summary>
    ///   <para>rdfs:comment : A widget
    ///       that allows the user to select one or more items from a list of choices.
    ///       Also see combobox and list.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#listbox">xhv:listbox</a>
    /// </summary>
    let listbox = _prefixId.prefix "listbox"
    /// <summary>
    ///   <para>rdfs:comment : A single
    ///       item in a list or directory.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#listitem">xhv:listitem</a>
    /// </summary>
    let listitem = _prefixId.prefix "listitem"
    /// <summary>
    ///   <para>rdfs:comment : A type of
    ///       live region where new information is added in meaningful order and old
    ///       information may disappear. Also see marquee.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#log">xhv:log</a>
    /// </summary>
    let log = _prefixId.prefix "log"
    /// <summary>
    ///   <para>rdfs:comment : acts as the
    ///       main content of the document. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#main">xhv:main</a>
    /// </summary>
    let main = _prefixId.prefix "main"
    /// <summary>
    ///   <para>rdfs:comment : A type
    ///       of live region where non-essential information changes frequently. Also
    ///       see log.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#marquee">xhv:marquee</a>
    /// </summary>
    let marquee = _prefixId.prefix "marquee"
    /// <summary>
    ///   <para>rdfs:comment : Content that
    ///       represents a mathematical expression. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#math">xhv:math</a>
    /// </summary>
    let math = _prefixId.prefix "math"
    /// <summary>
    ///   <para>rdfs:comment : A type of
    ///       widget that offers a list of choices to the user.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#menu">xhv:menu</a>
    /// </summary>
    let menu = _prefixId.prefix "menu"
    /// <summary>
    ///   <para>rdfs:comment : A presentation
    ///       of menu that usually remains visible and is usually presented horizontally.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#menubar">xhv:menubar</a>
    /// </summary>
    let menubar = _prefixId.prefix "menubar"
    /// <summary>
    ///   <para>rdfs:comment : An option
    ///       in a group of choices contained by a menu or menubar.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#menuitem">xhv:menuitem</a>
    /// </summary>
    let menuitem = _prefixId.prefix "menuitem"
    /// <summary>
    ///   <para>rdfs:comment : A
    ///       checkable menuitem that has three possible values: true, false, or mixed.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#menuitemcheckbox">xhv:menuitemcheckbox</a>
    /// </summary>
    let menuitemcheckbox = _prefixId.prefix "menuitemcheckbox"
    /// <summary>
    ///   <para>rdfs:comment : A
    ///       checkable menuitem in a group of menuitemradio roles, only one of which
    ///       can be checked at a time.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#menuitemradio">xhv:menuitemradio</a>
    /// </summary>
    let menuitemradio = _prefixId.prefix "menuitemradio"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#meta^^xsd:string</para>
    ///   <para>rdfa:term : meta^^xsd:string</para>
    ///   <para>rdfs:comment : meta refers to a resource that
    ///       provides metadata. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#meta">xhv:meta</a>
    /// </summary>
    let meta = _prefixId.prefix "meta"
    /// <summary>
    ///   <para>rdfs:comment : indicates a collection of items suitable for
    ///       navigating the document or related documents.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#navigation">xhv:navigation</a>
    /// </summary>
    let navigation = _prefixId.prefix "navigation"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#next^^xsd:string</para>
    ///   <para>rdfa:term : next^^xsd:string</para>
    ///   <para>rdfs:comment : next refers to the next resource
    ///       (after the current one) in an ordered collection of resources. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#next">xhv:next</a>
    /// </summary>
    let next = _prefixId.prefix "next"
    /// <summary>
    ///   <para>rdfs:comment : indicates
    ///       the content is parenthetic or ancillary to the main content of the
    ///       resource. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#note">xhv:note</a>
    /// </summary>
    let note = _prefixId.prefix "note"
    /// <summary>
    ///   <para>rdfs:comment : A selectable
    ///       item in a select list.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#option">xhv:option</a>
    /// </summary>
    let option = _prefixId.prefix "option"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#p3pv1^^xsd:string</para>
    ///   <para>rdfa:term : p3pv1^^xsd:string</para>
    ///   <para>rdfs:comment : p3pv1 refers to a P3P Policy Reference
    ///       File [P3P]. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#p3pv1">xhv:p3pv1</a>
    /// </summary>
    let p3pv1 = _prefixId.prefix "p3pv1"
    /// <summary>
    ///   <para>rdfs:comment : An
    ///       element whose implicit native role semantics will not be mapped to the
    ///       accessibility API.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#presentation">xhv:presentation</a>
    /// </summary>
    let presentation = _prefixId.prefix "presentation"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#prev^^xsd:string</para>
    ///   <para>rdfa:term : prev^^xsd:string</para>
    ///   <para>rdfs:comment : prev refers to a previous resource
    ///       (before the current one) in an ordered collection of resources. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#prev">xhv:prev</a>
    /// </summary>
    let prev = _prefixId.prefix "prev"
    /// <summary>
    ///   <para>rdfs:comment : An
    ///       element that displays the progress status for tasks that take a long time.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#progressbar">xhv:progressbar</a>
    /// </summary>
    let progressbar = _prefixId.prefix "progressbar"
    /// <summary>
    ///   <para>rdfs:comment : A checkable
    ///       input in a group of radio roles, only one of which can be checked at a
    ///       time.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#radio">xhv:radio</a>
    /// </summary>
    let radio = _prefixId.prefix "radio"
    /// <summary>
    ///   <para>rdfs:comment : A group
    ///       of radio buttons.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#radiogroup">xhv:radiogroup</a>
    /// </summary>
    let radiogroup = _prefixId.prefix "radiogroup"
    /// <summary>
    ///   <para>rdfs:comment : A large
    ///       perceivable section of a web page or document, that the author feels is
    ///       important enough to be included in a page summary or table of contents,
    ///       for example, an area of the page containing live sporting event statistics.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#region">xhv:region</a>
    /// </summary>
    let region = _prefixId.prefix "region"
    let relrev_properties = _prefixId.prefix "relrev-properties"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#role^^xsd:string</para>
    ///   <para>rdfa:term : role^^xsd:string</para>
    ///   <para>rdfs:comment : role indicates the purpose of the
    ///       resource. See the XHTML Role
    ///       Vocabulary for roles in this vocabulary space, and XHTMLROLE for information on extending the
    ///       collection of roles. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#role">xhv:role</a>
    /// </summary>
    let role = _prefixId.prefix "role"
    let role_properties = _prefixId.prefix "role-properties"
    /// <summary>
    ///   <para>rdfs:comment : A row of cells
    ///       in a grid.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#row">xhv:row</a>
    /// </summary>
    let row = _prefixId.prefix "row"
    /// <summary>
    ///   <para>rdfs:comment : A group
    ///       containing one or more row elements in a grid.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#rowgroup">xhv:rowgroup</a>
    /// </summary>
    let rowgroup = _prefixId.prefix "rowgroup"
    /// <summary>
    ///   <para>rdfs:comment : A cell
    ///       containing header information for a row in a grid.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#rowheader">xhv:rowheader</a>
    /// </summary>
    let rowheader = _prefixId.prefix "rowheader"
    /// <summary>
    ///   <para>rdfs:comment : A graphical
    ///       object that controls the scrolling of content within a viewing area, regardless
    ///       of whether the content is fully displayed within the viewing area.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#scrollbar">xhv:scrollbar</a>
    /// </summary>
    let scrollbar = _prefixId.prefix "scrollbar"
    /// <summary>
    ///   <para>rdfs:comment : indicates
    ///       that the section provides a search facility. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#search">xhv:search</a>
    /// </summary>
    let search = _prefixId.prefix "search"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#section^^xsd:string</para>
    ///   <para>rdfa:term : section^^xsd:string</para>
    ///   <para>rdfs:comment : section refers to a resource serving
    ///       as a section in a collection. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#section">xhv:section</a>
    /// </summary>
    let section = _prefixId.prefix "section"
    /// <summary>
    ///   <para>rdfs:comment : A divider
    ///       that separates and distinguishes sections of content or groups of menuitems.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#separator">xhv:separator</a>
    /// </summary>
    let separator = _prefixId.prefix "separator"
    /// <summary>
    ///   <para>rdfs:comment : A user
    ///       input where the user selects a value from within a given range.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#slider">xhv:slider</a>
    /// </summary>
    let slider = _prefixId.prefix "slider"
    /// <summary>
    ///   <para>rdfs:comment : A form
    ///       of range that expects a user to select from amongst discrete choices.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#spinbutton">xhv:spinbutton</a>
    /// </summary>
    let spinbutton = _prefixId.prefix "spinbutton"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#start^^xsd:string</para>
    ///   <para>rdfa:term : start^^xsd:string</para>
    ///   <para>rdfs:comment : start refers to the first resource in
    ///       a collection of resources. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#start">xhv:start</a>
    /// </summary>
    let start = _prefixId.prefix "start"
    /// <summary>
    ///   <para>rdfs:comment : A container
    ///       whose content is advisory information for the user but is not important
    ///       enough to justify an alert. Also see alert.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#status">xhv:status</a>
    /// </summary>
    let status = _prefixId.prefix "status"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#stylesheet^^xsd:string</para>
    ///   <para>rdfa:term : stylesheet^^xsd:string</para>
    ///   <para>rdfs:comment : stylesheet refers to a resource
    ///       serving as a stylesheet for a resource. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#stylesheet">xhv:stylesheet</a>
    /// </summary>
    let stylesheet = _prefixId.prefix "stylesheet"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#subsection^^xsd:string</para>
    ///   <para>rdfa:term : subsection^^xsd:string</para>
    ///   <para>rdfs:comment : subsection refers to a resource
    ///       serving as a subsection in a collection. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#subsection">xhv:subsection</a>
    /// </summary>
    let subsection = _prefixId.prefix "subsection"
    /// <summary>
    ///   <para>rdfs:comment : A grouping
    ///       label providing a mechanism for selecting the tab content that is to be
    ///       rendered to the user.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#tab">xhv:tab</a>
    /// </summary>
    let tab = _prefixId.prefix "tab"
    /// <summary>
    ///   <para>rdfs:comment : A list
    ///       of tab elements, which are references to tabpanel elements.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#tablist">xhv:tablist</a>
    /// </summary>
    let tablist = _prefixId.prefix "tablist"
    /// <summary>
    ///   <para>rdfs:comment : A container
    ///       for the resources associated with a tab, where each tab is contained in
    ///       a tablist.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#tabpanel">xhv:tabpanel</a>
    /// </summary>
    let tabpanel = _prefixId.prefix "tabpanel"
    /// <summary>
    ///   <para>rdfs:comment : Input
    ///       that allows free-form text as its value.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#textbox">xhv:textbox</a>
    /// </summary>
    let textbox = _prefixId.prefix "textbox"
    /// <summary>
    ///   <para>rdfs:comment : A type of
    ///       live region containing a numerical counter which indicates an amount of
    ///       elapsed time from a start point, or the time remaining until an end point.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#timer">xhv:timer</a>
    /// </summary>
    let timer = _prefixId.prefix "timer"
    /// <summary>
    ///   <para>rdfs:comment : A collection
    ///       of commonly used function buttons represented in compact visual form.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#toolbar">xhv:toolbar</a>
    /// </summary>
    let toolbar = _prefixId.prefix "toolbar"
    /// <summary>
    ///   <para>rdfs:comment : A contextual
    ///       popup that displays a description for an element.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#tooltip">xhv:tooltip</a>
    /// </summary>
    let tooltip = _prefixId.prefix "tooltip"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#top^^xsd:string</para>
    ///   <para>rdfa:term : top^^xsd:string</para>
    ///   <para>rdfs:comment : top is a synonym for start. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#top">xhv:top</a>
    /// </summary>
    let top = _prefixId.prefix "top"
    /// <summary>
    ///   <para>rdfs:comment : A type of
    ///       list that may contain sub-level nested groups that can be collapsed and
    ///       expanded.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#tree">xhv:tree</a>
    /// </summary>
    let tree = _prefixId.prefix "tree"
    /// <summary>
    ///   <para>rdfs:comment : A grid
    ///       whose rows can be expanded and collapsed in the same manner as for a tree.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#treegrid">xhv:treegrid</a>
    /// </summary>
    let treegrid = _prefixId.prefix "treegrid"
    /// <summary>
    ///   <para>rdfs:comment : An option
    ///       item of a tree. This is an element within a tree that may be expanded or
    ///       collapsed if it contains a sub-level group of treeitems.^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#treeitem">xhv:treeitem</a>
    /// </summary>
    let treeitem = _prefixId.prefix "treeitem"
    /// <summary>
    ///   <para>rdfa:uri : http://www.w3.org/1999/xhtml/vocab#up^^xsd:string</para>
    ///   <para>rdfa:term : up^^xsd:string</para>
    ///   <para>rdfs:comment : up refers to a resource "above" in a
    ///       hierarchically structured set. ^^xsd:string</para>
    ///   <a href="http://www.w3.org/1999/xhtml/vocab#up">xhv:up</a>
    /// </summary>
    let up = _prefixId.prefix "up"
