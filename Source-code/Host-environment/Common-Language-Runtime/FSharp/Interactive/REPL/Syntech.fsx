#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#time on
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

let hireDate = DateTime(2025, 12, 15)
[<Literal>]
let sampleJsonPath = @"C:\Secret\Syntech\sample.json"
[<Literal>]
let sampleHtmlPath = @"C:\Secret\Syntech\sample.html"
type PayStubJsonProvider = JsonProvider<UseOriginalNames=true, PreferDateOnly=true, OmitNullFields=true, RootName="page", Sample=sampleJsonPath>
type PayStubHtmlProvider = HtmlProvider<PreferOptionals=true, PreferDateOnly=true, Sample=sampleHtmlPath>

module Folder =
    let Syntech = DirectoryInfo @"C:\Secret\Syntech"



type StringAttribute = {
    attributeKey: string
    stringValue: string
}

type IntAttribute = { attributeKey: string; intValue: int }
type DecimalAttribute = {
    attributeKey: string
    decimalValue: decimal
}
type CharAttribute = {
    attributeKey: string
    charValue: char
}
type WageAttribute = {
    attributeKey: string
    currentValue: decimal
    yearToDateValue: decimal
}

type HourAttribute = {
    accruedYearToDate: decimal
    takenYearToDate: decimal
    balance: decimal
}













// TODO encapsulate this type, module, extension pattern via Fablous.AST
type CartesianPoint = OrderedPair of int * int
module CartesianPoint =
    let orderedPair (cartesianPoint: CartesianPoint) =
        match cartesianPoint with
        | OrderedPair(abscissa, ordinate) -> abscissa, ordinate
    let abscissa (cartesianPoint: CartesianPoint) =
        match cartesianPoint with
        | OrderedPair(abscissa, ordinate) -> abscissa
    let ordinate (cartesianPoint: CartesianPoint) =
        match cartesianPoint with
        | OrderedPair(abscissa, ordinate) -> ordinate
    let translate ((abscissaDistance: int), (ordinateDistance: int)) (cartesianPoint: CartesianPoint) =
        match cartesianPoint with
        | OrderedPair(abscissa, ordinate) -> OrderedPair(abscissa + abscissaDistance, ordinate + ordinateDistance)
    let horizontalShift (distance: int) (cartesianPoint: CartesianPoint) =
        cartesianPoint |> translate (0, distance)
    let verticalShift (distance: int) (cartesianPoint: CartesianPoint) =
        cartesianPoint |> translate (distance, 0)
type CartesianPoint with
    member this.orderedPair = this |> CartesianPoint.orderedPair
    member this.abscissa = this |> CartesianPoint.abscissa
    member this.ordinate = this |> CartesianPoint.ordinate
    member this.translate (abscissaDistance: int) (ordinateDistance: int) =
        this |> CartesianPoint.translate (ordinateDistance, abscissaDistance)
    member this.horizontalShift(distance: int) =
        this |> CartesianPoint.horizontalShift distance
    member this.verticalShift(distance: int) =
        this |> CartesianPoint.verticalShift distance

type CoordinatePlane<'PointType> = Map<CartesianPoint, 'PointType>
type PayStub = {
    payStubFile: FileInfo
} with

    member this.pdfJson = PayStubJsonProvider.Load(this.payStubFile.FullName)[0]
    member this.htmlTable =
        this.pdfJson.blocks[8].content.JsonValue.AsString()
        |> PayStubHtmlProvider.Parse
        |> _.Tables.Table1
    member this.rowValues =
        this.htmlTable.Rows
        |> Array.map (fun row ->
            match row.ToValueTuple() with
            | first, second, third, fourth, fifth, sixth, seventh, eighth, ninth, tenth, eleventh, twelvth -> [|

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
    member this.headerValues = this.htmlTable.Headers.Value |> Array.map Some
    member this.tableValues = Array.concat [| [| this.headerValues |]; this.rowValues |]
    member this.coordinatePlane: CoordinatePlane<string option> =
        [|
            for rowIndex = 0 to this.tableValues.Length - 1 do
                let tableRow = this.tableValues[rowIndex]
                for columnIndex = 0 to tableRow.Length - 1 do
                    OrderedPair(rowIndex, columnIndex), tableRow[columnIndex]
        |]
        |> Map.ofArray
    member this.keyValueFromSplit (delimiter: string) (rawValue: string) =
        match rawValue.Split(delimiter, StringSplitOptions.TrimEntries) with
        | [| left; right |] -> left, right

module PayStub =
    let all =
        Folder.Syntech.GetFiles("*_page001.json", SearchOption.AllDirectories)
        |> Array.map (fun jsonFile -> { payStubFile = jsonFile })
    // |> Array.sortBy (fun payStub -> payStub.Ch)
    let last = all |> Array.last


type String with
    member this.splitByDelimiter(delimiter: string) =
        match this.Split(delimiter, StringSplitOptions.TrimEntries) with
        | [| left; right |] -> left, right
        | _ -> this, this

// TODO next refactor keyString and valueString to reduce duplication/be more maintainable

let splitByDelimiter (property: string) =
    match property with
    | keyValueString when keyValueString.Contains(": $") -> keyValueString.splitByDelimiter ": $"
    | keyValueString when keyValueString.Contains(" $") -> keyValueString.splitByDelimiter " $"
    | keyValueString when keyValueString.Contains(":") -> keyValueString.splitByDelimiter ":"
    | keyValueString when keyValueString.Contains("- YTD") -> keyValueString.splitByDelimiter "- YTD"

    | keyValueString -> keyValueString.splitByDelimiter " "


type PayStubAttribute =
    | SimpleAttribute of CartesianPoint
    | ComplexAttribute of CartesianPoint * CartesianPoint

    member this.rawKeyValue(payStub: PayStub) =
        match this with
        | SimpleAttribute keyValueCoordinates -> splitByDelimiter payStub.coordinatePlane[keyValueCoordinates].Value
        | ComplexAttribute(keyCoordinates, valueCoordinates) ->
            splitByDelimiter payStub.coordinatePlane[keyCoordinates].Value |> fst, splitByDelimiter payStub.coordinatePlane[valueCoordinates].Value |> snd
    member this.keyString(payStub: PayStub) =
        match this.rawKeyValue payStub with
        | keyString, valueString -> keyString
    member this.valueString(payStub: PayStub) =
        match this.rawKeyValue payStub with
        | keyString, valueString when valueString.StartsWith('$') -> valueString.TrimStart('$')
        | keyString, valueString -> valueString
    member this.columnShift(distance: int) =
        match this with
        | SimpleAttribute keyValueCoordinates -> keyValueCoordinates.horizontalShift distance |> SimpleAttribute
        | ComplexAttribute(keyCoordinates, valueCoordinates) -> ComplexAttribute(keyCoordinates.horizontalShift distance, valueCoordinates.horizontalShift distance)
    member this.rowShift(distance: int) =
        match this with
        | SimpleAttribute keyValueCoordinates -> keyValueCoordinates.verticalShift distance |> SimpleAttribute
        | ComplexAttribute(keyCoordinates, valueCoordinates) -> ComplexAttribute(keyCoordinates.verticalShift distance, valueCoordinates.verticalShift distance)
(*

    member this.originalString (payStub : PayStub) = payStub.coordinatePlane[this.coordinates].Value
    member this.isColonDelimited(payStub : PayStub) = this.originalString(payStub).Contains(":")
    member this.splitByDelimiter (delimiter:string)(payStub : PayStub)  =
                match this.originalString(payStub).Split(delimiter, StringSplitOptions.TrimEntries) with
                | [| left; right |] -> left, right

    member this.tryKeyValue (payStub : PayStub) = 
        match this.originalString(payStub) with 
        | originalString when originalString.Contains(":") -> originalString.splitByDelimiter ":" |> Some
        | _ -> None

*)

module PayStubAttribute =
    let simpleCoordinate ((rowIndex: int), (columnIndex: int)) =
        OrderedPair(rowIndex, columnIndex) |> SimpleAttribute
    let complexCoordinateColumnShifted (distance: int) ((rowIndex: int), (columnIndex: int)) =
        ComplexAttribute(OrderedPair(rowIndex, columnIndex), OrderedPair(rowIndex, columnIndex + distance))
    let complexCoordinateRowShifted (distance: int) ((rowIndex: int), (columnIndex: int)) =
        ComplexAttribute(OrderedPair(rowIndex, columnIndex), OrderedPair(rowIndex + distance, columnIndex))

    let containsKey (key: string) (keySet: Set<string>) = keySet.Contains key

    let Name = simpleCoordinate (0, 3)
    let ProcessID = Name.columnShift 2
    let CheckDate = ProcessID.columnShift 2
    let BasePayRate = CheckDate.columnShift 4
    let EmployeeNumber = (1, 0) |> complexCoordinateColumnShifted 1
    let DepartmentID = EmployeeNumber.columnShift 2
    let SocialSecurityNumber = simpleCoordinate (1, 5)
    let MaritalStatus = SocialSecurityNumber.columnShift 1
    let FederalExeption = MaritalStatus.columnShift 1
    let StateExemption = FederalExeption.columnShift 1
    let ResidentState = StateExemption.columnShift 1
    let WorkState = ResidentState.columnShift 2
    let GrossWagesCurrent = simpleCoordinate (2, 1)
    let FederalIncomeTaxCurrent = GrossWagesCurrent.columnShift 1
    let OldAgeSurvivorsAndDisabilityInsuranceCurrent = FederalIncomeTaxCurrent.columnShift 1
    let MedicareCurrent = OldAgeSurvivorsAndDisabilityInsuranceCurrent.columnShift 1
    let StateIncomeTaxCurrent = MedicareCurrent.columnShift 1
    let Local1Current = StateIncomeTaxCurrent.columnShift 1
    let Local3Current = Local1Current.columnShift 1
    let Local4Current = Local3Current.columnShift 1
    let DeductionsCurrent = Local4Current.columnShift 1
    let NetPay = DeductionsCurrent.columnShift 2
    let GrossWagesYearToDate = (2, 1) |> complexCoordinateRowShifted 1
    let FederalIncomeTaxYearToDate = GrossWagesCurrent.rowShift 1
    let OldAgeSurvivorsAndDisabilityInsuranceYearToDate = FederalIncomeTaxCurrent.rowShift 1
    let MedicareYearToDate = OldAgeSurvivorsAndDisabilityInsuranceCurrent.rowShift 1
    let StateIncomeTaxYearToDate = MedicareCurrent.rowShift 1
    let Local1YearToDate = StateIncomeTaxCurrent.rowShift 1
    let Local3YearToDate = Local1Current.rowShift 1
    let Local4YearToDate = Local3Current.rowShift 1
    let DeductionsYearToDate = Local4Current.rowShift 1
    let VacationHoursAccrued = simpleCoordinate (4, 3)
    let VacationHoursTaken = VacationHoursAccrued.columnShift 1
    let VacationHoursBalance = VacationHoursTaken.columnShift 1
    let EmergencyHoursAccrued = VacationHoursBalance.columnShift 2
    let EmergencyHoursTaken = EmergencyHoursAccrued.columnShift 1
    let EmergencyHoursBalance = EmergencyHoursTaken.columnShift 1



type PayStub with
    member this.tryAttribute<'AttributeType> (valueMapping: string -> 'AttributeType option) (attribute: PayStubAttribute) =
        attribute.valueString (this) |> valueMapping

type HumanName = {
    firstName: string
    middleInitial: string
    lastName: string
} with

    member this.asString = sprintf "%s %s %s" this.firstName this.middleInitial this.lastName
module HumanName =
    let attributeKeys = set [ "Name" ]
    let tryValue (rawValue: string) =
        match rawValue.Split(' ') with
        | [| first; second; third |] ->
            Some {
                firstName = first
                middleInitial = second
                lastName = third
            }
        | _ -> None




type ProcessID =
    | ProcessID of int * int * int

    member this.digits =
        match this with
        | ProcessID(first, second, third) -> first, second, third
    member this.first =
        match this with
        | ProcessID(first, second, third) -> first
    member this.second =
        match this with
        | ProcessID(first, second, third) -> second
    member this.third =
        match this with
        | ProcessID(first, second, third) -> third
    member this.asString = sprintf "0%d-%d-%d" this.first this.second this.third


module ProcessID =
    let attributeKeys = set [ "Proc ID" ]
    let isKnownKey (rawValue: string) = attributeKeys.Contains rawValue

    let tryValue (rawValue: string) =
        match rawValue.Split('-') with
        | [| first; second; third |] -> ProcessID(int first, int second, int third) |> Some
        | _ -> None



type PayStub with
    member this.Name = PayStubAttribute.Name |> this.tryAttribute HumanName.tryValue |> Option.get
    member this.ProcessID = PayStubAttribute.ProcessID |> this.tryAttribute ProcessID.tryValue |> Option.get
    member this.CheckDate = this |> PayStubAttribute.CheckDate.valueString |> DateTime.Parse
    member this.DepositKind = "Direct Deposit"
    member this.BasePayRate = this |> PayStubAttribute.BasePayRate.valueString |> Decimal.Parse
    member this.EmployeeNumber = this |> PayStubAttribute.EmployeeNumber.valueString
    member this.DepartmentID = this |> PayStubAttribute.DepartmentID.valueString |> int
    member this.SocialSecurityNumber = this |> PayStubAttribute.SocialSecurityNumber.valueString
    member this.last4SSN = this.SocialSecurityNumber.Replace("XXX-XX-", "") |> int
    member this.MaritalStatus =
        match this |> PayStubAttribute.MaritalStatus.valueString with
        | "S" -> "Single"
        | status -> status
    member this.FederalExeption = this |> PayStubAttribute.FederalExeption.valueString |> int
    member this.StateExemption = this |> PayStubAttribute.StateExemption.valueString |> int
    member this.ResidentState = this |> PayStubAttribute.ResidentState.valueString
    member this.WorkState = this |> PayStubAttribute.WorkState.valueString
    member this.GrossWagesCurrent = this |> PayStubAttribute.GrossWagesCurrent.valueString |> Decimal.Parse
    member this.FederalIncomeTaxCurrent = this |> PayStubAttribute.FederalIncomeTaxCurrent.valueString |> Decimal.Parse
    member this.OldAgeSurvivorsAndDisabilityInsuranceCurrent =
        this
        |> PayStubAttribute.OldAgeSurvivorsAndDisabilityInsuranceCurrent.valueString
        |> Decimal.Parse
    member this.MedicareCurrent = this |> PayStubAttribute.MedicareCurrent.valueString |> Decimal.Parse
    member this.StateIncomeTaxCurrent = this |> PayStubAttribute.StateIncomeTaxCurrent.valueString |> Decimal.Parse
    member this.Local1Current = this |> PayStubAttribute.Local1Current.valueString |> Decimal.Parse
    member this.Local3Current = this |> PayStubAttribute.Local3Current.valueString |> Decimal.Parse
    member this.Local4Current = this |> PayStubAttribute.Local4Current.valueString |> Decimal.Parse
    member this.DeductionsCurrent = this |> PayStubAttribute.DeductionsCurrent.valueString |> Decimal.Parse
    member this.NetPay = this |> PayStubAttribute.NetPay.valueString |> Decimal.Parse
    member this.GrossWagesYearToDate = this |> PayStubAttribute.GrossWagesYearToDate.valueString |> Decimal.Parse
    member this.FederalIncomeTaxYearToDate = this |> PayStubAttribute.FederalIncomeTaxYearToDate.valueString |> Decimal.Parse
    member this.OldAgeSurvivorsAndDisabilityInsuranceYearToDate =
        this
        |> PayStubAttribute.OldAgeSurvivorsAndDisabilityInsuranceYearToDate.valueString
        |> Decimal.Parse
    member this.MedicareYearToDate = this |> PayStubAttribute.MedicareYearToDate.valueString |> Decimal.Parse
    member this.StateIncomeTaxYearToDate = this |> PayStubAttribute.StateIncomeTaxYearToDate.valueString |> Decimal.Parse
    member this.Local1YearToDate = this |> PayStubAttribute.Local1YearToDate.valueString |> Decimal.Parse
    member this.Local3YearToDate = this |> PayStubAttribute.Local3YearToDate.valueString |> Decimal.Parse
    member this.Local4YearToDate = this |> PayStubAttribute.Local4YearToDate.valueString |> Decimal.Parse
    member this.DeductionsYearToDate = this |> PayStubAttribute.DeductionsYearToDate.valueString |> Decimal.Parse
    member this.VacationHoursAccrued = this |> PayStubAttribute.VacationHoursAccrued.valueString |> Decimal.Parse
    member this.VacationHoursTaken = this |> PayStubAttribute.VacationHoursTaken.valueString |> Decimal.Parse
    member this.VacationHoursBalance = this |> PayStubAttribute.VacationHoursBalance.valueString |> Decimal.Parse
    member this.EmergencyHoursAccrued = this |> PayStubAttribute.EmergencyHoursAccrued.valueString |> Decimal.Parse
    member this.EmergencyHoursTaken = this |> PayStubAttribute.EmergencyHoursTaken.valueString |> Decimal.Parse
    member this.EmergencyHoursBalance = this |> PayStubAttribute.EmergencyHoursBalance.valueString |> Decimal.Parse


(*
let testAttribute = PayStubAttribute.GrossWagesYearToDate

PayStub.last |> testAttribute.keyString
PayStub.last |> testAttribute.valueString

Console.WriteLine $"{PayStub.last |> PayStubAttribute.Name.keyString} : {PayStub.last |> PayStubAttribute.Name.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.ProcessID.keyString} : {PayStub.last |> PayStubAttribute.ProcessID.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.CheckDate.keyString} : {PayStub.last |> PayStubAttribute.CheckDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.BasePayRate.keyString} : {PayStub.last |> PayStubAttribute.BasePayRate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.EmployeeNumber.keyString} : {PayStub.last |> PayStubAttribute.EmployeeNumber.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.DepartmentID.keyString} : {PayStub.last |> PayStubAttribute.DepartmentID.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.SocialSecurityNumber.keyString} : {PayStub.last |> PayStubAttribute.SocialSecurityNumber.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.MaritalStatus.keyString} : {PayStub.last |> PayStubAttribute.MaritalStatus.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.FederalExeption.keyString} : {PayStub.last |> PayStubAttribute.FederalExeption.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.StateExemption.keyString} : {PayStub.last |> PayStubAttribute.StateExemption.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.ResidentState.keyString} : {PayStub.last |> PayStubAttribute.ResidentState.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.WorkState.keyString} : {PayStub.last |> PayStubAttribute.WorkState.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.GrossWagesCurrent.keyString} : {PayStub.last |> PayStubAttribute.GrossWagesCurrent.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.FederalIncomeTaxCurrent.keyString} : {PayStub.last |> PayStubAttribute.FederalIncomeTaxCurrent.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.OldAgeSurvivorsAndDisabilityInsuranceCurrent.keyString} : {PayStub.last |> PayStubAttribute.OldAgeSurvivorsAndDisabilityInsuranceCurrent.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.MedicareCurrent.keyString} : {PayStub.last |> PayStubAttribute.MedicareCurrent.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.StateIncomeTaxCurrent.keyString} : {PayStub.last |> PayStubAttribute.StateIncomeTaxCurrent.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.Local1Current.keyString} : {PayStub.last |> PayStubAttribute.Local1Current.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.Local3Current.keyString} : {PayStub.last |> PayStubAttribute.Local3Current.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.Local4Current.keyString} : {PayStub.last |> PayStubAttribute.Local4Current.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.DeductionsCurrent.keyString} : {PayStub.last |> PayStubAttribute.DeductionsCurrent.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.NetPay.keyString} : {PayStub.last |> PayStubAttribute.NetPay.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.GrossWagesYearToDate.keyString} : {PayStub.last |> PayStubAttribute.GrossWagesYearToDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.FederalIncomeTaxYearToDate.keyString} : {PayStub.last |> PayStubAttribute.FederalIncomeTaxYearToDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.OldAgeSurvivorsAndDisabilityInsuranceYearToDate.keyString} : {PayStub.last |> PayStubAttribute.OldAgeSurvivorsAndDisabilityInsuranceYearToDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.MedicareYearToDate.keyString} : {PayStub.last |> PayStubAttribute.MedicareYearToDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.StateIncomeTaxYearToDate.keyString} : {PayStub.last |> PayStubAttribute.StateIncomeTaxYearToDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.Local1YearToDate.keyString} : {PayStub.last |> PayStubAttribute.Local1YearToDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.Local3YearToDate.keyString} : {PayStub.last |> PayStubAttribute.Local3YearToDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.Local4YearToDate.keyString} : {PayStub.last |> PayStubAttribute.Local4YearToDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.DeductionsYearToDate.keyString} : {PayStub.last |> PayStubAttribute.DeductionsYearToDate.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.VacationHoursAccrued.keyString} : {PayStub.last |> PayStubAttribute.VacationHoursAccrued.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.VacationHoursTaken.keyString} : {PayStub.last |> PayStubAttribute.VacationHoursTaken.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.VacationHoursBalance.keyString} : {PayStub.last |> PayStubAttribute.VacationHoursBalance.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.EmergencyHoursAccrued.keyString} : {PayStub.last |> PayStubAttribute.EmergencyHoursAccrued.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.EmergencyHoursTaken.keyString} : {PayStub.last |> PayStubAttribute.EmergencyHoursTaken.valueString}"
Console.WriteLine $"{PayStub.last |> PayStubAttribute.EmergencyHoursBalance.keyString} : {PayStub.last |> PayStubAttribute.EmergencyHoursBalance.valueString}"

let testString = "Base Pay Rate: $20.920"
testString.Split(": $")



PayStub.last.coordinatePlane
|> Seq.toArray
|> Array.map (fun keyValue -> sprintf "%A" keyValue)
|> String.concat "\n"
|> clip

*)
