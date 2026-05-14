open System
open System.Xml
open System.Xml.Linq
open System.Xml.XPath


#r "nuget: Unquote"
open Swensen.Unquote.Assertions
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"
open XmlErgonomics

module ucd =

    [<Literal>]
    let file_path = @"D:\Surface\Standards\Unicode\UCD\17.0.0\ucdxml\ucd.all.flat.xml"

    let xml = XPathNavigator.Load(file_path)

let namespace_manager = new XmlNamespaceManager(ucd.xml.NameTable)

let ucd_namespace =
    ucd.xml
    |> XPathNavigator.xmlns namespace_manager "ucd" "http://www.unicode.org/ns/2003/ucd/1.0"




let xpath (expression: string) (xpath_navigator: XPathNavigator) =
    let xpath_expression = XPathExpression.Compile(expression)
    xpath_expression.SetContext(namespace_manager)

    xpath_navigator
        .Select(
            xpath_expression
        )
        .toElementArray

let char_elements =
    ucd.xml
    |> xpath $"//ucd:char"
    |> Array.Parallel.filter (fun char_element ->

        String.IsNullOrWhiteSpace(char_element.GetAttribute("first-cp", ""))

    )

let get_char_attributes =
    char_elements
    |> Array.Parallel.collect (fun element ->
        element.MoveToFirstAttribute() |> ignore
        element.Attributes

    )
    |> Array.Parallel.filter (fun char_attribute -> not (String.IsNullOrEmpty char_attribute.Value))



let code_point_from_attribute (char_attribute: XPathNavigator) =
    let char_attribute_element = char_attribute.Parent
    let hexdigit_string = char_attribute_element.Attribute "cp"
    test <@ hexdigit_string.Length > 0 @>
    hexdigit_string




let character_properties =
    get_char_attributes
    |> Array.Parallel.map (fun char_attribute ->
        let code_point = code_point_from_attribute char_attribute

        (code_point, char_attribute.LocalName, char_attribute.Value)

    )









let get_name_alias_elements = ucd.xml |> xpath $"//ucd:name-alias"

let name_aliases =
    get_name_alias_elements
    |> Array.Parallel.map (fun name_alias_element ->

        let alias_attribute = name_alias_element.Attribute "alias"
        let type_attribute = name_alias_element.Attribute "type"
        let char_element_with_name_alias = name_alias_element.Parent
        let code_point = char_element_with_name_alias.Attribute "cp"
        (code_point, alias_attribute, type_attribute)

    )
