#if INTERACTIVE
#r "nuget: FSharp.Data"
#r "nuget: Iride"
#r "nuget: FsHttp"
#r @"C:\Repositories\IPS_Sites\integration\ResourceDescriptionFramework\bin\Debug\net10.0\ResourceDescriptionFramework.dll"
#load @"C:\Repositories\IPS_Sites\integration\SharedKernel\Sanitation.fs"
#load @"C:\Repositories\IPS_Sites\integration\SharedKernel\InvalidFileNameCharacter.fs"
#endif




open System
open System.IO
open System.Text



open FsHttp
open FSharp.Data



open SharedKernel
open Program
open Ergonomics
open Shorthand
open LangTag


open Rdf.Namespace
open Rdfs.Namespace
open Owl.Namespace
open Xsd.Namespace
open Xs.Namespace
open Xml.spec.Namespace
open Dcat.Namespace
open Dcmi.dcterms.Namespace
