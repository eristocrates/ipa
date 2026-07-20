namespace http.purl.org.opdm.refrigerator.hash

open DoxAletheia

module ofrd =
    let _namespace_name = "http://purl.org/opdm/refrigerator#"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    /// It represents a bottom freezer door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#BottomFreezer"></see></summary>
    let BottomFreezer = _prefix "BottomFreezer"
    /// <summary>
    /// Class to represent the different styles of fridge/freezers. Possible values include: french-door, side-by-side, top-freezer, bottom-freezer, single-door.
    /// <see href="http://purl.org/opdm/refrigerator#StyleOfUnit"></see></summary>
    let StyleOfUnit = _prefix "StyleOfUnit"
    /// <summary>
    /// It represents a bult-in type of body frame for a fridge/freezer.
    /// <see href="http://purl.org/opdm/refrigerator#BuiltIn"></see></summary>
    let BuiltIn = _prefix "BuiltIn"
    /// <summary>
    /// Class to represent the different types of body frames of a fridge/freezer. Possible values include: built-in, free-standing.
    /// <see href="http://purl.org/opdm/refrigerator#TypeOfBody"></see></summary>
    let TypeOfBody = _prefix "TypeOfBody"
    /// <summary>
    /// It represents a chest type of body frame for a fridge/freezer.
    /// <see href="http://purl.org/opdm/refrigerator#Chest"></see></summary>
    let Chest = _prefix "Chest"
    /// <summary>
    /// Class to represent the range of room temperatures that a fridge/freezer can operate. Possible values include: N, SN, ST, T.
    /// <see href="http://purl.org/opdm/refrigerator#ClimateClass"></see></summary>
    let ClimateClass = _prefix "ClimateClass"
    /// <summary>
    /// This concept represents the N climate class rating. The fridge/freezer can operate between 16 - 32 degree celsius of room temperature
    /// <see href="http://purl.org/opdm/refrigerator#ClimateN"></see></summary>
    let ClimateN = _prefix "ClimateN"
    /// <summary>
    /// This concept represents the SN climate class rating. The fridge/freezer can operate between 10 - 32 degree celsius of room temperature
    /// <see href="http://purl.org/opdm/refrigerator#ClimateSN"></see></summary>
    let ClimateSN = _prefix "ClimateSN"
    /// <summary>
    /// This concept represents the ST climate class rating. The fridge/freezer can operate between 18 - 38 degree celsius of room temperature
    /// <see href="http://purl.org/opdm/refrigerator#ClimateST"></see></summary>
    let ClimateST = _prefix "ClimateST"
    /// <summary>
    /// This concept represents the T climate class rating. The fridge/freezer can operate between 18 - 43 degree celsius of room temperature
    /// <see href="http://purl.org/opdm/refrigerator#ClimateT"></see></summary>
    let ClimateT = _prefix "ClimateT"
    /// <summary>
    /// This concept represents the A energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyA"></see></summary>
    let EnergyA = _prefix "EnergyA"
    /// <summary>
    /// Class to represent the European Union energy label codas of a fridge. Possible values go from A+++ to G.
    /// <see href="http://purl.org/opdm/refrigerator#EnergyRatingEU"></see></summary>
    let EnergyRatingEU = _prefix "EnergyRatingEU"
    /// <summary>
    /// This concept represents the A+ energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyA1"></see></summary>
    let EnergyA1 = _prefix "EnergyA1"
    /// <summary>
    /// This concept represents the A++ energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyA2"></see></summary>
    let EnergyA2 = _prefix "EnergyA2"
    /// <summary>
    /// This concept represents the A+++ energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyA3"></see></summary>
    let EnergyA3 = _prefix "EnergyA3"
    /// <summary>
    /// This concept represents the B energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyB"></see></summary>
    let EnergyB = _prefix "EnergyB"
    /// <summary>
    /// This concept represents the C energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyC"></see></summary>
    let EnergyC = _prefix "EnergyC"
    /// <summary>
    /// This concept represents the D energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyD"></see></summary>
    let EnergyD = _prefix "EnergyD"
    /// <summary>
    /// This concept represents the E energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyE"></see></summary>
    let EnergyE = _prefix "EnergyE"
    /// <summary>
    /// This concept represents the F energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyF"></see></summary>
    let EnergyF = _prefix "EnergyF"
    /// <summary>
    /// This concept represents the G energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyG"></see></summary>
    let EnergyG = _prefix "EnergyG"
    /// <summary>
    /// It represents a free-standing type of body frame for a fridge/freezer.
    /// <see href="http://purl.org/opdm/refrigerator#FreeStanding"></see></summary>
    let FreeStanding = _prefix "FreeStanding"
    /// <summary>
    /// A generic dedicated Freezer (with no Fridge unit) as a product type
    /// <see href="http://purl.org/opdm/refrigerator#Freezer"></see></summary>
    let Freezer = _prefix "Freezer"
    /// <summary>
    /// A generic Fridge/Freezer as a product type
    /// <see href="http://purl.org/opdm/refrigerator#FridgeFreezer"></see></summary>
    let FridgeFreezer = _prefix "FridgeFreezer"
    /// <summary>
    /// It represents a french-door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#FrenchDoor"></see></summary>
    let FrenchDoor = _prefix "FrenchDoor"
    /// <summary>
    /// A generic Fridge with no Freezer unit as a product type
    /// <see href="http://purl.org/opdm/refrigerator#Fridge"></see></summary>
    let Fridge = _prefix "Fridge"
    /// <summary>
    /// It represents the relative direction: left.
    /// <see href="http://purl.org/opdm/refrigerator#Left"></see></summary>
    let Left = _prefix "Left"
    /// <summary>
    /// Class to represent the most common relative directions. Possible values include: left, right, forward, backward, up, down.
    /// <see href="http://purl.org/opdm/refrigerator#RelativeDirection"></see></summary>
    let RelativeDirection = _prefix "RelativeDirection"
    /// <summary>
    /// It represents the relative direction: right.
    /// <see href="http://purl.org/opdm/refrigerator#Right"></see></summary>
    let Right = _prefix "Right"
    /// <summary>
    /// It represents a side-by-side door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#SideBySide"></see></summary>
    let SideBySide = _prefix "SideBySide"
    /// <summary>
    /// It represents a freezer-less door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#SingleDoor"></see></summary>
    let SingleDoor = _prefix "SingleDoor"
    /// <summary>
    /// It represents a top freezer door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#TopFreezer"></see></summary>
    let TopFreezer = _prefix "TopFreezer"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an antibacterial detector system or not.
    /// <see href="http://purl.org/opdm/refrigerator#antibacterial"></see></summary>
    let antibacterial = _prefix "antibacterial"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an Advanced Control System (ACS) or not. ACS allows the fridge/freezer to maintain the desired internal temperature safe from variations in the external termperature.
    /// <see href="http://purl.org/opdm/refrigerator#capableOfACS"></see></summary>
    let capableOfACS = _prefix "capableOfACS"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a child lock system or not.
    /// <see href="http://purl.org/opdm/refrigerator#childLock"></see></summary>
    let childLock = _prefix "childLock"
    /// <summary>
    /// The consumption of energy of the fridge/freezer in kilowatt hour (in a year) - UN/CEFACT common code: KWH.
    /// <see href="http://purl.org/opdm/refrigerator#consumptionOfEnergy"></see></summary>
    let consumptionOfEnergy = _prefix "consumptionOfEnergy"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an electronic display system or not.
    /// <see href="http://purl.org/opdm/refrigerator#display"></see></summary>
    let display = _prefix "display"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a door-open alarm system or not.
    /// <see href="http://purl.org/opdm/refrigerator#doorOpenAlarm"></see></summary>
    let doorOpenAlarm = _prefix "doorOpenAlarm"
    /// <summary>
    /// This property specifies whether the fridge/freezer is certified with the Energy Star label awarded by the Department of Energy and Enviromental Protection Agency of the US, or not.
    /// <see href="http://purl.org/opdm/refrigerator#energyStarUS"></see></summary>
    let energyStarUS = _prefix "energyStarUS"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a frost-free system or not.
    /// <see href="http://purl.org/opdm/refrigerator#frostFree"></see></summary>
    let frostFree = _prefix "frostFree"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an ice dispenser system or not.
    /// <see href="http://purl.org/opdm/refrigerator#iceDispenser"></see></summary>
    let iceDispenser = _prefix "iceDispenser"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an ice-maker system or not.
    /// <see href="http://purl.org/opdm/refrigerator#iceMaker"></see></summary>
    let iceMaker = _prefix "iceMaker"
    /// <summary>
    /// The level of noise in decibels of the fridge/freezer (UN/CEFACT common code: 2N).
    /// <see href="http://purl.org/opdm/refrigerator#levelOfNoise"></see></summary>
    let levelOfNoise = _prefix "levelOfNoise"
    /// <summary>
    /// This property specifies the number of compartments that the freezer is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#numberOfFreezerCompartments"></see></summary>
    let numberOfFreezerCompartments = _prefix "numberOfFreezerCompartments"
    /// <summary>
    /// This property specifies the number of shelves or levels that the fridge is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#numberOfFridgeShelves"></see></summary>
    let numberOfFridgeShelves = _prefix "numberOfFridgeShelves"
    /// <summary>
    /// This property specifies the number of front doors that the fridge is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#numberOfFrontDoors"></see></summary>
    let numberOfFrontDoors = _prefix "numberOfFrontDoors"
    /// <summary>
    /// This property specifies the number of front drawers that the fridge is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#numberOfFrontDrawers"></see></summary>
    let numberOfFrontDrawers = _prefix "numberOfFrontDrawers"
    /// <summary>
    /// The position of the door hinge of the fridge/freezer unit.
    /// <see href="http://purl.org/opdm/refrigerator#positionOfDoorHinge"></see></summary>
    let positionOfDoorHinge = _prefix "positionOfDoorHinge"
    /// <summary>
    /// The power supply requirements in volts of the fridge/freezer unit (UN/CEFACT common code: VLT). Optionally, this property can be complemented with a gr:valueReference property to indicate the frecuency that the power supply operates at in Hertz (UN/CEFACT common code: HTZ).
    /// <see href="http://purl.org/opdm/refrigerator#powerSupply"></see></summary>
    let powerSupply = _prefix "powerSupply"
    /// <summary>
    /// The climate class rating that the fridge/freezer can operate at.
    /// <see href="http://purl.org/opdm/refrigerator#ratingOfClimateClass"></see></summary>
    let ratingOfClimateClass = _prefix "ratingOfClimateClass"
    /// <summary>
    /// The rating of energy efficiency in the European Union that the fridge/freezer operates at.
    /// <see href="http://purl.org/opdm/refrigerator#ratingOfEnergyEU"></see></summary>
    let ratingOfEnergyEU = _prefix "ratingOfEnergyEU"
    /// <summary>
    /// This property specifies the maximum temperature that the freezer unit can reach. The temperature is indicated using a number of stars. Each star corresponds to a -6 degree celsius increment.
    /// <see href="http://purl.org/opdm/refrigerator#ratingOfStars"></see></summary>
    let ratingOfStars = _prefix "ratingOfStars"
    /// <summary>
    /// This property specifies whether the fridge/freezer can be controlled remotely via an external electronic device (smartphone, computer, etc.) system or not.
    /// <see href="http://purl.org/opdm/refrigerator#remoteControl"></see></summary>
    let remoteControl = _prefix "remoteControl"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with doors that can be mounted on either side of the unit or not.
    /// <see href="http://purl.org/opdm/refrigerator#reversibleDoor"></see></summary>
    let reversibleDoor = _prefix "reversibleDoor"
    /// <summary>
    /// The type of door that the fridge/freezer is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#styleOfUnit"></see></summary>
    let styleOfUnit = _prefix "styleOfUnit"
    /// <summary>
    /// The type of body frame that the fridge/freezer is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#typeOfBody"></see></summary>
    let typeOfBody = _prefix "typeOfBody"
    /// <summary>
    /// The volume in liters of the frozen goods compartment built-into the full fridge/freezer unit.
    /// <see href="http://purl.org/opdm/refrigerator#volumeOfFreezer"></see></summary>
    let volumeOfFreezer = _prefix "volumeOfFreezer"
    /// <summary>
    /// The volume in liters of the fresh goods compartment built-into the full fridge/freezer unit.
    /// <see href="http://purl.org/opdm/refrigerator#volumeOfFridge"></see></summary>
    let volumeOfFridge = _prefix "volumeOfFridge"
    /// <summary>
    /// The gross volume in liters of the total unit.
    /// <see href="http://purl.org/opdm/refrigerator#volumeOfUnitGross"></see></summary>
    let volumeOfUnitGross = _prefix "volumeOfUnitGross"
    /// <summary>
    /// The net volume in liters of the total unit. The value of this property usually is equal to the sum of the value of the properties ofrd:volumeOfFridge and ofrd:volumeOfFreezer
    /// <see href="http://purl.org/opdm/refrigerator#volumeOfUnitNet"></see></summary>
    let volumeOfUnitNet = _prefix "volumeOfUnitNet"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a water dispenser system or not.
    /// <see href="http://purl.org/opdm/refrigerator#waterDispenser"></see></summary>
    let waterDispenser = _prefix "waterDispenser"
    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a water filtration system or not.
    /// <see href="http://purl.org/opdm/refrigerator#waterFiltration"></see></summary>
    let waterFiltration = _prefix "waterFiltration"
