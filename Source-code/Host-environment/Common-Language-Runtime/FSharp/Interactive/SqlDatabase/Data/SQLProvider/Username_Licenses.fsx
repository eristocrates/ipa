open System

#r "nuget: SQLProvider.MsSql, 1.5.18"

#load @"C:\Secret\InforSecrets.fsx"

open InforSecrets

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics

open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql



type InforProdSql =
    SqlDataProvider<ConnectionString=Prod.connection_string, IndividualsAmount=10000, UseOptionTypes=Common.NullableColumnType.OPTION>

let operations = InforProdSql.GetDataContext()

let target_usernames =
    [|

       "FORDA"
       "KITED"
       "BASSCH"
       "PUNAUSUIAST"
       "MOSGENERIC"
       "MCSPRAYER1"
       "MCSPRAYER2"
       "MCSPRAYER3"


       |]



type ADDBY = ADDBY of string option
type ADDDTTM = ADDDTTM of DateTime option
type ALTERNATEID = ALTERNATEID of string option
type AUTHCODE = AUTHCODE of string option
type DATAGRP = DATAGRP of string option
type DISPLAYNAME = DISPLAYNAME of string option
type EMPID = EMPID of string option
type ENCRYPTCONTENT = ENCRYPTCONTENT of string
type EXPDAYS = EXPDAYS of int option
type ISREPORTAUTHOR = ISREPORTAUTHOR of string option
type LICENSECONTENT = LICENSECONTENT of string
type LICENSEKEY = LICENSEKEY of int
type LICENSENAME = LICENSENAME of string
type LICENSETYPE = LICENSETYPE of string
type LOGINATTEMPTS = LOGINATTEMPTS of int option
type MODBY = MODBY of string option
type MODDTTM = MODDTTM of DateTime option
type NTUSRNAME = NTUSRNAME of string option
type PASSEXPDTTM = PASSEXPDTTM of DateTime option
type ROLEADMIN = ROLEADMIN of string option
type UNIQUEPWD = UNIQUEPWD of string option
type USRKEY = USRKEY of int
type USRNAME = USRNAME of string




module CORE_ACCESSCONTROL =
    type ZACCUSR =

        { ADDBY: ADDBY
          ADDDTTM: ADDDTTM
          ALTERNATEID: ALTERNATEID
          AUTHCODE: AUTHCODE
          DATAGRP: DATAGRP
          DISPLAYNAME: DISPLAYNAME
          EMPID: EMPID
          EXPDAYS: EXPDAYS
          ISREPORTAUTHOR: ISREPORTAUTHOR
          LOGINATTEMPTS: LOGINATTEMPTS
          MODBY: MODBY
          MODDTTM: MODDTTM
          NTUSRNAME: NTUSRNAME
          PASSEXPDTTM: PASSEXPDTTM
          ROLEADMIN: ROLEADMIN
          UNIQUEPWD: UNIQUEPWD
          USRKEY: USRKEY
          USRNAME: USRNAME }

module CORE_LICENSE =
    type LICENSE =
        { ADDBY: ADDBY
          ADDDTTM: ADDDTTM
          LICENSECONTENT: LICENSECONTENT
          LICENSEKEY: LICENSEKEY
          LICENSENAME: LICENSENAME
          LICENSETYPE: LICENSETYPE
          MODBY: MODBY
          MODDTTM: MODDTTM }

    type USERLICENSE =
        { ADDBY: ADDBY
          ADDDTTM: ADDDTTM
          ENCRYPTCONTENT: ENCRYPTCONTENT
          LICENSEKEY: LICENSEKEY
          MODBY: MODBY
          MODDTTM: MODDTTM
          USRKEY: USRKEY }

type Infor_User =

    {


      AddedBy: ADDBY
      AddedDateTime: ADDDTTM
      AlternateId: ALTERNATEID
      AuthorizationCode: AUTHCODE
      DataGroup: DATAGRP
      DisplayName: DISPLAYNAME
      EmployeeID: EMPID
      ExpiredDays: EXPDAYS
      IsReportAuthor: ISREPORTAUTHOR
      Licenses: CORE_LICENSE.LICENSE array
      LoginAttempts: LOGINATTEMPTS
      LastModifiedBy: MODBY
      LastModifiedDateTime: MODDTTM
      WindowsName: NTUSRNAME
      PasswordExpireDate: PASSEXPDTTM
      RoleAdministrator: ROLEADMIN
      UniquePassword: UNIQUEPWD
      UserKey: USRKEY
      AccessUser: USRKEY
      UserName: USRNAME


     }

let target_zaccusrs: CORE_ACCESSCONTROL.ZACCUSR seq =
    query {
        for user in operations.CoreAccesscontrol.Zaccusr do
            where (user.Usrname |=| target_usernames)
            select user
    }
    |> Seq.map (fun user ->

        {

          USRNAME = USRNAME user.Usrname
          EMPID = EMPID user.Empid
          AUTHCODE = AUTHCODE user.Authcode
          DATAGRP = DATAGRP user.Datagrp
          USRKEY = USRKEY user.Usrkey
          NTUSRNAME = NTUSRNAME user.Ntusrname
          ROLEADMIN = ROLEADMIN user.Roleadmin
          ADDBY = ADDBY user.Addby
          ADDDTTM = ADDDTTM user.Adddttm
          MODBY = MODBY user.Modby
          MODDTTM = MODDTTM user.Moddttm
          PASSEXPDTTM = PASSEXPDTTM user.Passexpdttm
          LOGINATTEMPTS = LOGINATTEMPTS user.Loginattempts
          EXPDAYS = EXPDAYS user.Expdays
          UNIQUEPWD = UNIQUEPWD user.Uniquepwd
          ISREPORTAUTHOR = ISREPORTAUTHOR user.Isreportauthor
          DISPLAYNAME = DISPLAYNAME user.Displayname
          ALTERNATEID = ALTERNATEID user.Alternateid

        }

    )

let target_usrkeys =
    target_zaccusrs
    |> Seq.map (fun user ->
        let (USRKEY usrkey) = user.USRKEY
        usrkey)


let licenses: CORE_LICENSE.LICENSE seq =
    query {
        for license in operations.CoreLicense.License do
            select license
    }
    |> Seq.map (fun license ->

        {

          LICENSENAME = LICENSENAME license.Licensename
          LICENSETYPE = LICENSETYPE license.Licensetype
          LICENSECONTENT = LICENSECONTENT license.Licensecontent
          LICENSEKEY = LICENSEKEY license.Licensekey
          ADDDTTM = ADDDTTM license.Adddttm
          MODDTTM = MODDTTM license.Moddttm
          ADDBY = ADDBY license.Addby
          MODBY = MODBY license.Modby

        }

    )


let target_user_licenses: CORE_LICENSE.USERLICENSE seq =
    query {
        for user_license in operations.CoreLicense.Userlicense do
            where (user_license.Usrkey |=| target_usrkeys)
            select user_license

    }
    |> Seq.map (fun user_license ->

        {

          LICENSEKEY = LICENSEKEY user_license.Licensekey
          USRKEY = USRKEY user_license.Usrkey
          ENCRYPTCONTENT = ENCRYPTCONTENT user_license.Encryptcontent
          ADDDTTM = ADDDTTM user_license.Adddttm
          MODDTTM = MODDTTM user_license.Moddttm
          ADDBY = ADDBY user_license.Addby
          MODBY = MODBY user_license.Modby

        }

    )




let target_users =
    target_zaccusrs
    |> Seq.toArray
    |> Array.Parallel.map (fun user ->
        let user_licenses =
            target_user_licenses
            |> Seq.toArray
            |> Array.Parallel.filter (fun user_license -> user_license.USRKEY = user.USRKEY)
            |> Array.Parallel.collect (fun user_license ->
                licenses
                |> Seq.toArray
                |> Array.Parallel.filter (fun license -> license.LICENSEKEY = user_license.LICENSEKEY))



        {


          AddedBy = user.ADDBY
          AddedDateTime = user.ADDDTTM
          AlternateId = user.ALTERNATEID
          AuthorizationCode = user.AUTHCODE
          DataGroup = user.DATAGRP
          DisplayName = user.DISPLAYNAME
          EmployeeID = user.EMPID
          ExpiredDays = user.EXPDAYS
          IsReportAuthor = user.ISREPORTAUTHOR
          Licenses = user_licenses
          LoginAttempts = user.LOGINATTEMPTS
          LastModifiedBy = user.MODBY
          LastModifiedDateTime = user.MODDTTM
          WindowsName = user.NTUSRNAME
          PasswordExpireDate = user.PASSEXPDTTM
          RoleAdministrator = user.ROLEADMIN
          UniquePassword = user.UNIQUEPWD
          UserKey = user.USRKEY
          AccessUser = user.USRKEY
          UserName = user.USRNAME


        }


    )
    |> Seq.toArray


let inline show value = sprintf "%A" value

let stripCaseName (text: string) =
    let index = text.IndexOf " "

    if index < 0 then
        text
    else
        text.Substring(index + 1)

let showCell value = value |> sprintf "%A" |> stripCaseName




sprintf "%-20s, %-20s" "USRNAME" "LICENSENAME"
|> clip

target_users
|> Array.collect (fun user ->
    user.Licenses
    |> Array.map (fun license -> sprintf "%-20s, %-20s" (showCell user.UserName) (showCell license.LICENSENAME)))
|> String.concat "\n"
|> clip

(*

let inforUserNames =
    query {
        for user in TypeProvider.operations.CoreLicenseAudit.Users do
        select user.Username
    } |> Seq.filter (fun userName -> userName.IsSome)
    |> Seq.map (fun userName ->
    Console.WriteLine(userName.Value.ToLowerInvariant())
    userName.Value.ToLowerInvariant()
    )
    |> Set.ofSeq

let names_of_employees_with_infor_accounts =
    TypeProvider.neogov.json.data
    |> Array.filter (fun employee ->
        let userPrincipleName = employee.Email.Split '@' |> Array.head
        employee.IsActive && employee.Department = "Department of Public Works" && inforUserNames.Contains(userPrincipleName.ToLowerInvariant()
        )
    )
    |> Array.map (fun employeeWithInforAccount ->
            $"{employeeWithInforAccount.Email}, {employeeWithInforAccount.EmployeeName}"
    )
    |> Array.toList
    |> List.sort
let csvContent = "Email, EmployeeName" :: names_of_employees_with_infor_accounts


let htmlEscape (s: string) =
    if isNull s then "" else WebUtility.HtmlEncode s

let employeesWithInforAccountsTableHtml =
    let rows =
        TypeProvider.neogov.json.data
        |> Array.filter (fun employee ->
            let userPrincipleName = employee.Email.Split '@' |> Array.head
            employee.IsActive && employee.Department = "Department of Public Works" && inforUserNames.Contains(userPrincipleName.ToLowerInvariant()
            )
        )
        |> Array.choose (fun employee ->
            let userPrincipalName =
                employee.Email.Split '@' |> Array.head |> fun x -> x.ToLowerInvariant()

            if employee.IsActive
               && employee.Department = "Department of Public Works"
               && inforUserNames.Contains userPrincipalName
            then
                Some (employee.Email, employee.EmployeeName)
            else
                None
        )
        |> Array.sortBy (fun (email, name) -> email, name)
        |> Array.map (fun (email, name) ->
            $"<tr><td>{htmlEscape email}</td><td>{htmlEscape name}</td></tr>"
        )
        |> String.concat "\n"

    $"""<table>
  <thead>
    <tr><th>Email</th><th>EmployeeName</th></tr>
  </thead>
  <tbody>
{rows}
  </tbody>
</table>"""

File.WriteAllLines( @"C:\Repositories\Modernization\ConsoleFsharp\lcfl\sql\names_of_employees_with_infor_accounts.csv", csvContent)
File.WriteAllText( @"C:\Repositories\Modernization\ConsoleFsharp\lcfl\sql\names_of_employees_with_infor_accounts.html", employeesWithInforAccountsTableHtml)

module ActiveXDataObject =

    let getSchemaCollections(connection: Microsoft.Data.SqlClient.SqlConnection) =
        connection.GetSchema()

    let connect<'FunctionType> (connectionString: string)(connectionFunction: Microsoft.Data.SqlClient.SqlConnection -> 'FunctionType) =
        use connection = new Microsoft.Data.SqlClient.SqlConnection(connectionString)
        connection.Open()
        connection  |> connectionFunction

    module InforProdSql =
        let operations<'FunctionType> (connectionFunction: Microsoft.Data.SqlClient.SqlConnection -> 'FunctionType) =
            connect ConnectionString.operations connectionFunction

module ServerManagementObject =
    let connectServer(connectionString: string) =
        use sqlConnection = new Microsoft.Data.SqlClient.SqlConnection(connectionString)
        let serverConnection = new ServerConnection( sqlConnection )
        let server = new Server(serverConnection)
        server
    let InforProdSql =
        connectServer ConnectionString.operations








// ========================================================================== //
// Rdf


GraphRuntime.inMemoryDataset.Graphs |> Seq.iter (fun graph ->
    graph.Clear()
    graph.NamespaceMap.Clear()
)


let a = rdf.``type``

let dotnet'api = NamedGraph.inhabitant (mint.prefixID $"https://learn.microsoft.com/en-us/dotnet/api?view=net-10.0#" "dotnet.api") @"C:\Repositories\Modernization\ConsoleFsharp\lcfl\sql\dotnet\api"
[<Literal>]
let system'data'uriString = "https://learn.microsoft.com/en-us/dotnet/api/system.data?view=net-10.0"
type system'data'provider =  HtmlProvider<system'data'uriString>
let system'data'html = system'data'provider.Load system'data'uriString
let system'data = NamedGraph.inhabitant (mint.prefixID $"{system'data'uriString}#" "dotnet.system.data") $"""{dotnet'api.filePath}\system.data"""

dotnet'api._prefix "Namespace" --- a --> owl.Class >-: dotnet'api
dotnet'api._prefix "system.data" --- a --> dotnet'api._prefix "Namespace" >=: [ dotnet'api ; system'data ]
system'data'html.Tables.Classes.Html.Descendants "tr" |> Seq.iter (fun tableRow ->
    let description =
        tableRow.Descendants "p"
        |> Seq.map (fun p -> p.InnerText())
        |> Seq.map (fun s -> s.Trim())
        |> Seq.filter (fun s -> s <> "")
        |> String.concat " "

    tableRow.Descendants "a"
    |> Seq.filter (fun anchor -> anchor.HasClass "xref")
    |> Seq.iter (fun anchor ->
        let href = anchor.Attribute "href"
        Console.WriteLine href
        let localName =
            match href.Value() with
            | value when value.Contains '?' ->  value.Split '?' |> Array.head
            | value -> value
        dotnet'api._prefix "system.data" --- dotnet'api._prefix "Classes" --> dotnet'api._prefix localName >-: system'data
        dotnet'api._prefix localName --~ [
                                            // a -~- owl.Class
                                            dcterms.description -~- description @-@ en
                                            // rdfs.label -~- anchor.InnerText() @-@ en
                                            ] >-: system'data
        )
)
[<Literal>]
let system'data'datatable'uriString = "https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-10.0"
let system'data'datatable = NamedGraph.inhabitant (mint.prefixID $"{system'data'datatable'uriString}#" "dotnet.system.data") $"""{dotnet'api.filePath}\system.data.datatable"""

system'data._prefix "datatable" --- owl.equivalentClass --> dotnet'api._prefix "system.data.datatable" >=: [ system'data ; system'data'datatable ]

type system'data'datatable'provider =  HtmlProvider<system'data'datatable'uriString>
let system'data'datatable'html = system'data'datatable'provider.Load system'data'datatable'uriString

system'data'datatable'html.Tables.Properties.Html.Descendants "tr" |> Seq.iter (fun tableRow ->
    let description =
        tableRow.Descendants "p"
        |> Seq.map (fun p -> p.InnerText())
        |> Seq.map (fun s -> s.Trim())
        |> Seq.filter (fun s -> s <> "")
        |> String.concat " "

    tableRow.Descendants "a"
    |> Seq.filter (fun anchor -> anchor.HasClass "xref")
    |> Seq.iter (fun anchor ->
        let href = anchor.Attribute "href"
        Console.WriteLine href
        let localName =
            match href.Value() with
            | value when value.Contains '?' ->  value.Split '?' |> Array.head
            | value -> value
        dotnet'api._prefix "system.data.datatable" --- dotnet'api._prefix "Properties" --> dotnet'api._prefix localName >-: system'data'datatable
        dotnet'api._prefix localName --~ [
                                            // a -~- rdf.Property
                                            // rdfs.domain -~- dotnet'api._prefix "system.data.datatable"
                                            dcterms.description -~- description @-@ en
                                            // rdfs.label -~- anchor.InnerText() @-@ en
                                        ] >-: system'data'datatable
        )
)
//[100.64.1.16]
let InforProdSql = NamedGraph.inhabitant (mint.prefixID $"smb://InforProdSql.LeonAD.gov/" "InforProdSql") $"""InforProdSql"""
let SchemaCollections = ActiveXDataObject.operations<DataTable>  ActiveXDataObject.getSchemaCollections
InforProdSql._prefix SchemaCollections.TableName --- a --> dotnet'api._prefix "system.data.datatable" >-: system'data'datatable
// TODO Rows
SchemaCollections.Rows
SchemaCollections.DefaultView

File.WriteAllText(
    @"C:\Repositories\Modernization\ConsoleFsharp\lcfl\sql\MetadataCollections.txt",
    (SchemaCollections.Columns.ToString())
)
// TODO serialize
// Providers.MSSqlServer.typeMappings
// |> Seq.iter (fun employee ->
//     let employeeProperties = employee.
//     let employee = NamedGraph.inhabitant (mint.prefixID $"{MSBuild.Core.xsd.root.TargetNamespace}/" "msb") @"C:\Repositories\Modernization\ConsoleFsharp\MSBuild\msb"
//
// )
TypeProvider.operations.``Design Time Commands``.SaveContextSchema
GraphRuntime.Serialization.Turtle.save  dotnet'api
GraphRuntime.Serialization.Turtle.save  system'data
GraphRuntime.Serialization.Turtle.save  system'data'datatable
*)
