#time on

fsi.PrintLength <- 1
// fsi.PrintSize <- Int32.MaxValue
fsi.ShowDeclarationValues <- true
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "Internet.dll"
#r "TopLevelDomain.dll"
#r "IanaScheme.dll"
#r "ResourceIdentification.dll"
#r "ResourceDescription.dll"
#r "Iana.dll"
#r "IanaScheme.dll"
#r "IanaMime.dll"
#r "NetworkMonitor.dll"
#r "Turtle.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Ast.fsx"
open SharedKernel
open StringModule
open Internet
open ResourceIdentification
open ResourceDescription
open Turtle
open Iana
open NetworkMonitor

#load @".paket/load/main.group.fsx"
open PuppeteerSharp
open PuppeteerSharp.Cdp
open FolkerKinzel.MimeTypes
open System.Web
open IriTools
open System.Text.RegularExpressions

open System
open Humanizer
open CaseConverter
open System.Text
open TextCopy
open System.IO
open System.Linq
open PuppeteerSharp
open PuppeteerSharp.Cdp
open Tavis.UriTemplates
open BrowserApi.Css.Authoring
open BrowserApi.Css
open BrowserApi
open Meziantou.Framework
open System.Threading
open VDS.RDF
open FSharp.Data
open VDS.RDF.Parsing
open Universal.Common
open RDFSharp.Model
open AW.Identifiers
open LSL.DataUri

open System
open System.Globalization
open System.IO
open System.Threading
open System.Threading.Tasks

open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open FSharp.Collections.ParallelSeq
// #r "nuget: Microsoft.SqlServer.DacFx"

open Microsoft.SqlServer.Dac
open Microsoft.SqlServer.Dac.Model

open Fabulous.AST
open Fantomas.Core
#load @"C:\Secret\InforSecrets.fsx"
#load @"C:\Secret\EsriSecrets.fsx"
#load @"C:\Secret\ProjectDoxSecrets.fsx"
#load @"DataTierApplication.fsx"
open DataTierApplication
open ktsu.Semantics.Paths
open FsExcel
open FSharp.Text.RegexProvider
open FSharp.Text.RegexExtensions
open CsvHelper
module FSharpLiteral = FSharp.Literals.Literal

// let extractionTask = Task.Run(fun () -> dacExtract ())

module Sql =

    type Provider =
        SqlDataProvider<
            IndividualsAmount=1000,
            UseOptionTypes=Common.NullableColumnType.OPTION,
            CaseSensitivityChange=Common.CaseSensitivityChange.ORIGINAL,
            SsdtPath=ProjectDoxSecrets.Prod.dapac,
            ConnectionString=ProjectDoxSecrets.Prod.connectionString
         >
    let serverData = Provider.GetDataContext()
    let serverMetadata = Provider.GetReadOnlyDataContext()
    let dataContext = (box serverData) :?> Common.ISqlDataContext

module TSql =
    let DataTierApplication = {
        applicationName = "ProjectDox IPA"
        applicationDescription = "ProjectDox Interoperable Programmatic Automation"
        connectionString = ProjectDoxSecrets.Prod.connectionString
        dacpacFilePath = ProjectDoxSecrets.Prod.dapac
        databaseName = ProjectDoxSecrets.Prod.host
    }
    let Model = DataTierApplication.LoadModel()

module model =
    [<Literal>]
    let filePath = @"D:\Persistence\DAC\ProjectDox\model.xml"
    type Provider = XmlProvider<UseOriginalNames=true, Sample=filePath>
    let xml = Provider.Load filePath

module Origin =
    [<Literal>]
    let filePath = @"D:\Persistence\DAC\ProjectDox\Origin.xml"
    type Provider = XmlProvider<UseOriginalNames=true, Sample=filePath>
    let xml = Provider.Load filePath

module dox =
    let _namespaceTemplate = UriTemplate "https://DOXSQL-PROD.LeonAD.gov#{localName}"
    let _namespaceIri = _namespaceTemplate.AddParameters({| localName = String.Empty |}).asIri

    let _prefixedName (localName: string) =
        _namespaceTemplate.AddParameters({| localName = localName |}).asIri

    RDFNamespaceRegister.AddNamespace(RDFNamespace("dox", _namespaceIri.lexicalForm))

let fileEntities =
    query {
        for entity in Sql.serverData.Dbo.Files do
            select entity
    }
    |> PSeq.toArray
    |> Array.map (fun entity -> entity :> Common.SqlEntity)

let folderEntities =
    query {
        for entity in Sql.serverData.Dbo.Folders do
            select entity
    }
    |> PSeq.toArray
    |> Array.map (fun entity -> entity :> Common.SqlEntity)
let projectEntities =
    query {
        for entity in Sql.serverData.Dbo.Projects do
            select entity
    }
    |> PSeq.toArray
    |> Array.map (fun entity -> entity :> Common.SqlEntity)

let FilesTable = SqlTable("dbo", "Files", fileEntities)
(*
FilesTable.asAstModule.clip
*)

type File = {
    AuthorID: int
    BravaFile: string option
    CheckedOutBy: int
    CopiedFromFileID: int
    DateUpdated: DateTime
    Description: string option
    ErrorCode: string option
    ErrorMessage: string option
    FileID: int
    Filename: string
    Filesize: int
    FolderID: int
    IncomingID: int
    Keywords: string option
    LastModAuthor: string option
    LastModDate: DateTime
    OpenInBlueBeam: bool
    OrigAuthor: string option
    PageCount: int
    Preliminary: bool
    ProjectID: int
    PublishDate: DateTime option
    PublishPath: string option
    PublishURL: string option
    Rank: int
    SheetSize: string option
    SourcePath: string option
    SquareFeet: int
    Success: bool
    URL: string option
    UpdatedBy: int
    UploadBatchDate: DateTime
    UploadBatchID: string option
    UploadDate: DateTime
    Version: int
}

let files =
    fileEntities
    |> Array.Parallel.map (fun sqlEntity -> {
        AuthorID =
            sqlEntity.valueObjectByColumn["AuthorID"]
            |> SqlType.Parse FilesTable.columnsByName["AuthorID"].schema FilesTable.columnsByName["AuthorID"].isOption
            |> SqlType.asInt32
        BravaFile =
            sqlEntity.valueObjectByColumn["BravaFile"]
            |> SqlType.Parse FilesTable.columnsByName["BravaFile"].schema FilesTable.columnsByName["BravaFile"].isOption
            |> SqlType.asStringOption
        CheckedOutBy =
            sqlEntity.valueObjectByColumn["CheckedOutBy"]
            |> SqlType.Parse FilesTable.columnsByName["CheckedOutBy"].schema FilesTable.columnsByName["CheckedOutBy"].isOption
            |> SqlType.asInt32
        CopiedFromFileID =
            sqlEntity.valueObjectByColumn["CopiedFromFileID"]
            |> SqlType.Parse FilesTable.columnsByName["CopiedFromFileID"].schema FilesTable.columnsByName["CopiedFromFileID"].isOption
            |> SqlType.asInt32
        DateUpdated =
            sqlEntity.valueObjectByColumn["DateUpdated"]
            |> SqlType.Parse FilesTable.columnsByName["DateUpdated"].schema FilesTable.columnsByName["DateUpdated"].isOption
            |> SqlType.asDateTime
        Description =
            sqlEntity.valueObjectByColumn["Description"]
            |> SqlType.Parse FilesTable.columnsByName["Description"].schema FilesTable.columnsByName["Description"].isOption
            |> SqlType.asStringOption
        ErrorCode =
            sqlEntity.valueObjectByColumn["ErrorCode"]
            |> SqlType.Parse FilesTable.columnsByName["ErrorCode"].schema FilesTable.columnsByName["ErrorCode"].isOption
            |> SqlType.asStringOption
        ErrorMessage =
            sqlEntity.valueObjectByColumn["ErrorMessage"]
            |> SqlType.Parse FilesTable.columnsByName["ErrorMessage"].schema FilesTable.columnsByName["ErrorMessage"].isOption
            |> SqlType.asStringOption
        FileID =
            sqlEntity.valueObjectByColumn["FileID"]
            |> SqlType.Parse FilesTable.columnsByName["FileID"].schema FilesTable.columnsByName["FileID"].isOption
            |> SqlType.asInt32
        Filename =
            sqlEntity.valueObjectByColumn["Filename"]
            |> SqlType.Parse FilesTable.columnsByName["Filename"].schema FilesTable.columnsByName["Filename"].isOption
            |> SqlType.asString
        Filesize =
            sqlEntity.valueObjectByColumn["Filesize"]
            |> SqlType.Parse FilesTable.columnsByName["Filesize"].schema FilesTable.columnsByName["Filesize"].isOption
            |> SqlType.asInt32
        FolderID =
            sqlEntity.valueObjectByColumn["FolderID"]
            |> SqlType.Parse FilesTable.columnsByName["FolderID"].schema FilesTable.columnsByName["FolderID"].isOption
            |> SqlType.asInt32
        IncomingID =
            sqlEntity.valueObjectByColumn["IncomingID"]
            |> SqlType.Parse FilesTable.columnsByName["IncomingID"].schema FilesTable.columnsByName["IncomingID"].isOption
            |> SqlType.asInt32
        Keywords =
            sqlEntity.valueObjectByColumn["Keywords"]
            |> SqlType.Parse FilesTable.columnsByName["Keywords"].schema FilesTable.columnsByName["Keywords"].isOption
            |> SqlType.asStringOption
        LastModAuthor =
            sqlEntity.valueObjectByColumn["LastModAuthor"]
            |> SqlType.Parse FilesTable.columnsByName["LastModAuthor"].schema FilesTable.columnsByName["LastModAuthor"].isOption
            |> SqlType.asStringOption
        LastModDate =
            sqlEntity.valueObjectByColumn["LastModDate"]
            |> SqlType.Parse FilesTable.columnsByName["LastModDate"].schema FilesTable.columnsByName["LastModDate"].isOption
            |> SqlType.asDateTime
        OpenInBlueBeam =
            sqlEntity.valueObjectByColumn["OpenInBlueBeam"]
            |> SqlType.Parse FilesTable.columnsByName["OpenInBlueBeam"].schema FilesTable.columnsByName["OpenInBlueBeam"].isOption
            |> SqlType.asBoolean
        OrigAuthor =
            sqlEntity.valueObjectByColumn["OrigAuthor"]
            |> SqlType.Parse FilesTable.columnsByName["OrigAuthor"].schema FilesTable.columnsByName["OrigAuthor"].isOption
            |> SqlType.asStringOption
        PageCount =
            sqlEntity.valueObjectByColumn["PageCount"]
            |> SqlType.Parse FilesTable.columnsByName["PageCount"].schema FilesTable.columnsByName["PageCount"].isOption
            |> SqlType.asInt32
        Preliminary =
            sqlEntity.valueObjectByColumn["Preliminary"]
            |> SqlType.Parse FilesTable.columnsByName["Preliminary"].schema FilesTable.columnsByName["Preliminary"].isOption
            |> SqlType.asBoolean
        ProjectID =
            sqlEntity.valueObjectByColumn["ProjectID"]
            |> SqlType.Parse FilesTable.columnsByName["ProjectID"].schema FilesTable.columnsByName["ProjectID"].isOption
            |> SqlType.asInt32
        PublishDate =
            sqlEntity.valueObjectByColumn["PublishDate"]
            |> SqlType.Parse FilesTable.columnsByName["PublishDate"].schema FilesTable.columnsByName["PublishDate"].isOption
            |> SqlType.asDateTimeOption
        PublishPath =
            sqlEntity.valueObjectByColumn["PublishPath"]
            |> SqlType.Parse FilesTable.columnsByName["PublishPath"].schema FilesTable.columnsByName["PublishPath"].isOption
            |> SqlType.asStringOption
        PublishURL =
            sqlEntity.valueObjectByColumn["PublishURL"]
            |> SqlType.Parse FilesTable.columnsByName["PublishURL"].schema FilesTable.columnsByName["PublishURL"].isOption
            |> SqlType.asStringOption
        Rank =
            sqlEntity.valueObjectByColumn["Rank"]
            |> SqlType.Parse FilesTable.columnsByName["Rank"].schema FilesTable.columnsByName["Rank"].isOption
            |> SqlType.asInt32
        SheetSize =
            sqlEntity.valueObjectByColumn["SheetSize"]
            |> SqlType.Parse FilesTable.columnsByName["SheetSize"].schema FilesTable.columnsByName["SheetSize"].isOption
            |> SqlType.asStringOption
        SourcePath =
            sqlEntity.valueObjectByColumn["SourcePath"]
            |> SqlType.Parse FilesTable.columnsByName["SourcePath"].schema FilesTable.columnsByName["SourcePath"].isOption
            |> SqlType.asStringOption
        SquareFeet =
            sqlEntity.valueObjectByColumn["SquareFeet"]
            |> SqlType.Parse FilesTable.columnsByName["SquareFeet"].schema FilesTable.columnsByName["SquareFeet"].isOption
            |> SqlType.asInt32
        Success =
            sqlEntity.valueObjectByColumn["Success"]
            |> SqlType.Parse FilesTable.columnsByName["Success"].schema FilesTable.columnsByName["Success"].isOption
            |> SqlType.asBoolean
        URL =
            sqlEntity.valueObjectByColumn["URL"]
            |> SqlType.Parse FilesTable.columnsByName["URL"].schema FilesTable.columnsByName["URL"].isOption
            |> SqlType.asStringOption
        UpdatedBy =
            sqlEntity.valueObjectByColumn["UpdatedBy"]
            |> SqlType.Parse FilesTable.columnsByName["UpdatedBy"].schema FilesTable.columnsByName["UpdatedBy"].isOption
            |> SqlType.asInt32
        UploadBatchDate =
            sqlEntity.valueObjectByColumn["UploadBatchDate"]
            |> SqlType.Parse FilesTable.columnsByName["UploadBatchDate"].schema FilesTable.columnsByName["UploadBatchDate"].isOption
            |> SqlType.asDateTime
        UploadBatchID =
            sqlEntity.valueObjectByColumn["UploadBatchID"]
            |> SqlType.Parse FilesTable.columnsByName["UploadBatchID"].schema FilesTable.columnsByName["UploadBatchID"].isOption
            |> SqlType.asStringOption
        UploadDate =
            sqlEntity.valueObjectByColumn["UploadDate"]
            |> SqlType.Parse FilesTable.columnsByName["UploadDate"].schema FilesTable.columnsByName["UploadDate"].isOption
            |> SqlType.asDateTime
        Version =
            sqlEntity.valueObjectByColumn["Version"]
            |> SqlType.Parse FilesTable.columnsByName["Version"].schema FilesTable.columnsByName["Version"].isOption
            |> SqlType.asInt32
    })
// Real: 00:05:16.421, CPU: 00:05:33.546, GC gen0: 28799, gen1: 545, gen2: 0
let FoldersTable = SqlTable("dbo", "Folders", folderEntities)
(*
FoldersTable.asAstModule.clip
*)

type Folder = {
    DateUpdated: DateTime
    DerivedFromFolderID: int
    FileRankType: string option
    FolderID: int
    Name: string option
    PricePerMeg: decimal
    PricePerUpload: decimal
    PrintReady: bool
    ProjectID: int
    PublishPath: string
    SourcePath: string
    UpdatedBy: int
}

let folders =
    folderEntities
    |> Array.map (fun sqlEntity -> {
        DateUpdated =
            sqlEntity.valueObjectByColumn["DateUpdated"]
            |> SqlType.Parse FoldersTable.columnsByName["DateUpdated"].schema FoldersTable.columnsByName["DateUpdated"].isOption
            |> SqlType.asDateTime
        DerivedFromFolderID =
            sqlEntity.valueObjectByColumn["DerivedFromFolderID"]
            |> SqlType.Parse FoldersTable.columnsByName["DerivedFromFolderID"].schema FoldersTable.columnsByName["DerivedFromFolderID"].isOption
            |> SqlType.asInt32
        FileRankType =
            sqlEntity.valueObjectByColumn["FileRankType"]
            |> SqlType.Parse FoldersTable.columnsByName["FileRankType"].schema FoldersTable.columnsByName["FileRankType"].isOption
            |> SqlType.asStringOption
        FolderID =
            sqlEntity.valueObjectByColumn["FolderID"]
            |> SqlType.Parse FoldersTable.columnsByName["FolderID"].schema FoldersTable.columnsByName["FolderID"].isOption
            |> SqlType.asInt32
        Name =
            sqlEntity.valueObjectByColumn["Name"]
            |> SqlType.Parse FoldersTable.columnsByName["Name"].schema FoldersTable.columnsByName["Name"].isOption
            |> SqlType.asStringOption
        PricePerMeg =
            sqlEntity.valueObjectByColumn["PricePerMeg"]
            |> SqlType.Parse FoldersTable.columnsByName["PricePerMeg"].schema FoldersTable.columnsByName["PricePerMeg"].isOption
            |> SqlType.asDecimal
        PricePerUpload =
            sqlEntity.valueObjectByColumn["PricePerUpload"]
            |> SqlType.Parse FoldersTable.columnsByName["PricePerUpload"].schema FoldersTable.columnsByName["PricePerUpload"].isOption
            |> SqlType.asDecimal
        PrintReady =
            sqlEntity.valueObjectByColumn["PrintReady"]
            |> SqlType.Parse FoldersTable.columnsByName["PrintReady"].schema FoldersTable.columnsByName["PrintReady"].isOption
            |> SqlType.asBoolean
        ProjectID =
            sqlEntity.valueObjectByColumn["ProjectID"]
            |> SqlType.Parse FoldersTable.columnsByName["ProjectID"].schema FoldersTable.columnsByName["ProjectID"].isOption
            |> SqlType.asInt32
        PublishPath =
            sqlEntity.valueObjectByColumn["PublishPath"]
            |> SqlType.Parse FoldersTable.columnsByName["PublishPath"].schema FoldersTable.columnsByName["PublishPath"].isOption
            |> SqlType.asString
        SourcePath =
            sqlEntity.valueObjectByColumn["SourcePath"]
            |> SqlType.Parse FoldersTable.columnsByName["SourcePath"].schema FoldersTable.columnsByName["SourcePath"].isOption
            |> SqlType.asString
        UpdatedBy =
            sqlEntity.valueObjectByColumn["UpdatedBy"]
            |> SqlType.Parse FoldersTable.columnsByName["UpdatedBy"].schema FoldersTable.columnsByName["UpdatedBy"].isOption
            |> SqlType.asInt32
    })
// Real: 00:00:24.011, CPU: 00:00:22.140, GC gen0: 1883, gen1: 370, gen2: 0
let ProjectsTable = SqlTable("dbo", "Projects", projectEntities)
(*
ProjectsTable.asAstModule.clip
*)

type Project = {
    Address1: string option
    Address2: string option
    AppIntakeFormInstanceID: int option
    Archived: bool
    ArchivedDate: DateTime option
    BillTo3rdParty: bool
    BillTo3rdParty_Co: string option
    BillToAccount: bool
    BillToCC: bool
    CCProjectOnTeamMail: bool
    CellPhone: string option
    City: string option
    Company: string option
    Contact: string option
    CreateCompleteDate: DateTime option
    CreateDate: DateTime
    DateUpdated: DateTime
    DefaultWorkflowType: int
    Description: string option
    DisableReaccept: bool
    DisableReassignment: bool
    Email: string option
    EmailTemplatePath: string option
    EnableIncoming: bool
    EndDate: DateTime option
    Exported: bool
    ExportedDate: DateTime option
    GIStreamIncomingFolder: string option
    IncomingFaxNumber: string option
    Latitude: string option
    Location: string option
    Longitude: string option
    Name: string
    NameOriginal: string
    OrderFulfillmentIDs: string option
    OwnerID: int
    Pager: string option
    PassThruExtensions: string option
    Phone: string option
    PostalCode: string option
    PrintReadyExtensions: string option
    ProjectID: int
    ProjectImage: string option
    ProjectTemplateID: int
    PublicAccess: bool
    PublishPath: string
    ReproDisplayPlanHoldersList: bool
    ReproOrderLockLevel: string option
    ReproSalesPerson: string option
    ShowThumbnails: bool
    SourcePath: string
    SpatialRelationConfigID: int option
    State: string option
    Status: string option
    StatusDefinitionURL: string option
    StatusInfo: string option
    SupportBluebeam: bool
    URL: string
    UpdatedBy: int
    VersioningEnabled: bool
}

let projects =
    projectEntities
    |> Array.map (fun sqlEntity -> {
        Address1 =
            sqlEntity.valueObjectByColumn["Address1"]
            |> SqlType.Parse ProjectsTable.columnsByName["Address1"].schema ProjectsTable.columnsByName["Address1"].isOption
            |> SqlType.asStringOption
        Address2 =
            sqlEntity.valueObjectByColumn["Address2"]
            |> SqlType.Parse ProjectsTable.columnsByName["Address2"].schema ProjectsTable.columnsByName["Address2"].isOption
            |> SqlType.asStringOption
        AppIntakeFormInstanceID =
            sqlEntity.valueObjectByColumn["AppIntakeFormInstanceID"]
            |> SqlType.Parse ProjectsTable.columnsByName["AppIntakeFormInstanceID"].schema ProjectsTable.columnsByName["AppIntakeFormInstanceID"].isOption
            |> SqlType.asInt32Option
        Archived =
            sqlEntity.valueObjectByColumn["Archived"]
            |> SqlType.Parse ProjectsTable.columnsByName["Archived"].schema ProjectsTable.columnsByName["Archived"].isOption
            |> SqlType.asBoolean
        ArchivedDate =
            sqlEntity.valueObjectByColumn["ArchivedDate"]
            |> SqlType.Parse ProjectsTable.columnsByName["ArchivedDate"].schema ProjectsTable.columnsByName["ArchivedDate"].isOption
            |> SqlType.asDateTimeOption
        BillTo3rdParty =
            sqlEntity.valueObjectByColumn["BillTo3rdParty"]
            |> SqlType.Parse ProjectsTable.columnsByName["BillTo3rdParty"].schema ProjectsTable.columnsByName["BillTo3rdParty"].isOption
            |> SqlType.asBoolean
        BillTo3rdParty_Co =
            sqlEntity.valueObjectByColumn["BillTo3rdParty_Co"]
            |> SqlType.Parse ProjectsTable.columnsByName["BillTo3rdParty_Co"].schema ProjectsTable.columnsByName["BillTo3rdParty_Co"].isOption
            |> SqlType.asStringOption
        BillToAccount =
            sqlEntity.valueObjectByColumn["BillToAccount"]
            |> SqlType.Parse ProjectsTable.columnsByName["BillToAccount"].schema ProjectsTable.columnsByName["BillToAccount"].isOption
            |> SqlType.asBoolean
        BillToCC =
            sqlEntity.valueObjectByColumn["BillToCC"]
            |> SqlType.Parse ProjectsTable.columnsByName["BillToCC"].schema ProjectsTable.columnsByName["BillToCC"].isOption
            |> SqlType.asBoolean
        CCProjectOnTeamMail =
            sqlEntity.valueObjectByColumn["CCProjectOnTeamMail"]
            |> SqlType.Parse ProjectsTable.columnsByName["CCProjectOnTeamMail"].schema ProjectsTable.columnsByName["CCProjectOnTeamMail"].isOption
            |> SqlType.asBoolean
        CellPhone =
            sqlEntity.valueObjectByColumn["CellPhone"]
            |> SqlType.Parse ProjectsTable.columnsByName["CellPhone"].schema ProjectsTable.columnsByName["CellPhone"].isOption
            |> SqlType.asStringOption
        City =
            sqlEntity.valueObjectByColumn["City"]
            |> SqlType.Parse ProjectsTable.columnsByName["City"].schema ProjectsTable.columnsByName["City"].isOption
            |> SqlType.asStringOption
        Company =
            sqlEntity.valueObjectByColumn["Company"]
            |> SqlType.Parse ProjectsTable.columnsByName["Company"].schema ProjectsTable.columnsByName["Company"].isOption
            |> SqlType.asStringOption
        Contact =
            sqlEntity.valueObjectByColumn["Contact"]
            |> SqlType.Parse ProjectsTable.columnsByName["Contact"].schema ProjectsTable.columnsByName["Contact"].isOption
            |> SqlType.asStringOption
        CreateCompleteDate =
            sqlEntity.valueObjectByColumn["CreateCompleteDate"]
            |> SqlType.Parse ProjectsTable.columnsByName["CreateCompleteDate"].schema ProjectsTable.columnsByName["CreateCompleteDate"].isOption
            |> SqlType.asDateTimeOption
        CreateDate =
            sqlEntity.valueObjectByColumn["CreateDate"]
            |> SqlType.Parse ProjectsTable.columnsByName["CreateDate"].schema ProjectsTable.columnsByName["CreateDate"].isOption
            |> SqlType.asDateTime
        DateUpdated =
            sqlEntity.valueObjectByColumn["DateUpdated"]
            |> SqlType.Parse ProjectsTable.columnsByName["DateUpdated"].schema ProjectsTable.columnsByName["DateUpdated"].isOption
            |> SqlType.asDateTime
        DefaultWorkflowType =
            sqlEntity.valueObjectByColumn["DefaultWorkflowType"]
            |> SqlType.Parse ProjectsTable.columnsByName["DefaultWorkflowType"].schema ProjectsTable.columnsByName["DefaultWorkflowType"].isOption
            |> SqlType.asInt32
        Description =
            sqlEntity.valueObjectByColumn["Description"]
            |> SqlType.Parse ProjectsTable.columnsByName["Description"].schema ProjectsTable.columnsByName["Description"].isOption
            |> SqlType.asStringOption
        DisableReaccept =
            sqlEntity.valueObjectByColumn["DisableReaccept"]
            |> SqlType.Parse ProjectsTable.columnsByName["DisableReaccept"].schema ProjectsTable.columnsByName["DisableReaccept"].isOption
            |> SqlType.asBoolean
        DisableReassignment =
            sqlEntity.valueObjectByColumn["DisableReassignment"]
            |> SqlType.Parse ProjectsTable.columnsByName["DisableReassignment"].schema ProjectsTable.columnsByName["DisableReassignment"].isOption
            |> SqlType.asBoolean
        Email =
            sqlEntity.valueObjectByColumn["Email"]
            |> SqlType.Parse ProjectsTable.columnsByName["Email"].schema ProjectsTable.columnsByName["Email"].isOption
            |> SqlType.asStringOption
        EmailTemplatePath =
            sqlEntity.valueObjectByColumn["EmailTemplatePath"]
            |> SqlType.Parse ProjectsTable.columnsByName["EmailTemplatePath"].schema ProjectsTable.columnsByName["EmailTemplatePath"].isOption
            |> SqlType.asStringOption
        EnableIncoming =
            sqlEntity.valueObjectByColumn["EnableIncoming"]
            |> SqlType.Parse ProjectsTable.columnsByName["EnableIncoming"].schema ProjectsTable.columnsByName["EnableIncoming"].isOption
            |> SqlType.asBoolean
        EndDate =
            sqlEntity.valueObjectByColumn["EndDate"]
            |> SqlType.Parse ProjectsTable.columnsByName["EndDate"].schema ProjectsTable.columnsByName["EndDate"].isOption
            |> SqlType.asDateTimeOption
        Exported =
            sqlEntity.valueObjectByColumn["Exported"]
            |> SqlType.Parse ProjectsTable.columnsByName["Exported"].schema ProjectsTable.columnsByName["Exported"].isOption
            |> SqlType.asBoolean
        ExportedDate =
            sqlEntity.valueObjectByColumn["ExportedDate"]
            |> SqlType.Parse ProjectsTable.columnsByName["ExportedDate"].schema ProjectsTable.columnsByName["ExportedDate"].isOption
            |> SqlType.asDateTimeOption
        GIStreamIncomingFolder =
            sqlEntity.valueObjectByColumn["GIStreamIncomingFolder"]
            |> SqlType.Parse ProjectsTable.columnsByName["GIStreamIncomingFolder"].schema ProjectsTable.columnsByName["GIStreamIncomingFolder"].isOption
            |> SqlType.asStringOption
        IncomingFaxNumber =
            sqlEntity.valueObjectByColumn["IncomingFaxNumber"]
            |> SqlType.Parse ProjectsTable.columnsByName["IncomingFaxNumber"].schema ProjectsTable.columnsByName["IncomingFaxNumber"].isOption
            |> SqlType.asStringOption
        Latitude =
            sqlEntity.valueObjectByColumn["Latitude"]
            |> SqlType.Parse ProjectsTable.columnsByName["Latitude"].schema ProjectsTable.columnsByName["Latitude"].isOption
            |> SqlType.asStringOption
        Location =
            sqlEntity.valueObjectByColumn["Location"]
            |> SqlType.Parse ProjectsTable.columnsByName["Location"].schema ProjectsTable.columnsByName["Location"].isOption
            |> SqlType.asStringOption
        Longitude =
            sqlEntity.valueObjectByColumn["Longitude"]
            |> SqlType.Parse ProjectsTable.columnsByName["Longitude"].schema ProjectsTable.columnsByName["Longitude"].isOption
            |> SqlType.asStringOption
        Name =
            sqlEntity.valueObjectByColumn["Name"]
            |> SqlType.Parse ProjectsTable.columnsByName["Name"].schema ProjectsTable.columnsByName["Name"].isOption
            |> SqlType.asString
        NameOriginal =
            sqlEntity.valueObjectByColumn["NameOriginal"]
            |> SqlType.Parse ProjectsTable.columnsByName["NameOriginal"].schema ProjectsTable.columnsByName["NameOriginal"].isOption
            |> SqlType.asString
        OrderFulfillmentIDs =
            sqlEntity.valueObjectByColumn["OrderFulfillmentIDs"]
            |> SqlType.Parse ProjectsTable.columnsByName["OrderFulfillmentIDs"].schema ProjectsTable.columnsByName["OrderFulfillmentIDs"].isOption
            |> SqlType.asStringOption
        OwnerID =
            sqlEntity.valueObjectByColumn["OwnerID"]
            |> SqlType.Parse ProjectsTable.columnsByName["OwnerID"].schema ProjectsTable.columnsByName["OwnerID"].isOption
            |> SqlType.asInt32
        Pager =
            sqlEntity.valueObjectByColumn["Pager"]
            |> SqlType.Parse ProjectsTable.columnsByName["Pager"].schema ProjectsTable.columnsByName["Pager"].isOption
            |> SqlType.asStringOption
        PassThruExtensions =
            sqlEntity.valueObjectByColumn["PassThruExtensions"]
            |> SqlType.Parse ProjectsTable.columnsByName["PassThruExtensions"].schema ProjectsTable.columnsByName["PassThruExtensions"].isOption
            |> SqlType.asStringOption
        Phone =
            sqlEntity.valueObjectByColumn["Phone"]
            |> SqlType.Parse ProjectsTable.columnsByName["Phone"].schema ProjectsTable.columnsByName["Phone"].isOption
            |> SqlType.asStringOption
        PostalCode =
            sqlEntity.valueObjectByColumn["PostalCode"]
            |> SqlType.Parse ProjectsTable.columnsByName["PostalCode"].schema ProjectsTable.columnsByName["PostalCode"].isOption
            |> SqlType.asStringOption
        PrintReadyExtensions =
            sqlEntity.valueObjectByColumn["PrintReadyExtensions"]
            |> SqlType.Parse ProjectsTable.columnsByName["PrintReadyExtensions"].schema ProjectsTable.columnsByName["PrintReadyExtensions"].isOption
            |> SqlType.asStringOption
        ProjectID =
            sqlEntity.valueObjectByColumn["ProjectID"]
            |> SqlType.Parse ProjectsTable.columnsByName["ProjectID"].schema ProjectsTable.columnsByName["ProjectID"].isOption
            |> SqlType.asInt32
        ProjectImage =
            sqlEntity.valueObjectByColumn["ProjectImage"]
            |> SqlType.Parse ProjectsTable.columnsByName["ProjectImage"].schema ProjectsTable.columnsByName["ProjectImage"].isOption
            |> SqlType.asStringOption
        ProjectTemplateID =
            sqlEntity.valueObjectByColumn["ProjectTemplateID"]
            |> SqlType.Parse ProjectsTable.columnsByName["ProjectTemplateID"].schema ProjectsTable.columnsByName["ProjectTemplateID"].isOption
            |> SqlType.asInt32
        PublicAccess =
            sqlEntity.valueObjectByColumn["PublicAccess"]
            |> SqlType.Parse ProjectsTable.columnsByName["PublicAccess"].schema ProjectsTable.columnsByName["PublicAccess"].isOption
            |> SqlType.asBoolean
        PublishPath =
            sqlEntity.valueObjectByColumn["PublishPath"]
            |> SqlType.Parse ProjectsTable.columnsByName["PublishPath"].schema ProjectsTable.columnsByName["PublishPath"].isOption
            |> SqlType.asString
        ReproDisplayPlanHoldersList =
            sqlEntity.valueObjectByColumn["ReproDisplayPlanHoldersList"]
            |> SqlType.Parse ProjectsTable.columnsByName["ReproDisplayPlanHoldersList"].schema ProjectsTable.columnsByName["ReproDisplayPlanHoldersList"].isOption
            |> SqlType.asBoolean
        ReproOrderLockLevel =
            sqlEntity.valueObjectByColumn["ReproOrderLockLevel"]
            |> SqlType.Parse ProjectsTable.columnsByName["ReproOrderLockLevel"].schema ProjectsTable.columnsByName["ReproOrderLockLevel"].isOption
            |> SqlType.asStringOption
        ReproSalesPerson =
            sqlEntity.valueObjectByColumn["ReproSalesPerson"]
            |> SqlType.Parse ProjectsTable.columnsByName["ReproSalesPerson"].schema ProjectsTable.columnsByName["ReproSalesPerson"].isOption
            |> SqlType.asStringOption
        ShowThumbnails =
            sqlEntity.valueObjectByColumn["ShowThumbnails"]
            |> SqlType.Parse ProjectsTable.columnsByName["ShowThumbnails"].schema ProjectsTable.columnsByName["ShowThumbnails"].isOption
            |> SqlType.asBoolean
        SourcePath =
            sqlEntity.valueObjectByColumn["SourcePath"]
            |> SqlType.Parse ProjectsTable.columnsByName["SourcePath"].schema ProjectsTable.columnsByName["SourcePath"].isOption
            |> SqlType.asString
        SpatialRelationConfigID =
            sqlEntity.valueObjectByColumn["SpatialRelationConfigID"]
            |> SqlType.Parse ProjectsTable.columnsByName["SpatialRelationConfigID"].schema ProjectsTable.columnsByName["SpatialRelationConfigID"].isOption
            |> SqlType.asInt32Option
        State =
            sqlEntity.valueObjectByColumn["State"]
            |> SqlType.Parse ProjectsTable.columnsByName["State"].schema ProjectsTable.columnsByName["State"].isOption
            |> SqlType.asStringOption
        Status =
            sqlEntity.valueObjectByColumn["Status"]
            |> SqlType.Parse ProjectsTable.columnsByName["Status"].schema ProjectsTable.columnsByName["Status"].isOption
            |> SqlType.asStringOption
        StatusDefinitionURL =
            sqlEntity.valueObjectByColumn["StatusDefinitionURL"]
            |> SqlType.Parse ProjectsTable.columnsByName["StatusDefinitionURL"].schema ProjectsTable.columnsByName["StatusDefinitionURL"].isOption
            |> SqlType.asStringOption
        StatusInfo =
            sqlEntity.valueObjectByColumn["StatusInfo"]
            |> SqlType.Parse ProjectsTable.columnsByName["StatusInfo"].schema ProjectsTable.columnsByName["StatusInfo"].isOption
            |> SqlType.asStringOption
        SupportBluebeam =
            sqlEntity.valueObjectByColumn["SupportBluebeam"]
            |> SqlType.Parse ProjectsTable.columnsByName["SupportBluebeam"].schema ProjectsTable.columnsByName["SupportBluebeam"].isOption
            |> SqlType.asBoolean
        URL =
            sqlEntity.valueObjectByColumn["URL"]
            |> SqlType.Parse ProjectsTable.columnsByName["URL"].schema ProjectsTable.columnsByName["URL"].isOption
            |> SqlType.asString
        UpdatedBy =
            sqlEntity.valueObjectByColumn["UpdatedBy"]
            |> SqlType.Parse ProjectsTable.columnsByName["UpdatedBy"].schema ProjectsTable.columnsByName["UpdatedBy"].isOption
            |> SqlType.asInt32
        VersioningEnabled =
            sqlEntity.valueObjectByColumn["VersioningEnabled"]
            |> SqlType.Parse ProjectsTable.columnsByName["VersioningEnabled"].schema ProjectsTable.columnsByName["VersioningEnabled"].isOption
            |> SqlType.asBoolean
    })
// Real: 00:01:15.749, CPU: 00:01:17.625, GC gen0: 5985, gen1: 536, gen2: 0

(*
--IDENTIFY FILES SOURCE PATH:  =  PATH PER PROJECT ID, AND FOLDER ID IN WHICH THE FILE RESIDES

SELECT  P.[Name][PROJECT NAME], FI.ProjectID, --P.Status, 
FI.FolderID,FO.[Name] [FOLDER NAME],  FI.SourcePath, FI.PublishPath, FI.Version, 
FI.UploadDate, FI.Filesize, FI.PageCount,P.ProjectTemplateID

FROM ProjectDox.dbo.Files FI

INNER JOIN Folders FO ON FO.FolderID = FI.FolderID

INNER JOIN PROJECTS P ON P.ProjectID = FI.ProjectID

WHERE  P.ProjectTemplateID IN ('8','10','14','16','19','21','23','24','25','26','28','29','30','32','38','39','40','41','42')
and ( UPPER(P.Status) NOT IN ('VOID','WITHDRAWN') OR UPPER(P.StatusInfo) NOT LIKE '%WITHDRAWN%' OR UPPER(P.StatusInfo) NOT LIKE 'VOID' OR UPPER (P.[Name]) NOT LIKE '%VOID%' OR UPPER (P.[Name]) NOT LIKE '%WITHDRAWN%')

and FI.ProjectID IN (26725,24976,24912,24983,24754,23939)

ORDER BY P.[Name],FO.[Name], FI.[Filename]
*)

let UFP = @"\\Doxfile-Prod\UFP"

type Project with
    member this._files = files |> Array.filter (fun file -> file.ProjectID = this.ProjectID)
    member this._folders = folders |> Array.filter (fun folder -> folder.ProjectID = this.ProjectID)
type Folder with
    member this._project = projects |> Array.find (fun project -> this.ProjectID = project.ProjectID)
    member this._files = files |> Array.filter (fun file -> file.FolderID = this.FolderID)

type File with
    member this._project = projects |> Array.find (fun project -> this.ProjectID = project.ProjectID)
    member this._folder = folders |> Array.tryFind (fun folder -> this.FolderID = folder.FolderID)
    member this._stem = Path.GetFileNameWithoutExtension this.Filename
    member this._entityId = $"{this.ProjectID}-{this.FolderID}-{this.FileID}"

let projectStatuses =
    ProjectsTable.columnsByName["Status"].values
    |> Array.choose (fun value ->
        match value with
        | SqlType.nvarcharOption (status) -> status
        | _ -> None)
    |> Array.distinct
    |> Array.sort
// projectStatuses |> String.concat "\n" |> String.Clipboard.SetText
(*

[<RequireQualifiedAccess>]
type ProjectStatus =
    | ``Active``
    | ``Applicant Corrections``
    | ``Applicant Upload``
    | ``Approved``
    | ``Cancelled``
    | ``Client``
    | ``Completed``
    | ``In Progress``
    | ``In Review``
    | ``On Hold``
    | ``Prescreen``
    | ``Waiting on Files Upload``
    | ``Withdrawn``
    | ``Void``
type Project with
    member this._projectStatus =
        match this.Status with
        | Some "Active" -> ProjectStatus.``Active``
        | Some "Applicant Corrections" -> ProjectStatus.``Applicant Corrections``
        | Some "Applicant Upload" -> ProjectStatus.``Applicant Upload``
        | Some "Approved" -> ProjectStatus.``Approved``
        | Some "Cancelled" -> ProjectStatus.``Cancelled``
        | Some "Client" -> ProjectStatus.``Client``
        | Some "Completed" -> ProjectStatus.``Completed``
        | Some "In Progress" -> ProjectStatus.``In Progress``
        | Some "In Review" -> ProjectStatus.``In Review``
        | Some "On Hold" -> ProjectStatus.``On Hold``
        | Some "Prescreen" -> ProjectStatus.``Prescreen``
        | Some "Waiting on Files Upload" -> ProjectStatus.``Waiting on Files Upload``
        | Some "Withdrawn" -> ProjectStatus.``Withdrawn``
        | _ -> ProjectStatus.``Void``
    member this._isExcludedProjectTemplateID = excludedProjectTemplateIDs.Contains this.ProjectTemplateID
    member this._isVoidOrWithdrawn =
        match this._projectStatus with
        | ProjectStatus.``Void``
        | ProjectStatus.``Withdrawn`` -> true
        | _ -> false
    member this._isNotVoidNorWithdrawn = not this._isVoidOrWithdrawn
    member this._statusInfoContainsWithdrawn =
        match this.StatusInfo with
        | Some statusInfo -> statusInfo.ToLowerInvariant().Contains "withdrawn"
        | _ -> false
    member this._statusInfoContainsVoid =
        match this.StatusInfo with
        | Some statusInfo -> statusInfo.ToLowerInvariant().Contains "void"
        | _ -> false
    member this._nameContainsWithdrawn = this.Name.ToLowerInvariant().Contains "withdrawn"
    member this._nameContainsVoid = this.Name.ToLowerInvariant().Contains "void"

project._projectStatus
project._isExcludedProjectTemplateID
project.StatusInfo

project.ProjectTemplateID
project._files
// Define a partial active pattern that extracts captured groups
let (|Regex|_|) pattern input =
    let m = Regex.Match(input, pattern)
    if m.Success then
        // Skip the first group (the entire match) and return the captured subgroups
        Some [ for g in m.Groups -> g.Value ] |> Option.map List.tail
    else
        None

module Pattern =
    [<Literal>]
    let phone = @"^\(?(?<AreaCode>\d{3})\)[\s-](?<PhoneNumber>\d{3}[\s-]\d{4}$)"
    [<Literal>]
    let altId = @"(?<ProjectPrefix>[A-Z]+)(?<ProjectNumber>\d+)"
    [<Literal>]
    let frontBackMatter = @"^\((?<FrontMatterA>\w+)\)\s+(?<ProjectPrefix>[A-Z]+)(?<ProjectNumber>\d+)([ -]+(?<BackMatter>.+))?"
    [<Literal>]
    let integer = @"^\d+$"

type PhoneNumber = Regex<Pattern.phone>
let parseProjectName projectName =
    match projectName with
    | Regex Pattern.frontBackMatter [ frontmatter; projectPrefix; projectNumber; backmatter ] -> projectNumber
    | Regex Pattern.frontBackMatter [ frontmatter; projectPrefix; projectNumber ] -> projectNumber
    | _ -> sprintf "Unknown Project Name Pattern  %s" projectName
parseProjectName "(EXPIRED) LSP22007 -  Type 'A' FDPA Track"

"(WITHDRAWN)  LEX200085"

"^\(?(\d{3})\)[\s-](\d{3}[\s-]\d{4}$)"

// Output: Area Code: 555, Number: 123-4567
let phoneNumber = "(555) 123-4567"
parseProjectName phoneNumber
PhoneNumber().TypedMatch(phoneNumber).AreaCode
PhoneNumber().TypedMatch(phoneNumber).PhoneNumber

let parseProjectName_ projectName =
    match projectName with
    | Regex @"\((\w+)\)(\d+)" [ prefix; suffix ] -> Some {| prefix = prefix; suffix = suffix |}
    | Regex @"(\w+)(\d+)" [ prefix; suffix ] -> Some {| prefix = prefix; suffix = suffix |}
    | _ -> None
let randomProject = projects |> Array.randomChoice
randomProject.Name
parseProjectName randomProject.Name

*)
let sourcePathPattern =
    let init = new UrlPatternInit()
    init.Pathname <- "{/:serverName}{/:UserFilesStorage}{/:ProjectID}{/:FolderID}{/:fileStem}.{:fileExtension}"
    UrlPattern.Create(init)

type File with
    member this._filePath =
        this.SourcePath
        |> Option.map (fun path -> $"{path.TrimStart('\\').Replace('\\', '/')}")
    member this._fileUrl =
        this.SourcePath
        |> Option.map (fun path -> $"https://www.example.com/{path.TrimStart('\\').Replace('\\', '/')}")
    member this._pathNamePattern =
        this._fileUrl
        |> Option.map (fun filePath -> (sourcePathPattern.Match filePath).Pathname)
        |> Option.tryNullOrWhiteSpace

let sourcePaths =
    files
    |> Array.choose (fun file -> file.SourcePath)
    |> Array.distinct
    |> Array.sort
// sourcePaths |> String.concat "\n" |> String.Clipboard.SetText

type UserFilesStorage =
    | UserFilesSource
    | UserFilesPublish

type DocumentGroup =
    | BLD
    | BLD_ACA
    | BUILDING
    | CODE_COMPLIANCE
    | DEV_ACA
    | DEVELOPMENT
    | ENVIRONMENTAL
    | ``L-APR``
    | ``L-CERT``
    | LIC_PROFESSIONALS
    | ``OFFICIAL RECORD``
    | PUBLIC_WORKS
    | Historical
type DocumentType =
    | Res
    | Case
    | ``Document Migration``
type EntityType =
    | CAP
    | PARCEL

type DocumentEntity = {
    filePath: string
    entityId: string option
    documentGroup: DocumentGroup option
    documentType: DocumentType option
    entityType: EntityType
}
(*
module AltId =
    type ExactLine = Regex<"""^(?<ProjectPrefix>[A-Za-z]+)(?<ProjectNumber>\d+)$""">
    type LB = Regex<"""LB[\s-]?(?<ProjectNumber>\d+)""">
    type DSEM = Regex<"""DSEM[\s-]?(?<ProjectNumber>\d+)""">
    type FrontBackMatter = Regex<"""^\(?(?<FrontMatterA>\w+)\)?[\s-]+(?<ProjectPrefix>[A-Za-z]+)(?<ProjectNumber>\d+)([ -]+(?<BackMatter>.+))?$""">
    type DSEMPrePrefixed = Regex<"""^.*DSEM.*(?<ProjectPrefix>[A-Za-z]+)[\s-]?\+?(?<ProjectNumber>\d+)$""">
    type GEMLICPrePrefixed = Regex<"""^.*GEM-LIC.*(?<ProjectPrefix>[A-Za-z]+)[\s-]?\+?(?<ProjectNumber>\d+)$""">
    type Prefixed = Regex<"""^(?<Prefix>\w+)[\s-]+(?<ProjectPrefix>[A-Za-z]+)(?<ProjectNumber>\d+)$""">
    type PrePrefixed = Regex<"""^(?<PrePrefix>\w+)[\s-]+(?<PostPrefix>[^\s]+)[\s-]+(?<ProjectPrefix>[A-Za-z]+)(?<ProjectNumber>\d+)$""">
    type Doubled = Regex<"""^(?<ProjectPrefix1>[A-Za-z]+)(?<ProjectNumber1>\d+).*(?<ProjectPrefix2>[A-Za-z]+)(?<ProjectNumber2>\d+).*$""">
    type Tripled =
        Regex<
            """^(?<ProjectPrefix1>[A-Za-z]+)(?<ProjectNumber1>\d+).*(?<ProjectPrefix2>[A-Za-z]+)(?<ProjectNumber2>\d+).*(?<ProjectPrefix3>[A-Za-z]+)(?<ProjectNumber3>\d+).*$"""
         >
    type StartLine = Regex<"""^(?<ProjectPrefix>[A-Za-z]+)(?<ProjectNumber>\d+).*""">
    type EndLine = Regex<""".*(?<ProjectPrefix>[A-Za-z]+)(?<ProjectNumber>\d+)$""">
    type PWENG = Regex<"""[pP][wW]-[eE][nN][gG][\s-](?<Number1>\d+)[\s-](?<Number2>\d+)(?<Description>.*)""">

let projectNameSet = projects |> Array.map (fun project -> project.Name) |> Set.ofArray

projectNameSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\projectNameSet.txt", projectNameSet)

let AltIdPWENGSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.PWENG().TypedMatch(projectName).Success)

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdPWENGSet.txt", AltIdPWENGSet)
let AltIdDSEMSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.DSEM().TypedMatch(projectName).Success)

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdDSEMSet.txt", AltIdDSEMSet)
let AltIdLBSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.LB().TypedMatch(projectName).Success)

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdLBSet.txt", AltIdLBSet)

let AltIdExactLineSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.ExactLine().TypedMatch(projectName).Success)
AltIdExactLineSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdExactLineSet.txt", AltIdExactLineSet)
let AltIdDSEMPrePrefixedSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.DSEMPrePrefixed().TypedMatch(projectName).Success)
AltIdDSEMPrePrefixedSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdDSEMPrePrefixedSet.txt", AltIdDSEMPrePrefixedSet)
let AltIdGEMLICPrePrefixedSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.GEMLICPrePrefixed().TypedMatch(projectName).Success)
AltIdGEMLICPrePrefixedSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdGEMLICPrePrefixedSet.txt", AltIdGEMLICPrePrefixedSet)
let AltIdTripledSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.Tripled().TypedMatch(projectName).Success)
AltIdTripledSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdTripledSet.txt", AltIdTripledSet)
let AltIdDoubledSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.Doubled().TypedMatch(projectName).Success)
AltIdDoubledSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdDoubledSet.txt", AltIdDoubledSet)
let AltIdPrefixedSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.Prefixed().TypedMatch(projectName).Success)
AltIdPrefixedSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdPrefixedSet.txt", AltIdPrefixedSet)
let AltIdPrePrefixedSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.PrePrefixed().TypedMatch(projectName).Success)
AltIdPrePrefixedSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdPrePrefixedSet.txt", AltIdPrePrefixedSet)
let AltIdFrontBackMatterSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.FrontBackMatter().TypedMatch(projectName).Success)
AltIdFrontBackMatterSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdFrontBackMatterSet.txt", AltIdFrontBackMatterSet)
let AltIdStartLineSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.StartLine().TypedMatch(projectName).Success)
AltIdStartLineSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdStartLineSet.txt", AltIdStartLineSet)
let AltIdEndLineSet =
    projectNameSet
    |> Set.filter (fun projectName -> AltId.EndLine().TypedMatch(projectName).Success)
AltIdEndLineSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\AltIdEndLineSet.txt", AltIdEndLineSet)

let remainingSet =
    projectNameSet
    - AltIdPWENGSet
    - AltIdDSEMSet
    - AltIdLBSet
    - AltIdExactLineSet
    - AltIdDSEMPrePrefixedSet
    - AltIdGEMLICPrePrefixedSet
    - AltIdTripledSet
    - AltIdDoubledSet
    - AltIdPrefixedSet
    - AltIdPrePrefixedSet
    - AltIdFrontBackMatterSet
    - AltIdStartLineSet
    - AltIdEndLineSet

remainingSet.Count()

File.WriteAllLines(@"C:\Secret\ProjectDox\remainingSet.txt", remainingSet)

let entityId (file: File) =

    match
        AltIdPWENGSet.Contains file._project.Name,
        AltIdDSEMSet.Contains file._project.Name,
        AltIdLBSet.Contains file._project.Name,
        AltIdExactLineSet.Contains file._project.Name,
        AltIdDSEMPrePrefixedSet.Contains file._project.Name,
        AltIdGEMLICPrePrefixedSet.Contains file._project.Name,
        AltIdTripledSet.Contains file._project.Name,
        AltIdDoubledSet.Contains file._project.Name,
        AltIdPrefixedSet.Contains file._project.Name,
        AltIdPrePrefixedSet.Contains file._project.Name,
        AltIdFrontBackMatterSet.Contains file._project.Name,
        AltIdStartLineSet.Contains file._project.Name,
        AltIdEndLineSet.Contains file._project.Name
    with
    | altIdPWENG,
      altIdDSEM,
      altIdLB,
      altIdExactLine,
      altIdDSEMPrePrefixed,
      altIdGEMLICPrePrefixed,
      altIdTripled,
      altIdDoubled,
      altIdPrefixed,
      altIdPrePrefixed,
      altIdFrontBackMatter,
      altIdStartLine,
      altIdEndLine when altIdExactLine = true -> Some file._project.Name
    | altIdPWENG,
      altIdDSEM,
      altIdLB,
      altIdExactLine,
      altIdDSEMPrePrefixed,
      altIdGEMLICPrePrefixed,
      altIdTripled,
      altIdDoubled,
      altIdPrefixed,
      altIdPrePrefixed,
      altIdFrontBackMatter,
      altIdStartLine,
      altIdEndLine -> None

*)

let filesWithoutPath = files |> Array.filter (fun file -> file.SourcePath.IsNone)
filesWithoutPath[0]
filesWithoutPath.Length

let defaultCell (maybeValue: option<'T>) : string =
    match maybeValue with
    | Some value -> string value
    | None -> String.Empty
let fileList = files |> Array.toList
let folderList = folders |> Array.toList
let projectList = projects |> Array.toList

[<Literal>]
let AltIDRegex = """(?<AltID>[A-Za-z]{2-3}\d+)"""
type AltID = Regex<AltIDRegex>
let matchedFileIds =
    files
    |> Array.Parallel.choose (fun file ->
        match AltID().TypedMatch(file._project.Name) with
        | altIdMatch when altIdMatch.Success -> Some(file.FileID, altIdMatch.CompleteMatch.Value)
        | _ -> None)
    |> Map.ofArray

// WHERE  P.ProjectTemplateID IN ('8','10','14','16','19','21','23','24','25','26','28','29','30','32','38','39','40','41','42')

let includedProjectTemplateIDs = set [ 8; 10; 14; 16; 19; 21; 23; 24; 25; 26; 28; 29; 30; 32; 38; 39; 40; 41; 42 ]
// and ( UPPER(P.Status) NOT IN ('VOID','WITHDRAWN') OR UPPER(P.StatusInfo) NOT LIKE '%WITHDRAWN%' OR UPPER(P.StatusInfo) NOT LIKE 'VOID' OR UPPER (P.[Name]) NOT LIKE '%VOID%' OR UPPER (P.[Name]) NOT LIKE '%WITHDRAWN%')
let excludedSubStrings = set [ "VOID"; "WITHDRAWN" ]
// and FI.ProjectID IN (26725,24976,24912,24983,24754,23939)
let includedProjectIDs = set [ 26725; 24976; 24912; 24983; 24754; 23939 ]

let Meta =
    files
    |> Array.filter (fun file -> file._filePath.IsSome)
    |> Array.Parallel.map (fun file -> {|
        ``File Path`` = file._filePath.Value
        ``Entity Id`` = file._entityId
        ``Document Group`` = "Historical"
        ``Document Type`` = "Document Migration"
        ``Entity Type`` = "CAP"
    |})
    |> Array.toList

let Files =
    files
    |> Array.Parallel.map (fun file -> {|
        EntityID = file._entityId
        AuthorID = file.AuthorID
        BravaFile = defaultCell file.BravaFile
        CheckedOutBy = file.CheckedOutBy
        CopiedFromFileID = file.CopiedFromFileID
        DateUpdated = file.DateUpdated
        Description = defaultCell file.Description
        ErrorCode = defaultCell file.ErrorCode
        ErrorMessage = defaultCell file.ErrorMessage
        FileID = file.FileID
        Filename = file.Filename
        FolderName =
            match file._folder with
            | Some folder when folder.Name.IsSome -> folder.Name.Value
            | _ -> String.Empty
        ProjectName = file._project.Name
        Filesize = file.Filesize
        FolderID = file.FolderID
        IncomingID = file.IncomingID
        Keywords = defaultCell file.Keywords
        LastModAuthor = defaultCell file.LastModAuthor
        LastModDate = file.LastModDate
        OpenInBlueBeam = file.OpenInBlueBeam
        OrigAuthor = defaultCell file.OrigAuthor
        PageCount = file.PageCount
        Preliminary = file.Preliminary
        ProjectID = file.ProjectID
        PublishDate = defaultCell file.PublishDate
        PublishPath = defaultCell file.PublishPath
        PublishURL = defaultCell file.PublishURL
        Rank = file.Rank
        SheetSize = defaultCell file.SheetSize
        SourcePath = defaultCell file.SourcePath
        SquareFeet = file.SquareFeet
        Success = file.Success
        URL = defaultCell file.URL
        UpdatedBy = file.UpdatedBy
        UploadBatchDate = file.UploadBatchDate
        UploadBatchID = defaultCell file.UploadBatchID
        UploadDate = file.UploadDate
        Version = file.Version
    |})
    |> Array.toList
let Folders =
    folders
    |> Array.Parallel.map (fun folder -> {|
        DateUpdated = folder.DateUpdated
        DerivedFromFolderID = folder.DerivedFromFolderID
        FileRankType = defaultCell folder.FileRankType
        FolderID = folder.FolderID
        Name = defaultCell folder.Name
        PricePerMeg = folder.PricePerMeg
        PricePerUpload = folder.PricePerUpload
        PrintReady = folder.PrintReady
        ProjectID = folder.ProjectID
        PublishPath = folder.PublishPath
        SourcePath = folder.SourcePath
        UpdatedBy = folder.UpdatedBy
    |})
    |> Array.toList
let Projects =
    projects
    |> Array.Parallel.map (fun project -> {|
        Address1 = defaultCell project.Address1
        Address2 = defaultCell project.Address2
        AppIntakeFormInstanceID = defaultCell project.AppIntakeFormInstanceID
        Archived = project.Archived
        ArchivedDate = defaultCell project.ArchivedDate
        BillTo3rdParty = project.BillTo3rdParty
        BillTo3rdParty_Co = defaultCell project.BillTo3rdParty_Co
        BillToAccount = project.BillToAccount
        BillToCC = project.BillToCC
        CCProjectOnTeamMail = project.CCProjectOnTeamMail
        CellPhone = defaultCell project.CellPhone
        City = defaultCell project.City
        Company = defaultCell project.Company
        Contact = defaultCell project.Contact
        CreateCompleteDate = defaultCell project.CreateCompleteDate
        CreateDate = project.CreateDate
        DateUpdated = project.DateUpdated
        DefaultWorkflowType = project.DefaultWorkflowType
        Description = defaultCell project.Description
        DisableReaccept = project.DisableReaccept
        DisableReassignment = project.DisableReassignment
        Email = defaultCell project.Email
        EmailTemplatePath = defaultCell project.EmailTemplatePath
        EnableIncoming = project.EnableIncoming
        EndDate = defaultCell project.EndDate
        Exported = project.Exported
        ExportedDate = defaultCell project.ExportedDate
        GIStreamIncomingFolder = defaultCell project.GIStreamIncomingFolder
        IncomingFaxNumber = defaultCell project.IncomingFaxNumber
        Latitude = defaultCell project.Latitude
        Location = defaultCell project.Location
        Longitude = defaultCell project.Longitude
        Name = project.Name
        NameOriginal = project.NameOriginal
        OrderFulfillmentIDs = defaultCell project.OrderFulfillmentIDs
        OwnerID = project.OwnerID
        Pager = defaultCell project.Pager
        PassThruExtensions = defaultCell project.PassThruExtensions
        Phone = defaultCell project.Phone
        PostalCode = defaultCell project.PostalCode
        PrintReadyExtensions = defaultCell project.PrintReadyExtensions
        ProjectID = project.ProjectID
        ProjectImage = defaultCell project.ProjectImage
        ProjectTemplateID = project.ProjectTemplateID
        PublicAccess = project.PublicAccess
        PublishPath = project.PublishPath
        ReproDisplayPlanHoldersList = project.ReproDisplayPlanHoldersList
        ReproOrderLockLevel = defaultCell project.ReproOrderLockLevel
        ReproSalesPerson = defaultCell project.ReproSalesPerson
        ShowThumbnails = project.ShowThumbnails
        SourcePath = project.SourcePath
        SpatialRelationConfigID = defaultCell project.SpatialRelationConfigID
        State = defaultCell project.State
        Status = defaultCell project.Status
        StatusDefinitionURL = defaultCell project.StatusDefinitionURL
        StatusInfo = defaultCell project.StatusInfo
        SupportBluebeam = project.SupportBluebeam
        URL = project.URL
        UpdatedBy = project.UpdatedBy
        VersioningEnabled = project.VersioningEnabled
    |})
    |> Array.toList

let FileNames = fileList |> List.map (fun file -> file._stem) |> List.distinct |> List.sort
let FolderNames =
    folderList
    |> List.choose (fun folder -> folder.Name)
    |> List.distinct
    |> List.sort
let ProjectNames =
    projectList
    |> List.map (fun project -> project.Name)
    |> List.distinct
    |> List.sort

[ Worksheet "Meta"; Table [ TableName "Meta"; TableItems Meta ]; AutoFit All ]
|> Render.AsFile @"C:\Secret\ProjectDox\Meta.xlsx"

module Render =
    let AsCsv (filePath: string) records =
        use csv = new CsvWriter(new StreamWriter(filePath), CultureInfo.InvariantCulture)
        csv.WriteRecords(records)

Files |> Render.AsCsv @"C:\Secret\ProjectDox\Files.csv"
Folders |> Render.AsCsv @"C:\Secret\ProjectDox\Folders.csv"
Projects |> Render.AsCsv @"C:\Secret\ProjectDox\Projects.csv"
FileNames
|> List.map (fun fileName -> {| FileName = fileName |})
|> Render.AsCsv @"C:\Secret\ProjectDox\FileNames.csv"
FolderNames
|> List.map (fun folderName -> {| FolderName = folderName |})
|> Render.AsCsv @"C:\Secret\ProjectDox\FolderNames.csv"
ProjectNames
|> List.map (fun projectName -> {| ProjectName = projectName |})
|> Render.AsCsv @"C:\Secret\ProjectDox\ProjectNames.csv"

let ProjectNamesWithAltIDs =
    ProjectNames
    |> List.choose (fun projectName ->
        match AltID().TypedMatch projectName with
        | altIdMatch when altIdMatch.Success ->
            Some {|
                ProjectName = projectName
                AltID = altIdMatch.CompleteMatch.Value
            |}
        | altIdMatch -> None)

ProjectNamesWithAltIDs
|> Render.AsCsv @"C:\Secret\ProjectDox\ProjectNamesWithAltIDs.csv"

let ProjectNamesWithoutAltIDs =
    ProjectNames
    |> List.choose (fun projectName ->
        match AltID().TypedMatch projectName with
        | altIdMatch when altIdMatch.Success -> None
        | altIdMatch -> Some {| ProjectName = projectName |})
ProjectNamesWithoutAltIDs
|> Render.AsCsv @"C:\Secret\ProjectDox\ProjectNamesWithoutAltIDs.csv"
// Real: 00:10:58.036, CPU: 00:21:07.843, GC gen0: 53764, gen1: 1369, gen2: 35
// let randomFile = files |> Array.randomChoice
