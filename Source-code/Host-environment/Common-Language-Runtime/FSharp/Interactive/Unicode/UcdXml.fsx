
open System
open System.IO
open System.Xml
open System.Xml.Linq
open System.Xml.XPath


#r "nuget: FSharp.Data"
open FSharp.Data


#r "nuget:  Fabulous.AST"
open Fabulous.AST
open Fantomas.Core.SyntaxOak
open type Fabulous.AST.Ast

module ucd =

    [<Literal>]
    let file_path = @"D:\Surface\Standards\Unicode\UCD\17.0.0\ucdxml\ucd.all.flat.xml"

    let xml = XmlProvider<file_path>.Load(file_path)

let block_directory_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\Unicode\Block"

type Block = 
  {
    name:string
    first_cp:int
    last_cp:int
  }

ucd.xml.Blocks
|> Array.Parallel.map (fun Block -> 

  let block_directory = Path.Combine(block_directory_path, Block.Name.Replace(" ","_"))
  Directory.CreateDirectory(block_directory)

  let block = 
    {
      name = Block.Name
      first_cp = "0x" + Block.FirstCp.Value |> int
      last_cp = "0x" + Block.LastCp |> int
    }

  )

