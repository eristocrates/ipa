// TODO use dynamic operator for namespacenames for adhoc local names

#time on
fsi.PrintLength <- 10
fsi.PrintSize <- 300
// fsi.ShowDeclarationValues <- false
#I @"D:\https\com\github\eristocrates\ipa\dll"
#r "SharedKernel.dll"
#r "StringModule.dll"
#r "Internet.dll"
#r "TopLevelDomain.dll"
#r "IanaScheme.dll"
#r "ResourceIdentification.dll"
#r "ResourceDescription.dll"
#r "Iana.dll"
#r "IanaMime.dll"
#r "NetworkMonitor.dll"
#r "Turtle.dll"
#r @"DataTierApplication.dll"
#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load "Ast.fsx"
open SharedKernel
open StringModule
open DataTierApplication
open Internet
open ResourceIdentification
open ResourceDescription
open Turtle
open Iana
open NetworkMonitor

#load @"C:\Secret\InforSecrets.fsx"
#load @"C:\Secret\EsriSecrets.fsx"
#load @"C:\Secret\ProjectDoxSecrets.fsx"
#load @".paket/load/main.group.fsx"

module FSharpLiteral = FSharp.Literals.Literal

// #r "nuget: Microsoft.SqlServer.DacFx"
open AW.Identifiers
open BrowserApi.Dom
open BrowserApi.Css
open BrowserApi.Css.Authoring
open CaseConverter
open Fabulous.AST
open Fantomas.Core
open FolkerKinzel.MimeTypes
open FsExcel
open FSharp.Collections.ParallelSeq
open FSharp.Data
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open FSharp.Text.RegexExtensions
open FSharp.Text.RegexProvider
open Humanizer
open IriTools
open ktsu.Semantics.Paths
open LSL.DataUri
open Meziantou.Framework
open Microsoft.SqlServer.Dac
open Microsoft.SqlServer.Dac.Model
open PuppeteerSharp
open BrowserApi
open PuppeteerSharp.Cdp
open RDFSharp.Model
open System
open System.IO
open System.Linq
open System.Text
open System.Text.RegularExpressions
open System.Threading
open System.Threading.Tasks
open System.Web
open Tavis.UriTemplates
open TextCopy
open Universal.Common
open VDS.RDF
open VDS.RDF.Parsing
open FSharp.Text.RegexProvider
open FSharp.Text.RegexExtensions
open PuppeteerSharp.Input

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

type Feature with
    static member Query (offset: int) (table: ServiceFeatureTable) =
        Array.concat [|

            let query = QueryParameters()
            query.WhereClause <- "1 = 1"
            query.ReturnGeometry <- true
            query.ResultOffset <- offset
            query.MaxFeatures <- int table.LayerInfo.MaxRecordCount

            let features =
                table.QueryFeaturesAsync(query, QueryFeatureFields.LoadAll)
                |> Async.AwaitTask
                |> Async.RunSynchronously
                |> Seq.toArray

            if features.Length = 0 then
                [||]
            else
                table |> Feature.Query(offset + features.Length) |> Array.append features
        |]

    member this.attributes =
        this.Attributes
        |> Seq.toArray
        |> Array.map (|KeyValue|)
        |> Array.filter (fun (key, objValue) -> objValue <> null)
        |> Array.filter (fun (key, objValue) -> not (String.IsNullOrWhiteSpace(string objValue)))
        |> Array.map (fun (key, objValue) -> key, string objValue)
    member this.attribute(fieldName: string) =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = fieldName then Some value else None)
    member this.hasAttribute(fieldName: string) =
        match this.attribute fieldName with
        | Some _ -> true
        | None -> false
type StormwaterFeature =
    | StormwaterFeature of Feature

    member this.feature =
        match this with
        | StormwaterFeature feature -> feature
    member this.attributes = this.feature.attributes
    member this.X =
        match this.feature.Geometry with
        | :? MapPoint as mapPoint -> string mapPoint.X
        | _ -> String.Empty
    member this.Y =
        match this.feature.Geometry with
        | :? MapPoint as mapPoint -> string mapPoint.Y
        | _ -> String.Empty
    member this.Z =
        match this.feature.Geometry with
        | :? MapPoint as mapPoint -> string mapPoint.Z
        | _ -> String.Empty

    member this.AddressQualifier = defaultArg this.LOCATION String.Empty
    member this.Organization = defaultArg this.MAINTBY String.Empty
    member this.UnitDesc = defaultArg this.NOTES String.Empty
    member this.Area = defaultArg this.OUTFALLID String.Empty
    member this.Ownership = defaultArg this.OWNER String.Empty
    member this.ID = defaultArg this.UNITID String.Empty
    member this.ZCoordinate = defaultArg this.ZVALUE String.Empty
    member this.UnitType = defaultArg this.PONDTYPE String.Empty

    member this.ACCEPT_DATE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ACCEPT_DATE" then Some value else None)
    member this.ACCURACYCODE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ACCURACYCODE" then Some value else None)
    member this.ACREAGE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ACREAGE" then Some value else None)
    member this.ACRES =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ACRES" then Some value else None)
    member this.ACTIVITY =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ACTIVITY" then Some value else None)
    member this.ANCILLARYROLE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ANCILLARYROLE" then Some value else None)
    member this.ATTACHEDTOID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ATTACHEDTOID" then Some value else None)
    member this.ATTRIBUTECOMPLETE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ATTRIBUTECOMPLETE" then Some value else None)
    member this.CAPACITY =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "CAPACITY" then Some value else None)
    member this.CREATIONDATE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "CREATIONDATE" then Some value else None)
    member this.CREATOR =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "CREATOR" then Some value else None)
    member this.CREW =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "CREW" then Some value else None)
    member this.DAMAGEID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DAMAGEID" then Some value else None)
    member this.DAMAGETYPE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DAMAGETYPE" then Some value else None)
    member this.DATAFILE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DATAFILE" then Some value else None)
    member this.DATECREATED =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DATECREATED" then Some value else None)
    member this.DATEMODIFIED =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DATEMODIFIED" then Some value else None)
    member this.DATE_ =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DATE_" then Some value else None)
    member this.DESCRIPTION =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DESCRIPTION" then Some value else None)
    member this.DIAMETER =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DIAMETER" then Some value else None)
    member this.DIGITALPICTUREID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DIGITALPICTUREID" then Some value else None)
    member this.DIGITALPICTUREID_E =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DIGITALPICTUREID_E" then Some value else None)
    member this.DIGITALPICTUREID_S =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DIGITALPICTUREID_S" then Some value else None)
    member this.DIGITALPICTUREID_W =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DIGITALPICTUREID_W" then Some value else None)
    member this.DOWNSTREAMDEPTH =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DOWNSTREAMDEPTH" then Some value else None)
    member this.DOWNSTREAMELEVATION =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DOWNSTREAMELEVATION" then Some value else None)
    member this.DOWNSTREAM_DEPTH =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DOWNSTREAM_DEPTH" then Some value else None)
    member this.DOWNSTREAM_ELEV =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DOWNSTREAM_ELEV" then Some value else None)
    member this.DRAINAGEAREA =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DRAINAGEAREA" then Some value else None)
    member this.DRAINAGEBASIN =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DRAINAGEBASIN" then Some value else None)
    member this.DRAINAGE_AREA =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DRAINAGE_AREA" then Some value else None)
    member this.DRAWINGID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "DRAWINGID" then Some value else None)
    member this.EASTING =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "EASTING" then Some value else None)
    member this.EDITDATE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "EDITDATE" then Some value else None)
    member this.EDITOR =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "EDITOR" then Some value else None)
    member this.ELEMENTX =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ELEMENTX" then Some value else None)
    member this.ELEMENTY =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ELEMENTY" then Some value else None)
    member this.ENABLED =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ENABLED" then Some value else None)
    member this.FACILITYID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FACILITYID" then Some value else None)
    member this.FIELDCOMMENTS =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FIELDCOMMENTS" then Some value else None)
    member this.FIELDCOMPLETE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FIELDCOMPLETE" then Some value else None)
    member this.FIELDCREW =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FIELDCREW" then Some value else None)
    member this.FIELD_COMMENTS_ =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FIELD_COMMENTS_" then Some value else None)
    member this.FILE_NAME =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FILE_NAME" then Some value else None)
    member this.FILE_NAME_1 =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FILE_NAME_1" then Some value else None)
    member this.FILTER =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FILTER" then Some value else None)
    member this.FILTERLOCATION =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FILTERLOCATION" then Some value else None)
    member this.FILTERTYPE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FILTERTYPE" then Some value else None)
    member this.FINAL_NAME =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FINAL_NAME" then Some value else None)
    member this.FOLDER =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "FOLDER" then Some value else None)
    member this.GLOBALID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "GLOBALID" then Some value else None)
    member this.HEIGHT =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "HEIGHT" then Some value else None)
    member this.HOTLINK =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "HOTLINK" then Some value else None)
    member this.HYD_ID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "HYD_ID" then Some value else None)
    member this.HYPERLINK =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "HYPERLINK" then Some value else None)
    member this.HYPERLINK_AR =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "HYPERLINK_AR" then Some value else None)
    member this.IMAGERYYEAR =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "IMAGERYYEAR" then Some value else None)
    member this.INFILTRATION =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "INFILTRATION" then Some value else None)
    member this.INSPDATE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "INSPDATE" then Some value else None)
    member this.INVENTORIED_BY =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "INVENTORIED_BY" then Some value else None)
    member this.INVENTORYDATE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "INVENTORYDATE" then Some value else None)
    member this.INVENTORYTYPE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "INVENTORYTYPE" then Some value else None)
    member this.INVERTELEV =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "INVERTELEV" then Some value else None)
    member this.INVERT_ELEV =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "INVERT_ELEV" then Some value else None)
    member this.INVERT_ELEV29 =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "INVERT_ELEV29" then Some value else None)
    member this.ISINFALL =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ISINFALL" then Some value else None)
    member this.LEGACYID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "LEGACYID" then Some value else None)
    member this.LEGACY_ID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "LEGACY_ID" then Some value else None)
    member this.LFEET =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "LFEET" then Some value else None)
    member this.LIFECYCLE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "LIFECYCLE" then Some value else None)
    member this.LOCATION =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "LOCATION" then Some value else None)
    member this.LOC_DESC =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "LOC_DESC" then Some value else None)
    member this.MAINTBY =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "MAINTBY" then Some value else None)
    member this.MATERIAL =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "MATERIAL" then Some value else None)
    member this.MEDIA_CODE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "MEDIA_CODE" then Some value else None)
    member this.MILES =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "MILES" then Some value else None)
    member this.NEEDSATTENTION =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "NEEDSATTENTION" then Some value else None)
    member this.NORTHING =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "NORTHING" then Some value else None)
    member this.NOTES =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "NOTES" then Some value else None)
    member this.NUM_BARRELS =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "NUM_BARRELS" then Some value else None)
    member this.OBJECTID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "OBJECTID" then Some value else None)
    member this.OBSTRUCTION =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "OBSTRUCTION" then Some value else None)
    member this.ORIGINALSOURCE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ORIGINALSOURCE" then Some value else None)
    member this.OUTFALLID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "OUTFALLID" then Some value else None)
    member this.OUTFALLTYPE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "OUTFALLTYPE" then Some value else None)
    member this.OWNER =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "OWNER" then Some value else None)
    member this.PARCELID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PARCELID" then Some value else None)
    member this.PARENTID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PARENTID" then Some value else None)
    member this.PERCT_GRD =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PERCT_GRD" then Some value else None)
    member this.PHOTOID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PHOTOID" then Some value else None)
    member this.PHOTO_FOLDER =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PHOTO_FOLDER" then Some value else None)
    member this.PHOTO_NUM =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PHOTO_NUM" then Some value else None)
    member this.PID_1 =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PID_1" then Some value else None)
    member this.PIPESHAPE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PIPESHAPE" then Some value else None)
    member this.PLACE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PLACE" then Some value else None)
    member this.PONDID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PONDID" then Some value else None)
    member this.PONDTYPE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PONDTYPE" then Some value else None)
    member this.PONDYR =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PONDYR" then Some value else None)
    member this.POND_ID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "POND_ID" then Some value else None)
    member this.PRFRESOLUTION =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "PRFRESOLUTION" then Some value else None)
    member this.RAW_NAME =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "RAW_NAME" then Some value else None)
    member this.RELATEDFEATURE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "RELATEDFEATURE" then Some value else None)
    member this.ROTATION_AZ =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ROTATION_AZ" then Some value else None)
    member this.SHAPE_Area =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "SHAPE_Area" then Some value else None)
    member this.SHAPE_Length =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "SHAPE_Length" then Some value else None)
    member this.SLOT_ELEV =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "SLOT_ELEV" then Some value else None)
    member this.SOURCE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "SOURCE" then Some value else None)
    member this.SOURCEYEAR =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "SOURCEYEAR" then Some value else None)
    member this.STORAGE_FULL_PATH_ADDR =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "STORAGE_FULL_PATH_ADDR" then Some value else None)
    member this.STORAGE_PATH_ADDR =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "STORAGE_PATH_ADDR" then Some value else None)
    member this.STORAGE_STATIC_PATH_ADDR =
        this.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "STORAGE_STATIC_PATH_ADDR" then
                Some value
            else
                None)
    member this.STRCT_DEPTH =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "STRCT_DEPTH" then Some value else None)
    member this.STRUCTUREID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "STRUCTUREID" then Some value else None)
    member this.STRUCTURETYPE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "STRUCTURETYPE" then Some value else None)
    member this.STRUCTURE_ID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "STRUCTURE_ID" then Some value else None)
    member this.SUBTYPEFIELD =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "SUBTYPEFIELD" then Some value else None)
    member this.SURFACETYPE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "SURFACETYPE" then Some value else None)
    member this.Shape_Area =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "Shape_Area" then Some value else None)
    member this.Shape_Length =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "Shape_Length" then Some value else None)
    member this.UNDERDRAINS =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "UNDERDRAINS" then Some value else None)
    member this.UNITDESC =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "UNITDESC" then Some value else None)
    member this.UNITID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "UNITID" then Some value else None)
    member this.UPDATESOURCE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "UPDATESOURCE" then Some value else None)
    member this.UPSTREAMDEPTH =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "UPSTREAMDEPTH" then Some value else None)
    member this.UPSTREAMELEVATION =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "UPSTREAMELEVATION" then Some value else None)
    member this.UPSTREAMSTUCTUREID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "UPSTREAMSTUCTUREID" then Some value else None)
    member this.UPSTREAM_DEPTH =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "UPSTREAM_DEPTH" then Some value else None)
    member this.UPSTREAM_ELEV =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "UPSTREAM_ELEV" then Some value else None)
    member this.VIEW_ =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "VIEW_" then Some value else None)
    member this.WATERBODYNAME =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "WATERBODYNAME" then Some value else None)
    member this.WBID =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "WBID" then Some value else None)
    member this.WHOCREATED =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "WHOCREATED" then Some value else None)
    member this.WHOMODIFIED =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "WHOMODIFIED" then Some value else None)
    member this.WIDTH =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "WIDTH" then Some value else None)
    member this.Z29 =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "Z29" then Some value else None)
    member this.ZVALUE =
        this.attributes
        |> Array.tryPick (fun (key, value) -> if key = "ZVALUE" then Some value else None)

type StormLiftStationRow = {
    ID: string
    UnitDesc: string
    Area: string
    Organization: string
    Ownership: string
} with

    static member fromFeature(feature: StormwaterFeature) = {

        Organization = feature.Organization
        UnitDesc = feature.UnitDesc
        Area = feature.Area
        Ownership = feature.Ownership
        ID = feature.ID
    }

type StormServiceLineRow = {
    ID: string
    UnitDesc: string
    Area: string
    Organization: string
    Ownership: string
} with

    static member fromFeature(feature: StormwaterFeature) = {
        Organization = feature.Organization
        UnitDesc = feature.UnitDesc
        Area = feature.Area
        Ownership = feature.Ownership
        ID = feature.ID
    }

type StormValveRow = {
    ID: string
    UnitDesc: string
    AddressQualifier: string
    Area: string
    Organization: string
    Ownership: string
    XCoordinate: string
    YCoordinate: string
    ZCoordinate: string
} with

    static member fromFeature(feature: StormwaterFeature) = {
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

type StormBackflowPreventerRow = {
    ID: string
    UnitDesc: string
    Area: string
    Organization: string
    Ownership: string
} with

    static member fromFeature(feature: StormwaterFeature) = {
        Organization = feature.Organization
        UnitDesc = feature.UnitDesc
        Area = feature.Area
        Ownership = feature.Ownership
        ID = feature.ID
    }

type StormNodeRow = {
    ID: string
    UnitDesc: string
    AddressQualifier: string
    Area: string
    Organization: string
    Ownership: string
    XCoordinate: string
    YCoordinate: string
    ZCoordinate: string
} with

    static member fromFeature(feature: StormwaterFeature) = {
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

type StormInletRow = {
    ID: string
    UnitDesc: string
    AddressQualifier: string
    Area: string
    Organization: string
    Ownership: string
    XCoordinate: string
    YCoordinate: string
    ZCoordinate: string
} with

    static member fromFeature(feature: StormwaterFeature) = {
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

type StormManholeRow = {
    ID: string
    UnitDesc: string
    AddressQualifier: string
    Area: string
    Organization: string
    Ownership: string
    XCoordinate: string
    YCoordinate: string
    ZCoordinate: string
} with

    static member fromFeature(feature: StormwaterFeature) = {
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

type ComplexRow = {
    ID: string
    UnitDesc: string
    Area: string
    XCoordinate: string
    YCoordinate: string
} with

    static member fromFeature(feature: StormwaterFeature) = {
        UnitDesc = feature.UnitDesc
        Area = feature.Area
        ID = feature.ID
        XCoordinate = feature.X
        YCoordinate = feature.Y
    }

type StormLeveeRow = {
    ID: string
    UnitDesc: string
    AddressQualifier: string
    Area: string
    Organization: string
    Ownership: string
    XCoordinate: string
    YCoordinate: string
    ZCoordinate: string
} with

    static member fromFeature(feature: StormwaterFeature) = {
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

type StormMiscellaneousRow = {
    ID: string
    UnitDesc: string
    UnitType: string
    AddressQualifier: string
    Organization: string
    Ownership: string
    XCoordinate: string
    YCoordinate: string
    ZCoordinate: string
} with

    static member fromFeature(feature: StormwaterFeature) = {
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
    member this.aliased_fields =
        this.Fields
        |> Seq.filter (fun field -> field.Name <> field.Alias)
        |> Seq.toArray
    member this.features = this |> Feature.Query 0

type ArcGISMapImageLayer with
    member this.sublayers =
        this.Sublayers
        |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer)
        |> Seq.toArray
    member this.sublayerInfos = this.sublayers |> Array.map (fun layer -> layer.MapServiceSublayerInfo)
    member this.ungroupedLayers =
        this.sublayers
        |> Array.filter (fun layer -> layer.MapServiceSublayerInfo.SublayerType = ArcGISMapServiceSublayerType.FeatureLayer)
    member this.ungroupedTables = this.ungroupedLayers |> Array.map (fun featureLayer -> featureLayer.Table)
    member this.ungroupedFields = this.ungroupedTables |> Array.collect (fun table -> table.Fields |> Seq.toArray)
    member this.ungroupedLayerInfos = this.ungroupedLayers |> Array.map (fun layer -> layer.MapServiceSublayerInfo)
    member this.ungroupedLayerInfosByName(name: string) =
        this.ungroupedLayerInfos
        |> Array.filter (fun featureLayerInfo -> featureLayerInfo.ServiceLayerName = name)
    member this.ungroupedLayerByName(name: string) =
        this.ungroupedLayers
        |> Array.find (fun ungroupedLayer -> ungroupedLayer.Name = name)
    member this.groupLayers =
        this.sublayers
        |> Array.filter (fun layer -> layer.MapServiceSublayerInfo.SublayerType = ArcGISMapServiceSublayerType.GroupLayer)
    member this.groupLayerInfos = this.groupLayers |> Array.map (fun layer -> layer.MapServiceSublayerInfo)
    member this.groupLayerInfosByName(name: string) =
        this.groupLayerInfos
        |> Array.filter (fun groupLayerInfo -> groupLayerInfo.ServiceLayerName = name)
    member this.groupLayerByName(name: string) =
        this.groupLayers |> Array.find (fun groupLayer -> groupLayer.Name = name)
    member this.drainageNetworkLayers =
        this.groupLayers[0].Sublayers
        |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer)
        |> Seq.toArray
    member this.drainageNetworkSublayerIds = this.groupLayers[0].Sublayers |> Seq.map (fun layer -> layer.Id) |> Seq.toArray
    member this.drainageNetworkTables = this.drainageNetworkLayers |> Array.map (fun featureLayer -> featureLayer.Table)
    member this.drainageNetworkFields =
        this.drainageNetworkTables
        |> Array.collect (fun table -> table.Fields |> Seq.toArray)
    member this.drainageNetworkLayerInfos =
        this.drainageNetworkLayers
        |> Array.map (fun layer -> layer.MapServiceSublayerInfo)
    member this.drainageNetworkLayerInfosByName(name: string) =
        this.drainageNetworkLayerInfos
        |> Array.filter (fun drainageNetworkLayerInfo -> drainageNetworkLayerInfo.ServiceLayerName = name)
    member this.nondrainageNetworkLayers =
        this.groupLayers[1].Sublayers
        |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer)
        |> Seq.toArray
    member this.nondrainageNetworkSublayerIds = this.groupLayers[1].Sublayers |> Seq.map (fun layer -> layer.Id) |> Seq.toArray
    member this.nondrainageNetworkTables =
        this.nondrainageNetworkLayers
        |> Array.map (fun featureLayer -> featureLayer.Table)
    member this.nondrainageNetworkFields =
        this.nondrainageNetworkTables
        |> Array.collect (fun table -> table.Fields |> Seq.toArray)
    member this.nondrainageNetworkLayerInfos =
        this.nondrainageNetworkLayers
        |> Array.map (fun layer -> layer.MapServiceSublayerInfo)
    member this.nondrainageNetworkLayerInfosByName(name: string) =
        this.nondrainageNetworkLayerInfos
        |> Array.filter (fun nondrainageNetworkLayerInfo -> nondrainageNetworkLayerInfo.ServiceLayerName = name)
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
    member this.featureLayerInfosByName(name: string) =
        this.featureLayerInfos
        |> Array.filter (fun featureLayerInfo -> featureLayerInfo.ServiceLayerName = name)
    member this.tables =
        let tables =
            Array.concat [|
                this.ungroupedTables
                this.drainageNetworkTables
                this.nondrainageNetworkTables
            |]
        tables
        |> Array.iter (fun table -> table.FeatureRequestMode <- FeatureRequestMode.OnInteractionCache)
        tables
    member this.tableByName = this.tables |> Array.map (fun table -> table.TableName, table) |> Map.ofArray
    member this.tablesWithField(fieldName: string) =
        this.tables
        |> Array.choose (fun table ->
            let fieldExists = table.Fields |> Seq.exists (fun field -> field.Name = fieldName)
            if fieldExists then Some table else None

        )
    member this.tablesByName(name: string) =
        this.tables
        |> Array.filter (fun table -> table.LayerInfo.ServiceLayerName = name)
    member this.fields =
        Array.concat [|
            this.ungroupedFields
            this.drainageNetworkFields
            this.nondrainageNetworkFields
        |]
    member this.fieldsByTable(tableName: string) =
        let table = this.tablesByName tableName |> Array.exactlyOne
        table.Fields |> Seq.toArray
    member this.fieldsByQualifiedName (tableName: string) (fieldName: string) =
        let table = this.tablesByName tableName |> Array.exactlyOne
        table.Fields |> Seq.find (fun field -> field.Name = fieldName)
    member this.features = this.tables |> Array.collect (fun table -> table.features)

ArcGISRuntimeEnvironment.Initialize()
let StormwaterInfrastructure =
    ArcGISMapImageLayer(new Uri "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer")

StormwaterInfrastructure.LoadTablesAndLayersAsync()
|> Async.AwaitTask
|> Async.RunSynchronously

type FeatureClass = {
    imageLayer: ArcGISMapImageSublayer
    featureLayer: FeatureLayer
    featureTable: ServiceFeatureTable
    features: Feature array
} with

    static member fromStormwaterTable(featureTable: ServiceFeatureTable) = {
        imageLayer = StormwaterInfrastructure.featureLayersById[featureTable.ServiceLayerId]
        featureLayer = featureTable.Layer :?> FeatureLayer
        featureTable = featureTable
        features = featureTable.features
    }
    member this.assetRows(featureToAsset: StormwaterFeature -> 'Asset) =
        this.features
        |> Array.Parallel.map (fun feature -> StormwaterFeature feature |> featureToAsset)
        |> Array.toList

type StormwaterFeatureDataSet = {
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
} with

    member this.featureClasses = [|
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
    member this.featuresWithAttribute(fieldName: string) =
        this.features |> Array.filter (fun feature -> feature.hasAttribute fieldName)
    member this.featuresWithoutAttribute(fieldName: string) =
        this.features
        |> Array.filter (fun feature -> not (feature.hasAttribute fieldName))
    member this.featuresWithDuplicateAttribute(fieldName: string) =
        this.featuresWithAttribute fieldName
        |> Array.groupBy (fun feature -> feature.attribute fieldName |> Option.get)
        |> Array.filter (fun (attributeField, features) -> features.Length > 1)
        |> Array.sortBy (fun (attributeField, features) -> attributeField)
    member this.featuresWithoutUNITID = this.featuresWithoutAttribute "UNITID"
    member this.featuresWithDuplicateUNITID = this.featuresWithDuplicateAttribute "UNITID"

    member this.Conduit_to_StormLiftStation = this.ConduitFeatureClass.assetRows StormLiftStationRow.fromFeature
    member this.Culvert_Cross_Drain_to_StormServiceLine = this.CulvertCrossDrainFeatureClass.assetRows StormServiceLineRow.fromFeature
    member this.Debris_Trap_to_StormValve = this.DebrisTrapFeatureClass.assetRows StormValveRow.fromFeature
    member this.Ditch_to_StormBackflowPreventer = this.DitchFeatureClass.assetRows StormBackflowPreventerRow.fromFeature
    member this.End_Point_to_StormNode = this.EndPointFeatureClass.assetRows StormNodeRow.fromFeature
    member this.Inlet_to_StormInlet = this.InletFeatureClass.assetRows StormInletRow.fromFeature
    member this.Junction_Fixed_to_StormManhole = this.JunctionFixedFeatureClass.assetRows StormManholeRow.fromFeature
    member this.Outfall_to_Complex = this.OutfallFeatureClass.assetRows ComplexRow.fromFeature
    member this.Stormwater_Pond_Discharge_to_StormLevee = this.StormwaterPondDischargeFeatureClass.assetRows StormLeveeRow.fromFeature
    member this.Stormwater_Pond_to_StormMiscellaneous = this.StormwaterPondFeatureClass.assetRows StormMiscellaneousRow.fromFeature
let StormwaterInfrastructureDataSet =

    {
        ConduitFeatureClass =
            StormwaterInfrastructure.tableByName["Conduit"]
            |> FeatureClass.fromStormwaterTable
        CulvertCrossDrainFeatureClass =
            StormwaterInfrastructure.tableByName["Culvert Cross Drain"]
            |> FeatureClass.fromStormwaterTable
        DebrisTrapFeatureClass =
            StormwaterInfrastructure.tableByName["Debris Trap"]
            |> FeatureClass.fromStormwaterTable
        DitchFeatureClass =
            StormwaterInfrastructure.tableByName["Ditch"]
            |> FeatureClass.fromStormwaterTable
        EndPointFeatureClass =
            StormwaterInfrastructure.tableByName["End Point"]
            |> FeatureClass.fromStormwaterTable
        InletFeatureClass =
            StormwaterInfrastructure.tableByName["Inlet"]
            |> FeatureClass.fromStormwaterTable
        JunctionFixedFeatureClass =
            StormwaterInfrastructure.tableByName["Junction Fixed"]
            |> FeatureClass.fromStormwaterTable
        OutfallFeatureClass =
            StormwaterInfrastructure.tableByName["Outfall"]
            |> FeatureClass.fromStormwaterTable
        StormwaterPondDischargeFeatureClass =
            StormwaterInfrastructure.tableByName["Stormwater Pond Discharge"]
            |> FeatureClass.fromStormwaterTable
        StormwaterPondFeatureClass =
            StormwaterInfrastructure.tableByName["Stormwater Pond"]
            |> FeatureClass.fromStormwaterTable
    }

let LeonCountyCommissionDistricts =
    ArcGISMapImageLayer(new Uri "https://intervector.leoncountyfl.gov/intervector/rest/services/MapServices/TLC_OverlayCommissionDistrictFeature_D_WM/MapServer")

LeonCountyCommissionDistricts.LoadTablesAndLayersAsync()
|> Async.AwaitTask
|> Async.RunSynchronously

let DistrictFeatureClass =
    let imageLayer = LeonCountyCommissionDistricts.sublayers[0]
    {
        imageLayer = imageLayer
        featureLayer = imageLayer.Table.Layer :?> FeatureLayer
        featureTable = imageLayer.Table
        features = imageLayer.Table.features
    }

let targetFeatures =
    StormwaterInfrastructureDataSet.features
    |> Array.filter (fun feature ->
        let stormwaterFeature = StormwaterFeature feature
        match stormwaterFeature.UNITID with
        | Some unitId -> unitId.StartsWith("G")
        | _ -> false)
targetFeatures.Length
let polygon = DistrictFeatureClass.features[0].Geometry :?> Polygon
DistrictFeatureClass.features[0].attributes

let district (id: int) = DistrictFeatureClass.features[id - 1]
type DistrictFeature =
    | DistrictFeature of Feature

    member this.feature =
        match this with
        | DistrictFeature feature -> feature
    member this.attributes = this.feature.attributes
    member this.Polygon = this.feature.Geometry :?> Polygon

let District1 = district 1 |> DistrictFeature
let District2 = district 2 |> DistrictFeature
let District3 = district 3 |> DistrictFeature
let District4 = district 4 |> DistrictFeature
let District5 = district 5 |> DistrictFeature

District1.Polygon
