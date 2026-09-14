#time on
fsi.PrintLength <- 20
fsi.ShowDeclarationValues <- true

open System
open System.Globalization
open System.IO
open System.Net.Http


#r "nuget: CsvHelper"
open CsvHelper


#r "nuget: FsExcel"
open FsExcel

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

(*

Family Medicine: Adult Medicine // Millenium only
General Practice 
Internal Medicine (General Medical Care) 
Nurse Practitioner 
Nurse Practitioner: Acute Care 
Nurse Practitioner: Adult Health 
Nurse Practitioner: Primary Care 
Physician Assistant 


no more than 25 miles
prefer males

*)
module Document =
    module GeneralPractice =
        [<Literal>]
        let filePath =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Family\QueryResults\GeneralPractice.json"

        let json =
            let provided = JsonProvider<filePath>.Load filePath

            provided.Results
            |> Array.filter (fun result ->
                not (
                    result.CarrierEntity.Locations
                    |> Array.exists (fun location -> location.Name.Contains("Millennium"))
                )

            )

    module InteralMedicine =
        [<Literal>]
        let filePath =
            @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Family\QueryResults\InternalMedicine.json"

        let json =
            let provided = JsonProvider<filePath>.Load filePath

            provided.Results
            |> Array.filter (fun result ->
                not (
                    result.CarrierEntity.Locations
                    |> Array.exists (fun location -> location.Name.Contains("Millennium"))
                )

            )

module taxonomy =
    [<Literal>]
    let file_path = @"D:\Surface\Medical\Taxonomy_Master_List.csv"

    let csv = CsvProvider<file_path>.Load file_path


type MedicalProvider =
    { ``First Name``: string
      ``Middle Name``: string
      ``Last Name``: string
      Description: string
      Gender: string
      Grouping: string
      ``Primary Location Name``: string
      ``Primary Location Phone``: string
      ``Primary Location Address Line 1``: string
      ``Primary Location Address Line 2``: string
      ``Primary Location Address City``: string
      ``Primary Location Address Zip Code``: int }


let generalPracticeMedicalProviders =
    Document.GeneralPractice.json
    |> Array.filter (fun result ->
        result.CarrierEntity.Locations
        |> Array.exists (fun location -> location.Primary = "Y"))
    |> Array.filter (fun result -> result.CarrierEntity.Gender = "M")

    |> Array.map (fun result ->
        let description_display =
            result.CarrierEntity.Locations
            |> Array.collect (fun location ->
                location.Specialties
                |> Array.choose (fun speciality -> speciality.DescriptionDisplay))
            |> Array.distinct
            |> String.concat ", "

        let grouping =
            result.CarrierEntity.Locations
            |> Array.collect (fun location ->
                location.Specialties |> Array.choose (fun speciality -> speciality.Grouping))
            |> Array.distinct
            |> String.concat ", "

        let primaryLocation =
            result.CarrierEntity.Locations
            |> Array.find (fun location -> location.Primary = "Y")

        {

          ``First Name`` = result.CarrierEntity.Name.FirstName
          ``Middle Name`` = defaultArg result.CarrierEntity.Name.MiddleName String.Empty
          ``Last Name`` = result.CarrierEntity.Name.LastName
          Description = description_display
          Grouping = grouping
          Gender = result.CarrierEntity.Gender
          ``Primary Location Name`` = primaryLocation.Name
          ``Primary Location Phone`` = primaryLocation.Phone.Phone
          ``Primary Location Address Line 1`` = primaryLocation.Address.AddressLine1
          ``Primary Location Address Line 2`` = defaultArg primaryLocation.Address.AddressLine2 String.Empty
          ``Primary Location Address City`` = primaryLocation.Address.City
          ``Primary Location Address Zip Code`` = primaryLocation.Address.ZipCode

        }

    )

let internalMedicineMedicalProviders =
    Document.InteralMedicine.json
    |> Array.filter (fun result ->
        result.CarrierEntity.Locations
        |> Array.exists (fun location -> location.Primary = "Y"))
    |> Array.filter (fun result -> result.CarrierEntity.Gender = "M")
    |> Array.map (fun result ->
        let description_display =
            result.CarrierEntity.Locations
            |> Array.collect (fun location ->
                location.Specialties
                |> Array.choose (fun speciality -> speciality.DescriptionDisplay))
            |> Array.distinct
            |> String.concat ", "

        let grouping =
            result.CarrierEntity.Locations
            |> Array.collect (fun location ->
                location.Specialties |> Array.choose (fun speciality -> speciality.Grouping))
            |> Array.distinct
            |> String.concat ", "

        let primaryLocation =
            result.CarrierEntity.Locations
            |> Array.find (fun location -> location.Primary = "Y")

        {

          ``First Name`` = result.CarrierEntity.Name.FirstName
          ``Middle Name`` = defaultArg result.CarrierEntity.Name.MiddleName String.Empty
          ``Last Name`` = result.CarrierEntity.Name.LastName
          Description = description_display
          Grouping = grouping
          Gender = result.CarrierEntity.Gender
          ``Primary Location Name`` = primaryLocation.Name
          ``Primary Location Phone`` = primaryLocation.Phone.Phone
          ``Primary Location Address Line 1`` = primaryLocation.Address.AddressLine1
          ``Primary Location Address Line 2`` = defaultArg primaryLocation.Address.AddressLine2 String.Empty
          ``Primary Location Address City`` = primaryLocation.Address.City
          ``Primary Location Address Zip Code`` = primaryLocation.Address.ZipCode

        }

    )



let medicalProviders =
    Array.concat [| generalPracticeMedicalProviders; internalMedicineMedicalProviders |]
    |> Array.sortBy (fun medicalProvider -> medicalProvider.``Primary Location Address City``)

let writeCsv (filePath: string) data =
    use writer = new StreamWriter(filePath)
    use csv = new CsvWriter(writer, CultureInfo.InvariantCulture)
    csv.WriteRecords(data)

medicalProviders
|> writeCsv
    @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Family\Providers.csv"

medicalProviders.Length

// "address=18200 Cochran Blvd, Port Charlotte, FL 33948"

let randomMedicalProvider = medicalProviders |> Array.randomChoice

let matchingResult =
    Document.InteralMedicine.json
    |> Array.find (fun result -> result.CarrierEntity.Name.LastName = "Castillo")

let primaryLocation =
    matchingResult.CarrierEntity.Locations
    |> Array.find (fun location -> location.Primary = "Y")

primaryLocation.Address.ZipCode
