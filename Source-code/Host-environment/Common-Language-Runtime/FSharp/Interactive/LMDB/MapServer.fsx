open System
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

#r "nuget: Fabulous.AST.Json, 2.0.0-pre06"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\UnicodeStandard\PropertyAliases.fsx"
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
open PropertyAliases
open Swensen.Unquote.Assertions

#r "nuget: Blake3"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"

open RDFErgonomics

open LMDB

#r "nuget: FSharp.Data"
#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Extensions\JavascriptObjectNotationExtensions.fsx"

open FSharp.Data
open JavascriptObjectNotationExtensions

open FSharp.Data.JsonExtensions

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\XmlErgonomics.fsx"

open XmlErgonomics

#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\Ergonomics\PowershellErgonomics.fsx"

open PowershellErgonomics

module LCPW_OverlayStormwaterInfrastructure_D_WM =

    [<Literal>]
    let file_path =
        @"D:\Artifact\Company\Esri\LCPW_OverlayStormwaterInfrastructure_D_WM\LCPW_OverlayStormwaterInfrastructure_D_WM.json"

    let json = JsonProvider<file_path>.Load file_path

module LCG_Stormwater_Inventory =

    [<Literal>]
    let file_path =
        @"D:/Surface/Company/Environmental_Systems_Research_Institute/SDE_Schema_XRay/LCG_Stormwater_Inventory_updated/LCG_Stormwater_Inventory_Formatted.xml"

    let xml = XPathNavigator.Load(file_path)

let xpath (expression: string) (xpath_navigator: XPathNavigator) =
    let xpath_expression = XPathExpression.Compile(expression)

    xpath_navigator
        .Select(
            xpath_expression
        )
        .toElementArray



module gpservices =
    [<Literal>]
    let file_path =
        @"D:\Surface\Company\Environmental_Systems_Research_Institute\ArcGIS\Pro\Resources\ArcToolBox\Services\gpservices\json-schema.json"

    module schema =
        let json = JsonProvider<file_path>.Load file_path



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




let SW_Prefixes =
    Map.ofArray [|

                   "Conduit", "PI"
                   "Culvert Cross Drain", "CD"
                   "Debris Trap", "DT"
                   "Ditch", "DI"
                   "End Point", "EP"
                   "Inlet", "IN"
                   "Junction Fixed", "JN"
                   "Outfall", "OF"
                   "Stormwater Pond Discharge", "SD"

                    |]


(*

let feature_layer_names =
    LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
    |> Array.Parallel.map (fun layer -> layer.Name)
    |> Array.distinct

*)
let GPFeatureLayer_names =
    [|

       "Bridge Point"
       "Bridge"
       "Conduit"
       "Connectivity"
       "Culvert Cross Drain"
       "Damage"
       "Debris Trap"
       "Ditch Point"
       "Ditch"
       "Drainage Network"
       "End Point"
       "Generic Storm Asset"
       "Inlet"
       "Interference"
       "Junction Fixed"
       "Media Points Without Photos"
       "Media Points"
       "Non-Drainage Network"
       "Outfall Drainage Area MOF"
       "Outfall Drainage Area MS4"
       "Outfall Drainage Area"
       "Outfall"
       "Pollution Control Box"
       "Private Point"
       "Stormwater Pond - Top of Bank"
       "Stormwater Pond Discharge"
       "Stormwater Pond"

       |]


let DEFeatureClass_names =
    [|

       "Bridge"
       "BridgePoin_names"
       "Conduit"
       "Connectivity"
       "CulvertCrossDrain"
       "Damage"
       "DebrisTrap"
       "Ditch"
       "DitchPoint"
       "EndPoint"
       "GenericStormAsset"
       "Inlet"
       "Interference"
       "Junction_fixed"
       "MediaPoints"
       "MediaPointsWithoutPhotos"
       "Outfall"
       "Outfall_DrainageArea"
       "Outfall_DrainageArea_MOF"
       "Outfall_DrainageArea_MS4"
       "PollutionControlBox"
       "PrivatePoint"
       "StormwaterPond"
       "StormwaterPondDischarge"
       "StormwaterPondTopOfBank"

       |]



module esri =
    let _prefix = prefix_label "esri"

    let _prefixes = prefix_labels "esri"

    let Workspace = _prefix "Workspace"

    /// Feature Class
    /// A collection of spatial data with the same shape type: point, multipoint, polyline, and polygon.
    let DEFeatureClass = _prefix "DEFeatureClass"

    /// Feature Dataset
    /// A collection of feature classes that share a common geographic area and the same spatial reference system.
    let DEFeatureDataset = _prefix "DEFeatureDataset"

module swin =
    let _prefix = prefix_label "swin"
    let _prefixes = prefix_labels "swin"

    let _context =
        let term = _prefix ""
        Quad_Context.NamedGraph term.rdf_term_id.to_encoding

module intraraster =
    let _prefix = prefix_label "intraraster"
    let _prefixes = prefix_labels "intraraster"
    let _context = _prefix ""
    let _Feature name = _prefix ($"{name}_Feature")

    let Bridge_Point_Feature = _Feature "Bridge Point"
    let Bridge_Feature = _Feature "Bridge"
    let Conduit_Feature = _Feature "Conduit"
    let Connectivity_Feature = _Feature "Connectivity"
    let Culvert_Cross_Drain_Feature = _Feature "Culvert Cross Drain"
    let Damage_Feature = _Feature "Damage"
    let Debris_Trap_Feature = _Feature "Debris Trap"
    let Ditch_Point_Feature = _Feature "Ditch Point"
    let Ditch_Feature = _Feature "Ditch"
    let Drainage_Network_Feature = _Feature "Drainage Network"
    let End_Point_Feature = _Feature "End Point"
    let Generic_Storm_Asset_Feature = _Feature "Generic Storm Asset"
    let Inlet_Feature = _Feature "Inlet"
    let Interference_Feature = _Feature "Interference"
    let Junction_Fixed_Feature = _Feature "Junction Fixed"
    let Media_Points_Without_Photos_Feature = _Feature "Media Points Without Photos"
    let Media_Points_Feature = _Feature "Media Points"
    let Non_Drainage_Network_Feature = _Feature "Non-Drainage Network"
    let Outfall_Drainage_Area_MOF_Feature = _Feature "Outfall Drainage Area MOF"
    let Outfall_Drainage_Area_MS4_Feature = _Feature "Outfall Drainage Area MS4"
    let Outfall_Drainage_Area_Feature = _Feature "Outfall Drainage Area"
    let Outfall_Feature = _Feature "Outfall"
    let Pollution_Control_Box_Feature = _Feature "Pollution Control Box"
    let Private_Point_Feature = _Feature "Private Point"
    let Stormwater_Pond___Top_of_Bank_Feature = _Feature "Stormwater Pond - Top of Bank"
    let Stormwater_Pond_Discharge_Feature = _Feature "Stormwater Pond Discharge"
    let Stormwater_Pond_Feature = _Feature "Stormwater Pond"
    let Feature = _prefix "Feature"
    let attached_to = _prefix "attached_to"
    let unit_id = _prefix "unit_id"
    let Facility = _prefix "Facility"
    let facility = _prefix "facility"
    let Outfall_Area = _prefix "Outfall_Area"
    let outfall_area = _prefix "outfall_area"
    let Structure = _prefix "Structure"
    let upstream_structure = _prefix "upstream_structure"
    let Pond = _prefix "Pond"
    let parent = _prefix "parent"


Assert.spoc intraraster.Feature a owl.Class swin._context




GPFeatureLayer_names
|> Array.Parallel.collect (fun GPFeatureLayer_name ->
    let feature_owl_class = intraraster._Feature GPFeatureLayer_name
    let name = RDF_Literal.simple GPFeatureLayer_name


    [|

       Triple.spo feature_owl_class a owl.Class
       Triple.spo feature_owl_class rdfs.label name
       Triple.spo feature_owl_class rdfs.subClassOf intraraster.Feature

       |]

)
|> Assert.Triples_In_Context swin._context


LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun layer ->
    layer.Features
    |> Array.Parallel.filter (fun feature_json -> feature_json.Attributes.Unitid.IsSome)
    |> Array.Parallel.collect (fun feature_json ->

        let feature = intraraster._prefix feature_json.Attributes.Unitid.Value
        let unit_id = RDF_Literal.simple feature_json.Attributes.Unitid.Value
        let feature_owl_class = intraraster._Feature layer.Name

        [|

           Triple.spo feature a feature_owl_class
           Triple.spo feature intraraster.unit_id unit_id
           Triple.spo feature a owl.NamedIndividual

           |]

    )

)
|> Assert.Triples_In_Context swin._context




LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun layer ->
    layer.Features
    |> Array.Parallel.filter (fun feature_json -> feature_json.Attributes.Unitid.IsSome)
    |> Array.Parallel.filter (fun feature ->
        feature.Attributes.Attachedtoid.IsSome
        && not (String.IsNullOrWhiteSpace(feature.Attributes.Attachedtoid.Value)))
    |> Array.Parallel.map (fun feature_json ->

        let feature = intraraster._prefix feature_json.Attributes.Unitid.Value
        let Attachedto = intraraster._prefix feature_json.Attributes.Attachedtoid.Value
        Triple.spo feature intraraster.attached_to Attachedto

    )


)
|> Array.distinct
|> Assert.Triples_In_Context swin._context



LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun layer ->
    layer.Features
    |> Array.Parallel.filter (fun feature_json -> feature_json.Attributes.Unitid.IsSome)
    |> Array.Parallel.filter (fun feature ->
        feature.Attributes.Facilityid.IsSome
        && not (String.IsNullOrWhiteSpace(feature.Attributes.Facilityid.Value))
        && feature.Attributes.Facilityid.Value <> "N/A"
        && feature.Attributes.Facilityid.Value <> "<Null>"

    )
    |> Array.Parallel.collect (fun feature_json ->

        let feature = intraraster._prefix feature_json.Attributes.Unitid.Value
        let Facility = intraraster._prefix feature_json.Attributes.Facilityid.Value
        let facility_id = RDF_Literal.simple feature_json.Attributes.Facilityid.Value

        [|

           Triple.spo Facility a intraraster.Facility
           Triple.spo Facility rdfs.``member`` feature
           Triple.spo feature intraraster.facility Facility
           Triple.spo Facility rdfs.label facility_id

           |]

    )


)
|> Array.distinct
|> Assert.Triples_In_Context swin._context


LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun layer ->
    layer.Features
    |> Array.Parallel.filter (fun feature_json -> feature_json.Attributes.Unitid.IsSome)
    |> Array.Parallel.filter (fun feature ->
        feature.Attributes.Outfallid.IsSome
        && not (String.IsNullOrWhiteSpace(feature.Attributes.Outfallid.Value))
        && feature.Attributes.Outfallid.Value <> "N/A"
        && feature.Attributes.Outfallid.Value <> "<Null>"

    )
    |> Array.Parallel.collect (fun feature_json ->

        let feature = intraraster._prefix feature_json.Attributes.Unitid.Value
        let Outfall = intraraster._prefix feature_json.Attributes.Outfallid.Value
        let outfall_id = RDF_Literal.simple feature_json.Attributes.Outfallid.Value

        [|

           Triple.spo Outfall a intraraster.Outfall_Area
           Triple.spo feature intraraster.outfall_area Outfall
           Triple.spo Outfall rdfs.``member`` feature
           Triple.spo Outfall rdfs.label outfall_id

           |]

    )


)
|> Array.distinct
|> Assert.Triples_In_Context swin._context





LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun layer ->
    layer.Features
    |> Array.Parallel.filter (fun feature_json -> feature_json.Attributes.Unitid.IsSome)
    |> Array.Parallel.filter (fun feature ->
        feature.Attributes.Parentid.IsSome
        && not (String.IsNullOrWhiteSpace(feature.Attributes.Parentid.Value))
        && feature.Attributes.Parentid.Value <> "N/A"
        && feature.Attributes.Parentid.Value <> "<Null>")
    |> Array.Parallel.collect (fun feature_json ->

        let feature = intraraster._prefix feature_json.Attributes.Unitid.Value
        let Parent = intraraster._prefix feature_json.Attributes.Parentid.Value

        [|

           Triple.spo Parent rdfs.``member`` feature
           Triple.spo feature intraraster.parent Parent

           |]

    )


)
|> Array.distinct
|> Assert.Triples_In_Context swin._context



LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun layer ->
    layer.Features
    |> Array.Parallel.filter (fun feature_json -> feature_json.Attributes.Unitid.IsSome)
    |> Array.Parallel.filter (fun feature ->
        feature.Attributes.Upstreamstuctureid.IsSome
        && not (String.IsNullOrWhiteSpace(feature.Attributes.Upstreamstuctureid.Value)))
    |> Array.Parallel.collect (fun feature_json ->

        let feature = intraraster._prefix feature_json.Attributes.Unitid.Value

        let Upstreamstructure =
            intraraster._prefix feature_json.Attributes.Upstreamstuctureid.Value

        let upstream_structure_id =
            RDF_Literal.simple feature_json.Attributes.Upstreamstuctureid.Value

        [|

           Triple.spo feature intraraster.upstream_structure Upstreamstructure
           Triple.spo Upstreamstructure a intraraster.Structure
           Triple.spo Upstreamstructure rdfs.label upstream_structure_id

           |]

    )


)
|> Array.distinct
|> Assert.Triples_In_Context swin._context




LCPW_OverlayStormwaterInfrastructure_D_WM.json.Layers
|> Array.Parallel.collect (fun layer ->
    layer.Features
    |> Array.Parallel.filter (fun feature_json -> feature_json.Attributes.Unitid.IsSome)
    |> Array.Parallel.filter (fun feature ->
        (feature.Attributes.Structureid.Number.IsSome
         || feature.Attributes.Structureid.String.IsSome)
        && not (String.IsNullOrWhiteSpace(feature.Attributes.Structureid.String.Value))
        && feature.Attributes.Structureid.String.Value
           <> "None"
        && feature.Attributes.Structureid.String.Value
           <> "N/A"
        && feature.Attributes.Structureid.String.Value
           <> "<Null>"

    )
    |> Array.Parallel.collect (fun feature_json ->
        let feature = intraraster._prefix feature_json.Attributes.Unitid.Value

        try

            let Structure =
                intraraster._prefix (string feature_json.Attributes.Structureid.Number.Value)

            let Structure_id =
                RDF_Literal.simple (string feature_json.Attributes.Structureid.Number.Value)

            [|

               Triple.spo Structure rdfs.``member`` feature
               Triple.spo Structure a intraraster.Structure
               Triple.spo Structure rdfs.label Structure_id

               |]

        with
        | _ ->

            let Structure = intraraster._prefix feature_json.Attributes.Structureid.String.Value

            let Structure_id =
                RDF_Literal.simple feature_json.Attributes.Structureid.String.Value

            [|

               Triple.spo Structure rdfs.``member`` feature
               Triple.spo Structure a intraraster.Structure
               Triple.spo Structure rdfs.label Structure_id

               |]

    )


)
|> Array.distinct
|> Assert.Triples_In_Context swin._context

// TODO continue triplifying fields

(*
ACCURACYCODE
ACREAGE
ACRES
CAPACITY
DESCRIPTION
DIAMETER
DOWNSTREAM_DEPTH
DOWNSTREAM_ELEV
DOWNSTREAMDEPTH
DOWNSTREAMELEVATION
DRAINAGE_AREA
DRAINAGEAREA
DRAINAGEBASIN
EASTING
FIELD_COMMENTS_
FIELDCOMMENTS
FIELDCREW
FILTER
FILTERLOCATION
FILTERTYPE
HEIGHT
IMAGERYYEAR
INFILTRATION
INSPDATE
INVENTORIED_BY
INVENTORYDATE
INVENTORYTYPE
INVERT_ELEV
INVERT_ELEV29
INVERTELEV
ISINFALL
LFEET
LOC_DESC
LOCATION
MAINTBY
MATERIAL
MILES
NORTHING
NOTES
NUM_BARRELS
OBSTRUCTION
ORIGINALSOURCE
OUTFALLTYPE
OWNER
PIPESHAPE
PONDTYPE
PONDYR
RELATEDFEATURE
ROTATION_AZ
SHAPE
SHAPE_Area
SHAPE_Length
SLOT_ELEV
SOURCE
SOURCEYEAR
STRCT_DEPTH
STRUCTURETYPE
SUBTYPEFIELD
SURFACETYPE
UNDERDRAINS
UNITDESC
UPDATESOURCE
UPSTREAM_DEPTH
UPSTREAM_ELEV
UPSTREAMDEPTH
UPSTREAMELEVATION
UPSTREAMSTUCTUREID
VIEW_
WATERBODYNAME
WBID
WIDTH
Z29
ZVALUE

*)














































let super'member'sub_triples = Query._p_ rdfs.``member``

super'member'sub_triples
|> Array.Parallel.collect (fun super'member'sub ->
    Query.sp_ (RDF_Term.from_id (Triple.slot_value Triple_Slot.S super'member'sub)) a)

let feature'a'ditch_feature =
    Query._po a intraraster.Ditch_Feature
    |> Array.randomChoice

let ditch = RDF_Term.from_id (Triple.slot_value S feature'a'ditch_feature)
let container'member'ditch = Query.incoming_edges ditch

container'member'ditch
|> Array.map (fun triple -> Query.outgoing_edges (RDF_Term.from_id (Triple.slot_value Triple_Slot.S triple))

)


let mof = Query.in_all ditch |> Array.randomChoice
Query.outgoing_edges mof
