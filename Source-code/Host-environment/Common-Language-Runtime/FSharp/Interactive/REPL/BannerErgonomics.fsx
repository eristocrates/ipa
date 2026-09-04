#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#r "UrlErgonomics.dll"

open UrlErgonomics

open Dubzer.WhatwgUrl




module gov =
    module leoncountyfl =
        module leonintra =
            let baseUrl = DomUrl "https://leonintra.leoncountyfl.gov/"

            let PayrollCalendar =
                baseUrl.AppendPath "Departments/Human-Resources/PAYROLL-CALENDARS"

            let FormsDocuments = baseUrl.AppendPath "Forms-Documents"

        module bannerprodssb =

            let baseUrl =
                DomUrl "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService"

            let hrDashboard = baseUrl.AppendPath "ssb/hrDashboard"
            let payStubSummaryList = hrDashboard.AppendFragmentPath "payStubSummary/list"

            let payStubSummary (payYear: int) =
                payStubSummaryList.ConcatFragment(string payYear)


gov.leoncountyfl.bannerprodssb.payStubSummary 2025

let employeeTest =
    DomUrl "https://bannerprodssb.leoncountyfl.gov:8449/EmployeeSelfService/ssb/menu"

employeeTest.Host
employeeTest.pathStem
employeeTest.extension
