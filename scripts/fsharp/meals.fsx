#r @"C:\Solutions\Modernization\ConsoleFsharp\bin\Debug\net10.0\ConsoleFsharp.dll"
#r "nuget: Iride"
open Rdf.Namespace
open Program
open Shorthand
open Shorthand

let defaultGraph = Communication.Internet.Standard.Resource.Identifier.Internationalized.inhabitant
                        defaultGraphUriString
                        None
                        None 
                        None
// breakfast
// grits and eggs
// sausage patty

// lunch
// jambalaya
// rice

// dinner
// rice pilaf
// fried catfish



GraphRuntime.defaultGraph.Clear()
let a = rdf.``type``
let unprefixed = mint.prefixID "urn:unprefixed:" ""
unprefixed.prefix "newtest" --- a --> unprefixed.prefix "example" >-: defaultGraph
Serialization.Turtle.save Artifact.test.ttl GraphRuntime.defaultGraph