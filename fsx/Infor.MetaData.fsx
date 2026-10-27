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

let DBCHECKCONSTRAINTTable =
    SqlTable(
        "MetaData",
        "DBCHECKCONSTRAINT",
        query {
            for entity in Sql.serverData.MetaData.Dbcheckconstraint do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
// DBCHECKCONSTRAINTTable.asAstModule.clip
type DBCHECKCONSTRAINT = {
    ADDBY: string option
    ADDDTTM: DateTime
    CHECKCONSTRAINTKEY: int
    CHECKDESC: string option
    CHECKSTATEMENT: string option
    CHECKSTMT_ORACLE: string option
    COLUMNKEY: int
    COMMONID: string option
    ENUMCOLLKEY: int
    MODBY: string option
    MODDTTM: DateTime option
    NAME: string option
    OLDKEY: int option
    TABLEKEY: int
}

let dbcheckconstraints =
    DBCHECKCONSTRAINTTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["ADDBY"].schema DBCHECKCONSTRAINTTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["ADDDTTM"].schema DBCHECKCONSTRAINTTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        CHECKCONSTRAINTKEY =
            sqlEntity.valueObjectByColumn["CHECKCONSTRAINTKEY"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["CHECKCONSTRAINTKEY"].schema DBCHECKCONSTRAINTTable.columnsByName["CHECKCONSTRAINTKEY"].isOption
            |> SqlType.asInt32
        CHECKDESC =
            sqlEntity.valueObjectByColumn["CHECKDESC"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["CHECKDESC"].schema DBCHECKCONSTRAINTTable.columnsByName["CHECKDESC"].isOption
            |> SqlType.asStringOption
        CHECKSTATEMENT =
            sqlEntity.valueObjectByColumn["CHECKSTATEMENT"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["CHECKSTATEMENT"].schema DBCHECKCONSTRAINTTable.columnsByName["CHECKSTATEMENT"].isOption
            |> SqlType.asStringOption
        CHECKSTMT_ORACLE =
            sqlEntity.valueObjectByColumn["CHECKSTMT_ORACLE"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["CHECKSTMT_ORACLE"].schema DBCHECKCONSTRAINTTable.columnsByName["CHECKSTMT_ORACLE"].isOption
            |> SqlType.asStringOption
        COLUMNKEY =
            sqlEntity.valueObjectByColumn["COLUMNKEY"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["COLUMNKEY"].schema DBCHECKCONSTRAINTTable.columnsByName["COLUMNKEY"].isOption
            |> SqlType.asInt32
        COMMONID =
            sqlEntity.valueObjectByColumn["COMMONID"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["COMMONID"].schema DBCHECKCONSTRAINTTable.columnsByName["COMMONID"].isOption
            |> SqlType.asStringOption
        ENUMCOLLKEY =
            sqlEntity.valueObjectByColumn["ENUMCOLLKEY"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["ENUMCOLLKEY"].schema DBCHECKCONSTRAINTTable.columnsByName["ENUMCOLLKEY"].isOption
            |> SqlType.asInt32
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["MODBY"].schema DBCHECKCONSTRAINTTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["MODDTTM"].schema DBCHECKCONSTRAINTTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        NAME =
            sqlEntity.valueObjectByColumn["NAME"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["NAME"].schema DBCHECKCONSTRAINTTable.columnsByName["NAME"].isOption
            |> SqlType.asStringOption
        OLDKEY =
            sqlEntity.valueObjectByColumn["OLDKEY"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["OLDKEY"].schema DBCHECKCONSTRAINTTable.columnsByName["OLDKEY"].isOption
            |> SqlType.asInt32Option
        TABLEKEY =
            sqlEntity.valueObjectByColumn["TABLEKEY"]
            |> SqlType.Parse DBCHECKCONSTRAINTTable.columnsByName["TABLEKEY"].schema DBCHECKCONSTRAINTTable.columnsByName["TABLEKEY"].isOption
            |> SqlType.asInt32
    })
let DBCOLUMNTable =
    SqlTable(
        "MetaData",
        "DBCOLUMN",
        query {
            for entity in Sql.serverData.MetaData.Dbcolumn do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBCOLUMNTable.asAstModule.clip
*)

type DBCOLUMN = {
    ADDBY: string option
    ADDDTTM: DateTime
    COLUMNDESC: string option
    COLUMNKEY: int
    COMMONID: string option
    DATAPRECISION: int16 option
    DATASCALE: int16 option
    DEFAULTVALUE: string option
    DISPLAYDESC: string option
    DISPLAYTITLE: string option
    DISPLAYTITLELONG: string option
    DOMAINKEY: int
    LENGTH: int16 option
    LOCALE: string option
    MODBY: string option
    MODDTTM: DateTime option
    NAME: string option
    NULLABLEFLAG: string option
    OLDKEY: int option
    READYFORDEPLOYMENT: string
    REMARKS: string option
    REQUIREDFLAG: string
    SHOWSEARCHORDER: int16 option
    SQLTYPE: string option
    TABLEKEY: int
    USESEARCHORDER: int16 option
}

let dbcolumns =
    DBCOLUMNTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["ADDBY"].schema DBCOLUMNTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["ADDDTTM"].schema DBCOLUMNTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        COLUMNDESC =
            sqlEntity.valueObjectByColumn["COLUMNDESC"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["COLUMNDESC"].schema DBCOLUMNTable.columnsByName["COLUMNDESC"].isOption
            |> SqlType.asStringOption
        COLUMNKEY =
            sqlEntity.valueObjectByColumn["COLUMNKEY"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["COLUMNKEY"].schema DBCOLUMNTable.columnsByName["COLUMNKEY"].isOption
            |> SqlType.asInt32
        COMMONID =
            sqlEntity.valueObjectByColumn["COMMONID"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["COMMONID"].schema DBCOLUMNTable.columnsByName["COMMONID"].isOption
            |> SqlType.asStringOption
        DATAPRECISION =
            sqlEntity.valueObjectByColumn["DATAPRECISION"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["DATAPRECISION"].schema DBCOLUMNTable.columnsByName["DATAPRECISION"].isOption
            |> SqlType.asObject
        DATASCALE =
            sqlEntity.valueObjectByColumn["DATASCALE"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["DATASCALE"].schema DBCOLUMNTable.columnsByName["DATASCALE"].isOption
            |> SqlType.asObject
        DEFAULTVALUE =
            sqlEntity.valueObjectByColumn["DEFAULTVALUE"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["DEFAULTVALUE"].schema DBCOLUMNTable.columnsByName["DEFAULTVALUE"].isOption
            |> SqlType.asStringOption
        DISPLAYDESC =
            sqlEntity.valueObjectByColumn["DISPLAYDESC"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["DISPLAYDESC"].schema DBCOLUMNTable.columnsByName["DISPLAYDESC"].isOption
            |> SqlType.asStringOption
        DISPLAYTITLE =
            sqlEntity.valueObjectByColumn["DISPLAYTITLE"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["DISPLAYTITLE"].schema DBCOLUMNTable.columnsByName["DISPLAYTITLE"].isOption
            |> SqlType.asStringOption
        DISPLAYTITLELONG =
            sqlEntity.valueObjectByColumn["DISPLAYTITLELONG"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["DISPLAYTITLELONG"].schema DBCOLUMNTable.columnsByName["DISPLAYTITLELONG"].isOption
            |> SqlType.asStringOption
        DOMAINKEY =
            sqlEntity.valueObjectByColumn["DOMAINKEY"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["DOMAINKEY"].schema DBCOLUMNTable.columnsByName["DOMAINKEY"].isOption
            |> SqlType.asInt32
        LENGTH =
            sqlEntity.valueObjectByColumn["LENGTH"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["LENGTH"].schema DBCOLUMNTable.columnsByName["LENGTH"].isOption
            |> SqlType.asObject
        LOCALE =
            sqlEntity.valueObjectByColumn["LOCALE"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["LOCALE"].schema DBCOLUMNTable.columnsByName["LOCALE"].isOption
            |> SqlType.asStringOption
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["MODBY"].schema DBCOLUMNTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["MODDTTM"].schema DBCOLUMNTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        NAME =
            sqlEntity.valueObjectByColumn["NAME"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["NAME"].schema DBCOLUMNTable.columnsByName["NAME"].isOption
            |> SqlType.asStringOption
        NULLABLEFLAG =
            sqlEntity.valueObjectByColumn["NULLABLEFLAG"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["NULLABLEFLAG"].schema DBCOLUMNTable.columnsByName["NULLABLEFLAG"].isOption
            |> SqlType.asStringOption
        OLDKEY =
            sqlEntity.valueObjectByColumn["OLDKEY"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["OLDKEY"].schema DBCOLUMNTable.columnsByName["OLDKEY"].isOption
            |> SqlType.asInt32Option
        READYFORDEPLOYMENT =
            sqlEntity.valueObjectByColumn["READYFORDEPLOYMENT"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["READYFORDEPLOYMENT"].schema DBCOLUMNTable.columnsByName["READYFORDEPLOYMENT"].isOption
            |> SqlType.asString
        REMARKS =
            sqlEntity.valueObjectByColumn["REMARKS"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["REMARKS"].schema DBCOLUMNTable.columnsByName["REMARKS"].isOption
            |> SqlType.asStringOption
        REQUIREDFLAG =
            sqlEntity.valueObjectByColumn["REQUIREDFLAG"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["REQUIREDFLAG"].schema DBCOLUMNTable.columnsByName["REQUIREDFLAG"].isOption
            |> SqlType.asString
        SHOWSEARCHORDER =
            sqlEntity.valueObjectByColumn["SHOWSEARCHORDER"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["SHOWSEARCHORDER"].schema DBCOLUMNTable.columnsByName["SHOWSEARCHORDER"].isOption
            |> SqlType.asObject
        SQLTYPE =
            sqlEntity.valueObjectByColumn["SQLTYPE"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["SQLTYPE"].schema DBCOLUMNTable.columnsByName["SQLTYPE"].isOption
            |> SqlType.asStringOption
        TABLEKEY =
            sqlEntity.valueObjectByColumn["TABLEKEY"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["TABLEKEY"].schema DBCOLUMNTable.columnsByName["TABLEKEY"].isOption
            |> SqlType.asInt32
        USESEARCHORDER =
            sqlEntity.valueObjectByColumn["USESEARCHORDER"]
            |> SqlType.Parse DBCOLUMNTable.columnsByName["USESEARCHORDER"].schema DBCOLUMNTable.columnsByName["USESEARCHORDER"].isOption
            |> SqlType.asObject
    })
let DBCOLUMN_LOCALIZEDTable =
    SqlTable(
        "MetaData",
        "DBCOLUMN_LOCALIZED",
        query {
            for entity in Sql.serverData.MetaData.DbcolumnLocalized do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBCOLUMN_LOCALIZEDTable.asAstModule.clip
*)
type DBCOLUMN_LOCALIZED = {
    ADDBY: string option
    ADDDTTM: DateTime
    COLUMNDESC: string option
    COLUMNKEY: int
    DBCOLUMN_LOCALEKEY: int
    DISPLAYDESC: string option
    DISPLAYTITLE: string option
    DISPLAYTITLELONG: string option
    LOCALE: string option
    MODBY: string option
    MODDTTM: DateTime option
    REMARKS: string option
}

let dbcolumn_localized =
    DBCOLUMN_LOCALIZEDTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["ADDBY"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["ADDDTTM"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        COLUMNDESC =
            sqlEntity.valueObjectByColumn["COLUMNDESC"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["COLUMNDESC"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["COLUMNDESC"].isOption
            |> SqlType.asStringOption
        COLUMNKEY =
            sqlEntity.valueObjectByColumn["COLUMNKEY"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["COLUMNKEY"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["COLUMNKEY"].isOption
            |> SqlType.asInt32
        DBCOLUMN_LOCALEKEY =
            sqlEntity.valueObjectByColumn["DBCOLUMN_LOCALEKEY"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["DBCOLUMN_LOCALEKEY"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["DBCOLUMN_LOCALEKEY"].isOption
            |> SqlType.asInt32
        DISPLAYDESC =
            sqlEntity.valueObjectByColumn["DISPLAYDESC"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["DISPLAYDESC"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["DISPLAYDESC"].isOption
            |> SqlType.asStringOption
        DISPLAYTITLE =
            sqlEntity.valueObjectByColumn["DISPLAYTITLE"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["DISPLAYTITLE"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["DISPLAYTITLE"].isOption
            |> SqlType.asStringOption
        DISPLAYTITLELONG =
            sqlEntity.valueObjectByColumn["DISPLAYTITLELONG"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["DISPLAYTITLELONG"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["DISPLAYTITLELONG"].isOption
            |> SqlType.asStringOption
        LOCALE =
            sqlEntity.valueObjectByColumn["LOCALE"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["LOCALE"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["LOCALE"].isOption
            |> SqlType.asStringOption
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["MODBY"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["MODDTTM"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        REMARKS =
            sqlEntity.valueObjectByColumn["REMARKS"]
            |> SqlType.Parse DBCOLUMN_LOCALIZEDTable.columnsByName["REMARKS"].schema DBCOLUMN_LOCALIZEDTable.columnsByName["REMARKS"].isOption
            |> SqlType.asStringOption
    })
let DBCOLUMNCONSTRAINTLINKTable =
    SqlTable(
        "MetaData",
        "DBCOLUMNCONSTRAINTLINK",
        query {
            for entity in Sql.serverData.MetaData.Dbcolumnconstraintlink do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBCOLUMNCONSTRAINTLINKTable.asAstModule.clip
*)
type DBCOLUMNCONSTRAINTLINK = {
    ADDBY: string
    ADDDTTM: DateTime
    COLORDER: int16
    COLUMNKEY: int
    CONSTRAINTKEY: int
    MODBY: string option
    MODDTTM: DateTime option
    REFCOLUMNKEY: int
}

let dbcolumnconstraintlink =
    DBCOLUMNCONSTRAINTLINKTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBCOLUMNCONSTRAINTLINKTable.columnsByName["ADDBY"].schema DBCOLUMNCONSTRAINTLINKTable.columnsByName["ADDBY"].isOption
            |> SqlType.asString
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBCOLUMNCONSTRAINTLINKTable.columnsByName["ADDDTTM"].schema DBCOLUMNCONSTRAINTLINKTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        COLORDER =
            sqlEntity.valueObjectByColumn["COLORDER"]
            |> SqlType.Parse DBCOLUMNCONSTRAINTLINKTable.columnsByName["COLORDER"].schema DBCOLUMNCONSTRAINTLINKTable.columnsByName["COLORDER"].isOption
            |> SqlType.asObject
        COLUMNKEY =
            sqlEntity.valueObjectByColumn["COLUMNKEY"]
            |> SqlType.Parse DBCOLUMNCONSTRAINTLINKTable.columnsByName["COLUMNKEY"].schema DBCOLUMNCONSTRAINTLINKTable.columnsByName["COLUMNKEY"].isOption
            |> SqlType.asInt32
        CONSTRAINTKEY =
            sqlEntity.valueObjectByColumn["CONSTRAINTKEY"]
            |> SqlType.Parse DBCOLUMNCONSTRAINTLINKTable.columnsByName["CONSTRAINTKEY"].schema DBCOLUMNCONSTRAINTLINKTable.columnsByName["CONSTRAINTKEY"].isOption
            |> SqlType.asInt32
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBCOLUMNCONSTRAINTLINKTable.columnsByName["MODBY"].schema DBCOLUMNCONSTRAINTLINKTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBCOLUMNCONSTRAINTLINKTable.columnsByName["MODDTTM"].schema DBCOLUMNCONSTRAINTLINKTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        REFCOLUMNKEY =
            sqlEntity.valueObjectByColumn["REFCOLUMNKEY"]
            |> SqlType.Parse DBCOLUMNCONSTRAINTLINKTable.columnsByName["REFCOLUMNKEY"].schema DBCOLUMNCONSTRAINTLINKTable.columnsByName["REFCOLUMNKEY"].isOption
            |> SqlType.asInt32
    })
let DBCOLUMNINDEXLINKTable =
    SqlTable(
        "MetaData",
        "DBCOLUMNINDEXLINK",
        query {
            for entity in Sql.serverData.MetaData.Dbcolumnindexlink do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBCOLUMNINDEXLINKTable.asAstModule.clip
*)
type DBCOLUMNINDEXLINK = {
    ADDBY: string option
    ADDDTTM: DateTime
    COLORDER: int16
    COLUMNKEY: int
    INDEXKEY: int
    MODBY: string option
    MODDTTM: DateTime option
}

let dbcolumnindexlink =
    DBCOLUMNINDEXLINKTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBCOLUMNINDEXLINKTable.columnsByName["ADDBY"].schema DBCOLUMNINDEXLINKTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBCOLUMNINDEXLINKTable.columnsByName["ADDDTTM"].schema DBCOLUMNINDEXLINKTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        COLORDER =
            sqlEntity.valueObjectByColumn["COLORDER"]
            |> SqlType.Parse DBCOLUMNINDEXLINKTable.columnsByName["COLORDER"].schema DBCOLUMNINDEXLINKTable.columnsByName["COLORDER"].isOption
            |> SqlType.asObject
        COLUMNKEY =
            sqlEntity.valueObjectByColumn["COLUMNKEY"]
            |> SqlType.Parse DBCOLUMNINDEXLINKTable.columnsByName["COLUMNKEY"].schema DBCOLUMNINDEXLINKTable.columnsByName["COLUMNKEY"].isOption
            |> SqlType.asInt32
        INDEXKEY =
            sqlEntity.valueObjectByColumn["INDEXKEY"]
            |> SqlType.Parse DBCOLUMNINDEXLINKTable.columnsByName["INDEXKEY"].schema DBCOLUMNINDEXLINKTable.columnsByName["INDEXKEY"].isOption
            |> SqlType.asInt32
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBCOLUMNINDEXLINKTable.columnsByName["MODBY"].schema DBCOLUMNINDEXLINKTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBCOLUMNINDEXLINKTable.columnsByName["MODDTTM"].schema DBCOLUMNINDEXLINKTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
    })
let DBCONSTRAINTTable =
    SqlTable(
        "MetaData",
        "DBCONSTRAINT",
        query {
            for entity in Sql.serverData.MetaData.Dbconstraint do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBCONSTRAINTTable.asAstModule.clip
*)
type DBCONSTRAINT = {
    ADDBY: string
    ADDDTTM: DateTime
    CARDINALITYCHILD: string option
    CARDINALITYPARENT: string option
    CARDINALITYUSEDBYAPP: string option
    COMMONID: string option
    CONSTRAINTDESC: string option
    CONSTRAINTKEY: int
    DELETERULE: string option
    IDENTITYSEED: int option
    IDENTITYSTEP: int16 option
    MODBY: string option
    MODDTTM: DateTime option
    NAME: string
    OLDCOLKEY: int option
    TABLEKEY: int
    TYPE: string
    ZEQUENCE: string option
}

let dbconstraint =
    DBCONSTRAINTTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["ADDBY"].schema DBCONSTRAINTTable.columnsByName["ADDBY"].isOption
            |> SqlType.asString
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["ADDDTTM"].schema DBCONSTRAINTTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        CARDINALITYCHILD =
            sqlEntity.valueObjectByColumn["CARDINALITYCHILD"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["CARDINALITYCHILD"].schema DBCONSTRAINTTable.columnsByName["CARDINALITYCHILD"].isOption
            |> SqlType.asStringOption
        CARDINALITYPARENT =
            sqlEntity.valueObjectByColumn["CARDINALITYPARENT"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["CARDINALITYPARENT"].schema DBCONSTRAINTTable.columnsByName["CARDINALITYPARENT"].isOption
            |> SqlType.asStringOption
        CARDINALITYUSEDBYAPP =
            sqlEntity.valueObjectByColumn["CARDINALITYUSEDBYAPP"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["CARDINALITYUSEDBYAPP"].schema DBCONSTRAINTTable.columnsByName["CARDINALITYUSEDBYAPP"].isOption
            |> SqlType.asStringOption
        COMMONID =
            sqlEntity.valueObjectByColumn["COMMONID"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["COMMONID"].schema DBCONSTRAINTTable.columnsByName["COMMONID"].isOption
            |> SqlType.asStringOption
        CONSTRAINTDESC =
            sqlEntity.valueObjectByColumn["CONSTRAINTDESC"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["CONSTRAINTDESC"].schema DBCONSTRAINTTable.columnsByName["CONSTRAINTDESC"].isOption
            |> SqlType.asStringOption
        CONSTRAINTKEY =
            sqlEntity.valueObjectByColumn["CONSTRAINTKEY"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["CONSTRAINTKEY"].schema DBCONSTRAINTTable.columnsByName["CONSTRAINTKEY"].isOption
            |> SqlType.asInt32
        DELETERULE =
            sqlEntity.valueObjectByColumn["DELETERULE"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["DELETERULE"].schema DBCONSTRAINTTable.columnsByName["DELETERULE"].isOption
            |> SqlType.asStringOption
        IDENTITYSEED =
            sqlEntity.valueObjectByColumn["IDENTITYSEED"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["IDENTITYSEED"].schema DBCONSTRAINTTable.columnsByName["IDENTITYSEED"].isOption
            |> SqlType.asInt32Option
        IDENTITYSTEP =
            sqlEntity.valueObjectByColumn["IDENTITYSTEP"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["IDENTITYSTEP"].schema DBCONSTRAINTTable.columnsByName["IDENTITYSTEP"].isOption
            |> SqlType.asInt16
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["MODBY"].schema DBCONSTRAINTTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["MODDTTM"].schema DBCONSTRAINTTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        NAME =
            sqlEntity.valueObjectByColumn["NAME"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["NAME"].schema DBCONSTRAINTTable.columnsByName["NAME"].isOption
            |> SqlType.asString
        OLDCOLKEY =
            sqlEntity.valueObjectByColumn["OLDCOLKEY"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["OLDCOLKEY"].schema DBCONSTRAINTTable.columnsByName["OLDCOLKEY"].isOption
            |> SqlType.asInt32Option
        TABLEKEY =
            sqlEntity.valueObjectByColumn["TABLEKEY"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["TABLEKEY"].schema DBCONSTRAINTTable.columnsByName["TABLEKEY"].isOption
            |> SqlType.asInt32
        TYPE =
            sqlEntity.valueObjectByColumn["TYPE"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["TYPE"].schema DBCONSTRAINTTable.columnsByName["TYPE"].isOption
            |> SqlType.asString
        ZEQUENCE =
            sqlEntity.valueObjectByColumn["ZEQUENCE"]
            |> SqlType.Parse DBCONSTRAINTTable.columnsByName["ZEQUENCE"].schema DBCONSTRAINTTable.columnsByName["ZEQUENCE"].isOption
            |> SqlType.asStringOption
    })
let DBENUMTable =
    SqlTable(
        "MetaData",
        "DBENUM",
        query {
            for entity in Sql.serverData.MetaData.Dbenum do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBENUMTable.asAstModule.clip
*)
type DBENUM = {
    ADDBY: string option
    ADDDTTM: DateTime
    COMMONID: string option
    ENUMCOLLKEY: int
    ENUMDESC: string option
    ENUMKEY: int
    ENUMVAL: string option
    MODBY: string option
    MODDTTM: DateTime option
}

let dbenum =
    DBENUMTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBENUMTable.columnsByName["ADDBY"].schema DBENUMTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBENUMTable.columnsByName["ADDDTTM"].schema DBENUMTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        COMMONID =
            sqlEntity.valueObjectByColumn["COMMONID"]
            |> SqlType.Parse DBENUMTable.columnsByName["COMMONID"].schema DBENUMTable.columnsByName["COMMONID"].isOption
            |> SqlType.asStringOption
        ENUMCOLLKEY =
            sqlEntity.valueObjectByColumn["ENUMCOLLKEY"]
            |> SqlType.Parse DBENUMTable.columnsByName["ENUMCOLLKEY"].schema DBENUMTable.columnsByName["ENUMCOLLKEY"].isOption
            |> SqlType.asInt32
        ENUMDESC =
            sqlEntity.valueObjectByColumn["ENUMDESC"]
            |> SqlType.Parse DBENUMTable.columnsByName["ENUMDESC"].schema DBENUMTable.columnsByName["ENUMDESC"].isOption
            |> SqlType.asStringOption
        ENUMKEY =
            sqlEntity.valueObjectByColumn["ENUMKEY"]
            |> SqlType.Parse DBENUMTable.columnsByName["ENUMKEY"].schema DBENUMTable.columnsByName["ENUMKEY"].isOption
            |> SqlType.asInt32
        ENUMVAL =
            sqlEntity.valueObjectByColumn["ENUMVAL"]
            |> SqlType.Parse DBENUMTable.columnsByName["ENUMVAL"].schema DBENUMTable.columnsByName["ENUMVAL"].isOption
            |> SqlType.asStringOption
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBENUMTable.columnsByName["MODBY"].schema DBENUMTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBENUMTable.columnsByName["MODDTTM"].schema DBENUMTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
    })
let DBENUMCOLLTable =
    SqlTable(
        "MetaData",
        "DBENUMCOLL",
        query {
            for entity in Sql.serverData.MetaData.Dbenumcoll do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBENUMCOLLTable.asAstModule.clip
*)
type DBENUMCOLL = {
    ADDBY: string
    ADDDTTM: DateTime
    COMMONID: string option
    ENUMCOLLDESC: string option
    ENUMCOLLKEY: int
    MODBY: string option
    MODDTTM: DateTime option
    NAME: string option
}

let dbenumcoll =
    DBENUMCOLLTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBENUMCOLLTable.columnsByName["ADDBY"].schema DBENUMCOLLTable.columnsByName["ADDBY"].isOption
            |> SqlType.asString
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBENUMCOLLTable.columnsByName["ADDDTTM"].schema DBENUMCOLLTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        COMMONID =
            sqlEntity.valueObjectByColumn["COMMONID"]
            |> SqlType.Parse DBENUMCOLLTable.columnsByName["COMMONID"].schema DBENUMCOLLTable.columnsByName["COMMONID"].isOption
            |> SqlType.asStringOption
        ENUMCOLLDESC =
            sqlEntity.valueObjectByColumn["ENUMCOLLDESC"]
            |> SqlType.Parse DBENUMCOLLTable.columnsByName["ENUMCOLLDESC"].schema DBENUMCOLLTable.columnsByName["ENUMCOLLDESC"].isOption
            |> SqlType.asStringOption
        ENUMCOLLKEY =
            sqlEntity.valueObjectByColumn["ENUMCOLLKEY"]
            |> SqlType.Parse DBENUMCOLLTable.columnsByName["ENUMCOLLKEY"].schema DBENUMCOLLTable.columnsByName["ENUMCOLLKEY"].isOption
            |> SqlType.asInt32
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBENUMCOLLTable.columnsByName["MODBY"].schema DBENUMCOLLTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBENUMCOLLTable.columnsByName["MODDTTM"].schema DBENUMCOLLTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        NAME =
            sqlEntity.valueObjectByColumn["NAME"]
            |> SqlType.Parse DBENUMCOLLTable.columnsByName["NAME"].schema DBENUMCOLLTable.columnsByName["NAME"].isOption
            |> SqlType.asStringOption
    })
let DBINDEXTable =
    SqlTable(
        "MetaData",
        "DBINDEX",
        query {
            for entity in Sql.serverData.MetaData.Dbindex do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBINDEXTable.asAstModule.clip
*)
type DBINDEX = {
    ADDBY: string option
    ADDDTTM: DateTime
    COMMONID: string option
    INDEXDESC: string option
    INDEXKEY: int
    LATESTCHANGEDTTM: DateTime option
    MODBY: string option
    MODDTTM: DateTime option
    NAME: string option
    OLDINDEXKEY: int option
    PRODFAMILYKEY: int option
    SYNCHRONIZEDDTTM: DateTime option
    TABLEKEY: int
    UNIQUEFLAG: string
}

let dbindex =
    DBINDEXTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBINDEXTable.columnsByName["ADDBY"].schema DBINDEXTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBINDEXTable.columnsByName["ADDDTTM"].schema DBINDEXTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        COMMONID =
            sqlEntity.valueObjectByColumn["COMMONID"]
            |> SqlType.Parse DBINDEXTable.columnsByName["COMMONID"].schema DBINDEXTable.columnsByName["COMMONID"].isOption
            |> SqlType.asStringOption
        INDEXDESC =
            sqlEntity.valueObjectByColumn["INDEXDESC"]
            |> SqlType.Parse DBINDEXTable.columnsByName["INDEXDESC"].schema DBINDEXTable.columnsByName["INDEXDESC"].isOption
            |> SqlType.asStringOption
        INDEXKEY =
            sqlEntity.valueObjectByColumn["INDEXKEY"]
            |> SqlType.Parse DBINDEXTable.columnsByName["INDEXKEY"].schema DBINDEXTable.columnsByName["INDEXKEY"].isOption
            |> SqlType.asInt32
        LATESTCHANGEDTTM =
            sqlEntity.valueObjectByColumn["LATESTCHANGEDTTM"]
            |> SqlType.Parse DBINDEXTable.columnsByName["LATESTCHANGEDTTM"].schema DBINDEXTable.columnsByName["LATESTCHANGEDTTM"].isOption
            |> SqlType.asDateTimeOption
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBINDEXTable.columnsByName["MODBY"].schema DBINDEXTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBINDEXTable.columnsByName["MODDTTM"].schema DBINDEXTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        NAME =
            sqlEntity.valueObjectByColumn["NAME"]
            |> SqlType.Parse DBINDEXTable.columnsByName["NAME"].schema DBINDEXTable.columnsByName["NAME"].isOption
            |> SqlType.asStringOption
        OLDINDEXKEY =
            sqlEntity.valueObjectByColumn["OLDINDEXKEY"]
            |> SqlType.Parse DBINDEXTable.columnsByName["OLDINDEXKEY"].schema DBINDEXTable.columnsByName["OLDINDEXKEY"].isOption
            |> SqlType.asInt32Option
        PRODFAMILYKEY =
            sqlEntity.valueObjectByColumn["PRODFAMILYKEY"]
            |> SqlType.Parse DBINDEXTable.columnsByName["PRODFAMILYKEY"].schema DBINDEXTable.columnsByName["PRODFAMILYKEY"].isOption
            |> SqlType.asInt32Option
        SYNCHRONIZEDDTTM =
            sqlEntity.valueObjectByColumn["SYNCHRONIZEDDTTM"]
            |> SqlType.Parse DBINDEXTable.columnsByName["SYNCHRONIZEDDTTM"].schema DBINDEXTable.columnsByName["SYNCHRONIZEDDTTM"].isOption
            |> SqlType.asDateTimeOption
        TABLEKEY =
            sqlEntity.valueObjectByColumn["TABLEKEY"]
            |> SqlType.Parse DBINDEXTable.columnsByName["TABLEKEY"].schema DBINDEXTable.columnsByName["TABLEKEY"].isOption
            |> SqlType.asInt32
        UNIQUEFLAG =
            sqlEntity.valueObjectByColumn["UNIQUEFLAG"]
            |> SqlType.Parse DBINDEXTable.columnsByName["UNIQUEFLAG"].schema DBINDEXTable.columnsByName["UNIQUEFLAG"].isOption
            |> SqlType.asString
    })
let DBINPROCESSSTATETable =
    SqlTable(
        "MetaData",
        "DBINPROCESSSTATE",
        query {
            for entity in Sql.serverData.MetaData.Dbinprocessstate do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBINPROCESSSTATETable.asAstModule.clip
*)
type DBINPROCESSSTATE = {
    ADDBY: string option
    ADDDTTM: DateTime
    INPROCESSKEY: int
    MODBY: string
    MODDTTM: DateTime option
    STARTDTTM: DateTime option
}

let dbinprocessstate =
    DBINPROCESSSTATETable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBINPROCESSSTATETable.columnsByName["ADDBY"].schema DBINPROCESSSTATETable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBINPROCESSSTATETable.columnsByName["ADDDTTM"].schema DBINPROCESSSTATETable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        INPROCESSKEY =
            sqlEntity.valueObjectByColumn["INPROCESSKEY"]
            |> SqlType.Parse DBINPROCESSSTATETable.columnsByName["INPROCESSKEY"].schema DBINPROCESSSTATETable.columnsByName["INPROCESSKEY"].isOption
            |> SqlType.asInt32
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBINPROCESSSTATETable.columnsByName["MODBY"].schema DBINPROCESSSTATETable.columnsByName["MODBY"].isOption
            |> SqlType.asString
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBINPROCESSSTATETable.columnsByName["MODDTTM"].schema DBINPROCESSSTATETable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        STARTDTTM =
            sqlEntity.valueObjectByColumn["STARTDTTM"]
            |> SqlType.Parse DBINPROCESSSTATETable.columnsByName["STARTDTTM"].schema DBINPROCESSSTATETable.columnsByName["STARTDTTM"].isOption
            |> SqlType.asDateTimeOption
    })
let DBLOGTable =
    SqlTable(
        "MetaData",
        "DBLOG",
        query {
            for entity in Sql.serverData.MetaData.Dblog do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBLOGTable.asAstModule.clip
*)
type DBLOG = {
    ADDBY: string option
    ADDDTTM: DateTime
    ERROR: string option
    LOGKEY: int
    MODBY: string option
    MODDTTM: DateTime option
    SQLSTMT: string option
}

let dblog =
    DBLOGTable.sqlEntities
    |> Array.map (fun sqlEntity -> {
        ADDBY =
            sqlEntity.valueObjectByColumn["ADDBY"]
            |> SqlType.Parse DBLOGTable.columnsByName["ADDBY"].schema DBLOGTable.columnsByName["ADDBY"].isOption
            |> SqlType.asStringOption
        ADDDTTM =
            sqlEntity.valueObjectByColumn["ADDDTTM"]
            |> SqlType.Parse DBLOGTable.columnsByName["ADDDTTM"].schema DBLOGTable.columnsByName["ADDDTTM"].isOption
            |> SqlType.asDateTime
        ERROR =
            sqlEntity.valueObjectByColumn["ERROR"]
            |> SqlType.Parse DBLOGTable.columnsByName["ERROR"].schema DBLOGTable.columnsByName["ERROR"].isOption
            |> SqlType.asStringOption
        LOGKEY =
            sqlEntity.valueObjectByColumn["LOGKEY"]
            |> SqlType.Parse DBLOGTable.columnsByName["LOGKEY"].schema DBLOGTable.columnsByName["LOGKEY"].isOption
            |> SqlType.asInt32
        MODBY =
            sqlEntity.valueObjectByColumn["MODBY"]
            |> SqlType.Parse DBLOGTable.columnsByName["MODBY"].schema DBLOGTable.columnsByName["MODBY"].isOption
            |> SqlType.asStringOption
        MODDTTM =
            sqlEntity.valueObjectByColumn["MODDTTM"]
            |> SqlType.Parse DBLOGTable.columnsByName["MODDTTM"].schema DBLOGTable.columnsByName["MODDTTM"].isOption
            |> SqlType.asDateTimeOption
        SQLSTMT =
            sqlEntity.valueObjectByColumn["SQLSTMT"]
            |> SqlType.Parse DBLOGTable.columnsByName["SQLSTMT"].schema DBLOGTable.columnsByName["SQLSTMT"].isOption
            |> SqlType.asStringOption
    })
let DBPENDINGMODIFICATIONSTable =
    SqlTable(
        "MetaData",
        "DBPENDINGMODIFICATIONS",
        query {
            for entity in Sql.serverData.MetaData.Dbpendingmodifications do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBPENDINGMODIFICATIONSTable.asAstModule.clip
*)
let DBTABLETable =
    SqlTable(
        "MetaData",
        "DBTABLE",
        query {
            for entity in Sql.serverData.MetaData.Dbtable do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBTABLETable.asAstModule.clip
*)
let DBTABLE_LOCALIZEDTable =
    SqlTable(
        "MetaData",
        "DBTABLE_LOCALIZED",
        query {
            for entity in Sql.serverData.MetaData.DbtableLocalized do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBTABLE_LOCALIZEDTable.asAstModule.clip
*)
let DBVERSIONLOGTable =
    SqlTable(
        "MetaData",
        "DBVERSIONLOG",
        query {
            for entity in Sql.serverData.MetaData.Dbversionlog do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
DBVERSIONLOGTable.asAstModule.clip
*)
let PACKAGESTable =
    SqlTable(
        "MetaData",
        "PACKAGES",
        query {
            for entity in Sql.serverData.MetaData.Packages do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
PACKAGESTable.asAstModule.clip
*)
let PRODUCTFAMILYTable =
    SqlTable(
        "MetaData",
        "PRODUCTFAMILY",
        query {
            for entity in Sql.serverData.MetaData.Productfamily do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
PRODUCTFAMILYTable.asAstModule.clip
*)
let SHTESTTable =
    SqlTable(
        "MetaData",
        "SHTEST",
        query {
            for entity in Sql.serverData.MetaData.Shtest do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
SHTESTTable.asAstModule.clip
*)
let SYSTEMLICENSETable =
    SqlTable(
        "MetaData",
        "SYSTEMLICENSE",
        query {
            for entity in Sql.serverData.MetaData.Systemlicense do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
SYSTEMLICENSETable.asAstModule.clip
*)
let TABLEDATATable =
    SqlTable(
        "METADATA_EXPORTDATA",
        "TABLEDATA",
        query {
            for entity in Sql.serverData.MetadataExportdata.Tabledata do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
TABLEDATATable.asAstModule.clip
*)
let TABLEDATA_COLUMNSTable =
    SqlTable(
        "METADATA_EXPORTDATA",
        "TABLEDATA_COLUMNS",
        query {
            for entity in Sql.serverData.MetadataExportdata.Tabledata do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
TABLEDATA_COLUMNSTable.asAstModule.clip
*)
let CLASSDEFINITIONTable =
    SqlTable(
        "METADATA_IMPLEMENTATION",
        "CLASSDEFINITION",
        query {
            for entity in Sql.serverData.MetadataImplementation.Classdefinition do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
CLASSDEFINITIONTable.asAstModule.clip
*)
let INTERFACETable =
    SqlTable(
        "METADATA_IMPLEMENTATION",
        "INTERFACE",
        query {
            for entity in Sql.serverData.MetadataImplementation.Interface do
                select entity
        }
        |> PSeq.toArray
        |> Array.Parallel.map (fun entity -> entity :> Common.SqlEntity)
    )
(*
INTERFACETable.asAstModule.clip
*)
