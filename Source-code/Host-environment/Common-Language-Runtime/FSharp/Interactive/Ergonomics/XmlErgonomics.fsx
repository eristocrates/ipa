open System
open System.Xml
open System.Xml.Linq
open System.Xml.XPath


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
