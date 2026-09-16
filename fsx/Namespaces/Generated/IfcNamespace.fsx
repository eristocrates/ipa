#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ifc =
    let _prefixId = PrefixId.fromNamespaceLabel "https://w3id.org/ifc/IFC4_ADD1#" "ifc"
    let ABSORBEDDOSEUNIT = _prefixId.prefix "ABSORBEDDOSEUNIT"
    let ACCELERATIONUNIT = _prefixId.prefix "ACCELERATIONUNIT"
    let ACCESS = _prefixId.prefix "ACCESS"
    let ACCESSORY_ASSEMBLY = _prefixId.prefix "ACCESSORY_ASSEMBLY"
    let ACTIVE = _prefixId.prefix "ACTIVE"
    let ACTOR = _prefixId.prefix "ACTOR"
    let ACTUAL = _prefixId.prefix "ACTUAL"
    let ADD = _prefixId.prefix "ADD"
    let ADDED = _prefixId.prefix "ADDED"
    let ADIABATICAIRWASHER = _prefixId.prefix "ADIABATICAIRWASHER"
    let ADIABATICATOMIZING = _prefixId.prefix "ADIABATICATOMIZING"
    let ADIABATICCOMPRESSEDAIRNOZZLE = _prefixId.prefix "ADIABATICCOMPRESSEDAIRNOZZLE"
    let ADIABATICPAN = _prefixId.prefix "ADIABATICPAN"
    let ADIABATICRIGIDMEDIA = _prefixId.prefix "ADIABATICRIGIDMEDIA"
    let ADIABATICULTRASONIC = _prefixId.prefix "ADIABATICULTRASONIC"
    let ADIABATICWETTEDELEMENT = _prefixId.prefix "ADIABATICWETTEDELEMENT"
    let ADMINISTRATION = _prefixId.prefix "ADMINISTRATION"
    let ADVICE_CAUTION = _prefixId.prefix "ADVICE_CAUTION"
    let ADVICE_NOTE = _prefixId.prefix "ADVICE_NOTE"
    let ADVICE_WARNING = _prefixId.prefix "ADVICE_WARNING"
    let ADVISORY = _prefixId.prefix "ADVISORY"
    let AGGREGATES = _prefixId.prefix "AGGREGATES"
    let AIRCONDITIONING = _prefixId.prefix "AIRCONDITIONING"
    let AIRCONDITIONINGUNIT = _prefixId.prefix "AIRCONDITIONINGUNIT"
    let AIRCOOLED = _prefixId.prefix "AIRCOOLED"
    let AIRHANDLER = _prefixId.prefix "AIRHANDLER"
    let AIRPARTICLEFILTER = _prefixId.prefix "AIRPARTICLEFILTER"
    let AIRRELEASE = _prefixId.prefix "AIRRELEASE"
    let AIRSTATION = _prefixId.prefix "AIRSTATION"
    let ALARMPANEL = _prefixId.prefix "ALARMPANEL"
    let ALUMINIUM = _prefixId.prefix "ALUMINIUM"
    let ALUMINIUM_PLASTIC = _prefixId.prefix "ALUMINIUM_PLASTIC"
    let ALUMINIUM_WOOD = _prefixId.prefix "ALUMINIUM_WOOD"
    let AMMETER = _prefixId.prefix "AMMETER"
    let AMOUNTOFSUBSTANCEUNIT = _prefixId.prefix "AMOUNTOFSUBSTANCEUNIT"
    let AMPERE = _prefixId.prefix "AMPERE"
    let AMPLIFIER = _prefixId.prefix "AMPLIFIER"
    let ANCHORBOLT = _prefixId.prefix "ANCHORBOLT"
    let ANCHORING = _prefixId.prefix "ANCHORING"
    let ANCHORPLATE = _prefixId.prefix "ANCHORPLATE"
    let ANGULARVELOCITYUNIT = _prefixId.prefix "ANGULARVELOCITYUNIT"
    let ANTENNA = _prefixId.prefix "ANTENNA"
    let ANTIVACUUM = _prefixId.prefix "ANTIVACUUM"
    let ARCH = _prefixId.prefix "ARCH"
    let ARCHITECT = _prefixId.prefix "ARCHITECT"
    let AREA = _prefixId.prefix "AREA"
    let AREADENSITYUNIT = _prefixId.prefix "AREADENSITYUNIT"
    let AREAUNIT = _prefixId.prefix "AREAUNIT"
    let ASSEMBLY = _prefixId.prefix "ASSEMBLY"
    let ASSETINVENTORY = _prefixId.prefix "ASSETINVENTORY"
    let ASSIGNEE = _prefixId.prefix "ASSIGNEE"
    let ASSIGNOR = _prefixId.prefix "ASSIGNOR"
    let ASSISTEDBUTANE = _prefixId.prefix "ASSISTEDBUTANE"
    let ASSISTEDELECTRIC = _prefixId.prefix "ASSISTEDELECTRIC"
    let ASSISTEDNATURALGAS = _prefixId.prefix "ASSISTEDNATURALGAS"
    let ASSISTEDPROPANE = _prefixId.prefix "ASSISTEDPROPANE"
    let ASSISTEDSTEAM = _prefixId.prefix "ASSISTEDSTEAM"
    let ATEND = _prefixId.prefix "ATEND"
    let ATPATH = _prefixId.prefix "ATPATH"
    let ATSTART = _prefixId.prefix "ATSTART"
    let ATTENDANCE = _prefixId.prefix "ATTENDANCE"
    let ATTO = _prefixId.prefix "ATTO"
    let AUDIOVISUAL = _prefixId.prefix "AUDIOVISUAL"
    let AUDIOVISUALOUTLET = _prefixId.prefix "AUDIOVISUALOUTLET"
    let AWNING = _prefixId.prefix "AWNING"
    let AXIS1 = _prefixId.prefix "AXIS1"
    let AXIS2 = _prefixId.prefix "AXIS2"
    let AXIS3 = _prefixId.prefix "AXIS3"
    let BACKDRAFTDAMPER = _prefixId.prefix "BACKDRAFTDAMPER"
    let BALANCINGDAMPER = _prefixId.prefix "BALANCINGDAMPER"
    let BALUSTRADE = _prefixId.prefix "BALUSTRADE"
    let BAR = _prefixId.prefix "BAR"
    let BARREL_ROOF = _prefixId.prefix "BARREL_ROOF"
    let BASELINE = _prefixId.prefix "BASELINE"
    let BASESLAB = _prefixId.prefix "BASESLAB"
    let BASIN = _prefixId.prefix "BASIN"
    let BATH = _prefixId.prefix "BATH"
    let BATTERY = _prefixId.prefix "BATTERY"
    let BEAM = _prefixId.prefix "BEAM"
    let BEAM_GRID = _prefixId.prefix "BEAM_GRID"
    let BECQUEREL = _prefixId.prefix "BECQUEREL"
    let BED = _prefixId.prefix "BED"
    let BELL = _prefixId.prefix "BELL"
    let BELTDRIVE = _prefixId.prefix "BELTDRIVE"
    let BEND = _prefixId.prefix "BEND"
    let BENDING_ELEMENT = _prefixId.prefix "BENDING_ELEMENT"
    let BIDET = _prefixId.prefix "BIDET"
    let BILINEAR = _prefixId.prefix "BILINEAR"
    let BIRDCAGE = _prefixId.prefix "BIRDCAGE"
    let BLASTDAMPER = _prefixId.prefix "BLASTDAMPER"
    let BLINN = _prefixId.prefix "BLINN"
    let BOLT = _prefixId.prefix "BOLT"
    let BOOSTER = _prefixId.prefix "BOOSTER"
    let BORED = _prefixId.prefix "BORED"
    let BOTH = _prefixId.prefix "BOTH"
    let BOTTOM = _prefixId.prefix "BOTTOM"
    let BOTTOMHUNG = _prefixId.prefix "BOTTOMHUNG"
    let BRACE = _prefixId.prefix "BRACE"
    let BRACED_FRAME = _prefixId.prefix "BRACED_FRAME"
    let BRACKET = _prefixId.prefix "BRACKET"
    let BRAKES = _prefixId.prefix "BRAKES"
    let BREAKGLASSBUTTON = _prefixId.prefix "BREAKGLASSBUTTON"
    let BREAKPRESSURE = _prefixId.prefix "BREAKPRESSURE"
    let BREECHINGINLET = _prefixId.prefix "BREECHINGINLET"
    let BUDGET = _prefixId.prefix "BUDGET"
    let BUILDING = _prefixId.prefix "BUILDING"
    let BUILDINGOPERATOR = _prefixId.prefix "BUILDINGOPERATOR"
    let BUILDINGOWNER = _prefixId.prefix "BUILDINGOWNER"
    let BUOYANCY = _prefixId.prefix "BUOYANCY"
    let BUSBARSEGMENT = _prefixId.prefix "BUSBARSEGMENT"
    let BUTTERFLY_ROOF = _prefixId.prefix "BUTTERFLY_ROOF"
    let BY_DAY_COUNT = _prefixId.prefix "BY_DAY_COUNT"
    let BY_WEEKDAY_COUNT = _prefixId.prefix "BY_WEEKDAY_COUNT"
    let CABLE = _prefixId.prefix "CABLE"
    let CABLECARRIER = _prefixId.prefix "CABLECARRIER"
    let CABLELADDERSEGMENT = _prefixId.prefix "CABLELADDERSEGMENT"
    let CABLESEGMENT = _prefixId.prefix "CABLESEGMENT"
    let CABLETRAYSEGMENT = _prefixId.prefix "CABLETRAYSEGMENT"
    let CABLETRUNKINGSEGMENT = _prefixId.prefix "CABLETRUNKINGSEGMENT"
    let CAISSON_FOUNDATION = _prefixId.prefix "CAISSON_FOUNDATION"
    let CALIBRATION = _prefixId.prefix "CALIBRATION"
    let CAMERA = _prefixId.prefix "CAMERA"
    let CANDELA = _prefixId.prefix "CANDELA"
    let CAPACITORBANK = _prefixId.prefix "CAPACITORBANK"
    let CARPENTRY = _prefixId.prefix "CARPENTRY"
    let CARTESIAN = _prefixId.prefix "CARTESIAN"
    let CAST_IN_PLACE = _prefixId.prefix "CAST_IN_PLACE"
    let CEILING = _prefixId.prefix "CEILING"
    let CENTI = _prefixId.prefix "CENTI"
    let CENTRIFUGALAIRFOIL = _prefixId.prefix "CENTRIFUGALAIRFOIL"

    let CENTRIFUGALBACKWARDINCLINEDCURVED = _prefixId.prefix "CENTRIFUGALBACKWARDINCLINEDCURVED"

    let CENTRIFUGALFORWARDCURVED = _prefixId.prefix "CENTRIFUGALFORWARDCURVED"
    let CENTRIFUGALRADIAL = _prefixId.prefix "CENTRIFUGALRADIAL"
    let CHAIR = _prefixId.prefix "CHAIR"
    let CHAMFER = _prefixId.prefix "CHAMFER"
    let CHANGEORDER = _prefixId.prefix "CHANGEORDER"
    let CHANGEOVER = _prefixId.prefix "CHANGEOVER"
    let CHECK = _prefixId.prefix "CHECK"
    let CHEMICAL = _prefixId.prefix "CHEMICAL"
    let CHILLEDWATER = _prefixId.prefix "CHILLEDWATER"
    let CHORD = _prefixId.prefix "CHORD"
    let CHP = _prefixId.prefix "CHP"
    let CIRCUITBREAKER = _prefixId.prefix "CIRCUITBREAKER"
    let CIRCULAR_ARC = _prefixId.prefix "CIRCULAR_ARC"
    let CIRCULATOR = _prefixId.prefix "CIRCULATOR"
    let CISTERN = _prefixId.prefix "CISTERN"
    let CIVILENGINEER = _prefixId.prefix "CIVILENGINEER"
    let CLADDING = _prefixId.prefix "CLADDING"
    let CLEANING = _prefixId.prefix "CLEANING"
    let CLIENT = _prefixId.prefix "CLIENT"
    let CO2SENSOR = _prefixId.prefix "CO2SENSOR"
    let COATED = _prefixId.prefix "COATED"
    let CODECOMPLIANCE = _prefixId.prefix "CODECOMPLIANCE"
    let CODEWAIVER = _prefixId.prefix "CODEWAIVER"
    let COHESION = _prefixId.prefix "COHESION"
    let COLLAR = _prefixId.prefix "COLLAR"
    let COLUMN = _prefixId.prefix "COLUMN"
    let COMMISSIONING = _prefixId.prefix "COMMISSIONING"
    let COMMISSIONINGENGINEER = _prefixId.prefix "COMMISSIONINGENGINEER"
    let COMMUNICATION = _prefixId.prefix "COMMUNICATION"
    let COMMUNICATIONSOUTLET = _prefixId.prefix "COMMUNICATIONSOUTLET"
    let COMPACTFLUORESCENT = _prefixId.prefix "COMPACTFLUORESCENT"
    let COMPLETION_G1 = _prefixId.prefix "COMPLETION_G1"
    let COMPLEX = _prefixId.prefix "COMPLEX"
    let COMPOSITE = _prefixId.prefix "COMPOSITE"
    let COMPOUNDPLANEANGLEUNIT = _prefixId.prefix "COMPOUNDPLANEANGLEUNIT"
    let COMPRESSEDAIR = _prefixId.prefix "COMPRESSEDAIR"
    let COMPRESSEDAIRFILTER = _prefixId.prefix "COMPRESSEDAIRFILTER"
    let COMPRESSION = _prefixId.prefix "COMPRESSION"
    let COMPRESSION_MEMBER = _prefixId.prefix "COMPRESSION_MEMBER"
    let COMPUTER = _prefixId.prefix "COMPUTER"
    let CONCRETE = _prefixId.prefix "CONCRETE"
    let CONDENSERWATER = _prefixId.prefix "CONDENSERWATER"
    let CONDUCTANCESENSOR = _prefixId.prefix "CONDUCTANCESENSOR"
    let CONDUCTORSEGMENT = _prefixId.prefix "CONDUCTORSEGMENT"
    let CONDUITSEGMENT = _prefixId.prefix "CONDUITSEGMENT"
    let CONFIDENTIAL = _prefixId.prefix "CONFIDENTIAL"
    let CONICAL_SURF = _prefixId.prefix "CONICAL_SURF"
    let CONNECTOR = _prefixId.prefix "CONNECTOR"
    let CONST = _prefixId.prefix "CONST"
    let CONSTANTFLOW = _prefixId.prefix "CONSTANTFLOW"
    let CONSTRUCTION = _prefixId.prefix "CONSTRUCTION"
    let CONSTRUCTIONMANAGER = _prefixId.prefix "CONSTRUCTIONMANAGER"
    let CONSULTANT = _prefixId.prefix "CONSULTANT"
    let CONSUMERUNIT = _prefixId.prefix "CONSUMERUNIT"
    let CONTACTOR = _prefixId.prefix "CONTACTOR"
    let CONTACTSENSOR = _prefixId.prefix "CONTACTSENSOR"
    let CONTINUOUS = _prefixId.prefix "CONTINUOUS"
    let CONTRACTOR = _prefixId.prefix "CONTRACTOR"
    let CONTROL = _prefixId.prefix "CONTROL"
    let CONTROLDAMPER = _prefixId.prefix "CONTROLDAMPER"
    let CONTROLPANEL = _prefixId.prefix "CONTROLPANEL"
    let CONTSAMEGRADIENT = _prefixId.prefix "CONTSAMEGRADIENT"
    let CONTSAMEGRADIENTSAMECURVATURE = _prefixId.prefix "CONTSAMEGRADIENTSAMECURVATURE"
    let CONVECTOR = _prefixId.prefix "CONVECTOR"
    let CONVEYING = _prefixId.prefix "CONVEYING"
    let CORESEGMENT = _prefixId.prefix "CORESEGMENT"
    let COSTENGINEER = _prefixId.prefix "COSTENGINEER"
    let COSTPLAN = _prefixId.prefix "COSTPLAN"
    let COULOMB = _prefixId.prefix "COULOMB"
    let COUPLER = _prefixId.prefix "COUPLER"
    let COUPLING = _prefixId.prefix "COUPLING"
    let COWL = _prefixId.prefix "COWL"
    let CRANEWAY = _prefixId.prefix "CRANEWAY"
    let CREEP = _prefixId.prefix "CREEP"
    let CROSS = _prefixId.prefix "CROSS"
    let CUBIC_METRE = _prefixId.prefix "CUBIC_METRE"
    let CULVERT = _prefixId.prefix "CULVERT"
    let CURRENT = _prefixId.prefix "CURRENT"
    let CURTAIN_PANEL = _prefixId.prefix "CURTAIN_PANEL"
    let CURVATUREUNIT = _prefixId.prefix "CURVATUREUNIT"
    let CURVE = _prefixId.prefix "CURVE"
    let CURVED = _prefixId.prefix "CURVED"
    let CURVED_RUN_STAIR = _prefixId.prefix "CURVED_RUN_STAIR"
    let CUTOUT = _prefixId.prefix "CUTOUT"
    let CYCLONIC = _prefixId.prefix "CYCLONIC"
    let CYLINDRICAL_SURF = _prefixId.prefix "CYLINDRICAL_SURF"
    let DAILY = _prefixId.prefix "DAILY"
    let DATA = _prefixId.prefix "DATA"
    let DATAOUTLET = _prefixId.prefix "DATAOUTLET"
    let DC = _prefixId.prefix "DC"
    let DEAD_LOAD_G = _prefixId.prefix "DEAD_LOAD_G"
    let DECA = _prefixId.prefix "DECA"
    let DECI = _prefixId.prefix "DECI"
    let DEGREE_CELSIUS = _prefixId.prefix "DEGREE_CELSIUS"
    let DEHUMIDIFIER = _prefixId.prefix "DEHUMIDIFIER"
    let DELETED = _prefixId.prefix "DELETED"
    let DEMOLISHING = _prefixId.prefix "DEMOLISHING"
    let DEMOLITION = _prefixId.prefix "DEMOLITION"
    let DESIGNINTENT = _prefixId.prefix "DESIGNINTENT"
    let DESK = _prefixId.prefix "DESK"
    let DIAGNOSTIC = _prefixId.prefix "DIAGNOSTIC"
    let DIFFERENCE = _prefixId.prefix "DIFFERENCE"
    let DIFFUSER = _prefixId.prefix "DIFFUSER"
    let DIMMERSWITCH = _prefixId.prefix "DIMMERSWITCH"
    let DIRECTDRIVE = _prefixId.prefix "DIRECTDRIVE"
    let DIRECTEVAPORATIVEAIRWASHER = _prefixId.prefix "DIRECTEVAPORATIVEAIRWASHER"

    let DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER = _prefixId.prefix "DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER"

    let DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER = _prefixId.prefix "DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER"

    let DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER = _prefixId.prefix "DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER"

    let DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER = _prefixId.prefix "DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER"

    let DIRECTEXPANSION = _prefixId.prefix "DIRECTEXPANSION"
    let DIRECTEXPANSIONBRAZEDPLATE = _prefixId.prefix "DIRECTEXPANSIONBRAZEDPLATE"
    let DIRECTEXPANSIONSHELLANDTUBE = _prefixId.prefix "DIRECTEXPANSIONSHELLANDTUBE"
    let DIRECTEXPANSIONTUBEINTUBE = _prefixId.prefix "DIRECTEXPANSIONTUBEINTUBE"
    let DIRECTIONSOURCE = _prefixId.prefix "DIRECTIONSOURCE"
    let DISCONTINUOUS = _prefixId.prefix "DISCONTINUOUS"
    let DISCRETE = _prefixId.prefix "DISCRETE"
    let DISCRETEBINARY = _prefixId.prefix "DISCRETEBINARY"
    let DISHWASHER = _prefixId.prefix "DISHWASHER"
    let DISMANTLE = _prefixId.prefix "DISMANTLE"
    let DISPLAY = _prefixId.prefix "DISPLAY"
    let DISPOSAL = _prefixId.prefix "DISPOSAL"
    let DISTRIBUTIONBOARD = _prefixId.prefix "DISTRIBUTIONBOARD"
    let DISTRIBUTIONPOINT = _prefixId.prefix "DISTRIBUTIONPOINT"
    let DIVERTING = _prefixId.prefix "DIVERTING"
    let DIVIDE = _prefixId.prefix "DIVIDE"
    let DOMESTICCOLDWATER = _prefixId.prefix "DOMESTICCOLDWATER"
    let DOMESTICHOTWATER = _prefixId.prefix "DOMESTICHOTWATER"
    let DOME_ROOF = _prefixId.prefix "DOME_ROOF"
    let DOOR = _prefixId.prefix "DOOR"
    let DOSEEQUIVALENTUNIT = _prefixId.prefix "DOSEEQUIVALENTUNIT"
    let DOUBLECHECK = _prefixId.prefix "DOUBLECHECK"
    let DOUBLEREGULATING = _prefixId.prefix "DOUBLEREGULATING"
    let DOUBLE_ACTING = _prefixId.prefix "DOUBLE_ACTING"
    let DOUBLE_DOOR_DOUBLE_SWING = _prefixId.prefix "DOUBLE_DOOR_DOUBLE_SWING"
    let DOUBLE_DOOR_FOLDING = _prefixId.prefix "DOUBLE_DOOR_FOLDING"
    let DOUBLE_DOOR_SINGLE_SWING = _prefixId.prefix "DOUBLE_DOOR_SINGLE_SWING"

    let DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT = _prefixId.prefix "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT"

    let DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT = _prefixId.prefix "DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT"

    let DOUBLE_DOOR_SLIDING = _prefixId.prefix "DOUBLE_DOOR_SLIDING"
    let DOUBLE_PANEL_HORIZONTAL = _prefixId.prefix "DOUBLE_PANEL_HORIZONTAL"
    let DOUBLE_PANEL_VERTICAL = _prefixId.prefix "DOUBLE_PANEL_VERTICAL"
    let DOUBLE_RETURN_STAIR = _prefixId.prefix "DOUBLE_RETURN_STAIR"
    let DOUBLE_SWING_LEFT = _prefixId.prefix "DOUBLE_SWING_LEFT"
    let DOUBLE_SWING_RIGHT = _prefixId.prefix "DOUBLE_SWING_RIGHT"
    let DOWEL = _prefixId.prefix "DOWEL"
    let DOWN = _prefixId.prefix "DOWN"
    let DRAFT = _prefixId.prefix "DRAFT"
    let DRAINAGE = _prefixId.prefix "DRAINAGE"
    let DRAWOFFCOCK = _prefixId.prefix "DRAWOFFCOCK"
    let DRIVEN = _prefixId.prefix "DRIVEN"
    let DRYWALL = _prefixId.prefix "DRYWALL"
    let DUCT = _prefixId.prefix "DUCT"
    let DXCOOLINGCOIL = _prefixId.prefix "DXCOOLINGCOIL"
    let DYNAMIC = _prefixId.prefix "DYNAMIC"
    let DYNAMICVISCOSITYUNIT = _prefixId.prefix "DYNAMICVISCOSITYUNIT"
    let EARTHING = _prefixId.prefix "EARTHING"
    let EARTHINGSWITCH = _prefixId.prefix "EARTHINGSWITCH"
    let EARTHLEAKAGECIRCUITBREAKER = _prefixId.prefix "EARTHLEAKAGECIRCUITBREAKER"
    let EARTHMOVING = _prefixId.prefix "EARTHMOVING"
    let EARTHQUAKE_E = _prefixId.prefix "EARTHQUAKE_E"
    let EDGE = _prefixId.prefix "EDGE"
    let ELAPSEDTIME = _prefixId.prefix "ELAPSEDTIME"
    let ELECTRIC = _prefixId.prefix "ELECTRIC"
    let ELECTRICACTUATOR = _prefixId.prefix "ELECTRICACTUATOR"
    let ELECTRICAL = _prefixId.prefix "ELECTRICAL"
    let ELECTRICALENGINEER = _prefixId.prefix "ELECTRICALENGINEER"
    let ELECTRICCAPACITANCEUNIT = _prefixId.prefix "ELECTRICCAPACITANCEUNIT"
    let ELECTRICCHARGEUNIT = _prefixId.prefix "ELECTRICCHARGEUNIT"
    let ELECTRICCONDUCTANCEUNIT = _prefixId.prefix "ELECTRICCONDUCTANCEUNIT"
    let ELECTRICCOOKER = _prefixId.prefix "ELECTRICCOOKER"
    let ELECTRICCURRENTUNIT = _prefixId.prefix "ELECTRICCURRENTUNIT"
    let ELECTRICHEATINGCOIL = _prefixId.prefix "ELECTRICHEATINGCOIL"
    let ELECTRICRESISTANCEUNIT = _prefixId.prefix "ELECTRICRESISTANCEUNIT"
    let ELECTRICVOLTAGEUNIT = _prefixId.prefix "ELECTRICVOLTAGEUNIT"
    let ELECTROACOUSTIC = _prefixId.prefix "ELECTROACOUSTIC"
    let ELECTROMAGNETIC = _prefixId.prefix "ELECTROMAGNETIC"
    let ELECTRONIC = _prefixId.prefix "ELECTRONIC"
    let ELEMENT = _prefixId.prefix "ELEMENT"
    let ELEMENTEDWALL = _prefixId.prefix "ELEMENTEDWALL"
    let ELEVATION_VIEW = _prefixId.prefix "ELEVATION_VIEW"
    let ELEVATOR = _prefixId.prefix "ELEVATOR"
    let ELLIPTIC_ARC = _prefixId.prefix "ELLIPTIC_ARC"
    let EMAIL = _prefixId.prefix "EMAIL"
    let EMERGENCYSTOP = _prefixId.prefix "EMERGENCYSTOP"
    let ENDEVENT = _prefixId.prefix "ENDEVENT"
    let ENDSUCTION = _prefixId.prefix "ENDSUCTION"
    let ENERGYMETER = _prefixId.prefix "ENERGYMETER"
    let ENERGYUNIT = _prefixId.prefix "ENERGYUNIT"
    let ENGINEER = _prefixId.prefix "ENGINEER"
    let ENGINEGENERATOR = _prefixId.prefix "ENGINEGENERATOR"
    let ENTRY = _prefixId.prefix "ENTRY"
    let EQUALTO = _prefixId.prefix "EQUALTO"
    let EQUIDISTANT = _prefixId.prefix "EQUIDISTANT"
    let ERECTING = _prefixId.prefix "ERECTING"
    let ERECTION = _prefixId.prefix "ERECTION"
    let ESCALATOR = _prefixId.prefix "ESCALATOR"
    let ESTIMATE = _prefixId.prefix "ESTIMATE"
    let EVAPORATIVECOOLED = _prefixId.prefix "EVAPORATIVECOOLED"
    let EVENTCOMPLEX = _prefixId.prefix "EVENTCOMPLEX"
    let EVENTMESSAGE = _prefixId.prefix "EVENTMESSAGE"
    let EVENTRULE = _prefixId.prefix "EVENTRULE"
    let EVENTTIME = _prefixId.prefix "EVENTTIME"
    let EXA = _prefixId.prefix "EXA"
    let EXHAUST = _prefixId.prefix "EXHAUST"
    let EXIT = _prefixId.prefix "EXIT"
    let EXPANSION = _prefixId.prefix "EXPANSION"
    let EXTERNAL = _prefixId.prefix "EXTERNAL"
    let EXTERNALCOMBUSTION = _prefixId.prefix "EXTERNALCOMBUSTION"
    let EXTERNAL_EARTH = _prefixId.prefix "EXTERNAL_EARTH"
    let EXTERNAL_FIRE = _prefixId.prefix "EXTERNAL_FIRE"
    let EXTERNAL_WATER = _prefixId.prefix "EXTERNAL_WATER"
    let EXTRAORDINARY_A = _prefixId.prefix "EXTRAORDINARY_A"
    let FACILITIESMANAGER = _prefixId.prefix "FACILITIESMANAGER"
    let FACTORY = _prefixId.prefix "FACTORY"
    let FARAD = _prefixId.prefix "FARAD"
    let FAUCET = _prefixId.prefix "FAUCET"
    let FAX = _prefixId.prefix "FAX"
    let FEEDAIRUNIT = _prefixId.prefix "FEEDAIRUNIT"
    let FEEDANDEXPANSION = _prefixId.prefix "FEEDANDEXPANSION"
    let FEMTO = _prefixId.prefix "FEMTO"
    let FENESTRATION = _prefixId.prefix "FENESTRATION"
    let FIELDCONSTRUCTIONMANAGER = _prefixId.prefix "FIELDCONSTRUCTIONMANAGER"
    let FILECABINET = _prefixId.prefix "FILECABINET"
    let FINAL = _prefixId.prefix "FINAL"
    let FINALDRAFT = _prefixId.prefix "FINALDRAFT"
    let FINISHING = _prefixId.prefix "FINISHING"
    let FINISH_FINISH = _prefixId.prefix "FINISH_FINISH"
    let FINISH_START = _prefixId.prefix "FINISH_START"
    let FINNED = _prefixId.prefix "FINNED"
    let FIRE = _prefixId.prefix "FIRE"
    let FIREDAMPER = _prefixId.prefix "FIREDAMPER"
    let FIREHYDRANT = _prefixId.prefix "FIREHYDRANT"
    let FIREPROTECTION = _prefixId.prefix "FIREPROTECTION"
    let FIRESAFETY = _prefixId.prefix "FIRESAFETY"
    let FIRESENSOR = _prefixId.prefix "FIRESENSOR"
    let FIRESMOKEDAMPER = _prefixId.prefix "FIRESMOKEDAMPER"
    let FIRSTSHIFT = _prefixId.prefix "FIRSTSHIFT"
    let FIRST_ORDER_THEORY = _prefixId.prefix "FIRST_ORDER_THEORY"
    let FIXEDCASEMENT = _prefixId.prefix "FIXEDCASEMENT"
    let FIXEDPANEL = _prefixId.prefix "FIXEDPANEL"

    let FIXEDPLATECOUNTERFLOWEXCHANGER = _prefixId.prefix "FIXEDPLATECOUNTERFLOWEXCHANGER"

    let FIXEDPLATECROSSFLOWEXCHANGER = _prefixId.prefix "FIXEDPLATECROSSFLOWEXCHANGER"

    let FIXEDPLATEPARALLELFLOWEXCHANGER = _prefixId.prefix "FIXEDPLATEPARALLELFLOWEXCHANGER"

    let FIXED_END = _prefixId.prefix "FIXED_END"
    let FLAT = _prefixId.prefix "FLAT"
    let FLATOVAL = _prefixId.prefix "FLATOVAL"
    let FLAT_ROOF = _prefixId.prefix "FLAT_ROOF"
    let FLEXIBLESEGMENT = _prefixId.prefix "FLEXIBLESEGMENT"
    let FLOATING = _prefixId.prefix "FLOATING"
    let FLOODEDSHELLANDTUBE = _prefixId.prefix "FLOODEDSHELLANDTUBE"
    let FLOOR = _prefixId.prefix "FLOOR"
    let FLOORING = _prefixId.prefix "FLOORING"
    let FLOORTRAP = _prefixId.prefix "FLOORTRAP"
    let FLOORWASTE = _prefixId.prefix "FLOORWASTE"
    let FLOWSENSOR = _prefixId.prefix "FLOWSENSOR"
    let FLUORESCENT = _prefixId.prefix "FLUORESCENT"
    let FLUSHING = _prefixId.prefix "FLUSHING"
    let FOLDING = _prefixId.prefix "FOLDING"
    let FOLDING_TO_LEFT = _prefixId.prefix "FOLDING_TO_LEFT"
    let FOLDING_TO_RIGHT = _prefixId.prefix "FOLDING_TO_RIGHT"
    let FOOTING_BEAM = _prefixId.prefix "FOOTING_BEAM"
    let FORCEUNIT = _prefixId.prefix "FORCEUNIT"
    let FORMEDDUCT = _prefixId.prefix "FORMEDDUCT"
    let FORMWORK = _prefixId.prefix "FORMWORK"
    let FOUNDATION = _prefixId.prefix "FOUNDATION"
    let FREEFORM = _prefixId.prefix "FREEFORM"
    let FREESTANDINGELECTRICHEATER = _prefixId.prefix "FREESTANDINGELECTRICHEATER"
    let FREESTANDINGFAN = _prefixId.prefix "FREESTANDINGFAN"
    let FREESTANDINGWATERCOOLER = _prefixId.prefix "FREESTANDINGWATERCOOLER"
    let FREESTANDINGWATERHEATER = _prefixId.prefix "FREESTANDINGWATERHEATER"
    let FREEZER = _prefixId.prefix "FREEZER"
    let FREQUENCY = _prefixId.prefix "FREQUENCY"
    let FREQUENCYMETER = _prefixId.prefix "FREQUENCYMETER"
    let FREQUENCYUNIT = _prefixId.prefix "FREQUENCYUNIT"
    let FRICTION = _prefixId.prefix "FRICTION"
    let FRIDGE_FREEZER = _prefixId.prefix "FRIDGE_FREEZER"
    let FROSTSENSOR = _prefixId.prefix "FROSTSENSOR"
    let FUEL = _prefixId.prefix "FUEL"
    let FULL_NONLINEAR_THEORY = _prefixId.prefix "FULL_NONLINEAR_THEORY"
    let FUMEHOODEXHAUST = _prefixId.prefix "FUMEHOODEXHAUST"
    let FURNITUREINVENTORY = _prefixId.prefix "FURNITUREINVENTORY"
    let FUSEDISCONNECTOR = _prefixId.prefix "FUSEDISCONNECTOR"
    let GABLE_ROOF = _prefixId.prefix "GABLE_ROOF"
    let GAMBREL_ROOF = _prefixId.prefix "GAMBREL_ROOF"
    let GAS = _prefixId.prefix "GAS"
    let GASCOCK = _prefixId.prefix "GASCOCK"
    let GASDETECTIONPANEL = _prefixId.prefix "GASDETECTIONPANEL"
    let GASHEATINGCOIL = _prefixId.prefix "GASHEATINGCOIL"
    let GASMETER = _prefixId.prefix "GASMETER"
    let GASSENSOR = _prefixId.prefix "GASSENSOR"
    let GASTAP = _prefixId.prefix "GASTAP"
    let GATE = _prefixId.prefix "GATE"
    let GATEWAY = _prefixId.prefix "GATEWAY"
    let GENERAL = _prefixId.prefix "GENERAL"
    let GENERALISED_CONE = _prefixId.prefix "GENERALISED_CONE"
    let GFA = _prefixId.prefix "GFA"
    let GIGA = _prefixId.prefix "GIGA"
    let GIRDER = _prefixId.prefix "GIRDER"
    let GLASS = _prefixId.prefix "GLASS"
    let GLOBAL_COORDS = _prefixId.prefix "GLOBAL_COORDS"
    let GLUE = _prefixId.prefix "GLUE"
    let GRAM = _prefixId.prefix "GRAM"
    let GRAPH_VIEW = _prefixId.prefix "GRAPH_VIEW"
    let GRAVITYDAMPER = _prefixId.prefix "GRAVITYDAMPER"
    let GRAVITYRELIEFDAMPER = _prefixId.prefix "GRAVITYRELIEFDAMPER"
    let GRAY = _prefixId.prefix "GRAY"
    let GREASE = _prefixId.prefix "GREASE"
    let GREATERTHAN = _prefixId.prefix "GREATERTHAN"
    let GREATERTHANOREQUALTO = _prefixId.prefix "GREATERTHANOREQUALTO"
    let GRILL = _prefixId.prefix "GRILL"
    let GRILLE = _prefixId.prefix "GRILLE"
    let GROUP = _prefixId.prefix "GROUP"
    let GUARDRAIL = _prefixId.prefix "GUARDRAIL"
    let GULLYSUMP = _prefixId.prefix "GULLYSUMP"
    let GULLYTRAP = _prefixId.prefix "GULLYTRAP"
    let GUTTER = _prefixId.prefix "GUTTER"
    let GYPSUM = _prefixId.prefix "GYPSUM"
    let HALF_TURN_RAMP = _prefixId.prefix "HALF_TURN_RAMP"
    let HALF_TURN_STAIR = _prefixId.prefix "HALF_TURN_STAIR"
    let HALF_WINDING_STAIR = _prefixId.prefix "HALF_WINDING_STAIR"
    let HALOGEN = _prefixId.prefix "HALOGEN"
    let HANDDRYER = _prefixId.prefix "HANDDRYER"
    let HANDOPERATEDACTUATOR = _prefixId.prefix "HANDOPERATEDACTUATOR"
    let HANDRAIL = _prefixId.prefix "HANDRAIL"
    let HARD = _prefixId.prefix "HARD"
    let HARMONICFILTER = _prefixId.prefix "HARMONICFILTER"
    let HAZARDOUS = _prefixId.prefix "HAZARDOUS"
    let HEALTHANDSAFETY = _prefixId.prefix "HEALTHANDSAFETY"
    let HEATFLUXDENSITYUNIT = _prefixId.prefix "HEATFLUXDENSITYUNIT"
    let HEATING = _prefixId.prefix "HEATING"
    let HEATINGVALUEUNIT = _prefixId.prefix "HEATINGVALUEUNIT"
    let HEATPIPE = _prefixId.prefix "HEATPIPE"
    let HEATRECOVERY = _prefixId.prefix "HEATRECOVERY"
    let HEATSENSOR = _prefixId.prefix "HEATSENSOR"
    let HECTO = _prefixId.prefix "HECTO"
    let HENRY = _prefixId.prefix "HENRY"
    let HERMETIC = _prefixId.prefix "HERMETIC"
    let HERTZ = _prefixId.prefix "HERTZ"
    let HIGHPRESSUREMERCURY = _prefixId.prefix "HIGHPRESSUREMERCURY"
    let HIGHPRESSURESODIUM = _prefixId.prefix "HIGHPRESSURESODIUM"
    let HIGH_GRADE_STEEL = _prefixId.prefix "HIGH_GRADE_STEEL"
    let HIPPED_GABLE_ROOF = _prefixId.prefix "HIPPED_GABLE_ROOF"
    let HIP_ROOF = _prefixId.prefix "HIP_ROOF"
    let HOLE = _prefixId.prefix "HOLE"
    let HOLLOWCORE = _prefixId.prefix "HOLLOWCORE"
    let HOME = _prefixId.prefix "HOME"
    let HOSEREEL = _prefixId.prefix "HOSEREEL"
    let HUMIDISTAT = _prefixId.prefix "HUMIDISTAT"
    let HUMIDITYSENSOR = _prefixId.prefix "HUMIDITYSENSOR"
    let HVAC = _prefixId.prefix "HVAC"
    let HYDRAULICACTUATOR = _prefixId.prefix "HYDRAULICACTUATOR"
    let HYDRONICCOIL = _prefixId.prefix "HYDRONICCOIL"
    let HYPERBOLIC_ARC = _prefixId.prefix "HYPERBOLIC_ARC"
    let ICE = _prefixId.prefix "ICE"
    let IDENTIFIERSENSOR = _prefixId.prefix "IDENTIFIERSENSOR"
    let ILLUMINANCEUNIT = _prefixId.prefix "ILLUMINANCEUNIT"
    let IMPACT = _prefixId.prefix "IMPACT"
    let IMPULSE = _prefixId.prefix "IMPULSE"
    let INCLUDEDIN = _prefixId.prefix "INCLUDEDIN"
    let INCLUDES = _prefixId.prefix "INCLUDES"
    let INDICATORPANEL = _prefixId.prefix "INDICATORPANEL"
    let INDIRECTDIRECTCOMBINATION = _prefixId.prefix "INDIRECTDIRECTCOMBINATION"

    let INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER = _prefixId.prefix "INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER"

    let INDIRECTEVAPORATIVEPACKAGEAIRCOOLER = _prefixId.prefix "INDIRECTEVAPORATIVEPACKAGEAIRCOOLER"

    let INDIRECTEVAPORATIVEWETCOIL = _prefixId.prefix "INDIRECTEVAPORATIVEWETCOIL"
    let INDUCTANCEUNIT = _prefixId.prefix "INDUCTANCEUNIT"
    let INDUCTION = _prefixId.prefix "INDUCTION"
    let INDUCTORBANK = _prefixId.prefix "INDUCTORBANK"
    let INSPECTIONCHAMBER = _prefixId.prefix "INSPECTIONCHAMBER"
    let INSPECTIONPIT = _prefixId.prefix "INSPECTIONPIT"
    let INSTALLATION = _prefixId.prefix "INSTALLATION"
    let INSULATION = _prefixId.prefix "INSULATION"
    let INTEGERCOUNTRATEUNIT = _prefixId.prefix "INTEGERCOUNTRATEUNIT"
    let INTERMEDIATEEVENT = _prefixId.prefix "INTERMEDIATEEVENT"
    let INTERNAL = _prefixId.prefix "INTERNAL"
    let INTERNALCOMBUSTION = _prefixId.prefix "INTERNALCOMBUSTION"
    let INTERSECTION = _prefixId.prefix "INTERSECTION"
    let INVERTER = _prefixId.prefix "INVERTER"
    let IN_PLANE_LOADING_2D = _prefixId.prefix "IN_PLANE_LOADING_2D"
    let IONCONCENTRATIONSENSOR = _prefixId.prefix "IONCONCENTRATIONSENSOR"
    let IONCONCENTRATIONUNIT = _prefixId.prefix "IONCONCENTRATIONUNIT"
    let IRREGULAR = _prefixId.prefix "IRREGULAR"
    let ISOCONTOUR = _prefixId.prefix "ISOCONTOUR"
    let ISOLATING = _prefixId.prefix "ISOLATING"

    let ISOTHERMALMOISTURECAPACITYUNIT = _prefixId.prefix "ISOTHERMALMOISTURECAPACITYUNIT"

    let IfcAbsorbedDoseMeasure = _prefixId.prefix "IfcAbsorbedDoseMeasure"
    let IfcAccelerationMeasure = _prefixId.prefix "IfcAccelerationMeasure"
    let IfcActionRequest = _prefixId.prefix "IfcActionRequest"
    let IfcActionRequestTypeEnum = _prefixId.prefix "IfcActionRequestTypeEnum"
    let IfcActionSourceTypeEnum = _prefixId.prefix "IfcActionSourceTypeEnum"
    let IfcActionTypeEnum = _prefixId.prefix "IfcActionTypeEnum"
    let IfcActor = _prefixId.prefix "IfcActor"
    let IfcActorRole = _prefixId.prefix "IfcActorRole"
    let IfcActorRole_EmptyList = _prefixId.prefix "IfcActorRole_EmptyList"
    let IfcActorRole_List = _prefixId.prefix "IfcActorRole_List"
    let IfcActorSelect = _prefixId.prefix "IfcActorSelect"
    let IfcActuator = _prefixId.prefix "IfcActuator"
    let IfcActuatorType = _prefixId.prefix "IfcActuatorType"
    let IfcActuatorTypeEnum = _prefixId.prefix "IfcActuatorTypeEnum"
    let IfcAddress = _prefixId.prefix "IfcAddress"
    let IfcAddressTypeEnum = _prefixId.prefix "IfcAddressTypeEnum"
    let IfcAddress_EmptyList = _prefixId.prefix "IfcAddress_EmptyList"
    let IfcAddress_List = _prefixId.prefix "IfcAddress_List"
    let IfcAdvancedBrep = _prefixId.prefix "IfcAdvancedBrep"
    let IfcAdvancedBrepWithVoids = _prefixId.prefix "IfcAdvancedBrepWithVoids"
    let IfcAdvancedFace = _prefixId.prefix "IfcAdvancedFace"
    let IfcAirTerminal = _prefixId.prefix "IfcAirTerminal"
    let IfcAirTerminalBox = _prefixId.prefix "IfcAirTerminalBox"
    let IfcAirTerminalBoxType = _prefixId.prefix "IfcAirTerminalBoxType"
    let IfcAirTerminalBoxTypeEnum = _prefixId.prefix "IfcAirTerminalBoxTypeEnum"
    let IfcAirTerminalType = _prefixId.prefix "IfcAirTerminalType"
    let IfcAirTerminalTypeEnum = _prefixId.prefix "IfcAirTerminalTypeEnum"
    let IfcAirToAirHeatRecovery = _prefixId.prefix "IfcAirToAirHeatRecovery"
    let IfcAirToAirHeatRecoveryType = _prefixId.prefix "IfcAirToAirHeatRecoveryType"

    let IfcAirToAirHeatRecoveryTypeEnum = _prefixId.prefix "IfcAirToAirHeatRecoveryTypeEnum"

    let IfcAlarm = _prefixId.prefix "IfcAlarm"
    let IfcAlarmType = _prefixId.prefix "IfcAlarmType"
    let IfcAlarmTypeEnum = _prefixId.prefix "IfcAlarmTypeEnum"
    let IfcAmountOfSubstanceMeasure = _prefixId.prefix "IfcAmountOfSubstanceMeasure"
    let IfcAnalysisModelTypeEnum = _prefixId.prefix "IfcAnalysisModelTypeEnum"
    let IfcAnalysisTheoryTypeEnum = _prefixId.prefix "IfcAnalysisTheoryTypeEnum"
    let IfcAngularVelocityMeasure = _prefixId.prefix "IfcAngularVelocityMeasure"
    let IfcAnnotation = _prefixId.prefix "IfcAnnotation"
    let IfcAnnotationFillArea = _prefixId.prefix "IfcAnnotationFillArea"
    let IfcApplication = _prefixId.prefix "IfcApplication"
    let IfcAppliedValue = _prefixId.prefix "IfcAppliedValue"
    let IfcAppliedValueSelect = _prefixId.prefix "IfcAppliedValueSelect"
    let IfcAppliedValue_EmptyList = _prefixId.prefix "IfcAppliedValue_EmptyList"
    let IfcAppliedValue_List = _prefixId.prefix "IfcAppliedValue_List"
    let IfcApproval = _prefixId.prefix "IfcApproval"
    let IfcApprovalRelationship = _prefixId.prefix "IfcApprovalRelationship"
    let IfcArbitraryClosedProfileDef = _prefixId.prefix "IfcArbitraryClosedProfileDef"
    let IfcArbitraryOpenProfileDef = _prefixId.prefix "IfcArbitraryOpenProfileDef"

    let IfcArbitraryProfileDefWithVoids = _prefixId.prefix "IfcArbitraryProfileDefWithVoids"

    let IfcArcIndex = _prefixId.prefix "IfcArcIndex"
    let IfcAreaDensityMeasure = _prefixId.prefix "IfcAreaDensityMeasure"
    let IfcAreaMeasure = _prefixId.prefix "IfcAreaMeasure"
    let IfcArithmeticOperatorEnum = _prefixId.prefix "IfcArithmeticOperatorEnum"
    let IfcAssemblyPlaceEnum = _prefixId.prefix "IfcAssemblyPlaceEnum"
    let IfcAsset = _prefixId.prefix "IfcAsset"
    let IfcAsymmetricIShapeProfileDef = _prefixId.prefix "IfcAsymmetricIShapeProfileDef"
    let IfcAudioVisualAppliance = _prefixId.prefix "IfcAudioVisualAppliance"
    let IfcAudioVisualApplianceType = _prefixId.prefix "IfcAudioVisualApplianceType"

    let IfcAudioVisualApplianceTypeEnum = _prefixId.prefix "IfcAudioVisualApplianceTypeEnum"

    let IfcAxis1Placement = _prefixId.prefix "IfcAxis1Placement"
    let IfcAxis2Placement = _prefixId.prefix "IfcAxis2Placement"
    let IfcAxis2Placement2D = _prefixId.prefix "IfcAxis2Placement2D"
    let IfcAxis2Placement3D = _prefixId.prefix "IfcAxis2Placement3D"
    let IfcAxis2Placement3D_EmptyList = _prefixId.prefix "IfcAxis2Placement3D_EmptyList"
    let IfcAxis2Placement3D_List = _prefixId.prefix "IfcAxis2Placement3D_List"
    let IfcBSplineCurve = _prefixId.prefix "IfcBSplineCurve"
    let IfcBSplineCurveForm = _prefixId.prefix "IfcBSplineCurveForm"
    let IfcBSplineCurveWithKnots = _prefixId.prefix "IfcBSplineCurveWithKnots"
    let IfcBSplineSurface = _prefixId.prefix "IfcBSplineSurface"
    let IfcBSplineSurfaceForm = _prefixId.prefix "IfcBSplineSurfaceForm"
    let IfcBSplineSurfaceWithKnots = _prefixId.prefix "IfcBSplineSurfaceWithKnots"
    let IfcBeam = _prefixId.prefix "IfcBeam"
    let IfcBeamStandardCase = _prefixId.prefix "IfcBeamStandardCase"
    let IfcBeamType = _prefixId.prefix "IfcBeamType"
    let IfcBeamTypeEnum = _prefixId.prefix "IfcBeamTypeEnum"
    let IfcBenchmarkEnum = _prefixId.prefix "IfcBenchmarkEnum"
    let IfcBendingParameterSelect = _prefixId.prefix "IfcBendingParameterSelect"

    let IfcBendingParameterSelect_EmptyList = _prefixId.prefix "IfcBendingParameterSelect_EmptyList"

    let IfcBendingParameterSelect_List = _prefixId.prefix "IfcBendingParameterSelect_List"

    let IfcBinary = _prefixId.prefix "IfcBinary"
    let IfcBinary_EmptyList = _prefixId.prefix "IfcBinary_EmptyList"
    let IfcBinary_List = _prefixId.prefix "IfcBinary_List"
    let IfcBlobTexture = _prefixId.prefix "IfcBlobTexture"
    let IfcBlock = _prefixId.prefix "IfcBlock"
    let IfcBoiler = _prefixId.prefix "IfcBoiler"
    let IfcBoilerType = _prefixId.prefix "IfcBoilerType"
    let IfcBoilerTypeEnum = _prefixId.prefix "IfcBoilerTypeEnum"
    let IfcBoolean = _prefixId.prefix "IfcBoolean"
    let IfcBooleanClippingResult = _prefixId.prefix "IfcBooleanClippingResult"
    let IfcBooleanOperand = _prefixId.prefix "IfcBooleanOperand"
    let IfcBooleanOperator = _prefixId.prefix "IfcBooleanOperator"
    let IfcBooleanResult = _prefixId.prefix "IfcBooleanResult"
    let IfcBoundaryCondition = _prefixId.prefix "IfcBoundaryCondition"
    let IfcBoundaryCurve = _prefixId.prefix "IfcBoundaryCurve"
    let IfcBoundaryEdgeCondition = _prefixId.prefix "IfcBoundaryEdgeCondition"
    let IfcBoundaryFaceCondition = _prefixId.prefix "IfcBoundaryFaceCondition"
    let IfcBoundaryNodeCondition = _prefixId.prefix "IfcBoundaryNodeCondition"

    let IfcBoundaryNodeConditionWarping = _prefixId.prefix "IfcBoundaryNodeConditionWarping"

    let IfcBoundedCurve = _prefixId.prefix "IfcBoundedCurve"
    let IfcBoundedSurface = _prefixId.prefix "IfcBoundedSurface"
    let IfcBoundingBox = _prefixId.prefix "IfcBoundingBox"
    let IfcBoxAlignment = _prefixId.prefix "IfcBoxAlignment"
    let IfcBoxedHalfSpace = _prefixId.prefix "IfcBoxedHalfSpace"
    let IfcBuilding = _prefixId.prefix "IfcBuilding"
    let IfcBuildingElement = _prefixId.prefix "IfcBuildingElement"
    let IfcBuildingElementPart = _prefixId.prefix "IfcBuildingElementPart"
    let IfcBuildingElementPartType = _prefixId.prefix "IfcBuildingElementPartType"

    let IfcBuildingElementPartTypeEnum = _prefixId.prefix "IfcBuildingElementPartTypeEnum"

    let IfcBuildingElementProxy = _prefixId.prefix "IfcBuildingElementProxy"
    let IfcBuildingElementProxyType = _prefixId.prefix "IfcBuildingElementProxyType"

    let IfcBuildingElementProxyTypeEnum = _prefixId.prefix "IfcBuildingElementProxyTypeEnum"

    let IfcBuildingElementType = _prefixId.prefix "IfcBuildingElementType"
    let IfcBuildingStorey = _prefixId.prefix "IfcBuildingStorey"
    let IfcBuildingSystem = _prefixId.prefix "IfcBuildingSystem"
    let IfcBuildingSystemTypeEnum = _prefixId.prefix "IfcBuildingSystemTypeEnum"
    let IfcBurner = _prefixId.prefix "IfcBurner"
    let IfcBurnerType = _prefixId.prefix "IfcBurnerType"
    let IfcBurnerTypeEnum = _prefixId.prefix "IfcBurnerTypeEnum"
    let IfcCShapeProfileDef = _prefixId.prefix "IfcCShapeProfileDef"
    let IfcCableCarrierFitting = _prefixId.prefix "IfcCableCarrierFitting"
    let IfcCableCarrierFittingType = _prefixId.prefix "IfcCableCarrierFittingType"

    let IfcCableCarrierFittingTypeEnum = _prefixId.prefix "IfcCableCarrierFittingTypeEnum"

    let IfcCableCarrierSegment = _prefixId.prefix "IfcCableCarrierSegment"
    let IfcCableCarrierSegmentType = _prefixId.prefix "IfcCableCarrierSegmentType"

    let IfcCableCarrierSegmentTypeEnum = _prefixId.prefix "IfcCableCarrierSegmentTypeEnum"

    let IfcCableFitting = _prefixId.prefix "IfcCableFitting"
    let IfcCableFittingType = _prefixId.prefix "IfcCableFittingType"
    let IfcCableFittingTypeEnum = _prefixId.prefix "IfcCableFittingTypeEnum"
    let IfcCableSegment = _prefixId.prefix "IfcCableSegment"
    let IfcCableSegmentType = _prefixId.prefix "IfcCableSegmentType"
    let IfcCableSegmentTypeEnum = _prefixId.prefix "IfcCableSegmentTypeEnum"
    let IfcCardinalPointReference = _prefixId.prefix "IfcCardinalPointReference"
    let IfcCartesianPoint = _prefixId.prefix "IfcCartesianPoint"
    let IfcCartesianPointList = _prefixId.prefix "IfcCartesianPointList"
    let IfcCartesianPointList2D = _prefixId.prefix "IfcCartesianPointList2D"
    let IfcCartesianPointList3D = _prefixId.prefix "IfcCartesianPointList3D"
    let IfcCartesianPoint_EmptyList = _prefixId.prefix "IfcCartesianPoint_EmptyList"
    let IfcCartesianPoint_List = _prefixId.prefix "IfcCartesianPoint_List"

    let IfcCartesianPoint_List_EmptyList = _prefixId.prefix "IfcCartesianPoint_List_EmptyList"

    let IfcCartesianPoint_List_List = _prefixId.prefix "IfcCartesianPoint_List_List"

    let IfcCartesianTransformationOperator = _prefixId.prefix "IfcCartesianTransformationOperator"

    let IfcCartesianTransformationOperator2D = _prefixId.prefix "IfcCartesianTransformationOperator2D"

    let IfcCartesianTransformationOperator2DnonUniform = _prefixId.prefix "IfcCartesianTransformationOperator2DnonUniform"

    let IfcCartesianTransformationOperator3D = _prefixId.prefix "IfcCartesianTransformationOperator3D"

    let IfcCartesianTransformationOperator3DnonUniform = _prefixId.prefix "IfcCartesianTransformationOperator3DnonUniform"

    let IfcCenterLineProfileDef = _prefixId.prefix "IfcCenterLineProfileDef"
    let IfcChangeActionEnum = _prefixId.prefix "IfcChangeActionEnum"
    let IfcChiller = _prefixId.prefix "IfcChiller"
    let IfcChillerType = _prefixId.prefix "IfcChillerType"
    let IfcChillerTypeEnum = _prefixId.prefix "IfcChillerTypeEnum"
    let IfcChimney = _prefixId.prefix "IfcChimney"
    let IfcChimneyType = _prefixId.prefix "IfcChimneyType"
    let IfcChimneyTypeEnum = _prefixId.prefix "IfcChimneyTypeEnum"
    let IfcCircle = _prefixId.prefix "IfcCircle"
    let IfcCircleHollowProfileDef = _prefixId.prefix "IfcCircleHollowProfileDef"
    let IfcCircleProfileDef = _prefixId.prefix "IfcCircleProfileDef"
    let IfcCivilElement = _prefixId.prefix "IfcCivilElement"
    let IfcCivilElementType = _prefixId.prefix "IfcCivilElementType"
    let IfcClassification = _prefixId.prefix "IfcClassification"
    let IfcClassificationReference = _prefixId.prefix "IfcClassificationReference"

    let IfcClassificationReferenceSelect = _prefixId.prefix "IfcClassificationReferenceSelect"

    let IfcClassificationSelect = _prefixId.prefix "IfcClassificationSelect"
    let IfcClosedShell = _prefixId.prefix "IfcClosedShell"
    let IfcCoil = _prefixId.prefix "IfcCoil"
    let IfcCoilType = _prefixId.prefix "IfcCoilType"
    let IfcCoilTypeEnum = _prefixId.prefix "IfcCoilTypeEnum"
    let IfcColour = _prefixId.prefix "IfcColour"
    let IfcColourOrFactor = _prefixId.prefix "IfcColourOrFactor"
    let IfcColourRgb = _prefixId.prefix "IfcColourRgb"
    let IfcColourRgbList = _prefixId.prefix "IfcColourRgbList"
    let IfcColourSpecification = _prefixId.prefix "IfcColourSpecification"
    let IfcColumn = _prefixId.prefix "IfcColumn"
    let IfcColumnStandardCase = _prefixId.prefix "IfcColumnStandardCase"
    let IfcColumnType = _prefixId.prefix "IfcColumnType"
    let IfcColumnTypeEnum = _prefixId.prefix "IfcColumnTypeEnum"
    let IfcCommunicationsAppliance = _prefixId.prefix "IfcCommunicationsAppliance"

    let IfcCommunicationsApplianceType = _prefixId.prefix "IfcCommunicationsApplianceType"

    let IfcCommunicationsApplianceTypeEnum = _prefixId.prefix "IfcCommunicationsApplianceTypeEnum"

    let IfcComplexNumber = _prefixId.prefix "IfcComplexNumber"
    let IfcComplexProperty = _prefixId.prefix "IfcComplexProperty"
    let IfcComplexPropertyTemplate = _prefixId.prefix "IfcComplexPropertyTemplate"

    let IfcComplexPropertyTemplateTypeEnum = _prefixId.prefix "IfcComplexPropertyTemplateTypeEnum"

    let IfcCompositeCurve = _prefixId.prefix "IfcCompositeCurve"
    let IfcCompositeCurveOnSurface = _prefixId.prefix "IfcCompositeCurveOnSurface"
    let IfcCompositeCurveSegment = _prefixId.prefix "IfcCompositeCurveSegment"

    let IfcCompositeCurveSegment_EmptyList = _prefixId.prefix "IfcCompositeCurveSegment_EmptyList"

    let IfcCompositeCurveSegment_List = _prefixId.prefix "IfcCompositeCurveSegment_List"
    let IfcCompositeProfileDef = _prefixId.prefix "IfcCompositeProfileDef"
    let IfcCompoundPlaneAngleMeasure = _prefixId.prefix "IfcCompoundPlaneAngleMeasure"
    let IfcCompressor = _prefixId.prefix "IfcCompressor"
    let IfcCompressorType = _prefixId.prefix "IfcCompressorType"
    let IfcCompressorTypeEnum = _prefixId.prefix "IfcCompressorTypeEnum"
    let IfcCondenser = _prefixId.prefix "IfcCondenser"
    let IfcCondenserType = _prefixId.prefix "IfcCondenserType"
    let IfcCondenserTypeEnum = _prefixId.prefix "IfcCondenserTypeEnum"
    let IfcConic = _prefixId.prefix "IfcConic"
    let IfcConnectedFaceSet = _prefixId.prefix "IfcConnectedFaceSet"
    let IfcConnectionCurveGeometry = _prefixId.prefix "IfcConnectionCurveGeometry"
    let IfcConnectionGeometry = _prefixId.prefix "IfcConnectionGeometry"

    let IfcConnectionPointEccentricity = _prefixId.prefix "IfcConnectionPointEccentricity"

    let IfcConnectionPointGeometry = _prefixId.prefix "IfcConnectionPointGeometry"
    let IfcConnectionSurfaceGeometry = _prefixId.prefix "IfcConnectionSurfaceGeometry"
    let IfcConnectionTypeEnum = _prefixId.prefix "IfcConnectionTypeEnum"
    let IfcConnectionVolumeGeometry = _prefixId.prefix "IfcConnectionVolumeGeometry"
    let IfcConstraint = _prefixId.prefix "IfcConstraint"
    let IfcConstraintEnum = _prefixId.prefix "IfcConstraintEnum"
    let IfcConstraint_EmptyList = _prefixId.prefix "IfcConstraint_EmptyList"
    let IfcConstraint_List = _prefixId.prefix "IfcConstraint_List"

    let IfcConstructionEquipmentResource = _prefixId.prefix "IfcConstructionEquipmentResource"

    let IfcConstructionEquipmentResourceType = _prefixId.prefix "IfcConstructionEquipmentResourceType"

    let IfcConstructionEquipmentResourceTypeEnum = _prefixId.prefix "IfcConstructionEquipmentResourceTypeEnum"

    let IfcConstructionMaterialResource = _prefixId.prefix "IfcConstructionMaterialResource"

    let IfcConstructionMaterialResourceType = _prefixId.prefix "IfcConstructionMaterialResourceType"

    let IfcConstructionMaterialResourceTypeEnum = _prefixId.prefix "IfcConstructionMaterialResourceTypeEnum"

    let IfcConstructionProductResource = _prefixId.prefix "IfcConstructionProductResource"

    let IfcConstructionProductResourceType = _prefixId.prefix "IfcConstructionProductResourceType"

    let IfcConstructionProductResourceTypeEnum = _prefixId.prefix "IfcConstructionProductResourceTypeEnum"

    let IfcConstructionResource = _prefixId.prefix "IfcConstructionResource"
    let IfcConstructionResourceType = _prefixId.prefix "IfcConstructionResourceType"
    let IfcContext = _prefixId.prefix "IfcContext"
    let IfcContextDependentMeasure = _prefixId.prefix "IfcContextDependentMeasure"
    let IfcContextDependentUnit = _prefixId.prefix "IfcContextDependentUnit"
    let IfcControl = _prefixId.prefix "IfcControl"
    let IfcController = _prefixId.prefix "IfcController"
    let IfcControllerType = _prefixId.prefix "IfcControllerType"
    let IfcControllerTypeEnum = _prefixId.prefix "IfcControllerTypeEnum"
    let IfcConversionBasedUnit = _prefixId.prefix "IfcConversionBasedUnit"

    let IfcConversionBasedUnitWithOffset = _prefixId.prefix "IfcConversionBasedUnitWithOffset"

    let IfcCooledBeam = _prefixId.prefix "IfcCooledBeam"
    let IfcCooledBeamType = _prefixId.prefix "IfcCooledBeamType"
    let IfcCooledBeamTypeEnum = _prefixId.prefix "IfcCooledBeamTypeEnum"
    let IfcCoolingTower = _prefixId.prefix "IfcCoolingTower"
    let IfcCoolingTowerType = _prefixId.prefix "IfcCoolingTowerType"
    let IfcCoolingTowerTypeEnum = _prefixId.prefix "IfcCoolingTowerTypeEnum"
    let IfcCoordinateOperation = _prefixId.prefix "IfcCoordinateOperation"
    let IfcCoordinateReferenceSystem = _prefixId.prefix "IfcCoordinateReferenceSystem"

    let IfcCoordinateReferenceSystemSelect = _prefixId.prefix "IfcCoordinateReferenceSystemSelect"

    let IfcCostItem = _prefixId.prefix "IfcCostItem"
    let IfcCostItemTypeEnum = _prefixId.prefix "IfcCostItemTypeEnum"
    let IfcCostSchedule = _prefixId.prefix "IfcCostSchedule"
    let IfcCostScheduleTypeEnum = _prefixId.prefix "IfcCostScheduleTypeEnum"
    let IfcCostValue = _prefixId.prefix "IfcCostValue"
    let IfcCostValue_EmptyList = _prefixId.prefix "IfcCostValue_EmptyList"
    let IfcCostValue_List = _prefixId.prefix "IfcCostValue_List"
    let IfcCountMeasure = _prefixId.prefix "IfcCountMeasure"
    let IfcCovering = _prefixId.prefix "IfcCovering"
    let IfcCoveringType = _prefixId.prefix "IfcCoveringType"
    let IfcCoveringTypeEnum = _prefixId.prefix "IfcCoveringTypeEnum"
    let IfcCrewResource = _prefixId.prefix "IfcCrewResource"
    let IfcCrewResourceType = _prefixId.prefix "IfcCrewResourceType"
    let IfcCrewResourceTypeEnum = _prefixId.prefix "IfcCrewResourceTypeEnum"
    let IfcCsgPrimitive3D = _prefixId.prefix "IfcCsgPrimitive3D"
    let IfcCsgSelect = _prefixId.prefix "IfcCsgSelect"
    let IfcCsgSolid = _prefixId.prefix "IfcCsgSolid"
    let IfcCurrencyRelationship = _prefixId.prefix "IfcCurrencyRelationship"
    let IfcCurtainWall = _prefixId.prefix "IfcCurtainWall"
    let IfcCurtainWallType = _prefixId.prefix "IfcCurtainWallType"
    let IfcCurtainWallTypeEnum = _prefixId.prefix "IfcCurtainWallTypeEnum"
    let IfcCurvatureMeasure = _prefixId.prefix "IfcCurvatureMeasure"
    let IfcCurve = _prefixId.prefix "IfcCurve"
    let IfcCurveBoundedPlane = _prefixId.prefix "IfcCurveBoundedPlane"
    let IfcCurveBoundedSurface = _prefixId.prefix "IfcCurveBoundedSurface"

    let IfcCurveFontOrScaledCurveFontSelect = _prefixId.prefix "IfcCurveFontOrScaledCurveFontSelect"

    let IfcCurveInterpolationEnum = _prefixId.prefix "IfcCurveInterpolationEnum"
    let IfcCurveOnSurface = _prefixId.prefix "IfcCurveOnSurface"
    let IfcCurveOrEdgeCurve = _prefixId.prefix "IfcCurveOrEdgeCurve"
    let IfcCurveStyle = _prefixId.prefix "IfcCurveStyle"
    let IfcCurveStyleFont = _prefixId.prefix "IfcCurveStyleFont"
    let IfcCurveStyleFontAndScaling = _prefixId.prefix "IfcCurveStyleFontAndScaling"
    let IfcCurveStyleFontPattern = _prefixId.prefix "IfcCurveStyleFontPattern"

    let IfcCurveStyleFontPattern_EmptyList = _prefixId.prefix "IfcCurveStyleFontPattern_EmptyList"

    let IfcCurveStyleFontPattern_List = _prefixId.prefix "IfcCurveStyleFontPattern_List"
    let IfcCurveStyleFontSelect = _prefixId.prefix "IfcCurveStyleFontSelect"
    let IfcCylindricalSurface = _prefixId.prefix "IfcCylindricalSurface"
    let IfcDamper = _prefixId.prefix "IfcDamper"
    let IfcDamperType = _prefixId.prefix "IfcDamperType"
    let IfcDamperTypeEnum = _prefixId.prefix "IfcDamperTypeEnum"
    let IfcDataOriginEnum = _prefixId.prefix "IfcDataOriginEnum"
    let IfcDate = _prefixId.prefix "IfcDate"
    let IfcDateTime = _prefixId.prefix "IfcDateTime"
    let IfcDayInMonthNumber = _prefixId.prefix "IfcDayInMonthNumber"
    let IfcDayInWeekNumber = _prefixId.prefix "IfcDayInWeekNumber"
    let IfcDefinitionSelect = _prefixId.prefix "IfcDefinitionSelect"
    let IfcDerivedMeasureValue = _prefixId.prefix "IfcDerivedMeasureValue"
    let IfcDerivedProfileDef = _prefixId.prefix "IfcDerivedProfileDef"
    let IfcDerivedUnit = _prefixId.prefix "IfcDerivedUnit"
    let IfcDerivedUnitElement = _prefixId.prefix "IfcDerivedUnitElement"
    let IfcDerivedUnitEnum = _prefixId.prefix "IfcDerivedUnitEnum"
    let IfcDescriptiveMeasure = _prefixId.prefix "IfcDescriptiveMeasure"
    let IfcDimensionCount = _prefixId.prefix "IfcDimensionCount"
    let IfcDimensionalExponents = _prefixId.prefix "IfcDimensionalExponents"
    let IfcDirection = _prefixId.prefix "IfcDirection"
    let IfcDirectionSenseEnum = _prefixId.prefix "IfcDirectionSenseEnum"
    let IfcDiscreteAccessory = _prefixId.prefix "IfcDiscreteAccessory"
    let IfcDiscreteAccessoryType = _prefixId.prefix "IfcDiscreteAccessoryType"
    let IfcDiscreteAccessoryTypeEnum = _prefixId.prefix "IfcDiscreteAccessoryTypeEnum"
    let IfcDistributionChamberElement = _prefixId.prefix "IfcDistributionChamberElement"

    let IfcDistributionChamberElementType = _prefixId.prefix "IfcDistributionChamberElementType"

    let IfcDistributionChamberElementTypeEnum = _prefixId.prefix "IfcDistributionChamberElementTypeEnum"

    let IfcDistributionCircuit = _prefixId.prefix "IfcDistributionCircuit"
    let IfcDistributionControlElement = _prefixId.prefix "IfcDistributionControlElement"

    let IfcDistributionControlElementType = _prefixId.prefix "IfcDistributionControlElementType"

    let IfcDistributionElement = _prefixId.prefix "IfcDistributionElement"
    let IfcDistributionElementType = _prefixId.prefix "IfcDistributionElementType"
    let IfcDistributionFlowElement = _prefixId.prefix "IfcDistributionFlowElement"

    let IfcDistributionFlowElementType = _prefixId.prefix "IfcDistributionFlowElementType"

    let IfcDistributionPort = _prefixId.prefix "IfcDistributionPort"
    let IfcDistributionPortTypeEnum = _prefixId.prefix "IfcDistributionPortTypeEnum"
    let IfcDistributionSystem = _prefixId.prefix "IfcDistributionSystem"
    let IfcDistributionSystemEnum = _prefixId.prefix "IfcDistributionSystemEnum"

    let IfcDocumentConfidentialityEnum = _prefixId.prefix "IfcDocumentConfidentialityEnum"

    let IfcDocumentInformation = _prefixId.prefix "IfcDocumentInformation"

    let IfcDocumentInformationRelationship = _prefixId.prefix "IfcDocumentInformationRelationship"

    let IfcDocumentReference = _prefixId.prefix "IfcDocumentReference"
    let IfcDocumentSelect = _prefixId.prefix "IfcDocumentSelect"
    let IfcDocumentStatusEnum = _prefixId.prefix "IfcDocumentStatusEnum"
    let IfcDoor = _prefixId.prefix "IfcDoor"
    let IfcDoorLiningProperties = _prefixId.prefix "IfcDoorLiningProperties"
    let IfcDoorPanelOperationEnum = _prefixId.prefix "IfcDoorPanelOperationEnum"
    let IfcDoorPanelPositionEnum = _prefixId.prefix "IfcDoorPanelPositionEnum"
    let IfcDoorPanelProperties = _prefixId.prefix "IfcDoorPanelProperties"
    let IfcDoorStandardCase = _prefixId.prefix "IfcDoorStandardCase"
    let IfcDoorStyle = _prefixId.prefix "IfcDoorStyle"
    let IfcDoorStyleConstructionEnum = _prefixId.prefix "IfcDoorStyleConstructionEnum"
    let IfcDoorStyleOperationEnum = _prefixId.prefix "IfcDoorStyleOperationEnum"
    let IfcDoorType = _prefixId.prefix "IfcDoorType"
    let IfcDoorTypeEnum = _prefixId.prefix "IfcDoorTypeEnum"
    let IfcDoorTypeOperationEnum = _prefixId.prefix "IfcDoorTypeOperationEnum"
    let IfcDoseEquivalentMeasure = _prefixId.prefix "IfcDoseEquivalentMeasure"
    let IfcDraughtingPreDefinedColour = _prefixId.prefix "IfcDraughtingPreDefinedColour"

    let IfcDraughtingPreDefinedCurveFont = _prefixId.prefix "IfcDraughtingPreDefinedCurveFont"

    let IfcDuctFitting = _prefixId.prefix "IfcDuctFitting"
    let IfcDuctFittingType = _prefixId.prefix "IfcDuctFittingType"
    let IfcDuctFittingTypeEnum = _prefixId.prefix "IfcDuctFittingTypeEnum"
    let IfcDuctSegment = _prefixId.prefix "IfcDuctSegment"
    let IfcDuctSegmentType = _prefixId.prefix "IfcDuctSegmentType"
    let IfcDuctSegmentTypeEnum = _prefixId.prefix "IfcDuctSegmentTypeEnum"
    let IfcDuctSilencer = _prefixId.prefix "IfcDuctSilencer"
    let IfcDuctSilencerType = _prefixId.prefix "IfcDuctSilencerType"
    let IfcDuctSilencerTypeEnum = _prefixId.prefix "IfcDuctSilencerTypeEnum"
    let IfcDuration = _prefixId.prefix "IfcDuration"
    let IfcDynamicViscosityMeasure = _prefixId.prefix "IfcDynamicViscosityMeasure"
    let IfcEdge = _prefixId.prefix "IfcEdge"
    let IfcEdgeCurve = _prefixId.prefix "IfcEdgeCurve"
    let IfcEdgeLoop = _prefixId.prefix "IfcEdgeLoop"
    let IfcElectricAppliance = _prefixId.prefix "IfcElectricAppliance"
    let IfcElectricApplianceType = _prefixId.prefix "IfcElectricApplianceType"
    let IfcElectricApplianceTypeEnum = _prefixId.prefix "IfcElectricApplianceTypeEnum"
    let IfcElectricCapacitanceMeasure = _prefixId.prefix "IfcElectricCapacitanceMeasure"
    let IfcElectricChargeMeasure = _prefixId.prefix "IfcElectricChargeMeasure"
    let IfcElectricConductanceMeasure = _prefixId.prefix "IfcElectricConductanceMeasure"
    let IfcElectricCurrentMeasure = _prefixId.prefix "IfcElectricCurrentMeasure"
    let IfcElectricDistributionBoard = _prefixId.prefix "IfcElectricDistributionBoard"

    let IfcElectricDistributionBoardType = _prefixId.prefix "IfcElectricDistributionBoardType"

    let IfcElectricDistributionBoardTypeEnum = _prefixId.prefix "IfcElectricDistributionBoardTypeEnum"

    let IfcElectricFlowStorageDevice = _prefixId.prefix "IfcElectricFlowStorageDevice"

    let IfcElectricFlowStorageDeviceType = _prefixId.prefix "IfcElectricFlowStorageDeviceType"

    let IfcElectricFlowStorageDeviceTypeEnum = _prefixId.prefix "IfcElectricFlowStorageDeviceTypeEnum"

    let IfcElectricGenerator = _prefixId.prefix "IfcElectricGenerator"
    let IfcElectricGeneratorType = _prefixId.prefix "IfcElectricGeneratorType"
    let IfcElectricGeneratorTypeEnum = _prefixId.prefix "IfcElectricGeneratorTypeEnum"
    let IfcElectricMotor = _prefixId.prefix "IfcElectricMotor"
    let IfcElectricMotorType = _prefixId.prefix "IfcElectricMotorType"
    let IfcElectricMotorTypeEnum = _prefixId.prefix "IfcElectricMotorTypeEnum"
    let IfcElectricResistanceMeasure = _prefixId.prefix "IfcElectricResistanceMeasure"
    let IfcElectricTimeControl = _prefixId.prefix "IfcElectricTimeControl"
    let IfcElectricTimeControlType = _prefixId.prefix "IfcElectricTimeControlType"

    let IfcElectricTimeControlTypeEnum = _prefixId.prefix "IfcElectricTimeControlTypeEnum"

    let IfcElectricVoltageMeasure = _prefixId.prefix "IfcElectricVoltageMeasure"
    let IfcElement = _prefixId.prefix "IfcElement"
    let IfcElementAssembly = _prefixId.prefix "IfcElementAssembly"
    let IfcElementAssemblyType = _prefixId.prefix "IfcElementAssemblyType"
    let IfcElementAssemblyTypeEnum = _prefixId.prefix "IfcElementAssemblyTypeEnum"
    let IfcElementComponent = _prefixId.prefix "IfcElementComponent"
    let IfcElementComponentType = _prefixId.prefix "IfcElementComponentType"
    let IfcElementCompositionEnum = _prefixId.prefix "IfcElementCompositionEnum"
    let IfcElementQuantity = _prefixId.prefix "IfcElementQuantity"
    let IfcElementType = _prefixId.prefix "IfcElementType"
    let IfcElementarySurface = _prefixId.prefix "IfcElementarySurface"
    let IfcEllipse = _prefixId.prefix "IfcEllipse"
    let IfcEllipseProfileDef = _prefixId.prefix "IfcEllipseProfileDef"
    let IfcEnergyConversionDevice = _prefixId.prefix "IfcEnergyConversionDevice"
    let IfcEnergyConversionDeviceType = _prefixId.prefix "IfcEnergyConversionDeviceType"
    let IfcEnergyMeasure = _prefixId.prefix "IfcEnergyMeasure"
    let IfcEngine = _prefixId.prefix "IfcEngine"
    let IfcEngineType = _prefixId.prefix "IfcEngineType"
    let IfcEngineTypeEnum = _prefixId.prefix "IfcEngineTypeEnum"
    let IfcEvaporativeCooler = _prefixId.prefix "IfcEvaporativeCooler"
    let IfcEvaporativeCoolerType = _prefixId.prefix "IfcEvaporativeCoolerType"
    let IfcEvaporativeCoolerTypeEnum = _prefixId.prefix "IfcEvaporativeCoolerTypeEnum"
    let IfcEvaporator = _prefixId.prefix "IfcEvaporator"
    let IfcEvaporatorType = _prefixId.prefix "IfcEvaporatorType"
    let IfcEvaporatorTypeEnum = _prefixId.prefix "IfcEvaporatorTypeEnum"
    let IfcEvent = _prefixId.prefix "IfcEvent"
    let IfcEventTime = _prefixId.prefix "IfcEventTime"
    let IfcEventTriggerTypeEnum = _prefixId.prefix "IfcEventTriggerTypeEnum"
    let IfcEventType = _prefixId.prefix "IfcEventType"
    let IfcEventTypeEnum = _prefixId.prefix "IfcEventTypeEnum"
    let IfcExtendedProperties = _prefixId.prefix "IfcExtendedProperties"
    let IfcExternalInformation = _prefixId.prefix "IfcExternalInformation"
    let IfcExternalReference = _prefixId.prefix "IfcExternalReference"

    let IfcExternalReferenceRelationship = _prefixId.prefix "IfcExternalReferenceRelationship"

    let IfcExternalSpatialElement = _prefixId.prefix "IfcExternalSpatialElement"

    let IfcExternalSpatialElementTypeEnum = _prefixId.prefix "IfcExternalSpatialElementTypeEnum"

    let IfcExternalSpatialStructureElement = _prefixId.prefix "IfcExternalSpatialStructureElement"

    let IfcExternallyDefinedHatchStyle = _prefixId.prefix "IfcExternallyDefinedHatchStyle"

    let IfcExternallyDefinedSurfaceStyle = _prefixId.prefix "IfcExternallyDefinedSurfaceStyle"

    let IfcExternallyDefinedTextFont = _prefixId.prefix "IfcExternallyDefinedTextFont"
    let IfcExtrudedAreaSolid = _prefixId.prefix "IfcExtrudedAreaSolid"
    let IfcExtrudedAreaSolidTapered = _prefixId.prefix "IfcExtrudedAreaSolidTapered"
    let IfcFace = _prefixId.prefix "IfcFace"
    let IfcFaceBasedSurfaceModel = _prefixId.prefix "IfcFaceBasedSurfaceModel"
    let IfcFaceBound = _prefixId.prefix "IfcFaceBound"
    let IfcFaceOuterBound = _prefixId.prefix "IfcFaceOuterBound"
    let IfcFaceSurface = _prefixId.prefix "IfcFaceSurface"
    let IfcFacetedBrep = _prefixId.prefix "IfcFacetedBrep"
    let IfcFacetedBrepWithVoids = _prefixId.prefix "IfcFacetedBrepWithVoids"
    let IfcFailureConnectionCondition = _prefixId.prefix "IfcFailureConnectionCondition"
    let IfcFan = _prefixId.prefix "IfcFan"
    let IfcFanType = _prefixId.prefix "IfcFanType"
    let IfcFanTypeEnum = _prefixId.prefix "IfcFanTypeEnum"
    let IfcFastener = _prefixId.prefix "IfcFastener"
    let IfcFastenerType = _prefixId.prefix "IfcFastenerType"
    let IfcFastenerTypeEnum = _prefixId.prefix "IfcFastenerTypeEnum"
    let IfcFeatureElement = _prefixId.prefix "IfcFeatureElement"
    let IfcFeatureElementAddition = _prefixId.prefix "IfcFeatureElementAddition"
    let IfcFeatureElementSubtraction = _prefixId.prefix "IfcFeatureElementSubtraction"
    let IfcFillAreaStyle = _prefixId.prefix "IfcFillAreaStyle"
    let IfcFillAreaStyleHatching = _prefixId.prefix "IfcFillAreaStyleHatching"
    let IfcFillAreaStyleTiles = _prefixId.prefix "IfcFillAreaStyleTiles"
    let IfcFillStyleSelect = _prefixId.prefix "IfcFillStyleSelect"
    let IfcFilter = _prefixId.prefix "IfcFilter"
    let IfcFilterType = _prefixId.prefix "IfcFilterType"
    let IfcFilterTypeEnum = _prefixId.prefix "IfcFilterTypeEnum"
    let IfcFireSuppressionTerminal = _prefixId.prefix "IfcFireSuppressionTerminal"

    let IfcFireSuppressionTerminalType = _prefixId.prefix "IfcFireSuppressionTerminalType"

    let IfcFireSuppressionTerminalTypeEnum = _prefixId.prefix "IfcFireSuppressionTerminalTypeEnum"

    let IfcFixedReferenceSweptAreaSolid = _prefixId.prefix "IfcFixedReferenceSweptAreaSolid"

    let IfcFlowController = _prefixId.prefix "IfcFlowController"
    let IfcFlowControllerType = _prefixId.prefix "IfcFlowControllerType"
    let IfcFlowDirectionEnum = _prefixId.prefix "IfcFlowDirectionEnum"
    let IfcFlowFitting = _prefixId.prefix "IfcFlowFitting"
    let IfcFlowFittingType = _prefixId.prefix "IfcFlowFittingType"
    let IfcFlowInstrument = _prefixId.prefix "IfcFlowInstrument"
    let IfcFlowInstrumentType = _prefixId.prefix "IfcFlowInstrumentType"
    let IfcFlowInstrumentTypeEnum = _prefixId.prefix "IfcFlowInstrumentTypeEnum"
    let IfcFlowMeter = _prefixId.prefix "IfcFlowMeter"
    let IfcFlowMeterType = _prefixId.prefix "IfcFlowMeterType"
    let IfcFlowMeterTypeEnum = _prefixId.prefix "IfcFlowMeterTypeEnum"
    let IfcFlowMovingDevice = _prefixId.prefix "IfcFlowMovingDevice"
    let IfcFlowMovingDeviceType = _prefixId.prefix "IfcFlowMovingDeviceType"
    let IfcFlowSegment = _prefixId.prefix "IfcFlowSegment"
    let IfcFlowSegmentType = _prefixId.prefix "IfcFlowSegmentType"
    let IfcFlowStorageDevice = _prefixId.prefix "IfcFlowStorageDevice"
    let IfcFlowStorageDeviceType = _prefixId.prefix "IfcFlowStorageDeviceType"
    let IfcFlowTerminal = _prefixId.prefix "IfcFlowTerminal"
    let IfcFlowTerminalType = _prefixId.prefix "IfcFlowTerminalType"
    let IfcFlowTreatmentDevice = _prefixId.prefix "IfcFlowTreatmentDevice"
    let IfcFlowTreatmentDeviceType = _prefixId.prefix "IfcFlowTreatmentDeviceType"
    let IfcFontStyle = _prefixId.prefix "IfcFontStyle"
    let IfcFontVariant = _prefixId.prefix "IfcFontVariant"
    let IfcFontWeight = _prefixId.prefix "IfcFontWeight"
    let IfcFooting = _prefixId.prefix "IfcFooting"
    let IfcFootingType = _prefixId.prefix "IfcFootingType"
    let IfcFootingTypeEnum = _prefixId.prefix "IfcFootingTypeEnum"
    let IfcForceMeasure = _prefixId.prefix "IfcForceMeasure"
    let IfcFrequencyMeasure = _prefixId.prefix "IfcFrequencyMeasure"
    let IfcFurnishingElement = _prefixId.prefix "IfcFurnishingElement"
    let IfcFurnishingElementType = _prefixId.prefix "IfcFurnishingElementType"
    let IfcFurniture = _prefixId.prefix "IfcFurniture"
    let IfcFurnitureType = _prefixId.prefix "IfcFurnitureType"
    let IfcFurnitureTypeEnum = _prefixId.prefix "IfcFurnitureTypeEnum"
    let IfcGeographicElement = _prefixId.prefix "IfcGeographicElement"
    let IfcGeographicElementType = _prefixId.prefix "IfcGeographicElementType"
    let IfcGeographicElementTypeEnum = _prefixId.prefix "IfcGeographicElementTypeEnum"
    let IfcGeometricCurveSet = _prefixId.prefix "IfcGeometricCurveSet"
    let IfcGeometricProjectionEnum = _prefixId.prefix "IfcGeometricProjectionEnum"

    let IfcGeometricRepresentationContext = _prefixId.prefix "IfcGeometricRepresentationContext"

    let IfcGeometricRepresentationItem = _prefixId.prefix "IfcGeometricRepresentationItem"

    let IfcGeometricRepresentationSubContext = _prefixId.prefix "IfcGeometricRepresentationSubContext"

    let IfcGeometricSet = _prefixId.prefix "IfcGeometricSet"
    let IfcGeometricSetSelect = _prefixId.prefix "IfcGeometricSetSelect"
    let IfcGlobalOrLocalEnum = _prefixId.prefix "IfcGlobalOrLocalEnum"
    let IfcGloballyUniqueId = _prefixId.prefix "IfcGloballyUniqueId"
    let IfcGrid = _prefixId.prefix "IfcGrid"
    let IfcGridAxis = _prefixId.prefix "IfcGridAxis"
    let IfcGridAxis_EmptyList = _prefixId.prefix "IfcGridAxis_EmptyList"
    let IfcGridAxis_List = _prefixId.prefix "IfcGridAxis_List"
    let IfcGridPlacement = _prefixId.prefix "IfcGridPlacement"

    let IfcGridPlacementDirectionSelect = _prefixId.prefix "IfcGridPlacementDirectionSelect"

    let IfcGridTypeEnum = _prefixId.prefix "IfcGridTypeEnum"
    let IfcGroup = _prefixId.prefix "IfcGroup"
    let IfcHalfSpaceSolid = _prefixId.prefix "IfcHalfSpaceSolid"
    let IfcHatchLineDistanceSelect = _prefixId.prefix "IfcHatchLineDistanceSelect"
    let IfcHeatExchanger = _prefixId.prefix "IfcHeatExchanger"
    let IfcHeatExchangerType = _prefixId.prefix "IfcHeatExchangerType"
    let IfcHeatExchangerTypeEnum = _prefixId.prefix "IfcHeatExchangerTypeEnum"
    let IfcHeatFluxDensityMeasure = _prefixId.prefix "IfcHeatFluxDensityMeasure"
    let IfcHeatingValueMeasure = _prefixId.prefix "IfcHeatingValueMeasure"
    let IfcHumidifier = _prefixId.prefix "IfcHumidifier"
    let IfcHumidifierType = _prefixId.prefix "IfcHumidifierType"
    let IfcHumidifierTypeEnum = _prefixId.prefix "IfcHumidifierTypeEnum"
    let IfcIShapeProfileDef = _prefixId.prefix "IfcIShapeProfileDef"
    let IfcIdentifier = _prefixId.prefix "IfcIdentifier"
    let IfcIdentifier_EmptyList = _prefixId.prefix "IfcIdentifier_EmptyList"
    let IfcIdentifier_List = _prefixId.prefix "IfcIdentifier_List"
    let IfcIlluminanceMeasure = _prefixId.prefix "IfcIlluminanceMeasure"
    let IfcImageTexture = _prefixId.prefix "IfcImageTexture"
    let IfcIndexedColourMap = _prefixId.prefix "IfcIndexedColourMap"
    let IfcIndexedPolyCurve = _prefixId.prefix "IfcIndexedPolyCurve"
    let IfcIndexedTextureMap = _prefixId.prefix "IfcIndexedTextureMap"
    let IfcIndexedTriangleTextureMap = _prefixId.prefix "IfcIndexedTriangleTextureMap"
    let IfcInductanceMeasure = _prefixId.prefix "IfcInductanceMeasure"
    let IfcInteger = _prefixId.prefix "IfcInteger"
    let IfcIntegerCountRateMeasure = _prefixId.prefix "IfcIntegerCountRateMeasure"
    let IfcInteger_EmptyList = _prefixId.prefix "IfcInteger_EmptyList"
    let IfcInteger_List = _prefixId.prefix "IfcInteger_List"
    let IfcInterceptor = _prefixId.prefix "IfcInterceptor"
    let IfcInterceptorType = _prefixId.prefix "IfcInterceptorType"
    let IfcInterceptorTypeEnum = _prefixId.prefix "IfcInterceptorTypeEnum"
    let IfcInternalOrExternalEnum = _prefixId.prefix "IfcInternalOrExternalEnum"
    let IfcInventory = _prefixId.prefix "IfcInventory"
    let IfcInventoryTypeEnum = _prefixId.prefix "IfcInventoryTypeEnum"
    let IfcIonConcentrationMeasure = _prefixId.prefix "IfcIonConcentrationMeasure"
    let IfcIrregularTimeSeries = _prefixId.prefix "IfcIrregularTimeSeries"
    let IfcIrregularTimeSeriesValue = _prefixId.prefix "IfcIrregularTimeSeriesValue"

    let IfcIrregularTimeSeriesValue_EmptyList = _prefixId.prefix "IfcIrregularTimeSeriesValue_EmptyList"

    let IfcIrregularTimeSeriesValue_List = _prefixId.prefix "IfcIrregularTimeSeriesValue_List"

    let IfcIsothermalMoistureCapacityMeasure = _prefixId.prefix "IfcIsothermalMoistureCapacityMeasure"

    let IfcJunctionBox = _prefixId.prefix "IfcJunctionBox"
    let IfcJunctionBoxType = _prefixId.prefix "IfcJunctionBoxType"
    let IfcJunctionBoxTypeEnum = _prefixId.prefix "IfcJunctionBoxTypeEnum"
    let IfcKinematicViscosityMeasure = _prefixId.prefix "IfcKinematicViscosityMeasure"
    let IfcKnotType = _prefixId.prefix "IfcKnotType"
    let IfcLShapeProfileDef = _prefixId.prefix "IfcLShapeProfileDef"
    let IfcLabel = _prefixId.prefix "IfcLabel"
    let IfcLabel_EmptyList = _prefixId.prefix "IfcLabel_EmptyList"
    let IfcLabel_List = _prefixId.prefix "IfcLabel_List"
    let IfcLaborResource = _prefixId.prefix "IfcLaborResource"
    let IfcLaborResourceType = _prefixId.prefix "IfcLaborResourceType"
    let IfcLaborResourceTypeEnum = _prefixId.prefix "IfcLaborResourceTypeEnum"
    let IfcLagTime = _prefixId.prefix "IfcLagTime"
    let IfcLamp = _prefixId.prefix "IfcLamp"
    let IfcLampType = _prefixId.prefix "IfcLampType"
    let IfcLampTypeEnum = _prefixId.prefix "IfcLampTypeEnum"
    let IfcLanguageId = _prefixId.prefix "IfcLanguageId"
    let IfcLayerSetDirectionEnum = _prefixId.prefix "IfcLayerSetDirectionEnum"
    let IfcLayeredItem = _prefixId.prefix "IfcLayeredItem"
    let IfcLengthMeasure = _prefixId.prefix "IfcLengthMeasure"
    let IfcLengthMeasure_EmptyList = _prefixId.prefix "IfcLengthMeasure_EmptyList"
    let IfcLengthMeasure_List = _prefixId.prefix "IfcLengthMeasure_List"

    let IfcLengthMeasure_List_EmptyList = _prefixId.prefix "IfcLengthMeasure_List_EmptyList"

    let IfcLengthMeasure_List_List = _prefixId.prefix "IfcLengthMeasure_List_List"
    let IfcLibraryInformation = _prefixId.prefix "IfcLibraryInformation"
    let IfcLibraryReference = _prefixId.prefix "IfcLibraryReference"
    let IfcLibrarySelect = _prefixId.prefix "IfcLibrarySelect"
    let IfcLightDistributionCurveEnum = _prefixId.prefix "IfcLightDistributionCurveEnum"
    let IfcLightDistributionData = _prefixId.prefix "IfcLightDistributionData"

    let IfcLightDistributionDataSourceSelect = _prefixId.prefix "IfcLightDistributionDataSourceSelect"

    let IfcLightDistributionData_EmptyList = _prefixId.prefix "IfcLightDistributionData_EmptyList"

    let IfcLightDistributionData_List = _prefixId.prefix "IfcLightDistributionData_List"
    let IfcLightEmissionSourceEnum = _prefixId.prefix "IfcLightEmissionSourceEnum"
    let IfcLightFixture = _prefixId.prefix "IfcLightFixture"
    let IfcLightFixtureType = _prefixId.prefix "IfcLightFixtureType"
    let IfcLightFixtureTypeEnum = _prefixId.prefix "IfcLightFixtureTypeEnum"
    let IfcLightIntensityDistribution = _prefixId.prefix "IfcLightIntensityDistribution"
    let IfcLightSource = _prefixId.prefix "IfcLightSource"
    let IfcLightSourceAmbient = _prefixId.prefix "IfcLightSourceAmbient"
    let IfcLightSourceDirectional = _prefixId.prefix "IfcLightSourceDirectional"
    let IfcLightSourceGoniometric = _prefixId.prefix "IfcLightSourceGoniometric"
    let IfcLightSourcePositional = _prefixId.prefix "IfcLightSourcePositional"
    let IfcLightSourceSpot = _prefixId.prefix "IfcLightSourceSpot"
    let IfcLine = _prefixId.prefix "IfcLine"
    let IfcLineIndex = _prefixId.prefix "IfcLineIndex"
    let IfcLinearForceMeasure = _prefixId.prefix "IfcLinearForceMeasure"
    let IfcLinearMomentMeasure = _prefixId.prefix "IfcLinearMomentMeasure"
    let IfcLinearStiffnessMeasure = _prefixId.prefix "IfcLinearStiffnessMeasure"
    let IfcLinearVelocityMeasure = _prefixId.prefix "IfcLinearVelocityMeasure"
    let IfcLoadGroupTypeEnum = _prefixId.prefix "IfcLoadGroupTypeEnum"
    let IfcLocalPlacement = _prefixId.prefix "IfcLocalPlacement"
    let IfcLogical = _prefixId.prefix "IfcLogical"
    let IfcLogicalOperatorEnum = _prefixId.prefix "IfcLogicalOperatorEnum"
    let IfcLoop = _prefixId.prefix "IfcLoop"
    let IfcLuminousFluxMeasure = _prefixId.prefix "IfcLuminousFluxMeasure"

    let IfcLuminousIntensityDistributionMeasure = _prefixId.prefix "IfcLuminousIntensityDistributionMeasure"

    let IfcLuminousIntensityDistributionMeasure_EmptyList = _prefixId.prefix "IfcLuminousIntensityDistributionMeasure_EmptyList"

    let IfcLuminousIntensityDistributionMeasure_List = _prefixId.prefix "IfcLuminousIntensityDistributionMeasure_List"

    let IfcLuminousIntensityMeasure = _prefixId.prefix "IfcLuminousIntensityMeasure"
    let IfcMagneticFluxDensityMeasure = _prefixId.prefix "IfcMagneticFluxDensityMeasure"
    let IfcMagneticFluxMeasure = _prefixId.prefix "IfcMagneticFluxMeasure"
    let IfcManifoldSolidBrep = _prefixId.prefix "IfcManifoldSolidBrep"
    let IfcMapConversion = _prefixId.prefix "IfcMapConversion"
    let IfcMappedItem = _prefixId.prefix "IfcMappedItem"
    let IfcMassDensityMeasure = _prefixId.prefix "IfcMassDensityMeasure"
    let IfcMassFlowRateMeasure = _prefixId.prefix "IfcMassFlowRateMeasure"
    let IfcMassMeasure = _prefixId.prefix "IfcMassMeasure"
    let IfcMassPerLengthMeasure = _prefixId.prefix "IfcMassPerLengthMeasure"
    let IfcMaterial = _prefixId.prefix "IfcMaterial"

    let IfcMaterialClassificationRelationship = _prefixId.prefix "IfcMaterialClassificationRelationship"

    let IfcMaterialConstituent = _prefixId.prefix "IfcMaterialConstituent"
    let IfcMaterialConstituentSet = _prefixId.prefix "IfcMaterialConstituentSet"
    let IfcMaterialDefinition = _prefixId.prefix "IfcMaterialDefinition"

    let IfcMaterialDefinitionRepresentation = _prefixId.prefix "IfcMaterialDefinitionRepresentation"

    let IfcMaterialLayer = _prefixId.prefix "IfcMaterialLayer"
    let IfcMaterialLayerSet = _prefixId.prefix "IfcMaterialLayerSet"
    let IfcMaterialLayerSetUsage = _prefixId.prefix "IfcMaterialLayerSetUsage"
    let IfcMaterialLayerWithOffsets = _prefixId.prefix "IfcMaterialLayerWithOffsets"
    let IfcMaterialLayer_EmptyList = _prefixId.prefix "IfcMaterialLayer_EmptyList"
    let IfcMaterialLayer_List = _prefixId.prefix "IfcMaterialLayer_List"
    let IfcMaterialList = _prefixId.prefix "IfcMaterialList"
    let IfcMaterialProfile = _prefixId.prefix "IfcMaterialProfile"
    let IfcMaterialProfileSet = _prefixId.prefix "IfcMaterialProfileSet"
    let IfcMaterialProfileSetUsage = _prefixId.prefix "IfcMaterialProfileSetUsage"

    let IfcMaterialProfileSetUsageTapering = _prefixId.prefix "IfcMaterialProfileSetUsageTapering"

    let IfcMaterialProfileWithOffsets = _prefixId.prefix "IfcMaterialProfileWithOffsets"
    let IfcMaterialProfile_EmptyList = _prefixId.prefix "IfcMaterialProfile_EmptyList"
    let IfcMaterialProfile_List = _prefixId.prefix "IfcMaterialProfile_List"
    let IfcMaterialProperties = _prefixId.prefix "IfcMaterialProperties"
    let IfcMaterialRelationship = _prefixId.prefix "IfcMaterialRelationship"
    let IfcMaterialSelect = _prefixId.prefix "IfcMaterialSelect"
    let IfcMaterialUsageDefinition = _prefixId.prefix "IfcMaterialUsageDefinition"
    let IfcMaterial_EmptyList = _prefixId.prefix "IfcMaterial_EmptyList"
    let IfcMaterial_List = _prefixId.prefix "IfcMaterial_List"
    let IfcMeasureValue = _prefixId.prefix "IfcMeasureValue"
    let IfcMeasureWithUnit = _prefixId.prefix "IfcMeasureWithUnit"
    let IfcMechanicalFastener = _prefixId.prefix "IfcMechanicalFastener"
    let IfcMechanicalFastenerType = _prefixId.prefix "IfcMechanicalFastenerType"
    let IfcMechanicalFastenerTypeEnum = _prefixId.prefix "IfcMechanicalFastenerTypeEnum"
    let IfcMedicalDevice = _prefixId.prefix "IfcMedicalDevice"
    let IfcMedicalDeviceType = _prefixId.prefix "IfcMedicalDeviceType"
    let IfcMedicalDeviceTypeEnum = _prefixId.prefix "IfcMedicalDeviceTypeEnum"
    let IfcMember = _prefixId.prefix "IfcMember"
    let IfcMemberStandardCase = _prefixId.prefix "IfcMemberStandardCase"
    let IfcMemberType = _prefixId.prefix "IfcMemberType"
    let IfcMemberTypeEnum = _prefixId.prefix "IfcMemberTypeEnum"
    let IfcMetric = _prefixId.prefix "IfcMetric"
    let IfcMetricValueSelect = _prefixId.prefix "IfcMetricValueSelect"
    let IfcMirroredProfileDef = _prefixId.prefix "IfcMirroredProfileDef"
    let IfcModulusOfElasticityMeasure = _prefixId.prefix "IfcModulusOfElasticityMeasure"

    let IfcModulusOfLinearSubgradeReactionMeasure = _prefixId.prefix "IfcModulusOfLinearSubgradeReactionMeasure"

    let IfcModulusOfRotationalSubgradeReactionMeasure = _prefixId.prefix "IfcModulusOfRotationalSubgradeReactionMeasure"

    let IfcModulusOfRotationalSubgradeReactionSelect = _prefixId.prefix "IfcModulusOfRotationalSubgradeReactionSelect"

    let IfcModulusOfSubgradeReactionMeasure = _prefixId.prefix "IfcModulusOfSubgradeReactionMeasure"

    let IfcModulusOfSubgradeReactionSelect = _prefixId.prefix "IfcModulusOfSubgradeReactionSelect"

    let IfcModulusOfTranslationalSubgradeReactionSelect = _prefixId.prefix "IfcModulusOfTranslationalSubgradeReactionSelect"

    let IfcMoistureDiffusivityMeasure = _prefixId.prefix "IfcMoistureDiffusivityMeasure"
    let IfcMolecularWeightMeasure = _prefixId.prefix "IfcMolecularWeightMeasure"
    let IfcMomentOfInertiaMeasure = _prefixId.prefix "IfcMomentOfInertiaMeasure"
    let IfcMonetaryMeasure = _prefixId.prefix "IfcMonetaryMeasure"
    let IfcMonetaryUnit = _prefixId.prefix "IfcMonetaryUnit"
    let IfcMonthInYearNumber = _prefixId.prefix "IfcMonthInYearNumber"
    let IfcMotorConnection = _prefixId.prefix "IfcMotorConnection"
    let IfcMotorConnectionType = _prefixId.prefix "IfcMotorConnectionType"
    let IfcMotorConnectionTypeEnum = _prefixId.prefix "IfcMotorConnectionTypeEnum"
    let IfcNamedUnit = _prefixId.prefix "IfcNamedUnit"
    let IfcNonNegativeLengthMeasure = _prefixId.prefix "IfcNonNegativeLengthMeasure"
    let IfcNormalisedRatioMeasure = _prefixId.prefix "IfcNormalisedRatioMeasure"

    let IfcNormalisedRatioMeasure_EmptyList = _prefixId.prefix "IfcNormalisedRatioMeasure_EmptyList"

    let IfcNormalisedRatioMeasure_List = _prefixId.prefix "IfcNormalisedRatioMeasure_List"

    let IfcNormalisedRatioMeasure_List_EmptyList = _prefixId.prefix "IfcNormalisedRatioMeasure_List_EmptyList"

    let IfcNormalisedRatioMeasure_List_List = _prefixId.prefix "IfcNormalisedRatioMeasure_List_List"

    let IfcNullStyle = _prefixId.prefix "IfcNullStyle"
    let IfcNumericMeasure = _prefixId.prefix "IfcNumericMeasure"
    let IfcObject = _prefixId.prefix "IfcObject"
    let IfcObjectDefinition = _prefixId.prefix "IfcObjectDefinition"
    let IfcObjectDefinition_EmptyList = _prefixId.prefix "IfcObjectDefinition_EmptyList"
    let IfcObjectDefinition_List = _prefixId.prefix "IfcObjectDefinition_List"
    let IfcObjectPlacement = _prefixId.prefix "IfcObjectPlacement"
    let IfcObjectReferenceSelect = _prefixId.prefix "IfcObjectReferenceSelect"
    let IfcObjectTypeEnum = _prefixId.prefix "IfcObjectTypeEnum"
    let IfcObjective = _prefixId.prefix "IfcObjective"
    let IfcObjectiveEnum = _prefixId.prefix "IfcObjectiveEnum"
    let IfcOccupant = _prefixId.prefix "IfcOccupant"
    let IfcOccupantTypeEnum = _prefixId.prefix "IfcOccupantTypeEnum"
    let IfcOffsetCurve2D = _prefixId.prefix "IfcOffsetCurve2D"
    let IfcOffsetCurve3D = _prefixId.prefix "IfcOffsetCurve3D"
    let IfcOpenShell = _prefixId.prefix "IfcOpenShell"
    let IfcOpeningElement = _prefixId.prefix "IfcOpeningElement"
    let IfcOpeningElementTypeEnum = _prefixId.prefix "IfcOpeningElementTypeEnum"
    let IfcOpeningStandardCase = _prefixId.prefix "IfcOpeningStandardCase"
    let IfcOrganization = _prefixId.prefix "IfcOrganization"
    let IfcOrganizationRelationship = _prefixId.prefix "IfcOrganizationRelationship"
    let IfcOrientedEdge = _prefixId.prefix "IfcOrientedEdge"
    let IfcOrientedEdge_EmptyList = _prefixId.prefix "IfcOrientedEdge_EmptyList"
    let IfcOrientedEdge_List = _prefixId.prefix "IfcOrientedEdge_List"
    let IfcOuterBoundaryCurve = _prefixId.prefix "IfcOuterBoundaryCurve"
    let IfcOutlet = _prefixId.prefix "IfcOutlet"
    let IfcOutletType = _prefixId.prefix "IfcOutletType"
    let IfcOutletTypeEnum = _prefixId.prefix "IfcOutletTypeEnum"
    let IfcOwnerHistory = _prefixId.prefix "IfcOwnerHistory"
    let IfcPHMeasure = _prefixId.prefix "IfcPHMeasure"
    let IfcParameterValue = _prefixId.prefix "IfcParameterValue"
    let IfcParameterValue_EmptyList = _prefixId.prefix "IfcParameterValue_EmptyList"
    let IfcParameterValue_List = _prefixId.prefix "IfcParameterValue_List"

    let IfcParameterValue_List_EmptyList = _prefixId.prefix "IfcParameterValue_List_EmptyList"

    let IfcParameterValue_List_List = _prefixId.prefix "IfcParameterValue_List_List"
    let IfcParameterizedProfileDef = _prefixId.prefix "IfcParameterizedProfileDef"
    let IfcPath = _prefixId.prefix "IfcPath"
    let IfcPcurve = _prefixId.prefix "IfcPcurve"
    let IfcPerformanceHistory = _prefixId.prefix "IfcPerformanceHistory"
    let IfcPerformanceHistoryTypeEnum = _prefixId.prefix "IfcPerformanceHistoryTypeEnum"

    let IfcPermeableCoveringOperationEnum = _prefixId.prefix "IfcPermeableCoveringOperationEnum"

    let IfcPermeableCoveringProperties = _prefixId.prefix "IfcPermeableCoveringProperties"

    let IfcPermit = _prefixId.prefix "IfcPermit"
    let IfcPermitTypeEnum = _prefixId.prefix "IfcPermitTypeEnum"
    let IfcPerson = _prefixId.prefix "IfcPerson"
    let IfcPersonAndOrganization = _prefixId.prefix "IfcPersonAndOrganization"
    let IfcPhysicalComplexQuantity = _prefixId.prefix "IfcPhysicalComplexQuantity"
    let IfcPhysicalOrVirtualEnum = _prefixId.prefix "IfcPhysicalOrVirtualEnum"
    let IfcPhysicalQuantity = _prefixId.prefix "IfcPhysicalQuantity"
    let IfcPhysicalQuantity_EmptyList = _prefixId.prefix "IfcPhysicalQuantity_EmptyList"
    let IfcPhysicalQuantity_List = _prefixId.prefix "IfcPhysicalQuantity_List"
    let IfcPhysicalSimpleQuantity = _prefixId.prefix "IfcPhysicalSimpleQuantity"
    let IfcPile = _prefixId.prefix "IfcPile"
    let IfcPileConstructionEnum = _prefixId.prefix "IfcPileConstructionEnum"
    let IfcPileType = _prefixId.prefix "IfcPileType"
    let IfcPileTypeEnum = _prefixId.prefix "IfcPileTypeEnum"
    let IfcPipeFitting = _prefixId.prefix "IfcPipeFitting"
    let IfcPipeFittingType = _prefixId.prefix "IfcPipeFittingType"
    let IfcPipeFittingTypeEnum = _prefixId.prefix "IfcPipeFittingTypeEnum"
    let IfcPipeSegment = _prefixId.prefix "IfcPipeSegment"
    let IfcPipeSegmentType = _prefixId.prefix "IfcPipeSegmentType"
    let IfcPipeSegmentTypeEnum = _prefixId.prefix "IfcPipeSegmentTypeEnum"
    let IfcPixelTexture = _prefixId.prefix "IfcPixelTexture"
    let IfcPlacement = _prefixId.prefix "IfcPlacement"
    let IfcPlanarBox = _prefixId.prefix "IfcPlanarBox"
    let IfcPlanarExtent = _prefixId.prefix "IfcPlanarExtent"
    let IfcPlanarForceMeasure = _prefixId.prefix "IfcPlanarForceMeasure"
    let IfcPlane = _prefixId.prefix "IfcPlane"
    let IfcPlaneAngleMeasure = _prefixId.prefix "IfcPlaneAngleMeasure"

    let IfcPlaneAngleMeasure_EmptyList = _prefixId.prefix "IfcPlaneAngleMeasure_EmptyList"

    let IfcPlaneAngleMeasure_List = _prefixId.prefix "IfcPlaneAngleMeasure_List"
    let IfcPlate = _prefixId.prefix "IfcPlate"
    let IfcPlateStandardCase = _prefixId.prefix "IfcPlateStandardCase"
    let IfcPlateType = _prefixId.prefix "IfcPlateType"
    let IfcPlateTypeEnum = _prefixId.prefix "IfcPlateTypeEnum"
    let IfcPoint = _prefixId.prefix "IfcPoint"
    let IfcPointOnCurve = _prefixId.prefix "IfcPointOnCurve"
    let IfcPointOnSurface = _prefixId.prefix "IfcPointOnSurface"
    let IfcPointOrVertexPoint = _prefixId.prefix "IfcPointOrVertexPoint"
    let IfcPolyLoop = _prefixId.prefix "IfcPolyLoop"
    let IfcPolygonalBoundedHalfSpace = _prefixId.prefix "IfcPolygonalBoundedHalfSpace"
    let IfcPolyline = _prefixId.prefix "IfcPolyline"
    let IfcPort = _prefixId.prefix "IfcPort"
    let IfcPositiveInteger = _prefixId.prefix "IfcPositiveInteger"
    let IfcPositiveInteger_EmptyList = _prefixId.prefix "IfcPositiveInteger_EmptyList"
    let IfcPositiveInteger_List = _prefixId.prefix "IfcPositiveInteger_List"

    let IfcPositiveInteger_List_EmptyList = _prefixId.prefix "IfcPositiveInteger_List_EmptyList"

    let IfcPositiveInteger_List_List = _prefixId.prefix "IfcPositiveInteger_List_List"
    let IfcPositiveLengthMeasure = _prefixId.prefix "IfcPositiveLengthMeasure"
    let IfcPositivePlaneAngleMeasure = _prefixId.prefix "IfcPositivePlaneAngleMeasure"
    let IfcPositiveRatioMeasure = _prefixId.prefix "IfcPositiveRatioMeasure"
    let IfcPostalAddress = _prefixId.prefix "IfcPostalAddress"
    let IfcPowerMeasure = _prefixId.prefix "IfcPowerMeasure"
    let IfcPreDefinedColour = _prefixId.prefix "IfcPreDefinedColour"
    let IfcPreDefinedCurveFont = _prefixId.prefix "IfcPreDefinedCurveFont"
    let IfcPreDefinedItem = _prefixId.prefix "IfcPreDefinedItem"
    let IfcPreDefinedProperties = _prefixId.prefix "IfcPreDefinedProperties"
    let IfcPreDefinedPropertySet = _prefixId.prefix "IfcPreDefinedPropertySet"
    let IfcPreDefinedTextFont = _prefixId.prefix "IfcPreDefinedTextFont"
    let IfcPresentableText = _prefixId.prefix "IfcPresentableText"
    let IfcPresentationItem = _prefixId.prefix "IfcPresentationItem"

    let IfcPresentationLayerAssignment = _prefixId.prefix "IfcPresentationLayerAssignment"

    let IfcPresentationLayerWithStyle = _prefixId.prefix "IfcPresentationLayerWithStyle"
    let IfcPresentationStyle = _prefixId.prefix "IfcPresentationStyle"

    let IfcPresentationStyleAssignment = _prefixId.prefix "IfcPresentationStyleAssignment"

    let IfcPresentationStyleSelect = _prefixId.prefix "IfcPresentationStyleSelect"
    let IfcPressureMeasure = _prefixId.prefix "IfcPressureMeasure"
    let IfcProcedure = _prefixId.prefix "IfcProcedure"
    let IfcProcedureType = _prefixId.prefix "IfcProcedureType"
    let IfcProcedureTypeEnum = _prefixId.prefix "IfcProcedureTypeEnum"
    let IfcProcess = _prefixId.prefix "IfcProcess"
    let IfcProcessSelect = _prefixId.prefix "IfcProcessSelect"
    let IfcProduct = _prefixId.prefix "IfcProduct"
    let IfcProductDefinitionShape = _prefixId.prefix "IfcProductDefinitionShape"
    let IfcProductRepresentation = _prefixId.prefix "IfcProductRepresentation"

    let IfcProductRepresentationSelect = _prefixId.prefix "IfcProductRepresentationSelect"

    let IfcProductSelect = _prefixId.prefix "IfcProductSelect"
    let IfcProfileDef = _prefixId.prefix "IfcProfileDef"
    let IfcProfileDef_EmptyList = _prefixId.prefix "IfcProfileDef_EmptyList"
    let IfcProfileDef_List = _prefixId.prefix "IfcProfileDef_List"
    let IfcProfileProperties = _prefixId.prefix "IfcProfileProperties"
    let IfcProfileTypeEnum = _prefixId.prefix "IfcProfileTypeEnum"
    let IfcProject = _prefixId.prefix "IfcProject"
    let IfcProjectLibrary = _prefixId.prefix "IfcProjectLibrary"
    let IfcProjectOrder = _prefixId.prefix "IfcProjectOrder"
    let IfcProjectOrderTypeEnum = _prefixId.prefix "IfcProjectOrderTypeEnum"
    let IfcProjectedCRS = _prefixId.prefix "IfcProjectedCRS"
    let IfcProjectedOrTrueLengthEnum = _prefixId.prefix "IfcProjectedOrTrueLengthEnum"
    let IfcProjectionElement = _prefixId.prefix "IfcProjectionElement"
    let IfcProjectionElementTypeEnum = _prefixId.prefix "IfcProjectionElementTypeEnum"
    let IfcProperty = _prefixId.prefix "IfcProperty"
    let IfcPropertyAbstraction = _prefixId.prefix "IfcPropertyAbstraction"
    let IfcPropertyBoundedValue = _prefixId.prefix "IfcPropertyBoundedValue"
    let IfcPropertyDefinition = _prefixId.prefix "IfcPropertyDefinition"

    let IfcPropertyDependencyRelationship = _prefixId.prefix "IfcPropertyDependencyRelationship"

    let IfcPropertyEnumeratedValue = _prefixId.prefix "IfcPropertyEnumeratedValue"
    let IfcPropertyEnumeration = _prefixId.prefix "IfcPropertyEnumeration"
    let IfcPropertyListValue = _prefixId.prefix "IfcPropertyListValue"
    let IfcPropertyReferenceValue = _prefixId.prefix "IfcPropertyReferenceValue"
    let IfcPropertySet = _prefixId.prefix "IfcPropertySet"
    let IfcPropertySetDefinition = _prefixId.prefix "IfcPropertySetDefinition"

    let IfcPropertySetDefinitionSelect = _prefixId.prefix "IfcPropertySetDefinitionSelect"

    let IfcPropertySetDefinitionSet = _prefixId.prefix "IfcPropertySetDefinitionSet"
    let IfcPropertySetTemplate = _prefixId.prefix "IfcPropertySetTemplate"

    let IfcPropertySetTemplateTypeEnum = _prefixId.prefix "IfcPropertySetTemplateTypeEnum"

    let IfcPropertySingleValue = _prefixId.prefix "IfcPropertySingleValue"
    let IfcPropertyTableValue = _prefixId.prefix "IfcPropertyTableValue"
    let IfcPropertyTemplate = _prefixId.prefix "IfcPropertyTemplate"
    let IfcPropertyTemplateDefinition = _prefixId.prefix "IfcPropertyTemplateDefinition"
    let IfcProtectiveDevice = _prefixId.prefix "IfcProtectiveDevice"

    let IfcProtectiveDeviceTrippingUnit = _prefixId.prefix "IfcProtectiveDeviceTrippingUnit"

    let IfcProtectiveDeviceTrippingUnitType = _prefixId.prefix "IfcProtectiveDeviceTrippingUnitType"

    let IfcProtectiveDeviceTrippingUnitTypeEnum = _prefixId.prefix "IfcProtectiveDeviceTrippingUnitTypeEnum"

    let IfcProtectiveDeviceType = _prefixId.prefix "IfcProtectiveDeviceType"
    let IfcProtectiveDeviceTypeEnum = _prefixId.prefix "IfcProtectiveDeviceTypeEnum"
    let IfcProxy = _prefixId.prefix "IfcProxy"
    let IfcPump = _prefixId.prefix "IfcPump"
    let IfcPumpType = _prefixId.prefix "IfcPumpType"
    let IfcPumpTypeEnum = _prefixId.prefix "IfcPumpTypeEnum"
    let IfcQuantityArea = _prefixId.prefix "IfcQuantityArea"
    let IfcQuantityCount = _prefixId.prefix "IfcQuantityCount"
    let IfcQuantityLength = _prefixId.prefix "IfcQuantityLength"
    let IfcQuantitySet = _prefixId.prefix "IfcQuantitySet"
    let IfcQuantityTime = _prefixId.prefix "IfcQuantityTime"
    let IfcQuantityVolume = _prefixId.prefix "IfcQuantityVolume"
    let IfcQuantityWeight = _prefixId.prefix "IfcQuantityWeight"
    let IfcRadioActivityMeasure = _prefixId.prefix "IfcRadioActivityMeasure"
    let IfcRailing = _prefixId.prefix "IfcRailing"
    let IfcRailingType = _prefixId.prefix "IfcRailingType"
    let IfcRailingTypeEnum = _prefixId.prefix "IfcRailingTypeEnum"
    let IfcRamp = _prefixId.prefix "IfcRamp"
    let IfcRampFlight = _prefixId.prefix "IfcRampFlight"
    let IfcRampFlightType = _prefixId.prefix "IfcRampFlightType"
    let IfcRampFlightTypeEnum = _prefixId.prefix "IfcRampFlightTypeEnum"
    let IfcRampType = _prefixId.prefix "IfcRampType"
    let IfcRampTypeEnum = _prefixId.prefix "IfcRampTypeEnum"
    let IfcRatioMeasure = _prefixId.prefix "IfcRatioMeasure"
    let IfcRatioMeasure_EmptyList = _prefixId.prefix "IfcRatioMeasure_EmptyList"
    let IfcRatioMeasure_List = _prefixId.prefix "IfcRatioMeasure_List"

    let IfcRationalBSplineCurveWithKnots = _prefixId.prefix "IfcRationalBSplineCurveWithKnots"

    let IfcRationalBSplineSurfaceWithKnots = _prefixId.prefix "IfcRationalBSplineSurfaceWithKnots"

    let IfcReal = _prefixId.prefix "IfcReal"
    let IfcReal_EmptyList = _prefixId.prefix "IfcReal_EmptyList"
    let IfcReal_List = _prefixId.prefix "IfcReal_List"
    let IfcReal_List_EmptyList = _prefixId.prefix "IfcReal_List_EmptyList"
    let IfcReal_List_List = _prefixId.prefix "IfcReal_List_List"
    let IfcRectangleHollowProfileDef = _prefixId.prefix "IfcRectangleHollowProfileDef"
    let IfcRectangleProfileDef = _prefixId.prefix "IfcRectangleProfileDef"
    let IfcRectangularPyramid = _prefixId.prefix "IfcRectangularPyramid"
    let IfcRectangularTrimmedSurface = _prefixId.prefix "IfcRectangularTrimmedSurface"
    let IfcRecurrencePattern = _prefixId.prefix "IfcRecurrencePattern"
    let IfcRecurrenceTypeEnum = _prefixId.prefix "IfcRecurrenceTypeEnum"
    let IfcReference = _prefixId.prefix "IfcReference"
    let IfcReflectanceMethodEnum = _prefixId.prefix "IfcReflectanceMethodEnum"
    let IfcRegularTimeSeries = _prefixId.prefix "IfcRegularTimeSeries"
    let IfcReinforcementBarProperties = _prefixId.prefix "IfcReinforcementBarProperties"

    let IfcReinforcementDefinitionProperties = _prefixId.prefix "IfcReinforcementDefinitionProperties"

    let IfcReinforcingBar = _prefixId.prefix "IfcReinforcingBar"
    let IfcReinforcingBarRoleEnum = _prefixId.prefix "IfcReinforcingBarRoleEnum"
    let IfcReinforcingBarSurfaceEnum = _prefixId.prefix "IfcReinforcingBarSurfaceEnum"
    let IfcReinforcingBarType = _prefixId.prefix "IfcReinforcingBarType"
    let IfcReinforcingBarTypeEnum = _prefixId.prefix "IfcReinforcingBarTypeEnum"
    let IfcReinforcingElement = _prefixId.prefix "IfcReinforcingElement"
    let IfcReinforcingElementType = _prefixId.prefix "IfcReinforcingElementType"
    let IfcReinforcingMesh = _prefixId.prefix "IfcReinforcingMesh"
    let IfcReinforcingMeshType = _prefixId.prefix "IfcReinforcingMeshType"
    let IfcReinforcingMeshTypeEnum = _prefixId.prefix "IfcReinforcingMeshTypeEnum"
    let IfcRelAggregates = _prefixId.prefix "IfcRelAggregates"
    let IfcRelAssigns = _prefixId.prefix "IfcRelAssigns"
    let IfcRelAssignsToActor = _prefixId.prefix "IfcRelAssignsToActor"
    let IfcRelAssignsToControl = _prefixId.prefix "IfcRelAssignsToControl"
    let IfcRelAssignsToGroup = _prefixId.prefix "IfcRelAssignsToGroup"
    let IfcRelAssignsToGroupByFactor = _prefixId.prefix "IfcRelAssignsToGroupByFactor"
    let IfcRelAssignsToProcess = _prefixId.prefix "IfcRelAssignsToProcess"
    let IfcRelAssignsToProduct = _prefixId.prefix "IfcRelAssignsToProduct"
    let IfcRelAssignsToResource = _prefixId.prefix "IfcRelAssignsToResource"
    let IfcRelAssociates = _prefixId.prefix "IfcRelAssociates"
    let IfcRelAssociatesApproval = _prefixId.prefix "IfcRelAssociatesApproval"

    let IfcRelAssociatesClassification = _prefixId.prefix "IfcRelAssociatesClassification"

    let IfcRelAssociatesConstraint = _prefixId.prefix "IfcRelAssociatesConstraint"
    let IfcRelAssociatesDocument = _prefixId.prefix "IfcRelAssociatesDocument"
    let IfcRelAssociatesLibrary = _prefixId.prefix "IfcRelAssociatesLibrary"
    let IfcRelAssociatesMaterial = _prefixId.prefix "IfcRelAssociatesMaterial"
    let IfcRelConnects = _prefixId.prefix "IfcRelConnects"
    let IfcRelConnectsElements = _prefixId.prefix "IfcRelConnectsElements"
    let IfcRelConnectsPathElements = _prefixId.prefix "IfcRelConnectsPathElements"
    let IfcRelConnectsPortToElement = _prefixId.prefix "IfcRelConnectsPortToElement"
    let IfcRelConnectsPorts = _prefixId.prefix "IfcRelConnectsPorts"

    let IfcRelConnectsStructuralActivity = _prefixId.prefix "IfcRelConnectsStructuralActivity"

    let IfcRelConnectsStructuralMember = _prefixId.prefix "IfcRelConnectsStructuralMember"

    let IfcRelConnectsWithEccentricity = _prefixId.prefix "IfcRelConnectsWithEccentricity"

    let IfcRelConnectsWithRealizingElements = _prefixId.prefix "IfcRelConnectsWithRealizingElements"

    let IfcRelContainedInSpatialStructure = _prefixId.prefix "IfcRelContainedInSpatialStructure"

    let IfcRelCoversBldgElements = _prefixId.prefix "IfcRelCoversBldgElements"
    let IfcRelCoversSpaces = _prefixId.prefix "IfcRelCoversSpaces"
    let IfcRelDeclares = _prefixId.prefix "IfcRelDeclares"
    let IfcRelDecomposes = _prefixId.prefix "IfcRelDecomposes"
    let IfcRelDefines = _prefixId.prefix "IfcRelDefines"
    let IfcRelDefinesByObject = _prefixId.prefix "IfcRelDefinesByObject"
    let IfcRelDefinesByProperties = _prefixId.prefix "IfcRelDefinesByProperties"
    let IfcRelDefinesByTemplate = _prefixId.prefix "IfcRelDefinesByTemplate"
    let IfcRelDefinesByType = _prefixId.prefix "IfcRelDefinesByType"
    let IfcRelFillsElement = _prefixId.prefix "IfcRelFillsElement"
    let IfcRelFlowControlElements = _prefixId.prefix "IfcRelFlowControlElements"
    let IfcRelInterferesElements = _prefixId.prefix "IfcRelInterferesElements"
    let IfcRelNests = _prefixId.prefix "IfcRelNests"
    let IfcRelProjectsElement = _prefixId.prefix "IfcRelProjectsElement"

    let IfcRelReferencedInSpatialStructure = _prefixId.prefix "IfcRelReferencedInSpatialStructure"

    let IfcRelSequence = _prefixId.prefix "IfcRelSequence"
    let IfcRelServicesBuildings = _prefixId.prefix "IfcRelServicesBuildings"
    let IfcRelSpaceBoundary = _prefixId.prefix "IfcRelSpaceBoundary"
    let IfcRelSpaceBoundary1stLevel = _prefixId.prefix "IfcRelSpaceBoundary1stLevel"
    let IfcRelSpaceBoundary2ndLevel = _prefixId.prefix "IfcRelSpaceBoundary2ndLevel"
    let IfcRelVoidsElement = _prefixId.prefix "IfcRelVoidsElement"
    let IfcRelationship = _prefixId.prefix "IfcRelationship"

    let IfcReparametrisedCompositeCurveSegment = _prefixId.prefix "IfcReparametrisedCompositeCurveSegment"

    let IfcRepresentation = _prefixId.prefix "IfcRepresentation"
    let IfcRepresentationContext = _prefixId.prefix "IfcRepresentationContext"
    let IfcRepresentationItem = _prefixId.prefix "IfcRepresentationItem"
    let IfcRepresentationMap = _prefixId.prefix "IfcRepresentationMap"

    let IfcRepresentationMap_EmptyList = _prefixId.prefix "IfcRepresentationMap_EmptyList"

    let IfcRepresentationMap_List = _prefixId.prefix "IfcRepresentationMap_List"
    let IfcRepresentation_EmptyList = _prefixId.prefix "IfcRepresentation_EmptyList"
    let IfcRepresentation_List = _prefixId.prefix "IfcRepresentation_List"
    let IfcResource = _prefixId.prefix "IfcResource"

    let IfcResourceApprovalRelationship = _prefixId.prefix "IfcResourceApprovalRelationship"

    let IfcResourceConstraintRelationship = _prefixId.prefix "IfcResourceConstraintRelationship"

    let IfcResourceLevelRelationship = _prefixId.prefix "IfcResourceLevelRelationship"
    let IfcResourceObjectSelect = _prefixId.prefix "IfcResourceObjectSelect"
    let IfcResourceSelect = _prefixId.prefix "IfcResourceSelect"
    let IfcResourceTime = _prefixId.prefix "IfcResourceTime"
    let IfcRevolvedAreaSolid = _prefixId.prefix "IfcRevolvedAreaSolid"
    let IfcRevolvedAreaSolidTapered = _prefixId.prefix "IfcRevolvedAreaSolidTapered"
    let IfcRightCircularCone = _prefixId.prefix "IfcRightCircularCone"
    let IfcRightCircularCylinder = _prefixId.prefix "IfcRightCircularCylinder"
    let IfcRoleEnum = _prefixId.prefix "IfcRoleEnum"
    let IfcRoof = _prefixId.prefix "IfcRoof"
    let IfcRoofType = _prefixId.prefix "IfcRoofType"
    let IfcRoofTypeEnum = _prefixId.prefix "IfcRoofTypeEnum"
    let IfcRoot = _prefixId.prefix "IfcRoot"
    let IfcRotationalFrequencyMeasure = _prefixId.prefix "IfcRotationalFrequencyMeasure"
    let IfcRotationalMassMeasure = _prefixId.prefix "IfcRotationalMassMeasure"
    let IfcRotationalStiffnessMeasure = _prefixId.prefix "IfcRotationalStiffnessMeasure"
    let IfcRotationalStiffnessSelect = _prefixId.prefix "IfcRotationalStiffnessSelect"
    let IfcRoundedRectangleProfileDef = _prefixId.prefix "IfcRoundedRectangleProfileDef"
    let IfcSIPrefix = _prefixId.prefix "IfcSIPrefix"
    let IfcSIUnit = _prefixId.prefix "IfcSIUnit"
    let IfcSIUnitName = _prefixId.prefix "IfcSIUnitName"
    let IfcSanitaryTerminal = _prefixId.prefix "IfcSanitaryTerminal"
    let IfcSanitaryTerminalType = _prefixId.prefix "IfcSanitaryTerminalType"
    let IfcSanitaryTerminalTypeEnum = _prefixId.prefix "IfcSanitaryTerminalTypeEnum"
    let IfcSchedulingTime = _prefixId.prefix "IfcSchedulingTime"
    let IfcSectionModulusMeasure = _prefixId.prefix "IfcSectionModulusMeasure"
    let IfcSectionProperties = _prefixId.prefix "IfcSectionProperties"

    let IfcSectionReinforcementProperties = _prefixId.prefix "IfcSectionReinforcementProperties"

    let IfcSectionReinforcementProperties_EmptyList = _prefixId.prefix "IfcSectionReinforcementProperties_EmptyList"

    let IfcSectionReinforcementProperties_List = _prefixId.prefix "IfcSectionReinforcementProperties_List"

    let IfcSectionTypeEnum = _prefixId.prefix "IfcSectionTypeEnum"

    let IfcSectionalAreaIntegralMeasure = _prefixId.prefix "IfcSectionalAreaIntegralMeasure"

    let IfcSectionedSpine = _prefixId.prefix "IfcSectionedSpine"
    let IfcSegmentIndexSelect = _prefixId.prefix "IfcSegmentIndexSelect"

    let IfcSegmentIndexSelect_EmptyList = _prefixId.prefix "IfcSegmentIndexSelect_EmptyList"

    let IfcSegmentIndexSelect_List = _prefixId.prefix "IfcSegmentIndexSelect_List"
    let IfcSensor = _prefixId.prefix "IfcSensor"
    let IfcSensorType = _prefixId.prefix "IfcSensorType"
    let IfcSensorTypeEnum = _prefixId.prefix "IfcSensorTypeEnum"
    let IfcSequenceEnum = _prefixId.prefix "IfcSequenceEnum"
    let IfcShadingDevice = _prefixId.prefix "IfcShadingDevice"
    let IfcShadingDeviceType = _prefixId.prefix "IfcShadingDeviceType"
    let IfcShadingDeviceTypeEnum = _prefixId.prefix "IfcShadingDeviceTypeEnum"
    let IfcShapeAspect = _prefixId.prefix "IfcShapeAspect"
    let IfcShapeModel = _prefixId.prefix "IfcShapeModel"
    let IfcShapeModel_EmptyList = _prefixId.prefix "IfcShapeModel_EmptyList"
    let IfcShapeModel_List = _prefixId.prefix "IfcShapeModel_List"
    let IfcShapeRepresentation = _prefixId.prefix "IfcShapeRepresentation"
    let IfcShearModulusMeasure = _prefixId.prefix "IfcShearModulusMeasure"
    let IfcShell = _prefixId.prefix "IfcShell"
    let IfcShellBasedSurfaceModel = _prefixId.prefix "IfcShellBasedSurfaceModel"
    let IfcSimpleProperty = _prefixId.prefix "IfcSimpleProperty"
    let IfcSimplePropertyTemplate = _prefixId.prefix "IfcSimplePropertyTemplate"

    let IfcSimplePropertyTemplateTypeEnum = _prefixId.prefix "IfcSimplePropertyTemplateTypeEnum"

    let IfcSimpleValue = _prefixId.prefix "IfcSimpleValue"
    let IfcSite = _prefixId.prefix "IfcSite"
    let IfcSizeSelect = _prefixId.prefix "IfcSizeSelect"
    let IfcSlab = _prefixId.prefix "IfcSlab"
    let IfcSlabElementedCase = _prefixId.prefix "IfcSlabElementedCase"
    let IfcSlabStandardCase = _prefixId.prefix "IfcSlabStandardCase"
    let IfcSlabType = _prefixId.prefix "IfcSlabType"
    let IfcSlabTypeEnum = _prefixId.prefix "IfcSlabTypeEnum"

    let IfcSlippageConnectionCondition = _prefixId.prefix "IfcSlippageConnectionCondition"

    let IfcSolarDevice = _prefixId.prefix "IfcSolarDevice"
    let IfcSolarDeviceType = _prefixId.prefix "IfcSolarDeviceType"
    let IfcSolarDeviceTypeEnum = _prefixId.prefix "IfcSolarDeviceTypeEnum"
    let IfcSolidAngleMeasure = _prefixId.prefix "IfcSolidAngleMeasure"
    let IfcSolidModel = _prefixId.prefix "IfcSolidModel"
    let IfcSolidOrShell = _prefixId.prefix "IfcSolidOrShell"
    let IfcSoundPowerLevelMeasure = _prefixId.prefix "IfcSoundPowerLevelMeasure"
    let IfcSoundPowerMeasure = _prefixId.prefix "IfcSoundPowerMeasure"
    let IfcSoundPressureLevelMeasure = _prefixId.prefix "IfcSoundPressureLevelMeasure"
    let IfcSoundPressureMeasure = _prefixId.prefix "IfcSoundPressureMeasure"
    let IfcSpace = _prefixId.prefix "IfcSpace"
    let IfcSpaceBoundarySelect = _prefixId.prefix "IfcSpaceBoundarySelect"
    let IfcSpaceHeater = _prefixId.prefix "IfcSpaceHeater"
    let IfcSpaceHeaterType = _prefixId.prefix "IfcSpaceHeaterType"
    let IfcSpaceHeaterTypeEnum = _prefixId.prefix "IfcSpaceHeaterTypeEnum"
    let IfcSpaceType = _prefixId.prefix "IfcSpaceType"
    let IfcSpaceTypeEnum = _prefixId.prefix "IfcSpaceTypeEnum"
    let IfcSpatialElement = _prefixId.prefix "IfcSpatialElement"
    let IfcSpatialElementType = _prefixId.prefix "IfcSpatialElementType"
    let IfcSpatialStructureElement = _prefixId.prefix "IfcSpatialStructureElement"

    let IfcSpatialStructureElementType = _prefixId.prefix "IfcSpatialStructureElementType"

    let IfcSpatialZone = _prefixId.prefix "IfcSpatialZone"
    let IfcSpatialZoneType = _prefixId.prefix "IfcSpatialZoneType"
    let IfcSpatialZoneTypeEnum = _prefixId.prefix "IfcSpatialZoneTypeEnum"

    let IfcSpecificHeatCapacityMeasure = _prefixId.prefix "IfcSpecificHeatCapacityMeasure"

    let IfcSpecularExponent = _prefixId.prefix "IfcSpecularExponent"
    let IfcSpecularHighlightSelect = _prefixId.prefix "IfcSpecularHighlightSelect"
    let IfcSpecularRoughness = _prefixId.prefix "IfcSpecularRoughness"
    let IfcSphere = _prefixId.prefix "IfcSphere"
    let IfcStackTerminal = _prefixId.prefix "IfcStackTerminal"
    let IfcStackTerminalType = _prefixId.prefix "IfcStackTerminalType"
    let IfcStackTerminalTypeEnum = _prefixId.prefix "IfcStackTerminalTypeEnum"
    let IfcStair = _prefixId.prefix "IfcStair"
    let IfcStairFlight = _prefixId.prefix "IfcStairFlight"
    let IfcStairFlightType = _prefixId.prefix "IfcStairFlightType"
    let IfcStairFlightTypeEnum = _prefixId.prefix "IfcStairFlightTypeEnum"
    let IfcStairType = _prefixId.prefix "IfcStairType"
    let IfcStairTypeEnum = _prefixId.prefix "IfcStairTypeEnum"
    let IfcStateEnum = _prefixId.prefix "IfcStateEnum"
    let IfcStructuralAction = _prefixId.prefix "IfcStructuralAction"
    let IfcStructuralActivity = _prefixId.prefix "IfcStructuralActivity"

    let IfcStructuralActivityAssignmentSelect = _prefixId.prefix "IfcStructuralActivityAssignmentSelect"

    let IfcStructuralAnalysisModel = _prefixId.prefix "IfcStructuralAnalysisModel"
    let IfcStructuralConnection = _prefixId.prefix "IfcStructuralConnection"

    let IfcStructuralConnectionCondition = _prefixId.prefix "IfcStructuralConnectionCondition"

    let IfcStructuralCurveAction = _prefixId.prefix "IfcStructuralCurveAction"

    let IfcStructuralCurveActivityTypeEnum = _prefixId.prefix "IfcStructuralCurveActivityTypeEnum"

    let IfcStructuralCurveConnection = _prefixId.prefix "IfcStructuralCurveConnection"
    let IfcStructuralCurveMember = _prefixId.prefix "IfcStructuralCurveMember"

    let IfcStructuralCurveMemberTypeEnum = _prefixId.prefix "IfcStructuralCurveMemberTypeEnum"

    let IfcStructuralCurveMemberVarying = _prefixId.prefix "IfcStructuralCurveMemberVarying"

    let IfcStructuralCurveReaction = _prefixId.prefix "IfcStructuralCurveReaction"
    let IfcStructuralItem = _prefixId.prefix "IfcStructuralItem"
    let IfcStructuralLinearAction = _prefixId.prefix "IfcStructuralLinearAction"
    let IfcStructuralLoad = _prefixId.prefix "IfcStructuralLoad"
    let IfcStructuralLoadCase = _prefixId.prefix "IfcStructuralLoadCase"

    let IfcStructuralLoadConfiguration = _prefixId.prefix "IfcStructuralLoadConfiguration"

    let IfcStructuralLoadGroup = _prefixId.prefix "IfcStructuralLoadGroup"
    let IfcStructuralLoadLinearForce = _prefixId.prefix "IfcStructuralLoadLinearForce"
    let IfcStructuralLoadOrResult = _prefixId.prefix "IfcStructuralLoadOrResult"

    let IfcStructuralLoadOrResult_EmptyList = _prefixId.prefix "IfcStructuralLoadOrResult_EmptyList"

    let IfcStructuralLoadOrResult_List = _prefixId.prefix "IfcStructuralLoadOrResult_List"

    let IfcStructuralLoadPlanarForce = _prefixId.prefix "IfcStructuralLoadPlanarForce"

    let IfcStructuralLoadSingleDisplacement = _prefixId.prefix "IfcStructuralLoadSingleDisplacement"

    let IfcStructuralLoadSingleDisplacementDistortion = _prefixId.prefix "IfcStructuralLoadSingleDisplacementDistortion"

    let IfcStructuralLoadSingleForce = _prefixId.prefix "IfcStructuralLoadSingleForce"

    let IfcStructuralLoadSingleForceWarping = _prefixId.prefix "IfcStructuralLoadSingleForceWarping"

    let IfcStructuralLoadStatic = _prefixId.prefix "IfcStructuralLoadStatic"
    let IfcStructuralLoadTemperature = _prefixId.prefix "IfcStructuralLoadTemperature"
    let IfcStructuralMember = _prefixId.prefix "IfcStructuralMember"
    let IfcStructuralPlanarAction = _prefixId.prefix "IfcStructuralPlanarAction"
    let IfcStructuralPointAction = _prefixId.prefix "IfcStructuralPointAction"
    let IfcStructuralPointConnection = _prefixId.prefix "IfcStructuralPointConnection"
    let IfcStructuralPointReaction = _prefixId.prefix "IfcStructuralPointReaction"
    let IfcStructuralReaction = _prefixId.prefix "IfcStructuralReaction"
    let IfcStructuralResultGroup = _prefixId.prefix "IfcStructuralResultGroup"
    let IfcStructuralSurfaceAction = _prefixId.prefix "IfcStructuralSurfaceAction"

    let IfcStructuralSurfaceActivityTypeEnum = _prefixId.prefix "IfcStructuralSurfaceActivityTypeEnum"

    let IfcStructuralSurfaceConnection = _prefixId.prefix "IfcStructuralSurfaceConnection"

    let IfcStructuralSurfaceMember = _prefixId.prefix "IfcStructuralSurfaceMember"

    let IfcStructuralSurfaceMemberTypeEnum = _prefixId.prefix "IfcStructuralSurfaceMemberTypeEnum"

    let IfcStructuralSurfaceMemberVarying = _prefixId.prefix "IfcStructuralSurfaceMemberVarying"

    let IfcStructuralSurfaceReaction = _prefixId.prefix "IfcStructuralSurfaceReaction"
    let IfcStyleAssignmentSelect = _prefixId.prefix "IfcStyleAssignmentSelect"
    let IfcStyleModel = _prefixId.prefix "IfcStyleModel"
    let IfcStyledItem = _prefixId.prefix "IfcStyledItem"
    let IfcStyledRepresentation = _prefixId.prefix "IfcStyledRepresentation"
    let IfcSubContractResource = _prefixId.prefix "IfcSubContractResource"
    let IfcSubContractResourceType = _prefixId.prefix "IfcSubContractResourceType"

    let IfcSubContractResourceTypeEnum = _prefixId.prefix "IfcSubContractResourceTypeEnum"

    let IfcSubedge = _prefixId.prefix "IfcSubedge"
    let IfcSurface = _prefixId.prefix "IfcSurface"
    let IfcSurfaceCurveSweptAreaSolid = _prefixId.prefix "IfcSurfaceCurveSweptAreaSolid"
    let IfcSurfaceFeature = _prefixId.prefix "IfcSurfaceFeature"
    let IfcSurfaceFeatureTypeEnum = _prefixId.prefix "IfcSurfaceFeatureTypeEnum"
    let IfcSurfaceOfLinearExtrusion = _prefixId.prefix "IfcSurfaceOfLinearExtrusion"
    let IfcSurfaceOfRevolution = _prefixId.prefix "IfcSurfaceOfRevolution"
    let IfcSurfaceOrFaceSurface = _prefixId.prefix "IfcSurfaceOrFaceSurface"
    let IfcSurfaceReinforcementArea = _prefixId.prefix "IfcSurfaceReinforcementArea"
    let IfcSurfaceSide = _prefixId.prefix "IfcSurfaceSide"
    let IfcSurfaceStyle = _prefixId.prefix "IfcSurfaceStyle"
    let IfcSurfaceStyleElementSelect = _prefixId.prefix "IfcSurfaceStyleElementSelect"
    let IfcSurfaceStyleLighting = _prefixId.prefix "IfcSurfaceStyleLighting"
    let IfcSurfaceStyleRefraction = _prefixId.prefix "IfcSurfaceStyleRefraction"
    let IfcSurfaceStyleRendering = _prefixId.prefix "IfcSurfaceStyleRendering"
    let IfcSurfaceStyleShading = _prefixId.prefix "IfcSurfaceStyleShading"
    let IfcSurfaceStyleWithTextures = _prefixId.prefix "IfcSurfaceStyleWithTextures"
    let IfcSurfaceTexture = _prefixId.prefix "IfcSurfaceTexture"
    let IfcSurfaceTexture_EmptyList = _prefixId.prefix "IfcSurfaceTexture_EmptyList"
    let IfcSurfaceTexture_List = _prefixId.prefix "IfcSurfaceTexture_List"
    let IfcSweptAreaSolid = _prefixId.prefix "IfcSweptAreaSolid"
    let IfcSweptDiskSolid = _prefixId.prefix "IfcSweptDiskSolid"
    let IfcSweptDiskSolidPolygonal = _prefixId.prefix "IfcSweptDiskSolidPolygonal"
    let IfcSweptSurface = _prefixId.prefix "IfcSweptSurface"
    let IfcSwitchingDevice = _prefixId.prefix "IfcSwitchingDevice"
    let IfcSwitchingDeviceType = _prefixId.prefix "IfcSwitchingDeviceType"
    let IfcSwitchingDeviceTypeEnum = _prefixId.prefix "IfcSwitchingDeviceTypeEnum"
    let IfcSystem = _prefixId.prefix "IfcSystem"
    let IfcSystemFurnitureElement = _prefixId.prefix "IfcSystemFurnitureElement"
    let IfcSystemFurnitureElementType = _prefixId.prefix "IfcSystemFurnitureElementType"

    let IfcSystemFurnitureElementTypeEnum = _prefixId.prefix "IfcSystemFurnitureElementTypeEnum"

    let IfcTShapeProfileDef = _prefixId.prefix "IfcTShapeProfileDef"
    let IfcTable = _prefixId.prefix "IfcTable"
    let IfcTableColumn = _prefixId.prefix "IfcTableColumn"
    let IfcTableColumn_EmptyList = _prefixId.prefix "IfcTableColumn_EmptyList"
    let IfcTableColumn_List = _prefixId.prefix "IfcTableColumn_List"
    let IfcTableRow = _prefixId.prefix "IfcTableRow"
    let IfcTableRow_EmptyList = _prefixId.prefix "IfcTableRow_EmptyList"
    let IfcTableRow_List = _prefixId.prefix "IfcTableRow_List"
    let IfcTank = _prefixId.prefix "IfcTank"
    let IfcTankType = _prefixId.prefix "IfcTankType"
    let IfcTankTypeEnum = _prefixId.prefix "IfcTankTypeEnum"
    let IfcTask = _prefixId.prefix "IfcTask"
    let IfcTaskDurationEnum = _prefixId.prefix "IfcTaskDurationEnum"
    let IfcTaskTime = _prefixId.prefix "IfcTaskTime"
    let IfcTaskTimeRecurring = _prefixId.prefix "IfcTaskTimeRecurring"
    let IfcTaskType = _prefixId.prefix "IfcTaskType"
    let IfcTaskTypeEnum = _prefixId.prefix "IfcTaskTypeEnum"
    let IfcTelecomAddress = _prefixId.prefix "IfcTelecomAddress"
    let IfcTemperatureGradientMeasure = _prefixId.prefix "IfcTemperatureGradientMeasure"

    let IfcTemperatureRateOfChangeMeasure = _prefixId.prefix "IfcTemperatureRateOfChangeMeasure"

    let IfcTendon = _prefixId.prefix "IfcTendon"
    let IfcTendonAnchor = _prefixId.prefix "IfcTendonAnchor"
    let IfcTendonAnchorType = _prefixId.prefix "IfcTendonAnchorType"
    let IfcTendonAnchorTypeEnum = _prefixId.prefix "IfcTendonAnchorTypeEnum"
    let IfcTendonType = _prefixId.prefix "IfcTendonType"
    let IfcTendonTypeEnum = _prefixId.prefix "IfcTendonTypeEnum"
    let IfcTessellatedFaceSet = _prefixId.prefix "IfcTessellatedFaceSet"
    let IfcTessellatedItem = _prefixId.prefix "IfcTessellatedItem"
    let IfcText = _prefixId.prefix "IfcText"
    let IfcTextAlignment = _prefixId.prefix "IfcTextAlignment"
    let IfcTextDecoration = _prefixId.prefix "IfcTextDecoration"
    let IfcTextFontName = _prefixId.prefix "IfcTextFontName"
    let IfcTextFontName_EmptyList = _prefixId.prefix "IfcTextFontName_EmptyList"
    let IfcTextFontName_List = _prefixId.prefix "IfcTextFontName_List"
    let IfcTextFontSelect = _prefixId.prefix "IfcTextFontSelect"
    let IfcTextLiteral = _prefixId.prefix "IfcTextLiteral"
    let IfcTextLiteralWithExtent = _prefixId.prefix "IfcTextLiteralWithExtent"
    let IfcTextPath = _prefixId.prefix "IfcTextPath"
    let IfcTextStyle = _prefixId.prefix "IfcTextStyle"
    let IfcTextStyleFontModel = _prefixId.prefix "IfcTextStyleFontModel"
    let IfcTextStyleForDefinedFont = _prefixId.prefix "IfcTextStyleForDefinedFont"
    let IfcTextStyleTextModel = _prefixId.prefix "IfcTextStyleTextModel"
    let IfcTextTransformation = _prefixId.prefix "IfcTextTransformation"
    let IfcTextureCoordinate = _prefixId.prefix "IfcTextureCoordinate"
    let IfcTextureCoordinateGenerator = _prefixId.prefix "IfcTextureCoordinateGenerator"
    let IfcTextureMap = _prefixId.prefix "IfcTextureMap"
    let IfcTextureVertex = _prefixId.prefix "IfcTextureVertex"
    let IfcTextureVertexList = _prefixId.prefix "IfcTextureVertexList"
    let IfcTextureVertex_EmptyList = _prefixId.prefix "IfcTextureVertex_EmptyList"
    let IfcTextureVertex_List = _prefixId.prefix "IfcTextureVertex_List"
    let IfcThermalAdmittanceMeasure = _prefixId.prefix "IfcThermalAdmittanceMeasure"
    let IfcThermalConductivityMeasure = _prefixId.prefix "IfcThermalConductivityMeasure"

    let IfcThermalExpansionCoefficientMeasure = _prefixId.prefix "IfcThermalExpansionCoefficientMeasure"

    let IfcThermalResistanceMeasure = _prefixId.prefix "IfcThermalResistanceMeasure"

    let IfcThermalTransmittanceMeasure = _prefixId.prefix "IfcThermalTransmittanceMeasure"

    let IfcThermodynamicTemperatureMeasure = _prefixId.prefix "IfcThermodynamicTemperatureMeasure"

    let IfcTime = _prefixId.prefix "IfcTime"
    let IfcTimeMeasure = _prefixId.prefix "IfcTimeMeasure"
    let IfcTimeOrRatioSelect = _prefixId.prefix "IfcTimeOrRatioSelect"
    let IfcTimePeriod = _prefixId.prefix "IfcTimePeriod"
    let IfcTimePeriod_EmptyList = _prefixId.prefix "IfcTimePeriod_EmptyList"
    let IfcTimePeriod_List = _prefixId.prefix "IfcTimePeriod_List"
    let IfcTimeSeries = _prefixId.prefix "IfcTimeSeries"
    let IfcTimeSeriesDataTypeEnum = _prefixId.prefix "IfcTimeSeriesDataTypeEnum"
    let IfcTimeSeriesValue = _prefixId.prefix "IfcTimeSeriesValue"
    let IfcTimeSeriesValue_EmptyList = _prefixId.prefix "IfcTimeSeriesValue_EmptyList"
    let IfcTimeSeriesValue_List = _prefixId.prefix "IfcTimeSeriesValue_List"
    let IfcTimeStamp = _prefixId.prefix "IfcTimeStamp"

    let IfcTopologicalRepresentationItem = _prefixId.prefix "IfcTopologicalRepresentationItem"

    let IfcTopologyRepresentation = _prefixId.prefix "IfcTopologyRepresentation"
    let IfcTorqueMeasure = _prefixId.prefix "IfcTorqueMeasure"
    let IfcTransformer = _prefixId.prefix "IfcTransformer"
    let IfcTransformerType = _prefixId.prefix "IfcTransformerType"
    let IfcTransformerTypeEnum = _prefixId.prefix "IfcTransformerTypeEnum"
    let IfcTransitionCode = _prefixId.prefix "IfcTransitionCode"

    let IfcTranslationalStiffnessSelect = _prefixId.prefix "IfcTranslationalStiffnessSelect"

    let IfcTransportElement = _prefixId.prefix "IfcTransportElement"
    let IfcTransportElementType = _prefixId.prefix "IfcTransportElementType"
    let IfcTransportElementTypeEnum = _prefixId.prefix "IfcTransportElementTypeEnum"
    let IfcTrapeziumProfileDef = _prefixId.prefix "IfcTrapeziumProfileDef"
    let IfcTriangulatedFaceSet = _prefixId.prefix "IfcTriangulatedFaceSet"
    let IfcTrimmedCurve = _prefixId.prefix "IfcTrimmedCurve"
    let IfcTrimmingPreference = _prefixId.prefix "IfcTrimmingPreference"
    let IfcTrimmingSelect = _prefixId.prefix "IfcTrimmingSelect"
    let IfcTubeBundle = _prefixId.prefix "IfcTubeBundle"
    let IfcTubeBundleType = _prefixId.prefix "IfcTubeBundleType"
    let IfcTubeBundleTypeEnum = _prefixId.prefix "IfcTubeBundleTypeEnum"
    let IfcTypeObject = _prefixId.prefix "IfcTypeObject"
    let IfcTypeProcess = _prefixId.prefix "IfcTypeProcess"
    let IfcTypeProduct = _prefixId.prefix "IfcTypeProduct"
    let IfcTypeResource = _prefixId.prefix "IfcTypeResource"
    let IfcURIReference = _prefixId.prefix "IfcURIReference"
    let IfcURIReference_EmptyList = _prefixId.prefix "IfcURIReference_EmptyList"
    let IfcURIReference_List = _prefixId.prefix "IfcURIReference_List"
    let IfcUShapeProfileDef = _prefixId.prefix "IfcUShapeProfileDef"
    let IfcUnit = _prefixId.prefix "IfcUnit"
    let IfcUnitAssignment = _prefixId.prefix "IfcUnitAssignment"
    let IfcUnitEnum = _prefixId.prefix "IfcUnitEnum"
    let IfcUnitaryControlElement = _prefixId.prefix "IfcUnitaryControlElement"
    let IfcUnitaryControlElementType = _prefixId.prefix "IfcUnitaryControlElementType"

    let IfcUnitaryControlElementTypeEnum = _prefixId.prefix "IfcUnitaryControlElementTypeEnum"

    let IfcUnitaryEquipment = _prefixId.prefix "IfcUnitaryEquipment"
    let IfcUnitaryEquipmentType = _prefixId.prefix "IfcUnitaryEquipmentType"
    let IfcUnitaryEquipmentTypeEnum = _prefixId.prefix "IfcUnitaryEquipmentTypeEnum"
    let IfcValue = _prefixId.prefix "IfcValue"
    let IfcValue_EmptyList = _prefixId.prefix "IfcValue_EmptyList"
    let IfcValue_List = _prefixId.prefix "IfcValue_List"
    let IfcValve = _prefixId.prefix "IfcValve"
    let IfcValveType = _prefixId.prefix "IfcValveType"
    let IfcValveTypeEnum = _prefixId.prefix "IfcValveTypeEnum"
    let IfcVaporPermeabilityMeasure = _prefixId.prefix "IfcVaporPermeabilityMeasure"
    let IfcVector = _prefixId.prefix "IfcVector"
    let IfcVectorOrDirection = _prefixId.prefix "IfcVectorOrDirection"
    let IfcVector_EmptyList = _prefixId.prefix "IfcVector_EmptyList"
    let IfcVector_List = _prefixId.prefix "IfcVector_List"
    let IfcVertex = _prefixId.prefix "IfcVertex"
    let IfcVertexLoop = _prefixId.prefix "IfcVertexLoop"
    let IfcVertexPoint = _prefixId.prefix "IfcVertexPoint"
    let IfcVibrationIsolator = _prefixId.prefix "IfcVibrationIsolator"
    let IfcVibrationIsolatorType = _prefixId.prefix "IfcVibrationIsolatorType"
    let IfcVibrationIsolatorTypeEnum = _prefixId.prefix "IfcVibrationIsolatorTypeEnum"
    let IfcVirtualElement = _prefixId.prefix "IfcVirtualElement"
    let IfcVirtualGridIntersection = _prefixId.prefix "IfcVirtualGridIntersection"
    let IfcVoidingFeature = _prefixId.prefix "IfcVoidingFeature"
    let IfcVoidingFeatureTypeEnum = _prefixId.prefix "IfcVoidingFeatureTypeEnum"
    let IfcVolumeMeasure = _prefixId.prefix "IfcVolumeMeasure"
    let IfcVolumetricFlowRateMeasure = _prefixId.prefix "IfcVolumetricFlowRateMeasure"
    let IfcWall = _prefixId.prefix "IfcWall"
    let IfcWallElementedCase = _prefixId.prefix "IfcWallElementedCase"
    let IfcWallStandardCase = _prefixId.prefix "IfcWallStandardCase"
    let IfcWallType = _prefixId.prefix "IfcWallType"
    let IfcWallTypeEnum = _prefixId.prefix "IfcWallTypeEnum"
    let IfcWarpingConstantMeasure = _prefixId.prefix "IfcWarpingConstantMeasure"
    let IfcWarpingMomentMeasure = _prefixId.prefix "IfcWarpingMomentMeasure"
    let IfcWarpingStiffnessSelect = _prefixId.prefix "IfcWarpingStiffnessSelect"
    let IfcWasteTerminal = _prefixId.prefix "IfcWasteTerminal"
    let IfcWasteTerminalType = _prefixId.prefix "IfcWasteTerminalType"
    let IfcWasteTerminalTypeEnum = _prefixId.prefix "IfcWasteTerminalTypeEnum"
    let IfcWindow = _prefixId.prefix "IfcWindow"
    let IfcWindowLiningProperties = _prefixId.prefix "IfcWindowLiningProperties"
    let IfcWindowPanelOperationEnum = _prefixId.prefix "IfcWindowPanelOperationEnum"
    let IfcWindowPanelPositionEnum = _prefixId.prefix "IfcWindowPanelPositionEnum"
    let IfcWindowPanelProperties = _prefixId.prefix "IfcWindowPanelProperties"
    let IfcWindowStandardCase = _prefixId.prefix "IfcWindowStandardCase"
    let IfcWindowStyle = _prefixId.prefix "IfcWindowStyle"

    let IfcWindowStyleConstructionEnum = _prefixId.prefix "IfcWindowStyleConstructionEnum"

    let IfcWindowStyleOperationEnum = _prefixId.prefix "IfcWindowStyleOperationEnum"
    let IfcWindowType = _prefixId.prefix "IfcWindowType"
    let IfcWindowTypeEnum = _prefixId.prefix "IfcWindowTypeEnum"
    let IfcWindowTypePartitioningEnum = _prefixId.prefix "IfcWindowTypePartitioningEnum"
    let IfcWorkCalendar = _prefixId.prefix "IfcWorkCalendar"
    let IfcWorkCalendarTypeEnum = _prefixId.prefix "IfcWorkCalendarTypeEnum"
    let IfcWorkControl = _prefixId.prefix "IfcWorkControl"
    let IfcWorkPlan = _prefixId.prefix "IfcWorkPlan"
    let IfcWorkPlanTypeEnum = _prefixId.prefix "IfcWorkPlanTypeEnum"
    let IfcWorkSchedule = _prefixId.prefix "IfcWorkSchedule"
    let IfcWorkScheduleTypeEnum = _prefixId.prefix "IfcWorkScheduleTypeEnum"
    let IfcWorkTime = _prefixId.prefix "IfcWorkTime"
    let IfcZShapeProfileDef = _prefixId.prefix "IfcZShapeProfileDef"
    let IfcZone = _prefixId.prefix "IfcZone"
    let JALOUSIE = _prefixId.prefix "JALOUSIE"
    let JETGROUTING = _prefixId.prefix "JETGROUTING"
    let JOIST = _prefixId.prefix "JOIST"
    let JOULE = _prefixId.prefix "JOULE"
    let JUNCTION = _prefixId.prefix "JUNCTION"
    let KELVIN = _prefixId.prefix "KELVIN"
    let KEYPAD = _prefixId.prefix "KEYPAD"
    let KILO = _prefixId.prefix "KILO"
    let KINEMATICVISCOSITYUNIT = _prefixId.prefix "KINEMATICVISCOSITYUNIT"
    let KITCHENMACHINE = _prefixId.prefix "KITCHENMACHINE"
    let LACK_OF_FIT = _prefixId.prefix "LACK_OF_FIT"
    let LANDING = _prefixId.prefix "LANDING"
    let LANDSCAPING = _prefixId.prefix "LANDSCAPING"
    let LED = _prefixId.prefix "LED"
    let LEFT = _prefixId.prefix "LEFT"
    let LENGTHUNIT = _prefixId.prefix "LENGTHUNIT"
    let LESSEE = _prefixId.prefix "LESSEE"
    let LESSOR = _prefixId.prefix "LESSOR"
    let LESSTHAN = _prefixId.prefix "LESSTHAN"
    let LESSTHANOREQUALTO = _prefixId.prefix "LESSTHANOREQUALTO"
    let LETTINGAGENT = _prefixId.prefix "LETTINGAGENT"
    let LEVELSENSOR = _prefixId.prefix "LEVELSENSOR"
    let LIFTINGGEAR = _prefixId.prefix "LIFTINGGEAR"
    let LIGATURE = _prefixId.prefix "LIGATURE"
    let LIGHT = _prefixId.prefix "LIGHT"
    let LIGHTDOME = _prefixId.prefix "LIGHTDOME"
    let LIGHTEMITTINGDIODE = _prefixId.prefix "LIGHTEMITTINGDIODE"
    let LIGHTING = _prefixId.prefix "LIGHTING"
    let LIGHTNINGPROTECTION = _prefixId.prefix "LIGHTNINGPROTECTION"
    let LIGHTSENSOR = _prefixId.prefix "LIGHTSENSOR"
    let LINEAR = _prefixId.prefix "LINEAR"
    let LINEARFORCEUNIT = _prefixId.prefix "LINEARFORCEUNIT"
    let LINEARMOMENTUNIT = _prefixId.prefix "LINEARMOMENTUNIT"
    let LINEARSTIFFNESSUNIT = _prefixId.prefix "LINEARSTIFFNESSUNIT"
    let LINEARVELOCITYUNIT = _prefixId.prefix "LINEARVELOCITYUNIT"
    let LINTEL = _prefixId.prefix "LINTEL"
    let LIVE_LOAD_Q = _prefixId.prefix "LIVE_LOAD_Q"
    let LOADBEARING = _prefixId.prefix "LOADBEARING"
    let LOADING_3D = _prefixId.prefix "LOADING_3D"
    let LOAD_CASE = _prefixId.prefix "LOAD_CASE"
    let LOAD_COMBINATION = _prefixId.prefix "LOAD_COMBINATION"
    let LOAD_GROUP = _prefixId.prefix "LOAD_GROUP"
    let LOCAL_COORDS = _prefixId.prefix "LOCAL_COORDS"
    let LOCKED = _prefixId.prefix "LOCKED"
    let LOGICALAND = _prefixId.prefix "LOGICALAND"
    let LOGICALNOTAND = _prefixId.prefix "LOGICALNOTAND"
    let LOGICALNOTOR = _prefixId.prefix "LOGICALNOTOR"
    let LOGICALOR = _prefixId.prefix "LOGICALOR"
    let LOGICALXOR = _prefixId.prefix "LOGICALXOR"
    let LOGISTIC = _prefixId.prefix "LOGISTIC"
    let LOG_LINEAR = _prefixId.prefix "LOG_LINEAR"
    let LOG_LOG = _prefixId.prefix "LOG_LOG"
    let LOUVER = _prefixId.prefix "LOUVER"
    let LOUVRE = _prefixId.prefix "LOUVRE"
    let LOWPRESSURESODIUM = _prefixId.prefix "LOWPRESSURESODIUM"
    let LOWVOLTAGEHALOGEN = _prefixId.prefix "LOWVOLTAGEHALOGEN"
    let LUMEN = _prefixId.prefix "LUMEN"
    let LUMINOUSFLUXUNIT = _prefixId.prefix "LUMINOUSFLUXUNIT"

    let LUMINOUSINTENSITYDISTRIBUTIONUNIT = _prefixId.prefix "LUMINOUSINTENSITYDISTRIBUTIONUNIT"

    let LUMINOUSINTENSITYUNIT = _prefixId.prefix "LUMINOUSINTENSITYUNIT"
    let LUX = _prefixId.prefix "LUX"
    let MAGNETICFLUXDENSITYUNIT = _prefixId.prefix "MAGNETICFLUXDENSITYUNIT"
    let MAGNETICFLUXUNIT = _prefixId.prefix "MAGNETICFLUXUNIT"
    let MAIN = _prefixId.prefix "MAIN"
    let MAINTENANCE = _prefixId.prefix "MAINTENANCE"
    let MAINTENANCEWORKORDER = _prefixId.prefix "MAINTENANCEWORKORDER"
    let MAINVOLTAGEHALOGEN = _prefixId.prefix "MAINVOLTAGEHALOGEN"
    let MANHOLE = _prefixId.prefix "MANHOLE"
    let MANSARD_ROOF = _prefixId.prefix "MANSARD_ROOF"
    let MANUALPULLBOX = _prefixId.prefix "MANUALPULLBOX"
    let MANUFACTURER = _prefixId.prefix "MANUFACTURER"
    let MARK = _prefixId.prefix "MARK"
    let MASONRY = _prefixId.prefix "MASONRY"
    let MASSDENSITYUNIT = _prefixId.prefix "MASSDENSITYUNIT"
    let MASSFLOWRATEUNIT = _prefixId.prefix "MASSFLOWRATEUNIT"
    let MASSPERLENGTHUNIT = _prefixId.prefix "MASSPERLENGTHUNIT"
    let MASSUNIT = _prefixId.prefix "MASSUNIT"
    let MATT = _prefixId.prefix "MATT"
    let MEASURED = _prefixId.prefix "MEASURED"
    let MECHANICALENGINEER = _prefixId.prefix "MECHANICALENGINEER"
    let MECHANICALFORCEDDRAFT = _prefixId.prefix "MECHANICALFORCEDDRAFT"
    let MECHANICALINDUCEDDRAFT = _prefixId.prefix "MECHANICALINDUCEDDRAFT"
    let MEGA = _prefixId.prefix "MEGA"
    let MEMBER = _prefixId.prefix "MEMBER"
    let MEMBRANE = _prefixId.prefix "MEMBRANE"
    let MEMBRANE_ELEMENT = _prefixId.prefix "MEMBRANE_ELEMENT"
    let MERGECONFLICT = _prefixId.prefix "MERGECONFLICT"
    let METAL = _prefixId.prefix "METAL"
    let METALHALIDE = _prefixId.prefix "METALHALIDE"
    let METERCHAMBER = _prefixId.prefix "METERCHAMBER"
    let METRE = _prefixId.prefix "METRE"
    let MICRO = _prefixId.prefix "MICRO"
    let MICROPHONE = _prefixId.prefix "MICROPHONE"
    let MICROWAVE = _prefixId.prefix "MICROWAVE"
    let MIDDLE = _prefixId.prefix "MIDDLE"
    let MILLI = _prefixId.prefix "MILLI"
    let MIMICPANEL = _prefixId.prefix "MIMICPANEL"
    let MIRROR = _prefixId.prefix "MIRROR"
    let MITER = _prefixId.prefix "MITER"
    let MIXING = _prefixId.prefix "MIXING"
    let MODELVIEW = _prefixId.prefix "MODELVIEW"
    let MODEL_VIEW = _prefixId.prefix "MODEL_VIEW"
    let MODEM = _prefixId.prefix "MODEM"
    let MODIFIED = _prefixId.prefix "MODIFIED"
    let MODULUSOFELASTICITYUNIT = _prefixId.prefix "MODULUSOFELASTICITYUNIT"

    let MODULUSOFLINEARSUBGRADEREACTIONUNIT = _prefixId.prefix "MODULUSOFLINEARSUBGRADEREACTIONUNIT"

    let MODULUSOFROTATIONALSUBGRADEREACTIONUNIT = _prefixId.prefix "MODULUSOFROTATIONALSUBGRADEREACTIONUNIT"

    let MODULUSOFSUBGRADEREACTIONUNIT = _prefixId.prefix "MODULUSOFSUBGRADEREACTIONUNIT"
    let MOISTUREDIFFUSIVITYUNIT = _prefixId.prefix "MOISTUREDIFFUSIVITYUNIT"
    let MOISTURESENSOR = _prefixId.prefix "MOISTURESENSOR"
    let MOLDING = _prefixId.prefix "MOLDING"
    let MOLE = _prefixId.prefix "MOLE"
    let MOLECULARWEIGHTUNIT = _prefixId.prefix "MOLECULARWEIGHTUNIT"
    let MOMENTARYSWITCH = _prefixId.prefix "MOMENTARYSWITCH"
    let MOMENTOFINERTIAUNIT = _prefixId.prefix "MOMENTOFINERTIAUNIT"
    let MONTHLY_BY_DAY_OF_MONTH = _prefixId.prefix "MONTHLY_BY_DAY_OF_MONTH"
    let MONTHLY_BY_POSITION = _prefixId.prefix "MONTHLY_BY_POSITION"
    let MORTAR = _prefixId.prefix "MORTAR"
    let MOTORCONTROLCENTRE = _prefixId.prefix "MOTORCONTROLCENTRE"
    let MOVABLE = _prefixId.prefix "MOVABLE"
    let MOVE = _prefixId.prefix "MOVE"
    let MOVEMENTSENSOR = _prefixId.prefix "MOVEMENTSENSOR"
    let MOVEORDER = _prefixId.prefix "MOVEORDER"
    let MOVINGWALKWAY = _prefixId.prefix "MOVINGWALKWAY"
    let MULLION = _prefixId.prefix "MULLION"
    let MULTIPLY = _prefixId.prefix "MULTIPLY"
    let MULTIPOSITION = _prefixId.prefix "MULTIPOSITION"
    let MUNICIPALSOLIDWASTE = _prefixId.prefix "MUNICIPALSOLIDWASTE"
    let NAIL = _prefixId.prefix "NAIL"
    let NAILPLATE = _prefixId.prefix "NAILPLATE"
    let NANO = _prefixId.prefix "NANO"
    let NATURALDRAFT = _prefixId.prefix "NATURALDRAFT"
    let NEGATIVE = _prefixId.prefix "NEGATIVE"
    let NETWORKAPPLIANCE = _prefixId.prefix "NETWORKAPPLIANCE"
    let NETWORKBRIDGE = _prefixId.prefix "NETWORKBRIDGE"
    let NETWORKHUB = _prefixId.prefix "NETWORKHUB"
    let NEWTON = _prefixId.prefix "NEWTON"
    let NOCHANGE = _prefixId.prefix "NOCHANGE"
    let NOTCH = _prefixId.prefix "NOTCH"
    let NOTDEFIEND = _prefixId.prefix "NOTDEFIEND"
    let NOTDEFINED = _prefixId.prefix "NOTDEFINED"
    let NOTEQUALTO = _prefixId.prefix "NOTEQUALTO"
    let NOTINCLUDEDIN = _prefixId.prefix "NOTINCLUDEDIN"
    let NOTINCLUDES = _prefixId.prefix "NOTINCLUDES"
    let NULL = _prefixId.prefix "NULL"
    let OBSTRUCTION = _prefixId.prefix "OBSTRUCTION"
    let OCCUPANCY = _prefixId.prefix "OCCUPANCY"
    let ODORFILTER = _prefixId.prefix "ODORFILTER"
    let OFFICE = _prefixId.prefix "OFFICE"
    let OHM = _prefixId.prefix "OHM"
    let OIL = _prefixId.prefix "OIL"
    let OILFILTER = _prefixId.prefix "OILFILTER"
    let OILMETER = _prefixId.prefix "OILMETER"
    let OLED = _prefixId.prefix "OLED"
    let OPENING = _prefixId.prefix "OPENING"
    let OPENTYPE = _prefixId.prefix "OPENTYPE"
    let OPERATION = _prefixId.prefix "OPERATION"
    let OPERATIONAL = _prefixId.prefix "OPERATIONAL"
    let OTHEROPERATION = _prefixId.prefix "OTHEROPERATION"
    let OTHER_CONSTRUCTION = _prefixId.prefix "OTHER_CONSTRUCTION"
    let OUTERSHELL = _prefixId.prefix "OUTERSHELL"
    let OUT_PLANE_LOADING_2D = _prefixId.prefix "OUT_PLANE_LOADING_2D"
    let OWNER = _prefixId.prefix "OWNER"
    let OXYGENGENERATOR = _prefixId.prefix "OXYGENGENERATOR"
    let OXYGENPLANT = _prefixId.prefix "OXYGENPLANT"
    let PAD_FOOTING = _prefixId.prefix "PAD_FOOTING"
    let PAINTING = _prefixId.prefix "PAINTING"
    let PANEL = _prefixId.prefix "PANEL"
    let PARABOLA = _prefixId.prefix "PARABOLA"
    let PARABOLIC_ARC = _prefixId.prefix "PARABOLIC_ARC"
    let PARAMETER = _prefixId.prefix "PARAMETER"
    let PARAPET = _prefixId.prefix "PARAPET"
    let PARKING = _prefixId.prefix "PARKING"
    let PARTIAL = _prefixId.prefix "PARTIAL"
    let PARTITIONING = _prefixId.prefix "PARTITIONING"
    let PASCAL = _prefixId.prefix "PASCAL"
    let PASSIVE = _prefixId.prefix "PASSIVE"
    let PAVILION_ROOF = _prefixId.prefix "PAVILION_ROOF"
    let PAVING = _prefixId.prefix "PAVING"
    let PERMANENT_G = _prefixId.prefix "PERMANENT_G"
    let PERSONAL = _prefixId.prefix "PERSONAL"
    let PETA = _prefixId.prefix "PETA"
    let PETROL = _prefixId.prefix "PETROL"
    let PHASEANGLEMETER = _prefixId.prefix "PHASEANGLEMETER"
    let PHONE = _prefixId.prefix "PHONE"
    let PHONG = _prefixId.prefix "PHONG"
    let PHOTOCOPIER = _prefixId.prefix "PHOTOCOPIER"
    let PHSENSOR = _prefixId.prefix "PHSENSOR"
    let PHUNIT = _prefixId.prefix "PHUNIT"
    let PHYSICAL = _prefixId.prefix "PHYSICAL"
    let PICO = _prefixId.prefix "PICO"
    let PIECEWISEBINARY = _prefixId.prefix "PIECEWISEBINARY"
    let PIECEWISECONSTANT = _prefixId.prefix "PIECEWISECONSTANT"
    let PIECEWISECONTINUOUS = _prefixId.prefix "PIECEWISECONTINUOUS"
    let PIECEWISE_BEZIER_KNOTS = _prefixId.prefix "PIECEWISE_BEZIER_KNOTS"
    let PILASTER = _prefixId.prefix "PILASTER"
    let PILE_CAP = _prefixId.prefix "PILE_CAP"
    let PIN_JOINED_MEMBER = _prefixId.prefix "PIN_JOINED_MEMBER"
    let PIPE = _prefixId.prefix "PIPE"
    let PIVOTHORIZONTAL = _prefixId.prefix "PIVOTHORIZONTAL"
    let PIVOTVERTICAL = _prefixId.prefix "PIVOTVERTICAL"
    let PLAIN = _prefixId.prefix "PLAIN"
    let PLANARFORCEUNIT = _prefixId.prefix "PLANARFORCEUNIT"
    let PLANEANGLEUNIT = _prefixId.prefix "PLANEANGLEUNIT"
    let PLANE_SURF = _prefixId.prefix "PLANE_SURF"
    let PLANNED = _prefixId.prefix "PLANNED"
    let PLAN_VIEW = _prefixId.prefix "PLAN_VIEW"
    let PLASTIC = _prefixId.prefix "PLASTIC"
    let PLATE = _prefixId.prefix "PLATE"
    let PLAYER = _prefixId.prefix "PLAYER"
    let PLUMBING = _prefixId.prefix "PLUMBING"
    let PLUMBINGWALL = _prefixId.prefix "PLUMBINGWALL"
    let PNEUMATICACTUATOR = _prefixId.prefix "PNEUMATICACTUATOR"
    let POINTSOURCE = _prefixId.prefix "POINTSOURCE"
    let POLYGONAL = _prefixId.prefix "POLYGONAL"
    let POLYLINE_FORM = _prefixId.prefix "POLYLINE_FORM"
    let POLYPHASE = _prefixId.prefix "POLYPHASE"
    let POSITIVE = _prefixId.prefix "POSITIVE"
    let POST = _prefixId.prefix "POST"
    let POWER = _prefixId.prefix "POWER"
    let POWERFACTORMETER = _prefixId.prefix "POWERFACTORMETER"
    let POWERGENERATION = _prefixId.prefix "POWERGENERATION"
    let POWEROUTLET = _prefixId.prefix "POWEROUTLET"
    let POWERUNIT = _prefixId.prefix "POWERUNIT"
    let PRECASTPANEL = _prefixId.prefix "PRECASTPANEL"
    let PRECAST_CONCRETE = _prefixId.prefix "PRECAST_CONCRETE"
    let PREDICTED = _prefixId.prefix "PREDICTED"
    let PREFAB_STEEL = _prefixId.prefix "PREFAB_STEEL"
    let PRESSUREGAUGE = _prefixId.prefix "PRESSUREGAUGE"
    let PRESSUREREDUCING = _prefixId.prefix "PRESSUREREDUCING"
    let PRESSURERELIEF = _prefixId.prefix "PRESSURERELIEF"
    let PRESSURESENSOR = _prefixId.prefix "PRESSURESENSOR"
    let PRESSUREUNIT = _prefixId.prefix "PRESSUREUNIT"
    let PRESSUREVESSEL = _prefixId.prefix "PRESSUREVESSEL"
    let PRESTRESSING_P = _prefixId.prefix "PRESTRESSING_P"
    let PRICEDBILLOFQUANTITIES = _prefixId.prefix "PRICEDBILLOFQUANTITIES"
    let PRINTER = _prefixId.prefix "PRINTER"
    let PROCESS = _prefixId.prefix "PROCESS"
    let PRODUCT = _prefixId.prefix "PRODUCT"
    let PROGRAMMABLE = _prefixId.prefix "PROGRAMMABLE"
    let PROJECT = _prefixId.prefix "PROJECT"
    let PROJECTED_LENGTH = _prefixId.prefix "PROJECTED_LENGTH"
    let PROJECTMANAGER = _prefixId.prefix "PROJECTMANAGER"
    let PROJECTOR = _prefixId.prefix "PROJECTOR"
    let PROPELLORAXIAL = _prefixId.prefix "PROPELLORAXIAL"
    let PROPORTIONAL = _prefixId.prefix "PROPORTIONAL"
    let PROPPING = _prefixId.prefix "PROPPING"
    let PROVISIONFORVOID = _prefixId.prefix "PROVISIONFORVOID"
    let PSET_OCCURRENCEDRIVEN = _prefixId.prefix "PSET_OCCURRENCEDRIVEN"
    let PSET_PERFORMANCEDRIVEN = _prefixId.prefix "PSET_PERFORMANCEDRIVEN"
    let PSET_TYPEDRIVENONLY = _prefixId.prefix "PSET_TYPEDRIVENONLY"
    let PSET_TYPEDRIVENOVERRIDE = _prefixId.prefix "PSET_TYPEDRIVENOVERRIDE"
    let PUBLIC = _prefixId.prefix "PUBLIC"
    let PUMPING = _prefixId.prefix "PUMPING"
    let PUNCHING = _prefixId.prefix "PUNCHING"
    let PURCHASE = _prefixId.prefix "PURCHASE"
    let PURCHASEORDER = _prefixId.prefix "PURCHASEORDER"
    let PURLIN = _prefixId.prefix "PURLIN"
    let P_BOUNDEDVALUE = _prefixId.prefix "P_BOUNDEDVALUE"
    let P_COMPLEX = _prefixId.prefix "P_COMPLEX"
    let P_ENUMERATEDVALUE = _prefixId.prefix "P_ENUMERATEDVALUE"
    let P_LISTVALUE = _prefixId.prefix "P_LISTVALUE"
    let P_REFERENCEVALUE = _prefixId.prefix "P_REFERENCEVALUE"
    let P_SINGLEVALUE = _prefixId.prefix "P_SINGLEVALUE"
    let P_TABLEVALUE = _prefixId.prefix "P_TABLEVALUE"
    let QTO_OCCURRENCEDRIVEN = _prefixId.prefix "QTO_OCCURRENCEDRIVEN"
    let QTO_TYPEDRIVENONLY = _prefixId.prefix "QTO_TYPEDRIVENONLY"
    let QTO_TYPEDRIVENOVERRIDE = _prefixId.prefix "QTO_TYPEDRIVENOVERRIDE"
    let QUADRIC_SURF = _prefixId.prefix "QUADRIC_SURF"
    let QUARTER_TURN_RAMP = _prefixId.prefix "QUARTER_TURN_RAMP"
    let QUARTER_TURN_STAIR = _prefixId.prefix "QUARTER_TURN_STAIR"
    let QUARTER_WINDING_STAIR = _prefixId.prefix "QUARTER_WINDING_STAIR"
    let QUASI_UNIFORM_KNOTS = _prefixId.prefix "QUASI_UNIFORM_KNOTS"
    let Q_AREA = _prefixId.prefix "Q_AREA"
    let Q_COMPLEX = _prefixId.prefix "Q_COMPLEX"
    let Q_COUNT = _prefixId.prefix "Q_COUNT"
    let Q_LENGTH = _prefixId.prefix "Q_LENGTH"
    let Q_TIME = _prefixId.prefix "Q_TIME"
    let Q_VOLUME = _prefixId.prefix "Q_VOLUME"
    let Q_WEIGHT = _prefixId.prefix "Q_WEIGHT"
    let RADIAL = _prefixId.prefix "RADIAL"
    let RADIAN = _prefixId.prefix "RADIAN"
    let RADIATIONSENSOR = _prefixId.prefix "RADIATIONSENSOR"
    let RADIATOR = _prefixId.prefix "RADIATOR"
    let RADIOACTIVITYSENSOR = _prefixId.prefix "RADIOACTIVITYSENSOR"
    let RADIOACTIVITYUNIT = _prefixId.prefix "RADIOACTIVITYUNIT"
    let RAFTER = _prefixId.prefix "RAFTER"
    let RAIN = _prefixId.prefix "RAIN"
    let RAINBOW_ROOF = _prefixId.prefix "RAINBOW_ROOF"
    let RAINWATER = _prefixId.prefix "RAINWATER"
    let RAINWATERHOPPER = _prefixId.prefix "RAINWATERHOPPER"
    let READONLY = _prefixId.prefix "READONLY"
    let READONLYLOCKED = _prefixId.prefix "READONLYLOCKED"
    let READWRITE = _prefixId.prefix "READWRITE"
    let READWRITELOCKED = _prefixId.prefix "READWRITELOCKED"
    let RECEIVER = _prefixId.prefix "RECEIVER"
    let RECESS = _prefixId.prefix "RECESS"
    let RECIPROCATING = _prefixId.prefix "RECIPROCATING"
    let RECTANGULAR = _prefixId.prefix "RECTANGULAR"
    let RECTIFIER = _prefixId.prefix "RECTIFIER"
    let REDUCER = _prefixId.prefix "REDUCER"
    let REFLECTED_PLAN_VIEW = _prefixId.prefix "REFLECTED_PLAN_VIEW"
    let REFRIGERATION = _prefixId.prefix "REFRIGERATION"
    let REFRIGERATOR = _prefixId.prefix "REFRIGERATOR"
    let REGISTER = _prefixId.prefix "REGISTER"
    let REGULATING = _prefixId.prefix "REGULATING"
    let REINFORCEMENT_UNIT = _prefixId.prefix "REINFORCEMENT_UNIT"
    let RELAY = _prefixId.prefix "RELAY"
    let RELIEFDAMPER = _prefixId.prefix "RELIEFDAMPER"
    let RELUCTANCESYNCHRONOUS = _prefixId.prefix "RELUCTANCESYNCHRONOUS"
    let REMOVABLECASEMENT = _prefixId.prefix "REMOVABLECASEMENT"
    let REMOVAL = _prefixId.prefix "REMOVAL"
    let RENOVATION = _prefixId.prefix "RENOVATION"
    let REPEATER = _prefixId.prefix "REPEATER"
    let REQUIREMENT = _prefixId.prefix "REQUIREMENT"
    let RESELLER = _prefixId.prefix "RESELLER"
    let RESIDUALCURRENT = _prefixId.prefix "RESIDUALCURRENT"
    let RESIDUALCURRENTCIRCUITBREAKER = _prefixId.prefix "RESIDUALCURRENTCIRCUITBREAKER"
    let RESIDUALCURRENTSWITCH = _prefixId.prefix "RESIDUALCURRENTSWITCH"
    let RESOURCE = _prefixId.prefix "RESOURCE"
    let RESTRICTED = _prefixId.prefix "RESTRICTED"
    let REVISION = _prefixId.prefix "REVISION"
    let REVOLVING = _prefixId.prefix "REVOLVING"
    let RIGHT = _prefixId.prefix "RIGHT"
    let RIGIDSEGMENT = _prefixId.prefix "RIGIDSEGMENT"
    let RIGID_FRAME = _prefixId.prefix "RIGID_FRAME"
    let RIGID_JOINED_MEMBER = _prefixId.prefix "RIGID_JOINED_MEMBER"
    let RING = _prefixId.prefix "RING"
    let RIVET = _prefixId.prefix "RIVET"
    let ROLLINGPISTON = _prefixId.prefix "ROLLINGPISTON"
    let ROLLINGUP = _prefixId.prefix "ROLLINGUP"
    let ROOF = _prefixId.prefix "ROOF"
    let ROOFDRAIN = _prefixId.prefix "ROOFDRAIN"
    let ROOFING = _prefixId.prefix "ROOFING"
    let ROOFTOPUNIT = _prefixId.prefix "ROOFTOPUNIT"
    let ROTARY = _prefixId.prefix "ROTARY"
    let ROTARYVANE = _prefixId.prefix "ROTARYVANE"
    let ROTARYWHEEL = _prefixId.prefix "ROTARYWHEEL"
    let ROTATIONALFREQUENCYUNIT = _prefixId.prefix "ROTATIONALFREQUENCYUNIT"
    let ROTATIONALMASSUNIT = _prefixId.prefix "ROTATIONALMASSUNIT"
    let ROTATIONALSTIFFNESSUNIT = _prefixId.prefix "ROTATIONALSTIFFNESSUNIT"
    let ROUND = _prefixId.prefix "ROUND"
    let ROUTER = _prefixId.prefix "ROUTER"
    let RULED_SURF = _prefixId.prefix "RULED_SURF"
    let RUNAROUNDCOILLOOP = _prefixId.prefix "RUNAROUNDCOILLOOP"
    let SAFETYCUTOFF = _prefixId.prefix "SAFETYCUTOFF"
    let SANITARYFOUNTAIN = _prefixId.prefix "SANITARYFOUNTAIN"
    let SCANNER = _prefixId.prefix "SCANNER"
    let SCHEDULEOFRATES = _prefixId.prefix "SCHEDULEOFRATES"
    let SCREEN = _prefixId.prefix "SCREEN"
    let SCREW = _prefixId.prefix "SCREW"
    let SCROLL = _prefixId.prefix "SCROLL"
    let SECOND = _prefixId.prefix "SECOND"
    let SECONDSHIFT = _prefixId.prefix "SECONDSHIFT"
    let SECOND_ORDER_THEORY = _prefixId.prefix "SECOND_ORDER_THEORY"
    let SECTIONAREAINTEGRALUNIT = _prefixId.prefix "SECTIONAREAINTEGRALUNIT"
    let SECTIONMODULUSUNIT = _prefixId.prefix "SECTIONMODULUSUNIT"
    let SECTION_VIEW = _prefixId.prefix "SECTION_VIEW"
    let SECURITY = _prefixId.prefix "SECURITY"
    let SECURITYLIGHTING = _prefixId.prefix "SECURITYLIGHTING"
    let SELECTORSWITCH = _prefixId.prefix "SELECTORSWITCH"
    let SEMIHERMETIC = _prefixId.prefix "SEMIHERMETIC"
    let SETTLEMENT_U = _prefixId.prefix "SETTLEMENT_U"
    let SEWAGE = _prefixId.prefix "SEWAGE"
    let SHADING = _prefixId.prefix "SHADING"
    let SHEAR = _prefixId.prefix "SHEAR"
    let SHEARCONNECTOR = _prefixId.prefix "SHEARCONNECTOR"
    let SHEARMODULUSUNIT = _prefixId.prefix "SHEARMODULUSUNIT"
    let SHED_ROOF = _prefixId.prefix "SHED_ROOF"
    let SHEET = _prefixId.prefix "SHEET"
    let SHELF = _prefixId.prefix "SHELF"
    let SHELL = _prefixId.prefix "SHELL"
    let SHELLANDCOIL = _prefixId.prefix "SHELLANDCOIL"
    let SHELLANDTUBE = _prefixId.prefix "SHELLANDTUBE"
    let SHOE = _prefixId.prefix "SHOE"
    let SHOWER = _prefixId.prefix "SHOWER"
    let SHRINKAGE = _prefixId.prefix "SHRINKAGE"
    let SHUTDOWN = _prefixId.prefix "SHUTDOWN"
    let SHUTTER = _prefixId.prefix "SHUTTER"
    let SIDEHUNGLEFTHAND = _prefixId.prefix "SIDEHUNGLEFTHAND"
    let SIDEHUNGRIGHTHAND = _prefixId.prefix "SIDEHUNGRIGHTHAND"
    let SIEMENS = _prefixId.prefix "SIEMENS"
    let SIEVERT = _prefixId.prefix "SIEVERT"
    let SIGNAL = _prefixId.prefix "SIGNAL"
    let SIMULATED = _prefixId.prefix "SIMULATED"
    let SINGLESCREW = _prefixId.prefix "SINGLESCREW"
    let SINGLESTAGE = _prefixId.prefix "SINGLESTAGE"
    let SINGLE_PANEL = _prefixId.prefix "SINGLE_PANEL"
    let SINGLE_SWING_LEFT = _prefixId.prefix "SINGLE_SWING_LEFT"
    let SINGLE_SWING_RIGHT = _prefixId.prefix "SINGLE_SWING_RIGHT"
    let SINK = _prefixId.prefix "SINK"
    let SINUS = _prefixId.prefix "SINUS"
    let SIREN = _prefixId.prefix "SIREN"
    let SITE = _prefixId.prefix "SITE"
    let SITEGRADING = _prefixId.prefix "SITEGRADING"
    let SKETCH_VIEW = _prefixId.prefix "SKETCH_VIEW"
    let SKIRTINGBOARD = _prefixId.prefix "SKIRTINGBOARD"
    let SKYLIGHT = _prefixId.prefix "SKYLIGHT"
    let SLAB_FIELD = _prefixId.prefix "SLAB_FIELD"
    let SLEEVING = _prefixId.prefix "SLEEVING"
    let SLIDING = _prefixId.prefix "SLIDING"
    let SLIDINGHORIZONTAL = _prefixId.prefix "SLIDINGHORIZONTAL"
    let SLIDINGVERTICAL = _prefixId.prefix "SLIDINGVERTICAL"
    let SLIDING_TO_LEFT = _prefixId.prefix "SLIDING_TO_LEFT"
    let SLIDING_TO_RIGHT = _prefixId.prefix "SLIDING_TO_RIGHT"
    let SMOKEDAMPER = _prefixId.prefix "SMOKEDAMPER"
    let SMOKESENSOR = _prefixId.prefix "SMOKESENSOR"
    let SNOW_S = _prefixId.prefix "SNOW_S"
    let SOFA = _prefixId.prefix "SOFA"
    let SOFT = _prefixId.prefix "SOFT"
    let SOLARCOLLECTOR = _prefixId.prefix "SOLARCOLLECTOR"
    let SOLARPANEL = _prefixId.prefix "SOLARPANEL"
    let SOLIDANGLEUNIT = _prefixId.prefix "SOLIDANGLEUNIT"
    let SOLIDWALL = _prefixId.prefix "SOLIDWALL"
    let SOUNDPOWERLEVELUNIT = _prefixId.prefix "SOUNDPOWERLEVELUNIT"
    let SOUNDPOWERUNIT = _prefixId.prefix "SOUNDPOWERUNIT"
    let SOUNDPRESSURELEVELUNIT = _prefixId.prefix "SOUNDPRESSURELEVELUNIT"
    let SOUNDPRESSUREUNIT = _prefixId.prefix "SOUNDPRESSUREUNIT"
    let SOUNDSENSOR = _prefixId.prefix "SOUNDSENSOR"
    let SOURCE = _prefixId.prefix "SOURCE"
    let SOURCEANDSINK = _prefixId.prefix "SOURCEANDSINK"
    let SPACE = _prefixId.prefix "SPACE"
    let SPACEINVENTORY = _prefixId.prefix "SPACEINVENTORY"
    let SPANDREL = _prefixId.prefix "SPANDREL"
    let SPEAKER = _prefixId.prefix "SPEAKER"
    let SPECIFICATION = _prefixId.prefix "SPECIFICATION"
    let SPECIFICHEATCAPACITYUNIT = _prefixId.prefix "SPECIFICHEATCAPACITYUNIT"
    let SPHERICAL_SURF = _prefixId.prefix "SPHERICAL_SURF"
    let SPIRAL = _prefixId.prefix "SPIRAL"
    let SPIRAL_RAMP = _prefixId.prefix "SPIRAL_RAMP"
    let SPIRAL_STAIR = _prefixId.prefix "SPIRAL_STAIR"
    let SPLITCASE = _prefixId.prefix "SPLITCASE"
    let SPLITSYSTEM = _prefixId.prefix "SPLITSYSTEM"
    let SPOOL = _prefixId.prefix "SPOOL"
    let SPRING = _prefixId.prefix "SPRING"
    let SPRINKLER = _prefixId.prefix "SPRINKLER"
    let SPRINKLERDEFLECTOR = _prefixId.prefix "SPRINKLERDEFLECTOR"
    let SQUARE_METRE = _prefixId.prefix "SQUARE_METRE"
    let STANDALONE = _prefixId.prefix "STANDALONE"
    let STANDARD = _prefixId.prefix "STANDARD"
    let STAPLE = _prefixId.prefix "STAPLE"
    let STARTER = _prefixId.prefix "STARTER"
    let STARTEVENT = _prefixId.prefix "STARTEVENT"
    let STARTUP = _prefixId.prefix "STARTUP"
    let START_FINISH = _prefixId.prefix "START_FINISH"
    let START_START = _prefixId.prefix "START_START"
    let STEAM = _prefixId.prefix "STEAM"
    let STEAMHEATINGCOIL = _prefixId.prefix "STEAMHEATINGCOIL"
    let STEAMINJECTION = _prefixId.prefix "STEAMINJECTION"
    let STEAMTRAP = _prefixId.prefix "STEAMTRAP"
    let STEEL = _prefixId.prefix "STEEL"
    let STEELWORK = _prefixId.prefix "STEELWORK"
    let STERADIAN = _prefixId.prefix "STERADIAN"
    let STOPCOCK = _prefixId.prefix "STOPCOCK"
    let STORAGE = _prefixId.prefix "STORAGE"
    let STORMWATER = _prefixId.prefix "STORMWATER"
    let STRAIGHT = _prefixId.prefix "STRAIGHT"
    let STRAIGHT_RUN_RAMP = _prefixId.prefix "STRAIGHT_RUN_RAMP"
    let STRAIGHT_RUN_STAIR = _prefixId.prefix "STRAIGHT_RUN_STAIR"
    let STRAINER = _prefixId.prefix "STRAINER"
    let STRAND = _prefixId.prefix "STRAND"
    let STRAUSS = _prefixId.prefix "STRAUSS"
    let STRINGER = _prefixId.prefix "STRINGER"
    let STRIP_FOOTING = _prefixId.prefix "STRIP_FOOTING"
    let STRUCTURALENGINEER = _prefixId.prefix "STRUCTURALENGINEER"
    let STRUT = _prefixId.prefix "STRUT"
    let STUD = _prefixId.prefix "STUD"
    let STUDSHEARCONNECTOR = _prefixId.prefix "STUDSHEARCONNECTOR"
    let SUBCONTRACTOR = _prefixId.prefix "SUBCONTRACTOR"
    let SUBMERSIBLEPUMP = _prefixId.prefix "SUBMERSIBLEPUMP"
    let SUBTRACT = _prefixId.prefix "SUBTRACT"
    let SUMP = _prefixId.prefix "SUMP"
    let SUMPPUMP = _prefixId.prefix "SUMPPUMP"
    let SUPPLIER = _prefixId.prefix "SUPPLIER"
    let SUPPORT = _prefixId.prefix "SUPPORT"
    let SURF_OF_LINEAR_EXTRUSION = _prefixId.prefix "SURF_OF_LINEAR_EXTRUSION"
    let SURF_OF_REVOLUTION = _prefixId.prefix "SURF_OF_REVOLUTION"
    let SURVEYING = _prefixId.prefix "SURVEYING"
    let SWINGING = _prefixId.prefix "SWINGING"
    let SWING_FIXED_LEFT = _prefixId.prefix "SWING_FIXED_LEFT"
    let SWING_FIXED_RIGHT = _prefixId.prefix "SWING_FIXED_RIGHT"
    let SWITCHBOARD = _prefixId.prefix "SWITCHBOARD"
    let SWITCHDISCONNECTOR = _prefixId.prefix "SWITCHDISCONNECTOR"
    let SWITCHER = _prefixId.prefix "SWITCHER"
    let SYNCHRONOUS = _prefixId.prefix "SYNCHRONOUS"
    let SYSTEM_IMPERFECTION = _prefixId.prefix "SYSTEM_IMPERFECTION"
    let TABLE = _prefixId.prefix "TABLE"
    let TAG = _prefixId.prefix "TAG"
    let TAPERED = _prefixId.prefix "TAPERED"
    let TEE = _prefixId.prefix "TEE"
    let TELEPHONE = _prefixId.prefix "TELEPHONE"
    let TELEPHONEOUTLET = _prefixId.prefix "TELEPHONEOUTLET"
    let TEMPERATUREGRADIENTUNIT = _prefixId.prefix "TEMPERATUREGRADIENTUNIT"
    let TEMPERATURERATEOFCHANGEUNIT = _prefixId.prefix "TEMPERATURERATEOFCHANGEUNIT"
    let TEMPERATURESENSOR = _prefixId.prefix "TEMPERATURESENSOR"
    let TEMPERATURE_T = _prefixId.prefix "TEMPERATURE_T"
    let TENANT = _prefixId.prefix "TENANT"
    let TENDER = _prefixId.prefix "TENDER"
    let TENSIONING_END = _prefixId.prefix "TENSIONING_END"
    let TENSION_MEMBER = _prefixId.prefix "TENSION_MEMBER"
    let TERA = _prefixId.prefix "TERA"
    let TERRAIN = _prefixId.prefix "TERRAIN"
    let TESLA = _prefixId.prefix "TESLA"
    let TEXTURED = _prefixId.prefix "TEXTURED"
    let THERMAL = _prefixId.prefix "THERMAL"
    let THERMALADMITTANCEUNIT = _prefixId.prefix "THERMALADMITTANCEUNIT"
    let THERMALCONDUCTANCEUNIT = _prefixId.prefix "THERMALCONDUCTANCEUNIT"

    let THERMALEXPANSIONCOEFFICIENTUNIT = _prefixId.prefix "THERMALEXPANSIONCOEFFICIENTUNIT"

    let THERMALRESISTANCEUNIT = _prefixId.prefix "THERMALRESISTANCEUNIT"
    let THERMALTRANSMITTANCEUNIT = _prefixId.prefix "THERMALTRANSMITTANCEUNIT"
    let THERMODYNAMICTEMPERATUREUNIT = _prefixId.prefix "THERMODYNAMICTEMPERATUREUNIT"
    let THERMOMETER = _prefixId.prefix "THERMOMETER"

    let THERMOSIPHONCOILTYPEHEATEXCHANGERS = _prefixId.prefix "THERMOSIPHONCOILTYPEHEATEXCHANGERS"

    let THERMOSIPHONSEALEDTUBEHEATEXCHANGERS = _prefixId.prefix "THERMOSIPHONSEALEDTUBEHEATEXCHANGERS"

    let THERMOSTAT = _prefixId.prefix "THERMOSTAT"
    let THERMOSTATICACTUATOR = _prefixId.prefix "THERMOSTATICACTUATOR"
    let THIRDSHIFT = _prefixId.prefix "THIRDSHIFT"
    let THIRD_ORDER_THEORY = _prefixId.prefix "THIRD_ORDER_THEORY"
    let THREE_QUARTER_TURN_STAIR = _prefixId.prefix "THREE_QUARTER_TURN_STAIR"
    let THREE_QUARTER_WINDING_STAIR = _prefixId.prefix "THREE_QUARTER_WINDING_STAIR"
    let TILTANDTURNLEFTHAND = _prefixId.prefix "TILTANDTURNLEFTHAND"
    let TILTANDTURNRIGHTHAND = _prefixId.prefix "TILTANDTURNRIGHTHAND"
    let TIMECLOCK = _prefixId.prefix "TIMECLOCK"
    let TIMEDELAY = _prefixId.prefix "TIMEDELAY"
    let TIMEUNIT = _prefixId.prefix "TIMEUNIT"
    let TOGGLESWITCH = _prefixId.prefix "TOGGLESWITCH"
    let TOILETPAN = _prefixId.prefix "TOILETPAN"
    let TOP = _prefixId.prefix "TOP"
    let TOPHUNG = _prefixId.prefix "TOPHUNG"
    let TOROIDAL_SURF = _prefixId.prefix "TOROIDAL_SURF"
    let TORQUEUNIT = _prefixId.prefix "TORQUEUNIT"
    let TRANSITION = _prefixId.prefix "TRANSITION"
    let TRANSPORT = _prefixId.prefix "TRANSPORT"
    let TRANSPORTING = _prefixId.prefix "TRANSPORTING"
    let TRAPDOOR = _prefixId.prefix "TRAPDOOR"
    let TREATMENT = _prefixId.prefix "TREATMENT"
    let TRENCH = _prefixId.prefix "TRENCH"
    let TRIANGULAR = _prefixId.prefix "TRIANGULAR"
    let TRIGGERCONDITION = _prefixId.prefix "TRIGGERCONDITION"
    let TRIPLE_PANEL_BOTTOM = _prefixId.prefix "TRIPLE_PANEL_BOTTOM"
    let TRIPLE_PANEL_HORIZONTAL = _prefixId.prefix "TRIPLE_PANEL_HORIZONTAL"
    let TRIPLE_PANEL_LEFT = _prefixId.prefix "TRIPLE_PANEL_LEFT"
    let TRIPLE_PANEL_RIGHT = _prefixId.prefix "TRIPLE_PANEL_RIGHT"
    let TRIPLE_PANEL_TOP = _prefixId.prefix "TRIPLE_PANEL_TOP"
    let TRIPLE_PANEL_VERTICAL = _prefixId.prefix "TRIPLE_PANEL_VERTICAL"
    let TROCHOIDAL = _prefixId.prefix "TROCHOIDAL"
    let TRUE_LENGTH = _prefixId.prefix "TRUE_LENGTH"
    let TRUSS = _prefixId.prefix "TRUSS"
    let TUBEAXIAL = _prefixId.prefix "TUBEAXIAL"
    let TUMBLEDRYER = _prefixId.prefix "TUMBLEDRYER"
    let TUNER = _prefixId.prefix "TUNER"
    let TUNGSTENFILAMENT = _prefixId.prefix "TUNGSTENFILAMENT"
    let TV = _prefixId.prefix "TV"
    let TWINSCREW = _prefixId.prefix "TWINSCREW"

    let TWINTOWERENTHALPYRECOVERYLOOPS = _prefixId.prefix "TWINTOWERENTHALPYRECOVERYLOOPS"

    let TWOPOSITION = _prefixId.prefix "TWOPOSITION"
    let TWO_CURVED_RUN_STAIR = _prefixId.prefix "TWO_CURVED_RUN_STAIR"
    let TWO_QUARTER_TURN_RAMP = _prefixId.prefix "TWO_QUARTER_TURN_RAMP"
    let TWO_QUARTER_TURN_STAIR = _prefixId.prefix "TWO_QUARTER_TURN_STAIR"
    let TWO_QUARTER_WINDING_STAIR = _prefixId.prefix "TWO_QUARTER_WINDING_STAIR"
    let TWO_STRAIGHT_RUN_RAMP = _prefixId.prefix "TWO_STRAIGHT_RUN_RAMP"
    let TWO_STRAIGHT_RUN_STAIR = _prefixId.prefix "TWO_STRAIGHT_RUN_STAIR"
    let TYPE_A = _prefixId.prefix "TYPE_A"
    let TYPE_B = _prefixId.prefix "TYPE_B"
    let TYPE_C = _prefixId.prefix "TYPE_C"
    let T_BEAM = _prefixId.prefix "T_BEAM"
    let UNIFORM = _prefixId.prefix "UNIFORM"
    let UNIFORM_KNOTS = _prefixId.prefix "UNIFORM_KNOTS"
    let UNION = _prefixId.prefix "UNION"
    let UNPRICEDBILLOFQUANTITIES = _prefixId.prefix "UNPRICEDBILLOFQUANTITIES"
    let UNSPECIFIED = _prefixId.prefix "UNSPECIFIED"
    let UP = _prefixId.prefix "UP"
    let UPS = _prefixId.prefix "UPS"
    let URINAL = _prefixId.prefix "URINAL"
    let USERDEFINED = _prefixId.prefix "USERDEFINED"
    let VACUUM = _prefixId.prefix "VACUUM"
    let VACUUMSTATION = _prefixId.prefix "VACUUMSTATION"
    let VALVECHAMBER = _prefixId.prefix "VALVECHAMBER"
    let VANEAXIAL = _prefixId.prefix "VANEAXIAL"
    let VAPORPERMEABILITYUNIT = _prefixId.prefix "VAPORPERMEABILITYUNIT"
    let VARIABLEFLOWPRESSUREDEPENDANT = _prefixId.prefix "VARIABLEFLOWPRESSUREDEPENDANT"

    let VARIABLEFLOWPRESSUREINDEPENDANT = _prefixId.prefix "VARIABLEFLOWPRESSUREINDEPENDANT"

    let VARIABLE_Q = _prefixId.prefix "VARIABLE_Q"
    let VARISTOR = _prefixId.prefix "VARISTOR"
    let VENDINGMACHINE = _prefixId.prefix "VENDINGMACHINE"
    let VENT = _prefixId.prefix "VENT"
    let VENTILATION = _prefixId.prefix "VENTILATION"
    let VERBAL = _prefixId.prefix "VERBAL"
    let VERTICALINLINE = _prefixId.prefix "VERTICALINLINE"
    let VERTICALTURBINE = _prefixId.prefix "VERTICALTURBINE"
    let VESSEL = _prefixId.prefix "VESSEL"
    let VIRTUAL = _prefixId.prefix "VIRTUAL"
    let VOLT = _prefixId.prefix "VOLT"
    let VOLTAGE = _prefixId.prefix "VOLTAGE"
    let VOLTMETER_PEAK = _prefixId.prefix "VOLTMETER_PEAK"
    let VOLTMETER_RMS = _prefixId.prefix "VOLTMETER_RMS"
    let VOLUMETRICFLOWRATEUNIT = _prefixId.prefix "VOLUMETRICFLOWRATEUNIT"
    let VOLUMEUNIT = _prefixId.prefix "VOLUMEUNIT"
    let WARPINGCONSTANTUNIT = _prefixId.prefix "WARPINGCONSTANTUNIT"
    let WARPINGMOMENTUNIT = _prefixId.prefix "WARPINGMOMENTUNIT"
    let WASHHANDBASIN = _prefixId.prefix "WASHHANDBASIN"
    let WASHINGMACHINE = _prefixId.prefix "WASHINGMACHINE"
    let WASTEDISPOSALUNIT = _prefixId.prefix "WASTEDISPOSALUNIT"
    let WASTETRAP = _prefixId.prefix "WASTETRAP"
    let WASTEWATER = _prefixId.prefix "WASTEWATER"
    let WATER = _prefixId.prefix "WATER"
    let WATERCOOLED = _prefixId.prefix "WATERCOOLED"
    let WATERCOOLEDBRAZEDPLATE = _prefixId.prefix "WATERCOOLEDBRAZEDPLATE"
    let WATERCOOLEDSHELLCOIL = _prefixId.prefix "WATERCOOLEDSHELLCOIL"
    let WATERCOOLEDSHELLTUBE = _prefixId.prefix "WATERCOOLEDSHELLTUBE"
    let WATERCOOLEDTUBEINTUBE = _prefixId.prefix "WATERCOOLEDTUBEINTUBE"
    let WATERCOOLINGCOIL = _prefixId.prefix "WATERCOOLINGCOIL"
    let WATERFILTER = _prefixId.prefix "WATERFILTER"
    let WATERHEATINGCOIL = _prefixId.prefix "WATERHEATINGCOIL"
    let WATERMETER = _prefixId.prefix "WATERMETER"
    let WATERSUPPLY = _prefixId.prefix "WATERSUPPLY"
    let WATT = _prefixId.prefix "WATT"
    let WAVE = _prefixId.prefix "WAVE"
    let WCSEAT = _prefixId.prefix "WCSEAT"
    let WEATHERSTATION = _prefixId.prefix "WEATHERSTATION"
    let WEBER = _prefixId.prefix "WEBER"
    let WEEKLY = _prefixId.prefix "WEEKLY"
    let WELD = _prefixId.prefix "WELD"
    let WELDEDSHELLHERMETIC = _prefixId.prefix "WELDEDSHELLHERMETIC"
    let WHISTLE = _prefixId.prefix "WHISTLE"
    let WINDER = _prefixId.prefix "WINDER"
    let WINDOW = _prefixId.prefix "WINDOW"
    let WINDSENSOR = _prefixId.prefix "WINDSENSOR"
    let WIND_W = _prefixId.prefix "WIND_W"
    let WIRE = _prefixId.prefix "WIRE"
    let WOOD = _prefixId.prefix "WOOD"
    let WORK = _prefixId.prefix "WORK"
    let WORKORDER = _prefixId.prefix "WORKORDER"
    let WORKSURFACE = _prefixId.prefix "WORKSURFACE"
    let WORKTIME = _prefixId.prefix "WORKTIME"
    let WRAPPING = _prefixId.prefix "WRAPPING"
    let YEARLY_BY_DAY_OF_MONTH = _prefixId.prefix "YEARLY_BY_DAY_OF_MONTH"
    let YEARLY_BY_POSITION = _prefixId.prefix "YEARLY_BY_POSITION"

    /// <summary>
    ///   <para>rdfs:label : AccessState^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#accessState_IfcSimplePropertyTemplate">ifc:accessState_IfcSimplePropertyTemplate</a>
    /// </summary>
    let accessState_IfcSimplePropertyTemplate = _prefixId.prefix "accessState_IfcSimplePropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : ActingRole^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actingRole_IfcRelAssignsToActor">ifc:actingRole_IfcRelAssignsToActor</a>
    /// </summary>
    let actingRole_IfcRelAssignsToActor = _prefixId.prefix "actingRole_IfcRelAssignsToActor"

    /// <summary>
    ///   <para>rdfs:label : ActionSource^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actionSource_IfcStructuralLoadGroup">ifc:actionSource_IfcStructuralLoadGroup</a>
    /// </summary>
    let actionSource_IfcStructuralLoadGroup = _prefixId.prefix "actionSource_IfcStructuralLoadGroup"

    /// <summary>
    ///   <para>rdfs:label : ActionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actionType_IfcStructuralLoadGroup">ifc:actionType_IfcStructuralLoadGroup</a>
    /// </summary>
    let actionType_IfcStructuralLoadGroup = _prefixId.prefix "actionType_IfcStructuralLoadGroup"

    /// <summary>
    ///   <para>rdfs:label : ActualDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actualDate_IfcEventTime">ifc:actualDate_IfcEventTime</a>
    /// </summary>
    let actualDate_IfcEventTime = _prefixId.prefix "actualDate_IfcEventTime"
    /// <summary>
    ///   <para>rdfs:label : ActualDuration^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actualDuration_IfcTaskTime">ifc:actualDuration_IfcTaskTime</a>
    /// </summary>
    let actualDuration_IfcTaskTime = _prefixId.prefix "actualDuration_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : ActualFinish^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actualFinish_IfcResourceTime">ifc:actualFinish_IfcResourceTime</a>
    /// </summary>
    let actualFinish_IfcResourceTime = _prefixId.prefix "actualFinish_IfcResourceTime"
    /// <summary>
    ///   <para>rdfs:label : ActualFinish^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actualFinish_IfcTaskTime">ifc:actualFinish_IfcTaskTime</a>
    /// </summary>
    let actualFinish_IfcTaskTime = _prefixId.prefix "actualFinish_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : ActualStart^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actualStart_IfcResourceTime">ifc:actualStart_IfcResourceTime</a>
    /// </summary>
    let actualStart_IfcResourceTime = _prefixId.prefix "actualStart_IfcResourceTime"
    /// <summary>
    ///   <para>rdfs:label : ActualStart^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actualStart_IfcTaskTime">ifc:actualStart_IfcTaskTime</a>
    /// </summary>
    let actualStart_IfcTaskTime = _prefixId.prefix "actualStart_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : ActualUsage^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actualUsage_IfcResourceTime">ifc:actualUsage_IfcResourceTime</a>
    /// </summary>
    let actualUsage_IfcResourceTime = _prefixId.prefix "actualUsage_IfcResourceTime"
    /// <summary>
    ///   <para>rdfs:label : ActualWork^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#actualWork_IfcResourceTime">ifc:actualWork_IfcResourceTime</a>
    /// </summary>
    let actualWork_IfcResourceTime = _prefixId.prefix "actualWork_IfcResourceTime"

    /// <summary>
    ///   <para>rdfs:label : AdditionalConditions^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#additionalConditions_IfcRelConnectsStructuralMember">ifc:additionalConditions_IfcRelConnectsStructuralMember</a>
    /// </summary>
    let additionalConditions_IfcRelConnectsStructuralMember = _prefixId.prefix "additionalConditions_IfcRelConnectsStructuralMember"

    /// <summary>
    ///   <para>rdfs:label : AddressLines^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#addressLines_IfcPostalAddress">ifc:addressLines_IfcPostalAddress</a>
    /// </summary>
    let addressLines_IfcPostalAddress = _prefixId.prefix "addressLines_IfcPostalAddress"
    /// <summary>
    ///   <para>rdfs:label : Addresses^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#addresses_IfcOrganization">ifc:addresses_IfcOrganization</a>
    /// </summary>
    let addresses_IfcOrganization = _prefixId.prefix "addresses_IfcOrganization"
    /// <summary>
    ///   <para>rdfs:label : Addresses^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#addresses_IfcPerson">ifc:addresses_IfcPerson</a>
    /// </summary>
    let addresses_IfcPerson = _prefixId.prefix "addresses_IfcPerson"

    /// <summary>
    ///   <para>rdfs:label : AgreementFlag^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#agreementFlag_IfcHalfSpaceSolid">ifc:agreementFlag_IfcHalfSpaceSolid</a>
    /// </summary>
    let agreementFlag_IfcHalfSpaceSolid = _prefixId.prefix "agreementFlag_IfcHalfSpaceSolid"

    /// <summary>
    ///   <para>rdfs:label : AmbientIntensity^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#ambientIntensity_IfcLightSource">ifc:ambientIntensity_IfcLightSource</a>
    /// </summary>
    let ambientIntensity_IfcLightSource = _prefixId.prefix "ambientIntensity_IfcLightSource"

    /// <summary>
    ///   <para>rdfs:label : AmountOfSubstanceExponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#amountOfSubstanceExponent_IfcDimensionalExponents">ifc:amountOfSubstanceExponent_IfcDimensionalExponents</a>
    /// </summary>
    let amountOfSubstanceExponent_IfcDimensionalExponents = _prefixId.prefix "amountOfSubstanceExponent_IfcDimensionalExponents"

    /// <summary>
    ///   <para>rdfs:label : AnchorageSlip^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#anchorageSlip_IfcTendon">ifc:anchorageSlip_IfcTendon</a>
    /// </summary>
    let anchorageSlip_IfcTendon = _prefixId.prefix "anchorageSlip_IfcTendon"
    /// <summary>
    ///   <para>rdfs:label : Angle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#angle_IfcRevolvedAreaSolid">ifc:angle_IfcRevolvedAreaSolid</a>
    /// </summary>
    let angle_IfcRevolvedAreaSolid = _prefixId.prefix "angle_IfcRevolvedAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : ApplicableDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#applicableDate_IfcAppliedValue">ifc:applicableDate_IfcAppliedValue</a>
    /// </summary>
    let applicableDate_IfcAppliedValue = _prefixId.prefix "applicableDate_IfcAppliedValue"

    /// <summary>
    ///   <para>rdfs:label : ApplicableEntity^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#applicableEntity_IfcPropertySetTemplate">ifc:applicableEntity_IfcPropertySetTemplate</a>
    /// </summary>
    let applicableEntity_IfcPropertySetTemplate = _prefixId.prefix "applicableEntity_IfcPropertySetTemplate"

    /// <summary>
    ///   <para>rdfs:label : ApplicableOccurrence^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#applicableOccurrence_IfcTypeObject">ifc:applicableOccurrence_IfcTypeObject</a>
    /// </summary>
    let applicableOccurrence_IfcTypeObject = _prefixId.prefix "applicableOccurrence_IfcTypeObject"

    /// <summary>
    ///   <para>rdfs:label : ApplicationDeveloper^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#applicationDeveloper_IfcApplication">ifc:applicationDeveloper_IfcApplication</a>
    /// </summary>
    let applicationDeveloper_IfcApplication = _prefixId.prefix "applicationDeveloper_IfcApplication"

    /// <summary>
    ///   <para>rdfs:label : ApplicationFullName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#applicationFullName_IfcApplication">ifc:applicationFullName_IfcApplication</a>
    /// </summary>
    let applicationFullName_IfcApplication = _prefixId.prefix "applicationFullName_IfcApplication"

    /// <summary>
    ///   <para>rdfs:label : ApplicationIdentifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#applicationIdentifier_IfcApplication">ifc:applicationIdentifier_IfcApplication</a>
    /// </summary>
    let applicationIdentifier_IfcApplication = _prefixId.prefix "applicationIdentifier_IfcApplication"

    /// <summary>
    ///   <para>rdfs:label : AppliedCondition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#appliedCondition_IfcRelConnectsStructuralMember">ifc:appliedCondition_IfcRelConnectsStructuralMember</a>
    /// </summary>
    let appliedCondition_IfcRelConnectsStructuralMember = _prefixId.prefix "appliedCondition_IfcRelConnectsStructuralMember"

    /// <summary>
    ///   <para>rdfs:label : AppliedCondition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#appliedCondition_IfcStructuralConnection">ifc:appliedCondition_IfcStructuralConnection</a>
    /// </summary>
    let appliedCondition_IfcStructuralConnection = _prefixId.prefix "appliedCondition_IfcStructuralConnection"

    /// <summary>
    ///   <para>rdfs:label : AppliedLoad^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#appliedLoad_IfcStructuralActivity">ifc:appliedLoad_IfcStructuralActivity</a>
    /// </summary>
    let appliedLoad_IfcStructuralActivity = _prefixId.prefix "appliedLoad_IfcStructuralActivity"

    /// <summary>
    ///   <para>rdfs:label : AppliedValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#appliedValue_IfcAppliedValue">ifc:appliedValue_IfcAppliedValue</a>
    /// </summary>
    let appliedValue_IfcAppliedValue = _prefixId.prefix "appliedValue_IfcAppliedValue"
    /// <summary>
    ///   <para>rdfs:label : ApprovedObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#approvedObjects_IfcApproval">ifc:approvedObjects_IfcApproval</a>
    /// </summary>
    let approvedObjects_IfcApproval = _prefixId.prefix "approvedObjects_IfcApproval"
    /// <summary>
    ///   <para>rdfs:label : ApprovedResources^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#approvedResources_IfcApproval">ifc:approvedResources_IfcApproval</a>
    /// </summary>
    let approvedResources_IfcApproval = _prefixId.prefix "approvedResources_IfcApproval"
    /// <summary>
    ///   <para>rdfs:label : AreaValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#areaValue_IfcQuantityArea">ifc:areaValue_IfcQuantityArea</a>
    /// </summary>
    let areaValue_IfcQuantityArea = _prefixId.prefix "areaValue_IfcQuantityArea"

    /// <summary>
    ///   <para>rdfs:label : ArithmeticOperator^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#arithmeticOperator_IfcAppliedValue">ifc:arithmeticOperator_IfcAppliedValue</a>
    /// </summary>
    let arithmeticOperator_IfcAppliedValue = _prefixId.prefix "arithmeticOperator_IfcAppliedValue"

    /// <summary>
    ///   <para>rdfs:label : AssemblyPlace^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#assemblyPlace_IfcElementAssembly">ifc:assemblyPlace_IfcElementAssembly</a>
    /// </summary>
    let assemblyPlace_IfcElementAssembly = _prefixId.prefix "assemblyPlace_IfcElementAssembly"

    /// <summary>
    ///   <para>rdfs:label : AssemblyPlace^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#assemblyPlace_IfcFurnitureType">ifc:assemblyPlace_IfcFurnitureType</a>
    /// </summary>
    let assemblyPlace_IfcFurnitureType = _prefixId.prefix "assemblyPlace_IfcFurnitureType"

    /// <summary>
    ///   <para>rdfs:label : AssignedItems^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#assignedItems_IfcPresentationLayerAssignment">ifc:assignedItems_IfcPresentationLayerAssignment</a>
    /// </summary>
    let assignedItems_IfcPresentationLayerAssignment = _prefixId.prefix "assignedItems_IfcPresentationLayerAssignment"

    /// <summary>
    ///   <para>rdfs:label : AssignedStructuralActivity^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#assignedStructuralActivity_IfcStructuralItem">ifc:assignedStructuralActivity_IfcStructuralItem</a>
    /// </summary>
    let assignedStructuralActivity_IfcStructuralItem = _prefixId.prefix "assignedStructuralActivity_IfcStructuralItem"

    /// <summary>
    ///   <para>rdfs:label : AssignedToFlowElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#assignedToFlowElement_IfcDistributionControlElement">ifc:assignedToFlowElement_IfcDistributionControlElement</a>
    /// </summary>
    let assignedToFlowElement_IfcDistributionControlElement = _prefixId.prefix "assignedToFlowElement_IfcDistributionControlElement"

    /// <summary>
    ///   <para>rdfs:label : AssignedToStructuralItem^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#assignedToStructuralItem_IfcStructuralActivity">ifc:assignedToStructuralItem_IfcStructuralActivity</a>
    /// </summary>
    let assignedToStructuralItem_IfcStructuralActivity = _prefixId.prefix "assignedToStructuralItem_IfcStructuralActivity"

    /// <summary>
    ///   <para>rdfs:label : AttributeIdentifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#attributeIdentifier_IfcReference">ifc:attributeIdentifier_IfcReference</a>
    /// </summary>
    let attributeIdentifier_IfcReference = _prefixId.prefix "attributeIdentifier_IfcReference"

    /// <summary>
    ///   <para>rdfs:label : Axis1^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axis1_IfcCartesianTransformationOperator">ifc:axis1_IfcCartesianTransformationOperator</a>
    /// </summary>
    let axis1_IfcCartesianTransformationOperator = _prefixId.prefix "axis1_IfcCartesianTransformationOperator"

    /// <summary>
    ///   <para>rdfs:label : Axis2^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axis2_IfcCartesianTransformationOperator">ifc:axis2_IfcCartesianTransformationOperator</a>
    /// </summary>
    let axis2_IfcCartesianTransformationOperator = _prefixId.prefix "axis2_IfcCartesianTransformationOperator"

    /// <summary>
    ///   <para>rdfs:label : Axis3^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axis3_IfcCartesianTransformationOperator3D">ifc:axis3_IfcCartesianTransformationOperator3D</a>
    /// </summary>
    let axis3_IfcCartesianTransformationOperator3D = _prefixId.prefix "axis3_IfcCartesianTransformationOperator3D"

    /// <summary>
    ///   <para>rdfs:label : AxisCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axisCurve_IfcGridAxis">ifc:axisCurve_IfcGridAxis</a>
    /// </summary>
    let axisCurve_IfcGridAxis = _prefixId.prefix "axisCurve_IfcGridAxis"

    /// <summary>
    ///   <para>rdfs:label : AxisPosition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axisPosition_IfcSurfaceOfRevolution">ifc:axisPosition_IfcSurfaceOfRevolution</a>
    /// </summary>
    let axisPosition_IfcSurfaceOfRevolution = _prefixId.prefix "axisPosition_IfcSurfaceOfRevolution"

    /// <summary>
    ///   <para>rdfs:label : AxisTag^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axisTag_IfcGridAxis">ifc:axisTag_IfcGridAxis</a>
    /// </summary>
    let axisTag_IfcGridAxis = _prefixId.prefix "axisTag_IfcGridAxis"
    /// <summary>
    ///   <para>rdfs:label : Axis^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axis_IfcAxis1Placement">ifc:axis_IfcAxis1Placement</a>
    /// </summary>
    let axis_IfcAxis1Placement = _prefixId.prefix "axis_IfcAxis1Placement"
    /// <summary>
    ///   <para>rdfs:label : Axis^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axis_IfcAxis2Placement3D">ifc:axis_IfcAxis2Placement3D</a>
    /// </summary>
    let axis_IfcAxis2Placement3D = _prefixId.prefix "axis_IfcAxis2Placement3D"
    /// <summary>
    ///   <para>rdfs:label : Axis^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axis_IfcRevolvedAreaSolid">ifc:axis_IfcRevolvedAreaSolid</a>
    /// </summary>
    let axis_IfcRevolvedAreaSolid = _prefixId.prefix "axis_IfcRevolvedAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : Axis^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axis_IfcStructuralCurveConnection">ifc:axis_IfcStructuralCurveConnection</a>
    /// </summary>
    let axis_IfcStructuralCurveConnection = _prefixId.prefix "axis_IfcStructuralCurveConnection"

    /// <summary>
    ///   <para>rdfs:label : Axis^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#axis_IfcStructuralCurveMember">ifc:axis_IfcStructuralCurveMember</a>
    /// </summary>
    let axis_IfcStructuralCurveMember = _prefixId.prefix "axis_IfcStructuralCurveMember"

    /// <summary>
    ///   <para>rdfs:label : BackgroundColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#backgroundColour_IfcTextStyleForDefinedFont">ifc:backgroundColour_IfcTextStyleForDefinedFont</a>
    /// </summary>
    let backgroundColour_IfcTextStyleForDefinedFont = _prefixId.prefix "backgroundColour_IfcTextStyleForDefinedFont"

    /// <summary>
    ///   <para>rdfs:label : BarCount^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#barCount_IfcReinforcementBarProperties">ifc:barCount_IfcReinforcementBarProperties</a>
    /// </summary>
    let barCount_IfcReinforcementBarProperties = _prefixId.prefix "barCount_IfcReinforcementBarProperties"

    /// <summary>
    ///   <para>rdfs:label : BarLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#barLength_IfcReinforcingBar">ifc:barLength_IfcReinforcingBar</a>
    /// </summary>
    let barLength_IfcReinforcingBar = _prefixId.prefix "barLength_IfcReinforcingBar"

    /// <summary>
    ///   <para>rdfs:label : BarLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#barLength_IfcReinforcingBarType">ifc:barLength_IfcReinforcingBarType</a>
    /// </summary>
    let barLength_IfcReinforcingBarType = _prefixId.prefix "barLength_IfcReinforcingBarType"

    /// <summary>
    ///   <para>rdfs:label : BarSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#barSurface_IfcReinforcementBarProperties">ifc:barSurface_IfcReinforcementBarProperties</a>
    /// </summary>
    let barSurface_IfcReinforcementBarProperties = _prefixId.prefix "barSurface_IfcReinforcementBarProperties"

    /// <summary>
    ///   <para>rdfs:label : BarSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#barSurface_IfcReinforcingBar">ifc:barSurface_IfcReinforcingBar</a>
    /// </summary>
    let barSurface_IfcReinforcingBar = _prefixId.prefix "barSurface_IfcReinforcingBar"

    /// <summary>
    ///   <para>rdfs:label : BarSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#barSurface_IfcReinforcingBarType">ifc:barSurface_IfcReinforcingBarType</a>
    /// </summary>
    let barSurface_IfcReinforcingBarType = _prefixId.prefix "barSurface_IfcReinforcingBarType"

    /// <summary>
    ///   <para>rdfs:label : BaseCosts^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#baseCosts_IfcConstructionResource">ifc:baseCosts_IfcConstructionResource</a>
    /// </summary>
    let baseCosts_IfcConstructionResource = _prefixId.prefix "baseCosts_IfcConstructionResource"

    /// <summary>
    ///   <para>rdfs:label : BaseCosts^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#baseCosts_IfcConstructionResourceType">ifc:baseCosts_IfcConstructionResourceType</a>
    /// </summary>
    let baseCosts_IfcConstructionResourceType = _prefixId.prefix "baseCosts_IfcConstructionResourceType"

    /// <summary>
    ///   <para>rdfs:label : BaseQuantity^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#baseQuantity_IfcConstructionResource">ifc:baseQuantity_IfcConstructionResource</a>
    /// </summary>
    let baseQuantity_IfcConstructionResource = _prefixId.prefix "baseQuantity_IfcConstructionResource"

    /// <summary>
    ///   <para>rdfs:label : BaseQuantity^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#baseQuantity_IfcConstructionResourceType">ifc:baseQuantity_IfcConstructionResourceType</a>
    /// </summary>
    let baseQuantity_IfcConstructionResourceType = _prefixId.prefix "baseQuantity_IfcConstructionResourceType"

    /// <summary>
    ///   <para>rdfs:label : BaseSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#baseSurface_IfcHalfSpaceSolid">ifc:baseSurface_IfcHalfSpaceSolid</a>
    /// </summary>
    let baseSurface_IfcHalfSpaceSolid = _prefixId.prefix "baseSurface_IfcHalfSpaceSolid"
    /// <summary>
    ///   <para>rdfs:label : BasisCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#basisCurve_IfcOffsetCurve2D">ifc:basisCurve_IfcOffsetCurve2D</a>
    /// </summary>
    let basisCurve_IfcOffsetCurve2D = _prefixId.prefix "basisCurve_IfcOffsetCurve2D"
    /// <summary>
    ///   <para>rdfs:label : BasisCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#basisCurve_IfcOffsetCurve3D">ifc:basisCurve_IfcOffsetCurve3D</a>
    /// </summary>
    let basisCurve_IfcOffsetCurve3D = _prefixId.prefix "basisCurve_IfcOffsetCurve3D"
    /// <summary>
    ///   <para>rdfs:label : BasisCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#basisCurve_IfcPointOnCurve">ifc:basisCurve_IfcPointOnCurve</a>
    /// </summary>
    let basisCurve_IfcPointOnCurve = _prefixId.prefix "basisCurve_IfcPointOnCurve"
    /// <summary>
    ///   <para>rdfs:label : BasisCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#basisCurve_IfcTrimmedCurve">ifc:basisCurve_IfcTrimmedCurve</a>
    /// </summary>
    let basisCurve_IfcTrimmedCurve = _prefixId.prefix "basisCurve_IfcTrimmedCurve"

    /// <summary>
    ///   <para>rdfs:label : BasisSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#basisSurface_IfcCurveBoundedPlane">ifc:basisSurface_IfcCurveBoundedPlane</a>
    /// </summary>
    let basisSurface_IfcCurveBoundedPlane = _prefixId.prefix "basisSurface_IfcCurveBoundedPlane"

    /// <summary>
    ///   <para>rdfs:label : BasisSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#basisSurface_IfcCurveBoundedSurface">ifc:basisSurface_IfcCurveBoundedSurface</a>
    /// </summary>
    let basisSurface_IfcCurveBoundedSurface = _prefixId.prefix "basisSurface_IfcCurveBoundedSurface"

    /// <summary>
    ///   <para>rdfs:label : BasisSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#basisSurface_IfcPcurve">ifc:basisSurface_IfcPcurve</a>
    /// </summary>
    let basisSurface_IfcPcurve = _prefixId.prefix "basisSurface_IfcPcurve"

    /// <summary>
    ///   <para>rdfs:label : BasisSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#basisSurface_IfcPointOnSurface">ifc:basisSurface_IfcPointOnSurface</a>
    /// </summary>
    let basisSurface_IfcPointOnSurface = _prefixId.prefix "basisSurface_IfcPointOnSurface"

    /// <summary>
    ///   <para>rdfs:label : BasisSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#basisSurface_IfcRectangularTrimmedSurface">ifc:basisSurface_IfcRectangularTrimmedSurface</a>
    /// </summary>
    let basisSurface_IfcRectangularTrimmedSurface = _prefixId.prefix "basisSurface_IfcRectangularTrimmedSurface"

    /// <summary>
    ///   <para>rdfs:label : BeamWidthAngle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#beamWidthAngle_IfcLightSourceSpot">ifc:beamWidthAngle_IfcLightSourceSpot</a>
    /// </summary>
    let beamWidthAngle_IfcLightSourceSpot = _prefixId.prefix "beamWidthAngle_IfcLightSourceSpot"

    /// <summary>
    ///   <para>rdfs:label : BenchmarkValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#benchmarkValues_IfcObjective">ifc:benchmarkValues_IfcObjective</a>
    /// </summary>
    let benchmarkValues_IfcObjective = _prefixId.prefix "benchmarkValues_IfcObjective"
    /// <summary>
    ///   <para>rdfs:label : Benchmark^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#benchmark_IfcMetric">ifc:benchmark_IfcMetric</a>
    /// </summary>
    let benchmark_IfcMetric = _prefixId.prefix "benchmark_IfcMetric"

    /// <summary>
    ///   <para>rdfs:label : BendingParameters^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bendingParameters_IfcReinforcingBarType">ifc:bendingParameters_IfcReinforcingBarType</a>
    /// </summary>
    let bendingParameters_IfcReinforcingBarType = _prefixId.prefix "bendingParameters_IfcReinforcingBarType"

    /// <summary>
    ///   <para>rdfs:label : BendingParameters^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bendingParameters_IfcReinforcingMeshType">ifc:bendingParameters_IfcReinforcingMeshType</a>
    /// </summary>
    let bendingParameters_IfcReinforcingMeshType = _prefixId.prefix "bendingParameters_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : BendingShapeCode^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bendingShapeCode_IfcReinforcingBarType">ifc:bendingShapeCode_IfcReinforcingBarType</a>
    /// </summary>
    let bendingShapeCode_IfcReinforcingBarType = _prefixId.prefix "bendingShapeCode_IfcReinforcingBarType"

    /// <summary>
    ///   <para>rdfs:label : BendingShapeCode^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bendingShapeCode_IfcReinforcingMeshType">ifc:bendingShapeCode_IfcReinforcingMeshType</a>
    /// </summary>
    let bendingShapeCode_IfcReinforcingMeshType = _prefixId.prefix "bendingShapeCode_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : Blue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#blue_IfcColourRgb">ifc:blue_IfcColourRgb</a>
    /// </summary>
    let blue_IfcColourRgb = _prefixId.prefix "blue_IfcColourRgb"

    /// <summary>
    ///   <para>rdfs:label : BottomFlangeEdgeRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bottomFlangeEdgeRadius_IfcAsymmetricIShapeProfileDef">ifc:bottomFlangeEdgeRadius_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let bottomFlangeEdgeRadius_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "bottomFlangeEdgeRadius_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : BottomFlangeFilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bottomFlangeFilletRadius_IfcAsymmetricIShapeProfileDef">ifc:bottomFlangeFilletRadius_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let bottomFlangeFilletRadius_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "bottomFlangeFilletRadius_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : BottomFlangeSlope^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bottomFlangeSlope_IfcAsymmetricIShapeProfileDef">ifc:bottomFlangeSlope_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let bottomFlangeSlope_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "bottomFlangeSlope_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : BottomFlangeThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bottomFlangeThickness_IfcAsymmetricIShapeProfileDef">ifc:bottomFlangeThickness_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let bottomFlangeThickness_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "bottomFlangeThickness_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : BottomFlangeWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bottomFlangeWidth_IfcAsymmetricIShapeProfileDef">ifc:bottomFlangeWidth_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let bottomFlangeWidth_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "bottomFlangeWidth_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : BottomRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bottomRadius_IfcRightCircularCone">ifc:bottomRadius_IfcRightCircularCone</a>
    /// </summary>
    let bottomRadius_IfcRightCircularCone = _prefixId.prefix "bottomRadius_IfcRightCircularCone"

    /// <summary>
    ///   <para>rdfs:label : BottomXDim^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bottomXDim_IfcTrapeziumProfileDef">ifc:bottomXDim_IfcTrapeziumProfileDef</a>
    /// </summary>
    let bottomXDim_IfcTrapeziumProfileDef = _prefixId.prefix "bottomXDim_IfcTrapeziumProfileDef"

    /// <summary>
    ///   <para>rdfs:label : Bound^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bound_IfcFaceBound">ifc:bound_IfcFaceBound</a>
    /// </summary>
    let bound_IfcFaceBound = _prefixId.prefix "bound_IfcFaceBound"

    /// <summary>
    ///   <para>rdfs:label : Boundaries^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#boundaries_IfcCurveBoundedSurface">ifc:boundaries_IfcCurveBoundedSurface</a>
    /// </summary>
    let boundaries_IfcCurveBoundedSurface = _prefixId.prefix "boundaries_IfcCurveBoundedSurface"

    /// <summary>
    ///   <para>rdfs:label : Bounds^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#bounds_IfcFace">ifc:bounds_IfcFace</a>
    /// </summary>
    let bounds_IfcFace = _prefixId.prefix "bounds_IfcFace"

    /// <summary>
    ///   <para>rdfs:label : BoxAlignment^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#boxAlignment_IfcTextLiteralWithExtent">ifc:boxAlignment_IfcTextLiteralWithExtent</a>
    /// </summary>
    let boxAlignment_IfcTextLiteralWithExtent = _prefixId.prefix "boxAlignment_IfcTextLiteralWithExtent"

    /// <summary>
    ///   <para>rdfs:label : BuildingAddress^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#buildingAddress_IfcBuilding">ifc:buildingAddress_IfcBuilding</a>
    /// </summary>
    let buildingAddress_IfcBuilding = _prefixId.prefix "buildingAddress_IfcBuilding"

    /// <summary>
    ///   <para>rdfs:label : CardinalEndPoint^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#cardinalEndPoint_IfcMaterialProfileSetUsageTapering">ifc:cardinalEndPoint_IfcMaterialProfileSetUsageTapering</a>
    /// </summary>
    let cardinalEndPoint_IfcMaterialProfileSetUsageTapering = _prefixId.prefix "cardinalEndPoint_IfcMaterialProfileSetUsageTapering"

    /// <summary>
    ///   <para>rdfs:label : CardinalPoint^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#cardinalPoint_IfcMaterialProfileSetUsage">ifc:cardinalPoint_IfcMaterialProfileSetUsage</a>
    /// </summary>
    let cardinalPoint_IfcMaterialProfileSetUsage = _prefixId.prefix "cardinalPoint_IfcMaterialProfileSetUsage"

    /// <summary>
    ///   <para>rdfs:label : CasingDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#casingDepth_IfcDoorLiningProperties">ifc:casingDepth_IfcDoorLiningProperties</a>
    /// </summary>
    let casingDepth_IfcDoorLiningProperties = _prefixId.prefix "casingDepth_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : CasingThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#casingThickness_IfcDoorLiningProperties">ifc:casingThickness_IfcDoorLiningProperties</a>
    /// </summary>
    let casingThickness_IfcDoorLiningProperties = _prefixId.prefix "casingThickness_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : Category^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#category_IfcAppliedValue">ifc:category_IfcAppliedValue</a>
    /// </summary>
    let category_IfcAppliedValue = _prefixId.prefix "category_IfcAppliedValue"
    /// <summary>
    ///   <para>rdfs:label : Category^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#category_IfcMaterial">ifc:category_IfcMaterial</a>
    /// </summary>
    let category_IfcMaterial = _prefixId.prefix "category_IfcMaterial"

    /// <summary>
    ///   <para>rdfs:label : Category^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#category_IfcMaterialConstituent">ifc:category_IfcMaterialConstituent</a>
    /// </summary>
    let category_IfcMaterialConstituent = _prefixId.prefix "category_IfcMaterialConstituent"

    /// <summary>
    ///   <para>rdfs:label : Category^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#category_IfcMaterialLayer">ifc:category_IfcMaterialLayer</a>
    /// </summary>
    let category_IfcMaterialLayer = _prefixId.prefix "category_IfcMaterialLayer"
    /// <summary>
    ///   <para>rdfs:label : Category^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#category_IfcMaterialProfile">ifc:category_IfcMaterialProfile</a>
    /// </summary>
    let category_IfcMaterialProfile = _prefixId.prefix "category_IfcMaterialProfile"
    /// <summary>
    ///   <para>rdfs:label : CfsFaces^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#cfsFaces_IfcConnectedFaceSet">ifc:cfsFaces_IfcConnectedFaceSet</a>
    /// </summary>
    let cfsFaces_IfcConnectedFaceSet = _prefixId.prefix "cfsFaces_IfcConnectedFaceSet"
    /// <summary>
    ///   <para>rdfs:label : ChangeAction^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#changeAction_IfcOwnerHistory">ifc:changeAction_IfcOwnerHistory</a>
    /// </summary>
    let changeAction_IfcOwnerHistory = _prefixId.prefix "changeAction_IfcOwnerHistory"

    /// <summary>
    ///   <para>rdfs:label : ClassifiedMaterial^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#classifiedMaterial_IfcMaterialClassificationRelationship">ifc:classifiedMaterial_IfcMaterialClassificationRelationship</a>
    /// </summary>
    let classifiedMaterial_IfcMaterialClassificationRelationship = _prefixId.prefix "classifiedMaterial_IfcMaterialClassificationRelationship"

    /// <summary>
    ///   <para>rdfs:label : ClosedCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#closedCurve_IfcBSplineCurve">ifc:closedCurve_IfcBSplineCurve</a>
    /// </summary>
    let closedCurve_IfcBSplineCurve = _prefixId.prefix "closedCurve_IfcBSplineCurve"
    /// <summary>
    ///   <para>rdfs:label : Closed^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#closed_IfcTessellatedFaceSet">ifc:closed_IfcTessellatedFaceSet</a>
    /// </summary>
    let closed_IfcTessellatedFaceSet = _prefixId.prefix "closed_IfcTessellatedFaceSet"

    /// <summary>
    ///   <para>rdfs:label : Coefficient^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coefficient_IfcStructuralLoadGroup">ifc:coefficient_IfcStructuralLoadGroup</a>
    /// </summary>
    let coefficient_IfcStructuralLoadGroup = _prefixId.prefix "coefficient_IfcStructuralLoadGroup"

    /// <summary>
    ///   <para>rdfs:label : ColourAppearance^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#colourAppearance_IfcLightSourceGoniometric">ifc:colourAppearance_IfcLightSourceGoniometric</a>
    /// </summary>
    let colourAppearance_IfcLightSourceGoniometric = _prefixId.prefix "colourAppearance_IfcLightSourceGoniometric"

    /// <summary>
    ///   <para>rdfs:label : ColourComponents^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#colourComponents_IfcPixelTexture">ifc:colourComponents_IfcPixelTexture</a>
    /// </summary>
    let colourComponents_IfcPixelTexture = _prefixId.prefix "colourComponents_IfcPixelTexture"

    /// <summary>
    ///   <para>rdfs:label : ColourIndex^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#colourIndex_IfcIndexedColourMap">ifc:colourIndex_IfcIndexedColourMap</a>
    /// </summary>
    let colourIndex_IfcIndexedColourMap = _prefixId.prefix "colourIndex_IfcIndexedColourMap"

    /// <summary>
    ///   <para>rdfs:label : ColourList^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#colourList_IfcColourRgbList">ifc:colourList_IfcColourRgbList</a>
    /// </summary>
    let colourList_IfcColourRgbList = _prefixId.prefix "colourList_IfcColourRgbList"

    /// <summary>
    ///   <para>rdfs:label : ColourTemperature^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#colourTemperature_IfcLightSourceGoniometric">ifc:colourTemperature_IfcLightSourceGoniometric</a>
    /// </summary>
    let colourTemperature_IfcLightSourceGoniometric = _prefixId.prefix "colourTemperature_IfcLightSourceGoniometric"

    /// <summary>
    ///   <para>rdfs:label : Colour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#colour_IfcTextStyleForDefinedFont">ifc:colour_IfcTextStyleForDefinedFont</a>
    /// </summary>
    let colour_IfcTextStyleForDefinedFont = _prefixId.prefix "colour_IfcTextStyleForDefinedFont"

    /// <summary>
    ///   <para>rdfs:label : Colours^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#colours_IfcIndexedColourMap">ifc:colours_IfcIndexedColourMap</a>
    /// </summary>
    let colours_IfcIndexedColourMap = _prefixId.prefix "colours_IfcIndexedColourMap"
    /// <summary>
    ///   <para>rdfs:label : Columns^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#columns_IfcTable">ifc:columns_IfcTable</a>
    /// </summary>
    let columns_IfcTable = _prefixId.prefix "columns_IfcTable"
    /// <summary>
    ///   <para>rdfs:label : Completion^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#completion_IfcResourceTime">ifc:completion_IfcResourceTime</a>
    /// </summary>
    let completion_IfcResourceTime = _prefixId.prefix "completion_IfcResourceTime"
    /// <summary>
    ///   <para>rdfs:label : Completion^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#completion_IfcTaskTime">ifc:completion_IfcTaskTime</a>
    /// </summary>
    let completion_IfcTaskTime = _prefixId.prefix "completion_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : Components^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#components_IfcAppliedValue">ifc:components_IfcAppliedValue</a>
    /// </summary>
    let components_IfcAppliedValue = _prefixId.prefix "components_IfcAppliedValue"

    /// <summary>
    ///   <para>rdfs:label : CompositeProfile^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#compositeProfile_IfcMaterialProfileSet">ifc:compositeProfile_IfcMaterialProfileSet</a>
    /// </summary>
    let compositeProfile_IfcMaterialProfileSet = _prefixId.prefix "compositeProfile_IfcMaterialProfileSet"

    /// <summary>
    ///   <para>rdfs:label : CompositionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#compositionType_IfcSpatialStructureElement">ifc:compositionType_IfcSpatialStructureElement</a>
    /// </summary>
    let compositionType_IfcSpatialStructureElement = _prefixId.prefix "compositionType_IfcSpatialStructureElement"

    /// <summary>
    ///   <para>rdfs:label : CompressionFailureX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#compressionFailureX_IfcFailureConnectionCondition">ifc:compressionFailureX_IfcFailureConnectionCondition</a>
    /// </summary>
    let compressionFailureX_IfcFailureConnectionCondition = _prefixId.prefix "compressionFailureX_IfcFailureConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : CompressionFailureY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#compressionFailureY_IfcFailureConnectionCondition">ifc:compressionFailureY_IfcFailureConnectionCondition</a>
    /// </summary>
    let compressionFailureY_IfcFailureConnectionCondition = _prefixId.prefix "compressionFailureY_IfcFailureConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : CompressionFailureZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#compressionFailureZ_IfcFailureConnectionCondition">ifc:compressionFailureZ_IfcFailureConnectionCondition</a>
    /// </summary>
    let compressionFailureZ_IfcFailureConnectionCondition = _prefixId.prefix "compressionFailureZ_IfcFailureConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : ConcentrationExponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#concentrationExponent_IfcLightSourceSpot">ifc:concentrationExponent_IfcLightSourceSpot</a>
    /// </summary>
    let concentrationExponent_IfcLightSourceSpot = _prefixId.prefix "concentrationExponent_IfcLightSourceSpot"

    /// <summary>
    ///   <para>rdfs:label : ConditionCoordinateSystem^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#conditionCoordinateSystem_IfcRelConnectsStructuralMember">ifc:conditionCoordinateSystem_IfcRelConnectsStructuralMember</a>
    /// </summary>
    let conditionCoordinateSystem_IfcRelConnectsStructuralMember = _prefixId.prefix "conditionCoordinateSystem_IfcRelConnectsStructuralMember"

    /// <summary>
    ///   <para>rdfs:label : ConditionCoordinateSystem^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#conditionCoordinateSystem_IfcStructuralPointConnection">ifc:conditionCoordinateSystem_IfcStructuralPointConnection</a>
    /// </summary>
    let conditionCoordinateSystem_IfcStructuralPointConnection = _prefixId.prefix "conditionCoordinateSystem_IfcStructuralPointConnection"

    /// <summary>
    ///   <para>rdfs:label : Condition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#condition_IfcAppliedValue">ifc:condition_IfcAppliedValue</a>
    /// </summary>
    let condition_IfcAppliedValue = _prefixId.prefix "condition_IfcAppliedValue"

    /// <summary>
    ///   <para>rdfs:label : Confidentiality^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#confidentiality_IfcDocumentInformation">ifc:confidentiality_IfcDocumentInformation</a>
    /// </summary>
    let confidentiality_IfcDocumentInformation = _prefixId.prefix "confidentiality_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : ConnectedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectedBy_IfcStructuralMember">ifc:connectedBy_IfcStructuralMember</a>
    /// </summary>
    let connectedBy_IfcStructuralMember = _prefixId.prefix "connectedBy_IfcStructuralMember"

    /// <summary>
    ///   <para>rdfs:label : ConnectedFrom^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectedFrom_IfcElement">ifc:connectedFrom_IfcElement</a>
    /// </summary>
    let connectedFrom_IfcElement = _prefixId.prefix "connectedFrom_IfcElement"
    /// <summary>
    ///   <para>rdfs:label : ConnectedFrom^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectedFrom_IfcPort">ifc:connectedFrom_IfcPort</a>
    /// </summary>
    let connectedFrom_IfcPort = _prefixId.prefix "connectedFrom_IfcPort"
    /// <summary>
    ///   <para>rdfs:label : ConnectedTo^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectedTo_IfcElement">ifc:connectedTo_IfcElement</a>
    /// </summary>
    let connectedTo_IfcElement = _prefixId.prefix "connectedTo_IfcElement"
    /// <summary>
    ///   <para>rdfs:label : ConnectedTo^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectedTo_IfcPort">ifc:connectedTo_IfcPort</a>
    /// </summary>
    let connectedTo_IfcPort = _prefixId.prefix "connectedTo_IfcPort"

    /// <summary>
    ///   <para>rdfs:label : ConnectionConstraint^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectionConstraint_IfcRelConnectsWithEccentricity">ifc:connectionConstraint_IfcRelConnectsWithEccentricity</a>
    /// </summary>
    let connectionConstraint_IfcRelConnectsWithEccentricity = _prefixId.prefix "connectionConstraint_IfcRelConnectsWithEccentricity"

    /// <summary>
    ///   <para>rdfs:label : ConnectionGeometry^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectionGeometry_IfcRelConnectsElements">ifc:connectionGeometry_IfcRelConnectsElements</a>
    /// </summary>
    let connectionGeometry_IfcRelConnectsElements = _prefixId.prefix "connectionGeometry_IfcRelConnectsElements"

    /// <summary>
    ///   <para>rdfs:label : ConnectionGeometry^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectionGeometry_IfcRelSpaceBoundary">ifc:connectionGeometry_IfcRelSpaceBoundary</a>
    /// </summary>
    let connectionGeometry_IfcRelSpaceBoundary = _prefixId.prefix "connectionGeometry_IfcRelSpaceBoundary"

    /// <summary>
    ///   <para>rdfs:label : ConnectionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectionType_IfcRelConnectsWithRealizingElements">ifc:connectionType_IfcRelConnectsWithRealizingElements</a>
    /// </summary>
    let connectionType_IfcRelConnectsWithRealizingElements = _prefixId.prefix "connectionType_IfcRelConnectsWithRealizingElements"

    /// <summary>
    ///   <para>rdfs:label : ConnectsStructuralMembers^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#connectsStructuralMembers_IfcStructuralConnection">ifc:connectsStructuralMembers_IfcStructuralConnection</a>
    /// </summary>
    let connectsStructuralMembers_IfcStructuralConnection = _prefixId.prefix "connectsStructuralMembers_IfcStructuralConnection"

    /// <summary>
    ///   <para>rdfs:label : ConstantAttenuation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#constantAttenuation_IfcLightSourcePositional">ifc:constantAttenuation_IfcLightSourcePositional</a>
    /// </summary>
    let constantAttenuation_IfcLightSourcePositional = _prefixId.prefix "constantAttenuation_IfcLightSourcePositional"

    /// <summary>
    ///   <para>rdfs:label : ConstraintGrade^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#constraintGrade_IfcConstraint">ifc:constraintGrade_IfcConstraint</a>
    /// </summary>
    let constraintGrade_IfcConstraint = _prefixId.prefix "constraintGrade_IfcConstraint"

    /// <summary>
    ///   <para>rdfs:label : ConstraintSource^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#constraintSource_IfcConstraint">ifc:constraintSource_IfcConstraint</a>
    /// </summary>
    let constraintSource_IfcConstraint = _prefixId.prefix "constraintSource_IfcConstraint"

    /// <summary>
    ///   <para>rdfs:label : ConstructionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#constructionType_IfcDoorStyle">ifc:constructionType_IfcDoorStyle</a>
    /// </summary>
    let constructionType_IfcDoorStyle = _prefixId.prefix "constructionType_IfcDoorStyle"
    /// <summary>
    ///   <para>rdfs:label : ConstructionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#constructionType_IfcPile">ifc:constructionType_IfcPile</a>
    /// </summary>
    let constructionType_IfcPile = _prefixId.prefix "constructionType_IfcPile"

    /// <summary>
    ///   <para>rdfs:label : ConstructionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#constructionType_IfcWindowStyle">ifc:constructionType_IfcWindowStyle</a>
    /// </summary>
    let constructionType_IfcWindowStyle = _prefixId.prefix "constructionType_IfcWindowStyle"

    /// <summary>
    ///   <para>rdfs:label : ContainedIn^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#containedIn_IfcPort">ifc:containedIn_IfcPort</a>
    /// </summary>
    let containedIn_IfcPort = _prefixId.prefix "containedIn_IfcPort"

    /// <summary>
    ///   <para>rdfs:label : ContainsElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#containsElements_IfcSpatialElement">ifc:containsElements_IfcSpatialElement</a>
    /// </summary>
    let containsElements_IfcSpatialElement = _prefixId.prefix "containsElements_IfcSpatialElement"

    /// <summary>
    ///   <para>rdfs:label : ContextIdentifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#contextIdentifier_IfcRepresentationContext">ifc:contextIdentifier_IfcRepresentationContext</a>
    /// </summary>
    let contextIdentifier_IfcRepresentationContext = _prefixId.prefix "contextIdentifier_IfcRepresentationContext"

    /// <summary>
    ///   <para>rdfs:label : ContextOfItems^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#contextOfItems_IfcRepresentation">ifc:contextOfItems_IfcRepresentation</a>
    /// </summary>
    let contextOfItems_IfcRepresentation = _prefixId.prefix "contextOfItems_IfcRepresentation"

    /// <summary>
    ///   <para>rdfs:label : ContextType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#contextType_IfcRepresentationContext">ifc:contextType_IfcRepresentationContext</a>
    /// </summary>
    let contextType_IfcRepresentationContext = _prefixId.prefix "contextType_IfcRepresentationContext"

    /// <summary>
    ///   <para>rdfs:label : ControlPointsList^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#controlPointsList_IfcBSplineCurve">ifc:controlPointsList_IfcBSplineCurve</a>
    /// </summary>
    let controlPointsList_IfcBSplineCurve = _prefixId.prefix "controlPointsList_IfcBSplineCurve"

    /// <summary>
    ///   <para>rdfs:label : ControlPointsList^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#controlPointsList_IfcBSplineSurface">ifc:controlPointsList_IfcBSplineSurface</a>
    /// </summary>
    let controlPointsList_IfcBSplineSurface = _prefixId.prefix "controlPointsList_IfcBSplineSurface"

    /// <summary>
    ///   <para>rdfs:label : Controls^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#controls_IfcControl">ifc:controls_IfcControl</a>
    /// </summary>
    let controls_IfcControl = _prefixId.prefix "controls_IfcControl"

    /// <summary>
    ///   <para>rdfs:label : ConversionFactor^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#conversionFactor_IfcConversionBasedUnit">ifc:conversionFactor_IfcConversionBasedUnit</a>
    /// </summary>
    let conversionFactor_IfcConversionBasedUnit = _prefixId.prefix "conversionFactor_IfcConversionBasedUnit"

    /// <summary>
    ///   <para>rdfs:label : ConversionOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#conversionOffset_IfcConversionBasedUnitWithOffset">ifc:conversionOffset_IfcConversionBasedUnitWithOffset</a>
    /// </summary>
    let conversionOffset_IfcConversionBasedUnitWithOffset = _prefixId.prefix "conversionOffset_IfcConversionBasedUnitWithOffset"

    /// <summary>
    ///   <para>rdfs:label : CoordIndex^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coordIndex_IfcTriangulatedFaceSet">ifc:coordIndex_IfcTriangulatedFaceSet</a>
    /// </summary>
    let coordIndex_IfcTriangulatedFaceSet = _prefixId.prefix "coordIndex_IfcTriangulatedFaceSet"

    /// <summary>
    ///   <para>rdfs:label : CoordList^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coordList_IfcCartesianPointList2D">ifc:coordList_IfcCartesianPointList2D</a>
    /// </summary>
    let coordList_IfcCartesianPointList2D = _prefixId.prefix "coordList_IfcCartesianPointList2D"

    /// <summary>
    ///   <para>rdfs:label : CoordList^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coordList_IfcCartesianPointList3D">ifc:coordList_IfcCartesianPointList3D</a>
    /// </summary>
    let coordList_IfcCartesianPointList3D = _prefixId.prefix "coordList_IfcCartesianPointList3D"

    /// <summary>
    ///   <para>rdfs:label : CoordinateSpaceDimension^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coordinateSpaceDimension_IfcGeometricRepresentationContext">ifc:coordinateSpaceDimension_IfcGeometricRepresentationContext</a>
    /// </summary>
    let coordinateSpaceDimension_IfcGeometricRepresentationContext = _prefixId.prefix "coordinateSpaceDimension_IfcGeometricRepresentationContext"

    /// <summary>
    ///   <para>rdfs:label : Coordinates^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coordinates_IfcCartesianPoint">ifc:coordinates_IfcCartesianPoint</a>
    /// </summary>
    let coordinates_IfcCartesianPoint = _prefixId.prefix "coordinates_IfcCartesianPoint"

    /// <summary>
    ///   <para>rdfs:label : Coordinates^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coordinates_IfcTessellatedFaceSet">ifc:coordinates_IfcTessellatedFaceSet</a>
    /// </summary>
    let coordinates_IfcTessellatedFaceSet = _prefixId.prefix "coordinates_IfcTessellatedFaceSet"

    /// <summary>
    ///   <para>rdfs:label : Coordinates^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coordinates_IfcTextureVertex">ifc:coordinates_IfcTextureVertex</a>
    /// </summary>
    let coordinates_IfcTextureVertex = _prefixId.prefix "coordinates_IfcTextureVertex"
    /// <summary>
    ///   <para>rdfs:label : Corner^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#corner_IfcBoundingBox">ifc:corner_IfcBoundingBox</a>
    /// </summary>
    let corner_IfcBoundingBox = _prefixId.prefix "corner_IfcBoundingBox"

    /// <summary>
    ///   <para>rdfs:label : CorrespondingBoundary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#correspondingBoundary_IfcRelSpaceBoundary2ndLevel">ifc:correspondingBoundary_IfcRelSpaceBoundary2ndLevel</a>
    /// </summary>
    let correspondingBoundary_IfcRelSpaceBoundary2ndLevel = _prefixId.prefix "correspondingBoundary_IfcRelSpaceBoundary2ndLevel"

    /// <summary>
    ///   <para>rdfs:label : Corresponds^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#corresponds_IfcRelSpaceBoundary2ndLevel">ifc:corresponds_IfcRelSpaceBoundary2ndLevel</a>
    /// </summary>
    let corresponds_IfcRelSpaceBoundary2ndLevel = _prefixId.prefix "corresponds_IfcRelSpaceBoundary2ndLevel"

    /// <summary>
    ///   <para>rdfs:label : CostQuantities^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#costQuantities_IfcCostItem">ifc:costQuantities_IfcCostItem</a>
    /// </summary>
    let costQuantities_IfcCostItem = _prefixId.prefix "costQuantities_IfcCostItem"
    /// <summary>
    ///   <para>rdfs:label : CostValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#costValues_IfcCostItem">ifc:costValues_IfcCostItem</a>
    /// </summary>
    let costValues_IfcCostItem = _prefixId.prefix "costValues_IfcCostItem"
    /// <summary>
    ///   <para>rdfs:label : CountValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#countValue_IfcQuantityCount">ifc:countValue_IfcQuantityCount</a>
    /// </summary>
    let countValue_IfcQuantityCount = _prefixId.prefix "countValue_IfcQuantityCount"
    /// <summary>
    ///   <para>rdfs:label : Country^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#country_IfcPostalAddress">ifc:country_IfcPostalAddress</a>
    /// </summary>
    let country_IfcPostalAddress = _prefixId.prefix "country_IfcPostalAddress"
    /// <summary>
    ///   <para>rdfs:label : CoversElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coversElements_IfcCovering">ifc:coversElements_IfcCovering</a>
    /// </summary>
    let coversElements_IfcCovering = _prefixId.prefix "coversElements_IfcCovering"
    /// <summary>
    ///   <para>rdfs:label : CoversSpaces^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#coversSpaces_IfcCovering">ifc:coversSpaces_IfcCovering</a>
    /// </summary>
    let coversSpaces_IfcCovering = _prefixId.prefix "coversSpaces_IfcCovering"
    /// <summary>
    ///   <para>rdfs:label : CreatingActor^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#creatingActor_IfcConstraint">ifc:creatingActor_IfcConstraint</a>
    /// </summary>
    let creatingActor_IfcConstraint = _prefixId.prefix "creatingActor_IfcConstraint"
    /// <summary>
    ///   <para>rdfs:label : CreationDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#creationDate_IfcOwnerHistory">ifc:creationDate_IfcOwnerHistory</a>
    /// </summary>
    let creationDate_IfcOwnerHistory = _prefixId.prefix "creationDate_IfcOwnerHistory"
    /// <summary>
    ///   <para>rdfs:label : CreationDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#creationDate_IfcWorkControl">ifc:creationDate_IfcWorkControl</a>
    /// </summary>
    let creationDate_IfcWorkControl = _prefixId.prefix "creationDate_IfcWorkControl"
    /// <summary>
    ///   <para>rdfs:label : CreationTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#creationTime_IfcConstraint">ifc:creationTime_IfcConstraint</a>
    /// </summary>
    let creationTime_IfcConstraint = _prefixId.prefix "creationTime_IfcConstraint"

    /// <summary>
    ///   <para>rdfs:label : CreationTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#creationTime_IfcDocumentInformation">ifc:creationTime_IfcDocumentInformation</a>
    /// </summary>
    let creationTime_IfcDocumentInformation = _prefixId.prefix "creationTime_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : Creators^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#creators_IfcWorkControl">ifc:creators_IfcWorkControl</a>
    /// </summary>
    let creators_IfcWorkControl = _prefixId.prefix "creators_IfcWorkControl"

    /// <summary>
    ///   <para>rdfs:label : CrossSectionArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#crossSectionArea_IfcReinforcingBar">ifc:crossSectionArea_IfcReinforcingBar</a>
    /// </summary>
    let crossSectionArea_IfcReinforcingBar = _prefixId.prefix "crossSectionArea_IfcReinforcingBar"

    /// <summary>
    ///   <para>rdfs:label : CrossSectionArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#crossSectionArea_IfcReinforcingBarType">ifc:crossSectionArea_IfcReinforcingBarType</a>
    /// </summary>
    let crossSectionArea_IfcReinforcingBarType = _prefixId.prefix "crossSectionArea_IfcReinforcingBarType"

    /// <summary>
    ///   <para>rdfs:label : CrossSectionArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#crossSectionArea_IfcTendon">ifc:crossSectionArea_IfcTendon</a>
    /// </summary>
    let crossSectionArea_IfcTendon = _prefixId.prefix "crossSectionArea_IfcTendon"

    /// <summary>
    ///   <para>rdfs:label : CrossSectionArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#crossSectionArea_IfcTendonType">ifc:crossSectionArea_IfcTendonType</a>
    /// </summary>
    let crossSectionArea_IfcTendonType = _prefixId.prefix "crossSectionArea_IfcTendonType"

    /// <summary>
    ///   <para>rdfs:label : CrossSectionPositions^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#crossSectionPositions_IfcSectionedSpine">ifc:crossSectionPositions_IfcSectionedSpine</a>
    /// </summary>
    let crossSectionPositions_IfcSectionedSpine = _prefixId.prefix "crossSectionPositions_IfcSectionedSpine"

    /// <summary>
    ///   <para>rdfs:label : CrossSectionReinforcementDefinitions^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#crossSectionReinforcementDefinitions_IfcSectionReinforcementProperties">ifc:crossSectionReinforcementDefinitions_IfcSectionReinforcementProperties</a>
    /// </summary>
    let crossSectionReinforcementDefinitions_IfcSectionReinforcementProperties = _prefixId.prefix "crossSectionReinforcementDefinitions_IfcSectionReinforcementProperties"

    /// <summary>
    ///   <para>rdfs:label : CrossSections^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#crossSections_IfcSectionedSpine">ifc:crossSections_IfcSectionedSpine</a>
    /// </summary>
    let crossSections_IfcSectionedSpine = _prefixId.prefix "crossSections_IfcSectionedSpine"

    /// <summary>
    ///   <para>rdfs:label : Currency^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#currency_IfcMonetaryUnit">ifc:currency_IfcMonetaryUnit</a>
    /// </summary>
    let currency_IfcMonetaryUnit = _prefixId.prefix "currency_IfcMonetaryUnit"
    /// <summary>
    ///   <para>rdfs:label : CurrentValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#currentValue_IfcAsset">ifc:currentValue_IfcAsset</a>
    /// </summary>
    let currentValue_IfcAsset = _prefixId.prefix "currentValue_IfcAsset"
    /// <summary>
    ///   <para>rdfs:label : CurrentValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#currentValue_IfcInventory">ifc:currentValue_IfcInventory</a>
    /// </summary>
    let currentValue_IfcInventory = _prefixId.prefix "currentValue_IfcInventory"
    /// <summary>
    ///   <para>rdfs:label : CurveColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curveColour_IfcCurveStyle">ifc:curveColour_IfcCurveStyle</a>
    /// </summary>
    let curveColour_IfcCurveStyle = _prefixId.prefix "curveColour_IfcCurveStyle"

    /// <summary>
    ///   <para>rdfs:label : CurveFontScaling^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curveFontScaling_IfcCurveStyleFontAndScaling">ifc:curveFontScaling_IfcCurveStyleFontAndScaling</a>
    /// </summary>
    let curveFontScaling_IfcCurveStyleFontAndScaling = _prefixId.prefix "curveFontScaling_IfcCurveStyleFontAndScaling"

    /// <summary>
    ///   <para>rdfs:label : CurveFont^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curveFont_IfcCurveStyle">ifc:curveFont_IfcCurveStyle</a>
    /// </summary>
    let curveFont_IfcCurveStyle = _prefixId.prefix "curveFont_IfcCurveStyle"

    /// <summary>
    ///   <para>rdfs:label : CurveFont^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curveFont_IfcCurveStyleFontAndScaling">ifc:curveFont_IfcCurveStyleFontAndScaling</a>
    /// </summary>
    let curveFont_IfcCurveStyleFontAndScaling = _prefixId.prefix "curveFont_IfcCurveStyleFontAndScaling"

    /// <summary>
    ///   <para>rdfs:label : CurveForm^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curveForm_IfcBSplineCurve">ifc:curveForm_IfcBSplineCurve</a>
    /// </summary>
    let curveForm_IfcBSplineCurve = _prefixId.prefix "curveForm_IfcBSplineCurve"

    /// <summary>
    ///   <para>rdfs:label : CurveInterpolation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curveInterpolation_IfcPropertyTableValue">ifc:curveInterpolation_IfcPropertyTableValue</a>
    /// </summary>
    let curveInterpolation_IfcPropertyTableValue = _prefixId.prefix "curveInterpolation_IfcPropertyTableValue"

    /// <summary>
    ///   <para>rdfs:label : CurveOnRelatedElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curveOnRelatedElement_IfcConnectionCurveGeometry">ifc:curveOnRelatedElement_IfcConnectionCurveGeometry</a>
    /// </summary>
    let curveOnRelatedElement_IfcConnectionCurveGeometry = _prefixId.prefix "curveOnRelatedElement_IfcConnectionCurveGeometry"

    /// <summary>
    ///   <para>rdfs:label : CurveOnRelatingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curveOnRelatingElement_IfcConnectionCurveGeometry">ifc:curveOnRelatingElement_IfcConnectionCurveGeometry</a>
    /// </summary>
    let curveOnRelatingElement_IfcConnectionCurveGeometry = _prefixId.prefix "curveOnRelatingElement_IfcConnectionCurveGeometry"

    /// <summary>
    ///   <para>rdfs:label : CurveWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curveWidth_IfcCurveStyle">ifc:curveWidth_IfcCurveStyle</a>
    /// </summary>
    let curveWidth_IfcCurveStyle = _prefixId.prefix "curveWidth_IfcCurveStyle"

    /// <summary>
    ///   <para>rdfs:label : Curve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#curve_IfcArbitraryOpenProfileDef">ifc:curve_IfcArbitraryOpenProfileDef</a>
    /// </summary>
    let curve_IfcArbitraryOpenProfileDef = _prefixId.prefix "curve_IfcArbitraryOpenProfileDef"

    /// <summary>
    ///   <para>rdfs:label : DataOrigin^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#dataOrigin_IfcSchedulingTime">ifc:dataOrigin_IfcSchedulingTime</a>
    /// </summary>
    let dataOrigin_IfcSchedulingTime = _prefixId.prefix "dataOrigin_IfcSchedulingTime"
    /// <summary>
    ///   <para>rdfs:label : DataOrigin^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#dataOrigin_IfcTimeSeries">ifc:dataOrigin_IfcTimeSeries</a>
    /// </summary>
    let dataOrigin_IfcTimeSeries = _prefixId.prefix "dataOrigin_IfcTimeSeries"
    /// <summary>
    ///   <para>rdfs:label : DataValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#dataValue_IfcMetric">ifc:dataValue_IfcMetric</a>
    /// </summary>
    let dataValue_IfcMetric = _prefixId.prefix "dataValue_IfcMetric"

    /// <summary>
    ///   <para>rdfs:label : DayComponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#dayComponent_IfcRecurrencePattern">ifc:dayComponent_IfcRecurrencePattern</a>
    /// </summary>
    let dayComponent_IfcRecurrencePattern = _prefixId.prefix "dayComponent_IfcRecurrencePattern"

    /// <summary>
    ///   <para>rdfs:label : Declares^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#declares_IfcContext">ifc:declares_IfcContext</a>
    /// </summary>
    let declares_IfcContext = _prefixId.prefix "declares_IfcContext"
    /// <summary>
    ///   <para>rdfs:label : Declares^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#declares_IfcObject">ifc:declares_IfcObject</a>
    /// </summary>
    let declares_IfcObject = _prefixId.prefix "declares_IfcObject"

    /// <summary>
    ///   <para>rdfs:label : Decomposes^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#decomposes_IfcObjectDefinition">ifc:decomposes_IfcObjectDefinition</a>
    /// </summary>
    let decomposes_IfcObjectDefinition = _prefixId.prefix "decomposes_IfcObjectDefinition"

    /// <summary>
    ///   <para>rdfs:label : DefinedUnit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#definedUnit_IfcPropertyTableValue">ifc:definedUnit_IfcPropertyTableValue</a>
    /// </summary>
    let definedUnit_IfcPropertyTableValue = _prefixId.prefix "definedUnit_IfcPropertyTableValue"

    /// <summary>
    ///   <para>rdfs:label : DefinedValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#definedValues_IfcPropertyTableValue">ifc:definedValues_IfcPropertyTableValue</a>
    /// </summary>
    let definedValues_IfcPropertyTableValue = _prefixId.prefix "definedValues_IfcPropertyTableValue"

    /// <summary>
    ///   <para>rdfs:label : DefinesOccurrence^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#definesOccurrence_IfcPropertySetDefinition">ifc:definesOccurrence_IfcPropertySetDefinition</a>
    /// </summary>
    let definesOccurrence_IfcPropertySetDefinition = _prefixId.prefix "definesOccurrence_IfcPropertySetDefinition"

    /// <summary>
    ///   <para>rdfs:label : DefinesType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#definesType_IfcPropertySetDefinition">ifc:definesType_IfcPropertySetDefinition</a>
    /// </summary>
    let definesType_IfcPropertySetDefinition = _prefixId.prefix "definesType_IfcPropertySetDefinition"

    /// <summary>
    ///   <para>rdfs:label : Defines^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#defines_IfcPropertySetTemplate">ifc:defines_IfcPropertySetTemplate</a>
    /// </summary>
    let defines_IfcPropertySetTemplate = _prefixId.prefix "defines_IfcPropertySetTemplate"

    /// <summary>
    ///   <para>rdfs:label : DefiningUnit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#definingUnit_IfcPropertyTableValue">ifc:definingUnit_IfcPropertyTableValue</a>
    /// </summary>
    let definingUnit_IfcPropertyTableValue = _prefixId.prefix "definingUnit_IfcPropertyTableValue"

    /// <summary>
    ///   <para>rdfs:label : DefiningValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#definingValues_IfcPropertyTableValue">ifc:definingValues_IfcPropertyTableValue</a>
    /// </summary>
    let definingValues_IfcPropertyTableValue = _prefixId.prefix "definingValues_IfcPropertyTableValue"

    /// <summary>
    ///   <para>rdfs:label : DefinitionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#definitionType_IfcReinforcementDefinitionProperties">ifc:definitionType_IfcReinforcementDefinitionProperties</a>
    /// </summary>
    let definitionType_IfcReinforcementDefinitionProperties = _prefixId.prefix "definitionType_IfcReinforcementDefinitionProperties"

    /// <summary>
    ///   <para>rdfs:label : Degree^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#degree_IfcBSplineCurve">ifc:degree_IfcBSplineCurve</a>
    /// </summary>
    let degree_IfcBSplineCurve = _prefixId.prefix "degree_IfcBSplineCurve"

    /// <summary>
    ///   <para>rdfs:label : DeltaTConstant^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#deltaTConstant_IfcStructuralLoadTemperature">ifc:deltaTConstant_IfcStructuralLoadTemperature</a>
    /// </summary>
    let deltaTConstant_IfcStructuralLoadTemperature = _prefixId.prefix "deltaTConstant_IfcStructuralLoadTemperature"

    /// <summary>
    ///   <para>rdfs:label : DeltaTY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#deltaTY_IfcStructuralLoadTemperature">ifc:deltaTY_IfcStructuralLoadTemperature</a>
    /// </summary>
    let deltaTY_IfcStructuralLoadTemperature = _prefixId.prefix "deltaTY_IfcStructuralLoadTemperature"

    /// <summary>
    ///   <para>rdfs:label : DeltaTZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#deltaTZ_IfcStructuralLoadTemperature">ifc:deltaTZ_IfcStructuralLoadTemperature</a>
    /// </summary>
    let deltaTZ_IfcStructuralLoadTemperature = _prefixId.prefix "deltaTZ_IfcStructuralLoadTemperature"

    /// <summary>
    ///   <para>rdfs:label : DependantProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#dependantProperty_IfcPropertyDependencyRelationship">ifc:dependantProperty_IfcPropertyDependencyRelationship</a>
    /// </summary>
    let dependantProperty_IfcPropertyDependencyRelationship = _prefixId.prefix "dependantProperty_IfcPropertyDependencyRelationship"

    /// <summary>
    ///   <para>rdfs:label : DependingProperty^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#dependingProperty_IfcPropertyDependencyRelationship">ifc:dependingProperty_IfcPropertyDependencyRelationship</a>
    /// </summary>
    let dependingProperty_IfcPropertyDependencyRelationship = _prefixId.prefix "dependingProperty_IfcPropertyDependencyRelationship"

    /// <summary>
    ///   <para>rdfs:label : DepreciatedValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#depreciatedValue_IfcAsset">ifc:depreciatedValue_IfcAsset</a>
    /// </summary>
    let depreciatedValue_IfcAsset = _prefixId.prefix "depreciatedValue_IfcAsset"
    /// <summary>
    ///   <para>rdfs:label : Depth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#depth_IfcCShapeProfileDef">ifc:depth_IfcCShapeProfileDef</a>
    /// </summary>
    let depth_IfcCShapeProfileDef = _prefixId.prefix "depth_IfcCShapeProfileDef"
    /// <summary>
    ///   <para>rdfs:label : Depth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#depth_IfcExtrudedAreaSolid">ifc:depth_IfcExtrudedAreaSolid</a>
    /// </summary>
    let depth_IfcExtrudedAreaSolid = _prefixId.prefix "depth_IfcExtrudedAreaSolid"
    /// <summary>
    ///   <para>rdfs:label : Depth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#depth_IfcLShapeProfileDef">ifc:depth_IfcLShapeProfileDef</a>
    /// </summary>
    let depth_IfcLShapeProfileDef = _prefixId.prefix "depth_IfcLShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : Depth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#depth_IfcSurfaceOfLinearExtrusion">ifc:depth_IfcSurfaceOfLinearExtrusion</a>
    /// </summary>
    let depth_IfcSurfaceOfLinearExtrusion = _prefixId.prefix "depth_IfcSurfaceOfLinearExtrusion"

    /// <summary>
    ///   <para>rdfs:label : Depth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#depth_IfcTShapeProfileDef">ifc:depth_IfcTShapeProfileDef</a>
    /// </summary>
    let depth_IfcTShapeProfileDef = _prefixId.prefix "depth_IfcTShapeProfileDef"
    /// <summary>
    ///   <para>rdfs:label : Depth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#depth_IfcUShapeProfileDef">ifc:depth_IfcUShapeProfileDef</a>
    /// </summary>
    let depth_IfcUShapeProfileDef = _prefixId.prefix "depth_IfcUShapeProfileDef"
    /// <summary>
    ///   <para>rdfs:label : Depth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#depth_IfcZShapeProfileDef">ifc:depth_IfcZShapeProfileDef</a>
    /// </summary>
    let depth_IfcZShapeProfileDef = _prefixId.prefix "depth_IfcZShapeProfileDef"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcActorRole">ifc:description_IfcActorRole</a>
    /// </summary>
    let description_IfcActorRole = _prefixId.prefix "description_IfcActorRole"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcAddress">ifc:description_IfcAddress</a>
    /// </summary>
    let description_IfcAddress = _prefixId.prefix "description_IfcAddress"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcAppliedValue">ifc:description_IfcAppliedValue</a>
    /// </summary>
    let description_IfcAppliedValue = _prefixId.prefix "description_IfcAppliedValue"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcApproval">ifc:description_IfcApproval</a>
    /// </summary>
    let description_IfcApproval = _prefixId.prefix "description_IfcApproval"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcClassification">ifc:description_IfcClassification</a>
    /// </summary>
    let description_IfcClassification = _prefixId.prefix "description_IfcClassification"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcClassificationReference">ifc:description_IfcClassificationReference</a>
    /// </summary>
    let description_IfcClassificationReference = _prefixId.prefix "description_IfcClassificationReference"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcConstraint">ifc:description_IfcConstraint</a>
    /// </summary>
    let description_IfcConstraint = _prefixId.prefix "description_IfcConstraint"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcCoordinateReferenceSystem">ifc:description_IfcCoordinateReferenceSystem</a>
    /// </summary>
    let description_IfcCoordinateReferenceSystem = _prefixId.prefix "description_IfcCoordinateReferenceSystem"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcDocumentInformation">ifc:description_IfcDocumentInformation</a>
    /// </summary>
    let description_IfcDocumentInformation = _prefixId.prefix "description_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcDocumentReference">ifc:description_IfcDocumentReference</a>
    /// </summary>
    let description_IfcDocumentReference = _prefixId.prefix "description_IfcDocumentReference"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcExtendedProperties">ifc:description_IfcExtendedProperties</a>
    /// </summary>
    let description_IfcExtendedProperties = _prefixId.prefix "description_IfcExtendedProperties"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcLibraryInformation">ifc:description_IfcLibraryInformation</a>
    /// </summary>
    let description_IfcLibraryInformation = _prefixId.prefix "description_IfcLibraryInformation"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcLibraryReference">ifc:description_IfcLibraryReference</a>
    /// </summary>
    let description_IfcLibraryReference = _prefixId.prefix "description_IfcLibraryReference"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcMaterial">ifc:description_IfcMaterial</a>
    /// </summary>
    let description_IfcMaterial = _prefixId.prefix "description_IfcMaterial"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcMaterialConstituent">ifc:description_IfcMaterialConstituent</a>
    /// </summary>
    let description_IfcMaterialConstituent = _prefixId.prefix "description_IfcMaterialConstituent"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcMaterialConstituentSet">ifc:description_IfcMaterialConstituentSet</a>
    /// </summary>
    let description_IfcMaterialConstituentSet = _prefixId.prefix "description_IfcMaterialConstituentSet"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcMaterialLayer">ifc:description_IfcMaterialLayer</a>
    /// </summary>
    let description_IfcMaterialLayer = _prefixId.prefix "description_IfcMaterialLayer"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcMaterialLayerSet">ifc:description_IfcMaterialLayerSet</a>
    /// </summary>
    let description_IfcMaterialLayerSet = _prefixId.prefix "description_IfcMaterialLayerSet"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcMaterialProfile">ifc:description_IfcMaterialProfile</a>
    /// </summary>
    let description_IfcMaterialProfile = _prefixId.prefix "description_IfcMaterialProfile"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcMaterialProfileSet">ifc:description_IfcMaterialProfileSet</a>
    /// </summary>
    let description_IfcMaterialProfileSet = _prefixId.prefix "description_IfcMaterialProfileSet"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcOrganization">ifc:description_IfcOrganization</a>
    /// </summary>
    let description_IfcOrganization = _prefixId.prefix "description_IfcOrganization"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcPhysicalQuantity">ifc:description_IfcPhysicalQuantity</a>
    /// </summary>
    let description_IfcPhysicalQuantity = _prefixId.prefix "description_IfcPhysicalQuantity"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcPresentationLayerAssignment">ifc:description_IfcPresentationLayerAssignment</a>
    /// </summary>
    let description_IfcPresentationLayerAssignment = _prefixId.prefix "description_IfcPresentationLayerAssignment"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcProductRepresentation">ifc:description_IfcProductRepresentation</a>
    /// </summary>
    let description_IfcProductRepresentation = _prefixId.prefix "description_IfcProductRepresentation"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcProperty">ifc:description_IfcProperty</a>
    /// </summary>
    let description_IfcProperty = _prefixId.prefix "description_IfcProperty"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcResourceLevelRelationship">ifc:description_IfcResourceLevelRelationship</a>
    /// </summary>
    let description_IfcResourceLevelRelationship = _prefixId.prefix "description_IfcResourceLevelRelationship"

    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcRoot">ifc:description_IfcRoot</a>
    /// </summary>
    let description_IfcRoot = _prefixId.prefix "description_IfcRoot"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcShapeAspect">ifc:description_IfcShapeAspect</a>
    /// </summary>
    let description_IfcShapeAspect = _prefixId.prefix "description_IfcShapeAspect"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcTableColumn">ifc:description_IfcTableColumn</a>
    /// </summary>
    let description_IfcTableColumn = _prefixId.prefix "description_IfcTableColumn"
    /// <summary>
    ///   <para>rdfs:label : Description^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#description_IfcTimeSeries">ifc:description_IfcTimeSeries</a>
    /// </summary>
    let description_IfcTimeSeries = _prefixId.prefix "description_IfcTimeSeries"

    /// <summary>
    ///   <para>rdfs:label : DestabilizingLoad^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#destabilizingLoad_IfcStructuralAction">ifc:destabilizingLoad_IfcStructuralAction</a>
    /// </summary>
    let destabilizingLoad_IfcStructuralAction = _prefixId.prefix "destabilizingLoad_IfcStructuralAction"

    /// <summary>
    ///   <para>rdfs:label : DiffuseColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#diffuseColour_IfcSurfaceStyleRendering">ifc:diffuseColour_IfcSurfaceStyleRendering</a>
    /// </summary>
    let diffuseColour_IfcSurfaceStyleRendering = _prefixId.prefix "diffuseColour_IfcSurfaceStyleRendering"

    /// <summary>
    ///   <para>rdfs:label : DiffuseReflectionColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#diffuseReflectionColour_IfcSurfaceStyleLighting">ifc:diffuseReflectionColour_IfcSurfaceStyleLighting</a>
    /// </summary>
    let diffuseReflectionColour_IfcSurfaceStyleLighting = _prefixId.prefix "diffuseReflectionColour_IfcSurfaceStyleLighting"

    /// <summary>
    ///   <para>rdfs:label : DiffuseTransmissionColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#diffuseTransmissionColour_IfcSurfaceStyleLighting">ifc:diffuseTransmissionColour_IfcSurfaceStyleLighting</a>
    /// </summary>
    let diffuseTransmissionColour_IfcSurfaceStyleLighting = _prefixId.prefix "diffuseTransmissionColour_IfcSurfaceStyleLighting"

    /// <summary>
    ///   <para>rdfs:label : DiffuseTransmissionColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#diffuseTransmissionColour_IfcSurfaceStyleRendering">ifc:diffuseTransmissionColour_IfcSurfaceStyleRendering</a>
    /// </summary>
    let diffuseTransmissionColour_IfcSurfaceStyleRendering = _prefixId.prefix "diffuseTransmissionColour_IfcSurfaceStyleRendering"

    /// <summary>
    ///   <para>rdfs:label : Dimensions^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#dimensions_IfcNamedUnit">ifc:dimensions_IfcNamedUnit</a>
    /// </summary>
    let dimensions_IfcNamedUnit = _prefixId.prefix "dimensions_IfcNamedUnit"
    /// <summary>
    ///   <para>rdfs:label : Dir^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#dir_IfcLine">ifc:dir_IfcLine</a>
    /// </summary>
    let dir_IfcLine = _prefixId.prefix "dir_IfcLine"
    /// <summary>
    ///   <para>rdfs:label : DirectionRatios^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#directionRatios_IfcDirection">ifc:directionRatios_IfcDirection</a>
    /// </summary>
    let directionRatios_IfcDirection = _prefixId.prefix "directionRatios_IfcDirection"

    /// <summary>
    ///   <para>rdfs:label : DirectionSense^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#directionSense_IfcMaterialLayerSetUsage">ifc:directionSense_IfcMaterialLayerSetUsage</a>
    /// </summary>
    let directionSense_IfcMaterialLayerSetUsage = _prefixId.prefix "directionSense_IfcMaterialLayerSetUsage"

    /// <summary>
    ///   <para>rdfs:label : Directrix^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#directrix_IfcFixedReferenceSweptAreaSolid">ifc:directrix_IfcFixedReferenceSweptAreaSolid</a>
    /// </summary>
    let directrix_IfcFixedReferenceSweptAreaSolid = _prefixId.prefix "directrix_IfcFixedReferenceSweptAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : Directrix^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#directrix_IfcSurfaceCurveSweptAreaSolid">ifc:directrix_IfcSurfaceCurveSweptAreaSolid</a>
    /// </summary>
    let directrix_IfcSurfaceCurveSweptAreaSolid = _prefixId.prefix "directrix_IfcSurfaceCurveSweptAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : Directrix^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#directrix_IfcSweptDiskSolid">ifc:directrix_IfcSweptDiskSolid</a>
    /// </summary>
    let directrix_IfcSweptDiskSolid = _prefixId.prefix "directrix_IfcSweptDiskSolid"

    /// <summary>
    ///   <para>rdfs:label : Discrimination^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#discrimination_IfcPhysicalComplexQuantity">ifc:discrimination_IfcPhysicalComplexQuantity</a>
    /// </summary>
    let discrimination_IfcPhysicalComplexQuantity = _prefixId.prefix "discrimination_IfcPhysicalComplexQuantity"

    /// <summary>
    ///   <para>rdfs:label : DispersionFactor^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#dispersionFactor_IfcSurfaceStyleRefraction">ifc:dispersionFactor_IfcSurfaceStyleRefraction</a>
    /// </summary>
    let dispersionFactor_IfcSurfaceStyleRefraction = _prefixId.prefix "dispersionFactor_IfcSurfaceStyleRefraction"

    /// <summary>
    ///   <para>rdfs:label : DisplacementX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#displacementX_IfcStructuralLoadSingleDisplacement">ifc:displacementX_IfcStructuralLoadSingleDisplacement</a>
    /// </summary>
    let displacementX_IfcStructuralLoadSingleDisplacement = _prefixId.prefix "displacementX_IfcStructuralLoadSingleDisplacement"

    /// <summary>
    ///   <para>rdfs:label : DisplacementY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#displacementY_IfcStructuralLoadSingleDisplacement">ifc:displacementY_IfcStructuralLoadSingleDisplacement</a>
    /// </summary>
    let displacementY_IfcStructuralLoadSingleDisplacement = _prefixId.prefix "displacementY_IfcStructuralLoadSingleDisplacement"

    /// <summary>
    ///   <para>rdfs:label : DisplacementZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#displacementZ_IfcStructuralLoadSingleDisplacement">ifc:displacementZ_IfcStructuralLoadSingleDisplacement</a>
    /// </summary>
    let displacementZ_IfcStructuralLoadSingleDisplacement = _prefixId.prefix "displacementZ_IfcStructuralLoadSingleDisplacement"

    /// <summary>
    ///   <para>rdfs:label : DistanceAttenuation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#distanceAttenuation_IfcLightSourcePositional">ifc:distanceAttenuation_IfcLightSourcePositional</a>
    /// </summary>
    let distanceAttenuation_IfcLightSourcePositional = _prefixId.prefix "distanceAttenuation_IfcLightSourcePositional"

    /// <summary>
    ///   <para>rdfs:label : Distance^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#distance_IfcOffsetCurve2D">ifc:distance_IfcOffsetCurve2D</a>
    /// </summary>
    let distance_IfcOffsetCurve2D = _prefixId.prefix "distance_IfcOffsetCurve2D"
    /// <summary>
    ///   <para>rdfs:label : Distance^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#distance_IfcOffsetCurve3D">ifc:distance_IfcOffsetCurve3D</a>
    /// </summary>
    let distance_IfcOffsetCurve3D = _prefixId.prefix "distance_IfcOffsetCurve3D"

    /// <summary>
    ///   <para>rdfs:label : Distortion^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#distortion_IfcStructuralLoadSingleDisplacementDistortion">ifc:distortion_IfcStructuralLoadSingleDisplacementDistortion</a>
    /// </summary>
    let distortion_IfcStructuralLoadSingleDisplacementDistortion = _prefixId.prefix "distortion_IfcStructuralLoadSingleDisplacementDistortion"

    /// <summary>
    ///   <para>rdfs:label : DistributionData^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#distributionData_IfcLightIntensityDistribution">ifc:distributionData_IfcLightIntensityDistribution</a>
    /// </summary>
    let distributionData_IfcLightIntensityDistribution = _prefixId.prefix "distributionData_IfcLightIntensityDistribution"

    /// <summary>
    ///   <para>rdfs:label : DocumentOwner^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#documentOwner_IfcDocumentInformation">ifc:documentOwner_IfcDocumentInformation</a>
    /// </summary>
    let documentOwner_IfcDocumentInformation = _prefixId.prefix "documentOwner_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : DurationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#durationType_IfcLagTime">ifc:durationType_IfcLagTime</a>
    /// </summary>
    let durationType_IfcLagTime = _prefixId.prefix "durationType_IfcLagTime"
    /// <summary>
    ///   <para>rdfs:label : DurationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#durationType_IfcTaskTime">ifc:durationType_IfcTaskTime</a>
    /// </summary>
    let durationType_IfcTaskTime = _prefixId.prefix "durationType_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : Duration^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#duration_IfcWorkControl">ifc:duration_IfcWorkControl</a>
    /// </summary>
    let duration_IfcWorkControl = _prefixId.prefix "duration_IfcWorkControl"
    /// <summary>
    ///   <para>rdfs:label : EarlyDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#earlyDate_IfcEventTime">ifc:earlyDate_IfcEventTime</a>
    /// </summary>
    let earlyDate_IfcEventTime = _prefixId.prefix "earlyDate_IfcEventTime"
    /// <summary>
    ///   <para>rdfs:label : EarlyFinish^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#earlyFinish_IfcTaskTime">ifc:earlyFinish_IfcTaskTime</a>
    /// </summary>
    let earlyFinish_IfcTaskTime = _prefixId.prefix "earlyFinish_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : EarlyStart^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#earlyStart_IfcTaskTime">ifc:earlyStart_IfcTaskTime</a>
    /// </summary>
    let earlyStart_IfcTaskTime = _prefixId.prefix "earlyStart_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : Eastings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#eastings_IfcMapConversion">ifc:eastings_IfcMapConversion</a>
    /// </summary>
    let eastings_IfcMapConversion = _prefixId.prefix "eastings_IfcMapConversion"

    /// <summary>
    ///   <para>rdfs:label : EccentricityInX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#eccentricityInX_IfcConnectionPointEccentricity">ifc:eccentricityInX_IfcConnectionPointEccentricity</a>
    /// </summary>
    let eccentricityInX_IfcConnectionPointEccentricity = _prefixId.prefix "eccentricityInX_IfcConnectionPointEccentricity"

    /// <summary>
    ///   <para>rdfs:label : EccentricityInY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#eccentricityInY_IfcConnectionPointEccentricity">ifc:eccentricityInY_IfcConnectionPointEccentricity</a>
    /// </summary>
    let eccentricityInY_IfcConnectionPointEccentricity = _prefixId.prefix "eccentricityInY_IfcConnectionPointEccentricity"

    /// <summary>
    ///   <para>rdfs:label : EccentricityInZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#eccentricityInZ_IfcConnectionPointEccentricity">ifc:eccentricityInZ_IfcConnectionPointEccentricity</a>
    /// </summary>
    let eccentricityInZ_IfcConnectionPointEccentricity = _prefixId.prefix "eccentricityInZ_IfcConnectionPointEccentricity"

    /// <summary>
    ///   <para>rdfs:label : EdgeElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edgeElement_IfcOrientedEdge">ifc:edgeElement_IfcOrientedEdge</a>
    /// </summary>
    let edgeElement_IfcOrientedEdge = _prefixId.prefix "edgeElement_IfcOrientedEdge"
    /// <summary>
    ///   <para>rdfs:label : EdgeEnd^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edgeEnd_IfcEdge">ifc:edgeEnd_IfcEdge</a>
    /// </summary>
    let edgeEnd_IfcEdge = _prefixId.prefix "edgeEnd_IfcEdge"
    /// <summary>
    ///   <para>rdfs:label : EdgeGeometry^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edgeGeometry_IfcEdgeCurve">ifc:edgeGeometry_IfcEdgeCurve</a>
    /// </summary>
    let edgeGeometry_IfcEdgeCurve = _prefixId.prefix "edgeGeometry_IfcEdgeCurve"
    /// <summary>
    ///   <para>rdfs:label : EdgeList^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edgeList_IfcEdgeLoop">ifc:edgeList_IfcEdgeLoop</a>
    /// </summary>
    let edgeList_IfcEdgeLoop = _prefixId.prefix "edgeList_IfcEdgeLoop"
    /// <summary>
    ///   <para>rdfs:label : EdgeList^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edgeList_IfcPath">ifc:edgeList_IfcPath</a>
    /// </summary>
    let edgeList_IfcPath = _prefixId.prefix "edgeList_IfcPath"

    /// <summary>
    ///   <para>rdfs:label : EdgeRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edgeRadius_IfcLShapeProfileDef">ifc:edgeRadius_IfcLShapeProfileDef</a>
    /// </summary>
    let edgeRadius_IfcLShapeProfileDef = _prefixId.prefix "edgeRadius_IfcLShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : EdgeRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edgeRadius_IfcUShapeProfileDef">ifc:edgeRadius_IfcUShapeProfileDef</a>
    /// </summary>
    let edgeRadius_IfcUShapeProfileDef = _prefixId.prefix "edgeRadius_IfcUShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : EdgeRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edgeRadius_IfcZShapeProfileDef">ifc:edgeRadius_IfcZShapeProfileDef</a>
    /// </summary>
    let edgeRadius_IfcZShapeProfileDef = _prefixId.prefix "edgeRadius_IfcZShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : EdgeStart^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edgeStart_IfcEdge">ifc:edgeStart_IfcEdge</a>
    /// </summary>
    let edgeStart_IfcEdge = _prefixId.prefix "edgeStart_IfcEdge"
    /// <summary>
    ///   <para>rdfs:label : EditionDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#editionDate_IfcClassification">ifc:editionDate_IfcClassification</a>
    /// </summary>
    let editionDate_IfcClassification = _prefixId.prefix "editionDate_IfcClassification"
    /// <summary>
    ///   <para>rdfs:label : Edition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#edition_IfcClassification">ifc:edition_IfcClassification</a>
    /// </summary>
    let edition_IfcClassification = _prefixId.prefix "edition_IfcClassification"

    /// <summary>
    ///   <para>rdfs:label : Editors^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#editors_IfcDocumentInformation">ifc:editors_IfcDocumentInformation</a>
    /// </summary>
    let editors_IfcDocumentInformation = _prefixId.prefix "editors_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : EffectiveDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#effectiveDepth_IfcReinforcementBarProperties">ifc:effectiveDepth_IfcReinforcementBarProperties</a>
    /// </summary>
    let effectiveDepth_IfcReinforcementBarProperties = _prefixId.prefix "effectiveDepth_IfcReinforcementBarProperties"

    /// <summary>
    ///   <para>rdfs:label : ElectricCurrentExponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#electricCurrentExponent_IfcDimensionalExponents">ifc:electricCurrentExponent_IfcDimensionalExponents</a>
    /// </summary>
    let electricCurrentExponent_IfcDimensionalExponents = _prefixId.prefix "electricCurrentExponent_IfcDimensionalExponents"

    /// <summary>
    ///   <para>rdfs:label : ElectronicFormat^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#electronicFormat_IfcDocumentInformation">ifc:electronicFormat_IfcDocumentInformation</a>
    /// </summary>
    let electronicFormat_IfcDocumentInformation = _prefixId.prefix "electronicFormat_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : ElectronicMailAddresses^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#electronicMailAddresses_IfcTelecomAddress">ifc:electronicMailAddresses_IfcTelecomAddress</a>
    /// </summary>
    let electronicMailAddresses_IfcTelecomAddress = _prefixId.prefix "electronicMailAddresses_IfcTelecomAddress"

    /// <summary>
    ///   <para>rdfs:label : ElementType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#elementType_IfcElementType">ifc:elementType_IfcElementType</a>
    /// </summary>
    let elementType_IfcElementType = _prefixId.prefix "elementType_IfcElementType"

    /// <summary>
    ///   <para>rdfs:label : ElementType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#elementType_IfcSpatialElementType">ifc:elementType_IfcSpatialElementType</a>
    /// </summary>
    let elementType_IfcSpatialElementType = _prefixId.prefix "elementType_IfcSpatialElementType"

    /// <summary>
    ///   <para>rdfs:label : Elements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#elements_IfcDerivedUnit">ifc:elements_IfcDerivedUnit</a>
    /// </summary>
    let elements_IfcDerivedUnit = _prefixId.prefix "elements_IfcDerivedUnit"
    /// <summary>
    ///   <para>rdfs:label : Elements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#elements_IfcGeometricSet">ifc:elements_IfcGeometricSet</a>
    /// </summary>
    let elements_IfcGeometricSet = _prefixId.prefix "elements_IfcGeometricSet"

    /// <summary>
    ///   <para>rdfs:label : ElevationOfRefHeight^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#elevationOfRefHeight_IfcBuilding">ifc:elevationOfRefHeight_IfcBuilding</a>
    /// </summary>
    let elevationOfRefHeight_IfcBuilding = _prefixId.prefix "elevationOfRefHeight_IfcBuilding"

    /// <summary>
    ///   <para>rdfs:label : ElevationOfTerrain^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#elevationOfTerrain_IfcBuilding">ifc:elevationOfTerrain_IfcBuilding</a>
    /// </summary>
    let elevationOfTerrain_IfcBuilding = _prefixId.prefix "elevationOfTerrain_IfcBuilding"

    /// <summary>
    ///   <para>rdfs:label : ElevationWithFlooring^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#elevationWithFlooring_IfcSpace">ifc:elevationWithFlooring_IfcSpace</a>
    /// </summary>
    let elevationWithFlooring_IfcSpace = _prefixId.prefix "elevationWithFlooring_IfcSpace"

    /// <summary>
    ///   <para>rdfs:label : Elevation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#elevation_IfcBuildingStorey">ifc:elevation_IfcBuildingStorey</a>
    /// </summary>
    let elevation_IfcBuildingStorey = _prefixId.prefix "elevation_IfcBuildingStorey"
    /// <summary>
    ///   <para>rdfs:label : Enclosure^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#enclosure_IfcBoxedHalfSpace">ifc:enclosure_IfcBoxedHalfSpace</a>
    /// </summary>
    let enclosure_IfcBoxedHalfSpace = _prefixId.prefix "enclosure_IfcBoxedHalfSpace"

    /// <summary>
    ///   <para>rdfs:label : EndParam^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#endParam_IfcFixedReferenceSweptAreaSolid">ifc:endParam_IfcFixedReferenceSweptAreaSolid</a>
    /// </summary>
    let endParam_IfcFixedReferenceSweptAreaSolid = _prefixId.prefix "endParam_IfcFixedReferenceSweptAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : EndParam^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#endParam_IfcSurfaceCurveSweptAreaSolid">ifc:endParam_IfcSurfaceCurveSweptAreaSolid</a>
    /// </summary>
    let endParam_IfcSurfaceCurveSweptAreaSolid = _prefixId.prefix "endParam_IfcSurfaceCurveSweptAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : EndParam^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#endParam_IfcSweptDiskSolid">ifc:endParam_IfcSweptDiskSolid</a>
    /// </summary>
    let endParam_IfcSweptDiskSolid = _prefixId.prefix "endParam_IfcSweptDiskSolid"

    /// <summary>
    ///   <para>rdfs:label : EndProfile^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#endProfile_IfcSectionProperties">ifc:endProfile_IfcSectionProperties</a>
    /// </summary>
    let endProfile_IfcSectionProperties = _prefixId.prefix "endProfile_IfcSectionProperties"

    /// <summary>
    ///   <para>rdfs:label : EndSweptArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#endSweptArea_IfcExtrudedAreaSolidTapered">ifc:endSweptArea_IfcExtrudedAreaSolidTapered</a>
    /// </summary>
    let endSweptArea_IfcExtrudedAreaSolidTapered = _prefixId.prefix "endSweptArea_IfcExtrudedAreaSolidTapered"

    /// <summary>
    ///   <para>rdfs:label : EndSweptArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#endSweptArea_IfcRevolvedAreaSolidTapered">ifc:endSweptArea_IfcRevolvedAreaSolidTapered</a>
    /// </summary>
    let endSweptArea_IfcRevolvedAreaSolidTapered = _prefixId.prefix "endSweptArea_IfcRevolvedAreaSolidTapered"

    /// <summary>
    ///   <para>rdfs:label : EndTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#endTime_IfcTimePeriod">ifc:endTime_IfcTimePeriod</a>
    /// </summary>
    let endTime_IfcTimePeriod = _prefixId.prefix "endTime_IfcTimePeriod"
    /// <summary>
    ///   <para>rdfs:label : EndTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#endTime_IfcTimeSeries">ifc:endTime_IfcTimeSeries</a>
    /// </summary>
    let endTime_IfcTimeSeries = _prefixId.prefix "endTime_IfcTimeSeries"
    /// <summary>
    ///   <para>rdfs:label : EngagedIn^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#engagedIn_IfcPerson">ifc:engagedIn_IfcPerson</a>
    /// </summary>
    let engagedIn_IfcPerson = _prefixId.prefix "engagedIn_IfcPerson"
    /// <summary>
    ///   <para>rdfs:label : Engages^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#engages_IfcOrganization">ifc:engages_IfcOrganization</a>
    /// </summary>
    let engages_IfcOrganization = _prefixId.prefix "engages_IfcOrganization"

    /// <summary>
    ///   <para>rdfs:label : EnumerationReference^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#enumerationReference_IfcPropertyEnumeratedValue">ifc:enumerationReference_IfcPropertyEnumeratedValue</a>
    /// </summary>
    let enumerationReference_IfcPropertyEnumeratedValue = _prefixId.prefix "enumerationReference_IfcPropertyEnumeratedValue"

    /// <summary>
    ///   <para>rdfs:label : EnumerationValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#enumerationValues_IfcPropertyEnumeratedValue">ifc:enumerationValues_IfcPropertyEnumeratedValue</a>
    /// </summary>
    let enumerationValues_IfcPropertyEnumeratedValue = _prefixId.prefix "enumerationValues_IfcPropertyEnumeratedValue"

    /// <summary>
    ///   <para>rdfs:label : EnumerationValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#enumerationValues_IfcPropertyEnumeration">ifc:enumerationValues_IfcPropertyEnumeration</a>
    /// </summary>
    let enumerationValues_IfcPropertyEnumeration = _prefixId.prefix "enumerationValues_IfcPropertyEnumeration"

    /// <summary>
    ///   <para>rdfs:label : Enumerators^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#enumerators_IfcSimplePropertyTemplate">ifc:enumerators_IfcSimplePropertyTemplate</a>
    /// </summary>
    let enumerators_IfcSimplePropertyTemplate = _prefixId.prefix "enumerators_IfcSimplePropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : EventOccurenceTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#eventOccurenceTime_IfcEvent">ifc:eventOccurenceTime_IfcEvent</a>
    /// </summary>
    let eventOccurenceTime_IfcEvent = _prefixId.prefix "eventOccurenceTime_IfcEvent"
    /// <summary>
    ///   <para>rdfs:label : EventTriggerType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#eventTriggerType_IfcEvent">ifc:eventTriggerType_IfcEvent</a>
    /// </summary>
    let eventTriggerType_IfcEvent = _prefixId.prefix "eventTriggerType_IfcEvent"
    /// <summary>
    ///   <para>rdfs:label : EventTriggerType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#eventTriggerType_IfcEventType">ifc:eventTriggerType_IfcEventType</a>
    /// </summary>
    let eventTriggerType_IfcEventType = _prefixId.prefix "eventTriggerType_IfcEventType"

    /// <summary>
    ///   <para>rdfs:label : ExceptionTimes^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#exceptionTimes_IfcWorkCalendar">ifc:exceptionTimes_IfcWorkCalendar</a>
    /// </summary>
    let exceptionTimes_IfcWorkCalendar = _prefixId.prefix "exceptionTimes_IfcWorkCalendar"

    /// <summary>
    ///   <para>rdfs:label : ExchangeRate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#exchangeRate_IfcCurrencyRelationship">ifc:exchangeRate_IfcCurrencyRelationship</a>
    /// </summary>
    let exchangeRate_IfcCurrencyRelationship = _prefixId.prefix "exchangeRate_IfcCurrencyRelationship"

    /// <summary>
    ///   <para>rdfs:label : Exponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#exponent_IfcDerivedUnitElement">ifc:exponent_IfcDerivedUnitElement</a>
    /// </summary>
    let exponent_IfcDerivedUnitElement = _prefixId.prefix "exponent_IfcDerivedUnitElement"

    /// <summary>
    ///   <para>rdfs:label : Expression^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#expression_IfcMaterialRelationship">ifc:expression_IfcMaterialRelationship</a>
    /// </summary>
    let expression_IfcMaterialRelationship = _prefixId.prefix "expression_IfcMaterialRelationship"

    /// <summary>
    ///   <para>rdfs:label : Expression^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#expression_IfcPropertyDependencyRelationship">ifc:expression_IfcPropertyDependencyRelationship</a>
    /// </summary>
    let expression_IfcPropertyDependencyRelationship = _prefixId.prefix "expression_IfcPropertyDependencyRelationship"

    /// <summary>
    ///   <para>rdfs:label : Expression^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#expression_IfcPropertyTableValue">ifc:expression_IfcPropertyTableValue</a>
    /// </summary>
    let expression_IfcPropertyTableValue = _prefixId.prefix "expression_IfcPropertyTableValue"

    /// <summary>
    ///   <para>rdfs:label : Expression^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#expression_IfcSimplePropertyTemplate">ifc:expression_IfcSimplePropertyTemplate</a>
    /// </summary>
    let expression_IfcSimplePropertyTemplate = _prefixId.prefix "expression_IfcSimplePropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : Extent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#extent_IfcTextLiteralWithExtent">ifc:extent_IfcTextLiteralWithExtent</a>
    /// </summary>
    let extent_IfcTextLiteralWithExtent = _prefixId.prefix "extent_IfcTextLiteralWithExtent"

    /// <summary>
    ///   <para>rdfs:label : ExternalReferenceForResources^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#externalReferenceForResources_IfcExternalReference">ifc:externalReferenceForResources_IfcExternalReference</a>
    /// </summary>
    let externalReferenceForResources_IfcExternalReference = _prefixId.prefix "externalReferenceForResources_IfcExternalReference"

    /// <summary>
    ///   <para>rdfs:label : ExtrudedDirection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#extrudedDirection_IfcExtrudedAreaSolid">ifc:extrudedDirection_IfcExtrudedAreaSolid</a>
    /// </summary>
    let extrudedDirection_IfcExtrudedAreaSolid = _prefixId.prefix "extrudedDirection_IfcExtrudedAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : ExtrudedDirection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#extrudedDirection_IfcSurfaceOfLinearExtrusion">ifc:extrudedDirection_IfcSurfaceOfLinearExtrusion</a>
    /// </summary>
    let extrudedDirection_IfcSurfaceOfLinearExtrusion = _prefixId.prefix "extrudedDirection_IfcSurfaceOfLinearExtrusion"

    /// <summary>
    ///   <para>rdfs:label : FaceSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#faceSurface_IfcFaceSurface">ifc:faceSurface_IfcFaceSurface</a>
    /// </summary>
    let faceSurface_IfcFaceSurface = _prefixId.prefix "faceSurface_IfcFaceSurface"

    /// <summary>
    ///   <para>rdfs:label : FacsimileNumbers^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#facsimileNumbers_IfcTelecomAddress">ifc:facsimileNumbers_IfcTelecomAddress</a>
    /// </summary>
    let facsimileNumbers_IfcTelecomAddress = _prefixId.prefix "facsimileNumbers_IfcTelecomAddress"

    /// <summary>
    ///   <para>rdfs:label : Factor^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#factor_IfcRelAssignsToGroupByFactor">ifc:factor_IfcRelAssignsToGroupByFactor</a>
    /// </summary>
    let factor_IfcRelAssignsToGroupByFactor = _prefixId.prefix "factor_IfcRelAssignsToGroupByFactor"

    /// <summary>
    ///   <para>rdfs:label : FamilyName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#familyName_IfcPerson">ifc:familyName_IfcPerson</a>
    /// </summary>
    let familyName_IfcPerson = _prefixId.prefix "familyName_IfcPerson"

    /// <summary>
    ///   <para>rdfs:label : FbsmFaces^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fbsmFaces_IfcFaceBasedSurfaceModel">ifc:fbsmFaces_IfcFaceBasedSurfaceModel</a>
    /// </summary>
    let fbsmFaces_IfcFaceBasedSurfaceModel = _prefixId.prefix "fbsmFaces_IfcFaceBasedSurfaceModel"

    /// <summary>
    ///   <para>rdfs:label : FillStyles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fillStyles_IfcFillAreaStyle">ifc:fillStyles_IfcFillAreaStyle</a>
    /// </summary>
    let fillStyles_IfcFillAreaStyle = _prefixId.prefix "fillStyles_IfcFillAreaStyle"

    /// <summary>
    ///   <para>rdfs:label : FilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#filletRadius_IfcIShapeProfileDef">ifc:filletRadius_IfcIShapeProfileDef</a>
    /// </summary>
    let filletRadius_IfcIShapeProfileDef = _prefixId.prefix "filletRadius_IfcIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#filletRadius_IfcLShapeProfileDef">ifc:filletRadius_IfcLShapeProfileDef</a>
    /// </summary>
    let filletRadius_IfcLShapeProfileDef = _prefixId.prefix "filletRadius_IfcLShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#filletRadius_IfcSweptDiskSolidPolygonal">ifc:filletRadius_IfcSweptDiskSolidPolygonal</a>
    /// </summary>
    let filletRadius_IfcSweptDiskSolidPolygonal = _prefixId.prefix "filletRadius_IfcSweptDiskSolidPolygonal"

    /// <summary>
    ///   <para>rdfs:label : FilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#filletRadius_IfcTShapeProfileDef">ifc:filletRadius_IfcTShapeProfileDef</a>
    /// </summary>
    let filletRadius_IfcTShapeProfileDef = _prefixId.prefix "filletRadius_IfcTShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#filletRadius_IfcUShapeProfileDef">ifc:filletRadius_IfcUShapeProfileDef</a>
    /// </summary>
    let filletRadius_IfcUShapeProfileDef = _prefixId.prefix "filletRadius_IfcUShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#filletRadius_IfcZShapeProfileDef">ifc:filletRadius_IfcZShapeProfileDef</a>
    /// </summary>
    let filletRadius_IfcZShapeProfileDef = _prefixId.prefix "filletRadius_IfcZShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FillsVoids^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fillsVoids_IfcElement">ifc:fillsVoids_IfcElement</a>
    /// </summary>
    let fillsVoids_IfcElement = _prefixId.prefix "fillsVoids_IfcElement"
    /// <summary>
    ///   <para>rdfs:label : FinishTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#finishTime_IfcWorkControl">ifc:finishTime_IfcWorkControl</a>
    /// </summary>
    let finishTime_IfcWorkControl = _prefixId.prefix "finishTime_IfcWorkControl"
    /// <summary>
    ///   <para>rdfs:label : Finish^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#finish_IfcWorkTime">ifc:finish_IfcWorkTime</a>
    /// </summary>
    let finish_IfcWorkTime = _prefixId.prefix "finish_IfcWorkTime"

    /// <summary>
    ///   <para>rdfs:label : FirstMullionOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#firstMullionOffset_IfcWindowLiningProperties">ifc:firstMullionOffset_IfcWindowLiningProperties</a>
    /// </summary>
    let firstMullionOffset_IfcWindowLiningProperties = _prefixId.prefix "firstMullionOffset_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : FirstOperand^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#firstOperand_IfcBooleanResult">ifc:firstOperand_IfcBooleanResult</a>
    /// </summary>
    let firstOperand_IfcBooleanResult = _prefixId.prefix "firstOperand_IfcBooleanResult"

    /// <summary>
    ///   <para>rdfs:label : FirstTransomOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#firstTransomOffset_IfcWindowLiningProperties">ifc:firstTransomOffset_IfcWindowLiningProperties</a>
    /// </summary>
    let firstTransomOffset_IfcWindowLiningProperties = _prefixId.prefix "firstTransomOffset_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : FixedReference^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fixedReference_IfcFixedReferenceSweptAreaSolid">ifc:fixedReference_IfcFixedReferenceSweptAreaSolid</a>
    /// </summary>
    let fixedReference_IfcFixedReferenceSweptAreaSolid = _prefixId.prefix "fixedReference_IfcFixedReferenceSweptAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : FixedUntilDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fixedUntilDate_IfcAppliedValue">ifc:fixedUntilDate_IfcAppliedValue</a>
    /// </summary>
    let fixedUntilDate_IfcAppliedValue = _prefixId.prefix "fixedUntilDate_IfcAppliedValue"

    /// <summary>
    ///   <para>rdfs:label : FlangeEdgeRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeEdgeRadius_IfcIShapeProfileDef">ifc:flangeEdgeRadius_IfcIShapeProfileDef</a>
    /// </summary>
    let flangeEdgeRadius_IfcIShapeProfileDef = _prefixId.prefix "flangeEdgeRadius_IfcIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeEdgeRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeEdgeRadius_IfcTShapeProfileDef">ifc:flangeEdgeRadius_IfcTShapeProfileDef</a>
    /// </summary>
    let flangeEdgeRadius_IfcTShapeProfileDef = _prefixId.prefix "flangeEdgeRadius_IfcTShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeSlope^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeSlope_IfcIShapeProfileDef">ifc:flangeSlope_IfcIShapeProfileDef</a>
    /// </summary>
    let flangeSlope_IfcIShapeProfileDef = _prefixId.prefix "flangeSlope_IfcIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeSlope^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeSlope_IfcTShapeProfileDef">ifc:flangeSlope_IfcTShapeProfileDef</a>
    /// </summary>
    let flangeSlope_IfcTShapeProfileDef = _prefixId.prefix "flangeSlope_IfcTShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeSlope^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeSlope_IfcUShapeProfileDef">ifc:flangeSlope_IfcUShapeProfileDef</a>
    /// </summary>
    let flangeSlope_IfcUShapeProfileDef = _prefixId.prefix "flangeSlope_IfcUShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeThickness_IfcIShapeProfileDef">ifc:flangeThickness_IfcIShapeProfileDef</a>
    /// </summary>
    let flangeThickness_IfcIShapeProfileDef = _prefixId.prefix "flangeThickness_IfcIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeThickness_IfcTShapeProfileDef">ifc:flangeThickness_IfcTShapeProfileDef</a>
    /// </summary>
    let flangeThickness_IfcTShapeProfileDef = _prefixId.prefix "flangeThickness_IfcTShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeThickness_IfcUShapeProfileDef">ifc:flangeThickness_IfcUShapeProfileDef</a>
    /// </summary>
    let flangeThickness_IfcUShapeProfileDef = _prefixId.prefix "flangeThickness_IfcUShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeThickness_IfcZShapeProfileDef">ifc:flangeThickness_IfcZShapeProfileDef</a>
    /// </summary>
    let flangeThickness_IfcZShapeProfileDef = _prefixId.prefix "flangeThickness_IfcZShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeWidth_IfcTShapeProfileDef">ifc:flangeWidth_IfcTShapeProfileDef</a>
    /// </summary>
    let flangeWidth_IfcTShapeProfileDef = _prefixId.prefix "flangeWidth_IfcTShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeWidth_IfcUShapeProfileDef">ifc:flangeWidth_IfcUShapeProfileDef</a>
    /// </summary>
    let flangeWidth_IfcUShapeProfileDef = _prefixId.prefix "flangeWidth_IfcUShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlangeWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flangeWidth_IfcZShapeProfileDef">ifc:flangeWidth_IfcZShapeProfileDef</a>
    /// </summary>
    let flangeWidth_IfcZShapeProfileDef = _prefixId.prefix "flangeWidth_IfcZShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : FlowDirection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#flowDirection_IfcDistributionPort">ifc:flowDirection_IfcDistributionPort</a>
    /// </summary>
    let flowDirection_IfcDistributionPort = _prefixId.prefix "flowDirection_IfcDistributionPort"

    /// <summary>
    ///   <para>rdfs:label : FontFamily^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fontFamily_IfcTextStyleFontModel">ifc:fontFamily_IfcTextStyleFontModel</a>
    /// </summary>
    let fontFamily_IfcTextStyleFontModel = _prefixId.prefix "fontFamily_IfcTextStyleFontModel"

    /// <summary>
    ///   <para>rdfs:label : FontSize^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fontSize_IfcTextStyleFontModel">ifc:fontSize_IfcTextStyleFontModel</a>
    /// </summary>
    let fontSize_IfcTextStyleFontModel = _prefixId.prefix "fontSize_IfcTextStyleFontModel"

    /// <summary>
    ///   <para>rdfs:label : FontStyle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fontStyle_IfcTextStyleFontModel">ifc:fontStyle_IfcTextStyleFontModel</a>
    /// </summary>
    let fontStyle_IfcTextStyleFontModel = _prefixId.prefix "fontStyle_IfcTextStyleFontModel"

    /// <summary>
    ///   <para>rdfs:label : FontVariant^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fontVariant_IfcTextStyleFontModel">ifc:fontVariant_IfcTextStyleFontModel</a>
    /// </summary>
    let fontVariant_IfcTextStyleFontModel = _prefixId.prefix "fontVariant_IfcTextStyleFontModel"

    /// <summary>
    ///   <para>rdfs:label : FontWeight^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fontWeight_IfcTextStyleFontModel">ifc:fontWeight_IfcTextStyleFontModel</a>
    /// </summary>
    let fontWeight_IfcTextStyleFontModel = _prefixId.prefix "fontWeight_IfcTextStyleFontModel"

    /// <summary>
    ///   <para>rdfs:label : ForLayerSet^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#forLayerSet_IfcMaterialLayerSetUsage">ifc:forLayerSet_IfcMaterialLayerSetUsage</a>
    /// </summary>
    let forLayerSet_IfcMaterialLayerSetUsage = _prefixId.prefix "forLayerSet_IfcMaterialLayerSetUsage"

    /// <summary>
    ///   <para>rdfs:label : ForProfileEndSet^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#forProfileEndSet_IfcMaterialProfileSetUsageTapering">ifc:forProfileEndSet_IfcMaterialProfileSetUsageTapering</a>
    /// </summary>
    let forProfileEndSet_IfcMaterialProfileSetUsageTapering = _prefixId.prefix "forProfileEndSet_IfcMaterialProfileSetUsageTapering"

    /// <summary>
    ///   <para>rdfs:label : ForProfileSet^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#forProfileSet_IfcMaterialProfileSetUsage">ifc:forProfileSet_IfcMaterialProfileSetUsage</a>
    /// </summary>
    let forProfileSet_IfcMaterialProfileSetUsage = _prefixId.prefix "forProfileSet_IfcMaterialProfileSetUsage"

    /// <summary>
    ///   <para>rdfs:label : ForceX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#forceX_IfcStructuralLoadSingleForce">ifc:forceX_IfcStructuralLoadSingleForce</a>
    /// </summary>
    let forceX_IfcStructuralLoadSingleForce = _prefixId.prefix "forceX_IfcStructuralLoadSingleForce"

    /// <summary>
    ///   <para>rdfs:label : ForceY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#forceY_IfcStructuralLoadSingleForce">ifc:forceY_IfcStructuralLoadSingleForce</a>
    /// </summary>
    let forceY_IfcStructuralLoadSingleForce = _prefixId.prefix "forceY_IfcStructuralLoadSingleForce"

    /// <summary>
    ///   <para>rdfs:label : ForceZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#forceZ_IfcStructuralLoadSingleForce">ifc:forceZ_IfcStructuralLoadSingleForce</a>
    /// </summary>
    let forceZ_IfcStructuralLoadSingleForce = _prefixId.prefix "forceZ_IfcStructuralLoadSingleForce"

    /// <summary>
    ///   <para>rdfs:label : Formula^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#formula_IfcQuantityArea">ifc:formula_IfcQuantityArea</a>
    /// </summary>
    let formula_IfcQuantityArea = _prefixId.prefix "formula_IfcQuantityArea"
    /// <summary>
    ///   <para>rdfs:label : Formula^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#formula_IfcQuantityCount">ifc:formula_IfcQuantityCount</a>
    /// </summary>
    let formula_IfcQuantityCount = _prefixId.prefix "formula_IfcQuantityCount"
    /// <summary>
    ///   <para>rdfs:label : Formula^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#formula_IfcQuantityLength">ifc:formula_IfcQuantityLength</a>
    /// </summary>
    let formula_IfcQuantityLength = _prefixId.prefix "formula_IfcQuantityLength"
    /// <summary>
    ///   <para>rdfs:label : Formula^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#formula_IfcQuantityTime">ifc:formula_IfcQuantityTime</a>
    /// </summary>
    let formula_IfcQuantityTime = _prefixId.prefix "formula_IfcQuantityTime"
    /// <summary>
    ///   <para>rdfs:label : Formula^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#formula_IfcQuantityVolume">ifc:formula_IfcQuantityVolume</a>
    /// </summary>
    let formula_IfcQuantityVolume = _prefixId.prefix "formula_IfcQuantityVolume"
    /// <summary>
    ///   <para>rdfs:label : Formula^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#formula_IfcQuantityWeight">ifc:formula_IfcQuantityWeight</a>
    /// </summary>
    let formula_IfcQuantityWeight = _prefixId.prefix "formula_IfcQuantityWeight"

    /// <summary>
    ///   <para>rdfs:label : Fraction^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#fraction_IfcMaterialConstituent">ifc:fraction_IfcMaterialConstituent</a>
    /// </summary>
    let fraction_IfcMaterialConstituent = _prefixId.prefix "fraction_IfcMaterialConstituent"

    /// <summary>
    ///   <para>rdfs:label : FrameDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#frameDepth_IfcPermeableCoveringProperties">ifc:frameDepth_IfcPermeableCoveringProperties</a>
    /// </summary>
    let frameDepth_IfcPermeableCoveringProperties = _prefixId.prefix "frameDepth_IfcPermeableCoveringProperties"

    /// <summary>
    ///   <para>rdfs:label : FrameDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#frameDepth_IfcWindowPanelProperties">ifc:frameDepth_IfcWindowPanelProperties</a>
    /// </summary>
    let frameDepth_IfcWindowPanelProperties = _prefixId.prefix "frameDepth_IfcWindowPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : FrameThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#frameThickness_IfcPermeableCoveringProperties">ifc:frameThickness_IfcPermeableCoveringProperties</a>
    /// </summary>
    let frameThickness_IfcPermeableCoveringProperties = _prefixId.prefix "frameThickness_IfcPermeableCoveringProperties"

    /// <summary>
    ///   <para>rdfs:label : FrameThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#frameThickness_IfcWindowPanelProperties">ifc:frameThickness_IfcWindowPanelProperties</a>
    /// </summary>
    let frameThickness_IfcWindowPanelProperties = _prefixId.prefix "frameThickness_IfcWindowPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : FreeFloat^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#freeFloat_IfcTaskTime">ifc:freeFloat_IfcTaskTime</a>
    /// </summary>
    let freeFloat_IfcTaskTime = _prefixId.prefix "freeFloat_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : FrictionCoefficient^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#frictionCoefficient_IfcTendon">ifc:frictionCoefficient_IfcTendon</a>
    /// </summary>
    let frictionCoefficient_IfcTendon = _prefixId.prefix "frictionCoefficient_IfcTendon"

    /// <summary>
    ///   <para>rdfs:label : GeodeticDatum^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#geodeticDatum_IfcCoordinateReferenceSystem">ifc:geodeticDatum_IfcCoordinateReferenceSystem</a>
    /// </summary>
    let geodeticDatum_IfcCoordinateReferenceSystem = _prefixId.prefix "geodeticDatum_IfcCoordinateReferenceSystem"

    /// <summary>
    ///   <para>rdfs:label : Girth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#girth_IfcCShapeProfileDef">ifc:girth_IfcCShapeProfileDef</a>
    /// </summary>
    let girth_IfcCShapeProfileDef = _prefixId.prefix "girth_IfcCShapeProfileDef"
    /// <summary>
    ///   <para>rdfs:label : GivenName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#givenName_IfcPerson">ifc:givenName_IfcPerson</a>
    /// </summary>
    let givenName_IfcPerson = _prefixId.prefix "givenName_IfcPerson"
    /// <summary>
    ///   <para>rdfs:label : GivingApproval^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#givingApproval_IfcApproval">ifc:givingApproval_IfcApproval</a>
    /// </summary>
    let givingApproval_IfcApproval = _prefixId.prefix "givingApproval_IfcApproval"
    /// <summary>
    ///   <para>rdfs:label : GlobalId^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#globalId_IfcRoot">ifc:globalId_IfcRoot</a>
    /// </summary>
    let globalId_IfcRoot = _prefixId.prefix "globalId_IfcRoot"

    /// <summary>
    ///   <para>rdfs:label : GlobalOrLocal^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#globalOrLocal_IfcStructuralActivity">ifc:globalOrLocal_IfcStructuralActivity</a>
    /// </summary>
    let globalOrLocal_IfcStructuralActivity = _prefixId.prefix "globalOrLocal_IfcStructuralActivity"

    /// <summary>
    ///   <para>rdfs:label : Green^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#green_IfcColourRgb">ifc:green_IfcColourRgb</a>
    /// </summary>
    let green_IfcColourRgb = _prefixId.prefix "green_IfcColourRgb"
    /// <summary>
    ///   <para>rdfs:label : HasApprovals^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasApprovals_IfcProperty">ifc:hasApprovals_IfcProperty</a>
    /// </summary>
    let hasApprovals_IfcProperty = _prefixId.prefix "hasApprovals_IfcProperty"

    /// <summary>
    ///   <para>rdfs:label : HasAssignments^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasAssignments_IfcObjectDefinition">ifc:hasAssignments_IfcObjectDefinition</a>
    /// </summary>
    let hasAssignments_IfcObjectDefinition = _prefixId.prefix "hasAssignments_IfcObjectDefinition"

    /// <summary>
    ///   <para>rdfs:label : HasColours^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasColours_IfcTessellatedFaceSet">ifc:hasColours_IfcTessellatedFaceSet</a>
    /// </summary>
    let hasColours_IfcTessellatedFaceSet = _prefixId.prefix "hasColours_IfcTessellatedFaceSet"

    /// <summary>
    ///   <para>rdfs:label : HasConstraints^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasConstraints_IfcProperty">ifc:hasConstraints_IfcProperty</a>
    /// </summary>
    let hasConstraints_IfcProperty = _prefixId.prefix "hasConstraints_IfcProperty"

    /// <summary>
    ///   <para>rdfs:label : HasControlElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasControlElements_IfcDistributionFlowElement">ifc:hasControlElements_IfcDistributionFlowElement</a>
    /// </summary>
    let hasControlElements_IfcDistributionFlowElement = _prefixId.prefix "hasControlElements_IfcDistributionFlowElement"

    /// <summary>
    ///   <para>rdfs:label : HasCoverings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasCoverings_IfcElement">ifc:hasCoverings_IfcElement</a>
    /// </summary>
    let hasCoverings_IfcElement = _prefixId.prefix "hasCoverings_IfcElement"
    /// <summary>
    ///   <para>rdfs:label : HasCoverings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasCoverings_IfcSpace">ifc:hasCoverings_IfcSpace</a>
    /// </summary>
    let hasCoverings_IfcSpace = _prefixId.prefix "hasCoverings_IfcSpace"

    /// <summary>
    ///   <para>rdfs:label : HasDocumentReferences^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasDocumentReferences_IfcDocumentInformation">ifc:hasDocumentReferences_IfcDocumentInformation</a>
    /// </summary>
    let hasDocumentReferences_IfcDocumentInformation = _prefixId.prefix "hasDocumentReferences_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : HasFillings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasFillings_IfcOpeningElement">ifc:hasFillings_IfcOpeningElement</a>
    /// </summary>
    let hasFillings_IfcOpeningElement = _prefixId.prefix "hasFillings_IfcOpeningElement"

    /// <summary>
    ///   <para>rdfs:label : HasLibraryReferences^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasLibraryReferences_IfcLibraryInformation">ifc:hasLibraryReferences_IfcLibraryInformation</a>
    /// </summary>
    let hasLibraryReferences_IfcLibraryInformation = _prefixId.prefix "hasLibraryReferences_IfcLibraryInformation"

    /// <summary>
    ///   <para>rdfs:label : HasOpenings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasOpenings_IfcElement">ifc:hasOpenings_IfcElement</a>
    /// </summary>
    let hasOpenings_IfcElement = _prefixId.prefix "hasOpenings_IfcElement"

    /// <summary>
    ///   <para>rdfs:label : HasPorts^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasPorts_IfcDistributionElement">ifc:hasPorts_IfcDistributionElement</a>
    /// </summary>
    let hasPorts_IfcDistributionElement = _prefixId.prefix "hasPorts_IfcDistributionElement"

    /// <summary>
    ///   <para>rdfs:label : HasProjections^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasProjections_IfcElement">ifc:hasProjections_IfcElement</a>
    /// </summary>
    let hasProjections_IfcElement = _prefixId.prefix "hasProjections_IfcElement"

    /// <summary>
    ///   <para>rdfs:label : HasProperties^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasProperties_IfcComplexProperty">ifc:hasProperties_IfcComplexProperty</a>
    /// </summary>
    let hasProperties_IfcComplexProperty = _prefixId.prefix "hasProperties_IfcComplexProperty"

    /// <summary>
    ///   <para>rdfs:label : HasProperties^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasProperties_IfcMaterialDefinition">ifc:hasProperties_IfcMaterialDefinition</a>
    /// </summary>
    let hasProperties_IfcMaterialDefinition = _prefixId.prefix "hasProperties_IfcMaterialDefinition"

    /// <summary>
    ///   <para>rdfs:label : HasProperties^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasProperties_IfcProfileDef">ifc:hasProperties_IfcProfileDef</a>
    /// </summary>
    let hasProperties_IfcProfileDef = _prefixId.prefix "hasProperties_IfcProfileDef"
    /// <summary>
    ///   <para>rdfs:label : HasProperties^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasProperties_IfcPropertySet">ifc:hasProperties_IfcPropertySet</a>
    /// </summary>
    let hasProperties_IfcPropertySet = _prefixId.prefix "hasProperties_IfcPropertySet"
    /// <summary>
    ///   <para>rdfs:label : HasPropertySets^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasPropertySets_IfcTypeObject">ifc:hasPropertySets_IfcTypeObject</a>
    /// </summary>
    let hasPropertySets_IfcTypeObject = _prefixId.prefix "hasPropertySets_IfcTypeObject"

    /// <summary>
    ///   <para>rdfs:label : HasPropertyTemplates^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasPropertyTemplates_IfcComplexPropertyTemplate">ifc:hasPropertyTemplates_IfcComplexPropertyTemplate</a>
    /// </summary>
    let hasPropertyTemplates_IfcComplexPropertyTemplate = _prefixId.prefix "hasPropertyTemplates_IfcComplexPropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : HasPropertyTemplates^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasPropertyTemplates_IfcPropertySetTemplate">ifc:hasPropertyTemplates_IfcPropertySetTemplate</a>
    /// </summary>
    let hasPropertyTemplates_IfcPropertySetTemplate = _prefixId.prefix "hasPropertyTemplates_IfcPropertySetTemplate"

    /// <summary>
    ///   <para>rdfs:label : HasQuantities^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasQuantities_IfcPhysicalComplexQuantity">ifc:hasQuantities_IfcPhysicalComplexQuantity</a>
    /// </summary>
    let hasQuantities_IfcPhysicalComplexQuantity = _prefixId.prefix "hasQuantities_IfcPhysicalComplexQuantity"

    /// <summary>
    ///   <para>rdfs:label : HasRepresentation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasRepresentation_IfcMaterial">ifc:hasRepresentation_IfcMaterial</a>
    /// </summary>
    let hasRepresentation_IfcMaterial = _prefixId.prefix "hasRepresentation_IfcMaterial"

    /// <summary>
    ///   <para>rdfs:label : HasResults^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasResults_IfcStructuralAnalysisModel">ifc:hasResults_IfcStructuralAnalysisModel</a>
    /// </summary>
    let hasResults_IfcStructuralAnalysisModel = _prefixId.prefix "hasResults_IfcStructuralAnalysisModel"

    /// <summary>
    ///   <para>rdfs:label : HasSubContexts^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasSubContexts_IfcGeometricRepresentationContext">ifc:hasSubContexts_IfcGeometricRepresentationContext</a>
    /// </summary>
    let hasSubContexts_IfcGeometricRepresentationContext = _prefixId.prefix "hasSubContexts_IfcGeometricRepresentationContext"

    /// <summary>
    ///   <para>rdfs:label : HasTextureMaps^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasTextureMaps_IfcFace">ifc:hasTextureMaps_IfcFace</a>
    /// </summary>
    let hasTextureMaps_IfcFace = _prefixId.prefix "hasTextureMaps_IfcFace"

    /// <summary>
    ///   <para>rdfs:label : HasTextures^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hasTextures_IfcTessellatedFaceSet">ifc:hasTextures_IfcTessellatedFaceSet</a>
    /// </summary>
    let hasTextures_IfcTessellatedFaceSet = _prefixId.prefix "hasTextures_IfcTessellatedFaceSet"

    /// <summary>
    ///   <para>rdfs:label : HatchLineAngle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hatchLineAngle_IfcFillAreaStyleHatching">ifc:hatchLineAngle_IfcFillAreaStyleHatching</a>
    /// </summary>
    let hatchLineAngle_IfcFillAreaStyleHatching = _prefixId.prefix "hatchLineAngle_IfcFillAreaStyleHatching"

    /// <summary>
    ///   <para>rdfs:label : HatchLineAppearance^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#hatchLineAppearance_IfcFillAreaStyleHatching">ifc:hatchLineAppearance_IfcFillAreaStyleHatching</a>
    /// </summary>
    let hatchLineAppearance_IfcFillAreaStyleHatching = _prefixId.prefix "hatchLineAppearance_IfcFillAreaStyleHatching"

    /// <summary>
    ///   <para>rdfs:label : Height^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#height_IfcPixelTexture">ifc:height_IfcPixelTexture</a>
    /// </summary>
    let height_IfcPixelTexture = _prefixId.prefix "height_IfcPixelTexture"
    /// <summary>
    ///   <para>rdfs:label : Height^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#height_IfcRectangularPyramid">ifc:height_IfcRectangularPyramid</a>
    /// </summary>
    let height_IfcRectangularPyramid = _prefixId.prefix "height_IfcRectangularPyramid"
    /// <summary>
    ///   <para>rdfs:label : Height^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#height_IfcRightCircularCone">ifc:height_IfcRightCircularCone</a>
    /// </summary>
    let height_IfcRightCircularCone = _prefixId.prefix "height_IfcRightCircularCone"

    /// <summary>
    ///   <para>rdfs:label : Height^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#height_IfcRightCircularCylinder">ifc:height_IfcRightCircularCylinder</a>
    /// </summary>
    let height_IfcRightCircularCylinder = _prefixId.prefix "height_IfcRightCircularCylinder"

    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcAsset">ifc:identification_IfcAsset</a>
    /// </summary>
    let identification_IfcAsset = _prefixId.prefix "identification_IfcAsset"
    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcControl">ifc:identification_IfcControl</a>
    /// </summary>
    let identification_IfcControl = _prefixId.prefix "identification_IfcControl"

    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcDocumentInformation">ifc:identification_IfcDocumentInformation</a>
    /// </summary>
    let identification_IfcDocumentInformation = _prefixId.prefix "identification_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcExternalReference">ifc:identification_IfcExternalReference</a>
    /// </summary>
    let identification_IfcExternalReference = _prefixId.prefix "identification_IfcExternalReference"

    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcOrganization">ifc:identification_IfcOrganization</a>
    /// </summary>
    let identification_IfcOrganization = _prefixId.prefix "identification_IfcOrganization"

    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcPerson">ifc:identification_IfcPerson</a>
    /// </summary>
    let identification_IfcPerson = _prefixId.prefix "identification_IfcPerson"
    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcProcess">ifc:identification_IfcProcess</a>
    /// </summary>
    let identification_IfcProcess = _prefixId.prefix "identification_IfcProcess"
    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcResource">ifc:identification_IfcResource</a>
    /// </summary>
    let identification_IfcResource = _prefixId.prefix "identification_IfcResource"
    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcTypeProcess">ifc:identification_IfcTypeProcess</a>
    /// </summary>
    let identification_IfcTypeProcess = _prefixId.prefix "identification_IfcTypeProcess"

    /// <summary>
    ///   <para>rdfs:label : Identification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identification_IfcTypeResource">ifc:identification_IfcTypeResource</a>
    /// </summary>
    let identification_IfcTypeResource = _prefixId.prefix "identification_IfcTypeResource"

    /// <summary>
    ///   <para>rdfs:label : Identifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identifier_IfcApproval">ifc:identifier_IfcApproval</a>
    /// </summary>
    let identifier_IfcApproval = _prefixId.prefix "identifier_IfcApproval"

    /// <summary>
    ///   <para>rdfs:label : Identifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identifier_IfcPresentationLayerAssignment">ifc:identifier_IfcPresentationLayerAssignment</a>
    /// </summary>
    let identifier_IfcPresentationLayerAssignment = _prefixId.prefix "identifier_IfcPresentationLayerAssignment"

    /// <summary>
    ///   <para>rdfs:label : Identifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#identifier_IfcTableColumn">ifc:identifier_IfcTableColumn</a>
    /// </summary>
    let identifier_IfcTableColumn = _prefixId.prefix "identifier_IfcTableColumn"

    /// <summary>
    ///   <para>rdfs:label : ImplicitOuter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#implicitOuter_IfcCurveBoundedSurface">ifc:implicitOuter_IfcCurveBoundedSurface</a>
    /// </summary>
    let implicitOuter_IfcCurveBoundedSurface = _prefixId.prefix "implicitOuter_IfcCurveBoundedSurface"

    /// <summary>
    ///   <para>rdfs:label : ImpliedOrder^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#impliedOrder_IfcRelInterferesElements">ifc:impliedOrder_IfcRelInterferesElements</a>
    /// </summary>
    let impliedOrder_IfcRelInterferesElements = _prefixId.prefix "impliedOrder_IfcRelInterferesElements"

    /// <summary>
    ///   <para>rdfs:label : IncorporationDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#incorporationDate_IfcAsset">ifc:incorporationDate_IfcAsset</a>
    /// </summary>
    let incorporationDate_IfcAsset = _prefixId.prefix "incorporationDate_IfcAsset"

    /// <summary>
    ///   <para>rdfs:label : InnerBoundaries^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#innerBoundaries_IfcAnnotationFillArea">ifc:innerBoundaries_IfcAnnotationFillArea</a>
    /// </summary>
    let innerBoundaries_IfcAnnotationFillArea = _prefixId.prefix "innerBoundaries_IfcAnnotationFillArea"

    /// <summary>
    ///   <para>rdfs:label : InnerBoundaries^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#innerBoundaries_IfcCurveBoundedPlane">ifc:innerBoundaries_IfcCurveBoundedPlane</a>
    /// </summary>
    let innerBoundaries_IfcCurveBoundedPlane = _prefixId.prefix "innerBoundaries_IfcCurveBoundedPlane"

    /// <summary>
    ///   <para>rdfs:label : InnerBoundaries^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#innerBoundaries_IfcRelSpaceBoundary1stLevel">ifc:innerBoundaries_IfcRelSpaceBoundary1stLevel</a>
    /// </summary>
    let innerBoundaries_IfcRelSpaceBoundary1stLevel = _prefixId.prefix "innerBoundaries_IfcRelSpaceBoundary1stLevel"

    /// <summary>
    ///   <para>rdfs:label : InnerCurves^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#innerCurves_IfcArbitraryProfileDefWithVoids">ifc:innerCurves_IfcArbitraryProfileDefWithVoids</a>
    /// </summary>
    let innerCurves_IfcArbitraryProfileDefWithVoids = _prefixId.prefix "innerCurves_IfcArbitraryProfileDefWithVoids"

    /// <summary>
    ///   <para>rdfs:label : InnerFilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#innerFilletRadius_IfcRectangleHollowProfileDef">ifc:innerFilletRadius_IfcRectangleHollowProfileDef</a>
    /// </summary>
    let innerFilletRadius_IfcRectangleHollowProfileDef = _prefixId.prefix "innerFilletRadius_IfcRectangleHollowProfileDef"

    /// <summary>
    ///   <para>rdfs:label : InnerRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#innerRadius_IfcSweptDiskSolid">ifc:innerRadius_IfcSweptDiskSolid</a>
    /// </summary>
    let innerRadius_IfcSweptDiskSolid = _prefixId.prefix "innerRadius_IfcSweptDiskSolid"
    /// <summary>
    ///   <para>rdfs:label : InnerReference^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#innerReference_IfcReference">ifc:innerReference_IfcReference</a>
    /// </summary>
    let innerReference_IfcReference = _prefixId.prefix "innerReference_IfcReference"
    /// <summary>
    ///   <para>rdfs:label : InstanceName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#instanceName_IfcReference">ifc:instanceName_IfcReference</a>
    /// </summary>
    let instanceName_IfcReference = _prefixId.prefix "instanceName_IfcReference"

    /// <summary>
    ///   <para>rdfs:label : IntendedUse^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#intendedUse_IfcDocumentInformation">ifc:intendedUse_IfcDocumentInformation</a>
    /// </summary>
    let intendedUse_IfcDocumentInformation = _prefixId.prefix "intendedUse_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : Intensity^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#intensity_IfcLightSource">ifc:intensity_IfcLightSource</a>
    /// </summary>
    let intensity_IfcLightSource = _prefixId.prefix "intensity_IfcLightSource"

    /// <summary>
    ///   <para>rdfs:label : Intent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#intent_IfcRelAssociatesConstraint">ifc:intent_IfcRelAssociatesConstraint</a>
    /// </summary>
    let intent_IfcRelAssociatesConstraint = _prefixId.prefix "intent_IfcRelAssociatesConstraint"

    /// <summary>
    ///   <para>rdfs:label : InterferenceGeometry^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#interferenceGeometry_IfcRelInterferesElements">ifc:interferenceGeometry_IfcRelInterferesElements</a>
    /// </summary>
    let interferenceGeometry_IfcRelInterferesElements = _prefixId.prefix "interferenceGeometry_IfcRelInterferesElements"

    /// <summary>
    ///   <para>rdfs:label : InterferenceType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#interferenceType_IfcRelInterferesElements">ifc:interferenceType_IfcRelInterferesElements</a>
    /// </summary>
    let interferenceType_IfcRelInterferesElements = _prefixId.prefix "interferenceType_IfcRelInterferesElements"

    /// <summary>
    ///   <para>rdfs:label : InterferesElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#interferesElements_IfcElement">ifc:interferesElements_IfcElement</a>
    /// </summary>
    let interferesElements_IfcElement = _prefixId.prefix "interferesElements_IfcElement"

    /// <summary>
    ///   <para>rdfs:label : InternalFilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#internalFilletRadius_IfcCShapeProfileDef">ifc:internalFilletRadius_IfcCShapeProfileDef</a>
    /// </summary>
    let internalFilletRadius_IfcCShapeProfileDef = _prefixId.prefix "internalFilletRadius_IfcCShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : InternalLocation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#internalLocation_IfcPostalAddress">ifc:internalLocation_IfcPostalAddress</a>
    /// </summary>
    let internalLocation_IfcPostalAddress = _prefixId.prefix "internalLocation_IfcPostalAddress"

    /// <summary>
    ///   <para>rdfs:label : InternalOrExternalBoundary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#internalOrExternalBoundary_IfcRelSpaceBoundary">ifc:internalOrExternalBoundary_IfcRelSpaceBoundary</a>
    /// </summary>
    let internalOrExternalBoundary_IfcRelSpaceBoundary = _prefixId.prefix "internalOrExternalBoundary_IfcRelSpaceBoundary"

    /// <summary>
    ///   <para>rdfs:label : IntersectingAxes^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#intersectingAxes_IfcVirtualGridIntersection">ifc:intersectingAxes_IfcVirtualGridIntersection</a>
    /// </summary>
    let intersectingAxes_IfcVirtualGridIntersection = _prefixId.prefix "intersectingAxes_IfcVirtualGridIntersection"

    /// <summary>
    ///   <para>rdfs:label : Interval^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#interval_IfcRecurrencePattern">ifc:interval_IfcRecurrencePattern</a>
    /// </summary>
    let interval_IfcRecurrencePattern = _prefixId.prefix "interval_IfcRecurrencePattern"

    /// <summary>
    ///   <para>rdfs:label : InvisibleSegmentLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#invisibleSegmentLength_IfcCurveStyleFontPattern">ifc:invisibleSegmentLength_IfcCurveStyleFontPattern</a>
    /// </summary>
    let invisibleSegmentLength_IfcCurveStyleFontPattern = _prefixId.prefix "invisibleSegmentLength_IfcCurveStyleFontPattern"

    /// <summary>
    ///   <para>rdfs:label : IsActingUpon^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isActingUpon_IfcActor">ifc:isActingUpon_IfcActor</a>
    /// </summary>
    let isActingUpon_IfcActor = _prefixId.prefix "isActingUpon_IfcActor"

    /// <summary>
    ///   <para>rdfs:label : IsConnectionRealization^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isConnectionRealization_IfcElement">ifc:isConnectionRealization_IfcElement</a>
    /// </summary>
    let isConnectionRealization_IfcElement = _prefixId.prefix "isConnectionRealization_IfcElement"

    /// <summary>
    ///   <para>rdfs:label : IsCritical^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isCritical_IfcTaskTime">ifc:isCritical_IfcTaskTime</a>
    /// </summary>
    let isCritical_IfcTaskTime = _prefixId.prefix "isCritical_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : IsDeclaredBy^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isDeclaredBy_IfcObject">ifc:isDeclaredBy_IfcObject</a>
    /// </summary>
    let isDeclaredBy_IfcObject = _prefixId.prefix "isDeclaredBy_IfcObject"

    /// <summary>
    ///   <para>rdfs:label : IsDecomposedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isDecomposedBy_IfcObjectDefinition">ifc:isDecomposedBy_IfcObjectDefinition</a>
    /// </summary>
    let isDecomposedBy_IfcObjectDefinition = _prefixId.prefix "isDecomposedBy_IfcObjectDefinition"

    /// <summary>
    ///   <para>rdfs:label : IsDefinedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isDefinedBy_IfcPropertySetDefinition">ifc:isDefinedBy_IfcPropertySetDefinition</a>
    /// </summary>
    let isDefinedBy_IfcPropertySetDefinition = _prefixId.prefix "isDefinedBy_IfcPropertySetDefinition"

    /// <summary>
    ///   <para>rdfs:label : IsGroupedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isGroupedBy_IfcGroup">ifc:isGroupedBy_IfcGroup</a>
    /// </summary>
    let isGroupedBy_IfcGroup = _prefixId.prefix "isGroupedBy_IfcGroup"
    /// <summary>
    ///   <para>rdfs:label : IsHeading^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isHeading_IfcTableRow">ifc:isHeading_IfcTableRow</a>
    /// </summary>
    let isHeading_IfcTableRow = _prefixId.prefix "isHeading_IfcTableRow"

    /// <summary>
    ///   <para>rdfs:label : IsInterferedByElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isInterferedByElements_IfcElement">ifc:isInterferedByElements_IfcElement</a>
    /// </summary>
    let isInterferedByElements_IfcElement = _prefixId.prefix "isInterferedByElements_IfcElement"

    /// <summary>
    ///   <para>rdfs:label : IsLinear^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isLinear_IfcStructuralResultGroup">ifc:isLinear_IfcStructuralResultGroup</a>
    /// </summary>
    let isLinear_IfcStructuralResultGroup = _prefixId.prefix "isLinear_IfcStructuralResultGroup"

    /// <summary>
    ///   <para>rdfs:label : IsMilestone^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isMilestone_IfcTask">ifc:isMilestone_IfcTask</a>
    /// </summary>
    let isMilestone_IfcTask = _prefixId.prefix "isMilestone_IfcTask"

    /// <summary>
    ///   <para>rdfs:label : IsNestedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isNestedBy_IfcObjectDefinition">ifc:isNestedBy_IfcObjectDefinition</a>
    /// </summary>
    let isNestedBy_IfcObjectDefinition = _prefixId.prefix "isNestedBy_IfcObjectDefinition"

    /// <summary>
    ///   <para>rdfs:label : IsOverAllocated^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isOverAllocated_IfcResourceTime">ifc:isOverAllocated_IfcResourceTime</a>
    /// </summary>
    let isOverAllocated_IfcResourceTime = _prefixId.prefix "isOverAllocated_IfcResourceTime"

    /// <summary>
    ///   <para>rdfs:label : IsPointedTo^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isPointedTo_IfcDocumentInformation">ifc:isPointedTo_IfcDocumentInformation</a>
    /// </summary>
    let isPointedTo_IfcDocumentInformation = _prefixId.prefix "isPointedTo_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : IsPointer^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isPointer_IfcDocumentInformation">ifc:isPointer_IfcDocumentInformation</a>
    /// </summary>
    let isPointer_IfcDocumentInformation = _prefixId.prefix "isPointer_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : IsPredecessorTo^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isPredecessorTo_IfcProcess">ifc:isPredecessorTo_IfcProcess</a>
    /// </summary>
    let isPredecessorTo_IfcProcess = _prefixId.prefix "isPredecessorTo_IfcProcess"
    /// <summary>
    ///   <para>rdfs:label : IsRelatedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isRelatedBy_IfcOrganization">ifc:isRelatedBy_IfcOrganization</a>
    /// </summary>
    let isRelatedBy_IfcOrganization = _prefixId.prefix "isRelatedBy_IfcOrganization"
    /// <summary>
    ///   <para>rdfs:label : IsRelatedWith^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isRelatedWith_IfcApproval">ifc:isRelatedWith_IfcApproval</a>
    /// </summary>
    let isRelatedWith_IfcApproval = _prefixId.prefix "isRelatedWith_IfcApproval"
    /// <summary>
    ///   <para>rdfs:label : IsRelatedWith^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isRelatedWith_IfcMaterial">ifc:isRelatedWith_IfcMaterial</a>
    /// </summary>
    let isRelatedWith_IfcMaterial = _prefixId.prefix "isRelatedWith_IfcMaterial"
    /// <summary>
    ///   <para>rdfs:label : IsSuccessorFrom^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isSuccessorFrom_IfcProcess">ifc:isSuccessorFrom_IfcProcess</a>
    /// </summary>
    let isSuccessorFrom_IfcProcess = _prefixId.prefix "isSuccessorFrom_IfcProcess"
    /// <summary>
    ///   <para>rdfs:label : IsTypedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isTypedBy_IfcObject">ifc:isTypedBy_IfcObject</a>
    /// </summary>
    let isTypedBy_IfcObject = _prefixId.prefix "isTypedBy_IfcObject"
    /// <summary>
    ///   <para>rdfs:label : IsVentilated^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#isVentilated_IfcMaterialLayer">ifc:isVentilated_IfcMaterialLayer</a>
    /// </summary>
    let isVentilated_IfcMaterialLayer = _prefixId.prefix "isVentilated_IfcMaterialLayer"
    /// <summary>
    ///   <para>rdfs:label : Item^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#item_IfcStyledItem">ifc:item_IfcStyledItem</a>
    /// </summary>
    let item_IfcStyledItem = _prefixId.prefix "item_IfcStyledItem"
    /// <summary>
    ///   <para>rdfs:label : Items^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#items_IfcRepresentation">ifc:items_IfcRepresentation</a>
    /// </summary>
    let items_IfcRepresentation = _prefixId.prefix "items_IfcRepresentation"
    /// <summary>
    ///   <para>rdfs:label : Jurisdiction^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#jurisdiction_IfcInventory">ifc:jurisdiction_IfcInventory</a>
    /// </summary>
    let jurisdiction_IfcInventory = _prefixId.prefix "jurisdiction_IfcInventory"

    /// <summary>
    ///   <para>rdfs:label : KnotMultiplicities^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#knotMultiplicities_IfcBSplineCurveWithKnots">ifc:knotMultiplicities_IfcBSplineCurveWithKnots</a>
    /// </summary>
    let knotMultiplicities_IfcBSplineCurveWithKnots = _prefixId.prefix "knotMultiplicities_IfcBSplineCurveWithKnots"

    /// <summary>
    ///   <para>rdfs:label : KnotSpec^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#knotSpec_IfcBSplineCurveWithKnots">ifc:knotSpec_IfcBSplineCurveWithKnots</a>
    /// </summary>
    let knotSpec_IfcBSplineCurveWithKnots = _prefixId.prefix "knotSpec_IfcBSplineCurveWithKnots"

    /// <summary>
    ///   <para>rdfs:label : KnotSpec^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#knotSpec_IfcBSplineSurfaceWithKnots">ifc:knotSpec_IfcBSplineSurfaceWithKnots</a>
    /// </summary>
    let knotSpec_IfcBSplineSurfaceWithKnots = _prefixId.prefix "knotSpec_IfcBSplineSurfaceWithKnots"

    /// <summary>
    ///   <para>rdfs:label : Knots^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#knots_IfcBSplineCurveWithKnots">ifc:knots_IfcBSplineCurveWithKnots</a>
    /// </summary>
    let knots_IfcBSplineCurveWithKnots = _prefixId.prefix "knots_IfcBSplineCurveWithKnots"

    /// <summary>
    ///   <para>rdfs:label : Label^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#label_IfcCompositeProfileDef">ifc:label_IfcCompositeProfileDef</a>
    /// </summary>
    let label_IfcCompositeProfileDef = _prefixId.prefix "label_IfcCompositeProfileDef"
    /// <summary>
    ///   <para>rdfs:label : Label^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#label_IfcDerivedProfileDef">ifc:label_IfcDerivedProfileDef</a>
    /// </summary>
    let label_IfcDerivedProfileDef = _prefixId.prefix "label_IfcDerivedProfileDef"
    /// <summary>
    ///   <para>rdfs:label : LagValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lagValue_IfcLagTime">ifc:lagValue_IfcLagTime</a>
    /// </summary>
    let lagValue_IfcLagTime = _prefixId.prefix "lagValue_IfcLagTime"
    /// <summary>
    ///   <para>rdfs:label : LandTitleNumber^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#landTitleNumber_IfcSite">ifc:landTitleNumber_IfcSite</a>
    /// </summary>
    let landTitleNumber_IfcSite = _prefixId.prefix "landTitleNumber_IfcSite"
    /// <summary>
    ///   <para>rdfs:label : Language^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#language_IfcLibraryReference">ifc:language_IfcLibraryReference</a>
    /// </summary>
    let language_IfcLibraryReference = _prefixId.prefix "language_IfcLibraryReference"

    /// <summary>
    ///   <para>rdfs:label : LastModifiedDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lastModifiedDate_IfcOwnerHistory">ifc:lastModifiedDate_IfcOwnerHistory</a>
    /// </summary>
    let lastModifiedDate_IfcOwnerHistory = _prefixId.prefix "lastModifiedDate_IfcOwnerHistory"

    /// <summary>
    ///   <para>rdfs:label : LastModifyingApplication^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lastModifyingApplication_IfcOwnerHistory">ifc:lastModifyingApplication_IfcOwnerHistory</a>
    /// </summary>
    let lastModifyingApplication_IfcOwnerHistory = _prefixId.prefix "lastModifyingApplication_IfcOwnerHistory"

    /// <summary>
    ///   <para>rdfs:label : LastModifyingUser^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lastModifyingUser_IfcOwnerHistory">ifc:lastModifyingUser_IfcOwnerHistory</a>
    /// </summary>
    let lastModifyingUser_IfcOwnerHistory = _prefixId.prefix "lastModifyingUser_IfcOwnerHistory"

    /// <summary>
    ///   <para>rdfs:label : LastRevisionTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lastRevisionTime_IfcDocumentInformation">ifc:lastRevisionTime_IfcDocumentInformation</a>
    /// </summary>
    let lastRevisionTime_IfcDocumentInformation = _prefixId.prefix "lastRevisionTime_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : LastUpdateDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lastUpdateDate_IfcInventory">ifc:lastUpdateDate_IfcInventory</a>
    /// </summary>
    let lastUpdateDate_IfcInventory = _prefixId.prefix "lastUpdateDate_IfcInventory"
    /// <summary>
    ///   <para>rdfs:label : LateDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lateDate_IfcEventTime">ifc:lateDate_IfcEventTime</a>
    /// </summary>
    let lateDate_IfcEventTime = _prefixId.prefix "lateDate_IfcEventTime"
    /// <summary>
    ///   <para>rdfs:label : LateFinish^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lateFinish_IfcTaskTime">ifc:lateFinish_IfcTaskTime</a>
    /// </summary>
    let lateFinish_IfcTaskTime = _prefixId.prefix "lateFinish_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : LateStart^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lateStart_IfcTaskTime">ifc:lateStart_IfcTaskTime</a>
    /// </summary>
    let lateStart_IfcTaskTime = _prefixId.prefix "lateStart_IfcTaskTime"

    /// <summary>
    ///   <para>rdfs:label : LayerBlocked^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#layerBlocked_IfcPresentationLayerWithStyle">ifc:layerBlocked_IfcPresentationLayerWithStyle</a>
    /// </summary>
    let layerBlocked_IfcPresentationLayerWithStyle = _prefixId.prefix "layerBlocked_IfcPresentationLayerWithStyle"

    /// <summary>
    ///   <para>rdfs:label : LayerFrozen^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#layerFrozen_IfcPresentationLayerWithStyle">ifc:layerFrozen_IfcPresentationLayerWithStyle</a>
    /// </summary>
    let layerFrozen_IfcPresentationLayerWithStyle = _prefixId.prefix "layerFrozen_IfcPresentationLayerWithStyle"

    /// <summary>
    ///   <para>rdfs:label : LayerOn^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#layerOn_IfcPresentationLayerWithStyle">ifc:layerOn_IfcPresentationLayerWithStyle</a>
    /// </summary>
    let layerOn_IfcPresentationLayerWithStyle = _prefixId.prefix "layerOn_IfcPresentationLayerWithStyle"

    /// <summary>
    ///   <para>rdfs:label : LayerSetDirection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#layerSetDirection_IfcMaterialLayerSetUsage">ifc:layerSetDirection_IfcMaterialLayerSetUsage</a>
    /// </summary>
    let layerSetDirection_IfcMaterialLayerSetUsage = _prefixId.prefix "layerSetDirection_IfcMaterialLayerSetUsage"

    /// <summary>
    ///   <para>rdfs:label : LayerSetName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#layerSetName_IfcMaterialLayerSet">ifc:layerSetName_IfcMaterialLayerSet</a>
    /// </summary>
    let layerSetName_IfcMaterialLayerSet = _prefixId.prefix "layerSetName_IfcMaterialLayerSet"

    /// <summary>
    ///   <para>rdfs:label : LayerStyles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#layerStyles_IfcPresentationLayerWithStyle">ifc:layerStyles_IfcPresentationLayerWithStyle</a>
    /// </summary>
    let layerStyles_IfcPresentationLayerWithStyle = _prefixId.prefix "layerStyles_IfcPresentationLayerWithStyle"

    /// <summary>
    ///   <para>rdfs:label : LayerThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#layerThickness_IfcMaterialLayer">ifc:layerThickness_IfcMaterialLayer</a>
    /// </summary>
    let layerThickness_IfcMaterialLayer = _prefixId.prefix "layerThickness_IfcMaterialLayer"

    /// <summary>
    ///   <para>rdfs:label : LegSlope^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#legSlope_IfcLShapeProfileDef">ifc:legSlope_IfcLShapeProfileDef</a>
    /// </summary>
    let legSlope_IfcLShapeProfileDef = _prefixId.prefix "legSlope_IfcLShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : LengthExponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lengthExponent_IfcDimensionalExponents">ifc:lengthExponent_IfcDimensionalExponents</a>
    /// </summary>
    let lengthExponent_IfcDimensionalExponents = _prefixId.prefix "lengthExponent_IfcDimensionalExponents"

    /// <summary>
    ///   <para>rdfs:label : LengthValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lengthValue_IfcQuantityLength">ifc:lengthValue_IfcQuantityLength</a>
    /// </summary>
    let lengthValue_IfcQuantityLength = _prefixId.prefix "lengthValue_IfcQuantityLength"

    /// <summary>
    ///   <para>rdfs:label : LetterSpacing^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#letterSpacing_IfcTextStyleTextModel">ifc:letterSpacing_IfcTextStyleTextModel</a>
    /// </summary>
    let letterSpacing_IfcTextStyleTextModel = _prefixId.prefix "letterSpacing_IfcTextStyleTextModel"

    /// <summary>
    ///   <para>rdfs:label : Level^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#level_IfcApproval">ifc:level_IfcApproval</a>
    /// </summary>
    let level_IfcApproval = _prefixId.prefix "level_IfcApproval"
    /// <summary>
    ///   <para>rdfs:label : LevelingDelay^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#levelingDelay_IfcResourceTime">ifc:levelingDelay_IfcResourceTime</a>
    /// </summary>
    let levelingDelay_IfcResourceTime = _prefixId.prefix "levelingDelay_IfcResourceTime"

    /// <summary>
    ///   <para>rdfs:label : LifeCyclePhase^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lifeCyclePhase_IfcPerformanceHistory">ifc:lifeCyclePhase_IfcPerformanceHistory</a>
    /// </summary>
    let lifeCyclePhase_IfcPerformanceHistory = _prefixId.prefix "lifeCyclePhase_IfcPerformanceHistory"

    /// <summary>
    ///   <para>rdfs:label : LightColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lightColour_IfcLightSource">ifc:lightColour_IfcLightSource</a>
    /// </summary>
    let lightColour_IfcLightSource = _prefixId.prefix "lightColour_IfcLightSource"

    /// <summary>
    ///   <para>rdfs:label : LightDistributionCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lightDistributionCurve_IfcLightIntensityDistribution">ifc:lightDistributionCurve_IfcLightIntensityDistribution</a>
    /// </summary>
    let lightDistributionCurve_IfcLightIntensityDistribution = _prefixId.prefix "lightDistributionCurve_IfcLightIntensityDistribution"

    /// <summary>
    ///   <para>rdfs:label : LightDistributionDataSource^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lightDistributionDataSource_IfcLightSourceGoniometric">ifc:lightDistributionDataSource_IfcLightSourceGoniometric</a>
    /// </summary>
    let lightDistributionDataSource_IfcLightSourceGoniometric = _prefixId.prefix "lightDistributionDataSource_IfcLightSourceGoniometric"

    /// <summary>
    ///   <para>rdfs:label : LightEmissionSource^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lightEmissionSource_IfcLightSourceGoniometric">ifc:lightEmissionSource_IfcLightSourceGoniometric</a>
    /// </summary>
    let lightEmissionSource_IfcLightSourceGoniometric = _prefixId.prefix "lightEmissionSource_IfcLightSourceGoniometric"

    /// <summary>
    ///   <para>rdfs:label : LineHeight^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lineHeight_IfcTextStyleTextModel">ifc:lineHeight_IfcTextStyleTextModel</a>
    /// </summary>
    let lineHeight_IfcTextStyleTextModel = _prefixId.prefix "lineHeight_IfcTextStyleTextModel"

    /// <summary>
    ///   <para>rdfs:label : LinearForceX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#linearForceX_IfcStructuralLoadLinearForce">ifc:linearForceX_IfcStructuralLoadLinearForce</a>
    /// </summary>
    let linearForceX_IfcStructuralLoadLinearForce = _prefixId.prefix "linearForceX_IfcStructuralLoadLinearForce"

    /// <summary>
    ///   <para>rdfs:label : LinearForceY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#linearForceY_IfcStructuralLoadLinearForce">ifc:linearForceY_IfcStructuralLoadLinearForce</a>
    /// </summary>
    let linearForceY_IfcStructuralLoadLinearForce = _prefixId.prefix "linearForceY_IfcStructuralLoadLinearForce"

    /// <summary>
    ///   <para>rdfs:label : LinearForceZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#linearForceZ_IfcStructuralLoadLinearForce">ifc:linearForceZ_IfcStructuralLoadLinearForce</a>
    /// </summary>
    let linearForceZ_IfcStructuralLoadLinearForce = _prefixId.prefix "linearForceZ_IfcStructuralLoadLinearForce"

    /// <summary>
    ///   <para>rdfs:label : LinearMomentX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#linearMomentX_IfcStructuralLoadLinearForce">ifc:linearMomentX_IfcStructuralLoadLinearForce</a>
    /// </summary>
    let linearMomentX_IfcStructuralLoadLinearForce = _prefixId.prefix "linearMomentX_IfcStructuralLoadLinearForce"

    /// <summary>
    ///   <para>rdfs:label : LinearMomentY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#linearMomentY_IfcStructuralLoadLinearForce">ifc:linearMomentY_IfcStructuralLoadLinearForce</a>
    /// </summary>
    let linearMomentY_IfcStructuralLoadLinearForce = _prefixId.prefix "linearMomentY_IfcStructuralLoadLinearForce"

    /// <summary>
    ///   <para>rdfs:label : LinearMomentZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#linearMomentZ_IfcStructuralLoadLinearForce">ifc:linearMomentZ_IfcStructuralLoadLinearForce</a>
    /// </summary>
    let linearMomentZ_IfcStructuralLoadLinearForce = _prefixId.prefix "linearMomentZ_IfcStructuralLoadLinearForce"

    /// <summary>
    ///   <para>rdfs:label : LiningDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningDepth_IfcDoorLiningProperties">ifc:liningDepth_IfcDoorLiningProperties</a>
    /// </summary>
    let liningDepth_IfcDoorLiningProperties = _prefixId.prefix "liningDepth_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : LiningDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningDepth_IfcWindowLiningProperties">ifc:liningDepth_IfcWindowLiningProperties</a>
    /// </summary>
    let liningDepth_IfcWindowLiningProperties = _prefixId.prefix "liningDepth_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : LiningOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningOffset_IfcDoorLiningProperties">ifc:liningOffset_IfcDoorLiningProperties</a>
    /// </summary>
    let liningOffset_IfcDoorLiningProperties = _prefixId.prefix "liningOffset_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : LiningOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningOffset_IfcWindowLiningProperties">ifc:liningOffset_IfcWindowLiningProperties</a>
    /// </summary>
    let liningOffset_IfcWindowLiningProperties = _prefixId.prefix "liningOffset_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : LiningThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningThickness_IfcDoorLiningProperties">ifc:liningThickness_IfcDoorLiningProperties</a>
    /// </summary>
    let liningThickness_IfcDoorLiningProperties = _prefixId.prefix "liningThickness_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : LiningThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningThickness_IfcWindowLiningProperties">ifc:liningThickness_IfcWindowLiningProperties</a>
    /// </summary>
    let liningThickness_IfcWindowLiningProperties = _prefixId.prefix "liningThickness_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : LiningToPanelOffsetX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningToPanelOffsetX_IfcDoorLiningProperties">ifc:liningToPanelOffsetX_IfcDoorLiningProperties</a>
    /// </summary>
    let liningToPanelOffsetX_IfcDoorLiningProperties = _prefixId.prefix "liningToPanelOffsetX_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : LiningToPanelOffsetX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningToPanelOffsetX_IfcWindowLiningProperties">ifc:liningToPanelOffsetX_IfcWindowLiningProperties</a>
    /// </summary>
    let liningToPanelOffsetX_IfcWindowLiningProperties = _prefixId.prefix "liningToPanelOffsetX_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : LiningToPanelOffsetY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningToPanelOffsetY_IfcDoorLiningProperties">ifc:liningToPanelOffsetY_IfcDoorLiningProperties</a>
    /// </summary>
    let liningToPanelOffsetY_IfcDoorLiningProperties = _prefixId.prefix "liningToPanelOffsetY_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : LiningToPanelOffsetY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#liningToPanelOffsetY_IfcWindowLiningProperties">ifc:liningToPanelOffsetY_IfcWindowLiningProperties</a>
    /// </summary>
    let liningToPanelOffsetY_IfcWindowLiningProperties = _prefixId.prefix "liningToPanelOffsetY_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : ListPositions^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#listPositions_IfcReference">ifc:listPositions_IfcReference</a>
    /// </summary>
    let listPositions_IfcReference = _prefixId.prefix "listPositions_IfcReference"

    /// <summary>
    ///   <para>rdfs:label : ListValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#listValues_IfcIrregularTimeSeriesValue">ifc:listValues_IfcIrregularTimeSeriesValue</a>
    /// </summary>
    let listValues_IfcIrregularTimeSeriesValue = _prefixId.prefix "listValues_IfcIrregularTimeSeriesValue"

    /// <summary>
    ///   <para>rdfs:label : ListValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#listValues_IfcPropertyListValue">ifc:listValues_IfcPropertyListValue</a>
    /// </summary>
    let listValues_IfcPropertyListValue = _prefixId.prefix "listValues_IfcPropertyListValue"

    /// <summary>
    ///   <para>rdfs:label : ListValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#listValues_IfcTimeSeriesValue">ifc:listValues_IfcTimeSeriesValue</a>
    /// </summary>
    let listValues_IfcTimeSeriesValue = _prefixId.prefix "listValues_IfcTimeSeriesValue"
    /// <summary>
    ///   <para>rdfs:label : Literal^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#literal_IfcTextLiteral">ifc:literal_IfcTextLiteral</a>
    /// </summary>
    let literal_IfcTextLiteral = _prefixId.prefix "literal_IfcTextLiteral"

    /// <summary>
    ///   <para>rdfs:label : LoadGroupFor^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#loadGroupFor_IfcStructuralLoadGroup">ifc:loadGroupFor_IfcStructuralLoadGroup</a>
    /// </summary>
    let loadGroupFor_IfcStructuralLoadGroup = _prefixId.prefix "loadGroupFor_IfcStructuralLoadGroup"

    /// <summary>
    ///   <para>rdfs:label : LoadedBy^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#loadedBy_IfcStructuralAnalysisModel">ifc:loadedBy_IfcStructuralAnalysisModel</a>
    /// </summary>
    let loadedBy_IfcStructuralAnalysisModel = _prefixId.prefix "loadedBy_IfcStructuralAnalysisModel"

    /// <summary>
    ///   <para>rdfs:label : LocalOrigin^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#localOrigin_IfcCartesianTransformationOperator">ifc:localOrigin_IfcCartesianTransformationOperator</a>
    /// </summary>
    let localOrigin_IfcCartesianTransformationOperator = _prefixId.prefix "localOrigin_IfcCartesianTransformationOperator"

    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#location_IfcClassification">ifc:location_IfcClassification</a>
    /// </summary>
    let location_IfcClassification = _prefixId.prefix "location_IfcClassification"

    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#location_IfcDocumentInformation">ifc:location_IfcDocumentInformation</a>
    /// </summary>
    let location_IfcDocumentInformation = _prefixId.prefix "location_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#location_IfcExternalReference">ifc:location_IfcExternalReference</a>
    /// </summary>
    let location_IfcExternalReference = _prefixId.prefix "location_IfcExternalReference"

    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#location_IfcLibraryInformation">ifc:location_IfcLibraryInformation</a>
    /// </summary>
    let location_IfcLibraryInformation = _prefixId.prefix "location_IfcLibraryInformation"

    /// <summary>
    ///   <para>rdfs:label : Location^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#location_IfcPlacement">ifc:location_IfcPlacement</a>
    /// </summary>
    let location_IfcPlacement = _prefixId.prefix "location_IfcPlacement"

    /// <summary>
    ///   <para>rdfs:label : Locations^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#locations_IfcStructuralLoadConfiguration">ifc:locations_IfcStructuralLoadConfiguration</a>
    /// </summary>
    let locations_IfcStructuralLoadConfiguration = _prefixId.prefix "locations_IfcStructuralLoadConfiguration"

    /// <summary>
    ///   <para>rdfs:label : LogicalAggregator^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#logicalAggregator_IfcObjective">ifc:logicalAggregator_IfcObjective</a>
    /// </summary>
    let logicalAggregator_IfcObjective = _prefixId.prefix "logicalAggregator_IfcObjective"

    /// <summary>
    ///   <para>rdfs:label : LongDescription^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longDescription_IfcActionRequest">ifc:longDescription_IfcActionRequest</a>
    /// </summary>
    let longDescription_IfcActionRequest = _prefixId.prefix "longDescription_IfcActionRequest"

    /// <summary>
    ///   <para>rdfs:label : LongDescription^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longDescription_IfcPermit">ifc:longDescription_IfcPermit</a>
    /// </summary>
    let longDescription_IfcPermit = _prefixId.prefix "longDescription_IfcPermit"
    /// <summary>
    ///   <para>rdfs:label : LongDescription^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longDescription_IfcProcess">ifc:longDescription_IfcProcess</a>
    /// </summary>
    let longDescription_IfcProcess = _prefixId.prefix "longDescription_IfcProcess"

    /// <summary>
    ///   <para>rdfs:label : LongDescription^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longDescription_IfcProjectOrder">ifc:longDescription_IfcProjectOrder</a>
    /// </summary>
    let longDescription_IfcProjectOrder = _prefixId.prefix "longDescription_IfcProjectOrder"

    /// <summary>
    ///   <para>rdfs:label : LongDescription^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longDescription_IfcResource">ifc:longDescription_IfcResource</a>
    /// </summary>
    let longDescription_IfcResource = _prefixId.prefix "longDescription_IfcResource"

    /// <summary>
    ///   <para>rdfs:label : LongDescription^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longDescription_IfcTypeProcess">ifc:longDescription_IfcTypeProcess</a>
    /// </summary>
    let longDescription_IfcTypeProcess = _prefixId.prefix "longDescription_IfcTypeProcess"

    /// <summary>
    ///   <para>rdfs:label : LongDescription^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longDescription_IfcTypeResource">ifc:longDescription_IfcTypeResource</a>
    /// </summary>
    let longDescription_IfcTypeResource = _prefixId.prefix "longDescription_IfcTypeResource"

    /// <summary>
    ///   <para>rdfs:label : LongName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longName_IfcBuildingSystem">ifc:longName_IfcBuildingSystem</a>
    /// </summary>
    let longName_IfcBuildingSystem = _prefixId.prefix "longName_IfcBuildingSystem"
    /// <summary>
    ///   <para>rdfs:label : LongName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longName_IfcContext">ifc:longName_IfcContext</a>
    /// </summary>
    let longName_IfcContext = _prefixId.prefix "longName_IfcContext"

    /// <summary>
    ///   <para>rdfs:label : LongName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longName_IfcDistributionSystem">ifc:longName_IfcDistributionSystem</a>
    /// </summary>
    let longName_IfcDistributionSystem = _prefixId.prefix "longName_IfcDistributionSystem"

    /// <summary>
    ///   <para>rdfs:label : LongName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longName_IfcSpaceType">ifc:longName_IfcSpaceType</a>
    /// </summary>
    let longName_IfcSpaceType = _prefixId.prefix "longName_IfcSpaceType"
    /// <summary>
    ///   <para>rdfs:label : LongName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longName_IfcSpatialElement">ifc:longName_IfcSpatialElement</a>
    /// </summary>
    let longName_IfcSpatialElement = _prefixId.prefix "longName_IfcSpatialElement"
    /// <summary>
    ///   <para>rdfs:label : LongName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longName_IfcSpatialZoneType">ifc:longName_IfcSpatialZoneType</a>
    /// </summary>
    let longName_IfcSpatialZoneType = _prefixId.prefix "longName_IfcSpatialZoneType"
    /// <summary>
    ///   <para>rdfs:label : LongName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longName_IfcZone">ifc:longName_IfcZone</a>
    /// </summary>
    let longName_IfcZone = _prefixId.prefix "longName_IfcZone"

    /// <summary>
    ///   <para>rdfs:label : LongitudinalBarCrossSectionArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longitudinalBarCrossSectionArea_IfcReinforcingMesh">ifc:longitudinalBarCrossSectionArea_IfcReinforcingMesh</a>
    /// </summary>
    let longitudinalBarCrossSectionArea_IfcReinforcingMesh = _prefixId.prefix "longitudinalBarCrossSectionArea_IfcReinforcingMesh"

    /// <summary>
    ///   <para>rdfs:label : LongitudinalBarCrossSectionArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longitudinalBarCrossSectionArea_IfcReinforcingMeshType">ifc:longitudinalBarCrossSectionArea_IfcReinforcingMeshType</a>
    /// </summary>
    let longitudinalBarCrossSectionArea_IfcReinforcingMeshType = _prefixId.prefix "longitudinalBarCrossSectionArea_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : LongitudinalBarNominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longitudinalBarNominalDiameter_IfcReinforcingMesh">ifc:longitudinalBarNominalDiameter_IfcReinforcingMesh</a>
    /// </summary>
    let longitudinalBarNominalDiameter_IfcReinforcingMesh = _prefixId.prefix "longitudinalBarNominalDiameter_IfcReinforcingMesh"

    /// <summary>
    ///   <para>rdfs:label : LongitudinalBarNominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longitudinalBarNominalDiameter_IfcReinforcingMeshType">ifc:longitudinalBarNominalDiameter_IfcReinforcingMeshType</a>
    /// </summary>
    let longitudinalBarNominalDiameter_IfcReinforcingMeshType = _prefixId.prefix "longitudinalBarNominalDiameter_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : LongitudinalBarSpacing^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longitudinalBarSpacing_IfcReinforcingMesh">ifc:longitudinalBarSpacing_IfcReinforcingMesh</a>
    /// </summary>
    let longitudinalBarSpacing_IfcReinforcingMesh = _prefixId.prefix "longitudinalBarSpacing_IfcReinforcingMesh"

    /// <summary>
    ///   <para>rdfs:label : LongitudinalBarSpacing^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longitudinalBarSpacing_IfcReinforcingMeshType">ifc:longitudinalBarSpacing_IfcReinforcingMeshType</a>
    /// </summary>
    let longitudinalBarSpacing_IfcReinforcingMeshType = _prefixId.prefix "longitudinalBarSpacing_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : LongitudinalEndPosition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longitudinalEndPosition_IfcSectionReinforcementProperties">ifc:longitudinalEndPosition_IfcSectionReinforcementProperties</a>
    /// </summary>
    let longitudinalEndPosition_IfcSectionReinforcementProperties = _prefixId.prefix "longitudinalEndPosition_IfcSectionReinforcementProperties"

    /// <summary>
    ///   <para>rdfs:label : LongitudinalStartPosition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#longitudinalStartPosition_IfcSectionReinforcementProperties">ifc:longitudinalStartPosition_IfcSectionReinforcementProperties</a>
    /// </summary>
    let longitudinalStartPosition_IfcSectionReinforcementProperties = _prefixId.prefix "longitudinalStartPosition_IfcSectionReinforcementProperties"

    /// <summary>
    ///   <para>rdfs:label : LoopVertex^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#loopVertex_IfcVertexLoop">ifc:loopVertex_IfcVertexLoop</a>
    /// </summary>
    let loopVertex_IfcVertexLoop = _prefixId.prefix "loopVertex_IfcVertexLoop"

    /// <summary>
    ///   <para>rdfs:label : LowerBoundValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#lowerBoundValue_IfcPropertyBoundedValue">ifc:lowerBoundValue_IfcPropertyBoundedValue</a>
    /// </summary>
    let lowerBoundValue_IfcPropertyBoundedValue = _prefixId.prefix "lowerBoundValue_IfcPropertyBoundedValue"

    /// <summary>
    ///   <para>rdfs:label : LuminousFlux^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#luminousFlux_IfcLightSourceGoniometric">ifc:luminousFlux_IfcLightSourceGoniometric</a>
    /// </summary>
    let luminousFlux_IfcLightSourceGoniometric = _prefixId.prefix "luminousFlux_IfcLightSourceGoniometric"

    /// <summary>
    ///   <para>rdfs:label : LuminousIntensityExponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#luminousIntensityExponent_IfcDimensionalExponents">ifc:luminousIntensityExponent_IfcDimensionalExponents</a>
    /// </summary>
    let luminousIntensityExponent_IfcDimensionalExponents = _prefixId.prefix "luminousIntensityExponent_IfcDimensionalExponents"

    /// <summary>
    ///   <para>rdfs:label : LuminousIntensity^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#luminousIntensity_IfcLightDistributionData">ifc:luminousIntensity_IfcLightDistributionData</a>
    /// </summary>
    let luminousIntensity_IfcLightDistributionData = _prefixId.prefix "luminousIntensity_IfcLightDistributionData"

    /// <summary>
    ///   <para>rdfs:label : Magnitude^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#magnitude_IfcVector">ifc:magnitude_IfcVector</a>
    /// </summary>
    let magnitude_IfcVector = _prefixId.prefix "magnitude_IfcVector"

    /// <summary>
    ///   <para>rdfs:label : MainPlaneAngle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mainPlaneAngle_IfcLightDistributionData">ifc:mainPlaneAngle_IfcLightDistributionData</a>
    /// </summary>
    let mainPlaneAngle_IfcLightDistributionData = _prefixId.prefix "mainPlaneAngle_IfcLightDistributionData"

    /// <summary>
    ///   <para>rdfs:label : MapProjection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mapProjection_IfcProjectedCRS">ifc:mapProjection_IfcProjectedCRS</a>
    /// </summary>
    let mapProjection_IfcProjectedCRS = _prefixId.prefix "mapProjection_IfcProjectedCRS"
    /// <summary>
    ///   <para>rdfs:label : MapUnit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mapUnit_IfcProjectedCRS">ifc:mapUnit_IfcProjectedCRS</a>
    /// </summary>
    let mapUnit_IfcProjectedCRS = _prefixId.prefix "mapUnit_IfcProjectedCRS"
    /// <summary>
    ///   <para>rdfs:label : MapUsage^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mapUsage_IfcRepresentationMap">ifc:mapUsage_IfcRepresentationMap</a>
    /// </summary>
    let mapUsage_IfcRepresentationMap = _prefixId.prefix "mapUsage_IfcRepresentationMap"
    /// <summary>
    ///   <para>rdfs:label : MapZone^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mapZone_IfcProjectedCRS">ifc:mapZone_IfcProjectedCRS</a>
    /// </summary>
    let mapZone_IfcProjectedCRS = _prefixId.prefix "mapZone_IfcProjectedCRS"

    /// <summary>
    ///   <para>rdfs:label : MappedRepresentation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mappedRepresentation_IfcRepresentationMap">ifc:mappedRepresentation_IfcRepresentationMap</a>
    /// </summary>
    let mappedRepresentation_IfcRepresentationMap = _prefixId.prefix "mappedRepresentation_IfcRepresentationMap"

    /// <summary>
    ///   <para>rdfs:label : MappedTo^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mappedTo_IfcIndexedColourMap">ifc:mappedTo_IfcIndexedColourMap</a>
    /// </summary>
    let mappedTo_IfcIndexedColourMap = _prefixId.prefix "mappedTo_IfcIndexedColourMap"
    /// <summary>
    ///   <para>rdfs:label : MappedTo^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mappedTo_IfcIndexedTextureMap">ifc:mappedTo_IfcIndexedTextureMap</a>
    /// </summary>
    let mappedTo_IfcIndexedTextureMap = _prefixId.prefix "mappedTo_IfcIndexedTextureMap"
    /// <summary>
    ///   <para>rdfs:label : MappedTo^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mappedTo_IfcTextureMap">ifc:mappedTo_IfcTextureMap</a>
    /// </summary>
    let mappedTo_IfcTextureMap = _prefixId.prefix "mappedTo_IfcTextureMap"

    /// <summary>
    ///   <para>rdfs:label : MappingOrigin^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mappingOrigin_IfcRepresentationMap">ifc:mappingOrigin_IfcRepresentationMap</a>
    /// </summary>
    let mappingOrigin_IfcRepresentationMap = _prefixId.prefix "mappingOrigin_IfcRepresentationMap"

    /// <summary>
    ///   <para>rdfs:label : MappingSource^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mappingSource_IfcMappedItem">ifc:mappingSource_IfcMappedItem</a>
    /// </summary>
    let mappingSource_IfcMappedItem = _prefixId.prefix "mappingSource_IfcMappedItem"
    /// <summary>
    ///   <para>rdfs:label : MappingTarget^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mappingTarget_IfcMappedItem">ifc:mappingTarget_IfcMappedItem</a>
    /// </summary>
    let mappingTarget_IfcMappedItem = _prefixId.prefix "mappingTarget_IfcMappedItem"
    /// <summary>
    ///   <para>rdfs:label : Maps^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#maps_IfcTextureCoordinate">ifc:maps_IfcTextureCoordinate</a>
    /// </summary>
    let maps_IfcTextureCoordinate = _prefixId.prefix "maps_IfcTextureCoordinate"

    /// <summary>
    ///   <para>rdfs:label : MassExponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#massExponent_IfcDimensionalExponents">ifc:massExponent_IfcDimensionalExponents</a>
    /// </summary>
    let massExponent_IfcDimensionalExponents = _prefixId.prefix "massExponent_IfcDimensionalExponents"

    /// <summary>
    ///   <para>rdfs:label : MasterRepresentation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#masterRepresentation_IfcTrimmedCurve">ifc:masterRepresentation_IfcTrimmedCurve</a>
    /// </summary>
    let masterRepresentation_IfcTrimmedCurve = _prefixId.prefix "masterRepresentation_IfcTrimmedCurve"

    /// <summary>
    ///   <para>rdfs:label : MaterialClassifications^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#materialClassifications_IfcMaterialClassificationRelationship">ifc:materialClassifications_IfcMaterialClassificationRelationship</a>
    /// </summary>
    let materialClassifications_IfcMaterialClassificationRelationship = _prefixId.prefix "materialClassifications_IfcMaterialClassificationRelationship"

    /// <summary>
    ///   <para>rdfs:label : MaterialConstituents^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#materialConstituents_IfcMaterialConstituentSet">ifc:materialConstituents_IfcMaterialConstituentSet</a>
    /// </summary>
    let materialConstituents_IfcMaterialConstituentSet = _prefixId.prefix "materialConstituents_IfcMaterialConstituentSet"

    /// <summary>
    ///   <para>rdfs:label : MaterialLayers^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#materialLayers_IfcMaterialLayerSet">ifc:materialLayers_IfcMaterialLayerSet</a>
    /// </summary>
    let materialLayers_IfcMaterialLayerSet = _prefixId.prefix "materialLayers_IfcMaterialLayerSet"

    /// <summary>
    ///   <para>rdfs:label : MaterialProfiles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#materialProfiles_IfcMaterialProfileSet">ifc:materialProfiles_IfcMaterialProfileSet</a>
    /// </summary>
    let materialProfiles_IfcMaterialProfileSet = _prefixId.prefix "materialProfiles_IfcMaterialProfileSet"

    /// <summary>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#material_IfcMaterialConstituent">ifc:material_IfcMaterialConstituent</a>
    /// </summary>
    let material_IfcMaterialConstituent = _prefixId.prefix "material_IfcMaterialConstituent"

    /// <summary>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#material_IfcMaterialLayer">ifc:material_IfcMaterialLayer</a>
    /// </summary>
    let material_IfcMaterialLayer = _prefixId.prefix "material_IfcMaterialLayer"
    /// <summary>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#material_IfcMaterialProfile">ifc:material_IfcMaterialProfile</a>
    /// </summary>
    let material_IfcMaterialProfile = _prefixId.prefix "material_IfcMaterialProfile"

    /// <summary>
    ///   <para>rdfs:label : Material^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#material_IfcMaterialProperties">ifc:material_IfcMaterialProperties</a>
    /// </summary>
    let material_IfcMaterialProperties = _prefixId.prefix "material_IfcMaterialProperties"

    /// <summary>
    ///   <para>rdfs:label : Materials^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#materials_IfcMaterialList">ifc:materials_IfcMaterialList</a>
    /// </summary>
    let materials_IfcMaterialList = _prefixId.prefix "materials_IfcMaterialList"
    /// <summary>
    ///   <para>rdfs:label : MeshLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#meshLength_IfcReinforcingMesh">ifc:meshLength_IfcReinforcingMesh</a>
    /// </summary>
    let meshLength_IfcReinforcingMesh = _prefixId.prefix "meshLength_IfcReinforcingMesh"

    /// <summary>
    ///   <para>rdfs:label : MeshLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#meshLength_IfcReinforcingMeshType">ifc:meshLength_IfcReinforcingMeshType</a>
    /// </summary>
    let meshLength_IfcReinforcingMeshType = _prefixId.prefix "meshLength_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : MeshWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#meshWidth_IfcReinforcingMesh">ifc:meshWidth_IfcReinforcingMesh</a>
    /// </summary>
    let meshWidth_IfcReinforcingMesh = _prefixId.prefix "meshWidth_IfcReinforcingMesh"

    /// <summary>
    ///   <para>rdfs:label : MeshWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#meshWidth_IfcReinforcingMeshType">ifc:meshWidth_IfcReinforcingMeshType</a>
    /// </summary>
    let meshWidth_IfcReinforcingMeshType = _prefixId.prefix "meshWidth_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : MessagingIDs^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#messagingIDs_IfcTelecomAddress">ifc:messagingIDs_IfcTelecomAddress</a>
    /// </summary>
    let messagingIDs_IfcTelecomAddress = _prefixId.prefix "messagingIDs_IfcTelecomAddress"

    /// <summary>
    ///   <para>rdfs:label : MethodOfMeasurement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#methodOfMeasurement_IfcElementQuantity">ifc:methodOfMeasurement_IfcElementQuantity</a>
    /// </summary>
    let methodOfMeasurement_IfcElementQuantity = _prefixId.prefix "methodOfMeasurement_IfcElementQuantity"

    /// <summary>
    ///   <para>rdfs:label : MiddleNames^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#middleNames_IfcPerson">ifc:middleNames_IfcPerson</a>
    /// </summary>
    let middleNames_IfcPerson = _prefixId.prefix "middleNames_IfcPerson"
    /// <summary>
    ///   <para>rdfs:label : MinCurvatureRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#minCurvatureRadius_IfcTendon">ifc:minCurvatureRadius_IfcTendon</a>
    /// </summary>
    let minCurvatureRadius_IfcTendon = _prefixId.prefix "minCurvatureRadius_IfcTendon"
    /// <summary>
    ///   <para>rdfs:label : Mode^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mode_IfcSurfaceTexture">ifc:mode_IfcSurfaceTexture</a>
    /// </summary>
    let mode_IfcSurfaceTexture = _prefixId.prefix "mode_IfcSurfaceTexture"

    /// <summary>
    ///   <para>rdfs:label : Mode^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mode_IfcTextureCoordinateGenerator">ifc:mode_IfcTextureCoordinateGenerator</a>
    /// </summary>
    let mode_IfcTextureCoordinateGenerator = _prefixId.prefix "mode_IfcTextureCoordinateGenerator"

    /// <summary>
    ///   <para>rdfs:label : ModelOrDraughting^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#modelOrDraughting_IfcCurveStyle">ifc:modelOrDraughting_IfcCurveStyle</a>
    /// </summary>
    let modelOrDraughting_IfcCurveStyle = _prefixId.prefix "modelOrDraughting_IfcCurveStyle"

    /// <summary>
    ///   <para>rdfs:label : ModelOrDraughting^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#modelOrDraughting_IfcTextStyle">ifc:modelOrDraughting_IfcTextStyle</a>
    /// </summary>
    let modelOrDraughting_IfcTextStyle = _prefixId.prefix "modelOrDraughting_IfcTextStyle"

    /// <summary>
    ///   <para>rdfs:label : ModelorDraughting^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#modelorDraughting_IfcFillAreaStyle">ifc:modelorDraughting_IfcFillAreaStyle</a>
    /// </summary>
    let modelorDraughting_IfcFillAreaStyle = _prefixId.prefix "modelorDraughting_IfcFillAreaStyle"

    /// <summary>
    ///   <para>rdfs:label : MomentX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#momentX_IfcStructuralLoadSingleForce">ifc:momentX_IfcStructuralLoadSingleForce</a>
    /// </summary>
    let momentX_IfcStructuralLoadSingleForce = _prefixId.prefix "momentX_IfcStructuralLoadSingleForce"

    /// <summary>
    ///   <para>rdfs:label : MomentY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#momentY_IfcStructuralLoadSingleForce">ifc:momentY_IfcStructuralLoadSingleForce</a>
    /// </summary>
    let momentY_IfcStructuralLoadSingleForce = _prefixId.prefix "momentY_IfcStructuralLoadSingleForce"

    /// <summary>
    ///   <para>rdfs:label : MomentZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#momentZ_IfcStructuralLoadSingleForce">ifc:momentZ_IfcStructuralLoadSingleForce</a>
    /// </summary>
    let momentZ_IfcStructuralLoadSingleForce = _prefixId.prefix "momentZ_IfcStructuralLoadSingleForce"

    /// <summary>
    ///   <para>rdfs:label : MonthComponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#monthComponent_IfcRecurrencePattern">ifc:monthComponent_IfcRecurrencePattern</a>
    /// </summary>
    let monthComponent_IfcRecurrencePattern = _prefixId.prefix "monthComponent_IfcRecurrencePattern"

    /// <summary>
    ///   <para>rdfs:label : MullionThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#mullionThickness_IfcWindowLiningProperties">ifc:mullionThickness_IfcWindowLiningProperties</a>
    /// </summary>
    let mullionThickness_IfcWindowLiningProperties = _prefixId.prefix "mullionThickness_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcAppliedValue">ifc:name_IfcAppliedValue</a>
    /// </summary>
    let name_IfcAppliedValue = _prefixId.prefix "name_IfcAppliedValue"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcApproval">ifc:name_IfcApproval</a>
    /// </summary>
    let name_IfcApproval = _prefixId.prefix "name_IfcApproval"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcBoundaryCondition">ifc:name_IfcBoundaryCondition</a>
    /// </summary>
    let name_IfcBoundaryCondition = _prefixId.prefix "name_IfcBoundaryCondition"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcClassification">ifc:name_IfcClassification</a>
    /// </summary>
    let name_IfcClassification = _prefixId.prefix "name_IfcClassification"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcColourSpecification">ifc:name_IfcColourSpecification</a>
    /// </summary>
    let name_IfcColourSpecification = _prefixId.prefix "name_IfcColourSpecification"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcConstraint">ifc:name_IfcConstraint</a>
    /// </summary>
    let name_IfcConstraint = _prefixId.prefix "name_IfcConstraint"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcContextDependentUnit">ifc:name_IfcContextDependentUnit</a>
    /// </summary>
    let name_IfcContextDependentUnit = _prefixId.prefix "name_IfcContextDependentUnit"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcConversionBasedUnit">ifc:name_IfcConversionBasedUnit</a>
    /// </summary>
    let name_IfcConversionBasedUnit = _prefixId.prefix "name_IfcConversionBasedUnit"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcCoordinateReferenceSystem">ifc:name_IfcCoordinateReferenceSystem</a>
    /// </summary>
    let name_IfcCoordinateReferenceSystem = _prefixId.prefix "name_IfcCoordinateReferenceSystem"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcCurveStyleFont">ifc:name_IfcCurveStyleFont</a>
    /// </summary>
    let name_IfcCurveStyleFont = _prefixId.prefix "name_IfcCurveStyleFont"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcCurveStyleFontAndScaling">ifc:name_IfcCurveStyleFontAndScaling</a>
    /// </summary>
    let name_IfcCurveStyleFontAndScaling = _prefixId.prefix "name_IfcCurveStyleFontAndScaling"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcDocumentInformation">ifc:name_IfcDocumentInformation</a>
    /// </summary>
    let name_IfcDocumentInformation = _prefixId.prefix "name_IfcDocumentInformation"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcExtendedProperties">ifc:name_IfcExtendedProperties</a>
    /// </summary>
    let name_IfcExtendedProperties = _prefixId.prefix "name_IfcExtendedProperties"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcExternalReference">ifc:name_IfcExternalReference</a>
    /// </summary>
    let name_IfcExternalReference = _prefixId.prefix "name_IfcExternalReference"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcLibraryInformation">ifc:name_IfcLibraryInformation</a>
    /// </summary>
    let name_IfcLibraryInformation = _prefixId.prefix "name_IfcLibraryInformation"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcLightSource">ifc:name_IfcLightSource</a>
    /// </summary>
    let name_IfcLightSource = _prefixId.prefix "name_IfcLightSource"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcMaterial">ifc:name_IfcMaterial</a>
    /// </summary>
    let name_IfcMaterial = _prefixId.prefix "name_IfcMaterial"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcMaterialConstituent">ifc:name_IfcMaterialConstituent</a>
    /// </summary>
    let name_IfcMaterialConstituent = _prefixId.prefix "name_IfcMaterialConstituent"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcMaterialConstituentSet">ifc:name_IfcMaterialConstituentSet</a>
    /// </summary>
    let name_IfcMaterialConstituentSet = _prefixId.prefix "name_IfcMaterialConstituentSet"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcMaterialLayer">ifc:name_IfcMaterialLayer</a>
    /// </summary>
    let name_IfcMaterialLayer = _prefixId.prefix "name_IfcMaterialLayer"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcMaterialProfile">ifc:name_IfcMaterialProfile</a>
    /// </summary>
    let name_IfcMaterialProfile = _prefixId.prefix "name_IfcMaterialProfile"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcMaterialProfileSet">ifc:name_IfcMaterialProfileSet</a>
    /// </summary>
    let name_IfcMaterialProfileSet = _prefixId.prefix "name_IfcMaterialProfileSet"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcOrganization">ifc:name_IfcOrganization</a>
    /// </summary>
    let name_IfcOrganization = _prefixId.prefix "name_IfcOrganization"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcPhysicalQuantity">ifc:name_IfcPhysicalQuantity</a>
    /// </summary>
    let name_IfcPhysicalQuantity = _prefixId.prefix "name_IfcPhysicalQuantity"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcPreDefinedItem">ifc:name_IfcPreDefinedItem</a>
    /// </summary>
    let name_IfcPreDefinedItem = _prefixId.prefix "name_IfcPreDefinedItem"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcPresentationLayerAssignment">ifc:name_IfcPresentationLayerAssignment</a>
    /// </summary>
    let name_IfcPresentationLayerAssignment = _prefixId.prefix "name_IfcPresentationLayerAssignment"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcPresentationStyle">ifc:name_IfcPresentationStyle</a>
    /// </summary>
    let name_IfcPresentationStyle = _prefixId.prefix "name_IfcPresentationStyle"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcProductRepresentation">ifc:name_IfcProductRepresentation</a>
    /// </summary>
    let name_IfcProductRepresentation = _prefixId.prefix "name_IfcProductRepresentation"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcProperty">ifc:name_IfcProperty</a>
    /// </summary>
    let name_IfcProperty = _prefixId.prefix "name_IfcProperty"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcPropertyEnumeration">ifc:name_IfcPropertyEnumeration</a>
    /// </summary>
    let name_IfcPropertyEnumeration = _prefixId.prefix "name_IfcPropertyEnumeration"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcResourceLevelRelationship">ifc:name_IfcResourceLevelRelationship</a>
    /// </summary>
    let name_IfcResourceLevelRelationship = _prefixId.prefix "name_IfcResourceLevelRelationship"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcRoot">ifc:name_IfcRoot</a>
    /// </summary>
    let name_IfcRoot = _prefixId.prefix "name_IfcRoot"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcSIUnit">ifc:name_IfcSIUnit</a>
    /// </summary>
    let name_IfcSIUnit = _prefixId.prefix "name_IfcSIUnit"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcSchedulingTime">ifc:name_IfcSchedulingTime</a>
    /// </summary>
    let name_IfcSchedulingTime = _prefixId.prefix "name_IfcSchedulingTime"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcShapeAspect">ifc:name_IfcShapeAspect</a>
    /// </summary>
    let name_IfcShapeAspect = _prefixId.prefix "name_IfcShapeAspect"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcStructuralConnectionCondition">ifc:name_IfcStructuralConnectionCondition</a>
    /// </summary>
    let name_IfcStructuralConnectionCondition = _prefixId.prefix "name_IfcStructuralConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcStructuralLoad">ifc:name_IfcStructuralLoad</a>
    /// </summary>
    let name_IfcStructuralLoad = _prefixId.prefix "name_IfcStructuralLoad"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcStyledItem">ifc:name_IfcStyledItem</a>
    /// </summary>
    let name_IfcStyledItem = _prefixId.prefix "name_IfcStyledItem"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcTable">ifc:name_IfcTable</a>
    /// </summary>
    let name_IfcTable = _prefixId.prefix "name_IfcTable"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcTableColumn">ifc:name_IfcTableColumn</a>
    /// </summary>
    let name_IfcTableColumn = _prefixId.prefix "name_IfcTableColumn"
    /// <summary>
    ///   <para>rdfs:label : Name^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#name_IfcTimeSeries">ifc:name_IfcTimeSeries</a>
    /// </summary>
    let name_IfcTimeSeries = _prefixId.prefix "name_IfcTimeSeries"

    /// <summary>
    ///   <para>rdfs:label : NominalBarDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalBarDiameter_IfcReinforcementBarProperties">ifc:nominalBarDiameter_IfcReinforcementBarProperties</a>
    /// </summary>
    let nominalBarDiameter_IfcReinforcementBarProperties = _prefixId.prefix "nominalBarDiameter_IfcReinforcementBarProperties"

    /// <summary>
    ///   <para>rdfs:label : NominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalDiameter_IfcMechanicalFastener">ifc:nominalDiameter_IfcMechanicalFastener</a>
    /// </summary>
    let nominalDiameter_IfcMechanicalFastener = _prefixId.prefix "nominalDiameter_IfcMechanicalFastener"

    /// <summary>
    ///   <para>rdfs:label : NominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalDiameter_IfcMechanicalFastenerType">ifc:nominalDiameter_IfcMechanicalFastenerType</a>
    /// </summary>
    let nominalDiameter_IfcMechanicalFastenerType = _prefixId.prefix "nominalDiameter_IfcMechanicalFastenerType"

    /// <summary>
    ///   <para>rdfs:label : NominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalDiameter_IfcReinforcingBar">ifc:nominalDiameter_IfcReinforcingBar</a>
    /// </summary>
    let nominalDiameter_IfcReinforcingBar = _prefixId.prefix "nominalDiameter_IfcReinforcingBar"

    /// <summary>
    ///   <para>rdfs:label : NominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalDiameter_IfcReinforcingBarType">ifc:nominalDiameter_IfcReinforcingBarType</a>
    /// </summary>
    let nominalDiameter_IfcReinforcingBarType = _prefixId.prefix "nominalDiameter_IfcReinforcingBarType"

    /// <summary>
    ///   <para>rdfs:label : NominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalDiameter_IfcTendon">ifc:nominalDiameter_IfcTendon</a>
    /// </summary>
    let nominalDiameter_IfcTendon = _prefixId.prefix "nominalDiameter_IfcTendon"
    /// <summary>
    ///   <para>rdfs:label : NominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalDiameter_IfcTendonType">ifc:nominalDiameter_IfcTendonType</a>
    /// </summary>
    let nominalDiameter_IfcTendonType = _prefixId.prefix "nominalDiameter_IfcTendonType"

    /// <summary>
    ///   <para>rdfs:label : NominalLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalLength_IfcMechanicalFastener">ifc:nominalLength_IfcMechanicalFastener</a>
    /// </summary>
    let nominalLength_IfcMechanicalFastener = _prefixId.prefix "nominalLength_IfcMechanicalFastener"

    /// <summary>
    ///   <para>rdfs:label : NominalLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalLength_IfcMechanicalFastenerType">ifc:nominalLength_IfcMechanicalFastenerType</a>
    /// </summary>
    let nominalLength_IfcMechanicalFastenerType = _prefixId.prefix "nominalLength_IfcMechanicalFastenerType"

    /// <summary>
    ///   <para>rdfs:label : NominalValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#nominalValue_IfcPropertySingleValue">ifc:nominalValue_IfcPropertySingleValue</a>
    /// </summary>
    let nominalValue_IfcPropertySingleValue = _prefixId.prefix "nominalValue_IfcPropertySingleValue"

    /// <summary>
    ///   <para>rdfs:label : NormalIndex^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#normalIndex_IfcTriangulatedFaceSet">ifc:normalIndex_IfcTriangulatedFaceSet</a>
    /// </summary>
    let normalIndex_IfcTriangulatedFaceSet = _prefixId.prefix "normalIndex_IfcTriangulatedFaceSet"

    /// <summary>
    ///   <para>rdfs:label : Normals^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#normals_IfcTessellatedFaceSet">ifc:normals_IfcTessellatedFaceSet</a>
    /// </summary>
    let normals_IfcTessellatedFaceSet = _prefixId.prefix "normals_IfcTessellatedFaceSet"
    /// <summary>
    ///   <para>rdfs:label : Northings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#northings_IfcMapConversion">ifc:northings_IfcMapConversion</a>
    /// </summary>
    let northings_IfcMapConversion = _prefixId.prefix "northings_IfcMapConversion"
    /// <summary>
    ///   <para>rdfs:label : NumberOfRisers^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#numberOfRisers_IfcStairFlight">ifc:numberOfRisers_IfcStairFlight</a>
    /// </summary>
    let numberOfRisers_IfcStairFlight = _prefixId.prefix "numberOfRisers_IfcStairFlight"
    /// <summary>
    ///   <para>rdfs:label : NumberOfTreads^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#numberOfTreads_IfcStairFlight">ifc:numberOfTreads_IfcStairFlight</a>
    /// </summary>
    let numberOfTreads_IfcStairFlight = _prefixId.prefix "numberOfTreads_IfcStairFlight"
    /// <summary>
    ///   <para>rdfs:label : ObjectPlacement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#objectPlacement_IfcProduct">ifc:objectPlacement_IfcProduct</a>
    /// </summary>
    let objectPlacement_IfcProduct = _prefixId.prefix "objectPlacement_IfcProduct"
    /// <summary>
    ///   <para>rdfs:label : ObjectType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#objectType_IfcContext">ifc:objectType_IfcContext</a>
    /// </summary>
    let objectType_IfcContext = _prefixId.prefix "objectType_IfcContext"
    /// <summary>
    ///   <para>rdfs:label : ObjectType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#objectType_IfcObject">ifc:objectType_IfcObject</a>
    /// </summary>
    let objectType_IfcObject = _prefixId.prefix "objectType_IfcObject"

    /// <summary>
    ///   <para>rdfs:label : ObjectiveQualifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#objectiveQualifier_IfcObjective">ifc:objectiveQualifier_IfcObjective</a>
    /// </summary>
    let objectiveQualifier_IfcObjective = _prefixId.prefix "objectiveQualifier_IfcObjective"

    /// <summary>
    ///   <para>rdfs:label : Occurrences^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#occurrences_IfcRecurrencePattern">ifc:occurrences_IfcRecurrencePattern</a>
    /// </summary>
    let occurrences_IfcRecurrencePattern = _prefixId.prefix "occurrences_IfcRecurrencePattern"

    /// <summary>
    ///   <para>rdfs:label : OffsetDirection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#offsetDirection_IfcMaterialLayerWithOffsets">ifc:offsetDirection_IfcMaterialLayerWithOffsets</a>
    /// </summary>
    let offsetDirection_IfcMaterialLayerWithOffsets = _prefixId.prefix "offsetDirection_IfcMaterialLayerWithOffsets"

    /// <summary>
    ///   <para>rdfs:label : OffsetDistances^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#offsetDistances_IfcVirtualGridIntersection">ifc:offsetDistances_IfcVirtualGridIntersection</a>
    /// </summary>
    let offsetDistances_IfcVirtualGridIntersection = _prefixId.prefix "offsetDistances_IfcVirtualGridIntersection"

    /// <summary>
    ///   <para>rdfs:label : OffsetFromReferenceLine^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#offsetFromReferenceLine_IfcMaterialLayerSetUsage">ifc:offsetFromReferenceLine_IfcMaterialLayerSetUsage</a>
    /// </summary>
    let offsetFromReferenceLine_IfcMaterialLayerSetUsage = _prefixId.prefix "offsetFromReferenceLine_IfcMaterialLayerSetUsage"

    /// <summary>
    ///   <para>rdfs:label : OffsetValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#offsetValues_IfcMaterialLayerWithOffsets">ifc:offsetValues_IfcMaterialLayerWithOffsets</a>
    /// </summary>
    let offsetValues_IfcMaterialLayerWithOffsets = _prefixId.prefix "offsetValues_IfcMaterialLayerWithOffsets"

    /// <summary>
    ///   <para>rdfs:label : OffsetValues^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#offsetValues_IfcMaterialProfileWithOffsets">ifc:offsetValues_IfcMaterialProfileWithOffsets</a>
    /// </summary>
    let offsetValues_IfcMaterialProfileWithOffsets = _prefixId.prefix "offsetValues_IfcMaterialProfileWithOffsets"

    /// <summary>
    ///   <para>rdfs:label : OperationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#operationType_IfcDoor">ifc:operationType_IfcDoor</a>
    /// </summary>
    let operationType_IfcDoor = _prefixId.prefix "operationType_IfcDoor"
    /// <summary>
    ///   <para>rdfs:label : OperationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#operationType_IfcDoorStyle">ifc:operationType_IfcDoorStyle</a>
    /// </summary>
    let operationType_IfcDoorStyle = _prefixId.prefix "operationType_IfcDoorStyle"
    /// <summary>
    ///   <para>rdfs:label : OperationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#operationType_IfcDoorType">ifc:operationType_IfcDoorType</a>
    /// </summary>
    let operationType_IfcDoorType = _prefixId.prefix "operationType_IfcDoorType"

    /// <summary>
    ///   <para>rdfs:label : OperationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#operationType_IfcPermeableCoveringProperties">ifc:operationType_IfcPermeableCoveringProperties</a>
    /// </summary>
    let operationType_IfcPermeableCoveringProperties = _prefixId.prefix "operationType_IfcPermeableCoveringProperties"

    /// <summary>
    ///   <para>rdfs:label : OperationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#operationType_IfcWindowPanelProperties">ifc:operationType_IfcWindowPanelProperties</a>
    /// </summary>
    let operationType_IfcWindowPanelProperties = _prefixId.prefix "operationType_IfcWindowPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : OperationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#operationType_IfcWindowStyle">ifc:operationType_IfcWindowStyle</a>
    /// </summary>
    let operationType_IfcWindowStyle = _prefixId.prefix "operationType_IfcWindowStyle"
    /// <summary>
    ///   <para>rdfs:label : Operator^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#operator_IfcBooleanResult">ifc:operator_IfcBooleanResult</a>
    /// </summary>
    let operator_IfcBooleanResult = _prefixId.prefix "operator_IfcBooleanResult"
    /// <summary>
    ///   <para>rdfs:label : Operator^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#operator_IfcDerivedProfileDef">ifc:operator_IfcDerivedProfileDef</a>
    /// </summary>
    let operator_IfcDerivedProfileDef = _prefixId.prefix "operator_IfcDerivedProfileDef"

    /// <summary>
    ///   <para>rdfs:label : OrientationOf2DPlane^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#orientationOf2DPlane_IfcStructuralAnalysisModel">ifc:orientationOf2DPlane_IfcStructuralAnalysisModel</a>
    /// </summary>
    let orientationOf2DPlane_IfcStructuralAnalysisModel = _prefixId.prefix "orientationOf2DPlane_IfcStructuralAnalysisModel"

    /// <summary>
    ///   <para>rdfs:label : Orientation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#orientation_IfcFaceBound">ifc:orientation_IfcFaceBound</a>
    /// </summary>
    let orientation_IfcFaceBound = _prefixId.prefix "orientation_IfcFaceBound"

    /// <summary>
    ///   <para>rdfs:label : Orientation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#orientation_IfcLightSourceDirectional">ifc:orientation_IfcLightSourceDirectional</a>
    /// </summary>
    let orientation_IfcLightSourceDirectional = _prefixId.prefix "orientation_IfcLightSourceDirectional"

    /// <summary>
    ///   <para>rdfs:label : Orientation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#orientation_IfcLightSourceSpot">ifc:orientation_IfcLightSourceSpot</a>
    /// </summary>
    let orientation_IfcLightSourceSpot = _prefixId.prefix "orientation_IfcLightSourceSpot"

    /// <summary>
    ///   <para>rdfs:label : Orientation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#orientation_IfcOrientedEdge">ifc:orientation_IfcOrientedEdge</a>
    /// </summary>
    let orientation_IfcOrientedEdge = _prefixId.prefix "orientation_IfcOrientedEdge"
    /// <summary>
    ///   <para>rdfs:label : Orientation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#orientation_IfcVector">ifc:orientation_IfcVector</a>
    /// </summary>
    let orientation_IfcVector = _prefixId.prefix "orientation_IfcVector"
    /// <summary>
    ///   <para>rdfs:label : OriginalValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#originalValue_IfcAsset">ifc:originalValue_IfcAsset</a>
    /// </summary>
    let originalValue_IfcAsset = _prefixId.prefix "originalValue_IfcAsset"
    /// <summary>
    ///   <para>rdfs:label : OriginalValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#originalValue_IfcInventory">ifc:originalValue_IfcInventory</a>
    /// </summary>
    let originalValue_IfcInventory = _prefixId.prefix "originalValue_IfcInventory"

    /// <summary>
    ///   <para>rdfs:label : OrthogonalHeight^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#orthogonalHeight_IfcMapConversion">ifc:orthogonalHeight_IfcMapConversion</a>
    /// </summary>
    let orthogonalHeight_IfcMapConversion = _prefixId.prefix "orthogonalHeight_IfcMapConversion"

    /// <summary>
    ///   <para>rdfs:label : OuterBoundary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#outerBoundary_IfcAnnotationFillArea">ifc:outerBoundary_IfcAnnotationFillArea</a>
    /// </summary>
    let outerBoundary_IfcAnnotationFillArea = _prefixId.prefix "outerBoundary_IfcAnnotationFillArea"

    /// <summary>
    ///   <para>rdfs:label : OuterBoundary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#outerBoundary_IfcCurveBoundedPlane">ifc:outerBoundary_IfcCurveBoundedPlane</a>
    /// </summary>
    let outerBoundary_IfcCurveBoundedPlane = _prefixId.prefix "outerBoundary_IfcCurveBoundedPlane"

    /// <summary>
    ///   <para>rdfs:label : OuterCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#outerCurve_IfcArbitraryClosedProfileDef">ifc:outerCurve_IfcArbitraryClosedProfileDef</a>
    /// </summary>
    let outerCurve_IfcArbitraryClosedProfileDef = _prefixId.prefix "outerCurve_IfcArbitraryClosedProfileDef"

    /// <summary>
    ///   <para>rdfs:label : OuterFilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#outerFilletRadius_IfcRectangleHollowProfileDef">ifc:outerFilletRadius_IfcRectangleHollowProfileDef</a>
    /// </summary>
    let outerFilletRadius_IfcRectangleHollowProfileDef = _prefixId.prefix "outerFilletRadius_IfcRectangleHollowProfileDef"

    /// <summary>
    ///   <para>rdfs:label : Outer^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#outer_IfcManifoldSolidBrep">ifc:outer_IfcManifoldSolidBrep</a>
    /// </summary>
    let outer_IfcManifoldSolidBrep = _prefixId.prefix "outer_IfcManifoldSolidBrep"

    /// <summary>
    ///   <para>rdfs:label : OverallDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#overallDepth_IfcAsymmetricIShapeProfileDef">ifc:overallDepth_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let overallDepth_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "overallDepth_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : OverallDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#overallDepth_IfcIShapeProfileDef">ifc:overallDepth_IfcIShapeProfileDef</a>
    /// </summary>
    let overallDepth_IfcIShapeProfileDef = _prefixId.prefix "overallDepth_IfcIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : OverallHeight^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#overallHeight_IfcDoor">ifc:overallHeight_IfcDoor</a>
    /// </summary>
    let overallHeight_IfcDoor = _prefixId.prefix "overallHeight_IfcDoor"
    /// <summary>
    ///   <para>rdfs:label : OverallHeight^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#overallHeight_IfcWindow">ifc:overallHeight_IfcWindow</a>
    /// </summary>
    let overallHeight_IfcWindow = _prefixId.prefix "overallHeight_IfcWindow"
    /// <summary>
    ///   <para>rdfs:label : OverallWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#overallWidth_IfcDoor">ifc:overallWidth_IfcDoor</a>
    /// </summary>
    let overallWidth_IfcDoor = _prefixId.prefix "overallWidth_IfcDoor"

    /// <summary>
    ///   <para>rdfs:label : OverallWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#overallWidth_IfcIShapeProfileDef">ifc:overallWidth_IfcIShapeProfileDef</a>
    /// </summary>
    let overallWidth_IfcIShapeProfileDef = _prefixId.prefix "overallWidth_IfcIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : OverallWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#overallWidth_IfcWindow">ifc:overallWidth_IfcWindow</a>
    /// </summary>
    let overallWidth_IfcWindow = _prefixId.prefix "overallWidth_IfcWindow"
    /// <summary>
    ///   <para>rdfs:label : Overrides^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#overrides_IfcIndexedColourMap">ifc:overrides_IfcIndexedColourMap</a>
    /// </summary>
    let overrides_IfcIndexedColourMap = _prefixId.prefix "overrides_IfcIndexedColourMap"
    /// <summary>
    ///   <para>rdfs:label : OwnerHistory^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#ownerHistory_IfcRoot">ifc:ownerHistory_IfcRoot</a>
    /// </summary>
    let ownerHistory_IfcRoot = _prefixId.prefix "ownerHistory_IfcRoot"
    /// <summary>
    ///   <para>rdfs:label : Owner^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#owner_IfcAsset">ifc:owner_IfcAsset</a>
    /// </summary>
    let owner_IfcAsset = _prefixId.prefix "owner_IfcAsset"

    /// <summary>
    ///   <para>rdfs:label : OwningApplication^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#owningApplication_IfcOwnerHistory">ifc:owningApplication_IfcOwnerHistory</a>
    /// </summary>
    let owningApplication_IfcOwnerHistory = _prefixId.prefix "owningApplication_IfcOwnerHistory"

    /// <summary>
    ///   <para>rdfs:label : OwningUser^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#owningUser_IfcOwnerHistory">ifc:owningUser_IfcOwnerHistory</a>
    /// </summary>
    let owningUser_IfcOwnerHistory = _prefixId.prefix "owningUser_IfcOwnerHistory"
    /// <summary>
    ///   <para>rdfs:label : PagerNumber^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#pagerNumber_IfcTelecomAddress">ifc:pagerNumber_IfcTelecomAddress</a>
    /// </summary>
    let pagerNumber_IfcTelecomAddress = _prefixId.prefix "pagerNumber_IfcTelecomAddress"

    /// <summary>
    ///   <para>rdfs:label : PanelDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#panelDepth_IfcDoorPanelProperties">ifc:panelDepth_IfcDoorPanelProperties</a>
    /// </summary>
    let panelDepth_IfcDoorPanelProperties = _prefixId.prefix "panelDepth_IfcDoorPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : PanelOperation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#panelOperation_IfcDoorPanelProperties">ifc:panelOperation_IfcDoorPanelProperties</a>
    /// </summary>
    let panelOperation_IfcDoorPanelProperties = _prefixId.prefix "panelOperation_IfcDoorPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : PanelPosition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#panelPosition_IfcDoorPanelProperties">ifc:panelPosition_IfcDoorPanelProperties</a>
    /// </summary>
    let panelPosition_IfcDoorPanelProperties = _prefixId.prefix "panelPosition_IfcDoorPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : PanelPosition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#panelPosition_IfcPermeableCoveringProperties">ifc:panelPosition_IfcPermeableCoveringProperties</a>
    /// </summary>
    let panelPosition_IfcPermeableCoveringProperties = _prefixId.prefix "panelPosition_IfcPermeableCoveringProperties"

    /// <summary>
    ///   <para>rdfs:label : PanelPosition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#panelPosition_IfcWindowPanelProperties">ifc:panelPosition_IfcWindowPanelProperties</a>
    /// </summary>
    let panelPosition_IfcWindowPanelProperties = _prefixId.prefix "panelPosition_IfcWindowPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : PanelWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#panelWidth_IfcDoorPanelProperties">ifc:panelWidth_IfcDoorPanelProperties</a>
    /// </summary>
    let panelWidth_IfcDoorPanelProperties = _prefixId.prefix "panelWidth_IfcDoorPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : ParamLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#paramLength_IfcReparametrisedCompositeCurveSegment">ifc:paramLength_IfcReparametrisedCompositeCurveSegment</a>
    /// </summary>
    let paramLength_IfcReparametrisedCompositeCurveSegment = _prefixId.prefix "paramLength_IfcReparametrisedCompositeCurveSegment"

    /// <summary>
    ///   <para>rdfs:label : ParameterTakesPrecedence^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parameterTakesPrecedence_IfcDoorStyle">ifc:parameterTakesPrecedence_IfcDoorStyle</a>
    /// </summary>
    let parameterTakesPrecedence_IfcDoorStyle = _prefixId.prefix "parameterTakesPrecedence_IfcDoorStyle"

    /// <summary>
    ///   <para>rdfs:label : ParameterTakesPrecedence^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parameterTakesPrecedence_IfcDoorType">ifc:parameterTakesPrecedence_IfcDoorType</a>
    /// </summary>
    let parameterTakesPrecedence_IfcDoorType = _prefixId.prefix "parameterTakesPrecedence_IfcDoorType"

    /// <summary>
    ///   <para>rdfs:label : ParameterTakesPrecedence^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parameterTakesPrecedence_IfcWindowStyle">ifc:parameterTakesPrecedence_IfcWindowStyle</a>
    /// </summary>
    let parameterTakesPrecedence_IfcWindowStyle = _prefixId.prefix "parameterTakesPrecedence_IfcWindowStyle"

    /// <summary>
    ///   <para>rdfs:label : ParameterTakesPrecedence^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parameterTakesPrecedence_IfcWindowType">ifc:parameterTakesPrecedence_IfcWindowType</a>
    /// </summary>
    let parameterTakesPrecedence_IfcWindowType = _prefixId.prefix "parameterTakesPrecedence_IfcWindowType"

    /// <summary>
    ///   <para>rdfs:label : Parameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parameter_IfcSurfaceTexture">ifc:parameter_IfcSurfaceTexture</a>
    /// </summary>
    let parameter_IfcSurfaceTexture = _prefixId.prefix "parameter_IfcSurfaceTexture"

    /// <summary>
    ///   <para>rdfs:label : Parameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parameter_IfcTextureCoordinateGenerator">ifc:parameter_IfcTextureCoordinateGenerator</a>
    /// </summary>
    let parameter_IfcTextureCoordinateGenerator = _prefixId.prefix "parameter_IfcTextureCoordinateGenerator"

    /// <summary>
    ///   <para>rdfs:label : ParentBoundary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parentBoundary_IfcRelSpaceBoundary1stLevel">ifc:parentBoundary_IfcRelSpaceBoundary1stLevel</a>
    /// </summary>
    let parentBoundary_IfcRelSpaceBoundary1stLevel = _prefixId.prefix "parentBoundary_IfcRelSpaceBoundary1stLevel"

    /// <summary>
    ///   <para>rdfs:label : ParentContext^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parentContext_IfcGeometricRepresentationSubContext">ifc:parentContext_IfcGeometricRepresentationSubContext</a>
    /// </summary>
    let parentContext_IfcGeometricRepresentationSubContext = _prefixId.prefix "parentContext_IfcGeometricRepresentationSubContext"

    /// <summary>
    ///   <para>rdfs:label : ParentCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parentCurve_IfcCompositeCurveSegment">ifc:parentCurve_IfcCompositeCurveSegment</a>
    /// </summary>
    let parentCurve_IfcCompositeCurveSegment = _prefixId.prefix "parentCurve_IfcCompositeCurveSegment"

    /// <summary>
    ///   <para>rdfs:label : ParentEdge^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parentEdge_IfcSubedge">ifc:parentEdge_IfcSubedge</a>
    /// </summary>
    let parentEdge_IfcSubedge = _prefixId.prefix "parentEdge_IfcSubedge"

    /// <summary>
    ///   <para>rdfs:label : ParentProfile^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#parentProfile_IfcDerivedProfileDef">ifc:parentProfile_IfcDerivedProfileDef</a>
    /// </summary>
    let parentProfile_IfcDerivedProfileDef = _prefixId.prefix "parentProfile_IfcDerivedProfileDef"

    /// <summary>
    ///   <para>rdfs:label : PartOfComplexTemplate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#partOfComplexTemplate_IfcPropertyTemplate">ifc:partOfComplexTemplate_IfcPropertyTemplate</a>
    /// </summary>
    let partOfComplexTemplate_IfcPropertyTemplate = _prefixId.prefix "partOfComplexTemplate_IfcPropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : PartOfComplex^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#partOfComplex_IfcPhysicalQuantity">ifc:partOfComplex_IfcPhysicalQuantity</a>
    /// </summary>
    let partOfComplex_IfcPhysicalQuantity = _prefixId.prefix "partOfComplex_IfcPhysicalQuantity"

    /// <summary>
    ///   <para>rdfs:label : PartOfComplex^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#partOfComplex_IfcProperty">ifc:partOfComplex_IfcProperty</a>
    /// </summary>
    let partOfComplex_IfcProperty = _prefixId.prefix "partOfComplex_IfcProperty"

    /// <summary>
    ///   <para>rdfs:label : PartOfProductDefinitionShape^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#partOfProductDefinitionShape_IfcShapeAspect">ifc:partOfProductDefinitionShape_IfcShapeAspect</a>
    /// </summary>
    let partOfProductDefinitionShape_IfcShapeAspect = _prefixId.prefix "partOfProductDefinitionShape_IfcShapeAspect"

    /// <summary>
    ///   <para>rdfs:label : PartOfPsetTemplate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#partOfPsetTemplate_IfcPropertyTemplate">ifc:partOfPsetTemplate_IfcPropertyTemplate</a>
    /// </summary>
    let partOfPsetTemplate_IfcPropertyTemplate = _prefixId.prefix "partOfPsetTemplate_IfcPropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : PartOfPset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#partOfPset_IfcProperty">ifc:partOfPset_IfcProperty</a>
    /// </summary>
    let partOfPset_IfcProperty = _prefixId.prefix "partOfPset_IfcProperty"
    /// <summary>
    ///   <para>rdfs:label : PartitioningType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#partitioningType_IfcWindow">ifc:partitioningType_IfcWindow</a>
    /// </summary>
    let partitioningType_IfcWindow = _prefixId.prefix "partitioningType_IfcWindow"

    /// <summary>
    ///   <para>rdfs:label : PartitioningType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#partitioningType_IfcWindowType">ifc:partitioningType_IfcWindowType</a>
    /// </summary>
    let partitioningType_IfcWindowType = _prefixId.prefix "partitioningType_IfcWindowType"

    /// <summary>
    ///   <para>rdfs:label : Path^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#path_IfcTextLiteral">ifc:path_IfcTextLiteral</a>
    /// </summary>
    let path_IfcTextLiteral = _prefixId.prefix "path_IfcTextLiteral"
    /// <summary>
    ///   <para>rdfs:label : PatternList^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#patternList_IfcCurveStyleFont">ifc:patternList_IfcCurveStyleFont</a>
    /// </summary>
    let patternList_IfcCurveStyleFont = _prefixId.prefix "patternList_IfcCurveStyleFont"

    /// <summary>
    ///   <para>rdfs:label : PatternStart^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#patternStart_IfcFillAreaStyleHatching">ifc:patternStart_IfcFillAreaStyleHatching</a>
    /// </summary>
    let patternStart_IfcFillAreaStyleHatching = _prefixId.prefix "patternStart_IfcFillAreaStyleHatching"

    /// <summary>
    ///   <para>rdfs:label : Phase^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#phase_IfcContext">ifc:phase_IfcContext</a>
    /// </summary>
    let phase_IfcContext = _prefixId.prefix "phase_IfcContext"

    /// <summary>
    ///   <para>rdfs:label : PhysicalOrVirtualBoundary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#physicalOrVirtualBoundary_IfcRelSpaceBoundary">ifc:physicalOrVirtualBoundary_IfcRelSpaceBoundary</a>
    /// </summary>
    let physicalOrVirtualBoundary_IfcRelSpaceBoundary = _prefixId.prefix "physicalOrVirtualBoundary_IfcRelSpaceBoundary"

    /// <summary>
    ///   <para>rdfs:label : Pixel^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#pixel_IfcPixelTexture">ifc:pixel_IfcPixelTexture</a>
    /// </summary>
    let pixel_IfcPixelTexture = _prefixId.prefix "pixel_IfcPixelTexture"

    /// <summary>
    ///   <para>rdfs:label : PlacementLocation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#placementLocation_IfcGridPlacement">ifc:placementLocation_IfcGridPlacement</a>
    /// </summary>
    let placementLocation_IfcGridPlacement = _prefixId.prefix "placementLocation_IfcGridPlacement"

    /// <summary>
    ///   <para>rdfs:label : PlacementRefDirection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#placementRefDirection_IfcGridPlacement">ifc:placementRefDirection_IfcGridPlacement</a>
    /// </summary>
    let placementRefDirection_IfcGridPlacement = _prefixId.prefix "placementRefDirection_IfcGridPlacement"

    /// <summary>
    ///   <para>rdfs:label : PlacementRelTo^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#placementRelTo_IfcLocalPlacement">ifc:placementRelTo_IfcLocalPlacement</a>
    /// </summary>
    let placementRelTo_IfcLocalPlacement = _prefixId.prefix "placementRelTo_IfcLocalPlacement"

    /// <summary>
    ///   <para>rdfs:label : Placement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#placement_IfcPlanarBox">ifc:placement_IfcPlanarBox</a>
    /// </summary>
    let placement_IfcPlanarBox = _prefixId.prefix "placement_IfcPlanarBox"
    /// <summary>
    ///   <para>rdfs:label : Placement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#placement_IfcTextLiteral">ifc:placement_IfcTextLiteral</a>
    /// </summary>
    let placement_IfcTextLiteral = _prefixId.prefix "placement_IfcTextLiteral"

    /// <summary>
    ///   <para>rdfs:label : PlacesObject^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#placesObject_IfcObjectPlacement">ifc:placesObject_IfcObjectPlacement</a>
    /// </summary>
    let placesObject_IfcObjectPlacement = _prefixId.prefix "placesObject_IfcObjectPlacement"

    /// <summary>
    ///   <para>rdfs:label : PlanarForceX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#planarForceX_IfcStructuralLoadPlanarForce">ifc:planarForceX_IfcStructuralLoadPlanarForce</a>
    /// </summary>
    let planarForceX_IfcStructuralLoadPlanarForce = _prefixId.prefix "planarForceX_IfcStructuralLoadPlanarForce"

    /// <summary>
    ///   <para>rdfs:label : PlanarForceY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#planarForceY_IfcStructuralLoadPlanarForce">ifc:planarForceY_IfcStructuralLoadPlanarForce</a>
    /// </summary>
    let planarForceY_IfcStructuralLoadPlanarForce = _prefixId.prefix "planarForceY_IfcStructuralLoadPlanarForce"

    /// <summary>
    ///   <para>rdfs:label : PlanarForceZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#planarForceZ_IfcStructuralLoadPlanarForce">ifc:planarForceZ_IfcStructuralLoadPlanarForce</a>
    /// </summary>
    let planarForceZ_IfcStructuralLoadPlanarForce = _prefixId.prefix "planarForceZ_IfcStructuralLoadPlanarForce"

    /// <summary>
    ///   <para>rdfs:label : Pnt^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#pnt_IfcLine">ifc:pnt_IfcLine</a>
    /// </summary>
    let pnt_IfcLine = _prefixId.prefix "pnt_IfcLine"

    /// <summary>
    ///   <para>rdfs:label : PointOfReferenceHatchLine^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#pointOfReferenceHatchLine_IfcFillAreaStyleHatching">ifc:pointOfReferenceHatchLine_IfcFillAreaStyleHatching</a>
    /// </summary>
    let pointOfReferenceHatchLine_IfcFillAreaStyleHatching = _prefixId.prefix "pointOfReferenceHatchLine_IfcFillAreaStyleHatching"

    /// <summary>
    ///   <para>rdfs:label : PointOnRelatedElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#pointOnRelatedElement_IfcConnectionPointGeometry">ifc:pointOnRelatedElement_IfcConnectionPointGeometry</a>
    /// </summary>
    let pointOnRelatedElement_IfcConnectionPointGeometry = _prefixId.prefix "pointOnRelatedElement_IfcConnectionPointGeometry"

    /// <summary>
    ///   <para>rdfs:label : PointOnRelatingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#pointOnRelatingElement_IfcConnectionPointGeometry">ifc:pointOnRelatingElement_IfcConnectionPointGeometry</a>
    /// </summary>
    let pointOnRelatingElement_IfcConnectionPointGeometry = _prefixId.prefix "pointOnRelatingElement_IfcConnectionPointGeometry"

    /// <summary>
    ///   <para>rdfs:label : PointParameterU^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#pointParameterU_IfcPointOnSurface">ifc:pointParameterU_IfcPointOnSurface</a>
    /// </summary>
    let pointParameterU_IfcPointOnSurface = _prefixId.prefix "pointParameterU_IfcPointOnSurface"

    /// <summary>
    ///   <para>rdfs:label : PointParameterV^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#pointParameterV_IfcPointOnSurface">ifc:pointParameterV_IfcPointOnSurface</a>
    /// </summary>
    let pointParameterV_IfcPointOnSurface = _prefixId.prefix "pointParameterV_IfcPointOnSurface"

    /// <summary>
    ///   <para>rdfs:label : PointParameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#pointParameter_IfcPointOnCurve">ifc:pointParameter_IfcPointOnCurve</a>
    /// </summary>
    let pointParameter_IfcPointOnCurve = _prefixId.prefix "pointParameter_IfcPointOnCurve"

    /// <summary>
    ///   <para>rdfs:label : Points^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#points_IfcIndexedPolyCurve">ifc:points_IfcIndexedPolyCurve</a>
    /// </summary>
    let points_IfcIndexedPolyCurve = _prefixId.prefix "points_IfcIndexedPolyCurve"
    /// <summary>
    ///   <para>rdfs:label : Points^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#points_IfcPolyline">ifc:points_IfcPolyline</a>
    /// </summary>
    let points_IfcPolyline = _prefixId.prefix "points_IfcPolyline"
    /// <summary>
    ///   <para>rdfs:label : Polygon^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#polygon_IfcPolyLoop">ifc:polygon_IfcPolyLoop</a>
    /// </summary>
    let polygon_IfcPolyLoop = _prefixId.prefix "polygon_IfcPolyLoop"

    /// <summary>
    ///   <para>rdfs:label : PolygonalBoundary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#polygonalBoundary_IfcPolygonalBoundedHalfSpace">ifc:polygonalBoundary_IfcPolygonalBoundedHalfSpace</a>
    /// </summary>
    let polygonalBoundary_IfcPolygonalBoundedHalfSpace = _prefixId.prefix "polygonalBoundary_IfcPolygonalBoundedHalfSpace"

    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcConic">ifc:position_IfcConic</a>
    /// </summary>
    let position_IfcConic = _prefixId.prefix "position_IfcConic"
    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcCsgPrimitive3D">ifc:position_IfcCsgPrimitive3D</a>
    /// </summary>
    let position_IfcCsgPrimitive3D = _prefixId.prefix "position_IfcCsgPrimitive3D"
    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcElementarySurface">ifc:position_IfcElementarySurface</a>
    /// </summary>
    let position_IfcElementarySurface = _prefixId.prefix "position_IfcElementarySurface"

    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcLightSourceGoniometric">ifc:position_IfcLightSourceGoniometric</a>
    /// </summary>
    let position_IfcLightSourceGoniometric = _prefixId.prefix "position_IfcLightSourceGoniometric"

    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcLightSourcePositional">ifc:position_IfcLightSourcePositional</a>
    /// </summary>
    let position_IfcLightSourcePositional = _prefixId.prefix "position_IfcLightSourcePositional"

    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcParameterizedProfileDef">ifc:position_IfcParameterizedProfileDef</a>
    /// </summary>
    let position_IfcParameterizedProfileDef = _prefixId.prefix "position_IfcParameterizedProfileDef"

    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcPolygonalBoundedHalfSpace">ifc:position_IfcPolygonalBoundedHalfSpace</a>
    /// </summary>
    let position_IfcPolygonalBoundedHalfSpace = _prefixId.prefix "position_IfcPolygonalBoundedHalfSpace"

    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcRecurrencePattern">ifc:position_IfcRecurrencePattern</a>
    /// </summary>
    let position_IfcRecurrencePattern = _prefixId.prefix "position_IfcRecurrencePattern"
    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcSweptAreaSolid">ifc:position_IfcSweptAreaSolid</a>
    /// </summary>
    let position_IfcSweptAreaSolid = _prefixId.prefix "position_IfcSweptAreaSolid"
    /// <summary>
    ///   <para>rdfs:label : Position^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#position_IfcSweptSurface">ifc:position_IfcSweptSurface</a>
    /// </summary>
    let position_IfcSweptSurface = _prefixId.prefix "position_IfcSweptSurface"
    /// <summary>
    ///   <para>rdfs:label : PostalBox^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#postalBox_IfcPostalAddress">ifc:postalBox_IfcPostalAddress</a>
    /// </summary>
    let postalBox_IfcPostalAddress = _prefixId.prefix "postalBox_IfcPostalAddress"
    /// <summary>
    ///   <para>rdfs:label : PostalCode^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#postalCode_IfcPostalAddress">ifc:postalCode_IfcPostalAddress</a>
    /// </summary>
    let postalCode_IfcPostalAddress = _prefixId.prefix "postalCode_IfcPostalAddress"
    /// <summary>
    ///   <para>rdfs:label : PreStress^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#preStress_IfcTendon">ifc:preStress_IfcTendon</a>
    /// </summary>
    let preStress_IfcTendon = _prefixId.prefix "preStress_IfcTendon"

    /// <summary>
    ///   <para>rdfs:label : Precision^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#precision_IfcGeometricRepresentationContext">ifc:precision_IfcGeometricRepresentationContext</a>
    /// </summary>
    let precision_IfcGeometricRepresentationContext = _prefixId.prefix "precision_IfcGeometricRepresentationContext"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcActionRequest">ifc:predefinedType_IfcActionRequest</a>
    /// </summary>
    let predefinedType_IfcActionRequest = _prefixId.prefix "predefinedType_IfcActionRequest"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcActuator">ifc:predefinedType_IfcActuator</a>
    /// </summary>
    let predefinedType_IfcActuator = _prefixId.prefix "predefinedType_IfcActuator"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcActuatorType">ifc:predefinedType_IfcActuatorType</a>
    /// </summary>
    let predefinedType_IfcActuatorType = _prefixId.prefix "predefinedType_IfcActuatorType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAirTerminal">ifc:predefinedType_IfcAirTerminal</a>
    /// </summary>
    let predefinedType_IfcAirTerminal = _prefixId.prefix "predefinedType_IfcAirTerminal"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAirTerminalBox">ifc:predefinedType_IfcAirTerminalBox</a>
    /// </summary>
    let predefinedType_IfcAirTerminalBox = _prefixId.prefix "predefinedType_IfcAirTerminalBox"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAirTerminalBoxType">ifc:predefinedType_IfcAirTerminalBoxType</a>
    /// </summary>
    let predefinedType_IfcAirTerminalBoxType = _prefixId.prefix "predefinedType_IfcAirTerminalBoxType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAirTerminalType">ifc:predefinedType_IfcAirTerminalType</a>
    /// </summary>
    let predefinedType_IfcAirTerminalType = _prefixId.prefix "predefinedType_IfcAirTerminalType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAirToAirHeatRecovery">ifc:predefinedType_IfcAirToAirHeatRecovery</a>
    /// </summary>
    let predefinedType_IfcAirToAirHeatRecovery = _prefixId.prefix "predefinedType_IfcAirToAirHeatRecovery"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAirToAirHeatRecoveryType">ifc:predefinedType_IfcAirToAirHeatRecoveryType</a>
    /// </summary>
    let predefinedType_IfcAirToAirHeatRecoveryType = _prefixId.prefix "predefinedType_IfcAirToAirHeatRecoveryType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAlarm">ifc:predefinedType_IfcAlarm</a>
    /// </summary>
    let predefinedType_IfcAlarm = _prefixId.prefix "predefinedType_IfcAlarm"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAlarmType">ifc:predefinedType_IfcAlarmType</a>
    /// </summary>
    let predefinedType_IfcAlarmType = _prefixId.prefix "predefinedType_IfcAlarmType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAudioVisualAppliance">ifc:predefinedType_IfcAudioVisualAppliance</a>
    /// </summary>
    let predefinedType_IfcAudioVisualAppliance = _prefixId.prefix "predefinedType_IfcAudioVisualAppliance"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcAudioVisualApplianceType">ifc:predefinedType_IfcAudioVisualApplianceType</a>
    /// </summary>
    let predefinedType_IfcAudioVisualApplianceType = _prefixId.prefix "predefinedType_IfcAudioVisualApplianceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBeam">ifc:predefinedType_IfcBeam</a>
    /// </summary>
    let predefinedType_IfcBeam = _prefixId.prefix "predefinedType_IfcBeam"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBeamType">ifc:predefinedType_IfcBeamType</a>
    /// </summary>
    let predefinedType_IfcBeamType = _prefixId.prefix "predefinedType_IfcBeamType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBoiler">ifc:predefinedType_IfcBoiler</a>
    /// </summary>
    let predefinedType_IfcBoiler = _prefixId.prefix "predefinedType_IfcBoiler"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBoilerType">ifc:predefinedType_IfcBoilerType</a>
    /// </summary>
    let predefinedType_IfcBoilerType = _prefixId.prefix "predefinedType_IfcBoilerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBuildingElementPart">ifc:predefinedType_IfcBuildingElementPart</a>
    /// </summary>
    let predefinedType_IfcBuildingElementPart = _prefixId.prefix "predefinedType_IfcBuildingElementPart"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBuildingElementPartType">ifc:predefinedType_IfcBuildingElementPartType</a>
    /// </summary>
    let predefinedType_IfcBuildingElementPartType = _prefixId.prefix "predefinedType_IfcBuildingElementPartType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBuildingElementProxy">ifc:predefinedType_IfcBuildingElementProxy</a>
    /// </summary>
    let predefinedType_IfcBuildingElementProxy = _prefixId.prefix "predefinedType_IfcBuildingElementProxy"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBuildingElementProxyType">ifc:predefinedType_IfcBuildingElementProxyType</a>
    /// </summary>
    let predefinedType_IfcBuildingElementProxyType = _prefixId.prefix "predefinedType_IfcBuildingElementProxyType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBuildingSystem">ifc:predefinedType_IfcBuildingSystem</a>
    /// </summary>
    let predefinedType_IfcBuildingSystem = _prefixId.prefix "predefinedType_IfcBuildingSystem"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBurner">ifc:predefinedType_IfcBurner</a>
    /// </summary>
    let predefinedType_IfcBurner = _prefixId.prefix "predefinedType_IfcBurner"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcBurnerType">ifc:predefinedType_IfcBurnerType</a>
    /// </summary>
    let predefinedType_IfcBurnerType = _prefixId.prefix "predefinedType_IfcBurnerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCableCarrierFitting">ifc:predefinedType_IfcCableCarrierFitting</a>
    /// </summary>
    let predefinedType_IfcCableCarrierFitting = _prefixId.prefix "predefinedType_IfcCableCarrierFitting"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCableCarrierFittingType">ifc:predefinedType_IfcCableCarrierFittingType</a>
    /// </summary>
    let predefinedType_IfcCableCarrierFittingType = _prefixId.prefix "predefinedType_IfcCableCarrierFittingType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCableCarrierSegment">ifc:predefinedType_IfcCableCarrierSegment</a>
    /// </summary>
    let predefinedType_IfcCableCarrierSegment = _prefixId.prefix "predefinedType_IfcCableCarrierSegment"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCableCarrierSegmentType">ifc:predefinedType_IfcCableCarrierSegmentType</a>
    /// </summary>
    let predefinedType_IfcCableCarrierSegmentType = _prefixId.prefix "predefinedType_IfcCableCarrierSegmentType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCableFitting">ifc:predefinedType_IfcCableFitting</a>
    /// </summary>
    let predefinedType_IfcCableFitting = _prefixId.prefix "predefinedType_IfcCableFitting"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCableFittingType">ifc:predefinedType_IfcCableFittingType</a>
    /// </summary>
    let predefinedType_IfcCableFittingType = _prefixId.prefix "predefinedType_IfcCableFittingType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCableSegment">ifc:predefinedType_IfcCableSegment</a>
    /// </summary>
    let predefinedType_IfcCableSegment = _prefixId.prefix "predefinedType_IfcCableSegment"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCableSegmentType">ifc:predefinedType_IfcCableSegmentType</a>
    /// </summary>
    let predefinedType_IfcCableSegmentType = _prefixId.prefix "predefinedType_IfcCableSegmentType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcChiller">ifc:predefinedType_IfcChiller</a>
    /// </summary>
    let predefinedType_IfcChiller = _prefixId.prefix "predefinedType_IfcChiller"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcChillerType">ifc:predefinedType_IfcChillerType</a>
    /// </summary>
    let predefinedType_IfcChillerType = _prefixId.prefix "predefinedType_IfcChillerType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcChimney">ifc:predefinedType_IfcChimney</a>
    /// </summary>
    let predefinedType_IfcChimney = _prefixId.prefix "predefinedType_IfcChimney"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcChimneyType">ifc:predefinedType_IfcChimneyType</a>
    /// </summary>
    let predefinedType_IfcChimneyType = _prefixId.prefix "predefinedType_IfcChimneyType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCoil">ifc:predefinedType_IfcCoil</a>
    /// </summary>
    let predefinedType_IfcCoil = _prefixId.prefix "predefinedType_IfcCoil"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCoilType">ifc:predefinedType_IfcCoilType</a>
    /// </summary>
    let predefinedType_IfcCoilType = _prefixId.prefix "predefinedType_IfcCoilType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcColumn">ifc:predefinedType_IfcColumn</a>
    /// </summary>
    let predefinedType_IfcColumn = _prefixId.prefix "predefinedType_IfcColumn"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcColumnType">ifc:predefinedType_IfcColumnType</a>
    /// </summary>
    let predefinedType_IfcColumnType = _prefixId.prefix "predefinedType_IfcColumnType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCommunicationsAppliance">ifc:predefinedType_IfcCommunicationsAppliance</a>
    /// </summary>
    let predefinedType_IfcCommunicationsAppliance = _prefixId.prefix "predefinedType_IfcCommunicationsAppliance"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCommunicationsApplianceType">ifc:predefinedType_IfcCommunicationsApplianceType</a>
    /// </summary>
    let predefinedType_IfcCommunicationsApplianceType = _prefixId.prefix "predefinedType_IfcCommunicationsApplianceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCompressor">ifc:predefinedType_IfcCompressor</a>
    /// </summary>
    let predefinedType_IfcCompressor = _prefixId.prefix "predefinedType_IfcCompressor"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCompressorType">ifc:predefinedType_IfcCompressorType</a>
    /// </summary>
    let predefinedType_IfcCompressorType = _prefixId.prefix "predefinedType_IfcCompressorType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCondenser">ifc:predefinedType_IfcCondenser</a>
    /// </summary>
    let predefinedType_IfcCondenser = _prefixId.prefix "predefinedType_IfcCondenser"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCondenserType">ifc:predefinedType_IfcCondenserType</a>
    /// </summary>
    let predefinedType_IfcCondenserType = _prefixId.prefix "predefinedType_IfcCondenserType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcConstructionEquipmentResource">ifc:predefinedType_IfcConstructionEquipmentResource</a>
    /// </summary>
    let predefinedType_IfcConstructionEquipmentResource = _prefixId.prefix "predefinedType_IfcConstructionEquipmentResource"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcConstructionEquipmentResourceType">ifc:predefinedType_IfcConstructionEquipmentResourceType</a>
    /// </summary>
    let predefinedType_IfcConstructionEquipmentResourceType = _prefixId.prefix "predefinedType_IfcConstructionEquipmentResourceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcConstructionMaterialResource">ifc:predefinedType_IfcConstructionMaterialResource</a>
    /// </summary>
    let predefinedType_IfcConstructionMaterialResource = _prefixId.prefix "predefinedType_IfcConstructionMaterialResource"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcConstructionMaterialResourceType">ifc:predefinedType_IfcConstructionMaterialResourceType</a>
    /// </summary>
    let predefinedType_IfcConstructionMaterialResourceType = _prefixId.prefix "predefinedType_IfcConstructionMaterialResourceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcConstructionProductResource">ifc:predefinedType_IfcConstructionProductResource</a>
    /// </summary>
    let predefinedType_IfcConstructionProductResource = _prefixId.prefix "predefinedType_IfcConstructionProductResource"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcConstructionProductResourceType">ifc:predefinedType_IfcConstructionProductResourceType</a>
    /// </summary>
    let predefinedType_IfcConstructionProductResourceType = _prefixId.prefix "predefinedType_IfcConstructionProductResourceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcController">ifc:predefinedType_IfcController</a>
    /// </summary>
    let predefinedType_IfcController = _prefixId.prefix "predefinedType_IfcController"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcControllerType">ifc:predefinedType_IfcControllerType</a>
    /// </summary>
    let predefinedType_IfcControllerType = _prefixId.prefix "predefinedType_IfcControllerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCooledBeam">ifc:predefinedType_IfcCooledBeam</a>
    /// </summary>
    let predefinedType_IfcCooledBeam = _prefixId.prefix "predefinedType_IfcCooledBeam"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCooledBeamType">ifc:predefinedType_IfcCooledBeamType</a>
    /// </summary>
    let predefinedType_IfcCooledBeamType = _prefixId.prefix "predefinedType_IfcCooledBeamType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCoolingTower">ifc:predefinedType_IfcCoolingTower</a>
    /// </summary>
    let predefinedType_IfcCoolingTower = _prefixId.prefix "predefinedType_IfcCoolingTower"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCoolingTowerType">ifc:predefinedType_IfcCoolingTowerType</a>
    /// </summary>
    let predefinedType_IfcCoolingTowerType = _prefixId.prefix "predefinedType_IfcCoolingTowerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCostItem">ifc:predefinedType_IfcCostItem</a>
    /// </summary>
    let predefinedType_IfcCostItem = _prefixId.prefix "predefinedType_IfcCostItem"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCostSchedule">ifc:predefinedType_IfcCostSchedule</a>
    /// </summary>
    let predefinedType_IfcCostSchedule = _prefixId.prefix "predefinedType_IfcCostSchedule"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCovering">ifc:predefinedType_IfcCovering</a>
    /// </summary>
    let predefinedType_IfcCovering = _prefixId.prefix "predefinedType_IfcCovering"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCoveringType">ifc:predefinedType_IfcCoveringType</a>
    /// </summary>
    let predefinedType_IfcCoveringType = _prefixId.prefix "predefinedType_IfcCoveringType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCrewResource">ifc:predefinedType_IfcCrewResource</a>
    /// </summary>
    let predefinedType_IfcCrewResource = _prefixId.prefix "predefinedType_IfcCrewResource"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCrewResourceType">ifc:predefinedType_IfcCrewResourceType</a>
    /// </summary>
    let predefinedType_IfcCrewResourceType = _prefixId.prefix "predefinedType_IfcCrewResourceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCurtainWall">ifc:predefinedType_IfcCurtainWall</a>
    /// </summary>
    let predefinedType_IfcCurtainWall = _prefixId.prefix "predefinedType_IfcCurtainWall"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcCurtainWallType">ifc:predefinedType_IfcCurtainWallType</a>
    /// </summary>
    let predefinedType_IfcCurtainWallType = _prefixId.prefix "predefinedType_IfcCurtainWallType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDamper">ifc:predefinedType_IfcDamper</a>
    /// </summary>
    let predefinedType_IfcDamper = _prefixId.prefix "predefinedType_IfcDamper"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDamperType">ifc:predefinedType_IfcDamperType</a>
    /// </summary>
    let predefinedType_IfcDamperType = _prefixId.prefix "predefinedType_IfcDamperType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDiscreteAccessory">ifc:predefinedType_IfcDiscreteAccessory</a>
    /// </summary>
    let predefinedType_IfcDiscreteAccessory = _prefixId.prefix "predefinedType_IfcDiscreteAccessory"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDiscreteAccessoryType">ifc:predefinedType_IfcDiscreteAccessoryType</a>
    /// </summary>
    let predefinedType_IfcDiscreteAccessoryType = _prefixId.prefix "predefinedType_IfcDiscreteAccessoryType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDistributionChamberElement">ifc:predefinedType_IfcDistributionChamberElement</a>
    /// </summary>
    let predefinedType_IfcDistributionChamberElement = _prefixId.prefix "predefinedType_IfcDistributionChamberElement"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDistributionChamberElementType">ifc:predefinedType_IfcDistributionChamberElementType</a>
    /// </summary>
    let predefinedType_IfcDistributionChamberElementType = _prefixId.prefix "predefinedType_IfcDistributionChamberElementType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDistributionPort">ifc:predefinedType_IfcDistributionPort</a>
    /// </summary>
    let predefinedType_IfcDistributionPort = _prefixId.prefix "predefinedType_IfcDistributionPort"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDistributionSystem">ifc:predefinedType_IfcDistributionSystem</a>
    /// </summary>
    let predefinedType_IfcDistributionSystem = _prefixId.prefix "predefinedType_IfcDistributionSystem"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDoor">ifc:predefinedType_IfcDoor</a>
    /// </summary>
    let predefinedType_IfcDoor = _prefixId.prefix "predefinedType_IfcDoor"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDoorType">ifc:predefinedType_IfcDoorType</a>
    /// </summary>
    let predefinedType_IfcDoorType = _prefixId.prefix "predefinedType_IfcDoorType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDuctFitting">ifc:predefinedType_IfcDuctFitting</a>
    /// </summary>
    let predefinedType_IfcDuctFitting = _prefixId.prefix "predefinedType_IfcDuctFitting"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDuctFittingType">ifc:predefinedType_IfcDuctFittingType</a>
    /// </summary>
    let predefinedType_IfcDuctFittingType = _prefixId.prefix "predefinedType_IfcDuctFittingType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDuctSegment">ifc:predefinedType_IfcDuctSegment</a>
    /// </summary>
    let predefinedType_IfcDuctSegment = _prefixId.prefix "predefinedType_IfcDuctSegment"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDuctSegmentType">ifc:predefinedType_IfcDuctSegmentType</a>
    /// </summary>
    let predefinedType_IfcDuctSegmentType = _prefixId.prefix "predefinedType_IfcDuctSegmentType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDuctSilencer">ifc:predefinedType_IfcDuctSilencer</a>
    /// </summary>
    let predefinedType_IfcDuctSilencer = _prefixId.prefix "predefinedType_IfcDuctSilencer"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcDuctSilencerType">ifc:predefinedType_IfcDuctSilencerType</a>
    /// </summary>
    let predefinedType_IfcDuctSilencerType = _prefixId.prefix "predefinedType_IfcDuctSilencerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricAppliance">ifc:predefinedType_IfcElectricAppliance</a>
    /// </summary>
    let predefinedType_IfcElectricAppliance = _prefixId.prefix "predefinedType_IfcElectricAppliance"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricApplianceType">ifc:predefinedType_IfcElectricApplianceType</a>
    /// </summary>
    let predefinedType_IfcElectricApplianceType = _prefixId.prefix "predefinedType_IfcElectricApplianceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricDistributionBoard">ifc:predefinedType_IfcElectricDistributionBoard</a>
    /// </summary>
    let predefinedType_IfcElectricDistributionBoard = _prefixId.prefix "predefinedType_IfcElectricDistributionBoard"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricDistributionBoardType">ifc:predefinedType_IfcElectricDistributionBoardType</a>
    /// </summary>
    let predefinedType_IfcElectricDistributionBoardType = _prefixId.prefix "predefinedType_IfcElectricDistributionBoardType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricFlowStorageDevice">ifc:predefinedType_IfcElectricFlowStorageDevice</a>
    /// </summary>
    let predefinedType_IfcElectricFlowStorageDevice = _prefixId.prefix "predefinedType_IfcElectricFlowStorageDevice"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricFlowStorageDeviceType">ifc:predefinedType_IfcElectricFlowStorageDeviceType</a>
    /// </summary>
    let predefinedType_IfcElectricFlowStorageDeviceType = _prefixId.prefix "predefinedType_IfcElectricFlowStorageDeviceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricGenerator">ifc:predefinedType_IfcElectricGenerator</a>
    /// </summary>
    let predefinedType_IfcElectricGenerator = _prefixId.prefix "predefinedType_IfcElectricGenerator"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricGeneratorType">ifc:predefinedType_IfcElectricGeneratorType</a>
    /// </summary>
    let predefinedType_IfcElectricGeneratorType = _prefixId.prefix "predefinedType_IfcElectricGeneratorType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricMotor">ifc:predefinedType_IfcElectricMotor</a>
    /// </summary>
    let predefinedType_IfcElectricMotor = _prefixId.prefix "predefinedType_IfcElectricMotor"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricMotorType">ifc:predefinedType_IfcElectricMotorType</a>
    /// </summary>
    let predefinedType_IfcElectricMotorType = _prefixId.prefix "predefinedType_IfcElectricMotorType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricTimeControl">ifc:predefinedType_IfcElectricTimeControl</a>
    /// </summary>
    let predefinedType_IfcElectricTimeControl = _prefixId.prefix "predefinedType_IfcElectricTimeControl"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElectricTimeControlType">ifc:predefinedType_IfcElectricTimeControlType</a>
    /// </summary>
    let predefinedType_IfcElectricTimeControlType = _prefixId.prefix "predefinedType_IfcElectricTimeControlType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElementAssembly">ifc:predefinedType_IfcElementAssembly</a>
    /// </summary>
    let predefinedType_IfcElementAssembly = _prefixId.prefix "predefinedType_IfcElementAssembly"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcElementAssemblyType">ifc:predefinedType_IfcElementAssemblyType</a>
    /// </summary>
    let predefinedType_IfcElementAssemblyType = _prefixId.prefix "predefinedType_IfcElementAssemblyType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcEngine">ifc:predefinedType_IfcEngine</a>
    /// </summary>
    let predefinedType_IfcEngine = _prefixId.prefix "predefinedType_IfcEngine"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcEngineType">ifc:predefinedType_IfcEngineType</a>
    /// </summary>
    let predefinedType_IfcEngineType = _prefixId.prefix "predefinedType_IfcEngineType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcEvaporativeCooler">ifc:predefinedType_IfcEvaporativeCooler</a>
    /// </summary>
    let predefinedType_IfcEvaporativeCooler = _prefixId.prefix "predefinedType_IfcEvaporativeCooler"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcEvaporativeCoolerType">ifc:predefinedType_IfcEvaporativeCoolerType</a>
    /// </summary>
    let predefinedType_IfcEvaporativeCoolerType = _prefixId.prefix "predefinedType_IfcEvaporativeCoolerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcEvaporator">ifc:predefinedType_IfcEvaporator</a>
    /// </summary>
    let predefinedType_IfcEvaporator = _prefixId.prefix "predefinedType_IfcEvaporator"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcEvaporatorType">ifc:predefinedType_IfcEvaporatorType</a>
    /// </summary>
    let predefinedType_IfcEvaporatorType = _prefixId.prefix "predefinedType_IfcEvaporatorType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcEvent">ifc:predefinedType_IfcEvent</a>
    /// </summary>
    let predefinedType_IfcEvent = _prefixId.prefix "predefinedType_IfcEvent"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcEventType">ifc:predefinedType_IfcEventType</a>
    /// </summary>
    let predefinedType_IfcEventType = _prefixId.prefix "predefinedType_IfcEventType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcExternalSpatialElement">ifc:predefinedType_IfcExternalSpatialElement</a>
    /// </summary>
    let predefinedType_IfcExternalSpatialElement = _prefixId.prefix "predefinedType_IfcExternalSpatialElement"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFan">ifc:predefinedType_IfcFan</a>
    /// </summary>
    let predefinedType_IfcFan = _prefixId.prefix "predefinedType_IfcFan"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFanType">ifc:predefinedType_IfcFanType</a>
    /// </summary>
    let predefinedType_IfcFanType = _prefixId.prefix "predefinedType_IfcFanType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFastener">ifc:predefinedType_IfcFastener</a>
    /// </summary>
    let predefinedType_IfcFastener = _prefixId.prefix "predefinedType_IfcFastener"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFastenerType">ifc:predefinedType_IfcFastenerType</a>
    /// </summary>
    let predefinedType_IfcFastenerType = _prefixId.prefix "predefinedType_IfcFastenerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFilter">ifc:predefinedType_IfcFilter</a>
    /// </summary>
    let predefinedType_IfcFilter = _prefixId.prefix "predefinedType_IfcFilter"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFilterType">ifc:predefinedType_IfcFilterType</a>
    /// </summary>
    let predefinedType_IfcFilterType = _prefixId.prefix "predefinedType_IfcFilterType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFireSuppressionTerminal">ifc:predefinedType_IfcFireSuppressionTerminal</a>
    /// </summary>
    let predefinedType_IfcFireSuppressionTerminal = _prefixId.prefix "predefinedType_IfcFireSuppressionTerminal"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFireSuppressionTerminalType">ifc:predefinedType_IfcFireSuppressionTerminalType</a>
    /// </summary>
    let predefinedType_IfcFireSuppressionTerminalType = _prefixId.prefix "predefinedType_IfcFireSuppressionTerminalType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFlowInstrument">ifc:predefinedType_IfcFlowInstrument</a>
    /// </summary>
    let predefinedType_IfcFlowInstrument = _prefixId.prefix "predefinedType_IfcFlowInstrument"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFlowInstrumentType">ifc:predefinedType_IfcFlowInstrumentType</a>
    /// </summary>
    let predefinedType_IfcFlowInstrumentType = _prefixId.prefix "predefinedType_IfcFlowInstrumentType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFlowMeter">ifc:predefinedType_IfcFlowMeter</a>
    /// </summary>
    let predefinedType_IfcFlowMeter = _prefixId.prefix "predefinedType_IfcFlowMeter"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFlowMeterType">ifc:predefinedType_IfcFlowMeterType</a>
    /// </summary>
    let predefinedType_IfcFlowMeterType = _prefixId.prefix "predefinedType_IfcFlowMeterType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFooting">ifc:predefinedType_IfcFooting</a>
    /// </summary>
    let predefinedType_IfcFooting = _prefixId.prefix "predefinedType_IfcFooting"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFootingType">ifc:predefinedType_IfcFootingType</a>
    /// </summary>
    let predefinedType_IfcFootingType = _prefixId.prefix "predefinedType_IfcFootingType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFurniture">ifc:predefinedType_IfcFurniture</a>
    /// </summary>
    let predefinedType_IfcFurniture = _prefixId.prefix "predefinedType_IfcFurniture"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcFurnitureType">ifc:predefinedType_IfcFurnitureType</a>
    /// </summary>
    let predefinedType_IfcFurnitureType = _prefixId.prefix "predefinedType_IfcFurnitureType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcGeographicElement">ifc:predefinedType_IfcGeographicElement</a>
    /// </summary>
    let predefinedType_IfcGeographicElement = _prefixId.prefix "predefinedType_IfcGeographicElement"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcGeographicElementType">ifc:predefinedType_IfcGeographicElementType</a>
    /// </summary>
    let predefinedType_IfcGeographicElementType = _prefixId.prefix "predefinedType_IfcGeographicElementType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcGrid">ifc:predefinedType_IfcGrid</a>
    /// </summary>
    let predefinedType_IfcGrid = _prefixId.prefix "predefinedType_IfcGrid"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcHeatExchanger">ifc:predefinedType_IfcHeatExchanger</a>
    /// </summary>
    let predefinedType_IfcHeatExchanger = _prefixId.prefix "predefinedType_IfcHeatExchanger"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcHeatExchangerType">ifc:predefinedType_IfcHeatExchangerType</a>
    /// </summary>
    let predefinedType_IfcHeatExchangerType = _prefixId.prefix "predefinedType_IfcHeatExchangerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcHumidifier">ifc:predefinedType_IfcHumidifier</a>
    /// </summary>
    let predefinedType_IfcHumidifier = _prefixId.prefix "predefinedType_IfcHumidifier"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcHumidifierType">ifc:predefinedType_IfcHumidifierType</a>
    /// </summary>
    let predefinedType_IfcHumidifierType = _prefixId.prefix "predefinedType_IfcHumidifierType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcInterceptor">ifc:predefinedType_IfcInterceptor</a>
    /// </summary>
    let predefinedType_IfcInterceptor = _prefixId.prefix "predefinedType_IfcInterceptor"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcInterceptorType">ifc:predefinedType_IfcInterceptorType</a>
    /// </summary>
    let predefinedType_IfcInterceptorType = _prefixId.prefix "predefinedType_IfcInterceptorType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcInventory">ifc:predefinedType_IfcInventory</a>
    /// </summary>
    let predefinedType_IfcInventory = _prefixId.prefix "predefinedType_IfcInventory"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcJunctionBox">ifc:predefinedType_IfcJunctionBox</a>
    /// </summary>
    let predefinedType_IfcJunctionBox = _prefixId.prefix "predefinedType_IfcJunctionBox"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcJunctionBoxType">ifc:predefinedType_IfcJunctionBoxType</a>
    /// </summary>
    let predefinedType_IfcJunctionBoxType = _prefixId.prefix "predefinedType_IfcJunctionBoxType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcLaborResource">ifc:predefinedType_IfcLaborResource</a>
    /// </summary>
    let predefinedType_IfcLaborResource = _prefixId.prefix "predefinedType_IfcLaborResource"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcLaborResourceType">ifc:predefinedType_IfcLaborResourceType</a>
    /// </summary>
    let predefinedType_IfcLaborResourceType = _prefixId.prefix "predefinedType_IfcLaborResourceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcLamp">ifc:predefinedType_IfcLamp</a>
    /// </summary>
    let predefinedType_IfcLamp = _prefixId.prefix "predefinedType_IfcLamp"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcLampType">ifc:predefinedType_IfcLampType</a>
    /// </summary>
    let predefinedType_IfcLampType = _prefixId.prefix "predefinedType_IfcLampType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcLightFixture">ifc:predefinedType_IfcLightFixture</a>
    /// </summary>
    let predefinedType_IfcLightFixture = _prefixId.prefix "predefinedType_IfcLightFixture"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcLightFixtureType">ifc:predefinedType_IfcLightFixtureType</a>
    /// </summary>
    let predefinedType_IfcLightFixtureType = _prefixId.prefix "predefinedType_IfcLightFixtureType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcMechanicalFastener">ifc:predefinedType_IfcMechanicalFastener</a>
    /// </summary>
    let predefinedType_IfcMechanicalFastener = _prefixId.prefix "predefinedType_IfcMechanicalFastener"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcMechanicalFastenerType">ifc:predefinedType_IfcMechanicalFastenerType</a>
    /// </summary>
    let predefinedType_IfcMechanicalFastenerType = _prefixId.prefix "predefinedType_IfcMechanicalFastenerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcMedicalDevice">ifc:predefinedType_IfcMedicalDevice</a>
    /// </summary>
    let predefinedType_IfcMedicalDevice = _prefixId.prefix "predefinedType_IfcMedicalDevice"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcMedicalDeviceType">ifc:predefinedType_IfcMedicalDeviceType</a>
    /// </summary>
    let predefinedType_IfcMedicalDeviceType = _prefixId.prefix "predefinedType_IfcMedicalDeviceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcMember">ifc:predefinedType_IfcMember</a>
    /// </summary>
    let predefinedType_IfcMember = _prefixId.prefix "predefinedType_IfcMember"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcMemberType">ifc:predefinedType_IfcMemberType</a>
    /// </summary>
    let predefinedType_IfcMemberType = _prefixId.prefix "predefinedType_IfcMemberType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcMotorConnection">ifc:predefinedType_IfcMotorConnection</a>
    /// </summary>
    let predefinedType_IfcMotorConnection = _prefixId.prefix "predefinedType_IfcMotorConnection"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcMotorConnectionType">ifc:predefinedType_IfcMotorConnectionType</a>
    /// </summary>
    let predefinedType_IfcMotorConnectionType = _prefixId.prefix "predefinedType_IfcMotorConnectionType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcOccupant">ifc:predefinedType_IfcOccupant</a>
    /// </summary>
    let predefinedType_IfcOccupant = _prefixId.prefix "predefinedType_IfcOccupant"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcOpeningElement">ifc:predefinedType_IfcOpeningElement</a>
    /// </summary>
    let predefinedType_IfcOpeningElement = _prefixId.prefix "predefinedType_IfcOpeningElement"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcOutlet">ifc:predefinedType_IfcOutlet</a>
    /// </summary>
    let predefinedType_IfcOutlet = _prefixId.prefix "predefinedType_IfcOutlet"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcOutletType">ifc:predefinedType_IfcOutletType</a>
    /// </summary>
    let predefinedType_IfcOutletType = _prefixId.prefix "predefinedType_IfcOutletType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPerformanceHistory">ifc:predefinedType_IfcPerformanceHistory</a>
    /// </summary>
    let predefinedType_IfcPerformanceHistory = _prefixId.prefix "predefinedType_IfcPerformanceHistory"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPermit">ifc:predefinedType_IfcPermit</a>
    /// </summary>
    let predefinedType_IfcPermit = _prefixId.prefix "predefinedType_IfcPermit"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPile">ifc:predefinedType_IfcPile</a>
    /// </summary>
    let predefinedType_IfcPile = _prefixId.prefix "predefinedType_IfcPile"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPileType">ifc:predefinedType_IfcPileType</a>
    /// </summary>
    let predefinedType_IfcPileType = _prefixId.prefix "predefinedType_IfcPileType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPipeFitting">ifc:predefinedType_IfcPipeFitting</a>
    /// </summary>
    let predefinedType_IfcPipeFitting = _prefixId.prefix "predefinedType_IfcPipeFitting"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPipeFittingType">ifc:predefinedType_IfcPipeFittingType</a>
    /// </summary>
    let predefinedType_IfcPipeFittingType = _prefixId.prefix "predefinedType_IfcPipeFittingType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPipeSegment">ifc:predefinedType_IfcPipeSegment</a>
    /// </summary>
    let predefinedType_IfcPipeSegment = _prefixId.prefix "predefinedType_IfcPipeSegment"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPipeSegmentType">ifc:predefinedType_IfcPipeSegmentType</a>
    /// </summary>
    let predefinedType_IfcPipeSegmentType = _prefixId.prefix "predefinedType_IfcPipeSegmentType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPlate">ifc:predefinedType_IfcPlate</a>
    /// </summary>
    let predefinedType_IfcPlate = _prefixId.prefix "predefinedType_IfcPlate"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPlateType">ifc:predefinedType_IfcPlateType</a>
    /// </summary>
    let predefinedType_IfcPlateType = _prefixId.prefix "predefinedType_IfcPlateType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcProcedure">ifc:predefinedType_IfcProcedure</a>
    /// </summary>
    let predefinedType_IfcProcedure = _prefixId.prefix "predefinedType_IfcProcedure"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcProcedureType">ifc:predefinedType_IfcProcedureType</a>
    /// </summary>
    let predefinedType_IfcProcedureType = _prefixId.prefix "predefinedType_IfcProcedureType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcProjectOrder">ifc:predefinedType_IfcProjectOrder</a>
    /// </summary>
    let predefinedType_IfcProjectOrder = _prefixId.prefix "predefinedType_IfcProjectOrder"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcProjectionElement">ifc:predefinedType_IfcProjectionElement</a>
    /// </summary>
    let predefinedType_IfcProjectionElement = _prefixId.prefix "predefinedType_IfcProjectionElement"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcProtectiveDevice">ifc:predefinedType_IfcProtectiveDevice</a>
    /// </summary>
    let predefinedType_IfcProtectiveDevice = _prefixId.prefix "predefinedType_IfcProtectiveDevice"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcProtectiveDeviceTrippingUnit">ifc:predefinedType_IfcProtectiveDeviceTrippingUnit</a>
    /// </summary>
    let predefinedType_IfcProtectiveDeviceTrippingUnit = _prefixId.prefix "predefinedType_IfcProtectiveDeviceTrippingUnit"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcProtectiveDeviceTrippingUnitType">ifc:predefinedType_IfcProtectiveDeviceTrippingUnitType</a>
    /// </summary>
    let predefinedType_IfcProtectiveDeviceTrippingUnitType = _prefixId.prefix "predefinedType_IfcProtectiveDeviceTrippingUnitType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcProtectiveDeviceType">ifc:predefinedType_IfcProtectiveDeviceType</a>
    /// </summary>
    let predefinedType_IfcProtectiveDeviceType = _prefixId.prefix "predefinedType_IfcProtectiveDeviceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPump">ifc:predefinedType_IfcPump</a>
    /// </summary>
    let predefinedType_IfcPump = _prefixId.prefix "predefinedType_IfcPump"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcPumpType">ifc:predefinedType_IfcPumpType</a>
    /// </summary>
    let predefinedType_IfcPumpType = _prefixId.prefix "predefinedType_IfcPumpType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcRailing">ifc:predefinedType_IfcRailing</a>
    /// </summary>
    let predefinedType_IfcRailing = _prefixId.prefix "predefinedType_IfcRailing"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcRailingType">ifc:predefinedType_IfcRailingType</a>
    /// </summary>
    let predefinedType_IfcRailingType = _prefixId.prefix "predefinedType_IfcRailingType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcRamp">ifc:predefinedType_IfcRamp</a>
    /// </summary>
    let predefinedType_IfcRamp = _prefixId.prefix "predefinedType_IfcRamp"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcRampFlight">ifc:predefinedType_IfcRampFlight</a>
    /// </summary>
    let predefinedType_IfcRampFlight = _prefixId.prefix "predefinedType_IfcRampFlight"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcRampFlightType">ifc:predefinedType_IfcRampFlightType</a>
    /// </summary>
    let predefinedType_IfcRampFlightType = _prefixId.prefix "predefinedType_IfcRampFlightType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcRampType">ifc:predefinedType_IfcRampType</a>
    /// </summary>
    let predefinedType_IfcRampType = _prefixId.prefix "predefinedType_IfcRampType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcReinforcingBar">ifc:predefinedType_IfcReinforcingBar</a>
    /// </summary>
    let predefinedType_IfcReinforcingBar = _prefixId.prefix "predefinedType_IfcReinforcingBar"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcReinforcingBarType">ifc:predefinedType_IfcReinforcingBarType</a>
    /// </summary>
    let predefinedType_IfcReinforcingBarType = _prefixId.prefix "predefinedType_IfcReinforcingBarType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcReinforcingMesh">ifc:predefinedType_IfcReinforcingMesh</a>
    /// </summary>
    let predefinedType_IfcReinforcingMesh = _prefixId.prefix "predefinedType_IfcReinforcingMesh"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcReinforcingMeshType">ifc:predefinedType_IfcReinforcingMeshType</a>
    /// </summary>
    let predefinedType_IfcReinforcingMeshType = _prefixId.prefix "predefinedType_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcRoof">ifc:predefinedType_IfcRoof</a>
    /// </summary>
    let predefinedType_IfcRoof = _prefixId.prefix "predefinedType_IfcRoof"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcRoofType">ifc:predefinedType_IfcRoofType</a>
    /// </summary>
    let predefinedType_IfcRoofType = _prefixId.prefix "predefinedType_IfcRoofType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSanitaryTerminal">ifc:predefinedType_IfcSanitaryTerminal</a>
    /// </summary>
    let predefinedType_IfcSanitaryTerminal = _prefixId.prefix "predefinedType_IfcSanitaryTerminal"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSanitaryTerminalType">ifc:predefinedType_IfcSanitaryTerminalType</a>
    /// </summary>
    let predefinedType_IfcSanitaryTerminalType = _prefixId.prefix "predefinedType_IfcSanitaryTerminalType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSensor">ifc:predefinedType_IfcSensor</a>
    /// </summary>
    let predefinedType_IfcSensor = _prefixId.prefix "predefinedType_IfcSensor"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSensorType">ifc:predefinedType_IfcSensorType</a>
    /// </summary>
    let predefinedType_IfcSensorType = _prefixId.prefix "predefinedType_IfcSensorType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcShadingDevice">ifc:predefinedType_IfcShadingDevice</a>
    /// </summary>
    let predefinedType_IfcShadingDevice = _prefixId.prefix "predefinedType_IfcShadingDevice"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcShadingDeviceType">ifc:predefinedType_IfcShadingDeviceType</a>
    /// </summary>
    let predefinedType_IfcShadingDeviceType = _prefixId.prefix "predefinedType_IfcShadingDeviceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSlab">ifc:predefinedType_IfcSlab</a>
    /// </summary>
    let predefinedType_IfcSlab = _prefixId.prefix "predefinedType_IfcSlab"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSlabType">ifc:predefinedType_IfcSlabType</a>
    /// </summary>
    let predefinedType_IfcSlabType = _prefixId.prefix "predefinedType_IfcSlabType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSolarDevice">ifc:predefinedType_IfcSolarDevice</a>
    /// </summary>
    let predefinedType_IfcSolarDevice = _prefixId.prefix "predefinedType_IfcSolarDevice"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSolarDeviceType">ifc:predefinedType_IfcSolarDeviceType</a>
    /// </summary>
    let predefinedType_IfcSolarDeviceType = _prefixId.prefix "predefinedType_IfcSolarDeviceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSpace">ifc:predefinedType_IfcSpace</a>
    /// </summary>
    let predefinedType_IfcSpace = _prefixId.prefix "predefinedType_IfcSpace"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSpaceHeater">ifc:predefinedType_IfcSpaceHeater</a>
    /// </summary>
    let predefinedType_IfcSpaceHeater = _prefixId.prefix "predefinedType_IfcSpaceHeater"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSpaceHeaterType">ifc:predefinedType_IfcSpaceHeaterType</a>
    /// </summary>
    let predefinedType_IfcSpaceHeaterType = _prefixId.prefix "predefinedType_IfcSpaceHeaterType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSpaceType">ifc:predefinedType_IfcSpaceType</a>
    /// </summary>
    let predefinedType_IfcSpaceType = _prefixId.prefix "predefinedType_IfcSpaceType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSpatialZone">ifc:predefinedType_IfcSpatialZone</a>
    /// </summary>
    let predefinedType_IfcSpatialZone = _prefixId.prefix "predefinedType_IfcSpatialZone"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSpatialZoneType">ifc:predefinedType_IfcSpatialZoneType</a>
    /// </summary>
    let predefinedType_IfcSpatialZoneType = _prefixId.prefix "predefinedType_IfcSpatialZoneType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStackTerminal">ifc:predefinedType_IfcStackTerminal</a>
    /// </summary>
    let predefinedType_IfcStackTerminal = _prefixId.prefix "predefinedType_IfcStackTerminal"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStackTerminalType">ifc:predefinedType_IfcStackTerminalType</a>
    /// </summary>
    let predefinedType_IfcStackTerminalType = _prefixId.prefix "predefinedType_IfcStackTerminalType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStair">ifc:predefinedType_IfcStair</a>
    /// </summary>
    let predefinedType_IfcStair = _prefixId.prefix "predefinedType_IfcStair"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStairFlight">ifc:predefinedType_IfcStairFlight</a>
    /// </summary>
    let predefinedType_IfcStairFlight = _prefixId.prefix "predefinedType_IfcStairFlight"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStairFlightType">ifc:predefinedType_IfcStairFlightType</a>
    /// </summary>
    let predefinedType_IfcStairFlightType = _prefixId.prefix "predefinedType_IfcStairFlightType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStairType">ifc:predefinedType_IfcStairType</a>
    /// </summary>
    let predefinedType_IfcStairType = _prefixId.prefix "predefinedType_IfcStairType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStructuralAnalysisModel">ifc:predefinedType_IfcStructuralAnalysisModel</a>
    /// </summary>
    let predefinedType_IfcStructuralAnalysisModel = _prefixId.prefix "predefinedType_IfcStructuralAnalysisModel"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStructuralCurveAction">ifc:predefinedType_IfcStructuralCurveAction</a>
    /// </summary>
    let predefinedType_IfcStructuralCurveAction = _prefixId.prefix "predefinedType_IfcStructuralCurveAction"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStructuralCurveMember">ifc:predefinedType_IfcStructuralCurveMember</a>
    /// </summary>
    let predefinedType_IfcStructuralCurveMember = _prefixId.prefix "predefinedType_IfcStructuralCurveMember"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStructuralCurveReaction">ifc:predefinedType_IfcStructuralCurveReaction</a>
    /// </summary>
    let predefinedType_IfcStructuralCurveReaction = _prefixId.prefix "predefinedType_IfcStructuralCurveReaction"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStructuralLoadGroup">ifc:predefinedType_IfcStructuralLoadGroup</a>
    /// </summary>
    let predefinedType_IfcStructuralLoadGroup = _prefixId.prefix "predefinedType_IfcStructuralLoadGroup"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStructuralSurfaceAction">ifc:predefinedType_IfcStructuralSurfaceAction</a>
    /// </summary>
    let predefinedType_IfcStructuralSurfaceAction = _prefixId.prefix "predefinedType_IfcStructuralSurfaceAction"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStructuralSurfaceMember">ifc:predefinedType_IfcStructuralSurfaceMember</a>
    /// </summary>
    let predefinedType_IfcStructuralSurfaceMember = _prefixId.prefix "predefinedType_IfcStructuralSurfaceMember"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcStructuralSurfaceReaction">ifc:predefinedType_IfcStructuralSurfaceReaction</a>
    /// </summary>
    let predefinedType_IfcStructuralSurfaceReaction = _prefixId.prefix "predefinedType_IfcStructuralSurfaceReaction"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSubContractResource">ifc:predefinedType_IfcSubContractResource</a>
    /// </summary>
    let predefinedType_IfcSubContractResource = _prefixId.prefix "predefinedType_IfcSubContractResource"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSubContractResourceType">ifc:predefinedType_IfcSubContractResourceType</a>
    /// </summary>
    let predefinedType_IfcSubContractResourceType = _prefixId.prefix "predefinedType_IfcSubContractResourceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSurfaceFeature">ifc:predefinedType_IfcSurfaceFeature</a>
    /// </summary>
    let predefinedType_IfcSurfaceFeature = _prefixId.prefix "predefinedType_IfcSurfaceFeature"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSwitchingDevice">ifc:predefinedType_IfcSwitchingDevice</a>
    /// </summary>
    let predefinedType_IfcSwitchingDevice = _prefixId.prefix "predefinedType_IfcSwitchingDevice"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSwitchingDeviceType">ifc:predefinedType_IfcSwitchingDeviceType</a>
    /// </summary>
    let predefinedType_IfcSwitchingDeviceType = _prefixId.prefix "predefinedType_IfcSwitchingDeviceType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSystemFurnitureElement">ifc:predefinedType_IfcSystemFurnitureElement</a>
    /// </summary>
    let predefinedType_IfcSystemFurnitureElement = _prefixId.prefix "predefinedType_IfcSystemFurnitureElement"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcSystemFurnitureElementType">ifc:predefinedType_IfcSystemFurnitureElementType</a>
    /// </summary>
    let predefinedType_IfcSystemFurnitureElementType = _prefixId.prefix "predefinedType_IfcSystemFurnitureElementType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTank">ifc:predefinedType_IfcTank</a>
    /// </summary>
    let predefinedType_IfcTank = _prefixId.prefix "predefinedType_IfcTank"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTankType">ifc:predefinedType_IfcTankType</a>
    /// </summary>
    let predefinedType_IfcTankType = _prefixId.prefix "predefinedType_IfcTankType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTask">ifc:predefinedType_IfcTask</a>
    /// </summary>
    let predefinedType_IfcTask = _prefixId.prefix "predefinedType_IfcTask"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTaskType">ifc:predefinedType_IfcTaskType</a>
    /// </summary>
    let predefinedType_IfcTaskType = _prefixId.prefix "predefinedType_IfcTaskType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTendon">ifc:predefinedType_IfcTendon</a>
    /// </summary>
    let predefinedType_IfcTendon = _prefixId.prefix "predefinedType_IfcTendon"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTendonAnchor">ifc:predefinedType_IfcTendonAnchor</a>
    /// </summary>
    let predefinedType_IfcTendonAnchor = _prefixId.prefix "predefinedType_IfcTendonAnchor"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTendonAnchorType">ifc:predefinedType_IfcTendonAnchorType</a>
    /// </summary>
    let predefinedType_IfcTendonAnchorType = _prefixId.prefix "predefinedType_IfcTendonAnchorType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTendonType">ifc:predefinedType_IfcTendonType</a>
    /// </summary>
    let predefinedType_IfcTendonType = _prefixId.prefix "predefinedType_IfcTendonType"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTransformer">ifc:predefinedType_IfcTransformer</a>
    /// </summary>
    let predefinedType_IfcTransformer = _prefixId.prefix "predefinedType_IfcTransformer"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTransformerType">ifc:predefinedType_IfcTransformerType</a>
    /// </summary>
    let predefinedType_IfcTransformerType = _prefixId.prefix "predefinedType_IfcTransformerType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTransportElement">ifc:predefinedType_IfcTransportElement</a>
    /// </summary>
    let predefinedType_IfcTransportElement = _prefixId.prefix "predefinedType_IfcTransportElement"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTransportElementType">ifc:predefinedType_IfcTransportElementType</a>
    /// </summary>
    let predefinedType_IfcTransportElementType = _prefixId.prefix "predefinedType_IfcTransportElementType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTubeBundle">ifc:predefinedType_IfcTubeBundle</a>
    /// </summary>
    let predefinedType_IfcTubeBundle = _prefixId.prefix "predefinedType_IfcTubeBundle"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcTubeBundleType">ifc:predefinedType_IfcTubeBundleType</a>
    /// </summary>
    let predefinedType_IfcTubeBundleType = _prefixId.prefix "predefinedType_IfcTubeBundleType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcUnitaryControlElement">ifc:predefinedType_IfcUnitaryControlElement</a>
    /// </summary>
    let predefinedType_IfcUnitaryControlElement = _prefixId.prefix "predefinedType_IfcUnitaryControlElement"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcUnitaryControlElementType">ifc:predefinedType_IfcUnitaryControlElementType</a>
    /// </summary>
    let predefinedType_IfcUnitaryControlElementType = _prefixId.prefix "predefinedType_IfcUnitaryControlElementType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcUnitaryEquipment">ifc:predefinedType_IfcUnitaryEquipment</a>
    /// </summary>
    let predefinedType_IfcUnitaryEquipment = _prefixId.prefix "predefinedType_IfcUnitaryEquipment"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcUnitaryEquipmentType">ifc:predefinedType_IfcUnitaryEquipmentType</a>
    /// </summary>
    let predefinedType_IfcUnitaryEquipmentType = _prefixId.prefix "predefinedType_IfcUnitaryEquipmentType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcValve">ifc:predefinedType_IfcValve</a>
    /// </summary>
    let predefinedType_IfcValve = _prefixId.prefix "predefinedType_IfcValve"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcValveType">ifc:predefinedType_IfcValveType</a>
    /// </summary>
    let predefinedType_IfcValveType = _prefixId.prefix "predefinedType_IfcValveType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcVibrationIsolator">ifc:predefinedType_IfcVibrationIsolator</a>
    /// </summary>
    let predefinedType_IfcVibrationIsolator = _prefixId.prefix "predefinedType_IfcVibrationIsolator"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcVibrationIsolatorType">ifc:predefinedType_IfcVibrationIsolatorType</a>
    /// </summary>
    let predefinedType_IfcVibrationIsolatorType = _prefixId.prefix "predefinedType_IfcVibrationIsolatorType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcVoidingFeature">ifc:predefinedType_IfcVoidingFeature</a>
    /// </summary>
    let predefinedType_IfcVoidingFeature = _prefixId.prefix "predefinedType_IfcVoidingFeature"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcWall">ifc:predefinedType_IfcWall</a>
    /// </summary>
    let predefinedType_IfcWall = _prefixId.prefix "predefinedType_IfcWall"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcWallType">ifc:predefinedType_IfcWallType</a>
    /// </summary>
    let predefinedType_IfcWallType = _prefixId.prefix "predefinedType_IfcWallType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcWasteTerminal">ifc:predefinedType_IfcWasteTerminal</a>
    /// </summary>
    let predefinedType_IfcWasteTerminal = _prefixId.prefix "predefinedType_IfcWasteTerminal"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcWasteTerminalType">ifc:predefinedType_IfcWasteTerminalType</a>
    /// </summary>
    let predefinedType_IfcWasteTerminalType = _prefixId.prefix "predefinedType_IfcWasteTerminalType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcWindow">ifc:predefinedType_IfcWindow</a>
    /// </summary>
    let predefinedType_IfcWindow = _prefixId.prefix "predefinedType_IfcWindow"
    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcWindowType">ifc:predefinedType_IfcWindowType</a>
    /// </summary>
    let predefinedType_IfcWindowType = _prefixId.prefix "predefinedType_IfcWindowType"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcWorkCalendar">ifc:predefinedType_IfcWorkCalendar</a>
    /// </summary>
    let predefinedType_IfcWorkCalendar = _prefixId.prefix "predefinedType_IfcWorkCalendar"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcWorkPlan">ifc:predefinedType_IfcWorkPlan</a>
    /// </summary>
    let predefinedType_IfcWorkPlan = _prefixId.prefix "predefinedType_IfcWorkPlan"

    /// <summary>
    ///   <para>rdfs:label : PredefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#predefinedType_IfcWorkSchedule">ifc:predefinedType_IfcWorkSchedule</a>
    /// </summary>
    let predefinedType_IfcWorkSchedule = _prefixId.prefix "predefinedType_IfcWorkSchedule"

    /// <summary>
    ///   <para>rdfs:label : PrefixTitles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#prefixTitles_IfcPerson">ifc:prefixTitles_IfcPerson</a>
    /// </summary>
    let prefixTitles_IfcPerson = _prefixId.prefix "prefixTitles_IfcPerson"
    /// <summary>
    ///   <para>rdfs:label : Prefix^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#prefix_IfcSIUnit">ifc:prefix_IfcSIUnit</a>
    /// </summary>
    let prefix_IfcSIUnit = _prefixId.prefix "prefix_IfcSIUnit"

    /// <summary>
    ///   <para>rdfs:label : PrimaryMeasureType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#primaryMeasureType_IfcSimplePropertyTemplate">ifc:primaryMeasureType_IfcSimplePropertyTemplate</a>
    /// </summary>
    let primaryMeasureType_IfcSimplePropertyTemplate = _prefixId.prefix "primaryMeasureType_IfcSimplePropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : PrimaryUnit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#primaryUnit_IfcSimplePropertyTemplate">ifc:primaryUnit_IfcSimplePropertyTemplate</a>
    /// </summary>
    let primaryUnit_IfcSimplePropertyTemplate = _prefixId.prefix "primaryUnit_IfcSimplePropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : Priority^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#priority_IfcMaterialLayer">ifc:priority_IfcMaterialLayer</a>
    /// </summary>
    let priority_IfcMaterialLayer = _prefixId.prefix "priority_IfcMaterialLayer"
    /// <summary>
    ///   <para>rdfs:label : Priority^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#priority_IfcMaterialProfile">ifc:priority_IfcMaterialProfile</a>
    /// </summary>
    let priority_IfcMaterialProfile = _prefixId.prefix "priority_IfcMaterialProfile"
    /// <summary>
    ///   <para>rdfs:label : Priority^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#priority_IfcTask">ifc:priority_IfcTask</a>
    /// </summary>
    let priority_IfcTask = _prefixId.prefix "priority_IfcTask"
    /// <summary>
    ///   <para>rdfs:label : ProcessType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#processType_IfcTypeProcess">ifc:processType_IfcTypeProcess</a>
    /// </summary>
    let processType_IfcTypeProcess = _prefixId.prefix "processType_IfcTypeProcess"

    /// <summary>
    ///   <para>rdfs:label : ProductDefinitional^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#productDefinitional_IfcShapeAspect">ifc:productDefinitional_IfcShapeAspect</a>
    /// </summary>
    let productDefinitional_IfcShapeAspect = _prefixId.prefix "productDefinitional_IfcShapeAspect"

    /// <summary>
    ///   <para>rdfs:label : ProfileDefinition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#profileDefinition_IfcProfileProperties">ifc:profileDefinition_IfcProfileProperties</a>
    /// </summary>
    let profileDefinition_IfcProfileProperties = _prefixId.prefix "profileDefinition_IfcProfileProperties"

    /// <summary>
    ///   <para>rdfs:label : ProfileName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#profileName_IfcProfileDef">ifc:profileName_IfcProfileDef</a>
    /// </summary>
    let profileName_IfcProfileDef = _prefixId.prefix "profileName_IfcProfileDef"
    /// <summary>
    ///   <para>rdfs:label : ProfileType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#profileType_IfcProfileDef">ifc:profileType_IfcProfileDef</a>
    /// </summary>
    let profileType_IfcProfileDef = _prefixId.prefix "profileType_IfcProfileDef"
    /// <summary>
    ///   <para>rdfs:label : Profile^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#profile_IfcMaterialProfile">ifc:profile_IfcMaterialProfile</a>
    /// </summary>
    let profile_IfcMaterialProfile = _prefixId.prefix "profile_IfcMaterialProfile"

    /// <summary>
    ///   <para>rdfs:label : Profiles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#profiles_IfcCompositeProfileDef">ifc:profiles_IfcCompositeProfileDef</a>
    /// </summary>
    let profiles_IfcCompositeProfileDef = _prefixId.prefix "profiles_IfcCompositeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : ProjectedOrTrue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#projectedOrTrue_IfcStructuralCurveAction">ifc:projectedOrTrue_IfcStructuralCurveAction</a>
    /// </summary>
    let projectedOrTrue_IfcStructuralCurveAction = _prefixId.prefix "projectedOrTrue_IfcStructuralCurveAction"

    /// <summary>
    ///   <para>rdfs:label : ProjectedOrTrue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#projectedOrTrue_IfcStructuralSurfaceAction">ifc:projectedOrTrue_IfcStructuralSurfaceAction</a>
    /// </summary>
    let projectedOrTrue_IfcStructuralSurfaceAction = _prefixId.prefix "projectedOrTrue_IfcStructuralSurfaceAction"

    /// <summary>
    ///   <para>rdfs:label : ProjectsElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#projectsElements_IfcFeatureElementAddition">ifc:projectsElements_IfcFeatureElementAddition</a>
    /// </summary>
    let projectsElements_IfcFeatureElementAddition = _prefixId.prefix "projectsElements_IfcFeatureElementAddition"

    /// <summary>
    ///   <para>rdfs:label : PropertiesForConstraint^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#propertiesForConstraint_IfcConstraint">ifc:propertiesForConstraint_IfcConstraint</a>
    /// </summary>
    let propertiesForConstraint_IfcConstraint = _prefixId.prefix "propertiesForConstraint_IfcConstraint"

    /// <summary>
    ///   <para>rdfs:label : Properties^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#properties_IfcExtendedProperties">ifc:properties_IfcExtendedProperties</a>
    /// </summary>
    let properties_IfcExtendedProperties = _prefixId.prefix "properties_IfcExtendedProperties"

    /// <summary>
    ///   <para>rdfs:label : PropertyDependsOn^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#propertyDependsOn_IfcProperty">ifc:propertyDependsOn_IfcProperty</a>
    /// </summary>
    let propertyDependsOn_IfcProperty = _prefixId.prefix "propertyDependsOn_IfcProperty"

    /// <summary>
    ///   <para>rdfs:label : PropertyForDependance^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#propertyForDependance_IfcProperty">ifc:propertyForDependance_IfcProperty</a>
    /// </summary>
    let propertyForDependance_IfcProperty = _prefixId.prefix "propertyForDependance_IfcProperty"

    /// <summary>
    ///   <para>rdfs:label : PropertyReference^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#propertyReference_IfcPropertyReferenceValue">ifc:propertyReference_IfcPropertyReferenceValue</a>
    /// </summary>
    let propertyReference_IfcPropertyReferenceValue = _prefixId.prefix "propertyReference_IfcPropertyReferenceValue"

    /// <summary>
    ///   <para>rdfs:label : ProvidesBoundaries^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#providesBoundaries_IfcElement">ifc:providesBoundaries_IfcElement</a>
    /// </summary>
    let providesBoundaries_IfcElement = _prefixId.prefix "providesBoundaries_IfcElement"
    /// <summary>
    ///   <para>rdfs:label : ProxyType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#proxyType_IfcProxy">ifc:proxyType_IfcProxy</a>
    /// </summary>
    let proxyType_IfcProxy = _prefixId.prefix "proxyType_IfcProxy"

    /// <summary>
    ///   <para>rdfs:label : Publisher^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#publisher_IfcLibraryInformation">ifc:publisher_IfcLibraryInformation</a>
    /// </summary>
    let publisher_IfcLibraryInformation = _prefixId.prefix "publisher_IfcLibraryInformation"

    /// <summary>
    ///   <para>rdfs:label : Purpose^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#purpose_IfcAddress">ifc:purpose_IfcAddress</a>
    /// </summary>
    let purpose_IfcAddress = _prefixId.prefix "purpose_IfcAddress"

    /// <summary>
    ///   <para>rdfs:label : Purpose^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#purpose_IfcDocumentInformation">ifc:purpose_IfcDocumentInformation</a>
    /// </summary>
    let purpose_IfcDocumentInformation = _prefixId.prefix "purpose_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : Purpose^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#purpose_IfcStructuralLoadGroup">ifc:purpose_IfcStructuralLoadGroup</a>
    /// </summary>
    let purpose_IfcStructuralLoadGroup = _prefixId.prefix "purpose_IfcStructuralLoadGroup"

    /// <summary>
    ///   <para>rdfs:label : Purpose^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#purpose_IfcWorkControl">ifc:purpose_IfcWorkControl</a>
    /// </summary>
    let purpose_IfcWorkControl = _prefixId.prefix "purpose_IfcWorkControl"

    /// <summary>
    ///   <para>rdfs:label : QuadricAttenuation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#quadricAttenuation_IfcLightSourcePositional">ifc:quadricAttenuation_IfcLightSourcePositional</a>
    /// </summary>
    let quadricAttenuation_IfcLightSourcePositional = _prefixId.prefix "quadricAttenuation_IfcLightSourcePositional"

    /// <summary>
    ///   <para>rdfs:label : Qualifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#qualifier_IfcApproval">ifc:qualifier_IfcApproval</a>
    /// </summary>
    let qualifier_IfcApproval = _prefixId.prefix "qualifier_IfcApproval"

    /// <summary>
    ///   <para>rdfs:label : Quality^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#quality_IfcPhysicalComplexQuantity">ifc:quality_IfcPhysicalComplexQuantity</a>
    /// </summary>
    let quality_IfcPhysicalComplexQuantity = _prefixId.prefix "quality_IfcPhysicalComplexQuantity"

    /// <summary>
    ///   <para>rdfs:label : Quantities^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#quantities_IfcElementQuantity">ifc:quantities_IfcElementQuantity</a>
    /// </summary>
    let quantities_IfcElementQuantity = _prefixId.prefix "quantities_IfcElementQuantity"

    /// <summary>
    ///   <para>rdfs:label : QuantityInProcess^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#quantityInProcess_IfcRelAssignsToProcess">ifc:quantityInProcess_IfcRelAssignsToProcess</a>
    /// </summary>
    let quantityInProcess_IfcRelAssignsToProcess = _prefixId.prefix "quantityInProcess_IfcRelAssignsToProcess"

    /// <summary>
    ///   <para>rdfs:label : Radius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#radius_IfcCircle">ifc:radius_IfcCircle</a>
    /// </summary>
    let radius_IfcCircle = _prefixId.prefix "radius_IfcCircle"
    /// <summary>
    ///   <para>rdfs:label : Radius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#radius_IfcCircleProfileDef">ifc:radius_IfcCircleProfileDef</a>
    /// </summary>
    let radius_IfcCircleProfileDef = _prefixId.prefix "radius_IfcCircleProfileDef"
    /// <summary>
    ///   <para>rdfs:label : Radius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#radius_IfcCylindricalSurface">ifc:radius_IfcCylindricalSurface</a>
    /// </summary>
    let radius_IfcCylindricalSurface = _prefixId.prefix "radius_IfcCylindricalSurface"

    /// <summary>
    ///   <para>rdfs:label : Radius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#radius_IfcLightSourcePositional">ifc:radius_IfcLightSourcePositional</a>
    /// </summary>
    let radius_IfcLightSourcePositional = _prefixId.prefix "radius_IfcLightSourcePositional"

    /// <summary>
    ///   <para>rdfs:label : Radius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#radius_IfcRightCircularCylinder">ifc:radius_IfcRightCircularCylinder</a>
    /// </summary>
    let radius_IfcRightCircularCylinder = _prefixId.prefix "radius_IfcRightCircularCylinder"

    /// <summary>
    ///   <para>rdfs:label : Radius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#radius_IfcSphere">ifc:radius_IfcSphere</a>
    /// </summary>
    let radius_IfcSphere = _prefixId.prefix "radius_IfcSphere"
    /// <summary>
    ///   <para>rdfs:label : Radius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#radius_IfcSweptDiskSolid">ifc:radius_IfcSweptDiskSolid</a>
    /// </summary>
    let radius_IfcSweptDiskSolid = _prefixId.prefix "radius_IfcSweptDiskSolid"
    /// <summary>
    ///   <para>rdfs:label : RasterCode^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rasterCode_IfcBlobTexture">ifc:rasterCode_IfcBlobTexture</a>
    /// </summary>
    let rasterCode_IfcBlobTexture = _prefixId.prefix "rasterCode_IfcBlobTexture"
    /// <summary>
    ///   <para>rdfs:label : RasterFormat^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rasterFormat_IfcBlobTexture">ifc:rasterFormat_IfcBlobTexture</a>
    /// </summary>
    let rasterFormat_IfcBlobTexture = _prefixId.prefix "rasterFormat_IfcBlobTexture"

    /// <summary>
    ///   <para>rdfs:label : RateDateTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rateDateTime_IfcCurrencyRelationship">ifc:rateDateTime_IfcCurrencyRelationship</a>
    /// </summary>
    let rateDateTime_IfcCurrencyRelationship = _prefixId.prefix "rateDateTime_IfcCurrencyRelationship"

    /// <summary>
    ///   <para>rdfs:label : RateSource^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rateSource_IfcCurrencyRelationship">ifc:rateSource_IfcCurrencyRelationship</a>
    /// </summary>
    let rateSource_IfcCurrencyRelationship = _prefixId.prefix "rateSource_IfcCurrencyRelationship"

    /// <summary>
    ///   <para>rdfs:label : RealizingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#realizingElement_IfcRelConnectsPorts">ifc:realizingElement_IfcRelConnectsPorts</a>
    /// </summary>
    let realizingElement_IfcRelConnectsPorts = _prefixId.prefix "realizingElement_IfcRelConnectsPorts"

    /// <summary>
    ///   <para>rdfs:label : RealizingElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#realizingElements_IfcRelConnectsWithRealizingElements">ifc:realizingElements_IfcRelConnectsWithRealizingElements</a>
    /// </summary>
    let realizingElements_IfcRelConnectsWithRealizingElements = _prefixId.prefix "realizingElements_IfcRelConnectsWithRealizingElements"

    /// <summary>
    ///   <para>rdfs:label : RecurrencePattern^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#recurrencePattern_IfcWorkTime">ifc:recurrencePattern_IfcWorkTime</a>
    /// </summary>
    let recurrencePattern_IfcWorkTime = _prefixId.prefix "recurrencePattern_IfcWorkTime"

    /// <summary>
    ///   <para>rdfs:label : RecurrenceType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#recurrenceType_IfcRecurrencePattern">ifc:recurrenceType_IfcRecurrencePattern</a>
    /// </summary>
    let recurrenceType_IfcRecurrencePattern = _prefixId.prefix "recurrenceType_IfcRecurrencePattern"

    /// <summary>
    ///   <para>rdfs:label : Recurrence^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#recurrence_IfcTaskTimeRecurring">ifc:recurrence_IfcTaskTimeRecurring</a>
    /// </summary>
    let recurrence_IfcTaskTimeRecurring = _prefixId.prefix "recurrence_IfcTaskTimeRecurring"

    /// <summary>
    ///   <para>rdfs:label : Red^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#red_IfcColourRgb">ifc:red_IfcColourRgb</a>
    /// </summary>
    let red_IfcColourRgb = _prefixId.prefix "red_IfcColourRgb"

    /// <summary>
    ///   <para>rdfs:label : RefDirection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#refDirection_IfcAxis2Placement2D">ifc:refDirection_IfcAxis2Placement2D</a>
    /// </summary>
    let refDirection_IfcAxis2Placement2D = _prefixId.prefix "refDirection_IfcAxis2Placement2D"

    /// <summary>
    ///   <para>rdfs:label : RefDirection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#refDirection_IfcAxis2Placement3D">ifc:refDirection_IfcAxis2Placement3D</a>
    /// </summary>
    let refDirection_IfcAxis2Placement3D = _prefixId.prefix "refDirection_IfcAxis2Placement3D"

    /// <summary>
    ///   <para>rdfs:label : RefDirection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#refDirection_IfcOffsetCurve3D">ifc:refDirection_IfcOffsetCurve3D</a>
    /// </summary>
    let refDirection_IfcOffsetCurve3D = _prefixId.prefix "refDirection_IfcOffsetCurve3D"
    /// <summary>
    ///   <para>rdfs:label : RefElevation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#refElevation_IfcSite">ifc:refElevation_IfcSite</a>
    /// </summary>
    let refElevation_IfcSite = _prefixId.prefix "refElevation_IfcSite"
    /// <summary>
    ///   <para>rdfs:label : RefLatitude^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#refLatitude_IfcSite">ifc:refLatitude_IfcSite</a>
    /// </summary>
    let refLatitude_IfcSite = _prefixId.prefix "refLatitude_IfcSite"
    /// <summary>
    ///   <para>rdfs:label : RefLongitude^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#refLongitude_IfcSite">ifc:refLongitude_IfcSite</a>
    /// </summary>
    let refLongitude_IfcSite = _prefixId.prefix "refLongitude_IfcSite"
    /// <summary>
    ///   <para>rdfs:label : ReferenceCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referenceCurve_IfcPcurve">ifc:referenceCurve_IfcPcurve</a>
    /// </summary>
    let referenceCurve_IfcPcurve = _prefixId.prefix "referenceCurve_IfcPcurve"

    /// <summary>
    ///   <para>rdfs:label : ReferenceExtent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referenceExtent_IfcMaterialLayerSetUsage">ifc:referenceExtent_IfcMaterialLayerSetUsage</a>
    /// </summary>
    let referenceExtent_IfcMaterialLayerSetUsage = _prefixId.prefix "referenceExtent_IfcMaterialLayerSetUsage"

    /// <summary>
    ///   <para>rdfs:label : ReferenceExtent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referenceExtent_IfcMaterialProfileSetUsage">ifc:referenceExtent_IfcMaterialProfileSetUsage</a>
    /// </summary>
    let referenceExtent_IfcMaterialProfileSetUsage = _prefixId.prefix "referenceExtent_IfcMaterialProfileSetUsage"

    /// <summary>
    ///   <para>rdfs:label : ReferencePath^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referencePath_IfcMetric">ifc:referencePath_IfcMetric</a>
    /// </summary>
    let referencePath_IfcMetric = _prefixId.prefix "referencePath_IfcMetric"
    /// <summary>
    ///   <para>rdfs:label : ReferencePath^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referencePath_IfcTableColumn">ifc:referencePath_IfcTableColumn</a>
    /// </summary>
    let referencePath_IfcTableColumn = _prefixId.prefix "referencePath_IfcTableColumn"

    /// <summary>
    ///   <para>rdfs:label : ReferenceSurface^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referenceSurface_IfcSurfaceCurveSweptAreaSolid">ifc:referenceSurface_IfcSurfaceCurveSweptAreaSolid</a>
    /// </summary>
    let referenceSurface_IfcSurfaceCurveSweptAreaSolid = _prefixId.prefix "referenceSurface_IfcSurfaceCurveSweptAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : ReferenceTokens^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referenceTokens_IfcClassification">ifc:referenceTokens_IfcClassification</a>
    /// </summary>
    let referenceTokens_IfcClassification = _prefixId.prefix "referenceTokens_IfcClassification"

    /// <summary>
    ///   <para>rdfs:label : ReferencedByPlacements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referencedByPlacements_IfcObjectPlacement">ifc:referencedByPlacements_IfcObjectPlacement</a>
    /// </summary>
    let referencedByPlacements_IfcObjectPlacement = _prefixId.prefix "referencedByPlacements_IfcObjectPlacement"

    /// <summary>
    ///   <para>rdfs:label : ReferencedDocument^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referencedDocument_IfcDocumentReference">ifc:referencedDocument_IfcDocumentReference</a>
    /// </summary>
    let referencedDocument_IfcDocumentReference = _prefixId.prefix "referencedDocument_IfcDocumentReference"

    /// <summary>
    ///   <para>rdfs:label : ReferencedInStructures^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referencedInStructures_IfcElement">ifc:referencedInStructures_IfcElement</a>
    /// </summary>
    let referencedInStructures_IfcElement = _prefixId.prefix "referencedInStructures_IfcElement"

    /// <summary>
    ///   <para>rdfs:label : ReferencedLibrary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referencedLibrary_IfcLibraryReference">ifc:referencedLibrary_IfcLibraryReference</a>
    /// </summary>
    let referencedLibrary_IfcLibraryReference = _prefixId.prefix "referencedLibrary_IfcLibraryReference"

    /// <summary>
    ///   <para>rdfs:label : ReferencedSource^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referencedSource_IfcClassificationReference">ifc:referencedSource_IfcClassificationReference</a>
    /// </summary>
    let referencedSource_IfcClassificationReference = _prefixId.prefix "referencedSource_IfcClassificationReference"

    /// <summary>
    ///   <para>rdfs:label : ReferencesElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#referencesElements_IfcSpatialElement">ifc:referencesElements_IfcSpatialElement</a>
    /// </summary>
    let referencesElements_IfcSpatialElement = _prefixId.prefix "referencesElements_IfcSpatialElement"

    /// <summary>
    ///   <para>rdfs:label : ReflectanceColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#reflectanceColour_IfcSurfaceStyleLighting">ifc:reflectanceColour_IfcSurfaceStyleLighting</a>
    /// </summary>
    let reflectanceColour_IfcSurfaceStyleLighting = _prefixId.prefix "reflectanceColour_IfcSurfaceStyleLighting"

    /// <summary>
    ///   <para>rdfs:label : ReflectanceMethod^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#reflectanceMethod_IfcSurfaceStyleRendering">ifc:reflectanceMethod_IfcSurfaceStyleRendering</a>
    /// </summary>
    let reflectanceMethod_IfcSurfaceStyleRendering = _prefixId.prefix "reflectanceMethod_IfcSurfaceStyleRendering"

    /// <summary>
    ///   <para>rdfs:label : ReflectionColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#reflectionColour_IfcSurfaceStyleRendering">ifc:reflectionColour_IfcSurfaceStyleRendering</a>
    /// </summary>
    let reflectionColour_IfcSurfaceStyleRendering = _prefixId.prefix "reflectionColour_IfcSurfaceStyleRendering"

    /// <summary>
    ///   <para>rdfs:label : RefractionIndex^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#refractionIndex_IfcSurfaceStyleRefraction">ifc:refractionIndex_IfcSurfaceStyleRefraction</a>
    /// </summary>
    let refractionIndex_IfcSurfaceStyleRefraction = _prefixId.prefix "refractionIndex_IfcSurfaceStyleRefraction"

    /// <summary>
    ///   <para>rdfs:label : Region^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#region_IfcPostalAddress">ifc:region_IfcPostalAddress</a>
    /// </summary>
    let region_IfcPostalAddress = _prefixId.prefix "region_IfcPostalAddress"

    /// <summary>
    ///   <para>rdfs:label : ReinforcementRole^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#reinforcementRole_IfcSectionReinforcementProperties">ifc:reinforcementRole_IfcSectionReinforcementProperties</a>
    /// </summary>
    let reinforcementRole_IfcSectionReinforcementProperties = _prefixId.prefix "reinforcementRole_IfcSectionReinforcementProperties"

    /// <summary>
    ///   <para>rdfs:label : ReinforcementSectionDefinitions^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#reinforcementSectionDefinitions_IfcReinforcementDefinitionProperties">ifc:reinforcementSectionDefinitions_IfcReinforcementDefinitionProperties</a>
    /// </summary>
    let reinforcementSectionDefinitions_IfcReinforcementDefinitionProperties = _prefixId.prefix "reinforcementSectionDefinitions_IfcReinforcementDefinitionProperties"

    /// <summary>
    ///   <para>rdfs:label : RelatedApprovals^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedApprovals_IfcApprovalRelationship">ifc:relatedApprovals_IfcApprovalRelationship</a>
    /// </summary>
    let relatedApprovals_IfcApprovalRelationship = _prefixId.prefix "relatedApprovals_IfcApprovalRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatedBuildingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedBuildingElement_IfcRelFillsElement">ifc:relatedBuildingElement_IfcRelFillsElement</a>
    /// </summary>
    let relatedBuildingElement_IfcRelFillsElement = _prefixId.prefix "relatedBuildingElement_IfcRelFillsElement"

    /// <summary>
    ///   <para>rdfs:label : RelatedBuildingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedBuildingElement_IfcRelSpaceBoundary">ifc:relatedBuildingElement_IfcRelSpaceBoundary</a>
    /// </summary>
    let relatedBuildingElement_IfcRelSpaceBoundary = _prefixId.prefix "relatedBuildingElement_IfcRelSpaceBoundary"

    /// <summary>
    ///   <para>rdfs:label : RelatedBuildings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedBuildings_IfcRelServicesBuildings">ifc:relatedBuildings_IfcRelServicesBuildings</a>
    /// </summary>
    let relatedBuildings_IfcRelServicesBuildings = _prefixId.prefix "relatedBuildings_IfcRelServicesBuildings"

    /// <summary>
    ///   <para>rdfs:label : RelatedConnectionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedConnectionType_IfcRelConnectsPathElements">ifc:relatedConnectionType_IfcRelConnectsPathElements</a>
    /// </summary>
    let relatedConnectionType_IfcRelConnectsPathElements = _prefixId.prefix "relatedConnectionType_IfcRelConnectsPathElements"

    /// <summary>
    ///   <para>rdfs:label : RelatedControlElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedControlElements_IfcRelFlowControlElements">ifc:relatedControlElements_IfcRelFlowControlElements</a>
    /// </summary>
    let relatedControlElements_IfcRelFlowControlElements = _prefixId.prefix "relatedControlElements_IfcRelFlowControlElements"

    /// <summary>
    ///   <para>rdfs:label : RelatedCoverings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedCoverings_IfcRelCoversBldgElements">ifc:relatedCoverings_IfcRelCoversBldgElements</a>
    /// </summary>
    let relatedCoverings_IfcRelCoversBldgElements = _prefixId.prefix "relatedCoverings_IfcRelCoversBldgElements"

    /// <summary>
    ///   <para>rdfs:label : RelatedCoverings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedCoverings_IfcRelCoversSpaces">ifc:relatedCoverings_IfcRelCoversSpaces</a>
    /// </summary>
    let relatedCoverings_IfcRelCoversSpaces = _prefixId.prefix "relatedCoverings_IfcRelCoversSpaces"

    /// <summary>
    ///   <para>rdfs:label : RelatedDefinitions^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedDefinitions_IfcRelDeclares">ifc:relatedDefinitions_IfcRelDeclares</a>
    /// </summary>
    let relatedDefinitions_IfcRelDeclares = _prefixId.prefix "relatedDefinitions_IfcRelDeclares"

    /// <summary>
    ///   <para>rdfs:label : RelatedDocuments^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedDocuments_IfcDocumentInformationRelationship">ifc:relatedDocuments_IfcDocumentInformationRelationship</a>
    /// </summary>
    let relatedDocuments_IfcDocumentInformationRelationship = _prefixId.prefix "relatedDocuments_IfcDocumentInformationRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatedElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedElement_IfcRelConnectsElements">ifc:relatedElement_IfcRelConnectsElements</a>
    /// </summary>
    let relatedElement_IfcRelConnectsElements = _prefixId.prefix "relatedElement_IfcRelConnectsElements"

    /// <summary>
    ///   <para>rdfs:label : RelatedElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedElement_IfcRelConnectsPortToElement">ifc:relatedElement_IfcRelConnectsPortToElement</a>
    /// </summary>
    let relatedElement_IfcRelConnectsPortToElement = _prefixId.prefix "relatedElement_IfcRelConnectsPortToElement"

    /// <summary>
    ///   <para>rdfs:label : RelatedElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedElement_IfcRelInterferesElements">ifc:relatedElement_IfcRelInterferesElements</a>
    /// </summary>
    let relatedElement_IfcRelInterferesElements = _prefixId.prefix "relatedElement_IfcRelInterferesElements"

    /// <summary>
    ///   <para>rdfs:label : RelatedElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedElements_IfcRelContainedInSpatialStructure">ifc:relatedElements_IfcRelContainedInSpatialStructure</a>
    /// </summary>
    let relatedElements_IfcRelContainedInSpatialStructure = _prefixId.prefix "relatedElements_IfcRelContainedInSpatialStructure"

    /// <summary>
    ///   <para>rdfs:label : RelatedElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedElements_IfcRelReferencedInSpatialStructure">ifc:relatedElements_IfcRelReferencedInSpatialStructure</a>
    /// </summary>
    let relatedElements_IfcRelReferencedInSpatialStructure = _prefixId.prefix "relatedElements_IfcRelReferencedInSpatialStructure"

    /// <summary>
    ///   <para>rdfs:label : RelatedFeatureElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedFeatureElement_IfcRelProjectsElement">ifc:relatedFeatureElement_IfcRelProjectsElement</a>
    /// </summary>
    let relatedFeatureElement_IfcRelProjectsElement = _prefixId.prefix "relatedFeatureElement_IfcRelProjectsElement"

    /// <summary>
    ///   <para>rdfs:label : RelatedMaterials^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedMaterials_IfcMaterialRelationship">ifc:relatedMaterials_IfcMaterialRelationship</a>
    /// </summary>
    let relatedMaterials_IfcMaterialRelationship = _prefixId.prefix "relatedMaterials_IfcMaterialRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatedMonetaryUnit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedMonetaryUnit_IfcCurrencyRelationship">ifc:relatedMonetaryUnit_IfcCurrencyRelationship</a>
    /// </summary>
    let relatedMonetaryUnit_IfcCurrencyRelationship = _prefixId.prefix "relatedMonetaryUnit_IfcCurrencyRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatedObjectsType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedObjectsType_IfcRelAssigns">ifc:relatedObjectsType_IfcRelAssigns</a>
    /// </summary>
    let relatedObjectsType_IfcRelAssigns = _prefixId.prefix "relatedObjectsType_IfcRelAssigns"

    /// <summary>
    ///   <para>rdfs:label : RelatedObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedObjects_IfcRelAggregates">ifc:relatedObjects_IfcRelAggregates</a>
    /// </summary>
    let relatedObjects_IfcRelAggregates = _prefixId.prefix "relatedObjects_IfcRelAggregates"

    /// <summary>
    ///   <para>rdfs:label : RelatedObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedObjects_IfcRelAssigns">ifc:relatedObjects_IfcRelAssigns</a>
    /// </summary>
    let relatedObjects_IfcRelAssigns = _prefixId.prefix "relatedObjects_IfcRelAssigns"

    /// <summary>
    ///   <para>rdfs:label : RelatedObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedObjects_IfcRelAssociates">ifc:relatedObjects_IfcRelAssociates</a>
    /// </summary>
    let relatedObjects_IfcRelAssociates = _prefixId.prefix "relatedObjects_IfcRelAssociates"

    /// <summary>
    ///   <para>rdfs:label : RelatedObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedObjects_IfcRelDefinesByObject">ifc:relatedObjects_IfcRelDefinesByObject</a>
    /// </summary>
    let relatedObjects_IfcRelDefinesByObject = _prefixId.prefix "relatedObjects_IfcRelDefinesByObject"

    /// <summary>
    ///   <para>rdfs:label : RelatedObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedObjects_IfcRelDefinesByProperties">ifc:relatedObjects_IfcRelDefinesByProperties</a>
    /// </summary>
    let relatedObjects_IfcRelDefinesByProperties = _prefixId.prefix "relatedObjects_IfcRelDefinesByProperties"

    /// <summary>
    ///   <para>rdfs:label : RelatedObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedObjects_IfcRelDefinesByType">ifc:relatedObjects_IfcRelDefinesByType</a>
    /// </summary>
    let relatedObjects_IfcRelDefinesByType = _prefixId.prefix "relatedObjects_IfcRelDefinesByType"

    /// <summary>
    ///   <para>rdfs:label : RelatedObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedObjects_IfcRelNests">ifc:relatedObjects_IfcRelNests</a>
    /// </summary>
    let relatedObjects_IfcRelNests = _prefixId.prefix "relatedObjects_IfcRelNests"

    /// <summary>
    ///   <para>rdfs:label : RelatedOpeningElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedOpeningElement_IfcRelVoidsElement">ifc:relatedOpeningElement_IfcRelVoidsElement</a>
    /// </summary>
    let relatedOpeningElement_IfcRelVoidsElement = _prefixId.prefix "relatedOpeningElement_IfcRelVoidsElement"

    /// <summary>
    ///   <para>rdfs:label : RelatedOrganizations^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedOrganizations_IfcOrganizationRelationship">ifc:relatedOrganizations_IfcOrganizationRelationship</a>
    /// </summary>
    let relatedOrganizations_IfcOrganizationRelationship = _prefixId.prefix "relatedOrganizations_IfcOrganizationRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatedPort^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedPort_IfcRelConnectsPorts">ifc:relatedPort_IfcRelConnectsPorts</a>
    /// </summary>
    let relatedPort_IfcRelConnectsPorts = _prefixId.prefix "relatedPort_IfcRelConnectsPorts"

    /// <summary>
    ///   <para>rdfs:label : RelatedPriorities^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedPriorities_IfcRelConnectsPathElements">ifc:relatedPriorities_IfcRelConnectsPathElements</a>
    /// </summary>
    let relatedPriorities_IfcRelConnectsPathElements = _prefixId.prefix "relatedPriorities_IfcRelConnectsPathElements"

    /// <summary>
    ///   <para>rdfs:label : RelatedProcess^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedProcess_IfcRelSequence">ifc:relatedProcess_IfcRelSequence</a>
    /// </summary>
    let relatedProcess_IfcRelSequence = _prefixId.prefix "relatedProcess_IfcRelSequence"

    /// <summary>
    ///   <para>rdfs:label : RelatedPropertySets^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedPropertySets_IfcRelDefinesByTemplate">ifc:relatedPropertySets_IfcRelDefinesByTemplate</a>
    /// </summary>
    let relatedPropertySets_IfcRelDefinesByTemplate = _prefixId.prefix "relatedPropertySets_IfcRelDefinesByTemplate"

    /// <summary>
    ///   <para>rdfs:label : RelatedResourceObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedResourceObjects_IfcExternalReferenceRelationship">ifc:relatedResourceObjects_IfcExternalReferenceRelationship</a>
    /// </summary>
    let relatedResourceObjects_IfcExternalReferenceRelationship = _prefixId.prefix "relatedResourceObjects_IfcExternalReferenceRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatedResourceObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedResourceObjects_IfcResourceApprovalRelationship">ifc:relatedResourceObjects_IfcResourceApprovalRelationship</a>
    /// </summary>
    let relatedResourceObjects_IfcResourceApprovalRelationship = _prefixId.prefix "relatedResourceObjects_IfcResourceApprovalRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatedResourceObjects^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedResourceObjects_IfcResourceConstraintRelationship">ifc:relatedResourceObjects_IfcResourceConstraintRelationship</a>
    /// </summary>
    let relatedResourceObjects_IfcResourceConstraintRelationship = _prefixId.prefix "relatedResourceObjects_IfcResourceConstraintRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatedStructuralActivity^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedStructuralActivity_IfcRelConnectsStructuralActivity">ifc:relatedStructuralActivity_IfcRelConnectsStructuralActivity</a>
    /// </summary>
    let relatedStructuralActivity_IfcRelConnectsStructuralActivity = _prefixId.prefix "relatedStructuralActivity_IfcRelConnectsStructuralActivity"

    /// <summary>
    ///   <para>rdfs:label : RelatedStructuralConnection^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatedStructuralConnection_IfcRelConnectsStructuralMember">ifc:relatedStructuralConnection_IfcRelConnectsStructuralMember</a>
    /// </summary>
    let relatedStructuralConnection_IfcRelConnectsStructuralMember = _prefixId.prefix "relatedStructuralConnection_IfcRelConnectsStructuralMember"

    /// <summary>
    ///   <para>rdfs:label : RelatesTo^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatesTo_IfcMaterial">ifc:relatesTo_IfcMaterial</a>
    /// </summary>
    let relatesTo_IfcMaterial = _prefixId.prefix "relatesTo_IfcMaterial"
    /// <summary>
    ///   <para>rdfs:label : Relates^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relates_IfcApproval">ifc:relates_IfcApproval</a>
    /// </summary>
    let relates_IfcApproval = _prefixId.prefix "relates_IfcApproval"
    /// <summary>
    ///   <para>rdfs:label : Relates^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relates_IfcOrganization">ifc:relates_IfcOrganization</a>
    /// </summary>
    let relates_IfcOrganization = _prefixId.prefix "relates_IfcOrganization"

    /// <summary>
    ///   <para>rdfs:label : RelatingActor^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingActor_IfcRelAssignsToActor">ifc:relatingActor_IfcRelAssignsToActor</a>
    /// </summary>
    let relatingActor_IfcRelAssignsToActor = _prefixId.prefix "relatingActor_IfcRelAssignsToActor"

    /// <summary>
    ///   <para>rdfs:label : RelatingApproval^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingApproval_IfcApprovalRelationship">ifc:relatingApproval_IfcApprovalRelationship</a>
    /// </summary>
    let relatingApproval_IfcApprovalRelationship = _prefixId.prefix "relatingApproval_IfcApprovalRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatingApproval^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingApproval_IfcRelAssociatesApproval">ifc:relatingApproval_IfcRelAssociatesApproval</a>
    /// </summary>
    let relatingApproval_IfcRelAssociatesApproval = _prefixId.prefix "relatingApproval_IfcRelAssociatesApproval"

    /// <summary>
    ///   <para>rdfs:label : RelatingApproval^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingApproval_IfcResourceApprovalRelationship">ifc:relatingApproval_IfcResourceApprovalRelationship</a>
    /// </summary>
    let relatingApproval_IfcResourceApprovalRelationship = _prefixId.prefix "relatingApproval_IfcResourceApprovalRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatingBuildingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingBuildingElement_IfcRelCoversBldgElements">ifc:relatingBuildingElement_IfcRelCoversBldgElements</a>
    /// </summary>
    let relatingBuildingElement_IfcRelCoversBldgElements = _prefixId.prefix "relatingBuildingElement_IfcRelCoversBldgElements"

    /// <summary>
    ///   <para>rdfs:label : RelatingBuildingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingBuildingElement_IfcRelVoidsElement">ifc:relatingBuildingElement_IfcRelVoidsElement</a>
    /// </summary>
    let relatingBuildingElement_IfcRelVoidsElement = _prefixId.prefix "relatingBuildingElement_IfcRelVoidsElement"

    /// <summary>
    ///   <para>rdfs:label : RelatingClassification^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingClassification_IfcRelAssociatesClassification">ifc:relatingClassification_IfcRelAssociatesClassification</a>
    /// </summary>
    let relatingClassification_IfcRelAssociatesClassification = _prefixId.prefix "relatingClassification_IfcRelAssociatesClassification"

    /// <summary>
    ///   <para>rdfs:label : RelatingConnectionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingConnectionType_IfcRelConnectsPathElements">ifc:relatingConnectionType_IfcRelConnectsPathElements</a>
    /// </summary>
    let relatingConnectionType_IfcRelConnectsPathElements = _prefixId.prefix "relatingConnectionType_IfcRelConnectsPathElements"

    /// <summary>
    ///   <para>rdfs:label : RelatingConstraint^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingConstraint_IfcRelAssociatesConstraint">ifc:relatingConstraint_IfcRelAssociatesConstraint</a>
    /// </summary>
    let relatingConstraint_IfcRelAssociatesConstraint = _prefixId.prefix "relatingConstraint_IfcRelAssociatesConstraint"

    /// <summary>
    ///   <para>rdfs:label : RelatingConstraint^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingConstraint_IfcResourceConstraintRelationship">ifc:relatingConstraint_IfcResourceConstraintRelationship</a>
    /// </summary>
    let relatingConstraint_IfcResourceConstraintRelationship = _prefixId.prefix "relatingConstraint_IfcResourceConstraintRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatingContext^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingContext_IfcRelDeclares">ifc:relatingContext_IfcRelDeclares</a>
    /// </summary>
    let relatingContext_IfcRelDeclares = _prefixId.prefix "relatingContext_IfcRelDeclares"

    /// <summary>
    ///   <para>rdfs:label : RelatingControl^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingControl_IfcRelAssignsToControl">ifc:relatingControl_IfcRelAssignsToControl</a>
    /// </summary>
    let relatingControl_IfcRelAssignsToControl = _prefixId.prefix "relatingControl_IfcRelAssignsToControl"

    /// <summary>
    ///   <para>rdfs:label : RelatingDocument^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingDocument_IfcDocumentInformationRelationship">ifc:relatingDocument_IfcDocumentInformationRelationship</a>
    /// </summary>
    let relatingDocument_IfcDocumentInformationRelationship = _prefixId.prefix "relatingDocument_IfcDocumentInformationRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatingDocument^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingDocument_IfcRelAssociatesDocument">ifc:relatingDocument_IfcRelAssociatesDocument</a>
    /// </summary>
    let relatingDocument_IfcRelAssociatesDocument = _prefixId.prefix "relatingDocument_IfcRelAssociatesDocument"

    /// <summary>
    ///   <para>rdfs:label : RelatingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingElement_IfcRelConnectsElements">ifc:relatingElement_IfcRelConnectsElements</a>
    /// </summary>
    let relatingElement_IfcRelConnectsElements = _prefixId.prefix "relatingElement_IfcRelConnectsElements"

    /// <summary>
    ///   <para>rdfs:label : RelatingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingElement_IfcRelConnectsStructuralActivity">ifc:relatingElement_IfcRelConnectsStructuralActivity</a>
    /// </summary>
    let relatingElement_IfcRelConnectsStructuralActivity = _prefixId.prefix "relatingElement_IfcRelConnectsStructuralActivity"

    /// <summary>
    ///   <para>rdfs:label : RelatingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingElement_IfcRelInterferesElements">ifc:relatingElement_IfcRelInterferesElements</a>
    /// </summary>
    let relatingElement_IfcRelInterferesElements = _prefixId.prefix "relatingElement_IfcRelInterferesElements"

    /// <summary>
    ///   <para>rdfs:label : RelatingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingElement_IfcRelProjectsElement">ifc:relatingElement_IfcRelProjectsElement</a>
    /// </summary>
    let relatingElement_IfcRelProjectsElement = _prefixId.prefix "relatingElement_IfcRelProjectsElement"

    /// <summary>
    ///   <para>rdfs:label : RelatingFlowElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingFlowElement_IfcRelFlowControlElements">ifc:relatingFlowElement_IfcRelFlowControlElements</a>
    /// </summary>
    let relatingFlowElement_IfcRelFlowControlElements = _prefixId.prefix "relatingFlowElement_IfcRelFlowControlElements"

    /// <summary>
    ///   <para>rdfs:label : RelatingGroup^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingGroup_IfcRelAssignsToGroup">ifc:relatingGroup_IfcRelAssignsToGroup</a>
    /// </summary>
    let relatingGroup_IfcRelAssignsToGroup = _prefixId.prefix "relatingGroup_IfcRelAssignsToGroup"

    /// <summary>
    ///   <para>rdfs:label : RelatingLibrary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingLibrary_IfcRelAssociatesLibrary">ifc:relatingLibrary_IfcRelAssociatesLibrary</a>
    /// </summary>
    let relatingLibrary_IfcRelAssociatesLibrary = _prefixId.prefix "relatingLibrary_IfcRelAssociatesLibrary"

    /// <summary>
    ///   <para>rdfs:label : RelatingMaterial^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingMaterial_IfcMaterialRelationship">ifc:relatingMaterial_IfcMaterialRelationship</a>
    /// </summary>
    let relatingMaterial_IfcMaterialRelationship = _prefixId.prefix "relatingMaterial_IfcMaterialRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatingMaterial^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingMaterial_IfcRelAssociatesMaterial">ifc:relatingMaterial_IfcRelAssociatesMaterial</a>
    /// </summary>
    let relatingMaterial_IfcRelAssociatesMaterial = _prefixId.prefix "relatingMaterial_IfcRelAssociatesMaterial"

    /// <summary>
    ///   <para>rdfs:label : RelatingMonetaryUnit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingMonetaryUnit_IfcCurrencyRelationship">ifc:relatingMonetaryUnit_IfcCurrencyRelationship</a>
    /// </summary>
    let relatingMonetaryUnit_IfcCurrencyRelationship = _prefixId.prefix "relatingMonetaryUnit_IfcCurrencyRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatingObject^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingObject_IfcRelAggregates">ifc:relatingObject_IfcRelAggregates</a>
    /// </summary>
    let relatingObject_IfcRelAggregates = _prefixId.prefix "relatingObject_IfcRelAggregates"

    /// <summary>
    ///   <para>rdfs:label : RelatingObject^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingObject_IfcRelDefinesByObject">ifc:relatingObject_IfcRelDefinesByObject</a>
    /// </summary>
    let relatingObject_IfcRelDefinesByObject = _prefixId.prefix "relatingObject_IfcRelDefinesByObject"

    /// <summary>
    ///   <para>rdfs:label : RelatingObject^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingObject_IfcRelNests">ifc:relatingObject_IfcRelNests</a>
    /// </summary>
    let relatingObject_IfcRelNests = _prefixId.prefix "relatingObject_IfcRelNests"

    /// <summary>
    ///   <para>rdfs:label : RelatingOpeningElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingOpeningElement_IfcRelFillsElement">ifc:relatingOpeningElement_IfcRelFillsElement</a>
    /// </summary>
    let relatingOpeningElement_IfcRelFillsElement = _prefixId.prefix "relatingOpeningElement_IfcRelFillsElement"

    /// <summary>
    ///   <para>rdfs:label : RelatingOrganization^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingOrganization_IfcOrganizationRelationship">ifc:relatingOrganization_IfcOrganizationRelationship</a>
    /// </summary>
    let relatingOrganization_IfcOrganizationRelationship = _prefixId.prefix "relatingOrganization_IfcOrganizationRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatingPort^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingPort_IfcRelConnectsPortToElement">ifc:relatingPort_IfcRelConnectsPortToElement</a>
    /// </summary>
    let relatingPort_IfcRelConnectsPortToElement = _prefixId.prefix "relatingPort_IfcRelConnectsPortToElement"

    /// <summary>
    ///   <para>rdfs:label : RelatingPort^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingPort_IfcRelConnectsPorts">ifc:relatingPort_IfcRelConnectsPorts</a>
    /// </summary>
    let relatingPort_IfcRelConnectsPorts = _prefixId.prefix "relatingPort_IfcRelConnectsPorts"

    /// <summary>
    ///   <para>rdfs:label : RelatingPriorities^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingPriorities_IfcRelConnectsPathElements">ifc:relatingPriorities_IfcRelConnectsPathElements</a>
    /// </summary>
    let relatingPriorities_IfcRelConnectsPathElements = _prefixId.prefix "relatingPriorities_IfcRelConnectsPathElements"

    /// <summary>
    ///   <para>rdfs:label : RelatingProcess^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingProcess_IfcRelAssignsToProcess">ifc:relatingProcess_IfcRelAssignsToProcess</a>
    /// </summary>
    let relatingProcess_IfcRelAssignsToProcess = _prefixId.prefix "relatingProcess_IfcRelAssignsToProcess"

    /// <summary>
    ///   <para>rdfs:label : RelatingProcess^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingProcess_IfcRelSequence">ifc:relatingProcess_IfcRelSequence</a>
    /// </summary>
    let relatingProcess_IfcRelSequence = _prefixId.prefix "relatingProcess_IfcRelSequence"

    /// <summary>
    ///   <para>rdfs:label : RelatingProduct^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingProduct_IfcRelAssignsToProduct">ifc:relatingProduct_IfcRelAssignsToProduct</a>
    /// </summary>
    let relatingProduct_IfcRelAssignsToProduct = _prefixId.prefix "relatingProduct_IfcRelAssignsToProduct"

    /// <summary>
    ///   <para>rdfs:label : RelatingPropertyDefinition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingPropertyDefinition_IfcRelDefinesByProperties">ifc:relatingPropertyDefinition_IfcRelDefinesByProperties</a>
    /// </summary>
    let relatingPropertyDefinition_IfcRelDefinesByProperties = _prefixId.prefix "relatingPropertyDefinition_IfcRelDefinesByProperties"

    /// <summary>
    ///   <para>rdfs:label : RelatingReference^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingReference_IfcExternalReferenceRelationship">ifc:relatingReference_IfcExternalReferenceRelationship</a>
    /// </summary>
    let relatingReference_IfcExternalReferenceRelationship = _prefixId.prefix "relatingReference_IfcExternalReferenceRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelatingResource^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingResource_IfcRelAssignsToResource">ifc:relatingResource_IfcRelAssignsToResource</a>
    /// </summary>
    let relatingResource_IfcRelAssignsToResource = _prefixId.prefix "relatingResource_IfcRelAssignsToResource"

    /// <summary>
    ///   <para>rdfs:label : RelatingSpace^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingSpace_IfcRelCoversSpaces">ifc:relatingSpace_IfcRelCoversSpaces</a>
    /// </summary>
    let relatingSpace_IfcRelCoversSpaces = _prefixId.prefix "relatingSpace_IfcRelCoversSpaces"

    /// <summary>
    ///   <para>rdfs:label : RelatingSpace^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingSpace_IfcRelSpaceBoundary">ifc:relatingSpace_IfcRelSpaceBoundary</a>
    /// </summary>
    let relatingSpace_IfcRelSpaceBoundary = _prefixId.prefix "relatingSpace_IfcRelSpaceBoundary"

    /// <summary>
    ///   <para>rdfs:label : RelatingStructuralMember^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingStructuralMember_IfcRelConnectsStructuralMember">ifc:relatingStructuralMember_IfcRelConnectsStructuralMember</a>
    /// </summary>
    let relatingStructuralMember_IfcRelConnectsStructuralMember = _prefixId.prefix "relatingStructuralMember_IfcRelConnectsStructuralMember"

    /// <summary>
    ///   <para>rdfs:label : RelatingStructure^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingStructure_IfcRelContainedInSpatialStructure">ifc:relatingStructure_IfcRelContainedInSpatialStructure</a>
    /// </summary>
    let relatingStructure_IfcRelContainedInSpatialStructure = _prefixId.prefix "relatingStructure_IfcRelContainedInSpatialStructure"

    /// <summary>
    ///   <para>rdfs:label : RelatingStructure^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingStructure_IfcRelReferencedInSpatialStructure">ifc:relatingStructure_IfcRelReferencedInSpatialStructure</a>
    /// </summary>
    let relatingStructure_IfcRelReferencedInSpatialStructure = _prefixId.prefix "relatingStructure_IfcRelReferencedInSpatialStructure"

    /// <summary>
    ///   <para>rdfs:label : RelatingSystem^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingSystem_IfcRelServicesBuildings">ifc:relatingSystem_IfcRelServicesBuildings</a>
    /// </summary>
    let relatingSystem_IfcRelServicesBuildings = _prefixId.prefix "relatingSystem_IfcRelServicesBuildings"

    /// <summary>
    ///   <para>rdfs:label : RelatingTemplate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingTemplate_IfcRelDefinesByTemplate">ifc:relatingTemplate_IfcRelDefinesByTemplate</a>
    /// </summary>
    let relatingTemplate_IfcRelDefinesByTemplate = _prefixId.prefix "relatingTemplate_IfcRelDefinesByTemplate"

    /// <summary>
    ///   <para>rdfs:label : RelatingType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relatingType_IfcRelDefinesByType">ifc:relatingType_IfcRelDefinesByType</a>
    /// </summary>
    let relatingType_IfcRelDefinesByType = _prefixId.prefix "relatingType_IfcRelDefinesByType"

    /// <summary>
    ///   <para>rdfs:label : RelationshipType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relationshipType_IfcDocumentInformationRelationship">ifc:relationshipType_IfcDocumentInformationRelationship</a>
    /// </summary>
    let relationshipType_IfcDocumentInformationRelationship = _prefixId.prefix "relationshipType_IfcDocumentInformationRelationship"

    /// <summary>
    ///   <para>rdfs:label : RelativePlacement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#relativePlacement_IfcLocalPlacement">ifc:relativePlacement_IfcLocalPlacement</a>
    /// </summary>
    let relativePlacement_IfcLocalPlacement = _prefixId.prefix "relativePlacement_IfcLocalPlacement"

    /// <summary>
    ///   <para>rdfs:label : RemainingTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#remainingTime_IfcTaskTime">ifc:remainingTime_IfcTaskTime</a>
    /// </summary>
    let remainingTime_IfcTaskTime = _prefixId.prefix "remainingTime_IfcTaskTime"

    /// <summary>
    ///   <para>rdfs:label : RemainingUsage^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#remainingUsage_IfcResourceTime">ifc:remainingUsage_IfcResourceTime</a>
    /// </summary>
    let remainingUsage_IfcResourceTime = _prefixId.prefix "remainingUsage_IfcResourceTime"

    /// <summary>
    ///   <para>rdfs:label : RemainingWork^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#remainingWork_IfcResourceTime">ifc:remainingWork_IfcResourceTime</a>
    /// </summary>
    let remainingWork_IfcResourceTime = _prefixId.prefix "remainingWork_IfcResourceTime"
    /// <summary>
    ///   <para>rdfs:label : RepeatS^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#repeatS_IfcSurfaceTexture">ifc:repeatS_IfcSurfaceTexture</a>
    /// </summary>
    let repeatS_IfcSurfaceTexture = _prefixId.prefix "repeatS_IfcSurfaceTexture"
    /// <summary>
    ///   <para>rdfs:label : RepeatT^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#repeatT_IfcSurfaceTexture">ifc:repeatT_IfcSurfaceTexture</a>
    /// </summary>
    let repeatT_IfcSurfaceTexture = _prefixId.prefix "repeatT_IfcSurfaceTexture"

    /// <summary>
    ///   <para>rdfs:label : RepresentationContexts^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#representationContexts_IfcContext">ifc:representationContexts_IfcContext</a>
    /// </summary>
    let representationContexts_IfcContext = _prefixId.prefix "representationContexts_IfcContext"

    /// <summary>
    ///   <para>rdfs:label : RepresentationIdentifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#representationIdentifier_IfcRepresentation">ifc:representationIdentifier_IfcRepresentation</a>
    /// </summary>
    let representationIdentifier_IfcRepresentation = _prefixId.prefix "representationIdentifier_IfcRepresentation"

    /// <summary>
    ///   <para>rdfs:label : RepresentationMap^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#representationMap_IfcRepresentation">ifc:representationMap_IfcRepresentation</a>
    /// </summary>
    let representationMap_IfcRepresentation = _prefixId.prefix "representationMap_IfcRepresentation"

    /// <summary>
    ///   <para>rdfs:label : RepresentationMaps^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#representationMaps_IfcTypeProduct">ifc:representationMaps_IfcTypeProduct</a>
    /// </summary>
    let representationMaps_IfcTypeProduct = _prefixId.prefix "representationMaps_IfcTypeProduct"

    /// <summary>
    ///   <para>rdfs:label : RepresentationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#representationType_IfcRepresentation">ifc:representationType_IfcRepresentation</a>
    /// </summary>
    let representationType_IfcRepresentation = _prefixId.prefix "representationType_IfcRepresentation"

    /// <summary>
    ///   <para>rdfs:label : Representation^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#representation_IfcProduct">ifc:representation_IfcProduct</a>
    /// </summary>
    let representation_IfcProduct = _prefixId.prefix "representation_IfcProduct"

    /// <summary>
    ///   <para>rdfs:label : RepresentationsInContext^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#representationsInContext_IfcRepresentationContext">ifc:representationsInContext_IfcRepresentationContext</a>
    /// </summary>
    let representationsInContext_IfcRepresentationContext = _prefixId.prefix "representationsInContext_IfcRepresentationContext"

    /// <summary>
    ///   <para>rdfs:label : Representations^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#representations_IfcProductRepresentation">ifc:representations_IfcProductRepresentation</a>
    /// </summary>
    let representations_IfcProductRepresentation = _prefixId.prefix "representations_IfcProductRepresentation"

    /// <summary>
    ///   <para>rdfs:label : RepresentedMaterial^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#representedMaterial_IfcMaterialDefinitionRepresentation">ifc:representedMaterial_IfcMaterialDefinitionRepresentation</a>
    /// </summary>
    let representedMaterial_IfcMaterialDefinitionRepresentation = _prefixId.prefix "representedMaterial_IfcMaterialDefinitionRepresentation"

    /// <summary>
    ///   <para>rdfs:label : RequestingApproval^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#requestingApproval_IfcApproval">ifc:requestingApproval_IfcApproval</a>
    /// </summary>
    let requestingApproval_IfcApproval = _prefixId.prefix "requestingApproval_IfcApproval"

    /// <summary>
    ///   <para>rdfs:label : ResourceType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#resourceType_IfcTypeResource">ifc:resourceType_IfcTypeResource</a>
    /// </summary>
    let resourceType_IfcTypeResource = _prefixId.prefix "resourceType_IfcTypeResource"
    /// <summary>
    ///   <para>rdfs:label : ResponsiblePerson^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#responsiblePerson_IfcAsset">ifc:responsiblePerson_IfcAsset</a>
    /// </summary>
    let responsiblePerson_IfcAsset = _prefixId.prefix "responsiblePerson_IfcAsset"

    /// <summary>
    ///   <para>rdfs:label : ResponsiblePersons^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#responsiblePersons_IfcInventory">ifc:responsiblePersons_IfcInventory</a>
    /// </summary>
    let responsiblePersons_IfcInventory = _prefixId.prefix "responsiblePersons_IfcInventory"

    /// <summary>
    ///   <para>rdfs:label : ResultForLoadGroup^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#resultForLoadGroup_IfcStructuralResultGroup">ifc:resultForLoadGroup_IfcStructuralResultGroup</a>
    /// </summary>
    let resultForLoadGroup_IfcStructuralResultGroup = _prefixId.prefix "resultForLoadGroup_IfcStructuralResultGroup"

    /// <summary>
    ///   <para>rdfs:label : ResultGroupFor^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#resultGroupFor_IfcStructuralResultGroup">ifc:resultGroupFor_IfcStructuralResultGroup</a>
    /// </summary>
    let resultGroupFor_IfcStructuralResultGroup = _prefixId.prefix "resultGroupFor_IfcStructuralResultGroup"

    /// <summary>
    ///   <para>rdfs:label : Revision^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#revision_IfcDocumentInformation">ifc:revision_IfcDocumentInformation</a>
    /// </summary>
    let revision_IfcDocumentInformation = _prefixId.prefix "revision_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : RiserHeight^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#riserHeight_IfcStairFlight">ifc:riserHeight_IfcStairFlight</a>
    /// </summary>
    let riserHeight_IfcStairFlight = _prefixId.prefix "riserHeight_IfcStairFlight"
    /// <summary>
    ///   <para>rdfs:label : Role^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#role_IfcActorRole">ifc:role_IfcActorRole</a>
    /// </summary>
    let role_IfcActorRole = _prefixId.prefix "role_IfcActorRole"
    /// <summary>
    ///   <para>rdfs:label : Roles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#roles_IfcOrganization">ifc:roles_IfcOrganization</a>
    /// </summary>
    let roles_IfcOrganization = _prefixId.prefix "roles_IfcOrganization"
    /// <summary>
    ///   <para>rdfs:label : Roles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#roles_IfcPerson">ifc:roles_IfcPerson</a>
    /// </summary>
    let roles_IfcPerson = _prefixId.prefix "roles_IfcPerson"

    /// <summary>
    ///   <para>rdfs:label : Roles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#roles_IfcPersonAndOrganization">ifc:roles_IfcPersonAndOrganization</a>
    /// </summary>
    let roles_IfcPersonAndOrganization = _prefixId.prefix "roles_IfcPersonAndOrganization"

    /// <summary>
    ///   <para>rdfs:label : RotationalDisplacementRX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rotationalDisplacementRX_IfcStructuralLoadSingleDisplacement">ifc:rotationalDisplacementRX_IfcStructuralLoadSingleDisplacement</a>
    /// </summary>
    let rotationalDisplacementRX_IfcStructuralLoadSingleDisplacement = _prefixId.prefix "rotationalDisplacementRX_IfcStructuralLoadSingleDisplacement"

    /// <summary>
    ///   <para>rdfs:label : RotationalDisplacementRY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rotationalDisplacementRY_IfcStructuralLoadSingleDisplacement">ifc:rotationalDisplacementRY_IfcStructuralLoadSingleDisplacement</a>
    /// </summary>
    let rotationalDisplacementRY_IfcStructuralLoadSingleDisplacement = _prefixId.prefix "rotationalDisplacementRY_IfcStructuralLoadSingleDisplacement"

    /// <summary>
    ///   <para>rdfs:label : RotationalDisplacementRZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rotationalDisplacementRZ_IfcStructuralLoadSingleDisplacement">ifc:rotationalDisplacementRZ_IfcStructuralLoadSingleDisplacement</a>
    /// </summary>
    let rotationalDisplacementRZ_IfcStructuralLoadSingleDisplacement = _prefixId.prefix "rotationalDisplacementRZ_IfcStructuralLoadSingleDisplacement"

    /// <summary>
    ///   <para>rdfs:label : RotationalStiffnessByLengthX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rotationalStiffnessByLengthX_IfcBoundaryEdgeCondition">ifc:rotationalStiffnessByLengthX_IfcBoundaryEdgeCondition</a>
    /// </summary>
    let rotationalStiffnessByLengthX_IfcBoundaryEdgeCondition = _prefixId.prefix "rotationalStiffnessByLengthX_IfcBoundaryEdgeCondition"

    /// <summary>
    ///   <para>rdfs:label : RotationalStiffnessByLengthY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rotationalStiffnessByLengthY_IfcBoundaryEdgeCondition">ifc:rotationalStiffnessByLengthY_IfcBoundaryEdgeCondition</a>
    /// </summary>
    let rotationalStiffnessByLengthY_IfcBoundaryEdgeCondition = _prefixId.prefix "rotationalStiffnessByLengthY_IfcBoundaryEdgeCondition"

    /// <summary>
    ///   <para>rdfs:label : RotationalStiffnessByLengthZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rotationalStiffnessByLengthZ_IfcBoundaryEdgeCondition">ifc:rotationalStiffnessByLengthZ_IfcBoundaryEdgeCondition</a>
    /// </summary>
    let rotationalStiffnessByLengthZ_IfcBoundaryEdgeCondition = _prefixId.prefix "rotationalStiffnessByLengthZ_IfcBoundaryEdgeCondition"

    /// <summary>
    ///   <para>rdfs:label : RotationalStiffnessX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rotationalStiffnessX_IfcBoundaryNodeCondition">ifc:rotationalStiffnessX_IfcBoundaryNodeCondition</a>
    /// </summary>
    let rotationalStiffnessX_IfcBoundaryNodeCondition = _prefixId.prefix "rotationalStiffnessX_IfcBoundaryNodeCondition"

    /// <summary>
    ///   <para>rdfs:label : RotationalStiffnessY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rotationalStiffnessY_IfcBoundaryNodeCondition">ifc:rotationalStiffnessY_IfcBoundaryNodeCondition</a>
    /// </summary>
    let rotationalStiffnessY_IfcBoundaryNodeCondition = _prefixId.prefix "rotationalStiffnessY_IfcBoundaryNodeCondition"

    /// <summary>
    ///   <para>rdfs:label : RotationalStiffnessZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rotationalStiffnessZ_IfcBoundaryNodeCondition">ifc:rotationalStiffnessZ_IfcBoundaryNodeCondition</a>
    /// </summary>
    let rotationalStiffnessZ_IfcBoundaryNodeCondition = _prefixId.prefix "rotationalStiffnessZ_IfcBoundaryNodeCondition"

    /// <summary>
    ///   <para>rdfs:label : RoundingRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#roundingRadius_IfcRoundedRectangleProfileDef">ifc:roundingRadius_IfcRoundedRectangleProfileDef</a>
    /// </summary>
    let roundingRadius_IfcRoundedRectangleProfileDef = _prefixId.prefix "roundingRadius_IfcRoundedRectangleProfileDef"

    /// <summary>
    ///   <para>rdfs:label : RowCells^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rowCells_IfcTableRow">ifc:rowCells_IfcTableRow</a>
    /// </summary>
    let rowCells_IfcTableRow = _prefixId.prefix "rowCells_IfcTableRow"
    /// <summary>
    ///   <para>rdfs:label : Rows^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#rows_IfcTable">ifc:rows_IfcTable</a>
    /// </summary>
    let rows_IfcTable = _prefixId.prefix "rows_IfcTable"

    /// <summary>
    ///   <para>rdfs:label : SameSense^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sameSense_IfcCompositeCurveSegment">ifc:sameSense_IfcCompositeCurveSegment</a>
    /// </summary>
    let sameSense_IfcCompositeCurveSegment = _prefixId.prefix "sameSense_IfcCompositeCurveSegment"

    /// <summary>
    ///   <para>rdfs:label : SameSense^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sameSense_IfcEdgeCurve">ifc:sameSense_IfcEdgeCurve</a>
    /// </summary>
    let sameSense_IfcEdgeCurve = _prefixId.prefix "sameSense_IfcEdgeCurve"
    /// <summary>
    ///   <para>rdfs:label : SameSense^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sameSense_IfcFaceSurface">ifc:sameSense_IfcFaceSurface</a>
    /// </summary>
    let sameSense_IfcFaceSurface = _prefixId.prefix "sameSense_IfcFaceSurface"
    /// <summary>
    ///   <para>rdfs:label : SameSense^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sameSense_IfcGridAxis">ifc:sameSense_IfcGridAxis</a>
    /// </summary>
    let sameSense_IfcGridAxis = _prefixId.prefix "sameSense_IfcGridAxis"

    /// <summary>
    ///   <para>rdfs:label : SbsmBoundary^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sbsmBoundary_IfcShellBasedSurfaceModel">ifc:sbsmBoundary_IfcShellBasedSurfaceModel</a>
    /// </summary>
    let sbsmBoundary_IfcShellBasedSurfaceModel = _prefixId.prefix "sbsmBoundary_IfcShellBasedSurfaceModel"

    /// <summary>
    ///   <para>rdfs:label : Scale2^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scale2_IfcCartesianTransformationOperator2DnonUniform">ifc:scale2_IfcCartesianTransformationOperator2DnonUniform</a>
    /// </summary>
    let scale2_IfcCartesianTransformationOperator2DnonUniform = _prefixId.prefix "scale2_IfcCartesianTransformationOperator2DnonUniform"

    /// <summary>
    ///   <para>rdfs:label : Scale2^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scale2_IfcCartesianTransformationOperator3DnonUniform">ifc:scale2_IfcCartesianTransformationOperator3DnonUniform</a>
    /// </summary>
    let scale2_IfcCartesianTransformationOperator3DnonUniform = _prefixId.prefix "scale2_IfcCartesianTransformationOperator3DnonUniform"

    /// <summary>
    ///   <para>rdfs:label : Scale3^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scale3_IfcCartesianTransformationOperator3DnonUniform">ifc:scale3_IfcCartesianTransformationOperator3DnonUniform</a>
    /// </summary>
    let scale3_IfcCartesianTransformationOperator3DnonUniform = _prefixId.prefix "scale3_IfcCartesianTransformationOperator3DnonUniform"

    /// <summary>
    ///   <para>rdfs:label : Scale^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scale_IfcCartesianTransformationOperator">ifc:scale_IfcCartesianTransformationOperator</a>
    /// </summary>
    let scale_IfcCartesianTransformationOperator = _prefixId.prefix "scale_IfcCartesianTransformationOperator"

    /// <summary>
    ///   <para>rdfs:label : Scale^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scale_IfcMapConversion">ifc:scale_IfcMapConversion</a>
    /// </summary>
    let scale_IfcMapConversion = _prefixId.prefix "scale_IfcMapConversion"

    /// <summary>
    ///   <para>rdfs:label : ScheduleContour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scheduleContour_IfcResourceTime">ifc:scheduleContour_IfcResourceTime</a>
    /// </summary>
    let scheduleContour_IfcResourceTime = _prefixId.prefix "scheduleContour_IfcResourceTime"

    /// <summary>
    ///   <para>rdfs:label : ScheduleDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scheduleDate_IfcEventTime">ifc:scheduleDate_IfcEventTime</a>
    /// </summary>
    let scheduleDate_IfcEventTime = _prefixId.prefix "scheduleDate_IfcEventTime"
    /// <summary>
    ///   <para>rdfs:label : ScheduleDuration^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scheduleDuration_IfcTaskTime">ifc:scheduleDuration_IfcTaskTime</a>
    /// </summary>
    let scheduleDuration_IfcTaskTime = _prefixId.prefix "scheduleDuration_IfcTaskTime"

    /// <summary>
    ///   <para>rdfs:label : ScheduleFinish^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scheduleFinish_IfcResourceTime">ifc:scheduleFinish_IfcResourceTime</a>
    /// </summary>
    let scheduleFinish_IfcResourceTime = _prefixId.prefix "scheduleFinish_IfcResourceTime"

    /// <summary>
    ///   <para>rdfs:label : ScheduleFinish^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scheduleFinish_IfcTaskTime">ifc:scheduleFinish_IfcTaskTime</a>
    /// </summary>
    let scheduleFinish_IfcTaskTime = _prefixId.prefix "scheduleFinish_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : ScheduleStart^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scheduleStart_IfcResourceTime">ifc:scheduleStart_IfcResourceTime</a>
    /// </summary>
    let scheduleStart_IfcResourceTime = _prefixId.prefix "scheduleStart_IfcResourceTime"
    /// <summary>
    ///   <para>rdfs:label : ScheduleStart^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scheduleStart_IfcTaskTime">ifc:scheduleStart_IfcTaskTime</a>
    /// </summary>
    let scheduleStart_IfcTaskTime = _prefixId.prefix "scheduleStart_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : ScheduleUsage^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scheduleUsage_IfcResourceTime">ifc:scheduleUsage_IfcResourceTime</a>
    /// </summary>
    let scheduleUsage_IfcResourceTime = _prefixId.prefix "scheduleUsage_IfcResourceTime"
    /// <summary>
    ///   <para>rdfs:label : ScheduleWork^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scheduleWork_IfcResourceTime">ifc:scheduleWork_IfcResourceTime</a>
    /// </summary>
    let scheduleWork_IfcResourceTime = _prefixId.prefix "scheduleWork_IfcResourceTime"
    /// <summary>
    ///   <para>rdfs:label : Scope^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#scope_IfcDocumentInformation">ifc:scope_IfcDocumentInformation</a>
    /// </summary>
    let scope_IfcDocumentInformation = _prefixId.prefix "scope_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : SecondMullionOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#secondMullionOffset_IfcWindowLiningProperties">ifc:secondMullionOffset_IfcWindowLiningProperties</a>
    /// </summary>
    let secondMullionOffset_IfcWindowLiningProperties = _prefixId.prefix "secondMullionOffset_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : SecondOperand^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#secondOperand_IfcBooleanResult">ifc:secondOperand_IfcBooleanResult</a>
    /// </summary>
    let secondOperand_IfcBooleanResult = _prefixId.prefix "secondOperand_IfcBooleanResult"

    /// <summary>
    ///   <para>rdfs:label : SecondTransomOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#secondTransomOffset_IfcWindowLiningProperties">ifc:secondTransomOffset_IfcWindowLiningProperties</a>
    /// </summary>
    let secondTransomOffset_IfcWindowLiningProperties = _prefixId.prefix "secondTransomOffset_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : SecondaryMeasureType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#secondaryMeasureType_IfcSimplePropertyTemplate">ifc:secondaryMeasureType_IfcSimplePropertyTemplate</a>
    /// </summary>
    let secondaryMeasureType_IfcSimplePropertyTemplate = _prefixId.prefix "secondaryMeasureType_IfcSimplePropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : SecondaryPlaneAngle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#secondaryPlaneAngle_IfcLightDistributionData">ifc:secondaryPlaneAngle_IfcLightDistributionData</a>
    /// </summary>
    let secondaryPlaneAngle_IfcLightDistributionData = _prefixId.prefix "secondaryPlaneAngle_IfcLightDistributionData"

    /// <summary>
    ///   <para>rdfs:label : SecondaryUnit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#secondaryUnit_IfcSimplePropertyTemplate">ifc:secondaryUnit_IfcSimplePropertyTemplate</a>
    /// </summary>
    let secondaryUnit_IfcSimplePropertyTemplate = _prefixId.prefix "secondaryUnit_IfcSimplePropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : SectionDefinition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sectionDefinition_IfcSectionReinforcementProperties">ifc:sectionDefinition_IfcSectionReinforcementProperties</a>
    /// </summary>
    let sectionDefinition_IfcSectionReinforcementProperties = _prefixId.prefix "sectionDefinition_IfcSectionReinforcementProperties"

    /// <summary>
    ///   <para>rdfs:label : SectionType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sectionType_IfcSectionProperties">ifc:sectionType_IfcSectionProperties</a>
    /// </summary>
    let sectionType_IfcSectionProperties = _prefixId.prefix "sectionType_IfcSectionProperties"

    /// <summary>
    ///   <para>rdfs:label : Segments^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#segments_IfcCompositeCurve">ifc:segments_IfcCompositeCurve</a>
    /// </summary>
    let segments_IfcCompositeCurve = _prefixId.prefix "segments_IfcCompositeCurve"
    /// <summary>
    ///   <para>rdfs:label : Segments^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#segments_IfcIndexedPolyCurve">ifc:segments_IfcIndexedPolyCurve</a>
    /// </summary>
    let segments_IfcIndexedPolyCurve = _prefixId.prefix "segments_IfcIndexedPolyCurve"
    /// <summary>
    ///   <para>rdfs:label : SelfIntersect^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#selfIntersect_IfcBSplineCurve">ifc:selfIntersect_IfcBSplineCurve</a>
    /// </summary>
    let selfIntersect_IfcBSplineCurve = _prefixId.prefix "selfIntersect_IfcBSplineCurve"

    /// <summary>
    ///   <para>rdfs:label : SelfIntersect^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#selfIntersect_IfcBSplineSurface">ifc:selfIntersect_IfcBSplineSurface</a>
    /// </summary>
    let selfIntersect_IfcBSplineSurface = _prefixId.prefix "selfIntersect_IfcBSplineSurface"

    /// <summary>
    ///   <para>rdfs:label : SelfIntersect^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#selfIntersect_IfcCompositeCurve">ifc:selfIntersect_IfcCompositeCurve</a>
    /// </summary>
    let selfIntersect_IfcCompositeCurve = _prefixId.prefix "selfIntersect_IfcCompositeCurve"

    /// <summary>
    ///   <para>rdfs:label : SelfIntersect^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#selfIntersect_IfcIndexedPolyCurve">ifc:selfIntersect_IfcIndexedPolyCurve</a>
    /// </summary>
    let selfIntersect_IfcIndexedPolyCurve = _prefixId.prefix "selfIntersect_IfcIndexedPolyCurve"

    /// <summary>
    ///   <para>rdfs:label : SelfIntersect^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#selfIntersect_IfcOffsetCurve2D">ifc:selfIntersect_IfcOffsetCurve2D</a>
    /// </summary>
    let selfIntersect_IfcOffsetCurve2D = _prefixId.prefix "selfIntersect_IfcOffsetCurve2D"

    /// <summary>
    ///   <para>rdfs:label : SelfIntersect^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#selfIntersect_IfcOffsetCurve3D">ifc:selfIntersect_IfcOffsetCurve3D</a>
    /// </summary>
    let selfIntersect_IfcOffsetCurve3D = _prefixId.prefix "selfIntersect_IfcOffsetCurve3D"

    /// <summary>
    ///   <para>rdfs:label : SelfWeightCoefficients^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#selfWeightCoefficients_IfcStructuralLoadCase">ifc:selfWeightCoefficients_IfcStructuralLoadCase</a>
    /// </summary>
    let selfWeightCoefficients_IfcStructuralLoadCase = _prefixId.prefix "selfWeightCoefficients_IfcStructuralLoadCase"

    /// <summary>
    ///   <para>rdfs:label : SemiAxis1^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#semiAxis1_IfcEllipse">ifc:semiAxis1_IfcEllipse</a>
    /// </summary>
    let semiAxis1_IfcEllipse = _prefixId.prefix "semiAxis1_IfcEllipse"

    /// <summary>
    ///   <para>rdfs:label : SemiAxis1^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#semiAxis1_IfcEllipseProfileDef">ifc:semiAxis1_IfcEllipseProfileDef</a>
    /// </summary>
    let semiAxis1_IfcEllipseProfileDef = _prefixId.prefix "semiAxis1_IfcEllipseProfileDef"

    /// <summary>
    ///   <para>rdfs:label : SemiAxis2^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#semiAxis2_IfcEllipse">ifc:semiAxis2_IfcEllipse</a>
    /// </summary>
    let semiAxis2_IfcEllipse = _prefixId.prefix "semiAxis2_IfcEllipse"

    /// <summary>
    ///   <para>rdfs:label : SemiAxis2^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#semiAxis2_IfcEllipseProfileDef">ifc:semiAxis2_IfcEllipseProfileDef</a>
    /// </summary>
    let semiAxis2_IfcEllipseProfileDef = _prefixId.prefix "semiAxis2_IfcEllipseProfileDef"

    /// <summary>
    ///   <para>rdfs:label : SenseAgreement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#senseAgreement_IfcTrimmedCurve">ifc:senseAgreement_IfcTrimmedCurve</a>
    /// </summary>
    let senseAgreement_IfcTrimmedCurve = _prefixId.prefix "senseAgreement_IfcTrimmedCurve"

    /// <summary>
    ///   <para>rdfs:label : SequenceType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sequenceType_IfcRelSequence">ifc:sequenceType_IfcRelSequence</a>
    /// </summary>
    let sequenceType_IfcRelSequence = _prefixId.prefix "sequenceType_IfcRelSequence"

    /// <summary>
    ///   <para>rdfs:label : ServicedBySystems^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#servicedBySystems_IfcSpatialElement">ifc:servicedBySystems_IfcSpatialElement</a>
    /// </summary>
    let servicedBySystems_IfcSpatialElement = _prefixId.prefix "servicedBySystems_IfcSpatialElement"

    /// <summary>
    ///   <para>rdfs:label : ServicesBuildings^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#servicesBuildings_IfcSystem">ifc:servicesBuildings_IfcSystem</a>
    /// </summary>
    let servicesBuildings_IfcSystem = _prefixId.prefix "servicesBuildings_IfcSystem"

    /// <summary>
    ///   <para>rdfs:label : SetPointValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#setPointValue_IfcPropertyBoundedValue">ifc:setPointValue_IfcPropertyBoundedValue</a>
    /// </summary>
    let setPointValue_IfcPropertyBoundedValue = _prefixId.prefix "setPointValue_IfcPropertyBoundedValue"

    /// <summary>
    ///   <para>rdfs:label : ShapeAspectStyle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#shapeAspectStyle_IfcDoorLiningProperties">ifc:shapeAspectStyle_IfcDoorLiningProperties</a>
    /// </summary>
    let shapeAspectStyle_IfcDoorLiningProperties = _prefixId.prefix "shapeAspectStyle_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : ShapeAspectStyle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#shapeAspectStyle_IfcDoorPanelProperties">ifc:shapeAspectStyle_IfcDoorPanelProperties</a>
    /// </summary>
    let shapeAspectStyle_IfcDoorPanelProperties = _prefixId.prefix "shapeAspectStyle_IfcDoorPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : ShapeAspectStyle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#shapeAspectStyle_IfcPermeableCoveringProperties">ifc:shapeAspectStyle_IfcPermeableCoveringProperties</a>
    /// </summary>
    let shapeAspectStyle_IfcPermeableCoveringProperties = _prefixId.prefix "shapeAspectStyle_IfcPermeableCoveringProperties"

    /// <summary>
    ///   <para>rdfs:label : ShapeAspectStyle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#shapeAspectStyle_IfcWindowLiningProperties">ifc:shapeAspectStyle_IfcWindowLiningProperties</a>
    /// </summary>
    let shapeAspectStyle_IfcWindowLiningProperties = _prefixId.prefix "shapeAspectStyle_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : ShapeAspectStyle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#shapeAspectStyle_IfcWindowPanelProperties">ifc:shapeAspectStyle_IfcWindowPanelProperties</a>
    /// </summary>
    let shapeAspectStyle_IfcWindowPanelProperties = _prefixId.prefix "shapeAspectStyle_IfcWindowPanelProperties"

    /// <summary>
    ///   <para>rdfs:label : ShapeOfProduct^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#shapeOfProduct_IfcProductDefinitionShape">ifc:shapeOfProduct_IfcProductDefinitionShape</a>
    /// </summary>
    let shapeOfProduct_IfcProductDefinitionShape = _prefixId.prefix "shapeOfProduct_IfcProductDefinitionShape"

    /// <summary>
    ///   <para>rdfs:label : ShapeRepresentations^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#shapeRepresentations_IfcShapeAspect">ifc:shapeRepresentations_IfcShapeAspect</a>
    /// </summary>
    let shapeRepresentations_IfcShapeAspect = _prefixId.prefix "shapeRepresentations_IfcShapeAspect"

    /// <summary>
    ///   <para>rdfs:label : SharedPlacement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sharedPlacement_IfcStructuralAnalysisModel">ifc:sharedPlacement_IfcStructuralAnalysisModel</a>
    /// </summary>
    let sharedPlacement_IfcStructuralAnalysisModel = _prefixId.prefix "sharedPlacement_IfcStructuralAnalysisModel"

    /// <summary>
    ///   <para>rdfs:label : ShearReinforcement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#shearReinforcement_IfcSurfaceReinforcementArea">ifc:shearReinforcement_IfcSurfaceReinforcementArea</a>
    /// </summary>
    let shearReinforcement_IfcSurfaceReinforcementArea = _prefixId.prefix "shearReinforcement_IfcSurfaceReinforcementArea"

    /// <summary>
    ///   <para>rdfs:label : SheethDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sheethDiameter_IfcTendonType">ifc:sheethDiameter_IfcTendonType</a>
    /// </summary>
    let sheethDiameter_IfcTendonType = _prefixId.prefix "sheethDiameter_IfcTendonType"
    /// <summary>
    ///   <para>rdfs:label : Side^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#side_IfcSurfaceStyle">ifc:side_IfcSurfaceStyle</a>
    /// </summary>
    let side_IfcSurfaceStyle = _prefixId.prefix "side_IfcSurfaceStyle"
    /// <summary>
    ///   <para>rdfs:label : SiteAddress^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#siteAddress_IfcSite">ifc:siteAddress_IfcSite</a>
    /// </summary>
    let siteAddress_IfcSite = _prefixId.prefix "siteAddress_IfcSite"
    /// <summary>
    ///   <para>rdfs:label : SizeInX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sizeInX_IfcPlanarExtent">ifc:sizeInX_IfcPlanarExtent</a>
    /// </summary>
    let sizeInX_IfcPlanarExtent = _prefixId.prefix "sizeInX_IfcPlanarExtent"
    /// <summary>
    ///   <para>rdfs:label : SizeInY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sizeInY_IfcPlanarExtent">ifc:sizeInY_IfcPlanarExtent</a>
    /// </summary>
    let sizeInY_IfcPlanarExtent = _prefixId.prefix "sizeInY_IfcPlanarExtent"
    /// <summary>
    ///   <para>rdfs:label : Sizeable^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sizeable_IfcDoorStyle">ifc:sizeable_IfcDoorStyle</a>
    /// </summary>
    let sizeable_IfcDoorStyle = _prefixId.prefix "sizeable_IfcDoorStyle"
    /// <summary>
    ///   <para>rdfs:label : Sizeable^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sizeable_IfcWindowStyle">ifc:sizeable_IfcWindowStyle</a>
    /// </summary>
    let sizeable_IfcWindowStyle = _prefixId.prefix "sizeable_IfcWindowStyle"

    /// <summary>
    ///   <para>rdfs:label : SlippageX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#slippageX_IfcSlippageConnectionCondition">ifc:slippageX_IfcSlippageConnectionCondition</a>
    /// </summary>
    let slippageX_IfcSlippageConnectionCondition = _prefixId.prefix "slippageX_IfcSlippageConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : SlippageY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#slippageY_IfcSlippageConnectionCondition">ifc:slippageY_IfcSlippageConnectionCondition</a>
    /// </summary>
    let slippageY_IfcSlippageConnectionCondition = _prefixId.prefix "slippageY_IfcSlippageConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : SlippageZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#slippageZ_IfcSlippageConnectionCondition">ifc:slippageZ_IfcSlippageConnectionCondition</a>
    /// </summary>
    let slippageZ_IfcSlippageConnectionCondition = _prefixId.prefix "slippageZ_IfcSlippageConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : Sort^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sort_IfcClassificationReference">ifc:sort_IfcClassificationReference</a>
    /// </summary>
    let sort_IfcClassificationReference = _prefixId.prefix "sort_IfcClassificationReference"

    /// <summary>
    ///   <para>rdfs:label : SourceCRS^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sourceCRS_IfcCoordinateOperation">ifc:sourceCRS_IfcCoordinateOperation</a>
    /// </summary>
    let sourceCRS_IfcCoordinateOperation = _prefixId.prefix "sourceCRS_IfcCoordinateOperation"

    /// <summary>
    ///   <para>rdfs:label : SourceOfResultGroup^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sourceOfResultGroup_IfcStructuralLoadGroup">ifc:sourceOfResultGroup_IfcStructuralLoadGroup</a>
    /// </summary>
    let sourceOfResultGroup_IfcStructuralLoadGroup = _prefixId.prefix "sourceOfResultGroup_IfcStructuralLoadGroup"

    /// <summary>
    ///   <para>rdfs:label : Source^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#source_IfcClassification">ifc:source_IfcClassification</a>
    /// </summary>
    let source_IfcClassification = _prefixId.prefix "source_IfcClassification"

    /// <summary>
    ///   <para>rdfs:label : SpecularColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#specularColour_IfcSurfaceStyleRendering">ifc:specularColour_IfcSurfaceStyleRendering</a>
    /// </summary>
    let specularColour_IfcSurfaceStyleRendering = _prefixId.prefix "specularColour_IfcSurfaceStyleRendering"

    /// <summary>
    ///   <para>rdfs:label : SpecularHighlight^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#specularHighlight_IfcSurfaceStyleRendering">ifc:specularHighlight_IfcSurfaceStyleRendering</a>
    /// </summary>
    let specularHighlight_IfcSurfaceStyleRendering = _prefixId.prefix "specularHighlight_IfcSurfaceStyleRendering"

    /// <summary>
    ///   <para>rdfs:label : SpineCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#spineCurve_IfcSectionedSpine">ifc:spineCurve_IfcSectionedSpine</a>
    /// </summary>
    let spineCurve_IfcSectionedSpine = _prefixId.prefix "spineCurve_IfcSectionedSpine"

    /// <summary>
    ///   <para>rdfs:label : SpreadAngle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#spreadAngle_IfcLightSourceSpot">ifc:spreadAngle_IfcLightSourceSpot</a>
    /// </summary>
    let spreadAngle_IfcLightSourceSpot = _prefixId.prefix "spreadAngle_IfcLightSourceSpot"

    /// <summary>
    ///   <para>rdfs:label : StartOfNextHatchLine^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#startOfNextHatchLine_IfcFillAreaStyleHatching">ifc:startOfNextHatchLine_IfcFillAreaStyleHatching</a>
    /// </summary>
    let startOfNextHatchLine_IfcFillAreaStyleHatching = _prefixId.prefix "startOfNextHatchLine_IfcFillAreaStyleHatching"

    /// <summary>
    ///   <para>rdfs:label : StartParam^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#startParam_IfcFixedReferenceSweptAreaSolid">ifc:startParam_IfcFixedReferenceSweptAreaSolid</a>
    /// </summary>
    let startParam_IfcFixedReferenceSweptAreaSolid = _prefixId.prefix "startParam_IfcFixedReferenceSweptAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : StartParam^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#startParam_IfcSurfaceCurveSweptAreaSolid">ifc:startParam_IfcSurfaceCurveSweptAreaSolid</a>
    /// </summary>
    let startParam_IfcSurfaceCurveSweptAreaSolid = _prefixId.prefix "startParam_IfcSurfaceCurveSweptAreaSolid"

    /// <summary>
    ///   <para>rdfs:label : StartParam^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#startParam_IfcSweptDiskSolid">ifc:startParam_IfcSweptDiskSolid</a>
    /// </summary>
    let startParam_IfcSweptDiskSolid = _prefixId.prefix "startParam_IfcSweptDiskSolid"

    /// <summary>
    ///   <para>rdfs:label : StartProfile^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#startProfile_IfcSectionProperties">ifc:startProfile_IfcSectionProperties</a>
    /// </summary>
    let startProfile_IfcSectionProperties = _prefixId.prefix "startProfile_IfcSectionProperties"

    /// <summary>
    ///   <para>rdfs:label : StartTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#startTime_IfcTimePeriod">ifc:startTime_IfcTimePeriod</a>
    /// </summary>
    let startTime_IfcTimePeriod = _prefixId.prefix "startTime_IfcTimePeriod"
    /// <summary>
    ///   <para>rdfs:label : StartTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#startTime_IfcTimeSeries">ifc:startTime_IfcTimeSeries</a>
    /// </summary>
    let startTime_IfcTimeSeries = _prefixId.prefix "startTime_IfcTimeSeries"
    /// <summary>
    ///   <para>rdfs:label : StartTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#startTime_IfcWorkControl">ifc:startTime_IfcWorkControl</a>
    /// </summary>
    let startTime_IfcWorkControl = _prefixId.prefix "startTime_IfcWorkControl"
    /// <summary>
    ///   <para>rdfs:label : Start^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#start_IfcWorkTime">ifc:start_IfcWorkTime</a>
    /// </summary>
    let start_IfcWorkTime = _prefixId.prefix "start_IfcWorkTime"
    /// <summary>
    ///   <para>rdfs:label : State^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#state_IfcOwnerHistory">ifc:state_IfcOwnerHistory</a>
    /// </summary>
    let state_IfcOwnerHistory = _prefixId.prefix "state_IfcOwnerHistory"
    /// <summary>
    ///   <para>rdfs:label : StatusTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#statusTime_IfcResourceTime">ifc:statusTime_IfcResourceTime</a>
    /// </summary>
    let statusTime_IfcResourceTime = _prefixId.prefix "statusTime_IfcResourceTime"
    /// <summary>
    ///   <para>rdfs:label : StatusTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#statusTime_IfcTaskTime">ifc:statusTime_IfcTaskTime</a>
    /// </summary>
    let statusTime_IfcTaskTime = _prefixId.prefix "statusTime_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#status_IfcActionRequest">ifc:status_IfcActionRequest</a>
    /// </summary>
    let status_IfcActionRequest = _prefixId.prefix "status_IfcActionRequest"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#status_IfcApproval">ifc:status_IfcApproval</a>
    /// </summary>
    let status_IfcApproval = _prefixId.prefix "status_IfcApproval"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#status_IfcCostSchedule">ifc:status_IfcCostSchedule</a>
    /// </summary>
    let status_IfcCostSchedule = _prefixId.prefix "status_IfcCostSchedule"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#status_IfcDocumentInformation">ifc:status_IfcDocumentInformation</a>
    /// </summary>
    let status_IfcDocumentInformation = _prefixId.prefix "status_IfcDocumentInformation"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#status_IfcPermit">ifc:status_IfcPermit</a>
    /// </summary>
    let status_IfcPermit = _prefixId.prefix "status_IfcPermit"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#status_IfcProjectOrder">ifc:status_IfcProjectOrder</a>
    /// </summary>
    let status_IfcProjectOrder = _prefixId.prefix "status_IfcProjectOrder"
    /// <summary>
    ///   <para>rdfs:label : Status^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#status_IfcTask">ifc:status_IfcTask</a>
    /// </summary>
    let status_IfcTask = _prefixId.prefix "status_IfcTask"

    /// <summary>
    ///   <para>rdfs:label : SteelGrade^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#steelGrade_IfcReinforcementBarProperties">ifc:steelGrade_IfcReinforcementBarProperties</a>
    /// </summary>
    let steelGrade_IfcReinforcementBarProperties = _prefixId.prefix "steelGrade_IfcReinforcementBarProperties"

    /// <summary>
    ///   <para>rdfs:label : SteelGrade^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#steelGrade_IfcReinforcingElement">ifc:steelGrade_IfcReinforcingElement</a>
    /// </summary>
    let steelGrade_IfcReinforcingElement = _prefixId.prefix "steelGrade_IfcReinforcingElement"

    /// <summary>
    ///   <para>rdfs:label : StyledByItem^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#styledByItem_IfcRepresentationItem">ifc:styledByItem_IfcRepresentationItem</a>
    /// </summary>
    let styledByItem_IfcRepresentationItem = _prefixId.prefix "styledByItem_IfcRepresentationItem"

    /// <summary>
    ///   <para>rdfs:label : Styles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#styles_IfcPresentationStyleAssignment">ifc:styles_IfcPresentationStyleAssignment</a>
    /// </summary>
    let styles_IfcPresentationStyleAssignment = _prefixId.prefix "styles_IfcPresentationStyleAssignment"

    /// <summary>
    ///   <para>rdfs:label : Styles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#styles_IfcStyledItem">ifc:styles_IfcStyledItem</a>
    /// </summary>
    let styles_IfcStyledItem = _prefixId.prefix "styles_IfcStyledItem"
    /// <summary>
    ///   <para>rdfs:label : Styles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#styles_IfcSurfaceStyle">ifc:styles_IfcSurfaceStyle</a>
    /// </summary>
    let styles_IfcSurfaceStyle = _prefixId.prefix "styles_IfcSurfaceStyle"
    /// <summary>
    ///   <para>rdfs:label : SubmittedOn^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#submittedOn_IfcCostSchedule">ifc:submittedOn_IfcCostSchedule</a>
    /// </summary>
    let submittedOn_IfcCostSchedule = _prefixId.prefix "submittedOn_IfcCostSchedule"
    /// <summary>
    ///   <para>rdfs:label : SuffixTitles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#suffixTitles_IfcPerson">ifc:suffixTitles_IfcPerson</a>
    /// </summary>
    let suffixTitles_IfcPerson = _prefixId.prefix "suffixTitles_IfcPerson"

    /// <summary>
    ///   <para>rdfs:label : SupportedLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#supportedLength_IfcRelConnectsStructuralMember">ifc:supportedLength_IfcRelConnectsStructuralMember</a>
    /// </summary>
    let supportedLength_IfcRelConnectsStructuralMember = _prefixId.prefix "supportedLength_IfcRelConnectsStructuralMember"

    /// <summary>
    ///   <para>rdfs:label : SurfaceColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#surfaceColour_IfcSurfaceStyleShading">ifc:surfaceColour_IfcSurfaceStyleShading</a>
    /// </summary>
    let surfaceColour_IfcSurfaceStyleShading = _prefixId.prefix "surfaceColour_IfcSurfaceStyleShading"

    /// <summary>
    ///   <para>rdfs:label : SurfaceForm^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#surfaceForm_IfcBSplineSurface">ifc:surfaceForm_IfcBSplineSurface</a>
    /// </summary>
    let surfaceForm_IfcBSplineSurface = _prefixId.prefix "surfaceForm_IfcBSplineSurface"

    /// <summary>
    ///   <para>rdfs:label : SurfaceOnRelatedElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#surfaceOnRelatedElement_IfcConnectionSurfaceGeometry">ifc:surfaceOnRelatedElement_IfcConnectionSurfaceGeometry</a>
    /// </summary>
    let surfaceOnRelatedElement_IfcConnectionSurfaceGeometry = _prefixId.prefix "surfaceOnRelatedElement_IfcConnectionSurfaceGeometry"

    /// <summary>
    ///   <para>rdfs:label : SurfaceOnRelatingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#surfaceOnRelatingElement_IfcConnectionSurfaceGeometry">ifc:surfaceOnRelatingElement_IfcConnectionSurfaceGeometry</a>
    /// </summary>
    let surfaceOnRelatingElement_IfcConnectionSurfaceGeometry = _prefixId.prefix "surfaceOnRelatingElement_IfcConnectionSurfaceGeometry"

    /// <summary>
    ///   <para>rdfs:label : SurfaceReinforcement1^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#surfaceReinforcement1_IfcSurfaceReinforcementArea">ifc:surfaceReinforcement1_IfcSurfaceReinforcementArea</a>
    /// </summary>
    let surfaceReinforcement1_IfcSurfaceReinforcementArea = _prefixId.prefix "surfaceReinforcement1_IfcSurfaceReinforcementArea"

    /// <summary>
    ///   <para>rdfs:label : SurfaceReinforcement2^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#surfaceReinforcement2_IfcSurfaceReinforcementArea">ifc:surfaceReinforcement2_IfcSurfaceReinforcementArea</a>
    /// </summary>
    let surfaceReinforcement2_IfcSurfaceReinforcementArea = _prefixId.prefix "surfaceReinforcement2_IfcSurfaceReinforcementArea"

    /// <summary>
    ///   <para>rdfs:label : SweptArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sweptArea_IfcSweptAreaSolid">ifc:sweptArea_IfcSweptAreaSolid</a>
    /// </summary>
    let sweptArea_IfcSweptAreaSolid = _prefixId.prefix "sweptArea_IfcSweptAreaSolid"
    /// <summary>
    ///   <para>rdfs:label : SweptCurve^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#sweptCurve_IfcSweptSurface">ifc:sweptCurve_IfcSweptSurface</a>
    /// </summary>
    let sweptCurve_IfcSweptSurface = _prefixId.prefix "sweptCurve_IfcSweptSurface"

    /// <summary>
    ///   <para>rdfs:label : SystemType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#systemType_IfcDistributionPort">ifc:systemType_IfcDistributionPort</a>
    /// </summary>
    let systemType_IfcDistributionPort = _prefixId.prefix "systemType_IfcDistributionPort"

    /// <summary>
    ///   <para>rdfs:label : Tag^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tag_IfcElement">ifc:tag_IfcElement</a>
    /// </summary>
    let tag_IfcElement = _prefixId.prefix "tag_IfcElement"
    /// <summary>
    ///   <para>rdfs:label : Tag^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tag_IfcProxy">ifc:tag_IfcProxy</a>
    /// </summary>
    let tag_IfcProxy = _prefixId.prefix "tag_IfcProxy"
    /// <summary>
    ///   <para>rdfs:label : Tag^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tag_IfcTypeProduct">ifc:tag_IfcTypeProduct</a>
    /// </summary>
    let tag_IfcTypeProduct = _prefixId.prefix "tag_IfcTypeProduct"

    /// <summary>
    ///   <para>rdfs:label : TargetCRS^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#targetCRS_IfcCoordinateOperation">ifc:targetCRS_IfcCoordinateOperation</a>
    /// </summary>
    let targetCRS_IfcCoordinateOperation = _prefixId.prefix "targetCRS_IfcCoordinateOperation"

    /// <summary>
    ///   <para>rdfs:label : TargetScale^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#targetScale_IfcGeometricRepresentationSubContext">ifc:targetScale_IfcGeometricRepresentationSubContext</a>
    /// </summary>
    let targetScale_IfcGeometricRepresentationSubContext = _prefixId.prefix "targetScale_IfcGeometricRepresentationSubContext"

    /// <summary>
    ///   <para>rdfs:label : TargetView^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#targetView_IfcGeometricRepresentationSubContext">ifc:targetView_IfcGeometricRepresentationSubContext</a>
    /// </summary>
    let targetView_IfcGeometricRepresentationSubContext = _prefixId.prefix "targetView_IfcGeometricRepresentationSubContext"

    /// <summary>
    ///   <para>rdfs:label : TaskTime^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#taskTime_IfcTask">ifc:taskTime_IfcTask</a>
    /// </summary>
    let taskTime_IfcTask = _prefixId.prefix "taskTime_IfcTask"

    /// <summary>
    ///   <para>rdfs:label : TelephoneNumbers^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#telephoneNumbers_IfcTelecomAddress">ifc:telephoneNumbers_IfcTelecomAddress</a>
    /// </summary>
    let telephoneNumbers_IfcTelecomAddress = _prefixId.prefix "telephoneNumbers_IfcTelecomAddress"

    /// <summary>
    ///   <para>rdfs:label : TemplateType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#templateType_IfcComplexPropertyTemplate">ifc:templateType_IfcComplexPropertyTemplate</a>
    /// </summary>
    let templateType_IfcComplexPropertyTemplate = _prefixId.prefix "templateType_IfcComplexPropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : TemplateType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#templateType_IfcPropertySetTemplate">ifc:templateType_IfcPropertySetTemplate</a>
    /// </summary>
    let templateType_IfcPropertySetTemplate = _prefixId.prefix "templateType_IfcPropertySetTemplate"

    /// <summary>
    ///   <para>rdfs:label : TemplateType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#templateType_IfcSimplePropertyTemplate">ifc:templateType_IfcSimplePropertyTemplate</a>
    /// </summary>
    let templateType_IfcSimplePropertyTemplate = _prefixId.prefix "templateType_IfcSimplePropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : TensionFailureX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tensionFailureX_IfcFailureConnectionCondition">ifc:tensionFailureX_IfcFailureConnectionCondition</a>
    /// </summary>
    let tensionFailureX_IfcFailureConnectionCondition = _prefixId.prefix "tensionFailureX_IfcFailureConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : TensionFailureY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tensionFailureY_IfcFailureConnectionCondition">ifc:tensionFailureY_IfcFailureConnectionCondition</a>
    /// </summary>
    let tensionFailureY_IfcFailureConnectionCondition = _prefixId.prefix "tensionFailureY_IfcFailureConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : TensionFailureZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tensionFailureZ_IfcFailureConnectionCondition">ifc:tensionFailureZ_IfcFailureConnectionCondition</a>
    /// </summary>
    let tensionFailureZ_IfcFailureConnectionCondition = _prefixId.prefix "tensionFailureZ_IfcFailureConnectionCondition"

    /// <summary>
    ///   <para>rdfs:label : TensionForce^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tensionForce_IfcTendon">ifc:tensionForce_IfcTendon</a>
    /// </summary>
    let tensionForce_IfcTendon = _prefixId.prefix "tensionForce_IfcTendon"

    /// <summary>
    ///   <para>rdfs:label : TexCoordIndex^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#texCoordIndex_IfcIndexedTriangleTextureMap">ifc:texCoordIndex_IfcIndexedTriangleTextureMap</a>
    /// </summary>
    let texCoordIndex_IfcIndexedTriangleTextureMap = _prefixId.prefix "texCoordIndex_IfcIndexedTriangleTextureMap"

    /// <summary>
    ///   <para>rdfs:label : TexCoordsList^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#texCoordsList_IfcTextureVertexList">ifc:texCoordsList_IfcTextureVertexList</a>
    /// </summary>
    let texCoordsList_IfcTextureVertexList = _prefixId.prefix "texCoordsList_IfcTextureVertexList"

    /// <summary>
    ///   <para>rdfs:label : TexCoords^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#texCoords_IfcIndexedTextureMap">ifc:texCoords_IfcIndexedTextureMap</a>
    /// </summary>
    let texCoords_IfcIndexedTextureMap = _prefixId.prefix "texCoords_IfcIndexedTextureMap"

    /// <summary>
    ///   <para>rdfs:label : TextAlign^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#textAlign_IfcTextStyleTextModel">ifc:textAlign_IfcTextStyleTextModel</a>
    /// </summary>
    let textAlign_IfcTextStyleTextModel = _prefixId.prefix "textAlign_IfcTextStyleTextModel"

    /// <summary>
    ///   <para>rdfs:label : TextCharacterAppearance^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#textCharacterAppearance_IfcTextStyle">ifc:textCharacterAppearance_IfcTextStyle</a>
    /// </summary>
    let textCharacterAppearance_IfcTextStyle = _prefixId.prefix "textCharacterAppearance_IfcTextStyle"

    /// <summary>
    ///   <para>rdfs:label : TextDecoration^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#textDecoration_IfcTextStyleTextModel">ifc:textDecoration_IfcTextStyleTextModel</a>
    /// </summary>
    let textDecoration_IfcTextStyleTextModel = _prefixId.prefix "textDecoration_IfcTextStyleTextModel"

    /// <summary>
    ///   <para>rdfs:label : TextFontStyle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#textFontStyle_IfcTextStyle">ifc:textFontStyle_IfcTextStyle</a>
    /// </summary>
    let textFontStyle_IfcTextStyle = _prefixId.prefix "textFontStyle_IfcTextStyle"

    /// <summary>
    ///   <para>rdfs:label : TextIndent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#textIndent_IfcTextStyleTextModel">ifc:textIndent_IfcTextStyleTextModel</a>
    /// </summary>
    let textIndent_IfcTextStyleTextModel = _prefixId.prefix "textIndent_IfcTextStyleTextModel"

    /// <summary>
    ///   <para>rdfs:label : TextStyle^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#textStyle_IfcTextStyle">ifc:textStyle_IfcTextStyle</a>
    /// </summary>
    let textStyle_IfcTextStyle = _prefixId.prefix "textStyle_IfcTextStyle"

    /// <summary>
    ///   <para>rdfs:label : TextTransform^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#textTransform_IfcTextStyleTextModel">ifc:textTransform_IfcTextStyleTextModel</a>
    /// </summary>
    let textTransform_IfcTextStyleTextModel = _prefixId.prefix "textTransform_IfcTextStyleTextModel"

    /// <summary>
    ///   <para>rdfs:label : TextureTransform^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#textureTransform_IfcSurfaceTexture">ifc:textureTransform_IfcSurfaceTexture</a>
    /// </summary>
    let textureTransform_IfcSurfaceTexture = _prefixId.prefix "textureTransform_IfcSurfaceTexture"

    /// <summary>
    ///   <para>rdfs:label : Textures^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#textures_IfcSurfaceStyleWithTextures">ifc:textures_IfcSurfaceStyleWithTextures</a>
    /// </summary>
    let textures_IfcSurfaceStyleWithTextures = _prefixId.prefix "textures_IfcSurfaceStyleWithTextures"

    /// <summary>
    ///   <para>rdfs:label : TheActor^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#theActor_IfcActor">ifc:theActor_IfcActor</a>
    /// </summary>
    let theActor_IfcActor = _prefixId.prefix "theActor_IfcActor"

    /// <summary>
    ///   <para>rdfs:label : TheOrganization^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#theOrganization_IfcPersonAndOrganization">ifc:theOrganization_IfcPersonAndOrganization</a>
    /// </summary>
    let theOrganization_IfcPersonAndOrganization = _prefixId.prefix "theOrganization_IfcPersonAndOrganization"

    /// <summary>
    ///   <para>rdfs:label : ThePerson^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#thePerson_IfcPersonAndOrganization">ifc:thePerson_IfcPersonAndOrganization</a>
    /// </summary>
    let thePerson_IfcPersonAndOrganization = _prefixId.prefix "thePerson_IfcPersonAndOrganization"

    /// <summary>
    ///   <para>rdfs:label : TheoryType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#theoryType_IfcStructuralResultGroup">ifc:theoryType_IfcStructuralResultGroup</a>
    /// </summary>
    let theoryType_IfcStructuralResultGroup = _prefixId.prefix "theoryType_IfcStructuralResultGroup"

    /// <summary>
    ///   <para>rdfs:label : ThermodynamicTemperatureExponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#thermodynamicTemperatureExponent_IfcDimensionalExponents">ifc:thermodynamicTemperatureExponent_IfcDimensionalExponents</a>
    /// </summary>
    let thermodynamicTemperatureExponent_IfcDimensionalExponents = _prefixId.prefix "thermodynamicTemperatureExponent_IfcDimensionalExponents"

    /// <summary>
    ///   <para>rdfs:label : Thickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#thickness_IfcCenterLineProfileDef">ifc:thickness_IfcCenterLineProfileDef</a>
    /// </summary>
    let thickness_IfcCenterLineProfileDef = _prefixId.prefix "thickness_IfcCenterLineProfileDef"

    /// <summary>
    ///   <para>rdfs:label : Thickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#thickness_IfcLShapeProfileDef">ifc:thickness_IfcLShapeProfileDef</a>
    /// </summary>
    let thickness_IfcLShapeProfileDef = _prefixId.prefix "thickness_IfcLShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : Thickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#thickness_IfcStructuralSurfaceMember">ifc:thickness_IfcStructuralSurfaceMember</a>
    /// </summary>
    let thickness_IfcStructuralSurfaceMember = _prefixId.prefix "thickness_IfcStructuralSurfaceMember"

    /// <summary>
    ///   <para>rdfs:label : ThresholdDepth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#thresholdDepth_IfcDoorLiningProperties">ifc:thresholdDepth_IfcDoorLiningProperties</a>
    /// </summary>
    let thresholdDepth_IfcDoorLiningProperties = _prefixId.prefix "thresholdDepth_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : ThresholdOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#thresholdOffset_IfcDoorLiningProperties">ifc:thresholdOffset_IfcDoorLiningProperties</a>
    /// </summary>
    let thresholdOffset_IfcDoorLiningProperties = _prefixId.prefix "thresholdOffset_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : ThresholdThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#thresholdThickness_IfcDoorLiningProperties">ifc:thresholdThickness_IfcDoorLiningProperties</a>
    /// </summary>
    let thresholdThickness_IfcDoorLiningProperties = _prefixId.prefix "thresholdThickness_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : Tiles^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tiles_IfcFillAreaStyleTiles">ifc:tiles_IfcFillAreaStyleTiles</a>
    /// </summary>
    let tiles_IfcFillAreaStyleTiles = _prefixId.prefix "tiles_IfcFillAreaStyleTiles"

    /// <summary>
    ///   <para>rdfs:label : TilingPattern^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tilingPattern_IfcFillAreaStyleTiles">ifc:tilingPattern_IfcFillAreaStyleTiles</a>
    /// </summary>
    let tilingPattern_IfcFillAreaStyleTiles = _prefixId.prefix "tilingPattern_IfcFillAreaStyleTiles"

    /// <summary>
    ///   <para>rdfs:label : TilingScale^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#tilingScale_IfcFillAreaStyleTiles">ifc:tilingScale_IfcFillAreaStyleTiles</a>
    /// </summary>
    let tilingScale_IfcFillAreaStyleTiles = _prefixId.prefix "tilingScale_IfcFillAreaStyleTiles"

    /// <summary>
    ///   <para>rdfs:label : TimeExponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#timeExponent_IfcDimensionalExponents">ifc:timeExponent_IfcDimensionalExponents</a>
    /// </summary>
    let timeExponent_IfcDimensionalExponents = _prefixId.prefix "timeExponent_IfcDimensionalExponents"

    /// <summary>
    ///   <para>rdfs:label : TimeLag^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#timeLag_IfcRelSequence">ifc:timeLag_IfcRelSequence</a>
    /// </summary>
    let timeLag_IfcRelSequence = _prefixId.prefix "timeLag_IfcRelSequence"
    /// <summary>
    ///   <para>rdfs:label : TimeOfApproval^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#timeOfApproval_IfcApproval">ifc:timeOfApproval_IfcApproval</a>
    /// </summary>
    let timeOfApproval_IfcApproval = _prefixId.prefix "timeOfApproval_IfcApproval"

    /// <summary>
    ///   <para>rdfs:label : TimePeriods^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#timePeriods_IfcRecurrencePattern">ifc:timePeriods_IfcRecurrencePattern</a>
    /// </summary>
    let timePeriods_IfcRecurrencePattern = _prefixId.prefix "timePeriods_IfcRecurrencePattern"

    /// <summary>
    ///   <para>rdfs:label : TimeSeriesDataType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#timeSeriesDataType_IfcTimeSeries">ifc:timeSeriesDataType_IfcTimeSeries</a>
    /// </summary>
    let timeSeriesDataType_IfcTimeSeries = _prefixId.prefix "timeSeriesDataType_IfcTimeSeries"

    /// <summary>
    ///   <para>rdfs:label : TimeStamp^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#timeStamp_IfcIrregularTimeSeriesValue">ifc:timeStamp_IfcIrregularTimeSeriesValue</a>
    /// </summary>
    let timeStamp_IfcIrregularTimeSeriesValue = _prefixId.prefix "timeStamp_IfcIrregularTimeSeriesValue"

    /// <summary>
    ///   <para>rdfs:label : TimeStep^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#timeStep_IfcRegularTimeSeries">ifc:timeStep_IfcRegularTimeSeries</a>
    /// </summary>
    let timeStep_IfcRegularTimeSeries = _prefixId.prefix "timeStep_IfcRegularTimeSeries"
    /// <summary>
    ///   <para>rdfs:label : TimeValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#timeValue_IfcQuantityTime">ifc:timeValue_IfcQuantityTime</a>
    /// </summary>
    let timeValue_IfcQuantityTime = _prefixId.prefix "timeValue_IfcQuantityTime"

    /// <summary>
    ///   <para>rdfs:label : ToMaterialConstituentSet^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#toMaterialConstituentSet_IfcMaterialConstituent">ifc:toMaterialConstituentSet_IfcMaterialConstituent</a>
    /// </summary>
    let toMaterialConstituentSet_IfcMaterialConstituent = _prefixId.prefix "toMaterialConstituentSet_IfcMaterialConstituent"

    /// <summary>
    ///   <para>rdfs:label : TopFlangeEdgeRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#topFlangeEdgeRadius_IfcAsymmetricIShapeProfileDef">ifc:topFlangeEdgeRadius_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let topFlangeEdgeRadius_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "topFlangeEdgeRadius_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : TopFlangeFilletRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#topFlangeFilletRadius_IfcAsymmetricIShapeProfileDef">ifc:topFlangeFilletRadius_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let topFlangeFilletRadius_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "topFlangeFilletRadius_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : TopFlangeSlope^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#topFlangeSlope_IfcAsymmetricIShapeProfileDef">ifc:topFlangeSlope_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let topFlangeSlope_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "topFlangeSlope_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : TopFlangeThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#topFlangeThickness_IfcAsymmetricIShapeProfileDef">ifc:topFlangeThickness_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let topFlangeThickness_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "topFlangeThickness_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : TopFlangeWidth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#topFlangeWidth_IfcAsymmetricIShapeProfileDef">ifc:topFlangeWidth_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let topFlangeWidth_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "topFlangeWidth_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : TopXDim^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#topXDim_IfcTrapeziumProfileDef">ifc:topXDim_IfcTrapeziumProfileDef</a>
    /// </summary>
    let topXDim_IfcTrapeziumProfileDef = _prefixId.prefix "topXDim_IfcTrapeziumProfileDef"

    /// <summary>
    ///   <para>rdfs:label : TopXOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#topXOffset_IfcTrapeziumProfileDef">ifc:topXOffset_IfcTrapeziumProfileDef</a>
    /// </summary>
    let topXOffset_IfcTrapeziumProfileDef = _prefixId.prefix "topXOffset_IfcTrapeziumProfileDef"

    /// <summary>
    ///   <para>rdfs:label : TotalCrossSectionArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#totalCrossSectionArea_IfcReinforcementBarProperties">ifc:totalCrossSectionArea_IfcReinforcementBarProperties</a>
    /// </summary>
    let totalCrossSectionArea_IfcReinforcementBarProperties = _prefixId.prefix "totalCrossSectionArea_IfcReinforcementBarProperties"

    /// <summary>
    ///   <para>rdfs:label : TotalFloat^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#totalFloat_IfcTaskTime">ifc:totalFloat_IfcTaskTime</a>
    /// </summary>
    let totalFloat_IfcTaskTime = _prefixId.prefix "totalFloat_IfcTaskTime"
    /// <summary>
    ///   <para>rdfs:label : TotalFloat^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#totalFloat_IfcWorkControl">ifc:totalFloat_IfcWorkControl</a>
    /// </summary>
    let totalFloat_IfcWorkControl = _prefixId.prefix "totalFloat_IfcWorkControl"
    /// <summary>
    ///   <para>rdfs:label : TotalReplacementCost^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#totalReplacementCost_IfcAsset">ifc:totalReplacementCost_IfcAsset</a>
    /// </summary>
    let totalReplacementCost_IfcAsset = _prefixId.prefix "totalReplacementCost_IfcAsset"
    /// <summary>
    ///   <para>rdfs:label : Town^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#town_IfcPostalAddress">ifc:town_IfcPostalAddress</a>
    /// </summary>
    let town_IfcPostalAddress = _prefixId.prefix "town_IfcPostalAddress"

    /// <summary>
    ///   <para>rdfs:label : Transition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transition_IfcCompositeCurveSegment">ifc:transition_IfcCompositeCurveSegment</a>
    /// </summary>
    let transition_IfcCompositeCurveSegment = _prefixId.prefix "transition_IfcCompositeCurveSegment"

    /// <summary>
    ///   <para>rdfs:label : TranslationalStiffnessByAreaX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#translationalStiffnessByAreaX_IfcBoundaryFaceCondition">ifc:translationalStiffnessByAreaX_IfcBoundaryFaceCondition</a>
    /// </summary>
    let translationalStiffnessByAreaX_IfcBoundaryFaceCondition = _prefixId.prefix "translationalStiffnessByAreaX_IfcBoundaryFaceCondition"

    /// <summary>
    ///   <para>rdfs:label : TranslationalStiffnessByAreaY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#translationalStiffnessByAreaY_IfcBoundaryFaceCondition">ifc:translationalStiffnessByAreaY_IfcBoundaryFaceCondition</a>
    /// </summary>
    let translationalStiffnessByAreaY_IfcBoundaryFaceCondition = _prefixId.prefix "translationalStiffnessByAreaY_IfcBoundaryFaceCondition"

    /// <summary>
    ///   <para>rdfs:label : TranslationalStiffnessByAreaZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#translationalStiffnessByAreaZ_IfcBoundaryFaceCondition">ifc:translationalStiffnessByAreaZ_IfcBoundaryFaceCondition</a>
    /// </summary>
    let translationalStiffnessByAreaZ_IfcBoundaryFaceCondition = _prefixId.prefix "translationalStiffnessByAreaZ_IfcBoundaryFaceCondition"

    /// <summary>
    ///   <para>rdfs:label : TranslationalStiffnessByLengthX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#translationalStiffnessByLengthX_IfcBoundaryEdgeCondition">ifc:translationalStiffnessByLengthX_IfcBoundaryEdgeCondition</a>
    /// </summary>
    let translationalStiffnessByLengthX_IfcBoundaryEdgeCondition = _prefixId.prefix "translationalStiffnessByLengthX_IfcBoundaryEdgeCondition"

    /// <summary>
    ///   <para>rdfs:label : TranslationalStiffnessByLengthY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#translationalStiffnessByLengthY_IfcBoundaryEdgeCondition">ifc:translationalStiffnessByLengthY_IfcBoundaryEdgeCondition</a>
    /// </summary>
    let translationalStiffnessByLengthY_IfcBoundaryEdgeCondition = _prefixId.prefix "translationalStiffnessByLengthY_IfcBoundaryEdgeCondition"

    /// <summary>
    ///   <para>rdfs:label : TranslationalStiffnessByLengthZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#translationalStiffnessByLengthZ_IfcBoundaryEdgeCondition">ifc:translationalStiffnessByLengthZ_IfcBoundaryEdgeCondition</a>
    /// </summary>
    let translationalStiffnessByLengthZ_IfcBoundaryEdgeCondition = _prefixId.prefix "translationalStiffnessByLengthZ_IfcBoundaryEdgeCondition"

    /// <summary>
    ///   <para>rdfs:label : TranslationalStiffnessX^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#translationalStiffnessX_IfcBoundaryNodeCondition">ifc:translationalStiffnessX_IfcBoundaryNodeCondition</a>
    /// </summary>
    let translationalStiffnessX_IfcBoundaryNodeCondition = _prefixId.prefix "translationalStiffnessX_IfcBoundaryNodeCondition"

    /// <summary>
    ///   <para>rdfs:label : TranslationalStiffnessY^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#translationalStiffnessY_IfcBoundaryNodeCondition">ifc:translationalStiffnessY_IfcBoundaryNodeCondition</a>
    /// </summary>
    let translationalStiffnessY_IfcBoundaryNodeCondition = _prefixId.prefix "translationalStiffnessY_IfcBoundaryNodeCondition"

    /// <summary>
    ///   <para>rdfs:label : TranslationalStiffnessZ^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#translationalStiffnessZ_IfcBoundaryNodeCondition">ifc:translationalStiffnessZ_IfcBoundaryNodeCondition</a>
    /// </summary>
    let translationalStiffnessZ_IfcBoundaryNodeCondition = _prefixId.prefix "translationalStiffnessZ_IfcBoundaryNodeCondition"

    /// <summary>
    ///   <para>rdfs:label : TransmissionColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transmissionColour_IfcSurfaceStyleLighting">ifc:transmissionColour_IfcSurfaceStyleLighting</a>
    /// </summary>
    let transmissionColour_IfcSurfaceStyleLighting = _prefixId.prefix "transmissionColour_IfcSurfaceStyleLighting"

    /// <summary>
    ///   <para>rdfs:label : TransmissionColour^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transmissionColour_IfcSurfaceStyleRendering">ifc:transmissionColour_IfcSurfaceStyleRendering</a>
    /// </summary>
    let transmissionColour_IfcSurfaceStyleRendering = _prefixId.prefix "transmissionColour_IfcSurfaceStyleRendering"

    /// <summary>
    ///   <para>rdfs:label : TransomOffset^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transomOffset_IfcDoorLiningProperties">ifc:transomOffset_IfcDoorLiningProperties</a>
    /// </summary>
    let transomOffset_IfcDoorLiningProperties = _prefixId.prefix "transomOffset_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : TransomThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transomThickness_IfcDoorLiningProperties">ifc:transomThickness_IfcDoorLiningProperties</a>
    /// </summary>
    let transomThickness_IfcDoorLiningProperties = _prefixId.prefix "transomThickness_IfcDoorLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : TransomThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transomThickness_IfcWindowLiningProperties">ifc:transomThickness_IfcWindowLiningProperties</a>
    /// </summary>
    let transomThickness_IfcWindowLiningProperties = _prefixId.prefix "transomThickness_IfcWindowLiningProperties"

    /// <summary>
    ///   <para>rdfs:label : Transparency^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transparency_IfcSurfaceStyleRendering">ifc:transparency_IfcSurfaceStyleRendering</a>
    /// </summary>
    let transparency_IfcSurfaceStyleRendering = _prefixId.prefix "transparency_IfcSurfaceStyleRendering"

    /// <summary>
    ///   <para>rdfs:label : TransverseBarCrossSectionArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transverseBarCrossSectionArea_IfcReinforcingMesh">ifc:transverseBarCrossSectionArea_IfcReinforcingMesh</a>
    /// </summary>
    let transverseBarCrossSectionArea_IfcReinforcingMesh = _prefixId.prefix "transverseBarCrossSectionArea_IfcReinforcingMesh"

    /// <summary>
    ///   <para>rdfs:label : TransverseBarCrossSectionArea^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transverseBarCrossSectionArea_IfcReinforcingMeshType">ifc:transverseBarCrossSectionArea_IfcReinforcingMeshType</a>
    /// </summary>
    let transverseBarCrossSectionArea_IfcReinforcingMeshType = _prefixId.prefix "transverseBarCrossSectionArea_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : TransverseBarNominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transverseBarNominalDiameter_IfcReinforcingMesh">ifc:transverseBarNominalDiameter_IfcReinforcingMesh</a>
    /// </summary>
    let transverseBarNominalDiameter_IfcReinforcingMesh = _prefixId.prefix "transverseBarNominalDiameter_IfcReinforcingMesh"

    /// <summary>
    ///   <para>rdfs:label : TransverseBarNominalDiameter^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transverseBarNominalDiameter_IfcReinforcingMeshType">ifc:transverseBarNominalDiameter_IfcReinforcingMeshType</a>
    /// </summary>
    let transverseBarNominalDiameter_IfcReinforcingMeshType = _prefixId.prefix "transverseBarNominalDiameter_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : TransverseBarSpacing^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transverseBarSpacing_IfcReinforcingMesh">ifc:transverseBarSpacing_IfcReinforcingMesh</a>
    /// </summary>
    let transverseBarSpacing_IfcReinforcingMesh = _prefixId.prefix "transverseBarSpacing_IfcReinforcingMesh"

    /// <summary>
    ///   <para>rdfs:label : TransverseBarSpacing^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transverseBarSpacing_IfcReinforcingMeshType">ifc:transverseBarSpacing_IfcReinforcingMeshType</a>
    /// </summary>
    let transverseBarSpacing_IfcReinforcingMeshType = _prefixId.prefix "transverseBarSpacing_IfcReinforcingMeshType"

    /// <summary>
    ///   <para>rdfs:label : TransversePosition^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#transversePosition_IfcSectionReinforcementProperties">ifc:transversePosition_IfcSectionReinforcementProperties</a>
    /// </summary>
    let transversePosition_IfcSectionReinforcementProperties = _prefixId.prefix "transversePosition_IfcSectionReinforcementProperties"

    /// <summary>
    ///   <para>rdfs:label : TreadLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#treadLength_IfcStairFlight">ifc:treadLength_IfcStairFlight</a>
    /// </summary>
    let treadLength_IfcStairFlight = _prefixId.prefix "treadLength_IfcStairFlight"

    /// <summary>
    ///   <para>rdfs:label : TreeRootExpression^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#treeRootExpression_IfcCsgSolid">ifc:treeRootExpression_IfcCsgSolid</a>
    /// </summary>
    let treeRootExpression_IfcCsgSolid = _prefixId.prefix "treeRootExpression_IfcCsgSolid"

    /// <summary>
    ///   <para>rdfs:label : Trim1^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#trim1_IfcTrimmedCurve">ifc:trim1_IfcTrimmedCurve</a>
    /// </summary>
    let trim1_IfcTrimmedCurve = _prefixId.prefix "trim1_IfcTrimmedCurve"
    /// <summary>
    ///   <para>rdfs:label : Trim2^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#trim2_IfcTrimmedCurve">ifc:trim2_IfcTrimmedCurve</a>
    /// </summary>
    let trim2_IfcTrimmedCurve = _prefixId.prefix "trim2_IfcTrimmedCurve"

    /// <summary>
    ///   <para>rdfs:label : TrueNorth^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#trueNorth_IfcGeometricRepresentationContext">ifc:trueNorth_IfcGeometricRepresentationContext</a>
    /// </summary>
    let trueNorth_IfcGeometricRepresentationContext = _prefixId.prefix "trueNorth_IfcGeometricRepresentationContext"

    /// <summary>
    ///   <para>rdfs:label : TypeIdentifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#typeIdentifier_IfcReference">ifc:typeIdentifier_IfcReference</a>
    /// </summary>
    let typeIdentifier_IfcReference = _prefixId.prefix "typeIdentifier_IfcReference"
    /// <summary>
    ///   <para>rdfs:label : Types^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#types_IfcTypeObject">ifc:types_IfcTypeObject</a>
    /// </summary>
    let types_IfcTypeObject = _prefixId.prefix "types_IfcTypeObject"

    /// <summary>
    ///   <para>rdfs:label : U1^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#u1_IfcRectangularTrimmedSurface">ifc:u1_IfcRectangularTrimmedSurface</a>
    /// </summary>
    let u1_IfcRectangularTrimmedSurface = _prefixId.prefix "u1_IfcRectangularTrimmedSurface"

    /// <summary>
    ///   <para>rdfs:label : U2^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#u2_IfcRectangularTrimmedSurface">ifc:u2_IfcRectangularTrimmedSurface</a>
    /// </summary>
    let u2_IfcRectangularTrimmedSurface = _prefixId.prefix "u2_IfcRectangularTrimmedSurface"

    /// <summary>
    ///   <para>rdfs:label : UAxes^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#uAxes_IfcGrid">ifc:uAxes_IfcGrid</a>
    /// </summary>
    let uAxes_IfcGrid = _prefixId.prefix "uAxes_IfcGrid"
    /// <summary>
    ///   <para>rdfs:label : UClosed^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#uClosed_IfcBSplineSurface">ifc:uClosed_IfcBSplineSurface</a>
    /// </summary>
    let uClosed_IfcBSplineSurface = _prefixId.prefix "uClosed_IfcBSplineSurface"
    /// <summary>
    ///   <para>rdfs:label : UDegree^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#uDegree_IfcBSplineSurface">ifc:uDegree_IfcBSplineSurface</a>
    /// </summary>
    let uDegree_IfcBSplineSurface = _prefixId.prefix "uDegree_IfcBSplineSurface"

    /// <summary>
    ///   <para>rdfs:label : UKnots^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#uKnots_IfcBSplineSurfaceWithKnots">ifc:uKnots_IfcBSplineSurfaceWithKnots</a>
    /// </summary>
    let uKnots_IfcBSplineSurfaceWithKnots = _prefixId.prefix "uKnots_IfcBSplineSurfaceWithKnots"

    /// <summary>
    ///   <para>rdfs:label : UMultiplicities^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#uMultiplicities_IfcBSplineSurfaceWithKnots">ifc:uMultiplicities_IfcBSplineSurfaceWithKnots</a>
    /// </summary>
    let uMultiplicities_IfcBSplineSurfaceWithKnots = _prefixId.prefix "uMultiplicities_IfcBSplineSurfaceWithKnots"

    /// <summary>
    ///   <para>rdfs:label : URLReference^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#uRLReference_IfcImageTexture">ifc:uRLReference_IfcImageTexture</a>
    /// </summary>
    let uRLReference_IfcImageTexture = _prefixId.prefix "uRLReference_IfcImageTexture"
    /// <summary>
    ///   <para>rdfs:label : UnitBasis^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unitBasis_IfcAppliedValue">ifc:unitBasis_IfcAppliedValue</a>
    /// </summary>
    let unitBasis_IfcAppliedValue = _prefixId.prefix "unitBasis_IfcAppliedValue"

    /// <summary>
    ///   <para>rdfs:label : UnitComponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unitComponent_IfcMeasureWithUnit">ifc:unitComponent_IfcMeasureWithUnit</a>
    /// </summary>
    let unitComponent_IfcMeasureWithUnit = _prefixId.prefix "unitComponent_IfcMeasureWithUnit"

    /// <summary>
    ///   <para>rdfs:label : UnitType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unitType_IfcDerivedUnit">ifc:unitType_IfcDerivedUnit</a>
    /// </summary>
    let unitType_IfcDerivedUnit = _prefixId.prefix "unitType_IfcDerivedUnit"
    /// <summary>
    ///   <para>rdfs:label : UnitType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unitType_IfcNamedUnit">ifc:unitType_IfcNamedUnit</a>
    /// </summary>
    let unitType_IfcNamedUnit = _prefixId.prefix "unitType_IfcNamedUnit"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unit_IfcDerivedUnitElement">ifc:unit_IfcDerivedUnitElement</a>
    /// </summary>
    let unit_IfcDerivedUnitElement = _prefixId.prefix "unit_IfcDerivedUnitElement"

    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unit_IfcPhysicalSimpleQuantity">ifc:unit_IfcPhysicalSimpleQuantity</a>
    /// </summary>
    let unit_IfcPhysicalSimpleQuantity = _prefixId.prefix "unit_IfcPhysicalSimpleQuantity"

    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unit_IfcPropertyBoundedValue">ifc:unit_IfcPropertyBoundedValue</a>
    /// </summary>
    let unit_IfcPropertyBoundedValue = _prefixId.prefix "unit_IfcPropertyBoundedValue"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unit_IfcPropertyEnumeration">ifc:unit_IfcPropertyEnumeration</a>
    /// </summary>
    let unit_IfcPropertyEnumeration = _prefixId.prefix "unit_IfcPropertyEnumeration"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unit_IfcPropertyListValue">ifc:unit_IfcPropertyListValue</a>
    /// </summary>
    let unit_IfcPropertyListValue = _prefixId.prefix "unit_IfcPropertyListValue"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unit_IfcPropertySingleValue">ifc:unit_IfcPropertySingleValue</a>
    /// </summary>
    let unit_IfcPropertySingleValue = _prefixId.prefix "unit_IfcPropertySingleValue"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unit_IfcTableColumn">ifc:unit_IfcTableColumn</a>
    /// </summary>
    let unit_IfcTableColumn = _prefixId.prefix "unit_IfcTableColumn"
    /// <summary>
    ///   <para>rdfs:label : Unit^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unit_IfcTimeSeries">ifc:unit_IfcTimeSeries</a>
    /// </summary>
    let unit_IfcTimeSeries = _prefixId.prefix "unit_IfcTimeSeries"
    /// <summary>
    ///   <para>rdfs:label : UnitsInContext^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#unitsInContext_IfcContext">ifc:unitsInContext_IfcContext</a>
    /// </summary>
    let unitsInContext_IfcContext = _prefixId.prefix "unitsInContext_IfcContext"
    /// <summary>
    ///   <para>rdfs:label : Units^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#units_IfcUnitAssignment">ifc:units_IfcUnitAssignment</a>
    /// </summary>
    let units_IfcUnitAssignment = _prefixId.prefix "units_IfcUnitAssignment"
    /// <summary>
    ///   <para>rdfs:label : UpdateDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#updateDate_IfcCostSchedule">ifc:updateDate_IfcCostSchedule</a>
    /// </summary>
    let updateDate_IfcCostSchedule = _prefixId.prefix "updateDate_IfcCostSchedule"

    /// <summary>
    ///   <para>rdfs:label : UpperBoundValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#upperBoundValue_IfcPropertyBoundedValue">ifc:upperBoundValue_IfcPropertyBoundedValue</a>
    /// </summary>
    let upperBoundValue_IfcPropertyBoundedValue = _prefixId.prefix "upperBoundValue_IfcPropertyBoundedValue"

    /// <summary>
    ///   <para>rdfs:label : UsageName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#usageName_IfcComplexProperty">ifc:usageName_IfcComplexProperty</a>
    /// </summary>
    let usageName_IfcComplexProperty = _prefixId.prefix "usageName_IfcComplexProperty"

    /// <summary>
    ///   <para>rdfs:label : UsageName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#usageName_IfcComplexPropertyTemplate">ifc:usageName_IfcComplexPropertyTemplate</a>
    /// </summary>
    let usageName_IfcComplexPropertyTemplate = _prefixId.prefix "usageName_IfcComplexPropertyTemplate"

    /// <summary>
    ///   <para>rdfs:label : UsageName^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#usageName_IfcPropertyReferenceValue">ifc:usageName_IfcPropertyReferenceValue</a>
    /// </summary>
    let usageName_IfcPropertyReferenceValue = _prefixId.prefix "usageName_IfcPropertyReferenceValue"

    /// <summary>
    ///   <para>rdfs:label : Usage^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#usage_IfcConstructionResource">ifc:usage_IfcConstructionResource</a>
    /// </summary>
    let usage_IfcConstructionResource = _prefixId.prefix "usage_IfcConstructionResource"

    /// <summary>
    ///   <para>rdfs:label : Usage^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#usage_IfcPhysicalComplexQuantity">ifc:usage_IfcPhysicalComplexQuantity</a>
    /// </summary>
    let usage_IfcPhysicalComplexQuantity = _prefixId.prefix "usage_IfcPhysicalComplexQuantity"

    /// <summary>
    ///   <para>rdfs:label : Usense^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#usense_IfcRectangularTrimmedSurface">ifc:usense_IfcRectangularTrimmedSurface</a>
    /// </summary>
    let usense_IfcRectangularTrimmedSurface = _prefixId.prefix "usense_IfcRectangularTrimmedSurface"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedDataOrigin^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedDataOrigin_IfcSchedulingTime">ifc:userDefinedDataOrigin_IfcSchedulingTime</a>
    /// </summary>
    let userDefinedDataOrigin_IfcSchedulingTime = _prefixId.prefix "userDefinedDataOrigin_IfcSchedulingTime"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedDataOrigin^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedDataOrigin_IfcTimeSeries">ifc:userDefinedDataOrigin_IfcTimeSeries</a>
    /// </summary>
    let userDefinedDataOrigin_IfcTimeSeries = _prefixId.prefix "userDefinedDataOrigin_IfcTimeSeries"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedEventTriggerType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedEventTriggerType_IfcEvent">ifc:userDefinedEventTriggerType_IfcEvent</a>
    /// </summary>
    let userDefinedEventTriggerType_IfcEvent = _prefixId.prefix "userDefinedEventTriggerType_IfcEvent"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedEventTriggerType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedEventTriggerType_IfcEventType">ifc:userDefinedEventTriggerType_IfcEventType</a>
    /// </summary>
    let userDefinedEventTriggerType_IfcEventType = _prefixId.prefix "userDefinedEventTriggerType_IfcEventType"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedGrade^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedGrade_IfcConstraint">ifc:userDefinedGrade_IfcConstraint</a>
    /// </summary>
    let userDefinedGrade_IfcConstraint = _prefixId.prefix "userDefinedGrade_IfcConstraint"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedOperationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedOperationType_IfcDoor">ifc:userDefinedOperationType_IfcDoor</a>
    /// </summary>
    let userDefinedOperationType_IfcDoor = _prefixId.prefix "userDefinedOperationType_IfcDoor"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedOperationType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedOperationType_IfcDoorType">ifc:userDefinedOperationType_IfcDoorType</a>
    /// </summary>
    let userDefinedOperationType_IfcDoorType = _prefixId.prefix "userDefinedOperationType_IfcDoorType"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedPartitioningType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedPartitioningType_IfcWindow">ifc:userDefinedPartitioningType_IfcWindow</a>
    /// </summary>
    let userDefinedPartitioningType_IfcWindow = _prefixId.prefix "userDefinedPartitioningType_IfcWindow"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedPartitioningType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedPartitioningType_IfcWindowType">ifc:userDefinedPartitioningType_IfcWindowType</a>
    /// </summary>
    let userDefinedPartitioningType_IfcWindowType = _prefixId.prefix "userDefinedPartitioningType_IfcWindowType"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedPurpose^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedPurpose_IfcAddress">ifc:userDefinedPurpose_IfcAddress</a>
    /// </summary>
    let userDefinedPurpose_IfcAddress = _prefixId.prefix "userDefinedPurpose_IfcAddress"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedQualifier^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedQualifier_IfcObjective">ifc:userDefinedQualifier_IfcObjective</a>
    /// </summary>
    let userDefinedQualifier_IfcObjective = _prefixId.prefix "userDefinedQualifier_IfcObjective"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedRole^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedRole_IfcActorRole">ifc:userDefinedRole_IfcActorRole</a>
    /// </summary>
    let userDefinedRole_IfcActorRole = _prefixId.prefix "userDefinedRole_IfcActorRole"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedSequenceType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedSequenceType_IfcRelSequence">ifc:userDefinedSequenceType_IfcRelSequence</a>
    /// </summary>
    let userDefinedSequenceType_IfcRelSequence = _prefixId.prefix "userDefinedSequenceType_IfcRelSequence"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedTargetView^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedTargetView_IfcGeometricRepresentationSubContext">ifc:userDefinedTargetView_IfcGeometricRepresentationSubContext</a>
    /// </summary>
    let userDefinedTargetView_IfcGeometricRepresentationSubContext = _prefixId.prefix "userDefinedTargetView_IfcGeometricRepresentationSubContext"

    /// <summary>
    ///   <para>rdfs:label : UserDefinedType^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#userDefinedType_IfcDerivedUnit">ifc:userDefinedType_IfcDerivedUnit</a>
    /// </summary>
    let userDefinedType_IfcDerivedUnit = _prefixId.prefix "userDefinedType_IfcDerivedUnit"

    /// <summary>
    ///   <para>rdfs:label : User^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#user_IfcAsset">ifc:user_IfcAsset</a>
    /// </summary>
    let user_IfcAsset = _prefixId.prefix "user_IfcAsset"

    /// <summary>
    ///   <para>rdfs:label : V1^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#v1_IfcRectangularTrimmedSurface">ifc:v1_IfcRectangularTrimmedSurface</a>
    /// </summary>
    let v1_IfcRectangularTrimmedSurface = _prefixId.prefix "v1_IfcRectangularTrimmedSurface"

    /// <summary>
    ///   <para>rdfs:label : V2^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#v2_IfcRectangularTrimmedSurface">ifc:v2_IfcRectangularTrimmedSurface</a>
    /// </summary>
    let v2_IfcRectangularTrimmedSurface = _prefixId.prefix "v2_IfcRectangularTrimmedSurface"

    /// <summary>
    ///   <para>rdfs:label : VAxes^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#vAxes_IfcGrid">ifc:vAxes_IfcGrid</a>
    /// </summary>
    let vAxes_IfcGrid = _prefixId.prefix "vAxes_IfcGrid"
    /// <summary>
    ///   <para>rdfs:label : VClosed^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#vClosed_IfcBSplineSurface">ifc:vClosed_IfcBSplineSurface</a>
    /// </summary>
    let vClosed_IfcBSplineSurface = _prefixId.prefix "vClosed_IfcBSplineSurface"
    /// <summary>
    ///   <para>rdfs:label : VDegree^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#vDegree_IfcBSplineSurface">ifc:vDegree_IfcBSplineSurface</a>
    /// </summary>
    let vDegree_IfcBSplineSurface = _prefixId.prefix "vDegree_IfcBSplineSurface"

    /// <summary>
    ///   <para>rdfs:label : VKnots^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#vKnots_IfcBSplineSurfaceWithKnots">ifc:vKnots_IfcBSplineSurfaceWithKnots</a>
    /// </summary>
    let vKnots_IfcBSplineSurfaceWithKnots = _prefixId.prefix "vKnots_IfcBSplineSurfaceWithKnots"

    /// <summary>
    ///   <para>rdfs:label : VMultiplicities^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#vMultiplicities_IfcBSplineSurfaceWithKnots">ifc:vMultiplicities_IfcBSplineSurfaceWithKnots</a>
    /// </summary>
    let vMultiplicities_IfcBSplineSurfaceWithKnots = _prefixId.prefix "vMultiplicities_IfcBSplineSurfaceWithKnots"

    /// <summary>
    ///   <para>rdfs:label : ValidFrom^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#validFrom_IfcDocumentInformation">ifc:validFrom_IfcDocumentInformation</a>
    /// </summary>
    let validFrom_IfcDocumentInformation = _prefixId.prefix "validFrom_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : ValidUntil^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#validUntil_IfcDocumentInformation">ifc:validUntil_IfcDocumentInformation</a>
    /// </summary>
    let validUntil_IfcDocumentInformation = _prefixId.prefix "validUntil_IfcDocumentInformation"

    /// <summary>
    ///   <para>rdfs:label : ValueComponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#valueComponent_IfcMeasureWithUnit">ifc:valueComponent_IfcMeasureWithUnit</a>
    /// </summary>
    let valueComponent_IfcMeasureWithUnit = _prefixId.prefix "valueComponent_IfcMeasureWithUnit"

    /// <summary>
    ///   <para>rdfs:label : ValueSource^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#valueSource_IfcMetric">ifc:valueSource_IfcMetric</a>
    /// </summary>
    let valueSource_IfcMetric = _prefixId.prefix "valueSource_IfcMetric"
    /// <summary>
    ///   <para>rdfs:label : Values^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#values_IfcIrregularTimeSeries">ifc:values_IfcIrregularTimeSeries</a>
    /// </summary>
    let values_IfcIrregularTimeSeries = _prefixId.prefix "values_IfcIrregularTimeSeries"
    /// <summary>
    ///   <para>rdfs:label : Values^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#values_IfcRegularTimeSeries">ifc:values_IfcRegularTimeSeries</a>
    /// </summary>
    let values_IfcRegularTimeSeries = _prefixId.prefix "values_IfcRegularTimeSeries"

    /// <summary>
    ///   <para>rdfs:label : Values^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#values_IfcStructuralLoadConfiguration">ifc:values_IfcStructuralLoadConfiguration</a>
    /// </summary>
    let values_IfcStructuralLoadConfiguration = _prefixId.prefix "values_IfcStructuralLoadConfiguration"

    /// <summary>
    ///   <para>rdfs:label : VersionDate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#versionDate_IfcLibraryInformation">ifc:versionDate_IfcLibraryInformation</a>
    /// </summary>
    let versionDate_IfcLibraryInformation = _prefixId.prefix "versionDate_IfcLibraryInformation"

    /// <summary>
    ///   <para>rdfs:label : Version^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#version_IfcApplication">ifc:version_IfcApplication</a>
    /// </summary>
    let version_IfcApplication = _prefixId.prefix "version_IfcApplication"
    /// <summary>
    ///   <para>rdfs:label : Version^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#version_IfcLibraryInformation">ifc:version_IfcLibraryInformation</a>
    /// </summary>
    let version_IfcLibraryInformation = _prefixId.prefix "version_IfcLibraryInformation"
    /// <summary>
    ///   <para>rdfs:label : VertexGeometry^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#vertexGeometry_IfcVertexPoint">ifc:vertexGeometry_IfcVertexPoint</a>
    /// </summary>
    let vertexGeometry_IfcVertexPoint = _prefixId.prefix "vertexGeometry_IfcVertexPoint"

    /// <summary>
    ///   <para>rdfs:label : VerticalDatum^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#verticalDatum_IfcCoordinateReferenceSystem">ifc:verticalDatum_IfcCoordinateReferenceSystem</a>
    /// </summary>
    let verticalDatum_IfcCoordinateReferenceSystem = _prefixId.prefix "verticalDatum_IfcCoordinateReferenceSystem"

    /// <summary>
    ///   <para>rdfs:label : Vertices^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#vertices_IfcTextureMap">ifc:vertices_IfcTextureMap</a>
    /// </summary>
    let vertices_IfcTextureMap = _prefixId.prefix "vertices_IfcTextureMap"

    /// <summary>
    ///   <para>rdfs:label : VisibleSegmentLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#visibleSegmentLength_IfcCurveStyleFontPattern">ifc:visibleSegmentLength_IfcCurveStyleFontPattern</a>
    /// </summary>
    let visibleSegmentLength_IfcCurveStyleFontPattern = _prefixId.prefix "visibleSegmentLength_IfcCurveStyleFontPattern"

    /// <summary>
    ///   <para>rdfs:label : VoidsElements^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#voidsElements_IfcFeatureElementSubtraction">ifc:voidsElements_IfcFeatureElementSubtraction</a>
    /// </summary>
    let voidsElements_IfcFeatureElementSubtraction = _prefixId.prefix "voidsElements_IfcFeatureElementSubtraction"

    /// <summary>
    ///   <para>rdfs:label : Voids^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#voids_IfcAdvancedBrepWithVoids">ifc:voids_IfcAdvancedBrepWithVoids</a>
    /// </summary>
    let voids_IfcAdvancedBrepWithVoids = _prefixId.prefix "voids_IfcAdvancedBrepWithVoids"

    /// <summary>
    ///   <para>rdfs:label : Voids^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#voids_IfcFacetedBrepWithVoids">ifc:voids_IfcFacetedBrepWithVoids</a>
    /// </summary>
    let voids_IfcFacetedBrepWithVoids = _prefixId.prefix "voids_IfcFacetedBrepWithVoids"

    /// <summary>
    ///   <para>rdfs:label : VolumeOnRelatedElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#volumeOnRelatedElement_IfcConnectionVolumeGeometry">ifc:volumeOnRelatedElement_IfcConnectionVolumeGeometry</a>
    /// </summary>
    let volumeOnRelatedElement_IfcConnectionVolumeGeometry = _prefixId.prefix "volumeOnRelatedElement_IfcConnectionVolumeGeometry"

    /// <summary>
    ///   <para>rdfs:label : VolumeOnRelatingElement^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#volumeOnRelatingElement_IfcConnectionVolumeGeometry">ifc:volumeOnRelatingElement_IfcConnectionVolumeGeometry</a>
    /// </summary>
    let volumeOnRelatingElement_IfcConnectionVolumeGeometry = _prefixId.prefix "volumeOnRelatingElement_IfcConnectionVolumeGeometry"

    /// <summary>
    ///   <para>rdfs:label : VolumeValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#volumeValue_IfcQuantityVolume">ifc:volumeValue_IfcQuantityVolume</a>
    /// </summary>
    let volumeValue_IfcQuantityVolume = _prefixId.prefix "volumeValue_IfcQuantityVolume"

    /// <summary>
    ///   <para>rdfs:label : Vsense^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#vsense_IfcRectangularTrimmedSurface">ifc:vsense_IfcRectangularTrimmedSurface</a>
    /// </summary>
    let vsense_IfcRectangularTrimmedSurface = _prefixId.prefix "vsense_IfcRectangularTrimmedSurface"

    /// <summary>
    ///   <para>rdfs:label : WAxes^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#wAxes_IfcGrid">ifc:wAxes_IfcGrid</a>
    /// </summary>
    let wAxes_IfcGrid = _prefixId.prefix "wAxes_IfcGrid"

    /// <summary>
    ///   <para>rdfs:label : WWWHomePageURL^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#wWWHomePageURL_IfcTelecomAddress">ifc:wWWHomePageURL_IfcTelecomAddress</a>
    /// </summary>
    let wWWHomePageURL_IfcTelecomAddress = _prefixId.prefix "wWWHomePageURL_IfcTelecomAddress"

    /// <summary>
    ///   <para>rdfs:label : WallThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#wallThickness_IfcCShapeProfileDef">ifc:wallThickness_IfcCShapeProfileDef</a>
    /// </summary>
    let wallThickness_IfcCShapeProfileDef = _prefixId.prefix "wallThickness_IfcCShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WallThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#wallThickness_IfcCircleHollowProfileDef">ifc:wallThickness_IfcCircleHollowProfileDef</a>
    /// </summary>
    let wallThickness_IfcCircleHollowProfileDef = _prefixId.prefix "wallThickness_IfcCircleHollowProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WallThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#wallThickness_IfcRectangleHollowProfileDef">ifc:wallThickness_IfcRectangleHollowProfileDef</a>
    /// </summary>
    let wallThickness_IfcRectangleHollowProfileDef = _prefixId.prefix "wallThickness_IfcRectangleHollowProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WarpingMoment^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#warpingMoment_IfcStructuralLoadSingleForceWarping">ifc:warpingMoment_IfcStructuralLoadSingleForceWarping</a>
    /// </summary>
    let warpingMoment_IfcStructuralLoadSingleForceWarping = _prefixId.prefix "warpingMoment_IfcStructuralLoadSingleForceWarping"

    /// <summary>
    ///   <para>rdfs:label : WarpingStiffness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#warpingStiffness_IfcBoundaryNodeConditionWarping">ifc:warpingStiffness_IfcBoundaryNodeConditionWarping</a>
    /// </summary>
    let warpingStiffness_IfcBoundaryNodeConditionWarping = _prefixId.prefix "warpingStiffness_IfcBoundaryNodeConditionWarping"

    /// <summary>
    ///   <para>rdfs:label : WebEdgeRadius^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#webEdgeRadius_IfcTShapeProfileDef">ifc:webEdgeRadius_IfcTShapeProfileDef</a>
    /// </summary>
    let webEdgeRadius_IfcTShapeProfileDef = _prefixId.prefix "webEdgeRadius_IfcTShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WebSlope^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#webSlope_IfcTShapeProfileDef">ifc:webSlope_IfcTShapeProfileDef</a>
    /// </summary>
    let webSlope_IfcTShapeProfileDef = _prefixId.prefix "webSlope_IfcTShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WebThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#webThickness_IfcAsymmetricIShapeProfileDef">ifc:webThickness_IfcAsymmetricIShapeProfileDef</a>
    /// </summary>
    let webThickness_IfcAsymmetricIShapeProfileDef = _prefixId.prefix "webThickness_IfcAsymmetricIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WebThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#webThickness_IfcIShapeProfileDef">ifc:webThickness_IfcIShapeProfileDef</a>
    /// </summary>
    let webThickness_IfcIShapeProfileDef = _prefixId.prefix "webThickness_IfcIShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WebThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#webThickness_IfcTShapeProfileDef">ifc:webThickness_IfcTShapeProfileDef</a>
    /// </summary>
    let webThickness_IfcTShapeProfileDef = _prefixId.prefix "webThickness_IfcTShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WebThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#webThickness_IfcUShapeProfileDef">ifc:webThickness_IfcUShapeProfileDef</a>
    /// </summary>
    let webThickness_IfcUShapeProfileDef = _prefixId.prefix "webThickness_IfcUShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WebThickness^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#webThickness_IfcZShapeProfileDef">ifc:webThickness_IfcZShapeProfileDef</a>
    /// </summary>
    let webThickness_IfcZShapeProfileDef = _prefixId.prefix "webThickness_IfcZShapeProfileDef"

    /// <summary>
    ///   <para>rdfs:label : WeekdayComponent^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#weekdayComponent_IfcRecurrencePattern">ifc:weekdayComponent_IfcRecurrencePattern</a>
    /// </summary>
    let weekdayComponent_IfcRecurrencePattern = _prefixId.prefix "weekdayComponent_IfcRecurrencePattern"

    /// <summary>
    ///   <para>rdfs:label : WeightValue^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#weightValue_IfcQuantityWeight">ifc:weightValue_IfcQuantityWeight</a>
    /// </summary>
    let weightValue_IfcQuantityWeight = _prefixId.prefix "weightValue_IfcQuantityWeight"

    /// <summary>
    ///   <para>rdfs:label : WeightsData^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#weightsData_IfcRationalBSplineCurveWithKnots">ifc:weightsData_IfcRationalBSplineCurveWithKnots</a>
    /// </summary>
    let weightsData_IfcRationalBSplineCurveWithKnots = _prefixId.prefix "weightsData_IfcRationalBSplineCurveWithKnots"

    /// <summary>
    ///   <para>rdfs:label : WeightsData^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#weightsData_IfcRationalBSplineSurfaceWithKnots">ifc:weightsData_IfcRationalBSplineSurfaceWithKnots</a>
    /// </summary>
    let weightsData_IfcRationalBSplineSurfaceWithKnots = _prefixId.prefix "weightsData_IfcRationalBSplineSurfaceWithKnots"

    /// <summary>
    ///   <para>rdfs:label : Width^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#width_IfcCShapeProfileDef">ifc:width_IfcCShapeProfileDef</a>
    /// </summary>
    let width_IfcCShapeProfileDef = _prefixId.prefix "width_IfcCShapeProfileDef"
    /// <summary>
    ///   <para>rdfs:label : Width^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#width_IfcLShapeProfileDef">ifc:width_IfcLShapeProfileDef</a>
    /// </summary>
    let width_IfcLShapeProfileDef = _prefixId.prefix "width_IfcLShapeProfileDef"
    /// <summary>
    ///   <para>rdfs:label : Width^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#width_IfcPixelTexture">ifc:width_IfcPixelTexture</a>
    /// </summary>
    let width_IfcPixelTexture = _prefixId.prefix "width_IfcPixelTexture"

    /// <summary>
    ///   <para>rdfs:label : WordSpacing^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#wordSpacing_IfcTextStyleTextModel">ifc:wordSpacing_IfcTextStyleTextModel</a>
    /// </summary>
    let wordSpacing_IfcTextStyleTextModel = _prefixId.prefix "wordSpacing_IfcTextStyleTextModel"

    /// <summary>
    ///   <para>rdfs:label : WorkMethod^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#workMethod_IfcTask">ifc:workMethod_IfcTask</a>
    /// </summary>
    let workMethod_IfcTask = _prefixId.prefix "workMethod_IfcTask"
    /// <summary>
    ///   <para>rdfs:label : WorkMethod^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#workMethod_IfcTaskType">ifc:workMethod_IfcTaskType</a>
    /// </summary>
    let workMethod_IfcTaskType = _prefixId.prefix "workMethod_IfcTaskType"
    /// <summary>
    ///   <para>rdfs:label : WorkingTimes^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#workingTimes_IfcWorkCalendar">ifc:workingTimes_IfcWorkCalendar</a>
    /// </summary>
    let workingTimes_IfcWorkCalendar = _prefixId.prefix "workingTimes_IfcWorkCalendar"

    /// <summary>
    ///   <para>rdfs:label : WorldCoordinateSystem^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#worldCoordinateSystem_IfcGeometricRepresentationContext">ifc:worldCoordinateSystem_IfcGeometricRepresentationContext</a>
    /// </summary>
    let worldCoordinateSystem_IfcGeometricRepresentationContext = _prefixId.prefix "worldCoordinateSystem_IfcGeometricRepresentationContext"

    /// <summary>
    ///   <para>rdfs:label : XAxisAbscissa^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#xAxisAbscissa_IfcMapConversion">ifc:xAxisAbscissa_IfcMapConversion</a>
    /// </summary>
    let xAxisAbscissa_IfcMapConversion = _prefixId.prefix "xAxisAbscissa_IfcMapConversion"

    /// <summary>
    ///   <para>rdfs:label : XAxisOrdinate^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#xAxisOrdinate_IfcMapConversion">ifc:xAxisOrdinate_IfcMapConversion</a>
    /// </summary>
    let xAxisOrdinate_IfcMapConversion = _prefixId.prefix "xAxisOrdinate_IfcMapConversion"

    /// <summary>
    ///   <para>rdfs:label : XDim^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#xDim_IfcBoundingBox">ifc:xDim_IfcBoundingBox</a>
    /// </summary>
    let xDim_IfcBoundingBox = _prefixId.prefix "xDim_IfcBoundingBox"
    /// <summary>
    ///   <para>rdfs:label : XDim^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#xDim_IfcRectangleProfileDef">ifc:xDim_IfcRectangleProfileDef</a>
    /// </summary>
    let xDim_IfcRectangleProfileDef = _prefixId.prefix "xDim_IfcRectangleProfileDef"
    /// <summary>
    ///   <para>rdfs:label : XLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#xLength_IfcBlock">ifc:xLength_IfcBlock</a>
    /// </summary>
    let xLength_IfcBlock = _prefixId.prefix "xLength_IfcBlock"
    /// <summary>
    ///   <para>rdfs:label : XLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#xLength_IfcRectangularPyramid">ifc:xLength_IfcRectangularPyramid</a>
    /// </summary>
    let xLength_IfcRectangularPyramid = _prefixId.prefix "xLength_IfcRectangularPyramid"
    /// <summary>
    ///   <para>rdfs:label : YDim^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#yDim_IfcBoundingBox">ifc:yDim_IfcBoundingBox</a>
    /// </summary>
    let yDim_IfcBoundingBox = _prefixId.prefix "yDim_IfcBoundingBox"
    /// <summary>
    ///   <para>rdfs:label : YDim^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#yDim_IfcRectangleProfileDef">ifc:yDim_IfcRectangleProfileDef</a>
    /// </summary>
    let yDim_IfcRectangleProfileDef = _prefixId.prefix "yDim_IfcRectangleProfileDef"
    /// <summary>
    ///   <para>rdfs:label : YDim^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#yDim_IfcTrapeziumProfileDef">ifc:yDim_IfcTrapeziumProfileDef</a>
    /// </summary>
    let yDim_IfcTrapeziumProfileDef = _prefixId.prefix "yDim_IfcTrapeziumProfileDef"
    /// <summary>
    ///   <para>rdfs:label : YLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#yLength_IfcBlock">ifc:yLength_IfcBlock</a>
    /// </summary>
    let yLength_IfcBlock = _prefixId.prefix "yLength_IfcBlock"
    /// <summary>
    ///   <para>rdfs:label : YLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#yLength_IfcRectangularPyramid">ifc:yLength_IfcRectangularPyramid</a>
    /// </summary>
    let yLength_IfcRectangularPyramid = _prefixId.prefix "yLength_IfcRectangularPyramid"
    /// <summary>
    ///   <para>rdfs:label : ZDim^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#zDim_IfcBoundingBox">ifc:zDim_IfcBoundingBox</a>
    /// </summary>
    let zDim_IfcBoundingBox = _prefixId.prefix "zDim_IfcBoundingBox"
    /// <summary>
    ///   <para>rdfs:label : ZLength^^xsd:string</para>
    ///   <a href="https://w3id.org/ifc/IFC4_ADD1#zLength_IfcBlock">ifc:zLength_IfcBlock</a>
    /// </summary>
    let zLength_IfcBlock = _prefixId.prefix "zLength_IfcBlock"
