#load @".paket/load/main.group.fsx"
#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"

#r "TaskErgonomics.dll"

open TaskErgonomics

open System

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

#load @"C:\Secret\EsriSecrets.fsx"



let StormwaterInfrastructureMapImageLayer =
    ArcGISMapImageLayer(new Uri(EsriSecrets.StormwaterInfrastructurePath))

StormwaterInfrastructureMapImageLayer
    .LoadTablesAndLayersAsync()
    .await

ArcGISRuntimeEnvironment.Initialize()

module Feature =
    let rec Query (offset: int) (table: ServiceFeatureTable) =
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
                            table
                            |> Query(offset + features.Length)
                            |> Array.append features |]

type Feature with


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
        |> Array.filter (fun (key, objValue) -> objValue <> null)
        |> Array.filter (fun (key, objValue) -> not (String.IsNullOrWhiteSpace(string objValue)))
        |> Array.map (fun (key, objValue) -> key, string objValue)

    member this.attribute(fieldName: string) =
        this.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = fieldName then
                Some value
            else
                None)

    member this.hasAttribute(fieldName: string) =
        match this.attribute fieldName with
        | Some _ -> true
        | None -> false

type StormwaterFeature =
    | StormwaterFeature of Feature
    member this.feature =
        match this with
        | StormwaterFeature feature -> feature


    member this.ACCEPT_DATE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ACCEPT_DATE" then
                Some value
            else
                None)

    member this.ACCURACYCODE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ACCURACYCODE" then
                Some value
            else
                None)

    member this.ACREAGE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ACREAGE" then
                Some value
            else
                None)

    member this.ACRES =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ACRES" then
                Some value
            else
                None)

    member this.ACTIVITY =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ACTIVITY" then
                Some value
            else
                None)

    member this.ANCILLARYROLE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ANCILLARYROLE" then
                Some value
            else
                None)

    member this.ATTACHEDTOID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ATTACHEDTOID" then
                Some value
            else
                None)

    member this.ATTRIBUTECOMPLETE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ATTRIBUTECOMPLETE" then
                Some value
            else
                None)

    member this.CAPACITY =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "CAPACITY" then
                Some value
            else
                None)

    member this.CREATIONDATE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "CREATIONDATE" then
                Some value
            else
                None)

    member this.CREATOR =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "CREATOR" then
                Some value
            else
                None)

    member this.CREW =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "CREW" then
                Some value
            else
                None)

    member this.DAMAGEID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DAMAGEID" then
                Some value
            else
                None)

    member this.DAMAGETYPE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DAMAGETYPE" then
                Some value
            else
                None)

    member this.DATAFILE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DATAFILE" then
                Some value
            else
                None)

    member this.DATECREATED =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DATECREATED" then
                Some value
            else
                None)

    member this.DATEMODIFIED =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DATEMODIFIED" then
                Some value
            else
                None)

    member this.DATE_ =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DATE_" then
                Some value
            else
                None)

    member this.DESCRIPTION =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DESCRIPTION" then
                Some value
            else
                None)

    member this.DIAMETER =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DIAMETER" then
                Some value
            else
                None)

    member this.DIGITALPICTUREID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DIGITALPICTUREID" then
                Some value
            else
                None)

    member this.DIGITALPICTUREID_E =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DIGITALPICTUREID_E" then
                Some value
            else
                None)

    member this.DIGITALPICTUREID_S =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DIGITALPICTUREID_S" then
                Some value
            else
                None)

    member this.DIGITALPICTUREID_W =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DIGITALPICTUREID_W" then
                Some value
            else
                None)

    member this.DOWNSTREAMDEPTH =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DOWNSTREAMDEPTH" then
                Some value
            else
                None)

    member this.DOWNSTREAMELEVATION =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DOWNSTREAMELEVATION" then
                Some value
            else
                None)

    member this.DOWNSTREAM_DEPTH =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DOWNSTREAM_DEPTH" then
                Some value
            else
                None)

    member this.DOWNSTREAM_ELEV =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DOWNSTREAM_ELEV" then
                Some value
            else
                None)

    member this.DRAINAGEAREA =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DRAINAGEAREA" then
                Some value
            else
                None)

    member this.DRAINAGEBASIN =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DRAINAGEBASIN" then
                Some value
            else
                None)

    member this.DRAINAGE_AREA =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DRAINAGE_AREA" then
                Some value
            else
                None)

    member this.DRAWINGID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "DRAWINGID" then
                Some value
            else
                None)

    member this.EASTING =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "EASTING" then
                Some value
            else
                None)

    member this.EDITDATE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "EDITDATE" then
                Some value
            else
                None)

    member this.EDITOR =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "EDITOR" then
                Some value
            else
                None)

    member this.ELEMENTX =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ELEMENTX" then
                Some value
            else
                None)

    member this.ELEMENTY =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ELEMENTY" then
                Some value
            else
                None)

    member this.ENABLED =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ENABLED" then
                Some value
            else
                None)

    member this.FACILITYID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FACILITYID" then
                Some value
            else
                None)

    member this.FIELDCOMMENTS =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FIELDCOMMENTS" then
                Some value
            else
                None)

    member this.FIELDCOMPLETE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FIELDCOMPLETE" then
                Some value
            else
                None)

    member this.FIELDCREW =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FIELDCREW" then
                Some value
            else
                None)

    member this.FIELD_COMMENTS_ =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FIELD_COMMENTS_" then
                Some value
            else
                None)

    member this.FILE_NAME =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FILE_NAME" then
                Some value
            else
                None)

    member this.FILE_NAME_1 =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FILE_NAME_1" then
                Some value
            else
                None)

    member this.FILTER =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FILTER" then
                Some value
            else
                None)

    member this.FILTERLOCATION =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FILTERLOCATION" then
                Some value
            else
                None)

    member this.FILTERTYPE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FILTERTYPE" then
                Some value
            else
                None)

    member this.FINAL_NAME =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FINAL_NAME" then
                Some value
            else
                None)

    member this.FOLDER =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "FOLDER" then
                Some value
            else
                None)

    member this.GLOBALID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "GLOBALID" then
                Some value
            else
                None)

    member this.HEIGHT =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "HEIGHT" then
                Some value
            else
                None)

    member this.HOTLINK =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "HOTLINK" then
                Some value
            else
                None)

    member this.HYD_ID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "HYD_ID" then
                Some value
            else
                None)

    member this.HYPERLINK =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "HYPERLINK" then
                Some value
            else
                None)

    member this.HYPERLINK_AR =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "HYPERLINK_AR" then
                Some value
            else
                None)

    member this.IMAGERYYEAR =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "IMAGERYYEAR" then
                Some value
            else
                None)

    member this.INFILTRATION =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "INFILTRATION" then
                Some value
            else
                None)

    member this.INSPDATE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "INSPDATE" then
                Some value
            else
                None)

    member this.INVENTORIED_BY =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "INVENTORIED_BY" then
                Some value
            else
                None)

    member this.INVENTORYDATE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "INVENTORYDATE" then
                Some value
            else
                None)

    member this.INVENTORYTYPE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "INVENTORYTYPE" then
                Some value
            else
                None)

    member this.INVERTELEV =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "INVERTELEV" then
                Some value
            else
                None)

    member this.INVERT_ELEV =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "INVERT_ELEV" then
                Some value
            else
                None)

    member this.INVERT_ELEV29 =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "INVERT_ELEV29" then
                Some value
            else
                None)

    member this.ISINFALL =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ISINFALL" then
                Some value
            else
                None)

    member this.LEGACYID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "LEGACYID" then
                Some value
            else
                None)

    member this.LEGACY_ID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "LEGACY_ID" then
                Some value
            else
                None)

    member this.LFEET =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "LFEET" then
                Some value
            else
                None)

    member this.LIFECYCLE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "LIFECYCLE" then
                Some value
            else
                None)

    member this.LOCATION =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "LOCATION" then
                Some value
            else
                None)

    member this.LOC_DESC =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "LOC_DESC" then
                Some value
            else
                None)

    member this.MAINTBY =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "MAINTBY" then
                Some value
            else
                None)

    member this.MATERIAL =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "MATERIAL" then
                Some value
            else
                None)

    member this.MEDIA_CODE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "MEDIA_CODE" then
                Some value
            else
                None)

    member this.MILES =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "MILES" then
                Some value
            else
                None)

    member this.NEEDSATTENTION =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "NEEDSATTENTION" then
                Some value
            else
                None)

    member this.NORTHING =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "NORTHING" then
                Some value
            else
                None)

    member this.NOTES =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "NOTES" then
                Some value
            else
                None)

    member this.NUM_BARRELS =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "NUM_BARRELS" then
                Some value
            else
                None)

    member this.OBJECTID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "OBJECTID" then
                Some value
            else
                None)

    member this.OBSTRUCTION =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "OBSTRUCTION" then
                Some value
            else
                None)

    member this.ORIGINALSOURCE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ORIGINALSOURCE" then
                Some value
            else
                None)

    member this.OUTFALLID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "OUTFALLID" then
                Some value
            else
                None)

    member this.OUTFALLTYPE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "OUTFALLTYPE" then
                Some value
            else
                None)

    member this.OWNER =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "OWNER" then
                Some value
            else
                None)

    member this.PARCELID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PARCELID" then
                Some value
            else
                None)

    member this.PARENTID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PARENTID" then
                Some value
            else
                None)

    member this.PERCT_GRD =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PERCT_GRD" then
                Some value
            else
                None)

    member this.PHOTOID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PHOTOID" then
                Some value
            else
                None)

    member this.PHOTO_FOLDER =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PHOTO_FOLDER" then
                Some value
            else
                None)

    member this.PHOTO_NUM =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PHOTO_NUM" then
                Some value
            else
                None)

    member this.PID_1 =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PID_1" then
                Some value
            else
                None)

    member this.PIPESHAPE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PIPESHAPE" then
                Some value
            else
                None)

    member this.PLACE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PLACE" then
                Some value
            else
                None)

    member this.PONDID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PONDID" then
                Some value
            else
                None)

    member this.PONDTYPE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PONDTYPE" then
                Some value
            else
                None)

    member this.PONDYR =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PONDYR" then
                Some value
            else
                None)

    member this.POND_ID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "POND_ID" then
                Some value
            else
                None)

    member this.PRFRESOLUTION =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "PRFRESOLUTION" then
                Some value
            else
                None)

    member this.RAW_NAME =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "RAW_NAME" then
                Some value
            else
                None)

    member this.RELATEDFEATURE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "RELATEDFEATURE" then
                Some value
            else
                None)

    member this.ROTATION_AZ =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ROTATION_AZ" then
                Some value
            else
                None)

    member this.SHAPE_Area =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "SHAPE_Area" then
                Some value
            else
                None)

    member this.SHAPE_Length =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "SHAPE_Length" then
                Some value
            else
                None)

    member this.SLOT_ELEV =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "SLOT_ELEV" then
                Some value
            else
                None)

    member this.SOURCE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "SOURCE" then
                Some value
            else
                None)

    member this.SOURCEYEAR =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "SOURCEYEAR" then
                Some value
            else
                None)

    member this.STORAGE_FULL_PATH_ADDR =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "STORAGE_FULL_PATH_ADDR" then
                Some value
            else
                None)

    member this.STORAGE_PATH_ADDR =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "STORAGE_PATH_ADDR" then
                Some value
            else
                None)

    member this.STORAGE_STATIC_PATH_ADDR =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "STORAGE_STATIC_PATH_ADDR" then
                Some value
            else
                None)

    member this.STRCT_DEPTH =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "STRCT_DEPTH" then
                Some value
            else
                None)

    member this.STRUCTUREID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "STRUCTUREID" then
                Some value
            else
                None)

    member this.STRUCTURETYPE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "STRUCTURETYPE" then
                Some value
            else
                None)

    member this.STRUCTURE_ID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "STRUCTURE_ID" then
                Some value
            else
                None)

    member this.SUBTYPEFIELD =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "SUBTYPEFIELD" then
                Some value
            else
                None)

    member this.SURFACETYPE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "SURFACETYPE" then
                Some value
            else
                None)

    member this.Shape_Area =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "Shape_Area" then
                Some value
            else
                None)

    member this.Shape_Length =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "Shape_Length" then
                Some value
            else
                None)

    member this.UNDERDRAINS =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "UNDERDRAINS" then
                Some value
            else
                None)

    member this.UNITDESC =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "UNITDESC" then
                Some value
            else
                None)

    member this.UNITID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "UNITID" then
                Some value
            else
                None)

    member this.UPDATESOURCE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "UPDATESOURCE" then
                Some value
            else
                None)

    member this.UPSTREAMDEPTH =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "UPSTREAMDEPTH" then
                Some value
            else
                None)

    member this.UPSTREAMELEVATION =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "UPSTREAMELEVATION" then
                Some value
            else
                None)

    member this.UPSTREAMSTUCTUREID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "UPSTREAMSTUCTUREID" then
                Some value
            else
                None)

    member this.UPSTREAM_DEPTH =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "UPSTREAM_DEPTH" then
                Some value
            else
                None)

    member this.UPSTREAM_ELEV =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "UPSTREAM_ELEV" then
                Some value
            else
                None)

    member this.VIEW_ =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "VIEW_" then
                Some value
            else
                None)

    member this.WATERBODYNAME =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "WATERBODYNAME" then
                Some value
            else
                None)

    member this.WBID =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "WBID" then
                Some value
            else
                None)

    member this.WHOCREATED =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "WHOCREATED" then
                Some value
            else
                None)

    member this.WHOMODIFIED =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "WHOMODIFIED" then
                Some value
            else
                None)

    member this.WIDTH =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "WIDTH" then
                Some value
            else
                None)

    member this.Z29 =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) -> if key = "Z29" then Some value else None)

    member this.ZVALUE =
        this.feature.attributes
        |> Array.tryPick (fun (key, value) ->
            if key = "ZVALUE" then
                Some value
            else
                None)






type ServiceFeatureTable with
    member this.fields = this.Fields |> Seq.toArray

    member this.domainFields =
        this.Fields
        |> Seq.filter (fun field -> field.Domain <> null)
        |> Seq.toArray

    member this.nondomainFields =
        this.Fields
        |> Seq.filter (fun field -> field.Domain = null)
        |> Seq.toArray

    member this.aliasedFields =
        this.Fields
        |> Seq.filter (fun field -> field.Name <> field.Alias)
        |> Seq.toArray

    member this.features = this |> Feature.Query 0

type StormwaterFeatureTable =
    | StormwaterFeatureTable of ServiceFeatureTable
    member this.table =
        match this with
        | StormwaterFeatureTable serviceFeatureTable -> serviceFeatureTable

    member this.features =
        this.table.features
        |> Array.map (fun feature -> StormwaterFeature feature)

type ArcGISMapImageLayer with
    member this.sublayers =
        this.Sublayers
        |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer)
        |> Seq.toArray

type StormwaterImageLayer =
    | StormwaterImageLayer of ArcGISMapImageSublayer
    member this.imageLayer =
        match this with
        | StormwaterImageLayer arcGISMapImageSublayer -> arcGISMapImageSublayer
