#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false
// fsi.ShowDeclarationValues <- true

open System
open System.Xml.Linq
open System.IO
open System.Globalization

open System.Xml
open System.Xml.Linq
open System.Xml.XPath
open System.Xml.Serialization
open System.Xml.Schema
#r "nuget: FSharp.Data"
open FSharp.Data
#r "nuget: FsExcel"
open FsExcel

#r "nuget: Esri.ArcGISRuntime, 300.0.0"
open Esri.ArcGISRuntime
open Esri.ArcGISRuntime.ArcGISServices
open Esri.ArcGISRuntime.Data
open Esri.ArcGISRuntime.Geometry
open Esri.ArcGISRuntime.Mapping
open Esri.ArcGISRuntime.Mapping.FeatureForms
open Esri.ArcGISRuntime.Mapping.Popups
open Esri.ArcGISRuntime.Portal
open Esri.ArcGISRuntime.Symbology

#r "nuget: FSharp.XExtensions"
open FSharp.XExtensions
#r "nuget: LitXml"
open LitXml



#r "nuget: Humanizer.Core"
open Humanizer
#r "nuget: CaseConverter"
open CaseConverter

#load @"C:\Secret\InforSecrets.fsx"
open InforSecrets

#r "nuget: TextCopy"
open TextCopy




let clipboard = new Clipboard()
let clip (text:string) = clipboard.SetText text


module HansenDataDistribution = 
    [<Literal>]
    let xmlFilePath =  @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"
    let xmlFile = FileInfo xmlFilePath
    type Provider = XmlProvider<UseOriginalNames = true, PreferDateOnly = true,
            Sample = xmlFilePath >
    let xml = Provider.Load xmlFilePath



let assetTables = 
    HansenDataDistribution.xml.hansenMetadata.productFamilies
    |> Array.choose (fun productFamily -> 
        match productFamily.name with 
        | "AssetManagement.Storm" -> 
            productFamily.tables |> Array.filter (fun table -> table.databaseName.StartsWith("COMP")) |> Some
        | "AssetManagement.UsageArea" -> 
                productFamily.tables |> Array.filter (fun table -> table.name = "Complex") |> Some
        | _ -> None
        )
    |> Array.collect (fun tables -> tables)
assetTables |> Array.find (fun table -> table.name = "StormValve")




type FeatureAssetClassTable =
    { ``ArcGIS Feature Class``: string
      ``Infor Business Object``: string
      ``InforProdSql Database Table``: string
      ``InforProd Url Template``: string 
      ``InforProd Table Key``:int 
      }

type AssetFeatureIdentity = 
    {
        featureClass: string
        owner: string
        productFamily: string
        businessObject: string
        databaseSchema: string
        databaseTable: string
        businessObjectInfoViewerApplet: string
        tableKey: int
    }

let assetFeatureIdentities =

    [

      "Conduit", "Hansen", "AssetManagement.Storm", "StormLiftStation", "ASSETMANAGEMENT_STORM", "COMPSTLS", "StormLiftStationInfoViewerApplet", 9204
      "Culvert Cross Drain", "Hansen", "AssetManagement.Storm", "StormServiceLine", "ASSETMANAGEMENT_STORM", "COMPSTSL", "StormServiceLineInfoViewerApplet", 9233
      "Debris Trap", "Hansen", "AssetManagement.Storm", "StormValve", "ASSETMANAGEMENT_STORM", "COMPSTV", "StormValveInfoViewerApplet", 9284
      "Ditch", "Hansen", "AssetManagement.Storm", "StormBackflowPreventer", "ASSETMANAGEMENT_STORM", "COMPSTBF", "StormBackflowInfoViewerApplet", 9170
      "End Point", "Hansen", "AssetManagement.Storm", "StormNode", "ASSETMANAGEMENT_STORM", "COMPSTND", "StormNodeInfoViewerApplet", 9223
      "Inlet", "Hansen", "AssetManagement.Storm", "StormInlet", "ASSETMANAGEMENT_STORM", "COMPSTIN", "StormInletInfoViewerApplet", 9194
      "Junction Fixed", "Hansen", "AssetManagement.Storm", "StormManhole", "ASSETMANAGEMENT_STORM", "COMPSTMH", "StormManholeInfoViewerApplet", 9209
      "Outfall", "Hansen", "AssetManagement.UsageArea", "Complex", "ASSETMANAGEMENT_USAGEAREA", "COMPCPLX", "ComplexAssetInfoViewerApplet", 2198
      "Stormwater Pond Discharge", "Hansen", "AssetManagement.Storm", "StormLevee", "ASSETMANAGEMENT_STORM", "COMPSTLV", "StormLeveeInfoViewerApplet", 9201
      "Stormwater Pond", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "ASSETMANAGEMENT_STORM", "COMPSTMS", "StormMiscellaneousInfoViewerApplet", 9221

      ]
    |> List.map (fun (featureClass, owner, productFamily, businessObject, databaseSchema, databaseTable, businessObjectInfoViewerApplet, tableKey) ->
        {
        featureClass = featureClass
        owner = owner
        productFamily = productFamily
        businessObject = businessObject
        databaseSchema = databaseSchema
        databaseTable = databaseTable
        businessObjectInfoViewerApplet = businessObjectInfoViewerApplet
        tableKey = tableKey
        }
    )
let targetFeatureClasses = assetFeatureIdentities |> List.map (fun identity -> identity.featureClass) |> Set.ofList
let featureAssetClassObjects = 
        assetFeatureIdentities 
        |> List.map (fun assetFeatureIdentity -> 

            { ``ArcGIS Feature Class`` = assetFeatureIdentity.featureClass
              ``Infor Business Object`` = sprintf "%s.%s.%s" assetFeatureIdentity.owner assetFeatureIdentity.productFamily assetFeatureIdentity.businessObject
              ``InforProdSql Database Table`` = sprintf "%s.%s" assetFeatureIdentity.databaseSchema assetFeatureIdentity.databaseTable
              ``InforProd Url Template`` = sprintf "https://inforprod.leoncountyfl.gov/update/HFrame.htm?monk=%s.%s.%s&id={ID}&hasMenu=false&showHeader=false" assetFeatureIdentity.owner assetFeatureIdentity.productFamily assetFeatureIdentity.businessObjectInfoViewerApplet 
              ``InforProd Table Key`` = assetFeatureIdentity.tableKey
            }

        )


type FeatureAssetAttributeProperty =
    { ``ArcGIS Feature Class``: string
      ``ArcGIS Feature Attribute``: string
      ``Infor Business Object``: string
      ``Infor Business Object Property``: string
      ``InforProdSql Database Table``: string
      ``InforProdSql Database Column``: string 
      ``InforProdSql DotNet Type``:string
      }

// TODO make this authoritative by running codegen over it

type PropertyAttributeIdentity = 
    {
        featureClass: string
        featureAttribute: string
        owner: string
        productFamily: string
        businessObject: string
        businessObjectProperty: string
        databaseSchema: string
        databaseTable: string
        databaseColumn: string
        clrType: string
    }

let propertyAttributeIdentities =
    [

      "Conduit", "MAINTBY", "Hansen", "AssetManagement.Storm", "StormLiftStation", "Organization", "ASSETMANAGEMENT_STORM", "COMPSTLS", "ORGANIZATION", "System.String"
      "Conduit", "NOTES", "Hansen", "AssetManagement.Storm", "StormLiftStation", "UnitDesc", "ASSETMANAGEMENT_STORM", "COMPSTLS", "UNITDESC", "System.String"
      "Conduit", "OUTFALLID", "Hansen", "AssetManagement.Storm", "StormLiftStation", "Area", "ASSETMANAGEMENT_STORM", "COMPSTLS", "AREA", "System.String"
      "Conduit", "OWNER", "Hansen", "AssetManagement.Storm", "StormLiftStation", "Ownership", "ASSETMANAGEMENT_STORM", "COMPSTLS", "OWN", "System.String"
      "Conduit", "UNITID", "Hansen", "AssetManagement.Storm", "StormLiftStation", "ID", "ASSETMANAGEMENT_STORM", "COMPSTLS", "UNITID", "System.String"
      "Culvert Cross Drain", "MAINTBY", "Hansen", "AssetManagement.Storm", "StormServiceLine", "Organization", "ASSETMANAGEMENT_STORM", "COMPSTSL", "ORGANIZATION", "System.String"
      "Culvert Cross Drain", "NOTES", "Hansen", "AssetManagement.Storm", "StormServiceLine", "UnitDesc", "ASSETMANAGEMENT_STORM", "COMPSTSL", "UNITDESC", "System.String"
      "Culvert Cross Drain", "OUTFALLID", "Hansen", "AssetManagement.Storm", "StormServiceLine", "Area", "ASSETMANAGEMENT_STORM", "COMPSTSL", "AREA", "System.String"
      "Culvert Cross Drain", "OWNER", "Hansen", "AssetManagement.Storm", "StormServiceLine", "Ownership", "ASSETMANAGEMENT_STORM", "COMPSTSL", "OWN", "System.String"
      "Culvert Cross Drain", "UNITID", "Hansen", "AssetManagement.Storm", "StormServiceLine", "ID", "ASSETMANAGEMENT_STORM", "COMPSTSL", "UNITID", "System.String"
      "Debris Trap", "LOCATION", "Hansen", "AssetManagement.Storm", "StormValve", "AddressQualifier", "ASSETMANAGEMENT_STORM", "COMPSTV", "ADDRQUAL", "SystemString"
      "Debris Trap", "MAINTBY", "Hansen", "AssetManagement.Storm", "StormValve", "Organization", "ASSETMANAGEMENT_STORM", "COMPSTV", "ORGANIZATION", "System.String"
      "Debris Trap", "NOTES", "Hansen", "AssetManagement.Storm", "StormValve", "UnitDesc", "ASSETMANAGEMENT_STORM", "COMPSTV", "UNITDESC", "System.String"
      "Debris Trap", "OUTFALLID", "Hansen", "AssetManagement.Storm", "StormValve", "Area", "ASSETMANAGEMENT_STORM", "COMPSTV", "AREA", "System.String"
      "Debris Trap", "OWNER", "Hansen", "AssetManagement.Storm", "StormValve", "Ownership", "ASSETMANAGEMENT_STORM", "COMPSTV", "OWN", "System.String"
      "Debris Trap", "UNITID", "Hansen", "AssetManagement.Storm", "StormValve", "ID", "ASSETMANAGEMENT_STORM", "COMPSTV", "UNITID", "System.String"
      "Debris Trap", "x", "Hansen", "AssetManagement.Storm", "StormValve", "XCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTV", "XCOORD", "System.Double"
      "Debris Trap", "y", "Hansen", "AssetManagement.Storm", "StormValve", "YCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTV", "YCOORD", "System.Double"
      "Debris Trap", "ZVALUE", "Hansen", "AssetManagement.Storm", "StormValve", "ZCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTV", "ZCOORD", "System.Double"
      "Ditch", "MAINTBY", "Hansen", "AssetManagement.Storm", "StormBackflowPreventer", "Organization", "ASSETMANAGEMENT_STORM", "COMPSTBF", "ORGANIZATION", "System.String"
      "Ditch", "NOTES", "Hansen", "AssetManagement.Storm", "StormBackflowPreventer", "UnitDesc", "ASSETMANAGEMENT_STORM", "COMPSTBF", "UNITDESC", "System.String"
      "Ditch", "OUTFALLID", "Hansen", "AssetManagement.Storm", "StormBackflowPreventer", "Area", "ASSETMANAGEMENT_STORM", "COMPSTBF", "AREA", "System.String"
      "Ditch", "OWNER", "Hansen", "AssetManagement.Storm", "StormBackflowPreventer", "Ownership", "ASSETMANAGEMENT_STORM", "COMPSTBF", "OWN", "System.String"
      "Ditch", "UNITID", "Hansen", "AssetManagement.Storm", "StormBackflowPreventer", "ID", "ASSETMANAGEMENT_STORM", "COMPSTBF", "UNITID", "System.String"
      "End Point", "LOCATION", "Hansen", "AssetManagement.Storm", "StormNode", "AddressQualifier", "ASSETMANAGEMENT_STORM", "COMPSTND", "ADDRQUAL", "SystemString"
      "End Point", "MAINTBY", "Hansen", "AssetManagement.Storm", "StormNode", "Organization", "ASSETMANAGEMENT_STORM", "COMPSTND", "ORGANIZATION", "System.String"
      "End Point", "NOTES", "Hansen", "AssetManagement.Storm", "StormNode", "UnitDesc", "ASSETMANAGEMENT_STORM", "COMPSTND", "UNITDESC", "System.String"
      "End Point", "OUTFALLID", "Hansen", "AssetManagement.Storm", "StormNode", "Area", "ASSETMANAGEMENT_STORM", "COMPSTND", "AREA", "System.String"
      "End Point", "OWNER", "Hansen", "AssetManagement.Storm", "StormNode", "Ownership", "ASSETMANAGEMENT_STORM", "COMPSTND", "OWN", "System.String"
      "End Point", "UNITID", "Hansen", "AssetManagement.Storm", "StormNode", "ID", "ASSETMANAGEMENT_STORM", "COMPSTND", "UNITID", "System.String"
      "End Point", "x", "Hansen", "AssetManagement.Storm", "StormNode", "XCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTND", "XCOORD", "System.Double"
      "End Point", "y", "Hansen", "AssetManagement.Storm", "StormNode", "YCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTND", "YCOORD", "System.Double"
      "End Point", "ZVALUE", "Hansen", "AssetManagement.Storm", "StormNode", "ZCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTND", "ZCOORD", "System.Double"
      "Inlet", "LOCATION", "Hansen", "AssetManagement.Storm", "StormInlet", "AddressQualifier", "ASSETMANAGEMENT_STORM", "COMPSTIN", "ADDRQUAL", "SystemString"
      "Inlet", "MAINTBY", "Hansen", "AssetManagement.Storm", "StormInlet", "Organization", "ASSETMANAGEMENT_STORM", "COMPSTIN", "ORGANIZATION", "System.String"
      "Inlet", "NOTES", "Hansen", "AssetManagement.Storm", "StormInlet", "UnitDesc", "ASSETMANAGEMENT_STORM", "COMPSTIN", "UNITDESC", "System.String"
      "Inlet", "OUTFALLID", "Hansen", "AssetManagement.Storm", "StormInlet", "Area", "ASSETMANAGEMENT_STORM", "COMPSTIN", "AREA", "System.String"
      "Inlet", "OWNER", "Hansen", "AssetManagement.Storm", "StormInlet", "Ownership", "ASSETMANAGEMENT_STORM", "COMPSTIN", "OWN", "System.String"
      "Inlet", "UNITID", "Hansen", "AssetManagement.Storm", "StormInlet", "ID", "ASSETMANAGEMENT_STORM", "COMPSTIN", "UNITID", "System.String"
      "Inlet", "x", "Hansen", "AssetManagement.Storm", "StormInlet", "XCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTIN", "XCOORD", "System.Double"
      "Inlet", "y", "Hansen", "AssetManagement.Storm", "StormInlet", "YCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTIN", "YCOORD", "System.Double"
      "Inlet", "ZVALUE", "Hansen", "AssetManagement.Storm", "StormInlet", "ZCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTIN", "ZCOORD", "System.Double"
      "Junction Fixed", "LOCATION", "Hansen", "AssetManagement.Storm", "StormManhole", "AddressQualifier", "ASSETMANAGEMENT_STORM", "COMPSTMH", "ADDRQUAL", "SystemString"
      "Junction Fixed", "MAINTBY", "Hansen", "AssetManagement.Storm", "StormManhole", "Organization", "ASSETMANAGEMENT_STORM", "COMPSTMH", "ORGANIZATION", "System.String"
      "Junction Fixed", "NOTES", "Hansen", "AssetManagement.Storm", "StormManhole", "UnitDesc", "ASSETMANAGEMENT_STORM", "COMPSTMH", "UNITDESC", "System.String"
      "Junction Fixed", "OUTFALLID", "Hansen", "AssetManagement.Storm", "StormManhole", "Area", "ASSETMANAGEMENT_STORM", "COMPSTMH", "AREA", "System.String"
      "Junction Fixed", "OWNER", "Hansen", "AssetManagement.Storm", "StormManhole", "Ownership", "ASSETMANAGEMENT_STORM", "COMPSTMH", "OWN", "System.String"
      "Junction Fixed", "UNITID", "Hansen", "AssetManagement.Storm", "StormManhole", "ID", "ASSETMANAGEMENT_STORM", "COMPSTMH", "UNITID", "System.String"
      "Junction Fixed", "x", "Hansen", "AssetManagement.Storm", "StormManhole", "XCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTMH", "XCOORD", "System.Double"
      "Junction Fixed", "y", "Hansen", "AssetManagement.Storm", "StormManhole", "YCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTMH", "YCOORD", "System.Double"
      "Junction Fixed", "ZVALUE", "Hansen", "AssetManagement.Storm", "StormManhole", "ZCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTMH", "ZCOORD", "System.Double"
      "Outfall", "NOTES", "Hansen", "AssetManagement.UsageArea", "Complex", "UnitDesc", "ASSETMANAGEMENT_USAGEAREA", "COMPCPLX", "UNITDESC", "System.String"
      "Outfall", "OUTFALLID", "Hansen", "AssetManagement.UsageArea", "Complex", "Area", "ASSETMANAGEMENT_USAGEAREA", "COMPCPLX", "AREA", "System.String"
      "Outfall", "UNITID", "Hansen", "AssetManagement.UsageArea", "Complex", "ID", "ASSETMANAGEMENT_USAGEAREA", "COMPCPLX", "UNITID", "System.String"
      "Outfall", "x", "Hansen", "AssetManagement.UsageArea", "Complex", "XCoordinate", "ASSETMANAGEMENT_USAGEAREA", "COMPCPLX", "XCOORD", "System.Double"
      "Outfall", "y", "Hansen", "AssetManagement.UsageArea", "Complex", "YCoordinate", "ASSETMANAGEMENT_USAGEAREA", "COMPCPLX", "YCOORD", "System.Double"
      "Stormwater Pond Discharge", "LOCATION", "Hansen", "AssetManagement.Storm", "StormLevee", "AddressQualifier", "ASSETMANAGEMENT_STORM", "COMPSTLV", "ADDRQUAL", "SystemString"
      "Stormwater Pond Discharge", "MAINTBY", "Hansen", "AssetManagement.Storm", "StormLevee", "Organization", "ASSETMANAGEMENT_STORM", "COMPSTLV", "ORGANIZATION", "System.String"
      "Stormwater Pond Discharge", "NOTES", "Hansen", "AssetManagement.Storm", "StormLevee", "UnitDesc", "ASSETMANAGEMENT_STORM", "COMPSTLV", "UNITDESC", "System.String"
      "Stormwater Pond Discharge", "OUTFALLID", "Hansen", "AssetManagement.Storm", "StormLevee", "Area", "ASSETMANAGEMENT_STORM", "COMPSTLV", "AREA", "System.String"
      "Stormwater Pond Discharge", "OWNER", "Hansen", "AssetManagement.Storm", "StormLevee", "Ownership", "ASSETMANAGEMENT_STORM", "COMPSTLV", "OWN", "System.String"
      "Stormwater Pond Discharge", "UNITID", "Hansen", "AssetManagement.Storm", "StormLevee", "ID", "ASSETMANAGEMENT_STORM", "COMPSTLV", "UNITID", "System.String"
      "Stormwater Pond Discharge", "x", "Hansen", "AssetManagement.Storm", "StormLevee", "XCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTLV", "XCOORD", "System.Double"
      "Stormwater Pond Discharge", "y", "Hansen", "AssetManagement.Storm", "StormLevee", "YCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTLV", "YCOORD", "System.Double"
      "Stormwater Pond Discharge", "ZVALUE", "Hansen", "AssetManagement.Storm", "StormLevee", "ZCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTLV", "ZCOORD", "System.Double"
      "Stormwater Pond", "LOCATION", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "AddressQualifier", "ASSETMANAGEMENT_STORM", "COMPSTMS", "ADDRQUAL", "SystemString"
      "Stormwater Pond", "MAINTBY", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "Organization", "ASSETMANAGEMENT_STORM", "COMPSTMS", "ORGANIZATION", "System.String"
      "Stormwater Pond", "NOTES", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "UnitDesc", "ASSETMANAGEMENT_STORM", "COMPSTMS", "UNITDESC", "System.String"
      "Stormwater Pond", "OWNER", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "Ownership", "ASSETMANAGEMENT_STORM", "COMPSTMS", "OWN", "System.String"
      "Stormwater Pond", "PONDTYPE", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "UnitType", "ASSETMANAGEMENT_STORM", "COMPSTMS", "UNITTYPE", "System.String"
      "Stormwater Pond", "UNITID", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "ID", "ASSETMANAGEMENT_STORM", "COMPSTMS", "UNITID", "System.String"
      "Stormwater Pond", "x", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "XCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTMS", "XCOORD", "System.Double"
      "Stormwater Pond", "y", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "YCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTMS", "YCOORD", "System.Double"
      "Stormwater Pond", "ZVALUE", "Hansen", "AssetManagement.Storm", "StormMiscellaneous", "ZCoordinate", "ASSETMANAGEMENT_STORM", "COMPSTMS", "ZCOORD", "System.Double"


      ]
    |> List.map (fun (featureClass, featureAttribute, owner, productFamily, businessObject, businessObjectProperty, databaseSchema, databaseTable, databaseColumn, clrType) ->

    {
        featureClass = featureClass
        featureAttribute = featureAttribute
        owner = owner
        productFamily = productFamily
        businessObject = businessObject
        businessObjectProperty = businessObjectProperty
        databaseSchema = databaseSchema
        databaseTable = databaseTable
        databaseColumn = databaseColumn
        clrType = clrType
    }
    )
let featureAssetAttributeProperties = 
        propertyAttributeIdentities
        |> List.map (fun propertyAttributeIdentity -> 
        { ``ArcGIS Feature Class`` = propertyAttributeIdentity.featureClass
          ``ArcGIS Feature Attribute`` = propertyAttributeIdentity.featureAttribute
          ``Infor Business Object`` = sprintf "%s.%s.%s" propertyAttributeIdentity.owner propertyAttributeIdentity.productFamily propertyAttributeIdentity.businessObject
          ``Infor Business Object Property`` = sprintf "%s.%s.%s.%s" propertyAttributeIdentity.owner propertyAttributeIdentity.productFamily propertyAttributeIdentity.businessObject propertyAttributeIdentity.businessObjectProperty
          ``InforProdSql Database Table`` = sprintf "%s.%s" propertyAttributeIdentity.databaseSchema propertyAttributeIdentity.databaseTable
          ``InforProdSql Database Column`` = sprintf "%s.%s.%s" propertyAttributeIdentity.databaseSchema propertyAttributeIdentity.databaseTable propertyAttributeIdentity.databaseColumn 
          ``InforProdSql DotNet Type``= propertyAttributeIdentity.clrType
          }


    )




[

  Worksheet "Class-Objects"
  FsExcel.Table [ TableName "Feature-Asset Class-Objects "
                  TableItems featureAssetClassObjects ]
  Worksheet "Feature-Assets"
  FsExcel.Table [ TableName "Feature-Asset Attribute-Properties"
                  TableItems featureAssetAttributeProperties ]

  ]
|> Render.AsFile @"D:\Persistence\XLSX\LCG\Identifiers.xlsx"




ArcGISRuntimeEnvironment.Initialize()



type Feature with 
    static member Query (offset:int)  (table:ServiceFeatureTable) = 
        Array.concat [|

            let query = QueryParameters()
            query.WhereClause <- "1 = 1"
            query.ReturnGeometry <- true
            query.ResultOffset <- offset
            query.MaxFeatures <- int table.LayerInfo.MaxRecordCount

            let features =
                table.QueryFeaturesAsync(
                    query,
                    QueryFeatureFields.LoadAll
                )
                |> Async.AwaitTask
                |> Async.RunSynchronously
                |> Seq.toArray

            if features.Length = 0 then
                [||]
            else
                table |> Feature.Query (offset + features.Length) |> Array.append features
        |]



    member this.X = 
            match this.Geometry with 
            | :? MapPoint as mapPoint -> string mapPoint.X
            | _ -> String.Empty
    member this.Y = 
            match this.Geometry with 
            | :? MapPoint as mapPoint -> string mapPoint.Y
            | _ -> String.Empty
    member this.Z = 
            match this.Geometry with 
            | :? MapPoint as mapPoint -> string mapPoint.Z
            | _ -> String.Empty
    member this.attributes = 
            this.Attributes
            |> Seq.toArray
            |> Array.map (|KeyValue|)
            |> Array.filter (fun (key,objValue) -> objValue <> null )
            |> Array.filter (fun (key,objValue) -> not (String.IsNullOrWhiteSpace (string objValue)))
            |> Array.map (fun (key,objValue) ->  key, string objValue)
    member this.attribute (fieldName:string) = this.attributes |> Array.tryPick (fun (key,value) -> 
        if key = fieldName then 
            Some value
        else
            None
        )
    member this.hasAttribute (fieldName:string) = 
        match this.attribute fieldName with 
        | Some _ -> true
        | None -> false
    member this.AddressQualifier = defaultArg this.LOCATION String.Empty
    member this.Organization = defaultArg this.MAINTBY String.Empty
    member this.UnitDesc = defaultArg this.NOTES String.Empty
    member this.Area = defaultArg this.OUTFALLID String.Empty
    member this.Ownership = defaultArg this.OWNER String.Empty
    member this.ID = defaultArg this.UNITID String.Empty
    member this.ZCoordinate = defaultArg this.ZVALUE String.Empty
    member this.UnitType = defaultArg this.PONDTYPE String.Empty

    member this.ACCEPT_DATE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ACCEPT_DATE" then Some value else None)
    member this.ACCURACYCODE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ACCURACYCODE" then Some value else None)
    member this.ACREAGE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ACREAGE" then Some value else None)
    member this.ACRES = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ACRES" then Some value else None)
    member this.ACTIVITY = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ACTIVITY" then Some value else None)
    member this.ANCILLARYROLE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ANCILLARYROLE" then Some value else None)
    member this.ATTACHEDTOID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ATTACHEDTOID" then Some value else None)
    member this.ATTRIBUTECOMPLETE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ATTRIBUTECOMPLETE" then Some value else None)
    member this.CAPACITY = this.attributes |> Array.tryPick (fun (key,value) -> if key = "CAPACITY" then Some value else None)
    member this.CREATIONDATE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "CREATIONDATE" then Some value else None)
    member this.CREATOR = this.attributes |> Array.tryPick (fun (key,value) -> if key = "CREATOR" then Some value else None)
    member this.CREW = this.attributes |> Array.tryPick (fun (key,value) -> if key = "CREW" then Some value else None)
    member this.DAMAGEID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DAMAGEID" then Some value else None)
    member this.DAMAGETYPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DAMAGETYPE" then Some value else None)
    member this.DATAFILE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DATAFILE" then Some value else None)
    member this.DATECREATED = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DATECREATED" then Some value else None)
    member this.DATEMODIFIED = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DATEMODIFIED" then Some value else None)
    member this.DATE_ = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DATE_" then Some value else None)
    member this.DESCRIPTION = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DESCRIPTION" then Some value else None)
    member this.DIAMETER = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DIAMETER" then Some value else None)
    member this.DIGITALPICTUREID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DIGITALPICTUREID" then Some value else None)
    member this.DIGITALPICTUREID_E = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DIGITALPICTUREID_E" then Some value else None)
    member this.DIGITALPICTUREID_S = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DIGITALPICTUREID_S" then Some value else None)
    member this.DIGITALPICTUREID_W = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DIGITALPICTUREID_W" then Some value else None)
    member this.DOWNSTREAMDEPTH = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DOWNSTREAMDEPTH" then Some value else None)
    member this.DOWNSTREAMELEVATION = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DOWNSTREAMELEVATION" then Some value else None)
    member this.DOWNSTREAM_DEPTH = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DOWNSTREAM_DEPTH" then Some value else None)
    member this.DOWNSTREAM_ELEV = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DOWNSTREAM_ELEV" then Some value else None)
    member this.DRAINAGEAREA = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DRAINAGEAREA" then Some value else None)
    member this.DRAINAGEBASIN = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DRAINAGEBASIN" then Some value else None)
    member this.DRAINAGE_AREA = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DRAINAGE_AREA" then Some value else None)
    member this.DRAWINGID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "DRAWINGID" then Some value else None)
    member this.EASTING = this.attributes |> Array.tryPick (fun (key,value) -> if key = "EASTING" then Some value else None)
    member this.EDITDATE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "EDITDATE" then Some value else None)
    member this.EDITOR = this.attributes |> Array.tryPick (fun (key,value) -> if key = "EDITOR" then Some value else None)
    member this.ELEMENTX = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ELEMENTX" then Some value else None)
    member this.ELEMENTY = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ELEMENTY" then Some value else None)
    member this.ENABLED = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ENABLED" then Some value else None)
    member this.FACILITYID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FACILITYID" then Some value else None)
    member this.FIELDCOMMENTS = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FIELDCOMMENTS" then Some value else None)
    member this.FIELDCOMPLETE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FIELDCOMPLETE" then Some value else None)
    member this.FIELDCREW = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FIELDCREW" then Some value else None)
    member this.FIELD_COMMENTS_ = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FIELD_COMMENTS_" then Some value else None)
    member this.FILE_NAME = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FILE_NAME" then Some value else None)
    member this.FILE_NAME_1 = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FILE_NAME_1" then Some value else None)
    member this.FILTER = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FILTER" then Some value else None)
    member this.FILTERLOCATION = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FILTERLOCATION" then Some value else None)
    member this.FILTERTYPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FILTERTYPE" then Some value else None)
    member this.FINAL_NAME = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FINAL_NAME" then Some value else None)
    member this.FOLDER = this.attributes |> Array.tryPick (fun (key,value) -> if key = "FOLDER" then Some value else None)
    member this.GLOBALID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "GLOBALID" then Some value else None)
    member this.HEIGHT = this.attributes |> Array.tryPick (fun (key,value) -> if key = "HEIGHT" then Some value else None)
    member this.HOTLINK = this.attributes |> Array.tryPick (fun (key,value) -> if key = "HOTLINK" then Some value else None)
    member this.HYD_ID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "HYD_ID" then Some value else None)
    member this.HYPERLINK = this.attributes |> Array.tryPick (fun (key,value) -> if key = "HYPERLINK" then Some value else None)
    member this.HYPERLINK_AR = this.attributes |> Array.tryPick (fun (key,value) -> if key = "HYPERLINK_AR" then Some value else None)
    member this.IMAGERYYEAR = this.attributes |> Array.tryPick (fun (key,value) -> if key = "IMAGERYYEAR" then Some value else None)
    member this.INFILTRATION = this.attributes |> Array.tryPick (fun (key,value) -> if key = "INFILTRATION" then Some value else None)
    member this.INSPDATE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "INSPDATE" then Some value else None)
    member this.INVENTORIED_BY = this.attributes |> Array.tryPick (fun (key,value) -> if key = "INVENTORIED_BY" then Some value else None)
    member this.INVENTORYDATE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "INVENTORYDATE" then Some value else None)
    member this.INVENTORYTYPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "INVENTORYTYPE" then Some value else None)
    member this.INVERTELEV = this.attributes |> Array.tryPick (fun (key,value) -> if key = "INVERTELEV" then Some value else None)
    member this.INVERT_ELEV = this.attributes |> Array.tryPick (fun (key,value) -> if key = "INVERT_ELEV" then Some value else None)
    member this.INVERT_ELEV29 = this.attributes |> Array.tryPick (fun (key,value) -> if key = "INVERT_ELEV29" then Some value else None)
    member this.ISINFALL = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ISINFALL" then Some value else None)
    member this.LEGACYID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "LEGACYID" then Some value else None)
    member this.LEGACY_ID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "LEGACY_ID" then Some value else None)
    member this.LFEET = this.attributes |> Array.tryPick (fun (key,value) -> if key = "LFEET" then Some value else None)
    member this.LIFECYCLE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "LIFECYCLE" then Some value else None)
    member this.LOCATION = this.attributes |> Array.tryPick (fun (key,value) -> if key = "LOCATION" then Some value else None)
    member this.LOC_DESC = this.attributes |> Array.tryPick (fun (key,value) -> if key = "LOC_DESC" then Some value else None)
    member this.MAINTBY = this.attributes |> Array.tryPick (fun (key,value) -> if key = "MAINTBY" then Some value else None)
    member this.MATERIAL = this.attributes |> Array.tryPick (fun (key,value) -> if key = "MATERIAL" then Some value else None)
    member this.MEDIA_CODE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "MEDIA_CODE" then Some value else None)
    member this.MILES = this.attributes |> Array.tryPick (fun (key,value) -> if key = "MILES" then Some value else None)
    member this.NEEDSATTENTION = this.attributes |> Array.tryPick (fun (key,value) -> if key = "NEEDSATTENTION" then Some value else None)
    member this.NORTHING = this.attributes |> Array.tryPick (fun (key,value) -> if key = "NORTHING" then Some value else None)
    member this.NOTES = this.attributes |> Array.tryPick (fun (key,value) -> if key = "NOTES" then Some value else None)
    member this.NUM_BARRELS = this.attributes |> Array.tryPick (fun (key,value) -> if key = "NUM_BARRELS" then Some value else None)
    member this.OBJECTID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "OBJECTID" then Some value else None)
    member this.OBSTRUCTION = this.attributes |> Array.tryPick (fun (key,value) -> if key = "OBSTRUCTION" then Some value else None)
    member this.ORIGINALSOURCE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ORIGINALSOURCE" then Some value else None)
    member this.OUTFALLID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "OUTFALLID" then Some value else None)
    member this.OUTFALLTYPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "OUTFALLTYPE" then Some value else None)
    member this.OWNER = this.attributes |> Array.tryPick (fun (key,value) -> if key = "OWNER" then Some value else None)
    member this.PARCELID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PARCELID" then Some value else None)
    member this.PARENTID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PARENTID" then Some value else None)
    member this.PERCT_GRD = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PERCT_GRD" then Some value else None)
    member this.PHOTOID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PHOTOID" then Some value else None)
    member this.PHOTO_FOLDER = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PHOTO_FOLDER" then Some value else None)
    member this.PHOTO_NUM = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PHOTO_NUM" then Some value else None)
    member this.PID_1 = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PID_1" then Some value else None)
    member this.PIPESHAPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PIPESHAPE" then Some value else None)
    member this.PLACE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PLACE" then Some value else None)
    member this.PONDID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PONDID" then Some value else None)
    member this.PONDTYPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PONDTYPE" then Some value else None)
    member this.PONDYR = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PONDYR" then Some value else None)
    member this.POND_ID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "POND_ID" then Some value else None)
    member this.PRFRESOLUTION = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PRFRESOLUTION" then Some value else None)
    member this.RAW_NAME = this.attributes |> Array.tryPick (fun (key,value) -> if key = "RAW_NAME" then Some value else None)
    member this.RELATEDFEATURE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "RELATEDFEATURE" then Some value else None)
    member this.ROTATION_AZ = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ROTATION_AZ" then Some value else None)
    member this.SHAPE_Area = this.attributes |> Array.tryPick (fun (key,value) -> if key = "SHAPE_Area" then Some value else None)
    member this.SHAPE_Length = this.attributes |> Array.tryPick (fun (key,value) -> if key = "SHAPE_Length" then Some value else None)
    member this.SLOT_ELEV = this.attributes |> Array.tryPick (fun (key,value) -> if key = "SLOT_ELEV" then Some value else None)
    member this.SOURCE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "SOURCE" then Some value else None)
    member this.SOURCEYEAR = this.attributes |> Array.tryPick (fun (key,value) -> if key = "SOURCEYEAR" then Some value else None)
    member this.STORAGE_FULL_PATH_ADDR = this.attributes |> Array.tryPick (fun (key,value) -> if key = "STORAGE_FULL_PATH_ADDR" then Some value else None)
    member this.STORAGE_PATH_ADDR = this.attributes |> Array.tryPick (fun (key,value) -> if key = "STORAGE_PATH_ADDR" then Some value else None)
    member this.STORAGE_STATIC_PATH_ADDR = this.attributes |> Array.tryPick (fun (key,value) -> if key = "STORAGE_STATIC_PATH_ADDR" then Some value else None)
    member this.STRCT_DEPTH = this.attributes |> Array.tryPick (fun (key,value) -> if key = "STRCT_DEPTH" then Some value else None)
    member this.STRUCTUREID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "STRUCTUREID" then Some value else None)
    member this.STRUCTURETYPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "STRUCTURETYPE" then Some value else None)
    member this.STRUCTURE_ID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "STRUCTURE_ID" then Some value else None)
    member this.SUBTYPEFIELD = this.attributes |> Array.tryPick (fun (key,value) -> if key = "SUBTYPEFIELD" then Some value else None)
    member this.SURFACETYPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "SURFACETYPE" then Some value else None)
    member this.Shape_Area = this.attributes |> Array.tryPick (fun (key,value) -> if key = "Shape_Area" then Some value else None)
    member this.Shape_Length = this.attributes |> Array.tryPick (fun (key,value) -> if key = "Shape_Length" then Some value else None)
    member this.UNDERDRAINS = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UNDERDRAINS" then Some value else None)
    member this.UNITDESC = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UNITDESC" then Some value else None)
    member this.UNITID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UNITID" then Some value else None)
    member this.UPDATESOURCE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UPDATESOURCE" then Some value else None)
    member this.UPSTREAMDEPTH = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAMDEPTH" then Some value else None)
    member this.UPSTREAMELEVATION = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAMELEVATION" then Some value else None)
    member this.UPSTREAMSTUCTUREID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAMSTUCTUREID" then Some value else None)
    member this.UPSTREAM_DEPTH = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAM_DEPTH" then Some value else None)
    member this.UPSTREAM_ELEV = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UPSTREAM_ELEV" then Some value else None)
    member this.VIEW_ = this.attributes |> Array.tryPick (fun (key,value) -> if key = "VIEW_" then Some value else None)
    member this.WATERBODYNAME = this.attributes |> Array.tryPick (fun (key,value) -> if key = "WATERBODYNAME" then Some value else None)
    member this.WBID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "WBID" then Some value else None)
    member this.WHOCREATED = this.attributes |> Array.tryPick (fun (key,value) -> if key = "WHOCREATED" then Some value else None)
    member this.WHOMODIFIED = this.attributes |> Array.tryPick (fun (key,value) -> if key = "WHOMODIFIED" then Some value else None)
    member this.WIDTH = this.attributes |> Array.tryPick (fun (key,value) -> if key = "WIDTH" then Some value else None)
    member this.Z29 = this.attributes |> Array.tryPick (fun (key,value) -> if key = "Z29" then Some value else None)
    member this.ZVALUE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ZVALUE" then Some value else None)
            
type StormLiftStationRow = 
    {
        ID: string
        UnitDesc: string
        Area: string
        Organization: string
        Ownership: string
    }
    static member fromFeature (feature:Feature) = 
        {

          Organization = feature.Organization 
          UnitDesc = feature.UnitDesc 
          Area = feature.Area 
          Ownership = feature.Ownership 
          ID = feature.ID 
        }

type StormServiceLineRow = 
    {
        ID: string
        UnitDesc: string
        Area: string
        Organization: string
        Ownership: string
    }
    
    static member fromFeature (feature:Feature) = 
        {
          Organization = feature.Organization 
          UnitDesc = feature.UnitDesc 
          Area = feature.Area 
          Ownership = feature.Ownership 
          ID = feature.ID 
        }

type StormValveRow = 
    {
        ID: string
        UnitDesc: string
        AddressQualifier: string
        Area: string
        Organization: string
        Ownership: string
        XCoordinate: string
        YCoordinate: string
        ZCoordinate: string
    }
    static member fromFeature (feature:Feature) = 
        {
          AddressQualifier = feature.AddressQualifier 
          Organization = feature.Organization 
          UnitDesc = feature.UnitDesc 
          Area = feature.Area 
          Ownership = feature.Ownership 
          ID = feature.ID 
          XCoordinate = feature.X
          YCoordinate = feature.Y
          ZCoordinate = feature.ZCoordinate 

        }

type StormBackflowPreventerRow = 
    {
        ID: string
        UnitDesc: string
        Area: string
        Organization: string
        Ownership: string
    }
    static member fromFeature (feature:Feature) = 
        {
          Organization = feature.Organization 
          UnitDesc = feature.UnitDesc 
          Area = feature.Area 
          Ownership = feature.Ownership 
          ID = feature.ID 
        }

type StormNodeRow = 
    {
        ID: string
        UnitDesc: string
        AddressQualifier: string
        Area: string
        Organization: string
        Ownership: string
        XCoordinate: string
        YCoordinate: string
        ZCoordinate: string
    }
    static member fromFeature (feature:Feature) = 
        {
          AddressQualifier = feature.AddressQualifier 
          Organization = feature.Organization 
          UnitDesc = feature.UnitDesc 
          Area = feature.Area 
          Ownership = feature.Ownership 
          ID = feature.ID 
          XCoordinate = feature.X
          YCoordinate = feature.Y
          ZCoordinate = feature.ZCoordinate 
        }

type StormInletRow = 
    {
        ID: string
        UnitDesc: string
        AddressQualifier: string
        Area: string
        Organization: string
        Ownership: string
        XCoordinate: string
        YCoordinate: string
        ZCoordinate: string
    }
    static member fromFeature (feature:Feature) = 
        {
          AddressQualifier = feature.AddressQualifier 
          Organization = feature.Organization 
          UnitDesc = feature.UnitDesc 
          Area = feature.Area 
          Ownership = feature.Ownership 
          ID = feature.ID 
          XCoordinate = feature.X
          YCoordinate = feature.Y
          ZCoordinate = feature.ZCoordinate 

        }

type StormManholeRow = 
    {
        ID: string
        UnitDesc: string
        AddressQualifier: string
        Area: string
        Organization: string
        Ownership: string
        XCoordinate: string
        YCoordinate: string
        ZCoordinate: string
    }
    static member fromFeature (feature:Feature) = 
        {
          AddressQualifier = feature.AddressQualifier 
          Organization = feature.Organization 
          UnitDesc = feature.UnitDesc 
          Area = feature.Area 
          Ownership = feature.Ownership 
          ID = feature.ID 
          XCoordinate = feature.X
          YCoordinate = feature.Y
          ZCoordinate = feature.ZCoordinate 
        }

type ComplexRow = 
    {
        ID: string
        UnitDesc: string
        Area: string
        XCoordinate: string
        YCoordinate: string
    }
    static member fromFeature (feature:Feature) = 
        {
          UnitDesc = feature.UnitDesc 
          Area = feature.Area 
          ID = feature.ID 
          XCoordinate = feature.X
          YCoordinate = feature.Y
        }

type StormLeveeRow = 
    {
        ID: string
        UnitDesc: string
        AddressQualifier: string
        Area: string
        Organization: string
        Ownership: string
        XCoordinate: string
        YCoordinate: string
        ZCoordinate: string
    }
    static member fromFeature (feature:Feature) = 
        {
          AddressQualifier = feature.AddressQualifier 
          Organization = feature.Organization 
          UnitDesc = feature.UnitDesc 
          Area = feature.Area 
          Ownership = feature.Ownership 
          ID = feature.ID 
          XCoordinate = feature.X
          YCoordinate = feature.Y
          ZCoordinate = feature.ZCoordinate 

        }

type StormMiscellaneousRow = 
    {
        ID: string
        UnitDesc: string
        UnitType: string
        AddressQualifier: string
        Organization: string
        Ownership: string
        XCoordinate: string
        YCoordinate: string
        ZCoordinate: string
    }
    static member fromFeature (feature:Feature) = 
        {
          AddressQualifier = feature.AddressQualifier 
          Organization = feature.Organization 
          UnitDesc = feature.UnitDesc 
          Ownership = feature.Ownership 
          UnitType = feature.UnitType 
          ID = feature.ID 
          XCoordinate = feature.X
          YCoordinate = feature.Y
          ZCoordinate = feature.ZCoordinate 
        }

type ServiceFeatureTable with
    member this.fields = this.Fields |> Seq.toArray
    member this.domain_fields = this.Fields |> Seq.filter (fun field -> field.Domain <> null) |> Seq.toArray
    member this.nondomain_fields = this.Fields |> Seq.filter (fun field -> field.Domain = null) |> Seq.toArray
    member this.aliased_fields = this.Fields |> Seq.filter (fun field -> field.Name <> field.Alias) |> Seq.toArray
    member this.features = this |> Feature.Query  0

type ArcGISMapImageLayer with
    member this.sublayers = this.Sublayers |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer) |> Seq.toArray
    member this.sublayerInfos = this.sublayers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.ungroupedLayers = this.sublayers  |> Array.filter (fun layer -> layer.MapServiceSublayerInfo.SublayerType = ArcGISMapServiceSublayerType.FeatureLayer)
    member this.ungroupedTables = this.ungroupedLayers |> Array.map (fun featureLayer -> featureLayer.Table)
    member this.ungroupedFields = this.ungroupedTables |> Array.collect (fun table -> table.Fields |> Seq.toArray)
    member this.ungroupedLayerInfos = this.ungroupedLayers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.ungroupedLayerInfosByName (name:string) = this.ungroupedLayerInfos |> Array.filter (fun featureLayerInfo -> featureLayerInfo.ServiceLayerName = name)
    member this.ungroupedLayerByName (name:string) = this.ungroupedLayers |> Array.find (fun ungroupedLayer -> ungroupedLayer.Name = name)
    member this.groupLayers = this.sublayers  |> Array.filter (fun layer -> layer.MapServiceSublayerInfo.SublayerType = ArcGISMapServiceSublayerType.GroupLayer)
    member this.groupLayerInfos = this.groupLayers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.groupLayerInfosByName (name:string) = this.groupLayerInfos |> Array.filter (fun groupLayerInfo -> groupLayerInfo.ServiceLayerName = name)
    member this.groupLayerByName (name:string) = this.groupLayers |> Array.find (fun groupLayer -> groupLayer.Name = name)
    member this.drainageNetworkLayers = this.groupLayers[0].Sublayers |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer) |> Seq.toArray 
    member this.drainageNetworkSublayerIds = this.groupLayers[0].Sublayers |> Seq.map (fun layer -> layer.Id ) |> Seq.toArray 
    member this.drainageNetworkTables = this.drainageNetworkLayers |> Array.map (fun featureLayer -> featureLayer.Table)
    member this.drainageNetworkFields = this.drainageNetworkTables |> Array.collect (fun table -> table.Fields |> Seq.toArray)
    member this.drainageNetworkLayerInfos = this.drainageNetworkLayers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.drainageNetworkLayerInfosByName (name:string) = this.drainageNetworkLayerInfos |> Array.filter (fun drainageNetworkLayerInfo -> drainageNetworkLayerInfo.ServiceLayerName = name)
    member this.nondrainageNetworkLayers = this.groupLayers[1].Sublayers |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer) |> Seq.toArray 
    member this.nondrainageNetworkSublayerIds = this.groupLayers[1].Sublayers |> Seq.map (fun layer -> layer.Id ) |> Seq.toArray 
    member this.nondrainageNetworkTables = this.nondrainageNetworkLayers |> Array.map (fun featureLayer -> featureLayer.Table)
    member this.nondrainageNetworkFields = this.nondrainageNetworkTables |> Array.collect (fun table -> table.Fields |> Seq.toArray)
    member this.nondrainageNetworkLayerInfos = this.nondrainageNetworkLayers |> Array.map (fun layer -> layer.MapServiceSublayerInfo) 
    member this.nondrainageNetworkLayerInfosByName (name:string) = this.nondrainageNetworkLayerInfos |> Array.filter (fun nondrainageNetworkLayerInfo -> nondrainageNetworkLayerInfo.ServiceLayerName = name)
    member this.featureLayers = 
        Array.concat [|
            this.ungroupedLayers
            this.drainageNetworkLayers
            this.nondrainageNetworkLayers
        |]
    member this.featureLayersById = this.featureLayers |> Array.map (fun layer -> layer.Id, layer) |> Map.ofArray

    member this.featureLayerInfos = 
        Array.concat [|
            this.ungroupedLayerInfos
            this.drainageNetworkLayerInfos
            this.nondrainageNetworkLayerInfos
        |]
    member this.featureLayerInfosByName (name:string) = this.featureLayerInfos |> Array.filter (fun featureLayerInfo -> featureLayerInfo.ServiceLayerName = name)
    member this.tables = 
        let tables = 
            Array.concat [|
                this.ungroupedTables
                this.drainageNetworkTables
                this.nondrainageNetworkTables
            |]
        tables |> Array.iter (fun table -> table.FeatureRequestMode <- FeatureRequestMode.OnInteractionCache)
        tables
    member this.tableByName = this.tables |> Array.map (fun table -> table.TableName, table) |> Map.ofArray
    member this.tablesWithField (fieldName:string) = 
        this.tables |> Array.choose (fun table -> 
            let fieldExists = table.Fields |> Seq.exists (fun field -> field.Name = fieldName)
            if fieldExists then 
                Some table
            else 
                None
    
            )
    member this.tablesByName (name:string) = this.tables |> Array.filter (fun table -> table.LayerInfo.ServiceLayerName = name)
    member this.fields = 
        Array.concat [|
            this.ungroupedFields
            this.drainageNetworkFields
            this.nondrainageNetworkFields
        |]
    member this.fieldsByTable (tableName:string) = 
        let table = this.tablesByName tableName  |> Array.exactlyOne 
        table.Fields |> Seq.toArray
    member this.fieldsByQualifiedName (tableName:string)(fieldName:string) = 
        let table = this.tablesByName tableName  |> Array.exactlyOne 
        table.Fields |> Seq.find (fun field -> field.Name = fieldName) 
    member this.features = this.tables |> Array.collect (fun table -> table.features)






let MapServer = ArcGISMapImageLayer(new Uri "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer")
MapServer.LoadTablesAndLayersAsync()
    |> Async.AwaitTask
    |> Async.RunSynchronously

type FeatureClass = 
    {
        imageLayer: ArcGISMapImageSublayer
        featureLayer: FeatureLayer
        featureTable: ServiceFeatureTable
        features: Feature array
    }
    static member fromTable (featureTable:ServiceFeatureTable) = 
            {
                imageLayer = MapServer.featureLayersById[featureTable.ServiceLayerId]
                featureLayer = featureTable.Layer :?> FeatureLayer
                featureTable = featureTable
                features = featureTable.features
            }
    member this.assetRows (featureToAsset : Feature -> 'Asset) = this.features |> Array.Parallel.map featureToAsset |> Array.toList

type FeatureDataSet = 
    {
            ConduitFeatureClass: FeatureClass
            CulvertCrossDrainFeatureClass: FeatureClass
            DebrisTrapFeatureClass: FeatureClass
            DitchFeatureClass: FeatureClass
            EndPointFeatureClass: FeatureClass
            InletFeatureClass: FeatureClass
            JunctionFixedFeatureClass: FeatureClass
            OutfallFeatureClass: FeatureClass
            StormwaterPondDischargeFeatureClass: FeatureClass
            StormwaterPondFeatureClass: FeatureClass
    }
    member this.featureClasses = 
        [|
            this.ConduitFeatureClass
            this.CulvertCrossDrainFeatureClass
            this.DebrisTrapFeatureClass
            this.DitchFeatureClass
            this.EndPointFeatureClass
            this.InletFeatureClass
            this.JunctionFixedFeatureClass
            this.OutfallFeatureClass
            this.StormwaterPondDischargeFeatureClass
            this.StormwaterPondFeatureClass
        |]
    member this.features = this.featureClasses |> Array.collect (fun featureClass -> featureClass.features)
    member this.featuresWithAttribute (fieldName:string) = this.features |> Array.filter (fun feature -> feature.hasAttribute fieldName )
    member this.featuresWithoutAttribute (fieldName:string) =   this.features |> Array.filter (fun feature -> not (feature.hasAttribute fieldName ))
    member this.featuresWithDuplicateAttribute (fieldName:string) = 
        this.featuresWithAttribute fieldName
        |> Array.groupBy (fun feature -> feature.attribute fieldName  |> Option.get)
        |> Array.filter (fun (attributeField, features) -> features.Length > 1)
        |> Array.sortBy (fun (attributeField, features) -> attributeField)
    member this.featuresWithoutUNITID = this.featuresWithoutAttribute "UNITID"
    member this.featuresWithDuplicateUNITID = this.featuresWithDuplicateAttribute "UNITID"

    member this.Conduit_to_StormLiftStation =  this.ConduitFeatureClass.assetRows  StormLiftStationRow.fromFeature
    member this.Culvert_Cross_Drain_to_StormServiceLine =  this.CulvertCrossDrainFeatureClass.assetRows  StormServiceLineRow.fromFeature
    member this.Debris_Trap_to_StormValve =  this.DebrisTrapFeatureClass.assetRows  StormValveRow.fromFeature
    member this.Ditch_to_StormBackflowPreventer =  this.DitchFeatureClass.assetRows  StormBackflowPreventerRow.fromFeature
    member this.End_Point_to_StormNode =  this.EndPointFeatureClass.assetRows  StormNodeRow.fromFeature
    member this.Inlet_to_StormInlet =  this.InletFeatureClass.assetRows  StormInletRow.fromFeature
    member this.Junction_Fixed_to_StormManhole =  this.JunctionFixedFeatureClass.assetRows  StormManholeRow.fromFeature
    member this.Outfall_to_Complex =  this.OutfallFeatureClass.assetRows  ComplexRow.fromFeature
    member this.Stormwater_Pond_Discharge_to_StormLevee =  this.StormwaterPondDischargeFeatureClass.assetRows  StormLeveeRow.fromFeature
    member this.Stormwater_Pond_to_StormMiscellaneous =  this.StormwaterPondFeatureClass.assetRows  StormMiscellaneousRow.fromFeature
let StormwaterInfrastructureDataSet = 
    
    {
            ConduitFeatureClass = MapServer.tableByName["Conduit"] |> FeatureClass.fromTable
            CulvertCrossDrainFeatureClass = MapServer.tableByName["Culvert Cross Drain"] |> FeatureClass.fromTable
            DebrisTrapFeatureClass = MapServer.tableByName["Debris Trap"] |> FeatureClass.fromTable
            DitchFeatureClass = MapServer.tableByName["Ditch"] |> FeatureClass.fromTable
            EndPointFeatureClass = MapServer.tableByName["End Point"] |> FeatureClass.fromTable
            InletFeatureClass = MapServer.tableByName["Inlet"] |> FeatureClass.fromTable
            JunctionFixedFeatureClass = MapServer.tableByName["Junction Fixed"] |> FeatureClass.fromTable
            OutfallFeatureClass = MapServer.tableByName["Outfall"] |> FeatureClass.fromTable
            StormwaterPondDischargeFeatureClass = MapServer.tableByName["Stormwater Pond Discharge"] |> FeatureClass.fromTable
            StormwaterPondFeatureClass = MapServer.tableByName["Stormwater Pond"] |> FeatureClass.fromTable
    }



StormwaterInfrastructureDataSet.features.Length

(*
MapServer.fields
|> Array.map (fun field -> $"    member this.{field.Name} = this.attributes |> Array.tryPick (fun (key,value) -> if key = \"{field.Name}\" then Some value else None)")
|> Array.distinct
|> Array.sort
|> String.concat "\n"
|> clip

*)


// Duplicate UnitId Errors
// Unable to locate StormValve asset type in configuration
// CDBProvider:Commit Errors
// Missing UnitId Errors



let dateDirectoryName = DateTime.Now.ToString("yyyy-MM-dd")
let dateDirectory = Directory.CreateDirectory $@"D:\Persistence\XLSX\LCG\{dateDirectoryName}"

let importFile = Path.Combine (dateDirectory.FullName,"LCPW_OverlayStormwaterInfrastructure_D_WM.xlsx" ) |> FileInfo
[
    Worksheet "Conduit"
    FsExcel.Table [ TableName "Conduit_to_StormLiftStation" ; TableItems StormwaterInfrastructureDataSet.Conduit_to_StormLiftStation ]
    FsExcel.AutoFit All
    Worksheet "Culvert Cross Drain"
    FsExcel.Table [ TableName "Culvert_Cross_Drain_to_StormServiceLine" ; TableItems StormwaterInfrastructureDataSet.Culvert_Cross_Drain_to_StormServiceLine ]
    FsExcel.AutoFit All
    Worksheet "Debris Trap"
    FsExcel.Table [ TableName "Debris_Trap_to_StormValve" ; TableItems StormwaterInfrastructureDataSet.Debris_Trap_to_StormValve ]
    FsExcel.AutoFit All
    Worksheet "Ditch"
    FsExcel.Table [ TableName "Ditch_to_StormBackflowPreventer" ; TableItems StormwaterInfrastructureDataSet.Ditch_to_StormBackflowPreventer ]
    FsExcel.AutoFit All
    Worksheet "End Point"
    FsExcel.Table [ TableName "End_Point_to_StormNode" ; TableItems StormwaterInfrastructureDataSet.End_Point_to_StormNode ]
    FsExcel.AutoFit All
    Worksheet "Inlet"
    FsExcel.Table [ TableName "Inlet_to_StormInlet" ; TableItems StormwaterInfrastructureDataSet.Inlet_to_StormInlet ]
    FsExcel.AutoFit All
    Worksheet "Junction Fixed"
    FsExcel.Table [ TableName "Junction_Fixed_to_StormManhole" ; TableItems StormwaterInfrastructureDataSet.Junction_Fixed_to_StormManhole ]
    FsExcel.AutoFit All
    Worksheet "Outfall"
    FsExcel.Table [ TableName "Outfall_to_Complex" ; TableItems StormwaterInfrastructureDataSet.Outfall_to_Complex ]
    FsExcel.AutoFit All
    Worksheet "Stormwater Pond Discharge"
    FsExcel.Table [ TableName "Stormwater_Pond_Discharge_to_StormLevee" ; TableItems StormwaterInfrastructureDataSet.Stormwater_Pond_Discharge_to_StormLevee ]
    FsExcel.AutoFit All
    Worksheet "Stormwater Pond"
    FsExcel.Table [ TableName "Stormwater_Pond_to_StormMiscellaneous" ; TableItems StormwaterInfrastructureDataSet.Stormwater_Pond_to_StormMiscellaneous ]
    FsExcel.AutoFit All
  ]
|> Render.AsFile importFile.FullName


let MappingsXmlFile = Path.Combine(dateDirectory.FullName, "Mappings.xml") |> FileInfo

let sourceFile = FileInfo @"D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM.xlsx"


let MappingsXmlContent = 
    let Maps = elem "Maps"
    let Map = elem "Map"
    let Key = elem "Key"
    let IsDefault = elem "IsDefault"
    let Name = elem "Name"
    let SourceFilePath = elem "SourceFilePath"
    let SheetName = elem "SheetName"
    let ConnectionString = elem "ConnectionString"
    let ProviderName = elem "ProviderName"
    let UploadOption = elem "UploadOption"
    let IsFirstRowHeader = elem "IsFirstRowHeader"
    let CreatedDate = elem "CreatedDate"
    let CreatedBy = elem "CreatedBy"
    let MapColumn = elem "MapColumn"
    let MapKey = elem "MapKey"
    let SourceColumnName = elem "SourceColumnName"
    let TargetColumnCommonId = elem "TargetColumnCommonId"
    let TargetColumnType = elem "TargetColumnType"
    let MapTableInformation = elem "MapTableInformation"
    let ProductFamilyOwner = elem "ProductFamilyOwner"
    let ProductFamilyName = elem "ProductFamilyName"
    let TableName = elem "TableName"
    let TableCommonId = elem "TableCommonId"
    let TableKey = elem "TableKey"

    let mutable key = 0

    Maps { 
        // xmlns "http://www.infor.com/Hansen8/2011/08/Maps.xsd" 
        for assetFeatureIdentity in assetFeatureIdentities do 
            key <- key + 1
            let mapKey = string key
            let mapColumns = 
                propertyAttributeIdentities
                |> List.filter (fun propertyAttributeIdentity -> propertyAttributeIdentity.featureClass =  assetFeatureIdentity.featureClass)
                |> List.filter (fun propertyAttributeIdentity -> 
                    match propertyAttributeIdentity.businessObjectProperty with 
                    | "ID" 
                    | "UnitDesc"
                    | "AddressQualifier"
                        -> true
                    | property when property.EndsWith("Coordinate") -> true
                    | _ -> false 
                )
            Map {

                Key { mapKey  }
                IsDefault { "false" }
                Name { sprintf "%s_to_%s" (assetFeatureIdentity.featureClass.ReplaceWhitespace("_")) (assetFeatureIdentity.businessObject.ReplaceWhitespace("_")) }
                SourceFilePath { sourceFile.FullName }
                SheetName { assetFeatureIdentity.featureClass }
                ConnectionString { """Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM.xlsx;Extended Properties="Excel 12.0;HDR=Yes;IMEX=1";""" }
                ProviderName { "System.Data.OleDb" }
                UploadOption { "6" }
                IsFirstRowHeader { "true" }
                CreatedDate { DateTime.Now.ToString("O") }
                CreatedBy { @"LEONAD\collierb" }
            
                for mapColumn in mapColumns do 
                    
                    
                    MapColumn {
                        MapKey { key }
                        SourceColumnName { mapColumn.businessObjectProperty }
                        TargetColumnCommonId { mapColumn.businessObjectProperty }
                        TargetColumnType { mapColumn.clrType}
                    }
                MapTableInformation {
                    MapKey { key }
                    ProductFamilyOwner { assetFeatureIdentity.owner }
                    ProductFamilyName { assetFeatureIdentity.productFamily }
                    TableName { assetFeatureIdentity.databaseTable }
                    TableCommonId { assetFeatureIdentity.businessObject }
                    TableKey { assetFeatureIdentity.tableKey }
                }
            }

        }

let MappingsXDocument = 
    MappingsXmlContent
    |> ElementBuilder.writeToString 
    |> XDocument.Parse
MappingsXDocument.Declaration.Encoding <- "utf-8"
MappingsXDocument.Declaration.Standalone <- "yes"
MappingsXDocument.Root.DescendantsAndSelf()
    |> Seq.toArray
    |> Array.iter (fun element ->
        if element.Name.Namespace = XNamespace.None then
            element.Name <-
                XNamespace.op_Implicit ("http://www.infor.com/Hansen8/2011/08/Maps.xsd") + element.Name.LocalName
    )
MappingsXDocument.Save MappingsXmlFile.FullName












let mapnames = 
    assetFeatureIdentities
    |> List.map (fun assetFeatureIdentity -> 
            sprintf "%s_to_%s" (assetFeatureIdentity.featureClass.ReplaceWhitespace("_")) (assetFeatureIdentity.businessObject.ReplaceWhitespace("_"))
    )
    |> String.concat ","

let h8importPs1File = Path.Combine(dateDirectory.FullName,"h8import.ps1") |> FileInfo

let h8importPs1Text = 
    $$"""

param(
    [Parameter(Position = 0)]
    [string] $Username,

    [Parameter(Position = 1)]
    [string] $Password
)

$scriptTimer = [System.Diagnostics.Stopwatch]::StartNew()

$hasUsername = $PSBoundParameters.ContainsKey('Username')
$hasPassword = $PSBoundParameters.ContainsKey('Password')

if (-not $hasUsername -and -not $hasPassword) {
    $cred = Get-Credential

    $username = $cred.UserName
    $passwordPlain = $cred.GetNetworkCredential().Password
}
elseif ($hasUsername -and $hasPassword) {
    $username = $Username
    $passwordPlain = $Password
}
else {
    throw "Provide both Username and Password, or provide neither to open the credential prompt."
}

    
& "D:\Infor\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ImportTool\Hansen8ImportToolConsole.exe" --mapnames={{mapnames}} --url=https://infortest.leoncountyfl.gov/test_webservices --provider=Hansen8 --username=$username --password=$passwordPlain

$scriptTimer.Stop()

Write-Host (
    "Total runtime: {0:N3} seconds ({1})" -f
    $scriptTimer.Elapsed.TotalSeconds,
    $scriptTimer.Elapsed
)
    """.TrimStart().TrimEnd()
File.WriteAllText(h8importPs1File.FullName, h8importPs1Text)

let h8importErrorDirectory = Directory.CreateDirectory @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\ArcGIS\h8import_errors"
let errorSummaryFile = Path.Combine(h8importErrorDirectory.FullName, "errorSummary.txt") |> FileInfo


h8importErrorDirectory.GetFiles("*.csv")
|> Array.collect (fun errorFile -> 
    let errorCsv = CsvFile.Load errorFile.FullName
    errorCsv.Rows |> Seq.map (fun errorRow -> errorFile.Name + ", " + errorRow.GetColumn "_ERRORS_") |> Seq.toArray
    )
|> Array.distinct
|> Array.sortBy (fun errorText -> errorText.Length, errorText)
|> String.concat "\n"
|> fun errorSummaryText -> File.WriteAllText(errorSummaryFile.FullName, errorSummaryText)

(*
Hansen 8 Import Tool
==============================
Uploading data for Map: Conduit_to_StormLiftStation started.
Total number of records to be uploaded: 12582.
Successfully uploaded: 12577 records.
Failed to upload: 5 records.
Records that could not be uploaded to the server are written to the file: D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM_ERROR1.csv
Uploading data for Map: Conduit_to_StormLiftStation completed.

Uploading data for Map: Culvert_Cross_Drain_to_StormServiceLine started.
Total number of records to be uploaded: 2648.
Successfully uploaded: 2645 records.
Failed to upload: 3 records.
Records that could not be uploaded to the server are written to the file: D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM_ERROR2.csv
Uploading data for Map: Culvert_Cross_Drain_to_StormServiceLine completed.

Uploading data for Map: Debris_Trap_to_StormValve started.
Total number of records to be uploaded: 3.
Successfully uploaded: 0 records.
Failed to upload: 3 records.
Records that could not be uploaded to the server are written to the file: D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM_ERROR3.csv
Uploading data for Map: Debris_Trap_to_StormValve completed.

Uploading data for Map: Ditch_to_StormBackflowPreventer started.
Total number of records to be uploaded: 2634.
Successfully uploaded: 2632 records.
Failed to upload: 2 records.
Records that could not be uploaded to the server are written to the file: D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM_ERROR4.csv
Uploading data for Map: Ditch_to_StormBackflowPreventer completed.

Uploading data for Map: End_Point_to_StormNode started.
Total number of records to be uploaded: 10206.
Successfully uploaded: 10206 records.
Failed to upload: 0 records.
Uploading data for Map: End_Point_to_StormNode completed.

Uploading data for Map: Inlet_to_StormInlet started.
Total number of records to be uploaded: 8525.
Successfully uploaded: 8524 records.
Failed to upload: 1 records.
Records that could not be uploaded to the server are written to the file: D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM_ERROR5.csv
Uploading data for Map: Inlet_to_StormInlet completed.

Uploading data for Map: Junction_Fixed_to_StormManhole started.
Total number of records to be uploaded: 1672.
Successfully uploaded: 1671 records.
Failed to upload: 1 records.
Records that could not be uploaded to the server are written to the file: D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM_ERROR6.csv
Uploading data for Map: Junction_Fixed_to_StormManhole completed.

Uploading data for Map: Outfall_to_Complex started.
Total number of records to be uploaded: 266.
Successfully uploaded: 266 records.
Failed to upload: 0 records.
Uploading data for Map: Outfall_to_Complex completed.

Uploading data for Map: Stormwater_Pond_Discharge_to_StormLevee started.
Total number of records to be uploaded: 1124.
Successfully uploaded: 1124 records.
Failed to upload: 0 records.
Uploading data for Map: Stormwater_Pond_Discharge_to_StormLevee completed.

Uploading data for Map: Stormwater_Pond_to_StormMiscellaneous started.
Total number of records to be uploaded: 588.
Successfully uploaded: 585 records.
Failed to upload: 3 records.
Records that could not be uploaded to the server are written to the file: D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM_ERROR7.csv
Uploading data for Map: Stormwater_Pond_to_StormMiscellaneous completed.

Total runtime: 7,479.993 seconds (02:04:39.9931766)
*)

