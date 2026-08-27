# time on
fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false

open System 
open System.IO

open System.Xml
open System.Xml.Linq
open System.Xml.XPath
open System.Xml.Serialization
open System.Xml.Schema

#r "nuget: Dubzer.WhatwgUrl"
open Dubzer.WhatwgUrl


#r "nuget: PosInformatique.Foundations.EmailAddresses"
open PosInformatique.Foundations.EmailAddresses


#r "nuget: libphonenumber-csharp"
open PhoneNumbers

#r "nuget: PosInformatique.Foundations.EmailAddresses"
open PosInformatique.Foundations.EmailAddresses

#r "nuget: FSharp.Compiler.Service, 43.10.102"
open FSharp.Compiler

#r "nuget: FSharp.Literals, 2.2.15"
open FSharp.Literals

#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: FSharp.XExtensions"
open FSharp.XExtensions
#r "nuget: LitXml"
open LitXml


#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq

#r "nuget: Fabulous.AST"

open Fabulous.AST
open Fantomas.Core


#r "nuget: Humanizer.Core"
open Humanizer
#r "nuget: CaseConverter"
open CaseConverter



#r "nuget: Fli"
open Fli


#r "nuget: TextCopy"
open TextCopy


let phoneNumberUtil = PhoneNumberUtil.GetInstance() 
let number = phoneNumberUtil.Parse("\u002B1 850-606-5534", "US")











let clipboard = new Clipboard()
let clip (text:string) = clipboard.SetText text



type Binder = 
    | TypeBinder of identifier:string
    | CaseBinder of identifier:string
    | ModuleBinder of identifier:string
    | NamespaceBinder of identifier:string
    | VariableBinder of identifier:string
    member this.identifier = 
        match this with 
        | TypeBinder identifier -> identifier
        | CaseBinder identifier -> identifier
        | ModuleBinder identifier -> identifier
        | NamespaceBinder identifier -> identifier
        | VariableBinder identifier -> identifier
    static member BackTickExclusions = 
        [|
            '.'
            '+'
            '$'
            '&'
            '['
            ']'
            '/'
            '\\'
            '*'
            '\"'
            '`'
        |]
    static member IdentKeywords = 
        set [
            "abstract"
            "and"
            "as"
            "assert"
            "base"
            "begin"
            "class"
            "const"
            "default"
            "delegate"
            "do"
            "done"
            "downcast"
            "downto"
            "elif"
            "else"
            "end"
            "exception"
            "extern"
            "false"
            "finally"
            "fixed"
            "for"
            "fun"
            "function"
            "global"
            "if"
            "in"
            "inherit"
            "inline"
            "interface"
            "internal"
            "lazy"
            "let"
            "match"
            "member"
            "module"
            "mutable"
            "namespace"
            "new"
            "null"
            "of"
            "open"
            "or"
            "override"
            "private"
            "public"
            "rec"
            "return"
            "sig"
            "static"
            "struct"
            "then"
            "to"
            "true"
            "try"
            "type"
            "upcast"
            "use"
            "val"
            "void"
            "when"
            "while"
            "with"
            "yield"
            
        ]
    static member OCamlKeywords = 
            set [

              "asr"
              "land"
              "lor"
              "lsl"
              "lsr"
              "lxor"
              "mod"
              "sig"

               ]
    static member ReservedKeywords = 
    
        set [

              "break"
              "checked"
              "component"
              "const"
              "constraint"
              "continue"
              "event"
              "external"
              "include"
              "mixin"
              "parallel"
              "process"
              "protected"
              "pure"
              "sealed"
              "tailcall"
              "trait"
              "virtual"

               ]
    static member KeywordNames = Binder.IdentKeywords + Binder.OCamlKeywords + Binder.ReservedKeywords

    member this.Contains(character:char) = this.identifier.Contains(character)
    member this.isBackTickRestricted =
        match this with 
        | TypeBinder identifier -> true
        | CaseBinder identifier -> true
        | ModuleBinder identifier -> true
        | NamespaceBinder identifier -> true
        | VariableBinder identifier -> false
    static member NormalizeIdentifier (is_restricted:bool) (identifier: string)  =
        match identifier with
        | _ when identifier.Contains(' ') ->
            Converters.ReplaceWhitespace(identifier,  "_")
            |> Binder.NormalizeIdentifier is_restricted
        | _ when identifier.Contains('-') ->
            identifier.Replace("-", "_")
            |> Binder.NormalizeIdentifier is_restricted
        | _ when not (Syntax.PrettyNaming.IsIdentifierFirstCharacter identifier[0]) ->
            "_" + identifier |> Binder.NormalizeIdentifier is_restricted
        | _ when Binder.KeywordNames.Contains(identifier) -> identifier + "_" |> Binder.NormalizeIdentifier is_restricted
        | _ when Syntax.PrettyNaming.DoesIdentifierNeedBackticks identifier && is_restricted  ->
            let backtickableIdentifier = identifier.Replace(Binder.BackTickExclusions,"")
            Syntax.PrettyNaming.NormalizeIdentifierBackticks backtickableIdentifier |> Binder.NormalizeIdentifier is_restricted
        | _ when Syntax.PrettyNaming.DoesIdentifierNeedBackticks identifier   ->
            Syntax.PrettyNaming.NormalizeIdentifierBackticks identifier |> Binder.NormalizeIdentifier is_restricted
        | _ -> identifier
    member this.binding = Binder.NormalizeIdentifier this.isBackTickRestricted this.identifier





















module XMLSchema = 
    let namespace_name =  "http://www.w3.org/2001/XMLSchema"
    let xnamespace = XNamespace.Get namespace_name
    let qualifiedName (localName:string) = XmlQualifiedName(localName, namespace_name)
    let schemaSet = XmlSchemaSet()
module Folder = 
  let departments = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds\departments" 
  let incidents = Directory.CreateDirectory @"D:\Artifact\Company\SolarWinds\incidents" 

module Document = 
  module Incidents = 
    [<Literal>]
    let jsonFilePath = @"D:\Artifact\Company\SolarWinds\incidents\incidents_000040.json"
    type Provider = JsonProvider<jsonFilePath>
  module Incident = 
    [<Literal>]
    let xsdFilePath = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ServiceDesk\SolarWinds\Incident.xsd"
    let xsd = XmlProvider<xsdFilePath>.Load xsdFilePath
    let xmlSchema = 
      use reader = XmlReader.Create(xsdFilePath)
      XmlSchema.Read(reader, fun sender e -> printfn "Validation error: %s" e.Message)
      |> XMLSchema.schemaSet.Add
    [<Literal>]
    let jsonFilePath = @"D:\Artifact\Company\SolarWinds\custom_views\incidents.json"
    let columns = JsonProvider<jsonFilePath>.Load jsonFilePath

    [<Literal>]
    let jsonSchemaFilePath = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ServiceDesk\SolarWinds\incident.schema.json"
    let jsonSchema = (JsonProvider<jsonSchemaFilePath>.Load jsonSchemaFilePath).Properties.Data.Items

  module Departments = 
    [<Literal>]
    let jsonFilePath = @"D:\Artifact\Company\SolarWinds\departments\departments_000001.json"
    type Provider = JsonProvider<jsonFilePath>
  module Site = 
    [<Literal>]
    let jsonFilePath = @"D:\Artifact\Company\SolarWinds\sites.json"
    let json = JsonProvider<jsonFilePath>.Load jsonFilePath














let incidents = 
    Folder.incidents.GetFiles()
    |> Array.Parallel.collect (fun jsonFile -> 
    let json = Document.Incidents.Provider.Load jsonFile.FullName
    json 
    )





















type DepartmentRecord = 
  {
    name:string
    id:int
  }

let departments = 
    Folder.departments.GetFiles()
    |> Array.filter (fun file -> file.Name.EndsWith(".json"))
    |> Array.collect (fun jsonFile -> 
      let json = Document.Departments.Provider.Load jsonFile.FullName
      json 
      |> Array.map (fun department -> { name = department.Name ; id = department.Id})
      )
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ServiceDesk\SolarWinds\test.fsx"
open Test


type State with 
    static member fromString (stateString:string) = 
        match stateString with 
        | "New" -> State.New
        | "Pending Assignment" -> State.``Pending Assignment``
        | "In Process" -> State.``In Process``
        | "On Hold" -> State.``On Hold``
        | "Awaiting Approval" -> State.``Awaiting Approval``
        | "Awaiting Asset Tag" -> State.``Awaiting Asset Tag``
        | "Awaiting Delivery" -> State.``Awaiting Delivery``
        | "Awaiting Effective Date" -> State.``Awaiting Effective Date``
        | "Awaiting Input - User" -> State.``Awaiting Input - User``
        | "Awaiting Input - Tech" -> State.``Awaiting Input - Tech``
        | "Awaiting Input - Vendor" -> State.``Awaiting Input - Vendor``
        | "Awaiting Quote" -> State.``Awaiting Quote``
        | "Canceled by Requester" -> State.``Canceled by Requester``
        | "Pending HR Actions" -> State.``Pending HR Actions``
        | "Project - Proactive" -> State.``Project - Proactive``
        | "Purchase in Process" -> State.``Purchase in Process``
        | "Research Required" -> State.``Research Required``
        | "Scheduled-Check Due Date" -> State.``Scheduled-Check Due Date``
        | "Under Review" -> State.``Under Review``
        | "Assigned" -> State.Assigned
        | "Resolved" -> State.Resolved

type Priority with 
    static member fromInt (priorityInt:int) = 
        match priorityInt with 
        | 4 ->  Priority.Low 
        | 3 ->  Priority.Medium 
        | 2 ->  Priority.High 
        | 1 ->  Priority.Critical 
        | _ ->  Priority.None 
(*

let incidents = 
  Folder.incidents.GetFiles()
  |> Array.filter (fun file -> file.Name.EndsWith(".json"))
  |> Array.collect (fun jsonFile -> 

    let json = Document.Incidents.Provider.Load jsonFile.FullName
    json
    |> Array.map (fun incident -> 
    
    { 
      
      //: int
      id = incident.Id
      //: int
      number = incident.Number
      //: string
      name = incident.Name
      //: HtmlNode
      description = incident.Description |> HtmlNode.Parse |> List.exactlyOne
      //: string
      description_no_html = incident.DescriptionNoHtml
      //: State
      state = incident.State |> State.fromString
      //: Priority
      priority = incident.Priority |> int |> Priority.fromInt
      //: Category
      category = 
        {

            //: int
            id  = incident.Category.Id
            //: string
            name  = incident.Category.Name
            //: string option
            default_tags  = None
            //: int option
            parent_id  =  None

            //: bool
            deleted  = incident.Category.Deleted
            //: int 
            default_assignee_id  = incident.Category.DefaultAssigneeId
        }
      //: Category
      subcategory = 
        match incident.Subcategory with 
        | Some subcategory  -> 
      
              Some {

                  //: int
                  id  = subcategory.Id
                  //: string
                  name  = subcategory.Name
                  //: string option
                  default_tags  = None
                  //: int option
                  parent_id  = Some subcategory.ParentId
                  //: bool
                  deleted  = subcategory.Deleted
                  //: int 
                  default_assignee_id  = subcategory.DefaultAssigneeId
              }
        | None -> None
      //: Assignee
      assignee = 
        { 
          
          //: int
          group_id  = incident.Assignee.GroupId
          //: bool
          is_user  = incident.Assignee.IsUser
          //: int
          id  = incident.Assignee.Id
          //: string
          name  = incident.Assignee.Name
          //: EmailAddress
          email  = EmailAddress.Parse incident.Assignee.Email
          //: Avatar
          avatar  = 
              match incident.Assignee.Avatar.Type with 
              | "initials" -> { initials = incident.Assignee.Avatar.Initials.Value ; color = incident.Assignee.Avatar.Color.Value } |> AvatarInitials
              | "image" -> 
                            { 
                              
                              //: string
                              image_class  = incident.Assignee.Avatar.ImageClass
                              //: string option
                              sso_image_class  = None
                              //: DomUrl 
                              avatar_url  = DomUrl incident.Assignee.Avatar.AvatarUrl.Value
                              
                            } |> AvatarImage
          //: Assignee option 
          reports_to  = 

              Some { 
          
                //: int
                group_id  = incident.Assignee.ReportsTo.GroupId
                //: bool
                is_user  = incident.Assignee.ReportsTo.IsUser
                //: int
                id  = incident.Assignee.ReportsTo.Id
                //: string
                name  = incident.Assignee.ReportsTo.Name
                //: EmailAddress
                email  = EmailAddress.Parse incident.Assignee.ReportsTo.Email
                //: Avatar
                avatar  = 
                    match incident.Assignee.ReportsTo.Avatar.Type with 
                    | "initials" -> { initials = incident.Assignee.ReportsTo.Avatar.Initials.Value ; color = incident.Assignee.ReportsTo.Avatar.Color.Value } |> AvatarInitials
                    | "image" -> 
                                  { 
                              
                                    //: string
                                    image_class  = incident.Assignee.ReportsTo.Avatar.ImageClass
                                    //: string option
                                    sso_image_class  = None
                                    //: DomUrl 
                                    avatar_url  = DomUrl incident.Assignee.ReportsTo.Avatar.AvatarUrl.Value
                              
                                  } |> AvatarImage
                //: Assignee option 
                reports_to  = None
          
                }
          
          
          }
      //: User
      requester = 
            {

                // : int
                id = incident.Requester.Value.Id
                // : int
                account_id = incident.Requester.Value.AccountId
                // : int
                user_id = incident.Requester.Value.UserId
                // : EmailAddress
                email = incident.Requester.Value.Email
                // : string
                name = incident.Requester.Value.Name
                // : bool
                disabled = incident.Requester.Value.Disabled
                // : int option
                site_id = incident.Requester.Value.SiteId
                // : Site option
                site = incident.Requester.Value.Site
                // : int
                department_id = incident.Requester.Value.DepartmentId
                // : Department
                department = incident.Requester.Value.Department
                // : bool
                has_gravatar = incident.Requester.Value.HasGravatar
                // : DateTime
                customer_satisfaction_survey_time = incident.Requester.Value.CustomerSatisfactionSurveyTime
                // : Avatar 
                avatar = incident.Requester.Value.Avatar
            
            }
      
          incident.Requester
      //: DateTime
      created_at = incident.Created_at
      //: DateTime
      updated_at = incident.Updated_at
      //: DateTime option
      due_at = incident.Due_at
      //: string array
      sla_violations = incident.Sla_violations
      //: int
      number_of_comments = incident.Number_of_comments
      //: bool
      user_saw_all_comments = incident.User_saw_all_comments
      //: bool
      is_service_request = incident.Is_service_request
      //: User
      created_by = incident.Created_by
      //: Employee
      resolved_by = incident.Resolved_by
      //: string
      resolution_description = incident.Resolution_description
      //: ResolutionCode
      resolution_code = incident.Resolution_code
      //: Assignee option
      group_assignee = incident.Group_assignee
      //: DateTime
      customer_satisfaction_survey_sent_at = incident.Customer_satisfaction_survey_sent_at
      //: DateTime option
      customer_satisfaction_survey_completed_at = incident.Customer_satisfaction_survey_completed_at
      //: string option
      custom = incident.Custom
      //: DomUrl
      href = incident.Href
      //: DomUrl
      href_account_domain = incident.Href_account_domain
      //: Site option
      site = incident.Site
      //: Department
      department = incident.Department
      //: EmailAddress
      cc = incident.Cc
      //: unit array
      custom_fields_values = incident.Custom_fields_values
      //: string
      origin = incident.Origin
      //: unit array
      releases = incident.Releases
      //: unit array
      problems = incident.Problems
      //: unit array
      problem = incident.Problem
      //: IncidentReference array
      incidents = incident.Incidents
      //: unit array
      changes = incident.Changes
      //: unit array
      tasks = incident.Tasks
      //: unit array
      time_tracks = incident.Time_tracks
      //: unit array
      solutions = incident.Solutions
      //: unit array
      assets = incident.Assets
      //: unit array
      mobiles = incident.Mobiles
      //: unit array
      other_assets = incident.Other_assets
      //: unit array
      configuration_items = incident.Configuration_items
      //: unit array
      discovery_hardwares = incident.Discovery_hardwares
      //: unit array 
      purchase_orders = incident.Purchase_orders
      
      }
          
          )
    
    
    )


*)
(*

Document.Incident.columns
|> Array.map (fun column -> column.Type)
|> Array.distinct
|> Array.sort
|> Array.iter (fun columnType -> printfn "%s" columnType)

*)


let requiredColumns = 
  set [
      "id"
      "number"
      "name"
      "description"
      "description_no_html"
      "state"
      "priority"
      "category"
      "subcategory"
      "assignee"
      "requester"
      "created_at"
      "updated_at"
      "sla_violations"
      "number_of_comments"
      "user_saw_all_comments"
      "is_service_request"
      "created_by"
      "resolved_by"
      "resolution_description"
      "resolution_code"
      "href"
      "href_account_domain"
      "department"
      "cc"
      "custom_fields_values"
      "origin"
      "releases"
      "problems"
      "problem"
      "incidents"
      "changes"
      "tasks"
      "time_tracks"
      "solutions"
      "assets"
      "mobiles"
      "other_assets"
      "configuration_items"
      "discovery_hardwares"
      "purchase_orders"

  ]




let states = 
  [|
    "New"
    "Pending Assignment"
    "In Process"
    "On Hold"
    "Awaiting Approval"
    "Awaiting Asset Tag"
    "Awaiting Delivery"
    "Awaiting Effective Date"
    "Awaiting Input - User"
    "Awaiting Input - Tech"
    "Awaiting Input - Vendor"
    "Awaiting Quote"
    "Canceled by Requester"
    "Pending HR Actions"
    "Project - Proactive"
    "Purchase in Process"
    "Research Required"
    "Scheduled-Check Due Date"
    "Under Review"
    "Assigned"
    "Resolved"

  |]

let defaultColumns = 
  Document.Incident.columns
  |> Array.filter (fun column -> 
        match column.IsDefault with 
        | Some true when requiredColumns.Contains(column.Name.JsonValue.AsString()) -> true 
        | _ -> false 
        )
let resolutions = 
  [|

    "Aborted"
    "Canceled by User Request"
    "Duplicate"
    "No longer Funded"
    "Not Solved (Black Flag Blocking - See Notes)"
    "Not Solved (Escalated to External Support)"
    "Not Solved (Escalated to Vendor)"
    "Not Solved (Resolution Set for Future Upgrade)"
    "Not Solved (Not Reproducible)"
    "Not Solved (Too Costly)"
    "Postponed"
    "Solved (Permanently)"
    "Solved (Work Around)"
    "Unknown (No Response From User)"
    
  |]
let incidentRowColumns = 
  [|

    "Assignee"
    "Category"
    "Comments"
    "Created At"
    "Created By"
    "Department"
    "Description"
    "Group Assignment"
    "Priority"
    "Requester"
    "Site"
    "State"
    "Subcategory"
    "Tags"
    "Title"
    "Updated At"
  |]

defaultColumns |> Array.iter (fun column -> printfn "%s" (column.Name.JsonValue.AsString()))

let priority = Document.Incident.columns |> Array.find (fun column -> column.Name.JsonValue.AsString() = "priority")
let jsonTestFile = Path.Combine(__SOURCE_DIRECTORY__, "test.fsx") |> FileInfo




Ast.Oak() {
    Ast.AnonymousModule() {
        (*
        Ast.HashDirective(
            "r",
            "\"nuget: Esri.ArcGISRuntime, 300.0.0\""
        )
        *)
        Ast.HashDirective(
            "r",
            "\"nuget: PosInformatique.Foundations.EmailAddresses\""
        )
        Ast.HashDirective(
            "r",
            "\"nuget: FSharp.Data\""
        )
        Ast.HashDirective(
            "r",
            "\"nuget: Dubzer.WhatwgUrl\""
        )
        Ast.HashDirective(
            "r",
            "\"nuget: libphonenumber-csharp\""
        )
        Ast.Open("System")
        Ast.Open("PosInformatique.Foundations.EmailAddresses")
        Ast.Open("Dubzer.WhatwgUrl")
        Ast.Open("FSharp.Data")
        Ast.Open("PhoneNumbers")

        
        Ast.Enum("Priority"){
          for priorityOption in priority.Options do 
            Ast.EnumCase(priorityOption.Name.JsonValue.AsString(), Ast.Int(priorityOption.Id.JsonValue.AsInteger()))
        } 
        Ast.Enum("Department"){

                for department in departments do 
                  Ast.EnumCase(department.name, Ast.Int(department.id))

        } 
        Ast.Record("Incident"){
            Ast.Field("id", "int")
            Ast.Field("number", "int")
            Ast.Field("name", "string")
            Ast.Field("description", "HtmlNode")
            Ast.Field("description_no_html", "string")
            Ast.Field("state", "State")
            Ast.Field("priority", "Priority")
            Ast.Field("category", "Category")
            Ast.Field("subcategory", "Category option")
            Ast.Field("assignee", "Assignee")
            Ast.Field("requester", "User")
            Ast.Field("created_at", "DateTime")
            Ast.Field("updated_at", "DateTime")
            Ast.Field("due_at", "DateTime option")
            Ast.Field("sla_violations", "string array")
            Ast.Field("number_of_comments", "int")
            Ast.Field("user_saw_all_comments", "bool")
            Ast.Field("is_service_request", "bool")
            Ast.Field("created_by", "User")
            Ast.Field("resolved_by", "Employee")
            Ast.Field("resolution_description", "string")
            Ast.Field("resolution_code", "ResolutionCode")
            Ast.Field("group_assignee", "Assignee option")
            Ast.Field("customer_satisfaction_survey_sent_at", "DateTime")
            Ast.Field("customer_satisfaction_survey_completed_at", "DateTime option")
            Ast.Field("custom", "string option")
            Ast.Field("href", "DomUrl")
            Ast.Field("href_account_domain", "DomUrl")
            Ast.Field("site", "Site option")
            Ast.Field("department", "Department")
            Ast.Field("cc", "EmailAddress")
            Ast.Field("custom_fields_values", "unit array")
            Ast.Field("origin", "string")
            Ast.Field("releases", "unit array")
            Ast.Field("problems", "unit array")
            Ast.Field("problem", "unit array")
            Ast.Field("incidents", "IncidentReference array")
            Ast.Field("changes", "unit array")
            Ast.Field("tasks", "unit array")
            Ast.Field("time_tracks", "unit array")
            Ast.Field("solutions", "unit array")
            Ast.Field("assets", "unit array")
            Ast.Field("mobiles", "unit array")
            Ast.Field("other_assets", "unit array")
            Ast.Field("configuration_items", "unit array")
            Ast.Field("discovery_hardwares", "unit array")
            Ast.Field("purchase_orders", "unit array")              
              }
        Ast.Union("State"){
          for state in states do 
            Ast.UnionCase state
            
        }
        |> _.toRecursive()
        |> _.attribute(Ast.Attribute("RequireQualifiedAccess"))
        Ast.Union("ResolutionCode"){
          for resolution in resolutions do 
            Ast.UnionCase resolution
            
        }
        |> _.toRecursive()
        |> _.attribute(Ast.Attribute("RequireQualifiedAccess"))
        Ast.Record("User"){
          
          Ast.Field("id",  "int")
          Ast.Field("account_id",  "int")
          Ast.Field("user_id",  "int")
          Ast.Field("email",  "EmailAddress")
          Ast.Field("name",  "string")
          Ast.Field("disabled",  "bool")
          Ast.Field("site_id",  "int option")
          Ast.Field("site",  "Site option")
          Ast.Field("department_id",  "int")
          Ast.Field("department",  "Department")
          Ast.Field("has_gravatar",  "bool")
          Ast.Field("customer_satisfaction_survey_time",  "DateTime option")
          Ast.Field("avatar",  "Avatar")
        } |> _.toRecursive()
        Ast.Record("Site"){
          
          Ast.Field("id",  "int")
          Ast.Field("name",  "string")
          Ast.Field("location",  "string")
          Ast.Field("description",  "string option")
          Ast.Field("time_zone",  "string")
        } |> _.toRecursive()
        Ast.Union("Avatar"){
          Ast.UnionCase("AvatarInitials",  "AvatarInitials")
          Ast.UnionCase("AvatarImage",  "AvatarImage")
        } |> _.toRecursive()
        Ast.Record("AvatarInitials"){
          Ast.Field("initials",  "string")
          Ast.Field("color",  "string")
        } |> _.toRecursive()
        Ast.Record("AvatarImage"){
          Ast.Field("image_class",  "string option")
          Ast.Field("sso_image_class",  "string option")
          Ast.Field("avatar_url",  "DomUrl")
        } |> _.toRecursive()
        Ast.Record("IncidentRow"){
          for column in incidentRowColumns do 
              Ast.Field(column,  "string")
        } |> _.toRecursive()
        Ast.Record("IncidentReference"){
          Ast.Field("id",  "int")
          Ast.Field("href",  "DomUrl")
        } |> _.toRecursive()

        Ast.Record("Category"){
              Ast.Field("id", "int")
              Ast.Field("name", "string")
              Ast.Field("default_tags", "string option")
              Ast.Field("parent_id", "int option")
              Ast.Field("deleted", "bool")
              Ast.Field("default_assignee_id", "int")
        } |> _.toRecursive()
        Ast.Record("Assignee"){
              Ast.Field("group_id", "int")
              Ast.Field("is_user", "bool")
              Ast.Field("id", "int")
              Ast.Field("name", "string")
              Ast.Field("email",  "EmailAddress")
              Ast.Field("avatar", "Avatar")
              Ast.Field("reports_to", "Assignee option")
        } |> _.toRecursive()
        Ast.Record("Employee"){
              Ast.Field("id", "int")
              Ast.Field("name", "string")
              Ast.Field("disabled", "bool")
              Ast.Field("title", "string")
              Ast.Field("email",  "EmailAddress")
              Ast.Field("created_at", "DateTime")
              Ast.Field("updated_at", "DateTime")
              Ast.Field("last_login", "DateTime")
              Ast.Field("phone", "PhoneNumber")
              Ast.Field("mobile_phone", "PhoneNumber option")
              Ast.Field("role", "Role")
              Ast.Field("group_ids", "int array")
              Ast.Field("available_for_assignment", "bool")
              Ast.Field("can_be_available_for_assignment", "bool")
              Ast.Field("provider",  "string")
              Ast.Field("custom_fields_values", "unit array")
              Ast.Field("site",  "Site option")
              Ast.Field("department",  "Department")
              Ast.Field("avatar", "Avatar")
              Ast.Field("reports_to", "Assignee option")

        } |> _.toRecursive()
        Ast.Record("Role"){
              Ast.Field("id", "int")
              Ast.Field("name", "string")
              Ast.Field("description",  "string")
              Ast.Field("portal", "bool")
              Ast.Field("show_my_tasks", "bool")
        } |> _.toRecursive()
    }
}
|> Gen.mkOak
|> Gen.run
|> fun fsText -> File.WriteAllText(jsonTestFile.FullName,fsText)






















































(*

XMLSchema.schemaSet.Compile()

  

type SchemaElement = 
  | SimpleElement of SimpleElement
  | ComplexElement of ComplexElement
  member this.xmlSchemaElement = 
      match this with 
        | SimpleElement  simpleElement -> simpleElement.schemaElement
        | ComplexElement  complexElement -> complexElement.schemaElement

and SimpleElement = 
  {
    schemaElement : XmlSchemaElement
    simpleType : XmlSchemaSimpleType
  }
and ComplexElement = 
  {
    schemaElement : XmlSchemaElement
    complexType : XmlSchemaComplexType
  }

type XmlSchemaElement with 
    member this.toSchemaElement = 
      match this.ElementSchemaType with 
      | :? XmlSchemaSimpleType as simpleType -> 
          {
            schemaElement = this
            simpleType = simpleType
          } |> SimpleElement
      | :? XmlSchemaComplexType as complexType -> 
          {
            schemaElement = this
            complexType = complexType
          } |> ComplexElement


type XmlSchemaElementRecord = 
  {
    schemaElements :SchemaElement array
  }
  member this.simpleElements = this.schemaElements |> Array.choose (fun schemaElement -> 
    match schemaElement with 
    | SimpleElement simpleElement -> Some simpleElement
    | _ -> None
    )
  member this.complexElements = this.schemaElements |> Array.choose (fun schemaElement -> 
    match schemaElement with 
    | ComplexElement complexElement -> Some complexElement
    | _ -> None
    )

type XmlSchemaComplexType with 
    member this.Sequence = 
        {
          schemaElements = 
            match this.Particle with 
            | null -> [||]
            | :? XmlSchemaSequence as schemaSequence -> schemaSequence.Items  |> Seq.cast<XmlSchemaElement> |> Seq.map (fun sequenceElement -> sequenceElement.toSchemaElement) |> Seq.toArray
        }

type XmlSchema with 
    member this.ElementRecord = 
      {
        schemaElements = this.Elements.Values |> Seq.cast<XmlSchemaElement> |> Seq.map (fun xmlSchemaElement -> xmlSchemaElement.toSchemaElement) |> Seq.toArray
      }








let testElement = 
  Document.Incident.xmlSchema.ElementRecord.complexElements
  |> Array.choose (fun element -> 
    if element.schemaElement.Name.ToLowerInvariant() = "due_at" then 
      Some element
    else 
      None
      )
      |> Array.exactlyOne
      
testElement.complexType.Attributes

Document.Incident.xmlSchema.ElementRecord.complexElements
|> Array.iter (fun element -> printfn "%s" element.schemaElement.Name)

// TODO next evaluate why Sequence has null reference
// Sequence.schemaElements.Length .complexElements[2]



let xmlTestFile = Path.Combine(__SOURCE_DIRECTORY__, "test.fsx") |> FileInfo
Ast.Oak() {
    Ast.AnonymousModule() {
        (*
        Ast.HashDirective(
            "r",
            "\"nuget: Esri.ArcGISRuntime, 300.0.0\""
        )
        *)
        Ast.Open("System")
        for index = 1 to  Document.Incident.xmlSchema.ElementRecord.complexElements.Length - 1 do 
            let complexElement = Document.Incident.xmlSchema.ElementRecord.complexElements[index]
            let elementRecord = complexElement.schemaElement.Name |> Converters.FirstCharToUpperCase |> TypeBinder
            if complexElement.complexType.Sequence.schemaElements.Length > 0 then

                let astRecord = 
                  Ast.Record(elementRecord.binding){
                    for simpleElement in complexElement.complexType.Sequence.simpleElements do 
                      let elementField = simpleElement.schemaElement.RefName.Name |> Converters.ToCamelCase |> VariableBinder
                      Ast.Field(elementField.binding, Literal.stringifyTypeDynamic simpleElement.simpleType.Datatype.ValueType)
                    for complexElement in complexElement.complexType.Sequence.complexElements do 
                      Ast.Field(complexElement.schemaElement.RefName.Name, Converters.FirstCharToUpperCase complexElement.schemaElement.RefName.Name)
                  }
                if index = 1 then 
                  astRecord
                else 
                  astRecord.toRecursive()

    }
}
|> Gen.mkOak
|> Gen.run
|> fun fsText -> File.WriteAllText(xmlTestFile.FullName,fsText)



*)


//