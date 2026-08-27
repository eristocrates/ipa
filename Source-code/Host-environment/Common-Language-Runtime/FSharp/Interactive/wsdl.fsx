#r "nuget: FSharp.Data.WsdlProvider, 0.8.0-alpha"
#r "nuget: Microsoft.Extensions.Configuration"
#r "nuget: Microsoft.Extensions.Configuration.Json"
#r "nuget: Microsoft.Extensions.Configuration.UserSecrets"

#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Configuration.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Core.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\DotSpatial.Projections.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.AgencyDefined.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.AssetAnalysis.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.AssetValuation.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Building.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.DataExchngUtil.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Fleet.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.FleetMgmt.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.IndWaste.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.LCA.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Park.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Plant.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Railway.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Reservoir.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Risk.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Roadway.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Sewer.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.SolidWaste.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Storm.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Street.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.UsageArea.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.AssetManagement.Water.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Billing.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Budgeting.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Cashiering.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Building.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.BusinessLicense.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.CodeEnforcement.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Planning.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Project.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.TradeLicense.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CDR.Use.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Contract.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.AccessControl.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.AgencyVariables.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Attachments.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.AuditingTrail.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.BatchProcessing.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Configuration.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Correspondence.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.DataManagement.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.DataOutput.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Filter.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.FilterCode.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.HealthCheck.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.IO.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.License.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Metrics.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Migration.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.OAuth.OAuthUtils.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Proxies.Client.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Reporting.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Core.Security.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CRM.CallCentre.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.CRM.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.DynamicPortal.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.GIS.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.GISExtension.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Incident.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Inventory.MaterialsManagement.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Inventory.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.MetaData.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.MeterManagement.Water.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Planning.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Property.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.Resources.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.ResourcesManager.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.ResourcesManager.Scheduling.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.SolidWasteManagement.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen.WorkManagement.Proxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen8ClientProxies.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\HtmlSanitizationLibrary.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Infor.Authentication.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Infor.PublicSector.Core.FileSystemManagement.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Infor.PublicSector.Core.LocalTime.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Infor.Security.Cryptography.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\JsonPath.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Logging.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Metrics.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Microsoft.SqlServer.Types.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Newtonsoft.Json.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\ServiceStack.Common.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\ServiceStack.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\ServiceStack.Interfaces.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\ServiceStack.OrmLite.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\ServiceStack.Redis.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\ServiceStack.ServiceInterface.dll"
#r @"C:\Surfaces\Leon_County\OIT\MIS\Infor\Servers\InforProd\D\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\ServiceStack.Text.dll"



open System
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.Configuration.Json
open Microsoft.Extensions.Configuration.UserSecrets
open FSharp.Data
open System.ServiceModel

module Hansen =
    module Core =
        module Security =
            module Login =
                [<Literal>]
                let asmx_uri =
                    "https://infortest.leoncountyfl.gov/update_webservices/Core/Security/Hansen.Core.Security.Login.asmx"
                type asmx = WsdlProvider<asmx_uri>
                [<Literal>]
                let wsdl_uri =
                    "https://infortest.leoncountyfl.gov/update_webservices/Core/Security/Hansen.Core.Security.Login.asmx?WSDL"

                type wsdl = WsdlProvider<wsdl_uri>

// Build configuration from user secrets
let config =
    ConfigurationBuilder()
        .AddUserSecrets("b7ce3c90-6810-4193-a5bd-79c53bd74389")
        .Build()

let mutable ticket = String.Empty

let binding = new BasicHttpBinding(BasicHttpSecurityMode.None)

let endpoint =
    new EndpointAddress(Hansen.Core.Security.Login.wsdl_uri.Replace("https", "http"))

let loginClient =
    new Hansen.Core.Security.Login.wsdl.LoginSoapClient(binding, endpoint)

let serviceLogin = Hansen.Core.Security.Login.wsdl.ServiceLogin("Hansen8", config.["user"], config.["password"], ticket)


// let response = loginClient.ServiceLogin(serviceLogin)
