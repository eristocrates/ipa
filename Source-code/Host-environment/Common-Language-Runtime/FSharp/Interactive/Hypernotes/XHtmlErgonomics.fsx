open System
open System.Xml
open System.Xml.Linq
open System.Xml.XPath
open System.IO
open System.Text
open System.Text.RegularExpressions

#r "nuget: HtmlAgilityPack"
open HtmlAgilityPack
#r "nuget: FSharp.Data"

open FSharp.Data



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"

open XmlErgonomics

type NamespaceDeclaration =
    { Prefix: string
      NamespaceName: string }

module xlink =
    let _namespace_name = "http://www.w3.org/1999/xlink"
    let _prefix_label = "xlink"

    let _xmlns =
        { Prefix = _prefix_label
          NamespaceName = _namespace_name }

let getHtmlElement (document: HtmlAgilityPack.HtmlDocument) : HtmlAgilityPack.HtmlNode =
    document.DocumentNode.Descendants()
    |> Seq.cast<HtmlAgilityPack.HtmlNode>
    |> Seq.tryFind (fun node -> String.Equals(node.Name, "html", StringComparison.OrdinalIgnoreCase))
    |> Option.defaultWith (fun () -> invalidOp "The document does not contain an <html> element.")

let addNamespaceDeclarationsToNode
    (declarations: NamespaceDeclaration array)
    (node: HtmlAgilityPack.HtmlNode)
    : HtmlAgilityPack.HtmlNode =
    for declaration in declarations do
        node.SetAttributeValue($"xmlns:{declaration.Prefix}", declaration.NamespaceName)
        |> ignore

    node

let htmlToXhtml (html_path: string) (xhtml_path: string) =
    let document = HtmlAgilityPack.HtmlDocument()

    document.OptionOutputAsXml <- true
    document.OptionWriteEmptyNodes <- true
    document.OptionOutputUpperCase <- false

    document.Load(html_path, Encoding.UTF8)

    let htmlElement =
        document
        |> getHtmlElement
        |> addNamespaceDeclarationsToNode [| xlink._xmlns |]

    File.WriteAllText(xhtml_path, htmlElement.OuterHtml, Encoding.UTF8)





[<Literal>]
let test_html_path =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Hypernotes\html.wattsi"



[<Literal>]
let wattsi_xhtml =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Hypernotes\html.wattsi.xhtml"

htmlToXhtml test_html_path wattsi_xhtml




let test_html = HtmlDocument.Load test_html_path

let elements =
    test_html
    |> HtmlDocument.descendants true (fun node -> HtmlNode.name node <> "")

elements
|> Seq.take 10
|> Seq.mapi (fun index Element ->
    let Attributes =
        Element.Attributes()
        |> List.map (fun Attribute -> (Attribute.Name(), Attribute.Value()))

    index, Element.Name(), Element.DirectInnerText(), Attributes

)




(*


let xhtml = XmlProvider<wattsi_xhtml>.Load wattsi_xhtml

xhtml.Body.Header.Hgroups
|> Array.map (fun Hgroup -> Hgroup.H1)

xhtml.Body
*)
