open System
open System.Xml
open System.Xml.Linq
open System.Xml.XPath
open System.Buffers
open System.Runtime.CompilerServices
open System.Text

#r "nuget: FSharp.ViewEngine"
open FSharp.ViewEngine


module Render =

    let toXDocument (version: string) (encoding: string) (standalone: string option) (view: #HtmlElement) =
        let sb = new StringBuilder()

        if standalone.IsSome then

            sb.AppendLine($"""<?xml version="{version}" encoding="{encoding}" standalone="{standalone.Value}"?>""")
            |> ignore
        else

            sb.AppendLine($"""<?xml version="{version}" encoding="{encoding}"?>""")
            |> ignore

        view.Render(sb)
        sb.ToString() |> XDocument.Parse

    let toStandaloneXDocument (view: #HtmlElement) =
        let sb = new StringBuilder()


        view.Render(sb)
        sb.ToString() |> XDocument.Parse

    let toXElement (view: #HtmlElement) =
        let sb = new StringBuilder()
        view.Render(sb)
        sb.ToString() |> XElement.Parse


type Xml =

    static member text(v: string) = TextElement(v) :> HtmlElement

    static member inline _xmlns(value: string) =
        { Name = "xmlns"
          Value = ValueSome value }

    static member inline _lang(value: string) =
        { Name = "xml:lang"
          Value = ValueSome value }

    static member inline _space(value: string) =
        { Name = "xml:space"
          Value = ValueSome value }
    // Custom
    static member element(name: string) = TagBuilder(name)
    static member void_element(name: string) = VoidBuilder(name)
    static member inline _attribute (key: string) (value: string) = { Name = key; Value = ValueSome value }


module XDocument =
    let Name (name: string) = XName.Get(name)
    let Attribute (key: string) (value: obj) : obj = XAttribute(Name key, value) :> obj

    let Text (text: string) : obj = XText(text) :> obj

    let Element (name: string) (content: obj list) : XElement =
        XElement(Name name, content |> List.toArray)


    let Declaration_Root (declaration: XDeclaration) (root_element: XElement) : XDocument =
        XDocument(declaration, [| root_element :> obj |])

type XPathNodeIterator with
    member this.toElementArray =
        seq {
            while this.MoveNext() do
                this.Current.Clone()
        }
        |> Seq.toArray

type XPathNavigator with

    member this.Attributes =
        seq {
            while this.MoveToNextAttribute() do
                this.Clone()
        }
        |> Seq.toArray

    member this.Attribute(local_name: string) = this.GetAttribute(local_name, "")


    member this.Parent =
        let navigator = this.Clone()
        navigator.MoveToParent() |> ignore
        navigator

    member this.Children =
        let navigator = this.Clone()

        try
            navigator.MoveToFirstChild() |> ignore
            let head = navigator.Clone()

            let tail =
                seq {
                    while navigator.MoveToNext() do
                        this.Clone()
                }
                |> Seq.toArray

            Array.insertAt 0 head tail
        with
        | _ -> [||]

module XPathNavigator =




    let Load (file_path: string) =
        XPathDocument(file_path).CreateNavigator()

    let xmlns
        (namespace_manager: XmlNamespaceManager)
        (namespace_prefix: string)
        (namespace_name: string)
        (xpath_navigator: XPathNavigator)
        =
        namespace_manager.AddNamespace(namespace_prefix, namespace_name)
        XNamespace.op_Implicit namespace_name

/// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/xmldoc/recommended-tags
module Xml_Documentation_Comments =
    (*
The compiler verifies the syntax of the elements followed by a single * in the following list.
Visual Studio provides IntelliSense for the tags verified by the compiler and all tags followed by ** in the following list.
In addition to the tags listed here, the compiler and Visual Studio validate the <b>, <i>, <u>, <br/>, and <a> tags.
The compiler also validates <tt>, which is deprecated HTML.
*)
    let tt = Xml.element "tt"
    let _type = Xml._attribute "type"

    // General Tags used for multiple elements - These tags are the minimum set for any API.

    /// <summary>: The value of this element is displayed in IntelliSense in Visual Studio.
    let summary = Xml.element "summary"
    /// <remarks> **
    let remarks = Xml.element "remarks"

    // Tags used for members - These tags are used when documenting methods and properties.

    /// <returns>: The value of this element is displayed in IntelliSense in Visual Studio.
    let returns = Xml.element "returns"
    /// <param> *: The value of this element is displayed in IntelliSense in Visual Studio.
    let param = Xml.element "param"
    /// <paramref>
    let paramref = Xml.element "paramref"
    /// <exception> *
    let exception_ = Xml.element "exception"
    /// <value>: The value of this element is displayed in IntelliSense in Visual Studio.
    let value = Xml.element "value"

    // Format documentation output - These tags provide formatting directions for tools that generate documentation.

    /// <para>
    let para = Xml.element "para"
    /// <list>
    let list_ = Xml.element "list"
    let listheader = Xml.element "listheader"
    let item = Xml.element "item"
    let description = Xml.element "description"
    let term = Xml.element "term"

    /// <c>
    let c = Xml.element "c"
    /// <code>
    let code = Xml.element "code"
    /// <example> **
    let example = Xml.element "example"
    /// <b>
    let b = Xml.element "b"
    /// <i>
    let i = Xml.element "i"
    /// <u>
    let u = Xml.element "u"
    /// <br/>
    let br = Xml.void_element "br"
    /// <a>
    let a = Xml.element "a"

    // Reuse documentation text - These tags provide tools that make it easier to reuse XML comments.

    /// <inheritdoc> **
    let inheritdoc = Xml.element "inheritdoc"
    /// <include> *
    let include_ = Xml.element "include"

    // Generate links and references - These tags generate links to other documentation.

    /// <see> *
    let see = Xml.element "see"
    /// <seealso> *
    let seealso = Xml.element "seealso"
    /// cref
    let cref = Xml.element "cref"
    /// href
    let href = Xml.element "href"

    // Tags for generic types and methods - Use these tags only on generic types and methods.

    /// <typeparam> *: IntelliSense in Visual Studio shows the value of this element.
    let typeparam = Xml.element "typeparam"
    /// <typeparamref>
    let typeparamref = Xml.element "typeparamref"





(*

  let traverse (xpath: string) (xpath_navigator: XPathNavigator) =
      let xpath_expression = XPathExpression.Compile(xpath)
      xpath_expression.SetContext(namespace_manager)

      xpath_navigator.Select(xpath_expression)
      |> XPathNodeIterator.toElementArray

          *)
