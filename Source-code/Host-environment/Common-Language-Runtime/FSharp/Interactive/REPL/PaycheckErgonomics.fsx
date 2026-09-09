#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
# time on
fsi.ShowDeclarationValues <- true




#r "Metaprogramming.dll"

open Metaprogramming
#r "PathErgonomics.dll"

open PathErgonomics
#r "BrowserErgonomics.dll"
open BrowserErgonomics
#r "PageErgonomics.dll"
open PageErgonomics
#r "HtmlErgonomics.dll"
open HtmlErgonomics
#r "TaskErgonomics.dll"
open TaskErgonomics
#r "SparqlErgonomics.dll"
open SparqlErgonomics

#r "RdfAsm.dll"

open RdfAsm

#r "RdfIO.dll"

open RdfIO

#r "RdfDsl.dll"

open RdfDsl

#r "UrlErgonomics.dll"

open UrlErgonomics

open FSharp.Data
open FSharp.Configuration
open Dubzer.WhatwgUrl
open PuppeteerSharp
open PuppeteerSharp.Cdp
open FsHttp
open System.IO.Compression
open System.IO
open VDS.RDF.Query.Datasets
open VDS.RDF
open VDS.RDF.Parsing
open System
open System.Linq
open FolkerKinzel.MimeTypes
open IriTools
open System.Threading
open Humanizer
open Fabulous.AST
open Fantomas.Core
open BrowserApi.Css.Authoring


module Syntech = 
    let checkDirectory = DirectoryInfo @"C:\Secret\Syntech"
    let hireDate = DateTime(2025,12,15)
    [<Literal>]
    let sampleJsonPath = @"C:\Secret\Syntech\sample.json"
    [<Literal>]
    let sampleHtmlPath = @"C:\Secret\Syntech\sample.html"
    type CheckJsonProvider = JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="page", Sample=sampleJsonPath>
    type CheckHtmlProvider = HtmlProvider<PreferOptionals=true, PreferDateOnly=true,   Sample=sampleHtmlPath>
    let testJson = CheckJsonProvider.Load(@"C:\Secret\Syntech\2026-07-31\2026-07-31_page001.json")[0]
    let testHtml = testJson.blocks[8].content.JsonValue.AsString() |> CheckHtmlProvider.Parse 


Syntech.testJson.blocks |> Array.mapi (fun index block -> $"block[{index}] = {block.content.JsonValue.AsString()}") |> String.concat "\n" |> clip
Syntech.testJson.blocks[8].content
let headerValues = 
    Syntech.testHtml.Tables.Table1.Headers.Value
    |> Array.distinct
    |> Array.filter (fun tableHeader -> tableHeader.Contains(":"))



Syntech.testHtml.Tables.Table1.Rows.Length
Syntech.testHtml.Tables.Table1.Rows[0]





let rowValues = 
    Syntech.testHtml.Tables.Table1.Rows
    |> Array.mapi (fun index row -> 
        match row.ToValueTuple() with 
        | first, second, third, fourth, fifth, sixth, seventh, eighth, ninth, tenth, eleventh, twelvth  -> 
            [|

                Some first
                second
                third
                fourth
                fifth
                sixth
                seventh
                eighth
                ninth
                tenth
                eleventh
                twelvth 

            |]

    )
let keyDelimiterValue (delimiter:string) (rowValue:string) = 
    match rowValue.Split(delimiter,StringSplitOptions.TrimEntries) with 
    | [| left ; right |] -> left, right

let trimAttributeKeyColon  ((attributeKey:string),(attributeValue:string)) = attributeKey.TrimEnd(':'), attributeValue

type StringAttribute = 
    {
        attributeKey:string
        stringValue:string
    }
    static member mapped (mapping: string * string -> string * string) ((leftIndex:int),(rightIndex:int)) = 
        let keyValue = mapping((rowValues[leftIndex][rightIndex]).Value, (rowValues[leftIndex][rightIndex + 1]).Value)
        {
            attributeKey = fst keyValue
            stringValue = snd keyValue
        }
    static member delimited (delimiter:string) ((leftIndex:int),(rightIndex:int)) = 
        let keyValue = keyDelimiterValue delimiter (rowValues[leftIndex][rightIndex]).Value

        {
            attributeKey = fst keyValue
            stringValue = snd keyValue 
        }

type IntAttribute = 
    {
        attributeKey:string
        intValue:int
    }
    static member mapped (mapping: string * string -> string * string) ((leftIndex:int),(rightIndex:int)) = 
        let keyValue = mapping((rowValues[leftIndex][rightIndex]).Value, (rowValues[leftIndex][rightIndex + 1]).Value)
        {
            attributeKey = fst keyValue
            intValue = snd keyValue |> int
        }
    static member delimited (delimiter:string) ((leftIndex:int),(rightIndex:int)) = 
        let keyValue = keyDelimiterValue delimiter (rowValues[leftIndex][rightIndex]).Value

        {
            attributeKey = fst keyValue
            intValue = snd keyValue |> int
        }
type DecimalAttribute = 
    {
        attributeKey:string
        decimalValue:decimal
    }
    static member mapped (mapping: string * string -> string * string) ((leftIndex:int),(rightIndex:int)) = 
        let keyValue = mapping((rowValues[leftIndex][rightIndex]).Value, (rowValues[leftIndex][rightIndex + 1]).Value)
        {
            attributeKey = fst keyValue
            decimalValue = snd keyValue |> Decimal.Parse
        }
    static member delimited (delimiter:string) ((leftIndex:int),(rightIndex:int)) = 
        let keyValue = keyDelimiterValue delimiter (rowValues[leftIndex][rightIndex]).Value

        {
            attributeKey = fst keyValue
            intValue = snd keyValue |> int
        }
type CharAttribute = 
    {
        attributeKey:string
        charValue:char
    }
    static member delimited (delimiter:string) ((leftIndex:int),(rightIndex:int)) = 
        let keyValue = keyDelimiterValue delimiter (rowValues[leftIndex][rightIndex]).Value

        {
            attributeKey = fst keyValue
            charValue = snd keyValue |> char
        }
type WageAttribute = 
    {
        attributeKey:string
        currentValue:decimal
        yearToDateValue:decimal
    }

    static member delimited (delimiter:string) ((leftIndex:int),(rightIndex:int)) = 
        let keyCurrentValue = keyDelimiterValue delimiter (rowValues[leftIndex][rightIndex]).Value
        let blankYearToDateValue = keyDelimiterValue delimiter (rowValues[leftIndex + 1][rightIndex]).Value

        {
            attributeKey = fst keyCurrentValue
            currentValue = snd keyCurrentValue |> Decimal.Parse
            yearToDateValue = snd blankYearToDateValue |> Decimal.Parse
        }
    static member keyDelimited (delimiter:string) ((leftIndex:int),(rightIndex:int)) = 
        let keyCurrentValue = keyDelimiterValue delimiter (rowValues[leftIndex][rightIndex]).Value

        {
            attributeKey = fst keyCurrentValue
            currentValue = snd keyCurrentValue |> Decimal.Parse
            yearToDateValue = (rowValues[leftIndex + 1][rightIndex]).Value |> Decimal.Parse
        }
type HourAttribute = 
    {
        accruedYearToDate: decimal
        takenYearToDate: decimal
        balance: decimal
    }

    static member fromIndexes  ((leftIndex:int),(rightIndex:int)) = 
        let keyAccrValue = keyDelimiterValue " - YTD " (rowValues[leftIndex][rightIndex]).Value
        let keyTakenValue = keyDelimiterValue " - YTD " (rowValues[leftIndex][rightIndex + 1]).Value
        let keyBalanceValue = keyDelimiterValue " " (rowValues[leftIndex][rightIndex + 2]).Value
        {
            accruedYearToDate = snd keyAccrValue  |> Decimal.Parse
            takenYearToDate = snd keyTakenValue |> Decimal.Parse
            balance = snd keyBalanceValue |> Decimal.Parse
        }




let testLeft = 0
let testRight = 2
(rowValues[testLeft][testRight]), (rowValues[testLeft][testRight + 1]), (rowValues[testLeft][testRight + 2])



type SyntechCheck = 
    {
        
        EmployeeNumber : StringAttribute
        DepartmentID : IntAttribute
        SocialSecurityNumber : StringAttribute
        Marital : CharAttribute
        FederalExeption : IntAttribute
        StateExemption : IntAttribute
        ResidentState : StringAttribute
        WorkState : StringAttribute
        GrossWages : WageAttribute
        FederalIncomeTax : WageAttribute
        OldAgeSurvivorsAndDisabilityInsurance : WageAttribute
        Medicare : WageAttribute
        StateIncomeTax : WageAttribute
        Local1 : WageAttribute
        Local3 : WageAttribute
        Local4 : WageAttribute
        Deductions : WageAttribute
        NetPay : StringAttribute
        VacationHours : HourAttribute
        EmergencyHours : HourAttribute
    }
    member this.Last4SSN = this.SocialSecurityNumber.stringValue.Replace("XXX-XX-", "")  |> int


let check2026_7_31 = 
    {


        EmployeeNumber = (0, 0) |> StringAttribute.mapped  trimAttributeKeyColon
        DepartmentID =  (0, 2) |> IntAttribute.mapped trimAttributeKeyColon
        SocialSecurityNumber = (0, 4) |> StringAttribute.delimited ":" 
        Marital = (0, 6) |> CharAttribute.delimited ":"
        FederalExeption = (0, 7) |>  IntAttribute.delimited ":"
        StateExemption = (0, 8) |>  IntAttribute.delimited ":"
        ResidentState = (0, 9) |> StringAttribute.delimited ":"
        WorkState = (0, 10) |>StringAttribute.delimited ":"
        GrossWages = (1,1) |> WageAttribute.delimited "$"
        FederalIncomeTax = (1,2) |> WageAttribute.keyDelimited " "
        OldAgeSurvivorsAndDisabilityInsurance = (1,3) |> WageAttribute.keyDelimited " "
        Medicare = (1,4) |> WageAttribute.keyDelimited " "
        StateIncomeTax = (1,5) |> WageAttribute.keyDelimited " "
        Local1 = (1,6) |> WageAttribute.keyDelimited " "
        Local3 = (1,7) |> WageAttribute.keyDelimited " "
        Local4 = (1,8) |> WageAttribute.keyDelimited " "
        Deductions = (1,9) |> WageAttribute.keyDelimited " "
        NetPay = (1,10) |> StringAttribute.delimited "$"
        VacationHours = (3,3) |> HourAttribute.fromIndexes
        EmergencyHours = (3,7) |> HourAttribute.fromIndexes

        
    }

check2026_7_31.Last4SSN