namespace http.w3id.org.charta77.jup.slash

open DoxAletheia

module jup =
    let _namespace_name = "http://w3id.org/charta77/jup/"

    let _prefix local_name =
        Namespaced_IRI.parse _namespace_name local_name |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AOB"></see>
    /// </summary>
    let AOB = _prefix "AOB"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasForm"></see>
    /// </summary>
    let hasForm = _prefix "hasForm"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ElevatorMKPOForm"></see>
    /// </summary>
    let ElevatorMKPOForm = _prefix "ElevatorMKPOForm"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectMKPOForm"></see>
    /// </summary>
    let ObjectMKPOForm = _prefix "ObjectMKPOForm"
    /// <summary>
    /// Defined to complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/seeAlso"></see></summary>
    let seeAlso = _prefix "seeAlso"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PhysicalEntity"></see>
    /// </summary>
    let PhysicalEntity = _prefix "PhysicalEntity"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MappableEntity"></see>
    /// </summary>
    let MappableEntity = _prefix "MappableEntity"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/AOBAnnouncement"></see></summary>
    let AOBAnnouncement = _prefix "AOBAnnouncement"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/AOBAnnouncementsScheme"></see></summary>
    let AOBAnnouncementsScheme = _prefix "AOBAnnouncementsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AccessibleObjectMKPO"></see>
    /// </summary>
    let AccessibleObjectMKPO = _prefix "AccessibleObjectMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectCategorizationMKPO"></see>
    /// </summary>
    let ObjectCategorizationMKPO = _prefix "ObjectCategorizationMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectCategorizationsMKPOScheme"></see>
    /// </summary>
    let ObjectCategorizationsMKPOScheme = _prefix "ObjectCategorizationsMKPOScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AccessibleWCMKPO"></see>
    /// </summary>
    let AccessibleWCMKPO = _prefix "AccessibleWCMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCCategorizationMKPO"></see>
    /// </summary>
    let WCCategorizationMKPO = _prefix "WCCategorizationMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCCategorizationsMKPOScheme"></see>
    /// </summary>
    let WCCategorizationsMKPOScheme = _prefix "WCCategorizationsMKPOScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AddressableEntity"></see>
    /// </summary>
    let AddressableEntity = _prefix "AddressableEntity"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AdministrativeOfficeObjectCategory"></see>
    /// </summary>
    let AdministrativeOfficeObjectCategory =
        _prefix "AdministrativeOfficeObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectCategory"></see>
    /// </summary>
    let ObjectCategory = _prefix "ObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectCategoriesScheme"></see>
    /// </summary>
    let ObjectCategoriesScheme = _prefix "ObjectCategoriesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AirportObjectCategory"></see>
    /// </summary>
    let AirportObjectCategory = _prefix "AirportObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ArtificialEntranceGuidingLine"></see>
    /// </summary>
    let ArtificialEntranceGuidingLine = _prefix "ArtificialEntranceGuidingLine"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/EntranceGuidingLine"></see></summary>
    let EntranceGuidingLine = _prefix "EntranceGuidingLine"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/EntranceGuidingLinesScheme"></see></summary>
    let EntranceGuidingLinesScheme = _prefix "EntranceGuidingLinesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AssessableEntity"></see>
    /// </summary>
    let AssessableEntity = _prefix "AssessableEntity"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AutomaticDoorOpening"></see>
    /// </summary>
    let AutomaticDoorOpening = _prefix "AutomaticDoorOpening"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorOpening"></see></summary>
    let DoorOpening = _prefix "DoorOpening"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorOpeningsScheme"></see></summary>
    let DoorOpeningsScheme = _prefix "DoorOpeningsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AutomaticWCFlushing"></see>
    /// </summary>
    let AutomaticWCFlushing = _prefix "AutomaticWCFlushing"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCFlushing"></see></summary>
    let WCFlushing = _prefix "WCFlushing"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCFlushingsScheme"></see></summary>
    let WCFlushingsScheme = _prefix "WCFlushingsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AutomaticWCSwitch"></see>
    /// </summary>
    let AutomaticWCSwitch = _prefix "AutomaticWCSwitch"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCSwitch"></see></summary>
    let WCSwitch = _prefix "WCSwitch"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCSwitchesScheme"></see></summary>
    let WCSwitchesScheme = _prefix "WCSwitchesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BankObjectCategory"></see>
    /// </summary>
    let BankObjectCategory = _prefix "BankObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Bannister"></see>
    /// </summary>
    let Bannister = _prefix "Bannister"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BarObjectCategory"></see>
    /// </summary>
    let BarObjectCategory = _prefix "BarObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BasilicaObjectCategory"></see>
    /// </summary>
    let BasilicaObjectCategory = _prefix "BasilicaObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Bell"></see>
    /// </summary>
    let Bell = _prefix "Bell"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PlatformMKPOForm"></see>
    /// </summary>
    let PlatformMKPOForm = _prefix "PlatformMKPOForm"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/BellType"></see></summary>
    let BellType = _prefix "BellType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/BellTypesScheme"></see></summary>
    let BellTypesScheme = _prefix "BellTypesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BentRampType"></see>
    /// </summary>
    let BentRampType = _prefix "BentRampType"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampType"></see></summary>
    let RampType = _prefix "RampType"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampTypesScheme"></see></summary>
    let RampTypesScheme = _prefix "RampTypesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BlockedByFixedWCBasinSpace"></see>
    /// </summary>
    let BlockedByFixedWCBasinSpace = _prefix "BlockedByFixedWCBasinSpace"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCBasinSpace"></see></summary>
    let WCBasinSpace = _prefix "WCBasinSpace"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCBasinSpacesScheme"></see></summary>
    let WCBasinSpacesScheme = _prefix "WCBasinSpacesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BlockedByMobileWCBasinSpace"></see>
    /// </summary>
    let BlockedByMobileWCBasinSpace = _prefix "BlockedByMobileWCBasinSpace"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BotanicGardenObjectCategory"></see>
    /// </summary>
    let BotanicGardenObjectCategory = _prefix "BotanicGardenObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BottomContrastMarkingLocalization"></see>
    /// </summary>
    let BottomContrastMarkingLocalization = _prefix "BottomContrastMarkingLocalization"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ContrastMarkingLocalization"></see></summary>
    let ContrastMarkingLocalization = _prefix "ContrastMarkingLocalization"

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ContrastMarkingLocalizationsScheme"></see></summary>
    let ContrastMarkingLocalizationsScheme =
        _prefix "ContrastMarkingLocalizationsScheme"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BottomEntryArea"></see>
    /// </summary>
    let BottomEntryArea = _prefix "BottomEntryArea"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RampSkidsMKPOForm"></see>
    /// </summary>
    let RampSkidsMKPOForm = _prefix "RampSkidsMKPOForm"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EntryArea"></see>
    /// </summary>
    let EntryArea = _prefix "EntryArea"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BottomLeftWCCabinDisposition"></see>
    /// </summary>
    let BottomLeftWCCabinDisposition = _prefix "BottomLeftWCCabinDisposition"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCCabinDisposition"></see></summary>
    let WCCabinDisposition = _prefix "WCCabinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCCabinDispositionsScheme"></see>
    /// </summary>
    let WCCabinDispositionsScheme = _prefix "WCCabinDispositionsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BottomRightWCCabinDisposition"></see>
    /// </summary>
    let BottomRightWCCabinDisposition = _prefix "BottomRightWCCabinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BreweryObjectCategory"></see>
    /// </summary>
    let BreweryObjectCategory = _prefix "BreweryObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BusStationObjectCategory"></see>
    /// </summary>
    let BusStationObjectCategory = _prefix "BusStationObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CampObjectCategory"></see>
    /// </summary>
    let CampObjectCategory = _prefix "CampObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CarDealerObjectCategory"></see>
    /// </summary>
    let CarDealerObjectCategory = _prefix "CarDealerObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CargoElevatorType"></see>
    /// </summary>
    let CargoElevatorType = _prefix "CargoElevatorType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorType"></see></summary>
    let ElevatorType = _prefix "ElevatorType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorTypesScheme"></see></summary>
    let ElevatorTypesScheme = _prefix "ElevatorTypesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CarouselDoorType"></see>
    /// </summary>
    let CarouselDoorType = _prefix "CarouselDoorType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorType"></see></summary>
    let DoorType = _prefix "DoorType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorTypesScheme"></see></summary>
    let DoorTypesScheme = _prefix "DoorTypesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CathedralObjectCategory"></see>
    /// </summary>
    let CathedralObjectCategory = _prefix "CathedralObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ChapelObjectCategory"></see>
    /// </summary>
    let ChapelObjectCategory = _prefix "ChapelObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ChurchObjectCategory"></see>
    /// </summary>
    let ChurchObjectCategory = _prefix "ChurchObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CinemaObjectCategory"></see>
    /// </summary>
    let CinemaObjectCategory = _prefix "CinemaObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CityHallObjectCategory"></see>
    /// </summary>
    let CityHallObjectCategory = _prefix "CityHallObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CollegeObjectCategory"></see>
    /// </summary>
    let CollegeObjectCategory = _prefix "CollegeObjectCategory"
    /// <summary>
    /// e.g. Prague Castle
    /// <see href="http://w3id.org/charta77/jup/Complex"></see></summary>
    let Complex = _prefix "Complex"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ConcertHallObjectCategory"></see>
    /// </summary>
    let ConcertHallObjectCategory = _prefix "ConcertHallObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ContactSocialServiceObjectCategory"></see>
    /// </summary>
    let ContactSocialServiceObjectCategory =
        _prefix "ContactSocialServiceObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ContrastMarking"></see>
    /// </summary>
    let ContrastMarking = _prefix "ContrastMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCMKPOForm"></see>
    /// </summary>
    let WCMKPOForm = _prefix "WCMKPOForm"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CourtObjectCategory"></see>
    /// </summary>
    let CourtObjectCategory = _prefix "CourtObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DefensiveCastleObjectCategory"></see>
    /// </summary>
    let DefensiveCastleObjectCategory = _prefix "DefensiveCastleObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DentalEmergencyObjectCategory"></see>
    /// </summary>
    let DentalEmergencyObjectCategory = _prefix "DentalEmergencyObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DepartmentStoreObjectCategory"></see>
    /// </summary>
    let DepartmentStoreObjectCategory = _prefix "DepartmentStoreObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DifficultWCFlushingDifficulty"></see>
    /// </summary>
    let DifficultWCFlushingDifficulty = _prefix "DifficultWCFlushingDifficulty"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCFlushingDifficulty"></see></summary>
    let WCFlushingDifficulty = _prefix "WCFlushingDifficulty"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCFlushingDifficultiesScheme"></see></summary>
    let WCFlushingDifficultiesScheme = _prefix "WCFlushingDifficultiesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DigitalElevatorControlFlatMarking"></see>
    /// </summary>
    let DigitalElevatorControlFlatMarking = _prefix "DigitalElevatorControlFlatMarking"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorControlFlatMarking"></see></summary>
    let ElevatorControlFlatMarking = _prefix "ElevatorControlFlatMarking"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorControlFlatMarkingsScheme"></see></summary>
    let ElevatorControlFlatMarkingsScheme = _prefix "ElevatorControlFlatMarkingsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DirectObjectStairsType"></see>
    /// </summary>
    let DirectObjectStairsType = _prefix "DirectObjectStairsType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/StepsStairsType"></see></summary>
    let StepsStairsType = _prefix "StepsStairsType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/StepsStairsTypesScheme"></see></summary>
    let StepsStairsTypesScheme = _prefix "StepsStairsTypesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DirectRampType"></see>
    /// </summary>
    let DirectRampType = _prefix "DirectRampType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DoctorObjectCategory"></see>
    /// </summary>
    let DoctorObjectCategory = _prefix "DoctorObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Door"></see>
    /// </summary>
    let Door = _prefix "Door"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorOpeningDirection"></see></summary>
    let DoorOpeningDirection = _prefix "DoorOpeningDirection"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorOpeningDirectionsScheme"></see></summary>
    let DoorOpeningDirectionsScheme = _prefix "DoorOpeningDirectionsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DoublePanelledDoorType"></see>
    /// </summary>
    let DoublePanelledDoorType = _prefix "DoublePanelledDoorType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Elevator"></see>
    /// </summary>
    let Elevator = _prefix "Elevator"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ElevatorCageDoor"></see>
    /// </summary>
    let ElevatorCageDoor = _prefix "ElevatorCageDoor"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ElevatorCageHandle"></see>
    /// </summary>
    let ElevatorCageHandle = _prefix "ElevatorCageHandle"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Handle"></see>
    /// </summary>
    let Handle = _prefix "Handle"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorCageMirrorLocalization"></see></summary>
    let ElevatorCageMirrorLocalization = _prefix "ElevatorCageMirrorLocalization"

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorCageMirrorLocalizationsScheme"></see></summary>
    let ElevatorCageMirrorLocalizationsScheme =
        _prefix "ElevatorCageMirrorLocalizationsScheme"

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorCageSecondDoorLocalization"></see></summary>
    let ElevatorCageSecondDoorLocalization =
        _prefix "ElevatorCageSecondDoorLocalization"

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorCageSecondDoorLocalizationsScheme"></see></summary>
    let ElevatorCageSecondDoorLocalizationsScheme =
        _prefix "ElevatorCageSecondDoorLocalizationsScheme"

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorControlReliefMarking"></see></summary>
    let ElevatorControlReliefMarking = _prefix "ElevatorControlReliefMarking"

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorControlReliefMarkingsScheme"></see></summary>
    let ElevatorControlReliefMarkingsScheme =
        _prefix "ElevatorControlReliefMarkingsScheme"

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorDriveOff"></see></summary>
    let ElevatorDriveOff = _prefix "ElevatorDriveOff"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorDriveOffsScheme"></see></summary>
    let ElevatorDriveOffsScheme = _prefix "ElevatorDriveOffsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MappableEntityForm"></see>
    /// </summary>
    let MappableEntityForm = _prefix "MappableEntityForm"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MappableEntityMKPOFormsScheme"></see>
    /// </summary>
    let MappableEntityMKPOFormsScheme = _prefix "MappableEntityMKPOFormsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ElevatorShaftDoor"></see>
    /// </summary>
    let ElevatorShaftDoor = _prefix "ElevatorShaftDoor"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EmbassyObjectCategory"></see>
    /// </summary>
    let EmbassyObjectCategory = _prefix "EmbassyObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EmploymentOfficeObjectCategory"></see>
    /// </summary>
    let EmploymentOfficeObjectCategory = _prefix "EmploymentOfficeObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EngravedElevatorControlReliefMarking"></see>
    /// </summary>
    let EngravedElevatorControlReliefMarking =
        _prefix "EngravedElevatorControlReliefMarking"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EntireObjectInteriorAccessibility"></see>
    /// </summary>
    let EntireObjectInteriorAccessibility = _prefix "EntireObjectInteriorAccessibility"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ObjectInteriorAccessibility"></see></summary>
    let ObjectInteriorAccessibility = _prefix "ObjectInteriorAccessibility"

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ObjectInteriorAccessibilitiesScheme"></see></summary>
    let ObjectInteriorAccessibilitiesScheme =
        _prefix "ObjectInteriorAccessibilitiesScheme"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Entrance"></see>
    /// </summary>
    let Entrance = _prefix "Entrance"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/EntranceAccessibilitiesScheme"></see></summary>
    let EntranceAccessibilitiesScheme = _prefix "EntranceAccessibilitiesScheme"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/EntranceAccessibility"></see></summary>
    let EntranceAccessibility = _prefix "EntranceAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EntranceRampSkidsLocalization"></see>
    /// </summary>
    let EntranceRampSkidsLocalization = _prefix "EntranceRampSkidsLocalization"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSkidsLocalization"></see></summary>
    let RampSkidsLocalization = _prefix "RampSkidsLocalization"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSkidsLocalizationsScheme"></see></summary>
    let RampSkidsLocalizationsScheme = _prefix "RampSkidsLocalizationsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EntranceSteps"></see>
    /// </summary>
    let EntranceSteps = _prefix "EntranceSteps"
    /// <summary>
    /// Stairs is understood as connecting different floors
    /// <see href="http://w3id.org/charta77/jup/Steps"></see></summary>
    let Steps = _prefix "Steps"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/EntryAreaEntriesScheme"></see></summary>
    let EntryAreaEntriesScheme = _prefix "EntryAreaEntriesScheme"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/EntryAreaEntry"></see></summary>
    let EntryAreaEntry = _prefix "EntryAreaEntry"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FarmObjectCategory"></see>
    /// </summary>
    let FarmObjectCategory = _prefix "FarmObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FastFoodObjectCategory"></see>
    /// </summary>
    let FastFoodObjectCategory = _prefix "FastFoodObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FixedHandleType"></see>
    /// </summary>
    let FixedHandleType = _prefix "FixedHandleType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleType"></see></summary>
    let HandleType = _prefix "HandleType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleTypesScheme"></see></summary>
    let HandleTypesScheme = _prefix "HandleTypesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FixedRampSkidsMobility"></see>
    /// </summary>
    let FixedRampSkidsMobility = _prefix "FixedRampSkidsMobility"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSkidsMobility"></see></summary>
    let RampSkidsMobility = _prefix "RampSkidsMobility"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSkidsMobilitiesScheme"></see></summary>
    let RampSkidsMobilitiesScheme = _prefix "RampSkidsMobilitiesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FoldingHandleType"></see>
    /// </summary>
    let FoldingHandleType = _prefix "FoldingHandleType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FoldingWCChangingDesk"></see>
    /// </summary>
    let FoldingWCChangingDesk = _prefix "FoldingWCChangingDesk"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCChangingDesk"></see></summary>
    let WCChangingDesk = _prefix "WCChangingDesk"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCChangingDesksScheme"></see></summary>
    let WCChangingDesksScheme = _prefix "WCChangingDesksScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FolkArchitectureObjectCategory"></see>
    /// </summary>
    let FolkArchitectureObjectCategory = _prefix "FolkArchitectureObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Form"></see>
    /// </summary>
    let Form = _prefix "Form"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FortObjectCategory"></see>
    /// </summary>
    let FortObjectCategory = _prefix "FortObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FortressObjectCategory"></see>
    /// </summary>
    let FortressObjectCategory = _prefix "FortressObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FreeWCBasinSpace"></see>
    /// </summary>
    let FreeWCBasinSpace = _prefix "FreeWCBasinSpace"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FreelyAccessibleMappableEntityAccess"></see>
    /// </summary>
    let FreelyAccessibleMappableEntityAccess =
        _prefix "FreelyAccessibleMappableEntityAccess"

    /// <summary>
    /// The list was copied based on forms compliant with Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/MappableEntityAccess"></see></summary>
    let MappableEntityAccess = _prefix "MappableEntityAccess"
    /// <summary>
    /// The list was copied based on forms compliant with Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/MappableEntityAccessesScheme"></see></summary>
    let MappableEntityAccessesScheme = _prefix "MappableEntityAccessesScheme"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FrontElevatorCageSecondDoorLocalization"></see>
    /// </summary>
    let FrontElevatorCageSecondDoorLocalization =
        _prefix "FrontElevatorCageSecondDoorLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FrontEntryAreaEntry"></see>
    /// </summary>
    let FrontEntryAreaEntry = _prefix "FrontEntryAreaEntry"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FrontWallElevatorCageMirrorLocalization"></see>
    /// </summary>
    let FrontWallElevatorCageMirrorLocalization =
        _prefix "FrontWallElevatorCageMirrorLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FrontWallHandleLocalization"></see>
    /// </summary>
    let FrontWallHandleLocalization = _prefix "FrontWallHandleLocalization"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleLocalization"></see></summary>
    let HandleLocalization = _prefix "HandleLocalization"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleLocalizationsScheme"></see></summary>
    let HandleLocalizationsScheme = _prefix "HandleLocalizationsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FunerallHallObjectCategory"></see>
    /// </summary>
    let FunerallHallObjectCategory = _prefix "FunerallHallObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GalleryObjectCategory"></see>
    /// </summary>
    let GalleryObjectCategory = _prefix "GalleryObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GasStationObjectCategory"></see>
    /// </summary>
    let GasStationObjectCategory = _prefix "GasStationObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GentsWCCabinLocalization"></see>
    /// </summary>
    let GentsWCCabinLocalization = _prefix "GentsWCCabinLocalization"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCCabinLocalization"></see></summary>
    let WCCabinLocalization = _prefix "WCCabinLocalization"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCCabinLocalizationsScheme"></see></summary>
    let WCCabinLocalizationsScheme = _prefix "WCCabinLocalizationsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GraphicElevatorControlFlatMarking"></see>
    /// </summary>
    let GraphicElevatorControlFlatMarking = _prefix "GraphicElevatorControlFlatMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GuestHouseObjectCategory"></see>
    /// </summary>
    let GuestHouseObjectCategory = _prefix "GuestHouseObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Hallway"></see>
    /// </summary>
    let Hallway = _prefix "Hallway"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleOrientation"></see></summary>
    let HandleOrientation = _prefix "HandleOrientation"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleOrientationsScheme"></see></summary>
    let HandleOrientationsScheme = _prefix "HandleOrientationsScheme"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandlePosition"></see></summary>
    let HandlePosition = _prefix "HandlePosition"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandlePositionsScheme"></see></summary>
    let HandlePositionsScheme = _prefix "HandlePositionsScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HarborObjectCategory"></see>
    /// </summary>
    let HarborObjectCategory = _prefix "HarborObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HealthCenterObjectCategory"></see>
    /// </summary>
    let HealthCenterObjectCategory = _prefix "HealthCenterObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HealthInsuranceCompanyObjectCategory"></see>
    /// </summary>
    let HealthInsuranceCompanyObjectCategory =
        _prefix "HealthInsuranceCompanyObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HighSchoolObjectCategory"></see>
    /// </summary>
    let HighSchoolObjectCategory = _prefix "HighSchoolObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HorizontalHandleOrientation"></see>
    /// </summary>
    let HorizontalHandleOrientation = _prefix "HorizontalHandleOrientation"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HospitalObjectCategory"></see>
    /// </summary>
    let HospitalObjectCategory = _prefix "HospitalObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HotelObjectCategory"></see>
    /// </summary>
    let HotelObjectCategory = _prefix "HotelObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HypermarketObjectCategory"></see>
    /// </summary>
    let HypermarketObjectCategory = _prefix "HypermarketObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InaccessibleObjectInteriorAccessibility"></see>
    /// </summary>
    let InaccessibleObjectInteriorAccessibility =
        _prefix "InaccessibleObjectInteriorAccessibility"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InaccessibleObjectMKPO"></see>
    /// </summary>
    let InaccessibleObjectMKPO = _prefix "InaccessibleObjectMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InaccessibleWCMKPO"></see>
    /// </summary>
    let InaccessibleWCMKPO = _prefix "InaccessibleWCMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InclinedPlatformType"></see>
    /// </summary>
    let InclinedPlatformType = _prefix "InclinedPlatformType"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/PlatformType"></see></summary>
    let PlatformType = _prefix "PlatformType"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/PlatformTypesScheme"></see></summary>
    let PlatformTypesScheme = _prefix "PlatformTypesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/IndoorSwimmingPoolObjectCategory"></see>
    /// </summary>
    let IndoorSwimmingPoolObjectCategory = _prefix "IndoorSwimmingPoolObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InformationCenterObjectCategory"></see>
    /// </summary>
    let InformationCenterObjectCategory = _prefix "InformationCenterObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InsideHandlePosition"></see>
    /// </summary>
    let InsideHandlePosition = _prefix "InsideHandlePosition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InsufficientWashBasinUnderpass"></see>
    /// </summary>
    let InsufficientWashBasinUnderpass = _prefix "InsufficientWashBasinUnderpass"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WashBasinUnderpass"></see></summary>
    let WashBasinUnderpass = _prefix "WashBasinUnderpass"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WashBasinUnderpassesScheme"></see></summary>
    let WashBasinUnderpassesScheme = _prefix "WashBasinUnderpassesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InsuranceOfficeObjectCategory"></see>
    /// </summary>
    let InsuranceOfficeObjectCategory = _prefix "InsuranceOfficeObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/IntercomBellType"></see>
    /// </summary>
    let IntercomBellType = _prefix "IntercomBellType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InteriorRampSkidsLocalization"></see>
    /// </summary>
    let InteriorRampSkidsLocalization = _prefix "InteriorRampSkidsLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InteriorStairs"></see>
    /// </summary>
    let InteriorStairs = _prefix "InteriorStairs"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InteriorSteps"></see>
    /// </summary>
    let InteriorSteps = _prefix "InteriorSteps"
    /// <summary>
    /// to the interior of the cabine
    /// <see href="http://w3id.org/charta77/jup/InwardsDoorOpeningDirection"></see></summary>
    let InwardsDoorOpeningDirection = _prefix "InwardsDoorOpeningDirection"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/JingleAOBAnnouncement"></see>
    /// </summary>
    let JingleAOBAnnouncement = _prefix "JingleAOBAnnouncement"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/KindergartenObjectCategory"></see>
    /// </summary>
    let KindergartenObjectCategory = _prefix "KindergartenObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LadiesWCCabinLocalization"></see>
    /// </summary>
    let LadiesWCCabinLocalization = _prefix "LadiesWCCabinLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LandingsElevatorDriveOff"></see>
    /// </summary>
    let LandingsElevatorDriveOff = _prefix "LandingsElevatorDriveOff"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LandingsEntryArea"></see>
    /// </summary>
    let LandingsEntryArea = _prefix "LandingsEntryArea"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LeftBottomWCCabinDisposition"></see>
    /// </summary>
    let LeftBottomWCCabinDisposition = _prefix "LeftBottomWCCabinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LeftTopWCCabinDisposition"></see>
    /// </summary>
    let LeftTopWCCabinDisposition = _prefix "LeftTopWCCabinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LevelTap"></see>
    /// </summary>
    let LevelTap = _prefix "LevelTap"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/TapType"></see></summary>
    let TapType = _prefix "TapType"
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/TapTypesScheme"></see></summary>
    let TapTypesScheme = _prefix "TapTypesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LibraryObjectCategory"></see>
    /// </summary>
    let LibraryObjectCategory = _prefix "LibraryObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LobbyDoor"></see>
    /// </summary>
    let LobbyDoor = _prefix "LobbyDoor"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LobbyRampSkidsLocalization"></see>
    /// </summary>
    let LobbyRampSkidsLocalization = _prefix "LobbyRampSkidsLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LobbySteps"></see>
    /// </summary>
    let LobbySteps = _prefix "LobbySteps"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LockedMappableEntityAccess"></see>
    /// </summary>
    let LockedMappableEntityAccess = _prefix "LockedMappableEntityAccess"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LoretoObjectCategory"></see>
    /// </summary>
    let LoretoObjectCategory = _prefix "LoretoObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MainEntrance"></see>
    /// </summary>
    let MainEntrance = _prefix "MainEntrance"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Mapper"></see>
    /// </summary>
    let Mapper = _prefix "Mapper"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MechanicalDoorOpening"></see>
    /// </summary>
    let MechanicalDoorOpening = _prefix "MechanicalDoorOpening"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MechanicalWCFlushing"></see>
    /// </summary>
    let MechanicalWCFlushing = _prefix "MechanicalWCFlushing"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MedicalEmergencyObjectCategory"></see>
    /// </summary>
    let MedicalEmergencyObjectCategory = _prefix "MedicalEmergencyObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MedicalSupplyObjectCategory"></see>
    /// </summary>
    let MedicalSupplyObjectCategory = _prefix "MedicalSupplyObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MetropolitanPoliceObjectCategory"></see>
    /// </summary>
    let MetropolitanPoliceObjectCategory = _prefix "MetropolitanPoliceObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MezzaninesElevatorDriveOff"></see>
    /// </summary>
    let MezzaninesElevatorDriveOff = _prefix "MezzaninesElevatorDriveOff"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingBellType"></see>
    /// </summary>
    let MissingBellType = _prefix "MissingBellType"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingContrastMarkingLocalization"></see>
    /// </summary>
    let MissingContrastMarkingLocalization =
        _prefix "MissingContrastMarkingLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingEntranceGuidingLine"></see>
    /// </summary>
    let MissingEntranceGuidingLine = _prefix "MissingEntranceGuidingLine"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingHandlePosition"></see>
    /// </summary>
    let MissingHandlePosition = _prefix "MissingHandlePosition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingWCSwitch"></see>
    /// </summary>
    let MissingWCSwitch = _prefix "MissingWCSwitch"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MobileRampSkidsMobility"></see>
    /// </summary>
    let MobileRampSkidsMobility = _prefix "MobileRampSkidsMobility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MobileWCChangingDesk"></see>
    /// </summary>
    let MobileWCChangingDesk = _prefix "MobileWCChangingDesk"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MonasteryObjectCategory"></see>
    /// </summary>
    let MonasteryObjectCategory = _prefix "MonasteryObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MonumentObjectCategory"></see>
    /// </summary>
    let MonumentObjectCategory = _prefix "MonumentObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MoreStepsEntranceAccessibility"></see>
    /// </summary>
    let MoreStepsEntranceAccessibility = _prefix "MoreStepsEntranceAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MosqueObjectCategory"></see>
    /// </summary>
    let MosqueObjectCategory = _prefix "MosqueObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MunicipalOfficeObjectCategory"></see>
    /// </summary>
    let MunicipalOfficeObjectCategory = _prefix "MunicipalOfficeObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MunicipalityObjectCategory"></see>
    /// </summary>
    let MunicipalityObjectCategory = _prefix "MunicipalityObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MuseumObjectCategory"></see>
    /// </summary>
    let MuseumObjectCategory = _prefix "MuseumObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NarrowedPassage"></see>
    /// </summary>
    let NarrowedPassage = _prefix "NarrowedPassage"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NaturalEntranceGuidingLine"></see>
    /// </summary>
    let NaturalEntranceGuidingLine = _prefix "NaturalEntranceGuidingLine"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NavigationSystem"></see>
    /// </summary>
    let NavigationSystem = _prefix "NavigationSystem"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NoElevationEntranceAccessibility"></see>
    /// </summary>
    let NoElevationEntranceAccessibility = _prefix "NoElevationEntranceAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NonslipperyRampSurface"></see>
    /// </summary>
    let NonslipperyRampSurface = _prefix "NonslipperyRampSurface"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSurface"></see></summary>
    let RampSurface = _prefix "RampSurface"
    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSurfacesScheme"></see></summary>
    let RampSurfacesScheme = _prefix "RampSurfacesScheme"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NotConnectingObjectStairsType"></see>
    /// </summary>
    let NotConnectingObjectStairsType = _prefix "NotConnectingObjectStairsType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OKWCFlushingDifficulty"></see>
    /// </summary>
    let OKWCFlushingDifficulty = _prefix "OKWCFlushingDifficulty"
    /// <summary>
    /// An object may not be represented by an entire building, it can stand for its particular logic part (e.g. one department store in a multifunctional building). One address can thus comprise multiple objects.
    /// <see href="http://w3id.org/charta77/jup/Object"></see></summary>
    let Object = _prefix "Object"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObservatoryObjectCategory"></see>
    /// </summary>
    let ObservatoryObjectCategory = _prefix "ObservatoryObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OneSideDoorOpeningDirection"></see>
    /// </summary>
    let OneSideDoorOpeningDirection = _prefix "OneSideDoorOpeningDirection"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OneStepEntranceAccessibility"></see>
    /// </summary>
    let OneStepEntranceAccessibility = _prefix "OneStepEntranceAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OpticianShopObjectCategory"></see>
    /// </summary>
    let OpticianShopObjectCategory = _prefix "OpticianShopObjectCategory"
    /// <summary>
    /// e.g. Prague Castle Administration
    /// <see href="http://w3id.org/charta77/jup/Organization"></see></summary>
    let Organization = _prefix "Organization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OtheroObjectCategory"></see>
    /// </summary>
    let OtheroObjectCategory = _prefix "OtheroObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OutsideHandlePosition"></see>
    /// </summary>
    let OutsideHandlePosition = _prefix "OutsideHandlePosition"
    /// <summary>
    /// to the exterior of the cabine
    /// <see href="http://w3id.org/charta77/jup/OutwardsDoorOpeningDirection"></see></summary>
    let OutwardsDoorOpeningDirection = _prefix "OutwardsDoorOpeningDirection"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PalaceObjectCategory"></see>
    /// </summary>
    let PalaceObjectCategory = _prefix "PalaceObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PartObjectInteriorAccessibility"></see>
    /// </summary>
    let PartObjectInteriorAccessibility = _prefix "PartObjectInteriorAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PartlyAccessibleObjectMKPO"></see>
    /// </summary>
    let PartlyAccessibleObjectMKPO = _prefix "PartlyAccessibleObjectMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PartlyAccessibleWCMKPO"></see>
    /// </summary>
    let PartlyAccessibleWCMKPO = _prefix "PartlyAccessibleWCMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PastryObjectCategory"></see>
    /// </summary>
    let PastryObjectCategory = _prefix "PastryObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PersonalElevatorType"></see>
    /// </summary>
    let PersonalElevatorType = _prefix "PersonalElevatorType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PharmacyObjectCategory"></see>
    /// </summary>
    let PharmacyObjectCategory = _prefix "PharmacyObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PhraseAOBAnnouncement"></see>
    /// </summary>
    let PhraseAOBAnnouncement = _prefix "PhraseAOBAnnouncement"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Platform"></see>
    /// </summary>
    let Platform = _prefix "Platform"
    /// <summary>
    /// Appendix 2
    /// <see href="http://w3id.org/charta77/jup/PlatformEntranceAccessibility"></see></summary>
    let PlatformEntranceAccessibility = _prefix "PlatformEntranceAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PoliceObjectCategory"></see>
    /// </summary>
    let PoliceObjectCategory = _prefix "PoliceObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PostOfficeObjectCategory"></see>
    /// </summary>
    let PostOfficeObjectCategory = _prefix "PostOfficeObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ProtrudingElevatorControlReliefMarking"></see>
    /// </summary>
    let ProtrudingElevatorControlReliefMarking =
        _prefix "ProtrudingElevatorControlReliefMarking"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PubObjectCategory"></see>
    /// </summary>
    let PubObjectCategory = _prefix "PubObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PublicProsecutorObjectCategory"></see>
    /// </summary>
    let PublicProsecutorObjectCategory = _prefix "PublicProsecutorObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PublicToiletObjectCategory"></see>
    /// </summary>
    let PublicToiletObjectCategory = _prefix "PublicToiletObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Ramp"></see>
    /// </summary>
    let Ramp = _prefix "Ramp"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RampSkids"></see>
    /// </summary>
    let RampSkids = _prefix "RampSkids"
    /// <summary>
    /// Appendix 3
    /// <see href="http://w3id.org/charta77/jup/RampEntranceAccessibility"></see></summary>
    let RampEntranceAccessibility = _prefix "RampEntranceAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RampHandle"></see>
    /// </summary>
    let RampHandle = _prefix "RampHandle"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RampLeg"></see>
    /// </summary>
    let RampLeg = _prefix "RampLeg"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RecreationalFacilityObjectCategory"></see>
    /// </summary>
    let RecreationalFacilityObjectCategory =
        _prefix "RecreationalFacilityObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ResidentialSocialServiceObjectCategory"></see>
    /// </summary>
    let ResidentialSocialServiceObjectCategory =
        _prefix "ResidentialSocialServiceObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RestaurantObjectCategory"></see>
    /// </summary>
    let RestaurantObjectCategory = _prefix "RestaurantObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RightBottomWCCabinDisposition"></see>
    /// </summary>
    let RightBottomWCCabinDisposition = _prefix "RightBottomWCCabinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RightTopWCCabinDisposition"></see>
    /// </summary>
    let RightTopWCCabinDisposition = _prefix "RightTopWCCabinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RingOnlyBellType"></see>
    /// </summary>
    let RingOnlyBellType = _prefix "RingOnlyBellType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SchoolObjectCategory"></see>
    /// </summary>
    let SchoolObjectCategory = _prefix "SchoolObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SelfContainedWCCabinLocalization"></see>
    /// </summary>
    let SelfContainedWCCabinLocalization = _prefix "SelfContainedWCCabinLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ServiceObjectCategory"></see>
    /// </summary>
    let ServiceObjectCategory = _prefix "ServiceObjectCategory"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideElevatorCageSecondDoorLocalization"></see>
    /// </summary>
    let SideElevatorCageSecondDoorLocalization =
        _prefix "SideElevatorCageSecondDoorLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideEntrance"></see>
    /// </summary>
    let SideEntrance = _prefix "SideEntrance"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideEntryAreaEntry"></see>
    /// </summary>
    let SideEntryAreaEntry = _prefix "SideEntryAreaEntry"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideWallElevatorCageMirrorLocalization"></see>
    /// </summary>
    let SideWallElevatorCageMirrorLocalization =
        _prefix "SideWallElevatorCageMirrorLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideWallHandleLocalization"></see>
    /// </summary>
    let SideWallHandleLocalization = _prefix "SideWallHandleLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideWallsElevatorCageMirrorLocalization"></see>
    /// </summary>
    let SideWallsElevatorCageMirrorLocalization =
        _prefix "SideWallsElevatorCageMirrorLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideWallsHandleLocalization"></see>
    /// </summary>
    let SideWallsHandleLocalization = _prefix "SideWallsHandleLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SidesDoorOpeningDirection"></see>
    /// </summary>
    let SidesDoorOpeningDirection = _prefix "SidesDoorOpeningDirection"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SinglePanelledDoorType"></see>
    /// </summary>
    let SinglePanelledDoorType = _prefix "SinglePanelledDoorType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Skids"></see>
    /// </summary>
    let Skids = _prefix "Skids"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SlidingDoorOpening"></see>
    /// </summary>
    let SlidingDoorOpening = _prefix "SlidingDoorOpening"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SlipperyRampSurface"></see>
    /// </summary>
    let SlipperyRampSurface = _prefix "SlipperyRampSurface"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SocialOfficeObjectCategory"></see>
    /// </summary>
    let SocialOfficeObjectCategory = _prefix "SocialOfficeObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SpaHouseObjectCategory"></see>
    /// </summary>
    let SpaHouseObjectCategory = _prefix "SpaHouseObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SpiralObjectStairsType"></see>
    /// </summary>
    let SpiralObjectStairsType = _prefix "SpiralObjectStairsType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SpiralRampType"></see>
    /// </summary>
    let SpiralRampType = _prefix "SpiralRampType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SportsFacilityObjectCategory"></see>
    /// </summary>
    let SportsFacilityObjectCategory = _prefix "SportsFacilityObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/StadiumObjectCategory"></see>
    /// </summary>
    let StadiumObjectCategory = _prefix "StadiumObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/StatelyHomeObjectCategory"></see>
    /// </summary>
    let StatelyHomeObjectCategory = _prefix "StatelyHomeObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/StoreObjectCategory"></see>
    /// </summary>
    let StoreObjectCategory = _prefix "StoreObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SubwayStationObjectCategory"></see>
    /// </summary>
    let SubwayStationObjectCategory = _prefix "SubwayStationObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SufficientWashBasinUnderpass"></see>
    /// </summary>
    let SufficientWashBasinUnderpass = _prefix "SufficientWashBasinUnderpass"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SupermarketObjectCategory"></see>
    /// </summary>
    let SupermarketObjectCategory = _prefix "SupermarketObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SwimmingObjectCategory"></see>
    /// </summary>
    let SwimmingObjectCategory = _prefix "SwimmingObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SwingingDoorOpening"></see>
    /// </summary>
    let SwingingDoorOpening = _prefix "SwingingDoorOpening"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SynagogueObjectCategory"></see>
    /// </summary>
    let SynagogueObjectCategory = _prefix "SynagogueObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Tap"></see>
    /// </summary>
    let Tap = _prefix "Tap"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TaxOfficeObjectCategory"></see>
    /// </summary>
    let TaxOfficeObjectCategory = _prefix "TaxOfficeObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TempleObjectCategory"></see>
    /// </summary>
    let TempleObjectCategory = _prefix "TempleObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TheatreObjectCategory"></see>
    /// </summary>
    let TheatreObjectCategory = _prefix "TheatreObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TopContrastMarkingLocalization"></see>
    /// </summary>
    let TopContrastMarkingLocalization = _prefix "TopContrastMarkingLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TopEntryArea"></see>
    /// </summary>
    let TopEntryArea = _prefix "TopEntryArea"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TopLeftWCCabinDisposition"></see>
    /// </summary>
    let TopLeftWCCabinDisposition = _prefix "TopLeftWCCabinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TopRightWCCabinDisposition"></see>
    /// </summary>
    let TopRightWCCabinDisposition = _prefix "TopRightWCCabinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TouchFreeTap"></see>
    /// </summary>
    let TouchFreeTap = _prefix "TouchFreeTap"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TouristGuide"></see>
    /// </summary>
    let TouristGuide = _prefix "TouristGuide"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Tourniquet"></see>
    /// </summary>
    let Tourniquet = _prefix "Tourniquet"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TowerObjectCategory"></see>
    /// </summary>
    let TowerObjectCategory = _prefix "TowerObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TownhallObjectCategory"></see>
    /// </summary>
    let TownhallObjectCategory = _prefix "TownhallObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TrainStationObjectCategory"></see>
    /// </summary>
    let TrainStationObjectCategory = _prefix "TrainStationObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ValveTap"></see>
    /// </summary>
    let ValveTap = _prefix "ValveTap"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/VerticalHandleOrientation"></see>
    /// </summary>
    let VerticalHandleOrientation = _prefix "VerticalHandleOrientation"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/VerticalPlatformType"></see>
    /// </summary>
    let VerticalPlatformType = _prefix "VerticalPlatformType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/VeterinarySurgeryObjectCategory"></see>
    /// </summary>
    let VeterinarySurgeryObjectCategory = _prefix "VeterinarySurgeryObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ViticultureObjectCategory"></see>
    /// </summary>
    let ViticultureObjectCategory = _prefix "ViticultureObjectCategory"
    /// <summary>
    /// Placement of equipment objects is viewed from the entrance into the room
    /// <see href="http://w3id.org/charta77/jup/WC"></see></summary>
    let WC = _prefix "WC"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCBasinLeftHandle"></see>
    /// </summary>
    let WCBasinLeftHandle = _prefix "WCBasinLeftHandle"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCBasinRightHandle"></see>
    /// </summary>
    let WCBasinRightHandle = _prefix "WCBasinRightHandle"
    /// <summary>
    /// In case that the WC is accessible through hallways
    /// <see href="http://w3id.org/charta77/jup/WCHallway"></see></summary>
    let WCHallway = _prefix "WCHallway"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WashBasin"></see>
    /// </summary>
    let WashBasin = _prefix "WashBasin"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WashBasinHandle"></see>
    /// </summary>
    let WashBasinHandle = _prefix "WashBasinHandle"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WashBasinTap"></see>
    /// </summary>
    let WashBasinTap = _prefix "WashBasinTap"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WaterParkObjectCategory"></see>
    /// </summary>
    let WaterParkObjectCategory = _prefix "WaterParkObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WeddingHallObjectCategory"></see>
    /// </summary>
    let WeddingHallObjectCategory = _prefix "WeddingHallObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WellnessObjectCategory"></see>
    /// </summary>
    let WellnessObjectCategory = _prefix "WellnessObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WinterStadiumObjectCategory"></see>
    /// </summary>
    let WinterStadiumObjectCategory = _prefix "WinterStadiumObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/YesWCSwitch"></see>
    /// </summary>
    let YesWCSwitch = _prefix "YesWCSwitch"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ZooObjectCategory"></see>
    /// </summary>
    let ZooObjectCategory = _prefix "ZooObjectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/access"></see>
    /// </summary>
    let access = _prefix "access"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/accessProvidedBy"></see>
    /// </summary>
    let accessProvidedBy = _prefix "accessProvidedBy"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/accessibility"></see>
    /// </summary>
    let accessibility = _prefix "accessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/aobAboveDoor"></see>
    /// </summary>
    let aobAboveDoor = _prefix "aobAboveDoor"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/aobAnnouncement"></see>
    /// </summary>
    let aobAnnouncement = _prefix "aobAnnouncement"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/aobIsAboveDoor"></see>
    /// </summary>
    let aobIsAboveDoor = _prefix "aobIsAboveDoor"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/aobLocalization"></see>
    /// </summary>
    let aobLocalization = _prefix "aobLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/localization"></see>
    /// </summary>
    let localization = _prefix "localization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/bellHeight"></see>
    /// </summary>
    let bellHeight = _prefix "bellHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/bellIndentation"></see>
    /// </summary>
    let bellIndentation = _prefix "bellIndentation"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/bellType"></see>
    /// </summary>
    let bellType = _prefix "bellType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/belongsTo"></see>
    /// </summary>
    let belongsTo = _prefix "belongsTo"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/brailleLabelled"></see>
    /// </summary>
    let brailleLabelled = _prefix "brailleLabelled"
    /// <summary>
    /// A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.
    /// <see href="http://w3id.org/charta77/jup/certifiedRecord"></see></summary>
    let certifiedRecord = _prefix "certifiedRecord"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/contrastMarked"></see>
    /// </summary>
    let contrastMarked = _prefix "contrastMarked"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/contrastMarkingGlassSurfacesMarked"></see>
    /// </summary>
    let contrastMarkingGlassSurfacesMarked =
        _prefix "contrastMarkingGlassSurfacesMarked"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/contrastMarkingIsGlassSurfacesMarked"></see>
    /// </summary>
    let contrastMarkingIsGlassSurfacesMarked =
        _prefix "contrastMarkingIsGlassSurfacesMarked"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/contrastMarkingLocalization"></see>
    /// </summary>
    let contrastMarkingLocalization = _prefix "contrastMarkingLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/controlHeight"></see>
    /// </summary>
    let controlHeight = _prefix "controlHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/createdBy"></see>
    /// </summary>
    let createdBy = _prefix "createdBy"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/createdDate"></see>
    /// </summary>
    let createdDate = _prefix "createdDate"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorBrailleLabelled"></see>
    /// </summary>
    let doorBrailleLabelled = _prefix "doorBrailleLabelled"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorIsBrailleLabelled"></see>
    /// </summary>
    let doorIsBrailleLabelled = _prefix "doorIsBrailleLabelled"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorIsMarked"></see>
    /// </summary>
    let doorIsMarked = _prefix "doorIsMarked"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorMainPanelWidth"></see>
    /// </summary>
    let doorMainPanelWidth = _prefix "doorMainPanelWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorMarked"></see>
    /// </summary>
    let doorMarked = _prefix "doorMarked"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorOpening"></see>
    /// </summary>
    let doorOpening = _prefix "doorOpening"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorOpeningDirection"></see>
    /// </summary>
    let doorOpeningDirection = _prefix "doorOpeningDirection"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorSidePanelWidth"></see>
    /// </summary>
    let doorSidePanelWidth = _prefix "doorSidePanelWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorStepHeight"></see>
    /// </summary>
    let doorStepHeight = _prefix "doorStepHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/thresholdHeight"></see>
    /// </summary>
    let thresholdHeight = _prefix "thresholdHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorType"></see>
    /// </summary>
    let doorType = _prefix "doorType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorWidth"></see>
    /// </summary>
    let doorWidth = _prefix "doorWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorAccess"></see>
    /// </summary>
    let elevatorAccess = _prefix "elevatorAccess"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorAccessProvidedBy"></see>
    /// </summary>
    let elevatorAccessProvidedBy = _prefix "elevatorAccessProvidedBy"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlAnnouncementAcoustic"></see>
    /// </summary>
    let elevatorCageControlAnnouncementAcoustic =
        _prefix "elevatorCageControlAnnouncementAcoustic"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlAnnouncementPhonetic"></see>
    /// </summary>
    let elevatorCageControlAnnouncementPhonetic =
        _prefix "elevatorCageControlAnnouncementPhonetic"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlBrailleLabelled"></see>
    /// </summary>
    let elevatorCageControlBrailleLabelled =
        _prefix "elevatorCageControlBrailleLabelled"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlDistance"></see>
    /// </summary>
    let elevatorCageControlDistance = _prefix "elevatorCageControlDistance"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlFlatMarking"></see>
    /// </summary>
    let elevatorCageControlFlatMarking = _prefix "elevatorCageControlFlatMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlHeight"></see>
    /// </summary>
    let elevatorCageControlHeight = _prefix "elevatorCageControlHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlReliefMarking"></see>
    /// </summary>
    let elevatorCageControlReliefMarking = _prefix "elevatorCageControlReliefMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageDepth"></see>
    /// </summary>
    let elevatorCageDepth = _prefix "elevatorCageDepth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageMirrorHeight"></see>
    /// </summary>
    let elevatorCageMirrorHeight = _prefix "elevatorCageMirrorHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mirrorHeight"></see>
    /// </summary>
    let mirrorHeight = _prefix "mirrorHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageMirrorInstalled"></see>
    /// </summary>
    let elevatorCageMirrorInstalled = _prefix "elevatorCageMirrorInstalled"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageMirrorLocalization"></see>
    /// </summary>
    let elevatorCageMirrorLocalization = _prefix "elevatorCageMirrorLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCagePassthrough"></see>
    /// </summary>
    let elevatorCagePassthrough = _prefix "elevatorCagePassthrough"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageSeatFunctional"></see>
    /// </summary>
    let elevatorCageSeatFunctional = _prefix "elevatorCageSeatFunctional"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageSeatInstalled"></see>
    /// </summary>
    let elevatorCageSeatInstalled = _prefix "elevatorCageSeatInstalled"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageSeatWithinReach"></see>
    /// </summary>
    let elevatorCageSeatWithinReach = _prefix "elevatorCageSeatWithinReach"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageSecondDoorLocalization"></see>
    /// </summary>
    let elevatorCageSecondDoorLocalization =
        _prefix "elevatorCageSecondDoorLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageWidth"></see>
    /// </summary>
    let elevatorCageWidth = _prefix "elevatorCageWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorConnectsFloors"></see>
    /// </summary>
    let elevatorConnectsFloors = _prefix "elevatorConnectsFloors"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorControlBrailleLabelled"></see>
    /// </summary>
    let elevatorControlBrailleLabelled = _prefix "elevatorControlBrailleLabelled"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorControlFlatMarking"></see>
    /// </summary>
    let elevatorControlFlatMarking = _prefix "elevatorControlFlatMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorControlMaxHeight"></see>
    /// </summary>
    let elevatorControlMaxHeight = _prefix "elevatorControlMaxHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorControlReliefMarking"></see>
    /// </summary>
    let elevatorControlReliefMarking = _prefix "elevatorControlReliefMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorDriveOff"></see>
    /// </summary>
    let elevatorDriveOff = _prefix "elevatorDriveOff"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageControlAnnouncementAcoustic"></see>
    /// </summary>
    let elevatorIsCageControlAnnouncementAcoustic =
        _prefix "elevatorIsCageControlAnnouncementAcoustic"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageControlAnnouncementPhonetic"></see>
    /// </summary>
    let elevatorIsCageControlAnnouncementPhonetic =
        _prefix "elevatorIsCageControlAnnouncementPhonetic"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageControlBrailleMarking"></see>
    /// </summary>
    let elevatorIsCageControlBrailleMarking =
        _prefix "elevatorIsCageControlBrailleMarking"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageMirror"></see>
    /// </summary>
    let elevatorIsCageMirror = _prefix "elevatorIsCageMirror"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCagePassthrough"></see>
    /// </summary>
    let elevatorIsCagePassthrough = _prefix "elevatorIsCagePassthrough"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageSeat"></see>
    /// </summary>
    let elevatorIsCageSeat = _prefix "elevatorIsCageSeat"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageSeatFunctional"></see>
    /// </summary>
    let elevatorIsCageSeatFunctional = _prefix "elevatorIsCageSeatFunctional"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageSeatWithinReach"></see>
    /// </summary>
    let elevatorIsCageSeatWithinReach = _prefix "elevatorIsCageSeatWithinReach"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsControlBrailleMarking"></see>
    /// </summary>
    let elevatorIsControlBrailleMarking = _prefix "elevatorIsControlBrailleMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorLocalization"></see>
    /// </summary>
    let elevatorLocalization = _prefix "elevatorLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorType"></see>
    /// </summary>
    let elevatorType = _prefix "elevatorType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAccess"></see>
    /// </summary>
    let entranceAccess = _prefix "entranceAccess"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAccessProvidedBy"></see>
    /// </summary>
    let entranceAccessProvidedBy = _prefix "entranceAccessProvidedBy"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAccessibility"></see>
    /// </summary>
    let entranceAccessibility = _prefix "entranceAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAreaBeforeDoorDepth"></see>
    /// </summary>
    let entranceAreaBeforeDoorDepth = _prefix "entranceAreaBeforeDoorDepth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAreaBeforeDoorWidth"></see>
    /// </summary>
    let entranceAreaBeforeDoorWidth = _prefix "entranceAreaBeforeDoorWidth"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceDifficultSurfaceDescription"></see>
    /// </summary>
    let entranceDifficultSurfaceDescription =
        _prefix "entranceDifficultSurfaceDescription"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceGuidingLine"></see>
    /// </summary>
    let entranceGuidingLine = _prefix "entranceGuidingLine"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsDifficultSurface"></see>
    /// </summary>
    let entranceIsDifficultSurface = _prefix "entranceIsDifficultSurface"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsLongitudinalInclination"></see>
    /// </summary>
    let entranceIsLongitudinalInclination = _prefix "entranceIsLongitudinalInclination"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsReservedParking"></see>
    /// </summary>
    let entranceIsReservedParking = _prefix "entranceIsReservedParking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsSideEntranceInformation"></see>
    /// </summary>
    let entranceIsSideEntranceInformation = _prefix "entranceIsSideEntranceInformation"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsSideEntranceMarked"></see>
    /// </summary>
    let entranceIsSideEntranceMarked = _prefix "entranceIsSideEntranceMarked"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsStepContrastMarked"></see>
    /// </summary>
    let entranceIsStepContrastMarked = _prefix "entranceIsStepContrastMarked"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsTransverseInclination"></see>
    /// </summary>
    let entranceIsTransverseInclination = _prefix "entranceIsTransverseInclination"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLobbyDepth"></see>
    /// </summary>
    let entranceLobbyDepth = _prefix "entranceLobbyDepth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLobbyWidth"></see>
    /// </summary>
    let entranceLobbyWidth = _prefix "entranceLobbyWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLocalization"></see>
    /// </summary>
    let entranceLocalization = _prefix "entranceLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLongitudinalInclination"></see>
    /// </summary>
    let entranceLongitudinalInclination = _prefix "entranceLongitudinalInclination"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLongitudinalInclinationLocalization"></see>
    /// </summary>
    let entranceLongitudinalInclinationLocalization =
        _prefix "entranceLongitudinalInclinationLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceNumberOfReservedParking"></see>
    /// </summary>
    let entranceNumberOfReservedParking = _prefix "entranceNumberOfReservedParking"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceReservedParkingAccessDescription"></see>
    /// </summary>
    let entranceReservedParkingAccessDescription =
        _prefix "entranceReservedParkingAccessDescription"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceReservedParkingLocalization"></see>
    /// </summary>
    let entranceReservedParkingLocalization =
        _prefix "entranceReservedParkingLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceSideEntranceDescribed"></see>
    /// </summary>
    let entranceSideEntranceDescribed = _prefix "entranceSideEntranceDescribed"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceTransverseInclination"></see>
    /// </summary>
    let entranceTransverseInclination = _prefix "entranceTransverseInclination"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceTransverseInclinationLocalization"></see>
    /// </summary>
    let entranceTransverseInclinationLocalization =
        _prefix "entranceTransverseInclinationLocalization"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaDepth"></see>
    /// </summary>
    let entryAreaDepth = _prefix "entryAreaDepth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaEntry"></see>
    /// </summary>
    let entryAreaEntry = _prefix "entryAreaEntry"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaEntryClosing"></see>
    /// </summary>
    let entryAreaEntryClosing = _prefix "entryAreaEntryClosing"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaEntryWidth"></see>
    /// </summary>
    let entryAreaEntryWidth = _prefix "entryAreaEntryWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaHeightElevation"></see>
    /// </summary>
    let entryAreaHeightElevation = _prefix "entryAreaHeightElevation"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaIsEntryClosing"></see>
    /// </summary>
    let entryAreaIsEntryClosing = _prefix "entryAreaIsEntryClosing"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaWidth"></see>
    /// </summary>
    let entryAreaWidth = _prefix "entryAreaWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/formMaps"></see>
    /// </summary>
    let formMaps = _prefix "formMaps"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/formType"></see>
    /// </summary>
    let formType = _prefix "formType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hallwayDepth"></see>
    /// </summary>
    let hallwayDepth = _prefix "hallwayDepth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hallwayWidth"></see>
    /// </summary>
    let hallwayWidth = _prefix "hallwayWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleHeight"></see>
    /// </summary>
    let handleHeight = _prefix "handleHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleLength"></see>
    /// </summary>
    let handleLength = _prefix "handleLength"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleLocalization"></see>
    /// </summary>
    let handleLocalization = _prefix "handleLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleOrientation"></see>
    /// </summary>
    let handleOrientation = _prefix "handleOrientation"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handlePosition"></see>
    /// </summary>
    let handlePosition = _prefix "handlePosition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleType"></see>
    /// </summary>
    let handleType = _prefix "handleType"
    /// <summary>
    /// To complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/hasAttachment"></see></summary>
    let hasAttachment = _prefix "hasAttachment"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasDescription"></see>
    /// </summary>
    let hasDescription = _prefix "hasDescription"
    /// <summary>
    /// e.g. for IC organizations
    /// <see href="http://w3id.org/charta77/jup/hasIdentifier"></see></summary>
    let hasIdentifier = _prefix "hasIdentifier"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasLatitude"></see>
    /// </summary>
    let hasLatitude = _prefix "hasLatitude"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasLongitude"></see>
    /// </summary>
    let hasLongitude = _prefix "hasLongitude"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasName"></see>
    /// </summary>
    let hasName = _prefix "hasName"
    /// <summary>
    /// Adapted WC: poor anchorage of handles, handle attached to side wall,...
    /// <see href="http://w3id.org/charta77/jup/hasNotes"></see></summary>
    let hasNotes = _prefix "hasNotes"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasPart"></see>
    /// </summary>
    let hasPart = _prefix "hasPart"
    /// <summary>
    /// http://ruian.linked.opendata.cz/
    /// <see href="http://w3id.org/charta77/jup/hasPlace"></see></summary>
    let hasPlace = _prefix "hasPlace"
    /// <summary>
    /// Short and formated description summarizing form data, understandable to the wide public
    /// <see href="http://w3id.org/charta77/jup/hasSummary"></see></summary>
    let hasSummary = _prefix "hasSummary"
    /// <summary>
    /// A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.
    /// <see href="http://w3id.org/charta77/jup/isCertifiedRecord"></see></summary>
    let isCertifiedRecord = _prefix "isCertifiedRecord"
    /// <summary>
    /// Older entries describing the same mappable entity are assigned the false value.
    /// <see href="http://w3id.org/charta77/jup/isUpToDateRecord"></see></summary>
    let isUpToDateRecord = _prefix "isUpToDateRecord"
    /// <summary>
    /// To complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/license"></see></summary>
    let license = _prefix "license"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityAccess"></see>
    /// </summary>
    let mappableEntityAccess = _prefix "mappableEntityAccess"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityAccessProvidedBy"></see>
    /// </summary>
    let mappableEntityAccessProvidedBy = _prefix "mappableEntityAccessProvidedBy"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityAccessibility"></see>
    /// </summary>
    let mappableEntityAccessibility = _prefix "mappableEntityAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityControlHeight"></see>
    /// </summary>
    let mappableEntityControlHeight = _prefix "mappableEntityControlHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityIsBrailleMarking"></see>
    /// </summary>
    let mappableEntityIsBrailleMarking = _prefix "mappableEntityIsBrailleMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityIsContrastMarking"></see>
    /// </summary>
    let mappableEntityIsContrastMarking = _prefix "mappableEntityIsContrastMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityLocalization"></see>
    /// </summary>
    let mappableEntityLocalization = _prefix "mappableEntityLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityMirrorHeight"></see>
    /// </summary>
    let mappableEntityMirrorHeight = _prefix "mappableEntityMirrorHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityPassageWidth"></see>
    /// </summary>
    let mappableEntityPassageWidth = _prefix "mappableEntityPassageWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntitySeatHeight"></see>
    /// </summary>
    let mappableEntitySeatHeight = _prefix "mappableEntitySeatHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntitySwitchHeight"></see>
    /// </summary>
    let mappableEntitySwitchHeight = _prefix "mappableEntitySwitchHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityThresholdHeight"></see>
    /// </summary>
    let mappableEntityThresholdHeight = _prefix "mappableEntityThresholdHeight"
    /// <summary>
    /// A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.
    /// <see href="http://w3id.org/charta77/jup/mapperCertified"></see></summary>
    let mapperCertified = _prefix "mapperCertified"
    /// <summary>
    /// A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.
    /// <see href="http://w3id.org/charta77/jup/mapperIsCertified"></see></summary>
    let mapperIsCertified = _prefix "mapperIsCertified"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mapperNick"></see>
    /// </summary>
    let mapperNick = _prefix "mapperNick"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/narrowedPassageWidth"></see>
    /// </summary>
    let narrowedPassageWidth = _prefix "narrowedPassageWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/passageWidth"></see>
    /// </summary>
    let passageWidth = _prefix "passageWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/navigationSystemDescription"></see>
    /// </summary>
    let navigationSystemDescription = _prefix "navigationSystemDescription"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectAccessibilityMKPO"></see>
    /// </summary>
    let objectAccessibilityMKPO = _prefix "objectAccessibilityMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectCategory"></see>
    /// </summary>
    let objectCategory = _prefix "objectCategory"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectInteriorAccessibility"></see>
    /// </summary>
    let objectInteriorAccessibility = _prefix "objectInteriorAccessibility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectIsNarrowedPassage"></see>
    /// </summary>
    let objectIsNarrowedPassage = _prefix "objectIsNarrowedPassage"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectIsNavigationSystem"></see>
    /// </summary>
    let objectIsNavigationSystem = _prefix "objectIsNavigationSystem"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectIsStairs"></see>
    /// </summary>
    let objectIsStairs = _prefix "objectIsStairs"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectIsTourniquet"></see>
    /// </summary>
    let objectIsTourniquet = _prefix "objectIsTourniquet"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectNarrowedPassageLocalization"></see>
    /// </summary>
    let objectNarrowedPassageLocalization = _prefix "objectNarrowedPassageLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectNarrowedPassageWidth"></see>
    /// </summary>
    let objectNarrowedPassageWidth = _prefix "objectNarrowedPassageWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectNavigationSystemDescription"></see>
    /// </summary>
    let objectNavigationSystemDescription = _prefix "objectNavigationSystemDescription"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectStairsIsBannister"></see>
    /// </summary>
    let objectStairsIsBannister = _prefix "objectStairsIsBannister"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectStairsType"></see>
    /// </summary>
    let objectStairsType = _prefix "objectStairsType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectStairsType"></see>
    /// </summary>
    let ObjectStairsType = _prefix "ObjectStairsType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectStairsWidth"></see>
    /// </summary>
    let objectStairsWidth = _prefix "objectStairsWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectTourniquetLocalization"></see>
    /// </summary>
    let objectTourniquetLocalization = _prefix "objectTourniquetLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/partOf"></see>
    /// </summary>
    let partOf = _prefix "partOf"
    /// <summary>
    /// Access enabled by attendants if the platform is locked
    /// <see href="http://w3id.org/charta77/jup/platformAccess"></see></summary>
    let platformAccess = _prefix "platformAccess"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformDepth"></see>
    /// </summary>
    let platformDepth = _prefix "platformDepth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformInsideControlHeight"></see>
    /// </summary>
    let platformInsideControlHeight = _prefix "platformInsideControlHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformIsMinParameters"></see>
    /// </summary>
    let platformIsMinParameters = _prefix "platformIsMinParameters"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformLocalization"></see>
    /// </summary>
    let platformLocalization = _prefix "platformLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformMaxLoad"></see>
    /// </summary>
    let platformMaxLoad = _prefix "platformMaxLoad"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformMinParameters"></see>
    /// </summary>
    let platformMinParameters = _prefix "platformMinParameters"
    /// <summary>
    /// Elevation difference surmounted by platform
    /// <see href="http://w3id.org/charta77/jup/platformNumberOfFloors"></see></summary>
    let platformNumberOfFloors = _prefix "platformNumberOfFloors"
    /// <summary>
    /// Elevation difference surmounted by platform
    /// <see href="http://w3id.org/charta77/jup/platformNumberOfSteps"></see></summary>
    let platformNumberOfSteps = _prefix "platformNumberOfSteps"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformOutsideBottomControlHeight"></see>
    /// </summary>
    let platformOutsideBottomControlHeight =
        _prefix "platformOutsideBottomControlHeight"

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformOutsideTopControlHeight"></see>
    /// </summary>
    let platformOutsideTopControlHeight = _prefix "platformOutsideTopControlHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformType"></see>
    /// </summary>
    let platformType = _prefix "platformType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformWidth"></see>
    /// </summary>
    let platformWidth = _prefix "platformWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampAccessProvidedBy"></see>
    /// </summary>
    let rampAccessProvidedBy = _prefix "rampAccessProvidedBy"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampLegInclination"></see>
    /// </summary>
    let rampLegInclination = _prefix "rampLegInclination"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampLegLength"></see>
    /// </summary>
    let rampLegLength = _prefix "rampLegLength"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampLegWidth"></see>
    /// </summary>
    let rampLegWidth = _prefix "rampLegWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampNumberOfLegs"></see>
    /// </summary>
    let rampNumberOfLegs = _prefix "rampNumberOfLegs"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampSkidsInteriorLocalization"></see>
    /// </summary>
    let rampSkidsInteriorLocalization = _prefix "rampSkidsInteriorLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampSkidsLocalization"></see>
    /// </summary>
    let rampSkidsLocalization = _prefix "rampSkidsLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampSkidsMobility"></see>
    /// </summary>
    let rampSkidsMobility = _prefix "rampSkidsMobility"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampSurface"></see>
    /// </summary>
    let rampSurface = _prefix "rampSurface"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampType"></see>
    /// </summary>
    let rampType = _prefix "rampType"
    /// <summary>
    /// To complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/sameAs"></see></summary>
    let sameAs = _prefix "sameAs"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/seatHeight"></see>
    /// </summary>
    let seatHeight = _prefix "seatHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/skidsInclination"></see>
    /// </summary>
    let skidsInclination = _prefix "skidsInclination"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/skidsLength"></see>
    /// </summary>
    let skidsLength = _prefix "skidsLength"
    /// <summary>
    /// To complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/source"></see></summary>
    let source = _prefix "source"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsContrastMarked"></see>
    /// </summary>
    let stepsContrastMarked = _prefix "stepsContrastMarked"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsDepth"></see>
    /// </summary>
    let stepsDepth = _prefix "stepsDepth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsHeight"></see>
    /// </summary>
    let stepsHeight = _prefix "stepsHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsIsContrastMarked"></see>
    /// </summary>
    let stepsIsContrastMarked = _prefix "stepsIsContrastMarked"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsLocalization"></see>
    /// </summary>
    let stepsLocalization = _prefix "stepsLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsNumberOf"></see>
    /// </summary>
    let stepsNumberOf = _prefix "stepsNumberOf"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsType"></see>
    /// </summary>
    let stepsType = _prefix "stepsType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsWidth"></see>
    /// </summary>
    let stepsWidth = _prefix "stepsWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/switchHeight"></see>
    /// </summary>
    let switchHeight = _prefix "switchHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/tapHeight"></see>
    /// </summary>
    let tapHeight = _prefix "tapHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/tapType"></see>
    /// </summary>
    let tapType = _prefix "tapType"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/tourniquetLocalization"></see>
    /// </summary>
    let tourniquetLocalization = _prefix "tourniquetLocalization"
    /// <summary>
    /// Older entries describing the same mappable entity are assigned the false value.
    /// <see href="http://w3id.org/charta77/jup/upToDateRecord"></see></summary>
    let upToDateRecord = _prefix "upToDateRecord"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/washBasinHeight"></see>
    /// </summary>
    let washBasinHeight = _prefix "washBasinHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/washBasinUnderpass"></see>
    /// </summary>
    let washBasinUnderpass = _prefix "washBasinUnderpass"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcAccessibilityMKPO"></see>
    /// </summary>
    let wcAccessibilityMKPO = _prefix "wcAccessibilityMKPO"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcAlarmButtonBottomHeight"></see>
    /// </summary>
    let wcAlarmButtonBottomHeight = _prefix "wcAlarmButtonBottomHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcAlarmButtonInstalled"></see>
    /// </summary>
    let wcAlarmButtonInstalled = _prefix "wcAlarmButtonInstalled"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcAlarmButtonTopHeight"></see>
    /// </summary>
    let wcAlarmButtonTopHeight = _prefix "wcAlarmButtonTopHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinBackIndentation"></see>
    /// </summary>
    let wcBasinBackIndentation = _prefix "wcBasinBackIndentation"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinIsPaperReach"></see>
    /// </summary>
    let wcBasinIsPaperReach = _prefix "wcBasinIsPaperReach"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinLeftDistance"></see>
    /// </summary>
    let wcBasinLeftDistance = _prefix "wcBasinLeftDistance"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinPaperWithinReach"></see>
    /// </summary>
    let wcBasinPaperWithinReach = _prefix "wcBasinPaperWithinReach"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinRightDistance"></see>
    /// </summary>
    let wcBasinRightDistance = _prefix "wcBasinRightDistance"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinSeatHeight"></see>
    /// </summary>
    let wcBasinSeatHeight = _prefix "wcBasinSeatHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinSpace"></see>
    /// </summary>
    let wcBasinSpace = _prefix "wcBasinSpace"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinAccess"></see>
    /// </summary>
    let wcCabinAccess = _prefix "wcCabinAccess"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinDepth"></see>
    /// </summary>
    let wcCabinDepth = _prefix "wcCabinDepth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinDoorDisposition"></see>
    /// </summary>
    let wcCabinDoorDisposition = _prefix "wcCabinDoorDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinLocalization"></see>
    /// </summary>
    let wcCabinLocalization = _prefix "wcCabinLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinWCBasinDisposition"></see>
    /// </summary>
    let wcCabinWCBasinDisposition = _prefix "wcCabinWCBasinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinWashBasinDisposition"></see>
    /// </summary>
    let wcCabinWashBasinDisposition = _prefix "wcCabinWashBasinDisposition"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinWidth"></see>
    /// </summary>
    let wcCabinWidth = _prefix "wcCabinWidth"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcChangingDesk"></see>
    /// </summary>
    let wcChangingDesk = _prefix "wcChangingDesk"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcChangingDeskInstalled"></see>
    /// </summary>
    let wcChangingDeskInstalled = _prefix "wcChangingDeskInstalled"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcChangingDeskObstructs"></see>
    /// </summary>
    let wcChangingDeskObstructs = _prefix "wcChangingDeskObstructs"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushing"></see>
    /// </summary>
    let wcFlushing = _prefix "wcFlushing"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushingBackHeight"></see>
    /// </summary>
    let wcFlushingBackHeight = _prefix "wcFlushingBackHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushingDifficulty"></see>
    /// </summary>
    let wcFlushingDifficulty = _prefix "wcFlushingDifficulty"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushingSideDistance"></see>
    /// </summary>
    let wcFlushingSideDistance = _prefix "wcFlushingSideDistance"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushingSideHeight"></see>
    /// </summary>
    let wcFlushingSideHeight = _prefix "wcFlushingSideHeight"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcHandlesDistance"></see>
    /// </summary>
    let wcHandlesDistance = _prefix "wcHandlesDistance"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsAlarmButton"></see>
    /// </summary>
    let wcIsAlarmButton = _prefix "wcIsAlarmButton"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsChangingDesk"></see>
    /// </summary>
    let wcIsChangingDesk = _prefix "wcIsChangingDesk"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsChangingDeskObstructs"></see>
    /// </summary>
    let wcIsChangingDeskObstructs = _prefix "wcIsChangingDeskObstructs"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsRegularWC"></see>
    /// </summary>
    let wcIsRegularWC = _prefix "wcIsRegularWC"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsRegularWCBrailleMarking"></see>
    /// </summary>
    let wcIsRegularWCBrailleMarking = _prefix "wcIsRegularWCBrailleMarking"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcLocalization"></see>
    /// </summary>
    let wcLocalization = _prefix "wcLocalization"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcRegularWC"></see>
    /// </summary>
    let wcRegularWC = _prefix "wcRegularWC"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcRegularWCBrailleLabelled"></see>
    /// </summary>
    let wcRegularWCBrailleLabelled = _prefix "wcRegularWCBrailleLabelled"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcSwitch"></see>
    /// </summary>
    let wcSwitch = _prefix "wcSwitch"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcSwitchHeight"></see>
    /// </summary>
    let wcSwitchHeight = _prefix "wcSwitchHeight"
