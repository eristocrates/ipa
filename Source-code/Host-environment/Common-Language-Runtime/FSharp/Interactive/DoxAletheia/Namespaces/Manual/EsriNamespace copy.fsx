#load @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\DoxAletheia\RDFErgonomics.fsx"
open RDFErgonomics

module esri =

    let _prefix = prefix_label "esri"


    let ``abstract`` = _prefix "abstract"
    let ``type`` = _prefix "type"
    let absres = _prefix "absres"
    let accconst = _prefix "accconst"
    let add_fields = _prefix "add_fields"
    let AddCodedValueToDomain = _prefix "AddCodedValueToDomain"
    let AddField = _prefix "AddField"
    let AddGlobalIDs = _prefix "AddGlobalIDs"
    let address = _prefix "address"
    let addrtype = _prefix "addrtype"
    let AddSubtype = _prefix "AddSubtype"
    let AliasName = _prefix "AliasName"
    let aliasName = _prefix "aliasName"
    let altenc = _prefix "altenc"
    let AlterField = _prefix "AlterField"
    let altres = _prefix "altres"
    let altsys = _prefix "altsys"
    let AppBuilder = _prefix "AppBuilder"
    let AppStudio = _prefix "AppStudio"
    let ArcCatalog = _prefix "ArcCatalog"
    let arcgisant = _prefix "arcgisant"
    let ArcGISFormat = _prefix "ArcGISFormat"
    let ArcGISstyle = _prefix "ArcGISstyle"
    let ArcGlobe = _prefix "ArcGlobe"
    let ArcIMS = _prefix "ArcIMS"
    let ArcInfo = _prefix "ArcInfo"
    let ArcObjects = _prefix "ArcObjects"
    let ArcPad = _prefix "ArcPad"
    let ArcPy = _prefix "ArcPy"
    let ArcReader = _prefix "ArcReader"
    let ArcScene = _prefix "ArcScene"
    let ArcSDE = _prefix "ArcSDE"
    let ArcToolbox = _prefix "ArcToolbox"
    let ArcXML = _prefix "ArcXML"
    let AreaFieldName = _prefix "AreaFieldName"
    let AssignDefaultToField = _prefix "AssignDefaultToField"
    let AssignDomainToField = _prefix "AssignDomainToField"
    let atprecis = _prefix "atprecis"
    let attalias = _prefix "attalias"
    let attr = _prefix "attr"
    let attracc = _prefix "attracc"
    let attrdef = _prefix "attrdef"
    let attrdefs = _prefix "attrdefs"
    let attrdomv = _prefix "attrdomv"
    let attrlabl = _prefix "attrlabl"
    let attrtype = _prefix "attrtype"
    let attscale = _prefix "attscale"
    let attwidth = _prefix "attwidth"
    let autovectorization = _prefix "autovectorization"
    let AvgNumPoints = _prefix "AvgNumPoints"
    let avgNumPoints = _prefix "avgNumPoints"
    let BackwardPathLabel = _prefix "BackwardPathLabel"
    let basemap = _prefix "basemap"
    let bottombc = _prefix "bottombc"
    let bounding = _prefix "bounding"
    let breakline = _prefix "breakline"
    let cadastre = _prefix "cadastre"
    let caldate = _prefix "caldate"
    let CanVersion = _prefix "CanVersion"
    let Cardinality = _prefix "Cardinality"
    let CarteAssociation = _prefix "CarteAssociation"
    let CatalogPath = _prefix "CatalogPath"
    let centerpoint = _prefix "centerpoint"
    let ChangeTracked = _prefix "ChangeTracked"
    let CharSetCd = _prefix "CharSetCd"
    let Children = _prefix "Children"
    let CIMFeatureDatasetDataConnection = _prefix "CIMFeatureDatasetDataConnection"
    let CIMStandardDataConnection = _prefix "CIMStandardDataConnection"
    let citation = _prefix "citation"
    let citeinfo = _prefix "citeinfo"
    let city = _prefix "city"
    let CityEngine = _prefix "CityEngine"
    let ClassKey = _prefix "ClassKey"
    let ClassKeyName = _prefix "ClassKeyName"
    let clear_field_alias = _prefix "clear_field_alias"
    let clear_value = _prefix "clear_value"
    let CLSID = _prefix "CLSID"
    let cntaddr = _prefix "cntaddr"
    let cntinfo = _prefix "cntinfo"
    let cntorg = _prefix "cntorg"
    let cntorgp = _prefix "cntorgp"
    let cntper = _prefix "cntper"
    let cntvoice = _prefix "cntvoice"
    let Code = _prefix "Code"
    let code = _prefix "code"
    let code_description = _prefix "code_description"
    let coded_value = _prefix "coded_value"
    let coded_values = _prefix "coded_values"
    let CodedValue = _prefix "CodedValue"
    let CodedValues = _prefix "CodedValues"
    let computer = _prefix "computer"
    let configKeyword = _prefix "configKeyword"
    let ConfigurationKeyword = _prefix "ConfigurationKeyword"
    let connectionProperty = _prefix "connectionProperty"
    let ControllerMemberships = _prefix "ControllerMemberships"
    let coordRef = _prefix "coordRef"
    let coordrep = _prefix "coordrep"
    let cordsysn = _prefix "cordsysn"
    let countryCode = _prefix "countryCode"
    let CreaDate = _prefix "CreaDate"
    let CreatedAtFieldName = _prefix "CreatedAtFieldName"
    let CreaTime = _prefix "CreaTime"
    let creation_date = _prefix "creation_date"
    let creation_date_field = _prefix "creation_date_field"
    let creationDate = _prefix "creationDate"
    let creator = _prefix "creator"
    let creator_field = _prefix "creator_field"
    let CreatorFieldName = _prefix "CreatorFieldName"
    let csUnits = _prefix "csUnits"
    let current = _prefix "current"
    let dasymetric = _prefix "dasymetric"
    let database = _prefix "database"
    let DataElement = _prefix "DataElement"
    let dataExt = _prefix "dataExt"
    let dataIdInfo = _prefix "dataIdInfo"
    let dataLang = _prefix "dataLang"
    let DataProperties = _prefix "DataProperties"
    let dataqual = _prefix "dataqual"
    let Dataset = _prefix "Dataset"
    let DatasetDefinitions = _prefix "DatasetDefinitions"
    let DatasetType = _prefix "DatasetType"
    let datasnooping = _prefix "datasnooping"
    let Date = _prefix "Date"
    let day = _prefix "day"
    let DefaultSubtypeCode = _prefix "DefaultSubtypeCode"
    let defaultSubtypeCode = _prefix "defaultSubtypeCode"
    let DefaultValue = _prefix "DefaultValue"
    let defaultValue = _prefix "defaultValue"
    let DeleteCodedValueFromDomain = _prefix "DeleteCodedValueFromDomain"
    let DeleteField = _prefix "DeleteField"
    let denflat = _prefix "denflat"
    let descript = _prefix "descript"
    let Description = _prefix "Description"
    let DestinationClassNames = _prefix "DestinationClassNames"
    let detailed = _prefix "detailed"
    let direct = _prefix "direct"
    let DisableEditorTracking = _prefix "DisableEditorTracking"
    let DispID = _prefix "DispID"
    let distFormat = _prefix "distFormat"
    let distInfo = _prefix "distInfo"
    let distinfo = _prefix "distinfo"
    let distorFormat = _prefix "distorFormat"
    let distorTran = _prefix "distorTran"
    let distributor = _prefix "distributor"
    let dockable = _prefix "dockable"
    let Domain = _prefix "Domain"
    let domain = _prefix "domain"
    let domain_name = _prefix "domain_name"
    let DomainFixed = _prefix "DomainFixed"
    let domainFixed = _prefix "domainFixed"
    let DomainName = _prefix "DomainName"
    let Domains = _prefix "Domains"
    let domdesc = _prefix "domdesc"
    let domfldtp = _prefix "domfldtp"
    let domname = _prefix "domname"
    let domowner = _prefix "domowner"
    let domtype = _prefix "domtype"
    let DSID = _prefix "DSID"
    let eainfo = _prefix "eainfo"
    let eastbc = _prefix "eastbc"
    let eastBL = _prefix "eastBL"
    let edgematching = _prefix "edgematching"
    let edit_to_base = _prefix "edit_to_base"
    let Editable = _prefix "Editable"
    let editable = _prefix "editable"
    let EditedAtFieldName = _prefix "EditedAtFieldName"
    let EditorFieldName = _prefix "EditorFieldName"
    let EditorTrackingEnabled = _prefix "EditorTrackingEnabled"
    let efeacnt = _prefix "efeacnt"
    let efeageom = _prefix "efeageom"
    let efeatyp = _prefix "efeatyp"
    let ellips = _prefix "ellips"
    let EnableEditorTracking = _prefix "EnableEditorTracking"
    let enttyp = _prefix "enttyp"
    let enttypc = _prefix "enttypc"
    let enttypl = _prefix "enttypl"
    let enttypt = _prefix "enttypt"
    let envirDesc = _prefix "envirDesc"
    let EOBrowser = _prefix "EOBrowser"
    let Esri = _prefix "Esri"
    let esriDatasetType = _prefix "esriDatasetType"
    let esriExtentType = _prefix "esriExtentType"
    let esriFeatureType = _prefix "esriFeatureType"
    let esriFieldType = _prefix "esriFieldType"
    let esriGeometryType = _prefix "esriGeometryType"
    let esriterm = _prefix "esriterm"
    let esritopo = _prefix "esritopo"
    let esriWorkspaceType = _prefix "esriWorkspaceType"
    let EXTCLSID = _prefix "EXTCLSID"
    let ExtensionProperties = _prefix "ExtensionProperties"
    let Extent = _prefix "Extent"
    let exTypeCode = _prefix "exTypeCode"
    let FeatureDataset = _prefix "FeatureDataset"
    let FeatureType = _prefix "FeatureType"
    let field = _prefix "field"
    let field_alias = _prefix "field_alias"
    let field_domain = _prefix "field_domain"
    let field_is_nullable = _prefix "field_is_nullable"
    let field_is_required = _prefix "field_is_required"
    let field_length = _prefix "field_length"
    let field_name = _prefix "field_name"
    let field_precision = _prefix "field_precision"
    let field_type = _prefix "field_type"
    let FieldArray = _prefix "FieldArray"
    let FieldInfos = _prefix "FieldInfos"
    let FieldName = _prefix "FieldName"
    let Fields = _prefix "Fields"
    let FieldType = _prefix "FieldType"
    let flavor = _prefix "flavor"
    let formatName = _prefix "formatName"
    let ForwardPathLabel = _prefix "ForwardPathLabel"
    let ftname = _prefix "ftname"
    let GeoAnalytics = _prefix "GeoAnalytics"
    let GeoBndBox = _prefix "GeoBndBox"
    let geoBox = _prefix "geoBox"
    let GeocodeServer = _prefix "GeocodeServer"
    let geocomputation = _prefix "geocomputation"
    let geodatabase = _prefix "geodatabase"
    let geodatabaseDesigner = _prefix "geodatabaseDesigner"
    let GeoDataServer = _prefix "GeoDataServer"
    let geodataset = _prefix "geodataset"
    let geodesign = _prefix "geodesign"
    let geodetic = _prefix "geodetic"
    let geoEle = _prefix "geoEle"
    let geoenable = _prefix "geoenable"
    let GeoEnrichment = _prefix "GeoEnrichment"
    let GeoEvent = _prefix "GeoEvent"
    let geoform = _prefix "geoform"
    let GeoForm = _prefix "GeoForm"
    let geogcsn = _prefix "geogcsn"
    let geometObjs = _prefix "geometObjs"
    let GeometryDef = _prefix "GeometryDef"
    let geometryDef = _prefix "geometryDef"
    let GeometryType = _prefix "GeometryType"
    let GeoMobility = _prefix "GeoMobility"
    let geoObjCnt = _prefix "geoObjCnt"
    let geoObjTyp = _prefix "geoObjTyp"
    let GeoObjTypCd = _prefix "GeoObjTypCd"
    let GeoPlanner = _prefix "GeoPlanner"
    let georeferencing = _prefix "georeferencing"
    let georelational = _prefix "georelational"
    let GeoRSS = _prefix "GeoRSS"
    let geospecific = _prefix "geospecific"
    let geostatistics = _prefix "geostatistics"
    let geosurvey = _prefix "geosurvey"
    let geotypical = _prefix "geotypical"
    let giomgr = _prefix "giomgr"
    let GIScience = _prefix "GIScience"
    let GlobalID = _prefix "GlobalID"
    let GlobalIDFieldName = _prefix "GlobalIDFieldName"
    let grid = _prefix "grid"
    let GridSize0 = _prefix "GridSize0"
    let gsrvr = _prefix "gsrvr"
    let HasGlobalID = _prefix "HasGlobalID"
    let HasM = _prefix "HasM"
    let hasM = _prefix "hasM"
    let HasOID = _prefix "HasOID"
    let HasSpatialIndex = _prefix "HasSpatialIndex"
    let HasZ = _prefix "HasZ"
    let hasZ = _prefix "hasZ"
    let Helmert = _prefix "Helmert"
    let HighPrecision = _prefix "HighPrecision"
    let hillshading = _prefix "hillshading"
    let horizdn = _prefix "horizdn"
    let horizsys = _prefix "horizsys"
    let hour = _prefix "hour"
    let hours = _prefix "hours"
    let idCitation = _prefix "idCitation"
    let idCodeSpace = _prefix "idCodeSpace"
    let identCode = _prefix "identCode"
    let idinfo = _prefix "idinfo"
    let IDispatch = _prefix "IDispatch"
    let idVersion = _prefix "idVersion"
    let imsContentType = _prefix "imsContentType"
    let index = _prefix "index"
    let IndexArray = _prefix "IndexArray"
    let Indexes = _prefix "Indexes"
    let isanomal = _prefix "isanomal"
    let IsAscending = _prefix "IsAscending"
    let isAscending = _prefix "isAscending"
    let IsAttachmentRelationship = _prefix "IsAttachmentRelationship"
    let IsAttributed = _prefix "IsAttributed"
    let IsComposite = _prefix "IsComposite"
    let IsNullable = _prefix "IsNullable"
    let isNullable = _prefix "isNullable"
    let IsReflexive = _prefix "IsReflexive"
    let IsTimeInUTC = _prefix "IsTimeInUTC"
    let IsUnique = _prefix "IsUnique"
    let isUnique = _prefix "isUnique"
    let item = _prefix "item"
    let itemLocation = _prefix "itemLocation"
    let itemName = _prefix "itemName"
    let itemProps = _prefix "itemProps"
    let itemType = _prefix "itemType"
    let IUnknown = _prefix "IUnknown"
    let JavaServer = _prefix "JavaServer"
    let KeyRole = _prefix "KeyRole"
    let KeyType = _prefix "KeyType"
    let keywords = _prefix "keywords"
    let Kohonen = _prefix "Kohonen"
    let Krüger = _prefix "Krüger"
    let langdata = _prefix "langdata"
    let langmeta = _prefix "langmeta"
    let languageCode = _prefix "languageCode"
    let last_edit_date = _prefix "last_edit_date"
    let last_edit_date_field = _prefix "last_edit_date_field"
    let last_editor = _prefix "last_editor"
    let last_editor_field = _prefix "last_editor_field"
    let LatestVCSWKID = _prefix "LatestVCSWKID"
    let LatestWKID = _prefix "LatestWKID"
    let LayerFile = _prefix "LayerFile"
    let lboundng = _prefix "lboundng"
    let leftbc = _prefix "leftbc"
    let Length = _prefix "Length"
    let length = _prefix "length"
    let LengthFieldName = _prefix "LengthFieldName"
    let lineage = _prefix "lineage"
    let linkage = _prefix "linkage"
    let linrefer = _prefix "linrefer"
    let LocateXT = _prefix "LocateXT"
    let Maplex = _prefix "Maplex"
    let MapServer = _prefix "MapServer"
    let MapTip = _prefix "MapTip"
    let mdChar = _prefix "mdChar"
    let mdDateSt = _prefix "mdDateSt"
    let mdHrLv = _prefix "mdHrLv"
    let mdHrLvName = _prefix "mdHrLvName"
    let mdLang = _prefix "mdLang"
    let mdStanName = _prefix "mdStanName"
    let mdStanVer = _prefix "mdStanVer"
    let mereing = _prefix "mereing"
    let MergePolicy = _prefix "MergePolicy"
    let metabase = _prefix "metabase"
    let Metadata = _prefix "Metadata"
    let metadata = _prefix "metadata"
    let MetadataRetrieved = _prefix "MetadataRetrieved"
    let metainfo = _prefix "metainfo"
    let metc = _prefix "metc"
    let metd = _prefix "metd"
    let metextns = _prefix "metextns"
    let metprof = _prefix "metprof"
    let metstdn = _prefix "metstdn"
    let metstdv = _prefix "metstdv"
    let mettc = _prefix "mettc"
    let minute = _prefix "minute"
    let ModDate = _prefix "ModDate"
    let ModelBuilder = _prefix "ModelBuilder"
    let ModelName = _prefix "ModelName"
    let modelName = _prefix "modelName"
    let ModTime = _prefix "ModTime"
    let month = _prefix "month"
    let MOrigin = _prefix "MOrigin"
    let mrgtype = _prefix "mrgtype"
    let MScale = _prefix "MScale"
    let MTolerance = _prefix "MTolerance"
    let multipatch = _prefix "multipatch"
    let multipatches = _prefix "multipatches"
    let multiversioned = _prefix "multiversioned"
    let Name = _prefix "Name"
    let name = _prefix "name"
    let NaN = _prefix "NaN"
    let native = _prefix "native"
    let nativeExtBox = _prefix "nativeExtBox"
    let natvform = _prefix "natvform"
    let Navstar = _prefix "Navstar"
    let neatline = _prefix "neatline"
    let new_field_name = _prefix "new_field_name"
    let NoData = _prefix "NoData"
    let nonsimple = _prefix "nonsimple"
    let nonspatial = _prefix "nonspatial"
    let northbc = _prefix "northbc"
    let northBL = _prefix "northBL"
    let Notification = _prefix "Notification"
    let objCount = _prefix "objCount"
    let objectClass = _prefix "objectClass"
    let ObjectID = _prefix "ObjectID"
    let ObjectKeyName = _prefix "ObjectKeyName"
    let oidField = _prefix "oidField"
    let OIDFieldName = _prefix "OIDFieldName"
    let onLineSrc = _prefix "onLineSrc"
    let onlink = _prefix "onlink"
    let OpenGIS = _prefix "OpenGIS"
    let OpenLS = _prefix "OpenLS"
    let operationSequence = _prefix "operationSequence"
    let orDesc = _prefix "orDesc"
    let ordres = _prefix "ordres"
    let origin = _prefix "origin"
    let OriginClassKeys = _prefix "OriginClassKeys"
    let OriginClassNames = _prefix "OriginClassNames"
    let orthomosaic = _prefix "orthomosaic"
    let orthophotoquad = _prefix "orthophotoquad"
    let orthophotoscope = _prefix "orthophotoscope"
    let Owner = _prefix "Owner"
    let owner = _prefix "owner"
    let Peucker = _prefix "Peucker"
    let peXml = _prefix "peXml"
    let photogeology = _prefix "photogeology"
    let place = _prefix "place"
    let placekey = _prefix "placekey"
    let planar = _prefix "planar"
    let plance = _prefix "plance"
    let planci = _prefix "planci"
    let plandu = _prefix "plandu"
    let postal = _prefix "postal"
    let Precision = _prefix "Precision"
    let precision = _prefix "precision"
    let presForm = _prefix "presForm"
    let PresFormCd = _prefix "PresFormCd"
    let procdate = _prefix "procdate"
    let procdesc = _prefix "procdesc"
    let Process = _prefix "Process"
    let procstep = _prefix "procstep"
    let proctime = _prefix "proctime"
    let progress = _prefix "progress"
    let projcsn = _prefix "projcsn"
    let ProjectedCoordinateSystem = _prefix "ProjectedCoordinateSystem"
    let PropertyArray = _prefix "PropertyArray"
    let protocol = _prefix "protocol"
    let ptcontac = _prefix "ptcontac"
    let ptvctinf = _prefix "ptvctinf"
    let pubdate = _prefix "pubdate"
    let pubinfo = _prefix "pubinfo"
    let publish = _prefix "publish"
    let pubplace = _prefix "pubplace"
    let purpose = _prefix "purpose"
    let Qt = _prefix "Qt"
    let QuickCapture = _prefix "QuickCapture"
    let RasterFieldName = _prefix "RasterFieldName"
    let rasters = _prefix "rasters"
    let ratioing = _prefix "ratioing"
    let record_dates_in = _prefix "record_dates_in"
    let recordset = _prefix "recordset"
    let refSysID = _prefix "refSysID"
    let refSysInfo = _prefix "refSysInfo"
    let RefSystem = _prefix "RefSystem"
    let Regedit = _prefix "Regedit"
    let RegisterAsVersioned = _prefix "RegisterAsVersioned"
    let relatedItems = _prefix "relatedItems"
    let RelationshipClassKey = _prefix "RelationshipClassKey"
    let RelationshipClassNames = _prefix "RelationshipClassNames"
    let RelationshipRules = _prefix "RelationshipRules"
    let rematching = _prefix "rematching"
    let RemoveDomainFromField = _prefix "RemoveDomainFromField"
    let Required = _prefix "Required"
    let required = _prefix "required"
    let resdesc = _prefix "resdesc"
    let resTitle = _prefix "resTitle"
    let ReViewer = _prefix "ReViewer"
    let rhumb = _prefix "rhumb"
    let rightbc = _prefix "rightbc"
    let Scale = _prefix "Scale"
    let scale = _prefix "scale"
    let ScopeCd = _prefix "ScopeCd"
    let sdesetup = _prefix "sdesetup"
    let second = _prefix "second"
    let semiaxis = _prefix "semiaxis"
    let semiminor = _prefix "semiminor"
    let semivariogram = _prefix "semivariogram"
    let shapeField = _prefix "shapeField"
    let ShapeFieldName = _prefix "ShapeFieldName"
    let ShapeType = _prefix "ShapeType"
    let size = _prefix "size"
    let SnapTip = _prefix "SnapTip"
    let sngdate = _prefix "sngdate"
    let soundex = _prefix "soundex"
    let southbc = _prefix "southbc"
    let southBL = _prefix "southBL"
    let spatialization = _prefix "spatialization"
    let SpatialReference = _prefix "SpatialReference"
    let spatRepInfo = _prefix "spatRepInfo"
    let SpatRepTypCd = _prefix "SpatRepTypCd"
    let spatRpType = _prefix "spatRpType"
    let spdoinfo = _prefix "spdoinfo"
    let spdom = _prefix "spdom"
    let spindex = _prefix "spindex"
    let SplitPolicy = _prefix "SplitPolicy"
    let splttype = _prefix "splttype"
    let spref = _prefix "spref"
    let srcused = _prefix "srcused"
    let state = _prefix "state"
    let stateful = _prefix "stateful"
    let status = _prefix "status"
    let stcode = _prefix "stcode"
    let stereocompilation = _prefix "stereocompilation"
    let stereometer = _prefix "stereometer"
    let stereomodel = _prefix "stereomodel"
    let stereopair = _prefix "stereopair"
    let stereoplotter = _prefix "stereoplotter"
    let stfield = _prefix "stfield"
    let stflddd = _prefix "stflddd"
    let stflddv = _prefix "stflddv"
    let stfldnm = _prefix "stfldnm"
    let stname = _prefix "stname"
    let StoryMaps = _prefix "StoryMaps"
    let StreetMap = _prefix "StreetMap"
    let subsumption = _prefix "subsumption"
    let Subtype = _prefix "Subtype"
    let subtype = _prefix "subtype"
    let subtype_code = _prefix "subtype_code"
    let subtype_description = _prefix "subtype_description"
    let SubtypeCode = _prefix "SubtypeCode"
    let subtypeField = _prefix "subtypeField"
    let SubtypeFieldInfo = _prefix "SubtypeFieldInfo"
    let SubtypeFieldName = _prefix "SubtypeFieldName"
    let SubtypeName = _prefix "SubtypeName"
    let Subtypes = _prefix "Subtypes"
    let symbology = _prefix "symbology"
    let Sync = _prefix "Sync"
    let SyncDate = _prefix "SyncDate"
    let SyncOnce = _prefix "SyncOnce"
    let SyncTime = _prefix "SyncTime"
    let table = _prefix "table"
    let theme = _prefix "theme"
    let themekey = _prefix "themekey"
    let themekt = _prefix "themekt"
    let Time = _prefix "Time"
    let timeinfo = _prefix "timeinfo"
    let timeperd = _prefix "timeperd"
    let title = _prefix "title"
    let ToolSource = _prefix "ToolSource"
    let topbc = _prefix "topbc"
    let topLvl = _prefix "topLvl"
    let TopoLevCd = _prefix "TopoLevCd"
    let Type = _prefix "Type"
    let udom = _prefix "udom"
    let UIControl = _prefix "UIControl"
    let unjoined = _prefix "unjoined"
    let update = _prefix "update"
    let useconst = _prefix "useconst"
    let user = _prefix "user"
    let UVMap = _prefix "UVMap"
    let value = _prefix "value"
    let variography = _prefix "variography"
    let VCSWKID = _prefix "VCSWKID"
    let VectSpatRep = _prefix "VectSpatRep"
    let Version = _prefix "Version"
    let version = _prefix "version"
    let Versioned = _prefix "Versioned"
    let vertdef = _prefix "vertdef"
    let VMap = _prefix "VMap"
    let Voronoi = _prefix "Voronoi"
    let vTable = _prefix "vTable"
    let westbc = _prefix "westbc"
    let westBL = _prefix "westBL"
    let WKID = _prefix "WKID"
    let WKT = _prefix "WKT"
    let workflow = _prefix "workflow"
    let Workspace = _prefix "Workspace"
    let WorkspaceConnectionString = _prefix "WorkspaceConnectionString"
    let WorkspaceData = _prefix "WorkspaceData"
    let WorkspaceDefinition = _prefix "WorkspaceDefinition"
    let WorkspaceFactory = _prefix "WorkspaceFactory"
    let WorkspaceType = _prefix "WorkspaceType"
    let XMax = _prefix "XMax"
    let XMin = _prefix "XMin"
    let XmlDoc = _prefix "XmlDoc"
    let XOrigin = _prefix "XOrigin"
    let XYScale = _prefix "XYScale"
    let XYTolerance = _prefix "XYTolerance"
    let year = _prefix "year"
    let YMax = _prefix "YMax"
    let YMin = _prefix "YMin"
    let YOrigin = _prefix "YOrigin"
    let ZMax = _prefix "ZMax"
    let ZMin = _prefix "ZMin"
    let ZOrigin = _prefix "ZOrigin"
    let ZScale = _prefix "ZScale"
    let ZTolerance = _prefix "ZTolerance"

    /// Analysis Cell Size
    /// The cell size used by raster tools.
    let analysis_cell_size = _prefix "analysis_cell_size"

    /// Address Locator
    /// A dataset used for geocoding that stores the address attributes, associated indexes, and rules that define the process for translating nonspatial descriptions of places to spatial data.
    let DEAddressLocator = _prefix "DEAddressLocator"

    /// INFO Table
    /// A table in an INFO database.
    let DEArcInfoTable = _prefix "DEArcInfoTable"

    /// BIM File Workspace
    /// Spatial data in Revit file format.
    let DEBimFileWorkspace = _prefix "DEBimFileWorkspace"

    /// Parcel Fabric for ArcMap
    /// A parcel fabric for ArcMap is a dataset for the storage, maintenance, and editing of a continuous surface of connected parcels or parcel network.
    let DECadastralFabric = _prefix "DECadastralFabric"

    /// CAD Drawing Dataset
    /// A vector data source mixed with feature types and symbology. The dataset is not usable for feature class-based queries or analysis.
    let DECadDrawingDataset = _prefix "DECadDrawingDataset"

    /// Catalog Root
    /// The top-level node in the Catalog tree.
    let DECatalogRoot = _prefix "DECatalogRoot"

    /// Coverage
    /// A coverage dataset, a proprietary data model for storing geographic features as points, arcs, and polygons with associated feature attribute tables.
    let DECoverage = _prefix "DECoverage"

    /// Coverage Feature Class
    /// A coverage feature class, such as point, arc, node, route, route system, section, polygon, and region.
    let DECoverageFeatureClass = _prefix "DECoverageFeatureClass"

    /// Dataset
    /// A collection of related data, usually grouped or stored together.
    let DEDatasetType = _prefix "DEDatasetType"

    /// dBASE Table
    /// Attribute data stored in dBASE format.
    let DEDbaseTable = _prefix "DEDbaseTable"

    /// Disk Connection
    /// An access path to a data storage device.
    let DEDiskConnection = _prefix "DEDiskConnection"

    /// Feature Class
    /// A collection of spatial data with the same shape type: point, multipoint, polyline, and polygon.
    let DEFeatureClass = _prefix "DEFeatureClass"

    /// Feature Dataset
    /// A collection of feature classes that share a common geographic area and the same spatial reference system.
    let DEFeatureDataset = _prefix "DEFeatureDataset"

    /// File
    /// A file on disk.
    let DEFile = _prefix "DEFile"

    /// Folder
    /// Specifies a location on disk where data is stored.
    let DEFolder = _prefix "DEFolder"

    /// GeoDataServer
    /// A coarse-grained object that references a geodatabase.
    let DEGeoDataServer = _prefix "DEGeoDataServer"

    /// Geodataset
    /// A collection of data with a common theme in a geodatabase.
    let DEGeoDatasetType = _prefix "DEGeoDatasetType"

    /// Geometric Network
    /// A linear network represented by topologically connected edge and junction features. Feature connectivity is based on their geometric coincidence.
    let DEGeometricNetwork = _prefix "DEGeometricNetwork"

    /// GlobeServer
    /// A Globe server.
    let DEGlobeServer = _prefix "DEGlobeServer"

    /// GPServer
    /// A geoprocessing server.
    let DEGPServer = _prefix "DEGPServer"

    /// Image Service
    /// An image service.
    let DEImageServer = _prefix "DEImageServer"

    /// LAS Dataset
    /// A LAS dataset stores reference to one or more LAS files on disk as well as to additional surface features. A LAS file is a binary file that stores airborne lidar data.
    let DELasDataset = _prefix "DELasDataset"

    /// Layer File
    /// A layer file stores a layer definition, including symbology and rendering properties.
    let DELayer = _prefix "DELayer"

    /// ArcMap Document
    /// A file that contains one map, its layout, and its associated layers, tables, charts, and reports.
    let DEMapDocument = _prefix "DEMapDocument"

    /// Map Server
    /// A map server.
    let DEMapServer = _prefix "DEMapServer"

    /// Mosaic Dataset
    /// A collection of raster and image data that allows you to store, view, and query the data. It is a data model in the geodatabase used to manage a collection of raster datasets (images) stored as a catalog and viewed as a mosaicked image.
    let DEMosaicDataset = _prefix "DEMosaicDataset"

    /// Network Dataset
    /// A collection of topologically connected network elements (edges, junctions, and turns), derived from network sources and associated with a collection of network attributes.
    let DENetworkDataset = _prefix "DENetworkDataset"

    /// Parcel Fabric
    let DEParcelDataset = _prefix "DEParcelDataset"

    /// Projection File
    /// A file storing coordinate system information for spatial data.
    let DEPrjFile = _prefix "DEPrjFile"

    /// Raster Band
    /// A layer in a raster dataset.
    let DERasterBand = _prefix "DERasterBand"

    /// Raster Catalog
    /// A collection of raster datasets defined in a table. Each table record defines an individual raster dataset in the catalog.
    let DERasterCatalog = _prefix "DERasterCatalog"

    /// Raster Dataset
    /// A single dataset built from one or more rasters.
    let DERasterDataset = _prefix "DERasterDataset"

    /// Relationship Class
    /// The details about the relationship between objects in the geodatabase.
    let DERelationshipClass = _prefix "DERelationshipClass"

    /// Database Connections
    /// The database connection folder in ArcCatalog.
    let DERemoteDatabaseFolder = _prefix "DERemoteDatabaseFolder"

    /// ServerConnection
    /// A server connection.
    let DEServerConnection = _prefix "DEServerConnection"

    /// Shapefile
    /// Spatial data in a shapefile format.
    let DEShapeFile = _prefix "DEShapeFile"

    /// Coordinate Systems Folder
    /// A folder on disk storing coordinate systems.
    let DESpatialReferencesFolder = _prefix "DESpatialReferencesFolder"

    /// Table
    /// Tabular data.
    let DETable = _prefix "DETable"

    /// Text File
    /// Data stored in ASCII format.
    let DETextFile = _prefix "DETextFile"

    /// TIN
    /// A vector data structure that partitions geographic space into contiguous, nonoverlapping triangles. The vertices of each triangle are sample data points with x-, y-, and z-values.
    let DETin = _prefix "DETin"

    /// Tool
    /// A geoprocessing tool.
    let DETool = _prefix "DETool"

    /// Toolbox
    /// A geoprocessing toolbox.
    let DEToolbox = _prefix "DEToolbox"

    /// Topology
    /// A topology that defines and enforces data integrity rules for spatial data.
    let DETopology = _prefix "DETopology"

    /// Trace Network
    let DETraceNetwork = _prefix "DETraceNetwork"

    /// Data Element
    /// A dataset visible in ArcCatalog.
    let DEType = _prefix "DEType"

    /// Utility Network
    let DEUtilityNetwork = _prefix "DEUtilityNetwork"

    /// VPF Coverage
    /// Spatial data stored in Vector Product Format.
    let DEVPFCoverage = _prefix "DEVPFCoverage"

    /// VPF Table
    /// Attribute data stored in Vector Product Format.
    let DEVPFTable = _prefix "DEVPFTable"

    /// WCS Coverage
    /// Web Coverage Service (WCS) is an open specification for sharing raster datasets on the web.
    let DEWCSCoverage = _prefix "DEWCSCoverage"

    /// WMS Map
    /// A WMS map.
    let DEWMSMap = _prefix "DEWMSMap"

    /// WMTS Layer
    /// A WMTS Layer.
    let DEWMTS = _prefix "DEWMTS"

    /// Workspace
    /// A container such as a geodatabase or folder.
    let DEWorkspace = _prefix "DEWorkspace"

    /// Field
    /// A column in a table that stores the values for a single attribute.
    let Field = _prefix "Field"

    /// Decimate
    /// Specifies a subset of nodes of a TIN to create a generalized version of that TIN.
    let GP3DADecimate = _prefix "GP3DADecimate"

    /// 3D Object Feature Layer
    /// A layer that defines how 3D object features are displayed in a scene.
    let GP3DObjectFeatureLayer = _prefix "GP3DObjectFeatureLayer"

    /// 3D Tiles Layer
    /// A 3D tiles layer references a tileset that defines an integrated mesh or 3D object type data in a hierarchical data structure.
    let GP3DTilesLayer = _prefix "GP3DTilesLayer"

    /// Annotation Layer
    let GPAnnotationLayer = _prefix "GPAnnotationLayer"

    /// INFO Item
    /// An item in an INFO table.
    let GPArcInfoItem = _prefix "GPArcInfoItem"

    /// Areal Unit
    /// An areal unit type and value, such as square meter or acre.
    let GPArealUnit = _prefix "GPArealUnit"

    /// Boolean
    /// A Boolean value.
    let GPBoolean = _prefix "GPBoolean"

    /// Building Discipline Layer
    let GPBuildingDisciplineLayer = _prefix "GPBuildingDisciplineLayer"
    /// Building Layer
    let GPBuildingLayer = _prefix "GPBuildingLayer"
    /// Building Discipline Scene Layer
    let GPBuildingSceneDisciplineLayer = _prefix "GPBuildingSceneDisciplineLayer"
    /// Building Scene Layer
    let GPBuildingSceneLayer = _prefix "GPBuildingSceneLayer"

    /// Parcel Fabric Layer for ArcMap
    /// A layer referencing a parcel fabric for ArcMap on disk. This layer works as a group layer organizing a set of related layers under a single layer.
    let GPCadastralFabricLayer = _prefix "GPCadastralFabricLayer"

    /// Calculator Expression
    /// A calculator expression.
    let GPCalculatorExpression = _prefix "GPCalculatorExpression"

    /// Catalog Layer
    /// A catalog layer.
    let GPCatalogLayer = _prefix "GPCatalogLayer"

    /// Cell Size XY
    /// Defines the two sides of a raster cell.
    let GPCellSizeXY = _prefix "GPCellSizeXY"

    /// Composite Layer
    /// A reference to several children layers, including symbology and rendering properties.
    let GPCompositeLayer = _prefix "GPCompositeLayer"

    /// Coordinate System
    /// A reference framework, such as the UTM system, consisting of a set of points, lines, or surfaces, and a set of rules used to define the positions of points in two- and three-dimensional space.
    let GPCoordinateSystem = _prefix "GPCoordinateSystem"

    /// Data File
    /// A data file.
    let GPDataFile = _prefix "GPDataFile"

    /// Date
    /// A date value.
    let GPDate = _prefix "GPDate"

    /// Diagram Layer
    /// Diagram layer
    let GPDiagramLayer = _prefix "GPDiagramLayer"

    /// Dimension Layer
    let GPDimensionLayer = _prefix "GPDimensionLayer"

    /// Double
    /// Any floating-point number stored as a double precision, 64-bit value.
    let GPDouble = _prefix "GPDouble"

    /// Elevation Surface Layer
    /// Elevation surface layer
    let GPElevationSurfaceLayer = _prefix "GPElevationSurfaceLayer"

    /// Encrypted String
    /// Encrypted string for passwords.
    let GPEncryptedString = _prefix "GPEncryptedString"

    /// Envelope
    /// The coordinate pairs that define the minimum bounding rectangle in which the data source falls.
    let GPEnvelope = _prefix "GPEnvelope"

    /// Evaluation Scale
    /// The scale value range and increment value applied to inputs in a weighted overlay operation.
    let GPEvaluationScale = _prefix "GPEvaluationScale"

    /// Extent
    /// Specifies the coordinate pairs that define the minimum bounding rectangle (xmin, ymin and xmax, ymax) of a data source. All coordinates for the data source fall in this boundary.
    let GPExtent = _prefix "GPExtent"

    /// Feature Layer
    /// A reference to a feature class, including symbology and rendering properties.
    let GPFeatureLayer = _prefix "GPFeatureLayer"

    /// Feature Set
    /// Interactive features that draw the features when the tool is run.
    let GPFeatureRecordSetLayer = _prefix "GPFeatureRecordSetLayer"

    /// Field Info
    /// The details about a field in a FieldMap.
    let GPFieldInfo = _prefix "GPFieldInfo"

    /// Field Mappings
    /// A collection of fields in one or more input tables.
    let GPFieldMapping = _prefix "GPFieldMapping"

    /// Geostatistical Layer
    /// A reference to a geostatistical data source, including symbology and rendering properties.
    let GPGALayer = _prefix "GPGALayer"

    /// Geostatistical Search Neighborhood
    /// Defines the searching neighborhood parameters for a geostatistical layer.
    let GPGASearchNeighborhood = _prefix "GPGASearchNeighborhood"

    /// Geostatistical Value Table
    /// A collection of data sources and fields that define a geostatistical layer.
    let GPGAValueTable = _prefix "GPGAValueTable"

    /// Graph
    /// A graph.
    let GPGraph = _prefix "GPGraph"

    /// Graph Data Table
    /// A graph data table.
    let GPGraphDataTable = _prefix "GPGraphDataTable"

    /// Graphics Layer
    /// A layer that contains graphic elements.
    let GPGraphicsLayer = _prefix "GPGraphicsLayer"

    /// Group Layer
    /// A collection of layers that appear and act as a single layer. Group layers make it easier to organize a map, assign advanced drawing order options, and share layers for use in other maps.
    let GPGroupLayer = _prefix "GPGroupLayer"

    /// INFO Expression
    /// A syntax for defining and manipulating data in an INFO table.
    let GPINFOExpression = _prefix "GPINFOExpression"

    /// Internet Tiled Layer
    let GPInternetTiledLayer = _prefix "GPInternetTiledLayer"
    /// KML Layer
    let GPKMLLayer = _prefix "GPKMLLayer"

    /// LAS Dataset Layer
    /// A layer that references a LAS dataset on disk. This layer can apply filters on lidar files and surface constraints referenced by a LAS dataset.
    let GPLasDatasetLayer = _prefix "GPLasDatasetLayer"

    /// Layer
    /// A reference to a data source, such as a shapefile, coverage, geodatabase feature class, or raster, including symbology and rendering properties.
    let GPLayer = _prefix "GPLayer"

    /// Layout
    let GPLayout = _prefix "GPLayout"

    /// Line
    /// A shape, straight or curved, defined by a connected series of unique x,y-coordinate pairs.
    let GPLine = _prefix "GPLine"

    /// Linear Unit
    /// A linear unit type and value such as meter or feet.
    let GPLinearUnit = _prefix "GPLinearUnit"

    /// Long
    /// An integer number value.
    let GPLong = _prefix "GPLong"

    /// Map
    let GPMap = _prefix "GPMap"
    /// Map Server Layer
    let GPMapServerLayer = _prefix "GPMapServerLayer"

    /// M Domain
    /// A range of lowest and highest possible value for m-coordinates.
    let GPMDomain = _prefix "GPMDomain"

    /// Mosaic Layer
    /// A layer that references a mosaic dataset.
    let GPMosaicLayer = _prefix "GPMosaicLayer"

    /// Network Analyst Hierarchy Settings
    /// A hierarchy attribute that divides hierarchy values of a network dataset into three groups using two integers. The first integer sets the ending value of the first group; the second number sets the beginning value of the third group.
    let GPNAHierarchySettings = _prefix "GPNAHierarchySettings"

    /// Network Analyst Layer
    /// A special group layer used to express and solve network routing problems. Each sublayer held in memory in a Network Analyst layer represents some aspect of the routing problem and the routing solution.
    let GPNALayer = _prefix "GPNALayer"

    /// Network Dataset Layer
    /// A reference to a network dataset, including symbology and rendering properties.
    let GPNetworkDatasetLayer = _prefix "GPNetworkDatasetLayer"

    /// Network Data Source
    let GPNetworkDataSource = _prefix "GPNetworkDataSource"

    /// Oriented Imagery Layer
    /// Oriented Imagery Layer.
    let GPOrientedImageryLayer = _prefix "GPOrientedImageryLayer"

    /// Parcel Layer
    let GPParcelLayer = _prefix "GPParcelLayer"

    /// Point
    /// A pair of x,y-coordinates.
    let GPPoint = _prefix "GPPoint"

    /// Polygon
    /// A connected sequence of x,y-coordinate pairs, where the first and last coordinate pair are the same.
    let GPPolygon = _prefix "GPPolygon"

    /// Random Number Generator
    /// Specifies the seed and the generator to use when creating random values.
    let GPRandomNumberGenerator = _prefix "GPRandomNumberGenerator"

    /// Raster Type
    /// Raster data is added to a mosaic dataset by specifying a raster type. The raster type identifies metadata, such as georeferencing, acquisition date, and sensor type, with a raster format.
    let GPRasterBuilder = _prefix "GPRasterBuilder"

    /// Raster Calculator Expression
    /// A raster calculator expression.
    let GPRasterCalculatorExpression = _prefix "GPRasterCalculatorExpression"

    /// Raster Catalog Layer
    /// A reference to a raster catalog, including symbology and rendering properties.
    let GPRasterCatalogLayer = _prefix "GPRasterCatalogLayer"

    /// Raster Data Layer
    /// A raster data layer.
    let GPRasterDataLayer = _prefix "GPRasterDataLayer"

    /// Formulated Raster
    /// A raster surface whose cell values are represented by a formula or constant.
    let GPRasterFormulated = _prefix "GPRasterFormulated"

    /// Raster Layer
    /// A reference to a raster, including symbology and rendering properties.
    let GPRasterLayer = _prefix "GPRasterLayer"

    /// Record Set
    /// Interactive table; type in the table values when the tool is run.
    let GPRecordSet = _prefix "GPRecordSet"

    /// Report
    /// ArcGIS report
    let GPReport = _prefix "GPReport"

    /// Route Measure Event Properties
    /// Specifies the fields on a table that describe events measured by a linear referencing route system.
    let GPRouteMeasureEventProperties = _prefix "GPRouteMeasureEventProperties"

    /// Cell Size
    /// The cell size used by the ArcGIS Spatial Analyst extension.
    let GPSACellSize = _prefix "GPSACellSize"

    /// Extract Values
    /// An extract values parameter.
    let GPSAExtractValues = _prefix "GPSAExtractValues"

    /// Fuzzy function
    /// Specifies the algorithm used in fuzzification of an input raster.
    let GPSAFuzzyFunction = _prefix "GPSAFuzzyFunction"

    /// Compression
    /// Specifies the type of compression used for a raster.
    let GPSAGDBEnvCompression = _prefix "GPSAGDBEnvCompression"

    /// Pyramid
    /// Specifies if pyramids are built.
    let GPSAGDBEnvPyramid = _prefix "GPSAGDBEnvPyramid"

    /// Raster Statistics
    /// Specifies if raster statistics build.
    let GPSAGDBEnvStatistics = _prefix "GPSAGDBEnvStatistics"

    /// Tile Size
    /// Specifies the width and the height of data stored in a block.
    let GPSAGDBEnvTileSize = _prefix "GPSAGDBEnvTileSize"

    /// Horizontal Factor
    /// The relationship between the horizontal cost factor and the horizontal relative moving angle.
    let GPSAHorizontalFactor = _prefix "GPSAHorizontalFactor"

    /// Neighborhood
    /// The shape of the area around each cell used to calculate statistics.
    let GPSANeighborhood = _prefix "GPSANeighborhood"

    /// Radius
    /// Specifies which surrounding points are used for interpolation.
    let GPSARadius = _prefix "GPSARadius"

    /// Remap
    /// A table that defines how raster cell values are reclassified.
    let GPSARemap = _prefix "GPSARemap"

    /// Semivariogram
    /// Specifies the distance and direction representing two locations used to quantify autocorrelation.
    let GPSASemiVariogram = _prefix "GPSASemiVariogram"

    /// Time configuration
    /// Specifies the time periods used for calculating solar radiation at specific locations.
    let GPSATimeConfiguration = _prefix "GPSATimeConfiguration"

    /// Topo Features
    /// Features that are input to the interpolation.
    let GPSATopoFeatures = _prefix "GPSATopoFeatures"

    /// Transformation function
    /// Transformation function type
    let GPSATransformationFunction = _prefix "GPSATransformationFunction"

    /// Vertical Factor
    /// Specifies the relationship between the vertical cost factor and the vertical, relative moving angle.
    let GPSAVerticalFactor = _prefix "GPSAVerticalFactor"

    /// Weighted Overlay Table
    /// A table with data to combine multiple rasters by applying a common measurement scale of values to each raster, weighing each according to its importance.
    let GPSAWeightedOverlayTable = _prefix "GPSAWeightedOverlayTable"

    /// Weighted Sum
    /// Specifies data for overlaying several rasters, each multiplied by their given weight and summed.
    let GPSAWeightedSum = _prefix "GPSAWeightedSum"

    /// Scene Layer
    let GPSceneServiceLayer = _prefix "GPSceneServiceLayer"

    /// Spatial Reference
    /// The coordinate system used to store a spatial dataset, including the spatial domain.
    let GPSpatialReference = _prefix "GPSpatialReference"

    /// SQL Expression
    /// A syntax for defining and manipulating data from a relational database.
    let GPSQLExpression = _prefix "GPSQLExpression"

    /// String
    /// A text value.
    let GPString = _prefix "GPString"

    /// String Hidden
    /// A string that is masked by * characters.
    let GPStringHidden = _prefix "GPStringHidden"

    /// Table View
    /// A representation of tabular data for viewing and editing purposes, stored in memory or on disk.
    let GPTableView = _prefix "GPTableView"

    /// Terrain Layer
    /// A reference to a terrain, including symbology and rendering properties. It’s used to draw a terrain.
    let GPTerrainLayer = _prefix "GPTerrainLayer"

    /// Time Unit
    /// Time unit
    let GPTimeUnit = _prefix "GPTimeUnit"

    /// TIN Layer
    /// A reference to a TIN, including topological relationships, symbology, and rendering properties.
    let GPTinLayer = _prefix "GPTinLayer"

    /// Topology Layer
    /// A reference to a topology, including symbology and rendering properties.
    let GPTopologyLayer = _prefix "GPTopologyLayer"

    /// Trace Network Layer
    /// Trace network layer
    let GPTraceNetworkLayer = _prefix "GPTraceNetworkLayer"

    /// Trajectory Layer
    /// Trajectory layer
    let GPTrajectoryLayer = _prefix "GPTrajectoryLayer"

    /// Any Value
    /// A data type that accepts any value.
    let GPType = _prefix "GPType"

    /// Utility Network Layer
    let GPUtilityNetworkLayer = _prefix "GPUtilityNetworkLayer"

    /// Variant
    /// A data value that can contain any basic type: Boolean, date, double, long, and string.
    let GPVariant = _prefix "GPVariant"

    /// Vector Tile Layer
    let GPVectorLayer = _prefix "GPVectorLayer"
    /// Voxel Layer
    let GPVoxelLayer = _prefix "GPVoxelLayer"

    /// XY Domain
    /// A range of lowest and highest possible values for x,y-coordinates.
    let GPXYDomain = _prefix "GPXYDomain"

    /// Z Domain
    /// A range of lowest and highest possible values for z-coordinates.
    let GPZDomain = _prefix "GPZDomain"

    /// Index
    /// A data structure used to speed the search for records in geographic datasets and databases.
    let Index = _prefix "Index"

    /// Network Analyst Class FieldMap
    /// Mapping between location properties in a Network Analyst layer (such as stops, facilities, and incidents) and a point feature class.
    let NAClassFieldMap = _prefix "NAClassFieldMap"

    /// Network Travel Mode
    let NetworkTravelMode = _prefix "NetworkTravelMode"

    let Feature = _prefix "Feature"
