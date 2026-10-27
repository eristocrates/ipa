// TODO use dynamic operator for namespacenames for adhoc local names

#time on
fsi.PrintLength <- 10
fsi.PrintSize <- 300
// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "Internet.dll"
#r "TopLevelDomain.dll"
#r "IanaScheme.dll"
#r "ResourceIdentification.dll"
#r "ResourceDescription.dll"
#r "Iana.dll"
#r "IanaMime.dll"
#r "NetworkMonitor.dll"
#r "Turtle.dll"
#r @"DataTierApplication.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Ast.fsx"
open SharedKernel
open StringModule
open DataTierApplication
open Internet
open ResourceIdentification
open ResourceDescription
open Turtle
open Iana
open NetworkMonitor

#load @"C:\Secret\InforSecrets.fsx"
#load @"C:\Secret\EsriSecrets.fsx"
#load @"C:\Secret\ProjectDoxSecrets.fsx"
#load @".paket/load/main.group.fsx"

module FSharpLiteral = FSharp.Literals.Literal

// #r "nuget: Microsoft.SqlServer.DacFx"
open AW.Identifiers
open BrowserApi.Dom
open BrowserApi.Css
open BrowserApi.Css.Authoring
open CaseConverter
open Fabulous.AST
open Fantomas.Core
open FolkerKinzel.MimeTypes
open FsExcel
open FSharp.Collections.ParallelSeq
open FSharp.Data
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open FSharp.Text.RegexExtensions
open FSharp.Text.RegexProvider
open Humanizer
open IriTools
open ktsu.Semantics.Paths
open LSL.DataUri
open Meziantou.Framework
open Microsoft.SqlServer.Dac
open Microsoft.SqlServer.Dac.Model
open PuppeteerSharp
open BrowserApi
open PuppeteerSharp.Cdp
open RDFSharp.Model
open System
open System.IO
open System.Linq
open System.Text
open System.Text.RegularExpressions
open System.Threading
open System.Threading.Tasks
open System.Web
open Tavis.UriTemplates
open TextCopy
open Universal.Common
open VDS.RDF
open VDS.RDF.Parsing
open FSharp.Text.RegexProvider
open FSharp.Text.RegexExtensions
open PuppeteerSharp.Input

module HansenDataDistribution =
    [<Literal>]
    let xmlFilePath =
        @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"

    let xmlFile = new FileInfo(xmlFilePath)
    type Provider = XmlProvider<UseOriginalNames=true, Sample=xmlFilePath>

module InforProd =
    module Xml =
        let hansenMetadata = HansenDataDistribution.Provider.Load(HansenDataDistribution.xmlFilePath).hansenMetadata

        let productFamilies = hansenMetadata.productFamilies

        let productFamilieByName =
            productFamilies
            |> Array.map (fun productFamily -> productFamily.name, productFamily)
            |> Map.ofArray

        let domainColumns = hansenMetadata.domainColumns

        let domainColumnByName =
            domainColumns
            |> Array.map (fun domainColumn -> domainColumn.name, domainColumn)
            |> Map.ofArray

        let domainColumnByDatabaseName =
            domainColumns
            |> Array.map (fun domainColumn -> domainColumn.databaseName, domainColumn)
            |> Map.ofArray

        let tables = productFamilies |> Array.collect (fun productFamily -> productFamily.tables)

        let tableByName = tables |> Array.map (fun table -> table.name, table) |> Map.ofArray

        let tableByDatabaseName = tables |> Array.map (fun table -> table.databaseName, table) |> Map.ofArray

        let columns = tables |> Array.collect (fun table -> table.columns)

        let columnByName = columns |> Array.map (fun column -> column.name, column) |> Map.ofArray

        let columnByDatabaseName = columns |> Array.map (fun column -> column.databaseName, column) |> Map.ofArray

module Sql =
    type Provider =
        SqlDataProvider<
            IndividualsAmount=1000,
            UseOptionTypes=Common.NullableColumnType.OPTION,
            CaseSensitivityChange=Common.CaseSensitivityChange.ORIGINAL,
            SsdtPath=InforSecrets.Prod.dapac,
            ConnectionString=InforSecrets.Prod.connectionString
         >

    let serverData = Provider.GetDataContext()
    let serverMetadata = Provider.GetReadOnlyDataContext()
    let dataContext = (box serverData) :?> Common.ISqlDataContext

module TSql =
    let DataTierApplication = {
        applicationName = "Infor IPA"
        applicationDescription = "Infor Interoperable Programmatic Automation"
        connectionString = InforSecrets.Prod.connectionString
        dacpacFilePath = InforSecrets.Prod.dapac
        databaseName = InforSecrets.Prod.host
    }
    let Model = DataTierApplication.LoadModel()

let lc_select_all_employeesTable =
    SqlTable(
        "dbo",
        "lc_select_all_employees",
        query {
            for entity in Sql.serverData.Dbo.LcSelectAllemployees do
                select entity
        }
        |> Seq.toArray
        |> Array.map (fun entity -> entity :> Common.SqlEntity)
    )

// LcSelectAllemployeesView.asAstModule.clip

let lc_select_all_employeeEntities = lc_select_all_employeesTable.sqlEntities
// lc_select_all_employeesTable.asAstModule.clip

type BannerEmployee = {
    BENIFITE: decimal option
    DEPARTMENT: string
    DIVISION: string
    EFFECTIVE: DateTime option
    EMAIL: string option
    FIRSTNAME: string
    HIRED: DateTime
    ID: string
    LASTNAME: string
    MIDDLENAME: string option
    ORG: string
    ORGCODE: string
    POSITION: string
    RATE: decimal option
    SUPERVISOR: string option
    SUPERVISORID: string option
}

let bannerEmployees =
    lc_select_all_employeeEntities
    |> Array.map (fun sqlEntity -> {
        BENIFITE =
            sqlEntity.valueObjectByColumn["BENIFITE"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["BENIFITE"].schema lc_select_all_employeesTable.columnsByName["BENIFITE"].isOption
            |> SqlType.asDecimalOption
        DEPARTMENT =
            sqlEntity.valueObjectByColumn["DEPARTMENT"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["DEPARTMENT"].schema lc_select_all_employeesTable.columnsByName["DEPARTMENT"].isOption
            |> SqlType.asString
        DIVISION =
            sqlEntity.valueObjectByColumn["DIVISION"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["DIVISION"].schema lc_select_all_employeesTable.columnsByName["DIVISION"].isOption
            |> SqlType.asString
        EFFECTIVE =
            sqlEntity.valueObjectByColumn["EFFECTIVE"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["EFFECTIVE"].schema lc_select_all_employeesTable.columnsByName["EFFECTIVE"].isOption
            |> SqlType.asDateTimeOption
        EMAIL =
            sqlEntity.valueObjectByColumn["EMAIL"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["EMAIL"].schema lc_select_all_employeesTable.columnsByName["EMAIL"].isOption
            |> SqlType.asStringOption
        FIRSTNAME =
            sqlEntity.valueObjectByColumn["FIRSTNAME"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["FIRSTNAME"].schema lc_select_all_employeesTable.columnsByName["FIRSTNAME"].isOption
            |> SqlType.asString
        HIRED =
            sqlEntity.valueObjectByColumn["HIRED"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["HIRED"].schema lc_select_all_employeesTable.columnsByName["HIRED"].isOption
            |> SqlType.asDateTime
        ID =
            sqlEntity.valueObjectByColumn["ID"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["ID"].schema lc_select_all_employeesTable.columnsByName["ID"].isOption
            |> SqlType.asString
        LASTNAME =
            sqlEntity.valueObjectByColumn["LASTNAME"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["LASTNAME"].schema lc_select_all_employeesTable.columnsByName["LASTNAME"].isOption
            |> SqlType.asString
        MIDDLENAME =
            sqlEntity.valueObjectByColumn["MIDDLENAME"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["MIDDLENAME"].schema lc_select_all_employeesTable.columnsByName["MIDDLENAME"].isOption
            |> SqlType.asStringOption
        ORG =
            sqlEntity.valueObjectByColumn["ORG"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["ORG"].schema lc_select_all_employeesTable.columnsByName["ORG"].isOption
            |> SqlType.asString
        ORGCODE =
            sqlEntity.valueObjectByColumn["ORGCODE"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["ORGCODE"].schema lc_select_all_employeesTable.columnsByName["ORGCODE"].isOption
            |> SqlType.asString
        POSITION =
            sqlEntity.valueObjectByColumn["POSITION"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["POSITION"].schema lc_select_all_employeesTable.columnsByName["POSITION"].isOption
            |> SqlType.asString
        RATE =
            sqlEntity.valueObjectByColumn["RATE"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["RATE"].schema lc_select_all_employeesTable.columnsByName["RATE"].isOption
            |> SqlType.asDecimalOption
        SUPERVISOR =
            sqlEntity.valueObjectByColumn["SUPERVISOR"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["SUPERVISOR"].schema lc_select_all_employeesTable.columnsByName["SUPERVISOR"].isOption
            |> SqlType.asStringOption
        SUPERVISORID =
            sqlEntity.valueObjectByColumn["SUPERVISORID"]
            |> SqlType.Parse lc_select_all_employeesTable.columnsByName["SUPERVISORID"].schema lc_select_all_employeesTable.columnsByName["SUPERVISORID"].isOption
            |> SqlType.asStringOption
    })

(*
let Departments = bannerEmployees |> Array.Parallel.map (fun employee ->  employee.DEPARTMENT) |> Set.ofArray
*)
type Departments = 
    set [
        "Administration"
        "Board of County Commissioners"
        "Constitutional"
        "County Attorney's Office"
        "Department of Development Support & Environmental Management"
        "Department of Public Works"
        "Grants Administration"
        "Judicial"
        "Non-Operating"
        "Office of Financial Stewardship"
        "Office of Human Services & Community Partnerships"
        "Office of Information and Technology"
        "Office of Intervention & Detention Alternatives"
        "Office of Library Services"
        "Office of Public Safety"
        "Office of Resource Stewardship"
        "Office of Tourist Development"
    ]
let publicWorksEmployees = bannerEmployees |> Array.Parallel.filter (fun employee -> employee.DEPARTMENT = "Department of Public Works")
bannerEmployees |> Array.find (fun employee -> 
    match employee.FIRSTNAME, employee.LASTNAME with
    | "Jon", "Bryant" -> true 
    | _, _ -> false
    )

(*
publicWorksEmployees |> Array.Parallel.choose (fun employee -> employee.EMAIL) |> String.concat "\n" |> String.Clipboard.SetText
*)