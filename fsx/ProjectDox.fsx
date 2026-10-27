#time on

fsi.PrintLength <- 1
// fsi.PrintSize <- Int32.MaxValue
fsi.ShowDeclarationValues <- true
#load @".paket/load/main.group.fsx"
#load @"C:\Secret\InforSecrets.fsx"
#load @"C:\Secret\EsriSecrets.fsx"
#load @"C:\Secret\ProjectDoxSecrets.fsx"
#load @"DataTierApplication.fsx"
open System
open System
open System.IO
open System.Diagnostics
open System.Collections
open System.Threading.Tasks
open System.Threading.Tasks
open System.Globalization
open System.IO
open DataTierApplication
open Microsoft.VisualBasic.FileIO
open FsExcel
open FSharp.Text.RegexProvider
open FSharp.Text.RegexExtensions
open Meziantou.Framework
open CsvHelper
open TextCopy
module FSharpLiteral = FSharp.Literals.Literal

open FSharp.Data
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open FSharp.Collections.ParallelSeq
open FSLogger

open Microsoft.SqlServer.Dac
open Microsoft.SqlServer.Dac.Model
open System.Collections

type Logger = 
    | Logger of FSLogger.Logger
    member this.logger = 
        match this with 
        | Logger logger -> logger

    /// Highest level.
    member this.Fatal = this.logger.F
    /// Higher than the warn level and lower than the fatal level.
    member this.Error = this.logger.E
    /// Higher than the notice level and lower than the error level.
    member this.Warn = this.logger.W
    /// Higher than the info level and lower than the warn level.
    member this.Notice = this.logger.N
    /// Higher than the debug level and lower than the notice level.
    member this.Info = this.logger.I
    /// Higher than the trace level and lower than the info level.
    member this.Debug = this.logger.D
    /// Lowest level.
    member this.Trace = this.logger.T

    member this.WithConsumer(consumer: FSLogger.LogEntry -> unit) =
        this.logger
        |> FSLogger.Logger.addConsumer consumer
        |> Logger

    member this.WithPath(path: string) =
        this.logger
        |> FSLogger.Logger.withPath "%s" path
        |> Logger
    member this.WithLogFile(filePath: string) =
        let fullPath = Path.GetFullPath filePath

        Directory.CreateDirectory(Path.GetDirectoryName fullPath)
        |> ignore
        this.WithConsumer(fun entry ->
            File.AppendAllText(
                fullPath,
                entry.ToString() + Environment.NewLine
            )
        )

let log =
    FSLogger.Logger.ColorConsole
    |> Logger
    |> fun logger -> logger.WithLogFile(sprintf "%s/log/%s.log" __SOURCE_DIRECTORY__ (DateTime.Now.ToString("yyy/MM/dd")))

type String with

    static member Clipboard = new Clipboard()
type Clipboard with 
    member this.clip (text:string) = this.SetText(text)
    member this.clip (lines:string array) = lines |> String.concat "\n" |> this.clip
type String with
    member this.clip = String.Clipboard.clip this
type Option<'Type> with
    static member ofNullOrWhiteSpace(value: 'Type) =
        if String.IsNullOrWhiteSpace(string value) then
            None
        else
            Some value
    static member tryNullOrWhiteSpace(maybeValue: 'Type option) =
        match maybeValue with
        | Some value when String.IsNullOrWhiteSpace(string value) -> None
        | None -> None
        | Some value -> Some value
let UFP = @"\\Doxfile-Prod\UFP"
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

let allFiles = 
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

type Project with
    member this._files = allFiles |> Array.filter (fun file -> file.ProjectID = this.ProjectID)
    member this._folders = folders |> Array.filter (fun folder -> folder.ProjectID = this.ProjectID)
type Folder with
    member this._project = projects |> Array.find (fun project -> this.ProjectID = project.ProjectID)
    member this._files = allFiles |> Array.filter (fun file -> file.FolderID = this.FolderID)

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
    allFiles
    |> Array.choose (fun file -> file.SourcePath)
    |> Array.distinct
    |> Array.sort
sourcePaths |> String.concat "\n" |> String.Clipboard.SetText

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

let filesWithoutPath = allFiles |> Array.filter (fun file -> file.SourcePath.IsNone)
let defaultCell (maybeValue: option<'T>) : string =
    match maybeValue with
    | Some value -> string value
    | None -> String.Empty
let fileList = allFiles |> Array.toList
let folderList = folders |> Array.toList
let projectList = projects |> Array.toList

// WHERE  P.ProjectTemplateID IN ('8','10','14','16','19','21','23','24','25','26','28','29','30','32','38','39','40','41','42')
type ProjectTemplate = 
        | Unknown = 0
        | Public_Works_Project_Template = 1
        | Project_Template = 2
        | MIS_Project_Template = 3
        | Sonitrol_Template = 4
        | SAO_HR_Template = 6
        | DSEM_Contractor_Files = 7
        | DSEM_Build_SFR = 8
        | DSEM_Site_Plan_Type_D = 10
        | PW_Subdivision = 11
        | PW_Roads = 12
        | PW_ENG_Project_Template = 13
        | DSEM_Env_NFI = 14
        | County_Attorney_Large_Format_Rev = 15
        | DSEM_Env_EIA = 16
        | DSEM_Env_EMP = 19
        | DSEM_Build_Comm = 21
        | DSEM_Site_Plan_ASAP_LP = 23
        | DSEM_FH_Policy_2'9 = 24
        | DSEM_LEX_Boundary_Settlement = 25
        | DSEM_LDV_Temp_Event_ConstStaging = 26
        | DSEM_Site_Plan_Type_A = 28
        | DSEM_Site_Plan_Type_C = 29
        | DSEM_Site_Plan_Type_B = 30
        | DSEM_LEC_Template = 31
        | DSEM_Driveway_Permit = 32
        | PW_ENG_Accela_ROW_Permit = 33
        | PW_ENG_ComFac_Provider_Registration = 34
        | PW_ENG_ComFac_ROW_Permit = 36
        | PW_ENG_ROW_Placement_License = 37
        | DSEM_PUV_RCC_LOZ = 38
        | DSEM_LDV_Board_of_Adjustment_and_Appeals = 39
        | DSEM_LDV_Development_Agreements = 40
        | DSEM_Build_Express = 41
        | DSEM_LPA_Template = 42

let includedProjectTemplates = set [
                                        ProjectTemplate.Public_Works_Project_Template
                                        ProjectTemplate.PW_Subdivision
                                        ProjectTemplate.PW_Roads
                                        ProjectTemplate.PW_ENG_Project_Template
                                        ProjectTemplate.PW_ENG_Accela_ROW_Permit
                                        ProjectTemplate.PW_ENG_ComFac_Provider_Registration
                                        ProjectTemplate.PW_ENG_ComFac_ROW_Permit
                                        ProjectTemplate.PW_ENG_ROW_Placement_License
]

let includedProjectTemplateIDs = includedProjectTemplates |> Set.map int
// and ( UPPER(P.Status) NOT IN ('VOID','WITHDRAWN') OR UPPER(P.StatusInfo) NOT LIKE '%WITHDRAWN%' OR UPPER(P.StatusInfo) NOT LIKE 'VOID' OR UPPER (P.[Name]) NOT LIKE '%VOID%' OR UPPER (P.[Name]) NOT LIKE '%WITHDRAWN%')
let VOID = "VOID"
let WITHDRAWN = "WITHDRAWN"
let excludedStatuses = Set [ VOID ; WITHDRAWN ]
// and FI.ProjectID IN (26725,24976,24912,24983,24754,23939)
// let includedProjectIDs = set [26725 ; 24976 ; 24912 ; 24983 ; 24754 ; 23939]
let IN (valueSet:Set<string>) (stringValue:string)  = valueSet.Contains(stringValue.ToUpperInvariant())
let NOT_IN (valueSet:Set<string>) (stringValue:string) = not(stringValue |> IN valueSet)
let LIKE (subString:string) (superString:string) = superString.ToUpperInvariant().Contains(subString.ToUpperInvariant())
let NOT_LIKE (excludedSubString:string) (superString:string) = not ( superString |> LIKE excludedSubString)

let files = 
    allFiles
    |> Array.filter (fun file -> 
        match file._project.ProjectTemplateID,  file._project.Status, file._project.StatusInfo, file._project.Name with
        | projectTemplateID, Some projectStatus, Some projectStatusInfo, projectName 
            when 
                includedProjectTemplateIDs.Contains(projectTemplateID)
                && (
                    projectStatus |> NOT_IN excludedStatuses
                    || projectStatusInfo |> NOT_LIKE WITHDRAWN
                    || projectStatusInfo |> NOT_LIKE VOID
                    || projectName |> NOT_LIKE WITHDRAWN
                    || projectName |> NOT_LIKE VOID
                
                    )
                    -> true
        | projectTemplateID,  None, Some projectStatusInfo, projectName 
            when 
                includedProjectTemplateIDs.Contains(projectTemplateID)
                && (
                    projectStatusInfo |> NOT_LIKE WITHDRAWN
                    || projectStatusInfo |> NOT_LIKE VOID
                    || projectName |> NOT_LIKE WITHDRAWN
                    || projectName |> NOT_LIKE VOID
                
                    )
                    -> true
        | projectTemplateID,  None, None, projectName 
            when 
                includedProjectTemplateIDs.Contains(projectTemplateID)
                && (
                    projectName |> NOT_LIKE WITHDRAWN
                    || projectName |> NOT_LIKE VOID
                
                    )
                    -> true
                
        | projectTemplateID,  projectStatus, projectStatusInfo, projectName when projectName.Contains("PW") -> true
        | projectTemplateID,  projectStatus, projectStatusInfo, projectName -> false

        )
        
// Real: 00:02:05.459, CPU: 00:01:51.312, GC gen0: 51, gen1: 51, gen2: 1

type PWENGAltId = Regex<"^[pP][wW]-[eE][nN][gG]\s+(?<Year>\d+)-(?<Id>\d+)">

type FileGroup =
    {
        name:string
        files : File array
    }
    static member ofProjectName (projectName:string) = 
        {
            name = projectName
            files = files |> Array.Parallel.filter (fun file -> file._project.Name = projectName)
        }

    member this.Meta = 
        this.files
        |> Array.filter (fun file -> 
            match file._project.ProjectTemplateID,  file._project.Status, file._project.StatusInfo, file._project.Name with
            | projectTemplateID,  Some projectStatus, Some projectStatusInfo, projectName 
                when 
                    includedProjectTemplateIDs.Contains(projectTemplateID)
                    && (
                        projectStatus |> NOT_IN excludedStatuses
                        || projectStatusInfo |> NOT_LIKE WITHDRAWN
                        || projectStatusInfo |> NOT_LIKE VOID
                        || projectName |> NOT_LIKE WITHDRAWN
                        || projectName |> NOT_LIKE VOID
                
                        )
                        -> true
            | projectTemplateID,  None, Some projectStatusInfo, projectName 
                when 
                    includedProjectTemplateIDs.Contains(projectTemplateID)
                    && (
                        projectStatusInfo |> NOT_LIKE WITHDRAWN
                        || projectStatusInfo |> NOT_LIKE VOID
                        || projectName |> NOT_LIKE WITHDRAWN
                        || projectName |> NOT_LIKE VOID
                
                        )
                        -> true
            | projectTemplateID,  None, None, projectName 
                when 
                    includedProjectTemplateIDs.Contains(projectTemplateID)
                    && (
                        projectName |> NOT_LIKE WITHDRAWN
                        || projectName |> NOT_LIKE VOID
                
                        )
                        -> true
                
            | projectTemplateID,  projectStatus, projectStatusInfo, projectName -> false

            )

        |> Array.Parallel.map (fun file -> {|
            ``File Path`` = file._filePath.Value
            ``Entity Id`` = file._entityId
            ``Document Group`` = "Historical"
            ``Document Type`` = "Document Migration"
            ``Entity Type`` = "CAP"
        |})
        |> Array.toList

    member this.Files =
        this.files
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
    member this.Folders = 
    
        this.files 
        |> Array.choose (fun file -> file._folder)
        |> Array.distinct
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
    member this.Projects = 
    
        this.files 
        |> Array.map (fun file -> file._project)
        |> Array.distinct
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
    member this.FileNames  = 
        this.files  
        |> Array.map (fun file -> {| FileName = file._stem |}) 
        |> Array.distinct 
        |> Array.sort 
        |> Array.toList
    member this.FolderNames  =
        this.files
        |> Array.choose (fun file -> 
            match file._folder with 
            | Some folder -> Some {| FolderName = folder.Name |}
            | None -> None
            )
        |> Array.distinct
        |> Array.sort
        |> Array.toList
    member this.ProjectNames =
        this.files
        |> Array.map (fun file -> {| ProjectName = file._project.Name|})
        |> Array.distinct
        |> Array.sort
        |> Array.toList
    member this.OneDriveDirectory = Directory.CreateDirectory $@"C:\Users\CollierB\OneDrive\OneDrive - Leon County Government\DIGEPLAN PUBLIC WORKS PROJECT\Brandon's Shared Files\{this.name}"
    member this.MetaFile = FileInfo $"{this.OneDriveDirectory.FullName}\Meta.xlsx"
    member this.WriteXlsx(fileStem:string) = 
        fun tableItems ->
            [ Worksheet fileStem; FsExcel.Table [ TableName fileStem; TableItems tableItems ]; AutoFit All ]
            |> Render.AsFile $"{this.OneDriveDirectory.FullName}\{fileStem}.xlsx"
    member this.WriteCsv(fileStem:string) = 
        fun (records : seq<'Type>) ->
            use csv = new CsvWriter(new StreamWriter($"{this.OneDriveDirectory.FullName}\{fileStem}.csv"), CultureInfo.InvariantCulture)
            csv.WriteRecords records
    member this.sourceDirectories = this.files |> Array.choose (fun file -> file.PublishPath) |> Array.map DirectoryInfo

    member this.copyDirectories( ?onFileReported: unit -> unit, ?onDirectoryCompleted: unit -> unit ) =
        this.sourceDirectories
        |> Array.map (fun sourceDirectory ->
            let destinationDirectory =
                Path.Combine(
                    $@"D:\unc\{this.name}",
                    sourceDirectory.FullName[2..]
                )
            try
                try
                    let startInfo = ProcessStartInfo("robocopy.exe")

                    startInfo.ArgumentList.Add(sourceDirectory.FullName)
                    startInfo.ArgumentList.Add(destinationDirectory)

                    for argument in
                        [|
                            "/E"
                            "/MT:16"
                            "/R:1"
                            "/W:1"
                            "/XC"
                            "/XN"
                            "/XO"
                            "/NP"
                            "/NDL"
                            "/NJH"
                            "/NJS"
                        |] do
                        startInfo.ArgumentList.Add(argument)
                    startInfo.RedirectStandardOutput <- true
                    startInfo.UseShellExecute <- false
                    startInfo.CreateNoWindow <- true

                    use process_ = Process.Start(startInfo)

                    let mutable line = process_.StandardOutput.ReadLine()

                    while not (isNull line) do
                        if System.Text.RegularExpressions.Regex.IsMatch(
                            line,
                            @"^\s*New File\s+",
                            System.Text.RegularExpressions.RegexOptions.IgnoreCase
                        ) then
                            onFileReported
                            |> Option.iter (fun callback -> callback())

                        line <- process_.StandardOutput.ReadLine()

                    process_.WaitForExit()

                    if process_.ExitCode >= 8 then
                        failwithf "Robocopy failed with exit code %d" process_.ExitCode
                    // log.WithPath(destinationDirectory).Trace $"{sourceDirectory.FullName} copied to {destinationDirectory}"

                    Ok sourceDirectory

                with err ->
                    log.WithPath(sourceDirectory.FullName).Error err.Message
                    Error (sourceDirectory, err)
            finally
                onDirectoryCompleted
                |> Option.iter (fun callback -> callback())

        )

    (*
    member this.copyDirectories() = 
        this.sourceDirectories |> Array.map (fun sourceDirectory ->  
            let destinationDirectory = Path.Combine($@"D:\unc\{this.name}", sourceDirectory.FullName[2..] )
            try
                FileSystem.CopyDirectory(sourceDirectory.FullName, destinationDirectory, false)
                log.WithPath(destinationDirectory).Trace $"{sourceDirectory.FullName} copied to {destinationDirectory}"
                Ok sourceDirectory
            with 
            | err -> 
                let errors = 
                    err.Data |> Seq.cast<DictionaryEntry>
                    |> Seq.map (fun dictionaryEntry -> new FileInfo(string dictionaryEntry.Key), string dictionaryEntry.Value)  |> Seq.toArray
                    |> Seq.filter (fun (file, fileError) ->  not (fileError.EndsWith("already exists.")))
                    |> Seq.toArray
                if errors.Length > 0 then 
                    log.WithPath(sourceDirectory.FullName).Error err.Message
                    Error (sourceDirectory,err)
                else 
                    log.WithPath(destinationDirectory).Trace $"{sourceDirectory.FullName} already exists at {destinationDirectory}"
                    Ok sourceDirectory
                
        )
    *)

let roadProjects = 
    set [
            "PW-Intersections"
        ]
let subdivisionProjects =
    set [
        "PW ASHFORD GLEN"
        "PW-Paupers Cemetery"
    ]
let bridgeProjects =
    set [
        "PW-BRIDGES"
    ]

let engFileGroup  = 

    let name = "PW-ENG"
    {
        name = name
        files = files |> Array.Parallel.filter (fun file -> PWENGAltId.TypedIsMatch file._project.Name )
    }
let misFileGroup  = 

    let name = "PW-MIS"
    {
        name = name
        files = files |> Array.Parallel.filter (fun file -> file._project.Name = "Roberts - PW-MIS" )
    }

let roadFileGroup = 

    let name = "Roads"
    {
        name = name
        files = files |> Array.Parallel.filter (fun file -> roadProjects.Contains file._project.Name)
    }
let subdivisionFileGroup = 
    let name = "Subdivisions"
    {
        name = name
        files = files |> Array.Parallel.filter (fun file -> subdivisionProjects.Contains file._project.Name)
    }
let bridgeFileGroup = 
    let name = "Bridges"
    {
        name = name
        files = files |> Array.Parallel.filter (fun file -> bridgeProjects.Contains file._project.Name)
    }

let projectNames = 
    files
    |> Array.Parallel.map (fun file -> file._project.Name)
    |> Array.distinct
    |> Array.sort
let folderNames = 
    files
    |> Array.Parallel.choose (fun file -> 
        match file._folder with 
        | Some folder -> folder.Name
        | None -> None
        )
    |> Array.distinct
    |> Array.sort
let pathNames = 
    files
    |> Array.Parallel.choose (fun file -> 
        match file._folder with 
        | Some folder when folder.Name.IsSome -> Some $"{file._project.Name}/{folder.Name.Value}"
        | _ -> None
        )
    |> Array.distinct
    |> Array.sort
(*
projectNames |> String.Clipboard.clip
folderNames |> String.Clipboard.clip
pathNames  |> String.Clipboard.clip
*)
// TODO move these serializers to FileGroup

[|
    engFileGroup
    misFileGroup
    roadFileGroup
    subdivisionFileGroup
    bridgeFileGroup
|]
|> Array.iter (fun fileGroup -> 
    fileGroup.WriteXlsx "Meta" fileGroup.Meta
    fileGroup.WriteCsv "Files" fileGroup.Files
    fileGroup.WriteCsv "FileNames" fileGroup.FileNames
    fileGroup.WriteCsv "Folders" fileGroup.Folders
    fileGroup.WriteCsv "Projects" fileGroup.Projects
    fileGroup.WriteCsv "ProjectNames" fileGroup.ProjectNames
    )

let groups =
    [|
        misFileGroup
        subdivisionFileGroup
        bridgeFileGroup
        roadFileGroup
        engFileGroup
    |]

let totalDirectories =
    groups
    |> Array.sumBy (fun group -> group.sourceDirectories.Length)

let mutable completedDirectories = 0
let progressLock = obj()

let stopwatch = Stopwatch.StartNew()

let reportProgress () =
    lock progressLock (fun () ->
        completedDirectories <- completedDirectories + 1

        let elapsed = stopwatch.Elapsed

        let remaining =
            totalDirectories - completedDirectories

        let percentage =
            if totalDirectories = 0 then 100.0
            else
                100.0
                * float completedDirectories
                / float totalDirectories

        let eta =
            if completedDirectories = 0 then
                "Calculating"
            else
                TimeSpan.FromSeconds(
                    elapsed.TotalSeconds
                    * float remaining
                    / float completedDirectories
                ).ToString(@"dd\.hh\:mm\:ss")
        let elapsedText = elapsed.ToString(@"dd\.hh\:mm\:ss")

        Console.Write(
            sprintf "\rProgress: %d/%d (%.1f%%) | Elapsed: %s | ETA: %s    "
                completedDirectories
                totalDirectories
                percentage
                elapsedText
                eta
        )

    )

let copyTask =
    // Task.Run(fun () ->
        try
            groups
            |> Array.Parallel.map (fun fileGroup ->
                fileGroup.copyDirectories(
                    onDirectoryCompleted = reportProgress
                )
            )
        finally
            stopwatch.Stop()
            lock progressLock (fun () ->
                Console.WriteLine()
            )
    // )
(*
Progress: 3599/15079 (23.9%) | Elapsed: 00.00:31:52 | ETA: 00.01:41:41    [10/21/2026 12:27:09 AM -04:00|Error]//DoxFile-Prod/UFP/848/22562/W Tharpe 60% Final PDF.7z:Robocopy failed with exit code 16
Progress: 6473/15079 (42.9%) | Elapsed: 00.01:47:16 | ETA: 00.02:22:37    [10/21/2026 1:42:32 AM -04:00|Error]//DoxFile-Prod/UFP/1210/28100/ANA-CIVIL 3D.ctb:Robocopy failed with exit code 16
Progress: 6474/15079 (42.9%) | Elapsed: 00.01:47:16 | ETA: 00.02:22:35    [10/21/2026 1:42:33 AM -04:00|Error]//DoxFile-Prod/UFP/1210/28100/ANA-CIVIL 3D_5-7-09.ctb:Robocopy failed with exit code 16
Progress: 7263/15079 (48.2%) | Elapsed: 00.02:19:58 | ETA: 00.02:30:37    [10/21/2026 2:15:14 AM -04:00|Error]//DoxFile-Prod/UFP/610/34031/BrownJoe-Export.pst:Robocopy failed with exit code 16
Progress: 7264/15079 (48.2%) | Elapsed: 00.02:19:58 | ETA: 00.02:30:35    [10/21/2026 2:15:15 AM -04:00|Error]//DoxFile-Prod/UFP/610/34031/BurkeK-Export.pst:Robocopy failed with exit code 16
Progress: 7265/15079 (48.2%) | Elapsed: 00.02:19:58 | ETA: 00.02:30:33    [10/21/2026 2:15:15 AM -04:00|Error]//DoxFile-Prod/UFP/610/34031/McGhinM-Export.pst:Robocopy failed with exit code 16
Progress: 7266/15079 (48.2%) | Elapsed: 00.02:19:59 | ETA: 00.02:30:31    [10/21/2026 2:15:15 AM -04:00|Error]//DoxFile-Prod/UFP/610/34031/ParkT-Export.pst:Robocopy failed with exit code 16
Progress: 7267/15079 (48.2%) | Elapsed: 00.02:19:59 | ETA: 00.02:30:29    [10/21/2026 2:15:16 AM -04:00|Error]//DoxFile-Prod/UFP/610/34031/WuC-Export.pst:Robocopy failed with exit code 16
Progress: 11692/15079 (77.5%) | Elapsed: 00.06:25:43 | ETA: 00.01:51:44    [10/21/2026 6:21:00 AM -04:00|Error]//DoxFile-Prod/UFP/4378/88384/LAKEVIEW DRIVE-S2-S1-.ipd:Robocopy failed with exit code 16
Progress: 11693/15079 (77.5%) | Elapsed: 00.06:25:43 | ETA: 00.01:51:41    [10/21/2026 6:21:00 AM -04:00|Error]//DoxFile-Prod/UFP/4378/88384/LAKEVIEW DRIVE-S2-S1-.mpg:Robocopy failed with exit code 16
Progress: 11711/15079 (77.7%) | Elapsed: 00.06:26:00 | ETA: 00.01:51:00    [10/21/2026 6:21:17 AM -04:00|Error]//DoxFile-Prod/UFP/4378/88384/LAKEVIEW DRIVE-S2-S3-.ipd:Robocopy failed with exit code 16
Progress: 11712/15079 (77.7%) | Elapsed: 00.06:26:00 | ETA: 00.01:50:58    [10/21/2026 6:21:17 AM -04:00|Error]//DoxFile-Prod/UFP/4378/88384/LAKEVIEW DRIVE-S2-S3-.mpg:Robocopy failed with exit code 16
Progress: 11994/15079 (79.5%) | Elapsed: 00.06:34:39 | ETA: 00.01:41:30    [10/21/2026 6:29:56 AM -04:00|Error]//DoxFile-Prod/UFP/4378/91718/Architectural Imperial.dwt:Robocopy failed with exit code 16
Progress: 12016/15079 (79.7%) | Elapsed: 00.06:35:02 | ETA: 00.01:40:41    [10/21/2026 6:30:18 AM -04:00|Error]//DoxFile-Prod/UFP/4378/91716/100-Percent.dst:Robocopy failed with exit code 16
Progress: 14070/15079 (93.3%) | Elapsed: 00.08:49:40 | ETA: 00.00:37:59    [10/21/2026 8:44:57 AM -04:00|Error]//DoxFile-Prod/UFP/7888/130171/20180323_100924.mp4:Robocopy failed with exit code 16
Progress: 15079/15079 (100.0%) | Elapsed: 00.11:00:58 | ETA: 00.00:00:00    
Real: 11:00:58.951, CPU: 00:01:02.062, GC gen0: 28, gen1: 19, gen2: 0
val stopwatch: Stopwatch
val reportProgress: unit -> unit
val copyTask: Result<DirectoryInfo,(DirectoryInfo * exn)> array array
*)
(*

let copyTask =
    Task.Run (fun () ->  
    [|
        misFileGroup
        subdivisionFileGroup
        bridgeFileGroup
        roadFileGroup
        engFileGroup
    |]
    |> Array.sortBy (fun fileGroup -> fileGroup.files.Length )
    |> Array.map (fun fileGroup -> fileGroup.copyDirectories()))

*)
// copyTask

let failedCopies =
    copyTask
    |> Array.collect id
    |> Array.choose (function
        | Error (sourceDirectory, err) ->
            Some (sourceDirectory, err)
        | Ok _ ->
            None
    )
let failedDirectories = 
    failedCopies
    |> Array.map (fun (directory, err) -> directory)

(*

failedDirectories
|> Array.map (fun directory -> directory.FullName)
|> String.Clipboard.clip
\\DoxFile-Prod\UFP\848\22562\W Tharpe 60% Final PDF.7z
\\DoxFile-Prod\UFP\1210\28100\ANA-CIVIL 3D.ctb
\\DoxFile-Prod\UFP\1210\28100\ANA-CIVIL 3D_5-7-09.ctb
\\DoxFile-Prod\UFP\610\34031\BrownJoe-Export.pst
\\DoxFile-Prod\UFP\610\34031\BurkeK-Export.pst
\\DoxFile-Prod\UFP\610\34031\McGhinM-Export.pst
\\DoxFile-Prod\UFP\610\34031\ParkT-Export.pst
\\DoxFile-Prod\UFP\610\34031\WuC-Export.pst
\\DoxFile-Prod\UFP\4378\88384\LAKEVIEW DRIVE-S2-S1-.ipd
\\DoxFile-Prod\UFP\4378\88384\LAKEVIEW DRIVE-S2-S1-.mpg
\\DoxFile-Prod\UFP\4378\88384\LAKEVIEW DRIVE-S2-S3-.ipd
\\DoxFile-Prod\UFP\4378\88384\LAKEVIEW DRIVE-S2-S3-.mpg
\\DoxFile-Prod\UFP\4378\91718\Architectural Imperial.dwt
\\DoxFile-Prod\UFP\4378\91716\100-Percent.dst
\\DoxFile-Prod\UFP\7888\130171\20180323_100924.mp4

*)
let missingDirectories = 
    failedDirectories
    |> Array.filter (fun directory -> not directory.Exists)
(*

missingDirectories
|> Array.map (fun directory -> directory.FullName)
|> String.Clipboard.clip
\\DoxFile-Prod\UFP\848\22562\W Tharpe 60% Final PDF.7z
\\DoxFile-Prod\UFP\1210\28100\ANA-CIVIL 3D.ctb
\\DoxFile-Prod\UFP\1210\28100\ANA-CIVIL 3D_5-7-09.ctb
\\DoxFile-Prod\UFP\610\34031\BrownJoe-Export.pst
\\DoxFile-Prod\UFP\610\34031\BurkeK-Export.pst
\\DoxFile-Prod\UFP\610\34031\McGhinM-Export.pst
\\DoxFile-Prod\UFP\610\34031\ParkT-Export.pst
\\DoxFile-Prod\UFP\610\34031\WuC-Export.pst
\\DoxFile-Prod\UFP\4378\88384\LAKEVIEW DRIVE-S2-S1-.ipd
\\DoxFile-Prod\UFP\4378\88384\LAKEVIEW DRIVE-S2-S1-.mpg
\\DoxFile-Prod\UFP\4378\88384\LAKEVIEW DRIVE-S2-S3-.ipd
\\DoxFile-Prod\UFP\4378\88384\LAKEVIEW DRIVE-S2-S3-.mpg
\\DoxFile-Prod\UFP\4378\91718\Architectural Imperial.dwt
\\DoxFile-Prod\UFP\4378\91716\100-Percent.dst
\\DoxFile-Prod\UFP\7888\130171\20180323_100924.mp4
*)
let lastFile = subdivisionFileGroup.files |> Array.find (fun file -> 
    match  file.SourcePath with 
    | Some sourcePath  -> sourcePath.Contains @"13\155\848\13459\S-22"
    | _ -> false
    )

let filesToCopy = 
    [|
        misFileGroup
        subdivisionFileGroup
        bridgeFileGroup
        roadFileGroup
        // engFileGroup
    |]
    |> Array.sortBy (fun fileGroup -> fileGroup.files.Length )
    |> Array.collect (fun fileGroup -> fileGroup.files)
let lastIndex = 
    filesToCopy
    |> Array.findIndex (fun file ->  

        match  file.SourcePath with 
        | Some sourcePath  -> sourcePath.Contains @"12\115\19990106-BIR"
        | _ -> false
        )
$"{lastIndex} of {filesToCopy.Length}"
let remaining = filesToCopy.Length - lastIndex
(double remaining * 2.0)  / 60.0

let engineerCopyTask =
    Task.Run (fun () ->  
    [|
        // misFileGroup
        // subdivisionFileGroup
        // bridgeFileGroup
        // roadFileGroup
        engFileGroup
    |]
    |> Array.sortBy (fun fileGroup -> fileGroup.files.Length )
    |> Array.map (fun fileGroup -> fileGroup.copyDirectories()    ) )
let directoryErrors (directoryResults: Result<DirectoryInfo,DirectoryInfo * exn> array) = 
    directoryResults
    |> Array.choose (fun directoryResult -> 
        match directoryResult with 
        | Error(directory,directoryError) -> Some(directory,directoryError)
        | _ -> None)

(*
[<Literal>]
let AltIDRegex = """(?<AltID>[A-Za-z]{2-3}\d+)"""
type AltID = Regex<AltIDRegex>
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
*)

