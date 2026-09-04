#I @"C:\Repositories\eristocrates\ipa\Source-code\Host-environment\Common-Language-Runtime\FSharp\Interactive\REPL"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module ofrd =
    let _prefixId =
        PrefixId.fromNamespaceLabel "http://purl.org/opdm/refrigerator#" "ofrd"

    let _namespaceIri = _prefixId.prefix ""
    let BottomFreezer = _prefixId.prefix "BottomFreezer"
    let BuiltIn = _prefixId.prefix "BuiltIn"
    let Chest = _prefixId.prefix "Chest"
    /// <summary>
    ///   <para>rdfs:label : ClimateClass</para>
    ///   <para>rdfs:comment : Class to represent the range of room temperatures that a fridge/freezer can operate. Possible values include: N, SN, ST, T.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#ClimateClass">ofrd:ClimateClass</a>
    /// </summary>
    let ClimateClass = _prefixId.prefix "ClimateClass"
    let ClimateN = _prefixId.prefix "ClimateN"
    let ClimateSN = _prefixId.prefix "ClimateSN"
    let ClimateST = _prefixId.prefix "ClimateST"
    let ClimateT = _prefixId.prefix "ClimateT"
    let EnergyA = _prefixId.prefix "EnergyA"
    let EnergyA1 = _prefixId.prefix "EnergyA1"
    let EnergyA2 = _prefixId.prefix "EnergyA2"
    let EnergyA3 = _prefixId.prefix "EnergyA3"
    let EnergyB = _prefixId.prefix "EnergyB"
    let EnergyC = _prefixId.prefix "EnergyC"
    let EnergyD = _prefixId.prefix "EnergyD"
    let EnergyE = _prefixId.prefix "EnergyE"
    let EnergyF = _prefixId.prefix "EnergyF"
    let EnergyG = _prefixId.prefix "EnergyG"
    /// <summary>
    ///   <para>rdfs:label : EnergyRatingEU</para>
    ///   <para>rdfs:comment : Class to represent the European Union energy label codas of a fridge. Possible values go from A+++ to G.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#EnergyRatingEU">ofrd:EnergyRatingEU</a>
    /// </summary>
    let EnergyRatingEU = _prefixId.prefix "EnergyRatingEU"
    let FreeStanding = _prefixId.prefix "FreeStanding"
    /// <summary>
    ///   <para>rdfs:label : Congeladorrdfs:label : Freezer</para>
    ///   <para>rdfs:comment : A generic dedicated Freezer (with no Fridge unit) as a product type</para>
    ///   <a href="http://purl.org/opdm/refrigerator#Freezer">ofrd:Freezer</a>
    /// </summary>
    let Freezer = _prefixId.prefix "Freezer"
    let FrenchDoor = _prefixId.prefix "FrenchDoor"
    /// <summary>
    ///   <para>skos:altLabel : Heladeraskos:altLabel : Neveraskos:altLabel : Refrigeratorskos:altLabel : Refrigerador</para>
    ///   <para>rdfs:comment : A generic Fridge with no Freezer unit as a product type</para>
    ///   <para>rdfs:label : Fridgerdfs:label : Kühlschrankrdfs:label : Frigorífico</para>
    ///   <a href="http://purl.org/opdm/refrigerator#Fridge">ofrd:Fridge</a>
    /// </summary>
    let Fridge = _prefixId.prefix "Fridge"
    /// <summary>
    ///   <para>rdfs:label : Kühlschrankrdfs:label : Frigorífico/Congeladorrdfs:label : FridgeFreezer</para>
    ///   <para>skos:altLabel : Nevera/Congeladorskos:altLabel : Refrigerador/Congeladorskos:altLabel : Heladera/Congeladorskos:altLabel : Refrigerator/Freezer</para>
    ///   <para>rdfs:comment : A generic Fridge/Freezer as a product type</para>
    ///   <a href="http://purl.org/opdm/refrigerator#FridgeFreezer">ofrd:FridgeFreezer</a>
    /// </summary>
    let FridgeFreezer = _prefixId.prefix "FridgeFreezer"
    let Left = _prefixId.prefix "Left"
    /// <summary>
    ///   <para>rdfs:label : RelativeDirection</para>
    ///   <para>rdfs:comment : Class to represent the most common relative directions. Possible values include: left, right, forward, backward, up, down.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#RelativeDirection">ofrd:RelativeDirection</a>
    /// </summary>
    let RelativeDirection = _prefixId.prefix "RelativeDirection"
    let Right = _prefixId.prefix "Right"
    let SideBySide = _prefixId.prefix "SideBySide"
    let SingleDoor = _prefixId.prefix "SingleDoor"
    /// <summary>
    ///   <para>rdfs:comment : Class to represent the different styles of fridge/freezers. Possible values include: french-door, side-by-side, top-freezer, bottom-freezer, single-door.</para>
    ///   <para>rdfs:label : StyleOfUnit</para>
    ///   <a href="http://purl.org/opdm/refrigerator#StyleOfUnit">ofrd:StyleOfUnit</a>
    /// </summary>
    let StyleOfUnit = _prefixId.prefix "StyleOfUnit"
    let TopFreezer = _prefixId.prefix "TopFreezer"
    /// <summary>
    ///   <para>rdfs:label : TypeOfBody</para>
    ///   <para>rdfs:comment : Class to represent the different types of body frames of a fridge/freezer. Possible values include: built-in, free-standing.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#TypeOfBody">ofrd:TypeOfBody</a>
    /// </summary>
    let TypeOfBody = _prefixId.prefix "TypeOfBody"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with an antibacterial detector system or not.</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : Antibacterial</para>
    ///   <a href="http://purl.org/opdm/refrigerator#antibacterial">ofrd:antibacterial</a>
    /// </summary>
    let antibacterial = _prefixId.prefix "antibacterial"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:label : Capable of ACS</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with an Advanced Control System (ACS) or not. ACS allows the fridge/freezer to maintain the desired internal temperature safe from variations in the external termperature.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#capableOfACS">ofrd:capableOfACS</a>
    /// </summary>
    let capableOfACS = _prefixId.prefix "capableOfACS"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with a child lock system or not.</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:label : Child lock</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#childLock">ofrd:childLock</a>
    /// </summary>
    let childLock = _prefixId.prefix "childLock"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:label : Consumption of energy</para>
    ///   <para>http://purl.org/opdm/utility#recommendedUnitOfMeasure : KWH^^xsd:string</para>
    ///   <para>rdfs:comment : The consumption of energy of the fridge/freezer in kilowatt hour (in a year) - UN/CEFACT common code: KWH.</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#consumptionOfEnergy">ofrd:consumptionOfEnergy</a>
    /// </summary>
    let consumptionOfEnergy = _prefixId.prefix "consumptionOfEnergy"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : Display</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with an electronic display system or not.</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#display">ofrd:display</a>
    /// </summary>
    let display = _prefixId.prefix "display"
    /// <summary>
    ///   <para>rdfs:label : Door open alarm</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with a door-open alarm system or not.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#doorOpenAlarm">ofrd:doorOpenAlarm</a>
    /// </summary>
    let doorOpenAlarm = _prefixId.prefix "doorOpenAlarm"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is certified with the Energy Star label awarded by the Department of Energy and Enviromental Protection Agency of the US, or not.</para>
    ///   <para>rdfs:label : Energy Star US</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#energyStarUS">ofrd:energyStarUS</a>
    /// </summary>
    let energyStarUS = _prefixId.prefix "energyStarUS"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with a frost-free system or not.</para>
    ///   <para>rdfs:label : Frost free</para>
    ///   <a href="http://purl.org/opdm/refrigerator#frostFree">ofrd:frostFree</a>
    /// </summary>
    let frostFree = _prefixId.prefix "frostFree"
    /// <summary>
    ///   <para>rdfs:label : Ice dispenser</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with an ice dispenser system or not.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#iceDispenser">ofrd:iceDispenser</a>
    /// </summary>
    let iceDispenser = _prefixId.prefix "iceDispenser"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:label : Ice maker</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with an ice-maker system or not.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#iceMaker">ofrd:iceMaker</a>
    /// </summary>
    let iceMaker = _prefixId.prefix "iceMaker"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#recommendedUnitOfMeasure : 2N^^xsd:string</para>
    ///   <para>rdfs:comment : The level of noise in decibels of the fridge/freezer (UN/CEFACT common code: 2N).</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : Level of noise</para>
    ///   <a href="http://purl.org/opdm/refrigerator#levelOfNoise">ofrd:levelOfNoise</a>
    /// </summary>
    let levelOfNoise = _prefixId.prefix "levelOfNoise"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the number of compartments that the freezer is equipped with.</para>
    ///   <para>rdfs:label : Number of freezer compartments</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#numberOfFreezerCompartments">ofrd:numberOfFreezerCompartments</a>
    /// </summary>
    let numberOfFreezerCompartments = _prefixId.prefix "numberOfFreezerCompartments"
    /// <summary>
    ///   <para>rdfs:label : Number of fridge shelves</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the number of shelves or levels that the fridge is equipped with.</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#numberOfFridgeShelves">ofrd:numberOfFridgeShelves</a>
    /// </summary>
    let numberOfFridgeShelves = _prefixId.prefix "numberOfFridgeShelves"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the number of front doors that the fridge is equipped with.</para>
    ///   <para>rdfs:label : Number of front doors</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#numberOfFrontDoors">ofrd:numberOfFrontDoors</a>
    /// </summary>
    let numberOfFrontDoors = _prefixId.prefix "numberOfFrontDoors"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies the number of front drawers that the fridge is equipped with.</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:label : Number of front drawers</para>
    ///   <a href="http://purl.org/opdm/refrigerator#numberOfFrontDrawers">ofrd:numberOfFrontDrawers</a>
    /// </summary>
    let numberOfFrontDrawers = _prefixId.prefix "numberOfFrontDrawers"
    /// <summary>
    ///   <para>rdfs:comment : The position of the door hinge of the fridge/freezer unit.</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : Position of door hinge</para>
    ///   <a href="http://purl.org/opdm/refrigerator#positionOfDoorHinge">ofrd:positionOfDoorHinge</a>
    /// </summary>
    let positionOfDoorHinge = _prefixId.prefix "positionOfDoorHinge"
    /// <summary>
    ///   <para>rdfs:label : Power supply</para>
    ///   <para>http://purl.org/opdm/utility#recommendedUnitOfMeasure : VLT^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : The power supply requirements in volts of the fridge/freezer unit (UN/CEFACT common code: VLT). Optionally, this property can be complemented with a gr:valueReference property to indicate the frecuency that the power supply operates at in Hertz (UN/CEFACT common code: HTZ).</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#powerSupply">ofrd:powerSupply</a>
    /// </summary>
    let powerSupply = _prefixId.prefix "powerSupply"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : The climate class rating that the fridge/freezer can operate at.</para>
    ///   <para>rdfs:label : Rating of climate class</para>
    ///   <a href="http://purl.org/opdm/refrigerator#ratingOfClimateClass">ofrd:ratingOfClimateClass</a>
    /// </summary>
    let ratingOfClimateClass = _prefixId.prefix "ratingOfClimateClass"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:label : Rating of energy EU</para>
    ///   <para>rdfs:comment : The rating of energy efficiency in the European Union that the fridge/freezer operates at.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#ratingOfEnergyEU">ofrd:ratingOfEnergyEU</a>
    /// </summary>
    let ratingOfEnergyEU = _prefixId.prefix "ratingOfEnergyEU"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies the maximum temperature that the freezer unit can reach. The temperature is indicated using a number of stars. Each star corresponds to a -6 degree celsius increment.</para>
    ///   <para>rdfs:label : Rating of stars</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#ratingOfStars">ofrd:ratingOfStars</a>
    /// </summary>
    let ratingOfStars = _prefixId.prefix "ratingOfStars"
    /// <summary>
    ///   <para>rdfs:label : Remote control</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer can be controlled remotely via an external electronic device (smartphone, computer, etc.) system or not.</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#remoteControl">ofrd:remoteControl</a>
    /// </summary>
    let remoteControl = _prefixId.prefix "remoteControl"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:label : Reversible door</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with doors that can be mounted on either side of the unit or not.</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#reversibleDoor">ofrd:reversibleDoor</a>
    /// </summary>
    let reversibleDoor = _prefixId.prefix "reversibleDoor"
    /// <summary>
    ///   <para>rdfs:comment : The type of door that the fridge/freezer is equipped with.</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : Style of unit</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#styleOfUnit">ofrd:styleOfUnit</a>
    /// </summary>
    let styleOfUnit = _prefixId.prefix "styleOfUnit"
    /// <summary>
    ///   <para>rdfs:label : Type of body</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : The type of body frame that the fridge/freezer is equipped with.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#typeOfBody">ofrd:typeOfBody</a>
    /// </summary>
    let typeOfBody = _prefixId.prefix "typeOfBody"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : Volume of freezer</para>
    ///   <para>http://purl.org/opdm/utility#recommendedUnitOfMeasure : LTR^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:comment : The volume in liters of the frozen goods compartment built-into the full fridge/freezer unit.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#volumeOfFreezer">ofrd:volumeOfFreezer</a>
    /// </summary>
    let volumeOfFreezer = _prefixId.prefix "volumeOfFreezer"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:label : Volume of fridge</para>
    ///   <para>http://purl.org/opdm/utility#recommendedUnitOfMeasure : LTR^^xsd:string</para>
    ///   <para>rdfs:comment : The volume in liters of the fresh goods compartment built-into the full fridge/freezer unit.</para>
    ///   <a href="http://purl.org/opdm/refrigerator#volumeOfFridge">ofrd:volumeOfFridge</a>
    /// </summary>
    let volumeOfFridge = _prefixId.prefix "volumeOfFridge"
    /// <summary>
    ///   <para>rdfs:comment : The gross volume in liters of the total unit.</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : Volume of unit gross</para>
    ///   <para>http://purl.org/opdm/utility#recommendedUnitOfMeasure : LTR^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#volumeOfUnitGross">ofrd:volumeOfUnitGross</a>
    /// </summary>
    let volumeOfUnitGross = _prefixId.prefix "volumeOfUnitGross"
    /// <summary>
    ///   <para>rdfs:label : Volume of unit net</para>
    ///   <para>rdfs:comment : The net volume in liters of the total unit. The value of this property usually is equal to the sum of the value of the properties ofrd:volumeOfFridge and ofrd:volumeOfFreezer</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#recommendedUnitOfMeasure : LTR^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#volumeOfUnitNet">ofrd:volumeOfUnitNet</a>
    /// </summary>
    let volumeOfUnitNet = _prefixId.prefix "volumeOfUnitNet"
    /// <summary>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>rdfs:label : Water dispenser</para>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with a water dispenser system or not.</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <a href="http://purl.org/opdm/refrigerator#waterDispenser">ofrd:waterDispenser</a>
    /// </summary>
    let waterDispenser = _prefixId.prefix "waterDispenser"
    /// <summary>
    ///   <para>rdfs:comment : This property specifies whether the fridge/freezer is equipped with a water filtration system or not.</para>
    ///   <para>http://purl.org/opdm/utility#minCardinality : 0^^xsd:string</para>
    ///   <para>http://purl.org/opdm/utility#maxCardinality : 1^^xsd:string</para>
    ///   <para>rdfs:label : Water filtration</para>
    ///   <a href="http://purl.org/opdm/refrigerator#waterFiltration">ofrd:waterFiltration</a>
    /// </summary>
    let waterFiltration = _prefixId.prefix "waterFiltration"
