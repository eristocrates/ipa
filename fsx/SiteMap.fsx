#time on
fsi.PrintLength <- 1
fsi.ShowDeclarationValues <- false
#r "nuget: Newtonsoft.Json, 13.0.0.0"

#I @"D:\https\com\github\eristocrates\ipa\dll"
#I @"D:\https\com\github\eristocrates\ipa\fs\DoxAletheia\src\DoxAletheia.Runtime\bin\Release\net10.0"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#I @"D:\https\com\github\eristocrates\ipa\fsx\.paket\load"
#load "Me.fsx"
open Me
#load "Clipboard.fsx"
open Clipboard
//#load @".paket/load/main.group.fsx"
#r "DoxAletheia.Runtime.dll"
open DoxAletheia
open DoxAletheia.Runtime
// open type Functional

// open Ada.Url
open AngleSharp.Attributes
open AngleSharp.Dom
open AngleSharp.Html.Parser
open BrowserApi.Common
open BrowserApi.Css.Authoring
open canopy
// open Dubzer.WhatwgUrl
open DynamicObj
open Fabulous.AST.Json
// open Fli
open Flurl
open FolkerKinzel.MimeTypes
open FSharp.Data
open FSharp.Data.JsonExtensions
open FSharp.Data.JsonPath
open FSharp.Data.JsonSchema
open FSharp.Data.JsonSchema.Core
open FSharp.Data.JsonSchema.OpenApi
open FSharp.Json
// open FSharpPlus
open FsHttp
// open FsPublicSuffix
open HCollections
// open Iana
// open IriTools
// open Json.More
// open Json.Path
// open Json.Pointer
// open JsonStructure
open Meziantou.Framework
open MimeDetective
// open Nager.PublicSuffix
// open Nager.PublicSuffix.Models
// open Nager.PublicSuffix.RuleParsers
// open Nager.PublicSuffix.RuleProviders
// open Newtonsoft.Json
// open Newtonsoft.Json.Linq
// open NJsonSchema
// open NLanguageTag
// open NuGet
// open NuGet.CatalogReader
// open NuGet.Common
// open NuGet.Protocol
// open NuGet.Protocol.Core.Types
// open NuGet.Protocol.Resources
open OpenQA.Selenium
open OpenQA.Selenium.Edge
open OpenQA.Selenium.Remote
open ProviderImplementation.ProvidedTypes
open PuppeteerSharp
open PuppeteerSharp.Cdp
open PuppeteerSharp.Cdp.Messaging
// open RDFSharp.Model
open ShapeSifter
open ShapeSifter.Patterns
open System
open System.Collections
open System.Collections.Concurrent
// open System.ComponentModel.DataAnnotations
// open System.Diagnostics
// open System.Globalization
open System.IO
open System.IO.Compression
open System.Linq
// open System.Net
// open System.Numerics
open System.Reflection
// open System.Security.Cryptography
// open System.Text
open System.Text.Json
// open System.Text.Json.Schema
// open System.Text.Json.Serialization
// open System.Text.RegularExpressions
open System.Threading
open System.Threading.Tasks
// open System.Xml
// open System.Xml.Schema
// open System.Xml.Linq
open System.Xml.XPath
// open Tavis.UriTemplates
open TypeEquality
open TypeShape
open TypeShape.Core
// open VDS.Common.Tries
open VDS.RDF
open WebSharper.Core 
open Dramaturge
open Dramaturge.Browsers
open Dramaturge.Network
open AW.Identifiers

open LSL.DataUri

open Microsoft.FSharp.Linq.RuntimeHelpers
open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open Microsoft.FSharp.Reflection
open Microsoft.VisualBasic.FileIO
open System.Numerics
open PuppeteerSharp.Input

type JsonNode = Nodes.JsonNode
type JsonNodeObject = Nodes.JsonObject
type JsonNodeArray = Nodes.JsonArray
type JsonNodeValue = Nodes.JsonValue
module FSharpLiteral = FSharp.Literals.Literal

type UriSchemes = Iana.RegistryProvider.``Uniform Resource Identifier (URI) Schemes``.``Uniform Resource Identifier (URI) Schemes``
type PublicSuffixes = PublicSuffixList.PublicSuffixProvider
type Mime = Iana.InternetMediaTypeProvider
let iriref (iriString: string) = Iri.op_Implicit iriString

let irlref (irlString:string) = Url.Parse irlString |> Irl.ofUrl
