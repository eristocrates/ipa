namespace http.purl.org.opdm.refrigerator.hash

open DoxAletheia.Rdf_Vocabulary

module ofrd =
    let _namespace_name = "http://purl.org/opdm/refrigerator#"

    /// <summary>
    /// It represents a bottom freezer door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#BottomFreezer"></see></summary>
    let BottomFreezer =
        Namespaced_IRI.parse _namespace_name "BottomFreezer" |> NamespacedName

    /// <summary>
    /// Class to represent the different styles of fridge/freezers. Possible values include: french-door, side-by-side, top-freezer, bottom-freezer, single-door.
    /// <see href="http://purl.org/opdm/refrigerator#StyleOfUnit"></see></summary>
    let StyleOfUnit =
        Namespaced_IRI.parse _namespace_name "StyleOfUnit" |> NamespacedName

    /// <summary>
    /// It represents a bult-in type of body frame for a fridge/freezer.
    /// <see href="http://purl.org/opdm/refrigerator#BuiltIn"></see></summary>
    let BuiltIn = Namespaced_IRI.parse _namespace_name "BuiltIn" |> NamespacedName
    /// <summary>
    /// Class to represent the different types of body frames of a fridge/freezer. Possible values include: built-in, free-standing.
    /// <see href="http://purl.org/opdm/refrigerator#TypeOfBody"></see></summary>
    let TypeOfBody = Namespaced_IRI.parse _namespace_name "TypeOfBody" |> NamespacedName
    /// <summary>
    /// It represents a chest type of body frame for a fridge/freezer.
    /// <see href="http://purl.org/opdm/refrigerator#Chest"></see></summary>
    let Chest = Namespaced_IRI.parse _namespace_name "Chest" |> NamespacedName

    /// <summary>
    /// Class to represent the range of room temperatures that a fridge/freezer can operate. Possible values include: N, SN, ST, T.
    /// <see href="http://purl.org/opdm/refrigerator#ClimateClass"></see></summary>
    let ClimateClass =
        Namespaced_IRI.parse _namespace_name "ClimateClass" |> NamespacedName

    /// <summary>
    /// This concept represents the N climate class rating. The fridge/freezer can operate between 16 - 32 degree celsius of room temperature
    /// <see href="http://purl.org/opdm/refrigerator#ClimateN"></see></summary>
    let ClimateN = Namespaced_IRI.parse _namespace_name "ClimateN" |> NamespacedName
    /// <summary>
    /// This concept represents the SN climate class rating. The fridge/freezer can operate between 10 - 32 degree celsius of room temperature
    /// <see href="http://purl.org/opdm/refrigerator#ClimateSN"></see></summary>
    let ClimateSN = Namespaced_IRI.parse _namespace_name "ClimateSN" |> NamespacedName
    /// <summary>
    /// This concept represents the ST climate class rating. The fridge/freezer can operate between 18 - 38 degree celsius of room temperature
    /// <see href="http://purl.org/opdm/refrigerator#ClimateST"></see></summary>
    let ClimateST = Namespaced_IRI.parse _namespace_name "ClimateST" |> NamespacedName
    /// <summary>
    /// This concept represents the T climate class rating. The fridge/freezer can operate between 18 - 43 degree celsius of room temperature
    /// <see href="http://purl.org/opdm/refrigerator#ClimateT"></see></summary>
    let ClimateT = Namespaced_IRI.parse _namespace_name "ClimateT" |> NamespacedName
    /// <summary>
    /// This concept represents the A energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyA"></see></summary>
    let EnergyA = Namespaced_IRI.parse _namespace_name "EnergyA" |> NamespacedName

    /// <summary>
    /// Class to represent the European Union energy label codas of a fridge. Possible values go from A+++ to G.
    /// <see href="http://purl.org/opdm/refrigerator#EnergyRatingEU"></see></summary>
    let EnergyRatingEU =
        Namespaced_IRI.parse _namespace_name "EnergyRatingEU" |> NamespacedName

    /// <summary>
    /// This concept represents the A+ energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyA1"></see></summary>
    let EnergyA1 = Namespaced_IRI.parse _namespace_name "EnergyA1" |> NamespacedName
    /// <summary>
    /// This concept represents the A++ energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyA2"></see></summary>
    let EnergyA2 = Namespaced_IRI.parse _namespace_name "EnergyA2" |> NamespacedName
    /// <summary>
    /// This concept represents the A+++ energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyA3"></see></summary>
    let EnergyA3 = Namespaced_IRI.parse _namespace_name "EnergyA3" |> NamespacedName
    /// <summary>
    /// This concept represents the B energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyB"></see></summary>
    let EnergyB = Namespaced_IRI.parse _namespace_name "EnergyB" |> NamespacedName
    /// <summary>
    /// This concept represents the C energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyC"></see></summary>
    let EnergyC = Namespaced_IRI.parse _namespace_name "EnergyC" |> NamespacedName
    /// <summary>
    /// This concept represents the D energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyD"></see></summary>
    let EnergyD = Namespaced_IRI.parse _namespace_name "EnergyD" |> NamespacedName
    /// <summary>
    /// This concept represents the E energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyE"></see></summary>
    let EnergyE = Namespaced_IRI.parse _namespace_name "EnergyE" |> NamespacedName
    /// <summary>
    /// This concept represents the F energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyF"></see></summary>
    let EnergyF = Namespaced_IRI.parse _namespace_name "EnergyF" |> NamespacedName
    /// <summary>
    /// This concept represents the G energy efficiency rating in the European Union labelling scheme
    /// <see href="http://purl.org/opdm/refrigerator#EnergyG"></see></summary>
    let EnergyG = Namespaced_IRI.parse _namespace_name "EnergyG" |> NamespacedName

    /// <summary>
    /// It represents a free-standing type of body frame for a fridge/freezer.
    /// <see href="http://purl.org/opdm/refrigerator#FreeStanding"></see></summary>
    let FreeStanding =
        Namespaced_IRI.parse _namespace_name "FreeStanding" |> NamespacedName

    /// <summary>
    /// A generic dedicated Freezer (with no Fridge unit) as a product type
    /// <see href="http://purl.org/opdm/refrigerator#Freezer"></see></summary>
    let Freezer = Namespaced_IRI.parse _namespace_name "Freezer" |> NamespacedName

    /// <summary>
    /// A generic Fridge/Freezer as a product type
    /// <see href="http://purl.org/opdm/refrigerator#FridgeFreezer"></see></summary>
    let FridgeFreezer =
        Namespaced_IRI.parse _namespace_name "FridgeFreezer" |> NamespacedName

    /// <summary>
    /// It represents a french-door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#FrenchDoor"></see></summary>
    let FrenchDoor = Namespaced_IRI.parse _namespace_name "FrenchDoor" |> NamespacedName
    /// <summary>
    /// A generic Fridge with no Freezer unit as a product type
    /// <see href="http://purl.org/opdm/refrigerator#Fridge"></see></summary>
    let Fridge = Namespaced_IRI.parse _namespace_name "Fridge" |> NamespacedName
    /// <summary>
    /// It represents the relative direction: left.
    /// <see href="http://purl.org/opdm/refrigerator#Left"></see></summary>
    let Left = Namespaced_IRI.parse _namespace_name "Left" |> NamespacedName

    /// <summary>
    /// Class to represent the most common relative directions. Possible values include: left, right, forward, backward, up, down.
    /// <see href="http://purl.org/opdm/refrigerator#RelativeDirection"></see></summary>
    let RelativeDirection =
        Namespaced_IRI.parse _namespace_name "RelativeDirection" |> NamespacedName

    /// <summary>
    /// It represents the relative direction: right.
    /// <see href="http://purl.org/opdm/refrigerator#Right"></see></summary>
    let Right = Namespaced_IRI.parse _namespace_name "Right" |> NamespacedName
    /// <summary>
    /// It represents a side-by-side door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#SideBySide"></see></summary>
    let SideBySide = Namespaced_IRI.parse _namespace_name "SideBySide" |> NamespacedName
    /// <summary>
    /// It represents a freezer-less door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#SingleDoor"></see></summary>
    let SingleDoor = Namespaced_IRI.parse _namespace_name "SingleDoor" |> NamespacedName
    /// <summary>
    /// It represents a top freezer door type of fridge.
    /// <see href="http://purl.org/opdm/refrigerator#TopFreezer"></see></summary>
    let TopFreezer = Namespaced_IRI.parse _namespace_name "TopFreezer" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an antibacterial detector system or not.
    /// <see href="http://purl.org/opdm/refrigerator#antibacterial"></see></summary>
    let antibacterial =
        Namespaced_IRI.parse _namespace_name "antibacterial" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an Advanced Control System (ACS) or not. ACS allows the fridge/freezer to maintain the desired internal temperature safe from variations in the external termperature.
    /// <see href="http://purl.org/opdm/refrigerator#capableOfACS"></see></summary>
    let capableOfACS =
        Namespaced_IRI.parse _namespace_name "capableOfACS" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a child lock system or not.
    /// <see href="http://purl.org/opdm/refrigerator#childLock"></see></summary>
    let childLock = Namespaced_IRI.parse _namespace_name "childLock" |> NamespacedName

    /// <summary>
    /// The consumption of energy of the fridge/freezer in kilowatt hour (in a year) - UN/CEFACT common code: KWH.
    /// <see href="http://purl.org/opdm/refrigerator#consumptionOfEnergy"></see></summary>
    let consumptionOfEnergy =
        Namespaced_IRI.parse _namespace_name "consumptionOfEnergy" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an electronic display system or not.
    /// <see href="http://purl.org/opdm/refrigerator#display"></see></summary>
    let display = Namespaced_IRI.parse _namespace_name "display" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a door-open alarm system or not.
    /// <see href="http://purl.org/opdm/refrigerator#doorOpenAlarm"></see></summary>
    let doorOpenAlarm =
        Namespaced_IRI.parse _namespace_name "doorOpenAlarm" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is certified with the Energy Star label awarded by the Department of Energy and Enviromental Protection Agency of the US, or not.
    /// <see href="http://purl.org/opdm/refrigerator#energyStarUS"></see></summary>
    let energyStarUS =
        Namespaced_IRI.parse _namespace_name "energyStarUS" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a frost-free system or not.
    /// <see href="http://purl.org/opdm/refrigerator#frostFree"></see></summary>
    let frostFree = Namespaced_IRI.parse _namespace_name "frostFree" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an ice dispenser system or not.
    /// <see href="http://purl.org/opdm/refrigerator#iceDispenser"></see></summary>
    let iceDispenser =
        Namespaced_IRI.parse _namespace_name "iceDispenser" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with an ice-maker system or not.
    /// <see href="http://purl.org/opdm/refrigerator#iceMaker"></see></summary>
    let iceMaker = Namespaced_IRI.parse _namespace_name "iceMaker" |> NamespacedName

    /// <summary>
    /// The level of noise in decibels of the fridge/freezer (UN/CEFACT common code: 2N).
    /// <see href="http://purl.org/opdm/refrigerator#levelOfNoise"></see></summary>
    let levelOfNoise =
        Namespaced_IRI.parse _namespace_name "levelOfNoise" |> NamespacedName

    /// <summary>
    /// This property specifies the number of compartments that the freezer is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#numberOfFreezerCompartments"></see></summary>
    let numberOfFreezerCompartments =
        Namespaced_IRI.parse _namespace_name "numberOfFreezerCompartments" |> NamespacedName

    /// <summary>
    /// This property specifies the number of shelves or levels that the fridge is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#numberOfFridgeShelves"></see></summary>
    let numberOfFridgeShelves =
        Namespaced_IRI.parse _namespace_name "numberOfFridgeShelves" |> NamespacedName

    /// <summary>
    /// This property specifies the number of front doors that the fridge is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#numberOfFrontDoors"></see></summary>
    let numberOfFrontDoors =
        Namespaced_IRI.parse _namespace_name "numberOfFrontDoors" |> NamespacedName

    /// <summary>
    /// This property specifies the number of front drawers that the fridge is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#numberOfFrontDrawers"></see></summary>
    let numberOfFrontDrawers =
        Namespaced_IRI.parse _namespace_name "numberOfFrontDrawers" |> NamespacedName

    /// <summary>
    /// The position of the door hinge of the fridge/freezer unit.
    /// <see href="http://purl.org/opdm/refrigerator#positionOfDoorHinge"></see></summary>
    let positionOfDoorHinge =
        Namespaced_IRI.parse _namespace_name "positionOfDoorHinge" |> NamespacedName

    /// <summary>
    /// The power supply requirements in volts of the fridge/freezer unit (UN/CEFACT common code: VLT). Optionally, this property can be complemented with a gr:valueReference property to indicate the frecuency that the power supply operates at in Hertz (UN/CEFACT common code: HTZ).
    /// <see href="http://purl.org/opdm/refrigerator#powerSupply"></see></summary>
    let powerSupply =
        Namespaced_IRI.parse _namespace_name "powerSupply" |> NamespacedName

    /// <summary>
    /// The climate class rating that the fridge/freezer can operate at.
    /// <see href="http://purl.org/opdm/refrigerator#ratingOfClimateClass"></see></summary>
    let ratingOfClimateClass =
        Namespaced_IRI.parse _namespace_name "ratingOfClimateClass" |> NamespacedName

    /// <summary>
    /// The rating of energy efficiency in the European Union that the fridge/freezer operates at.
    /// <see href="http://purl.org/opdm/refrigerator#ratingOfEnergyEU"></see></summary>
    let ratingOfEnergyEU =
        Namespaced_IRI.parse _namespace_name "ratingOfEnergyEU" |> NamespacedName

    /// <summary>
    /// This property specifies the maximum temperature that the freezer unit can reach. The temperature is indicated using a number of stars. Each star corresponds to a -6 degree celsius increment.
    /// <see href="http://purl.org/opdm/refrigerator#ratingOfStars"></see></summary>
    let ratingOfStars =
        Namespaced_IRI.parse _namespace_name "ratingOfStars" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer can be controlled remotely via an external electronic device (smartphone, computer, etc.) system or not.
    /// <see href="http://purl.org/opdm/refrigerator#remoteControl"></see></summary>
    let remoteControl =
        Namespaced_IRI.parse _namespace_name "remoteControl" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with doors that can be mounted on either side of the unit or not.
    /// <see href="http://purl.org/opdm/refrigerator#reversibleDoor"></see></summary>
    let reversibleDoor =
        Namespaced_IRI.parse _namespace_name "reversibleDoor" |> NamespacedName

    /// <summary>
    /// The type of door that the fridge/freezer is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#styleOfUnit"></see></summary>
    let styleOfUnit =
        Namespaced_IRI.parse _namespace_name "styleOfUnit" |> NamespacedName

    /// <summary>
    /// The type of body frame that the fridge/freezer is equipped with.
    /// <see href="http://purl.org/opdm/refrigerator#typeOfBody"></see></summary>
    let typeOfBody = Namespaced_IRI.parse _namespace_name "typeOfBody" |> NamespacedName

    /// <summary>
    /// The volume in liters of the frozen goods compartment built-into the full fridge/freezer unit.
    /// <see href="http://purl.org/opdm/refrigerator#volumeOfFreezer"></see></summary>
    let volumeOfFreezer =
        Namespaced_IRI.parse _namespace_name "volumeOfFreezer" |> NamespacedName

    /// <summary>
    /// The volume in liters of the fresh goods compartment built-into the full fridge/freezer unit.
    /// <see href="http://purl.org/opdm/refrigerator#volumeOfFridge"></see></summary>
    let volumeOfFridge =
        Namespaced_IRI.parse _namespace_name "volumeOfFridge" |> NamespacedName

    /// <summary>
    /// The gross volume in liters of the total unit.
    /// <see href="http://purl.org/opdm/refrigerator#volumeOfUnitGross"></see></summary>
    let volumeOfUnitGross =
        Namespaced_IRI.parse _namespace_name "volumeOfUnitGross" |> NamespacedName

    /// <summary>
    /// The net volume in liters of the total unit. The value of this property usually is equal to the sum of the value of the properties ofrd:volumeOfFridge and ofrd:volumeOfFreezer
    /// <see href="http://purl.org/opdm/refrigerator#volumeOfUnitNet"></see></summary>
    let volumeOfUnitNet =
        Namespaced_IRI.parse _namespace_name "volumeOfUnitNet" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a water dispenser system or not.
    /// <see href="http://purl.org/opdm/refrigerator#waterDispenser"></see></summary>
    let waterDispenser =
        Namespaced_IRI.parse _namespace_name "waterDispenser" |> NamespacedName

    /// <summary>
    /// This property specifies whether the fridge/freezer is equipped with a water filtration system or not.
    /// <see href="http://purl.org/opdm/refrigerator#waterFiltration"></see></summary>
    let waterFiltration =
        Namespaced_IRI.parse _namespace_name "waterFiltration" |> NamespacedName
