#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "CssErgonomics.dll"

open System
open System.IO

open FsHttp
open ChromeProtocol.Domains
open BrowserApi.Css.Authoring
open PuppeteerSharp.Cdp
open Dubzer.WhatwgUrl
open Meziantou.Framework
open FolkerKinzel.MimeTypes
