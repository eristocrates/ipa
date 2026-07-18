namespace http.w3id.org.charta77.jup.slash

open DoxAletheia.Rdf_Vocabulary

module jup =
    let _namespace_name = "http://w3id.org/charta77/jup/"
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AOB"></see>
    /// </summary>
    let AOB = Namespaced_IRI.parse _namespace_name "AOB" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasForm"></see>
    /// </summary>
    let hasForm = Namespaced_IRI.parse _namespace_name "hasForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ElevatorMKPOForm"></see>
    /// </summary>
    let ElevatorMKPOForm =
        Namespaced_IRI.parse _namespace_name "ElevatorMKPOForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectMKPOForm"></see>
    /// </summary>
    let ObjectMKPOForm =
        Namespaced_IRI.parse _namespace_name "ObjectMKPOForm" |> NamespacedName

    /// <summary>
    /// Defined to complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/seeAlso"></see></summary>
    let seeAlso = Namespaced_IRI.parse _namespace_name "seeAlso" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PhysicalEntity"></see>
    /// </summary>
    let PhysicalEntity =
        Namespaced_IRI.parse _namespace_name "PhysicalEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MappableEntity"></see>
    /// </summary>
    let MappableEntity =
        Namespaced_IRI.parse _namespace_name "MappableEntity" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/AOBAnnouncement"></see></summary>
    let AOBAnnouncement =
        Namespaced_IRI.parse _namespace_name "AOBAnnouncement" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/AOBAnnouncementsScheme"></see></summary>
    let AOBAnnouncementsScheme =
        Namespaced_IRI.parse _namespace_name "AOBAnnouncementsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AccessibleObjectMKPO"></see>
    /// </summary>
    let AccessibleObjectMKPO =
        Namespaced_IRI.parse _namespace_name "AccessibleObjectMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectCategorizationMKPO"></see>
    /// </summary>
    let ObjectCategorizationMKPO =
        Namespaced_IRI.parse _namespace_name "ObjectCategorizationMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectCategorizationsMKPOScheme"></see>
    /// </summary>
    let ObjectCategorizationsMKPOScheme =
        Namespaced_IRI.parse _namespace_name "ObjectCategorizationsMKPOScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AccessibleWCMKPO"></see>
    /// </summary>
    let AccessibleWCMKPO =
        Namespaced_IRI.parse _namespace_name "AccessibleWCMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCCategorizationMKPO"></see>
    /// </summary>
    let WCCategorizationMKPO =
        Namespaced_IRI.parse _namespace_name "WCCategorizationMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCCategorizationsMKPOScheme"></see>
    /// </summary>
    let WCCategorizationsMKPOScheme =
        Namespaced_IRI.parse _namespace_name "WCCategorizationsMKPOScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AddressableEntity"></see>
    /// </summary>
    let AddressableEntity =
        Namespaced_IRI.parse _namespace_name "AddressableEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AdministrativeOfficeObjectCategory"></see>
    /// </summary>
    let AdministrativeOfficeObjectCategory =
        Namespaced_IRI.parse _namespace_name "AdministrativeOfficeObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectCategory"></see>
    /// </summary>
    let ObjectCategory =
        Namespaced_IRI.parse _namespace_name "ObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectCategoriesScheme"></see>
    /// </summary>
    let ObjectCategoriesScheme =
        Namespaced_IRI.parse _namespace_name "ObjectCategoriesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AirportObjectCategory"></see>
    /// </summary>
    let AirportObjectCategory =
        Namespaced_IRI.parse _namespace_name "AirportObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ArtificialEntranceGuidingLine"></see>
    /// </summary>
    let ArtificialEntranceGuidingLine =
        Namespaced_IRI.parse _namespace_name "ArtificialEntranceGuidingLine" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/EntranceGuidingLine"></see></summary>
    let EntranceGuidingLine =
        Namespaced_IRI.parse _namespace_name "EntranceGuidingLine" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/EntranceGuidingLinesScheme"></see></summary>
    let EntranceGuidingLinesScheme =
        Namespaced_IRI.parse _namespace_name "EntranceGuidingLinesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AssessableEntity"></see>
    /// </summary>
    let AssessableEntity =
        Namespaced_IRI.parse _namespace_name "AssessableEntity" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AutomaticDoorOpening"></see>
    /// </summary>
    let AutomaticDoorOpening =
        Namespaced_IRI.parse _namespace_name "AutomaticDoorOpening" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorOpening"></see></summary>
    let DoorOpening =
        Namespaced_IRI.parse _namespace_name "DoorOpening" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorOpeningsScheme"></see></summary>
    let DoorOpeningsScheme =
        Namespaced_IRI.parse _namespace_name "DoorOpeningsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AutomaticWCFlushing"></see>
    /// </summary>
    let AutomaticWCFlushing =
        Namespaced_IRI.parse _namespace_name "AutomaticWCFlushing" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCFlushing"></see></summary>
    let WCFlushing = Namespaced_IRI.parse _namespace_name "WCFlushing" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCFlushingsScheme"></see></summary>
    let WCFlushingsScheme =
        Namespaced_IRI.parse _namespace_name "WCFlushingsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/AutomaticWCSwitch"></see>
    /// </summary>
    let AutomaticWCSwitch =
        Namespaced_IRI.parse _namespace_name "AutomaticWCSwitch" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCSwitch"></see></summary>
    let WCSwitch = Namespaced_IRI.parse _namespace_name "WCSwitch" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCSwitchesScheme"></see></summary>
    let WCSwitchesScheme =
        Namespaced_IRI.parse _namespace_name "WCSwitchesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BankObjectCategory"></see>
    /// </summary>
    let BankObjectCategory =
        Namespaced_IRI.parse _namespace_name "BankObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Bannister"></see>
    /// </summary>
    let Bannister = Namespaced_IRI.parse _namespace_name "Bannister" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BarObjectCategory"></see>
    /// </summary>
    let BarObjectCategory =
        Namespaced_IRI.parse _namespace_name "BarObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BasilicaObjectCategory"></see>
    /// </summary>
    let BasilicaObjectCategory =
        Namespaced_IRI.parse _namespace_name "BasilicaObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Bell"></see>
    /// </summary>
    let Bell = Namespaced_IRI.parse _namespace_name "Bell" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PlatformMKPOForm"></see>
    /// </summary>
    let PlatformMKPOForm =
        Namespaced_IRI.parse _namespace_name "PlatformMKPOForm" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/BellType"></see></summary>
    let BellType = Namespaced_IRI.parse _namespace_name "BellType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/BellTypesScheme"></see></summary>
    let BellTypesScheme =
        Namespaced_IRI.parse _namespace_name "BellTypesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BentRampType"></see>
    /// </summary>
    let BentRampType =
        Namespaced_IRI.parse _namespace_name "BentRampType" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampType"></see></summary>
    let RampType = Namespaced_IRI.parse _namespace_name "RampType" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampTypesScheme"></see></summary>
    let RampTypesScheme =
        Namespaced_IRI.parse _namespace_name "RampTypesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BlockedByFixedWCBasinSpace"></see>
    /// </summary>
    let BlockedByFixedWCBasinSpace =
        Namespaced_IRI.parse _namespace_name "BlockedByFixedWCBasinSpace" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCBasinSpace"></see></summary>
    let WCBasinSpace =
        Namespaced_IRI.parse _namespace_name "WCBasinSpace" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCBasinSpacesScheme"></see></summary>
    let WCBasinSpacesScheme =
        Namespaced_IRI.parse _namespace_name "WCBasinSpacesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BlockedByMobileWCBasinSpace"></see>
    /// </summary>
    let BlockedByMobileWCBasinSpace =
        Namespaced_IRI.parse _namespace_name "BlockedByMobileWCBasinSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BotanicGardenObjectCategory"></see>
    /// </summary>
    let BotanicGardenObjectCategory =
        Namespaced_IRI.parse _namespace_name "BotanicGardenObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BottomContrastMarkingLocalization"></see>
    /// </summary>
    let BottomContrastMarkingLocalization =
        Namespaced_IRI.parse _namespace_name "BottomContrastMarkingLocalization" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ContrastMarkingLocalization"></see></summary>
    let ContrastMarkingLocalization =
        Namespaced_IRI.parse _namespace_name "ContrastMarkingLocalization" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ContrastMarkingLocalizationsScheme"></see></summary>
    let ContrastMarkingLocalizationsScheme =
        Namespaced_IRI.parse _namespace_name "ContrastMarkingLocalizationsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BottomEntryArea"></see>
    /// </summary>
    let BottomEntryArea =
        Namespaced_IRI.parse _namespace_name "BottomEntryArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RampSkidsMKPOForm"></see>
    /// </summary>
    let RampSkidsMKPOForm =
        Namespaced_IRI.parse _namespace_name "RampSkidsMKPOForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EntryArea"></see>
    /// </summary>
    let EntryArea = Namespaced_IRI.parse _namespace_name "EntryArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BottomLeftWCCabinDisposition"></see>
    /// </summary>
    let BottomLeftWCCabinDisposition =
        Namespaced_IRI.parse _namespace_name "BottomLeftWCCabinDisposition" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCCabinDisposition"></see></summary>
    let WCCabinDisposition =
        Namespaced_IRI.parse _namespace_name "WCCabinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCCabinDispositionsScheme"></see>
    /// </summary>
    let WCCabinDispositionsScheme =
        Namespaced_IRI.parse _namespace_name "WCCabinDispositionsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BottomRightWCCabinDisposition"></see>
    /// </summary>
    let BottomRightWCCabinDisposition =
        Namespaced_IRI.parse _namespace_name "BottomRightWCCabinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BreweryObjectCategory"></see>
    /// </summary>
    let BreweryObjectCategory =
        Namespaced_IRI.parse _namespace_name "BreweryObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/BusStationObjectCategory"></see>
    /// </summary>
    let BusStationObjectCategory =
        Namespaced_IRI.parse _namespace_name "BusStationObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CampObjectCategory"></see>
    /// </summary>
    let CampObjectCategory =
        Namespaced_IRI.parse _namespace_name "CampObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CarDealerObjectCategory"></see>
    /// </summary>
    let CarDealerObjectCategory =
        Namespaced_IRI.parse _namespace_name "CarDealerObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CargoElevatorType"></see>
    /// </summary>
    let CargoElevatorType =
        Namespaced_IRI.parse _namespace_name "CargoElevatorType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorType"></see></summary>
    let ElevatorType =
        Namespaced_IRI.parse _namespace_name "ElevatorType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorTypesScheme"></see></summary>
    let ElevatorTypesScheme =
        Namespaced_IRI.parse _namespace_name "ElevatorTypesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CarouselDoorType"></see>
    /// </summary>
    let CarouselDoorType =
        Namespaced_IRI.parse _namespace_name "CarouselDoorType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorType"></see></summary>
    let DoorType = Namespaced_IRI.parse _namespace_name "DoorType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorTypesScheme"></see></summary>
    let DoorTypesScheme =
        Namespaced_IRI.parse _namespace_name "DoorTypesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CathedralObjectCategory"></see>
    /// </summary>
    let CathedralObjectCategory =
        Namespaced_IRI.parse _namespace_name "CathedralObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ChapelObjectCategory"></see>
    /// </summary>
    let ChapelObjectCategory =
        Namespaced_IRI.parse _namespace_name "ChapelObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ChurchObjectCategory"></see>
    /// </summary>
    let ChurchObjectCategory =
        Namespaced_IRI.parse _namespace_name "ChurchObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CinemaObjectCategory"></see>
    /// </summary>
    let CinemaObjectCategory =
        Namespaced_IRI.parse _namespace_name "CinemaObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CityHallObjectCategory"></see>
    /// </summary>
    let CityHallObjectCategory =
        Namespaced_IRI.parse _namespace_name "CityHallObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CollegeObjectCategory"></see>
    /// </summary>
    let CollegeObjectCategory =
        Namespaced_IRI.parse _namespace_name "CollegeObjectCategory" |> NamespacedName

    /// <summary>
    /// e.g. Prague Castle
    /// <see href="http://w3id.org/charta77/jup/Complex"></see></summary>
    let Complex = Namespaced_IRI.parse _namespace_name "Complex" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ConcertHallObjectCategory"></see>
    /// </summary>
    let ConcertHallObjectCategory =
        Namespaced_IRI.parse _namespace_name "ConcertHallObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ContactSocialServiceObjectCategory"></see>
    /// </summary>
    let ContactSocialServiceObjectCategory =
        Namespaced_IRI.parse _namespace_name "ContactSocialServiceObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ContrastMarking"></see>
    /// </summary>
    let ContrastMarking =
        Namespaced_IRI.parse _namespace_name "ContrastMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCMKPOForm"></see>
    /// </summary>
    let WCMKPOForm = Namespaced_IRI.parse _namespace_name "WCMKPOForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/CourtObjectCategory"></see>
    /// </summary>
    let CourtObjectCategory =
        Namespaced_IRI.parse _namespace_name "CourtObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DefensiveCastleObjectCategory"></see>
    /// </summary>
    let DefensiveCastleObjectCategory =
        Namespaced_IRI.parse _namespace_name "DefensiveCastleObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DentalEmergencyObjectCategory"></see>
    /// </summary>
    let DentalEmergencyObjectCategory =
        Namespaced_IRI.parse _namespace_name "DentalEmergencyObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DepartmentStoreObjectCategory"></see>
    /// </summary>
    let DepartmentStoreObjectCategory =
        Namespaced_IRI.parse _namespace_name "DepartmentStoreObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DifficultWCFlushingDifficulty"></see>
    /// </summary>
    let DifficultWCFlushingDifficulty =
        Namespaced_IRI.parse _namespace_name "DifficultWCFlushingDifficulty" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCFlushingDifficulty"></see></summary>
    let WCFlushingDifficulty =
        Namespaced_IRI.parse _namespace_name "WCFlushingDifficulty" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCFlushingDifficultiesScheme"></see></summary>
    let WCFlushingDifficultiesScheme =
        Namespaced_IRI.parse _namespace_name "WCFlushingDifficultiesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DigitalElevatorControlFlatMarking"></see>
    /// </summary>
    let DigitalElevatorControlFlatMarking =
        Namespaced_IRI.parse _namespace_name "DigitalElevatorControlFlatMarking" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorControlFlatMarking"></see></summary>
    let ElevatorControlFlatMarking =
        Namespaced_IRI.parse _namespace_name "ElevatorControlFlatMarking" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorControlFlatMarkingsScheme"></see></summary>
    let ElevatorControlFlatMarkingsScheme =
        Namespaced_IRI.parse _namespace_name "ElevatorControlFlatMarkingsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DirectObjectStairsType"></see>
    /// </summary>
    let DirectObjectStairsType =
        Namespaced_IRI.parse _namespace_name "DirectObjectStairsType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/StepsStairsType"></see></summary>
    let StepsStairsType =
        Namespaced_IRI.parse _namespace_name "StepsStairsType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/StepsStairsTypesScheme"></see></summary>
    let StepsStairsTypesScheme =
        Namespaced_IRI.parse _namespace_name "StepsStairsTypesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DirectRampType"></see>
    /// </summary>
    let DirectRampType =
        Namespaced_IRI.parse _namespace_name "DirectRampType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DoctorObjectCategory"></see>
    /// </summary>
    let DoctorObjectCategory =
        Namespaced_IRI.parse _namespace_name "DoctorObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Door"></see>
    /// </summary>
    let Door = Namespaced_IRI.parse _namespace_name "Door" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorOpeningDirection"></see></summary>
    let DoorOpeningDirection =
        Namespaced_IRI.parse _namespace_name "DoorOpeningDirection" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/DoorOpeningDirectionsScheme"></see></summary>
    let DoorOpeningDirectionsScheme =
        Namespaced_IRI.parse _namespace_name "DoorOpeningDirectionsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/DoublePanelledDoorType"></see>
    /// </summary>
    let DoublePanelledDoorType =
        Namespaced_IRI.parse _namespace_name "DoublePanelledDoorType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Elevator"></see>
    /// </summary>
    let Elevator = Namespaced_IRI.parse _namespace_name "Elevator" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ElevatorCageDoor"></see>
    /// </summary>
    let ElevatorCageDoor =
        Namespaced_IRI.parse _namespace_name "ElevatorCageDoor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ElevatorCageHandle"></see>
    /// </summary>
    let ElevatorCageHandle =
        Namespaced_IRI.parse _namespace_name "ElevatorCageHandle" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Handle"></see>
    /// </summary>
    let Handle = Namespaced_IRI.parse _namespace_name "Handle" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorCageMirrorLocalization"></see></summary>
    let ElevatorCageMirrorLocalization =
        Namespaced_IRI.parse _namespace_name "ElevatorCageMirrorLocalization" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorCageMirrorLocalizationsScheme"></see></summary>
    let ElevatorCageMirrorLocalizationsScheme =
        Namespaced_IRI.parse _namespace_name "ElevatorCageMirrorLocalizationsScheme" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorCageSecondDoorLocalization"></see></summary>
    let ElevatorCageSecondDoorLocalization =
        Namespaced_IRI.parse _namespace_name "ElevatorCageSecondDoorLocalization" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorCageSecondDoorLocalizationsScheme"></see></summary>
    let ElevatorCageSecondDoorLocalizationsScheme =
        Namespaced_IRI.parse _namespace_name "ElevatorCageSecondDoorLocalizationsScheme" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorControlReliefMarking"></see></summary>
    let ElevatorControlReliefMarking =
        Namespaced_IRI.parse _namespace_name "ElevatorControlReliefMarking" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorControlReliefMarkingsScheme"></see></summary>
    let ElevatorControlReliefMarkingsScheme =
        Namespaced_IRI.parse _namespace_name "ElevatorControlReliefMarkingsScheme" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorDriveOff"></see></summary>
    let ElevatorDriveOff =
        Namespaced_IRI.parse _namespace_name "ElevatorDriveOff" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ElevatorDriveOffsScheme"></see></summary>
    let ElevatorDriveOffsScheme =
        Namespaced_IRI.parse _namespace_name "ElevatorDriveOffsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MappableEntityForm"></see>
    /// </summary>
    let MappableEntityForm =
        Namespaced_IRI.parse _namespace_name "MappableEntityForm" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MappableEntityMKPOFormsScheme"></see>
    /// </summary>
    let MappableEntityMKPOFormsScheme =
        Namespaced_IRI.parse _namespace_name "MappableEntityMKPOFormsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ElevatorShaftDoor"></see>
    /// </summary>
    let ElevatorShaftDoor =
        Namespaced_IRI.parse _namespace_name "ElevatorShaftDoor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EmbassyObjectCategory"></see>
    /// </summary>
    let EmbassyObjectCategory =
        Namespaced_IRI.parse _namespace_name "EmbassyObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EmploymentOfficeObjectCategory"></see>
    /// </summary>
    let EmploymentOfficeObjectCategory =
        Namespaced_IRI.parse _namespace_name "EmploymentOfficeObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EngravedElevatorControlReliefMarking"></see>
    /// </summary>
    let EngravedElevatorControlReliefMarking =
        Namespaced_IRI.parse _namespace_name "EngravedElevatorControlReliefMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EntireObjectInteriorAccessibility"></see>
    /// </summary>
    let EntireObjectInteriorAccessibility =
        Namespaced_IRI.parse _namespace_name "EntireObjectInteriorAccessibility" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ObjectInteriorAccessibility"></see></summary>
    let ObjectInteriorAccessibility =
        Namespaced_IRI.parse _namespace_name "ObjectInteriorAccessibility" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/ObjectInteriorAccessibilitiesScheme"></see></summary>
    let ObjectInteriorAccessibilitiesScheme =
        Namespaced_IRI.parse _namespace_name "ObjectInteriorAccessibilitiesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Entrance"></see>
    /// </summary>
    let Entrance = Namespaced_IRI.parse _namespace_name "Entrance" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/EntranceAccessibilitiesScheme"></see></summary>
    let EntranceAccessibilitiesScheme =
        Namespaced_IRI.parse _namespace_name "EntranceAccessibilitiesScheme" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/EntranceAccessibility"></see></summary>
    let EntranceAccessibility =
        Namespaced_IRI.parse _namespace_name "EntranceAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EntranceRampSkidsLocalization"></see>
    /// </summary>
    let EntranceRampSkidsLocalization =
        Namespaced_IRI.parse _namespace_name "EntranceRampSkidsLocalization" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSkidsLocalization"></see></summary>
    let RampSkidsLocalization =
        Namespaced_IRI.parse _namespace_name "RampSkidsLocalization" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSkidsLocalizationsScheme"></see></summary>
    let RampSkidsLocalizationsScheme =
        Namespaced_IRI.parse _namespace_name "RampSkidsLocalizationsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/EntranceSteps"></see>
    /// </summary>
    let EntranceSteps =
        Namespaced_IRI.parse _namespace_name "EntranceSteps" |> NamespacedName

    /// <summary>
    /// Stairs is understood as connecting different floors
    /// <see href="http://w3id.org/charta77/jup/Steps"></see></summary>
    let Steps = Namespaced_IRI.parse _namespace_name "Steps" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/EntryAreaEntriesScheme"></see></summary>
    let EntryAreaEntriesScheme =
        Namespaced_IRI.parse _namespace_name "EntryAreaEntriesScheme" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/EntryAreaEntry"></see></summary>
    let EntryAreaEntry =
        Namespaced_IRI.parse _namespace_name "EntryAreaEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FarmObjectCategory"></see>
    /// </summary>
    let FarmObjectCategory =
        Namespaced_IRI.parse _namespace_name "FarmObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FastFoodObjectCategory"></see>
    /// </summary>
    let FastFoodObjectCategory =
        Namespaced_IRI.parse _namespace_name "FastFoodObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FixedHandleType"></see>
    /// </summary>
    let FixedHandleType =
        Namespaced_IRI.parse _namespace_name "FixedHandleType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleType"></see></summary>
    let HandleType = Namespaced_IRI.parse _namespace_name "HandleType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleTypesScheme"></see></summary>
    let HandleTypesScheme =
        Namespaced_IRI.parse _namespace_name "HandleTypesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FixedRampSkidsMobility"></see>
    /// </summary>
    let FixedRampSkidsMobility =
        Namespaced_IRI.parse _namespace_name "FixedRampSkidsMobility" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSkidsMobility"></see></summary>
    let RampSkidsMobility =
        Namespaced_IRI.parse _namespace_name "RampSkidsMobility" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSkidsMobilitiesScheme"></see></summary>
    let RampSkidsMobilitiesScheme =
        Namespaced_IRI.parse _namespace_name "RampSkidsMobilitiesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FoldingHandleType"></see>
    /// </summary>
    let FoldingHandleType =
        Namespaced_IRI.parse _namespace_name "FoldingHandleType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FoldingWCChangingDesk"></see>
    /// </summary>
    let FoldingWCChangingDesk =
        Namespaced_IRI.parse _namespace_name "FoldingWCChangingDesk" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCChangingDesk"></see></summary>
    let WCChangingDesk =
        Namespaced_IRI.parse _namespace_name "WCChangingDesk" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCChangingDesksScheme"></see></summary>
    let WCChangingDesksScheme =
        Namespaced_IRI.parse _namespace_name "WCChangingDesksScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FolkArchitectureObjectCategory"></see>
    /// </summary>
    let FolkArchitectureObjectCategory =
        Namespaced_IRI.parse _namespace_name "FolkArchitectureObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Form"></see>
    /// </summary>
    let Form = Namespaced_IRI.parse _namespace_name "Form" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FortObjectCategory"></see>
    /// </summary>
    let FortObjectCategory =
        Namespaced_IRI.parse _namespace_name "FortObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FortressObjectCategory"></see>
    /// </summary>
    let FortressObjectCategory =
        Namespaced_IRI.parse _namespace_name "FortressObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FreeWCBasinSpace"></see>
    /// </summary>
    let FreeWCBasinSpace =
        Namespaced_IRI.parse _namespace_name "FreeWCBasinSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FreelyAccessibleMappableEntityAccess"></see>
    /// </summary>
    let FreelyAccessibleMappableEntityAccess =
        Namespaced_IRI.parse _namespace_name "FreelyAccessibleMappableEntityAccess" |> NamespacedName

    /// <summary>
    /// The list was copied based on forms compliant with Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/MappableEntityAccess"></see></summary>
    let MappableEntityAccess =
        Namespaced_IRI.parse _namespace_name "MappableEntityAccess" |> NamespacedName

    /// <summary>
    /// The list was copied based on forms compliant with Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/MappableEntityAccessesScheme"></see></summary>
    let MappableEntityAccessesScheme =
        Namespaced_IRI.parse _namespace_name "MappableEntityAccessesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FrontElevatorCageSecondDoorLocalization"></see>
    /// </summary>
    let FrontElevatorCageSecondDoorLocalization =
        Namespaced_IRI.parse _namespace_name "FrontElevatorCageSecondDoorLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FrontEntryAreaEntry"></see>
    /// </summary>
    let FrontEntryAreaEntry =
        Namespaced_IRI.parse _namespace_name "FrontEntryAreaEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FrontWallElevatorCageMirrorLocalization"></see>
    /// </summary>
    let FrontWallElevatorCageMirrorLocalization =
        Namespaced_IRI.parse _namespace_name "FrontWallElevatorCageMirrorLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FrontWallHandleLocalization"></see>
    /// </summary>
    let FrontWallHandleLocalization =
        Namespaced_IRI.parse _namespace_name "FrontWallHandleLocalization" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleLocalization"></see></summary>
    let HandleLocalization =
        Namespaced_IRI.parse _namespace_name "HandleLocalization" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleLocalizationsScheme"></see></summary>
    let HandleLocalizationsScheme =
        Namespaced_IRI.parse _namespace_name "HandleLocalizationsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/FunerallHallObjectCategory"></see>
    /// </summary>
    let FunerallHallObjectCategory =
        Namespaced_IRI.parse _namespace_name "FunerallHallObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GalleryObjectCategory"></see>
    /// </summary>
    let GalleryObjectCategory =
        Namespaced_IRI.parse _namespace_name "GalleryObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GasStationObjectCategory"></see>
    /// </summary>
    let GasStationObjectCategory =
        Namespaced_IRI.parse _namespace_name "GasStationObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GentsWCCabinLocalization"></see>
    /// </summary>
    let GentsWCCabinLocalization =
        Namespaced_IRI.parse _namespace_name "GentsWCCabinLocalization" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCCabinLocalization"></see></summary>
    let WCCabinLocalization =
        Namespaced_IRI.parse _namespace_name "WCCabinLocalization" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WCCabinLocalizationsScheme"></see></summary>
    let WCCabinLocalizationsScheme =
        Namespaced_IRI.parse _namespace_name "WCCabinLocalizationsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GraphicElevatorControlFlatMarking"></see>
    /// </summary>
    let GraphicElevatorControlFlatMarking =
        Namespaced_IRI.parse _namespace_name "GraphicElevatorControlFlatMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/GuestHouseObjectCategory"></see>
    /// </summary>
    let GuestHouseObjectCategory =
        Namespaced_IRI.parse _namespace_name "GuestHouseObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Hallway"></see>
    /// </summary>
    let Hallway = Namespaced_IRI.parse _namespace_name "Hallway" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleOrientation"></see></summary>
    let HandleOrientation =
        Namespaced_IRI.parse _namespace_name "HandleOrientation" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandleOrientationsScheme"></see></summary>
    let HandleOrientationsScheme =
        Namespaced_IRI.parse _namespace_name "HandleOrientationsScheme" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandlePosition"></see></summary>
    let HandlePosition =
        Namespaced_IRI.parse _namespace_name "HandlePosition" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/HandlePositionsScheme"></see></summary>
    let HandlePositionsScheme =
        Namespaced_IRI.parse _namespace_name "HandlePositionsScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HarborObjectCategory"></see>
    /// </summary>
    let HarborObjectCategory =
        Namespaced_IRI.parse _namespace_name "HarborObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HealthCenterObjectCategory"></see>
    /// </summary>
    let HealthCenterObjectCategory =
        Namespaced_IRI.parse _namespace_name "HealthCenterObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HealthInsuranceCompanyObjectCategory"></see>
    /// </summary>
    let HealthInsuranceCompanyObjectCategory =
        Namespaced_IRI.parse _namespace_name "HealthInsuranceCompanyObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HighSchoolObjectCategory"></see>
    /// </summary>
    let HighSchoolObjectCategory =
        Namespaced_IRI.parse _namespace_name "HighSchoolObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HorizontalHandleOrientation"></see>
    /// </summary>
    let HorizontalHandleOrientation =
        Namespaced_IRI.parse _namespace_name "HorizontalHandleOrientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HospitalObjectCategory"></see>
    /// </summary>
    let HospitalObjectCategory =
        Namespaced_IRI.parse _namespace_name "HospitalObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HotelObjectCategory"></see>
    /// </summary>
    let HotelObjectCategory =
        Namespaced_IRI.parse _namespace_name "HotelObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/HypermarketObjectCategory"></see>
    /// </summary>
    let HypermarketObjectCategory =
        Namespaced_IRI.parse _namespace_name "HypermarketObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InaccessibleObjectInteriorAccessibility"></see>
    /// </summary>
    let InaccessibleObjectInteriorAccessibility =
        Namespaced_IRI.parse _namespace_name "InaccessibleObjectInteriorAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InaccessibleObjectMKPO"></see>
    /// </summary>
    let InaccessibleObjectMKPO =
        Namespaced_IRI.parse _namespace_name "InaccessibleObjectMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InaccessibleWCMKPO"></see>
    /// </summary>
    let InaccessibleWCMKPO =
        Namespaced_IRI.parse _namespace_name "InaccessibleWCMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InclinedPlatformType"></see>
    /// </summary>
    let InclinedPlatformType =
        Namespaced_IRI.parse _namespace_name "InclinedPlatformType" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/PlatformType"></see></summary>
    let PlatformType =
        Namespaced_IRI.parse _namespace_name "PlatformType" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/PlatformTypesScheme"></see></summary>
    let PlatformTypesScheme =
        Namespaced_IRI.parse _namespace_name "PlatformTypesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/IndoorSwimmingPoolObjectCategory"></see>
    /// </summary>
    let IndoorSwimmingPoolObjectCategory =
        Namespaced_IRI.parse _namespace_name "IndoorSwimmingPoolObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InformationCenterObjectCategory"></see>
    /// </summary>
    let InformationCenterObjectCategory =
        Namespaced_IRI.parse _namespace_name "InformationCenterObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InsideHandlePosition"></see>
    /// </summary>
    let InsideHandlePosition =
        Namespaced_IRI.parse _namespace_name "InsideHandlePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InsufficientWashBasinUnderpass"></see>
    /// </summary>
    let InsufficientWashBasinUnderpass =
        Namespaced_IRI.parse _namespace_name "InsufficientWashBasinUnderpass" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WashBasinUnderpass"></see></summary>
    let WashBasinUnderpass =
        Namespaced_IRI.parse _namespace_name "WashBasinUnderpass" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/WashBasinUnderpassesScheme"></see></summary>
    let WashBasinUnderpassesScheme =
        Namespaced_IRI.parse _namespace_name "WashBasinUnderpassesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InsuranceOfficeObjectCategory"></see>
    /// </summary>
    let InsuranceOfficeObjectCategory =
        Namespaced_IRI.parse _namespace_name "InsuranceOfficeObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/IntercomBellType"></see>
    /// </summary>
    let IntercomBellType =
        Namespaced_IRI.parse _namespace_name "IntercomBellType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InteriorRampSkidsLocalization"></see>
    /// </summary>
    let InteriorRampSkidsLocalization =
        Namespaced_IRI.parse _namespace_name "InteriorRampSkidsLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InteriorStairs"></see>
    /// </summary>
    let InteriorStairs =
        Namespaced_IRI.parse _namespace_name "InteriorStairs" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/InteriorSteps"></see>
    /// </summary>
    let InteriorSteps =
        Namespaced_IRI.parse _namespace_name "InteriorSteps" |> NamespacedName

    /// <summary>
    /// to the interior of the cabine
    /// <see href="http://w3id.org/charta77/jup/InwardsDoorOpeningDirection"></see></summary>
    let InwardsDoorOpeningDirection =
        Namespaced_IRI.parse _namespace_name "InwardsDoorOpeningDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/JingleAOBAnnouncement"></see>
    /// </summary>
    let JingleAOBAnnouncement =
        Namespaced_IRI.parse _namespace_name "JingleAOBAnnouncement" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/KindergartenObjectCategory"></see>
    /// </summary>
    let KindergartenObjectCategory =
        Namespaced_IRI.parse _namespace_name "KindergartenObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LadiesWCCabinLocalization"></see>
    /// </summary>
    let LadiesWCCabinLocalization =
        Namespaced_IRI.parse _namespace_name "LadiesWCCabinLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LandingsElevatorDriveOff"></see>
    /// </summary>
    let LandingsElevatorDriveOff =
        Namespaced_IRI.parse _namespace_name "LandingsElevatorDriveOff" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LandingsEntryArea"></see>
    /// </summary>
    let LandingsEntryArea =
        Namespaced_IRI.parse _namespace_name "LandingsEntryArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LeftBottomWCCabinDisposition"></see>
    /// </summary>
    let LeftBottomWCCabinDisposition =
        Namespaced_IRI.parse _namespace_name "LeftBottomWCCabinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LeftTopWCCabinDisposition"></see>
    /// </summary>
    let LeftTopWCCabinDisposition =
        Namespaced_IRI.parse _namespace_name "LeftTopWCCabinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LevelTap"></see>
    /// </summary>
    let LevelTap = Namespaced_IRI.parse _namespace_name "LevelTap" |> NamespacedName
    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/TapType"></see></summary>
    let TapType = Namespaced_IRI.parse _namespace_name "TapType" |> NamespacedName

    /// <summary>
    /// The list copied from the form based on Object Accessibility Categorization Methodology
    /// <see href="http://w3id.org/charta77/jup/TapTypesScheme"></see></summary>
    let TapTypesScheme =
        Namespaced_IRI.parse _namespace_name "TapTypesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LibraryObjectCategory"></see>
    /// </summary>
    let LibraryObjectCategory =
        Namespaced_IRI.parse _namespace_name "LibraryObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LobbyDoor"></see>
    /// </summary>
    let LobbyDoor = Namespaced_IRI.parse _namespace_name "LobbyDoor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LobbyRampSkidsLocalization"></see>
    /// </summary>
    let LobbyRampSkidsLocalization =
        Namespaced_IRI.parse _namespace_name "LobbyRampSkidsLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LobbySteps"></see>
    /// </summary>
    let LobbySteps = Namespaced_IRI.parse _namespace_name "LobbySteps" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LockedMappableEntityAccess"></see>
    /// </summary>
    let LockedMappableEntityAccess =
        Namespaced_IRI.parse _namespace_name "LockedMappableEntityAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/LoretoObjectCategory"></see>
    /// </summary>
    let LoretoObjectCategory =
        Namespaced_IRI.parse _namespace_name "LoretoObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MainEntrance"></see>
    /// </summary>
    let MainEntrance =
        Namespaced_IRI.parse _namespace_name "MainEntrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Mapper"></see>
    /// </summary>
    let Mapper = Namespaced_IRI.parse _namespace_name "Mapper" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MechanicalDoorOpening"></see>
    /// </summary>
    let MechanicalDoorOpening =
        Namespaced_IRI.parse _namespace_name "MechanicalDoorOpening" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MechanicalWCFlushing"></see>
    /// </summary>
    let MechanicalWCFlushing =
        Namespaced_IRI.parse _namespace_name "MechanicalWCFlushing" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MedicalEmergencyObjectCategory"></see>
    /// </summary>
    let MedicalEmergencyObjectCategory =
        Namespaced_IRI.parse _namespace_name "MedicalEmergencyObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MedicalSupplyObjectCategory"></see>
    /// </summary>
    let MedicalSupplyObjectCategory =
        Namespaced_IRI.parse _namespace_name "MedicalSupplyObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MetropolitanPoliceObjectCategory"></see>
    /// </summary>
    let MetropolitanPoliceObjectCategory =
        Namespaced_IRI.parse _namespace_name "MetropolitanPoliceObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MezzaninesElevatorDriveOff"></see>
    /// </summary>
    let MezzaninesElevatorDriveOff =
        Namespaced_IRI.parse _namespace_name "MezzaninesElevatorDriveOff" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingBellType"></see>
    /// </summary>
    let MissingBellType =
        Namespaced_IRI.parse _namespace_name "MissingBellType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingContrastMarkingLocalization"></see>
    /// </summary>
    let MissingContrastMarkingLocalization =
        Namespaced_IRI.parse _namespace_name "MissingContrastMarkingLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingEntranceGuidingLine"></see>
    /// </summary>
    let MissingEntranceGuidingLine =
        Namespaced_IRI.parse _namespace_name "MissingEntranceGuidingLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingHandlePosition"></see>
    /// </summary>
    let MissingHandlePosition =
        Namespaced_IRI.parse _namespace_name "MissingHandlePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MissingWCSwitch"></see>
    /// </summary>
    let MissingWCSwitch =
        Namespaced_IRI.parse _namespace_name "MissingWCSwitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MobileRampSkidsMobility"></see>
    /// </summary>
    let MobileRampSkidsMobility =
        Namespaced_IRI.parse _namespace_name "MobileRampSkidsMobility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MobileWCChangingDesk"></see>
    /// </summary>
    let MobileWCChangingDesk =
        Namespaced_IRI.parse _namespace_name "MobileWCChangingDesk" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MonasteryObjectCategory"></see>
    /// </summary>
    let MonasteryObjectCategory =
        Namespaced_IRI.parse _namespace_name "MonasteryObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MonumentObjectCategory"></see>
    /// </summary>
    let MonumentObjectCategory =
        Namespaced_IRI.parse _namespace_name "MonumentObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MoreStepsEntranceAccessibility"></see>
    /// </summary>
    let MoreStepsEntranceAccessibility =
        Namespaced_IRI.parse _namespace_name "MoreStepsEntranceAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MosqueObjectCategory"></see>
    /// </summary>
    let MosqueObjectCategory =
        Namespaced_IRI.parse _namespace_name "MosqueObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MunicipalOfficeObjectCategory"></see>
    /// </summary>
    let MunicipalOfficeObjectCategory =
        Namespaced_IRI.parse _namespace_name "MunicipalOfficeObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MunicipalityObjectCategory"></see>
    /// </summary>
    let MunicipalityObjectCategory =
        Namespaced_IRI.parse _namespace_name "MunicipalityObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/MuseumObjectCategory"></see>
    /// </summary>
    let MuseumObjectCategory =
        Namespaced_IRI.parse _namespace_name "MuseumObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NarrowedPassage"></see>
    /// </summary>
    let NarrowedPassage =
        Namespaced_IRI.parse _namespace_name "NarrowedPassage" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NaturalEntranceGuidingLine"></see>
    /// </summary>
    let NaturalEntranceGuidingLine =
        Namespaced_IRI.parse _namespace_name "NaturalEntranceGuidingLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NavigationSystem"></see>
    /// </summary>
    let NavigationSystem =
        Namespaced_IRI.parse _namespace_name "NavigationSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NoElevationEntranceAccessibility"></see>
    /// </summary>
    let NoElevationEntranceAccessibility =
        Namespaced_IRI.parse _namespace_name "NoElevationEntranceAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NonslipperyRampSurface"></see>
    /// </summary>
    let NonslipperyRampSurface =
        Namespaced_IRI.parse _namespace_name "NonslipperyRampSurface" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSurface"></see></summary>
    let RampSurface =
        Namespaced_IRI.parse _namespace_name "RampSurface" |> NamespacedName

    /// <summary>
    /// Types of elevator cage mirror localizations
    /// <see href="http://w3id.org/charta77/jup/RampSurfacesScheme"></see></summary>
    let RampSurfacesScheme =
        Namespaced_IRI.parse _namespace_name "RampSurfacesScheme" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/NotConnectingObjectStairsType"></see>
    /// </summary>
    let NotConnectingObjectStairsType =
        Namespaced_IRI.parse _namespace_name "NotConnectingObjectStairsType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OKWCFlushingDifficulty"></see>
    /// </summary>
    let OKWCFlushingDifficulty =
        Namespaced_IRI.parse _namespace_name "OKWCFlushingDifficulty" |> NamespacedName

    /// <summary>
    /// An object may not be represented by an entire building, it can stand for its particular logic part (e.g. one department store in a multifunctional building). One address can thus comprise multiple objects.
    /// <see href="http://w3id.org/charta77/jup/Object"></see></summary>
    let Object = Namespaced_IRI.parse _namespace_name "Object" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObservatoryObjectCategory"></see>
    /// </summary>
    let ObservatoryObjectCategory =
        Namespaced_IRI.parse _namespace_name "ObservatoryObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OneSideDoorOpeningDirection"></see>
    /// </summary>
    let OneSideDoorOpeningDirection =
        Namespaced_IRI.parse _namespace_name "OneSideDoorOpeningDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OneStepEntranceAccessibility"></see>
    /// </summary>
    let OneStepEntranceAccessibility =
        Namespaced_IRI.parse _namespace_name "OneStepEntranceAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OpticianShopObjectCategory"></see>
    /// </summary>
    let OpticianShopObjectCategory =
        Namespaced_IRI.parse _namespace_name "OpticianShopObjectCategory" |> NamespacedName

    /// <summary>
    /// e.g. Prague Castle Administration
    /// <see href="http://w3id.org/charta77/jup/Organization"></see></summary>
    let Organization =
        Namespaced_IRI.parse _namespace_name "Organization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OtheroObjectCategory"></see>
    /// </summary>
    let OtheroObjectCategory =
        Namespaced_IRI.parse _namespace_name "OtheroObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/OutsideHandlePosition"></see>
    /// </summary>
    let OutsideHandlePosition =
        Namespaced_IRI.parse _namespace_name "OutsideHandlePosition" |> NamespacedName

    /// <summary>
    /// to the exterior of the cabine
    /// <see href="http://w3id.org/charta77/jup/OutwardsDoorOpeningDirection"></see></summary>
    let OutwardsDoorOpeningDirection =
        Namespaced_IRI.parse _namespace_name "OutwardsDoorOpeningDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PalaceObjectCategory"></see>
    /// </summary>
    let PalaceObjectCategory =
        Namespaced_IRI.parse _namespace_name "PalaceObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PartObjectInteriorAccessibility"></see>
    /// </summary>
    let PartObjectInteriorAccessibility =
        Namespaced_IRI.parse _namespace_name "PartObjectInteriorAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PartlyAccessibleObjectMKPO"></see>
    /// </summary>
    let PartlyAccessibleObjectMKPO =
        Namespaced_IRI.parse _namespace_name "PartlyAccessibleObjectMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PartlyAccessibleWCMKPO"></see>
    /// </summary>
    let PartlyAccessibleWCMKPO =
        Namespaced_IRI.parse _namespace_name "PartlyAccessibleWCMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PastryObjectCategory"></see>
    /// </summary>
    let PastryObjectCategory =
        Namespaced_IRI.parse _namespace_name "PastryObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PersonalElevatorType"></see>
    /// </summary>
    let PersonalElevatorType =
        Namespaced_IRI.parse _namespace_name "PersonalElevatorType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PharmacyObjectCategory"></see>
    /// </summary>
    let PharmacyObjectCategory =
        Namespaced_IRI.parse _namespace_name "PharmacyObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PhraseAOBAnnouncement"></see>
    /// </summary>
    let PhraseAOBAnnouncement =
        Namespaced_IRI.parse _namespace_name "PhraseAOBAnnouncement" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Platform"></see>
    /// </summary>
    let Platform = Namespaced_IRI.parse _namespace_name "Platform" |> NamespacedName

    /// <summary>
    /// Appendix 2
    /// <see href="http://w3id.org/charta77/jup/PlatformEntranceAccessibility"></see></summary>
    let PlatformEntranceAccessibility =
        Namespaced_IRI.parse _namespace_name "PlatformEntranceAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PoliceObjectCategory"></see>
    /// </summary>
    let PoliceObjectCategory =
        Namespaced_IRI.parse _namespace_name "PoliceObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PostOfficeObjectCategory"></see>
    /// </summary>
    let PostOfficeObjectCategory =
        Namespaced_IRI.parse _namespace_name "PostOfficeObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ProtrudingElevatorControlReliefMarking"></see>
    /// </summary>
    let ProtrudingElevatorControlReliefMarking =
        Namespaced_IRI.parse _namespace_name "ProtrudingElevatorControlReliefMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PubObjectCategory"></see>
    /// </summary>
    let PubObjectCategory =
        Namespaced_IRI.parse _namespace_name "PubObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PublicProsecutorObjectCategory"></see>
    /// </summary>
    let PublicProsecutorObjectCategory =
        Namespaced_IRI.parse _namespace_name "PublicProsecutorObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/PublicToiletObjectCategory"></see>
    /// </summary>
    let PublicToiletObjectCategory =
        Namespaced_IRI.parse _namespace_name "PublicToiletObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Ramp"></see>
    /// </summary>
    let Ramp = Namespaced_IRI.parse _namespace_name "Ramp" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RampSkids"></see>
    /// </summary>
    let RampSkids = Namespaced_IRI.parse _namespace_name "RampSkids" |> NamespacedName

    /// <summary>
    /// Appendix 3
    /// <see href="http://w3id.org/charta77/jup/RampEntranceAccessibility"></see></summary>
    let RampEntranceAccessibility =
        Namespaced_IRI.parse _namespace_name "RampEntranceAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RampHandle"></see>
    /// </summary>
    let RampHandle = Namespaced_IRI.parse _namespace_name "RampHandle" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RampLeg"></see>
    /// </summary>
    let RampLeg = Namespaced_IRI.parse _namespace_name "RampLeg" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RecreationalFacilityObjectCategory"></see>
    /// </summary>
    let RecreationalFacilityObjectCategory =
        Namespaced_IRI.parse _namespace_name "RecreationalFacilityObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ResidentialSocialServiceObjectCategory"></see>
    /// </summary>
    let ResidentialSocialServiceObjectCategory =
        Namespaced_IRI.parse _namespace_name "ResidentialSocialServiceObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RestaurantObjectCategory"></see>
    /// </summary>
    let RestaurantObjectCategory =
        Namespaced_IRI.parse _namespace_name "RestaurantObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RightBottomWCCabinDisposition"></see>
    /// </summary>
    let RightBottomWCCabinDisposition =
        Namespaced_IRI.parse _namespace_name "RightBottomWCCabinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RightTopWCCabinDisposition"></see>
    /// </summary>
    let RightTopWCCabinDisposition =
        Namespaced_IRI.parse _namespace_name "RightTopWCCabinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/RingOnlyBellType"></see>
    /// </summary>
    let RingOnlyBellType =
        Namespaced_IRI.parse _namespace_name "RingOnlyBellType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SchoolObjectCategory"></see>
    /// </summary>
    let SchoolObjectCategory =
        Namespaced_IRI.parse _namespace_name "SchoolObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SelfContainedWCCabinLocalization"></see>
    /// </summary>
    let SelfContainedWCCabinLocalization =
        Namespaced_IRI.parse _namespace_name "SelfContainedWCCabinLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ServiceObjectCategory"></see>
    /// </summary>
    let ServiceObjectCategory =
        Namespaced_IRI.parse _namespace_name "ServiceObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideElevatorCageSecondDoorLocalization"></see>
    /// </summary>
    let SideElevatorCageSecondDoorLocalization =
        Namespaced_IRI.parse _namespace_name "SideElevatorCageSecondDoorLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideEntrance"></see>
    /// </summary>
    let SideEntrance =
        Namespaced_IRI.parse _namespace_name "SideEntrance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideEntryAreaEntry"></see>
    /// </summary>
    let SideEntryAreaEntry =
        Namespaced_IRI.parse _namespace_name "SideEntryAreaEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideWallElevatorCageMirrorLocalization"></see>
    /// </summary>
    let SideWallElevatorCageMirrorLocalization =
        Namespaced_IRI.parse _namespace_name "SideWallElevatorCageMirrorLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideWallHandleLocalization"></see>
    /// </summary>
    let SideWallHandleLocalization =
        Namespaced_IRI.parse _namespace_name "SideWallHandleLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideWallsElevatorCageMirrorLocalization"></see>
    /// </summary>
    let SideWallsElevatorCageMirrorLocalization =
        Namespaced_IRI.parse _namespace_name "SideWallsElevatorCageMirrorLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SideWallsHandleLocalization"></see>
    /// </summary>
    let SideWallsHandleLocalization =
        Namespaced_IRI.parse _namespace_name "SideWallsHandleLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SidesDoorOpeningDirection"></see>
    /// </summary>
    let SidesDoorOpeningDirection =
        Namespaced_IRI.parse _namespace_name "SidesDoorOpeningDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SinglePanelledDoorType"></see>
    /// </summary>
    let SinglePanelledDoorType =
        Namespaced_IRI.parse _namespace_name "SinglePanelledDoorType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Skids"></see>
    /// </summary>
    let Skids = Namespaced_IRI.parse _namespace_name "Skids" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SlidingDoorOpening"></see>
    /// </summary>
    let SlidingDoorOpening =
        Namespaced_IRI.parse _namespace_name "SlidingDoorOpening" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SlipperyRampSurface"></see>
    /// </summary>
    let SlipperyRampSurface =
        Namespaced_IRI.parse _namespace_name "SlipperyRampSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SocialOfficeObjectCategory"></see>
    /// </summary>
    let SocialOfficeObjectCategory =
        Namespaced_IRI.parse _namespace_name "SocialOfficeObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SpaHouseObjectCategory"></see>
    /// </summary>
    let SpaHouseObjectCategory =
        Namespaced_IRI.parse _namespace_name "SpaHouseObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SpiralObjectStairsType"></see>
    /// </summary>
    let SpiralObjectStairsType =
        Namespaced_IRI.parse _namespace_name "SpiralObjectStairsType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SpiralRampType"></see>
    /// </summary>
    let SpiralRampType =
        Namespaced_IRI.parse _namespace_name "SpiralRampType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SportsFacilityObjectCategory"></see>
    /// </summary>
    let SportsFacilityObjectCategory =
        Namespaced_IRI.parse _namespace_name "SportsFacilityObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/StadiumObjectCategory"></see>
    /// </summary>
    let StadiumObjectCategory =
        Namespaced_IRI.parse _namespace_name "StadiumObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/StatelyHomeObjectCategory"></see>
    /// </summary>
    let StatelyHomeObjectCategory =
        Namespaced_IRI.parse _namespace_name "StatelyHomeObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/StoreObjectCategory"></see>
    /// </summary>
    let StoreObjectCategory =
        Namespaced_IRI.parse _namespace_name "StoreObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SubwayStationObjectCategory"></see>
    /// </summary>
    let SubwayStationObjectCategory =
        Namespaced_IRI.parse _namespace_name "SubwayStationObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SufficientWashBasinUnderpass"></see>
    /// </summary>
    let SufficientWashBasinUnderpass =
        Namespaced_IRI.parse _namespace_name "SufficientWashBasinUnderpass" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SupermarketObjectCategory"></see>
    /// </summary>
    let SupermarketObjectCategory =
        Namespaced_IRI.parse _namespace_name "SupermarketObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SwimmingObjectCategory"></see>
    /// </summary>
    let SwimmingObjectCategory =
        Namespaced_IRI.parse _namespace_name "SwimmingObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SwingingDoorOpening"></see>
    /// </summary>
    let SwingingDoorOpening =
        Namespaced_IRI.parse _namespace_name "SwingingDoorOpening" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/SynagogueObjectCategory"></see>
    /// </summary>
    let SynagogueObjectCategory =
        Namespaced_IRI.parse _namespace_name "SynagogueObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Tap"></see>
    /// </summary>
    let Tap = Namespaced_IRI.parse _namespace_name "Tap" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TaxOfficeObjectCategory"></see>
    /// </summary>
    let TaxOfficeObjectCategory =
        Namespaced_IRI.parse _namespace_name "TaxOfficeObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TempleObjectCategory"></see>
    /// </summary>
    let TempleObjectCategory =
        Namespaced_IRI.parse _namespace_name "TempleObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TheatreObjectCategory"></see>
    /// </summary>
    let TheatreObjectCategory =
        Namespaced_IRI.parse _namespace_name "TheatreObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TopContrastMarkingLocalization"></see>
    /// </summary>
    let TopContrastMarkingLocalization =
        Namespaced_IRI.parse _namespace_name "TopContrastMarkingLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TopEntryArea"></see>
    /// </summary>
    let TopEntryArea =
        Namespaced_IRI.parse _namespace_name "TopEntryArea" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TopLeftWCCabinDisposition"></see>
    /// </summary>
    let TopLeftWCCabinDisposition =
        Namespaced_IRI.parse _namespace_name "TopLeftWCCabinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TopRightWCCabinDisposition"></see>
    /// </summary>
    let TopRightWCCabinDisposition =
        Namespaced_IRI.parse _namespace_name "TopRightWCCabinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TouchFreeTap"></see>
    /// </summary>
    let TouchFreeTap =
        Namespaced_IRI.parse _namespace_name "TouchFreeTap" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TouristGuide"></see>
    /// </summary>
    let TouristGuide =
        Namespaced_IRI.parse _namespace_name "TouristGuide" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/Tourniquet"></see>
    /// </summary>
    let Tourniquet = Namespaced_IRI.parse _namespace_name "Tourniquet" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TowerObjectCategory"></see>
    /// </summary>
    let TowerObjectCategory =
        Namespaced_IRI.parse _namespace_name "TowerObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TownhallObjectCategory"></see>
    /// </summary>
    let TownhallObjectCategory =
        Namespaced_IRI.parse _namespace_name "TownhallObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/TrainStationObjectCategory"></see>
    /// </summary>
    let TrainStationObjectCategory =
        Namespaced_IRI.parse _namespace_name "TrainStationObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ValveTap"></see>
    /// </summary>
    let ValveTap = Namespaced_IRI.parse _namespace_name "ValveTap" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/VerticalHandleOrientation"></see>
    /// </summary>
    let VerticalHandleOrientation =
        Namespaced_IRI.parse _namespace_name "VerticalHandleOrientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/VerticalPlatformType"></see>
    /// </summary>
    let VerticalPlatformType =
        Namespaced_IRI.parse _namespace_name "VerticalPlatformType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/VeterinarySurgeryObjectCategory"></see>
    /// </summary>
    let VeterinarySurgeryObjectCategory =
        Namespaced_IRI.parse _namespace_name "VeterinarySurgeryObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ViticultureObjectCategory"></see>
    /// </summary>
    let ViticultureObjectCategory =
        Namespaced_IRI.parse _namespace_name "ViticultureObjectCategory" |> NamespacedName

    /// <summary>
    /// Placement of equipment objects is viewed from the entrance into the room
    /// <see href="http://w3id.org/charta77/jup/WC"></see></summary>
    let WC = Namespaced_IRI.parse _namespace_name "WC" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCBasinLeftHandle"></see>
    /// </summary>
    let WCBasinLeftHandle =
        Namespaced_IRI.parse _namespace_name "WCBasinLeftHandle" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WCBasinRightHandle"></see>
    /// </summary>
    let WCBasinRightHandle =
        Namespaced_IRI.parse _namespace_name "WCBasinRightHandle" |> NamespacedName

    /// <summary>
    /// In case that the WC is accessible through hallways
    /// <see href="http://w3id.org/charta77/jup/WCHallway"></see></summary>
    let WCHallway = Namespaced_IRI.parse _namespace_name "WCHallway" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WashBasin"></see>
    /// </summary>
    let WashBasin = Namespaced_IRI.parse _namespace_name "WashBasin" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WashBasinHandle"></see>
    /// </summary>
    let WashBasinHandle =
        Namespaced_IRI.parse _namespace_name "WashBasinHandle" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WashBasinTap"></see>
    /// </summary>
    let WashBasinTap =
        Namespaced_IRI.parse _namespace_name "WashBasinTap" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WaterParkObjectCategory"></see>
    /// </summary>
    let WaterParkObjectCategory =
        Namespaced_IRI.parse _namespace_name "WaterParkObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WeddingHallObjectCategory"></see>
    /// </summary>
    let WeddingHallObjectCategory =
        Namespaced_IRI.parse _namespace_name "WeddingHallObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WellnessObjectCategory"></see>
    /// </summary>
    let WellnessObjectCategory =
        Namespaced_IRI.parse _namespace_name "WellnessObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/WinterStadiumObjectCategory"></see>
    /// </summary>
    let WinterStadiumObjectCategory =
        Namespaced_IRI.parse _namespace_name "WinterStadiumObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/YesWCSwitch"></see>
    /// </summary>
    let YesWCSwitch =
        Namespaced_IRI.parse _namespace_name "YesWCSwitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ZooObjectCategory"></see>
    /// </summary>
    let ZooObjectCategory =
        Namespaced_IRI.parse _namespace_name "ZooObjectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/access"></see>
    /// </summary>
    let access = Namespaced_IRI.parse _namespace_name "access" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/accessProvidedBy"></see>
    /// </summary>
    let accessProvidedBy =
        Namespaced_IRI.parse _namespace_name "accessProvidedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/accessibility"></see>
    /// </summary>
    let accessibility =
        Namespaced_IRI.parse _namespace_name "accessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/aobAboveDoor"></see>
    /// </summary>
    let aobAboveDoor =
        Namespaced_IRI.parse _namespace_name "aobAboveDoor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/aobAnnouncement"></see>
    /// </summary>
    let aobAnnouncement =
        Namespaced_IRI.parse _namespace_name "aobAnnouncement" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/aobIsAboveDoor"></see>
    /// </summary>
    let aobIsAboveDoor =
        Namespaced_IRI.parse _namespace_name "aobIsAboveDoor" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/aobLocalization"></see>
    /// </summary>
    let aobLocalization =
        Namespaced_IRI.parse _namespace_name "aobLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/localization"></see>
    /// </summary>
    let localization =
        Namespaced_IRI.parse _namespace_name "localization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/bellHeight"></see>
    /// </summary>
    let bellHeight = Namespaced_IRI.parse _namespace_name "bellHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/bellIndentation"></see>
    /// </summary>
    let bellIndentation =
        Namespaced_IRI.parse _namespace_name "bellIndentation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/bellType"></see>
    /// </summary>
    let bellType = Namespaced_IRI.parse _namespace_name "bellType" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/belongsTo"></see>
    /// </summary>
    let belongsTo = Namespaced_IRI.parse _namespace_name "belongsTo" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/brailleLabelled"></see>
    /// </summary>
    let brailleLabelled =
        Namespaced_IRI.parse _namespace_name "brailleLabelled" |> NamespacedName

    /// <summary>
    /// A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.
    /// <see href="http://w3id.org/charta77/jup/certifiedRecord"></see></summary>
    let certifiedRecord =
        Namespaced_IRI.parse _namespace_name "certifiedRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/contrastMarked"></see>
    /// </summary>
    let contrastMarked =
        Namespaced_IRI.parse _namespace_name "contrastMarked" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/contrastMarkingGlassSurfacesMarked"></see>
    /// </summary>
    let contrastMarkingGlassSurfacesMarked =
        Namespaced_IRI.parse _namespace_name "contrastMarkingGlassSurfacesMarked" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/contrastMarkingIsGlassSurfacesMarked"></see>
    /// </summary>
    let contrastMarkingIsGlassSurfacesMarked =
        Namespaced_IRI.parse _namespace_name "contrastMarkingIsGlassSurfacesMarked" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/contrastMarkingLocalization"></see>
    /// </summary>
    let contrastMarkingLocalization =
        Namespaced_IRI.parse _namespace_name "contrastMarkingLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/controlHeight"></see>
    /// </summary>
    let controlHeight =
        Namespaced_IRI.parse _namespace_name "controlHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/createdBy"></see>
    /// </summary>
    let createdBy = Namespaced_IRI.parse _namespace_name "createdBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/createdDate"></see>
    /// </summary>
    let createdDate =
        Namespaced_IRI.parse _namespace_name "createdDate" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorBrailleLabelled"></see>
    /// </summary>
    let doorBrailleLabelled =
        Namespaced_IRI.parse _namespace_name "doorBrailleLabelled" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorIsBrailleLabelled"></see>
    /// </summary>
    let doorIsBrailleLabelled =
        Namespaced_IRI.parse _namespace_name "doorIsBrailleLabelled" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorIsMarked"></see>
    /// </summary>
    let doorIsMarked =
        Namespaced_IRI.parse _namespace_name "doorIsMarked" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorMainPanelWidth"></see>
    /// </summary>
    let doorMainPanelWidth =
        Namespaced_IRI.parse _namespace_name "doorMainPanelWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorMarked"></see>
    /// </summary>
    let doorMarked = Namespaced_IRI.parse _namespace_name "doorMarked" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorOpening"></see>
    /// </summary>
    let doorOpening =
        Namespaced_IRI.parse _namespace_name "doorOpening" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorOpeningDirection"></see>
    /// </summary>
    let doorOpeningDirection =
        Namespaced_IRI.parse _namespace_name "doorOpeningDirection" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorSidePanelWidth"></see>
    /// </summary>
    let doorSidePanelWidth =
        Namespaced_IRI.parse _namespace_name "doorSidePanelWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorStepHeight"></see>
    /// </summary>
    let doorStepHeight =
        Namespaced_IRI.parse _namespace_name "doorStepHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/thresholdHeight"></see>
    /// </summary>
    let thresholdHeight =
        Namespaced_IRI.parse _namespace_name "thresholdHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorType"></see>
    /// </summary>
    let doorType = Namespaced_IRI.parse _namespace_name "doorType" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/doorWidth"></see>
    /// </summary>
    let doorWidth = Namespaced_IRI.parse _namespace_name "doorWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorAccess"></see>
    /// </summary>
    let elevatorAccess =
        Namespaced_IRI.parse _namespace_name "elevatorAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorAccessProvidedBy"></see>
    /// </summary>
    let elevatorAccessProvidedBy =
        Namespaced_IRI.parse _namespace_name "elevatorAccessProvidedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlAnnouncementAcoustic"></see>
    /// </summary>
    let elevatorCageControlAnnouncementAcoustic =
        Namespaced_IRI.parse _namespace_name "elevatorCageControlAnnouncementAcoustic" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlAnnouncementPhonetic"></see>
    /// </summary>
    let elevatorCageControlAnnouncementPhonetic =
        Namespaced_IRI.parse _namespace_name "elevatorCageControlAnnouncementPhonetic" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlBrailleLabelled"></see>
    /// </summary>
    let elevatorCageControlBrailleLabelled =
        Namespaced_IRI.parse _namespace_name "elevatorCageControlBrailleLabelled" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlDistance"></see>
    /// </summary>
    let elevatorCageControlDistance =
        Namespaced_IRI.parse _namespace_name "elevatorCageControlDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlFlatMarking"></see>
    /// </summary>
    let elevatorCageControlFlatMarking =
        Namespaced_IRI.parse _namespace_name "elevatorCageControlFlatMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlHeight"></see>
    /// </summary>
    let elevatorCageControlHeight =
        Namespaced_IRI.parse _namespace_name "elevatorCageControlHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageControlReliefMarking"></see>
    /// </summary>
    let elevatorCageControlReliefMarking =
        Namespaced_IRI.parse _namespace_name "elevatorCageControlReliefMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageDepth"></see>
    /// </summary>
    let elevatorCageDepth =
        Namespaced_IRI.parse _namespace_name "elevatorCageDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageMirrorHeight"></see>
    /// </summary>
    let elevatorCageMirrorHeight =
        Namespaced_IRI.parse _namespace_name "elevatorCageMirrorHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mirrorHeight"></see>
    /// </summary>
    let mirrorHeight =
        Namespaced_IRI.parse _namespace_name "mirrorHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageMirrorInstalled"></see>
    /// </summary>
    let elevatorCageMirrorInstalled =
        Namespaced_IRI.parse _namespace_name "elevatorCageMirrorInstalled" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageMirrorLocalization"></see>
    /// </summary>
    let elevatorCageMirrorLocalization =
        Namespaced_IRI.parse _namespace_name "elevatorCageMirrorLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCagePassthrough"></see>
    /// </summary>
    let elevatorCagePassthrough =
        Namespaced_IRI.parse _namespace_name "elevatorCagePassthrough" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageSeatFunctional"></see>
    /// </summary>
    let elevatorCageSeatFunctional =
        Namespaced_IRI.parse _namespace_name "elevatorCageSeatFunctional" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageSeatInstalled"></see>
    /// </summary>
    let elevatorCageSeatInstalled =
        Namespaced_IRI.parse _namespace_name "elevatorCageSeatInstalled" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageSeatWithinReach"></see>
    /// </summary>
    let elevatorCageSeatWithinReach =
        Namespaced_IRI.parse _namespace_name "elevatorCageSeatWithinReach" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageSecondDoorLocalization"></see>
    /// </summary>
    let elevatorCageSecondDoorLocalization =
        Namespaced_IRI.parse _namespace_name "elevatorCageSecondDoorLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorCageWidth"></see>
    /// </summary>
    let elevatorCageWidth =
        Namespaced_IRI.parse _namespace_name "elevatorCageWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorConnectsFloors"></see>
    /// </summary>
    let elevatorConnectsFloors =
        Namespaced_IRI.parse _namespace_name "elevatorConnectsFloors" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorControlBrailleLabelled"></see>
    /// </summary>
    let elevatorControlBrailleLabelled =
        Namespaced_IRI.parse _namespace_name "elevatorControlBrailleLabelled" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorControlFlatMarking"></see>
    /// </summary>
    let elevatorControlFlatMarking =
        Namespaced_IRI.parse _namespace_name "elevatorControlFlatMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorControlMaxHeight"></see>
    /// </summary>
    let elevatorControlMaxHeight =
        Namespaced_IRI.parse _namespace_name "elevatorControlMaxHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorControlReliefMarking"></see>
    /// </summary>
    let elevatorControlReliefMarking =
        Namespaced_IRI.parse _namespace_name "elevatorControlReliefMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorDriveOff"></see>
    /// </summary>
    let elevatorDriveOff =
        Namespaced_IRI.parse _namespace_name "elevatorDriveOff" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageControlAnnouncementAcoustic"></see>
    /// </summary>
    let elevatorIsCageControlAnnouncementAcoustic =
        Namespaced_IRI.parse _namespace_name "elevatorIsCageControlAnnouncementAcoustic" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageControlAnnouncementPhonetic"></see>
    /// </summary>
    let elevatorIsCageControlAnnouncementPhonetic =
        Namespaced_IRI.parse _namespace_name "elevatorIsCageControlAnnouncementPhonetic" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageControlBrailleMarking"></see>
    /// </summary>
    let elevatorIsCageControlBrailleMarking =
        Namespaced_IRI.parse _namespace_name "elevatorIsCageControlBrailleMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageMirror"></see>
    /// </summary>
    let elevatorIsCageMirror =
        Namespaced_IRI.parse _namespace_name "elevatorIsCageMirror" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCagePassthrough"></see>
    /// </summary>
    let elevatorIsCagePassthrough =
        Namespaced_IRI.parse _namespace_name "elevatorIsCagePassthrough" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageSeat"></see>
    /// </summary>
    let elevatorIsCageSeat =
        Namespaced_IRI.parse _namespace_name "elevatorIsCageSeat" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageSeatFunctional"></see>
    /// </summary>
    let elevatorIsCageSeatFunctional =
        Namespaced_IRI.parse _namespace_name "elevatorIsCageSeatFunctional" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsCageSeatWithinReach"></see>
    /// </summary>
    let elevatorIsCageSeatWithinReach =
        Namespaced_IRI.parse _namespace_name "elevatorIsCageSeatWithinReach" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorIsControlBrailleMarking"></see>
    /// </summary>
    let elevatorIsControlBrailleMarking =
        Namespaced_IRI.parse _namespace_name "elevatorIsControlBrailleMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorLocalization"></see>
    /// </summary>
    let elevatorLocalization =
        Namespaced_IRI.parse _namespace_name "elevatorLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/elevatorType"></see>
    /// </summary>
    let elevatorType =
        Namespaced_IRI.parse _namespace_name "elevatorType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAccess"></see>
    /// </summary>
    let entranceAccess =
        Namespaced_IRI.parse _namespace_name "entranceAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAccessProvidedBy"></see>
    /// </summary>
    let entranceAccessProvidedBy =
        Namespaced_IRI.parse _namespace_name "entranceAccessProvidedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAccessibility"></see>
    /// </summary>
    let entranceAccessibility =
        Namespaced_IRI.parse _namespace_name "entranceAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAreaBeforeDoorDepth"></see>
    /// </summary>
    let entranceAreaBeforeDoorDepth =
        Namespaced_IRI.parse _namespace_name "entranceAreaBeforeDoorDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceAreaBeforeDoorWidth"></see>
    /// </summary>
    let entranceAreaBeforeDoorWidth =
        Namespaced_IRI.parse _namespace_name "entranceAreaBeforeDoorWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceDifficultSurfaceDescription"></see>
    /// </summary>
    let entranceDifficultSurfaceDescription =
        Namespaced_IRI.parse _namespace_name "entranceDifficultSurfaceDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceGuidingLine"></see>
    /// </summary>
    let entranceGuidingLine =
        Namespaced_IRI.parse _namespace_name "entranceGuidingLine" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsDifficultSurface"></see>
    /// </summary>
    let entranceIsDifficultSurface =
        Namespaced_IRI.parse _namespace_name "entranceIsDifficultSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsLongitudinalInclination"></see>
    /// </summary>
    let entranceIsLongitudinalInclination =
        Namespaced_IRI.parse _namespace_name "entranceIsLongitudinalInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsReservedParking"></see>
    /// </summary>
    let entranceIsReservedParking =
        Namespaced_IRI.parse _namespace_name "entranceIsReservedParking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsSideEntranceInformation"></see>
    /// </summary>
    let entranceIsSideEntranceInformation =
        Namespaced_IRI.parse _namespace_name "entranceIsSideEntranceInformation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsSideEntranceMarked"></see>
    /// </summary>
    let entranceIsSideEntranceMarked =
        Namespaced_IRI.parse _namespace_name "entranceIsSideEntranceMarked" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsStepContrastMarked"></see>
    /// </summary>
    let entranceIsStepContrastMarked =
        Namespaced_IRI.parse _namespace_name "entranceIsStepContrastMarked" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceIsTransverseInclination"></see>
    /// </summary>
    let entranceIsTransverseInclination =
        Namespaced_IRI.parse _namespace_name "entranceIsTransverseInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLobbyDepth"></see>
    /// </summary>
    let entranceLobbyDepth =
        Namespaced_IRI.parse _namespace_name "entranceLobbyDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLobbyWidth"></see>
    /// </summary>
    let entranceLobbyWidth =
        Namespaced_IRI.parse _namespace_name "entranceLobbyWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLocalization"></see>
    /// </summary>
    let entranceLocalization =
        Namespaced_IRI.parse _namespace_name "entranceLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLongitudinalInclination"></see>
    /// </summary>
    let entranceLongitudinalInclination =
        Namespaced_IRI.parse _namespace_name "entranceLongitudinalInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceLongitudinalInclinationLocalization"></see>
    /// </summary>
    let entranceLongitudinalInclinationLocalization =
        Namespaced_IRI.parse _namespace_name "entranceLongitudinalInclinationLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceNumberOfReservedParking"></see>
    /// </summary>
    let entranceNumberOfReservedParking =
        Namespaced_IRI.parse _namespace_name "entranceNumberOfReservedParking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceReservedParkingAccessDescription"></see>
    /// </summary>
    let entranceReservedParkingAccessDescription =
        Namespaced_IRI.parse _namespace_name "entranceReservedParkingAccessDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceReservedParkingLocalization"></see>
    /// </summary>
    let entranceReservedParkingLocalization =
        Namespaced_IRI.parse _namespace_name "entranceReservedParkingLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceSideEntranceDescribed"></see>
    /// </summary>
    let entranceSideEntranceDescribed =
        Namespaced_IRI.parse _namespace_name "entranceSideEntranceDescribed" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceTransverseInclination"></see>
    /// </summary>
    let entranceTransverseInclination =
        Namespaced_IRI.parse _namespace_name "entranceTransverseInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entranceTransverseInclinationLocalization"></see>
    /// </summary>
    let entranceTransverseInclinationLocalization =
        Namespaced_IRI.parse _namespace_name "entranceTransverseInclinationLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaDepth"></see>
    /// </summary>
    let entryAreaDepth =
        Namespaced_IRI.parse _namespace_name "entryAreaDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaEntry"></see>
    /// </summary>
    let entryAreaEntry =
        Namespaced_IRI.parse _namespace_name "entryAreaEntry" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaEntryClosing"></see>
    /// </summary>
    let entryAreaEntryClosing =
        Namespaced_IRI.parse _namespace_name "entryAreaEntryClosing" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaEntryWidth"></see>
    /// </summary>
    let entryAreaEntryWidth =
        Namespaced_IRI.parse _namespace_name "entryAreaEntryWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaHeightElevation"></see>
    /// </summary>
    let entryAreaHeightElevation =
        Namespaced_IRI.parse _namespace_name "entryAreaHeightElevation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaIsEntryClosing"></see>
    /// </summary>
    let entryAreaIsEntryClosing =
        Namespaced_IRI.parse _namespace_name "entryAreaIsEntryClosing" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/entryAreaWidth"></see>
    /// </summary>
    let entryAreaWidth =
        Namespaced_IRI.parse _namespace_name "entryAreaWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/formMaps"></see>
    /// </summary>
    let formMaps = Namespaced_IRI.parse _namespace_name "formMaps" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/formType"></see>
    /// </summary>
    let formType = Namespaced_IRI.parse _namespace_name "formType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hallwayDepth"></see>
    /// </summary>
    let hallwayDepth =
        Namespaced_IRI.parse _namespace_name "hallwayDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hallwayWidth"></see>
    /// </summary>
    let hallwayWidth =
        Namespaced_IRI.parse _namespace_name "hallwayWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleHeight"></see>
    /// </summary>
    let handleHeight =
        Namespaced_IRI.parse _namespace_name "handleHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleLength"></see>
    /// </summary>
    let handleLength =
        Namespaced_IRI.parse _namespace_name "handleLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleLocalization"></see>
    /// </summary>
    let handleLocalization =
        Namespaced_IRI.parse _namespace_name "handleLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleOrientation"></see>
    /// </summary>
    let handleOrientation =
        Namespaced_IRI.parse _namespace_name "handleOrientation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handlePosition"></see>
    /// </summary>
    let handlePosition =
        Namespaced_IRI.parse _namespace_name "handlePosition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/handleType"></see>
    /// </summary>
    let handleType = Namespaced_IRI.parse _namespace_name "handleType" |> NamespacedName

    /// <summary>
    /// To complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/hasAttachment"></see></summary>
    let hasAttachment =
        Namespaced_IRI.parse _namespace_name "hasAttachment" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasDescription"></see>
    /// </summary>
    let hasDescription =
        Namespaced_IRI.parse _namespace_name "hasDescription" |> NamespacedName

    /// <summary>
    /// e.g. for IC organizations
    /// <see href="http://w3id.org/charta77/jup/hasIdentifier"></see></summary>
    let hasIdentifier =
        Namespaced_IRI.parse _namespace_name "hasIdentifier" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasLatitude"></see>
    /// </summary>
    let hasLatitude =
        Namespaced_IRI.parse _namespace_name "hasLatitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasLongitude"></see>
    /// </summary>
    let hasLongitude =
        Namespaced_IRI.parse _namespace_name "hasLongitude" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasName"></see>
    /// </summary>
    let hasName = Namespaced_IRI.parse _namespace_name "hasName" |> NamespacedName
    /// <summary>
    /// Adapted WC: poor anchorage of handles, handle attached to side wall,...
    /// <see href="http://w3id.org/charta77/jup/hasNotes"></see></summary>
    let hasNotes = Namespaced_IRI.parse _namespace_name "hasNotes" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/hasPart"></see>
    /// </summary>
    let hasPart = Namespaced_IRI.parse _namespace_name "hasPart" |> NamespacedName
    /// <summary>
    /// http://ruian.linked.opendata.cz/
    /// <see href="http://w3id.org/charta77/jup/hasPlace"></see></summary>
    let hasPlace = Namespaced_IRI.parse _namespace_name "hasPlace" |> NamespacedName
    /// <summary>
    /// Short and formated description summarizing form data, understandable to the wide public
    /// <see href="http://w3id.org/charta77/jup/hasSummary"></see></summary>
    let hasSummary = Namespaced_IRI.parse _namespace_name "hasSummary" |> NamespacedName

    /// <summary>
    /// A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.
    /// <see href="http://w3id.org/charta77/jup/isCertifiedRecord"></see></summary>
    let isCertifiedRecord =
        Namespaced_IRI.parse _namespace_name "isCertifiedRecord" |> NamespacedName

    /// <summary>
    /// Older entries describing the same mappable entity are assigned the false value.
    /// <see href="http://w3id.org/charta77/jup/isUpToDateRecord"></see></summary>
    let isUpToDateRecord =
        Namespaced_IRI.parse _namespace_name "isUpToDateRecord" |> NamespacedName

    /// <summary>
    /// To complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/license"></see></summary>
    let license = Namespaced_IRI.parse _namespace_name "license" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityAccess"></see>
    /// </summary>
    let mappableEntityAccess =
        Namespaced_IRI.parse _namespace_name "mappableEntityAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityAccessProvidedBy"></see>
    /// </summary>
    let mappableEntityAccessProvidedBy =
        Namespaced_IRI.parse _namespace_name "mappableEntityAccessProvidedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityAccessibility"></see>
    /// </summary>
    let mappableEntityAccessibility =
        Namespaced_IRI.parse _namespace_name "mappableEntityAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityControlHeight"></see>
    /// </summary>
    let mappableEntityControlHeight =
        Namespaced_IRI.parse _namespace_name "mappableEntityControlHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityIsBrailleMarking"></see>
    /// </summary>
    let mappableEntityIsBrailleMarking =
        Namespaced_IRI.parse _namespace_name "mappableEntityIsBrailleMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityIsContrastMarking"></see>
    /// </summary>
    let mappableEntityIsContrastMarking =
        Namespaced_IRI.parse _namespace_name "mappableEntityIsContrastMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityLocalization"></see>
    /// </summary>
    let mappableEntityLocalization =
        Namespaced_IRI.parse _namespace_name "mappableEntityLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityMirrorHeight"></see>
    /// </summary>
    let mappableEntityMirrorHeight =
        Namespaced_IRI.parse _namespace_name "mappableEntityMirrorHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityPassageWidth"></see>
    /// </summary>
    let mappableEntityPassageWidth =
        Namespaced_IRI.parse _namespace_name "mappableEntityPassageWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntitySeatHeight"></see>
    /// </summary>
    let mappableEntitySeatHeight =
        Namespaced_IRI.parse _namespace_name "mappableEntitySeatHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntitySwitchHeight"></see>
    /// </summary>
    let mappableEntitySwitchHeight =
        Namespaced_IRI.parse _namespace_name "mappableEntitySwitchHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mappableEntityThresholdHeight"></see>
    /// </summary>
    let mappableEntityThresholdHeight =
        Namespaced_IRI.parse _namespace_name "mappableEntityThresholdHeight" |> NamespacedName

    /// <summary>
    /// A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.
    /// <see href="http://w3id.org/charta77/jup/mapperCertified"></see></summary>
    let mapperCertified =
        Namespaced_IRI.parse _namespace_name "mapperCertified" |> NamespacedName

    /// <summary>
    /// A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.
    /// <see href="http://w3id.org/charta77/jup/mapperIsCertified"></see></summary>
    let mapperIsCertified =
        Namespaced_IRI.parse _namespace_name "mapperIsCertified" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/mapperNick"></see>
    /// </summary>
    let mapperNick = Namespaced_IRI.parse _namespace_name "mapperNick" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/narrowedPassageWidth"></see>
    /// </summary>
    let narrowedPassageWidth =
        Namespaced_IRI.parse _namespace_name "narrowedPassageWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/passageWidth"></see>
    /// </summary>
    let passageWidth =
        Namespaced_IRI.parse _namespace_name "passageWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/navigationSystemDescription"></see>
    /// </summary>
    let navigationSystemDescription =
        Namespaced_IRI.parse _namespace_name "navigationSystemDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectAccessibilityMKPO"></see>
    /// </summary>
    let objectAccessibilityMKPO =
        Namespaced_IRI.parse _namespace_name "objectAccessibilityMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectCategory"></see>
    /// </summary>
    let objectCategory =
        Namespaced_IRI.parse _namespace_name "objectCategory" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectInteriorAccessibility"></see>
    /// </summary>
    let objectInteriorAccessibility =
        Namespaced_IRI.parse _namespace_name "objectInteriorAccessibility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectIsNarrowedPassage"></see>
    /// </summary>
    let objectIsNarrowedPassage =
        Namespaced_IRI.parse _namespace_name "objectIsNarrowedPassage" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectIsNavigationSystem"></see>
    /// </summary>
    let objectIsNavigationSystem =
        Namespaced_IRI.parse _namespace_name "objectIsNavigationSystem" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectIsStairs"></see>
    /// </summary>
    let objectIsStairs =
        Namespaced_IRI.parse _namespace_name "objectIsStairs" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectIsTourniquet"></see>
    /// </summary>
    let objectIsTourniquet =
        Namespaced_IRI.parse _namespace_name "objectIsTourniquet" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectNarrowedPassageLocalization"></see>
    /// </summary>
    let objectNarrowedPassageLocalization =
        Namespaced_IRI.parse _namespace_name "objectNarrowedPassageLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectNarrowedPassageWidth"></see>
    /// </summary>
    let objectNarrowedPassageWidth =
        Namespaced_IRI.parse _namespace_name "objectNarrowedPassageWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectNavigationSystemDescription"></see>
    /// </summary>
    let objectNavigationSystemDescription =
        Namespaced_IRI.parse _namespace_name "objectNavigationSystemDescription" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectStairsIsBannister"></see>
    /// </summary>
    let objectStairsIsBannister =
        Namespaced_IRI.parse _namespace_name "objectStairsIsBannister" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectStairsType"></see>
    /// </summary>
    let objectStairsType =
        Namespaced_IRI.parse _namespace_name "objectStairsType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/ObjectStairsType"></see>
    /// </summary>
    let ObjectStairsType =
        Namespaced_IRI.parse _namespace_name "ObjectStairsType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectStairsWidth"></see>
    /// </summary>
    let objectStairsWidth =
        Namespaced_IRI.parse _namespace_name "objectStairsWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/objectTourniquetLocalization"></see>
    /// </summary>
    let objectTourniquetLocalization =
        Namespaced_IRI.parse _namespace_name "objectTourniquetLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/partOf"></see>
    /// </summary>
    let partOf = Namespaced_IRI.parse _namespace_name "partOf" |> NamespacedName

    /// <summary>
    /// Access enabled by attendants if the platform is locked
    /// <see href="http://w3id.org/charta77/jup/platformAccess"></see></summary>
    let platformAccess =
        Namespaced_IRI.parse _namespace_name "platformAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformDepth"></see>
    /// </summary>
    let platformDepth =
        Namespaced_IRI.parse _namespace_name "platformDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformInsideControlHeight"></see>
    /// </summary>
    let platformInsideControlHeight =
        Namespaced_IRI.parse _namespace_name "platformInsideControlHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformIsMinParameters"></see>
    /// </summary>
    let platformIsMinParameters =
        Namespaced_IRI.parse _namespace_name "platformIsMinParameters" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformLocalization"></see>
    /// </summary>
    let platformLocalization =
        Namespaced_IRI.parse _namespace_name "platformLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformMaxLoad"></see>
    /// </summary>
    let platformMaxLoad =
        Namespaced_IRI.parse _namespace_name "platformMaxLoad" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformMinParameters"></see>
    /// </summary>
    let platformMinParameters =
        Namespaced_IRI.parse _namespace_name "platformMinParameters" |> NamespacedName

    /// <summary>
    /// Elevation difference surmounted by platform
    /// <see href="http://w3id.org/charta77/jup/platformNumberOfFloors"></see></summary>
    let platformNumberOfFloors =
        Namespaced_IRI.parse _namespace_name "platformNumberOfFloors" |> NamespacedName

    /// <summary>
    /// Elevation difference surmounted by platform
    /// <see href="http://w3id.org/charta77/jup/platformNumberOfSteps"></see></summary>
    let platformNumberOfSteps =
        Namespaced_IRI.parse _namespace_name "platformNumberOfSteps" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformOutsideBottomControlHeight"></see>
    /// </summary>
    let platformOutsideBottomControlHeight =
        Namespaced_IRI.parse _namespace_name "platformOutsideBottomControlHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformOutsideTopControlHeight"></see>
    /// </summary>
    let platformOutsideTopControlHeight =
        Namespaced_IRI.parse _namespace_name "platformOutsideTopControlHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformType"></see>
    /// </summary>
    let platformType =
        Namespaced_IRI.parse _namespace_name "platformType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/platformWidth"></see>
    /// </summary>
    let platformWidth =
        Namespaced_IRI.parse _namespace_name "platformWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampAccessProvidedBy"></see>
    /// </summary>
    let rampAccessProvidedBy =
        Namespaced_IRI.parse _namespace_name "rampAccessProvidedBy" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampLegInclination"></see>
    /// </summary>
    let rampLegInclination =
        Namespaced_IRI.parse _namespace_name "rampLegInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampLegLength"></see>
    /// </summary>
    let rampLegLength =
        Namespaced_IRI.parse _namespace_name "rampLegLength" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampLegWidth"></see>
    /// </summary>
    let rampLegWidth =
        Namespaced_IRI.parse _namespace_name "rampLegWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampNumberOfLegs"></see>
    /// </summary>
    let rampNumberOfLegs =
        Namespaced_IRI.parse _namespace_name "rampNumberOfLegs" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampSkidsInteriorLocalization"></see>
    /// </summary>
    let rampSkidsInteriorLocalization =
        Namespaced_IRI.parse _namespace_name "rampSkidsInteriorLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampSkidsLocalization"></see>
    /// </summary>
    let rampSkidsLocalization =
        Namespaced_IRI.parse _namespace_name "rampSkidsLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampSkidsMobility"></see>
    /// </summary>
    let rampSkidsMobility =
        Namespaced_IRI.parse _namespace_name "rampSkidsMobility" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampSurface"></see>
    /// </summary>
    let rampSurface =
        Namespaced_IRI.parse _namespace_name "rampSurface" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/rampType"></see>
    /// </summary>
    let rampType = Namespaced_IRI.parse _namespace_name "rampType" |> NamespacedName
    /// <summary>
    /// To complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/sameAs"></see></summary>
    let sameAs = Namespaced_IRI.parse _namespace_name "sameAs" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/seatHeight"></see>
    /// </summary>
    let seatHeight = Namespaced_IRI.parse _namespace_name "seatHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/skidsInclination"></see>
    /// </summary>
    let skidsInclination =
        Namespaced_IRI.parse _namespace_name "skidsInclination" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/skidsLength"></see>
    /// </summary>
    let skidsLength =
        Namespaced_IRI.parse _namespace_name "skidsLength" |> NamespacedName

    /// <summary>
    /// To complete the vocabulary
    /// <see href="http://w3id.org/charta77/jup/source"></see></summary>
    let source = Namespaced_IRI.parse _namespace_name "source" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsContrastMarked"></see>
    /// </summary>
    let stepsContrastMarked =
        Namespaced_IRI.parse _namespace_name "stepsContrastMarked" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsDepth"></see>
    /// </summary>
    let stepsDepth = Namespaced_IRI.parse _namespace_name "stepsDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsHeight"></see>
    /// </summary>
    let stepsHeight =
        Namespaced_IRI.parse _namespace_name "stepsHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsIsContrastMarked"></see>
    /// </summary>
    let stepsIsContrastMarked =
        Namespaced_IRI.parse _namespace_name "stepsIsContrastMarked" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsLocalization"></see>
    /// </summary>
    let stepsLocalization =
        Namespaced_IRI.parse _namespace_name "stepsLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsNumberOf"></see>
    /// </summary>
    let stepsNumberOf =
        Namespaced_IRI.parse _namespace_name "stepsNumberOf" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsType"></see>
    /// </summary>
    let stepsType = Namespaced_IRI.parse _namespace_name "stepsType" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/stepsWidth"></see>
    /// </summary>
    let stepsWidth = Namespaced_IRI.parse _namespace_name "stepsWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/switchHeight"></see>
    /// </summary>
    let switchHeight =
        Namespaced_IRI.parse _namespace_name "switchHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/tapHeight"></see>
    /// </summary>
    let tapHeight = Namespaced_IRI.parse _namespace_name "tapHeight" |> NamespacedName
    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/tapType"></see>
    /// </summary>
    let tapType = Namespaced_IRI.parse _namespace_name "tapType" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/tourniquetLocalization"></see>
    /// </summary>
    let tourniquetLocalization =
        Namespaced_IRI.parse _namespace_name "tourniquetLocalization" |> NamespacedName

    /// <summary>
    /// Older entries describing the same mappable entity are assigned the false value.
    /// <see href="http://w3id.org/charta77/jup/upToDateRecord"></see></summary>
    let upToDateRecord =
        Namespaced_IRI.parse _namespace_name "upToDateRecord" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/washBasinHeight"></see>
    /// </summary>
    let washBasinHeight =
        Namespaced_IRI.parse _namespace_name "washBasinHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/washBasinUnderpass"></see>
    /// </summary>
    let washBasinUnderpass =
        Namespaced_IRI.parse _namespace_name "washBasinUnderpass" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcAccessibilityMKPO"></see>
    /// </summary>
    let wcAccessibilityMKPO =
        Namespaced_IRI.parse _namespace_name "wcAccessibilityMKPO" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcAlarmButtonBottomHeight"></see>
    /// </summary>
    let wcAlarmButtonBottomHeight =
        Namespaced_IRI.parse _namespace_name "wcAlarmButtonBottomHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcAlarmButtonInstalled"></see>
    /// </summary>
    let wcAlarmButtonInstalled =
        Namespaced_IRI.parse _namespace_name "wcAlarmButtonInstalled" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcAlarmButtonTopHeight"></see>
    /// </summary>
    let wcAlarmButtonTopHeight =
        Namespaced_IRI.parse _namespace_name "wcAlarmButtonTopHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinBackIndentation"></see>
    /// </summary>
    let wcBasinBackIndentation =
        Namespaced_IRI.parse _namespace_name "wcBasinBackIndentation" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinIsPaperReach"></see>
    /// </summary>
    let wcBasinIsPaperReach =
        Namespaced_IRI.parse _namespace_name "wcBasinIsPaperReach" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinLeftDistance"></see>
    /// </summary>
    let wcBasinLeftDistance =
        Namespaced_IRI.parse _namespace_name "wcBasinLeftDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinPaperWithinReach"></see>
    /// </summary>
    let wcBasinPaperWithinReach =
        Namespaced_IRI.parse _namespace_name "wcBasinPaperWithinReach" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinRightDistance"></see>
    /// </summary>
    let wcBasinRightDistance =
        Namespaced_IRI.parse _namespace_name "wcBasinRightDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinSeatHeight"></see>
    /// </summary>
    let wcBasinSeatHeight =
        Namespaced_IRI.parse _namespace_name "wcBasinSeatHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcBasinSpace"></see>
    /// </summary>
    let wcBasinSpace =
        Namespaced_IRI.parse _namespace_name "wcBasinSpace" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinAccess"></see>
    /// </summary>
    let wcCabinAccess =
        Namespaced_IRI.parse _namespace_name "wcCabinAccess" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinDepth"></see>
    /// </summary>
    let wcCabinDepth =
        Namespaced_IRI.parse _namespace_name "wcCabinDepth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinDoorDisposition"></see>
    /// </summary>
    let wcCabinDoorDisposition =
        Namespaced_IRI.parse _namespace_name "wcCabinDoorDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinLocalization"></see>
    /// </summary>
    let wcCabinLocalization =
        Namespaced_IRI.parse _namespace_name "wcCabinLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinWCBasinDisposition"></see>
    /// </summary>
    let wcCabinWCBasinDisposition =
        Namespaced_IRI.parse _namespace_name "wcCabinWCBasinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinWashBasinDisposition"></see>
    /// </summary>
    let wcCabinWashBasinDisposition =
        Namespaced_IRI.parse _namespace_name "wcCabinWashBasinDisposition" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcCabinWidth"></see>
    /// </summary>
    let wcCabinWidth =
        Namespaced_IRI.parse _namespace_name "wcCabinWidth" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcChangingDesk"></see>
    /// </summary>
    let wcChangingDesk =
        Namespaced_IRI.parse _namespace_name "wcChangingDesk" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcChangingDeskInstalled"></see>
    /// </summary>
    let wcChangingDeskInstalled =
        Namespaced_IRI.parse _namespace_name "wcChangingDeskInstalled" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcChangingDeskObstructs"></see>
    /// </summary>
    let wcChangingDeskObstructs =
        Namespaced_IRI.parse _namespace_name "wcChangingDeskObstructs" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushing"></see>
    /// </summary>
    let wcFlushing = Namespaced_IRI.parse _namespace_name "wcFlushing" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushingBackHeight"></see>
    /// </summary>
    let wcFlushingBackHeight =
        Namespaced_IRI.parse _namespace_name "wcFlushingBackHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushingDifficulty"></see>
    /// </summary>
    let wcFlushingDifficulty =
        Namespaced_IRI.parse _namespace_name "wcFlushingDifficulty" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushingSideDistance"></see>
    /// </summary>
    let wcFlushingSideDistance =
        Namespaced_IRI.parse _namespace_name "wcFlushingSideDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcFlushingSideHeight"></see>
    /// </summary>
    let wcFlushingSideHeight =
        Namespaced_IRI.parse _namespace_name "wcFlushingSideHeight" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcHandlesDistance"></see>
    /// </summary>
    let wcHandlesDistance =
        Namespaced_IRI.parse _namespace_name "wcHandlesDistance" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsAlarmButton"></see>
    /// </summary>
    let wcIsAlarmButton =
        Namespaced_IRI.parse _namespace_name "wcIsAlarmButton" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsChangingDesk"></see>
    /// </summary>
    let wcIsChangingDesk =
        Namespaced_IRI.parse _namespace_name "wcIsChangingDesk" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsChangingDeskObstructs"></see>
    /// </summary>
    let wcIsChangingDeskObstructs =
        Namespaced_IRI.parse _namespace_name "wcIsChangingDeskObstructs" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsRegularWC"></see>
    /// </summary>
    let wcIsRegularWC =
        Namespaced_IRI.parse _namespace_name "wcIsRegularWC" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcIsRegularWCBrailleMarking"></see>
    /// </summary>
    let wcIsRegularWCBrailleMarking =
        Namespaced_IRI.parse _namespace_name "wcIsRegularWCBrailleMarking" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcLocalization"></see>
    /// </summary>
    let wcLocalization =
        Namespaced_IRI.parse _namespace_name "wcLocalization" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcRegularWC"></see>
    /// </summary>
    let wcRegularWC =
        Namespaced_IRI.parse _namespace_name "wcRegularWC" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcRegularWCBrailleLabelled"></see>
    /// </summary>
    let wcRegularWCBrailleLabelled =
        Namespaced_IRI.parse _namespace_name "wcRegularWCBrailleLabelled" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcSwitch"></see>
    /// </summary>
    let wcSwitch = Namespaced_IRI.parse _namespace_name "wcSwitch" |> NamespacedName

    /// <summary>
    ///   <see href="http://w3id.org/charta77/jup/wcSwitchHeight"></see>
    /// </summary>
    let wcSwitchHeight =
        Namespaced_IRI.parse _namespace_name "wcSwitchHeight" |> NamespacedName
