#r "nuget: Arch, 2.1.0"

open Arch
open Arch.Core

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Parsing\Identifier\Resource\Resource_Identification.fsx"
open Resource_Identification


let world = World.Create()

let example = https.www.example.com.absolute_iri.as_string
