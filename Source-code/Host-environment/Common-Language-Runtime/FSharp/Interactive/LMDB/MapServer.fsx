fsi.ShowDeclarationValues <- false

open System
open System.Reflection
open System.Reflection.Emit
open Microsoft.FSharp.Reflection
open System.Diagnostics
open System.Collections.Generic
open System.Globalization
open System.Text
open System.Diagnostics
open System.IO
open System.Linq
open System.Text
open System.Text.Json
open System.Xml
open System.Xml.Linq
open System.Xml.XPath
open System.Text.RegularExpressions


#r "nuget: Fabulous.AST.Json, 2.0.0-pre06"

#r "nuget: LightningDB"
#r "nuget: MessagePack"
#r "nuget: MessagePack.FSharpExtensions"
#r "nuget: Unquote"
#r "nuget: XParsec"

#r "nuget: FSharp.Data"
#r "nuget: FSharp.Data.JsonSchema.Core"
#r "nuget: FSharp.Data.JsonSchema.NJsonSchema"
#r "nuget: FSharp.Data.JsonSchema.OpenApi"
#r "nuget: FSharp.Json"

open LightningDB
open MessagePack
open Swensen.Unquote.Assertions

#r "nuget: Blake3"

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\LMDB\LMDB.fsx"

open LMDB

#r "nuget: FSharp.Data"
open FSharp.Data
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\JavascriptObjectNotationExtensions.fsx"

open JavascriptObjectNotationExtensions

open FSharp.Data.JsonExtensions

open Fabulous.AST
open Fabulous.AST.Json

open type Fabulous.AST.Ast
open Fantomas.FCS.Text
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"

open XmlErgonomics
open type Xml




#r "nuget: dotNetRdf"

open VDS.RDF.Parsing
open VDS.RDF.Parsing.Tokens
open VDS.RDF.Storage
open VDS.RDF.Writing
open VDS.RDF.Query.Datasets


#r "nuget: ExcelProvider"
open FSharp.Interop.Excel



#r "nuget: SQLProvider.MsSql, 1.5.18"

#load @"C:\Secret\InforSecrets.fsx"

open InforSecrets

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics

open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql

#r @"C:\Repositories\appsdb\IPS_Sites\integration\Mappings.xml\System.Web.Services.dll"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\processExecution.fsx"

open ProcessExecution


#r "nuget: ClosedXML"
open ClosedXML.Excel




#r "nuget: FSharp.ViewEngine"
open FSharp.ViewEngine
open type Html



#r "nuget: Catalyst.Models.English"

open Catalyst
open Catalyst.Models
open Mosaik.Core


English.Register()
Storage.Current <- DiskStorage("catalyst-models")

module nlp =
    let pipeline = Pipeline.For(Language.English)

    let recognizer =
        AveragePerceptronEntityRecognizer.FromStoreAsync(Language.English, Version.Latest, "WikiNER")
        |> Async.AwaitTask
        |> Async.RunSynchronously

    pipeline.Add(recognizer) |> ignore

    let process_single (input: string) =
        let document = Document(input, Language.English)
        pipeline.ProcessSingle(document)

    let process_multiple (inputs: string array) =
        let documents =
            inputs
            |> Array.map (fun input -> Document(input, Language.English) :> IDocument)
            |> Array.toSeq
        pipeline.Process documents


let should_triplify = true

type InforProdSql = SqlDataProvider<ConnectionString=Prod.connection_string, IndividualsAmount=10000, UseOptionTypes=Common.NullableColumnType.OPTION>


module InforProdSql =

    let operations = InforProdSql.GetDataContext()



[<Literal>]
let mapping_directory =
    @"D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM"








let is_nullish (string_value: string) =
    (String.IsNullOrWhiteSpace(string_value))
    || string_value = "N/A"
    || string_value = "<Null>"
    || string_value = "None"
    || string_value = "null"

let is_not_nullish (string_value: string) = not (is_nullish string_value)


let xpath (expression: string) (xpath_navigator: XPathNavigator) =
    let xpath_expression = XPathExpression.Compile(expression)

    xpath_navigator
        .Select(
            xpath_expression
        )
        .toElementArray






module LCPW_OverlayStormwaterInfrastructure_D_WM =

    [<Literal>]
    let file_path =
        @"D:\Artifact\Company\Esri\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM.json"

    let json = JsonProvider<file_path>.Load file_path


    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =

        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let MapServer = _vocab "MapServer"

    let initialExtent = _vocab "initialExtent"
    let fullExtent = _vocab "fullExtent"

    module _literal =

        module value =

            let currentVersion =
                lmdb_read_write { return! RDF_Literal.autotyped json.CurrentVersion }

            let serviceDescription =
                lmdb_read_write { return! RDF_Literal.US json.ServiceDescription }

            let mapName = lmdb_read_write { return! RDF_Literal.US json.MapName }
            // let description = lmdb_read_write { return! RDF_Literal.autotyped json.Description }

            // let copyrightText = lmdb_read_write { return! RDF_Literal.autotyped json.CopyrightText }

            let supportsDynamicLayers =
                lmdb_read_write { return! RDF_Literal.autotyped json.SupportsDynamicLayers }


            let spatialReference =
                lmdb_read_write { return! RDF_Literal.simple json.SpatialReference }

            let singleFusedMapCache =
                lmdb_read_write { return! RDF_Literal.autotyped json.SingleFusedMapCache }

            let minScale = lmdb_read_write { return! RDF_Literal.autotyped json.MinScale }

            let maxScale = lmdb_read_write { return! RDF_Literal.autotyped json.MaxScale }

            let units = lmdb_read_write { return! RDF_Literal.simple json.Units }

            let supportedImageFormatTypes =
                lmdb_read_write { return! RDF_Literal.simple json.SupportedImageFormatTypes }

            module supportedImageFormatType =
                let PNG32 = lmdb_read_write { return! RDF_Literal.simple "PNG32" }
                let PNG24 = lmdb_read_write { return! RDF_Literal.simple "PNG24" }
                let PNG = lmdb_read_write { return! RDF_Literal.simple "PNG" }
                let JPG = lmdb_read_write { return! RDF_Literal.simple "JPG" }
                let DIB = lmdb_read_write { return! RDF_Literal.simple "DIB" }
                let TIFF = lmdb_read_write { return! RDF_Literal.simple "TIFF" }
                let EMF = lmdb_read_write { return! RDF_Literal.simple "EMF" }
                let PS = lmdb_read_write { return! RDF_Literal.simple "PS" }
                let PDF = lmdb_read_write { return! RDF_Literal.simple "PDF" }
                let GIF = lmdb_read_write { return! RDF_Literal.simple "GIF" }
                let SVG = lmdb_read_write { return! RDF_Literal.simple "SVG" }
                let SVGZ = lmdb_read_write { return! RDF_Literal.simple "SVGZ" }
                let BMP = lmdb_read_write { return! RDF_Literal.simple "BMP" }


            let Keywords =
                lmdb_read_write { return! RDF_Literal.autotyped json.DocumentInfo.Keywords }

            module Keyword =
                let stormwater = lmdb_read_write { return! RDF_Literal.simple "stormwater" }
                let swmf = lmdb_read_write { return! RDF_Literal.simple "swmf" }
                let drainage = lmdb_read_write { return! RDF_Literal.simple "drainage" }
                let leon_county = lmdb_read_write { return! RDF_Literal.simple "leon county" }
                let public_works = lmdb_read_write { return! RDF_Literal.simple "public works" }
                let lcpw = lmdb_read_write { return! RDF_Literal.simple "lcpw" }
                let tallahassee = lmdb_read_write { return! RDF_Literal.simple "tallahassee" }
                let florida = lmdb_read_write { return! RDF_Literal.simple "florida" }

            let capabilities =
                lmdb_read_write { return! RDF_Literal.autotyped json.Capabilities }

            module capability =

                let Map = lmdb_read_write { return! RDF_Literal.simple "Map" }
                let Query = lmdb_read_write { return! RDF_Literal.simple "Query" }
                let Data = lmdb_read_write { return! RDF_Literal.simple "Data" }

            let supportedQueryFormats =
                lmdb_read_write { return! RDF_Literal.autotyped json.SupportedQueryFormats }

            module supportedQueryFormat =
                let JSON = lmdb_read_write { return! RDF_Literal.simple "JSON" }
                let geoJSON = lmdb_read_write { return! RDF_Literal.simple "geoJSON" }


            let exportTilesAllowed =
                lmdb_read_write { return! RDF_Literal.autotyped json.ExportTilesAllowed }

            // let referenceScale = lmdb_read_write { return! RDF_Literal.autotyped json.ReferenceScale }

            let supportsDatumTransformation =
                lmdb_read_write { return! RDF_Literal.autotyped json.SupportsDatumTransformation }

            let maxRecordCount =
                lmdb_read_write { return! RDF_Literal.autotyped json.MaxRecordCount }

            let maxImageHeight =
                lmdb_read_write { return! RDF_Literal.autotyped json.MaxImageHeight }

            let maxImageWidth =
                lmdb_read_write { return! RDF_Literal.autotyped json.MaxImageWidth }

            // let supportedExtensions = lmdb_read_write { return! RDF_Literal.autotyped json.SupportedExtensions }

            let culture = lmdb_read_write { return! RDF_Literal.autotyped json.Culture }
            let name = lmdb_read_write { return! RDF_Literal.autotyped json.Name }
            let guid = lmdb_read_write { return! RDF_Literal.autotyped json.Guid }
            let catalogPath = lmdb_read_write { return! RDF_Literal.autotyped json.CatalogPath }
            // let snippet = lmdb_read_write { return! RDF_Literal.autotyped json.Snippet }
            let summary = lmdb_read_write { return! RDF_Literal.autotyped json.Summary }
            let title = lmdb_read_write { return! RDF_Literal.autotyped json.Title }
            // let tags = lmdb_read_write { return! RDF_Literal.autotyped json.Tags }
            let ``type`` = lmdb_read_write { return! RDF_Literal.autotyped json.Type }

// let typeKeywords = lmdb_read_write { return! RDF_Literal.autotyped json.TypeKeywords }
// let thumbnail = lmdb_read_write { return! RDF_Literal.autotyped json.Thumbnail }
// let url = lmdb_read_write { return! RDF_Literal.autotyped json.Url }
// let extent = lmdb_read_write { return! RDF_Literal.autotyped json.Extent }
// let accessInformation = lmdb_read_write { return! RDF_Literal.autotyped json.AccessInformation }
// let licenseInfo = lmdb_read_write { return! RDF_Literal.autotyped json.LicenseInfo }

module XRay =
    module LCG_Stormwater_Inventory =

        [<Literal>]
        let file_path =
            @"D:/Surface/Company/Environmental_Systems_Research_Institute/SDE_Schema_XRay/LCG_Stormwater_Inventory_updated/LCG_Stormwater_Inventory_Formatted.xml"

        let navigator = XPathNavigator.Load(file_path)
        let xml = XmlProvider<file_path>.Load file_path


    module DatasetDescriptions =
        [<Literal>]
        let file_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\XRay\DatasetDescriptions.xlsx"

        type Xlsx = ExcelFile<file_path>
        let xlsx = new Xlsx()

    module DomainCodedValues =
        [<Literal>]
        let file_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\XRay\DomainCodedValues.xlsx"

        type Xlsx = ExcelFile<file_path>
        let xlsx = new Xlsx()

    module DomainDescriptions =
        [<Literal>]
        let file_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\XRay\DomainDescriptions.xlsx"

        type Xlsx = ExcelFile<file_path>
        let xlsx = new Xlsx()

    module FieldDescriptions =
        [<Literal>]
        let file_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\XRay\FieldDescriptions.xlsx"

        type Xlsx = ExcelFile<file_path>
        let xlsx = new Xlsx()

    module GISDatasets =
        [<Literal>]
        let file_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\XRay\GISDatasets.xlsx"

        type Xlsx = ExcelFile<file_path>
        let xlsx = new Xlsx()

    module GISDomains =
        [<Literal>]
        let file_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\XRay\GISDomains.xlsx"

        type Xlsx = ExcelFile<file_path>
        let xlsx = new Xlsx()

    module LCPW =
        [<Literal>]
        let file_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\XRay\LCPW.Htm"

        let htm = HtmlDocument.Load file_path

    module WorkspaceDescriptions =
        [<Literal>]
        let file_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\XRay\WorkspaceDescriptions.xlsx"

        type Xlsx = ExcelFile<file_path>
        let xlsx = new Xlsx()



















module MetaData =
    [<Literal>]
    let file_path =
        @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"

    let xml = XmlProvider<file_path>.Load file_path
    let navigator = XPathNavigator.Load(file_path)

module Hansen8ClientProxies =
    [<Literal>]
    let file_path =
        @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_Web_Services_2025_04_01\ApplicationFiles\ClientProxies\Hansen8ClientProxies.dll"

    let dll = Assembly.LoadFile file_path


(*


XRay.DatasetDescriptions.xlsx.Data
|> Seq.toArray
|> Array.map (fun data_row -> data_row.``DataElement Name``)

Directory.EnumerateFiles(@"D:\Surface\Company\Environmental_Systems_Research_Institute\SDE_Schema_XRay\XRay")
|> String.concat "\n"
|> clip

let namespace_manager =
    new XmlNamespaceManager(XRay.LCG_Stormwater_Inventory.navigator.NameTable)

let xsi_namespace =
    XRay.LCG_Stormwater_Inventory.navigator
    |> XPathNavigator.xmlns namespace_manager "xsi" "http://www.w3.org/2001/XMLSchema-instance"
*)





let layer_name_by_FeatureClass'Name =
    Map.ofArray [|


                   "Bridge", "Bridge"
                   "BridgePoint", "Bridge Point"
                   "Conduit", "Conduit"
                   "Connectivity", "Connectivity"
                   "CulvertCrossDrain", "Culvert Cross Drain"
                   "Damage", "Damage"
                   "DebrisTrap", "Debris Trap"
                   "Ditch", "Ditch"
                   "DitchPoint", "Ditch Point"
                   "EndPoint", "End Point"
                   "GenericStormAsset", "Generic Storm Asset"
                   "Inlet", "Inlet"
                   "Interference", "Interference"
                   "Junction_fixed", "Junction Fixed"
                   "MediaPoints", "Media Points"
                   "MediaPointsWithoutPhotos", "Media Points Without Photos"
                   "Outfall", "Outfall"
                   "Outfall_DrainageArea", "Outfall Drainage Area"
                   "Outfall_DrainageArea_MOF", "Outfall Drainage Area MOF"
                   "Outfall_DrainageArea_MS4", "Outfall Drainage Area MS4"
                   "PollutionControlBox", "Pollution Control Box"
                   "PrivatePoint", "Private Point"
                   "StormwaterPond", "Stormwater Pond"
                   "StormwaterPond_MediaPoints", "Stormwater Pond Media Points"
                   "StormwaterPondDischarge", "Stormwater Pond Discharge"
                   "StormwaterPondTopOfBank", "Stormwater Pond - Top of Bank"

                    |]

let layer_names_with_unit_ids =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.choose (fun Layer ->
        let fields =
            Layer.Fields
            |> Array.Parallel.map (fun Field -> Field.Name)
            |> Set.ofArray
        if fields.Contains("UNITID") then
            Some(Layer.Name)
        else
            None)
    |> Set.ofArray

let layer_names_without_unit_ids =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.choose (fun Layer ->
        let fields =
            Layer.Fields
            |> Array.Parallel.map (fun Field -> Field.Name)
            |> Set.ofArray
        if fields.Contains("UNITID") then
            None
        else
            Some(Layer.Name))
    |> Set.ofArray

let layer_names_with_global_ids =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.choose (fun Layer ->
        let fields =
            Layer.Fields
            |> Array.Parallel.map (fun Field -> Field.Name)
            |> Set.ofArray
        if fields.Contains("GLOBALID") then
            Some(Layer.Name)
        else
            None)
    |> Set.ofArray

let layer_names_with_globalids_without_unit_ids =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.choose (fun Layer ->
        let fields =
            Layer.Fields
            |> Array.Parallel.map (fun Field -> Field.Name)
            |> Set.ofArray
        if
            fields.Contains("GLOBALID")
            && not (fields.Contains("UNITID"))
        then
            Some(Layer.Name)
        else
            None)
    |> Set.ofArray

let layer_names_with_global_id_and_unit_ids =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.choose (fun Layer ->
        let fields =
            Layer.Fields
            |> Array.Parallel.map (fun Field -> Field.Name)
            |> Set.ofArray
        if
            fields.Contains("GLOBALID")
            && fields.Contains("UNITID")
        then
            Some(Layer.Name)
        else
            None)
    |> Set.ofArray

let relevent_ids =
    set [


          "ATTACHEDTOID"
          "FACILITYID"
          "GLOBALID"
          "HYD_ID"
          "OUTFALLID"
          "PARENTID"
          "STRUCTUREID"
          "UPSTREAMSTUCTUREID"

           ]

let relevent_domain_attributes =
    set [


          "DIAMETER"
          "FILTERLOCATION"
          "MAINTBY"
          "MATERIAL"
          "OWNER"
          "PIPESHAPE"
          "PONDTYPE"

           ]

let relevent_attributes =
    set [



          "DESCRIPTION"
          "DOWNSTREAM_DEPTH"
          "DOWNSTREAM_ELEV"
          "DOWNSTREAMDEPTH"
          "DOWNSTREAMELEVATION"
          "DRAINAGEBASIN"
          "FILTERTYPE"
          "HEIGHT"
          "INVERT_ELEV"
          "INVERTELEV"
          "LFEET"
          "LOC_DESC"
          "LOCATION"
          "NOTES"
          "OUTFALLTYPE"
          "PONDYR"
          "RELATEDFEATURE"
          "SLOT_ELEV"
          "STRCT_DEPTH"
          "STRUCTURETYPE"
          "SUBTYPEFIELD"
          "SURFACETYPE"
          "UPSTREAM_DEPTH"
          "UPSTREAM_ELEV"
          "UPSTREAMDEPTH"
          "UPSTREAMELEVATION"
          "WATERBODYNAME"
          "WIDTH"
          "ZVALUE"


           ]

let table_databaseName_from_name =

    MetaData.navigator
    |> xpath "//table"
    |> Array.Parallel.map (fun table -> table.Attribute "name", table.Attribute "databaseName")
    |> Map.ofArray

(*
    [|

       "StormBackflowPreventer", "COMPSTBF"
       "StormChannel", "COMPSTCH"
       "StormChannelDrainageConnection", "COMPDRCN"
       "StormInlet", "COMPSTIN"
       "StormLevee", "COMPSTLV"
       "StormLiftStation", "COMPSTLS"
       "StormMain", "COMPSTMN"
       "StormManhole", "COMPSTMH"
       "StormMeter", "COMPSTMT"
       "StormMeterComponent", "COMPSTMC"
       "StormMeterRegister", "COMPSTMR"
       "StormMiscellaneous", "COMPSTMS"
       "StormNode", "COMPSTND"
       "StormPump", "COMPSTP"
       "StormServiceLine", "COMPSTSL"
       "StormStorageBasin", "COMPSTSB"
       "StormValve", "COMPSTV"
       "Complex", "COMPCPLX"


       |]

    *)

let table_key_from_name (table_name: string) =

    let result =
        query {
            for Dbtable in InforProdSql.operations.MetaData.Dbtable do
                where (Dbtable.Commonid.Value = table_name)
                select Dbtable.Tablekey
        }
        |> Seq.toArray
    if result.Length < 1 then
        None
    else
        Some(result[0])

module Normalize =
    let field (field_name: string) =
        match field_name with
        | "INVERT_ELEV" -> "INVERTELEV"
        | "DOWNSTREAM_DEPTH" -> "DOWNSTREAMDEPTH"
        | "DOWNSTREAM_ELEV" -> "DOWNSTREAMELEVATION"
        | "FIELD_COMMENTS_" -> "FIELD_COMMENTS"
        | "LOC_DESC" -> "LOCATION"
        | "UPSTREAM_ELEV" -> "UPSTREAMELEVATION"
        | "UPSTREAM_DEPTH" -> "UPSTREAMDEPTH"

        | _ -> field_name

    let maint_by (code: string) =

        match code with

        | "Public Works Operations" -> "PWOPR"
        | "Private" -> "PVT"
        | "Unknown" -> "UNKN"
        | "Florida DOT" -> "DOT"
        | "FDOT" -> "DOT" // TODO report to GIS malformed coded value
        | "Leon County" -> "CNTY"
        | "State of Florida" -> "STATE"
        | "Abandonded" -> "ABND"
        | _ -> code

    // TODO report to GIS that dDomainEndPointMaterial strings for name and code are swapped
    let material (code: string) =

        match code with
        | "CONCRETE" -> "CON"
        | "BRICK" -> "BRK"
        | "RUBBLE ROCK" -> "RR"
        | "CEMENT BAGS" // TODO report misnamed coded value to GIS
        | "SAND CEMENT BAG" -> "SCB"
        | "DIRT" -> "DRT"
        | "OTHER" -> "OTH"
        | "NOT ASSESSED" -> "NA"
        | "UNKNOWN" -> "UNK"
        | _ -> code

    let owner (code: string) =
        match code with

        | "FDOT" -> "DOT" // TODO report to GIS malformed coded value
        | "Private" -> "PVT" // TODO report to GIS malformed coded value
        | _ -> code

    let pipe_shape (code: string) =

        match code with
        // TODO report to GIS malformed domain value
        | "ROUND" -> "RND"
        | _ -> code

    let surface_type (code: string) =
        match code with
        // TODO report to GIS malformed domain value
        | "Dirt" -> "DIRT"
        | "Grass" -> "GRASS"
        | _ -> code



// "PWOPER.EndPoint_Has_PollutionControlBox"
// "PWOPER.EndPoint_has_StormwaterPondToEndPoints"
// "PWOPER.EndPoint_Has_Outfall"
// "PWOPER.EndPoint_Has_DebrisTrap"
// "PWOPER.Inlet_Has_Outfall"
// "PWOPER.Inlet_Has_Interference"
// "PWOPER.Inlet_Has_PollutionControlBox"
// "PWOPER.Inlet_Has_DebrisTrap"
// "PWOPER.Conduit_Has_Outfall"
// "PWOPER.Ditch_Has_DebrisTrap"
// "PWOPER.Ditch_Has_Interference"
// "PWOPER.Ditch_Has_Outfall"
// "PWOPER.Junction_Has_PollutionControlBox"
// "PWOPER.Junction_Has_Interference"
// "PWOPER.Junction_Has_Outfall"
// "PWOPER.CulvertCrossDrain_Has_Outfall"
// "Inlet_Has_DebrisTrap"
// "Ditch_Has_DebrisTrap"
// "EndPoint_Has_DebrisTrap"
// "Junction_Has_Interference"
// "Inlet_Has_Interference"
// "Ditch_Has_Interference"
// "PWOPER.Outfall_Has_OutfallDrainageArea"
// "PWOPER.Connectivity_Has_Outfall"
// "PWOPER.StormwaterPondDischarge_Has_Outfall"
// "PWOPER.GenericStormAsset_Has_Outfall"
// "PWOPER.PrivatePoint_Has_Outfall"
// "PWOPER.DitchPoint_Has_Outfall"

// TODO look for ANY data about the specific relationships above

// | "Culvert Cross Drain" -> "StormServiceLine"
// | "Debris Trap" -> "StormValve"
// | "End Point" -> "StormNode"
// | "Inlet" -> "StormInlet"
// | "Junction Fixed" -> "StormManhole"
// | "Outfall" -> "StormStorageBasin"
// | "Stormwater Pond Discharge" -> "StormLevee"
// | "Stormwater Pond" -> "StormMiscellaneous"
// TODO identify endpoints to resolve these failing mapping
// | "Conduit" -> "StormMain"
// | "Ditch" -> "StormChannel"
(*
Infor Storm Asset Tables by Table Type


SimpleAsset
  StormBackflowPreventer
  StormInlet
  StormLevee
  StormManhole
  StormNode
  StormServiceLine
  StormStorageBasin



MainlineAsset
  StormChannel
  StormMain



Table
  StormChannelDrainageConnection



CompoundAsset
  StormLiftStation
  StormMiscellaneous



EquipmentAsset
  StormMeter
  StormMeterComponent
  StormMeterRegister
  StormPump
  StormValve

*)



(*
let unitid_prefix_by_Layer'Name =
    Map.ofArray [|

                   "Conduit", "PI"
                   "Culvert Cross Drain", "CD"
                   "Debris Trap", "DT"
                   "Ditch", "DI"
                   "End Point", "EP"
                   "Inlet", "IN"
                   "Junction Fixed", "JN"
                   "Outfall", "OF"
                   "Stormwater Pond", "SP"
                   "Stormwater Pond Discharge", "SD"

                    |]



let feature_layer_names =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.map (fun layer -> layer.Name)
    |> Array.distinct



LCPW_OverlayStormwaterInfrastructure_D_WM.json.JsonValue.PropertyKeys

let Map_Server_Keys =
    [|

       "currentVersion"
       "serviceDescription"
       "mapName"
       "description"
       "copyrightText"
       "supportsDynamicLayers"
       "layers"
       "tables"
       "spatialReference"
       "singleFusedMapCache"
       "initialExtent"
       "fullExtent"
       "minScale"
       "maxScale"
       "units"
       "supportedImageFormatTypes"
       "documentInfo"
       "capabilities"
       "supportedQueryFormats"
       "exportTilesAllowed"
       "referenceScale"
       "supportsDatumTransformation"
       "maxRecordCount"
       "maxImageHeight"
       "maxImageWidth"
       "supportedExtensions"
       "culture"
       "name"
       "guid"
       "catalogPath"
       "snippet"
       "summary"
       "title"
       "tags"
       "type"
       "typeKeywords"
       "thumbnail"
       "url"
       "extent"
       "accessInformation"
       "licenseInfo"

       |]
// definitions.ILayerDefinition
gpservices.schema.json.Definitions.ILayerDefinition.Properties.JsonValue?capabilities?description







LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun Layer -> Layer.JsonValue.ScalarKeyValues)
|> Array.Parallel.choose (fun (key, value) ->
    match value with

    | JsonValue.String string_value when String.IsNullOrWhiteSpace(string_value) -> None
    | JsonValue.Number number_value when number_value = 0M -> None
    | JsonValue.Float float_value when float_value <> 0 -> None
    | _ -> Some(key))
|> Array.distinct

LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers[0]

*)
let Layer_Keys =
    [|

       "name"
       "parentLayerId"
       "defaultVisibility"
       "type"
       "currentVersion"
       "hasAttachments"
       "htmlPopupType"
       "canModifyLayer"
       "canScaleSymbols"
       "hasLabels"
       "capabilities"
       "supportsStatistics"
       "supportsAdvancedQueries"
       "supportedQueryFormats"
       "isDataVersioned"
       "useStandardizedQueries"
       "supportsCoordinatesQuantization"
       "id"
       "minScale"
       "geometryType"
       "displayField"
       "maxRecordCount"
       "supportsDatumTransformation"
       "count"
       "displayFieldName"
       "exceededTransferLimit"
       "hasZ"

       |]




























module www2k =


    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"http://www.w3.org/2000/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let xmlns = _vocab "xmlns"

/// https://schema.org/docs/about.html
module schemorg =


    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"https://schema.org/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let Book = _vocab "Book"
    let isbn = _vocab "isbn"
    let eisbn = _vocab "eisbn"
    let accessMode = _vocab "accessMode"
    let accessModeSufficient = _vocab "accessModeSufficient"
    let accessibilityHazard = _vocab "accessibilityHazard"
    let accessibilityFeature = _vocab "accessibilityFeature"
    let accessibilitySummary = _vocab "accessibilitySummary"
    let SoftwareApplication = _vocab "SoftwareApplication"


/// https://www.w3.org/TR/epub-ssv-11/#dictionaries
module epub_ssv =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"https://www.w3.org/TR/epub-ssv-11/#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    /// A group of terms, each having an opposite or nearly opposite meaning from a headword or idiom.
    let antonym_group = _vocab "antonym-group"
    /// A condensed dictionary entry designed for constrained lookup viewports.
    let condensed_entry = _vocab "condensed-entry"
    /// The definition of a particular meaning of a headword or idiom.
    let def = _vocab "def"
    /// A dictionary entry.
    let dictentry = _vocab "dictentry"
    /// A collection of dictionary entries.
    let dictionary = _vocab "dictionary"
    /// An explanation of the historical origin of a headword.
    let etymology = _vocab "etymology"
    /// An illustration of the usage of a defined term or phrase.
    let example = _vocab "example"
    /// Supplemental grammatical information related to the headword and modifying a part of speech or a particular meaning.
    let gram_info = _vocab "gram-info"
    /// A defining instance of a phrase.
    let idiom = _vocab "idiom"
    /// The grammatical function of a headword.
    let part_of_speech = _vocab "part-of-speech"
    /// A list of part of speech groups in a dictionary entry.
    let part_of_speech_list = _vocab "part-of-speech-list"
    /// A unit that associates a part of speech with its related sense and phrase groups.
    let part_of_speech_group = _vocab "part-of-speech-group"
    /// A phonetic transcription of the pronunciation of a headword or other component of a dictionary entry.
    let phonetic_transcription = _vocab "phonetic-transcription"
    /// A list of phrase groups in a dictionary entry.
    let phrase_list = _vocab "phrase-list"
    /// A unit for organizing information pertaining to an idiom or example.
    let phrase_group = _vocab "phrase-group"
    /// A list of sense groups in a dictionary entry.
    let sense_list = _vocab "sense-list"
    /// A unit for organizing information pertaining to a particular meaning of a headword or idiom.
    let sense_group = _vocab "sense-group"
    /// A group of terms, each having identical or similar meaning to a headword or idiom.
    let synonym_group = _vocab "synonym-group"
    /// The translation of a particular meaning of a source language headword, idiom, or example into a target language.
    let tran = _vocab "tran"
    /// Grammatical or usage information related to a translation.
    let tran_info = _vocab "tran-info"

module esri_press =


    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"https://www.esri.com/en-us/esri-press/browse/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let a_to_z_gis =
        _vocab "a-to-z-gis-an-illustrated-dictionary-of-geographic-information-systems-third-edition"

module opf =

    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"http://www.idpf.org/2007/opf#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

module entry =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/lexicon/entry/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _minuscule (local_name_string: string) (transaction: LightningTransaction) =
        _prefix (local_name_string.ToLowerInvariant()) transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string (local_name_string.low_lined)

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

module concept =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/lexicon/concept/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _minuscule (local_name_string: string) (transaction: LightningTransaction) =
        _prefix (local_name_string.ToLowerInvariant()) transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    module gis =

        let _vocab (local_name_string: string) =
            lmdb_read_write {
                let! local_name = Lexical_Form.from_string $"gis.{local_name_string.low_lined}"

                return!
                    RDF_Term.from_namespaced_iri
                        { namespace_name_id = _namespace_name.lexical_form_id
                          local_name_id = local_name.lexical_form_id }
            }

        let feature_layer = _vocab "feature_layer"
        let feature_class = _vocab "feature_class"
        let field = _vocab "field"
        let column = _vocab "column"
        let feature = _vocab "feature"
        let identifier = _vocab "identifier"

    module infor =

        let _vocab (local_name_string: string) =
            lmdb_read_write {
                let! local_name = Lexical_Form.from_string $"infor.{local_name_string.low_lined}"

                return!
                    RDF_Term.from_namespaced_iri
                        { namespace_name_id = _namespace_name.lexical_form_id
                          local_name_id = local_name.lexical_form_id }
            }

        let database = _vocab "database"
        let table_definition = _vocab "table_definition"
        let column = _vocab "column"
        let asset = _vocab "asset"
        let table = _vocab "table"
        let identification_code = _vocab "identification_code"

module constituent =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/lexicon/constituent/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _minuscule (local_name_string: string) (transaction: LightningTransaction) =
        _prefix (local_name_string.ToLowerInvariant()) transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

module A_to_Z_GIS =
    /// https://www.iana.org/assignments/urn-formal/isbn
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"urn:isbn:9781589488113:" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let _graph = _vocab ""


/// https://www.rfc-editor.org/info/rfc2397/
module data =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"data:text/plain;charset=UTF-8;" }

    let url (mediatype: string) (charset: string) (data_string: string) (transaction: LightningTransaction) =
        let lexical_form =
            Lexical_Form.from_string $"data:{mediatype};charset={charset};{Uri.EscapeDataString(data_string)}" transaction
        RDF_Term.from_atomic_iri { lexical_form_id = lexical_form.lexical_form_id } transaction

    module text =
        let plain (text: string) = url "text/plain" "UTF-8" text


module usage =

    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/lexicon/usage/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _minuscule (local_name_string: string) (transaction: LightningTransaction) =
        _prefix (local_name_string.ToLowerInvariant()) transaction

module sense =

    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/lexicon/sense/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _minuscule (local_name_string: string) (transaction: LightningTransaction) =
        _prefix (local_name_string.ToLowerInvariant()) transaction

    let _gis (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            let low_lined = local_name_string.Replace("\\", "-").low_lined
            Lexical_Form.from_string $"gis.{low_lined}" transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction


    let _woedms (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            let low_lined = local_name_string.Replace("\\", "-").low_lined
            Lexical_Form.from_string $"woedms.{low_lined}" transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction


    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    module gis =
        let _vocab (local_name_string: string) =
            lmdb_read_write {
                let! local_name = Lexical_Form.from_string $"gis.{local_name_string.low_lined}"

                return!
                    RDF_Term.from_namespaced_iri
                        { namespace_name_id = _namespace_name.lexical_form_id
                          local_name_id = local_name.lexical_form_id }
            }

        let feature = _vocab "feature"

    module woedms =

        let _vocab (local_name_string: string) =
            lmdb_read_write {
                let! local_name = Lexical_Form.from_string $"woedms.{local_name_string.low_lined}"

                return!
                    RDF_Term.from_namespaced_iri
                        { namespace_name_id = _namespace_name.lexical_form_id
                          local_name_id = local_name.lexical_form_id }
            }

        let asset = _vocab "asset"






/// http://www.esri.com/metadata/esriprof80.html
module esri =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"http://www.esri.com/schemas/ArcGIS/3.3.0/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let coded_value_domain = _vocab "coded_value_domain"
    let feature_dataset = _vocab "feature_dataset"
    let DataElement = _vocab "DataElement"
    let DEDataset = _vocab "DEDataset"
    let DETable = _vocab "DETable"
    let DEGeoDataset = _vocab "DEGeoDataset"
    let DEFeatureClass = _vocab "DEFeatureClass"
    let Name = _vocab "Name"
    let Code = _vocab "Code"


    let ArcGISMapServiceLayer = _vocab "ArcGISMapServiceLayer"
    let Workspace = _vocab "Workspace"
    let MapService = _vocab "MapService"
    let WorkspaceDefinition = _vocab "WorkspaceDefinition"
    let WorkspaceType = _vocab "WorkspaceType"
    let esriLocalDatabaseWorkspace = _vocab "esriLocalDatabaseWorkspace"

    /// Creation Date
    let CreaDate = _vocab "CreaDate"
    /// Creation Time
    let CreaTime = _vocab "CreaTime"
    /// Synchronize Once
    let SyncOnce = _vocab "SyncOnce"
    /// Synchronization Date
    let SyncDate = _vocab "SyncDate"
    /// Synchronization Time
    let SyncTime = _vocab "SyncTime"
    /// Modification Date
    let ModDate = _vocab "ModDate"
    /// Modification Time
    let ModTime = _vocab "ModTime"
    /// Data Properties
    let DataProperties = _vocab "DataProperties"
    /// Subtype Code
    let stcode = _vocab "stcode"
    /// Subtype Name
    let stname = _vocab "stname"
    /// Identification Information
    let idinfo = _vocab "idinfo"
    /// Citation
    let citation = _vocab "citation"
    /// Citation Information
    let citeinfo = _vocab "citeinfo"
    /// Description
    let descript = _vocab "descript"
    /// Abstract
    let ``abstract`` = _vocab "abstract"
    /// Purpose
    let purpose = _vocab "purpose"
    /// Language of Dataset
    let langdata = _vocab "langdata"
    /// Time Period of Content
    let timeperd = _vocab "timeperd"
    /// Time Period Information
    let timeinfo = _vocab "timeinfo"
    /// Currentness Reference
    let current = _vocab "current"
    /// Status
    let status = _vocab "status"
    /// Progress
    let progress = _vocab "progress"
    /// Maintenance and Update Frequency
    let update = _vocab "update"
    /// Spatial Domain
    let spdom = _vocab "spdom"
    /// Bounding Coordinates
    let bounding = _vocab "bounding"
    /// West Bounding Coordinate
    let westbc = _vocab "westbc"
    /// East Bounding Coordinate
    let eastbc = _vocab "eastbc"
    /// North Bounding Coordinate
    let northbc = _vocab "northbc"
    /// South Bounding Coordinate
    let southbc = _vocab "southbc"
    /// Local Bounding Coordinates
    let lboundng = _vocab "lboundng"
    /// Top Bounding Coordinate
    let topbc = _vocab "topbc"
    /// Bottom Bounding Coordinate
    let bottombc = _vocab "bottombc"
    /// Left Bounding Coordinate
    let leftbc = _vocab "leftbc"
    /// Right Bounding Coordinate
    let rightbc = _vocab "rightbc"
    /// Keywords
    let keywords = _vocab "keywords"
    /// Theme
    let theme = _vocab "theme"
    /// Theme Keyword Thesaurus
    let themekt = _vocab "themekt"
    /// Theme Keyword
    let themekey = _vocab "themekey"
    /// Place
    let place = _vocab "place"
    /// Place Keyword
    let placekey = _vocab "placekey"
    /// Access Constraints
    let accconst = _vocab "accconst"
    /// Use Constraints
    let useconst = _vocab "useconst"
    /// Point of Contact
    let ptcontac = _vocab "ptcontac"
    /// Contact Information
    let cntinfo = _vocab "cntinfo"
    /// Native Dataset Environment
    let native = _vocab "native"
    /// Native Dataset Format
    let natvform = _vocab "natvform"
    /// Data Quality Information
    let dataqual = _vocab "dataqual"
    /// Attribute Accuracy
    let attracc = _vocab "attracc"
    /// Lineage
    let lineage = _vocab "lineage"
    /// Process Step
    let procstep = _vocab "procstep"
    /// Process Description
    let procdesc = _vocab "procdesc"
    /// Source Used Citation Abbreviation
    let srcused = _vocab "srcused"
    /// Process Date
    let procdate = _vocab "procdate"
    /// Process Time
    let proctime = _vocab "proctime"
    /// Spatial Data Organization Information
    let spdoinfo = _vocab "spdoinfo"
    /// Direct Spatial Reference Method
    let direct = _vocab "direct"
    /// Point and Vector Object Information
    let ptvctinf = _vocab "ptvctinf"
    /// ESRI Terms Description
    let esriterm = _vocab "esriterm"
    /// ESRI Feature Type
    let efeatyp = _vocab "efeatyp"
    /// ESRI Feature Geometry
    let efeageom = _vocab "efeageom"
    /// ESRI Topology
    let esritopo = _vocab "esritopo"
    /// ESRI Feature Count
    let efeacnt = _vocab "efeacnt"
    /// Spatial Index
    let spindex = _vocab "spindex"
    /// Linear Referencing
    let linrefer = _vocab "linrefer"
    /// Spatial Reference Information
    let spref = _vocab "spref"
    /// Horizontal Coordinate System Definition
    let horizsys = _vocab "horizsys"
    /// Coordinate System Name
    let cordsysn = _vocab "cordsysn"
    /// Projected Coordinate System Name
    let projcsn = _vocab "projcsn"
    /// Geographic Coordinate System Name
    let geogcsn = _vocab "geogcsn"
    /// Planar
    let planar = _vocab "planar"
    /// Planar Coordinate Information
    let planci = _vocab "planci"
    /// Planar Coordinate Encoding Method
    let plance = _vocab "plance"
    /// Coordinate Representation
    let coordrep = _vocab "coordrep"
    /// Abscissa Resolution
    let absres = _vocab "absres"
    /// Planar Distance Units
    let plandu = _vocab "plandu"
    /// Geodetic Model
    let geodetic = _vocab "geodetic"
    /// Horizontal Datum Name
    let horizdn = _vocab "horizdn"
    /// Ellipsoid Name
    let ellips = _vocab "ellips"
    /// Semi-Major Axis
    let semiaxis = _vocab "semiaxis"
    /// Denominator of Flattening Ratio
    let denflat = _vocab "denflat"
    /// Vertical Coordinate System Definition
    let vertdef = _vocab "vertdef"
    /// Altitude System Definition
    let altsys = _vocab "altsys"
    /// Altitude Encoding Method
    let altenc = _vocab "altenc"
    /// Entity and Attribute Information
    let eainfo = _vocab "eainfo"
    /// Entity Type
    let enttyp = _vocab "enttyp"
    /// Entity Type Label
    let enttypl = _vocab "enttypl"
    /// Entity Type Type
    let enttypt = _vocab "enttypt"
    /// Entity Type Count
    let enttypc = _vocab "enttypc"
    /// Attribute
    let attr = _vocab "attr"
    /// Attribute Label
    let attrlabl = _vocab "attrlabl"
    /// Attribute Alias
    let attalias = _vocab "attalias"
    /// Attribute Definition
    let attrdef = _vocab "attrdef"
    /// Attribute Definition Source
    let attrdefs = _vocab "attrdefs"
    /// Attribute Type
    let attrtype = _vocab "attrtype"
    /// Attribute Width
    let attwidth = _vocab "attwidth"
    /// Attribute Precision
    let atprecis = _vocab "atprecis"
    /// Attribute Scale
    let attscale = _vocab "attscale"
    /// Attribute Domain Values
    let attrdomv = _vocab "attrdomv"
    /// Unrepresentable Domain
    let udom = _vocab "udom"
    /// Subtype Information
    let subtype = _vocab "subtype"
    /// Subtype Attribute
    let stfield = _vocab "stfield"
    /// Subtype Attribute Name
    let stfldnm = _vocab "stfldnm"
    /// Subtype Default Value
    let stflddv = _vocab "stflddv"
    /// Attribute Defined Domain
    let stflddd = _vocab "stflddd"
    /// Domain Name
    let domname = _vocab "domname"
    /// Domain Description
    let domdesc = _vocab "domdesc"
    /// Domain Owner
    let domowner = _vocab "domowner"
    /// Domain Attribute Type
    let domfldtp = _vocab "domfldtp"
    /// Domain Type
    let domtype = _vocab "domtype"
    /// Split Rule
    let splttype = _vocab "splttype"
    /// Distribution Information
    let distinfo = _vocab "distinfo"
    /// Resource Description
    let resdesc = _vocab "resdesc"
    /// Metadata Reference Information
    let metainfo = _vocab "metainfo"
    /// Metadata Date
    let metd = _vocab "metd"
    /// Language of Metadata
    let langmeta = _vocab "langmeta"
    /// Metadata Contact
    let metc = _vocab "metc"
    /// Metadata Standard Name
    let metstdn = _vocab "metstdn"
    /// Metadata Standard Version
    let metstdv = _vocab "metstdv"
    /// Metadata Time Convention
    let mettc = _vocab "mettc"
    /// Metadata Extensions
    let metextns = _vocab "metextns"
    /// Online Linkage
    let onlink = _vocab "onlink"
    /// Profile Name
    let metprof = _vocab "metprof"
    /// Originator
    let origin = _vocab "origin"
    /// Publication Date
    let pubdate = _vocab "pubdate"
    /// Title
    let title = _vocab "title"
    /// File or Table Name
    let ftname = _vocab "ftname"
    /// Geospatial Data Presentation Form
    let geoform = _vocab "geoform"
    /// Publication Information
    let pubinfo = _vocab "pubinfo"
    /// Publication Place
    let pubplace = _vocab "pubplace"
    /// Publisher
    let publish = _vocab "publish"
    /// Single Date/Time
    let sngdate = _vocab "sngdate"
    /// Calendar Date
    let caldate = _vocab "caldate"
    /// Contact Person
    let cntper = _vocab "cntper"
    /// Contact Organization
    let cntorg = _vocab "cntorg"
    /// Contact Organization Primary
    let cntorgp = _vocab "cntorgp"
    /// Contact Address
    let cntaddr = _vocab "cntaddr"
    /// Address Type
    let addrtype = _vocab "addrtype"
    /// Address
    let address = _vocab "address"
    /// City
    let city = _vocab "city"
    /// State or Province
    let state = _vocab "state"
    /// Postal Code
    let postal = _vocab "postal"
    /// Contact Voice Telephone
    let cntvoice = _vocab "cntvoice"
    /// Hours of Service
    let hours = _vocab "hours"
    let CodedValueDomain = _vocab "CodedValueDomain"
    let CodedValue = _vocab "CodedValue"
    let FieldType = _vocab "FieldType"
    let DEFeatureDataset = _vocab "DEFeatureDataset"
    let DatasetType = _vocab "DatasetType"
    let esriDTFeatureDataset = _vocab "esriDTFeatureDataset"
    ///   <Description>A reference to a feature class, including symbology and rendering properties.</Description>
    let GPFeatureLayer = _vocab "GPFeatureLayer"
    let DisplayName = _vocab "DisplayName"
    let Description = _vocab "Description"
    let Field = _vocab "Field"



    let coded_value = _vocab "coded_value"
    let code = _vocab "code"
    let value = _vocab "value"
    let field_type = _vocab "field_type"

    module _literal =
        module label =
            let CreaDate = RDF_Literal.simple "Creation Date"
            let CreaTime = RDF_Literal.simple "Creation Time"
            let SyncOnce = RDF_Literal.simple "Synchronize Once"
            let SyncDate = RDF_Literal.simple "Synchronization Date"
            let SyncTime = RDF_Literal.simple "Synchronization Time"
            let ModDate = RDF_Literal.simple "Modification Date"
            let ModTime = RDF_Literal.simple "Modification Time"
            let DataProperties = RDF_Literal.simple "Data Properties"
            let stcode = RDF_Literal.simple "Subtype Code"
            let stname = RDF_Literal.simple "Subtype Name"
            let idinfo = RDF_Literal.simple "Identification Information"
            let citation = RDF_Literal.simple "Citation"
            let citeinfo = RDF_Literal.simple "Citation Information"
            let descript = RDF_Literal.simple "Description"
            let ``abstract`` = RDF_Literal.simple "Abstract"
            let purpose = RDF_Literal.simple "Purpose"
            let langdata = RDF_Literal.simple "Language of Dataset"
            let timeperd = RDF_Literal.simple "Time Period of Content"
            let timeinfo = RDF_Literal.simple "Time Period Information"
            let current = RDF_Literal.simple "Currentness Reference"
            let status = RDF_Literal.simple "Status"
            let progress = RDF_Literal.simple "Progress"
            let update = RDF_Literal.simple "Maintenance and Update Frequency"
            let spdom = RDF_Literal.simple "Spatial Domain"
            let bounding = RDF_Literal.simple "Bounding Coordinates"
            let westbc = RDF_Literal.simple "West Bounding Coordinate"
            let eastbc = RDF_Literal.simple "East Bounding Coordinate"
            let northbc = RDF_Literal.simple "North Bounding Coordinate"
            let southbc = RDF_Literal.simple "South Bounding Coordinate"
            let lboundng = RDF_Literal.simple "Local Bounding Coordinates"
            let topbc = RDF_Literal.simple "Top Bounding Coordinate"
            let bottombc = RDF_Literal.simple "Bottom Bounding Coordinate"
            let leftbc = RDF_Literal.simple "Left Bounding Coordinate"
            let rightbc = RDF_Literal.simple "Right Bounding Coordinate"
            let keywords = RDF_Literal.simple "Keywords"
            let theme = RDF_Literal.simple "Theme"
            let themekt = RDF_Literal.simple "Theme Keyword Thesaurus"
            let themekey = RDF_Literal.simple "Theme Keyword"
            let place = RDF_Literal.simple "Place"
            let placekey = RDF_Literal.simple "Place Keyword"
            let accconst = RDF_Literal.simple "Access Constraints"
            let useconst = RDF_Literal.simple "Use Constraints"
            let ptcontac = RDF_Literal.simple "Point of Contact"
            let cntinfo = RDF_Literal.simple "Contact Information"
            let native = RDF_Literal.simple "Native Dataset Environment"
            let natvform = RDF_Literal.simple "Native Dataset Format"
            let dataqual = RDF_Literal.simple "Data Quality Information"
            let attracc = RDF_Literal.simple "Attribute Accuracy"
            let lineage = RDF_Literal.simple "Lineage"
            let procstep = RDF_Literal.simple "Process Step"
            let procdesc = RDF_Literal.simple "Process Description"
            let srcused = RDF_Literal.simple "Source Used Citation Abbreviation"
            let procdate = RDF_Literal.simple "Process Date"
            let proctime = RDF_Literal.simple "Process Time"
            let spdoinfo = RDF_Literal.simple "Spatial Data Organization Information"
            let direct = RDF_Literal.simple "Direct Spatial Reference Method"
            let ptvctinf = RDF_Literal.simple "Point and Vector Object Information"
            let esriterm = RDF_Literal.simple "ESRI Terms Description"
            let efeatyp = RDF_Literal.simple "ESRI Feature Type"
            let efeageom = RDF_Literal.simple "ESRI Feature Geometry"
            let esritopo = RDF_Literal.simple "ESRI Topology"
            let efeacnt = RDF_Literal.simple "ESRI Feature Count"
            let spindex = RDF_Literal.simple "Spatial Index"
            let linrefer = RDF_Literal.simple "Linear Referencing"
            let spref = RDF_Literal.simple "Spatial Reference Information"
            let horizsys = RDF_Literal.simple "Horizontal Coordinate System Definition"
            let cordsysn = RDF_Literal.simple "Coordinate System Name"
            let projcsn = RDF_Literal.simple "Projected Coordinate System Name"
            let geogcsn = RDF_Literal.simple "Geographic Coordinate System Name"
            let planar = RDF_Literal.simple "Planar"
            let planci = RDF_Literal.simple "Planar Coordinate Information"
            let plance = RDF_Literal.simple "Planar Coordinate Encoding Method"
            let coordrep = RDF_Literal.simple "Coordinate Representation"
            let absres = RDF_Literal.simple "Abscissa Resolution"
            let plandu = RDF_Literal.simple "Planar Distance Units"
            let geodetic = RDF_Literal.simple "Geodetic Model"
            let horizdn = RDF_Literal.simple "Horizontal Datum Name"
            let ellips = RDF_Literal.simple "Ellipsoid Name"
            let semiaxis = RDF_Literal.simple "Semi-Major Axis"
            let denflat = RDF_Literal.simple "Denominator of Flattening Ratio"
            let vertdef = RDF_Literal.simple "Vertical Coordinate System Definition"
            let altsys = RDF_Literal.simple "Altitude System Definition"
            let altenc = RDF_Literal.simple "Altitude Encoding Method"
            let eainfo = RDF_Literal.simple "Entity and Attribute Information"
            let enttyp = RDF_Literal.simple "Entity Type"
            let enttypl = RDF_Literal.simple "Entity Type Label"
            let enttypt = RDF_Literal.simple "Entity Type Type"
            let enttypc = RDF_Literal.simple "Entity Type Count"
            let attr = RDF_Literal.simple "Attribute"
            let attrlabl = RDF_Literal.simple "Attribute Label"
            let attalias = RDF_Literal.simple "Attribute Alias"
            let attrdef = RDF_Literal.simple "Attribute Definition"
            let attrdefs = RDF_Literal.simple "Attribute Definition Source"
            let attrtype = RDF_Literal.simple "Attribute Type"
            let attwidth = RDF_Literal.simple "Attribute Width"
            let atprecis = RDF_Literal.simple "Attribute Precision"
            let attscale = RDF_Literal.simple "Attribute Scale"
            let attrdomv = RDF_Literal.simple "Attribute Domain Values"
            let udom = RDF_Literal.simple "Unrepresentable Domain"
            let subtype = RDF_Literal.simple "Subtype Information"
            let stfield = RDF_Literal.simple "Subtype Attribute"
            let stfldnm = RDF_Literal.simple "Subtype Attribute Name"
            let stflddv = RDF_Literal.simple "Subtype Default Value"
            let stflddd = RDF_Literal.simple "Attribute Defined Domain"
            let domname = RDF_Literal.simple "Domain Name"
            let domdesc = RDF_Literal.simple "Domain Description"
            let domowner = RDF_Literal.simple "Domain Owner"
            let domfldtp = RDF_Literal.simple "Domain Attribute Type"
            let domtype = RDF_Literal.simple "Domain Type"
            let splttype = RDF_Literal.simple "Split Rule"
            let distinfo = RDF_Literal.simple "Distribution Information"
            let resdesc = RDF_Literal.simple "Resource Description"
            let metainfo = RDF_Literal.simple "Metadata Reference Information"
            let metd = RDF_Literal.simple "Metadata Date"
            let langmeta = RDF_Literal.simple "Language of Metadata"
            let metc = RDF_Literal.simple "Metadata Contact"
            let metstdn = RDF_Literal.simple "Metadata Standard Name"
            let metstdv = RDF_Literal.simple "Metadata Standard Version"
            let mettc = RDF_Literal.simple "Metadata Time Convention"
            let metextns = RDF_Literal.simple "Metadata Extensions"
            let onlink = RDF_Literal.simple "Online Linkage"
            let metprof = RDF_Literal.simple "Profile Name"
            let origin = RDF_Literal.simple "Originator"
            let pubdate = RDF_Literal.simple "Publication Date"
            let title = RDF_Literal.simple "Title"
            let ftname = RDF_Literal.simple "File or Table Name"
            let geoform = RDF_Literal.simple "Geospatial Data Presentation Form"
            let pubinfo = RDF_Literal.simple "Publication Information"
            let pubplace = RDF_Literal.simple "Publication Place"
            let publish = RDF_Literal.simple "Publisher"
            let sngdate = RDF_Literal.simple "Single Date/Time"
            let caldate = RDF_Literal.simple "Calendar Date"
            let cntper = RDF_Literal.simple "Contact Person"
            let cntorg = RDF_Literal.simple "Contact Organization"
            let cntorgp = RDF_Literal.simple "Contact Organization Primary"
            let addrtype = RDF_Literal.simple "Address Type"
            let address = RDF_Literal.simple "Address"
            let city = RDF_Literal.simple "City"
            let state = RDF_Literal.simple "State or Province"
            let postal = RDF_Literal.simple "Postal Code"
            let cntvoice = RDF_Literal.simple "Contact Voice Telephone"
            let hours = RDF_Literal.simple "Hours of Service"


module hansen =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"http://hansen.com/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let Reference_Guide = _vocab "Reference_Guide"
    let H8Help_glossary = _vocab "H8Help_glossary"
    let Metadata = _vocab "Metadata"

    let asset_management = _vocab "asset_management"
    let basics = _vocab "basics"
    let budgeting = _vocab "budgeting"
    let cashiering = _vocab "cashiering"

    let community_development_and_regulation =
        _vocab "community_development_and_regulation"

    let code_enforcement = _vocab "code_enforcement"
    let core = _vocab "core"
    let customer_service_management = _vocab "customer_service_management"
    let inventory = _vocab "inventory"
    let personalization = _vocab "personalization"
    let resources = _vocab "resources"
    let service_and_constituent = _vocab "service_and_constituent"
    let system = _vocab "system"
    let work_management = _vocab "work_management"
    let data_layer = _vocab "data_layer"


module infor =

    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"http://schema.infor.com/InforOAGIS/2/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let data_layer = _vocab "data_layer"
    let business_layer = _vocab "business_layer"
    let presentation_layer = _vocab "presentation_layer"
    let asset = _vocab "asset"
    let CodeTable = _vocab "CodeTable"
    let Table = _vocab "Table"
    let LinkTable = _vocab "LinkTable"
    let AttachementLinkTable = _vocab "AttachementLinkTable"
    let LinearAsset = _vocab "LinearAsset"
    let MainlineAsset = _vocab "MainlineAsset"
    let SegmentAsset = _vocab "SegmentAsset"
    let EquipmentAsset = _vocab "EquipmentAsset"
    let CompoundAsset = _vocab "CompoundAsset"
    let SimpleAsset = _vocab "SimpleAsset"
    let View = _vocab "View"
    let TransactionCore = _vocab "TransactionCore"

    let System_License = _vocab "System_License"
    let Column = _vocab "Column"
    let Domain_Column = _vocab "Domain_Column"
    let Unique_Column = _vocab "Unique_Column"
    let Product_Family = _vocab "Product_Family"

    let Enumeration = _vocab "Enumeration"

    // distinct infor element names
    let column = _vocab "column"
    let customCreateStatement = _vocab "customCreateStatement"
    let domainColumn = _vocab "domainColumn"
    let domainColumnReference = _vocab "domainColumnReference"
    let enumeration = _vocab "enumeration"
    let enumerationCheckConstraint = _vocab "enumerationCheckConstraint"
    let enumerationValue = _vocab "enumerationValue"
    let foreignColumnReference = _vocab "foreignColumnReference"
    let foreignKeyConstraint = _vocab "foreignKeyConstraint"
    let hansenDataDistribution = _vocab "hansenDataDistribution"
    let hansenMetadata = _vocab "hansenMetadata"
    let index = _vocab "index"
    let localColumnReference = _vocab "localColumnReference"
    let primaryKeyConstraint = _vocab "primaryKeyConstraint"
    let productFamily = _vocab "productFamily"
    let referencingConstraint = _vocab "referencingConstraint"
    let requiredSystemLicense = _vocab "requiredSystemLicense"
    let systemLicense = _vocab "systemLicense"
    let table = _vocab "table"
    let tableCheckConstraint = _vocab "tableCheckConstraint"
    let text = _vocab "text"
    let uniqueConstraint = _vocab "uniqueConstraint"
    // distinct infor attribute names
    let cardinalityChild = _vocab "cardinalityChild"
    let cardinalityParent = _vocab "cardinalityParent"
    let cardinalityUsedByApplication = _vocab "cardinalityUsedByApplication"
    let commonId = _vocab "commonId"
    let dataPrecision = _vocab "dataPrecision"
    let dataScale = _vocab "dataScale"
    let databaseName = _vocab "databaseName"
    let defaultValue = _vocab "defaultValue"
    let deleteRule = _vocab "deleteRule"
    let deploymentStatus = _vocab "deploymentStatus"
    let description = _vocab "description"
    let direction = _vocab "direction"
    let displayDescription = _vocab "displayDescription"
    let displayName = _vocab "displayName"
    let displayTitle = _vocab "displayTitle"
    let displayTitleLong = _vocab "displayTitleLong"
    let effectiveDateTime = _vocab "effectiveDateTime"
    let enumerationName = _vocab "enumerationName"
    let expiredDateTime = _vocab "expiredDateTime"
    let hasNullRecord = _vocab "hasNullRecord"
    let identitySeed = _vocab "identitySeed"
    let identityStep = _vocab "identityStep"
    let isAgencyEnhancable = _vocab "isAgencyEnhancable"
    let isHansen = _vocab "isHansen"
    let isLicensed = _vocab "isLicensed"
    let isNullable = _vocab "isNullable"
    let isRequired = _vocab "isRequired"
    let isUnique = _vocab "isUnique"
    let length = _vocab "length"
    let locale = _vocab "locale"
    let name = _vocab "name"
    let oracleStatement = _vocab "oracleStatement"
    let order = _vocab "order"
    let owner = _vocab "owner"
    let platform = _vocab "platform"
    let remarks = _vocab "remarks"
    let showSearchOrder = _vocab "showSearchOrder"
    let statement = _vocab "statement"
    let ``type`` = _vocab "type"
    let useSearchOrder = _vocab "useSearchOrder"
    let value = _vocab "value"
    // distinct column names
    let Code = _vocab "Code"
    let Description = _vocab "Description"
    let BackgroundColor = _vocab "BackgroundColor"
    let IsException = _vocab "IsException"
    let TextColor = _vocab "TextColor"
    let BillableUsage = _vocab "BillableUsage"
    let BillableUsageInCubicFeet = _vocab "BillableUsageInCubicFeet"
    let FieldNotes = _vocab "FieldNotes"
    let Inspection = _vocab "Inspection"
    let IsCorrected = _vocab "IsCorrected"
    let IsCycle = _vocab "IsCycle"
    let IsEstimate = _vocab "IsEstimate"
    let IsFinal = _vocab "IsFinal"
    let IsInitial = _vocab "IsInitial"
    let IsReadyToBill = _vocab "IsReadyToBill"
    let ReadBy = _vocab "ReadBy"
    let ReaderCode = _vocab "ReaderCode"
    let Reading = _vocab "Reading"
    let ReadingDateTime = _vocab "ReadingDateTime"
    let ReadingKey = _vocab "ReadingKey"
    let Reason = _vocab "Reason"
    let Source = _vocab "Source"
    let StormMeter = _vocab "StormMeter"
    let Usage = _vocab "Usage"
    let WorkOrder = _vocab "WorkOrder"
    let GroupProject = _vocab "GroupProject"
    let ServiceRequest = _vocab "ServiceRequest"
    let Asset = _vocab "Asset"
    let AssetType = _vocab "AssetType"
    let Index = _vocab "Index"
    let IndexHistoryKey = _vocab "IndexHistoryKey"
    let IndexValue = _vocab "IndexValue"
    let InspectionCategory = _vocab "InspectionCategory"
    let InspectionDate = _vocab "InspectionDate"
    let Comments = _vocab "Comments"
    let Attachment = _vocab "Attachment"
    let IsDefault = _vocab "IsDefault"
    let Observation = _vocab "Observation"
    let AreaFeet = _vocab "AreaFeet"
    let AreaMeters = _vocab "AreaMeters"
    let InspectionKey = _vocab "InspectionKey"
    let InspectionSampleUnitKey = _vocab "InspectionSampleUnitKey"
    let LengthFeet = _vocab "LengthFeet"
    let LengthMeters = _vocab "LengthMeters"
    let SampleDescription = _vocab "SampleDescription"
    let SampleUnitNumber = _vocab "SampleUnitNumber"
    let WidthFeet = _vocab "WidthFeet"
    let WidthMeters = _vocab "WidthMeters"
    let ComponentType = _vocab "ComponentType"
    let AssetLength = _vocab "AssetLength"
    let AssetLengthUOM = _vocab "AssetLengthUOM"
    let AssetWidth = _vocab "AssetWidth"
    let AssetWidthUOM = _vocab "AssetWidthUOM"
    let AssignedTo = _vocab "AssignedTo"
    let CancelInspection = _vocab "CancelInspection"
    let CompletedBy = _vocab "CompletedBy"
    let CompletedDateTime = _vocab "CompletedDateTime"
    let GroupInspection = _vocab "GroupInspection"
    let GroupInspectionSchedule = _vocab "GroupInspectionSchedule"
    let InspectionNumber = _vocab "InspectionNumber"
    let InspectionSchedule = _vocab "InspectionSchedule"
    let InspectionType = _vocab "InspectionType"
    let PlanKey = _vocab "PlanKey"
    let Responsibility = _vocab "Responsibility"
    let ScheduledDateTime = _vocab "ScheduledDateTime"
    let StartDateTime = _vocab "StartDateTime"
    let Project = _vocab "Project"
    let Priority = _vocab "Priority"
    let Problem = _vocab "Problem"
    let InspectionSource = _vocab "InspectionSource"
    let InitiatedBy = _vocab "InitiatedBy"
    let InitiatedDateTime = _vocab "InitiatedDateTime"
    let ReferenceNumber = _vocab "ReferenceNumber"
    let BudgetNumber = _vocab "BudgetNumber"
    let ClassDescription = _vocab "ClassDescription"
    let ClassName = _vocab "ClassName"
    let DisplayOrder = _vocab "DisplayOrder"
    let EffectiveDate = _vocab "EffectiveDate"
    let ExpireDate = _vocab "ExpireDate"
    let ServiceInspDetailKey = _vocab "ServiceInspDetailKey"
    let Title = _vocab "Title"
    let AddOnConditionFormula = _vocab "AddOnConditionFormula"
    let DistanceTo = _vocab "DistanceTo"
    let IsResolved = _vocab "IsResolved"
    let MeasuredFrom = _vocab "MeasuredFrom"
    let Measurement = _vocab "Measurement"
    let ObservationDefinition = _vocab "ObservationDefinition"
    let ObservationKey = _vocab "ObservationKey"
    let ObservationSeverity = _vocab "ObservationSeverity"
    let Offset = _vocab "Offset"
    let OffsetUOM = _vocab "OffsetUOM"
    let Rating = _vocab "Rating"
    let RelativeDistanceFrom = _vocab "RelativeDistanceFrom"
    let RelativeDistanceTo = _vocab "RelativeDistanceTo"
    let ResolvedDate = _vocab "ResolvedDate"
    let SampleUnit = _vocab "SampleUnit"
    let StartDistance = _vocab "StartDistance"
    let Width = _vocab "Width"
    let WidthUOM = _vocab "WidthUOM"
    let InspectionTypeKey = _vocab "InspectionTypeKey"
    let StandardOperatingProcedure = _vocab "StandardOperatingProcedure"
    let UnitOfWork = _vocab "UnitOfWork"
    let InspTypeKey = _vocab "InspTypeKey"
    let ObsDetailPageName = _vocab "ObsDetailPageName"
    let ObservationCode = _vocab "ObservationCode"
    let ObservationDefinitionKey = _vocab "ObservationDefinitionKey"
    let ObservationDescription = _vocab "ObservationDescription"
    let UnitOfMeasure = _vocab "UnitOfMeasure"
    let WeightingFactor = _vocab "WeightingFactor"
    let ObservationGroup = _vocab "ObservationGroup"
    let ObservationSeverityDescription = _vocab "ObservationSeverityDescription"
    let ObservationSeverityKey = _vocab "ObservationSeverityKey"
    let UsageReading = _vocab "UsageReading"
    let Weather = _vocab "Weather"
    let PreCleaning = _vocab "PreCleaning"
    let MediaNumber = _vocab "MediaNumber"
    let SurveyedDepth = _vocab "SurveyedDepth"
    let SurveyedDepthUOM = _vocab "SurveyedDepthUOM"
    let SurveyedDiameter = _vocab "SurveyedDiameter"
    let SurveyedDiameterUOM = _vocab "SurveyedDiameterUOM"
    let IsGrouted = _vocab "IsGrouted"
    let VTRIndex = _vocab "VTRIndex"
    let PositionFrom = _vocab "PositionFrom"
    let PositionTo = _vocab "PositionTo"
    let SurveyedHeight = _vocab "SurveyedHeight"
    let SurveyedHeightUOM = _vocab "SurveyedHeightUOM"
    let Address = _vocab "Address"
    let AddressQualifier = _vocab "AddressQualifier"
    let Area = _vocab "Area"
    let AsBuilt = _vocab "AsBuilt"
    let AssetKey = _vocab "AssetKey"
    let Complex = _vocab "Complex"
    let District = _vocab "District"
    let ExpiredBy = _vocab "ExpiredBy"
    let GISStaticIdentifier = _vocab "GISStaticIdentifier"
    let ID = _vocab "ID"
    let InstalledDate = _vocab "InstalledDate"
    let Location = _vocab "Location"
    let MainLine = _vocab "MainLine"
    let Manufacturer = _vocab "Manufacturer"
    let MapNumber = _vocab "MapNumber"
    let ModelNumber = _vocab "ModelNumber"
    let Ownership = _vocab "Ownership"
    let Parcel = _vocab "Parcel"
    let SerialNumber = _vocab "SerialNumber"
    let ServiceLine = _vocab "ServiceLine"
    let ServiceStatus = _vocab "ServiceStatus"
    let Site = _vocab "Site"
    let Size = _vocab "Size"
    let SizeUOM = _vocab "SizeUOM"
    let SpecialInstructions = _vocab "SpecialInstructions"
    let StreetSegment = _vocab "StreetSegment"
    let SubArea = _vocab "SubArea"
    let UnitDesc = _vocab "UnitDesc"
    let UnitType = _vocab "UnitType"
    let UsageArea = _vocab "UsageArea"
    let XCoordinate = _vocab "XCoordinate"
    let YCoordinate = _vocab "YCoordinate"
    let ZCoordinate = _vocab "ZCoordinate"
    let Organization = _vocab "Organization"
    let AccessRoad = _vocab "AccessRoad"
    let AccessRoadUnitOfMeasure = _vocab "AccessRoadUnitOfMeasure"
    let BaseWidth = _vocab "BaseWidth"
    let BaseWidthUOM = _vocab "BaseWidthUOM"
    let ChannelWidth = _vocab "ChannelWidth"
    let ChannelWidthUOM = _vocab "ChannelWidthUOM"
    let ConstructionMaterial = _vocab "ConstructionMaterial"
    let DesignCapacity = _vocab "DesignCapacity"
    let DesignCapacityUOM = _vocab "DesignCapacityUOM"
    let DesignFlow = _vocab "DesignFlow"
    let DownstreamDepth = _vocab "DownstreamDepth"
    let DownstreamDepthUOM = _vocab "DownstreamDepthUOM"
    let DownstreamElevationUOM = _vocab "DownstreamElevationUOM"
    let DownstreamInvertElevation = _vocab "DownstreamInvertElevation"
    let EasementWidth = _vocab "EasementWidth"
    let EasementWidthUOM = _vocab "EasementWidthUOM"
    let GateLocation = _vocab "GateLocation"
    let ID2 = _vocab "ID2"
    let LeftBankHeight = _vocab "LeftBankHeight"
    let LeftBankHeightUOM = _vocab "LeftBankHeightUOM"
    let LeftBankMaterial = _vocab "LeftBankMaterial"
    let LeftBankSlope = _vocab "LeftBankSlope"
    let LeftBankSlopeUOM = _vocab "LeftBankSlopeUOM"
    let LeftFenceType = _vocab "LeftFenceType"
    let LeftLandUse = _vocab "LeftLandUse"
    let Length = _vocab "Length"
    let LengthUOM = _vocab "LengthUOM"
    let LockDetails = _vocab "LockDetails"
    let ParallelLineNumber = _vocab "ParallelLineNumber"
    let RampLocation = _vocab "RampLocation"
    let RightBankHeight = _vocab "RightBankHeight"
    let RightBankHeightUOM = _vocab "RightBankHeightUOM"
    let RightBankMaterial = _vocab "RightBankMaterial"
    let RightBankSlope = _vocab "RightBankSlope"
    let RightBankSlopeUOM = _vocab "RightBankSlopeUOM"
    let RightFenceType = _vocab "RightFenceType"
    let RightLandUse = _vocab "RightLandUse"
    let Segment = _vocab "Segment"
    let Shape = _vocab "Shape"
    let Slope = _vocab "Slope"
    let SlopeUOM = _vocab "SlopeUOM"
    let UnitID2Asset = _vocab "UnitID2Asset"
    let UnitID2Type = _vocab "UnitID2Type"
    let UnitIDAsset = _vocab "UnitIDAsset"
    let UnitIDType = _vocab "UnitIDType"
    let UpstreamDepth = _vocab "UpstreamDepth"
    let UpstreamDepthUOM = _vocab "UpstreamDepthUOM"
    let UpstreamElevation = _vocab "UpstreamElevation"
    let UpstreamElevationUOM = _vocab "UpstreamElevationUOM"
    let Vegetation = _vocab "Vegetation"
    let BottomWidth = _vocab "BottomWidth"
    let Diameter = _vocab "Diameter"
    let Distance = _vocab "Distance"
    let DrainageKey = _vocab "DrainageKey"
    let DrainType = _vocab "DrainType"
    let FlapGate = _vocab "FlapGate"
    let Side = _vocab "Side"
    let SideSlope = _vocab "SideSlope"
    let StormChannelDrainageConnectionKey = _vocab "StormChannelDrainageConnectionKey"
    let WeightFactor = _vocab "WeightFactor"
    let Failure = _vocab "Failure"
    let FailureDefinitionKey = _vocab "FailureDefinitionKey"
    let IsCompleted = _vocab "IsCompleted"
    let Image = _vocab "Image"
    let ConnectionPipeLength = _vocab "ConnectionPipeLength"
    let ConnectionPipeLengthUOM = _vocab "ConnectionPipeLengthUOM"
    let ConnectionPipeSize = _vocab "ConnectionPipeSize"
    let ConnectionPipeSzeUOM = _vocab "ConnectionPipeSzeUOM"
    let ConnectionPipeType = _vocab "ConnectionPipeType"
    let Depth = _vocab "Depth"
    let DepthUOM = _vocab "DepthUOM"
    let DownstreamConnectionDirection = _vocab "DownstreamConnectionDirection"
    let DownstreamConnectionType = _vocab "DownstreamConnectionType"
    let DownstreamDistance = _vocab "DownstreamDistance"
    let DownstreamDistanceFromNode = _vocab "DownstreamDistanceFromNode"
    let DownstreamDistanceUOM = _vocab "DownstreamDistanceUOM"
    let DownstreamInvertElevationUOM = _vocab "DownstreamInvertElevationUOM"
    let DownstreamStormInlet = _vocab "DownstreamStormInlet"
    let GrateType = _vocab "GrateType"
    let Intersection = _vocab "Intersection"
    let Material = _vocab "Material"
    let OutletDepth = _vocab "OutletDepth"
    let OutletDepthUOM = _vocab "OutletDepthUOM"
    let UpstreamInvertElevation = _vocab "UpstreamInvertElevation"
    let UpstreamInvertElevationUOM = _vocab "UpstreamInvertElevationUOM"
    let Volume = _vocab "Volume"
    let CrestCamber = _vocab "CrestCamber"
    let DownstreamFilterLayer = _vocab "DownstreamFilterLayer"
    let DownstreamSlope = _vocab "DownstreamSlope"
    let DownstreamSlopeUOM = _vocab "DownstreamSlopeUOM"
    let Foundation = _vocab "Foundation"
    let FreeboardNormal = _vocab "FreeboardNormal"
    let FreeboardNormalUOM = _vocab "FreeboardNormalUOM"
    let FreeboardWithWaveWall = _vocab "FreeboardWithWaveWall"
    let FreeboardWithWaveWallUOM = _vocab "FreeboardWithWaveWallUOM"
    let Height = _vocab "Height"
    let HeightUOM = _vocab "HeightUOM"
    let IsUpstreamFilterLayer = _vocab "IsUpstreamFilterLayer"
    let SeismicResistance = _vocab "SeismicResistance"
    let TopLevel = _vocab "TopLevel"
    let TopLevelUOM = _vocab "TopLevelUOM"
    let UpstreamSlope = _vocab "UpstreamSlope"
    let UpstreamSlopeUOM = _vocab "UpstreamSlopeUOM"
    let WaveWallHeight = _vocab "WaveWallHeight"
    let WaveWallHeightUOM = _vocab "WaveWallHeightUOM"
    let WaveWallThickness = _vocab "WaveWallThickness"
    let WaveWallThicknessUOM = _vocab "WaveWallThicknessUOM"
    let DischargePipeSize = _vocab "DischargePipeSize"
    let DischargePipeSizeUOM = _vocab "DischargePipeSizeUOM"
    let NumberOfPumps = _vocab "NumberOfPumps"
    let OverflowElevation = _vocab "OverflowElevation"
    let OverflowElevationUOM = _vocab "OverflowElevationUOM"
    let PumpingCapacity = _vocab "PumpingCapacity"
    let PumpingCapacityUOM = _vocab "PumpingCapacityUOM"
    let WetWellElevation = _vocab "WetWellElevation"
    let WetWellElevationUOM = _vocab "WetWellElevationUOM"
    let WetWellVolume = _vocab "WetWellVolume"
    let WetWellVolumeUOM = _vocab "WetWellVolumeUOM"
    let CriticalRating = _vocab "CriticalRating"
    let DirectionFromDownstream = _vocab "DirectionFromDownstream"
    let DirectionFromUpstream = _vocab "DirectionFromUpstream"
    let DownstreamElevation = _vocab "DownstreamElevation"
    let FrictionFactor = _vocab "FrictionFactor"
    let GroundWaterLevel = _vocab "GroundWaterLevel"
    let GroundWaterLevelUOM = _vocab "GroundWaterLevelUOM"
    let JointLength = _vocab "JointLength"
    let JointLengthUOM = _vocab "JointLengthUOM"
    let JointType = _vocab "JointType"
    let PipeDiameter = _vocab "PipeDiameter"
    let PipeDiameterUOM = _vocab "PipeDiameterUOM"
    let PipeHeight = _vocab "PipeHeight"
    let PipeHeightUOM = _vocab "PipeHeightUOM"
    let PipeLength = _vocab "PipeLength"
    let PipeLengthUOM = _vocab "PipeLengthUOM"
    let PipeMaterial = _vocab "PipeMaterial"
    let PipeShape = _vocab "PipeShape"
    let SurfaceCover = _vocab "SurfaceCover"
    let BarrelDiameter = _vocab "BarrelDiameter"
    let BarrelDiameterUOM = _vocab "BarrelDiameterUOM"
    let BaseType = _vocab "BaseType"
    let BenchType = _vocab "BenchType"
    let ChannelType = _vocab "ChannelType"
    let ConeType = _vocab "ConeType"
    let CoverDiameter = _vocab "CoverDiameter"
    let CoverDiameterUOM = _vocab "CoverDiameterUOM"
    let CoverType = _vocab "CoverType"
    let DistanceToHydrant = _vocab "DistanceToHydrant"
    let DistanceToHydrantUOM = _vocab "DistanceToHydrantUOM"
    let FrameType = _vocab "FrameType"
    let IsDropManhole = _vocab "IsDropManhole"
    let IsMetered = _vocab "IsMetered"
    let RingsMaterial = _vocab "RingsMaterial"
    let StepsMaterial = _vocab "StepsMaterial"
    let WallMaterial = _vocab "WallMaterial"
    let AccountNumber = _vocab "AccountNumber"
    let AverageMonthlyUsage = _vocab "AverageMonthlyUsage"
    let AverageMonthlyUsageUOM = _vocab "AverageMonthlyUsageUOM"
    let Elevation = _vocab "Elevation"
    let ElevationUOM = _vocab "ElevationUOM"
    let HasBypass = _vocab "HasBypass"
    let HighRegister = _vocab "HighRegister"
    let LowRegister = _vocab "LowRegister"
    let ManufacturedDate = _vocab "ManufacturedDate"
    let MeterComponent = _vocab "MeterComponent"
    let PipeGrade = _vocab "PipeGrade"
    let PipeSize = _vocab "PipeSize"
    let PipeSizeUOM = _vocab "PipeSizeUOM"
    let Purchased = _vocab "Purchased"
    let ServiceType = _vocab "ServiceType"
    let TotalUsage = _vocab "TotalUsage"
    let TotalUsageUOM = _vocab "TotalUsageUOM"
    let UsageDate = _vocab "UsageDate"
    let WetWellOverflow = _vocab "WetWellOverflow"
    let WetWellOverflowUOM = _vocab "WetWellOverflowUOM"
    let MasterComponent = _vocab "MasterComponent"
    let NumberOfDials = _vocab "NumberOfDials"
    let Configuration = _vocab "Configuration"
    let HighRegisterMultiplier = _vocab "HighRegisterMultiplier"
    let HighRegisterNumberOfDecimals = _vocab "HighRegisterNumberOfDecimals"
    let HighRegisterNumberOfDials = _vocab "HighRegisterNumberOfDials"
    let LowRegisterMultiplier = _vocab "LowRegisterMultiplier"
    let LowRegisterNumberOfDecimals = _vocab "LowRegisterNumberOfDecimals"
    let LowRegisterNumberOfDials = _vocab "LowRegisterNumberOfDials"
    let Color = _vocab "Color"
    let Condition = _vocab "Condition"
    let DiameterUOM = _vocab "DiameterUOM"
    let Weight = _vocab "Weight"
    let WeightUOM = _vocab "WeightUOM"
    let DistanceFromEndpoint = _vocab "DistanceFromEndpoint"
    let DistanceFromEndpointUOM = _vocab "DistanceFromEndpointUOM"
    let FromEndpoint = _vocab "FromEndpoint"
    let ExpectedLife = _vocab "ExpectedLife"
    let ExpectedLifeUOM = _vocab "ExpectedLifeUOM"
    let Flow = _vocab "Flow"
    let FlowUOM = _vocab "FlowUOM"
    let MeanTimeBetweenFailures = _vocab "MeanTimeBetweenFailures"
    let MeanTimeBetweenFailuresUOM = _vocab "MeanTimeBetweenFailuresUOM"
    let MotorSerialNumber = _vocab "MotorSerialNumber"
    let RevolutionsPerMinute = _vocab "RevolutionsPerMinute"
    let TotalDynamicHead = _vocab "TotalDynamicHead"
    let Trim = _vocab "Trim"
    let Building = _vocab "Building"
    let CleanoutLocation = _vocab "CleanoutLocation"
    let DepthAtPropertyLine = _vocab "DepthAtPropertyLine"
    let DepthAtPropertyLineUOM = _vocab "DepthAtPropertyLineUOM"
    let DunAndBradstreetNumber = _vocab "DunAndBradstreetNumber"
    let EnvironmentalProtectAgencyID = _vocab "EnvironmentalProtectAgencyID"
    let MunicipalityCondition = _vocab "MunicipalityCondition"
    let NPDESID = _vocab "NPDESID"
    let NumberOfTaps = _vocab "NumberOfTaps"
    let OwnerCondition = _vocab "OwnerCondition"
    let SIC = _vocab "SIC"
    let TapAddress = _vocab "TapAddress"
    let TapDistance = _vocab "TapDistance"
    let TapDistanceUOM = _vocab "TapDistanceUOM"
    let TapFrom = _vocab "TapFrom"
    let TapLocation = _vocab "TapLocation"
    let UICID = _vocab "UICID"
    let CAS = _vocab "CAS"
    let GenericClass = _vocab "GenericClass"
    let IsInService = _vocab "IsInService"
    let DeadStorageCapacity = _vocab "DeadStorageCapacity"
    let DeadStorageCapacityUOM = _vocab "DeadStorageCapacityUOM"
    let FullSupplyLevelGauge = _vocab "FullSupplyLevelGauge"
    let FullSupplyLevelGaugeUOM = _vocab "FullSupplyLevelGaugeUOM"
    let FullSupplyLevelRL = _vocab "FullSupplyLevelRL"
    let FullSupplyLevelRLUOM = _vocab "FullSupplyLevelRLUOM"
    let LiveStorageCapacity = _vocab "LiveStorageCapacity"
    let LiveStorageCapacityUOM = _vocab "LiveStorageCapacityUOM"
    let MinimumOperatingLevelGauge = _vocab "MinimumOperatingLevelGauge"
    let MinimumOperatingLevelRL = _vocab "MinimumOperatingLevelRL"
    let MinOperatingLevelGaugeUOM = _vocab "MinOperatingLevelGaugeUOM"
    let MinOperatingLevelRLUOM = _vocab "MinOperatingLevelRLUOM"
    let SurfaceArea = _vocab "SurfaceArea"
    let SurfaceAreaUOM = _vocab "SurfaceAreaUOM"
    let TotalCapacity = _vocab "TotalCapacity"
    let TotalCapacityUOM = _vocab "TotalCapacityUOM"
    let CapacityAtDepth = _vocab "CapacityAtDepth"
    let DepthCapacityKey = _vocab "DepthCapacityKey"
    let DrainageCapacity = _vocab "DrainageCapacity"
    let DrainageSystem = _vocab "DrainageSystem"
    let DrainKey = _vocab "DrainKey"
    let FloodLevel = _vocab "FloodLevel"
    let FloodLevelEvent = _vocab "FloodLevelEvent"
    let FloodLevelKey = _vocab "FloodLevelKey"
    let TypeKey = _vocab "TypeKey"
    let DirectionToOpen = _vocab "DirectionToOpen"
    let InvertElevation = _vocab "InvertElevation"
    let InvertElevationUOM = _vocab "InvertElevationUOM"
    let NumberOfTurnsToOpen = _vocab "NumberOfTurnsToOpen"
    let Obstruction = _vocab "Obstruction"
    let OperatorDepth = _vocab "OperatorDepth"
    let OperatorDepthUOM = _vocab "OperatorDepthUOM"
    let RimElevation = _vocab "RimElevation"
    let RimElevationUOM = _vocab "RimElevationUOM"
    let ValveStatus = _vocab "ValveStatus"

    module Hansen =
        module AssetManagement =
            module UsageArea =

                let productFamily = _vocab "Hansen.AssetManagement.UsageArea"

                module Complex =
                    let table = _vocab "Hansen.AssetManagement.UsageArea.Complex"
                    let Address = _vocab "Hansen.AssetManagement.UsageArea.Complex.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.UsageArea.Complex.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.UsageArea.Complex.Area"
                    let AreaSize = _vocab "Hansen.AssetManagement.UsageArea.Complex.AreaSize"

                    let AreaSizeUnitOfMeasure =
                        _vocab "Hansen.AssetManagement.UsageArea.Complex.AreaSizeUnitOfMeasure"

                    let AsBuilt = _vocab "Hansen.AssetManagement.UsageArea.Complex.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.UsageArea.Complex.AssetKey"
                    let BudgetNumber = _vocab "Hansen.AssetManagement.UsageArea.Complex.BudgetNumber"
                    let Complex = _vocab "Hansen.AssetManagement.UsageArea.Complex.Complex"
                    let District = _vocab "Hansen.AssetManagement.UsageArea.Complex.District"
                    let ExpiredBy = _vocab "Hansen.AssetManagement.UsageArea.Complex.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.UsageArea.Complex.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.UsageArea.Complex.ID"
                    let InstalledDate = _vocab "Hansen.AssetManagement.UsageArea.Complex.InstalledDate"
                    let Location = _vocab "Hansen.AssetManagement.UsageArea.Complex.Location"
                    let MapNumber = _vocab "Hansen.AssetManagement.UsageArea.Complex.MapNumber"
                    let Organization = _vocab "Hansen.AssetManagement.UsageArea.Complex.Organization"
                    let Ownership = _vocab "Hansen.AssetManagement.UsageArea.Complex.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.UsageArea.Complex.Parcel"
                    let ServiceStatus = _vocab "Hansen.AssetManagement.UsageArea.Complex.ServiceStatus"
                    let Site = _vocab "Hansen.AssetManagement.UsageArea.Complex.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.UsageArea.Complex.SpecialInstructions"

                    let StreetSegment = _vocab "Hansen.AssetManagement.UsageArea.Complex.StreetSegment"
                    let SubArea = _vocab "Hansen.AssetManagement.UsageArea.Complex.SubArea"
                    let UnitDesc = _vocab "Hansen.AssetManagement.UsageArea.Complex.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.UsageArea.Complex.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.UsageArea.Complex.UsageArea"
                    let XCoordinate = _vocab "Hansen.AssetManagement.UsageArea.Complex.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.UsageArea.Complex.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.UsageArea.Complex.ZCoordinate"

            module Storm =
                let productFamily = _vocab "Hansen.AssetManagement.Storm"

                module StormBackflowPreventer =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.AssetKey"

                    let BudgetNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.BudgetNumber"

                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Complex"
                    let District = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.District"

                    let ExpiredBy =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.ID"

                    let InstalledDate =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.InstalledDate"

                    let Location = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Location"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.MainLine"

                    let Manufacturer =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Manufacturer"

                    let MapNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.MapNumber"

                    let ModelNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.ModelNumber"

                    let Organization =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Organization"

                    let Ownership =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Ownership"

                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Parcel"

                    let Responsibility =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Responsibility"

                    let SerialNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.SerialNumber"

                    let ServiceLine =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.ServiceLine"

                    let ServiceStatus =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.ServiceStatus"

                    let Site = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Site"
                    let Size = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.Size"
                    let SizeUOM = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.SizeUOM"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.SpecialInstructions"

                    let StreetSegment =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.StreetSegment"

                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.SubArea"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.UnitType"

                    let UsageArea =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.UsageArea"

                    let XCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.XCoordinate"

                    let YCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.YCoordinate"

                    let ZCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormBackflowPreventer.ZCoordinate"

                module StormChannel =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormChannel"
                    let AccessRoad = _vocab "Hansen.AssetManagement.Storm.StormChannel.AccessRoad"

                    let AccessRoadUnitOfMeasure =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.AccessRoadUnitOfMeasure"

                    let Address = _vocab "Hansen.AssetManagement.Storm.StormChannel.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormChannel.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormChannel.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormChannel.AssetKey"
                    let BaseWidth = _vocab "Hansen.AssetManagement.Storm.StormChannel.BaseWidth"
                    let BaseWidthUOM = _vocab "Hansen.AssetManagement.Storm.StormChannel.BaseWidthUOM"
                    let BudgetNumber = _vocab "Hansen.AssetManagement.Storm.StormChannel.BudgetNumber"
                    let ChannelWidth = _vocab "Hansen.AssetManagement.Storm.StormChannel.ChannelWidth"

                    let ChannelWidthUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.ChannelWidthUOM"

                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormChannel.Complex"

                    let ConstructionMaterial =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.ConstructionMaterial"

                    let DesignCapacity =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.DesignCapacity"

                    let DesignCapacityUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.DesignCapacityUOM"

                    let DesignFlow = _vocab "Hansen.AssetManagement.Storm.StormChannel.DesignFlow"
                    let District = _vocab "Hansen.AssetManagement.Storm.StormChannel.District"

                    let DownstreamDepth =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.DownstreamDepth"

                    let DownstreamDepthUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.DownstreamDepthUOM"

                    let DownstreamElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.DownstreamElevationUOM"

                    let DownstreamInvertElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.DownstreamInvertElevation"

                    let EasementWidth = _vocab "Hansen.AssetManagement.Storm.StormChannel.EasementWidth"

                    let EasementWidthUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.EasementWidthUOM"

                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormChannel.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.GISStaticIdentifier"

                    let GateLocation = _vocab "Hansen.AssetManagement.Storm.StormChannel.GateLocation"
                    let ID = _vocab "Hansen.AssetManagement.Storm.StormChannel.ID"
                    let ID2 = _vocab "Hansen.AssetManagement.Storm.StormChannel.ID2"
                    let InstalledDate = _vocab "Hansen.AssetManagement.Storm.StormChannel.InstalledDate"

                    let LeftBankHeight =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.LeftBankHeight"

                    let LeftBankHeightUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.LeftBankHeightUOM"

                    let LeftBankMaterial =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.LeftBankMaterial"

                    let LeftBankSlope = _vocab "Hansen.AssetManagement.Storm.StormChannel.LeftBankSlope"

                    let LeftBankSlopeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.LeftBankSlopeUOM"

                    let LeftFenceType = _vocab "Hansen.AssetManagement.Storm.StormChannel.LeftFenceType"
                    let LeftLandUse = _vocab "Hansen.AssetManagement.Storm.StormChannel.LeftLandUse"
                    let Length = _vocab "Hansen.AssetManagement.Storm.StormChannel.Length"
                    let LengthUOM = _vocab "Hansen.AssetManagement.Storm.StormChannel.LengthUOM"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormChannel.Location"
                    let LockDetails = _vocab "Hansen.AssetManagement.Storm.StormChannel.LockDetails"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormChannel.MapNumber"
                    let Organization = _vocab "Hansen.AssetManagement.Storm.StormChannel.Organization"
                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormChannel.Ownership"

                    let ParallelLineNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.ParallelLineNumber"

                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormChannel.Parcel"
                    let RampLocation = _vocab "Hansen.AssetManagement.Storm.StormChannel.RampLocation"

                    let RightBankHeight =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.RightBankHeight"

                    let RightBankHeightUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.RightBankHeightUOM"

                    let RightBankMaterial =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.RightBankMaterial"

                    let RightBankSlope =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.RightBankSlope"

                    let RightBankSlopeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.RightBankSlopeUOM"

                    let RightFenceType =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.RightFenceType"

                    let RightLandUse = _vocab "Hansen.AssetManagement.Storm.StormChannel.RightLandUse"
                    let Segment = _vocab "Hansen.AssetManagement.Storm.StormChannel.Segment"
                    let ServiceStatus = _vocab "Hansen.AssetManagement.Storm.StormChannel.ServiceStatus"
                    let Shape = _vocab "Hansen.AssetManagement.Storm.StormChannel.Shape"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormChannel.Site"
                    let Slope = _vocab "Hansen.AssetManagement.Storm.StormChannel.Slope"
                    let SlopeUOM = _vocab "Hansen.AssetManagement.Storm.StormChannel.SlopeUOM"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.SpecialInstructions"

                    let StreetSegment = _vocab "Hansen.AssetManagement.Storm.StormChannel.StreetSegment"
                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormChannel.SubArea"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormChannel.UnitDesc"
                    let UnitID2Asset = _vocab "Hansen.AssetManagement.Storm.StormChannel.UnitID2Asset"
                    let UnitID2Type = _vocab "Hansen.AssetManagement.Storm.StormChannel.UnitID2Type"
                    let UnitIDAsset = _vocab "Hansen.AssetManagement.Storm.StormChannel.UnitIDAsset"
                    let UnitIDType = _vocab "Hansen.AssetManagement.Storm.StormChannel.UnitIDType"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormChannel.UnitType"
                    let UpstreamDepth = _vocab "Hansen.AssetManagement.Storm.StormChannel.UpstreamDepth"

                    let UpstreamDepthUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.UpstreamDepthUOM"

                    let UpstreamElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.UpstreamElevation"

                    let UpstreamElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormChannel.UpstreamElevationUOM"

                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormChannel.UsageArea"
                    let Vegetation = _vocab "Hansen.AssetManagement.Storm.StormChannel.Vegetation"
                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormChannel.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormChannel.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormChannel.ZCoordinate"

                module StormChannelDrainageConnection =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection"

                    let BottomWidth =
                        _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.BottomWidth"

                    let ConstructionMaterial =
                        _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.ConstructionMaterial"

                    let Diameter =
                        _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.Diameter"

                    let Distance =
                        _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.Distance"

                    let DrainType =
                        _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.DrainType"

                    let DrainageKey =
                        _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.DrainageKey"

                    let FlapGate =
                        _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.FlapGate"

                    let Side = _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.Side"

                    let SideSlope =
                        _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.SideSlope"

                    let StormChannelDrainageConnectionKey =
                        _vocab "Hansen.AssetManagement.Storm.StormChannelDrainageConnection.StormChannelDrainageConnectionKey"

                module StormInlet =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormInlet"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormInlet.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormInlet.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormInlet.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormInlet.AssetKey"
                    let BudgetNumber = _vocab "Hansen.AssetManagement.Storm.StormInlet.BudgetNumber"
                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormInlet.Complex"

                    let ConnectionPipeLength =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.ConnectionPipeLength"

                    let ConnectionPipeLengthUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.ConnectionPipeLengthUOM"

                    let ConnectionPipeSize =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.ConnectionPipeSize"

                    let ConnectionPipeSzeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.ConnectionPipeSzeUOM"

                    let ConnectionPipeType =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.ConnectionPipeType"

                    let Depth = _vocab "Hansen.AssetManagement.Storm.StormInlet.Depth"
                    let DepthUOM = _vocab "Hansen.AssetManagement.Storm.StormInlet.DepthUOM"
                    let District = _vocab "Hansen.AssetManagement.Storm.StormInlet.District"

                    let DownstreamConnectionDirection =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.DownstreamConnectionDirection"

                    let DownstreamConnectionType =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.DownstreamConnectionType"

                    let DownstreamDistance =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.DownstreamDistance"

                    let DownstreamDistanceFromNode =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.DownstreamDistanceFromNode"

                    let DownstreamDistanceUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.DownstreamDistanceUOM"

                    let DownstreamInvertElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.DownstreamInvertElevation"

                    let DownstreamInvertElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.DownstreamInvertElevationUOM"

                    let DownstreamStormInlet =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.DownstreamStormInlet"

                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormInlet.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.GISStaticIdentifier"

                    let GrateType = _vocab "Hansen.AssetManagement.Storm.StormInlet.GrateType"
                    let ID = _vocab "Hansen.AssetManagement.Storm.StormInlet.ID"
                    let InstalledDate = _vocab "Hansen.AssetManagement.Storm.StormInlet.InstalledDate"
                    let Intersection = _vocab "Hansen.AssetManagement.Storm.StormInlet.Intersection"
                    let Length = _vocab "Hansen.AssetManagement.Storm.StormInlet.Length"
                    let LengthUOM = _vocab "Hansen.AssetManagement.Storm.StormInlet.LengthUOM"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormInlet.Location"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormInlet.MainLine"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormInlet.MapNumber"
                    let Material = _vocab "Hansen.AssetManagement.Storm.StormInlet.Material"
                    let Organization = _vocab "Hansen.AssetManagement.Storm.StormInlet.Organization"
                    let OutletDepth = _vocab "Hansen.AssetManagement.Storm.StormInlet.OutletDepth"
                    let OutletDepthUOM = _vocab "Hansen.AssetManagement.Storm.StormInlet.OutletDepthUOM"
                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormInlet.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormInlet.Parcel"
                    let ServiceStatus = _vocab "Hansen.AssetManagement.Storm.StormInlet.ServiceStatus"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormInlet.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.SpecialInstructions"

                    let StreetSegment = _vocab "Hansen.AssetManagement.Storm.StormInlet.StreetSegment"
                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormInlet.SubArea"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormInlet.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormInlet.UnitType"

                    let UpstreamInvertElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.UpstreamInvertElevation"

                    let UpstreamInvertElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormInlet.UpstreamInvertElevationUOM"

                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormInlet.UsageArea"
                    let Width = _vocab "Hansen.AssetManagement.Storm.StormInlet.Width"
                    let WidthUOM = _vocab "Hansen.AssetManagement.Storm.StormInlet.WidthUOM"
                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormInlet.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormInlet.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormInlet.ZCoordinate"

                module StormLevee =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormLevee"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormLevee.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormLevee.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormLevee.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormLevee.AssetKey"
                    let BudgetNumber = _vocab "Hansen.AssetManagement.Storm.StormLevee.BudgetNumber"
                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormLevee.Complex"
                    let CrestCamber = _vocab "Hansen.AssetManagement.Storm.StormLevee.CrestCamber"
                    let District = _vocab "Hansen.AssetManagement.Storm.StormLevee.District"

                    let DownstreamFilterLayer =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.DownstreamFilterLayer"

                    let DownstreamSlope =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.DownstreamSlope"

                    let DownstreamSlopeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.DownstreamSlopeUOM"

                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormLevee.ExpiredBy"
                    let Foundation = _vocab "Hansen.AssetManagement.Storm.StormLevee.Foundation"

                    let FreeboardNormal =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.FreeboardNormal"

                    let FreeboardNormalUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.FreeboardNormalUOM"

                    let FreeboardWithWaveWall =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.FreeboardWithWaveWall"

                    let FreeboardWithWaveWallUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.FreeboardWithWaveWallUOM"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.GISStaticIdentifier"

                    let Height = _vocab "Hansen.AssetManagement.Storm.StormLevee.Height"
                    let HeightUOM = _vocab "Hansen.AssetManagement.Storm.StormLevee.HeightUOM"
                    let ID = _vocab "Hansen.AssetManagement.Storm.StormLevee.ID"
                    let InstalledDate = _vocab "Hansen.AssetManagement.Storm.StormLevee.InstalledDate"

                    let IsUpstreamFilterLayer =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.IsUpstreamFilterLayer"

                    let Length = _vocab "Hansen.AssetManagement.Storm.StormLevee.Length"
                    let LengthUOM = _vocab "Hansen.AssetManagement.Storm.StormLevee.LengthUOM"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormLevee.Location"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormLevee.MapNumber"
                    let Organization = _vocab "Hansen.AssetManagement.Storm.StormLevee.Organization"
                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormLevee.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormLevee.Parcel"

                    let SeismicResistance =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.SeismicResistance"

                    let ServiceStatus = _vocab "Hansen.AssetManagement.Storm.StormLevee.ServiceStatus"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormLevee.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.SpecialInstructions"

                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormLevee.SubArea"
                    let TopLevel = _vocab "Hansen.AssetManagement.Storm.StormLevee.TopLevel"
                    let TopLevelUOM = _vocab "Hansen.AssetManagement.Storm.StormLevee.TopLevelUOM"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormLevee.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormLevee.UnitType"
                    let UpstreamSlope = _vocab "Hansen.AssetManagement.Storm.StormLevee.UpstreamSlope"

                    let UpstreamSlopeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.UpstreamSlopeUOM"

                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormLevee.UsageArea"
                    let WaveWallHeight = _vocab "Hansen.AssetManagement.Storm.StormLevee.WaveWallHeight"

                    let WaveWallHeightUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.WaveWallHeightUOM"

                    let WaveWallThickness =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.WaveWallThickness"

                    let WaveWallThicknessUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLevee.WaveWallThicknessUOM"

                    let Width = _vocab "Hansen.AssetManagement.Storm.StormLevee.Width"
                    let WidthUOM = _vocab "Hansen.AssetManagement.Storm.StormLevee.WidthUOM"
                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormLevee.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormLevee.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormLevee.ZCoordinate"

                module StormLiftStation =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormLiftStation"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.AssetKey"

                    let BudgetNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.BudgetNumber"

                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.Complex"
                    let Description = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.Description"

                    let DischargePipeSize =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.DischargePipeSize"

                    let DischargePipeSizeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.DischargePipeSizeUOM"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.District"
                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.ID"

                    let InstalledDate =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.InstalledDate"

                    let Location = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.Location"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.MainLine"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.MapNumber"
                    let ModelNumber = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.ModelNumber"

                    let NumberOfPumps =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.NumberOfPumps"

                    let Organization =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.Organization"

                    let OverflowElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.OverflowElevation"

                    let OverflowElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.OverflowElevationUOM"

                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.Parcel"

                    let PumpingCapacity =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.PumpingCapacity"

                    let PumpingCapacityUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.PumpingCapacityUOM"

                    let SerialNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.SerialNumber"

                    let ServiceStatus =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.ServiceStatus"

                    let Site = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.SpecialInstructions"

                    let StreetSegment =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.StreetSegment"

                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.SubArea"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.UsageArea"

                    let WetWellElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.WetWellElevation"

                    let WetWellElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.WetWellElevationUOM"

                    let WetWellVolume =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.WetWellVolume"

                    let WetWellVolumeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormLiftStation.WetWellVolumeUOM"

                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormLiftStation.ZCoordinate"

                module StormMain =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormMain"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormMain.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormMain.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormMain.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormMain.AssetKey"
                    let BudgetNumber = _vocab "Hansen.AssetManagement.Storm.StormMain.BudgetNumber"
                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormMain.Complex"
                    let CriticalRating = _vocab "Hansen.AssetManagement.Storm.StormMain.CriticalRating"
                    let DesignFlow = _vocab "Hansen.AssetManagement.Storm.StormMain.DesignFlow"

                    let DirectionFromDownstream =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.DirectionFromDownstream"

                    let DirectionFromUpstream =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.DirectionFromUpstream"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormMain.District"

                    let DownstreamDepth =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.DownstreamDepth"

                    let DownstreamDepthUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.DownstreamDepthUOM"

                    let DownstreamElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.DownstreamElevation"

                    let DownstreamElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.DownstreamElevationUOM"

                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormMain.ExpiredBy"
                    let FrictionFactor = _vocab "Hansen.AssetManagement.Storm.StormMain.FrictionFactor"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.GISStaticIdentifier"

                    let GroundWaterLevel =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.GroundWaterLevel"

                    let GroundWaterLevelUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.GroundWaterLevelUOM"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormMain.ID"
                    let ID2 = _vocab "Hansen.AssetManagement.Storm.StormMain.ID2"
                    let InstalledDate = _vocab "Hansen.AssetManagement.Storm.StormMain.InstalledDate"
                    let JointLength = _vocab "Hansen.AssetManagement.Storm.StormMain.JointLength"
                    let JointLengthUOM = _vocab "Hansen.AssetManagement.Storm.StormMain.JointLengthUOM"
                    let JointType = _vocab "Hansen.AssetManagement.Storm.StormMain.JointType"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormMain.Location"
                    let Manufacturer = _vocab "Hansen.AssetManagement.Storm.StormMain.Manufacturer"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormMain.MapNumber"
                    let Organization = _vocab "Hansen.AssetManagement.Storm.StormMain.Organization"
                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormMain.Ownership"

                    let ParallelLineNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.ParallelLineNumber"

                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormMain.Parcel"
                    let PipeDiameter = _vocab "Hansen.AssetManagement.Storm.StormMain.PipeDiameter"

                    let PipeDiameterUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.PipeDiameterUOM"

                    let PipeHeight = _vocab "Hansen.AssetManagement.Storm.StormMain.PipeHeight"
                    let PipeHeightUOM = _vocab "Hansen.AssetManagement.Storm.StormMain.PipeHeightUOM"
                    let PipeLength = _vocab "Hansen.AssetManagement.Storm.StormMain.PipeLength"
                    let PipeLengthUOM = _vocab "Hansen.AssetManagement.Storm.StormMain.PipeLengthUOM"
                    let PipeMaterial = _vocab "Hansen.AssetManagement.Storm.StormMain.PipeMaterial"
                    let PipeShape = _vocab "Hansen.AssetManagement.Storm.StormMain.PipeShape"
                    let Segment = _vocab "Hansen.AssetManagement.Storm.StormMain.Segment"
                    let ServiceStatus = _vocab "Hansen.AssetManagement.Storm.StormMain.ServiceStatus"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormMain.Site"
                    let Slope = _vocab "Hansen.AssetManagement.Storm.StormMain.Slope"
                    let SlopeUOM = _vocab "Hansen.AssetManagement.Storm.StormMain.SlopeUOM"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.SpecialInstructions"

                    let StreetSegment = _vocab "Hansen.AssetManagement.Storm.StormMain.StreetSegment"
                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormMain.SubArea"
                    let SurfaceCover = _vocab "Hansen.AssetManagement.Storm.StormMain.SurfaceCover"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormMain.UnitDesc"
                    let UnitID2Asset = _vocab "Hansen.AssetManagement.Storm.StormMain.UnitID2Asset"
                    let UnitID2Type = _vocab "Hansen.AssetManagement.Storm.StormMain.UnitID2Type"
                    let UnitIDAsset = _vocab "Hansen.AssetManagement.Storm.StormMain.UnitIDAsset"
                    let UnitIDType = _vocab "Hansen.AssetManagement.Storm.StormMain.UnitIDType"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormMain.UnitType"
                    let UpstreamDepth = _vocab "Hansen.AssetManagement.Storm.StormMain.UpstreamDepth"

                    let UpstreamDepthUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.UpstreamDepthUOM"

                    let UpstreamElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.UpstreamElevation"

                    let UpstreamElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMain.UpstreamElevationUOM"

                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormMain.UsageArea"
                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormMain.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormMain.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormMain.ZCoordinate"

                module StormManhole =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormManhole"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormManhole.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormManhole.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormManhole.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormManhole.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormManhole.AssetKey"

                    let BarrelDiameter =
                        _vocab "Hansen.AssetManagement.Storm.StormManhole.BarrelDiameter"

                    let BarrelDiameterUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormManhole.BarrelDiameterUOM"

                    let BaseType = _vocab "Hansen.AssetManagement.Storm.StormManhole.BaseType"
                    let BenchType = _vocab "Hansen.AssetManagement.Storm.StormManhole.BenchType"
                    let BudgetNumber = _vocab "Hansen.AssetManagement.Storm.StormManhole.BudgetNumber"
                    let ChannelType = _vocab "Hansen.AssetManagement.Storm.StormManhole.ChannelType"
                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormManhole.Complex"
                    let ConeType = _vocab "Hansen.AssetManagement.Storm.StormManhole.ConeType"
                    let CoverDiameter = _vocab "Hansen.AssetManagement.Storm.StormManhole.CoverDiameter"

                    let CoverDiameterUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormManhole.CoverDiameterUOM"

                    let CoverType = _vocab "Hansen.AssetManagement.Storm.StormManhole.CoverType"
                    let Depth = _vocab "Hansen.AssetManagement.Storm.StormManhole.Depth"
                    let DepthUOM = _vocab "Hansen.AssetManagement.Storm.StormManhole.DepthUOM"

                    let DistanceToHydrant =
                        _vocab "Hansen.AssetManagement.Storm.StormManhole.DistanceToHydrant"

                    let DistanceToHydrantUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormManhole.DistanceToHydrantUOM"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormManhole.District"
                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormManhole.ExpiredBy"
                    let FrameType = _vocab "Hansen.AssetManagement.Storm.StormManhole.FrameType"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormManhole.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormManhole.ID"
                    let InstalledDate = _vocab "Hansen.AssetManagement.Storm.StormManhole.InstalledDate"
                    let Intersection = _vocab "Hansen.AssetManagement.Storm.StormManhole.Intersection"
                    let IsDropManhole = _vocab "Hansen.AssetManagement.Storm.StormManhole.IsDropManhole"
                    let IsMetered = _vocab "Hansen.AssetManagement.Storm.StormManhole.IsMetered"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormManhole.Location"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormManhole.MapNumber"
                    let Organization = _vocab "Hansen.AssetManagement.Storm.StormManhole.Organization"
                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormManhole.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormManhole.Parcel"
                    let RingsMaterial = _vocab "Hansen.AssetManagement.Storm.StormManhole.RingsMaterial"
                    let ServiceStatus = _vocab "Hansen.AssetManagement.Storm.StormManhole.ServiceStatus"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormManhole.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormManhole.SpecialInstructions"

                    let StepsMaterial = _vocab "Hansen.AssetManagement.Storm.StormManhole.StepsMaterial"
                    let StreetSegment = _vocab "Hansen.AssetManagement.Storm.StormManhole.StreetSegment"
                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormManhole.SubArea"
                    let SurfaceCover = _vocab "Hansen.AssetManagement.Storm.StormManhole.SurfaceCover"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormManhole.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormManhole.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormManhole.UsageArea"
                    let WallMaterial = _vocab "Hansen.AssetManagement.Storm.StormManhole.WallMaterial"
                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormManhole.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormManhole.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormManhole.ZCoordinate"

                module StormMeter =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormMeter"
                    let AccountNumber = _vocab "Hansen.AssetManagement.Storm.StormMeter.AccountNumber"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormMeter.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormMeter.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormMeter.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormMeter.AssetKey"

                    let AverageMonthlyUsage =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.AverageMonthlyUsage"

                    let AverageMonthlyUsageUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.AverageMonthlyUsageUOM"

                    let BudgetNumber = _vocab "Hansen.AssetManagement.Storm.StormMeter.BudgetNumber"
                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormMeter.Complex"
                    let District = _vocab "Hansen.AssetManagement.Storm.StormMeter.District"
                    let Elevation = _vocab "Hansen.AssetManagement.Storm.StormMeter.Elevation"
                    let ElevationUOM = _vocab "Hansen.AssetManagement.Storm.StormMeter.ElevationUOM"
                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormMeter.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.GISStaticIdentifier"

                    let HasBypass = _vocab "Hansen.AssetManagement.Storm.StormMeter.HasBypass"
                    let HighRegister = _vocab "Hansen.AssetManagement.Storm.StormMeter.HighRegister"
                    let ID = _vocab "Hansen.AssetManagement.Storm.StormMeter.ID"
                    let InstalledDate = _vocab "Hansen.AssetManagement.Storm.StormMeter.InstalledDate"
                    let Intersection = _vocab "Hansen.AssetManagement.Storm.StormMeter.Intersection"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormMeter.Location"
                    let LowRegister = _vocab "Hansen.AssetManagement.Storm.StormMeter.LowRegister"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormMeter.MainLine"

                    let ManufacturedDate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.ManufacturedDate"

                    let Manufacturer = _vocab "Hansen.AssetManagement.Storm.StormMeter.Manufacturer"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormMeter.MapNumber"
                    let MeterComponent = _vocab "Hansen.AssetManagement.Storm.StormMeter.MeterComponent"
                    let ModelNumber = _vocab "Hansen.AssetManagement.Storm.StormMeter.ModelNumber"
                    let Organization = _vocab "Hansen.AssetManagement.Storm.StormMeter.Organization"

                    let OverflowElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.OverflowElevation"

                    let OverflowElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.OverflowElevationUOM"

                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormMeter.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormMeter.Parcel"
                    let PipeGrade = _vocab "Hansen.AssetManagement.Storm.StormMeter.PipeGrade"
                    let PipeMaterial = _vocab "Hansen.AssetManagement.Storm.StormMeter.PipeMaterial"
                    let PipeSize = _vocab "Hansen.AssetManagement.Storm.StormMeter.PipeSize"
                    let PipeSizeUOM = _vocab "Hansen.AssetManagement.Storm.StormMeter.PipeSizeUOM"
                    let Purchased = _vocab "Hansen.AssetManagement.Storm.StormMeter.Purchased"
                    let SerialNumber = _vocab "Hansen.AssetManagement.Storm.StormMeter.SerialNumber"
                    let ServiceLine = _vocab "Hansen.AssetManagement.Storm.StormMeter.ServiceLine"
                    let ServiceStatus = _vocab "Hansen.AssetManagement.Storm.StormMeter.ServiceStatus"
                    let ServiceType = _vocab "Hansen.AssetManagement.Storm.StormMeter.ServiceType"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormMeter.Site"
                    let Size = _vocab "Hansen.AssetManagement.Storm.StormMeter.Size"
                    let SizeUOM = _vocab "Hansen.AssetManagement.Storm.StormMeter.SizeUOM"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.SpecialInstructions"

                    let StreetSegment = _vocab "Hansen.AssetManagement.Storm.StormMeter.StreetSegment"
                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormMeter.SubArea"
                    let TotalUsage = _vocab "Hansen.AssetManagement.Storm.StormMeter.TotalUsage"
                    let TotalUsageUOM = _vocab "Hansen.AssetManagement.Storm.StormMeter.TotalUsageUOM"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormMeter.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormMeter.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormMeter.UsageArea"
                    let UsageDate = _vocab "Hansen.AssetManagement.Storm.StormMeter.UsageDate"

                    let WetWellOverflow =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.WetWellOverflow"

                    let WetWellOverflowUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMeter.WetWellOverflowUOM"

                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormMeter.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormMeter.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormMeter.ZCoordinate"

                module StormMeterComponent =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.AssetKey"

                    let BudgetNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.BudgetNumber"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.District"
                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.ID"

                    let InstalledDate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.InstalledDate"

                    let Location = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.Location"

                    let ManufacturedDate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.ManufacturedDate"

                    let Manufacturer =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.Manufacturer"

                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.MapNumber"

                    let MasterComponent =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.MasterComponent"

                    let ModelNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.ModelNumber"

                    let Organization =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.Organization"

                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.Parcel"
                    let Purchased = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.Purchased"

                    let SerialNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.SerialNumber"

                    let ServiceStatus =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.ServiceStatus"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.SpecialInstructions"

                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.SubArea"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.UnitType"

                    let XCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.XCoordinate"

                    let YCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.YCoordinate"

                    let ZCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterComponent.ZCoordinate"

                module StormMeterRegister =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.AssetKey"

                    let BudgetNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.BudgetNumber"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.District"
                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.ID"

                    let InstalledDate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.InstalledDate"

                    let Location = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.Location"

                    let ManufacturedDate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.ManufacturedDate"

                    let Manufacturer =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.Manufacturer"

                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.MapNumber"

                    let ModelNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.ModelNumber"

                    let NumberOfDials =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.NumberOfDials"

                    let Organization =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.Organization"

                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.Parcel"
                    let Purchased = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.Purchased"

                    let SerialNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.SerialNumber"

                    let ServiceStatus =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.ServiceStatus"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.SpecialInstructions"

                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.SubArea"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.UnitType"

                    let XCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.XCoordinate"

                    let YCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.YCoordinate"

                    let ZCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormMeterRegister.ZCoordinate"

                module StormMiscellaneous =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.AssetKey"

                    let AverageMonthlyUsage =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.AverageMonthlyUsage"

                    let AverageMonthlyUsageUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.AverageMonthlyUsageUOM"

                    let BudgetNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.BudgetNumber"

                    let Color = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Color"
                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Complex"
                    let Condition = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Condition"
                    let Depth = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Depth"
                    let DepthUOM = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.DepthUOM"

                    let Description =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Description"

                    let Diameter = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Diameter"

                    let DiameterUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.DiameterUOM"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.District"
                    let Elevation = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Elevation"

                    let ElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.ElevationUOM"

                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.GISStaticIdentifier"

                    let Height = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Height"
                    let HeightUOM = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.HeightUOM"
                    let ID = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.ID"

                    let InstalledDate =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.InstalledDate"

                    let Intersection =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Intersection"

                    let Length = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Length"
                    let LengthUOM = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.LengthUOM"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Location"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.MainLine"

                    let Manufacturer =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Manufacturer"

                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.MapNumber"
                    let Material = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Material"

                    let ModelNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.ModelNumber"

                    let Organization =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Organization"

                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Parcel"

                    let SerialNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.SerialNumber"

                    let ServiceLine =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.ServiceLine"

                    let ServiceStatus =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.ServiceStatus"

                    let Site = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.SpecialInstructions"

                    let StreetSegment =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.StreetSegment"

                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.SubArea"

                    let SurfaceCover =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.SurfaceCover"

                    let TotalUsage = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.TotalUsage"

                    let TotalUsageUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.TotalUsageUOM"

                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.UsageArea"
                    let UsageDate = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.UsageDate"
                    let Weight = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Weight"
                    let WeightUOM = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.WeightUOM"
                    let Width = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.Width"
                    let WidthUOM = _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.WidthUOM"

                    let XCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.XCoordinate"

                    let YCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.YCoordinate"

                    let ZCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormMiscellaneous.ZCoordinate"

                module StormNode =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormNode"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormNode.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormNode.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormNode.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormNode.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormNode.AssetKey"
                    let BudgetNumber = _vocab "Hansen.AssetManagement.Storm.StormNode.BudgetNumber"
                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormNode.Complex"

                    let DistanceFromEndpoint =
                        _vocab "Hansen.AssetManagement.Storm.StormNode.DistanceFromEndpoint"

                    let DistanceFromEndpointUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormNode.DistanceFromEndpointUOM"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormNode.District"
                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormNode.ExpiredBy"
                    let FromEndpoint = _vocab "Hansen.AssetManagement.Storm.StormNode.FromEndpoint"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormNode.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormNode.ID"
                    let InstalledDate = _vocab "Hansen.AssetManagement.Storm.StormNode.InstalledDate"
                    let Intersection = _vocab "Hansen.AssetManagement.Storm.StormNode.Intersection"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormNode.Location"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormNode.MainLine"
                    let Manufacturer = _vocab "Hansen.AssetManagement.Storm.StormNode.Manufacturer"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormNode.MapNumber"
                    let ModelNumber = _vocab "Hansen.AssetManagement.Storm.StormNode.ModelNumber"
                    let Organization = _vocab "Hansen.AssetManagement.Storm.StormNode.Organization"
                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormNode.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormNode.Parcel"
                    let SerialNumber = _vocab "Hansen.AssetManagement.Storm.StormNode.SerialNumber"
                    let ServiceStatus = _vocab "Hansen.AssetManagement.Storm.StormNode.ServiceStatus"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormNode.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormNode.SpecialInstructions"

                    let StreetSegment = _vocab "Hansen.AssetManagement.Storm.StormNode.StreetSegment"
                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormNode.SubArea"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormNode.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormNode.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormNode.UsageArea"
                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormNode.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormNode.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormNode.ZCoordinate"

                module StormPump =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormPump"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormPump.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormPump.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormPump.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormPump.AssetKey"

                    let AverageMonthlyUsage =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.AverageMonthlyUsage"

                    let AverageMonthlyUsageUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.AverageMonthlyUsageUOM"

                    let BudgetNumber = _vocab "Hansen.AssetManagement.Storm.StormPump.BudgetNumber"
                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormPump.Complex"

                    let DischargePipeSize =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.DischargePipeSize"

                    let DischargePipeSizeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.DischargePipeSizeUOM"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormPump.District"
                    let ExpectedLife = _vocab "Hansen.AssetManagement.Storm.StormPump.ExpectedLife"

                    let ExpectedLifeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.ExpectedLifeUOM"

                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormPump.ExpiredBy"
                    let Flow = _vocab "Hansen.AssetManagement.Storm.StormPump.Flow"
                    let FlowUOM = _vocab "Hansen.AssetManagement.Storm.StormPump.FlowUOM"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormPump.ID"
                    let InstalledDate = _vocab "Hansen.AssetManagement.Storm.StormPump.InstalledDate"
                    let Intersection = _vocab "Hansen.AssetManagement.Storm.StormPump.Intersection"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormPump.Location"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormPump.MainLine"

                    let ManufacturedDate =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.ManufacturedDate"

                    let Manufacturer = _vocab "Hansen.AssetManagement.Storm.StormPump.Manufacturer"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormPump.MapNumber"

                    let MeanTimeBetweenFailures =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.MeanTimeBetweenFailures"

                    let MeanTimeBetweenFailuresUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.MeanTimeBetweenFailuresUOM"

                    let ModelNumber = _vocab "Hansen.AssetManagement.Storm.StormPump.ModelNumber"

                    let MotorSerialNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.MotorSerialNumber"

                    let Organization = _vocab "Hansen.AssetManagement.Storm.StormPump.Organization"
                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormPump.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormPump.Parcel"
                    let Purchased = _vocab "Hansen.AssetManagement.Storm.StormPump.Purchased"

                    let RevolutionsPerMinute =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.RevolutionsPerMinute"

                    let SerialNumber = _vocab "Hansen.AssetManagement.Storm.StormPump.SerialNumber"
                    let ServiceStatus = _vocab "Hansen.AssetManagement.Storm.StormPump.ServiceStatus"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormPump.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.SpecialInstructions"

                    let StreetSegment = _vocab "Hansen.AssetManagement.Storm.StormPump.StreetSegment"
                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormPump.SubArea"

                    let TotalDynamicHead =
                        _vocab "Hansen.AssetManagement.Storm.StormPump.TotalDynamicHead"

                    let TotalUsage = _vocab "Hansen.AssetManagement.Storm.StormPump.TotalUsage"
                    let TotalUsageUOM = _vocab "Hansen.AssetManagement.Storm.StormPump.TotalUsageUOM"
                    let Trim = _vocab "Hansen.AssetManagement.Storm.StormPump.Trim"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormPump.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormPump.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormPump.UsageArea"
                    let UsageDate = _vocab "Hansen.AssetManagement.Storm.StormPump.UsageDate"
                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormPump.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormPump.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormPump.ZCoordinate"

                module StormServiceLine =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormServiceLine"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.AssetKey"

                    let BudgetNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.BudgetNumber"

                    let Building = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Building"

                    let CleanoutLocation =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.CleanoutLocation"

                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Complex"

                    let DepthAtPropertyLine =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.DepthAtPropertyLine"

                    let DepthAtPropertyLineUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.DepthAtPropertyLineUOM"

                    let Diameter = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Diameter"
                    let DiameterUOM = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.DiameterUOM"
                    let District = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.District"

                    let DunAndBradstreetNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.DunAndBradstreetNumber"

                    let EnvironmentalProtectAgencyID =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.EnvironmentalProtectAgencyID"

                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.ID"

                    let InstalledDate =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.InstalledDate"

                    let Length = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Length"
                    let LengthUOM = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.LengthUOM"
                    let Location = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Location"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.MainLine"

                    let Manufacturer =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Manufacturer"

                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.MapNumber"

                    let MunicipalityCondition =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.MunicipalityCondition"

                    let NPDESID = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.NPDESID"

                    let NumberOfTaps =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.NumberOfTaps"

                    let Organization =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Organization"

                    let OwnerCondition =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.OwnerCondition"

                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Parcel"

                    let PipeMaterial =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.PipeMaterial"

                    let SIC = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.SIC"

                    let ServiceStatus =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.ServiceStatus"

                    let ServiceType = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.ServiceType"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.SpecialInstructions"

                    let StreetSegment =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.StreetSegment"

                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.SubArea"

                    let SurfaceCover =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.SurfaceCover"

                    let TapAddress = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.TapAddress"
                    let TapDistance = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.TapDistance"

                    let TapDistanceUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormServiceLine.TapDistanceUOM"

                    let TapFrom = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.TapFrom"
                    let TapLocation = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.TapLocation"
                    let UICID = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.UICID"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.UsageArea"
                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormServiceLine.ZCoordinate"

                module StormStorageBasin =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.AssetKey"

                    let BudgetNumber =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.BudgetNumber"

                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.Complex"

                    let DeadStorageCapacity =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.DeadStorageCapacity"

                    let DeadStorageCapacityUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.DeadStorageCapacityUOM"

                    let Description =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.Description"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.District"
                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.ExpiredBy"

                    let FullSupplyLevelGauge =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.FullSupplyLevelGauge"

                    let FullSupplyLevelGaugeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.FullSupplyLevelGaugeUOM"

                    let FullSupplyLevelRL =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.FullSupplyLevelRL"

                    let FullSupplyLevelRLUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.FullSupplyLevelRLUOM"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.ID"

                    let InstalledDate =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.InstalledDate"

                    let LiveStorageCapacity =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.LiveStorageCapacity"

                    let LiveStorageCapacityUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.LiveStorageCapacityUOM"

                    let Location = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.Location"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.MainLine"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.MapNumber"

                    let MinOperatingLevelGaugeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.MinOperatingLevelGaugeUOM"

                    let MinOperatingLevelRLUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.MinOperatingLevelRLUOM"

                    let MinimumOperatingLevelGauge =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.MinimumOperatingLevelGauge"

                    let MinimumOperatingLevelRL =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.MinimumOperatingLevelRL"

                    let Organization =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.Organization"

                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.Parcel"

                    let ServiceStatus =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.ServiceStatus"

                    let Site = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.Site"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.SpecialInstructions"

                    let StreetSegment =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.StreetSegment"

                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.SubArea"

                    let SurfaceArea =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.SurfaceArea"

                    let SurfaceAreaUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.SurfaceAreaUOM"

                    let TotalCapacity =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.TotalCapacity"

                    let TotalCapacityUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.TotalCapacityUOM"

                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.UsageArea"

                    let XCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.XCoordinate"

                    let YCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.YCoordinate"

                    let ZCoordinate =
                        _vocab "Hansen.AssetManagement.Storm.StormStorageBasin.ZCoordinate"

                module StormValve =
                    let table = _vocab "Hansen.AssetManagement.Storm.StormValve"
                    let Address = _vocab "Hansen.AssetManagement.Storm.StormValve.Address"

                    let AddressQualifier =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.AddressQualifier"

                    let Area = _vocab "Hansen.AssetManagement.Storm.StormValve.Area"
                    let AsBuilt = _vocab "Hansen.AssetManagement.Storm.StormValve.AsBuilt"
                    let AssetKey = _vocab "Hansen.AssetManagement.Storm.StormValve.AssetKey"
                    let BudgetNumber = _vocab "Hansen.AssetManagement.Storm.StormValve.BudgetNumber"
                    let Complex = _vocab "Hansen.AssetManagement.Storm.StormValve.Complex"

                    let DirectionToOpen =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.DirectionToOpen"

                    let District = _vocab "Hansen.AssetManagement.Storm.StormValve.District"
                    let ExpectedLife = _vocab "Hansen.AssetManagement.Storm.StormValve.ExpectedLife"

                    let ExpectedLifeUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.ExpectedLifeUOM"

                    let ExpiredBy = _vocab "Hansen.AssetManagement.Storm.StormValve.ExpiredBy"

                    let GISStaticIdentifier =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.GISStaticIdentifier"

                    let ID = _vocab "Hansen.AssetManagement.Storm.StormValve.ID"
                    let InstalledDate = _vocab "Hansen.AssetManagement.Storm.StormValve.InstalledDate"
                    let Intersection = _vocab "Hansen.AssetManagement.Storm.StormValve.Intersection"

                    let InvertElevation =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.InvertElevation"

                    let InvertElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.InvertElevationUOM"

                    let Location = _vocab "Hansen.AssetManagement.Storm.StormValve.Location"
                    let MainLine = _vocab "Hansen.AssetManagement.Storm.StormValve.MainLine"

                    let ManufacturedDate =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.ManufacturedDate"

                    let Manufacturer = _vocab "Hansen.AssetManagement.Storm.StormValve.Manufacturer"
                    let MapNumber = _vocab "Hansen.AssetManagement.Storm.StormValve.MapNumber"

                    let MeanTimeBetweenFailures =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.MeanTimeBetweenFailures"

                    let MeanTimeBetweenFailuresUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.MeanTimeBetweenFailuresUOM"

                    let ModelNumber = _vocab "Hansen.AssetManagement.Storm.StormValve.ModelNumber"

                    let NumberOfTurnsToOpen =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.NumberOfTurnsToOpen"

                    let Obstruction = _vocab "Hansen.AssetManagement.Storm.StormValve.Obstruction"
                    let OperatorDepth = _vocab "Hansen.AssetManagement.Storm.StormValve.OperatorDepth"

                    let OperatorDepthUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.OperatorDepthUOM"

                    let Organization = _vocab "Hansen.AssetManagement.Storm.StormValve.Organization"
                    let Ownership = _vocab "Hansen.AssetManagement.Storm.StormValve.Ownership"
                    let Parcel = _vocab "Hansen.AssetManagement.Storm.StormValve.Parcel"
                    let Purchased = _vocab "Hansen.AssetManagement.Storm.StormValve.Purchased"
                    let RimElevation = _vocab "Hansen.AssetManagement.Storm.StormValve.RimElevation"

                    let RimElevationUOM =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.RimElevationUOM"

                    let SerialNumber = _vocab "Hansen.AssetManagement.Storm.StormValve.SerialNumber"
                    let ServiceLine = _vocab "Hansen.AssetManagement.Storm.StormValve.ServiceLine"
                    let ServiceStatus = _vocab "Hansen.AssetManagement.Storm.StormValve.ServiceStatus"
                    let Site = _vocab "Hansen.AssetManagement.Storm.StormValve.Site"
                    let Size = _vocab "Hansen.AssetManagement.Storm.StormValve.Size"
                    let SizeUOM = _vocab "Hansen.AssetManagement.Storm.StormValve.SizeUOM"

                    let SpecialInstructions =
                        _vocab "Hansen.AssetManagement.Storm.StormValve.SpecialInstructions"

                    let StreetSegment = _vocab "Hansen.AssetManagement.Storm.StormValve.StreetSegment"
                    let SubArea = _vocab "Hansen.AssetManagement.Storm.StormValve.SubArea"
                    let TotalUsage = _vocab "Hansen.AssetManagement.Storm.StormValve.TotalUsage"
                    let TotalUsageUOM = _vocab "Hansen.AssetManagement.Storm.StormValve.TotalUsageUOM"
                    let UnitDesc = _vocab "Hansen.AssetManagement.Storm.StormValve.UnitDesc"
                    let UnitType = _vocab "Hansen.AssetManagement.Storm.StormValve.UnitType"
                    let UsageArea = _vocab "Hansen.AssetManagement.Storm.StormValve.UsageArea"
                    let ValveStatus = _vocab "Hansen.AssetManagement.Storm.StormValve.ValveStatus"
                    let XCoordinate = _vocab "Hansen.AssetManagement.Storm.StormValve.XCoordinate"
                    let YCoordinate = _vocab "Hansen.AssetManagement.Storm.StormValve.YCoordinate"
                    let ZCoordinate = _vocab "Hansen.AssetManagement.Storm.StormValve.ZCoordinate"

module leonad =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/leonad/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let collierb = _vocab "collierb"

    module _literal =
        let LEONAD (user_principal: string) (transaction: LightningTransaction) =
            RDF_Literal.simple $"""LEONAD\{user_principal}""" transaction

module lcg =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/lcg/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let _graph = _vocab ""
    let Stormwater_Inventory = _vocab "Stormwater_Inventory"




module oit =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/oit/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let _graph = _vocab ""
    let lexicon = _vocab "lexicon"
    let H8Import_Tool = _vocab "H8Import_Tool"
    let Geodatabase = _vocab "Geodatabase"
    let WOEDMS_Concept_Scheme = _vocab "WOEDMS_Concept_Scheme"
    let GIS_Concept_Scheme = _vocab "GIS_Concept_Scheme"
    let County_Application = _vocab "County_Application"
    let Esri_ArcGIS_Pro = _vocab "Esri_ArcGIS_Pro"
    let Infor_Operations_and_Regulations = _vocab "Infor_Operations_and_Regulations"
    let Infor_Public_Sector_Suite = _vocab "Infor_Public_Sector_Suite"
    let database = _vocab "database"
    let InforProdSql = _vocab "InforProdSql"
    let InforTestSql = _vocab "InforTestSql"

module om =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"https://open-metadata.org/schema/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

module woedms =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/woedms/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let created_by = _vocab "created_by"
    let from_layer = _vocab "from_layer"
    let from_field = _vocab "from_field"

    let to_table = _vocab "to_table"
    let to_column = _vocab "to_column"
    let map = _vocab "map"
    let Logical_Mapping = _vocab "Logical_Mapping"
    let Conceptual_Mapping = _vocab "Conceptual_Mapping"
    let map_column = _vocab "map_column"
    let values_depend_on_column = _vocab "values_depend_on_column"
    let dependent_column = _vocab "dependent_column"
    let Primary_Key_Column = _vocab "Primary_Key_Column"
    let primary_key_column = _vocab "primary_key_column"

    let BackflowPreventer_Asset = _vocab "BackflowPreventer_Asset"
    let Channel_Asset = _vocab "Channel_Asset"
    let ChannelDrainageConnection_Asset = _vocab "ChannelDrainageConnection_Asset"
    let Inlet_Asset = _vocab "Inlet_Asset"
    let Levee_Asset = _vocab "Levee_Asset"
    let LiftStation_Asset = _vocab "LiftStation_Asset"
    let Main_Asset = _vocab "Main_Asset"
    let Manhole_Asset = _vocab "Manhole_Asset"
    let Meter_Asset = _vocab "Meter_Asset"
    let MeterComponent_Asset = _vocab "MeterComponent_Asset"
    let MeterRegister_Asset = _vocab "MeterRegister_Asset"
    let Miscellaneous_Asset = _vocab "Miscellaneous_Asset"
    let Node_Asset = _vocab "Node_Asset"
    let Pump_Asset = _vocab "Pump_Asset"
    let ServiceLine_Asset = _vocab "ServiceLine_Asset"
    let StorageBasin_Asset = _vocab "StorageBasin_Asset"
    let Valve_Asset = _vocab "Valve_Asset"

module LCG_Stormwater_Inventory =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/LCG_Stormwater_Inventory/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let workspace = _vocab "workspace"

module swin =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Workplace.ontology_base}/swin/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let _Feature (local_name_string: string) = _vocab $"{local_name_string}_Feature"

    let _Feature_Class (local_name_string: string) =
        _vocab $"{local_name_string}_Feature_Class"

    let _Feature_Layer (local_name_string: string) =
        _vocab $"{local_name_string}_Feature_Layer"

    let _feature_attribute (layer_name: string) (ATTRIBUTE: string) (transaction: LightningTransaction) =
        _prefix $"{layer_name}.{ATTRIBUTE}" transaction

    let maintainer = _vocab "maintainer"
    let material = _vocab "material"
    let pond_type = _vocab "pond_type"
    let surface_type = _vocab "surface_type"
    let pipe_shape = _vocab "pipe_shape"
    let origin = _vocab "origin"
    let Point_Origin = _vocab "Point-Origin"
    let Linear_Origin = _vocab "Linear-Origin"

    let LCG_Stormwater_Inventory = _vocab "LCG_Stormwater_Inventory"
    let code = _vocab "code"

    module Conduit =
        let ACCEPT_DATE = _vocab "Conduit.ACCEPT_DATE"
        let ACCURACYCODE = _vocab "Conduit.ACCURACYCODE"
        let ATTRIBUTECOMPLETE = _vocab "Conduit.ATTRIBUTECOMPLETE"
        let DATECREATED = _vocab "Conduit.DATECREATED"
        let DATEMODIFIED = _vocab "Conduit.DATEMODIFIED"
        let DIAMETER = _vocab "Conduit.DIAMETER"
        let DIGITALPICTUREID = _vocab "Conduit.DIGITALPICTUREID"
        let DOWNSTREAMDEPTH = _vocab "Conduit.DOWNSTREAMDEPTH"
        let DOWNSTREAMELEVATION = _vocab "Conduit.DOWNSTREAMELEVATION"
        let DRAWINGID = _vocab "Conduit.DRAWINGID"
        let ENABLED = _vocab "Conduit.ENABLED"
        let FACILITYID = _vocab "Conduit.FACILITYID"
        let FIELD_COMMENTS_ = _vocab "Conduit.FIELD_COMMENTS_"
        let FIELDCOMPLETE = _vocab "Conduit.FIELDCOMPLETE"
        let GLOBALID = _vocab "Conduit.GLOBALID"
        let HEIGHT = _vocab "Conduit.HEIGHT"
        let IMAGERYYEAR = _vocab "Conduit.IMAGERYYEAR"
        let INVENTORYDATE = _vocab "Conduit.INVENTORYDATE"
        let LEGACYID = _vocab "Conduit.LEGACYID"
        let LFEET = _vocab "Conduit.LFEET"
        let LIFECYCLE = _vocab "Conduit.LIFECYCLE"
        let MAINTBY = _vocab "Conduit.MAINTBY"
        let MATERIAL = _vocab "Conduit.MATERIAL"
        let NEEDSATTENTION = _vocab "Conduit.NEEDSATTENTION"
        let NOTES = _vocab "Conduit.NOTES"
        let OBJECTID = _vocab "Conduit.OBJECTID"
        let ORIGINALSOURCE = _vocab "Conduit.ORIGINALSOURCE"
        let OUTFALLID = _vocab "Conduit.OUTFALLID"
        let OWNER = _vocab "Conduit.OWNER"
        let PARENTID = _vocab "Conduit.PARENTID"
        let PERCT_GRD = _vocab "Conduit.PERCT_GRD"
        let PIPESHAPE = _vocab "Conduit.PIPESHAPE"
        let SHAPE = _vocab "Conduit.SHAPE"
        let SHAPE_Length = _vocab "Conduit.SHAPE_Length"
        let SOURCE = _vocab "Conduit.SOURCE"
        let SUBTYPEFIELD = _vocab "Conduit.SUBTYPEFIELD"
        let UNITID = _vocab "Conduit.UNITID"
        let UPDATESOURCE = _vocab "Conduit.UPDATESOURCE"
        let UPSTREAMDEPTH = _vocab "Conduit.UPSTREAMDEPTH"
        let UPSTREAMELEVATION = _vocab "Conduit.UPSTREAMELEVATION"
        let WHOCREATED = _vocab "Conduit.WHOCREATED"
        let WHOMODIFIED = _vocab "Conduit.WHOMODIFIED"
        let WIDTH = _vocab "Conduit.WIDTH"

    module Culvert_Cross_Drain =
        let ACCEPT_DATE = _vocab "Culvert_Cross_Drain.ACCEPT_DATE"
        let ACCURACYCODE = _vocab "Culvert_Cross_Drain.ACCURACYCODE"
        let ATTRIBUTECOMPLETE = _vocab "Culvert_Cross_Drain.ATTRIBUTECOMPLETE"
        let DATECREATED = _vocab "Culvert_Cross_Drain.DATECREATED"
        let DATEMODIFIED = _vocab "Culvert_Cross_Drain.DATEMODIFIED"
        let DIAMETER = _vocab "Culvert_Cross_Drain.DIAMETER"
        let DIGITALPICTUREID = _vocab "Culvert_Cross_Drain.DIGITALPICTUREID"
        let DOWNSTREAM_DEPTH = _vocab "Culvert_Cross_Drain.DOWNSTREAM_DEPTH"
        let DOWNSTREAM_ELEV = _vocab "Culvert_Cross_Drain.DOWNSTREAM_ELEV"
        let DRAWINGID = _vocab "Culvert_Cross_Drain.DRAWINGID"
        let ENABLED = _vocab "Culvert_Cross_Drain.ENABLED"
        let FACILITYID = _vocab "Culvert_Cross_Drain.FACILITYID"
        let FIELD_COMMENTS_ = _vocab "Culvert_Cross_Drain.FIELD_COMMENTS_"
        let FIELDCOMPLETE = _vocab "Culvert_Cross_Drain.FIELDCOMPLETE"
        let GLOBALID = _vocab "Culvert_Cross_Drain.GLOBALID"
        let HEIGHT = _vocab "Culvert_Cross_Drain.HEIGHT"
        let IMAGERYYEAR = _vocab "Culvert_Cross_Drain.IMAGERYYEAR"
        let INVENTORYDATE = _vocab "Culvert_Cross_Drain.INVENTORYDATE"
        let LEGACYID = _vocab "Culvert_Cross_Drain.LEGACYID"
        let LFEET = _vocab "Culvert_Cross_Drain.LFEET"
        let LIFECYCLE = _vocab "Culvert_Cross_Drain.LIFECYCLE"
        let MAINTBY = _vocab "Culvert_Cross_Drain.MAINTBY"
        let MATERIAL = _vocab "Culvert_Cross_Drain.MATERIAL"
        let NEEDSATTENTION = _vocab "Culvert_Cross_Drain.NEEDSATTENTION"
        let NOTES = _vocab "Culvert_Cross_Drain.NOTES"
        let NUM_BARRELS = _vocab "Culvert_Cross_Drain.NUM_BARRELS"
        let OBJECTID = _vocab "Culvert_Cross_Drain.OBJECTID"
        let ORIGINALSOURCE = _vocab "Culvert_Cross_Drain.ORIGINALSOURCE"
        let OUTFALLID = _vocab "Culvert_Cross_Drain.OUTFALLID"
        let OWNER = _vocab "Culvert_Cross_Drain.OWNER"
        let PARENTID = _vocab "Culvert_Cross_Drain.PARENTID"
        let PERCT_GRD = _vocab "Culvert_Cross_Drain.PERCT_GRD"
        let PIPESHAPE = _vocab "Culvert_Cross_Drain.PIPESHAPE"
        let SHAPE = _vocab "Culvert_Cross_Drain.SHAPE"
        let SHAPE_Length = _vocab "Culvert_Cross_Drain.SHAPE_Length"
        let SOURCE = _vocab "Culvert_Cross_Drain.SOURCE"
        let SUBTYPEFIELD = _vocab "Culvert_Cross_Drain.SUBTYPEFIELD"
        let UNITID = _vocab "Culvert_Cross_Drain.UNITID"
        let UPDATESOURCE = _vocab "Culvert_Cross_Drain.UPDATESOURCE"
        let UPSTREAM_DEPTH = _vocab "Culvert_Cross_Drain.UPSTREAM_DEPTH"
        let UPSTREAM_ELEV = _vocab "Culvert_Cross_Drain.UPSTREAM_ELEV"
        let WHOCREATED = _vocab "Culvert_Cross_Drain.WHOCREATED"
        let WHOMODIFIED = _vocab "Culvert_Cross_Drain.WHOMODIFIED"
        let WIDTH = _vocab "Cuvert_Cross_Drain.WIDTH"

    module Debris_Trap =
        let ACCURACYCODE = _vocab "Debris_Trap.ACCURACYCODE"
        let ATTACHEDTOID = _vocab "Debris_Trap.ATTACHEDTOID"
        let ATTRIBUTECOMPLETE = _vocab "Debris_Trap.ATTRIBUTECOMPLETE"
        let DATECREATED = _vocab "Debris_Trap.DATECREATED"
        let DATEMODIFIED = _vocab "Debris_Trap.DATEMODIFIED"
        let DIGITALPICTUREID = _vocab "Debris_Trap.DIGITALPICTUREID"
        let EASTING = _vocab "Debris_Trap.EASTING"
        let FACILITYID = _vocab "Debris_Trap.FACILITYID"
        let FIELDCOMMENTS = _vocab "Debris_Trap.FIELDCOMMENTS"
        let FIELDCOMPLETE = _vocab "Debris_Trap.FIELDCOMPLETE"
        let GLOBALID = _vocab "Debris_Trap.GLOBALID"
        let HYPERLINK_AR = _vocab "Debris_Trap.HYPERLINK_AR"
        let IMAGERYYEAR = _vocab "Debris_Trap.IMAGERYYEAR"
        let INVENTORYDATE = _vocab "Debris_Trap.INVENTORYDATE"
        let INVENTORYTYPE = _vocab "Debris_Trap.INVENTORYTYPE"
        let LEGACYID = _vocab "Debris_Trap.LEGACYID"
        let LIFECYCLE = _vocab "Debris_Trap.LIFECYCLE"
        let LOCATION = _vocab "Debris_Trap.LOCATION"
        let MAINTBY = _vocab "Debris_Trap.MAINTBY"
        let NEEDSATTENTION = _vocab "Debris_Trap.NEEDSATTENTION"
        let NORTHING = _vocab "Debris_Trap.NORTHING"
        let NOTES = _vocab "Debris_Trap.NOTES"
        let OBJECTID = _vocab "Debris_Trap.OBJECTID"
        let ORIGINALSOURCE = _vocab "Debris_Trap.ORIGINALSOURCE"
        let OUTFALLID = _vocab "Debris_Trap.OUTFALLID"
        let OWNER = _vocab "Debris_Trap.OWNER"
        let PARENTID = _vocab "Debris_Trap.PARENTID"
        let PRFRESOLUTION = _vocab "Debris_Trap.PRFRESOLUTION"
        let SHAPE = _vocab "Debris_Trap.SHAPE"
        let SOURCE = _vocab "Debris_Trap.SOURCE"
        let UNITID = _vocab "Debris_Trap.UNITID"
        let UPDATESOURCE = _vocab "Debris_Trap.UPDATESOURCE"
        let WHOCREATED = _vocab "Debris_Trap.WHOCREATED"
        let WHOMODIFIED = _vocab "Debris_Trap.WHOMODIFIED"
        let Z29 = _vocab "Debris_Trap.Z29"
        let ZVALUE = _vocab "Debris_Trap.ZVALUE"

    module Ditch =
        let ACCURACYCODE = _vocab "Ditch.ACCURACYCODE"
        let ATTRIBUTECOMPLETE = _vocab "Ditch.ATTRIBUTECOMPLETE"
        let DATECREATED = _vocab "Ditch.DATECREATED"
        let DATEMODIFIED = _vocab "Ditch.DATEMODIFIED"
        let DIGITALPICTUREID = _vocab "Ditch.DIGITALPICTUREID"
        let DRAWINGID = _vocab "Ditch.DRAWINGID"
        let ENABLED = _vocab "Ditch.ENABLED"
        let FACILITYID = _vocab "Ditch.FACILITYID"
        let FIELDCOMMENTS = _vocab "Ditch.FIELDCOMMENTS"
        let FIELDCOMPLETE = _vocab "Ditch.FIELDCOMPLETE"
        let GLOBALID = _vocab "Ditch.GLOBALID"
        let IMAGERYYEAR = _vocab "Ditch.IMAGERYYEAR"
        let INVENTORYDATE = _vocab "Ditch.INVENTORYDATE"
        let LEGACYID = _vocab "Ditch.LEGACYID"
        let LIFECYCLE = _vocab "Ditch.LIFECYCLE"
        let MAINTBY = _vocab "Ditch.MAINTBY"
        let MILES = _vocab "Ditch.MILES"
        let NOTES = _vocab "Ditch.NOTES"
        let OBJECTID = _vocab "Ditch.OBJECTID"
        let ORIGINALSOURCE = _vocab "Ditch.ORIGINALSOURCE"
        let OUTFALLID = _vocab "Ditch.OUTFALLID"
        let OWNER = _vocab "Ditch.OWNER"
        let PARENTID = _vocab "Ditch.PARENTID"
        let RELATEDFEATURE = _vocab "Ditch.RELATEDFEATURE"
        let SHAPE = _vocab "Ditch.SHAPE"
        let SHAPE_Length = _vocab "Ditch.SHAPE_Length"
        let SOURCE = _vocab "Ditch.SOURCE"
        let SUBTYPEFIELD = _vocab "Ditch.SUBTYPEFIELD"
        let SURFACETYPE = _vocab "Ditch.SURFACETYPE"
        let UNITID = _vocab "Ditch.UNITID"
        let WHOCREATED = _vocab "Ditch.WHOCREATED"
        let WHOMODIFIED = _vocab "Ditch.WHOMODIFIED"

    module End_Point =
        let End_Point_ACCURACYCODE = _vocab "End Point.ACCURACYCODE"
        let ANCILLARYROLE = _vocab "End Point.ANCILLARYROLE"
        let ATTRIBUTECOMPLETE = _vocab "End Point.ATTRIBUTECOMPLETE"
        let CREW = _vocab "End Point.CREW"
        let DATECREATED = _vocab "End Point.DATECREATED"
        let DATEMODIFIED = _vocab "End Point.DATEMODIFIED"
        let DIGITALPICTUREID = _vocab "End Point.DIGITALPICTUREID"
        let DRAWINGID = _vocab "End Point.DRAWINGID"
        let EASTING = _vocab "End Point.EASTING"
        let ENABLED = _vocab "End Point.ENABLED"
        let FACILITYID = _vocab "End Point.FACILITYID"
        let FIELDCOMMENTS = _vocab "End Point.FIELDCOMMENTS"
        let FIELDCOMPLETE = _vocab "End Point.FIELDCOMPLETE"
        let GLOBALID = _vocab "End Point.GLOBALID"
        let HYPERLINK_AR = _vocab "End Point.HYPERLINK_AR"
        let IMAGERYYEAR = _vocab "End Point.IMAGERYYEAR"
        let INFILTRATION = _vocab "End Point.INFILTRATION"
        let INVENTORYDATE = _vocab "End Point.INVENTORYDATE"
        let INVENTORYTYPE = _vocab "End Point.INVENTORYTYPE"
        let ISINFALL = _vocab "End Point.ISINFALL"
        let LEGACYID = _vocab "End Point.LEGACYID"
        let LIFECYCLE = _vocab "End Point.LIFECYCLE"
        let LOCATION = _vocab "End Point.LOCATION"
        let MAINTBY = _vocab "End Point.MAINTBY"
        let MATERIAL = _vocab "End Point.MATERIAL"
        let NEEDSATTENTION = _vocab "End Point.NEEDSATTENTION"
        let NORTHING = _vocab "End Point.NORTHING"
        let NOTES = _vocab "End Point.NOTES"
        let OBJECTID = _vocab "End Point.OBJECTID"
        let OBSTRUCTION = _vocab "End Point.OBSTRUCTION"
        let ORIGINALSOURCE = _vocab "End Point.ORIGINALSOURCE"
        let OUTFALLID = _vocab "End Point.OUTFALLID"
        let OWNER = _vocab "End Point.OWNER"
        let PARENTID = _vocab "End Point.PARENTID"
        let PRFRESOLUTION = _vocab "End Point.PRFRESOLUTION"
        let RELATEDFEATURE = _vocab "End Point.RELATEDFEATURE"
        let SHAPE = _vocab "End Point.SHAPE"
        let SOURCE = _vocab "End Point.SOURCE"
        let STRUCTUREID = _vocab "End Point.STRUCTUREID"
        let SUBTYPEFIELD = _vocab "End Point.SUBTYPEFIELD"
        let UNITID = _vocab "End Point.UNITID"
        let UPDATESOURCE = _vocab "End Point.UPDATESOURCE"
        let WHOCREATED = _vocab "End Point.WHOCREATED"
        let WHOMODIFIED = _vocab "End Point.WHOMODIFIED"
        let ZVALUE = _vocab "End Point.ZVALUE"

    module Inlet =
        let ACCURACYCODE = _vocab "Inlet.ACCURACYCODE"
        let ANCILLARYROLE = _vocab "Inlet.ANCILLARYROLE"
        let ATTRIBUTECOMPLETE = _vocab "Inlet.ATTRIBUTECOMPLETE"
        let CREW = _vocab "Inlet.CREW"
        let DATECREATED = _vocab "Inlet.DATECREATED"
        let DATEMODIFIED = _vocab "Inlet.DATEMODIFIED"
        let DIGITALPICTUREID = _vocab "Inlet.DIGITALPICTUREID"
        let DRAWINGID = _vocab "Inlet.DRAWINGID"
        let EASTING = _vocab "Inlet.EASTING"
        let ENABLED = _vocab "Inlet.ENABLED"
        let FACILITYID = _vocab "Inlet.FACILITYID"
        let FIELDCOMMENTS = _vocab "Inlet.FIELDCOMMENTS"
        let FIELDCOMPLETE = _vocab "Inlet.FIELDCOMPLETE"
        let GLOBALID = _vocab "Inlet.GLOBALID"
        let HYPERLINK_AR = _vocab "Inlet.HYPERLINK_AR"
        let IMAGERYYEAR = _vocab "Inlet.IMAGERYYEAR"
        let INFILTRATION = _vocab "Inlet.INFILTRATION"
        let INVENTORYDATE = _vocab "Inlet.INVENTORYDATE"
        let INVENTORYTYPE = _vocab "Inlet.INVENTORYTYPE"
        let INVERT_ELEV29 = _vocab "Inlet.INVERT_ELEV29"
        let INVERTELEV = _vocab "Inlet.INVERTELEV"
        let ISINFALL = _vocab "Inlet.ISINFALL"
        let LEGACYID = _vocab "Inlet.LEGACYID"
        let LIFECYCLE = _vocab "Inlet.LIFECYCLE"
        let LOCATION = _vocab "Inlet.LOCATION"
        let MAINTBY = _vocab "Inlet.MAINTBY"
        let MATERIAL = _vocab "Inlet.MATERIAL"
        let NEEDSATTENTION = _vocab "Inlet.NEEDSATTENTION"
        let NORTHING = _vocab "Inlet.NORTHING"
        let NOTES = _vocab "Inlet.NOTES"
        let OBJECTID = _vocab "Inlet.OBJECTID"
        let OBSTRUCTION = _vocab "Inlet.OBSTRUCTION"
        let ORIGINALSOURCE = _vocab "Inlet.ORIGINALSOURCE"
        let OUTFALLID = _vocab "Inlet.OUTFALLID"
        let OWNER = _vocab "Inlet.OWNER"
        let PARENTID = _vocab "Inlet.PARENTID"
        let PID_1 = _vocab "Inlet.PID_1"
        let PLACE = _vocab "Inlet.PLACE"
        let PRFRESOLUTION = _vocab "Inlet.PRFRESOLUTION"
        let RELATEDFEATURE = _vocab "Inlet.RELATEDFEATURE"
        let SHAPE = _vocab "Inlet.SHAPE"
        let SLOT_ELEV = _vocab "Inlet.SLOT_ELEV"
        let SOURCE = _vocab "Inlet.SOURCE"
        let STRCT_DEPTH = _vocab "Inlet.STRCT_DEPTH"
        let STRUCTUREID = _vocab "Inlet.STRUCTUREID"
        let SUBTYPEFIELD = _vocab "Inlet.SUBTYPEFIELD"
        let UNDERDRAINS = _vocab "Inlet.UNDERDRAINS"
        let UNITID = _vocab "Inlet.UNITID"
        let UPDATESOURCE = _vocab "Inlet.UPDATESOURCE"
        let WHOCREATED = _vocab "Inlet.WHOCREATED"
        let WHOMODIFIED = _vocab "Inlet.WHOMODIFIED"
        let ZVALUE = _vocab "Inlet.ZVALUE"

    module Junction_Fixed =
        let ACCURACYCODE = _vocab "Junction Fixed.ACCURACYCODE"
        let ANCILLARYROLE = _vocab "Junction Fixed.ANCILLARYROLE"
        let ATTRIBUTECOMPLETE = _vocab "Junction Fixed.ATTRIBUTECOMPLETE"
        let CREW = _vocab "Junction Fixed.CREW"
        let DATECREATED = _vocab "Junction Fixed.DATECREATED"
        let DATEMODIFIED = _vocab "Junction Fixed.DATEMODIFIED"
        let DIGITALPICTUREID = _vocab "Junction Fixed.DIGITALPICTUREID"
        let DRAWINGID = _vocab "Junction Fixed.DRAWINGID"
        let EASTING = _vocab "Junction Fixed.EASTING"
        let ENABLED = _vocab "Junction Fixed.ENABLED"
        let FACILITYID = _vocab "Junction Fixed.FACILITYID"
        let FIELDCOMMENTS = _vocab "Junction Fixed.FIELDCOMMENTS"
        let FIELDCOMPLETE = _vocab "Junction Fixed.FIELDCOMPLETE"
        let GLOBALID = _vocab "Junction Fixed.GLOBALID"
        let HYPERLINK_AR = _vocab "Junction Fixed.HYPERLINK_AR"
        let IMAGERYYEAR = _vocab "Junction Fixed.IMAGERYYEAR"
        let INFILTRATION = _vocab "Junction Fixed.INFILTRATION"
        let INVENTORYDATE = _vocab "Junction Fixed.INVENTORYDATE"
        let INVENTORYTYPE = _vocab "Junction Fixed.INVENTORYTYPE"
        let INVERT_ELEV = _vocab "Junction Fixed.INVERT_ELEV"
        let ISINFALL = _vocab "Junction Fixed.ISINFALL"
        let LEGACY_ID = _vocab "Junction Fixed.LEGACY_ID"
        let LIFECYCLE = _vocab "Junction Fixed.LIFECYCLE"
        let LOCATION = _vocab "Junction Fixed.LOCATION"
        let MAINTBY = _vocab "Junction Fixed.MAINTBY"
        let MATERIAL = _vocab "Junction Fixed.MATERIAL"
        let NEEDSATTENTION = _vocab "Junction Fixed.NEEDSATTENTION"
        let NORTHING = _vocab "Junction Fixed.NORTHING"
        let NOTES = _vocab "Junction Fixed.NOTES"
        let OBJECTID = _vocab "Junction Fixed.OBJECTID"
        let OBSTRUCTION = _vocab "Junction Fixed.OBSTRUCTION"
        let ORIGINALSOURCE = _vocab "Junction Fixed.ORIGINALSOURCE"
        let OUTFALLID = _vocab "Junction Fixed.OUTFALLID"
        let OWNER = _vocab "Junction Fixed.OWNER"
        let PARENTID = _vocab "Junction Fixed.PARENTID"
        let PRFRESOLUTION = _vocab "Junction Fixed.PRFRESOLUTION"
        let RELATEDFEATURE = _vocab "Junction Fixed.RELATEDFEATURE"
        let SHAPE = _vocab "Junction Fixed.SHAPE"
        let SOURCE = _vocab "Junction Fixed.SOURCE"
        let STRCT_DEPTH = _vocab "Junction Fixed.STRCT_DEPTH"
        let STRUCTUREID = _vocab "Junction Fixed.STRUCTUREID"
        let SUBTYPEFIELD = _vocab "Junction Fixed.SUBTYPEFIELD"
        let UNITID = _vocab "Junction Fixed.UNITID"
        let UPDATESOURCE = _vocab "Junction Fixed.UPDATESOURCE"
        let WHOCREATED = _vocab "Junction Fixed.WHOCREATED"
        let WHOMODIFIED = _vocab "Junction Fixed.WHOMODIFIED"
        let ZVALUE = _vocab "Junction Fixed.ZVALUE"

    module Outfall =
        let ATTACHEDTOID = _vocab "Outfall.ATTACHEDTOID"
        let DRAINAGEBASIN = _vocab "Outfall.DRAINAGEBASIN"
        let FACILITYID = _vocab "Outfall.FACILITYID"
        let GLOBALID = _vocab "Outfall.GLOBALID"
        let NOTES = _vocab "Outfall.NOTES"
        let OBJECTID = _vocab "Outfall.OBJECTID"
        let OUTFALLID = _vocab "Outfall.OUTFALLID"
        let OUTFALLTYPE = _vocab "Outfall.OUTFALLTYPE"
        let SHAPE = _vocab "Outfall.SHAPE"
        let STRUCTURETYPE = _vocab "Outfall.STRUCTURETYPE"
        let UNITID = _vocab "Outfall.UNITID"
        let UPSTREAMSTUCTUREID = _vocab "Outfall.UPSTREAMSTUCTUREID"
        let WATERBODYNAME = _vocab "Outfall.WATERBODYNAME"
        let WBID = _vocab "Outfall.WBID"

    module Stormwater_Pond_Discharge =

        let ACCURACYCODE = _vocab "Stormwater Pond Discharge.ACCURACYCODE"

        let ANCILLARYROLE = _vocab "Stormwater Pond Discharge.ANCILLARYROLE"

        let ATTRIBUTECOMPLETE = _vocab "Stormwater Pond Discharge.ATTRIBUTECOMPLETE"

        let DATECREATED = _vocab "Stormwater Pond Discharge.DATECREATED"

        let DATEMODIFIED = _vocab "Stormwater Pond Discharge.DATEMODIFIED"

        let DIGITALPICTUREID = _vocab "Stormwater Pond Discharge.DIGITALPICTUREID"

        let DIGITALPICTUREID_E = _vocab "Stormwater Pond Discharge.DIGITALPICTUREID_E"

        let DIGITALPICTUREID_S = _vocab "Stormwater Pond Discharge.DIGITALPICTUREID_S"

        let DIGITALPICTUREID_W = _vocab "Stormwater Pond Discharge.DIGITALPICTUREID_W"

        let DRAWINGID = _vocab "Stormwater Pond Discharge.DRAWINGID"

        let EASTING = _vocab "Stormwater Pond Discharge.EASTING"
        let ENABLED = _vocab "Stormwater Pond Discharge.ENABLED"

        let FACILITYID = _vocab "Stormwater Pond Discharge.FACILITYID"

        let FIELDCOMMENTS = _vocab "Stormwater Pond Discharge.FIELDCOMMENTS"

        let FIELDCOMPLETE = _vocab "Stormwater Pond Discharge.FIELDCOMPLETE"

        let GLOBALID = _vocab "Stormwater Pond Discharge.GLOBALID"

        let HYPERLINK_AR = _vocab "Stormwater Pond Discharge.HYPERLINK_AR"

        let IMAGERYYEAR = _vocab "Stormwater Pond Discharge.IMAGERYYEAR"

        let INFILTRATION = _vocab "Stormwater Pond Discharge.INFILTRATION"

        let INVENTORYDATE = _vocab "Stormwater Pond Discharge.INVENTORYDATE"

        let INVENTORYTYPE = _vocab "Stormwater Pond Discharge.INVENTORYTYPE"

        let LEGACYID = _vocab "Stormwater Pond Discharge.LEGACYID"

        let LIFECYCLE = _vocab "Stormwater Pond Discharge.LIFECYCLE"

        let LOCATION = _vocab "Stormwater Pond Discharge.LOCATION"
        let MAINTBY = _vocab "Stormwater Pond Discharge.MAINTBY"

        let NEEDSATTENTION = _vocab "Stormwater Pond Discharge.NEEDSATTENTION"

        let NORTHING = _vocab "Stormwater Pond Discharge.NORTHING"
        let NOTES = _vocab "Stormwater Pond Discharge.NOTES"
        let OBJECTID = _vocab "Stormwater Pond Discharge.OBJECTID"

        let ORIGINALSOURCE = _vocab "Stormwater Pond Discharge.ORIGINALSOURCE"

        let OUTFALLID = _vocab "Stormwater Pond Discharge.OUTFALLID"

        let OWNER = _vocab "Stormwater Pond Discharge.OWNER"
        let PARENTID = _vocab "Stormwater Pond Discharge.PARENTID"

        let PRFRESOLUTION = _vocab "Stormwater Pond Discharge.PRFRESOLUTION"

        let SHAPE = _vocab "Stormwater Pond Discharge.SHAPE"
        let SOURCE = _vocab "Stormwater Pond Discharge.SOURCE"

        let STRUCTUREID = _vocab "Stormwater Pond Discharge.STRUCTUREID"

        let STRUCTURETYPE = _vocab "Stormwater Pond Discharge.STRUCTURETYPE"

        let SUBTYPEFIELD = _vocab "Stormwater Pond Discharge.SUBTYPEFIELD"

        let UNITID = _vocab "Stormwater Pond Discharge.UNITID"

        let UPDATESOURCE = _vocab "Stormwater Pond Discharge.UPDATESOURCE"

        let WHOCREATED = _vocab "Stormwater Pond Discharge.WHOCREATED"

        let WHOMODIFIED = _vocab "Stormwater Pond Discharge.WHOMODIFIED"

        let Z29 = _vocab "Stormwater Pond Discharge.Z29"
        let ZVALUE = _vocab "Stormwater Pond Discharge.ZVALUE"

    module Stormwater_Pond =

        let ACCURACYCODE = _vocab "Stormwater Pond.ACCURACYCODE"
        let ACREAGE = _vocab "Stormwater Pond.ACREAGE"
        let ACTIVITY = _vocab "Stormwater Pond.ACTIVITY"
        let ANCILLARYROLE = _vocab "Stormwater Pond.ANCILLARYROLE"
        let CAPACITY = _vocab "Stormwater Pond.CAPACITY"
        let DATECREATED = _vocab "Stormwater Pond.DATECREATED"
        let DATEMODIFIED = _vocab "Stormwater Pond.DATEMODIFIED"
        let DRAINAGE_AREA = _vocab "Stormwater Pond.DRAINAGE_AREA"
        let EASTING = _vocab "Stormwater Pond.EASTING"
        let ENABLED = _vocab "Stormwater Pond.ENABLED"
        let FACILITYID = _vocab "Stormwater Pond.FACILITYID"
        let FILTER = _vocab "Stormwater Pond.FILTER"
        let FILTERLOCATION = _vocab "Stormwater Pond.FILTERLOCATION"
        let FILTERTYPE = _vocab "Stormwater Pond.FILTERTYPE"
        let GLOBALID = _vocab "Stormwater Pond.GLOBALID"
        let IMAGERYYEAR = _vocab "Stormwater Pond.IMAGERYYEAR"
        let LEGACYID = _vocab "Stormwater Pond.LEGACYID"
        let LIFECYCLE = _vocab "Stormwater Pond.LIFECYCLE"
        let LOCATION = _vocab "Stormwater Pond.LOCATION"
        let MAINTBY = _vocab "Stormwater Pond.MAINTBY"
        let NORTHING = _vocab "Stormwater Pond.NORTHING"
        let NOTES = _vocab "Stormwater Pond.NOTES"
        let OBJECTID = _vocab "Stormwater Pond.OBJECTID"
        let ORIGINALSOURCE = _vocab "Stormwater Pond.ORIGINALSOURCE"
        let OWNER = _vocab "Stormwater Pond.OWNER"
        let PARCELID = _vocab "Stormwater Pond.PARCELID"
        let PARENTID = _vocab "Stormwater Pond.PARENTID"
        let PONDID = _vocab "Stormwater Pond.PONDID"
        let PONDTYPE = _vocab "Stormwater Pond.PONDTYPE"
        let SOURCE = _vocab "Stormwater Pond.SOURCE"
        let SUBTYPEFIELD = _vocab "Stormwater Pond.SUBTYPEFIELD"
        let Shape = _vocab "Stormwater Pond.Shape"
        let UNITDESC = _vocab "Stormwater Pond.UNITDESC"
        let UPDATESOURCE = _vocab "Stormwater Pond.UPDATESOURCE"
        let WHOCREATED = _vocab "Stormwater Pond.WHOCREATED"
        let WHOMODIFIED = _vocab "Stormwater Pond.WHOMODIFIED"
        let Z29 = _vocab "Stormwater Pond.Z29"
        let ZVALUE = _vocab "Stormwater Pond.ZVALUE"

    let owner = _vocab "owner"
    let Owner = _vocab "Owner"
    let filter_location = _vocab "filter_location"
    let Filter_Location = _vocab "Filter_Location"

    let LCPW_OverlayStormwaterInfrastructure_D_WM =
        _vocab "LCPW_OverlayStormwaterInfrastructure_D_WM"

    let x_coordinate = _vocab "x_coordinate"
    let y_coordinate = _vocab "y_coordinate"
    let z_coordinate = _vocab "z_coordinate"
    let hyd = _vocab "hyd"
    let Hyd = _vocab "Hyd"

    let drainage_basin = _vocab "drainage_basin"
    let Drainage_Basin = _vocab "Drainage_Basin"
    let attached_to = _vocab "attached_to"
    let facility = _vocab "facility"
    let feature_class = _vocab "feature_class"
    let Feature_Class = _vocab "Feature_Class"
    let layer = _vocab "layer"
    let Layer = _vocab "Layer"
    let feature_layer = _vocab "feature_layer"
    let Feature_Layer = _vocab "Feature_Layer"
    let group_layer = _vocab "group_layer"
    let Group_Layer = _vocab "Group_Layer"
    let parent_layer = _vocab "parent_layer"
    let child_layer = _vocab "child_layer"
    let coded_value_domain = _vocab "coded_value_domain"
    let coded_value = _vocab "coded_value"
    let data_element = _vocab "data_element"
    let feature_dataset = _vocab "feature_dataset"
    let DrainageNetwork_Feature_Dataset = _vocab "DrainageNetwork_Feature_Dataset"
    let DrainageNonNetwork_Feature_Dataset = _vocab "DrainageNonNetwork_Feature_Dataset"
    let Bridge_Feature_Class = _Feature_Class "Bridge"
    let BridgePoint_Feature_Class = _Feature_Class "BridgePoint"
    let Conduit_Feature_Class = _Feature_Class "Conduit"
    let Connectivity_Feature_Class = _Feature_Class "Connectivity"
    let CulvertCrossDrain_Feature_Class = _Feature_Class "CulvertCrossDrain"
    let Damage_Feature_Class = _Feature_Class "Damage"
    let DebrisTrap_Feature_Class = _Feature_Class "DebrisTrap"
    let Ditch_Feature_Class = _Feature_Class "Ditch"
    let DitchPoint_Feature_Class = _Feature_Class "DitchPoint"
    let EndPoint_Feature_Class = _Feature_Class "EndPoint"
    let GenericStormAsset_Feature_Class = _Feature_Class "GenericStormAsset"
    let Inlet_Feature_Class = _Feature_Class "Inlet"
    let Interference_Feature_Class = _Feature_Class "Interference"
    let Junction_fixed_Feature_Class = _Feature_Class "Junction_fixed"
    let MediaPoints_Feature_Class = _Feature_Class "MediaPoints"

    let MediaPointsWithoutPhotos_Feature_Class =
        _Feature_Class "MediaPointsWithoutPhotos"

    let Outfall_Feature_Class = _Feature_Class "Outfall"
    let Outfall_DrainageArea_Feature_Class = _Feature_Class "Outfall_DrainageArea"

    let Outfall_DrainageArea_MOF_Feature_Class =
        _Feature_Class "Outfall_DrainageArea_MOF"

    let Outfall_DrainageArea_MS4_Feature_Class =
        _Feature_Class "Outfall_DrainageArea_MS4"

    let PollutionControlBox_Feature_Class = _Feature_Class "PollutionControlBox"
    let PrivatePoint_Feature_Class = _Feature_Class "PrivatePoint"
    let StormwaterPond_Feature_Class = _Feature_Class "StormwaterPond"

    let StormwaterPond_MediaPoints_Feature_Class =
        _Feature_Class "StormwaterPond_MediaPoints"

    let StormwaterPondDischarge_Feature_Class = _Feature_Class "StormwaterPondDischarge"
    let StormwaterPondTopOfBank_Feature_Class = _Feature_Class "StormwaterPondTopOfBank"
    let Drainage_Network_Group_Layer = _vocab "Drainage_Network_Group_Layer"
    let Non_Drainage_Network_Group_Layer = _vocab "Non-Drainage_Network_Group_Layer"
    let Bridge_Feature_Layer = _Feature_Layer "Bridge"
    let Bridge_Point_Feature_Layer = _Feature_Layer "Bridge Point"
    let Conduit_Feature_Layer = _Feature_Layer "Conduit"
    let Connectivity_Feature_Layer = _Feature_Layer "Connectivity"
    let Culvert_Cross_Drain_Feature_Layer = _Feature_Layer "Culvert Cross Drain"
    let Damage_Feature_Layer = _Feature_Layer "Damage"
    let Debris_Trap_Feature_Layer = _Feature_Layer "Debris Trap"
    let Ditch_Feature_Layer = _Feature_Layer "Ditch"
    let Ditch_Point_Feature_Layer = _Feature_Layer "Ditch Point"
    let End_Point_Feature_Layer = _Feature_Layer "End Point"
    let Generic_Storm_Asset_Feature_Layer = _Feature_Layer "Generic Storm Asset"
    let Inlet_Feature_Layer = _Feature_Layer "Inlet"
    let Interference_Feature_Layer = _Feature_Layer "Interference"
    let Junction_Fixed_Feature_Layer = _Feature_Layer "Junction Fixed"
    let Media_Points_Feature_Layer = _Feature_Layer "Media Points"

    let Media_Points_Without_Photos_Feature_Layer =
        _Feature_Layer "Media Points Without Photos"

    let Outfall_Feature_Layer = _Feature_Layer "Outfall"
    let Outfall_Drainage_Area_Feature_Layer = _Feature_Layer "Outfall Drainage Area"

    let Outfall_Drainage_Area_MOF_Feature_Layer =
        _Feature_Layer "Outfall Drainage Area MOF"

    let Outfall_Drainage_Area_MS4_Feature_Layer =
        _Feature_Layer "Outfall Drainage Area MS4"

    let Pollution_Control_Box_Feature_Layer = _Feature_Layer "Pollution Control Box"
    let Private_Point_Feature_Layer = _Feature_Layer "Private Point"
    let Stormwater_Pond_Feature_Layer = _Feature_Layer "Stormwater Pond"

    let Stormwater_Pond_Media_Points_Feature_Layer =
        _Feature_Layer "Stormwater Pond Media Points"

    let Stormwater_Pond_Discharge_Feature_Layer =
        _Feature_Layer "Stormwater Pond Discharge"

    let Stormwater_Pond_Top_of_Bank_Feature_Layer =
        _Feature_Layer "Stormwater Pond - Top of Bank"

    let Bridge_Feature = _Feature "Bridge"
    let Bridge_Point_Feature = _Feature "Bridge Point"
    let Conduit_Feature = _Feature "Conduit"
    let Connectivity_Feature = _Feature "Connectivity"
    let Culvert_Cross_Drain_Feature = _Feature "Culvert Cross Drain"
    let Damage_Feature = _Feature "Damage"
    let Debris_Trap_Feature = _Feature "Debris Trap"
    let Ditch_Feature = _Feature "Ditch"
    let Ditch_Point_Feature = _Feature "Ditch Point"
    let End_Point_Feature = _Feature "End Point"
    let Generic_Storm_Asset_Feature = _Feature "Generic Storm Asset"
    let Inlet_Feature = _Feature "Inlet"
    let Interference_Feature = _Feature "Interference"
    let Junction_Fixed_Feature = _Feature "Junction Fixed"
    let Media_Points_Feature = _Feature "Media Points"
    let Media_Points_Without_Photos_Feature = _Feature "Media Points Without Photos"
    let Outfall_Feature = _Feature "Outfall"
    let Outfall_Drainage_Area_Feature = _Feature "Outfall Drainage Area"
    let Outfall_Drainage_Area_MOF_Feature = _Feature "Outfall Drainage Area MOF"
    let Outfall_Drainage_Area_MS4_Feature = _Feature "Outfall Drainage Area MS4"
    let Pollution_Control_Box_Feature = _Feature "Pollution Control Box"
    let Private_Point_Feature = _Feature "Private Point"
    let Stormwater_Pond_Feature = _Feature "Stormwater Pond"
    let Stormwater_Pond_Media_Points_Feature = _Feature "Stormwater Pond Media Points"
    let Stormwater_Pond_Discharge_Feature = _Feature "Stormwater Pond Discharge"
    let Stormwater_Pond_Top_of_Bank_Feature = _Feature "Stormwater Pond - Top of Bank"


    let ACCEPT_DATE = _vocab "ACCEPT_DATE"
    let ACCURACYCODE = _vocab "ACCURACYCODE"
    let ACREAGE = _vocab "ACREAGE"
    let ACRES = _vocab "ACRES"
    let ACTIVITY = _vocab "ACTIVITY"
    let ANCILLARYROLE = _vocab "ANCILLARYROLE"
    let ATTACHEDTOID = _vocab "ATTACHEDTOID"
    let ATTRIBUTECOMPLETE = _vocab "ATTRIBUTECOMPLETE"
    let CAPACITY = _vocab "CAPACITY"
    let CREATIONDATE = _vocab "CREATIONDATE"
    let CREATOR = _vocab "CREATOR"
    let CREW = _vocab "CREW"
    let DAMAGEID = _vocab "DAMAGEID"
    let DAMAGETYPE = _vocab "DAMAGETYPE"
    let DATAFILE = _vocab "DATAFILE"
    let DATE_ = _vocab "DATE_"
    let DATECREATED = _vocab "DATECREATED"
    let DATEMODIFIED = _vocab "DATEMODIFIED"
    let DESCRIPTION = _vocab "DESCRIPTION"
    let DIAMETER = _vocab "DIAMETER"
    let DIGITALPICTUREID = _vocab "DIGITALPICTUREID"
    let DIGITALPICTUREID_E = _vocab "DIGITALPICTUREID_E"
    let DIGITALPICTUREID_S = _vocab "DIGITALPICTUREID_S"
    let DIGITALPICTUREID_W = _vocab "DIGITALPICTUREID_W"
    let DOWNSTREAM_DEPTH = _vocab "DOWNSTREAM_DEPTH"
    let DOWNSTREAM_ELEV = _vocab "DOWNSTREAM_ELEV"
    let DOWNSTREAMDEPTH = _vocab "DOWNSTREAMDEPTH"
    let DOWNSTREAMELEVATION = _vocab "DOWNSTREAMELEVATION"
    let DRAINAGE_AREA = _vocab "DRAINAGE_AREA"
    let DRAINAGEAREA = _vocab "DRAINAGEAREA"
    let DRAINAGEBASIN = _vocab "DRAINAGEBASIN"
    let DRAWINGID = _vocab "DRAWINGID"
    let EASTING = _vocab "EASTING"
    let EDITDATE = _vocab "EDITDATE"
    let EDITOR = _vocab "EDITOR"
    let ELEMENTX = _vocab "ELEMENTX"
    let ELEMENTY = _vocab "ELEMENTY"
    let ENABLED = _vocab "ENABLED"
    let FACILITYID = _vocab "FACILITYID"
    let FIELD_COMMENTS_ = _vocab "FIELD_COMMENTS_"
    let FIELDCOMMENTS = _vocab "FIELDCOMMENTS"
    let FIELDCOMPLETE = _vocab "FIELDCOMPLETE"
    let FIELDCREW = _vocab "FIELDCREW"
    let FILE_NAME = _vocab "FILE_NAME"
    let FILE_NAME_1 = _vocab "FILE_NAME_1"
    let FILTER = _vocab "FILTER"
    let FILTERLOCATION = _vocab "FILTERLOCATION"
    let FILTERTYPE = _vocab "FILTERTYPE"
    let FINAL_NAME = _vocab "FINAL_NAME"
    let FOLDER = _vocab "FOLDER"
    let GLOBALID = _vocab "GLOBALID"
    let HEIGHT = _vocab "HEIGHT"
    let HOTLINK = _vocab "HOTLINK"
    let HYD_ID = _vocab "HYD_ID"
    let HYPERLINK = _vocab "HYPERLINK"
    let HYPERLINK_AR = _vocab "HYPERLINK_AR"
    let IMAGERYYEAR = _vocab "IMAGERYYEAR"
    let INFILTRATION = _vocab "INFILTRATION"
    let INSPDATE = _vocab "INSPDATE"
    let INVENTORIED_BY = _vocab "INVENTORIED_BY"
    let INVENTORYDATE = _vocab "INVENTORYDATE"
    let INVENTORYTYPE = _vocab "INVENTORYTYPE"
    let INVERT_ELEV = _vocab "INVERT_ELEV"
    let INVERT_ELEV29 = _vocab "INVERT_ELEV29"
    let INVERTELEV = _vocab "INVERTELEV"
    let ISINFALL = _vocab "ISINFALL"
    let LEGACY_ID = _vocab "LEGACY_ID"
    let LEGACYID = _vocab "LEGACYID"
    let LFEET = _vocab "LFEET"
    let LIFECYCLE = _vocab "LIFECYCLE"
    let LOC_DESC = _vocab "LOC_DESC"
    let LOCATION = _vocab "LOCATION"
    let MAINTBY = _vocab "MAINTBY"
    let MATERIAL = _vocab "MATERIAL"
    let MEDIA_CODE = _vocab "MEDIA_CODE"
    let MILES = _vocab "MILES"
    let NEEDSATTENTION = _vocab "NEEDSATTENTION"
    let NORTHING = _vocab "NORTHING"
    let NOTES = _vocab "NOTES"
    let NUM_BARRELS = _vocab "NUM_BARRELS"
    let OBJECTID = _vocab "OBJECTID"
    let OBSTRUCTION = _vocab "OBSTRUCTION"
    let ORIGINALSOURCE = _vocab "ORIGINALSOURCE"
    let OUTFALLID = _vocab "OUTFALLID"
    let OUTFALLTYPE = _vocab "OUTFALLTYPE"
    let OWNER = _vocab "OWNER"
    let PARCELID = _vocab "PARCELID"
    let PARENTID = _vocab "PARENTID"
    let PERCT_GRD = _vocab "PERCT_GRD"
    let PHOTO_FOLDER = _vocab "PHOTO_FOLDER"
    let PHOTO_NUM = _vocab "PHOTO_NUM"
    let PHOTOID = _vocab "PHOTOID"
    let PID_1 = _vocab "PID_1"
    let PIPESHAPE = _vocab "PIPESHAPE"
    let PLACE = _vocab "PLACE"
    let POND_ID = _vocab "POND_ID"
    let PONDID = _vocab "PONDID"
    let PONDTYPE = _vocab "PONDTYPE"
    let PONDYR = _vocab "PONDYR"
    let PRFRESOLUTION = _vocab "PRFRESOLUTION"
    let RAW_NAME = _vocab "RAW_NAME"
    let RELATEDFEATURE = _vocab "RELATEDFEATURE"
    let ROTATION_AZ = _vocab "ROTATION_AZ"
    let SHAPE = _vocab "SHAPE"
    let SHAPE_Area = _vocab "SHAPE_Area"
    let SHAPE_Length = _vocab "SHAPE_Length"
    let SLOT_ELEV = _vocab "SLOT_ELEV"
    let SOURCE = _vocab "SOURCE"
    let SOURCEYEAR = _vocab "SOURCEYEAR"
    let STORAGE_FULL_PATH_ADDR = _vocab "STORAGE_FULL_PATH_ADDR"
    let STORAGE_PATH_ADDR = _vocab "STORAGE_PATH_ADDR"
    let STORAGE_STATIC_PATH_ADDR = _vocab "STORAGE_STATIC_PATH_ADDR"
    let STRCT_DEPTH = _vocab "STRCT_DEPTH"
    let STRUCTURE_ID = _vocab "STRUCTURE_ID"
    let STRUCTUREID = _vocab "STRUCTUREID"
    let STRUCTURETYPE = _vocab "STRUCTURETYPE"
    let SUBTYPEFIELD = _vocab "SUBTYPEFIELD"
    let SURFACETYPE = _vocab "SURFACETYPE"
    let UNDERDRAINS = _vocab "UNDERDRAINS"
    let UNITDESC = _vocab "UNITDESC"
    let UPDATESOURCE = _vocab "UPDATESOURCE"
    let UPSTREAM_DEPTH = _vocab "UPSTREAM_DEPTH"
    let UPSTREAM_ELEV = _vocab "UPSTREAM_ELEV"
    let UPSTREAMDEPTH = _vocab "UPSTREAMDEPTH"
    let UPSTREAMELEVATION = _vocab "UPSTREAMELEVATION"
    let UPSTREAMSTUCTUREID = _vocab "UPSTREAMSTUCTUREID"
    let VIEW_ = _vocab "VIEW_"
    let WATERBODYNAME = _vocab "WATERBODYNAME"
    let WBID = _vocab "WBID"
    let WHOCREATED = _vocab "WHOCREATED"
    let WHOMODIFIED = _vocab "WHOMODIFIED"
    let WIDTH = _vocab "WIDTH"
    let Z29 = _vocab "Z29"
    let ZVALUE = _vocab "ZVALUE"
    let UNITID = _vocab "UNITID"
    let Feature = _vocab "Feature"
    let Facility = _vocab "Facility"
    let Outfall = _vocab "Outfall"
    let Upstream_Structure = _vocab "Upstream_Structure"
    let Downstream_Structure = _vocab "Downstream_Structure"
    let Structure = _vocab "Structure"
    let Pond = _vocab "Pond"
    let parent = _vocab "parent"
    let subLayer = _vocab "subLayer"
    let outfall = _vocab "outfall"
    let upstream_structure = _vocab "upstream_structure"
    let structure = _vocab "structure"
    let downstream_structure = _vocab "downstream_structure"
    let currentVersion = _vocab "currentVersion"
    let serviceDescription = _vocab "serviceDescription"
    let mapName = _vocab "mapName"
    let description = _vocab "description"
    let copyrightText = _vocab "copyrightText"
    let supportsDynamicLayers = _vocab "supportsDynamicLayers"
    let layers = _vocab "layers"
    let tables = _vocab "tables"
    let table = _vocab "table"
    let spatialReference = _vocab "spatialReference"
    let singleFusedMapCache = _vocab "singleFusedMapCache"
    let initialExtent = _vocab "initialExtent"
    let fullExtent = _vocab "fullExtent"
    let minScale = _vocab "minScale"
    let maxScale = _vocab "maxScale"
    let units = _vocab "units"
    let supportedImageFormatTypes = _vocab "supportedImageFormatTypes"
    let supportedImageFormatType = _vocab "supportedImageFormatType"
    let documentInfo = _vocab "documentInfo"
    let capabilities = _vocab "capabilities"
    let supportedQueryFormats = _vocab "supportedQueryFormats"
    let exportTilesAllowed = _vocab "exportTilesAllowed"
    let referenceScale = _vocab "referenceScale"
    let supportsDatumTransformation = _vocab "supportsDatumTransformation"
    let maxRecordCount = _vocab "maxRecordCount"
    let maxImageHeight = _vocab "maxImageHeight"
    let maxImageWidth = _vocab "maxImageWidth"
    let supportedExtensions = _vocab "supportedExtensions"
    let culture = _vocab "culture"
    let name = _vocab "name"
    let guid = _vocab "guid"
    let catalogPath = _vocab "catalogPath"
    let snippet = _vocab "snippet"
    let summary = _vocab "summary"
    let title = _vocab "title"
    let tags = _vocab "tags"
    let ``type`` = _vocab "type"
    let typeKeywords = _vocab "typeKeywords"
    let thumbnail = _vocab "thumbnail"
    let url = _vocab "url"
    let extent = _vocab "extent"
    let accessInformation = _vocab "accessInformation"
    let licenseInfo = _vocab "licenseInfo"
    let Keyword = _vocab "Keyword"
    let Keywords = _vocab "Keywords"
    let capability = _vocab "capability"
    let supportedQueryFormat = _vocab "supportedQueryFormat"
    let Map_Service = _vocab "Map_Service"
    let parentLayerId = _vocab "parentLayerId"
    let defaultVisibility = _vocab "defaultVisibility"
    let hasAttachments = _vocab "hasAttachments"
    let htmlPopupType = _vocab "htmlPopupType"
    let canModifyLayer = _vocab "canModifyLayer"
    let canScaleSymbols = _vocab "canScaleSymbols"
    let hasLabels = _vocab "hasLabels"
    let supportsStatistics = _vocab "supportsStatistics"
    let supportsAdvancedQueries = _vocab "supportsAdvancedQueries"
    let isDataVersioned = _vocab "isDataVersioned"
    let useStandardizedQueries = _vocab "useStandardizedQueries"
    let supportsCoordinatesQuantization = _vocab "supportsCoordinatesQuantization"
    let id = _vocab "id"
    let geometryType = _vocab "geometryType"
    let displayField = _vocab "displayField"
    let count = _vocab "count"
    let displayFieldName = _vocab "displayFieldName"
    let exceededTransferLimit = _vocab "exceededTransferLimit"
    let hasZ = _vocab "hasZ"
    let field = _vocab "field"
    let domain = _vocab "domain"
    let feature = _vocab "feature"
    let x = _vocab "x"
    let y = _vocab "y"

    module _literal =
        let DrainageNetwork = RDF_Literal.simple "DrainageNetwork"
        let DrainageNonNetwork = RDF_Literal.simple "DrainageNonNetwork"

        module description =
            let Bridge =
                lmdb_read_write { return! RDF_Literal.US "A short stretch of closed conduit, used where a ditch or canal crosses under a roadway. " }

            let BridgePoint =
                lmdb_read_write { return! RDF_Literal.US "A vertex point for a ditch line or a point to represent the location of a specific attribute." }

            let Conduit =
                lmdb_read_write { return! RDF_Literal.US "A stormwater pipe feature making up a closed system. " }

            let Connectivity =
                lmdb_read_write { return! RDF_Literal.US "A line that represents the flow of stormwater that is not represented by any other drain line feature. " }

            let CulvertCrossDrain =
                lmdb_read_write { return! RDF_Literal.US "A short stretch of closed conduit, used where a ditch or canal crosses under a roadway. " }

            let DebrisTrap =
                lmdb_read_write { return! RDF_Literal.US "Are assets related to an open system and are designed and build to specifications." }

            let Ditch =
                lmdb_read_write { return! RDF_Literal.US "A small open channel, trench, or structure designed to collect and carry stormwater runoff." }

            let DitchPoint =
                lmdb_read_write { return! RDF_Literal.US "A vertex point for a ditch line or a point to represent the location of a specific attribute." }

            let EndPoint =
                lmdb_read_write { return! RDF_Literal.US "The point at which an open system meets a closed system. " }

            let GenericStormAsset =
                lmdb_read_write { return! RDF_Literal.US "Unspecified stormwater system feature that is used to represent a missing feature at the end of a conduit/culvert." }

            let Inlet =
                lmdb_read_write { return! RDF_Literal.US "A feature at the beginning of a closed drainage system where water is able to enter the conveyance system." }

            let Interference =
                lmdb_read_write { return! RDF_Literal.US "Identifies if there is interference within or crossing the ditch. Example would be a sewer or water pipe from ditch bank to ditch bank." }

            let Junction_fixed =
                lmdb_read_write { return! RDF_Literal.US "A cylindrical or cube-shaped structure located below the surface grade. Serves as a connector for merging laterals, inlets, and endpoints from different directions and elevations. Most often accessed through a manhole." }

            let PollutionControlBox =
                lmdb_read_write { return! RDF_Literal.US "Filtration device that separates debris from stormwater. This is usually an asset related to the closed system and is pre-fabricated in nature." }

            let PrivatePoint =
                lmdb_read_write { return! RDF_Literal.US "The point at which a city maintained  stormwater conduit is stopped to show that the flow is originating  from a private source" }

            let StormwaterPondDischarge =
                lmdb_read_write { return! RDF_Literal.US "A control device acting as a barricade, allowing water to flow once it reaches a certain level." }

module dotnet =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"https://learn.microsoft.com/en-us/dotnet/api/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

module h8importtool =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"http://www.infor.com/Hansen8/2011/08/Maps.xsd#" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let Maps = _vocab "Maps"
    let Map = _vocab "Map"
    let Key = _vocab "Key"
    let IsDefault = _vocab "IsDefault"
    let Name = _vocab "Name"
    let SourceFilePath = _vocab "SourceFilePath"
    let SheetName = _vocab "SheetName"
    let ConnectionString = _vocab "ConnectionString"
    let ProviderName = _vocab "ProviderName"
    let UploadOption = _vocab "UploadOption"
    let IsFirstRowHeader = _vocab "IsFirstRowHeader"
    let CreatedDate = _vocab "CreatedDate"
    let CreatedBy = _vocab "CreatedBy"
    let MapColumn = _vocab "MapColumn"
    let MapKey = _vocab "MapKey"
    let SourceColumnName = _vocab "SourceColumnName"
    let TargetColumnCommonId = _vocab "TargetColumnCommonId"
    let TargetColumnType = _vocab "TargetColumnType"
    let MapTableInformation = _vocab "MapTableInformation"
    let ProductFamilyOwner = _vocab "ProductFamilyOwner"
    let ProductFamilyName = _vocab "ProductFamilyName"
    let TableName = _vocab "TableName"
    let TableCommonId = _vocab "TableCommonId"
    let TableKey = _vocab "TableKey"
    let System'Data'OleDb = _vocab "System'Data'OleDb"
    let Conduit_to_StormLiftStation = _vocab "Conduit_to_StormLiftStation"

    let CulvertCrossDrain_to_StormServiceLine =
        _vocab "CulvertCrossDrain_to_StormServiceLine"

    let DebrisTrap_to_StormValve = _vocab "DebrisTrap_to_StormValve"
    let Ditch_to_StormBackflowPreventer = _vocab "Ditch_to_StormBackflowPreventer"
    let EndPoint_to_StormNode = _vocab "EndPoint_to_StormNode"
    let Inlet_to_StormInlet = _vocab "Inlet_to_StormInlet"
    let Junction_fixed_to_StormManhole = _vocab "Junction_fixed_to_StormManhole"
    let Outfall_to_StormStorageBasin = _vocab "Outfall_to_StormStorageBasin"

    let StormwaterPond_to_StormMiscellaneous =
        _vocab "StormwaterPond_to_StormMiscellaneous"

    let StormwaterPondDischarge_to_StormLevee =
        _vocab "StormwaterPondDischarge_to_StormLevee"

    module _string =
        let file_path (layer_name: string) =
            Path.Combine(mapping_directory, $"{layer_name}.xlsx")

        let connection_string (layer_name: string) =
            let Data_Source = file_path layer_name
            $"""Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Data_Source};Extended Properties="Excel 12.0;HDR=Yes;IMEX=1";"""

    module _literal =
        let source_file_path (layer_name: string) (transaction: LightningTransaction) =
            let file_path = _string.file_path layer_name
            RDF_Literal.simple file_path transaction

        let connection_string (layer_name: string) (transaction: LightningTransaction) =
            let connection_string = _string.connection_string layer_name
            RDF_Literal.simple connection_string transaction

        let System'Data'OleDb =
            lmdb_read_write { return! RDF_Literal.simple "System.Data.OleDb" }






module interraster =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string "http://interraster.leoncountyfl.gov/interraster/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _Feature (name: string) (transaction: LightningTransaction) =
        _prefix ($"{name.low_lined}_Feature") transaction

    let _Feature_Layer (name: string) (transaction: LightningTransaction) =
        _prefix ($"{name.low_lined}_Feature_Layer") transaction

    let _Feature_Layer_Schema (name: string) (transaction: LightningTransaction) =
        _prefix ($"{name.low_lined}_Feature_Layer_Schema") transaction

    let _Feature_Layer_Data (name: string) (transaction: LightningTransaction) =
        _prefix ($"{name.low_lined}_Feature_Layer_Data") transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }

    let ACCEPT_DATE = _vocab "ACCEPT_DATE"
    let ACCURACYCODE = _vocab "ACCURACYCODE"
    let ACREAGE = _vocab "ACREAGE"
    let ACRES = _vocab "ACRES"
    let ACTIVITY = _vocab "ACTIVITY"
    let ANCILLARYROLE = _vocab "ANCILLARYROLE"
    let ATTACHEDTOID = _vocab "ATTACHEDTOID"
    let ATTRIBUTECOMPLETE = _vocab "ATTRIBUTECOMPLETE"
    let CAPACITY = _vocab "CAPACITY"
    let CREATIONDATE = _vocab "CREATIONDATE"
    let CREATOR = _vocab "CREATOR"
    let CREW = _vocab "CREW"
    let DAMAGEID = _vocab "DAMAGEID"
    let DAMAGETYPE = _vocab "DAMAGETYPE"
    let DATAFILE = _vocab "DATAFILE"
    let DATE_ = _vocab "DATE_"
    let DATECREATED = _vocab "DATECREATED"
    let DATEMODIFIED = _vocab "DATEMODIFIED"
    let DESCRIPTION = _vocab "DESCRIPTION"
    let DIAMETER = _vocab "DIAMETER"
    let DIGITALPICTUREID = _vocab "DIGITALPICTUREID"
    let DIGITALPICTUREID_E = _vocab "DIGITALPICTUREID_E"
    let DIGITALPICTUREID_S = _vocab "DIGITALPICTUREID_S"
    let DIGITALPICTUREID_W = _vocab "DIGITALPICTUREID_W"
    let DOWNSTREAM_DEPTH = _vocab "DOWNSTREAM_DEPTH"
    let DOWNSTREAM_ELEV = _vocab "DOWNSTREAM_ELEV"
    let DOWNSTREAMDEPTH = _vocab "DOWNSTREAMDEPTH"
    let DOWNSTREAMELEVATION = _vocab "DOWNSTREAMELEVATION"
    let DRAINAGE_AREA = _vocab "DRAINAGE_AREA"
    let DRAINAGEAREA = _vocab "DRAINAGEAREA"
    let DRAINAGEBASIN = _vocab "DRAINAGEBASIN"
    let DRAWINGID = _vocab "DRAWINGID"
    let EASTING = _vocab "EASTING"
    let EDITDATE = _vocab "EDITDATE"
    let EDITOR = _vocab "EDITOR"
    let ELEMENTX = _vocab "ELEMENTX"
    let ELEMENTY = _vocab "ELEMENTY"
    let ENABLED = _vocab "ENABLED"
    let FACILITYID = _vocab "FACILITYID"
    let FIELD_COMMENTS_ = _vocab "FIELD_COMMENTS_"
    let FIELDCOMMENTS = _vocab "FIELDCOMMENTS"
    let FIELDCOMPLETE = _vocab "FIELDCOMPLETE"
    let FIELDCREW = _vocab "FIELDCREW"
    let FILE_NAME = _vocab "FILE_NAME"
    let FILE_NAME_1 = _vocab "FILE_NAME_1"
    let FILTER = _vocab "FILTER"
    let FILTERLOCATION = _vocab "FILTERLOCATION"
    let FILTERTYPE = _vocab "FILTERTYPE"
    let FINAL_NAME = _vocab "FINAL_NAME"
    let FOLDER = _vocab "FOLDER"
    let GLOBALID = _vocab "GLOBALID"
    let HEIGHT = _vocab "HEIGHT"
    let HOTLINK = _vocab "HOTLINK"
    let HYD_ID = _vocab "HYD_ID"
    let HYPERLINK = _vocab "HYPERLINK"
    let HYPERLINK_AR = _vocab "HYPERLINK_AR"
    let IMAGERYYEAR = _vocab "IMAGERYYEAR"
    let INFILTRATION = _vocab "INFILTRATION"
    let INSPDATE = _vocab "INSPDATE"
    let INVENTORIED_BY = _vocab "INVENTORIED_BY"
    let INVENTORYDATE = _vocab "INVENTORYDATE"
    let INVENTORYTYPE = _vocab "INVENTORYTYPE"
    let INVERT_ELEV = _vocab "INVERT_ELEV"
    let INVERT_ELEV29 = _vocab "INVERT_ELEV29"
    let INVERTELEV = _vocab "INVERTELEV"
    let ISINFALL = _vocab "ISINFALL"
    let LEGACY_ID = _vocab "LEGACY_ID"
    let LEGACYID = _vocab "LEGACYID"
    let LFEET = _vocab "LFEET"
    let LIFECYCLE = _vocab "LIFECYCLE"
    let LOC_DESC = _vocab "LOC_DESC"
    let LOCATION = _vocab "LOCATION"
    let MAINTBY = _vocab "MAINTBY"
    let MATERIAL = _vocab "MATERIAL"
    let MEDIA_CODE = _vocab "MEDIA_CODE"
    let MILES = _vocab "MILES"
    let NEEDSATTENTION = _vocab "NEEDSATTENTION"
    let NORTHING = _vocab "NORTHING"
    let NOTES = _vocab "NOTES"
    let NUM_BARRELS = _vocab "NUM_BARRELS"
    let OBJECTID = _vocab "OBJECTID"
    let OBSTRUCTION = _vocab "OBSTRUCTION"
    let ORIGINALSOURCE = _vocab "ORIGINALSOURCE"
    let OUTFALLID = _vocab "OUTFALLID"
    let OUTFALLTYPE = _vocab "OUTFALLTYPE"
    let OWNER = _vocab "OWNER"
    let PARCELID = _vocab "PARCELID"
    let PARENTID = _vocab "PARENTID"
    let PERCT_GRD = _vocab "PERCT_GRD"
    let PHOTO_FOLDER = _vocab "PHOTO_FOLDER"
    let PHOTO_NUM = _vocab "PHOTO_NUM"
    let PHOTOID = _vocab "PHOTOID"
    let PID_1 = _vocab "PID_1"
    let PIPESHAPE = _vocab "PIPESHAPE"
    let PLACE = _vocab "PLACE"
    let POND_ID = _vocab "POND_ID"
    let PONDID = _vocab "PONDID"
    let PONDTYPE = _vocab "PONDTYPE"
    let PONDYR = _vocab "PONDYR"
    let PRFRESOLUTION = _vocab "PRFRESOLUTION"
    let RAW_NAME = _vocab "RAW_NAME"
    let RELATEDFEATURE = _vocab "RELATEDFEATURE"
    let ROTATION_AZ = _vocab "ROTATION_AZ"
    let SHAPE = _vocab "SHAPE"
    let SHAPE_Area = _vocab "SHAPE_Area"
    let SHAPE_Length = _vocab "SHAPE_Length"
    let SLOT_ELEV = _vocab "SLOT_ELEV"
    let SOURCE = _vocab "SOURCE"
    let SOURCEYEAR = _vocab "SOURCEYEAR"
    let STORAGE_FULL_PATH_ADDR = _vocab "STORAGE_FULL_PATH_ADDR"
    let STORAGE_PATH_ADDR = _vocab "STORAGE_PATH_ADDR"
    let STORAGE_STATIC_PATH_ADDR = _vocab "STORAGE_STATIC_PATH_ADDR"
    let STRCT_DEPTH = _vocab "STRCT_DEPTH"
    let STRUCTURE_ID = _vocab "STRUCTURE_ID"
    let STRUCTUREID = _vocab "STRUCTUREID"
    let STRUCTURETYPE = _vocab "STRUCTURETYPE"
    let SUBTYPEFIELD = _vocab "SUBTYPEFIELD"
    let SURFACETYPE = _vocab "SURFACETYPE"
    let UNDERDRAINS = _vocab "UNDERDRAINS"
    let UNITDESC = _vocab "UNITDESC"
    let UPDATESOURCE = _vocab "UPDATESOURCE"
    let UPSTREAM_DEPTH = _vocab "UPSTREAM_DEPTH"
    let UPSTREAM_ELEV = _vocab "UPSTREAM_ELEV"
    let UPSTREAMDEPTH = _vocab "UPSTREAMDEPTH"
    let UPSTREAMELEVATION = _vocab "UPSTREAMELEVATION"
    let UPSTREAMSTUCTUREID = _vocab "UPSTREAMSTUCTUREID"
    let VIEW_ = _vocab "VIEW_"
    let WATERBODYNAME = _vocab "WATERBODYNAME"
    let WBID = _vocab "WBID"
    let WHOCREATED = _vocab "WHOCREATED"
    let WHOMODIFIED = _vocab "WHOMODIFIED"
    let WIDTH = _vocab "WIDTH"
    let Z29 = _vocab "Z29"
    let ZVALUE = _vocab "ZVALUE"
    let UNITID = _vocab "UNITID"
    let Feature = _vocab "Feature"
    let Facility = _vocab "Facility"
    let Outfall = _vocab "Outfall"
    let Upstream_Structure = _vocab "Upstream_Structure"
    let Downstream_Structure = _vocab "Downstream_Structure"
    let Structure = _vocab "Structure"
    let Pond = _vocab "Pond"
    let Feature_Layer = _vocab "Feature_Layer"
    let Feature_Class = _vocab "Feature_Class"
    let parent = _vocab "parent"
    let subLayer = _vocab "subLayer"
    let outfall = _vocab "outfall"
    let upstream_structure = _vocab "upstream_structure"
    let structure = _vocab "structure"
    let downstream_structure = _vocab "downstream_structure"
    let currentVersion = _vocab "currentVersion"
    let serviceDescription = _vocab "serviceDescription"
    let mapName = _vocab "mapName"
    let description = _vocab "description"
    let copyrightText = _vocab "copyrightText"
    let supportsDynamicLayers = _vocab "supportsDynamicLayers"
    let layers = _vocab "layers"
    let layer = _vocab "layer"
    let tables = _vocab "tables"
    let table = _vocab "table"
    let spatialReference = _vocab "spatialReference"
    let singleFusedMapCache = _vocab "singleFusedMapCache"
    let initialExtent = _vocab "initialExtent"
    let fullExtent = _vocab "fullExtent"
    let minScale = _vocab "minScale"
    let maxScale = _vocab "maxScale"
    let units = _vocab "units"
    let supportedImageFormatTypes = _vocab "supportedImageFormatTypes"
    let supportedImageFormatType = _vocab "supportedImageFormatType"
    let documentInfo = _vocab "documentInfo"
    let capabilities = _vocab "capabilities"
    let supportedQueryFormats = _vocab "supportedQueryFormats"
    let exportTilesAllowed = _vocab "exportTilesAllowed"
    let referenceScale = _vocab "referenceScale"
    let supportsDatumTransformation = _vocab "supportsDatumTransformation"
    let maxRecordCount = _vocab "maxRecordCount"
    let maxImageHeight = _vocab "maxImageHeight"
    let maxImageWidth = _vocab "maxImageWidth"
    let supportedExtensions = _vocab "supportedExtensions"
    let culture = _vocab "culture"
    let name = _vocab "name"
    let guid = _vocab "guid"
    let catalogPath = _vocab "catalogPath"
    let snippet = _vocab "snippet"
    let summary = _vocab "summary"
    let title = _vocab "title"
    let tags = _vocab "tags"
    let ``type`` = _vocab "type"
    let typeKeywords = _vocab "typeKeywords"
    let thumbnail = _vocab "thumbnail"
    let url = _vocab "url"
    let extent = _vocab "extent"
    let accessInformation = _vocab "accessInformation"
    let licenseInfo = _vocab "licenseInfo"
    let Keyword = _vocab "Keyword"
    let Keywords = _vocab "Keywords"
    let capability = _vocab "capability"
    let supportedQueryFormat = _vocab "supportedQueryFormat"
    let Map_Service = _vocab "Map_Service"
    let parentLayerId = _vocab "parentLayerId"
    let defaultVisibility = _vocab "defaultVisibility"
    let hasAttachments = _vocab "hasAttachments"
    let htmlPopupType = _vocab "htmlPopupType"
    let canModifyLayer = _vocab "canModifyLayer"
    let canScaleSymbols = _vocab "canScaleSymbols"
    let hasLabels = _vocab "hasLabels"
    let supportsStatistics = _vocab "supportsStatistics"
    let supportsAdvancedQueries = _vocab "supportsAdvancedQueries"
    let isDataVersioned = _vocab "isDataVersioned"
    let useStandardizedQueries = _vocab "useStandardizedQueries"
    let supportsCoordinatesQuantization = _vocab "supportsCoordinatesQuantization"
    let id = _vocab "id"
    let geometryType = _vocab "geometryType"
    let displayField = _vocab "displayField"
    let count = _vocab "count"
    let displayFieldName = _vocab "displayFieldName"
    let exceededTransferLimit = _vocab "exceededTransferLimit"
    let hasZ = _vocab "hasZ"
    let field = _vocab "field"
    let domain = _vocab "domain"
    let feature = _vocab "feature"
    let x = _vocab "x"
    let y = _vocab "y"




module dbug =
    let _namespace_name =
        lmdb_read_write { return! Lexical_Form.from_string $"{Commonplace.ontology_base}/dbug/" }

    let _prefix (local_name_string: string) (transaction: LightningTransaction) =
        let local_name =
            Lexical_Form.from_string (local_name_string.Replace("\\", "-").low_lined) transaction

        RDF_Term.from_namespaced_iri
            { namespace_name_id = _namespace_name.lexical_form_id
              local_name_id = local_name.lexical_form_id }
            transaction

    let _vocab (local_name_string: string) =
        lmdb_read_write {
            let! local_name = Lexical_Form.from_string local_name_string.low_lined

            return!
                RDF_Term.from_namespaced_iri
                    { namespace_name_id = _namespace_name.lexical_form_id
                      local_name_id = local_name.lexical_form_id }
        }


    let _graph = _vocab ""






















(*
Oak() {
AnonymousModule() {

    Json(LCPW_OverlayStormwaterInfrastructure_D_WM.json.JsonValue.ToString())
}
}
|> Gen.mkOak
|> Gen.run
|> printfn "%s"

*)
(*
type ParentLayer = { id: int; name: string }
type SubLayersItem = { id: int; name: string }
type SpatialReference = { wkid: int; latestWkid: int }

type Extent =
{ xmin: float
  ymin: float
  xmax: float
  ymax: float
  spatialReference: SpatialReference }

type FieldsItem =
{ name: string
  ``type``: string
  alias: string
  domain: obj option
  length: int option }

type GeometryField = { }
type OwnershipBasedAccessControlForFeatures = { allowOthersToQuery: bool }

type AdvancedQueryCapabilities =
{ useStandardizedQueries: bool
  supportsStatistics: bool
  supportsHavingClause: bool
  supportsCountDistinct: bool
  supportsOrderBy: bool
  supportsDistinct: bool
  supportsPagination: bool
  supportsTrueCurve: bool
  supportsReturningQueryExtent: bool
  supportsQueryWithDistance: bool
  supportsSqlExpression: bool }

type SourceSpatialReference = { wkid: int; latestWkid: int }

type Symbol =
{ ``type``: string
  url: string
  imageData: string
  contentType: string
  width: int
  height: int
  angle: int
  xoffset: int
  yoffset: int }

type UniqueValueInfosItem =
{ symbol: Symbol
  value: string
  label: string
  description: string }

type Renderer =
{ ``type``: string
  field1: string
  field2: obj
  field3: obj
  defaultSymbol: obj
  defaultLabel: obj
  uniqueValueInfos: UniqueValueInfosItem list
  fieldDelimiter: string }

type DrawingInfo =
{ renderer: Renderer
  transparency: int
  labelingInfo: obj }

type FieldAliases =
{ OBJECTID: string
  FACILITYID: string
  ATTACHEDTOID: string
  UPSTREAMSTUCTUREID: string
  OUTFALLTYPE: string
  WATERBODYNAME: string
  WBID: string
  DRAINAGEBASIN: string
  NOTES: string
  GLOBALID: string
  STRUCTURETYPE: string
  OUTFALLID: string
  UNITID: string }

type Attributes =
{ OBJECTID: int
  FACILITYID: string
  ATTACHEDTOID: string
  UPSTREAMSTUCTUREID: string
  OUTFALLTYPE: string
  WATERBODYNAME: string
  WBID: obj
  DRAINAGEBASIN: string
  NOTES: string
  GLOBALID: string
  STRUCTURETYPE: string
  OUTFALLID: string
  UNITID: string }

type Geometry = { x: float; y: float }

type FeaturesItem =
{ attributes: Attributes
  geometry: Geometry }

type LayersItem =
{ id: int
  name: string
  parentLayerId: int
  defaultVisibility: bool
  subLayerIds: int list option
  minScale: int
  maxScale: int
  ``type``: string
  currentVersion: float
  description: string
  geometryType: string option
  copyrightText: string
  parentLayer: ParentLayer option
  subLayers: SubLayersItem list
  extent: Extent
  hasAttachments: bool
  htmlPopupType: string
  displayField: string
  typeIdField: obj option
  subtypeFieldName: obj option
  subtypeField: obj option
  defaultSubtypeCode: obj option
  fields: FieldsItem list option
  geometryField: GeometryField
  indexes: obj list
  subtypes: obj list
  relationships: obj list
  canModifyLayer: bool
  canScaleSymbols: bool
  hasLabels: bool
  capabilities: string
  supportsStatistics: bool
  supportsAdvancedQueries: bool
  supportedQueryFormats: string
  isDataVersioned: bool
  ownershipBasedAccessControlForFeatures: OwnershipBasedAccessControlForFeatures
  useStandardizedQueries: bool
  advancedQueryCapabilities: AdvancedQueryCapabilities
  supportsCoordinatesQuantization: bool
  sourceSpatialReference: SourceSpatialReference option
  drawingInfo: DrawingInfo option
  maxRecordCount: int option
  supportsDatumTransformation: bool option
  count: int option
  displayFieldName: string option
  fieldAliases: FieldAliases option
  spatialReference: SpatialReference option
  features: FeaturesItem list option
  dateFieldsTimeReference: obj option
  exceededTransferLimit: bool option
  hasZ: bool option }

type InitialExtent =
{ xmin: float
  ymin: float
  xmax: float
  ymax: float
  spatialReference: SpatialReference }

type FullExtent =
{ xmin: float
  ymin: float
  xmax: float
  ymax: float
  spatialReference: SpatialReference }

type DocumentInfo =
{ Title: string
  Author: string
  Comments: string
  Subject: string
  Category: string
  AntialiasingMode: string
  TextAntialiasingMode: string
  Keywords: string }

type Root =
{ currentVersion: float
  serviceDescription: string
  mapName: string
  description: string
  copyrightText: string
  supportsDynamicLayers: bool
  layers: LayersItem list
  tables: obj list
  spatialReference: string
  singleFusedMapCache: bool
  initialExtent: InitialExtent
  fullExtent: FullExtent
  minScale: float
  maxScale: int
  units: string
  supportedImageFormatTypes: string
  documentInfo: DocumentInfo
  capabilities: string
  supportedQueryFormats: string
  exportTilesAllowed: bool
  referenceScale: int
  supportsDatumTransformation: bool
  maxRecordCount: int
  maxImageHeight: int
  maxImageWidth: int
  supportedExtensions: string
  culture: string
  name: string
  guid: string
  catalogPath: string
  snippet: string
  summary: string
  title: string
  tags: string list
  ``type``: string
  typeKeywords: string list
  thumbnail: string
  url: string
  extent: float list list
  accessInformation: string
  licenseInfo: string }


*)





























































let DomainNames =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.collect (fun Layer ->

        Layer.Fields
        |> Array.Parallel.choose (fun Field -> Field.Domain)
        |> Array.Parallel.map (fun Domain -> Domain.Name)

    )
    // TODO ask GIS what happend to domain data from the feature layer
    |> Array.append [|

                       "dDomainInletMaterial"
                       "dDomainEndPointMaterial"
                       "dDomainJunctionMaterial"
                       "dDomainDitchSurfType"

                        |]
    |> Array.distinct



let FieldName'DomainNames =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.collect (fun Layer ->

        Layer.Fields
        |> Array.Parallel.filter (fun Field -> Field.Domain.IsSome)
        |> Array.Parallel.map (fun Field -> Normalize.field Field.Name, Field.Domain.Value.Name)

    )
    |> Array.distinct





module Coded_Value_Domain =
    module Literal =
        let domain_name =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for DomainName in DomainNames do
                           (DomainName, RDF_Literal.simple DomainName current_transaction)

                       |]
                    |> Map.ofArray

            }

    module Iri =
        let individual_domain =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for DomainName in DomainNames do
                           (DomainName, swin._prefix DomainName current_transaction)

                       |]
                    |> Map.ofArray

            }



let FieldName'DomainName'CodedValueName'CodedValueCodes =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.collect (fun Layer ->

        Layer.Fields
        |> Array.Parallel.filter (fun Field -> Field.Domain.IsSome)
        |> Array.Parallel.collect (fun Field ->
            let Domain = Field.Domain.Value
            Domain.CodedValues
            |> Array.Parallel.map (fun CodedValue -> (Normalize.field Field.Name, Domain.Name, CodedValue.Name.JsonValue.AsString(), CodedValue.Code.JsonValue.AsString()))

        )

    )
    // TODO ask GIS what happend to domain data from the feature layer
    |> Array.append [|

                       "MATERIAL", "dDomainInletMaterial", "Brick", "BRK"
                       "MATERIAL", "dDomainInletMaterial", "Concrete", "CON"
                       "MATERIAL", "dDomainInletMaterial", "Other", "OTH"
                       "MATERIAL", "dDomainInletMaterial", "Not Assessed", "NA"
                       "MATERIAL", "dDomainInletMaterial", "Unknown", "UNK"
                       "MATERIAL", "dDomainInletMaterial", "SCB", "SCB"

                       "MATERIAL", "dDomainEndPointMaterial", "CONCRETE", "CON"
                       "MATERIAL", "dDomainEndPointMaterial", "BRICK", "BRK"
                       "MATERIAL", "dDomainEndPointMaterial", "RUBBLE ROCK", "RR"
                       "MATERIAL", "dDomainEndPointMaterial", "SAND CEMENT BAG", "SCB"
                       "MATERIAL", "dDomainEndPointMaterial", "DIRT", "DRT"
                       "MATERIAL", "dDomainEndPointMaterial", "OTHER", "OTH"
                       "MATERIAL", "dDomainEndPointMaterial", "NOT ASSESSED", "NA"
                       "MATERIAL", "dDomainEndPointMaterial", "UNKNOWN", "UNK"

                       "MATERIAL", "dDomainJunctionMaterial", "Brick", "BRK"
                       "MATERIAL", "dDomainJunctionMaterial", "PreCast", "PRE"
                       "MATERIAL", "dDomainJunctionMaterial", "Other", "OTH"
                       "MATERIAL", "dDomainJunctionMaterial", "Unknown", "UNK"
                       "MATERIAL", "dDomainJunctionMaterial", "NotAssessed", "NA"
                       "MATERIAL", "dDomainJunctionMaterial", "Concrete", "CON"


                       "SURFACETYPE", "dDomainDitchSurfType", "Rubble Rock", "ROCK"
                       "SURFACETYPE", "dDomainDitchSurfType", "Grass", "GRASS"
                       "SURFACETYPE", "dDomainDitchSurfType", "Dirt", "DIRT"
                       "SURFACETYPE", "dDomainDitchSurfType", "Sand Cement Bags", "SAND"
                       "SURFACETYPE", "dDomainDitchSurfType", "Fabri Form", "FABRI"
                       "SURFACETYPE", "dDomainDitchSurfType", "Gabion", "GAB"
                       "SURFACETYPE", "dDomainDitchSurfType", "Concrete", "CON"
                       "SURFACETYPE", "dDomainDitchSurfType", "Other", "OTH"
                       "SURFACETYPE", "dDomainDitchSurfType", "Unknown", "UNK"
                       "SURFACETYPE", "dDomainDitchSurfType", "Not Assessed", "NA"

                        |]
    |> Array.distinct




(*


FieldName'DomainName'CodedValueName'CodedValueCodes
|> Array.Parallel.filter (fun (FieldName, DomainName, CodedValueName, CodedValueCode) -> DomainName = "dDomainMaintBy")

LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun Layer ->

    Layer.Features
    |> Array.Parallel.map (fun Feature -> Feature.Attributes.Filterlocation.JsonValue.AsString())
    |> Array.filter is_not_nullish

)
|> Array.distinct
*)

module Coded_Value =

    module Iri =
        let individual_coded_value_by_DomainName'CodedValueName =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for FieldName, DomainName, CodedValueName, CodedValueCode in FieldName'DomainName'CodedValueName'CodedValueCodes do
                           ((DomainName, CodedValueName), swin._prefix $"{DomainName}.{CodedValueName}" current_transaction)

                       |]
                    |> Map.ofArray

            }

        let individual_coded_value_by_FieldName'CodedValueCode =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for FieldName, DomainName, CodedValueName, CodedValueCode in FieldName'DomainName'CodedValueName'CodedValueCodes do
                           ((FieldName, CodedValueCode), swin._prefix $"{DomainName}.{CodedValueName}" current_transaction)

                       |]
                    |> Map.ofArray

            }

    module Literal =

        let name =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for FieldName, DomainName, CodedValueName, CodedValueCode in FieldName'DomainName'CodedValueName'CodedValueCodes do
                           (CodedValueName, RDF_Literal.simple CodedValueName current_transaction)

                       |]
                    |> Map.ofArray

            }

        let code =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for FieldName, DomainName, CodedValueName, CodedValueCode in FieldName'DomainName'CodedValueName'CodedValueCodes do
                           (CodedValueCode, RDF_Literal.simple CodedValueCode current_transaction)

                       |]
                    |> Map.ofArray

            }








let FeatureLayer_Name'Abstract =
    XRay.LCG_Stormwater_Inventory.xml.WorkspaceDefinition.DatasetDefinitions.DataElements
    |> Array.Parallel.collect (fun FeatureDataset ->

        FeatureDataset.Children.DataElements
        |> Array.Parallel.choose (fun FeatureClass ->

            match FeatureClass.Metadata.XmlDoc.Metadata.Idinfo with
            | Some idinfo ->
                match idinfo.Descript with
                | Some descript when descript.Abstract.IsSome ->
                    let feature_layer_name = layer_name_by_FeatureClass'Name[FeatureClass.Name]
                    Some(feature_layer_name, descript.Abstract.Value)
                | _ -> None
            | None -> None

        )

    )
    |> Array.distinct


let ChildLayerName'ParentLayerName'ParentLayerId =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.choose (fun Layer ->

        if Layer.ParentLayer.IsSome then
            Some(Layer.Name, Layer.ParentLayer.Value.Name, Layer.ParentLayer.Value.Id)
        else
            None

    )
    |> Array.distinct


module Feature_Layer =
    let Ids =
        LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
        |> Array.Parallel.map (fun Layer -> Layer.Id)
        |> Array.distinct

    let Names =
        LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
        |> Array.Parallel.map (fun Layer -> Layer.Name)
        |> Array.distinct

    let Types =
        LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
        |> Array.Parallel.map (fun Layer -> Layer.Type)
        |> Array.distinct

    let GeometryTypes =
        LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
        |> Array.Parallel.choose (fun Layer -> Layer.GeometryType)
        |> Array.distinct

    let CurrentVersions =
        LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
        |> Array.Parallel.map (fun Layer -> Layer.CurrentVersion)
        |> Array.distinct

    let Counts =
        LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
        |> Array.Parallel.choose (fun Layer -> Layer.Count)
        |> Array.distinct

    module Literal =
        let id =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Id in Ids do
                           (Id, RDF_Literal.datatyped $"{Id}" xsd.int current_transaction)

                       |]
                    |> Map.ofArray

            }

        let name =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Name in Names do
                           (Name, RDF_Literal.simple Name current_transaction)

                       |]
                    |> Map.ofArray

            }

        let current_version =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for CurrentVersion in CurrentVersions do
                           (CurrentVersion, RDF_Literal.autotyped CurrentVersion current_transaction)

                       |]
                    |> Map.ofArray

            }

        let count =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Count in Counts do
                           (Count, RDF_Literal.autotyped Count current_transaction)

                       |]
                    |> Map.ofArray

            }

        let abstract_description =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Name, Abstract in FeatureLayer_Name'Abstract do
                           (Name, RDF_Literal.US Abstract current_transaction)

                       |]
                    |> Map.ofArray

            }

    module Iri =
        let feature_layer_by_Name =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Layer in LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers do
                           (Layer.Name, swin._prefix $"{Layer.Name}_Feature_Layer" current_transaction)

                       |]
                    |> Map.ofArray

            }

        let layer_owl_class =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Layer in LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers do
                           (Layer.Name, swin._prefix $"{Layer.Name}_Feature" current_transaction)

                       |]
                    |> Map.ofArray

            }

        let layer_type =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Type in Types do
                           (Type, swin._prefix Type current_transaction)

                       |]
                    |> Map.ofArray

            }

        let geometry_type =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for GeometryType in GeometryTypes do
                           (GeometryType, swin._prefix GeometryType current_transaction)

                       |]
                    |> Map.ofArray

            }




// TODO consider ontolex concept mapping
// TODO let GIS know subtypes are missing from interraster feature layers
(*
let LayerName'Stcode'Stname =
XRay.LCG_Stormwater_Inventory.xml.WorkspaceDefinition.DatasetDefinitions.DataElements
|> Array.Parallel.collect (fun FeatureDataset ->

    FeatureDataset.Children.DataElements
    |> Array.Parallel.choose (fun FeatureClass ->

        match FeatureClass.Metadata.XmlDoc.Metadata.Eainfo with
        | Some idinfo ->
            let Details =
                idinfo.Detaileds
                |> Array.Parallel.collect (fun Detailed ->
                    Detailed.Subtypes
                    |> Array.Parallel.map (fun Subtype ->
                        let layer_name = layer_name_by_FeatureClass'Name[FeatureClass.Name]

                        (layer_name, Subtype.Stcode.Value, Subtype.Stname.Value))

                )

            if Details.Length > 0 then
                Some(Details)
            else
                None

        | None -> None

    )
    |> Array.Parallel.collect (fun Detail -> Detail)

)
|> Array.distinct

module Subtype =
module Literal =
    let subtype_name =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for Layer'Name, Stcode, Stname in LayerName'Stcode'Stname do
                       let! subtype_name = RDF_Literal.simple Stname current_transaction
                       ($"{Layer'Name}.{Stcode}", subtype_name)

                   |]
                |> Map.ofArray

        }

module Iri =
    let individual_subtype_by_Layer'Stcode =


        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for Layer'Name, Stcode, Stname in LayerName'Stcode'Stname do
                       let! subtype = interraster._prefix $"{Layer'Name}.{Stname}" current_transaction
                       ($"{Layer'Name}.{Stcode}", subtype)

                   |]
                |> Map.ofArray

        }

    let subtype_owl_class_by_Layer'Stcode =


        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for Layer'Name, Stcode, Stname in LayerName'Stcode'Stname do
                       let! subtype = interraster._Feature $"{Layer'Name}.{Stname}" current_transaction
                       ($"{Layer'Name}.{Stcode}", subtype)

                   |]
                |> Map.ofArray

        }

*)

let LayerName'SubtypeCode'SubtypeName =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.collect (fun Layer ->
        Layer.Subtypes
        |> Array.Parallel.map (fun Subtype -> (Layer.Name, Subtype.Code, Subtype.Name)))

module Subtype =
    let iri =

        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for LayerName, SubtypeCode, SubtypeName in LayerName'SubtypeCode'SubtypeName do
                       ((LayerName, SubtypeCode), swin._prefix $"{LayerName}.{SubtypeName}" current_transaction)

                   |]
                |> Map.ofArray

        }

    let name =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for LayerName, SubtypeCode, SubtypeName in LayerName'SubtypeCode'SubtypeName do
                       ((LayerName, SubtypeCode), RDF_Literal.US SubtypeName current_transaction)

                   |]
                |> Map.ofArray

        }

let FieldName'FieldDomain =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.collect (fun Layer ->

        Layer.Fields
        |> Array.Parallel.choose (fun Field ->
            if Field.Domain.IsSome then
                Some(Normalize.field Field.Name, Field.Domain.Value.Name)
            else
                None

        )

    )
    |> Array.distinct



module Layer_Field =
    let FieldNames =
        LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
        |> Array.Parallel.collect (fun Layer ->
            Layer.Fields
            |> Array.map (fun Field -> Normalize.field Field.Name))
        |> Array.distinct
        |> Array.append [| "x"; "y" |]

    let FieldMonikers =
        LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
        |> Array.Parallel.collect (fun Layer ->
            Layer.Fields
            |> Array.map (fun Field -> Layer.Name, Normalize.field Field.Name)
            |> Array.append [| Layer.Name, "x"
                               Layer.Name, "y" |])
        |> Array.distinct

    let FieldTypes =
        LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
        |> Array.Parallel.collect (fun Layer ->

            Layer.Fields
            |> Array.map (fun Field -> Field.Type))
        |> Array.distinct

    module Iri =
        let super_field =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for FieldName in FieldNames do
                           (FieldName, swin._prefix FieldName current_transaction)

                       |]
                    |> Map.ofArray

            }

        let layer_field =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for LayerName, FieldName in FieldMonikers do
                           let moniker = $"{LayerName}.{FieldName}"
                           (moniker, swin._prefix moniker current_transaction)

                       |]
                    |> Map.ofArray

            }

        let field_type =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for FieldType in FieldTypes do
                           (FieldType, swin._prefix FieldType current_transaction)

                       |]
                    |> Map.ofArray

            }

    module Literal =
        let name =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for FieldName in FieldNames do
                           (FieldName, RDF_Literal.simple FieldName current_transaction)

                       |]
                    |> Map.ofArray

            }





let FieldName'FieldAlias =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.collect (fun layer ->

        layer.Fields
        |> Array.Parallel.filter (fun field -> Normalize.field field.Name <> field.Alias)
        |> Array.map (fun field -> Normalize.field field.Name, field.Alias))
    |> Array.distinct


let FieldName'DomainName =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.collect (fun layer ->

        layer.Fields
        |> Array.Parallel.choose (fun field ->
            if field.Domain.IsSome then
                Some(field)
            else
                None

        )
        |> Array.map (fun field -> Normalize.field field.Name, field.Domain.Value.Name))
    |> Array.distinct

























































[<Struct>]
type Esri_Feature =
    { LayerName: string

      Unitid: Option<string>
      Globalid: Option<Guid>


      Attachedtoid: Option<string>
      Facilityid: Option<string>
      HydId: Option<string>
      Outfallid: Option<string>
      Parentid: Option<string>
      StructureId: Option<string>
      Upstreamstuctureid: Option<string>

      Description: Option<string>
      Diameter: Option<int>
      DownstreamDepth: Option<decimal>
      DownstreamElevation: Option<decimal>
      Drainagebasin: Option<string>
      Filterlocation: Option<string>
      Filtertype: Option<string>
      Height: Option<decimal>
      InvertElevation: Option<decimal>
      Lfeet: Option<decimal>
      LocationDescription: Option<string>
      Maintby: Option<string>
      Material: Option<string>
      Notes: Option<string>
      NumBarrels: Option<int>
      Outfalltype: Option<string>
      Owner: Option<string>
      Pipeshape: Option<string>
      Pondtype: Option<string>
      Pondyr: Option<int>
      Relatedfeature: Option<string>
      SlotElev: Option<decimal>
      StrctDepth: Option<decimal>
      Structuretype: Option<string>
      Subtypefield: Option<int>
      Surfacetype: Option<string>
      UpstreamDepth: Option<decimal>
      UpstreamElevation: Option<decimal>
      Waterbodyname: Option<string>
      Width: Option<decimal>
      X: Option<float>
      Y: Option<float>
      Zvalue: Option<decimal>

     }

let Features =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.collect (fun Layer ->
        Layer.Features
        |> Array.Parallel.map (fun Feature ->
            let StructureId =

                try
                    match Feature.Attributes.Structureid.Number with
                    | Some structure_id when string structure_id |> is_not_nullish -> Some(string structure_id)
                    | _ -> None

                with
                | _ ->
                    match Feature.Attributes.Structureid.String with
                    | Some structure_id when structure_id |> is_not_nullish -> Some(structure_id)
                    | _ -> None

            let Filterlocation =

                try
                    Feature.Attributes.Filterlocation.String
                with
                | _ -> None

            let Notes =

                try
                    if Feature.Attributes.Notes.Number.IsSome then
                        Some(string Feature.Attributes.Notes.Number.Value)
                    else
                        Feature.Attributes.Notes.String


                with
                | _ -> Feature.Attributes.Notes.String

            let Pondyr =

                try
                    if Feature.Attributes.Pondyr.Number.IsSome then
                        Feature.Attributes.Pondyr.Number
                    else
                        None


                with
                | _ -> None

            let Relatedfeature =

                try
                    Feature.Attributes.Relatedfeature.String

                with
                | _ -> None

            let DownstreamDepth =
                if Feature.Attributes.DownstreamDepth.IsSome then
                    Feature.Attributes.DownstreamDepth
                else
                    Feature.Attributes.Downstreamdepth

            let DownstreamElevation =
                if Feature.Attributes.Downstreamelevation.IsSome then
                    Feature.Attributes.Downstreamelevation
                else
                    Feature.Attributes.DownstreamElev

            let InvertElevation =
                if Feature.Attributes.InvertElev.IsSome then
                    Feature.Attributes.InvertElev
                else
                    Feature.Attributes.Invertelev

            let LocationDescription =
                if Feature.Attributes.LocDesc.IsSome then
                    Feature.Attributes.LocDesc
                else
                    Feature.Attributes.Location

            let UpstreamElevation =
                if Feature.Attributes.Upstreamelevation.IsSome then
                    Feature.Attributes.Upstreamelevation
                else
                    Feature.Attributes.UpstreamElev

            let Facilityid =
                match Feature.Attributes.Facilityid with
                | Some facility_id when facility_id |> is_not_nullish -> Some(facility_id)
                | _ -> None

            let Attachedtoid =
                match Feature.Attributes.Attachedtoid with
                | Some attachedto_id when attachedto_id |> is_not_nullish -> Some(attachedto_id)
                | _ -> None

            let Outfallid =
                match Feature.Attributes.Outfallid with
                | Some outfall_id when outfall_id |> is_not_nullish -> Some(outfall_id)
                | _ -> None

            let Parentid =
                match Feature.Attributes.Parentid with
                | Some parent_id when parent_id |> is_not_nullish -> Some(parent_id)
                | _ -> None

            let Upstreamstuctureid =
                match Feature.Attributes.Upstreamstuctureid with
                | Some upstreamstucture_id when upstreamstucture_id |> is_not_nullish -> Some(upstreamstucture_id)
                | _ -> None

            let Diameter =
                match Feature.Attributes.Diameter with
                | Some diameter when diameter <> 0 -> Some(diameter)
                | _ -> None

            {

              LayerName = Layer.Name
              Attachedtoid = Attachedtoid
              Description = Feature.Attributes.Description
              Diameter = Diameter
              DownstreamDepth = DownstreamDepth
              DownstreamElevation = DownstreamElevation
              Drainagebasin = Feature.Attributes.Drainagebasin
              Facilityid = Facilityid
              Filterlocation = Filterlocation
              Filtertype = Feature.Attributes.Filtertype
              Globalid = Feature.Attributes.Globalid
              Height = Feature.Attributes.Height
              HydId = Feature.Attributes.HydId
              InvertElevation = InvertElevation
              Lfeet = Feature.Attributes.Lfeet
              LocationDescription = LocationDescription
              Maintby = Feature.Attributes.Maintby
              Material = Feature.Attributes.Material
              Notes = Notes
              NumBarrels = Feature.Attributes.NumBarrels
              Outfallid = Outfallid
              Outfalltype = Feature.Attributes.Outfalltype
              Owner = Feature.Attributes.Owner
              Parentid = Parentid
              Pipeshape = Feature.Attributes.Pipeshape
              Pondtype = Feature.Attributes.Pondtype
              Pondyr = Pondyr
              Relatedfeature = Relatedfeature
              SlotElev = Feature.Attributes.SlotElev
              StrctDepth = Feature.Attributes.StrctDepth
              StructureId = StructureId
              Structuretype = Feature.Attributes.Structuretype
              Subtypefield = Feature.Attributes.Subtypefield
              Surfacetype = Feature.Attributes.Surfacetype
              Unitid = Feature.Attributes.Unitid
              UpstreamDepth = Feature.Attributes.UpstreamDepth
              UpstreamElevation = UpstreamElevation
              Upstreamstuctureid = Upstreamstuctureid
              Waterbodyname = Feature.Attributes.Waterbodyname
              Width = Feature.Attributes.Width
              X = Feature.Geometry.X
              Y = Feature.Geometry.Y
              Zvalue = Feature.Attributes.Zvalue


            }

        ))
    |> Array.distinct

let Features_with_Unitid =

    Features
    |> Array.Parallel.choose (fun Feature ->
        if Feature.Unitid.IsSome then
            Some(Feature)
        else
            None)
    |> Array.distinct


let Features_with_Globalid =

    Features
    |> Array.Parallel.choose (fun Feature ->
        if Feature.Globalid.IsSome then
            Some(Feature)
        else
            None)
    |> Array.distinct



let Features_with_Unitid_and_Globalid =

    Features
    |> Array.Parallel.choose (fun Feature ->
        if Feature.Unitid.IsSome && Feature.Globalid.IsSome then
            Some(Feature)
        else
            None)
    |> Array.distinct




module Id =
    let Unitids =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Unitid)
        |> Array.distinct

    let Globalids =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Globalid)
        |> Array.distinct

    let Facilityids =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Facilityid)
        |> Array.distinct

    let Attachedtoids =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Attachedtoid)
        |> Array.distinct

    let Outfallids =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Outfallid)
        |> Array.distinct

    let HydIds =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.HydId)
        |> Array.distinct

    let Parentids =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Parentid)
        |> Array.distinct

    let Structureids =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.StructureId)
        |> Array.distinct

    let Upstreamstuctureids =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Upstreamstuctureid)
        |> Array.distinct

    module Literal =
        let unit_id =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Unitid in Unitids do
                           (Unitid, RDF_Literal.simple Unitid current_transaction)

                       |]
                    |> Map.ofArray

            }

        let global_id =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Globalid in Globalids do
                           let GLOBALID = Globalid.ToString().ToUpper()
                           (Globalid, RDF_Literal.datatyped GLOBALID xsd.ID current_transaction)

                       |]
                    |> Map.ofArray

            }

        let facility_id =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Facilityid in Facilityids do
                           (Facilityid, RDF_Literal.autotyped Facilityid current_transaction)

                       |]
                    |> Map.ofArray

            }

        let outfall_id =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Outfallid in Outfallids do
                           (Outfallid, RDF_Literal.simple Outfallid current_transaction)

                       |]
                    |> Map.ofArray

            }

        let hyd_id =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for HydId in HydIds do
                           (HydId, RDF_Literal.simple HydId current_transaction)

                       |]
                    |> Map.ofArray

            }

        let structure_id =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Structureid in Structureids do
                           (Structureid, RDF_Literal.simple Structureid current_transaction)

                       |]
                    |> Map.ofArray

            }

        let upstream_structure_id =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Upstreamstuctureid in Upstreamstuctureids do
                           (Upstreamstuctureid, RDF_Literal.simple Upstreamstuctureid current_transaction)

                       |]
                    |> Map.ofArray
            }

    module Iri =
        let individual_feature_by_Unitid =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Unitid in Unitids do
                           (Unitid, swin._prefix Unitid current_transaction)

                       |]
                    |> Map.ofArray

            }

        let individual_feature_by_Globalid =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Globalid in Globalids do
                           (Globalid, swin._prefix $"{Globalid.ToString().ToUpper()}" current_transaction)

                       |]
                    |> Map.ofArray

            }

        let individual_facility =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Facilityid in Facilityids do
                           (Facilityid, swin._prefix Facilityid current_transaction)

                       |]
                    |> Map.ofArray

            }

        let individual_feature_by_Attachedtoid =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Attachedtoid in Attachedtoids do
                           (Attachedtoid, swin._prefix $"{Attachedtoid}" current_transaction)

                       |]
                    |> Map.ofArray

            }

        let individual_outfall =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Outfallid in Outfallids do
                           (Outfallid, swin._prefix Outfallid current_transaction)

                       |]
                    |> Map.ofArray

            }

        let individual_hyd =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for HydId in HydIds do
                           (HydId, swin._prefix HydId current_transaction)

                       |]
                    |> Map.ofArray

            }

        let individual_parent =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Parentid in Parentids do
                           (Parentid, swin._prefix Parentid current_transaction)

                       |]
                    |> Map.ofArray

            }

        let individual_structure =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Structureid in Structureids do
                           (Structureid, swin._prefix Structureid current_transaction)

                       |]
                    |> Map.ofArray

            }

        let individual_upstream_structure =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Upstreamstuctureid in Upstreamstuctureids do
                           (Upstreamstuctureid, swin._prefix Upstreamstuctureid current_transaction)

                       |]
                    |> Map.ofArray

            }



module Coordinate =

    let Xs =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.X)
        |> Array.distinct

    let Ys =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Y)
        |> Array.distinct

    let Zs =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Zvalue)
        |> Array.distinct

    module Literal =
        let x =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for X in Xs do
                           (X, RDF_Literal.autotyped X current_transaction)

                       |]
                    |> Map.ofArray

            }

        let y =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Y in Ys do
                           (Y, RDF_Literal.autotyped Y current_transaction)

                       |]
                    |> Map.ofArray

            }

        let z =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Z in Zs do
                           (Z, RDF_Literal.autotyped Z current_transaction)

                       |]
                    |> Map.ofArray

            }

module Attribute =
    let Descriptions =

        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Description)
        |> Array.Parallel.filter is_not_nullish
        |> Array.distinct

    let Diameters =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Diameter)
        |> Array.distinct

    let DownstreamDepths =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.DownstreamDepth)
        |> Array.distinct

    let DownstreamElevations =

        Features
        |> Array.Parallel.choose (fun Feature -> Feature.DownstreamElevation)
        |> Array.distinct

    let DrainageBasins =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Drainagebasin)
        |> Array.distinct

    let Filterlocations =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Filterlocation)
        |> Array.distinct

    let Filtertypes =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Filtertype)
        |> Array.distinct

    let Heights =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Height)
        |> Array.distinct

    let InvertElevations =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.InvertElevation)
        |> Array.distinct

    let Lfeets =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Lfeet)
        |> Array.distinct

    let LocationDescriptions =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.LocationDescription)
        |> Array.distinct

    let Maintbys =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Maintby)
        |> Array.distinct
        |> Array.map Normalize.maint_by

    let Materials =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Material)
        |> Array.distinct
        |> Array.map Normalize.material

    let Notes =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Notes)
        |> Array.distinct

    let NumBarrels =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.NumBarrels)
        |> Array.distinct

    let Outfalltypes =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Outfalltype)
        |> Array.distinct

    let Owners =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Owner)
        |> Array.distinct
        |> Array.map Normalize.owner

    let Pipeshapes =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Pipeshape)
        |> Array.distinct
        |> Array.map Normalize.pipe_shape

    let Pondtypes =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Pondtype)
        |> Array.distinct

    let Pondyrs =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Pondyr)
        |> Array.distinct

    let Relatedfeatures =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Relatedfeature)
        |> Array.distinct

    let SlotElevs =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.SlotElev)
        |> Array.distinct

    let StrctDepths =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.StrctDepth)
        |> Array.distinct

    let Structuretypes =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Structuretype)
        |> Array.distinct

    let Subtypefields =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Subtypefield)
        |> Array.distinct

    let Surfacetypes =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Surfacetype)
        |> Array.distinct
        |> Array.map Normalize.surface_type

    let UpstreamDepths =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.UpstreamDepth)
        |> Array.distinct

    let UpstreamElevations =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.UpstreamElevation)
        |> Array.distinct

    let Waterbodynames =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Waterbodyname)
        |> Array.distinct

    let Widths =
        Features
        |> Array.Parallel.choose (fun Feature -> Feature.Width)
        |> Array.distinct

    module Iri =
        let individual_drainage_basin =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for DrainageBasin in DrainageBasins do
                           (DrainageBasin, swin._prefix DrainageBasin current_transaction)

                       |]
                    |> Map.ofArray

            }

        let outfall_type =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Outfalltype in Outfalltypes do
                           (Outfalltype, swin._prefix $"{Outfalltype} Outfall" current_transaction)

                       |]
                    |> Map.ofArray

            }

        let structure_type =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Structuretype in Structuretypes do
                           let local_name =
                               if Structuretype
                                   .ToLowerInvariant()
                                      .Contains("structure") then
                                   Structuretype
                               else
                                   $"{Structuretype} Structure"




                           (Structuretype, swin._prefix local_name current_transaction)

                       |]
                    |> Map.ofArray

            }


    module Literal =
        let description =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Description in Descriptions do
                           (Description, RDF_Literal.US Description current_transaction)

                       |]
                    |> Map.ofArray

            }

        let diameter =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Diameter in Diameters do
                           (Diameter, RDF_Literal.autotyped Diameter current_transaction)

                       |]
                    |> Map.ofArray

            }

        let downstream_depth =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for DownstreamDepth in DownstreamDepths do
                           (DownstreamDepth, RDF_Literal.autotyped DownstreamDepth current_transaction)

                       |]
                    |> Map.ofArray

            }

        let downstream_elevation =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for DownstreamElevation in DownstreamElevations do
                           (DownstreamElevation, RDF_Literal.autotyped DownstreamElevation current_transaction)

                       |]
                    |> Map.ofArray

            }

        let drainage_basin =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for DrainageBasin in DrainageBasins do
                           (DrainageBasin, RDF_Literal.autotyped DrainageBasin current_transaction)

                       |]
                    |> Map.ofArray

            }

        let filter_location =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Filterlocation in Filterlocations do
                           (Filterlocation, RDF_Literal.autotyped Filterlocation current_transaction)

                       |]
                    |> Map.ofArray

            }

        let filter_type =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Filtertype in Filtertypes do
                           (Filtertype, RDF_Literal.autotyped Filtertype current_transaction)

                       |]
                    |> Map.ofArray

            }

        let height =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Height in Heights do
                           (Height, RDF_Literal.autotyped Height current_transaction)

                       |]
                    |> Map.ofArray

            }

        let invert_elevation =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for InvertElevation in InvertElevations do
                           (InvertElevation, RDF_Literal.autotyped InvertElevation current_transaction)

                       |]
                    |> Map.ofArray

            }

        let l_feet =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Lfeet in Lfeets do
                           (Lfeet, RDF_Literal.autotyped Lfeet current_transaction)

                       |]
                    |> Map.ofArray

            }

        let location_description =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for LocationDescription in LocationDescriptions do
                           (LocationDescription, RDF_Literal.autotyped LocationDescription current_transaction)

                       |]
                    |> Map.ofArray

            }

        let maint_by =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Maintby in Maintbys do
                           (Maintby, RDF_Literal.autotyped Maintby current_transaction)

                       |]
                    |> Map.ofArray

            }

        let material =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Material in Materials do
                           (Material, RDF_Literal.autotyped Material current_transaction)

                       |]
                    |> Map.ofArray

            }

        let notes =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Notes in Notes do
                           (Notes, RDF_Literal.autotyped Notes current_transaction)

                       |]
                    |> Map.ofArray

            }

        let num_barrels =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for NumBarrels in NumBarrels do
                           (NumBarrels, RDF_Literal.autotyped NumBarrels current_transaction)

                       |]
                    |> Map.ofArray

            }

        let outfall_type =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Outfalltype in Outfalltypes do
                           (Outfalltype, RDF_Literal.autotyped Outfalltype current_transaction)

                       |]
                    |> Map.ofArray

            }

        let owner =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Owner in Owners do
                           (Owner, RDF_Literal.autotyped Owner current_transaction)

                       |]
                    |> Map.ofArray

            }

        let pipe_shape =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Pipeshape in Pipeshapes do
                           (Pipeshape, RDF_Literal.autotyped Pipeshape current_transaction)

                       |]
                    |> Map.ofArray

            }

        let pond_type =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Pondtype in Pondtypes do
                           (Pondtype, RDF_Literal.autotyped Pondtype current_transaction)

                       |]
                    |> Map.ofArray

            }

        let pond_yr =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Pondyr in Pondyrs do
                           (Pondyr, RDF_Literal.autotyped Pondyr current_transaction)

                       |]
                    |> Map.ofArray

            }

        let related_feature =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Relatedfeature in Relatedfeatures do
                           (Relatedfeature, RDF_Literal.autotyped Relatedfeature current_transaction)

                       |]
                    |> Map.ofArray

            }

        let slot_elev =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for SlotElev in SlotElevs do
                           (SlotElev, RDF_Literal.autotyped SlotElev current_transaction)

                       |]
                    |> Map.ofArray

            }

        let strct_depth =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for StrctDepth in StrctDepths do
                           (StrctDepth, RDF_Literal.autotyped StrctDepth current_transaction)

                       |]
                    |> Map.ofArray

            }

        let structure_type =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Structuretype in Structuretypes do
                           (Structuretype, RDF_Literal.autotyped Structuretype current_transaction)

                       |]
                    |> Map.ofArray

            }

        let subtype_field =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Subtypefield in Subtypefields do
                           (Subtypefield, RDF_Literal.autotyped Subtypefield current_transaction)

                       |]
                    |> Map.ofArray

            }

        let surface_type =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Surfacetype in Surfacetypes do
                           (Surfacetype, RDF_Literal.autotyped Surfacetype current_transaction)

                       |]
                    |> Map.ofArray

            }

        let upstream_depth =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for UpstreamDepth in UpstreamDepths do
                           (UpstreamDepth, RDF_Literal.autotyped UpstreamDepth current_transaction)

                       |]
                    |> Map.ofArray

            }

        let upstream_elevation =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for UpstreamElevation in UpstreamElevations do
                           (UpstreamElevation, RDF_Literal.autotyped UpstreamElevation current_transaction)

                       |]
                    |> Map.ofArray

            }

        let water_body_name =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Waterbodyname in Waterbodynames do
                           (Waterbodyname, RDF_Literal.autotyped Waterbodyname current_transaction)

                       |]
                    |> Map.ofArray

            }

        let width =

            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for Width in Widths do
                           (Width, RDF_Literal.autotyped Width current_transaction)

                       |]
                    |> Map.ofArray

            }





































(*
let LayerName_Stcode'Stname =

XRay.LCG_Stormwater_Inventory.xml.WorkspaceDefinition.DatasetDefinitions.DataElements
|> Array.Parallel.collect (fun FeatureDataset ->

    FeatureDataset.Children.DataElements
    |> Array.Parallel.choose (fun FeatureClass ->

        match FeatureClass.Metadata.XmlDoc.Metadata.Eainfo with
        | Some idinfo ->
            let Details =
                idinfo.Detaileds
                |> Array.Parallel.collect (fun Detailed ->
                    Detailed.Subtypes
                    |> Array.Parallel.map (fun Subtype ->
                        let layer_name = layer_name_by_FeatureClass'Name[FeatureClass.Name]

                        ((layer_name, Subtype.Stcode.Value), Subtype.Stname.Value))

                )

            if Details.Length > 0 then
                Some(Details)
            else
                None

        | None -> None

    )
    |> Array.Parallel.collect (fun Detail -> Detail)

)
|> Array.distinct
|> Array.append [| ("End Point",6), "Bubble_Up_Structure"|]
|> Map.ofArray

let LayerName_Stcode =
LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun Layer ->
    Layer.Features
    |> Array.Parallel.filter (fun Feature -> Feature.Attributes.Subtypefield.IsSome)
    |> Array.Parallel.map (fun Feature -> Layer.Name, Feature.Attributes.Subtypefield.Value)

)
|> Array.distinct
|> Array.sort

let results =
LayerName_Stcode
|> Array.map (fun tuple_key ->
    try
        LayerName_Stcode'Stname[tuple_key]
    with
    | err -> failwith $"{tuple_key} failed with error {err.Message}"

)

let FeatureClass_Elements =
XRay.LCPW.htm.Elements "a"
|> Seq.toArray
|> Array.Parallel.choose (fun anchor ->
    match anchor.TryGetAttribute "name" with
    | Some name when name.Value().StartsWith("FeatureClass") -> Some(anchor)
    | _ -> None

    )



let random_FeatureClass_Element = FeatureClass_Elements |> Array.randomChoice

*)
// TODO ask GIS why features in these layers have a subtype code of 1 despite the layer not showing any subtypes
let layers_without_listed_subtype =
    set [

          "Stormwater Pond"
          "Bridge Point"
          "Bridge" ]

let shared_feature_assertions (Feature: Esri_Feature) (individual_feature: RDF_Term) (transaction: LightningTransaction) =

    let layer_owl_class = Feature_Layer.Iri.layer_owl_class[Feature.LayerName]
    Assert.spog individual_feature is_a layer_owl_class oit._graph transaction
    Assert.spog individual_feature is_a swin.Feature oit._graph transaction
    Assert.spog individual_feature is_a owl.NamedIndividual oit._graph transaction

    if
        Feature.Subtypefield.IsSome
        && not (layers_without_listed_subtype.Contains(Feature.LayerName))
    then
        try
            let subtype_owl_class = Subtype.iri[(Feature.LayerName, Feature.Subtypefield.Value)]

            Assert.spog individual_feature is_a subtype_owl_class oit._graph transaction
            Assert.spog subtype_owl_class rdfs.label Subtype.name[(Feature.LayerName, Feature.Subtypefield.Value)] oit._graph transaction

        with
        | err -> failwith $"Subtype.iri[({Feature.LayerName}, {Feature.Subtypefield.Value})] failed with message {err.Message}"

    if Feature.Attachedtoid.IsSome then
        Assert.spog individual_feature swin.attached_to Id.Iri.individual_feature_by_Attachedtoid[Feature.Attachedtoid.Value] oit._graph transaction

    if Feature.Facilityid.IsSome then

        let individual_facility = Id.Iri.individual_facility[Feature.Facilityid.Value]

        Assert.spog individual_feature swin.facility individual_facility oit._graph transaction
        Assert.spog individual_facility is_a swin.Facility oit._graph transaction
        Assert.spog individual_facility is_a owl.NamedIndividual oit._graph transaction

        Assert.spog individual_facility Layer_Field.Iri.layer_field[$"{Feature.LayerName}.FACILITYID"] Id.Literal.facility_id[Feature.Facilityid.Value] oit._graph transaction

    if Feature.HydId.IsSome then

        let individual_hyd = Id.Iri.individual_hyd[Feature.HydId.Value]

        Assert.spog individual_feature swin.hyd individual_hyd oit._graph transaction
        Assert.spog individual_hyd is_a swin.Hyd oit._graph transaction
        Assert.spog individual_hyd is_a owl.NamedIndividual oit._graph transaction
        Assert.spog individual_hyd Layer_Field.Iri.layer_field[$"{Feature.LayerName}.HYD_ID"] Id.Literal.hyd_id[Feature.HydId.Value] oit._graph transaction

    if Feature.Outfallid.IsSome then

        let individual_outfall = Id.Iri.individual_outfall[Feature.Outfallid.Value]

        Assert.spog individual_feature swin.outfall individual_outfall oit._graph transaction
        Assert.spog individual_outfall is_a swin.Outfall oit._graph transaction
        Assert.spog individual_outfall is_a owl.NamedIndividual oit._graph transaction

        Assert.spog individual_outfall Layer_Field.Iri.layer_field[$"{Feature.LayerName}.OUTFALLID"] Id.Literal.outfall_id[Feature.Outfallid.Value] oit._graph transaction

    if Feature.Parentid.IsSome then

        let individual_parent = Id.Iri.individual_parent[Feature.Parentid.Value]
        Assert.spog individual_feature swin.parent individual_parent oit._graph transaction

    if Feature.StructureId.IsSome then

        let individual_structure = Id.Iri.individual_structure[Feature.StructureId.Value]

        Assert.spog individual_feature swin.structure individual_structure oit._graph transaction
        Assert.spog individual_structure is_a swin.Structure oit._graph transaction
        Assert.spog individual_structure is_a owl.NamedIndividual oit._graph transaction

        Assert.spog individual_structure Layer_Field.Iri.layer_field[$"{Feature.LayerName}.STRUCTUREID"] Id.Literal.structure_id[Feature.StructureId.Value] oit._graph transaction


    if Feature.Upstreamstuctureid.IsSome then

        let individual_upstream_structure =
            Id.Iri.individual_upstream_structure[Feature.Upstreamstuctureid.Value]



        Assert.spog individual_feature swin.upstream_structure individual_upstream_structure oit._graph transaction
        Assert.spog individual_upstream_structure is_a swin.Upstream_Structure oit._graph transaction
        Assert.spog individual_upstream_structure is_a owl.NamedIndividual oit._graph transaction

        Assert.spog individual_upstream_structure Layer_Field.Iri.layer_field[$"{Feature.LayerName}.UPSTREAMSTUCTUREID"] Id.Literal.upstream_structure_id[Feature.Upstreamstuctureid.Value] oit._graph transaction




    if Feature.Description.IsSome
       && Feature.Description.Value |> is_not_nullish then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.DESCRIPTION"] Attribute.Literal.description[Feature.Description.Value] oit._graph transaction

    if Feature.Diameter.IsSome
       && Feature.Diameter.Value <> 0 then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.DIAMETER"] Attribute.Literal.diameter[Feature.Diameter.Value] oit._graph transaction

    if Feature.DownstreamDepth.IsSome
       && Feature.DownstreamDepth.Value <> 0M then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.DOWNSTREAMDEPTH"] Attribute.Literal.downstream_depth[Feature.DownstreamDepth.Value] oit._graph transaction

    if Feature.DownstreamElevation.IsSome
       && Feature.DownstreamElevation.Value <> 0M then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.DOWNSTREAMELEVATION"] Attribute.Literal.downstream_elevation[Feature.DownstreamElevation.Value] oit._graph transaction

    if Feature.Drainagebasin.IsSome
       && Feature.Drainagebasin.Value |> is_not_nullish then
        let individual_drainage_basin =
            Attribute.Iri.individual_drainage_basin[Feature.Drainagebasin.Value]

        let drainage_basin_label =
            Attribute.Literal.drainage_basin[Feature.Drainagebasin.Value]

        Assert.spog individual_feature swin.drainage_basin individual_drainage_basin oit._graph transaction
        Assert.spog individual_drainage_basin is_a swin.Drainage_Basin oit._graph transaction
        Assert.spog individual_drainage_basin rdfs.label drainage_basin_label oit._graph transaction

    if Feature.Filterlocation.IsSome
       && Feature.Filterlocation.Value |> is_not_nullish then
        try
            let layer_field = Layer_Field.Iri.layer_field[$"{Feature.LayerName}.FILTERLOCATION"]

            Assert.spog individual_feature layer_field Attribute.Literal.filter_location[Feature.Filterlocation.Value] oit._graph transaction
            Assert.spog individual_feature swin.filter_location Coded_Value.Iri.individual_coded_value_by_FieldName'CodedValueCode[("FILTERLOCATION", Feature.Filterlocation.Value)] oit._graph transaction
            Assert.spog swin.filter_location swin.field layer_field oit._graph transaction
        with
        | err -> failwith $"(FILTERLOCATION, {Feature.Filterlocation.Value}) failed with message {err.Message}"

    if Feature.Filtertype.IsSome
       && Feature.Filtertype.Value |> is_not_nullish then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.FILTERTYPE"] Attribute.Literal.filter_type[Feature.Filtertype.Value] oit._graph transaction

    if Feature.Height.IsSome
       && Feature.Height.Value <> 0M then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.HEIGHT"] Attribute.Literal.height[Feature.Height.Value] oit._graph transaction

    if Feature.InvertElevation.IsSome
       && Feature.InvertElevation.Value <> 0M then
        try
            Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.INVERTELEV"] Attribute.Literal.invert_elevation[Feature.InvertElevation.Value] oit._graph transaction
        with
        | err -> failwith $"({Feature.LayerName}.INVERTELEV, {Feature.InvertElevation.Value}) failed with message {err.Message}"
    if Feature.Lfeet.IsSome && Feature.Lfeet.Value <> 0M then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.LFEET"] Attribute.Literal.l_feet[Feature.Lfeet.Value] oit._graph transaction

    if Feature.LocationDescription.IsSome
       && Feature.LocationDescription.Value
          |> is_not_nullish then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.LOCATION"] Attribute.Literal.location_description[Feature.LocationDescription.Value] oit._graph transaction

    if Feature.Maintby.IsSome
       && Feature.Maintby.Value |> is_not_nullish then
        try
            let code = Normalize.maint_by Feature.Maintby.Value
            let layer_field = Layer_Field.Iri.layer_field[$"{Feature.LayerName}.MAINTBY"]

            Assert.spog individual_feature layer_field Attribute.Literal.maint_by[code] oit._graph transaction
            Assert.spog individual_feature swin.maintainer Coded_Value.Iri.individual_coded_value_by_FieldName'CodedValueCode[("MAINTBY", code)] oit._graph transaction
            Assert.spog swin.maintainer swin.field layer_field oit._graph transaction

        with
        | err -> failwith $"(MAINTBY, {Feature.Maintby.Value}) failed with message {err.Message}"
    if Feature.Material.IsSome
       && Feature.Material.Value |> is_not_nullish then
        try
            let code = Normalize.material Feature.Material.Value
            let layer_field = Layer_Field.Iri.layer_field[$"{Feature.LayerName}.MATERIAL"]


            Assert.spog individual_feature layer_field Attribute.Literal.material[code] oit._graph transaction
            Assert.spog individual_feature swin.material Coded_Value.Iri.individual_coded_value_by_FieldName'CodedValueCode[("MATERIAL", code)] oit._graph transaction
            Assert.spog swin.material swin.field layer_field oit._graph transaction
        with
        | err -> failwith $"(MATERIAL, {Feature.Material.Value}) failed with message {err.Message}"
    if Feature.Notes.IsSome
       && Feature.Notes.Value |> is_not_nullish then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.NOTES"] Attribute.Literal.notes[Feature.Notes.Value] oit._graph transaction

    if Feature.NumBarrels.IsSome
       && Feature.NumBarrels.Value <> 0 then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.NUM_BARRELS"] Attribute.Literal.num_barrels[Feature.NumBarrels.Value] oit._graph transaction

    if Feature.Outfalltype.IsSome
       && Feature.Outfalltype.Value |> is_not_nullish then
        let outfall_type = Attribute.Iri.outfall_type[Feature.Outfalltype.Value]
        Assert.spog individual_feature is_a outfall_type oit._graph transaction

        Assert.spog outfall_type rdfs.label Attribute.Literal.outfall_type[Feature.Outfalltype.Value] oit._graph transaction
    if Feature.Owner.IsSome
       && Feature.Owner.Value |> is_not_nullish then
        try
            let code = Normalize.owner Feature.Owner.Value
            let owner =
                Coded_Value.Iri.individual_coded_value_by_FieldName'CodedValueCode[("OWNER", code)]
            let layer_field = Layer_Field.Iri.layer_field[$"{Feature.LayerName}.OWNER"]
            Assert.spog individual_feature layer_field Attribute.Literal.owner[code] oit._graph transaction
            Assert.spog individual_feature swin.owner owner oit._graph transaction
            Assert.spog swin.owner swin.field layer_field oit._graph transaction
            Assert.spog owner is_a swin.Owner oit._graph transaction
        with
        | err -> failwith $"(OWNER, {Feature.Owner.Value}) failed with message {err.Message}"
    if Feature.Pipeshape.IsSome
       && Feature.Pipeshape.Value |> is_not_nullish then
        try
            let code = Normalize.pipe_shape Feature.Pipeshape.Value
            let layer_field = Layer_Field.Iri.layer_field[$"{Feature.LayerName}.PIPESHAPE"]

            Assert.spog individual_feature layer_field Attribute.Literal.pipe_shape[code] oit._graph transaction
            Assert.spog individual_feature swin.pipe_shape Coded_Value.Iri.individual_coded_value_by_FieldName'CodedValueCode[("PIPESHAPE", code)] oit._graph transaction
            Assert.spog swin.pipe_shape swin.field layer_field oit._graph transaction

        with
        | err -> failwith $"(PIPESHAPE, {Feature.Pipeshape.Value}) failed with message {err.Message}"
    if Feature.Pondtype.IsSome
       && Feature.Pondtype.Value |> is_not_nullish then

        let layer_field = Layer_Field.Iri.layer_field[$"{Feature.LayerName}.PONDTYPE"]
        Assert.spog individual_feature layer_field Attribute.Literal.pond_type[Feature.Pondtype.Value] oit._graph transaction
        Assert.spog individual_feature swin.pond_type Coded_Value.Iri.individual_coded_value_by_FieldName'CodedValueCode[("PONDTYPE", Feature.Pondtype.Value)] oit._graph transaction
        Assert.spog swin.pond_type swin.field layer_field oit._graph transaction

    if Feature.Pondyr.IsSome && Feature.Pondyr.Value <> 0 then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.PONDYR"] Attribute.Literal.pond_yr[Feature.Pondyr.Value] oit._graph transaction

    if Feature.Relatedfeature.IsSome
       && Feature.Relatedfeature.Value |> is_not_nullish then

        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.RELATEDFEATURE"] Attribute.Literal.related_feature[Feature.Relatedfeature.Value] oit._graph transaction

    if Feature.SlotElev.IsSome
       && Feature.SlotElev.Value <> 0M then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.SLOT_ELEV"] Attribute.Literal.slot_elev[Feature.SlotElev.Value] oit._graph transaction

    if Feature.StrctDepth.IsSome
       && Feature.StrctDepth.Value <> 0M then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.STRCT_DEPTH"] Attribute.Literal.strct_depth[Feature.StrctDepth.Value] oit._graph transaction

    if Feature.Structuretype.IsSome
       && Feature.Structuretype.Value |> is_not_nullish then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.STRUCTURETYPE"] Attribute.Literal.structure_type[Feature.Structuretype.Value] oit._graph transaction
        Assert.spog individual_feature is_a Attribute.Iri.structure_type[Feature.Structuretype.Value] oit._graph transaction


    if Feature.Subtypefield.IsSome then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.SUBTYPEFIELD"] Attribute.Literal.subtype_field[Feature.Subtypefield.Value] oit._graph transaction

    if Feature.Surfacetype.IsSome
       && Feature.Surfacetype.Value |> is_not_nullish then
        try
            let code = Normalize.surface_type Feature.Surfacetype.Value
            let layer_field = Layer_Field.Iri.layer_field[$"{Feature.LayerName}.SURFACETYPE"]
            Assert.spog individual_feature layer_field Attribute.Literal.surface_type[code] oit._graph transaction
            Assert.spog individual_feature swin.surface_type Coded_Value.Iri.individual_coded_value_by_FieldName'CodedValueCode[("SURFACETYPE", code)] oit._graph transaction
            Assert.spog swin.surface_type swin.field layer_field oit._graph transaction
        with
        | err -> failwith $"(SURFACETYPE, {Feature.Surfacetype.Value}) failed with message {err.Message}"

    if Feature.UpstreamDepth.IsSome
       && Feature.UpstreamDepth.Value <> 0M then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.UPSTREAMDEPTH"] Attribute.Literal.upstream_depth[Feature.UpstreamDepth.Value] oit._graph transaction

    if Feature.UpstreamElevation.IsSome
       && Feature.UpstreamElevation.Value <> 0M then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.UPSTREAMELEVATION"] Attribute.Literal.upstream_elevation[Feature.UpstreamElevation.Value] oit._graph transaction

    if Feature.Waterbodyname.IsSome
       && Feature.Waterbodyname.Value |> is_not_nullish then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.WATERBODYNAME"] Attribute.Literal.water_body_name[Feature.Waterbodyname.Value] oit._graph transaction

    if Feature.Width.IsSome && Feature.Width.Value <> 0M then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.WIDTH"] Attribute.Literal.width[Feature.Width.Value] oit._graph transaction

    if Feature.X.IsSome && Feature.X.Value <> 0 then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.x"] Coordinate.Literal.x[Feature.X.Value] oit._graph transaction

    if Feature.Y.IsSome && Feature.Y.Value <> 0 then
        Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.y"] Coordinate.Literal.y[Feature.Y.Value] oit._graph transaction

    if Feature.Zvalue.IsSome
       && Feature.Zvalue.Value <> 0M then
        Assert.spog individual_feature swin.z_coordinate Coordinate.Literal.z[Feature.Zvalue.Value] oit._graph transaction
// with | err -> printf "Feature %A failed with error: %s" Feature err.Message





























module AZ =
    let directory_path =
        @"D:\Surface\Company\Environmental_Systems_Research_Institute\Esri_Reference\A_to_Z_GIS\OEBPS\"

    [<Literal>]
    let file_path =
        @"D:/Surface/Company/Environmental_Systems_Research_Institute/Esri_Reference/A_to_Z_GIS/OEBPS/A_to_Z_GIS_Dictionary.xml"

    let xdirectory_path (file_path: string) (expression: string) =

        let xhtml = XPathNavigator.Load(file_path)
        let namespace_manager = new XmlNamespaceManager(xhtml.NameTable)
        xhtml
        |> XPathNavigator.xmlns namespace_manager "xhtml" "http://www.w3.org/1999/xhtml"
        |> ignore
        xhtml
        |> XPathNavigator.xmlns namespace_manager "epub" "http://www.idpf.org/2007/ops"
        |> ignore
        let xpath_expression = XPathExpression.Compile(expression)

        xpath_expression.SetContext(namespace_manager)
        xhtml.Select(xpath_expression).toElementArray


    let articlesToDictionaryXml () =

        let document = XmlDocument()

        let root = document.CreateElement("dictionary")
        document.AppendChild(root) |> ignore
        let builder = StringBuilder()

        let settings = XmlWriterSettings(Indent = true, OmitXmlDeclaration = false)

        use writer = XmlWriter.Create(builder, settings)

        writer.WriteStartDocument()
        writer.WriteStartElement("dictionary")

        let articles =
            Directory.GetFiles(directory_path, "AZ_*.xhtml")
            |> Array.Parallel.collect (fun file_path -> xdirectory_path file_path "//xhtml:article")
        for article in articles do
            use reader = article.ReadSubtree()
            let node = document.ReadNode(reader)

            if not (isNull node) then
                root.AppendChild(node) |> ignore
        document.Save(file_path)

    let xhtml = XPathNavigator.Load(file_path)

    let namespace_manager = new XmlNamespaceManager(xhtml.NameTable)

    xhtml
    |> XPathNavigator.xmlns namespace_manager "xhtml" "http://www.w3.org/1999/xhtml"
    |> ignore

    xhtml
    |> XPathNavigator.xmlns namespace_manager "epub" "http://www.idpf.org/2007/ops"
    |> ignore

    let xpath (expression: string) (xpath_navigator: XPathNavigator) =
        let xpath_expression = XPathExpression.Compile(expression)
        xpath_expression.SetContext(namespace_manager)

        xpath_navigator
            .Select(
                xpath_expression
            )
            .toElementArray

    let xml = XmlProvider<file_path>.Load file_path

    let articles =
        Directory.GetFiles(directory_path, "*.xhtml")
        |> Array.Parallel.collect (fun file_path -> xdirectory_path file_path "//xhtml:article")


    let field_span_descendant_of (element: XPathNavigator) =
        element
        |> xpath """./descendant::xhtml:span[@class = "field"]"""
        |> Array.map (fun field_span -> field_span.Value.TrimStart('[').TrimEnd(']'))

    let article_ids =
        Directory.GetFiles(directory_path, "AZ_*.xhtml")
        |> Array.Parallel.collect (fun file_path -> xdirectory_path file_path "//xhtml:article/@id")
        |> Array.Parallel.map (fun element -> element.Value)

    let lexical_tokens =
        article_ids
        |> Array.collect (fun id ->
            let doc = nlp.process_single id
            let token_list = doc.ToTokenList()
            token_list
            |> Seq.toArray
            |> Array.filter (fun token -> token.Value <> "_")
            |> Array.map (fun token -> token.Value))
        |> Array.append article_ids
        |> Array.distinct

    let constituents =
        article_ids
        |> Array.choose (fun id ->
            let doc = nlp.process_single id
            let token_list = doc.ToTokenList()
            let tokens =
                token_list
                |> Seq.toArray
                |> Array.filter (fun token -> token.Value <> "_")
                |> Array.map (fun token -> token.Value)
            if tokens.Length > 1 then
                let components =
                    tokens
                    |> Array.map (fun token -> id, $"{id}.{token}")
                Some(components)
            else
                None)
        |> Array.collect (fun nested_array -> nested_array)



(*
    let definiendums =
        article_ids
        |> Array.Parallel.collect (fun id ->
            Directory.GetFiles(directory_path, "AZ_*.xhtml")
            |> Array.Parallel.collect (fun file_path ->
                xdirectory_path file_path $"""//xhtml:article[@id="{id}"]/xhtml:p/xhtml:dfn"""
                |> Array.Parallel.map (fun element -> id, element.Value)))


    let definientia =
        article_ids
        |> Array.Parallel.collect (fun id ->
            Directory.GetFiles(directory_path, "AZ_*.xhtml")
            |> Array.Parallel.collect (fun file_path ->
                xdirectory_path file_path $"""//xhtml:article[@id="{id}"]/xhtml:p/xhtml:span[@epub:type = "def"]"""
                |> Array.Parallel.map (fun element -> id, element.Value)))



    let subject_areas =
        article_ids
        |> Array.Parallel.collect (fun id ->
            Directory.GetFiles(directory_path, "AZ_*.xhtml")
            |> Array.Parallel.choose (fun file_path ->
                let areas =
                    xdirectory_path file_path $"""//xhtml:article[@id="{id}"]/xhtml:p/xhtml:span[@class = "field"]"""
                    |> Array.collect (fun element ->
                        element
                            .Value
                            .TrimStart('[')
                            .TrimEnd(']')
                            .Split(","))
                if areas.Length > 0 then

                    Some(id, areas)
                else
                    None)

        )

    let images =
        article_ids
        |> Array.Parallel.collect (fun id ->
            Directory.GetFiles(directory_path, "AZ_*.xhtml")
            |> Array.Parallel.choose (fun file_path ->
                let images =
                    xdirectory_path file_path $"""//xhtml:article[@id="{id}"]/xhtml:figure/xhtml:img/@src"""
                    |> Array.map (fun element ->
                        let file_path = Path.Combine(directory_path, element.Value)
                        let file_uri = new Uri(file_path)
                        file_uri.AbsoluteUri

                    )
                if images.Length > 0 then
                    Some(id, images)
                else
                    None)

        )
    let see_alsos =
        article_ids
        |> Array.Parallel.collect (fun id ->
            Directory.GetFiles(directory_path, "AZ_*.xhtml")
            |> Array.Parallel.choose (fun file_path ->
                let links =
                    xdirectory_path file_path $"""//xhtml:article[@id="{id}"]/xhtml:p/xhtml:a"""
                    |> Array.Parallel.map (fun element -> element.Value)
                if links.Length > 0 then
                    Some(id, links)
                else
                    None))

    module Iri =
        let lexicographic_entry =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    article_ids
                    |> Array.map (fun id -> (id, A_to_Z_GIS._prefix id current_transaction))
                    |> Map.ofArray
            }


        let lexical_entry =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    article_ids
                    |> Array.map (fun id -> (id, entry._prefix id current_transaction))
                    |> Map.ofArray
            }

        let lexical_token =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun token -> (token, entry._prefix token current_transaction))
                    |> Map.ofArray
            }

        let lexical_form =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun lexical_token -> (lexical_token, data.text.plain lexical_token current_transaction))
                    |> Map.ofArray
            }

        let gis_sense =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun lexical_token -> (lexical_token, sense._prefix $"gis.{lexical_token}" current_transaction))
                    |> Map.ofArray
            }

        let lexical_concept =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun lexical_token -> (lexical_token, concept._prefix $"{lexical_token}" current_transaction))
                    |> Map.ofArray
            }

        let gis_concept =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun lexical_token -> (lexical_token, concept._prefix $"gis.{lexical_token}" current_transaction))
                    |> Map.ofArray
            }

        let lexical_constituent =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    constituents
                    |> Array.map (fun (id, lexical_constituent) -> (lexical_constituent, constituent._prefix (lexical_constituent) current_transaction))
                    |> Map.ofArray
            }


        let subject_area =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    subject_areas
                    |> Array.collect (fun (id, areas) ->
                        areas
                        |> Array.map (fun subject_area ->

                            (subject_area, A_to_Z_GIS._prefix subject_area current_transaction))

                    )
                    |> Map.ofArray
            }

        let see_also =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    see_alsos
                    |> Array.collect (fun (id, see_also) -> see_also)
                    |> Array.distinct
                    |> Array.map (fun see_also ->

                        (see_also, entry._prefix see_also current_transaction)

                    )
                    |> Map.ofArray
            }

        let image =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    images
                    |> Array.collect (fun (id, image) -> image)
                    |> Array.distinct
                    |> Array.map (fun image ->
                        let iri_form = Lexical_Form.from_string image current_transaction
                        let iriref =
                            RDF_Term.from_atomic_iri { lexical_form_id = iri_form.lexical_form_id } current_transaction

                        (subject_area, iriref)

                    )
                    |> Map.ofArray
            }

    module Literal =

        let definiendum =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    definiendums
                    |> Array.map (fun (id, definiendum) ->

                        (definiendum, RDF_Literal.US definiendum current_transaction)

                    )
                    |> Map.ofArray
            }

        let definiens =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    definientia
                    |> Array.map (fun (id, definiens) ->

                        (definiens, RDF_Literal.US definiens current_transaction)

                    )
                    |> Map.ofArray
            }
        let subject_area =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    subject_areas
                    |> Array.collect (fun (id, subject_area) -> subject_area)
                    |> Array.distinct
                    |> Array.map (fun subject_area ->

                        (subject_area, RDF_Literal.US subject_area current_transaction)

                    )
                    |> Map.ofArray
            }


*)




module gp =
    module services =
        [<Literal>]
        let file_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\ArcGIS\Pro\Resources\ArcToolBox\Services\gpservices\json-schema.json"

        module schema =
            let json = JsonProvider<file_path>.Load file_path

    module DataTypes =
        let directory_path =
            @"D:\Surface\Company\Environmental_Systems_Research_Institute\ArcGIS\Pro\Resources\Help\gp\DataTypes"
        // TODO extract datatypes
        let xpath (file_path: string) (expression: string) =

            let xhtml = XPathNavigator.Load(file_path)
            let namespace_manager = new XmlNamespaceManager(xhtml.NameTable)
            let xpath_expression = XPathExpression.Compile(expression)

            xpath_expression.SetContext(namespace_manager)
            xhtml.Select(xpath_expression).toElementArray







// AZ.ids |> String.concat "\n" |> clip






module H8Help_gloss =

    [<Literal>]
    let file_path =
        @"D:\Surface\Company\Infor\Download_Center\Product\Operations_and_Regulations\Release\Infor_Public_Sector_2025_04_01\IPS_2025_04_01\ApplicationFiles\Application\production\operations\help\H8Help_gloss.xml"

    // let navigator = XPathNavigator.Load(file_path)
    let xml = XmlProvider<file_path>.Load file_path

    let ids =
        xml.Terms
        |> Array.Parallel.map (fun term -> term.Word)

    let lexical_tokens =
        ids
        |> Array.collect (fun id ->
            let doc = nlp.process_single id
            let token_list = doc.ToTokenList()
            token_list
            |> Seq.toArray
            |> Array.filter (fun token -> token.Value <> "_")
            |> Array.map (fun token -> token.Value))
        |> Array.append ids
        |> Array.distinct

    let constituents =
        ids
        |> Array.choose (fun id ->
            let doc = nlp.process_single id
            let token_list = doc.ToTokenList()
            let tokens =
                token_list
                |> Seq.toArray
                |> Array.filter (fun token -> token.Value <> "_")
                |> Array.map (fun token -> token.Value)
            if tokens.Length > 1 then
                let components =
                    tokens
                    |> Array.map (fun token -> id, $"{id}.{token}")
                Some(components)
            else
                None)
        |> Array.collect (fun nested_array -> nested_array)

    let definiendums =
        xml.Terms
        |> Array.Parallel.map (fun term -> term.Word, term.Word)

    let definientia =
        xml.Terms
        |> Array.Parallel.map (fun term -> term.Word, term.Def)
    // TODO handle implicit see also in def
    module Iri =

        let lexicographic_entry =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    ids
                    |> Array.map (fun id -> (id, hansen._prefix id current_transaction))
                    |> Map.ofArray
            }


        let lexical_entry =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    ids
                    |> Array.map (fun id -> (id, entry._prefix id current_transaction))
                    |> Map.ofArray
            }

        let lexical_token =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun token -> (token, entry._prefix token current_transaction))
                    |> Map.ofArray
            }

        let lexical_form =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun lexical_token -> (lexical_token, data.text.plain lexical_token current_transaction))
                    |> Map.ofArray
            }

        let infor_sense =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun lexical_token -> (lexical_token, sense._prefix $"infor.{lexical_token}" current_transaction))
                    |> Map.ofArray
            }

        let lexical_concept =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun lexical_token -> (lexical_token, concept._prefix $"{lexical_token}" current_transaction))
                    |> Map.ofArray
            }

        let infor_concept =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    lexical_tokens
                    |> Array.map (fun lexical_token -> (lexical_token, concept._prefix $"infor.{lexical_token}" current_transaction))
                    |> Map.ofArray
            }

        let lexical_constituent =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    constituents
                    |> Array.map (fun (id, lexical_constituent) -> (lexical_constituent, constituent._prefix (lexical_constituent) current_transaction))
                    |> Map.ofArray
            }


    module Literal =

        let definiendum =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    definiendums
                    |> Array.map (fun (id, definiendum) ->

                        (definiendum, RDF_Literal.US definiendum current_transaction)

                    )
                    |> Map.ofArray
            }

        let definiens =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction
                return
                    definientia
                    |> Array.map (fun (id, definiens) ->

                        (definiens, RDF_Literal.US definiens current_transaction)

                    )
                    |> Map.ofArray
            }
























































module hansenDataDistribution =
    module xml =

        let cardinalityChilds =
            MetaData.navigator
            |> xpath "//@cardinalityChild"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let cardinalityParents =
            MetaData.navigator
            |> xpath "//@cardinalityParent"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let cardinalityUsedByApplications =
            MetaData.navigator
            |> xpath "//@cardinalityUsedByApplication"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let commonIds =
            MetaData.navigator
            |> xpath "//@commonId"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let dataPrecisions =
            MetaData.navigator
            |> xpath "//@dataPrecision"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let dataScales =
            MetaData.navigator
            |> xpath "//@dataScale"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let databaseNames =
            MetaData.navigator
            |> xpath "//@databaseName"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let defaultValues =
            MetaData.navigator
            |> xpath "//@defaultValue"
            |> Array.Parallel.map (fun attribute -> attribute.Value.Replace("'", ""))
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.filter (fun defaultValue -> not (String.IsNullOrWhiteSpace(defaultValue)))

        let deleteRules =
            MetaData.navigator
            |> xpath "//@deleteRule"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let deploymentStatuss =
            MetaData.navigator
            |> xpath "//@deploymentStatus"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let descriptions =
            MetaData.navigator
            |> xpath "//@description"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let directions =
            MetaData.navigator
            |> xpath "//@direction"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let displayDescriptions =
            MetaData.navigator
            |> xpath "//@displayDescription"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let displayNames =
            MetaData.navigator
            |> xpath "//@displayName"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let displayTitles =
            MetaData.navigator
            |> xpath "//@displayTitle"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let displayTitleLongs =
            MetaData.navigator
            |> xpath "//@displayTitleLong"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let effectiveDateTimes =
            MetaData.navigator
            |> xpath "//@effectiveDateTime"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.map (fun value -> DateTime.Parse(value))


        let enumerationNames =
            MetaData.navigator
            |> xpath "//@enumerationName"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let expiredDateTimes =
            MetaData.navigator
            |> xpath "//@expiredDateTime"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.map (fun value -> DateTime.Parse(value))

        let hasNullRecords =
            MetaData.navigator
            |> xpath "//@hasNullRecord"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let identitySeeds =
            MetaData.navigator
            |> xpath "//@identitySeed"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let identitySteps =
            MetaData.navigator
            |> xpath "//@identityStep"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let isAgencyEnhancables =
            MetaData.navigator
            |> xpath "//@isAgencyEnhancable"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.map (fun value -> Boolean.Parse value)

        let isHansens =
            MetaData.navigator
            |> xpath "//@isHansen"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.map (fun value -> Boolean.Parse value)

        let isLicenseds =
            MetaData.navigator
            |> xpath "//@isLicensed"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.map (fun value -> Boolean.Parse value)

        let isNullables =
            MetaData.navigator
            |> xpath "//@isNullable"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.map (fun value -> Boolean.Parse value)

        let isRequireds =
            MetaData.navigator
            |> xpath "//@isRequired"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.map (fun value -> Boolean.Parse value)

        let isUniques =
            MetaData.navigator
            |> xpath "//@isUnique"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.map (fun value -> Boolean.Parse value)

        let lengths =
            MetaData.navigator
            |> xpath "//@length"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish
            |> Array.Parallel.map (fun value -> int value)

        let locales =
            MetaData.navigator
            |> xpath "//@locale"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let names =
            MetaData.navigator
            |> xpath "//@name"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let oracleStatements =
            MetaData.navigator
            |> xpath "//@oracleStatement"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let orders =
            MetaData.navigator
            |> xpath "//@order"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let owners =
            MetaData.navigator
            |> xpath "//@owner"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let platforms =
            MetaData.navigator
            |> xpath "//@platform"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let remarkss =
            MetaData.navigator
            |> xpath "//@remarks"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let showSearchOrders =
            MetaData.navigator
            |> xpath "//@showSearchOrder"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let statements =
            MetaData.navigator
            |> xpath "//@statement"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let types =
            MetaData.navigator
            |> xpath "//@type"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let useSearchOrders =
            MetaData.navigator
            |> xpath "//@useSearchOrder"
            |> Array.Parallel.map (fun attribute -> attribute.Value)
            |> Array.Parallel.filter is_not_nullish

        let values =
            MetaData.navigator
            |> xpath "//@value"
            |> Array.Parallel.map (fun attribute -> attribute.Value.Replace("'", ""))
            |> Array.Parallel.filter is_not_nullish


    module Literal =

        let cardinalityChild =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for cardinalityChild in xml.cardinalityChilds do
                           (cardinalityChild, RDF_Literal.datatyped cardinalityChild xsd.int current_transaction)

                       |]
                    |> Map.ofArray
            }

        let cardinalityParent =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for cardinalityParent in xml.cardinalityParents do
                           (cardinalityParent, RDF_Literal.datatyped cardinalityParent xsd.int current_transaction)

                       |]
                    |> Map.ofArray
            }
        // TODO normalize pseudo boolean Y or N values
        let cardinalityUsedByApplication =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for cardinalityUsedByApplication in xml.cardinalityUsedByApplications do
                           (cardinalityUsedByApplication, RDF_Literal.datatyped cardinalityUsedByApplication xsd.token current_transaction)

                       |]
                    |> Map.ofArray
            }

        let commonId =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for commonId in xml.commonIds do
                           (commonId, RDF_Literal.simple commonId current_transaction)

                       |]
                    |> Map.ofArray
            }

        let dataPrecision =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for dataPrecision in xml.dataPrecisions do
                           (dataPrecision, RDF_Literal.datatyped dataPrecision xsd.int current_transaction)

                       |]
                    |> Map.ofArray
            }

        let dataScale =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for dataScale in xml.dataScales do
                           (dataScale, RDF_Literal.datatyped dataScale xsd.int current_transaction)

                       |]
                    |> Map.ofArray
            }

        let databaseName =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for databaseName in xml.databaseNames do
                           (databaseName, RDF_Literal.simple databaseName current_transaction)

                       |]
                    |> Map.ofArray
            }

        let defaultValue =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for defaultValue in xml.defaultValues do
                           match Int32.TryParse(defaultValue) with
                           | true, int_value -> (defaultValue, RDF_Literal.datatyped defaultValue xsd.int current_transaction)
                           | false, _ -> (defaultValue, RDF_Literal.simple defaultValue current_transaction)

                       |]
                    |> Map.ofArray
            }

        let deleteRule =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for deleteRule in xml.deleteRules do
                           (deleteRule, RDF_Literal.datatyped deleteRule xsd.token current_transaction)

                       |]
                    |> Map.ofArray
            }

        let deploymentStatus =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for deploymentStatus in xml.deploymentStatuss do
                           (deploymentStatus, RDF_Literal.simple deploymentStatus current_transaction)

                       |]
                    |> Map.ofArray
            }

        let description =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for description in xml.descriptions do
                           (description, RDF_Literal.US description current_transaction)

                       |]
                    |> Map.ofArray
            }

        let direction =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for direction in xml.directions do
                           (direction, RDF_Literal.simple direction current_transaction)

                       |]
                    |> Map.ofArray
            }

        let displayDescription =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for displayDescription in xml.displayDescriptions do
                           (displayDescription, RDF_Literal.US displayDescription current_transaction)

                       |]
                    |> Map.ofArray
            }

        let displayName =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for displayName in xml.displayNames do
                           (displayName, RDF_Literal.simple displayName current_transaction)

                       |]
                    |> Map.ofArray
            }

        let displayTitle =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for displayTitle in xml.displayTitles do
                           (displayTitle, RDF_Literal.US displayTitle current_transaction)

                       |]
                    |> Map.ofArray
            }

        let displayTitleLong =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for displayTitleLong in xml.displayTitleLongs do
                           (displayTitleLong, RDF_Literal.US displayTitleLong current_transaction)

                       |]
                    |> Map.ofArray
            }

        let effectiveDateTime =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for effectiveDateTime in xml.effectiveDateTimes do
                           (effectiveDateTime, RDF_Literal.Temporal.date.time effectiveDateTime current_transaction) |]
                    |> Map.ofArray
            }

        let enumerationName =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for enumerationName in xml.enumerationNames do
                           (enumerationName, RDF_Literal.simple enumerationName current_transaction)

                       |]
                    |> Map.ofArray
            }

        let expiredDateTime =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for expiredDateTime in xml.expiredDateTimes do
                           (expiredDateTime, RDF_Literal.Temporal.date.time expiredDateTime current_transaction)

                       |]
                    |> Map.ofArray
            }

        let hasNullRecord =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for hasNullRecord in xml.hasNullRecords do
                           (hasNullRecord, RDF_Literal.datatyped hasNullRecord xsd.boolean current_transaction)

                       |]
                    |> Map.ofArray
            }

        let identitySeed =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for identitySeed in xml.identitySeeds do
                           (identitySeed, RDF_Literal.datatyped identitySeed xsd.int current_transaction)

                       |]
                    |> Map.ofArray
            }

        let identityStep =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for identityStep in xml.identitySteps do
                           (identityStep, RDF_Literal.datatyped identityStep xsd.boolean current_transaction)

                       |]
                    |> Map.ofArray
            }

        let isAgencyEnhancable =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for isAgencyEnhancable in xml.isAgencyEnhancables do
                           (isAgencyEnhancable, RDF_Literal.autotyped isAgencyEnhancable current_transaction)

                       |]
                    |> Map.ofArray
            }

        let isHansen =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for isHansen in xml.isHansens do
                           (isHansen, RDF_Literal.autotyped isHansen current_transaction)

                       |]
                    |> Map.ofArray
            }

        let isLicensed =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for isLicensed in xml.isLicenseds do
                           (isLicensed, RDF_Literal.autotyped isLicensed current_transaction)

                       |]
                    |> Map.ofArray
            }

        let isNullable =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for isNullable in xml.isNullables do
                           (isNullable, RDF_Literal.autotyped isNullable current_transaction)

                       |]
                    |> Map.ofArray
            }

        let isRequired =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for isRequired in xml.isRequireds do
                           (isRequired, RDF_Literal.autotyped isRequired current_transaction)

                       |]
                    |> Map.ofArray
            }

        let isUnique =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for isUnique in xml.isUniques do
                           (isUnique, RDF_Literal.autotyped isUnique current_transaction)

                       |]
                    |> Map.ofArray
            }

        let length =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for length in xml.lengths do
                           (length, RDF_Literal.autotyped length current_transaction)

                       |]
                    |> Map.ofArray
            }

        let locale =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for locale in xml.locales do
                           (locale, RDF_Literal.simple locale current_transaction)

                       |]
                    |> Map.ofArray
            }

        let name =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for name in xml.names do
                           (name, RDF_Literal.simple name current_transaction)

                       |]
                    |> Map.ofArray
            }

        let oracleStatement =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for oracleStatement in xml.oracleStatements do
                           (oracleStatement, RDF_Literal.simple oracleStatement current_transaction)

                       |]
                    |> Map.ofArray
            }

        let order =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for order in xml.orders do
                           (order, RDF_Literal.datatyped order xsd.int current_transaction)

                       |]
                    |> Map.ofArray
            }

        let owner =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for owner in xml.owners do
                           (owner, RDF_Literal.simple owner current_transaction)

                       |]
                    |> Map.ofArray
            }

        let platform =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for platform in xml.platforms do
                           (platform, RDF_Literal.simple platform current_transaction)

                       |]
                    |> Map.ofArray
            }

        let remarks =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for remarks in xml.remarkss do
                           (remarks, RDF_Literal.US remarks current_transaction)

                       |]
                    |> Map.ofArray
            }

        let showSearchOrder =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for showSearchOrder in xml.showSearchOrders do
                           (showSearchOrder, RDF_Literal.datatyped showSearchOrder xsd.int current_transaction)

                       |]
                    |> Map.ofArray
            }

        let statement =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for statement in xml.statements do
                           (statement, RDF_Literal.simple statement current_transaction)

                       |]
                    |> Map.ofArray
            }

        let ``type`` =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for ``type`` in xml.types do
                           (``type``, RDF_Literal.simple ``type`` current_transaction)

                       |]
                    |> Map.ofArray
            }

        let useSearchOrder =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for useSearchOrder in xml.useSearchOrders do
                           (useSearchOrder, RDF_Literal.datatyped useSearchOrder xsd.int current_transaction)

                       |]
                    |> Map.ofArray
            }

        let value =
            lmdb_read_write {
                let! current_transaction = lmdb_read_write.Current_Transaction

                return
                    [|

                       for value in xml.values do
                           match Int32.TryParse(value) with
                           | true, int_value -> (value, RDF_Literal.datatyped value xsd.int current_transaction)
                           | false, _ -> (value, RDF_Literal.simple value current_transaction)

                       |]
                    |> Map.ofArray
            }




module systemLicense =
    let names =
        MetaData.xml.HansenMetadata.SystemLicenses
        |> Array.Parallel.map (fun SystemLicense -> SystemLicense.Name)

    let iri =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for name in names do
                       (name, infor._prefix name current_transaction)

                   |]
                |> Map.ofArray
        }

module domainColumn =
    let names =
        MetaData.xml.HansenMetadata.DomainColumns
        |> Array.Parallel.map (fun DomainColumn -> DomainColumn.Name)

    let types =
        MetaData.xml.HansenMetadata.DomainColumns
        |> Array.Parallel.map (fun DomainColumn -> DomainColumn.Type)

    let iri =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for name in names do
                       (name, infor._prefix name current_transaction)

                   |]
                |> Map.ofArray
        }

    let type_iri =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for ``type`` in types do
                       (``type``, infor._prefix ``type`` current_transaction)

                   |]
                |> Map.ofArray
        }


module productFamily =
    let names =
        MetaData.xml.HansenMetadata.ProductFamilies
        |> Array.Parallel.map (fun ProductFamily -> ProductFamily.Name)


    let iri =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for name in names do
                       (name, infor._prefix $"Hansen.{name}" current_transaction)

                   |]
                |> Map.ofArray
        }




module table =


    let monikers =
        MetaData.xml.HansenMetadata.ProductFamilies
        |> Array.Parallel.collect (fun ProductFamily ->
            ProductFamily.Tables
            |> Array.Parallel.map (fun Table -> ProductFamily.Name, Table.Name))

    let names =
        MetaData.xml.HansenMetadata.ProductFamilies
        |> Array.Parallel.collect (fun ProductFamily ->
            ProductFamily.Tables
            |> Array.Parallel.map (fun Table -> Table.Name))

    let types =
        MetaData.xml.HansenMetadata.ProductFamilies
        |> Array.Parallel.collect (fun ProductFamily ->
            ProductFamily.Tables
            |> Array.Parallel.map (fun Table -> Table.Type))

    let iri =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for productFamily, table in monikers do
                       ($"{productFamily}.{table}", infor._prefix $"Hansen.{productFamily}.{table}" current_transaction)

                   |]
                |> Map.ofArray
        }

    let type_iri =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for ``type`` in types do
                       (``type``, infor._prefix ``type`` current_transaction)

                   |]
                |> Map.ofArray
        }


module column =


    let monikers =
        MetaData.xml.HansenMetadata.ProductFamilies
        |> Array.Parallel.collect (fun ProductFamily ->
            ProductFamily.Tables
            |> Array.Parallel.collect (fun Table ->
                Array.concat [|


                                Table.Columns
                                |> Array.Parallel.map (fun Column -> ProductFamily.Name, Table.Name, Column.Name)
                                Table.DomainColumnReferences
                                |> Array.Parallel.map (fun Column -> ProductFamily.Name, Table.Name, Column.Name)


                                 |]))

    let names =
        MetaData.xml.HansenMetadata.ProductFamilies
        |> Array.Parallel.collect (fun ProductFamily ->
            ProductFamily.Tables
            |> Array.Parallel.collect (fun Table ->
                Array.concat [|


                                Table.Columns
                                |> Array.Parallel.map (fun Column -> Column.Name)
                                Table.DomainColumnReferences
                                |> Array.Parallel.map (fun Column -> Column.Name)


                                 |]))


    let types =
        MetaData.xml.HansenMetadata.ProductFamilies
        |> Array.Parallel.collect (fun ProductFamily ->
            ProductFamily.Tables
            |> Array.Parallel.collect (fun Table ->
                Table.Columns
                |> Array.Parallel.map (fun Column -> Column.Type)))

    let iri =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for productFamily, table, column in monikers do
                       ($"{productFamily}.{table}.{column}", infor._prefix $"Hansen.{productFamily}.{table}.{column}" current_transaction)

                   |]
                |> Map.ofArray
        }

    let type_iri =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for ``type`` in types do
                       (``type``, infor._prefix ``type`` current_transaction)

                   |]
                |> Map.ofArray
        }

    let super_column =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for name in names do
                       (name, infor._prefix name current_transaction)

                   |]
                |> Map.ofArray
        }

module enumeration =

    let names =
        MetaData.xml.HansenMetadata.Enumerations
        |> Array.Parallel.map (fun Enumeration -> Enumeration.Name)


    let iri =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for name in names do
                       (name, infor._prefix $"{name}" current_transaction)

                   |]
                |> Map.ofArray
        }




module Map =
    let layer'table_names =
        [| "Inlet", "AssetManagement.Storm.StormInlet"
           "Conduit", "AssetManagement.Storm.StormLiftStation"
           "Culvert Cross Drain", "AssetManagement.Storm.StormServiceLine"
           "Debris Trap", "AssetManagement.Storm.StormValve"
           "Ditch", "AssetManagement.Storm.StormBackflowPreventer"
           "End Point", "AssetManagement.Storm.StormNode"
           "Junction Fixed", "AssetManagement.Storm.StormManhole"
           "Outfall", "AssetManagement.UsageArea.Complex"
           "Stormwater Pond", "AssetManagement.Storm.StormMiscellaneous"
           "Stormwater Pond Discharge", "AssetManagement.Storm.StormLevee"

           |]

    let esri_to_infor_name (esri'infor_name: string * string) =
        let esri_name, infor_name = esri'infor_name
        $"{esri_name.low_lined}_to_Hansen.{infor_name}"

    let layer_to_table_names = layer'table_names |> Array.map esri_to_infor_name

    let iri =

        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for name in layer_to_table_names do
                       (name, h8importtool._prefix name current_transaction)

                   |]
                |> Map.ofArray

        }

    let name =
        lmdb_read_write {
            let! current_transaction = lmdb_read_write.Current_Transaction

            return
                [|

                   for name in layer_to_table_names do
                       (name, RDF_Literal.simple name current_transaction)

                   |]
                |> Map.ofArray

        }



    let moniker_to_target_column_type (productFamily_name: string) (table_name: string) (column_name: string) =
        let clrTable =
            Hansen8ClientProxies.dll.DefinedTypes
            |> Seq.tryFind (fun moniker -> moniker.FullName = $"Hansen.{productFamily_name}.{table_name}")
            |> Option.get

        let clrColumn =
            clrTable.DeclaredFields
            |> Seq.tryFind (fun declared_field -> declared_field.Name = column_name)
            |> Option.get

        clrColumn.FieldType.FullName

    let layer_field_to_table_column<'ValueType> (layer_name: string) (field_name: string) (productFamily_name: string) (table_name: string) (column_name: string) (transaction: LightningTransaction) =

        let mapping_name =
            esri_to_infor_name (layer_name, $"{productFamily_name}.{table_name}")
        let map_column_name =
            esri_to_infor_name ($"{layer_name}.{field_name}", $"{productFamily_name}.{table_name}.{column_name}")

        let mapping = iri[mapping_name]
        let map_column = h8importtool._prefix map_column_name transaction
        try
            let source_field = Layer_Field.Iri.layer_field[$"{layer_name}.{field_name}"]
            ()
        with
        | err ->
            failwith
                $"""layer_name:{layer_name}
    field_name:{field_name}
    productFamily_name:{productFamily_name}
    table_name:{table_name}
    column_name:{column_name}
 failed with error {err.Message}"""
        let source_field = Layer_Field.Iri.layer_field[$"{layer_name}.{field_name}"]
        let target_column = column.iri[$"{productFamily_name}.{table_name}.{column_name}"]
        let target_column_type =
            RDF_Literal.simple (moniker_to_target_column_type productFamily_name table_name column_name) transaction
        match table_key_from_name table_name with
        | Some key -> Assert.spog mapping h8importtool.TableKey (RDF_Literal.autotyped key transaction) oit._graph transaction
        | None -> ()

        Assert.spog map_column is_a h8importtool.MapColumn oit._graph transaction
        Assert.spog mapping woedms.map_column map_column oit._graph transaction
        Assert.spog map_column woedms.from_field source_field oit._graph transaction
        Assert.spog map_column h8importtool.SourceColumnName (RDF_Literal.simple $"{layer_name}.{field_name}" transaction) oit._graph transaction
        Assert.spog map_column woedms.to_column target_column oit._graph transaction
        Assert.spog map_column h8importtool.TargetColumnCommonId (RDF_Literal.simple column_name transaction) oit._graph transaction
        Assert.spog map_column h8importtool.TargetColumnType target_column_type oit._graph transaction

        Assert.spog mapping h8importtool.ProductFamilyName (RDF_Literal.simple productFamily_name transaction) oit._graph transaction
        Assert.spog mapping h8importtool.TableName (RDF_Literal.simple table_databaseName_from_name[table_name] transaction) oit._graph transaction
        Assert.spog mapping h8importtool.TableCommonId (RDF_Literal.simple table_name transaction) oit._graph transaction






















(*

let multiconstraints =
    MetaData.xml.HansenMetadata.ProductFamilies
    |> Array.Parallel.collect (fun ProductFamily ->
    ProductFamily.Tables
    |> Array.Parallel.collect (fun Table ->
    Table.ReferencingConstraints
    |> Array.Parallel.filter (fun ReferencingConstraint ->
    ReferencingConstraint.LocalColumnReferences.Length > 1
    && ReferencingConstraint.ForeignColumnReferences.Length > 1
    // && ReferencingConstraint.ForeignColumnReferences.Length <> ReferencingConstraint.LocalColumnReferences.Length

    )

    )

    )

enumeration.iri["YesNo"]
*)






let stopwatch = Stopwatch.StartNew()

if should_triplify then



    lmdb_read_write {
        let! current_transaction = lmdb_read_write.Current_Transaction


        do! Assert.spog oit.Infor_Operations_and_Regulations is_a oit.County_Application oit._graph
        do! Assert.spog oit.Esri_ArcGIS_Pro is_a oit.County_Application oit._graph
        do! Assert.spog oit.Infor_Operations_and_Regulations infor.data_layer oit.InforProdSql oit._graph
        do! Assert.spog oit.Infor_Operations_and_Regulations infor.data_layer oit.InforTestSql oit._graph
        do! Assert.spog oit.InforProdSql is_a om.Database oit._graph
        do! Assert.spog oit.InforTestSql is_a om.Database oit._graph
        // TODO maybe ask gis for the name of the geodatabase
        do! Assert.spog oit.Geodatabase is_a om.Database oit._graph
        do! Assert.spog oit.H8Import_Tool is_a om.DataService oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM is_a om.DataService oit._graph
        do! Assert.spog oit.Geodatabase dcat.accessService swin.LCPW_OverlayStormwaterInfrastructure_D_WM oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM dcat.endpointURL (Atomic_IRI.term_from_string "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer" current_transaction) oit._graph





        // rdfs subclasses
        do! Assert.spog oit.County_Application rdfs.subClassOf schemorg.SoftwareApplication oit._graph
        do! Assert.spog esri.esriLocalDatabaseWorkspace rdfs.subClassOf esri.Workspace oit._graph
        do! Assert.spog esri.DEDataset rdfs.subClassOf esri.DataElement oit._graph
        do! Assert.spog esri.DEGeoDataset rdfs.subClassOf esri.DEDataset oit._graph
        do! Assert.spog esri.DETable rdfs.subClassOf esri.DEDataset oit._graph
        do! Assert.spog esri.DEFeatureDataset rdfs.subClassOf esri.DEGeoDataset oit._graph
        do! Assert.spog esri.DEFeatureClass rdfs.subClassOf esri.DETable oit._graph
        do! Assert.spog swin.Feature_Layer rdfs.subClassOf swin.Layer oit._graph
        do! Assert.spog swin.Group_Layer rdfs.subClassOf swin.Layer oit._graph
        do! Assert.spog swin.Upstream_Structure rdfs.subClassOf swin.Structure oit._graph
        do! Assert.spog swin.Downstream_Structure rdfs.subClassOf swin.Structure oit._graph

        // rdfs subproperties
        do! Assert.spog swin.feature_dataset rdfs.subPropertyOf swin.data_element oit._graph
        do! Assert.spog swin.feature_layer rdfs.subPropertyOf swin.layer oit._graph
        do! Assert.spog swin.group_layer rdfs.subPropertyOf swin.layer oit._graph
        do! Assert.spog swin.parent_layer rdfs.subPropertyOf swin.layer oit._graph
        do! Assert.spog swin.child_layer rdfs.subPropertyOf swin.layer oit._graph
        do! Assert.spog swin.upstream_structure rdfs.subPropertyOf swin.structure oit._graph
        do! Assert.spog swin.downstream_structure rdfs.subPropertyOf swin.structure oit._graph


        do! Assert.spog swin.description rdfs.subPropertyOf dcterms.description oit._graph
        do! Assert.spog swin.serviceDescription rdfs.subPropertyOf dcterms.description oit._graph
        do! Assert.spog esri.Description rdfs.subPropertyOf dcterms.description oit._graph

        do! Assert.spog swin.title rdfs.subPropertyOf dcterms.title oit._graph

        do! Assert.spog swin.summary rdfs.subPropertyOf dcterms.``abstract`` oit._graph
        do! Assert.spog esri.``abstract`` rdfs.subPropertyOf dcterms.``abstract`` oit._graph

        do! Assert.spog swin.name rdfs.subPropertyOf rdfs.label oit._graph
        do! Assert.spog esri.DisplayName rdfs.subPropertyOf rdfs.label oit._graph


        // owl inverse properties

        do! Assert.spog interraster.upstream_structure owl.inverseOf interraster.downstream_structure oit._graph
        do! Assert.spog interraster.upstream_structure owl.inverseOf interraster.downstream_structure oit._graph
        do! Assert.spog interraster.parent owl.inverseOf interraster.subLayer oit._graph

        // owl equivalent properties
        do! Assert.spog interraster.Keywords owl.equivalentProperty interraster.tags oit._graph





        do! Assert.spog esri.GPFeatureLayer esri.Description (RDF_Literal.US "A reference to is_a feature class, including symbology and rendering properties." current_transaction) oit._graph
        do! Assert.spog esri.DEFeatureDataset esri.Description (RDF_Literal.US "A collection of feature classes that share is_a common geographic area and the same spatial reference system." current_transaction) oit._graph
        do!
            Assert.spog
                esri.MapService
                esri.Description
                (RDF_Literal.US
                    """A persistent software process that provides access to map images for display in is_a client application.
                The images can be rendered dynamically for is_a specific extent or prerendered and cached in is_a tile grid as static images.
                A map service can also provide access to the underlying feature layer data used to create the map images.
                Map services offer access to map and layer content. Map services can
       either be cached or dynamic. A map service that fulfills requests with
       pre-created tiles from is_a cache instead of dynamically rendering part of
       the map is called is_a cached map service. A dynamic map service requires
       the server to render the map each time is_a request comes in. Map services
       using is_a tile cache can significantly improve performance while
       delivering maps, while dynamic map services offer more flexibility."""
                    current_transaction)
                oit._graph




        do! Assert.spog swin.LCG_Stormwater_Inventory is_a esri.esriLocalDatabaseWorkspace oit._graph

        for DomainName in DomainNames do
            let individual_domain = Coded_Value_Domain.Iri.individual_domain[DomainName]
            do! Assert.spog swin.LCG_Stormwater_Inventory esri.coded_value_domain individual_domain oit._graph
            do! Assert.spog individual_domain is_a esri.CodedValueDomain oit._graph

        for FieldName, DomainName, CodedValueName, CodedValueCode in FieldName'DomainName'CodedValueName'CodedValueCodes do
            let super_field = Layer_Field.Iri.super_field[FieldName]
            let individual_domain = Coded_Value_Domain.Iri.individual_domain[DomainName]
            let individual_coded_value =
                Coded_Value.Iri.individual_coded_value_by_DomainName'CodedValueName[(DomainName, CodedValueName)]

            do! Assert.spog super_field esri.coded_value_domain individual_domain oit._graph
            do! Assert.spog individual_domain swin.coded_value individual_coded_value oit._graph
            do! Assert.spog individual_coded_value is_a esri.CodedValue oit._graph
            do! Assert.spog individual_coded_value esri.Name Coded_Value.Literal.name[CodedValueName] oit._graph
            do! Assert.spog individual_coded_value esri.Code Coded_Value.Literal.code[CodedValueCode] oit._graph


        do! Assert.spog swin.LCG_Stormwater_Inventory swin.feature_dataset swin.DrainageNetwork_Feature_Dataset oit._graph
        do! Assert.spog swin.LCG_Stormwater_Inventory swin.feature_dataset swin.DrainageNonNetwork_Feature_Dataset oit._graph

        do! Assert.spog swin.DrainageNetwork_Feature_Dataset is_a esri.DEFeatureDataset oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset is_a esri.DEFeatureDataset oit._graph

        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.group_layer swin.Drainage_Network_Group_Layer oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset is_a swin.Non_Drainage_Network_Group_Layer oit._graph


        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.EndPoint_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.BridgePoint_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.Inlet_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.Conduit_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.Ditch_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.Connectivity_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.Junction_fixed_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.StormwaterPond_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.Bridge_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.DitchPoint_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.GenericStormAsset_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.StormwaterPondDischarge_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.CulvertCrossDrain_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.PrivatePoint_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNetwork_Feature_Dataset swin.feature_class swin.StormwaterPond_MediaPoints_Feature_Class oit._graph


        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.MediaPoints_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.Damage_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.DebrisTrap_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.Interference_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.MediaPointsWithoutPhotos_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.Outfall_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.Outfall_DrainageArea_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.Outfall_DrainageArea_MOF_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.Outfall_DrainageArea_MS4_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.PollutionControlBox_Feature_Class oit._graph
        do! Assert.spog swin.DrainageNonNetwork_Feature_Dataset swin.feature_class swin.StormwaterPondTopOfBank_Feature_Class oit._graph


        do! Assert.spog swin.Bridge_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.BridgePoint_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Conduit_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Connectivity_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.CulvertCrossDrain_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Damage_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.DebrisTrap_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Ditch_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.DitchPoint_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.EndPoint_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.GenericStormAsset_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Inlet_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Interference_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Junction_fixed_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.MediaPoints_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.MediaPointsWithoutPhotos_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Outfall_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Outfall_DrainageArea_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Outfall_DrainageArea_MOF_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.Outfall_DrainageArea_MS4_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.PollutionControlBox_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.PrivatePoint_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.StormwaterPond_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.StormwaterPond_MediaPoints_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.StormwaterPondDischarge_Feature_Class is_a esri.DEFeatureClass oit._graph
        do! Assert.spog swin.StormwaterPondTopOfBank_Feature_Class is_a esri.DEFeatureClass oit._graph


        do! Assert.spog swin.Bridge_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.BridgePoint_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Conduit_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Connectivity_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.CulvertCrossDrain_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Damage_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.DebrisTrap_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Ditch_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.DitchPoint_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.EndPoint_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.GenericStormAsset_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Inlet_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Interference_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Junction_fixed_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.MediaPoints_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.MediaPointsWithoutPhotos_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Outfall_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Outfall_DrainageArea_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Outfall_DrainageArea_MOF_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.Outfall_DrainageArea_MS4_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.PollutionControlBox_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.PrivatePoint_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.StormwaterPond_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.StormwaterPond_MediaPoints_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.StormwaterPondDischarge_Feature_Class is_a swin.Feature_Class oit._graph
        do! Assert.spog swin.StormwaterPondTopOfBank_Feature_Class is_a swin.Feature_Class oit._graph


        do! Assert.spog swin.Bridge_Feature_Class esri.Description swin._literal.description.Bridge oit._graph
        do! Assert.spog swin.BridgePoint_Feature_Class esri.Description swin._literal.description.BridgePoint oit._graph
        do! Assert.spog swin.Conduit_Feature_Class esri.Description swin._literal.description.Conduit oit._graph
        do! Assert.spog swin.Connectivity_Feature_Class esri.Description swin._literal.description.Connectivity oit._graph
        do! Assert.spog swin.CulvertCrossDrain_Feature_Class esri.Description swin._literal.description.CulvertCrossDrain oit._graph
        do! Assert.spog swin.DebrisTrap_Feature_Class esri.Description swin._literal.description.DebrisTrap oit._graph
        do! Assert.spog swin.Ditch_Feature_Class esri.Description swin._literal.description.Ditch oit._graph
        do! Assert.spog swin.DitchPoint_Feature_Class esri.Description swin._literal.description.DitchPoint oit._graph
        do! Assert.spog swin.EndPoint_Feature_Class esri.Description swin._literal.description.EndPoint oit._graph
        do! Assert.spog swin.GenericStormAsset_Feature_Class esri.Description swin._literal.description.GenericStormAsset oit._graph
        do! Assert.spog swin.Inlet_Feature_Class esri.Description swin._literal.description.Inlet oit._graph
        do! Assert.spog swin.Interference_Feature_Class esri.Description swin._literal.description.Interference oit._graph
        do! Assert.spog swin.Junction_fixed_Feature_Class esri.Description swin._literal.description.Junction_fixed oit._graph
        do! Assert.spog swin.PollutionControlBox_Feature_Class esri.Description swin._literal.description.PollutionControlBox oit._graph
        do! Assert.spog swin.PrivatePoint_Feature_Class esri.Description swin._literal.description.PrivatePoint oit._graph
        do! Assert.spog swin.StormwaterPondDischarge_Feature_Class esri.Description swin._literal.description.StormwaterPondDischarge oit._graph


        do! Assert.spog swin.Bridge_Feature_Class swin.feature_layer swin.Bridge_Feature_Layer oit._graph
        do! Assert.spog swin.BridgePoint_Feature_Class swin.feature_layer swin.Bridge_Point_Feature_Layer oit._graph
        do! Assert.spog swin.Conduit_Feature_Class swin.feature_layer swin.Conduit_Feature_Layer oit._graph
        do! Assert.spog swin.Connectivity_Feature_Class swin.feature_layer swin.Connectivity_Feature_Layer oit._graph
        do! Assert.spog swin.CulvertCrossDrain_Feature_Class swin.feature_layer swin.Culvert_Cross_Drain_Feature_Layer oit._graph
        do! Assert.spog swin.Damage_Feature_Class swin.feature_layer swin.Damage_Feature_Layer oit._graph
        do! Assert.spog swin.DebrisTrap_Feature_Class swin.feature_layer swin.Debris_Trap_Feature_Layer oit._graph
        do! Assert.spog swin.Ditch_Feature_Class swin.feature_layer swin.Ditch_Feature_Layer oit._graph
        do! Assert.spog swin.DitchPoint_Feature_Class swin.feature_layer swin.Ditch_Point_Feature_Layer oit._graph
        do! Assert.spog swin.EndPoint_Feature_Class swin.feature_layer swin.End_Point_Feature_Layer oit._graph
        do! Assert.spog swin.GenericStormAsset_Feature_Class swin.feature_layer swin.Generic_Storm_Asset_Feature_Layer oit._graph
        do! Assert.spog swin.Inlet_Feature_Class swin.feature_layer swin.Inlet_Feature_Layer oit._graph
        do! Assert.spog swin.Interference_Feature_Class swin.feature_layer swin.Interference_Feature_Layer oit._graph
        do! Assert.spog swin.Junction_fixed_Feature_Class swin.feature_layer swin.Junction_Fixed_Feature_Layer oit._graph
        do! Assert.spog swin.MediaPoints_Feature_Class swin.feature_layer swin.Media_Points_Feature_Layer oit._graph
        do! Assert.spog swin.MediaPointsWithoutPhotos_Feature_Class swin.feature_layer swin.Media_Points_Without_Photos_Feature_Layer oit._graph
        do! Assert.spog swin.Outfall_Feature_Class swin.feature_layer swin.Outfall_Feature_Layer oit._graph
        do! Assert.spog swin.Outfall_DrainageArea_Feature_Class swin.feature_layer swin.Outfall_Drainage_Area_Feature_Layer oit._graph
        do! Assert.spog swin.Outfall_DrainageArea_MOF_Feature_Class swin.feature_layer swin.Outfall_Drainage_Area_MOF_Feature_Layer oit._graph
        do! Assert.spog swin.Outfall_DrainageArea_MS4_Feature_Class swin.feature_layer swin.Outfall_Drainage_Area_MS4_Feature_Layer oit._graph
        do! Assert.spog swin.PollutionControlBox_Feature_Class swin.feature_layer swin.Pollution_Control_Box_Feature_Layer oit._graph
        do! Assert.spog swin.PrivatePoint_Feature_Class swin.feature_layer swin.Private_Point_Feature_Layer oit._graph
        do! Assert.spog swin.StormwaterPond_Feature_Class swin.feature_layer swin.Stormwater_Pond_Feature_Layer oit._graph
        do! Assert.spog swin.StormwaterPond_MediaPoints_Feature_Class swin.feature_layer swin.Stormwater_Pond_Media_Points_Feature_Layer oit._graph
        do! Assert.spog swin.StormwaterPondDischarge_Feature_Class swin.feature_layer swin.Stormwater_Pond_Discharge_Feature_Layer oit._graph
        do! Assert.spog swin.StormwaterPondTopOfBank_Feature_Class swin.feature_layer swin.Stormwater_Pond_Top_of_Bank_Feature_Layer oit._graph


        do! Assert.spog swin.Bridge_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Bridge_Point_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Conduit_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Connectivity_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Culvert_Cross_Drain_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Damage_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Debris_Trap_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Ditch_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Ditch_Point_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.End_Point_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Generic_Storm_Asset_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Inlet_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Interference_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Junction_Fixed_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Media_Points_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Media_Points_Without_Photos_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Outfall_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Outfall_Drainage_Area_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Outfall_Drainage_Area_MOF_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Outfall_Drainage_Area_MS4_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Pollution_Control_Box_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Private_Point_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Stormwater_Pond_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Stormwater_Pond_Media_Points_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Stormwater_Pond_Discharge_Feature_Layer is_a esri.GPFeatureLayer oit._graph
        do! Assert.spog swin.Stormwater_Pond_Top_of_Bank_Feature_Layer is_a esri.GPFeatureLayer oit._graph


        do! Assert.spog swin.Bridge_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Bridge_Point_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Conduit_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Connectivity_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Culvert_Cross_Drain_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Damage_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Debris_Trap_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Ditch_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Ditch_Point_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.End_Point_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Generic_Storm_Asset_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Inlet_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Interference_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Junction_Fixed_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Media_Points_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Media_Points_Without_Photos_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Outfall_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Outfall_Drainage_Area_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Outfall_Drainage_Area_MOF_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Outfall_Drainage_Area_MS4_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Pollution_Control_Box_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Private_Point_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Stormwater_Pond_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Stormwater_Pond_Media_Points_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Stormwater_Pond_Discharge_Feature_Layer is_a swin.Feature_Layer oit._graph
        do! Assert.spog swin.Stormwater_Pond_Top_of_Bank_Feature_Layer is_a swin.Feature_Layer oit._graph






        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM is_a esri.MapService oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.currentVersion LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.currentVersion oit._graph // "currentVersion"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.serviceDescription LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.serviceDescription oit._graph // "serviceDescription"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.mapName LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.mapName oit._graph // "mapName"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportsDynamicLayers LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportsDynamicLayers oit._graph // "supportsDynamicLayers"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.spatialReference LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.spatialReference oit._graph // "spatialReference"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.singleFusedMapCache LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.singleFusedMapCache oit._graph // "singleFusedMapCache"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.minScale LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.minScale oit._graph // "minScale"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.maxScale LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.maxScale oit._graph // "maxScale"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.units LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.units oit._graph // "units"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatTypes LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatTypes oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.PNG32 oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.PNG24 oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.PNG oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.JPG oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.DIB oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.TIFF oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.EMF oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.PS oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.PDF oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.GIF oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.SVG oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.SVGZ oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedImageFormatType LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedImageFormatType.BMP oit._graph // "supportedImageFormatTypes"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.Keywords LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.Keywords oit._graph // "Keywords"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.Keyword LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.Keyword.stormwater oit._graph // "Keywords"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.Keyword LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.Keyword.swmf oit._graph // "Keywords"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.Keyword LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.Keyword.drainage oit._graph // "Keywords"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.Keyword LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.Keyword.leon_county oit._graph // "Keywords"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.Keyword LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.Keyword.public_works oit._graph // "Keywords"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.Keyword LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.Keyword.lcpw oit._graph // "Keywords"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.Keyword LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.Keyword.tallahassee oit._graph // "Keywords"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.Keyword LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.Keyword.florida oit._graph // "Keywords"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.capabilities LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.capabilities oit._graph // "capabilities"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.capability LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.capability.Data oit._graph // "capabilities"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.capability LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.capability.Query oit._graph // "capabilities"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.capability LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.capability.Map oit._graph // "capabilities"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedQueryFormats LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedQueryFormats oit._graph // "supportedQueryFormats"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedQueryFormat LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedQueryFormat.JSON oit._graph // "supportedQueryFormats"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportedQueryFormat LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedQueryFormat.geoJSON oit._graph // "supportedQueryFormats"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.exportTilesAllowed LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.exportTilesAllowed oit._graph // "exportTilesAllowed"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.supportsDatumTransformation LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportsDatumTransformation oit._graph // "supportsDatumTransformation"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.maxRecordCount LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.maxRecordCount oit._graph // "maxRecordCount"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.maxImageHeight LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.maxImageHeight oit._graph // "maxImageHeight"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.maxImageWidth LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.maxImageWidth oit._graph // "maxImageWidth"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.culture LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.culture oit._graph // "culture"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.name LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.name oit._graph // "name"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.guid LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.guid oit._graph // "guid"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.catalogPath LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.catalogPath oit._graph // "catalogPath"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.summary LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.summary oit._graph // "summary"
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.title LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.title oit._graph // "title"

        (*
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.tags LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.tags oit._graph // "tags"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.supportedExtensions LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.supportedExtensions oit._graph // "supportedExtensions"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.snippet LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.snippet oit._graph // "snippet"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.referenceScale LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.referenceScale oit._graph // "referenceScale"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.typeKeywords LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.typeKeywords oit._graph // "typeKeywords"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.thumbnail LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.thumbnail oit._graph // "thumbnail"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.url LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.url oit._graph // "url"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.extent LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.extent oit._graph // "extent"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.accessInformation LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.accessInformation oit._graph // "accessInformation"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.licenseInfo LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.licenseInfo oit._graph // "licenseInfo"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.description LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.description oit._graph // "description"
    do! Assert.spog gis.LCPW_OverlayStormwaterInfrastructure_D_WM gis.copyrightText LCPW_OverlayStormwaterInfrastructure_D_WM._literal.value.copyrightText oit._graph // "copyrightText"
    *)


        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.group_layer swin.Drainage_Network_Group_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.group_layer swin.Non_Drainage_Network_Group_Layer oit._graph

        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Bridge_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Bridge_Point_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Conduit_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Connectivity_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Culvert_Cross_Drain_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Damage_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Debris_Trap_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Ditch_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Ditch_Point_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.End_Point_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Generic_Storm_Asset_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Inlet_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Interference_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Junction_Fixed_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Media_Points_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Media_Points_Without_Photos_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Outfall_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Outfall_Drainage_Area_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Outfall_Drainage_Area_MOF_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Outfall_Drainage_Area_MS4_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Pollution_Control_Box_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Private_Point_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Stormwater_Pond_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Stormwater_Pond_Media_Points_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Stormwater_Pond_Discharge_Feature_Layer oit._graph
        do! Assert.spog swin.LCPW_OverlayStormwaterInfrastructure_D_WM swin.feature_layer swin.Stormwater_Pond_Top_of_Bank_Feature_Layer oit._graph






        // layer hierarchy
        for ChildLayerName, ParentLayerName, ParentLayerId in ChildLayerName'ParentLayerName'ParentLayerId do
            let child_layer = Feature_Layer.Iri.feature_layer_by_Name[ChildLayerName]
            let parent_layer = Feature_Layer.Iri.feature_layer_by_Name[ParentLayerName]
            do! Assert.spog child_layer swin.parent_layer parent_layer oit._graph
            do! Assert.spog parent_layer swin.child_layer child_layer oit._graph
        // TODO update when feature layer gets subtypes back
        (*
    // Subtypes
    for Layer'Name, Stcode, Stname in LayerName'Stcode'Stname do

    let individual_layer = Feature_Layer.Iri.feature_layer_by_Name[Layer'Name]

    let individual_subtype =
        Subtype.Iri.individual_subtype_by_Layer'Stcode[$"{Layer'Name}.{Stcode}"]

    let subtype_owl_class =
        Subtype.Iri.subtype_owl_class_by_Layer'Stcode[$"{Layer'Name}.{Stcode}"]

    let layer_owl_class = Feature_Layer.Iri.layer_owl_class[Layer'Name]

    do! Assert.spog individual_layer esri.subtype individual_subtype oit._graph
    do! Assert.spog subtype_owl_class is_a owl.Class oit._graph
    do! Assert.spog subtype_owl_class rdfs.subClassOf layer_owl_class oit._graph
    *)

        // Field Aliases
        for Field'Name, Field'Alias in FieldName'FieldAlias do
            let super_field = Layer_Field.Iri.super_field[Field'Name]
            let! field_alias = swin._prefix Field'Alias
            let! alias = RDF_Literal.simple Field'Alias
            do! Assert.spog super_field owl.sameAs field_alias oit._graph
            do! Assert.spog field_alias swin.name alias oit._graph

        // Layers
        for Layer in LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers do
            let feature_layer = Feature_Layer.Iri.feature_layer_by_Name[Layer.Name]
            let layer_type = Feature_Layer.Iri.layer_type[Layer.Type]
            let layer_name = Feature_Layer.Literal.name[Layer.Name]
            let layer_owl_class = Feature_Layer.Iri.layer_owl_class[Layer.Name]

            do! Assert.spog layer_owl_class is_a owl.Class oit._graph
            do! Assert.spog layer_owl_class rdfs.label layer_name oit._graph
            do! Assert.spog layer_owl_class rdfs.subClassOf swin.Feature oit._graph

            do! Assert.spog feature_layer is_a layer_type oit._graph
            do! Assert.spog layer_type rdfs.subClassOf esri.GPFeatureLayer oit._graph

            try
                let layer_abstract = Feature_Layer.Literal.abstract_description[Layer.Name]
                do! Assert.spog feature_layer swin.name layer_name oit._graph
                do! Assert.spog feature_layer esri.``abstract`` layer_abstract oit._graph
            with
            | _ -> ()


            do! Assert.spog feature_layer swin.currentVersion Feature_Layer.Literal.current_version[Layer.CurrentVersion] oit._graph

            if Layer.GeometryType.IsSome then
                do! Assert.spog feature_layer swin.geometryType Feature_Layer.Iri.geometry_type[Layer.GeometryType.Value] oit._graph

            if Layer.Count.IsSome then
                do! Assert.spog feature_layer swin.count Feature_Layer.Literal.count[Layer.Count.Value] oit._graph


            for Field in Layer.Fields do
                let FieldName = Normalize.field Field.Name
                let layer_field = Layer_Field.Iri.layer_field[$"{Layer.Name}.{FieldName}"]
                let super_field = Layer_Field.Iri.super_field[FieldName]
                let field_type = Layer_Field.Iri.field_type[Field.Type]

                do! Assert.spog layer_field rdfs.subPropertyOf super_field oit._graph
                do! Assert.spog layer_field is_a esri.Field oit._graph
                do! Assert.spog layer_field is_a field_type oit._graph
                do! Assert.spog field_type rdfs.subClassOf esri.Field oit._graph
                do! Assert.spog layer_field swin.name Layer_Field.Literal.name[FieldName] oit._graph
                do! Assert.spog feature_layer swin.field layer_field oit._graph


                if Field.Domain.IsSome then
                    let Domain = Field.Domain.Value

                    let domain = Coded_Value_Domain.Iri.individual_domain[Domain.Name]
                    do! Assert.spog domain is_a esri.CodedValueDomain oit._graph


        // TODO figure out how to handle coded values
        (*
            for CodedValue in Domain.CodedValues do
                let Name = CodedValue.Name.JsonValue.AsString()
                let Code = CodedValue.Code.JsonValue.AsString()

                let coded_value =
                    Coded_Value.Iri.individual_coded_value_by_DomainName'Code[$"{Domain.Name}.{Code}"]

                let code = Coded_Value.Literal.code[Code]

                do! Assert.spog coded_value is_a esri.CodedValue oit._graph
                do! Assert.spog coded_value esri.code code oit._graph


                match Domain.Name with
                | "dDomainSourceYear" ->
                    let! value = RDF_Literal.datatyped Name xsd.gYear
                    do! Assert.spog coded_value esri.value value oit._graph

                | "dDomainFieldComment" ->
                    let! value = RDF_Literal.datatyped Name xsd.positiveInteger
                    do! Assert.spog coded_value esri.value value oit._graph

                | "EnabledDomain" ->
                    let! value = RDF_Literal.datatyped Name xsd.boolean
                    do! Assert.spog coded_value esri.value value oit._graph

                | "dDomainBoolean" ->
                    let! value = RDF_Literal.simple Name
                    let! bool_value = RDF_Literal.datatyped Code xsd.boolean
                    do! Assert.spog coded_value esri.value value oit._graph
                    do! Assert.spog coded_value rdf.value bool_value oit._graph

                | "dDomainLifeCycle"
                | "dDomainPRResolution"
                | "dDomainAccuracyCode"
                | "WhoCreatOrModified"
                | "MediaCode"
                | "AncillaryRoleDomain"
                | "InventoriedBy" ->
                    let! value = RDF_Literal.simple Name
                    do! Assert.spog coded_value esri.value value oit._graph

                | "dDomainPondType"
                | "dDomainEndPointMaterial"
                | "dDomainPipeShape"
                | "dDomainSource"
                | "dDomainDitchSurfType"
                | "DamageType"
                | "dDomainJunctionMaterial"
                | "Outfall Type"
                | "StructureType"
                | "dDomainInletMaterial"
                | "FilterType"
                | "dDomainFilterLocation"
                | "dDomainNonNetwork"
                | "dDomainMaintBy"
                | "dDomainOwner"
                | "dDomainMaterial"
                | "dDomainInventoryType" ->
                    let! value = RDF_Literal.simple Name
                    let! domain_owl_class = interraster._prefix $"{Domain.Name}.{Code}"

                    do! Assert.spog coded_value esri.value value oit._graph
                    do! Assert.spog domain_owl_class is_a owl.Class oit._graph

                | "CompanyDomain"
                | "Crew"
                | "dDomainPipeDia"
                | _ -> ()

            *)
        // Features
        for Feature in Features do
            let feature_layer = Feature_Layer.Iri.feature_layer_by_Name[Feature.LayerName]

            if layer_names_with_unit_ids.Contains(Feature.LayerName) then
                let Unitid = Feature.Unitid.Value
                let individual_feature = Id.Iri.individual_feature_by_Unitid[Unitid]
                let unit_id = Id.Literal.unit_id[Unitid]

                do! Assert.spog feature_layer swin.feature individual_feature oit._graph
                do! Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.UNITID"] unit_id oit._graph


                do! shared_feature_assertions Feature individual_feature

            if layer_names_with_globalids_without_unit_ids.Contains(Feature.LayerName) then
                let Globalid = Feature.Globalid.Value
                let individual_feature = Id.Iri.individual_feature_by_Globalid[Globalid]
                let global_id = Id.Literal.global_id[Globalid]
                do! Assert.spog individual_feature Layer_Field.Iri.layer_field[$"{Feature.LayerName}.GLOBALID"] global_id oit._graph
                do! shared_feature_assertions Feature individual_feature
        (*
            if layer_names_with_global_id_and_unit_ids.Contains(Feature.LayerName) then
                let Unitid = Feature.Unitid.Value
                let Globalid = Feature.Globalid.Value
                let individual_feature_from_unit_id = Id.Iri.individual_feature_by_Unitid[Unitid]

                let individual_feature_from_global_id =
                    Id.Iri.individual_feature_by_Globalid[Globalid]

                do! Assert.spog individual_feature_from_unit_id owl.sameAs individual_feature_from_global_id oit._graph
    *)



















        do! Assert.spog infor.System_License is_a owl.Class oit._graph
        do! Assert.spog infor.Column is_a owl.Class oit._graph
        do! Assert.spog infor.Domain_Column is_a owl.Class oit._graph
        do! Assert.spog infor.Unique_Column is_a owl.Class oit._graph
        do! Assert.spog woedms.Primary_Key_Column is_a owl.Class oit._graph

        do! Assert.spog infor.Domain_Column rdfs.subClassOf infor.Column oit._graph
        do! Assert.spog woedms.Primary_Key_Column rdfs.subClassOf infor.Column oit._graph
        do! Assert.spog infor.LinearAsset rdfs.subClassOf infor.Asset oit._graph
        do! Assert.spog infor.MainlineAsset rdfs.subClassOf infor.Asset oit._graph
        do! Assert.spog infor.SegmentAsset rdfs.subClassOf infor.Asset oit._graph
        do! Assert.spog infor.EquipmentAsset rdfs.subClassOf infor.Asset oit._graph
        do! Assert.spog infor.CompoundAsset rdfs.subClassOf infor.Asset oit._graph
        do! Assert.spog infor.SimpleAsset rdfs.subClassOf infor.Asset oit._graph

        do! Assert.spog woedms.values_depend_on_column is_a owl.ObjectProperty oit._graph
        do! Assert.spog woedms.dependent_column is_a owl.ObjectProperty oit._graph

        do! Assert.spog woedms.values_depend_on_column owl.inverseOf woedms.values_depend_on_column oit._graph

        do! Assert.spog infor.description rdfs.subPropertyOf dcterms.description oit._graph


        for SystemLicense in MetaData.xml.HansenMetadata.SystemLicenses do
            let individual_system_license = systemLicense.iri[SystemLicense.Name]

            do! Assert.spog individual_system_license is_a infor.System_License oit._graph
            do! Assert.spog individual_system_license infor.name hansenDataDistribution.Literal.name[SystemLicense.Name] oit._graph
            if SystemLicense.Description.IsSome
               && SystemLicense.Description.Value
                  <> SystemLicense.Name
               && SystemLicense.Description.Value |> is_not_nullish then
                do! Assert.spog individual_system_license infor.description hansenDataDistribution.Literal.description[SystemLicense.Description.Value] oit._graph
            if SystemLicense.EffectiveDateTime.IsSome then
                do! Assert.spog individual_system_license infor.effectiveDateTime hansenDataDistribution.Literal.effectiveDateTime[SystemLicense.EffectiveDateTime.Value] oit._graph


        for DomainColumn in MetaData.xml.HansenMetadata.DomainColumns do
            let individual_domain_column = domainColumn.iri[DomainColumn.Name]
            let domain_column_type = domainColumn.type_iri[DomainColumn.Type]
            do! Assert.spog individual_domain_column is_a infor.Domain_Column oit._graph
            do! Assert.spog individual_domain_column infor.``type`` domain_column_type oit._graph
            do! Assert.spog individual_domain_column infor.name hansenDataDistribution.Literal.name[DomainColumn.Name] oit._graph
            do! Assert.spog individual_domain_column infor.databaseName hansenDataDistribution.Literal.databaseName[DomainColumn.DatabaseName] oit._graph
            do! Assert.spog individual_domain_column infor.isRequired hansenDataDistribution.Literal.isRequired[DomainColumn.IsRequired] oit._graph
            do! Assert.spog individual_domain_column infor.description hansenDataDistribution.Literal.description[DomainColumn.Text.Description] oit._graph

            if DomainColumn.Text.Remarks.IsSome
               && DomainColumn.Text.Remarks.Value |> is_not_nullish then
                do! Assert.spog individual_domain_column infor.remarks hansenDataDistribution.Literal.remarks[DomainColumn.Text.Remarks.Value] oit._graph
            if DomainColumn.Text.DisplayDescription.IsSome
               && DomainColumn.Text.DisplayDescription.Value
                  |> is_not_nullish
               && DomainColumn.Text.DisplayDescription.Value
                  <> DomainColumn.Text.Description then
                do! Assert.spog individual_domain_column infor.displayDescription hansenDataDistribution.Literal.displayDescription[DomainColumn.Text.DisplayDescription.Value] oit._graph
            if DomainColumn.Text.DisplayTitle.IsSome
               && DomainColumn.Text.DisplayTitle.Value
                  |> is_not_nullish then
                do! Assert.spog individual_domain_column infor.displayTitle hansenDataDistribution.Literal.displayTitle[DomainColumn.Text.DisplayTitle.Value] oit._graph
            if DomainColumn.Text.DisplayTitleLong.IsSome
               && DomainColumn.Text.DisplayTitleLong.Value
                  |> is_not_nullish then
                if DomainColumn.Text.DisplayTitle.IsNone then
                    do! Assert.spog individual_domain_column infor.displayTitleLong hansenDataDistribution.Literal.displayTitleLong[DomainColumn.Text.DisplayTitleLong.Value] oit._graph
                else if DomainColumn.Text.DisplayTitle.IsSome
                        && DomainColumn.Text.DisplayTitle.Value
                           |> is_not_nullish
                        && (DomainColumn.Text.DisplayTitleLong.Value
                            <> DomainColumn.Text.DisplayTitle.Value) then
                    do! Assert.spog individual_domain_column infor.displayTitleLong hansenDataDistribution.Literal.displayTitleLong[DomainColumn.Text.DisplayTitleLong.Value] oit._graph

        for table_type in table.types do
            match table_type with
            | "Table" -> do! Assert.spog infor.Table is_a owl.Class oit._graph
            | _ ->
                let individual_type = table.type_iri[table_type]
                do! Assert.spog individual_type is_a owl.Class oit._graph
                do! Assert.spog individual_type rdfs.subClassOf infor.Table oit._graph

        for ProductFamily in MetaData.xml.HansenMetadata.ProductFamilies do

            let individual_product_family = productFamily.iri[ProductFamily.Name]
            do! Assert.spog individual_product_family is_a infor.Product_Family oit._graph
            do! Assert.spog individual_product_family infor.name hansenDataDistribution.Literal.name[ProductFamily.Name] oit._graph
            if ProductFamily.RequiredSystemLicense.IsSome then
                do! Assert.spog individual_product_family infor.requiredSystemLicense systemLicense.iri[ProductFamily.RequiredSystemLicense.Value.Name] oit._graph
            for Table in ProductFamily.Tables do
                let individual_table = table.iri[$"{ProductFamily.Name}.{Table.Name}"]
                do! Assert.spog individual_table infor.productFamily individual_product_family oit._graph
                do! Assert.spog individual_product_family infor.table individual_table oit._graph

                do! Assert.spog individual_table is_a table.type_iri[Table.Type] oit._graph
                do! Assert.spog individual_table infor.name hansenDataDistribution.Literal.name[Table.Name] oit._graph
                do! Assert.spog individual_table infor.databaseName hansenDataDistribution.Literal.databaseName[Table.DatabaseName] oit._graph
                match table_key_from_name Table.Name with
                | Some key ->
                    let! table_key = RDF_Literal.autotyped key
                    do! Assert.spog individual_table h8importtool.TableKey table_key oit._graph
                | None -> ()

                if Table.DatabaseName.StartsWith("COMP") then
                    do! Assert.spog individual_table is_a infor.AssetType oit._graph

                if Table.Text.Description.IsSome
                   && Table.Text.Description.Value |> is_not_nullish then
                    do! Assert.spog individual_table infor.description hansenDataDistribution.Literal.description[Table.Text.Description.Value] oit._graph
                if Table.Text.Remarks.IsSome
                   && Table.Text.Remarks.Value |> is_not_nullish then
                    do! Assert.spog individual_table infor.remarks hansenDataDistribution.Literal.remarks[Table.Text.Remarks.Value] oit._graph

                for DomainColumnReference in Table.DomainColumnReferences do
                    let individual_column =
                        column.iri[$"{ProductFamily.Name}.{Table.Name}.{DomainColumnReference.Name}"]
                    do! Assert.spog individual_table infor.column individual_column oit._graph
                    do! Assert.spog individual_column infor.table individual_table oit._graph
                    do! Assert.spog individual_column is_a infor.Column oit._graph
                    do! Assert.spog individual_column infor.name hansenDataDistribution.Literal.name[DomainColumnReference.Name] oit._graph
                    do! Assert.spog individual_column infor.domainColumnReference domainColumn.iri[DomainColumnReference.Name] oit._graph


                for Column in Table.Columns do
                    let individual_column =
                        column.iri[$"{ProductFamily.Name}.{Table.Name}.{Column.Name}"]
                    let super_column = column.super_column[Column.Name]

                    do! Assert.spog individual_table infor.column individual_column oit._graph
                    do! Assert.spog individual_column infor.table individual_table oit._graph

                    do! Assert.spog individual_column is_a infor.Column oit._graph
                    do! Assert.spog individual_column rdfs.subPropertyOf super_column oit._graph
                    do! Assert.spog individual_column infor.``type`` column.type_iri[Column.Type] oit._graph
                    do! Assert.spog individual_column infor.name hansenDataDistribution.Literal.name[Column.Name] oit._graph
                    do! Assert.spog individual_column infor.databaseName hansenDataDistribution.Literal.databaseName[Column.DatabaseName] oit._graph
                    do! Assert.spog individual_column infor.length hansenDataDistribution.Literal.length[Column.Length] oit._graph

                    if Column.Text.Remarks.IsSome
                       && Column.Text.Remarks.Value |> is_not_nullish then
                        do! Assert.spog individual_column infor.remarks hansenDataDistribution.Literal.remarks[Column.Text.Remarks.Value] oit._graph
                    if Column.Text.Description.IsSome
                       && Column.Text.Description.Value |> is_not_nullish then
                        do! Assert.spog individual_column infor.description hansenDataDistribution.Literal.description[Column.Text.Description.Value] oit._graph
                    if Column.Text.DisplayDescription.IsSome
                       && Column.Text.DisplayDescription.Value
                          |> is_not_nullish then
                        if Column.Text.Description.IsNone then
                            do! Assert.spog individual_column infor.displayDescription hansenDataDistribution.Literal.displayDescription[Column.Text.DisplayDescription.Value] oit._graph
                        else if Column.Text.Description.IsSome
                                && Column.Text.Description.Value |> is_not_nullish
                                && (Column.Text.DisplayDescription.Value
                                    <> Column.Text.Description.Value) then
                            do! Assert.spog individual_column infor.displayDescription hansenDataDistribution.Literal.displayDescription[Column.Text.DisplayDescription.Value] oit._graph
                    if Column.Text.DisplayTitle.IsSome
                       && Column.Text.DisplayTitle.Value |> is_not_nullish then
                        do! Assert.spog individual_column infor.displayTitle hansenDataDistribution.Literal.displayTitle[Column.Text.DisplayTitle.Value] oit._graph
                    if Column.Text.DisplayTitleLong.IsSome
                       && Column.Text.DisplayTitleLong.Value
                          |> is_not_nullish then
                        if Column.Text.DisplayTitle.IsNone then
                            do! Assert.spog individual_column infor.displayTitleLong hansenDataDistribution.Literal.displayTitleLong[Column.Text.DisplayTitleLong.Value] oit._graph
                        else if Column.Text.DisplayTitle.IsSome
                                && Column.Text.DisplayTitle.Value |> is_not_nullish
                                && (Column.Text.DisplayTitleLong.Value
                                    <> Column.Text.DisplayTitle.Value) then
                            do! Assert.spog individual_column infor.displayTitleLong hansenDataDistribution.Literal.displayTitleLong[Column.Text.DisplayTitleLong.Value] oit._graph


                if Table.PrimaryKeyConstraint.IsSome then
                    for LocalColumnReference in Table.PrimaryKeyConstraint.Value.LocalColumnReferences do
                        let individual_column = column.iri[LocalColumnReference.Name]
                        do! Assert.spog individual_column is_a woedms.Primary_Key_Column oit._graph
                        do! Assert.spog individual_table woedms.primary_key_column individual_column oit._graph

                for ReferencingConstraint in Table.ReferencingConstraints do
                    for index = 0 to ReferencingConstraint.ForeignColumnReferences.Length
                                     - 1 do
                        let local_reference =
                            ReferencingConstraint.LocalColumnReferences[index]
                                .Name
                        let foreign_reference =
                            ReferencingConstraint.ForeignColumnReferences[index]
                                .Name
                        try
                            let local_column = column.iri[local_reference]
                            let foreign_column = column.iri[foreign_reference]

                            do! Assert.spog foreign_column woedms.values_depend_on_column local_column oit._graph
                            do! Assert.spog local_column woedms.dependent_column foreign_column oit._graph
                        with
                        | err -> failwith $"{ProductFamily.Name}.{Table.Name}.{ReferencingConstraint.CommonId} failed with error {err.Message}"

                for ForeignKeyConstraint in Table.ForeignKeyConstraints do
                    for index = 0 to ForeignKeyConstraint.ForeignColumnReferences.Length
                                     - 1 do
                        let local_reference =
                            ForeignKeyConstraint.LocalColumnReferences[index]
                                .Name
                        let foreign_reference =
                            ForeignKeyConstraint.ForeignColumnReferences[index]
                                .Name
                        try
                            let local_column = column.iri[local_reference]
                            let foreign_column = column.iri[foreign_reference]

                            do! Assert.spog foreign_column woedms.dependent_column local_column oit._graph
                            do! Assert.spog local_column woedms.values_depend_on_column foreign_column oit._graph
                        with
                        | err -> failwith $"{ProductFamily.Name}.{Table.Name}.{ForeignKeyConstraint.CommonId} failed with error {err.Message}"

                for EnumerationCheckConstraint in Table.EnumerationCheckConstraints do
                    try
                        do! Assert.spog column.iri[EnumerationCheckConstraint.LocalColumnReference.Name] infor.enumeration enumeration.iri[EnumerationCheckConstraint.EnumerationName] oit._graph
                    with
                    | err -> failwith $"{ProductFamily.Name}.{Table.Name}.{EnumerationCheckConstraint.CommonId} failed with error {err.Message}"
                for UniqueConstraint in Table.UniqueConstraints do
                    for LocalColumnReference in UniqueConstraint.LocalColumnReferences do

                        do! Assert.spog column.iri[LocalColumnReference.Name] is_a infor.Unique_Column oit._graph

        do! Assert.spog woedms.Logical_Mapping is_a owl.Class oit._graph
        do! Assert.spog h8importtool.ProductFamilyOwner rdfs.subPropertyOf h8importtool.MapTableInformation oit._graph
        do! Assert.spog h8importtool.ProductFamilyName rdfs.subPropertyOf h8importtool.MapTableInformation oit._graph
        do! Assert.spog h8importtool.TableName rdfs.subPropertyOf h8importtool.MapTableInformation oit._graph
        do! Assert.spog h8importtool.TableCommonId rdfs.subPropertyOf h8importtool.MapTableInformation oit._graph
        do! Assert.spog h8importtool.TableKey rdfs.subPropertyOf h8importtool.MapTableInformation oit._graph

        do! Assert.spog h8importtool.Maps is_a woedms.Logical_Mapping oit._graph
        do! Assert.spog h8importtool.Maps www2k.xmlns (RDF_Literal.simple "http://www.infor.com/Hansen8/2011/08/Maps.xsd" current_transaction) oit._graph

        for layer_name, table_name in Map.layer'table_names do
            let map_name = Map.esri_to_infor_name (layer_name, table_name)
            let map = Map.iri[map_name]
            do! Assert.spog map is_a h8importtool.Map oit._graph
            do! Assert.spog h8importtool.Maps woedms.map map oit._graph

            do! Assert.spog map woedms.from_layer Feature_Layer.Iri.feature_layer_by_Name[layer_name] oit._graph
            do! Assert.spog map woedms.to_table table.iri[table_name] oit._graph
            // TODO change if ever used on agency defined product family
            do! Assert.spog map h8importtool.ProductFamilyOwner (RDF_Literal.simple "Hansen" current_transaction) oit._graph
            do! Assert.spog map h8importtool.IsDefault RDF_false oit._graph
            do! Assert.spog map h8importtool.Name Map.name[map_name] oit._graph
            do! Assert.spog map h8importtool.SheetName (RDF_Literal.simple layer_name current_transaction) oit._graph
            do! Assert.spog map h8importtool.ProviderName h8importtool._literal.System'Data'OleDb oit._graph
            do! Assert.spog map h8importtool.UploadOption (RDF_Literal.autotyped 6 current_transaction) oit._graph
            do! Assert.spog map h8importtool.IsFirstRowHeader RDF_true oit._graph
            do! Assert.spog map h8importtool.CreatedDate (RDF_Literal.autotyped DateTime.Now current_transaction) oit._graph
            do! Assert.spog map woedms.created_by leonad.collierb oit._graph
            do! Assert.spog map h8importtool.CreatedBy (RDF_Literal.simple @"LEONAD\collierb" current_transaction) oit._graph

        do! Map.layer_field_to_table_column "Conduit" "UNITID" "AssetManagement.Storm" "StormLiftStation" "ID"
        do! Map.layer_field_to_table_column "Conduit" "NOTES" "AssetManagement.Storm" "StormLiftStation" "UnitDesc"
        do! Map.layer_field_to_table_column "Culvert Cross Drain" "UNITID" "AssetManagement.Storm" "StormServiceLine" "ID"
        do! Map.layer_field_to_table_column "Culvert Cross Drain" "NOTES" "AssetManagement.Storm" "StormServiceLine" "UnitDesc"
        do! Map.layer_field_to_table_column "Debris Trap" "UNITID" "AssetManagement.Storm" "StormValve" "ID"
        do! Map.layer_field_to_table_column "Debris Trap" "NOTES" "AssetManagement.Storm" "StormValve" "UnitDesc"
        do! Map.layer_field_to_table_column "Debris Trap" "LOCATION" "AssetManagement.Storm" "StormValve" "AddressQualifier"
        do! Map.layer_field_to_table_column "Debris Trap" "x" "AssetManagement.Storm" "StormValve" "XCoordinate"
        do! Map.layer_field_to_table_column "Debris Trap" "y" "AssetManagement.Storm" "StormValve" "YCoordinate"
        do! Map.layer_field_to_table_column "Ditch" "UNITID" "AssetManagement.Storm" "StormBackflowPreventer" "ID"
        do! Map.layer_field_to_table_column "Ditch" "NOTES" "AssetManagement.Storm" "StormBackflowPreventer" "UnitDesc"
        do! Map.layer_field_to_table_column "End Point" "UNITID" "AssetManagement.Storm" "StormNode" "ID"
        do! Map.layer_field_to_table_column "End Point" "NOTES" "AssetManagement.Storm" "StormNode" "UnitDesc"
        do! Map.layer_field_to_table_column "End Point" "LOCATION" "AssetManagement.Storm" "StormNode" "AddressQualifier"
        do! Map.layer_field_to_table_column "End Point" "x" "AssetManagement.Storm" "StormNode" "XCoordinate"
        do! Map.layer_field_to_table_column "End Point" "y" "AssetManagement.Storm" "StormNode" "YCoordinate"
        do! Map.layer_field_to_table_column "End Point" "ZVALUE" "AssetManagement.Storm" "StormNode" "ZCoordinate"
        do! Map.layer_field_to_table_column "Inlet" "UNITID" "AssetManagement.Storm" "StormInlet" "ID"
        do! Map.layer_field_to_table_column "Inlet" "NOTES" "AssetManagement.Storm" "StormInlet" "UnitDesc"
        do! Map.layer_field_to_table_column "Inlet" "LOCATION" "AssetManagement.Storm" "StormInlet" "AddressQualifier"
        do! Map.layer_field_to_table_column "Inlet" "x" "AssetManagement.Storm" "StormInlet" "XCoordinate"
        do! Map.layer_field_to_table_column "Inlet" "y" "AssetManagement.Storm" "StormInlet" "YCoordinate"
        do! Map.layer_field_to_table_column "Inlet" "ZVALUE" "AssetManagement.Storm" "StormInlet" "ZCoordinate"
        do! Map.layer_field_to_table_column "Junction Fixed" "UNITID" "AssetManagement.Storm" "StormManhole" "ID"
        do! Map.layer_field_to_table_column "Junction Fixed" "NOTES" "AssetManagement.Storm" "StormManhole" "UnitDesc"
        do! Map.layer_field_to_table_column "Junction Fixed" "LOCATION" "AssetManagement.Storm" "StormManhole" "AddressQualifier"
        do! Map.layer_field_to_table_column "Junction Fixed" "x" "AssetManagement.Storm" "StormManhole" "XCoordinate"
        do! Map.layer_field_to_table_column "Junction Fixed" "y" "AssetManagement.Storm" "StormManhole" "YCoordinate"
        do! Map.layer_field_to_table_column "Junction Fixed" "ZVALUE" "AssetManagement.Storm" "StormManhole" "ZCoordinate"
        do! Map.layer_field_to_table_column "Outfall" "UNITID" "AssetManagement.UsageArea" "Complex" "ID"
        do! Map.layer_field_to_table_column "Outfall" "NOTES" "AssetManagement.UsageArea" "Complex" "UnitDesc"
        do! Map.layer_field_to_table_column "Outfall" "x" "AssetManagement.UsageArea" "Complex" "XCoordinate"
        do! Map.layer_field_to_table_column "Outfall" "y" "AssetManagement.UsageArea" "Complex" "YCoordinate"
        do! Map.layer_field_to_table_column "Stormwater Pond" "UNITID" "AssetManagement.Storm" "StormMiscellaneous" "ID"
        do! Map.layer_field_to_table_column "Stormwater Pond" "NOTES" "AssetManagement.Storm" "StormMiscellaneous" "UnitDesc"
        do! Map.layer_field_to_table_column "Stormwater Pond" "LOCATION" "AssetManagement.Storm" "StormMiscellaneous" "AddressQualifier"
        do! Map.layer_field_to_table_column "Stormwater Pond" "x" "AssetManagement.Storm" "StormMiscellaneous" "XCoordinate"
        do! Map.layer_field_to_table_column "Stormwater Pond" "y" "AssetManagement.Storm" "StormMiscellaneous" "YCoordinate"
        do! Map.layer_field_to_table_column "Stormwater Pond" "ZVALUE" "AssetManagement.Storm" "StormMiscellaneous" "ZCoordinate"
        do! Map.layer_field_to_table_column "Stormwater Pond Discharge" "UNITID" "AssetManagement.Storm" "StormLevee" "ID"
        do! Map.layer_field_to_table_column "Stormwater Pond Discharge" "NOTES" "AssetManagement.Storm" "StormLevee" "UnitDesc"
        do! Map.layer_field_to_table_column "Stormwater Pond Discharge" "LOCATION" "AssetManagement.Storm" "StormLevee" "AddressQualifier"
        do! Map.layer_field_to_table_column "Stormwater Pond Discharge" "x" "AssetManagement.Storm" "StormLevee" "XCoordinate"
        do! Map.layer_field_to_table_column "Stormwater Pond Discharge" "y" "AssetManagement.Storm" "StormLevee" "YCoordinate"
        do! Map.layer_field_to_table_column "Stormwater Pond Discharge" "ZVALUE" "AssetManagement.Storm" "StormLevee" "ZCoordinate"











    }

    let shared_terminological_assertions (terminological_concept: RDF_Term) (lexical_sense: RDF_Term) (lexical_entry: RDF_Term) (ontological_entity: RDF_Term) (ontological_predicate: RDF_Term) (transaction: LightningTransaction) =

        Assert.spog terminological_concept is_a termlex.TerminologicalConcept oit._graph transaction
        if ontological_entity <> rdf.nil then
            Assert.spog terminological_concept termlex.isConceptOf ontological_entity oit._graph transaction
            Assert.spog ontological_entity termlex.concept terminological_concept oit._graph transaction

            Assert.spog lexical_entry termlex.evokes terminological_concept oit._graph transaction
            Assert.spog terminological_concept termlex.isEvokedBy lexical_entry oit._graph transaction

            Assert.spog lexical_sense termlex.isLexicalizedSenseOf terminological_concept oit._graph transaction
            Assert.spog terminological_concept termlex.lexicalizedSense lexical_sense oit._graph transaction

            Assert.spog lexical_sense ontolex.reference ontological_entity oit._graph transaction
            Assert.spog ontological_entity ontolex.isReferenceOf lexical_sense oit._graph transaction


        if ontological_predicate <> rdf.nil then
            Assert.spog lexical_entry ontolex.denotes ontological_predicate oit._graph transaction
            Assert.spog ontological_predicate ontolex.isDenotedBy lexical_entry oit._graph transaction

    lmdb_read_write {
        let! current_transaction = lmdb_read_write.Current_Transaction

        do! Assert.spog ontolex.LexicalConcept rdfs.subClassOf skos.Concept oit._graph
        do! Assert.spog termlex.TerminologicalConcept rdfs.subClassOf skos.Concept oit._graph

        do! Assert.spog oit.WOEDMS_Concept_Scheme is_a skos.ConceptScheme oit._graph
        do! Assert.spog oit.GIS_Concept_Scheme is_a skos.ConceptScheme oit._graph

        do! Assert.spog esri_press.a_to_z_gis is_a schemorg.Book oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.title (RDF_Literal.simple "A to Z GIS" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.date (RDF_Literal.autotyped (DateTime.Parse "2024-11-22T19:05:23Z") current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.language (RDF_Literal.simple "en-US" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.``type`` (RDF_Literal.US "dictionary" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.creator (RDF_Literal.simple "Kelly Brownlee" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.publisher (RDF_Literal.simple "ESRI, Incorporated" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.rights (RDF_Literal.US "Copyright Esri 2025. All rights reserved." current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.subject (RDF_Literal.US "Dictionaries" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.subject (RDF_Literal.US "Cartography" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis dce.subject (RDF_Literal.US "Geographic Information Systems" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.isbn (RDF_Literal.simple "9781589488113" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.eisbn (RDF_Literal.simple "9781589488120" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessMode (RDF_Literal.US "textual" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessMode (RDF_Literal.US "visual" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessModeSufficient (RDF_Literal.US "textual,visual" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessModeSufficient (RDF_Literal.US "textual" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessibilityHazard (RDF_Literal.US "none" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessibilityFeature (RDF_Literal.US "readingOrder" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessibilityFeature (RDF_Literal.US "structuralNavigation" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessibilityFeature (RDF_Literal.US "displayTransformability" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessibilityFeature (RDF_Literal.US "tableOfContents" current_transaction) oit._graph
        do! Assert.spog esri_press.a_to_z_gis schemorg.accessibilityFeature (RDF_Literal.US "pageBreakMarkers" current_transaction) oit._graph
        do!
            Assert.spog
                esri_press.a_to_z_gis
                schemorg.accessibilitySummary
                (RDF_Literal.US "The EPUB version of this publication strives to meet WCAG 2.2 Level AA. Alt text is not provided for images illustrating terms, as the term’s definition is presumed to serve this purpose." current_transaction)
                oit._graph
        do! Assert.spog esri_press.a_to_z_gis is_a lexicog.LexicographicResource oit._graph
        do! Assert.spog oit._graph is_a lime.Lexicon oit._graph
        do! Assert.spog oit._graph dce.language (RDF_Literal.simple "en-US" current_transaction) oit._graph
        for article in AZ.articles do

            let article_id = article.Attribute "id"
            let dfn =
                article
                |> AZ.xpath "./descendant::xhtml:dfn"
                |> Array.exactlyOne
            let dfn_id = dfn.Attribute "id"
            let headword = dfn.Value




            let! source_form = Lexical_Form.from_string article.BaseURI
            let! source = RDF_Term.from_atomic_iri { lexical_form_id = source_form.lexical_form_id }
            let! lexicographic_entry = A_to_Z_GIS._prefix article_id
            let! lexical_entry = entry._minuscule headword
            let! lexical_form = data.text.plain headword
            let! canonical_form = RDF_Literal.US headword



            do! Assert.spog esri_press.a_to_z_gis lexicog.entry lexicographic_entry oit._graph
            do! Assert.spog lexicographic_entry is_a lexicog.Entry oit._graph
            do! Assert.spog lexicographic_entry prov.wasDerivedFrom source oit._graph
            do! Assert.spog lexicographic_entry lexicog.describes lexical_entry oit._graph
            do! Assert.spog oit.lexicon lime.entry lexical_entry oit._graph
            do! Assert.spog lexical_entry ontolex.lexicalForm lexical_form oit._graph
            do! Assert.spog lexical_form is_a ontolex.Form oit._graph
            do! Assert.spog lexical_form ontolex.canonicalForm canonical_form oit._graph

            for anchor in article |> AZ.xpath """./descendant::xhtml:a""" do
                let! cross_reference = A_to_Z_GIS._prefix anchor.Value
                do! Assert.spog lexicographic_entry rdfs.seeAlso cross_reference oit._graph
            for figure in
                article
                |> AZ.xpath """./descendant::xhtml:figure""" do
                let src =
                    figure
                    |> AZ.xpath """./descendant::xhtml:img/@src"""
                    |> Array.exactlyOne
                let img_path = Path.Combine(AZ.directory_path, src.Value)
                let! img_form = Lexical_Form.from_string img_path
                let! img_iriref = RDF_Term.from_atomic_iri { lexical_form_id = img_form.lexical_form_id }
                let figcaption =
                    figure
                    |> AZ.xpath """./descendant::xhtml:figcaption"""
                    |> Array.exactlyOne
                let! label = RDF_Literal.US figcaption.Value

                do! Assert.spog lexicographic_entry foaf.depiction img_iriref oit._graph
                do! Assert.spog img_iriref foaf.depicts lexicographic_entry oit._graph
                do! Assert.spog img_iriref rdfs.label label oit._graph


            let sense_list =
                article
                |> AZ.xpath """./descendant::xhtml:ol/xhtml:li"""
            let sense_elements =
                if sense_list.Length > 0 then
                    sense_list
                else
                    [| article |]
            for sense_element in sense_elements do
                let def_spans =
                    sense_element
                    |> AZ.xpath """./descendant::xhtml:span[@epub:type = "def"]"""
                if def_spans.Length = 1 then
                    let! definition = RDF_Literal.US def_spans[0].Value
                    let subject_areas =
                        AZ.field_span_descendant_of sense_element
                        |> Array.collect (fun text -> text.Split(", "))
                    for subject_area in subject_areas do
                        let! lexicographic_subcomponent = A_to_Z_GIS._prefix $"{article_id}.{subject_area}"
                        let! lexicographic_area = A_to_Z_GIS._prefix subject_area
                        let! lexical_sense = sense._minuscule $"{subject_area}.{headword}"
                        let! lexical_usage = usage._minuscule $"{subject_area}.{headword}"
                        let! terminological_concept = concept._minuscule $"gis.{headword}"


                        do! Assert.spog lexicographic_entry lexicog.subComponent lexicographic_subcomponent oit._graph
                        do! Assert.spog lexicographic_subcomponent is_a lexicog.LexicographicComponent oit._graph
                        do! Assert.spog lexicographic_subcomponent lexicog.describes lexical_sense oit._graph
                        do! Assert.spog lexical_entry ontolex.sense lexical_sense oit._graph
                        do! Assert.spog lexical_sense ontolex.isSenseOf lexical_entry oit._graph
                        do! Assert.spog lexical_sense dcterms.subject lexicographic_area oit._graph
                        do! Assert.spog lexicographic_area is_a skos.Concept oit._graph
                        do! Assert.spog lexical_sense ontolex.usage lexical_usage oit._graph
                        do! Assert.spog lexical_usage is_a termlex.Usage oit._graph
                        do! Assert.spog lexical_usage skos.definition definition oit._graph
                        match headword, subject_area with
                        | "feature", _ ->
                            do! Assert.spog terminological_concept skos.narrowMatch concept.infor.asset oit._graph
                            do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry swin.Feature swin.feature
                        | "feature layer", _ ->
                            do! Assert.spog terminological_concept skos.closeMatch concept.infor.table_definition oit._graph
                            do! Assert.spog terminological_concept skos.related concept.gis.feature_class oit._graph
                            do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry swin.Feature_Layer swin.feature_layer
                        | "feature class", _ ->
                            do! Assert.spog terminological_concept skos.closeMatch concept.infor.table_definition oit._graph
                            do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry swin.Feature_Class swin.feature_class
                        | "field", "database structures" ->
                            do! Assert.spog terminological_concept skos.exactMatch concept.infor.column oit._graph
                            do! Assert.spog terminological_concept skos.related concept.gis.column oit._graph
                            do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry swin.Feature_Class swin.feature_class
                        | "column", "computing" -> do! Assert.spog terminological_concept skos.exactMatch concept.infor.column oit._graph
                        | "identifier", _ ->
                            do! Assert.spog terminological_concept skos.exactMatch concept.infor.identification_code oit._graph
                            do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry swin.UNITID rdf.nil
                        | "geodatabase", _ ->
                            do! Assert.spog terminological_concept skos.closeMatch concept.infor.database oit._graph
                            do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry oit.Geodatabase oit.database
                        | "table", _ ->
                            do! Assert.spog terminological_concept skos.exactMatch concept.infor.table oit._graph
                            do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.Table infor.table

                        | _ -> ()

                        let tokens =
                            let doc = nlp.process_single headword
                            let token_list = doc.ToTokenList()
                            token_list
                            |> Seq.toArray
                            |> Array.filter (fun token -> token.Value <> "_")
                            |> Array.map (fun token -> token.Value)

                        if tokens.Length > 1 then
                            do! Assert.spog lexical_entry is_a ontolex.MultiWordExpression oit._graph
                            for index = 0 to tokens.Length - 1 do
                                try
                                    let token = tokens[index]
                                    let! rdf_ordinal = rdf._prefix $"_{index + 1}"
                                    let! lexical_constituent = constituent._minuscule $"{headword}.{token}"
                                    let! lexical_token = entry._minuscule token

                                    do! Assert.spog lexical_constituent is_a decomp.Component oit._graph
                                    do! Assert.spog lexical_entry decomp.constituent lexical_constituent oit._graph
                                    do! Assert.spog lexical_entry rdf_ordinal lexical_constituent oit._graph
                                    do! Assert.spog lexical_constituent decomp.correspondsTo lexical_token oit._graph
                                with
                                | err -> failwith $"headword: {headword} token: {tokens[index]} failed with error {err.Message}"

                        else
                            do! Assert.spog lexical_entry is_a ontolex.Word oit._graph

                else
                    do! Assert.spog lexical_entry is_a ontolex.LexicalEntry oit._graph


    }

    lmdb_read_write {
        let! current_transaction = lmdb_read_write.Current_Transaction

        do! Assert.spog hansen.H8Help_glossary is_a lexicog.LexicographicResource oit._graph
        do! Assert.spog hansen.asset_management is_a skos.Concept oit._graph
        do! Assert.spog hansen.basics is_a skos.Concept oit._graph
        do! Assert.spog hansen.budgeting is_a skos.Concept oit._graph
        do! Assert.spog hansen.cashiering is_a skos.Concept oit._graph
        do! Assert.spog hansen.community_development_and_regulation is_a skos.Concept oit._graph
        do! Assert.spog hansen.code_enforcement is_a skos.Concept oit._graph
        do! Assert.spog hansen.core is_a skos.Concept oit._graph
        do! Assert.spog hansen.customer_service_management is_a skos.Concept oit._graph
        do! Assert.spog hansen.inventory is_a skos.Concept oit._graph
        do! Assert.spog hansen.personalization is_a skos.Concept oit._graph
        do! Assert.spog hansen.resources is_a skos.Concept oit._graph
        do! Assert.spog hansen.service_and_constituent is_a skos.Concept oit._graph
        do! Assert.spog hansen.system is_a skos.Concept oit._graph
        do! Assert.spog hansen.work_management is_a skos.Concept oit._graph
        for term in H8Help_gloss.xml.Terms do
            let headword = term.Word

            let subject_area =
                match term.Family with
                | "am"
                | "assetmanagement" -> "asset_management"
                | "Basics" -> "basics"
                | "BGT" -> "budgeting"
                | "Cashiering" -> "cashiering"
                | "CDR"
                | "cdr" -> "community_development_and_regulation"
                | "ce" -> "code_enforcement"
                | "core"
                | "Core" -> "core"
                | "CSM"
                | "csm" -> "customer_service_management"
                | "inventory" -> "inventory"
                | "pers"
                | "personalization" -> "personalization"
                | "resource"
                | "Resources" -> "resources"
                | "SC" -> "service_and_constituent"
                | "sys"
                | "System" -> "system"
                | "wm" -> "work_management"
                | _ -> term.Family
            let source_uri = new Uri(H8Help_gloss.file_path)
            let! source_form = Lexical_Form.from_string source_uri.AbsoluteUri
            let! source = RDF_Term.from_atomic_iri { lexical_form_id = source_form.lexical_form_id }
            let! lexicographic_entry = hansen._prefix term.Id
            let! lexical_entry = entry._minuscule headword
            let! lexical_form = data.text.plain headword
            let! canonical_form = RDF_Literal.US headword
            let! lexicographic_area = hansen._prefix subject_area

            do! Assert.spog hansen.H8Help_glossary lexicog.entry lexicographic_entry oit._graph
            do! Assert.spog lexicographic_entry is_a lexicog.Entry oit._graph
            do! Assert.spog lexicographic_entry prov.wasDerivedFrom source oit._graph
            do! Assert.spog lexicographic_entry lexicog.describes lexical_entry oit._graph
            do! Assert.spog oit.lexicon lime.entry lexical_entry oit._graph
            do! Assert.spog lexical_entry ontolex.lexicalForm lexical_form oit._graph
            do! Assert.spog lexical_form is_a ontolex.Form oit._graph
            do! Assert.spog lexical_form ontolex.canonicalForm canonical_form oit._graph

            let definitions =
                match term.Def with
                | _ when term.Def.StartsWith("see") ->
                    let referenced_terms =
                        term
                            .Def
                            .TrimStart("see ".ToCharArray())
                            .Replace(", or", ",")
                            .Replace(" or ", ", ")
                            .Split(", ")
                    for referenced_term in referenced_terms do
                        let cross_reference = hansen._prefix referenced_term current_transaction
                        Assert.spog lexicographic_entry rdfs.seeAlso cross_reference oit._graph current_transaction
                    [||]
                | _ when term.Def.Contains("(1)") -> term.Def.Replace("(1) ", "").Split(" (2) ")


                | def -> [| def |]
            let term_has_multiple_definitions = definitions.Length > 1

            for index = 0 to definitions.Length - 1 do
                let rdf_index = index + 1


                let! definition = RDF_Literal.US definitions[index]
                let! lexicographic_subcomponent =
                    if term_has_multiple_definitions then
                        hansen._prefix $"{term.Id}.{subject_area}_{rdf_index}"
                    else
                        hansen._prefix $"{term.Id}.{subject_area}"
                let! lexical_sense =
                    if term_has_multiple_definitions then
                        sense._minuscule $"{subject_area}.{headword}_{rdf_index}"
                    else
                        sense._minuscule $"{subject_area}.{headword}"
                let! lexical_usage =
                    if term_has_multiple_definitions then
                        usage._minuscule $"{subject_area}.{headword}_{rdf_index}"
                    else
                        usage._minuscule $"{subject_area}.{headword}"
                let! terminological_concept =

                    if term_has_multiple_definitions then
                        concept._minuscule $"infor.{headword}_{rdf_index}"
                    else
                        concept._minuscule $"infor.{headword}"

                if term_has_multiple_definitions then
                    let! rdf_ordinal = rdf._prefix $"_{rdf_index}"
                    do! Assert.spog lexicographic_entry rdf_ordinal lexicographic_subcomponent oit._graph


                do! Assert.spog lexicographic_entry lexicog.subComponent lexicographic_subcomponent oit._graph
                do! Assert.spog lexicographic_subcomponent is_a lexicog.LexicographicComponent oit._graph
                do! Assert.spog lexicographic_subcomponent lexicog.describes lexical_sense oit._graph
                do! Assert.spog lexical_entry ontolex.sense lexical_sense oit._graph
                do! Assert.spog lexical_sense ontolex.isSenseOf lexical_entry oit._graph
                do! Assert.spog lexical_sense dcterms.subject lexicographic_area oit._graph
                do! Assert.spog lexicographic_area is_a skos.Concept oit._graph
                do! Assert.spog lexical_sense ontolex.usage lexical_usage oit._graph
                do! Assert.spog lexical_usage is_a termlex.Usage oit._graph
                do! Assert.spog lexical_usage skos.definition definition oit._graph
                do! Assert.spog terminological_concept is_a skos.Concept oit._graph

                match headword with
                | "asset" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.Asset infor.asset
                | "asset type" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.AssetType rdf.nil
                | "table definition" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.Table infor.table
                | "column" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.Column infor.column
                | "database" ->
                    do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry oit.InforProdSql oit.database
                    do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry oit.InforTestSql oit.database
                | "identification code" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.ID rdf.nil

                | _ -> ()

            let tokens =
                let doc = nlp.process_single headword
                let token_list = doc.ToTokenList()
                token_list
                |> Seq.toArray
                |> Array.filter (fun token -> token.Value <> "_")
                |> Array.map (fun token -> token.Value)

            if tokens.Length > 1 then
                do! Assert.spog lexical_entry is_a ontolex.MultiWordExpression oit._graph
                for index = 0 to tokens.Length - 1 do
                    try
                        let token = tokens[index]
                        let! rdf_ordinal = rdf._prefix $"_{index + 1}"
                        let! lexical_constituent = constituent._minuscule $"{headword}.{token}"
                        let! lexical_token = entry._minuscule token

                        do! Assert.spog lexical_constituent is_a decomp.Component oit._graph
                        do! Assert.spog lexical_entry decomp.constituent lexical_constituent oit._graph
                        do! Assert.spog lexical_entry rdf_ordinal lexical_constituent oit._graph
                        do! Assert.spog lexical_constituent decomp.correspondsTo lexical_token oit._graph
                    with
                    | err -> failwith $"headword: {headword} token: {tokens[index]} failed with error {err.Message}"

            else
                do! Assert.spog lexical_entry is_a ontolex.Word oit._graph




    }
    // TODO next test
    (*
    lmdb_read_write {
    let! transaction = lmdb_read_write.Current_Transaction

    let key = Encoding.UTF8.GetBytes "Lexical_Form_ID"
    let value = 411472UL.to_byte_array

    let result =
        transaction.Put(
            Lightning_Memory_Map.ID_Kind'Next_ID.handle,
            key,
            value
        )

    return result
}

    *)

    lmdb_read_write {
        let! current_transaction = lmdb_read_write.Current_Transaction

        do! Assert.spog hansen.Metadata is_a lexicog.LexicographicResource oit._graph
        let asset_columns =
            Array.concat [|

                            MetaData.navigator
                            |> xpath """//productFamily[@name = "AssetManagement.AgencyDefined"]/table[@name = "SimpleAgencyAsset"]/column"""
                            MetaData.navigator |> xpath """//domainColumn"""

                             |]
        for asset_column in asset_columns do
            let headword = asset_column.Attribute "name"
            let database_name = asset_column.Attribute "databaseName"

            let subject_area = "asset_management"
            let source_uri = new Uri(MetaData.file_path)
            let! source_form = Lexical_Form.from_string source_uri.AbsoluteUri
            let! source = RDF_Term.from_atomic_iri { lexical_form_id = source_form.lexical_form_id }
            let! lexicographic_entry = hansen._prefix database_name
            let! lexical_entry = entry._minuscule headword
            let! lexical_form = data.text.plain headword
            let! canonical_form = RDF_Literal.US headword
            let! lexicographic_area = hansen._prefix subject_area

            do! Assert.spog hansen.Metadata lexicog.entry lexicographic_entry oit._graph
            do! Assert.spog lexicographic_entry is_a lexicog.Entry oit._graph
            do! Assert.spog lexicographic_entry prov.wasDerivedFrom source oit._graph
            do! Assert.spog lexicographic_entry lexicog.describes lexical_entry oit._graph
            do! Assert.spog oit.lexicon lime.entry lexical_entry oit._graph
            do! Assert.spog lexical_entry ontolex.lexicalForm lexical_form oit._graph
            do! Assert.spog lexical_form is_a ontolex.Form oit._graph
            do! Assert.spog lexical_form ontolex.canonicalForm canonical_form oit._graph

            let asset_description =
                asset_column
                |> xpath ".//@description"
                |> Array.exactlyOne
            let asset_displayDescription =
                asset_column
                |> xpath ".//@displayDescription"
                |> Array.exactlyOne
            let! definition =
                match asset_displayDescription.Value, asset_description.Value with
                | displayDescription, _ when not (String.IsNullOrWhiteSpace(displayDescription)) -> RDF_Literal.US displayDescription
                | _, _ -> RDF_Literal.US asset_description.Value

            let! lexicographic_subcomponent = hansen._prefix $"{database_name}.{subject_area}"
            let! lexical_sense = sense._minuscule $"{subject_area}.{headword}"
            let! lexical_usage = usage._minuscule $"{subject_area}.{headword}"
            let! terminological_concept = concept._minuscule $"infor.{headword}"

            do! Assert.spog lexicographic_entry lexicog.subComponent lexicographic_subcomponent oit._graph
            do! Assert.spog lexicographic_subcomponent is_a lexicog.LexicographicComponent oit._graph
            do! Assert.spog lexicographic_subcomponent lexicog.describes lexical_sense oit._graph
            do! Assert.spog lexical_entry ontolex.sense lexical_sense oit._graph
            do! Assert.spog lexical_sense ontolex.isSenseOf lexical_entry oit._graph
            do! Assert.spog lexical_sense dcterms.subject lexicographic_area oit._graph
            do! Assert.spog lexicographic_area is_a skos.Concept oit._graph
            do! Assert.spog lexical_sense ontolex.usage lexical_usage oit._graph
            do! Assert.spog lexical_usage is_a termlex.Usage oit._graph
            do! Assert.spog lexical_usage skos.definition definition oit._graph
            do! Assert.spog terminological_concept is_a skos.Concept oit._graph

            match headword with
            | "ID" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.ID rdf.nil
            | "UnitDesc" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.UnitDesc rdf.nil
            | "AddressQualifier" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.AddressQualifier rdf.nil
            | "XCoordinate" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.XCoordinate rdf.nil
            | "YCoordinate" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.YCoordinate rdf.nil
            | "ZCoordinate" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.ZCoordinate rdf.nil
            | _ -> ()

            let tokens =
                let doc = nlp.process_single headword
                let token_list = doc.ToTokenList()
                token_list
                |> Seq.toArray
                |> Array.filter (fun token -> token.Value <> "_")
                |> Array.map (fun token -> token.Value)

            if tokens.Length > 1 then
                do! Assert.spog lexical_entry is_a ontolex.MultiWordExpression oit._graph
                for index = 0 to tokens.Length - 1 do
                    try
                        let token = tokens[index]
                        let! rdf_ordinal = rdf._prefix $"_{index + 1}"
                        let! lexical_constituent = constituent._minuscule $"{headword}.{token}"
                        let! lexical_token = entry._minuscule token

                        do! Assert.spog lexical_constituent is_a decomp.Component oit._graph
                        do! Assert.spog lexical_entry decomp.constituent lexical_constituent oit._graph
                        do! Assert.spog lexical_entry rdf_ordinal lexical_constituent oit._graph
                        do! Assert.spog lexical_constituent decomp.correspondsTo lexical_token oit._graph
                    with
                    | err -> failwith $"headword: {headword} token: {tokens[index]} failed with error {err.Message}"

            else
                do! Assert.spog lexical_entry is_a ontolex.Word oit._graph




    }



    lmdb_read_write {
        let! current_transaction = lmdb_read_write.Current_Transaction

        do! Assert.spog hansen.Reference_Guide is_a lexicog.LexicographicResource oit._graph
        let manual_definitions =
            [|

               "Data layer", "The main component of the data layer is an Oracle or SQL Server database that stores the agency’s data. The data layer consists of an Oracle or SQL Server database that stores your agency’s data."
               "Business layer", "The purpose of the Infor Public Sector business layer is to make the system’s full range of business logic accessible by isolating it from both the database and the user interface. "
               "Presentation layer", "Conceptually, the presentation layer is the simplest of the three layers—it’s the user interface. I"
               "Storm Inlet", "An inlet is an opening in a storm main that serves as a drainage point for surface wate"


               |]
        for definiendum, definiens in manual_definitions do

            let subject_area = "asset_management"
            let! lexicographic_entry = hansen._prefix definiendum
            let! lexical_entry = entry._minuscule definiendum
            let! lexical_form = data.text.plain definiendum
            let! canonical_form = RDF_Literal.US definiendum
            let! lexicographic_area = hansen._prefix subject_area

            do! Assert.spog hansen.Reference_Guide lexicog.entry lexicographic_entry oit._graph
            do! Assert.spog lexicographic_entry is_a lexicog.Entry oit._graph
            do! Assert.spog lexicographic_entry lexicog.describes lexical_entry oit._graph
            do! Assert.spog oit.lexicon lime.entry lexical_entry oit._graph
            do! Assert.spog lexical_entry ontolex.lexicalForm lexical_form oit._graph
            do! Assert.spog lexical_form is_a ontolex.Form oit._graph
            do! Assert.spog lexical_form ontolex.canonicalForm canonical_form oit._graph

            let! definition = RDF_Literal.US definiens

            let! lexicographic_subcomponent = hansen._prefix $"reference_guide.{subject_area}"
            let! lexical_sense = sense._minuscule $"{subject_area}.{definiendum}"
            let! lexical_usage = usage._minuscule $"{subject_area}.{definiendum}"
            let! terminological_concept = concept._minuscule $"infor.{definiendum}"

            do! Assert.spog lexicographic_entry lexicog.subComponent lexicographic_subcomponent oit._graph
            do! Assert.spog lexicographic_subcomponent is_a lexicog.LexicographicComponent oit._graph
            do! Assert.spog lexicographic_subcomponent lexicog.describes lexical_sense oit._graph
            do! Assert.spog lexical_entry ontolex.sense lexical_sense oit._graph
            do! Assert.spog lexical_sense ontolex.isSenseOf lexical_entry oit._graph
            do! Assert.spog lexical_sense dcterms.subject lexicographic_area oit._graph
            do! Assert.spog lexicographic_area is_a skos.Concept oit._graph
            do! Assert.spog lexical_sense ontolex.usage lexical_usage oit._graph
            do! Assert.spog lexical_usage is_a termlex.Usage oit._graph
            do! Assert.spog lexical_usage skos.definition definition oit._graph
            do! Assert.spog terminological_concept is_a skos.Concept oit._graph

            match definiendum with
            | "Data layer" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry rdf.nil infor.data_layer
            | "Business layer" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry rdf.nil infor.business_layer
            | "Presentation layer" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry rdf.nil infor.presentation_layer
            | "Storm Inlet" -> do! shared_terminological_assertions terminological_concept lexical_sense lexical_entry infor.Hansen.AssetManagement.Storm.StormInlet.table rdf.nil
            | _ -> ()

            let tokens =
                let doc = nlp.process_single definiendum
                let token_list = doc.ToTokenList()
                token_list
                |> Seq.toArray
                |> Array.filter (fun token -> token.Value <> "_")
                |> Array.map (fun token -> token.Value)

            if tokens.Length > 1 then
                do! Assert.spog lexical_entry is_a ontolex.MultiWordExpression oit._graph
                for index = 0 to tokens.Length - 1 do
                    try
                        let token = tokens[index]
                        let! rdf_ordinal = rdf._prefix $"_{index + 1}"
                        let! lexical_constituent = constituent._minuscule $"{definiendum}.{token}"
                        let! lexical_token = entry._minuscule token

                        do! Assert.spog lexical_constituent is_a decomp.Component oit._graph
                        do! Assert.spog lexical_entry decomp.constituent lexical_constituent oit._graph
                        do! Assert.spog lexical_entry rdf_ordinal lexical_constituent oit._graph
                        do! Assert.spog lexical_constituent decomp.correspondsTo lexical_token oit._graph
                    with
                    | err -> failwith $"definiendum: {definiendum} token: {tokens[index]} failed with error {err.Message}"

            else
                do! Assert.spog lexical_entry is_a ontolex.Word oit._graph




    }




// TODO sort out concept mapping vs entity mapping (changes these to skos:Concepts)
(*


        do! Assert.spog gis.DESCRIPTION h8importtool.MapColumn infor.UnitDesc oit._graph
        do! Assert.spog gis.DIAMETER h8importtool.MapColumn infor.Diameter oit._graph

        do! Assert.spog gis.DOWNSTREAMDEPTH h8importtool.MapColumn infor.DownstreamDepth oit._graph
        do! Assert.spog gis.DOWNSTREAMELEVATION h8importtool.MapColumn infor.DownstreamElevation oit._graph
        do! Assert.spog gis.DOWNSTREAMELEVATION h8importtool.MapColumn infor.DownstreamInvertElevation oit._graph
        do! Assert.spog gis.INVERTELEV h8importtool.MapColumn infor.InvertElevation oit._graph
        do! Assert.spog gis.UPSTREAMELEVATION h8importtool.MapColumn infor.UpstreamElevation oit._graph
        do! Assert.spog gis.UPSTREAMELEVATION h8importtool.MapColumn infor.UpstreamInvertElevation oit._graph
        do! Assert.spog gis.UPSTREAMDEPTH h8importtool.MapColumn infor.UpstreamDepth oit._graph

        do! Assert.spog gis.LFEET h8importtool.MapColumn infor.Length oit._graph
        do! Assert.spog gis.LFEET h8importtool.MapColumn infor.ConnectionPipeLength oit._graph
        do! Assert.spog gis.LFEET h8importtool.MapColumn infor.JointLength oit._graph
        do! Assert.spog gis.LFEET h8importtool.MapColumn infor.PipeLength oit._graph

        do! Assert.spog gis.MAINTBY h8importtool.MapColumn infor.Responsibility oit._graph
        do! Assert.spog gis.OWNER h8importtool.MapColumn infor.Ownership oit._graph

        do! Assert.spog gis.MATERIAL h8importtool.MapColumn infor.ConstructionMaterial oit._graph
        do! Assert.spog gis.MATERIAL h8importtool.MapColumn infor.Material oit._graph
        do! Assert.spog gis.MATERIAL h8importtool.MapColumn infor.PipeMaterial oit._graph
        do! Assert.spog gis.MATERIAL h8importtool.MapColumn infor.RingsMaterial oit._graph
        do! Assert.spog gis.MATERIAL h8importtool.MapColumn infor.StepsMaterial oit._graph
        do! Assert.spog gis.MATERIAL h8importtool.MapColumn infor.WallMaterial oit._graph

        do! Assert.spog gis.NOTES h8importtool.MapColumn infor.UnitDesc oit._graph
        do! Assert.spog gis.PIPESHAPE h8importtool.MapColumn infor.PipeShape oit._graph
        do! Assert.spog gis.WIDTH h8importtool.MapColumn infor.Width oit._graph

        do! Assert.spog gis.x_coordinate h8importtool.MapColumn infor.XCoordinate oit._graph
        do! Assert.spog gis.y_coordinate h8importtool.MapColumn infor.YCoordinate oit._graph
        do! Assert.spog gis.z_coordinate h8importtool.MapColumn infor.ZCoordinate oit._graph

        do! Assert.spog gis.LOCATION h8importtool.MapColumn infor.AddressQualifier oit._graph


    *)
stopwatch.Stop()












































module Tabular =
    module Hypertext =

        let table_from_rows (rows: string array array) =
            table {
                if rows.Length > 0 then
                    thead {
                        tr {
                            for header in rows[0] do
                                th { header }
                        }
                    }

                    tbody {
                        for row in rows[1..] do
                            tr {
                                for cell in row do
                                    td { cell }
                            }
                    }
            }

        let document_from_layers (stem: string) (tabular_content_by_layer: (string * string array array) array) =
            html {
                _lang "en"
                style {
                    _type "text/css"
                    """
                body {
                    font-family: Tahoma
                }

                table {
                    font-size: 90%;
                    vertical-align: top;
                    border-style: solid;
                    border-width: 0px;
                    border-color: gray;
                    border-collapse: collapse;
                    border-spacing: 1pt;
                    background-color: white
                }

                th {
                    text-align: left;
                    font-family: Verdana;
                    vertical-align: bottom
                }

                tr {
                    vertical-align: top
                }

                a {}

                td {
                    border-width: 1px;
                    border-color: black;
                    padding: 2px;
                    border-style: solid;
                    border-collapse: collapse;
                    border-spacing: 1pt;
                    background-color: white
                }

                hr {
                    color: #3333FF;
                }
                """
                }
                head {
                    meta { _charset "utf-8" }
                    title stem
                }

                body {
                    for layer_name, rows_in_layer in tabular_content_by_layer do
                        h2 { layer_name }
                        table_from_rows rows_in_layer
                }
            }

        let render_document (stem: string) tabular_content_by_layer =
            tabular_content_by_layer
            |> document_from_layers stem
            |> Render.toHtmlDocString

        let render_table rows =
            rows |> table_from_rows |> Render.toString

    module Csv =

        let escape (value: string) =
            let requires_quotes =
                value.Contains(",")
                || value.Contains("\"")
                || value.Contains("\n")
                || value.Contains("\r")

            let escaped = value.Replace("\"", "\"\"")

            if requires_quotes then
                $"\"{escaped}\""
            else
                escaped

        let row (cells: string array) =
            cells |> Array.map escape |> String.concat ","

        let save (file_content: string) (stem: string) =
            let file_path = Path.Combine(csv_directory_path, $"{stem}.csv")
            File.WriteAllText(file_path, file_content)


    module Xlsx =


        let private sanitize_sheet_name (sheet_name: string) =
            let invalid_characters = Regex(@"[\[\]\*\?/\\:]")

            let sanitized = invalid_characters.Replace(sheet_name, "_").Trim()

            let non_empty =
                if System.String.IsNullOrWhiteSpace(sanitized) then
                    "Sheet"
                else
                    sanitized

            if non_empty.Length > 31 then
                non_empty.Substring(0, 31)
            else
                non_empty

        let private unique_sheet_name (existing_names: Set<string>) (base_name: string) =
            let candidate = sanitize_sheet_name base_name

            if not (existing_names.Contains candidate) then
                candidate
            else
                let rec loop index =
                    let suffix = $"_{index}"

                    let max_base_length = 31 - suffix.Length

                    let truncated_base =
                        if candidate.Length > max_base_length then
                            candidate.Substring(0, max_base_length)
                        else
                            candidate

                    let next_candidate = $"{truncated_base}{suffix}"

                    if existing_names.Contains next_candidate then
                        loop (index + 1)
                    else
                        next_candidate

                loop 2

        let workbook_from_layers (tabular_content_by_layer: (string * string array array) array) (workbook: XLWorkbook) =

            let mutable sheet_names = Set.empty

            for layer_name, rows_in_layer in tabular_content_by_layer do
                let sheet_name = unique_sheet_name sheet_names layer_name

                sheet_names <- sheet_names.Add sheet_name

                let worksheet = workbook.Worksheets.Add sheet_name

                for row_index = 0 to rows_in_layer.Length - 1 do
                    let row = rows_in_layer[row_index]

                    for column_index = 0 to row.Length - 1 do
                        worksheet.Cell(row_index + 1, column_index + 1).Value <- row[column_index]

                if rows_in_layer.Length > 0 then
                    let header_range = worksheet.Range(1, 1, 1, rows_in_layer[0].Length)

                    header_range.Style.Font.Bold <- true
                    header_range.Style.Alignment.Horizontal <- XLAlignmentHorizontalValues.Center

                    worksheet.SheetView.FreezeRows(1)

                worksheet.Columns().AdjustToContents() |> ignore

            workbook

        let save (workbook: XLWorkbook) (stem: string) (tabular_content_by_layer: (string * string array array) array) =
            use workbook = workbook_from_layers tabular_content_by_layer workbook
            let file_path = Path.Combine(xlsx_directory_path, $"{stem}.xlsx")


            workbook.SaveAs(file_path)



module NetRdf =
    let PREFIX (prefix_label: string) (namespace_name: Lexical_Form) (graph: VDS.RDF.IGraph) =

        graph.NamespaceMap.AddNamespace(prefix_label, new Uri(namespace_name.string_value))

    let triplestore = new VDS.RDF.ThreadSafeTripleStore()

    module NQuads =
        let parser = NQuadsParser()

        let parse (quads: Quad array) (triplestore: VDS.RDF.ITripleStore) (transaction: LightningTransaction) =

            let text =
                quads
                |> Array.map (fun quad -> Quad.nq quad transaction)
                |> String.concat "\n"

            use reader = new StringReader(text)
            parser.Load(triplestore, reader)

    module NTriples =
        let parser = NTriplesParser()

        let parse_quads (quads: Quad array) (graph: VDS.RDF.IGraph) (transaction: LightningTransaction) =

            let text =
                quads
                |> Array.map Quad.to_Triple
                |> Array.map (fun triple -> Triple.nt triple transaction)
                |> String.concat "\n"
            try
                use reader = new StringReader(text)
                parser.Load(graph, reader)
            with
            | err ->
                clip text
                failwith err.Message



        let parse_triples (triples: Triple array) (graph: VDS.RDF.IGraph) (transaction: LightningTransaction) =

            let text =
                triples
                |> Array.map (fun triple -> Triple.nt triple transaction)
                |> String.concat "\n"

            use reader = new StringReader(text)
            parser.Load(graph, reader)

    module Turtle =


        let writer =
            let writer = new CompressingTurtleWriter(TurtleSyntax.Rdf11Star)
            writer.HighSpeedModePermitted <- false
            writer.PrettyPrintMode <- true
            writer

        let write (file_path: string) (graph: VDS.RDF.IGraph) = writer.Save(graph, file_path)

    module Trig =
        let writer =
            let writer = new TriGWriter()
            writer.HighSpeedModePermitted <- false
            writer.PrettyPrintMode <- true
            writer

        let write (file_path: string) (triplestore: VDS.RDF.ITripleStore) = writer.Save(triplestore, file_path)




let serialize_ttl (graph: VDS.RDF.IGraph) (quads: Quad array) (stem: string) =

    lmdb_read_only { do! NetRdf.NTriples.parse_quads quads graph }

    graph |> NetRdf.PREFIX "owl" owl._namespace_name
    graph |> NetRdf.PREFIX "prov" prov._namespace_name
    graph
    |> NetRdf.PREFIX "termlex" termlex._namespace_name
    graph |> NetRdf.PREFIX "foaf" foaf._namespace_name
    graph
    |> NetRdf.PREFIX "hansen" hansen._namespace_name
    graph |> NetRdf.PREFIX "skos" skos._namespace_name
    graph
    |> NetRdf.PREFIX "A_to_Z_GIS" A_to_Z_GIS._namespace_name
    graph
    |> NetRdf.PREFIX "concept" concept._namespace_name
    graph
    |> NetRdf.PREFIX "constituent" constituent._namespace_name
    graph
    |> NetRdf.PREFIX "ontolex" ontolex._namespace_name
    graph
    |> NetRdf.PREFIX "lexicog" lexicog._namespace_name
    graph
    |> NetRdf.PREFIX "decomp" decomp._namespace_name
    graph
    |> NetRdf.PREFIX "sense" sense._namespace_name
    graph
    |> NetRdf.PREFIX "usage" usage._namespace_name
    graph
    |> NetRdf.PREFIX "esri_press" esri_press._namespace_name
    graph
    |> NetRdf.PREFIX "entry" entry._namespace_name
    graph |> NetRdf.PREFIX "lime" lime._namespace_name
    graph |> NetRdf.PREFIX "" data._namespace_name

    graph
    |> NetRdf.PREFIX "dcterms" dcterms._namespace_name

    graph
    |> NetRdf.PREFIX "LCPW_OverlayStormwaterInfrastructure_D_WM" LCPW_OverlayStormwaterInfrastructure_D_WM._namespace_name

    graph |> NetRdf.PREFIX "esri" esri._namespace_name

    graph |> NetRdf.PREFIX "lcg" lcg._namespace_name

    graph |> NetRdf.PREFIX "oit" oit._namespace_name

    graph
    |> NetRdf.PREFIX "woedms" woedms._namespace_name

    graph |> NetRdf.PREFIX "swin" swin._namespace_name

    graph
    |> NetRdf.PREFIX "LCG_Stormwater_Inventory" LCG_Stormwater_Inventory._namespace_name

    graph
    |> NetRdf.PREFIX "infor" infor._namespace_name

    graph
    |> NetRdf.PREFIX "h8importtool" h8importtool._namespace_name
    graph
    |> NetRdf.PREFIX "leonad" leonad._namespace_name

    let file_path = Path.Combine(rdf_directory_path, $"{stem}.ttl")
    graph |> NetRdf.Turtle.write file_path










































// TODO serialize mapping to h8importtool xml!!!
// TODO serialize to documentation!

// TODO inspect properties sharing subjects and objects for any redundancies
// TODO separate querying into separate file/instantiation
let mappings =

    lmdb_read_only {
        let! map_quads =
            Graph_Pattern._pog is_a h8importtool.Map oit._graph
            |> Quad_Query.quads_by_pattern
        return!
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V [| for quad in map_quads -> quad.subject |> RDF_Subject.term |]
            |> Graph_Traversal.bothE
            |> Graph_Traversal.to_quads


    }

let map_columns =

    lmdb_read_only {
        let! map_column_quads =
            Graph_Pattern._pog is_a h8importtool.MapColumn oit._graph
            |> Quad_Query.quads_by_pattern
        return!
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V [| for quad in map_column_quads -> quad.subject |> RDF_Subject.term |]
            |> Graph_Traversal.bothE
            |> Graph_Traversal.to_quads


    }


let source_field_quads =
    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        let! source_field_quads =
            Graph_Pattern._p_g woedms.from_field oit._graph
            |> Quad_Query.quads_by_pattern
        let distinct_terms =
            [| for quad in source_field_quads do
                   quad.object |> RDF_Object.term |]
            |> Array.distinctBy (fun term -> RDF_Term.term_id term)
        return!
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V distinct_terms
            |> Graph_Traversal.bothE
            |> Graph_Traversal.to_quads
    }

let target_column_quads =
    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        let! target_column_quads =
            Graph_Pattern._p_g woedms.to_column oit._graph
            |> Quad_Query.quads_by_pattern
        let distinct_terms =
            [| for quad in target_column_quads do
                   quad.object |> RDF_Object.term |]
            |> Array.distinctBy (fun term -> RDF_Term.term_id term)
        return!
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V distinct_terms
            |> Graph_Traversal.bothE
            |> Graph_Traversal.to_quads
    }

let source_field_terms =
    source_field_quads
    |> Array.map (fun quad -> quad.subject |> RDF_Subject.term)
    |> Array.distinctBy (fun term -> RDF_Term.term_id term)

let layer'unitid_terms =
    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        return
            source_field_terms
            |> Array.choose (fun term ->
                let (RDF_Term.FromNamespacedIRI (term_id, term_iri)) = term
                let local_name =
                    Get.String_by_Lexical_Form_ID term_iri.local_name_id current_transaction
                if
                    local_name.Contains("UNITID")
                    && not (local_name.Contains("Hansen"))
                then
                    let to_period = local_name.IndexOf(".") - 1
                    let layer_name = local_name[..to_period]
                    Some(layer_name, term)
                else
                    None

            )

    }
    |> Array.distinct

let target_sample_size = 1

let sample_features_by_layer =

    lmdb_read_only {

        let! current_transaction = lmdb_read_only.Current_Transaction
        return
            layer'unitid_terms
            |> Array.choose (fun (layer_name, unitid_term) ->

                let unitid_quads =
                    Quad_Query.quads_by_pattern (Graph_Pattern._p_g unitid_term oit._graph) current_transaction

                if unitid_quads.Length > 0 then
                    Some(layer_name, unitid_quads)
                else
                    None)
            |> Array.map (fun (layer_name, unitid_quads) ->
                let sample_size =
                    if unitid_quads.Length < target_sample_size then
                        unitid_quads.Length
                    else
                        target_sample_size

                let sample_features =
                    unitid_quads
                    |> Array.randomSample sample_size
                    |> Array.map (fun quad -> quad.subject |> RDF_Subject.term)


                let sample_quads =
                    Graph_Traversal.traversal_with_graph oit._graph
                    |> Graph_Traversal.V sample_features
                    |> Graph_Traversal.bothE
                    |> Graph_Traversal.to_quads
                    <| current_transaction
                layer_name, sample_quads

            )

    }

let features_by_layer =

    lmdb_read_only {

        let! current_transaction = lmdb_read_only.Current_Transaction
        return
            layer'unitid_terms
            |> Array.choose (fun (layer_name, unitid_term) ->

                let unitid_quads =
                    Quad_Query.quads_by_pattern (Graph_Pattern._p_g unitid_term oit._graph) current_transaction

                if unitid_quads.Length > 0 then
                    Some(layer_name, unitid_quads)
                else
                    None)
            |> Array.map (fun (layer_name, unitid_quads) ->

                let features =
                    unitid_quads
                    |> Array.map (fun quad -> quad.subject |> RDF_Subject.term)


                let feature_quads =
                    Graph_Traversal.traversal_with_graph oit._graph
                    |> Graph_Traversal.V features
                    |> Graph_Traversal.bothE
                    |> Graph_Traversal.to_quads
                    <| current_transaction
                layer_name, feature_quads

            )

    }


// TODO move to string extension
let contains_substring_from (substrings: string array) (value: string) =
    substrings
    |> Array.exists (fun substring -> value.Contains substring)






let sample_quads =
    sample_features_by_layer
    |> Array.collect (fun (layer_name, sample_quads_in_layer) -> sample_quads_in_layer)


let sample_features =
    sample_quads
    |> Array.map (fun quad -> quad.subject |> RDF_Subject.term)
    |> Array.distinctBy (fun term -> RDF_Term.term_id term)

let sample_layers =
    sample_quads
    |> Array.Parallel.filter (fun quad -> RDF_Predicate.term quad.predicate = swin.feature)
    |> Array.map (fun quad -> quad.subject |> RDF_Subject.term)
    |> Array.distinctBy (fun term -> RDF_Term.term_id term)

let sample_layer_quads =
    lmdb_read_only {
        return!
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V sample_layers
            |> Graph_Traversal.inE swin.layer
            |> Graph_Traversal.to_quads

    }

let metadata_quads =
    Array.concat [|

                    mappings
                    map_columns
                    source_field_quads
                    target_column_quads

                     |]



let columns_by_layer quads_by_layer =

    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        return
            quads_by_layer
            |> Array.map (fun (layer_name, sample_quads_in_layer) ->
                let columns_in_layer =
                    sample_quads_in_layer
                    |> Array.filter (fun quad -> RDF_Predicate.term quad.predicate = swin.feature)
                    |> Array.collect (fun quad ->
                        let layer_term = RDF_Subject.term quad.subject
                        Quad_Query.quads_by_pattern (Graph_Pattern.sp_g layer_term swin.field oit._graph) current_transaction)
                    |> Array.map (fun quad ->

                        match RDF_Object.term quad.object with
                        | RDF_Term.FromNamespacedIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.local_name_id current_transaction
                        | RDF_Term.FromSimpleLiteral (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id current_transaction
                        | RDF_Term.FromDatatypedLiteral (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id current_transaction
                        | RDF_Term.FromRegionString (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id current_transaction

                    )
                (layer_name, columns_in_layer)

            )

    }

let column_cells_by_layer_feature quads_by_layer =

    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        return
            quads_by_layer
            |> Array.map (fun (layer_name, sample_quads_in_layer) ->
                let column_cells_in_layer =
                    sample_quads_in_layer
                    |> Array.filter (fun quad -> RDF_Predicate.term quad.predicate <> swin.feature)
                    |> Array.groupBy (fun quad -> RDF_Subject.term quad.subject)
                    |> Array.map (fun (feature, feature_quads) ->
                        feature_quads
                        |> Array.map (fun quad ->
                            let column =
                                match RDF_Predicate.term quad.predicate with
                                | RDF_Term.FromNamespacedIRI (term_id, term) ->
                                    let local_name =
                                        Get.String_by_Lexical_Form_ID term.local_name_id current_transaction
                                    match local_name with
                                    // TODO consider any column name overrides
                                    | _ -> local_name
                            let cell =
                                match RDF_Object.term quad.object with
                                | RDF_Term.FromNamespacedIRI (term_id, term) -> Get.String_by_Lexical_Form_ID term.local_name_id current_transaction
                                | RDF_Term.FromSimpleLiteral (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id current_transaction
                                | RDF_Term.FromDatatypedLiteral (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id current_transaction
                                | RDF_Term.FromRegionString (term_id, term) -> Get.String_by_Lexical_Form_ID term.lexical_form_id current_transaction
                            column, cell)
                        |> Array.filter (fun (column, cell) -> column <> "type")
                        |> Array.sortBy (fun (column, cell) -> column))
                (layer_name, column_cells_in_layer)

            )

    }


let tabular_content_by_layer quads_by_layer =
    column_cells_by_layer_feature quads_by_layer
    |> Array.map (fun (layer_name, column_cells_in_layer) ->

        let header_row =
            column_cells_in_layer
            |> Array.collect (fun column_cells_for_feature -> column_cells_for_feature |> Array.map fst)
            |> Array.distinct
            |> Array.sort


        let feature_rows =
            column_cells_in_layer
            |> Array.map (fun column_cells_for_feature ->

                let cell_by_column = column_cells_for_feature |> Map.ofArray

                header_row
                |> Array.map (fun column ->
                    cell_by_column
                    |> Map.tryFind column
                    |> Option.defaultValue ""))

        let rows_in_layer = feature_rows |> Array.insertAt 0 header_row
        (layer_name, rows_in_layer))

let csv_content_by_layer quads_by_layer =
    tabular_content_by_layer quads_by_layer
    |> Array.map (fun (layer_name, rows_in_layer) ->
        let csv_content =
            rows_in_layer
            |> Array.map Tabular.Csv.row
            |> String.concat "\n"
        (layer_name, csv_content)

    )

csv_content_by_layer sample_features_by_layer
|> Array.iter (fun (layer_name, csv_content) -> Tabular.Csv.save csv_content $"{layer_name}_Sample")


let html_content_by_layer quads_by_layer =
    tabular_content_by_layer quads_by_layer
    |> Array.map (fun (layer_name, rows_in_layer) ->
        let html_content =
            Tabular.Hypertext.table_from_rows rows_in_layer
            |> Render.toString
        (layer_name, html_content)

    )

let html_document_content =
    tabular_content_by_layer sample_features_by_layer
    |> Tabular.Hypertext.render_document "Sample Data"

let html_document_path = Path.Combine(html_directory_path, "sample_data.html")

File.WriteAllText(html_document_path, html_document_content)


let metadata_workbook = new XLWorkbook()
let sample_data_workbook = new XLWorkbook()
let data_workbook = new XLWorkbook()

tabular_content_by_layer sample_features_by_layer
|> Tabular.Xlsx.save sample_data_workbook "sample_data"

let source_file_stem = "LCPW_OverlayStormwaterInfrastructure_D_WM"

tabular_content_by_layer features_by_layer
|> Tabular.Xlsx.save data_workbook source_file_stem







let metadata_graph = new VDS.RDF.ThreadSafeGraph()
serialize_ttl metadata_graph metadata_quads "metadata"





let sample_data_graph = new VDS.RDF.ThreadSafeGraph()

let sample_data_quads =

    let excluded_predicate_terms =
        set [ swin.owner
              swin.z_coordinate
              swin.maintainer
              swin.material
              swin.surface_type
              swin.pipe_shape

               ]
    let excluded_predicate_substrings =
        [|

           ".x"
           ".y"
           "SUBTYPEFIELD"
           "OWNER"
           "MAINTBY"
           "RELATEDFEATURE"
           "UNITID"
           "STRCT_DEPTH"
           "INVERTELEV"
           "SLOT_ELEV"
           "UPSTREAMELEVATION"
           "DOWNSTREAMELEVATION"
           "HEIGHT"
           "LFEET"
           "DIAMETER"
           "PIPESHAPE"
           "MATERIAL"
           "NUM_BARRELS"
           "DOWNSTREAMDEPTH"
           "UPSTREAMDEPTH"
           "WIDTH"
           "STRUCTURETYPE"
           "SURFACETYPE"
           "PONDTYPE"
           "FILTERLOCATION"

           |]

    let excluded_object_terms =
        set [

              owl.NamedIndividual
              swin.Feature
              esri.GPFeatureLayer

               ]


    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        return

            Array.concat [|

                            sample_quads
                            sample_layer_quads

                             |]
    (*
            |> Array.Parallel.filter (fun quad -> not (excluded_object_terms.Contains(RDF_Object.term quad.object)))
            |> Array.Parallel.filter (fun quad -> not (excluded_predicate_terms.Contains(RDF_Predicate.term quad.predicate)))
            (*
            |> Array.choose (fun quad ->
                if quad.subject.IsFromNamespacedIRI then

                    let (RDF_Term.FromNamespacedIRI (term_id, term)) = RDF_Subject.term quad.subject
                    let local_name =
                        Get.String_by_Lexical_Form_ID term.local_name_id current_transaction
                    if local_name.Contains("_Feature") then
                        None
                    else
                        Some(quad)
                else
                    Some(quad)


            )
                        *)

            |> Array.choose (fun quad ->

                let (RDF_Term.FromNamespacedIRI (term_id, term)) = RDF_Predicate.term quad.predicate
                let local_name =
                    Get.String_by_Lexical_Form_ID term.local_name_id current_transaction
                if local_name
                   |> contains_substring_from excluded_predicate_substrings then
                    None
                else
                    Some(quad)

            )
            |> Array.choose (fun quad ->
                if quad.object.IsFromNamespacedIRI then

                    let (RDF_Term.FromNamespacedIRI (term_id, term)) = RDF_Object.term quad.object
                    let local_name =
                        Get.String_by_Lexical_Form_ID term.local_name_id current_transaction
                    if local_name.EndsWith("_Feature") then
                        None
                    else
                        Some(quad)
                else
                    Some(quad)


            )
            *)

    }

serialize_ttl sample_data_graph sample_data_quads "sample_data"




let map_terms =

    lmdb_read_only {
        let! quads =
            Graph_Pattern._p_g woedms.map oit._graph
            |> Quad_Query.quads_by_pattern

        return
            quads
            |> Array.map (fun quad -> RDF_Object.term quad.object)

    }

let Maps =
    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        return
            [|

               for index = 0 to map_terms.Length - 1 do
                   let MapKey = index + 1
                   $"""
    <Map>
        <Key>{MapKey}</Key>
    </Map>
            """
                       .TrimStart()
                       .TrimEnd()

               |]
            |> String.concat "\n"

    // let (RDF_Term.FromNamespacedIRI (term_id, term_iri)) = RDF_Object.term maps[index].object
    // let map = Namespaced_IRI.nq term_iri current_transaction
    // Console.WriteLine $"{index}: {map}"
    }

let h8import_xml_path = Path.Combine(xlsx_directory_path, $"Mappings.xml")

let h8import_xml_content =
    let Maps = Xml.element "Maps"
    let Map = Xml.element "Map"
    let Key = Xml.element "Key"
    let IsDefault = Xml.element "IsDefault"
    let Name = Xml.element "Name"
    let SourceFilePath = Xml.element "SourceFilePath"
    let SheetName = Xml.element "SheetName"
    let ConnectionString = Xml.element "ConnectionString"
    let ProviderName = Xml.element "ProviderName"
    let UploadOption = Xml.element "UploadOption"
    let IsFirstRowHeader = Xml.element "IsFirstRowHeader"
    let CreatedDate = Xml.element "CreatedDate"
    let CreatedBy = Xml.element "CreatedBy"
    let MapColumn = Xml.element "MapColumn"
    let MapKey = Xml.element "MapKey"
    let SourceColumnName = Xml.element "SourceColumnName"
    let TargetColumnCommonId = Xml.element "TargetColumnCommonId"
    let TargetColumnType = Xml.element "TargetColumnType"
    let MapTableInformation = Xml.element "MapTableInformation"
    let ProductFamilyOwner = Xml.element "ProductFamilyOwner"
    let ProductFamilyName = Xml.element "ProductFamilyName"
    let TableName = Xml.element "TableName"
    let TableCommonId = Xml.element "TableCommonId"
    let TableKey = Xml.element "TableKey"
    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        let xlsx_path =
            Path.Combine(@"D:\www\update\Integration\Interraster\LCPW_OverlayStormwaterInfrastructure_D_WM", $"{source_file_stem}.xlsx")

        return
            Maps {
                Xml._xmlns "http://www.infor.com/Hansen8/2011/08/Maps.xsd"

                for index = 0 to map_terms.Length - 1 do
                    let key = string (index + 1)
                    let map_term = map_terms[index]
                    let map_columns =
                        Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term woedms.map_column oit._graph) current_transaction
                        |> Array.map (fun quad -> RDF_Object.term quad.object)

                    Map {
                        Key { key }
                        IsDefault {

                            Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.IsDefault oit._graph) current_transaction
                            |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                            |> Array.head

                        }
                        Name {

                            Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.Name oit._graph) current_transaction
                            |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                            |> Array.head

                        }
                        SourceFilePath { xlsx_path }
                        SheetName {

                            Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.SheetName oit._graph) current_transaction
                            |> Array.map (fun quad ->
                                (RDF_Object.string_value quad.object current_transaction)
                                    .Replace(" ", "_"))
                            |> Array.head

                        }
                        ConnectionString { $"""Provider=Microsoft.ACE.OLEDB.12.0;Data Source={xlsx_path};Extended Properties="Excel 12.0;HDR=Yes;IMEX=1";""" }
                        ProviderName {
                            Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.ProviderName oit._graph) current_transaction
                            |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                            |> Array.head
                        }
                        UploadOption {
                            Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.UploadOption oit._graph) current_transaction
                            |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                            |> Array.head
                        }
                        IsFirstRowHeader {
                            Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.IsFirstRowHeader oit._graph) current_transaction
                            |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                            |> Array.head
                        }
                        CreatedDate {
                            Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.CreatedDate oit._graph) current_transaction
                            |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                            |> Array.head
                        }
                        CreatedBy {
                            Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.CreatedBy oit._graph) current_transaction
                            |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                            |> Array.head
                        }
                        for map_column in map_columns do
                            let target_column =
                                Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_column woedms.to_column oit._graph) current_transaction
                                |> Array.map (fun quad -> RDF_Object.term quad.object)
                                |> Array.head

                            MapColumn {
                                MapKey { key }
                                SourceColumnName {
                                    Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_column h8importtool.SourceColumnName oit._graph) current_transaction
                                    |> Array.map (fun quad ->
                                        (RDF_Object.string_value quad.object current_transaction)
                                            .Replace(" ", "_"))
                                    |> Array.head
                                }
                                TargetColumnCommonId {

                                    Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_column h8importtool.TargetColumnCommonId oit._graph) current_transaction
                                    |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                                    |> Array.head
                                }
                                TargetColumnType {
                                    Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_column h8importtool.TargetColumnType oit._graph) current_transaction
                                    |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                                    |> Array.head
                                }
                            }
                        MapTableInformation {
                            MapKey { key }
                            ProductFamilyOwner {
                                Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.ProductFamilyOwner oit._graph) current_transaction
                                |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                                |> Array.head
                            }
                            ProductFamilyName {
                                Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.ProductFamilyName oit._graph) current_transaction
                                |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                                |> Array.head
                            }
                            TableName {
                                Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.TableName oit._graph) current_transaction
                                |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                                |> Array.head
                            }
                            TableCommonId {
                                Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.TableCommonId oit._graph) current_transaction
                                |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                                |> Array.head
                            }
                            TableKey {
                                Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.TableKey oit._graph) current_transaction
                                |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                                |> Array.head
                            }

                        }

                    }
            }

    }

let h8import_xml_document =
    h8import_xml_content
    |> Render.toXDocument "1.0" "utf-8" (Some "yes")

h8import_xml_document.Save(h8import_xml_path)

let mapnames =
    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction

        return
            map_terms
            |> Array.map (fun map_term ->

                Quad_Query.quads_by_pattern (Graph_Pattern.sp_g map_term h8importtool.Name oit._graph) current_transaction
                |> Array.map (fun quad -> RDF_Object.string_value quad.object current_transaction)
                |> Array.head)
            |> String.concat ","


    }

let h8import_ps1_path = Path.Combine(xlsx_directory_path, $"h8import.ps1")
let test_webservices_url = "https://infortest.leoncountyfl.gov/update_webservices"

let h8import_ps1_content =
    $"""
$cred = Get-Credential

$username = $cred.UserName

$passwordPlain = [Runtime.InteropServices.Marshal]::PtrToStringAuto(
    [Runtime.InteropServices.Marshal]::SecureStringToBSTR($cred.Password)
)

& "D:\Infor\Downloads\IPS_Web_Services_2025_04_01\ApplicationFiles\ImportTool\Hansen8ImportToolConsole.exe" --mapnames={mapnames} --url={test_webservices_url} --provider=Hansen8 --username=$username --password=$passwordPlain
    """
        .TrimStart()
        .TrimEnd()

File.WriteAllText(h8import_ps1_path, h8import_ps1_content)

// File.WriteAllText(h8import_xml_path, h8import_xml_document)


let h8import = new VDS.RDF.ThreadSafeGraph()

// fsi.ShowDeclarationValues <- true
// fsi.ShowDeclarationValues <- false



(*
let concept_quads =
    lmdb_read_only {
        let current_transaction = lmdb_read_only.Current_Transaction
        let gis_verticies =
            gis_entries
            |> Array.collect (fun gis_id ->
                [|

                   AZ.Iri.lexical_concept[gis_id]
                   AZ.Iri.gis_concept[gis_id]
                   AZ.Iri.gis_sense[gis_id]
                   AZ.Iri.lexical_form[gis_id]

                   |])
        let infor_verticies =
            infor_entries
            |> Array.collect (fun infor_id ->
                [|

                   H8Help_gloss.Iri.lexical_concept[infor_id]
                   H8Help_gloss.Iri.infor_concept[infor_id]
                   H8Help_gloss.Iri.infor_sense[infor_id]
                   H8Help_gloss.Iri.lexical_form[infor_id]

                   |])
        let verticies =
            Array.concat [|

                            gis_verticies
                            infor_verticies

                             |]
        return!
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V verticies
            |> Graph_Traversal.bothE
            |> Graph_Traversal.to_quads

    }
*)







(*
let entry_quads =
    esrinfor_terms
    |> Array.collect (fun esrinfor_entry ->
        lmdb_read_only {

            let! lexical_entry = entry._prefix esrinfor_entry
            let! rdf_type =
                Graph_Pattern.sp_g lexical_entry is_a oit._graph
                |> Quad_Query.quads_by_pattern
            let! denotes =
                Graph_Pattern.sp_g lexical_entry ontolex.denotes oit._graph
                |> Quad_Query.quads_by_pattern
            let! evokes =
                Graph_Pattern.sp_g lexical_entry ontolex.evokes oit._graph
                |> Quad_Query.quads_by_pattern
            let! sense =
                Graph_Pattern.sp_g lexical_entry ontolex.sense oit._graph
                |> Quad_Query.quads_by_pattern
            let! subclass =
                Graph_Pattern.sp_g ontolex.LexicalConcept rdfs.subClassOf oit._graph
                |> Quad_Query.quads_by_pattern
            return
                Array.concat [|

                                rdf_type
                                denotes
                                evokes
                                sense
                                subclass

                                 |]
        }

    )

*)

















let gis_headwords =
    set [

          "feature"
          "feature_class"
          "feature_layer"
          "field"
          "identifier"
          "geodatabase"


           ]

let infor_headwords =
    set [

          "asset"
          "table definition"
          "column"
          "identification code"
          "ID"
          "UnitDesc"
          "AddressQualifier"
          "XCoordinate"
          "YCoordinate"
          "ZCoordinate"
          "table"
          "Data layer"
          "Business layer"
          "Presentation layer"

           ]



let esrinfor_headwords = Set.union gis_headwords infor_headwords

let excluded_predicate_terms =
    set [

          decomp.constituent
          ontolex.isSenseOf
          ontolex.lexicalForm
          termlex.isLexicalizedSenseOf
          termlex.isEvokedBy
          dcterms.subject

           ]

let excluded_senses =
    set [

          "data_storage.feature_class"
          "data_models.field"
          "data_models.column"
          "asset_management.feature"
          "core.field"

           ]

let excluded_object_terms =
    set [

          skos.Concept
          termlex.TerminologicalConcept
          termlex.Usage
          // ontolex.Word
          // ontolex.MultiWordExpression

           ]






let entries =
    lmdb_read_write {
        let! current_transaction = lmdb_read_write.Current_Transaction
        return

            esrinfor_headwords
            |> Set.toArray
            |> Array.map (fun term -> entry._minuscule term current_transaction)

    }

let lexical_quads =

    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        let! entry_quads =
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V entries
            |> Graph_Traversal.outE_all
            |> Graph_Traversal.to_quads
        let constituients =

            entry_quads
            |> Array.choose (fun quad ->
                if RDF_Predicate.term quad.predicate = decomp.constituent then
                    Some(RDF_Object.term quad.object)
                else
                    None)

        let! constituients_quads_raw =
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V constituients
            |> Graph_Traversal.outE_all
            |> Graph_Traversal.to_quads
        let constituent_quads_filtered =
            constituients_quads_raw
            |> Array.choose (fun quad ->
                let local_name = RDF_Subject.string_value quad.subject current_transaction
                let term_exists =
                    esrinfor_headwords
                    |> Set.exists (fun term -> local_name.EndsWith(term))
                if RDF_Predicate.term quad.predicate = decomp.correspondsTo
                   && term_exists then
                    Some(quad)
                else
                    None)

        let sense_objects =
            entry_quads
            |> Array.choose (fun quad ->
                if RDF_Predicate.term quad.predicate = ontolex.sense then
                    Some(quad.object)
                else
                    None)
        let senses_filtered =
            sense_objects
            |> Array.choose (fun sense_object ->
                let local_name = RDF_Object.string_value sense_object current_transaction
                if excluded_senses.Contains(local_name) then
                    None
                else
                    Some(RDF_Object.term sense_object)

            )

        let! sense_quads =
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V senses_filtered
            |> Graph_Traversal.outE_all
            |> Graph_Traversal.to_quads
        let usages =
            sense_quads
            |> Array.choose (fun quad ->
                if RDF_Predicate.term quad.predicate = ontolex.usage then
                    Some(RDF_Object.term quad.object)
                else
                    None)
        let! usage_quads =
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V usages
            |> Graph_Traversal.outE_all
            |> Graph_Traversal.to_quads
        let concepts =
            entry_quads
            |> Array.choose (fun quad ->
                if RDF_Predicate.term quad.predicate = termlex.evokes then
                    Some(RDF_Object.term quad.object)
                else
                    None)
        let! concept_quads =
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V concepts
            |> Graph_Traversal.outE_all
            |> Graph_Traversal.to_quads

        return
            Array.concat [|

                            entry_quads
                            sense_quads
                            usage_quads
                            constituent_quads_filtered
                            concept_quads

                             |]
            |> Array.Parallel.filter (fun quad -> not (excluded_predicate_terms.Contains(RDF_Predicate.term quad.predicate)))
            |> Array.Parallel.filter (fun quad -> not (excluded_object_terms.Contains(RDF_Object.term quad.object)))
            |> Array.Parallel.choose (fun quad ->

                let local_name = RDF_Object.string_value quad.object current_transaction

                let term_exists =
                    excluded_senses
                    |> Set.exists (fun term -> local_name.EndsWith(term))
                if RDF_Predicate.term quad.predicate = ontolex.sense
                   && term_exists then
                    None
                else
                    Some(quad)

            )



    }


(*
let test_quads =

    lmdb_read_only {
        let! current_transaction = lmdb_read_only.Current_Transaction
        let! term_quads =
            Graph_Pattern._pog is_a termlex.TerminologicalConcept oit._graph
            |> Quad_Query.quads_by_pattern
        let! feature_layer_test = entry._minuscule "feature_layer"
        let! feature_layer_quads =
            Graph_Traversal.traversal_with_graph oit._graph
            |> Graph_Traversal.V [| feature_layer_test |]
            |> Graph_Traversal.bothE
            |> Graph_Traversal.to_quads
        return term_quads

    }

*)
let lexical_graph = new VDS.RDF.ThreadSafeGraph()
serialize_ttl lexical_graph lexical_quads "lex"
// serialize_ttl lexical_graph test_quads "lex"


LCG.print_stats ()
// printfn "%s elapsed=%O" "transaction stopwatch:" stopwatch.Elapsed
