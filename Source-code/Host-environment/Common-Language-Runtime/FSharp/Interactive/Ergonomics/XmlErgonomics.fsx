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
    static member elVoid(name: string) = VoidBuilder(name)
    static member inline _attribute(key: string, value: string) = { Name = key; Value = ValueSome value }


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




(*

  let traverse (xpath: string) (xpath_navigator: XPathNavigator) =
      let xpath_expression = XPathExpression.Compile(xpath)
      xpath_expression.SetContext(namespace_manager)

      xpath_navigator.Select(xpath_expression)
      |> XPathNodeIterator.toElementArray

          *)
