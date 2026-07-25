namespace http.w3id.org.charta77.jup.slash

open DoxAletheia
open DotNetRDFSharp
open type Prefix_ID

module jup =
    let _namespace_iri = Namespace_Iri jup |> NamespaceIRI
    /// <summary>
    ///   <para>jup:ElevatorMKPOForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:MappableEntityForm</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorMKPOForm">http://w3id.org/charta77/jup/ElevatorMKPOForm</seealso>
    let ElevatorMKPOForm = Prefixed_Name(jup, "ElevatorMKPOForm") |> PrefixedName
    /// <summary>
    ///   <para>jup:ObjectMKPOForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:MappableEntityForm</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ObjectMKPOForm">http://w3id.org/charta77/jup/ObjectMKPOForm</seealso>
    let ObjectMKPOForm = Prefixed_Name(jup, "ObjectMKPOForm") |> PrefixedName
    /// <summary>
    ///   <para>jup:PhysicalEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Physical entity</para><para>Fyzicka entita</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PhysicalEntity">http://w3id.org/charta77/jup/PhysicalEntity</seealso>
    let PhysicalEntity = Prefixed_Name(jup, "PhysicalEntity") |> PrefixedName

    /// <summary>
    ///   <para>jup:AOBAnnouncementsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Type of AOB announcements scheme</para><para>Schema typu hlaseni AOB</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AOBAnnouncementsScheme">http://w3id.org/charta77/jup/AOBAnnouncementsScheme</seealso>
    let AOBAnnouncementsScheme =
        Prefixed_Name(jup, "AOBAnnouncementsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:FortObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FortObjectCategory">http://w3id.org/charta77/jup/FortObjectCategory</seealso>
    let FortObjectCategory = Prefixed_Name(jup, "FortObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SideElevatorCageSecondDoorLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ElevatorCageSecondDoorLocalization</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SideElevatorCageSecondDoorLocalization">http://w3id.org/charta77/jup/SideElevatorCageSecondDoorLocalization</seealso>
    let SideElevatorCageSecondDoorLocalization =
        Prefixed_Name(jup, "SideElevatorCageSecondDoorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:SideWallHandleLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:HandleLocalization</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SideWallHandleLocalization">http://w3id.org/charta77/jup/SideWallHandleLocalization</seealso>
    let SideWallHandleLocalization =
        Prefixed_Name(jup, "SideWallHandleLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:SinglePanelledDoorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:DoorType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SinglePanelledDoorType">http://w3id.org/charta77/jup/SinglePanelledDoorType</seealso>
    let SinglePanelledDoorType =
        Prefixed_Name(jup, "SinglePanelledDoorType") |> PrefixedName

    /// <summary>
    ///   <para>jup:Skids</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Liziny</para><para>Skids</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Skids">http://w3id.org/charta77/jup/Skids</seealso>
    let Skids = Prefixed_Name(jup, "Skids") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceReservedParkingLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Lokalizace vyhrazeneho parkovaciho stani</para><para>Reserved parking places localization</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceReservedParkingLocalization">http://w3id.org/charta77/jup/entranceReservedParkingLocalization</seealso>
    let entranceReservedParkingLocalization =
        Prefixed_Name(jup, "entranceReservedParkingLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceTransverseInclinationLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Transverse inclination localization: (access communication, area before the entrance)</para><para>Lokalizace pricneho sklonu (pristupova komunikace, prostor pred vstupem,...)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceTransverseInclinationLocalization">http://w3id.org/charta77/jup/entranceTransverseInclinationLocalization</seealso>
    let entranceTransverseInclinationLocalization =
        Prefixed_Name(jup, "entranceTransverseInclinationLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:entryAreaEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vstup na nastuni plochu</para><para>Entry to entry aree</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entryAreaEntry">http://w3id.org/charta77/jup/entryAreaEntry</seealso>
    let entryAreaEntry = Prefixed_Name(jup, "entryAreaEntry") |> PrefixedName

    /// <summary>
    ///   <para>jup:entryAreaHeightElevation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Height elevation difference between platform floor and entry area in cm</para><para>Vyska prevyseni mezi podlahou klece/plosiny a nastupistem v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entryAreaHeightElevation">http://w3id.org/charta77/jup/entryAreaHeightElevation</seealso>
    let entryAreaHeightElevation =
        Prefixed_Name(jup, "entryAreaHeightElevation") |> PrefixedName

    /// <summary>
    ///   <para>jup:formMaps</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>entita, kterou formular mapuje</para><para>entity mapped by the form</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/formMaps">http://w3id.org/charta77/jup/formMaps</seealso>
    let formMaps = Prefixed_Name(jup, "formMaps") |> PrefixedName
    /// <summary>
    ///   <para>jup:formType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Typ formulare mapujici entitu</para><para>Type of form mapping entity</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/formType">http://w3id.org/charta77/jup/formType</seealso>
    let formType = Prefixed_Name(jup, "formType") |> PrefixedName
    /// <summary>
    ///   <para>jup:hallwayWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Width of hallway in cm</para><para>Sirka predsine v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hallwayWidth">http://w3id.org/charta77/jup/hallwayWidth</seealso>
    let hallwayWidth = Prefixed_Name(jup, "hallwayWidth") |> PrefixedName
    /// <summary>
    ///   <para>jup:handleHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska umisteni madla v cm</para><para>Height of handle in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/handleHeight">http://w3id.org/charta77/jup/handleHeight</seealso>
    let handleHeight = Prefixed_Name(jup, "handleHeight") |> PrefixedName
    /// <summary>
    ///   <para>jup:handleLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Length of handle in cm</para><para>Delka madla v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/handleLength">http://w3id.org/charta77/jup/handleLength</seealso>
    let handleLength = Prefixed_Name(jup, "handleLength") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCCategorizationMKPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Three degree evaluation system for bathroom accessibility based on Object Accessibility Categorization Methodology</para><para>Tristupnovy system ohodnoceni pristupnosti toalet dle Metodiky Kategorizace Pristupnosti Objektu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCCategorizationMKPO">http://w3id.org/charta77/jup/WCCategorizationMKPO</seealso>
    let WCCategorizationMKPO =
        Prefixed_Name(jup, "WCCategorizationMKPO") |> PrefixedName

    /// <summary>
    ///   <para>jup:AdministrativeOfficeObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AdministrativeOfficeObjectCategory">http://w3id.org/charta77/jup/AdministrativeOfficeObjectCategory</seealso>
    let AdministrativeOfficeObjectCategory =
        Prefixed_Name(jup, "AdministrativeOfficeObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:MechanicalDoorOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:DoorOpening</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MechanicalDoorOpening">http://w3id.org/charta77/jup/MechanicalDoorOpening</seealso>
    let MechanicalDoorOpening =
        Prefixed_Name(jup, "MechanicalDoorOpening") |> PrefixedName

    /// <summary>
    ///   <para>jup:MetropolitanPoliceObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MetropolitanPoliceObjectCategory">http://w3id.org/charta77/jup/MetropolitanPoliceObjectCategory</seealso>
    let MetropolitanPoliceObjectCategory =
        Prefixed_Name(jup, "MetropolitanPoliceObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:MissingEntranceGuidingLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:EntranceGuidingLine</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MissingEntranceGuidingLine">http://w3id.org/charta77/jup/MissingEntranceGuidingLine</seealso>
    let MissingEntranceGuidingLine =
        Prefixed_Name(jup, "MissingEntranceGuidingLine") |> PrefixedName

    /// <summary>
    ///   <para>jup:MissingHandlePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:HandlePosition</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MissingHandlePosition">http://w3id.org/charta77/jup/MissingHandlePosition</seealso>
    let MissingHandlePosition =
        Prefixed_Name(jup, "MissingHandlePosition") |> PrefixedName

    /// <summary>
    ///   <para>jup:hasForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///
    /// labels<para>Entita je popsana formularem</para><para>Entity described by a form</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasForm">http://w3id.org/charta77/jup/hasForm</seealso>
    let hasForm = Prefixed_Name(jup, "hasForm") |> PrefixedName
    /// <summary>
    ///   <para>jup:AOBAnnouncement</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Types of AOB announcements</para><para>Typy hlaseni AOB</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AOBAnnouncement">http://w3id.org/charta77/jup/AOBAnnouncement</seealso>
    let AOBAnnouncement = Prefixed_Name(jup, "AOBAnnouncement") |> PrefixedName
    /// <summary>
    ///   <para>jup:RampLeg</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Rameno rampy</para><para>Ramp leg</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampLeg">http://w3id.org/charta77/jup/RampLeg</seealso>
    let RampLeg = Prefixed_Name(jup, "RampLeg") |> PrefixedName

    /// <summary>
    ///   <para>jup:RecreationalFacilityObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RecreationalFacilityObjectCategory">http://w3id.org/charta77/jup/RecreationalFacilityObjectCategory</seealso>
    let RecreationalFacilityObjectCategory =
        Prefixed_Name(jup, "RecreationalFacilityObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:ResidentialSocialServiceObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ResidentialSocialServiceObjectCategory">http://w3id.org/charta77/jup/ResidentialSocialServiceObjectCategory</seealso>
    let ResidentialSocialServiceObjectCategory =
        Prefixed_Name(jup, "ResidentialSocialServiceObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:RestaurantObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RestaurantObjectCategory">http://w3id.org/charta77/jup/RestaurantObjectCategory</seealso>
    let RestaurantObjectCategory =
        Prefixed_Name(jup, "RestaurantObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:RightBottomWCCabinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCCabinDisposition</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RightBottomWCCabinDisposition">http://w3id.org/charta77/jup/RightBottomWCCabinDisposition</seealso>
    let RightBottomWCCabinDisposition =
        Prefixed_Name(jup, "RightBottomWCCabinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:RingOnlyBellType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:BellType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RingOnlyBellType">http://w3id.org/charta77/jup/RingOnlyBellType</seealso>
    let RingOnlyBellType = Prefixed_Name(jup, "RingOnlyBellType") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcBasinSeatHeight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Vyska umisteni sedatka v cm</para><para>Height of seat in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcBasinSeatHeight">http://w3id.org/charta77/jup/wcBasinSeatHeight</seealso>
    let wcBasinSeatHeight = Prefixed_Name(jup, "wcBasinSeatHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:CollegeObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/CollegeObjectCategory">http://w3id.org/charta77/jup/CollegeObjectCategory</seealso>
    let CollegeObjectCategory =
        Prefixed_Name(jup, "CollegeObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:ContactSocialServiceObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ContactSocialServiceObjectCategory">http://w3id.org/charta77/jup/ContactSocialServiceObjectCategory</seealso>
    let ContactSocialServiceObjectCategory =
        Prefixed_Name(jup, "ContactSocialServiceObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCMKPOForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:MappableEntityForm</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCMKPOForm">http://w3id.org/charta77/jup/WCMKPOForm</seealso>
    let WCMKPOForm = Prefixed_Name(jup, "WCMKPOForm") |> PrefixedName
    /// <summary>
    ///   <para>jup:LevelTap</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:TapType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LevelTap">http://w3id.org/charta77/jup/LevelTap</seealso>
    let LevelTap = Prefixed_Name(jup, "LevelTap") |> PrefixedName

    /// <summary>
    ///   <para>jup:ViticultureObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ViticultureObjectCategory">http://w3id.org/charta77/jup/ViticultureObjectCategory</seealso>
    let ViticultureObjectCategory =
        Prefixed_Name(jup, "ViticultureObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectInteriorAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Accessibility of interior</para><para>Pristupnost interieru</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectInteriorAccessibility">http://w3id.org/charta77/jup/objectInteriorAccessibility</seealso>
    let objectInteriorAccessibility =
        Prefixed_Name(jup, "objectInteriorAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:AOB</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Akusticky orientacni majacek</para><para>Acoustic orientation beacon</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AOB">http://w3id.org/charta77/jup/AOB</seealso>
    let AOB = Prefixed_Name(jup, "AOB") |> PrefixedName

    /// <summary>
    ///   <para>jup:AccessibleObjectMKPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategorizationMKPO</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AccessibleObjectMKPO">http://w3id.org/charta77/jup/AccessibleObjectMKPO</seealso>
    let AccessibleObjectMKPO =
        Prefixed_Name(jup, "AccessibleObjectMKPO") |> PrefixedName

    /// <summary>
    ///   <para>jup:ObjectCategorizationMKPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Three degree evaluation system for object accessibility based on Object Accessibility Categorization Methodology</para><para>Tristupnovy system ohodnoceni pristupnosti objektu dle Metodiky Kategorizace Pristupnosti Objektu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ObjectCategorizationMKPO">http://w3id.org/charta77/jup/ObjectCategorizationMKPO</seealso>
    let ObjectCategorizationMKPO =
        Prefixed_Name(jup, "ObjectCategorizationMKPO") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Types of elevators</para><para>Typy vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorType">http://w3id.org/charta77/jup/ElevatorType</seealso>
    let ElevatorType = Prefixed_Name(jup, "ElevatorType") |> PrefixedName
    /// <summary>
    ///   <para>jup:ElevatorTypesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Type of elevators scheme</para><para>Schema typu vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorTypesScheme">http://w3id.org/charta77/jup/ElevatorTypesScheme</seealso>
    let ElevatorTypesScheme = Prefixed_Name(jup, "ElevatorTypesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:HandleOrientationsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Orientation of handles scheme</para><para>Schema orientace madla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HandleOrientationsScheme">http://w3id.org/charta77/jup/HandleOrientationsScheme</seealso>
    let HandleOrientationsScheme =
        Prefixed_Name(jup, "HandleOrientationsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:HandlePositionsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Position of handles scheme</para><para>Schema pozic madla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HandlePositionsScheme">http://w3id.org/charta77/jup/HandlePositionsScheme</seealso>
    let HandlePositionsScheme =
        Prefixed_Name(jup, "HandlePositionsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:TouchFreeTap</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:TapType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TouchFreeTap">http://w3id.org/charta77/jup/TouchFreeTap</seealso>
    let TouchFreeTap = Prefixed_Name(jup, "TouchFreeTap") |> PrefixedName
    /// <summary>
    ///   <para>jup:seeAlso</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:AnnotationProperty</para>
    ///   <para>Definovano z duvodu uplnosti slovniku</para>
    ///   <para>Defined to complete the vocabulary</para>
    /// labels<para>Entity information source reference</para><para>Odkaz na zdroj informaci o entite</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/seeAlso">http://w3id.org/charta77/jup/seeAlso</seealso>
    let seeAlso = Prefixed_Name(jup, "seeAlso") |> PrefixedName
    /// <summary>
    ///   <para>jup:Object</para>
    /// </summary>
    /// <remarks>
    ///   <para>Objektem nemusi byt pouze cela budova, ale take jen jeji urcita logicka cast (napr. jeden obchod v multifunkcnim dome). Na jedne adrese tak muze byt vice objektu. </para>
    ///   <para>An object may not be represented by an entire building, it can stand for its particular logic part (e.g. one department store in a multifunctional building). One address can thus comprise multiple objects.</para>
    /// labels<para>Mapovany objekt</para><para>Mapped object</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Object">http://w3id.org/charta77/jup/Object</seealso>
    let Object = Prefixed_Name(jup, "Object") |> PrefixedName

    /// <summary>
    ///   <para>jup:contrastMarkingIsGlassSurfacesMarked</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Glass surfaces (glass lower than 80 cm above floor level)</para><para>Prosklene plochy (proskleni nize nez 80 cm nad podlahu)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/contrastMarkingIsGlassSurfacesMarked">http://w3id.org/charta77/jup/contrastMarkingIsGlassSurfacesMarked</seealso>
    let contrastMarkingIsGlassSurfacesMarked =
        Prefixed_Name(jup, "contrastMarkingIsGlassSurfacesMarked") |> PrefixedName

    /// <summary>
    ///   <para>jup:ObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Building categorization</para><para>Kategorizace budov</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ObjectCategory">http://w3id.org/charta77/jup/ObjectCategory</seealso>
    let ObjectCategory = Prefixed_Name(jup, "ObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:ArtificialEntranceGuidingLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:EntranceGuidingLine</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ArtificialEntranceGuidingLine">http://w3id.org/charta77/jup/ArtificialEntranceGuidingLine</seealso>
    let ArtificialEntranceGuidingLine =
        Prefixed_Name(jup, "ArtificialEntranceGuidingLine") |> PrefixedName

    /// <summary>
    ///   <para>jup:EntranceGuidingLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Typy vodicich linii</para><para>Guiding line types</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntranceGuidingLine">http://w3id.org/charta77/jup/EntranceGuidingLine</seealso>
    let EntranceGuidingLine = Prefixed_Name(jup, "EntranceGuidingLine") |> PrefixedName

    /// <summary>
    ///   <para>jup:DoublePanelledDoorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:DoorType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DoublePanelledDoorType">http://w3id.org/charta77/jup/DoublePanelledDoorType</seealso>
    let DoublePanelledDoorType =
        Prefixed_Name(jup, "DoublePanelledDoorType") |> PrefixedName

    /// <summary>
    ///   <para>jup:Elevator</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Elevator</para><para>Vytah</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Elevator">http://w3id.org/charta77/jup/Elevator</seealso>
    let Elevator = Prefixed_Name(jup, "Elevator") |> PrefixedName
    /// <summary>
    ///   <para>jup:ElevatorCageDoor</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Elevator cage door</para><para>Dvere klece vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorCageDoor">http://w3id.org/charta77/jup/ElevatorCageDoor</seealso>
    let ElevatorCageDoor = Prefixed_Name(jup, "ElevatorCageDoor") |> PrefixedName
    /// <summary>
    ///   <para>jup:Handle</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Handle</para><para>Madlo</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Handle">http://w3id.org/charta77/jup/Handle</seealso>
    let Handle = Prefixed_Name(jup, "Handle") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorCageMirrorLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Types of elevator cage mirror localizations</para><para>Typy umisteni zrcadla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorCageMirrorLocalization">http://w3id.org/charta77/jup/ElevatorCageMirrorLocalization</seealso>
    let ElevatorCageMirrorLocalization =
        Prefixed_Name(jup, "ElevatorCageMirrorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:doorStepHeight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Height of doorstep in cm</para><para>Vyska prahu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorStepHeight">http://w3id.org/charta77/jup/doorStepHeight</seealso>
    let doorStepHeight = Prefixed_Name(jup, "doorStepHeight") |> PrefixedName
    /// <summary>
    ///   <para>jup:thresholdHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Threshold height in cm</para><para>Vyska prahu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/thresholdHeight">http://w3id.org/charta77/jup/thresholdHeight</seealso>
    let thresholdHeight = Prefixed_Name(jup, "thresholdHeight") |> PrefixedName
    /// <summary>
    ///   <para>jup:doorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Type of door</para><para>Typ dveri</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorType">http://w3id.org/charta77/jup/doorType</seealso>
    let doorType = Prefixed_Name(jup, "doorType") |> PrefixedName
    /// <summary>
    ///   <para>jup:elevatorAccess</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Access to elevator</para><para>Pristup k vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorAccess">http://w3id.org/charta77/jup/elevatorAccess</seealso>
    let elevatorAccess = Prefixed_Name(jup, "elevatorAccess") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageControlAnnouncementAcoustic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Acoustic announcement of control inside the cage</para><para>Akusticke hlaseni ovladace uvnitr klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageControlAnnouncementAcoustic">http://w3id.org/charta77/jup/elevatorCageControlAnnouncementAcoustic</seealso>
    let elevatorCageControlAnnouncementAcoustic =
        Prefixed_Name(jup, "elevatorCageControlAnnouncementAcoustic") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageControlBrailleLabelled</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Braille relief marking of control inside the cage</para><para>Oznaceni ovladace uvnitr klece Braillovym pismem</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageControlBrailleLabelled">http://w3id.org/charta77/jup/elevatorCageControlBrailleLabelled</seealso>
    let elevatorCageControlBrailleLabelled =
        Prefixed_Name(jup, "elevatorCageControlBrailleLabelled") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageControlFlatMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Typ plocheho oznaceni ovladace ovladace uvnitr klece</para><para>Type of flat marking of control inside the cage</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageControlFlatMarking">http://w3id.org/charta77/jup/elevatorCageControlFlatMarking</seealso>
    let elevatorCageControlFlatMarking =
        Prefixed_Name(jup, "elevatorCageControlFlatMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageControlReliefMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Type of relief marking of control inside the cage</para><para>Typ reliefu oznaceni ovladace uvnitr klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageControlReliefMarking">http://w3id.org/charta77/jup/elevatorCageControlReliefMarking</seealso>
    let elevatorCageControlReliefMarking =
        Prefixed_Name(jup, "elevatorCageControlReliefMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageMirrorHeight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Vyska umisteni spodni hrany zrcadla v cm</para><para>Height of bottom side of mirror in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageMirrorHeight">http://w3id.org/charta77/jup/elevatorCageMirrorHeight</seealso>
    let elevatorCageMirrorHeight =
        Prefixed_Name(jup, "elevatorCageMirrorHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageMirrorLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Mirror localization</para><para>Umisteni zrcadla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageMirrorLocalization">http://w3id.org/charta77/jup/elevatorCageMirrorLocalization</seealso>
    let elevatorCageMirrorLocalization =
        Prefixed_Name(jup, "elevatorCageMirrorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCagePassthrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Pass-through elevator cage</para><para>Pruchozi klec vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCagePassthrough">http://w3id.org/charta77/jup/elevatorCagePassthrough</seealso>
    let elevatorCagePassthrough =
        Prefixed_Name(jup, "elevatorCagePassthrough") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageSeatFunctional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Sedatko je funkcni ve vsech polohach</para><para>Seat is functional in all positions</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageSeatFunctional">http://w3id.org/charta77/jup/elevatorCageSeatFunctional</seealso>
    let elevatorCageSeatFunctional =
        Prefixed_Name(jup, "elevatorCageSeatFunctional") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageSeatWithinReach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Control within reach of seat</para><para>Ovladani v dosahu sedatka</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageSeatWithinReach">http://w3id.org/charta77/jup/elevatorCageSeatWithinReach</seealso>
    let elevatorCageSeatWithinReach =
        Prefixed_Name(jup, "elevatorCageSeatWithinReach") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageSecondDoorLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Localization of elevator cage second door</para><para>Umisteni druhych dveri pruchozi klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageSecondDoorLocalization">http://w3id.org/charta77/jup/elevatorCageSecondDoorLocalization</seealso>
    let elevatorCageSecondDoorLocalization =
        Prefixed_Name(jup, "elevatorCageSecondDoorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Width of elevator cage in cm</para><para>Sirka klece vytahu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageWidth">http://w3id.org/charta77/jup/elevatorCageWidth</seealso>
    let elevatorCageWidth = Prefixed_Name(jup, "elevatorCageWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorConnectsFloors</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Elevator connects floors</para><para>Vytah spojuje patra</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorConnectsFloors">http://w3id.org/charta77/jup/elevatorConnectsFloors</seealso>
    let elevatorConnectsFloors =
        Prefixed_Name(jup, "elevatorConnectsFloors") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorControlBrailleLabelled</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Oznaceni ovladace na nastupnich mistech Braillovym pismem</para><para>Braille marking of controls at places of entry</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorControlBrailleLabelled">http://w3id.org/charta77/jup/elevatorControlBrailleLabelled</seealso>
    let elevatorControlBrailleLabelled =
        Prefixed_Name(jup, "elevatorControlBrailleLabelled") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorControlFlatMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Typ plocheho oznaceni ovladace na nastupnich mistech</para><para>Type of flat marking of controls at places of entry</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorControlFlatMarking">http://w3id.org/charta77/jup/elevatorControlFlatMarking</seealso>
    let elevatorControlFlatMarking =
        Prefixed_Name(jup, "elevatorControlFlatMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorControlReliefMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Type of relief marking of controls at places of entry</para><para>Typ reliefu oznaceni ovladace na nastupnich mistech</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorControlReliefMarking">http://w3id.org/charta77/jup/elevatorControlReliefMarking</seealso>
    let elevatorControlReliefMarking =
        Prefixed_Name(jup, "elevatorControlReliefMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorDriveOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Dojezd vytahu na hlavnich podestach nebo v mezipatrech</para><para>Elevator drive-off at main landings or at mezzanines</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorDriveOff">http://w3id.org/charta77/jup/elevatorDriveOff</seealso>
    let elevatorDriveOff = Prefixed_Name(jup, "elevatorDriveOff") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorIsCageControlAnnouncementAcoustic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Acoustic announcement of control inside the cage</para><para>Akusticke hlaseni ovladace uvnitr klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorIsCageControlAnnouncementAcoustic">http://w3id.org/charta77/jup/elevatorIsCageControlAnnouncementAcoustic</seealso>
    let elevatorIsCageControlAnnouncementAcoustic =
        Prefixed_Name(jup, "elevatorIsCageControlAnnouncementAcoustic") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorIsCageControlAnnouncementPhonetic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Phonetic announcement of control inside the cage</para><para>Foneticke hlaseni ovladace uvnitr klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorIsCageControlAnnouncementPhonetic">http://w3id.org/charta77/jup/elevatorIsCageControlAnnouncementPhonetic</seealso>
    let elevatorIsCageControlAnnouncementPhonetic =
        Prefixed_Name(jup, "elevatorIsCageControlAnnouncementPhonetic") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorIsCageControlBrailleMarking</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Braille relief marking of control inside the cage</para><para>Oznaceni ovladace uvnitr klece Braillovym pismem</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorIsCageControlBrailleMarking">http://w3id.org/charta77/jup/elevatorIsCageControlBrailleMarking</seealso>
    let elevatorIsCageControlBrailleMarking =
        Prefixed_Name(jup, "elevatorIsCageControlBrailleMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorIsCageMirror</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Mirror inside the cage</para><para>Zrcadlo uvnitr klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorIsCageMirror">http://w3id.org/charta77/jup/elevatorIsCageMirror</seealso>
    let elevatorIsCageMirror =
        Prefixed_Name(jup, "elevatorIsCageMirror") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorIsCagePassthrough</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Pass-through elevator cage</para><para>Pruchozi klec vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorIsCagePassthrough">http://w3id.org/charta77/jup/elevatorIsCagePassthrough</seealso>
    let elevatorIsCagePassthrough =
        Prefixed_Name(jup, "elevatorIsCagePassthrough") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorIsCageSeat</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Sedatko uvnitr klece</para><para>Seat inside the cage</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorIsCageSeat">http://w3id.org/charta77/jup/elevatorIsCageSeat</seealso>
    let elevatorIsCageSeat = Prefixed_Name(jup, "elevatorIsCageSeat") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorIsCageSeatFunctional</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Sedatko je funkcni ve vsech polohach</para><para>Seat is functional in all positions</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorIsCageSeatFunctional">http://w3id.org/charta77/jup/elevatorIsCageSeatFunctional</seealso>
    let elevatorIsCageSeatFunctional =
        Prefixed_Name(jup, "elevatorIsCageSeatFunctional") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorIsCageSeatWithinReach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Control within reach of seat</para><para>Ovladani v dosahu sedatka</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorIsCageSeatWithinReach">http://w3id.org/charta77/jup/elevatorIsCageSeatWithinReach</seealso>
    let elevatorIsCageSeatWithinReach =
        Prefixed_Name(jup, "elevatorIsCageSeatWithinReach") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorIsControlBrailleMarking</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Oznaceni ovladace na nastupnich mistech Braillovym pismem</para><para>Braille marking of controls at places of entry</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorIsControlBrailleMarking">http://w3id.org/charta77/jup/elevatorIsControlBrailleMarking</seealso>
    let elevatorIsControlBrailleMarking =
        Prefixed_Name(jup, "elevatorIsControlBrailleMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorLocalization</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Localization of elevator</para><para>Lokalizace vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorLocalization">http://w3id.org/charta77/jup/elevatorLocalization</seealso>
    let elevatorLocalization =
        Prefixed_Name(jup, "elevatorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:StepsStairsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Typy schodiste</para><para>Stair types</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/StepsStairsType">http://w3id.org/charta77/jup/StepsStairsType</seealso>
    let StepsStairsType = Prefixed_Name(jup, "StepsStairsType") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectNarrowedPassageLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Narrowed passage localization</para><para>Lokalizace zuzeneho pruchodu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectNarrowedPassageLocalization">http://w3id.org/charta77/jup/objectNarrowedPassageLocalization</seealso>
    let objectNarrowedPassageLocalization =
        Prefixed_Name(jup, "objectNarrowedPassageLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:MappableEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Mapovatelna entita</para><para>Mappable entity</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MappableEntity">http://w3id.org/charta77/jup/MappableEntity</seealso>
    let MappableEntity = Prefixed_Name(jup, "MappableEntity") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityControlHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Control placement height in cm</para><para>Vyska umisteni ovladace v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityControlHeight">http://w3id.org/charta77/jup/mappableEntityControlHeight</seealso>
    let mappableEntityControlHeight =
        Prefixed_Name(jup, "mappableEntityControlHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:Hallway</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Predsin</para><para>Hallway</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Hallway">http://w3id.org/charta77/jup/Hallway</seealso>
    let Hallway = Prefixed_Name(jup, "Hallway") |> PrefixedName
    /// <summary>
    ///   <para>jup:HandleOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Orientation of handels</para><para>Orientace madel</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HandleOrientation">http://w3id.org/charta77/jup/HandleOrientation</seealso>
    let HandleOrientation = Prefixed_Name(jup, "HandleOrientation") |> PrefixedName
    /// <summary>
    ///   <para>jup:HandlePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Positions of handels</para><para>Pozice madel</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HandlePosition">http://w3id.org/charta77/jup/HandlePosition</seealso>
    let HandlePosition = Prefixed_Name(jup, "HandlePosition") |> PrefixedName

    /// <summary>
    ///   <para>jup:HarborObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HarborObjectCategory">http://w3id.org/charta77/jup/HarborObjectCategory</seealso>
    let HarborObjectCategory =
        Prefixed_Name(jup, "HarborObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:HealthCenterObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HealthCenterObjectCategory">http://w3id.org/charta77/jup/HealthCenterObjectCategory</seealso>
    let HealthCenterObjectCategory =
        Prefixed_Name(jup, "HealthCenterObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:HighSchoolObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HighSchoolObjectCategory">http://w3id.org/charta77/jup/HighSchoolObjectCategory</seealso>
    let HighSchoolObjectCategory =
        Prefixed_Name(jup, "HighSchoolObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:HorizontalHandleOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:HandleOrientation</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HorizontalHandleOrientation">http://w3id.org/charta77/jup/HorizontalHandleOrientation</seealso>
    let HorizontalHandleOrientation =
        Prefixed_Name(jup, "HorizontalHandleOrientation") |> PrefixedName

    /// <summary>
    ///   <para>jup:HotelObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HotelObjectCategory">http://w3id.org/charta77/jup/HotelObjectCategory</seealso>
    let HotelObjectCategory = Prefixed_Name(jup, "HotelObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:InaccessibleObjectMKPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategorizationMKPO</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InaccessibleObjectMKPO">http://w3id.org/charta77/jup/InaccessibleObjectMKPO</seealso>
    let InaccessibleObjectMKPO =
        Prefixed_Name(jup, "InaccessibleObjectMKPO") |> PrefixedName

    /// <summary>
    ///   <para>jup:PlatformType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    /// labels<para>Types of platforms</para><para>Typy plosiny</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PlatformType">http://w3id.org/charta77/jup/PlatformType</seealso>
    let PlatformType = Prefixed_Name(jup, "PlatformType") |> PrefixedName
    /// <summary>
    ///   <para>jup:PlatformTypesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Type of platforms scheme</para><para>Schema typu plosiny</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PlatformTypesScheme">http://w3id.org/charta77/jup/PlatformTypesScheme</seealso>
    let PlatformTypesScheme = Prefixed_Name(jup, "PlatformTypesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:InsideHandlePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:HandlePosition</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InsideHandlePosition">http://w3id.org/charta77/jup/InsideHandlePosition</seealso>
    let InsideHandlePosition =
        Prefixed_Name(jup, "InsideHandlePosition") |> PrefixedName

    /// <summary>
    ///   <para>jup:InsuranceOfficeObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InsuranceOfficeObjectCategory">http://w3id.org/charta77/jup/InsuranceOfficeObjectCategory</seealso>
    let InsuranceOfficeObjectCategory =
        Prefixed_Name(jup, "InsuranceOfficeObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:InteriorStairs</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Stairs inside the interior</para><para>Schodiste v interieru</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InteriorStairs">http://w3id.org/charta77/jup/InteriorStairs</seealso>
    let InteriorStairs = Prefixed_Name(jup, "InteriorStairs") |> PrefixedName

    /// <summary>
    ///   <para>jup:JingleAOBAnnouncement</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:AOBAnnouncement</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/JingleAOBAnnouncement">http://w3id.org/charta77/jup/JingleAOBAnnouncement</seealso>
    let JingleAOBAnnouncement =
        Prefixed_Name(jup, "JingleAOBAnnouncement") |> PrefixedName

    /// <summary>
    ///   <para>jup:KindergartenObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/KindergartenObjectCategory">http://w3id.org/charta77/jup/KindergartenObjectCategory</seealso>
    let KindergartenObjectCategory =
        Prefixed_Name(jup, "KindergartenObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:LadiesWCCabinLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCCabinLocalization</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LadiesWCCabinLocalization">http://w3id.org/charta77/jup/LadiesWCCabinLocalization</seealso>
    let LadiesWCCabinLocalization =
        Prefixed_Name(jup, "LadiesWCCabinLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:LandingsEntryArea</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Landings</para><para>Podesta</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LandingsEntryArea">http://w3id.org/charta77/jup/LandingsEntryArea</seealso>
    let LandingsEntryArea = Prefixed_Name(jup, "LandingsEntryArea") |> PrefixedName

    /// <summary>
    ///   <para>jup:LeftBottomWCCabinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCCabinDisposition</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LeftBottomWCCabinDisposition">http://w3id.org/charta77/jup/LeftBottomWCCabinDisposition</seealso>
    let LeftBottomWCCabinDisposition =
        Prefixed_Name(jup, "LeftBottomWCCabinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:LibraryObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LibraryObjectCategory">http://w3id.org/charta77/jup/LibraryObjectCategory</seealso>
    let LibraryObjectCategory =
        Prefixed_Name(jup, "LibraryObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:LobbyDoor</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Dvere zadveri</para><para>Lobby door</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LobbyDoor">http://w3id.org/charta77/jup/LobbyDoor</seealso>
    let LobbyDoor = Prefixed_Name(jup, "LobbyDoor") |> PrefixedName
    /// <summary>
    ///   <para>jup:LobbySteps</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Schody v zadveri</para><para>Steps in lobby</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LobbySteps">http://w3id.org/charta77/jup/LobbySteps</seealso>
    let LobbySteps = Prefixed_Name(jup, "LobbySteps") |> PrefixedName

    /// <summary>
    ///   <para>jup:LockedMappableEntityAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:MappableEntityAccess</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LockedMappableEntityAccess">http://w3id.org/charta77/jup/LockedMappableEntityAccess</seealso>
    let LockedMappableEntityAccess =
        Prefixed_Name(jup, "LockedMappableEntityAccess") |> PrefixedName

    /// <summary>
    ///   <para>jup:LoretoObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LoretoObjectCategory">http://w3id.org/charta77/jup/LoretoObjectCategory</seealso>
    let LoretoObjectCategory =
        Prefixed_Name(jup, "LoretoObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:Mapper</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Person mapping object accessibility</para><para>Osoba mapujici pristupnost objektu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Mapper">http://w3id.org/charta77/jup/Mapper</seealso>
    let Mapper = Prefixed_Name(jup, "Mapper") |> PrefixedName

    /// <summary>
    ///   <para>jup:MechanicalWCFlushing</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCFlushing</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MechanicalWCFlushing">http://w3id.org/charta77/jup/MechanicalWCFlushing</seealso>
    let MechanicalWCFlushing =
        Prefixed_Name(jup, "MechanicalWCFlushing") |> PrefixedName

    /// <summary>
    ///   <para>jup:MedicalEmergencyObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MedicalEmergencyObjectCategory">http://w3id.org/charta77/jup/MedicalEmergencyObjectCategory</seealso>
    let MedicalEmergencyObjectCategory =
        Prefixed_Name(jup, "MedicalEmergencyObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:MedicalSupplyObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MedicalSupplyObjectCategory">http://w3id.org/charta77/jup/MedicalSupplyObjectCategory</seealso>
    let MedicalSupplyObjectCategory =
        Prefixed_Name(jup, "MedicalSupplyObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:MezzaninesElevatorDriveOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ElevatorDriveOff</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MezzaninesElevatorDriveOff">http://w3id.org/charta77/jup/MezzaninesElevatorDriveOff</seealso>
    let MezzaninesElevatorDriveOff =
        Prefixed_Name(jup, "MezzaninesElevatorDriveOff") |> PrefixedName

    /// <summary>
    ///   <para>jup:MissingBellType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:BellType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MissingBellType">http://w3id.org/charta77/jup/MissingBellType</seealso>
    let MissingBellType = Prefixed_Name(jup, "MissingBellType") |> PrefixedName

    /// <summary>
    ///   <para>jup:MissingContrastMarkingLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ContrastMarkingLocalization</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MissingContrastMarkingLocalization">http://w3id.org/charta77/jup/MissingContrastMarkingLocalization</seealso>
    let MissingContrastMarkingLocalization =
        Prefixed_Name(jup, "MissingContrastMarkingLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:MissingWCSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCSwitch</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MissingWCSwitch">http://w3id.org/charta77/jup/MissingWCSwitch</seealso>
    let MissingWCSwitch = Prefixed_Name(jup, "MissingWCSwitch") |> PrefixedName

    /// <summary>
    ///   <para>jup:MobileRampSkidsMobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:RampSkidsMobility</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MobileRampSkidsMobility">http://w3id.org/charta77/jup/MobileRampSkidsMobility</seealso>
    let MobileRampSkidsMobility =
        Prefixed_Name(jup, "MobileRampSkidsMobility") |> PrefixedName

    /// <summary>
    ///   <para>jup:MobileWCChangingDesk</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCChangingDesk</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MobileWCChangingDesk">http://w3id.org/charta77/jup/MobileWCChangingDesk</seealso>
    let MobileWCChangingDesk =
        Prefixed_Name(jup, "MobileWCChangingDesk") |> PrefixedName

    /// <summary>
    ///   <para>jup:MonasteryObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MonasteryObjectCategory">http://w3id.org/charta77/jup/MonasteryObjectCategory</seealso>
    let MonasteryObjectCategory =
        Prefixed_Name(jup, "MonasteryObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:MonumentObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MonumentObjectCategory">http://w3id.org/charta77/jup/MonumentObjectCategory</seealso>
    let MonumentObjectCategory =
        Prefixed_Name(jup, "MonumentObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:MoreStepsEntranceAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:EntranceAccessibility</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MoreStepsEntranceAccessibility">http://w3id.org/charta77/jup/MoreStepsEntranceAccessibility</seealso>
    let MoreStepsEntranceAccessibility =
        Prefixed_Name(jup, "MoreStepsEntranceAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:MunicipalOfficeObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MunicipalOfficeObjectCategory">http://w3id.org/charta77/jup/MunicipalOfficeObjectCategory</seealso>
    let MunicipalOfficeObjectCategory =
        Prefixed_Name(jup, "MunicipalOfficeObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:MunicipalityObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MunicipalityObjectCategory">http://w3id.org/charta77/jup/MunicipalityObjectCategory</seealso>
    let MunicipalityObjectCategory =
        Prefixed_Name(jup, "MunicipalityObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:MuseumObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MuseumObjectCategory">http://w3id.org/charta77/jup/MuseumObjectCategory</seealso>
    let MuseumObjectCategory =
        Prefixed_Name(jup, "MuseumObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:NarrowedPassage</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Narrowed passage (less than 80 cm)</para><para>Zuzeny pruchod (mene nez 800mm)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/NarrowedPassage">http://w3id.org/charta77/jup/NarrowedPassage</seealso>
    let NarrowedPassage = Prefixed_Name(jup, "NarrowedPassage") |> PrefixedName

    /// <summary>
    ///   <para>jup:NaturalEntranceGuidingLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:EntranceGuidingLine</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/NaturalEntranceGuidingLine">http://w3id.org/charta77/jup/NaturalEntranceGuidingLine</seealso>
    let NaturalEntranceGuidingLine =
        Prefixed_Name(jup, "NaturalEntranceGuidingLine") |> PrefixedName

    /// <summary>
    ///   <para>jup:NoElevationEntranceAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:EntranceAccessibility</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/NoElevationEntranceAccessibility">http://w3id.org/charta77/jup/NoElevationEntranceAccessibility</seealso>
    let NoElevationEntranceAccessibility =
        Prefixed_Name(jup, "NoElevationEntranceAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:NonslipperyRampSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:RampSurface</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/NonslipperyRampSurface">http://w3id.org/charta77/jup/NonslipperyRampSurface</seealso>
    let NonslipperyRampSurface =
        Prefixed_Name(jup, "NonslipperyRampSurface") |> PrefixedName

    /// <summary>
    ///   <para>jup:RampSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Types of ramp surfaces</para><para>Typy povrchu rampy</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampSurface">http://w3id.org/charta77/jup/RampSurface</seealso>
    let RampSurface = Prefixed_Name(jup, "RampSurface") |> PrefixedName
    /// <summary>
    ///   <para>jup:RampSurfacesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    /// labels<para>Type of ramp surfaces scheme</para><para>Schema typu povrchu rampy</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampSurfacesScheme">http://w3id.org/charta77/jup/RampSurfacesScheme</seealso>
    let RampSurfacesScheme = Prefixed_Name(jup, "RampSurfacesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:NotConnectingObjectStairsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:StepsStairsType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/NotConnectingObjectStairsType">http://w3id.org/charta77/jup/NotConnectingObjectStairsType</seealso>
    let NotConnectingObjectStairsType =
        Prefixed_Name(jup, "NotConnectingObjectStairsType") |> PrefixedName

    /// <summary>
    ///   <para>jup:OKWCFlushingDifficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCFlushingDifficulty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/OKWCFlushingDifficulty">http://w3id.org/charta77/jup/OKWCFlushingDifficulty</seealso>
    let OKWCFlushingDifficulty =
        Prefixed_Name(jup, "OKWCFlushingDifficulty") |> PrefixedName

    /// <summary>
    ///   <para>jup:ObservatoryObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ObservatoryObjectCategory">http://w3id.org/charta77/jup/ObservatoryObjectCategory</seealso>
    let ObservatoryObjectCategory =
        Prefixed_Name(jup, "ObservatoryObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:OneSideDoorOpeningDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:DoorOpeningDirection</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/OneSideDoorOpeningDirection">http://w3id.org/charta77/jup/OneSideDoorOpeningDirection</seealso>
    let OneSideDoorOpeningDirection =
        Prefixed_Name(jup, "OneSideDoorOpeningDirection") |> PrefixedName

    /// <summary>
    ///   <para>jup:OneStepEntranceAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:EntranceAccessibility</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/OneStepEntranceAccessibility">http://w3id.org/charta77/jup/OneStepEntranceAccessibility</seealso>
    let OneStepEntranceAccessibility =
        Prefixed_Name(jup, "OneStepEntranceAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:OpticianShopObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/OpticianShopObjectCategory">http://w3id.org/charta77/jup/OpticianShopObjectCategory</seealso>
    let OpticianShopObjectCategory =
        Prefixed_Name(jup, "OpticianShopObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:Organization</para>
    /// </summary>
    /// <remarks>
    ///   <para>napr. Sprava prazskeho hradu</para>
    ///   <para>e.g. Prague Castle Administration</para>
    /// labels<para>Organization</para><para>Organizace</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Organization">http://w3id.org/charta77/jup/Organization</seealso>
    let Organization = Prefixed_Name(jup, "Organization") |> PrefixedName

    /// <summary>
    ///   <para>jup:OtheroObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/OtheroObjectCategory">http://w3id.org/charta77/jup/OtheroObjectCategory</seealso>
    let OtheroObjectCategory =
        Prefixed_Name(jup, "OtheroObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:OutsideHandlePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:HandlePosition</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/OutsideHandlePosition">http://w3id.org/charta77/jup/OutsideHandlePosition</seealso>
    let OutsideHandlePosition =
        Prefixed_Name(jup, "OutsideHandlePosition") |> PrefixedName

    /// <summary>
    ///   <para>jup:OutwardsDoorOpeningDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:DoorOpeningDirection</para>
    ///   <para>to the exterior of the cabine</para>
    ///   <para>z kabiny</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/OutwardsDoorOpeningDirection">http://w3id.org/charta77/jup/OutwardsDoorOpeningDirection</seealso>
    let OutwardsDoorOpeningDirection =
        Prefixed_Name(jup, "OutwardsDoorOpeningDirection") |> PrefixedName

    /// <summary>
    ///   <para>jup:PalaceObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PalaceObjectCategory">http://w3id.org/charta77/jup/PalaceObjectCategory</seealso>
    let PalaceObjectCategory =
        Prefixed_Name(jup, "PalaceObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:PartObjectInteriorAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectInteriorAccessibility</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PartObjectInteriorAccessibility">http://w3id.org/charta77/jup/PartObjectInteriorAccessibility</seealso>
    let PartObjectInteriorAccessibility =
        Prefixed_Name(jup, "PartObjectInteriorAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:PartlyAccessibleObjectMKPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategorizationMKPO</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PartlyAccessibleObjectMKPO">http://w3id.org/charta77/jup/PartlyAccessibleObjectMKPO</seealso>
    let PartlyAccessibleObjectMKPO =
        Prefixed_Name(jup, "PartlyAccessibleObjectMKPO") |> PrefixedName

    /// <summary>
    ///   <para>jup:PartlyAccessibleWCMKPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCCategorizationMKPO</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PartlyAccessibleWCMKPO">http://w3id.org/charta77/jup/PartlyAccessibleWCMKPO</seealso>
    let PartlyAccessibleWCMKPO =
        Prefixed_Name(jup, "PartlyAccessibleWCMKPO") |> PrefixedName

    /// <summary>
    ///   <para>jup:PastryObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PastryObjectCategory">http://w3id.org/charta77/jup/PastryObjectCategory</seealso>
    let PastryObjectCategory =
        Prefixed_Name(jup, "PastryObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:PersonalElevatorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ElevatorType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PersonalElevatorType">http://w3id.org/charta77/jup/PersonalElevatorType</seealso>
    let PersonalElevatorType =
        Prefixed_Name(jup, "PersonalElevatorType") |> PrefixedName

    /// <summary>
    ///   <para>jup:PharmacyObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PharmacyObjectCategory">http://w3id.org/charta77/jup/PharmacyObjectCategory</seealso>
    let PharmacyObjectCategory =
        Prefixed_Name(jup, "PharmacyObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:PhraseAOBAnnouncement</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:AOBAnnouncement</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PhraseAOBAnnouncement">http://w3id.org/charta77/jup/PhraseAOBAnnouncement</seealso>
    let PhraseAOBAnnouncement =
        Prefixed_Name(jup, "PhraseAOBAnnouncement") |> PrefixedName

    /// <summary>
    ///   <para>jup:Platform</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Platform</para><para>Plosina</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Platform">http://w3id.org/charta77/jup/Platform</seealso>
    let Platform = Prefixed_Name(jup, "Platform") |> PrefixedName

    /// <summary>
    ///   <para>jup:PlatformEntranceAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:EntranceAccessibility</para>
    ///   <para>skos:Concept</para>
    ///   <para>Appendix 2</para>
    ///   <para>Priloha c.2</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PlatformEntranceAccessibility">http://w3id.org/charta77/jup/PlatformEntranceAccessibility</seealso>
    let PlatformEntranceAccessibility =
        Prefixed_Name(jup, "PlatformEntranceAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:PoliceObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PoliceObjectCategory">http://w3id.org/charta77/jup/PoliceObjectCategory</seealso>
    let PoliceObjectCategory =
        Prefixed_Name(jup, "PoliceObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:PostOfficeObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PostOfficeObjectCategory">http://w3id.org/charta77/jup/PostOfficeObjectCategory</seealso>
    let PostOfficeObjectCategory =
        Prefixed_Name(jup, "PostOfficeObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:ProtrudingElevatorControlReliefMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ElevatorControlReliefMarking</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ProtrudingElevatorControlReliefMarking">http://w3id.org/charta77/jup/ProtrudingElevatorControlReliefMarking</seealso>
    let ProtrudingElevatorControlReliefMarking =
        Prefixed_Name(jup, "ProtrudingElevatorControlReliefMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:PubObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PubObjectCategory">http://w3id.org/charta77/jup/PubObjectCategory</seealso>
    let PubObjectCategory = Prefixed_Name(jup, "PubObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:PublicProsecutorObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PublicProsecutorObjectCategory">http://w3id.org/charta77/jup/PublicProsecutorObjectCategory</seealso>
    let PublicProsecutorObjectCategory =
        Prefixed_Name(jup, "PublicProsecutorObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:PublicToiletObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PublicToiletObjectCategory">http://w3id.org/charta77/jup/PublicToiletObjectCategory</seealso>
    let PublicToiletObjectCategory =
        Prefixed_Name(jup, "PublicToiletObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:Ramp</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Rampa</para><para>Ramp</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Ramp">http://w3id.org/charta77/jup/Ramp</seealso>
    let Ramp = Prefixed_Name(jup, "Ramp") |> PrefixedName
    /// <summary>
    ///   <para>jup:RampSkids</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Rampa / Liziny</para><para>Ramp / Skids</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampSkids">http://w3id.org/charta77/jup/RampSkids</seealso>
    let RampSkids = Prefixed_Name(jup, "RampSkids") |> PrefixedName

    /// <summary>
    ///   <para>jup:RampEntranceAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:EntranceAccessibility</para>
    ///   <para>skos:Concept</para>
    ///   <para>Priloha c.3</para>
    ///   <para>Appendix 3</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampEntranceAccessibility">http://w3id.org/charta77/jup/RampEntranceAccessibility</seealso>
    let RampEntranceAccessibility =
        Prefixed_Name(jup, "RampEntranceAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Type of elevator</para><para>Typ vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorType">http://w3id.org/charta77/jup/elevatorType</seealso>
    let elevatorType = Prefixed_Name(jup, "elevatorType") |> PrefixedName
    /// <summary>
    ///   <para>jup:entranceAccess</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Access to entrance</para><para>Pristup ke vstupu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceAccess">http://w3id.org/charta77/jup/entranceAccess</seealso>
    let entranceAccess = Prefixed_Name(jup, "entranceAccess") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceAccessProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Access to entrance provided by</para><para>Pristup ke vstupu zajisti</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceAccessProvidedBy">http://w3id.org/charta77/jup/entranceAccessProvidedBy</seealso>
    let entranceAccessProvidedBy =
        Prefixed_Name(jup, "entranceAccessProvidedBy") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Accessibility of entrance</para><para>Pristupnost vstupu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceAccessibility">http://w3id.org/charta77/jup/entranceAccessibility</seealso>
    let entranceAccessibility =
        Prefixed_Name(jup, "entranceAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceAreaBeforeDoorDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Depth of area before the door in cm</para><para>Hloubka plochy pred dvermi v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceAreaBeforeDoorDepth">http://w3id.org/charta77/jup/entranceAreaBeforeDoorDepth</seealso>
    let entranceAreaBeforeDoorDepth =
        Prefixed_Name(jup, "entranceAreaBeforeDoorDepth") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceAreaBeforeDoorWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Width of area before the door in cm</para><para>Sirka plochy pred dvermi v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceAreaBeforeDoorWidth">http://w3id.org/charta77/jup/entranceAreaBeforeDoorWidth</seealso>
    let entranceAreaBeforeDoorWidth =
        Prefixed_Name(jup, "entranceAreaBeforeDoorWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceDifficultSurfaceDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Type of difficult surface: (rough historical pavement, cracked tarmac…)</para><para>Typ obtizneho povrchu (hruba historicka dlazba, popraskany asfalt…)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceDifficultSurfaceDescription">http://w3id.org/charta77/jup/entranceDifficultSurfaceDescription</seealso>
    let entranceDifficultSurfaceDescription =
        Prefixed_Name(jup, "entranceDifficultSurfaceDescription") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceGuidingLine</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vodici linie</para><para>Guiding line</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceGuidingLine">http://w3id.org/charta77/jup/entranceGuidingLine</seealso>
    let entranceGuidingLine = Prefixed_Name(jup, "entranceGuidingLine") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceIsDifficultSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Difficult surface</para><para>Obtizny povrch</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceIsDifficultSurface">http://w3id.org/charta77/jup/entranceIsDifficultSurface</seealso>
    let entranceIsDifficultSurface =
        Prefixed_Name(jup, "entranceIsDifficultSurface") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceIsLongitudinalInclination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Longitudinal inclination</para><para>Sklon podelny</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceIsLongitudinalInclination">http://w3id.org/charta77/jup/entranceIsLongitudinalInclination</seealso>
    let entranceIsLongitudinalInclination =
        Prefixed_Name(jup, "entranceIsLongitudinalInclination") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceIsSideEntranceInformation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Information about the side entrance by the main entrance</para><para>Informace o vedlejsim vstupu u vstupu hlavniho</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceIsSideEntranceInformation">http://w3id.org/charta77/jup/entranceIsSideEntranceInformation</seealso>
    let entranceIsSideEntranceInformation =
        Prefixed_Name(jup, "entranceIsSideEntranceInformation") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceIsSideEntranceMarked</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vedlejsi vstup vyznacen</para><para>Side entrance marked</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceIsSideEntranceMarked">http://w3id.org/charta77/jup/entranceIsSideEntranceMarked</seealso>
    let entranceIsSideEntranceMarked =
        Prefixed_Name(jup, "entranceIsSideEntranceMarked") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceIsStepContrastMarked</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Prvni a posledni schod kontrastne vyznacen</para><para>First and last step marked</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceIsStepContrastMarked">http://w3id.org/charta77/jup/entranceIsStepContrastMarked</seealso>
    let entranceIsStepContrastMarked =
        Prefixed_Name(jup, "entranceIsStepContrastMarked") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceIsTransverseInclination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Transverse inclination</para><para>Sklon pricny</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceIsTransverseInclination">http://w3id.org/charta77/jup/entranceIsTransverseInclination</seealso>
    let entranceIsTransverseInclination =
        Prefixed_Name(jup, "entranceIsTransverseInclination") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceLobbyDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Hloubka zadveri v cm</para><para>Lobby depth in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceLobbyDepth">http://w3id.org/charta77/jup/entranceLobbyDepth</seealso>
    let entranceLobbyDepth = Prefixed_Name(jup, "entranceLobbyDepth") |> PrefixedName
    /// <summary>
    ///   <para>jup:entranceLobbyWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Sirka zadveri v cm</para><para>Lobby width in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceLobbyWidth">http://w3id.org/charta77/jup/entranceLobbyWidth</seealso>
    let entranceLobbyWidth = Prefixed_Name(jup, "entranceLobbyWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceLocalization</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Entrance localization</para><para>Lokalizace vstupu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceLocalization">http://w3id.org/charta77/jup/entranceLocalization</seealso>
    let entranceLocalization =
        Prefixed_Name(jup, "entranceLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceLongitudinalInclination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Longitudinal inclination in %</para><para>Sklon podelny v %</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceLongitudinalInclination">http://w3id.org/charta77/jup/entranceLongitudinalInclination</seealso>
    let entranceLongitudinalInclination =
        Prefixed_Name(jup, "entranceLongitudinalInclination") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceLongitudinalInclinationLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Longitudinal inclination localization: (access communication, area before the entrance)</para><para>Lokalizace podelneho sklonu (pristupova komunikace, prostor pred vstupem,...)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceLongitudinalInclinationLocalization">http://w3id.org/charta77/jup/entranceLongitudinalInclinationLocalization</seealso>
    let entranceLongitudinalInclinationLocalization =
        Prefixed_Name(jup, "entranceLongitudinalInclinationLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceNumberOfReservedParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Pocet vyhrazenych parkovacich stani</para><para>Number of reserved parking places</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceNumberOfReservedParking">http://w3id.org/charta77/jup/entranceNumberOfReservedParking</seealso>
    let entranceNumberOfReservedParking =
        Prefixed_Name(jup, "entranceNumberOfReservedParking") |> PrefixedName

    /// <summary>
    ///   <para>jup:ObjectCategorizationsMKPOScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>Evaluation scheme for object accessibility based on Object Accessibility Categorization Methodology</para><para>Schema ohodnoceni pristupnosti objektu dle Metodiky Kategorizace Pristupnosti Objektu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ObjectCategorizationsMKPOScheme">http://w3id.org/charta77/jup/ObjectCategorizationsMKPOScheme</seealso>
    let ObjectCategorizationsMKPOScheme =
        Prefixed_Name(jup, "ObjectCategorizationsMKPOScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCCategorizationsMKPOScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>Bathroom accessibility evaluation scheme based on Object Accessibility Categorization Methodology</para><para>Schema ohodnoceni pristupnosti toalet dle Metodiky Kategorizace Pristupnosti Objektu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCCategorizationsMKPOScheme">http://w3id.org/charta77/jup/WCCategorizationsMKPOScheme</seealso>
    let WCCategorizationsMKPOScheme =
        Prefixed_Name(jup, "WCCategorizationsMKPOScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:IntercomBellType</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:BellType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/IntercomBellType">http://w3id.org/charta77/jup/IntercomBellType</seealso>
    let IntercomBellType = Prefixed_Name(jup, "IntercomBellType") |> PrefixedName

    /// <summary>
    ///   <para>jup:LandingsElevatorDriveOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ElevatorDriveOff</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LandingsElevatorDriveOff">http://w3id.org/charta77/jup/LandingsElevatorDriveOff</seealso>
    let LandingsElevatorDriveOff =
        Prefixed_Name(jup, "LandingsElevatorDriveOff") |> PrefixedName

    /// <summary>
    ///   <para>jup:LeftTopWCCabinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCCabinDisposition</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LeftTopWCCabinDisposition">http://w3id.org/charta77/jup/LeftTopWCCabinDisposition</seealso>
    let LeftTopWCCabinDisposition =
        Prefixed_Name(jup, "LeftTopWCCabinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:TapType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Types of taps</para><para>Typy baterii</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TapType">http://w3id.org/charta77/jup/TapType</seealso>
    let TapType = Prefixed_Name(jup, "TapType") |> PrefixedName
    /// <summary>
    ///   <para>jup:TapTypesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Schema typu baterii</para><para>Tap type scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TapTypesScheme">http://w3id.org/charta77/jup/TapTypesScheme</seealso>
    let TapTypesScheme = Prefixed_Name(jup, "TapTypesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:LobbyRampSkidsLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:RampSkidsLocalization</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/LobbyRampSkidsLocalization">http://w3id.org/charta77/jup/LobbyRampSkidsLocalization</seealso>
    let LobbyRampSkidsLocalization =
        Prefixed_Name(jup, "LobbyRampSkidsLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:MainEntrance</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Main entrance</para><para>Vstup hlavni</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MainEntrance">http://w3id.org/charta77/jup/MainEntrance</seealso>
    let MainEntrance = Prefixed_Name(jup, "MainEntrance") |> PrefixedName
    /// <summary>
    ///   <para>jup:AccessibleWCMKPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCCategorizationMKPO</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AccessibleWCMKPO">http://w3id.org/charta77/jup/AccessibleWCMKPO</seealso>
    let AccessibleWCMKPO = Prefixed_Name(jup, "AccessibleWCMKPO") |> PrefixedName
    /// <summary>
    ///   <para>jup:AddressableEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Entita majici adresu</para><para>Addressable entity</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AddressableEntity">http://w3id.org/charta77/jup/AddressableEntity</seealso>
    let AddressableEntity = Prefixed_Name(jup, "AddressableEntity") |> PrefixedName

    /// <summary>
    ///   <para>jup:ObjectCategoriesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>Building categorization scheme</para><para>Schema kategorizace budov</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ObjectCategoriesScheme">http://w3id.org/charta77/jup/ObjectCategoriesScheme</seealso>
    let ObjectCategoriesScheme =
        Prefixed_Name(jup, "ObjectCategoriesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:AirportObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AirportObjectCategory">http://w3id.org/charta77/jup/AirportObjectCategory</seealso>
    let AirportObjectCategory =
        Prefixed_Name(jup, "AirportObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:MosqueObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MosqueObjectCategory">http://w3id.org/charta77/jup/MosqueObjectCategory</seealso>
    let MosqueObjectCategory =
        Prefixed_Name(jup, "MosqueObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:HypermarketObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HypermarketObjectCategory">http://w3id.org/charta77/jup/HypermarketObjectCategory</seealso>
    let HypermarketObjectCategory =
        Prefixed_Name(jup, "HypermarketObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntitySeatHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska umisteni sedatka v cm</para><para>Seat placement height in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntitySeatHeight">http://w3id.org/charta77/jup/mappableEntitySeatHeight</seealso>
    let mappableEntitySeatHeight =
        Prefixed_Name(jup, "mappableEntitySeatHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:DirectObjectStairsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:StepsStairsType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DirectObjectStairsType">http://w3id.org/charta77/jup/DirectObjectStairsType</seealso>
    let DirectObjectStairsType =
        Prefixed_Name(jup, "DirectObjectStairsType") |> PrefixedName

    /// <summary>
    ///   <para>jup:StepsStairsTypesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Schema typu schodiste</para><para>Stair type scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/StepsStairsTypesScheme">http://w3id.org/charta77/jup/StepsStairsTypesScheme</seealso>
    let StepsStairsTypesScheme =
        Prefixed_Name(jup, "StepsStairsTypesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:DirectRampType</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:RampType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DirectRampType">http://w3id.org/charta77/jup/DirectRampType</seealso>
    let DirectRampType = Prefixed_Name(jup, "DirectRampType") |> PrefixedName
    /// <summary>
    ///   <para>jup:partOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Mappable entities relationship</para><para>Vztah mapovatelnych entit</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/partOf">http://w3id.org/charta77/jup/partOf</seealso>
    let partOf = Prefixed_Name(jup, "partOf") |> PrefixedName
    /// <summary>
    ///   <para>jup:platformAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>Access enabled by attendants if the platform is locked</para>
    ///   <para>Pokud je plosina uzamcena, pristup zajisten obsluhou.</para>
    /// labels<para>Access to platform</para><para>Pristup k plosine</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformAccess">http://w3id.org/charta77/jup/platformAccess</seealso>
    let platformAccess = Prefixed_Name(jup, "platformAccess") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformIsMinParameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Min. dimensions 70 x 90 cm, min. load capacity 150 kg</para><para>Min. rozmer 70 x 90 cm, min. nosnost 150 kg</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformIsMinParameters">http://w3id.org/charta77/jup/platformIsMinParameters</seealso>
    let platformIsMinParameters =
        Prefixed_Name(jup, "platformIsMinParameters") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformLocalization</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Platform localization</para><para>Lokalizace plosiny</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformLocalization">http://w3id.org/charta77/jup/platformLocalization</seealso>
    let platformLocalization =
        Prefixed_Name(jup, "platformLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformNumberOfSteps</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Elevation difference surmounted by platform</para>
    ///   <para>Prevyseni prekonavane plosinou</para>
    /// labels<para>Number of steps</para><para>Pocet schodu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformNumberOfSteps">http://w3id.org/charta77/jup/platformNumberOfSteps</seealso>
    let platformNumberOfSteps =
        Prefixed_Name(jup, "platformNumberOfSteps") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Width of platform in direction of motion in cm</para><para>Sirka plosiny ve smeru jizdy v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformWidth">http://w3id.org/charta77/jup/platformWidth</seealso>
    let platformWidth = Prefixed_Name(jup, "platformWidth") |> PrefixedName
    /// <summary>
    ///   <para>jup:AssessableEntity</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///   <para>ohodnoceni z hlediska pristupnosti</para>
    ///   <para>accessibility evaluation</para>
    /// labels<para>Ohodnotitelna entita</para><para>Assessable entity</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AssessableEntity">http://w3id.org/charta77/jup/AssessableEntity</seealso>
    let AssessableEntity = Prefixed_Name(jup, "AssessableEntity") |> PrefixedName
    /// <summary>
    ///   <para>jup:NavigationSystem</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Navigation system for visually handicapped persons</para><para>Navigacni system pro osoby se zrakovym omezenim</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/NavigationSystem">http://w3id.org/charta77/jup/NavigationSystem</seealso>
    let NavigationSystem = Prefixed_Name(jup, "NavigationSystem") |> PrefixedName
    /// <summary>
    ///   <para>jup:aobAboveDoor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Above the front door axis</para><para>Nad osou vstupnich dveri</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/aobAboveDoor">http://w3id.org/charta77/jup/aobAboveDoor</seealso>
    let aobAboveDoor = Prefixed_Name(jup, "aobAboveDoor") |> PrefixedName
    /// <summary>
    ///   <para>jup:DoorOpeningsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Schema typu otevirani dveri</para><para>Door openings type scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DoorOpeningsScheme">http://w3id.org/charta77/jup/DoorOpeningsScheme</seealso>
    let DoorOpeningsScheme = Prefixed_Name(jup, "DoorOpeningsScheme") |> PrefixedName
    /// <summary>
    ///   <para>jup:WCFlushing</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Types of WC flushings</para><para>Typy splachovani WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCFlushing">http://w3id.org/charta77/jup/WCFlushing</seealso>
    let WCFlushing = Prefixed_Name(jup, "WCFlushing") |> PrefixedName
    /// <summary>
    ///   <para>jup:ElevatorCageHandle</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Madlo ve vytahove kleci</para><para>Elevator cage handle</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorCageHandle">http://w3id.org/charta77/jup/ElevatorCageHandle</seealso>
    let ElevatorCageHandle = Prefixed_Name(jup, "ElevatorCageHandle") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorCageMirrorLocalizationsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Type of elevator cage mirror localizations scheme</para><para>Schema typu umisteni zrcadla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorCageMirrorLocalizationsScheme">http://w3id.org/charta77/jup/ElevatorCageMirrorLocalizationsScheme</seealso>
    let ElevatorCageMirrorLocalizationsScheme =
        Prefixed_Name(jup, "ElevatorCageMirrorLocalizationsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:doorWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Door width in cm</para><para>Sirka dveri v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorWidth">http://w3id.org/charta77/jup/doorWidth</seealso>
    let doorWidth = Prefixed_Name(jup, "doorWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorAccessProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Access to elevator provided by</para><para>Pristup k vytahu zajisti</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorAccessProvidedBy">http://w3id.org/charta77/jup/elevatorAccessProvidedBy</seealso>
    let elevatorAccessProvidedBy =
        Prefixed_Name(jup, "elevatorAccessProvidedBy") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageControlAnnouncementPhonetic</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Phonetic announcement of control inside the cage</para><para>Foneticke hlaseni ovladace uvnitr klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageControlAnnouncementPhonetic">http://w3id.org/charta77/jup/elevatorCageControlAnnouncementPhonetic</seealso>
    let elevatorCageControlAnnouncementPhonetic =
        Prefixed_Name(jup, "elevatorCageControlAnnouncementPhonetic") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageControlDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Distance of control inside the cage from the nearest corner in cm</para><para>Vzdalenost ovladace uvnitr klece od nejblizsiho rohu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageControlDistance">http://w3id.org/charta77/jup/elevatorCageControlDistance</seealso>
    let elevatorCageControlDistance =
        Prefixed_Name(jup, "elevatorCageControlDistance") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageControlHeight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Vyska umisteni horniho tlacitka ovladace uvnitr klece v cm</para><para>Height of control inside the cage in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageControlHeight">http://w3id.org/charta77/jup/elevatorCageControlHeight</seealso>
    let elevatorCageControlHeight =
        Prefixed_Name(jup, "elevatorCageControlHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Depth of elevator cage in cm</para><para>Hloubka klece vytahu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageDepth">http://w3id.org/charta77/jup/elevatorCageDepth</seealso>
    let elevatorCageDepth = Prefixed_Name(jup, "elevatorCageDepth") |> PrefixedName
    /// <summary>
    ///   <para>jup:mirrorHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska umisteni spodni hrany zrcadla v cm</para><para>Lower mirror edge height in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mirrorHeight">http://w3id.org/charta77/jup/mirrorHeight</seealso>
    let mirrorHeight = Prefixed_Name(jup, "mirrorHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageMirrorInstalled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Mirror inside the cage</para><para>Zrcadlo uvnitr klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageMirrorInstalled">http://w3id.org/charta77/jup/elevatorCageMirrorInstalled</seealso>
    let elevatorCageMirrorInstalled =
        Prefixed_Name(jup, "elevatorCageMirrorInstalled") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorCageSeatInstalled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Seat inside the cage</para><para>Sedatko uvnitr klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorCageSeatInstalled">http://w3id.org/charta77/jup/elevatorCageSeatInstalled</seealso>
    let elevatorCageSeatInstalled =
        Prefixed_Name(jup, "elevatorCageSeatInstalled") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCFlushingsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Type of WC flushings scheme</para><para>Schema typu splachovani WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCFlushingsScheme">http://w3id.org/charta77/jup/WCFlushingsScheme</seealso>
    let WCFlushingsScheme = Prefixed_Name(jup, "WCFlushingsScheme") |> PrefixedName
    /// <summary>
    ///   <para>jup:BankObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BankObjectCategory">http://w3id.org/charta77/jup/BankObjectCategory</seealso>
    let BankObjectCategory = Prefixed_Name(jup, "BankObjectCategory") |> PrefixedName
    /// <summary>
    ///   <para>jup:BarObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BarObjectCategory">http://w3id.org/charta77/jup/BarObjectCategory</seealso>
    let BarObjectCategory = Prefixed_Name(jup, "BarObjectCategory") |> PrefixedName
    /// <summary>
    ///   <para>jup:Bell</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Zvonek</para><para>Bell</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Bell">http://w3id.org/charta77/jup/Bell</seealso>
    let Bell = Prefixed_Name(jup, "Bell") |> PrefixedName
    /// <summary>
    ///   <para>jup:BellType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Typy zvonku</para><para>Bell types</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BellType">http://w3id.org/charta77/jup/BellType</seealso>
    let BellType = Prefixed_Name(jup, "BellType") |> PrefixedName
    /// <summary>
    ///   <para>jup:BellTypesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Schema typu zvonku</para><para>Bell type scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BellTypesScheme">http://w3id.org/charta77/jup/BellTypesScheme</seealso>
    let BellTypesScheme = Prefixed_Name(jup, "BellTypesScheme") |> PrefixedName
    /// <summary>
    ///   <para>jup:RampType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    /// labels<para>Types of ramp</para><para>Typy ramp</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampType">http://w3id.org/charta77/jup/RampType</seealso>
    let RampType = Prefixed_Name(jup, "RampType") |> PrefixedName
    /// <summary>
    ///   <para>jup:RampTypesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    /// labels<para>Type of ramp scheme</para><para>Schema typu ramp</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampTypesScheme">http://w3id.org/charta77/jup/RampTypesScheme</seealso>
    let RampTypesScheme = Prefixed_Name(jup, "RampTypesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:BlockedByMobileWCBasinSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCBasinSpace</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BlockedByMobileWCBasinSpace">http://w3id.org/charta77/jup/BlockedByMobileWCBasinSpace</seealso>
    let BlockedByMobileWCBasinSpace =
        Prefixed_Name(jup, "BlockedByMobileWCBasinSpace") |> PrefixedName

    /// <summary>
    ///   <para>jup:EntryAreaEntriesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Schema typu vstupu na nastupni plochu</para><para>Type of entry area entries scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntryAreaEntriesScheme">http://w3id.org/charta77/jup/EntryAreaEntriesScheme</seealso>
    let EntryAreaEntriesScheme =
        Prefixed_Name(jup, "EntryAreaEntriesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:FarmObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FarmObjectCategory">http://w3id.org/charta77/jup/FarmObjectCategory</seealso>
    let FarmObjectCategory = Prefixed_Name(jup, "FarmObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:FixedRampSkidsMobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:RampSkidsMobility</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FixedRampSkidsMobility">http://w3id.org/charta77/jup/FixedRampSkidsMobility</seealso>
    let FixedRampSkidsMobility =
        Prefixed_Name(jup, "FixedRampSkidsMobility") |> PrefixedName

    /// <summary>
    ///   <para>jup:RampSkidsMobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Mobility types of ramps/skids</para><para>Typy mobility rampy/lizin</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampSkidsMobility">http://w3id.org/charta77/jup/RampSkidsMobility</seealso>
    let RampSkidsMobility = Prefixed_Name(jup, "RampSkidsMobility") |> PrefixedName

    /// <summary>
    ///   <para>jup:RampSkidsMobilitiesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    /// labels<para>Mobility type of ramps/skids scheme</para><para>Schema typu mobility rampy/lizin</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampSkidsMobilitiesScheme">http://w3id.org/charta77/jup/RampSkidsMobilitiesScheme</seealso>
    let RampSkidsMobilitiesScheme =
        Prefixed_Name(jup, "RampSkidsMobilitiesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCChangingDesksScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Schema typu prebalovacich pultu</para><para>Type of changing desks scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCChangingDesksScheme">http://w3id.org/charta77/jup/WCChangingDesksScheme</seealso>
    let WCChangingDesksScheme =
        Prefixed_Name(jup, "WCChangingDesksScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:FolkArchitectureObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FolkArchitectureObjectCategory">http://w3id.org/charta77/jup/FolkArchitectureObjectCategory</seealso>
    let FolkArchitectureObjectCategory =
        Prefixed_Name(jup, "FolkArchitectureObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:FortressObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FortressObjectCategory">http://w3id.org/charta77/jup/FortressObjectCategory</seealso>
    let FortressObjectCategory =
        Prefixed_Name(jup, "FortressObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:FreeWCBasinSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCBasinSpace</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FreeWCBasinSpace">http://w3id.org/charta77/jup/FreeWCBasinSpace</seealso>
    let FreeWCBasinSpace = Prefixed_Name(jup, "FreeWCBasinSpace") |> PrefixedName

    /// <summary>
    ///   <para>jup:FreelyAccessibleMappableEntityAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:MappableEntityAccess</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FreelyAccessibleMappableEntityAccess">http://w3id.org/charta77/jup/FreelyAccessibleMappableEntityAccess</seealso>
    let FreelyAccessibleMappableEntityAccess =
        Prefixed_Name(jup, "FreelyAccessibleMappableEntityAccess") |> PrefixedName

    /// <summary>
    ///   <para>jup:MappableEntityAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list was copied based on forms compliant with Object Accessibility Categorization Methodology</para>
    /// labels<para>Types of accessibility to the mappable entity</para><para>Typy pristupu k mapovatelne entite</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MappableEntityAccess">http://w3id.org/charta77/jup/MappableEntityAccess</seealso>
    let MappableEntityAccess =
        Prefixed_Name(jup, "MappableEntityAccess") |> PrefixedName

    /// <summary>
    ///   <para>jup:MappableEntityAccessesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list was copied based on forms compliant with Object Accessibility Categorization Methodology</para>
    /// labels<para>A type of accessibility scheme to the mappable entity</para><para>Schema typu pristupu k mapovatelne entite</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MappableEntityAccessesScheme">http://w3id.org/charta77/jup/MappableEntityAccessesScheme</seealso>
    let MappableEntityAccessesScheme =
        Prefixed_Name(jup, "MappableEntityAccessesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:FrontEntryAreaEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:EntryAreaEntry</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FrontEntryAreaEntry">http://w3id.org/charta77/jup/FrontEntryAreaEntry</seealso>
    let FrontEntryAreaEntry = Prefixed_Name(jup, "FrontEntryAreaEntry") |> PrefixedName

    /// <summary>
    ///   <para>jup:FrontWallHandleLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:HandleLocalization</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FrontWallHandleLocalization">http://w3id.org/charta77/jup/FrontWallHandleLocalization</seealso>
    let FrontWallHandleLocalization =
        Prefixed_Name(jup, "FrontWallHandleLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:HandleLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Localization of handels</para><para>Umisteni madel</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HandleLocalization">http://w3id.org/charta77/jup/HandleLocalization</seealso>
    let HandleLocalization = Prefixed_Name(jup, "HandleLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:GalleryObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/GalleryObjectCategory">http://w3id.org/charta77/jup/GalleryObjectCategory</seealso>
    let GalleryObjectCategory =
        Prefixed_Name(jup, "GalleryObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCCabinLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Localization of WC cabin</para><para>Typy umisteni kabiny WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCCabinLocalization">http://w3id.org/charta77/jup/WCCabinLocalization</seealso>
    let WCCabinLocalization = Prefixed_Name(jup, "WCCabinLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCCabinLocalizationsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Localization of WC cabins scheme</para><para>Schema typu umisteni kabin</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCCabinLocalizationsScheme">http://w3id.org/charta77/jup/WCCabinLocalizationsScheme</seealso>
    let WCCabinLocalizationsScheme =
        Prefixed_Name(jup, "WCCabinLocalizationsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:GraphicElevatorControlFlatMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ElevatorControlFlatMarking</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/GraphicElevatorControlFlatMarking">http://w3id.org/charta77/jup/GraphicElevatorControlFlatMarking</seealso>
    let GraphicElevatorControlFlatMarking =
        Prefixed_Name(jup, "GraphicElevatorControlFlatMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:GuestHouseObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/GuestHouseObjectCategory">http://w3id.org/charta77/jup/GuestHouseObjectCategory</seealso>
    let GuestHouseObjectCategory =
        Prefixed_Name(jup, "GuestHouseObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SupermarketObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SupermarketObjectCategory">http://w3id.org/charta77/jup/SupermarketObjectCategory</seealso>
    let SupermarketObjectCategory =
        Prefixed_Name(jup, "SupermarketObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SwimmingObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SwimmingObjectCategory">http://w3id.org/charta77/jup/SwimmingObjectCategory</seealso>
    let SwimmingObjectCategory =
        Prefixed_Name(jup, "SwimmingObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SwingingDoorOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:DoorOpening</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SwingingDoorOpening">http://w3id.org/charta77/jup/SwingingDoorOpening</seealso>
    let SwingingDoorOpening = Prefixed_Name(jup, "SwingingDoorOpening") |> PrefixedName

    /// <summary>
    ///   <para>jup:TaxOfficeObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TaxOfficeObjectCategory">http://w3id.org/charta77/jup/TaxOfficeObjectCategory</seealso>
    let TaxOfficeObjectCategory =
        Prefixed_Name(jup, "TaxOfficeObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:TempleObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TempleObjectCategory">http://w3id.org/charta77/jup/TempleObjectCategory</seealso>
    let TempleObjectCategory =
        Prefixed_Name(jup, "TempleObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:contrastMarkingLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Localization of contrast marking</para><para>Umisteni</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/contrastMarkingLocalization">http://w3id.org/charta77/jup/contrastMarkingLocalization</seealso>
    let contrastMarkingLocalization =
        Prefixed_Name(jup, "contrastMarkingLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:rampSkidsInteriorLocalization</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Ramp/skids localization in interior</para><para>Lokalizace rampy/lizin v interieru</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampSkidsInteriorLocalization">http://w3id.org/charta77/jup/rampSkidsInteriorLocalization</seealso>
    let rampSkidsInteriorLocalization =
        Prefixed_Name(jup, "rampSkidsInteriorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCSwitchesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Type of WC switches scheme</para><para>Schema typu vypinacu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCSwitchesScheme">http://w3id.org/charta77/jup/WCSwitchesScheme</seealso>
    let WCSwitchesScheme = Prefixed_Name(jup, "WCSwitchesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:BasilicaObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BasilicaObjectCategory">http://w3id.org/charta77/jup/BasilicaObjectCategory</seealso>
    let BasilicaObjectCategory =
        Prefixed_Name(jup, "BasilicaObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:PlatformMKPOForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:MappableEntityForm</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/PlatformMKPOForm">http://w3id.org/charta77/jup/PlatformMKPOForm</seealso>
    let PlatformMKPOForm = Prefixed_Name(jup, "PlatformMKPOForm") |> PrefixedName
    /// <summary>
    ///   <para>jup:BentRampType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:RampType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BentRampType">http://w3id.org/charta77/jup/BentRampType</seealso>
    let BentRampType = Prefixed_Name(jup, "BentRampType") |> PrefixedName

    /// <summary>
    ///   <para>jup:BlockedByFixedWCBasinSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCBasinSpace</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BlockedByFixedWCBasinSpace">http://w3id.org/charta77/jup/BlockedByFixedWCBasinSpace</seealso>
    let BlockedByFixedWCBasinSpace =
        Prefixed_Name(jup, "BlockedByFixedWCBasinSpace") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCBasinSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Types of wheelchair space next to closet</para><para>Typy prostoru pro vozik vedle WC misy</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCBasinSpace">http://w3id.org/charta77/jup/WCBasinSpace</seealso>
    let WCBasinSpace = Prefixed_Name(jup, "WCBasinSpace") |> PrefixedName

    /// <summary>
    ///   <para>jup:BotanicGardenObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BotanicGardenObjectCategory">http://w3id.org/charta77/jup/BotanicGardenObjectCategory</seealso>
    let BotanicGardenObjectCategory =
        Prefixed_Name(jup, "BotanicGardenObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:ContrastMarkingLocalizationsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Schema typu umisteni kontrastniho znaceni prosklenych ploch</para><para>Types of contrast marking of glass surfaces scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ContrastMarkingLocalizationsScheme">http://w3id.org/charta77/jup/ContrastMarkingLocalizationsScheme</seealso>
    let ContrastMarkingLocalizationsScheme =
        Prefixed_Name(jup, "ContrastMarkingLocalizationsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:EntryArea</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Nastupni plocha</para><para>Entry area</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntryArea">http://w3id.org/charta77/jup/EntryArea</seealso>
    let EntryArea = Prefixed_Name(jup, "EntryArea") |> PrefixedName

    /// <summary>
    ///   <para>jup:BottomLeftWCCabinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCCabinDisposition</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BottomLeftWCCabinDisposition">http://w3id.org/charta77/jup/BottomLeftWCCabinDisposition</seealso>
    let BottomLeftWCCabinDisposition =
        Prefixed_Name(jup, "BottomLeftWCCabinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:BottomRightWCCabinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCCabinDisposition</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BottomRightWCCabinDisposition">http://w3id.org/charta77/jup/BottomRightWCCabinDisposition</seealso>
    let BottomRightWCCabinDisposition =
        Prefixed_Name(jup, "BottomRightWCCabinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:BusStationObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BusStationObjectCategory">http://w3id.org/charta77/jup/BusStationObjectCategory</seealso>
    let BusStationObjectCategory =
        Prefixed_Name(jup, "BusStationObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:CampObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/CampObjectCategory">http://w3id.org/charta77/jup/CampObjectCategory</seealso>
    let CampObjectCategory = Prefixed_Name(jup, "CampObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:CarDealerObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/CarDealerObjectCategory">http://w3id.org/charta77/jup/CarDealerObjectCategory</seealso>
    let CarDealerObjectCategory =
        Prefixed_Name(jup, "CarDealerObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:DoorTypesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Schema typu dveri</para><para>Door type scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DoorTypesScheme">http://w3id.org/charta77/jup/DoorTypesScheme</seealso>
    let DoorTypesScheme = Prefixed_Name(jup, "DoorTypesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:CathedralObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/CathedralObjectCategory">http://w3id.org/charta77/jup/CathedralObjectCategory</seealso>
    let CathedralObjectCategory =
        Prefixed_Name(jup, "CathedralObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:ChurchObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ChurchObjectCategory">http://w3id.org/charta77/jup/ChurchObjectCategory</seealso>
    let ChurchObjectCategory =
        Prefixed_Name(jup, "ChurchObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:CityHallObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/CityHallObjectCategory">http://w3id.org/charta77/jup/CityHallObjectCategory</seealso>
    let CityHallObjectCategory =
        Prefixed_Name(jup, "CityHallObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:Complex</para>
    /// </summary>
    /// <remarks>
    ///   <para>e.g. Prague Castle</para>
    ///   <para>napr. Prazsky hrad</para>
    /// labels<para>Building complex</para><para>Komplex budov</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Complex">http://w3id.org/charta77/jup/Complex</seealso>
    let Complex = Prefixed_Name(jup, "Complex") |> PrefixedName

    /// <summary>
    ///   <para>jup:ConcertHallObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ConcertHallObjectCategory">http://w3id.org/charta77/jup/ConcertHallObjectCategory</seealso>
    let ConcertHallObjectCategory =
        Prefixed_Name(jup, "ConcertHallObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:ContrastMarking</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Kontrastni znaceni prosklenych ploch</para><para>Contrast marking of glass surfaces</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ContrastMarking">http://w3id.org/charta77/jup/ContrastMarking</seealso>
    let ContrastMarking = Prefixed_Name(jup, "ContrastMarking") |> PrefixedName
    /// <summary>
    ///   <para>jup:CourtObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/CourtObjectCategory">http://w3id.org/charta77/jup/CourtObjectCategory</seealso>
    let CourtObjectCategory = Prefixed_Name(jup, "CourtObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:DefensiveCastleObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DefensiveCastleObjectCategory">http://w3id.org/charta77/jup/DefensiveCastleObjectCategory</seealso>
    let DefensiveCastleObjectCategory =
        Prefixed_Name(jup, "DefensiveCastleObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:DentalEmergencyObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DentalEmergencyObjectCategory">http://w3id.org/charta77/jup/DentalEmergencyObjectCategory</seealso>
    let DentalEmergencyObjectCategory =
        Prefixed_Name(jup, "DentalEmergencyObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:DepartmentStoreObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DepartmentStoreObjectCategory">http://w3id.org/charta77/jup/DepartmentStoreObjectCategory</seealso>
    let DepartmentStoreObjectCategory =
        Prefixed_Name(jup, "DepartmentStoreObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:DifficultWCFlushingDifficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCFlushingDifficulty</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DifficultWCFlushingDifficulty">http://w3id.org/charta77/jup/DifficultWCFlushingDifficulty</seealso>
    let DifficultWCFlushingDifficulty =
        Prefixed_Name(jup, "DifficultWCFlushingDifficulty") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCFlushingDifficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Types of WC flushing difficulties</para><para>Typy obtiznosti splachovani WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCFlushingDifficulty">http://w3id.org/charta77/jup/WCFlushingDifficulty</seealso>
    let WCFlushingDifficulty =
        Prefixed_Name(jup, "WCFlushingDifficulty") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCFlushingDifficultiesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Type of WC flushing difficulties scheme</para><para>Schema typu obtiznosti splachovani WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCFlushingDifficultiesScheme">http://w3id.org/charta77/jup/WCFlushingDifficultiesScheme</seealso>
    let WCFlushingDifficultiesScheme =
        Prefixed_Name(jup, "WCFlushingDifficultiesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:DigitalElevatorControlFlatMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ElevatorControlFlatMarking</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DigitalElevatorControlFlatMarking">http://w3id.org/charta77/jup/DigitalElevatorControlFlatMarking</seealso>
    let DigitalElevatorControlFlatMarking =
        Prefixed_Name(jup, "DigitalElevatorControlFlatMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorControlFlatMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Types of elevator control flat markings</para><para>Typy plochych oznaceni ovladace vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorControlFlatMarking">http://w3id.org/charta77/jup/ElevatorControlFlatMarking</seealso>
    let ElevatorControlFlatMarking =
        Prefixed_Name(jup, "ElevatorControlFlatMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorControlFlatMarkingsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Schema typu plochych oznaceni ovladace vytahu</para><para>Type of elevator control flat markings scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorControlFlatMarkingsScheme">http://w3id.org/charta77/jup/ElevatorControlFlatMarkingsScheme</seealso>
    let ElevatorControlFlatMarkingsScheme =
        Prefixed_Name(jup, "ElevatorControlFlatMarkingsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:DoctorObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DoctorObjectCategory">http://w3id.org/charta77/jup/DoctorObjectCategory</seealso>
    let DoctorObjectCategory =
        Prefixed_Name(jup, "DoctorObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:Door</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Dvere</para><para>Door</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Door">http://w3id.org/charta77/jup/Door</seealso>
    let Door = Prefixed_Name(jup, "Door") |> PrefixedName

    /// <summary>
    ///   <para>jup:DoorOpeningDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Typy orientace otevirani dveri</para><para>Door opening direction types</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DoorOpeningDirection">http://w3id.org/charta77/jup/DoorOpeningDirection</seealso>
    let DoorOpeningDirection =
        Prefixed_Name(jup, "DoorOpeningDirection") |> PrefixedName

    /// <summary>
    ///   <para>jup:DoorOpeningDirectionsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Schema typu orientace otevirani dveri</para><para>Door opening direction type scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DoorOpeningDirectionsScheme">http://w3id.org/charta77/jup/DoorOpeningDirectionsScheme</seealso>
    let DoorOpeningDirectionsScheme =
        Prefixed_Name(jup, "DoorOpeningDirectionsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:aobAnnouncement</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>AOB announcement type</para><para>Typ hlaseni</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/aobAnnouncement">http://w3id.org/charta77/jup/aobAnnouncement</seealso>
    let aobAnnouncement = Prefixed_Name(jup, "aobAnnouncement") |> PrefixedName
    /// <summary>
    ///   <para>jup:aobIsAboveDoor</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Above the front door axis</para><para>Nad osou vstupnich dveri</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/aobIsAboveDoor">http://w3id.org/charta77/jup/aobIsAboveDoor</seealso>
    let aobIsAboveDoor = Prefixed_Name(jup, "aobIsAboveDoor") |> PrefixedName
    /// <summary>
    ///   <para>jup:seatHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska umisteni sedatka v cm</para><para>Seat placement height in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/seatHeight">http://w3id.org/charta77/jup/seatHeight</seealso>
    let seatHeight = Prefixed_Name(jup, "seatHeight") |> PrefixedName
    /// <summary>
    ///   <para>jup:Bannister</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Bannister</para><para>Zabradli</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Bannister">http://w3id.org/charta77/jup/Bannister</seealso>
    let Bannister = Prefixed_Name(jup, "Bannister") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorControlReliefMarkingsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Schema typu reliefu oznaceni ovladace vytahu</para><para>Type of elevator control reliefs scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorControlReliefMarkingsScheme">http://w3id.org/charta77/jup/ElevatorControlReliefMarkingsScheme</seealso>
    let ElevatorControlReliefMarkingsScheme =
        Prefixed_Name(jup, "ElevatorControlReliefMarkingsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:elevatorControlMaxHeight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Vyska umisteni horniho tlacitka ovladace na nastupnich mistech ve vsech patrech (maximalne) v cm</para><para>Height of upper button of controls at places of entry in all floors (max) in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/elevatorControlMaxHeight">http://w3id.org/charta77/jup/elevatorControlMaxHeight</seealso>
    let elevatorControlMaxHeight =
        Prefixed_Name(jup, "elevatorControlMaxHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorDriveOffsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Type of elevator drive-offs scheme</para><para>Schema typu dojezdu vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorDriveOffsScheme">http://w3id.org/charta77/jup/ElevatorDriveOffsScheme</seealso>
    let ElevatorDriveOffsScheme =
        Prefixed_Name(jup, "ElevatorDriveOffsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorShaftDoor</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Dvere sachty vytahu</para><para>Elevator shaft door</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorShaftDoor">http://w3id.org/charta77/jup/ElevatorShaftDoor</seealso>
    let ElevatorShaftDoor = Prefixed_Name(jup, "ElevatorShaftDoor") |> PrefixedName

    /// <summary>
    ///   <para>jup:EmbassyObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EmbassyObjectCategory">http://w3id.org/charta77/jup/EmbassyObjectCategory</seealso>
    let EmbassyObjectCategory =
        Prefixed_Name(jup, "EmbassyObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:EmploymentOfficeObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EmploymentOfficeObjectCategory">http://w3id.org/charta77/jup/EmploymentOfficeObjectCategory</seealso>
    let EmploymentOfficeObjectCategory =
        Prefixed_Name(jup, "EmploymentOfficeObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:EngravedElevatorControlReliefMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ElevatorControlReliefMarking</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EngravedElevatorControlReliefMarking">http://w3id.org/charta77/jup/EngravedElevatorControlReliefMarking</seealso>
    let EngravedElevatorControlReliefMarking =
        Prefixed_Name(jup, "EngravedElevatorControlReliefMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:ObjectInteriorAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Typy pristupnosti interieru</para><para>Interior accessiblity types</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ObjectInteriorAccessibility">http://w3id.org/charta77/jup/ObjectInteriorAccessibility</seealso>
    let ObjectInteriorAccessibility =
        Prefixed_Name(jup, "ObjectInteriorAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:ObjectInteriorAccessibilitiesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Interior accessibility type scheme</para><para>Schema typu pristupnosti interieru</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ObjectInteriorAccessibilitiesScheme">http://w3id.org/charta77/jup/ObjectInteriorAccessibilitiesScheme</seealso>
    let ObjectInteriorAccessibilitiesScheme =
        Prefixed_Name(jup, "ObjectInteriorAccessibilitiesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:Entrance</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Entrance</para><para>Vstup</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Entrance">http://w3id.org/charta77/jup/Entrance</seealso>
    let Entrance = Prefixed_Name(jup, "Entrance") |> PrefixedName

    /// <summary>
    ///   <para>jup:EntranceAccessibilitiesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Entrance accessibility scheme</para><para>Schema pristupnosti vsupu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntranceAccessibilitiesScheme">http://w3id.org/charta77/jup/EntranceAccessibilitiesScheme</seealso>
    let EntranceAccessibilitiesScheme =
        Prefixed_Name(jup, "EntranceAccessibilitiesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:EntranceAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Entrance accessibility types</para><para>Typy pristupnosti vstupu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntranceAccessibility">http://w3id.org/charta77/jup/EntranceAccessibility</seealso>
    let EntranceAccessibility =
        Prefixed_Name(jup, "EntranceAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:EntranceRampSkidsLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:RampSkidsLocalization</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntranceRampSkidsLocalization">http://w3id.org/charta77/jup/EntranceRampSkidsLocalization</seealso>
    let EntranceRampSkidsLocalization =
        Prefixed_Name(jup, "EntranceRampSkidsLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:RampSkidsLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Localization of ramps/skids</para><para>Lokalizace rampy/lizin</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampSkidsLocalization">http://w3id.org/charta77/jup/RampSkidsLocalization</seealso>
    let RampSkidsLocalization =
        Prefixed_Name(jup, "RampSkidsLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:EntranceSteps</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Steps before entrance</para><para>Schody pred vstupem</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntranceSteps">http://w3id.org/charta77/jup/EntranceSteps</seealso>
    let EntranceSteps = Prefixed_Name(jup, "EntranceSteps") |> PrefixedName
    /// <summary>
    ///   <para>jup:Steps</para>
    /// </summary>
    /// <remarks>
    ///   <para>Stairs is understood as connecting different floors</para>
    ///   <para>Schodiste je chapano jako schody spojujici patra</para>
    /// labels<para>Schody, Schodiste</para><para>Steps, Stairs</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Steps">http://w3id.org/charta77/jup/Steps</seealso>
    let Steps = Prefixed_Name(jup, "Steps") |> PrefixedName
    /// <summary>
    ///   <para>jup:EntryAreaEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Typy vstupu na nastupni plochu</para><para>Types of entry area entries</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntryAreaEntry">http://w3id.org/charta77/jup/EntryAreaEntry</seealso>
    let EntryAreaEntry = Prefixed_Name(jup, "EntryAreaEntry") |> PrefixedName

    /// <summary>
    ///   <para>jup:FastFoodObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FastFoodObjectCategory">http://w3id.org/charta77/jup/FastFoodObjectCategory</seealso>
    let FastFoodObjectCategory =
        Prefixed_Name(jup, "FastFoodObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:HandleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Types of handels</para><para>Typy madel</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HandleType">http://w3id.org/charta77/jup/HandleType</seealso>
    let HandleType = Prefixed_Name(jup, "HandleType") |> PrefixedName
    /// <summary>
    ///   <para>jup:HandleTypesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Handle type scheme</para><para>Schema typu madla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HandleTypesScheme">http://w3id.org/charta77/jup/HandleTypesScheme</seealso>
    let HandleTypesScheme = Prefixed_Name(jup, "HandleTypesScheme") |> PrefixedName
    /// <summary>
    ///   <para>jup:FoldingHandleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:HandleType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FoldingHandleType">http://w3id.org/charta77/jup/FoldingHandleType</seealso>
    let FoldingHandleType = Prefixed_Name(jup, "FoldingHandleType") |> PrefixedName

    /// <summary>
    ///   <para>jup:FoldingWCChangingDesk</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCChangingDesk</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FoldingWCChangingDesk">http://w3id.org/charta77/jup/FoldingWCChangingDesk</seealso>
    let FoldingWCChangingDesk =
        Prefixed_Name(jup, "FoldingWCChangingDesk") |> PrefixedName

    /// <summary>
    ///   <para>jup:Form</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:Class</para>
    ///
    /// labels<para>Formular mapujici entitu</para><para>Form mapping entity</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Form">http://w3id.org/charta77/jup/Form</seealso>
    let Form = Prefixed_Name(jup, "Form") |> PrefixedName

    /// <summary>
    ///   <para>jup:SchoolObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SchoolObjectCategory">http://w3id.org/charta77/jup/SchoolObjectCategory</seealso>
    let SchoolObjectCategory =
        Prefixed_Name(jup, "SchoolObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SelfContainedWCCabinLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCCabinLocalization</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SelfContainedWCCabinLocalization">http://w3id.org/charta77/jup/SelfContainedWCCabinLocalization</seealso>
    let SelfContainedWCCabinLocalization =
        Prefixed_Name(jup, "SelfContainedWCCabinLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:ServiceObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ServiceObjectCategory">http://w3id.org/charta77/jup/ServiceObjectCategory</seealso>
    let ServiceObjectCategory =
        Prefixed_Name(jup, "ServiceObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SideEntrance</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Vstup vedlejsi</para><para>Side entrance</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SideEntrance">http://w3id.org/charta77/jup/SideEntrance</seealso>
    let SideEntrance = Prefixed_Name(jup, "SideEntrance") |> PrefixedName
    /// <summary>
    ///   <para>jup:SideEntryAreaEntry</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:EntryAreaEntry</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SideEntryAreaEntry">http://w3id.org/charta77/jup/SideEntryAreaEntry</seealso>
    let SideEntryAreaEntry = Prefixed_Name(jup, "SideEntryAreaEntry") |> PrefixedName

    /// <summary>
    ///   <para>jup:SideWallElevatorCageMirrorLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ElevatorCageMirrorLocalization</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SideWallElevatorCageMirrorLocalization">http://w3id.org/charta77/jup/SideWallElevatorCageMirrorLocalization</seealso>
    let SideWallElevatorCageMirrorLocalization =
        Prefixed_Name(jup, "SideWallElevatorCageMirrorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:SideWallsElevatorCageMirrorLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ElevatorCageMirrorLocalization</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SideWallsElevatorCageMirrorLocalization">http://w3id.org/charta77/jup/SideWallsElevatorCageMirrorLocalization</seealso>
    let SideWallsElevatorCageMirrorLocalization =
        Prefixed_Name(jup, "SideWallsElevatorCageMirrorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:SideWallsHandleLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:HandleLocalization</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SideWallsHandleLocalization">http://w3id.org/charta77/jup/SideWallsHandleLocalization</seealso>
    let SideWallsHandleLocalization =
        Prefixed_Name(jup, "SideWallsHandleLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:SidesDoorOpeningDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:DoorOpeningDirection</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SidesDoorOpeningDirection">http://w3id.org/charta77/jup/SidesDoorOpeningDirection</seealso>
    let SidesDoorOpeningDirection =
        Prefixed_Name(jup, "SidesDoorOpeningDirection") |> PrefixedName

    /// <summary>
    ///   <para>jup:SlidingDoorOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:DoorOpening</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SlidingDoorOpening">http://w3id.org/charta77/jup/SlidingDoorOpening</seealso>
    let SlidingDoorOpening = Prefixed_Name(jup, "SlidingDoorOpening") |> PrefixedName
    /// <summary>
    ///   <para>jup:SlipperyRampSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:RampSurface</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SlipperyRampSurface">http://w3id.org/charta77/jup/SlipperyRampSurface</seealso>
    let SlipperyRampSurface = Prefixed_Name(jup, "SlipperyRampSurface") |> PrefixedName

    /// <summary>
    ///   <para>jup:SocialOfficeObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SocialOfficeObjectCategory">http://w3id.org/charta77/jup/SocialOfficeObjectCategory</seealso>
    let SocialOfficeObjectCategory =
        Prefixed_Name(jup, "SocialOfficeObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SpiralRampType</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:RampType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SpiralRampType">http://w3id.org/charta77/jup/SpiralRampType</seealso>
    let SpiralRampType = Prefixed_Name(jup, "SpiralRampType") |> PrefixedName

    /// <summary>
    ///   <para>jup:SportsFacilityObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SportsFacilityObjectCategory">http://w3id.org/charta77/jup/SportsFacilityObjectCategory</seealso>
    let SportsFacilityObjectCategory =
        Prefixed_Name(jup, "SportsFacilityObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:StadiumObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/StadiumObjectCategory">http://w3id.org/charta77/jup/StadiumObjectCategory</seealso>
    let StadiumObjectCategory =
        Prefixed_Name(jup, "StadiumObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:StoreObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/StoreObjectCategory">http://w3id.org/charta77/jup/StoreObjectCategory</seealso>
    let StoreObjectCategory = Prefixed_Name(jup, "StoreObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SubwayStationObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SubwayStationObjectCategory">http://w3id.org/charta77/jup/SubwayStationObjectCategory</seealso>
    let SubwayStationObjectCategory =
        Prefixed_Name(jup, "SubwayStationObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SufficientWashBasinUnderpass</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WashBasinUnderpass</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SufficientWashBasinUnderpass">http://w3id.org/charta77/jup/SufficientWashBasinUnderpass</seealso>
    let SufficientWashBasinUnderpass =
        Prefixed_Name(jup, "SufficientWashBasinUnderpass") |> PrefixedName

    /// <summary>
    ///   <para>jup:SynagogueObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SynagogueObjectCategory">http://w3id.org/charta77/jup/SynagogueObjectCategory</seealso>
    let SynagogueObjectCategory =
        Prefixed_Name(jup, "SynagogueObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:Tap</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Baterie</para><para>Tap</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Tap">http://w3id.org/charta77/jup/Tap</seealso>
    let Tap = Prefixed_Name(jup, "Tap") |> PrefixedName

    /// <summary>
    ///   <para>jup:TheatreObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TheatreObjectCategory">http://w3id.org/charta77/jup/TheatreObjectCategory</seealso>
    let TheatreObjectCategory =
        Prefixed_Name(jup, "TheatreObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:TopContrastMarkingLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ContrastMarkingLocalization</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TopContrastMarkingLocalization">http://w3id.org/charta77/jup/TopContrastMarkingLocalization</seealso>
    let TopContrastMarkingLocalization =
        Prefixed_Name(jup, "TopContrastMarkingLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:TopEntryArea</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Horni nastupni plocha, vstup a dojezd</para><para>Top entry area, entry and exit</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TopEntryArea">http://w3id.org/charta77/jup/TopEntryArea</seealso>
    let TopEntryArea = Prefixed_Name(jup, "TopEntryArea") |> PrefixedName

    /// <summary>
    ///   <para>jup:TopLeftWCCabinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCCabinDisposition</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TopLeftWCCabinDisposition">http://w3id.org/charta77/jup/TopLeftWCCabinDisposition</seealso>
    let TopLeftWCCabinDisposition =
        Prefixed_Name(jup, "TopLeftWCCabinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:TopRightWCCabinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCCabinDisposition</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TopRightWCCabinDisposition">http://w3id.org/charta77/jup/TopRightWCCabinDisposition</seealso>
    let TopRightWCCabinDisposition =
        Prefixed_Name(jup, "TopRightWCCabinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:TouristGuide</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Prohlidkovy okruh</para><para>Tourist guide</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TouristGuide">http://w3id.org/charta77/jup/TouristGuide</seealso>
    let TouristGuide = Prefixed_Name(jup, "TouristGuide") |> PrefixedName
    /// <summary>
    ///   <para>jup:Tourniquet</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Tourniquet</para><para>Turniket</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/Tourniquet">http://w3id.org/charta77/jup/Tourniquet</seealso>
    let Tourniquet = Prefixed_Name(jup, "Tourniquet") |> PrefixedName
    /// <summary>
    ///   <para>jup:TowerObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TowerObjectCategory">http://w3id.org/charta77/jup/TowerObjectCategory</seealso>
    let TowerObjectCategory = Prefixed_Name(jup, "TowerObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:TownhallObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TownhallObjectCategory">http://w3id.org/charta77/jup/TownhallObjectCategory</seealso>
    let TownhallObjectCategory =
        Prefixed_Name(jup, "TownhallObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:TrainStationObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/TrainStationObjectCategory">http://w3id.org/charta77/jup/TrainStationObjectCategory</seealso>
    let TrainStationObjectCategory =
        Prefixed_Name(jup, "TrainStationObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:ValveTap</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:TapType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ValveTap">http://w3id.org/charta77/jup/ValveTap</seealso>
    let ValveTap = Prefixed_Name(jup, "ValveTap") |> PrefixedName

    /// <summary>
    ///   <para>jup:VerticalHandleOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:HandleOrientation</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/VerticalHandleOrientation">http://w3id.org/charta77/jup/VerticalHandleOrientation</seealso>
    let VerticalHandleOrientation =
        Prefixed_Name(jup, "VerticalHandleOrientation") |> PrefixedName

    /// <summary>
    ///   <para>jup:VerticalPlatformType</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:PlatformType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/VerticalPlatformType">http://w3id.org/charta77/jup/VerticalPlatformType</seealso>
    let VerticalPlatformType =
        Prefixed_Name(jup, "VerticalPlatformType") |> PrefixedName

    /// <summary>
    ///   <para>jup:VeterinarySurgeryObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/VeterinarySurgeryObjectCategory">http://w3id.org/charta77/jup/VeterinarySurgeryObjectCategory</seealso>
    let VeterinarySurgeryObjectCategory =
        Prefixed_Name(jup, "VeterinarySurgeryObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:WC</para>
    /// </summary>
    /// <remarks>
    ///   <para>Placement of equipment objects is viewed from the entrance into the room</para>
    ///   <para>Umisteni zarizovacich predmetu se hodnoti z pohledu od vstupu do kabiny</para>
    /// labels<para>Upravene WC</para><para>Adapted WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WC">http://w3id.org/charta77/jup/WC</seealso>
    let WC = Prefixed_Name(jup, "WC") |> PrefixedName
    /// <summary>
    ///   <para>jup:WCBasinLeftHandle</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>WC basin left handle</para><para>Leve madlo u WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCBasinLeftHandle">http://w3id.org/charta77/jup/WCBasinLeftHandle</seealso>
    let WCBasinLeftHandle = Prefixed_Name(jup, "WCBasinLeftHandle") |> PrefixedName
    /// <summary>
    ///   <para>jup:WCBasinRightHandle</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>WC basin right handle</para><para>Prave madlo u WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCBasinRightHandle">http://w3id.org/charta77/jup/WCBasinRightHandle</seealso>
    let WCBasinRightHandle = Prefixed_Name(jup, "WCBasinRightHandle") |> PrefixedName
    /// <summary>
    ///   <para>jup:WCHallway</para>
    /// </summary>
    /// <remarks>
    ///   <para>V pripade, ze je kabina pristupna přes predsine</para>
    ///   <para>In case that the WC is accessible through hallways</para>
    /// labels<para>Predsin upraveneho WC</para><para>Adapted WC hallway</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCHallway">http://w3id.org/charta77/jup/WCHallway</seealso>
    let WCHallway = Prefixed_Name(jup, "WCHallway") |> PrefixedName
    /// <summary>
    ///   <para>jup:WashBasin</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>WashBasin</para><para>Umyvadlo</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WashBasin">http://w3id.org/charta77/jup/WashBasin</seealso>
    let WashBasin = Prefixed_Name(jup, "WashBasin") |> PrefixedName
    /// <summary>
    ///   <para>jup:WashBasinHandle</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>WashBasin handle</para><para>Madlo u umyvadla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WashBasinHandle">http://w3id.org/charta77/jup/WashBasinHandle</seealso>
    let WashBasinHandle = Prefixed_Name(jup, "WashBasinHandle") |> PrefixedName
    /// <summary>
    ///   <para>jup:WashBasinTap</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Baterie u umyvadla</para><para>WashBasin tap</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WashBasinTap">http://w3id.org/charta77/jup/WashBasinTap</seealso>
    let WashBasinTap = Prefixed_Name(jup, "WashBasinTap") |> PrefixedName

    /// <summary>
    ///   <para>jup:WaterParkObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WaterParkObjectCategory">http://w3id.org/charta77/jup/WaterParkObjectCategory</seealso>
    let WaterParkObjectCategory =
        Prefixed_Name(jup, "WaterParkObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:WeddingHallObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WeddingHallObjectCategory">http://w3id.org/charta77/jup/WeddingHallObjectCategory</seealso>
    let WeddingHallObjectCategory =
        Prefixed_Name(jup, "WeddingHallObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:WellnessObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WellnessObjectCategory">http://w3id.org/charta77/jup/WellnessObjectCategory</seealso>
    let WellnessObjectCategory =
        Prefixed_Name(jup, "WellnessObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:WinterStadiumObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WinterStadiumObjectCategory">http://w3id.org/charta77/jup/WinterStadiumObjectCategory</seealso>
    let WinterStadiumObjectCategory =
        Prefixed_Name(jup, "WinterStadiumObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:YesWCSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCSwitch</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/YesWCSwitch">http://w3id.org/charta77/jup/YesWCSwitch</seealso>
    let YesWCSwitch = Prefixed_Name(jup, "YesWCSwitch") |> PrefixedName
    /// <summary>
    ///   <para>jup:ZooObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ZooObjectCategory">http://w3id.org/charta77/jup/ZooObjectCategory</seealso>
    let ZooObjectCategory = Prefixed_Name(jup, "ZooObjectCategory") |> PrefixedName
    /// <summary>
    ///   <para>jup:access</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Access to the mappable entity</para><para>Pristup k mapovatelne entite</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/access">http://w3id.org/charta77/jup/access</seealso>
    let access = Prefixed_Name(jup, "access") |> PrefixedName
    /// <summary>
    ///   <para>jup:accessProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Access to entrance to the mappable entity provided by</para><para>Pristup ke vstupu mapovatelne entity zajisti</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/accessProvidedBy">http://w3id.org/charta77/jup/accessProvidedBy</seealso>
    let accessProvidedBy = Prefixed_Name(jup, "accessProvidedBy") |> PrefixedName
    /// <summary>
    ///   <para>jup:accessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Pristupnost ohodnotitelne entity</para><para>Assessable entity accessibility</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/accessibility">http://w3id.org/charta77/jup/accessibility</seealso>
    let accessibility = Prefixed_Name(jup, "accessibility") |> PrefixedName
    /// <summary>
    ///   <para>jup:aobLocalization</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Localization of AOB in the case that not placed above the door axis</para><para>Lokalizace AOB v pripade, ze neni nad osou dveri</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/aobLocalization">http://w3id.org/charta77/jup/aobLocalization</seealso>
    let aobLocalization = Prefixed_Name(jup, "aobLocalization") |> PrefixedName
    /// <summary>
    ///   <para>jup:localization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Localization of mappable entity</para><para>Lokalizace mapovatelne entity</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/localization">http://w3id.org/charta77/jup/localization</seealso>
    let localization = Prefixed_Name(jup, "localization") |> PrefixedName
    /// <summary>
    ///   <para>jup:bellHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska umisteni zvonku v cm</para><para>Height of bell in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/bellHeight">http://w3id.org/charta77/jup/bellHeight</seealso>
    let bellHeight = Prefixed_Name(jup, "bellHeight") |> PrefixedName
    /// <summary>
    ///   <para>jup:bellIndentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Bell distance from corner in cm</para><para>Odsazeni zvonku od rohu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/bellIndentation">http://w3id.org/charta77/jup/bellIndentation</seealso>
    let bellIndentation = Prefixed_Name(jup, "bellIndentation") |> PrefixedName
    /// <summary>
    ///   <para>jup:bellType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Typ zvonku</para><para>Bell type</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/bellType">http://w3id.org/charta77/jup/bellType</seealso>
    let bellType = Prefixed_Name(jup, "bellType") |> PrefixedName
    /// <summary>
    ///   <para>jup:belongsTo</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Objekt je soucasti komplexu budov</para><para></para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/belongsTo">http://w3id.org/charta77/jup/belongsTo</seealso>
    let belongsTo = Prefixed_Name(jup, "belongsTo") |> PrefixedName
    /// <summary>
    ///   <para>jup:brailleLabelled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Oznaceni Braillovym pismem</para><para>Braille labelling</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/brailleLabelled">http://w3id.org/charta77/jup/brailleLabelled</seealso>
    let brailleLabelled = Prefixed_Name(jup, "brailleLabelled") |> PrefixedName
    /// <summary>
    ///   <para>jup:certifiedRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.</para>
    ///   <para>Certifikovana osoba vklada profesionalne (odborne) namerene udaje. K ziskani certifikace je nutne skoleni, zkouska, apod.</para>
    /// labels<para>Zaznam byl vytvoreny certifikovanou osobou</para><para>Entry created by a certified person</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/certifiedRecord">http://w3id.org/charta77/jup/certifiedRecord</seealso>
    let certifiedRecord = Prefixed_Name(jup, "certifiedRecord") |> PrefixedName
    /// <summary>
    ///   <para>jup:contrastMarked</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Kontrastni znaceni</para><para>Contrast marking</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/contrastMarked">http://w3id.org/charta77/jup/contrastMarked</seealso>
    let contrastMarked = Prefixed_Name(jup, "contrastMarked") |> PrefixedName

    /// <summary>
    ///   <para>jup:contrastMarkingGlassSurfacesMarked</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Glass surfaces (glass lower than 80 cm above floor level)</para><para>Prosklene plochy (proskleni nize nez 80 cm nad podlahu)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/contrastMarkingGlassSurfacesMarked">http://w3id.org/charta77/jup/contrastMarkingGlassSurfacesMarked</seealso>
    let contrastMarkingGlassSurfacesMarked =
        Prefixed_Name(jup, "contrastMarkingGlassSurfacesMarked") |> PrefixedName

    /// <summary>
    ///   <para>jup:controlHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Control placement height in cm</para><para>Vyska umisteni ovladace v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/controlHeight">http://w3id.org/charta77/jup/controlHeight</seealso>
    let controlHeight = Prefixed_Name(jup, "controlHeight") |> PrefixedName
    /// <summary>
    ///   <para>jup:createdBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Identifikator osoby, ktera vytvorila zaznam</para><para>Person ID of the entry creator</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/createdBy">http://w3id.org/charta77/jup/createdBy</seealso>
    let createdBy = Prefixed_Name(jup, "createdBy") |> PrefixedName
    /// <summary>
    ///   <para>jup:createdDate</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Datum vytvoreni zaznamu</para><para>Entry creation date</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/createdDate">http://w3id.org/charta77/jup/createdDate</seealso>
    let createdDate = Prefixed_Name(jup, "createdDate") |> PrefixedName
    /// <summary>
    ///   <para>jup:doorBrailleLabelled</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Oznaceni na dverich v Braillove pisme</para><para>Braille labelling on door</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorBrailleLabelled">http://w3id.org/charta77/jup/doorBrailleLabelled</seealso>
    let doorBrailleLabelled = Prefixed_Name(jup, "doorBrailleLabelled") |> PrefixedName

    /// <summary>
    ///   <para>jup:doorIsBrailleLabelled</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Oznaceni na dverich v Braillove pisme</para><para>Braille labelling on door</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorIsBrailleLabelled">http://w3id.org/charta77/jup/doorIsBrailleLabelled</seealso>
    let doorIsBrailleLabelled =
        Prefixed_Name(jup, "doorIsBrailleLabelled") |> PrefixedName

    /// <summary>
    ///   <para>jup:doorIsMarked</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Oznaceni na dverich</para><para>Marking on door</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorIsMarked">http://w3id.org/charta77/jup/doorIsMarked</seealso>
    let doorIsMarked = Prefixed_Name(jup, "doorIsMarked") |> PrefixedName
    /// <summary>
    ///   <para>jup:doorMainPanelWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Drive-through width of main panel in cm</para><para>Prujezdna sirka hlavniho kridla v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorMainPanelWidth">http://w3id.org/charta77/jup/doorMainPanelWidth</seealso>
    let doorMainPanelWidth = Prefixed_Name(jup, "doorMainPanelWidth") |> PrefixedName
    /// <summary>
    ///   <para>jup:doorMarked</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Oznaceni na dverich</para><para>Marking on door</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorMarked">http://w3id.org/charta77/jup/doorMarked</seealso>
    let doorMarked = Prefixed_Name(jup, "doorMarked") |> PrefixedName
    /// <summary>
    ///   <para>jup:doorOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Typ otevirani dveri</para><para>Door opening type</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorOpening">http://w3id.org/charta77/jup/doorOpening</seealso>
    let doorOpening = Prefixed_Name(jup, "doorOpening") |> PrefixedName

    /// <summary>
    ///   <para>jup:doorOpeningDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Door opening direction</para><para>Smer otevirani dveri</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorOpeningDirection">http://w3id.org/charta77/jup/doorOpeningDirection</seealso>
    let doorOpeningDirection =
        Prefixed_Name(jup, "doorOpeningDirection") |> PrefixedName

    /// <summary>
    ///   <para>jup:doorSidePanelWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Sirka vedlejsiho kridla v cm</para><para>Width of side panel in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/doorSidePanelWidth">http://w3id.org/charta77/jup/doorSidePanelWidth</seealso>
    let doorSidePanelWidth = Prefixed_Name(jup, "doorSidePanelWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:EntireObjectInteriorAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectInteriorAccessibility</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntireObjectInteriorAccessibility">http://w3id.org/charta77/jup/EntireObjectInteriorAccessibility</seealso>
    let EntireObjectInteriorAccessibility =
        Prefixed_Name(jup, "EntireObjectInteriorAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:RampHandle</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Madlo (zabradli)u rampy</para><para>Ramp handle (bannister)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampHandle">http://w3id.org/charta77/jup/RampHandle</seealso>
    let RampHandle = Prefixed_Name(jup, "RampHandle") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceIsReservedParking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyhrazene parkovaci stani</para><para>Reserved parking places</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceIsReservedParking">http://w3id.org/charta77/jup/entranceIsReservedParking</seealso>
    let entranceIsReservedParking =
        Prefixed_Name(jup, "entranceIsReservedParking") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCBasinSpacesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Type of wheelchair space next to closet scheme</para><para>Schema typu prostoru pro vozik vedle WC misy</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCBasinSpacesScheme">http://w3id.org/charta77/jup/WCBasinSpacesScheme</seealso>
    let WCBasinSpacesScheme = Prefixed_Name(jup, "WCBasinSpacesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:RampSkidsLocalizationsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>Types of elevator cage mirror localizations</para>
    /// labels<para>Localisation of ramps/skids scheme</para><para>Schema lokalizace rampy/lizin</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampSkidsLocalizationsScheme">http://w3id.org/charta77/jup/RampSkidsLocalizationsScheme</seealso>
    let RampSkidsLocalizationsScheme =
        Prefixed_Name(jup, "RampSkidsLocalizationsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcAlarmButtonInstalled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Signalizacni tlacitko</para><para>Alarm button</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcAlarmButtonInstalled">http://w3id.org/charta77/jup/wcAlarmButtonInstalled</seealso>
    let wcAlarmButtonInstalled =
        Prefixed_Name(jup, "wcAlarmButtonInstalled") |> PrefixedName

    /// <summary>
    ///   <para>jup:BottomContrastMarkingLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ContrastMarkingLocalization</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BottomContrastMarkingLocalization">http://w3id.org/charta77/jup/BottomContrastMarkingLocalization</seealso>
    let BottomContrastMarkingLocalization =
        Prefixed_Name(jup, "BottomContrastMarkingLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:FixedHandleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:HandleType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FixedHandleType">http://w3id.org/charta77/jup/FixedHandleType</seealso>
    let FixedHandleType = Prefixed_Name(jup, "FixedHandleType") |> PrefixedName
    /// <summary>
    ///   <para>jup:WCChangingDesk</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Typy prebalovacich pultu</para><para>Types of changing desks</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCChangingDesk">http://w3id.org/charta77/jup/WCChangingDesk</seealso>
    let WCChangingDesk = Prefixed_Name(jup, "WCChangingDesk") |> PrefixedName

    /// <summary>
    ///   <para>jup:RightTopWCCabinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCCabinDisposition</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RightTopWCCabinDisposition">http://w3id.org/charta77/jup/RightTopWCCabinDisposition</seealso>
    let RightTopWCCabinDisposition =
        Prefixed_Name(jup, "RightTopWCCabinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceReservedParkingAccessDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Access from reserved parking places to the building entrance: (barrier-free, curb without a ramp, narrowing…)</para><para>Pristup od vyhrazeneho parkovaciho stani ke vstupu objektu (bezbarierovy, obrubnik bez najezdu, zuzeni…)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceReservedParkingAccessDescription">http://w3id.org/charta77/jup/entranceReservedParkingAccessDescription</seealso>
    let entranceReservedParkingAccessDescription =
        Prefixed_Name(jup, "entranceReservedParkingAccessDescription") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceSideEntranceDescribed</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Information about the side entrance by the main entrance</para><para>Informace o vedlejsim vstupu u vstupu hlavniho</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceSideEntranceDescribed">http://w3id.org/charta77/jup/entranceSideEntranceDescribed</seealso>
    let entranceSideEntranceDescribed =
        Prefixed_Name(jup, "entranceSideEntranceDescribed") |> PrefixedName

    /// <summary>
    ///   <para>jup:entranceTransverseInclination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Transverse inclination in %</para><para>Sklon pricny v %</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entranceTransverseInclination">http://w3id.org/charta77/jup/entranceTransverseInclination</seealso>
    let entranceTransverseInclination =
        Prefixed_Name(jup, "entranceTransverseInclination") |> PrefixedName

    /// <summary>
    ///   <para>jup:entryAreaDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Hloubka nastupni plochy v cm</para><para>Depth of entry area in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entryAreaDepth">http://w3id.org/charta77/jup/entryAreaDepth</seealso>
    let entryAreaDepth = Prefixed_Name(jup, "entryAreaDepth") |> PrefixedName

    /// <summary>
    ///   <para>jup:entryAreaEntryClosing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>closing (doors, barriers) of entry area</para><para>Zavirani (dvirka, zabrana) vstupu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entryAreaEntryClosing">http://w3id.org/charta77/jup/entryAreaEntryClosing</seealso>
    let entryAreaEntryClosing =
        Prefixed_Name(jup, "entryAreaEntryClosing") |> PrefixedName

    /// <summary>
    ///   <para>jup:entryAreaEntryWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Sirka vstupu na nastuni plochu v cm</para><para>Width of entry to entry area in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entryAreaEntryWidth">http://w3id.org/charta77/jup/entryAreaEntryWidth</seealso>
    let entryAreaEntryWidth = Prefixed_Name(jup, "entryAreaEntryWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcCabinWCBasinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>pridat sken nakresu</para>
    ///   <para></para>
    /// labels<para>Dispozice WC misy v kabine WC</para><para>Cabin WC basin disposition</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcCabinWCBasinDisposition">http://w3id.org/charta77/jup/wcCabinWCBasinDisposition</seealso>
    let wcCabinWCBasinDisposition =
        Prefixed_Name(jup, "wcCabinWCBasinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:ContrastMarkingLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Typy umisteni kontrastniho znaceni prosklenych ploch</para><para>Types of contrast marking of glass surfaces</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ContrastMarkingLocalization">http://w3id.org/charta77/jup/ContrastMarkingLocalization</seealso>
    let ContrastMarkingLocalization =
        Prefixed_Name(jup, "ContrastMarkingLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:BottomEntryArea</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Dolni nastupni plocha, vstup a dojezd</para><para>Bottom entry area, entry and exit</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BottomEntryArea">http://w3id.org/charta77/jup/BottomEntryArea</seealso>
    let BottomEntryArea = Prefixed_Name(jup, "BottomEntryArea") |> PrefixedName

    /// <summary>
    ///   <para>jup:WCCabinDispositionsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>Schema typu dispozic kabiny WC</para><para>Disposition of WC cabin scheme</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCCabinDispositionsScheme">http://w3id.org/charta77/jup/WCCabinDispositionsScheme</seealso>
    let WCCabinDispositionsScheme =
        Prefixed_Name(jup, "WCCabinDispositionsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:CargoElevatorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ElevatorType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/CargoElevatorType">http://w3id.org/charta77/jup/CargoElevatorType</seealso>
    let CargoElevatorType = Prefixed_Name(jup, "CargoElevatorType") |> PrefixedName
    /// <summary>
    ///   <para>jup:CarouselDoorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:DoorType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/CarouselDoorType">http://w3id.org/charta77/jup/CarouselDoorType</seealso>
    let CarouselDoorType = Prefixed_Name(jup, "CarouselDoorType") |> PrefixedName
    /// <summary>
    ///   <para>jup:DoorType</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Door types</para><para>Typy dveri</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DoorType">http://w3id.org/charta77/jup/DoorType</seealso>
    let DoorType = Prefixed_Name(jup, "DoorType") |> PrefixedName

    /// <summary>
    ///   <para>jup:ChapelObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ChapelObjectCategory">http://w3id.org/charta77/jup/ChapelObjectCategory</seealso>
    let ChapelObjectCategory =
        Prefixed_Name(jup, "ChapelObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:CinemaObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/CinemaObjectCategory">http://w3id.org/charta77/jup/CinemaObjectCategory</seealso>
    let CinemaObjectCategory =
        Prefixed_Name(jup, "CinemaObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:HealthInsuranceCompanyObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HealthInsuranceCompanyObjectCategory">http://w3id.org/charta77/jup/HealthInsuranceCompanyObjectCategory</seealso>
    let HealthInsuranceCompanyObjectCategory =
        Prefixed_Name(jup, "HealthInsuranceCompanyObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:HospitalObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HospitalObjectCategory">http://w3id.org/charta77/jup/HospitalObjectCategory</seealso>
    let HospitalObjectCategory =
        Prefixed_Name(jup, "HospitalObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:InaccessibleObjectInteriorAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectInteriorAccessibility</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InaccessibleObjectInteriorAccessibility">http://w3id.org/charta77/jup/InaccessibleObjectInteriorAccessibility</seealso>
    let InaccessibleObjectInteriorAccessibility =
        Prefixed_Name(jup, "InaccessibleObjectInteriorAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:InaccessibleWCMKPO</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCCategorizationMKPO</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InaccessibleWCMKPO">http://w3id.org/charta77/jup/InaccessibleWCMKPO</seealso>
    let InaccessibleWCMKPO = Prefixed_Name(jup, "InaccessibleWCMKPO") |> PrefixedName

    /// <summary>
    ///   <para>jup:InclinedPlatformType</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:PlatformType</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InclinedPlatformType">http://w3id.org/charta77/jup/InclinedPlatformType</seealso>
    let InclinedPlatformType =
        Prefixed_Name(jup, "InclinedPlatformType") |> PrefixedName

    /// <summary>
    ///   <para>jup:IndoorSwimmingPoolObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/IndoorSwimmingPoolObjectCategory">http://w3id.org/charta77/jup/IndoorSwimmingPoolObjectCategory</seealso>
    let IndoorSwimmingPoolObjectCategory =
        Prefixed_Name(jup, "IndoorSwimmingPoolObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:InformationCenterObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InformationCenterObjectCategory">http://w3id.org/charta77/jup/InformationCenterObjectCategory</seealso>
    let InformationCenterObjectCategory =
        Prefixed_Name(jup, "InformationCenterObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:InsufficientWashBasinUnderpass</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WashBasinUnderpass</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InsufficientWashBasinUnderpass">http://w3id.org/charta77/jup/InsufficientWashBasinUnderpass</seealso>
    let InsufficientWashBasinUnderpass =
        Prefixed_Name(jup, "InsufficientWashBasinUnderpass") |> PrefixedName

    /// <summary>
    ///   <para>jup:WashBasinUnderpass</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Types of wash basin underpasses</para><para>Typy podjezdu umyvadla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WashBasinUnderpass">http://w3id.org/charta77/jup/WashBasinUnderpass</seealso>
    let WashBasinUnderpass = Prefixed_Name(jup, "WashBasinUnderpass") |> PrefixedName

    /// <summary>
    ///   <para>jup:WashBasinUnderpassesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Type of wash basin underpasses scheme</para><para>Schema typu podjezdu umyvadla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WashBasinUnderpassesScheme">http://w3id.org/charta77/jup/WashBasinUnderpassesScheme</seealso>
    let WashBasinUnderpassesScheme =
        Prefixed_Name(jup, "WashBasinUnderpassesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:InteriorRampSkidsLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:RampSkidsLocalization</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InteriorRampSkidsLocalization">http://w3id.org/charta77/jup/InteriorRampSkidsLocalization</seealso>
    let InteriorRampSkidsLocalization =
        Prefixed_Name(jup, "InteriorRampSkidsLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:InteriorSteps</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Steps inside the interior</para><para>Schody v interieru</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InteriorSteps">http://w3id.org/charta77/jup/InteriorSteps</seealso>
    let InteriorSteps = Prefixed_Name(jup, "InteriorSteps") |> PrefixedName

    /// <summary>
    ///   <para>jup:InwardsDoorOpeningDirection</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:DoorOpeningDirection</para>
    ///   <para>skos:Concept</para>
    ///   <para>to the interior of the cabine</para>
    ///   <para>do kabiny</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/InwardsDoorOpeningDirection">http://w3id.org/charta77/jup/InwardsDoorOpeningDirection</seealso>
    let InwardsDoorOpeningDirection =
        Prefixed_Name(jup, "InwardsDoorOpeningDirection") |> PrefixedName

    /// <summary>
    ///   <para>jup:mapperIsCertified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.</para>
    ///   <para>Certifikovana osoba vklada profesionalne (odborne) namerene udaje. K ziskani certifikace je nutne skoleni, zkouska, apod.</para>
    /// labels<para>Cerifikovana osoba</para><para>Certified person</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mapperIsCertified">http://w3id.org/charta77/jup/mapperIsCertified</seealso>
    let mapperIsCertified = Prefixed_Name(jup, "mapperIsCertified") |> PrefixedName
    /// <summary>
    ///   <para>jup:mapperNick</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Uzivatelske jmeno</para><para>Username</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mapperNick">http://w3id.org/charta77/jup/mapperNick</seealso>
    let mapperNick = Prefixed_Name(jup, "mapperNick") |> PrefixedName

    /// <summary>
    ///   <para>jup:narrowedPassageWidth</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Narrowed passage width in cm</para><para>Sirka zuzeneho pruchodu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/narrowedPassageWidth">http://w3id.org/charta77/jup/narrowedPassageWidth</seealso>
    let narrowedPassageWidth =
        Prefixed_Name(jup, "narrowedPassageWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:passageWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Sirka pruchodu v cm</para><para>Passage width in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/passageWidth">http://w3id.org/charta77/jup/passageWidth</seealso>
    let passageWidth = Prefixed_Name(jup, "passageWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:navigationSystemDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Hapticky, elektronicky…</para><para>Haptic, electronic,...</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/navigationSystemDescription">http://w3id.org/charta77/jup/navigationSystemDescription</seealso>
    let navigationSystemDescription =
        Prefixed_Name(jup, "navigationSystemDescription") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectAccessibilityMKPO</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Object accessibility evaluation scheme based on Object Accessibility Categorization Methodology</para><para>Ohodnoceni pristupnosti objektu dle Metodiky Kategorizace Pristupnosti Objektu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectAccessibilityMKPO">http://w3id.org/charta77/jup/objectAccessibilityMKPO</seealso>
    let objectAccessibilityMKPO =
        Prefixed_Name(jup, "objectAccessibilityMKPO") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Kategorie budovy</para><para>Object category</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectCategory">http://w3id.org/charta77/jup/objectCategory</seealso>
    let objectCategory = Prefixed_Name(jup, "objectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectIsNarrowedPassage</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Narrowed passage (less than 80 cm)</para><para>Zuzeny pruchod (mene nez 800mm)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectIsNarrowedPassage">http://w3id.org/charta77/jup/objectIsNarrowedPassage</seealso>
    let objectIsNarrowedPassage =
        Prefixed_Name(jup, "objectIsNarrowedPassage") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectIsNavigationSystem</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Navigation system for visually handicapped persons</para><para>Navigacni system pro osoby se zrakovym omezenim</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectIsNavigationSystem">http://w3id.org/charta77/jup/objectIsNavigationSystem</seealso>
    let objectIsNavigationSystem =
        Prefixed_Name(jup, "objectIsNavigationSystem") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectIsStairs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Spojujici patra budovy</para>
    ///   <para></para>
    /// labels<para>Stairs inside the interior</para><para>Schodiste v interieru</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectIsStairs">http://w3id.org/charta77/jup/objectIsStairs</seealso>
    let objectIsStairs = Prefixed_Name(jup, "objectIsStairs") |> PrefixedName
    /// <summary>
    ///   <para>jup:objectIsTourniquet</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Tourniquets</para><para>Turnikety</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectIsTourniquet">http://w3id.org/charta77/jup/objectIsTourniquet</seealso>
    let objectIsTourniquet = Prefixed_Name(jup, "objectIsTourniquet") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectNarrowedPassageWidth</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Narrowed passage width in cm</para><para>Sirka zuzeneho pruchodu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectNarrowedPassageWidth">http://w3id.org/charta77/jup/objectNarrowedPassageWidth</seealso>
    let objectNarrowedPassageWidth =
        Prefixed_Name(jup, "objectNarrowedPassageWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectNavigationSystemDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Hapticky, elektronicky…</para><para>Haptic, electronic,...</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectNavigationSystemDescription">http://w3id.org/charta77/jup/objectNavigationSystemDescription</seealso>
    let objectNavigationSystemDescription =
        Prefixed_Name(jup, "objectNavigationSystemDescription") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectStairsIsBannister</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Stairway with bannister</para><para>Zabradli u schodiste</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectStairsIsBannister">http://w3id.org/charta77/jup/objectStairsIsBannister</seealso>
    let objectStairsIsBannister =
        Prefixed_Name(jup, "objectStairsIsBannister") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectStairsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Typ schodiste</para><para>Stair type</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectStairsType">http://w3id.org/charta77/jup/objectStairsType</seealso>
    let objectStairsType = Prefixed_Name(jup, "objectStairsType") |> PrefixedName
    /// <summary>
    ///   <para>jup:ObjectStairsType</para>
    /// </summary>
    /// <remarks></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ObjectStairsType">http://w3id.org/charta77/jup/ObjectStairsType</seealso>
    let ObjectStairsType = Prefixed_Name(jup, "ObjectStairsType") |> PrefixedName
    /// <summary>
    ///   <para>jup:objectStairsWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Sirka schodiste v cm</para><para>Stairs width in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectStairsWidth">http://w3id.org/charta77/jup/objectStairsWidth</seealso>
    let objectStairsWidth = Prefixed_Name(jup, "objectStairsWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:objectTourniquetLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Tourniquet localization</para><para>Lokalizace turniketu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/objectTourniquetLocalization">http://w3id.org/charta77/jup/objectTourniquetLocalization</seealso>
    let objectTourniquetLocalization =
        Prefixed_Name(jup, "objectTourniquetLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Depth of platform in direction of motion in cm</para><para>Hloubka plosiny ve smeru jizdy v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformDepth">http://w3id.org/charta77/jup/platformDepth</seealso>
    let platformDepth = Prefixed_Name(jup, "platformDepth") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformInsideControlHeight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Height of control inside the platform in cm</para><para>Vyska umisteni ovladacu uvnitr plosiny v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformInsideControlHeight">http://w3id.org/charta77/jup/platformInsideControlHeight</seealso>
    let platformInsideControlHeight =
        Prefixed_Name(jup, "platformInsideControlHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformMaxLoad</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Maximum load in kg</para><para>Nosnost v kg</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformMaxLoad">http://w3id.org/charta77/jup/platformMaxLoad</seealso>
    let platformMaxLoad = Prefixed_Name(jup, "platformMaxLoad") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformMinParameters</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Min. dimensions 70 x 90 cm, min. load capacity 150 kg</para><para>Min. rozmer 70 x 90 cm, min. nosnost 150 kg</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformMinParameters">http://w3id.org/charta77/jup/platformMinParameters</seealso>
    let platformMinParameters =
        Prefixed_Name(jup, "platformMinParameters") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformNumberOfFloors</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Prevyseni prekonavane plosinou</para>
    ///   <para>Elevation difference surmounted by platform</para>
    /// labels<para>Number of floors</para><para>Pocet podlazi</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformNumberOfFloors">http://w3id.org/charta77/jup/platformNumberOfFloors</seealso>
    let platformNumberOfFloors =
        Prefixed_Name(jup, "platformNumberOfFloors") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformOutsideBottomControlHeight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Height of control outside the platform bottom in cm</para><para>Vyska umisteni ovladacu vne plosiny dole v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformOutsideBottomControlHeight">http://w3id.org/charta77/jup/platformOutsideBottomControlHeight</seealso>
    let platformOutsideBottomControlHeight =
        Prefixed_Name(jup, "platformOutsideBottomControlHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformOutsideTopControlHeight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Height of control outside the platform top in cm</para><para>Vyska umisteni ovladacu vne plosiny nahore v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformOutsideTopControlHeight">http://w3id.org/charta77/jup/platformOutsideTopControlHeight</seealso>
    let platformOutsideTopControlHeight =
        Prefixed_Name(jup, "platformOutsideTopControlHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:platformType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Type of platform</para><para>Typ plosiny</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/platformType">http://w3id.org/charta77/jup/platformType</seealso>
    let platformType = Prefixed_Name(jup, "platformType") |> PrefixedName

    /// <summary>
    ///   <para>jup:rampAccessProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Access to the ramp provided by</para><para>Pristup k rampe zajisti</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampAccessProvidedBy">http://w3id.org/charta77/jup/rampAccessProvidedBy</seealso>
    let rampAccessProvidedBy =
        Prefixed_Name(jup, "rampAccessProvidedBy") |> PrefixedName

    /// <summary>
    ///   <para>jup:rampLegInclination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Indentation of rampLeg in cm</para><para>Sklon ramena v %</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampLegInclination">http://w3id.org/charta77/jup/rampLegInclination</seealso>
    let rampLegInclination = Prefixed_Name(jup, "rampLegInclination") |> PrefixedName
    /// <summary>
    ///   <para>jup:rampLegLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Length of rampLeg in cm</para><para>Delka ramena v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampLegLength">http://w3id.org/charta77/jup/rampLegLength</seealso>
    let rampLegLength = Prefixed_Name(jup, "rampLegLength") |> PrefixedName
    /// <summary>
    ///   <para>jup:rampLegWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Width of rampLeg in cm</para><para>Sirka ramena v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampLegWidth">http://w3id.org/charta77/jup/rampLegWidth</seealso>
    let rampLegWidth = Prefixed_Name(jup, "rampLegWidth") |> PrefixedName
    /// <summary>
    ///   <para>jup:rampNumberOfLegs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Number of rampLegs (sections)</para><para>Pocet ramen (useku)</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampNumberOfLegs">http://w3id.org/charta77/jup/rampNumberOfLegs</seealso>
    let rampNumberOfLegs = Prefixed_Name(jup, "rampNumberOfLegs") |> PrefixedName

    /// <summary>
    ///   <para>jup:rampSkidsLocalization</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Localization of ramp/skids</para><para>Lokalizace rampy/lizin</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampSkidsLocalization">http://w3id.org/charta77/jup/rampSkidsLocalization</seealso>
    let rampSkidsLocalization =
        Prefixed_Name(jup, "rampSkidsLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:rampSkidsMobility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Mobilita rampy/lizin</para><para>Ramp/skids mobility</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampSkidsMobility">http://w3id.org/charta77/jup/rampSkidsMobility</seealso>
    let rampSkidsMobility = Prefixed_Name(jup, "rampSkidsMobility") |> PrefixedName
    /// <summary>
    ///   <para>jup:rampSurface</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Povrch rampy</para><para>Ramp surface</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampSurface">http://w3id.org/charta77/jup/rampSurface</seealso>
    let rampSurface = Prefixed_Name(jup, "rampSurface") |> PrefixedName
    /// <summary>
    ///   <para>jup:rampType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Type of ramp</para><para>Typ rampy</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/rampType">http://w3id.org/charta77/jup/rampType</seealso>
    let rampType = Prefixed_Name(jup, "rampType") |> PrefixedName
    /// <summary>
    ///   <para>jup:sameAs</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Pro uplnost slovniku</para>
    ///   <para>To complete the vocabulary</para>
    /// labels<para>Equality of individuals</para><para>Rovnost individui</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/sameAs">http://w3id.org/charta77/jup/sameAs</seealso>
    let sameAs = Prefixed_Name(jup, "sameAs") |> PrefixedName
    /// <summary>
    ///   <para>jup:skidsInclination</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Skids inclination in %</para><para>Sklon lizin v %</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/skidsInclination">http://w3id.org/charta77/jup/skidsInclination</seealso>
    let skidsInclination = Prefixed_Name(jup, "skidsInclination") |> PrefixedName
    /// <summary>
    ///   <para>jup:skidsLength</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Length of skids in cm</para><para>Delka lizin v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/skidsLength">http://w3id.org/charta77/jup/skidsLength</seealso>
    let skidsLength = Prefixed_Name(jup, "skidsLength") |> PrefixedName
    /// <summary>
    ///   <para>jup:source</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Pro uplnost slovniku</para>
    ///   <para>To complete the vocabulary</para>
    /// labels<para>Zdroj dat o mapovatelne entite</para><para>Mappable entity data source</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/source">http://w3id.org/charta77/jup/source</seealso>
    let source = Prefixed_Name(jup, "source") |> PrefixedName
    /// <summary>
    ///   <para>jup:stepsContrastMarked</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Prvni a posledni schod kontrastne vyznacen</para><para>First and last step marked</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/stepsContrastMarked">http://w3id.org/charta77/jup/stepsContrastMarked</seealso>
    let stepsContrastMarked = Prefixed_Name(jup, "stepsContrastMarked") |> PrefixedName
    /// <summary>
    ///   <para>jup:stepsDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Depth of step in cm</para><para>Hloubka schodu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/stepsDepth">http://w3id.org/charta77/jup/stepsDepth</seealso>
    let stepsDepth = Prefixed_Name(jup, "stepsDepth") |> PrefixedName
    /// <summary>
    ///   <para>jup:stepsHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Height of step in cm</para><para>Vyska schodu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/stepsHeight">http://w3id.org/charta77/jup/stepsHeight</seealso>
    let stepsHeight = Prefixed_Name(jup, "stepsHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:stepsIsContrastMarked</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Prvni a posledni schod kontrastne vyznacen</para><para>First and last step marked</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/stepsIsContrastMarked">http://w3id.org/charta77/jup/stepsIsContrastMarked</seealso>
    let stepsIsContrastMarked =
        Prefixed_Name(jup, "stepsIsContrastMarked") |> PrefixedName

    /// <summary>
    ///   <para>jup:stepsLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para></para>
    ///   <para>Podlazi (-1.NP, 1.NP, 2, 1-2,...)</para>
    /// labels<para>Lokalizace schodu nebo schodiste</para><para>Localization of steps or stairs</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/stepsLocalization">http://w3id.org/charta77/jup/stepsLocalization</seealso>
    let stepsLocalization = Prefixed_Name(jup, "stepsLocalization") |> PrefixedName
    /// <summary>
    ///   <para>jup:stepsNumberOf</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Number of steps</para><para>Pocet schodu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/stepsNumberOf">http://w3id.org/charta77/jup/stepsNumberOf</seealso>
    let stepsNumberOf = Prefixed_Name(jup, "stepsNumberOf") |> PrefixedName
    /// <summary>
    ///   <para>jup:stepsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Typ schodiste nebo schodu</para><para>Type of stairs or steps</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/stepsType">http://w3id.org/charta77/jup/stepsType</seealso>
    let stepsType = Prefixed_Name(jup, "stepsType") |> PrefixedName
    /// <summary>
    ///   <para>jup:stepsWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Width of step in cm</para><para>Sirka schodu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/stepsWidth">http://w3id.org/charta77/jup/stepsWidth</seealso>
    let stepsWidth = Prefixed_Name(jup, "stepsWidth") |> PrefixedName
    /// <summary>
    ///   <para>jup:switchHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Switch placement height in cm</para><para>Vyska umisteni vypinace v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/switchHeight">http://w3id.org/charta77/jup/switchHeight</seealso>
    let switchHeight = Prefixed_Name(jup, "switchHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:tourniquetLocalization</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Tourniquet localization</para><para>Lokalizace turniketu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/tourniquetLocalization">http://w3id.org/charta77/jup/tourniquetLocalization</seealso>
    let tourniquetLocalization =
        Prefixed_Name(jup, "tourniquetLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:upToDateRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Starsi zaznamy o stejne mapovatelne entite maji nastaveny priznak na false</para>
    ///   <para>Older entries describing the same mappable entity are assigned the false value.</para>
    /// labels<para>Aktualni zaznam</para><para>Current entry</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/upToDateRecord">http://w3id.org/charta77/jup/upToDateRecord</seealso>
    let upToDateRecord = Prefixed_Name(jup, "upToDateRecord") |> PrefixedName
    /// <summary>
    ///   <para>jup:washBasinHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska umisteni umyvadla v cm</para><para>Height of wash basin in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/washBasinHeight">http://w3id.org/charta77/jup/washBasinHeight</seealso>
    let washBasinHeight = Prefixed_Name(jup, "washBasinHeight") |> PrefixedName
    /// <summary>
    ///   <para>jup:washBasinUnderpass</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Podjezd umyvadla v hloubce 200mm od hrany umyvadla</para><para>Wash basin underpass 20 cm below the side of basin</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/washBasinUnderpass">http://w3id.org/charta77/jup/washBasinUnderpass</seealso>
    let washBasinUnderpass = Prefixed_Name(jup, "washBasinUnderpass") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcAccessibilityMKPO</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Bathroom accessibility evaluation system based on Object Accessibility Categorization Methodology</para><para>Ohodnoceni pristupnosti toalety dle Metodiky Kategorizace Pristupnosti Objektu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcAccessibilityMKPO">http://w3id.org/charta77/jup/wcAccessibilityMKPO</seealso>
    let wcAccessibilityMKPO = Prefixed_Name(jup, "wcAccessibilityMKPO") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcAlarmButtonBottomHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska signalizacniho tlacitka ve spodni urovni v cm</para><para>Height of alarm at bottom level in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcAlarmButtonBottomHeight">http://w3id.org/charta77/jup/wcAlarmButtonBottomHeight</seealso>
    let wcAlarmButtonBottomHeight =
        Prefixed_Name(jup, "wcAlarmButtonBottomHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcAlarmButtonTopHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska signalizacniho tlacitka v horni urovni v cm</para><para>Height of alarm at top level in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcAlarmButtonTopHeight">http://w3id.org/charta77/jup/wcAlarmButtonTopHeight</seealso>
    let wcAlarmButtonTopHeight =
        Prefixed_Name(jup, "wcAlarmButtonTopHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcBasinBackIndentation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vzdalenost odsazeni cela misy od zadni steny v cm</para><para>Indentation of WC basin from back wall in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcBasinBackIndentation">http://w3id.org/charta77/jup/wcBasinBackIndentation</seealso>
    let wcBasinBackIndentation =
        Prefixed_Name(jup, "wcBasinBackIndentation") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcBasinIsPaperReach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Toilet paper within a reach of the WC basin</para><para>Toaletni papir v dosahu z misy</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcBasinIsPaperReach">http://w3id.org/charta77/jup/wcBasinIsPaperReach</seealso>
    let wcBasinIsPaperReach = Prefixed_Name(jup, "wcBasinIsPaperReach") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcBasinLeftDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Distance from left side of basin to the left wall in cm</para><para>Vzdalenost od leveho boku misy k leve stene v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcBasinLeftDistance">http://w3id.org/charta77/jup/wcBasinLeftDistance</seealso>
    let wcBasinLeftDistance = Prefixed_Name(jup, "wcBasinLeftDistance") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcBasinPaperWithinReach</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Toilet paper within a reach of the WC basin</para><para>Toaletni papir v dosahu z misy</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcBasinPaperWithinReach">http://w3id.org/charta77/jup/wcBasinPaperWithinReach</seealso>
    let wcBasinPaperWithinReach =
        Prefixed_Name(jup, "wcBasinPaperWithinReach") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcBasinRightDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Distance from right side of basin to the right wall in cm</para><para>Vzdalenost od praveho boku misy k prave stene v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcBasinRightDistance">http://w3id.org/charta77/jup/wcBasinRightDistance</seealso>
    let wcBasinRightDistance =
        Prefixed_Name(jup, "wcBasinRightDistance") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcBasinSpace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Space for wheelchair next to the WC basin</para><para>Prostor pro vozik vedle WC misy</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcBasinSpace">http://w3id.org/charta77/jup/wcBasinSpace</seealso>
    let wcBasinSpace = Prefixed_Name(jup, "wcBasinSpace") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcCabinAccess</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Accessibility to adpted WC cabin</para><para>Pristup do upravene WC kabiny</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcCabinAccess">http://w3id.org/charta77/jup/wcCabinAccess</seealso>
    let wcCabinAccess = Prefixed_Name(jup, "wcCabinAccess") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcCabinDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Depth of WC cabin in cm</para><para>Hloubka kabiny v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcCabinDepth">http://w3id.org/charta77/jup/wcCabinDepth</seealso>
    let wcCabinDepth = Prefixed_Name(jup, "wcCabinDepth") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcCabinDoorDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para></para>
    ///   <para>pridat sken nakresu</para>
    /// labels<para>Dispozice dveri v kabine WC</para><para>Cabin door disposition</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcCabinDoorDisposition">http://w3id.org/charta77/jup/wcCabinDoorDisposition</seealso>
    let wcCabinDoorDisposition =
        Prefixed_Name(jup, "wcCabinDoorDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcCabinLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Type of adapted WC cabin</para><para>Typ upravene WC kabiny</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcCabinLocalization">http://w3id.org/charta77/jup/wcCabinLocalization</seealso>
    let wcCabinLocalization = Prefixed_Name(jup, "wcCabinLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcCabinWashBasinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>pridat sken nakresu</para>
    ///   <para></para>
    /// labels<para>Dispozice umyvadla v kabine WC</para><para>Cabin washBasin disposition</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcCabinWashBasinDisposition">http://w3id.org/charta77/jup/wcCabinWashBasinDisposition</seealso>
    let wcCabinWashBasinDisposition =
        Prefixed_Name(jup, "wcCabinWashBasinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcCabinWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Width of WC cabin in cm</para><para>Sirka kabiny v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcCabinWidth">http://w3id.org/charta77/jup/wcCabinWidth</seealso>
    let wcCabinWidth = Prefixed_Name(jup, "wcCabinWidth") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcChangingDesk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Typ prebalovaciho pultu</para><para>Type of changing desk</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcChangingDesk">http://w3id.org/charta77/jup/wcChangingDesk</seealso>
    let wcChangingDesk = Prefixed_Name(jup, "wcChangingDesk") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcChangingDeskInstalled</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Prebalovaci pult</para><para>Changing desk</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcChangingDeskInstalled">http://w3id.org/charta77/jup/wcChangingDeskInstalled</seealso>
    let wcChangingDeskInstalled =
        Prefixed_Name(jup, "wcChangingDeskInstalled") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcChangingDeskObstructs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Prekazi prebalovaci pult pri obsluze WC</para><para>Changing desk obstructs the use of WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcChangingDeskObstructs">http://w3id.org/charta77/jup/wcChangingDeskObstructs</seealso>
    let wcChangingDeskObstructs =
        Prefixed_Name(jup, "wcChangingDeskObstructs") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcFlushingBackHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Height of toilet flushing at the back in cm</para><para>Vyska umisteni splachovani vzadu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcFlushingBackHeight">http://w3id.org/charta77/jup/wcFlushingBackHeight</seealso>
    let wcFlushingBackHeight =
        Prefixed_Name(jup, "wcFlushingBackHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcFlushingDifficulty</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Difficulty of flushing</para><para>Obtiznost splachovani</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcFlushingDifficulty">http://w3id.org/charta77/jup/wcFlushingDifficulty</seealso>
    let wcFlushingDifficulty =
        Prefixed_Name(jup, "wcFlushingDifficulty") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcFlushingSideDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Distance from corner of toilet flushing from side in cm</para><para>Vzdalenost splachovani od rohu mistnosti v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcFlushingSideDistance">http://w3id.org/charta77/jup/wcFlushingSideDistance</seealso>
    let wcFlushingSideDistance =
        Prefixed_Name(jup, "wcFlushingSideDistance") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcFlushingSideHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Height of toilet flushing from side in cm</para><para>Vyska umisteni splachovani z boku v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcFlushingSideHeight">http://w3id.org/charta77/jup/wcFlushingSideHeight</seealso>
    let wcFlushingSideHeight =
        Prefixed_Name(jup, "wcFlushingSideHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcHandlesDistance</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Axis distance of handles in cm</para><para>Osova vydalenost madel v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcHandlesDistance">http://w3id.org/charta77/jup/wcHandlesDistance</seealso>
    let wcHandlesDistance = Prefixed_Name(jup, "wcHandlesDistance") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcIsAlarmButton</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Signalizacni tlacitko</para><para>Alarm button</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcIsAlarmButton">http://w3id.org/charta77/jup/wcIsAlarmButton</seealso>
    let wcIsAlarmButton = Prefixed_Name(jup, "wcIsAlarmButton") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcIsChangingDesk</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Prebalovaci pult</para><para>Changing desk</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcIsChangingDesk">http://w3id.org/charta77/jup/wcIsChangingDesk</seealso>
    let wcIsChangingDesk = Prefixed_Name(jup, "wcIsChangingDesk") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcIsChangingDeskObstructs</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Prekazi prebalovaci pult pri obsluze WC</para><para>Changing desk obstructs the use of WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcIsChangingDeskObstructs">http://w3id.org/charta77/jup/wcIsChangingDeskObstructs</seealso>
    let wcIsChangingDeskObstructs =
        Prefixed_Name(jup, "wcIsChangingDeskObstructs") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcIsRegularWC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Regular WC in building</para><para>Bezne WC v budove</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcIsRegularWC">http://w3id.org/charta77/jup/wcIsRegularWC</seealso>
    let wcIsRegularWC = Prefixed_Name(jup, "wcIsRegularWC") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcIsRegularWCBrailleMarking</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Braille marking of regular WC in building</para><para>Oznaceni bezneho WC Braillovym pismem</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcIsRegularWCBrailleMarking">http://w3id.org/charta77/jup/wcIsRegularWCBrailleMarking</seealso>
    let wcIsRegularWCBrailleMarking =
        Prefixed_Name(jup, "wcIsRegularWCBrailleMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcLocalization</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Localization of WC</para><para>Lokalizace WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcLocalization">http://w3id.org/charta77/jup/wcLocalization</seealso>
    let wcLocalization = Prefixed_Name(jup, "wcLocalization") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcRegularWC</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Regular WC in building</para><para>Bezne WC v budove</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcRegularWC">http://w3id.org/charta77/jup/wcRegularWC</seealso>
    let wcRegularWC = Prefixed_Name(jup, "wcRegularWC") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcRegularWCBrailleLabelled</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Braille marking of regular WC in building</para><para>Oznaceni bezneho WC Braillovym pismem</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcRegularWCBrailleLabelled">http://w3id.org/charta77/jup/wcRegularWCBrailleLabelled</seealso>
    let wcRegularWCBrailleLabelled =
        Prefixed_Name(jup, "wcRegularWCBrailleLabelled") |> PrefixedName

    /// <summary>
    ///   <para>jup:wcSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Typ vypinace</para><para>Switch type</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcSwitch">http://w3id.org/charta77/jup/wcSwitch</seealso>
    let wcSwitch = Prefixed_Name(jup, "wcSwitch") |> PrefixedName
    /// <summary>
    ///   <para>jup:RampSkidsMKPOForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:MappableEntityForm</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/RampSkidsMKPOForm">http://w3id.org/charta77/jup/RampSkidsMKPOForm</seealso>
    let RampSkidsMKPOForm = Prefixed_Name(jup, "RampSkidsMKPOForm") |> PrefixedName

    /// <summary>
    ///   <para>jup:FrontWallElevatorCageMirrorLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ElevatorCageMirrorLocalization</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FrontWallElevatorCageMirrorLocalization">http://w3id.org/charta77/jup/FrontWallElevatorCageMirrorLocalization</seealso>
    let FrontWallElevatorCageMirrorLocalization =
        Prefixed_Name(jup, "FrontWallElevatorCageMirrorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:FunerallHallObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FunerallHallObjectCategory">http://w3id.org/charta77/jup/FunerallHallObjectCategory</seealso>
    let FunerallHallObjectCategory =
        Prefixed_Name(jup, "FunerallHallObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:GentsWCCabinLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCCabinLocalization</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/GentsWCCabinLocalization">http://w3id.org/charta77/jup/GentsWCCabinLocalization</seealso>
    let GentsWCCabinLocalization =
        Prefixed_Name(jup, "GentsWCCabinLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:SpiralObjectStairsType</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:StepsStairsType</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SpiralObjectStairsType">http://w3id.org/charta77/jup/SpiralObjectStairsType</seealso>
    let SpiralObjectStairsType =
        Prefixed_Name(jup, "SpiralObjectStairsType") |> PrefixedName

    /// <summary>
    ///   <para>jup:StatelyHomeObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ObjectCategory</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/StatelyHomeObjectCategory">http://w3id.org/charta77/jup/StatelyHomeObjectCategory</seealso>
    let StatelyHomeObjectCategory =
        Prefixed_Name(jup, "StatelyHomeObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:hasDescription</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Verbal section description</para><para>Slovni popis useku</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasDescription">http://w3id.org/charta77/jup/hasDescription</seealso>
    let hasDescription = Prefixed_Name(jup, "hasDescription") |> PrefixedName
    /// <summary>
    ///   <para>jup:hasLongitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Zemepisna delka adresovatelne entity</para><para>Addressable entity longitude</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasLongitude">http://w3id.org/charta77/jup/hasLongitude</seealso>
    let hasLongitude = Prefixed_Name(jup, "hasLongitude") |> PrefixedName
    /// <summary>
    ///   <para>jup:hasPlace</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>http://ruian.linked.opendata.cz/</para>
    ///   <para>http://ruian.linked.opendata.cz/</para>
    /// labels<para>Adresni misto podle RUIAN</para><para>RUIAN address points</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasPlace">http://w3id.org/charta77/jup/hasPlace</seealso>
    let hasPlace = Prefixed_Name(jup, "hasPlace") |> PrefixedName
    /// <summary>
    ///   <para>jup:isCertifiedRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.</para>
    ///   <para>Certifikovana osoba vklada profesionalne (odborne) namerene udaje. K ziskani certifikace je nutne skoleni, zkouska, apod.</para>
    /// labels<para>Zaznam byl vytvoreny certifikovanou osobou</para><para>Entry created by a certified person</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/isCertifiedRecord">http://w3id.org/charta77/jup/isCertifiedRecord</seealso>
    let isCertifiedRecord = Prefixed_Name(jup, "isCertifiedRecord") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcSwitchHeight</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Vyska umisteni vypinace v cm</para><para>Height of switch in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcSwitchHeight">http://w3id.org/charta77/jup/wcSwitchHeight</seealso>
    let wcSwitchHeight = Prefixed_Name(jup, "wcSwitchHeight") |> PrefixedName
    /// <summary>
    ///   <para>jup:WCCabinDisposition</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Dispositions of WC cabin</para><para>Typy dispozic kabiny WC</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCCabinDisposition">http://w3id.org/charta77/jup/WCCabinDisposition</seealso>
    let WCCabinDisposition = Prefixed_Name(jup, "WCCabinDisposition") |> PrefixedName

    /// <summary>
    ///   <para>jup:BreweryObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/BreweryObjectCategory">http://w3id.org/charta77/jup/BreweryObjectCategory</seealso>
    let BreweryObjectCategory =
        Prefixed_Name(jup, "BreweryObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:handleOrientation</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Handle orientation</para><para>Orientace madla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/handleOrientation">http://w3id.org/charta77/jup/handleOrientation</seealso>
    let handleOrientation = Prefixed_Name(jup, "handleOrientation") |> PrefixedName
    /// <summary>
    ///   <para>jup:wcFlushing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Type of flushing</para><para>Typ splachovani</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/wcFlushing">http://w3id.org/charta77/jup/wcFlushing</seealso>
    let wcFlushing = Prefixed_Name(jup, "wcFlushing") |> PrefixedName

    /// <summary>
    ///   <para>jup:FrontElevatorCageSecondDoorLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:ElevatorCageSecondDoorLocalization</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/FrontElevatorCageSecondDoorLocalization">http://w3id.org/charta77/jup/FrontElevatorCageSecondDoorLocalization</seealso>
    let FrontElevatorCageSecondDoorLocalization =
        Prefixed_Name(jup, "FrontElevatorCageSecondDoorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:HandleLocalizationsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Localization of handles scheme</para><para>Schema umisteni madla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/HandleLocalizationsScheme">http://w3id.org/charta77/jup/HandleLocalizationsScheme</seealso>
    let HandleLocalizationsScheme =
        Prefixed_Name(jup, "HandleLocalizationsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:GasStationObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/GasStationObjectCategory">http://w3id.org/charta77/jup/GasStationObjectCategory</seealso>
    let GasStationObjectCategory =
        Prefixed_Name(jup, "GasStationObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:SpaHouseObjectCategory</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:ObjectCategory</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/SpaHouseObjectCategory">http://w3id.org/charta77/jup/SpaHouseObjectCategory</seealso>
    let SpaHouseObjectCategory =
        Prefixed_Name(jup, "SpaHouseObjectCategory") |> PrefixedName

    /// <summary>
    ///   <para>jup:entryAreaIsEntryClosing</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>closing (doors, barriers) of entry area</para><para>Zavirani (dvirka, zabrana) vstupu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entryAreaIsEntryClosing">http://w3id.org/charta77/jup/entryAreaIsEntryClosing</seealso>
    let entryAreaIsEntryClosing =
        Prefixed_Name(jup, "entryAreaIsEntryClosing") |> PrefixedName

    /// <summary>
    ///   <para>jup:entryAreaWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Sirka nastupni plochy v cm</para><para>Width of entry area in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/entryAreaWidth">http://w3id.org/charta77/jup/entryAreaWidth</seealso>
    let entryAreaWidth = Prefixed_Name(jup, "entryAreaWidth") |> PrefixedName
    /// <summary>
    ///   <para>jup:hallwayDepth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Depth of hallway in cm</para><para>Hloubka predsine v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hallwayDepth">http://w3id.org/charta77/jup/hallwayDepth</seealso>
    let hallwayDepth = Prefixed_Name(jup, "hallwayDepth") |> PrefixedName
    /// <summary>
    ///   <para>jup:handleLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Handle localization</para><para>Umisteni madla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/handleLocalization">http://w3id.org/charta77/jup/handleLocalization</seealso>
    let handleLocalization = Prefixed_Name(jup, "handleLocalization") |> PrefixedName
    /// <summary>
    ///   <para>jup:handlePosition</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Handle position</para><para>Pozice madla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/handlePosition">http://w3id.org/charta77/jup/handlePosition</seealso>
    let handlePosition = Prefixed_Name(jup, "handlePosition") |> PrefixedName
    /// <summary>
    ///   <para>jup:handleType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Handle type</para><para>Typ madla</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/handleType">http://w3id.org/charta77/jup/handleType</seealso>
    let handleType = Prefixed_Name(jup, "handleType") |> PrefixedName
    /// <summary>
    ///   <para>jup:hasAttachment</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Pro uplnost slovniku</para>
    ///   <para>To complete the vocabulary</para>
    /// labels<para>Attachment</para><para>Priloha</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasAttachment">http://w3id.org/charta77/jup/hasAttachment</seealso>
    let hasAttachment = Prefixed_Name(jup, "hasAttachment") |> PrefixedName
    /// <summary>
    ///   <para>jup:hasIdentifier</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>e.g. for IC organizations</para>
    ///   <para>napr. pro organizace IC</para>
    /// labels<para>Jednoznacny identifikator v danem kontextu</para><para>Unique ID in the particular context</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasIdentifier">http://w3id.org/charta77/jup/hasIdentifier</seealso>
    let hasIdentifier = Prefixed_Name(jup, "hasIdentifier") |> PrefixedName
    /// <summary>
    ///   <para>jup:hasLatitude</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Zemepisna sirka adresovatelne entity</para><para>Addressable entity latitude</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasLatitude">http://w3id.org/charta77/jup/hasLatitude</seealso>
    let hasLatitude = Prefixed_Name(jup, "hasLatitude") |> PrefixedName
    /// <summary>
    ///   <para>jup:hasName</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Oficialni nazev</para><para>Official name</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasName">http://w3id.org/charta77/jup/hasName</seealso>
    let hasName = Prefixed_Name(jup, "hasName") |> PrefixedName
    /// <summary>
    ///   <para>jup:hasNotes</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Upravene WC: spatne ukotveni madel, madlo kotvene na bocni stene,...</para>
    ///   <para>Adapted WC: poor anchorage of handles, handle attached to side wall,...</para>
    /// labels<para>Poznamky k mapovatelne entite</para><para>Mappable entity notes</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasNotes">http://w3id.org/charta77/jup/hasNotes</seealso>
    let hasNotes = Prefixed_Name(jup, "hasNotes") |> PrefixedName
    /// <summary>
    ///   <para>jup:hasPart</para>
    /// </summary>
    /// <remarks>
    ///
    /// labels<para>Mappable entities relationship</para><para>Vztah mapovatelnych entit</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasPart">http://w3id.org/charta77/jup/hasPart</seealso>
    let hasPart = Prefixed_Name(jup, "hasPart") |> PrefixedName
    /// <summary>
    ///   <para>jup:hasSummary</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>Strucny, pro laiky srozumitelny, formatovany text shrnujici udaje z formularu</para>
    ///   <para>Short and formated description summarizing form data, understandable to the wide public</para>
    /// labels<para>Text desciption of an object</para><para>Textovy popis objektu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/hasSummary">http://w3id.org/charta77/jup/hasSummary</seealso>
    let hasSummary = Prefixed_Name(jup, "hasSummary") |> PrefixedName
    /// <summary>
    ///   <para>jup:isUpToDateRecord</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>Older entries describing the same mappable entity are assigned the false value.</para>
    ///   <para>Starsi zaznamy o stejne mapovatelne entite maji nastaveny priznak na false</para>
    /// labels<para>Aktualni zaznam</para><para>Current entry</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/isUpToDateRecord">http://w3id.org/charta77/jup/isUpToDateRecord</seealso>
    let isUpToDateRecord = Prefixed_Name(jup, "isUpToDateRecord") |> PrefixedName
    /// <summary>
    ///   <para>jup:license</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///   <para>To complete the vocabulary</para>
    ///   <para>Pro uplnost slovniku</para>
    /// labels<para>Licence, pod kterou jsou data o mapovatelne entite uvolnena</para><para>Open licence to mappable entity data</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/license">http://w3id.org/charta77/jup/license</seealso>
    let license = Prefixed_Name(jup, "license") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityAccess</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Access to the mappable entity</para><para>Pristup k mapovatelne entite</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityAccess">http://w3id.org/charta77/jup/mappableEntityAccess</seealso>
    let mappableEntityAccess =
        Prefixed_Name(jup, "mappableEntityAccess") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityAccessProvidedBy</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Access to entrance to the mappable entity provided by</para><para>Pristup ke vstupu mapovatelne entity zajisti</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityAccessProvidedBy">http://w3id.org/charta77/jup/mappableEntityAccessProvidedBy</seealso>
    let mappableEntityAccessProvidedBy =
        Prefixed_Name(jup, "mappableEntityAccessProvidedBy") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityAccessibility</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Pristupnost mapovatelne entity</para><para>Mappable entity accessibility</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityAccessibility">http://w3id.org/charta77/jup/mappableEntityAccessibility</seealso>
    let mappableEntityAccessibility =
        Prefixed_Name(jup, "mappableEntityAccessibility") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityIsBrailleMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Oznaceni Braillovym pismem</para><para>Braille labelling</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityIsBrailleMarking">http://w3id.org/charta77/jup/mappableEntityIsBrailleMarking</seealso>
    let mappableEntityIsBrailleMarking =
        Prefixed_Name(jup, "mappableEntityIsBrailleMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityIsContrastMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Kontrastni znaceni</para><para>Contrast marking</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityIsContrastMarking">http://w3id.org/charta77/jup/mappableEntityIsContrastMarking</seealso>
    let mappableEntityIsContrastMarking =
        Prefixed_Name(jup, "mappableEntityIsContrastMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdf:Property</para>
    ///
    /// labels<para>Localization of mappable entity</para><para>Lokalizace mapovatelne entity</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityLocalization">http://w3id.org/charta77/jup/mappableEntityLocalization</seealso>
    let mappableEntityLocalization =
        Prefixed_Name(jup, "mappableEntityLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityMirrorHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska umisteni spodni hrany zrcadla v cm</para><para>Lower mirror edge height in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityMirrorHeight">http://w3id.org/charta77/jup/mappableEntityMirrorHeight</seealso>
    let mappableEntityMirrorHeight =
        Prefixed_Name(jup, "mappableEntityMirrorHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityPassageWidth</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Passage width in cm</para><para>Sirka pruchodu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityPassageWidth">http://w3id.org/charta77/jup/mappableEntityPassageWidth</seealso>
    let mappableEntityPassageWidth =
        Prefixed_Name(jup, "mappableEntityPassageWidth") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntitySwitchHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Switch placement height in cm</para><para>Vyska umisteni vypinace v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntitySwitchHeight">http://w3id.org/charta77/jup/mappableEntitySwitchHeight</seealso>
    let mappableEntitySwitchHeight =
        Prefixed_Name(jup, "mappableEntitySwitchHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:mappableEntityThresholdHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Threshold height in cm</para><para>Vyska prahu v cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mappableEntityThresholdHeight">http://w3id.org/charta77/jup/mappableEntityThresholdHeight</seealso>
    let mappableEntityThresholdHeight =
        Prefixed_Name(jup, "mappableEntityThresholdHeight") |> PrefixedName

    /// <summary>
    ///   <para>jup:mapperCertified</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///   <para>A certified person enters professionally taken data. To become a certified person a special training, examination etc. is required.</para>
    ///   <para>Certifikovana osoba vklada profesionalne (odborne) namerene udaje. K ziskani certifikace je nutne skoleni, zkouska, apod.</para>
    /// labels<para>Cerifikovana osoba</para><para>Certified person</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/mapperCertified">http://w3id.org/charta77/jup/mapperCertified</seealso>
    let mapperCertified = Prefixed_Name(jup, "mapperCertified") |> PrefixedName

    /// <summary>
    ///   <para>jup:EntranceGuidingLinesScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Guiding line scheme</para><para>Schema vodici linie</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/EntranceGuidingLinesScheme">http://w3id.org/charta77/jup/EntranceGuidingLinesScheme</seealso>
    let EntranceGuidingLinesScheme =
        Prefixed_Name(jup, "EntranceGuidingLinesScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:AutomaticDoorOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:DoorOpening</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AutomaticDoorOpening">http://w3id.org/charta77/jup/AutomaticDoorOpening</seealso>
    let AutomaticDoorOpening =
        Prefixed_Name(jup, "AutomaticDoorOpening") |> PrefixedName

    /// <summary>
    ///   <para>jup:DoorOpening</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Typy otevirani dveri</para><para>Door openings types</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/DoorOpening">http://w3id.org/charta77/jup/DoorOpening</seealso>
    let DoorOpening = Prefixed_Name(jup, "DoorOpening") |> PrefixedName
    /// <summary>
    ///   <para>jup:AutomaticWCFlushing</para>
    /// </summary>
    /// <remarks>
    ///   <para>jup:WCFlushing</para>
    ///   <para>skos:Concept</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AutomaticWCFlushing">http://w3id.org/charta77/jup/AutomaticWCFlushing</seealso>
    let AutomaticWCFlushing = Prefixed_Name(jup, "AutomaticWCFlushing") |> PrefixedName
    /// <summary>
    ///   <para>jup:AutomaticWCSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:Concept</para>
    ///   <para>jup:WCSwitch</para>
    /// </remarks>
    /// <seealso href="http://w3id.org/charta77/jup/AutomaticWCSwitch">http://w3id.org/charta77/jup/AutomaticWCSwitch</seealso>
    let AutomaticWCSwitch = Prefixed_Name(jup, "AutomaticWCSwitch") |> PrefixedName
    /// <summary>
    ///   <para>jup:WCSwitch</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Types of WC switches</para><para>Typy vypinace</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/WCSwitch">http://w3id.org/charta77/jup/WCSwitch</seealso>
    let WCSwitch = Prefixed_Name(jup, "WCSwitch") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorCageSecondDoorLocalization</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Types of second door placement in pass-through cage</para><para>Typy umisteni druhych dveri pruchozi klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorCageSecondDoorLocalization">http://w3id.org/charta77/jup/ElevatorCageSecondDoorLocalization</seealso>
    let ElevatorCageSecondDoorLocalization =
        Prefixed_Name(jup, "ElevatorCageSecondDoorLocalization") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorCageSecondDoorLocalizationsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Scheme for types of second door placement in pass-through cage</para><para>Schema typu umisteni druhych dveri pruchozi klece</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorCageSecondDoorLocalizationsScheme">http://w3id.org/charta77/jup/ElevatorCageSecondDoorLocalizationsScheme</seealso>
    let ElevatorCageSecondDoorLocalizationsScheme =
        Prefixed_Name(jup, "ElevatorCageSecondDoorLocalizationsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorControlReliefMarking</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    /// labels<para>Typy reliefu oznaceni ovladace vytahu</para><para>Types of elevator control reliefs</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorControlReliefMarking">http://w3id.org/charta77/jup/ElevatorControlReliefMarking</seealso>
    let ElevatorControlReliefMarking =
        Prefixed_Name(jup, "ElevatorControlReliefMarking") |> PrefixedName

    /// <summary>
    ///   <para>jup:ElevatorDriveOff</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///   <para>Vycet prevzat z formularu dle Metodiky Kategorizace Pristupnosti Objektu</para>
    ///   <para>The list copied from the form based on Object Accessibility Categorization Methodology</para>
    /// labels<para>Types of elevator drive-offs</para><para>Typy dojezdu vytahu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/ElevatorDriveOff">http://w3id.org/charta77/jup/ElevatorDriveOff</seealso>
    let ElevatorDriveOff = Prefixed_Name(jup, "ElevatorDriveOff") |> PrefixedName
    /// <summary>
    ///   <para>jup:MappableEntityForm</para>
    /// </summary>
    /// <remarks>
    ///   <para>rdfs:Class</para>
    ///
    /// labels<para>Formulare mapujici entity</para><para>Forms mapping entities</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MappableEntityForm">http://w3id.org/charta77/jup/MappableEntityForm</seealso>
    let MappableEntityForm = Prefixed_Name(jup, "MappableEntityForm") |> PrefixedName

    /// <summary>
    ///   <para>jup:MappableEntityMKPOFormsScheme</para>
    /// </summary>
    /// <remarks>
    ///   <para>skos:ConceptScheme</para>
    ///
    /// labels<para>A scheme for Object Accessibility Categorization Methodology forms</para><para>Schema pro formulare Metodiky Kategorizace Pristupnosti Objektu</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/MappableEntityMKPOFormsScheme">http://w3id.org/charta77/jup/MappableEntityMKPOFormsScheme</seealso>
    let MappableEntityMKPOFormsScheme =
        Prefixed_Name(jup, "MappableEntityMKPOFormsScheme") |> PrefixedName

    /// <summary>
    ///   <para>jup:tapHeight</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Vyska umisteni baterie od podlahy v cm</para><para>Height of tap in cm</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/tapHeight">http://w3id.org/charta77/jup/tapHeight</seealso>
    let tapHeight = Prefixed_Name(jup, "tapHeight") |> PrefixedName
    /// <summary>
    ///   <para>jup:tapType</para>
    /// </summary>
    /// <remarks>
    ///   <para>owl:FunctionalProperty</para>
    ///
    /// labels<para>Typ baterie</para><para>Type of tap</para></remarks>
    /// <seealso href="http://w3id.org/charta77/jup/tapType">http://w3id.org/charta77/jup/tapType</seealso>
    let tapType = Prefixed_Name(jup, "tapType") |> PrefixedName
