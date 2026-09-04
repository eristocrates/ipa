#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "PdfErgonomics.dll"

open PdfErgonomics
open System.IO



module LeonCounty =
    module Resolution =
        let TreatAllDignityRespect =
            "https://cms.leoncountyfl.gov/Portals/0/DeptFiles/Admin/ResolutionTreatAllDignityRespect.pdf"
            |> FileInfo

    module ComprehensivePlan =
        let TallahasseeLeonCounty2050 =
            "https://www.talgov.com/Uploads/Public/Documents/place/comp_plan/tallahassee-leon-county-comprehensive-plan-rev-g2026n.pdf"
            |> FileInfo

    module FY2022 =
        module FY2026 =
            let StrategicPlan =
                "https://cms.leoncountyfl.gov/Portals/0/DeptFiles/CMR/Docs/StrategicPlan.pdf"
                |> FileInfo

    module FY2025 =
        let AnnualReport =
            "https://cms.leoncountyfl.gov/Portals/0/adam/Documents/AI0vCswaFkyX0tCKHBE7pQ/Link/LCAR-2025.pdf"
            |> FileInfo

    module FY2026 =
        module Budget =
            module Adopted =
                let LeonCounty =
                    "https://cms.leoncountyfl.gov/Portals/0/DeptFiles/OMB/Docs/AnnualBudget/FY2026AdoptedBudget.pdf"
                    |> FileInfo

                let GeneralBudgetInformation =
                    "https://www.leoncountyfl.gov/omb/budget26/docs/00-05%20-%20General%20Budget%20Information.pdf"
                    |> FileInfo

                let DepartmentofPublicWorks =
                    "https://www.leoncountyfl.gov/omb/budget26/docs/11%20-%20Public%20Works.pdf"
                    |> FileInfo

                let OfficeofInformationAndTechnology =
                    "https://www.leoncountyfl.gov/omb/budget26/docs/09%20-%20Office%20of%20Information%20Technology.pdf"
                    |> FileInfo

                let Appendix =
                    "https://www.leoncountyfl.gov/omb/budget26/docs/26%20-%20Appendix.pdf"
                    |> FileInfo



module OfficeofInformationAndTechnology =
    open UglyToad.PdfPig

    let pdf =
        PdfDocument.Open LeonCounty.FY2026.Budget.Adopted.OfficeofInformationAndTechnology.FullName
