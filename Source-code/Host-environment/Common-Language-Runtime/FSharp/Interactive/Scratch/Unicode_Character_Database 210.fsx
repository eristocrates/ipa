open System
open System.Collections.Generic
open System.Globalization
open System.Text
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
#r "nuget: MessagePack.FSharpExtensions"
#r "nuget: Unquote"
#r "nuget: XParsec"

open FSharp.UMX
open LightningDB
open MessagePack
open PropertyAliases
open Swensen.Unquote.Assertions

#r "nuget: Blake3"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\RDFErgonomics.fsx"

open RDFErgonomics

open LMDB

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"

open XmlErgonomics

// open Unicode_Standard
// open StringExtensions
// Configure DB for duplicate keys


// open RdfErgonomics
// open Unicode_Standard
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\DiagnosticsErgonomics.fsx"
open DiagnosticsErgonomics







let context_iri =
    Resolved_IRI.from_trusted_string $"https://eristocrates.dev/ontology/unicode/"

(*


let code_point_form = iri "https://eristocrates.dev/ontology/unicode/3184F"
let na_attribute_iri = iri $"https://eristocrates.dev/ontology/unicode/na"
// let results = Query.sp_c random_code_point_iri na_iri context_iri





*)



















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
    time_operation "char_elements" (fun () ->
        ucd.xml
        |> xpath $"//ucd:char"
        |> Array.Parallel.filter (fun char_element ->

            String.IsNullOrWhiteSpace(char_element.GetAttribute("first-cp", ""))

        )

    )

let char_attributes =
    time_operation "char_attributes" (fun () ->
        char_elements
        |> Array.Parallel.collect (fun element ->
            element.MoveToFirstAttribute() |> ignore
            element.Attributes

        )
        |> Array.Parallel.filter (fun char_attribute -> not (String.IsNullOrEmpty char_attribute.Value))

    )



let code_point_from_attribute (char_attribute: XPathNavigator) =
    let char_attribute_element = char_attribute.Parent
    let hexdigit_string = char_attribute_element.Attribute "cp"
    // test <@ hexdigit_string.Length > 0 @>
    hexdigit_string




let character_properties =

    time_operation "character_properties" (fun () ->
        char_attributes
        |> Array.Parallel.map (fun char_attribute ->
            let code_point = code_point_from_attribute char_attribute

            (code_point, char_attribute.LocalName, char_attribute.Value)

        ))










let name_aliases =
    time_operation "name_aliases" (fun () ->
        ucd.xml
        |> xpath $"//ucd:name-alias"
        |> Array.Parallel.map (fun name_alias_element ->

            let alias_attribute = name_alias_element.Attribute "alias"
            let type_attribute = name_alias_element.Attribute "type"
            let char_element_with_name_alias = name_alias_element.Parent
            let code_point = char_element_with_name_alias.Attribute "cp"
            (code_point, alias_attribute, type_attribute)

        )

    )























(*






let code_point_iri =

    let local_name =
        character_properties
        |> Array.map (fun (code_point, _, _) -> code_point)
        |> Array.randomChoice

    iri $"https://eristocrates.dev/ontology/unicode/{local_name}"

let attribute_iri =

    let local_name =
        character_properties
        |> Array.map (fun (_, attribute, _) -> attribute)
        |> Array.randomChoice

    iri $"https://eristocrates.dev/ontology/unicode/{local_name}"

let literal =
    character_properties
    |> Array.map (fun (_, _, attribute_value) -> attribute_value)
    |> Array.randomChoice
    |> simple_literal


Query.s__c code_point_iri context_iri
|> Array.iter (fun (p, o) ->
    printfn
        "<%s> <%s> \"%s\" <%s> ."
        (Transient_Term.to_string code_point_iri)
        (Transient_Term.to_string p)
        (Transient_Term.to_string o)
        (Transient_Term.to_string context_iri))

Query.s___ code_point_iri
|> Array.iter (fun (p, o, _) ->
    printfn
        "%s %s %s"
        (Transient_Term.to_string code_point_iri)
        (Transient_Term.to_string p)
        (Transient_Term.to_string o))

Query.s___ code_point_iri
|> Array.iter (fun (p, o, _) ->
    printfn
        "%s %s %s"
        (Transient_Term.to_string code_point_iri)
        (Transient_Term.to_string p)
        (Transient_Term.to_string o))

let na_iri = iri $"https://eristocrates.dev/ontology/unicode/na"
let kIRG_UKSource = iri $"https://eristocrates.dev/ontology/unicode/kIRG_UKSource"
let UK_10329 = simple_literal "UK-10329"

Query._poc kIRG_UKSource UK_10329 context_iri
Query.sp_c code_point_iri na_iri context_iri
Query._p__ na_iri

*)





































































let code_point_iri_strings =
    character_properties
    |> Array.map (fun (code_point, _, _) -> code_point)
    |> Array.distinct
    |> Array.map (fun local_name -> $"https://eristocrates.dev/ontology/unicode/{local_name}"

    )

let attribute_iri_strings =
    character_properties
    |> Array.map (fun (_, char_attribute_LocalName, _) -> char_attribute_LocalName)
    |> Array.distinct
    |> Array.map (fun local_name -> $"https://eristocrates.dev/ontology/unicode/{local_name}"

    )

let attribute_literal_strings =
    character_properties
    |> Array.map (fun (_, _, char_attribute_value) -> char_attribute_value)
    |> Array.distinct


let alias_literal_strings =
    name_aliases
    |> Array.map (fun (_, alias_attribute, _) -> alias_attribute)
    |> Array.distinct

let alias_iri_strings =
    alias_literal_strings
    |> Array.map (fun local_name -> $"https://eristocrates.dev/ontology/unicode/{local_name}"

    )

let alias_type_iri_strings =
    name_aliases
    |> Array.map (fun (_, _, type_attribute) -> type_attribute)
    |> Array.distinct
    |> Array.map (fun local_name -> $"https://eristocrates.dev/ontology/unicode/{local_name}"

    )


let iri_strings =
    Array.concat [|

                    code_point_iri_strings
                    attribute_iri_strings
                    alias_iri_strings
                    alias_type_iri_strings

                     |]

let literal_strings =
    Array.concat [|

                    attribute_literal_strings
                    alias_literal_strings

                     |]


let iri_terms =
    Database.Get.Lexical_Forms_from_Strings iri_strings
    |> Resolved_IRI.from_lexical_forms
    |> Database.Get.Transient_Terms_From_Persistent_Terms

let literal_terms =
    Database.Get.Lexical_Forms_from_Strings literal_strings
    |> RDF_Literal.from_lexical_forms_as_simple
    |> Database.Get.Transient_Terms_From_Persistent_Terms





















let iri_term_by_string_lookup = Transient_Term.to_transient_map iri_terms

let literal_term_by_string_lookup = Transient_Term.to_transient_map literal_terms

let iri_lookup string_value = iri_term_by_string_lookup[string_value]

let simple_literal_lookup string_value =
    literal_term_by_string_lookup[string_value]

































character_properties
|> Array.distinctBy (fun (_, char_attribute, _) -> char_attribute)
|> Array.map (fun (_, char_attribute, _) ->
    let char_attribute_iri =
        iri_lookup $"https://eristocrates.dev/ontology/unicode/{char_attribute}"

    Quad.spoc char_attribute_iri a unicode.Unicode_Character_Property context_iri

)
|> Assert.Quads























let mutable total_stopwatch = Stopwatch.StartNew()

let mutable total_quads_written = 0


let code_point_elements =
    character_properties
    |> Array.distinctBy (fun (code_point, _, _) -> code_point)

let code_point_elements_batch_cardinality = code_point_elements.Length / batch_size

code_point_elements
|> Array.chunkBySize batch_size
|> Array.iteri (fun batch_index code_point_batch ->

    let batch_stopwatch = Stopwatch.StartNew()

    let quads =
        code_point_batch
        |> Array.map (fun (code_point, _, _) ->
            let code_point_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{code_point}"

            Quad.spoc code_point_iri a unicode.Code_Point context_iri

        )


    Assert.Quads quads

    batch_stopwatch.Stop()


    total_quads_written <- total_quads_written + quads.Length

    let total_rate =
        float total_quads_written
        / total_stopwatch.Elapsed.TotalSeconds

    let batch_rate =
        float quads.Length
        / batch_stopwatch.Elapsed.TotalSeconds

    printfn
        "batch=%i/%d  batch_rate=%.0f quads/sec total=%i total_elapsed=%O total_rate=%.0f quads/sec"
        batch_index
        code_point_elements_batch_cardinality
        batch_rate
        total_quads_written
        total_stopwatch.Elapsed
        total_rate)

total_stopwatch.Stop()

printfn
    "done total_quads=%i elapsed=%O average_rate=%.0f quads/sec"
    total_quads_written
    total_stopwatch.Elapsed
    (float total_quads_written
     / total_stopwatch.Elapsed.TotalSeconds)


















total_stopwatch = Stopwatch.StartNew()

total_quads_written = 0

let character_property_batch_cardinality = character_properties.Length / batch_size

character_properties
|> Array.chunkBySize batch_size
|> Array.iteri (fun batch_index character_property_batch ->

    let batch_stopwatch = Stopwatch.StartNew()

    let quads =
        character_property_batch
        |> Array.map (fun (code_point, char_attribute, char_attribute_value) ->

            let code_point_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{code_point}"

            let char_attribute_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{char_attribute}"

            let attribute_literal = simple_literal_lookup char_attribute_value

            Quad.spoc code_point_iri char_attribute_iri attribute_literal context_iri

        )


    Assert.Quads quads

    batch_stopwatch.Stop()


    total_quads_written <- total_quads_written + quads.Length

    let total_rate =
        float total_quads_written
        / total_stopwatch.Elapsed.TotalSeconds

    let batch_rate =
        float quads.Length
        / batch_stopwatch.Elapsed.TotalSeconds

    printfn
        "batch=%i/%d  batch_rate=%.0f quads/sec total=%i total_elapsed=%O total_rate=%.0f quads/sec"
        batch_index
        character_property_batch_cardinality
        batch_rate
        total_quads_written
        total_stopwatch.Elapsed
        total_rate)

total_stopwatch.Stop()

printfn
    "done total_quads=%i elapsed=%O average_rate=%.0f quads/sec"
    total_quads_written
    total_stopwatch.Elapsed
    (float total_quads_written
     / total_stopwatch.Elapsed.TotalSeconds)






























































total_stopwatch <- Stopwatch.StartNew()

total_quads_written <- 0

let name_aliases_batch_cardinality = name_aliases.Length / batch_size

name_aliases
|> Array.chunkBySize batch_size
|> Array.iteri (fun batch_index name_alias_batch ->

    let batch_stopwatch = Stopwatch.StartNew()

    let quads =
        name_alias_batch
        |> Array.collect (fun (code_point, alias_attribute, type_attribute) ->

            let code_point_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{code_point}"

            let alias_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{alias_attribute}"

            let alias_literal = simple_literal_lookup alias_attribute

            let type_iri =
                iri_lookup $"https://eristocrates.dev/ontology/unicode/{type_attribute}"

            [|

               Quad.spoc code_point_iri unicode.name_alias alias_iri context_iri
               Quad.spoc alias_iri a unicode.Name_Alias context_iri
               Quad.spoc alias_iri unicode.alias_type type_iri context_iri
               Quad.spoc alias_iri rdf.value alias_literal context_iri

               |]

        )


    Assert.Quads quads

    batch_stopwatch.Stop()

    total_quads_written <- total_quads_written + quads.Length

    let total_rate =
        float total_quads_written
        / total_stopwatch.Elapsed.TotalSeconds

    let batch_rate =
        float quads.Length
        / batch_stopwatch.Elapsed.TotalSeconds

    printfn
        "batch=%i/%d rows  batch_rate=%.0f quads/sec total=%i total_elapsed=%O total_rate=%.0f quads/sec"
        batch_index
        name_aliases_batch_cardinality
        batch_rate
        total_quads_written
        total_stopwatch.Elapsed
        total_rate)

total_stopwatch.Stop()

printfn
    "done total_quads=%i elapsed=%O average_rate=%.0f quads/sec"
    total_quads_written
    total_stopwatch.Elapsed
    (float total_quads_written
     / total_stopwatch.Elapsed.TotalSeconds)











// print_environment_stats()

//
