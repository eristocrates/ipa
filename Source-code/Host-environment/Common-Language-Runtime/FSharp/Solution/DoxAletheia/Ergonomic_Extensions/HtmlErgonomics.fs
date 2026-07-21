module DoxAletheia.HtmlErgonomics
open System.IO


open FSharp.Data


open FSharp.ViewEngine




open Fss
open Fss.Types





[<RequireQualifiedAccessAttribute>]
type Html_Tag =
    | A
    | Abbr
    | Acronym
    | Address
    | Area
    | Article
    | Aside
    | Audio
    | B
    | Base
    | Bdi
    | Bdo
    | Big
    | Blockquote
    | Body
    | Br
    | Button
    | Canvas
    | Caption
    | Center
    | Cite
    | Code
    | Col
    | Colgroup
    | Data
    | Datalist
    | Dd
    | Del
    | Details
    | Dfn
    | Dialog
    | Dir
    | Div
    | Dl
    | Dt
    | Em
    | Embed
    | Fencedframe
    | Fieldset
    | Figcaption
    | Figure
    | Font
    | Footer
    | Form
    | Frame
    | Frameset
    | Geolocation
    | H1
    | H2
    | H3
    | H4
    | H5
    | H6
    | Head
    | Header
    | Hgroup
    | Hr
    | Html
    | I
    | Iframe
    | Img
    | Input
    | Ins
    | Kbd
    | Label
    | Legend
    | Li
    | Link
    | Main
    | Map
    | Mark
    | Marquee
    | Menu
    | Meta
    | Meter
    | Nav
    | Nobr
    | Noembed
    | Noframes
    | Noscript
    | Object
    | Ol
    | Optgroup
    | Option
    | Output
    | P
    | Param
    | Picture
    | Plaintext
    | Portal
    | Pre
    | Progress
    | Q
    | Rb
    | Rp
    | Rt
    | Rtc
    | Ruby
    | S
    | Samp
    | Script
    | Search
    | Section
    | Select
    | Selectedcontent
    | Slot
    | Small
    | Source
    | Span
    | Strike
    | Strong
    | Style
    | Sub
    | Summary
    | Sup
    | Table
    | Tbody
    | Td
    | Template
    | Textarea
    | Tfoot
    | Th
    | Thead
    | Time
    | Title
    | Tr
    | Track
    | Tt
    | U
    | Ul
    | Var
    | Video
    | Wbr
    | Xmp
    static member toDocString(html_element: HtmlElement) = Render.toHtmlDocString html_element

    static member toDocument(html_element: HtmlElement) =
        Render.toHtmlDocString html_element
        |> HtmlDocument.Parse

    static member toFormattedDocString(html_element: HtmlElement) =
        let document =
            Render.toHtmlDocString html_element
            |> HtmlDocument.Parse

        document.ToString()

    member this.Stringify() =

        match this with
        | A -> "a"
        | Abbr -> "abbr"
        | Acronym -> "acronym"
        | Address -> "address"
        | Area -> "area"
        | Article -> "article"
        | Aside -> "aside"
        | Audio -> "audio"
        | B -> "b"
        | Base -> "base"
        | Bdi -> "bdi"
        | Bdo -> "bdo"
        | Big -> "big"
        | Blockquote -> "blockquote"
        | Body -> "body"
        | Br -> "br"
        | Button -> "button"
        | Canvas -> "canvas"
        | Caption -> "caption"
        | Center -> "center"
        | Cite -> "cite"
        | Code -> "code"
        | Col -> "col"
        | Colgroup -> "colgroup"
        | Data -> "data"
        | Datalist -> "datalist"
        | Dd -> "dd"
        | Del -> "del"
        | Details -> "details"
        | Dfn -> "dfn"
        | Dialog -> "dialog"
        | Dir -> "dir"
        | Div -> "div"
        | Dl -> "dl"
        | Dt -> "dt"
        | Em -> "em"
        | Embed -> "embed"
        | Fencedframe -> "fencedframe"
        | Fieldset -> "fieldset"
        | Figcaption -> "figcaption"
        | Figure -> "figure"
        | Font -> "font"
        | Footer -> "footer"
        | Form -> "form"
        | Frame -> "frame"
        | Frameset -> "frameset"
        | Geolocation -> "geolocation"
        | H1 -> "h1"
        | H2 -> "h2"
        | H3 -> "h3"
        | H4 -> "h4"
        | H5 -> "h5"
        | H6 -> "h6"
        | Head -> "head"
        | Header -> "header"
        | Hgroup -> "hgroup"
        | Hr -> "hr"
        | Html -> "html"
        | I -> "i"
        | Iframe -> "iframe"
        | Img -> "img"
        | Input -> "input"
        | Ins -> "ins"
        | Kbd -> "kbd"
        | Label -> "label"
        | Legend -> "legend"
        | Li -> "li"
        | Link -> "link"
        | Main -> "main"
        | Map -> "map"
        | Mark -> "mark"
        | Marquee -> "marquee"
        | Menu -> "menu"
        | Meta -> "meta"
        | Meter -> "meter"
        | Nav -> "nav"
        | Nobr -> "nobr"
        | Noembed -> "noembed"
        | Noframes -> "noframes"
        | Noscript -> "noscript"
        | Object -> "object"
        | Ol -> "ol"
        | Optgroup -> "optgroup"
        | Option -> "option"
        | Output -> "output"
        | P -> "p"
        | Param -> "param"
        | Picture -> "picture"
        | Plaintext -> "plaintext"
        | Portal -> "portal"
        | Pre -> "pre"
        | Progress -> "progress"
        | Q -> "q"
        | Rb -> "rb"
        | Rp -> "rp"
        | Rt -> "rt"
        | Rtc -> "rtc"
        | Ruby -> "ruby"
        | S -> "s"
        | Samp -> "samp"
        | Script -> "script"
        | Search -> "search"
        | Section -> "section"
        | Select -> "select"
        | Selectedcontent -> "selectedcontent"
        | Slot -> "slot"
        | Small -> "small"
        | Source -> "source"
        | Span -> "span"
        | Strike -> "strike"
        | Strong -> "strong"
        | Style -> "style"
        | Sub -> "sub"
        | Summary -> "summary"
        | Sup -> "sup"
        | Table -> "table"
        | Tbody -> "tbody"
        | Td -> "td"
        | Template -> "template"
        | Textarea -> "textarea"
        | Tfoot -> "tfoot"
        | Th -> "th"
        | Thead -> "thead"
        | Time -> "time"
        | Title -> "title"
        | Tr -> "tr"
        | Track -> "track"
        | Tt -> "tt"
        | U -> "u"
        | Ul -> "ul"
        | Var -> "var"
        | Video -> "video"
        | Wbr -> "wbr"
        | Xmp -> "xmp"


    static member val EmptyAttr = { Name = null; Value = ValueNone }
    static member val empty = NoopElement() :> HtmlElement
    static member raw(v: string) = RawElement(v) :> HtmlElement
    static member js(v: string) = RawElement(v) :> HtmlElement
    static member text(v: string) = TextElement(v) :> HtmlElement
    static member el(name: string) = TagBuilder(name)
    static member elVoid(name: string) = VoidBuilder(name)

    static member val html = TagBuilder("html")
    static member val head = TagBuilder("head")

    static member title(value: string) =
        let el = RegularElement("title")
        el.AddChild(TextElement(value) :> HtmlElement)
        el :> HtmlElement

    static member val script = TagBuilder("script")
    static member val body = TagBuilder("body")
    static member val main = TagBuilder("main")
    static member val header = TagBuilder("header")
    static member val footer = TagBuilder("footer")
    static member val nav = TagBuilder("nav")
    static member val h1 = TagBuilder("h1")
    static member val h2 = TagBuilder("h2")
    static member val h3 = TagBuilder("h3")
    static member val h4 = TagBuilder("h4")
    static member val h5 = TagBuilder("h5")
    static member val h6 = TagBuilder("h6")
    static member val div = TagBuilder("div")
    static member val p = TagBuilder("p")
    static member val span = TagBuilder("span")
    static member val anchor = TagBuilder("a")
    static member val button = TagBuilder("button")
    static member val code = TagBuilder("code")
    static member val pre = TagBuilder("pre")
    static member val ul = TagBuilder("ul")
    static member val ol = TagBuilder("ol")
    static member val li = TagBuilder("li")
    static member val blockquote = TagBuilder("blockquote")
    static member val article = TagBuilder("article")
    static member val dialog = TagBuilder("dialog")
    static member val time = TagBuilder("time")
    static member val form = TagBuilder("form")
    static member val label = TagBuilder("label")
    static member val textarea = TagBuilder("textarea")
    static member val select = TagBuilder("select")
    static member val option = TagBuilder("option")
    static member val table = TagBuilder("table")
    static member val thead = TagBuilder("thead")
    static member val tr = TagBuilder("tr")
    static member val th = TagBuilder("th")
    static member val tbody = TagBuilder("tbody")
    static member val td = TagBuilder("td")
    static member val dl = TagBuilder("dl")
    static member val dt = TagBuilder("dt")
    static member val dd = TagBuilder("dd")
    static member val template = TagBuilder("template")
    static member val iframe = TagBuilder("iframe")
    static member val section = TagBuilder("section")
    static member val aside = TagBuilder("aside")
    static member val figure = TagBuilder("figure")
    static member val figcaption = TagBuilder("figcaption")
    static member val details = TagBuilder("details")
    static member val summary = TagBuilder("summary")
    static member val strong = TagBuilder("strong")
    static member val em = TagBuilder("em")
    static member val b = TagBuilder("b")
    static member val i = TagBuilder("i")
    static member val u = TagBuilder("u")
    static member val s = TagBuilder("s")
    static member val small = TagBuilder("small")
    static member val mark = TagBuilder("mark")
    static member val sub = TagBuilder("sub")
    static member val sup = TagBuilder("sup")
    static member val abbr = TagBuilder("abbr")
    static member val cite = TagBuilder("cite")
    static member val q = TagBuilder("q")
    static member val dfn = TagBuilder("dfn")
    static member val var = TagBuilder("var")
    static member val samp = TagBuilder("samp")
    static member val kbd = TagBuilder("kbd")
    static member val ins = TagBuilder("ins")
    static member val del = TagBuilder("del")
    static member val address = TagBuilder("address")
    static member val hgroup = TagBuilder("hgroup")
    static member val search = TagBuilder("search")
    static member val noscript = TagBuilder("noscript")
    static member val slot = TagBuilder("slot")
    static member val data = TagBuilder("data")
    static member val video = TagBuilder("video")
    static member val audio = TagBuilder("audio")
    static member val picture = TagBuilder("picture")
    static member val canvas = TagBuilder("canvas")
    static member val object = TagBuilder("object")
    static member val fieldset = TagBuilder("fieldset")
    static member val legend = TagBuilder("legend")
    static member val datalist = TagBuilder("datalist")
    static member val output = TagBuilder("output")
    static member val progress = TagBuilder("progress")
    static member val meter = TagBuilder("meter")
    static member val caption = TagBuilder("caption")
    static member val colgroup = TagBuilder("colgroup")
    static member val tfoot = TagBuilder("tfoot")
    static member val map = TagBuilder("map")
    static member val ruby = TagBuilder("ruby")
    static member val rt = TagBuilder("rt")
    static member val rp = TagBuilder("rp")
    static member val bdi = TagBuilder("bdi")
    static member val bdo = TagBuilder("bdo")
    static member val optgroup = TagBuilder("optgroup")
    static member val menu = TagBuilder("menu")
    static member val portal = TagBuilder("portal")
    static member val style = TagBuilder("style")
    static member val br = VoidElement("br") :> HtmlElement
    static member val hr = VoidElement("hr") :> HtmlElement
    static member val wbr = VoidElement("wbr") :> HtmlElement
    static member val meta = VoidBuilder("meta")
    static member val link = VoidBuilder("link")
    static member val img = VoidBuilder("img")
    static member val input = VoidBuilder("input")
    static member val source = VoidBuilder("source")
    static member val track = VoidBuilder("track")
    static member val col = VoidBuilder("col")
    static member val area = VoidBuilder("area")
    static member val embed = VoidBuilder("embed")
    static member val ``base`` = VoidBuilder("base")

    // Custom attributes
    static member inline _attr(name: string) = { Name = name; Value = ValueNone }
    static member inline _attr(name: string, v: string) = { Name = name; Value = ValueSome v }

    // Global attributes
    static member inline _id(v: string) = { Name = "id"; Value = ValueSome v }
    static member inline _class(v: string) = { Name = "class"; Value = ValueSome v }

    static member inline _class(v: string seq) =
        { Name = "class"
          Value = ValueSome(v |> String.concat " ") }

    static member inline _style(v: string) = { Name = "style"; Value = ValueSome v }
    static member inline _title(v: string) = { Name = "title"; Value = ValueSome v }
    static member inline _lang(v: string) = { Name = "lang"; Value = ValueSome v }
    static member inline _dir(v: string) = { Name = "dir"; Value = ValueSome v }

    static member inline _hidden(v: bool) =
        if v then
            { Name = "hidden"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _tabindex(v: int) =
        { Name = "tabindex"
          Value = ValueSome(string v) }

    static member inline _accesskey(v: string) =
        { Name = "accesskey"
          Value = ValueSome v }

    static member inline _translate(v: bool) =
        { Name = "translate"
          Value = ValueSome(if v then "yes" else "no") }

    static member inline _spellcheck(v: bool) =
        { Name = "spellcheck"
          Value = ValueSome(if v then "true" else "false") }

    static member inline _draggable(v: bool) =
        { Name = "draggable"
          Value = ValueSome(if v then "true" else "false") }

    static member inline _contenteditable(v: bool) =
        { Name = "contenteditable"
          Value = ValueSome(if v then "true" else "false") }

    static member inline _autofocus(v: bool) =
        if v then
            { Name = "autofocus"
              Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _inert(v: bool) =
        if v then
            { Name = "inert"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _inputmode(v: string) =
        { Name = "inputmode"
          Value = ValueSome v }

    static member inline _enterkeyhint(v: string) =
        { Name = "enterkeyhint"
          Value = ValueSome v }

    static member inline _is(v: string) = { Name = "is"; Value = ValueSome v }
    static member inline _slot(v: string) = { Name = "slot"; Value = ValueSome v }
    static member inline _part(v: string) = { Name = "part"; Value = ValueSome v }
    static member inline _nonce(v: string) = { Name = "nonce"; Value = ValueSome v }

    static member inline _popover(v: string) =
        { Name = "popover"
          Value = ValueSome v }

    static member inline _data(attr: string, ?v: string) =
        let key = $"data-{attr}"

        match v with
        | Some v -> { Name = key; Value = ValueSome v }
        | None -> { Name = key; Value = ValueNone }

    // Document and meta attributes
    static member inline _charset(v: string) =
        { Name = "charset"
          Value = ValueSome v }

    static member inline _name(v: string) = { Name = "name"; Value = ValueSome v }

    static member inline _content(v: string) =
        { Name = "content"
          Value = ValueSome v }

    static member inline _property(v: string) =
        { Name = "property"
          Value = ValueSome v }

    // Link and resource attributes
    static member inline _href(v: string) = { Name = "href"; Value = ValueSome v }
    static member inline _rel(v: string) = { Name = "rel"; Value = ValueSome v }
    static member inline _src(v: string) = { Name = "src"; Value = ValueSome v }

    static member inline _srcset(v: string) =
        { Name = "srcset"; Value = ValueSome v }

    static member inline _sizes(v: string) = { Name = "sizes"; Value = ValueSome v }
    static member inline _media(v: string) = { Name = "media"; Value = ValueSome v }
    static member inline _type(v: string) = { Name = "type"; Value = ValueSome v }

    static member inline _target(v: string) =
        { Name = "target"; Value = ValueSome v }

    static member inline _download(v: string) =
        { Name = "download"
          Value = ValueSome v }

    static member inline _download() =
        { Name = "download"; Value = ValueNone }

    static member inline _referrerpolicy(v: string) =
        { Name = "referrerpolicy"
          Value = ValueSome v }

    static member inline _crossorigin =
        { Name = "crossorigin"
          Value = ValueNone }

    static member inline _integrity(v: string) =
        { Name = "integrity"
          Value = ValueSome v }

    static member inline _fetchpriority(v: string) =
        { Name = "fetchpriority"
          Value = ValueSome v }

    static member inline _async(v: bool) =
        if v then
            { Name = "async"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _defer(v: bool) =
        if v then
            { Name = "defer"; Value = ValueNone }
        else
            Html.EmptyAttr

    // Image and media attributes
    static member inline _alt(v: string) = { Name = "alt"; Value = ValueSome v }
    static member inline _width(v: string) = { Name = "width"; Value = ValueSome v }

    static member inline _height(v: string) =
        { Name = "height"; Value = ValueSome v }

    static member inline _loading(v: string) =
        { Name = "loading"
          Value = ValueSome v }

    static member inline _decoding(v: string) =
        { Name = "decoding"
          Value = ValueSome v }

    static member inline _usemap(v: string) =
        { Name = "usemap"; Value = ValueSome v }

    static member inline _ismap(v: bool) =
        if v then
            { Name = "ismap"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _poster(v: string) =
        { Name = "poster"; Value = ValueSome v }

    static member inline _controls(v: bool) =
        if v then
            { Name = "controls"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _autoplay(v: bool) =
        if v then
            { Name = "autoplay"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _loop(v: bool) =
        if v then
            { Name = "loop"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _muted(v: bool) =
        if v then
            { Name = "muted"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _preload(v: string) =
        { Name = "preload"
          Value = ValueSome v }

    static member inline _kind(v: string) = { Name = "kind"; Value = ValueSome v }

    static member inline _srclang(v: string) =
        { Name = "srclang"
          Value = ValueSome v }

    static member inline _label(v: string) = { Name = "label"; Value = ValueSome v }

    static member inline _default(v: bool) =
        if v then
            { Name = "default"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _coords(v: string) =
        { Name = "coords"; Value = ValueSome v }

    static member inline _shape(v: string) = { Name = "shape"; Value = ValueSome v }

    // Form attributes
    static member inline _action(v: string) =
        { Name = "action"; Value = ValueSome v }

    static member inline _method(v: string) =
        { Name = "method"; Value = ValueSome v }

    static member inline _enctype(v: string) =
        { Name = "enctype"
          Value = ValueSome v }

    static member inline _novalidate(v: bool) =
        if v then
            { Name = "novalidate"
              Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _for(v: string) = { Name = "for"; Value = ValueSome v }
    static member inline _value(v: string) = { Name = "value"; Value = ValueSome v }

    static member inline _placeholder(v: string) =
        { Name = "placeholder"
          Value = ValueSome v }

    static member inline _autocomplete(v: string) =
        { Name = "autocomplete"
          Value = ValueSome v }

    static member inline _pattern(v: string) =
        { Name = "pattern"
          Value = ValueSome v }

    static member inline _accept(v: string) =
        { Name = "accept"; Value = ValueSome v }

    static member inline _required(v: bool) =
        if v then
            { Name = "required"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _disabled(v: bool) =
        if v then
            { Name = "disabled"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _readonly(v: bool) =
        if v then
            { Name = "readonly"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _multiple(v: bool) =
        if v then
            { Name = "multiple"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _selected(v: bool) =
        if v then
            { Name = "selected"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _checked(v: bool) =
        if v then
            { Name = "checked"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _rows(v: int) =
        { Name = "rows"
          Value = ValueSome(string v) }

    static member inline _cols(v: int) =
        { Name = "cols"
          Value = ValueSome(string v) }

    static member inline _wrap(v: string) = { Name = "wrap"; Value = ValueSome v }

    static member inline _size(v: int) =
        { Name = "size"
          Value = ValueSome(string v) }

    static member inline _list(v: string) = { Name = "list"; Value = ValueSome v }

    static member inline _dirname(v: string) =
        { Name = "dirname"
          Value = ValueSome v }

    static member inline _min(v: string) = { Name = "min"; Value = ValueSome v }

    static member inline _min(v: float) =
        { Name = "min"
          Value = ValueSome(string v) }

    static member inline _minlength(v: string) =
        { Name = "minlength"
          Value = ValueSome v }

    static member inline _minlength(v: int) =
        { Name = "minlength"
          Value = ValueSome(string v) }

    static member inline _max(v: string) = { Name = "max"; Value = ValueSome v }

    static member inline _max(v: float) =
        { Name = "max"
          Value = ValueSome(string v) }

    static member inline _maxlength(v: string) =
        { Name = "maxlength"
          Value = ValueSome v }

    static member inline _maxlength(v: int) =
        { Name = "maxlength"
          Value = ValueSome(string v) }

    static member inline _step(v: string) = { Name = "step"; Value = ValueSome v }

    static member inline _step(v: float) =
        { Name = "step"
          Value = ValueSome(string v) }

    static member inline _form(v: string) = { Name = "form"; Value = ValueSome v }

    static member inline _formaction(v: string) =
        { Name = "formaction"
          Value = ValueSome v }

    static member inline _formmethod(v: string) =
        { Name = "formmethod"
          Value = ValueSome v }

    static member inline _formenctype(v: string) =
        { Name = "formenctype"
          Value = ValueSome v }

    static member inline _formnovalidate(v: bool) =
        if v then
            { Name = "formnovalidate"
              Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _formtarget(v: string) =
        { Name = "formtarget"
          Value = ValueSome v }

    static member inline _popovertarget(v: string) =
        { Name = "popovertarget"
          Value = ValueSome v }

    static member inline _popovertargetaction(v: string) =
        { Name = "popovertargetaction"
          Value = ValueSome v }

    // Table attributes
    static member inline _colspan(v: int) =
        { Name = "colspan"
          Value = ValueSome(string v) }

    static member inline _rowspan(v: int) =
        { Name = "rowspan"
          Value = ValueSome(string v) }

    static member inline _scope(v: string) = { Name = "scope"; Value = ValueSome v }

    static member inline _headers(v: string) =
        { Name = "headers"
          Value = ValueSome v }

    // Details and dialog attributes
    static member inline _open(v: bool) =
        if v then
            { Name = "open"; Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _cite(v: string) = { Name = "cite"; Value = ValueSome v }

    static member inline _datetime(v: string) =
        { Name = "datetime"
          Value = ValueSome v }

    // List attributes
    static member inline _start(v: int) =
        { Name = "start"
          Value = ValueSome(string v) }

    static member inline _reversed(v: bool) =
        if v then
            { Name = "reversed"; Value = ValueNone }
        else
            Html.EmptyAttr

    // Meter attributes
    static member inline _high(v: float) =
        { Name = "high"
          Value = ValueSome(string v) }

    static member inline _low(v: float) =
        { Name = "low"
          Value = ValueSome(string v) }

    static member inline _optimum(v: float) =
        { Name = "optimum"
          Value = ValueSome(string v) }

    // Iframe attributes
    static member inline _sandbox(v: string) =
        { Name = "sandbox"
          Value = ValueSome v }

    static member inline _allow(v: string) = { Name = "allow"; Value = ValueSome v }

    // Microdata attributes
    static member inline _itemscope(v: bool) =
        if v then
            { Name = "itemscope"
              Value = ValueNone }
        else
            Html.EmptyAttr

    static member inline _itemtype(v: string) =
        { Name = "itemtype"
          Value = ValueSome v }

    static member inline _itemprop(v: string) =
        { Name = "itemprop"
          Value = ValueSome v }

    static member inline _itemid(v: string) =
        { Name = "itemid"; Value = ValueSome v }

    static member inline _itemref(v: string) =
        { Name = "itemref"
          Value = ValueSome v }

    // ARIA attributes
    static member inline _role(v: string) = { Name = "role"; Value = ValueSome v }

    static member inline _ariaLabel(v: string) =
        { Name = "aria-label"
          Value = ValueSome v }

    static member inline _ariaLabelledby(v: string) =
        { Name = "aria-labelledby"
          Value = ValueSome v }

    static member inline _ariaDescribedby(v: string) =
        { Name = "aria-describedby"
          Value = ValueSome v }

    static member inline _ariaHidden(v: string) =
        { Name = "aria-hidden"
          Value = ValueSome v }

    static member inline _ariaExpanded(v: string) =
        { Name = "aria-expanded"
          Value = ValueSome v }

    static member inline _ariaControls(v: string) =
        { Name = "aria-controls"
          Value = ValueSome v }

    static member inline _ariaLive(v: string) =
        { Name = "aria-live"
          Value = ValueSome v }

    static member inline _ariaCurrent(v: string) =
        { Name = "aria-current"
          Value = ValueSome v }

    static member inline _ariaModal(v: string) =
        { Name = "aria-modal"
          Value = ValueSome v }

    static member inline _ariaDisabled(v: string) =
        { Name = "aria-disabled"
          Value = ValueSome v }

    static member inline _ariaSelected(v: string) =
        { Name = "aria-selected"
          Value = ValueSome v }

    static member inline _ariaChecked(v: string) =
        { Name = "aria-checked"
          Value = ValueSome v }

    static member inline _ariaRequired(v: string) =
        { Name = "aria-required"
          Value = ValueSome v }

    static member inline _ariaInvalid(v: string) =
        { Name = "aria-invalid"
          Value = ValueSome v }

    static member inline _ariaHaspopup(v: string) =
        { Name = "aria-haspopup"
          Value = ValueSome v }

    static member inline _ariaPressed(v: string) =
        { Name = "aria-pressed"
          Value = ValueSome v }

    static member inline _ariaValuenow(v: string) =
        { Name = "aria-valuenow"
          Value = ValueSome v }

    static member inline _ariaValuemin(v: string) =
        { Name = "aria-valuemin"
          Value = ValueSome v }

    static member inline _ariaValuemax(v: string) =
        { Name = "aria-valuemax"
          Value = ValueSome v }

    static member inline _ariaValuetext(v: string) =
        { Name = "aria-valuetext"
          Value = ValueSome v }

    static member inline _ariaAtomic(v: string) =
        { Name = "aria-atomic"
          Value = ValueSome v }

    static member inline _ariaBusy(v: string) =
        { Name = "aria-busy"
          Value = ValueSome v }

    static member inline _ariaPlaceholder(v: string) =
        { Name = "aria-placeholder"
          Value = ValueSome v }

    static member inline _ariaRoledescription(v: string) =
        { Name = "aria-roledescription"
          Value = ValueSome v }

    // Event handler attributes
    static member inline _onclick(v: string) =
        { Name = "onclick"
          Value = ValueSome v }

    static member inline _ondblclick(v: string) =
        { Name = "ondblclick"
          Value = ValueSome v }

    static member inline _onchange(v: string) =
        { Name = "onchange"
          Value = ValueSome v }

    static member inline _oninput(v: string) =
        { Name = "oninput"
          Value = ValueSome v }

    static member inline _onbeforeinput(v: string) =
        { Name = "onbeforeinput"
          Value = ValueSome v }

    static member inline _onsubmit(v: string) =
        { Name = "onsubmit"
          Value = ValueSome v }

    static member inline _onreset(v: string) =
        { Name = "onreset"
          Value = ValueSome v }

    static member inline _oninvalid(v: string) =
        { Name = "oninvalid"
          Value = ValueSome v }

    static member inline _onselect(v: string) =
        { Name = "onselect"
          Value = ValueSome v }

    static member inline _onfocus(v: string) =
        { Name = "onfocus"
          Value = ValueSome v }

    static member inline _onblur(v: string) =
        { Name = "onblur"; Value = ValueSome v }

    static member inline _onkeydown(v: string) =
        { Name = "onkeydown"
          Value = ValueSome v }

    static member inline _onkeyup(v: string) =
        { Name = "onkeyup"
          Value = ValueSome v }

    static member inline _onkeypress(v: string) =
        { Name = "onkeypress"
          Value = ValueSome v }

    static member inline _onmousedown(v: string) =
        { Name = "onmousedown"
          Value = ValueSome v }

    static member inline _onmouseup(v: string) =
        { Name = "onmouseup"
          Value = ValueSome v }

    static member inline _onmouseover(v: string) =
        { Name = "onmouseover"
          Value = ValueSome v }

    static member inline _onmouseout(v: string) =
        { Name = "onmouseout"
          Value = ValueSome v }

    static member inline _onmousemove(v: string) =
        { Name = "onmousemove"
          Value = ValueSome v }

    static member inline _onmouseenter(v: string) =
        { Name = "onmouseenter"
          Value = ValueSome v }

    static member inline _onmouseleave(v: string) =
        { Name = "onmouseleave"
          Value = ValueSome v }

    static member inline _oncontextmenu(v: string) =
        { Name = "oncontextmenu"
          Value = ValueSome v }

    static member inline _onwheel(v: string) =
        { Name = "onwheel"
          Value = ValueSome v }

    static member inline _onscroll(v: string) =
        { Name = "onscroll"
          Value = ValueSome v }

    static member inline _onresize(v: string) =
        { Name = "onresize"
          Value = ValueSome v }

    static member inline _oncopy(v: string) =
        { Name = "oncopy"; Value = ValueSome v }

    static member inline _oncut(v: string) = { Name = "oncut"; Value = ValueSome v }

    static member inline _onpaste(v: string) =
        { Name = "onpaste"
          Value = ValueSome v }

    static member inline _ondrag(v: string) =
        { Name = "ondrag"; Value = ValueSome v }

    static member inline _ondragstart(v: string) =
        { Name = "ondragstart"
          Value = ValueSome v }

    static member inline _ondragend(v: string) =
        { Name = "ondragend"
          Value = ValueSome v }

    static member inline _ondragover(v: string) =
        { Name = "ondragover"
          Value = ValueSome v }

    static member inline _ondragenter(v: string) =
        { Name = "ondragenter"
          Value = ValueSome v }

    static member inline _ondragleave(v: string) =
        { Name = "ondragleave"
          Value = ValueSome v }

    static member inline _ondrop(v: string) =
        { Name = "ondrop"; Value = ValueSome v }

    static member inline _ontouchstart(v: string) =
        { Name = "ontouchstart"
          Value = ValueSome v }

    static member inline _ontouchmove(v: string) =
        { Name = "ontouchmove"
          Value = ValueSome v }

    static member inline _ontouchend(v: string) =
        { Name = "ontouchend"
          Value = ValueSome v }

    static member inline _onanimationstart(v: string) =
        { Name = "onanimationstart"
          Value = ValueSome v }

    static member inline _onanimationend(v: string) =
        { Name = "onanimationend"
          Value = ValueSome v }

    static member inline _onanimationiteration(v: string) =
        { Name = "onanimationiteration"
          Value = ValueSome v }

    static member inline _ontransitionend(v: string) =
        { Name = "ontransitionend"
          Value = ValueSome v }

    static member inline _onload(v: string) =
        { Name = "onload"; Value = ValueSome v }

    static member inline _onerror(v: string) =
        { Name = "onerror"
          Value = ValueSome v }

    static member inline _onabort(v: string) =
        { Name = "onabort"
          Value = ValueSome v }

    static member inline _ontoggle(v: string) =
        { Name = "ontoggle"
          Value = ValueSome v }

    static member inline _onplay(v: string) =
        { Name = "onplay"; Value = ValueSome v }

    static member inline _onpause(v: string) =
        { Name = "onpause"
          Value = ValueSome v }

    static member inline _onended(v: string) =
        { Name = "onended"
          Value = ValueSome v }


[<RequireQualifiedAccess>]
type Selector =
    | Tag of Html_Tag
    | Id of string
    | Class of string
    static member stringify this =
        match this with
        | Tag tag -> tag.Stringify()
        | Id id -> $"#{id}"
        | Class class_ -> $".{class_}"

    static member html = Tag Html_Tag.Html
    static member head = Tag Html_Tag.Head
    static member title = Tag Html_Tag.Title
    static member script = Tag Html_Tag.Script
    static member body = Tag Html_Tag.Body
    static member main = Tag Html_Tag.Main
    static member header = Tag Html_Tag.Header
    static member footer = Tag Html_Tag.Footer
    static member nav = Tag Html_Tag.Nav
    static member h1 = Tag Html_Tag.H1
    static member h2 = Tag Html_Tag.H2
    static member h3 = Tag Html_Tag.H3
    static member h4 = Tag Html_Tag.H4
    static member h5 = Tag Html_Tag.H5
    static member h6 = Tag Html_Tag.H6
    static member div = Tag Html_Tag.Div
    static member p = Tag Html_Tag.P
    static member span = Tag Html_Tag.Span
    static member a = Tag Html_Tag.A
    static member button = Tag Html_Tag.Button
    static member code = Tag Html_Tag.Code
    static member pre = Tag Html_Tag.Pre
    static member ul = Tag Html_Tag.Ul
    static member ol = Tag Html_Tag.Ol
    static member li = Tag Html_Tag.Li
    static member blockquote = Tag Html_Tag.Blockquote
    static member article = Tag Html_Tag.Article
    static member dialog = Tag Html_Tag.Dialog
    static member time = Tag Html_Tag.Time
    static member form = Tag Html_Tag.Form
    static member label = Tag Html_Tag.Label
    static member textarea = Tag Html_Tag.Textarea
    static member select = Tag Html_Tag.Select
    static member option = Tag Html_Tag.Option
    static member table = Tag Html_Tag.Table
    static member thead = Tag Html_Tag.Thead
    static member tr = Tag Html_Tag.Tr
    static member th = Tag Html_Tag.Th
    static member tbody = Tag Html_Tag.Tbody
    static member td = Tag Html_Tag.Td
    static member dl = Tag Html_Tag.Dl
    static member dt = Tag Html_Tag.Dt
    static member dd = Tag Html_Tag.Dd
    static member template = Tag Html_Tag.Template
    static member iframe = Tag Html_Tag.Iframe
    static member section = Tag Html_Tag.Section
    static member aside = Tag Html_Tag.Aside
    static member figure = Tag Html_Tag.Figure
    static member figcaption = Tag Html_Tag.Figcaption
    static member details = Tag Html_Tag.Details
    static member summary = Tag Html_Tag.Summary
    static member strong = Tag Html_Tag.Strong
    static member em = Tag Html_Tag.Em
    static member b = Tag Html_Tag.B
    static member i = Tag Html_Tag.I
    static member u = Tag Html_Tag.U
    static member s = Tag Html_Tag.S
    static member small = Tag Html_Tag.Small
    static member mark = Tag Html_Tag.Mark
    static member sub = Tag Html_Tag.Sub
    static member sup = Tag Html_Tag.Sup
    static member abbr = Tag Html_Tag.Abbr
    static member cite = Tag Html_Tag.Cite
    static member q = Tag Html_Tag.Q
    static member dfn = Tag Html_Tag.Dfn
    static member var = Tag Html_Tag.Var
    static member samp = Tag Html_Tag.Samp
    static member kbd = Tag Html_Tag.Kbd
    static member ins = Tag Html_Tag.Ins
    static member del = Tag Html_Tag.Del
    static member address = Tag Html_Tag.Address
    static member hgroup = Tag Html_Tag.Hgroup
    static member search = Tag Html_Tag.Search
    static member noscript = Tag Html_Tag.Noscript
    static member slot = Tag Html_Tag.Slot
    static member data = Tag Html_Tag.Data
    static member video = Tag Html_Tag.Video
    static member audio = Tag Html_Tag.Audio
    static member picture = Tag Html_Tag.Picture
    static member canvas = Tag Html_Tag.Canvas
    static member object = Tag Html_Tag.Object
    static member fieldset = Tag Html_Tag.Fieldset
    static member legend = Tag Html_Tag.Legend
    static member datalist = Tag Html_Tag.Datalist
    static member output = Tag Html_Tag.Output
    static member progress = Tag Html_Tag.Progress
    static member meter = Tag Html_Tag.Meter
    static member caption = Tag Html_Tag.Caption
    static member colgroup = Tag Html_Tag.Colgroup
    static member tfoot = Tag Html_Tag.Tfoot
    static member map = Tag Html_Tag.Map
    static member ruby = Tag Html_Tag.Ruby
    static member rt = Tag Html_Tag.Rt
    static member rp = Tag Html_Tag.Rp
    static member bdi = Tag Html_Tag.Bdi
    static member bdo = Tag Html_Tag.Bdo
    static member optgroup = Tag Html_Tag.Optgroup
    static member menu = Tag Html_Tag.Menu
    static member portal = Tag Html_Tag.Portal
    static member style = Tag Html_Tag.Style
    static member br = Tag Html_Tag.Br
    static member hr = Tag Html_Tag.Hr
    static member wbr = Tag Html_Tag.Wbr
    static member meta = Tag Html_Tag.Meta
    static member link = Tag Html_Tag.Link
    static member img = Tag Html_Tag.Img
    static member input = Tag Html_Tag.Input
    static member source = Tag Html_Tag.Source
    static member track = Tag Html_Tag.Track
    static member col = Tag Html_Tag.Col
    static member area = Tag Html_Tag.Area
    static member embed = Tag Html_Tag.Embed
    static member ``base`` = Tag Html_Tag.Base












let css (selector: string) (rules: Rule list) =
    let _, css_string = createFssWithClassname "" rules
    selector + css_string.TrimStart('.')

module Render =

    open DocumentFormat.OpenXml
    open DocumentFormat.OpenXml.Packaging
    open DocumentFormat.OpenXml.Wordprocessing
    open HtmlToOpenXml

    let toDocx (docxPath: string) (html: string) =
        if File.Exists docxPath then
            File.Delete docxPath

        use wordDoc =
            WordprocessingDocument.Create(docxPath, WordprocessingDocumentType.Document)

        let mainPart = wordDoc.AddMainDocumentPart()

        mainPart.Document <- Document(Body())

        let converter = HtmlConverter(mainPart)

        let elements = converter.Parse(html)

        mainPart.Document.Body.Append(
            elements
            |> Seq.cast<OpenXmlElement>
            |> Seq.toArray
        )

        mainPart.Document.Save()

(*















type Css_Rule = Fss.Types.Rule
type Length_Percentage = Fss.Types.ILengthPercentage
let Zero = Fss.Types.Zero
let Px = Fss.Types.Px
let Pt = Fss.Types.Pt
let Percent = Fss.Types.Percent



type RuleSetBuilder(selector: Selector) =

    member _.Yield(rule: Css_Rule) : Css_Rule list = [ rule ]

    member _.YieldFrom(rules: Css_Rule list) : Css_Rule list = rules

    member _.Zero() : Css_Rule list = []

    member _.Combine(left: Css_Rule list, right: Css_Rule list) : Css_Rule list = left @ right

    member _.Delay(build: unit -> Css_Rule list) : Css_Rule list = build ()

    member _.Run(rules: Css_Rule list) : HtmlElement =

        let placeholderClassName = "__fss_view_engine_selector_placeholder__"

        let _, generatedCss =
            Fss.Functions.createFssWithClassname placeholderClassName rules

        generatedCss.Replace("." + placeholderClassName, Selector.stringify selector)
        + "\n"
        |> RawElement
        :> HtmlElement

type NestedRuleSetBuilder(createNestedRule: Css_Rule list -> Css_Rule) =
    member _.Yield(rule: Css_Rule) : Css_Rule list = [ rule ]

    member _.YieldFrom(rules: Css_Rule list) : Css_Rule list = rules

    member _.Zero() : Css_Rule list = []

    member _.Combine(left: Css_Rule list, right: Css_Rule list) : Css_Rule list = left @ right

    member _.Delay(build: unit -> Css_Rule list) : Css_Rule list = build ()

    member _.Run(rules: Css_Rule list) : Css_Rule = createNestedRule rules

type Css =
    // pseudoelements

    static member after_ = NestedRuleSetBuilder PseudoElement.after
    static member before_ = NestedRuleSetBuilder PseudoElement.before
    // pseudoclasses
    // element selectors
    static member html_ = RuleSetBuilder Selector.html
    static member head_ = RuleSetBuilder Selector.head
    static member title_ = RuleSetBuilder Selector.title
    static member script_ = RuleSetBuilder Selector.script
    static member body_ = RuleSetBuilder Selector.body
    static member main_ = RuleSetBuilder Selector.main
    static member header_ = RuleSetBuilder Selector.header
    static member footer_ = RuleSetBuilder Selector.footer
    static member nav_ = RuleSetBuilder Selector.nav
    static member h1_ = RuleSetBuilder Selector.h1
    static member h2_ = RuleSetBuilder Selector.h2
    static member h3_ = RuleSetBuilder Selector.h3
    static member h4_ = RuleSetBuilder Selector.h4
    static member h5_ = RuleSetBuilder Selector.h5
    static member h6_ = RuleSetBuilder Selector.h6
    static member div_ = RuleSetBuilder Selector.div
    static member p_ = RuleSetBuilder Selector.p
    static member span_ = RuleSetBuilder Selector.span
    static member a_ = RuleSetBuilder Selector.a
    static member button_ = RuleSetBuilder Selector.button
    static member code_ = RuleSetBuilder Selector.code
    static member pre_ = RuleSetBuilder Selector.pre
    static member ul_ = RuleSetBuilder Selector.ul
    static member ol_ = RuleSetBuilder Selector.ol
    static member li_ = RuleSetBuilder Selector.li
    static member blockquote_ = RuleSetBuilder Selector.blockquote
    static member article_ = RuleSetBuilder Selector.article
    static member dialog_ = RuleSetBuilder Selector.dialog
    static member time_ = RuleSetBuilder Selector.time
    static member form_ = RuleSetBuilder Selector.form
    static member label_ = RuleSetBuilder Selector.label
    static member textarea_ = RuleSetBuilder Selector.textarea
    static member select_ = RuleSetBuilder Selector.select
    static member option_ = RuleSetBuilder Selector.option
    static member table_ = RuleSetBuilder Selector.table
    static member thead_ = RuleSetBuilder Selector.thead
    static member tr_ = RuleSetBuilder Selector.tr
    static member th_ = RuleSetBuilder Selector.th
    static member tbody_ = RuleSetBuilder Selector.tbody
    static member td_ = RuleSetBuilder Selector.td
    static member dl_ = RuleSetBuilder Selector.dl
    static member dt_ = RuleSetBuilder Selector.dt
    static member dd_ = RuleSetBuilder Selector.dd
    static member template_ = RuleSetBuilder Selector.template
    static member iframe_ = RuleSetBuilder Selector.iframe
    static member section_ = RuleSetBuilder Selector.section
    static member aside_ = RuleSetBuilder Selector.aside
    static member figure_ = RuleSetBuilder Selector.figure
    static member figcaption_ = RuleSetBuilder Selector.figcaption
    static member details_ = RuleSetBuilder Selector.details
    static member summary_ = RuleSetBuilder Selector.summary
    static member strong_ = RuleSetBuilder Selector.strong
    static member em_ = RuleSetBuilder Selector.em
    static member b_ = RuleSetBuilder Selector.b
    static member i_ = RuleSetBuilder Selector.i
    static member u_ = RuleSetBuilder Selector.u
    static member s_ = RuleSetBuilder Selector.s
    static member small_ = RuleSetBuilder Selector.small
    static member mark_ = RuleSetBuilder Selector.mark
    static member sub_ = RuleSetBuilder Selector.sub
    static member sup_ = RuleSetBuilder Selector.sup
    static member abbr_ = RuleSetBuilder Selector.abbr
    static member cite_ = RuleSetBuilder Selector.cite
    static member q_ = RuleSetBuilder Selector.q
    static member dfn_ = RuleSetBuilder Selector.dfn
    static member var_ = RuleSetBuilder Selector.var
    static member samp_ = RuleSetBuilder Selector.samp
    static member kbd_ = RuleSetBuilder Selector.kbd
    static member ins_ = RuleSetBuilder Selector.ins
    static member del_ = RuleSetBuilder Selector.del
    static member address_ = RuleSetBuilder Selector.address
    static member hgroup_ = RuleSetBuilder Selector.hgroup
    static member search_ = RuleSetBuilder Selector.search
    static member noscript_ = RuleSetBuilder Selector.noscript
    static member slot_ = RuleSetBuilder Selector.slot
    static member data_ = RuleSetBuilder Selector.data
    static member video_ = RuleSetBuilder Selector.video
    static member audio_ = RuleSetBuilder Selector.audio
    static member picture_ = RuleSetBuilder Selector.picture
    static member canvas_ = RuleSetBuilder Selector.canvas
    static member object_ = RuleSetBuilder Selector.object
    static member fieldset_ = RuleSetBuilder Selector.fieldset
    static member legend_ = RuleSetBuilder Selector.legend
    static member datalist_ = RuleSetBuilder Selector.datalist
    static member output_ = RuleSetBuilder Selector.output
    static member progress_ = RuleSetBuilder Selector.progress
    static member meter_ = RuleSetBuilder Selector.meter
    static member caption_ = RuleSetBuilder Selector.caption
    static member colgroup_ = RuleSetBuilder Selector.colgroup
    static member tfoot_ = RuleSetBuilder Selector.tfoot
    static member map_ = RuleSetBuilder Selector.map
    static member ruby_ = RuleSetBuilder Selector.ruby
    static member rt_ = RuleSetBuilder Selector.rt
    static member rp_ = RuleSetBuilder Selector.rp
    static member bdi_ = RuleSetBuilder Selector.bdi
    static member bdo_ = RuleSetBuilder Selector.bdo
    static member optgroup_ = RuleSetBuilder Selector.optgroup
    static member menu_ = RuleSetBuilder Selector.menu
    static member portal_ = RuleSetBuilder Selector.portal
    static member style_ = RuleSetBuilder Selector.style
    static member br_ = RuleSetBuilder Selector.br
    static member hr_ = RuleSetBuilder Selector.hr
    static member wbr_ = RuleSetBuilder Selector.wbr
    static member meta_ = RuleSetBuilder Selector.meta
    static member link_ = RuleSetBuilder Selector.link
    static member img_ = RuleSetBuilder Selector.img
    static member input_ = RuleSetBuilder Selector.input
    static member source_ = RuleSetBuilder Selector.source
    static member track_ = RuleSetBuilder Selector.track
    static member col_ = RuleSetBuilder Selector.col
    static member area_ = RuleSetBuilder Selector.area
    static member embed_ = RuleSetBuilder Selector.embed
    static member base_ = RuleSetBuilder Selector.``base``
*)
