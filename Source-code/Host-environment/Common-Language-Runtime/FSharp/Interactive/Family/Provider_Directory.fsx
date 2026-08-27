# time on
fsi.PrintLength <- 20
fsi.ShowDeclarationValues <- true
open System
open System.IO
open System.Net.Http

#r "nuget: Humanizer.Core"
open Humanizer

#r "nuget: CaseConverter"
open CaseConverter

#r "nuget: FsHttp"
open FsHttp
#r "nuget: Fli"
open Fli

#r "nuget: FSharp.Literals, 2.2.15"
open FSharp.Literals

#r "nuget: FSharp.Data"
open FSharp.Data
open FSharp.Data.JsonExtensions

#r "nuget: SwaggerProvider"

open SwaggerProvider


#r "nuget: Hl7.Fhir.R4"

open Hl7.Fhir.Model
open Hl7.Fhir.Rest


#r "nuget: Focal.Json, 0.10.0"

open Focal.Core
open Focal.Json


#r "nuget: Newtonsoft.Json"

open Newtonsoft.Json.Linq
#r "nuget: Fabulous.AST" 
open Fabulous.AST


#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Ergonomic_Extensions\obj\Release\net10.0"
// #I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\DotNetRDFSharp\obj\Release\net10.0"
// #I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Solution\DoxAletheia\Rdf_Vocabulary\obj\Release\net10.0"
#r "Ergonomic_Extensions.dll"
// #r "DotNetRDFSharp.dll"
// #r "Rdf_Vocabulary.dll"
open DoxAletheia.PrettierNaming
open DoxAletheia.PrettierNaming.FSharp_Keywords





module results = 
        [<Literal>]
        let file_path = @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Family\current_results.json"
        let json = 
                let provided = JsonProvider<file_path>.Load file_path
                provided.Results
                |> Array.filter (fun result ->
                    not (result.CarrierEntity.Locations
                            |> Array.exists (fun location -> location.Name.Contains("Millennium"))
                        )
                            
                            )
module taxonomy = 
        [<Literal>]
        let file_path = @"D:\Surface\Medical\Taxonomy_Master_List.csv"
        let csv = CsvProvider<file_path>.Load file_path


type Medical_Provider = 
    {
        first_name:string
        middle_name:string
        last_name:string
        description:string
        grouping:string
    }


let medical_providers = 
            results.json
            |> Array.take 2
            |> Array.map (fun result -> 
            let description_display = 
                        result.CarrierEntity.Locations
                        |> Array.collect (fun location ->
                                location.Specialties |> Array.choose (fun speciality -> speciality.DescriptionDisplay)
                                )
                                |> Array.distinct
                                |> String.concat ", "
            let grouping = 
                        result.CarrierEntity.Locations
                        |> Array.collect (fun location ->
                                location.Specialties |> Array.choose (fun speciality -> speciality.Grouping)
                                )
                                |> Array.distinct
                                |> String.concat ", "
            
            {

                first_name = result.CarrierEntity.Name.FirstName
                middle_name = defaultArg result.CarrierEntity.Name.MiddleName  String.Empty
                last_name = result.CarrierEntity.Name.LastName
                description = description_display
                grouping = grouping
                

            }
                
                )


// TODO type EVERYTHING then consider how to render for mom and richard





























module Provider_Directory = 
    let uri = new Uri "https://iopc-pd.api.centene.com/iopc/pd/fhir/providerdirectory/"
    module openapi = 

        [<Literal>]
        let file_path =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Family\pd-swagger-PP-2023-12-12_15_52_39-PP-2024-10-10_21_48_31.json"
        let json = JsonProvider<file_path>.Load file_path
    module Client = 
        let fhir = new FhirClient("https://iopc-pd.api.centene.com/iopc/pd/fhir/providerdirectory/" )
        fhir.Settings.PreferredFormat <- ResourceFormat.Xml
        fhir.Settings.ReturnPreference <- ReturnPreference.Representation

open Provider_Directory.Client







type Bundle with 
  static member inline as_resource<'T when 'T :> Resource> (bundle:Bundle)  =
    bundle.Entry
    |> Seq.choose (fun entry ->
        match entry.Resource with
        | :? 'T as resource -> Some resource
        | _ -> None)
    |> Seq.toArray

type Location with 
    member this.practitioner_roles = 
      fhir.SearchAsync<PractitionerRole>(
          criteria =
              [|
                  $"location=Location/{this.Id}"
              |]
      )
      |> Async.AwaitTask
      |> Async.RunSynchronously
      |> Bundle.as_resource<PractitionerRole>

type PractitionerRole with 
    member this.organization() =  
      fhir.SearchAsync<Organization>(
          criteria =
              [|
                  $"_id=HMN"
              |]
      )
      |> Async.AwaitTask
      |> Async.RunSynchronously
      |> Bundle.as_resource<Organization>

























let practitioners = 
    fhir.SearchAsync<Practitioner>(
        [| 
          
            "given:exact=Alfonso"
            "family:exact=Garcia-Bello"
          
           |]
    )
    |> Async.AwaitTask
    |> Async.RunSynchronously
    |> Bundle.as_resource<Practitioner>

let practitioner = practitioners[0]
practitioner.Identifier




let practitioner_roles = 
    fhir.SearchAsync<PractitionerRole>(
        [| 
          
            $"practitioner=Practitioner/{practitioner.Id}"
          
           |]
    )
    |> Async.AwaitTask
    |> Async.RunSynchronously
    |> Bundle.as_resource<PractitionerRole>

let random_practitioner_role = practitioner_roles |> Array.randomChoice


// practitioner role id 
// entityId-carrier_code-provId-


let organizations = 
    fhir.SearchAsync<Organization>(
        [| $"={random_practitioner_role.Organization.Reference}" |]
    )
    |> Async.AwaitTask
    |> Async.RunSynchronously
    |> Bundle.as_resource<Organization>

organizations.Length
organizations |> Array.map (fun element -> element.Name)






let insurance_plans = 
    fhir.SearchAsync<InsurancePlan>(
        [| 
          
            "name=Medicaid/Child Welfare - FL" 
          
           |]
    )
    |> Async.AwaitTask
    |> Async.RunSynchronously
    |> Bundle.as_resource<InsurancePlan>

insurance_plans.Length


insurance_plans |> Array.map (fun element -> element.Type[0].Coding)
insurance_plans |> Array.map (fun element -> element.Meta)





let locations = 
    fhir.SearchAsync<Location>(
        [|

              "address=18200 Cochran Blvd, Port Charlotte, FL 33948"

        |]
    )
    |> Async.AwaitTask
    |> Async.RunSynchronously
    |> Bundle.as_resource<Location>
    |> Array.filter (fun location -> location.practitioner_roles.Length > 0)

locations.Length

let random_location = locations |> Array.randomChoice
random_location.Address
random_location
random_location.practitioner_roles
let random_practitioner_role = random_location.practitioner_roles |> Array.randomChoice 

random_practitioner_role.Organization.Url.OriginalString
random_practitioner_role.organization()

