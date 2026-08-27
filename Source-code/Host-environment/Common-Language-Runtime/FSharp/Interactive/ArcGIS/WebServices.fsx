#time on 
fsi.ShowDeclarationValues <- true

open System
open System.IO
open System.Xml
open System
open System.Xml
open System.Xml.Linq
open System.Xml.Schema
open System.Xml.Serialization
open System.Xml.Linq


#r "nuget: FSharp.Compiler.Service, 43.10.102"

open FSharp.Compiler.Syntax
open FSharp.Compiler.Tokenization

#r "nuget:  Fabulous.AST"

open Fabulous.AST
open Fantomas.Core.SyntaxOak

open type Fabulous.AST.Ast


#r "nuget: FSharp.Data"
open FSharp.Data

#r "nuget: FsHttp"
open FsHttp



#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"
open PowershellErgonomics


#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\IriPathing.fsx"
open IriPathing

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\ArrayExtensions.fsx"
open ArrayExtensions

#r "nuget: FSharp.Compiler.Service, 43.10.102"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ParserCombinator\PrettierNaming.fsx"
#r @"C:\Repositories\appsdb\IPS_Sites\integration\SoapApi\obj\Release\net10.0\SoapApi.dll"
open Api.Soap

open PrettierNaming
open PrettierNaming.FSharp_Keywords








#I @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices\bin"

#r "Core.dll"
#r "Core.Data.dll"
#r "CoreObjects.dll"
#r "AssetManagement.dll"
#r "Storm.dll"
#r "Hansen.AssetManagement.AgencyDefined.WebServices.dll"
#r "Hansen.AssetManagement.AssetAnalysis.WebServices.dll"
#r "Hansen.AssetManagement.AssetValuation.WebServices.dll"
#r "Hansen.AssetManagement.Building.WebServices.dll"
#r "Hansen.AssetManagement.DataExchngUtil.WebServices.dll"
#r "Hansen.AssetManagement.Fleet.WebServices.dll"
#r "Hansen.AssetManagement.FleetManagement.WebServices.dll"
#r "Hansen.AssetManagement.IndWaste.WebServices.dll"
#r "Hansen.AssetManagement.LCA.WebServices.dll"
#r "Hansen.AssetManagement.Park.WebServices.dll"
#r "Hansen.AssetManagement.Plant.WebServices.dll"
#r "Hansen.AssetManagement.Railway.WebServices.dll"
#r "Hansen.AssetManagement.Reservoir.WebServices.dll"
#r "Hansen.AssetManagement.Risk.WebServices.dll"
#r "Hansen.AssetManagement.Roadway.WebServices.dll"
#r "Hansen.AssetManagement.Sewer.WebServices.dll"
#r "Hansen.AssetManagement.SolidWaste.WebServices.dll"
#r "Hansen.AssetManagement.Street.WebServices.dll"
#r "Hansen.AssetManagement.UsageArea.WebServices.dll"
#r "Hansen.AssetManagement.Water.WebServices.dll"
#r "Hansen.AssetManagement.WebServices.dll"
#r "Hansen.AutoComplete.ResultBase.dll"
#r "Hansen.Billing.FeatureToggles.dll"
#r "Hansen.Billing.WebServices.dll"
#r "Hansen.Budgeting.WebServices.dll"
#r "Hansen.Cashiering.WebServices.dll"
#r "Hansen.CDR.BuildingApplication.WebServices.dll"
#r "Hansen.CDR.BusinessLicense.WebServices.dll"
#r "Hansen.CDR.CodeEnforcement.WebServices.dll"
#r "Hansen.CDR.Planning.WebServices.dll"
#r "Hansen.CDR.Project.WebServices.dll"
#r "Hansen.CDR.TradeLicense.WebServices.dll"
#r "Hansen.CDR.Use.WebServices.dll"
#r "Hansen.CDR.WebServices.dll"
#r "Hansen.Contract.WebServices.dll"
#r "Hansen.Core.AccessControl.WebServices.dll"
#r "Hansen.Core.AgencyVariables.WebServices.dll"
#r "Hansen.Core.AppFarm.dll"
#r "Hansen.Core.ArchiveData.dll"
#r "Hansen.Core.Attachments.WebServices.dll"
#r "Hansen.Core.AuditingTrail.WebServices.dll"
#r "Hansen.Core.AWSUtil.dll"
#r "Hansen.Core.BatchManager.Client.dll"
#r "Hansen.Core.BatchManager.dll"
#r "Hansen.Core.BatchManager.Generation.dll"
#r "Hansen.Core.BatchManager.Models.dll"
#r "Hansen.Core.BatchManager.Shared.dll"
#r "Hansen.Core.BatchProcessing.WebServices.dll"
#r "Hansen.Core.ChangeNotification.dll"
#r "Hansen.Core.Cloud.Amazon.dll"
#r "Hansen.Core.Configuration.WebServices.dll"
#r "Hansen.Core.Correspondence.WebServices.dll"
#r "Hansen.Core.Data.Provider.ORACLECLIENT.dll"
#r "Hansen.Core.Data.Provider.ORACLEMANAGED.dll"
#r "Hansen.Core.Data.Provider.ORACLEODP.dll"
#r "Hansen.Core.Data.Provider.PostgreSql.dll"
#r "Hansen.Core.Data.Provider.SQLSRVR7.dll"
#r "Hansen.Core.DataLake.Integrations.dll"
#r "Hansen.Core.DataManagement.dll"
#r "Hansen.Core.DataManagement.WebServices.dll"
#r "Hansen.Core.DataOutput.WebServices.dll"
#r "Hansen.Core.FileTransfers.dll"
#r "Hansen.Core.Filter.WebServices.dll"
#r "Hansen.Core.FilterCode.WebServices.dll"
#r "Hansen.Core.HealthCheck.WebServices.dll"
#r "Hansen.Core.InforDocumentManagement.dll"
#r "Hansen.Core.IO.WebServices.dll"
#r "Hansen.Core.KeyStore.dll"
#r "Hansen.Core.KeyStore.Redis.dll"
#r "Hansen.Core.License.WebServices.dll"
#r "Hansen.Core.MessageBus.dll"
#r "Hansen.Core.MessageBus.Interfaces.dll"
#r "Hansen.Core.MessageBus.Redis.dll"
#r "Hansen.Core.Metrics.CloudWatch.dll"
#r "Hansen.Core.Metrics.dll"
#r "Hansen.Core.Metrics.Ips.dll"
#r "Hansen.Core.Migration.WebServices.dll"
#r "Hansen.Core.OAuth.OAuthUtils.dll"
#r "Hansen.Core.PingState.dll"
#r "Hansen.Core.Provisioning.Integrations.Core.dll"
#r "Hansen.Core.Provisioning.Integrations.DataLake.dll"
#r "Hansen.Core.Provisioning.Integrations.ION.dll"
#r "Hansen.Core.Reporting.WebServices.dll"
#r "Hansen.Core.ReportManagement.dll"
#r "Hansen.Core.ReportManagement.XmlSerializers.dll"
#r "Hansen.Core.RoleBasedFilters.WebServices.dll"
#r "Hansen.Core.Search.Ingestion.dll"
#r "Hansen.Core.Search.Shared.dll"
#r "Hansen.Core.Security.WebServices.dll"
#r "Hansen.Core.Snippets.WebServices.dll"
#r "Hansen.Core.WebServices.dll"
#r "Hansen.Core.WebServiceUtilities.dll"
#r "Hansen.CRM.CallCentre.WebServices.dll"
#r "Hansen.CRM.WebServices.dll"
#r "Hansen.DataDistribution.dll"
#r "Hansen.DataDistribution.XmlSerializers.dll"
#r "Hansen.Deployment.Common.dll"
#r "Hansen.Deployment.Logging.dll"
#r "Hansen.Deployment.Shared.dll"
#r "Hansen.DynamicPortal.WebServices.dll"
#r "Hansen.Extend.WebServices.dll"
#r "Hansen.GIS.Common.dll"
#r "Hansen.GIS.ConfigurationModels.dll"
#r "Hansen.GIS.Extensions.dll"
#r "Hansen.GIS.GISBase.dll"
#r "Hansen.GIS.ServiceModels.dll"
#r "Hansen.GIS.Services.dll"
#r "Hansen.GIS.WebServices.dll"
#r "Hansen.Incident.WebServices.dll"
#r "Hansen.Inventory.MaterialsManagement.WebServices.dll"
#r "Hansen.Inventory.WebServices.dll"
#r "Hansen.Lib.Common.EnterpriseLogging2.dll"
#r "Hansen.Lib.Common.Messaging.dll"
#r "Hansen.Lib.Common.Service.dll"
#r "Hansen.Lib.Common.Utility.dll"
#r "Hansen.Metadata.CodeGeneration.Core.dll"
#r "Hansen.Metadata.CodeGeneration.dll"
#r "Hansen.MetaData.CodeGeneration.Templates.Core.dll"
#r "Hansen.Metadata.CodeGeneration.Templates.dll"
#r "Hansen.MetaData.Repository.dll"
#r "Hansen.Metadata.ViewBridge.dll"
#r "Hansen.MetaData.WebServices.dll"
#r "Hansen.MeterManagement.Water.WebServices.dll"
#r "Hansen.Planning.WebServices.dll"
#r "Hansen.Property.WebServices.dll"
#r "Hansen.Resources.WebServices.dll"
#r "Hansen.ResourcesManager.Scheduling.WebServices.dll"
#r "Hansen.ResourcesManager.WebServices.dll"
#r "Hansen.SolidWasteManagement.WebServices.dll"
#r "Hansen.WebServices.dll"
#r "Hansen.WorkManagement.WebServices.dll"
#r "Infor.Amazon.KMS.dll"
#r "Infor.Authentication.dll"
#r "Infor.Core.Mapping.dll"
#r "Infor.GIS.ServiceContracts.dll"
#r "Infor.Http.dll"
#r "Infor.IO.dll"
#r "Infor.Mobile.Configuration.dll"
#r "Infor.PublicSector.AntiXss.dll"
#r "Infor.PublicSector.Contract.Data.GIS.dll"
#r "Infor.PublicSector.Contract.Transfer.AssetInspectionExchange.dll"
#r "Infor.PublicSector.Contract.Transfer.DataLake.dll"
#r "Infor.PublicSector.Contract.Transfer.DMT.dll"
#r "Infor.PublicSector.Contract.Transfer.GIS.dll"
#r "Infor.PublicSector.Core.FileSystemManagement.dll"
#r "Infor.PublicSector.Core.LocalTime.dll"
#r "Infor.PublicSector.DataLake.Common.dll"
#r "Infor.PublicSector.Engine.Common.DMT.dll"
#r "Infor.PublicSector.Engine.Compare.GIS.dll"
#r "Infor.PublicSector.Engine.Export.DataLake.dll"
#r "Infor.PublicSector.Engine.Export.DMT.dll"
#r "Infor.PublicSector.Engine.Export.GIS.dll"
#r "Infor.PublicSector.Engine.Import.DMT.dll"
#r "Infor.PublicSector.Engine.Import.GIS.dll"
#r "Infor.PublicSector.IFX.Common.dll"
#r "Infor.PublicSector.IFX.Common.GIS.dll"
#r "Infor.PublicSector.IFX.Common.IPS.dll"
#r "Infor.PublicSector.IFX.Contract.dll"
#r "Infor.PublicSector.IFX.Proxy.dll"
#r "Infor.PublicSector.IFX.Server.dll"
#r "Infor.PublicSector.Manager.Data.GIS.dll"
#r "Infor.PublicSector.Manager.Transfer.AssetInspectionExchange.dll"
#r "Infor.PublicSector.Manager.Transfer.DataLake.dll"
#r "Infor.PublicSector.Manager.Transfer.GIS.dll"
#r "Infor.PublicSector.Proxy.Data.GIS.dll"
#r "Infor.PublicSector.Proxy.Transfer.AssetInspectionExchange.dll"
#r "Infor.PublicSector.Proxy.Transfer.DataLake.dll"
#r "Infor.PublicSector.Proxy.Transfer.GIS.dll"
#r "Infor.PublicSector.ResourceAccess.GIS.dll"
#r "Infor.PublicSector.ResourceAccess.IPS.GIS.dll"
#r "Infor.PublicSector.ResourceAccess.SessionData.DMT.dll"
#r "Infor.PublicSector.ResourceAccess.Shared.dll"
#r "Infor.PublicSector.ResourceAccess.Support.DMT.dll"
#r "Infor.PublicSector.ResourceAccess.SystemData.DMT.dll"
#r "Infor.PublicSector.Rest.Services.Core.Models.dll"
#r "Infor.PublicSector.Rest.Subsystem.Framework.dll"
#r "Infor.PublicSector.Services.Core.Provision.Models.dll"
#r "Infor.PublicSector.Services.GIS.Models.dll"
#r "Infor.PublicSector.Utility.Common.dll"
#r "Infor.PublicSector.Utility.Contract.Configuration.GIS.dll"
#r "Infor.PublicSector.Utility.Contract.Log.dll"
#r "Infor.PublicSector.Utility.Manager.Configuration.GIS.dll"
#r "Infor.PublicSector.Utility.Manager.Log.dll"
#r "Infor.PublicSector.Utility.Proxy.Configuration.GIS.dll"
#r "Infor.PublicSector.Utility.Proxy.Log.dll"
#r "Infor.PublicSector.Utility.ResourceAccess.SessionData.DataLake.dll"
#r "Infor.PublicSector.Utility.ResourceAccess.SystemData.DataLake.dll"
#r "Infor.Reflection.dll"
#r "Infor.Reflection.ObjectIteration.dll"
#r "Infor.Reporting.Birst.Client.dll"
#r "Infor.RestServices.Documentation.Api.dll"
#r "Infor.Security.Cryptography.dll"
#r "Infor.SessionStateProvider.dll"
#r "Infor.Xml.dll"
#r "InforUserAnalytics.dll"
#I @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies"


#r "Core.dll"
#r "Hansen.AssetManagement.Storm.Proxies.dll"
#r "Hansen.AssetManagement.AgencyDefined.Proxies.dll"
#r "Hansen.AssetManagement.AssetAnalysis.Proxies.dll"
#r "Hansen.AssetManagement.AssetValuation.Proxies.dll"
#r "Hansen.AssetManagement.Building.Proxies.dll"
#r "Hansen.AssetManagement.DataExchngUtil.Proxies.dll"
#r "Hansen.AssetManagement.Fleet.Proxies.dll"
#r "Hansen.AssetManagement.FleetMgmt.Proxies.dll"
#r "Hansen.AssetManagement.IndWaste.Proxies.dll"
#r "Hansen.AssetManagement.LCA.Proxies.dll"
#r "Hansen.AssetManagement.Park.Proxies.dll"
#r "Hansen.AssetManagement.Plant.Proxies.dll"
#r "Hansen.AssetManagement.Proxies.dll"
#r "Hansen.AssetManagement.Railway.Proxies.dll"
#r "Hansen.AssetManagement.Reservoir.Proxies.dll"
#r "Hansen.AssetManagement.Risk.Proxies.dll"
#r "Hansen.AssetManagement.Roadway.Proxies.dll"
#r "Hansen.AssetManagement.Sewer.Proxies.dll"
#r "Hansen.AssetManagement.SolidWaste.Proxies.dll"
#r "Hansen.AssetManagement.Street.Proxies.dll"
#r "Hansen.AssetManagement.UsageArea.Proxies.dll"
#r "Hansen.AssetManagement.Water.Proxies.dll"
#r "Hansen.Billing.Proxies.dll"
#r "Hansen.Budgeting.Proxies.dll"
#r "Hansen.Cashiering.Proxies.dll"
#r "Hansen.CDR.Building.Proxies.dll"
#r "Hansen.CDR.BusinessLicense.Proxies.dll"
#r "Hansen.CDR.CodeEnforcement.Proxies.dll"
#r "Hansen.CDR.Planning.Proxies.dll"
#r "Hansen.CDR.Project.Proxies.dll"
#r "Hansen.CDR.Proxies.dll"
#r "Hansen.CDR.TradeLicense.Proxies.dll"
#r "Hansen.CDR.Use.Proxies.dll"
#r "Hansen.Contract.Proxies.dll"
#r "Hansen.Core.AccessControl.Proxies.dll"
#r "Hansen.Core.AgencyVariables.Proxies.dll"
#r "Hansen.Core.Attachments.Proxies.dll"
#r "Hansen.Core.AuditingTrail.Proxies.dll"
#r "Hansen.Core.BatchProcessing.Proxies.dll"
#r "Hansen.Core.Configuration.Proxies.dll"
#r "Hansen.Core.Correspondence.Proxies.dll"
#r "Hansen.Core.DataManagement.Proxies.dll"
#r "Hansen.Core.DataOutput.Proxies.dll"
#r "Hansen.Core.Filter.Proxies.dll"
#r "Hansen.Core.FilterCode.Proxies.dll"
#r "Hansen.Core.HealthCheck.Proxies.dll"
#r "Hansen.Core.IO.Proxies.dll"
#r "Hansen.Core.License.Proxies.dll"
#r "Hansen.Core.Metrics.dll"
#r "Hansen.Core.Migration.Proxies.dll"
#r "Hansen.Core.OAuth.OAuthUtils.dll"
#r "Hansen.Core.Proxies.Client.dll"
#r "Hansen.Core.Proxies.dll"
#r "Hansen.Core.Reporting.Proxies.dll"
#r "Hansen.Core.Security.Proxies.dll"
#r "Hansen.CRM.CallCentre.Proxies.dll"
#r "Hansen.CRM.Proxies.dll"
#r "Hansen.DynamicPortal.Proxies.dll"
#r "Hansen.GIS.Proxies.dll"
#r "Hansen.GISExtension.Proxies.dll"
#r "Hansen.Incident.Proxies.dll"
#r "Hansen.Inventory.MaterialsManagement.Proxies.dll"
#r "Hansen.Inventory.Proxies.dll"
#r "Hansen.MetaData.Proxies.dll"
#r "Hansen.MeterManagement.Water.Proxies.dll"
#r "Hansen.Planning.Proxies.dll"
#r "Hansen.Property.Proxies.dll"
#r "Hansen.Resources.Proxies.dll"
#r "Hansen.ResourcesManager.Proxies.dll"
#r "Hansen.ResourcesManager.Scheduling.Proxies.dll"
#r "Hansen.SolidWasteManagement.Proxies.dll"
#r "Hansen.WorkManagement.Proxies.dll"
#r "Hansen8ClientProxies.dll"

#r "Infor.Authentication.dll"
#r "Infor.PublicSector.Core.FileSystemManagement.dll"
#r "Infor.PublicSector.Core.LocalTime.dll"
#r "Infor.Security.Cryptography.dll"


#r "Messaging.dll"
#r "MetaData.dll"

#r "Employee.dll"

#r "CustomerService.dll"

#r "DataCatalog.Client.dll"
#r "DataCatalog.Shared.dll"
#r "DataExchngUtil.dll"
#r "DataInput.dll"
#r "DataLake.dll"
#r "DataOutput.dll"
#r "DefinitionManager.dll"

#r "BusinessLicense.dll"
#r "BusinessLicenseApplet.dll"
#r "CalendarManagement.dll"
#r "CallCentre.dll"
#r "Core.Data.dll"
#r "Core.dll"
#r "Core.Net.dll"
#r "Core.Views.dll"
#r "CoreObjects.dll"
#r "Correspondence.dll"
#r "CRMApplet.dll"
#r "CRMCodeDefinition.dll"
#r "crystaldecisions.crystalreports.engine.dll"
#r "CrystalDecisions.ReportAppServer.ClientDoc.dll"
#r "CrystalDecisions.ReportAppServer.CommLayer.dll"
#r "CrystalDecisions.ReportAppServer.CommonControls.dll"
#r "CrystalDecisions.ReportAppServer.CommonObjectModel.dll"
#r "CrystalDecisions.ReportAppServer.Controllers.dll"
#r "CrystalDecisions.ReportAppServer.CubeDefModel.dll"
#r "CrystalDecisions.ReportAppServer.DataDefModel.dll"
#r "CrystalDecisions.ReportAppServer.DataSetConversion.dll"
#r "CrystalDecisions.ReportAppServer.ObjectFactory.dll"
#r "CrystalDecisions.ReportAppServer.ReportDefModel.dll"
#r "CrystalDecisions.ReportAppServer.XmlSerialize.dll"
#r "CrystalDecisions.ReportSource.dll"
#r "crystaldecisions.shared.dll"
#r "crystaldecisions.web.dll"



open Hansen.AssetManagement.Storm




























module MSBuild = 
  let Project = 
    """
    
<Project Sdk="Microsoft.NET.Sdk">

	<PropertyGroup>
		<OutputType>Library</OutputType>
		<TargetFramework>net10.0</TargetFramework>
	</PropertyGroup>

	<ItemGroup>
		<Compile Include="*.fs" />
	</ItemGroup>

	<ItemGroup>
		<PackageReference Include="FSharp.Data" Version="8.1.14" />
		<PackageReference Include="FSharp.Data.WsdlProvider" Version="0.8.0-alpha" />
	</ItemGroup>
	<ItemGroup>
          <Reference Include="SoapApi">
            <HintPath>C:\Repositories\appsdb\IPS_Sites\integration\SoapApi\obj\Release\net10.0\SoapApi.dll</HintPath>
          </Reference>

	</ItemGroup>

	<ItemGroup>
		<Reference Include="Core">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Core.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Storm.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Storm.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.AgencyDefined.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.AgencyDefined.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.AssetAnalysis.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.AssetAnalysis.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.AssetValuation.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.AssetValuation.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Building.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Building.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.DataExchngUtil.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.DataExchngUtil.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Fleet.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Fleet.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.FleetMgmt.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.FleetMgmt.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.IndWaste.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.IndWaste.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.LCA.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.LCA.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Park.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Park.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Plant.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Plant.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Railway.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Railway.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Reservoir.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Reservoir.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Risk.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Risk.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Roadway.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Roadway.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Sewer.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Sewer.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.SolidWaste.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.SolidWaste.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Street.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Street.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.UsageArea.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.UsageArea.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.AssetManagement.Water.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.AssetManagement.Water.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Billing.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Billing.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Budgeting.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Budgeting.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Cashiering.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Cashiering.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CDR.Building.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CDR.Building.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CDR.BusinessLicense.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CDR.BusinessLicense.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CDR.CodeEnforcement.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CDR.CodeEnforcement.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CDR.Planning.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CDR.Planning.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CDR.Project.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CDR.Project.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CDR.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CDR.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CDR.TradeLicense.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CDR.TradeLicense.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CDR.Use.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CDR.Use.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Contract.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Contract.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.AccessControl.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.AccessControl.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.AgencyVariables.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.AgencyVariables.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Attachments.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Attachments.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.AuditingTrail.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.AuditingTrail.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.BatchProcessing.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.BatchProcessing.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Configuration.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Configuration.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Correspondence.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Correspondence.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.DataManagement.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.DataManagement.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.DataOutput.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.DataOutput.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Filter.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Filter.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.FilterCode.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.FilterCode.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.HealthCheck.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.HealthCheck.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.IO.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.IO.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.License.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.License.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Metrics">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Metrics.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Migration.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Migration.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.OAuth.OAuthUtils">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.OAuth.OAuthUtils.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Proxies.Client">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Proxies.Client.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Reporting.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Reporting.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Core.Security.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Core.Security.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CRM.CallCentre.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CRM.CallCentre.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.CRM.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.CRM.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.DynamicPortal.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.DynamicPortal.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.GIS.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.GIS.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.GISExtension.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.GISExtension.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Incident.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Incident.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Inventory.MaterialsManagement.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Inventory.MaterialsManagement.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Inventory.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Inventory.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.MetaData.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.MetaData.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.MeterManagement.Water.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.MeterManagement.Water.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Planning.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Planning.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Property.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Property.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.Resources.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.Resources.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.ResourcesManager.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.ResourcesManager.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.ResourcesManager.Scheduling.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.ResourcesManager.Scheduling.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.SolidWasteManagement.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.SolidWasteManagement.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen.WorkManagement.Proxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen.WorkManagement.Proxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Hansen8ClientProxies">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Hansen8ClientProxies.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Infor.Authentication">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Infor.Authentication.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Infor.PublicSector.Core.FileSystemManagement">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Infor.PublicSector.Core.FileSystemManagement.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Infor.PublicSector.Core.LocalTime">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Infor.PublicSector.Core.LocalTime.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Infor.Security.Cryptography">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Infor.Security.Cryptography.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Messaging">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Messaging.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="MetaData">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\MetaData.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Employee">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Employee.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CustomerService">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CustomerService.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="DataCatalog.Client">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\DataCatalog.Client.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="DataCatalog.Shared">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\DataCatalog.Shared.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="DataExchngUtil">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\DataExchngUtil.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="DataInput">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\DataInput.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="DataLake">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\DataLake.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="DataOutput">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\DataOutput.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="DefinitionManager">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\DefinitionManager.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="BusinessLicense">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\BusinessLicense.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="BusinessLicenseApplet">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\BusinessLicenseApplet.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CalendarManagement">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CalendarManagement.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CallCentre">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CallCentre.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Core.Data">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Core.Data.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Core">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Core.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Core.Net">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Core.Net.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Core.Views">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Core.Views.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CoreObjects">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CoreObjects.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="Correspondence">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\Correspondence.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CRMApplet">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CRMApplet.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CRMCodeDefinition">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CRMCodeDefinition.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="crystaldecisions.crystalreports.engine">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\crystaldecisions.crystalreports.engine.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.ClientDoc">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.ClientDoc.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.CommLayer">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.CommLayer.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.CommonControls">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.CommonControls.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.CommonObjectModel">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.CommonObjectModel.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.Controllers">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.Controllers.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.CubeDefModel">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.CubeDefModel.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.DataDefModel">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.DataDefModel.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.DataSetConversion">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.DataSetConversion.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.ObjectFactory">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.ObjectFactory.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.ReportDefModel">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.ReportDefModel.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportAppServer.XmlSerialize">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportAppServer.XmlSerialize.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="CrystalDecisions.ReportSource">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\CrystalDecisions.ReportSource.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="crystaldecisions.shared">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\crystaldecisions.shared.dll</HintPath>
		</Reference>
	</ItemGroup>

	<ItemGroup>
		<Reference Include="crystaldecisions.web">
			<HintPath>C:\Repositories\appsdb\IPS_Sites\integration\dynamic_linked_libraries\ClientProxies\crystaldecisions.web.dll</HintPath>
		</Reference>
	</ItemGroup>

</Project>

    """





module Wsdl =
    let private xsd =
        XNamespace.Get "http://www.w3.org/2001/XMLSchema"
    let private wsdl =
        XNamespace.Get "http://schemas.xmlsoap.org/wsdl/"

    let private soap_1_1 =
        XNamespace.Get "http://schemas.xmlsoap.org/wsdl/soap/"

    let private soap_1_2 =
        XNamespace.Get "http://schemas.xmlsoap.org/wsdl/soap12/"
    
    let private schema_importer
        (definitions: XElement)
        =
        let validation_handler =
            ValidationEventHandler(fun _ arguments ->
                if arguments.Severity = XmlSeverityType.Error then
                    raise arguments.Exception
            )

        let schemas =
            XmlSchemas()

        definitions.Elements(wsdl + "types")
        |> Seq.collect (fun types ->
            types.Elements(xsd + "schema")
        )
        |> Seq.iter (fun schema_element ->
            use reader =
                schema_element.CreateReader()

            let schema =
                XmlSchema.Read(
                    reader,
                    validation_handler
                )

            if isNull schema then
                failwith
                    "XmlSchema.Read returned no schema."

            schemas.Add(schema)
            |> ignore
        )

        schemas.Compile(
            validation_handler,
            true
        )

        XmlSchemaImporter(schemas)



    let private try_attribute
        (name: string)
        (element: XElement)
        =
        let attribute =
            element.Attribute(XName.Get name)

        if isNull attribute then
            None
        else
            Some attribute.Value

    let private attribute
        (name: string)
        (element: XElement)
        =
        match try_attribute name element with
        | Some value ->
            value
        | None ->
            failwithf
                "Element %O does not have the required attribute %s."
                element.Name
                name

    let private local_name (qualified_name: string) =
        let separator =
            qualified_name.IndexOf(':')

        if separator = -1 then
            qualified_name
        else
            qualified_name.Substring(separator + 1)

    let private child_name
        (child_name: XName)
        (parent: XElement)
        =
        let child =
            parent.Element(child_name)

        if isNull child then
            None
        else
            try_attribute "name" child

    let private exactly_one
        (description: string)
        (values: seq<'value>)
        =
        match values |> Seq.toArray with
        | [| value |] ->
            value

        | [||] ->
            failwithf "No %s was found." description

        | values ->
            failwithf
                "Expected one %s, but found %i."
                description
                values.Length


    let private resolve_qualified_name
        (context: XElement)
        (lexical_name: string)
        =
        let separator =
            lexical_name.IndexOf(':')

        let prefix, local_name =
            if separator = -1 then
                String.Empty,
                lexical_name
            else
                lexical_name.Substring(0, separator),
                lexical_name.Substring(separator + 1)

        let namespace_name =
            if String.IsNullOrEmpty prefix then
                context.GetDefaultNamespace()
            else
                context.GetNamespaceOfPrefix(prefix)

        if isNull namespace_name then
            failwithf
                "Cannot resolve QName '%s' on element %O."
                lexical_name
                context.Name

        XmlQualifiedName(
            local_name,
            namespace_name.NamespaceName
        )

    let private resolve_parameter_type
        (parameter_element: XElement)
        (mapping: XmlMemberMapping)
        =
        let schema_type_name =
            try_attribute "type" parameter_element
            |> Option.map (
                resolve_qualified_name parameter_element
            )

        let dotnet_type_name =
            match schema_type_name with
            | Some schema_type
                when schema_type.Namespace
                     = "http://www.w3.org/2001/XMLSchema" ->

                // For xs:string, xs:int, xs:dateTime, etc.,
                // XmlSchemaImporter gives the correct CLR type.
                mapping.TypeFullName

            // Infor uses actual CLR full names as these XSD type names.
            | Some schema_type
                when schema_type.Name.StartsWith(
                    "Hansen.",
                    StringComparison.Ordinal
                ) ->

                schema_type.Name

            // Named schema helper types such as ArrayOfString.
            // Let XmlSchemaImporter determine their CLR representation.
            | Some _ ->
                mapping.TypeFullName

            // Anonymous inline simple/complex types.
            | None ->
                mapping.TypeFullName
        schema_type_name,
        dotnet_type_name

    let operations (wsdl_file_path: string) =
        let document =
            XDocument.Load wsdl_file_path

        let definitions =
            document.Root

        if isNull definitions then
            failwith "The WSDL document has no root element."
        let target_namespace =
            definitions
            |> attribute "targetNamespace"

        let importer =
            schema_importer definitions


        let binding, soap_namespace =
            definitions.Elements(wsdl + "binding")
            |> Seq.choose (fun candidate ->
                if not (isNull (candidate.Element(soap_1_1 + "binding"))) then
                    Some (candidate, soap_1_1)

                elif not (isNull (candidate.Element(soap_1_2 + "binding"))) then
                    Some (candidate, soap_1_2)

                else
                    None
            )
            |> exactly_one "SOAP binding"

        let port_type_name =
            binding
            |> attribute "type"
            |> local_name

        let port_type =
            definitions.Elements(wsdl + "portType")
            |> Seq.filter (fun candidate ->
                attribute "name" candidate = port_type_name
            )
            |> exactly_one $"port type {port_type_name}"

        let port_type_operations =
            port_type.Elements(wsdl + "operation")
            |> Seq.toArray

        let messages =
            definitions.Elements(wsdl + "message")
            |> Seq.toArray

        let global_schema_elements =
            definitions.Elements(wsdl + "types")
            |> Seq.collect (fun types ->
                types.Elements(xsd + "schema")
            )
            |> Seq.collect (fun schema ->
                schema.Elements(xsd + "element")
            )
            |> Seq.toArray
        binding.Elements(wsdl + "operation")
        |> Seq.map (fun binding_operation ->

            let operation_name =
                attribute "name" binding_operation

            let binding_input_name =
                child_name
                    (wsdl + "input")
                    binding_operation

            let binding_output_name =
                child_name
                    (wsdl + "output")
                    binding_operation

            let matching_port_type_operation =
                port_type_operations
                |> Seq.filter (fun port_type_operation ->

                    let same_operation_name =
                        attribute
                            "name"
                            port_type_operation = operation_name

                    let same_input_name =
                        match binding_input_name with
                        | None ->
                            true

                        | Some expected ->
                            child_name
                                (wsdl + "input")
                                port_type_operation = Some expected

                    let same_output_name =
                        match binding_output_name with
                        | None ->
                            true

                        | Some expected ->
                            child_name
                                (wsdl + "output")
                                port_type_operation = Some expected

                    same_operation_name
                    && same_input_name
                    && same_output_name
                )
                |> exactly_one
                    $"port-type operation {operation_name}"

            let input =
                matching_port_type_operation.Element(
                    wsdl + "input"
                )

            if isNull input then
                failwithf
                    "Operation %s has no input."
                    operation_name

            let message_name =
                input
                |> attribute "message"
                |> local_name

            let message =
                messages
                |> Seq.filter (fun candidate ->
                    attribute "name" candidate = message_name
                )
                |> exactly_one $"message {message_name}"

            let part =
                message.Elements(wsdl + "part")
                |> exactly_one
                    $"part of message {message_name}"

            let document_element_name =
                part
                |> attribute "element"
                |> local_name
                
            let document_element_qualified_name =
                XmlQualifiedName(
                    document_element_name,
                    target_namespace
                )

            let member_mappings =
                importer.ImportMembersMapping(
                    document_element_qualified_name
                )



            let document_element =
                global_schema_elements
                |> Seq.filter (fun candidate ->
                    attribute "name" candidate = document_element_name
                )
                |> exactly_one
                    $"document element {document_element_name}"
            let source_parameter_elements =
                document_element.Element(xsd + "complexType")
                |> Option.ofObj
                |> Option.bind (fun complex_type ->
                    complex_type.Element(xsd + "sequence")
                    |> Option.ofObj
                )
                |> Option.map (fun sequence ->
                    sequence.Elements(xsd + "element")
                    |> Seq.toArray
                )
                |> Option.defaultValue [||]


            let source_parameters_by_name =
                source_parameter_elements
                |> Array.map (fun parameter_element ->
                    let parameter_name =
                        match
                            try_attribute "name" parameter_element,
                            try_attribute "ref" parameter_element
                        with
                        | Some name, _ ->
                            name

                        | None, Some reference ->
                            local_name reference

                        | None, None ->
                            failwithf
                                "A parameter in document element '%s' has neither name nor ref."
                                document_element_name

                    parameter_name,
                    parameter_element
                )
                |> Map.ofArray

            let parameters =
                [|
                    for index in 0 .. member_mappings.Count - 1 do
                        let mapping =
                            member_mappings[index]

                        let parameter_name =
                            mapping.XsdElementName


                        let source_parameter =
                            match
                                source_parameters_by_name
                                |> Map.tryFind parameter_name
                            with
                            | Some source_parameter ->
                                source_parameter

                            | None ->
                                failwithf
                                    "The imported parameter '%s' could not be matched to a source parameter in document element '%s' for operation '%s'."
                                    parameter_name
                                    document_element_name
                                    operation_name

                        let schema_type_name, dotnet_type_name =
                            resolve_parameter_type
                                source_parameter
                                mapping

                        if String.IsNullOrWhiteSpace dotnet_type_name then
                            failwithf
                                "The schema importer returned no .NET type for parameter '%s' in operation '%s'."
                                parameter_name
                                operation_name

                                
                        let minimum_occurrences =
                              try_attribute
                                  "minOccurs"
                                  source_parameter
                              |> Option.defaultValue "1"
                        let maximum_occurrences =
                            try_attribute
                                "maxOccurs"
                                source_parameter
                            |> Option.defaultValue "1"

                        yield
                            {
                                parameter_name =
                                    parameter_name

                                dotnet_type_name =
                                    dotnet_type_name
                                schema_type_name = schema_type_name

                                minimum_occurrences =
                                    minimum_occurrences

                                maximum_occurrences =
                                    maximum_occurrences
                            }
                |]

            let soap_operation =
                binding_operation.Element(
                    soap_namespace + "operation"
                )
            if isNull soap_operation then
                failwithf
                    "Operation %s has no SOAP 1.1 binding."
                    operation_name

            let soap_action =
                attribute
                    "soapAction"
                    soap_operation

            {
                operation_name =
                    operation_name

                input_name =
                    binding_input_name

                message_name =
                    message_name

                document_element_name =
                    document_element_name

                soap_action =
                    soap_action

                parameters =
                    parameters
            }
        )
        |> Seq.toArray



let rec fsharp_type_name_from_dotnet
    (dotnet_type_name: string)
    =
    match dotnet_type_name with
    | "System.String" ->
        "string"

    | "System.Boolean" ->
        "bool"

    | "System.Byte" ->
        "byte"

    | "System.SByte" ->
        "sbyte"

    | "System.Int16" ->
        "int16"

    | "System.Int32" ->
        "int"

    | "System.Int64" ->
        "int64"

    | "System.UInt16" ->
        "uint16"

    | "System.UInt32" ->
        "uint"

    | "System.UInt64" ->
        "uint64"

    | "System.Single" ->
        "float32"

    | "System.Double" ->
        "float"

    | "System.Decimal" ->
        "decimal"

    | "System.DateTime" ->
        "DateTime"

    | "System.TimeSpan" ->
        "TimeSpan"

    | "System.Guid" ->
        "Guid"

    | "System.Object" ->
        "obj"

    | "System.Xml.XmlElement" ->
        "System.Xml.XmlElement"

    | "System.Xml.XmlNode" ->
        "System.Xml.XmlNode"

    | "System.Data.DataSet" ->
        "System.Data.DataSet"

    | type_name
        when type_name.EndsWith(
            "[]",
            StringComparison.Ordinal
        ) ->

        let element_type_name =
            type_name.Substring(
                0,
                type_name.Length - 2
            )

        let element_fsharp_type =
            fsharp_type_name_from_dotnet
                element_type_name

        $"{element_fsharp_type} array"

    | type_name ->
        // CLR nested types use '+'. F# source uses '.'.
        type_name.Replace('+', '.')


let fsharp_type_name
    (parameter: Wsdl_Parameter)
    =
    fsharp_type_name_from_dotnet
        parameter.dotnet_type_name







let wsdl_namespace =
    XNamespace.Get "http://schemas.xmlsoap.org/wsdl/"

let xsd_namespace =
    XNamespace.Get "http://www.w3.org/2001/XMLSchema"

let import_parameter_mappings
    (wsdl_file_path: string)
    (document_element_name: string)
    =
    let document =
        XDocument.Load wsdl_file_path

    let definitions =
        document.Root

    if isNull definitions then
        failwith "The WSDL document has no definitions element."

    let target_namespace_attribute =
        definitions.Attribute(
            XName.Get "targetNamespace"
        )

    if isNull target_namespace_attribute then
        failwith "The WSDL has no targetNamespace."

    let target_namespace =
        target_namespace_attribute.Value

    let validation_handler =
        ValidationEventHandler(fun _ arguments ->
            failwith arguments.Message
        )

    let schemas =
        XmlSchemas()

    definitions.Elements(wsdl_namespace + "types")
    |> Seq.collect (fun types ->
        types.Elements(xsd_namespace + "schema")
    )
    |> Seq.iter (fun schema_element ->
        use reader =
            schema_element.CreateReader()

        let schema =
            XmlSchema.Read(
                reader,
                validation_handler
            )

        schemas.Add(schema)
        |> ignore
    )

    schemas.Compile(
        validation_handler,
        true
    )

    let importer =
        XmlSchemaImporter(schemas)

    let wrapper_name =
        XmlQualifiedName(
            document_element_name,
            target_namespace
        )

    let members =
        importer.ImportMembersMapping(wrapper_name)

    [|
        for index in 0 .. members.Count - 1 do
            let member_mapping =
                members[index]

            yield
                member_mapping.XsdElementName,
                member_mapping.TypeFullName,
                member_mapping.Any,
                member_mapping.CheckSpecified
    |]










































































module WebServices = 
  let local_directory = new DirectoryInfo @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\WebServices"
  let project_directory = new DirectoryInfo @"C:\Repositories\appsdb\IPS_Sites\integration\WebServices"
  let test_uri = new Uri "https://infortest.leoncountyfl.gov/update_webservices"

type Web_Service = 
  {
    local_wsdl:FileInfo
    local_asmx:FileInfo
    moniker:string
    tokens:string array
    relative_path:string
    remote_asmx:Uri
    remote_wsdl:Uri
    local_fs:FileInfo

  }
  member this.fs_text = 
      let document =
          XDocument.Load this.local_wsdl.FullName


      let local_name (qualified_name: string) =
          match qualified_name.IndexOf(':') with
          | -1 ->
              qualified_name
          | index ->
              qualified_name[(index + 1)..]

      let final_name_segment (name: string) =
          match name.LastIndexOf('.') with
          | -1 ->
              name
          | index ->
              name[(index + 1)..]

      let fsharp_string_literal
          (value: string)
          =
          sprintf "%A" value

      let document_expression
          (operation: Wsdl_Operation)
          =
          let arguments =
              if Array.isEmpty operation.parameters then
                  "()"
              else
                  operation.parameters
                  |> Array.map (fun parameter ->
                      $"({parameter.parameter_name}: {fsharp_type_name parameter})"
                  )
                  |> String.concat " "

          let parameter_expressions =
              operation.parameters
              |> Array.map (fun parameter ->
                  let parameter_name =
                      fsharp_string_literal parameter.parameter_name

                  $"Soap.parameter target_namespace {parameter_name} {parameter.parameter_name}"
              )
              |> String.concat ";\n                    "

          $"""fun {arguments} ->
          Soap.document_document
              target_namespace
              document_element_name
              [
                  {parameter_expressions}
              ]"""

      
      let target_namespace =
          let document =
              XDocument.Load( Uri(this.local_wsdl.FullName).OriginalString )

          document.Root
              .Attribute(XName.Get "targetNamespace")
              .Value

      Oak() {
        let namespace_binding = this.tokens[0..this.tokens.Length - 2] |> String.concat "."
        let module_binding = this.moniker + "Service"
        let url = "url"
        let uri = "uri"
        let remote_wsdl = "remote_wsdl"
        let file_path = "file_path"
        let file = "file"
        Namespace(module_binding) {
                  Open("System")
                  Open("System.IO")
                  Open("System.Xml.Serialization")
                  Open("Hansen.Core.WebServiceUtilities")
                  Open(namespace_binding)
                  Open("FSharp.Data")
                  Open("Api")
                  Value("moniker", Ast.String(this.moniker))

                  Value( url, Ast.String( this.remote_asmx.OriginalString ) ).attribute(Attribute("Literal"))
                  Value( uri, $"new Uri({url})" )
                  Value( file_path, Ast.String( this.local_wsdl.FullName ) ) .attribute(Attribute("Literal"))
                  Value( file, $"new FileInfo({file_path})" )
                  Value( "target_namespace", Ast.String(target_namespace) ) .attribute(Attribute("Literal"))

                  for operation in this.operations do
                      let module_name =
                          operation.document_element_name.Replace(
                              $"{this.moniker}_",
                              ""
                          )

                      Module(module_name) {
                          Value( "operation_name", Ast.String(operation.operation_name) ) 
                          Value( "message_name", Ast.String(operation.message_name) ) 
                          Value( "document_element_name", Ast.String( operation.document_element_name ) ) 
                          Value( "soap_action", Ast.String(operation.soap_action) ) 
                          Value( "document", document_expression operation )
                      }
              

                }|> _.toImplicit()
            }
            |> Gen.mkOak
            |> Gen.run
  member this.save_fs() = 
    if not this.local_fs.Exists then
      Directory.CreateDirectory(this.local_fs.DirectoryName) |> ignore
    File.WriteAllText(this.local_fs.FullName,this.fs_text)
  member this.operations = Wsdl.operations this.local_wsdl.FullName


let web_services = 
  Directory.GetFiles(WebServices.local_directory.FullName,"*.wsdl",SearchOption.AllDirectories)
  |> Array.Parallel.map (fun wsdl_path -> 
  
    let local_wsdl = new FileInfo(wsdl_path) 
    let moniker = Path.GetFileNameWithoutExtension(local_wsdl.FullName) 
    let tokens = moniker.Split('.',StringSplitOptions.RemoveEmptyEntries) 
    let local_asmx = Path.ChangeExtension(local_wsdl.FullName,".asmx") |> FileInfo 
    let relative_path = Path.GetRelativePath(WebServices.local_directory.FullName, local_asmx.FullName) 
    let remote_asmx = new Uri(sprintf "%s/%s" WebServices.test_uri.OriginalString (relative_path.Replace("\\","/"))) 
    let remote_wsdl = new Uri(sprintf "%s?WSDL" remote_asmx.OriginalString) 
    let local_fs = Path.ChangeExtension(Path.Combine(WebServices.project_directory.FullName,"Hansen",relative_path),".fs") |> FileInfo
    {
      local_wsdl = local_wsdl
      moniker = moniker
      tokens = tokens
      local_asmx = local_asmx
      relative_path = relative_path
      remote_asmx = remote_asmx
      remote_wsdl = remote_wsdl
      local_fs = local_fs

    }

  )




let xsd =
    XNamespace.Get "http://www.w3.org/2001/XMLSchema"

let find_document_parameter
    (wsdl_file_path: string)
    (document_element_name: string)
    (parameter_name: string)
    =
    let document =
        XDocument.Load(wsdl_file_path)

    document.Descendants(xsd + "element")
    |> Seq.find (fun element ->
        let name =
            element.Attribute(XName.Get "name")

        not (isNull name)
        && name.Value = document_element_name
    )
    |> fun document_element ->
        document_element.Descendants(xsd + "element")
        |> Seq.find (fun element ->
            let name =
                element.Attribute(XName.Get "name")

            not (isNull name)
            && name.Value = parameter_name
        )





web_services
|> Array.Parallel.map (fun web_service -> web_service.local_fs.Directory)
|> Array.distinct
|> Array.iter (fun directory -> 
  let project_path = Path.Combine(directory.FullName,$"{directory.Name}.fsproj")
  File.WriteAllText(project_path, MSBuild.Project)
  )








// let test_web_service = web_services |> Array.find (fun web_service -> web_service.moniker = "Hansen.AssetManagement.Storm.StormInlet")




// test_web_service.save_fs()



web_services |> Array.Parallel.iter (fun web_service -> web_service.save_fs())





































