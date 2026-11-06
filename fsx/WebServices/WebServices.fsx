#time on
fsi.PrintLength <- 1
fsi.ShowDeclarationValues <- false
#r @"D:\https\com\github\eristocrates\ipa\fsx\packages\Microsoft.Data.SqlClient\runtimes\win\lib\net9.0\Microsoft.Data.SqlClient.dll"
//#r "nuget: Newtonsoft.Json, 13.0.0.1"
#I @"D:\https\com\github\eristocrates\FSharp.Data.WsdlProvider\src\FSharp.Data.WsdlProvider.Runtime\bin\Release\net8.0"

#I @"D:\https\com\github\eristocrates\FSharp.Data.WsdlProvider\src\FSharp.Data.WsdlProvider.DesignTime\bin\Release\net8.0"

#r "FSharp.Data.WsdlProvider.Runtime.dll"
#r "FSharp.Data.WsdlProvider.DesignTime.dll"

open FSharp.Data
// #I @"D:\https\com\github\eristocrates\ipa\dll"
// #I @"D:\https\com\github\eristocrates\ipa\fsx"
// #I @"D:\https\com\github\eristocrates\ipa\fsx\.paket"

#load @"C:\Secret\InforSecrets.fsx"
#load @"D:\https\com\github\eristocrates\ipa\fsx\Clipboard.fsx"
open Clipboard
//#load @".paket/load/main.group.fsx"
// #I @"D:\https\com\github\eristocrates\ipa\fs\DoxAletheia\src\DoxAletheia.Runtime\bin\Release\net10.0"
// #r "DoxAletheia.Runtime.dll"
// open DoxAletheia
// open DoxAletheia.Runtime
// open BasicGraphActivePattern
// open type Functional
// open type RdfTerm

#I @"D:\https\com\github\eristocrates\InforSqlHydra\bin\Release\net10.0"
#r "InforSqlHydra.dll"
open Dapper.FSharp.MSSQL

Dapper.FSharp.MSSQL.OptionTypes.register ()
open InforTestSql.TestOperations


open System
open System.Runtime.Loader
open System.Collections
open System.Collections.Concurrent
open System.Collections.Generic
open System.ComponentModel.DataAnnotations
open System.Data
open System.Diagnostics
open System.Globalization
open System.IO
open System.Linq
open System.Net
open System.Net.Http
open System.Net.Http.Headers
open System.Numerics
open System.Reflection
open System.Runtime.InteropServices
open System.Security.Cryptography
open System.ServiceModel
open System.Text
open System.Text.Json
open System.Text.Json.Schema
open System.Text.Json.Serialization
open System.Text.RegularExpressions
open System.Threading
open System.Threading.Tasks
open System.Web.Services.Description
open System.Xml
open System.Xml.Linq
open System.Xml.Schema
open System.Xml.XPath

#r "nuget: Esri.ArcGISRuntime, 300.0.0"

// open Ada.Url
// open AngleSharp.Attributes
// open AngleSharp.Dom
// open AngleSharp.Html.Parser
// open BrowserApi.Css.Authoring
// open canopy
// open Dubzer.WhatwgUrl
// open DynamicObj
open Esri.ArcGISRuntime
// open Fabulous.AST.Json
// open Fli
// open Flurl
// open FolkerKinzel.MimeTypes
// open Fs.Units
open FSharp.Collections.ParallelSeq
// open FSharp.Data
// open FSharp.Data.JsonExtensions
// open FSharp.Data.JsonPath
// open FSharp.Data.JsonSchema
// open FSharp.Data.JsonSchema.Core
// open FSharp.Data.JsonSchema.OpenApi
// open FSharp.Data.Sql
// open FSharp.Data.Sql.MsSql
// open FSharp.Interop.Excel
// open FSharp.Json
// open FSharpPlus
// open FsHttp
// open FsPublicSuffix
// open HCollections
// open Iana
// open IriTools
// open Json.More
// open Json.Path
// open Json.Pointer
// open JsonStructure
// open Meziantou.Framework
// open Microsoft.FSharp.Linq.RuntimeHelpers
// open Microsoft.FSharp.Quotations
// open Microsoft.FSharp.Quotations.Patterns
// open Microsoft.FSharp.Reflection
// open Microsoft.VisualBasic.FileIO
// open MimeDetective
// open Nager.PublicSuffix
// open Nager.PublicSuffix.Models
// open Nager.PublicSuffix.RuleParsers
// open Nager.PublicSuffix.RuleProviders
// open Newtonsoft.Json
// open Newtonsoft.Json.Linq
// open NJsonSchema
// open NLanguageTag
// open NuGet
// open NuGet.CatalogReader
// open NuGet.Common
// open NuGet.Protocol
// open NuGet.Protocol.Core.Types
// open NuGet.Protocol.Resources
// open OpenQA.Selenium
// open OpenQA.Selenium.Edge
// open OpenQA.Selenium.Remote
// open ProviderImplementation.ProvidedTypes
// open PuppeteerSharp
// open PuppeteerSharp.Cdp
// open RDFSharp.Model
// open ShapeSifter
// open ShapeSifter.Patterns
// open SmartWsdlKit
// open SqlHydra
// open SqlHydra.Query
// open Tavis.UriTemplates
// open TypeEquality
// open TypeShape
// open TypeShape.Core
// open VDS.Common.Tries
// open VDS.RDF
// open WebSharper.Core

type JsonNode = Nodes.JsonNode
type JsonNodeObject = Nodes.JsonObject
type JsonNodeArray = Nodes.JsonArray
type JsonNodeValue = Nodes.JsonValue
module FSharpLiteral = FSharp.Literals.Literal
module TType = ShapeSifter.Patterns

// type UriSchemes = Iana.RegistryProvider.``Uniform Resource Identifier (URI) Schemes``.``Uniform Resource Identifier (URI) Schemes``
// type PublicSuffixes = PublicSuffixList.PublicSuffixProvider
// type MediaType = Iana.InternetMediaTypeProvider

type Data.ServiceFeatureTable with
    member this.FeatureQuery(offset: int) =
        Array.concat [|
            let query = Data.QueryParameters()
            query.WhereClause <- "1 = 1"
            query.ReturnGeometry <- true
            query.ResultOffset <- offset
            query.MaxFeatures <- int this.LayerInfo.MaxRecordCount
            let queryResults =
                this.QueryFeaturesAsync(query, Data.QueryFeatureFields.LoadAll)
                |> Async.AwaitTask
                |> Async.RunSynchronously
                |> Seq.toArray
            if queryResults.Length = 0 then
                Array.empty
            else
                this.FeatureQuery(offset + queryResults.Length) |> Array.append queryResults
        |]
type Data.FeatureTable with
    member this.fieldMap = this.Fields |> Seq.map (fun field -> field.Name, field) |> Map.ofSeq
type FeatureAttribute =
    /// "A binary large object."
    | BlobField of obj option
    /// "A date time value. Shapefile formats do not store the time component."
    | DateField of DateTime option
    /// "A date only value."
    | DateOnlyField of DateOnly option
    /// "A float value."
    | Float32Field of single option
    /// "A double value."
    | Float64Field of double option
    /// "A geometry value."
    | GeometryField of Geometry.Geometry option
    /// "An esri global ID value."
    | GlobalIDField of Guid
    /// "Globally Unique Identifier value."
    | GuidField of Guid option
    /// "A 16-bit integer value."
    | Int16Field of Int16 option
    /// "A 32-bit integer value."
    | Int32Field of Int32 option
    /// "A 64-bit integer value."
    | Int64Field of Int64 option
    /// "An object ID value."
    | OIDField of Int64
    /// "A raster value."
    | RasterField of Rasters.Raster option
    /// "A string value."
    | TextField of string option
    /// "A time only value."
    | TimeOnlyField of TimeOnly option
    /// "A timestamp with offset." option
    | TimestampOffsetField of DateTimeOffset option
    /// "An xml value."
    | XmlField of XElement option
    | DomainField of Data.CodedValueDomain * FeatureAttribute
    | UnknownField of obj option
type FeatureGeometry =
    | EnvelopeGeometry of Geometry.Envelope
    | MapPointGeometry of Geometry.MapPoint
    | MultipartGeometry of Geometry.Multipart
    | MultipointGeometry of Geometry.Multipoint
let optional<'T> (valueObject: obj) : 'T option =
    valueObject |> Option.ofObj |> Option.map unbox<'T>

type Data.Feature with
    member this.attributes =
        this.Attributes
        |> Seq.map (|KeyValue|)
        |> Seq.map (fun (key, value) ->
            let field = this.FeatureTable.fieldMap[key]
            let attribute =
                match Option.ofObj field.Domain, field.FieldType with
                (*
                | Some (:? Data.CodedValueDomain as domain), _ -> let codedValue = value
                        |> Option.ofObj
                        |> Option.map (fun code -> domain.CodedValues |> Seq.find (fun codedValue -> Object.Equals(codedValue.Code, code)))
                    CodedValueField codedValue
    *)
                | _, Data.FieldType.Blob -> BlobField(Option.ofObj value)
                | _, Data.FieldType.Date -> DateField(optional<DateTime> value)
                | _, Data.FieldType.DateOnly -> DateOnlyField(optional<DateOnly> value)
                | _, Data.FieldType.Float32 -> Float32Field(optional<single> value)
                | _, Data.FieldType.Float64 -> Float64Field(optional<double> value)
                | _, Data.FieldType.Geometry -> GeometryField(optional<Geometry.Geometry> value)
                | _, Data.FieldType.GlobalID -> GlobalIDField(unbox<Guid> value)
                | _, Data.FieldType.Guid -> GuidField(optional<Guid> value)
                | _, Data.FieldType.Int16 -> Int16Field(optional<Int16> value)
                | _, Data.FieldType.Int32 -> Int32Field(optional<Int32> value)
                | _, Data.FieldType.Int64 -> Int64Field(optional<Int64> value)
                | _, Data.FieldType.OID -> OIDField(unbox<Int64> value)
                | _, Data.FieldType.Raster -> RasterField(optional<Rasters.Raster> value)
                | _, Data.FieldType.Text -> TextField(optional<string> value)
                | _, Data.FieldType.TimeOnly -> TimeOnlyField(optional<TimeOnly> value)
                | _, Data.FieldType.TimestampOffset -> TimestampOffsetField(optional<DateTimeOffset> value)
                | _, _ -> UnknownField(Option.ofObj value)
            field, attribute)
    member this.unkownAttributes =
        this.attributes
        |> Seq.filter (fun (field, attribute) -> attribute.IsUnknownField)
    member this.geometry =
        match this.Geometry with
        | :? Geometry.Envelope as envelope -> EnvelopeGeometry envelope
        | :? Geometry.MapPoint as mapPoint -> MapPointGeometry mapPoint
        | :? Geometry.Multipart as multipart -> MultipartGeometry multipart
        | :? Geometry.Multipoint as multipoint -> MultipointGeometry multipoint
    member this.X =
        match this.geometry with
        | MapPointGeometry mapPoint -> optional<double> mapPoint.X
        | _ -> None
    member this.Y =
        match this.geometry with
        | MapPointGeometry mapPoint -> optional<double> mapPoint.Y
        | _ -> None

    member this.ACCEPT_DATE = optional<string> this.Attributes["ACCEPT_DATE"]
    member this.ACCURACYCODE = optional<string> this.Attributes["ACCURACYCODE"]
    member this.ACREAGE = optional<double> this.Attributes["ACREAGE"]
    member this.ACRES = optional<double> this.Attributes["ACRES"]
    member this.ACTIVITY = optional<string> this.Attributes["ACTIVITY"]
    member this.ANCILLARYROLE = optional<Int16> this.Attributes["ANCILLARYROLE"]
    member this.ATTACHEDTOID = optional<string> this.Attributes["ATTACHEDTOID"]
    member this.ATTRIBUTECOMPLETE = optional<Int16> this.Attributes["ATTRIBUTECOMPLETE"]
    member this.CAPACITY = optional<double> this.Attributes["CAPACITY"]
    member this.COMPKEY = optional<Int32> this.Attributes["COMPKEY"]
    member this.CREATIONDATE = optional<DateTime> this.Attributes["CREATIONDATE"]
    member this.CREATOR = optional<string> this.Attributes["CREATOR"]
    member this.CREW = optional<string> this.Attributes["CREW"]
    member this.DAMAGEID = optional<string> this.Attributes["DAMAGEID"]
    member this.DAMAGETYPE = optional<string> this.Attributes["DAMAGETYPE"]
    member this.DATAFILE = optional<string> this.Attributes["DATAFILE"]
    member this.DATE_ = optional<DateTime> this.Attributes["DATE_"]
    member this.DATECREATED = optional<DateTime> this.Attributes["DATECREATED"]
    member this.DATEMODIFIED = optional<DateTime> this.Attributes["DATEMODIFIED"]
    member this.DESCRIPTION = optional<string> this.Attributes["DESCRIPTION"]
    member this.DIAMETER = optional<Int16> this.Attributes["DIAMETER"]
    member this.DIGITALPICTUREID = optional<string> this.Attributes["DIGITALPICTUREID"]
    member this.DIGITALPICTUREID_E = optional<string> this.Attributes["DIGITALPICTUREID_E"]
    member this.DIGITALPICTUREID_S = optional<string> this.Attributes["DIGITALPICTUREID_S"]
    member this.DIGITALPICTUREID_W = optional<string> this.Attributes["DIGITALPICTUREID_W"]
    member this.DOWNSTREAM_DEPTH = optional<double> this.Attributes["DOWNSTREAM_DEPTH"]
    member this.DOWNSTREAM_ELEV = optional<double> this.Attributes["DOWNSTREAM_ELEV"]
    member this.DOWNSTREAMDEPTH = optional<double> this.Attributes["DOWNSTREAMDEPTH"]
    member this.DOWNSTREAMELEVATION = optional<double> this.Attributes["DOWNSTREAMELEVATION"]
    member this.DRAINAGE_AREA = optional<double> this.Attributes["DRAINAGE_AREA"]
    member this.DRAINAGEAREA = optional<double> this.Attributes["DRAINAGEAREA"]
    member this.DRAINAGEBASIN = optional<string> this.Attributes["DRAINAGEBASIN"]
    member this.DRAWINGID = optional<string> this.Attributes["DRAWINGID"]
    member this.EASTING = optional<double> this.Attributes["EASTING"]
    member this.EDITDATE = optional<DateTime> this.Attributes["EDITDATE"]
    member this.EDITOR = optional<string> this.Attributes["EDITOR"]
    member this.ELEMENTX = optional<double> this.Attributes["ELEMENTX"]
    member this.ELEMENTY = optional<double> this.Attributes["ELEMENTY"]
    member this.ENABLED = optional<Int16> this.Attributes["ENABLED"]
    member this.FACILITYID = optional<string> this.Attributes["FACILITYID"]
    member this.FIELD_COMMENTS_ = optional<string> this.Attributes["FIELD_COMMENTS_"]
    member this.FIELDCOMMENTS = optional<string> this.Attributes["FIELDCOMMENTS"]
    member this.FIELDCOMPLETE = optional<Int16> this.Attributes["FIELDCOMPLETE"]
    member this.FIELDCREW = optional<string> this.Attributes["FIELDCREW"]
    member this.FILE_NAME = optional<string> this.Attributes["FILE_NAME"]
    member this.FILE_NAME_1 = optional<string> this.Attributes["FILE_NAME_1"]
    member this.FILTER = optional<Int16> this.Attributes["FILTER"]
    member this.FILTERLOCATION = optional<string> this.Attributes["FILTERLOCATION"]
    member this.FILTERTYPE = optional<string> this.Attributes["FILTERTYPE"]
    member this.FINAL_NAME = optional<string> this.Attributes["FINAL_NAME"]
    member this.FOLDER = optional<string> this.Attributes["FOLDER"]
    member this.GLOBALID = optional<string> this.Attributes["GLOBALID"]
    member this.GLOBALID = unbox<Guid> this.Attributes["GLOBALID"]
    member this.HEIGHT = optional<double> this.Attributes["HEIGHT"]
    member this.HOTLINK = optional<string> this.Attributes["HOTLINK"]
    member this.HYD_ID = optional<string> this.Attributes["HYD_ID"]
    member this.HYPERLINK = optional<string> this.Attributes["HYPERLINK"]
    member this.HYPERLINK_AR = optional<string> this.Attributes["HYPERLINK_AR"]
    member this.IMAGERYYEAR = optional<string> this.Attributes["IMAGERYYEAR"]
    member this.INFILTRATION = optional<Int16> this.Attributes["INFILTRATION"]
    member this.INSPDATE = optional<DateTime> this.Attributes["INSPDATE"]
    member this.INVENTORIED_BY = optional<string> this.Attributes["INVENTORIED_BY"]
    member this.INVENTORYDATE = optional<DateTime> this.Attributes["INVENTORYDATE"]
    member this.INVENTORYTYPE = optional<string> this.Attributes["INVENTORYTYPE"]
    member this.INVERT_ELEV = optional<double> this.Attributes["INVERT_ELEV"]
    member this.INVERT_ELEV29 = optional<double> this.Attributes["INVERT_ELEV29"]
    member this.INVERTELEV = optional<double> this.Attributes["INVERTELEV"]
    member this.ISINFALL = optional<Int16> this.Attributes["ISINFALL"]
    member this.ISINFALL = optional<Int32> this.Attributes["ISINFALL"]
    member this.LEGACY_ID = optional<string> this.Attributes["LEGACY_ID"]
    member this.LEGACYID = optional<string> this.Attributes["LEGACYID"]
    member this.LFEET = optional<double> this.Attributes["LFEET"]
    member this.LIFECYCLE = optional<string> this.Attributes["LIFECYCLE"]
    member this.LOC_DESC = optional<string> this.Attributes["LOC_DESC"]
    member this.LOCATION = optional<string> this.Attributes["LOCATION"]
    member this.MAINTBY = optional<string> this.Attributes["MAINTBY"]
    member this.MATERIAL = optional<string> this.Attributes["MATERIAL"]
    member this.MEDIA_CODE = optional<string> this.Attributes["MEDIA_CODE"]
    member this.MILES = optional<double> this.Attributes["MILES"]
    member this.NEEDSATTENTION = optional<Int16> this.Attributes["NEEDSATTENTION"]
    member this.NORTHING = optional<double> this.Attributes["NORTHING"]
    member this.NOTES = optional<string> this.Attributes["NOTES"]
    member this.NUM_BARRELS = optional<Int32> this.Attributes["NUM_BARRELS"]
    member this.OBJECTID = unbox<Int64> this.Attributes["OBJECTID"]
    member this.OBSTRUCTION = optional<string> this.Attributes["OBSTRUCTION"]
    member this.ORIGINALSOURCE = optional<string> this.Attributes["ORIGINALSOURCE"]
    member this.OUTFALLID = optional<string> this.Attributes["OUTFALLID"]
    member this.OUTFALLTYPE = optional<string> this.Attributes["OUTFALLTYPE"]
    member this.OWNER = optional<string> this.Attributes["OWNER"]
    member this.PARCELID = optional<string> this.Attributes["PARCELID"]
    member this.PARENTID = optional<string> this.Attributes["PARENTID"]
    member this.PERCT_GRD = optional<double> this.Attributes["PERCT_GRD"]
    member this.PHOTO_FOLDER = optional<string> this.Attributes["PHOTO_FOLDER"]
    member this.PHOTO_NUM = optional<Int16> this.Attributes["PHOTO_NUM"]
    member this.PHOTOID = optional<string> this.Attributes["PHOTOID"]
    member this.PID_1 = optional<string> this.Attributes["PID_1"]
    member this.PIPESHAPE = optional<string> this.Attributes["PIPESHAPE"]
    member this.PLACE = optional<string> this.Attributes["PLACE"]
    member this.POND_ID = optional<Int16> this.Attributes["POND_ID"]
    member this.PONDID = optional<double> this.Attributes["PONDID"]
    member this.PONDID = optional<string> this.Attributes["PONDID"]
    member this.PONDTYPE = optional<string> this.Attributes["PONDTYPE"]
    member this.PONDYR = optional<string> this.Attributes["PONDYR"]
    member this.PRFRESOLUTION = optional<string> this.Attributes["PRFRESOLUTION"]
    member this.RAW_NAME = optional<string> this.Attributes["RAW_NAME"]
    member this.RELATEDFEATURE = optional<string> this.Attributes["RELATEDFEATURE"]
    member this.ROTATION_AZ = optional<Int16> this.Attributes["ROTATION_AZ"]
    member this.Shape_Area = optional<double> this.Attributes["Shape_Area"]
    member this.SHAPE_Area = optional<double> this.Attributes["SHAPE_Area"]
    member this.Shape_Length = optional<double> this.Attributes["Shape_Length"]
    member this.SHAPE_Length = optional<double> this.Attributes["SHAPE_Length"]
    member this.SLOT_ELEV = optional<double> this.Attributes["SLOT_ELEV"]
    member this.SOURCE = optional<string> this.Attributes["SOURCE"]
    member this.SOURCEYEAR = optional<string> this.Attributes["SOURCEYEAR"]
    member this.STORAGE_FULL_PATH_ADDR = optional<string> this.Attributes["STORAGE_FULL_PATH_ADDR"]
    member this.STORAGE_PATH_ADDR = optional<string> this.Attributes["STORAGE_PATH_ADDR"]
    member this.STORAGE_STATIC_PATH_ADDR = optional<string> this.Attributes["STORAGE_STATIC_PATH_ADDR"]
    member this.STRCT_DEPTH = optional<double> this.Attributes["STRCT_DEPTH"]
    member this.STRUCTURE_ID = optional<string> this.Attributes["STRUCTURE_ID"]
    member this.STRUCTUREID = optional<string> this.Attributes["STRUCTUREID"]
    member this.STRUCTURETYPE = optional<string> this.Attributes["STRUCTURETYPE"]
    member this.SUBTYPEFIELD = optional<Int32> this.Attributes["SUBTYPEFIELD"]
    member this.SURFACETYPE = optional<string> this.Attributes["SURFACETYPE"]
    member this.UNDERDRAINS = optional<double> this.Attributes["UNDERDRAINS"]
    member this.UNITDESC = optional<string> this.Attributes["UNITDESC"]
    member this.UNITID = optional<string> this.Attributes["UNITID"]
    member this.UPDATESOURCE = optional<string> this.Attributes["UPDATESOURCE"]
    member this.UPSTREAM_DEPTH = optional<double> this.Attributes["UPSTREAM_DEPTH"]
    member this.UPSTREAM_ELEV = optional<double> this.Attributes["UPSTREAM_ELEV"]
    member this.UPSTREAMDEPTH = optional<double> this.Attributes["UPSTREAMDEPTH"]
    member this.UPSTREAMELEVATION = optional<double> this.Attributes["UPSTREAMELEVATION"]
    member this.UPSTREAMSTUCTUREID = optional<string> this.Attributes["UPSTREAMSTUCTUREID"]
    member this.VIEW_ = optional<string> this.Attributes["VIEW_"]
    member this.WATERBODYNAME = optional<string> this.Attributes["WATERBODYNAME"]
    member this.WBID = optional<string> this.Attributes["WBID"]
    member this.WHOCREATED = optional<string> this.Attributes["WHOCREATED"]
    member this.WHOMODIFIED = optional<string> this.Attributes["WHOMODIFIED"]
    member this.WIDTH = optional<double> this.Attributes["WIDTH"]
    member this.Z29 = optional<double> this.Attributes["Z29"]
    member this.ZVALUE = optional<double> this.Attributes["ZVALUE"]

type OutfallFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    FACILITYID: string option
    ATTACHEDTOID: string option
    UPSTREAMSTUCTUREID: string option
    OUTFALLTYPE: string option
    WATERBODYNAME: string option
    WBID: string option
    DRAINAGEBASIN: string option
    NOTES: string option
    STRUCTURETYPE: string option
    OUTFALLID: string option
    UNITID: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type StormwaterPondFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    EASTING: double option
    NORTHING: double option
    NOTES: string option
    PONDTYPE: string option
    PARCELID: string option
    ACTIVITY: string option
    FILTER: Int16 option
    FILTERTYPE: string option
    FILTERLOCATION: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    LOCATION: string option
    SUBTYPEFIELD: Int32 option
    ZVALUE: double option
    Z29: double option
    PONDID: double option
    DRAINAGE_AREA: double option
    ACREAGE: double option
    CAPACITY: double option
    IMAGERYYEAR: string option
    UNITDESC: string option
    UNITID: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type EndPointFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    LOCATION: string option
    INVENTORYDATE: DateTime option
    INVENTORYTYPE: string option
    EASTING: double option
    NORTHING: double option
    INFILTRATION: Int16 option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    PRFRESOLUTION: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    MATERIAL: string option
    ISINFALL: Int16 option
    RELATEDFEATURE: string option
    HYPERLINK_AR: string option
    OBSTRUCTION: string option
    CREW: string option
    ENABLED: Int16 option
    NEEDSATTENTION: Int16 option
    SUBTYPEFIELD: Int32 option
    ZVALUE: double option
    FIELDCOMMENTS: string option
    IMAGERYYEAR: string option
    STRUCTUREID: string option
    OUTFALLID: string option
    UNITID: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type InletFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    LOCATION: string option
    INVENTORYDATE: DateTime option
    INVENTORYTYPE: string option
    EASTING: double option
    NORTHING: double option
    INFILTRATION: Int16 option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    PRFRESOLUTION: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    MATERIAL: string option
    RELATEDFEATURE: string option
    HYPERLINK_AR: string option
    OBSTRUCTION: string option
    CREW: string option
    FIELDCOMMENTS: string option
    ZVALUE: double option
    SUBTYPEFIELD: Int32 option
    STRCT_DEPTH: double option
    UNDERDRAINS: double option
    SLOT_ELEV: double option
    INVERTELEV: double option
    ISINFALL: Int32 option
    INVERT_ELEV29: double option
    ENABLED: Int16 option
    NEEDSATTENTION: Int16 option
    PLACE: string option
    PID_1: string option
    IMAGERYYEAR: string option
    STRUCTUREID: string option
    OUTFALLID: string option
    UNITID: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type DebrisTrapFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    ATTACHEDTOID: string option
    NEEDSATTENTION: Int16 option
    LOCATION: string option
    INVENTORYDATE: DateTime option
    INVENTORYTYPE: string option
    EASTING: double option
    NORTHING: double option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    PRFRESOLUTION: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    HYPERLINK_AR: string option
    FIELDCOMMENTS: string option
    ZVALUE: double option
    Z29: double option
    IMAGERYYEAR: string option
    OUTFALLID: string option
    UNITID: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type JunctionFixedFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    NEEDSATTENTION: Int16 option
    LOCATION: string option
    INVENTORYDATE: DateTime option
    INVENTORYTYPE: string option
    EASTING: double option
    NORTHING: double option
    INFILTRATION: Int16 option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    MATERIAL: string option
    RELATEDFEATURE: string option
    HYPERLINK_AR: string option
    CREW: string option
    LEGACY_ID: string option
    SUBTYPEFIELD: Int32 option
    FIELDCOMMENTS: string option
    ZVALUE: double option
    PRFRESOLUTION: string option
    STRCT_DEPTH: double option
    OBSTRUCTION: string option
    INVERT_ELEV: double option
    ISINFALL: Int32 option
    IMAGERYYEAR: string option
    STRUCTUREID: string option
    OUTFALLID: string option
    UNITID: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type ConnectivityFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    NOTES: string option
    SUBTYPEFIELD: Int32 option
    IMAGERYYEAR: string option
    COMPKEY: Int32 option
    SHAPE_Length: double option
    X: double option
    Y: double option
}




type GenericStormAssetFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    SUBTYPEFIELD: Int32 option
    EASTING: double option
    NORTHING: double option
    ZVALUE: double option
    Z29: double option
    NOTES: string option
    INVENTORYDATE: DateTime option
    FIELDCOMMENTS: string option
    PRFRESOLUTION: string option
    IMAGERYYEAR: string option
    STRUCTUREID: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type StormwaterPondDischargeFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    NEEDSATTENTION: Int16 option
    LOCATION: string option
    INVENTORYDATE: DateTime option
    INVENTORYTYPE: string option
    EASTING: double option
    NORTHING: double option
    Z29: double option
    INFILTRATION: Int16 option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    HYPERLINK_AR: string option
    DIGITALPICTUREID_S: string option
    DIGITALPICTUREID_E: string option
    DIGITALPICTUREID_W: string option
    SUBTYPEFIELD: Int32 option
    FIELDCOMMENTS: string option
    ZVALUE: double option
    PRFRESOLUTION: string option
    IMAGERYYEAR: string option
    GLOBALID: string option
    STRUCTUREID: string option
    OUTFALLID: string option
    STRUCTURETYPE: string option
    UNITID: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type PrivatePointFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    SUBTYPEFIELD: Int32 option
    EASTING: double option
    NORTHING: double option
    ZVALUE: double option
    Z29: double option
    NOTES: string option
    IMAGERYYEAR: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type ConduitFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    ACCEPT_DATE: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    INVENTORYDATE: DateTime option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    ACCURACYCODE: string option
    WHOMODIFIED: string option
    MATERIAL: string option
    PIPESHAPE: string option
    DIAMETER: Int16 option
    NEEDSATTENTION: Int16 option
    FIELD_COMMENTS_: string option
    SUBTYPEFIELD: Int32 option
    UPSTREAMDEPTH: double option
    UPSTREAMELEVATION: double option
    DOWNSTREAMDEPTH: double option
    DOWNSTREAMELEVATION: double option
    LFEET: double option
    PERCT_GRD: double option
    WIDTH: double option
    HEIGHT: double option
    IMAGERYYEAR: string option
    OUTFALLID: string option
    UNITID: string option
    COMPKEY: Int32 option
    SHAPE_Length: double option
    X: double option
    Y: double option
}




type CulvertCrossDrainFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    INVENTORYDATE: DateTime option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    ACCURACYCODE: string option
    WHOMODIFIED: string option
    MATERIAL: string option
    PIPESHAPE: string option
    DIAMETER: Int16 option
    NEEDSATTENTION: Int16 option
    FIELD_COMMENTS_: string option
    SUBTYPEFIELD: Int32 option
    WIDTH: double option
    HEIGHT: double option
    ACCEPT_DATE: string option
    UPSTREAM_ELEV: double option
    UPSTREAM_DEPTH: double option
    DOWNSTREAM_ELEV: double option
    DOWNSTREAM_DEPTH: double option
    NUM_BARRELS: Int32 option
    IMAGERYYEAR: string option
    LFEET: double option
    PERCT_GRD: double option
    OUTFALLID: string option
    UNITID: string option
    COMPKEY: Int32 option
    SHAPE_Length: double option
    X: double option
    Y: double option
}




type DitchPointFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    EASTING: double option
    NORTHING: double option
    NOTES: string option
    INVENTORYDATE: DateTime option
    INVENTORYTYPE: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    INFILTRATION: Int16 option
    NEEDSATTENTION: Int16 option
    RELATEDFEATURE: string option
    SUBTYPEFIELD: Int32 option
    ZVALUE: double option
    Z29: double option
    IMAGERYYEAR: string option
    COMPKEY: Int32 option
    X: double option
    Y: double option
}




type DitchFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    INVENTORYDATE: DateTime option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    DATEMODIFIED: DateTime option
    ACCURACYCODE: string option
    WHOMODIFIED: string option
    SURFACETYPE: string option
    RELATEDFEATURE: string option
    SUBTYPEFIELD: Int32 option
    FIELDCOMMENTS: string option
    MILES: double option
    IMAGERYYEAR: string option
    OUTFALLID: string option
    UNITID: string option
    COMPKEY: Int32 option
    SHAPE_Length: double option
    X: double option
    Y: double option
}




type BridgePointFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    EASTING: double option
    NORTHING: double option
    NOTES: string option
    INVENTORYDATE: DateTime option
    INVENTORYTYPE: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    INFILTRATION: Int16 option
    NEEDSATTENTION: Int16 option
    RELATEDFEATURE: string option
    SUBTYPEFIELD: Int32 option
    ZVALUE: double option
    Z29: double option
    IMAGERYYEAR: string option
    X: double option
    Y: double option
}




type BridgeFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    INVENTORYDATE: DateTime option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    ACCURACYCODE: string option
    WHOMODIFIED: string option
    MATERIAL: string option
    PIPESHAPE: string option
    DIAMETER: Int16 option
    NEEDSATTENTION: Int16 option
    FIELD_COMMENTS_: string option
    SUBTYPEFIELD: Int32 option
    WIDTH: double option
    HEIGHT: double option
    ACCEPT_DATE: string option
    UPSTREAM_ELEV: double option
    UPSTREAM_DEPTH: double option
    DOWNSTREAM_ELEV: double option
    DOWNSTREAM_DEPTH: double option
    NUM_BARRELS: Int32 option
    IMAGERYYEAR: string option
    LFEET: double option
    PERCT_GRD: double option
    COMPKEY: Int32 option
    Shape_Length: double option
    X: double option
    Y: double option
}




type StormwaterPondTopofBankFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    ANCILLARYROLE: Int16 option
    ENABLED: Int16 option
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    NOTES: string option
    PONDTYPE: string option
    PARCELID: string option
    ACTIVITY: string option
    FILTER: Int16 option
    FILTERTYPE: string option
    FILTERLOCATION: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    LOCATION: string option
    DIGITALPICTUREID: string option
    HYPERLINK_AR: string option
    POND_ID: Int16 option
    SUBTYPEFIELD: Int32 option
    DRAINAGEAREA: double option
    ACREAGE: double option
    CAPACITY: double option
    IMAGERYYEAR: string option
    PONDYR: string option
    SHAPE_Length: double option
    X: double option
    Y: double option
}




type OutfallDrainageAreaMS4Feature = {
    feature: Data.Feature
    OBJECTID: Int64
    FACILITYID: string option
    ATTACHEDTOID: string option
    NOTES: string option
    ACRES: double option
    GLOBALID: Guid
    Shape_Length: double option
    Shape_Area: double option
    X: double option
    Y: double option
}




type OutfallDrainageAreaFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    FACILITYID: string option
    ATTACHEDTOID: string option
    NOTES: string option
    ACRES: double option
    GLOBALID: Guid
    SHAPE_Length: double option
    SHAPE_Area: double option
    X: double option
    Y: double option
}




type OutfallDrainageAreaMOFFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    FACILITYID: string option
    ATTACHEDTOID: string option
    NOTES: string option
    ACRES: double option
    GLOBALID: Guid
    Shape_Length: double option
    Shape_Area: double option
    X: double option
    Y: double option
}




type MediaPointsFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    HYD_ID: string option
    NOTES: string option
    FOLDER: string option
    RAW_NAME: string option
    FINAL_NAME: string option
    MEDIA_CODE: string option
    VIEW_: string option
    LOC_DESC: string option
    ELEMENTX: double option
    ELEMENTY: double option
    DATE_: DateTime option
    STORAGE_PATH_ADDR: string option
    FILE_NAME: string option
    STORAGE_FULL_PATH_ADDR: string option
    STORAGE_STATIC_PATH_ADDR: string option
    PHOTOID: string option
    FIELDCREW: string option
    CREATIONDATE: DateTime option
    CREATOR: string option
    EDITDATE: DateTime option
    EDITOR: string option
    STRUCTURE_ID: string option
    ROTATION_AZ: Int16 option
    PHOTO_NUM: Int16 option
    HYPERLINK: string option
    HOTLINK: string option
    GLOBALID: Guid
    X: double option
    Y: double option
}




type DamageFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    PONDID: string option
    DESCRIPTION: string option
    PHOTOID: string option
    HOTLINK: string option
    DATAFILE: string option
    INSPDATE: DateTime option
    NORTHING: double option
    EASTING: double option
    INVENTORIED_BY: string option
    PHOTO_FOLDER: string option
    DAMAGEID: string option
    DAMAGETYPE: string option
    X: double option
    Y: double option
}




type MediaPointsWithoutPhotosFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    HYD_ID: string option
    NOTES: string option
    FOLDER: string option
    RAW_NAME: string option
    FINAL_NAME: string option
    MEDIA_CODE: string option
    VIEW_: string option
    LOC_DESC: string option
    ELEMENTX: double option
    ELEMENTY: double option
    DATE_: DateTime option
    STORAGE_PATH_ADDR: string option
    FILE_NAME: string option
    STORAGE_FULL_PATH_ADDR: string option
    STORAGE_STATIC_PATH_ADDR: string option
    PHOTOID: string option
    FIELDCREW: string option
    CREATIONDATE: DateTime option
    CREATOR: string option
    EDITDATE: DateTime option
    EDITOR: string option
    STRUCTURE_ID: string option
    ROTATION_AZ: Int16 option
    PHOTO_NUM: Int16 option
    HYPERLINK: string option
    HOTLINK: string option
    GLOBALID: Guid
    FILE_NAME_1: string option
    X: double option
    Y: double option
}




type InterferenceFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    ATTACHEDTOID: string option
    NEEDSATTENTION: Int16 option
    LOCATION: string option
    INVENTORYDATE: DateTime option
    INVENTORYTYPE: string option
    EASTING: double option
    NORTHING: double option
    ZVALUE: double option
    Z29: double option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    PRFRESOLUTION: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    HYPERLINK_AR: string option
    FIELDCOMMENTS: string option
    SOURCEYEAR: string option
    X: double option
    Y: double option
}




type PollutionControlBoxFeature = {
    feature: Data.Feature
    OBJECTID: Int64
    LIFECYCLE: string option
    PARENTID: string option
    OWNER: string option
    MAINTBY: string option
    SOURCE: string option
    FACILITYID: string option
    LEGACYID: string option
    ATTACHEDTOID: string option
    NEEDSATTENTION: Int16 option
    LOCATION: string option
    INVENTORYDATE: DateTime option
    INVENTORYTYPE: string option
    EASTING: double option
    NORTHING: double option
    DIGITALPICTUREID: string option
    FIELDCOMPLETE: Int16 option
    ATTRIBUTECOMPLETE: Int16 option
    NOTES: string option
    PRFRESOLUTION: string option
    DRAWINGID: string option
    ORIGINALSOURCE: string option
    DATECREATED: DateTime option
    WHOCREATED: string option
    UPDATESOURCE: string option
    DATEMODIFIED: DateTime option
    WHOMODIFIED: string option
    ACCURACYCODE: string option
    HYPERLINK_AR: string option
    FIELDCOMMENTS: string option
    ZVALUE: double option
    Z29: double option
    IMAGERYYEAR: string option
    X: double option
    Y: double option
}



// featureTables |> Seq.map (fun table -> table.TableName) |> String.Clipboard.clip
type StormwaterFeature =
    | StormwaterFeature of Data.Feature
    | BridgeFeature of BridgeFeature
    | BridgePointFeature of BridgePointFeature
    | ConduitFeature of ConduitFeature
    | ConnectivityFeature of ConnectivityFeature
    | CulvertCrossDrainFeature of CulvertCrossDrainFeature
    | DamageFeature of DamageFeature
    | DebrisTrapFeature of DebrisTrapFeature
    | DitchFeature of DitchFeature
    | DitchPointFeature of DitchPointFeature
    | EndPointFeature of EndPointFeature
    | GenericStormAssetFeature of GenericStormAssetFeature
    | InletFeature of InletFeature
    | InterferenceFeature of InterferenceFeature
    | JunctionFixedFeature of JunctionFixedFeature
    | MediaPointsFeature of MediaPointsFeature
    | MediaPointsWithoutPhotosFeature of MediaPointsWithoutPhotosFeature
    | OutfallDrainageAreaFeature of OutfallDrainageAreaFeature
    | OutfallDrainageAreaMOFFeature of OutfallDrainageAreaMOFFeature
    | OutfallDrainageAreaMS4Feature of OutfallDrainageAreaMS4Feature
    | OutfallFeature of OutfallFeature
    | PollutionControlBoxFeature of PollutionControlBoxFeature
    | PrivatePointFeature of PrivatePointFeature
    | StormwaterPondDischargeFeature of StormwaterPondDischargeFeature
    | StormwaterPondFeature of StormwaterPondFeature
    | StormwaterPondTopofBankFeature of StormwaterPondTopofBankFeature


    static member ofFeature(feature: Data.Feature) : StormwaterFeature =
        match feature.FeatureTable.TableName with
        | "Outfall" ->
            StormwaterFeature.OutfallFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                ATTACHEDTOID = optional<string> (feature.Attributes.["ATTACHEDTOID"])
                UPSTREAMSTUCTUREID = optional<string> (feature.Attributes.["UPSTREAMSTUCTUREID"])
                OUTFALLTYPE = optional<string> (feature.Attributes.["OUTFALLTYPE"])
                WATERBODYNAME = optional<string> (feature.Attributes.["WATERBODYNAME"])
                WBID = optional<string> (feature.Attributes.["WBID"])
                DRAINAGEBASIN = optional<string> (feature.Attributes.["DRAINAGEBASIN"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                STRUCTURETYPE = optional<string> (feature.Attributes.["STRUCTURETYPE"])
                OUTFALLID = optional<string> (feature.Attributes.["OUTFALLID"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "Stormwater Pond" ->
            StormwaterFeature.StormwaterPondFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                PONDTYPE = optional<string> (feature.Attributes.["PONDTYPE"])
                PARCELID = optional<string> (feature.Attributes.["PARCELID"])
                ACTIVITY = optional<string> (feature.Attributes.["ACTIVITY"])
                FILTER = optional<Int16> (feature.Attributes.["FILTER"])
                FILTERTYPE = optional<string> (feature.Attributes.["FILTERTYPE"])
                FILTERLOCATION = optional<string> (feature.Attributes.["FILTERLOCATION"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                LOCATION = optional<string> (feature.Attributes.["LOCATION"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                Z29 = optional<double> (feature.Attributes.["Z29"])
                PONDID = optional<double> (feature.Attributes.["PONDID"])
                DRAINAGE_AREA = optional<double> (feature.Attributes.["DRAINAGE_AREA"])
                ACREAGE = optional<double> (feature.Attributes.["ACREAGE"])
                CAPACITY = optional<double> (feature.Attributes.["CAPACITY"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                UNITDESC = optional<string> (feature.Attributes.["UNITDESC"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "End Point" ->
            StormwaterFeature.EndPointFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                LOCATION = optional<string> (feature.Attributes.["LOCATION"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                INVENTORYTYPE = optional<string> (feature.Attributes.["INVENTORYTYPE"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                INFILTRATION = optional<Int16> (feature.Attributes.["INFILTRATION"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                PRFRESOLUTION = optional<string> (feature.Attributes.["PRFRESOLUTION"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                MATERIAL = optional<string> (feature.Attributes.["MATERIAL"])
                ISINFALL = optional<Int16> (feature.Attributes.["ISINFALL"])
                RELATEDFEATURE = optional<string> (feature.Attributes.["RELATEDFEATURE"])
                HYPERLINK_AR = optional<string> (feature.Attributes.["HYPERLINK_AR"])
                OBSTRUCTION = optional<string> (feature.Attributes.["OBSTRUCTION"])
                CREW = optional<string> (feature.Attributes.["CREW"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                FIELDCOMMENTS = optional<string> (feature.Attributes.["FIELDCOMMENTS"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                STRUCTUREID = optional<string> (feature.Attributes.["STRUCTUREID"])
                OUTFALLID = optional<string> (feature.Attributes.["OUTFALLID"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "Inlet" ->
            StormwaterFeature.InletFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                LOCATION = optional<string> (feature.Attributes.["LOCATION"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                INVENTORYTYPE = optional<string> (feature.Attributes.["INVENTORYTYPE"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                INFILTRATION = optional<Int16> (feature.Attributes.["INFILTRATION"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                PRFRESOLUTION = optional<string> (feature.Attributes.["PRFRESOLUTION"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                MATERIAL = optional<string> (feature.Attributes.["MATERIAL"])
                RELATEDFEATURE = optional<string> (feature.Attributes.["RELATEDFEATURE"])
                HYPERLINK_AR = optional<string> (feature.Attributes.["HYPERLINK_AR"])
                OBSTRUCTION = optional<string> (feature.Attributes.["OBSTRUCTION"])
                CREW = optional<string> (feature.Attributes.["CREW"])
                FIELDCOMMENTS = optional<string> (feature.Attributes.["FIELDCOMMENTS"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                STRCT_DEPTH = optional<double> (feature.Attributes.["STRCT_DEPTH"])
                UNDERDRAINS = optional<double> (feature.Attributes.["UNDERDRAINS"])
                SLOT_ELEV = optional<double> (feature.Attributes.["SLOT_ELEV"])
                INVERTELEV = optional<double> (feature.Attributes.["INVERTELEV"])
                ISINFALL = optional<Int32> (feature.Attributes.["ISINFALL"])
                INVERT_ELEV29 = optional<double> (feature.Attributes.["INVERT_ELEV29"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                PLACE = optional<string> (feature.Attributes.["PLACE"])
                PID_1 = optional<string> (feature.Attributes.["PID_1"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                STRUCTUREID = optional<string> (feature.Attributes.["STRUCTUREID"])
                OUTFALLID = optional<string> (feature.Attributes.["OUTFALLID"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "Debris Trap" ->
            StormwaterFeature.DebrisTrapFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                ATTACHEDTOID = optional<string> (feature.Attributes.["ATTACHEDTOID"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                LOCATION = optional<string> (feature.Attributes.["LOCATION"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                INVENTORYTYPE = optional<string> (feature.Attributes.["INVENTORYTYPE"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                PRFRESOLUTION = optional<string> (feature.Attributes.["PRFRESOLUTION"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                HYPERLINK_AR = optional<string> (feature.Attributes.["HYPERLINK_AR"])
                FIELDCOMMENTS = optional<string> (feature.Attributes.["FIELDCOMMENTS"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                Z29 = optional<double> (feature.Attributes.["Z29"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                OUTFALLID = optional<string> (feature.Attributes.["OUTFALLID"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "Junction Fixed" ->
            StormwaterFeature.JunctionFixedFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                LOCATION = optional<string> (feature.Attributes.["LOCATION"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                INVENTORYTYPE = optional<string> (feature.Attributes.["INVENTORYTYPE"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                INFILTRATION = optional<Int16> (feature.Attributes.["INFILTRATION"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                MATERIAL = optional<string> (feature.Attributes.["MATERIAL"])
                RELATEDFEATURE = optional<string> (feature.Attributes.["RELATEDFEATURE"])
                HYPERLINK_AR = optional<string> (feature.Attributes.["HYPERLINK_AR"])
                CREW = optional<string> (feature.Attributes.["CREW"])
                LEGACY_ID = optional<string> (feature.Attributes.["LEGACY_ID"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                FIELDCOMMENTS = optional<string> (feature.Attributes.["FIELDCOMMENTS"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                PRFRESOLUTION = optional<string> (feature.Attributes.["PRFRESOLUTION"])
                STRCT_DEPTH = optional<double> (feature.Attributes.["STRCT_DEPTH"])
                OBSTRUCTION = optional<string> (feature.Attributes.["OBSTRUCTION"])
                INVERT_ELEV = optional<double> (feature.Attributes.["INVERT_ELEV"])
                ISINFALL = optional<Int32> (feature.Attributes.["ISINFALL"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                STRUCTUREID = optional<string> (feature.Attributes.["STRUCTUREID"])
                OUTFALLID = optional<string> (feature.Attributes.["OUTFALLID"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "Connectivity" ->
            StormwaterFeature.ConnectivityFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                SHAPE_Length = optional<double> (feature.Attributes.["SHAPE_Length"])
                X = feature.X
                Y = feature.Y
            }
        | "Generic Storm Asset" ->
            StormwaterFeature.GenericStormAssetFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                Z29 = optional<double> (feature.Attributes.["Z29"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                FIELDCOMMENTS = optional<string> (feature.Attributes.["FIELDCOMMENTS"])
                PRFRESOLUTION = optional<string> (feature.Attributes.["PRFRESOLUTION"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                STRUCTUREID = optional<string> (feature.Attributes.["STRUCTUREID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "Stormwater Pond Discharge" ->
            StormwaterFeature.StormwaterPondDischargeFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                LOCATION = optional<string> (feature.Attributes.["LOCATION"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                INVENTORYTYPE = optional<string> (feature.Attributes.["INVENTORYTYPE"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                Z29 = optional<double> (feature.Attributes.["Z29"])
                INFILTRATION = optional<Int16> (feature.Attributes.["INFILTRATION"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                HYPERLINK_AR = optional<string> (feature.Attributes.["HYPERLINK_AR"])
                DIGITALPICTUREID_S = optional<string> (feature.Attributes.["DIGITALPICTUREID_S"])
                DIGITALPICTUREID_E = optional<string> (feature.Attributes.["DIGITALPICTUREID_E"])
                DIGITALPICTUREID_W = optional<string> (feature.Attributes.["DIGITALPICTUREID_W"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                FIELDCOMMENTS = optional<string> (feature.Attributes.["FIELDCOMMENTS"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                PRFRESOLUTION = optional<string> (feature.Attributes.["PRFRESOLUTION"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                GLOBALID = optional<string> (feature.Attributes.["GLOBALID"])
                STRUCTUREID = optional<string> (feature.Attributes.["STRUCTUREID"])
                OUTFALLID = optional<string> (feature.Attributes.["OUTFALLID"])
                STRUCTURETYPE = optional<string> (feature.Attributes.["STRUCTURETYPE"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "Private Point" ->
            StormwaterFeature.PrivatePointFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                Z29 = optional<double> (feature.Attributes.["Z29"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "Conduit" ->
            StormwaterFeature.ConduitFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                ACCEPT_DATE = optional<string> (feature.Attributes.["ACCEPT_DATE"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                MATERIAL = optional<string> (feature.Attributes.["MATERIAL"])
                PIPESHAPE = optional<string> (feature.Attributes.["PIPESHAPE"])
                DIAMETER = optional<Int16> (feature.Attributes.["DIAMETER"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                FIELD_COMMENTS_ = optional<string> (feature.Attributes.["FIELD_COMMENTS_"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                UPSTREAMDEPTH = optional<double> (feature.Attributes.["UPSTREAMDEPTH"])
                UPSTREAMELEVATION = optional<double> (feature.Attributes.["UPSTREAMELEVATION"])
                DOWNSTREAMDEPTH = optional<double> (feature.Attributes.["DOWNSTREAMDEPTH"])
                DOWNSTREAMELEVATION = optional<double> (feature.Attributes.["DOWNSTREAMELEVATION"])
                LFEET = optional<double> (feature.Attributes.["LFEET"])
                PERCT_GRD = optional<double> (feature.Attributes.["PERCT_GRD"])
                WIDTH = optional<double> (feature.Attributes.["WIDTH"])
                HEIGHT = optional<double> (feature.Attributes.["HEIGHT"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                OUTFALLID = optional<string> (feature.Attributes.["OUTFALLID"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                SHAPE_Length = optional<double> (feature.Attributes.["SHAPE_Length"])
                X = feature.X
                Y = feature.Y
            }
        | "Culvert Cross Drain" ->
            StormwaterFeature.CulvertCrossDrainFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                MATERIAL = optional<string> (feature.Attributes.["MATERIAL"])
                PIPESHAPE = optional<string> (feature.Attributes.["PIPESHAPE"])
                DIAMETER = optional<Int16> (feature.Attributes.["DIAMETER"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                FIELD_COMMENTS_ = optional<string> (feature.Attributes.["FIELD_COMMENTS_"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                WIDTH = optional<double> (feature.Attributes.["WIDTH"])
                HEIGHT = optional<double> (feature.Attributes.["HEIGHT"])
                ACCEPT_DATE = optional<string> (feature.Attributes.["ACCEPT_DATE"])
                UPSTREAM_ELEV = optional<double> (feature.Attributes.["UPSTREAM_ELEV"])
                UPSTREAM_DEPTH = optional<double> (feature.Attributes.["UPSTREAM_DEPTH"])
                DOWNSTREAM_ELEV = optional<double> (feature.Attributes.["DOWNSTREAM_ELEV"])
                DOWNSTREAM_DEPTH = optional<double> (feature.Attributes.["DOWNSTREAM_DEPTH"])
                NUM_BARRELS = optional<Int32> (feature.Attributes.["NUM_BARRELS"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                LFEET = optional<double> (feature.Attributes.["LFEET"])
                PERCT_GRD = optional<double> (feature.Attributes.["PERCT_GRD"])
                OUTFALLID = optional<string> (feature.Attributes.["OUTFALLID"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                SHAPE_Length = optional<double> (feature.Attributes.["SHAPE_Length"])
                X = feature.X
                Y = feature.Y
            }
        | "Ditch Point" ->
            StormwaterFeature.DitchPointFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                INVENTORYTYPE = optional<string> (feature.Attributes.["INVENTORYTYPE"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                INFILTRATION = optional<Int16> (feature.Attributes.["INFILTRATION"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                RELATEDFEATURE = optional<string> (feature.Attributes.["RELATEDFEATURE"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                Z29 = optional<double> (feature.Attributes.["Z29"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                X = feature.X
                Y = feature.Y
            }
        | "Ditch" ->
            StormwaterFeature.DitchFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                SURFACETYPE = optional<string> (feature.Attributes.["SURFACETYPE"])
                RELATEDFEATURE = optional<string> (feature.Attributes.["RELATEDFEATURE"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                FIELDCOMMENTS = optional<string> (feature.Attributes.["FIELDCOMMENTS"])
                MILES = optional<double> (feature.Attributes.["MILES"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                OUTFALLID = optional<string> (feature.Attributes.["OUTFALLID"])
                UNITID = optional<string> (feature.Attributes.["UNITID"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                SHAPE_Length = optional<double> (feature.Attributes.["SHAPE_Length"])
                X = feature.X
                Y = feature.Y
            }
        | "Bridge Point" ->
            StormwaterFeature.BridgePointFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                INVENTORYTYPE = optional<string> (feature.Attributes.["INVENTORYTYPE"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                INFILTRATION = optional<Int16> (feature.Attributes.["INFILTRATION"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                RELATEDFEATURE = optional<string> (feature.Attributes.["RELATEDFEATURE"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                Z29 = optional<double> (feature.Attributes.["Z29"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                X = feature.X
                Y = feature.Y
            }
        | "Bridge" ->
            StormwaterFeature.BridgeFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                MATERIAL = optional<string> (feature.Attributes.["MATERIAL"])
                PIPESHAPE = optional<string> (feature.Attributes.["PIPESHAPE"])
                DIAMETER = optional<Int16> (feature.Attributes.["DIAMETER"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                FIELD_COMMENTS_ = optional<string> (feature.Attributes.["FIELD_COMMENTS_"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                WIDTH = optional<double> (feature.Attributes.["WIDTH"])
                HEIGHT = optional<double> (feature.Attributes.["HEIGHT"])
                ACCEPT_DATE = optional<string> (feature.Attributes.["ACCEPT_DATE"])
                UPSTREAM_ELEV = optional<double> (feature.Attributes.["UPSTREAM_ELEV"])
                UPSTREAM_DEPTH = optional<double> (feature.Attributes.["UPSTREAM_DEPTH"])
                DOWNSTREAM_ELEV = optional<double> (feature.Attributes.["DOWNSTREAM_ELEV"])
                DOWNSTREAM_DEPTH = optional<double> (feature.Attributes.["DOWNSTREAM_DEPTH"])
                NUM_BARRELS = optional<Int32> (feature.Attributes.["NUM_BARRELS"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                LFEET = optional<double> (feature.Attributes.["LFEET"])
                PERCT_GRD = optional<double> (feature.Attributes.["PERCT_GRD"])
                COMPKEY = optional<Int32> (feature.Attributes.["COMPKEY"])
                Shape_Length = optional<double> (feature.Attributes.["Shape_Length"])
                X = feature.X
                Y = feature.Y
            }
        | "Stormwater Pond - Top of Bank" ->
            StormwaterFeature.StormwaterPondTopofBankFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                ANCILLARYROLE = optional<Int16> (feature.Attributes.["ANCILLARYROLE"])
                ENABLED = optional<Int16> (feature.Attributes.["ENABLED"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                PONDTYPE = optional<string> (feature.Attributes.["PONDTYPE"])
                PARCELID = optional<string> (feature.Attributes.["PARCELID"])
                ACTIVITY = optional<string> (feature.Attributes.["ACTIVITY"])
                FILTER = optional<Int16> (feature.Attributes.["FILTER"])
                FILTERTYPE = optional<string> (feature.Attributes.["FILTERTYPE"])
                FILTERLOCATION = optional<string> (feature.Attributes.["FILTERLOCATION"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                LOCATION = optional<string> (feature.Attributes.["LOCATION"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                HYPERLINK_AR = optional<string> (feature.Attributes.["HYPERLINK_AR"])
                POND_ID = optional<Int16> (feature.Attributes.["POND_ID"])
                SUBTYPEFIELD = optional<Int32> (feature.Attributes.["SUBTYPEFIELD"])
                DRAINAGEAREA = optional<double> (feature.Attributes.["DRAINAGEAREA"])
                ACREAGE = optional<double> (feature.Attributes.["ACREAGE"])
                CAPACITY = optional<double> (feature.Attributes.["CAPACITY"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                PONDYR = optional<string> (feature.Attributes.["PONDYR"])
                SHAPE_Length = optional<double> (feature.Attributes.["SHAPE_Length"])
                X = feature.X
                Y = feature.Y
            }
        | "Outfall Drainage Area MS4" ->
            StormwaterFeature.OutfallDrainageAreaMS4Feature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                ATTACHEDTOID = optional<string> (feature.Attributes.["ATTACHEDTOID"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                ACRES = optional<double> (feature.Attributes.["ACRES"])
                GLOBALID = unbox<Guid> (feature.Attributes.["GLOBALID"])
                Shape_Length = optional<double> (feature.Attributes.["Shape_Length"])
                Shape_Area = optional<double> (feature.Attributes.["Shape_Area"])
                X = feature.X
                Y = feature.Y
            }
        | "Outfall Drainage Area" ->
            StormwaterFeature.OutfallDrainageAreaFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                ATTACHEDTOID = optional<string> (feature.Attributes.["ATTACHEDTOID"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                ACRES = optional<double> (feature.Attributes.["ACRES"])
                GLOBALID = unbox<Guid> (feature.Attributes.["GLOBALID"])
                SHAPE_Length = optional<double> (feature.Attributes.["SHAPE_Length"])
                SHAPE_Area = optional<double> (feature.Attributes.["SHAPE_Area"])
                X = feature.X
                Y = feature.Y
            }
        | "Outfall Drainage Area MOF" ->
            StormwaterFeature.OutfallDrainageAreaMOFFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                ATTACHEDTOID = optional<string> (feature.Attributes.["ATTACHEDTOID"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                ACRES = optional<double> (feature.Attributes.["ACRES"])
                GLOBALID = unbox<Guid> (feature.Attributes.["GLOBALID"])
                Shape_Length = optional<double> (feature.Attributes.["Shape_Length"])
                Shape_Area = optional<double> (feature.Attributes.["Shape_Area"])
                X = feature.X
                Y = feature.Y
            }
        | "Media Points" ->
            StormwaterFeature.MediaPointsFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                HYD_ID = optional<string> (feature.Attributes.["HYD_ID"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                FOLDER = optional<string> (feature.Attributes.["FOLDER"])
                RAW_NAME = optional<string> (feature.Attributes.["RAW_NAME"])
                FINAL_NAME = optional<string> (feature.Attributes.["FINAL_NAME"])
                MEDIA_CODE = optional<string> (feature.Attributes.["MEDIA_CODE"])
                VIEW_ = optional<string> (feature.Attributes.["VIEW_"])
                LOC_DESC = optional<string> (feature.Attributes.["LOC_DESC"])
                ELEMENTX = optional<double> (feature.Attributes.["ELEMENTX"])
                ELEMENTY = optional<double> (feature.Attributes.["ELEMENTY"])
                DATE_ = optional<DateTime> (feature.Attributes.["DATE_"])
                STORAGE_PATH_ADDR = optional<string> (feature.Attributes.["STORAGE_PATH_ADDR"])
                FILE_NAME = optional<string> (feature.Attributes.["FILE_NAME"])
                STORAGE_FULL_PATH_ADDR = optional<string> (feature.Attributes.["STORAGE_FULL_PATH_ADDR"])
                STORAGE_STATIC_PATH_ADDR = optional<string> (feature.Attributes.["STORAGE_STATIC_PATH_ADDR"])
                PHOTOID = optional<string> (feature.Attributes.["PHOTOID"])
                FIELDCREW = optional<string> (feature.Attributes.["FIELDCREW"])
                CREATIONDATE = optional<DateTime> (feature.Attributes.["CREATIONDATE"])
                CREATOR = optional<string> (feature.Attributes.["CREATOR"])
                EDITDATE = optional<DateTime> (feature.Attributes.["EDITDATE"])
                EDITOR = optional<string> (feature.Attributes.["EDITOR"])
                STRUCTURE_ID = optional<string> (feature.Attributes.["STRUCTURE_ID"])
                ROTATION_AZ = optional<Int16> (feature.Attributes.["ROTATION_AZ"])
                PHOTO_NUM = optional<Int16> (feature.Attributes.["PHOTO_NUM"])
                HYPERLINK = optional<string> (feature.Attributes.["HYPERLINK"])
                HOTLINK = optional<string> (feature.Attributes.["HOTLINK"])
                GLOBALID = unbox<Guid> (feature.Attributes.["GLOBALID"])
                X = feature.X
                Y = feature.Y
            }
        | "Damage" ->
            StormwaterFeature.DamageFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                PONDID = optional<string> (feature.Attributes.["PONDID"])
                DESCRIPTION = optional<string> (feature.Attributes.["DESCRIPTION"])
                PHOTOID = optional<string> (feature.Attributes.["PHOTOID"])
                HOTLINK = optional<string> (feature.Attributes.["HOTLINK"])
                DATAFILE = optional<string> (feature.Attributes.["DATAFILE"])
                INSPDATE = optional<DateTime> (feature.Attributes.["INSPDATE"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                INVENTORIED_BY = optional<string> (feature.Attributes.["INVENTORIED_BY"])
                PHOTO_FOLDER = optional<string> (feature.Attributes.["PHOTO_FOLDER"])
                DAMAGEID = optional<string> (feature.Attributes.["DAMAGEID"])
                DAMAGETYPE = optional<string> (feature.Attributes.["DAMAGETYPE"])
                X = feature.X
                Y = feature.Y
            }
        | "Media Points Without Photos" ->
            StormwaterFeature.MediaPointsWithoutPhotosFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                HYD_ID = optional<string> (feature.Attributes.["HYD_ID"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                FOLDER = optional<string> (feature.Attributes.["FOLDER"])
                RAW_NAME = optional<string> (feature.Attributes.["RAW_NAME"])
                FINAL_NAME = optional<string> (feature.Attributes.["FINAL_NAME"])
                MEDIA_CODE = optional<string> (feature.Attributes.["MEDIA_CODE"])
                VIEW_ = optional<string> (feature.Attributes.["VIEW_"])
                LOC_DESC = optional<string> (feature.Attributes.["LOC_DESC"])
                ELEMENTX = optional<double> (feature.Attributes.["ELEMENTX"])
                ELEMENTY = optional<double> (feature.Attributes.["ELEMENTY"])
                DATE_ = optional<DateTime> (feature.Attributes.["DATE_"])
                STORAGE_PATH_ADDR = optional<string> (feature.Attributes.["STORAGE_PATH_ADDR"])
                FILE_NAME = optional<string> (feature.Attributes.["FILE_NAME"])
                STORAGE_FULL_PATH_ADDR = optional<string> (feature.Attributes.["STORAGE_FULL_PATH_ADDR"])
                STORAGE_STATIC_PATH_ADDR = optional<string> (feature.Attributes.["STORAGE_STATIC_PATH_ADDR"])
                PHOTOID = optional<string> (feature.Attributes.["PHOTOID"])
                FIELDCREW = optional<string> (feature.Attributes.["FIELDCREW"])
                CREATIONDATE = optional<DateTime> (feature.Attributes.["CREATIONDATE"])
                CREATOR = optional<string> (feature.Attributes.["CREATOR"])
                EDITDATE = optional<DateTime> (feature.Attributes.["EDITDATE"])
                EDITOR = optional<string> (feature.Attributes.["EDITOR"])
                STRUCTURE_ID = optional<string> (feature.Attributes.["STRUCTURE_ID"])
                ROTATION_AZ = optional<Int16> (feature.Attributes.["ROTATION_AZ"])
                PHOTO_NUM = optional<Int16> (feature.Attributes.["PHOTO_NUM"])
                HYPERLINK = optional<string> (feature.Attributes.["HYPERLINK"])
                HOTLINK = optional<string> (feature.Attributes.["HOTLINK"])
                GLOBALID = unbox<Guid> (feature.Attributes.["GLOBALID"])
                FILE_NAME_1 = optional<string> (feature.Attributes.["FILE_NAME_1"])
                X = feature.X
                Y = feature.Y
            }
        | "Interference" ->
            StormwaterFeature.InterferenceFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                ATTACHEDTOID = optional<string> (feature.Attributes.["ATTACHEDTOID"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                LOCATION = optional<string> (feature.Attributes.["LOCATION"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                INVENTORYTYPE = optional<string> (feature.Attributes.["INVENTORYTYPE"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                Z29 = optional<double> (feature.Attributes.["Z29"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                PRFRESOLUTION = optional<string> (feature.Attributes.["PRFRESOLUTION"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                HYPERLINK_AR = optional<string> (feature.Attributes.["HYPERLINK_AR"])
                FIELDCOMMENTS = optional<string> (feature.Attributes.["FIELDCOMMENTS"])
                SOURCEYEAR = optional<string> (feature.Attributes.["SOURCEYEAR"])
                X = feature.X
                Y = feature.Y
            }
        | "Pollution Control Box" ->
            StormwaterFeature.PollutionControlBoxFeature {
                feature = feature
                OBJECTID = unbox<Int64> (feature.Attributes.["OBJECTID"])
                LIFECYCLE = optional<string> (feature.Attributes.["LIFECYCLE"])
                PARENTID = optional<string> (feature.Attributes.["PARENTID"])
                OWNER = optional<string> (feature.Attributes.["OWNER"])
                MAINTBY = optional<string> (feature.Attributes.["MAINTBY"])
                SOURCE = optional<string> (feature.Attributes.["SOURCE"])
                FACILITYID = optional<string> (feature.Attributes.["FACILITYID"])
                LEGACYID = optional<string> (feature.Attributes.["LEGACYID"])
                ATTACHEDTOID = optional<string> (feature.Attributes.["ATTACHEDTOID"])
                NEEDSATTENTION = optional<Int16> (feature.Attributes.["NEEDSATTENTION"])
                LOCATION = optional<string> (feature.Attributes.["LOCATION"])
                INVENTORYDATE = optional<DateTime> (feature.Attributes.["INVENTORYDATE"])
                INVENTORYTYPE = optional<string> (feature.Attributes.["INVENTORYTYPE"])
                EASTING = optional<double> (feature.Attributes.["EASTING"])
                NORTHING = optional<double> (feature.Attributes.["NORTHING"])
                DIGITALPICTUREID = optional<string> (feature.Attributes.["DIGITALPICTUREID"])
                FIELDCOMPLETE = optional<Int16> (feature.Attributes.["FIELDCOMPLETE"])
                ATTRIBUTECOMPLETE = optional<Int16> (feature.Attributes.["ATTRIBUTECOMPLETE"])
                NOTES = optional<string> (feature.Attributes.["NOTES"])
                PRFRESOLUTION = optional<string> (feature.Attributes.["PRFRESOLUTION"])
                DRAWINGID = optional<string> (feature.Attributes.["DRAWINGID"])
                ORIGINALSOURCE = optional<string> (feature.Attributes.["ORIGINALSOURCE"])
                DATECREATED = optional<DateTime> (feature.Attributes.["DATECREATED"])
                WHOCREATED = optional<string> (feature.Attributes.["WHOCREATED"])
                UPDATESOURCE = optional<string> (feature.Attributes.["UPDATESOURCE"])
                DATEMODIFIED = optional<DateTime> (feature.Attributes.["DATEMODIFIED"])
                WHOMODIFIED = optional<string> (feature.Attributes.["WHOMODIFIED"])
                ACCURACYCODE = optional<string> (feature.Attributes.["ACCURACYCODE"])
                HYPERLINK_AR = optional<string> (feature.Attributes.["HYPERLINK_AR"])
                FIELDCOMMENTS = optional<string> (feature.Attributes.["FIELDCOMMENTS"])
                ZVALUE = optional<double> (feature.Attributes.["ZVALUE"])
                Z29 = optional<double> (feature.Attributes.["Z29"])
                IMAGERYYEAR = optional<string> (feature.Attributes.["IMAGERYYEAR"])
                X = feature.X
                Y = feature.Y
            }
        | tableName -> StormwaterFeature feature

ArcGISRuntimeEnvironment.Initialize()

let StormwaterInfrastructure =
    let layer =
        Mapping.ArcGISMapImageLayer(new Uri "https://interraster.leoncountyfl.gov/interraster/rest/services/MapServices/LCPW_OverlayStormwaterInfrastructure_D_WM/MapServer")
    layer.LoadTablesAndLayersAsync() |> Async.AwaitTask |> Async.RunSynchronously
    layer

let featureTables =
    StormwaterInfrastructure.Sublayers
    |> Seq.cast<Mapping.ArcGISMapImageSublayer>
    |> Seq.collect (fun sublayer ->
        sublayer.Sublayers
        |> Seq.cast<Mapping.ArcGISMapImageSublayer>
        |> Seq.insertAt 0 sublayer)
    |> Seq.choose (fun sublayer -> Option.ofObj sublayer.Table)

let codegenFeatureTypes () =
    featureTables
    |> Seq.map (fun table ->
        let tableName = table.TableName.Replace(" ", "").Replace("-", "")
        let recordFields =
            table.Fields
            |> Seq.map (fun field ->
                let recordFieldType =
                    match field.FieldType with
                    | Data.FieldType.Blob -> "obj"
                    | Data.FieldType.Date -> "DateTime"
                    | Data.FieldType.DateOnly -> "DateOnly"
                    | Data.FieldType.Float32 -> "single"
                    | Data.FieldType.Float64 -> "double"
                    | Data.FieldType.Geometry -> "Geometry.Geometry"
                    | Data.FieldType.GlobalID -> "Guid"
                    | Data.FieldType.Guid -> "Guid"
                    | Data.FieldType.Int16 -> "Int16"
                    | Data.FieldType.Int32 -> "Int32"
                    | Data.FieldType.Int64 -> "Int64"
                    | Data.FieldType.OID -> "Int64"
                    | Data.FieldType.Raster -> "Rasters.Raster"
                    | Data.FieldType.Text -> "string"
                    | Data.FieldType.TimeOnly -> "TimeOnly"
                    | Data.FieldType.TimestampOffset -> "DateTimeOffset"
                    | Data.FieldType.Xml -> "XElement"
                    | _ -> "obj"
                if field.IsNullable then
                    $"{field.Name} : {recordFieldType} option"
                else
                    $"{field.Name} : {recordFieldType}")
            |> String.concat "\n"
        $$"""
    type {{tableName}}Feature =
        {
        feature : Data.Feature
        {{recordFields}}
        X : double option
        Y : double option
        }


        """)
// codegenFeatureTypes() |> String.Clipboard.clip
let codegenFeatureConversions () =

    let featureTypeName (table: Data.ServiceFeatureTable) =
        table.TableName.Replace(" ", "").Replace("-", "") + "Feature"

    let fieldTypeName (field: Data.Field) =
        match field.FieldType with
        | Data.FieldType.Blob -> "obj"
        | Data.FieldType.Date -> "DateTime"
        | Data.FieldType.DateOnly -> "DateOnly"
        | Data.FieldType.Float32 -> "single"
        | Data.FieldType.Float64 -> "double"
        | Data.FieldType.Geometry -> "Geometry.Geometry"
        | Data.FieldType.GlobalID -> "Guid"
        | Data.FieldType.Guid -> "Guid"
        | Data.FieldType.Int16 -> "Int16"
        | Data.FieldType.Int32 -> "Int32"
        | Data.FieldType.Int64 -> "Int64"
        | Data.FieldType.OID -> "Int64"
        | Data.FieldType.Raster -> "Rasters.Raster"
        | Data.FieldType.Text -> "string"
        | Data.FieldType.TimeOnly -> "TimeOnly"
        | Data.FieldType.TimestampOffset -> "DateTimeOffset"
        | Data.FieldType.Xml -> "XElement"
        | _ -> "obj"

    let fieldAssignment (field: Data.Field) =

        let fieldType = fieldTypeName field

        let attributeExpression = sprintf "feature.Attributes.[%A]" field.Name

        let valueExpression =
            if field.IsNullable then
                sprintf "optional<%s> (%s)" fieldType attributeExpression
            else
                sprintf "unbox<%s> (%s)" fieldType attributeExpression

        sprintf "            %s = %s" field.Name valueExpression

    let generateCase (table: Data.ServiceFeatureTable) =

        let typeName = featureTypeName table

        let assignments = table.Fields |> Seq.map fieldAssignment |> String.concat "\n"

        sprintf
            """    | %A ->
        StormwaterFeature.%s {
            feature = feature
%s
            X = feature.X
            Y = feature.Y
        }"""
            table.TableName
            typeName
            assignments

    let cases = featureTables |> Seq.map generateCase |> String.concat "\n"

    sprintf
        """let toStormwaterFeature (feature: Data.Feature) : StormwaterFeature =
    match feature.FeatureTable.TableName with
%s
    | tableName ->
        failwithf "Unrecognized stormwater feature table: %%s" tableName
"""
        cases
// codegenFeatureConversions () |> String.Clipboard.clip
let features =
    featureTables
    |> Seq.collect (fun table -> table.FeatureQuery 0)
    |> Seq.filter (fun feature -> feature.Attributes.ContainsKey "UNITID")
    |> Seq.map StormwaterFeature.ofFeature
module InforTest =
    let Connect () =
        let connection =
            new Microsoft.Data.SqlClient.SqlConnection(
                "ApplicationIntent=ReadOnly;Server=InforTestSql;Database=test;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=True"
            )
        connection.Open()
        connection
let assetFeatures =
    select {
        for asset in table<dbo.lc_stormwater_infrastructure> do
            selectAll
    }
    |> InforTest.Connect().SelectAsync<dbo.lc_stormwater_infrastructure>
    |> Async.AwaitTask
    |> Async.RunSynchronously

let assetFeature = assetFeatures |> Seq.item 1
let assetUnitIDs =
    assetFeatures
    |> Seq.filter (fun assetFeature -> assetFeature.COMPKEY <> 1)
    |> Seq.map (fun assetFeature -> assetFeature.UNITID.TrimStart('''))
    |> Set.ofSeq
type StormwaterFeature with
    member this.UNITID =
        match this with
        | StormwaterFeature feature -> feature.UNITID
        | BridgeFeature feature -> None
        | BridgePointFeature feature -> None
        | ConduitFeature feature -> feature.UNITID
        | ConnectivityFeature feature -> None
        | CulvertCrossDrainFeature feature -> feature.UNITID
        | DamageFeature feature -> None
        | DebrisTrapFeature feature -> feature.UNITID
        | DitchFeature feature -> feature.UNITID
        | DitchPointFeature feature -> None
        | EndPointFeature feature -> feature.UNITID
        | GenericStormAssetFeature feature -> None
        | InletFeature feature -> feature.UNITID
        | InterferenceFeature feature -> None
        | JunctionFixedFeature feature -> feature.UNITID
        | MediaPointsFeature feature -> None
        | MediaPointsWithoutPhotosFeature feature -> None
        | OutfallDrainageAreaFeature feature -> None
        | OutfallDrainageAreaMOFFeature feature -> None
        | OutfallDrainageAreaMS4Feature feature -> None
        | OutfallFeature feature -> feature.UNITID
        | PollutionControlBoxFeature feature -> None
        | PrivatePointFeature feature -> None
        | StormwaterPondDischargeFeature feature -> feature.UNITID
        | StormwaterPondFeature feature -> feature.UNITID
        | StormwaterPondTopofBankFeature feature -> None

let featureUnitIDs = features |> Seq.choose (fun feature -> feature.UNITID) |> Set.ofSeq
assetUnitIDs.Count()
featureUnitIDs.Count()
let missingUnitIDs = featureUnitIDs - assetUnitIDs
missingUnitIDs.Count()
let missingFeatures =
        features
        |> Seq.filter (fun feature ->
            match feature.UNITID with
            | Some unitID -> missingUnitIDs.Contains unitID
            | None -> false)
// missingFeatures[0]
type LoginProvider = WsdlProvider<"""D:\webservices\Core\Security\Hansen.Core.Security.Login.wsdl""">
let mutable ticket = InforSecrets.Login.ticket
let serviceLogin = LoginProvider.ServiceLogin("Hansen8", InforSecrets.Login.username, InforSecrets.Login.password, ticket)
let httpsBinding = new BasicHttpBinding(BasicHttpSecurityMode.Transport)
// let loginSoapClient = new LoginProvider.LoginSoapClient(httpsBinding, new EndpointAddress("https://infortest.leoncountyfl.gov/test_webservices/Core/Security/Hansen.Core.Security.Login.asmx"))

let loginSoapClient =
    new LoginProvider.LoginSoapClient(httpsBinding, new EndpointAddress "https://infortest.leoncountyfl.gov/test_webservices/Core/Security/Hansen.Core.Security.Login.asmx")

let response = loginSoapClient.ServiceLogin(serviceLogin)
if ticket <> response.ticket then
    ticket <- response.ticket

type ComplexProvider = WsdlProvider<"""D:\webservices\AssetManagement\UsageArea\Hansen.AssetManagement.UsageArea.Complex.wsdl""">
let ComplexSoapClient = new ComplexProvider.ComplexSoapClient(httpsBinding,new EndpointAddress "https://infortest.leoncountyfl.gov/test_webservices/AssetManagement/UsageArea/Hansen.AssetManagement.UsageArea.Complex.asmx")
let complex = new ComplexProvider.Hansen_AssetManagement_UsageArea_Complex()
let missingOutfalls = 
    missingFeatures
    |> Seq.choose (fun feature -> 
        match feature with 
        | OutfallFeature outfall -> Some outfall
        | _ -> None)
let outfall = missingOutfalls |> Seq.head 
complex
outfall.UNITID |> Option.map (fun attribute -> complex.ID <- attribute)
outfall.NOTES |> Option.map (fun attribute -> complex.UnitDesc <- attribute)
outfall.X |> Option.map (fun attribute -> complex.XCoordinate <- attribute)
outfall.Y |> Option.map (fun attribute -> complex.YCoordinate <- attribute)

let addResponse = ComplexSoapClient.Add <| ComplexProvider.Hansen_AssetManagement_UsageArea_Complex_Add_1B2M2Y8AsgTpgAmY7PhCfgAA(ticket, complex)
addResponse.``Hansen.AssetManagement.UsageArea.Complex_Add_1B2M2Y8AsgTpgAmY7PhCfgAAResult``.
(*
type StormInletProvider = WsdlProvider<"""D:\webservices\AssetManagement\Storm\Hansen.AssetManagement.Storm.StormInlet.wsdl"""> 
type StormInletCollection = WsdlProvider<"""D:\webservices\AssetManagement\Storm\Hansen.AssetManagement.Storm.StormInletCollection.wsdl"""> 
type StormInletType = WsdlProvider<"""D:\webservices\AssetManagement\Storm\Hansen.AssetManagement.Storm.StormInletType.wsdl"""> 
type StormInletTypeCollection = WsdlProvider<"""D:\webservices\AssetManagement\Storm\Hansen.AssetManagement.Storm.StormInletTypeCollection.wsdl"""> let StormInletSoapClient = new StormInletProvider.StormInletSoapClient(httpsBinding, new EndpointAddress("https://infortest.leoncountyfl.gov/test_webservices/AssetManagement/Storm/Hansen.AssetManagement.Storm.StormInlet.asmx"))

[<Literal>]
let webservicesDirectoryPath = @"\\InforTest\www\test\webservices"
let webservicesDirectory = DirectoryInfo webservicesDirectoryPath
let wsdlFiles = webservicesDirectory.GetFiles("*.wsdl", SearchOption.AllDirectories)
let groupedServices = 
    wsdlFiles
    |> Array.map (fun file ->  
        let lastIndex = file.stem.ToCharArray() |> Array.findIndexBack (fun character -> character = '.')
        let name = file.stem[lastIndex + 1 ..]
        let productFamily = file.stem[..lastIndex - 1]
        let providerPath = file.FullName.Replace(@"\\InforTest\www\test","D:" )
        {|
            productFamily = productFamily
            name = name
            lastIndex = lastIndex
            providerSring = sprintf "type %s = WsdlProvider<\"\"\"%s\"\"\">" name providerPath

        |}
    )
    |> Array.groupBy (fun wsdl -> wsdl.productFamily)
let productFamily, services = groupedServices |> Array.find (fun (productFamily, services) -> productFamily = "Hansen.AssetManagement.Storm")
services[0]
let fsxWebServices = Directory.CreateDirectory @"D:\https\com\github\eristocrates\ipa\fsx\WebServices"
let fsxFile = Path.Combine(fsxWebServices.FullName, $"{productFamily}.fsx") |> FileInfo
let directives = 
    $"""
#I @"D:\https\com\github\eristocrates\FSharp.Data.WsdlProvider\src\FSharp.Data.WsdlProvider.Runtime\bin\Release\net8.0"
#I @"D:\https\com\github\eristocrates\FSharp.Data.WsdlProvider\src\FSharp.Data.WsdlProvider.DesignTime\bin\Release\net8.0"
#r "FSharp.Data.WsdlProvider.Runtime.dll"
#r "FSharp.Data.WsdlProvider.DesignTime.dll"
open FSharp.Data
    """
let fsxContent = services |> Array.map (fun service -> service.providerSring)  |> Array.insertAt 0 directives
File.WriteAllLines(fsxFile.FullName, fsxContent)
type WebServices = WebServiceDescriptionProvider<webservicesDirectoryPath>
open type WebServices.AssetManagement.Storm
Hansen.AssetManagement.Storm.StormInlet.ServiceInfo

type JsonValue with
    /// Creates an XML representation of a JSON value (works
    /// only when the top-level value is an object or an array)
    static member toXml(x: JsonValue) =
        // Helper functions for constructing XML
        // attributes and XML elements
        let attr name value =
            XAttribute(XName.Get name, value) :> XObject

        let elem name (value: obj) =
            XElement(XName.Get name, value) :> XObject

        // Inner recursive function that implements the conversion
        let rec toXml =
            function
            // Primitive values are returned as objects
            | JsonValue.Null -> null
            | JsonValue.Boolean b -> b :> obj
            | JsonValue.Number number -> number :> obj
            | JsonValue.Float number -> number :> obj
            | JsonValue.String s -> s :> obj

            // JSON object becomes a collection of XML
            // attributes (for primitives) or child elements
            | JsonValue.Record properties ->
                properties
                |> Array.map (fun (key, value) ->
                    match value with
                    | JsonValue.String s -> attr key s
                    | JsonValue.Boolean b -> attr key b
                    | JsonValue.Number n -> attr key n
                    | JsonValue.Float n -> attr key n
                    | _ -> elem key (toXml value))
                :> obj

            // JSON array is turned into a
            // sequence of <item> elements
            | JsonValue.Array elements -> elements |> Array.map (fun item -> elem "item" (toXml item)) :> obj

        // Perform the conversion and cast the result to sequence
        // of objects (may fail for unexpected inputs!)
        (toXml x) :?> XObject seq

type FSharpRecord<'RecordType> with
    member this.xmlDocument(rootElementName: string) : XDocument =
        JsonConvert.DeserializeXNode(this.jsonString, rootElementName)

    member this.xmlString(rootElementName: string) =
        this.xmlDocument(rootElementName).ToString()

let jsonString = featureClassRecord.jsonString
let xmlString = featureClassRecord.xmlString featureClassRecord.value.table.TableName
xmlString
// InforTestSql.TestOperations.ASSETMANAGEMENT_STORM.COMPSTIN.
*)
(*
open System
open System.ServiceModel
open System.ServiceModel.Channels

let loginClientType = typeof<LoginProvider.LoginSoapClient>

let expectedBindingType =
    loginClientType.GetConstructors()
    |> Array.pick (fun constructorInfo ->
        let parameters = constructorInfo.GetParameters()

        if parameters.Length = 2 && parameters.[1].ParameterType = typeof<EndpointAddress> then
            Some parameters.[0].ParameterType
        else
            None)

printfn "Expected binding type:"
printfn "%s" expectedBindingType.AssemblyQualifiedName

printfn "Current WCF binding type:"
printfn "%s" typeof<Binding>.AssemblyQualifiedName

printfn "Identical binding types: %b" (expectedBindingType = typeof<Binding>)

printfn "BasicHttpBinding is assignable: %b" (expectedBindingType.IsAssignableFrom(typeof<BasicHttpBinding>))

open System
open System.Runtime.Loader
open System.ServiceModel

let rec inspectType (t: Type) =
    if not (isNull t) then
        let context =
            AssemblyLoadContext.GetLoadContext(t.Assembly)

        printfn "Type: %s" t.FullName
        printfn "Assembly: %s" t.Assembly.FullName
        printfn "Location: %s" t.Assembly.Location
        printfn "Load context: %s" context.Name
        printfn ""

        inspectType t.BaseType

printfn "=== BasicHttpBinding inheritance ==="
inspectType typeof<BasicHttpBinding>

printfn "=== Constructor's expected Binding ==="
inspectType expectedBindingType

open System
open System.Reflection

type DiagnosticDispatchProxy() =
    inherit DispatchProxy()

    override _.Invoke(_method: MethodInfo, _arguments: obj[]) : obj =
        null

let soapInterface =
    typeof<LoginProvider.LoginSoapClient>.BaseType
        .GetGenericArguments()
    |> Array.exactlyOne

printfn "SOAP interface: %s" soapInterface.FullName
printfn "Is interface: %b" soapInterface.IsInterface

for methodInfo in soapInterface.GetMethods() do
    printfn
        "%s | Return: %O | Static: %b | Abstract: %b"
        methodInfo.Name
        methodInfo.ReturnType
        methodInfo.IsStatic
        methodInfo.IsAbstract

let proxy =
    DispatchProxy.Create(
        soapInterface,
        typeof<DiagnosticDispatchProxy>
    )

printfn "Proxy created: %s" (proxy.GetType().FullName)

type IServiceLoginSignatureProbe =

    abstract member ServiceLogin:
        LoginProvider.ServiceLogin ->
        LoginProvider.ServiceLoginResponse
let probe =
    DispatchProxy.Create< IServiceLoginSignatureProbe, DiagnosticDispatchProxy >()

printfn "Created: %s" (probe.GetType().FullName)

open System
open System.Reflection
open System.Reflection.Emit

let sourceMethods = soapInterface.GetMethods()

let assemblyBuilder =
    AssemblyBuilder.DefineDynamicAssembly(
        AssemblyName("LoginSignatureProbes_" + Guid.NewGuid().ToString("N")),
        AssemblyBuilderAccess.Run
    )

let moduleBuilder =
    assemblyBuilder.DefineDynamicModule("LoginSignatureProbes")

let createInterface (name: string) (methods: MethodInfo[]) =

    let interfaceBuilder =
        moduleBuilder.DefineType(
            name,
            TypeAttributes.Public |||
            TypeAttributes.Interface |||
            TypeAttributes.Abstract
        )

    let methodAttributes =
        MethodAttributes.Public |||
        MethodAttributes.Abstract |||
        MethodAttributes.Virtual |||
        MethodAttributes.NewSlot |||
        MethodAttributes.HideBySig

    for methodInfo in methods do
        let parameterTypes =
            methodInfo.GetParameters()
            |> Array.map (fun parameter -> parameter.ParameterType)

        interfaceBuilder.DefineMethod(
            methodInfo.Name,
            methodAttributes,
            methodInfo.ReturnType,
            parameterTypes
        )
        |> ignore

    interfaceBuilder.CreateType()

let testInterface (name: string) (methods: MethodInfo[]) =
    try
        let interfaceType = createInterface name methods

        DispatchProxy.Create(
            interfaceType,
            typeof<DiagnosticDispatchProxy>
        )
        |> ignore

        printfn "PASS: %s" name

    with exceptionValue ->
        printfn "FAIL: %s" name
        printfn "  %s" exceptionValue.Message

sourceMethods
|> Array.iteri (fun index methodInfo ->
    testInterface
        (sprintf "Probe_%02d_%s" index methodInfo.Name)
        [| methodInfo |]
)

testInterface "Probe_AllMethods" sourceMethods
*)
