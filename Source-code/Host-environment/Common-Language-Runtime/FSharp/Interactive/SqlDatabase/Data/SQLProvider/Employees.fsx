#time on
fsi.PrintLength <- 10

open System

#r "nuget: SQLProvider.MsSql, 1.5.18"

#load @"C:\Secret\InforSecrets.fsx"

open InforSecrets

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics

open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql

open System.Linq

type InforProdSql =
    SqlDataProvider<ConnectionString=Prod.connection_string, IndividualsAmount=10000, UseOptionTypes=Common.NullableColumnType.OPTION>

let operations = InforProdSql.GetDataContext()



type Banner_Organization = 
    {

        Name:string
        Code :string
    
    }
type Banner_Supervisor = 
    {

        Name:string
        ID :string
    
    }
type Banner_Employee = 
    {
        ID:string
        First_Name:string
        MI:string
        Last_Name:string
        Hired_Date:DateTime
        Effective_Start_Date:DateTime option
        Rate: decimal option
        Supervisor : Banner_Supervisor option
        Position : string
        Email: string option
        Organization: Banner_Organization
        Department:string 
        Division:string
    }


let banner_employees =
    query {
        for banner_employee in operations.Dbo.LcSelectAllemployees do
            
            
            
            select
                {

                    ID = banner_employee.Id.Value
                    First_Name = banner_employee.Firstname.Value
                    MI = banner_employee.Middlename
                    Last_Name = banner_employee.Lastname
                    Hired_Date = banner_employee.Hired
                    Effective_Start_Date = banner_employee.Effective
                    Rate = banner_employee.Rate
                    Supervisor = 
                        if banner_employee.Supervisor.IsSome && banner_employee.Supervisorid.IsSome then 
                            Some {Name = banner_employee.Supervisor.Value  ; ID = banner_employee.Supervisorid.Value }  
                        else 
                            None
                    Position = banner_employee.Position.Value
                    Email = banner_employee.Email
                    Organization = { Name = banner_employee.Org.Value ; Code = banner_employee.Orgcode }
                    Department = banner_employee.Department.Value
                    Division = banner_employee.Division.Value
                    

                }

    } |> Seq.toArray




let banner_employee_ids = 
    banner_employees
    |> Array.Parallel.map (fun banner_employee -> banner_employee.ID)
    |> Set.ofArray





let infor_employee_ids = 

    query {
        for infor_employee in operations.Resources.EmployeeviewActive do
            
            select (infor_employee.Empid)
            
            
            

    }
    |> Set.ofSeq
let missing_employee_ids = banner_employee_ids - infor_employee_ids
missing_employee_ids.Count
let missing_employees = 
    banner_employees
    |> Array.Parallel.filter (fun banner_employee -> missing_employee_ids.Contains(banner_employee.ID))
// TODO next finish solar wind tickets
// TODO investigate api for adding employees
missing_employees.Length
missing_employees |> Array.tryFind (fun employee -> employee.Last_Name.ToLowerInvariant() = "ervin")

infor_employee_ids.Contains("90034339")
let infor_employee_contact_keys = 
    query {
        for infor_employee in operations.Resources.Employee do
            where (infor_employee.Expdate.IsNone && not (banner_employee_ids.Contains(infor_employee.Empid)))
            select (infor_employee.Contactkey)
            
            
            

    } 
let infor_id_keys = 
    query {
        for contact in operations.Resources.Contact do 
        where ( infor_employee_contact_keys.Contains(contact.Cntctkey))
        where contact.Idkey.IsSome
        select contact.Idkey.Value
    }


let infor_employees = 
    query {
        for contact in operations.Resources.Cntctid do 
        where (infor_id_keys.Contains (contact.Idkey))
        where(not(contact.Namelast.Contains("EXPIRED")))
        select (contact.Namefirst, contact.Namelast)
    }
    |> Seq.toArray



infor_employees.Length
let employee_probe = infor_employees |> Array.randomSample 10 // |> Array.Parallel.filter (fun employee -> employee.Supervisor.IsNone)

(*


printfn "%d out of %d employees (%.2f%%)"
    employee_probe.Length
    banner_employees.Length
    ((double employee_probe.Length / double banner_employees.Length) *100.0)

*)

