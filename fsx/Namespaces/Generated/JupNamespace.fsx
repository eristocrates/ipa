#I @"D:\https\com\github\eristocrates\ipa\fsx"
#load @".paket/load/main.group.fsx"
#r @"RdfAsm.dll"
open RdfAsm
#r @"RdfIO.dll"
open RdfIO

module jup =
    let _prefixId = PrefixId.fromNamespaceLabel "http://w3id.org/charta77/jup/" "jup"
    let AOB = _prefixId.prefix "AOB"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of AOB announcementsrdfs:label : Typy hlaseni AOB</para>
    ///   <a href="http://w3id.org/charta77/jup/AOBAnnouncement">jup:AOBAnnouncement</a>
    /// </summary>
    let AOBAnnouncement = _prefixId.prefix "AOBAnnouncement"
    let AOBAnnouncementsScheme = _prefixId.prefix "AOBAnnouncementsScheme"
    let AccessibleObjectMKPO = _prefixId.prefix "AccessibleObjectMKPO"
    let AccessibleWCMKPO = _prefixId.prefix "AccessibleWCMKPO"
    /// <summary>
    ///   <para>rdfs:label : Addressable entityrdfs:label : Entita majici adresu</para>
    ///   <a href="http://w3id.org/charta77/jup/AddressableEntity">jup:AddressableEntity</a>
    /// </summary>
    let AddressableEntity = _prefixId.prefix "AddressableEntity"

    let AdministrativeOfficeObjectCategory = _prefixId.prefix "AdministrativeOfficeObjectCategory"

    let AirportObjectCategory = _prefixId.prefix "AirportObjectCategory"
    let ArtificialEntranceGuidingLine = _prefixId.prefix "ArtificialEntranceGuidingLine"
    /// <summary>
    ///   <para>rdfs:comment : accessibility evaluationrdfs:comment : ohodnoceni z hlediska pristupnosti</para>
    ///   <para>rdfs:label : Assessable entityrdfs:label : Ohodnotitelna entita</para>
    ///   <a href="http://w3id.org/charta77/jup/AssessableEntity">jup:AssessableEntity</a>
    /// </summary>
    let AssessableEntity = _prefixId.prefix "AssessableEntity"
    let AutomaticDoorOpening = _prefixId.prefix "AutomaticDoorOpening"
    let AutomaticWCFlushing = _prefixId.prefix "AutomaticWCFlushing"
    let AutomaticWCSwitch = _prefixId.prefix "AutomaticWCSwitch"
    let BankObjectCategory = _prefixId.prefix "BankObjectCategory"
    let Bannister = _prefixId.prefix "Bannister"
    let BarObjectCategory = _prefixId.prefix "BarObjectCategory"
    let BasilicaObjectCategory = _prefixId.prefix "BasilicaObjectCategory"
    let Bell = _prefixId.prefix "Bell"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Bell typesrdfs:label : Typy zvonku</para>
    ///   <a href="http://w3id.org/charta77/jup/BellType">jup:BellType</a>
    /// </summary>
    let BellType = _prefixId.prefix "BellType"
    let BellTypesScheme = _prefixId.prefix "BellTypesScheme"
    let BentRampType = _prefixId.prefix "BentRampType"
    let BlockedByFixedWCBasinSpace = _prefixId.prefix "BlockedByFixedWCBasinSpace"
    let BlockedByMobileWCBasinSpace = _prefixId.prefix "BlockedByMobileWCBasinSpace"
    let BotanicGardenObjectCategory = _prefixId.prefix "BotanicGardenObjectCategory"

    let BottomContrastMarkingLocalization = _prefixId.prefix "BottomContrastMarkingLocalization"

    let BottomEntryArea = _prefixId.prefix "BottomEntryArea"
    let BottomLeftWCCabinDisposition = _prefixId.prefix "BottomLeftWCCabinDisposition"
    let BottomRightWCCabinDisposition = _prefixId.prefix "BottomRightWCCabinDisposition"
    let BreweryObjectCategory = _prefixId.prefix "BreweryObjectCategory"
    let BusStationObjectCategory = _prefixId.prefix "BusStationObjectCategory"
    let CampObjectCategory = _prefixId.prefix "CampObjectCategory"
    let CarDealerObjectCategory = _prefixId.prefix "CarDealerObjectCategory"
    let CargoElevatorType = _prefixId.prefix "CargoElevatorType"
    let CarouselDoorType = _prefixId.prefix "CarouselDoorType"
    let CathedralObjectCategory = _prefixId.prefix "CathedralObjectCategory"
    let ChapelObjectCategory = _prefixId.prefix "ChapelObjectCategory"
    let ChurchObjectCategory = _prefixId.prefix "ChurchObjectCategory"
    let CinemaObjectCategory = _prefixId.prefix "CinemaObjectCategory"
    let CityHallObjectCategory = _prefixId.prefix "CityHallObjectCategory"
    let CollegeObjectCategory = _prefixId.prefix "CollegeObjectCategory"
    let Complex = _prefixId.prefix "Complex"
    let ConcertHallObjectCategory = _prefixId.prefix "ConcertHallObjectCategory"

    let ContactSocialServiceObjectCategory = _prefixId.prefix "ContactSocialServiceObjectCategory"

    let ContrastMarking = _prefixId.prefix "ContrastMarking"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of contrast marking of glass surfacesrdfs:label : Typy umisteni kontrastniho znaceni prosklenych ploch</para>
    ///   <a href="http://w3id.org/charta77/jup/ContrastMarkingLocalization">jup:ContrastMarkingLocalization</a>
    /// </summary>
    let ContrastMarkingLocalization = _prefixId.prefix "ContrastMarkingLocalization"

    let ContrastMarkingLocalizationsScheme = _prefixId.prefix "ContrastMarkingLocalizationsScheme"

    let CourtObjectCategory = _prefixId.prefix "CourtObjectCategory"
    let DefensiveCastleObjectCategory = _prefixId.prefix "DefensiveCastleObjectCategory"
    let DentalEmergencyObjectCategory = _prefixId.prefix "DentalEmergencyObjectCategory"
    let DepartmentStoreObjectCategory = _prefixId.prefix "DepartmentStoreObjectCategory"
    let DifficultWCFlushingDifficulty = _prefixId.prefix "DifficultWCFlushingDifficulty"

    let DigitalElevatorControlFlatMarking = _prefixId.prefix "DigitalElevatorControlFlatMarking"

    let DirectObjectStairsType = _prefixId.prefix "DirectObjectStairsType"
    let DirectRampType = _prefixId.prefix "DirectRampType"
    let DoctorObjectCategory = _prefixId.prefix "DoctorObjectCategory"
    let Door = _prefixId.prefix "Door"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Door openings typesrdfs:label : Typy otevirani dveri</para>
    ///   <a href="http://w3id.org/charta77/jup/DoorOpening">jup:DoorOpening</a>
    /// </summary>
    let DoorOpening = _prefixId.prefix "DoorOpening"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Door opening direction typesrdfs:label : Typy orientace otevirani dveri</para>
    ///   <a href="http://w3id.org/charta77/jup/DoorOpeningDirection">jup:DoorOpeningDirection</a>
    /// </summary>
    let DoorOpeningDirection = _prefixId.prefix "DoorOpeningDirection"
    let DoorOpeningDirectionsScheme = _prefixId.prefix "DoorOpeningDirectionsScheme"
    let DoorOpeningsScheme = _prefixId.prefix "DoorOpeningsScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Door typesrdfs:label : Typy dveri</para>
    ///   <a href="http://w3id.org/charta77/jup/DoorType">jup:DoorType</a>
    /// </summary>
    let DoorType = _prefixId.prefix "DoorType"
    let DoorTypesScheme = _prefixId.prefix "DoorTypesScheme"
    let DoublePanelledDoorType = _prefixId.prefix "DoublePanelledDoorType"
    let Elevator = _prefixId.prefix "Elevator"
    let ElevatorCageDoor = _prefixId.prefix "ElevatorCageDoor"
    let ElevatorCageHandle = _prefixId.prefix "ElevatorCageHandle"

    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of elevator cage mirror localizationsrdfs:label : Typy umisteni zrcadla</para>
    ///   <a href="http://w3id.org/charta77/jup/ElevatorCageMirrorLocalization">jup:ElevatorCageMirrorLocalization</a>
    /// </summary>
    let ElevatorCageMirrorLocalization = _prefixId.prefix "ElevatorCageMirrorLocalization"

    let ElevatorCageMirrorLocalizationsScheme = _prefixId.prefix "ElevatorCageMirrorLocalizationsScheme"

    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of second door placement in pass-through cagerdfs:label : Typy umisteni druhych dveri pruchozi klece</para>
    ///   <a href="http://w3id.org/charta77/jup/ElevatorCageSecondDoorLocalization">jup:ElevatorCageSecondDoorLocalization</a>
    /// </summary>
    let ElevatorCageSecondDoorLocalization = _prefixId.prefix "ElevatorCageSecondDoorLocalization"

    let ElevatorCageSecondDoorLocalizationsScheme = _prefixId.prefix "ElevatorCageSecondDoorLocalizationsScheme"

    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of elevator control flat markingsrdfs:label : Typy plochych oznaceni ovladace vytahu</para>
    ///   <a href="http://w3id.org/charta77/jup/ElevatorControlFlatMarking">jup:ElevatorControlFlatMarking</a>
    /// </summary>
    let ElevatorControlFlatMarking = _prefixId.prefix "ElevatorControlFlatMarking"

    let ElevatorControlFlatMarkingsScheme = _prefixId.prefix "ElevatorControlFlatMarkingsScheme"

    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of elevator control reliefsrdfs:label : Typy reliefu oznaceni ovladace vytahu</para>
    ///   <a href="http://w3id.org/charta77/jup/ElevatorControlReliefMarking">jup:ElevatorControlReliefMarking</a>
    /// </summary>
    let ElevatorControlReliefMarking = _prefixId.prefix "ElevatorControlReliefMarking"

    let ElevatorControlReliefMarkingsScheme = _prefixId.prefix "ElevatorControlReliefMarkingsScheme"

    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of elevator drive-offsrdfs:label : Typy dojezdu vytahu</para>
    ///   <a href="http://w3id.org/charta77/jup/ElevatorDriveOff">jup:ElevatorDriveOff</a>
    /// </summary>
    let ElevatorDriveOff = _prefixId.prefix "ElevatorDriveOff"
    let ElevatorDriveOffsScheme = _prefixId.prefix "ElevatorDriveOffsScheme"
    let ElevatorMKPOForm = _prefixId.prefix "ElevatorMKPOForm"
    let ElevatorShaftDoor = _prefixId.prefix "ElevatorShaftDoor"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of elevatorsrdfs:label : Typy vytahu</para>
    ///   <a href="http://w3id.org/charta77/jup/ElevatorType">jup:ElevatorType</a>
    /// </summary>
    let ElevatorType = _prefixId.prefix "ElevatorType"
    let ElevatorTypesScheme = _prefixId.prefix "ElevatorTypesScheme"
    let EmbassyObjectCategory = _prefixId.prefix "EmbassyObjectCategory"

    let EmploymentOfficeObjectCategory = _prefixId.prefix "EmploymentOfficeObjectCategory"

    let EngravedElevatorControlReliefMarking = _prefixId.prefix "EngravedElevatorControlReliefMarking"

    let EntireObjectInteriorAccessibility = _prefixId.prefix "EntireObjectInteriorAccessibility"

    let Entrance = _prefixId.prefix "Entrance"
    let EntranceAccessibilitiesScheme = _prefixId.prefix "EntranceAccessibilitiesScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Entrance accessibility typesrdfs:label : Typy pristupnosti vstupu</para>
    ///   <a href="http://w3id.org/charta77/jup/EntranceAccessibility">jup:EntranceAccessibility</a>
    /// </summary>
    let EntranceAccessibility = _prefixId.prefix "EntranceAccessibility"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Guiding line typesrdfs:label : Typy vodicich linii</para>
    ///   <a href="http://w3id.org/charta77/jup/EntranceGuidingLine">jup:EntranceGuidingLine</a>
    /// </summary>
    let EntranceGuidingLine = _prefixId.prefix "EntranceGuidingLine"
    let EntranceGuidingLinesScheme = _prefixId.prefix "EntranceGuidingLinesScheme"
    let EntranceRampSkidsLocalization = _prefixId.prefix "EntranceRampSkidsLocalization"
    let EntranceSteps = _prefixId.prefix "EntranceSteps"
    let EntryArea = _prefixId.prefix "EntryArea"
    let EntryAreaEntriesScheme = _prefixId.prefix "EntryAreaEntriesScheme"
    /// <summary>
    ///   <para>rdfs:comment : Types of elevator cage mirror localizationsrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of entry area entriesrdfs:label : Typy vstupu na nastupni plochu</para>
    ///   <a href="http://w3id.org/charta77/jup/EntryAreaEntry">jup:EntryAreaEntry</a>
    /// </summary>
    let EntryAreaEntry = _prefixId.prefix "EntryAreaEntry"
    let FarmObjectCategory = _prefixId.prefix "FarmObjectCategory"
    let FastFoodObjectCategory = _prefixId.prefix "FastFoodObjectCategory"
    let FixedHandleType = _prefixId.prefix "FixedHandleType"
    let FixedRampSkidsMobility = _prefixId.prefix "FixedRampSkidsMobility"
    let FoldingHandleType = _prefixId.prefix "FoldingHandleType"
    let FoldingWCChangingDesk = _prefixId.prefix "FoldingWCChangingDesk"

    let FolkArchitectureObjectCategory = _prefixId.prefix "FolkArchitectureObjectCategory"

    /// <summary>
    ///   <para>rdfs:label : Form mapping entityrdfs:label : Formular mapujici entitu</para>
    ///   <a href="http://w3id.org/charta77/jup/Form">jup:Form</a>
    /// </summary>
    let Form = _prefixId.prefix "Form"
    let FortObjectCategory = _prefixId.prefix "FortObjectCategory"
    let FortressObjectCategory = _prefixId.prefix "FortressObjectCategory"
    let FreeWCBasinSpace = _prefixId.prefix "FreeWCBasinSpace"

    let FreelyAccessibleMappableEntityAccess = _prefixId.prefix "FreelyAccessibleMappableEntityAccess"

    let FrontElevatorCageSecondDoorLocalization = _prefixId.prefix "FrontElevatorCageSecondDoorLocalization"

    let FrontEntryAreaEntry = _prefixId.prefix "FrontEntryAreaEntry"

    let FrontWallElevatorCageMirrorLocalization = _prefixId.prefix "FrontWallElevatorCageMirrorLocalization"

    let FrontWallHandleLocalization = _prefixId.prefix "FrontWallHandleLocalization"
    let FunerallHallObjectCategory = _prefixId.prefix "FunerallHallObjectCategory"
    let GalleryObjectCategory = _prefixId.prefix "GalleryObjectCategory"
    let GasStationObjectCategory = _prefixId.prefix "GasStationObjectCategory"
    let GentsWCCabinLocalization = _prefixId.prefix "GentsWCCabinLocalization"

    let GraphicElevatorControlFlatMarking = _prefixId.prefix "GraphicElevatorControlFlatMarking"

    let GuestHouseObjectCategory = _prefixId.prefix "GuestHouseObjectCategory"
    let Hallway = _prefixId.prefix "Hallway"
    let Handle = _prefixId.prefix "Handle"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Localization of handelsrdfs:label : Umisteni madel</para>
    ///   <a href="http://w3id.org/charta77/jup/HandleLocalization">jup:HandleLocalization</a>
    /// </summary>
    let HandleLocalization = _prefixId.prefix "HandleLocalization"
    let HandleLocalizationsScheme = _prefixId.prefix "HandleLocalizationsScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Orientation of handelsrdfs:label : Orientace madel</para>
    ///   <a href="http://w3id.org/charta77/jup/HandleOrientation">jup:HandleOrientation</a>
    /// </summary>
    let HandleOrientation = _prefixId.prefix "HandleOrientation"
    let HandleOrientationsScheme = _prefixId.prefix "HandleOrientationsScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Positions of handelsrdfs:label : Pozice madel</para>
    ///   <a href="http://w3id.org/charta77/jup/HandlePosition">jup:HandlePosition</a>
    /// </summary>
    let HandlePosition = _prefixId.prefix "HandlePosition"
    let HandlePositionsScheme = _prefixId.prefix "HandlePositionsScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of handelsrdfs:label : Typy madel</para>
    ///   <a href="http://w3id.org/charta77/jup/HandleType">jup:HandleType</a>
    /// </summary>
    let HandleType = _prefixId.prefix "HandleType"
    let HandleTypesScheme = _prefixId.prefix "HandleTypesScheme"
    let HarborObjectCategory = _prefixId.prefix "HarborObjectCategory"
    let HealthCenterObjectCategory = _prefixId.prefix "HealthCenterObjectCategory"

    let HealthInsuranceCompanyObjectCategory = _prefixId.prefix "HealthInsuranceCompanyObjectCategory"

    let HighSchoolObjectCategory = _prefixId.prefix "HighSchoolObjectCategory"
    let HorizontalHandleOrientation = _prefixId.prefix "HorizontalHandleOrientation"
    let HospitalObjectCategory = _prefixId.prefix "HospitalObjectCategory"
    let HotelObjectCategory = _prefixId.prefix "HotelObjectCategory"
    let HypermarketObjectCategory = _prefixId.prefix "HypermarketObjectCategory"

    let InaccessibleObjectInteriorAccessibility = _prefixId.prefix "InaccessibleObjectInteriorAccessibility"

    let InaccessibleObjectMKPO = _prefixId.prefix "InaccessibleObjectMKPO"
    let InaccessibleWCMKPO = _prefixId.prefix "InaccessibleWCMKPO"
    let InclinedPlatformType = _prefixId.prefix "InclinedPlatformType"

    let IndoorSwimmingPoolObjectCategory = _prefixId.prefix "IndoorSwimmingPoolObjectCategory"

    let InformationCenterObjectCategory = _prefixId.prefix "InformationCenterObjectCategory"

    let InsideHandlePosition = _prefixId.prefix "InsideHandlePosition"

    let InsufficientWashBasinUnderpass = _prefixId.prefix "InsufficientWashBasinUnderpass"

    let InsuranceOfficeObjectCategory = _prefixId.prefix "InsuranceOfficeObjectCategory"
    let IntercomBellType = _prefixId.prefix "IntercomBellType"
    let InteriorRampSkidsLocalization = _prefixId.prefix "InteriorRampSkidsLocalization"
    let InteriorStairs = _prefixId.prefix "InteriorStairs"
    let InteriorSteps = _prefixId.prefix "InteriorSteps"
    let InwardsDoorOpeningDirection = _prefixId.prefix "InwardsDoorOpeningDirection"
    let JingleAOBAnnouncement = _prefixId.prefix "JingleAOBAnnouncement"
    let KindergartenObjectCategory = _prefixId.prefix "KindergartenObjectCategory"
    let LadiesWCCabinLocalization = _prefixId.prefix "LadiesWCCabinLocalization"
    let LandingsElevatorDriveOff = _prefixId.prefix "LandingsElevatorDriveOff"
    let LandingsEntryArea = _prefixId.prefix "LandingsEntryArea"
    let LeftBottomWCCabinDisposition = _prefixId.prefix "LeftBottomWCCabinDisposition"
    let LeftTopWCCabinDisposition = _prefixId.prefix "LeftTopWCCabinDisposition"
    let LevelTap = _prefixId.prefix "LevelTap"
    let LibraryObjectCategory = _prefixId.prefix "LibraryObjectCategory"
    let LobbyDoor = _prefixId.prefix "LobbyDoor"
    let LobbyRampSkidsLocalization = _prefixId.prefix "LobbyRampSkidsLocalization"
    let LobbySteps = _prefixId.prefix "LobbySteps"
    let LockedMappableEntityAccess = _prefixId.prefix "LockedMappableEntityAccess"
    let LoretoObjectCategory = _prefixId.prefix "LoretoObjectCategory"
    let MainEntrance = _prefixId.prefix "MainEntrance"
    /// <summary>
    ///   <para>rdfs:label : Mappable entityrdfs:label : Mapovatelna entita</para>
    ///   <a href="http://w3id.org/charta77/jup/MappableEntity">jup:MappableEntity</a>
    /// </summary>
    let MappableEntity = _prefixId.prefix "MappableEntity"
    /// <summary>
    ///   <para>rdfs:comment : The list was copied based on forms compliant with Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of accessibility to the mappable entityrdfs:label : Typy pristupu k mapovatelne entite</para>
    ///   <a href="http://w3id.org/charta77/jup/MappableEntityAccess">jup:MappableEntityAccess</a>
    /// </summary>
    let MappableEntityAccess = _prefixId.prefix "MappableEntityAccess"
    let MappableEntityAccessesScheme = _prefixId.prefix "MappableEntityAccessesScheme"
    /// <summary>
    ///   <para>rdfs:label : Forms mapping entitiesrdfs:label : Formulare mapujici entity</para>
    ///   <a href="http://w3id.org/charta77/jup/MappableEntityForm">jup:MappableEntityForm</a>
    /// </summary>
    let MappableEntityForm = _prefixId.prefix "MappableEntityForm"
    let MappableEntityMKPOFormsScheme = _prefixId.prefix "MappableEntityMKPOFormsScheme"
    let Mapper = _prefixId.prefix "Mapper"
    let MechanicalDoorOpening = _prefixId.prefix "MechanicalDoorOpening"
    let MechanicalWCFlushing = _prefixId.prefix "MechanicalWCFlushing"

    let MedicalEmergencyObjectCategory = _prefixId.prefix "MedicalEmergencyObjectCategory"

    let MedicalSupplyObjectCategory = _prefixId.prefix "MedicalSupplyObjectCategory"

    let MetropolitanPoliceObjectCategory = _prefixId.prefix "MetropolitanPoliceObjectCategory"

    let MezzaninesElevatorDriveOff = _prefixId.prefix "MezzaninesElevatorDriveOff"
    let MissingBellType = _prefixId.prefix "MissingBellType"

    let MissingContrastMarkingLocalization = _prefixId.prefix "MissingContrastMarkingLocalization"

    let MissingEntranceGuidingLine = _prefixId.prefix "MissingEntranceGuidingLine"
    let MissingHandlePosition = _prefixId.prefix "MissingHandlePosition"
    let MissingWCSwitch = _prefixId.prefix "MissingWCSwitch"
    let MobileRampSkidsMobility = _prefixId.prefix "MobileRampSkidsMobility"
    let MobileWCChangingDesk = _prefixId.prefix "MobileWCChangingDesk"
    let MonasteryObjectCategory = _prefixId.prefix "MonasteryObjectCategory"
    let MonumentObjectCategory = _prefixId.prefix "MonumentObjectCategory"

    let MoreStepsEntranceAccessibility = _prefixId.prefix "MoreStepsEntranceAccessibility"

    let MosqueObjectCategory = _prefixId.prefix "MosqueObjectCategory"
    let MunicipalOfficeObjectCategory = _prefixId.prefix "MunicipalOfficeObjectCategory"
    let MunicipalityObjectCategory = _prefixId.prefix "MunicipalityObjectCategory"
    let MuseumObjectCategory = _prefixId.prefix "MuseumObjectCategory"
    let NarrowedPassage = _prefixId.prefix "NarrowedPassage"
    let NaturalEntranceGuidingLine = _prefixId.prefix "NaturalEntranceGuidingLine"
    let NavigationSystem = _prefixId.prefix "NavigationSystem"

    let NoElevationEntranceAccessibility = _prefixId.prefix "NoElevationEntranceAccessibility"

    let NonslipperyRampSurface = _prefixId.prefix "NonslipperyRampSurface"
    let NotConnectingObjectStairsType = _prefixId.prefix "NotConnectingObjectStairsType"
    let OKWCFlushingDifficulty = _prefixId.prefix "OKWCFlushingDifficulty"
    let Object = _prefixId.prefix "Object"
    let ObjectCategoriesScheme = _prefixId.prefix "ObjectCategoriesScheme"
    /// <summary>
    ///   <para>rdfs:label : Three degree evaluation system for object accessibility based on Object Accessibility Categorization Methodologyrdfs:label : Tristupnovy system ohodnoceni pristupnosti objektu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <a href="http://w3id.org/charta77/jup/ObjectCategorizationMKPO">jup:ObjectCategorizationMKPO</a>
    /// </summary>
    let ObjectCategorizationMKPO = _prefixId.prefix "ObjectCategorizationMKPO"

    let ObjectCategorizationsMKPOScheme = _prefixId.prefix "ObjectCategorizationsMKPOScheme"

    /// <summary>
    ///   <para>rdfs:label : Building categorizationrdfs:label : Kategorizace budov</para>
    ///   <a href="http://w3id.org/charta77/jup/ObjectCategory">jup:ObjectCategory</a>
    /// </summary>
    let ObjectCategory = _prefixId.prefix "ObjectCategory"

    let ObjectInteriorAccessibilitiesScheme = _prefixId.prefix "ObjectInteriorAccessibilitiesScheme"

    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Interior accessiblity typesrdfs:label : Typy pristupnosti interieru</para>
    ///   <a href="http://w3id.org/charta77/jup/ObjectInteriorAccessibility">jup:ObjectInteriorAccessibility</a>
    /// </summary>
    let ObjectInteriorAccessibility = _prefixId.prefix "ObjectInteriorAccessibility"
    let ObjectMKPOForm = _prefixId.prefix "ObjectMKPOForm"
    let ObjectStairsType = _prefixId.prefix "ObjectStairsType"
    let ObservatoryObjectCategory = _prefixId.prefix "ObservatoryObjectCategory"
    let OneSideDoorOpeningDirection = _prefixId.prefix "OneSideDoorOpeningDirection"
    let OneStepEntranceAccessibility = _prefixId.prefix "OneStepEntranceAccessibility"
    let OpticianShopObjectCategory = _prefixId.prefix "OpticianShopObjectCategory"
    let Organization = _prefixId.prefix "Organization"
    let OtheroObjectCategory = _prefixId.prefix "OtheroObjectCategory"
    let OutsideHandlePosition = _prefixId.prefix "OutsideHandlePosition"
    let OutwardsDoorOpeningDirection = _prefixId.prefix "OutwardsDoorOpeningDirection"
    let PalaceObjectCategory = _prefixId.prefix "PalaceObjectCategory"

    let PartObjectInteriorAccessibility = _prefixId.prefix "PartObjectInteriorAccessibility"

    let PartlyAccessibleObjectMKPO = _prefixId.prefix "PartlyAccessibleObjectMKPO"
    let PartlyAccessibleWCMKPO = _prefixId.prefix "PartlyAccessibleWCMKPO"
    let PastryObjectCategory = _prefixId.prefix "PastryObjectCategory"
    let PersonalElevatorType = _prefixId.prefix "PersonalElevatorType"
    let PharmacyObjectCategory = _prefixId.prefix "PharmacyObjectCategory"
    let PhraseAOBAnnouncement = _prefixId.prefix "PhraseAOBAnnouncement"
    /// <summary>
    ///   <para>rdfs:label : Physical entityrdfs:label : Fyzicka entita</para>
    ///   <a href="http://w3id.org/charta77/jup/PhysicalEntity">jup:PhysicalEntity</a>
    /// </summary>
    let PhysicalEntity = _prefixId.prefix "PhysicalEntity"
    let Platform = _prefixId.prefix "Platform"
    let PlatformEntranceAccessibility = _prefixId.prefix "PlatformEntranceAccessibility"
    let PlatformMKPOForm = _prefixId.prefix "PlatformMKPOForm"
    /// <summary>
    ///   <para>rdfs:comment : Types of elevator cage mirror localizationsrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of platformsrdfs:label : Typy plosiny</para>
    ///   <a href="http://w3id.org/charta77/jup/PlatformType">jup:PlatformType</a>
    /// </summary>
    let PlatformType = _prefixId.prefix "PlatformType"
    let PlatformTypesScheme = _prefixId.prefix "PlatformTypesScheme"
    let PoliceObjectCategory = _prefixId.prefix "PoliceObjectCategory"
    let PostOfficeObjectCategory = _prefixId.prefix "PostOfficeObjectCategory"

    let ProtrudingElevatorControlReliefMarking = _prefixId.prefix "ProtrudingElevatorControlReliefMarking"

    let PubObjectCategory = _prefixId.prefix "PubObjectCategory"

    let PublicProsecutorObjectCategory = _prefixId.prefix "PublicProsecutorObjectCategory"

    let PublicToiletObjectCategory = _prefixId.prefix "PublicToiletObjectCategory"
    let Ramp = _prefixId.prefix "Ramp"
    let RampEntranceAccessibility = _prefixId.prefix "RampEntranceAccessibility"
    let RampHandle = _prefixId.prefix "RampHandle"
    let RampLeg = _prefixId.prefix "RampLeg"
    let RampSkids = _prefixId.prefix "RampSkids"
    /// <summary>
    ///   <para>rdfs:comment : Types of elevator cage mirror localizationsrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Localization of ramps/skidsrdfs:label : Lokalizace rampy/lizin</para>
    ///   <a href="http://w3id.org/charta77/jup/RampSkidsLocalization">jup:RampSkidsLocalization</a>
    /// </summary>
    let RampSkidsLocalization = _prefixId.prefix "RampSkidsLocalization"
    let RampSkidsLocalizationsScheme = _prefixId.prefix "RampSkidsLocalizationsScheme"
    let RampSkidsMKPOForm = _prefixId.prefix "RampSkidsMKPOForm"
    let RampSkidsMobilitiesScheme = _prefixId.prefix "RampSkidsMobilitiesScheme"
    /// <summary>
    ///   <para>rdfs:comment : Types of elevator cage mirror localizationsrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Mobility types of ramps/skidsrdfs:label : Typy mobility rampy/lizin</para>
    ///   <a href="http://w3id.org/charta77/jup/RampSkidsMobility">jup:RampSkidsMobility</a>
    /// </summary>
    let RampSkidsMobility = _prefixId.prefix "RampSkidsMobility"
    /// <summary>
    ///   <para>rdfs:comment : Types of elevator cage mirror localizationsrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of ramp surfacesrdfs:label : Typy povrchu rampy</para>
    ///   <a href="http://w3id.org/charta77/jup/RampSurface">jup:RampSurface</a>
    /// </summary>
    let RampSurface = _prefixId.prefix "RampSurface"
    let RampSurfacesScheme = _prefixId.prefix "RampSurfacesScheme"
    /// <summary>
    ///   <para>rdfs:comment : Types of elevator cage mirror localizationsrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of ramprdfs:label : Typy ramp</para>
    ///   <a href="http://w3id.org/charta77/jup/RampType">jup:RampType</a>
    /// </summary>
    let RampType = _prefixId.prefix "RampType"
    let RampTypesScheme = _prefixId.prefix "RampTypesScheme"

    let RecreationalFacilityObjectCategory = _prefixId.prefix "RecreationalFacilityObjectCategory"

    let ResidentialSocialServiceObjectCategory = _prefixId.prefix "ResidentialSocialServiceObjectCategory"

    let RestaurantObjectCategory = _prefixId.prefix "RestaurantObjectCategory"
    let RightBottomWCCabinDisposition = _prefixId.prefix "RightBottomWCCabinDisposition"
    let RightTopWCCabinDisposition = _prefixId.prefix "RightTopWCCabinDisposition"
    let RingOnlyBellType = _prefixId.prefix "RingOnlyBellType"
    let SchoolObjectCategory = _prefixId.prefix "SchoolObjectCategory"

    let SelfContainedWCCabinLocalization = _prefixId.prefix "SelfContainedWCCabinLocalization"

    let ServiceObjectCategory = _prefixId.prefix "ServiceObjectCategory"

    let SideElevatorCageSecondDoorLocalization = _prefixId.prefix "SideElevatorCageSecondDoorLocalization"

    let SideEntrance = _prefixId.prefix "SideEntrance"
    let SideEntryAreaEntry = _prefixId.prefix "SideEntryAreaEntry"

    let SideWallElevatorCageMirrorLocalization = _prefixId.prefix "SideWallElevatorCageMirrorLocalization"

    let SideWallHandleLocalization = _prefixId.prefix "SideWallHandleLocalization"

    let SideWallsElevatorCageMirrorLocalization = _prefixId.prefix "SideWallsElevatorCageMirrorLocalization"

    let SideWallsHandleLocalization = _prefixId.prefix "SideWallsHandleLocalization"
    let SidesDoorOpeningDirection = _prefixId.prefix "SidesDoorOpeningDirection"
    let SinglePanelledDoorType = _prefixId.prefix "SinglePanelledDoorType"
    let Skids = _prefixId.prefix "Skids"
    let SlidingDoorOpening = _prefixId.prefix "SlidingDoorOpening"
    let SlipperyRampSurface = _prefixId.prefix "SlipperyRampSurface"
    let SocialOfficeObjectCategory = _prefixId.prefix "SocialOfficeObjectCategory"
    let SpaHouseObjectCategory = _prefixId.prefix "SpaHouseObjectCategory"
    let SpiralObjectStairsType = _prefixId.prefix "SpiralObjectStairsType"
    let SpiralRampType = _prefixId.prefix "SpiralRampType"
    let SportsFacilityObjectCategory = _prefixId.prefix "SportsFacilityObjectCategory"
    let StadiumObjectCategory = _prefixId.prefix "StadiumObjectCategory"
    let StatelyHomeObjectCategory = _prefixId.prefix "StatelyHomeObjectCategory"
    let Steps = _prefixId.prefix "Steps"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Stair typesrdfs:label : Typy schodiste</para>
    ///   <a href="http://w3id.org/charta77/jup/StepsStairsType">jup:StepsStairsType</a>
    /// </summary>
    let StepsStairsType = _prefixId.prefix "StepsStairsType"
    let StepsStairsTypesScheme = _prefixId.prefix "StepsStairsTypesScheme"
    let StoreObjectCategory = _prefixId.prefix "StoreObjectCategory"
    let SubwayStationObjectCategory = _prefixId.prefix "SubwayStationObjectCategory"
    let SufficientWashBasinUnderpass = _prefixId.prefix "SufficientWashBasinUnderpass"
    let SupermarketObjectCategory = _prefixId.prefix "SupermarketObjectCategory"
    let SwimmingObjectCategory = _prefixId.prefix "SwimmingObjectCategory"
    let SwingingDoorOpening = _prefixId.prefix "SwingingDoorOpening"
    let SynagogueObjectCategory = _prefixId.prefix "SynagogueObjectCategory"
    let Tap = _prefixId.prefix "Tap"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of tapsrdfs:label : Typy baterii</para>
    ///   <a href="http://w3id.org/charta77/jup/TapType">jup:TapType</a>
    /// </summary>
    let TapType = _prefixId.prefix "TapType"
    let TapTypesScheme = _prefixId.prefix "TapTypesScheme"
    let TaxOfficeObjectCategory = _prefixId.prefix "TaxOfficeObjectCategory"
    let TempleObjectCategory = _prefixId.prefix "TempleObjectCategory"
    let TheatreObjectCategory = _prefixId.prefix "TheatreObjectCategory"

    let TopContrastMarkingLocalization = _prefixId.prefix "TopContrastMarkingLocalization"

    let TopEntryArea = _prefixId.prefix "TopEntryArea"
    let TopLeftWCCabinDisposition = _prefixId.prefix "TopLeftWCCabinDisposition"
    let TopRightWCCabinDisposition = _prefixId.prefix "TopRightWCCabinDisposition"
    let TouchFreeTap = _prefixId.prefix "TouchFreeTap"
    let TouristGuide = _prefixId.prefix "TouristGuide"
    let Tourniquet = _prefixId.prefix "Tourniquet"
    let TowerObjectCategory = _prefixId.prefix "TowerObjectCategory"
    let TownhallObjectCategory = _prefixId.prefix "TownhallObjectCategory"
    let TrainStationObjectCategory = _prefixId.prefix "TrainStationObjectCategory"
    let ValveTap = _prefixId.prefix "ValveTap"
    let VerticalHandleOrientation = _prefixId.prefix "VerticalHandleOrientation"
    let VerticalPlatformType = _prefixId.prefix "VerticalPlatformType"

    let VeterinarySurgeryObjectCategory = _prefixId.prefix "VeterinarySurgeryObjectCategory"

    let ViticultureObjectCategory = _prefixId.prefix "ViticultureObjectCategory"
    let WC = _prefixId.prefix "WC"
    let WCBasinLeftHandle = _prefixId.prefix "WCBasinLeftHandle"
    let WCBasinRightHandle = _prefixId.prefix "WCBasinRightHandle"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of wheelchair space next to closetrdfs:label : Typy prostoru pro vozik vedle WC misy</para>
    ///   <a href="http://w3id.org/charta77/jup/WCBasinSpace">jup:WCBasinSpace</a>
    /// </summary>
    let WCBasinSpace = _prefixId.prefix "WCBasinSpace"
    let WCBasinSpacesScheme = _prefixId.prefix "WCBasinSpacesScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Dispositions of WC cabinrdfs:label : Typy dispozic kabiny WC</para>
    ///   <a href="http://w3id.org/charta77/jup/WCCabinDisposition">jup:WCCabinDisposition</a>
    /// </summary>
    let WCCabinDisposition = _prefixId.prefix "WCCabinDisposition"
    let WCCabinDispositionsScheme = _prefixId.prefix "WCCabinDispositionsScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Localization of WC cabinrdfs:label : Typy umisteni kabiny WC</para>
    ///   <a href="http://w3id.org/charta77/jup/WCCabinLocalization">jup:WCCabinLocalization</a>
    /// </summary>
    let WCCabinLocalization = _prefixId.prefix "WCCabinLocalization"
    let WCCabinLocalizationsScheme = _prefixId.prefix "WCCabinLocalizationsScheme"
    /// <summary>
    ///   <para>rdfs:label : Three degree evaluation system for bathroom accessibility based on Object Accessibility Categorization Methodologyrdfs:label : Tristupnovy system ohodnoceni pristupnosti toalet dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <a href="http://w3id.org/charta77/jup/WCCategorizationMKPO">jup:WCCategorizationMKPO</a>
    /// </summary>
    let WCCategorizationMKPO = _prefixId.prefix "WCCategorizationMKPO"
    let WCCategorizationsMKPOScheme = _prefixId.prefix "WCCategorizationsMKPOScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of changing desksrdfs:label : Typy prebalovacich pultu</para>
    ///   <a href="http://w3id.org/charta77/jup/WCChangingDesk">jup:WCChangingDesk</a>
    /// </summary>
    let WCChangingDesk = _prefixId.prefix "WCChangingDesk"
    let WCChangingDesksScheme = _prefixId.prefix "WCChangingDesksScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of WC flushingsrdfs:label : Typy splachovani WC</para>
    ///   <a href="http://w3id.org/charta77/jup/WCFlushing">jup:WCFlushing</a>
    /// </summary>
    let WCFlushing = _prefixId.prefix "WCFlushing"
    let WCFlushingDifficultiesScheme = _prefixId.prefix "WCFlushingDifficultiesScheme"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of WC flushing difficultiesrdfs:label : Typy obtiznosti splachovani WC</para>
    ///   <a href="http://w3id.org/charta77/jup/WCFlushingDifficulty">jup:WCFlushingDifficulty</a>
    /// </summary>
    let WCFlushingDifficulty = _prefixId.prefix "WCFlushingDifficulty"
    let WCFlushingsScheme = _prefixId.prefix "WCFlushingsScheme"
    let WCHallway = _prefixId.prefix "WCHallway"
    let WCMKPOForm = _prefixId.prefix "WCMKPOForm"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of WC switchesrdfs:label : Typy vypinace</para>
    ///   <a href="http://w3id.org/charta77/jup/WCSwitch">jup:WCSwitch</a>
    /// </summary>
    let WCSwitch = _prefixId.prefix "WCSwitch"
    let WCSwitchesScheme = _prefixId.prefix "WCSwitchesScheme"
    let WashBasin = _prefixId.prefix "WashBasin"
    let WashBasinHandle = _prefixId.prefix "WashBasinHandle"
    let WashBasinTap = _prefixId.prefix "WashBasinTap"
    /// <summary>
    ///   <para>rdfs:comment : The list copied from the form based on Object Accessibility Categorization Methodologyrdfs:comment : Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>rdfs:label : Types of wash basin underpassesrdfs:label : Typy podjezdu umyvadla</para>
    ///   <a href="http://w3id.org/charta77/jup/WashBasinUnderpass">jup:WashBasinUnderpass</a>
    /// </summary>
    let WashBasinUnderpass = _prefixId.prefix "WashBasinUnderpass"
    let WashBasinUnderpassesScheme = _prefixId.prefix "WashBasinUnderpassesScheme"
    let WaterParkObjectCategory = _prefixId.prefix "WaterParkObjectCategory"
    let WeddingHallObjectCategory = _prefixId.prefix "WeddingHallObjectCategory"
    let WellnessObjectCategory = _prefixId.prefix "WellnessObjectCategory"
    let WinterStadiumObjectCategory = _prefixId.prefix "WinterStadiumObjectCategory"
    let YesWCSwitch = _prefixId.prefix "YesWCSwitch"
    let ZooObjectCategory = _prefixId.prefix "ZooObjectCategory"
    let access = _prefixId.prefix "access"
    /// <summary>
    ///   <para>rdfs:label : Access to entrance to the mappable entity provided byrdfs:label : Pristup ke vstupu mapovatelne entity zajisti</para>
    ///   <a href="http://w3id.org/charta77/jup/accessProvidedBy">jup:accessProvidedBy</a>
    /// </summary>
    let accessProvidedBy = _prefixId.prefix "accessProvidedBy"
    let accessibility = _prefixId.prefix "accessibility"
    let aobAboveDoor = _prefixId.prefix "aobAboveDoor"
    let aobAnnouncement = _prefixId.prefix "aobAnnouncement"
    let aobIsAboveDoor = _prefixId.prefix "aobIsAboveDoor"
    let aobLocalization = _prefixId.prefix "aobLocalization"
    let bellHeight = _prefixId.prefix "bellHeight"
    let bellIndentation = _prefixId.prefix "bellIndentation"
    let bellType = _prefixId.prefix "bellType"
    let belongsTo = _prefixId.prefix "belongsTo"
    let brailleLabelled = _prefixId.prefix "brailleLabelled"
    let certifiedRecord = _prefixId.prefix "certifiedRecord"
    let contrastMarked = _prefixId.prefix "contrastMarked"

    let contrastMarkingGlassSurfacesMarked = _prefixId.prefix "contrastMarkingGlassSurfacesMarked"

    let contrastMarkingIsGlassSurfacesMarked = _prefixId.prefix "contrastMarkingIsGlassSurfacesMarked"

    let contrastMarkingLocalization = _prefixId.prefix "contrastMarkingLocalization"
    let controlHeight = _prefixId.prefix "controlHeight"
    let createdBy = _prefixId.prefix "createdBy"
    let createdDate = _prefixId.prefix "createdDate"
    let doorBrailleLabelled = _prefixId.prefix "doorBrailleLabelled"
    let doorIsBrailleLabelled = _prefixId.prefix "doorIsBrailleLabelled"
    let doorIsMarked = _prefixId.prefix "doorIsMarked"
    let doorMainPanelWidth = _prefixId.prefix "doorMainPanelWidth"
    let doorMarked = _prefixId.prefix "doorMarked"
    let doorOpening = _prefixId.prefix "doorOpening"
    let doorOpeningDirection = _prefixId.prefix "doorOpeningDirection"
    let doorSidePanelWidth = _prefixId.prefix "doorSidePanelWidth"
    let doorStepHeight = _prefixId.prefix "doorStepHeight"
    let doorType = _prefixId.prefix "doorType"
    let doorWidth = _prefixId.prefix "doorWidth"
    let elevatorAccess = _prefixId.prefix "elevatorAccess"
    let elevatorAccessProvidedBy = _prefixId.prefix "elevatorAccessProvidedBy"

    let elevatorCageControlAnnouncementAcoustic = _prefixId.prefix "elevatorCageControlAnnouncementAcoustic"

    let elevatorCageControlAnnouncementPhonetic = _prefixId.prefix "elevatorCageControlAnnouncementPhonetic"

    let elevatorCageControlBrailleLabelled = _prefixId.prefix "elevatorCageControlBrailleLabelled"

    let elevatorCageControlDistance = _prefixId.prefix "elevatorCageControlDistance"

    let elevatorCageControlFlatMarking = _prefixId.prefix "elevatorCageControlFlatMarking"

    let elevatorCageControlHeight = _prefixId.prefix "elevatorCageControlHeight"

    let elevatorCageControlReliefMarking = _prefixId.prefix "elevatorCageControlReliefMarking"

    let elevatorCageDepth = _prefixId.prefix "elevatorCageDepth"
    let elevatorCageMirrorHeight = _prefixId.prefix "elevatorCageMirrorHeight"
    let elevatorCageMirrorInstalled = _prefixId.prefix "elevatorCageMirrorInstalled"

    let elevatorCageMirrorLocalization = _prefixId.prefix "elevatorCageMirrorLocalization"

    let elevatorCagePassthrough = _prefixId.prefix "elevatorCagePassthrough"
    let elevatorCageSeatFunctional = _prefixId.prefix "elevatorCageSeatFunctional"
    let elevatorCageSeatInstalled = _prefixId.prefix "elevatorCageSeatInstalled"
    let elevatorCageSeatWithinReach = _prefixId.prefix "elevatorCageSeatWithinReach"

    let elevatorCageSecondDoorLocalization = _prefixId.prefix "elevatorCageSecondDoorLocalization"

    let elevatorCageWidth = _prefixId.prefix "elevatorCageWidth"
    /// <summary>
    ///   <para>rdfs:label : Elevator connects floorsrdfs:label : Vytah spojuje patra</para>
    ///   <a href="http://w3id.org/charta77/jup/elevatorConnectsFloors">jup:elevatorConnectsFloors</a>
    /// </summary>
    let elevatorConnectsFloors = _prefixId.prefix "elevatorConnectsFloors"

    let elevatorControlBrailleLabelled = _prefixId.prefix "elevatorControlBrailleLabelled"

    let elevatorControlFlatMarking = _prefixId.prefix "elevatorControlFlatMarking"
    let elevatorControlMaxHeight = _prefixId.prefix "elevatorControlMaxHeight"
    let elevatorControlReliefMarking = _prefixId.prefix "elevatorControlReliefMarking"
    let elevatorDriveOff = _prefixId.prefix "elevatorDriveOff"

    let elevatorIsCageControlAnnouncementAcoustic = _prefixId.prefix "elevatorIsCageControlAnnouncementAcoustic"

    let elevatorIsCageControlAnnouncementPhonetic = _prefixId.prefix "elevatorIsCageControlAnnouncementPhonetic"

    let elevatorIsCageControlBrailleMarking = _prefixId.prefix "elevatorIsCageControlBrailleMarking"

    let elevatorIsCageMirror = _prefixId.prefix "elevatorIsCageMirror"
    let elevatorIsCagePassthrough = _prefixId.prefix "elevatorIsCagePassthrough"
    let elevatorIsCageSeat = _prefixId.prefix "elevatorIsCageSeat"
    let elevatorIsCageSeatFunctional = _prefixId.prefix "elevatorIsCageSeatFunctional"
    let elevatorIsCageSeatWithinReach = _prefixId.prefix "elevatorIsCageSeatWithinReach"

    let elevatorIsControlBrailleMarking = _prefixId.prefix "elevatorIsControlBrailleMarking"

    let elevatorLocalization = _prefixId.prefix "elevatorLocalization"
    let elevatorType = _prefixId.prefix "elevatorType"
    let entranceAccess = _prefixId.prefix "entranceAccess"
    let entranceAccessProvidedBy = _prefixId.prefix "entranceAccessProvidedBy"
    let entranceAccessibility = _prefixId.prefix "entranceAccessibility"
    let entranceAreaBeforeDoorDepth = _prefixId.prefix "entranceAreaBeforeDoorDepth"
    let entranceAreaBeforeDoorWidth = _prefixId.prefix "entranceAreaBeforeDoorWidth"

    /// <summary>
    ///   <para>rdfs:label : Type of difficult surface: (rough historical pavement, cracked tarmac…)rdfs:label : Typ obtizneho povrchu (hruba historicka dlazba, popraskany asfalt…)</para>
    ///   <a href="http://w3id.org/charta77/jup/entranceDifficultSurfaceDescription">jup:entranceDifficultSurfaceDescription</a>
    /// </summary>
    let entranceDifficultSurfaceDescription = _prefixId.prefix "entranceDifficultSurfaceDescription"

    let entranceGuidingLine = _prefixId.prefix "entranceGuidingLine"
    let entranceIsDifficultSurface = _prefixId.prefix "entranceIsDifficultSurface"

    let entranceIsLongitudinalInclination = _prefixId.prefix "entranceIsLongitudinalInclination"

    let entranceIsReservedParking = _prefixId.prefix "entranceIsReservedParking"

    let entranceIsSideEntranceInformation = _prefixId.prefix "entranceIsSideEntranceInformation"

    let entranceIsSideEntranceMarked = _prefixId.prefix "entranceIsSideEntranceMarked"
    let entranceIsStepContrastMarked = _prefixId.prefix "entranceIsStepContrastMarked"

    let entranceIsTransverseInclination = _prefixId.prefix "entranceIsTransverseInclination"

    let entranceLobbyDepth = _prefixId.prefix "entranceLobbyDepth"
    let entranceLobbyWidth = _prefixId.prefix "entranceLobbyWidth"
    let entranceLocalization = _prefixId.prefix "entranceLocalization"

    let entranceLongitudinalInclination = _prefixId.prefix "entranceLongitudinalInclination"

    /// <summary>
    ///   <para>rdfs:label : Longitudinal inclination localization: (access communication, area before the entrance)rdfs:label : Lokalizace podelneho sklonu (pristupova komunikace, prostor pred vstupem,...)</para>
    ///   <a href="http://w3id.org/charta77/jup/entranceLongitudinalInclinationLocalization">jup:entranceLongitudinalInclinationLocalization</a>
    /// </summary>
    let entranceLongitudinalInclinationLocalization = _prefixId.prefix "entranceLongitudinalInclinationLocalization"

    let entranceNumberOfReservedParking = _prefixId.prefix "entranceNumberOfReservedParking"

    /// <summary>
    ///   <para>rdfs:label : Access from reserved parking places to the building entrance: (barrier-free, curb without a ramp, narrowing…)rdfs:label : Pristup od vyhrazeneho parkovaciho stani ke vstupu objektu (bezbarierovy, obrubnik bez najezdu, zuzeni…)</para>
    ///   <a href="http://w3id.org/charta77/jup/entranceReservedParkingAccessDescription">jup:entranceReservedParkingAccessDescription</a>
    /// </summary>
    let entranceReservedParkingAccessDescription = _prefixId.prefix "entranceReservedParkingAccessDescription"

    /// <summary>
    ///   <para>rdfs:label : Reserved parking places localizationrdfs:label : Lokalizace vyhrazeneho parkovaciho stani</para>
    ///   <a href="http://w3id.org/charta77/jup/entranceReservedParkingLocalization">jup:entranceReservedParkingLocalization</a>
    /// </summary>
    let entranceReservedParkingLocalization = _prefixId.prefix "entranceReservedParkingLocalization"

    let entranceSideEntranceDescribed = _prefixId.prefix "entranceSideEntranceDescribed"
    let entranceTransverseInclination = _prefixId.prefix "entranceTransverseInclination"

    /// <summary>
    ///   <para>rdfs:label : Transverse inclination localization: (access communication, area before the entrance)rdfs:label : Lokalizace pricneho sklonu (pristupova komunikace, prostor pred vstupem,...)</para>
    ///   <a href="http://w3id.org/charta77/jup/entranceTransverseInclinationLocalization">jup:entranceTransverseInclinationLocalization</a>
    /// </summary>
    let entranceTransverseInclinationLocalization = _prefixId.prefix "entranceTransverseInclinationLocalization"

    let entryAreaDepth = _prefixId.prefix "entryAreaDepth"
    let entryAreaEntry = _prefixId.prefix "entryAreaEntry"
    let entryAreaEntryClosing = _prefixId.prefix "entryAreaEntryClosing"
    let entryAreaEntryWidth = _prefixId.prefix "entryAreaEntryWidth"
    let entryAreaHeightElevation = _prefixId.prefix "entryAreaHeightElevation"
    let entryAreaIsEntryClosing = _prefixId.prefix "entryAreaIsEntryClosing"
    let entryAreaWidth = _prefixId.prefix "entryAreaWidth"
    /// <summary>
    ///   <para>rdfs:label : entity mapped by the formrdfs:label : entita, kterou formular mapuje</para>
    ///   <a href="http://w3id.org/charta77/jup/formMaps">jup:formMaps</a>
    /// </summary>
    let formMaps = _prefixId.prefix "formMaps"
    /// <summary>
    ///   <para>rdfs:label : Type of form mapping entityrdfs:label : Typ formulare mapujici entitu</para>
    ///   <a href="http://w3id.org/charta77/jup/formType">jup:formType</a>
    /// </summary>
    let formType = _prefixId.prefix "formType"
    let hallwayDepth = _prefixId.prefix "hallwayDepth"
    let hallwayWidth = _prefixId.prefix "hallwayWidth"
    let handleHeight = _prefixId.prefix "handleHeight"
    let handleLength = _prefixId.prefix "handleLength"
    let handleLocalization = _prefixId.prefix "handleLocalization"
    let handleOrientation = _prefixId.prefix "handleOrientation"
    let handlePosition = _prefixId.prefix "handlePosition"
    let handleType = _prefixId.prefix "handleType"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : To complete the vocabularyrdfs:comment : Pro uplnost slovniku</para>
    ///   <para>rdfs:label : Attachmentrdfs:label : Priloha</para>
    ///   <a href="http://w3id.org/charta77/jup/hasAttachment">jup:hasAttachment</a>
    /// </summary>
    let hasAttachment = _prefixId.prefix "hasAttachment"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Verbal section descriptionrdfs:label : Slovni popis useku</para>
    ///   <a href="http://w3id.org/charta77/jup/hasDescription">jup:hasDescription</a>
    /// </summary>
    let hasDescription = _prefixId.prefix "hasDescription"
    /// <summary>
    ///   <para>rdfs:label : Entity described by a formrdfs:label : Entita je popsana formularem</para>
    ///   <a href="http://w3id.org/charta77/jup/hasForm">jup:hasForm</a>
    /// </summary>
    let hasForm = _prefixId.prefix "hasForm"
    let hasIdentifier = _prefixId.prefix "hasIdentifier"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Addressable entity latituderdfs:label : Zemepisna sirka adresovatelne entity</para>
    ///   <a href="http://w3id.org/charta77/jup/hasLatitude">jup:hasLatitude</a>
    /// </summary>
    let hasLatitude = _prefixId.prefix "hasLatitude"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Addressable entity longituderdfs:label : Zemepisna delka adresovatelne entity</para>
    ///   <a href="http://w3id.org/charta77/jup/hasLongitude">jup:hasLongitude</a>
    /// </summary>
    let hasLongitude = _prefixId.prefix "hasLongitude"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Official namerdfs:label : Oficialni nazev</para>
    ///   <a href="http://w3id.org/charta77/jup/hasName">jup:hasName</a>
    /// </summary>
    let hasName = _prefixId.prefix "hasName"
    /// <summary>
    ///   <para>rdfs:comment : Adapted WC: poor anchorage of handles, handle attached to side wall,...rdfs:comment : Upravene WC: spatne ukotveni madel, madlo kotvene na bocni stene,...</para>
    ///   <para>rdfs:label : Mappable entity notesrdfs:label : Poznamky k mapovatelne entite</para>
    ///   <a href="http://w3id.org/charta77/jup/hasNotes">jup:hasNotes</a>
    /// </summary>
    let hasNotes = _prefixId.prefix "hasNotes"
    let hasPart = _prefixId.prefix "hasPart"
    let hasPlace = _prefixId.prefix "hasPlace"
    /// <summary>
    ///   <para>rdfs:comment : Short and formated description summarizing form data, understandable to the wide publicrdfs:comment : Strucny, pro laiky srozumitelny, formatovany text shrnujici udaje z formularu</para>
    ///   <para>rdfs:label : Text desciption of an objectrdfs:label : Textovy popis objektu</para>
    ///   <a href="http://w3id.org/charta77/jup/hasSummary">jup:hasSummary</a>
    /// </summary>
    let hasSummary = _prefixId.prefix "hasSummary"
    let isCertifiedRecord = _prefixId.prefix "isCertifiedRecord"
    let isUpToDateRecord = _prefixId.prefix "isUpToDateRecord"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : To complete the vocabularyrdfs:comment : Pro uplnost slovniku</para>
    ///   <para>rdfs:label : Open licence to mappable entity datardfs:label : Licence, pod kterou jsou data o mapovatelne entite uvolnena</para>
    ///   <a href="http://w3id.org/charta77/jup/license">jup:license</a>
    /// </summary>
    let license = _prefixId.prefix "license"
    /// <summary>
    ///   <para>rdfs:label : Localization of mappable entityrdfs:label : Lokalizace mapovatelne entity</para>
    ///   <a href="http://w3id.org/charta77/jup/localization">jup:localization</a>
    /// </summary>
    let localization = _prefixId.prefix "localization"
    let mappableEntityAccess = _prefixId.prefix "mappableEntityAccess"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Access to entrance to the mappable entity provided byrdfs:label : Pristup ke vstupu mapovatelne entity zajisti</para>
    ///   <a href="http://w3id.org/charta77/jup/mappableEntityAccessProvidedBy">jup:mappableEntityAccessProvidedBy</a>
    /// </summary>
    let mappableEntityAccessProvidedBy = _prefixId.prefix "mappableEntityAccessProvidedBy"

    let mappableEntityAccessibility = _prefixId.prefix "mappableEntityAccessibility"
    let mappableEntityControlHeight = _prefixId.prefix "mappableEntityControlHeight"

    let mappableEntityIsBrailleMarking = _prefixId.prefix "mappableEntityIsBrailleMarking"

    let mappableEntityIsContrastMarking = _prefixId.prefix "mappableEntityIsContrastMarking"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Localization of mappable entityrdfs:label : Lokalizace mapovatelne entity</para>
    ///   <a href="http://w3id.org/charta77/jup/mappableEntityLocalization">jup:mappableEntityLocalization</a>
    /// </summary>
    let mappableEntityLocalization = _prefixId.prefix "mappableEntityLocalization"
    let mappableEntityMirrorHeight = _prefixId.prefix "mappableEntityMirrorHeight"
    let mappableEntityPassageWidth = _prefixId.prefix "mappableEntityPassageWidth"
    let mappableEntitySeatHeight = _prefixId.prefix "mappableEntitySeatHeight"
    let mappableEntitySwitchHeight = _prefixId.prefix "mappableEntitySwitchHeight"
    let mappableEntityThresholdHeight = _prefixId.prefix "mappableEntityThresholdHeight"
    let mapperCertified = _prefixId.prefix "mapperCertified"
    let mapperIsCertified = _prefixId.prefix "mapperIsCertified"
    let mapperNick = _prefixId.prefix "mapperNick"
    let mirrorHeight = _prefixId.prefix "mirrorHeight"
    let narrowedPassageWidth = _prefixId.prefix "narrowedPassageWidth"
    /// <summary>
    ///   <para>rdfs:label : Haptic, electronic,...rdfs:label : Hapticky, elektronicky…</para>
    ///   <a href="http://w3id.org/charta77/jup/navigationSystemDescription">jup:navigationSystemDescription</a>
    /// </summary>
    let navigationSystemDescription = _prefixId.prefix "navigationSystemDescription"
    let objectAccessibilityMKPO = _prefixId.prefix "objectAccessibilityMKPO"
    let objectCategory = _prefixId.prefix "objectCategory"
    let objectInteriorAccessibility = _prefixId.prefix "objectInteriorAccessibility"
    let objectIsNarrowedPassage = _prefixId.prefix "objectIsNarrowedPassage"
    let objectIsNavigationSystem = _prefixId.prefix "objectIsNavigationSystem"
    let objectIsStairs = _prefixId.prefix "objectIsStairs"
    let objectIsTourniquet = _prefixId.prefix "objectIsTourniquet"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Narrowed passage localizationrdfs:label : Lokalizace zuzeneho pruchodu</para>
    ///   <a href="http://w3id.org/charta77/jup/objectNarrowedPassageLocalization">jup:objectNarrowedPassageLocalization</a>
    /// </summary>
    let objectNarrowedPassageLocalization = _prefixId.prefix "objectNarrowedPassageLocalization"

    let objectNarrowedPassageWidth = _prefixId.prefix "objectNarrowedPassageWidth"

    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Haptic, electronic,...rdfs:label : Hapticky, elektronicky…</para>
    ///   <a href="http://w3id.org/charta77/jup/objectNavigationSystemDescription">jup:objectNavigationSystemDescription</a>
    /// </summary>
    let objectNavigationSystemDescription = _prefixId.prefix "objectNavigationSystemDescription"

    let objectStairsIsBannister = _prefixId.prefix "objectStairsIsBannister"
    let objectStairsType = _prefixId.prefix "objectStairsType"
    let objectStairsWidth = _prefixId.prefix "objectStairsWidth"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:label : Tourniquet localizationrdfs:label : Lokalizace turniketu</para>
    ///   <a href="http://w3id.org/charta77/jup/objectTourniquetLocalization">jup:objectTourniquetLocalization</a>
    /// </summary>
    let objectTourniquetLocalization = _prefixId.prefix "objectTourniquetLocalization"
    /// <summary>
    ///   <para>rdfs:label : Mappable entities relationshiprdfs:label : Vztah mapovatelnych entit</para>
    ///   <a href="http://w3id.org/charta77/jup/partOf">jup:partOf</a>
    /// </summary>
    let partOf = _prefixId.prefix "partOf"
    let passageWidth = _prefixId.prefix "passageWidth"
    let platformAccess = _prefixId.prefix "platformAccess"
    let platformDepth = _prefixId.prefix "platformDepth"
    let platformInsideControlHeight = _prefixId.prefix "platformInsideControlHeight"
    let platformIsMinParameters = _prefixId.prefix "platformIsMinParameters"
    let platformLocalization = _prefixId.prefix "platformLocalization"
    let platformMaxLoad = _prefixId.prefix "platformMaxLoad"
    let platformMinParameters = _prefixId.prefix "platformMinParameters"
    let platformNumberOfFloors = _prefixId.prefix "platformNumberOfFloors"
    let platformNumberOfSteps = _prefixId.prefix "platformNumberOfSteps"

    let platformOutsideBottomControlHeight = _prefixId.prefix "platformOutsideBottomControlHeight"

    let platformOutsideTopControlHeight = _prefixId.prefix "platformOutsideTopControlHeight"

    let platformType = _prefixId.prefix "platformType"
    let platformWidth = _prefixId.prefix "platformWidth"
    /// <summary>
    ///   <para>rdfs:label : Access to the ramp provided byrdfs:label : Pristup k rampe zajisti</para>
    ///   <a href="http://w3id.org/charta77/jup/rampAccessProvidedBy">jup:rampAccessProvidedBy</a>
    /// </summary>
    let rampAccessProvidedBy = _prefixId.prefix "rampAccessProvidedBy"
    let rampLegInclination = _prefixId.prefix "rampLegInclination"
    let rampLegLength = _prefixId.prefix "rampLegLength"
    let rampLegWidth = _prefixId.prefix "rampLegWidth"
    let rampNumberOfLegs = _prefixId.prefix "rampNumberOfLegs"
    let rampSkidsInteriorLocalization = _prefixId.prefix "rampSkidsInteriorLocalization"
    let rampSkidsLocalization = _prefixId.prefix "rampSkidsLocalization"
    let rampSkidsMobility = _prefixId.prefix "rampSkidsMobility"
    let rampSurface = _prefixId.prefix "rampSurface"
    let rampType = _prefixId.prefix "rampType"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : To complete the vocabularyrdfs:comment : Pro uplnost slovniku</para>
    ///   <para>rdfs:label : Equality of individualsrdfs:label : Rovnost individui</para>
    ///   <a href="http://w3id.org/charta77/jup/sameAs">jup:sameAs</a>
    /// </summary>
    let sameAs = _prefixId.prefix "sameAs"
    let seatHeight = _prefixId.prefix "seatHeight"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : Defined to complete the vocabularyrdfs:comment : Definovano z duvodu uplnosti slovniku</para>
    ///   <para>rdfs:label : Entity information source referencerdfs:label : Odkaz na zdroj informaci o entite</para>
    ///   <a href="http://w3id.org/charta77/jup/seeAlso">jup:seeAlso</a>
    /// </summary>
    let seeAlso = _prefixId.prefix "seeAlso"
    let skidsInclination = _prefixId.prefix "skidsInclination"
    let skidsLength = _prefixId.prefix "skidsLength"
    /// <summary>
    ///   <para>owl:deprecated : true^^xsd:boolean</para>
    ///   <para>rdfs:comment : To complete the vocabularyrdfs:comment : Pro uplnost slovniku</para>
    ///   <para>rdfs:label : Mappable entity data sourcerdfs:label : Zdroj dat o mapovatelne entite</para>
    ///   <a href="http://w3id.org/charta77/jup/source">jup:source</a>
    /// </summary>
    let source = _prefixId.prefix "source"
    let stepsContrastMarked = _prefixId.prefix "stepsContrastMarked"
    let stepsDepth = _prefixId.prefix "stepsDepth"
    let stepsHeight = _prefixId.prefix "stepsHeight"
    let stepsIsContrastMarked = _prefixId.prefix "stepsIsContrastMarked"
    let stepsLocalization = _prefixId.prefix "stepsLocalization"
    let stepsNumberOf = _prefixId.prefix "stepsNumberOf"
    let stepsType = _prefixId.prefix "stepsType"
    let stepsWidth = _prefixId.prefix "stepsWidth"
    let switchHeight = _prefixId.prefix "switchHeight"
    let tapHeight = _prefixId.prefix "tapHeight"
    let tapType = _prefixId.prefix "tapType"
    let thresholdHeight = _prefixId.prefix "thresholdHeight"
    let tourniquetLocalization = _prefixId.prefix "tourniquetLocalization"
    let upToDateRecord = _prefixId.prefix "upToDateRecord"
    let washBasinHeight = _prefixId.prefix "washBasinHeight"
    let washBasinUnderpass = _prefixId.prefix "washBasinUnderpass"
    let wcAccessibilityMKPO = _prefixId.prefix "wcAccessibilityMKPO"
    let wcAlarmButtonBottomHeight = _prefixId.prefix "wcAlarmButtonBottomHeight"
    let wcAlarmButtonInstalled = _prefixId.prefix "wcAlarmButtonInstalled"
    let wcAlarmButtonTopHeight = _prefixId.prefix "wcAlarmButtonTopHeight"
    let wcBasinBackIndentation = _prefixId.prefix "wcBasinBackIndentation"
    let wcBasinIsPaperReach = _prefixId.prefix "wcBasinIsPaperReach"
    let wcBasinLeftDistance = _prefixId.prefix "wcBasinLeftDistance"
    let wcBasinPaperWithinReach = _prefixId.prefix "wcBasinPaperWithinReach"
    let wcBasinRightDistance = _prefixId.prefix "wcBasinRightDistance"
    let wcBasinSeatHeight = _prefixId.prefix "wcBasinSeatHeight"
    let wcBasinSpace = _prefixId.prefix "wcBasinSpace"
    let wcCabinAccess = _prefixId.prefix "wcCabinAccess"
    let wcCabinDepth = _prefixId.prefix "wcCabinDepth"
    let wcCabinDoorDisposition = _prefixId.prefix "wcCabinDoorDisposition"
    let wcCabinLocalization = _prefixId.prefix "wcCabinLocalization"
    let wcCabinWCBasinDisposition = _prefixId.prefix "wcCabinWCBasinDisposition"
    let wcCabinWashBasinDisposition = _prefixId.prefix "wcCabinWashBasinDisposition"
    let wcCabinWidth = _prefixId.prefix "wcCabinWidth"
    let wcChangingDesk = _prefixId.prefix "wcChangingDesk"
    let wcChangingDeskInstalled = _prefixId.prefix "wcChangingDeskInstalled"
    let wcChangingDeskObstructs = _prefixId.prefix "wcChangingDeskObstructs"
    let wcFlushing = _prefixId.prefix "wcFlushing"
    let wcFlushingBackHeight = _prefixId.prefix "wcFlushingBackHeight"
    let wcFlushingDifficulty = _prefixId.prefix "wcFlushingDifficulty"
    let wcFlushingSideDistance = _prefixId.prefix "wcFlushingSideDistance"
    let wcFlushingSideHeight = _prefixId.prefix "wcFlushingSideHeight"
    let wcHandlesDistance = _prefixId.prefix "wcHandlesDistance"
    let wcIsAlarmButton = _prefixId.prefix "wcIsAlarmButton"
    let wcIsChangingDesk = _prefixId.prefix "wcIsChangingDesk"
    let wcIsChangingDeskObstructs = _prefixId.prefix "wcIsChangingDeskObstructs"
    let wcIsRegularWC = _prefixId.prefix "wcIsRegularWC"
    let wcIsRegularWCBrailleMarking = _prefixId.prefix "wcIsRegularWCBrailleMarking"
    let wcLocalization = _prefixId.prefix "wcLocalization"
    let wcRegularWC = _prefixId.prefix "wcRegularWC"
    let wcRegularWCBrailleLabelled = _prefixId.prefix "wcRegularWCBrailleLabelled"
    let wcSwitch = _prefixId.prefix "wcSwitch"
    let wcSwitchHeight = _prefixId.prefix "wcSwitchHeight"
