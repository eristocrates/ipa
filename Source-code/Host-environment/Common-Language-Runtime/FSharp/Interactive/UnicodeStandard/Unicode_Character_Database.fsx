open System
open System.Diagnostics
open System.IO
open System.Linq
open System.Text
open System.Text.Json
open System.Xml
open System.Xml.Linq
open System.Xml.XPath

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\PropertyAliases.fsx"
#r "nuget: FSharp.UMX"
#r "nuget: LightningDB"
#r "nuget: MessagePack"
#r "nuget: Unquote"
#r "nuget: XParsec"

open FSharp.UMX
open LightningDB
open MessagePack
open PropertyAliases
open Swensen.Unquote.Assertions

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\DatabaseErgonomics.fsx"
open DatabaseErgonomics

// Configure DB for duplicate keys


let write_singleton_key_config =
    DatabaseConfiguration()
    |> LMDB.DatabaseConfiguration.create_DB_if_not_already_existing

let write_duplicate_key_config =
    write_singleton_key_config
    |> LMDB.DatabaseConfiguration.use_sorted_duplicates

let read_duplicate_key_config =
    DatabaseConfiguration()
    |> LMDB.DatabaseConfiguration.use_sorted_duplicates


let ucd_directory_path =
    @"C:\Repositories\eristocrates\ipa\Persistence\Database\Embedded\KeyValue\LightningDB\Unicode"

let ucd_environment = LMDB.env.create_gigabytes_at_path 1 ucd_directory_path

ucd_environment.Open()




let read_transaction_context =
    {

      environment = ucd_environment
      database_configuration = read_duplicate_key_config

    }

let write_transaction_context =
    {

      environment = ucd_environment
      database_configuration = write_duplicate_key_config

    }


[<MessagePackObject>]
type Unicode_Character_Property =
    {

      [<Key(0)>]
      property_short_name: string

      [<Key(1)>]
      property_value: string


     }

[<MessagePackObject>]
type Unicode_Name_Alias =
    {

      [<Key(0)>]
      alias_name: string

      [<Key(1)>]
      alias_type: string

     }


let unicode_iri (local_name: string) =
    let underscored_local_name = local_name.Replace(" ", "_")
    $"https://eristocrates.dev/ontology/unicode/{underscored_local_name}"


let unicode_character_property_iri =
    "https://eristocrates.dev/ontology/unicode/component/Unicode_Character_Property"


let unicode_name_alias_iri =
    "https://eristocrates.dev/ontology/unicode/component/Unicode_Name_Alias"










(*


[<Literal>]
let file_path = @"D:\Surface\Standards\Unicode\UCD\17.0.0\ucdxml\ucd.all.flat.xml"

let xpath_document = XPathDocument(file_path).CreateNavigator()
// let type_provider = XmlProvider<file_path>.Load file_path


let ucd_vocabulary = XNamespace.op_Implicit "http://www.unicode.org/ns/2003/ucd/1.0"

let namespace_manager = XmlNamespaceManager xpath_document.NameTable
namespace_manager.AddNamespace("ucd", ucd_vocabulary.NamespaceName)




module XPathNodeIterator =
    let toElementArray (xpath_node_iterator: XPathNodeIterator) =
        seq {
            while xpath_node_iterator.MoveNext() do
                xpath_node_iterator.Current.Clone()
        }
        |> Seq.toArray

module XPathNavigator =
    let toAttributeArray (xpath_navigator: XPathNavigator) =
        seq {
            while xpath_navigator.MoveToNextAttribute() do
                xpath_navigator.Clone()
        }
        |> Seq.toArray

    let toParent (xpath_navigator: XPathNavigator) =
        let navigator = xpath_navigator.Clone()
        navigator.MoveToParent() |> ignore
        navigator



let navigate_xpath (xpath: string) (xpath_navigator: XPathNavigator) =
    let xpath_expression = XPathExpression.Compile(xpath)
    xpath_expression.SetContext(namespace_manager)

    xpath_navigator.Select(xpath_expression)
    |> XPathNodeIterator.toElementArray

let document_xpath (xpath: string) = xpath_document |> navigate_xpath xpath

let get_char_elements () =
    document_xpath $"//ucd:char"
    |> Array.Parallel.filter (fun char_element ->

        String.IsNullOrWhiteSpace(char_element.GetAttribute("first-cp", ""))

    )

let char_attributes =
    get_char_elements ()
    |> Array.Parallel.collect (fun element ->
        element.MoveToFirstAttribute() |> ignore
        element |> XPathNavigator.toAttributeArray

    )
    |> Array.Parallel.filter (fun char_attribute -> not (String.IsNullOrEmpty char_attribute.Value))



let code_point_from_attribute (char_attribute: XPathNavigator) =
    let char_attribute_element = char_attribute |> XPathNavigator.toParent
    let hexdigit_string = char_attribute_element.GetAttribute("cp", "")
    test <@ hexdigit_string.Length > 0 @>
    // int_from_hexdigit_string hexdigit_string
    hexdigit_string




let character_properties =
    char_attributes
    |> Array.Parallel.map (fun char_attribute ->
        let code_point = code_point_from_attribute char_attribute



        (code_point, char_attribute.LocalName, char_attribute.Value)

    )






let code_point'character_property: Decoded.Entity'Component<Unicode_Character_Property> array =
    character_properties
    |> Array.Parallel.map (fun (code_point, property_short_name, property_value) ->

        { Entity = unicode_iri code_point

          Component =
              { property_short_name = unicode_iri property_short_name
                property_value = property_value } })


Write.Entity'Components<Unicode_Character_Property>
    unicode_character_property_iri
    code_point'character_property
    write_transaction_context



let get_name_alias_elements () = document_xpath $"//ucd:name-alias"

let name_aliases =
    get_name_alias_elements ()
    |> Array.Parallel.map (fun name_alias_element ->

        let alias_attribute = name_alias_element.GetAttribute("alias", "")
        let type_attribute = name_alias_element.GetAttribute("type", "")
        let char_element_with_name_alias = name_alias_element |> XPathNavigator.toParent
        let code_point = char_element_with_name_alias.GetAttribute("cp", "")
        (code_point, alias_attribute, type_attribute)

    )


let code_point'name_alias: Decoded.Entity'Component<Unicode_Name_Alias> array =
    name_aliases
    |> Array.Parallel.map (fun (code_point, alias_attribute, type_attribute) ->

        {

          Entity = unicode_iri code_point
          Component =
            {

              alias_name = unicode_iri alias_attribute
              alias_type = unicode_iri type_attribute

            }

        })

Write.Entity'Components unicode_name_alias_iri code_point'name_alias write_transaction_context


*)




let entities_with_name_alias =
    Read.Entities_with_Component<Unicode_Name_Alias> unicode_name_alias_iri read_transaction_context

let random_entity'component = entities_with_name_alias |> Array.randomChoice

let components_from_random_entity'component =
    Read.Components_for_Entity random_entity'component.Entity read_transaction_context

components_from_random_entity'component
|> Array.map (fun entity'component -> entity'component.component_type)
|> Array.distinct
//
let random_entity'name_aliases =
    Read.Components_for_Entity_with_type<Unicode_Name_Alias>
        "https://eristocrates.dev/ontology/unicode/component/Unicode_Name_Alias"
        random_entity'component.Entity
        read_transaction_context

let random_entity'character_properties =
    Read.Components_for_Entity_with_type<Unicode_Character_Property>
        "https://eristocrates.dev/ontology/unicode/component/Unicode_Character_Property"
        random_entity'component.Entity
        read_transaction_context



(*

let test_entity = "5758"
let test_entity_iri = unicode_iri test_entity
let test_property_iri = unicode_iri "test"


let test_entity'component =
    {

      Entity = test_entity_iri
      Component =
        {

          property_short_name = test_property_iri
          property_value = "unchanged"

        }

    }



Update.Entities_with_Component<Unicode_Name_Alias>
    unicode_name_alias_iri
    read_transaction_context
    (fun entity'name_alias ->

        { entity'name_alias with
            Component =
                { alias_name = entity'name_alias.Component.alias_name
                  alias_type = entity'name_alias.Component.alias_type } })
let test_component =
    read_Components_for_Entity<Unicode_Character_Property> test_entity_iri read_transaction_context

*)

// write_Entity'Components [| test_entity'component |] write_transaction_context

// migrate_Entity write_transaction_context test_entity test_entity_iri



//
// printfn "%A" values
