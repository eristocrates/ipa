namespace http.purl.org.opdm.refrigerator.hash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module ofrd =
    let _namespace_iri = Namespace_Iri ofrd |> NamespaceIRI
    /// <summary>
    ///   <para>ofrd:</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Ontology</para>
    ///   <para>"Vocabulary to describe fridges and freezers"</para>
    /// labels<para>"Fridge and Freezer Vocabulary"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#">http://purl.org/opdm/refrigerator#</seealso>
    let _prefix_iri = Prefixed_Name(ofrd, "") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:BottomFreezer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:StyleOfUnit</para>
    ///   <para>"It represents a bottom freezer door type of fridge."</para>
    /// labels<para>"BottomFreezerDoor"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#BottomFreezer">http://purl.org/opdm/refrigerator#BottomFreezer</seealso>
    let BottomFreezer = Prefixed_Name(ofrd, "BottomFreezer") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:BuiltIn</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:TypeOfBody</para>
    ///   <para>"It represents a bult-in type of body frame for a fridge/freezer."</para>
    /// labels<para>"BuiltIn"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#BuiltIn">http://purl.org/opdm/refrigerator#BuiltIn</seealso>
    let BuiltIn = Prefixed_Name(ofrd, "BuiltIn") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:Chest</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:TypeOfBody</para>
    ///   <para>"It represents a chest type of body frame for a fridge/freezer."</para>
    /// labels<para>"Chest"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#Chest">http://purl.org/opdm/refrigerator#Chest</seealso>
    let Chest = Prefixed_Name(ofrd, "Chest") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:ClimateClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class to represent the range of room temperatures that a fridge/freezer can operate. Possible values include: N, SN, ST, T."</para>
    /// labels<para>"ClimateClass"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#ClimateClass">http://purl.org/opdm/refrigerator#ClimateClass</seealso>
    let ClimateClass = Prefixed_Name(ofrd, "ClimateClass") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:ClimateN</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:ClimateClass</para>
    ///   <para>"This concept represents the N climate class rating. The fridge/freezer can operate between 16 - 32 degree celsius of room temperature"</para>
    /// labels<para>"N Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#ClimateN">http://purl.org/opdm/refrigerator#ClimateN</seealso>
    let ClimateN = Prefixed_Name(ofrd, "ClimateN") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:ClimateSN</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:ClimateClass</para>
    ///   <para>"This concept represents the SN climate class rating. The fridge/freezer can operate between 10 - 32 degree celsius of room temperature"</para>
    /// labels<para>"SN Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#ClimateSN">http://purl.org/opdm/refrigerator#ClimateSN</seealso>
    let ClimateSN = Prefixed_Name(ofrd, "ClimateSN") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:ClimateST</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:ClimateClass</para>
    ///   <para>"This concept represents the ST climate class rating. The fridge/freezer can operate between 18 - 38 degree celsius of room temperature"</para>
    /// labels<para>"ST Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#ClimateST">http://purl.org/opdm/refrigerator#ClimateST</seealso>
    let ClimateST = Prefixed_Name(ofrd, "ClimateST") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:ClimateT</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:ClimateClass</para>
    ///   <para>"This concept represents the T climate class rating. The fridge/freezer can operate between 18 - 43 degree celsius of room temperature"</para>
    /// labels<para>"T Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#ClimateT">http://purl.org/opdm/refrigerator#ClimateT</seealso>
    let ClimateT = Prefixed_Name(ofrd, "ClimateT") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyA</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the A energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"A Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyA">http://purl.org/opdm/refrigerator#EnergyA</seealso>
    let EnergyA = Prefixed_Name(ofrd, "EnergyA") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyA1</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the A+ energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"A+ Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyA1">http://purl.org/opdm/refrigerator#EnergyA1</seealso>
    let EnergyA1 = Prefixed_Name(ofrd, "EnergyA1") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyA2</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the A++ energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"A++ Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyA2">http://purl.org/opdm/refrigerator#EnergyA2</seealso>
    let EnergyA2 = Prefixed_Name(ofrd, "EnergyA2") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyA3</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the A+++ energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"A+++ Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyA3">http://purl.org/opdm/refrigerator#EnergyA3</seealso>
    let EnergyA3 = Prefixed_Name(ofrd, "EnergyA3") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyB</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the B energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"B Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyB">http://purl.org/opdm/refrigerator#EnergyB</seealso>
    let EnergyB = Prefixed_Name(ofrd, "EnergyB") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyC</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the C energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"C Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyC">http://purl.org/opdm/refrigerator#EnergyC</seealso>
    let EnergyC = Prefixed_Name(ofrd, "EnergyC") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyD</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the D energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"D Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyD">http://purl.org/opdm/refrigerator#EnergyD</seealso>
    let EnergyD = Prefixed_Name(ofrd, "EnergyD") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyE</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the E energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"E Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyE">http://purl.org/opdm/refrigerator#EnergyE</seealso>
    let EnergyE = Prefixed_Name(ofrd, "EnergyE") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyF</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the F energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"F Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyF">http://purl.org/opdm/refrigerator#EnergyF</seealso>
    let EnergyF = Prefixed_Name(ofrd, "EnergyF") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyG</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:EnergyRatingEU</para>
    ///   <para>"This concept represents the G energy efficiency rating in the European Union labelling scheme"</para>
    /// labels<para>"G Rating"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyG">http://purl.org/opdm/refrigerator#EnergyG</seealso>
    let EnergyG = Prefixed_Name(ofrd, "EnergyG") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:EnergyRatingEU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class to represent the European Union energy label codas of a fridge. Possible values go from A+++ to G."</para>
    /// labels<para>"EnergyRatingEU"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#EnergyRatingEU">http://purl.org/opdm/refrigerator#EnergyRatingEU</seealso>
    let EnergyRatingEU = Prefixed_Name(ofrd, "EnergyRatingEU") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:FreeStanding</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:TypeOfBody</para>
    ///   <para>"It represents a free-standing type of body frame for a fridge/freezer."</para>
    /// labels<para>"FreeStanding"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#FreeStanding">http://purl.org/opdm/refrigerator#FreeStanding</seealso>
    let FreeStanding = Prefixed_Name(ofrd, "FreeStanding") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:Freezer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A generic dedicated Freezer (with no Fridge unit) as a product type"</para>
    /// labels<para>"Freezer"</para><para>"Congelador"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#Freezer">http://purl.org/opdm/refrigerator#Freezer</seealso>
    let Freezer = Prefixed_Name(ofrd, "Freezer") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:FrenchDoor</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:StyleOfUnit</para>
    ///   <para>"It represents a french-door type of fridge."</para>
    /// labels<para>"FrenchDoor"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#FrenchDoor">http://purl.org/opdm/refrigerator#FrenchDoor</seealso>
    let FrenchDoor = Prefixed_Name(ofrd, "FrenchDoor") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:Fridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>owl:Class</para>
    ///   <para>"A generic Fridge with no Freezer unit as a product type"</para>
    /// labels<para>"Fridge"</para><para>"Frigorífico"</para><para>"Kühlschrank"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#Fridge">http://purl.org/opdm/refrigerator#Fridge</seealso>
    let Fridge = Prefixed_Name(ofrd, "Fridge") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:FridgeFreezer</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"A generic Fridge/Freezer as a product type"</para>
    /// labels<para>"Frigorífico/Congelador"</para><para>"Kühlschrank"</para><para>"FridgeFreezer"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#FridgeFreezer">http://purl.org/opdm/refrigerator#FridgeFreezer</seealso>
    let FridgeFreezer = Prefixed_Name(ofrd, "FridgeFreezer") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:Left</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:RelativeDirection</para>
    ///   <para>"It represents the relative direction: left."</para>
    /// labels<para>"Left"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#Left">http://purl.org/opdm/refrigerator#Left</seealso>
    let Left = Prefixed_Name(ofrd, "Left") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:RelativeDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class to represent the most common relative directions. Possible values include: left, right, forward, backward, up, down."</para>
    /// labels<para>"RelativeDirection"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#RelativeDirection">http://purl.org/opdm/refrigerator#RelativeDirection</seealso>
    let RelativeDirection = Prefixed_Name(ofrd, "RelativeDirection") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:Right</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:RelativeDirection</para>
    ///   <para>"It represents the relative direction: right."</para>
    /// labels<para>"Right"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#Right">http://purl.org/opdm/refrigerator#Right</seealso>
    let Right = Prefixed_Name(ofrd, "Right") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:SideBySide</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:StyleOfUnit</para>
    ///   <para>"It represents a side-by-side door type of fridge."</para>
    /// labels<para>"SideBySideDoor"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#SideBySide">http://purl.org/opdm/refrigerator#SideBySide</seealso>
    let SideBySide = Prefixed_Name(ofrd, "SideBySide") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:SingleDoor</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:StyleOfUnit</para>
    ///   <para>"It represents a freezer-less door type of fridge."</para>
    /// labels<para>"FreezerlessDoor"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#SingleDoor">http://purl.org/opdm/refrigerator#SingleDoor</seealso>
    let SingleDoor = Prefixed_Name(ofrd, "SingleDoor") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:StyleOfUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class to represent the different styles of fridge/freezers. Possible values include: french-door, side-by-side, top-freezer, bottom-freezer, single-door."</para>
    /// labels<para>"StyleOfUnit"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#StyleOfUnit">http://purl.org/opdm/refrigerator#StyleOfUnit</seealso>
    let StyleOfUnit = Prefixed_Name(ofrd, "StyleOfUnit") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:TopFreezer</para>
    /// </summary>
    /// <remarks>
    ///   <para>ofrd:StyleOfUnit</para>
    ///   <para>"It represents a top freezer door type of fridge."</para>
    /// labels<para>"TopFreezerDoor"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#TopFreezer">http://purl.org/opdm/refrigerator#TopFreezer</seealso>
    let TopFreezer = Prefixed_Name(ofrd, "TopFreezer") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:TypeOfBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>"Class to represent the different types of body frames of a fridge/freezer. Possible values include: built-in, free-standing."</para>
    /// labels<para>"TypeOfBody"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#TypeOfBody">http://purl.org/opdm/refrigerator#TypeOfBody</seealso>
    let TypeOfBody = Prefixed_Name(ofrd, "TypeOfBody") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:antibacterial</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with an antibacterial detector system or not."</para>
    /// labels<para>"Antibacterial"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#antibacterial">http://purl.org/opdm/refrigerator#antibacterial</seealso>
    let antibacterial = Prefixed_Name(ofrd, "antibacterial") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:capableOfACS</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with an Advanced Control System (ACS) or not. ACS allows the fridge/freezer to maintain the desired internal temperature safe from variations in the external termperature."</para>
    /// labels<para>"Capable of ACS"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#capableOfACS">http://purl.org/opdm/refrigerator#capableOfACS</seealso>
    let capableOfACS = Prefixed_Name(ofrd, "capableOfACS") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:childLock</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with a child lock system or not."</para>
    /// labels<para>"Child lock"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#childLock">http://purl.org/opdm/refrigerator#childLock</seealso>
    let childLock = Prefixed_Name(ofrd, "childLock") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:consumptionOfEnergy</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The consumption of energy of the fridge/freezer in kilowatt hour (in a year) - UN/CEFACT common code: KWH."</para>
    /// labels<para>"Consumption of energy"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#consumptionOfEnergy">http://purl.org/opdm/refrigerator#consumptionOfEnergy</seealso>
    let consumptionOfEnergy = Prefixed_Name(ofrd, "consumptionOfEnergy") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:display</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with an electronic display system or not."</para>
    /// labels<para>"Display"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#display">http://purl.org/opdm/refrigerator#display</seealso>
    let display = Prefixed_Name(ofrd, "display") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:doorOpenAlarm</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with a door-open alarm system or not."</para>
    /// labels<para>"Door open alarm"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#doorOpenAlarm">http://purl.org/opdm/refrigerator#doorOpenAlarm</seealso>
    let doorOpenAlarm = Prefixed_Name(ofrd, "doorOpenAlarm") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:energyStarUS</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"This property specifies whether the fridge/freezer is certified with the Energy Star label awarded by the Department of Energy and Enviromental Protection Agency of the US, or not."</para>
    /// labels<para>"Energy Star US"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#energyStarUS">http://purl.org/opdm/refrigerator#energyStarUS</seealso>
    let energyStarUS = Prefixed_Name(ofrd, "energyStarUS") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:frostFree</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with a frost-free system or not."</para>
    /// labels<para>"Frost free"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#frostFree">http://purl.org/opdm/refrigerator#frostFree</seealso>
    let frostFree = Prefixed_Name(ofrd, "frostFree") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:iceDispenser</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with an ice dispenser system or not."</para>
    /// labels<para>"Ice dispenser"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#iceDispenser">http://purl.org/opdm/refrigerator#iceDispenser</seealso>
    let iceDispenser = Prefixed_Name(ofrd, "iceDispenser") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:iceMaker</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with an ice-maker system or not."</para>
    /// labels<para>"Ice maker"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#iceMaker">http://purl.org/opdm/refrigerator#iceMaker</seealso>
    let iceMaker = Prefixed_Name(ofrd, "iceMaker") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:levelOfNoise</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>"The level of noise in decibels of the fridge/freezer (UN/CEFACT common code: 2N)."</para>
    /// labels<para>"Level of noise"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#levelOfNoise">http://purl.org/opdm/refrigerator#levelOfNoise</seealso>
    let levelOfNoise = Prefixed_Name(ofrd, "levelOfNoise") |> PrefixedName

    /// <summary>
    ///   <para>ofrd:numberOfFreezerCompartments</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies the number of compartments that the freezer is equipped with."</para>
    /// labels<para>"Number of freezer compartments"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#numberOfFreezerCompartments">http://purl.org/opdm/refrigerator#numberOfFreezerCompartments</seealso>
    let numberOfFreezerCompartments =
        Prefixed_Name(ofrd, "numberOfFreezerCompartments") |> PrefixedName

    /// <summary>
    ///   <para>ofrd:numberOfFridgeShelves</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"This property specifies the number of shelves or levels that the fridge is equipped with."</para>
    /// labels<para>"Number of fridge shelves"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#numberOfFridgeShelves">http://purl.org/opdm/refrigerator#numberOfFridgeShelves</seealso>
    let numberOfFridgeShelves =
        Prefixed_Name(ofrd, "numberOfFridgeShelves") |> PrefixedName

    /// <summary>
    ///   <para>ofrd:numberOfFrontDoors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"This property specifies the number of front doors that the fridge is equipped with."</para>
    /// labels<para>"Number of front doors"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#numberOfFrontDoors">http://purl.org/opdm/refrigerator#numberOfFrontDoors</seealso>
    let numberOfFrontDoors = Prefixed_Name(ofrd, "numberOfFrontDoors") |> PrefixedName

    /// <summary>
    ///   <para>ofrd:numberOfFrontDrawers</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"This property specifies the number of front drawers that the fridge is equipped with."</para>
    /// labels<para>"Number of front drawers"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#numberOfFrontDrawers">http://purl.org/opdm/refrigerator#numberOfFrontDrawers</seealso>
    let numberOfFrontDrawers =
        Prefixed_Name(ofrd, "numberOfFrontDrawers") |> PrefixedName

    /// <summary>
    ///   <para>ofrd:positionOfDoorHinge</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The position of the door hinge of the fridge/freezer unit."</para>
    /// labels<para>"Position of door hinge"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#positionOfDoorHinge">http://purl.org/opdm/refrigerator#positionOfDoorHinge</seealso>
    let positionOfDoorHinge = Prefixed_Name(ofrd, "positionOfDoorHinge") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:powerSupply</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The power supply requirements in volts of the fridge/freezer unit (UN/CEFACT common code: VLT). Optionally, this property can be complemented with a gr:valueReference property to indicate the frecuency that the power supply operates at in Hertz (UN/CEFACT common code: HTZ)."</para>
    /// labels<para>"Power supply"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#powerSupply">http://purl.org/opdm/refrigerator#powerSupply</seealso>
    let powerSupply = Prefixed_Name(ofrd, "powerSupply") |> PrefixedName

    /// <summary>
    ///   <para>ofrd:ratingOfClimateClass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"The climate class rating that the fridge/freezer can operate at."</para>
    /// labels<para>"Rating of climate class"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#ratingOfClimateClass">http://purl.org/opdm/refrigerator#ratingOfClimateClass</seealso>
    let ratingOfClimateClass =
        Prefixed_Name(ofrd, "ratingOfClimateClass") |> PrefixedName

    /// <summary>
    ///   <para>ofrd:ratingOfEnergyEU</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"The rating of energy efficiency in the European Union that the fridge/freezer operates at."</para>
    /// labels<para>"Rating of energy EU"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#ratingOfEnergyEU">http://purl.org/opdm/refrigerator#ratingOfEnergyEU</seealso>
    let ratingOfEnergyEU = Prefixed_Name(ofrd, "ratingOfEnergyEU") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:ratingOfStars</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>"This property specifies the maximum temperature that the freezer unit can reach. The temperature is indicated using a number of stars. Each star corresponds to a -6 degree celsius increment."</para>
    /// labels<para>"Rating of stars"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#ratingOfStars">http://purl.org/opdm/refrigerator#ratingOfStars</seealso>
    let ratingOfStars = Prefixed_Name(ofrd, "ratingOfStars") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:remoteControl</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the fridge/freezer can be controlled remotely via an external electronic device (smartphone, computer, etc.) system or not."</para>
    /// labels<para>"Remote control"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#remoteControl">http://purl.org/opdm/refrigerator#remoteControl</seealso>
    let remoteControl = Prefixed_Name(ofrd, "remoteControl") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:reversibleDoor</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with doors that can be mounted on either side of the unit or not."</para>
    /// labels<para>"Reversible door"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#reversibleDoor">http://purl.org/opdm/refrigerator#reversibleDoor</seealso>
    let reversibleDoor = Prefixed_Name(ofrd, "reversibleDoor") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:styleOfUnit</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The type of door that the fridge/freezer is equipped with."</para>
    /// labels<para>"Style of unit"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#styleOfUnit">http://purl.org/opdm/refrigerator#styleOfUnit</seealso>
    let styleOfUnit = Prefixed_Name(ofrd, "styleOfUnit") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:typeOfBody</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"The type of body frame that the fridge/freezer is equipped with."</para>
    /// labels<para>"Type of body"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#typeOfBody">http://purl.org/opdm/refrigerator#typeOfBody</seealso>
    let typeOfBody = Prefixed_Name(ofrd, "typeOfBody") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:volumeOfFreezer</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The volume in liters of the frozen goods compartment built-into the full fridge/freezer unit."</para>
    /// labels<para>"Volume of freezer"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#volumeOfFreezer">http://purl.org/opdm/refrigerator#volumeOfFreezer</seealso>
    let volumeOfFreezer = Prefixed_Name(ofrd, "volumeOfFreezer") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:volumeOfFridge</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>"The volume in liters of the fresh goods compartment built-into the full fridge/freezer unit."</para>
    /// labels<para>"Volume of fridge"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#volumeOfFridge">http://purl.org/opdm/refrigerator#volumeOfFridge</seealso>
    let volumeOfFridge = Prefixed_Name(ofrd, "volumeOfFridge") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:volumeOfUnitGross</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>"The gross volume in liters of the total unit."</para>
    /// labels<para>"Volume of unit gross"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#volumeOfUnitGross">http://purl.org/opdm/refrigerator#volumeOfUnitGross</seealso>
    let volumeOfUnitGross = Prefixed_Name(ofrd, "volumeOfUnitGross") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:volumeOfUnitNet</para>
    /// </summary>
    /// <remarks>
    ///   <para>gr:QuantitativeValue</para>
    ///   <para>owl:ObjectProperty</para>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>"The net volume in liters of the total unit. The value of this property usually is equal to the sum of the value of the properties ofrd:volumeOfFridge and ofrd:volumeOfFreezer"</para>
    /// labels<para>"Volume of unit net"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#volumeOfUnitNet">http://purl.org/opdm/refrigerator#volumeOfUnitNet</seealso>
    let volumeOfUnitNet = Prefixed_Name(ofrd, "volumeOfUnitNet") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:waterDispenser</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with a water dispenser system or not."</para>
    /// labels<para>"Water dispenser"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#waterDispenser">http://purl.org/opdm/refrigerator#waterDispenser</seealso>
    let waterDispenser = Prefixed_Name(ofrd, "waterDispenser") |> PrefixedName
    /// <summary>
    ///   <para>ofrd:waterFiltration</para>
    /// </summary>
    /// <remarks>
    ///   <para>&lt;http://purl.org/opdm/utility#MetadataContainer&gt;</para>
    ///   <para>owl:DatatypeProperty</para>
    ///   <para>"This property specifies whether the fridge/freezer is equipped with a water filtration system or not."</para>
    /// labels<para>"Water filtration"</para></remarks>
    /// <seealso href="http://purl.org/opdm/refrigerator#waterFiltration">http://purl.org/opdm/refrigerator#waterFiltration</seealso>
    let waterFiltration = Prefixed_Name(ofrd, "waterFiltration") |> PrefixedName
