#time on

fsi.PrintLength <- 10
fsi.ShowDeclarationValues <- false
// fsi.ShowDeclarationValues <- true

open System
open System.Linq
open System.Xml.Linq
open System.IO
open System.Globalization
open System.Text.RegularExpressions

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


#r "nuget: FSharp.Collections.ParallelSeq"
open FSharp.Collections.ParallelSeq

#r "nuget: SQLProvider.MsSql, 1.5.18"
open FSharp.Data.Sql
open FSharp.Data.Sql.MsSql
open System.Linq


#r "nuget: EntityMatcher"
open EntityMatcher
open EntityMatcher.Core
open EntityMatcher.SetMatching



#load @"C:\Secret\InforSecrets.fsx"
open InforSecrets



let clipboard = new Clipboard()
let clip (text:string) = clipboard.SetText text


module HansenDataDistribution = 
    [<Literal>]
    let xmlFilePath =  @"D:/Surface/Company/Infor/Download_Center/Product/Operations_and_Regulations/Release/Infor_Public_Sector_2025_04_01/IPS_2025_04_01/Deployment Files/MetaData/MetaData.xml"
    let xmlFile = FileInfo xmlFilePath
    type Provider = XmlProvider<UseOriginalNames = true, PreferDateOnly = true,
            Sample = xmlFilePath >
    let xml = Provider.Load xmlFilePath


type InforProdSql =
    SqlDataProvider<ConnectionString=Prod.connection_string, IndividualsAmount=10000, UseOptionTypes=Common.NullableColumnType.OPTION>

let operations = InforProdSql.GetDataContext()

ArcGISRuntimeEnvironment.Initialize()

let AccelaXAPO = ArcGISMapImageLayer(new Uri "https://tlcaccela.leoncountyfl.gov/accela/rest/services/AccelaXAPO/MapServer/")
AccelaXAPO.LoadTablesAndLayersAsync()
    |> Async.AwaitTask
    |> Async.RunSynchronously



type ArcGISMapImageLayer with
    member this.sublayers = this.Sublayers |> Seq.map (fun layer -> layer :?> ArcGISMapImageSublayer) |> Seq.toArray
    member this.sublayerById = this.sublayers |> Array.map (fun layer -> layer.Id, layer) |> Map.ofArray

    member this.tables = this.sublayers |> Array.map (fun layer -> layer.Table)









type Feature with 
    member this.mapPoint = this.Geometry :?> MapPoint
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
    member this.ACCELAID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ACCELAID" then Some value else None)
    member this.CW_ASSET = this.attributes |> Array.tryPick (fun (key,value) -> if key = "CW_ASSET" then Some value else None)
    member this.HOUSENUM = this.attributes |> Array.tryPick (fun (key,value) -> if key = "HOUSENUM" then Some value else None)
    member this.LATITUDE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "LATITUDE" then Some value else None)
    member this.LONGITUDE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "LONGITUDE" then Some value else None)
    member this.NAME = this.attributes |> Array.tryPick (fun (key,value) -> if key = "NAME" then Some value else None)
    member this.OBJECTID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "OBJECTID" then Some value else None)
    member this.POSTAL_TOWN = this.attributes |> Array.tryPick (fun (key,value) -> if key = "POSTAL_TOWN" then Some value else None)
    member this.PREFIX = this.attributes |> Array.tryPick (fun (key,value) -> if key = "PREFIX" then Some value else None)
    member this.STATE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "STATE" then Some value else None)
    member this.SUFFIX = this.attributes |> Array.tryPick (fun (key,value) -> if key = "SUFFIX" then Some value else None)
    member this.TYPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "TYPE" then Some value else None)
    member this.UNITID = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UNITID" then Some value else None)
    member this.UNITTYPE = this.attributes |> Array.tryPick (fun (key,value) -> if key = "UNITTYPE" then Some value else None)
    member this.WHOLE_ADDRESS = this.attributes |> Array.tryPick (fun (key,value) -> if key = "WHOLE_ADDRESS" then Some value else None)
    member this.ZIPCD = this.attributes |> Array.tryPick (fun (key,value) -> if key = "ZIPCD" then Some value else None)
    member this.StreetNumber = defaultArg this.HOUSENUM String.Empty
    member this.Stno = this.StreetNumber
    member this.StreetName = defaultArg this.NAME String.Empty
    member this.Stname = this.StreetName
    member this.City = defaultArg this.POSTAL_TOWN String.Empty
    member this.PreDirection = defaultArg this.PREFIX String.Empty
    member this.Predir = this.PreDirection
    member this.State = defaultArg this.STATE String.Empty

    member this.PostDirection = defaultArg this.SUFFIX String.Empty
    member this.Postdir = this.PostDirection
    member this.Suffix = defaultArg this.TYPE String.Empty
    member this.StreetSubDesignation = 
        match this.UNITTYPE, this.UNITID with 
        | Some unitType, Some unitId -> $"{unitType} {unitId}"
        | None, Some unitId -> unitId
        | Some unitType, None -> unitType
        | None, None -> String.Empty
        
    member this.Stsub = this.StreetSubDesignation
    member this.ZIP = defaultArg this.ZIPCD String.Empty
    member this.Zip = this.ZIP


    
    static member Query (offset:int)  (table:ServiceFeatureTable) = 
        Array.concat [|

            let query = QueryParameters()
            query.WhereClause <- "1 = 1"
            query.ResultOffset <- offset
            query.MaxFeatures <-  min 3000 (int table.LayerInfo.MaxRecordCount) 

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


        
type ServiceFeatureTable with
    member this.fields = this.Fields |> Seq.toArray
    member this.domainFields = this.Fields |> Seq.filter (fun field -> field.Domain <> null) |> Seq.toArray
    member this.nondomainFields = this.Fields |> Seq.filter (fun field -> field.Domain = null) |> Seq.toArray
    member this.aliasedFields = this.Fields |> Seq.filter (fun field -> field.Name <> field.Alias) |> Seq.toArray
    member this.getFeatures() = this |> Feature.Query  0




type AddressFeatureRow = 
    {
        NAME:string
        HOUSENUM: string
        OBJECTID:string
        POSTAL_TOWN:string
        PREFIX:string
        STATE:string
        SUFFIX:string
        TYPE:string
        UNITID:string
        UNITTYPE:string
        WHOLE_ADDRESS:string
        ZIPCD:string
    }
    static member fromFeature (feature:Feature) = 
        
        {
            NAME = defaultArg feature.NAME String.Empty
            HOUSENUM = defaultArg feature.HOUSENUM String.Empty
            OBJECTID = defaultArg feature.OBJECTID String.Empty
            POSTAL_TOWN = defaultArg feature.POSTAL_TOWN String.Empty
            PREFIX = defaultArg feature.PREFIX String.Empty
            STATE = defaultArg feature.STATE String.Empty
            SUFFIX = defaultArg feature.SUFFIX String.Empty
            TYPE = defaultArg feature.TYPE String.Empty
            UNITID = defaultArg feature.UNITID String.Empty
            UNITTYPE = defaultArg feature.UNITTYPE String.Empty
            WHOLE_ADDRESS = defaultArg feature.WHOLE_ADDRESS String.Empty
            ZIPCD = defaultArg feature.ZIPCD String.Empty
        }

type AddressAssetRow = 
    {
        /// description="Street number used in locating system units."
        StreetNumber : string
        /// description="Street name used in locating system units.  This is used to identify the street for addresses and blocks, and for the first street for intersections."
        StreetName : string
        /// description="City in which the address is located."
        City : string
        /// description="Code that identifies the direction preceding the street name, as in &quot;North Main Street.&quot;  Must be in the Direction Table."
        PreDirection : string
        /// description="State in which the address is located."
        State : string
        /// description="Code that identifies the direction following the street name, as in &quot;Main Street South.&quot;  Must be in the Direction Table."
        PostDirection : string
        /// description="Code that identifies the street suffix, as in Street, Road, Avenue, etc.  Must be in the Street Suffix Table."
        Suffix : string
        /// description="Sub-designation identifier.  Suite number, apartment number, or any other additional address designation."
        StreetSubDesignation : string
        /// description="ZIP+4 of the address."
        ZIP : string
        (*
        
        /// description="Code that identifies the street suffix, as in Street, Road, Avenue, etc.  Must be in the Street Suffix Code Table.  This is used for the first cross street for addresses and blocks, and for the second street for intersections."
        Street2Suffix : string
        /// description="Key to an address.  This is a system generated, non-display, sequential number."
        AddressKey : string
        /// description="Code that identifies work area of address location. Must be in the Area Table."
        Area : string
        /// description="Code that identifies status of the address. Must be in the AddressStatus Table."
        AddressStatus : string
        /// description="Block of the address"
        Block : string
        /// description="Enumeration constraint using Address City Limits enumeration.&#xA;&#xD;Indicates if an address exists outside agency city limits or not."
        CityLimits : string
        /// description="Code that identifies the compass direction to differentiate between multiple intersections of the same two streets.  Must be in the Direction Table."
        CompassDirection : string
        /// description="Flag indicating if the address is foreign.  'Y' indicates that the address is foreign which will disable the validation, 'N' otherwise."
        Foreign : string
        /// description="Shows the range of street numbers which concantenates &quot;StreetNumber&quot; and &quot;StreetNumberHi&quot; and puts the string &quot;to&quot; between them IF the address is a range address."
        FullStreetNumber : string
        /// description="GPS X value for this address."
        GPSXCoordinate : string
        /// description="GPS Y value for this address."
        GPSYCoordinate : string
        /// description="GPS Z value for this address."
        GPSZCoordinate : string
        /// description="indicates if the address is the most current version."
        IsCurrent : string
        /// description="Free form field describing legal property description."
        LegalDescription : string
        /// description="Free form field describing legal owner."
        LegalOwner : string
        /// description="Lot of address"
        Lot : string
        /// description="Number of the map where the address is located."
        MapNumber : string
        /// description="Optional code definition"
        OptionA : string
        /// description="Optional agency code definition"
        OptionB : string
        /// description="Optional agency code definition"
        OptionC : string
        /// description="Optional integer field"
        OptionD : string
        /// description="FK to Property Use code table."
        PropertyUse : string
        /// description="Block cross street or second street of intersection or optinal cross street of street address"
        Street2Name : string
        /// description="Street name used in locating system units.  This is used for the first cross street for addresses, blocks and ranges, and for the second street for intersections."
        Street2Name : string
        /// description="Code that identifies the direction following the street name, as in &quot;Main Street South.&quot;  Must be in the Direction Code Table.  This is used for the first cross street for addresses and blocks, and for the second street for intersections."
        Street2PostDirection : string
        /// description="Code that identifies the direction preceding the street name, as in &quot;North Main Street.&quot;  Must be in the Direction Code Table.  This is used for the first cross street for addresses and blocks, and for the second street for intersections."
        Street2PreDirection : string
        /// description="Street name used in locating system units.  This is used for the second cross street for addresses, blocks and ranges."
        Street3Name : string
        /// description="Code that identifies the direction following the street name, as in &quot;Main Street South.&quot;  Must be in the Direction Code Table.  This is used for the second cross street for addresses and blocks."
        Street3PostDirection : string
        /// description="Code that identifies the direction preceding the street name, as in &quot;North Main Street.&quot;  Must be in the Direction Code Table.  This is used for the second cross street for addresses and blocks."
        Street3PreDirection : string
        /// description="Code that identifies the street suffix, as in Street, Road, Avenue, etc.  Must be in the Street Suffix Code Table.  This is used for the second cross street for addresses and blocks."
        Street3Suffix : string
        /// description="The high street number when a range address type is used."
        StreetNumberHigh : string
        /// description="Numeric interpretation of StreetNumber.  Used for sorting and searching."
        StreetNumberSortAs : string
        /// description="Numeric interpretation of StreetNumberHigh.  Used for sorting and searching"
        StreetNumberSortAsHigh : string
        /// description="Code that identifies subdivision of address location. Must be in the Subdivision Table."
        SubDivisionCode : string
        /// description="Description of subdivision of address location."
        SubDivisionDescription : string
        /// description="FK to Address Township code table. "
        TownshipCode : string
        /// description="Flag indicating the type of record in the table.  'A' = Address, 'I' = Intersection, 'B' = Block, 'R' = Range.  Traditional street address records are type 'A'."
        Type : string
        /// description="stores the version of the address"
        Version : string
        /// description="FK to In Out Service Area code table.&#xD;&#xA;&#xD;&#xA;"
        InOutServiceArea : string
        /// description="Management Group of the address"
        ManagementGroup : string
        /// description="CASS Validation Date"
        CassValidationDateTime : string
        /// description="Description of the Cass Validation Result."
        CassValidationDescription : string
        /// description="Specifies the status of the Cass Validation."
        CassValidationStatus : string
        /// description="For CASS processing.  Validation state information.  Displays if the validation succeeded or failed."
        CassIsValid : string
        /// description="Indicates whether duplicate services are allowed at the address."
        AllowDuplicateServices : string
        
        *)
        
        }
        static member fromFeature (feature:Feature) = 
            {
                StreetName  = feature.StreetName
                StreetNumber  = feature.StreetNumber
                City  = feature.City
                PreDirection  = feature.PreDirection
                State  = feature.State
                PostDirection  = feature.PostDirection
                Suffix  = feature.Suffix
                StreetSubDesignation  = feature.StreetSubDesignation
                ZIP  = feature.ZIP
            }
        member this.asStreetAddress  =
            [
                this.StreetNumber
                this.PreDirection
                this.StreetName
                this.Suffix
                this.PostDirection
                this.StreetSubDesignation
            ]
            |> List.filter (System.String.IsNullOrWhiteSpace >> not)
            |> String.concat " "





type FeatureClass = 
    {
        imageLayer: ArcGISMapImageSublayer
        sublayer: FeatureLayer
        featureTable: ServiceFeatureTable
        features: Feature array
    }
    static member fromTable (featureTable:ServiceFeatureTable) = 
            {
                imageLayer = AccelaXAPO.sublayerById[featureTable.ServiceLayerId]
                sublayer = featureTable.Layer :?> FeatureLayer
                featureTable = featureTable
                features = featureTable.getFeatures()
            }
    // member this.assetRows (featureToAsset : Feature -> 'Asset) = this.features |> Array.Parallel.map featureToAsset |> Array.toList



let AddressFeatureClass = FeatureClass.fromTable AccelaXAPO.sublayers[0].Table

let targetColumns = 
    set [
        "StreetNumber"
        "StreetName"
        "City"
        "PreDirection"
        "State"
        "PostDirection"
        "Suffix"
        "StreetSubDesignation"
        "ZIP"
    ]

module Hansen = 
    module Property = 
        let productFamily = 
            HansenDataDistribution.xml.hansenMetadata.productFamilies
            |> Array.find (fun productFamily -> productFamily.name = "Property" )
        module Address = 
            let table = productFamily.tables |> Array.find (fun table -> table.name = "Address")
            let featureColumns = 
                table.columns |> Array.filter (fun column ->
                    match  column.locale with 
                    | Some "" -> targetColumns.Contains(column.name)
                    | Some "US" -> targetColumns.Contains(column.name)
                    | _ -> false
                     )


Hansen.Property.Address.featureColumns
|> Array.map (fun column -> $"this.{column.databaseName.ToTitleCase()} = this.{column.name}")

  
// AddressFeatureClass.features[0].attributes



let databaseAddresses = 
    query {
        for address in operations.Property.Address do 
            select (address.Stno, address.Stname, address.City, address.Predir, address.State, address.Postdir, address.Stsub,  address.Suffix, address.Zip)
    }
    |> PSeq.map(fun (addressStno, addressStname, addressCity, addressPredir, addressState, addressPostdir, addressStsub,  addressSuffix, addressZip) -> 
            
            {
                StreetName  = addressStname.ReplaceWhitespace("")
                StreetNumber  = addressStno.ReplaceWhitespace("")
                City  = addressCity.ReplaceWhitespace("")
                PreDirection  = addressPredir.ReplaceWhitespace("")
                State  = addressState.ReplaceWhitespace("")
                PostDirection  = addressPostdir.ReplaceWhitespace("")
                Suffix  = addressSuffix.ReplaceWhitespace("")
                StreetSubDesignation  = addressStsub.ReplaceWhitespace("")
                ZIP  = addressZip.ReplaceWhitespace("")
            }
    )
    |> PSeq.toArray

let addressMatcher = EntityMatcherEngineBuilder().Build()


let addressesMatch
    (layerAddress: AddressAssetRow)
    (databaseAddress: AddressAssetRow) =

    addressMatcher
        .Compare(
            FieldKind.USStreetAddress,
            layerAddress.asStreetAddress,
            databaseAddress.asStreetAddress
        )
        .State = MatchState.Match



type AddressMatchType =
    | ByStreetNumber = 0
    | ByStreetName   = 1
    | ByZIP          = 2


type MatchByStreetNumber() =
    inherit SetMatchDefinition< AddressAssetRow, AddressMatchType, string >()

    override _.MatchType =
        AddressMatchType.ByStreetNumber

    override _.Conversion =
        Func<AddressAssetRow, string>(
            fun address -> address.StreetNumber
        )

    override _.FilterMatch =
        Func<AddressAssetRow, bool>(
            fun address ->
                not (String.IsNullOrWhiteSpace address.StreetNumber)
        )

let addressDefinitions :
    ISetMatchDefinition<AddressAssetRow, AddressMatchType>[] =
    [|
        MatchByStreetNumber()
        :> ISetMatchDefinition<AddressAssetRow, AddressMatchType>
    |]

let databaseAddressMatcher =
    EntitySetMatcher<AddressAssetRow, AddressMatchType>(
        databaseAddresses,
        addressDefinitions
    )









let findCandidates (layerAddress: AddressAssetRow) : AddressAssetRow array =
    let requirements =
        [| AddressMatchType.ByStreetNumber |]

    let requirementSpan =
        ReadOnlySpan<AddressMatchType>(requirements)

    let matches =
        databaseAddressMatcher.FindMatches(
            layerAddress,
            requirementSpan
        )

    matches.ToArray()

let findMatches (layerAddress: AddressAssetRow) =
    findCandidates layerAddress
    |> Array.choose (fun databaseAddress ->
        let result =
            addressMatcher.Compare(
                FieldKind.USStreetAddress,
                layerAddress.asStreetAddress,
                databaseAddress.asStreetAddress
            )

        if result.State = MatchState.Match then
            Some (databaseAddress, result)
        else
            None
    )

let databaseAddressSet = databaseAddresses |> Set.ofSeq


let layerAddresses = AddressFeatureClass.features |> Array.map AddressAssetRow.fromFeature
let layerAddressSet = layerAddresses |> Set.ofArray

let novelAddresses = layerAddressSet - databaseAddressSet |> Set.toArray



let addressLinkage =
    layerAddresses
    |> Array.map (fun layerAddress ->
        let matches =
            findMatches layerAddress

        layerAddress, matches
    )






let alreadyExists (layerAddress: AddressAssetRow) =
    let candidates =
        findCandidates layerAddress

    candidates
    |> Array.exists (addressesMatch layerAddress)



let matchedLayerAddresses =
    layerAddresses
    |> Array.filter alreadyExists 

matchedLayerAddresses.Length
matchedLayerAddresses[0]

let testAddresses = 
    databaseAddresses
    |> Array.filter (fun databaseAddress -> 
        databaseAddress.StreetNumber = matchedLayerAddresses[0].StreetNumber)

testAddresses.Length

let layerAddress, matches =
    addressLinkage.[0]

layerAddress
matches
let databaseAddress, matchResult =
    matches.[0]

layerAddress.asStreetAddress
databaseAddress.asStreetAddress

matchResult.State
matchResult.Score
matchResult.Method










let matchedAddresses =
    addressLinkage
    |> Array.collect (fun (layerAddress, matches) ->
        matches
        |> Array.map (fun (databaseAddress, result) ->
            {|
                Layer = layerAddress
                Database = databaseAddress
                LayerStreetAddress = layerAddress.asStreetAddress
                DatabaseStreetAddress = databaseAddress.asStreetAddress
                Score = result.Score
                Method = result.Method
            |}
        )
    )

let missingLayerAddresses =
    addressLinkage
    |> Array.choose (fun (layerAddress, matches) ->
        if Array.isEmpty matches then
            Some layerAddress
        else
            None
    )

let existingLayerAddresses =
    addressLinkage
    |> Array.choose (fun (layerAddress, matches) ->
        if Array.isEmpty matches then
            None
        else
            Some layerAddress
    )




// addressLinkage |> Array.randomChoice
// missingLayerAddresses |> Array.randomSample 5  |> Array.toList


let sampleFeatures = AddressFeatureClass.features |> Array.randomSample 5
let addressAssetRows = sampleFeatures |> Array.map AddressAssetRow.fromFeature |> Array.toList
let addressFeatureRows = sampleFeatures |> Array.map AddressFeatureRow.fromFeature |> Array.toList

let dateDirectoryName = DateTime.Now.ToString("yyyy-MM-dd")

let dateDirectory = Directory.CreateDirectory $@"D:\Persistence\XLSX\LCG\{dateDirectoryName}"
let addressImportFile = Path.Combine (dateDirectory.FullName,"Addresses.xlsx" ) |> FileInfo

[
    Worksheet "Addresses_to_Address"
    FsExcel.Table [ TableName "Addresses_to_Address" ; TableItems addressAssetRows ]
    FsExcel.AutoFit All
    Worksheet "Addresses"
    FsExcel.Table [ TableName "Addresses" ; TableItems addressFeatureRows ]
    FsExcel.AutoFit All
]
|> Render.AsFile addressImportFile.FullName

let MappingsXmlFile = Path.Combine(dateDirectory.FullName, "Mappings.xml") |> FileInfo
let sourceFile = FileInfo @"D:\www\update\Integration\TLCAccela\AccelaXAPO\Addresses.xlsx"

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

      "Addresses", "Hansen", "Property", "Address", "PROPERTY", "ADDRESS", "AddressInfoViewerApplet", 1219

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





type FeatureAssetClassTable =
    { ``ArcGIS Feature Class``: string
      ``Infor Business Object``: string
      ``InforProdSql Database Table``: string
      ``InforProd Url Template``: string 
      ``InforProd Table Key``:int 
      }
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

        "Addresses", "HOUSENUM", "Hansen", "Property", "Address", "StreetNumber", "PROPERTY", "ADDRESS", "STNO", "System.String"
        "Addresses", "NAME", "Hansen", "Property", "Address", "StreetName", "PROPERTY", "ADDRESS", "STNAME", "System.String"
        "Addresses", "POSTAL_TOWN", "Hansen", "Property", "Address", "City", "PROPERTY", "ADDRESS", "CITY", "System.String"
        "Addresses", "PREFIX", "Hansen", "Property", "Address", "PreDirection", "PROPERTY", "ADDRESS", "PREDIR", "System.String"
        "Addresses", "STATE", "Hansen", "Property", "Address", "State", "PROPERTY", "ADDRESS", "STATE", "System.String"
        "Addresses", "SUFFIX", "Hansen", "Property", "Address", "PostDirection", "PROPERTY", "POSTDIR", "POSTDIR", "System.String"
        "Addresses", "TYPE", "Hansen", "Property", "Address", "Suffix", "PROPERTY", "ADDRESS", "SUFFIX", "System.String"
        "Addresses", "UNITTYPEID", "Hansen", "Property", "Address", "StreetSubDesignation", "PROPERTY", "ADDRESS", "STSUB", "System.String"
        "Addresses", "ZIPCD", "Hansen", "Property", "Address", "ZIP", "PROPERTY", "ADDRESS", "ZIP", "System.String"

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
            let mapName =  sprintf "%s_to_%s" (assetFeatureIdentity.featureClass.ReplaceWhitespace("_")) (assetFeatureIdentity.businessObject.ReplaceWhitespace("_")) 
            key <- key + 1
            let mapKey = string key
            let mapColumns = 
                propertyAttributeIdentities
                |> List.filter (fun propertyAttributeIdentity -> propertyAttributeIdentity.featureClass =  assetFeatureIdentity.featureClass)
            Map {

                Key { mapKey  }
                IsDefault { "false" }
                Name { mapName }
                SourceFilePath { sourceFile.FullName }
                SheetName { mapName }
                ConnectionString { $"""Provider=Microsoft.ACE.OLEDB.12.0;Data Source={sourceFile.FullName};Extended Properties="Excel 12.0;HDR=Yes;IMEX=1";""" }
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










// TODO get all address features, make a spreadsheet, try to get pedro to confirm column mapping 
(*
AddressFeatureClass.featureTable.fields
|> Array.map (fun field -> $"    member this.{field.Name} = this.attributes |> Array.tryPick (fun (key,value) -> if key = \"{field.Name}\" then Some value else None)")
|> Array.distinct
|> Array.sort
|> String.concat "\n"
|> clip


// 2280 Miccosukee Road, Tallahassee, FL 32308
let sampleFeature = 
    AddressFeatureClass.features
    |> Array.Parallel.choose (fun feature ->
        match feature.HOUSENUM with 
        |  Some "427" -> Some feature 
        | _ -> None 
    )
    |> Array.head
sampleFeature.mapPoint.X
sampleFeature.mapPoint.Y
sampleFeature.mapPoint.Z

sampleFeature.ACCELAID
sampleFeature.CW_ASSET
sampleFeature.HOUSENUM
sampleFeature.LATITUDE
sampleFeature.LONGITUDE
sampleFeature.NAME
sampleFeature.OBJECTID
sampleFeature.POSTAL_TOWN
sampleFeature.PREFIX
sampleFeature.STATE
sampleFeature.SUFFIX
sampleFeature.TYPE
sampleFeature.UNITID
sampleFeature.UNITTYPE
sampleFeature.WHOLE_ADDRESS
sampleFeature.ZIPCD


*)











//