#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

#r "UrlErgonomics.dll"

open UrlErgonomics
open Dubzer.WhatwgUrl


module NeoGov =
    let PaginatedUrl (url: DomUrl) =

        url
        |> DomUrl.AddQueryParameter "Page" 1
        |> DomUrl.AddQueryParameter "PageSize" 1000

    let loginwithsso = DomUrl "https://login.neogov.com/loginwithsso" // ?returnURL=https%3A%2F%2Funified.neogov.com%2Fdashboard&siteCode=US
    let dashboard = DomUrl "https://unified.neogov.com/dashboard"

    module Employee =
        let employees =
            DomUrl "https://unifiedweb-api.neogov.com/api/Employee/employees"
            |> PaginatedUrl

        module by =
            module id =
                let orgChartView (employeeId: string) =
                    DomUrl $"https://unifiedweb-api.neogov.com/api/Employee/{employeeId}/hierarchy/orgChartView"
                    |> DomUrl.AddQueryParameter "includeSubordinateInformation" true

                let directManager (employeeId: string) =
                    DomUrl $"https://unifiedweb-api.neogov.com/api/Employee/{employeeId}/directManager"

                let profile (employeeId: string) =
                    DomUrl $"https://unifiedweb-api.neogov.com/api/Employee/user-profile"
                    |> DomUrl.AddQueryParameter "employeeId" employeeId

    module Default =
        let customWindowProperties =
            DomUrl "https://unifiedweb-api.neogov.com/api/Default/customWindowProperties"

    let profile (employeeId: string) =
        DomUrl $"https://unified.neogov.com/profile/{employeeId}"

    module Task =
        let todo =
            DomUrl "https://unifiedweb-api.neogov.com/api/Task/todo"
            |> PaginatedUrl

        let completed =
            DomUrl "https://unifiedweb-api.neogov.com/api/Task/completed"
            |> PaginatedUrl

        let taskType = DomUrl "https://unifiedweb-api.neogov.com/api/TaskType"



(*

mainTab.BringToFrontAsync().await

mainTab.GoToAsync(NeoGov.dashboard.asString).await

El.A * Attr.Href.StartsWith("/loginwithsso") |> _.Css |> mainTab.Locator |> _.ClickAsync().await

El.Input * Attr.Id.Equals("EmployerCode") |> _.Css |> mainTab.Locator |> _.FillAsync("leoncountyfl").await

El.Button * Attr.Id.Equals("sendEmployerId") |> _.Css |> mainTab.Locator |> _.ClickAsync().await
El.Input * Attr.Type.Equals("submit") |> _.Css |> mainTab.Locator |> _.ClickAsync().await



*)
