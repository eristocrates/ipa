#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System
open System.IO
open System.Text
open System.Threading.Tasks

#load @".paket/load/main.group.fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#r "Ipa.dll"

open Ipa

#r "Iana.dll"
open Iana
#r "IanaScheme.dll"

open Meziantou.Framework
// FullPath.FromPath KnownFolder.Downloads.DefaultPath
// TODO deal with resolving environment variables from KnownFolder


let Downloads = DriveInfo.C ../ @"Users\CollierB\Downloads"

let Scratch = personalDrive ../ @"Repositories\eristocrates\ipa\Scratch"
let GeneratedNamespaces = personalDrive ../ @"Repositories\eristocrates\ipa\fsx\Namespaces\Generated"
let fiboMaster = personalDrive ../ @"https\spec.edmcouncil.org\fibo\ontology\master"
