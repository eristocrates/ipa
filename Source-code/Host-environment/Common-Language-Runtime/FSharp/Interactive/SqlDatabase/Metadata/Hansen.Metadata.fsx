#time on
fsi.PrintLength <- 10


open System
open System.Reflection
open System.Reflection.Emit
open Microsoft.FSharp.Reflection
open System.Diagnostics
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
open System.Text.RegularExpressions



#load @"C:\Secret\InforSecrets.fsx"

open InforSecrets

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq
open PowershellErgonomics



#r "nuget: Fabulous.AST"
open Fabulous.AST

open type Fabulous.AST.Ast
open Fantomas.FCS.Text

#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: SQLProvider.MsSql, 1.5.18"
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"


open XmlErgonomics
open type Xml



type InforProdSql =
    SqlDataProvider<ConnectionString=Prod.connection_string, IndividualsAmount=10000, UseOptionTypes=Common.NullableColumnType.OPTION>

let operations = InforProdSql.GetDataContext()

module MetaData =
    [<Literal>]
    let file_path =
        @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"

    let xml = XmlProvider<file_path>.Load file_path
    let navigator = XPathNavigator.Load(file_path)
module WebServices = 
  module Hansen = 
    module Resources =
      module Employee = 
        [<Literal>]
        let file_path =
          @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices\Resources\Hansen.Resources.Employee.wsdl"
        let wsdl = XmlProvider<file_path>.Load file_path


WebServices.Hansen.Resources.Employee.wsdl.Types.Schema.ComplexTypes
|> Array.iter ( fun ComplexType -> printfn "%s" ComplexType.Name)

MetaData.xml.HansenMetadata.ProductFamilies
|> Array.Parallel.filter (fun ProductFamily -> ProductFamily.Name = "Resources"  )
|> Array.Parallel.collect (fun Resources -> 
  Resources.Tables
  |> Array.Parallel.filter

)
