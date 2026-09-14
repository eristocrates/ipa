open System

#r "nuget: FSharp.Data"
#r "nuget: FSharp.Data.Mutator,0.2.0"
#r "nuget: FSharp.Data.JsonSchema.Core, 3.1.0"
#r "nuget: FSharp.Data.JsonSchema.NJsonSchema, 3.1.0"
#r "nuget: FSharp.Data.JsonSchema.OpenApi, 3.1.0"

open FSharp.Data
open FSharp.Data.Mutator
open FSharp.Data.JsonSchema
open FSharp.Data.JsonSchema.Core
open FSharp.Data.JsonSchema.OpenApi
open NJsonSchema

[<Literal>]
let valheimFilePath =
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Valheim\items.json"

let valheimIds =
    JsonProvider<Sample=valheimFilePath, UseOriginalNames=true>.Load valheimFilePath

valheimIds.items
|> Array.map (fun item -> item.Name)
|> Array.distinct
|> Array.sort
|> String.concat "\n"

(*
"A crude but useful weapon.
Ammo
AmmoNonEquipable
Bow
Chest
Consumable
Customization
Fish
Helmet
Legs
Material
Misc
NULL
OneHandedWeapon
Shield
Shoulder
Tool
Torch
Trophy
TwoHandedWeapon
TwoHandedWeaponLeft
Utility"
*)


(*

Ammo
Bow
OneHandedWeapon
TwoHandedWeapon
Shield
Tool

Torch
Consumable
Fish

Helmet
Shoulder
Chest
Legs

Material
Misc
Trophy
*)

let filteredItems =
    valheimIds.items |> Array.filter (fun item -> item.Type = "Misc")

filteredItems |> Array.randomChoice
filteredItems.Length
