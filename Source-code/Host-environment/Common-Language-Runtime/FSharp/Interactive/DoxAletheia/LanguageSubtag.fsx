#time on
fsi.ShowDeclarationValues <- false
fsi.PrintLength <- 10


open System
open System.IO

#r "nuget: FSharp.Compiler.Service, 43.10.102"

open FSharp.Compiler.Syntax
open FSharp.Compiler.Tokenization


open System
open System.Text
open System.Security
open FSharp.Compiler.CodeAnalysis
open FSharp.Compiler.Diagnostics
open FSharp.Compiler.Text
open FSharp.Compiler.Diagnostics
open FSharp.Compiler.Interactive.Shell

#r "nuget: FSharp.Data"
open FSharp.Data


#r "nuget:  Fabulous.AST"
open Fabulous.AST
open Fantomas.Core.SyntaxOak
open type Fabulous.AST.Ast

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"
open XmlErgonomics
#r @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Ergonomic_Extensions\obj\Release\net10.0\Ergonomic_Extensions.dll"
open DoxAletheia
open PrettierNaming
// #load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\LanguageTag.fsx"
let registry_directory_path =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\LanguageSubtag.txt"
[<Literal>]
let registry_file_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\language-subtag-registry.json"
let registry = JsonProvider<registry_file_path>.Load registry_file_path


type Subtag = 
    {   
        Added: DateTime
        Comments: string array
        Description: string array
        Macrolanguage: string
        PreferredValue: string
        Prefix: string array
        Scope: string option
        Name: string
        SuppressScript: string option
        Tag: string option
        Type: string
    }

let single_subtags =
    registry
    |> Array.filter (fun subtag -> subtag.Deprecated.IsNone )
    |> Array.filter (fun subtag -> not (subtag.Subtag.JsonValue.AsString().Contains("..")))
    |> Array.filter (fun subtag -> not (String.IsNullOrWhiteSpace(subtag.Subtag.JsonValue.AsString())))
    |> Array.map (fun subtag -> 
        {   
        
        Added = subtag.Added
        Comments = subtag.Comments
        Description = subtag.Description
        Macrolanguage = subtag.Macrolanguage.JsonValue.AsString()
        PreferredValue = subtag.PreferredValue.JsonValue.AsString()
        Prefix = subtag.Prefix
        Scope = subtag.Scope
        Name = subtag.Subtag.JsonValue.AsString()
        SuppressScript = subtag.SuppressScript
        Tag = subtag.Tag
        Type = subtag.Type
    }


        )
let prefixed_subtags =
        single_subtags
        |> Array.filter (fun subtag -> subtag.Prefix.Length > 0 )
        |> Array.collect (fun subtag -> 
                subtag.Prefix |> Array.map (fun prefix -> { subtag with Name = sprintf "%s-%s" prefix subtag.Name } )
            )
let subtags = 
    Array.concat [| single_subtags ; prefixed_subtags|]
    |> Array.sortBy (fun subtag -> subtag.Name)



let subtag_types = 
    subtags
    |> Array.map (fun subtag -> subtag.Type)
    |> Array.distinct

// type Language_Tag(primary:Language_Subtag, ext1:Extended_Language_Subtag option, ext2:Extended_Language_Subtag option, ext3:Extended_Language_Subtag option, region:Region_Subtag option, variants:Variant_Subtag option array, extensions:Extension_Subtag option array, private_use:Private_Use_Subtag option) =

let languages = 
    subtags
    |> Array.filter (fun subtag -> subtag.Type = "language"&& subtag.Name <> "qaa..qtz")


let extended_languages = 
    subtags
    |> Array.filter (fun subtag -> subtag.Type = "extlang")


let scripts =
    subtags
    |> Array.filter (fun subtag -> subtag.Type = "script" && subtag.Name <> "Qaaa..Qabx")
let regions =
    subtags
    |> Array.filter (fun subtag -> subtag.Type = "region")
let variants =     
    subtags
    |> Array.filter (fun subtag -> subtag.Type = "variant")



module RegistryXmlDocs = 
    open Xml_Documentation_Comments
    let xmldoc_by_record (subtag:Subtag) =
        summary {
            para { sprintf "Name: %s" subtag.Name }
            if subtag.Description.Length > 0 then 
                para { sprintf "Description: %s" (subtag.Description |> String.concat "\n") }
            para { sprintf "Type: %s" subtag.Type }
            para { sprintf "Added: %A" subtag.Added }

            if subtag.Comments.Length > 0 then 
                remarks { sprintf "Comments: %s" (subtag.Comments |> String.concat "\n") }
            if subtag.Macrolanguage.Length > 0 then 
                para { sprintf "Macrolanguage: %s" subtag.Macrolanguage }
            if subtag.PreferredValue.Length > 0 then 
                para { sprintf "PreferredValue: %s" subtag.PreferredValue }
            if subtag.Prefix.Length > 0 then 
                para { sprintf "Prefixes: %s" (subtag.Prefix |> String.concat "\n") }
            if subtag.Scope.IsSome then 
                para { sprintf "Scope: %s" subtag.Scope.Value }
            if subtag.SuppressScript.IsSome then 
                para { sprintf "SuppressScript: %s" subtag.SuppressScript.Value }
            if subtag.Tag.IsSome then 
                para { sprintf "Tag: %s" subtag.Tag.Value }

        
        }
        |> Render.toXElement
        |> fun xelement -> xelement.ToString()
        |> fun xelement_string -> xelement_string.Split("\n")

let langtag_directory_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\LanguageTags"



let language_subtags = 
                        Oak() {
                            Namespace("DoxAletheia"){

                                Union("Language_Subtag") {
                                    for subtag in languages do
                                        UnionCase(subtag.Name.normalize_identifier)
                                        |> _.xmlDocs(RegistryXmlDocs.xmldoc_by_record subtag)
                                }
                                |> _.attribute(Attribute("RequireQualifiedAccess"))
                            }
                            }
                            |> Gen.mkOak
                            |> Gen.run

File.WriteAllText($@"{langtag_directory_path}\LanguageSubtags.fs",language_subtags)








let extended_language_subtags = 
                        Oak() {
                            Namespace("DoxAletheia"){
                                Union("Extended_Language_Subtag") {
                                    for subtag in extended_languages do
                                        UnionCase(subtag.Name.normalize_identifier)
                                        |> _.xmlDocs(RegistryXmlDocs.xmldoc_by_record subtag)

                                }
                                |> _.attribute(Attribute("RequireQualifiedAccess"))
                            }
                            }
                            |> Gen.mkOak
                            |> Gen.run

File.WriteAllText($@"{langtag_directory_path}\Extended_Language_Subtags.fs",extended_language_subtags)








let script_subtags = 
                        Oak() {
                            Namespace("DoxAletheia"){

                                Union("Script_Subtag") {
                                    for subtag in scripts do
                                        UnionCase(subtag.Name.normalize_identifier)
                                        |> _.xmlDocs(RegistryXmlDocs.xmldoc_by_record subtag)

                                }
                            }
                            }
                            |> Gen.mkOak
                            |> Gen.run

File.WriteAllText($@"{langtag_directory_path}\Script_Subtags.fs",script_subtags)








let region_subtags = 
                        Oak() {
                            Namespace("DoxAletheia"){
                                Union("Region_Subtag") {
                                    for subtag in regions do
                                        let name = 
                                                match subtag.Name with 
                                                | name when Char.IsAsciiDigit name[0]->  "Z'" + name
                                                | name ->  name

                                        UnionCase(name.normalize_identifier)
                                        |> _.xmlDocs(RegistryXmlDocs.xmldoc_by_record subtag)

                                }
                            }
                            }
                            |> Gen.mkOak
                            |> Gen.run

File.WriteAllText($@"{langtag_directory_path}\Region_Subtags.fs",region_subtags)








let variant_subtags = 
                        Oak() {
                            Namespace("DoxAletheia"){

                                Union("Variant_Subtag") {
                                    for subtag in variants do
                                        UnionCase(subtag.Name.normalize_identifier)
                                        |> _.xmlDocs(RegistryXmlDocs.xmldoc_by_record subtag)

                                }
                                |> _.attribute(Attribute("RequireQualifiedAccess"))
                            }
                            }
                            |> Gen.mkOak
                            |> Gen.run

File.WriteAllText($@"{langtag_directory_path}\Variant_Subtags.fs",variant_subtags)







